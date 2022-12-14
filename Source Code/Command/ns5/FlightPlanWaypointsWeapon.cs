using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns12;
using ns4;

namespace ns5
{
	// Token: 0x02000D7A RID: 3450
	[DesignerGenerated]
	internal sealed class FlightPlanWaypointsWeapon : UserControl
	{
		// Token: 0x06005B36 RID: 23350 RVA: 0x0003ABD3 File Offset: 0x00038DD3
		public FlightPlanWaypointsWeapon()
		{
			this.InitializeComponent();
		}

		// Token: 0x06005B37 RID: 23351 RVA: 0x003254C4 File Offset: 0x003236C4
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06005B38 RID: 23352 RVA: 0x00325504 File Offset: 0x00323704
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
			this.vmethod_3(new Button());
			this.vmethod_5(new Button());
			this.vmethod_7(new Button());
			this.vmethod_9(new Button());
			this.vmethod_11(new Button());
			this.vmethod_1(new Class2422());
			this.vmethod_13(new DataGridViewTextBoxColumn());
			this.vmethod_15(new DataGridViewTextBoxColumn());
			this.vmethod_17(new DataGridViewComboBoxColumn());
			this.vmethod_19(new DataGridViewTextBoxColumn());
			this.vmethod_21(new DataGridViewTextBoxColumn());
			this.vmethod_23(new DataGridViewImageColumn());
			this.vmethod_25(new DataGridViewTextBoxColumn());
			this.vmethod_27(new DataGridViewTextBoxColumn());
			this.vmethod_29(new DataGridViewImageColumn());
			this.vmethod_31(new DataGridViewTextBoxColumn());
			this.vmethod_33(new DataGridViewTextBoxColumn());
			this.vmethod_35(new DataGridViewTextBoxColumn());
			this.vmethod_37(new DataGridViewTextBoxColumn());
			this.vmethod_39(new DataGridViewTextBoxColumn());
			this.vmethod_41(new DataGridViewTextBoxColumn());
			this.vmethod_43(new DataGridViewTextBoxColumn());
			this.vmethod_45(new DataGridViewTextBoxColumn());
			this.vmethod_47(new DataGridViewTextBoxColumn());
			this.vmethod_49(new DataGridViewTextBoxColumn());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_2().Location = new Point(423, 312);
			this.vmethod_2().Name = "Button_ClearTime";
			this.vmethod_2().Size = new Size(70, 24);
			this.vmethod_2().TabIndex = 26;
			this.vmethod_2().Text = "Clear Time";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_4().Location = new Point(191, 312);
			this.vmethod_4().Name = "Button_EditSpeedAltitude";
			this.vmethod_4().Size = new Size(115, 24);
			this.vmethod_4().TabIndex = 25;
			this.vmethod_4().Text = "Edit Speed / Altitude";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().Location = new Point(307, 312);
			this.vmethod_6().Name = "Button_EditTime";
			this.vmethod_6().Size = new Size(115, 24);
			this.vmethod_6().TabIndex = 24;
			this.vmethod_6().Text = "Edit Time";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_8().Location = new Point(95, 312);
			this.vmethod_8().Name = "Button_DeleteWaypoint";
			this.vmethod_8().Size = new Size(95, 24);
			this.vmethod_8().TabIndex = 23;
			this.vmethod_8().Text = "Delete Waypoint";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_10().Location = new Point(-1, 312);
			this.vmethod_10().Name = "Button_InsertWaypoint";
			this.vmethod_10().Size = new Size(95, 24);
			this.vmethod_10().TabIndex = 22;
			this.vmethod_10().Text = "Insert Waypoint";
			this.vmethod_10().UseVisualStyleBackColor = true;
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToResizeColumns = false;
			this.vmethod_0().AllowUserToResizeRows = false;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().ColumnHeadersHeight = 18;
			this.vmethod_0().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_12(),
				this.vmethod_14(),
				this.vmethod_16(),
				this.vmethod_18(),
				this.vmethod_20(),
				this.vmethod_22(),
				this.vmethod_24(),
				this.vmethod_26(),
				this.vmethod_28(),
				this.vmethod_30(),
				this.vmethod_32(),
				this.vmethod_34(),
				this.vmethod_36(),
				this.vmethod_38(),
				this.vmethod_40(),
				this.vmethod_42(),
				this.vmethod_44(),
				this.vmethod_46(),
				this.vmethod_48()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "DGV_WaypointsWeapon";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().RowHeadersWidth = 10;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new Size(492, 280);
			this.vmethod_0().TabIndex = 11;
			this.vmethod_12().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.vmethod_12().DataPropertyName = "ID";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_12().DefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_12().Frozen = true;
			this.vmethod_12().HeaderText = "#";
			this.vmethod_12().Name = "ID";
			this.vmethod_12().ReadOnly = true;
			this.vmethod_12().Width = 5;
			this.vmethod_14().DataPropertyName = "ObjectID";
			this.vmethod_14().HeaderText = "ObjectID";
			this.vmethod_14().Name = "ObjectID";
			this.vmethod_14().Visible = false;
			this.vmethod_16().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_16().DataPropertyName = "Type";
			this.vmethod_16().Frozen = true;
			this.vmethod_16().HeaderText = "Type";
			this.vmethod_16().Name = "Type";
			this.vmethod_16().Resizable = DataGridViewTriState.True;
			this.vmethod_16().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_16().Width = 54;
			this.vmethod_18().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_18().DataPropertyName = "Time_Zulu";
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.BottomCenter;
			this.vmethod_18().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_18().HeaderText = "Zulu Time";
			this.vmethod_18().Name = "Time_Zulu";
			this.vmethod_18().ReadOnly = true;
			this.vmethod_18().Width = 77;
			this.vmethod_20().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_20().DataPropertyName = "Time_Local";
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.BottomCenter;
			this.vmethod_20().DefaultCellStyle = dataGridViewCellStyle6;
			this.vmethod_20().HeaderText = "Local Time";
			this.vmethod_20().Name = "Time_Local";
			this.vmethod_20().ReadOnly = true;
			this.vmethod_20().Width = 82;
			this.vmethod_22().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.vmethod_22().DataPropertyName = "TimeFixedImg";
			this.vmethod_22().HeaderText = " ";
			this.vmethod_22().Name = "TimeFixedImg";
			this.vmethod_22().Width = 5;
			this.vmethod_24().DataPropertyName = "TimeFixed";
			this.vmethod_24().HeaderText = "TimeFixed";
			this.vmethod_24().Name = "TimeFixed";
			this.vmethod_24().Resizable = DataGridViewTriState.True;
			this.vmethod_24().Visible = false;
			this.vmethod_24().Width = 5;
			this.vmethod_26().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_26().DataPropertyName = "DesiredSpeed";
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_26().DefaultCellStyle = dataGridViewCellStyle7;
			this.vmethod_26().HeaderText = " Speed";
			this.vmethod_26().Name = "DesiredSpeed";
			this.vmethod_26().ReadOnly = true;
			this.vmethod_26().Width = 64;
			this.vmethod_28().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.vmethod_28().DataPropertyName = "SpeedFixedImg";
			this.vmethod_28().HeaderText = " ";
			this.vmethod_28().Name = "SpeedFixedImg";
			this.vmethod_28().Width = 5;
			this.vmethod_30().DataPropertyName = "SpeedFixed";
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_30().DefaultCellStyle = dataGridViewCellStyle8;
			this.vmethod_30().HeaderText = "SpeedFixed";
			this.vmethod_30().Name = "SpeedFixed";
			this.vmethod_30().Resizable = DataGridViewTriState.True;
			this.vmethod_30().Visible = false;
			this.vmethod_30().Width = 5;
			this.vmethod_32().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_32().DataPropertyName = "DesiredAltitude";
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_32().DefaultCellStyle = dataGridViewCellStyle9;
			this.vmethod_32().HeaderText = "Altitude";
			this.vmethod_32().Name = "DesiredAltitude";
			this.vmethod_32().ReadOnly = true;
			this.vmethod_32().Width = 65;
			this.vmethod_34().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_34().DataPropertyName = "Leg_Distance";
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_34().DefaultCellStyle = dataGridViewCellStyle10;
			this.vmethod_34().HeaderText = "Leg Distance";
			this.vmethod_34().Name = "Leg_Distance";
			this.vmethod_34().Width = 93;
			this.vmethod_36().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_36().DataPropertyName = "Leg_TotalDistance";
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_36().DefaultCellStyle = dataGridViewCellStyle11;
			this.vmethod_36().HeaderText = "Total Distance";
			this.vmethod_36().Name = "Leg_TotalDistance";
			this.vmethod_36().Width = 99;
			this.vmethod_38().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_38().DataPropertyName = "Leg_Time";
			dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_38().DefaultCellStyle = dataGridViewCellStyle12;
			this.vmethod_38().HeaderText = "Leg Time";
			this.vmethod_38().Name = "Leg_Time";
			this.vmethod_38().ToolTipText = "Time needed to fly this leg.";
			this.vmethod_38().Width = 74;
			this.vmethod_40().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_40().DataPropertyName = "Hold_Time";
			dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_40().DefaultCellStyle = dataGridViewCellStyle13;
			this.vmethod_40().HeaderText = "Hold Time";
			this.vmethod_40().Name = "Hold_Time";
			this.vmethod_40().ToolTipText = "Loiter time at waypoint to allow flight to form up (Push Point).";
			this.vmethod_40().Width = 78;
			this.vmethod_42().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_42().DataPropertyName = "Leg_TotalTime";
			dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_42().DefaultCellStyle = dataGridViewCellStyle14;
			this.vmethod_42().HeaderText = "Total Time";
			this.vmethod_42().Name = "Leg_TotalTime";
			this.vmethod_42().Width = 80;
			this.vmethod_44().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_44().DataPropertyName = "Leg_FuelRequired";
			dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_44().DefaultCellStyle = dataGridViewCellStyle15;
			this.vmethod_44().HeaderText = "Leg Fuel";
			this.vmethod_44().Name = "Leg_FuelRequired";
			this.vmethod_44().ToolTipText = "Fuel neeed to fly this leg.";
			this.vmethod_44().Width = 71;
			this.vmethod_46().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_46().DataPropertyName = "Leg_FuelRemaining";
			dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_46().DefaultCellStyle = dataGridViewCellStyle16;
			this.vmethod_46().HeaderText = "Remaining Fuel";
			this.vmethod_46().Name = "Leg_FuelRemaining";
			this.vmethod_46().ToolTipText = "Remaining mission fuel (i.e. total fuel minus reserves) after this leg has been completed.";
			this.vmethod_46().Width = 103;
			this.vmethod_48().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_48().DataPropertyName = "Coordinates";
			this.vmethod_48().HeaderText = "Coordinates";
			this.vmethod_48().Name = "Coordinates";
			this.vmethod_48().Width = 86;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_0());
			base.Name = "FlightPlanWaypointsWeapon";
			base.Size = new Size(492, 352);
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06005B39 RID: 23353 RVA: 0x0003ABE1 File Offset: 0x00038DE1
		[CompilerGenerated]
		internal Class2422 vmethod_0()
		{
			return this.class2422_0;
		}

		// Token: 0x06005B3A RID: 23354 RVA: 0x0032637C File Offset: 0x0032457C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class2422 class2422_1)
		{
			DataGridViewCellPaintingEventHandler value = new DataGridViewCellPaintingEventHandler(this.method_4);
			DataGridViewColumnEventHandler value2 = new DataGridViewColumnEventHandler(this.method_5);
			PaintEventHandler value3 = new PaintEventHandler(this.method_6);
			ScrollEventHandler value4 = new ScrollEventHandler(this.method_7);
			EventHandler value5 = new EventHandler(this.method_8);
			EventHandler value6 = new EventHandler(this.method_9);
			EventHandler value7 = new EventHandler(this.method_10);
			DataGridViewCellEventHandler value8 = new DataGridViewCellEventHandler(this.method_14);
			DataGridViewCellEventHandler value9 = new DataGridViewCellEventHandler(this.method_15);
			EventHandler value10 = new EventHandler(this.method_16);
			EventHandler value11 = new EventHandler(this.method_18);
			Class2422 @class = this.class2422_0;
			if (@class != null)
			{
				@class.CellPainting -= value;
				@class.ColumnWidthChanged -= value2;
				@class.Paint -= value3;
				@class.Scroll -= value4;
				@class.MouseHover -= value5;
				@class.Enter -= value6;
				@class.SelectionChanged -= value7;
				@class.CellClick -= value8;
				@class.CellValueChanged -= value9;
				@class.CurrentCellDirtyStateChanged -= value10;
				@class.SelectionChanged -= value11;
			}
			this.class2422_0 = class2422_1;
			@class = this.class2422_0;
			if (@class != null)
			{
				@class.CellPainting += value;
				@class.ColumnWidthChanged += value2;
				@class.Paint += value3;
				@class.Scroll += value4;
				@class.MouseHover += value5;
				@class.Enter += value6;
				@class.SelectionChanged += value7;
				@class.CellClick += value8;
				@class.CellValueChanged += value9;
				@class.CurrentCellDirtyStateChanged += value10;
				@class.SelectionChanged += value11;
			}
		}

		// Token: 0x06005B3B RID: 23355 RVA: 0x0003ABE9 File Offset: 0x00038DE9
		[CompilerGenerated]
		internal Button vmethod_2()
		{
			return this.button_0;
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x003264FC File Offset: 0x003246FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_19);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_5;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005B3D RID: 23357 RVA: 0x0003ABF1 File Offset: 0x00038DF1
		[CompilerGenerated]
		internal Button vmethod_4()
		{
			return this.button_1;
		}

		// Token: 0x06005B3E RID: 23358 RVA: 0x00326540 File Offset: 0x00324740
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_3);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_5;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005B3F RID: 23359 RVA: 0x0003ABF9 File Offset: 0x00038DF9
		[CompilerGenerated]
		internal Button vmethod_6()
		{
			return this.button_2;
		}

		// Token: 0x06005B40 RID: 23360 RVA: 0x00326584 File Offset: 0x00324784
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_2);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_5;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005B41 RID: 23361 RVA: 0x0003AC01 File Offset: 0x00038E01
		[CompilerGenerated]
		internal Button vmethod_8()
		{
			return this.button_3;
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x003265C8 File Offset: 0x003247C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_1);
			Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_5;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005B43 RID: 23363 RVA: 0x0003AC09 File Offset: 0x00038E09
		[CompilerGenerated]
		internal Button vmethod_10()
		{
			return this.button_4;
		}

		// Token: 0x06005B44 RID: 23364 RVA: 0x0032660C File Offset: 0x0032480C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_0);
			Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_5;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x0003AC11 File Offset: 0x00038E11
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_12()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x0003AC19 File Offset: 0x00038E19
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x0003AC22 File Offset: 0x00038E22
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_14()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x0003AC2A File Offset: 0x00038E2A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x0003AC33 File Offset: 0x00038E33
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_16()
		{
			return this.dataGridViewComboBoxColumn_0;
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x0003AC3B File Offset: 0x00038E3B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1)
		{
			this.dataGridViewComboBoxColumn_0 = dataGridViewComboBoxColumn_1;
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x0003AC44 File Offset: 0x00038E44
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_18()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x0003AC4C File Offset: 0x00038E4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x0003AC55 File Offset: 0x00038E55
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_20()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x0003AC5D File Offset: 0x00038E5D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B4F RID: 23375 RVA: 0x0003AC66 File Offset: 0x00038E66
		[CompilerGenerated]
		internal DataGridViewImageColumn vmethod_22()
		{
			return this.dataGridViewImageColumn_0;
		}

		// Token: 0x06005B50 RID: 23376 RVA: 0x0003AC6E File Offset: 0x00038E6E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewImageColumn dataGridViewImageColumn_2)
		{
			this.dataGridViewImageColumn_0 = dataGridViewImageColumn_2;
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x0003AC77 File Offset: 0x00038E77
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_24()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06005B52 RID: 23378 RVA: 0x0003AC7F File Offset: 0x00038E7F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x0003AC88 File Offset: 0x00038E88
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_26()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x0003AC90 File Offset: 0x00038E90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B55 RID: 23381 RVA: 0x0003AC99 File Offset: 0x00038E99
		[CompilerGenerated]
		internal DataGridViewImageColumn vmethod_28()
		{
			return this.dataGridViewImageColumn_1;
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x0003ACA1 File Offset: 0x00038EA1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(DataGridViewImageColumn dataGridViewImageColumn_2)
		{
			this.dataGridViewImageColumn_1 = dataGridViewImageColumn_2;
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x0003ACAA File Offset: 0x00038EAA
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_30()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06005B58 RID: 23384 RVA: 0x0003ACB2 File Offset: 0x00038EB2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x0003ACBB File Offset: 0x00038EBB
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_32()
		{
			return this.dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06005B5A RID: 23386 RVA: 0x0003ACC3 File Offset: 0x00038EC3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x0003ACCC File Offset: 0x00038ECC
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_34()
		{
			return this.dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x0003ACD4 File Offset: 0x00038ED4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_8 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x0003ACDD File Offset: 0x00038EDD
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_36()
		{
			return this.dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x0003ACE5 File Offset: 0x00038EE5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_9 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x0003ACEE File Offset: 0x00038EEE
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_38()
		{
			return this.dataGridViewTextBoxColumn_10;
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x0003ACF6 File Offset: 0x00038EF6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_10 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x0003ACFF File Offset: 0x00038EFF
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_40()
		{
			return this.dataGridViewTextBoxColumn_11;
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x0003AD07 File Offset: 0x00038F07
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_11 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x0003AD10 File Offset: 0x00038F10
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_42()
		{
			return this.dataGridViewTextBoxColumn_12;
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x0003AD18 File Offset: 0x00038F18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_12 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B65 RID: 23397 RVA: 0x0003AD21 File Offset: 0x00038F21
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_44()
		{
			return this.dataGridViewTextBoxColumn_13;
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x0003AD29 File Offset: 0x00038F29
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_13 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B67 RID: 23399 RVA: 0x0003AD32 File Offset: 0x00038F32
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_46()
		{
			return this.dataGridViewTextBoxColumn_14;
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x0003AD3A File Offset: 0x00038F3A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_14 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x0003AD43 File Offset: 0x00038F43
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_48()
		{
			return this.dataGridViewTextBoxColumn_15;
		}

		// Token: 0x06005B6A RID: 23402 RVA: 0x0003AD4B File Offset: 0x00038F4B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16)
		{
			this.dataGridViewTextBoxColumn_15 = dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x00326650 File Offset: 0x00324850
		private void method_0(object sender, EventArgs e)
		{
			try
			{
				bool flag = false;
				int count = this.vmethod_0().Rows.Count;
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataGridViewRow dataGridViewRow = this.vmethod_0().Rows[i];
					if (dataGridViewRow.Selected)
					{
						Waypoint waypoint = (Waypoint)dataGridViewRow.Tag;
						if (waypoint.method_40() || waypoint.method_42())
						{
							Interaction.MsgBox("Cannot insert a new waypoint between Start and End Station waypoints!", MsgBoxStyle.OkOnly, null);
						}
						else
						{
							if (waypoint.method_22())
							{
								Interaction.MsgBox("Cannot insert waypoints with Split formation. Change the formation and try again.", MsgBoxStyle.OkOnly, null);
								return;
							}
							Waypoint.WaypointType waypointType_;
							switch (waypoint.waypointType_0)
							{
							case Waypoint.WaypointType.ManualPlottedCourseWaypoint:
								waypointType_ = Waypoint.WaypointType.ManualPlottedCourseWaypoint;
								goto IL_13C;
							case Waypoint.WaypointType.PatrolStation:
							case Waypoint.WaypointType.Assemble:
							case Waypoint.WaypointType.LandingMarshal:
							case Waypoint.WaypointType.Refuel:
							case Waypoint.WaypointType.TakeOff:
							case Waypoint.WaypointType.Marshal:
							case Waypoint.WaypointType.Land:
							case Waypoint.WaypointType.StationStart_Racetrack:
							case Waypoint.WaypointType.StationStart_FigureEight:
							case Waypoint.WaypointType.StationStart_Area:
							case Waypoint.WaypointType.StationStart_RaceTrackRandom:
							case Waypoint.WaypointType.StationEnd:
							case Waypoint.WaypointType.HoldStart:
							case Waypoint.WaypointType.HoldEnd:
								waypointType_ = Waypoint.WaypointType.TurningPoint;
								goto IL_13C;
							case Waypoint.WaypointType.TurningPoint:
								waypointType_ = Waypoint.WaypointType.TurningPoint;
								goto IL_13C;
							case Waypoint.WaypointType.InitialPoint:
							case Waypoint.WaypointType.Split:
							case Waypoint.WaypointType.WeaponLaunch:
								waypointType_ = Waypoint.WaypointType.StrikeIngress;
								goto IL_13C;
							case Waypoint.WaypointType.Formate:
							case Waypoint.WaypointType.Target:
							case Waypoint.WaypointType.WeaponTarget:
								waypointType_ = Waypoint.WaypointType.StrikeEgress;
								goto IL_13C;
							case Waypoint.WaypointType.StrikeIngress:
								waypointType_ = Waypoint.WaypointType.StrikeIngress;
								goto IL_13C;
							case Waypoint.WaypointType.StrikeEgress:
								waypointType_ = Waypoint.WaypointType.StrikeEgress;
								goto IL_13C;
							}
							waypointType_ = Waypoint.WaypointType.ManualPlottedCourseWaypoint;
							IL_13C:
							GeoPoint geoPoint = new GeoPoint();
							GeoPoint geoPoint2 = new GeoPoint();
							GeoPoint geoPoint3 = new GeoPoint();
							GeoPoint geoPoint4 = new GeoPoint();
							GeoPoint geoPoint5 = new GeoPoint();
							GeoPoint geoPoint6 = new GeoPoint();
							if (i + 1 <= count - 1)
							{
								Waypoint waypoint2 = Client.smethod_25().waypoint_0[i + 1];
								double double_ = (double)Math2.smethod_17(waypoint.imethod_2(), waypoint.imethod_0(), waypoint2.imethod_2(), waypoint2.imethod_0());
								double num2 = (double)Math2.smethod_15(waypoint.imethod_2(), waypoint.imethod_0(), waypoint2.imethod_2(), waypoint2.imethod_0());
								double double_2 = waypoint.imethod_0();
								double double_3 = waypoint.imethod_2();
								GeoPoint geoPoint7;
								double double_4 = (geoPoint7 = geoPoint).imethod_0();
								GeoPoint geoPoint8;
								double double_5 = (geoPoint8 = geoPoint).imethod_2();
								Class411.smethod_1(double_2, double_3, ref double_4, ref double_5, num2 / 2.0, Math2.smethod_6(double_));
								geoPoint8.imethod_3(double_5);
								geoPoint7.imethod_1(double_4);
								if (!Information.IsNothing(waypoint.waypoint_0))
								{
									Waypoint waypoint_ = waypoint.waypoint_0;
									Waypoint waypoint3;
									if (Information.IsNothing(waypoint2.waypoint_0))
									{
										waypoint3 = waypoint2;
									}
									else
									{
										waypoint3 = waypoint2.waypoint_0;
									}
									double_ = (double)Math2.smethod_17(waypoint_.imethod_2(), waypoint_.imethod_0(), waypoint3.imethod_2(), waypoint3.imethod_0());
									num2 = (double)Math2.smethod_15(waypoint_.imethod_2(), waypoint_.imethod_0(), waypoint3.imethod_2(), waypoint3.imethod_0());
									double double_6 = waypoint_.imethod_0();
									double double_7 = waypoint_.imethod_2();
									double_5 = (geoPoint8 = geoPoint2).imethod_0();
									double_4 = (geoPoint7 = geoPoint2).imethod_2();
									Class411.smethod_1(double_6, double_7, ref double_5, ref double_4, num2 / 2.0, Math2.smethod_6(double_));
									geoPoint7.imethod_3(double_4);
									geoPoint8.imethod_1(double_5);
								}
								if (!Information.IsNothing(waypoint.waypoint_1))
								{
									Waypoint waypoint_2 = waypoint.waypoint_1;
									Waypoint waypoint4;
									if (Information.IsNothing(waypoint2.waypoint_1))
									{
										waypoint4 = waypoint2;
									}
									else
									{
										waypoint4 = waypoint2.waypoint_1;
									}
									double_ = (double)Math2.smethod_17(waypoint_2.imethod_2(), waypoint_2.imethod_0(), waypoint4.imethod_2(), waypoint4.imethod_0());
									num2 = (double)Math2.smethod_15(waypoint_2.imethod_2(), waypoint_2.imethod_0(), waypoint4.imethod_2(), waypoint4.imethod_0());
									double double_8 = waypoint_2.imethod_0();
									double double_9 = waypoint_2.imethod_2();
									double_4 = (geoPoint7 = geoPoint).imethod_0();
									double_5 = (geoPoint8 = geoPoint).imethod_2();
									Class411.smethod_1(double_8, double_9, ref double_4, ref double_5, num2 / 2.0, Math2.smethod_6(double_));
									geoPoint8.imethod_3(double_5);
									geoPoint7.imethod_1(double_4);
								}
								if (!Information.IsNothing(waypoint.waypoint_2))
								{
									Waypoint waypoint_3 = waypoint.waypoint_1;
									Waypoint waypoint5;
									if (Information.IsNothing(waypoint2.waypoint_1))
									{
										waypoint5 = waypoint2;
									}
									else
									{
										waypoint5 = waypoint2.waypoint_1;
									}
									double_ = (double)Math2.smethod_17(waypoint_3.imethod_2(), waypoint_3.imethod_0(), waypoint5.imethod_2(), waypoint5.imethod_0());
									num2 = (double)Math2.smethod_15(waypoint_3.imethod_2(), waypoint_3.imethod_0(), waypoint5.imethod_2(), waypoint5.imethod_0());
									double double_10 = waypoint_3.imethod_0();
									double double_11 = waypoint_3.imethod_2();
									double_5 = (geoPoint8 = geoPoint).imethod_0();
									double_4 = (geoPoint7 = geoPoint).imethod_2();
									Class411.smethod_1(double_10, double_11, ref double_5, ref double_4, num2 / 2.0, Math2.smethod_6(double_));
									geoPoint7.imethod_3(double_4);
									geoPoint8.imethod_1(double_5);
								}
								if (!Information.IsNothing(waypoint.waypoint_3))
								{
									Waypoint waypoint_4 = waypoint.waypoint_1;
									Waypoint waypoint6;
									if (Information.IsNothing(waypoint2.waypoint_1))
									{
										waypoint6 = waypoint2;
									}
									else
									{
										waypoint6 = waypoint2.waypoint_1;
									}
									double_ = (double)Math2.smethod_17(waypoint_4.imethod_2(), waypoint_4.imethod_0(), waypoint6.imethod_2(), waypoint6.imethod_0());
									num2 = (double)Math2.smethod_15(waypoint_4.imethod_2(), waypoint_4.imethod_0(), waypoint6.imethod_2(), waypoint6.imethod_0());
									double double_12 = waypoint_4.imethod_0();
									double double_13 = waypoint_4.imethod_2();
									double_4 = (geoPoint7 = geoPoint).imethod_0();
									double_5 = (geoPoint8 = geoPoint).imethod_2();
									Class411.smethod_1(double_12, double_13, ref double_4, ref double_5, num2 / 2.0, Math2.smethod_6(double_));
									geoPoint8.imethod_3(double_5);
									geoPoint7.imethod_1(double_4);
								}
								if (!Information.IsNothing(waypoint.waypoint_4))
								{
									Waypoint waypoint_5 = waypoint.waypoint_1;
									Waypoint waypoint7;
									if (Information.IsNothing(waypoint2.waypoint_1))
									{
										waypoint7 = waypoint2;
									}
									else
									{
										waypoint7 = waypoint2.waypoint_1;
									}
									double_ = (double)Math2.smethod_17(waypoint_5.imethod_2(), waypoint_5.imethod_0(), waypoint7.imethod_2(), waypoint7.imethod_0());
									num2 = (double)Math2.smethod_15(waypoint_5.imethod_2(), waypoint_5.imethod_0(), waypoint7.imethod_2(), waypoint7.imethod_0());
									double double_14 = waypoint_5.imethod_0();
									double double_15 = waypoint_5.imethod_2();
									double_5 = (geoPoint8 = geoPoint).imethod_0();
									double_4 = (geoPoint7 = geoPoint).imethod_2();
									Class411.smethod_1(double_14, double_15, ref double_5, ref double_4, num2 / 2.0, Math2.smethod_6(double_));
									geoPoint7.imethod_3(double_4);
									geoPoint8.imethod_1(double_5);
								}
							}
							else
							{
								double double_16 = waypoint.imethod_0();
								double double_17 = waypoint.imethod_2();
								GeoPoint geoPoint7;
								double double_4 = (geoPoint7 = geoPoint).imethod_0();
								GeoPoint geoPoint8;
								double double_5 = (geoPoint8 = geoPoint).imethod_2();
								Class411.smethod_1(double_16, double_17, ref double_4, ref double_5, 10.0, 0.0);
								geoPoint8.imethod_3(double_5);
								geoPoint7.imethod_1(double_4);
								if (!Information.IsNothing(waypoint.waypoint_0))
								{
									double double_18 = waypoint.waypoint_0.imethod_0();
									double double_19 = waypoint.waypoint_0.imethod_2();
									double_5 = (geoPoint8 = geoPoint).imethod_0();
									double_4 = (geoPoint7 = geoPoint).imethod_2();
									Class411.smethod_1(double_18, double_19, ref double_5, ref double_4, 10.0, 0.0);
									geoPoint7.imethod_3(double_4);
									geoPoint8.imethod_1(double_5);
								}
								if (!Information.IsNothing(waypoint.waypoint_1))
								{
									double double_20 = waypoint.waypoint_1.imethod_0();
									double double_21 = waypoint.waypoint_1.imethod_2();
									double_4 = (geoPoint7 = geoPoint).imethod_0();
									double_5 = (geoPoint8 = geoPoint).imethod_2();
									Class411.smethod_1(double_20, double_21, ref double_4, ref double_5, 10.0, 0.0);
									geoPoint8.imethod_3(double_5);
									geoPoint7.imethod_1(double_4);
								}
								if (!Information.IsNothing(waypoint.waypoint_2))
								{
									double double_22 = waypoint.waypoint_2.imethod_0();
									double double_23 = waypoint.waypoint_2.imethod_2();
									double_5 = (geoPoint8 = geoPoint).imethod_0();
									double_4 = (geoPoint7 = geoPoint).imethod_2();
									Class411.smethod_1(double_22, double_23, ref double_5, ref double_4, 10.0, 0.0);
									geoPoint7.imethod_3(double_4);
									geoPoint8.imethod_1(double_5);
								}
								if (!Information.IsNothing(waypoint.waypoint_3))
								{
									double double_24 = waypoint.waypoint_3.imethod_0();
									double double_25 = waypoint.waypoint_3.imethod_2();
									double_4 = (geoPoint7 = geoPoint).imethod_0();
									double_5 = (geoPoint8 = geoPoint).imethod_2();
									Class411.smethod_1(double_24, double_25, ref double_4, ref double_5, 10.0, 0.0);
									geoPoint8.imethod_3(double_5);
									geoPoint7.imethod_1(double_4);
								}
								if (!Information.IsNothing(waypoint.waypoint_4))
								{
									double double_26 = waypoint.waypoint_4.imethod_0();
									double double_27 = waypoint.waypoint_4.imethod_2();
									double_5 = (geoPoint8 = geoPoint).imethod_0();
									double_4 = (geoPoint7 = geoPoint).imethod_2();
									Class411.smethod_1(double_26, double_27, ref double_5, ref double_4, 10.0, 0.0);
									geoPoint7.imethod_3(double_4);
									geoPoint8.imethod_1(double_5);
								}
							}
							Scenario scenario = Client.smethod_46();
							bool bool_ = true;
							bool bool_2 = false;
							Doctrine doctrine = null;
							Waypoint waypoint8 = Waypoint.smethod_14(ref scenario, ref waypoint, bool_, bool_2, ref doctrine);
							waypoint8.waypointType_0 = waypointType_;
							waypoint8.imethod_3(geoPoint.imethod_2());
							waypoint8.imethod_1(geoPoint.imethod_0());
							waypoint8.float_24 = 0f;
							waypoint8.float_25 = 0f;
							waypoint8.float_26 = 0f;
							if (!Information.IsNothing(waypoint8.waypoint_0))
							{
								Waypoint waypoint_6 = waypoint8.waypoint_0;
								waypoint_6.waypointType_0 = waypointType_;
								waypoint_6.imethod_3(geoPoint2.imethod_2());
								waypoint_6.imethod_1(geoPoint2.imethod_0());
							}
							if (!Information.IsNothing(waypoint8.waypoint_1))
							{
								Waypoint waypoint_7 = waypoint8.waypoint_1;
								waypoint_7.waypointType_0 = waypointType_;
								waypoint_7.imethod_3(geoPoint3.imethod_2());
								waypoint_7.imethod_1(geoPoint3.imethod_0());
							}
							if (!Information.IsNothing(waypoint8.waypoint_2))
							{
								Waypoint waypoint_8 = waypoint8.waypoint_2;
								waypoint_8.waypointType_0 = waypointType_;
								waypoint_8.imethod_3(geoPoint4.imethod_2());
								waypoint_8.imethod_1(geoPoint4.imethod_0());
							}
							if (!Information.IsNothing(waypoint8.waypoint_3))
							{
								Waypoint waypoint_9 = waypoint8.waypoint_3;
								waypoint_9.waypointType_0 = waypointType_;
								waypoint_9.imethod_3(geoPoint5.imethod_2());
								waypoint_9.imethod_1(geoPoint5.imethod_0());
							}
							if (!Information.IsNothing(waypoint8.waypoint_4))
							{
								Waypoint waypoint_10 = waypoint8.waypoint_4;
								waypoint_10.waypointType_0 = waypointType_;
								waypoint_10.imethod_3(geoPoint6.imethod_2());
								waypoint_10.imethod_1(geoPoint6.imethod_0());
							}
							ActiveUnit_Navigator.smethod_1(ref Client.smethod_25().waypoint_0, i + 1, waypoint8);
							IL_A00:
							if (!Information.IsNothing(waypoint) && !Information.IsNothing(waypoint8))
							{
								for (int j = Client.smethod_46().method_42().Count - 1; j >= 0; j += -1)
								{
									ActiveUnit activeUnit = Client.smethod_46().method_42()[j];
									if (!Information.IsNothing(activeUnit) && activeUnit.vmethod_127())
									{
										if ((activeUnit.bool_3 || (activeUnit.bool_1 && ((Group)activeUnit).method_143() == Group.GroupType.AirGroup)) && activeUnit.vmethod_85().method_49() && !Information.IsNothing(activeUnit.vmethod_7(false)) && activeUnit.vmethod_7(false) == Client.smethod_50())
										{
											int num3 = Enumerable.Count<Waypoint>(activeUnit.vmethod_85().method_4()) - 1;
											for (int k = 0; k <= num3; k++)
											{
												if (activeUnit.vmethod_85().method_4()[k] == waypoint && k >= 0)
												{
													ActiveUnit_Navigator activeUnit_Navigator = activeUnit.vmethod_85();
													Waypoint[] waypoint_11 = activeUnit_Navigator.method_4();
													ActiveUnit_Navigator.smethod_1(ref waypoint_11, k + 1, waypoint8);
													activeUnit_Navigator.method_5(waypoint_11);
													flag = true;
												}
												if (flag)
												{
													break;
												}
											}
										}
										if (flag)
										{
											break;
										}
									}
								}
							}
							if (this.vmethod_0().SelectedRows.Count > 0)
							{
								Client.smethod_25().int_0 = this.vmethod_0().SelectedRows[0].Index;
								Client.smethod_25().waypoint_1 = (Waypoint)this.vmethod_0().Rows[Client.smethod_25().int_0].Tag;
								this.vmethod_0().Rows[0].Selected = false;
							}
							Client.smethod_25().method_8(true, true, true, true, false);
							if (!Client.flightPlanTime_0.Visible)
							{
							}
							if (Client.smethod_31().Visible)
							{
								Client.smethod_31().method_5();
							}
							return;
						}
					}
				}
				goto IL_A00;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x00327270 File Offset: 0x00325470
		private void method_1(object sender, EventArgs e)
		{
			try
			{
				if (this.vmethod_0().SelectedRows.Count != 0)
				{
					for (int i = this.vmethod_0().Rows.Count - 1; i >= 0; i += -1)
					{
						DataGridViewRow dataGridViewRow = this.vmethod_0().Rows[i];
						if (dataGridViewRow.Selected)
						{
							Waypoint waypoint = (Waypoint)dataGridViewRow.Tag;
							switch (waypoint.waypointType_0)
							{
							case Waypoint.WaypointType.Assemble:
							case Waypoint.WaypointType.TurningPoint:
							case Waypoint.WaypointType.InitialPoint:
							case Waypoint.WaypointType.Target:
							case Waypoint.WaypointType.StrikeIngress:
							case Waypoint.WaypointType.StrikeEgress:
							case Waypoint.WaypointType.Refuel:
							case Waypoint.WaypointType.WeaponLaunch:
							case Waypoint.WaypointType.WeaponTarget:
								if (waypoint.method_22())
								{
									Interaction.MsgBox("Cannot delete waypoints with Split formation. Change the formation and try again.", MsgBoxStyle.OkOnly, null);
								}
								else if (!Information.IsNothing(waypoint))
								{
									foreach (ActiveUnit activeUnit in Client.smethod_50().activeUnit_0)
									{
										if (activeUnit.vmethod_85().method_47())
										{
											if (Enumerable.Contains<Waypoint>(activeUnit.vmethod_85().method_4(), waypoint))
											{
												activeUnit.vmethod_85().method_53(waypoint, true);
											}
											else if (!Information.IsNothing(waypoint.waypoint_0) && Enumerable.Contains<Waypoint>(activeUnit.vmethod_85().method_4(), waypoint.waypoint_0))
											{
												activeUnit.vmethod_85().method_53(waypoint.waypoint_0, false);
											}
											else if (!Information.IsNothing(waypoint.waypoint_1) && Enumerable.Contains<Waypoint>(activeUnit.vmethod_85().method_4(), waypoint.waypoint_1))
											{
												activeUnit.vmethod_85().method_53(waypoint.waypoint_1, false);
											}
											else if (!Information.IsNothing(waypoint.waypoint_2) && Enumerable.Contains<Waypoint>(activeUnit.vmethod_85().method_4(), waypoint.waypoint_2))
											{
												activeUnit.vmethod_85().method_53(waypoint.waypoint_2, false);
											}
											else if (!Information.IsNothing(waypoint.waypoint_3) && Enumerable.Contains<Waypoint>(activeUnit.vmethod_85().method_4(), waypoint.waypoint_3))
											{
												activeUnit.vmethod_85().method_53(waypoint.waypoint_3, false);
											}
											else if (!Information.IsNothing(waypoint.waypoint_4) && Enumerable.Contains<Waypoint>(activeUnit.vmethod_85().method_4(), waypoint.waypoint_4))
											{
												activeUnit.vmethod_85().method_53(waypoint.waypoint_4, false);
											}
										}
									}
								}
								break;
							default:
								if (waypoint.method_44())
								{
									Interaction.MsgBox("Cannot delete a Hold Start or Hold End waypoint!", MsgBoxStyle.OkOnly, null);
								}
								else if (waypoint.method_39())
								{
									Interaction.MsgBox("Cannot delete a Station Start or Station End waypoint!", MsgBoxStyle.OkOnly, null);
								}
								else
								{
									Interaction.MsgBox("Cannot delete waypoint!", MsgBoxStyle.OkOnly, null);
								}
								break;
							}
						}
					}
					if (this.vmethod_0().SelectedRows.Count > 0)
					{
						Client.smethod_25().int_0 = this.vmethod_0().SelectedRows[0].Index;
						Client.smethod_25().waypoint_1 = (Waypoint)this.vmethod_0().Rows[Client.smethod_25().int_0].Tag;
						this.vmethod_0().Rows[0].Selected = false;
					}
					Client.smethod_25().method_8(true, true, true, true, false);
					if (!Client.flightPlanTime_0.Visible)
					{
					}
					if (Client.smethod_31().Visible)
					{
						Client.smethod_31().method_5();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x00327624 File Offset: 0x00325824
		private void method_2(object sender, EventArgs e)
		{
			for (int i = Client.smethod_25().flightPlanWaypointsWeapon_1.vmethod_0().Rows.Count - 1; i >= 0; i += -1)
			{
				DataGridViewRow dataGridViewRow = Client.smethod_25().flightPlanWaypointsWeapon_1.vmethod_0().Rows[i];
				if (dataGridViewRow.Selected)
				{
					Waypoint expression = (Waypoint)dataGridViewRow.Tag;
					IL_57:
					if (!Information.IsNothing(expression))
					{
						Client.flightPlanTime_0.bool_3 = true;
						Client.flightPlanTime_0.Show();
						Client.flightPlanTime_0.BringToFront();
					}
					return;
				}
			}
			goto IL_57;
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x003276B0 File Offset: 0x003258B0
		private void method_3(object sender, EventArgs e)
		{
			int num = this.vmethod_0().Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataGridViewRow dataGridViewRow = this.vmethod_0().Rows[i];
				if (dataGridViewRow.Selected)
				{
					Waypoint waypoint_ = (Waypoint)dataGridViewRow.Tag;
					Class2413.smethod_2().method_66().waypoint_0 = waypoint_;
					Class2413.smethod_2().method_66().activeUnit_0 = null;
					Class2413.smethod_2().method_66().flight_0 = null;
					Class2413.smethod_2().method_66().mission_0 = null;
					Class2413.smethod_2().method_66().Show();
					return;
				}
			}
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x00327754 File Offset: 0x00325954
		private void method_4(object sender, DataGridViewCellPaintingEventArgs e)
		{
			try
			{
				if (e.RowIndex == 0 && e.ColumnIndex == this.vmethod_0().Columns["Time_Zulu"].Index)
				{
					Rectangle cellBounds = e.CellBounds;
					cellBounds.Y += (int)Math.Round((double)e.CellBounds.Height / 2.0);
					cellBounds.Height = (int)Math.Round((double)e.CellBounds.Height / 2.0);
					e.PaintBackground(cellBounds, true);
					e.PaintContent(cellBounds);
				}
				else if (e.RowIndex == 0 && e.ColumnIndex == this.vmethod_0().Columns["DesiredSpeed"].Index)
				{
					Rectangle cellBounds2 = e.CellBounds;
					cellBounds2.Y += (int)Math.Round((double)e.CellBounds.Height / 2.0);
					cellBounds2.Height = (int)Math.Round((double)e.CellBounds.Height / 2.0);
					e.PaintBackground(cellBounds2, true);
					e.PaintContent(cellBounds2);
				}
				else if (e.RowIndex == 0)
				{
					bool flag = e.ColumnIndex == 2 | e.ColumnIndex == 3;
				}
				if (this.vmethod_0().Columns["Time_Local"].Index == e.ColumnIndex && e.RowIndex >= 0)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == e.RowIndex)
					{
						ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.SelectionBackColor, 1, ButtonBorderStyle.Solid, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None);
					}
					else
					{
						ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None);
					}
					Rectangle cellBounds3 = e.CellBounds;
					int width = this.vmethod_0().GetCellDisplayRectangle(this.vmethod_0().Columns["TimeFixedImg"].Index, e.RowIndex, true).Width;
					cellBounds3.Width += width;
					ControlPaint.DrawBorder(e.Graphics, cellBounds3, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, Color.Red, 0, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
					e.Handled = true;
				}
				else if (this.vmethod_0().Columns["DesiredSpeed"].Index == e.ColumnIndex && e.RowIndex >= 0)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == e.RowIndex)
					{
						ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.SelectionBackColor, 1, ButtonBorderStyle.Solid, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None);
					}
					else
					{
						ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None);
					}
					Rectangle cellBounds4 = e.CellBounds;
					int width2 = this.vmethod_0().GetCellDisplayRectangle(this.vmethod_0().Columns["SpeedFixedImg"].Index, e.RowIndex, true).Width;
					cellBounds4.Width += width2;
					ControlPaint.DrawBorder(e.Graphics, cellBounds4, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, Color.Red, 0, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
					e.Handled = true;
				}
				else if (this.vmethod_0().Columns["Time_Local"].Index == e.ColumnIndex && e.RowIndex == -1)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, e.CellStyle.BackColor, 1, ButtonBorderStyle.None);
					Rectangle cellBounds5 = e.CellBounds;
					cellBounds5.Width++;
					ControlPaint.DrawBorder(e.Graphics, cellBounds5, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
					cellBounds5.Y++;
					cellBounds5.Height -= 2;
					ControlPaint.DrawBorder(e.Graphics, cellBounds5, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 2, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid);
					e.Handled = true;
				}
				else if (this.vmethod_0().Columns["DesiredSpeed"].Index == e.ColumnIndex && e.RowIndex == -1)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, e.CellStyle.BackColor, 1, ButtonBorderStyle.None);
					Rectangle cellBounds6 = e.CellBounds;
					cellBounds6.Width++;
					ControlPaint.DrawBorder(e.Graphics, cellBounds6, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
					cellBounds6.Y++;
					cellBounds6.Height -= 2;
					ControlPaint.DrawBorder(e.Graphics, cellBounds6, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 2, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid);
					e.Handled = true;
				}
				else if (this.vmethod_0().Columns["TimeFixedImg"].Index == e.ColumnIndex && e.RowIndex == -1)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.None);
					Rectangle cellBounds7 = e.CellBounds;
					cellBounds7.Width++;
					ControlPaint.DrawBorder(e.Graphics, cellBounds7, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
					cellBounds7.Height -= 2;
					cellBounds7.Y++;
					ControlPaint.DrawBorder(e.Graphics, cellBounds7, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 2, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid);
					e.Handled = true;
				}
				else if (this.vmethod_0().Columns["SpeedFixedImg"].Index == e.ColumnIndex && e.RowIndex == -1)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.None);
					Rectangle cellBounds8 = e.CellBounds;
					cellBounds8.Width++;
					ControlPaint.DrawBorder(e.Graphics, cellBounds8, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
					cellBounds8.Y++;
					cellBounds8.Height -= 2;
					ControlPaint.DrawBorder(e.Graphics, cellBounds8, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 2, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid);
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x00328144 File Offset: 0x00326344
		private void method_5(object sender, DataGridViewColumnEventArgs e)
		{
			Rectangle displayRectangle = this.vmethod_0().DisplayRectangle;
			this.vmethod_0().Invalidate(displayRectangle);
		}

		// Token: 0x06005B71 RID: 23409 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_6(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_7(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06005B73 RID: 23411 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_8(object sender, EventArgs e)
		{
		}

		// Token: 0x06005B74 RID: 23412 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_9(object sender, EventArgs e)
		{
		}

		// Token: 0x06005B75 RID: 23413 RVA: 0x0003AD54 File Offset: 0x00038F54
		private void method_10(object sender, EventArgs e)
		{
			if (Client.smethod_25().bool_3)
			{
				this.method_11();
				this.method_12();
				this.method_13();
			}
		}

		// Token: 0x06005B76 RID: 23414 RVA: 0x0032816C File Offset: 0x0032636C
		public void method_11()
		{
			try
			{
				Client.smethod_25().bitmap_0.MakeTransparent(Color.White);
				Client.smethod_25().bitmap_1.MakeTransparent(Color.White);
				Client.smethod_25().bitmap_2.MakeTransparent(Color.White);
				Client.smethod_25().bitmap_3.MakeTransparent(Color.White);
				Client.smethod_25().bitmap_4.MakeTransparent(Color.White);
				bool bool_ = Client.smethod_25().bool_3;
				Client.smethod_25().bool_3 = false;
				try
				{
					foreach (object obj in ((IEnumerable)this.vmethod_0().Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["TimeFixed"].Value), 1))
						{
							if (dataGridViewRow.Cells["TimeFixedImg"].Value != Client.smethod_25().bitmap_0)
							{
								dataGridViewRow.Cells["TimeFixedImg"].Value = Client.smethod_25().bitmap_0;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["TimeFixed"].Value), 0))
						{
							if (dataGridViewRow.Cells["TimeFixedImg"].Value != Client.smethod_25().bitmap_1)
							{
								dataGridViewRow.Cells["TimeFixedImg"].Value = Client.smethod_25().bitmap_1;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["TimeFixed"].Value), 2))
						{
							if (dataGridViewRow.Cells["TimeFixedImg"].Value != Client.smethod_25().bitmap_3)
							{
								dataGridViewRow.Cells["TimeFixedImg"].Value = Client.smethod_25().bitmap_3;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["TimeFixed"].Value), 3))
						{
							if (dataGridViewRow.Cells["TimeFixedImg"].Value != Client.smethod_25().bitmap_4)
							{
								dataGridViewRow.Cells["TimeFixedImg"].Value = Client.smethod_25().bitmap_4;
							}
						}
						else if (dataGridViewRow.Cells["TimeFixedImg"].Value != Client.smethod_25().bitmap_2)
						{
							dataGridViewRow.Cells["TimeFixedImg"].Value = Client.smethod_25().bitmap_2;
						}
						if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["SpeedFixed"].Value), 1))
						{
							if (dataGridViewRow.Cells["SpeedFixedImg"].Value != Client.smethod_25().bitmap_0)
							{
								dataGridViewRow.Cells["SpeedFixedImg"].Value = Client.smethod_25().bitmap_0;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["SpeedFixed"].Value), 0))
						{
							if (dataGridViewRow.Cells["SpeedFixedImg"].Value != Client.smethod_25().bitmap_1)
							{
								dataGridViewRow.Cells["SpeedFixedImg"].Value = Client.smethod_25().bitmap_1;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["SpeedFixed"].Value), 2))
						{
							if (dataGridViewRow.Cells["SpeedFixedImg"].Value != Client.smethod_25().bitmap_3)
							{
								dataGridViewRow.Cells["SpeedFixedImg"].Value = Client.smethod_25().bitmap_3;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["SpeedFixed"].Value), 3))
						{
							if (dataGridViewRow.Cells["SpeedFixedImg"].Value != Client.smethod_25().bitmap_4)
							{
								dataGridViewRow.Cells["SpeedFixedImg"].Value = Client.smethod_25().bitmap_4;
							}
						}
						else if (dataGridViewRow.Cells["SpeedFixedImg"].Value != Client.smethod_25().bitmap_2)
						{
							dataGridViewRow.Cells["SpeedFixedImg"].Value = Client.smethod_25().bitmap_2;
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
				Client.smethod_25().bool_3 = bool_;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x0032869C File Offset: 0x0032689C
		public void method_12()
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.vmethod_0().Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						Waypoint waypoint = (Waypoint)dataGridViewRow.Tag;
						if (!Information.IsNothing(waypoint))
						{
							if (waypoint.waypointType_0 == Waypoint.WaypointType.StationEnd)
							{
								dataGridViewRow.Cells["Type"].ReadOnly = true;
								dataGridViewRow.Cells["Type"].Style.BackColor = Color.LightGray;
								dataGridViewRow.Cells["Type"].Style.SelectionBackColor = Color.LightGray;
								dataGridViewRow.Cells["Type"].Style.SelectionForeColor = Color.Black;
							}
							else if (dataGridViewRow.Cells["Type"].ReadOnly)
							{
								dataGridViewRow.Cells["Type"].ReadOnly = false;
								dataGridViewRow.Cells["Type"].Style.BackColor = default(Color);
								dataGridViewRow.Cells["Type"].Style.SelectionBackColor = default(Color);
							}
							if (waypoint.waypointType_0 == Waypoint.WaypointType.HoldEnd)
							{
								dataGridViewRow.Cells["Type"].ReadOnly = true;
								dataGridViewRow.Cells["Type"].Style.BackColor = Color.LightGray;
								dataGridViewRow.Cells["Type"].Style.SelectionBackColor = Color.LightGray;
								dataGridViewRow.Cells["Type"].Style.SelectionForeColor = Color.Black;
							}
							else if (dataGridViewRow.Cells["Type"].ReadOnly)
							{
								dataGridViewRow.Cells["Type"].ReadOnly = false;
								dataGridViewRow.Cells["Type"].Style.BackColor = default(Color);
								dataGridViewRow.Cells["Type"].Style.SelectionBackColor = default(Color);
							}
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005B78 RID: 23416 RVA: 0x00328958 File Offset: 0x00326B58
		public void method_13()
		{
			try
			{
				this.vmethod_10().Enabled = false;
				this.vmethod_8().Enabled = false;
				this.vmethod_4().Enabled = false;
				this.vmethod_6().Enabled = false;
				this.vmethod_2().Enabled = false;
				if (this.vmethod_0().SelectedRows.Count == 1)
				{
					int num = this.vmethod_0().Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						DataGridViewRow dataGridViewRow = this.vmethod_0().Rows[i];
						if (dataGridViewRow.Selected)
						{
							Waypoint waypoint = (Waypoint)dataGridViewRow.Tag;
							if (!Information.IsNothing(waypoint))
							{
								switch (waypoint.waypointType_0)
								{
								case Waypoint.WaypointType.Assemble:
								case Waypoint.WaypointType.TurningPoint:
								case Waypoint.WaypointType.InitialPoint:
								case Waypoint.WaypointType.Target:
								case Waypoint.WaypointType.StrikeIngress:
								case Waypoint.WaypointType.StrikeEgress:
								case Waypoint.WaypointType.Refuel:
								case Waypoint.WaypointType.TakeOff:
								case Waypoint.WaypointType.WeaponLaunch:
								case Waypoint.WaypointType.WeaponTarget:
								case Waypoint.WaypointType.StationEnd:
								case Waypoint.WaypointType.HoldEnd:
									this.vmethod_10().Enabled = true;
									break;
								}
								switch (waypoint.waypointType_0)
								{
								case Waypoint.WaypointType.Assemble:
								case Waypoint.WaypointType.TurningPoint:
								case Waypoint.WaypointType.InitialPoint:
								case Waypoint.WaypointType.Target:
								case Waypoint.WaypointType.StrikeIngress:
								case Waypoint.WaypointType.StrikeEgress:
								case Waypoint.WaypointType.Refuel:
								case Waypoint.WaypointType.WeaponLaunch:
								case Waypoint.WaypointType.WeaponTarget:
									this.vmethod_8().Enabled = true;
									break;
								}
								switch (waypoint.waypointType_0)
								{
								case Waypoint.WaypointType.Assemble:
								case Waypoint.WaypointType.TurningPoint:
								case Waypoint.WaypointType.InitialPoint:
								case Waypoint.WaypointType.Target:
								case Waypoint.WaypointType.LandingMarshal:
								case Waypoint.WaypointType.StrikeIngress:
								case Waypoint.WaypointType.StrikeEgress:
								case Waypoint.WaypointType.Refuel:
								case Waypoint.WaypointType.TakeOff:
								case Waypoint.WaypointType.WeaponLaunch:
								case Waypoint.WaypointType.WeaponTarget:
								case Waypoint.WaypointType.StationStart_Racetrack:
								case Waypoint.WaypointType.StationStart_FigureEight:
								case Waypoint.WaypointType.StationStart_Area:
								case Waypoint.WaypointType.StationStart_RaceTrackRandom:
								case Waypoint.WaypointType.StationEnd:
								case Waypoint.WaypointType.HoldStart:
								case Waypoint.WaypointType.HoldEnd:
									this.vmethod_4().Enabled = true;
									break;
								}
								this.vmethod_6().Enabled = true;
								break;
							}
						}
					}
				}
				else if (this.vmethod_0().SelectedRows.Count > 1)
				{
					if (this.vmethod_0().Rows.Count > 0)
					{
						this.vmethod_2().Enabled = true;
						this.vmethod_8().Enabled = true;
					}
				}
				else if (this.vmethod_0().Rows.Count > 0)
				{
					this.vmethod_2().Enabled = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005B79 RID: 23417 RVA: 0x00328C20 File Offset: 0x00326E20
		private void method_14(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				int num = this.vmethod_0().Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataGridViewRow dataGridViewRow = this.vmethod_0().Rows[i];
					if (dataGridViewRow.Selected)
					{
						DataGridViewRow dataGridViewRow2 = dataGridViewRow;
						Client.smethod_25().waypoint_1 = (Waypoint)dataGridViewRow2.Tag;
						Client.smethod_59(Client.smethod_25().waypoint_1);
						DataGridViewColumn dataGridViewColumn = this.vmethod_0().Columns[e.ColumnIndex];
						if (Operators.CompareString(dataGridViewColumn.Name, "Type", false) == 0)
						{
							if (!this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index].IsInEditMode)
							{
								DataTable dataSource = new DataTable();
								DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index];
								Waypoint.smethod_20(ref dataSource);
								dataGridViewComboBoxCell.DataSource = dataSource;
								dataGridViewComboBoxCell.DisplayMember = "Description";
								dataGridViewComboBoxCell.ValueMember = "ID";
								dataGridViewComboBoxCell.DropDownWidth = 500;
							}
							this.vmethod_0().BeginEdit(true);
							if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_16().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
							{
								((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
							}
						}
						else if (Operators.CompareString(dataGridViewColumn.Name, "Formation", false) == 0)
						{
							if (!this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index].IsInEditMode)
							{
								DataTable dataSource2 = new DataTable();
								DataGridViewComboBoxCell dataGridViewComboBoxCell2 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index];
								Waypoint.smethod_24(ref dataSource2);
								dataGridViewComboBoxCell2.DataSource = dataSource2;
								dataGridViewComboBoxCell2.DisplayMember = "Description";
								dataGridViewComboBoxCell2.ValueMember = "ID";
								dataGridViewComboBoxCell2.DropDownWidth = 500;
							}
							this.vmethod_0().BeginEdit(true);
							if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_16().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
							{
								((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
							}
						}
						else
						{
							if (Operators.CompareString(dataGridViewColumn.Name, "AARUsage", false) == 0)
							{
								Waypoint waypoint = (Waypoint)dataGridViewRow.Tag;
								if (!Information.IsNothing(waypoint))
								{
									if (!this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index].IsInEditMode)
									{
										DataTable dataSource3 = new DataTable();
										waypoint.method_18().method_53(ref dataSource3, Client.smethod_46(), null);
										DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index];
										dataGridViewComboBoxCell3.DataSource = dataSource3;
										dataGridViewComboBoxCell3.DisplayMember = "Description";
										dataGridViewComboBoxCell3.ValueMember = "ID";
										dataGridViewComboBoxCell3.DropDownWidth = 500;
									}
									this.vmethod_0().BeginEdit(true);
									if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_16().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
									{
										((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
										break;
									}
									break;
								}
							}
							if (Operators.CompareString(dataGridViewColumn.Name, "AARSelection", false) == 0)
							{
								Waypoint waypoint2 = (Waypoint)dataGridViewRow.Tag;
								if (!Information.IsNothing(waypoint2))
								{
									if (!this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index].IsInEditMode)
									{
										DataTable dataSource4 = new DataTable();
										waypoint2.method_18().method_54(ref dataSource4, Client.smethod_46(), null);
										DataGridViewComboBoxCell dataGridViewComboBoxCell4 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index];
										dataGridViewComboBoxCell4.DataSource = dataSource4;
										dataGridViewComboBoxCell4.DisplayMember = "Description";
										dataGridViewComboBoxCell4.ValueMember = "ID";
										dataGridViewComboBoxCell4.DropDownWidth = 500;
									}
									this.vmethod_0().BeginEdit(true);
									if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_16().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
									{
										((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
										break;
									}
									break;
								}
							}
							if (Operators.CompareString(dataGridViewColumn.Name, "SpeedToT", false) == 0)
							{
								if (!this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index].IsInEditMode)
								{
									DataTable dataSource5 = new DataTable();
									DataGridViewComboBoxCell dataGridViewComboBoxCell5 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index];
									Waypoint.smethod_31(ref dataSource5);
									dataGridViewComboBoxCell5.DataSource = dataSource5;
									dataGridViewComboBoxCell5.DisplayMember = "Description";
									dataGridViewComboBoxCell5.ValueMember = "ID";
									dataGridViewComboBoxCell5.DropDownWidth = 500;
								}
								this.vmethod_0().BeginEdit(true);
								if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_16().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
								{
									((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
								}
							}
							else if (Operators.CompareString(dataGridViewColumn.Name, "TurnRate", false) == 0)
							{
								if (!this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index].IsInEditMode)
								{
									DataTable dataSource6 = new DataTable();
									DataGridViewComboBoxCell dataGridViewComboBoxCell6 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index];
									Waypoint.smethod_25(ref dataSource6);
									dataGridViewComboBoxCell6.DataSource = dataSource6;
									dataGridViewComboBoxCell6.DisplayMember = "Description";
									dataGridViewComboBoxCell6.ValueMember = "ID";
									dataGridViewComboBoxCell6.DropDownWidth = 500;
								}
								this.vmethod_0().BeginEdit(true);
								if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_16().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
								{
									((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
								}
							}
							else if (Operators.CompareString(dataGridViewColumn.Name, "TimeFixedImg", false) == 0)
							{
								Waypoint waypoint3 = (Waypoint)dataGridViewRow.Tag;
								if (!Information.IsNothing(waypoint3.nullable_7))
								{
									if (waypoint3.enum82_0 == Waypoint.Enum82.const_0)
									{
										waypoint3.enum82_0 = Waypoint.Enum82.const_1;
										dataGridViewRow.Cells["TimeFixed"].Value = waypoint3.enum82_0;
									}
									else if (waypoint3.enum82_0 == Waypoint.Enum82.const_1)
									{
										if (waypoint3.enum83_0 == Waypoint.Enum83.const_2)
										{
											waypoint3.enum82_0 = Waypoint.Enum82.const_3;
											dataGridViewRow.Cells["TimeFixed"].Value = waypoint3.enum82_0;
										}
										else
										{
											waypoint3.enum82_0 = Waypoint.Enum82.const_0;
											dataGridViewRow.Cells["TimeFixed"].Value = waypoint3.enum82_0;
										}
									}
									else if (waypoint3.enum82_0 == Waypoint.Enum82.const_3)
									{
										waypoint3.enum82_0 = Waypoint.Enum82.const_0;
										dataGridViewRow.Cells["TimeFixed"].Value = waypoint3.enum82_0;
									}
									flag = true;
									flag2 = true;
									flag4 = true;
								}
							}
							else if (Operators.CompareString(dataGridViewColumn.Name, "SpeedFixedImg", false) == 0)
							{
								Waypoint waypoint4 = (Waypoint)dataGridViewRow.Tag;
								if (waypoint4.enum82_1 == Waypoint.Enum82.const_0)
								{
									if (!Information.IsNothing(waypoint4.nullable_0) || waypoint4.method_35() != ActiveUnit_Kinematics.UnitThrottlePreset.None)
									{
										waypoint4.enum82_1 = Waypoint.Enum82.const_1;
									}
								}
								else if (waypoint4.enum82_1 == Waypoint.Enum82.const_1)
								{
									if (waypoint4.waypointType_0 != Waypoint.WaypointType.TakeOff)
									{
										if (waypoint4.waypointType_0 != Waypoint.WaypointType.Land)
										{
											waypoint4.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Cruise);
											waypoint4.nullable_0 = null;
											waypoint4.method_28(null);
											waypoint4.enum82_1 = Waypoint.Enum82.const_0;
											goto IL_912;
										}
									}
									waypoint4.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Loiter);
									waypoint4.nullable_0 = null;
									waypoint4.method_28(null);
									waypoint4.enum82_1 = Waypoint.Enum82.const_1;
								}
								else if (waypoint4.enum82_1 == Waypoint.Enum82.const_3)
								{
									waypoint4.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Cruise);
									waypoint4.nullable_0 = null;
									waypoint4.method_28(null);
									waypoint4.enum82_1 = Waypoint.Enum82.const_0;
								}
								IL_912:
								flag = true;
								flag2 = true;
							}
						}
						IL_916:
						if (!Information.IsNothing(dataGridViewRow2))
						{
							this.vmethod_10().Enabled = true;
							this.vmethod_8().Enabled = true;
							this.vmethod_6().Enabled = true;
							this.vmethod_2().Enabled = true;
							this.vmethod_4().Enabled = true;
						}
						else
						{
							this.vmethod_10().Enabled = false;
							this.vmethod_8().Enabled = false;
							this.vmethod_6().Enabled = false;
							this.vmethod_2().Enabled = false;
							this.vmethod_4().Enabled = false;
						}
						if (flag)
						{
							Client.smethod_25().method_8(true, flag2, false, flag3, false);
						}
						else if (flag3)
						{
							Client.smethod_25().method_6();
						}
						else if (flag2)
						{
							Client.smethod_25().method_7();
						}
						if (flag || flag3 || flag2)
						{
							this.method_11();
							this.method_12();
						}
						if (!Client.flightPlanTime_0.Visible)
						{
						}
						if (flag4 && Client.smethod_31().Visible)
						{
							Client.smethod_31().method_5();
							Client.smethod_31().method_13();
						}
						this.method_13();
						return;
					}
				}
				goto IL_916;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200588", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x0003AD74 File Offset: 0x00038F74
		private void method_15(object sender, DataGridViewCellEventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0 && Client.smethod_25().bool_3)
			{
				this.method_17(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x0003ADA1 File Offset: 0x00038FA1
		private void method_16(object sender, EventArgs e)
		{
			Client.smethod_25().bool_3 = true;
			if (this.vmethod_0().IsCurrentCellDirty)
			{
				this.vmethod_0().CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		// Token: 0x06005B7C RID: 23420 RVA: 0x00329698 File Offset: 0x00327898
		private void method_17(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				bool flag = false;
				if (!Information.IsNothing(Client.smethod_25().weapon_0))
				{
					if (e.RowIndex <= Enumerable.Count<Waypoint>(Client.smethod_25().waypoint_0) - 1)
					{
						Waypoint waypoint = Client.smethod_25().waypoint_0[e.RowIndex];
						if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["Type"].Index)
						{
							DataGridViewCell dataGridViewCell = this.vmethod_0()[e.ColumnIndex, e.RowIndex];
							object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value);
							int? num = Waypoint.smethod_21(ref objectValue);
							dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(objectValue);
							Waypoint.WaypointType value = (Waypoint.WaypointType)num.Value;
							if (e.RowIndex == 0)
							{
								if (value == Waypoint.WaypointType.TakeOff)
								{
									waypoint.waypointType_0 = value;
								}
								else
								{
									Client.smethod_25().method_6();
									Interaction.MsgBox("The first waypoint in a flightplan must be the Take-Off waypoint!", MsgBoxStyle.OkOnly, null);
								}
							}
							else if (e.RowIndex == this.vmethod_0().Rows.Count - 1)
							{
								if (value == Waypoint.WaypointType.Land)
								{
									waypoint.waypointType_0 = value;
								}
								else
								{
									Client.smethod_25().method_6();
									Interaction.MsgBox("The last waypoint in a flightplan must be the Landing waypoint!", MsgBoxStyle.OkOnly, null);
								}
							}
							else if (e.RowIndex == this.vmethod_0().Rows.Count - 2)
							{
								if (value == Waypoint.WaypointType.LandingMarshal)
								{
									waypoint.waypointType_0 = value;
								}
								else
								{
									Client.smethod_25().method_6();
									Interaction.MsgBox("The second last waypoint in a flightplan must be the Landing Marshal waypoint!", MsgBoxStyle.OkOnly, null);
								}
							}
							else if (value == Waypoint.WaypointType.TakeOff)
							{
								if (e.RowIndex == 0)
								{
									waypoint.waypointType_0 = value;
								}
								else
								{
									Client.smethod_25().method_6();
									Interaction.MsgBox("The Take-Off waypoint must be the first waypoint in a flightplan!", MsgBoxStyle.OkOnly, null);
								}
							}
							else if (value == Waypoint.WaypointType.Land)
							{
								if (e.RowIndex == this.vmethod_0().Rows.Count - 1)
								{
									waypoint.waypointType_0 = value;
								}
								else
								{
									Client.smethod_25().method_6();
									Interaction.MsgBox("The Landing waypoint must be the last waypoint in a flightplan!", MsgBoxStyle.OkOnly, null);
								}
							}
							else if (value == Waypoint.WaypointType.LandingMarshal)
							{
								if (e.RowIndex == this.vmethod_0().Rows.Count - 2)
								{
									waypoint.waypointType_0 = value;
								}
								else
								{
									Client.smethod_25().method_6();
									Interaction.MsgBox("The Landing Marshal waypoint must be the second last waypoint in a flightplan!", MsgBoxStyle.OkOnly, null);
								}
							}
							else
							{
								if (value != Waypoint.WaypointType.StationStart_Area && value != Waypoint.WaypointType.StationStart_FigureEight && value != Waypoint.WaypointType.StationStart_Racetrack)
								{
									if (value != Waypoint.WaypointType.StationStart_RaceTrackRandom)
									{
										if (value == Waypoint.WaypointType.StationEnd)
										{
											Client.smethod_25().method_6();
											Interaction.MsgBox("The Station End waypoint is set automatically when a Station Start waypoint is configured. Select Station Start instead.", MsgBoxStyle.OkOnly, null);
											goto IL_43E;
										}
										if (value == Waypoint.WaypointType.HoldStart)
										{
											if (e.RowIndex < 1)
											{
												Client.smethod_25().method_6();
												Interaction.MsgBox("The first waypoint in a flightplan can not be a Hold Start waypoint!", MsgBoxStyle.OkOnly, null);
												goto IL_43E;
											}
											if (e.RowIndex > this.vmethod_0().Rows.Count - 4)
											{
												Client.smethod_25().method_6();
												Interaction.MsgBox("The last three waypoints in a flightplan can not be a Hold Start waypoint! Reason: Neither the Landing nor Landing Marshal waypoints can be a Hold End waypoint. Note! The waypoint after Hold Start is automatically turned into a Hold End waypoint.", MsgBoxStyle.OkOnly, null);
												goto IL_43E;
											}
											goto IL_43E;
										}
										else
										{
											if (value == Waypoint.WaypointType.HoldEnd)
											{
												Client.smethod_25().method_6();
												Interaction.MsgBox("The Hold End waypoint is set automatically when a Hold Start waypoint is configured. Select Hold Start instead.", MsgBoxStyle.OkOnly, null);
												goto IL_43E;
											}
											if (waypoint.method_42() || waypoint.method_40())
											{
												flag = true;
											}
											bool flag2 = false;
											bool flag3 = false;
											if (waypoint.waypointType_0 != Waypoint.WaypointType.WeaponTarget && value != Waypoint.WaypointType.WeaponTarget && waypoint.waypointType_0 != Waypoint.WaypointType.Target && value != Waypoint.WaypointType.Target && waypoint.waypointType_0 != Waypoint.WaypointType.InitialPoint && value != Waypoint.WaypointType.InitialPoint && waypoint.waypointType_0 != Waypoint.WaypointType.WeaponLaunch)
											{
												if (value != Waypoint.WaypointType.WeaponLaunch)
												{
													if (waypoint.waypointType_0 == Waypoint.WaypointType.TurningPoint || value == Waypoint.WaypointType.TurningPoint || waypoint.waypointType_0 == Waypoint.WaypointType.StrikeIngress || value == Waypoint.WaypointType.StrikeIngress || waypoint.waypointType_0 == Waypoint.WaypointType.StrikeEgress || value == Waypoint.WaypointType.StrikeEgress)
													{
														flag3 = true;
														goto IL_38C;
													}
													goto IL_38C;
												}
											}
											flag2 = true;
											IL_38C:
											waypoint.waypointType_0 = value;
											if (value == Waypoint.WaypointType.Assemble)
											{
												waypoint.float_24 = 600f;
												flag = true;
												goto IL_43E;
											}
											if (value == Waypoint.WaypointType.Refuel)
											{
												Client.smethod_25().method_8(true, true, false, false, false);
												goto IL_43E;
											}
											if (flag2)
											{
												Client.smethod_25().method_8(true, true, false, false, false);
												flag = true;
												goto IL_43E;
											}
											if (flag3)
											{
												Client.smethod_25().method_8(true, true, false, false, false);
												goto IL_43E;
											}
											goto IL_43E;
										}
									}
								}
								if (e.RowIndex < 1)
								{
									Client.smethod_25().method_6();
									Interaction.MsgBox("The first waypoint in a flightplan can not be a Station Start waypoint!", MsgBoxStyle.OkOnly, null);
								}
								else if (e.RowIndex > this.vmethod_0().Rows.Count - 4)
								{
									Client.smethod_25().method_6();
									Interaction.MsgBox("The last three waypoints in a flightplan can not be a Station Start waypoint! Reason: Neither the Landing nor Landing Marshal waypoints can be a Station End waypoint. Note! The waypoint after Station Start is automatically turned into a Station End waypoint.", MsgBoxStyle.OkOnly, null);
								}
							}
							IL_43E:
							if (waypoint.waypointType_0 != Waypoint.WaypointType.Assemble && waypoint.waypointType_0 != Waypoint.WaypointType.HoldEnd)
							{
								if (waypoint.float_24 > 0f)
								{
									waypoint.float_24 = 0f;
									Client.smethod_25().method_8(true, true, false, false, false);
									flag = true;
								}
							}
							else
							{
								Client.smethod_25().method_8(true, true, false, false, false);
								flag = true;
							}
						}
						if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["Formation"].Index)
						{
							DataGridViewCell dataGridViewCell2 = this.vmethod_0()[e.ColumnIndex, e.RowIndex];
							object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value);
							int? num = Waypoint.smethod_26(ref objectValue);
							dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(objectValue);
							Waypoint.Enum83 value2 = (Waypoint.Enum83)num.Value;
							if (value2 == Waypoint.Enum83.const_2 && waypoint.method_39())
							{
								Client.smethod_25().method_6();
								Interaction.MsgBox("Station waypoints cannot be set to Split formation.", MsgBoxStyle.OkOnly, null);
							}
							else if (value2 == Waypoint.Enum83.const_2 && waypoint.method_45())
							{
								Client.smethod_25().method_6();
								Interaction.MsgBox("Hold and Assemble waypoints cannot be set to Split formation.", MsgBoxStyle.OkOnly, null);
							}
							else if (value2 == Waypoint.Enum83.const_2 && e.RowIndex <= 1)
							{
								Client.smethod_25().method_6();
								Interaction.MsgBox("The first two waypoint in a flightplan cannot be set to Split formation.", MsgBoxStyle.OkOnly, null);
							}
							else if (value2 == Waypoint.Enum83.const_2 && e.RowIndex >= this.vmethod_0().Rows.Count - 1)
							{
								Client.smethod_25().method_6();
								Interaction.MsgBox("The last waypoint in a flightplan cannot be set to Split formation.", MsgBoxStyle.OkOnly, null);
							}
							else if (value2 == Waypoint.Enum83.const_2 && waypoint.waypointType_0 == Waypoint.WaypointType.LandingMarshal)
							{
								Client.smethod_25().method_6();
								Interaction.MsgBox("A landing marshal waypoint cannot be set to Split formation.", MsgBoxStyle.OkOnly, null);
							}
							else
							{
								Client.smethod_25().method_8(true, true, true, true, false);
								flag = true;
							}
						}
						if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["TurnRate"].Index)
						{
							Waypoint waypoint2 = waypoint;
							DataGridViewCell dataGridViewCell3 = this.vmethod_0()[e.ColumnIndex, e.RowIndex];
							object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewCell3.Value);
							int? num = Waypoint.smethod_27(ref objectValue);
							dataGridViewCell3.Value = RuntimeHelpers.GetObjectValue(objectValue);
							waypoint2.enum81_0 = (Waypoint.Enum81)num.Value;
							Client.smethod_25().method_8(true, true, true, false, false);
							flag = true;
						}
						if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["AARUsage"].Index)
						{
							Doctrine doctrine = waypoint.method_18();
							int int_ = Conversions.ToInteger(this.vmethod_0()[e.ColumnIndex, e.RowIndex].Value);
							Scenario scenario = Client.smethod_46();
							int num2 = 0;
							doctrine.method_318(int_, ref scenario, ref num2, false, false, false);
							Client.smethod_25().method_8(true, true, false, false, false);
						}
						if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["AARSelection"].Index)
						{
							Doctrine doctrine2 = waypoint.method_18();
							int int_2 = Conversions.ToInteger(this.vmethod_0()[e.ColumnIndex, e.RowIndex].Value);
							Scenario scenario = Client.smethod_46();
							int num2 = 0;
							doctrine2.method_320(int_2, ref scenario, ref num2, false, false, false);
							Client.smethod_25().method_8(true, true, false, false, false);
						}
						if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["SpeedToT"].Index)
						{
							Waypoint waypoint3 = waypoint;
							DataGridViewCell dataGridViewCell4 = this.vmethod_0()[e.ColumnIndex, e.RowIndex];
							object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewCell4.Value);
							int? num = Waypoint.smethod_32(ref objectValue);
							dataGridViewCell4.Value = RuntimeHelpers.GetObjectValue(objectValue);
							waypoint3.enum84_0 = (Waypoint.Enum84)num.Value;
						}
						this.method_11();
						this.method_12();
						this.method_13();
						if (flag && Client.smethod_31().Visible)
						{
							Client.smethod_31().method_5();
							Client.smethod_31().method_30();
						}
						Client.smethod_25().bool_3 = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005B7D RID: 23421 RVA: 0x0003ADCC File Offset: 0x00038FCC
		private void method_18(object sender, EventArgs e)
		{
			if (Client.smethod_25().bool_3)
			{
				int count = this.vmethod_0().SelectedRows.Count;
			}
		}

		// Token: 0x06005B7E RID: 23422 RVA: 0x00329F08 File Offset: 0x00328108
		private void method_19(object sender, EventArgs e)
		{
			try
			{
				Client.smethod_25().method_8(false, true, false, false, true);
				this.method_12();
				this.method_13();
				Class2413.smethod_2().method_41().method_235();
				Client.bool_1 = true;
				Class2413.smethod_2().method_41().method_84();
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_4();
				}
				FlightPlanTime flightPlanTime_ = Client.flightPlanTime_0;
				Mission mission = null;
				Mission.Flight flight = null;
				Waypoint waypoint = null;
				flightPlanTime_.method_4(ref mission, ref flight, ref waypoint, Mission.Flight.Enum106.const_0, false);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0400354B RID: 13643
		private IContainer icontainer_0;

		// Token: 0x0400354C RID: 13644
		[CompilerGenerated]
		[AccessedThroughProperty("DGV_WaypointsWeapon")]
		private Class2422 class2422_0;

		// Token: 0x0400354D RID: 13645
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ClearTime")]
		private Button button_0;

		// Token: 0x0400354E RID: 13646
		[CompilerGenerated]
		[AccessedThroughProperty("Button_EditSpeedAltitude")]
		private Button button_1;

		// Token: 0x0400354F RID: 13647
		[CompilerGenerated]
		[AccessedThroughProperty("Button_EditTime")]
		private Button button_2;

		// Token: 0x04003550 RID: 13648
		[CompilerGenerated]
		[AccessedThroughProperty("Button_DeleteWaypoint")]
		private Button button_3;

		// Token: 0x04003551 RID: 13649
		[CompilerGenerated]
		[AccessedThroughProperty("Button_InsertWaypoint")]
		private Button button_4;

		// Token: 0x04003552 RID: 13650
		[AccessedThroughProperty("ID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04003553 RID: 13651
		[AccessedThroughProperty("ObjectID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04003554 RID: 13652
		[CompilerGenerated]
		[AccessedThroughProperty("Type")]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		// Token: 0x04003555 RID: 13653
		[CompilerGenerated]
		[AccessedThroughProperty("Time_Zulu")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04003556 RID: 13654
		[AccessedThroughProperty("Time_Local")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04003557 RID: 13655
		[CompilerGenerated]
		[AccessedThroughProperty("TimeFixedImg")]
		private DataGridViewImageColumn dataGridViewImageColumn_0;

		// Token: 0x04003558 RID: 13656
		[AccessedThroughProperty("TimeFixed")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04003559 RID: 13657
		[AccessedThroughProperty("DesiredSpeed")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x0400355A RID: 13658
		[CompilerGenerated]
		[AccessedThroughProperty("SpeedFixedImg")]
		private DataGridViewImageColumn dataGridViewImageColumn_1;

		// Token: 0x0400355B RID: 13659
		[CompilerGenerated]
		[AccessedThroughProperty("SpeedFixed")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x0400355C RID: 13660
		[CompilerGenerated]
		[AccessedThroughProperty("DesiredAltitude")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x0400355D RID: 13661
		[CompilerGenerated]
		[AccessedThroughProperty("Leg_Distance")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		// Token: 0x0400355E RID: 13662
		[CompilerGenerated]
		[AccessedThroughProperty("Leg_TotalDistance")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		// Token: 0x0400355F RID: 13663
		[AccessedThroughProperty("Leg_Time")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		// Token: 0x04003560 RID: 13664
		[CompilerGenerated]
		[AccessedThroughProperty("Hold_Time")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		// Token: 0x04003561 RID: 13665
		[CompilerGenerated]
		[AccessedThroughProperty("Leg_TotalTime")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		// Token: 0x04003562 RID: 13666
		[CompilerGenerated]
		[AccessedThroughProperty("Leg_FuelRequired")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		// Token: 0x04003563 RID: 13667
		[CompilerGenerated]
		[AccessedThroughProperty("Leg_FuelRemaining")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		// Token: 0x04003564 RID: 13668
		[CompilerGenerated]
		[AccessedThroughProperty("Coordinates")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;
	}
}
