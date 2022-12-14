using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks;
using ns10;
using ns13;
using ns14;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns7
{
	// Token: 0x02000F1D RID: 3869
	[DesignerGenerated]
	internal sealed partial class SpeedAlt : DarkSecondaryFormBase
	{
		// Token: 0x06008971 RID: 35185 RVA: 0x00497B1C File Offset: 0x00495D1C
		public SpeedAlt()
		{
			base.Load += this.SpeedAlt_Load;
			base.KeyDown += this.SpeedAlt_KeyDown;
			base.FormClosing += this.SpeedAlt_FormClosing;
			base.FormClosed += this.SpeedAlt_FormClosed;
			this.bool_3 = false;
			this.bool_4 = false;
			this.bool_5 = false;
			this.bool_6 = true;
			this.bool_7 = false;
			this.InitializeComponent_1();
		}

		// Token: 0x06008973 RID: 35187 RVA: 0x00497BE0 File Offset: 0x00495DE0
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SpeedAlt));
			this.vmethod_15(new Timer(this.icontainer_1));
			this.vmethod_161(new FlowLayoutPanel());
			this.vmethod_165(new FlowLayoutPanel());
			this.vmethod_163(new Class116());
			this.vmethod_167(new Class116());
			this.vmethod_169(new Class111());
			this.vmethod_171(new Class111());
			this.vmethod_93(new Class115());
			this.vmethod_105(new Class116());
			this.vmethod_107(new Class116());
			this.vmethod_101(new Control8());
			this.vmethod_103(new Class2451());
			this.vmethod_99(new Class116());
			this.vmethod_95(new Class116());
			this.vmethod_97(new Class116());
			this.vmethod_91(new Class116());
			this.vmethod_31(new Class115());
			this.vmethod_159(new Class112());
			this.vmethod_157(new Class112());
			this.vmethod_71(new Control8());
			this.vmethod_39(new Class112());
			this.vmethod_35(new Class115());
			this.vmethod_151(new Class122());
			this.vmethod_87(new Class122());
			this.vmethod_79(new Class122());
			this.vmethod_81(new Class122());
			this.vmethod_83(new Class122());
			this.vmethod_85(new Class122());
			this.vmethod_73(new Class116());
			this.vmethod_3(new Class116());
			this.vmethod_1(new TrackBar());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Class116());
			this.vmethod_11(new Class116());
			this.vmethod_13(new Class116());
			this.vmethod_141(new Class116());
			this.vmethod_33(new Class115());
			this.vmethod_27(new Class116());
			this.vmethod_143(new Class112());
			this.vmethod_137(new Class116());
			this.vmethod_139(new Class116());
			this.vmethod_133(new Class116());
			this.vmethod_135(new Class116());
			this.vmethod_127(new PictureBox());
			this.vmethod_129(new PictureBox());
			this.vmethod_131(new PictureBox());
			this.vmethod_119(new Class116());
			this.vmethod_125(new Class116());
			this.vmethod_123(new Class116());
			this.vmethod_121(new Class116());
			this.vmethod_117(new PictureBox());
			this.vmethod_115(new PictureBox());
			this.vmethod_113(new PictureBox());
			this.vmethod_111(new PictureBox());
			this.vmethod_109(new PictureBox());
			this.vmethod_23(new Class116());
			this.vmethod_25(new Class116());
			this.vmethod_89(new FlowLayoutPanel());
			this.vmethod_53(new Class115());
			this.vmethod_153(new Class122());
			this.vmethod_55(new Class122());
			this.vmethod_57(new Class122());
			this.vmethod_59(new Class122());
			this.vmethod_61(new Class122());
			this.vmethod_63(new Class122());
			this.vmethod_65(new Class122());
			this.vmethod_67(new Class122());
			this.vmethod_41(new Class115());
			this.vmethod_155(new Class122());
			this.vmethod_69(new Class122());
			this.vmethod_51(new Class122());
			this.vmethod_43(new Class122());
			this.vmethod_45(new Class122());
			this.vmethod_47(new Class122());
			this.vmethod_49(new Class122());
			this.vmethod_77(new Class116());
			this.vmethod_75(new Control8());
			this.vmethod_37(new Class112());
			this.vmethod_21(new Class116());
			this.vmethod_17(new TrackBar());
			this.vmethod_29(new Class116());
			this.vmethod_19(new Class116());
			this.vmethod_145(new ShapeContainer());
			this.vmethod_147(new LineShape());
			this.vmethod_149(new LineShape());
			this.vmethod_160().SuspendLayout();
			this.vmethod_164().SuspendLayout();
			this.vmethod_92().SuspendLayout();
			this.vmethod_30().SuspendLayout();
			this.vmethod_34().SuspendLayout();
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_32().SuspendLayout();
			((ISupportInitialize)this.vmethod_126()).BeginInit();
			((ISupportInitialize)this.vmethod_128()).BeginInit();
			((ISupportInitialize)this.vmethod_130()).BeginInit();
			((ISupportInitialize)this.vmethod_116()).BeginInit();
			((ISupportInitialize)this.vmethod_114()).BeginInit();
			((ISupportInitialize)this.vmethod_112()).BeginInit();
			((ISupportInitialize)this.vmethod_110()).BeginInit();
			((ISupportInitialize)this.vmethod_108()).BeginInit();
			this.vmethod_88().SuspendLayout();
			this.vmethod_52().SuspendLayout();
			this.vmethod_40().SuspendLayout();
			((ISupportInitialize)this.vmethod_16()).BeginInit();
			base.SuspendLayout();
			this.vmethod_14().Interval = 1000;
			this.vmethod_160().Controls.Add(this.vmethod_164());
			this.vmethod_160().Controls.Add(this.vmethod_92());
			this.vmethod_160().Controls.Add(this.vmethod_30());
			this.vmethod_160().Controls.Add(this.vmethod_32());
			this.vmethod_160().Dock = DockStyle.Fill;
			this.vmethod_160().FlowDirection = FlowDirection.TopDown;
			this.vmethod_160().Location = new Point(0, 0);
			this.vmethod_160().Name = "FlowLayoutPanel2";
			this.vmethod_160().Size = new Size(419, 658);
			this.vmethod_160().TabIndex = 19;
			this.vmethod_164().Anchor = (AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_164().Controls.Add(this.vmethod_162());
			this.vmethod_164().Controls.Add(this.vmethod_166());
			this.vmethod_164().Controls.Add(this.vmethod_168());
			this.vmethod_164().Controls.Add(this.vmethod_170());
			this.vmethod_164().Location = new Point(3, 3);
			this.vmethod_164().Name = "FlowLayoutPanel_SettingsFor";
			this.vmethod_164().Size = new Size(409, 27);
			this.vmethod_164().TabIndex = 20;
			this.vmethod_162().method_2(true);
			this.vmethod_162().Font = new Font("Segoe UI", 14f);
			this.vmethod_162().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_162().Location = new Point(3, 0);
			this.vmethod_162().Name = "Label_X";
			this.vmethod_162().Size = new Size(112, 25);
			this.vmethod_162().TabIndex = 19;
			this.vmethod_162().Text = "Settings for:";
			this.vmethod_166().method_2(true);
			this.vmethod_166().Font = new Font("Segoe UI", 14f, FontStyle.Bold);
			this.vmethod_166().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_166().Location = new Point(121, 0);
			this.vmethod_166().Name = "Label_SettingsFor";
			this.vmethod_166().Size = new Size(58, 25);
			this.vmethod_166().TabIndex = 20;
			this.vmethod_166().Text = "UNIT";
			this.vmethod_168().Image = (Image)componentResourceManager.GetObject("Button_Previous.Image");
			this.vmethod_168().Location = new Point(185, 3);
			this.vmethod_168().Name = "Button_Previous";
			this.vmethod_168().Padding = new Padding(5);
			this.vmethod_168().Size = new Size(15, 23);
			this.vmethod_168().TabIndex = 21;
			this.vmethod_170().Image = (Image)componentResourceManager.GetObject("Button_Next.Image");
			this.vmethod_170().Location = new Point(206, 3);
			this.vmethod_170().Name = "Button_Next";
			this.vmethod_170().Padding = new Padding(5);
			this.vmethod_170().Size = new Size(15, 23);
			this.vmethod_170().TabIndex = 22;
			this.vmethod_92().Controls.Add(this.vmethod_104());
			this.vmethod_92().Controls.Add(this.vmethod_106());
			this.vmethod_92().Controls.Add(this.vmethod_100());
			this.vmethod_92().Controls.Add(this.vmethod_102());
			this.vmethod_92().Controls.Add(this.vmethod_98());
			this.vmethod_92().Controls.Add(this.vmethod_94());
			this.vmethod_92().Controls.Add(this.vmethod_96());
			this.vmethod_92().Controls.Add(this.vmethod_90());
			this.vmethod_92().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_92().Location = new Point(3, 36);
			this.vmethod_92().Name = "GroupBox_Waypoint";
			this.vmethod_92().Size = new Size(409, 131);
			this.vmethod_92().TabIndex = 18;
			this.vmethod_92().TabStop = false;
			this.vmethod_92().Text = "WAYPOINT";
			this.vmethod_104().method_2(true);
			this.vmethod_104().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_104().Location = new Point(5, 102);
			this.vmethod_104().Name = "Label4";
			this.vmethod_104().Size = new Size(34, 15);
			this.vmethod_104().TabIndex = 21;
			this.vmethod_104().Text = "Type:";
			this.vmethod_106().method_2(true);
			this.vmethod_106().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_106().Location = new Point(5, 84);
			this.vmethod_106().Name = "Label1";
			this.vmethod_106().Size = new Size(70, 15);
			this.vmethod_106().TabIndex = 20;
			this.vmethod_106().Text = "Description:";
			this.vmethod_100().method_14(null);
			this.vmethod_100().method_15(AutoCompleteMode.None);
			this.vmethod_100().method_13(AutoCompleteSource.None);
			this.vmethod_100().BackColor = Color.Transparent;
			this.vmethod_100().method_17(new Font("Segoe UI", 8f));
			this.vmethod_100().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_100().method_12(null);
			this.vmethod_100().method_18(null);
			this.vmethod_100().Location = new Point(77, 80);
			this.vmethod_100().method_2(32767);
			this.vmethod_100().method_7(false);
			this.vmethod_100().Name = "TextBox_WaypointDescription";
			this.vmethod_100().method_3(false);
			this.vmethod_100().method_19(ScrollBars.None);
			this.vmethod_100().method_9(0);
			this.vmethod_100().Size = new Size(325, 20);
			this.vmethod_100().TabIndex = 19;
			this.vmethod_100().method_1(HorizontalAlignment.Left);
			this.vmethod_100().method_5(false);
			this.vmethod_100().method_10("");
			this.vmethod_102().BackColor = Color.Transparent;
			this.vmethod_102().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_102().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_102().Font = new Font("Segoe UI", 7f);
			this.vmethod_102().FormattingEnabled = true;
			this.vmethod_102().Items.AddRange(new object[]
			{
				"Form-Up ",
				"Plotted Course / Navigation",
				"Target"
			});
			this.vmethod_102().Location = new Point(77, 102);
			this.vmethod_102().Name = "CB_WaypointType";
			this.vmethod_102().Size = new Size(325, 21);
			this.vmethod_102().TabIndex = 18;
			this.vmethod_98().method_2(true);
			this.vmethod_98().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_98().Location = new Point(5, 61);
			this.vmethod_98().Name = "Label_Fuel";
			this.vmethod_98().Size = new Size(62, 15);
			this.vmethod_98().TabIndex = 17;
			this.vmethod_98().Text = "Label_Fuel";
			this.vmethod_94().method_2(true);
			this.vmethod_94().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_94().Location = new Point(88, 43);
			this.vmethod_94().Name = "Label_TTG";
			this.vmethod_94().Size = new Size(59, 15);
			this.vmethod_94().TabIndex = 16;
			this.vmethod_94().Text = "Label_TTG";
			this.vmethod_96().method_2(true);
			this.vmethod_96().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_96().Location = new Point(5, 43);
			this.vmethod_96().Name = "Label_DTG";
			this.vmethod_96().Size = new Size(60, 15);
			this.vmethod_96().TabIndex = 15;
			this.vmethod_96().Text = "Label_DTG";
			this.vmethod_90().method_2(true);
			this.vmethod_90().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_90().Location = new Point(5, 20);
			this.vmethod_90().Name = "Label_WaypointName";
			this.vmethod_90().Size = new Size(90, 15);
			this.vmethod_90().TabIndex = 11;
			this.vmethod_90().Text = "WaypointName";
			this.vmethod_30().Controls.Add(this.vmethod_158());
			this.vmethod_30().Controls.Add(this.vmethod_156());
			this.vmethod_30().Controls.Add(this.vmethod_70());
			this.vmethod_30().Controls.Add(this.vmethod_38());
			this.vmethod_30().Controls.Add(this.vmethod_34());
			this.vmethod_30().Controls.Add(this.vmethod_72());
			this.vmethod_30().Controls.Add(this.vmethod_2());
			this.vmethod_30().Controls.Add(this.vmethod_0());
			this.vmethod_30().Controls.Add(this.vmethod_4());
			this.vmethod_30().Controls.Add(this.vmethod_6());
			this.vmethod_30().Controls.Add(this.vmethod_8());
			this.vmethod_30().Controls.Add(this.vmethod_10());
			this.vmethod_30().Controls.Add(this.vmethod_12());
			this.vmethod_30().Controls.Add(this.vmethod_140());
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Location = new Point(3, 173);
			this.vmethod_30().Name = "GroupBox_Speed";
			this.vmethod_30().Size = new Size(409, 164);
			this.vmethod_30().TabIndex = 16;
			this.vmethod_30().TabStop = false;
			this.vmethod_30().Text = "THROTTLE";
			this.vmethod_158().AutoSize = true;
			this.vmethod_158().Location = new Point(294, 62);
			this.vmethod_158().Name = "CB_AvoidCavitation";
			this.vmethod_158().Size = new Size(114, 19);
			this.vmethod_158().TabIndex = 13;
			this.vmethod_158().Text = "Avoid Cavitation";
			this.vmethod_156().AutoSize = true;
			this.vmethod_156().Location = new Point(294, 20);
			this.vmethod_156().Name = "CB_SprintDrift";
			this.vmethod_156().Size = new Size(108, 19);
			this.vmethod_156().TabIndex = 12;
			this.vmethod_156().Text = "Sprint And Drift";
			this.vmethod_70().method_14(null);
			this.vmethod_70().method_15(AutoCompleteMode.None);
			this.vmethod_70().method_13(AutoCompleteSource.None);
			this.vmethod_70().BackColor = Color.Transparent;
			this.vmethod_70().method_17(new Font("Segoe UI", 8f));
			this.vmethod_70().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_70().method_12(null);
			this.vmethod_70().method_18(null);
			this.vmethod_70().Location = new Point(119, 18);
			this.vmethod_70().method_2(32767);
			this.vmethod_70().method_7(false);
			this.vmethod_70().Name = "TextBox_EnterSpeed";
			this.vmethod_70().method_3(false);
			this.vmethod_70().method_19(ScrollBars.None);
			this.vmethod_70().method_9(0);
			this.vmethod_70().Size = new Size(60, 20);
			this.vmethod_70().TabIndex = 2;
			this.vmethod_70().method_1(HorizontalAlignment.Left);
			this.vmethod_70().method_5(false);
			this.vmethod_70().method_10("");
			this.vmethod_38().AutoSize = true;
			this.vmethod_38().Location = new Point(9, 20);
			this.vmethod_38().Name = "CB_SpeedOverride";
			this.vmethod_38().Size = new Size(114, 19);
			this.vmethod_38().TabIndex = 1;
			this.vmethod_38().Text = "Manual Override";
			this.vmethod_34().Controls.Add(this.vmethod_150());
			this.vmethod_34().Controls.Add(this.vmethod_86());
			this.vmethod_34().Controls.Add(this.vmethod_78());
			this.vmethod_34().Controls.Add(this.vmethod_80());
			this.vmethod_34().Controls.Add(this.vmethod_82());
			this.vmethod_34().Controls.Add(this.vmethod_84());
			this.vmethod_34().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_34().Location = new Point(6, 113);
			this.vmethod_34().Name = "GroupBox_SpeedPresets";
			this.vmethod_34().Size = new Size(397, 44);
			this.vmethod_34().TabIndex = 10;
			this.vmethod_34().TabStop = false;
			this.vmethod_34().Text = "Throttle Presets";
			this.vmethod_150().BackColor = Color.Transparent;
			this.vmethod_150().Cursor = Cursors.Hand;
			this.vmethod_150().Font = new Font("Segoe UI", 9f);
			this.vmethod_150().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_150().Location = new Point(339, 20);
			this.vmethod_150().Name = "RB_NoThrottlePreset";
			this.vmethod_150().Size = new Size(51, 21);
			this.vmethod_150().TabIndex = 5;
			this.vmethod_150().Text = "None";
			this.vmethod_86().BackColor = Color.Transparent;
			this.vmethod_86().Cursor = Cursors.Hand;
			this.vmethod_86().Font = new Font("Segoe UI", 9f);
			this.vmethod_86().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_86().Location = new Point(261, 20);
			this.vmethod_86().Name = "RB_Flank";
			this.vmethod_86().Size = new Size(80, 21);
			this.vmethod_86().TabIndex = 0;
			this.vmethod_86().Text = "Flank";
			this.vmethod_78().BackColor = Color.Transparent;
			this.vmethod_78().Cursor = Cursors.Hand;
			this.vmethod_78().Font = new Font("Segoe UI", 9f);
			this.vmethod_78().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_78().Location = new Point(201, 20);
			this.vmethod_78().Name = "RB_Full";
			this.vmethod_78().Size = new Size(70, 21);
			this.vmethod_78().TabIndex = 4;
			this.vmethod_78().Text = "Full";
			this.vmethod_80().BackColor = Color.Transparent;
			this.vmethod_80().Cursor = Cursors.Hand;
			this.vmethod_80().Font = new Font("Segoe UI", 9f);
			this.vmethod_80().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_80().Location = new Point(131, 20);
			this.vmethod_80().Name = "RB_Cruise";
			this.vmethod_80().Size = new Size(60, 21);
			this.vmethod_80().TabIndex = 3;
			this.vmethod_80().Text = "Cruise";
			this.vmethod_82().BackColor = Color.Transparent;
			this.vmethod_82().Cursor = Cursors.Hand;
			this.vmethod_82().Font = new Font("Segoe UI", 9f);
			this.vmethod_82().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_82().Location = new Point(70, 20);
			this.vmethod_82().Name = "RB_Creep";
			this.vmethod_82().Size = new Size(60, 21);
			this.vmethod_82().TabIndex = 2;
			this.vmethod_82().Text = "Creep";
			this.vmethod_84().BackColor = Color.Transparent;
			this.vmethod_84().Cursor = Cursors.Hand;
			this.vmethod_84().Font = new Font("Segoe UI", 9f);
			this.vmethod_84().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_84().Location = new Point(10, 20);
			this.vmethod_84().Name = "RB_Stop";
			this.vmethod_84().Size = new Size(59, 21);
			this.vmethod_84().TabIndex = 1;
			this.vmethod_84().Text = "Stop";
			this.vmethod_72().method_2(true);
			this.vmethod_72().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_72().Location = new Point(183, 21);
			this.vmethod_72().Name = "Label_Speed";
			this.vmethod_72().Size = new Size(17, 15);
			this.vmethod_72().TabIndex = 3;
			this.vmethod_72().Text = "kt";
			this.vmethod_2().method_2(true);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(3, 83);
			this.vmethod_2().Name = "Label_MinSpeed";
			this.vmethod_2().RightToLeft = RightToLeft.No;
			this.vmethod_2().Size = new Size(60, 15);
			this.vmethod_2().TabIndex = 4;
			this.vmethod_2().Text = "MinSpeed";
			this.vmethod_2().TextAlign = ContentAlignment.MiddleRight;
			this.vmethod_0().AutoSize = false;
			this.vmethod_0().LargeChange = 10;
			this.vmethod_0().Location = new Point(55, 79);
			this.vmethod_0().Name = "TrackBar_Throttle";
			this.vmethod_0().Size = new Size(290, 31);
			this.vmethod_0().SmallChange = 5;
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().TickFrequency = 100;
			this.vmethod_4().method_2(true);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(343, 83);
			this.vmethod_4().Name = "Label_MaxSpeed";
			this.vmethod_4().Size = new Size(62, 15);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_4().Text = "MaxSpeed";
			this.vmethod_4().TextAlign = ContentAlignment.MiddleLeft;
			this.vmethod_6().method_2(true);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(5, 43);
			this.vmethod_6().Name = "Label2";
			this.vmethod_6().Size = new Size(84, 15);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().Text = "Desired Speed:";
			this.vmethod_8().method_2(true);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(116, 42);
			this.vmethod_8().Name = "Label_DesiredSpeed";
			this.vmethod_8().Size = new Size(78, 15);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_8().Text = "DesiredSpeed";
			this.vmethod_10().method_2(true);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Location = new Point(5, 61);
			this.vmethod_10().Name = "Label3";
			this.vmethod_10().Size = new Size(85, 15);
			this.vmethod_10().TabIndex = 6;
			this.vmethod_10().Text = "Current Speed:";
			this.vmethod_12().method_2(true);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(116, 61);
			this.vmethod_12().Name = "Label_ActualSpeed";
			this.vmethod_12().Size = new Size(79, 15);
			this.vmethod_12().TabIndex = 7;
			this.vmethod_12().Text = "CurrentSpeed";
			this.vmethod_140().method_2(true);
			this.vmethod_140().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_140().Location = new Point(220, 42);
			this.vmethod_140().Name = "Label_Cavitation";
			this.vmethod_140().Size = new Size(92, 15);
			this.vmethod_140().TabIndex = 11;
			this.vmethod_140().Text = "Label Cavitation";
			this.vmethod_32().Controls.Add(this.vmethod_26());
			this.vmethod_32().Controls.Add(this.vmethod_142());
			this.vmethod_32().Controls.Add(this.vmethod_136());
			this.vmethod_32().Controls.Add(this.vmethod_138());
			this.vmethod_32().Controls.Add(this.vmethod_132());
			this.vmethod_32().Controls.Add(this.vmethod_134());
			this.vmethod_32().Controls.Add(this.vmethod_126());
			this.vmethod_32().Controls.Add(this.vmethod_128());
			this.vmethod_32().Controls.Add(this.vmethod_130());
			this.vmethod_32().Controls.Add(this.vmethod_118());
			this.vmethod_32().Controls.Add(this.vmethod_124());
			this.vmethod_32().Controls.Add(this.vmethod_122());
			this.vmethod_32().Controls.Add(this.vmethod_120());
			this.vmethod_32().Controls.Add(this.vmethod_116());
			this.vmethod_32().Controls.Add(this.vmethod_114());
			this.vmethod_32().Controls.Add(this.vmethod_112());
			this.vmethod_32().Controls.Add(this.vmethod_110());
			this.vmethod_32().Controls.Add(this.vmethod_108());
			this.vmethod_32().Controls.Add(this.vmethod_22());
			this.vmethod_32().Controls.Add(this.vmethod_24());
			this.vmethod_32().Controls.Add(this.vmethod_88());
			this.vmethod_32().Controls.Add(this.vmethod_76());
			this.vmethod_32().Controls.Add(this.vmethod_74());
			this.vmethod_32().Controls.Add(this.vmethod_36());
			this.vmethod_32().Controls.Add(this.vmethod_20());
			this.vmethod_32().Controls.Add(this.vmethod_16());
			this.vmethod_32().Controls.Add(this.vmethod_28());
			this.vmethod_32().Controls.Add(this.vmethod_18());
			this.vmethod_32().Controls.Add(this.vmethod_144());
			this.vmethod_32().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_32().Location = new Point(3, 343);
			this.vmethod_32().Name = "GroupBox_Altitude";
			this.vmethod_32().Size = new Size(409, 303);
			this.vmethod_32().TabIndex = 17;
			this.vmethod_32().TabStop = false;
			this.vmethod_32().Text = "ALTITUDE / DEPTH";
			this.vmethod_26().method_2(true);
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Location = new Point(109, 43);
			this.vmethod_26().Name = "Label_DesiredAlt";
			this.vmethod_26().Size = new Size(61, 15);
			this.vmethod_26().TabIndex = 14;
			this.vmethod_26().Text = "DesiredAlt";
			this.vmethod_142().Location = new Point(9, 276);
			this.vmethod_142().Name = "CB_TerrainFollowing";
			this.vmethod_142().Size = new Size(268, 20);
			this.vmethod_142().TabIndex = 44;
			this.vmethod_142().Text = "Terrain Following (Above Ground Level (AGL))";
			this.vmethod_136().method_2(true);
			this.vmethod_136().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_136().Location = new Point(311, 61);
			this.vmethod_136().Name = "Label14";
			this.vmethod_136().Size = new Size(47, 15);
			this.vmethod_136().TabIndex = 42;
			this.vmethod_136().Text = "Label14";
			this.vmethod_138().method_2(true);
			this.vmethod_138().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_138().Location = new Point(311, 124);
			this.vmethod_138().Name = "Label13";
			this.vmethod_138().Size = new Size(47, 15);
			this.vmethod_138().TabIndex = 41;
			this.vmethod_138().Text = "Label13";
			this.vmethod_132().method_2(true);
			this.vmethod_132().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_132().Location = new Point(311, 216);
			this.vmethod_132().Name = "Label12";
			this.vmethod_132().Size = new Size(47, 15);
			this.vmethod_132().TabIndex = 40;
			this.vmethod_132().Text = "Label12";
			this.vmethod_134().method_2(true);
			this.vmethod_134().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_134().Location = new Point(311, 194);
			this.vmethod_134().Name = "Label11";
			this.vmethod_134().Size = new Size(47, 15);
			this.vmethod_134().TabIndex = 39;
			this.vmethod_134().Text = "Label11";
			this.vmethod_126().Image = Class2417.smethod_1();
			this.vmethod_126().Location = new Point(256, 121);
			this.vmethod_126().Name = "CloudLowTopPictureBox";
			this.vmethod_126().Size = new Size(28, 12);
			this.vmethod_126().TabIndex = 38;
			this.vmethod_126().TabStop = false;
			this.vmethod_128().Image = Class2417.smethod_1();
			this.vmethod_128().Location = new Point(256, 226);
			this.vmethod_128().Name = "CloudLowBottomPictureBox";
			this.vmethod_128().Size = new Size(28, 12);
			this.vmethod_128().TabIndex = 37;
			this.vmethod_128().TabStop = false;
			this.vmethod_130().Image = Class2417.smethod_1();
			this.vmethod_130().Location = new Point(256, 208);
			this.vmethod_130().Name = "CloudHighBottomPictureBox";
			this.vmethod_130().Size = new Size(28, 12);
			this.vmethod_130().TabIndex = 36;
			this.vmethod_130().TabStop = false;
			this.vmethod_118().method_2(true);
			this.vmethod_118().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_118().Location = new Point(311, 81);
			this.vmethod_118().Name = "Label7";
			this.vmethod_118().Size = new Size(41, 15);
			this.vmethod_118().TabIndex = 32;
			this.vmethod_118().Text = "Label7";
			this.vmethod_118().TextAlign = ContentAlignment.MiddleLeft;
			this.vmethod_124().method_2(true);
			this.vmethod_124().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_124().Location = new Point(311, 168);
			this.vmethod_124().Name = "Label10";
			this.vmethod_124().Size = new Size(47, 15);
			this.vmethod_124().TabIndex = 35;
			this.vmethod_124().Text = "Label10";
			this.vmethod_122().method_2(true);
			this.vmethod_122().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_122().Location = new Point(311, 146);
			this.vmethod_122().Name = "Label9";
			this.vmethod_122().Size = new Size(41, 15);
			this.vmethod_122().TabIndex = 34;
			this.vmethod_122().Text = "Label9";
			this.vmethod_120().method_2(true);
			this.vmethod_120().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_120().Location = new Point(311, 104);
			this.vmethod_120().Name = "Label8";
			this.vmethod_120().Size = new Size(41, 15);
			this.vmethod_120().TabIndex = 33;
			this.vmethod_120().Text = "Label8";
			this.vmethod_116().Image = Class2417.smethod_2();
			this.vmethod_116().Location = new Point(256, 168);
			this.vmethod_116().Name = "GroundLevelPictureBox";
			this.vmethod_116().Size = new Size(28, 12);
			this.vmethod_116().TabIndex = 30;
			this.vmethod_116().TabStop = false;
			this.vmethod_114().Image = Class2417.smethod_1();
			this.vmethod_114().Location = new Point(256, 190);
			this.vmethod_114().Name = "CloudHighTopPictureBox";
			this.vmethod_114().Size = new Size(28, 12);
			this.vmethod_114().TabIndex = 28;
			this.vmethod_114().TabStop = false;
			this.vmethod_112().Image = Class2417.smethod_6();
			this.vmethod_112().Location = new Point(256, 146);
			this.vmethod_112().Name = "SeaFloorPictureBox";
			this.vmethod_112().Size = new Size(28, 12);
			this.vmethod_112().TabIndex = 27;
			this.vmethod_112().TabStop = false;
			this.vmethod_110().Image = Class2417.smethod_3();
			this.vmethod_110().Location = new Point(256, 103);
			this.vmethod_110().Name = "LayerBottomPictureBox";
			this.vmethod_110().Size = new Size(28, 12);
			this.vmethod_110().TabIndex = 26;
			this.vmethod_110().TabStop = false;
			this.vmethod_108().Image = Class2417.smethod_4();
			this.vmethod_108().Location = new Point(256, 80);
			this.vmethod_108().Name = "LayerTopPictureBox";
			this.vmethod_108().Size = new Size(28, 12);
			this.vmethod_108().TabIndex = 25;
			this.vmethod_108().TabStop = false;
			this.vmethod_22().method_2(true);
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().Location = new Point(317, 16);
			this.vmethod_22().Name = "Label_MaxAlt";
			this.vmethod_22().RightToLeft = RightToLeft.No;
			this.vmethod_22().Size = new Size(45, 15);
			this.vmethod_22().TabIndex = 12;
			this.vmethod_22().Text = "MaxAlt";
			this.vmethod_22().TextAlign = ContentAlignment.MiddleRight;
			this.vmethod_24().method_2(true);
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().Location = new Point(317, 247);
			this.vmethod_24().Name = "Label_MinAlt";
			this.vmethod_24().RightToLeft = RightToLeft.No;
			this.vmethod_24().Size = new Size(43, 15);
			this.vmethod_24().TabIndex = 13;
			this.vmethod_24().Text = "MinAlt";
			this.vmethod_24().TextAlign = ContentAlignment.MiddleRight;
			this.vmethod_88().Controls.Add(this.vmethod_52());
			this.vmethod_88().Controls.Add(this.vmethod_40());
			this.vmethod_88().Location = new Point(8, 77);
			this.vmethod_88().Name = "FlowLayoutPanel_Presets";
			this.vmethod_88().Size = new Size(214, 196);
			this.vmethod_88().TabIndex = 24;
			this.vmethod_52().Controls.Add(this.vmethod_152());
			this.vmethod_52().Controls.Add(this.vmethod_54());
			this.vmethod_52().Controls.Add(this.vmethod_56());
			this.vmethod_52().Controls.Add(this.vmethod_58());
			this.vmethod_52().Controls.Add(this.vmethod_60());
			this.vmethod_52().Controls.Add(this.vmethod_62());
			this.vmethod_52().Controls.Add(this.vmethod_64());
			this.vmethod_52().Controls.Add(this.vmethod_66());
			this.vmethod_52().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_52().Location = new Point(3, 3);
			this.vmethod_52().Name = "GroupBox_AltitudePresets";
			this.vmethod_52().Size = new Size(210, 193);
			this.vmethod_52().TabIndex = 21;
			this.vmethod_52().TabStop = false;
			this.vmethod_52().Text = "Altitude Presets";
			this.vmethod_152().BackColor = Color.Transparent;
			this.vmethod_152().Cursor = Cursors.Hand;
			this.vmethod_152().Font = new Font("Segoe UI", 9f);
			this.vmethod_152().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_152().Location = new Point(6, 169);
			this.vmethod_152().Name = "RB_NoAltitudePreset";
			this.vmethod_152().Size = new Size(200, 21);
			this.vmethod_152().TabIndex = 7;
			this.vmethod_152().Text = "None";
			this.vmethod_54().BackColor = Color.Transparent;
			this.vmethod_54().Cursor = Cursors.Hand;
			this.vmethod_54().Font = new Font("Segoe UI", 9f);
			this.vmethod_54().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_54().Location = new Point(6, 83);
			this.vmethod_54().Name = "RB_MediumAltitude12000";
			this.vmethod_54().Size = new Size(200, 21);
			this.vmethod_54().TabIndex = 6;
			this.vmethod_54().Text = "Medium Altitude (12000 ft)";
			this.vmethod_56().BackColor = Color.Transparent;
			this.vmethod_56().Cursor = Cursors.Hand;
			this.vmethod_56().Font = new Font("Segoe UI", 9f);
			this.vmethod_56().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_56().Location = new Point(6, 105);
			this.vmethod_56().Name = "RB_LowAltitude2000";
			this.vmethod_56().Size = new Size(200, 21);
			this.vmethod_56().TabIndex = 5;
			this.vmethod_56().Text = "Low Altitude (2000 ft)";
			this.vmethod_58().BackColor = Color.Transparent;
			this.vmethod_58().Cursor = Cursors.Hand;
			this.vmethod_58().Font = new Font("Segoe UI", 9f);
			this.vmethod_58().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_58().Location = new Point(6, 149);
			this.vmethod_58().Name = "RB_MinAltitude";
			this.vmethod_58().Size = new Size(200, 21);
			this.vmethod_58().TabIndex = 4;
			this.vmethod_58().Text = "Min Altitude";
			this.vmethod_60().BackColor = Color.Transparent;
			this.vmethod_60().Cursor = Cursors.Hand;
			this.vmethod_60().Font = new Font("Segoe UI", 9f);
			this.vmethod_60().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_60().Location = new Point(6, 127);
			this.vmethod_60().Name = "RB_LowAltitude1000";
			this.vmethod_60().Size = new Size(200, 21);
			this.vmethod_60().TabIndex = 3;
			this.vmethod_60().Text = "Low Altitude (1000 ft)";
			this.vmethod_62().BackColor = Color.Transparent;
			this.vmethod_62().Cursor = Cursors.Hand;
			this.vmethod_62().Font = new Font("Segoe UI", 9f);
			this.vmethod_62().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_62().Location = new Point(6, 61);
			this.vmethod_62().Name = "RB_HighAltitude25000";
			this.vmethod_62().Size = new Size(200, 21);
			this.vmethod_62().TabIndex = 2;
			this.vmethod_62().Text = "High Altitude (25000 ft)";
			this.vmethod_64().BackColor = Color.Transparent;
			this.vmethod_64().Cursor = Cursors.Hand;
			this.vmethod_64().Font = new Font("Segoe UI", 9f);
			this.vmethod_64().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_64().Location = new Point(6, 39);
			this.vmethod_64().Name = "RB_HighAltitude36000";
			this.vmethod_64().Size = new Size(200, 21);
			this.vmethod_64().TabIndex = 1;
			this.vmethod_64().Text = "High Altitude (36000 ft)";
			this.vmethod_66().BackColor = Color.Transparent;
			this.vmethod_66().Cursor = Cursors.Hand;
			this.vmethod_66().Font = new Font("Segoe UI", 9f);
			this.vmethod_66().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_66().Location = new Point(6, 17);
			this.vmethod_66().Name = "RB_MaxAltitude";
			this.vmethod_66().Size = new Size(200, 21);
			this.vmethod_66().TabIndex = 0;
			this.vmethod_66().Text = "Max Altitude";
			this.vmethod_40().Controls.Add(this.vmethod_154());
			this.vmethod_40().Controls.Add(this.vmethod_68());
			this.vmethod_40().Controls.Add(this.vmethod_50());
			this.vmethod_40().Controls.Add(this.vmethod_42());
			this.vmethod_40().Controls.Add(this.vmethod_44());
			this.vmethod_40().Controls.Add(this.vmethod_46());
			this.vmethod_40().Controls.Add(this.vmethod_48());
			this.vmethod_40().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_40().Location = new Point(3, 202);
			this.vmethod_40().Name = "GroupBox_SubDepthPreset";
			this.vmethod_40().Size = new Size(210, 193);
			this.vmethod_40().TabIndex = 17;
			this.vmethod_40().TabStop = false;
			this.vmethod_40().Text = "Depth Presets";
			this.vmethod_154().BackColor = Color.Transparent;
			this.vmethod_154().Cursor = Cursors.Hand;
			this.vmethod_154().Font = new Font("Segoe UI", 9f);
			this.vmethod_154().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_154().Location = new Point(6, 151);
			this.vmethod_154().Name = "RB_NoDepthPreset";
			this.vmethod_154().Size = new Size(200, 21);
			this.vmethod_154().TabIndex = 7;
			this.vmethod_154().Text = "None";
			this.vmethod_68().BackColor = Color.Transparent;
			this.vmethod_68().Cursor = Cursors.Hand;
			this.vmethod_68().Font = new Font("Segoe UI", 9f);
			this.vmethod_68().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_68().Location = new Point(6, 19);
			this.vmethod_68().Name = "RB_Surface";
			this.vmethod_68().Size = new Size(200, 21);
			this.vmethod_68().TabIndex = 18;
			this.vmethod_68().Text = "Surface";
			this.vmethod_50().BackColor = Color.Transparent;
			this.vmethod_50().Cursor = Cursors.Hand;
			this.vmethod_50().Font = new Font("Segoe UI", 9f);
			this.vmethod_50().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_50().Location = new Point(6, 63);
			this.vmethod_50().Name = "RB_Shallow";
			this.vmethod_50().Size = new Size(200, 21);
			this.vmethod_50().TabIndex = 4;
			this.vmethod_50().Text = "Shallow";
			this.vmethod_42().BackColor = Color.Transparent;
			this.vmethod_42().Cursor = Cursors.Hand;
			this.vmethod_42().Font = new Font("Segoe UI", 9f);
			this.vmethod_42().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_42().Location = new Point(6, 129);
			this.vmethod_42().Name = "RB_MaxDepth";
			this.vmethod_42().Size = new Size(200, 21);
			this.vmethod_42().TabIndex = 3;
			this.vmethod_42().Text = "As deep as possible";
			this.vmethod_44().BackColor = Color.Transparent;
			this.vmethod_44().Cursor = Cursors.Hand;
			this.vmethod_44().Font = new Font("Segoe UI", 9f);
			this.vmethod_44().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_44().Location = new Point(6, 107);
			this.vmethod_44().Name = "RB_UnderLayer";
			this.vmethod_44().Size = new Size(200, 21);
			this.vmethod_44().TabIndex = 2;
			this.vmethod_44().Text = "Just under the layer";
			this.vmethod_46().BackColor = Color.Transparent;
			this.vmethod_46().Cursor = Cursors.Hand;
			this.vmethod_46().Font = new Font("Segoe UI", 9f);
			this.vmethod_46().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_46().Location = new Point(6, 85);
			this.vmethod_46().Name = "RB_OverLayer";
			this.vmethod_46().Size = new Size(200, 21);
			this.vmethod_46().TabIndex = 1;
			this.vmethod_46().Text = "Just over the layer";
			this.vmethod_48().BackColor = Color.Transparent;
			this.vmethod_48().Cursor = Cursors.Hand;
			this.vmethod_48().Font = new Font("Segoe UI", 9f);
			this.vmethod_48().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_48().Location = new Point(6, 41);
			this.vmethod_48().Name = "RB_Periscope";
			this.vmethod_48().Size = new Size(200, 21);
			this.vmethod_48().TabIndex = 0;
			this.vmethod_48().Text = "Periscope depth";
			this.vmethod_76().method_2(true);
			this.vmethod_76().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_76().Location = new Point(188, 21);
			this.vmethod_76().Name = "Label_Altitude";
			this.vmethod_76().Size = new Size(82, 15);
			this.vmethod_76().TabIndex = 23;
			this.vmethod_76().Text = "Label_Altitude";
			this.vmethod_74().method_14(null);
			this.vmethod_74().method_15(AutoCompleteMode.None);
			this.vmethod_74().method_13(AutoCompleteSource.None);
			this.vmethod_74().BackColor = Color.Transparent;
			this.vmethod_74().method_17(new Font("Segoe UI", 8f));
			this.vmethod_74().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_74().method_12(null);
			this.vmethod_74().method_18(null);
			this.vmethod_74().Location = new Point(119, 17);
			this.vmethod_74().method_2(32767);
			this.vmethod_74().method_7(false);
			this.vmethod_74().Name = "TextBox_EnterAltitude";
			this.vmethod_74().method_3(false);
			this.vmethod_74().method_19(ScrollBars.None);
			this.vmethod_74().method_9(0);
			this.vmethod_74().Size = new Size(60, 20);
			this.vmethod_74().TabIndex = 20;
			this.vmethod_74().method_1(HorizontalAlignment.Left);
			this.vmethod_74().method_5(false);
			this.vmethod_74().method_10("");
			this.vmethod_36().AutoSize = true;
			this.vmethod_36().Location = new Point(9, 20);
			this.vmethod_36().Name = "CB_AltOverride";
			this.vmethod_36().Size = new Size(114, 19);
			this.vmethod_36().TabIndex = 16;
			this.vmethod_36().Text = "Manual Override";
			this.vmethod_20().method_2(true);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Location = new Point(5, 43);
			this.vmethod_20().Name = "Label6";
			this.vmethod_20().Size = new Size(94, 15);
			this.vmethod_20().TabIndex = 10;
			this.vmethod_20().Text = "Desired Altitude:";
			this.vmethod_16().LargeChange = 10;
			this.vmethod_16().Location = new Point(287, 9);
			this.vmethod_16().Name = "TrackBar_Altitude";
			this.vmethod_16().Orientation = Orientation.Vertical;
			this.vmethod_16().RightToLeft = RightToLeft.No;
			this.vmethod_16().Size = new Size(45, 290);
			this.vmethod_16().SmallChange = 5;
			this.vmethod_16().TabIndex = 9;
			this.vmethod_16().TickFrequency = 305;
			this.vmethod_28().method_2(true);
			this.vmethod_28().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_28().Location = new Point(109, 61);
			this.vmethod_28().Name = "Label_CurrentAlt";
			this.vmethod_28().Size = new Size(62, 15);
			this.vmethod_28().TabIndex = 15;
			this.vmethod_28().Text = "CurrentAlt";
			this.vmethod_18().method_2(true);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(5, 61);
			this.vmethod_18().Name = "Label5";
			this.vmethod_18().Size = new Size(95, 15);
			this.vmethod_18().TabIndex = 11;
			this.vmethod_18().Text = "Current Altitude:";
			this.vmethod_144().Location = new Point(3, 19);
			this.vmethod_144().Margin = new Padding(0);
			this.vmethod_144().Name = "ShapeContainer1";
			this.vmethod_144().Shapes.AddRange(new Shape[]
			{
				this.vmethod_146(),
				this.vmethod_148()
			});
			this.vmethod_144().Size = new Size(403, 281);
			this.vmethod_144().TabIndex = 43;
			this.vmethod_144().TabStop = false;
			this.vmethod_146().BorderColor = Color.FromArgb(64, 64, 64);
			this.vmethod_146().BorderWidth = 3;
			this.vmethod_146().Name = "LineShape2";
			this.vmethod_146().X1 = 256;
			this.vmethod_146().X2 = 256;
			this.vmethod_146().Y1 = 33;
			this.vmethod_146().Y2 = 179;
			this.vmethod_148().BorderColor = Color.FromArgb(64, 64, 64);
			this.vmethod_148().BorderWidth = 3;
			this.vmethod_148().Name = "LineShape1";
			this.vmethod_148().X1 = 256;
			this.vmethod_148().X2 = 256;
			this.vmethod_148().Y1 = 70;
			this.vmethod_148().Y2 = 216;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(419, 658);
			base.Controls.Add(this.vmethod_160());
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new Size(435, 150);
			base.Name = "SpeedAlt";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Show;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Throttle & Altitude for:";
			this.vmethod_160().ResumeLayout(false);
			this.vmethod_164().ResumeLayout(false);
			this.vmethod_164().PerformLayout();
			this.vmethod_92().ResumeLayout(false);
			this.vmethod_92().PerformLayout();
			this.vmethod_30().ResumeLayout(false);
			this.vmethod_30().PerformLayout();
			this.vmethod_34().ResumeLayout(false);
			((ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_32().ResumeLayout(false);
			this.vmethod_32().PerformLayout();
			((ISupportInitialize)this.vmethod_126()).EndInit();
			((ISupportInitialize)this.vmethod_128()).EndInit();
			((ISupportInitialize)this.vmethod_130()).EndInit();
			((ISupportInitialize)this.vmethod_116()).EndInit();
			((ISupportInitialize)this.vmethod_114()).EndInit();
			((ISupportInitialize)this.vmethod_112()).EndInit();
			((ISupportInitialize)this.vmethod_110()).EndInit();
			((ISupportInitialize)this.vmethod_108()).EndInit();
			this.vmethod_88().ResumeLayout(false);
			this.vmethod_52().ResumeLayout(false);
			this.vmethod_40().ResumeLayout(false);
			((ISupportInitialize)this.vmethod_16()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06008974 RID: 35188 RVA: 0x000527DD File Offset: 0x000509DD
		[CompilerGenerated]
		internal TrackBar vmethod_0()
		{
			return this.trackBar_0;
		}

		// Token: 0x06008975 RID: 35189 RVA: 0x0049B8EC File Offset: 0x00499AEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TrackBar trackBar_2)
		{
			EventHandler value = new EventHandler(this.method_16);
			TrackBar trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_0 = trackBar_2;
			trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x06008976 RID: 35190 RVA: 0x000527E5 File Offset: 0x000509E5
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x06008977 RID: 35191 RVA: 0x000527ED File Offset: 0x000509ED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_31)
		{
			this.class116_0 = class116_31;
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x000527F6 File Offset: 0x000509F6
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x000527FE File Offset: 0x000509FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_31)
		{
			this.class116_1 = class116_31;
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x00052807 File Offset: 0x00050A07
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_2;
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x0005280F File Offset: 0x00050A0F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_31)
		{
			this.class116_2 = class116_31;
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x00052818 File Offset: 0x00050A18
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_3;
		}

		// Token: 0x0600897D RID: 35197 RVA: 0x00052820 File Offset: 0x00050A20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_31)
		{
			this.class116_3 = class116_31;
		}

		// Token: 0x0600897E RID: 35198 RVA: 0x00052829 File Offset: 0x00050A29
		[CompilerGenerated]
		internal Class116 vmethod_10()
		{
			return this.class116_4;
		}

		// Token: 0x0600897F RID: 35199 RVA: 0x00052831 File Offset: 0x00050A31
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class116 class116_31)
		{
			this.class116_4 = class116_31;
		}

		// Token: 0x06008980 RID: 35200 RVA: 0x0005283A File Offset: 0x00050A3A
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_5;
		}

		// Token: 0x06008981 RID: 35201 RVA: 0x00052842 File Offset: 0x00050A42
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_31)
		{
			this.class116_5 = class116_31;
		}

		// Token: 0x06008982 RID: 35202 RVA: 0x0005284B File Offset: 0x00050A4B
		[CompilerGenerated]
		internal Timer vmethod_14()
		{
			return this.timer_0;
		}

		// Token: 0x06008983 RID: 35203 RVA: 0x0049B930 File Offset: 0x00499B30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_8);
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

		// Token: 0x06008984 RID: 35204 RVA: 0x00052853 File Offset: 0x00050A53
		[CompilerGenerated]
		internal TrackBar vmethod_16()
		{
			return this.trackBar_1;
		}

		// Token: 0x06008985 RID: 35205 RVA: 0x0049B974 File Offset: 0x00499B74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(TrackBar trackBar_2)
		{
			EventHandler value = new EventHandler(this.method_17);
			TrackBar trackBar = this.trackBar_1;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_1 = trackBar_2;
			trackBar = this.trackBar_1;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x06008986 RID: 35206 RVA: 0x0005285B File Offset: 0x00050A5B
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_6;
		}

		// Token: 0x06008987 RID: 35207 RVA: 0x00052863 File Offset: 0x00050A63
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_31)
		{
			this.class116_6 = class116_31;
		}

		// Token: 0x06008988 RID: 35208 RVA: 0x0005286C File Offset: 0x00050A6C
		[CompilerGenerated]
		internal Class116 vmethod_20()
		{
			return this.class116_7;
		}

		// Token: 0x06008989 RID: 35209 RVA: 0x00052874 File Offset: 0x00050A74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class116 class116_31)
		{
			this.class116_7 = class116_31;
		}

		// Token: 0x0600898A RID: 35210 RVA: 0x0005287D File Offset: 0x00050A7D
		[CompilerGenerated]
		internal Class116 vmethod_22()
		{
			return this.class116_8;
		}

		// Token: 0x0600898B RID: 35211 RVA: 0x00052885 File Offset: 0x00050A85
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class116 class116_31)
		{
			this.class116_8 = class116_31;
		}

		// Token: 0x0600898C RID: 35212 RVA: 0x0005288E File Offset: 0x00050A8E
		[CompilerGenerated]
		internal Class116 vmethod_24()
		{
			return this.class116_9;
		}

		// Token: 0x0600898D RID: 35213 RVA: 0x00052896 File Offset: 0x00050A96
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class116 class116_31)
		{
			this.class116_9 = class116_31;
		}

		// Token: 0x0600898E RID: 35214 RVA: 0x0005289F File Offset: 0x00050A9F
		[CompilerGenerated]
		internal Class116 vmethod_26()
		{
			return this.class116_10;
		}

		// Token: 0x0600898F RID: 35215 RVA: 0x000528A7 File Offset: 0x00050AA7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class116 class116_31)
		{
			this.class116_10 = class116_31;
		}

		// Token: 0x06008990 RID: 35216 RVA: 0x000528B0 File Offset: 0x00050AB0
		[CompilerGenerated]
		internal Class116 vmethod_28()
		{
			return this.class116_11;
		}

		// Token: 0x06008991 RID: 35217 RVA: 0x000528B8 File Offset: 0x00050AB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class116 class116_31)
		{
			this.class116_11 = class116_31;
		}

		// Token: 0x06008992 RID: 35218 RVA: 0x000528C1 File Offset: 0x00050AC1
		[CompilerGenerated]
		internal Class115 vmethod_30()
		{
			return this.class115_0;
		}

		// Token: 0x06008993 RID: 35219 RVA: 0x000528C9 File Offset: 0x00050AC9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class115 class115_6)
		{
			this.class115_0 = class115_6;
		}

		// Token: 0x06008994 RID: 35220 RVA: 0x000528D2 File Offset: 0x00050AD2
		[CompilerGenerated]
		internal Class115 vmethod_32()
		{
			return this.class115_1;
		}

		// Token: 0x06008995 RID: 35221 RVA: 0x000528DA File Offset: 0x00050ADA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class115 class115_6)
		{
			this.class115_1 = class115_6;
		}

		// Token: 0x06008996 RID: 35222 RVA: 0x000528E3 File Offset: 0x00050AE3
		[CompilerGenerated]
		internal Class115 vmethod_34()
		{
			return this.class115_2;
		}

		// Token: 0x06008997 RID: 35223 RVA: 0x000528EB File Offset: 0x00050AEB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Class115 class115_6)
		{
			this.class115_2 = class115_6;
		}

		// Token: 0x06008998 RID: 35224 RVA: 0x000528F4 File Offset: 0x00050AF4
		[CompilerGenerated]
		internal Class112 vmethod_36()
		{
			return this.class112_0;
		}

		// Token: 0x06008999 RID: 35225 RVA: 0x0049B9B8 File Offset: 0x00499BB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class112 class112_5)
		{
			EventHandler value = new EventHandler(this.method_45);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_0 = class112_5;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600899A RID: 35226 RVA: 0x000528FC File Offset: 0x00050AFC
		[CompilerGenerated]
		internal Class112 vmethod_38()
		{
			return this.class112_1;
		}

		// Token: 0x0600899B RID: 35227 RVA: 0x0049B9FC File Offset: 0x00499BFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Class112 class112_5)
		{
			EventHandler value = new EventHandler(this.method_46);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_1 = class112_5;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600899C RID: 35228 RVA: 0x00052904 File Offset: 0x00050B04
		[CompilerGenerated]
		internal Class115 vmethod_40()
		{
			return this.class115_3;
		}

		// Token: 0x0600899D RID: 35229 RVA: 0x0005290C File Offset: 0x00050B0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Class115 class115_6)
		{
			this.class115_3 = class115_6;
		}

		// Token: 0x0600899E RID: 35230 RVA: 0x00052915 File Offset: 0x00050B15
		[CompilerGenerated]
		internal Class122 vmethod_42()
		{
			return this.class122_0;
		}

		// Token: 0x0600899F RID: 35231 RVA: 0x0049BA40 File Offset: 0x00499C40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_27);
			Class122 @class = this.class122_0;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_0 = class122_21;
			@class = this.class122_0;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089A0 RID: 35232 RVA: 0x0005291D File Offset: 0x00050B1D
		[CompilerGenerated]
		internal Class122 vmethod_44()
		{
			return this.class122_1;
		}

		// Token: 0x060089A1 RID: 35233 RVA: 0x0049BA84 File Offset: 0x00499C84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_26);
			Class122 @class = this.class122_1;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_1 = class122_21;
			@class = this.class122_1;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089A2 RID: 35234 RVA: 0x00052925 File Offset: 0x00050B25
		[CompilerGenerated]
		internal Class122 vmethod_46()
		{
			return this.class122_2;
		}

		// Token: 0x060089A3 RID: 35235 RVA: 0x0049BAC8 File Offset: 0x00499CC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_25);
			Class122 @class = this.class122_2;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_2 = class122_21;
			@class = this.class122_2;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089A4 RID: 35236 RVA: 0x0005292D File Offset: 0x00050B2D
		[CompilerGenerated]
		internal Class122 vmethod_48()
		{
			return this.class122_3;
		}

		// Token: 0x060089A5 RID: 35237 RVA: 0x0049BB0C File Offset: 0x00499D0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_23);
			Class122 @class = this.class122_3;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_3 = class122_21;
			@class = this.class122_3;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089A6 RID: 35238 RVA: 0x00052935 File Offset: 0x00050B35
		[CompilerGenerated]
		internal Class122 vmethod_50()
		{
			return this.class122_4;
		}

		// Token: 0x060089A7 RID: 35239 RVA: 0x0049BB50 File Offset: 0x00499D50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_24);
			Class122 @class = this.class122_4;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_4 = class122_21;
			@class = this.class122_4;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089A8 RID: 35240 RVA: 0x0005293D File Offset: 0x00050B3D
		[CompilerGenerated]
		internal Class115 vmethod_52()
		{
			return this.class115_4;
		}

		// Token: 0x060089A9 RID: 35241 RVA: 0x00052945 File Offset: 0x00050B45
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Class115 class115_6)
		{
			this.class115_4 = class115_6;
		}

		// Token: 0x060089AA RID: 35242 RVA: 0x0005294E File Offset: 0x00050B4E
		[CompilerGenerated]
		internal Class122 vmethod_54()
		{
			return this.class122_5;
		}

		// Token: 0x060089AB RID: 35243 RVA: 0x0049BB94 File Offset: 0x00499D94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_33);
			Class122 @class = this.class122_5;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_5 = class122_21;
			@class = this.class122_5;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089AC RID: 35244 RVA: 0x00052956 File Offset: 0x00050B56
		[CompilerGenerated]
		internal Class122 vmethod_56()
		{
			return this.class122_6;
		}

		// Token: 0x060089AD RID: 35245 RVA: 0x0049BBD8 File Offset: 0x00499DD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_34);
			Class122 @class = this.class122_6;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_6 = class122_21;
			@class = this.class122_6;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089AE RID: 35246 RVA: 0x0005295E File Offset: 0x00050B5E
		[CompilerGenerated]
		internal Class122 vmethod_58()
		{
			return this.class122_7;
		}

		// Token: 0x060089AF RID: 35247 RVA: 0x0049BC1C File Offset: 0x00499E1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_36);
			Class122 @class = this.class122_7;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_7 = class122_21;
			@class = this.class122_7;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089B0 RID: 35248 RVA: 0x00052966 File Offset: 0x00050B66
		[CompilerGenerated]
		internal Class122 vmethod_60()
		{
			return this.class122_8;
		}

		// Token: 0x060089B1 RID: 35249 RVA: 0x0049BC60 File Offset: 0x00499E60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_35);
			Class122 @class = this.class122_8;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_8 = class122_21;
			@class = this.class122_8;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089B2 RID: 35250 RVA: 0x0005296E File Offset: 0x00050B6E
		[CompilerGenerated]
		internal Class122 vmethod_62()
		{
			return this.class122_9;
		}

		// Token: 0x060089B3 RID: 35251 RVA: 0x0049BCA4 File Offset: 0x00499EA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_32);
			Class122 @class = this.class122_9;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_9 = class122_21;
			@class = this.class122_9;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089B4 RID: 35252 RVA: 0x00052976 File Offset: 0x00050B76
		[CompilerGenerated]
		internal Class122 vmethod_64()
		{
			return this.class122_10;
		}

		// Token: 0x060089B5 RID: 35253 RVA: 0x0049BCE8 File Offset: 0x00499EE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_31);
			Class122 @class = this.class122_10;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_10 = class122_21;
			@class = this.class122_10;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089B6 RID: 35254 RVA: 0x0005297E File Offset: 0x00050B7E
		[CompilerGenerated]
		internal Class122 vmethod_66()
		{
			return this.class122_11;
		}

		// Token: 0x060089B7 RID: 35255 RVA: 0x0049BD2C File Offset: 0x00499F2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_29);
			Class122 @class = this.class122_11;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_11 = class122_21;
			@class = this.class122_11;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089B8 RID: 35256 RVA: 0x00052986 File Offset: 0x00050B86
		[CompilerGenerated]
		internal Class122 vmethod_68()
		{
			return this.class122_12;
		}

		// Token: 0x060089B9 RID: 35257 RVA: 0x0049BD70 File Offset: 0x00499F70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_22);
			Class122 @class = this.class122_12;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_12 = class122_21;
			@class = this.class122_12;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089BA RID: 35258 RVA: 0x0005298E File Offset: 0x00050B8E
		[CompilerGenerated]
		internal Control8 vmethod_70()
		{
			return this.control8_0;
		}

		// Token: 0x060089BB RID: 35259 RVA: 0x0049BDB4 File Offset: 0x00499FB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(Control8 control8_3)
		{
			EventHandler value = new EventHandler(this.method_37);
			EventHandler value2 = new EventHandler(this.method_38);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_43);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.Enter -= value;
				control.Leave -= value2;
				control.KeyPress -= value3;
			}
			this.control8_0 = control8_3;
			control = this.control8_0;
			if (control != null)
			{
				control.Enter += value;
				control.Leave += value2;
				control.KeyPress += value3;
			}
		}

		// Token: 0x060089BC RID: 35260 RVA: 0x00052996 File Offset: 0x00050B96
		[CompilerGenerated]
		internal Class116 vmethod_72()
		{
			return this.class116_12;
		}

		// Token: 0x060089BD RID: 35261 RVA: 0x0005299E File Offset: 0x00050B9E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(Class116 class116_31)
		{
			this.class116_12 = class116_31;
		}

		// Token: 0x060089BE RID: 35262 RVA: 0x000529A7 File Offset: 0x00050BA7
		[CompilerGenerated]
		internal Control8 vmethod_74()
		{
			return this.control8_1;
		}

		// Token: 0x060089BF RID: 35263 RVA: 0x0049BE30 File Offset: 0x0049A030
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(Control8 control8_3)
		{
			EventHandler value = new EventHandler(this.method_39);
			EventHandler value2 = new EventHandler(this.method_41);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_44);
			Control8 control = this.control8_1;
			if (control != null)
			{
				control.Enter -= value;
				control.Leave -= value2;
				control.KeyPress -= value3;
			}
			this.control8_1 = control8_3;
			control = this.control8_1;
			if (control != null)
			{
				control.Enter += value;
				control.Leave += value2;
				control.KeyPress += value3;
			}
		}

		// Token: 0x060089C0 RID: 35264 RVA: 0x000529AF File Offset: 0x00050BAF
		[CompilerGenerated]
		internal Class116 vmethod_76()
		{
			return this.class116_13;
		}

		// Token: 0x060089C1 RID: 35265 RVA: 0x000529B7 File Offset: 0x00050BB7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Class116 class116_31)
		{
			this.class116_13 = class116_31;
		}

		// Token: 0x060089C2 RID: 35266 RVA: 0x000529C0 File Offset: 0x00050BC0
		[CompilerGenerated]
		internal Class122 vmethod_78()
		{
			return this.class122_13;
		}

		// Token: 0x060089C3 RID: 35267 RVA: 0x0049BEAC File Offset: 0x0049A0AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_13);
			Class122 @class = this.class122_13;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_13 = class122_21;
			@class = this.class122_13;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089C4 RID: 35268 RVA: 0x000529C8 File Offset: 0x00050BC8
		[CompilerGenerated]
		internal Class122 vmethod_80()
		{
			return this.class122_14;
		}

		// Token: 0x060089C5 RID: 35269 RVA: 0x0049BEF0 File Offset: 0x0049A0F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_12);
			Class122 @class = this.class122_14;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_14 = class122_21;
			@class = this.class122_14;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089C6 RID: 35270 RVA: 0x000529D0 File Offset: 0x00050BD0
		[CompilerGenerated]
		internal Class122 vmethod_82()
		{
			return this.class122_15;
		}

		// Token: 0x060089C7 RID: 35271 RVA: 0x0049BF34 File Offset: 0x0049A134
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_10);
			Class122 @class = this.class122_15;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_15 = class122_21;
			@class = this.class122_15;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089C8 RID: 35272 RVA: 0x000529D8 File Offset: 0x00050BD8
		[CompilerGenerated]
		internal Class122 vmethod_84()
		{
			return this.class122_16;
		}

		// Token: 0x060089C9 RID: 35273 RVA: 0x0049BF78 File Offset: 0x0049A178
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_9);
			Class122 @class = this.class122_16;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_16 = class122_21;
			@class = this.class122_16;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089CA RID: 35274 RVA: 0x000529E0 File Offset: 0x00050BE0
		[CompilerGenerated]
		internal Class122 vmethod_86()
		{
			return this.class122_17;
		}

		// Token: 0x060089CB RID: 35275 RVA: 0x0049BFBC File Offset: 0x0049A1BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_15);
			Class122 @class = this.class122_17;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_17 = class122_21;
			@class = this.class122_17;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060089CC RID: 35276 RVA: 0x000529E8 File Offset: 0x00050BE8
		[CompilerGenerated]
		internal FlowLayoutPanel vmethod_88()
		{
			return this.flowLayoutPanel_0;
		}

		// Token: 0x060089CD RID: 35277 RVA: 0x000529F0 File Offset: 0x00050BF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(FlowLayoutPanel flowLayoutPanel_3)
		{
			this.flowLayoutPanel_0 = flowLayoutPanel_3;
		}

		// Token: 0x060089CE RID: 35278 RVA: 0x000529F9 File Offset: 0x00050BF9
		[CompilerGenerated]
		internal Class116 vmethod_90()
		{
			return this.class116_14;
		}

		// Token: 0x060089CF RID: 35279 RVA: 0x00052A01 File Offset: 0x00050C01
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(Class116 class116_31)
		{
			this.class116_14 = class116_31;
		}

		// Token: 0x060089D0 RID: 35280 RVA: 0x00052A0A File Offset: 0x00050C0A
		[CompilerGenerated]
		internal Class115 vmethod_92()
		{
			return this.class115_5;
		}

		// Token: 0x060089D1 RID: 35281 RVA: 0x00052A12 File Offset: 0x00050C12
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(Class115 class115_6)
		{
			this.class115_5 = class115_6;
		}

		// Token: 0x060089D2 RID: 35282 RVA: 0x00052A1B File Offset: 0x00050C1B
		[CompilerGenerated]
		internal Class116 vmethod_94()
		{
			return this.class116_15;
		}

		// Token: 0x060089D3 RID: 35283 RVA: 0x00052A23 File Offset: 0x00050C23
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(Class116 class116_31)
		{
			this.class116_15 = class116_31;
		}

		// Token: 0x060089D4 RID: 35284 RVA: 0x00052A2C File Offset: 0x00050C2C
		[CompilerGenerated]
		internal Class116 vmethod_96()
		{
			return this.class116_16;
		}

		// Token: 0x060089D5 RID: 35285 RVA: 0x00052A34 File Offset: 0x00050C34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(Class116 class116_31)
		{
			this.class116_16 = class116_31;
		}

		// Token: 0x060089D6 RID: 35286 RVA: 0x00052A3D File Offset: 0x00050C3D
		[CompilerGenerated]
		internal Class116 vmethod_98()
		{
			return this.class116_17;
		}

		// Token: 0x060089D7 RID: 35287 RVA: 0x00052A45 File Offset: 0x00050C45
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_99(Class116 class116_31)
		{
			this.class116_17 = class116_31;
		}

		// Token: 0x060089D8 RID: 35288 RVA: 0x00052A4E File Offset: 0x00050C4E
		[CompilerGenerated]
		internal Control8 vmethod_100()
		{
			return this.control8_2;
		}

		// Token: 0x060089D9 RID: 35289 RVA: 0x0049C000 File Offset: 0x0049A200
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_101(Control8 control8_3)
		{
			EventHandler value = new EventHandler(this.method_49);
			EventHandler value2 = new EventHandler(this.method_50);
			Control8 control = this.control8_2;
			if (control != null)
			{
				control.Enter -= value;
				control.Leave -= value2;
			}
			this.control8_2 = control8_3;
			control = this.control8_2;
			if (control != null)
			{
				control.Enter += value;
				control.Leave += value2;
			}
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x00052A56 File Offset: 0x00050C56
		[CompilerGenerated]
		internal Class2451 vmethod_102()
		{
			return this.class2451_0;
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x0049C060 File Offset: 0x0049A260
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_103(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_47);
			EventHandler value2 = new EventHandler(this.method_48);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.DropDown -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_0 = class2451_1;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.DropDown += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x060089DC RID: 35292 RVA: 0x00052A5E File Offset: 0x00050C5E
		[CompilerGenerated]
		internal Class116 vmethod_104()
		{
			return this.class116_18;
		}

		// Token: 0x060089DD RID: 35293 RVA: 0x00052A66 File Offset: 0x00050C66
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_105(Class116 class116_31)
		{
			this.class116_18 = class116_31;
		}

		// Token: 0x060089DE RID: 35294 RVA: 0x00052A6F File Offset: 0x00050C6F
		[CompilerGenerated]
		internal Class116 vmethod_106()
		{
			return this.class116_19;
		}

		// Token: 0x060089DF RID: 35295 RVA: 0x00052A77 File Offset: 0x00050C77
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_107(Class116 class116_31)
		{
			this.class116_19 = class116_31;
		}

		// Token: 0x060089E0 RID: 35296 RVA: 0x00052A80 File Offset: 0x00050C80
		[CompilerGenerated]
		internal PictureBox vmethod_108()
		{
			return this.pictureBox_0;
		}

		// Token: 0x060089E1 RID: 35297 RVA: 0x00052A88 File Offset: 0x00050C88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_109(PictureBox pictureBox_8)
		{
			this.pictureBox_0 = pictureBox_8;
		}

		// Token: 0x060089E2 RID: 35298 RVA: 0x00052A91 File Offset: 0x00050C91
		[CompilerGenerated]
		internal PictureBox vmethod_110()
		{
			return this.pictureBox_1;
		}

		// Token: 0x060089E3 RID: 35299 RVA: 0x00052A99 File Offset: 0x00050C99
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_111(PictureBox pictureBox_8)
		{
			this.pictureBox_1 = pictureBox_8;
		}

		// Token: 0x060089E4 RID: 35300 RVA: 0x00052AA2 File Offset: 0x00050CA2
		[CompilerGenerated]
		internal PictureBox vmethod_112()
		{
			return this.pictureBox_2;
		}

		// Token: 0x060089E5 RID: 35301 RVA: 0x00052AAA File Offset: 0x00050CAA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_113(PictureBox pictureBox_8)
		{
			this.pictureBox_2 = pictureBox_8;
		}

		// Token: 0x060089E6 RID: 35302 RVA: 0x00052AB3 File Offset: 0x00050CB3
		[CompilerGenerated]
		internal PictureBox vmethod_114()
		{
			return this.pictureBox_3;
		}

		// Token: 0x060089E7 RID: 35303 RVA: 0x00052ABB File Offset: 0x00050CBB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_115(PictureBox pictureBox_8)
		{
			this.pictureBox_3 = pictureBox_8;
		}

		// Token: 0x060089E8 RID: 35304 RVA: 0x00052AC4 File Offset: 0x00050CC4
		[CompilerGenerated]
		internal PictureBox vmethod_116()
		{
			return this.pictureBox_4;
		}

		// Token: 0x060089E9 RID: 35305 RVA: 0x00052ACC File Offset: 0x00050CCC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_117(PictureBox pictureBox_8)
		{
			this.pictureBox_4 = pictureBox_8;
		}

		// Token: 0x060089EA RID: 35306 RVA: 0x00052AD5 File Offset: 0x00050CD5
		[CompilerGenerated]
		internal Class116 vmethod_118()
		{
			return this.class116_20;
		}

		// Token: 0x060089EB RID: 35307 RVA: 0x00052ADD File Offset: 0x00050CDD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_119(Class116 class116_31)
		{
			this.class116_20 = class116_31;
		}

		// Token: 0x060089EC RID: 35308 RVA: 0x00052AE6 File Offset: 0x00050CE6
		[CompilerGenerated]
		internal Class116 vmethod_120()
		{
			return this.class116_21;
		}

		// Token: 0x060089ED RID: 35309 RVA: 0x00052AEE File Offset: 0x00050CEE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_121(Class116 class116_31)
		{
			this.class116_21 = class116_31;
		}

		// Token: 0x060089EE RID: 35310 RVA: 0x00052AF7 File Offset: 0x00050CF7
		[CompilerGenerated]
		internal Class116 vmethod_122()
		{
			return this.class116_22;
		}

		// Token: 0x060089EF RID: 35311 RVA: 0x00052AFF File Offset: 0x00050CFF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_123(Class116 class116_31)
		{
			this.class116_22 = class116_31;
		}

		// Token: 0x060089F0 RID: 35312 RVA: 0x00052B08 File Offset: 0x00050D08
		[CompilerGenerated]
		internal Class116 vmethod_124()
		{
			return this.class116_23;
		}

		// Token: 0x060089F1 RID: 35313 RVA: 0x00052B10 File Offset: 0x00050D10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_125(Class116 class116_31)
		{
			this.class116_23 = class116_31;
		}

		// Token: 0x060089F2 RID: 35314 RVA: 0x00052B19 File Offset: 0x00050D19
		[CompilerGenerated]
		internal PictureBox vmethod_126()
		{
			return this.pictureBox_5;
		}

		// Token: 0x060089F3 RID: 35315 RVA: 0x00052B21 File Offset: 0x00050D21
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_127(PictureBox pictureBox_8)
		{
			this.pictureBox_5 = pictureBox_8;
		}

		// Token: 0x060089F4 RID: 35316 RVA: 0x00052B2A File Offset: 0x00050D2A
		[CompilerGenerated]
		internal PictureBox vmethod_128()
		{
			return this.pictureBox_6;
		}

		// Token: 0x060089F5 RID: 35317 RVA: 0x00052B32 File Offset: 0x00050D32
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_129(PictureBox pictureBox_8)
		{
			this.pictureBox_6 = pictureBox_8;
		}

		// Token: 0x060089F6 RID: 35318 RVA: 0x00052B3B File Offset: 0x00050D3B
		[CompilerGenerated]
		internal PictureBox vmethod_130()
		{
			return this.pictureBox_7;
		}

		// Token: 0x060089F7 RID: 35319 RVA: 0x00052B43 File Offset: 0x00050D43
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_131(PictureBox pictureBox_8)
		{
			this.pictureBox_7 = pictureBox_8;
		}

		// Token: 0x060089F8 RID: 35320 RVA: 0x00052B4C File Offset: 0x00050D4C
		[CompilerGenerated]
		internal Class116 vmethod_132()
		{
			return this.class116_24;
		}

		// Token: 0x060089F9 RID: 35321 RVA: 0x00052B54 File Offset: 0x00050D54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_133(Class116 class116_31)
		{
			this.class116_24 = class116_31;
		}

		// Token: 0x060089FA RID: 35322 RVA: 0x00052B5D File Offset: 0x00050D5D
		[CompilerGenerated]
		internal Class116 vmethod_134()
		{
			return this.class116_25;
		}

		// Token: 0x060089FB RID: 35323 RVA: 0x00052B65 File Offset: 0x00050D65
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_135(Class116 class116_31)
		{
			this.class116_25 = class116_31;
		}

		// Token: 0x060089FC RID: 35324 RVA: 0x00052B6E File Offset: 0x00050D6E
		[CompilerGenerated]
		internal Class116 vmethod_136()
		{
			return this.class116_26;
		}

		// Token: 0x060089FD RID: 35325 RVA: 0x00052B76 File Offset: 0x00050D76
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_137(Class116 class116_31)
		{
			this.class116_26 = class116_31;
		}

		// Token: 0x060089FE RID: 35326 RVA: 0x00052B7F File Offset: 0x00050D7F
		[CompilerGenerated]
		internal Class116 vmethod_138()
		{
			return this.class116_27;
		}

		// Token: 0x060089FF RID: 35327 RVA: 0x00052B87 File Offset: 0x00050D87
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_139(Class116 class116_31)
		{
			this.class116_27 = class116_31;
		}

		// Token: 0x06008A00 RID: 35328 RVA: 0x00052B90 File Offset: 0x00050D90
		[CompilerGenerated]
		internal Class116 vmethod_140()
		{
			return this.class116_28;
		}

		// Token: 0x06008A01 RID: 35329 RVA: 0x00052B98 File Offset: 0x00050D98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_141(Class116 class116_31)
		{
			this.class116_28 = class116_31;
		}

		// Token: 0x06008A02 RID: 35330 RVA: 0x00052BA1 File Offset: 0x00050DA1
		[CompilerGenerated]
		internal Class112 vmethod_142()
		{
			return this.class112_2;
		}

		// Token: 0x06008A03 RID: 35331 RVA: 0x0049C0C0 File Offset: 0x0049A2C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_143(Class112 class112_5)
		{
			EventHandler value = new EventHandler(this.method_53);
			Class112 @class = this.class112_2;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_2 = class112_5;
			@class = this.class112_2;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06008A04 RID: 35332 RVA: 0x00052BA9 File Offset: 0x00050DA9
		[CompilerGenerated]
		private ShapeContainer vmethod_144()
		{
			return this.shapeContainer_0;
		}

		// Token: 0x06008A05 RID: 35333 RVA: 0x00052BB1 File Offset: 0x00050DB1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_145(ShapeContainer shapeContainer_1)
		{
			this.shapeContainer_0 = shapeContainer_1;
		}

		// Token: 0x06008A06 RID: 35334 RVA: 0x00052BBA File Offset: 0x00050DBA
		[CompilerGenerated]
		private LineShape vmethod_146()
		{
			return this.lineShape_0;
		}

		// Token: 0x06008A07 RID: 35335 RVA: 0x00052BC2 File Offset: 0x00050DC2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_147(LineShape lineShape_2)
		{
			this.lineShape_0 = lineShape_2;
		}

		// Token: 0x06008A08 RID: 35336 RVA: 0x00052BCB File Offset: 0x00050DCB
		[CompilerGenerated]
		private LineShape vmethod_148()
		{
			return this.lineShape_1;
		}

		// Token: 0x06008A09 RID: 35337 RVA: 0x00052BD3 File Offset: 0x00050DD3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_149(LineShape lineShape_2)
		{
			this.lineShape_1 = lineShape_2;
		}

		// Token: 0x06008A0A RID: 35338 RVA: 0x00052BDC File Offset: 0x00050DDC
		[CompilerGenerated]
		internal Class122 vmethod_150()
		{
			return this.class122_18;
		}

		// Token: 0x06008A0B RID: 35339 RVA: 0x0049C104 File Offset: 0x0049A304
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_151(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_14);
			Class122 @class = this.class122_18;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_18 = class122_21;
			@class = this.class122_18;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06008A0C RID: 35340 RVA: 0x00052BE4 File Offset: 0x00050DE4
		[CompilerGenerated]
		internal Class122 vmethod_152()
		{
			return this.class122_19;
		}

		// Token: 0x06008A0D RID: 35341 RVA: 0x0049C148 File Offset: 0x0049A348
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_153(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_30);
			Class122 @class = this.class122_19;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_19 = class122_21;
			@class = this.class122_19;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06008A0E RID: 35342 RVA: 0x00052BEC File Offset: 0x00050DEC
		[CompilerGenerated]
		internal Class122 vmethod_154()
		{
			return this.class122_20;
		}

		// Token: 0x06008A0F RID: 35343 RVA: 0x0049C18C File Offset: 0x0049A38C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_155(Class122 class122_21)
		{
			EventHandler value = new EventHandler(this.method_28);
			Class122 @class = this.class122_20;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class122_20 = class122_21;
			@class = this.class122_20;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06008A10 RID: 35344 RVA: 0x00052BF4 File Offset: 0x00050DF4
		[CompilerGenerated]
		internal Class112 vmethod_156()
		{
			return this.class112_3;
		}

		// Token: 0x06008A11 RID: 35345 RVA: 0x0049C1D0 File Offset: 0x0049A3D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_157(Class112 class112_5)
		{
			EventHandler value = new EventHandler(this.method_54);
			Class112 @class = this.class112_3;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_3 = class112_5;
			@class = this.class112_3;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008A12 RID: 35346 RVA: 0x00052BFC File Offset: 0x00050DFC
		[CompilerGenerated]
		internal Class112 vmethod_158()
		{
			return this.class112_4;
		}

		// Token: 0x06008A13 RID: 35347 RVA: 0x0049C214 File Offset: 0x0049A414
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_159(Class112 class112_5)
		{
			EventHandler value = new EventHandler(this.method_55);
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

		// Token: 0x06008A14 RID: 35348 RVA: 0x00052C04 File Offset: 0x00050E04
		[CompilerGenerated]
		internal FlowLayoutPanel vmethod_160()
		{
			return this.flowLayoutPanel_1;
		}

		// Token: 0x06008A15 RID: 35349 RVA: 0x00052C0C File Offset: 0x00050E0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_161(FlowLayoutPanel flowLayoutPanel_3)
		{
			this.flowLayoutPanel_1 = flowLayoutPanel_3;
		}

		// Token: 0x06008A16 RID: 35350 RVA: 0x00052C15 File Offset: 0x00050E15
		[CompilerGenerated]
		internal Class116 vmethod_162()
		{
			return this.class116_29;
		}

		// Token: 0x06008A17 RID: 35351 RVA: 0x00052C1D File Offset: 0x00050E1D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_163(Class116 class116_31)
		{
			this.class116_29 = class116_31;
		}

		// Token: 0x06008A18 RID: 35352 RVA: 0x00052C26 File Offset: 0x00050E26
		[CompilerGenerated]
		internal FlowLayoutPanel vmethod_164()
		{
			return this.flowLayoutPanel_2;
		}

		// Token: 0x06008A19 RID: 35353 RVA: 0x00052C2E File Offset: 0x00050E2E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_165(FlowLayoutPanel flowLayoutPanel_3)
		{
			this.flowLayoutPanel_2 = flowLayoutPanel_3;
		}

		// Token: 0x06008A1A RID: 35354 RVA: 0x00052C37 File Offset: 0x00050E37
		[CompilerGenerated]
		internal Class116 vmethod_166()
		{
			return this.class116_30;
		}

		// Token: 0x06008A1B RID: 35355 RVA: 0x00052C3F File Offset: 0x00050E3F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_167(Class116 class116_31)
		{
			this.class116_30 = class116_31;
		}

		// Token: 0x06008A1C RID: 35356 RVA: 0x00052C48 File Offset: 0x00050E48
		[CompilerGenerated]
		internal Class111 vmethod_168()
		{
			return this.class111_0;
		}

		// Token: 0x06008A1D RID: 35357 RVA: 0x0049C258 File Offset: 0x0049A458
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_169(Class111 class111_2)
		{
			EventHandler value = new EventHandler(this.method_56);
			Class111 @class = this.class111_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class111_0 = class111_2;
			@class = this.class111_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008A1E RID: 35358 RVA: 0x00052C50 File Offset: 0x00050E50
		[CompilerGenerated]
		internal Class111 vmethod_170()
		{
			return this.class111_1;
		}

		// Token: 0x06008A1F RID: 35359 RVA: 0x0049C29C File Offset: 0x0049A49C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_171(Class111 class111_2)
		{
			EventHandler value = new EventHandler(this.method_57);
			Class111 @class = this.class111_1;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class111_1 = class111_2;
			@class = this.class111_1;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008A20 RID: 35360 RVA: 0x00052C58 File Offset: 0x00050E58
		private void SpeedAlt_Load(object sender, EventArgs e)
		{
			this.method_3();
			this.vmethod_14().Interval = 250;
			this.vmethod_14().Start();
		}

		// Token: 0x06008A21 RID: 35361 RVA: 0x0049C2E0 File Offset: 0x0049A4E0
		public void method_3()
		{
			try
			{
				this.method_5(false);
				this.bool_6 = false;
				if (Class570.class280_0.method_12())
				{
					this.vmethod_76().Text = "ft";
				}
				else
				{
					this.vmethod_76().Text = "m";
					this.vmethod_64().Text = "High Altitude (10973 m)";
					this.vmethod_62().Text = "High Altitude (7620 m)";
					this.vmethod_54().Text = "Medium Altitude (3658 m)";
					this.vmethod_56().Text = "Low Altitude (610 m)";
					this.vmethod_60().Text = "Low Altitude (305 m)";
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (!this.activeUnit_0.bool_3 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.AirGroup))
					{
						this.vmethod_84().Text = "Stop";
						this.vmethod_82().Text = "Creep";
						this.vmethod_78().Text = "Full";
						this.vmethod_86().Text = "Flank";
					}
					else
					{
						this.vmethod_84().Text = "Hover";
						this.vmethod_82().Text = "Loiter";
						this.vmethod_78().Text = "Military";
						this.vmethod_86().Text = "Afterburner";
					}
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.vmethod_84().Text = "Hover";
					this.vmethod_82().Text = "Loiter";
					this.vmethod_78().Text = "Military";
					this.vmethod_86().Text = "Afterburner";
				}
				this.vmethod_76().Visible = false;
				this.vmethod_74().Visible = false;
				this.vmethod_36().Visible = false;
				this.vmethod_18().Visible = false;
				this.vmethod_20().Visible = false;
				this.vmethod_26().Visible = false;
				this.vmethod_28().Visible = false;
				this.vmethod_10().Visible = true;
				this.vmethod_12().Visible = true;
				this.vmethod_64().Enabled = true;
				this.vmethod_62().Enabled = true;
				this.vmethod_54().Enabled = true;
				this.vmethod_56().Enabled = true;
				this.vmethod_60().Enabled = true;
				this.vmethod_48().Enabled = true;
				this.vmethod_50().Enabled = true;
				this.vmethod_46().Enabled = true;
				this.vmethod_44().Enabled = true;
				this.vmethod_84().Enabled = true;
				this.vmethod_142().Enabled = true;
				this.vmethod_102().Enabled = false;
				this.vmethod_100().Enabled = false;
				float num;
				float num2;
				if (!Information.IsNothing(this.activeUnit_0))
				{
					num = this.activeUnit_0.vmethod_87().vmethod_30();
					num2 = this.activeUnit_0.vmethod_87().vmethod_31();
				}
				this.vmethod_16().Maximum = (int)Math.Round((double)num);
				this.vmethod_16().Minimum = (int)Math.Round((double)num2);
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (!this.activeUnit_0.bool_3 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.AirGroup))
					{
						if (this.activeUnit_0.bool_5 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup))
						{
							if (num2 > -20f)
							{
								this.vmethod_48().Enabled = false;
							}
							if (num2 > -40f)
							{
								this.vmethod_50().Enabled = false;
							}
							if ((num2 > Submarine_AI.smethod_2(this.activeUnit_0) && this.activeUnit_0.bool_5) | (num2 > Class167.smethod_2(this.activeUnit_0) && this.activeUnit_0.bool_1))
							{
								this.vmethod_46().Enabled = false;
							}
							if ((num2 > Submarine_AI.smethod_3(this.activeUnit_0) && this.activeUnit_0.bool_5) | (num2 > Class167.smethod_3(this.activeUnit_0) && this.activeUnit_0.bool_1))
							{
								this.vmethod_44().Enabled = false;
							}
						}
					}
					else
					{
						if (num * 3.28084f < 36000f)
						{
							this.vmethod_64().Enabled = false;
						}
						if (num * 3.28084f < 25000f)
						{
							this.vmethod_62().Enabled = false;
						}
						if (num * 3.28084f < 12000f)
						{
							this.vmethod_54().Enabled = false;
						}
						if (num * 3.28084f < 2000f)
						{
							this.vmethod_56().Enabled = false;
						}
						if (num * 3.28084f < 1000f)
						{
							this.vmethod_60().Enabled = false;
						}
					}
				}
				if (Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					if (!Information.IsNothing(this.activeUnit_0))
					{
						if (this.activeUnit_0.bool_5)
						{
							this.vmethod_40().Visible = true;
							this.vmethod_40().Enabled = true;
						}
						else if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup)
						{
							this.vmethod_40().Visible = true;
							this.vmethod_40().Enabled = true;
						}
						else
						{
							this.vmethod_40().Visible = false;
							this.vmethod_40().Enabled = false;
						}
						if (this.activeUnit_0.bool_3)
						{
							this.vmethod_52().Visible = true;
							this.vmethod_52().Enabled = true;
							this.vmethod_142().Enabled = true;
						}
						else if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)
						{
							this.vmethod_52().Visible = true;
							this.vmethod_52().Enabled = true;
							this.vmethod_142().Enabled = true;
						}
						else
						{
							this.vmethod_52().Visible = false;
							this.vmethod_52().Enabled = false;
							this.vmethod_142().Enabled = false;
						}
						if (this.activeUnit_0.bool_8)
						{
							this.vmethod_0().Minimum = 0;
							this.vmethod_0().Maximum = this.activeUnit_0.vmethod_87().vmethod_38();
							if (this.activeUnit_0.vmethod_70() > (float)this.vmethod_0().Maximum)
							{
								this.vmethod_0().Value = this.vmethod_0().Maximum;
							}
							else
							{
								this.vmethod_0().Value = (int)Math.Round((double)this.activeUnit_0.vmethod_70());
							}
						}
						else if (this.activeUnit_0.bool_5 || this.activeUnit_0.bool_3 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup) || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup))
						{
							this.vmethod_76().Visible = true;
							this.vmethod_74().Visible = true;
							this.vmethod_26().Visible = true;
							this.vmethod_28().Visible = true;
							this.vmethod_36().Visible = true;
							this.vmethod_18().Visible = true;
							this.vmethod_20().Visible = true;
							if (Class570.class280_0.method_12())
							{
								this.vmethod_22().Text = Conversions.ToString((int)Math.Round((double)(num * 3.28084f))) + " ft";
								this.vmethod_24().Text = Conversions.ToString((int)Math.Round((double)(num2 * 3.28084f))) + " ft";
							}
							else
							{
								this.vmethod_22().Text = Conversions.ToString(num) + " m";
								this.vmethod_24().Text = Conversions.ToString(num2) + " m";
							}
						}
						this.vmethod_150().Visible = false;
						this.vmethod_154().Visible = false;
						this.vmethod_152().Visible = false;
						if (this.activeUnit_0.bool_2 && ((Weapon)this.activeUnit_0).struct36_0.bool_16)
						{
							this.vmethod_142().Enabled = true;
						}
					}
				}
				else
				{
					this.vmethod_68().Checked = false;
					this.vmethod_48().Checked = false;
					this.vmethod_50().Checked = false;
					this.vmethod_46().Checked = false;
					this.vmethod_44().Checked = false;
					this.vmethod_42().Checked = false;
					this.vmethod_66().Checked = false;
					this.vmethod_64().Checked = false;
					this.vmethod_62().Checked = false;
					this.vmethod_54().Checked = false;
					this.vmethod_56().Checked = false;
					this.vmethod_60().Checked = false;
					this.vmethod_58().Checked = false;
					this.vmethod_84().Checked = false;
					this.vmethod_82().Checked = false;
					this.vmethod_80().Checked = false;
					this.vmethod_78().Checked = false;
					this.vmethod_86().Checked = false;
					this.vmethod_150().Checked = false;
					this.vmethod_154().Checked = false;
					this.vmethod_152().Checked = false;
					if (!Information.IsNothing(this.activeUnit_0))
					{
						if (this.activeUnit_0.bool_8)
						{
							this.vmethod_76().Visible = false;
							this.vmethod_74().Visible = false;
						}
						else if (!this.activeUnit_0.bool_5 && !this.activeUnit_0.bool_3 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.AirGroup))
						{
							this.vmethod_76().Visible = false;
							this.vmethod_74().Visible = false;
						}
						else
						{
							this.vmethod_76().Visible = true;
							this.vmethod_74().Visible = true;
						}
					}
					this.vmethod_102().Enabled = true;
					this.vmethod_100().Enabled = true;
					Waypoint waypoint;
					if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
					{
						waypoint = Client.smethod_58();
					}
					else
					{
						waypoint = this.waypoint_0;
					}
					switch (waypoint.method_35())
					{
					case ActiveUnit_Kinematics.UnitThrottlePreset.FullStop:
						this.vmethod_84().Checked = true;
						break;
					case ActiveUnit_Kinematics.UnitThrottlePreset.Loiter:
						this.vmethod_82().Checked = true;
						break;
					case ActiveUnit_Kinematics.UnitThrottlePreset.Cruise:
						this.vmethod_80().Checked = true;
						break;
					case ActiveUnit_Kinematics.UnitThrottlePreset.Full:
						this.vmethod_78().Checked = true;
						break;
					case ActiveUnit_Kinematics.UnitThrottlePreset.Flank:
						this.vmethod_86().Checked = true;
						break;
					}
					switch (waypoint.method_31())
					{
					case ActiveUnit_AI.AircraftAltitudePreset.MinAltitude:
						this.vmethod_58().Checked = true;
						break;
					case ActiveUnit_AI.AircraftAltitudePreset.Low1000:
						this.vmethod_60().Checked = true;
						break;
					case ActiveUnit_AI.AircraftAltitudePreset.Low2000:
						this.vmethod_56().Checked = true;
						break;
					case ActiveUnit_AI.AircraftAltitudePreset.Medium12000:
						this.vmethod_54().Checked = true;
						break;
					case ActiveUnit_AI.AircraftAltitudePreset.High25000:
						this.vmethod_62().Checked = true;
						break;
					case ActiveUnit_AI.AircraftAltitudePreset.High36000:
						this.vmethod_64().Checked = true;
						break;
					case ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude:
						this.vmethod_66().Checked = true;
						break;
					}
					switch (waypoint.method_33())
					{
					case ActiveUnit_AI.SubmarineDepthPreset.Periscope:
						this.vmethod_48().Checked = true;
						break;
					case ActiveUnit_AI.SubmarineDepthPreset.Shallow:
						this.vmethod_50().Checked = true;
						break;
					case ActiveUnit_AI.SubmarineDepthPreset.OverLayer:
						this.vmethod_46().Checked = true;
						break;
					case ActiveUnit_AI.SubmarineDepthPreset.UnderLayer:
						this.vmethod_44().Checked = true;
						break;
					case ActiveUnit_AI.SubmarineDepthPreset.MaxDepth:
						this.vmethod_42().Checked = true;
						break;
					case ActiveUnit_AI.SubmarineDepthPreset.Surface:
						this.vmethod_68().Checked = true;
						break;
					}
					if (!Information.IsNothing(this.activeUnit_0))
					{
						if (this.activeUnit_0.bool_5 || this.activeUnit_0.bool_3 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup) || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup))
						{
							this.vmethod_20().Visible = true;
							this.vmethod_26().Visible = true;
							this.vmethod_28().Visible = true;
							this.vmethod_76().Visible = true;
							this.vmethod_74().Visible = true;
							this.vmethod_36().Visible = true;
							this.vmethod_18().Visible = true;
							this.vmethod_20().Visible = true;
						}
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						this.vmethod_20().Visible = true;
						this.vmethod_26().Visible = true;
						this.vmethod_76().Visible = true;
						this.vmethod_74().Visible = true;
						this.vmethod_36().Visible = true;
						this.vmethod_20().Visible = true;
						this.vmethod_10().Visible = false;
						this.vmethod_12().Visible = false;
					}
					if (Information.IsNothing(waypoint.method_27()))
					{
						if (waypoint.method_35() != ActiveUnit_Kinematics.UnitThrottlePreset.None)
						{
							this.vmethod_150().Visible = true;
						}
						else
						{
							this.vmethod_150().Visible = false;
						}
					}
					else
					{
						this.vmethod_150().Visible = false;
					}
					this.vmethod_154().Visible = false;
					this.vmethod_152().Visible = false;
					if (!Information.IsNothing(this.activeUnit_0))
					{
						if (!this.activeUnit_0.bool_5)
						{
							if (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.SubGroup)
							{
								this.vmethod_40().Visible = false;
								this.vmethod_40().Enabled = false;
								goto IL_DA1;
							}
						}
						this.vmethod_40().Visible = true;
						this.vmethod_40().Enabled = true;
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						this.vmethod_40().Visible = false;
						this.vmethod_40().Enabled = false;
					}
					IL_DA1:
					if (!Information.IsNothing(this.activeUnit_0))
					{
						if (!this.activeUnit_0.bool_3 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.AirGroup))
						{
							this.vmethod_52().Visible = false;
							this.vmethod_52().Enabled = false;
						}
						else
						{
							this.vmethod_52().Visible = true;
							this.vmethod_52().Enabled = true;
							if (this.activeUnit_0.bool_3 && !((Aircraft)this.activeUnit_0).method_150(false))
							{
								this.vmethod_84().Enabled = false;
							}
							if (this.activeUnit_0.bool_1)
							{
								if (Information.IsNothing(((Group)this.activeUnit_0).method_147()))
								{
									return;
								}
								if (!((Aircraft)((Group)this.activeUnit_0).method_147()).method_150(false))
								{
									this.vmethod_84().Enabled = false;
								}
							}
							this.vmethod_142().Enabled = true;
						}
					}
					if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.bool_2)
					{
						this.vmethod_84().Enabled = false;
						this.vmethod_82().Enabled = false;
						if (((Weapon)this.activeUnit_0).struct36_0.bool_16)
						{
							this.vmethod_142().Enabled = true;
						}
					}
				}
				if (this.activeUnit_0 != null && this.activeUnit_0.bool_3 && !((Aircraft)this.activeUnit_0).method_150(false))
				{
					this.vmethod_84().Enabled = false;
				}
				if (!this.bool_7)
				{
					Client.smethod_16(new Client.Delegate80(this.method_4));
					Client.smethod_18(new Client.Delegate81(this.method_4));
					this.bool_7 = true;
				}
				this.bool_6 = true;
				Class2413.smethod_2().method_41().rightColumnWPF_0.vmethod_14().method_1(true);
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008A22 RID: 35362 RVA: 0x0049D29C File Offset: 0x0049B49C
		public void method_4()
		{
			try
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					this.method_52(false);
					if (this.bool_3)
					{
						this.bool_3 = false;
					}
					if (this.bool_4)
					{
						this.bool_4 = false;
					}
				}
				else if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.bool_0)
				{
					Side side_ = Client.smethod_50();
					Unit unit_ = this.activeUnit_0;
					bool flag = false;
					string text = null;
					if (GameGeneral.smethod_45(side_, unit_, flag, ref text, Client.smethod_52().method_59()))
					{
						this.method_52(false);
						if (this.bool_3)
						{
							this.bool_3 = false;
						}
						if (this.bool_4)
						{
							this.bool_4 = false;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200636", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008A23 RID: 35363 RVA: 0x0049D394 File Offset: 0x0049B594
		public void method_5(bool RefreshEvenIfNotVisible = false)
		{
			if (base.Visible || RefreshEvenIfNotVisible)
			{
				this.bool_6 = false;
				if (Client.smethod_58() == null)
				{
					this.vmethod_92().Visible = false;
					if (Client.smethod_54() != null)
					{
						this.vmethod_166().Text = "UNIT";
						this.vmethod_168().method_3(false);
					}
					else
					{
						this.vmethod_166().Text = "Nothing";
						this.vmethod_168().method_3(true);
					}
				}
				else
				{
					this.vmethod_92().Visible = true;
					if (Client.smethod_54() != null)
					{
						int num = Array.IndexOf<Waypoint>(((ActiveUnit)Client.smethod_54()).vmethod_85().method_4(), Client.smethod_58());
						this.vmethod_166().Text = "WAYPOINT #" + Conversions.ToString(num + 1);
						if (num == Enumerable.Count<Waypoint>(((ActiveUnit)Client.smethod_54()).vmethod_85().method_4()) - 1)
						{
							this.vmethod_170().method_3(false);
						}
						else
						{
							this.vmethod_170().method_3(true);
						}
					}
					else
					{
						this.vmethod_166().Text = "WAYPOINT";
					}
					this.vmethod_168().method_3(true);
				}
				try
				{
					if (Client.smethod_58() != null)
					{
						this.vmethod_158().method_1(true);
						if (Client.smethod_54() != null && (Client.smethod_54().bool_6 | Client.smethod_54().bool_5))
						{
							this.vmethod_158().Visible = true;
							if (Client.smethod_58().nullable_6 == null)
							{
								this.vmethod_158().CheckState = CheckState.Indeterminate;
							}
							else
							{
								this.vmethod_158().Checked = Client.smethod_58().nullable_6.Value;
							}
						}
						else
						{
							this.vmethod_158().Visible = false;
						}
					}
					else if (Client.smethod_54() == null)
					{
						this.vmethod_158().Visible = false;
					}
					else
					{
						this.vmethod_158().method_1(false);
						this.vmethod_158().CheckState = CheckState.Checked;
						if (Client.smethod_54().bool_6 | Client.smethod_54().bool_5)
						{
							this.vmethod_158().Visible = true;
							this.vmethod_158().Checked = ((ActiveUnit)Client.smethod_54()).vmethod_85().bool_15;
						}
						else
						{
							this.vmethod_158().Visible = false;
						}
					}
					if (Client.smethod_58() != null)
					{
						this.vmethod_156().method_1(true);
						if (Client.smethod_54() != null && (Client.smethod_54().bool_6 | Client.smethod_54().bool_5))
						{
							this.vmethod_156().Visible = true;
							if (Client.smethod_58().nullable_4 == null)
							{
								this.vmethod_156().CheckState = CheckState.Indeterminate;
							}
							else
							{
								this.vmethod_156().Checked = Client.smethod_58().nullable_4.Value;
							}
						}
						else
						{
							this.vmethod_156().Visible = false;
						}
					}
					else if (Client.smethod_54() == null)
					{
						this.vmethod_156().Visible = false;
					}
					else
					{
						this.vmethod_156().method_1(false);
						this.vmethod_156().CheckState = CheckState.Checked;
						if (Client.smethod_54().bool_6 | Client.smethod_54().bool_5)
						{
							this.vmethod_156().Visible = true;
							this.vmethod_156().Checked = ((ActiveUnit)Client.smethod_54()).vmethod_85().vmethod_3();
						}
						else
						{
							this.vmethod_156().Visible = false;
						}
					}
					if (this.activeUnit_0 == null & Client.smethod_58() == null & this.waypoint_0 == null)
					{
						return;
					}
					if (this.activeUnit_0 != null && this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_147() == null)
					{
						return;
					}
					if (Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
					{
						if (!this.activeUnit_0.bool_6 && !this.activeUnit_0.bool_5)
						{
							this.vmethod_140().Visible = false;
						}
						else
						{
							this.vmethod_140().Visible = true;
							int num2 = this.activeUnit_0.vmethod_87().method_7(this.activeUnit_0.vmethod_14(false));
							if (num2 == 2147483647)
							{
								this.vmethod_140().Font = new Font(this.vmethod_140().Font, FontStyle.Regular);
								this.vmethod_140().ForeColor = Color.LightGray;
								this.vmethod_140().Text = "Cavitation impossible";
							}
							else if (this.activeUnit_0.vmethod_40() >= (float)num2)
							{
								this.vmethod_140().Font = new Font(this.vmethod_140().Font, FontStyle.Bold);
								this.vmethod_140().ForeColor = Color.Red;
								this.vmethod_140().Text = "Cavitating!!! (" + Conversions.ToString(num2) + " kts)";
							}
							else
							{
								this.vmethod_140().Font = new Font(this.vmethod_140().Font, FontStyle.Regular);
								this.vmethod_140().ForeColor = Color.LightGray;
								this.vmethod_140().Text = "Cavitation at " + Conversions.ToString(num2) + " kts";
							}
						}
					}
					else
					{
						this.vmethod_140().Visible = false;
					}
					if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
					{
						if (Operators.CompareString(Client.smethod_58().Name, "", false) == 0)
						{
							this.Text = "Throttle & Altitude settings for: Navigation Waypoint";
						}
						else
						{
							this.Text = "Throttle & Altitude settings for: " + Client.smethod_58().Name;
						}
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						this.Text = string.Concat(new string[]
						{
							"Throttle & Altitude settings for: ",
							this.waypoint_0.Name,
							" (Type: ",
							Waypoint.smethod_23(this.waypoint_0.waypointType_0),
							")"
						});
					}
					else if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.bool_0)
					{
						this.Text = "Throttle & Altitude settings for: " + this.activeUnit_0.Name;
					}
					if (!Information.IsNothing(this.activeUnit_0))
					{
						this.vmethod_86().Enabled = (this.activeUnit_0.vmethod_82() == ActiveUnit.Throttle.Flank);
						this.vmethod_78().Enabled = (this.activeUnit_0.vmethod_82() >= ActiveUnit.Throttle.Full);
					}
					if (Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
					{
						if (!this.vmethod_0().Visible)
						{
							this.vmethod_0().Visible = true;
							this.vmethod_4().Visible = true;
							this.vmethod_2().Visible = true;
						}
						if (!this.activeUnit_0.bool_5 && !this.activeUnit_0.bool_7 && !this.activeUnit_0.bool_3 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.AirGroup))
						{
							if (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.SubGroup)
							{
								if (this.vmethod_16().Visible)
								{
									this.vmethod_16().Visible = false;
									this.vmethod_22().Visible = false;
									this.vmethod_24().Visible = false;
									goto IL_7B4;
								}
								goto IL_7B4;
							}
						}
						if (!this.vmethod_16().Visible)
						{
							this.vmethod_16().Visible = true;
							this.vmethod_22().Visible = true;
							this.vmethod_24().Visible = true;
						}
					}
					else
					{
						if (this.vmethod_0().Visible)
						{
							this.vmethod_0().Visible = false;
							this.vmethod_4().Visible = false;
							this.vmethod_2().Visible = false;
						}
						if (this.vmethod_16().Visible)
						{
							this.vmethod_16().Visible = false;
							this.vmethod_22().Visible = false;
							this.vmethod_24().Visible = false;
						}
					}
					IL_7B4:
					double num3 = 0.0;
					float num4 = 0f;
					float num5 = 0f;
					float num6 = 0f;
					float num7 = 0f;
					float num8;
					float num9;
					if (!Information.IsNothing(this.activeUnit_0))
					{
						num8 = this.activeUnit_0.vmethod_87().vmethod_30();
						num9 = this.activeUnit_0.vmethod_87().vmethod_31();
					}
					if (Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
					{
						if (!Information.IsNothing(this.activeUnit_0))
						{
							this.vmethod_0().Maximum = Math.Max(this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_82(), false), this.activeUnit_0.vmethod_87().vmethod_39(this.activeUnit_0.vmethod_72()));
							if (this.activeUnit_0.vmethod_85().vmethod_3())
							{
								this.vmethod_6().Text = "Desired Avg Speed:";
								this.vmethod_34().Enabled = false;
							}
							else
							{
								this.vmethod_6().Text = "Desired Speed:";
								this.vmethod_34().Enabled = true;
							}
							if (this.activeUnit_0.bool_1)
							{
								if (this.activeUnit_0.vmethod_85().vmethod_3())
								{
									this.vmethod_8().Text = string.Format("{0:0} kt", this.activeUnit_0.vmethod_85().vmethod_5().Value);
									this.vmethod_12().Text = string.Format("{0:0} kt", this.activeUnit_0.vmethod_40());
								}
								else
								{
									this.vmethod_8().Text = string.Format("{0:0} kt", this.activeUnit_0.vmethod_70());
									this.vmethod_12().Text = string.Format("{0:0} kt", this.activeUnit_0.vmethod_40());
								}
							}
							else
							{
								if (this.activeUnit_0.vmethod_85().vmethod_3())
								{
									this.vmethod_8().Text = string.Format("{0:0} kt", this.activeUnit_0.vmethod_85().vmethod_5().Value);
								}
								else
								{
									this.vmethod_8().Text = string.Format("{0:0} kt", this.activeUnit_0.vmethod_70());
								}
								this.vmethod_12().Text = string.Format("{0:0.0}", this.activeUnit_0.vmethod_40()) + " kt (Throttle: " + this.method_7() + ")";
							}
							if (!this.activeUnit_0.bool_3 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.AirGroup))
							{
								if (Class570.class280_0.method_12())
								{
									this.vmethod_26().Text = string.Format("{0:0}", this.activeUnit_0.vmethod_72() * 3.28084f, 0) + " ft";
									this.vmethod_28().Text = string.Format("{0:0}", this.activeUnit_0.vmethod_14(false) * 3.28084f, 0) + " ft";
								}
								else
								{
									this.vmethod_26().Text = string.Format("{0:0.0}", this.activeUnit_0.vmethod_72(), 0) + " m";
									this.vmethod_28().Text = string.Format("{0:0.0}", this.activeUnit_0.vmethod_14(false), 0) + " m";
								}
							}
							else
							{
								bool flag;
								float num10;
								if (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && !this.activeUnit_0.vmethod_87().vmethod_12())
								{
									flag = this.activeUnit_0.vmethod_65(false).method_147().vmethod_76(this.activeUnit_0.vmethod_65(false).method_147());
									num10 = this.activeUnit_0.vmethod_65(false).method_147().vmethod_74();
								}
								else
								{
									flag = this.activeUnit_0.vmethod_76(this.activeUnit_0);
									num10 = this.activeUnit_0.vmethod_74();
								}
								if (Class570.class280_0.method_12())
								{
									if (flag)
									{
										this.vmethod_26().Text = string.Format("{0:0}", num10 * 3.28084f) + " ft AGL";
									}
									else
									{
										this.vmethod_26().Text = string.Format("{0:0}", this.activeUnit_0.vmethod_72() * 3.28084f) + " ft ASL";
									}
									if (this.activeUnit_0.method_15())
									{
										this.vmethod_28().Text = string.Format("{0:0}", this.activeUnit_0.vmethod_14(false) * 3.28084f) + " ft ASL (" + string.Format("{0:0}", this.activeUnit_0.vmethod_13() * 3.28084f) + " ft AGL)";
									}
									else
									{
										this.vmethod_28().Text = string.Format("{0:0}", this.activeUnit_0.vmethod_14(false) * 3.28084f) + " ft ASL";
									}
								}
								else
								{
									if (flag)
									{
										this.vmethod_26().Text = string.Format("{0:0.0}", num10) + " m AGL";
									}
									else
									{
										this.vmethod_26().Text = string.Format("{0:0.0}", this.activeUnit_0.vmethod_72()) + " m ASL";
									}
									if (this.activeUnit_0.method_15())
									{
										this.vmethod_28().Text = string.Format("{0:0.0}", this.activeUnit_0.vmethod_14(false)) + " m ASL (" + string.Format("{0:0.0}", this.activeUnit_0.vmethod_13()) + " m AGL)";
									}
									else
									{
										this.vmethod_28().Text = string.Format("{0:0.0}", this.activeUnit_0.vmethod_14(false)) + " m ASL";
									}
								}
							}
							if (this.activeUnit_0.bool_1)
							{
								Group group = (Group)this.activeUnit_0;
								if (!Information.IsNothing(group.method_147()))
								{
									this.vmethod_142().Checked = group.method_147().vmethod_76(group.method_147());
								}
							}
							else
							{
								this.vmethod_142().Checked = this.activeUnit_0.vmethod_76(this.activeUnit_0);
							}
							if (!this.bool_4)
							{
								bool flag2;
								float num11;
								if (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && !this.activeUnit_0.vmethod_87().vmethod_12())
								{
									flag2 = this.activeUnit_0.vmethod_65(false).method_147().vmethod_76(this.activeUnit_0.vmethod_65(false).method_147());
									num11 = this.activeUnit_0.vmethod_65(false).method_147().vmethod_74();
								}
								else
								{
									flag2 = this.activeUnit_0.vmethod_76(this.activeUnit_0);
									num11 = this.activeUnit_0.vmethod_74();
								}
								if (Class570.class280_0.method_12())
								{
									if (this.activeUnit_0.bool_1 && (((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup | ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup))
									{
										if (flag2)
										{
											this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)(num11 * 3.28084f)));
										}
										else
										{
											this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)(this.activeUnit_0.vmethod_72() * 3.28084f)));
										}
									}
									else if (this.activeUnit_0.bool_3 | this.activeUnit_0.bool_5)
									{
										if (flag2)
										{
											this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)(num11 * 3.28084f)));
										}
										else
										{
											this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)(this.activeUnit_0.vmethod_72() * 3.28084f)));
										}
									}
								}
								else if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)
								{
									if (this.activeUnit_0.vmethod_76(this.activeUnit_0))
									{
										this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)this.activeUnit_0.vmethod_74()));
									}
									else
									{
										this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)this.activeUnit_0.vmethod_72()));
									}
								}
								else if (this.activeUnit_0.bool_3 | this.activeUnit_0.bool_5)
								{
									if (this.activeUnit_0.vmethod_76(this.activeUnit_0))
									{
										this.vmethod_74().Text = Conversions.ToString(this.activeUnit_0.vmethod_74());
									}
									else
									{
										this.vmethod_74().Text = Conversions.ToString(this.activeUnit_0.vmethod_72());
									}
								}
								if (!this.bool_3)
								{
									this.vmethod_70().Text = Conversions.ToString(this.activeUnit_0.vmethod_70());
								}
							}
							if (this.activeUnit_0.bool_1)
							{
								if (Information.IsNothing(((Group)this.activeUnit_0).method_147()))
								{
									return;
								}
								this.vmethod_38().Checked = (this.activeUnit_0.vmethod_87().vmethod_10() != null);
								this.vmethod_36().Checked = this.activeUnit_0.vmethod_87().vmethod_12();
							}
							else
							{
								this.vmethod_38().Checked = (this.activeUnit_0.vmethod_87().vmethod_10() != null);
								this.vmethod_36().Checked = this.activeUnit_0.vmethod_87().vmethod_12();
							}
							this.vmethod_2().Text = this.vmethod_0().Minimum.ToString() + " kt";
							this.vmethod_4().Text = this.vmethod_0().Maximum.ToString() + " kt";
							if (this.activeUnit_0.vmethod_85().vmethod_3() && !Information.IsNothing(this.activeUnit_0.vmethod_85().vmethod_5()))
							{
								if (this.activeUnit_0.vmethod_85().vmethod_5().Value > (float)this.vmethod_0().Maximum)
								{
									this.vmethod_0().Value = this.vmethod_0().Maximum;
								}
								else if (this.activeUnit_0.vmethod_85().vmethod_5().Value < (float)this.vmethod_0().Minimum)
								{
									this.vmethod_0().Value = this.vmethod_0().Minimum;
								}
								else
								{
									this.vmethod_0().Value = (int)Math.Round((double)this.activeUnit_0.vmethod_85().vmethod_5().Value);
								}
							}
							else if (this.activeUnit_0.vmethod_70() > (float)this.vmethod_0().Maximum)
							{
								this.vmethod_0().Value = this.vmethod_0().Maximum;
							}
							else if (this.activeUnit_0.vmethod_70() < (float)this.vmethod_0().Minimum)
							{
								this.vmethod_0().Value = this.vmethod_0().Minimum;
							}
							else
							{
								this.vmethod_0().Value = (int)Math.Round((double)this.activeUnit_0.vmethod_70());
							}
							if (this.activeUnit_0.vmethod_72() > (float)this.vmethod_16().Maximum)
							{
								this.vmethod_16().Value = this.vmethod_16().Maximum;
							}
							else if (this.activeUnit_0.vmethod_72() < (float)this.vmethod_16().Minimum)
							{
								this.vmethod_16().Value = this.vmethod_16().Minimum;
							}
							else
							{
								this.vmethod_16().Value = (int)Math.Round((double)this.activeUnit_0.vmethod_72());
							}
							bool flag3 = false;
							if (this.activeUnit_0.bool_3 | this.activeUnit_0.bool_6 | this.activeUnit_0.bool_5)
							{
								flag3 = true;
							}
							if (this.activeUnit_0.bool_1 && (((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup | ((Group)this.activeUnit_0).method_143() == Group.GroupType.SurfaceGroup | ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup))
							{
								flag3 = true;
							}
							if (flag3 && Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_4()) > 0)
							{
								try
								{
									if (this.activeUnit_0.vmethod_40() > 0f && this.activeUnit_0.vmethod_70() > 0f)
									{
										num3 = (double)this.activeUnit_0.method_23(this.activeUnit_0.vmethod_85().method_4()[0]);
										num4 = (float)(num3 / (double)this.activeUnit_0.vmethod_40() * 3600.0);
										num5 = (float)(num3 / (double)this.activeUnit_0.vmethod_70() * 3600.0);
										ActiveUnit activeUnit;
										if (this.activeUnit_0.bool_1)
										{
											activeUnit = ((Group)this.activeUnit_0).method_147();
										}
										else
										{
											activeUnit = this.activeUnit_0;
										}
										num6 = num4 * activeUnit.vmethod_98(activeUnit.vmethod_87().vmethod_41(activeUnit.vmethod_14(false), (float)((int)Math.Round((double)activeUnit.vmethod_40()))), null, new float?((float)((int)Math.Round((double)activeUnit.vmethod_40()))), new float?(activeUnit.vmethod_14(false)), false, false, false, false, false);
										num7 = num5 * activeUnit.vmethod_98(activeUnit.vmethod_84(), null, new float?((float)((int)Math.Round((double)activeUnit.vmethod_70()))), new float?(activeUnit.vmethod_72()), false, false, false, false, false);
										this.vmethod_96().Text = "DTG: " + string.Format("{0:0} nm", num3);
										if ((int)Math.Round((double)num5) != (int)Math.Round((double)num4))
										{
											this.vmethod_94().Text = string.Concat(new string[]
											{
												"TTG: ",
												Misc.smethod_11((long)Math.Round((double)num4), Aircraft_AirOps.Enum44.const_0, false, false),
												" (Current), ",
												Misc.smethod_11((long)Math.Round((double)num5), Aircraft_AirOps.Enum44.const_0, false, false),
												" (Desired) "
											});
											this.vmethod_98().Text = string.Concat(new string[]
											{
												"Fuel qty required: ",
												string.Format("{0:0.0}", num6, 1),
												" kg (Current), ",
												string.Format("{0:0.0}", num7, 1),
												" kg (Desired) "
											});
										}
										else
										{
											this.vmethod_94().Text = "TTG: " + Misc.smethod_11((long)Math.Round((double)num5), Aircraft_AirOps.Enum44.const_0, false, false);
											this.vmethod_98().Text = "Fuel qty required: " + string.Format("{0:0.0}", num7, 1) + " kg";
										}
										if (Operators.CompareString(this.activeUnit_0.vmethod_85().method_4()[0].Name, "", false) == 0)
										{
											this.vmethod_90().Text = "Next waypoint: Navigation Waypoint ";
										}
										else
										{
											this.vmethod_90().Text = "Next waypoint: " + this.activeUnit_0.vmethod_85().method_4()[0].Name;
										}
									}
									else
									{
										this.vmethod_90().Text = "One or more speed order is 0kt, can not estimate DTG/TTG/Fuel qty";
										this.vmethod_96().Text = "";
										this.vmethod_94().Text = "";
										this.vmethod_98().Text = "";
									}
									this.vmethod_100().Text = this.activeUnit_0.vmethod_85().method_4()[0].string_2;
									Waypoint.WaypointType waypointType_ = this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0;
									if (waypointType_ <= Waypoint.WaypointType.Assemble)
									{
										if (waypointType_ != Waypoint.WaypointType.ManualPlottedCourseWaypoint)
										{
											if (waypointType_ == Waypoint.WaypointType.Assemble)
											{
												this.vmethod_102().SelectedIndex = 0;
											}
										}
										else
										{
											this.vmethod_102().SelectedIndex = 1;
										}
									}
									else if (waypointType_ == Waypoint.WaypointType.Target || waypointType_ == Waypoint.WaypointType.WeaponTarget)
									{
										this.vmethod_102().SelectedIndex = 2;
									}
									goto IL_18F1;
								}
								catch (Exception ex)
								{
									ex.Data.Add("Error at 200414", ex.Message);
									GameGeneral.smethod_25(ref ex);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									goto IL_18F1;
								}
							}
							this.vmethod_90().Text = "";
							this.vmethod_96().Text = "";
							this.vmethod_94().Text = "";
							this.vmethod_98().Text = "";
							this.vmethod_100().Text = "";
							this.vmethod_102().SelectedIndex = -1;
							IL_18F1:
							this.vmethod_16().Maximum = (int)Math.Round((double)num8);
							this.vmethod_16().Minimum = (int)Math.Round((double)num9);
							if (this.activeUnit_0.bool_3)
							{
								if (!((Aircraft)this.activeUnit_0).method_150(false))
								{
									this.vmethod_0().Minimum = ((Aircraft)this.activeUnit_0).method_159().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Loiter, false);
									this.vmethod_84().Enabled = false;
								}
								this.vmethod_80().Enabled = true;
								this.vmethod_82().Enabled = true;
							}
							else if (this.activeUnit_0.bool_6)
							{
								this.vmethod_0().Minimum = 0;
								this.vmethod_80().Enabled = true;
								this.vmethod_82().Enabled = true;
								this.vmethod_84().Enabled = true;
							}
							else if (this.activeUnit_0.bool_5)
							{
								this.vmethod_0().Minimum = 0;
								this.vmethod_80().Enabled = true;
								this.vmethod_82().Enabled = true;
								this.vmethod_84().Enabled = true;
							}
							else if (this.activeUnit_0.bool_8)
							{
								this.vmethod_0().Minimum = 0;
								if (((Facility)this.activeUnit_0)._FacilityCategory_0 != Facility._FacilityCategory.Mobile_Vehicle)
								{
									if (((Facility)this.activeUnit_0)._FacilityCategory_0 != Facility._FacilityCategory.Mobile_Personnel)
									{
										this.vmethod_82().Enabled = false;
										this.vmethod_80().Enabled = false;
										this.vmethod_84().Enabled = true;
										goto IL_1BDF;
									}
								}
								this.vmethod_82().Enabled = true;
								this.vmethod_80().Enabled = true;
								this.vmethod_84().Enabled = true;
							}
							else if (this.activeUnit_0.bool_2)
							{
								this.vmethod_0().Minimum = ((Weapon)this.activeUnit_0).vmethod_143().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Cruise, false);
								this.vmethod_84().Enabled = false;
								this.vmethod_82().Enabled = false;
								this.vmethod_80().Enabled = true;
							}
							else if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)
							{
								if (Information.IsNothing(((Group)this.activeUnit_0).method_147()))
								{
									return;
								}
								Aircraft aircraft = (Aircraft)((Group)this.activeUnit_0).method_147();
								if (!aircraft.method_150(false))
								{
									this.vmethod_0().Minimum = aircraft.method_159().vmethod_40(aircraft.vmethod_14(false), ActiveUnit.Throttle.Loiter, false);
									this.vmethod_84().Enabled = false;
								}
								this.vmethod_82().Enabled = true;
							}
							else
							{
								this.vmethod_0().Minimum = (int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_32(this.activeUnit_0.vmethod_14(false), false));
							}
							IL_1BDF:
							if (this.activeUnit_0.bool_5 && !Information.IsNothing(this.activeUnit_0.vmethod_87().vmethod_1()) && this.activeUnit_0.vmethod_70() != (float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), (ActiveUnit.Throttle)this.activeUnit_0.vmethod_87().vmethod_1(), false))
							{
								this.vmethod_84().Checked = false;
								this.vmethod_82().Checked = false;
								this.vmethod_80().Checked = false;
								this.vmethod_78().Checked = false;
								this.vmethod_86().Checked = false;
								switch (this.activeUnit_0.vmethod_87().vmethod_1())
								{
								case ActiveUnit_Kinematics.UnitThrottlePreset.FullStop:
									this.vmethod_84().Checked = true;
									break;
								case ActiveUnit_Kinematics.UnitThrottlePreset.Loiter:
									this.vmethod_82().Checked = true;
									break;
								case ActiveUnit_Kinematics.UnitThrottlePreset.Cruise:
									this.vmethod_80().Checked = true;
									break;
								case ActiveUnit_Kinematics.UnitThrottlePreset.Full:
									this.vmethod_78().Checked = true;
									break;
								case ActiveUnit_Kinematics.UnitThrottlePreset.Flank:
									this.vmethod_86().Checked = true;
									break;
								}
							}
							if (!Information.IsNothing(this.activeUnit_0.vmethod_87().vmethod_1()))
							{
								switch (this.activeUnit_0.vmethod_87().vmethod_1())
								{
								case ActiveUnit_Kinematics.UnitThrottlePreset.FullStop:
									if (!this.vmethod_84().Checked)
									{
										this.vmethod_84().Checked = true;
									}
									break;
								case ActiveUnit_Kinematics.UnitThrottlePreset.Loiter:
									if (!this.vmethod_82().Checked)
									{
										this.vmethod_82().Checked = true;
									}
									break;
								case ActiveUnit_Kinematics.UnitThrottlePreset.Cruise:
									if (!this.vmethod_80().Checked)
									{
										this.vmethod_80().Checked = true;
									}
									break;
								case ActiveUnit_Kinematics.UnitThrottlePreset.Full:
									if (!this.vmethod_78().Checked)
									{
										this.vmethod_78().Checked = true;
									}
									break;
								case ActiveUnit_Kinematics.UnitThrottlePreset.Flank:
									if (!this.vmethod_86().Checked)
									{
										this.vmethod_86().Checked = true;
									}
									break;
								case ActiveUnit_Kinematics.UnitThrottlePreset.None:
									if (!this.vmethod_150().Checked)
									{
										this.vmethod_150().Checked = true;
									}
									break;
								default:
									if (this.vmethod_84().Checked)
									{
										this.vmethod_84().Checked = false;
									}
									if (this.vmethod_82().Checked)
									{
										this.vmethod_82().Checked = false;
									}
									if (this.vmethod_80().Checked)
									{
										this.vmethod_80().Checked = false;
									}
									if (this.vmethod_78().Checked)
									{
										this.vmethod_78().Checked = false;
									}
									if (this.vmethod_86().Checked)
									{
										this.vmethod_86().Checked = false;
									}
									if (this.vmethod_150().Checked)
									{
										this.vmethod_150().Checked = false;
									}
									break;
								}
							}
							else
							{
								this.vmethod_84().Checked = false;
								this.vmethod_82().Checked = false;
								this.vmethod_80().Checked = false;
								this.vmethod_78().Checked = false;
								this.vmethod_86().Checked = false;
								this.vmethod_150().Checked = false;
							}
							if (this.activeUnit_0.bool_3)
							{
								switch (((Aircraft)this.activeUnit_0).method_158().method_114())
								{
								case ActiveUnit_AI.AircraftAltitudePreset.None:
									if (!this.vmethod_152().Checked)
									{
										this.vmethod_152().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.MinAltitude:
									if (!this.vmethod_58().Checked)
									{
										this.vmethod_58().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.Low1000:
									if (!this.vmethod_60().Checked)
									{
										this.vmethod_60().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.Low2000:
									if (!this.vmethod_56().Checked)
									{
										this.vmethod_56().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.Medium12000:
									if (!this.vmethod_54().Checked)
									{
										this.vmethod_54().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.High25000:
									if (!this.vmethod_62().Checked)
									{
										this.vmethod_62().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.High36000:
									if (!this.vmethod_64().Checked)
									{
										this.vmethod_64().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude:
									if (!this.vmethod_66().Checked)
									{
										this.vmethod_66().Checked = true;
									}
									break;
								default:
									if (this.vmethod_66().Checked)
									{
										this.vmethod_66().Checked = false;
									}
									if (this.vmethod_64().Checked)
									{
										this.vmethod_64().Checked = false;
									}
									if (this.vmethod_62().Checked)
									{
										this.vmethod_62().Checked = false;
									}
									if (this.vmethod_54().Checked)
									{
										this.vmethod_54().Checked = false;
									}
									if (this.vmethod_56().Checked)
									{
										this.vmethod_56().Checked = false;
									}
									if (this.vmethod_60().Checked)
									{
										this.vmethod_60().Checked = false;
									}
									if (this.vmethod_58().Checked)
									{
										this.vmethod_58().Checked = false;
									}
									if (this.vmethod_152().Checked)
									{
										this.vmethod_152().Checked = false;
									}
									break;
								}
							}
							else if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)
							{
								switch (((Aircraft_AI)((Group)this.activeUnit_0).method_147().vmethod_86()).method_114())
								{
								case ActiveUnit_AI.AircraftAltitudePreset.None:
									if (!this.vmethod_152().Checked)
									{
										this.vmethod_152().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.MinAltitude:
									if (!this.vmethod_58().Checked)
									{
										this.vmethod_58().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.Low1000:
									if (!this.vmethod_60().Checked)
									{
										this.vmethod_60().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.Low2000:
									if (!this.vmethod_56().Checked)
									{
										this.vmethod_56().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.Medium12000:
									if (!this.vmethod_54().Checked)
									{
										this.vmethod_54().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.High25000:
									if (!this.vmethod_62().Checked)
									{
										this.vmethod_62().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.High36000:
									if (!this.vmethod_64().Checked)
									{
										this.vmethod_64().Checked = true;
									}
									break;
								case ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude:
									if (!this.vmethod_66().Checked)
									{
										this.vmethod_66().Checked = true;
									}
									break;
								default:
									if (this.vmethod_66().Checked)
									{
										this.vmethod_66().Checked = false;
									}
									if (this.vmethod_64().Checked)
									{
										this.vmethod_64().Checked = false;
									}
									if (this.vmethod_62().Checked)
									{
										this.vmethod_62().Checked = false;
									}
									if (this.vmethod_54().Checked)
									{
										this.vmethod_54().Checked = false;
									}
									if (this.vmethod_56().Checked)
									{
										this.vmethod_56().Checked = false;
									}
									if (this.vmethod_60().Checked)
									{
										this.vmethod_60().Checked = false;
									}
									if (this.vmethod_58().Checked)
									{
										this.vmethod_58().Checked = false;
									}
									if (this.vmethod_152().Checked)
									{
										this.vmethod_152().Checked = false;
									}
									break;
								}
							}
							if (this.activeUnit_0.bool_5)
							{
								switch (((Submarine)this.activeUnit_0).method_153().method_114())
								{
								case ActiveUnit_AI.SubmarineDepthPreset.None:
									if (!this.vmethod_154().Checked)
									{
										this.vmethod_154().Checked = true;
									}
									break;
								case ActiveUnit_AI.SubmarineDepthPreset.Periscope:
									if (!this.vmethod_48().Checked)
									{
										this.vmethod_48().Checked = true;
									}
									break;
								case ActiveUnit_AI.SubmarineDepthPreset.Shallow:
									if (!this.vmethod_50().Checked)
									{
										this.vmethod_50().Checked = true;
									}
									break;
								case ActiveUnit_AI.SubmarineDepthPreset.OverLayer:
									if (!this.vmethod_46().Checked)
									{
										this.vmethod_46().Checked = true;
									}
									break;
								case ActiveUnit_AI.SubmarineDepthPreset.UnderLayer:
									if (!this.vmethod_44().Checked)
									{
										this.vmethod_44().Checked = true;
									}
									break;
								case ActiveUnit_AI.SubmarineDepthPreset.MaxDepth:
									if (!this.vmethod_42().Checked)
									{
										this.vmethod_42().Checked = true;
									}
									break;
								case ActiveUnit_AI.SubmarineDepthPreset.Surface:
									if (!this.vmethod_68().Checked)
									{
										this.vmethod_68().Checked = true;
									}
									break;
								default:
									if (this.vmethod_68().Checked)
									{
										this.vmethod_68().Checked = false;
									}
									if (this.vmethod_48().Checked)
									{
										this.vmethod_48().Checked = false;
									}
									if (this.vmethod_50().Checked)
									{
										this.vmethod_50().Checked = false;
									}
									if (this.vmethod_46().Checked)
									{
										this.vmethod_46().Checked = false;
									}
									if (this.vmethod_44().Checked)
									{
										this.vmethod_44().Checked = false;
									}
									if (this.vmethod_42().Checked)
									{
										this.vmethod_42().Checked = false;
									}
									if (this.vmethod_154().Checked)
									{
										this.vmethod_154().Checked = false;
									}
									break;
								}
							}
							else if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup)
							{
								switch (((Submarine_AI)((Group)this.activeUnit_0).method_147().vmethod_86()).method_114())
								{
								case ActiveUnit_AI.SubmarineDepthPreset.None:
									if (!this.vmethod_154().Checked)
									{
										this.vmethod_154().Checked = true;
									}
									break;
								case ActiveUnit_AI.SubmarineDepthPreset.Periscope:
									if (!this.vmethod_48().Checked)
									{
										this.vmethod_48().Checked = true;
									}
									break;
								case ActiveUnit_AI.SubmarineDepthPreset.Shallow:
									if (!this.vmethod_50().Checked)
									{
										this.vmethod_50().Checked = true;
									}
									break;
								case ActiveUnit_AI.SubmarineDepthPreset.OverLayer:
									if (!this.vmethod_46().Checked)
									{
										this.vmethod_46().Checked = true;
									}
									break;
								case ActiveUnit_AI.SubmarineDepthPreset.UnderLayer:
									if (!this.vmethod_44().Checked)
									{
										this.vmethod_44().Checked = true;
									}
									break;
								case ActiveUnit_AI.SubmarineDepthPreset.MaxDepth:
									if (!this.vmethod_42().Checked)
									{
										this.vmethod_42().Checked = true;
									}
									break;
								case ActiveUnit_AI.SubmarineDepthPreset.Surface:
									if (!this.vmethod_68().Checked)
									{
										this.vmethod_68().Checked = true;
									}
									break;
								default:
									if (this.vmethod_68().Checked)
									{
										this.vmethod_68().Checked = false;
									}
									if (this.vmethod_48().Checked)
									{
										this.vmethod_48().Checked = false;
									}
									if (this.vmethod_50().Checked)
									{
										this.vmethod_50().Checked = false;
									}
									if (this.vmethod_46().Checked)
									{
										this.vmethod_46().Checked = false;
									}
									if (this.vmethod_44().Checked)
									{
										this.vmethod_44().Checked = false;
									}
									if (this.vmethod_42().Checked)
									{
										this.vmethod_42().Checked = false;
									}
									if (this.vmethod_154().Checked)
									{
										this.vmethod_154().Checked = false;
									}
									break;
								}
							}
						}
					}
					else
					{
						Waypoint waypoint;
						if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
						{
							waypoint = Client.smethod_58();
						}
						else
						{
							waypoint = this.waypoint_0;
						}
						if (waypoint.nullable_4.GetValueOrDefault())
						{
							this.vmethod_6().Text = "Desired Avg Speed:";
							this.vmethod_34().Enabled = false;
						}
						else
						{
							this.vmethod_6().Text = "Desired Speed:";
							this.vmethod_34().Enabled = true;
						}
						if (((Information.IsNothing(waypoint) || Information.IsNothing(waypoint.nullable_4)) ? new bool?(false) : waypoint.nullable_4).GetValueOrDefault())
						{
							if (!Information.IsNothing(waypoint.nullable_5))
							{
								this.vmethod_8().Text = string.Format("{0:0} kt", waypoint.nullable_5.Value);
							}
							else
							{
								this.vmethod_8().Text = "Avg sprint-drift speed not entered!";
							}
						}
						else if (waypoint.method_27() != null)
						{
							if (!Information.IsNothing(waypoint.nullable_0))
							{
								this.vmethod_8().Text = string.Format("{0:0}", waypoint.nullable_0.Value) + " kt";
							}
							else
							{
								if (waypoint.method_35() == ActiveUnit_Kinematics.UnitThrottlePreset.FullStop)
								{
									this.vmethod_8().Text = "Full Stop";
								}
								if (waypoint.method_35() == ActiveUnit_Kinematics.UnitThrottlePreset.Loiter)
								{
									if (Information.IsNothing(this.waypoint_0) && !this.activeUnit_0.bool_3 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.AirGroup))
									{
										this.vmethod_8().Text = "Creep";
									}
									else
									{
										this.vmethod_8().Text = "Loiter";
									}
								}
								if (waypoint.method_35() == ActiveUnit_Kinematics.UnitThrottlePreset.Cruise)
								{
									this.vmethod_8().Text = "Cruise";
								}
								if (waypoint.method_35() == ActiveUnit_Kinematics.UnitThrottlePreset.Full)
								{
									if (Information.IsNothing(this.waypoint_0) && !this.activeUnit_0.bool_3 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.AirGroup))
									{
										this.vmethod_8().Text = "Full";
									}
									else
									{
										this.vmethod_8().Text = "Military";
									}
								}
								if (waypoint.method_35() == ActiveUnit_Kinematics.UnitThrottlePreset.Flank)
								{
									if (Information.IsNothing(this.waypoint_0) && !this.activeUnit_0.bool_3 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.AirGroup))
									{
										this.vmethod_8().Text = "Flank";
									}
									else
									{
										this.vmethod_8().Text = "Afterburner";
									}
								}
							}
						}
						else
						{
							this.vmethod_8().Text = "Not Set";
						}
						if (waypoint.method_29() && !Information.IsNothing(waypoint.nullable_1))
						{
							if (Information.IsNothing(waypoint.nullable_1) && Information.IsNothing(waypoint.nullable_2))
							{
								if (!Information.IsNothing(this.activeUnit_0))
								{
									if (this.activeUnit_0.bool_5 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.SubGroup) && waypoint.method_33() == ActiveUnit_AI.SubmarineDepthPreset.MaxDepth)
									{
										this.vmethod_26().Text = "Max Depth";
									}
									if (this.activeUnit_0.bool_3 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup))
									{
										if (waypoint.method_31() == ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude)
										{
											this.vmethod_26().Text = "Max Altitude";
										}
										if (waypoint.method_31() == ActiveUnit_AI.AircraftAltitudePreset.MinAltitude)
										{
											this.vmethod_26().Text = "Min Altitude";
										}
									}
								}
								else if (!Information.IsNothing(this.waypoint_0))
								{
									if (waypoint.method_31() == ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude)
									{
										this.vmethod_26().Text = "Max Altitude";
									}
									if (waypoint.method_31() == ActiveUnit_AI.AircraftAltitudePreset.MinAltitude)
									{
										this.vmethod_26().Text = "Min Altitude";
									}
								}
							}
							else if (Class570.class280_0.method_12())
							{
								if (Information.IsNothing(this.waypoint_0) && !this.activeUnit_0.bool_3 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.AirGroup))
								{
									this.vmethod_26().Text = Conversions.ToString((int)Math.Round((double)(waypoint.nullable_1 * 3.28084f).Value)) + " ft";
								}
								else if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
								{
									this.vmethod_26().Text = Conversions.ToString((int)Math.Round((double)(waypoint.nullable_2 * 3.28084f).Value)) + " ft AGL";
								}
								else if (!Information.IsNothing(waypoint.nullable_1))
								{
									this.vmethod_26().Text = Conversions.ToString((int)Math.Round((double)(waypoint.nullable_1 * 3.28084f).Value)) + " ft ASL";
								}
							}
							else if (Information.IsNothing(this.waypoint_0) && !this.activeUnit_0.bool_3 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.AirGroup))
							{
								this.vmethod_26().Text = Conversions.ToString((int)Math.Round((double)waypoint.nullable_1.Value)) + " m";
							}
							else if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
							{
								this.vmethod_26().Text = Conversions.ToString((int)Math.Round((double)waypoint.nullable_2.Value)) + " m AGL";
							}
							else if (!Information.IsNothing(waypoint.nullable_1))
							{
								this.vmethod_26().Text = Conversions.ToString((int)Math.Round((double)waypoint.nullable_1.Value)) + " m ASL";
							}
						}
						else
						{
							this.vmethod_26().Text = "Not Set";
						}
						if (!this.bool_3)
						{
							this.vmethod_70().Text = this.vmethod_8().Text;
						}
						if (!this.bool_4)
						{
							this.vmethod_74().Text = this.vmethod_26().Text;
						}
						this.vmethod_142().Checked = waypoint.method_37();
						if (!Information.IsNothing(this.activeUnit_0))
						{
							if (this.activeUnit_0.bool_1)
							{
								this.vmethod_12().Text = string.Format("{0:0} kt", ((Group)this.activeUnit_0).method_147().vmethod_40());
							}
							else
							{
								this.vmethod_12().Text = string.Format("{0:0} kt (Throttle: {1})", this.activeUnit_0.vmethod_40(), this.method_7());
							}
						}
						if (!Information.IsNothing(this.activeUnit_0))
						{
							if (!this.activeUnit_0.bool_3 && (!this.activeUnit_0.bool_1 || ((Group)this.activeUnit_0).method_143() != Group.GroupType.AirGroup))
							{
								if (Class570.class280_0.method_12())
								{
									this.vmethod_28().Text = Conversions.ToString((int)Math.Round((double)(this.activeUnit_0.vmethod_14(false) * 3.28084f))) + " ft";
								}
								else
								{
									this.vmethod_28().Text = string.Format("{0:0.0}", this.activeUnit_0.vmethod_14(false)) + " m";
								}
							}
							else if (Class570.class280_0.method_12())
							{
								if (this.activeUnit_0.method_15())
								{
									this.vmethod_28().Text = Conversions.ToString((int)Math.Round((double)(this.activeUnit_0.vmethod_14(false) * 3.28084f))) + " ft ASL (" + Conversions.ToString((int)Math.Round((double)(this.activeUnit_0.vmethod_13() * 3.28084f))) + " ft AGL)";
								}
								else
								{
									this.vmethod_28().Text = Conversions.ToString((int)Math.Round((double)(this.activeUnit_0.vmethod_14(false) * 3.28084f))) + " ft ASL";
								}
							}
							else if (this.activeUnit_0.method_15())
							{
								this.vmethod_28().Text = string.Format("{0:0.0}", this.activeUnit_0.vmethod_14(false)) + " m ASL (" + string.Format("{0:0.0}", this.activeUnit_0.vmethod_13()) + " m AGL)";
							}
							else
							{
								this.vmethod_28().Text = string.Format("{0:0.0}", this.activeUnit_0.vmethod_14(false)) + " m ASL";
							}
						}
						if (!this.bool_4)
						{
							if (waypoint.nullable_1 != null || waypoint.nullable_2 != null || waypoint.method_31() == ActiveUnit_AI.AircraftAltitudePreset.None || waypoint.method_33() == ActiveUnit_AI.SubmarineDepthPreset.None)
							{
								if (!waypoint.method_29())
								{
									this.vmethod_74().Text = "";
								}
								else if (waypoint.nullable_1 != null || waypoint.nullable_2 != null)
								{
									if (Class570.class280_0.method_12())
									{
										if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
										{
											this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)(waypoint.nullable_2 * 3.28084f).Value));
										}
										else if (!Information.IsNothing(waypoint.nullable_1))
										{
											this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)(waypoint.nullable_1 * 3.28084f).Value));
										}
									}
									else if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
									{
										this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)waypoint.nullable_2.Value));
									}
									else if (!Information.IsNothing(waypoint.nullable_1))
									{
										this.vmethod_74().Text = Conversions.ToString((int)Math.Round((double)waypoint.nullable_1.Value));
									}
								}
							}
							if (waypoint.method_35() == ActiveUnit_Kinematics.UnitThrottlePreset.None)
							{
								bool? flag5;
								bool? flag4 = flag5 = ((!Information.IsNothing(waypoint.nullable_4)) ? waypoint.nullable_4 : new bool?(false));
								if (((flag5 == null || flag4.GetValueOrDefault()) ? (flag4 & !Information.IsNothing(waypoint.nullable_5)) : new bool?(false)).GetValueOrDefault())
								{
									if (!this.bool_3)
									{
										this.vmethod_70().Text = Conversions.ToString(waypoint.nullable_5.Value);
									}
								}
								else if (waypoint.method_27() == null)
								{
									if (!this.bool_3)
									{
										this.vmethod_70().Text = "";
									}
								}
								else if (waypoint.nullable_0 != null && !this.bool_3)
								{
									this.vmethod_70().Text = Conversions.ToString(waypoint.nullable_0.Value);
								}
							}
						}
						this.vmethod_38().Checked = (waypoint.method_27() != null);
						this.vmethod_36().Checked = waypoint.method_29();
						if (Information.IsNothing(waypoint.method_27()))
						{
							if (waypoint.method_35() != ActiveUnit_Kinematics.UnitThrottlePreset.None)
							{
								this.vmethod_150().Visible = true;
							}
							else
							{
								this.vmethod_150().Visible = false;
							}
						}
						else
						{
							this.vmethod_150().Visible = false;
						}
						if (!waypoint.method_29())
						{
							if (waypoint.method_31() != ActiveUnit_AI.AircraftAltitudePreset.None)
							{
								this.vmethod_152().Visible = true;
							}
							else
							{
								this.vmethod_152().Visible = false;
							}
							if (waypoint.method_33() != ActiveUnit_AI.SubmarineDepthPreset.None)
							{
								this.vmethod_154().Visible = true;
							}
							else
							{
								this.vmethod_154().Visible = false;
							}
						}
						else
						{
							this.vmethod_154().Visible = false;
							this.vmethod_152().Visible = false;
						}
						if (!Information.IsNothing(waypoint.method_35()))
						{
							switch (waypoint.method_35())
							{
							case ActiveUnit_Kinematics.UnitThrottlePreset.FullStop:
								if (!this.vmethod_84().Checked)
								{
									this.vmethod_84().Checked = true;
								}
								break;
							case ActiveUnit_Kinematics.UnitThrottlePreset.Loiter:
								if (!this.vmethod_82().Checked)
								{
									this.vmethod_82().Checked = true;
								}
								break;
							case ActiveUnit_Kinematics.UnitThrottlePreset.Cruise:
								if (!this.vmethod_80().Checked)
								{
									this.vmethod_80().Checked = true;
								}
								break;
							case ActiveUnit_Kinematics.UnitThrottlePreset.Full:
								if (!this.vmethod_78().Checked)
								{
									this.vmethod_78().Checked = true;
								}
								break;
							case ActiveUnit_Kinematics.UnitThrottlePreset.Flank:
								if (!this.vmethod_86().Checked)
								{
									this.vmethod_86().Checked = true;
								}
								break;
							case ActiveUnit_Kinematics.UnitThrottlePreset.None:
								if (!this.vmethod_150().Checked)
								{
									this.vmethod_150().Checked = true;
								}
								break;
							default:
								if (this.vmethod_84().Checked)
								{
									this.vmethod_84().Checked = false;
								}
								if (this.vmethod_82().Checked)
								{
									this.vmethod_82().Checked = false;
								}
								if (this.vmethod_80().Checked)
								{
									this.vmethod_80().Checked = false;
								}
								if (this.vmethod_78().Checked)
								{
									this.vmethod_78().Checked = false;
								}
								if (this.vmethod_86().Checked)
								{
									this.vmethod_86().Checked = false;
								}
								if (this.vmethod_150().Checked)
								{
									this.vmethod_150().Checked = false;
								}
								break;
							}
						}
						else
						{
							this.vmethod_84().Checked = false;
							this.vmethod_82().Checked = false;
							this.vmethod_80().Checked = false;
							this.vmethod_78().Checked = false;
							this.vmethod_86().Checked = false;
							this.vmethod_150().Checked = false;
						}
						if (!Information.IsNothing(this.activeUnit_0))
						{
							int num12 = Array.IndexOf<Waypoint>(this.activeUnit_0.vmethod_85().method_4(), Client.smethod_58());
							bool flag6 = false;
							if (num12 >= 0)
							{
								if (this.activeUnit_0.bool_3 || this.activeUnit_0.bool_6 || this.activeUnit_0.bool_5)
								{
									flag6 = true;
								}
								if (!flag6 && this.activeUnit_0.bool_1 && (((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup | ((Group)this.activeUnit_0).method_143() == Group.GroupType.SurfaceGroup | ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup))
								{
									flag6 = true;
								}
							}
							if (flag6)
							{
								int num14;
								int num15;
								try
								{
									int num13 = num12;
									for (int i = 0; i <= num13; i++)
									{
										if (i == 0)
										{
											num14 = (int)Math.Round((double)this.activeUnit_0.vmethod_40());
											num15 = (int)Math.Round((double)this.activeUnit_0.vmethod_70());
											float num16 = this.activeUnit_0.vmethod_14(false);
											float num17 = this.activeUnit_0.vmethod_72();
											num3 = (double)this.activeUnit_0.method_23(this.activeUnit_0.vmethod_85().method_4()[0]);
											ActiveUnit activeUnit2;
											if (this.activeUnit_0.bool_1)
											{
												activeUnit2 = ((Group)this.activeUnit_0).method_147();
											}
											else
											{
												activeUnit2 = this.activeUnit_0;
											}
											if (num14 > 0 && num4 < 3.4028235E+38f && num6 < 3.4028235E+38f)
											{
												num4 = (float)(num3 / (double)num14 * 3600.0);
												num6 = num4 * activeUnit2.vmethod_98(activeUnit2.vmethod_87().vmethod_41(num16, (float)num14), null, new float?((float)num14), new float?(num16), false, false, false, false, false);
											}
											else
											{
												num4 = float.MaxValue;
												num6 = float.MaxValue;
											}
											if (num15 > 0 && num5 < 3.4028235E+38f && num7 < 3.4028235E+38f)
											{
												num5 = (float)(num3 / (double)num15 * 3600.0);
												num7 = num5 * activeUnit2.vmethod_98(activeUnit2.vmethod_84(), null, new float?((float)num15), new float?(num17), false, false, false, false, false);
											}
											else
											{
												num5 = float.MaxValue;
												num7 = float.MaxValue;
											}
										}
										else if (this.activeUnit_0.vmethod_85().method_4()[i].imethod_2() != this.activeUnit_0.vmethod_85().method_4()[i - 1].imethod_2() && this.activeUnit_0.vmethod_85().method_4()[i].imethod_0() != this.activeUnit_0.vmethod_85().method_4()[i - 1].imethod_0())
										{
											double num18 = (double)Math2.smethod_15(this.activeUnit_0.vmethod_85().method_4()[i].imethod_2(), this.activeUnit_0.vmethod_85().method_4()[i].imethod_0(), this.activeUnit_0.vmethod_85().method_4()[i - 1].imethod_2(), this.activeUnit_0.vmethod_85().method_4()[i - 1].imethod_0());
											float num16;
											float num17;
											if (this.activeUnit_0.vmethod_85().method_4()[i - 1].method_29())
											{
												if (!Information.IsNothing(this.activeUnit_0.vmethod_85().method_4()[i - 1].nullable_1))
												{
													num16 = this.activeUnit_0.vmethod_85().method_4()[i - 1].nullable_1.Value;
													num17 = this.activeUnit_0.vmethod_85().method_4()[i - 1].nullable_1.Value;
													if (num16 < num9)
													{
														num16 = num9;
													}
													if (num16 > num8)
													{
														num16 = num8;
													}
													if (num17 < num9)
													{
														num17 = num9;
													}
													if (num17 > num8)
													{
														num17 = num8;
													}
												}
												else if (this.activeUnit_0.vmethod_85().method_4()[i - 1].method_33() != ActiveUnit_AI.SubmarineDepthPreset.None)
												{
													if (this.activeUnit_0.bool_5 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup))
													{
														if (this.activeUnit_0.vmethod_85().method_4()[i - 1].method_33() == ActiveUnit_AI.SubmarineDepthPreset.Surface)
														{
															num16 = 0f;
															num17 = 0f;
														}
														if (this.activeUnit_0.vmethod_85().method_4()[i - 1].method_33() == ActiveUnit_AI.SubmarineDepthPreset.MaxDepth)
														{
															num16 = num9;
															num17 = num9;
														}
													}
												}
												else if (this.activeUnit_0.vmethod_85().method_4()[i - 1].method_31() != ActiveUnit_AI.AircraftAltitudePreset.None && (this.activeUnit_0.bool_3 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)))
												{
													if (this.activeUnit_0.vmethod_85().method_4()[i - 1].method_31() == ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude)
													{
														num16 = num8;
														num17 = num8;
													}
													if (this.activeUnit_0.vmethod_85().method_4()[i - 1].method_31() == ActiveUnit_AI.AircraftAltitudePreset.MinAltitude)
													{
														num16 = num9;
														num17 = num9;
													}
												}
											}
											if (this.activeUnit_0.vmethod_85().method_4()[i - 1].method_27() != null)
											{
												if (!Information.IsNothing(this.activeUnit_0.vmethod_85().method_4()[i - 1].nullable_0))
												{
													num14 = (int)Math.Round((double)this.activeUnit_0.vmethod_85().method_4()[i - 1].nullable_0.Value);
													num15 = (int)Math.Round((double)this.activeUnit_0.vmethod_85().method_4()[i - 1].nullable_0.Value);
													if (num14 > this.activeUnit_0.vmethod_87().vmethod_39(num16))
													{
														num14 = this.activeUnit_0.vmethod_87().vmethod_39(num16);
													}
													if (num15 > this.activeUnit_0.vmethod_87().vmethod_39(num17))
													{
														num15 = this.activeUnit_0.vmethod_87().vmethod_39(num17);
													}
													if (this.activeUnit_0.bool_3)
													{
														if (!((Aircraft)this.activeUnit_0).method_150(false))
														{
															if (num14 < ((Aircraft)this.activeUnit_0).method_159().vmethod_40(num16, ActiveUnit.Throttle.Loiter, false))
															{
																num14 = ((Aircraft)this.activeUnit_0).method_159().vmethod_40(num16, ActiveUnit.Throttle.Loiter, false);
															}
															if (num15 < ((Aircraft)this.activeUnit_0).method_159().vmethod_40(num17, ActiveUnit.Throttle.Loiter, false))
															{
																num15 = ((Aircraft)this.activeUnit_0).method_159().vmethod_40(num17, ActiveUnit.Throttle.Loiter, false);
															}
														}
													}
													else if (this.activeUnit_0.bool_2)
													{
														if (num14 < ((Weapon)this.activeUnit_0).vmethod_143().vmethod_40(num16, ActiveUnit.Throttle.Cruise, false))
														{
															num14 = ((Weapon)this.activeUnit_0).vmethod_143().vmethod_40(num16, ActiveUnit.Throttle.Cruise, false);
														}
														if (num15 < ((Weapon)this.activeUnit_0).vmethod_143().vmethod_40(num17, ActiveUnit.Throttle.Cruise, false))
														{
															num15 = ((Weapon)this.activeUnit_0).vmethod_143().vmethod_40(num17, ActiveUnit.Throttle.Cruise, false);
														}
													}
													else if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)
													{
														if (Information.IsNothing(((Group)this.activeUnit_0).method_147()))
														{
															return;
														}
														Aircraft aircraft2 = (Aircraft)((Group)this.activeUnit_0).method_147();
														if (!aircraft2.method_150(false))
														{
															if (num14 < aircraft2.method_159().vmethod_40(num16, ActiveUnit.Throttle.Loiter, false))
															{
																num14 = aircraft2.method_159().vmethod_40(num16, ActiveUnit.Throttle.Loiter, false);
															}
															if (num15 < aircraft2.method_159().vmethod_40(num17, ActiveUnit.Throttle.Loiter, false))
															{
																num15 = aircraft2.method_159().vmethod_40(num17, ActiveUnit.Throttle.Loiter, false);
															}
														}
													}
													else
													{
														if (num14 < (int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_32(num16, false)))
														{
															num14 = (int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_32(this.activeUnit_0.vmethod_14(false), false));
														}
														if (num15 < (int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_32(num17, false)))
														{
															num15 = (int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_32(this.activeUnit_0.vmethod_72(), false));
														}
													}
												}
											}
											else if (this.activeUnit_0.vmethod_85().method_4()[i - 1].method_35() != ActiveUnit_Kinematics.UnitThrottlePreset.None)
											{
												num14 = this.activeUnit_0.vmethod_87().vmethod_40(num16, (ActiveUnit.Throttle)this.activeUnit_0.vmethod_85().method_4()[i - 1].method_35(), false);
												num15 = this.activeUnit_0.vmethod_87().vmethod_40(num17, (ActiveUnit.Throttle)this.activeUnit_0.vmethod_85().method_4()[i - 1].method_35(), false);
											}
											if (num14 <= 0 | num15 <= 0)
											{
												break;
											}
											num3 += num18;
											ActiveUnit activeUnit3;
											if (this.activeUnit_0.bool_1)
											{
												activeUnit3 = ((Group)this.activeUnit_0).method_147();
											}
											else
											{
												activeUnit3 = this.activeUnit_0;
											}
											if (num14 > 0 && num4 < 3.4028235E+38f && num6 < 3.4028235E+38f)
											{
												num4 = (float)((double)num4 + num18 / (double)num14 * 3600.0);
												num6 = (float)((double)num6 + num18 / (double)num14 * 3600.0 * (double)activeUnit3.vmethod_98(activeUnit3.vmethod_87().vmethod_41(num16, (float)num14), null, new float?((float)num14), new float?(num16), false, false, false, false, false));
											}
											if (num15 > 0 && num5 < 3.4028235E+38f && num7 < 3.4028235E+38f)
											{
												num5 = (float)((double)num5 + num18 / (double)num15 * 3600.0);
												num7 = (float)((double)num7 + num18 / (double)num15 * 3600.0 * (double)activeUnit3.vmethod_98(activeUnit3.vmethod_87().vmethod_41(num16, (float)num14), null, new float?((float)num15), new float?(num17), false, false, false, false, false));
											}
										}
									}
								}
								catch (Exception ex2)
								{
									ex2.Data.Add("Error at 200412", ex2.Message);
									GameGeneral.smethod_25(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
								}
								try
								{
									if (num14 > 0 && num15 > 0 && num5 > 0f && num4 > 0f && (float)num14 < 3.4028235E+38f && (float)num15 < 3.4028235E+38f && num5 < 3.4028235E+38f && num4 < 3.4028235E+38f)
									{
										this.vmethod_96().Text = "DTG: " + string.Format("{0:0} nm", num3);
										if ((int)Math.Round((double)num5) != (int)Math.Round((double)num4))
										{
											this.vmethod_94().Text = string.Concat(new string[]
											{
												"TTG: ",
												Misc.smethod_11((long)Math.Round((double)num4), Aircraft_AirOps.Enum44.const_0, false, false),
												" (Current), ",
												Misc.smethod_11((long)Math.Round((double)num5), Aircraft_AirOps.Enum44.const_0, false, false),
												" (Desired) "
											});
											this.vmethod_98().Text = string.Concat(new string[]
											{
												"Fuel qty required: ",
												string.Format("{0:0.0}", num6),
												" kg (Current), ",
												string.Format("{0:0.0}", num7),
												" kg (Desired) "
											});
										}
										else
										{
											this.vmethod_94().Text = "TTG: " + Misc.smethod_11((long)Math.Round((double)num5), Aircraft_AirOps.Enum44.const_0, false, false);
											this.vmethod_98().Text = "Fuel qty required: " + string.Format("{0:0.0}", num7) + " kg";
										}
										this.vmethod_90().Text = "Waypoint #" + Conversions.ToString(num12 + 1) + " for " + this.activeUnit_0.Name;
									}
									else
									{
										this.vmethod_90().Text = "One or more speed order is 0kt, can not estimate DTG/TTG/Fuel qty";
										this.vmethod_96().Text = "";
										this.vmethod_94().Text = "";
										this.vmethod_98().Text = "";
									}
									goto IL_42EA;
								}
								catch (Exception ex3)
								{
									ex3.Data.Add("Error at 200413", ex3.Message);
									GameGeneral.smethod_25(ref ex3);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									goto IL_42EA;
								}
							}
							this.vmethod_90().Text = "";
							this.vmethod_96().Text = "";
							this.vmethod_94().Text = "";
							this.vmethod_98().Text = "";
						}
						IL_42EA:
						if (!this.bool_5)
						{
							this.vmethod_100().Text = waypoint.string_2;
							Waypoint.WaypointType waypointType_2 = waypoint.waypointType_0;
							if (waypointType_2 <= Waypoint.WaypointType.Assemble)
							{
								if (waypointType_2 != Waypoint.WaypointType.ManualPlottedCourseWaypoint)
								{
									if (waypointType_2 == Waypoint.WaypointType.Assemble)
									{
										this.vmethod_102().SelectedIndex = 0;
									}
								}
								else
								{
									this.vmethod_102().SelectedIndex = 1;
								}
							}
							else if (waypointType_2 == Waypoint.WaypointType.Target || waypointType_2 == Waypoint.WaypointType.WeaponTarget)
							{
								this.vmethod_102().SelectedIndex = 2;
							}
						}
					}
					this.method_6();
					this.bool_6 = true;
				}
				catch (Exception ex4)
				{
					ex4.Data.Add("Error at 200637", ex4.Message);
					GameGeneral.smethod_25(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				if (this.vmethod_92().Visible)
				{
					if (this.activeUnit_0 != null && (this.activeUnit_0.bool_6 || this.activeUnit_0.bool_8))
					{
						this.vmethod_32().Visible = false;
						base.Height = this.vmethod_164().Height + this.vmethod_30().Height + 60 + this.vmethod_92().Height;
						return;
					}
					this.vmethod_32().Visible = true;
					base.Height = this.vmethod_164().Height + this.vmethod_30().Height + this.vmethod_32().Height + 60 + this.vmethod_92().Height;
					return;
				}
				else
				{
					if (this.activeUnit_0 != null && (this.activeUnit_0.bool_6 || this.activeUnit_0.bool_8))
					{
						this.vmethod_32().Visible = false;
						base.Height = this.vmethod_164().Height + this.vmethod_30().Height + 60;
						return;
					}
					this.vmethod_32().Visible = true;
					base.Height = this.vmethod_164().Height + this.vmethod_30().Height + this.vmethod_32().Height + 60;
				}
			}
		}

		// Token: 0x06008A24 RID: 35364 RVA: 0x004A18D8 File Offset: 0x0049FAD8
		private void method_6()
		{
			if (!this.vmethod_16().Visible)
			{
				this.vmethod_130().Visible = false;
				this.vmethod_114().Visible = false;
				this.vmethod_128().Visible = false;
				this.vmethod_126().Visible = false;
				this.vmethod_116().Visible = false;
				this.vmethod_148().Visible = false;
				this.vmethod_146().Visible = false;
				this.vmethod_134().Visible = false;
				this.vmethod_132().Visible = false;
				this.vmethod_124().Visible = false;
				this.vmethod_138().Visible = false;
				this.vmethod_136().Visible = false;
				this.vmethod_112().Visible = false;
				this.vmethod_108().Visible = false;
				this.vmethod_110().Visible = false;
				this.vmethod_118().Visible = false;
				this.vmethod_120().Visible = false;
				this.vmethod_122().Visible = false;
				return;
			}
			ActiveUnit activeUnit = this.activeUnit_0;
			if (activeUnit.bool_1)
			{
				activeUnit = ((Group)activeUnit).method_147();
			}
			float num = (float)activeUnit.method_9(false, true, false);
			Weather.WeatherProfile weatherProfile = Weather.smethod_0(activeUnit.scenario_0, activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), (int)Math.Round((double)activeUnit.vmethod_14(true)));
			int num2;
			int num3;
			float num4;
			Class568.smethod_1(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), (int)Math.Round((double)activeUnit.vmethod_14(true)), ref num2, ref num3, ref num4, true);
			double num5 = (double)(this.vmethod_16().Top + this.vmethod_16().Margin.Top + 10);
			double num6 = (double)(this.vmethod_16().Top + this.vmethod_16().Height - this.vmethod_16().Margin.Top - this.vmethod_16().Margin.Bottom - 7);
			double num7 = (double)this.vmethod_16().Maximum;
			double num8 = (double)this.vmethod_16().Minimum;
			double num9 = num7;
			double num10 = num8;
			double num11 = num5;
			double num12 = num6;
			double num13;
			double num14;
			if (activeUnit.vmethod_56() == GlobalVariables.ActiveUnitType.Aircraft)
			{
				this.vmethod_148().Visible = true;
				this.vmethod_146().Visible = true;
				if (num < 0f | (double)num > num7 | (double)num < num8)
				{
					this.vmethod_124().Visible = false;
					this.vmethod_116().Visible = false;
				}
				else
				{
					num13 = (double)num;
					num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
					this.vmethod_116().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_116().Height / 2.0);
					this.vmethod_116().Visible = true;
					if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
					{
						this.vmethod_124().Visible = true;
						this.vmethod_124().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_124().Height / 2.0 - 1.0);
						this.vmethod_124().Text = "Ground Level";
					}
					else
					{
						this.vmethod_124().Visible = false;
					}
				}
				float num15 = (float)((double)weatherProfile.method_3() - 0.001);
				if (weatherProfile.method_3() == 0f)
				{
					num15 = 0f;
				}
				double num16;
				double num17;
				double num18;
				double num19;
				if ((double)num15 > 0.9)
				{
					num16 = 36000.0;
					num17 = 7000.0;
					num18 = 2000.0;
					num19 = 1.0;
					this.vmethod_134().Text = "Solid Cloud";
					this.vmethod_132().Text = "Solid Cloud";
					this.vmethod_138().Text = "Thick Fog";
					this.vmethod_136().Text = "Thick Fog";
				}
				else if ((double)num15 > 0.8)
				{
					num16 = 36000.0;
					num17 = 7000.0;
					num18 = 2000.0;
					num19 = 1.0;
					this.vmethod_134().Text = "Solid Cloud";
					this.vmethod_132().Text = "Solid Cloud";
					this.vmethod_138().Text = "Thin Fog";
					this.vmethod_136().Text = "Thin Fog";
				}
				else if ((double)num15 > 0.7)
				{
					num16 = 36000.0;
					num17 = 30000.0;
					num18 = 16000.0;
					num19 = 7000.0;
					this.vmethod_134().Text = "Mod. Cloud";
					this.vmethod_132().Text = "Mod. Cloud";
					this.vmethod_138().Text = "Solid Cloud";
					this.vmethod_136().Text = "Solid Cloud";
				}
				else if ((double)num15 > 0.6)
				{
					num16 = 30000.0;
					num17 = 27000.0;
					num18 = 16000.0;
					num19 = 7000.0;
					this.vmethod_134().Text = "Light Cloud";
					this.vmethod_132().Text = "Light Cloud";
					this.vmethod_138().Text = "Mod. Cloud";
					this.vmethod_136().Text = "Mod. Cloud";
				}
				else if ((double)num15 > 0.5)
				{
					num16 = 0.0;
					num17 = 0.0;
					num18 = 28000.0;
					num19 = 25000.0;
					this.vmethod_134().Text = "";
					this.vmethod_132().Text = "";
					this.vmethod_138().Text = "Mod. Cloud";
					this.vmethod_136().Text = "Mod. Cloud";
				}
				else if ((double)num15 > 0.4)
				{
					num16 = 0.0;
					num17 = 0.0;
					num18 = 16000.0;
					num19 = 7000.0;
					this.vmethod_134().Text = "";
					this.vmethod_132().Text = "";
					this.vmethod_138().Text = "Mod. Cloud";
					this.vmethod_136().Text = "Mod. Cloud";
				}
				else if ((double)num15 > 0.3)
				{
					num16 = 0.0;
					num17 = 0.0;
					num18 = 7000.0;
					num19 = 2000.0;
					this.vmethod_134().Text = "";
					this.vmethod_132().Text = "";
					this.vmethod_138().Text = "Mod. Cloud";
					this.vmethod_136().Text = "Mod. Cloud";
				}
				else if ((double)num15 > 0.2)
				{
					num16 = 0.0;
					num17 = 0.0;
					num18 = 23000.0;
					num19 = 20000.0;
					this.vmethod_134().Text = "";
					this.vmethod_132().Text = "";
					this.vmethod_138().Text = "Light Cloud";
					this.vmethod_136().Text = "Light Cloud";
				}
				else if ((double)num15 > 0.1)
				{
					num16 = 0.0;
					num17 = 0.0;
					num18 = 16000.0;
					num19 = 10000.0;
					this.vmethod_134().Text = "";
					this.vmethod_132().Text = "";
					this.vmethod_138().Text = "Light Cloud";
					this.vmethod_136().Text = "Light Cloud";
				}
				else if ((double)num15 > 0.0)
				{
					num16 = 0.0;
					num17 = 0.0;
					num18 = 7000.0;
					num19 = 5000.0;
					this.vmethod_134().Text = "";
					this.vmethod_132().Text = "";
					this.vmethod_138().Text = "Light Cloud";
					this.vmethod_136().Text = "Light Cloud";
				}
				else
				{
					num16 = 0.0;
					num17 = 0.0;
					num18 = 0.0;
					num19 = 0.0;
					this.vmethod_134().Text = "";
					this.vmethod_132().Text = "";
					this.vmethod_132().Text = "";
					this.vmethod_138().Text = "";
				}
				double num20 = num16 / 3.2808399200439453;
				double num21 = num17 / 3.2808399200439453;
				double num22 = num18 / 3.2808399200439453;
				double num23 = num19 / 3.2808399200439453;
				num13 = num20;
				num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
				this.vmethod_148().Y1 = (int)Math.Round(num14 - (double)this.vmethod_114().Height);
				num13 = num21;
				num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
				this.vmethod_148().Y2 = (int)Math.Round(num14 - (double)this.vmethod_130().Height);
				num13 = num22;
				num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
				this.vmethod_146().Y1 = (int)Math.Round(num14 - (double)this.vmethod_126().Height);
				num13 = num23;
				num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
				this.vmethod_146().Y2 = (int)Math.Round(num14 - (double)this.vmethod_128().Height);
				if (num20 == 0.0 | num20 < (double)num | num20 > num7 | num20 < num8)
				{
					this.vmethod_114().Visible = false;
					this.vmethod_134().Visible = false;
				}
				else
				{
					num13 = num20;
					num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
					this.vmethod_114().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_114().Height / 2.0);
					this.vmethod_114().Visible = true;
					if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
					{
						this.vmethod_134().Visible = true;
						this.vmethod_134().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_134().Height / 2.0 - 1.0);
					}
					else
					{
						this.vmethod_134().Visible = false;
					}
				}
				if (num21 == 0.0 | num21 < (double)num | num21 > num7 | num21 < num8)
				{
					this.vmethod_130().Visible = false;
					this.vmethod_132().Visible = false;
				}
				else
				{
					num13 = num21;
					num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
					this.vmethod_130().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_130().Height / 2.0);
					this.vmethod_130().Visible = true;
					if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
					{
						this.vmethod_132().Visible = true;
						this.vmethod_132().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_132().Height / 2.0 - 1.0);
					}
					else
					{
						this.vmethod_132().Visible = false;
					}
				}
				if (num22 == 0.0 | num22 < (double)num | num22 > num7 | num22 < num8)
				{
					this.vmethod_126().Visible = false;
					this.vmethod_138().Visible = false;
				}
				else
				{
					num13 = num22;
					num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
					this.vmethod_126().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_126().Height / 2.0);
					this.vmethod_126().Visible = true;
					if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
					{
						this.vmethod_138().Visible = true;
						this.vmethod_138().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_134().Height / 2.0 - 1.0);
					}
					else
					{
						this.vmethod_138().Visible = false;
					}
				}
				if (num23 == 0.0 | num23 < (double)num | num23 > num7 | num23 < num8)
				{
					this.vmethod_128().Visible = false;
					this.vmethod_136().Visible = false;
				}
				else
				{
					num13 = num23;
					num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
					this.vmethod_128().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_128().Height / 2.0);
					this.vmethod_128().Visible = true;
					if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
					{
						this.vmethod_136().Visible = true;
						this.vmethod_136().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_136().Height / 2.0 - 1.0);
					}
					else
					{
						this.vmethod_136().Visible = false;
					}
				}
			}
			else
			{
				this.vmethod_130().Visible = false;
				this.vmethod_114().Visible = false;
				this.vmethod_128().Visible = false;
				this.vmethod_126().Visible = false;
				this.vmethod_116().Visible = false;
				this.vmethod_148().Visible = false;
				this.vmethod_146().Visible = false;
				this.vmethod_134().Visible = false;
				this.vmethod_132().Visible = false;
				this.vmethod_124().Visible = false;
				this.vmethod_138().Visible = false;
				this.vmethod_136().Visible = false;
			}
			if (activeUnit.vmethod_56() != GlobalVariables.ActiveUnitType.Submarine)
			{
				this.vmethod_112().Visible = false;
				this.vmethod_108().Visible = false;
				this.vmethod_110().Visible = false;
				this.vmethod_118().Visible = false;
				this.vmethod_120().Visible = false;
				this.vmethod_122().Visible = false;
				return;
			}
			if ((float)num2 < num | (double)num2 > num7 | (double)num2 < num8)
			{
				this.vmethod_108().Visible = false;
				this.vmethod_118().Visible = false;
			}
			else
			{
				num13 = (double)num2;
				num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
				this.vmethod_108().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_108().Height / 2.0);
				this.vmethod_108().Visible = true;
				if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
				{
					this.vmethod_118().Visible = true;
					this.vmethod_118().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_118().Height / 2.0 - 1.0);
					this.vmethod_118().Text = "Layer Ceiling";
				}
				else
				{
					this.vmethod_118().Visible = false;
				}
			}
			if ((float)num3 < num | (double)num3 > num7 | (double)num3 < num8)
			{
				this.vmethod_110().Visible = false;
				this.vmethod_120().Visible = false;
			}
			else
			{
				num13 = (double)num3;
				num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
				this.vmethod_110().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_110().Height / 2.0);
				this.vmethod_110().Visible = true;
				if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
				{
					this.vmethod_120().Visible = true;
					this.vmethod_120().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_120().Height / 2.0 - 1.0);
					this.vmethod_120().Text = "Layer Floor";
				}
				else
				{
					this.vmethod_120().Visible = false;
				}
			}
			if ((double)num < num8 | (double)num > num7 | (double)num < num8)
			{
				this.vmethod_112().Visible = false;
				this.vmethod_122().Visible = false;
				return;
			}
			num13 = (double)num;
			num14 = num11 + (num12 - num11) * ((num13 - num9) / (num10 - num9));
			this.vmethod_112().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_112().Height / 2.0);
			this.vmethod_112().Visible = true;
			if (Math.Min(Math.Abs((double)((int)Math.Round(num14)) - num5), Math.Abs((double)((int)Math.Round(num14)) - num6)) > 20.0)
			{
				this.vmethod_122().Visible = true;
				this.vmethod_122().Top = (int)Math.Round((double)((int)Math.Round(num14)) - (double)this.vmethod_122().Height / 2.0 - 1.0);
				this.vmethod_122().Text = "Sea Floor";
				return;
			}
			this.vmethod_122().Visible = false;
		}

		// Token: 0x06008A25 RID: 35365 RVA: 0x004A2BE4 File Offset: 0x004A0DE4
		private string method_7()
		{
			string result;
			if (Information.IsNothing(this.activeUnit_0))
			{
				result = "-";
			}
			else
			{
				switch (this.activeUnit_0.vmethod_84())
				{
				case ActiveUnit.Throttle.FullStop:
					result = "Full Stop";
					break;
				case ActiveUnit.Throttle.Loiter:
					if (this.activeUnit_0.bool_3)
					{
						result = "Loiter";
					}
					else
					{
						result = "Creep";
					}
					break;
				case ActiveUnit.Throttle.Cruise:
					result = "Cruise";
					break;
				case ActiveUnit.Throttle.Full:
					if (this.activeUnit_0.bool_3)
					{
						result = "Military";
					}
					else
					{
						result = "Full";
					}
					break;
				case ActiveUnit.Throttle.Flank:
					if (this.activeUnit_0.bool_3)
					{
						result = "Afterburner";
					}
					else
					{
						result = "Flank";
					}
					break;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = this.activeUnit_0.vmethod_84().ToString();
					break;
				}
			}
			return result;
		}

		// Token: 0x06008A26 RID: 35366 RVA: 0x00052C7B File Offset: 0x00050E7B
		private void method_8(object sender, EventArgs e)
		{
			this.method_5(false);
		}

		// Token: 0x06008A27 RID: 35367 RVA: 0x004A2CC0 File Offset: 0x004A0EC0
		private void method_9(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && this.vmethod_84().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_36(ActiveUnit_Kinematics.UnitThrottlePreset.FullStop);
					Client.smethod_58().nullable_0 = null;
					Client.smethod_58().method_28(null);
					Client.smethod_58().enum82_1 = Waypoint.Enum82.const_1;
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					if (!this.method_11(ref this.waypoint_0))
					{
						this.vmethod_84().Checked = false;
						return;
					}
					this.waypoint_0.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.FullStop);
					this.waypoint_0.nullable_0 = null;
					this.waypoint_0.method_28(null);
					this.waypoint_0.enum82_1 = Waypoint.Enum82.const_1;
					Scenario scenario_ = Client.smethod_46();
					Mission mission = this.mission_0;
					ActiveUnit activeUnit = this.flight_0.method_32(Client.smethod_46());
					Mission.Flight flight = this.flight_0;
					Mission.Flight flight2;
					Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
					float num = 0f;
					float num2 = 0f;
					Class514.smethod_28(scenario_, mission, activeUnit, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
					flight2.method_16(waypoint_);
					Client.bool_1 = true;
					if (Client.smethod_32().Visible)
					{
						Client.smethod_32().method_13();
						Client.smethod_32().flightPlanWaypoints_6.method_14();
						return;
					}
				}
				else if (!Information.IsNothing(this.activeUnit_0))
				{
					this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.FullStop);
					this.activeUnit_0.vmethod_87().method_0();
					this.vmethod_0().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_70(), (float)this.vmethod_0().Minimum));
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A28 RID: 35368 RVA: 0x004A2EF8 File Offset: 0x004A10F8
		private void method_10(object sender, EventArgs e)
		{
			if (this.bool_6 && this.vmethod_82().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Loiter);
					Client.smethod_58().nullable_0 = null;
					Client.smethod_58().method_28(null);
					Client.smethod_58().enum82_1 = Waypoint.Enum82.const_1;
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					if (!this.method_11(ref this.waypoint_0))
					{
						this.vmethod_82().Checked = false;
						return;
					}
					this.waypoint_0.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Loiter);
					this.waypoint_0.nullable_0 = null;
					this.waypoint_0.method_28(null);
					this.waypoint_0.enum82_1 = Waypoint.Enum82.const_1;
					Scenario scenario_ = Client.smethod_46();
					Mission mission = this.mission_0;
					ActiveUnit activeUnit = this.flight_0.method_32(Client.smethod_46());
					Mission.Flight flight = this.flight_0;
					Mission.Flight flight2;
					Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
					float num = 0f;
					float num2 = 0f;
					Class514.smethod_28(scenario_, mission, activeUnit, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
					flight2.method_16(waypoint_);
					Client.bool_1 = true;
					if (Client.smethod_32().Visible)
					{
						Client.smethod_32().method_13();
						Client.smethod_32().flightPlanWaypoints_6.method_14();
						return;
					}
				}
				else if (!Information.IsNothing(this.activeUnit_0))
				{
					this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.Loiter);
					this.activeUnit_0.vmethod_87().method_0();
					if (Math.Max(this.activeUnit_0.vmethod_70(), (float)this.vmethod_0().Minimum) > (float)this.vmethod_0().Maximum)
					{
						this.vmethod_0().Value = this.vmethod_0().Maximum;
					}
					else
					{
						this.vmethod_0().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_70(), (float)this.vmethod_0().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A29 RID: 35369 RVA: 0x004A3164 File Offset: 0x004A1364
		private bool method_11(ref Waypoint waypoint_1)
		{
			if (waypoint_1.enum79_0 == Waypoint.Enum79.const_1)
			{
				foreach (Side side in Client.smethod_46().method_44())
				{
					try
					{
						foreach (Mission mission in side.method_35())
						{
							try
							{
								foreach (Mission.Flight flight in mission.list_1)
								{
									if (Enumerable.Contains<Waypoint>(flight.method_15(), waypoint_1) && flight.int_2 == 0)
									{
										DarkMessageBox.smethod_1("Waypoints for flightplans with no aircraft type set cannot use throttle presets, only fixed speeds.", string.Empty, Enum11.const_0);
										return false;
									}
								}
							}
							finally
							{
								List<Mission.Flight>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
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
			}
			return true;
		}

		// Token: 0x06008A2A RID: 35370 RVA: 0x004A3250 File Offset: 0x004A1450
		private void method_12(object sender, EventArgs e)
		{
			if (this.bool_6 && this.vmethod_80().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Cruise);
					Client.smethod_58().nullable_0 = null;
					Client.smethod_58().method_28(null);
					Client.smethod_58().enum82_1 = Waypoint.Enum82.const_1;
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					if (!this.method_11(ref this.waypoint_0))
					{
						this.vmethod_80().Checked = false;
						return;
					}
					this.waypoint_0.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Cruise);
					this.waypoint_0.nullable_0 = null;
					this.waypoint_0.method_28(null);
					this.waypoint_0.enum82_1 = Waypoint.Enum82.const_1;
					Scenario scenario_ = Client.smethod_46();
					Mission mission = this.mission_0;
					ActiveUnit activeUnit = this.flight_0.method_32(Client.smethod_46());
					Mission.Flight flight = this.flight_0;
					Mission.Flight flight2;
					Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
					float num = 0f;
					float num2 = 0f;
					Class514.smethod_28(scenario_, mission, activeUnit, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
					flight2.method_16(waypoint_);
					Client.bool_1 = true;
					if (Client.smethod_32().Visible)
					{
						Client.smethod_32().method_13();
						Client.smethod_32().flightPlanWaypoints_6.method_14();
						return;
					}
				}
				else if (!Information.IsNothing(this.activeUnit_0))
				{
					this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.Cruise);
					this.activeUnit_0.vmethod_87().method_0();
					if (Math.Max(this.activeUnit_0.vmethod_70(), (float)this.vmethod_0().Minimum) > (float)this.vmethod_0().Maximum)
					{
						this.vmethod_0().Value = this.vmethod_0().Maximum;
					}
					else
					{
						this.vmethod_0().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_70(), (float)this.vmethod_0().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A2B RID: 35371 RVA: 0x004A34BC File Offset: 0x004A16BC
		private void method_13(object sender, EventArgs e)
		{
			if (this.bool_6 && this.vmethod_78().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Full);
					Client.smethod_58().nullable_0 = null;
					Client.smethod_58().method_28(null);
					Client.smethod_58().enum82_1 = Waypoint.Enum82.const_1;
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					if (!this.method_11(ref this.waypoint_0))
					{
						this.vmethod_78().Checked = false;
						return;
					}
					this.waypoint_0.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Full);
					this.waypoint_0.nullable_0 = null;
					this.waypoint_0.method_28(null);
					this.waypoint_0.enum82_1 = Waypoint.Enum82.const_1;
					Scenario scenario_ = Client.smethod_46();
					Mission mission = this.mission_0;
					ActiveUnit activeUnit = this.flight_0.method_32(Client.smethod_46());
					Mission.Flight flight = this.flight_0;
					Mission.Flight flight2;
					Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
					float num = 0f;
					float num2 = 0f;
					Class514.smethod_28(scenario_, mission, activeUnit, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
					flight2.method_16(waypoint_);
					Client.bool_1 = true;
					if (Client.smethod_32().Visible)
					{
						Client.smethod_32().method_13();
						Client.smethod_32().flightPlanWaypoints_6.method_14();
						return;
					}
				}
				else if (!Information.IsNothing(this.activeUnit_0))
				{
					this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.Full);
					this.activeUnit_0.vmethod_87().method_0();
					if (Math.Max(this.activeUnit_0.vmethod_70(), (float)this.vmethod_0().Minimum) > (float)this.vmethod_0().Maximum)
					{
						this.vmethod_0().Value = this.vmethod_0().Maximum;
					}
					else
					{
						this.vmethod_0().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_70(), (float)this.vmethod_0().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A2C RID: 35372 RVA: 0x004A3728 File Offset: 0x004A1928
		private void method_14(object sender, EventArgs e)
		{
			if (this.bool_6 && this.vmethod_150().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_36(ActiveUnit_Kinematics.UnitThrottlePreset.None);
					Client.smethod_58().nullable_0 = null;
					Client.smethod_58().method_28(null);
					Client.smethod_58().enum82_1 = Waypoint.Enum82.const_1;
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					if (!this.method_11(ref this.waypoint_0))
					{
						this.vmethod_150().Checked = false;
						return;
					}
					this.waypoint_0.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.None);
					this.waypoint_0.nullable_0 = null;
					this.waypoint_0.method_28(null);
					this.waypoint_0.enum82_1 = Waypoint.Enum82.const_0;
					Scenario scenario_ = Client.smethod_46();
					Mission mission = this.mission_0;
					ActiveUnit activeUnit = this.flight_0.method_32(Client.smethod_46());
					Mission.Flight flight = this.flight_0;
					Mission.Flight flight2;
					Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
					float num = 0f;
					float num2 = 0f;
					Class514.smethod_28(scenario_, mission, activeUnit, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
					flight2.method_16(waypoint_);
					Client.bool_1 = true;
					if (Client.smethod_32().Visible)
					{
						Client.smethod_32().method_13();
						Client.smethod_32().flightPlanWaypoints_6.method_14();
					}
				}
			}
		}

		// Token: 0x06008A2D RID: 35373 RVA: 0x004A38B8 File Offset: 0x004A1AB8
		private void method_15(object sender, EventArgs e)
		{
			if (this.bool_6 && this.vmethod_86().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Flank);
					Client.smethod_58().nullable_0 = null;
					Client.smethod_58().method_28(null);
					Client.smethod_58().enum82_1 = Waypoint.Enum82.const_1;
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					if (!this.method_11(ref this.waypoint_0))
					{
						this.vmethod_86().Checked = false;
						return;
					}
					this.waypoint_0.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.Flank);
					this.waypoint_0.nullable_0 = null;
					this.waypoint_0.method_28(null);
					this.waypoint_0.enum82_1 = Waypoint.Enum82.const_1;
					Scenario scenario_ = Client.smethod_46();
					Mission mission = this.mission_0;
					ActiveUnit activeUnit = this.flight_0.method_32(Client.smethod_46());
					Mission.Flight flight = this.flight_0;
					Mission.Flight flight2;
					Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
					float num = 0f;
					float num2 = 0f;
					Class514.smethod_28(scenario_, mission, activeUnit, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
					flight2.method_16(waypoint_);
					Client.bool_1 = true;
					if (Client.smethod_32().Visible)
					{
						Client.smethod_32().method_13();
						Client.smethod_32().flightPlanWaypoints_6.method_14();
						return;
					}
				}
				else if (!Information.IsNothing(this.activeUnit_0))
				{
					this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.Flank);
					this.activeUnit_0.vmethod_87().method_0();
					if (Math.Max(this.activeUnit_0.vmethod_70(), (float)this.vmethod_0().Minimum) > (float)this.vmethod_0().Maximum)
					{
						this.vmethod_0().Value = this.vmethod_0().Maximum;
					}
					else
					{
						this.vmethod_0().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_70(), (float)this.vmethod_0().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A2E RID: 35374 RVA: 0x004A3B24 File Offset: 0x004A1D24
		private void method_16(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0))
			{
				if (this.activeUnit_0.vmethod_85().vmethod_3())
				{
					this.activeUnit_0.vmethod_85().vmethod_6(new float?((float)this.vmethod_0().Value));
					this.activeUnit_0.vmethod_87().vmethod_11(null);
				}
				else
				{
					this.activeUnit_0.vmethod_71((float)this.vmethod_0().Value);
					this.activeUnit_0.vmethod_87().vmethod_11(new float?((float)this.vmethod_0().Value));
				}
				this.method_19();
				this.activeUnit_0.vmethod_86().method_25();
				Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
			}
		}

		// Token: 0x06008A2F RID: 35375 RVA: 0x004A3C04 File Offset: 0x004A1E04
		private void method_17(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0))
			{
				this.activeUnit_0.vmethod_73((float)this.vmethod_16().Value);
				this.method_18();
				this.activeUnit_0.vmethod_86().method_25();
				Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
			}
		}

		// Token: 0x06008A30 RID: 35376 RVA: 0x004A3C70 File Offset: 0x004A1E70
		private void method_18()
		{
			if (!(Information.IsNothing(this.activeUnit_0) & Information.IsNothing(Client.smethod_58())) || !Information.IsNothing(this.waypoint_0))
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_30(true);
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_30(true);
				}
				else if (!Information.IsNothing(this.activeUnit_0))
				{
					this.activeUnit_0.vmethod_87().vmethod_13(true);
				}
				this.method_21();
				if (!Information.IsNothing(this.activeUnit_0))
				{
					this.activeUnit_0.vmethod_86().method_25();
				}
				this.vmethod_36().Checked = true;
				if (!Information.IsNothing(this.activeUnit_0))
				{
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A31 RID: 35377 RVA: 0x004A3D68 File Offset: 0x004A1F68
		private void method_19()
		{
			if (!(Information.IsNothing(this.activeUnit_0) & Information.IsNothing(Client.smethod_58())) || !Information.IsNothing(this.waypoint_0))
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					if (Client.smethod_58().nullable_4.GetValueOrDefault())
					{
						Client.smethod_58().method_28(null);
						Client.smethod_58().enum82_1 = Waypoint.Enum82.const_0;
					}
					else
					{
						Client.smethod_58().method_28(Client.smethod_58().nullable_0);
						Client.smethod_58().enum82_1 = Waypoint.Enum82.const_1;
					}
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_28(this.waypoint_0.nullable_0);
					this.waypoint_0.enum82_1 = Waypoint.Enum82.const_1;
					Scenario scenario_ = Client.smethod_46();
					Mission mission = this.mission_0;
					ActiveUnit activeUnit = this.flight_0.method_32(Client.smethod_46());
					Mission.Flight flight = this.flight_0;
					Mission.Flight flight2;
					Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
					float num = 0f;
					float num2 = 0f;
					Class514.smethod_28(scenario_, mission, activeUnit, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
					flight2.method_16(waypoint_);
					Client.bool_1 = true;
					if (Client.smethod_32().Visible)
					{
						Client.smethod_32().method_13();
						Client.smethod_32().flightPlanWaypoints_6.method_14();
					}
				}
				else if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.vmethod_85().vmethod_3())
					{
						this.activeUnit_0.vmethod_87().vmethod_11(null);
					}
					else
					{
						this.activeUnit_0.vmethod_87().vmethod_11(new float?(this.activeUnit_0.vmethod_70()));
					}
				}
				this.method_20();
				if (!Information.IsNothing(this.activeUnit_0))
				{
					this.activeUnit_0.vmethod_86().method_25();
				}
				this.vmethod_38().Checked = true;
				if (!Information.IsNothing(this.activeUnit_0))
				{
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A32 RID: 35378 RVA: 0x004A3FAC File Offset: 0x004A21AC
		private void method_20()
		{
			if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
			{
				Client.smethod_58().method_36(ActiveUnit_Kinematics.UnitThrottlePreset.None);
			}
			else if (!Information.IsNothing(this.waypoint_0))
			{
				this.waypoint_0.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.None);
			}
			else if (!Information.IsNothing(this.activeUnit_0))
			{
				this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.None);
			}
			this.vmethod_84().Checked = false;
			this.vmethod_82().Checked = false;
			this.vmethod_80().Checked = false;
			this.vmethod_78().Checked = false;
			this.vmethod_86().Checked = false;
		}

		// Token: 0x06008A33 RID: 35379 RVA: 0x004A4054 File Offset: 0x004A2254
		private void method_21()
		{
			if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
			{
				Client.smethod_58().method_34(ActiveUnit_AI.SubmarineDepthPreset.None);
				Client.smethod_58().method_32(ActiveUnit_AI.AircraftAltitudePreset.None);
				this.vmethod_68().Checked = false;
				this.vmethod_48().Checked = false;
				this.vmethod_50().Checked = false;
				this.vmethod_46().Checked = false;
				this.vmethod_44().Checked = false;
				this.vmethod_42().Checked = false;
				this.vmethod_66().Checked = false;
				this.vmethod_64().Checked = false;
				this.vmethod_62().Checked = false;
				this.vmethod_54().Checked = false;
				this.vmethod_56().Checked = false;
				this.vmethod_60().Checked = false;
				this.vmethod_58().Checked = false;
				return;
			}
			if (!Information.IsNothing(this.waypoint_0))
			{
				this.waypoint_0.method_34(ActiveUnit_AI.SubmarineDepthPreset.None);
				this.waypoint_0.method_32(ActiveUnit_AI.AircraftAltitudePreset.None);
				this.vmethod_68().Checked = false;
				this.vmethod_48().Checked = false;
				this.vmethod_50().Checked = false;
				this.vmethod_46().Checked = false;
				this.vmethod_44().Checked = false;
				this.vmethod_42().Checked = false;
				this.vmethod_66().Checked = false;
				this.vmethod_64().Checked = false;
				this.vmethod_62().Checked = false;
				this.vmethod_54().Checked = false;
				this.vmethod_56().Checked = false;
				this.vmethod_60().Checked = false;
				this.vmethod_58().Checked = false;
				return;
			}
			if (!Information.IsNothing(this.activeUnit_0))
			{
				if (this.activeUnit_0.bool_5)
				{
					((Submarine_AI)this.activeUnit_0.vmethod_86()).method_115(ActiveUnit_AI.SubmarineDepthPreset.None);
					this.vmethod_68().Checked = false;
					this.vmethod_48().Checked = false;
					this.vmethod_50().Checked = false;
					this.vmethod_46().Checked = false;
					this.vmethod_44().Checked = false;
					this.vmethod_42().Checked = false;
				}
				if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup)
				{
					((Class167)this.activeUnit_0.vmethod_86()).method_112(ActiveUnit_AI.SubmarineDepthPreset.None);
					this.vmethod_68().Checked = false;
					this.vmethod_48().Checked = false;
					this.vmethod_50().Checked = false;
					this.vmethod_46().Checked = false;
					this.vmethod_44().Checked = false;
					this.vmethod_42().Checked = false;
				}
				if (this.activeUnit_0.bool_3)
				{
					((Aircraft_AI)this.activeUnit_0.vmethod_86()).method_115(ActiveUnit_AI.AircraftAltitudePreset.None);
					this.vmethod_66().Checked = false;
					this.vmethod_64().Checked = false;
					this.vmethod_62().Checked = false;
					this.vmethod_54().Checked = false;
					this.vmethod_56().Checked = false;
					this.vmethod_60().Checked = false;
					this.vmethod_58().Checked = false;
				}
				if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)
				{
					((Class167)this.activeUnit_0.vmethod_86()).method_113(ActiveUnit_AI.AircraftAltitudePreset.None);
					this.vmethod_66().Checked = false;
					this.vmethod_64().Checked = false;
					this.vmethod_62().Checked = false;
					this.vmethod_54().Checked = false;
					this.vmethod_56().Checked = false;
					this.vmethod_60().Checked = false;
					this.vmethod_58().Checked = false;
				}
			}
		}

		// Token: 0x06008A34 RID: 35380 RVA: 0x004A43F4 File Offset: 0x004A25F4
		private void method_22(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_5 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup)) && this.vmethod_68().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_34(ActiveUnit_AI.SubmarineDepthPreset.Surface);
					Client.smethod_58().method_26();
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_34(ActiveUnit_AI.SubmarineDepthPreset.Surface);
					this.waypoint_0.method_26();
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_5)
					{
						Submarine_AI submarine_AI = (Submarine_AI)this.activeUnit_0.vmethod_86();
						submarine_AI.method_115(ActiveUnit_AI.SubmarineDepthPreset.Surface);
						submarine_AI.vmethod_28(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						@class.method_112(ActiveUnit_AI.SubmarineDepthPreset.Surface);
						@class.vmethod_28(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A35 RID: 35381 RVA: 0x004A45B8 File Offset: 0x004A27B8
		private void method_23(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_5 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup)) && this.vmethod_48().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_34(ActiveUnit_AI.SubmarineDepthPreset.Periscope);
					Client.smethod_58().method_26();
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_34(ActiveUnit_AI.SubmarineDepthPreset.Periscope);
					this.waypoint_0.method_26();
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_5)
					{
						Submarine_AI submarine_AI = (Submarine_AI)this.activeUnit_0.vmethod_86();
						submarine_AI.method_115(ActiveUnit_AI.SubmarineDepthPreset.Periscope);
						submarine_AI.vmethod_28(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						@class.method_112(ActiveUnit_AI.SubmarineDepthPreset.Periscope);
						@class.vmethod_28(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A36 RID: 35382 RVA: 0x004A477C File Offset: 0x004A297C
		private void method_24(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_5 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup)) && this.vmethod_50().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_34(ActiveUnit_AI.SubmarineDepthPreset.Shallow);
					Client.smethod_58().method_26();
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_34(ActiveUnit_AI.SubmarineDepthPreset.Shallow);
					this.waypoint_0.method_26();
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_5)
					{
						Submarine_AI submarine_AI = (Submarine_AI)this.activeUnit_0.vmethod_86();
						submarine_AI.method_115(ActiveUnit_AI.SubmarineDepthPreset.Shallow);
						submarine_AI.vmethod_28(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						@class.method_112(ActiveUnit_AI.SubmarineDepthPreset.Shallow);
						@class.vmethod_28(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A37 RID: 35383 RVA: 0x004A4940 File Offset: 0x004A2B40
		private void method_25(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_5 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup)) && this.vmethod_46().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_34(ActiveUnit_AI.SubmarineDepthPreset.OverLayer);
					Client.smethod_58().method_26();
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_34(ActiveUnit_AI.SubmarineDepthPreset.OverLayer);
					this.waypoint_0.method_26();
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_5)
					{
						Submarine_AI submarine_AI = (Submarine_AI)this.activeUnit_0.vmethod_86();
						submarine_AI.method_115(ActiveUnit_AI.SubmarineDepthPreset.OverLayer);
						submarine_AI.vmethod_28(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						@class.method_112(ActiveUnit_AI.SubmarineDepthPreset.OverLayer);
						@class.vmethod_28(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A38 RID: 35384 RVA: 0x004A4B04 File Offset: 0x004A2D04
		private void method_26(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_5 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup)) && this.vmethod_44().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_34(ActiveUnit_AI.SubmarineDepthPreset.UnderLayer);
					Client.smethod_58().method_26();
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_34(ActiveUnit_AI.SubmarineDepthPreset.UnderLayer);
					this.waypoint_0.method_26();
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_5)
					{
						Submarine_AI submarine_AI = (Submarine_AI)this.activeUnit_0.vmethod_86();
						submarine_AI.method_115(ActiveUnit_AI.SubmarineDepthPreset.UnderLayer);
						submarine_AI.vmethod_28(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						@class.method_112(ActiveUnit_AI.SubmarineDepthPreset.UnderLayer);
						@class.vmethod_28(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A39 RID: 35385 RVA: 0x004A4CC8 File Offset: 0x004A2EC8
		private void method_27(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_5 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup)) && this.vmethod_42().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_34(ActiveUnit_AI.SubmarineDepthPreset.MaxDepth);
					Client.smethod_58().method_26();
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_34(ActiveUnit_AI.SubmarineDepthPreset.MaxDepth);
					this.waypoint_0.method_26();
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_5)
					{
						Submarine_AI submarine_AI = (Submarine_AI)this.activeUnit_0.vmethod_86();
						submarine_AI.method_115(ActiveUnit_AI.SubmarineDepthPreset.MaxDepth);
						submarine_AI.vmethod_28(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						@class.method_112(ActiveUnit_AI.SubmarineDepthPreset.MaxDepth);
						@class.vmethod_28(false);
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A3A RID: 35386 RVA: 0x004A4E8C File Offset: 0x004A308C
		private void method_28(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_5 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup)) && this.vmethod_154().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_34(ActiveUnit_AI.SubmarineDepthPreset.None);
					Client.smethod_58().nullable_1 = null;
					Client.smethod_58().nullable_2 = null;
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_34(ActiveUnit_AI.SubmarineDepthPreset.None);
					this.waypoint_0.nullable_1 = null;
					this.waypoint_0.nullable_2 = null;
				}
			}
		}

		// Token: 0x06008A3B RID: 35387 RVA: 0x004A4F84 File Offset: 0x004A3184
		private void method_29(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_3 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)) && this.vmethod_66().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_32(ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude);
					Client.smethod_58().nullable_1 = null;
					Client.smethod_58().nullable_2 = null;
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_32(ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude);
					this.waypoint_0.nullable_1 = null;
					this.waypoint_0.nullable_2 = null;
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_3)
					{
						Aircraft_AI aircraft_AI = ((Aircraft)this.activeUnit_0).method_158();
						aircraft_AI.method_115(ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude);
						aircraft_AI.vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						@class.method_113(ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude);
						@class.vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A3C RID: 35388 RVA: 0x004A5174 File Offset: 0x004A3374
		private void method_30(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_3 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)) && this.vmethod_152().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_32(ActiveUnit_AI.AircraftAltitudePreset.None);
					Client.smethod_58().nullable_1 = null;
					Client.smethod_58().nullable_2 = null;
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_32(ActiveUnit_AI.AircraftAltitudePreset.None);
					this.waypoint_0.nullable_1 = null;
					this.waypoint_0.nullable_2 = null;
				}
			}
		}

		// Token: 0x06008A3D RID: 35389 RVA: 0x004A526C File Offset: 0x004A346C
		private void method_31(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_3 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)) && this.vmethod_64().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_32(ActiveUnit_AI.AircraftAltitudePreset.High36000);
					Client.smethod_58().method_25();
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_32(ActiveUnit_AI.AircraftAltitudePreset.High36000);
					this.waypoint_0.method_25();
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_3)
					{
						Aircraft_AI aircraft_AI = ((Aircraft)this.activeUnit_0).method_158();
						aircraft_AI.method_115(ActiveUnit_AI.AircraftAltitudePreset.High36000);
						aircraft_AI.vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						((Class167)this.activeUnit_0.vmethod_86()).method_113(ActiveUnit_AI.AircraftAltitudePreset.High36000);
						((Class167)this.activeUnit_0.vmethod_86()).vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A3E RID: 35390 RVA: 0x004A544C File Offset: 0x004A364C
		private void method_32(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_3 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)) && this.vmethod_62().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_32(ActiveUnit_AI.AircraftAltitudePreset.High25000);
					Client.smethod_58().method_25();
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_32(ActiveUnit_AI.AircraftAltitudePreset.High25000);
					this.waypoint_0.method_25();
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_3)
					{
						Aircraft_AI aircraft_AI = ((Aircraft)this.activeUnit_0).method_158();
						aircraft_AI.method_115(ActiveUnit_AI.AircraftAltitudePreset.High25000);
						aircraft_AI.vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						((Class167)this.activeUnit_0.vmethod_86()).method_113(ActiveUnit_AI.AircraftAltitudePreset.High25000);
						((Class167)this.activeUnit_0.vmethod_86()).vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A3F RID: 35391 RVA: 0x004A562C File Offset: 0x004A382C
		private void method_33(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_3 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)) && this.vmethod_54().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_32(ActiveUnit_AI.AircraftAltitudePreset.Medium12000);
					Client.smethod_58().method_25();
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_32(ActiveUnit_AI.AircraftAltitudePreset.Medium12000);
					this.waypoint_0.method_25();
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_3)
					{
						Aircraft_AI aircraft_AI = ((Aircraft)this.activeUnit_0).method_158();
						aircraft_AI.method_115(ActiveUnit_AI.AircraftAltitudePreset.Medium12000);
						aircraft_AI.vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						((Class167)this.activeUnit_0.vmethod_86()).method_113(ActiveUnit_AI.AircraftAltitudePreset.Medium12000);
						((Class167)this.activeUnit_0.vmethod_86()).vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A40 RID: 35392 RVA: 0x004A580C File Offset: 0x004A3A0C
		private void method_34(object sender, EventArgs e)
		{
			if (this.activeUnit_0 != null && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_3 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)) && this.vmethod_56().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_32(ActiveUnit_AI.AircraftAltitudePreset.Low2000);
					Client.smethod_58().method_25();
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_32(ActiveUnit_AI.AircraftAltitudePreset.Low2000);
					this.waypoint_0.method_25();
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_3)
					{
						Aircraft_AI aircraft_AI = ((Aircraft)this.activeUnit_0).method_158();
						aircraft_AI.method_115(ActiveUnit_AI.AircraftAltitudePreset.Low2000);
						aircraft_AI.vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						((Class167)this.activeUnit_0.vmethod_86()).method_113(ActiveUnit_AI.AircraftAltitudePreset.Low2000);
						((Class167)this.activeUnit_0.vmethod_86()).vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A41 RID: 35393 RVA: 0x004A59E8 File Offset: 0x004A3BE8
		private void method_35(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_3 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)) && this.vmethod_60().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_32(ActiveUnit_AI.AircraftAltitudePreset.Low1000);
					Client.smethod_58().method_25();
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_32(ActiveUnit_AI.AircraftAltitudePreset.Low1000);
					this.waypoint_0.method_25();
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_3)
					{
						Aircraft_AI aircraft_AI = ((Aircraft)this.activeUnit_0).method_158();
						aircraft_AI.method_115(ActiveUnit_AI.AircraftAltitudePreset.Low1000);
						aircraft_AI.vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						@class.method_113(ActiveUnit_AI.AircraftAltitudePreset.Low1000);
						@class.vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A42 RID: 35394 RVA: 0x004A5BA8 File Offset: 0x004A3DA8
		private void method_36(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.bool_6 && (!Information.IsNothing(this.waypoint_0) || this.activeUnit_0.bool_3 || (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)) && this.vmethod_58().Checked)
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_32(ActiveUnit_AI.AircraftAltitudePreset.MinAltitude);
					Client.smethod_58().method_25();
					return;
				}
				if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_32(ActiveUnit_AI.AircraftAltitudePreset.MinAltitude);
					this.waypoint_0.method_25();
					return;
				}
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_3)
					{
						Aircraft_AI aircraft_AI = ((Aircraft)this.activeUnit_0).method_158();
						aircraft_AI.method_115(ActiveUnit_AI.AircraftAltitudePreset.MinAltitude);
						aircraft_AI.vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					else if (this.activeUnit_0.bool_1)
					{
						Class167 @class = (Class167)this.activeUnit_0.vmethod_86();
						@class.method_113(ActiveUnit_AI.AircraftAltitudePreset.MinAltitude);
						@class.vmethod_27();
						this.vmethod_16().Value = (int)Math.Round((double)Math.Max(this.activeUnit_0.vmethod_72(), (float)this.vmethod_16().Minimum));
					}
					this.activeUnit_0.vmethod_86().method_25();
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
			}
		}

		// Token: 0x06008A43 RID: 35395 RVA: 0x00052C84 File Offset: 0x00050E84
		private void method_37(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x06008A44 RID: 35396 RVA: 0x00052C8D File Offset: 0x00050E8D
		private void method_38(object sender, EventArgs e)
		{
			this.method_40();
		}

		// Token: 0x06008A45 RID: 35397 RVA: 0x00052C95 File Offset: 0x00050E95
		private void method_39(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x06008A46 RID: 35398 RVA: 0x004A5D68 File Offset: 0x004A3F68
		private void method_40()
		{
			if (this.bool_3)
			{
				this.method_20();
				if (((!Information.IsNothing(Client.smethod_58())) ? Client.smethod_58().nullable_4 : new bool?(false)).GetValueOrDefault())
				{
					if (Versioned.IsNumeric(this.vmethod_70().Text))
					{
						Client.smethod_58().nullable_5 = new float?(Conversions.ToSingle(this.vmethod_70().Text));
						Client.smethod_58().method_28(null);
					}
				}
				else if (Information.IsNothing(Client.smethod_58()) && !Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.vmethod_85().vmethod_3())
				{
					if (Versioned.IsNumeric(this.vmethod_70().Text))
					{
						this.activeUnit_0.vmethod_85().vmethod_6(new float?(Conversions.ToSingle(this.vmethod_70().Text)));
						this.activeUnit_0.vmethod_87().vmethod_11(null);
					}
				}
				else if (Operators.CompareString(this.vmethod_70().Text, "", false) == 0 && !Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_28(null);
					Client.smethod_58().nullable_0 = null;
					this.vmethod_38().Checked = false;
					Client.smethod_58().enum82_1 = Waypoint.Enum82.const_1;
					this.method_20();
				}
				else if (Operators.CompareString(this.vmethod_70().Text, "", false) == 0 && !Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_28(null);
					this.waypoint_0.nullable_0 = null;
					this.vmethod_38().Checked = false;
					this.waypoint_0.enum82_1 = Waypoint.Enum82.const_1;
					this.method_20();
				}
				else if ((Versioned.IsNumeric(this.vmethod_70().Text) || Information.IsNothing(Client.smethod_58()) || !Information.IsNothing(this.waypoint_0)) && (Versioned.IsNumeric(this.vmethod_70().Text) || Information.IsNothing(this.waypoint_0)) && (Operators.CompareString(this.vmethod_70().Text, "", false) != 0 & Versioned.IsNumeric(this.vmethod_70().Text)))
				{
					int num = Conversions.ToInteger(this.vmethod_70().Text);
					if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
					{
						Client.smethod_58().nullable_0 = new float?((float)num);
						Client.smethod_58().enum82_1 = Waypoint.Enum82.const_1;
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						this.waypoint_0.nullable_0 = new float?((float)num);
						this.waypoint_0.enum82_1 = Waypoint.Enum82.const_1;
					}
					else if (!Information.IsNothing(this.activeUnit_0))
					{
						if (num > Math.Max(this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_82(), false), this.activeUnit_0.vmethod_87().vmethod_39(this.activeUnit_0.vmethod_72())))
						{
							num = Math.Max(this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_82(), false), this.activeUnit_0.vmethod_87().vmethod_39(this.activeUnit_0.vmethod_72()));
						}
						if (this.activeUnit_0.bool_3)
						{
							if (!((Aircraft)this.activeUnit_0).method_150(false) && num < ((Aircraft)this.activeUnit_0).method_159().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Loiter, false))
							{
								num = ((Aircraft)this.activeUnit_0).method_159().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Loiter, false);
							}
						}
						else if (this.activeUnit_0.bool_2)
						{
							if (num < ((Weapon)this.activeUnit_0).vmethod_143().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Cruise, false))
							{
								num = ((Weapon)this.activeUnit_0).vmethod_143().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Cruise, false);
							}
						}
						else if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)
						{
							if (Information.IsNothing(((Group)this.activeUnit_0).method_147()))
							{
								return;
							}
							Aircraft aircraft = (Aircraft)((Group)this.activeUnit_0).method_147();
							if (!aircraft.method_150(false) && num < aircraft.method_159().vmethod_40(aircraft.vmethod_14(false), ActiveUnit.Throttle.Loiter, false))
							{
								num = aircraft.method_159().vmethod_40(aircraft.vmethod_14(false), ActiveUnit.Throttle.Loiter, false);
							}
						}
						else if (num < (int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_32(this.activeUnit_0.vmethod_14(false), false)))
						{
							num = (int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_32(this.activeUnit_0.vmethod_14(false), false));
						}
						this.activeUnit_0.vmethod_71((float)num);
					}
					this.method_19();
				}
			}
			this.bool_3 = false;
			this.method_5(false);
		}

		// Token: 0x06008A47 RID: 35399 RVA: 0x00052C9E File Offset: 0x00050E9E
		private void method_41(object sender, EventArgs e)
		{
			this.method_42();
		}

		// Token: 0x06008A48 RID: 35400 RVA: 0x004A62C8 File Offset: 0x004A44C8
		private void method_42()
		{
			if (this.bool_4)
			{
				this.method_21();
				if (Operators.CompareString(this.vmethod_74().Text, "", false) == 0 && !Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_30(false);
					Client.smethod_58().nullable_1 = null;
					Client.smethod_58().nullable_2 = null;
				}
				else if (Operators.CompareString(this.vmethod_74().Text, "", false) == 0 && !Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_30(false);
					this.waypoint_0.nullable_1 = null;
					this.waypoint_0.nullable_2 = null;
				}
				else if ((Versioned.IsNumeric(this.vmethod_74().Text) || Information.IsNothing(Client.smethod_58()) || !Information.IsNothing(this.waypoint_0)) && (Versioned.IsNumeric(this.vmethod_74().Text) || Information.IsNothing(this.waypoint_0)) && (Operators.CompareString(this.vmethod_74().Text, "", false) != 0 & Versioned.IsNumeric(this.vmethod_74().Text)))
				{
					float num = Conversions.ToSingle(this.vmethod_74().Text);
					if (Class570.class280_0.method_12())
					{
						num /= 3.28084f;
					}
					if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
					{
						if (Client.smethod_58().method_37())
						{
							Client.smethod_58().nullable_1 = null;
							Client.smethod_58().nullable_2 = new float?(num);
						}
						else
						{
							Client.smethod_58().nullable_1 = new float?(num);
							Client.smethod_58().nullable_2 = null;
						}
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						if (this.waypoint_0.method_37())
						{
							this.waypoint_0.nullable_1 = null;
							this.waypoint_0.nullable_2 = new float?(num);
						}
						else
						{
							this.waypoint_0.nullable_1 = new float?(num);
							this.waypoint_0.nullable_2 = null;
						}
					}
					else if (!Information.IsNothing(this.activeUnit_0))
					{
						float num2 = this.activeUnit_0.vmethod_87().vmethod_30();
						float num3 = this.activeUnit_0.vmethod_87().vmethod_31();
						if (num < num3)
						{
							num = num3;
						}
						if (num > num2)
						{
							num = num2;
						}
						this.activeUnit_0.vmethod_73(num);
						if (this.activeUnit_0.vmethod_76(this.activeUnit_0))
						{
							this.activeUnit_0.vmethod_75(num);
						}
						else
						{
							this.activeUnit_0.vmethod_73(num);
						}
					}
					this.method_18();
				}
			}
			this.bool_4 = false;
			this.method_5(false);
		}

		// Token: 0x06008A49 RID: 35401 RVA: 0x00043AB9 File Offset: 0x00041CB9
		private void method_43(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x06008A4A RID: 35402 RVA: 0x00043AB9 File Offset: 0x00041CB9
		private void method_44(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x06008A4B RID: 35403 RVA: 0x004A65A0 File Offset: 0x004A47A0
		private void SpeedAlt_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F2 && base.Visible)
			{
				base.Close();
				return;
			}
			if (!base.Visible || (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Space))
			{
				if ((this.bool_3 || this.bool_4 || this.bool_5) && (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12))
				{
					Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
				if (!this.bool_4 && !this.bool_3 && !this.bool_5)
				{
					Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
		}

		// Token: 0x06008A4C RID: 35404 RVA: 0x004A6700 File Offset: 0x004A4900
		public void method_45(object sender, EventArgs e)
		{
			if (this.bool_6 && (!Information.IsNothing(this.activeUnit_0) || !Information.IsNothing(this.waypoint_0)))
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_30(this.vmethod_36().Checked);
					if (Information.IsNothing(Client.smethod_58().nullable_1))
					{
						Client.smethod_58().nullable_1 = new float?(0f);
					}
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_30(this.vmethod_36().Checked);
					if (Information.IsNothing(this.waypoint_0.nullable_1))
					{
						this.waypoint_0.nullable_1 = new float?(0f);
					}
				}
				else
				{
					this.activeUnit_0.vmethod_87().vmethod_13(this.vmethod_36().Checked);
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
				if (!this.vmethod_36().Checked)
				{
					this.method_21();
					if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
					{
						Client.smethod_58().nullable_1 = null;
						Client.smethod_58().nullable_2 = null;
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						this.waypoint_0.nullable_1 = null;
						this.waypoint_0.nullable_2 = null;
					}
					else
					{
						this.activeUnit_0.vmethod_86().method_25();
					}
				}
				if (Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
				this.method_5(false);
			}
		}

		// Token: 0x06008A4D RID: 35405 RVA: 0x004A6900 File Offset: 0x004A4B00
		public void method_46(object sender, EventArgs e)
		{
			if (this.bool_6 && (!Information.IsNothing(this.activeUnit_0) || !Information.IsNothing(this.waypoint_0)))
			{
				if (this.vmethod_38().Checked)
				{
					if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
					{
						if (Client.smethod_58().nullable_0 != null)
						{
							Client.smethod_58().method_28(Client.smethod_58().nullable_0);
						}
						else
						{
							Client.smethod_58().nullable_0 = new float?(0f);
							Client.smethod_58().method_28(Client.smethod_58().nullable_0);
						}
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						if (this.waypoint_0.nullable_0 != null)
						{
							this.waypoint_0.method_28(this.waypoint_0.nullable_0);
						}
						else
						{
							this.waypoint_0.nullable_0 = new float?(0f);
							this.waypoint_0.method_28(this.waypoint_0.nullable_0);
						}
					}
					else
					{
						this.activeUnit_0.vmethod_87().vmethod_11(new float?(this.activeUnit_0.vmethod_70()));
					}
				}
				else
				{
					this.method_20();
					if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
					{
						Client.smethod_58().enum82_1 = Waypoint.Enum82.const_0;
						Client.smethod_58().method_36(ActiveUnit_Kinematics.UnitThrottlePreset.None);
						Client.smethod_58().method_28(null);
						Client.smethod_58().nullable_0 = null;
					}
					else if (!Information.IsNothing(this.waypoint_0))
					{
						this.waypoint_0.enum82_1 = Waypoint.Enum82.const_0;
						this.waypoint_0.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.None);
						this.waypoint_0.method_28(null);
						this.waypoint_0.nullable_0 = null;
						Scenario scenario_ = Client.smethod_46();
						Mission mission = this.mission_0;
						ActiveUnit activeUnit = this.flight_0.method_32(Client.smethod_46());
						Mission.Flight flight = this.flight_0;
						Mission.Flight flight2;
						Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
						float num = 0f;
						float num2 = 0f;
						Class514.smethod_28(scenario_, mission, activeUnit, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
						flight2.method_16(waypoint_);
						Client.bool_1 = true;
						if (Client.smethod_32().Visible)
						{
							Client.smethod_32().method_13();
							Client.smethod_32().flightPlanWaypoints_6.method_14();
						}
					}
					else
					{
						this.activeUnit_0.vmethod_87().vmethod_11(null);
						this.activeUnit_0.vmethod_86().method_25();
					}
				}
				if (Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), this.activeUnit_0, false);
				}
				this.method_5(false);
			}
		}

		// Token: 0x06008A4E RID: 35406 RVA: 0x00052CA6 File Offset: 0x00050EA6
		private void method_47(object sender, EventArgs e)
		{
			this.bool_5 = true;
		}

		// Token: 0x06008A4F RID: 35407 RVA: 0x004A6C0C File Offset: 0x004A4E0C
		private void method_48(object sender, EventArgs e)
		{
			switch (this.vmethod_102().SelectedIndex)
			{
			case 0:
				Client.smethod_58().waypointType_0 = Waypoint.WaypointType.Assemble;
				break;
			case 1:
				Client.smethod_58().waypointType_0 = Waypoint.WaypointType.ManualPlottedCourseWaypoint;
				break;
			case 2:
				Client.smethod_58().waypointType_0 = Waypoint.WaypointType.Target;
				break;
			}
			this.bool_5 = false;
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x00052CA6 File Offset: 0x00050EA6
		private void method_49(object sender, EventArgs e)
		{
			this.bool_5 = true;
		}

		// Token: 0x06008A51 RID: 35409 RVA: 0x00052CAF File Offset: 0x00050EAF
		private void method_50(object sender, EventArgs e)
		{
			this.method_51();
		}

		// Token: 0x06008A52 RID: 35410 RVA: 0x004A6C68 File Offset: 0x004A4E68
		private void method_51()
		{
			if (this.bool_5)
			{
				if (Information.IsNothing(this.waypoint_0) && !Information.IsNothing(Client.smethod_58()))
				{
					Client.smethod_58().string_2 = this.vmethod_100().Text;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.string_2 = this.vmethod_100().Text;
				}
			}
			this.bool_5 = false;
			this.method_5(false);
		}

		// Token: 0x06008A53 RID: 35411 RVA: 0x00052CB7 File Offset: 0x00050EB7
		private void SpeedAlt_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.method_52(true);
			Class2413.smethod_2().method_41().BringToFront();
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x06008A54 RID: 35412 RVA: 0x004A6CE0 File Offset: 0x004A4EE0
		private void method_52(bool bool_8)
		{
			if (this.vmethod_74().Focused || bool_8)
			{
				this.method_42();
			}
			if (this.vmethod_70().Focused || bool_8)
			{
				this.method_40();
			}
			if (this.vmethod_100().Focused || bool_8)
			{
				this.method_51();
			}
			checked
			{
				if (!Information.IsNothing(this.waypoint_0) || !Information.IsNothing(Client.smethod_58()))
				{
					bool flag = false;
					Waypoint waypoint;
					if (!Information.IsNothing(this.waypoint_0))
					{
						waypoint = this.waypoint_0;
					}
					else
					{
						waypoint = Client.smethod_58();
					}
					if (waypoint.enum79_0 == Waypoint.Enum79.const_1)
					{
						Side[] array = Client.smethod_46().method_44();
						int i = 0;
						while (i < array.Length)
						{
							Side side = array[i];
							try
							{
								foreach (Mission mission in side.method_35())
								{
									try
									{
										foreach (Mission.Flight flight in mission.list_1)
										{
											if (Enumerable.Contains<Waypoint>(flight.method_15(), waypoint))
											{
												Scenario scenario_ = Client.smethod_46();
												Mission mission2 = mission;
												ActiveUnit activeUnit = flight.method_32(Client.smethod_46());
												Mission.Flight flight2 = flight;
												Mission.Flight flight3;
												Waypoint[] waypoint_ = (flight3 = flight).method_15();
												float num = 0f;
												float num2 = 0f;
												Class514.smethod_28(scenario_, mission2, activeUnit, flight2, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
												flight3.method_16(waypoint_);
												Class2413.smethod_2().method_41().method_235();
												flag = true;
												if (Client.smethod_32().Visible)
												{
													Client.smethod_32().method_13();
													Client.smethod_32().flightPlanWaypoints_6.method_14();
													break;
												}
												break;
											}
										}
									}
									finally
									{
										List<Mission.Flight>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
									if (flag)
									{
										break;
									}
								}
								goto IL_1DC;
							}
							finally
							{
								IEnumerator<Mission> enumerator;
								if (enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							IL_1D3:
							i++;
							continue;
							IL_1DC:
							if (flag)
							{
								break;
							}
							goto IL_1D3;
						}
						if (Client.smethod_32().Visible)
						{
							Client.smethod_32().method_9(false);
							Client.smethod_32().method_13();
							Client.smethod_32().flightPlanWaypoints_6.method_14();
						}
						if (Client.smethod_31().Visible)
						{
							Client.smethod_31().method_5();
						}
					}
				}
				this.vmethod_38().Select();
			}
		}

		// Token: 0x06008A55 RID: 35413 RVA: 0x004A6F54 File Offset: 0x004A5154
		private void SpeedAlt_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.bool_7)
			{
				Client.smethod_17(new Client.Delegate80(this.method_4));
				Client.smethod_19(new Client.Delegate81(this.method_4));
			}
			this.bool_7 = false;
			this.waypoint_0 = null;
			this.activeUnit_0 = null;
		}

		// Token: 0x06008A56 RID: 35414 RVA: 0x004A6FA0 File Offset: 0x004A51A0
		private void method_53(object sender, EventArgs e)
		{
			if (this.bool_6 && (!Information.IsNothing(this.activeUnit_0) || !Information.IsNothing(this.waypoint_0)))
			{
				if (!Information.IsNothing(Client.smethod_58()) && Information.IsNothing(this.waypoint_0))
				{
					Client.smethod_58().method_38(this.vmethod_142().Checked);
					if (Client.smethod_58().method_37())
					{
						Client.smethod_58().nullable_2 = Client.smethod_58().nullable_1;
						Client.smethod_58().nullable_1 = null;
						return;
					}
					Client.smethod_58().nullable_1 = Client.smethod_58().nullable_2;
					Client.smethod_58().nullable_2 = null;
					return;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.method_38(this.vmethod_142().Checked);
					if (this.waypoint_0.method_37())
					{
						this.waypoint_0.nullable_2 = this.waypoint_0.nullable_1;
						this.waypoint_0.nullable_1 = null;
						return;
					}
					this.waypoint_0.nullable_1 = this.waypoint_0.nullable_2;
					this.waypoint_0.nullable_2 = null;
					return;
				}
				else if (!Information.IsNothing(this.activeUnit_0))
				{
					if (this.activeUnit_0.bool_3)
					{
						this.activeUnit_0.vmethod_77(this.activeUnit_0, this.vmethod_142().Checked);
					}
					else if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)
					{
						Group group = (Group)this.activeUnit_0;
						if (!Information.IsNothing(group.method_122()))
						{
							group.method_147().vmethod_77(group.method_147(), this.vmethod_142().Checked);
						}
					}
					if (this.activeUnit_0.bool_3 | (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup))
					{
						if (this.activeUnit_0.vmethod_76(this.activeUnit_0))
						{
							if (this.activeUnit_0.vmethod_72() > 0f)
							{
								this.activeUnit_0.vmethod_75(this.activeUnit_0.vmethod_72());
								return;
							}
							if (!this.activeUnit_0.method_121())
							{
								this.activeUnit_0.vmethod_75(200f);
								return;
							}
							if (!Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()))
							{
								if (this.activeUnit_0.vmethod_65(false).method_147().vmethod_74() > 0f)
								{
									this.activeUnit_0.vmethod_75(this.activeUnit_0.vmethod_65(false).method_147().vmethod_74());
									return;
								}
								this.activeUnit_0.vmethod_75(200f);
								return;
							}
						}
						else
						{
							float num = this.activeUnit_0.vmethod_74();
							float num2 = this.activeUnit_0.vmethod_87().vmethod_30();
							float num3 = this.activeUnit_0.vmethod_87().vmethod_31();
							if (num < num3)
							{
								num = num3;
							}
							if (num > num2)
							{
								num = num2;
							}
							this.activeUnit_0.vmethod_73(num);
						}
					}
				}
			}
		}

		// Token: 0x06008A57 RID: 35415 RVA: 0x004A72B0 File Offset: 0x004A54B0
		private void method_54(object sender, EventArgs e)
		{
			if (!Information.IsNothing(Client.smethod_58()))
			{
				CheckState checkState = this.vmethod_156().CheckState;
				if (checkState > CheckState.Checked)
				{
					if (checkState != CheckState.Indeterminate)
					{
						return;
					}
					Client.smethod_58().nullable_4 = null;
					Client.smethod_58().nullable_5 = null;
					return;
				}
				else
				{
					Client.smethod_58().nullable_4 = new bool?(this.vmethod_156().Checked);
					if (!Client.smethod_58().nullable_4.GetValueOrDefault())
					{
						Client.smethod_58().nullable_5 = null;
						return;
					}
					if (Information.IsNothing(Client.smethod_58().nullable_5) && !Information.IsNothing(Client.smethod_58().nullable_0))
					{
						Client.smethod_58().nullable_5 = Client.smethod_58().nullable_0;
						return;
					}
				}
			}
			else if (Information.IsNothing(this.waypoint_0) && !Information.IsNothing(Client.smethod_54()) && Client.smethod_54().bool_0)
			{
				this.activeUnit_0.vmethod_85().vmethod_4(this.vmethod_156().Checked);
				this.method_5(false);
			}
		}

		// Token: 0x06008A58 RID: 35416 RVA: 0x004A73CC File Offset: 0x004A55CC
		private void method_55(object sender, EventArgs e)
		{
			if (Information.IsNothing(Client.smethod_58()))
			{
				if (Information.IsNothing(this.waypoint_0) && !Information.IsNothing(Client.smethod_54()) && Client.smethod_54().bool_0)
				{
					((ActiveUnit)Client.smethod_54()).vmethod_85().bool_15 = this.vmethod_158().Checked;
					this.method_5(false);
				}
				return;
			}
			CheckState checkState = this.vmethod_158().CheckState;
			if (checkState <= CheckState.Checked)
			{
				Client.smethod_58().nullable_6 = new bool?(this.vmethod_158().Checked);
				return;
			}
			if (checkState != CheckState.Indeterminate)
			{
				return;
			}
			Client.smethod_58().nullable_6 = null;
		}

		// Token: 0x06008A59 RID: 35417 RVA: 0x004A7474 File Offset: 0x004A5674
		public void method_56(object sender, EventArgs e)
		{
			if (Client.smethod_54() != null && Client.smethod_58() != null)
			{
				int num = Array.IndexOf<Waypoint>(((ActiveUnit)Client.smethod_54()).vmethod_85().method_4(), Client.smethod_58());
				if (num == 0)
				{
					Client.smethod_59(null);
					return;
				}
				Client.smethod_59(((ActiveUnit)Client.smethod_54()).vmethod_85().method_4()[num - 1]);
				this.method_5(false);
			}
		}

		// Token: 0x06008A5A RID: 35418 RVA: 0x004A74DC File Offset: 0x004A56DC
		public void method_57(object sender, EventArgs e)
		{
			if (Client.smethod_54() != null)
			{
				if (Client.smethod_58() == null)
				{
					if (((ActiveUnit)Client.smethod_54()).vmethod_85().method_47())
					{
						Client.smethod_59(((ActiveUnit)Client.smethod_54()).vmethod_85().method_4()[0]);
					}
				}
				else
				{
					int num = Array.IndexOf<Waypoint>(((ActiveUnit)Client.smethod_54()).vmethod_85().method_4(), Client.smethod_58());
					if (num == Enumerable.Count<Waypoint>(((ActiveUnit)Client.smethod_54()).vmethod_85().method_4()) - 1)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
							return;
						}
						return;
					}
					else
					{
						Client.smethod_59(((ActiveUnit)Client.smethod_54()).vmethod_85().method_4()[num + 1]);
					}
				}
				this.method_5(false);
			}
		}

		// Token: 0x04004AB2 RID: 19122
		[CompilerGenerated]
		[AccessedThroughProperty("TrackBar_Throttle")]
		private TrackBar trackBar_0;

		// Token: 0x04004AB3 RID: 19123
		[CompilerGenerated]
		[AccessedThroughProperty("Label_MinSpeed")]
		private Class116 class116_0;

		// Token: 0x04004AB4 RID: 19124
		[AccessedThroughProperty("Label_MaxSpeed")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x04004AB5 RID: 19125
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_2;

		// Token: 0x04004AB6 RID: 19126
		[AccessedThroughProperty("Label_DesiredSpeed")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x04004AB7 RID: 19127
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x04004AB8 RID: 19128
		[AccessedThroughProperty("Label_ActualSpeed")]
		[CompilerGenerated]
		private Class116 class116_5;

		// Token: 0x04004AB9 RID: 19129
		[AccessedThroughProperty("Timer1")]
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x04004ABA RID: 19130
		[AccessedThroughProperty("TrackBar_Altitude")]
		[CompilerGenerated]
		private TrackBar trackBar_1;

		// Token: 0x04004ABB RID: 19131
		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Class116 class116_6;

		// Token: 0x04004ABC RID: 19132
		[AccessedThroughProperty("Label6")]
		[CompilerGenerated]
		private Class116 class116_7;

		// Token: 0x04004ABD RID: 19133
		[CompilerGenerated]
		[AccessedThroughProperty("Label_MaxAlt")]
		private Class116 class116_8;

		// Token: 0x04004ABE RID: 19134
		[CompilerGenerated]
		[AccessedThroughProperty("Label_MinAlt")]
		private Class116 class116_9;

		// Token: 0x04004ABF RID: 19135
		[AccessedThroughProperty("Label_DesiredAlt")]
		[CompilerGenerated]
		private Class116 class116_10;

		// Token: 0x04004AC0 RID: 19136
		[AccessedThroughProperty("Label_CurrentAlt")]
		[CompilerGenerated]
		private Class116 class116_11;

		// Token: 0x04004AC1 RID: 19137
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox_Speed")]
		private Class115 class115_0;

		// Token: 0x04004AC2 RID: 19138
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox_Altitude")]
		private Class115 class115_1;

		// Token: 0x04004AC3 RID: 19139
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox_SpeedPresets")]
		private Class115 class115_2;

		// Token: 0x04004AC4 RID: 19140
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AltOverride")]
		private Class112 class112_0;

		// Token: 0x04004AC5 RID: 19141
		[AccessedThroughProperty("CB_SpeedOverride")]
		[CompilerGenerated]
		private Class112 class112_1;

		// Token: 0x04004AC6 RID: 19142
		[AccessedThroughProperty("GroupBox_SubDepthPreset")]
		[CompilerGenerated]
		private Class115 class115_3;

		// Token: 0x04004AC7 RID: 19143
		[CompilerGenerated]
		[AccessedThroughProperty("RB_MaxDepth")]
		private Class122 class122_0;

		// Token: 0x04004AC8 RID: 19144
		[CompilerGenerated]
		[AccessedThroughProperty("RB_UnderLayer")]
		private Class122 class122_1;

		// Token: 0x04004AC9 RID: 19145
		[AccessedThroughProperty("RB_OverLayer")]
		[CompilerGenerated]
		private Class122 class122_2;

		// Token: 0x04004ACA RID: 19146
		[AccessedThroughProperty("RB_Periscope")]
		[CompilerGenerated]
		private Class122 class122_3;

		// Token: 0x04004ACB RID: 19147
		[AccessedThroughProperty("RB_Shallow")]
		[CompilerGenerated]
		private Class122 class122_4;

		// Token: 0x04004ACC RID: 19148
		[AccessedThroughProperty("GroupBox_AltitudePresets")]
		[CompilerGenerated]
		private Class115 class115_4;

		// Token: 0x04004ACD RID: 19149
		[AccessedThroughProperty("RB_MediumAltitude12000")]
		[CompilerGenerated]
		private Class122 class122_5;

		// Token: 0x04004ACE RID: 19150
		[CompilerGenerated]
		[AccessedThroughProperty("RB_LowAltitude2000")]
		private Class122 class122_6;

		// Token: 0x04004ACF RID: 19151
		[CompilerGenerated]
		[AccessedThroughProperty("RB_MinAltitude")]
		private Class122 class122_7;

		// Token: 0x04004AD0 RID: 19152
		[CompilerGenerated]
		[AccessedThroughProperty("RB_LowAltitude1000")]
		private Class122 class122_8;

		// Token: 0x04004AD1 RID: 19153
		[AccessedThroughProperty("RB_HighAltitude25000")]
		[CompilerGenerated]
		private Class122 class122_9;

		// Token: 0x04004AD2 RID: 19154
		[AccessedThroughProperty("RB_HighAltitude36000")]
		[CompilerGenerated]
		private Class122 class122_10;

		// Token: 0x04004AD3 RID: 19155
		[CompilerGenerated]
		[AccessedThroughProperty("RB_MaxAltitude")]
		private Class122 class122_11;

		// Token: 0x04004AD4 RID: 19156
		[CompilerGenerated]
		[AccessedThroughProperty("RB_Surface")]
		private Class122 class122_12;

		// Token: 0x04004AD5 RID: 19157
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_EnterSpeed")]
		private Control8 control8_0;

		// Token: 0x04004AD6 RID: 19158
		[AccessedThroughProperty("Label_Speed")]
		[CompilerGenerated]
		private Class116 class116_12;

		// Token: 0x04004AD7 RID: 19159
		[AccessedThroughProperty("TextBox_EnterAltitude")]
		[CompilerGenerated]
		private Control8 control8_1;

		// Token: 0x04004AD8 RID: 19160
		[AccessedThroughProperty("Label_Altitude")]
		[CompilerGenerated]
		private Class116 class116_13;

		// Token: 0x04004AD9 RID: 19161
		[AccessedThroughProperty("RB_Full")]
		[CompilerGenerated]
		private Class122 class122_13;

		// Token: 0x04004ADA RID: 19162
		[CompilerGenerated]
		[AccessedThroughProperty("RB_Cruise")]
		private Class122 class122_14;

		// Token: 0x04004ADB RID: 19163
		[CompilerGenerated]
		[AccessedThroughProperty("RB_Creep")]
		private Class122 class122_15;

		// Token: 0x04004ADC RID: 19164
		[AccessedThroughProperty("RB_Stop")]
		[CompilerGenerated]
		private Class122 class122_16;

		// Token: 0x04004ADD RID: 19165
		[AccessedThroughProperty("RB_Flank")]
		[CompilerGenerated]
		private Class122 class122_17;

		// Token: 0x04004ADE RID: 19166
		[CompilerGenerated]
		[AccessedThroughProperty("FlowLayoutPanel_Presets")]
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x04004ADF RID: 19167
		[AccessedThroughProperty("Label_WaypointName")]
		[CompilerGenerated]
		private Class116 class116_14;

		// Token: 0x04004AE0 RID: 19168
		[AccessedThroughProperty("GroupBox_Waypoint")]
		[CompilerGenerated]
		private Class115 class115_5;

		// Token: 0x04004AE1 RID: 19169
		[AccessedThroughProperty("Label_TTG")]
		[CompilerGenerated]
		private Class116 class116_15;

		// Token: 0x04004AE2 RID: 19170
		[AccessedThroughProperty("Label_DTG")]
		[CompilerGenerated]
		private Class116 class116_16;

		// Token: 0x04004AE3 RID: 19171
		[CompilerGenerated]
		[AccessedThroughProperty("Label_Fuel")]
		private Class116 class116_17;

		// Token: 0x04004AE4 RID: 19172
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_WaypointDescription")]
		private Control8 control8_2;

		// Token: 0x04004AE5 RID: 19173
		[CompilerGenerated]
		[AccessedThroughProperty("CB_WaypointType")]
		private Class2451 class2451_0;

		// Token: 0x04004AE6 RID: 19174
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_18;

		// Token: 0x04004AE7 RID: 19175
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_19;

		// Token: 0x04004AE8 RID: 19176
		[CompilerGenerated]
		[AccessedThroughProperty("LayerTopPictureBox")]
		private PictureBox pictureBox_0;

		// Token: 0x04004AE9 RID: 19177
		[AccessedThroughProperty("LayerBottomPictureBox")]
		[CompilerGenerated]
		private PictureBox pictureBox_1;

		// Token: 0x04004AEA RID: 19178
		[AccessedThroughProperty("SeaFloorPictureBox")]
		[CompilerGenerated]
		private PictureBox pictureBox_2;

		// Token: 0x04004AEB RID: 19179
		[AccessedThroughProperty("CloudHighTopPictureBox")]
		[CompilerGenerated]
		private PictureBox pictureBox_3;

		// Token: 0x04004AEC RID: 19180
		[AccessedThroughProperty("GroundLevelPictureBox")]
		[CompilerGenerated]
		private PictureBox pictureBox_4;

		// Token: 0x04004AED RID: 19181
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Class116 class116_20;

		// Token: 0x04004AEE RID: 19182
		[CompilerGenerated]
		[AccessedThroughProperty("Label8")]
		private Class116 class116_21;

		// Token: 0x04004AEF RID: 19183
		[CompilerGenerated]
		[AccessedThroughProperty("Label9")]
		private Class116 class116_22;

		// Token: 0x04004AF0 RID: 19184
		[CompilerGenerated]
		[AccessedThroughProperty("Label10")]
		private Class116 class116_23;

		// Token: 0x04004AF1 RID: 19185
		[CompilerGenerated]
		[AccessedThroughProperty("CloudLowTopPictureBox")]
		private PictureBox pictureBox_5;

		// Token: 0x04004AF2 RID: 19186
		[CompilerGenerated]
		[AccessedThroughProperty("CloudLowBottomPictureBox")]
		private PictureBox pictureBox_6;

		// Token: 0x04004AF3 RID: 19187
		[AccessedThroughProperty("CloudHighBottomPictureBox")]
		[CompilerGenerated]
		private PictureBox pictureBox_7;

		// Token: 0x04004AF4 RID: 19188
		[CompilerGenerated]
		[AccessedThroughProperty("Label12")]
		private Class116 class116_24;

		// Token: 0x04004AF5 RID: 19189
		[AccessedThroughProperty("Label11")]
		[CompilerGenerated]
		private Class116 class116_25;

		// Token: 0x04004AF6 RID: 19190
		[CompilerGenerated]
		[AccessedThroughProperty("Label14")]
		private Class116 class116_26;

		// Token: 0x04004AF7 RID: 19191
		[AccessedThroughProperty("Label13")]
		[CompilerGenerated]
		private Class116 class116_27;

		// Token: 0x04004AF8 RID: 19192
		[CompilerGenerated]
		[AccessedThroughProperty("Label_Cavitation")]
		private Class116 class116_28;

		// Token: 0x04004AF9 RID: 19193
		[CompilerGenerated]
		[AccessedThroughProperty("CB_TerrainFollowing")]
		private Class112 class112_2;

		// Token: 0x04004AFA RID: 19194
		[CompilerGenerated]
		[AccessedThroughProperty("ShapeContainer1")]
		private ShapeContainer shapeContainer_0;

		// Token: 0x04004AFB RID: 19195
		[AccessedThroughProperty("LineShape2")]
		[CompilerGenerated]
		private LineShape lineShape_0;

		// Token: 0x04004AFC RID: 19196
		[AccessedThroughProperty("LineShape1")]
		[CompilerGenerated]
		private LineShape lineShape_1;

		// Token: 0x04004AFD RID: 19197
		[AccessedThroughProperty("RB_NoThrottlePreset")]
		[CompilerGenerated]
		private Class122 class122_18;

		// Token: 0x04004AFE RID: 19198
		[AccessedThroughProperty("RB_NoAltitudePreset")]
		[CompilerGenerated]
		private Class122 class122_19;

		// Token: 0x04004AFF RID: 19199
		[AccessedThroughProperty("RB_NoDepthPreset")]
		[CompilerGenerated]
		private Class122 class122_20;

		// Token: 0x04004B00 RID: 19200
		[CompilerGenerated]
		[AccessedThroughProperty("CB_SprintDrift")]
		private Class112 class112_3;

		// Token: 0x04004B01 RID: 19201
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AvoidCavitation")]
		private Class112 class112_4;

		// Token: 0x04004B02 RID: 19202
		[CompilerGenerated]
		[AccessedThroughProperty("FlowLayoutPanel2")]
		private FlowLayoutPanel flowLayoutPanel_1;

		// Token: 0x04004B03 RID: 19203
		[AccessedThroughProperty("Label_X")]
		[CompilerGenerated]
		private Class116 class116_29;

		// Token: 0x04004B04 RID: 19204
		[AccessedThroughProperty("FlowLayoutPanel_SettingsFor")]
		[CompilerGenerated]
		private FlowLayoutPanel flowLayoutPanel_2;

		// Token: 0x04004B05 RID: 19205
		[CompilerGenerated]
		[AccessedThroughProperty("Label_SettingsFor")]
		private Class116 class116_30;

		// Token: 0x04004B06 RID: 19206
		[CompilerGenerated]
		[AccessedThroughProperty("Button_Previous")]
		private Class111 class111_0;

		// Token: 0x04004B07 RID: 19207
		[AccessedThroughProperty("Button_Next")]
		[CompilerGenerated]
		private Class111 class111_1;

		// Token: 0x04004B08 RID: 19208
		public ActiveUnit activeUnit_0;

		// Token: 0x04004B09 RID: 19209
		public Waypoint waypoint_0;

		// Token: 0x04004B0A RID: 19210
		public Mission.Flight flight_0;

		// Token: 0x04004B0B RID: 19211
		public Mission mission_0;

		// Token: 0x04004B0C RID: 19212
		private bool bool_3;

		// Token: 0x04004B0D RID: 19213
		private bool bool_4;

		// Token: 0x04004B0E RID: 19214
		private bool bool_5;

		// Token: 0x04004B0F RID: 19215
		private bool bool_6;

		// Token: 0x04004B10 RID: 19216
		private bool bool_7;
	}
}
