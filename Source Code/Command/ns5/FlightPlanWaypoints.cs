using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using ns10;
using ns12;
using ns2;
using ns3;
using ns4;

namespace ns5
{
	// Token: 0x02000D79 RID: 3449
	[DesignerGenerated]
	internal sealed class FlightPlanWaypoints : UserControl
	{
		// Token: 0x06005ABA RID: 23226 RVA: 0x0003A858 File Offset: 0x00038A58
		public FlightPlanWaypoints()
		{
			this.InitializeComponent();
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x0031DCB4 File Offset: 0x0031BEB4
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

		// Token: 0x06005ABC RID: 23228 RVA: 0x0031DCF4 File Offset: 0x0031BEF4
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
			DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
			this.vmethod_1(new Class114());
			this.vmethod_41(new DataGridViewTextBoxColumn());
			this.vmethod_43(new DataGridViewTextBoxColumn());
			this.vmethod_45(new DataGridViewComboBoxColumn());
			this.vmethod_47(new DataGridViewTextBoxColumn());
			this.vmethod_49(new DataGridViewTextBoxColumn());
			this.vmethod_51(new DataGridViewImageColumn());
			this.vmethod_53(new DataGridViewTextBoxColumn());
			this.vmethod_55(new DataGridViewTextBoxColumn());
			this.vmethod_57(new DataGridViewImageColumn());
			this.vmethod_59(new DataGridViewTextBoxColumn());
			this.vmethod_61(new DataGridViewTextBoxColumn());
			this.vmethod_63(new DataGridViewTextBoxColumn());
			this.vmethod_65(new DataGridViewTextBoxColumn());
			this.vmethod_67(new DataGridViewTextBoxColumn());
			this.vmethod_69(new DataGridViewTextBoxColumn());
			this.vmethod_71(new DataGridViewTextBoxColumn());
			this.vmethod_73(new DataGridViewTextBoxColumn());
			this.vmethod_75(new DataGridViewTextBoxColumn());
			this.vmethod_77(new DataGridViewComboBoxColumn());
			this.vmethod_79(new DataGridViewComboBoxColumn());
			this.vmethod_81(new DataGridViewComboBoxColumn());
			this.vmethod_83(new DataGridViewComboBoxColumn());
			this.vmethod_85(new DataGridViewTextBoxColumn());
			this.vmethod_87(new DataGridViewTextBoxColumn());
			this.vmethod_89(new DataGridViewTextBoxColumn());
			this.vmethod_91(new DataGridViewComboBoxColumn());
			this.vmethod_93(new DataGridViewTextBoxColumn());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Control9());
			this.vmethod_9(new Control9());
			this.vmethod_11(new Control9());
			this.vmethod_39(new Control9());
			this.vmethod_13(new Control9());
			this.vmethod_15(new DataGridViewTextBoxColumn());
			this.vmethod_17(new DataGridViewTextBoxColumn());
			this.vmethod_19(new DataGridViewTextBoxColumn());
			this.vmethod_21(new DataGridViewTextBoxColumn());
			this.vmethod_23(new DataGridViewTextBoxColumn());
			this.vmethod_25(new DataGridViewTextBoxColumn());
			this.vmethod_27(new DataGridViewTextBoxColumn());
			this.vmethod_29(new DataGridViewTextBoxColumn());
			this.vmethod_31(new DataGridViewTextBoxColumn());
			this.vmethod_33(new DataGridViewTextBoxColumn());
			this.vmethod_35(new DataGridViewTextBoxColumn());
			this.vmethod_37(new Control9());
			this.vmethod_95(new Control9());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToResizeColumns = false;
			this.vmethod_0().AllowUserToResizeRows = false;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().BorderStyle = BorderStyle.None;
			this.vmethod_0().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_0().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().ColumnHeadersHeight = 18;
			this.vmethod_0().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_40(),
				this.vmethod_42(),
				this.vmethod_44(),
				this.vmethod_46(),
				this.vmethod_48(),
				this.vmethod_50(),
				this.vmethod_52(),
				this.vmethod_54(),
				this.vmethod_56(),
				this.vmethod_58(),
				this.vmethod_60(),
				this.vmethod_62(),
				this.vmethod_64(),
				this.vmethod_66(),
				this.vmethod_68(),
				this.vmethod_70(),
				this.vmethod_72(),
				this.vmethod_74(),
				this.vmethod_76(),
				this.vmethod_78(),
				this.vmethod_80(),
				this.vmethod_82(),
				this.vmethod_84(),
				this.vmethod_86(),
				this.vmethod_88(),
				this.vmethod_90(),
				this.vmethod_92()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "DGV_Waypoints";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().RowHeadersWidth = 10;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle4.ForeColor = Color.LightGray;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle4.SelectionForeColor = Color.LightGray;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new Size(586, 303);
			this.vmethod_0().TabIndex = 10;
			this.vmethod_40().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.vmethod_40().DataPropertyName = "ID";
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_40().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_40().Frozen = true;
			this.vmethod_40().HeaderText = "#";
			this.vmethod_40().Name = "ID";
			this.vmethod_40().ReadOnly = true;
			this.vmethod_40().Width = 5;
			this.vmethod_42().DataPropertyName = "ObjectID";
			this.vmethod_42().HeaderText = "ObjectID";
			this.vmethod_42().Name = "ObjectID";
			this.vmethod_42().Visible = false;
			this.vmethod_44().AutoComplete = false;
			this.vmethod_44().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_44().DataPropertyName = "Type";
			this.vmethod_44().FlatStyle = FlatStyle.Flat;
			this.vmethod_44().Frozen = true;
			this.vmethod_44().HeaderText = "Type";
			this.vmethod_44().MaxDropDownItems = 20;
			this.vmethod_44().Name = "Type";
			this.vmethod_44().Resizable = DataGridViewTriState.True;
			this.vmethod_44().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_44().Width = 52;
			this.vmethod_46().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_46().DataPropertyName = "Time_Zulu";
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.BottomCenter;
			this.vmethod_46().DefaultCellStyle = dataGridViewCellStyle6;
			this.vmethod_46().HeaderText = "Zulu Time";
			this.vmethod_46().Name = "Time_Zulu";
			this.vmethod_46().ReadOnly = true;
			this.vmethod_46().Width = 79;
			this.vmethod_48().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_48().DataPropertyName = "Time_Local";
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.BottomCenter;
			this.vmethod_48().DefaultCellStyle = dataGridViewCellStyle7;
			this.vmethod_48().HeaderText = "Local Time";
			this.vmethod_48().Name = "Time_Local";
			this.vmethod_48().ReadOnly = true;
			this.vmethod_48().Width = 82;
			this.vmethod_50().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.vmethod_50().DataPropertyName = "TimeFixedImg";
			this.vmethod_50().HeaderText = " ";
			this.vmethod_50().Name = "TimeFixedImg";
			this.vmethod_50().Width = 5;
			this.vmethod_52().DataPropertyName = "TimeFixed";
			this.vmethod_52().HeaderText = "TimeFixed";
			this.vmethod_52().Name = "TimeFixed";
			this.vmethod_52().Resizable = DataGridViewTriState.True;
			this.vmethod_52().Visible = false;
			this.vmethod_52().Width = 5;
			this.vmethod_54().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_54().DataPropertyName = "DesiredSpeed";
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_54().DefaultCellStyle = dataGridViewCellStyle8;
			this.vmethod_54().HeaderText = " Speed";
			this.vmethod_54().Name = "DesiredSpeed";
			this.vmethod_54().ReadOnly = true;
			this.vmethod_54().Width = 65;
			this.vmethod_56().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.vmethod_56().DataPropertyName = "SpeedFixedImg";
			this.vmethod_56().HeaderText = " ";
			this.vmethod_56().Name = "SpeedFixedImg";
			this.vmethod_56().Width = 5;
			this.vmethod_58().DataPropertyName = "SpeedFixed";
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_58().DefaultCellStyle = dataGridViewCellStyle9;
			this.vmethod_58().HeaderText = "SpeedFixed";
			this.vmethod_58().Name = "SpeedFixed";
			this.vmethod_58().Resizable = DataGridViewTriState.True;
			this.vmethod_58().Visible = false;
			this.vmethod_58().Width = 5;
			this.vmethod_60().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_60().DataPropertyName = "DesiredAltitude";
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_60().DefaultCellStyle = dataGridViewCellStyle10;
			this.vmethod_60().HeaderText = "Altitude";
			this.vmethod_60().Name = "DesiredAltitude";
			this.vmethod_60().ReadOnly = true;
			this.vmethod_60().Width = 71;
			this.vmethod_62().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_62().DataPropertyName = "Leg_Distance";
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_62().DefaultCellStyle = dataGridViewCellStyle11;
			this.vmethod_62().HeaderText = "Leg Distance";
			this.vmethod_62().Name = "Leg_Distance";
			this.vmethod_62().Width = 95;
			this.vmethod_64().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_64().DataPropertyName = "Leg_TotalDistance";
			dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_64().DefaultCellStyle = dataGridViewCellStyle12;
			this.vmethod_64().HeaderText = "Total Distance";
			this.vmethod_64().Name = "Leg_TotalDistance";
			this.vmethod_64().Width = 101;
			this.vmethod_66().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_66().DataPropertyName = "Leg_Time";
			dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_66().DefaultCellStyle = dataGridViewCellStyle13;
			this.vmethod_66().HeaderText = "Leg Time";
			this.vmethod_66().Name = "Leg_Time";
			this.vmethod_66().ToolTipText = "Time needed to fly this leg.";
			this.vmethod_66().Width = 74;
			this.vmethod_68().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_68().DataPropertyName = "Hold_Time";
			dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_68().DefaultCellStyle = dataGridViewCellStyle14;
			this.vmethod_68().HeaderText = "Hold Time";
			this.vmethod_68().Name = "Hold_Time";
			this.vmethod_68().ToolTipText = "Loiter time at waypoint to allow flight to form up (Push Point).";
			this.vmethod_68().Width = 81;
			this.vmethod_70().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_70().DataPropertyName = "Leg_TotalTime";
			dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_70().DefaultCellStyle = dataGridViewCellStyle15;
			this.vmethod_70().HeaderText = "Total Time";
			this.vmethod_70().Name = "Leg_TotalTime";
			this.vmethod_70().Width = 80;
			this.vmethod_72().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_72().DataPropertyName = "Leg_FuelRequired";
			dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_72().DefaultCellStyle = dataGridViewCellStyle16;
			this.vmethod_72().HeaderText = "Leg Fuel";
			this.vmethod_72().Name = "Leg_FuelRequired";
			this.vmethod_72().ToolTipText = "Fuel neeed to fly this leg.";
			this.vmethod_72().Width = 73;
			this.vmethod_74().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_74().DataPropertyName = "Leg_FuelRemaining";
			dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_74().DefaultCellStyle = dataGridViewCellStyle17;
			this.vmethod_74().HeaderText = "Remaining Fuel";
			this.vmethod_74().Name = "Leg_FuelRemaining";
			this.vmethod_74().ToolTipText = "Remaining mission fuel (i.e. total fuel minus reserves) after this leg has been completed.";
			this.vmethod_74().Width = 110;
			this.vmethod_76().AutoComplete = false;
			this.vmethod_76().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_76().DataPropertyName = "SpeedToT";
			this.vmethod_76().FlatStyle = FlatStyle.Flat;
			this.vmethod_76().HeaderText = "Adjust Speed for ToT";
			this.vmethod_76().Name = "SpeedToT";
			this.vmethod_76().Resizable = DataGridViewTriState.True;
			this.vmethod_76().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_76().Width = 135;
			this.vmethod_78().AutoComplete = false;
			this.vmethod_78().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_78().DataPropertyName = "Formation";
			this.vmethod_78().FlatStyle = FlatStyle.Flat;
			this.vmethod_78().HeaderText = "Formation";
			this.vmethod_78().Name = "Formation";
			this.vmethod_78().Resizable = DataGridViewTriState.True;
			this.vmethod_78().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_78().Width = 83;
			this.vmethod_80().AutoComplete = false;
			this.vmethod_80().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_80().DataPropertyName = "AARUsage";
			this.vmethod_80().FlatStyle = FlatStyle.Flat;
			this.vmethod_80().HeaderText = "Tankers (AAR)";
			this.vmethod_80().Name = "AARUsage";
			this.vmethod_80().Resizable = DataGridViewTriState.True;
			this.vmethod_80().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_80().Width = 98;
			this.vmethod_82().AutoComplete = false;
			this.vmethod_82().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_82().DataPropertyName = "AARSelection";
			this.vmethod_82().FlatStyle = FlatStyle.Flat;
			this.vmethod_82().HeaderText = "Tanker Selection";
			this.vmethod_82().Name = "AARSelection";
			this.vmethod_82().Resizable = DataGridViewTriState.True;
			this.vmethod_82().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_82().Width = 113;
			this.vmethod_84().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_84().DataPropertyName = "AARSettings";
			this.vmethod_84().HeaderText = "Tanker Planner Settings";
			this.vmethod_84().Name = "AARSettings";
			this.vmethod_84().ReadOnly = true;
			this.vmethod_84().Width = 150;
			this.vmethod_86().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_86().DataPropertyName = "SensorUsage";
			this.vmethod_86().HeaderText = "Sensor Usage";
			this.vmethod_86().Name = "SensorUsage";
			this.vmethod_88().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_88().DataPropertyName = "Doctrine";
			this.vmethod_88().HeaderText = "Doctrine / EMCON / WRA";
			this.vmethod_88().Name = "Doctrine";
			this.vmethod_88().Width = 159;
			this.vmethod_90().AutoComplete = false;
			this.vmethod_90().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_90().DataPropertyName = "TurnRate";
			this.vmethod_90().FlatStyle = FlatStyle.Flat;
			this.vmethod_90().HeaderText = "Turn Rate";
			this.vmethod_90().Name = "TurnRate";
			this.vmethod_90().Width = 60;
			this.vmethod_92().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_92().DataPropertyName = "Coordinates";
			this.vmethod_92().HeaderText = "Coordinates";
			this.vmethod_92().Name = "Coordinates";
			this.vmethod_92().Width = 93;
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DialogResult = DialogResult.None;
			this.vmethod_2().Font = new Font(Client.font_1.FontFamily, 8f);
			this.vmethod_2().ForeColor = SystemColors.Control;
			this.vmethod_2().Location = new Point(-1, 305);
			this.vmethod_2().Name = "Button_InsertWaypoint";
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(95, 24);
			this.vmethod_2().TabIndex = 12;
			this.vmethod_2().Text = "Insert Waypoint";
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().Font = new Font(Client.font_1.FontFamily, 8f);
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(95, 305);
			this.vmethod_4().Name = "Button_DeleteWaypoint";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(95, 24);
			this.vmethod_4().TabIndex = 13;
			this.vmethod_4().Text = "Delete Waypoint";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font(Client.font_1.FontFamily, 8f);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(307, 305);
			this.vmethod_6().Name = "Button_EditTime";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(115, 24);
			this.vmethod_6().TabIndex = 16;
			this.vmethod_6().Text = "Edit Time";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DialogResult = DialogResult.None;
			this.vmethod_8().Font = new Font(Client.font_1.FontFamily, 8f);
			this.vmethod_8().ForeColor = SystemColors.Control;
			this.vmethod_8().Location = new Point(191, 305);
			this.vmethod_8().Name = "Button_EditSpeedAltitude";
			this.vmethod_8().method_1(0);
			this.vmethod_8().Size = new Size(115, 24);
			this.vmethod_8().TabIndex = 17;
			this.vmethod_8().Text = "Edit Speed / Altitude";
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DialogResult = DialogResult.None;
			this.vmethod_10().Font = new Font(Client.font_1.FontFamily, 8f);
			this.vmethod_10().ForeColor = SystemColors.Control;
			this.vmethod_10().Location = new Point(-1, 329);
			this.vmethod_10().Name = "Button_EditDoctrine";
			this.vmethod_10().method_1(0);
			this.vmethod_10().Size = new Size(174, 24);
			this.vmethod_10().TabIndex = 18;
			this.vmethod_10().Text = "Edit Doctrine / EMCON / WRA";
			this.vmethod_38().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_38().BackColor = Color.Transparent;
			this.vmethod_38().DialogResult = DialogResult.None;
			this.vmethod_38().Font = new Font(Client.font_1.FontFamily, 8f);
			this.vmethod_38().ForeColor = SystemColors.Control;
			this.vmethod_38().Location = new Point(349, 329);
			this.vmethod_38().Name = "Button_EditSensorUsage";
			this.vmethod_38().method_1(0);
			this.vmethod_38().Size = new Size(144, 24);
			this.vmethod_38().TabIndex = 19;
			this.vmethod_38().Text = "Edit Sensor Usage";
			this.vmethod_12().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font(Client.font_1.FontFamily, 8f);
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(174, 329);
			this.vmethod_12().Name = "Button_EditAAR";
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(174, 24);
			this.vmethod_12().TabIndex = 20;
			this.vmethod_12().Text = "Edit Air-to-Air Refuelling Settings";
			this.vmethod_14().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_14().DataPropertyName = "ID";
			this.vmethod_14().Frozen = true;
			this.vmethod_14().HeaderText = "Wpt";
			this.vmethod_14().Name = "DataGridViewTextBoxColumn1";
			this.vmethod_14().ReadOnly = true;
			this.vmethod_16().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_16().DataPropertyName = "Time_Zulu";
			dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.BottomCenter;
			this.vmethod_16().DefaultCellStyle = dataGridViewCellStyle18;
			this.vmethod_16().HeaderText = "Zulu";
			this.vmethod_16().Name = "DataGridViewTextBoxColumn2";
			this.vmethod_16().ReadOnly = true;
			this.vmethod_18().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_18().DataPropertyName = "Time_Local";
			dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.BottomCenter;
			this.vmethod_18().DefaultCellStyle = dataGridViewCellStyle19;
			this.vmethod_18().HeaderText = "Local";
			this.vmethod_18().Name = "DataGridViewTextBoxColumn3";
			this.vmethod_18().ReadOnly = true;
			this.vmethod_20().DataPropertyName = "TimeFixed";
			this.vmethod_20().HeaderText = "TimeFixed";
			this.vmethod_20().Name = "DataGridViewTextBoxColumn4";
			this.vmethod_20().Resizable = DataGridViewTriState.True;
			this.vmethod_20().Visible = false;
			this.vmethod_20().Width = 5;
			this.vmethod_22().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_22().DataPropertyName = "DesiredSpeed";
			this.vmethod_22().HeaderText = " ";
			this.vmethod_22().Name = "DataGridViewTextBoxColumn5";
			this.vmethod_22().ReadOnly = true;
			this.vmethod_24().DataPropertyName = "SpeedFixed";
			this.vmethod_24().HeaderText = "SpeedFixed";
			this.vmethod_24().Name = "DataGridViewTextBoxColumn6";
			this.vmethod_24().Resizable = DataGridViewTriState.True;
			this.vmethod_24().Visible = false;
			this.vmethod_24().Width = 5;
			this.vmethod_26().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_26().DataPropertyName = "DesiredAltitude";
			this.vmethod_26().HeaderText = "DesiredAltitude";
			this.vmethod_26().Name = "DataGridViewTextBoxColumn7";
			this.vmethod_26().ReadOnly = true;
			this.vmethod_28().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_28().DataPropertyName = "AARSettings";
			this.vmethod_28().HeaderText = "AARSettings";
			this.vmethod_28().Name = "DataGridViewTextBoxColumn8";
			this.vmethod_28().ReadOnly = true;
			this.vmethod_30().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_30().DataPropertyName = "Doctrine";
			this.vmethod_30().HeaderText = "Doctrine / EMCON / WRA";
			this.vmethod_30().Name = "DataGridViewTextBoxColumn9";
			this.vmethod_32().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_32().DataPropertyName = "SensorUsage";
			this.vmethod_32().HeaderText = "Sensor Usage";
			this.vmethod_32().Name = "DataGridViewTextBoxColumn10";
			this.vmethod_34().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_34().DataPropertyName = "Coordinates";
			this.vmethod_34().HeaderText = "Coordinates";
			this.vmethod_34().Name = "DataGridViewTextBoxColumn11";
			this.vmethod_36().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_36().BackColor = Color.Transparent;
			this.vmethod_36().DialogResult = DialogResult.None;
			this.vmethod_36().Font = new Font(Client.font_1.FontFamily, 8f);
			this.vmethod_36().ForeColor = SystemColors.Control;
			this.vmethod_36().Location = new Point(423, 305);
			this.vmethod_36().Name = "Button_ClearTime";
			this.vmethod_36().method_1(0);
			this.vmethod_36().Size = new Size(70, 24);
			this.vmethod_36().TabIndex = 21;
			this.vmethod_36().Text = "Clear Time";
			this.vmethod_94().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_94().BackColor = Color.Transparent;
			this.vmethod_94().DialogResult = DialogResult.None;
			this.vmethod_94().Font = new Font(Client.font_1.FontFamily, 8f);
			this.vmethod_94().ForeColor = SystemColors.Control;
			this.vmethod_94().Location = new Point(494, 305);
			this.vmethod_94().Name = "Button_EditTargetAndWeapons";
			this.vmethod_94().method_1(0);
			this.vmethod_94().Size = new Size(92, 48);
			this.vmethod_94().TabIndex = 21;
			this.vmethod_94().Text = "Targeteering & Weaponeering";
			base.AutoScaleMode = AutoScaleMode.None;
			base.Controls.Add(this.vmethod_94());
			base.Controls.Add(this.vmethod_36());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_38());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.Name = "FlightPlanWaypoints";
			base.Size = new Size(586, 352);
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x0003A866 File Offset: 0x00038A66
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x0031F8A4 File Offset: 0x0031DAA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			DataGridViewCellPaintingEventHandler value = new DataGridViewCellPaintingEventHandler(this.method_7);
			DataGridViewColumnEventHandler value2 = new DataGridViewColumnEventHandler(this.method_8);
			PaintEventHandler value3 = new PaintEventHandler(this.method_9);
			ScrollEventHandler value4 = new ScrollEventHandler(this.method_10);
			EventHandler value5 = new EventHandler(this.method_11);
			EventHandler value6 = new EventHandler(this.method_12);
			EventHandler value7 = new EventHandler(this.method_13);
			DataGridViewCellEventHandler value8 = new DataGridViewCellEventHandler(this.method_17);
			DataGridViewCellEventHandler value9 = new DataGridViewCellEventHandler(this.method_18);
			EventHandler value10 = new EventHandler(this.method_19);
			EventHandler value11 = new EventHandler(this.method_21);
			Class114 @class = this.class114_0;
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
			this.class114_0 = class114_1;
			@class = this.class114_0;
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

		// Token: 0x06005ABF RID: 23231 RVA: 0x0003A86E File Offset: 0x00038A6E
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x06005AC0 RID: 23232 RVA: 0x0031FA24 File Offset: 0x0031DC24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_0);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_9;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x0003A876 File Offset: 0x00038A76
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_1;
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x0031FA68 File Offset: 0x0031DC68
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_1);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_9;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x0003A87E File Offset: 0x00038A7E
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_2;
		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x0031FAAC File Offset: 0x0031DCAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_2);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_9;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x0003A886 File Offset: 0x00038A86
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_3;
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x0031FAF0 File Offset: 0x0031DCF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_9;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06005AC7 RID: 23239 RVA: 0x0003A88E File Offset: 0x00038A8E
		[CompilerGenerated]
		internal Control9 vmethod_10()
		{
			return this.control9_4;
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x0031FB34 File Offset: 0x0031DD34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_4;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_4 = control9_9;
			control = this.control9_4;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x0003A896 File Offset: 0x00038A96
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_5;
		}

		// Token: 0x06005ACA RID: 23242 RVA: 0x0031FB78 File Offset: 0x0031DD78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_5);
			Control9 control = this.control9_5;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_5 = control9_9;
			control = this.control9_5;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06005ACB RID: 23243 RVA: 0x0003A89E File Offset: 0x00038A9E
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_14()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x0003A8A6 File Offset: 0x00038AA6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x0003A8AF File Offset: 0x00038AAF
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_16()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x0003A8B7 File Offset: 0x00038AB7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x0003A8C0 File Offset: 0x00038AC0
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_18()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x0003A8C8 File Offset: 0x00038AC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x0003A8D1 File Offset: 0x00038AD1
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_20()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x0003A8D9 File Offset: 0x00038AD9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x0003A8E2 File Offset: 0x00038AE2
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_22()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x0003A8EA File Offset: 0x00038AEA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x0003A8F3 File Offset: 0x00038AF3
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_24()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x0003A8FB File Offset: 0x00038AFB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x0003A904 File Offset: 0x00038B04
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_26()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06005AD8 RID: 23256 RVA: 0x0003A90C File Offset: 0x00038B0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x0003A915 File Offset: 0x00038B15
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_28()
		{
			return this.dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x0003A91D File Offset: 0x00038B1D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x0003A926 File Offset: 0x00038B26
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_30()
		{
			return this.dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x0003A92E File Offset: 0x00038B2E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_8 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x0003A937 File Offset: 0x00038B37
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_32()
		{
			return this.dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x0003A93F File Offset: 0x00038B3F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_9 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x0003A948 File Offset: 0x00038B48
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_34()
		{
			return this.dataGridViewTextBoxColumn_10;
		}

		// Token: 0x06005AE0 RID: 23264 RVA: 0x0003A950 File Offset: 0x00038B50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_10 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AE1 RID: 23265 RVA: 0x0003A959 File Offset: 0x00038B59
		[CompilerGenerated]
		internal Control9 vmethod_36()
		{
			return this.control9_6;
		}

		// Token: 0x06005AE2 RID: 23266 RVA: 0x0031FBBC File Offset: 0x0031DDBC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_22);
			Control9 control = this.control9_6;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_6 = control9_9;
			control = this.control9_6;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x0003A961 File Offset: 0x00038B61
		[CompilerGenerated]
		internal Control9 vmethod_38()
		{
			return this.control9_7;
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x0031FC00 File Offset: 0x0031DE00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_6);
			Control9 control = this.control9_7;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_7 = control9_9;
			control = this.control9_7;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x0003A969 File Offset: 0x00038B69
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_40()
		{
			return this.dataGridViewTextBoxColumn_11;
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x0003A971 File Offset: 0x00038B71
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_11 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x0003A97A File Offset: 0x00038B7A
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_42()
		{
			return this.dataGridViewTextBoxColumn_12;
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x0003A982 File Offset: 0x00038B82
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_12 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x0003A98B File Offset: 0x00038B8B
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_44()
		{
			return this.dataGridViewComboBoxColumn_0;
		}

		// Token: 0x06005AEA RID: 23274 RVA: 0x0003A993 File Offset: 0x00038B93
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_6)
		{
			this.dataGridViewComboBoxColumn_0 = dataGridViewComboBoxColumn_6;
		}

		// Token: 0x06005AEB RID: 23275 RVA: 0x0003A99C File Offset: 0x00038B9C
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_46()
		{
			return this.dataGridViewTextBoxColumn_13;
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x0003A9A4 File Offset: 0x00038BA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_13 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AED RID: 23277 RVA: 0x0003A9AD File Offset: 0x00038BAD
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_48()
		{
			return this.dataGridViewTextBoxColumn_14;
		}

		// Token: 0x06005AEE RID: 23278 RVA: 0x0003A9B5 File Offset: 0x00038BB5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_14 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x0003A9BE File Offset: 0x00038BBE
		[CompilerGenerated]
		internal DataGridViewImageColumn vmethod_50()
		{
			return this.dataGridViewImageColumn_0;
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x0003A9C6 File Offset: 0x00038BC6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(DataGridViewImageColumn dataGridViewImageColumn_2)
		{
			this.dataGridViewImageColumn_0 = dataGridViewImageColumn_2;
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x0003A9CF File Offset: 0x00038BCF
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_52()
		{
			return this.dataGridViewTextBoxColumn_15;
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x0003A9D7 File Offset: 0x00038BD7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_15 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AF3 RID: 23283 RVA: 0x0003A9E0 File Offset: 0x00038BE0
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_54()
		{
			return this.dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06005AF4 RID: 23284 RVA: 0x0003A9E8 File Offset: 0x00038BE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_16 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AF5 RID: 23285 RVA: 0x0003A9F1 File Offset: 0x00038BF1
		[CompilerGenerated]
		internal DataGridViewImageColumn vmethod_56()
		{
			return this.dataGridViewImageColumn_1;
		}

		// Token: 0x06005AF6 RID: 23286 RVA: 0x0003A9F9 File Offset: 0x00038BF9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(DataGridViewImageColumn dataGridViewImageColumn_2)
		{
			this.dataGridViewImageColumn_1 = dataGridViewImageColumn_2;
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x0003AA02 File Offset: 0x00038C02
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_58()
		{
			return this.dataGridViewTextBoxColumn_17;
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x0003AA0A File Offset: 0x00038C0A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_17 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x0003AA13 File Offset: 0x00038C13
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_60()
		{
			return this.dataGridViewTextBoxColumn_18;
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x0003AA1B File Offset: 0x00038C1B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_18 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x0003AA24 File Offset: 0x00038C24
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_62()
		{
			return this.dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x0003AA2C File Offset: 0x00038C2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_19 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x0003AA35 File Offset: 0x00038C35
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_64()
		{
			return this.dataGridViewTextBoxColumn_20;
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x0003AA3D File Offset: 0x00038C3D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_20 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x0003AA46 File Offset: 0x00038C46
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_66()
		{
			return this.dataGridViewTextBoxColumn_21;
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x0003AA4E File Offset: 0x00038C4E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_21 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x0003AA57 File Offset: 0x00038C57
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_68()
		{
			return this.dataGridViewTextBoxColumn_22;
		}

		// Token: 0x06005B02 RID: 23298 RVA: 0x0003AA5F File Offset: 0x00038C5F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_22 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005B03 RID: 23299 RVA: 0x0003AA68 File Offset: 0x00038C68
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_70()
		{
			return this.dataGridViewTextBoxColumn_23;
		}

		// Token: 0x06005B04 RID: 23300 RVA: 0x0003AA70 File Offset: 0x00038C70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_23 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005B05 RID: 23301 RVA: 0x0003AA79 File Offset: 0x00038C79
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_72()
		{
			return this.dataGridViewTextBoxColumn_24;
		}

		// Token: 0x06005B06 RID: 23302 RVA: 0x0003AA81 File Offset: 0x00038C81
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_24 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005B07 RID: 23303 RVA: 0x0003AA8A File Offset: 0x00038C8A
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_74()
		{
			return this.dataGridViewTextBoxColumn_25;
		}

		// Token: 0x06005B08 RID: 23304 RVA: 0x0003AA92 File Offset: 0x00038C92
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_25 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005B09 RID: 23305 RVA: 0x0003AA9B File Offset: 0x00038C9B
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_76()
		{
			return this.dataGridViewComboBoxColumn_1;
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x0003AAA3 File Offset: 0x00038CA3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_6)
		{
			this.dataGridViewComboBoxColumn_1 = dataGridViewComboBoxColumn_6;
		}

		// Token: 0x06005B0B RID: 23307 RVA: 0x0003AAAC File Offset: 0x00038CAC
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_78()
		{
			return this.dataGridViewComboBoxColumn_2;
		}

		// Token: 0x06005B0C RID: 23308 RVA: 0x0003AAB4 File Offset: 0x00038CB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_6)
		{
			this.dataGridViewComboBoxColumn_2 = dataGridViewComboBoxColumn_6;
		}

		// Token: 0x06005B0D RID: 23309 RVA: 0x0003AABD File Offset: 0x00038CBD
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_80()
		{
			return this.dataGridViewComboBoxColumn_3;
		}

		// Token: 0x06005B0E RID: 23310 RVA: 0x0003AAC5 File Offset: 0x00038CC5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_6)
		{
			this.dataGridViewComboBoxColumn_3 = dataGridViewComboBoxColumn_6;
		}

		// Token: 0x06005B0F RID: 23311 RVA: 0x0003AACE File Offset: 0x00038CCE
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_82()
		{
			return this.dataGridViewComboBoxColumn_4;
		}

		// Token: 0x06005B10 RID: 23312 RVA: 0x0003AAD6 File Offset: 0x00038CD6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_6)
		{
			this.dataGridViewComboBoxColumn_4 = dataGridViewComboBoxColumn_6;
		}

		// Token: 0x06005B11 RID: 23313 RVA: 0x0003AADF File Offset: 0x00038CDF
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_84()
		{
			return this.dataGridViewTextBoxColumn_26;
		}

		// Token: 0x06005B12 RID: 23314 RVA: 0x0003AAE7 File Offset: 0x00038CE7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_26 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005B13 RID: 23315 RVA: 0x0003AAF0 File Offset: 0x00038CF0
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_86()
		{
			return this.dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06005B14 RID: 23316 RVA: 0x0003AAF8 File Offset: 0x00038CF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_27 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005B15 RID: 23317 RVA: 0x0003AB01 File Offset: 0x00038D01
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_88()
		{
			return this.dataGridViewTextBoxColumn_28;
		}

		// Token: 0x06005B16 RID: 23318 RVA: 0x0003AB09 File Offset: 0x00038D09
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_28 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005B17 RID: 23319 RVA: 0x0003AB12 File Offset: 0x00038D12
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_90()
		{
			return this.dataGridViewComboBoxColumn_5;
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x0003AB1A File Offset: 0x00038D1A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_6)
		{
			this.dataGridViewComboBoxColumn_5 = dataGridViewComboBoxColumn_6;
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x0003AB23 File Offset: 0x00038D23
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_92()
		{
			return this.dataGridViewTextBoxColumn_29;
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x0003AB2B File Offset: 0x00038D2B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_29 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06005B1B RID: 23323 RVA: 0x0003AB34 File Offset: 0x00038D34
		[CompilerGenerated]
		internal Control9 vmethod_94()
		{
			return this.control9_8;
		}

		// Token: 0x06005B1C RID: 23324 RVA: 0x0031FC44 File Offset: 0x0031DE44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_22);
			EventHandler value2 = new EventHandler(this.method_23);
			Control9 control = this.control9_8;
			if (control != null)
			{
				control.Click -= value;
				control.Click -= value2;
			}
			this.control9_8 = control9_9;
			control = this.control9_8;
			if (control != null)
			{
				control.Click += value;
				control.Click += value2;
			}
		}

		// Token: 0x06005B1D RID: 23325 RVA: 0x0031FCA4 File Offset: 0x0031DEA4
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
							if (this.enum106_0 != Mission.Flight.Enum106.const_1)
							{
								waypoint = Client.smethod_32().flight_0.method_15()[i];
							}
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
								goto IL_158;
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
								goto IL_158;
							case Waypoint.WaypointType.TurningPoint:
								waypointType_ = Waypoint.WaypointType.TurningPoint;
								goto IL_158;
							case Waypoint.WaypointType.InitialPoint:
							case Waypoint.WaypointType.Split:
							case Waypoint.WaypointType.WeaponLaunch:
								waypointType_ = Waypoint.WaypointType.StrikeIngress;
								goto IL_158;
							case Waypoint.WaypointType.Formate:
							case Waypoint.WaypointType.Target:
							case Waypoint.WaypointType.WeaponTarget:
								waypointType_ = Waypoint.WaypointType.StrikeEgress;
								goto IL_158;
							case Waypoint.WaypointType.StrikeIngress:
								waypointType_ = Waypoint.WaypointType.StrikeIngress;
								goto IL_158;
							case Waypoint.WaypointType.StrikeEgress:
								waypointType_ = Waypoint.WaypointType.StrikeEgress;
								goto IL_158;
							}
							waypointType_ = Waypoint.WaypointType.ManualPlottedCourseWaypoint;
							IL_158:
							GeoPoint geoPoint = new GeoPoint();
							GeoPoint geoPoint2 = new GeoPoint();
							GeoPoint geoPoint3 = new GeoPoint();
							GeoPoint geoPoint4 = new GeoPoint();
							GeoPoint geoPoint5 = new GeoPoint();
							GeoPoint geoPoint6 = new GeoPoint();
							if (i + 1 <= count - 1)
							{
								Waypoint waypoint2 = Client.smethod_32().flight_0.method_15()[i + 1];
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
							Mission.Flight flight_ = Client.smethod_32().flight_0;
							Waypoint[] array = flight_.method_15();
							ActiveUnit_Navigator.smethod_1(ref array, i + 1, waypoint8);
							flight_.method_16(array);
							IL_A32:
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
													array = activeUnit_Navigator.method_4();
													ActiveUnit_Navigator.smethod_1(ref array, k + 1, waypoint8);
													activeUnit_Navigator.method_5(array);
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
								Client.smethod_32().int_0 = this.vmethod_0().SelectedRows[0].Index;
								Client.smethod_32().waypoint_0 = (Waypoint)this.vmethod_0().Rows[Client.smethod_32().int_0].Tag;
								this.vmethod_0().Rows[0].Selected = false;
							}
							Client.smethod_32().method_34(true, true, true, true, false);
							if (Client.flightPlanTime_0.Visible && Client.flightPlanTime_0.bool_3)
							{
								Client.flightPlanTime_0.method_4(ref Client.smethod_32().mission_0, ref Client.smethod_32().flight_0, ref Client.smethod_32().waypoint_0, Client.smethod_32().flightPlanWaypoints_6.enum106_0, true);
							}
							if (Client.smethod_31().Visible)
							{
								Client.smethod_31().method_5();
							}
							return;
						}
					}
				}
				goto IL_A32;
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

		// Token: 0x06005B1E RID: 23326 RVA: 0x0032093C File Offset: 0x0031EB3C
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
								if (this.enum106_0 != Mission.Flight.Enum106.const_1)
								{
									waypoint = Client.smethod_32().flight_0.method_15()[i];
								}
								if (waypoint.method_22())
								{
									Interaction.MsgBox("Cannot delete waypoints with Split formation. Change the formation and try again.", MsgBoxStyle.OkOnly, null);
								}
								else
								{
									if (!Information.IsNothing(waypoint))
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
									ActiveUnit_Navigator.smethod_2(Client.smethod_46(), Client.smethod_32().mission_0, Client.smethod_32().flight_0, waypoint);
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
						Client.smethod_32().int_0 = this.vmethod_0().SelectedRows[0].Index;
						Client.smethod_32().waypoint_0 = (Waypoint)this.vmethod_0().Rows[Client.smethod_32().int_0].Tag;
						this.vmethod_0().Rows[0].Selected = false;
					}
					Client.smethod_32().method_34(true, true, true, true, false);
					if (Client.flightPlanTime_0.Visible && Client.flightPlanTime_0.bool_3)
					{
						Client.flightPlanTime_0.method_4(ref Client.smethod_32().mission_0, ref Client.smethod_32().flight_0, ref Client.smethod_32().waypoint_0, Client.smethod_32().flightPlanWaypoints_6.enum106_0, true);
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

		// Token: 0x06005B1F RID: 23327 RVA: 0x00320D70 File Offset: 0x0031EF70
		private void method_2(object sender, EventArgs e)
		{
			for (int i = Client.smethod_32().flightPlanWaypoints_6.vmethod_0().Rows.Count - 1; i >= 0; i += -1)
			{
				DataGridViewRow dataGridViewRow = Client.smethod_32().flightPlanWaypoints_6.vmethod_0().Rows[i];
				if (dataGridViewRow.Selected)
				{
					Waypoint waypoint = (Waypoint)dataGridViewRow.Tag;
					IL_57:
					if (!Information.IsNothing(waypoint) && (Client.smethod_32().flight_0.enum93_0 != Mission.Enum93.const_1 || waypoint.method_41()))
					{
						Client.flightPlanTime_0.bool_3 = true;
						Client.flightPlanTime_0.method_4(ref Client.smethod_32().mission_0, ref Client.smethod_32().flight_0, ref Client.smethod_32().waypoint_0, Client.smethod_32().flightPlanWaypoints_6.enum106_0, true);
						Client.flightPlanTime_0.Show();
						Client.flightPlanTime_0.BringToFront();
					}
					return;
				}
			}
			goto IL_57;
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x00320E50 File Offset: 0x0031F050
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
					Class2413.smethod_2().method_66().flight_0 = Client.smethod_32().flight_0;
					Class2413.smethod_2().method_66().mission_0 = Client.smethod_32().mission_0;
					Class2413.smethod_2().method_66().Show();
					return;
				}
			}
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x00320F04 File Offset: 0x0031F104
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count > 0)
			{
				Waypoint waypoint = (Waypoint)this.vmethod_0().SelectedRows[0].Tag;
				if (!Information.IsNothing(waypoint))
				{
					MainForm mainForm = Class2413.smethod_2().method_41();
					Class310 class310_ = waypoint;
					ReadOnlyCollection<Unit> readOnlyCollection = null;
					List<ActiveUnit> list = null;
					mainForm.method_308(class310_, ref readOnlyCollection, ref list, false);
				}
			}
		}

		// Token: 0x06005B22 RID: 23330 RVA: 0x00320F64 File Offset: 0x0031F164
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count > 0)
			{
				Waypoint waypoint = (Waypoint)this.vmethod_0().SelectedRows[0].Tag;
				if (!Information.IsNothing(waypoint) && waypoint.waypointType_0 == Waypoint.WaypointType.Refuel)
				{
					Class2413.smethod_2().method_70().mission_0 = null;
					Class2413.smethod_2().method_70().waypoint_0 = waypoint;
					Class2413.smethod_2().method_70().Show();
				}
			}
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x00320FE4 File Offset: 0x0031F1E4
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count > 0)
			{
				Waypoint waypoint = (Waypoint)this.vmethod_0().SelectedRows[0].Tag;
				if (!Information.IsNothing(waypoint))
				{
					DoctrineForm doctrineForm = new DoctrineForm();
					doctrineForm.class310_0 = waypoint;
					doctrineForm.bool_8 = false;
					doctrineForm.Show();
					doctrineForm.vmethod_0().SelectedIndex = 1;
				}
			}
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x0032104C File Offset: 0x0031F24C
		private void method_7(object sender, DataGridViewCellPaintingEventArgs e)
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

		// Token: 0x06005B25 RID: 23333 RVA: 0x00321A3C File Offset: 0x0031FC3C
		private void method_8(object sender, DataGridViewColumnEventArgs e)
		{
			Rectangle displayRectangle = this.vmethod_0().DisplayRectangle;
			this.vmethod_0().Invalidate(displayRectangle);
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_9(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06005B27 RID: 23335 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_10(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06005B28 RID: 23336 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_11(object sender, EventArgs e)
		{
		}

		// Token: 0x06005B29 RID: 23337 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_12(object sender, EventArgs e)
		{
		}

		// Token: 0x06005B2A RID: 23338 RVA: 0x0003AB3C File Offset: 0x00038D3C
		private void method_13(object sender, EventArgs e)
		{
			if (Client.smethod_32().bool_3)
			{
				this.method_14();
				this.method_15();
				this.method_16();
			}
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x00321A64 File Offset: 0x0031FC64
		public void method_14()
		{
			try
			{
				Client.smethod_32().bitmap_0.MakeTransparent(Color.White);
				Client.smethod_32().bitmap_1.MakeTransparent(Color.White);
				Client.smethod_32().bitmap_2.MakeTransparent(Color.White);
				Client.smethod_32().bitmap_3.MakeTransparent(Color.White);
				Client.smethod_32().bitmap_4.MakeTransparent(Color.White);
				bool bool_ = Client.smethod_32().bool_3;
				Client.smethod_32().bool_3 = false;
				try
				{
					foreach (object obj in ((IEnumerable)this.vmethod_0().Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["TimeFixed"].Value), 1))
						{
							if (dataGridViewRow.Cells["TimeFixedImg"].Value != Client.smethod_32().bitmap_0)
							{
								dataGridViewRow.Cells["TimeFixedImg"].Value = Client.smethod_32().bitmap_0;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["TimeFixed"].Value), 0))
						{
							if (dataGridViewRow.Cells["TimeFixedImg"].Value != Client.smethod_32().bitmap_1)
							{
								dataGridViewRow.Cells["TimeFixedImg"].Value = Client.smethod_32().bitmap_1;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["TimeFixed"].Value), 2))
						{
							if (dataGridViewRow.Cells["TimeFixedImg"].Value != Client.smethod_32().bitmap_3)
							{
								dataGridViewRow.Cells["TimeFixedImg"].Value = Client.smethod_32().bitmap_3;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["TimeFixed"].Value), 3))
						{
							if (dataGridViewRow.Cells["TimeFixedImg"].Value != Client.smethod_32().bitmap_4)
							{
								dataGridViewRow.Cells["TimeFixedImg"].Value = Client.smethod_32().bitmap_4;
							}
						}
						else if (dataGridViewRow.Cells["TimeFixedImg"].Value != Client.smethod_32().bitmap_2)
						{
							dataGridViewRow.Cells["TimeFixedImg"].Value = Client.smethod_32().bitmap_2;
						}
						if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["SpeedFixed"].Value), 1))
						{
							if (dataGridViewRow.Cells["SpeedFixedImg"].Value != Client.smethod_32().bitmap_0)
							{
								dataGridViewRow.Cells["SpeedFixedImg"].Value = Client.smethod_32().bitmap_0;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["SpeedFixed"].Value), 0))
						{
							if (dataGridViewRow.Cells["SpeedFixedImg"].Value != Client.smethod_32().bitmap_1)
							{
								dataGridViewRow.Cells["SpeedFixedImg"].Value = Client.smethod_32().bitmap_1;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["SpeedFixed"].Value), 2))
						{
							if (dataGridViewRow.Cells["SpeedFixedImg"].Value != Client.smethod_32().bitmap_3)
							{
								dataGridViewRow.Cells["SpeedFixedImg"].Value = Client.smethod_32().bitmap_3;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["SpeedFixed"].Value), 3))
						{
							if (dataGridViewRow.Cells["SpeedFixedImg"].Value != Client.smethod_32().bitmap_4)
							{
								dataGridViewRow.Cells["SpeedFixedImg"].Value = Client.smethod_32().bitmap_4;
							}
						}
						else if (dataGridViewRow.Cells["SpeedFixedImg"].Value != Client.smethod_32().bitmap_2)
						{
							dataGridViewRow.Cells["SpeedFixedImg"].Value = Client.smethod_32().bitmap_2;
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
				Client.smethod_32().bool_3 = bool_;
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

		// Token: 0x06005B2C RID: 23340 RVA: 0x00321F94 File Offset: 0x00320194
		public void method_15()
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
							bool flag = true;
							Doctrine.Enum56? @enum = waypoint.method_18().method_152(Client.smethod_46(), false, false, false, false);
							byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
							bool? flag2 = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
							bool? flag3 = flag2 = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
							bool? flag4;
							bool? flag10;
							if (flag2 != null && !flag3.GetValueOrDefault())
							{
								flag4 = new bool?(false);
							}
							else
							{
								b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
								bool? flag6;
								bool? flag5 = flag6 = ((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null);
								Doctrine.Enum56? enum2;
								bool? flag7 = flag5 = ((flag6 == null || flag5.GetValueOrDefault()) ? (flag5 & !Information.IsNothing(enum2)) : new bool?(false));
								bool? flag8;
								if (flag5 != null && !flag7.GetValueOrDefault())
								{
									flag8 = new bool?(false);
								}
								else
								{
									b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
									bool? flag9 = flag5 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
									flag8 = ((flag5 != null) ? (flag7 & flag9.GetValueOrDefault()) : null);
								}
								flag2 = flag8;
								flag10 = (flag2 = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2));
								flag4 = ((flag2 != null) ? (flag3 & flag10.GetValueOrDefault()) : null);
							}
							flag10 = flag4;
							if (flag10.GetValueOrDefault())
							{
								if (dataGridViewRow.Cells["AARSelection"].ReadOnly)
								{
									dataGridViewRow.Cells["AARSelection"].ReadOnly = false;
									dataGridViewRow.Cells["AARSelection"].Style.BackColor = default(Color);
									dataGridViewRow.Cells["AARSelection"].Style.ForeColor = default(Color);
									dataGridViewRow.Cells["AARSelection"].Style.SelectionBackColor = default(Color);
									dataGridViewRow.Cells["AARSelection"].Style.SelectionForeColor = default(Color);
								}
							}
							else
							{
								flag = false;
								dataGridViewRow.Cells["AARSelection"].ReadOnly = true;
								dataGridViewRow.Cells["AARSelection"].Style.BackColor = Color.LightGray;
								dataGridViewRow.Cells["AARSelection"].Style.ForeColor = dataGridViewRow.Cells["AARSelection"].Style.BackColor;
								dataGridViewRow.Cells["AARSelection"].Style.SelectionBackColor = Color.LightGray;
								dataGridViewRow.Cells["AARSelection"].Style.SelectionForeColor = dataGridViewRow.Cells["AARSelection"].Style.SelectionBackColor;
							}
							b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
							flag10 = ((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null);
							if (((flag10 != null) ? new bool?(!flag10.GetValueOrDefault()) : flag10).GetValueOrDefault())
							{
								Doctrine.Enum56? enum2 = @enum;
							}
							if (waypoint.waypointType_0 == Waypoint.WaypointType.StationEnd || waypoint.waypointType_0 == Waypoint.WaypointType.Assemble || waypoint.waypointType_0 == Waypoint.WaypointType.HoldEnd)
							{
								goto IL_749;
							}
							if (waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
							{
								goto IL_749;
							}
							if (dataGridViewRow.Cells["SpeedToT"].ReadOnly)
							{
								dataGridViewRow.Cells["SpeedToT"].ReadOnly = false;
								dataGridViewRow.Cells["SpeedToT"].Style.BackColor = default(Color);
								dataGridViewRow.Cells["SpeedToT"].Style.ForeColor = default(Color);
								dataGridViewRow.Cells["SpeedToT"].Style.SelectionBackColor = default(Color);
								dataGridViewRow.Cells["SpeedToT"].Style.SelectionForeColor = default(Color);
							}
							IL_80C:
							if (Client.smethod_32().flight_0._FlightSize_0 > Mission._FlightSize.SingleAircraft)
							{
								dataGridViewRow.Cells["Formation"].ReadOnly = false;
								dataGridViewRow.Cells["Formation"].Style.BackColor = default(Color);
								dataGridViewRow.Cells["Formation"].Style.ForeColor = default(Color);
								dataGridViewRow.Cells["Formation"].Style.SelectionBackColor = default(Color);
								dataGridViewRow.Cells["Formation"].Style.SelectionForeColor = default(Color);
							}
							else
							{
								dataGridViewRow.Cells["Formation"].ReadOnly = true;
								dataGridViewRow.Cells["Formation"].Style.BackColor = Color.LightGray;
								dataGridViewRow.Cells["Formation"].Style.ForeColor = dataGridViewRow.Cells["Formation"].Style.BackColor;
								dataGridViewRow.Cells["Formation"].Style.SelectionBackColor = Color.LightGray;
								dataGridViewRow.Cells["Formation"].Style.SelectionForeColor = dataGridViewRow.Cells["Formation"].Style.SelectionBackColor;
							}
							Doctrine.Enum57? enum3 = waypoint.method_18().method_157(Client.smethod_46(), false, false, false, false);
							bool? flag11;
							if (waypoint.waypointType_0 == Waypoint.WaypointType.Refuel && flag)
							{
								b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
								flag10 = ((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null);
								flag11 = ((flag10 != null) ? new bool?(!flag10.GetValueOrDefault()) : flag10);
							}
							else
							{
								flag11 = new bool?(false);
							}
							flag10 = flag11;
							if (!flag10.GetValueOrDefault())
							{
								dataGridViewRow.Cells["AARSettings"].ReadOnly = true;
								dataGridViewRow.Cells["AARSettings"].Style.BackColor = Color.LightGray;
								dataGridViewRow.Cells["AARSettings"].Style.ForeColor = dataGridViewRow.Cells["AARSettings"].Style.BackColor;
								dataGridViewRow.Cells["AARSettings"].Style.SelectionBackColor = Color.LightGray;
								dataGridViewRow.Cells["AARSettings"].Style.SelectionForeColor = dataGridViewRow.Cells["AARSettings"].Style.SelectionBackColor;
								continue;
							}
							if (dataGridViewRow.Cells["AARSettings"].ReadOnly)
							{
								dataGridViewRow.Cells["AARSettings"].ReadOnly = false;
								dataGridViewRow.Cells["AARSettings"].Style.BackColor = default(Color);
								dataGridViewRow.Cells["AARSettings"].Style.ForeColor = default(Color);
								dataGridViewRow.Cells["AARSettings"].Style.SelectionBackColor = default(Color);
								dataGridViewRow.Cells["AARSettings"].Style.SelectionForeColor = default(Color);
								continue;
							}
							continue;
							IL_749:
							dataGridViewRow.Cells["SpeedToT"].ReadOnly = true;
							dataGridViewRow.Cells["SpeedToT"].Style.BackColor = Color.LightGray;
							dataGridViewRow.Cells["SpeedToT"].Style.ForeColor = dataGridViewRow.Cells["SpeedToT"].Style.BackColor;
							dataGridViewRow.Cells["SpeedToT"].Style.SelectionBackColor = Color.LightGray;
							dataGridViewRow.Cells["SpeedToT"].Style.SelectionForeColor = dataGridViewRow.Cells["SpeedToT"].Style.SelectionBackColor;
							goto IL_80C;
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

		// Token: 0x06005B2D RID: 23341 RVA: 0x00322BF4 File Offset: 0x00320DF4
		public void method_16()
		{
			try
			{
				this.vmethod_2().Enabled = false;
				this.vmethod_4().Enabled = false;
				this.vmethod_8().Enabled = false;
				this.vmethod_6().Enabled = false;
				this.vmethod_36().Enabled = false;
				this.vmethod_10().Enabled = false;
				this.vmethod_12().Enabled = false;
				this.vmethod_38().Enabled = false;
				this.vmethod_94().Enabled = false;
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
									this.vmethod_2().Enabled = true;
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
									this.vmethod_4().Enabled = true;
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
									this.vmethod_8().Enabled = true;
									break;
								}
								if (Client.smethod_32().flight_0._FlightTask_0 != Mission._FlightTask.const_48)
								{
									if (Client.smethod_32().flight_0.enum93_0 == Mission.Enum93.const_1)
									{
										Waypoint.WaypointType waypointType_ = waypoint.waypointType_0;
										if (waypointType_ == Waypoint.WaypointType.StationEnd)
										{
											this.vmethod_6().Enabled = true;
										}
									}
									else
									{
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
										case Waypoint.WaypointType.Land:
										case Waypoint.WaypointType.WeaponTarget:
										case Waypoint.WaypointType.StationStart_Racetrack:
										case Waypoint.WaypointType.StationStart_FigureEight:
										case Waypoint.WaypointType.StationStart_Area:
										case Waypoint.WaypointType.StationStart_RaceTrackRandom:
										case Waypoint.WaypointType.StationEnd:
										case Waypoint.WaypointType.HoldStart:
										case Waypoint.WaypointType.HoldEnd:
											this.vmethod_6().Enabled = true;
											break;
										}
									}
								}
								Waypoint.WaypointType waypointType_2 = waypoint.waypointType_0;
								if (waypointType_2 == Waypoint.WaypointType.Target || waypointType_2 == Waypoint.WaypointType.WeaponTarget)
								{
									this.vmethod_94().Enabled = true;
								}
								if (this.vmethod_0().Rows.Count > 0)
								{
									this.vmethod_36().Enabled = true;
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
									this.vmethod_10().Enabled = true;
									break;
								}
								Doctrine.Enum56? @enum = waypoint.method_18().method_152(Client.smethod_46(), false, false, false, false);
								Waypoint.WaypointType waypointType_3 = waypoint.waypointType_0;
								byte? b;
								bool? flag9;
								if (waypointType_3 == Waypoint.WaypointType.Refuel)
								{
									b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
									bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
									bool? flag2 = flag = ((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag);
									bool? flag3;
									if (flag != null && !flag2.GetValueOrDefault())
									{
										flag3 = new bool?(false);
									}
									else
									{
										b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
										bool? flag5;
										bool? flag4 = flag5 = ((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null);
										Doctrine.Enum56? enum2;
										bool? flag6 = flag4 = ((flag5 == null || flag4.GetValueOrDefault()) ? (flag4 & !Information.IsNothing(enum2)) : new bool?(false));
										bool? flag7;
										if (flag4 != null && !flag6.GetValueOrDefault())
										{
											flag7 = new bool?(false);
										}
										else
										{
											b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
											bool? flag8 = flag4 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
											flag7 = ((flag4 != null) ? (flag6 & flag8.GetValueOrDefault()) : null);
										}
										flag = flag7;
										flag9 = (flag = ((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag));
										flag3 = ((flag != null) ? (flag2 & flag9.GetValueOrDefault()) : null);
									}
									flag9 = flag3;
									if (flag9.GetValueOrDefault())
									{
										this.vmethod_12().Enabled = true;
									}
								}
								b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
								flag9 = ((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null);
								if (((flag9 != null) ? new bool?(!flag9.GetValueOrDefault()) : flag9).GetValueOrDefault())
								{
									Doctrine.Enum56? enum2 = @enum;
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
									this.vmethod_38().Enabled = true;
									goto IL_71F;
								case Waypoint.WaypointType.Split:
								case Waypoint.WaypointType.Formate:
								case Waypoint.WaypointType.Marshal:
								case Waypoint.WaypointType.Land:
								case Waypoint.WaypointType.PickupPoint:
									goto IL_71F;
								default:
									goto IL_71F;
								}
							}
						}
					}
				}
				else if (this.vmethod_0().SelectedRows.Count > 1)
				{
					if (this.vmethod_0().Rows.Count > 0)
					{
						this.vmethod_36().Enabled = true;
						this.vmethod_4().Enabled = true;
					}
				}
				else if (this.vmethod_0().Rows.Count > 0)
				{
					this.vmethod_36().Enabled = true;
				}
				IL_71F:;
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

		// Token: 0x06005B2E RID: 23342 RVA: 0x00323378 File Offset: 0x00321578
		private void method_17(object sender, DataGridViewCellEventArgs e)
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
						Client.smethod_32().waypoint_0 = (Waypoint)dataGridViewRow2.Tag;
						Client.smethod_59(Client.smethod_32().waypoint_0);
						DataGridViewColumn dataGridViewColumn = this.vmethod_0().Columns[e.ColumnIndex];
						if (Operators.CompareString(dataGridViewColumn.Name, "Type", false) == 0)
						{
							if (!this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index].IsInEditMode)
							{
								DataTable dataSource = new DataTable();
								DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index];
								Waypoint.smethod_17(ref dataSource);
								dataGridViewComboBoxCell.DataSource = dataSource;
								dataGridViewComboBoxCell.DisplayMember = "Description";
								dataGridViewComboBoxCell.ValueMember = "ID";
								dataGridViewComboBoxCell.DropDownWidth = 500;
							}
							this.vmethod_0().BeginEdit(true);
							if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_44().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
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
							if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_44().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
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
									if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_44().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
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
									if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_44().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
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
								if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_44().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
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
								if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_44().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
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
										Mission.Flight flight_ = Client.smethod_32().flight_0;
										FlightPlanEditor flightPlanEditor = Client.smethod_32();
										Mission.Flight flight_2;
										Waypoint[] waypoint_ = (flight_2 = Client.smethod_32().flight_0).method_15();
										AirTaskingOrder.smethod_0(flight_, ref waypoint3, ref flightPlanEditor.mission_0, ref waypoint_, Client.smethod_32().flightPlanWaypoints_6.enum106_0);
										flight_2.method_16(waypoint_);
									}
									else if (waypoint3.enum82_0 == Waypoint.Enum82.const_1)
									{
										if (waypoint3.enum83_0 == Waypoint.Enum83.const_2 && this.enum106_0 != Mission.Flight.Enum106.const_1)
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
								if (Client.smethod_32().flight_0.int_2 == 0)
								{
									Interaction.MsgBox("Flightplan Templates with no aircraft type selected may only use fixed speeds!", MsgBoxStyle.OkOnly, null);
									waypoint4.enum82_1 = Waypoint.Enum82.const_1;
								}
								else if (waypoint4.enum82_1 == Waypoint.Enum82.const_0)
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
											if (waypoint4.enum83_0 != Waypoint.Enum83.const_2 || this.enum106_0 == Mission.Flight.Enum106.const_1)
											{
												waypoint4.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Cruise);
												waypoint4.nullable_0 = null;
												waypoint4.method_28(null);
												waypoint4.enum82_1 = Waypoint.Enum82.const_0;
												goto IL_A2B;
											}
											waypoint4.enum82_1 = Waypoint.Enum82.const_3;
											if (!Information.IsNothing(Client.smethod_32().flight_0) && Enumerable.Count<Waypoint>(Client.smethod_32().flight_0.method_15()) >= i + 1)
											{
												Waypoint waypoint5 = Client.smethod_32().flight_0.method_15()[i];
												waypoint4.nullable_0 = waypoint5.nullable_0;
												waypoint4.method_28(waypoint5.method_27());
												waypoint4.method_36(waypoint5.method_35());
												goto IL_A2B;
											}
											goto IL_A2B;
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
								IL_A2B:
								flag = true;
								flag2 = true;
							}
						}
						IL_A2F:
						if (!Information.IsNothing(dataGridViewRow2))
						{
							this.vmethod_2().Enabled = true;
							this.vmethod_4().Enabled = true;
							this.vmethod_6().Enabled = true;
							this.vmethod_36().Enabled = true;
							this.vmethod_8().Enabled = true;
							this.vmethod_10().Enabled = true;
							this.vmethod_12().Enabled = true;
							this.vmethod_38().Enabled = true;
						}
						else
						{
							this.vmethod_2().Enabled = false;
							this.vmethod_4().Enabled = false;
							this.vmethod_6().Enabled = false;
							this.vmethod_36().Enabled = false;
							this.vmethod_8().Enabled = false;
							this.vmethod_10().Enabled = false;
							this.vmethod_12().Enabled = false;
							this.vmethod_38().Enabled = false;
						}
						if (flag)
						{
							Client.smethod_32().method_34(true, flag2, false, flag3, false);
						}
						else if (flag3)
						{
							Client.smethod_32().method_12();
						}
						else if (flag2)
						{
							Client.smethod_32().method_13();
						}
						if (flag || flag3 || flag2)
						{
							this.method_14();
							this.method_15();
						}
						if (Client.flightPlanTime_0.Visible && Client.flightPlanTime_0.bool_3)
						{
							Client.flightPlanTime_0.method_4(ref Client.smethod_32().mission_0, ref Client.smethod_32().flight_0, ref Client.smethod_32().waypoint_0, Client.smethod_32().flightPlanWaypoints_6.enum106_0, true);
						}
						if (flag4 && Client.smethod_31().Visible)
						{
							Client.smethod_31().method_5();
							Client.smethod_31().method_13();
						}
						this.method_16();
						return;
					}
				}
				goto IL_A2F;
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

		// Token: 0x06005B2F RID: 23343 RVA: 0x00323F98 File Offset: 0x00322198
		public static Waypoint smethod_0(ref Waypoint waypoint_0, Mission.Flight.Enum106 enum106_1)
		{
			Waypoint result;
			try
			{
				if (enum106_1 == Mission.Flight.Enum106.const_1)
				{
					result = waypoint_0;
				}
				else if (waypoint_0.enum83_0 == Waypoint.Enum83.const_0)
				{
					result = waypoint_0;
				}
				else
				{
					if (enum106_1 == Mission.Flight.Enum106.const_2)
					{
						if (!Information.IsNothing(waypoint_0.waypoint_0))
						{
							return waypoint_0.waypoint_0;
						}
					}
					else if (enum106_1 == Mission.Flight.Enum106.const_3)
					{
						if (!Information.IsNothing(waypoint_0.waypoint_1))
						{
							return waypoint_0.waypoint_1;
						}
					}
					else if (enum106_1 == Mission.Flight.Enum106.const_4)
					{
						if (!Information.IsNothing(waypoint_0.waypoint_2))
						{
							return waypoint_0.waypoint_2;
						}
					}
					else if (enum106_1 == Mission.Flight.Enum106.const_5)
					{
						if (!Information.IsNothing(waypoint_0.waypoint_3))
						{
							return waypoint_0.waypoint_3;
						}
					}
					else if (enum106_1 == Mission.Flight.Enum106.const_6 && !Information.IsNothing(waypoint_0.waypoint_4))
					{
						return waypoint_0.waypoint_4;
					}
					result = waypoint_0;
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
				result = null;
			}
			return result;
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x0003AB5C File Offset: 0x00038D5C
		private void method_18(object sender, DataGridViewCellEventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0 && Client.smethod_32().bool_3)
			{
				this.method_20(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06005B31 RID: 23345 RVA: 0x0003AB89 File Offset: 0x00038D89
		private void method_19(object sender, EventArgs e)
		{
			Client.smethod_32().bool_3 = true;
			if (this.vmethod_0().IsCurrentCellDirty)
			{
				this.vmethod_0().CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		// Token: 0x06005B32 RID: 23346 RVA: 0x003240A8 File Offset: 0x003222A8
		private void method_20(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				bool flag = false;
				if (!Information.IsNothing(Client.smethod_32().flight_0))
				{
					if (e.RowIndex <= Enumerable.Count<Waypoint>(Client.smethod_32().flight_0.method_15()) - 1)
					{
						Waypoint waypoint = Client.smethod_32().flight_0.method_15()[e.RowIndex];
						if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["Type"].Index)
						{
							DataGridViewCell dataGridViewCell = this.vmethod_0()[e.ColumnIndex, e.RowIndex];
							object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value);
							int? num = Waypoint.smethod_18(ref objectValue);
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
									Client.smethod_32().method_12();
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
									Client.smethod_32().method_12();
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
									Client.smethod_32().method_12();
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
									Client.smethod_32().method_12();
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
									Client.smethod_32().method_12();
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
									Client.smethod_32().method_12();
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
											Client.smethod_32().method_12();
											Interaction.MsgBox("The Station End waypoint is set automatically when a Station Start waypoint is configured. Select Station Start instead.", MsgBoxStyle.OkOnly, null);
											goto IL_CFC;
										}
										if (value == Waypoint.WaypointType.HoldStart)
										{
											if (e.RowIndex < 1)
											{
												Client.smethod_32().method_12();
												Interaction.MsgBox("The first waypoint in a flightplan can not be a Hold Start waypoint!", MsgBoxStyle.OkOnly, null);
												goto IL_CFC;
											}
											if (e.RowIndex > this.vmethod_0().Rows.Count - 4)
											{
												Client.smethod_32().method_12();
												Interaction.MsgBox("The last three waypoints in a flightplan can not be a Hold Start waypoint! Reason: Neither the Landing nor Landing Marshal waypoints can be a Hold End waypoint. Note! The waypoint after Hold Start is automatically turned into a Hold End waypoint.", MsgBoxStyle.OkOnly, null);
												goto IL_CFC;
											}
											Waypoint waypoint2 = Client.smethod_32().flight_0.method_15()[e.RowIndex + 1];
											if (waypoint2.method_42() && !waypoint2.method_43())
											{
												Client.smethod_32().method_12();
												Interaction.MsgBox("The waypoint after a Hold Start waypoint cannot be another Hold Start waypoint!", MsgBoxStyle.OkOnly, null);
												goto IL_CFC;
											}
											if (waypoint.enum83_0 != Waypoint.Enum83.const_2)
											{
												if (waypoint2.enum83_0 != Waypoint.Enum83.const_2)
												{
													if (waypoint2.waypointType_0 != Waypoint.WaypointType.TurningPoint && waypoint2.waypointType_0 != Waypoint.WaypointType.StrikeIngress && waypoint2.waypointType_0 != Waypoint.WaypointType.StrikeEgress)
													{
														Client.smethod_32().method_12();
														Interaction.MsgBox("The waypoint after Hold Start will be changed into a Hold End waypoint, and can only be of type Turning Point.", MsgBoxStyle.OkOnly, null);
														goto IL_CFC;
													}
													waypoint.waypointType_0 = value;
													waypoint.enum81_0 = Waypoint.Enum81.const_0;
													if (!Information.IsNothing(Client.smethod_32().flight_0.method_32(Client.smethod_46())))
													{
														waypoint.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Loiter);
														waypoint.enum82_1 = Waypoint.Enum82.const_1;
														if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
														{
															waypoint.nullable_0 = new float?((float)Client.smethod_32().flight_0.method_32(Client.smethod_46()).vmethod_87().vmethod_40(waypoint.nullable_2.Value, (ActiveUnit.Throttle)waypoint.method_35(), false));
														}
														else
														{
															waypoint.nullable_0 = new float?((float)Client.smethod_32().flight_0.method_32(Client.smethod_46()).vmethod_87().vmethod_40(waypoint.nullable_1.Value, (ActiveUnit.Throttle)waypoint.method_35(), false));
														}
														waypoint.method_28(null);
													}
													waypoint2.waypointType_0 = Waypoint.WaypointType.HoldEnd;
													waypoint2.float_24 = 600f;
													Client.smethod_32().method_34(true, true, false, false, false);
													flag = true;
													goto IL_CFC;
												}
											}
											Client.smethod_32().method_12();
											Interaction.MsgBox("Hold Start or Hold End waypoints can not use Split formations. Change the formation to Spread and try again.", MsgBoxStyle.OkOnly, null);
											goto IL_CFC;
										}
										else
										{
											if (value == Waypoint.WaypointType.HoldEnd)
											{
												Client.smethod_32().method_12();
												Interaction.MsgBox("The Hold End waypoint is set automatically when a Hold Start waypoint is configured. Select Hold Start instead.", MsgBoxStyle.OkOnly, null);
												goto IL_CFC;
											}
											if ((value == Waypoint.WaypointType.InitialPoint || value == Waypoint.WaypointType.WeaponLaunch) && Client.smethod_32().mission_0._MissionClass_0 != Mission._MissionClass.Strike)
											{
												Client.smethod_32().method_12();
												Interaction.MsgBox("Only strike missions may use Initial Point or Weapon Release waypoints.", MsgBoxStyle.OkOnly, null);
												goto IL_CFC;
											}
											if ((value == Waypoint.WaypointType.InitialPoint || value == Waypoint.WaypointType.WeaponLaunch) && Client.smethod_32().mission_0._MissionClass_0 == Mission._MissionClass.Strike && Client.smethod_32().flight_0.bool_12)
											{
												Client.smethod_32().method_12();
												Interaction.MsgBox("Escorts for strike missions cannot use Initial Point or Weapon Release waypoints. Change Flight Task to a non-escort type if you wish to attack specific targets.", MsgBoxStyle.OkOnly, null);
												goto IL_CFC;
											}
											if ((value == Waypoint.WaypointType.Target || value == Waypoint.WaypointType.WeaponTarget) && Client.smethod_32().mission_0._MissionClass_0 != Mission._MissionClass.Strike)
											{
												Client.smethod_32().method_12();
												Interaction.MsgBox("Only strike missions may use Target or Weapon Target waypoints.", MsgBoxStyle.OkOnly, null);
												goto IL_CFC;
											}
											if ((value == Waypoint.WaypointType.Target || value == Waypoint.WaypointType.WeaponTarget) && Client.smethod_32().mission_0._MissionClass_0 == Mission._MissionClass.Strike && Client.smethod_32().flight_0.bool_12)
											{
												Client.smethod_32().method_12();
												Interaction.MsgBox("Escorts for strike missions cannot use Target or Weapon Target waypoints. Change Flight Task to a non-escort type if you wish to attack specific targets.", MsgBoxStyle.OkOnly, null);
												goto IL_CFC;
											}
											if ((value == Waypoint.WaypointType.StrikeIngress || value == Waypoint.WaypointType.StrikeEgress) && Client.smethod_32().mission_0._MissionClass_0 != Mission._MissionClass.Strike)
											{
												Client.smethod_32().method_12();
												Interaction.MsgBox("Only strike missions may use Ingress or Egress waypoints.", MsgBoxStyle.OkOnly, null);
												goto IL_CFC;
											}
											if ((value == Waypoint.WaypointType.StrikeIngress || value == Waypoint.WaypointType.StrikeEgress) && Client.smethod_32().mission_0._MissionClass_0 == Mission._MissionClass.Strike && Client.smethod_32().flight_0.bool_12)
											{
												Client.smethod_32().method_12();
												Interaction.MsgBox("Escorts for strike missions must use Turning Point waypoints, not Turning Point (Ingress) or Turning Point (Egress).", MsgBoxStyle.OkOnly, null);
												goto IL_CFC;
											}
											if (value == Waypoint.WaypointType.TurningPoint && Client.smethod_32().mission_0._MissionClass_0 == Mission._MissionClass.Strike && !Client.smethod_32().flight_0.bool_12)
											{
												Client.smethod_32().method_12();
												Interaction.MsgBox("Use Turning Point (Ingress) or Turning Point (Egress) waypoints for strike missions.", MsgBoxStyle.OkOnly, null);
												goto IL_CFC;
											}
											if (waypoint.method_42() || waypoint.method_40())
											{
												if (!Information.IsNothing(Client.smethod_32().flight_0.method_32(Client.smethod_46())))
												{
													waypoint.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Cruise);
													waypoint.enum82_1 = Waypoint.Enum82.const_0;
													if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
													{
														waypoint.nullable_0 = new float?((float)Client.smethod_32().flight_0.method_32(Client.smethod_46()).vmethod_87().vmethod_40(waypoint.nullable_2.Value, (ActiveUnit.Throttle)waypoint.method_35(), false));
													}
													else
													{
														waypoint.nullable_0 = new float?((float)Client.smethod_32().flight_0.method_32(Client.smethod_46()).vmethod_87().vmethod_40(waypoint.nullable_1.Value, (ActiveUnit.Throttle)waypoint.method_35(), false));
													}
													waypoint.method_28(null);
												}
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
														goto IL_7F3;
													}
													goto IL_7F3;
												}
											}
											flag2 = true;
											IL_7F3:
											waypoint.waypointType_0 = value;
											if (value == Waypoint.WaypointType.Assemble)
											{
												waypoint.float_24 = 600f;
												flag = true;
											}
											else
											{
												if (value == Waypoint.WaypointType.Refuel)
												{
													bool flag4 = false;
													foreach (Waypoint waypoint3 in Client.smethod_32().flight_0.method_15())
													{
														if (waypoint3.waypointType_0 != Waypoint.WaypointType.Refuel && !Information.IsNothing(waypoint3.method_18().method_152(Client.smethod_46(), false, false, false, false)))
														{
															Doctrine.Enum56? @enum = waypoint3.method_18().method_152(Client.smethod_46(), false, false, false, false);
															byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
															bool? flag5 = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
															if (((flag5 != null) ? new bool?(!flag5.GetValueOrDefault()) : flag5).GetValueOrDefault())
															{
																flag4 = true;
																IL_90A:
																if (flag4 && Interaction.MsgBox("Disable Air-to-Air Refuelling (AAR) doctrine for all waypoints except Refuel-type waypoints?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
																{
																	foreach (Waypoint waypoint4 in Client.smethod_32().flight_0.method_15())
																	{
																		if (waypoint4.waypointType_0 != Waypoint.WaypointType.Refuel)
																		{
																			waypoint4.method_18().method_153(Client.smethod_46(), false, false, false, false, new Doctrine.Enum56?(Doctrine.Enum56.const_1));
																		}
																	}
																}
																Client.smethod_32().method_34(true, true, false, false, false);
																goto IL_9A9;
															}
														}
													}
													goto IL_90A;
												}
												if (flag2)
												{
													Client.smethod_32().method_34(true, true, false, false, false);
													flag = true;
												}
												else if (flag3)
												{
													Client.smethod_32().method_34(true, true, false, false, false);
												}
											}
											IL_9A9:
											Waypoint waypoint5 = Client.smethod_32().flight_0.method_15()[e.RowIndex + 1];
											if (waypoint5.waypointType_0 == Waypoint.WaypointType.StationEnd)
											{
												waypoint5.waypointType_0 = Waypoint.WaypointType.TurningPoint;
												waypoint5.float_25 = 0f;
												waypoint5.float_24 = 0f;
												waypoint5.enum82_0 = Waypoint.Enum82.const_0;
												waypoint5.enum81_0 = Waypoint.Enum81.const_2;
												Client.smethod_32().method_34(true, true, false, false, false);
											}
											if (waypoint5.waypointType_0 == Waypoint.WaypointType.HoldEnd)
											{
												if (value == Waypoint.WaypointType.StrikeIngress)
												{
													waypoint5.waypointType_0 = Waypoint.WaypointType.StrikeIngress;
												}
												else if (value == Waypoint.WaypointType.StrikeEgress)
												{
													waypoint5.waypointType_0 = Waypoint.WaypointType.StrikeEgress;
												}
												else
												{
													waypoint5.waypointType_0 = Waypoint.WaypointType.TurningPoint;
												}
												waypoint5.float_25 = 0f;
												waypoint5.float_24 = 0f;
												waypoint5.enum82_0 = Waypoint.Enum82.const_0;
												waypoint5.enum81_0 = Waypoint.Enum81.const_2;
												Client.smethod_32().method_34(true, true, false, false, false);
												flag = true;
												goto IL_CFC;
											}
											goto IL_CFC;
										}
									}
								}
								if (e.RowIndex < 1)
								{
									Client.smethod_32().method_12();
									Interaction.MsgBox("The first waypoint in a flightplan can not be a Station Start waypoint!", MsgBoxStyle.OkOnly, null);
								}
								else if (e.RowIndex > this.vmethod_0().Rows.Count - 4)
								{
									Client.smethod_32().method_12();
									Interaction.MsgBox("The last three waypoints in a flightplan can not be a Station Start waypoint! Reason: Neither the Landing nor Landing Marshal waypoints can be a Station End waypoint. Note! The waypoint after Station Start is automatically turned into a Station End waypoint.", MsgBoxStyle.OkOnly, null);
								}
								else if (Client.smethod_32().mission_0._MissionClass_0 != Mission._MissionClass.Patrol && Client.smethod_32().mission_0._MissionClass_0 != Mission._MissionClass.Support && (Client.smethod_32().mission_0._MissionClass_0 != Mission._MissionClass.Strike || !Client.smethod_32().flight_0.bool_12))
								{
									Client.smethod_32().method_12();
									Interaction.MsgBox("Only patrol missions, support missions and strike mission escorts may use station waypoints.", MsgBoxStyle.OkOnly, null);
								}
								else
								{
									Waypoint waypoint6 = Client.smethod_32().flight_0.method_15()[e.RowIndex + 1];
									if (waypoint6.method_40() && !waypoint6.method_41())
									{
										Client.smethod_32().method_12();
										Interaction.MsgBox("The waypoint after a Station Start waypoint cannot be another Station Start waypoint!", MsgBoxStyle.OkOnly, null);
									}
									else
									{
										if (waypoint.enum83_0 != Waypoint.Enum83.const_2)
										{
											if (waypoint6.enum83_0 != Waypoint.Enum83.const_2)
											{
												if (waypoint6.waypointType_0 != Waypoint.WaypointType.TurningPoint && waypoint6.waypointType_0 != Waypoint.WaypointType.StrikeIngress && waypoint6.waypointType_0 != Waypoint.WaypointType.StrikeEgress && waypoint6.waypointType_0 != Waypoint.WaypointType.StationEnd)
												{
													Client.smethod_32().method_12();
													Interaction.MsgBox("The waypoint after Station Start will be changed into a Station End waypoint, and can only be of type Turning Point.", MsgBoxStyle.OkOnly, null);
													goto IL_CFC;
												}
												waypoint.waypointType_0 = value;
												waypoint.enum81_0 = Waypoint.Enum81.const_1;
												if (!Information.IsNothing(Client.smethod_32().flight_0.method_32(Client.smethod_46())))
												{
													waypoint.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Loiter);
													waypoint.enum82_1 = Waypoint.Enum82.const_1;
													if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
													{
														waypoint.nullable_0 = new float?((float)Client.smethod_32().flight_0.method_32(Client.smethod_46()).vmethod_87().vmethod_40(waypoint.nullable_2.Value, (ActiveUnit.Throttle)waypoint.method_35(), false));
													}
													else
													{
														waypoint.nullable_0 = new float?((float)Client.smethod_32().flight_0.method_32(Client.smethod_46()).vmethod_87().vmethod_40(waypoint.nullable_1.Value, (ActiveUnit.Throttle)waypoint.method_35(), false));
													}
													waypoint.method_28(null);
												}
												waypoint6.waypointType_0 = Waypoint.WaypointType.StationEnd;
												Client.smethod_32().method_34(true, true, false, false, false);
												flag = true;
												goto IL_CFC;
											}
										}
										Client.smethod_32().method_12();
										Interaction.MsgBox("Station Start or Station End waypoints can not use Split formations. Change the formation to Spread and try again.", MsgBoxStyle.OkOnly, null);
									}
								}
							}
							IL_CFC:
							if (waypoint.waypointType_0 != Waypoint.WaypointType.Assemble && waypoint.waypointType_0 != Waypoint.WaypointType.HoldEnd)
							{
								if (waypoint.float_24 > 0f)
								{
									waypoint.float_24 = 0f;
									Client.smethod_32().method_34(true, true, false, false, false);
									flag = true;
								}
							}
							else
							{
								Client.smethod_32().method_34(true, true, false, false, false);
								flag = true;
							}
							if (!Information.IsNothing(waypoint.waypoint_0))
							{
								waypoint.waypoint_0.waypointType_0 = waypoint.waypointType_0;
							}
							if (!Information.IsNothing(waypoint.waypoint_1))
							{
								waypoint.waypoint_1.waypointType_0 = waypoint.waypointType_0;
							}
							if (!Information.IsNothing(waypoint.waypoint_2))
							{
								waypoint.waypoint_2.waypointType_0 = waypoint.waypointType_0;
							}
							if (!Information.IsNothing(waypoint.waypoint_3))
							{
								waypoint.waypoint_3.waypointType_0 = waypoint.waypointType_0;
							}
							if (!Information.IsNothing(waypoint.waypoint_4))
							{
								waypoint.waypoint_4.waypointType_0 = waypoint.waypointType_0;
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
								Client.smethod_32().method_12();
								Interaction.MsgBox("Station waypoints cannot be set to Split formation.", MsgBoxStyle.OkOnly, null);
							}
							else if (value2 == Waypoint.Enum83.const_2 && waypoint.method_45())
							{
								Client.smethod_32().method_12();
								Interaction.MsgBox("Hold and Assemble waypoints cannot be set to Split formation.", MsgBoxStyle.OkOnly, null);
							}
							else if (value2 == Waypoint.Enum83.const_2 && e.RowIndex <= 1)
							{
								Client.smethod_32().method_12();
								Interaction.MsgBox("The first two waypoint in a flightplan cannot be set to Split formation.", MsgBoxStyle.OkOnly, null);
							}
							else if (value2 == Waypoint.Enum83.const_2 && e.RowIndex >= this.vmethod_0().Rows.Count - 1)
							{
								Client.smethod_32().method_12();
								Interaction.MsgBox("The last waypoint in a flightplan cannot be set to Split formation.", MsgBoxStyle.OkOnly, null);
							}
							else if (value2 == Waypoint.Enum83.const_2 && waypoint.waypointType_0 == Waypoint.WaypointType.LandingMarshal)
							{
								Client.smethod_32().method_12();
								Interaction.MsgBox("A landing marshal waypoint cannot be set to Split formation.", MsgBoxStyle.OkOnly, null);
							}
							else
							{
								if (e.RowIndex > 0 && e.RowIndex < Enumerable.Count<Waypoint>(Client.smethod_32().flight_0.method_15()) - 2)
								{
									waypoint.enum83_0 = value2;
									Waypoint waypoint7 = Client.smethod_32().flight_0.method_15()[e.RowIndex - 1];
									Waypoint waypoint8 = Client.smethod_32().flight_0.method_15()[e.RowIndex + 1];
									if (waypoint.enum83_0 == Waypoint.Enum83.const_2)
									{
										Waypoint waypoint9 = waypoint;
										Scenario scenario = Client.smethod_46();
										waypoint9.method_20(ref scenario, ref Client.smethod_32().flight_0._FlightSize_0, ref waypoint7, ref waypoint8, true);
									}
									else
									{
										waypoint.method_24(ref waypoint7, ref waypoint8);
									}
								}
								else
								{
									waypoint.enum83_0 = Waypoint.Enum83.const_0;
									Waypoint waypoint10 = waypoint;
									Waypoint waypoint11 = null;
									Waypoint waypoint12 = null;
									waypoint10.method_24(ref waypoint11, ref waypoint12);
									Interaction.MsgBox("The first waypoint or the last two waypoints in a flightplan cannot be split.", MsgBoxStyle.OkOnly, null);
								}
								Client.smethod_32().method_34(true, true, true, true, false);
								flag = true;
							}
						}
						if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["TurnRate"].Index)
						{
							Waypoint waypoint13 = waypoint;
							DataGridViewCell dataGridViewCell3 = this.vmethod_0()[e.ColumnIndex, e.RowIndex];
							object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewCell3.Value);
							int? num = Waypoint.smethod_27(ref objectValue);
							dataGridViewCell3.Value = RuntimeHelpers.GetObjectValue(objectValue);
							waypoint13.enum81_0 = (Waypoint.Enum81)num.Value;
							Client.smethod_32().method_34(true, true, true, false, false);
							flag = true;
						}
						if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["AARUsage"].Index)
						{
							Doctrine doctrine = waypoint.method_18();
							int int_ = Conversions.ToInteger(this.vmethod_0()[e.ColumnIndex, e.RowIndex].Value);
							Scenario scenario = Client.smethod_46();
							int num2 = 0;
							doctrine.method_318(int_, ref scenario, ref num2, false, false, false);
							Client.smethod_32().method_34(true, true, false, false, false);
						}
						if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["AARSelection"].Index)
						{
							Doctrine doctrine2 = waypoint.method_18();
							int int_2 = Conversions.ToInteger(this.vmethod_0()[e.ColumnIndex, e.RowIndex].Value);
							Scenario scenario = Client.smethod_46();
							int num2 = 0;
							doctrine2.method_320(int_2, ref scenario, ref num2, false, false, false);
							Client.smethod_32().method_34(true, true, false, false, false);
						}
						if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["SpeedToT"].Index)
						{
							Waypoint waypoint14 = waypoint;
							DataGridViewCell dataGridViewCell4 = this.vmethod_0()[e.ColumnIndex, e.RowIndex];
							object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewCell4.Value);
							int? num = Waypoint.smethod_32(ref objectValue);
							dataGridViewCell4.Value = RuntimeHelpers.GetObjectValue(objectValue);
							waypoint14.enum84_0 = (Waypoint.Enum84)num.Value;
						}
						this.method_14();
						this.method_15();
						this.method_16();
						if (flag && Client.smethod_31().Visible)
						{
							Client.smethod_31().method_5();
							Client.smethod_31().method_30();
						}
						Client.smethod_32().bool_3 = false;
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

		// Token: 0x06005B33 RID: 23347 RVA: 0x0003ABB4 File Offset: 0x00038DB4
		private void method_21(object sender, EventArgs e)
		{
			if (Client.smethod_32().bool_3)
			{
				int count = this.vmethod_0().SelectedRows.Count;
			}
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x00325338 File Offset: 0x00323538
		private void method_22(object sender, EventArgs e)
		{
			try
			{
				bool bool_ = !Information.IsNothing(Client.smethod_32().mission_0) && Client.smethod_32().mission_0.enum88_0 == Mission.Enum88.const_1;
				if (Information.IsNothing(Client.smethod_32().mission_0) || Client.smethod_32().mission_0.enum88_0 != Mission.Enum88.const_1 || DarkMessageBox.smethod_1("Flightplans in packages should always have waypoint times set! Are you sure you want to clear the waypoint times?", "Confirm", Enum11.const_2) != DialogResult.Cancel)
				{
					AirTaskingOrder.smethod_3(Client.smethod_32().flight_0, bool_);
					Client.smethod_32().method_34(false, true, false, false, true);
					this.method_15();
					this.method_16();
					Class2413.smethod_2().method_41().method_235();
					Client.bool_1 = true;
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

		// Token: 0x06005B35 RID: 23349 RVA: 0x00325460 File Offset: 0x00323660
		private void method_23(object sender, EventArgs e)
		{
			try
			{
				Interaction.MsgBox("Not yet, sorry!", MsgBoxStyle.OkOnly, null);
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

		// Token: 0x04003519 RID: 13593
		private IContainer icontainer_0;

		// Token: 0x0400351A RID: 13594
		[CompilerGenerated]
		[AccessedThroughProperty("DGV_Waypoints")]
		private Class114 class114_0;

		// Token: 0x0400351B RID: 13595
		[AccessedThroughProperty("Button_InsertWaypoint")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x0400351C RID: 13596
		[CompilerGenerated]
		[AccessedThroughProperty("Button_DeleteWaypoint")]
		private Control9 control9_1;

		// Token: 0x0400351D RID: 13597
		[AccessedThroughProperty("Button_EditTime")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x0400351E RID: 13598
		[AccessedThroughProperty("Button_EditSpeedAltitude")]
		[CompilerGenerated]
		private Control9 control9_3;

		// Token: 0x0400351F RID: 13599
		[CompilerGenerated]
		[AccessedThroughProperty("Button_EditDoctrine")]
		private Control9 control9_4;

		// Token: 0x04003520 RID: 13600
		[AccessedThroughProperty("Button_EditAAR")]
		[CompilerGenerated]
		private Control9 control9_5;

		// Token: 0x04003521 RID: 13601
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04003522 RID: 13602
		[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04003523 RID: 13603
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04003524 RID: 13604
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04003525 RID: 13605
		[AccessedThroughProperty("DataGridViewTextBoxColumn5")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04003526 RID: 13606
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn6")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x04003527 RID: 13607
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn7")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x04003528 RID: 13608
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn8")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x04003529 RID: 13609
		[AccessedThroughProperty("DataGridViewTextBoxColumn9")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		// Token: 0x0400352A RID: 13610
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn10")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		// Token: 0x0400352B RID: 13611
		[AccessedThroughProperty("DataGridViewTextBoxColumn11")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		// Token: 0x0400352C RID: 13612
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ClearTime")]
		private Control9 control9_6;

		// Token: 0x0400352D RID: 13613
		[AccessedThroughProperty("Button_EditSensorUsage")]
		[CompilerGenerated]
		private Control9 control9_7;

		// Token: 0x0400352E RID: 13614
		[CompilerGenerated]
		[AccessedThroughProperty("ID")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		// Token: 0x0400352F RID: 13615
		[AccessedThroughProperty("ObjectID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		// Token: 0x04003530 RID: 13616
		[AccessedThroughProperty("Type")]
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		// Token: 0x04003531 RID: 13617
		[AccessedThroughProperty("Time_Zulu")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		// Token: 0x04003532 RID: 13618
		[CompilerGenerated]
		[AccessedThroughProperty("Time_Local")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		// Token: 0x04003533 RID: 13619
		[CompilerGenerated]
		[AccessedThroughProperty("TimeFixedImg")]
		private DataGridViewImageColumn dataGridViewImageColumn_0;

		// Token: 0x04003534 RID: 13620
		[CompilerGenerated]
		[AccessedThroughProperty("TimeFixed")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		// Token: 0x04003535 RID: 13621
		[AccessedThroughProperty("DesiredSpeed")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		// Token: 0x04003536 RID: 13622
		[AccessedThroughProperty("SpeedFixedImg")]
		[CompilerGenerated]
		private DataGridViewImageColumn dataGridViewImageColumn_1;

		// Token: 0x04003537 RID: 13623
		[AccessedThroughProperty("SpeedFixed")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		// Token: 0x04003538 RID: 13624
		[CompilerGenerated]
		[AccessedThroughProperty("DesiredAltitude")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		// Token: 0x04003539 RID: 13625
		[CompilerGenerated]
		[AccessedThroughProperty("Leg_Distance")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		// Token: 0x0400353A RID: 13626
		[CompilerGenerated]
		[AccessedThroughProperty("Leg_TotalDistance")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		// Token: 0x0400353B RID: 13627
		[CompilerGenerated]
		[AccessedThroughProperty("Leg_Time")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		// Token: 0x0400353C RID: 13628
		[AccessedThroughProperty("Hold_Time")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		// Token: 0x0400353D RID: 13629
		[AccessedThroughProperty("Leg_TotalTime")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		// Token: 0x0400353E RID: 13630
		[CompilerGenerated]
		[AccessedThroughProperty("Leg_FuelRequired")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		// Token: 0x0400353F RID: 13631
		[AccessedThroughProperty("Leg_FuelRemaining")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		// Token: 0x04003540 RID: 13632
		[AccessedThroughProperty("SpeedToT")]
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;

		// Token: 0x04003541 RID: 13633
		[CompilerGenerated]
		[AccessedThroughProperty("Formation")]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;

		// Token: 0x04003542 RID: 13634
		[CompilerGenerated]
		[AccessedThroughProperty("AARUsage")]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_3;

		// Token: 0x04003543 RID: 13635
		[AccessedThroughProperty("AARSelection")]
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4;

		// Token: 0x04003544 RID: 13636
		[CompilerGenerated]
		[AccessedThroughProperty("AARSettings")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

		// Token: 0x04003545 RID: 13637
		[AccessedThroughProperty("SensorUsage")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

		// Token: 0x04003546 RID: 13638
		[AccessedThroughProperty("Doctrine")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

		// Token: 0x04003547 RID: 13639
		[AccessedThroughProperty("TurnRate")]
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5;

		// Token: 0x04003548 RID: 13640
		[AccessedThroughProperty("Coordinates")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

		// Token: 0x04003549 RID: 13641
		[AccessedThroughProperty("Button_EditTargetAndWeapons")]
		[CompilerGenerated]
		private Control9 control9_8;

		// Token: 0x0400354A RID: 13642
		public Mission.Flight.Enum106 enum106_0;
	}
}
