using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;

namespace ns6
{
	// Token: 0x02000ECC RID: 3788
	[DesignerGenerated]
	internal sealed partial class Options : DarkSecondaryFormBase
	{
		// Token: 0x060082A3 RID: 33443 RVA: 0x00466678 File Offset: 0x00464878
		public Options()
		{
			base.Load += this.Options_Load;
			base.KeyDown += this.Options_KeyDown;
			base.FormClosing += this.Options_FormClosing;
			this.bool_3 = false;
			this.bool_4 = false;
			this.InitializeComponent_1();
		}

		// Token: 0x060082A5 RID: 33445 RVA: 0x004666D8 File Offset: 0x004648D8
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_9(new Control12());
			this.vmethod_5(new TabPage());
			this.vmethod_105(new Class112());
			this.vmethod_103(new Class112());
			this.vmethod_101(new Class112());
			this.vmethod_57(new Control8());
			this.vmethod_59(new Control8());
			this.vmethod_61(new Class116());
			this.vmethod_63(new Class116());
			this.vmethod_55(new Class112());
			this.vmethod_51(new Class112());
			this.vmethod_23(new Control9());
			this.vmethod_15(new Class112());
			this.vmethod_13(new Class112());
			this.vmethod_11(new Class112());
			this.vmethod_7(new Class112());
			this.vmethod_25(new TabPage());
			this.vmethod_141(new Class112());
			this.vmethod_137(new Control9());
			this.vmethod_139(new Class112());
			this.vmethod_113(new Class2451());
			this.vmethod_115(new Class116());
			this.vmethod_109(new Class2451());
			this.vmethod_111(new Class116());
			this.vmethod_65(new Class112());
			this.vmethod_53(new Class112());
			this.vmethod_41(new Class2451());
			this.vmethod_43(new Class116());
			this.vmethod_45(new Class2451());
			this.vmethod_47(new Class116());
			this.vmethod_37(new Class2451());
			this.vmethod_39(new Class116());
			this.vmethod_27(new Class2451());
			this.vmethod_49(new Class116());
			this.vmethod_29(new Class2451());
			this.vmethod_31(new Class116());
			this.vmethod_33(new Class2451());
			this.vmethod_35(new Class116());
			this.vmethod_1(new TabPage());
			this.vmethod_3(new Class114());
			this.vmethod_117(new DataGridViewTextBoxColumn());
			this.vmethod_119(new DataGridViewTextBoxColumn());
			this.vmethod_121(new DataGridViewCheckBoxColumn());
			this.vmethod_123(new DataGridViewCheckBoxColumn());
			this.vmethod_125(new DataGridViewCheckBoxColumn());
			this.vmethod_17(new TabPage());
			this.vmethod_21(new Class112());
			this.vmethod_19(new Class112());
			this.vmethod_67(new TabPage());
			this.vmethod_69(new Class115());
			this.vmethod_71(new Class112());
			this.vmethod_73(new Class115());
			this.vmethod_75(new Class112());
			this.vmethod_77(new Class112());
			this.vmethod_79(new Class112());
			this.vmethod_81(new Class115());
			this.vmethod_107(new Class112());
			this.vmethod_83(new Class112());
			this.vmethod_85(new Class112());
			this.vmethod_87(new Class112());
			this.vmethod_89(new Class112());
			this.vmethod_91(new Class112());
			this.vmethod_93(new Class112());
			this.vmethod_95(new Class112());
			this.vmethod_97(new Class112());
			this.vmethod_99(new Class116());
			this.vmethod_127(new TabPage());
			this.vmethod_131(new Control8());
			this.vmethod_133(new Control9());
			this.vmethod_129(new Class116());
			this.vmethod_143(new TabPage());
			this.vmethod_145(new ElementHost());
			this.hoverInfoOptions_0 = new HoverInfoOptions();
			this.vmethod_135(new OpenFileDialog());
			this.vmethod_8().SuspendLayout();
			this.vmethod_4().SuspendLayout();
			this.vmethod_24().SuspendLayout();
			this.vmethod_0().SuspendLayout();
			((ISupportInitialize)this.vmethod_2()).BeginInit();
			this.vmethod_16().SuspendLayout();
			this.vmethod_66().SuspendLayout();
			this.vmethod_68().SuspendLayout();
			this.vmethod_72().SuspendLayout();
			this.vmethod_80().SuspendLayout();
			this.vmethod_126().SuspendLayout();
			this.vmethod_142().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_8().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_8().Controls.Add(this.vmethod_4());
			this.vmethod_8().Controls.Add(this.vmethod_24());
			this.vmethod_8().Controls.Add(this.vmethod_0());
			this.vmethod_8().Controls.Add(this.vmethod_16());
			this.vmethod_8().Controls.Add(this.vmethod_66());
			this.vmethod_8().Controls.Add(this.vmethod_126());
			this.vmethod_8().Controls.Add(this.vmethod_142());
			this.vmethod_8().Cursor = Cursors.Hand;
			this.vmethod_8().Font = new Font("Segoe UI", 8f);
			this.vmethod_8().ItemSize = new Size(80, 20);
			this.vmethod_8().Location = new Point(0, 0);
			this.vmethod_8().Name = "TabControl1";
			this.vmethod_8().SelectedIndex = 0;
			this.vmethod_8().Size = new Size(702, 470);
			this.vmethod_8().TabIndex = 0;
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().Controls.Add(this.vmethod_104());
			this.vmethod_4().Controls.Add(this.vmethod_102());
			this.vmethod_4().Controls.Add(this.vmethod_100());
			this.vmethod_4().Controls.Add(this.vmethod_56());
			this.vmethod_4().Controls.Add(this.vmethod_58());
			this.vmethod_4().Controls.Add(this.vmethod_60());
			this.vmethod_4().Controls.Add(this.vmethod_62());
			this.vmethod_4().Controls.Add(this.vmethod_54());
			this.vmethod_4().Controls.Add(this.vmethod_50());
			this.vmethod_4().Controls.Add(this.vmethod_22());
			this.vmethod_4().Controls.Add(this.vmethod_14());
			this.vmethod_4().Controls.Add(this.vmethod_12());
			this.vmethod_4().Controls.Add(this.vmethod_10());
			this.vmethod_4().Controls.Add(this.vmethod_6());
			this.vmethod_4().Location = new Point(4, 24);
			this.vmethod_4().Name = "TabPage1";
			this.vmethod_4().Padding = new Padding(3);
			this.vmethod_4().Size = new Size(694, 442);
			this.vmethod_4().TabIndex = 1;
			this.vmethod_4().Text = "General";
			this.vmethod_104().Location = new Point(8, 201);
			this.vmethod_104().Name = "CB_MemoryProtection";
			this.vmethod_104().Size = new Size(270, 17);
			this.vmethod_104().TabIndex = 25;
			this.vmethod_104().Text = "Extra memory protection (rarely needed)";
			this.vmethod_102().AutoSize = true;
			this.vmethod_102().Location = new Point(8, 161);
			this.vmethod_102().Name = "CB_LogDebugInfoToFile";
			this.vmethod_102().Size = new Size(289, 17);
			this.vmethod_102().TabIndex = 24;
			this.vmethod_102().Text = "Log debug information to file (only for debugging)";
			this.vmethod_100().AutoSize = true;
			this.vmethod_100().Location = new Point(8, 139);
			this.vmethod_100().Name = "CB_ShowGameSpeedButton";
			this.vmethod_100().Size = new Size(311, 17);
			this.vmethod_100().TabIndex = 23;
			this.vmethod_100().Text = "Show 'Game Speed' button on toolbar in main window";
			this.vmethod_56().method_14(null);
			this.vmethod_56().method_15(AutoCompleteMode.None);
			this.vmethod_56().method_13(AutoCompleteSource.None);
			this.vmethod_56().BackColor = Color.Transparent;
			this.vmethod_56().method_17(new Font("Segoe UI", 8f));
			this.vmethod_56().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_56().method_12(null);
			this.vmethod_56().method_18(null);
			this.vmethod_56().Location = new Point(412, 182);
			this.vmethod_56().method_2(32767);
			this.vmethod_56().method_7(false);
			this.vmethod_56().Name = "TB_Navigation_ThresholdDistanceDeg";
			this.vmethod_56().method_3(false);
			this.vmethod_56().method_19(ScrollBars.None);
			this.vmethod_56().method_9(0);
			this.vmethod_56().Size = new Size(30, 20);
			this.vmethod_56().TabIndex = 22;
			this.vmethod_56().method_1(HorizontalAlignment.Left);
			this.vmethod_56().method_5(false);
			this.vmethod_56().method_10("");
			this.vmethod_58().method_14(null);
			this.vmethod_58().method_15(AutoCompleteMode.None);
			this.vmethod_58().method_13(AutoCompleteSource.None);
			this.vmethod_58().BackColor = Color.Transparent;
			this.vmethod_58().method_17(new Font("Segoe UI", 8f));
			this.vmethod_58().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_58().method_12(null);
			this.vmethod_58().method_18(null);
			this.vmethod_58().Location = new Point(237, 182);
			this.vmethod_58().method_2(32767);
			this.vmethod_58().method_7(false);
			this.vmethod_58().Name = "TB_Navigation_MaxDistanceNM";
			this.vmethod_58().method_3(false);
			this.vmethod_58().method_19(ScrollBars.None);
			this.vmethod_58().method_9(0);
			this.vmethod_58().Size = new Size(41, 20);
			this.vmethod_58().TabIndex = 22;
			this.vmethod_58().method_1(HorizontalAlignment.Left);
			this.vmethod_58().method_5(false);
			this.vmethod_58().method_10("");
			this.vmethod_60().method_2(true);
			this.vmethod_60().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_60().Location = new Point(279, 185);
			this.vmethod_60().Name = "Label8";
			this.vmethod_60().Size = new Size(137, 13);
			this.vmethod_60().TabIndex = 21;
			this.vmethod_60().Text = "Threshold distance (deg):";
			this.vmethod_62().method_2(true);
			this.vmethod_62().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_62().Location = new Point(4, 183);
			this.vmethod_62().Name = "Label7";
			this.vmethod_62().Size = new Size(231, 13);
			this.vmethod_62().TabIndex = 20;
			this.vmethod_62().Text = "Fine-grained navigation, max distance (nm):";
			this.vmethod_54().AutoSize = true;
			this.vmethod_54().Location = new Point(8, 117);
			this.vmethod_54().Name = "CB_AllowPowerScemeSwitch";
			this.vmethod_54().Size = new Size(295, 17);
			this.vmethod_54().TabIndex = 18;
			this.vmethod_54().Text = "Allow switching to High-Performance power scheme";
			this.vmethod_50().AutoSize = true;
			this.vmethod_50().Location = new Point(8, 95);
			this.vmethod_50().Name = "CB_UnitStatusImage";
			this.vmethod_50().Size = new Size(155, 17);
			this.vmethod_50().TabIndex = 17;
			this.vmethod_50().Text = "Display unit status image";
			this.vmethod_22().BackColor = Color.Transparent;
			this.vmethod_22().DialogResult = DialogResult.None;
			this.vmethod_22().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_22().ForeColor = SystemColors.Control;
			this.vmethod_22().Location = new Point(3, 411);
			this.vmethod_22().Name = "Button_ResetWindowPlacement";
			this.vmethod_22().method_1(0);
			this.vmethod_22().Size = new Size(202, 23);
			this.vmethod_22().TabIndex = 11;
			this.vmethod_22().Text = "Reset positions of secondary windows";
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new Point(8, 73);
			this.vmethod_14().Name = "CB_ZoomOnCursor";
			this.vmethod_14().Size = new Size(174, 17);
			this.vmethod_14().TabIndex = 7;
			this.vmethod_14().Text = "Map zooms on mouse cursor";
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Location = new Point(8, 51);
			this.vmethod_12().Name = "CB_AltitudeInFeet";
			this.vmethod_12().Size = new Size(136, 17);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_12().Text = "Show altitude in Feet";
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Location = new Point(8, 29);
			this.vmethod_10().Name = "CB_MessageLogInWindow";
			this.vmethod_10().Size = new Size(285, 17);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_10().Text = "Message log in separate window [Ctrl + Shift + M]";
			this.vmethod_6().AutoSize = true;
			this.vmethod_6().BackColor = Color.FromArgb(39, 39, 39);
			this.vmethod_6().Location = new Point(8, 7);
			this.vmethod_6().Name = "CB_UseAutosave";
			this.vmethod_6().Size = new Size(95, 17);
			this.vmethod_6().TabIndex = 0;
			this.vmethod_6().Text = "Use Autosave";
			this.vmethod_24().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_24().Controls.Add(this.vmethod_140());
			this.vmethod_24().Controls.Add(this.vmethod_136());
			this.vmethod_24().Controls.Add(this.vmethod_138());
			this.vmethod_24().Controls.Add(this.vmethod_112());
			this.vmethod_24().Controls.Add(this.vmethod_114());
			this.vmethod_24().Controls.Add(this.vmethod_108());
			this.vmethod_24().Controls.Add(this.vmethod_110());
			this.vmethod_24().Controls.Add(this.vmethod_64());
			this.vmethod_24().Controls.Add(this.vmethod_52());
			this.vmethod_24().Controls.Add(this.vmethod_40());
			this.vmethod_24().Controls.Add(this.vmethod_42());
			this.vmethod_24().Controls.Add(this.vmethod_44());
			this.vmethod_24().Controls.Add(this.vmethod_46());
			this.vmethod_24().Controls.Add(this.vmethod_36());
			this.vmethod_24().Controls.Add(this.vmethod_38());
			this.vmethod_24().Controls.Add(this.vmethod_26());
			this.vmethod_24().Controls.Add(this.vmethod_48());
			this.vmethod_24().Controls.Add(this.vmethod_28());
			this.vmethod_24().Controls.Add(this.vmethod_30());
			this.vmethod_24().Controls.Add(this.vmethod_32());
			this.vmethod_24().Controls.Add(this.vmethod_34());
			this.vmethod_24().Location = new Point(4, 24);
			this.vmethod_24().Name = "TabPage4";
			this.vmethod_24().Padding = new Padding(3);
			this.vmethod_24().Size = new Size(694, 442);
			this.vmethod_24().TabIndex = 4;
			this.vmethod_24().Text = "Map Display";
			this.vmethod_140().AutoSize = true;
			this.vmethod_140().Location = new Point(11, 256);
			this.vmethod_140().Name = "CB_ColorDatablocks";
			this.vmethod_140().Size = new Size(146, 17);
			this.vmethod_140().TabIndex = 37;
			this.vmethod_140().Text = "Use colored datablocks";
			this.vmethod_136().BackColor = Color.Transparent;
			this.vmethod_136().DialogResult = DialogResult.None;
			this.vmethod_136().ForeColor = SystemColors.Control;
			this.vmethod_136().Location = new Point(183, 302);
			this.vmethod_136().Name = "Button_SetPersonalMapProfile";
			this.vmethod_136().method_1(0);
			this.vmethod_136().Size = new Size(195, 23);
			this.vmethod_136().TabIndex = 36;
			this.vmethod_136().Text = "Save current map profile as \"personal\"";
			this.vmethod_138().AutoSize = true;
			this.vmethod_138().Location = new Point(11, 302);
			this.vmethod_138().Name = "CB_UsePersonalMapProfile";
			this.vmethod_138().Size = new Size(155, 17);
			this.vmethod_138().TabIndex = 35;
			this.vmethod_138().Text = "Use personal map profile";
			this.vmethod_112().BackColor = Color.Transparent;
			this.vmethod_112().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_112().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_112().Font = new Font("Segoe UI", 7f);
			this.vmethod_112().FormattingEnabled = true;
			this.vmethod_112().Items.AddRange(new object[]
			{
				"All",
				"Selected Task Pool ",
				"Selected Package",
				"Selected Flight",
				"Do not Show"
			});
			this.vmethod_112().Location = new Point(183, 202);
			this.vmethod_112().Name = "CP_ShowFlightPlans_Planned";
			this.vmethod_112().Size = new Size(245, 21);
			this.vmethod_112().TabIndex = 34;
			this.vmethod_114().method_2(true);
			this.vmethod_114().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_114().Location = new Point(8, 205);
			this.vmethod_114().Name = "Label11";
			this.vmethod_114().Size = new Size(150, 13);
			this.vmethod_114().TabIndex = 33;
			this.vmethod_114().Text = "Show flightplans (planned):";
			this.vmethod_108().BackColor = Color.Transparent;
			this.vmethod_108().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_108().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_108().Font = new Font("Segoe UI", 7f);
			this.vmethod_108().FormattingEnabled = true;
			this.vmethod_108().Items.AddRange(new object[]
			{
				"All",
				"Selected Unit",
				"Do not Show"
			});
			this.vmethod_108().Location = new Point(183, 175);
			this.vmethod_108().Name = "CP_ShowFlightPlans_Airborne";
			this.vmethod_108().Size = new Size(245, 21);
			this.vmethod_108().TabIndex = 32;
			this.vmethod_110().method_2(true);
			this.vmethod_110().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_110().Location = new Point(8, 178);
			this.vmethod_110().Name = "Label20";
			this.vmethod_110().Size = new Size(169, 13);
			this.vmethod_110().TabIndex = 31;
			this.vmethod_110().Text = "Show flightplans (airborne a/c):";
			this.vmethod_64().AutoSize = true;
			this.vmethod_64().Location = new Point(11, 233);
			this.vmethod_64().Name = "CB_ShowDiagnostics";
			this.vmethod_64().Size = new Size(118, 17);
			this.vmethod_64().TabIndex = 29;
			this.vmethod_64().Text = "Show Diagnostics";
			this.vmethod_52().AutoSize = true;
			this.vmethod_52().Location = new Point(11, 279);
			this.vmethod_52().Name = "CB_PlacenameVisibility";
			this.vmethod_52().Size = new Size(184, 17);
			this.vmethod_52().TabIndex = 28;
			this.vmethod_52().Text = "Display country and city names";
			this.vmethod_40().BackColor = Color.Transparent;
			this.vmethod_40().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_40().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_40().Font = new Font("Segoe UI", 7f);
			this.vmethod_40().FormattingEnabled = true;
			this.vmethod_40().Items.AddRange(new object[]
			{
				"All",
				"Selected Unit",
				"Do not Show"
			});
			this.vmethod_40().Location = new Point(183, 148);
			this.vmethod_40().Name = "CP_ShowPlottedPaths";
			this.vmethod_40().Size = new Size(245, 21);
			this.vmethod_40().TabIndex = 26;
			this.vmethod_42().method_2(true);
			this.vmethod_42().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_42().Location = new Point(8, 151);
			this.vmethod_42().Name = "Label6";
			this.vmethod_42().Size = new Size(112, 13);
			this.vmethod_42().TabIndex = 25;
			this.vmethod_42().Text = "Show plotted paths:";
			this.vmethod_44().BackColor = Color.Transparent;
			this.vmethod_44().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_44().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_44().Font = new Font("Segoe UI", 7f);
			this.vmethod_44().FormattingEnabled = true;
			this.vmethod_44().Items.AddRange(new object[]
			{
				"All Groups",
				"Selected Groups",
				"Do not Show"
			});
			this.vmethod_44().Location = new Point(183, 121);
			this.vmethod_44().Name = "CP_ShowGhostedGroupMembers";
			this.vmethod_44().Size = new Size(245, 21);
			this.vmethod_44().TabIndex = 27;
			this.vmethod_46().method_2(true);
			this.vmethod_46().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_46().Location = new Point(8, 124);
			this.vmethod_46().Name = "Label5";
			this.vmethod_46().Size = new Size(169, 13);
			this.vmethod_46().TabIndex = 24;
			this.vmethod_46().Text = "Show ghosted group members:";
			this.vmethod_36().BackColor = Color.Transparent;
			this.vmethod_36().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_36().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_36().Font = new Font("Segoe UI", 7f);
			this.vmethod_36().FormattingEnabled = true;
			this.vmethod_36().Items.AddRange(new object[]
			{
				"NTDS + NATO APP-6",
				"Stylized",
				"Directional Stylized"
			});
			this.vmethod_36().Location = new Point(183, 94);
			this.vmethod_36().Name = "CB_MapSymbols";
			this.vmethod_36().Size = new Size(245, 21);
			this.vmethod_36().TabIndex = 23;
			this.vmethod_38().method_2(true);
			this.vmethod_38().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_38().Location = new Point(8, 97);
			this.vmethod_38().Name = "Label4";
			this.vmethod_38().Size = new Size(78, 13);
			this.vmethod_38().TabIndex = 22;
			this.vmethod_38().Text = "Map Symbols:";
			this.vmethod_26().BackColor = Color.Transparent;
			this.vmethod_26().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_26().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_26().Font = new Font("Segoe UI", 7f);
			this.vmethod_26().FormattingEnabled = true;
			this.vmethod_26().Items.AddRange(new object[]
			{
				"Show on cursor",
				"Show on bottom",
				"Do not show"
			});
			this.vmethod_26().Location = new Point(183, 67);
			this.vmethod_26().Name = "CB_MapCursorBox";
			this.vmethod_26().Size = new Size(245, 21);
			this.vmethod_26().TabIndex = 21;
			this.vmethod_48().method_2(true);
			this.vmethod_48().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_48().Location = new Point(8, 70);
			this.vmethod_48().Name = "Label3";
			this.vmethod_48().Size = new Size(162, 13);
			this.vmethod_48().TabIndex = 20;
			this.vmethod_48().Text = "Map Cursor Databox Visibility:";
			this.vmethod_28().BackColor = Color.Transparent;
			this.vmethod_28().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_28().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_28().Font = new Font("Segoe UI", 7f);
			this.vmethod_28().FormattingEnabled = true;
			this.vmethod_28().Items.AddRange(new object[]
			{
				"Normal",
				"Small",
				"Do not show"
			});
			this.vmethod_28().Location = new Point(183, 40);
			this.vmethod_28().Name = "CB_RefPointVisibility";
			this.vmethod_28().Size = new Size(245, 21);
			this.vmethod_28().TabIndex = 19;
			this.vmethod_30().method_2(true);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Location = new Point(8, 43);
			this.vmethod_30().Name = "Label2";
			this.vmethod_30().Size = new Size(137, 13);
			this.vmethod_30().TabIndex = 18;
			this.vmethod_30().Text = "Reference Point Visibility:";
			this.vmethod_32().BackColor = Color.Transparent;
			this.vmethod_32().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_32().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_32().Font = new Font("Segoe UI", 7f);
			this.vmethod_32().FormattingEnabled = true;
			this.vmethod_32().Items.AddRange(new object[]
			{
				"Normal",
				"Ghosted",
				"Do not show"
			});
			this.vmethod_32().Location = new Point(183, 13);
			this.vmethod_32().Name = "CB_SonobuoyVisibility";
			this.vmethod_32().Size = new Size(245, 21);
			this.vmethod_32().TabIndex = 17;
			this.vmethod_34().method_2(true);
			this.vmethod_34().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_34().Location = new Point(8, 16);
			this.vmethod_34().Name = "Label1";
			this.vmethod_34().Size = new Size(109, 13);
			this.vmethod_34().TabIndex = 16;
			this.vmethod_34().Text = "Sonobuoy Visibility:";
			this.vmethod_0().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Location = new Point(4, 24);
			this.vmethod_0().Name = "TabPage2";
			this.vmethod_0().Padding = new Padding(3);
			this.vmethod_0().Size = new Size(694, 442);
			this.vmethod_0().TabIndex = 2;
			this.vmethod_0().Text = "Message Log";
			this.vmethod_2().AllowUserToAddRows = false;
			this.vmethod_2().AllowUserToDeleteRows = false;
			this.vmethod_2().AllowUserToResizeColumns = false;
			this.vmethod_2().AllowUserToResizeRows = false;
			this.vmethod_2().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().BorderStyle = BorderStyle.None;
			this.vmethod_2().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_2().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font("Segoe UI", 8f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_2().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_2().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_2().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_116(),
				this.vmethod_118(),
				this.vmethod_120(),
				this.vmethod_122(),
				this.vmethod_124()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 8f);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_2().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_2().Dock = DockStyle.Fill;
			this.vmethod_2().EnableHeadersVisualStyles = false;
			this.vmethod_2().Location = new Point(3, 3);
			this.vmethod_2().Name = "DataGridView1";
			this.vmethod_2().RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_2().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_2().Size = new Size(688, 436);
			this.vmethod_2().TabIndex = 0;
			this.vmethod_116().DataPropertyName = "MessageType_Hidden";
			this.vmethod_116().HeaderText = "MessageType_Hidden";
			this.vmethod_116().Name = "MessageType_Hidden";
			this.vmethod_116().ReadOnly = true;
			this.vmethod_116().Visible = false;
			this.vmethod_118().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_118().DataPropertyName = "MessageType";
			this.vmethod_118().HeaderText = "Message Type";
			this.vmethod_118().Name = "MessageType";
			this.vmethod_118().ReadOnly = true;
			this.vmethod_118().Width = 93;
			this.vmethod_120().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_120().DataPropertyName = "MessageLog";
			this.vmethod_120().HeaderText = "Show on Message Log";
			this.vmethod_120().Name = "MessageLog";
			this.vmethod_122().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_122().DataPropertyName = "PopUp";
			this.vmethod_122().HeaderText = "Raise Pop-Up";
			this.vmethod_122().Name = "PopUp";
			this.vmethod_124().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_124().DataPropertyName = "ShowBalloon";
			this.vmethod_124().HeaderText = "Show Balloon";
			this.vmethod_124().Name = "Column_ShowBalloon";
			this.vmethod_16().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_16().Controls.Add(this.vmethod_20());
			this.vmethod_16().Controls.Add(this.vmethod_18());
			this.vmethod_16().Location = new Point(4, 24);
			this.vmethod_16().Name = "TabPage3";
			this.vmethod_16().Size = new Size(694, 442);
			this.vmethod_16().TabIndex = 3;
			this.vmethod_16().Text = "Sounds/Music";
			this.vmethod_20().AutoSize = true;
			this.vmethod_20().Location = new Point(8, 35);
			this.vmethod_20().Name = "CB_Music";
			this.vmethod_20().Size = new Size(143, 17);
			this.vmethod_20().TabIndex = 7;
			this.vmethod_20().Text = "Use background music";
			this.vmethod_18().AutoSize = true;
			this.vmethod_18().Location = new Point(8, 12);
			this.vmethod_18().Name = "CB_Sounds";
			this.vmethod_18().Size = new Size(117, 17);
			this.vmethod_18().TabIndex = 6;
			this.vmethod_18().Text = "Use game sounds";
			this.vmethod_66().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_66().Controls.Add(this.vmethod_68());
			this.vmethod_66().Controls.Add(this.vmethod_72());
			this.vmethod_66().Controls.Add(this.vmethod_80());
			this.vmethod_66().Controls.Add(this.vmethod_98());
			this.vmethod_66().Location = new Point(4, 24);
			this.vmethod_66().Name = "TabPage5";
			this.vmethod_66().Padding = new Padding(3);
			this.vmethod_66().Size = new Size(694, 442);
			this.vmethod_66().TabIndex = 5;
			this.vmethod_66().Text = "Game Speed";
			this.vmethod_68().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_68().Controls.Add(this.vmethod_70());
			this.vmethod_68().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_68().Location = new Point(0, 320);
			this.vmethod_68().Name = "GroupBox3";
			this.vmethod_68().Size = new Size(694, 46);
			this.vmethod_68().TabIndex = 7;
			this.vmethod_68().TabStop = false;
			this.vmethod_68().Text = "Optional: These are pretty useful features that will free up additional CPU cycles for game execution when disabled";
			this.vmethod_70().Location = new Point(10, 18);
			this.vmethod_70().Name = "CB_Autosave";
			this.vmethod_70().Size = new Size(660, 17);
			this.vmethod_70().TabIndex = 0;
			this.vmethod_70().Text = "Autosave: Saves the current scenario at 20 second intervals and put the files in the Scenario folder with name Autosave.scen";
			this.vmethod_72().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_72().Controls.Add(this.vmethod_74());
			this.vmethod_72().Controls.Add(this.vmethod_76());
			this.vmethod_72().Controls.Add(this.vmethod_78());
			this.vmethod_72().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_72().Location = new Point(0, 236);
			this.vmethod_72().Name = "GroupBox2";
			this.vmethod_72().Size = new Size(694, 78);
			this.vmethod_72().TabIndex = 6;
			this.vmethod_72().TabStop = false;
			this.vmethod_72().Text = "Recommended: Disabling these settings will improve speed in large scenarios or in small scenarios running at high time-compression";
			this.vmethod_74().AutoSize = true;
			this.vmethod_74().Location = new Point(10, 17);
			this.vmethod_74().Name = "CB_FriendlyRangeSymbols";
			this.vmethod_74().Size = new Size(144, 17);
			this.vmethod_74().TabIndex = 0;
			this.vmethod_74().Text = "Friendly range symbols";
			this.vmethod_76().AutoSize = true;
			this.vmethod_76().Location = new Point(10, 36);
			this.vmethod_76().Name = "CB_DisplayIlluminationVectors";
			this.vmethod_76().Size = new Size(167, 17);
			this.vmethod_76().TabIndex = 0;
			this.vmethod_76().Text = "Display illumination vectors";
			this.vmethod_78().AutoSize = true;
			this.vmethod_78().Location = new Point(10, 55);
			this.vmethod_78().Name = "CB_DisplayContactEmissions";
			this.vmethod_78().Size = new Size(172, 17);
			this.vmethod_78().TabIndex = 0;
			this.vmethod_78().Text = "Display all contact emissions";
			this.vmethod_80().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_80().Controls.Add(this.vmethod_106());
			this.vmethod_80().Controls.Add(this.vmethod_82());
			this.vmethod_80().Controls.Add(this.vmethod_84());
			this.vmethod_80().Controls.Add(this.vmethod_86());
			this.vmethod_80().Controls.Add(this.vmethod_88());
			this.vmethod_80().Controls.Add(this.vmethod_90());
			this.vmethod_80().Controls.Add(this.vmethod_92());
			this.vmethod_80().Controls.Add(this.vmethod_94());
			this.vmethod_80().Controls.Add(this.vmethod_96());
			this.vmethod_80().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_80().Location = new Point(0, 31);
			this.vmethod_80().Name = "GroupBox1";
			this.vmethod_80().Size = new Size(694, 199);
			this.vmethod_80().TabIndex = 5;
			this.vmethod_80().TabStop = false;
			this.vmethod_80().Text = "Highly recommended: These settings have huge impact on speed and should be deselected";
			this.vmethod_106().AutoSize = true;
			this.vmethod_106().Location = new Point(10, 21);
			this.vmethod_106().Name = "CB_ExtraMemoryProtection";
			this.vmethod_106().Size = new Size(151, 17);
			this.vmethod_106().TabIndex = 1;
			this.vmethod_106().Text = "Extra memory protection";
			this.vmethod_82().AutoSize = true;
			this.vmethod_82().Location = new Point(10, 116);
			this.vmethod_82().Name = "CB_DisplayTargetingVectors";
			this.vmethod_82().Size = new Size(171, 17);
			this.vmethod_82().TabIndex = 0;
			this.vmethod_82().Text = "Display all targeting vectors ";
			this.vmethod_84().AutoSize = true;
			this.vmethod_84().Location = new Point(10, 173);
			this.vmethod_84().Name = "CB_DisallowHighPerformancePowerScheme";
			this.vmethod_84().Size = new Size(310, 17);
			this.vmethod_84().TabIndex = 0;
			this.vmethod_84().Text = "Disallow switching to High-Performance power scheme";
			this.vmethod_86().AutoSize = true;
			this.vmethod_86().Location = new Point(10, 154);
			this.vmethod_86().Name = "CB_ShowGhostedGroupMembers";
			this.vmethod_86().Size = new Size(185, 17);
			this.vmethod_86().TabIndex = 0;
			this.vmethod_86().Text = "Show ghosted group members";
			this.vmethod_88().AutoSize = true;
			this.vmethod_88().Location = new Point(10, 135);
			this.vmethod_88().Name = "CB_DisplayDatalinks";
			this.vmethod_88().Size = new Size(128, 17);
			this.vmethod_88().TabIndex = 0;
			this.vmethod_88().Text = "Display all datalinks";
			this.vmethod_90().AutoSize = true;
			this.vmethod_90().Location = new Point(10, 97);
			this.vmethod_90().Name = "CB_DisplayMissionAreas";
			this.vmethod_90().Size = new Size(202, 17);
			this.vmethod_90().TabIndex = 0;
			this.vmethod_90().Text = "Display all mission areas / courses ";
			this.vmethod_92().AutoSize = true;
			this.vmethod_92().Location = new Point(10, 78);
			this.vmethod_92().Name = "CB_DisplayCountryAndCityNames";
			this.vmethod_92().Size = new Size(184, 17);
			this.vmethod_92().TabIndex = 0;
			this.vmethod_92().Text = "Display country and city names";
			this.vmethod_94().AutoSize = true;
			this.vmethod_94().Location = new Point(10, 59);
			this.vmethod_94().Name = "CB_CustomFineGrainedNavigation";
			this.vmethod_94().Size = new Size(234, 17);
			this.vmethod_94().TabIndex = 0;
			this.vmethod_94().Text = "Custom fine-grained navigation settings";
			this.vmethod_96().AutoSize = true;
			this.vmethod_96().Location = new Point(10, 40);
			this.vmethod_96().Name = "CB_NonFriendlyRangeSymbols";
			this.vmethod_96().Size = new Size(168, 17);
			this.vmethod_96().TabIndex = 0;
			this.vmethod_96().Text = "Non-friendly range symbols";
			this.vmethod_98().method_2(true);
			this.vmethod_98().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_98().Location = new Point(5, 10);
			this.vmethod_98().Name = "Label9";
			this.vmethod_98().Size = new Size(513, 13);
			this.vmethod_98().TabIndex = 4;
			this.vmethod_98().Text = "Deselect CPU-intensive features to reduce computer workload and improve game execution speed:";
			this.vmethod_126().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_126().Controls.Add(this.vmethod_130());
			this.vmethod_126().Controls.Add(this.vmethod_132());
			this.vmethod_126().Controls.Add(this.vmethod_128());
			this.vmethod_126().Location = new Point(4, 24);
			this.vmethod_126().Name = "TabPage6";
			this.vmethod_126().Padding = new Padding(3);
			this.vmethod_126().Size = new Size(694, 442);
			this.vmethod_126().TabIndex = 6;
			this.vmethod_126().Text = "Tacview";
			this.vmethod_130().method_14(null);
			this.vmethod_130().method_15(AutoCompleteMode.None);
			this.vmethod_130().method_13(AutoCompleteSource.None);
			this.vmethod_130().BackColor = Color.Transparent;
			this.vmethod_130().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_130().method_12(null);
			this.vmethod_130().method_18(null);
			this.vmethod_130().Location = new Point(140, 11);
			this.vmethod_130().method_2(32767);
			this.vmethod_130().method_7(false);
			this.vmethod_130().Name = "TB_TacviewPath";
			this.vmethod_130().method_3(false);
			this.vmethod_130().method_19(ScrollBars.None);
			this.vmethod_130().method_9(0);
			this.vmethod_130().Size = new Size(467, 20);
			this.vmethod_130().TabIndex = 3;
			this.vmethod_130().method_1(HorizontalAlignment.Left);
			this.vmethod_130().method_5(false);
			this.vmethod_130().method_10("");
			this.vmethod_132().BackColor = Color.Transparent;
			this.vmethod_132().DialogResult = DialogResult.None;
			this.vmethod_132().ForeColor = SystemColors.Control;
			this.vmethod_132().Location = new Point(613, 11);
			this.vmethod_132().Name = "Button_TacviewPath";
			this.vmethod_132().method_1(0);
			this.vmethod_132().Size = new Size(75, 20);
			this.vmethod_132().TabIndex = 4;
			this.vmethod_132().Text = "Select...";
			this.vmethod_128().method_2(true);
			this.vmethod_128().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_128().Location = new Point(6, 14);
			this.vmethod_128().Name = "DarkLabel1";
			this.vmethod_128().Size = new Size(134, 13);
			this.vmethod_128().TabIndex = 0;
			this.vmethod_128().Text = "Tacview executable path:";
			this.vmethod_142().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_142().Controls.Add(this.vmethod_144());
			this.vmethod_142().Location = new Point(4, 24);
			this.vmethod_142().Name = "TabPage7";
			this.vmethod_142().Padding = new Padding(3);
			this.vmethod_142().Size = new Size(694, 442);
			this.vmethod_142().TabIndex = 7;
			this.vmethod_142().Text = "Hover Info";
			this.vmethod_144().Dock = DockStyle.Fill;
			this.vmethod_144().Location = new Point(3, 3);
			this.vmethod_144().Name = "ElementHost1";
			this.vmethod_144().Size = new Size(688, 436);
			this.vmethod_144().TabIndex = 0;
			this.vmethod_144().Text = "ElementHost1";
			this.vmethod_144().Child = this.hoverInfoOptions_0;
			this.vmethod_134().FileName = "OpenFileDialog1";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(702, 470);
			base.Controls.Add(this.vmethod_8());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new Size(716, 503);
			base.Name = "Options";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Options";
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_4().PerformLayout();
			this.vmethod_24().ResumeLayout(false);
			this.vmethod_24().PerformLayout();
			this.vmethod_0().ResumeLayout(false);
			((ISupportInitialize)this.vmethod_2()).EndInit();
			this.vmethod_16().ResumeLayout(false);
			this.vmethod_16().PerformLayout();
			this.vmethod_66().ResumeLayout(false);
			this.vmethod_66().PerformLayout();
			this.vmethod_68().ResumeLayout(false);
			this.vmethod_72().ResumeLayout(false);
			this.vmethod_72().PerformLayout();
			this.vmethod_80().ResumeLayout(false);
			this.vmethod_80().PerformLayout();
			this.vmethod_126().ResumeLayout(false);
			this.vmethod_126().PerformLayout();
			this.vmethod_142().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x060082A6 RID: 33446 RVA: 0x0004F504 File Offset: 0x0004D704
		[CompilerGenerated]
		internal TabPage vmethod_0()
		{
			return this.tabPage_0;
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x0004F50C File Offset: 0x0004D70C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TabPage tabPage_7)
		{
			this.tabPage_0 = tabPage_7;
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x0004F515 File Offset: 0x0004D715
		[CompilerGenerated]
		internal Class114 vmethod_2()
		{
			return this.class114_0;
		}

		// Token: 0x060082A9 RID: 33449 RVA: 0x00469874 File Offset: 0x00467A74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class114 class114_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_46);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.CellContentClick -= value;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.CellContentClick += value;
			}
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x0004F51D File Offset: 0x0004D71D
		[CompilerGenerated]
		internal TabPage vmethod_4()
		{
			return this.tabPage_1;
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x0004F525 File Offset: 0x0004D725
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabPage tabPage_7)
		{
			this.tabPage_1 = tabPage_7;
		}

		// Token: 0x060082AC RID: 33452 RVA: 0x0004F52E File Offset: 0x0004D72E
		[CompilerGenerated]
		internal Class112 vmethod_6()
		{
			return this.class112_0;
		}

		// Token: 0x060082AD RID: 33453 RVA: 0x004698B8 File Offset: 0x00467AB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_25);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_0 = class112_28;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082AE RID: 33454 RVA: 0x0004F536 File Offset: 0x0004D736
		[CompilerGenerated]
		internal Control12 vmethod_8()
		{
			return this.control12_0;
		}

		// Token: 0x060082AF RID: 33455 RVA: 0x0004F53E File Offset: 0x0004D73E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control12 control12_1)
		{
			this.control12_0 = control12_1;
		}

		// Token: 0x060082B0 RID: 33456 RVA: 0x0004F547 File Offset: 0x0004D747
		[CompilerGenerated]
		internal Class112 vmethod_10()
		{
			return this.class112_1;
		}

		// Token: 0x060082B1 RID: 33457 RVA: 0x004698FC File Offset: 0x00467AFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_32);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_1 = class112_28;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082B2 RID: 33458 RVA: 0x0004F54F File Offset: 0x0004D74F
		[CompilerGenerated]
		internal Class112 vmethod_12()
		{
			return this.class112_2;
		}

		// Token: 0x060082B3 RID: 33459 RVA: 0x00469940 File Offset: 0x00467B40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_33);
			Class112 @class = this.class112_2;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_2 = class112_28;
			@class = this.class112_2;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082B4 RID: 33460 RVA: 0x0004F557 File Offset: 0x0004D757
		[CompilerGenerated]
		internal Class112 vmethod_14()
		{
			return this.class112_3;
		}

		// Token: 0x060082B5 RID: 33461 RVA: 0x00469984 File Offset: 0x00467B84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_34);
			Class112 @class = this.class112_3;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_3 = class112_28;
			@class = this.class112_3;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082B6 RID: 33462 RVA: 0x0004F55F File Offset: 0x0004D75F
		[CompilerGenerated]
		internal TabPage vmethod_16()
		{
			return this.tabPage_2;
		}

		// Token: 0x060082B7 RID: 33463 RVA: 0x0004F567 File Offset: 0x0004D767
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(TabPage tabPage_7)
		{
			this.tabPage_2 = tabPage_7;
		}

		// Token: 0x060082B8 RID: 33464 RVA: 0x0004F570 File Offset: 0x0004D770
		[CompilerGenerated]
		internal Class112 vmethod_18()
		{
			return this.class112_4;
		}

		// Token: 0x060082B9 RID: 33465 RVA: 0x004699C8 File Offset: 0x00467BC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_44);
			Class112 @class = this.class112_4;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_4 = class112_28;
			@class = this.class112_4;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082BA RID: 33466 RVA: 0x0004F578 File Offset: 0x0004D778
		[CompilerGenerated]
		internal Class112 vmethod_20()
		{
			return this.class112_5;
		}

		// Token: 0x060082BB RID: 33467 RVA: 0x00469A0C File Offset: 0x00467C0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_45);
			Class112 @class = this.class112_5;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_5 = class112_28;
			@class = this.class112_5;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082BC RID: 33468 RVA: 0x0004F580 File Offset: 0x0004D780
		[CompilerGenerated]
		internal Control9 vmethod_22()
		{
			return this.control9_0;
		}

		// Token: 0x060082BD RID: 33469 RVA: 0x00469A50 File Offset: 0x00467C50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_5);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_3;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060082BE RID: 33470 RVA: 0x0004F588 File Offset: 0x0004D788
		[CompilerGenerated]
		internal TabPage vmethod_24()
		{
			return this.tabPage_3;
		}

		// Token: 0x060082BF RID: 33471 RVA: 0x0004F590 File Offset: 0x0004D790
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(TabPage tabPage_7)
		{
			this.tabPage_3 = tabPage_7;
		}

		// Token: 0x060082C0 RID: 33472 RVA: 0x0004F599 File Offset: 0x0004D799
		[CompilerGenerated]
		internal Class2451 vmethod_26()
		{
			return this.class2451_0;
		}

		// Token: 0x060082C1 RID: 33473 RVA: 0x00469A94 File Offset: 0x00467C94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class2451 class2451_8)
		{
			EventHandler value = new EventHandler(this.method_38);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_8;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060082C2 RID: 33474 RVA: 0x0004F5A1 File Offset: 0x0004D7A1
		[CompilerGenerated]
		internal Class2451 vmethod_28()
		{
			return this.class2451_1;
		}

		// Token: 0x060082C3 RID: 33475 RVA: 0x00469AD8 File Offset: 0x00467CD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class2451 class2451_8)
		{
			EventHandler value = new EventHandler(this.method_37);
			Class2451 @class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_1 = class2451_8;
			@class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060082C4 RID: 33476 RVA: 0x0004F5A9 File Offset: 0x0004D7A9
		[CompilerGenerated]
		internal Class116 vmethod_30()
		{
			return this.class116_0;
		}

		// Token: 0x060082C5 RID: 33477 RVA: 0x0004F5B1 File Offset: 0x0004D7B1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class116 class116_12)
		{
			this.class116_0 = class116_12;
		}

		// Token: 0x060082C6 RID: 33478 RVA: 0x0004F5BA File Offset: 0x0004D7BA
		[CompilerGenerated]
		internal Class2451 vmethod_32()
		{
			return this.class2451_2;
		}

		// Token: 0x060082C7 RID: 33479 RVA: 0x00469B1C File Offset: 0x00467D1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class2451 class2451_8)
		{
			EventHandler value = new EventHandler(this.method_36);
			Class2451 @class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_2 = class2451_8;
			@class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060082C8 RID: 33480 RVA: 0x0004F5C2 File Offset: 0x0004D7C2
		[CompilerGenerated]
		internal Class116 vmethod_34()
		{
			return this.class116_1;
		}

		// Token: 0x060082C9 RID: 33481 RVA: 0x0004F5CA File Offset: 0x0004D7CA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Class116 class116_12)
		{
			this.class116_1 = class116_12;
		}

		// Token: 0x060082CA RID: 33482 RVA: 0x0004F5D3 File Offset: 0x0004D7D3
		[CompilerGenerated]
		internal Class2451 vmethod_36()
		{
			return this.class2451_3;
		}

		// Token: 0x060082CB RID: 33483 RVA: 0x00469B60 File Offset: 0x00467D60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class2451 class2451_8)
		{
			EventHandler value = new EventHandler(this.method_39);
			Class2451 @class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_3 = class2451_8;
			@class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060082CC RID: 33484 RVA: 0x0004F5DB File Offset: 0x0004D7DB
		[CompilerGenerated]
		internal Class116 vmethod_38()
		{
			return this.class116_2;
		}

		// Token: 0x060082CD RID: 33485 RVA: 0x0004F5E3 File Offset: 0x0004D7E3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Class116 class116_12)
		{
			this.class116_2 = class116_12;
		}

		// Token: 0x060082CE RID: 33486 RVA: 0x0004F5EC File Offset: 0x0004D7EC
		[CompilerGenerated]
		internal Class2451 vmethod_40()
		{
			return this.class2451_4;
		}

		// Token: 0x060082CF RID: 33487 RVA: 0x00469BA4 File Offset: 0x00467DA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Class2451 class2451_8)
		{
			EventHandler value = new EventHandler(this.method_40);
			Class2451 @class = this.class2451_4;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_4 = class2451_8;
			@class = this.class2451_4;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060082D0 RID: 33488 RVA: 0x0004F5F4 File Offset: 0x0004D7F4
		[CompilerGenerated]
		internal Class116 vmethod_42()
		{
			return this.class116_3;
		}

		// Token: 0x060082D1 RID: 33489 RVA: 0x0004F5FC File Offset: 0x0004D7FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Class116 class116_12)
		{
			this.class116_3 = class116_12;
		}

		// Token: 0x060082D2 RID: 33490 RVA: 0x0004F605 File Offset: 0x0004D805
		[CompilerGenerated]
		internal Class2451 vmethod_44()
		{
			return this.class2451_5;
		}

		// Token: 0x060082D3 RID: 33491 RVA: 0x00469BE8 File Offset: 0x00467DE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Class2451 class2451_8)
		{
			EventHandler value = new EventHandler(this.method_27);
			Class2451 @class = this.class2451_5;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_5 = class2451_8;
			@class = this.class2451_5;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060082D4 RID: 33492 RVA: 0x0004F60D File Offset: 0x0004D80D
		[CompilerGenerated]
		internal Class116 vmethod_46()
		{
			return this.class116_4;
		}

		// Token: 0x060082D5 RID: 33493 RVA: 0x0004F615 File Offset: 0x0004D815
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Class116 class116_12)
		{
			this.class116_4 = class116_12;
		}

		// Token: 0x060082D6 RID: 33494 RVA: 0x0004F61E File Offset: 0x0004D81E
		[CompilerGenerated]
		internal Class116 vmethod_48()
		{
			return this.class116_5;
		}

		// Token: 0x060082D7 RID: 33495 RVA: 0x0004F626 File Offset: 0x0004D826
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Class116 class116_12)
		{
			this.class116_5 = class116_12;
		}

		// Token: 0x060082D8 RID: 33496 RVA: 0x0004F62F File Offset: 0x0004D82F
		[CompilerGenerated]
		internal Class112 vmethod_50()
		{
			return this.class112_6;
		}

		// Token: 0x060082D9 RID: 33497 RVA: 0x00469C2C File Offset: 0x00467E2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_35);
			Class112 @class = this.class112_6;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_6 = class112_28;
			@class = this.class112_6;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082DA RID: 33498 RVA: 0x0004F637 File Offset: 0x0004D837
		[CompilerGenerated]
		internal Class112 vmethod_52()
		{
			return this.class112_7;
		}

		// Token: 0x060082DB RID: 33499 RVA: 0x00469C70 File Offset: 0x00467E70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_26);
			Class112 @class = this.class112_7;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_7 = class112_28;
			@class = this.class112_7;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082DC RID: 33500 RVA: 0x0004F63F File Offset: 0x0004D83F
		[CompilerGenerated]
		internal Class112 vmethod_54()
		{
			return this.class112_8;
		}

		// Token: 0x060082DD RID: 33501 RVA: 0x00469CB4 File Offset: 0x00467EB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_24);
			Class112 @class = this.class112_8;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_8 = class112_28;
			@class = this.class112_8;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082DE RID: 33502 RVA: 0x0004F647 File Offset: 0x0004D847
		[CompilerGenerated]
		internal Control8 vmethod_56()
		{
			return this.control8_0;
		}

		// Token: 0x060082DF RID: 33503 RVA: 0x00469CF8 File Offset: 0x00467EF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(Control8 control8_3)
		{
			EventHandler value = new EventHandler(this.method_8);
			EventHandler value2 = new EventHandler(this.method_9);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.Enter -= value;
				control.Leave -= value2;
			}
			this.control8_0 = control8_3;
			control = this.control8_0;
			if (control != null)
			{
				control.Enter += value;
				control.Leave += value2;
			}
		}

		// Token: 0x060082E0 RID: 33504 RVA: 0x0004F64F File Offset: 0x0004D84F
		[CompilerGenerated]
		internal Control8 vmethod_58()
		{
			return this.control8_1;
		}

		// Token: 0x060082E1 RID: 33505 RVA: 0x00469D58 File Offset: 0x00467F58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(Control8 control8_3)
		{
			EventHandler value = new EventHandler(this.method_6);
			EventHandler value2 = new EventHandler(this.method_7);
			Control8 control = this.control8_1;
			if (control != null)
			{
				control.Enter -= value;
				control.Leave -= value2;
			}
			this.control8_1 = control8_3;
			control = this.control8_1;
			if (control != null)
			{
				control.Enter += value;
				control.Leave += value2;
			}
		}

		// Token: 0x060082E2 RID: 33506 RVA: 0x0004F657 File Offset: 0x0004D857
		[CompilerGenerated]
		internal Class116 vmethod_60()
		{
			return this.class116_6;
		}

		// Token: 0x060082E3 RID: 33507 RVA: 0x0004F65F File Offset: 0x0004D85F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(Class116 class116_12)
		{
			this.class116_6 = class116_12;
		}

		// Token: 0x060082E4 RID: 33508 RVA: 0x0004F668 File Offset: 0x0004D868
		[CompilerGenerated]
		internal Class116 vmethod_62()
		{
			return this.class116_7;
		}

		// Token: 0x060082E5 RID: 33509 RVA: 0x0004F670 File Offset: 0x0004D870
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(Class116 class116_12)
		{
			this.class116_7 = class116_12;
		}

		// Token: 0x060082E6 RID: 33510 RVA: 0x0004F679 File Offset: 0x0004D879
		[CompilerGenerated]
		internal Class112 vmethod_64()
		{
			return this.class112_9;
		}

		// Token: 0x060082E7 RID: 33511 RVA: 0x00469DB8 File Offset: 0x00467FB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_41);
			Class112 @class = this.class112_9;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_9 = class112_28;
			@class = this.class112_9;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082E8 RID: 33512 RVA: 0x0004F681 File Offset: 0x0004D881
		[CompilerGenerated]
		internal TabPage vmethod_66()
		{
			return this.tabPage_4;
		}

		// Token: 0x060082E9 RID: 33513 RVA: 0x0004F689 File Offset: 0x0004D889
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(TabPage tabPage_7)
		{
			this.tabPage_4 = tabPage_7;
		}

		// Token: 0x060082EA RID: 33514 RVA: 0x0004F692 File Offset: 0x0004D892
		[CompilerGenerated]
		internal Class115 vmethod_68()
		{
			return this.class115_0;
		}

		// Token: 0x060082EB RID: 33515 RVA: 0x0004F69A File Offset: 0x0004D89A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(Class115 class115_3)
		{
			this.class115_0 = class115_3;
		}

		// Token: 0x060082EC RID: 33516 RVA: 0x0004F6A3 File Offset: 0x0004D8A3
		[CompilerGenerated]
		internal Class112 vmethod_70()
		{
			return this.class112_10;
		}

		// Token: 0x060082ED RID: 33517 RVA: 0x00469DFC File Offset: 0x00467FFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_22);
			Class112 @class = this.class112_10;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_10 = class112_28;
			@class = this.class112_10;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082EE RID: 33518 RVA: 0x0004F6AB File Offset: 0x0004D8AB
		[CompilerGenerated]
		internal Class115 vmethod_72()
		{
			return this.class115_1;
		}

		// Token: 0x060082EF RID: 33519 RVA: 0x0004F6B3 File Offset: 0x0004D8B3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(Class115 class115_3)
		{
			this.class115_1 = class115_3;
		}

		// Token: 0x060082F0 RID: 33520 RVA: 0x0004F6BC File Offset: 0x0004D8BC
		[CompilerGenerated]
		internal Class112 vmethod_74()
		{
			return this.class112_11;
		}

		// Token: 0x060082F1 RID: 33521 RVA: 0x00469E40 File Offset: 0x00468040
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_19);
			Class112 @class = this.class112_11;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_11 = class112_28;
			@class = this.class112_11;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082F2 RID: 33522 RVA: 0x0004F6C4 File Offset: 0x0004D8C4
		[CompilerGenerated]
		internal Class112 vmethod_76()
		{
			return this.class112_12;
		}

		// Token: 0x060082F3 RID: 33523 RVA: 0x00469E84 File Offset: 0x00468084
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_20);
			Class112 @class = this.class112_12;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_12 = class112_28;
			@class = this.class112_12;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082F4 RID: 33524 RVA: 0x0004F6CC File Offset: 0x0004D8CC
		[CompilerGenerated]
		internal Class112 vmethod_78()
		{
			return this.class112_13;
		}

		// Token: 0x060082F5 RID: 33525 RVA: 0x00469EC8 File Offset: 0x004680C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_21);
			Class112 @class = this.class112_13;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_13 = class112_28;
			@class = this.class112_13;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082F6 RID: 33526 RVA: 0x0004F6D4 File Offset: 0x0004D8D4
		[CompilerGenerated]
		internal Class115 vmethod_80()
		{
			return this.class115_2;
		}

		// Token: 0x060082F7 RID: 33527 RVA: 0x0004F6DC File Offset: 0x0004D8DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(Class115 class115_3)
		{
			this.class115_2 = class115_3;
		}

		// Token: 0x060082F8 RID: 33528 RVA: 0x0004F6E5 File Offset: 0x0004D8E5
		[CompilerGenerated]
		internal Class112 vmethod_82()
		{
			return this.class112_14;
		}

		// Token: 0x060082F9 RID: 33529 RVA: 0x00469F0C File Offset: 0x0046810C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_16);
			Class112 @class = this.class112_14;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_14 = class112_28;
			@class = this.class112_14;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082FA RID: 33530 RVA: 0x0004F6ED File Offset: 0x0004D8ED
		[CompilerGenerated]
		internal Class112 vmethod_84()
		{
			return this.class112_15;
		}

		// Token: 0x060082FB RID: 33531 RVA: 0x00469F50 File Offset: 0x00468150
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_18);
			Class112 @class = this.class112_15;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_15 = class112_28;
			@class = this.class112_15;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082FC RID: 33532 RVA: 0x0004F6F5 File Offset: 0x0004D8F5
		[CompilerGenerated]
		internal Class112 vmethod_86()
		{
			return this.class112_16;
		}

		// Token: 0x060082FD RID: 33533 RVA: 0x00469F94 File Offset: 0x00468194
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_23);
			Class112 @class = this.class112_16;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_16 = class112_28;
			@class = this.class112_16;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060082FE RID: 33534 RVA: 0x0004F6FD File Offset: 0x0004D8FD
		[CompilerGenerated]
		internal Class112 vmethod_88()
		{
			return this.class112_17;
		}

		// Token: 0x060082FF RID: 33535 RVA: 0x00469FD8 File Offset: 0x004681D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_17);
			Class112 @class = this.class112_17;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_17 = class112_28;
			@class = this.class112_17;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008300 RID: 33536 RVA: 0x0004F705 File Offset: 0x0004D905
		[CompilerGenerated]
		internal Class112 vmethod_90()
		{
			return this.class112_18;
		}

		// Token: 0x06008301 RID: 33537 RVA: 0x0046A01C File Offset: 0x0046821C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_15);
			Class112 @class = this.class112_18;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_18 = class112_28;
			@class = this.class112_18;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008302 RID: 33538 RVA: 0x0004F70D File Offset: 0x0004D90D
		[CompilerGenerated]
		internal Class112 vmethod_92()
		{
			return this.class112_19;
		}

		// Token: 0x06008303 RID: 33539 RVA: 0x0046A060 File Offset: 0x00468260
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_14);
			Class112 @class = this.class112_19;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_19 = class112_28;
			@class = this.class112_19;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008304 RID: 33540 RVA: 0x0004F715 File Offset: 0x0004D915
		[CompilerGenerated]
		internal Class112 vmethod_94()
		{
			return this.class112_20;
		}

		// Token: 0x06008305 RID: 33541 RVA: 0x0046A0A4 File Offset: 0x004682A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_13);
			Class112 @class = this.class112_20;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_20 = class112_28;
			@class = this.class112_20;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008306 RID: 33542 RVA: 0x0004F71D File Offset: 0x0004D91D
		[CompilerGenerated]
		internal Class112 vmethod_96()
		{
			return this.class112_21;
		}

		// Token: 0x06008307 RID: 33543 RVA: 0x0046A0E8 File Offset: 0x004682E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_12);
			Class112 @class = this.class112_21;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_21 = class112_28;
			@class = this.class112_21;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008308 RID: 33544 RVA: 0x0004F725 File Offset: 0x0004D925
		[CompilerGenerated]
		internal Class116 vmethod_98()
		{
			return this.class116_8;
		}

		// Token: 0x06008309 RID: 33545 RVA: 0x0004F72D File Offset: 0x0004D92D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_99(Class116 class116_12)
		{
			this.class116_8 = class116_12;
		}

		// Token: 0x0600830A RID: 33546 RVA: 0x0004F736 File Offset: 0x0004D936
		[CompilerGenerated]
		internal Class112 vmethod_100()
		{
			return this.class112_22;
		}

		// Token: 0x0600830B RID: 33547 RVA: 0x0046A12C File Offset: 0x0046832C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_101(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_28);
			Class112 @class = this.class112_22;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_22 = class112_28;
			@class = this.class112_22;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600830C RID: 33548 RVA: 0x0004F73E File Offset: 0x0004D93E
		[CompilerGenerated]
		internal Class112 vmethod_102()
		{
			return this.class112_23;
		}

		// Token: 0x0600830D RID: 33549 RVA: 0x0046A170 File Offset: 0x00468370
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_103(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_29);
			Class112 @class = this.class112_23;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_23 = class112_28;
			@class = this.class112_23;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600830E RID: 33550 RVA: 0x0004F746 File Offset: 0x0004D946
		[CompilerGenerated]
		internal Class112 vmethod_104()
		{
			return this.class112_24;
		}

		// Token: 0x0600830F RID: 33551 RVA: 0x0046A1B4 File Offset: 0x004683B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_105(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_30);
			Class112 @class = this.class112_24;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_24 = class112_28;
			@class = this.class112_24;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008310 RID: 33552 RVA: 0x0004F74E File Offset: 0x0004D94E
		[CompilerGenerated]
		internal Class112 vmethod_106()
		{
			return this.class112_25;
		}

		// Token: 0x06008311 RID: 33553 RVA: 0x0046A1F8 File Offset: 0x004683F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_107(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_31);
			Class112 @class = this.class112_25;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_25 = class112_28;
			@class = this.class112_25;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008312 RID: 33554 RVA: 0x0004F756 File Offset: 0x0004D956
		[CompilerGenerated]
		internal Class2451 vmethod_108()
		{
			return this.class2451_6;
		}

		// Token: 0x06008313 RID: 33555 RVA: 0x0046A23C File Offset: 0x0046843C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_109(Class2451 class2451_8)
		{
			EventHandler value = new EventHandler(this.method_42);
			Class2451 @class = this.class2451_6;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_6 = class2451_8;
			@class = this.class2451_6;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06008314 RID: 33556 RVA: 0x0004F75E File Offset: 0x0004D95E
		[CompilerGenerated]
		internal Class116 vmethod_110()
		{
			return this.class116_9;
		}

		// Token: 0x06008315 RID: 33557 RVA: 0x0004F766 File Offset: 0x0004D966
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_111(Class116 class116_12)
		{
			this.class116_9 = class116_12;
		}

		// Token: 0x06008316 RID: 33558 RVA: 0x0004F76F File Offset: 0x0004D96F
		[CompilerGenerated]
		internal Class2451 vmethod_112()
		{
			return this.class2451_7;
		}

		// Token: 0x06008317 RID: 33559 RVA: 0x0046A280 File Offset: 0x00468480
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_113(Class2451 class2451_8)
		{
			EventHandler value = new EventHandler(this.method_43);
			Class2451 @class = this.class2451_7;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_7 = class2451_8;
			@class = this.class2451_7;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06008318 RID: 33560 RVA: 0x0004F777 File Offset: 0x0004D977
		[CompilerGenerated]
		internal Class116 vmethod_114()
		{
			return this.class116_10;
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x0004F77F File Offset: 0x0004D97F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_115(Class116 class116_12)
		{
			this.class116_10 = class116_12;
		}

		// Token: 0x0600831A RID: 33562 RVA: 0x0004F788 File Offset: 0x0004D988
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_116()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x0600831B RID: 33563 RVA: 0x0004F790 File Offset: 0x0004D990
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_117(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600831C RID: 33564 RVA: 0x0004F799 File Offset: 0x0004D999
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_118()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600831D RID: 33565 RVA: 0x0004F7A1 File Offset: 0x0004D9A1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_119(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600831E RID: 33566 RVA: 0x0004F7AA File Offset: 0x0004D9AA
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_120()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x0600831F RID: 33567 RVA: 0x0004F7B2 File Offset: 0x0004D9B2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_121(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_3;
		}

		// Token: 0x06008320 RID: 33568 RVA: 0x0004F7BB File Offset: 0x0004D9BB
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_122()
		{
			return this.dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x06008321 RID: 33569 RVA: 0x0004F7C3 File Offset: 0x0004D9C3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_123(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3)
		{
			this.dataGridViewCheckBoxColumn_1 = dataGridViewCheckBoxColumn_3;
		}

		// Token: 0x06008322 RID: 33570 RVA: 0x0004F7CC File Offset: 0x0004D9CC
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_124()
		{
			return this.dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x06008323 RID: 33571 RVA: 0x0004F7D4 File Offset: 0x0004D9D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_125(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3)
		{
			this.dataGridViewCheckBoxColumn_2 = dataGridViewCheckBoxColumn_3;
		}

		// Token: 0x06008324 RID: 33572 RVA: 0x0004F7DD File Offset: 0x0004D9DD
		[CompilerGenerated]
		internal TabPage vmethod_126()
		{
			return this.tabPage_5;
		}

		// Token: 0x06008325 RID: 33573 RVA: 0x0004F7E5 File Offset: 0x0004D9E5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_127(TabPage tabPage_7)
		{
			this.tabPage_5 = tabPage_7;
		}

		// Token: 0x06008326 RID: 33574 RVA: 0x0004F7EE File Offset: 0x0004D9EE
		[CompilerGenerated]
		internal Class116 vmethod_128()
		{
			return this.class116_11;
		}

		// Token: 0x06008327 RID: 33575 RVA: 0x0004F7F6 File Offset: 0x0004D9F6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_129(Class116 class116_12)
		{
			this.class116_11 = class116_12;
		}

		// Token: 0x06008328 RID: 33576 RVA: 0x0004F7FF File Offset: 0x0004D9FF
		[CompilerGenerated]
		internal Control8 vmethod_130()
		{
			return this.control8_2;
		}

		// Token: 0x06008329 RID: 33577 RVA: 0x0004F807 File Offset: 0x0004DA07
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_131(Control8 control8_3)
		{
			this.control8_2 = control8_3;
		}

		// Token: 0x0600832A RID: 33578 RVA: 0x0004F810 File Offset: 0x0004DA10
		[CompilerGenerated]
		internal Control9 vmethod_132()
		{
			return this.control9_1;
		}

		// Token: 0x0600832B RID: 33579 RVA: 0x0046A2C4 File Offset: 0x004684C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_133(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_47);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_3;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600832C RID: 33580 RVA: 0x0004F818 File Offset: 0x0004DA18
		[CompilerGenerated]
		internal OpenFileDialog vmethod_134()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x0600832D RID: 33581 RVA: 0x0004F820 File Offset: 0x0004DA20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_135(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x0600832E RID: 33582 RVA: 0x0004F829 File Offset: 0x0004DA29
		[CompilerGenerated]
		internal Control9 vmethod_136()
		{
			return this.control9_2;
		}

		// Token: 0x0600832F RID: 33583 RVA: 0x0046A308 File Offset: 0x00468508
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_137(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_49);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_3;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008330 RID: 33584 RVA: 0x0004F831 File Offset: 0x0004DA31
		[CompilerGenerated]
		internal Class112 vmethod_138()
		{
			return this.class112_26;
		}

		// Token: 0x06008331 RID: 33585 RVA: 0x0046A34C File Offset: 0x0046854C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_139(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_48);
			Class112 @class = this.class112_26;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_26 = class112_28;
			@class = this.class112_26;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008332 RID: 33586 RVA: 0x0004F839 File Offset: 0x0004DA39
		[CompilerGenerated]
		internal Class112 vmethod_140()
		{
			return this.class112_27;
		}

		// Token: 0x06008333 RID: 33587 RVA: 0x0046A390 File Offset: 0x00468590
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_141(Class112 class112_28)
		{
			EventHandler value = new EventHandler(this.method_50);
			Class112 @class = this.class112_27;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_27 = class112_28;
			@class = this.class112_27;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008334 RID: 33588 RVA: 0x0004F841 File Offset: 0x0004DA41
		[CompilerGenerated]
		internal TabPage vmethod_142()
		{
			return this.tabPage_6;
		}

		// Token: 0x06008335 RID: 33589 RVA: 0x0004F849 File Offset: 0x0004DA49
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_143(TabPage tabPage_7)
		{
			this.tabPage_6 = tabPage_7;
		}

		// Token: 0x06008336 RID: 33590 RVA: 0x0004F852 File Offset: 0x0004DA52
		[CompilerGenerated]
		internal ElementHost vmethod_144()
		{
			return this.elementHost_0;
		}

		// Token: 0x06008337 RID: 33591 RVA: 0x0004F85A File Offset: 0x0004DA5A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_145(ElementHost elementHost_1)
		{
			this.elementHost_0 = elementHost_1;
		}

		// Token: 0x06008338 RID: 33592 RVA: 0x0046A3D4 File Offset: 0x004685D4
		private void Options_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_112().Visible = false;
			this.vmethod_108().Visible = false;
			this.vmethod_114().Visible = false;
			this.vmethod_110().Visible = false;
			if (!GameGeneral.bool_0)
			{
				this.vmethod_8().TabPages.RemoveAt(5);
			}
			this.class280_0 = Class570.class280_0;
			this.method_3();
		}

		// Token: 0x06008339 RID: 33593 RVA: 0x0046A450 File Offset: 0x00468650
		private void method_3()
		{
			this.vmethod_6().Checked = this.class280_0.method_0();
			this.vmethod_64().Checked = this.class280_0.method_4();
			this.vmethod_10().Checked = this.class280_0.method_6();
			this.vmethod_18().Checked = this.class280_0.method_8();
			this.vmethod_20().Checked = this.class280_0.method_10();
			this.vmethod_12().Checked = this.class280_0.method_12();
			this.vmethod_14().Checked = this.class280_0.method_14();
			this.vmethod_32().SelectedIndex = (int)this.class280_0.method_16();
			this.vmethod_28().SelectedIndex = (int)this.class280_0.method_20();
			this.vmethod_36().SelectedIndex = (int)this.class280_0.method_22();
			this.vmethod_26().SelectedIndex = (int)this.class280_0.method_24();
			this.vmethod_44().SelectedIndex = (int)this.class280_0.method_28();
			this.vmethod_40().SelectedIndex = (int)this.class280_0.method_32();
			this.vmethod_108().SelectedIndex = (int)this.class280_0.method_34();
			this.vmethod_112().SelectedIndex = (int)this.class280_0.method_36();
			this.vmethod_58().Text = Conversions.ToString(this.class280_0.method_38());
			this.vmethod_56().Text = Conversions.ToString(this.class280_0.method_40());
			this.vmethod_100().Checked = this.class280_0.method_48();
			this.vmethod_102().Checked = this.class280_0.method_50();
			this.vmethod_104().Checked = this.class280_0.method_52();
			this.vmethod_50().Checked = this.class280_0.method_42();
			this.vmethod_52().Checked = this.class280_0.method_54();
			this.vmethod_54().Enabled = Class2473.smethod_2();
			this.vmethod_54().Checked = (this.class280_0.method_58() && Class2473.smethod_2());
			this.vmethod_138().Checked = this.class280_0.bool_19;
			this.vmethod_140().Checked = Client.smethod_52().method_27();
			this.method_4();
			this.vmethod_96().Checked = Client.smethod_52().method_25();
			this.vmethod_96().Enabled = this.vmethod_96().Checked;
			this.vmethod_94().Checked = (this.class280_0.method_38() != 8f || (double)this.class280_0.method_40() != 0.5);
			this.vmethod_94().Enabled = this.vmethod_94().Checked;
			this.vmethod_92().Checked = this.class280_0.method_54();
			this.vmethod_90().Checked = (Class570.class280_0.method_30() == Class279.Class280.Enum78.const_0);
			this.vmethod_90().Enabled = this.vmethod_90().Checked;
			this.vmethod_82().Checked = (Client.smethod_52().method_49() == Class285.Enum85.const_0);
			this.vmethod_82().Enabled = this.vmethod_82().Checked;
			this.vmethod_88().Checked = (Client.smethod_52().method_45() == Class285.Enum85.const_0);
			this.vmethod_88().Enabled = this.vmethod_88().Checked;
			this.vmethod_86().Checked = (this.class280_0.method_28() == Class279.Class280.Enum74.const_0 || this.class280_0.method_28() == Class279.Class280.Enum74.const_1);
			this.vmethod_86().Enabled = this.vmethod_86().Checked;
			this.vmethod_84().Enabled = Class2473.smethod_2();
			this.vmethod_84().Checked = (!this.class280_0.method_58() && Class2473.smethod_2());
			this.vmethod_106().Checked = this.class280_0.method_52();
			this.vmethod_74().Checked = (Client.smethod_52().method_57() == Class285.Enum85.const_0);
			this.vmethod_74().Enabled = this.vmethod_74().Checked;
			this.vmethod_76().Checked = (Client.smethod_52().method_51() == Class285.Enum85.const_0);
			this.vmethod_76().Enabled = this.vmethod_76().Checked;
			this.vmethod_78().Checked = (Client.smethod_52().method_53() == Class285.Enum85.const_0);
			this.vmethod_78().Enabled = this.vmethod_78().Checked;
			this.vmethod_70().Checked = this.class280_0.method_0();
			if (!string.IsNullOrEmpty(Class570.class280_0.method_62()))
			{
				this.vmethod_130().Text = Class570.class280_0.method_62();
			}
		}

		// Token: 0x0600833A RID: 33594 RVA: 0x0046A914 File Offset: 0x00468B14
		private void method_4()
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("MessageType_Hidden", typeof(string));
			dataTable.Columns.Add("MessageType", typeof(string));
			dataTable.Columns.Add("MessageLog", typeof(bool));
			dataTable.Columns.Add("PopUp", typeof(bool));
			dataTable.Columns.Add("ShowBalloon", typeof(bool));
			try
			{
				foreach (LoggedMessage.MessageType messageType in Class570.class280_0.dictionary_0.Keys)
				{
					if ((messageType != LoggedMessage.MessageType.CommsIsolatedMessage || Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_5)) && (messageType != LoggedMessage.MessageType.UnguidedWeaponModifiers || (false | GameGeneral.smethod_6())))
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow["MessageType_Hidden"] = messageType.ToString();
						dataRow["MessageType"] = Misc.smethod_22(messageType);
						dataRow["MessageLog"] = Class570.class280_0.dictionary_0[messageType].bool_0;
						dataRow["PopUp"] = Class570.class280_0.dictionary_0[messageType].bool_1;
						dataRow["ShowBalloon"] = Class570.class280_0.dictionary_0[messageType].bool_2;
						dataTable.Rows.Add(dataRow);
					}
				}
			}
			finally
			{
				Dictionary<LoggedMessage.MessageType, LoggedMessage.Class284>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.vmethod_2().DataSource = dataTable;
		}

		// Token: 0x0600833B RID: 33595 RVA: 0x000476BE File Offset: 0x000458BE
		private void Options_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x0600833C RID: 33596 RVA: 0x0004F863 File Offset: 0x0004DA63
		private void method_5(object sender, EventArgs e)
		{
			Class2566.dictionary_0.Clear();
			Class570.smethod_2(Class2566.dictionary_0, Client.list_1);
			DarkMessageBox.smethod_0("Positions & sizes of secondary windows have been reset to default values", "", Enum11.const_0);
		}

		// Token: 0x0600833D RID: 33597 RVA: 0x0004F88F File Offset: 0x0004DA8F
		private void Options_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.method_10();
			this.method_11();
			Class570.smethod_2(Class2566.dictionary_0, Client.list_1);
			base.Hide();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600833E RID: 33598 RVA: 0x0004F8C1 File Offset: 0x0004DAC1
		private void method_6(object sender, EventArgs e)
		{
			this.bool_3 = true;
			this.method_3();
		}

		// Token: 0x0600833F RID: 33599 RVA: 0x0004F8D0 File Offset: 0x0004DAD0
		private void method_7(object sender, EventArgs e)
		{
			this.method_10();
			this.method_3();
		}

		// Token: 0x06008340 RID: 33600 RVA: 0x0004F8DE File Offset: 0x0004DADE
		private void method_8(object sender, EventArgs e)
		{
			this.bool_4 = true;
			this.method_3();
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x0004F8ED File Offset: 0x0004DAED
		private void method_9(object sender, EventArgs e)
		{
			this.method_11();
			this.method_3();
		}

		// Token: 0x06008342 RID: 33602 RVA: 0x0046AAEC File Offset: 0x00468CEC
		private void method_10()
		{
			if (this.bool_3)
			{
				this.bool_3 = false;
				if (string.IsNullOrEmpty(this.vmethod_58().Text) || !Versioned.IsNumeric(this.vmethod_58().Text))
				{
					this.class280_0.method_39(0f);
					if (!Information.IsNothing(Client.smethod_46()))
					{
						Client.smethod_46().Navigation_FinegrainedMaxDistance = 0f;
					}
					this.vmethod_58().Text = "0";
					return;
				}
				if (Conversions.ToSingle(this.vmethod_58().Text) != Client.smethod_46().Navigation_FinegrainedMaxDistance)
				{
					DarkMessageBox.smethod_1(string.Concat(new string[]
					{
						"IMPORTANT NOTE! You have selected to use fine-grained navigation for distances up to ",
						this.vmethod_58().Text,
						" nm, and look for paths up to ",
						this.vmethod_56().Text,
						" degrees lat/lon outside the start and end points. Fine-grained navigation is extremely CPU intensive, and for instance a 50 nm course with 2 degrees lat/lon search area outside the start and end points may take up to five minutes to compute since it involves checking nearly one million (!) points. Do not alter these settings unless you know what you do. The default setting is 8 nm and 0.5 degrees."
					}), "", Enum11.const_0);
				}
				this.class280_0.method_39(Conversions.ToSingle(this.vmethod_58().Text));
				if (!Information.IsNothing(Client.smethod_46()))
				{
					Client.smethod_46().Navigation_FinegrainedMaxDistance = Conversions.ToSingle(this.vmethod_58().Text);
					return;
				}
			}
			else
			{
				this.bool_3 = false;
			}
		}

		// Token: 0x06008343 RID: 33603 RVA: 0x0046AC24 File Offset: 0x00468E24
		private void method_11()
		{
			if (this.bool_4)
			{
				this.bool_4 = false;
				if (string.IsNullOrEmpty(this.vmethod_56().Text) || !Versioned.IsNumeric(this.vmethod_56().Text))
				{
					this.class280_0.method_41(0f);
					if (!Information.IsNothing(Client.smethod_46()))
					{
						Client.smethod_46().Navigation_FinegrainedThresholdDistance = 0f;
					}
					this.vmethod_56().Text = "0";
					return;
				}
				if (Conversions.ToSingle(this.vmethod_56().Text) != Client.smethod_46().Navigation_FinegrainedThresholdDistance)
				{
					DarkMessageBox.smethod_1(string.Concat(new string[]
					{
						"IMPORTANT NOTE! You have selected to use fine-grained navigation for distances up to ",
						this.vmethod_58().Text,
						" nm, and look for paths up to ",
						this.vmethod_56().Text,
						" degrees lat/lon outside the start and end points. Fine-grained navigation is extremely CPU intensive, and for instance a 50 nm course with 2 degrees lat/lon search area outside the start and end points may take up to five minutes to compute since it involves checking nearly one million (!) points. Do not alter these settings unless you know what you do. The default setting is 8 nm and 0.5 degrees."
					}), "", Enum11.const_0);
				}
				this.class280_0.method_41(Conversions.ToSingle(this.vmethod_56().Text));
				if (!Information.IsNothing(Client.smethod_46()))
				{
					Client.smethod_46().Navigation_FinegrainedThresholdDistance = Conversions.ToSingle(this.vmethod_56().Text);
					return;
				}
			}
			else
			{
				this.bool_4 = false;
			}
		}

		// Token: 0x06008344 RID: 33604 RVA: 0x0046AD5C File Offset: 0x00468F5C
		private void method_12(object sender, EventArgs e)
		{
			if (!this.vmethod_96().Checked)
			{
				Client.smethod_52().method_26(false);
				Class2413.smethod_2().method_41().method_307();
				this.vmethod_96().Enabled = this.vmethod_96().Checked;
			}
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x06008345 RID: 33605 RVA: 0x0046ADB4 File Offset: 0x00468FB4
		private void method_13(object sender, EventArgs e)
		{
			if (!this.vmethod_94().Checked)
			{
				this.class280_0.method_39(8f);
				this.class280_0.method_41(0.5f);
				Client.smethod_46().Navigation_FinegrainedMaxDistance = 8f;
				Client.smethod_46().Navigation_FinegrainedThresholdDistance = 0.5f;
				this.vmethod_94().Enabled = false;
			}
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x06008346 RID: 33606 RVA: 0x0004F8FB File Offset: 0x0004DAFB
		private void method_14(object sender, EventArgs e)
		{
			this.class280_0.method_55(this.vmethod_92().Checked);
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x06008347 RID: 33607 RVA: 0x0046AE24 File Offset: 0x00469024
		private void method_15(object sender, EventArgs e)
		{
			if (!this.vmethod_90().Checked)
			{
				this.class280_0.method_31(Class279.Class280.Enum78.const_2);
				Class2413.smethod_2().method_41().method_307();
				this.vmethod_90().Enabled = false;
			}
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x06008348 RID: 33608 RVA: 0x0046AE74 File Offset: 0x00469074
		private void method_16(object sender, EventArgs e)
		{
			if (!this.vmethod_82().Checked)
			{
				Client.smethod_52().method_50(Class285.Enum85.const_2);
				Class2413.smethod_2().method_41().method_307();
				this.vmethod_82().Enabled = false;
			}
			else
			{
				Client.smethod_52().method_50(Class285.Enum85.const_0);
			}
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x06008349 RID: 33609 RVA: 0x0046AED0 File Offset: 0x004690D0
		private void method_17(object sender, EventArgs e)
		{
			if (!this.vmethod_88().Checked)
			{
				Client.smethod_52().method_46(Class285.Enum85.const_2);
				Class2413.smethod_2().method_41().method_307();
				this.vmethod_88().Enabled = false;
			}
			else
			{
				Client.smethod_52().method_46(Class285.Enum85.const_0);
			}
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x0600834A RID: 33610 RVA: 0x0004F91F File Offset: 0x0004DB1F
		private void method_18(object sender, EventArgs e)
		{
			this.class280_0.method_59(!this.vmethod_84().Checked);
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x0600834B RID: 33611 RVA: 0x0046AF2C File Offset: 0x0046912C
		private void method_19(object sender, EventArgs e)
		{
			if (!this.vmethod_74().Checked)
			{
				Client.smethod_52().method_58(Class285.Enum85.const_2);
				Class2413.smethod_2().method_41().method_307();
				this.vmethod_74().Enabled = false;
			}
			else
			{
				Client.smethod_52().method_58(Class285.Enum85.const_0);
			}
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x0600834C RID: 33612 RVA: 0x0046AF88 File Offset: 0x00469188
		private void method_20(object sender, EventArgs e)
		{
			if (!this.vmethod_76().Checked)
			{
				Client.smethod_52().method_52(Class285.Enum85.const_2);
				Class2413.smethod_2().method_41().method_307();
				this.vmethod_76().Enabled = false;
			}
			else
			{
				Client.smethod_52().method_52(Class285.Enum85.const_0);
			}
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x0600834D RID: 33613 RVA: 0x0046AFE4 File Offset: 0x004691E4
		private void method_21(object sender, EventArgs e)
		{
			if (!this.vmethod_78().Checked)
			{
				Client.smethod_52().method_54(Class285.Enum85.const_2);
				Class2413.smethod_2().method_41().method_307();
				this.vmethod_78().Enabled = false;
			}
			else
			{
				Client.smethod_52().method_54(Class285.Enum85.const_0);
			}
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x0600834E RID: 33614 RVA: 0x0004F946 File Offset: 0x0004DB46
		private void method_22(object sender, EventArgs e)
		{
			this.class280_0.method_1(this.vmethod_70().Checked);
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x0600834F RID: 33615 RVA: 0x0046B040 File Offset: 0x00469240
		private void method_23(object sender, EventArgs e)
		{
			if (!this.vmethod_86().Checked)
			{
				this.class280_0.method_29(Class279.Class280.Enum74.const_2);
				Class2413.smethod_2().method_41().method_307();
				this.vmethod_86().Enabled = false;
			}
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x06008350 RID: 33616 RVA: 0x0046B090 File Offset: 0x00469290
		private void method_24(object sender, EventArgs e)
		{
			bool flag = this.class280_0.method_58() != this.vmethod_54().Checked;
			this.class280_0.method_59(this.vmethod_54().Checked);
			if (flag)
			{
				if (this.class280_0.method_58())
				{
					Class2473.smethod_0();
				}
				else
				{
					Class2473.smethod_1();
				}
			}
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x06008351 RID: 33617 RVA: 0x0004F96A File Offset: 0x0004DB6A
		private void method_25(object sender, EventArgs e)
		{
			this.class280_0.method_1(this.vmethod_6().Checked);
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x06008352 RID: 33618 RVA: 0x0004F98E File Offset: 0x0004DB8E
		private void method_26(object sender, EventArgs e)
		{
			this.class280_0.method_55(this.vmethod_52().Checked);
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x06008353 RID: 33619 RVA: 0x0004F9B2 File Offset: 0x0004DBB2
		private void method_27(object sender, EventArgs e)
		{
			this.class280_0.method_29((Class279.Class280.Enum74)this.vmethod_44().SelectedIndex);
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x06008354 RID: 33620 RVA: 0x0004F9D7 File Offset: 0x0004DBD7
		private void method_28(object sender, EventArgs e)
		{
			this.class280_0.method_49(this.vmethod_100().Checked);
			Client.bool_1 = true;
		}

		// Token: 0x06008355 RID: 33621 RVA: 0x0004F9F5 File Offset: 0x0004DBF5
		private void method_29(object sender, EventArgs e)
		{
			this.class280_0.method_51(this.vmethod_102().Checked);
		}

		// Token: 0x06008356 RID: 33622 RVA: 0x0004FA0D File Offset: 0x0004DC0D
		private void method_30(object sender, EventArgs e)
		{
			this.class280_0.method_53(this.vmethod_104().Checked);
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x06008357 RID: 33623 RVA: 0x0004FA31 File Offset: 0x0004DC31
		private void method_31(object sender, EventArgs e)
		{
			this.class280_0.method_53(this.vmethod_106().Checked);
			Client.bool_1 = true;
			this.method_3();
		}

		// Token: 0x06008358 RID: 33624 RVA: 0x0004FA55 File Offset: 0x0004DC55
		private void method_32(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_41().method_175();
		}

		// Token: 0x06008359 RID: 33625 RVA: 0x0004FA66 File Offset: 0x0004DC66
		private void method_33(object sender, EventArgs e)
		{
			this.class280_0.method_13(this.vmethod_12().Checked);
		}

		// Token: 0x0600835A RID: 33626 RVA: 0x0004FA7E File Offset: 0x0004DC7E
		private void method_34(object sender, EventArgs e)
		{
			this.class280_0.method_15(this.vmethod_14().Checked);
		}

		// Token: 0x0600835B RID: 33627 RVA: 0x0004FA96 File Offset: 0x0004DC96
		private void method_35(object sender, EventArgs e)
		{
			this.class280_0.method_43(this.vmethod_50().Checked);
		}

		// Token: 0x0600835C RID: 33628 RVA: 0x0004FAAE File Offset: 0x0004DCAE
		private void method_36(object sender, EventArgs e)
		{
			this.class280_0.method_17((Class279.Class280.Enum69)this.vmethod_32().SelectedIndex);
			Class2413.smethod_2().method_41().method_307();
			Client.bool_1 = true;
		}

		// Token: 0x0600835D RID: 33629 RVA: 0x0004FADC File Offset: 0x0004DCDC
		private void method_37(object sender, EventArgs e)
		{
			this.class280_0.method_21((Class279.Class280.Enum71)this.vmethod_28().SelectedIndex);
			Class2413.smethod_2().method_41().method_307();
			Client.bool_1 = true;
		}

		// Token: 0x0600835E RID: 33630 RVA: 0x0004FB0A File Offset: 0x0004DD0A
		private void method_38(object sender, EventArgs e)
		{
			this.class280_0.method_25((Class279.Class280.Enum72)this.vmethod_26().SelectedIndex);
		}

		// Token: 0x0600835F RID: 33631 RVA: 0x0004FB23 File Offset: 0x0004DD23
		private void method_39(object sender, EventArgs e)
		{
			this.class280_0.method_23((Class279.Class280.Enum73)this.vmethod_36().SelectedIndex);
			Client.smethod_69();
		}

		// Token: 0x06008360 RID: 33632 RVA: 0x0004FB41 File Offset: 0x0004DD41
		private void method_40(object sender, EventArgs e)
		{
			this.class280_0.method_33((Class279.Class280.Enum75)this.vmethod_40().SelectedIndex);
		}

		// Token: 0x06008361 RID: 33633 RVA: 0x0004FB5A File Offset: 0x0004DD5A
		private void method_41(object sender, EventArgs e)
		{
			this.class280_0.method_5(this.vmethod_64().Checked);
		}

		// Token: 0x06008362 RID: 33634 RVA: 0x0004FB72 File Offset: 0x0004DD72
		private void method_42(object sender, EventArgs e)
		{
			this.class280_0.method_35((Class279.Class280.Enum76)this.vmethod_108().SelectedIndex);
			Class2413.smethod_2().method_41().method_307();
			Client.bool_1 = true;
		}

		// Token: 0x06008363 RID: 33635 RVA: 0x0004FBA0 File Offset: 0x0004DDA0
		private void method_43(object sender, EventArgs e)
		{
			this.class280_0.method_37((Class279.Class280.Enum77)this.vmethod_112().SelectedIndex);
			Client.bool_1 = true;
		}

		// Token: 0x06008364 RID: 33636 RVA: 0x0004FBBF File Offset: 0x0004DDBF
		private void method_44(object sender, EventArgs e)
		{
			this.class280_0.method_9(this.vmethod_18().Checked);
		}

		// Token: 0x06008365 RID: 33637 RVA: 0x0004FBD7 File Offset: 0x0004DDD7
		private void method_45(object sender, EventArgs e)
		{
			this.class280_0.method_11(this.vmethod_20().Checked);
			if (this.class280_0.method_10())
			{
				Class2561.smethod_1();
				return;
			}
			Class2561.class2559_0.method_1();
		}

		// Token: 0x06008366 RID: 33638 RVA: 0x0046B0F8 File Offset: 0x004692F8
		private void method_46(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex >= 2)
			{
				DataGridViewRow dataGridViewRow = this.vmethod_2().Rows[e.RowIndex];
				dataGridViewRow.Cells[e.ColumnIndex].Value = !Conversions.ToBoolean(dataGridViewRow.Cells[e.ColumnIndex].Value);
				string value = Conversions.ToString(dataGridViewRow.Cells[0].Value);
				LoggedMessage.MessageType key = (LoggedMessage.MessageType)Conversions.ToByte(Enum.Parse(typeof(LoggedMessage.MessageType), value, true));
				LoggedMessage.Class284 @class = Class570.class280_0.dictionary_0[key];
				@class.bool_0 = Conversions.ToBoolean(dataGridViewRow.Cells[2].Value);
				@class.bool_1 = Conversions.ToBoolean(dataGridViewRow.Cells[3].Value);
				@class.bool_2 = Conversions.ToBoolean(dataGridViewRow.Cells[4].Value);
			}
		}

		// Token: 0x06008367 RID: 33639 RVA: 0x0046B200 File Offset: 0x00469400
		private void method_47(object sender, EventArgs e)
		{
			this.vmethod_134().InitialDirectory = Class2413.smethod_1().Info.DirectoryPath;
			this.vmethod_134().Title = "Please locate the Tacview executable:";
			this.vmethod_134().DefaultExt = "*.exe";
			this.vmethod_134().FileName = "*.exe";
			if (this.vmethod_134().ShowDialog() == DialogResult.OK)
			{
				Class570.class280_0.method_63(this.vmethod_134().FileName);
				this.vmethod_130().Text = this.vmethod_134().FileName;
			}
		}

		// Token: 0x06008368 RID: 33640 RVA: 0x0046B290 File Offset: 0x00469490
		private void method_48(object sender, EventArgs e)
		{
			this.class280_0.bool_19 = this.vmethod_138().Checked;
			if (this.class280_0.bool_19 && this.class280_0.method_64() == null)
			{
				this.class280_0.method_65(Client.smethod_52());
			}
			Class2413.smethod_2().method_41().method_307();
		}

		// Token: 0x06008369 RID: 33641 RVA: 0x0004FC0C File Offset: 0x0004DE0C
		private void method_49(object sender, EventArgs e)
		{
			this.class280_0.method_65(Client.smethod_52());
		}

		// Token: 0x0600836A RID: 33642 RVA: 0x0004FC1E File Offset: 0x0004DE1E
		private void method_50(object sender, EventArgs e)
		{
			Client.smethod_52().method_28(this.vmethod_140().Checked);
			Client.bool_1 = true;
		}

		// Token: 0x040047AB RID: 18347
		[AccessedThroughProperty("TabPage2")]
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x040047AC RID: 18348
		[AccessedThroughProperty("DataGridView1")]
		[CompilerGenerated]
		private Class114 class114_0;

		// Token: 0x040047AD RID: 18349
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage1")]
		private TabPage tabPage_1;

		// Token: 0x040047AE RID: 18350
		[CompilerGenerated]
		[AccessedThroughProperty("CB_UseAutosave")]
		private Class112 class112_0;

		// Token: 0x040047AF RID: 18351
		[AccessedThroughProperty("TabControl1")]
		[CompilerGenerated]
		private Control12 control12_0;

		// Token: 0x040047B0 RID: 18352
		[CompilerGenerated]
		[AccessedThroughProperty("CB_MessageLogInWindow")]
		private Class112 class112_1;

		// Token: 0x040047B1 RID: 18353
		[AccessedThroughProperty("CB_AltitudeInFeet")]
		[CompilerGenerated]
		private Class112 class112_2;

		// Token: 0x040047B2 RID: 18354
		[AccessedThroughProperty("CB_ZoomOnCursor")]
		[CompilerGenerated]
		private Class112 class112_3;

		// Token: 0x040047B3 RID: 18355
		[AccessedThroughProperty("TabPage3")]
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x040047B4 RID: 18356
		[AccessedThroughProperty("CB_Sounds")]
		[CompilerGenerated]
		private Class112 class112_4;

		// Token: 0x040047B5 RID: 18357
		[AccessedThroughProperty("CB_Music")]
		[CompilerGenerated]
		private Class112 class112_5;

		// Token: 0x040047B6 RID: 18358
		[AccessedThroughProperty("Button_ResetWindowPlacement")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x040047B7 RID: 18359
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage4")]
		private TabPage tabPage_3;

		// Token: 0x040047B8 RID: 18360
		[AccessedThroughProperty("CB_MapCursorBox")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x040047B9 RID: 18361
		[CompilerGenerated]
		[AccessedThroughProperty("CB_RefPointVisibility")]
		private Class2451 class2451_1;

		// Token: 0x040047BA RID: 18362
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_0;

		// Token: 0x040047BB RID: 18363
		[AccessedThroughProperty("CB_SonobuoyVisibility")]
		[CompilerGenerated]
		private Class2451 class2451_2;

		// Token: 0x040047BC RID: 18364
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_1;

		// Token: 0x040047BD RID: 18365
		[CompilerGenerated]
		[AccessedThroughProperty("CB_MapSymbols")]
		private Class2451 class2451_3;

		// Token: 0x040047BE RID: 18366
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_2;

		// Token: 0x040047BF RID: 18367
		[CompilerGenerated]
		[AccessedThroughProperty("CP_ShowPlottedPaths")]
		private Class2451 class2451_4;

		// Token: 0x040047C0 RID: 18368
		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Class116 class116_3;

		// Token: 0x040047C1 RID: 18369
		[AccessedThroughProperty("CP_ShowGhostedGroupMembers")]
		[CompilerGenerated]
		private Class2451 class2451_5;

		// Token: 0x040047C2 RID: 18370
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x040047C3 RID: 18371
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_5;

		// Token: 0x040047C4 RID: 18372
		[AccessedThroughProperty("CB_UnitStatusImage")]
		[CompilerGenerated]
		private Class112 class112_6;

		// Token: 0x040047C5 RID: 18373
		[CompilerGenerated]
		[AccessedThroughProperty("CB_PlacenameVisibility")]
		private Class112 class112_7;

		// Token: 0x040047C6 RID: 18374
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AllowPowerScemeSwitch")]
		private Class112 class112_8;

		// Token: 0x040047C7 RID: 18375
		[AccessedThroughProperty("TB_Navigation_ThresholdDistanceDeg")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x040047C8 RID: 18376
		[AccessedThroughProperty("TB_Navigation_MaxDistanceNM")]
		[CompilerGenerated]
		private Control8 control8_1;

		// Token: 0x040047C9 RID: 18377
		[AccessedThroughProperty("Label8")]
		[CompilerGenerated]
		private Class116 class116_6;

		// Token: 0x040047CA RID: 18378
		[AccessedThroughProperty("Label7")]
		[CompilerGenerated]
		private Class116 class116_7;

		// Token: 0x040047CB RID: 18379
		[AccessedThroughProperty("CB_ShowDiagnostics")]
		[CompilerGenerated]
		private Class112 class112_9;

		// Token: 0x040047CC RID: 18380
		[AccessedThroughProperty("TabPage5")]
		[CompilerGenerated]
		private TabPage tabPage_4;

		// Token: 0x040047CD RID: 18381
		[AccessedThroughProperty("GroupBox3")]
		[CompilerGenerated]
		private Class115 class115_0;

		// Token: 0x040047CE RID: 18382
		[AccessedThroughProperty("CB_Autosave")]
		[CompilerGenerated]
		private Class112 class112_10;

		// Token: 0x040047CF RID: 18383
		[AccessedThroughProperty("GroupBox2")]
		[CompilerGenerated]
		private Class115 class115_1;

		// Token: 0x040047D0 RID: 18384
		[CompilerGenerated]
		[AccessedThroughProperty("CB_FriendlyRangeSymbols")]
		private Class112 class112_11;

		// Token: 0x040047D1 RID: 18385
		[CompilerGenerated]
		[AccessedThroughProperty("CB_DisplayIlluminationVectors")]
		private Class112 class112_12;

		// Token: 0x040047D2 RID: 18386
		[CompilerGenerated]
		[AccessedThroughProperty("CB_DisplayContactEmissions")]
		private Class112 class112_13;

		// Token: 0x040047D3 RID: 18387
		[AccessedThroughProperty("GroupBox1")]
		[CompilerGenerated]
		private Class115 class115_2;

		// Token: 0x040047D4 RID: 18388
		[AccessedThroughProperty("CB_DisplayTargetingVectors")]
		[CompilerGenerated]
		private Class112 class112_14;

		// Token: 0x040047D5 RID: 18389
		[AccessedThroughProperty("CB_DisallowHighPerformancePowerScheme")]
		[CompilerGenerated]
		private Class112 class112_15;

		// Token: 0x040047D6 RID: 18390
		[AccessedThroughProperty("CB_ShowGhostedGroupMembers")]
		[CompilerGenerated]
		private Class112 class112_16;

		// Token: 0x040047D7 RID: 18391
		[AccessedThroughProperty("CB_DisplayDatalinks")]
		[CompilerGenerated]
		private Class112 class112_17;

		// Token: 0x040047D8 RID: 18392
		[AccessedThroughProperty("CB_DisplayMissionAreas")]
		[CompilerGenerated]
		private Class112 class112_18;

		// Token: 0x040047D9 RID: 18393
		[AccessedThroughProperty("CB_DisplayCountryAndCityNames")]
		[CompilerGenerated]
		private Class112 class112_19;

		// Token: 0x040047DA RID: 18394
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CustomFineGrainedNavigation")]
		private Class112 class112_20;

		// Token: 0x040047DB RID: 18395
		[AccessedThroughProperty("CB_NonFriendlyRangeSymbols")]
		[CompilerGenerated]
		private Class112 class112_21;

		// Token: 0x040047DC RID: 18396
		[CompilerGenerated]
		[AccessedThroughProperty("Label9")]
		private Class116 class116_8;

		// Token: 0x040047DD RID: 18397
		[CompilerGenerated]
		[AccessedThroughProperty("CB_ShowGameSpeedButton")]
		private Class112 class112_22;

		// Token: 0x040047DE RID: 18398
		[CompilerGenerated]
		[AccessedThroughProperty("CB_LogDebugInfoToFile")]
		private Class112 class112_23;

		// Token: 0x040047DF RID: 18399
		[AccessedThroughProperty("CB_MemoryProtection")]
		[CompilerGenerated]
		private Class112 class112_24;

		// Token: 0x040047E0 RID: 18400
		[AccessedThroughProperty("CB_ExtraMemoryProtection")]
		[CompilerGenerated]
		private Class112 class112_25;

		// Token: 0x040047E1 RID: 18401
		[CompilerGenerated]
		[AccessedThroughProperty("CP_ShowFlightPlans_Airborne")]
		private Class2451 class2451_6;

		// Token: 0x040047E2 RID: 18402
		[AccessedThroughProperty("Label20")]
		[CompilerGenerated]
		private Class116 class116_9;

		// Token: 0x040047E3 RID: 18403
		[CompilerGenerated]
		[AccessedThroughProperty("CP_ShowFlightPlans_Planned")]
		private Class2451 class2451_7;

		// Token: 0x040047E4 RID: 18404
		[CompilerGenerated]
		[AccessedThroughProperty("Label11")]
		private Class116 class116_10;

		// Token: 0x040047E5 RID: 18405
		[CompilerGenerated]
		[AccessedThroughProperty("MessageType_Hidden")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x040047E6 RID: 18406
		[CompilerGenerated]
		[AccessedThroughProperty("MessageType")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x040047E7 RID: 18407
		[CompilerGenerated]
		[AccessedThroughProperty("MessageLog")]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x040047E8 RID: 18408
		[CompilerGenerated]
		[AccessedThroughProperty("PopUp")]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		// Token: 0x040047E9 RID: 18409
		[AccessedThroughProperty("Column_ShowBalloon")]
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

		// Token: 0x040047EA RID: 18410
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage6")]
		private TabPage tabPage_5;

		// Token: 0x040047EB RID: 18411
		[CompilerGenerated]
		[AccessedThroughProperty("DarkLabel1")]
		private Class116 class116_11;

		// Token: 0x040047EC RID: 18412
		[CompilerGenerated]
		[AccessedThroughProperty("TB_TacviewPath")]
		private Control8 control8_2;

		// Token: 0x040047ED RID: 18413
		[AccessedThroughProperty("Button_TacviewPath")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x040047EE RID: 18414
		[CompilerGenerated]
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x040047EF RID: 18415
		[CompilerGenerated]
		[AccessedThroughProperty("Button_SetPersonalMapProfile")]
		private Control9 control9_2;

		// Token: 0x040047F0 RID: 18416
		[AccessedThroughProperty("CB_UsePersonalMapProfile")]
		[CompilerGenerated]
		private Class112 class112_26;

		// Token: 0x040047F1 RID: 18417
		[CompilerGenerated]
		[AccessedThroughProperty("CB_ColorDatablocks")]
		private Class112 class112_27;

		// Token: 0x040047F2 RID: 18418
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage7")]
		private TabPage tabPage_6;

		// Token: 0x040047F3 RID: 18419
		[AccessedThroughProperty("ElementHost1")]
		[CompilerGenerated]
		private ElementHost elementHost_0;

		// Token: 0x040047F4 RID: 18420
		internal HoverInfoOptions hoverInfoOptions_0;

		// Token: 0x040047F5 RID: 18421
		private Class279.Class280 class280_0;

		// Token: 0x040047F6 RID: 18422
		private bool bool_3;

		// Token: 0x040047F7 RID: 18423
		private bool bool_4;
	}
}
