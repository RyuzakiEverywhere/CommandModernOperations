using System;
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
using ns11;
using ns2;
using ns3;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000EC8 RID: 3784
	[DesignerGenerated]
	public sealed partial class NewMission : DarkSecondaryFormBase
	{
		// Token: 0x060081EB RID: 33259 RVA: 0x004601B8 File Offset: 0x0045E3B8
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class116());
			this.vmethod_3(new Control8());
			this.vmethod_5(new Class2451());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Class116());
			this.vmethod_11(new Class2451());
			this.vmethod_13(new Control9());
			this.vmethod_15(new Control9());
			this.vmethod_85(new Class112());
			this.vmethod_17(new Class2451());
			this.vmethod_19(new Class116());
			this.vmethod_21(new Class116());
			this.vmethod_23(new Class2451());
			this.vmethod_25(new FlowLayoutPanel());
			this.vmethod_27(new Class115());
			this.vmethod_29(new Control9());
			this.vmethod_31(new Class118());
			this.vmethod_33(new Class118());
			this.vmethod_35(new Class116());
			this.vmethod_37(new Class116());
			this.vmethod_39(new Class115());
			this.vmethod_41(new Class112());
			this.vmethod_43(new Class112());
			this.vmethod_45(new Class112());
			this.vmethod_47(new Control9());
			this.vmethod_49(new Class118());
			this.vmethod_51(new Class116());
			this.vmethod_53(new Class118());
			this.vmethod_55(new Class116());
			this.vmethod_57(new Class115());
			this.vmethod_77(new Control9());
			this.vmethod_59(new Class118());
			this.vmethod_61(new Class118());
			this.vmethod_63(new Class116());
			this.vmethod_65(new Class116());
			this.vmethod_67(new Class115());
			this.vmethod_79(new Control9());
			this.vmethod_69(new Class118());
			this.vmethod_71(new Class118());
			this.vmethod_73(new Class116());
			this.vmethod_75(new Class116());
			this.vmethod_81(new Class2451());
			this.vmethod_83(new Class116());
			this.vmethod_24().SuspendLayout();
			this.vmethod_26().SuspendLayout();
			this.vmethod_38().SuspendLayout();
			this.vmethod_56().SuspendLayout();
			this.vmethod_66().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(2, 42);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(56, 23);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Name:";
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().method_14(null);
			this.vmethod_2().method_15(AutoCompleteMode.None);
			this.vmethod_2().method_13(AutoCompleteSource.None);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().method_17(new Font("Segoe UI", 10f));
			this.vmethod_2().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_2().method_12(null);
			this.vmethod_2().method_18(null);
			this.vmethod_2().Location = new Point(78, 38);
			this.vmethod_2().method_2(32767);
			this.vmethod_2().method_7(false);
			this.vmethod_2().Name = "TextBox_Name";
			this.vmethod_2().method_3(false);
			this.vmethod_2().method_9(0);
			this.vmethod_2().Size = new Size(266, 20);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().method_1(HorizontalAlignment.Left);
			this.vmethod_2().method_5(false);
			this.vmethod_2().method_10("");
			this.vmethod_4().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_4().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_4().Font = new Font("Segoe UI", 7f);
			this.vmethod_4().FormattingEnabled = true;
			this.vmethod_4().Location = new Point(78, 64);
			this.vmethod_4().Name = "CB_MissionClass";
			this.vmethod_4().Size = new Size(266, 21);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_6().method_2(true);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(2, 68);
			this.vmethod_6().Name = "Label_MissionClass";
			this.vmethod_6().Size = new Size(37, 15);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "Class:";
			this.vmethod_8().method_2(true);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(1, 97);
			this.vmethod_8().Name = "Label_MissionType";
			this.vmethod_8().Size = new Size(35, 15);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "Type:";
			this.vmethod_10().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_10().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_10().Font = new Font("Segoe UI", 7f);
			this.vmethod_10().FormattingEnabled = true;
			this.vmethod_10().Location = new Point(78, 93);
			this.vmethod_10().Name = "CB_MissionType";
			this.vmethod_10().Size = new Size(266, 21);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font("Segoe UI", 10f);
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(5, 200);
			this.vmethod_12().Name = "Button1";
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(75, 23);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_12().Text = "OK";
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().DialogResult = DialogResult.None;
			this.vmethod_14().Font = new Font("Segoe UI", 10f);
			this.vmethod_14().ForeColor = SystemColors.Control;
			this.vmethod_14().Location = new Point(461, 202);
			this.vmethod_14().Name = "Button2";
			this.vmethod_14().method_1(0);
			this.vmethod_14().Size = new Size(75, 23);
			this.vmethod_14().TabIndex = 7;
			this.vmethod_14().Text = "Cancel";
			this.vmethod_84().AutoSize = true;
			this.vmethod_84().Location = new Point(5, 179);
			this.vmethod_84().Name = "CB_OpenMissionEditor";
			this.vmethod_84().Size = new Size(178, 19);
			this.vmethod_84().TabIndex = 8;
			this.vmethod_84().Text = "Open Mission Editor window";
			this.vmethod_16().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_16().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_16().Font = new Font("Segoe UI", 7f);
			this.vmethod_16().FormattingEnabled = true;
			this.vmethod_16().Items.AddRange(new object[]
			{
				"Active",
				"Inactive"
			});
			this.vmethod_16().Location = new Point(78, 123);
			this.vmethod_16().Name = "CB_MissionStatus";
			this.vmethod_16().Size = new Size(266, 21);
			this.vmethod_16().TabIndex = 30;
			this.vmethod_18().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_18().method_2(true);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(1, 127);
			this.vmethod_18().Name = "Label_MissionStatus";
			this.vmethod_18().Size = new Size(42, 15);
			this.vmethod_18().TabIndex = 29;
			this.vmethod_18().Text = "Status:";
			this.vmethod_20().method_2(true);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Location = new Point(2, 12);
			this.vmethod_20().Name = "Label_Category";
			this.vmethod_20().Size = new Size(58, 15);
			this.vmethod_20().TabIndex = 32;
			this.vmethod_20().Text = "Category:";
			this.vmethod_22().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_22().BackColor = Color.Transparent;
			this.vmethod_22().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_22().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_22().Font = new Font("Segoe UI", 7f);
			this.vmethod_22().FormattingEnabled = true;
			this.vmethod_22().Location = new Point(78, 8);
			this.vmethod_22().Name = "CB_Category";
			this.vmethod_22().Size = new Size(266, 21);
			this.vmethod_22().TabIndex = 31;
			this.vmethod_24().Controls.Add(this.vmethod_26());
			this.vmethod_24().Controls.Add(this.vmethod_38());
			this.vmethod_24().Controls.Add(this.vmethod_56());
			this.vmethod_24().Controls.Add(this.vmethod_66());
			this.vmethod_24().Location = new Point(347, 8);
			this.vmethod_24().Margin = new Padding(0);
			this.vmethod_24().Name = "FlowLayoutPanel1";
			this.vmethod_24().Size = new Size(188, 195);
			this.vmethod_24().TabIndex = 47;
			this.vmethod_26().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_26().Controls.Add(this.vmethod_28());
			this.vmethod_26().Controls.Add(this.vmethod_30());
			this.vmethod_26().Controls.Add(this.vmethod_32());
			this.vmethod_26().Controls.Add(this.vmethod_34());
			this.vmethod_26().Controls.Add(this.vmethod_36());
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Location = new Point(3, 3);
			this.vmethod_26().Name = "GroupBox_ActivationTime";
			this.vmethod_26().Size = new Size(183, 61);
			this.vmethod_26().TabIndex = 45;
			this.vmethod_26().TabStop = false;
			this.vmethod_26().Text = "Activation Time";
			this.vmethod_28().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_28().BackColor = Color.Transparent;
			this.vmethod_28().DialogResult = DialogResult.None;
			this.vmethod_28().Font = new Font("Segoe UI", 10f);
			this.vmethod_28().ForeColor = SystemColors.Control;
			this.vmethod_28().Location = new Point(124, 14);
			this.vmethod_28().Name = "Button_Clear_ActivationTime";
			this.vmethod_28().method_1(0);
			this.vmethod_28().Size = new Size(56, 22);
			this.vmethod_28().TabIndex = 43;
			this.vmethod_28().Text = "Clear";
			this.vmethod_30().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_30().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_30().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Location = new Point(39, 36);
			this.vmethod_30().Name = "DateTimePicker_ActivationTime";
			this.vmethod_30().Size = new Size(79, 23);
			this.vmethod_30().TabIndex = 37;
			this.vmethod_32().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_32().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_32().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_32().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_32().Location = new Point(39, 15);
			this.vmethod_32().Name = "DateTimePicker_ActivationDate";
			this.vmethod_32().Size = new Size(79, 23);
			this.vmethod_32().TabIndex = 36;
			this.vmethod_34().method_2(true);
			this.vmethod_34().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_34().Location = new Point(4, 19);
			this.vmethod_34().Name = "Label101";
			this.vmethod_34().Size = new Size(34, 15);
			this.vmethod_34().TabIndex = 38;
			this.vmethod_34().Text = "Date:";
			this.vmethod_36().method_2(true);
			this.vmethod_36().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_36().Location = new Point(4, 39);
			this.vmethod_36().Name = "Label102";
			this.vmethod_36().Size = new Size(37, 15);
			this.vmethod_36().TabIndex = 38;
			this.vmethod_36().Text = "Time:";
			this.vmethod_38().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_38().Controls.Add(this.vmethod_40());
			this.vmethod_38().Controls.Add(this.vmethod_42());
			this.vmethod_38().Controls.Add(this.vmethod_44());
			this.vmethod_38().Controls.Add(this.vmethod_46());
			this.vmethod_38().Controls.Add(this.vmethod_48());
			this.vmethod_38().Controls.Add(this.vmethod_50());
			this.vmethod_38().Controls.Add(this.vmethod_52());
			this.vmethod_38().Controls.Add(this.vmethod_54());
			this.vmethod_38().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_38().Location = new Point(3, 70);
			this.vmethod_38().Name = "GroupBox_DeactivationTime";
			this.vmethod_38().Size = new Size(183, 119);
			this.vmethod_38().TabIndex = 44;
			this.vmethod_38().TabStop = false;
			this.vmethod_38().Text = "Deactivation Time";
			this.vmethod_40().AutoSize = true;
			this.vmethod_40().Location = new Point(8, 98);
			this.vmethod_40().Name = "CheckBox_DeleteMission";
			this.vmethod_40().Size = new Size(103, 19);
			this.vmethod_40().TabIndex = 46;
			this.vmethod_40().Text = "Delete Mission";
			this.vmethod_42().AutoSize = true;
			this.vmethod_42().Location = new Point(8, 79);
			this.vmethod_42().Name = "CheckBox_OrderRTB";
			this.vmethod_42().Size = new Size(79, 19);
			this.vmethod_42().TabIndex = 45;
			this.vmethod_42().Text = "Order RTB";
			this.vmethod_44().AutoSize = true;
			this.vmethod_44().Location = new Point(8, 60);
			this.vmethod_44().Name = "CheckBox_UnassignUnits";
			this.vmethod_44().Size = new Size(104, 19);
			this.vmethod_44().TabIndex = 44;
			this.vmethod_44().Text = "Unassign Units";
			this.vmethod_46().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_46().BackColor = Color.Transparent;
			this.vmethod_46().DialogResult = DialogResult.None;
			this.vmethod_46().Font = new Font("Segoe UI", 10f);
			this.vmethod_46().ForeColor = SystemColors.Control;
			this.vmethod_46().Location = new Point(124, 14);
			this.vmethod_46().Name = "Button_Clear_DeactivationTime";
			this.vmethod_46().method_1(0);
			this.vmethod_46().Size = new Size(54, 22);
			this.vmethod_46().TabIndex = 43;
			this.vmethod_46().Text = "Clear";
			this.vmethod_48().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_48().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_48().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_48().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_48().Location = new Point(39, 36);
			this.vmethod_48().Name = "DateTimePicker_DeactivationTime";
			this.vmethod_48().Size = new Size(79, 23);
			this.vmethod_48().TabIndex = 40;
			this.vmethod_50().method_2(true);
			this.vmethod_50().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_50().Location = new Point(4, 40);
			this.vmethod_50().Name = "Label112";
			this.vmethod_50().Size = new Size(37, 15);
			this.vmethod_50().TabIndex = 41;
			this.vmethod_50().Text = "Time:";
			this.vmethod_52().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_52().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_52().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_52().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_52().Location = new Point(39, 15);
			this.vmethod_52().Name = "DateTimePicker_DeactivationDate";
			this.vmethod_52().Size = new Size(79, 23);
			this.vmethod_52().TabIndex = 39;
			this.vmethod_54().method_2(true);
			this.vmethod_54().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_54().Location = new Point(4, 19);
			this.vmethod_54().Name = "Label114";
			this.vmethod_54().Size = new Size(34, 15);
			this.vmethod_54().TabIndex = 42;
			this.vmethod_54().Text = "Date:";
			this.vmethod_56().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_56().Controls.Add(this.vmethod_76());
			this.vmethod_56().Controls.Add(this.vmethod_58());
			this.vmethod_56().Controls.Add(this.vmethod_60());
			this.vmethod_56().Controls.Add(this.vmethod_62());
			this.vmethod_56().Controls.Add(this.vmethod_64());
			this.vmethod_56().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_56().Location = new Point(3, 195);
			this.vmethod_56().Name = "GroupBox_TakeOffTime";
			this.vmethod_56().Size = new Size(183, 61);
			this.vmethod_56().TabIndex = 46;
			this.vmethod_56().TabStop = false;
			this.vmethod_56().Text = "Take-Off Time";
			this.vmethod_76().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_76().BackColor = Color.Transparent;
			this.vmethod_76().DialogResult = DialogResult.None;
			this.vmethod_76().Font = new Font("Segoe UI", 10f);
			this.vmethod_76().ForeColor = SystemColors.Control;
			this.vmethod_76().Location = new Point(118, 14);
			this.vmethod_76().Name = "Button_Clear_TakeOffTime";
			this.vmethod_76().method_1(0);
			this.vmethod_76().Size = new Size(60, 22);
			this.vmethod_76().TabIndex = 44;
			this.vmethod_76().Text = "Clear";
			this.vmethod_58().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_58().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_58().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_58().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_58().Location = new Point(39, 36);
			this.vmethod_58().Name = "DateTimePicker_TakeOffTime";
			this.vmethod_58().Size = new Size(79, 23);
			this.vmethod_58().TabIndex = 37;
			this.vmethod_60().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_60().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_60().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_60().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_60().Location = new Point(39, 15);
			this.vmethod_60().Name = "DateTimePicker_TakeOffDate";
			this.vmethod_60().Size = new Size(79, 23);
			this.vmethod_60().TabIndex = 36;
			this.vmethod_62().method_2(true);
			this.vmethod_62().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_62().Location = new Point(4, 19);
			this.vmethod_62().Name = "Label162";
			this.vmethod_62().Size = new Size(34, 15);
			this.vmethod_62().TabIndex = 38;
			this.vmethod_62().Text = "Date:";
			this.vmethod_64().method_2(true);
			this.vmethod_64().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_64().Location = new Point(4, 39);
			this.vmethod_64().Name = "Label169";
			this.vmethod_64().Size = new Size(37, 15);
			this.vmethod_64().TabIndex = 38;
			this.vmethod_64().Text = "Time:";
			this.vmethod_66().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_66().Controls.Add(this.vmethod_78());
			this.vmethod_66().Controls.Add(this.vmethod_68());
			this.vmethod_66().Controls.Add(this.vmethod_70());
			this.vmethod_66().Controls.Add(this.vmethod_72());
			this.vmethod_66().Controls.Add(this.vmethod_74());
			this.vmethod_66().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_66().Location = new Point(3, 262);
			this.vmethod_66().Name = "GroupBox_TimeOnTarget";
			this.vmethod_66().Size = new Size(183, 61);
			this.vmethod_66().TabIndex = 47;
			this.vmethod_66().TabStop = false;
			this.vmethod_66().Text = "Time On Target (ToT)";
			this.vmethod_78().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_78().BackColor = Color.Transparent;
			this.vmethod_78().DialogResult = DialogResult.None;
			this.vmethod_78().Font = new Font("Segoe UI", 10f);
			this.vmethod_78().ForeColor = SystemColors.Control;
			this.vmethod_78().Location = new Point(118, 14);
			this.vmethod_78().Name = "Button_Clear_TimeOnTarget";
			this.vmethod_78().method_1(0);
			this.vmethod_78().Size = new Size(60, 22);
			this.vmethod_78().TabIndex = 44;
			this.vmethod_78().Text = "Clear";
			this.vmethod_68().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_68().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_68().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_68().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_68().Location = new Point(39, 36);
			this.vmethod_68().Name = "DateTimePicker_TimeOnTargetTime";
			this.vmethod_68().Size = new Size(79, 23);
			this.vmethod_68().TabIndex = 37;
			this.vmethod_70().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_70().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_70().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_70().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_70().Location = new Point(39, 15);
			this.vmethod_70().Name = "DateTimePicker_TimeOnTargetDate";
			this.vmethod_70().Size = new Size(79, 23);
			this.vmethod_70().TabIndex = 36;
			this.vmethod_72().method_2(true);
			this.vmethod_72().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_72().Location = new Point(4, 19);
			this.vmethod_72().Name = "Label170";
			this.vmethod_72().Size = new Size(34, 15);
			this.vmethod_72().TabIndex = 38;
			this.vmethod_72().Text = "Date:";
			this.vmethod_74().method_2(true);
			this.vmethod_74().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_74().Location = new Point(4, 39);
			this.vmethod_74().Name = "Label171";
			this.vmethod_74().Size = new Size(37, 15);
			this.vmethod_74().TabIndex = 38;
			this.vmethod_74().Text = "Time:";
			this.vmethod_80().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_80().BackColor = Color.Transparent;
			this.vmethod_80().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_80().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_80().Font = new Font("Segoe UI", 7f);
			this.vmethod_80().FormattingEnabled = true;
			this.vmethod_80().Items.AddRange(new object[]
			{
				"Active",
				"Inactive"
			});
			this.vmethod_80().Location = new Point(78, 153);
			this.vmethod_80().Name = "CB_ParentPool";
			this.vmethod_80().Size = new Size(266, 21);
			this.vmethod_80().TabIndex = 49;
			this.vmethod_82().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_82().method_2(true);
			this.vmethod_82().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_82().Location = new Point(1, 158);
			this.vmethod_82().Name = "Label_ParentPool";
			this.vmethod_82().Size = new Size(71, 15);
			this.vmethod_82().TabIndex = 48;
			this.vmethod_82().Text = "Parent pool:";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(541, 229);
			base.Controls.Add(this.vmethod_80());
			base.Controls.Add(this.vmethod_82());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_84());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "NewMission";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "New Mission / Task Pool / Package";
			this.vmethod_24().ResumeLayout(false);
			this.vmethod_26().ResumeLayout(false);
			this.vmethod_26().PerformLayout();
			this.vmethod_38().ResumeLayout(false);
			this.vmethod_38().PerformLayout();
			this.vmethod_56().ResumeLayout(false);
			this.vmethod_56().PerformLayout();
			this.vmethod_66().ResumeLayout(false);
			this.vmethod_66().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060081EC RID: 33260 RVA: 0x0004F0B3 File Offset: 0x0004D2B3
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x060081ED RID: 33261 RVA: 0x0004F0BB File Offset: 0x0004D2BB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_14)
		{
			this.class116_0 = class116_14;
		}

		// Token: 0x060081EE RID: 33262 RVA: 0x0004F0C4 File Offset: 0x0004D2C4
		[CompilerGenerated]
		internal Control8 vmethod_2()
		{
			return this.control8_0;
		}

		// Token: 0x060081EF RID: 33263 RVA: 0x004620AC File Offset: 0x004602AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control8 control8_1)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_3);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.method_22(delegate85_);
			}
			this.control8_0 = control8_1;
			control = this.control8_0;
			if (control != null)
			{
				control.method_21(delegate85_);
			}
		}

		// Token: 0x060081F0 RID: 33264 RVA: 0x0004F0CC File Offset: 0x0004D2CC
		[CompilerGenerated]
		internal Class2451 vmethod_4()
		{
			return this.class2451_0;
		}

		// Token: 0x060081F1 RID: 33265 RVA: 0x004620F0 File Offset: 0x004602F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class2451 class2451_5)
		{
			EventHandler value = new EventHandler(this.method_4);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectedIndexChanged -= value;
			}
			this.class2451_0 = class2451_5;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060081F2 RID: 33266 RVA: 0x0004F0D4 File Offset: 0x0004D2D4
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_1;
		}

		// Token: 0x060081F3 RID: 33267 RVA: 0x0004F0DC File Offset: 0x0004D2DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_14)
		{
			this.class116_1 = class116_14;
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x0004F0E5 File Offset: 0x0004D2E5
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_2;
		}

		// Token: 0x060081F5 RID: 33269 RVA: 0x0004F0ED File Offset: 0x0004D2ED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_14)
		{
			this.class116_2 = class116_14;
		}

		// Token: 0x060081F6 RID: 33270 RVA: 0x0004F0F6 File Offset: 0x0004D2F6
		[CompilerGenerated]
		internal Class2451 vmethod_10()
		{
			return this.class2451_1;
		}

		// Token: 0x060081F7 RID: 33271 RVA: 0x0004F0FE File Offset: 0x0004D2FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class2451 class2451_5)
		{
			this.class2451_1 = class2451_5;
		}

		// Token: 0x060081F8 RID: 33272 RVA: 0x0004F107 File Offset: 0x0004D307
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_0;
		}

		// Token: 0x060081F9 RID: 33273 RVA: 0x00462134 File Offset: 0x00460334
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_6)
		{
			EventHandler value = new EventHandler(this.method_5);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_6;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060081FA RID: 33274 RVA: 0x0004F10F File Offset: 0x0004D30F
		[CompilerGenerated]
		internal Control9 vmethod_14()
		{
			return this.control9_1;
		}

		// Token: 0x060081FB RID: 33275 RVA: 0x00462178 File Offset: 0x00460378
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control9 control9_6)
		{
			EventHandler value = new EventHandler(this.method_7);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_6;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060081FC RID: 33276 RVA: 0x0004F117 File Offset: 0x0004D317
		[CompilerGenerated]
		internal Class2451 vmethod_16()
		{
			return this.class2451_2;
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x0004F11F File Offset: 0x0004D31F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class2451 class2451_5)
		{
			this.class2451_2 = class2451_5;
		}

		// Token: 0x060081FE RID: 33278 RVA: 0x0004F128 File Offset: 0x0004D328
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_3;
		}

		// Token: 0x060081FF RID: 33279 RVA: 0x0004F130 File Offset: 0x0004D330
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_14)
		{
			this.class116_3 = class116_14;
		}

		// Token: 0x06008200 RID: 33280 RVA: 0x0004F139 File Offset: 0x0004D339
		[CompilerGenerated]
		internal Class116 vmethod_20()
		{
			return this.class116_4;
		}

		// Token: 0x06008201 RID: 33281 RVA: 0x0004F141 File Offset: 0x0004D341
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class116 class116_14)
		{
			this.class116_4 = class116_14;
		}

		// Token: 0x06008202 RID: 33282 RVA: 0x0004F14A File Offset: 0x0004D34A
		[CompilerGenerated]
		internal Class2451 vmethod_22()
		{
			return this.class2451_3;
		}

		// Token: 0x06008203 RID: 33283 RVA: 0x004621BC File Offset: 0x004603BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class2451 class2451_5)
		{
			EventHandler value = new EventHandler(this.method_10);
			Class2451 @class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectedIndexChanged -= value;
			}
			this.class2451_3 = class2451_5;
			@class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06008204 RID: 33284 RVA: 0x0004F152 File Offset: 0x0004D352
		[CompilerGenerated]
		internal FlowLayoutPanel vmethod_24()
		{
			return this.flowLayoutPanel_0;
		}

		// Token: 0x06008205 RID: 33285 RVA: 0x0004F15A File Offset: 0x0004D35A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(FlowLayoutPanel flowLayoutPanel_1)
		{
			this.flowLayoutPanel_0 = flowLayoutPanel_1;
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x0004F163 File Offset: 0x0004D363
		[CompilerGenerated]
		internal Class115 vmethod_26()
		{
			return this.class115_0;
		}

		// Token: 0x06008207 RID: 33287 RVA: 0x0004F16B File Offset: 0x0004D36B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class115 class115_4)
		{
			this.class115_0 = class115_4;
		}

		// Token: 0x06008208 RID: 33288 RVA: 0x0004F174 File Offset: 0x0004D374
		[CompilerGenerated]
		internal Control9 vmethod_28()
		{
			return this.control9_2;
		}

		// Token: 0x06008209 RID: 33289 RVA: 0x00462200 File Offset: 0x00460400
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Control9 control9_6)
		{
			EventHandler value = new EventHandler(this.method_37);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_6;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600820A RID: 33290 RVA: 0x0004F17C File Offset: 0x0004D37C
		[CompilerGenerated]
		internal Class118 vmethod_30()
		{
			return this.class118_0;
		}

		// Token: 0x0600820B RID: 33291 RVA: 0x00462244 File Offset: 0x00460444
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class118 class118_8)
		{
			EventHandler value = new EventHandler(this.method_14);
			EventHandler value2 = new EventHandler(this.method_15);
			Class118 @class = this.class118_0;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
			}
			this.class118_0 = class118_8;
			@class = this.class118_0;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
			}
		}

		// Token: 0x0600820C RID: 33292 RVA: 0x0004F184 File Offset: 0x0004D384
		[CompilerGenerated]
		internal Class118 vmethod_32()
		{
			return this.class118_1;
		}

		// Token: 0x0600820D RID: 33293 RVA: 0x004622A4 File Offset: 0x004604A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class118 class118_8)
		{
			EventHandler value = new EventHandler(this.method_12);
			EventHandler value2 = new EventHandler(this.method_13);
			EventHandler value3 = new EventHandler(this.method_41);
			Class118 @class = this.class118_1;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
				@class.Leave -= value3;
			}
			this.class118_1 = class118_8;
			@class = this.class118_1;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
				@class.Leave += value3;
			}
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x0004F18C File Offset: 0x0004D38C
		[CompilerGenerated]
		internal Class116 vmethod_34()
		{
			return this.class116_5;
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x0004F194 File Offset: 0x0004D394
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Class116 class116_14)
		{
			this.class116_5 = class116_14;
		}

		// Token: 0x06008210 RID: 33296 RVA: 0x0004F19D File Offset: 0x0004D39D
		[CompilerGenerated]
		internal Class116 vmethod_36()
		{
			return this.class116_6;
		}

		// Token: 0x06008211 RID: 33297 RVA: 0x0004F1A5 File Offset: 0x0004D3A5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class116 class116_14)
		{
			this.class116_6 = class116_14;
		}

		// Token: 0x06008212 RID: 33298 RVA: 0x0004F1AE File Offset: 0x0004D3AE
		[CompilerGenerated]
		internal Class115 vmethod_38()
		{
			return this.class115_1;
		}

		// Token: 0x06008213 RID: 33299 RVA: 0x0004F1B6 File Offset: 0x0004D3B6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Class115 class115_4)
		{
			this.class115_1 = class115_4;
		}

		// Token: 0x06008214 RID: 33300 RVA: 0x0004F1BF File Offset: 0x0004D3BF
		[CompilerGenerated]
		internal Class112 vmethod_40()
		{
			return this.class112_0;
		}

		// Token: 0x06008215 RID: 33301 RVA: 0x0004F1C7 File Offset: 0x0004D3C7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Class112 class112_4)
		{
			this.class112_0 = class112_4;
		}

		// Token: 0x06008216 RID: 33302 RVA: 0x0004F1D0 File Offset: 0x0004D3D0
		[CompilerGenerated]
		internal Class112 vmethod_42()
		{
			return this.class112_1;
		}

		// Token: 0x06008217 RID: 33303 RVA: 0x0004F1D8 File Offset: 0x0004D3D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Class112 class112_4)
		{
			this.class112_1 = class112_4;
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x0004F1E1 File Offset: 0x0004D3E1
		[CompilerGenerated]
		internal Class112 vmethod_44()
		{
			return this.class112_2;
		}

		// Token: 0x06008219 RID: 33305 RVA: 0x0004F1E9 File Offset: 0x0004D3E9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Class112 class112_4)
		{
			this.class112_2 = class112_4;
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x0004F1F2 File Offset: 0x0004D3F2
		[CompilerGenerated]
		internal Control9 vmethod_46()
		{
			return this.control9_3;
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x00462320 File Offset: 0x00460520
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Control9 control9_6)
		{
			EventHandler value = new EventHandler(this.method_38);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_6;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600821C RID: 33308 RVA: 0x0004F1FA File Offset: 0x0004D3FA
		[CompilerGenerated]
		internal Class118 vmethod_48()
		{
			return this.class118_2;
		}

		// Token: 0x0600821D RID: 33309 RVA: 0x00462364 File Offset: 0x00460564
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Class118 class118_8)
		{
			EventHandler value = new EventHandler(this.method_18);
			EventHandler value2 = new EventHandler(this.method_19);
			Class118 @class = this.class118_2;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
			}
			this.class118_2 = class118_8;
			@class = this.class118_2;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
			}
		}

		// Token: 0x0600821E RID: 33310 RVA: 0x0004F202 File Offset: 0x0004D402
		[CompilerGenerated]
		internal Class116 vmethod_50()
		{
			return this.class116_7;
		}

		// Token: 0x0600821F RID: 33311 RVA: 0x0004F20A File Offset: 0x0004D40A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(Class116 class116_14)
		{
			this.class116_7 = class116_14;
		}

		// Token: 0x06008220 RID: 33312 RVA: 0x0004F213 File Offset: 0x0004D413
		[CompilerGenerated]
		internal Class118 vmethod_52()
		{
			return this.class118_3;
		}

		// Token: 0x06008221 RID: 33313 RVA: 0x004623C4 File Offset: 0x004605C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Class118 class118_8)
		{
			EventHandler value = new EventHandler(this.method_16);
			EventHandler value2 = new EventHandler(this.method_17);
			EventHandler value3 = new EventHandler(this.method_42);
			Class118 @class = this.class118_3;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
				@class.Leave -= value3;
			}
			this.class118_3 = class118_8;
			@class = this.class118_3;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
				@class.Leave += value3;
			}
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x0004F21B File Offset: 0x0004D41B
		[CompilerGenerated]
		internal Class116 vmethod_54()
		{
			return this.class116_8;
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x0004F223 File Offset: 0x0004D423
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Class116 class116_14)
		{
			this.class116_8 = class116_14;
		}

		// Token: 0x06008224 RID: 33316 RVA: 0x0004F22C File Offset: 0x0004D42C
		[CompilerGenerated]
		internal Class115 vmethod_56()
		{
			return this.class115_2;
		}

		// Token: 0x06008225 RID: 33317 RVA: 0x0004F234 File Offset: 0x0004D434
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(Class115 class115_4)
		{
			this.class115_2 = class115_4;
		}

		// Token: 0x06008226 RID: 33318 RVA: 0x0004F23D File Offset: 0x0004D43D
		[CompilerGenerated]
		internal Class118 vmethod_58()
		{
			return this.class118_4;
		}

		// Token: 0x06008227 RID: 33319 RVA: 0x00462440 File Offset: 0x00460640
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(Class118 class118_8)
		{
			EventHandler value = new EventHandler(this.method_22);
			EventHandler value2 = new EventHandler(this.method_23);
			Class118 @class = this.class118_4;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
			}
			this.class118_4 = class118_8;
			@class = this.class118_4;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
			}
		}

		// Token: 0x06008228 RID: 33320 RVA: 0x0004F245 File Offset: 0x0004D445
		[CompilerGenerated]
		internal Class118 vmethod_60()
		{
			return this.class118_5;
		}

		// Token: 0x06008229 RID: 33321 RVA: 0x004624A0 File Offset: 0x004606A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(Class118 class118_8)
		{
			EventHandler value = new EventHandler(this.method_20);
			EventHandler value2 = new EventHandler(this.method_21);
			EventHandler value3 = new EventHandler(this.method_43);
			Class118 @class = this.class118_5;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
				@class.Leave -= value3;
			}
			this.class118_5 = class118_8;
			@class = this.class118_5;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
				@class.Leave += value3;
			}
		}

		// Token: 0x0600822A RID: 33322 RVA: 0x0004F24D File Offset: 0x0004D44D
		[CompilerGenerated]
		internal Class116 vmethod_62()
		{
			return this.class116_9;
		}

		// Token: 0x0600822B RID: 33323 RVA: 0x0004F255 File Offset: 0x0004D455
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(Class116 class116_14)
		{
			this.class116_9 = class116_14;
		}

		// Token: 0x0600822C RID: 33324 RVA: 0x0004F25E File Offset: 0x0004D45E
		[CompilerGenerated]
		internal Class116 vmethod_64()
		{
			return this.class116_10;
		}

		// Token: 0x0600822D RID: 33325 RVA: 0x0004F266 File Offset: 0x0004D466
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Class116 class116_14)
		{
			this.class116_10 = class116_14;
		}

		// Token: 0x0600822E RID: 33326 RVA: 0x0004F26F File Offset: 0x0004D46F
		[CompilerGenerated]
		internal Class115 vmethod_66()
		{
			return this.class115_3;
		}

		// Token: 0x0600822F RID: 33327 RVA: 0x0004F277 File Offset: 0x0004D477
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(Class115 class115_4)
		{
			this.class115_3 = class115_4;
		}

		// Token: 0x06008230 RID: 33328 RVA: 0x0004F280 File Offset: 0x0004D480
		[CompilerGenerated]
		internal Class118 vmethod_68()
		{
			return this.class118_6;
		}

		// Token: 0x06008231 RID: 33329 RVA: 0x0046251C File Offset: 0x0046071C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(Class118 class118_8)
		{
			EventHandler value = new EventHandler(this.method_26);
			EventHandler value2 = new EventHandler(this.method_27);
			Class118 @class = this.class118_6;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
			}
			this.class118_6 = class118_8;
			@class = this.class118_6;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
			}
		}

		// Token: 0x06008232 RID: 33330 RVA: 0x0004F288 File Offset: 0x0004D488
		[CompilerGenerated]
		internal Class118 vmethod_70()
		{
			return this.class118_7;
		}

		// Token: 0x06008233 RID: 33331 RVA: 0x0046257C File Offset: 0x0046077C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(Class118 class118_8)
		{
			EventHandler value = new EventHandler(this.method_24);
			EventHandler value2 = new EventHandler(this.method_25);
			EventHandler value3 = new EventHandler(this.method_44);
			Class118 @class = this.class118_7;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
				@class.Leave -= value3;
			}
			this.class118_7 = class118_8;
			@class = this.class118_7;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
				@class.Leave += value3;
			}
		}

		// Token: 0x06008234 RID: 33332 RVA: 0x0004F290 File Offset: 0x0004D490
		[CompilerGenerated]
		internal Class116 vmethod_72()
		{
			return this.class116_11;
		}

		// Token: 0x06008235 RID: 33333 RVA: 0x0004F298 File Offset: 0x0004D498
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(Class116 class116_14)
		{
			this.class116_11 = class116_14;
		}

		// Token: 0x06008236 RID: 33334 RVA: 0x0004F2A1 File Offset: 0x0004D4A1
		[CompilerGenerated]
		internal Class116 vmethod_74()
		{
			return this.class116_12;
		}

		// Token: 0x06008237 RID: 33335 RVA: 0x0004F2A9 File Offset: 0x0004D4A9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(Class116 class116_14)
		{
			this.class116_12 = class116_14;
		}

		// Token: 0x06008238 RID: 33336 RVA: 0x0004F2B2 File Offset: 0x0004D4B2
		[CompilerGenerated]
		internal Control9 vmethod_76()
		{
			return this.control9_4;
		}

		// Token: 0x06008239 RID: 33337 RVA: 0x004625F8 File Offset: 0x004607F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Control9 control9_6)
		{
			EventHandler value = new EventHandler(this.method_39);
			Control9 control = this.control9_4;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_4 = control9_6;
			control = this.control9_4;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600823A RID: 33338 RVA: 0x0004F2BA File Offset: 0x0004D4BA
		[CompilerGenerated]
		internal Control9 vmethod_78()
		{
			return this.control9_5;
		}

		// Token: 0x0600823B RID: 33339 RVA: 0x0046263C File Offset: 0x0046083C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(Control9 control9_6)
		{
			EventHandler value = new EventHandler(this.method_40);
			Control9 control = this.control9_5;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_5 = control9_6;
			control = this.control9_5;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600823C RID: 33340 RVA: 0x0004F2C2 File Offset: 0x0004D4C2
		[CompilerGenerated]
		internal Class2451 vmethod_80()
		{
			return this.class2451_4;
		}

		// Token: 0x0600823D RID: 33341 RVA: 0x0004F2CA File Offset: 0x0004D4CA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(Class2451 class2451_5)
		{
			this.class2451_4 = class2451_5;
		}

		// Token: 0x0600823E RID: 33342 RVA: 0x0004F2D3 File Offset: 0x0004D4D3
		[CompilerGenerated]
		internal Class116 vmethod_82()
		{
			return this.class116_13;
		}

		// Token: 0x0600823F RID: 33343 RVA: 0x0004F2DB File Offset: 0x0004D4DB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(Class116 class116_14)
		{
			this.class116_13 = class116_14;
		}

		// Token: 0x06008240 RID: 33344 RVA: 0x0004F2E4 File Offset: 0x0004D4E4
		[CompilerGenerated]
		internal Class112 vmethod_84()
		{
			return this.class112_3;
		}

		// Token: 0x06008241 RID: 33345 RVA: 0x00462680 File Offset: 0x00460880
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(Class112 class112_4)
		{
			EventHandler value = new EventHandler(this.method_9);
			Class112 @class = this.class112_3;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_3 = class112_4;
			@class = this.class112_3;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06008242 RID: 33346 RVA: 0x004626C4 File Offset: 0x004608C4
		public NewMission()
		{
			base.FormClosing += this.NewMission_FormClosing;
			base.Load += this.NewMission_Load;
			base.VisibleChanged += this.NewMission_VisibleChanged;
			base.KeyDown += this.NewMission_KeyDown;
			this.bool_3 = true;
			this.bool_4 = false;
			this.bool_5 = false;
			this.bool_6 = false;
			this.bool_7 = false;
			this.InitializeComponent_1();
			this.bool_2 = false;
		}

		// Token: 0x06008243 RID: 33347 RVA: 0x0004F2EC File Offset: 0x0004D4EC
		private void method_3(object object_0)
		{
			this.vmethod_12().Enabled = (Operators.CompareString(this.vmethod_2().Text, "", false) != 0);
		}

		// Token: 0x06008244 RID: 33348 RVA: 0x00462750 File Offset: 0x00460950
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_4().SelectedIndex != -1)
			{
				switch (this.vmethod_4().SelectedIndex)
				{
				case 0:
					this.vmethod_10().Enabled = true;
					this.vmethod_8().Enabled = true;
					this.vmethod_10().Items.Clear();
					this.vmethod_10().Items.Add("Air Intercept");
					this.vmethod_10().Items.Add("Land Strike");
					this.vmethod_10().Items.Add("Naval ASuW Strike");
					this.vmethod_10().Items.Add("ASW Strike");
					if (this.vmethod_10().Items.Count > 0 && this.vmethod_10().SelectedIndex < 0)
					{
						this.vmethod_10().SelectedIndex = 0;
						return;
					}
					break;
				case 1:
					this.vmethod_10().Enabled = true;
					this.vmethod_8().Enabled = true;
					this.vmethod_10().Items.Clear();
					this.vmethod_10().Items.Add("AAW Patrol");
					this.vmethod_10().Items.Add("ASuW Patrol (Naval)");
					this.vmethod_10().Items.Add("ASuW Patrol (Ground)");
					this.vmethod_10().Items.Add("ASuW Patrol (Mixed)");
					this.vmethod_10().Items.Add("ASW Patrol");
					this.vmethod_10().Items.Add("SEAD Patrol");
					this.vmethod_10().Items.Add("Sea Control Patrol");
					if (this.vmethod_10().Items.Count > 0 && this.vmethod_10().SelectedIndex < 0)
					{
						this.vmethod_10().SelectedIndex = 0;
						return;
					}
					break;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					this.vmethod_10().Items.Clear();
					this.vmethod_10().Enabled = false;
					this.vmethod_8().Enabled = true;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06008245 RID: 33349 RVA: 0x0004F312 File Offset: 0x0004D512
		private void method_5(object sender, EventArgs e)
		{
			this.method_6();
		}

		// Token: 0x06008246 RID: 33350 RVA: 0x0046296C File Offset: 0x00460B6C
		private void method_6()
		{
			if (this.vmethod_22().SelectedIndex != -1)
			{
				if (this.vmethod_22().SelectedIndex != 1 && this.vmethod_4().SelectedIndex == -1)
				{
					DarkMessageBox.smethod_2("Please give the package a class type.", "No class type", Enum11.const_0);
					return;
				}
				if (Operators.CompareString(this.vmethod_2().Text, "", false) == 0)
				{
					DarkMessageBox.smethod_2("Please enter a name!", "No name", Enum11.const_0);
					return;
				}
				this.method_29();
				this.method_31();
				this.method_33();
				this.method_35();
				switch (this.vmethod_22().SelectedIndex)
				{
				case 0:
				case 2:
				{
					Mission.Enum88 enum88_;
					if (this.vmethod_22().SelectedIndex == 2)
					{
						if (this.vmethod_80().Items.Count == 0 || this.vmethod_80().SelectedIndex < 0)
						{
							DarkMessageBox.smethod_2("You must select a parent Aircraft Task Pool! If none exists, create one first.", "", Enum11.const_0);
							return;
						}
						enum88_ = Mission.Enum88.const_1;
						Client.smethod_50().method_90();
					}
					else
					{
						enum88_ = Mission.Enum88.const_0;
					}
					switch (this.vmethod_4().SelectedIndex)
					{
					case 0:
						switch (this.vmethod_10().SelectedIndex)
						{
						case 0:
						{
							Strike strike = new Strike(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, Strike.StrikeType.Air_Intercept);
							if (strike.enum88_0 == Mission.Enum88.const_1)
							{
								string right = this.vmethod_80().SelectedItem.ToString();
								try
								{
									foreach (Mission mission in Client.smethod_50().method_35())
									{
										if (Operators.CompareString(mission.Name, right, false) == 0)
										{
											((Class342)mission).list_5.Add(strike);
											strike.method_14(Client.smethod_50(), mission.string_0);
											break;
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
							int selectedIndex = this.vmethod_16().SelectedIndex;
							if (selectedIndex == 1)
							{
								strike.method_11(Client.smethod_46(), Mission.Enum89.const_1);
							}
							strike.bool_19 = this.vmethod_44().Checked;
							strike.bool_20 = this.vmethod_42().Checked;
							strike.bool_21 = this.vmethod_40().Checked;
							if (strike.enum88_0 == Mission.Enum88.const_0)
							{
								if (this.nullable_0 != null)
								{
									strike.method_25(this.nullable_0, Client.smethod_46());
								}
								if (this.nullable_1 != null)
								{
									strike.method_28(this.nullable_1, Client.smethod_46());
								}
							}
							else
							{
								if (this.nullable_2 != null)
								{
									strike.method_30(this.nullable_2);
								}
								if (this.nullable_3 != null)
								{
									strike.method_32(this.nullable_3);
								}
							}
							if (this.bool_3)
							{
								Client.smethod_30().method_7(strike);
								if (!Client.smethod_30().Visible)
								{
									Client.smethod_30().Show();
								}
								else
								{
									Client.smethod_30().method_3();
								}
							}
							base.Close();
							break;
						}
						case 1:
						{
							Strike strike2 = new Strike(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, Strike.StrikeType.Land_Strike);
							if (strike2.enum88_0 == Mission.Enum88.const_1)
							{
								string right2 = this.vmethod_80().SelectedItem.ToString();
								try
								{
									foreach (Mission mission2 in Client.smethod_50().method_35())
									{
										if (Operators.CompareString(mission2.Name, right2, false) == 0)
										{
											((Class342)mission2).list_5.Add(strike2);
											strike2.method_14(Client.smethod_50(), mission2.string_0);
											break;
										}
									}
								}
								finally
								{
									IEnumerator<Mission> enumerator2;
									if (enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
							}
							int selectedIndex2 = this.vmethod_16().SelectedIndex;
							if (selectedIndex2 == 1)
							{
								strike2.method_11(Client.smethod_46(), Mission.Enum89.const_1);
							}
							try
							{
								foreach (Unit unit in Client.smethod_50().method_56())
								{
									if (unit.vmethod_7(false) != Client.smethod_50() && !Client.smethod_50().method_67(unit.vmethod_7(false)))
									{
										if (unit.bool_1)
										{
											try
											{
												foreach (ActiveUnit activeUnit in ((Group)unit).vmethod_141().Values)
												{
													strike2.hashSet_0.Add(activeUnit);
													if (strike2.method_12() && Client.smethod_50().method_68(activeUnit.vmethod_7(false)) != Misc.PostureStance.Hostile)
													{
														Client.smethod_50().method_69(activeUnit.vmethod_7(false), Misc.PostureStance.Hostile);
													}
												}
												continue;
											}
											finally
											{
												IEnumerator<ActiveUnit> enumerator4;
												if (enumerator4 != null)
												{
													enumerator4.Dispose();
												}
											}
										}
										if (unit.bool_0)
										{
											strike2.hashSet_0.Add(unit);
											if (strike2.method_12() && Client.smethod_50().method_68(unit.vmethod_7(false)) != Misc.PostureStance.Hostile)
											{
												Client.smethod_50().method_69(unit.vmethod_7(false), Misc.PostureStance.Hostile);
											}
										}
										else
										{
											Contact contact = (Contact)unit;
											if (contact.activeUnit_0 != null)
											{
												if (Client.smethod_50().method_12().ContainsKey(contact.activeUnit_0.string_0))
												{
													try
													{
														foreach (ActiveUnit activeUnit2 in ((Group)contact.activeUnit_0).vmethod_141().Values)
														{
															if (Client.smethod_50().method_11().ContainsKey(activeUnit2.string_0))
															{
																Contact contact2;
																Client.smethod_50().method_11().TryGetValue(activeUnit2.string_0, ref contact2);
																if (contact2 != null)
																{
																	strike2.hashSet_0.Add(contact2);
																	if (strike2.method_12() && contact.method_130(Client.smethod_50()) != Misc.PostureStance.Hostile)
																	{
																		contact.method_131(Client.smethod_50(), false, Misc.PostureStance.Hostile);
																	}
																}
															}
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
												strike2.hashSet_0.Add(contact);
												if (strike2.method_12() && contact.method_130(Client.smethod_50()) != Misc.PostureStance.Hostile)
												{
													contact.method_131(Client.smethod_50(), false, Misc.PostureStance.Hostile);
												}
											}
										}
									}
								}
							}
							finally
							{
								IEnumerator<Unit> enumerator3;
								if (enumerator3 != null)
								{
									enumerator3.Dispose();
								}
							}
							if (strike2.hashSet_0.Count > 0)
							{
								List<Unit> list = Enumerable.ToList<Unit>(Enumerable.OrderBy<Unit, string>(strike2.hashSet_0, (NewMission._Closure$__.$I188-0 == null) ? (NewMission._Closure$__.$I188-0 = new Func<Unit, string>(NewMission._Closure$__.$I.method_0)) : NewMission._Closure$__.$I188-0));
								strike2.hashSet_0 = new HashSet<Unit>(list);
								strike2.bool_27 = true;
							}
							strike2.bool_19 = this.vmethod_44().Checked;
							strike2.bool_20 = this.vmethod_42().Checked;
							strike2.bool_21 = this.vmethod_40().Checked;
							if (strike2.enum88_0 == Mission.Enum88.const_0)
							{
								if (this.nullable_0 != null)
								{
									strike2.method_25(this.nullable_0, Client.smethod_46());
								}
								if (this.nullable_1 != null)
								{
									strike2.method_28(this.nullable_1, Client.smethod_46());
								}
							}
							else
							{
								if (this.nullable_2 != null)
								{
									strike2.method_30(this.nullable_2);
								}
								if (this.nullable_3 != null)
								{
									strike2.method_32(this.nullable_3);
								}
							}
							if (this.bool_3)
							{
								Client.smethod_30().method_7(strike2);
								if (!Client.smethod_30().Visible)
								{
									Client.smethod_30().Show();
								}
								else
								{
									Client.smethod_30().method_3();
								}
								Client.smethod_30().Show();
							}
							base.Close();
							break;
						}
						case 2:
						{
							Strike strike3 = new Strike(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, Strike.StrikeType.Maritime_Strike);
							if (strike3.enum88_0 == Mission.Enum88.const_1)
							{
								string right3 = this.vmethod_80().SelectedItem.ToString();
								try
								{
									foreach (Mission mission3 in Client.smethod_50().method_35())
									{
										if (Operators.CompareString(mission3.Name, right3, false) == 0)
										{
											((Class342)mission3).list_5.Add(strike3);
											strike3.method_14(Client.smethod_50(), mission3.string_0);
											break;
										}
									}
								}
								finally
								{
									IEnumerator<Mission> enumerator6;
									if (enumerator6 != null)
									{
										enumerator6.Dispose();
									}
								}
							}
							int selectedIndex3 = this.vmethod_16().SelectedIndex;
							if (selectedIndex3 == 1)
							{
								strike3.method_11(Client.smethod_46(), Mission.Enum89.const_1);
							}
							try
							{
								foreach (Unit unit2 in Client.smethod_50().method_56())
								{
									if (unit2.vmethod_7(false) != Client.smethod_50() && !Client.smethod_50().method_67(unit2.vmethod_7(false)))
									{
										if (unit2.bool_1)
										{
											try
											{
												foreach (ActiveUnit activeUnit3 in ((Group)unit2).vmethod_141().Values)
												{
													strike3.hashSet_0.Add(activeUnit3);
													if (strike3.method_12() && Client.smethod_50().method_68(activeUnit3.vmethod_7(false)) != Misc.PostureStance.Hostile)
													{
														Client.smethod_50().method_69(activeUnit3.vmethod_7(false), Misc.PostureStance.Hostile);
													}
												}
												continue;
											}
											finally
											{
												IEnumerator<ActiveUnit> enumerator8;
												if (enumerator8 != null)
												{
													enumerator8.Dispose();
												}
											}
										}
										if (unit2.bool_0)
										{
											strike3.hashSet_0.Add(unit2);
											if (strike3.method_12() && Client.smethod_50().method_68(unit2.vmethod_7(false)) != Misc.PostureStance.Hostile)
											{
												Client.smethod_50().method_69(unit2.vmethod_7(false), Misc.PostureStance.Hostile);
											}
										}
										else
										{
											Contact contact3 = (Contact)unit2;
											if (contact3.activeUnit_0 != null)
											{
												if (Client.smethod_50().method_12().ContainsKey(contact3.activeUnit_0.string_0))
												{
													try
													{
														foreach (ActiveUnit activeUnit4 in ((Group)contact3.activeUnit_0).vmethod_141().Values)
														{
															if (Client.smethod_50().method_11().ContainsKey(activeUnit4.string_0))
															{
																Contact contact4;
																Client.smethod_50().method_11().TryGetValue(activeUnit4.string_0, ref contact4);
																if (!Information.IsNothing(contact4))
																{
																	strike3.hashSet_0.Add(contact4);
																	if (strike3.method_12() && contact3.method_130(Client.smethod_50()) != Misc.PostureStance.Hostile)
																	{
																		contact3.method_131(Client.smethod_50(), false, Misc.PostureStance.Hostile);
																	}
																}
															}
														}
														continue;
													}
													finally
													{
														IEnumerator<ActiveUnit> enumerator9;
														if (enumerator9 != null)
														{
															enumerator9.Dispose();
														}
													}
												}
												strike3.hashSet_0.Add(contact3);
												if (strike3.method_12() && contact3.method_130(Client.smethod_50()) != Misc.PostureStance.Hostile)
												{
													contact3.method_131(Client.smethod_50(), false, Misc.PostureStance.Hostile);
												}
											}
										}
									}
								}
							}
							finally
							{
								IEnumerator<Unit> enumerator7;
								if (enumerator7 != null)
								{
									enumerator7.Dispose();
								}
							}
							if (strike3.hashSet_0.Count > 0)
							{
								List<Unit> list2 = Enumerable.ToList<Unit>(Enumerable.OrderBy<Unit, string>(strike3.hashSet_0, (NewMission._Closure$__.$I188-1 == null) ? (NewMission._Closure$__.$I188-1 = new Func<Unit, string>(NewMission._Closure$__.$I.method_1)) : NewMission._Closure$__.$I188-1));
								strike3.hashSet_0 = new HashSet<Unit>(list2);
								strike3.bool_27 = true;
							}
							strike3.bool_19 = this.vmethod_44().Checked;
							strike3.bool_20 = this.vmethod_42().Checked;
							strike3.bool_21 = this.vmethod_40().Checked;
							if (strike3.enum88_0 == Mission.Enum88.const_0)
							{
								if (this.nullable_0 != null)
								{
									strike3.method_25(this.nullable_0, Client.smethod_46());
								}
								if (this.nullable_1 != null)
								{
									strike3.method_28(this.nullable_1, Client.smethod_46());
								}
							}
							else
							{
								if (this.nullable_2 != null)
								{
									strike3.method_30(this.nullable_2);
								}
								if (this.nullable_3 != null)
								{
									strike3.method_32(this.nullable_3);
								}
							}
							if (this.bool_3)
							{
								Client.smethod_30().method_7(strike3);
								if (!Client.smethod_30().Visible)
								{
									Client.smethod_30().Show();
								}
								else
								{
									Client.smethod_30().method_3();
								}
								Client.smethod_30().Show();
							}
							base.Close();
							break;
						}
						case 3:
						{
							Strike strike4 = new Strike(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, Strike.StrikeType.Sub_Strike);
							if (strike4.enum88_0 == Mission.Enum88.const_1)
							{
								string right4 = this.vmethod_80().SelectedItem.ToString();
								try
								{
									foreach (Mission mission4 in Client.smethod_50().method_35())
									{
										if (Operators.CompareString(mission4.Name, right4, false) == 0)
										{
											((Class342)mission4).list_5.Add(strike4);
											strike4.method_14(Client.smethod_50(), mission4.string_0);
											break;
										}
									}
								}
								finally
								{
									IEnumerator<Mission> enumerator10;
									if (enumerator10 != null)
									{
										enumerator10.Dispose();
									}
								}
							}
							int selectedIndex4 = this.vmethod_16().SelectedIndex;
							if (selectedIndex4 == 1)
							{
								strike4.method_11(Client.smethod_46(), Mission.Enum89.const_1);
							}
							try
							{
								foreach (Unit unit3 in Client.smethod_50().method_56())
								{
									if (unit3.vmethod_7(false) != Client.smethod_50() && !Client.smethod_50().method_67(unit3.vmethod_7(false)))
									{
										if (unit3.bool_1)
										{
											try
											{
												foreach (ActiveUnit activeUnit5 in ((Group)unit3).vmethod_141().Values)
												{
													strike4.hashSet_0.Add(activeUnit5);
													if (strike4.method_12() && Client.smethod_50().method_68(activeUnit5.vmethod_7(false)) != Misc.PostureStance.Hostile)
													{
														Client.smethod_50().method_69(activeUnit5.vmethod_7(false), Misc.PostureStance.Hostile);
													}
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
										if (unit3.bool_0)
										{
											strike4.hashSet_0.Add(unit3);
											if (strike4.method_12() && Client.smethod_50().method_68(unit3.vmethod_7(false)) != Misc.PostureStance.Hostile)
											{
												Client.smethod_50().method_69(unit3.vmethod_7(false), Misc.PostureStance.Hostile);
											}
										}
										else
										{
											Contact contact5 = (Contact)unit3;
											if (!Information.IsNothing(contact5.activeUnit_0))
											{
												if (Client.smethod_50().method_12().ContainsKey(contact5.activeUnit_0.string_0))
												{
													try
													{
														foreach (ActiveUnit activeUnit6 in ((Group)contact5.activeUnit_0).vmethod_141().Values)
														{
															if (Client.smethod_50().method_11().ContainsKey(activeUnit6.string_0))
															{
																Contact contact6;
																Client.smethod_50().method_11().TryGetValue(activeUnit6.string_0, ref contact6);
																if (!Information.IsNothing(contact6))
																{
																	strike4.hashSet_0.Add(contact6);
																	if (strike4.method_12() && contact5.method_130(Client.smethod_50()) != Misc.PostureStance.Hostile)
																	{
																		contact5.method_131(Client.smethod_50(), false, Misc.PostureStance.Hostile);
																	}
																}
															}
														}
														continue;
													}
													finally
													{
														IEnumerator<ActiveUnit> enumerator13;
														if (enumerator13 != null)
														{
															enumerator13.Dispose();
														}
													}
												}
												strike4.hashSet_0.Add(contact5);
												if (strike4.method_12() && contact5.method_130(Client.smethod_50()) != Misc.PostureStance.Hostile)
												{
													contact5.method_131(Client.smethod_50(), false, Misc.PostureStance.Hostile);
												}
											}
										}
									}
								}
							}
							finally
							{
								IEnumerator<Unit> enumerator11;
								if (enumerator11 != null)
								{
									enumerator11.Dispose();
								}
							}
							if (strike4.hashSet_0.Count > 0)
							{
								List<Unit> list3 = Enumerable.ToList<Unit>(Enumerable.OrderBy<Unit, string>(strike4.hashSet_0, (NewMission._Closure$__.$I188-2 == null) ? (NewMission._Closure$__.$I188-2 = new Func<Unit, string>(NewMission._Closure$__.$I.method_2)) : NewMission._Closure$__.$I188-2));
								strike4.hashSet_0 = new HashSet<Unit>(list3);
								strike4.bool_27 = true;
							}
							strike4.bool_19 = this.vmethod_44().Checked;
							strike4.bool_20 = this.vmethod_42().Checked;
							strike4.bool_21 = this.vmethod_40().Checked;
							if (strike4.enum88_0 == Mission.Enum88.const_0)
							{
								if (this.nullable_0 != null)
								{
									strike4.method_25(this.nullable_0, Client.smethod_46());
								}
								if (this.nullable_1 != null)
								{
									strike4.method_28(this.nullable_1, Client.smethod_46());
								}
							}
							else
							{
								if (this.nullable_2 != null)
								{
									strike4.method_30(this.nullable_2);
								}
								if (this.nullable_3 != null)
								{
									strike4.method_32(this.nullable_3);
								}
							}
							if (this.bool_3)
							{
								Client.smethod_30().method_7(strike4);
								if (!Client.smethod_30().Visible)
								{
									Client.smethod_30().Show();
								}
								else
								{
									Client.smethod_30().method_3();
								}
								Client.smethod_30().Show();
							}
							base.Close();
							break;
						}
						default:
							DarkMessageBox.smethod_2("Please select a type.", "No type selected", Enum11.const_0);
							return;
						}
						break;
					case 1:
					{
						IEnumerable<ReferencePoint> enumerable = Enumerable.Where<ReferencePoint>(Client.smethod_50().vmethod_12(), (NewMission._Closure$__.$I188-3 == null) ? (NewMission._Closure$__.$I188-3 = new Func<ReferencePoint, bool>(NewMission._Closure$__.$I.method_3)) : NewMission._Closure$__.$I188-3);
						if (Enumerable.Count<ReferencePoint>(enumerable) == 0)
						{
							DarkMessageBox.smethod_2("You must select at least one reference point before creating a patrol mission.", "No reference points selected!", Enum11.const_0);
							return;
						}
						List<ReferencePoint> list4 = new List<ReferencePoint>();
						list4.AddRange(enumerable);
						Mission mission5 = null;
						switch (this.vmethod_10().SelectedIndex)
						{
						case 0:
							mission5 = new Class343(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, list4, GlobalVariables.PatrolType.AAW, true);
							break;
						case 1:
							mission5 = new Class343(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, list4, GlobalVariables.PatrolType.ASuW_Naval, true);
							break;
						case 2:
							mission5 = new Class343(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, list4, GlobalVariables.PatrolType.ASuW_Land, true);
							break;
						case 3:
							mission5 = new Class343(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, list4, GlobalVariables.PatrolType.ASuW_Mixed, true);
							break;
						case 4:
							mission5 = new Class343(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, list4, GlobalVariables.PatrolType.ASW, true);
							break;
						case 5:
							mission5 = new Class343(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, list4, GlobalVariables.PatrolType.SEAD, true);
							break;
						case 6:
							mission5 = new Class343(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, list4, GlobalVariables.PatrolType.SeaControl, true);
							break;
						default:
							DarkMessageBox.smethod_2("Please select a type.", "No type selected", Enum11.const_0);
							return;
						}
						if (Information.IsNothing(mission5))
						{
							DarkMessageBox.smethod_2("Please select a patrol type.", "No patrol type selected!", Enum11.const_0);
						}
						else
						{
							if (mission5.enum88_0 == Mission.Enum88.const_1)
							{
								string right5 = this.vmethod_80().SelectedItem.ToString();
								try
								{
									foreach (Mission mission6 in Client.smethod_50().method_35())
									{
										if (Operators.CompareString(mission6.Name, right5, false) == 0)
										{
											((Class342)mission6).list_5.Add(mission5);
											mission5.method_14(Client.smethod_50(), mission6.string_0);
											break;
										}
									}
								}
								finally
								{
									IEnumerator<Mission> enumerator14;
									if (enumerator14 != null)
									{
										enumerator14.Dispose();
									}
								}
							}
							int selectedIndex5 = this.vmethod_16().SelectedIndex;
							if (selectedIndex5 == 1)
							{
								mission5.method_11(Client.smethod_46(), Mission.Enum89.const_1);
							}
							mission5.bool_19 = this.vmethod_44().Checked;
							mission5.bool_20 = this.vmethod_42().Checked;
							mission5.bool_21 = this.vmethod_40().Checked;
							if (mission5.enum88_0 == Mission.Enum88.const_0)
							{
								if (this.nullable_0 != null)
								{
									mission5.method_25(this.nullable_0, Client.smethod_46());
								}
								if (this.nullable_1 != null)
								{
									mission5.method_28(this.nullable_1, Client.smethod_46());
								}
							}
							else
							{
								if (this.nullable_2 != null)
								{
									mission5.method_30(this.nullable_2);
								}
								if (this.nullable_3 != null)
								{
									mission5.method_32(this.nullable_3);
								}
							}
							if (this.bool_3)
							{
								Client.smethod_30().method_7(mission5);
								if (!Client.smethod_30().Visible)
								{
									Client.smethod_30().Show();
								}
								else
								{
									Client.smethod_30().method_3();
								}
							}
							base.Close();
						}
						break;
					}
					case 2:
					{
						IEnumerable<ReferencePoint> enumerable2 = Enumerable.Where<ReferencePoint>(Client.smethod_50().vmethod_12(), (NewMission._Closure$__.$I188-4 == null) ? (NewMission._Closure$__.$I188-4 = new Func<ReferencePoint, bool>(NewMission._Closure$__.$I.method_4)) : NewMission._Closure$__.$I188-4);
						if (Enumerable.Count<ReferencePoint>(enumerable2) == 0)
						{
							DarkMessageBox.smethod_2("You must select at least one reference point before creating a support mission.", "No reference points selected!", Enum11.const_0);
							return;
						}
						List<ReferencePoint> list5 = new List<ReferencePoint>();
						list5.AddRange(enumerable2);
						Side side_ = Client.smethod_50();
						Scenario scenario = Client.smethod_46();
						Class344 @class = new Class344(ref side_, ref scenario, this.vmethod_2().Text, enum88_, ref list5, true);
						Client.smethod_51(side_);
						Class344 class2 = @class;
						if (class2.enum88_0 == Mission.Enum88.const_1)
						{
							string right6 = this.vmethod_80().SelectedItem.ToString();
							try
							{
								foreach (Mission mission7 in Client.smethod_50().method_35())
								{
									if (Operators.CompareString(mission7.Name, right6, false) == 0)
									{
										((Class342)mission7).list_5.Add(class2);
										class2.method_14(Client.smethod_50(), mission7.string_0);
										break;
									}
								}
							}
							finally
							{
								IEnumerator<Mission> enumerator15;
								if (enumerator15 != null)
								{
									enumerator15.Dispose();
								}
							}
						}
						int selectedIndex6 = this.vmethod_16().SelectedIndex;
						if (selectedIndex6 == 1)
						{
							class2.method_11(Client.smethod_46(), Mission.Enum89.const_1);
						}
						class2.bool_19 = this.vmethod_44().Checked;
						class2.bool_20 = this.vmethod_42().Checked;
						class2.bool_21 = this.vmethod_40().Checked;
						if (class2.enum88_0 == Mission.Enum88.const_0)
						{
							if (this.nullable_0 != null)
							{
								class2.method_25(this.nullable_0, Client.smethod_46());
							}
							if (this.nullable_1 != null)
							{
								class2.method_28(this.nullable_1, Client.smethod_46());
							}
						}
						else
						{
							if (this.nullable_2 != null)
							{
								class2.method_30(this.nullable_2);
							}
							if (this.nullable_3 != null)
							{
								class2.method_32(this.nullable_3);
							}
						}
						if (this.bool_3)
						{
							Client.smethod_30().method_7(class2);
							if (!Client.smethod_30().Visible)
							{
								Client.smethod_30().Show();
							}
							else
							{
								Client.smethod_30().method_3();
							}
						}
						base.Close();
						break;
					}
					case 3:
					{
						if (Information.IsNothing(Client.smethod_54()) || !Client.smethod_54().bool_0)
						{
							DarkMessageBox.smethod_2("You must select a valid destination before creating a ferry mission.", "No valid destination selected!", Enum11.const_0);
							return;
						}
						FerryMission ferryMission = new FerryMission(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, (ActiveUnit)Client.smethod_54());
						if (ferryMission.enum88_0 == Mission.Enum88.const_1)
						{
							string right7 = this.vmethod_80().SelectedItem.ToString();
							try
							{
								foreach (Mission mission8 in Client.smethod_50().method_35())
								{
									if (Operators.CompareString(mission8.Name, right7, false) == 0)
									{
										((Class342)mission8).list_5.Add(ferryMission);
										ferryMission.method_14(Client.smethod_50(), mission8.string_0);
										break;
									}
								}
							}
							finally
							{
								IEnumerator<Mission> enumerator16;
								if (enumerator16 != null)
								{
									enumerator16.Dispose();
								}
							}
						}
						int selectedIndex7 = this.vmethod_16().SelectedIndex;
						if (selectedIndex7 == 1)
						{
							ferryMission.method_11(Client.smethod_46(), Mission.Enum89.const_1);
						}
						ferryMission.bool_19 = this.vmethod_44().Checked;
						ferryMission.bool_20 = this.vmethod_42().Checked;
						ferryMission.bool_21 = this.vmethod_40().Checked;
						if (ferryMission.enum88_0 == Mission.Enum88.const_0)
						{
							if (this.nullable_0 != null)
							{
								ferryMission.method_25(this.nullable_0, Client.smethod_46());
							}
							if (this.nullable_1 != null)
							{
								ferryMission.method_28(this.nullable_1, Client.smethod_46());
							}
						}
						else
						{
							if (this.nullable_2 != null)
							{
								ferryMission.method_30(this.nullable_2);
							}
							if (this.nullable_3 != null)
							{
								ferryMission.method_32(this.nullable_3);
							}
						}
						if (this.bool_3)
						{
							Client.smethod_30().method_7(ferryMission);
							if (!Client.smethod_30().Visible)
							{
								Client.smethod_30().Show();
							}
							else
							{
								Client.smethod_30().method_3();
							}
						}
						base.Close();
						break;
					}
					case 4:
					{
						IEnumerable<ReferencePoint> enumerable3 = Enumerable.Where<ReferencePoint>(Client.smethod_50().vmethod_12(), (NewMission._Closure$__.$I188-5 == null) ? (NewMission._Closure$__.$I188-5 = new Func<ReferencePoint, bool>(NewMission._Closure$__.$I.method_5)) : NewMission._Closure$__.$I188-5);
						if (Enumerable.Count<ReferencePoint>(enumerable3) < 2)
						{
							DarkMessageBox.smethod_2("You must select at least two reference points before creating a mining mission.", "Not enough reference points selected!", Enum11.const_0);
							return;
						}
						List<ReferencePoint> list_ = Enumerable.ToList<ReferencePoint>(enumerable3);
						Class340 class3 = new Class340(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, list_, true);
						if (class3.enum88_0 == Mission.Enum88.const_1)
						{
							string right8 = this.vmethod_80().SelectedItem.ToString();
							try
							{
								foreach (Mission mission9 in Client.smethod_50().method_35())
								{
									if (Operators.CompareString(mission9.Name, right8, false) == 0)
									{
										((Class342)mission9).list_5.Add(class3);
										class3.method_14(Client.smethod_50(), mission9.string_0);
										break;
									}
								}
							}
							finally
							{
								IEnumerator<Mission> enumerator17;
								if (enumerator17 != null)
								{
									enumerator17.Dispose();
								}
							}
						}
						int selectedIndex8 = this.vmethod_16().SelectedIndex;
						if (selectedIndex8 == 1)
						{
							class3.method_11(Client.smethod_46(), Mission.Enum89.const_1);
						}
						class3.bool_19 = this.vmethod_44().Checked;
						class3.bool_20 = this.vmethod_42().Checked;
						class3.bool_21 = this.vmethod_40().Checked;
						if (class3.enum88_0 == Mission.Enum88.const_0)
						{
							if (this.nullable_0 != null)
							{
								class3.method_25(this.nullable_0, Client.smethod_46());
							}
							if (this.nullable_1 != null)
							{
								class3.method_28(this.nullable_1, Client.smethod_46());
							}
						}
						else
						{
							if (this.nullable_2 != null)
							{
								class3.method_30(this.nullable_2);
							}
							if (this.nullable_3 != null)
							{
								class3.method_32(this.nullable_3);
							}
						}
						if (this.bool_3)
						{
							Client.smethod_30().method_7(class3);
							if (!Client.smethod_30().Visible)
							{
								Client.smethod_30().Show();
							}
							else
							{
								Client.smethod_30().method_3();
							}
						}
						base.Close();
						break;
					}
					case 5:
					{
						IEnumerable<ReferencePoint> enumerable4 = Enumerable.Where<ReferencePoint>(Client.smethod_50().vmethod_12(), (NewMission._Closure$__.$I188-6 == null) ? (NewMission._Closure$__.$I188-6 = new Func<ReferencePoint, bool>(NewMission._Closure$__.$I.method_6)) : NewMission._Closure$__.$I188-6);
						if (Enumerable.Count<ReferencePoint>(enumerable4) < 2)
						{
							DarkMessageBox.smethod_2("You must select at least two reference points before creating a mine-clearing mission.", "Not enough reference points selected!", Enum11.const_0);
							return;
						}
						List<ReferencePoint> list_2 = Enumerable.ToList<ReferencePoint>(enumerable4);
						Class341 class4 = new Class341(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, enum88_, list_2, true);
						if (class4.enum88_0 == Mission.Enum88.const_1)
						{
							string right9 = this.vmethod_80().SelectedItem.ToString();
							try
							{
								foreach (Mission mission10 in Client.smethod_50().method_35())
								{
									if (Operators.CompareString(mission10.Name, right9, false) == 0)
									{
										((Class342)mission10).list_5.Add(class4);
										class4.method_14(Client.smethod_50(), mission10.string_0);
										break;
									}
								}
							}
							finally
							{
								IEnumerator<Mission> enumerator18;
								if (enumerator18 != null)
								{
									enumerator18.Dispose();
								}
							}
						}
						int selectedIndex9 = this.vmethod_16().SelectedIndex;
						if (selectedIndex9 == 1)
						{
							class4.method_11(Client.smethod_46(), Mission.Enum89.const_1);
						}
						class4.bool_19 = this.vmethod_44().Checked;
						class4.bool_20 = this.vmethod_42().Checked;
						class4.bool_21 = this.vmethod_40().Checked;
						if (class4.enum88_0 == Mission.Enum88.const_0)
						{
							if (this.nullable_0 != null)
							{
								class4.method_25(this.nullable_0, Client.smethod_46());
							}
							if (this.nullable_1 != null)
							{
								class4.method_28(this.nullable_1, Client.smethod_46());
							}
						}
						else
						{
							if (this.nullable_2 != null)
							{
								class4.method_30(this.nullable_2);
							}
							if (this.nullable_3 != null)
							{
								class4.method_32(this.nullable_3);
							}
						}
						if (this.bool_3)
						{
							Client.smethod_30().method_7(class4);
							if (!Client.smethod_30().Visible)
							{
								Client.smethod_30().Show();
							}
							else
							{
								Client.smethod_30().method_3();
							}
						}
						base.Close();
						break;
					}
					case 6:
					{
						IEnumerable<ReferencePoint> enumerable5 = Enumerable.Where<ReferencePoint>(Client.smethod_50().vmethod_12(), (NewMission._Closure$__.$I188-7 == null) ? (NewMission._Closure$__.$I188-7 = new Func<ReferencePoint, bool>(NewMission._Closure$__.$I.method_7)) : NewMission._Closure$__.$I188-7);
						if (Enumerable.Count<ReferencePoint>(enumerable5) == 0)
						{
							DarkMessageBox.smethod_2("You must select at least one reference point before creating a patrol mission.", "No reference points selected!", Enum11.const_0);
							return;
						}
						List<ReferencePoint> list6 = new List<ReferencePoint>();
						list6.AddRange(enumerable5);
						Class338 class5 = new Class338(Client.smethod_50(), Client.smethod_46(), this.vmethod_2().Text, list6, true);
						if (Information.IsNothing(class5))
						{
							DarkMessageBox.smethod_2("Please select a patrol type.", "No patrol type selected!", Enum11.const_0);
						}
						else
						{
							class5.Name = this.vmethod_2().Text;
							if (this.bool_3)
							{
								Client.smethod_30().method_7(class5);
								if (!Client.smethod_30().Visible)
								{
									Client.smethod_30().Show();
								}
								else
								{
									Client.smethod_30().method_3();
								}
							}
							base.Close();
						}
						break;
					}
					}
					break;
				}
				case 1:
				{
					Side side_ = Client.smethod_50();
					Scenario scenario = Client.smethod_46();
					Class342 class6 = new Class342(ref side_, ref scenario, this.vmethod_2().Text, Mission.Enum88.const_2);
					Client.smethod_51(side_);
					Class342 mission_ = class6;
					if (this.bool_3)
					{
						Client.smethod_30().method_7(mission_);
						if (!Client.smethod_30().Visible)
						{
							Client.smethod_30().Show();
						}
						else
						{
							Client.smethod_30().method_3();
						}
					}
					base.Close();
					break;
				}
				}
				Client.bool_1 = true;
			}
		}

		// Token: 0x06008247 RID: 33351 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_7(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06008248 RID: 33352 RVA: 0x0004F31A File Offset: 0x0004D51A
		private void NewMission_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.vmethod_2().Focus();
			e.Cancel = true;
			base.Hide();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06008249 RID: 33353 RVA: 0x004648A0 File Offset: 0x00462AA0
		public static void smethod_0(ref DataTable dataTable_0)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				"Mission"
			});
		}

		// Token: 0x0600824A RID: 33354 RVA: 0x00464930 File Offset: 0x00462B30
		private void NewMission_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			DataTable dataSource = new DataTable();
			NewMission.smethod_0(ref dataSource);
			Class2451 @class = this.vmethod_22();
			@class.DataSource = dataSource;
			@class.DropDownWidth = 500;
			@class.DisplayMember = "Description";
			@class.ValueMember = "ID";
			this.vmethod_80().Visible = false;
			this.vmethod_44().Visible = false;
			this.vmethod_42().Visible = false;
			this.vmethod_40().Visible = false;
			this.vmethod_82().Visible = false;
			this.Text = "New Mission";
			this.method_8();
			this.vmethod_12().Enabled = (Operators.CompareString(this.vmethod_2().Text, "", false) != 0);
		}

		// Token: 0x0600824B RID: 33355 RVA: 0x0004F344 File Offset: 0x0004D544
		private void NewMission_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.vmethod_2().Text = "";
				this.method_8();
			}
		}

		// Token: 0x0600824C RID: 33356 RVA: 0x004649FC File Offset: 0x00462BFC
		private void method_8()
		{
			this.vmethod_2().Text = "";
			this.nullable_0 = null;
			this.nullable_1 = null;
			this.nullable_2 = null;
			this.nullable_3 = null;
			if (this.vmethod_22().Items.Count > 0)
			{
				this.vmethod_22().SelectedIndex = 0;
			}
			this.method_11();
			if (this.vmethod_4().Items.Count > 0)
			{
				this.vmethod_4().SelectedIndex = 0;
			}
			if (this.vmethod_10().Items.Count > 0)
			{
				this.vmethod_10().SelectedIndex = 0;
			}
			this.vmethod_84().Checked = this.bool_3;
			if (this.vmethod_16().Items.Count > 0)
			{
				this.vmethod_16().SelectedIndex = 0;
			}
			this.vmethod_26().Visible = true;
			this.vmethod_38().Visible = true;
			this.vmethod_56().Visible = false;
			this.vmethod_66().Visible = false;
			this.vmethod_32().Mask = "None";
			this.vmethod_30().Mask = "None";
			this.vmethod_52().Mask = "None";
			this.vmethod_48().Mask = "None";
			this.vmethod_60().Mask = "None";
			this.vmethod_58().Mask = "None";
			this.vmethod_70().Mask = "None";
			this.vmethod_68().Mask = "None";
			this.method_36();
		}

		// Token: 0x0600824D RID: 33357 RVA: 0x00464B94 File Offset: 0x00462D94
		private void NewMission_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F11 && e.Modifiers == Keys.Control && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.Return && base.Visible && this.vmethod_12().Enabled)
			{
				this.method_6();
			}
			if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600824E RID: 33358 RVA: 0x0004F364 File Offset: 0x0004D564
		private void method_9(object sender, EventArgs e)
		{
			this.bool_3 = this.vmethod_84().Checked;
		}

		// Token: 0x0600824F RID: 33359 RVA: 0x00464C94 File Offset: 0x00462E94
		private void method_10(object sender, EventArgs e)
		{
			this.method_11();
			if (this.vmethod_4().Items.Count > 0 && this.vmethod_4().SelectedIndex < 0)
			{
				this.vmethod_4().SelectedIndex = 0;
			}
			if (this.vmethod_10().Items.Count > 0 && this.vmethod_10().SelectedIndex < 0)
			{
				this.vmethod_10().SelectedIndex = 0;
			}
		}

		// Token: 0x06008250 RID: 33360 RVA: 0x00464D04 File Offset: 0x00462F04
		private void method_11()
		{
			if (this.vmethod_22().SelectedIndex != -1)
			{
				switch (this.vmethod_22().SelectedIndex)
				{
				case 0:
				case 2:
					if (this.vmethod_22().SelectedIndex == 2)
					{
						this.vmethod_2().Text = "Package " + Conversions.ToString(Client.smethod_50().method_92());
						this.vmethod_26().Visible = false;
						this.vmethod_38().Visible = false;
						this.vmethod_56().Visible = true;
						this.vmethod_66().Visible = true;
						this.vmethod_80().Enabled = true;
						this.vmethod_82().Enabled = true;
						this.vmethod_80().Items.Clear();
						try
						{
							foreach (Mission mission in Client.smethod_50().method_35())
							{
								if (mission.enum88_0 == Mission.Enum88.const_2)
								{
									this.vmethod_80().Items.Add(mission.Name);
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
						if (this.vmethod_80().Items.Count > 0)
						{
							this.vmethod_80().SelectedIndex = 0;
						}
					}
					else
					{
						this.vmethod_2().Text = "Mission: <name>";
						this.vmethod_26().Visible = true;
						this.vmethod_38().Visible = true;
						this.vmethod_56().Visible = false;
						this.vmethod_66().Visible = false;
						this.vmethod_80().Enabled = false;
						this.vmethod_82().Enabled = true;
						this.vmethod_80().Items.Clear();
					}
					this.vmethod_10().Items.Clear();
					this.vmethod_10().Enabled = false;
					this.vmethod_8().Enabled = false;
					this.vmethod_4().Enabled = true;
					this.vmethod_6().Enabled = true;
					this.vmethod_4().Items.Clear();
					this.vmethod_4().Items.Add("Strike (incl. Air Intercept)");
					this.vmethod_4().Items.Add("Patrol");
					this.vmethod_4().Items.Add("Support");
					this.vmethod_4().Items.Add("Ferry");
					this.vmethod_4().Items.Add("Mining");
					this.vmethod_4().Items.Add("Mine-clearing");
					this.vmethod_4().Items.Add("Cargo");
					break;
				case 1:
					this.vmethod_26().Visible = false;
					this.vmethod_38().Visible = false;
					this.vmethod_56().Visible = false;
					this.vmethod_66().Visible = false;
					this.vmethod_80().Enabled = false;
					this.vmethod_82().Enabled = false;
					this.vmethod_80().Items.Clear();
					this.vmethod_4().Items.Clear();
					this.vmethod_4().Enabled = false;
					this.vmethod_6().Enabled = false;
					this.vmethod_10().Items.Clear();
					this.vmethod_10().Enabled = false;
					this.vmethod_8().Enabled = false;
					this.vmethod_2().Text = "Task Pool: <name>";
					break;
				}
				this.method_36();
			}
		}

		// Token: 0x06008251 RID: 33361 RVA: 0x0004F377 File Offset: 0x0004D577
		private void method_12(object sender, EventArgs e)
		{
			this.bool_4 = true;
			this.method_28();
		}

		// Token: 0x06008252 RID: 33362 RVA: 0x0004F386 File Offset: 0x0004D586
		private void method_13(object sender, EventArgs e)
		{
			this.method_29();
		}

		// Token: 0x06008253 RID: 33363 RVA: 0x0004F377 File Offset: 0x0004D577
		private void method_14(object sender, EventArgs e)
		{
			this.bool_4 = true;
			this.method_28();
		}

		// Token: 0x06008254 RID: 33364 RVA: 0x0004F386 File Offset: 0x0004D586
		private void method_15(object sender, EventArgs e)
		{
			this.method_29();
		}

		// Token: 0x06008255 RID: 33365 RVA: 0x0004F38E File Offset: 0x0004D58E
		private void method_16(object sender, EventArgs e)
		{
			this.bool_5 = true;
			this.method_30();
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x0004F39D File Offset: 0x0004D59D
		private void method_17(object sender, EventArgs e)
		{
			this.method_31();
		}

		// Token: 0x06008257 RID: 33367 RVA: 0x0004F38E File Offset: 0x0004D58E
		private void method_18(object sender, EventArgs e)
		{
			this.bool_5 = true;
			this.method_30();
		}

		// Token: 0x06008258 RID: 33368 RVA: 0x0004F39D File Offset: 0x0004D59D
		private void method_19(object sender, EventArgs e)
		{
			this.method_31();
		}

		// Token: 0x06008259 RID: 33369 RVA: 0x0004F3A5 File Offset: 0x0004D5A5
		private void method_20(object sender, EventArgs e)
		{
			this.bool_6 = true;
			this.method_32();
		}

		// Token: 0x0600825A RID: 33370 RVA: 0x0004F3B4 File Offset: 0x0004D5B4
		private void method_21(object sender, EventArgs e)
		{
			this.method_33();
		}

		// Token: 0x0600825B RID: 33371 RVA: 0x0004F3A5 File Offset: 0x0004D5A5
		private void method_22(object sender, EventArgs e)
		{
			this.bool_6 = true;
			this.method_32();
		}

		// Token: 0x0600825C RID: 33372 RVA: 0x0004F3B4 File Offset: 0x0004D5B4
		private void method_23(object sender, EventArgs e)
		{
			this.method_33();
		}

		// Token: 0x0600825D RID: 33373 RVA: 0x0004F3BC File Offset: 0x0004D5BC
		private void method_24(object sender, EventArgs e)
		{
			this.bool_7 = true;
			this.method_34();
		}

		// Token: 0x0600825E RID: 33374 RVA: 0x0004F3CB File Offset: 0x0004D5CB
		private void method_25(object sender, EventArgs e)
		{
			this.method_35();
		}

		// Token: 0x0600825F RID: 33375 RVA: 0x0004F3BC File Offset: 0x0004D5BC
		private void method_26(object sender, EventArgs e)
		{
			this.bool_7 = true;
			this.method_34();
		}

		// Token: 0x06008260 RID: 33376 RVA: 0x0004F3CB File Offset: 0x0004D5CB
		private void method_27(object sender, EventArgs e)
		{
			this.method_35();
		}

		// Token: 0x06008261 RID: 33377 RVA: 0x00465068 File Offset: 0x00463268
		private void method_28()
		{
			if (Information.IsNothing(this.nullable_0))
			{
				this.vmethod_32().Mask = "0000-00-00";
				this.vmethod_30().Mask = "00:00:00";
				DateTime dateTime = Client.smethod_46().method_31();
				string text = "";
				string text2 = "";
				GameGeneral.smethod_47(ref dateTime, ref text);
				GameGeneral.smethod_48(ref dateTime, ref text2, false);
				this.vmethod_30().Text = text;
				this.vmethod_32().Text = text2;
			}
		}

		// Token: 0x06008262 RID: 33378 RVA: 0x004650EC File Offset: 0x004632EC
		private void method_29()
		{
			if (this.bool_4)
			{
				this.vmethod_32().Mask = "0000-00-00";
				this.vmethod_30().Mask = "00:00:00";
				List<string> list = Enumerable.ToList<string>(this.vmethod_30().Text.Split(new char[]
				{
					':'
				}));
				if (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2]))
				{
					List<string> list2 = Enumerable.ToList<string>(this.vmethod_32().Text.Split(new char[]
					{
						'-'
					}));
					if (Versioned.IsNumeric(list2[0]) & Versioned.IsNumeric(list2[1]) & Versioned.IsNumeric(list2[2]))
					{
						this.nullable_0 = new DateTime?(new DateTime(Conversions.ToInteger(list2[0]), Conversions.ToInteger(list2[1]), Conversions.ToInteger(list2[2]), Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2])));
						this.bool_4 = false;
					}
				}
			}
		}

		// Token: 0x06008263 RID: 33379 RVA: 0x00465218 File Offset: 0x00463418
		private void method_30()
		{
			if (Information.IsNothing(this.nullable_1))
			{
				this.vmethod_52().Mask = "0000-00-00";
				this.vmethod_48().Mask = "00:00:00";
				DateTime dateTime = Client.smethod_46().method_27().Add(Client.smethod_46().method_29());
				string text = "";
				string text2 = "";
				GameGeneral.smethod_47(ref dateTime, ref text);
				GameGeneral.smethod_48(ref dateTime, ref text2, false);
				this.vmethod_48().Text = text;
				this.vmethod_52().Text = text2;
			}
		}

		// Token: 0x06008264 RID: 33380 RVA: 0x004652AC File Offset: 0x004634AC
		private void method_31()
		{
			if (this.bool_5)
			{
				this.vmethod_52().Mask = "0000-00-00";
				this.vmethod_48().Mask = "00:00:00";
				List<string> list = Enumerable.ToList<string>(this.vmethod_48().Text.Split(new char[]
				{
					':'
				}));
				if (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2]))
				{
					List<string> list2 = Enumerable.ToList<string>(this.vmethod_52().Text.Split(new char[]
					{
						'-'
					}));
					if (Versioned.IsNumeric(list2[0]) & Versioned.IsNumeric(list2[1]) & Versioned.IsNumeric(list2[2]))
					{
						this.nullable_1 = new DateTime?(new DateTime(Conversions.ToInteger(list2[0]), Conversions.ToInteger(list2[1]), Conversions.ToInteger(list2[2]), Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2])));
						this.bool_5 = false;
					}
				}
			}
		}

		// Token: 0x06008265 RID: 33381 RVA: 0x004653D8 File Offset: 0x004635D8
		private void method_32()
		{
			if (Information.IsNothing(this.nullable_2))
			{
				this.vmethod_60().Mask = "0000-00-00";
				this.vmethod_58().Mask = "00:00:00";
				DateTime dateTime = Client.smethod_46().method_27().AddMinutes(30.0);
				string text = "";
				string text2 = "";
				GameGeneral.smethod_47(ref dateTime, ref text);
				GameGeneral.smethod_48(ref dateTime, ref text2, false);
				this.vmethod_60().Text = text;
				this.vmethod_58().Text = text2;
			}
		}

		// Token: 0x06008266 RID: 33382 RVA: 0x0046546C File Offset: 0x0046366C
		private void method_33()
		{
			if (this.bool_6)
			{
				this.vmethod_60().Mask = "0000-00-00";
				this.vmethod_58().Mask = "00:00:00";
				List<string> list = Enumerable.ToList<string>(this.vmethod_58().Text.Split(new char[]
				{
					':'
				}));
				if (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2]))
				{
					List<string> list2 = Enumerable.ToList<string>(this.vmethod_60().Text.Split(new char[]
					{
						'-'
					}));
					if (Versioned.IsNumeric(list2[0]) & Versioned.IsNumeric(list2[1]) & Versioned.IsNumeric(list2[2]))
					{
						this.nullable_2 = new DateTime?(new DateTime(Conversions.ToInteger(list2[0]), Conversions.ToInteger(list2[1]), Conversions.ToInteger(list2[2]), Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2])));
						this.method_36();
						this.bool_6 = false;
					}
				}
			}
		}

		// Token: 0x06008267 RID: 33383 RVA: 0x004655A0 File Offset: 0x004637A0
		private void method_34()
		{
			if (Information.IsNothing(this.nullable_3))
			{
				this.vmethod_70().Mask = "0000-00-00";
				this.vmethod_68().Mask = "00:00:00";
				DateTime dateTime = Client.smethod_46().method_27().AddHours(3.0);
				string text = "";
				string text2 = "";
				GameGeneral.smethod_47(ref dateTime, ref text);
				GameGeneral.smethod_48(ref dateTime, ref text2, false);
				this.vmethod_70().Text = text;
				this.vmethod_68().Text = text2;
			}
		}

		// Token: 0x06008268 RID: 33384 RVA: 0x00465634 File Offset: 0x00463834
		private void method_35()
		{
			if (this.bool_7)
			{
				this.vmethod_70().Mask = "0000-00-00";
				this.vmethod_68().Mask = "00:00:00";
				List<string> list = Enumerable.ToList<string>(this.vmethod_68().Text.Split(new char[]
				{
					':'
				}));
				if (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2]))
				{
					List<string> list2 = Enumerable.ToList<string>(this.vmethod_70().Text.Split(new char[]
					{
						'-'
					}));
					if (Versioned.IsNumeric(list2[0]) & Versioned.IsNumeric(list2[1]) & Versioned.IsNumeric(list2[2]))
					{
						this.nullable_3 = new DateTime?(new DateTime(Conversions.ToInteger(list2[0]), Conversions.ToInteger(list2[1]), Conversions.ToInteger(list2[2]), Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2])));
						this.method_36();
						this.bool_7 = false;
					}
				}
			}
		}

		// Token: 0x06008269 RID: 33385 RVA: 0x00465768 File Offset: 0x00463968
		private void method_36()
		{
			if (this.nullable_3 != null)
			{
				this.vmethod_60().Enabled = false;
				this.vmethod_58().Enabled = false;
				this.vmethod_76().Enabled = false;
				this.vmethod_70().Enabled = true;
				this.vmethod_68().Enabled = true;
				this.vmethod_78().Enabled = true;
				return;
			}
			if (this.nullable_2 != null)
			{
				this.vmethod_60().Enabled = true;
				this.vmethod_58().Enabled = true;
				this.vmethod_76().Enabled = true;
				this.vmethod_70().Enabled = false;
				this.vmethod_68().Enabled = false;
				this.vmethod_78().Enabled = false;
				return;
			}
			this.vmethod_60().Enabled = true;
			this.vmethod_58().Enabled = true;
			this.vmethod_76().Enabled = true;
			this.vmethod_70().Enabled = true;
			this.vmethod_68().Enabled = true;
			this.vmethod_78().Enabled = true;
		}

		// Token: 0x0600826A RID: 33386 RVA: 0x0046586C File Offset: 0x00463A6C
		private void method_37(object sender, EventArgs e)
		{
			this.nullable_0 = null;
			this.vmethod_32().Mask = "";
			this.vmethod_30().Mask = "";
			this.vmethod_32().Text = "None";
			this.vmethod_30().Text = "None";
		}

		// Token: 0x0600826B RID: 33387 RVA: 0x004658C8 File Offset: 0x00463AC8
		private void method_38(object sender, EventArgs e)
		{
			this.nullable_1 = null;
			this.vmethod_52().Mask = "";
			this.vmethod_48().Mask = "";
			this.vmethod_52().Text = "None";
			this.vmethod_48().Text = "None";
		}

		// Token: 0x0600826C RID: 33388 RVA: 0x00465924 File Offset: 0x00463B24
		private void method_39(object sender, EventArgs e)
		{
			this.nullable_2 = null;
			this.vmethod_60().Mask = "";
			this.vmethod_58().Mask = "";
			this.vmethod_60().Text = "None";
			this.vmethod_58().Text = "None";
			this.method_36();
		}

		// Token: 0x0600826D RID: 33389 RVA: 0x00465984 File Offset: 0x00463B84
		private void method_40(object sender, EventArgs e)
		{
			this.nullable_3 = null;
			this.vmethod_70().Mask = "";
			this.vmethod_68().Mask = "";
			this.vmethod_70().Text = "None";
			this.vmethod_68().Text = "None";
			this.method_36();
		}

		// Token: 0x0600826E RID: 33390 RVA: 0x0004F3D3 File Offset: 0x0004D5D3
		private void method_41(object sender, EventArgs e)
		{
			this.bool_4 = true;
			this.method_29();
		}

		// Token: 0x0600826F RID: 33391 RVA: 0x0004F3E2 File Offset: 0x0004D5E2
		private void method_42(object sender, EventArgs e)
		{
			this.bool_5 = true;
			this.method_31();
		}

		// Token: 0x06008270 RID: 33392 RVA: 0x0004F3F1 File Offset: 0x0004D5F1
		private void method_43(object sender, EventArgs e)
		{
			this.bool_6 = true;
			this.method_33();
		}

		// Token: 0x06008271 RID: 33393 RVA: 0x0004F400 File Offset: 0x0004D600
		private void method_44(object sender, EventArgs e)
		{
			this.bool_7 = true;
			this.method_35();
		}

		// Token: 0x0400475D RID: 18269
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x0400475E RID: 18270
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_Name")]
		private Control8 control8_0;

		// Token: 0x0400475F RID: 18271
		[CompilerGenerated]
		[AccessedThroughProperty("CB_MissionClass")]
		private Class2451 class2451_0;

		// Token: 0x04004760 RID: 18272
		[CompilerGenerated]
		[AccessedThroughProperty("Label_MissionClass")]
		private Class116 class116_1;

		// Token: 0x04004761 RID: 18273
		[CompilerGenerated]
		[AccessedThroughProperty("Label_MissionType")]
		private Class116 class116_2;

		// Token: 0x04004762 RID: 18274
		[CompilerGenerated]
		[AccessedThroughProperty("CB_MissionType")]
		private Class2451 class2451_1;

		// Token: 0x04004763 RID: 18275
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04004764 RID: 18276
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x04004765 RID: 18277
		[CompilerGenerated]
		[AccessedThroughProperty("CB_MissionStatus")]
		private Class2451 class2451_2;

		// Token: 0x04004766 RID: 18278
		[CompilerGenerated]
		[AccessedThroughProperty("Label_MissionStatus")]
		private Class116 class116_3;

		// Token: 0x04004767 RID: 18279
		[CompilerGenerated]
		[AccessedThroughProperty("Label_Category")]
		private Class116 class116_4;

		// Token: 0x04004768 RID: 18280
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Category")]
		private Class2451 class2451_3;

		// Token: 0x04004769 RID: 18281
		[CompilerGenerated]
		[AccessedThroughProperty("FlowLayoutPanel1")]
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x0400476A RID: 18282
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox_ActivationTime")]
		private Class115 class115_0;

		// Token: 0x0400476B RID: 18283
		[CompilerGenerated]
		[AccessedThroughProperty("Button_Clear_ActivationTime")]
		private Control9 control9_2;

		// Token: 0x0400476C RID: 18284
		[CompilerGenerated]
		[AccessedThroughProperty("DateTimePicker_ActivationTime")]
		private Class118 class118_0;

		// Token: 0x0400476D RID: 18285
		[CompilerGenerated]
		[AccessedThroughProperty("DateTimePicker_ActivationDate")]
		private Class118 class118_1;

		// Token: 0x0400476E RID: 18286
		[CompilerGenerated]
		[AccessedThroughProperty("Label101")]
		private Class116 class116_5;

		// Token: 0x0400476F RID: 18287
		[CompilerGenerated]
		[AccessedThroughProperty("Label102")]
		private Class116 class116_6;

		// Token: 0x04004770 RID: 18288
		[AccessedThroughProperty("GroupBox_DeactivationTime")]
		[CompilerGenerated]
		private Class115 class115_1;

		// Token: 0x04004771 RID: 18289
		[AccessedThroughProperty("CheckBox_DeleteMission")]
		[CompilerGenerated]
		private Class112 class112_0;

		// Token: 0x04004772 RID: 18290
		[AccessedThroughProperty("CheckBox_OrderRTB")]
		[CompilerGenerated]
		private Class112 class112_1;

		// Token: 0x04004773 RID: 18291
		[AccessedThroughProperty("CheckBox_UnassignUnits")]
		[CompilerGenerated]
		private Class112 class112_2;

		// Token: 0x04004774 RID: 18292
		[AccessedThroughProperty("Button_Clear_DeactivationTime")]
		[CompilerGenerated]
		private Control9 control9_3;

		// Token: 0x04004775 RID: 18293
		[AccessedThroughProperty("DateTimePicker_DeactivationTime")]
		[CompilerGenerated]
		private Class118 class118_2;

		// Token: 0x04004776 RID: 18294
		[AccessedThroughProperty("Label112")]
		[CompilerGenerated]
		private Class116 class116_7;

		// Token: 0x04004777 RID: 18295
		[AccessedThroughProperty("DateTimePicker_DeactivationDate")]
		[CompilerGenerated]
		private Class118 class118_3;

		// Token: 0x04004778 RID: 18296
		[AccessedThroughProperty("Label114")]
		[CompilerGenerated]
		private Class116 class116_8;

		// Token: 0x04004779 RID: 18297
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox_TakeOffTime")]
		private Class115 class115_2;

		// Token: 0x0400477A RID: 18298
		[AccessedThroughProperty("DateTimePicker_TakeOffTime")]
		[CompilerGenerated]
		private Class118 class118_4;

		// Token: 0x0400477B RID: 18299
		[AccessedThroughProperty("DateTimePicker_TakeOffDate")]
		[CompilerGenerated]
		private Class118 class118_5;

		// Token: 0x0400477C RID: 18300
		[AccessedThroughProperty("Label162")]
		[CompilerGenerated]
		private Class116 class116_9;

		// Token: 0x0400477D RID: 18301
		[CompilerGenerated]
		[AccessedThroughProperty("Label169")]
		private Class116 class116_10;

		// Token: 0x0400477E RID: 18302
		[AccessedThroughProperty("GroupBox_TimeOnTarget")]
		[CompilerGenerated]
		private Class115 class115_3;

		// Token: 0x0400477F RID: 18303
		[AccessedThroughProperty("DateTimePicker_TimeOnTargetTime")]
		[CompilerGenerated]
		private Class118 class118_6;

		// Token: 0x04004780 RID: 18304
		[AccessedThroughProperty("DateTimePicker_TimeOnTargetDate")]
		[CompilerGenerated]
		private Class118 class118_7;

		// Token: 0x04004781 RID: 18305
		[AccessedThroughProperty("Label170")]
		[CompilerGenerated]
		private Class116 class116_11;

		// Token: 0x04004782 RID: 18306
		[AccessedThroughProperty("Label171")]
		[CompilerGenerated]
		private Class116 class116_12;

		// Token: 0x04004783 RID: 18307
		[CompilerGenerated]
		[AccessedThroughProperty("Button_Clear_TakeOffTime")]
		private Control9 control9_4;

		// Token: 0x04004784 RID: 18308
		[AccessedThroughProperty("Button_Clear_TimeOnTarget")]
		[CompilerGenerated]
		private Control9 control9_5;

		// Token: 0x04004785 RID: 18309
		[CompilerGenerated]
		[AccessedThroughProperty("CB_ParentPool")]
		private Class2451 class2451_4;

		// Token: 0x04004786 RID: 18310
		[CompilerGenerated]
		[AccessedThroughProperty("Label_ParentPool")]
		private Class116 class116_13;

		// Token: 0x04004787 RID: 18311
		[CompilerGenerated]
		[AccessedThroughProperty("CB_OpenMissionEditor")]
		private Class112 class112_3;

		// Token: 0x04004788 RID: 18312
		private bool bool_3;

		// Token: 0x04004789 RID: 18313
		private bool bool_4;

		// Token: 0x0400478A RID: 18314
		private bool bool_5;

		// Token: 0x0400478B RID: 18315
		private bool bool_6;

		// Token: 0x0400478C RID: 18316
		private bool bool_7;

		// Token: 0x0400478D RID: 18317
		private DateTime? nullable_0;

		// Token: 0x0400478E RID: 18318
		private DateTime? nullable_1;

		// Token: 0x0400478F RID: 18319
		private DateTime? nullable_2;

		// Token: 0x04004790 RID: 18320
		private DateTime? nullable_3;
	}
}
