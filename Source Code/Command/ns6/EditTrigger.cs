using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000EBE RID: 3774
	[DesignerGenerated]
	internal sealed partial class EditTrigger : DarkSecondaryFormBase
	{
		// Token: 0x060079CF RID: 31183 RVA: 0x0042313C File Offset: 0x0042133C
		public EditTrigger()
		{
			base.FormClosing += this.EditTrigger_FormClosing;
			base.Load += this.EditTrigger_Load;
			base.KeyDown += this.EditTrigger_KeyDown;
			base.FormClosed += this.EditTrigger_FormClosed;
			this.InitializeComponent_1();
		}

		// Token: 0x060079D1 RID: 31185 RVA: 0x004231E0 File Offset: 0x004213E0
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			this.vmethod_1(new Class116());
			this.vmethod_3(new Control8());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Control9());
			this.vmethod_9(new Class116());
			this.vmethod_11(new TabPage());
			this.vmethod_15(new UnitFilter());
			this.vmethod_13(new Control12());
			this.vmethod_17(new TabPage());
			this.vmethod_45(new Class120());
			this.vmethod_47(new Class116());
			this.vmethod_21(new UnitFilter());
			this.vmethod_19(new TabPage());
			this.vmethod_23(new Class2451());
			this.vmethod_25(new Class116());
			this.vmethod_27(new Class120());
			this.vmethod_29(new Class2451());
			this.vmethod_31(new Class116());
			this.vmethod_33(new Class116());
			this.vmethod_35(new TabPage());
			this.vmethod_43(new Control9());
			this.vmethod_41(new Class116());
			this.vmethod_37(new Class118());
			this.vmethod_39(new Class118());
			this.vmethod_49(new TabPage());
			this.vmethod_55(new Class115());
			this.vmethod_67(new Class116());
			this.vmethod_69(new Class116());
			this.vmethod_71(new Control8());
			this.vmethod_57(new Control8());
			this.vmethod_59(new Control8());
			this.vmethod_61(new Class116());
			this.vmethod_63(new Control8());
			this.vmethod_65(new Class116());
			this.vmethod_53(new AreaEditor());
			this.vmethod_51(new UnitFilter());
			this.vmethod_73(new TabPage());
			this.vmethod_93(new Class112());
			this.vmethod_95(new Class112());
			this.vmethod_75(new Class115());
			this.vmethod_89(new Control9());
			this.vmethod_91(new Class118());
			this.vmethod_99(new Class118());
			this.vmethod_87(new Class118());
			this.vmethod_85(new Class118());
			this.vmethod_77(new Class116());
			this.vmethod_79(new Class116());
			this.vmethod_81(new AreaEditor());
			this.vmethod_83(new UnitFilter());
			this.vmethod_101(new TabPage());
			this.vmethod_103(new Class116());
			this.vmethod_105(new Class118());
			this.vmethod_107(new Class118());
			this.vmethod_109(new Class116());
			this.vmethod_111(new Control9());
			this.vmethod_113(new Class116());
			this.vmethod_115(new Class118());
			this.vmethod_117(new Class118());
			this.vmethod_119(new TabPage());
			this.vmethod_137(new AreaEditor());
			this.vmethod_133(new Class2451());
			this.vmethod_135(new Class116());
			this.vmethod_123(new Class2451());
			this.vmethod_125(new Class116());
			this.vmethod_121(new UnitFilter());
			this.vmethod_127(new TabPage());
			this.vmethod_129(new Class2451());
			this.vmethod_131(new Class116());
			this.vmethod_97(new System.Windows.Forms.ToolTip(this.icontainer_1));
			this.vmethod_10().SuspendLayout();
			this.vmethod_12().SuspendLayout();
			this.vmethod_16().SuspendLayout();
			((ISupportInitialize)this.vmethod_44()).BeginInit();
			this.vmethod_18().SuspendLayout();
			((ISupportInitialize)this.vmethod_26()).BeginInit();
			this.vmethod_34().SuspendLayout();
			this.vmethod_48().SuspendLayout();
			this.vmethod_54().SuspendLayout();
			this.vmethod_72().SuspendLayout();
			this.vmethod_74().SuspendLayout();
			this.vmethod_100().SuspendLayout();
			this.vmethod_118().SuspendLayout();
			this.vmethod_126().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().method_2(true);
			this.vmethod_0().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(4, 10);
			this.vmethod_0().Name = "Label2";
			this.vmethod_0().Size = new Size(69, 13);
			this.vmethod_0().TabIndex = 3;
			this.vmethod_0().Text = "Description:";
			this.vmethod_2().method_14(null);
			this.vmethod_2().method_15(AutoCompleteMode.None);
			this.vmethod_2().method_13(AutoCompleteSource.None);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().method_17(new Font("Segoe UI", 10f));
			this.vmethod_2().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_2().method_12(null);
			this.vmethod_2().method_18(null);
			this.vmethod_2().Location = new Point(90, 6);
			this.vmethod_2().method_2(32767);
			this.vmethod_2().method_7(false);
			this.vmethod_2().Name = "TextBox1";
			this.vmethod_2().method_3(false);
			this.vmethod_2().method_19(ScrollBars.None);
			this.vmethod_2().method_9(0);
			this.vmethod_2().Size = new Size(451, 20);
			this.vmethod_2().TabIndex = 4;
			this.vmethod_2().method_1(HorizontalAlignment.Left);
			this.vmethod_2().method_5(false);
			this.vmethod_2().method_10("");
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().Font = new Font("Segoe UI", 10f);
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(2, 402);
			this.vmethod_4().Name = "Button_OK";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(111, 23);
			this.vmethod_4().TabIndex = 5;
			this.vmethod_4().Text = "OK";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font("Segoe UI", 10f);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(624, 402);
			this.vmethod_6().Name = "Button_Cancel";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(120, 23);
			this.vmethod_6().TabIndex = 6;
			this.vmethod_6().Text = "Cancel";
			this.vmethod_8().method_2(true);
			this.vmethod_8().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(1, 43);
			this.vmethod_8().Name = "Label3";
			this.vmethod_8().Size = new Size(105, 13);
			this.vmethod_8().TabIndex = 7;
			this.vmethod_8().Text = "Settings for trigger";
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().Controls.Add(this.vmethod_14());
			this.vmethod_10().Location = new Point(4, 36);
			this.vmethod_10().Name = "TabPage1";
			this.vmethod_10().Padding = new Padding(3);
			this.vmethod_10().Size = new Size(744, 297);
			this.vmethod_10().TabIndex = 0;
			this.vmethod_10().Text = "Unit is Destroyed";
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().method_2(null);
			this.vmethod_14().Location = new Point(6, 6);
			this.vmethod_14().MinimumSize = new Size(311, 177);
			this.vmethod_14().Name = "UnitFilter_UnitDestroyed";
			this.vmethod_14().Size = new Size(311, 177);
			this.vmethod_14().TabIndex = 0;
			this.vmethod_12().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_12().Controls.Add(this.vmethod_10());
			this.vmethod_12().Controls.Add(this.vmethod_16());
			this.vmethod_12().Controls.Add(this.vmethod_18());
			this.vmethod_12().Controls.Add(this.vmethod_34());
			this.vmethod_12().Controls.Add(this.vmethod_48());
			this.vmethod_12().Controls.Add(this.vmethod_72());
			this.vmethod_12().Controls.Add(this.vmethod_100());
			this.vmethod_12().Controls.Add(this.vmethod_118());
			this.vmethod_12().Controls.Add(this.vmethod_126());
			this.vmethod_12().Cursor = Cursors.Hand;
			this.vmethod_12().Font = new Font("Segoe UI", 8f);
			this.vmethod_12().ItemSize = new Size(80, 32);
			this.vmethod_12().Location = new Point(2, 59);
			this.vmethod_12().Multiline = true;
			this.vmethod_12().Name = "TC_TriggerOptions";
			this.vmethod_12().SelectedIndex = 0;
			this.vmethod_12().Size = new Size(752, 337);
			this.vmethod_12().SizeMode = TabSizeMode.Fixed;
			this.vmethod_12().TabIndex = 20;
			this.vmethod_16().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_16().Controls.Add(this.vmethod_44());
			this.vmethod_16().Controls.Add(this.vmethod_46());
			this.vmethod_16().Controls.Add(this.vmethod_20());
			this.vmethod_16().Location = new Point(4, 36);
			this.vmethod_16().Name = "TabPage2";
			this.vmethod_16().Size = new Size(744, 297);
			this.vmethod_16().TabIndex = 1;
			this.vmethod_16().Text = "Unit is Damaged";
			this.vmethod_44().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_44().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_44().Font = new Font("Segoe UI", 10f);
			this.vmethod_44().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_44().Location = new Point(166, 181);
			this.vmethod_44().Name = "NUD_DamagePercent";
			this.vmethod_44().Size = new Size(74, 25);
			this.vmethod_44().TabIndex = 3;
			this.vmethod_46().method_2(true);
			this.vmethod_46().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_46().Location = new Point(20, 186);
			this.vmethod_46().Name = "Label7";
			this.vmethod_46().Size = new Size(148, 13);
			this.vmethod_46().TabIndex = 2;
			this.vmethod_46().Text = "Damage Percent Threshold:";
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().method_2(null);
			this.vmethod_20().Location = new Point(6, 6);
			this.vmethod_20().MinimumSize = new Size(311, 177);
			this.vmethod_20().Name = "UnitFilter_UnitDamaged";
			this.vmethod_20().Size = new Size(311, 177);
			this.vmethod_20().TabIndex = 1;
			this.vmethod_18().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_18().Controls.Add(this.vmethod_22());
			this.vmethod_18().Controls.Add(this.vmethod_24());
			this.vmethod_18().Controls.Add(this.vmethod_26());
			this.vmethod_18().Controls.Add(this.vmethod_28());
			this.vmethod_18().Controls.Add(this.vmethod_30());
			this.vmethod_18().Controls.Add(this.vmethod_32());
			this.vmethod_18().Location = new Point(4, 36);
			this.vmethod_18().Name = "TabPage3";
			this.vmethod_18().Size = new Size(744, 297);
			this.vmethod_18().TabIndex = 2;
			this.vmethod_18().Text = "Side Points";
			this.vmethod_22().BackColor = Color.Transparent;
			this.vmethod_22().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_22().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_22().Font = new Font("Segoe UI", 7f);
			this.vmethod_22().FormattingEnabled = true;
			this.vmethod_22().Items.AddRange(new object[]
			{
				"exceeds",
				"reaches exactly",
				"falls under"
			});
			this.vmethod_22().Location = new Point(153, 126);
			this.vmethod_22().Name = "CB_Points_ReachDirection";
			this.vmethod_22().Size = new Size(121, 21);
			this.vmethod_22().TabIndex = 10;
			this.vmethod_24().method_2(true);
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().Location = new Point(351, 128);
			this.vmethod_24().Name = "Label5";
			this.vmethod_24().Size = new Size(40, 13);
			this.vmethod_24().TabIndex = 9;
			this.vmethod_24().Text = "points";
			this.vmethod_26().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_26().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_26().Font = new Font("Segoe UI", 8f);
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Location = new Point(280, 126);
			NumericUpDown numericUpDown = this.vmethod_26();
			int[] array = new int[4];
			array[0] = 999999;
			numericUpDown.Maximum = new decimal(array);
			this.vmethod_26().Minimum = new decimal(new int[]
			{
				999999,
				0,
				0,
				int.MinValue
			});
			this.vmethod_26().Name = "NUD_Points";
			this.vmethod_26().Size = new Size(65, 22);
			this.vmethod_26().TabIndex = 8;
			this.vmethod_28().BackColor = Color.Transparent;
			this.vmethod_28().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_28().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_28().Font = new Font("Segoe UI", 7f);
			this.vmethod_28().FormattingEnabled = true;
			this.vmethod_28().Location = new Point(153, 98);
			this.vmethod_28().Name = "CB_Points_Sides";
			this.vmethod_28().Size = new Size(192, 21);
			this.vmethod_28().TabIndex = 7;
			this.vmethod_30().method_2(true);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Location = new Point(8, 130);
			this.vmethod_30().Name = "Label4";
			this.vmethod_30().Size = new Size(146, 13);
			this.vmethod_30().TabIndex = 6;
			this.vmethod_30().Text = "Trigger activates when side";
			this.vmethod_32().method_2(true);
			this.vmethod_32().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_32().Location = new Point(116, 101);
			this.vmethod_32().Name = "Label1";
			this.vmethod_32().Size = new Size(32, 13);
			this.vmethod_32().TabIndex = 5;
			this.vmethod_32().Text = "Side:";
			this.vmethod_34().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_34().Controls.Add(this.vmethod_42());
			this.vmethod_34().Controls.Add(this.vmethod_40());
			this.vmethod_34().Controls.Add(this.vmethod_36());
			this.vmethod_34().Controls.Add(this.vmethod_38());
			this.vmethod_34().Location = new Point(4, 36);
			this.vmethod_34().Name = "TabPage4";
			this.vmethod_34().Padding = new Padding(3);
			this.vmethod_34().Size = new Size(744, 297);
			this.vmethod_34().TabIndex = 3;
			this.vmethod_34().Text = "Time";
			this.vmethod_42().BackColor = Color.Transparent;
			this.vmethod_42().DialogResult = DialogResult.None;
			this.vmethod_42().Font = new Font("Segoe UI", 10f);
			this.vmethod_42().ForeColor = SystemColors.Control;
			this.vmethod_42().Location = new Point(229, 139);
			this.vmethod_42().Name = "Button_SetTime";
			this.vmethod_42().method_1(0);
			this.vmethod_42().Size = new Size(75, 23);
			this.vmethod_42().TabIndex = 25;
			this.vmethod_42().Text = "Set Time";
			this.vmethod_40().method_2(true);
			this.vmethod_40().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_40().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_40().Location = new Point(158, 45);
			this.vmethod_40().Name = "Label6";
			this.vmethod_40().Size = new Size(41, 13);
			this.vmethod_40().TabIndex = 24;
			this.vmethod_40().Text = "Label6";
			this.vmethod_36().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_36().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_36().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_36().Location = new Point(161, 113);
			this.vmethod_36().Name = "DTP_StartTime";
			this.vmethod_36().Size = new Size(223, 22);
			this.vmethod_36().TabIndex = 23;
			this.vmethod_38().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_38().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_38().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_38().Location = new Point(161, 87);
			this.vmethod_38().Name = "DTP_StartDate";
			this.vmethod_38().Size = new Size(223, 22);
			this.vmethod_38().TabIndex = 22;
			this.vmethod_48().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_48().Controls.Add(this.vmethod_54());
			this.vmethod_48().Controls.Add(this.vmethod_52());
			this.vmethod_48().Controls.Add(this.vmethod_50());
			this.vmethod_48().Location = new Point(4, 36);
			this.vmethod_48().Name = "TabPage5";
			this.vmethod_48().Size = new Size(744, 297);
			this.vmethod_48().TabIndex = 4;
			this.vmethod_48().Text = "Unit Remains In Area";
			this.vmethod_54().Controls.Add(this.vmethod_66());
			this.vmethod_54().Controls.Add(this.vmethod_68());
			this.vmethod_54().Controls.Add(this.vmethod_70());
			this.vmethod_54().Controls.Add(this.vmethod_56());
			this.vmethod_54().Controls.Add(this.vmethod_58());
			this.vmethod_54().Controls.Add(this.vmethod_60());
			this.vmethod_54().Controls.Add(this.vmethod_62());
			this.vmethod_54().Controls.Add(this.vmethod_64());
			this.vmethod_54().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_54().Location = new Point(387, 15);
			this.vmethod_54().Name = "GroupBox1";
			this.vmethod_54().Size = new Size(163, 119);
			this.vmethod_54().TabIndex = 4;
			this.vmethod_54().TabStop = false;
			this.vmethod_54().Text = "Required Time Amount";
			this.vmethod_66().method_2(true);
			this.vmethod_66().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_66().Location = new Point(119, 78);
			this.vmethod_66().Name = "Label12";
			this.vmethod_66().Size = new Size(28, 13);
			this.vmethod_66().TabIndex = 27;
			this.vmethod_66().Text = "secs";
			this.vmethod_68().method_2(true);
			this.vmethod_68().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_68().Location = new Point(43, 78);
			this.vmethod_68().Name = "Label11";
			this.vmethod_68().Size = new Size(31, 13);
			this.vmethod_68().TabIndex = 26;
			this.vmethod_68().Text = "mins";
			this.vmethod_70().method_14(null);
			this.vmethod_70().method_15(AutoCompleteMode.None);
			this.vmethod_70().method_13(AutoCompleteSource.None);
			this.vmethod_70().BackColor = Color.Transparent;
			this.vmethod_70().method_17(new Font("Segoe UI", 10f));
			this.vmethod_70().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_70().method_12(null);
			this.vmethod_70().method_18(null);
			this.vmethod_70().Location = new Point(78, 75);
			this.vmethod_70().method_2(32767);
			this.vmethod_70().method_7(false);
			this.vmethod_70().Name = "TB_Secs";
			this.vmethod_70().method_3(false);
			this.vmethod_70().method_19(ScrollBars.None);
			this.vmethod_70().method_9(0);
			this.vmethod_70().Size = new Size(39, 20);
			this.vmethod_70().TabIndex = 25;
			this.vmethod_70().Text = "0";
			this.vmethod_70().method_1(HorizontalAlignment.Left);
			this.vmethod_70().method_5(false);
			this.vmethod_70().method_10("");
			this.vmethod_56().method_14(null);
			this.vmethod_56().method_15(AutoCompleteMode.None);
			this.vmethod_56().method_13(AutoCompleteSource.None);
			this.vmethod_56().BackColor = Color.Transparent;
			this.vmethod_56().method_17(new Font("Segoe UI", 10f));
			this.vmethod_56().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_56().method_12(null);
			this.vmethod_56().method_18(null);
			this.vmethod_56().Location = new Point(6, 75);
			this.vmethod_56().method_2(32767);
			this.vmethod_56().method_7(false);
			this.vmethod_56().Name = "TB_Mins";
			this.vmethod_56().method_3(false);
			this.vmethod_56().method_19(ScrollBars.None);
			this.vmethod_56().method_9(0);
			this.vmethod_56().Size = new Size(36, 20);
			this.vmethod_56().TabIndex = 24;
			this.vmethod_56().Text = "0";
			this.vmethod_56().method_1(HorizontalAlignment.Left);
			this.vmethod_56().method_5(false);
			this.vmethod_56().method_10("");
			this.vmethod_58().method_14(null);
			this.vmethod_58().method_15(AutoCompleteMode.None);
			this.vmethod_58().method_13(AutoCompleteSource.None);
			this.vmethod_58().BackColor = Color.Transparent;
			this.vmethod_58().method_17(new Font("Segoe UI", 10f));
			this.vmethod_58().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_58().method_12(null);
			this.vmethod_58().method_18(null);
			this.vmethod_58().Location = new Point(78, 35);
			this.vmethod_58().method_2(32767);
			this.vmethod_58().method_7(false);
			this.vmethod_58().Name = "TB_Hours";
			this.vmethod_58().method_3(false);
			this.vmethod_58().method_19(ScrollBars.None);
			this.vmethod_58().method_9(0);
			this.vmethod_58().Size = new Size(39, 20);
			this.vmethod_58().TabIndex = 22;
			this.vmethod_58().Text = "0";
			this.vmethod_58().method_1(HorizontalAlignment.Left);
			this.vmethod_58().method_5(false);
			this.vmethod_58().method_10("");
			this.vmethod_60().method_2(true);
			this.vmethod_60().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_60().Location = new Point(40, 39);
			this.vmethod_60().Name = "Label10";
			this.vmethod_60().Size = new Size(30, 13);
			this.vmethod_60().TabIndex = 19;
			this.vmethod_60().Text = "days";
			this.vmethod_62().method_14(null);
			this.vmethod_62().method_15(AutoCompleteMode.None);
			this.vmethod_62().method_13(AutoCompleteSource.None);
			this.vmethod_62().BackColor = Color.Transparent;
			this.vmethod_62().method_17(new Font("Segoe UI", 10f));
			this.vmethod_62().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_62().method_12(null);
			this.vmethod_62().method_18(null);
			this.vmethod_62().Location = new Point(7, 35);
			this.vmethod_62().method_2(32767);
			this.vmethod_62().method_7(false);
			this.vmethod_62().Name = "TB_Days";
			this.vmethod_62().method_3(false);
			this.vmethod_62().method_19(ScrollBars.None);
			this.vmethod_62().method_9(0);
			this.vmethod_62().Size = new Size(35, 20);
			this.vmethod_62().TabIndex = 20;
			this.vmethod_62().Text = "0";
			this.vmethod_62().method_1(HorizontalAlignment.Left);
			this.vmethod_62().method_5(false);
			this.vmethod_62().method_10("");
			this.vmethod_64().method_2(true);
			this.vmethod_64().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_64().Location = new Point(119, 39);
			this.vmethod_64().Name = "Label9";
			this.vmethod_64().Size = new Size(37, 13);
			this.vmethod_64().TabIndex = 21;
			this.vmethod_64().Text = "hours";
			this.vmethod_52().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_52().Location = new Point(387, 170);
			this.vmethod_52().Name = "AreaEditor_UnitInArea";
			this.vmethod_52().Size = new Size(351, 124);
			this.vmethod_52().TabIndex = 3;
			this.vmethod_52().method_1("Area To Be Inside");
			this.vmethod_50().BackColor = Color.Transparent;
			this.vmethod_50().method_2(null);
			this.vmethod_50().Location = new Point(6, 6);
			this.vmethod_50().MinimumSize = new Size(311, 177);
			this.vmethod_50().Name = "UnitFilter_UnitInArea";
			this.vmethod_50().Size = new Size(311, 177);
			this.vmethod_50().TabIndex = 2;
			this.vmethod_72().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_72().Controls.Add(this.vmethod_92());
			this.vmethod_72().Controls.Add(this.vmethod_94());
			this.vmethod_72().Controls.Add(this.vmethod_74());
			this.vmethod_72().Controls.Add(this.vmethod_80());
			this.vmethod_72().Controls.Add(this.vmethod_82());
			this.vmethod_72().Location = new Point(4, 36);
			this.vmethod_72().Name = "TabPage6";
			this.vmethod_72().Size = new Size(744, 297);
			this.vmethod_72().TabIndex = 5;
			this.vmethod_72().Text = "Unit Enters Area";
			this.vmethod_92().AutoSize = true;
			this.vmethod_92().Location = new Point(84, 200);
			this.vmethod_92().Name = "CB_UnitEntersArea_ModifierNOT";
			this.vmethod_92().Size = new Size(99, 17);
			this.vmethod_92().TabIndex = 8;
			this.vmethod_92().Text = "Modifier: NOT";
			this.vmethod_96().SetToolTip(this.vmethod_92(), "\"When checked, the trigger fires if an eligible unit is NOT in the specified area within the specified time frame");
			this.vmethod_94().AutoSize = true;
			this.vmethod_94().Location = new Point(84, 232);
			this.vmethod_94().Name = "CB_UnitEntersArea_ModifierEXIT";
			this.vmethod_94().Size = new Size(97, 17);
			this.vmethod_94().TabIndex = 9;
			this.vmethod_94().Text = "Modifier: EXIT";
			this.vmethod_96().SetToolTip(this.vmethod_94(), "\"When checked, the trigger fires if an eligible unit EXITs the specified area within the specified time frame");
			this.vmethod_74().Controls.Add(this.vmethod_88());
			this.vmethod_74().Controls.Add(this.vmethod_90());
			this.vmethod_74().Controls.Add(this.vmethod_98());
			this.vmethod_74().Controls.Add(this.vmethod_86());
			this.vmethod_74().Controls.Add(this.vmethod_84());
			this.vmethod_74().Controls.Add(this.vmethod_76());
			this.vmethod_74().Controls.Add(this.vmethod_78());
			this.vmethod_74().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_74().Location = new Point(323, 16);
			this.vmethod_74().Name = "GroupBox2";
			this.vmethod_74().Size = new Size(415, 130);
			this.vmethod_74().TabIndex = 7;
			this.vmethod_74().TabStop = false;
			this.vmethod_74().Text = "Earliest + Latest Time";
			this.vmethod_88().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_88().BackColor = Color.Transparent;
			this.vmethod_88().DialogResult = DialogResult.None;
			this.vmethod_88().Font = new Font("Segoe UI", 10f);
			this.vmethod_88().ForeColor = SystemColors.Control;
			this.vmethod_88().Location = new Point(148, 102);
			this.vmethod_88().Name = "Button_UnitEntersArea";
			this.vmethod_88().method_1(0);
			this.vmethod_88().Size = new Size(142, 22);
			this.vmethod_88().TabIndex = 32;
			this.vmethod_88().Text = "SET TIMES";
			this.vmethod_90().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_90().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_90().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_90().Location = new Point(301, 63);
			this.vmethod_90().Name = "DTP_EnterArea_LTOA_Time";
			this.vmethod_90().Size = new Size(93, 22);
			this.vmethod_90().TabIndex = 31;
			this.vmethod_98().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_98().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_98().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_98().Location = new Point(104, 63);
			this.vmethod_98().Name = "DTP_EnterArea_ETOA_Time";
			this.vmethod_98().Size = new Size(93, 22);
			this.vmethod_98().TabIndex = 30;
			this.vmethod_86().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_86().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_86().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_86().Location = new Point(203, 37);
			this.vmethod_86().Name = "DTP_EnterArea_LTOA_Date";
			this.vmethod_86().Size = new Size(191, 22);
			this.vmethod_86().TabIndex = 29;
			this.vmethod_84().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_84().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_84().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_84().Location = new Point(6, 37);
			this.vmethod_84().Name = "DTP_EnterArea_ETOA_Date";
			this.vmethod_84().Size = new Size(191, 22);
			this.vmethod_84().TabIndex = 28;
			this.vmethod_76().method_2(true);
			this.vmethod_76().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_76().Location = new Point(200, 21);
			this.vmethod_76().Name = "Label_UnitEntersArea_Latest";
			this.vmethod_76().Size = new Size(40, 13);
			this.vmethod_76().TabIndex = 27;
			this.vmethod_76().Text = "Latest:";
			this.vmethod_78().method_2(true);
			this.vmethod_78().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_78().Location = new Point(3, 21);
			this.vmethod_78().Name = "Label_UnitEntersArea_Earliest";
			this.vmethod_78().Size = new Size(47, 13);
			this.vmethod_78().TabIndex = 26;
			this.vmethod_78().Text = "Earliest:";
			this.vmethod_80().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_80().Location = new Point(387, 172);
			this.vmethod_80().Name = "AreaEditor_UnitEntersArea";
			this.vmethod_80().Size = new Size(351, 125);
			this.vmethod_80().TabIndex = 6;
			this.vmethod_80().method_1("Area To Be Inside");
			this.vmethod_82().BackColor = Color.Transparent;
			this.vmethod_82().method_2(null);
			this.vmethod_82().Location = new Point(6, 6);
			this.vmethod_82().MinimumSize = new Size(311, 177);
			this.vmethod_82().Name = "UnitFilter_UnitEntersArea";
			this.vmethod_82().Size = new Size(311, 177);
			this.vmethod_82().TabIndex = 5;
			this.vmethod_100().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_100().Controls.Add(this.vmethod_102());
			this.vmethod_100().Controls.Add(this.vmethod_104());
			this.vmethod_100().Controls.Add(this.vmethod_106());
			this.vmethod_100().Controls.Add(this.vmethod_108());
			this.vmethod_100().Controls.Add(this.vmethod_110());
			this.vmethod_100().Controls.Add(this.vmethod_112());
			this.vmethod_100().Controls.Add(this.vmethod_114());
			this.vmethod_100().Controls.Add(this.vmethod_116());
			this.vmethod_100().Location = new Point(4, 36);
			this.vmethod_100().Name = "TabPage7";
			this.vmethod_100().Padding = new Padding(3);
			this.vmethod_100().Size = new Size(744, 297);
			this.vmethod_100().TabIndex = 6;
			this.vmethod_100().Text = "Random Time";
			this.vmethod_102().method_2(true);
			this.vmethod_102().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_102().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_102().Location = new Point(169, 154);
			this.vmethod_102().Name = "Label14";
			this.vmethod_102().Size = new Size(41, 13);
			this.vmethod_102().TabIndex = 33;
			this.vmethod_102().Text = "Latest:";
			this.vmethod_104().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_104().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_104().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_104().Location = new Point(172, 196);
			this.vmethod_104().Name = "DTP_LatestTime";
			this.vmethod_104().Size = new Size(223, 22);
			this.vmethod_104().TabIndex = 32;
			this.vmethod_106().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_106().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_106().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_106().Location = new Point(172, 170);
			this.vmethod_106().Name = "DTP_LatestDate";
			this.vmethod_106().Size = new Size(223, 22);
			this.vmethod_106().TabIndex = 31;
			this.vmethod_108().method_2(true);
			this.vmethod_108().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_108().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_108().Location = new Point(169, 77);
			this.vmethod_108().Name = "Label13";
			this.vmethod_108().Size = new Size(47, 13);
			this.vmethod_108().TabIndex = 30;
			this.vmethod_108().Text = "Earliest:";
			this.vmethod_110().BackColor = Color.Transparent;
			this.vmethod_110().DialogResult = DialogResult.None;
			this.vmethod_110().Font = new Font("Segoe UI", 10f);
			this.vmethod_110().ForeColor = SystemColors.Control;
			this.vmethod_110().Location = new Point(221, 235);
			this.vmethod_110().Name = "Button1";
			this.vmethod_110().method_1(0);
			this.vmethod_110().Size = new Size(131, 23);
			this.vmethod_110().TabIndex = 29;
			this.vmethod_110().Text = "Set Random Time";
			this.vmethod_112().method_2(true);
			this.vmethod_112().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_112().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_112().Location = new Point(170, 23);
			this.vmethod_112().Name = "Label8";
			this.vmethod_112().Size = new Size(41, 13);
			this.vmethod_112().TabIndex = 28;
			this.vmethod_112().Text = "Label8";
			this.vmethod_114().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_114().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_114().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_114().Location = new Point(172, 119);
			this.vmethod_114().Name = "DTP_EarliestTime";
			this.vmethod_114().Size = new Size(223, 22);
			this.vmethod_114().TabIndex = 27;
			this.vmethod_116().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_116().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_116().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_116().Location = new Point(172, 93);
			this.vmethod_116().Name = "DTP_EarliestDate";
			this.vmethod_116().Size = new Size(223, 22);
			this.vmethod_116().TabIndex = 26;
			this.vmethod_118().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_118().Controls.Add(this.vmethod_136());
			this.vmethod_118().Controls.Add(this.vmethod_132());
			this.vmethod_118().Controls.Add(this.vmethod_134());
			this.vmethod_118().Controls.Add(this.vmethod_122());
			this.vmethod_118().Controls.Add(this.vmethod_124());
			this.vmethod_118().Controls.Add(this.vmethod_120());
			this.vmethod_118().Location = new Point(4, 36);
			this.vmethod_118().Name = "TabPage8";
			this.vmethod_118().Padding = new Padding(3);
			this.vmethod_118().Size = new Size(744, 297);
			this.vmethod_118().TabIndex = 7;
			this.vmethod_118().Text = "Unit is Detected";
			this.vmethod_136().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_136().Location = new Point(323, 169);
			this.vmethod_136().Name = "AreaEditor_DetectedArea";
			this.vmethod_136().Size = new Size(351, 125);
			this.vmethod_136().TabIndex = 12;
			this.vmethod_136().method_1("Area To Be Inside");
			this.vmethod_132().BackColor = Color.Transparent;
			this.vmethod_132().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_132().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_132().Font = new Font("Segoe UI", 7f);
			this.vmethod_132().FormattingEnabled = true;
			this.vmethod_132().Items.AddRange(new object[]
			{
				"Unknown",
				"Known Domain (e.g. ship, aircraft)",
				"Known Type (e.g. frigate, bomber)",
				"Known Class (e.g. F-16, Nimitz-class)",
				"Precise ID (e.g. Air Force One, USS Nimitz)"
			});
			this.vmethod_132().Location = new Point(477, 110);
			this.vmethod_132().Name = "CB_MCL";
			this.vmethod_132().Size = new Size(146, 21);
			this.vmethod_132().TabIndex = 11;
			this.vmethod_134().method_2(true);
			this.vmethod_134().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_134().Location = new Point(332, 113);
			this.vmethod_134().Name = "Label16";
			this.vmethod_134().Size = new Size(153, 13);
			this.vmethod_134().TabIndex = 10;
			this.vmethod_134().Text = "Minimum classification level:";
			this.vmethod_122().BackColor = Color.Transparent;
			this.vmethod_122().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_122().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_122().Font = new Font("Segoe UI", 7f);
			this.vmethod_122().FormattingEnabled = true;
			this.vmethod_122().Location = new Point(431, 83);
			this.vmethod_122().Name = "CB_UnitDetected_Sides";
			this.vmethod_122().Size = new Size(192, 21);
			this.vmethod_122().TabIndex = 9;
			this.vmethod_124().method_2(true);
			this.vmethod_124().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_124().Location = new Point(350, 86);
			this.vmethod_124().Name = "Label15";
			this.vmethod_124().Size = new Size(79, 13);
			this.vmethod_124().TabIndex = 8;
			this.vmethod_124().Text = "Detector Side:";
			this.vmethod_120().BackColor = Color.Transparent;
			this.vmethod_120().method_2(null);
			this.vmethod_120().Location = new Point(6, 6);
			this.vmethod_120().MinimumSize = new Size(311, 177);
			this.vmethod_120().Name = "UnitFilter_UnitDetected";
			this.vmethod_120().Size = new Size(311, 177);
			this.vmethod_120().TabIndex = 6;
			this.vmethod_126().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_126().Controls.Add(this.vmethod_128());
			this.vmethod_126().Controls.Add(this.vmethod_130());
			this.vmethod_126().Location = new Point(4, 36);
			this.vmethod_126().Name = "TabPage9";
			this.vmethod_126().Padding = new Padding(3);
			this.vmethod_126().Size = new Size(744, 297);
			this.vmethod_126().TabIndex = 8;
			this.vmethod_126().Text = "Regular Time";
			this.vmethod_128().BackColor = Color.Transparent;
			this.vmethod_128().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_128().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_128().Font = new Font("Segoe UI", 7f);
			this.vmethod_128().FormattingEnabled = true;
			this.vmethod_128().Items.AddRange(new object[]
			{
				"One Second",
				"Five Seconds",
				"Fifteen Seconds",
				"Thirty Seconds",
				"One Minute",
				"Five Minutes",
				"Fifteen Minutes",
				"Thirty Minutes",
				"One Hour",
				"Six Hours",
				"Twelve Hours",
				"Twenty Four Hours"
			});
			this.vmethod_128().Location = new Point(227, 98);
			this.vmethod_128().Name = "CB_RegularTimeInterval";
			this.vmethod_128().Size = new Size(155, 21);
			this.vmethod_128().TabIndex = 1;
			this.vmethod_130().method_2(true);
			this.vmethod_130().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_130().Location = new Point(115, 101);
			this.vmethod_130().Name = "Label17";
			this.vmethod_130().Size = new Size(116, 13);
			this.vmethod_130().TabIndex = 0;
			this.vmethod_130().Text = "Trigger will fire every:";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(747, 428);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditTrigger";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Edit event trigger";
			this.vmethod_10().ResumeLayout(false);
			this.vmethod_12().ResumeLayout(false);
			this.vmethod_16().ResumeLayout(false);
			this.vmethod_16().PerformLayout();
			((ISupportInitialize)this.vmethod_44()).EndInit();
			this.vmethod_18().ResumeLayout(false);
			this.vmethod_18().PerformLayout();
			((ISupportInitialize)this.vmethod_26()).EndInit();
			this.vmethod_34().ResumeLayout(false);
			this.vmethod_34().PerformLayout();
			this.vmethod_48().ResumeLayout(false);
			this.vmethod_54().ResumeLayout(false);
			this.vmethod_54().PerformLayout();
			this.vmethod_72().ResumeLayout(false);
			this.vmethod_72().PerformLayout();
			this.vmethod_74().ResumeLayout(false);
			this.vmethod_74().PerformLayout();
			this.vmethod_100().ResumeLayout(false);
			this.vmethod_100().PerformLayout();
			this.vmethod_118().ResumeLayout(false);
			this.vmethod_118().PerformLayout();
			this.vmethod_126().ResumeLayout(false);
			this.vmethod_126().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x0004B154 File Offset: 0x00049354
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x060079D3 RID: 31187 RVA: 0x0004B15C File Offset: 0x0004935C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_19)
		{
			this.class116_0 = class116_19;
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x0004B165 File Offset: 0x00049365
		[CompilerGenerated]
		internal Control8 vmethod_2()
		{
			return this.control8_0;
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x004266A4 File Offset: 0x004248A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control8 control8_5)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_5);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.method_22(delegate85_);
			}
			this.control8_0 = control8_5;
			control = this.control8_0;
			if (control != null)
			{
				control.method_21(delegate85_);
			}
		}

		// Token: 0x060079D6 RID: 31190 RVA: 0x0004B16D File Offset: 0x0004936D
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_0;
		}

		// Token: 0x060079D7 RID: 31191 RVA: 0x004266E8 File Offset: 0x004248E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_5)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_5;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060079D8 RID: 31192 RVA: 0x0004B175 File Offset: 0x00049375
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_1;
		}

		// Token: 0x060079D9 RID: 31193 RVA: 0x0042672C File Offset: 0x0042492C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_5)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_5;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060079DA RID: 31194 RVA: 0x0004B17D File Offset: 0x0004937D
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_1;
		}

		// Token: 0x060079DB RID: 31195 RVA: 0x0004B185 File Offset: 0x00049385
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_19)
		{
			this.class116_1 = class116_19;
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x0004B18E File Offset: 0x0004938E
		[CompilerGenerated]
		internal TabPage vmethod_10()
		{
			return this.tabPage_0;
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x0004B196 File Offset: 0x00049396
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TabPage tabPage_9)
		{
			this.tabPage_0 = tabPage_9;
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x0004B19F File Offset: 0x0004939F
		[CompilerGenerated]
		internal Control12 vmethod_12()
		{
			return this.control12_0;
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x0004B1A7 File Offset: 0x000493A7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control12 control12_1)
		{
			this.control12_0 = control12_1;
		}

		// Token: 0x060079E0 RID: 31200 RVA: 0x0004B1B0 File Offset: 0x000493B0
		[CompilerGenerated]
		internal UnitFilter vmethod_14()
		{
			return this.unitFilter_0;
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x0004B1B8 File Offset: 0x000493B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(UnitFilter unitFilter_5)
		{
			this.unitFilter_0 = unitFilter_5;
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x0004B1C1 File Offset: 0x000493C1
		[CompilerGenerated]
		internal TabPage vmethod_16()
		{
			return this.tabPage_1;
		}

		// Token: 0x060079E3 RID: 31203 RVA: 0x0004B1C9 File Offset: 0x000493C9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(TabPage tabPage_9)
		{
			this.tabPage_1 = tabPage_9;
		}

		// Token: 0x060079E4 RID: 31204 RVA: 0x0004B1D2 File Offset: 0x000493D2
		[CompilerGenerated]
		internal TabPage vmethod_18()
		{
			return this.tabPage_2;
		}

		// Token: 0x060079E5 RID: 31205 RVA: 0x0004B1DA File Offset: 0x000493DA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(TabPage tabPage_9)
		{
			this.tabPage_2 = tabPage_9;
		}

		// Token: 0x060079E6 RID: 31206 RVA: 0x0004B1E3 File Offset: 0x000493E3
		[CompilerGenerated]
		internal UnitFilter vmethod_20()
		{
			return this.unitFilter_1;
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x0004B1EB File Offset: 0x000493EB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(UnitFilter unitFilter_5)
		{
			this.unitFilter_1 = unitFilter_5;
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x0004B1F4 File Offset: 0x000493F4
		[CompilerGenerated]
		internal Class2451 vmethod_22()
		{
			return this.class2451_0;
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x00426770 File Offset: 0x00424970
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class2451 class2451_5)
		{
			EventHandler value = new EventHandler(this.method_7);
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

		// Token: 0x060079EA RID: 31210 RVA: 0x0004B1FC File Offset: 0x000493FC
		[CompilerGenerated]
		internal Class116 vmethod_24()
		{
			return this.class116_2;
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x0004B204 File Offset: 0x00049404
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class116 class116_19)
		{
			this.class116_2 = class116_19;
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x0004B20D File Offset: 0x0004940D
		[CompilerGenerated]
		internal Class120 vmethod_26()
		{
			return this.class120_0;
		}

		// Token: 0x060079ED RID: 31213 RVA: 0x004267B4 File Offset: 0x004249B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class120 class120_2)
		{
			EventHandler value = new EventHandler(this.method_8);
			Class120 @class = this.class120_0;
			if (@class != null)
			{
				@class.TextChanged -= value;
			}
			this.class120_0 = class120_2;
			@class = this.class120_0;
			if (@class != null)
			{
				@class.TextChanged += value;
			}
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x0004B215 File Offset: 0x00049415
		[CompilerGenerated]
		internal Class2451 vmethod_28()
		{
			return this.class2451_1;
		}

		// Token: 0x060079EF RID: 31215 RVA: 0x004267F8 File Offset: 0x004249F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class2451 class2451_5)
		{
			EventHandler value = new EventHandler(this.method_6);
			Class2451 @class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectedIndexChanged -= value;
			}
			this.class2451_1 = class2451_5;
			@class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x0004B21D File Offset: 0x0004941D
		[CompilerGenerated]
		internal Class116 vmethod_30()
		{
			return this.class116_3;
		}

		// Token: 0x060079F1 RID: 31217 RVA: 0x0004B225 File Offset: 0x00049425
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class116 class116_19)
		{
			this.class116_3 = class116_19;
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x0004B22E File Offset: 0x0004942E
		[CompilerGenerated]
		internal Class116 vmethod_32()
		{
			return this.class116_4;
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x0004B236 File Offset: 0x00049436
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class116 class116_19)
		{
			this.class116_4 = class116_19;
		}

		// Token: 0x060079F4 RID: 31220 RVA: 0x0004B23F File Offset: 0x0004943F
		[CompilerGenerated]
		internal TabPage vmethod_34()
		{
			return this.tabPage_3;
		}

		// Token: 0x060079F5 RID: 31221 RVA: 0x0004B247 File Offset: 0x00049447
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(TabPage tabPage_9)
		{
			this.tabPage_3 = tabPage_9;
		}

		// Token: 0x060079F6 RID: 31222 RVA: 0x0004B250 File Offset: 0x00049450
		[CompilerGenerated]
		internal Class118 vmethod_36()
		{
			return this.class118_0;
		}

		// Token: 0x060079F7 RID: 31223 RVA: 0x0004B258 File Offset: 0x00049458
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class118 class118_10)
		{
			this.class118_0 = class118_10;
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x0004B261 File Offset: 0x00049461
		[CompilerGenerated]
		internal Class118 vmethod_38()
		{
			return this.class118_1;
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x0004B269 File Offset: 0x00049469
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Class118 class118_10)
		{
			this.class118_1 = class118_10;
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x0004B272 File Offset: 0x00049472
		[CompilerGenerated]
		internal Class116 vmethod_40()
		{
			return this.class116_5;
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x0004B27A File Offset: 0x0004947A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Class116 class116_19)
		{
			this.class116_5 = class116_19;
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x0004B283 File Offset: 0x00049483
		[CompilerGenerated]
		internal Control9 vmethod_42()
		{
			return this.control9_2;
		}

		// Token: 0x060079FD RID: 31229 RVA: 0x0042683C File Offset: 0x00424A3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Control9 control9_5)
		{
			EventHandler value = new EventHandler(this.method_9);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_5;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060079FE RID: 31230 RVA: 0x0004B28B File Offset: 0x0004948B
		[CompilerGenerated]
		internal Class120 vmethod_44()
		{
			return this.class120_1;
		}

		// Token: 0x060079FF RID: 31231 RVA: 0x00426880 File Offset: 0x00424A80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Class120 class120_2)
		{
			EventHandler value = new EventHandler(this.method_10);
			Class120 @class = this.class120_1;
			if (@class != null)
			{
				@class.TextChanged -= value;
			}
			this.class120_1 = class120_2;
			@class = this.class120_1;
			if (@class != null)
			{
				@class.TextChanged += value;
			}
		}

		// Token: 0x06007A00 RID: 31232 RVA: 0x0004B293 File Offset: 0x00049493
		[CompilerGenerated]
		internal Class116 vmethod_46()
		{
			return this.class116_6;
		}

		// Token: 0x06007A01 RID: 31233 RVA: 0x0004B29B File Offset: 0x0004949B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Class116 class116_19)
		{
			this.class116_6 = class116_19;
		}

		// Token: 0x06007A02 RID: 31234 RVA: 0x0004B2A4 File Offset: 0x000494A4
		[CompilerGenerated]
		internal TabPage vmethod_48()
		{
			return this.tabPage_4;
		}

		// Token: 0x06007A03 RID: 31235 RVA: 0x0004B2AC File Offset: 0x000494AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(TabPage tabPage_9)
		{
			this.tabPage_4 = tabPage_9;
		}

		// Token: 0x06007A04 RID: 31236 RVA: 0x0004B2B5 File Offset: 0x000494B5
		[CompilerGenerated]
		internal UnitFilter vmethod_50()
		{
			return this.unitFilter_2;
		}

		// Token: 0x06007A05 RID: 31237 RVA: 0x0004B2BD File Offset: 0x000494BD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(UnitFilter unitFilter_5)
		{
			this.unitFilter_2 = unitFilter_5;
		}

		// Token: 0x06007A06 RID: 31238 RVA: 0x0004B2C6 File Offset: 0x000494C6
		[CompilerGenerated]
		internal AreaEditor vmethod_52()
		{
			return this.areaEditor_0;
		}

		// Token: 0x06007A07 RID: 31239 RVA: 0x0004B2CE File Offset: 0x000494CE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(AreaEditor areaEditor_3)
		{
			this.areaEditor_0 = areaEditor_3;
		}

		// Token: 0x06007A08 RID: 31240 RVA: 0x0004B2D7 File Offset: 0x000494D7
		[CompilerGenerated]
		internal Class115 vmethod_54()
		{
			return this.class115_0;
		}

		// Token: 0x06007A09 RID: 31241 RVA: 0x0004B2DF File Offset: 0x000494DF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Class115 class115_2)
		{
			this.class115_0 = class115_2;
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x0004B2E8 File Offset: 0x000494E8
		[CompilerGenerated]
		internal Control8 vmethod_56()
		{
			return this.control8_1;
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x0004B2F0 File Offset: 0x000494F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(Control8 control8_5)
		{
			this.control8_1 = control8_5;
		}

		// Token: 0x06007A0C RID: 31244 RVA: 0x0004B2F9 File Offset: 0x000494F9
		[CompilerGenerated]
		internal Control8 vmethod_58()
		{
			return this.control8_2;
		}

		// Token: 0x06007A0D RID: 31245 RVA: 0x0004B301 File Offset: 0x00049501
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(Control8 control8_5)
		{
			this.control8_2 = control8_5;
		}

		// Token: 0x06007A0E RID: 31246 RVA: 0x0004B30A File Offset: 0x0004950A
		[CompilerGenerated]
		internal Class116 vmethod_60()
		{
			return this.class116_7;
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x0004B312 File Offset: 0x00049512
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(Class116 class116_19)
		{
			this.class116_7 = class116_19;
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x0004B31B File Offset: 0x0004951B
		[CompilerGenerated]
		internal Control8 vmethod_62()
		{
			return this.control8_3;
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x0004B323 File Offset: 0x00049523
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(Control8 control8_5)
		{
			this.control8_3 = control8_5;
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x0004B32C File Offset: 0x0004952C
		[CompilerGenerated]
		internal Class116 vmethod_64()
		{
			return this.class116_8;
		}

		// Token: 0x06007A13 RID: 31251 RVA: 0x0004B334 File Offset: 0x00049534
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Class116 class116_19)
		{
			this.class116_8 = class116_19;
		}

		// Token: 0x06007A14 RID: 31252 RVA: 0x0004B33D File Offset: 0x0004953D
		[CompilerGenerated]
		internal Class116 vmethod_66()
		{
			return this.class116_9;
		}

		// Token: 0x06007A15 RID: 31253 RVA: 0x0004B345 File Offset: 0x00049545
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(Class116 class116_19)
		{
			this.class116_9 = class116_19;
		}

		// Token: 0x06007A16 RID: 31254 RVA: 0x0004B34E File Offset: 0x0004954E
		[CompilerGenerated]
		internal Class116 vmethod_68()
		{
			return this.class116_10;
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x0004B356 File Offset: 0x00049556
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(Class116 class116_19)
		{
			this.class116_10 = class116_19;
		}

		// Token: 0x06007A18 RID: 31256 RVA: 0x0004B35F File Offset: 0x0004955F
		[CompilerGenerated]
		internal Control8 vmethod_70()
		{
			return this.control8_4;
		}

		// Token: 0x06007A19 RID: 31257 RVA: 0x0004B367 File Offset: 0x00049567
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(Control8 control8_5)
		{
			this.control8_4 = control8_5;
		}

		// Token: 0x06007A1A RID: 31258 RVA: 0x0004B370 File Offset: 0x00049570
		[CompilerGenerated]
		internal TabPage vmethod_72()
		{
			return this.tabPage_5;
		}

		// Token: 0x06007A1B RID: 31259 RVA: 0x0004B378 File Offset: 0x00049578
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(TabPage tabPage_9)
		{
			this.tabPage_5 = tabPage_9;
		}

		// Token: 0x06007A1C RID: 31260 RVA: 0x0004B381 File Offset: 0x00049581
		[CompilerGenerated]
		internal Class115 vmethod_74()
		{
			return this.class115_1;
		}

		// Token: 0x06007A1D RID: 31261 RVA: 0x0004B389 File Offset: 0x00049589
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(Class115 class115_2)
		{
			this.class115_1 = class115_2;
		}

		// Token: 0x06007A1E RID: 31262 RVA: 0x0004B392 File Offset: 0x00049592
		[CompilerGenerated]
		internal Class116 vmethod_76()
		{
			return this.class116_11;
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x0004B39A File Offset: 0x0004959A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Class116 class116_19)
		{
			this.class116_11 = class116_19;
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x0004B3A3 File Offset: 0x000495A3
		[CompilerGenerated]
		internal Class116 vmethod_78()
		{
			return this.class116_12;
		}

		// Token: 0x06007A21 RID: 31265 RVA: 0x0004B3AB File Offset: 0x000495AB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(Class116 class116_19)
		{
			this.class116_12 = class116_19;
		}

		// Token: 0x06007A22 RID: 31266 RVA: 0x0004B3B4 File Offset: 0x000495B4
		[CompilerGenerated]
		internal AreaEditor vmethod_80()
		{
			return this.areaEditor_1;
		}

		// Token: 0x06007A23 RID: 31267 RVA: 0x0004B3BC File Offset: 0x000495BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(AreaEditor areaEditor_3)
		{
			this.areaEditor_1 = areaEditor_3;
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x0004B3C5 File Offset: 0x000495C5
		[CompilerGenerated]
		internal UnitFilter vmethod_82()
		{
			return this.unitFilter_3;
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x0004B3CD File Offset: 0x000495CD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(UnitFilter unitFilter_5)
		{
			this.unitFilter_3 = unitFilter_5;
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x0004B3D6 File Offset: 0x000495D6
		[CompilerGenerated]
		internal Class118 vmethod_84()
		{
			return this.class118_2;
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x0004B3DE File Offset: 0x000495DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(Class118 class118_10)
		{
			this.class118_2 = class118_10;
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x0004B3E7 File Offset: 0x000495E7
		[CompilerGenerated]
		internal Class118 vmethod_86()
		{
			return this.class118_3;
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x0004B3EF File Offset: 0x000495EF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(Class118 class118_10)
		{
			this.class118_3 = class118_10;
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x0004B3F8 File Offset: 0x000495F8
		[CompilerGenerated]
		internal Control9 vmethod_88()
		{
			return this.control9_3;
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x004268C4 File Offset: 0x00424AC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(Control9 control9_5)
		{
			EventHandler value = new EventHandler(this.method_17);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_5;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x0004B400 File Offset: 0x00049600
		[CompilerGenerated]
		internal Class118 vmethod_90()
		{
			return this.class118_4;
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x0004B408 File Offset: 0x00049608
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(Class118 class118_10)
		{
			this.class118_4 = class118_10;
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x0004B411 File Offset: 0x00049611
		[CompilerGenerated]
		internal Class112 vmethod_92()
		{
			return this.class112_0;
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x0004B419 File Offset: 0x00049619
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(Class112 class112_2)
		{
			this.class112_0 = class112_2;
		}

		// Token: 0x06007A30 RID: 31280 RVA: 0x0004B422 File Offset: 0x00049622
		[CompilerGenerated]
		internal Class112 vmethod_94()
		{
			return this.class112_1;
		}

		// Token: 0x06007A31 RID: 31281 RVA: 0x0004B42A File Offset: 0x0004962A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(Class112 class112_2)
		{
			this.class112_1 = class112_2;
		}

		// Token: 0x06007A32 RID: 31282 RVA: 0x0004B433 File Offset: 0x00049633
		[CompilerGenerated]
		internal System.Windows.Forms.ToolTip vmethod_96()
		{
			return this.toolTip_0;
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x0004B43B File Offset: 0x0004963B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(System.Windows.Forms.ToolTip toolTip_1)
		{
			this.toolTip_0 = toolTip_1;
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x0004B444 File Offset: 0x00049644
		[CompilerGenerated]
		internal Class118 vmethod_98()
		{
			return this.class118_5;
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x0004B44C File Offset: 0x0004964C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_99(Class118 class118_10)
		{
			this.class118_5 = class118_10;
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x0004B455 File Offset: 0x00049655
		[CompilerGenerated]
		internal TabPage vmethod_100()
		{
			return this.tabPage_6;
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x0004B45D File Offset: 0x0004965D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_101(TabPage tabPage_9)
		{
			this.tabPage_6 = tabPage_9;
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x0004B466 File Offset: 0x00049666
		[CompilerGenerated]
		internal Class116 vmethod_102()
		{
			return this.class116_13;
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x0004B46E File Offset: 0x0004966E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_103(Class116 class116_19)
		{
			this.class116_13 = class116_19;
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x0004B477 File Offset: 0x00049677
		[CompilerGenerated]
		internal Class118 vmethod_104()
		{
			return this.class118_6;
		}

		// Token: 0x06007A3B RID: 31291 RVA: 0x0004B47F File Offset: 0x0004967F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_105(Class118 class118_10)
		{
			this.class118_6 = class118_10;
		}

		// Token: 0x06007A3C RID: 31292 RVA: 0x0004B488 File Offset: 0x00049688
		[CompilerGenerated]
		internal Class118 vmethod_106()
		{
			return this.class118_7;
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x0004B490 File Offset: 0x00049690
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_107(Class118 class118_10)
		{
			this.class118_7 = class118_10;
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x0004B499 File Offset: 0x00049699
		[CompilerGenerated]
		internal Class116 vmethod_108()
		{
			return this.class116_14;
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x0004B4A1 File Offset: 0x000496A1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_109(Class116 class116_19)
		{
			this.class116_14 = class116_19;
		}

		// Token: 0x06007A40 RID: 31296 RVA: 0x0004B4AA File Offset: 0x000496AA
		[CompilerGenerated]
		internal Control9 vmethod_110()
		{
			return this.control9_4;
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x00426908 File Offset: 0x00424B08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_111(Control9 control9_5)
		{
			EventHandler value = new EventHandler(this.method_18);
			Control9 control = this.control9_4;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_4 = control9_5;
			control = this.control9_4;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x0004B4B2 File Offset: 0x000496B2
		[CompilerGenerated]
		internal Class116 vmethod_112()
		{
			return this.class116_15;
		}

		// Token: 0x06007A43 RID: 31299 RVA: 0x0004B4BA File Offset: 0x000496BA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_113(Class116 class116_19)
		{
			this.class116_15 = class116_19;
		}

		// Token: 0x06007A44 RID: 31300 RVA: 0x0004B4C3 File Offset: 0x000496C3
		[CompilerGenerated]
		internal Class118 vmethod_114()
		{
			return this.class118_8;
		}

		// Token: 0x06007A45 RID: 31301 RVA: 0x0004B4CB File Offset: 0x000496CB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_115(Class118 class118_10)
		{
			this.class118_8 = class118_10;
		}

		// Token: 0x06007A46 RID: 31302 RVA: 0x0004B4D4 File Offset: 0x000496D4
		[CompilerGenerated]
		internal Class118 vmethod_116()
		{
			return this.class118_9;
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x0004B4DC File Offset: 0x000496DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_117(Class118 class118_10)
		{
			this.class118_9 = class118_10;
		}

		// Token: 0x06007A48 RID: 31304 RVA: 0x0004B4E5 File Offset: 0x000496E5
		[CompilerGenerated]
		internal TabPage vmethod_118()
		{
			return this.tabPage_7;
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x0004B4ED File Offset: 0x000496ED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_119(TabPage tabPage_9)
		{
			this.tabPage_7 = tabPage_9;
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x0004B4F6 File Offset: 0x000496F6
		[CompilerGenerated]
		internal UnitFilter vmethod_120()
		{
			return this.unitFilter_4;
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x0004B4FE File Offset: 0x000496FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_121(UnitFilter unitFilter_5)
		{
			this.unitFilter_4 = unitFilter_5;
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x0004B507 File Offset: 0x00049707
		[CompilerGenerated]
		internal Class2451 vmethod_122()
		{
			return this.class2451_2;
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x0042694C File Offset: 0x00424B4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_123(Class2451 class2451_5)
		{
			EventHandler value = new EventHandler(this.method_19);
			Class2451 @class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectedIndexChanged -= value;
			}
			this.class2451_2 = class2451_5;
			@class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x0004B50F File Offset: 0x0004970F
		[CompilerGenerated]
		internal Class116 vmethod_124()
		{
			return this.class116_16;
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x0004B517 File Offset: 0x00049717
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_125(Class116 class116_19)
		{
			this.class116_16 = class116_19;
		}

		// Token: 0x06007A50 RID: 31312 RVA: 0x0004B520 File Offset: 0x00049720
		[CompilerGenerated]
		internal TabPage vmethod_126()
		{
			return this.tabPage_8;
		}

		// Token: 0x06007A51 RID: 31313 RVA: 0x0004B528 File Offset: 0x00049728
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_127(TabPage tabPage_9)
		{
			this.tabPage_8 = tabPage_9;
		}

		// Token: 0x06007A52 RID: 31314 RVA: 0x0004B531 File Offset: 0x00049731
		[CompilerGenerated]
		internal Class2451 vmethod_128()
		{
			return this.class2451_3;
		}

		// Token: 0x06007A53 RID: 31315 RVA: 0x00426990 File Offset: 0x00424B90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_129(Class2451 class2451_5)
		{
			EventHandler value = new EventHandler(this.method_21);
			EventHandler value2 = new EventHandler(this.method_22);
			Class2451 @class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
				@class.SelectedIndexChanged -= value2;
			}
			this.class2451_3 = class2451_5;
			@class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
				@class.SelectedIndexChanged += value2;
			}
		}

		// Token: 0x06007A54 RID: 31316 RVA: 0x0004B539 File Offset: 0x00049739
		[CompilerGenerated]
		internal Class116 vmethod_130()
		{
			return this.class116_17;
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x0004B541 File Offset: 0x00049741
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_131(Class116 class116_19)
		{
			this.class116_17 = class116_19;
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x0004B54A File Offset: 0x0004974A
		[CompilerGenerated]
		internal Class2451 vmethod_132()
		{
			return this.class2451_4;
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x004269F0 File Offset: 0x00424BF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_133(Class2451 class2451_5)
		{
			EventHandler value = new EventHandler(this.method_20);
			Class2451 @class = this.class2451_4;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_4 = class2451_5;
			@class = this.class2451_4;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x0004B552 File Offset: 0x00049752
		[CompilerGenerated]
		internal Class116 vmethod_134()
		{
			return this.class116_18;
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x0004B55A File Offset: 0x0004975A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_135(Class116 class116_19)
		{
			this.class116_18 = class116_19;
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x0004B563 File Offset: 0x00049763
		[CompilerGenerated]
		internal AreaEditor vmethod_136()
		{
			return this.areaEditor_2;
		}

		// Token: 0x06007A5B RID: 31323 RVA: 0x0004B56B File Offset: 0x0004976B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_137(AreaEditor areaEditor_3)
		{
			this.areaEditor_2 = areaEditor_3;
		}

		// Token: 0x06007A5C RID: 31324 RVA: 0x0004B574 File Offset: 0x00049774
		private void EditTrigger_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_36().method_3();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06007A5D RID: 31325 RVA: 0x00426A34 File Offset: 0x00424C34
		private void EditTrigger_Load(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.eventTrigger_0))
			{
				base.Close();
			}
			this.vmethod_2().Text = this.eventTrigger_0.string_2;
			this.vmethod_4().Visible = (this.enum207_0 == EditTrigger.Enum207.const_0);
			this.vmethod_6().Visible = this.vmethod_4().Visible;
			switch (this.eventTrigger_0.eventTriggerType_0)
			{
			case EventTrigger.EventTriggerType.UnitDestroyed:
				this.vmethod_12().SelectedIndex = 0;
				this.vmethod_12().TabPages[0].Enabled = true;
				this.vmethod_14().method_2(((Class337)this.eventTrigger_0).class349_0);
				break;
			case EventTrigger.EventTriggerType.Points:
				this.vmethod_12().SelectedIndex = 2;
				this.vmethod_12().TabPages[2].Enabled = true;
				this.vmethod_28().Items.Clear();
				this.vmethod_28().DisplayMember = "Content";
				foreach (Side side in Client.smethod_46().method_44())
				{
					ComboBoxItem comboBoxItem = new ComboBoxItem();
					comboBoxItem.Content = side.method_51();
					comboBoxItem.Tag = side.string_0;
					this.vmethod_28().Items.Add(comboBoxItem);
				}
				try
				{
					foreach (object obj in this.vmethod_28().Items)
					{
						ComboBoxItem comboBoxItem2 = (ComboBoxItem)obj;
						if (Operators.CompareString(Conversions.ToString(comboBoxItem2.Tag), ((Class334)this.eventTrigger_0).string_3, false) == 0)
						{
							this.vmethod_28().SelectedItem = comboBoxItem2;
							break;
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
				this.vmethod_22().SelectedIndex = (int)((Class334)this.eventTrigger_0).enum48_0;
				this.vmethod_26().Value = new decimal(((Class334)this.eventTrigger_0).int_0);
				break;
			case EventTrigger.EventTriggerType.Time:
			{
				this.vmethod_12().SelectedIndex = 3;
				this.vmethod_12().TabPages[3].Enabled = true;
				DateTime dateTime_ = ((Class335)this.eventTrigger_0).dateTime_0;
				this.vmethod_40().Text = "Currently set: " + dateTime_.ToShortDateString() + " - " + dateTime_.ToShortTimeString();
				string text = "";
				string text2 = "";
				GameGeneral.smethod_47(ref dateTime_, ref text);
				GameGeneral.smethod_48(ref dateTime_, ref text2, true);
				this.vmethod_38().Text = text2;
				this.vmethod_36().Text = text;
				break;
			}
			case EventTrigger.EventTriggerType.UnitDamaged:
				this.vmethod_12().SelectedIndex = 1;
				this.vmethod_12().TabPages[1].Enabled = true;
				this.vmethod_20().method_2(((Class336)this.eventTrigger_0).class349_0);
				this.vmethod_44().Value = new decimal((int)((Class336)this.eventTrigger_0).byte_0);
				break;
			case EventTrigger.EventTriggerType.UnitRemainsInArea:
			{
				this.vmethod_12().SelectedIndex = 4;
				this.vmethod_12().TabPages[4].Enabled = true;
				this.vmethod_50().method_2(((Class333)this.eventTrigger_0).class349_0);
				this.vmethod_52().list_0 = ((Class333)this.eventTrigger_0).list_0;
				this.vmethod_52().imethod_0();
				TimeSpan timeSpan = TimeSpan.FromSeconds((double)((Class333)this.eventTrigger_0).long_0);
				this.vmethod_62().Text = Conversions.ToString(timeSpan.Days);
				this.vmethod_58().Text = Conversions.ToString(timeSpan.Hours);
				this.vmethod_56().Text = Conversions.ToString(timeSpan.Minutes);
				this.vmethod_70().Text = Conversions.ToString(timeSpan.Seconds);
				this.vmethod_62().method_21(new Control8.Delegate85(this.method_11));
				this.vmethod_58().method_21(new Control8.Delegate85(this.method_12));
				this.vmethod_56().method_21(new Control8.Delegate85(this.method_13));
				this.vmethod_70().method_21(new Control8.Delegate85(this.method_14));
				break;
			}
			case EventTrigger.EventTriggerType.UnitEntersArea:
			{
				this.vmethod_12().SelectedIndex = 5;
				this.vmethod_12().TabPages[5].Enabled = true;
				this.vmethod_82().method_2(((Class332)this.eventTrigger_0).class349_0);
				this.vmethod_80().list_0 = ((Class332)this.eventTrigger_0).list_0;
				this.vmethod_80().imethod_0();
				DateTime dateTime_2 = ((Class332)this.eventTrigger_0).dateTime_0;
				DateTime dateTime_3 = ((Class332)this.eventTrigger_0).dateTime_1;
				string text3;
				GameGeneral.smethod_47(ref dateTime_2, ref text3);
				string text4;
				GameGeneral.smethod_48(ref dateTime_2, ref text4, true);
				this.vmethod_84().Text = text4;
				this.vmethod_98().Text = text3;
				string text5;
				GameGeneral.smethod_47(ref dateTime_3, ref text5);
				string text6;
				GameGeneral.smethod_48(ref dateTime_3, ref text6, true);
				this.vmethod_86().Text = text6;
				this.vmethod_90().Text = text5;
				this.vmethod_78().Text = "Earliest: " + dateTime_2.ToShortDateString() + " - " + dateTime_2.ToShortTimeString();
				this.vmethod_76().Text = "Latest: " + dateTime_3.ToShortDateString() + " - " + dateTime_3.ToShortTimeString();
				this.vmethod_92().Checked = ((Class332)this.eventTrigger_0).bool_11;
				this.vmethod_92().CheckedChanged += this.method_15;
				this.vmethod_94().Checked = ((Class332)this.eventTrigger_0).bool_12;
				this.vmethod_94().CheckedChanged += this.method_16;
				break;
			}
			case EventTrigger.EventTriggerType.RandomTime:
			{
				this.vmethod_12().SelectedIndex = 6;
				this.vmethod_12().TabPages[6].Enabled = true;
				DateTime dateTime_4 = ((Class327)this.eventTrigger_0).dateTime_0;
				DateTime dateTime_5 = ((Class327)this.eventTrigger_0).dateTime_1;
				this.vmethod_112().Text = string.Concat(new string[]
				{
					"Currently set: \r\nEarliest: ",
					dateTime_4.ToShortDateString(),
					" - ",
					dateTime_4.ToShortTimeString(),
					"\r\nLatest: ",
					dateTime_5.ToShortDateString(),
					" - ",
					dateTime_5.ToShortTimeString()
				});
				string text7;
				GameGeneral.smethod_47(ref dateTime_4, ref text7);
				string text8;
				GameGeneral.smethod_48(ref dateTime_4, ref text8, true);
				this.vmethod_116().Text = text8;
				this.vmethod_114().Text = text7;
				string text9;
				GameGeneral.smethod_47(ref dateTime_5, ref text9);
				string text10;
				GameGeneral.smethod_48(ref dateTime_5, ref text10, true);
				this.vmethod_106().Text = text10;
				this.vmethod_104().Text = text9;
				break;
			}
			case EventTrigger.EventTriggerType.UnitDetected:
				this.vmethod_12().SelectedIndex = 7;
				this.vmethod_12().TabPages[7].Enabled = true;
				this.vmethod_122().Items.Clear();
				this.vmethod_122().DisplayMember = "Content";
				foreach (Side side2 in Client.smethod_46().method_44())
				{
					ComboBoxItem comboBoxItem3 = new ComboBoxItem();
					comboBoxItem3.Content = side2.method_51();
					comboBoxItem3.Tag = side2.string_0;
					this.vmethod_122().Items.Add(comboBoxItem3);
				}
				try
				{
					foreach (object obj2 in this.vmethod_122().Items)
					{
						ComboBoxItem comboBoxItem4 = (ComboBoxItem)obj2;
						if (Operators.CompareString(Conversions.ToString(comboBoxItem4.Tag), ((Class329)this.eventTrigger_0).string_3, false) == 0)
						{
							this.vmethod_122().SelectedItem = comboBoxItem4;
							break;
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
				this.vmethod_120().method_2(((Class329)this.eventTrigger_0).class349_0);
				this.vmethod_136().list_0 = ((Class329)this.eventTrigger_0).list_0;
				this.vmethod_136().imethod_0();
				this.vmethod_132().SelectedIndex = (int)((Class329)this.eventTrigger_0).identificationStatus_0;
				break;
			case EventTrigger.EventTriggerType.RegularTime:
				this.vmethod_12().SelectedIndex = 8;
				this.vmethod_12().TabPages[8].Enabled = true;
				this.vmethod_128().SelectedIndex = (int)((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0;
				break;
			}
			this.vmethod_12().method_0();
		}

		// Token: 0x06007A5E RID: 31326 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06007A5F RID: 31327 RVA: 0x00427314 File Offset: 0x00425514
		private void method_4(object sender, EventArgs e)
		{
			EditTrigger.Enum207 @enum = this.enum207_0;
			if (@enum != EditTrigger.Enum207.const_0)
			{
				if (@enum != EditTrigger.Enum207.const_1)
				{
				}
			}
			else
			{
				Client.smethod_46().vmethod_4().Add(this.eventTrigger_0.string_0, this.eventTrigger_0);
			}
			base.Close();
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x0004B594 File Offset: 0x00049794
		private void method_5(object object_0)
		{
			this.eventTrigger_0.string_2 = this.vmethod_2().Text;
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x0004B5AC File Offset: 0x000497AC
		private void method_6(object sender, EventArgs e)
		{
			((Class334)this.eventTrigger_0).string_3 = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_28().SelectedItem, null, "tag", new object[0], null, null, null));
		}

		// Token: 0x06007A62 RID: 31330 RVA: 0x0004B5E2 File Offset: 0x000497E2
		private void method_7(object sender, EventArgs e)
		{
			((Class334)this.eventTrigger_0).enum48_0 = (Class334.Enum48)this.vmethod_22().SelectedIndex;
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x0004B600 File Offset: 0x00049800
		private void method_8(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_26().Value))
			{
				((Class334)this.eventTrigger_0).int_0 = Convert.ToInt32(this.vmethod_26().Value);
			}
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x00427358 File Offset: 0x00425558
		private void method_9(object sender, EventArgs e)
		{
			List<string> list = Enumerable.ToList<string>(this.vmethod_36().Text.Split(new char[]
			{
				':'
			}));
			if (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2]))
			{
				List<string> list2 = Enumerable.ToList<string>(this.vmethod_38().Text.Split(new char[]
				{
					'-'
				}));
				if (Versioned.IsNumeric(list2[0]) & Versioned.IsNumeric(list2[1]) & Versioned.IsNumeric(list2[2]))
				{
					((Class335)this.eventTrigger_0).dateTime_0 = new DateTime(Conversions.ToInteger(list2[0]), Conversions.ToInteger(list2[1]), Conversions.ToInteger(list2[2]), Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2]));
					this.vmethod_40().Text = "Currently set: " + ((Class335)this.eventTrigger_0).dateTime_0.ToShortDateString() + " - " + ((Class335)this.eventTrigger_0).dateTime_0.ToShortTimeString();
				}
			}
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x004274A0 File Offset: 0x004256A0
		private void method_10(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_44().Value) && !Information.IsNothing(this.eventTrigger_0))
			{
				((Class336)this.eventTrigger_0).byte_0 = Convert.ToByte(this.vmethod_44().Value);
			}
		}

		// Token: 0x06007A66 RID: 31334 RVA: 0x004274F4 File Offset: 0x004256F4
		private void method_11(object object_0)
		{
			if (string.IsNullOrEmpty(this.vmethod_62().Text))
			{
				this.vmethod_62().Text = "0";
			}
			if (Versioned.IsNumeric(this.vmethod_62().Text))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(this.vmethod_62().Text), Conversions.ToInteger(this.vmethod_58().Text), Conversions.ToInteger(this.vmethod_56().Text), Conversions.ToInteger(this.vmethod_70().Text));
				if (!Information.IsNothing(this.eventTrigger_0))
				{
					((Class333)this.eventTrigger_0).long_0 = (long)Math.Round(timeSpan.TotalSeconds);
				}
			}
		}

		// Token: 0x06007A67 RID: 31335 RVA: 0x004275A8 File Offset: 0x004257A8
		private void method_12(object object_0)
		{
			if (string.IsNullOrEmpty(this.vmethod_58().Text))
			{
				this.vmethod_58().Text = "0";
			}
			if (Versioned.IsNumeric(this.vmethod_58().Text))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(this.vmethod_62().Text), Conversions.ToInteger(this.vmethod_58().Text), Conversions.ToInteger(this.vmethod_56().Text), Conversions.ToInteger(this.vmethod_70().Text));
				if (!Information.IsNothing(this.eventTrigger_0))
				{
					((Class333)this.eventTrigger_0).long_0 = (long)Math.Round(timeSpan.TotalSeconds);
				}
			}
		}

		// Token: 0x06007A68 RID: 31336 RVA: 0x0042765C File Offset: 0x0042585C
		private void method_13(object object_0)
		{
			if (string.IsNullOrEmpty(this.vmethod_56().Text))
			{
				this.vmethod_56().Text = "0";
			}
			if (Versioned.IsNumeric(this.vmethod_56().Text))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(this.vmethod_62().Text), Conversions.ToInteger(this.vmethod_58().Text), Conversions.ToInteger(this.vmethod_56().Text), Conversions.ToInteger(this.vmethod_70().Text));
				if (!Information.IsNothing(this.eventTrigger_0))
				{
					((Class333)this.eventTrigger_0).long_0 = (long)Math.Round(timeSpan.TotalSeconds);
				}
			}
		}

		// Token: 0x06007A69 RID: 31337 RVA: 0x00427710 File Offset: 0x00425910
		private void method_14(object object_0)
		{
			if (string.IsNullOrEmpty(this.vmethod_70().Text))
			{
				this.vmethod_70().Text = "0";
			}
			if (Versioned.IsNumeric(this.vmethod_70().Text))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(this.vmethod_62().Text), Conversions.ToInteger(this.vmethod_58().Text), Conversions.ToInteger(this.vmethod_56().Text), Conversions.ToInteger(this.vmethod_70().Text));
				if (!Information.IsNothing(this.eventTrigger_0))
				{
					((Class333)this.eventTrigger_0).long_0 = (long)Math.Round(timeSpan.TotalSeconds);
				}
			}
		}

		// Token: 0x06007A6A RID: 31338 RVA: 0x004277C4 File Offset: 0x004259C4
		private void method_15(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventTrigger_0))
			{
				((Class332)this.eventTrigger_0).bool_11 = this.vmethod_92().Checked;
				if (this.vmethod_92().Checked)
				{
					this.vmethod_94().Checked = false;
					this.Refresh();
				}
			}
		}

		// Token: 0x06007A6B RID: 31339 RVA: 0x00427818 File Offset: 0x00425A18
		private void method_16(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventTrigger_0))
			{
				((Class332)this.eventTrigger_0).bool_12 = this.vmethod_94().Checked;
				if (this.vmethod_94().Checked)
				{
					this.vmethod_92().Checked = false;
					this.Refresh();
				}
			}
		}

		// Token: 0x06007A6C RID: 31340 RVA: 0x0042786C File Offset: 0x00425A6C
		private void method_17(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventTrigger_0))
			{
				List<string> list = Enumerable.ToList<string>(this.vmethod_98().Text.Split(new char[]
				{
					':'
				}));
				if (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2]))
				{
					List<string> list2 = Enumerable.ToList<string>(this.vmethod_84().Text.Split(new char[]
					{
						'-'
					}));
					if (Versioned.IsNumeric(list2[0]) & Versioned.IsNumeric(list2[1]) & Versioned.IsNumeric(list2[2]))
					{
						((Class332)this.eventTrigger_0).dateTime_0 = new DateTime(Conversions.ToInteger(list2[0]), Conversions.ToInteger(list2[1]), Conversions.ToInteger(list2[2]), Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2]));
						this.vmethod_78().Text = "Earliest: " + ((Class332)this.eventTrigger_0).dateTime_0.ToShortDateString() + " - " + ((Class332)this.eventTrigger_0).dateTime_0.ToShortTimeString();
						List<string> list3 = Enumerable.ToList<string>(this.vmethod_90().Text.Split(new char[]
						{
							':'
						}));
						if (Versioned.IsNumeric(list3[0]) & Versioned.IsNumeric(list3[1]) & Versioned.IsNumeric(list3[2]))
						{
							List<string> list4 = Enumerable.ToList<string>(this.vmethod_86().Text.Split(new char[]
							{
								'-'
							}));
							if (Versioned.IsNumeric(list4[0]) & Versioned.IsNumeric(list4[1]) & Versioned.IsNumeric(list4[2]))
							{
								((Class332)this.eventTrigger_0).dateTime_1 = new DateTime(Conversions.ToInteger(list4[0]), Conversions.ToInteger(list4[1]), Conversions.ToInteger(list4[2]), Conversions.ToInteger(list3[0]), Conversions.ToInteger(list3[1]), Conversions.ToInteger(list3[2]));
								this.vmethod_76().Text = "Latest: " + ((Class332)this.eventTrigger_0).dateTime_1.ToShortDateString() + " - " + ((Class332)this.eventTrigger_0).dateTime_1.ToShortTimeString();
							}
						}
					}
				}
			}
		}

		// Token: 0x06007A6D RID: 31341 RVA: 0x00427AFC File Offset: 0x00425CFC
		private void method_18(object sender, EventArgs e)
		{
			List<string> list = Enumerable.ToList<string>(this.vmethod_114().Text.Split(new char[]
			{
				':'
			}));
			if (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2]))
			{
				List<string> list2 = Enumerable.ToList<string>(this.vmethod_116().Text.Split(new char[]
				{
					'-'
				}));
				if (Versioned.IsNumeric(list2[0]) & Versioned.IsNumeric(list2[1]) & Versioned.IsNumeric(list2[2]))
				{
					((Class327)this.eventTrigger_0).dateTime_0 = new DateTime(Conversions.ToInteger(list2[0]), Conversions.ToInteger(list2[1]), Conversions.ToInteger(list2[2]), Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2]));
					List<string> list3 = Enumerable.ToList<string>(this.vmethod_104().Text.Split(new char[]
					{
						':'
					}));
					if (Versioned.IsNumeric(list3[0]) & Versioned.IsNumeric(list3[1]) & Versioned.IsNumeric(list3[2]))
					{
						List<string> list4 = Enumerable.ToList<string>(this.vmethod_106().Text.Split(new char[]
						{
							'-'
						}));
						if (Versioned.IsNumeric(list4[0]) & Versioned.IsNumeric(list4[1]) & Versioned.IsNumeric(list4[2]))
						{
							((Class327)this.eventTrigger_0).dateTime_1 = new DateTime(Conversions.ToInteger(list4[0]), Conversions.ToInteger(list4[1]), Conversions.ToInteger(list4[2]), Conversions.ToInteger(list3[0]), Conversions.ToInteger(list3[1]), Conversions.ToInteger(list3[2]));
							if (DateTime.Compare(((Class327)this.eventTrigger_0).dateTime_0, ((Class327)this.eventTrigger_0).dateTime_1) > 0)
							{
								DarkMessageBox.smethod_2("Error! Earliest Time cannot be greater than Latest Time!", "", Enum11.const_0);
								this.vmethod_112().Text = "Error! Earliest Time cannot be greater than Latest Time";
								return;
							}
							this.vmethod_112().Text = string.Concat(new string[]
							{
								"Currently set: \r\nEarliest: ",
								((Class327)this.eventTrigger_0).dateTime_0.ToShortDateString(),
								" - ",
								((Class327)this.eventTrigger_0).dateTime_0.ToShortTimeString(),
								"\r\nLatest: ",
								((Class327)this.eventTrigger_0).dateTime_1.ToShortDateString(),
								" - ",
								((Class327)this.eventTrigger_0).dateTime_1.ToShortTimeString()
							});
						}
					}
				}
			}
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x003B6260 File Offset: 0x003B4460
		private void EditTrigger_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06007A6F RID: 31343 RVA: 0x0004B639 File Offset: 0x00049839
		private void method_19(object sender, EventArgs e)
		{
			((Class329)this.eventTrigger_0).string_3 = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_122().SelectedItem, null, "tag", new object[0], null, null, null));
		}

		// Token: 0x06007A70 RID: 31344 RVA: 0x00427DD4 File Offset: 0x00425FD4
		private void EditTrigger_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.vmethod_62().method_22(new Control8.Delegate85(this.method_11));
			this.vmethod_58().method_22(new Control8.Delegate85(this.method_12));
			this.vmethod_56().method_22(new Control8.Delegate85(this.method_13));
			this.vmethod_70().method_22(new Control8.Delegate85(this.method_14));
		}

		// Token: 0x06007A71 RID: 31345 RVA: 0x0004B66F File Offset: 0x0004986F
		private void method_20(object sender, EventArgs e)
		{
			((Class329)this.eventTrigger_0).identificationStatus_0 = (Contact_Base.IdentificationStatus)this.vmethod_132().SelectedIndex;
		}

		// Token: 0x06007A72 RID: 31346 RVA: 0x00427E40 File Offset: 0x00426040
		private void method_21(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventTrigger_0))
			{
				switch (this.vmethod_128().SelectedIndex)
				{
				case 0:
					((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0 = EventTrigger_RegularTime.RegularTimeInterval.OneSecond;
					return;
				case 1:
					((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0 = EventTrigger_RegularTime.RegularTimeInterval.FiveSeconds;
					return;
				case 2:
					((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0 = EventTrigger_RegularTime.RegularTimeInterval.FifteenSeconds;
					return;
				case 3:
					((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0 = EventTrigger_RegularTime.RegularTimeInterval.ThirtySeconds;
					return;
				case 4:
					((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0 = EventTrigger_RegularTime.RegularTimeInterval.OneMinute;
					return;
				case 5:
					((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0 = EventTrigger_RegularTime.RegularTimeInterval.FiveMinutes;
					return;
				case 6:
					((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0 = EventTrigger_RegularTime.RegularTimeInterval.FifteenMinutes;
					return;
				case 7:
					((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0 = EventTrigger_RegularTime.RegularTimeInterval.ThirtyMinutes;
					return;
				case 8:
					((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0 = EventTrigger_RegularTime.RegularTimeInterval.OneHour;
					return;
				case 9:
					((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0 = EventTrigger_RegularTime.RegularTimeInterval.SixHours;
					return;
				case 10:
					((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0 = EventTrigger_RegularTime.RegularTimeInterval.TwelveHours;
					return;
				case 11:
					((EventTrigger_RegularTime)this.eventTrigger_0).regularTimeInterval_0 = EventTrigger_RegularTime.RegularTimeInterval.TwentyFourHours;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06007A73 RID: 31347 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_22(object sender, EventArgs e)
		{
		}

		// Token: 0x04004409 RID: 17417
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x0400440A RID: 17418
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private Control8 control8_0;

		// Token: 0x0400440B RID: 17419
		[AccessedThroughProperty("Button_OK")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x0400440C RID: 17420
		[AccessedThroughProperty("Button_Cancel")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x0400440D RID: 17421
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x0400440E RID: 17422
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage1")]
		private TabPage tabPage_0;

		// Token: 0x0400440F RID: 17423
		[AccessedThroughProperty("TC_TriggerOptions")]
		[CompilerGenerated]
		private Control12 control12_0;

		// Token: 0x04004410 RID: 17424
		[CompilerGenerated]
		[AccessedThroughProperty("UnitFilter_UnitDestroyed")]
		private UnitFilter unitFilter_0;

		// Token: 0x04004411 RID: 17425
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage2")]
		private TabPage tabPage_1;

		// Token: 0x04004412 RID: 17426
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage3")]
		private TabPage tabPage_2;

		// Token: 0x04004413 RID: 17427
		[AccessedThroughProperty("UnitFilter_UnitDamaged")]
		[CompilerGenerated]
		private UnitFilter unitFilter_1;

		// Token: 0x04004414 RID: 17428
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Points_ReachDirection")]
		private Class2451 class2451_0;

		// Token: 0x04004415 RID: 17429
		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Class116 class116_2;

		// Token: 0x04004416 RID: 17430
		[CompilerGenerated]
		[AccessedThroughProperty("NUD_Points")]
		private Class120 class120_0;

		// Token: 0x04004417 RID: 17431
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Points_Sides")]
		private Class2451 class2451_1;

		// Token: 0x04004418 RID: 17432
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x04004419 RID: 17433
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_4;

		// Token: 0x0400441A RID: 17434
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage4")]
		private TabPage tabPage_3;

		// Token: 0x0400441B RID: 17435
		[CompilerGenerated]
		[AccessedThroughProperty("DTP_StartTime")]
		private Class118 class118_0;

		// Token: 0x0400441C RID: 17436
		[CompilerGenerated]
		[AccessedThroughProperty("DTP_StartDate")]
		private Class118 class118_1;

		// Token: 0x0400441D RID: 17437
		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Class116 class116_5;

		// Token: 0x0400441E RID: 17438
		[AccessedThroughProperty("Button_SetTime")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x0400441F RID: 17439
		[CompilerGenerated]
		[AccessedThroughProperty("NUD_DamagePercent")]
		private Class120 class120_1;

		// Token: 0x04004420 RID: 17440
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Class116 class116_6;

		// Token: 0x04004421 RID: 17441
		[AccessedThroughProperty("TabPage5")]
		[CompilerGenerated]
		private TabPage tabPage_4;

		// Token: 0x04004422 RID: 17442
		[AccessedThroughProperty("UnitFilter_UnitInArea")]
		[CompilerGenerated]
		private UnitFilter unitFilter_2;

		// Token: 0x04004423 RID: 17443
		[AccessedThroughProperty("AreaEditor_UnitInArea")]
		[CompilerGenerated]
		private AreaEditor areaEditor_0;

		// Token: 0x04004424 RID: 17444
		[AccessedThroughProperty("GroupBox1")]
		[CompilerGenerated]
		private Class115 class115_0;

		// Token: 0x04004425 RID: 17445
		[AccessedThroughProperty("TB_Mins")]
		[CompilerGenerated]
		private Control8 control8_1;

		// Token: 0x04004426 RID: 17446
		[AccessedThroughProperty("TB_Hours")]
		[CompilerGenerated]
		private Control8 control8_2;

		// Token: 0x04004427 RID: 17447
		[CompilerGenerated]
		[AccessedThroughProperty("Label10")]
		private Class116 class116_7;

		// Token: 0x04004428 RID: 17448
		[AccessedThroughProperty("TB_Days")]
		[CompilerGenerated]
		private Control8 control8_3;

		// Token: 0x04004429 RID: 17449
		[AccessedThroughProperty("Label9")]
		[CompilerGenerated]
		private Class116 class116_8;

		// Token: 0x0400442A RID: 17450
		[AccessedThroughProperty("Label12")]
		[CompilerGenerated]
		private Class116 class116_9;

		// Token: 0x0400442B RID: 17451
		[AccessedThroughProperty("Label11")]
		[CompilerGenerated]
		private Class116 class116_10;

		// Token: 0x0400442C RID: 17452
		[CompilerGenerated]
		[AccessedThroughProperty("TB_Secs")]
		private Control8 control8_4;

		// Token: 0x0400442D RID: 17453
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage6")]
		private TabPage tabPage_5;

		// Token: 0x0400442E RID: 17454
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox2")]
		private Class115 class115_1;

		// Token: 0x0400442F RID: 17455
		[AccessedThroughProperty("Label_UnitEntersArea_Latest")]
		[CompilerGenerated]
		private Class116 class116_11;

		// Token: 0x04004430 RID: 17456
		[CompilerGenerated]
		[AccessedThroughProperty("Label_UnitEntersArea_Earliest")]
		private Class116 class116_12;

		// Token: 0x04004431 RID: 17457
		[CompilerGenerated]
		[AccessedThroughProperty("AreaEditor_UnitEntersArea")]
		private AreaEditor areaEditor_1;

		// Token: 0x04004432 RID: 17458
		[AccessedThroughProperty("UnitFilter_UnitEntersArea")]
		[CompilerGenerated]
		private UnitFilter unitFilter_3;

		// Token: 0x04004433 RID: 17459
		[AccessedThroughProperty("DTP_EnterArea_ETOA_Date")]
		[CompilerGenerated]
		private Class118 class118_2;

		// Token: 0x04004434 RID: 17460
		[AccessedThroughProperty("DTP_EnterArea_LTOA_Date")]
		[CompilerGenerated]
		private Class118 class118_3;

		// Token: 0x04004435 RID: 17461
		[AccessedThroughProperty("Button_UnitEntersArea")]
		[CompilerGenerated]
		private Control9 control9_3;

		// Token: 0x04004436 RID: 17462
		[CompilerGenerated]
		[AccessedThroughProperty("DTP_EnterArea_LTOA_Time")]
		private Class118 class118_4;

		// Token: 0x04004437 RID: 17463
		[CompilerGenerated]
		[AccessedThroughProperty("CB_UnitEntersArea_ModifierNOT")]
		private Class112 class112_0;

		// Token: 0x04004438 RID: 17464
		[AccessedThroughProperty("CB_UnitEntersArea_ModifierEXIT")]
		[CompilerGenerated]
		private Class112 class112_1;

		// Token: 0x04004439 RID: 17465
		[CompilerGenerated]
		[AccessedThroughProperty("ToolTip1")]
		private System.Windows.Forms.ToolTip toolTip_0;

		// Token: 0x0400443A RID: 17466
		[CompilerGenerated]
		[AccessedThroughProperty("DTP_EnterArea_ETOA_Time")]
		private Class118 class118_5;

		// Token: 0x0400443B RID: 17467
		[AccessedThroughProperty("TabPage7")]
		[CompilerGenerated]
		private TabPage tabPage_6;

		// Token: 0x0400443C RID: 17468
		[CompilerGenerated]
		[AccessedThroughProperty("Label14")]
		private Class116 class116_13;

		// Token: 0x0400443D RID: 17469
		[AccessedThroughProperty("DTP_LatestTime")]
		[CompilerGenerated]
		private Class118 class118_6;

		// Token: 0x0400443E RID: 17470
		[AccessedThroughProperty("DTP_LatestDate")]
		[CompilerGenerated]
		private Class118 class118_7;

		// Token: 0x0400443F RID: 17471
		[CompilerGenerated]
		[AccessedThroughProperty("Label13")]
		private Class116 class116_14;

		// Token: 0x04004440 RID: 17472
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_4;

		// Token: 0x04004441 RID: 17473
		[AccessedThroughProperty("Label8")]
		[CompilerGenerated]
		private Class116 class116_15;

		// Token: 0x04004442 RID: 17474
		[CompilerGenerated]
		[AccessedThroughProperty("DTP_EarliestTime")]
		private Class118 class118_8;

		// Token: 0x04004443 RID: 17475
		[CompilerGenerated]
		[AccessedThroughProperty("DTP_EarliestDate")]
		private Class118 class118_9;

		// Token: 0x04004444 RID: 17476
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage8")]
		private TabPage tabPage_7;

		// Token: 0x04004445 RID: 17477
		[CompilerGenerated]
		[AccessedThroughProperty("UnitFilter_UnitDetected")]
		private UnitFilter unitFilter_4;

		// Token: 0x04004446 RID: 17478
		[AccessedThroughProperty("CB_UnitDetected_Sides")]
		[CompilerGenerated]
		private Class2451 class2451_2;

		// Token: 0x04004447 RID: 17479
		[CompilerGenerated]
		[AccessedThroughProperty("Label15")]
		private Class116 class116_16;

		// Token: 0x04004448 RID: 17480
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage9")]
		private TabPage tabPage_8;

		// Token: 0x04004449 RID: 17481
		[CompilerGenerated]
		[AccessedThroughProperty("CB_RegularTimeInterval")]
		private Class2451 class2451_3;

		// Token: 0x0400444A RID: 17482
		[AccessedThroughProperty("Label17")]
		[CompilerGenerated]
		private Class116 class116_17;

		// Token: 0x0400444B RID: 17483
		[AccessedThroughProperty("CB_MCL")]
		[CompilerGenerated]
		private Class2451 class2451_4;

		// Token: 0x0400444C RID: 17484
		[CompilerGenerated]
		[AccessedThroughProperty("Label16")]
		private Class116 class116_18;

		// Token: 0x0400444D RID: 17485
		[CompilerGenerated]
		[AccessedThroughProperty("AreaEditor_DetectedArea")]
		private AreaEditor areaEditor_2;

		// Token: 0x0400444E RID: 17486
		public EventTrigger eventTrigger_0;

		// Token: 0x0400444F RID: 17487
		public EditTrigger.Enum207 enum207_0;

		// Token: 0x02000EBF RID: 3775
		internal enum Enum207 : byte
		{
			// Token: 0x04004451 RID: 17489
			const_0,
			// Token: 0x04004452 RID: 17490
			const_1
		}
	}
}
