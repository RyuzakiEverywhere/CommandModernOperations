using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns2;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000E18 RID: 3608
	[DesignerGenerated]
	public sealed partial class FlightPlanAircraftLoadout : DarkSecondaryFormBase
	{
		// Token: 0x060069BB RID: 27067 RVA: 0x00396934 File Offset: 0x00394B34
		public FlightPlanAircraftLoadout()
		{
			base.FormClosing += this.FlightPlanAircraftLoadout_FormClosing;
			base.FormClosed += this.FlightPlanAircraftLoadout_FormClosed;
			base.Load += this.FlightPlanAircraftLoadout_Load;
			base.KeyDown += this.FlightPlanAircraftLoadout_KeyDown;
			base.VisibleChanged += this.FlightPlanAircraftLoadout_VisibleChanged;
			this.bool_3 = false;
			this.bool_4 = false;
			this.bool_5 = false;
			this.InitializeComponent_1();
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x003969FC File Offset: 0x00394BFC
		private void InitializeComponent_1()
		{
			this.vmethod_59(new Class116());
			this.vmethod_1(new Control4());
			this.vmethod_3(new Control4());
			this.vmethod_5(new Control4());
			this.vmethod_7(new Class2451());
			this.vmethod_61(new Class116());
			this.vmethod_63(new Control9());
			this.vmethod_65(new Control9());
			this.vmethod_9(new Control8());
			this.vmethod_89(new Class116());
			this.vmethod_91(new Class116());
			this.vmethod_93(new Class116());
			this.vmethod_95(new Class116());
			this.vmethod_97(new Class116());
			this.vmethod_67(new Class116());
			this.vmethod_69(new Class116());
			this.vmethod_71(new Class116());
			this.vmethod_73(new Class116());
			this.vmethod_75(new Class116());
			this.vmethod_77(new Class116());
			this.vmethod_79(new Class116());
			this.vmethod_99(new Class116());
			this.vmethod_101(new Class116());
			this.vmethod_81(new Class116());
			this.vmethod_83(new Class116());
			this.vmethod_103(new Class116());
			this.vmethod_85(new Class116());
			this.vmethod_87(new Class116());
			this.vmethod_11(new SplitContainer());
			this.vmethod_13(new SplitContainer());
			this.vmethod_15(new SplitContainer());
			this.vmethod_105(new Class116());
			this.vmethod_107(new Class116());
			this.vmethod_109(new Class116());
			this.vmethod_161(new Class116());
			this.vmethod_45(new Class2451());
			this.vmethod_47(new Class2451());
			this.vmethod_49(new Class2451());
			this.vmethod_51(new Class2451());
			this.vmethod_53(new Class2451());
			this.vmethod_55(new Class2451());
			this.vmethod_135(new Class116());
			this.vmethod_137(new Class116());
			this.vmethod_139(new Class116());
			this.vmethod_141(new Class116());
			this.vmethod_143(new Class116());
			this.vmethod_145(new Class116());
			this.vmethod_147(new Class116());
			this.vmethod_149(new Class116());
			this.vmethod_151(new Class116());
			this.vmethod_153(new Class116());
			this.vmethod_155(new Class112());
			this.vmethod_157(new Class116());
			this.vmethod_159(new Class116());
			this.vmethod_19(new Control8());
			this.vmethod_21(new Control8());
			this.vmethod_23(new Control8());
			this.vmethod_25(new Control8());
			this.vmethod_27(new Control8());
			this.vmethod_29(new Control8());
			this.vmethod_31(new Control8());
			this.vmethod_33(new Control8());
			this.vmethod_35(new Control8());
			this.vmethod_37(new Control8());
			this.vmethod_39(new Control8());
			this.vmethod_41(new Control8());
			this.vmethod_43(new Control8());
			this.vmethod_121(new Class112());
			this.vmethod_123(new Class112());
			this.vmethod_125(new Class112());
			this.vmethod_127(new Class112());
			this.vmethod_129(new Class112());
			this.vmethod_131(new Class112());
			this.vmethod_133(new Class112());
			this.vmethod_111(new Class116());
			this.vmethod_113(new Control9());
			this.vmethod_115(new Class116());
			this.vmethod_117(new Class116());
			this.vmethod_119(new Class116());
			this.vmethod_17(new Class2451());
			this.vmethod_57(new Class2451());
			this.vmethod_163(new Class116());
			((ISupportInitialize)this.vmethod_10()).BeginInit();
			this.vmethod_10().Panel1.SuspendLayout();
			this.vmethod_10().Panel2.SuspendLayout();
			this.vmethod_10().SuspendLayout();
			((ISupportInitialize)this.vmethod_12()).BeginInit();
			this.vmethod_12().Panel1.SuspendLayout();
			this.vmethod_12().Panel2.SuspendLayout();
			this.vmethod_12().SuspendLayout();
			((ISupportInitialize)this.vmethod_14()).BeginInit();
			this.vmethod_14().Panel1.SuspendLayout();
			this.vmethod_14().Panel2.SuspendLayout();
			this.vmethod_14().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_58().method_2(true);
			this.vmethod_58().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_58().Location = new Point(18, 29);
			this.vmethod_58().Name = "Label1";
			this.vmethod_58().Size = new Size(84, 15);
			this.vmethod_58().TabIndex = 0;
			this.vmethod_58().Text = "Form-up time:";
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().Location = new Point(3, 26);
			this.vmethod_0().Name = "ListBox_AircraftTypes";
			this.vmethod_0().Size = new Size(281, 255);
			this.vmethod_0().TabIndex = 16;
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().Location = new Point(3, 26);
			this.vmethod_2().Name = "ListBox_Loadouts";
			this.vmethod_2().Size = new Size(399, 255);
			this.vmethod_2().TabIndex = 17;
			this.vmethod_4().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_4().Location = new Point(8, 26);
			this.vmethod_4().Name = "ListBox_AssignedAircraft";
			this.vmethod_4().Size = new Size(685, 271);
			this.vmethod_4().TabIndex = 18;
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_6().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_6().Font = new Font("Segoe UI", 7f);
			this.vmethod_6().FormattingEnabled = true;
			this.vmethod_6().Location = new Point(82, 4);
			this.vmethod_6().Name = "ComboBox_FlightplanType";
			this.vmethod_6().Size = new Size(122, 21);
			this.vmethod_6().TabIndex = 39;
			this.vmethod_60().method_2(true);
			this.vmethod_60().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_60().Location = new Point(3, 8);
			this.vmethod_60().Name = "Label9";
			this.vmethod_60().Size = new Size(89, 15);
			this.vmethod_60().TabIndex = 38;
			this.vmethod_60().Text = "Flightplan type:";
			this.vmethod_62().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_62().BackColor = Color.Transparent;
			this.vmethod_62().DialogResult = DialogResult.None;
			this.vmethod_62().Font = new Font("Segoe UI", 10f);
			this.vmethod_62().ForeColor = SystemColors.Control;
			this.vmethod_62().Location = new Point(-1, 303);
			this.vmethod_62().Name = "Button_ClearSlots";
			this.vmethod_62().Padding = new Padding(5);
			this.vmethod_62().method_1(0);
			this.vmethod_62().Size = new Size(139, 24);
			this.vmethod_62().TabIndex = 41;
			this.vmethod_62().Text = "Clear a/c Slots";
			this.vmethod_64().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_64().BackColor = Color.Transparent;
			this.vmethod_64().DialogResult = DialogResult.None;
			this.vmethod_64().Font = new Font("Segoe UI", 10f);
			this.vmethod_64().ForeColor = SystemColors.Control;
			this.vmethod_64().Location = new Point(139, 303);
			this.vmethod_64().Name = "Button_FillEmptySlots";
			this.vmethod_64().Padding = new Padding(5);
			this.vmethod_64().method_1(0);
			this.vmethod_64().Size = new Size(139, 24);
			this.vmethod_64().TabIndex = 40;
			this.vmethod_64().Text = "Fill Empty a/c Slots";
			this.vmethod_8().method_14(null);
			this.vmethod_8().method_15(AutoCompleteMode.None);
			this.vmethod_8().method_13(AutoCompleteSource.None);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().method_17(new Font("Segoe UI", 8f));
			this.vmethod_8().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_8().method_12(null);
			this.vmethod_8().method_18(null);
			this.vmethod_8().Location = new Point(150, 26);
			this.vmethod_8().method_2(32767);
			this.vmethod_8().method_7(false);
			this.vmethod_8().Name = "TextBox_FormUpTime";
			this.vmethod_8().method_3(false);
			this.vmethod_8().method_9(0);
			this.vmethod_8().Size = new Size(122, 20);
			this.vmethod_8().TabIndex = 43;
			this.vmethod_8().method_1(HorizontalAlignment.Left);
			this.vmethod_8().method_5(false);
			this.vmethod_8().method_10("");
			this.vmethod_88().method_2(true);
			this.vmethod_88().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_88().Location = new Point(18, 597);
			this.vmethod_88().Name = "Label27";
			this.vmethod_88().Size = new Size(145, 15);
			this.vmethod_88().TabIndex = 19;
			this.vmethod_88().Text = "Fuel reserve loiter altitude:";
			this.vmethod_90().method_2(true);
			this.vmethod_90().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_90().Location = new Point(18, 576);
			this.vmethod_90().Name = "Label_ReserveLoiterTime";
			this.vmethod_90().Size = new Size(129, 15);
			this.vmethod_90().TabIndex = 18;
			this.vmethod_90().Text = "Fuel reserve loiter time:";
			this.vmethod_92().method_2(true);
			this.vmethod_92().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_92().Location = new Point(18, 555);
			this.vmethod_92().Name = "Label29";
			this.vmethod_92().Size = new Size(134, 15);
			this.vmethod_92().TabIndex = 17;
			this.vmethod_92().Text = "Fuel reserve percentage:";
			this.vmethod_94().method_2(true);
			this.vmethod_94().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_94().Location = new Point(18, 533);
			this.vmethod_94().Name = "Label26";
			this.vmethod_94().Size = new Size(101, 15);
			this.vmethod_94().TabIndex = 16;
			this.vmethod_94().Text = "Combat duration:";
			this.vmethod_96().method_2(true);
			this.vmethod_96().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_96().Location = new Point(18, 513);
			this.vmethod_96().Name = "Label25";
			this.vmethod_96().Size = new Size(95, 15);
			this.vmethod_96().TabIndex = 16;
			this.vmethod_96().Text = "Combat throttle:";
			this.vmethod_66().method_2(true);
			this.vmethod_66().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_66().Location = new Point(18, 324);
			this.vmethod_66().Name = "Label19";
			this.vmethod_66().Size = new Size(127, 15);
			this.vmethod_66().TabIndex = 15;
			this.vmethod_66().Text = "Attack egress distance:";
			this.vmethod_68().method_2(true);
			this.vmethod_68().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_68().Location = new Point(18, 240);
			this.vmethod_68().Name = "Label18";
			this.vmethod_68().Size = new Size(131, 15);
			this.vmethod_68().TabIndex = 14;
			this.vmethod_68().Text = "Attack ingress distance:";
			this.vmethod_70().method_2(true);
			this.vmethod_70().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_70().Location = new Point(18, 386);
			this.vmethod_70().Name = "Label15";
			this.vmethod_70().Size = new Size(122, 15);
			this.vmethod_70().TabIndex = 13;
			this.vmethod_70().Text = "Attack egress throttle:";
			this.vmethod_72().method_2(true);
			this.vmethod_72().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_72().Location = new Point(18, 344);
			this.vmethod_72().Name = "Label17";
			this.vmethod_72().Size = new Size(123, 15);
			this.vmethod_72().TabIndex = 11;
			this.vmethod_72().Text = "Attack egress altitude:";
			this.vmethod_74().method_2(true);
			this.vmethod_74().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_74().Location = new Point(18, 302);
			this.vmethod_74().Name = "Label12";
			this.vmethod_74().Size = new Size(126, 15);
			this.vmethod_74().TabIndex = 10;
			this.vmethod_74().Text = "Attack ingress throttle:";
			this.vmethod_76().method_2(true);
			this.vmethod_76().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_76().Location = new Point(18, 261);
			this.vmethod_76().Name = "Label14";
			this.vmethod_76().Size = new Size(127, 15);
			this.vmethod_76().TabIndex = 8;
			this.vmethod_76().Text = "Attack ingress altitude:";
			this.vmethod_78().method_2(true);
			this.vmethod_78().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_78().Location = new Point(18, 219);
			this.vmethod_78().Name = "Label8";
			this.vmethod_78().Size = new Size(121, 15);
			this.vmethod_78().TabIndex = 7;
			this.vmethod_78().Text = "Cruise egress throttle:";
			this.vmethod_98().method_2(true);
			this.vmethod_98().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_98().Location = new Point(18, 491);
			this.vmethod_98().Name = "Label24";
			this.vmethod_98().Size = new Size(96, 15);
			this.vmethod_98().TabIndex = 6;
			this.vmethod_98().Text = "Combat altitude:";
			this.vmethod_100().method_2(true);
			this.vmethod_100().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_100().Location = new Point(18, 469);
			this.vmethod_100().Name = "Label23";
			this.vmethod_100().Size = new Size(89, 15);
			this.vmethod_100().TabIndex = 6;
			this.vmethod_100().Text = "Station throttle:";
			this.vmethod_80().method_2(true);
			this.vmethod_80().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_80().Location = new Point(18, 155);
			this.vmethod_80().Name = "Label7";
			this.vmethod_80().Size = new Size(125, 15);
			this.vmethod_80().TabIndex = 6;
			this.vmethod_80().Text = "Cruise ingress throttle:";
			this.vmethod_82().method_2(true);
			this.vmethod_82().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_82().Location = new Point(18, 177);
			this.vmethod_82().Name = "Label6";
			this.vmethod_82().Size = new Size(122, 15);
			this.vmethod_82().TabIndex = 4;
			this.vmethod_82().Text = "Cruise egress altitude:";
			this.vmethod_102().method_2(true);
			this.vmethod_102().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_102().Location = new Point(18, 427);
			this.vmethod_102().Name = "Label21";
			this.vmethod_102().Size = new Size(90, 15);
			this.vmethod_102().TabIndex = 2;
			this.vmethod_102().Text = "Station altitude:";
			this.vmethod_84().method_2(true);
			this.vmethod_84().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_84().Location = new Point(18, 114);
			this.vmethod_84().Name = "Label3";
			this.vmethod_84().Size = new Size(126, 15);
			this.vmethod_84().TabIndex = 2;
			this.vmethod_84().Text = "Cruise ingress altitude:";
			this.vmethod_86().method_2(true);
			this.vmethod_86().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_86().Location = new Point(18, 50);
			this.vmethod_86().Name = "Label2";
			this.vmethod_86().Size = new Size(100, 15);
			this.vmethod_86().TabIndex = 1;
			this.vmethod_86().Text = "Form-up altitude:";
			this.vmethod_10().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_10().Location = new Point(4, 74);
			this.vmethod_10().Name = "SplitContainer3";
			this.vmethod_10().Panel1.Controls.Add(this.vmethod_12());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_160());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_44());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_46());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_48());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_50());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_52());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_54());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_134());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_136());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_138());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_140());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_142());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_144());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_146());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_148());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_150());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_152());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_154());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_156());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_158());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_18());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_20());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_22());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_24());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_26());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_28());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_30());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_32());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_34());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_36());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_38());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_40());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_42());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_120());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_122());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_124());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_126());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_128());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_130());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_132());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_110());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_88());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_8());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_90());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_92());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_94());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_58());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_96());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_86());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_98());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_84());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_66());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_102());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_68());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_70());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_82());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_72());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_74());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_80());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_100());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_76());
			this.vmethod_10().Panel2.Controls.Add(this.vmethod_78());
			this.vmethod_10().Size = new Size(1007, 615);
			this.vmethod_10().SplitterDistance = 696;
			this.vmethod_10().TabIndex = 44;
			this.vmethod_12().Dock = DockStyle.Fill;
			this.vmethod_12().Location = new Point(0, 0);
			this.vmethod_12().Name = "SplitContainer1";
			this.vmethod_12().Orientation = Orientation.Horizontal;
			this.vmethod_12().Panel1.Controls.Add(this.vmethod_14());
			this.vmethod_12().Panel2.Controls.Add(this.vmethod_108());
			this.vmethod_12().Panel2.Controls.Add(this.vmethod_62());
			this.vmethod_12().Panel2.Controls.Add(this.vmethod_4());
			this.vmethod_12().Panel2.Controls.Add(this.vmethod_64());
			this.vmethod_12().Size = new Size(696, 615);
			this.vmethod_12().SplitterDistance = 284;
			this.vmethod_12().TabIndex = 45;
			this.vmethod_14().Dock = DockStyle.Fill;
			this.vmethod_14().Location = new Point(0, 0);
			this.vmethod_14().Name = "SplitContainer2";
			this.vmethod_14().Panel1.Controls.Add(this.vmethod_104());
			this.vmethod_14().Panel1.Controls.Add(this.vmethod_0());
			this.vmethod_14().Panel2.Controls.Add(this.vmethod_106());
			this.vmethod_14().Panel2.Controls.Add(this.vmethod_2());
			this.vmethod_14().Size = new Size(696, 284);
			this.vmethod_14().SplitterDistance = 287;
			this.vmethod_14().TabIndex = 0;
			this.vmethod_104().method_2(true);
			this.vmethod_104().Font = new Font("Segoe UI", 12f);
			this.vmethod_104().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_104().Location = new Point(3, 3);
			this.vmethod_104().Name = "Label31";
			this.vmethod_104().Size = new Size(95, 21);
			this.vmethod_104().TabIndex = 17;
			this.vmethod_104().Text = "Aircraft type";
			this.vmethod_106().method_2(true);
			this.vmethod_106().Font = new Font("Segoe UI", 12f);
			this.vmethod_106().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_106().Location = new Point(3, 3);
			this.vmethod_106().Name = "Label32";
			this.vmethod_106().Size = new Size(101, 21);
			this.vmethod_106().TabIndex = 18;
			this.vmethod_106().Text = "Loadout type";
			this.vmethod_108().method_2(true);
			this.vmethod_108().Font = new Font("Segoe UI", 12f);
			this.vmethod_108().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_108().Location = new Point(3, 3);
			this.vmethod_108().Name = "Label30";
			this.vmethod_108().Size = new Size(126, 21);
			this.vmethod_108().TabIndex = 19;
			this.vmethod_108().Text = "Assigned aircraft";
			this.vmethod_160().method_2(true);
			this.vmethod_160().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_160().Location = new Point(278, 575);
			this.vmethod_160().Name = "Label4";
			this.vmethod_160().Size = new Size(28, 15);
			this.vmethod_160().TabIndex = 89;
			this.vmethod_160().Text = "min";
			this.vmethod_44().BackColor = Color.Transparent;
			this.vmethod_44().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_44().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_44().Font = new Font("Segoe UI", 7f);
			this.vmethod_44().FormattingEnabled = true;
			this.vmethod_44().Location = new Point(150, 465);
			this.vmethod_44().Name = "CB_StationThrottle";
			this.vmethod_44().Size = new Size(122, 21);
			this.vmethod_44().TabIndex = 88;
			this.vmethod_46().BackColor = Color.Transparent;
			this.vmethod_46().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_46().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_46().Font = new Font("Segoe UI", 7f);
			this.vmethod_46().FormattingEnabled = true;
			this.vmethod_46().Location = new Point(150, 382);
			this.vmethod_46().Name = "CB_AttackEgressThrottle";
			this.vmethod_46().Size = new Size(122, 21);
			this.vmethod_46().TabIndex = 87;
			this.vmethod_48().BackColor = Color.Transparent;
			this.vmethod_48().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_48().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_48().Font = new Font("Segoe UI", 7f);
			this.vmethod_48().FormattingEnabled = true;
			this.vmethod_48().Location = new Point(150, 298);
			this.vmethod_48().Name = "CB_AttackIngressThrottle";
			this.vmethod_48().Size = new Size(122, 21);
			this.vmethod_48().TabIndex = 86;
			this.vmethod_50().BackColor = Color.Transparent;
			this.vmethod_50().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_50().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_50().Font = new Font("Segoe UI", 7f);
			this.vmethod_50().FormattingEnabled = true;
			this.vmethod_50().Location = new Point(150, 214);
			this.vmethod_50().Name = "CB_CruiseEgressThrottle";
			this.vmethod_50().Size = new Size(122, 21);
			this.vmethod_50().TabIndex = 85;
			this.vmethod_52().BackColor = Color.Transparent;
			this.vmethod_52().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_52().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_52().Font = new Font("Segoe UI", 7f);
			this.vmethod_52().FormattingEnabled = true;
			this.vmethod_52().Location = new Point(150, 151);
			this.vmethod_52().Name = "CB_CruiseIngressThrottle";
			this.vmethod_52().Size = new Size(122, 21);
			this.vmethod_52().TabIndex = 84;
			this.vmethod_54().BackColor = Color.Transparent;
			this.vmethod_54().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_54().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_54().Font = new Font("Segoe UI", 7f);
			this.vmethod_54().FormattingEnabled = true;
			this.vmethod_54().Location = new Point(150, 508);
			this.vmethod_54().Name = "CB_CombatThrottle";
			this.vmethod_54().Size = new Size(122, 21);
			this.vmethod_54().TabIndex = 47;
			this.vmethod_134().method_2(true);
			this.vmethod_134().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_134().Location = new Point(278, 596);
			this.vmethod_134().Name = "Label47";
			this.vmethod_134().Size = new Size(18, 15);
			this.vmethod_134().TabIndex = 83;
			this.vmethod_134().Text = "m";
			this.vmethod_136().method_2(true);
			this.vmethod_136().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_136().Location = new Point(278, 533);
			this.vmethod_136().Name = "Label45";
			this.vmethod_136().Size = new Size(28, 15);
			this.vmethod_136().TabIndex = 81;
			this.vmethod_136().Text = "min";
			this.vmethod_138().method_2(true);
			this.vmethod_138().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_138().Location = new Point(278, 491);
			this.vmethod_138().Name = "Label44";
			this.vmethod_138().Size = new Size(18, 15);
			this.vmethod_138().TabIndex = 80;
			this.vmethod_138().Text = "m";
			this.vmethod_140().method_2(true);
			this.vmethod_140().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_140().Location = new Point(278, 324);
			this.vmethod_140().Name = "Label43";
			this.vmethod_140().Size = new Size(25, 15);
			this.vmethod_140().TabIndex = 79;
			this.vmethod_140().Text = "nm";
			this.vmethod_142().method_2(true);
			this.vmethod_142().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_142().Location = new Point(278, 343);
			this.vmethod_142().Name = "Label42";
			this.vmethod_142().Size = new Size(18, 15);
			this.vmethod_142().TabIndex = 78;
			this.vmethod_142().Text = "m";
			this.vmethod_144().method_2(true);
			this.vmethod_144().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_144().Location = new Point(278, 260);
			this.vmethod_144().Name = "Label41";
			this.vmethod_144().Size = new Size(18, 15);
			this.vmethod_144().TabIndex = 77;
			this.vmethod_144().Text = "m";
			this.vmethod_146().method_2(true);
			this.vmethod_146().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_146().Location = new Point(278, 239);
			this.vmethod_146().Name = "Label40";
			this.vmethod_146().Size = new Size(25, 15);
			this.vmethod_146().TabIndex = 76;
			this.vmethod_146().Text = "nm";
			this.vmethod_148().method_2(true);
			this.vmethod_148().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_148().Location = new Point(278, 176);
			this.vmethod_148().Name = "Label39";
			this.vmethod_148().Size = new Size(18, 15);
			this.vmethod_148().TabIndex = 75;
			this.vmethod_148().Text = "m";
			this.vmethod_150().method_2(true);
			this.vmethod_150().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_150().Location = new Point(278, 113);
			this.vmethod_150().Name = "Label_CruiseIngressAltitude";
			this.vmethod_150().Size = new Size(18, 15);
			this.vmethod_150().TabIndex = 74;
			this.vmethod_150().Text = "m";
			this.vmethod_152().method_2(true);
			this.vmethod_152().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_152().Location = new Point(278, 31);
			this.vmethod_152().Name = "Label_FormUpTime";
			this.vmethod_152().Size = new Size(28, 15);
			this.vmethod_152().TabIndex = 73;
			this.vmethod_152().Text = "min";
			this.vmethod_154().AutoSize = true;
			this.vmethod_154().Location = new Point(21, 91);
			this.vmethod_154().Name = "CB_CruiseOneWayOnly";
			this.vmethod_154().Size = new Size(132, 19);
			this.vmethod_154().TabIndex = 72;
			this.vmethod_154().Text = "Cruise one way only";
			this.vmethod_156().method_2(true);
			this.vmethod_156().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_156().Location = new Point(278, 50);
			this.vmethod_156().Name = "Label_FormUpAltitude";
			this.vmethod_156().Size = new Size(18, 15);
			this.vmethod_156().TabIndex = 71;
			this.vmethod_156().Text = "m";
			this.vmethod_158().method_2(true);
			this.vmethod_158().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_158().Location = new Point(278, 427);
			this.vmethod_158().Name = "Label_PatrolTransitAltitude_Aircraft";
			this.vmethod_158().Size = new Size(18, 15);
			this.vmethod_158().TabIndex = 70;
			this.vmethod_158().Text = "m";
			this.vmethod_18().method_14(null);
			this.vmethod_18().method_15(AutoCompleteMode.None);
			this.vmethod_18().method_13(AutoCompleteSource.None);
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().method_17(new Font("Segoe UI", 8f));
			this.vmethod_18().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_18().method_12(null);
			this.vmethod_18().method_18(null);
			this.vmethod_18().Location = new Point(150, 593);
			this.vmethod_18().method_2(32767);
			this.vmethod_18().method_7(false);
			this.vmethod_18().Name = "TextBox_ReserveLoiterAltitude";
			this.vmethod_18().method_3(false);
			this.vmethod_18().method_9(0);
			this.vmethod_18().Size = new Size(122, 20);
			this.vmethod_18().TabIndex = 69;
			this.vmethod_18().method_1(HorizontalAlignment.Left);
			this.vmethod_18().method_5(false);
			this.vmethod_18().method_10("");
			this.vmethod_20().method_14(null);
			this.vmethod_20().method_15(AutoCompleteMode.None);
			this.vmethod_20().method_13(AutoCompleteSource.None);
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().method_17(new Font("Segoe UI", 8f));
			this.vmethod_20().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_20().method_12(null);
			this.vmethod_20().method_18(null);
			this.vmethod_20().Location = new Point(150, 572);
			this.vmethod_20().method_2(32767);
			this.vmethod_20().method_7(false);
			this.vmethod_20().Name = "TextBox18";
			this.vmethod_20().method_3(false);
			this.vmethod_20().method_9(0);
			this.vmethod_20().Size = new Size(122, 20);
			this.vmethod_20().TabIndex = 68;
			this.vmethod_20().method_1(HorizontalAlignment.Left);
			this.vmethod_20().method_5(false);
			this.vmethod_20().method_10("");
			this.vmethod_22().method_14(null);
			this.vmethod_22().method_15(AutoCompleteMode.None);
			this.vmethod_22().method_13(AutoCompleteSource.None);
			this.vmethod_22().BackColor = Color.Transparent;
			this.vmethod_22().method_17(new Font("Segoe UI", 8f));
			this.vmethod_22().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_22().method_12(null);
			this.vmethod_22().method_18(null);
			this.vmethod_22().Location = new Point(150, 551);
			this.vmethod_22().method_2(32767);
			this.vmethod_22().method_7(false);
			this.vmethod_22().Name = "TextBox_ReservePercetage";
			this.vmethod_22().method_3(false);
			this.vmethod_22().method_9(0);
			this.vmethod_22().Size = new Size(122, 20);
			this.vmethod_22().TabIndex = 67;
			this.vmethod_22().method_1(HorizontalAlignment.Left);
			this.vmethod_22().method_5(false);
			this.vmethod_22().method_10("");
			this.vmethod_24().method_14(null);
			this.vmethod_24().method_15(AutoCompleteMode.None);
			this.vmethod_24().method_13(AutoCompleteSource.None);
			this.vmethod_24().BackColor = Color.Transparent;
			this.vmethod_24().method_17(new Font("Segoe UI", 8f));
			this.vmethod_24().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_24().method_12(null);
			this.vmethod_24().method_18(null);
			this.vmethod_24().Location = new Point(150, 530);
			this.vmethod_24().method_2(32767);
			this.vmethod_24().method_7(false);
			this.vmethod_24().Name = "TextBox_CombatDuration";
			this.vmethod_24().method_3(false);
			this.vmethod_24().method_9(0);
			this.vmethod_24().Size = new Size(122, 20);
			this.vmethod_24().TabIndex = 66;
			this.vmethod_24().method_1(HorizontalAlignment.Left);
			this.vmethod_24().method_5(false);
			this.vmethod_24().method_10("");
			this.vmethod_26().method_14(null);
			this.vmethod_26().method_15(AutoCompleteMode.None);
			this.vmethod_26().method_13(AutoCompleteSource.None);
			this.vmethod_26().BackColor = Color.Transparent;
			this.vmethod_26().method_17(new Font("Segoe UI", 8f));
			this.vmethod_26().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_26().method_12(null);
			this.vmethod_26().method_18(null);
			this.vmethod_26().Location = new Point(150, 487);
			this.vmethod_26().method_2(32767);
			this.vmethod_26().method_7(false);
			this.vmethod_26().Name = "TextBox_CombatAltitude";
			this.vmethod_26().method_3(false);
			this.vmethod_26().method_9(0);
			this.vmethod_26().Size = new Size(122, 20);
			this.vmethod_26().TabIndex = 65;
			this.vmethod_26().method_1(HorizontalAlignment.Left);
			this.vmethod_26().method_5(false);
			this.vmethod_26().method_10("");
			this.vmethod_28().method_14(null);
			this.vmethod_28().method_15(AutoCompleteMode.None);
			this.vmethod_28().method_13(AutoCompleteSource.None);
			this.vmethod_28().BackColor = Color.Transparent;
			this.vmethod_28().method_17(new Font("Segoe UI", 8f));
			this.vmethod_28().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_28().method_12(null);
			this.vmethod_28().method_18(null);
			this.vmethod_28().Location = new Point(150, 424);
			this.vmethod_28().method_2(32767);
			this.vmethod_28().method_7(false);
			this.vmethod_28().Name = "TextBox_StationAltitude";
			this.vmethod_28().method_3(false);
			this.vmethod_28().method_9(0);
			this.vmethod_28().Size = new Size(122, 20);
			this.vmethod_28().TabIndex = 63;
			this.vmethod_28().method_1(HorizontalAlignment.Left);
			this.vmethod_28().method_5(false);
			this.vmethod_28().method_10("");
			this.vmethod_30().method_14(null);
			this.vmethod_30().method_15(AutoCompleteMode.None);
			this.vmethod_30().method_13(AutoCompleteSource.None);
			this.vmethod_30().BackColor = Color.Transparent;
			this.vmethod_30().method_17(new Font("Segoe UI", 8f));
			this.vmethod_30().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_30().method_12(null);
			this.vmethod_30().method_18(null);
			this.vmethod_30().Location = new Point(150, 341);
			this.vmethod_30().method_2(32767);
			this.vmethod_30().method_7(false);
			this.vmethod_30().Name = "TextBox_AttackEgressAltitude";
			this.vmethod_30().method_3(false);
			this.vmethod_30().method_9(0);
			this.vmethod_30().Size = new Size(122, 20);
			this.vmethod_30().TabIndex = 61;
			this.vmethod_30().method_1(HorizontalAlignment.Left);
			this.vmethod_30().method_5(false);
			this.vmethod_30().method_10("");
			this.vmethod_32().method_14(null);
			this.vmethod_32().method_15(AutoCompleteMode.None);
			this.vmethod_32().method_13(AutoCompleteSource.None);
			this.vmethod_32().BackColor = Color.Transparent;
			this.vmethod_32().method_17(new Font("Segoe UI", 8f));
			this.vmethod_32().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_32().method_12(null);
			this.vmethod_32().method_18(null);
			this.vmethod_32().Location = new Point(150, 320);
			this.vmethod_32().method_2(32767);
			this.vmethod_32().method_7(false);
			this.vmethod_32().Name = "AttackEgressDistance";
			this.vmethod_32().method_3(false);
			this.vmethod_32().method_9(0);
			this.vmethod_32().Size = new Size(122, 20);
			this.vmethod_32().TabIndex = 60;
			this.vmethod_32().method_1(HorizontalAlignment.Left);
			this.vmethod_32().method_5(false);
			this.vmethod_32().method_10("");
			this.vmethod_34().method_14(null);
			this.vmethod_34().method_15(AutoCompleteMode.None);
			this.vmethod_34().method_13(AutoCompleteSource.None);
			this.vmethod_34().BackColor = Color.Transparent;
			this.vmethod_34().method_17(new Font("Segoe UI", 8f));
			this.vmethod_34().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_34().method_12(null);
			this.vmethod_34().method_18(null);
			this.vmethod_34().Location = new Point(150, 257);
			this.vmethod_34().method_2(32767);
			this.vmethod_34().method_7(false);
			this.vmethod_34().Name = "TextBox_AttackIngressAltitude";
			this.vmethod_34().method_3(false);
			this.vmethod_34().method_9(0);
			this.vmethod_34().Size = new Size(122, 20);
			this.vmethod_34().TabIndex = 58;
			this.vmethod_34().method_1(HorizontalAlignment.Left);
			this.vmethod_34().method_5(false);
			this.vmethod_34().method_10("");
			this.vmethod_36().method_14(null);
			this.vmethod_36().method_15(AutoCompleteMode.None);
			this.vmethod_36().method_13(AutoCompleteSource.None);
			this.vmethod_36().BackColor = Color.Transparent;
			this.vmethod_36().method_17(new Font("Segoe UI", 8f));
			this.vmethod_36().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_36().method_12(null);
			this.vmethod_36().method_18(null);
			this.vmethod_36().Location = new Point(150, 236);
			this.vmethod_36().method_2(32767);
			this.vmethod_36().method_7(false);
			this.vmethod_36().Name = "TextBox_AttackIngressDistance";
			this.vmethod_36().method_3(false);
			this.vmethod_36().method_9(0);
			this.vmethod_36().Size = new Size(122, 20);
			this.vmethod_36().TabIndex = 57;
			this.vmethod_36().method_1(HorizontalAlignment.Left);
			this.vmethod_36().method_5(false);
			this.vmethod_36().method_10("");
			this.vmethod_38().method_14(null);
			this.vmethod_38().method_15(AutoCompleteMode.None);
			this.vmethod_38().method_13(AutoCompleteSource.None);
			this.vmethod_38().BackColor = Color.Transparent;
			this.vmethod_38().method_17(new Font("Segoe UI", 8f));
			this.vmethod_38().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_38().method_12(null);
			this.vmethod_38().method_18(null);
			this.vmethod_38().Location = new Point(150, 173);
			this.vmethod_38().method_2(32767);
			this.vmethod_38().method_7(false);
			this.vmethod_38().Name = "CB_CruiseEgressAltitude";
			this.vmethod_38().method_3(false);
			this.vmethod_38().method_9(0);
			this.vmethod_38().Size = new Size(122, 20);
			this.vmethod_38().TabIndex = 55;
			this.vmethod_38().method_1(HorizontalAlignment.Left);
			this.vmethod_38().method_5(false);
			this.vmethod_38().method_10("");
			this.vmethod_40().method_14(null);
			this.vmethod_40().method_15(AutoCompleteMode.None);
			this.vmethod_40().method_13(AutoCompleteSource.None);
			this.vmethod_40().BackColor = Color.Transparent;
			this.vmethod_40().method_17(new Font("Segoe UI", 8f));
			this.vmethod_40().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_40().method_12(null);
			this.vmethod_40().method_18(null);
			this.vmethod_40().Location = new Point(150, 110);
			this.vmethod_40().method_2(32767);
			this.vmethod_40().method_7(false);
			this.vmethod_40().Name = "TextBox_CruiseIngressAltitude";
			this.vmethod_40().method_3(false);
			this.vmethod_40().method_9(0);
			this.vmethod_40().Size = new Size(122, 20);
			this.vmethod_40().TabIndex = 53;
			this.vmethod_40().method_1(HorizontalAlignment.Left);
			this.vmethod_40().method_5(false);
			this.vmethod_40().method_10("");
			this.vmethod_42().method_14(null);
			this.vmethod_42().method_15(AutoCompleteMode.None);
			this.vmethod_42().method_13(AutoCompleteSource.None);
			this.vmethod_42().BackColor = Color.Transparent;
			this.vmethod_42().method_17(new Font("Segoe UI", 8f));
			this.vmethod_42().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_42().method_12(null);
			this.vmethod_42().method_18(null);
			this.vmethod_42().Location = new Point(150, 47);
			this.vmethod_42().method_2(32767);
			this.vmethod_42().method_7(false);
			this.vmethod_42().Name = "TextBox_FormUpAltitude";
			this.vmethod_42().method_3(false);
			this.vmethod_42().method_9(0);
			this.vmethod_42().Size = new Size(122, 20);
			this.vmethod_42().TabIndex = 51;
			this.vmethod_42().method_1(HorizontalAlignment.Left);
			this.vmethod_42().method_5(false);
			this.vmethod_42().method_10("");
			this.vmethod_120().Location = new Point(21, 69);
			this.vmethod_120().Name = "CB_CruiseAtOptimumAltitude";
			this.vmethod_120().Size = new Size(226, 16);
			this.vmethod_120().TabIndex = 50;
			this.vmethod_120().Text = "Cruise at optimum altitude";
			this.vmethod_122().AutoSize = true;
			this.vmethod_122().Location = new Point(21, 446);
			this.vmethod_122().Name = "CB_StationTerrainFollowing";
			this.vmethod_122().Size = new Size(155, 19);
			this.vmethod_122().TabIndex = 49;
			this.vmethod_122().Text = "Station terrain-following";
			this.vmethod_124().Location = new Point(21, 363);
			this.vmethod_124().Name = "CB_AttackEgressTerrainFollowing";
			this.vmethod_124().Size = new Size(226, 13);
			this.vmethod_124().TabIndex = 48;
			this.vmethod_124().Text = "Attack egress terrain-following";
			this.vmethod_126().Location = new Point(21, 279);
			this.vmethod_126().Name = "CB_AttackIngressTerrainFollowing";
			this.vmethod_126().Size = new Size(271, 20);
			this.vmethod_126().TabIndex = 47;
			this.vmethod_126().Text = "Attack ingress terrain-following";
			this.vmethod_128().Location = new Point(21, 195);
			this.vmethod_128().Name = "CB_CruiseEgressTerrainFollowing";
			this.vmethod_128().Size = new Size(272, 21);
			this.vmethod_128().TabIndex = 46;
			this.vmethod_128().Text = "Cruise egress terrain-following";
			this.vmethod_130().Location = new Point(21, 132);
			this.vmethod_130().Name = "CB_CruiseIngressTerrainFollowing";
			this.vmethod_130().Size = new Size(251, 20);
			this.vmethod_130().TabIndex = 45;
			this.vmethod_130().Text = "Cruise ingress terrain-following";
			this.vmethod_132().AutoSize = true;
			this.vmethod_132().Location = new Point(21, 405);
			this.vmethod_132().Name = "CB_DropOrdnanceAtMaxRange";
			this.vmethod_132().Size = new Size(176, 19);
			this.vmethod_132().TabIndex = 44;
			this.vmethod_132().Text = "Drop ordnance at max range";
			this.vmethod_110().method_2(true);
			this.vmethod_110().Font = new Font("Segoe UI", 12f);
			this.vmethod_110().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_110().Location = new Point(21, 3);
			this.vmethod_110().Name = "Label33";
			this.vmethod_110().Size = new Size(55, 21);
			this.vmethod_110().TabIndex = 19;
			this.vmethod_110().Text = "Profile";
			this.vmethod_112().BackColor = Color.Transparent;
			this.vmethod_112().DialogResult = DialogResult.None;
			this.vmethod_112().Font = new Font("Segoe UI", 10f);
			this.vmethod_112().ForeColor = SystemColors.Control;
			this.vmethod_112().Location = new Point(558, 50);
			this.vmethod_112().Name = "Button_ChangeTakeOffLocation";
			this.vmethod_112().Padding = new Padding(5);
			this.vmethod_112().method_1(0);
			this.vmethod_112().Size = new Size(157, 21);
			this.vmethod_112().TabIndex = 49;
			this.vmethod_112().Text = "Change take-off location";
			this.vmethod_114().method_2(true);
			this.vmethod_114().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_114().Location = new Point(3, 53);
			this.vmethod_114().Name = "Label34";
			this.vmethod_114().Size = new Size(100, 15);
			this.vmethod_114().TabIndex = 48;
			this.vmethod_114().Text = "Take-off location:";
			this.vmethod_116().method_2(true);
			this.vmethod_116().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_116().Location = new Point(95, 53);
			this.vmethod_116().Name = "Label_TakeOffLocation";
			this.vmethod_116().Size = new Size(113, 15);
			this.vmethod_116().TabIndex = 47;
			this.vmethod_116().Text = "<Take-off location>";
			this.vmethod_118().method_2(true);
			this.vmethod_118().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_118().Location = new Point(226, 7);
			this.vmethod_118().Name = "Label35";
			this.vmethod_118().Size = new Size(102, 15);
			this.vmethod_118().TabIndex = 45;
			this.vmethod_118().Text = "Desired flight size:";
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_16().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_16().Font = new Font("Segoe UI", 7f);
			this.vmethod_16().FormattingEnabled = true;
			this.vmethod_16().Location = new Point(326, 4);
			this.vmethod_16().Name = "ComboBox_DesiredFlightSize";
			this.vmethod_16().Size = new Size(230, 21);
			this.vmethod_16().TabIndex = 46;
			this.vmethod_56().BackColor = Color.Transparent;
			this.vmethod_56().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_56().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_56().Font = new Font("Segoe UI", 7f);
			this.vmethod_56().FormattingEnabled = true;
			this.vmethod_56().Location = new Point(326, 26);
			this.vmethod_56().Name = "ComboBox_MinimumFlightSize";
			this.vmethod_56().Size = new Size(230, 21);
			this.vmethod_56().TabIndex = 91;
			this.vmethod_162().method_2(true);
			this.vmethod_162().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_162().Location = new Point(226, 29);
			this.vmethod_162().Name = "Label5";
			this.vmethod_162().Size = new Size(116, 15);
			this.vmethod_162().TabIndex = 90;
			this.vmethod_162().Text = "Minimum flight size:";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1008, 691);
			base.Controls.Add(this.vmethod_112());
			base.Controls.Add(this.vmethod_114());
			base.Controls.Add(this.vmethod_116());
			base.Controls.Add(this.vmethod_56());
			base.Controls.Add(this.vmethod_162());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_118());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_60());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new Size(1024, 730);
			base.Name = "FlightPlanAircraftLoadout";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Select Aircraft and Loadout for flight <FlightName>";
			this.vmethod_10().Panel1.ResumeLayout(false);
			this.vmethod_10().Panel2.ResumeLayout(false);
			this.vmethod_10().Panel2.PerformLayout();
			((ISupportInitialize)this.vmethod_10()).EndInit();
			this.vmethod_10().ResumeLayout(false);
			this.vmethod_12().Panel1.ResumeLayout(false);
			this.vmethod_12().Panel2.ResumeLayout(false);
			this.vmethod_12().Panel2.PerformLayout();
			((ISupportInitialize)this.vmethod_12()).EndInit();
			this.vmethod_12().ResumeLayout(false);
			this.vmethod_14().Panel1.ResumeLayout(false);
			this.vmethod_14().Panel1.PerformLayout();
			this.vmethod_14().Panel2.ResumeLayout(false);
			this.vmethod_14().Panel2.PerformLayout();
			((ISupportInitialize)this.vmethod_14()).EndInit();
			this.vmethod_14().ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060069BE RID: 27070 RVA: 0x0004315B File Offset: 0x0004135B
		[CompilerGenerated]
		internal Control4 vmethod_0()
		{
			return this.control4_0;
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x0039AB3C File Offset: 0x00398D3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control4 control4_3)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_18);
			MouseEventHandler value = new MouseEventHandler(this.method_20);
			Control4 control = this.control4_0;
			if (control != null)
			{
				control.method_17(eventHandler_);
				control.MouseDown -= value;
			}
			this.control4_0 = control4_3;
			control = this.control4_0;
			if (control != null)
			{
				control.method_16(eventHandler_);
				control.MouseDown += value;
			}
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x00043163 File Offset: 0x00041363
		[CompilerGenerated]
		internal Control4 vmethod_2()
		{
			return this.control4_1;
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x0039AB9C File Offset: 0x00398D9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control4 control4_3)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_19);
			MouseEventHandler value = new MouseEventHandler(this.method_21);
			Control4 control = this.control4_1;
			if (control != null)
			{
				control.method_17(eventHandler_);
				control.MouseDown -= value;
			}
			this.control4_1 = control4_3;
			control = this.control4_1;
			if (control != null)
			{
				control.method_16(eventHandler_);
				control.MouseDown += value;
			}
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x0004316B File Offset: 0x0004136B
		[CompilerGenerated]
		internal Control4 vmethod_4()
		{
			return this.control4_2;
		}

		// Token: 0x060069C3 RID: 27075 RVA: 0x0039ABFC File Offset: 0x00398DFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control4 control4_3)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_22);
			MouseEventHandler value = new MouseEventHandler(this.method_23);
			Control4 control = this.control4_2;
			if (control != null)
			{
				control.method_17(eventHandler_);
				control.MouseDown -= value;
			}
			this.control4_2 = control4_3;
			control = this.control4_2;
			if (control != null)
			{
				control.method_16(eventHandler_);
				control.MouseDown += value;
			}
		}

		// Token: 0x060069C4 RID: 27076 RVA: 0x00043173 File Offset: 0x00041373
		[CompilerGenerated]
		internal Class2451 vmethod_6()
		{
			return this.class2451_0;
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x0039AC5C File Offset: 0x00398E5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class2451 class2451_9)
		{
			EventHandler value = new EventHandler(this.method_10);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_9;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060069C6 RID: 27078 RVA: 0x0004317B File Offset: 0x0004137B
		[CompilerGenerated]
		internal Control8 vmethod_8()
		{
			return this.control8_0;
		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x00043183 File Offset: 0x00041383
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control8 control8_14)
		{
			this.control8_0 = control8_14;
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x0004318C File Offset: 0x0004138C
		[CompilerGenerated]
		internal SplitContainer vmethod_10()
		{
			return this.splitContainer_0;
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x00043194 File Offset: 0x00041394
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(SplitContainer splitContainer_3)
		{
			this.splitContainer_0 = splitContainer_3;
		}

		// Token: 0x060069CA RID: 27082 RVA: 0x0004319D File Offset: 0x0004139D
		[CompilerGenerated]
		internal SplitContainer vmethod_12()
		{
			return this.splitContainer_1;
		}

		// Token: 0x060069CB RID: 27083 RVA: 0x000431A5 File Offset: 0x000413A5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(SplitContainer splitContainer_3)
		{
			this.splitContainer_1 = splitContainer_3;
		}

		// Token: 0x060069CC RID: 27084 RVA: 0x000431AE File Offset: 0x000413AE
		[CompilerGenerated]
		internal SplitContainer vmethod_14()
		{
			return this.splitContainer_2;
		}

		// Token: 0x060069CD RID: 27085 RVA: 0x000431B6 File Offset: 0x000413B6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(SplitContainer splitContainer_3)
		{
			this.splitContainer_2 = splitContainer_3;
		}

		// Token: 0x060069CE RID: 27086 RVA: 0x000431BF File Offset: 0x000413BF
		[CompilerGenerated]
		internal Class2451 vmethod_16()
		{
			return this.class2451_1;
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x0039ACA0 File Offset: 0x00398EA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class2451 class2451_9)
		{
			EventHandler value = new EventHandler(this.method_11);
			Class2451 @class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_1 = class2451_9;
			@class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x000431C7 File Offset: 0x000413C7
		[CompilerGenerated]
		internal Control8 vmethod_18()
		{
			return this.control8_1;
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x000431CF File Offset: 0x000413CF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Control8 control8_14)
		{
			this.control8_1 = control8_14;
		}

		// Token: 0x060069D2 RID: 27090 RVA: 0x000431D8 File Offset: 0x000413D8
		[CompilerGenerated]
		internal Control8 vmethod_20()
		{
			return this.control8_2;
		}

		// Token: 0x060069D3 RID: 27091 RVA: 0x000431E0 File Offset: 0x000413E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Control8 control8_14)
		{
			this.control8_2 = control8_14;
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x000431E9 File Offset: 0x000413E9
		[CompilerGenerated]
		internal Control8 vmethod_22()
		{
			return this.control8_3;
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x000431F1 File Offset: 0x000413F1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Control8 control8_14)
		{
			this.control8_3 = control8_14;
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x000431FA File Offset: 0x000413FA
		[CompilerGenerated]
		internal Control8 vmethod_24()
		{
			return this.control8_4;
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x00043202 File Offset: 0x00041402
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Control8 control8_14)
		{
			this.control8_4 = control8_14;
		}

		// Token: 0x060069D8 RID: 27096 RVA: 0x0004320B File Offset: 0x0004140B
		[CompilerGenerated]
		internal Control8 vmethod_26()
		{
			return this.control8_5;
		}

		// Token: 0x060069D9 RID: 27097 RVA: 0x00043213 File Offset: 0x00041413
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Control8 control8_14)
		{
			this.control8_5 = control8_14;
		}

		// Token: 0x060069DA RID: 27098 RVA: 0x0004321C File Offset: 0x0004141C
		[CompilerGenerated]
		internal Control8 vmethod_28()
		{
			return this.control8_6;
		}

		// Token: 0x060069DB RID: 27099 RVA: 0x00043224 File Offset: 0x00041424
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Control8 control8_14)
		{
			this.control8_6 = control8_14;
		}

		// Token: 0x060069DC RID: 27100 RVA: 0x0004322D File Offset: 0x0004142D
		[CompilerGenerated]
		internal Control8 vmethod_30()
		{
			return this.control8_7;
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x00043235 File Offset: 0x00041435
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Control8 control8_14)
		{
			this.control8_7 = control8_14;
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x0004323E File Offset: 0x0004143E
		[CompilerGenerated]
		internal Control8 vmethod_32()
		{
			return this.control8_8;
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x00043246 File Offset: 0x00041446
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Control8 control8_14)
		{
			this.control8_8 = control8_14;
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x0004324F File Offset: 0x0004144F
		[CompilerGenerated]
		internal Control8 vmethod_34()
		{
			return this.control8_9;
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x00043257 File Offset: 0x00041457
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Control8 control8_14)
		{
			this.control8_9 = control8_14;
		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x00043260 File Offset: 0x00041460
		[CompilerGenerated]
		internal Control8 vmethod_36()
		{
			return this.control8_10;
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x00043268 File Offset: 0x00041468
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Control8 control8_14)
		{
			this.control8_10 = control8_14;
		}

		// Token: 0x060069E4 RID: 27108 RVA: 0x00043271 File Offset: 0x00041471
		[CompilerGenerated]
		internal Control8 vmethod_38()
		{
			return this.control8_11;
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x00043279 File Offset: 0x00041479
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Control8 control8_14)
		{
			this.control8_11 = control8_14;
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x00043282 File Offset: 0x00041482
		[CompilerGenerated]
		internal Control8 vmethod_40()
		{
			return this.control8_12;
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x0004328A File Offset: 0x0004148A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Control8 control8_14)
		{
			this.control8_12 = control8_14;
		}

		// Token: 0x060069E8 RID: 27112 RVA: 0x00043293 File Offset: 0x00041493
		[CompilerGenerated]
		internal Control8 vmethod_42()
		{
			return this.control8_13;
		}

		// Token: 0x060069E9 RID: 27113 RVA: 0x0004329B File Offset: 0x0004149B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Control8 control8_14)
		{
			this.control8_13 = control8_14;
		}

		// Token: 0x060069EA RID: 27114 RVA: 0x000432A4 File Offset: 0x000414A4
		[CompilerGenerated]
		internal Class2451 vmethod_44()
		{
			return this.class2451_2;
		}

		// Token: 0x060069EB RID: 27115 RVA: 0x000432AC File Offset: 0x000414AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Class2451 class2451_9)
		{
			this.class2451_2 = class2451_9;
		}

		// Token: 0x060069EC RID: 27116 RVA: 0x000432B5 File Offset: 0x000414B5
		[CompilerGenerated]
		internal Class2451 vmethod_46()
		{
			return this.class2451_3;
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x000432BD File Offset: 0x000414BD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Class2451 class2451_9)
		{
			this.class2451_3 = class2451_9;
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x000432C6 File Offset: 0x000414C6
		[CompilerGenerated]
		internal Class2451 vmethod_48()
		{
			return this.class2451_4;
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x000432CE File Offset: 0x000414CE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Class2451 class2451_9)
		{
			this.class2451_4 = class2451_9;
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x000432D7 File Offset: 0x000414D7
		[CompilerGenerated]
		internal Class2451 vmethod_50()
		{
			return this.class2451_5;
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x000432DF File Offset: 0x000414DF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(Class2451 class2451_9)
		{
			this.class2451_5 = class2451_9;
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x000432E8 File Offset: 0x000414E8
		[CompilerGenerated]
		internal Class2451 vmethod_52()
		{
			return this.class2451_6;
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x000432F0 File Offset: 0x000414F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Class2451 class2451_9)
		{
			this.class2451_6 = class2451_9;
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x000432F9 File Offset: 0x000414F9
		[CompilerGenerated]
		internal Class2451 vmethod_54()
		{
			return this.class2451_7;
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x00043301 File Offset: 0x00041501
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Class2451 class2451_9)
		{
			this.class2451_7 = class2451_9;
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x0004330A File Offset: 0x0004150A
		[CompilerGenerated]
		internal Class2451 vmethod_56()
		{
			return this.class2451_8;
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x0039ACE4 File Offset: 0x00398EE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(Class2451 class2451_9)
		{
			EventHandler value = new EventHandler(this.method_12);
			Class2451 @class = this.class2451_8;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_8 = class2451_9;
			@class = this.class2451_8;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x00043312 File Offset: 0x00041512
		[CompilerGenerated]
		internal Class116 vmethod_58()
		{
			return this.class116_0;
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x0004331A File Offset: 0x0004151A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(Class116 class116_42)
		{
			this.class116_0 = class116_42;
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x00043323 File Offset: 0x00041523
		[CompilerGenerated]
		internal Class116 vmethod_60()
		{
			return this.class116_1;
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x0004332B File Offset: 0x0004152B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(Class116 class116_42)
		{
			this.class116_1 = class116_42;
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x00043334 File Offset: 0x00041534
		[CompilerGenerated]
		internal Control9 vmethod_62()
		{
			return this.control9_0;
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x0039AD28 File Offset: 0x00398F28
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_13);
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

		// Token: 0x060069FE RID: 27134 RVA: 0x0004333C File Offset: 0x0004153C
		[CompilerGenerated]
		internal Control9 vmethod_64()
		{
			return this.control9_1;
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x0039AD6C File Offset: 0x00398F6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_15);
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

		// Token: 0x06006A00 RID: 27136 RVA: 0x00043344 File Offset: 0x00041544
		[CompilerGenerated]
		internal Class116 vmethod_66()
		{
			return this.class116_2;
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x0004334C File Offset: 0x0004154C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(Class116 class116_42)
		{
			this.class116_2 = class116_42;
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x00043355 File Offset: 0x00041555
		[CompilerGenerated]
		internal Class116 vmethod_68()
		{
			return this.class116_3;
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x0004335D File Offset: 0x0004155D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(Class116 class116_42)
		{
			this.class116_3 = class116_42;
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x00043366 File Offset: 0x00041566
		[CompilerGenerated]
		internal Class116 vmethod_70()
		{
			return this.class116_4;
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x0004336E File Offset: 0x0004156E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(Class116 class116_42)
		{
			this.class116_4 = class116_42;
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x00043377 File Offset: 0x00041577
		[CompilerGenerated]
		internal Class116 vmethod_72()
		{
			return this.class116_5;
		}

		// Token: 0x06006A07 RID: 27143 RVA: 0x0004337F File Offset: 0x0004157F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(Class116 class116_42)
		{
			this.class116_5 = class116_42;
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x00043388 File Offset: 0x00041588
		[CompilerGenerated]
		internal Class116 vmethod_74()
		{
			return this.class116_6;
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x00043390 File Offset: 0x00041590
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(Class116 class116_42)
		{
			this.class116_6 = class116_42;
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x00043399 File Offset: 0x00041599
		[CompilerGenerated]
		internal Class116 vmethod_76()
		{
			return this.class116_7;
		}

		// Token: 0x06006A0B RID: 27147 RVA: 0x000433A1 File Offset: 0x000415A1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Class116 class116_42)
		{
			this.class116_7 = class116_42;
		}

		// Token: 0x06006A0C RID: 27148 RVA: 0x000433AA File Offset: 0x000415AA
		[CompilerGenerated]
		internal Class116 vmethod_78()
		{
			return this.class116_8;
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x000433B2 File Offset: 0x000415B2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(Class116 class116_42)
		{
			this.class116_8 = class116_42;
		}

		// Token: 0x06006A0E RID: 27150 RVA: 0x000433BB File Offset: 0x000415BB
		[CompilerGenerated]
		internal Class116 vmethod_80()
		{
			return this.class116_9;
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x000433C3 File Offset: 0x000415C3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(Class116 class116_42)
		{
			this.class116_9 = class116_42;
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x000433CC File Offset: 0x000415CC
		[CompilerGenerated]
		internal Class116 vmethod_82()
		{
			return this.class116_10;
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x000433D4 File Offset: 0x000415D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(Class116 class116_42)
		{
			this.class116_10 = class116_42;
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x000433DD File Offset: 0x000415DD
		[CompilerGenerated]
		internal Class116 vmethod_84()
		{
			return this.class116_11;
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x000433E5 File Offset: 0x000415E5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(Class116 class116_42)
		{
			this.class116_11 = class116_42;
		}

		// Token: 0x06006A14 RID: 27156 RVA: 0x000433EE File Offset: 0x000415EE
		[CompilerGenerated]
		internal Class116 vmethod_86()
		{
			return this.class116_12;
		}

		// Token: 0x06006A15 RID: 27157 RVA: 0x000433F6 File Offset: 0x000415F6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(Class116 class116_42)
		{
			this.class116_12 = class116_42;
		}

		// Token: 0x06006A16 RID: 27158 RVA: 0x000433FF File Offset: 0x000415FF
		[CompilerGenerated]
		internal Class116 vmethod_88()
		{
			return this.class116_13;
		}

		// Token: 0x06006A17 RID: 27159 RVA: 0x00043407 File Offset: 0x00041607
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(Class116 class116_42)
		{
			this.class116_13 = class116_42;
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x00043410 File Offset: 0x00041610
		[CompilerGenerated]
		internal Class116 vmethod_90()
		{
			return this.class116_14;
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x00043418 File Offset: 0x00041618
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(Class116 class116_42)
		{
			this.class116_14 = class116_42;
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x00043421 File Offset: 0x00041621
		[CompilerGenerated]
		internal Class116 vmethod_92()
		{
			return this.class116_15;
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x00043429 File Offset: 0x00041629
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(Class116 class116_42)
		{
			this.class116_15 = class116_42;
		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x00043432 File Offset: 0x00041632
		[CompilerGenerated]
		internal Class116 vmethod_94()
		{
			return this.class116_16;
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x0004343A File Offset: 0x0004163A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(Class116 class116_42)
		{
			this.class116_16 = class116_42;
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x00043443 File Offset: 0x00041643
		[CompilerGenerated]
		internal Class116 vmethod_96()
		{
			return this.class116_17;
		}

		// Token: 0x06006A1F RID: 27167 RVA: 0x0004344B File Offset: 0x0004164B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(Class116 class116_42)
		{
			this.class116_17 = class116_42;
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x00043454 File Offset: 0x00041654
		[CompilerGenerated]
		internal Class116 vmethod_98()
		{
			return this.class116_18;
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x0004345C File Offset: 0x0004165C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_99(Class116 class116_42)
		{
			this.class116_18 = class116_42;
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x00043465 File Offset: 0x00041665
		[CompilerGenerated]
		internal Class116 vmethod_100()
		{
			return this.class116_19;
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x0004346D File Offset: 0x0004166D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_101(Class116 class116_42)
		{
			this.class116_19 = class116_42;
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x00043476 File Offset: 0x00041676
		[CompilerGenerated]
		internal Class116 vmethod_102()
		{
			return this.class116_20;
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x0004347E File Offset: 0x0004167E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_103(Class116 class116_42)
		{
			this.class116_20 = class116_42;
		}

		// Token: 0x06006A26 RID: 27174 RVA: 0x00043487 File Offset: 0x00041687
		[CompilerGenerated]
		internal Class116 vmethod_104()
		{
			return this.class116_21;
		}

		// Token: 0x06006A27 RID: 27175 RVA: 0x0004348F File Offset: 0x0004168F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_105(Class116 class116_42)
		{
			this.class116_21 = class116_42;
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x00043498 File Offset: 0x00041698
		[CompilerGenerated]
		internal Class116 vmethod_106()
		{
			return this.class116_22;
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x000434A0 File Offset: 0x000416A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_107(Class116 class116_42)
		{
			this.class116_22 = class116_42;
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x000434A9 File Offset: 0x000416A9
		[CompilerGenerated]
		internal Class116 vmethod_108()
		{
			return this.class116_23;
		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x000434B1 File Offset: 0x000416B1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_109(Class116 class116_42)
		{
			this.class116_23 = class116_42;
		}

		// Token: 0x06006A2C RID: 27180 RVA: 0x000434BA File Offset: 0x000416BA
		[CompilerGenerated]
		internal Class116 vmethod_110()
		{
			return this.class116_24;
		}

		// Token: 0x06006A2D RID: 27181 RVA: 0x000434C2 File Offset: 0x000416C2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_111(Class116 class116_42)
		{
			this.class116_24 = class116_42;
		}

		// Token: 0x06006A2E RID: 27182 RVA: 0x000434CB File Offset: 0x000416CB
		[CompilerGenerated]
		internal Control9 vmethod_112()
		{
			return this.control9_2;
		}

		// Token: 0x06006A2F RID: 27183 RVA: 0x0039ADB0 File Offset: 0x00398FB0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_113(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_17);
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

		// Token: 0x06006A30 RID: 27184 RVA: 0x000434D3 File Offset: 0x000416D3
		[CompilerGenerated]
		internal Class116 vmethod_114()
		{
			return this.class116_25;
		}

		// Token: 0x06006A31 RID: 27185 RVA: 0x000434DB File Offset: 0x000416DB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_115(Class116 class116_42)
		{
			this.class116_25 = class116_42;
		}

		// Token: 0x06006A32 RID: 27186 RVA: 0x000434E4 File Offset: 0x000416E4
		[CompilerGenerated]
		internal Class116 vmethod_116()
		{
			return this.class116_26;
		}

		// Token: 0x06006A33 RID: 27187 RVA: 0x000434EC File Offset: 0x000416EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_117(Class116 class116_42)
		{
			this.class116_26 = class116_42;
		}

		// Token: 0x06006A34 RID: 27188 RVA: 0x000434F5 File Offset: 0x000416F5
		[CompilerGenerated]
		internal Class116 vmethod_118()
		{
			return this.class116_27;
		}

		// Token: 0x06006A35 RID: 27189 RVA: 0x000434FD File Offset: 0x000416FD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_119(Class116 class116_42)
		{
			this.class116_27 = class116_42;
		}

		// Token: 0x06006A36 RID: 27190 RVA: 0x00043506 File Offset: 0x00041706
		[CompilerGenerated]
		internal Class112 vmethod_120()
		{
			return this.class112_0;
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x0004350E File Offset: 0x0004170E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_121(Class112 class112_8)
		{
			this.class112_0 = class112_8;
		}

		// Token: 0x06006A38 RID: 27192 RVA: 0x00043517 File Offset: 0x00041717
		[CompilerGenerated]
		internal Class112 vmethod_122()
		{
			return this.class112_1;
		}

		// Token: 0x06006A39 RID: 27193 RVA: 0x0004351F File Offset: 0x0004171F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_123(Class112 class112_8)
		{
			this.class112_1 = class112_8;
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x00043528 File Offset: 0x00041728
		[CompilerGenerated]
		internal Class112 vmethod_124()
		{
			return this.class112_2;
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x00043530 File Offset: 0x00041730
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_125(Class112 class112_8)
		{
			this.class112_2 = class112_8;
		}

		// Token: 0x06006A3C RID: 27196 RVA: 0x00043539 File Offset: 0x00041739
		[CompilerGenerated]
		internal Class112 vmethod_126()
		{
			return this.class112_3;
		}

		// Token: 0x06006A3D RID: 27197 RVA: 0x00043541 File Offset: 0x00041741
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_127(Class112 class112_8)
		{
			this.class112_3 = class112_8;
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x0004354A File Offset: 0x0004174A
		[CompilerGenerated]
		internal Class112 vmethod_128()
		{
			return this.class112_4;
		}

		// Token: 0x06006A3F RID: 27199 RVA: 0x00043552 File Offset: 0x00041752
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_129(Class112 class112_8)
		{
			this.class112_4 = class112_8;
		}

		// Token: 0x06006A40 RID: 27200 RVA: 0x0004355B File Offset: 0x0004175B
		[CompilerGenerated]
		internal Class112 vmethod_130()
		{
			return this.class112_5;
		}

		// Token: 0x06006A41 RID: 27201 RVA: 0x00043563 File Offset: 0x00041763
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_131(Class112 class112_8)
		{
			this.class112_5 = class112_8;
		}

		// Token: 0x06006A42 RID: 27202 RVA: 0x0004356C File Offset: 0x0004176C
		[CompilerGenerated]
		internal Class112 vmethod_132()
		{
			return this.class112_6;
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x00043574 File Offset: 0x00041774
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_133(Class112 class112_8)
		{
			this.class112_6 = class112_8;
		}

		// Token: 0x06006A44 RID: 27204 RVA: 0x0004357D File Offset: 0x0004177D
		[CompilerGenerated]
		internal Class116 vmethod_134()
		{
			return this.class116_28;
		}

		// Token: 0x06006A45 RID: 27205 RVA: 0x00043585 File Offset: 0x00041785
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_135(Class116 class116_42)
		{
			this.class116_28 = class116_42;
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x0004358E File Offset: 0x0004178E
		[CompilerGenerated]
		internal Class116 vmethod_136()
		{
			return this.class116_29;
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x00043596 File Offset: 0x00041796
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_137(Class116 class116_42)
		{
			this.class116_29 = class116_42;
		}

		// Token: 0x06006A48 RID: 27208 RVA: 0x0004359F File Offset: 0x0004179F
		[CompilerGenerated]
		internal Class116 vmethod_138()
		{
			return this.class116_30;
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x000435A7 File Offset: 0x000417A7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_139(Class116 class116_42)
		{
			this.class116_30 = class116_42;
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x000435B0 File Offset: 0x000417B0
		[CompilerGenerated]
		internal Class116 vmethod_140()
		{
			return this.class116_31;
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x000435B8 File Offset: 0x000417B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_141(Class116 class116_42)
		{
			this.class116_31 = class116_42;
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x000435C1 File Offset: 0x000417C1
		[CompilerGenerated]
		internal Class116 vmethod_142()
		{
			return this.class116_32;
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x000435C9 File Offset: 0x000417C9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_143(Class116 class116_42)
		{
			this.class116_32 = class116_42;
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x000435D2 File Offset: 0x000417D2
		[CompilerGenerated]
		internal Class116 vmethod_144()
		{
			return this.class116_33;
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x000435DA File Offset: 0x000417DA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_145(Class116 class116_42)
		{
			this.class116_33 = class116_42;
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x000435E3 File Offset: 0x000417E3
		[CompilerGenerated]
		internal Class116 vmethod_146()
		{
			return this.class116_34;
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x000435EB File Offset: 0x000417EB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_147(Class116 class116_42)
		{
			this.class116_34 = class116_42;
		}

		// Token: 0x06006A52 RID: 27218 RVA: 0x000435F4 File Offset: 0x000417F4
		[CompilerGenerated]
		internal Class116 vmethod_148()
		{
			return this.class116_35;
		}

		// Token: 0x06006A53 RID: 27219 RVA: 0x000435FC File Offset: 0x000417FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_149(Class116 class116_42)
		{
			this.class116_35 = class116_42;
		}

		// Token: 0x06006A54 RID: 27220 RVA: 0x00043605 File Offset: 0x00041805
		[CompilerGenerated]
		internal Class116 vmethod_150()
		{
			return this.class116_36;
		}

		// Token: 0x06006A55 RID: 27221 RVA: 0x0004360D File Offset: 0x0004180D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_151(Class116 class116_42)
		{
			this.class116_36 = class116_42;
		}

		// Token: 0x06006A56 RID: 27222 RVA: 0x00043616 File Offset: 0x00041816
		[CompilerGenerated]
		internal Class116 vmethod_152()
		{
			return this.class116_37;
		}

		// Token: 0x06006A57 RID: 27223 RVA: 0x0004361E File Offset: 0x0004181E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_153(Class116 class116_42)
		{
			this.class116_37 = class116_42;
		}

		// Token: 0x06006A58 RID: 27224 RVA: 0x00043627 File Offset: 0x00041827
		[CompilerGenerated]
		internal Class112 vmethod_154()
		{
			return this.class112_7;
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x0004362F File Offset: 0x0004182F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_155(Class112 class112_8)
		{
			this.class112_7 = class112_8;
		}

		// Token: 0x06006A5A RID: 27226 RVA: 0x00043638 File Offset: 0x00041838
		[CompilerGenerated]
		internal Class116 vmethod_156()
		{
			return this.class116_38;
		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x00043640 File Offset: 0x00041840
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_157(Class116 class116_42)
		{
			this.class116_38 = class116_42;
		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x00043649 File Offset: 0x00041849
		[CompilerGenerated]
		internal Class116 vmethod_158()
		{
			return this.class116_39;
		}

		// Token: 0x06006A5D RID: 27229 RVA: 0x00043651 File Offset: 0x00041851
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_159(Class116 class116_42)
		{
			this.class116_39 = class116_42;
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x0004365A File Offset: 0x0004185A
		[CompilerGenerated]
		internal Class116 vmethod_160()
		{
			return this.class116_40;
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x00043662 File Offset: 0x00041862
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_161(Class116 class116_42)
		{
			this.class116_40 = class116_42;
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x0004366B File Offset: 0x0004186B
		[CompilerGenerated]
		internal Class116 vmethod_162()
		{
			return this.class116_41;
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x00043673 File Offset: 0x00041873
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_163(Class116 class116_42)
		{
			this.class116_41 = class116_42;
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x00042F6B File Offset: 0x0004116B
		private void FlightPlanAircraftLoadout_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x0000378C File Offset: 0x0000198C
		private void FlightPlanAircraftLoadout_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x0000378C File Offset: 0x0000198C
		private void FlightPlanAircraftLoadout_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x0039ADF4 File Offset: 0x00398FF4
		private void FlightPlanAircraftLoadout_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Hide();
				return;
			}
			if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x0004367C File Offset: 0x0004187C
		public void method_3()
		{
			this.method_4();
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x00043684 File Offset: 0x00041884
		public void method_4()
		{
			this.method_5();
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x0039AEA8 File Offset: 0x003990A8
		internal void method_5()
		{
			try
			{
				if (Information.IsNothing(this.mission_0))
				{
					this.Text = "Flightplan Editor for flight <NO MISSION OR FLIGHT SELECTED>";
				}
				else
				{
					if (Information.IsNothing(this.flight_0))
					{
						this.Text = "Flightplan Editor for flight <NO FLIGHT SELECTED>";
					}
					else
					{
						this.Text = "Flightplan Editor for " + this.flight_0.string_4;
					}
					if (!Information.IsNothing(this.flight_0) && this.mission_0.method_54())
					{
						if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
						{
							DataTable dataTable = new DataTable();
							DataTable dataTable2 = new DataTable();
							Class2451 class2451_ = this.vmethod_16();
							MissionEditor.smethod_3(ref class2451_, ref dataTable, this.flight_0._FlightSize_0);
							this.vmethod_17(class2451_);
							class2451_ = this.vmethod_56();
							MissionEditor.smethod_3(ref class2451_, ref dataTable2, this.flight_0._FlightSize_1);
							this.vmethod_57(class2451_);
							DataTable dataSource = new DataTable();
							Mission.Flight.smethod_14(ref dataSource);
							Class2451 @class = this.vmethod_6();
							@class.DataSource = dataSource;
							@class.DisplayMember = "Description";
							@class.ValueMember = "ID";
							@class.DropDownWidth = 500;
							this.vmethod_6().SelectedIndex = Mission.Flight.smethod_16((int)this.flight_0.enum93_0);
							this.method_7();
							if (this.vmethod_0().method_18().Count > 0)
							{
								this.method_8();
							}
							this.method_9();
							this.vmethod_116().Text = this.flight_0.string_6;
						}
					}
					else
					{
						this.vmethod_16().DataSource = null;
						this.vmethod_16().Items.Clear();
						this.vmethod_16().SelectedIndex = -1;
						this.vmethod_56().DataSource = null;
						this.vmethod_56().Items.Clear();
						this.vmethod_56().SelectedIndex = -1;
						this.vmethod_6().DataSource = null;
						this.vmethod_6().Items.Clear();
						this.vmethod_6().SelectedIndex = -1;
						this.vmethod_0().method_18().Clear();
						this.vmethod_2().method_18().Clear();
						this.vmethod_4().method_18().Clear();
						this.vmethod_116().Text = "";
					}
					this.method_6();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x0039B138 File Offset: 0x00399338
		private void method_6()
		{
			if (!Information.IsNothing(this.flight_0) && this.flight_0.enum93_0 == Mission.Enum93.const_0)
			{
				this.vmethod_62().Enabled = true;
				this.vmethod_64().Enabled = true;
				this.vmethod_4().Enabled = true;
				this.vmethod_108().Enabled = true;
				return;
			}
			this.vmethod_62().Enabled = false;
			this.vmethod_64().Enabled = false;
			this.vmethod_4().Enabled = false;
			this.vmethod_108().Enabled = false;
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x0039B1C0 File Offset: 0x003993C0
		private void method_7()
		{
			try
			{
				this.vmethod_0().method_18().Clear();
				List<ActiveUnit> list = this.mission_0.method_15(Client.smethod_46());
				int count = list.Count;
				Class117 @class = new Class117();
				@class.method_3("Any type");
				@class.Tag = 0;
				this.vmethod_0().method_18().Add(@class);
				list = Enumerable.ToList<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, string>(Enumerable.Select<ActiveUnit, ActiveUnit>(list, (FlightPlanAircraftLoadout._Closure$__.$I345-0 == null) ? (FlightPlanAircraftLoadout._Closure$__.$I345-0 = new Func<ActiveUnit, ActiveUnit>(FlightPlanAircraftLoadout._Closure$__.$I.method_0)) : FlightPlanAircraftLoadout._Closure$__.$I345-0), (FlightPlanAircraftLoadout._Closure$__.$I345-1 == null) ? (FlightPlanAircraftLoadout._Closure$__.$I345-1 = new Func<ActiveUnit, string>(FlightPlanAircraftLoadout._Closure$__.$I.method_1)) : FlightPlanAircraftLoadout._Closure$__.$I345-1, new Class440<string[]>(true)));
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					ActiveUnit activeUnit = list[i];
					if (!Information.IsNothing(activeUnit) && activeUnit.bool_3)
					{
						int dbid = activeUnit.DBID;
						bool flag = false;
						int num2 = this.vmethod_0().method_18().Count - 1;
						int j = 0;
						while (j <= num2)
						{
							object obj = this.vmethod_0().method_18()[j];
							if (activeUnit.DBID == (int)((Class117)obj).Tag)
							{
								flag = true;
								IL_144:
								if (!flag)
								{
									Class117 class2 = new Class117();
									class2.method_3(activeUnit.string_2);
									class2.Tag = dbid;
									this.vmethod_0().method_18().Add(class2);
									goto IL_17B;
								}
								goto IL_17B;
							}
							else
							{
								j++;
							}
						}
						goto IL_144;
					}
					IL_17B:;
				}
				this.vmethod_0().method_20().Clear();
				int num3 = this.vmethod_0().method_18().Count - 1;
				for (int k = 0; k <= num3; k++)
				{
					object obj = this.vmethod_0().method_18()[k];
					if (this.flight_0.int_2 == (int)((Class117)obj).Tag)
					{
						this.vmethod_0().method_29(0);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006A6B RID: 27243 RVA: 0x0039B424 File Offset: 0x00399624
		private void method_8()
		{
			try
			{
				this.vmethod_2().method_18().Clear();
				Class117 @class = new Class117();
				@class.method_3("Any loadout");
				@class.Tag = 0;
				this.vmethod_2().method_18().Add(@class);
				this.vmethod_2().method_29(0);
				if (this.flight_0.int_2 != 0)
				{
					List<Loadout> list = DBFunctions.smethod_41(this.flight_0.int_2, Client.smethod_46());
					int count = list.Count;
					list = Enumerable.ToList<Loadout>(Enumerable.OrderBy<Loadout, string>(Enumerable.Select<Loadout, Loadout>(list, (FlightPlanAircraftLoadout._Closure$__.$I346-0 == null) ? (FlightPlanAircraftLoadout._Closure$__.$I346-0 = new Func<Loadout, Loadout>(FlightPlanAircraftLoadout._Closure$__.$I.method_2)) : FlightPlanAircraftLoadout._Closure$__.$I346-0), (FlightPlanAircraftLoadout._Closure$__.$I346-1 == null) ? (FlightPlanAircraftLoadout._Closure$__.$I346-1 = new Func<Loadout, string>(FlightPlanAircraftLoadout._Closure$__.$I.method_3)) : FlightPlanAircraftLoadout._Closure$__.$I346-1, new Class440<string[]>(true)));
					int num = count - 1;
					for (int i = 0; i <= num; i++)
					{
						Loadout loadout = list[i];
						Class117 class2 = new Class117();
						class2.method_3(loadout.Name);
						class2.Tag = loadout.DBID;
						this.vmethod_2().method_18().Add(class2);
					}
					this.vmethod_0().method_20().Clear();
					int num2 = this.vmethod_2().method_18().Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						object obj = this.vmethod_2().method_18()[j];
						if (this.flight_0.int_3 == (int)((Class117)obj).Tag)
						{
							this.vmethod_2().method_29(j);
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x0039B62C File Offset: 0x0039982C
		private void method_9()
		{
			try
			{
				this.vmethod_4().method_18().Clear();
				if (this.flight_0.enum93_0 != Mission.Enum93.const_1)
				{
					List<ActiveUnit> list = this.mission_0.method_15(Client.smethod_46());
					if (this.mission_0.enum88_0 == Mission.Enum88.const_1)
					{
						try
						{
							foreach (Mission mission in Client.smethod_50().method_35())
							{
								if (Operators.CompareString(mission.string_0, this.mission_0.method_13(Client.smethod_50()), false) == 0)
								{
									try
									{
										foreach (ActiveUnit activeUnit in mission.method_16(Client.smethod_46()))
										{
											if (activeUnit.bool_3 && Information.IsNothing(activeUnit.vmethod_101()))
											{
												list.Add(activeUnit);
											}
										}
									}
									finally
									{
										List<ActiveUnit>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
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
					list = Enumerable.ToList<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, string>(Enumerable.Select<ActiveUnit, ActiveUnit>(list, (FlightPlanAircraftLoadout._Closure$__.$I347-0 == null) ? (FlightPlanAircraftLoadout._Closure$__.$I347-0 = new Func<ActiveUnit, ActiveUnit>(FlightPlanAircraftLoadout._Closure$__.$I.method_4)) : FlightPlanAircraftLoadout._Closure$__.$I347-0), (FlightPlanAircraftLoadout._Closure$__.$I347-1 == null) ? (FlightPlanAircraftLoadout._Closure$__.$I347-1 = new Func<ActiveUnit, string>(FlightPlanAircraftLoadout._Closure$__.$I.method_5)) : FlightPlanAircraftLoadout._Closure$__.$I347-1, new Class440<string[]>(true)));
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						ActiveUnit activeUnit2 = list[i];
						if (!Information.IsNothing(activeUnit2) && activeUnit2.bool_3 && (this.flight_0.int_2 <= 0 || activeUnit2.DBID == this.flight_0.int_2) && !activeUnit2.vmethod_127())
						{
							Aircraft aircraft = (Aircraft)activeUnit2;
							if (!Information.IsNothing(aircraft.method_167()) && (this.flight_0.int_3 <= 0 || aircraft.method_166() == this.flight_0.int_3))
							{
								ActiveUnit activeUnit3 = aircraft.method_164().method_30();
								if (!Information.IsNothing(activeUnit3) && Operators.CompareString(activeUnit3.string_0, this.flight_0.string_5, false) == 0)
								{
									bool flag;
									if (activeUnit2.vmethod_85().method_48())
									{
										if (activeUnit2.vmethod_85().method_7() != this.flight_0)
										{
											goto IL_28A;
										}
										flag = true;
									}
									else
									{
										flag = false;
									}
									Class117 @class = new Class117();
									@class.method_3(activeUnit2.Name);
									if (flag)
									{
										@class.Tag = true;
									}
									else
									{
										@class.Tag = false;
									}
									this.vmethod_4().method_18().Add(@class);
								}
							}
						}
						IL_28A:;
					}
					this.vmethod_0().method_20().Clear();
					int num2 = this.vmethod_4().method_18().Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						if ((bool)((Class117)this.vmethod_4().method_18()[j]).Tag)
						{
							this.vmethod_4().method_29(j);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x0004368C File Offset: 0x0004188C
		private void FlightPlanAircraftLoadout_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.method_4();
				this.bool_3 = false;
				this.bool_4 = false;
			}
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x0039B9C0 File Offset: 0x00399BC0
		private void method_10(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				Mission.Enum93 enum93_ = Mission.Flight.smethod_15(this.vmethod_6().SelectedIndex);
				Mission.Flight flight_ = this.flight_0;
				Scenario scenario = Client.smethod_46();
				Side side_ = Client.smethod_50();
				AirTaskingOrder.smethod_1(flight_, ref scenario, ref side_, ref this.mission_0, enum93_);
				Client.smethod_51(side_);
				if (Client.smethod_32().Visible)
				{
					Client.smethod_32().method_9(false);
					Client.smethod_32().flightPlanWaypoints_6.method_14();
					Client.smethod_32().method_13();
					Client.smethod_32().method_11();
				}
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_4();
				}
				this.method_5();
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
			}
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x0039BAB4 File Offset: 0x00399CB4
		private void method_11(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				Mission._FlightSize flightSize_;
				switch (this.vmethod_16().SelectedIndex)
				{
				case 0:
					flightSize_ = Mission._FlightSize.SingleAircraft;
					break;
				case 1:
					flightSize_ = Mission._FlightSize.TwoAircraft;
					break;
				case 2:
					flightSize_ = Mission._FlightSize.ThreeAircraft;
					break;
				case 3:
					flightSize_ = Mission._FlightSize.FourAircraft;
					break;
				case 4:
					flightSize_ = Mission._FlightSize.SixAircraft;
					break;
				default:
					flightSize_ = Mission._FlightSize.SingleAircraft;
					break;
				}
				Mission.Flight flight = this.flight_0;
				Scenario scenario = Client.smethod_46();
				flight.method_26(ref scenario, ref this.mission_0, flightSize_);
				if (Client.smethod_32().Visible)
				{
					Client.smethod_32().method_12();
				}
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_4();
				}
				this.method_5();
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				Class2413.smethod_2().method_41().method_235();
				Client.bool_1 = true;
			}
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x0039BBB4 File Offset: 0x00399DB4
		private void method_12(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				Mission._FlightSize flightSize_;
				switch (this.vmethod_16().SelectedIndex)
				{
				case 0:
					flightSize_ = Mission._FlightSize.SingleAircraft;
					break;
				case 1:
					flightSize_ = Mission._FlightSize.TwoAircraft;
					break;
				case 2:
					flightSize_ = Mission._FlightSize.ThreeAircraft;
					break;
				case 3:
					flightSize_ = Mission._FlightSize.FourAircraft;
					break;
				case 4:
					flightSize_ = Mission._FlightSize.SixAircraft;
					break;
				default:
					flightSize_ = Mission._FlightSize.SingleAircraft;
					break;
				}
				Mission.Flight flight = this.flight_0;
				Scenario scenario = Client.smethod_46();
				flight.method_27(ref scenario, ref this.mission_0, flightSize_);
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_4();
				}
				this.method_5();
			}
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x0039BC68 File Offset: 0x00399E68
		private void method_13(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				this.method_14();
				if (Client.smethod_32().Visible)
				{
					Client.smethod_32().method_9(false);
					Client.smethod_32().method_11();
					Client.smethod_32().method_13();
				}
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_4();
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				this.method_5();
			}
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x0039BD14 File Offset: 0x00399F14
		private void method_14()
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				Mission mission = this.mission_0;
				Scenario scenario = Client.smethod_46();
				Side side_ = Client.smethod_50();
				mission.method_20(ref scenario, ref side_, ref this.flight_0);
				Client.smethod_51(side_);
			}
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x0039BD74 File Offset: 0x00399F74
		private void method_15(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				this.method_16();
				if (Client.smethod_32().Visible)
				{
					Client.smethod_32().method_9(false);
					Client.smethod_32().method_11();
					Client.smethod_32().method_13();
				}
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_6();
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				this.method_5();
			}
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x0039BE20 File Offset: 0x0039A020
		private void method_16()
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				if (!this.flight_0.bool_12 && Enumerable.Count<Waypoint>(this.flight_0.method_15()) == 0)
				{
					Interaction.MsgBox("Create a flightplan before assigning aircraft", MsgBoxStyle.OkOnly, null);
					return;
				}
				Mission mission = this.mission_0;
				Scenario scenario_ = Client.smethod_46();
				Side side_ = Client.smethod_50();
				bool flag = true;
				mission.method_22(scenario_, ref side_, ref flag, this.flight_0, true);
				Client.smethod_51(side_);
			}
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x0039BEB0 File Offset: 0x0039A0B0
		private void method_17(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				Scenario scenario = Client.smethod_46();
				Side side_ = Client.smethod_50();
				Mission.Flight flight_ = this.flight_0;
				Mission.Flight flight = this.flight_0;
				Mission.Flight flight2 = this.flight_0;
				Unit unit = Client.smethod_54();
				ReadOnlyCollection<Unit> readOnlyCollection = Client.smethod_50().method_56();
				FlightPlanEditor.smethod_0(ref scenario, ref side_, ref this.mission_0, flight_, ref flight.string_6, ref flight2.string_5, ref unit, ref readOnlyCollection, true, false, false);
				Client.smethod_51(side_);
				if (Client.smethod_32().Visible)
				{
					Client.smethod_32().method_5();
				}
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_5();
				}
				this.method_5();
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				Client.bool_1 = true;
			}
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x0039BFA0 File Offset: 0x0039A1A0
		private void method_18(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0))
			{
				if (this.flight_0.method_10(Client.smethod_46()) != Mission.Enum102.const_0)
				{
					this.bool_3 = false;
					return;
				}
				if (this.bool_3)
				{
					this.bool_3 = false;
					if (this.vmethod_0().method_20().Count >= 0 && this.vmethod_0().method_21().Count > 0 && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
					{
						bool flag = false;
						List<ActiveUnit> list = this.mission_0.method_15(Client.smethod_46());
						int num = list.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							ActiveUnit activeUnit = list[i];
							if (!Information.IsNothing(activeUnit) && activeUnit.bool_3 && activeUnit.DBID == this.flight_0.int_2 && activeUnit.vmethod_85().method_48() && activeUnit.vmethod_85().method_7() == this.flight_0)
							{
								flag = true;
								IL_10D:
								if (flag)
								{
									if (Interaction.MsgBox("Changing aircraft type will remove existing aircraft from the flight. Proceed?", MsgBoxStyle.YesNo, null) == MsgBoxResult.No)
									{
										this.bool_3 = false;
										this.method_3();
										return;
									}
									this.method_14();
								}
								int num2 = Conversions.ToInteger(((Class117)this.vmethod_0().method_21()[0]).Tag);
								if (this.flight_0.int_2 != num2)
								{
									this.flight_0.int_2 = num2;
									this.flight_0.method_33(Client.smethod_46(), null);
									this.flight_0.string_11 = "";
									if (num2 > 0)
									{
										this.flight_0.int_3 = 0;
										this.flight_0.method_14(Client.smethod_46(), "Any loadout");
									}
									else
									{
										this.flight_0.int_3 = 0;
										this.flight_0.method_14(Client.smethod_46(), "Any loadout");
									}
									ActiveUnit activeUnit2 = this.flight_0.method_32(Client.smethod_46());
									if (num2 > 0)
									{
										this.flight_0.string_12 = activeUnit2.string_2;
									}
									else
									{
										this.flight_0.string_12 = "Any type";
									}
									if (!Information.IsNothing(this.mission_0.list_2))
									{
										for (int j = this.mission_0.list_2.Count - 1; j >= 0; j += -1)
										{
											Mission.EmptyAircraftSlot emptyAircraftSlot = this.mission_0.list_2[j];
											if (!Information.IsNothing(emptyAircraftSlot.method_5(Client.smethod_46())) && (Information.IsNothing(this.flight_0) || Operators.CompareString(this.flight_0.string_0, emptyAircraftSlot.string_2, false) == 0))
											{
												emptyAircraftSlot.method_2(Client.smethod_46(), null, this.flight_0.method_32(Client.smethod_46()));
												if (Information.IsNothing(this.flight_0.method_32(Client.smethod_46())))
												{
													emptyAircraftSlot.string_0 = "Any type";
													emptyAircraftSlot.int_0 = 0;
												}
												else
												{
													emptyAircraftSlot.string_0 = this.flight_0.method_32(Client.smethod_46()).string_2;
													emptyAircraftSlot.int_0 = this.flight_0.method_32(Client.smethod_46()).DBID;
												}
												emptyAircraftSlot.int_1 = this.flight_0.int_3;
												emptyAircraftSlot.string_1 = this.flight_0.method_13(Client.smethod_46());
											}
										}
									}
									if (this.flight_0.int_2 == 0 && Enumerable.Count<Waypoint>(this.flight_0.method_15()) > 0)
									{
										Interaction.MsgBox("Flightplan can be used by any aircraft type, so setting all speeds to fixed...", MsgBoxStyle.OkOnly, null);
										this.method_24();
									}
									Scenario scenario_ = Client.smethod_46();
									Mission mission = this.mission_0;
									ActiveUnit activeUnit_ = this.flight_0.method_32(Client.smethod_46());
									Mission.Flight flight = this.flight_0;
									Mission.Flight flight2;
									Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
									float num3 = 0f;
									float num4 = 0f;
									Class514.smethod_28(scenario_, mission, activeUnit_, flight, ref waypoint_, ref num3, ref num4, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
									flight2.method_16(waypoint_);
									if (Client.smethod_32().Visible)
									{
										if (this.flight_0.int_2 == 0)
										{
											Client.smethod_32().method_6();
										}
										else
										{
											Client.smethod_32().method_9(true);
											Client.smethod_32().flightPlanWaypoints_6.method_14();
											Client.smethod_32().method_11();
											Client.smethod_32().method_13();
										}
									}
									if (Client.smethod_31().Visible)
									{
										Client.smethod_31().method_6();
									}
									if (Client.smethod_30().Visible)
									{
										Client.smethod_30().method_11();
										Client.smethod_30().method_13();
									}
									this.method_9();
								}
								this.method_8();
								return;
							}
						}
						goto IL_10D;
					}
				}
			}
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x0039C44C File Offset: 0x0039A64C
		private void method_19(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0))
			{
				if (this.flight_0.method_10(Client.smethod_46()) != Mission.Enum102.const_0)
				{
					this.bool_4 = false;
					return;
				}
				if (this.bool_4)
				{
					this.bool_4 = false;
					if (this.vmethod_2().method_20().Count >= 0 && this.vmethod_2().method_21().Count > 0 && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
					{
						bool flag = false;
						List<ActiveUnit> list = this.mission_0.method_15(Client.smethod_46());
						int num = list.Count - 1;
						int i = 0;
						while (i <= num)
						{
							ActiveUnit activeUnit = list[i];
							if (!Information.IsNothing(activeUnit) && activeUnit.bool_3 && activeUnit.DBID == this.flight_0.int_2 && activeUnit.vmethod_85().method_48() && activeUnit.vmethod_85().method_7() == this.flight_0)
							{
								flag = true;
								IL_10D:
								if (flag)
								{
									if (Interaction.MsgBox("Changing loadout type will remove existing aircraft from the flight. Proceed?", MsgBoxStyle.YesNo, null) == MsgBoxResult.No)
									{
										this.bool_4 = false;
										this.method_3();
										return;
									}
									this.method_14();
								}
								object obj = this.vmethod_2().method_21()[0];
								int num2 = Conversions.ToInteger(((Class117)obj).Tag);
								if (this.flight_0.int_3 != num2)
								{
									this.flight_0.method_33(Client.smethod_46(), null);
									this.flight_0.string_11 = "";
									if (num2 > 0)
									{
										this.flight_0.int_3 = num2;
										this.flight_0.method_14(Client.smethod_46(), ((Class117)obj).method_2());
									}
									else
									{
										this.flight_0.int_3 = 0;
										this.flight_0.method_14(Client.smethod_46(), "Any loadout");
									}
									this.flight_0.method_32(Client.smethod_46());
									if (!Information.IsNothing(this.mission_0.list_2))
									{
										for (int j = this.mission_0.list_2.Count - 1; j >= 0; j += -1)
										{
											Mission.EmptyAircraftSlot emptyAircraftSlot = this.mission_0.list_2[j];
											if (!Information.IsNothing(emptyAircraftSlot.method_5(Client.smethod_46())) && Operators.CompareString(this.flight_0.string_0, emptyAircraftSlot.string_2, false) == 0)
											{
												emptyAircraftSlot.int_1 = this.flight_0.int_3;
												emptyAircraftSlot.string_1 = this.flight_0.method_13(Client.smethod_46());
											}
										}
									}
									if (Client.smethod_32().Visible)
									{
										Client.smethod_32().method_9(true);
										Client.smethod_32().method_11();
									}
									if (Client.smethod_31().Visible)
									{
										Client.smethod_31().method_6();
									}
									if (Client.smethod_30().Visible)
									{
										Client.smethod_30().method_11();
										Client.smethod_30().method_13();
									}
									this.method_9();
									return;
								}
								return;
							}
							else
							{
								i++;
							}
						}
						goto IL_10D;
					}
				}
			}
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x000436AA File Offset: 0x000418AA
		private void method_20(object sender, MouseEventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x000436B3 File Offset: 0x000418B3
		private void method_21(object sender, MouseEventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x0039C744 File Offset: 0x0039A944
		private void method_22(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0))
			{
				if (this.flight_0.method_10(Client.smethod_46()) != Mission.Enum102.const_0)
				{
					this.bool_5 = false;
					return;
				}
				if (this.bool_5)
				{
					this.bool_5 = false;
					if (this.vmethod_4().method_20().Count < 0)
					{
						if (this.vmethod_4().method_21().Count == 0)
						{
							List<ActiveUnit> list = this.mission_0.method_15(Client.smethod_46());
							int num = list.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								ActiveUnit activeUnit = list[i];
								if (!Information.IsNothing(activeUnit) && activeUnit.bool_3 && activeUnit.DBID == this.flight_0.int_2 && activeUnit.vmethod_85().method_48() && activeUnit.vmethod_85().method_7() == this.flight_0)
								{
									Mission mission = this.mission_0;
									Scenario scenario = Client.smethod_46();
									mission.method_21(ref scenario, ref this.flight_0, ref activeUnit);
								}
							}
							return;
						}
					}
					else if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
					{
						List<ActiveUnit> list2 = this.mission_0.method_15(Client.smethod_46());
						if (this.mission_0.enum88_0 == Mission.Enum88.const_1)
						{
							try
							{
								foreach (Mission mission2 in Client.smethod_50().method_35())
								{
									if (Operators.CompareString(mission2.string_0, this.mission_0.method_13(Client.smethod_50()), false) == 0)
									{
										try
										{
											foreach (ActiveUnit activeUnit2 in mission2.method_16(Client.smethod_46()))
											{
												if (activeUnit2.bool_3 && Information.IsNothing(activeUnit2.vmethod_101()))
												{
													list2.Add(activeUnit2);
												}
											}
										}
										finally
										{
											List<ActiveUnit>.Enumerator enumerator2;
											((IDisposable)enumerator2).Dispose();
										}
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
						int count = list2.Count;
						if (this.flight_0.int_2 == 0 || this.flight_0.int_3 == 0)
						{
							bool flag = false;
							int num2 = count - 1;
							for (int j = 0; j <= num2; j++)
							{
								ActiveUnit activeUnit3 = list2[j];
								if (!Information.IsNothing(activeUnit3) && activeUnit3.bool_3 && (this.flight_0.int_2 <= 0 || activeUnit3.DBID == this.flight_0.int_2))
								{
									int num3 = this.vmethod_4().method_21().Count - 1;
									for (int k = 0; k <= num3; k++)
									{
										object obj = this.vmethod_4().method_21()[k];
										if (Operators.CompareString(activeUnit3.Name, ((Class117)obj).method_2(), false) == 0)
										{
											if (this.flight_0.int_2 == 0)
											{
												this.flight_0.method_33(Client.smethod_46(), activeUnit3);
												this.flight_0.int_2 = activeUnit3.DBID;
												this.flight_0.string_11 = activeUnit3.string_0;
												Interaction.MsgBox("Aircraft type for this flight has been set to " + activeUnit3.string_2 + ".", MsgBoxStyle.OkOnly, null);
											}
											if (this.flight_0.int_3 == 0)
											{
												Aircraft aircraft = (Aircraft)activeUnit3;
												if (!Information.IsNothing(aircraft.method_167()))
												{
													this.flight_0.int_3 = aircraft.method_167().DBID;
													this.flight_0.method_14(Client.smethod_46(), aircraft.method_167().Name);
													Interaction.MsgBox("Flight will use loadout " + aircraft.method_167().Name, MsgBoxStyle.OkOnly, null);
												}
											}
											flag = true;
											break;
										}
										if (flag)
										{
											break;
										}
									}
								}
							}
						}
						int num4 = 0;
						int flightSize_ = (int)this.flight_0._FlightSize_0;
						int num5 = count - 1;
						for (int l = 0; l <= num5; l++)
						{
							ActiveUnit activeUnit3 = list2[l];
							if (!Information.IsNothing(activeUnit3) && activeUnit3.bool_3 && activeUnit3.DBID == this.flight_0.int_2)
							{
								if (activeUnit3.vmethod_85().method_48())
								{
									if (activeUnit3.vmethod_85().method_7() == this.flight_0)
									{
										int count2 = this.vmethod_4().method_21().Count;
										bool flag2 = false;
										int num6 = count2 - 1;
										int m = 0;
										while (m <= num6)
										{
											object obj2 = this.vmethod_4().method_21()[m];
											if (Operators.CompareString(activeUnit3.Name, ((Class117)obj2).method_2(), false) != 0)
											{
												m++;
											}
											else
											{
												flag2 = true;
												num4++;
												IL_495:
												if (!flag2)
												{
													Mission mission3 = this.mission_0;
													Scenario scenario = Client.smethod_46();
													mission3.method_21(ref scenario, ref this.flight_0, ref activeUnit3);
													goto IL_576;
												}
												goto IL_576;
											}
										}
										goto IL_495;
									}
								}
								else
								{
									int num7 = this.vmethod_4().method_21().Count - 1;
									for (int n = 0; n <= num7; n++)
									{
										object obj3 = this.vmethod_4().method_21()[n];
										if (Operators.CompareString(activeUnit3.Name, ((Class117)obj3).method_2(), false) == 0)
										{
											activeUnit3.vmethod_85().method_8(this.flight_0);
											activeUnit3.vmethod_86().bool_2 = this.flight_0.bool_12;
											if (Information.IsNothing(activeUnit3.vmethod_101()))
											{
												ActiveUnit activeUnit4 = activeUnit3;
												Mission value = this.mission_0;
												bool setMissionOnly = false;
												Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
												activeUnit4.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
												Interaction.MsgBox("Have pulled this aircraft from the Task Pool and assigned to selected package. ", MsgBoxStyle.OkOnly, null);
											}
											num4++;
											break;
										}
									}
								}
							}
							IL_576:;
						}
						int num8 = flightSize_ - num4;
						int num9 = 0;
						if (!Information.IsNothing(this.mission_0.list_2))
						{
							for (int num10 = this.mission_0.list_2.Count - 1; num10 >= 0; num10 += -1)
							{
								Mission.EmptyAircraftSlot emptyAircraftSlot = this.mission_0.list_2[num10];
								if (!Information.IsNothing(emptyAircraftSlot.method_5(Client.smethod_46())) && (Information.IsNothing(this.flight_0) || Operators.CompareString(this.flight_0.string_0, emptyAircraftSlot.string_2, false) == 0))
								{
									num9++;
									if (num9 > num8)
									{
										this.mission_0.list_2.Remove(emptyAircraftSlot);
									}
								}
							}
						}
						this.mission_0.method_17(Client.smethod_46(), this.flight_0);
						Scenario scenario_ = Client.smethod_46();
						Mission mission4 = this.mission_0;
						ActiveUnit activeUnit_ = this.flight_0.method_32(Client.smethod_46());
						Mission.Flight flight = this.flight_0;
						Mission.Flight flight2;
						Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
						float num11 = 0f;
						float num12 = 0f;
						Class514.smethod_28(scenario_, mission4, activeUnit_, flight, ref waypoint_, ref num11, ref num12, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
						flight2.method_16(waypoint_);
						if (Client.smethod_32().Visible)
						{
							Client.smethod_32().method_9(false);
							Client.smethod_32().method_11();
							Client.smethod_32().method_13();
						}
						if (Client.smethod_31().Visible)
						{
							Client.smethod_31().method_4();
						}
						this.bool_5 = false;
						this.method_5();
						if (Client.smethod_30().Visible)
						{
							Client.smethod_30().method_11();
							Client.smethod_30().method_13();
						}
						Client.bool_1 = true;
					}
				}
			}
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x000436BC File Offset: 0x000418BC
		private void method_23(object sender, MouseEventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				this.bool_5 = true;
			}
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x0039CEB0 File Offset: 0x0039B0B0
		public void method_24()
		{
			int num = Enumerable.Count<Waypoint>(this.flight_0.method_15()) - 1;
			for (int i = 0; i <= num; i++)
			{
				Waypoint waypoint = this.flight_0.method_15()[i];
				waypoint.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.None);
				if (waypoint.enum82_1 == Waypoint.Enum82.const_1)
				{
					waypoint.method_28(waypoint.nullable_0);
				}
				else
				{
					float? nullable_ = waypoint.nullable_0;
					if (((nullable_ != null) ? new bool?(nullable_.GetValueOrDefault() > 0f) : null).GetValueOrDefault())
					{
						waypoint.method_28(waypoint.nullable_0);
					}
					else
					{
						waypoint.nullable_0 = new float?(waypoint.float_1);
						waypoint.method_28(new float?(waypoint.float_1));
					}
					waypoint.enum82_1 = Waypoint.Enum82.const_1;
				}
				Information.IsNothing(waypoint.method_27());
			}
		}

		// Token: 0x04003C73 RID: 15475
		[CompilerGenerated]
		[AccessedThroughProperty("ListBox_AircraftTypes")]
		private Control4 control4_0;

		// Token: 0x04003C74 RID: 15476
		[AccessedThroughProperty("ListBox_Loadouts")]
		[CompilerGenerated]
		private Control4 control4_1;

		// Token: 0x04003C75 RID: 15477
		[AccessedThroughProperty("ListBox_AssignedAircraft")]
		[CompilerGenerated]
		private Control4 control4_2;

		// Token: 0x04003C76 RID: 15478
		[AccessedThroughProperty("ComboBox_FlightplanType")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04003C77 RID: 15479
		[AccessedThroughProperty("TextBox_FormUpTime")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x04003C78 RID: 15480
		[CompilerGenerated]
		[AccessedThroughProperty("SplitContainer3")]
		private SplitContainer splitContainer_0;

		// Token: 0x04003C79 RID: 15481
		[CompilerGenerated]
		[AccessedThroughProperty("SplitContainer1")]
		private SplitContainer splitContainer_1;

		// Token: 0x04003C7A RID: 15482
		[AccessedThroughProperty("SplitContainer2")]
		[CompilerGenerated]
		private SplitContainer splitContainer_2;

		// Token: 0x04003C7B RID: 15483
		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox_DesiredFlightSize")]
		private Class2451 class2451_1;

		// Token: 0x04003C7C RID: 15484
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_ReserveLoiterAltitude")]
		private Control8 control8_1;

		// Token: 0x04003C7D RID: 15485
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox18")]
		private Control8 control8_2;

		// Token: 0x04003C7E RID: 15486
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_ReservePercetage")]
		private Control8 control8_3;

		// Token: 0x04003C7F RID: 15487
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_CombatDuration")]
		private Control8 control8_4;

		// Token: 0x04003C80 RID: 15488
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_CombatAltitude")]
		private Control8 control8_5;

		// Token: 0x04003C81 RID: 15489
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_StationAltitude")]
		private Control8 control8_6;

		// Token: 0x04003C82 RID: 15490
		[AccessedThroughProperty("TextBox_AttackEgressAltitude")]
		[CompilerGenerated]
		private Control8 control8_7;

		// Token: 0x04003C83 RID: 15491
		[AccessedThroughProperty("AttackEgressDistance")]
		[CompilerGenerated]
		private Control8 control8_8;

		// Token: 0x04003C84 RID: 15492
		[AccessedThroughProperty("TextBox_AttackIngressAltitude")]
		[CompilerGenerated]
		private Control8 control8_9;

		// Token: 0x04003C85 RID: 15493
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_AttackIngressDistance")]
		private Control8 control8_10;

		// Token: 0x04003C86 RID: 15494
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CruiseEgressAltitude")]
		private Control8 control8_11;

		// Token: 0x04003C87 RID: 15495
		[AccessedThroughProperty("TextBox_CruiseIngressAltitude")]
		[CompilerGenerated]
		private Control8 control8_12;

		// Token: 0x04003C88 RID: 15496
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_FormUpAltitude")]
		private Control8 control8_13;

		// Token: 0x04003C89 RID: 15497
		[CompilerGenerated]
		[AccessedThroughProperty("CB_StationThrottle")]
		private Class2451 class2451_2;

		// Token: 0x04003C8A RID: 15498
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AttackEgressThrottle")]
		private Class2451 class2451_3;

		// Token: 0x04003C8B RID: 15499
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AttackIngressThrottle")]
		private Class2451 class2451_4;

		// Token: 0x04003C8C RID: 15500
		[AccessedThroughProperty("CB_CruiseEgressThrottle")]
		[CompilerGenerated]
		private Class2451 class2451_5;

		// Token: 0x04003C8D RID: 15501
		[AccessedThroughProperty("CB_CruiseIngressThrottle")]
		[CompilerGenerated]
		private Class2451 class2451_6;

		// Token: 0x04003C8E RID: 15502
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CombatThrottle")]
		private Class2451 class2451_7;

		// Token: 0x04003C8F RID: 15503
		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox_MinimumFlightSize")]
		private Class2451 class2451_8;

		// Token: 0x04003C90 RID: 15504
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04003C91 RID: 15505
		[CompilerGenerated]
		[AccessedThroughProperty("Label9")]
		private Class116 class116_1;

		// Token: 0x04003C92 RID: 15506
		[AccessedThroughProperty("Button_ClearSlots")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04003C93 RID: 15507
		[CompilerGenerated]
		[AccessedThroughProperty("Button_FillEmptySlots")]
		private Control9 control9_1;

		// Token: 0x04003C94 RID: 15508
		[CompilerGenerated]
		[AccessedThroughProperty("Label19")]
		private Class116 class116_2;

		// Token: 0x04003C95 RID: 15509
		[AccessedThroughProperty("Label18")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x04003C96 RID: 15510
		[CompilerGenerated]
		[AccessedThroughProperty("Label15")]
		private Class116 class116_4;

		// Token: 0x04003C97 RID: 15511
		[CompilerGenerated]
		[AccessedThroughProperty("Label17")]
		private Class116 class116_5;

		// Token: 0x04003C98 RID: 15512
		[CompilerGenerated]
		[AccessedThroughProperty("Label12")]
		private Class116 class116_6;

		// Token: 0x04003C99 RID: 15513
		[AccessedThroughProperty("Label14")]
		[CompilerGenerated]
		private Class116 class116_7;

		// Token: 0x04003C9A RID: 15514
		[AccessedThroughProperty("Label8")]
		[CompilerGenerated]
		private Class116 class116_8;

		// Token: 0x04003C9B RID: 15515
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Class116 class116_9;

		// Token: 0x04003C9C RID: 15516
		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Class116 class116_10;

		// Token: 0x04003C9D RID: 15517
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_11;

		// Token: 0x04003C9E RID: 15518
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_12;

		// Token: 0x04003C9F RID: 15519
		[CompilerGenerated]
		[AccessedThroughProperty("Label27")]
		private Class116 class116_13;

		// Token: 0x04003CA0 RID: 15520
		[AccessedThroughProperty("Label_ReserveLoiterTime")]
		[CompilerGenerated]
		private Class116 class116_14;

		// Token: 0x04003CA1 RID: 15521
		[CompilerGenerated]
		[AccessedThroughProperty("Label29")]
		private Class116 class116_15;

		// Token: 0x04003CA2 RID: 15522
		[CompilerGenerated]
		[AccessedThroughProperty("Label26")]
		private Class116 class116_16;

		// Token: 0x04003CA3 RID: 15523
		[CompilerGenerated]
		[AccessedThroughProperty("Label25")]
		private Class116 class116_17;

		// Token: 0x04003CA4 RID: 15524
		[CompilerGenerated]
		[AccessedThroughProperty("Label24")]
		private Class116 class116_18;

		// Token: 0x04003CA5 RID: 15525
		[CompilerGenerated]
		[AccessedThroughProperty("Label23")]
		private Class116 class116_19;

		// Token: 0x04003CA6 RID: 15526
		[CompilerGenerated]
		[AccessedThroughProperty("Label21")]
		private Class116 class116_20;

		// Token: 0x04003CA7 RID: 15527
		[CompilerGenerated]
		[AccessedThroughProperty("Label31")]
		private Class116 class116_21;

		// Token: 0x04003CA8 RID: 15528
		[CompilerGenerated]
		[AccessedThroughProperty("Label32")]
		private Class116 class116_22;

		// Token: 0x04003CA9 RID: 15529
		[CompilerGenerated]
		[AccessedThroughProperty("Label30")]
		private Class116 class116_23;

		// Token: 0x04003CAA RID: 15530
		[CompilerGenerated]
		[AccessedThroughProperty("Label33")]
		private Class116 class116_24;

		// Token: 0x04003CAB RID: 15531
		[AccessedThroughProperty("Button_ChangeTakeOffLocation")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x04003CAC RID: 15532
		[AccessedThroughProperty("Label34")]
		[CompilerGenerated]
		private Class116 class116_25;

		// Token: 0x04003CAD RID: 15533
		[CompilerGenerated]
		[AccessedThroughProperty("Label_TakeOffLocation")]
		private Class116 class116_26;

		// Token: 0x04003CAE RID: 15534
		[CompilerGenerated]
		[AccessedThroughProperty("Label35")]
		private Class116 class116_27;

		// Token: 0x04003CAF RID: 15535
		[AccessedThroughProperty("CB_CruiseAtOptimumAltitude")]
		[CompilerGenerated]
		private Class112 class112_0;

		// Token: 0x04003CB0 RID: 15536
		[AccessedThroughProperty("CB_StationTerrainFollowing")]
		[CompilerGenerated]
		private Class112 class112_1;

		// Token: 0x04003CB1 RID: 15537
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AttackEgressTerrainFollowing")]
		private Class112 class112_2;

		// Token: 0x04003CB2 RID: 15538
		[AccessedThroughProperty("CB_AttackIngressTerrainFollowing")]
		[CompilerGenerated]
		private Class112 class112_3;

		// Token: 0x04003CB3 RID: 15539
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CruiseEgressTerrainFollowing")]
		private Class112 class112_4;

		// Token: 0x04003CB4 RID: 15540
		[AccessedThroughProperty("CB_CruiseIngressTerrainFollowing")]
		[CompilerGenerated]
		private Class112 class112_5;

		// Token: 0x04003CB5 RID: 15541
		[AccessedThroughProperty("CB_DropOrdnanceAtMaxRange")]
		[CompilerGenerated]
		private Class112 class112_6;

		// Token: 0x04003CB6 RID: 15542
		[AccessedThroughProperty("Label47")]
		[CompilerGenerated]
		private Class116 class116_28;

		// Token: 0x04003CB7 RID: 15543
		[AccessedThroughProperty("Label45")]
		[CompilerGenerated]
		private Class116 class116_29;

		// Token: 0x04003CB8 RID: 15544
		[CompilerGenerated]
		[AccessedThroughProperty("Label44")]
		private Class116 class116_30;

		// Token: 0x04003CB9 RID: 15545
		[CompilerGenerated]
		[AccessedThroughProperty("Label43")]
		private Class116 class116_31;

		// Token: 0x04003CBA RID: 15546
		[CompilerGenerated]
		[AccessedThroughProperty("Label42")]
		private Class116 class116_32;

		// Token: 0x04003CBB RID: 15547
		[CompilerGenerated]
		[AccessedThroughProperty("Label41")]
		private Class116 class116_33;

		// Token: 0x04003CBC RID: 15548
		[CompilerGenerated]
		[AccessedThroughProperty("Label40")]
		private Class116 class116_34;

		// Token: 0x04003CBD RID: 15549
		[CompilerGenerated]
		[AccessedThroughProperty("Label39")]
		private Class116 class116_35;

		// Token: 0x04003CBE RID: 15550
		[AccessedThroughProperty("Label_CruiseIngressAltitude")]
		[CompilerGenerated]
		private Class116 class116_36;

		// Token: 0x04003CBF RID: 15551
		[AccessedThroughProperty("Label_FormUpTime")]
		[CompilerGenerated]
		private Class116 class116_37;

		// Token: 0x04003CC0 RID: 15552
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CruiseOneWayOnly")]
		private Class112 class112_7;

		// Token: 0x04003CC1 RID: 15553
		[CompilerGenerated]
		[AccessedThroughProperty("Label_FormUpAltitude")]
		private Class116 class116_38;

		// Token: 0x04003CC2 RID: 15554
		[CompilerGenerated]
		[AccessedThroughProperty("Label_PatrolTransitAltitude_Aircraft")]
		private Class116 class116_39;

		// Token: 0x04003CC3 RID: 15555
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_40;

		// Token: 0x04003CC4 RID: 15556
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Class116 class116_41;

		// Token: 0x04003CC5 RID: 15557
		public Mission mission_0;

		// Token: 0x04003CC6 RID: 15558
		public Mission.Flight flight_0;

		// Token: 0x04003CC7 RID: 15559
		public bool bool_3;

		// Token: 0x04003CC8 RID: 15560
		public bool bool_4;

		// Token: 0x04003CC9 RID: 15561
		public bool bool_5;
	}
}
