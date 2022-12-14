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
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;
using ns13;
using ns14;
using ns2;
using ns5;

namespace ns4
{
	// Token: 0x02000E1A RID: 3610
	[DesignerGenerated]
	internal sealed partial class FlightPlanEditor : DarkSecondaryFormBase
	{
		// Token: 0x06006A85 RID: 27269 RVA: 0x0039CF90 File Offset: 0x0039B190
		public FlightPlanEditor()
		{
			base.FormClosing += this.FlightPlanEditor_FormClosing;
			base.FormClosed += this.FlightPlanEditor_FormClosed;
			base.Load += this.FlightPlanEditor_Load;
			base.VisibleChanged += this.FlightPlanEditor_VisibleChanged;
			base.KeyDown += this.FlightPlanEditor_KeyDown;
			base.Shown += this.FlightPlanEditor_Shown;
			this.bool_3 = true;
			this.int_0 = 0;
			this.bool_4 = false;
			this.dataTable_0 = new DataTable();
			this.dataTable_1 = new DataTable();
			this.dataTable_2 = new DataTable();
			this.dataTable_3 = new DataTable();
			this.dataTable_4 = new DataTable();
			this.dataTable_5 = new DataTable();
			this.dataTable_6 = new DataTable();
			this.dataTable_7 = new DataTable();
			this.dataTable_8 = new DataTable();
			this.dataTable_9 = new DataTable();
			this.dataTable_10 = new DataTable();
			this.dataTable_11 = new DataTable();
			this.dataTable_12 = new DataTable();
			this.bitmap_0 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Locked_16.png");
			this.bitmap_1 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Unlocked_16.png");
			this.bitmap_2 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\NotConfigured_16.png");
			this.bitmap_3 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\NotLockable_16.png");
			this.bitmap_4 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Relative_16.png");
			this.InitializeComponent_1();
		}

		// Token: 0x06006A87 RID: 27271 RVA: 0x0039D194 File Offset: 0x0039B394
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control12());
			this.vmethod_3(new TabPage());
			this.vmethod_39(new FlightPlanWaypoints());
			this.vmethod_5(new TabPage());
			this.vmethod_43(new FlightPlanWaypoints());
			this.vmethod_7(new TabPage());
			this.vmethod_45(new FlightPlanWaypoints());
			this.vmethod_9(new TabPage());
			this.vmethod_47(new FlightPlanWaypoints());
			this.vmethod_11(new TabPage());
			this.vmethod_49(new FlightPlanWaypoints());
			this.vmethod_13(new TabPage());
			this.vmethod_51(new FlightPlanWaypoints());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Class116());
			this.vmethod_19(new Class116());
			this.vmethod_21(new Class116());
			this.vmethod_23(new Class2451());
			this.vmethod_25(new Class2451());
			this.vmethod_27(new Class2451());
			this.vmethod_29(new Control8());
			this.vmethod_31(new Class111());
			this.vmethod_33(new Class116());
			this.vmethod_35(new Class116());
			this.vmethod_37(new Class116());
			this.vmethod_41(new Class116());
			this.vmethod_53(new Class111());
			this.vmethod_55(new Class111());
			this.vmethod_57(new Class116());
			this.vmethod_59(new Class116());
			this.vmethod_61(new Class111());
			this.vmethod_63(new Class116());
			this.vmethod_65(new Class116());
			this.vmethod_67(new Class116());
			this.vmethod_69(new Class116());
			this.vmethod_71(new Class111());
			this.vmethod_73(new Class111());
			this.vmethod_75(new Class115());
			this.vmethod_77(new Class2451());
			this.vmethod_79(new Class116());
			this.vmethod_81(new Class116());
			this.vmethod_83(new Class116());
			this.vmethod_85(new Class116());
			this.vmethod_87(new Class116());
			this.vmethod_89(new Class116());
			this.vmethod_91(new Class116());
			this.vmethod_93(new Class111());
			this.vmethod_95(new Class111());
			this.vmethod_97(new Class111());
			this.vmethod_99(new Class111());
			this.vmethod_101(new Class111());
			this.vmethod_103(new Class111());
			this.vmethod_0().SuspendLayout();
			this.vmethod_2().SuspendLayout();
			this.vmethod_4().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			this.vmethod_10().SuspendLayout();
			this.vmethod_12().SuspendLayout();
			this.vmethod_74().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Controls.Add(this.vmethod_4());
			this.vmethod_0().Controls.Add(this.vmethod_6());
			this.vmethod_0().Controls.Add(this.vmethod_8());
			this.vmethod_0().Controls.Add(this.vmethod_10());
			this.vmethod_0().Controls.Add(this.vmethod_12());
			this.vmethod_0().Location = new Point(0, 315);
			this.vmethod_0().Name = "TabControl_Aircraft";
			this.vmethod_0().SelectedIndex = 0;
			this.vmethod_0().Size = new Size(500, 467);
			this.vmethod_0().TabIndex = 10;
			this.vmethod_2().Controls.Add(this.vmethod_38());
			this.vmethod_2().Location = new Point(4, 22);
			this.vmethod_2().Margin = new Padding(0);
			this.vmethod_2().Name = "TabPage1";
			this.vmethod_2().Size = new Size(492, 441);
			this.vmethod_2().TabIndex = 0;
			this.vmethod_2().Text = "Aircraft #1";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_38().Dock = DockStyle.Fill;
			this.vmethod_38().Location = new Point(0, 0);
			this.vmethod_38().Margin = new Padding(0);
			this.vmethod_38().Name = "FlightPlanWaypoints1";
			this.vmethod_38().Size = new Size(492, 441);
			this.vmethod_38().TabIndex = 0;
			this.vmethod_4().Controls.Add(this.vmethod_42());
			this.vmethod_4().Location = new Point(4, 22);
			this.vmethod_4().Name = "TabPage2";
			this.vmethod_4().Size = new Size(492, 441);
			this.vmethod_4().TabIndex = 1;
			this.vmethod_4().Text = "#2";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_42().Dock = DockStyle.Fill;
			this.vmethod_42().Location = new Point(0, 0);
			this.vmethod_42().Margin = new Padding(0);
			this.vmethod_42().Name = "FlightPlanWaypoints2";
			this.vmethod_42().Size = new Size(492, 441);
			this.vmethod_42().TabIndex = 1;
			this.vmethod_6().Controls.Add(this.vmethod_44());
			this.vmethod_6().Location = new Point(4, 22);
			this.vmethod_6().Name = "TabPage3";
			this.vmethod_6().Size = new Size(492, 441);
			this.vmethod_6().TabIndex = 2;
			this.vmethod_6().Text = "#3";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_44().Dock = DockStyle.Fill;
			this.vmethod_44().Location = new Point(0, 0);
			this.vmethod_44().Margin = new Padding(0);
			this.vmethod_44().Name = "FlightPlanWaypoints3";
			this.vmethod_44().Size = new Size(492, 441);
			this.vmethod_44().TabIndex = 2;
			this.vmethod_8().Controls.Add(this.vmethod_46());
			this.vmethod_8().Location = new Point(4, 22);
			this.vmethod_8().Name = "TabPage4";
			this.vmethod_8().Size = new Size(492, 441);
			this.vmethod_8().TabIndex = 3;
			this.vmethod_8().Text = "#4";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_46().Dock = DockStyle.Fill;
			this.vmethod_46().Location = new Point(0, 0);
			this.vmethod_46().Margin = new Padding(0);
			this.vmethod_46().Name = "FlightPlanWaypoints4";
			this.vmethod_46().Size = new Size(492, 441);
			this.vmethod_46().TabIndex = 2;
			this.vmethod_10().Controls.Add(this.vmethod_48());
			this.vmethod_10().Location = new Point(4, 22);
			this.vmethod_10().Name = "TabPage5";
			this.vmethod_10().Size = new Size(492, 441);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_10().Text = "#5";
			this.vmethod_10().UseVisualStyleBackColor = true;
			this.vmethod_48().Dock = DockStyle.Fill;
			this.vmethod_48().Location = new Point(0, 0);
			this.vmethod_48().Margin = new Padding(0);
			this.vmethod_48().Name = "FlightPlanWaypoints5";
			this.vmethod_48().Size = new Size(492, 441);
			this.vmethod_48().TabIndex = 2;
			this.vmethod_12().Controls.Add(this.vmethod_50());
			this.vmethod_12().Location = new Point(4, 22);
			this.vmethod_12().Name = "TabPage6";
			this.vmethod_12().Size = new Size(492, 441);
			this.vmethod_12().TabIndex = 5;
			this.vmethod_12().Text = "#6";
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_50().Dock = DockStyle.Fill;
			this.vmethod_50().Location = new Point(0, 0);
			this.vmethod_50().Margin = new Padding(0);
			this.vmethod_50().Name = "FlightPlanWaypoints6";
			this.vmethod_50().Size = new Size(492, 441);
			this.vmethod_50().TabIndex = 2;
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new Point(6, 20);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Size = new Size(53, 13);
			this.vmethod_14().TabIndex = 11;
			this.vmethod_14().Text = "Package:";
			this.vmethod_16().AutoSize = true;
			this.vmethod_16().Location = new Point(6, 42);
			this.vmethod_16().Name = "Label2";
			this.vmethod_16().Size = new Size(35, 13);
			this.vmethod_16().TabIndex = 11;
			this.vmethod_16().Text = "Flight:";
			this.vmethod_18().AutoSize = true;
			this.vmethod_18().Location = new Point(2, 77);
			this.vmethod_18().Name = "Label3";
			this.vmethod_18().Size = new Size(46, 13);
			this.vmethod_18().TabIndex = 11;
			this.vmethod_18().Text = "Callsign:";
			this.vmethod_20().AutoSize = true;
			this.vmethod_20().Location = new Point(2, 140);
			this.vmethod_20().Name = "Label4";
			this.vmethod_20().Size = new Size(34, 13);
			this.vmethod_20().TabIndex = 11;
			this.vmethod_20().Text = "Task:";
			this.vmethod_22().FormattingEnabled = true;
			this.vmethod_22().Location = new Point(62, 16);
			this.vmethod_22().Name = "Combo_CurrentPackage";
			this.vmethod_22().Size = new Size(153, 21);
			this.vmethod_22().TabIndex = 12;
			this.vmethod_24().FormattingEnabled = true;
			this.vmethod_24().Location = new Point(62, 38);
			this.vmethod_24().Name = "Combo_CurrentFlightPlan";
			this.vmethod_24().Size = new Size(153, 21);
			this.vmethod_24().TabIndex = 12;
			this.vmethod_26().FormattingEnabled = true;
			this.vmethod_26().Location = new Point(98, 136);
			this.vmethod_26().Name = "Combo_FlightTask";
			this.vmethod_26().Size = new Size(122, 21);
			this.vmethod_26().TabIndex = 12;
			this.vmethod_28().Location = new Point(98, 73);
			this.vmethod_28().Name = "TextBox_FlightCallsign";
			this.vmethod_28().Size = new Size(122, 20);
			this.vmethod_28().TabIndex = 13;
			this.vmethod_30().Location = new Point(358, 52);
			this.vmethod_30().Name = "Button_CopyFlightplan";
			this.vmethod_30().Size = new Size(139, 24);
			this.vmethod_30().TabIndex = 14;
			this.vmethod_30().Text = "Copy Flightplan";
			this.vmethod_30().UseVisualStyleBackColor = true;
			this.vmethod_32().AutoSize = true;
			this.vmethod_32().Location = new Point(98, 203);
			this.vmethod_32().Name = "Label_LaunchDateAndTime";
			this.vmethod_32().Size = new Size(122, 13);
			this.vmethod_32().TabIndex = 16;
			this.vmethod_32().Text = "<Launch date and time>";
			this.vmethod_34().AutoSize = true;
			this.vmethod_34().Location = new Point(2, 161);
			this.vmethod_34().Name = "Label6";
			this.vmethod_34().Size = new Size(43, 13);
			this.vmethod_34().TabIndex = 19;
			this.vmethod_34().Text = "Aircraft:";
			this.vmethod_36().AutoSize = true;
			this.vmethod_36().Location = new Point(2, 182);
			this.vmethod_36().Name = "Label7";
			this.vmethod_36().Size = new Size(49, 13);
			this.vmethod_36().TabIndex = 21;
			this.vmethod_36().Text = "Loadout:";
			this.vmethod_40().AutoSize = true;
			this.vmethod_40().Location = new Point(2, 203);
			this.vmethod_40().Name = "Label5";
			this.vmethod_40().Size = new Size(92, 13);
			this.vmethod_40().TabIndex = 23;
			this.vmethod_40().Text = "Zulu take-off time:";
			this.vmethod_52().Location = new Point(358, 102);
			this.vmethod_52().Name = "Button_FillEmptySlots";
			this.vmethod_52().Size = new Size(139, 24);
			this.vmethod_52().TabIndex = 24;
			this.vmethod_52().Text = "Fill Empty a/c Slots";
			this.vmethod_52().UseVisualStyleBackColor = true;
			this.vmethod_54().Location = new Point(358, 77);
			this.vmethod_54().Name = "Button_ClearSlots";
			this.vmethod_54().Size = new Size(139, 24);
			this.vmethod_54().TabIndex = 25;
			this.vmethod_54().Text = "Clear a/c Slots";
			this.vmethod_54().UseVisualStyleBackColor = true;
			this.vmethod_56().AutoSize = true;
			this.vmethod_56().Location = new Point(98, 161);
			this.vmethod_56().Name = "Label_AircraftType";
			this.vmethod_56().Size = new Size(75, 13);
			this.vmethod_56().TabIndex = 26;
			this.vmethod_56().Text = "<Aircraft type>";
			this.vmethod_58().AutoSize = true;
			this.vmethod_58().Location = new Point(98, 182);
			this.vmethod_58().Name = "Label_LoadoutName";
			this.vmethod_58().Size = new Size(87, 13);
			this.vmethod_58().TabIndex = 27;
			this.vmethod_58().Text = "<Loadout name>";
			this.vmethod_60().Enabled = false;
			this.vmethod_60().Location = new Point(358, 162);
			this.vmethod_60().Name = "Button_ChangeAircraftType";
			this.vmethod_60().Size = new Size(139, 42);
			this.vmethod_60().TabIndex = 28;
			this.vmethod_60().Text = "Change a/c type and loadout";
			this.vmethod_60().UseVisualStyleBackColor = true;
			this.vmethod_62().AutoSize = true;
			this.vmethod_62().Location = new Point(2, 224);
			this.vmethod_62().Name = "Label8";
			this.vmethod_62().Size = new Size(99, 13);
			this.vmethod_62().TabIndex = 30;
			this.vmethod_62().Text = "Zulu objective time:";
			this.vmethod_64().AutoSize = true;
			this.vmethod_64().Location = new Point(98, 224);
			this.vmethod_64().Name = "Label_ObjectiveDateAndTime";
			this.vmethod_64().Size = new Size(117, 13);
			this.vmethod_64().TabIndex = 29;
			this.vmethod_64().Text = "<Target date and time>";
			this.vmethod_66().AutoSize = true;
			this.vmethod_66().Location = new Point(2, 119);
			this.vmethod_66().Name = "Label10";
			this.vmethod_66().Size = new Size(40, 13);
			this.vmethod_66().TabIndex = 32;
			this.vmethod_66().Text = "Status:";
			this.vmethod_68().AutoSize = true;
			this.vmethod_68().Location = new Point(98, 119);
			this.vmethod_68().Name = "Label_FlightStatus";
			this.vmethod_68().Size = new Size(75, 13);
			this.vmethod_68().TabIndex = 31;
			this.vmethod_68().Text = "<Flight status>";
			this.vmethod_70().Enabled = false;
			this.vmethod_70().Location = new Point(358, 2);
			this.vmethod_70().Name = "Button_CreateFlightplanSkeleton";
			this.vmethod_70().Size = new Size(139, 24);
			this.vmethod_70().TabIndex = 33;
			this.vmethod_70().Text = "Create Flightplan";
			this.vmethod_70().UseVisualStyleBackColor = true;
			this.vmethod_72().Enabled = false;
			this.vmethod_72().Location = new Point(358, 27);
			this.vmethod_72().Name = "Button_DeleteFlightplan";
			this.vmethod_72().Size = new Size(139, 24);
			this.vmethod_72().TabIndex = 34;
			this.vmethod_72().Text = "Delete Flightplan";
			this.vmethod_72().UseVisualStyleBackColor = true;
			this.vmethod_74().Controls.Add(this.vmethod_24());
			this.vmethod_74().Controls.Add(this.vmethod_14());
			this.vmethod_74().Controls.Add(this.vmethod_16());
			this.vmethod_74().Controls.Add(this.vmethod_22());
			this.vmethod_74().Location = new Point(5, 2);
			this.vmethod_74().Name = "GroupBox_SelectedFlight";
			this.vmethod_74().Size = new Size(225, 68);
			this.vmethod_74().TabIndex = 35;
			this.vmethod_74().TabStop = false;
			this.vmethod_74().Text = "Selected Flight";
			this.vmethod_76().FormattingEnabled = true;
			this.vmethod_76().Location = new Point(98, 94);
			this.vmethod_76().Name = "Combo_FlightplanType";
			this.vmethod_76().Size = new Size(122, 21);
			this.vmethod_76().TabIndex = 37;
			this.vmethod_78().AutoSize = true;
			this.vmethod_78().Location = new Point(2, 98);
			this.vmethod_78().Name = "Label9";
			this.vmethod_78().Size = new Size(34, 13);
			this.vmethod_78().TabIndex = 36;
			this.vmethod_78().Text = "Type:";
			this.vmethod_80().AutoSize = true;
			this.vmethod_80().Location = new Point(2, 266);
			this.vmethod_80().Name = "Label11";
			this.vmethod_80().Size = new Size(88, 13);
			this.vmethod_80().TabIndex = 41;
			this.vmethod_80().Text = "Landing location:";
			this.vmethod_82().AutoSize = true;
			this.vmethod_82().Location = new Point(98, 266);
			this.vmethod_82().Name = "Label1_LandingLocation";
			this.vmethod_82().Size = new Size(97, 13);
			this.vmethod_82().TabIndex = 40;
			this.vmethod_82().Text = "<Landing location>";
			this.vmethod_84().AutoSize = true;
			this.vmethod_84().Location = new Point(2, 245);
			this.vmethod_84().Name = "Label13";
			this.vmethod_84().Size = new Size(90, 13);
			this.vmethod_84().TabIndex = 39;
			this.vmethod_84().Text = "Take-off location:";
			this.vmethod_86().AutoSize = true;
			this.vmethod_86().Location = new Point(98, 245);
			this.vmethod_86().Name = "Label_TakeOffLocation";
			this.vmethod_86().Size = new Size(99, 13);
			this.vmethod_86().TabIndex = 38;
			this.vmethod_86().Text = "<Take-off location>";
			this.vmethod_88().AutoSize = true;
			this.vmethod_88().Location = new Point(2, 287);
			this.vmethod_88().Name = "Label15";
			this.vmethod_88().Size = new Size(94, 13);
			this.vmethod_88().TabIndex = 43;
			this.vmethod_88().Text = "Diversion location:";
			this.vmethod_90().AutoSize = true;
			this.vmethod_90().Location = new Point(98, 287);
			this.vmethod_90().Name = "Label_DiversionAirfield";
			this.vmethod_90().Size = new Size(103, 13);
			this.vmethod_90().TabIndex = 42;
			this.vmethod_90().Text = "<Diversion location>";
			this.vmethod_92().Location = new Point(358, 204);
			this.vmethod_92().Name = "Button_ChangeTakeOffTime";
			this.vmethod_92().Size = new Size(139, 21);
			this.vmethod_92().TabIndex = 44;
			this.vmethod_92().Text = "Change take-off time";
			this.vmethod_92().UseVisualStyleBackColor = true;
			this.vmethod_94().Location = new Point(358, 225);
			this.vmethod_94().Name = "Button_ChangeObjectiveTime";
			this.vmethod_94().Size = new Size(139, 21);
			this.vmethod_94().TabIndex = 45;
			this.vmethod_94().Text = "Change objective time";
			this.vmethod_94().UseVisualStyleBackColor = true;
			this.vmethod_96().Location = new Point(358, 246);
			this.vmethod_96().Name = "Button_ChangeTakeOffLocation";
			this.vmethod_96().Size = new Size(139, 21);
			this.vmethod_96().TabIndex = 46;
			this.vmethod_96().Text = "Change take-off location";
			this.vmethod_96().UseVisualStyleBackColor = true;
			this.vmethod_98().Location = new Point(358, 267);
			this.vmethod_98().Name = "Button_ChangeLandingLocation";
			this.vmethod_98().Size = new Size(139, 21);
			this.vmethod_98().TabIndex = 47;
			this.vmethod_98().Text = "Change landing location";
			this.vmethod_98().UseVisualStyleBackColor = true;
			this.vmethod_100().Location = new Point(358, 288);
			this.vmethod_100().Name = "Button_ChangeDiversionLocation";
			this.vmethod_100().Size = new Size(139, 21);
			this.vmethod_100().TabIndex = 48;
			this.vmethod_100().Text = "Change diversion location";
			this.vmethod_100().UseVisualStyleBackColor = true;
			this.vmethod_102().Enabled = false;
			this.vmethod_102().Location = new Point(226, 27);
			this.vmethod_102().Name = "Button_CreateFlightplanFull";
			this.vmethod_102().Size = new Size(139, 24);
			this.vmethod_102().TabIndex = 33;
			this.vmethod_102().Text = "Create Full Flightplan";
			this.vmethod_102().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(499, 782);
			base.Controls.Add(this.vmethod_100());
			base.Controls.Add(this.vmethod_98());
			base.Controls.Add(this.vmethod_96());
			base.Controls.Add(this.vmethod_94());
			base.Controls.Add(this.vmethod_92());
			base.Controls.Add(this.vmethod_60());
			base.Controls.Add(this.vmethod_76());
			base.Controls.Add(this.vmethod_78());
			base.Controls.Add(this.vmethod_68());
			base.Controls.Add(this.vmethod_74());
			base.Controls.Add(this.vmethod_72());
			base.Controls.Add(this.vmethod_102());
			base.Controls.Add(this.vmethod_70());
			base.Controls.Add(this.vmethod_66());
			base.Controls.Add(this.vmethod_54());
			base.Controls.Add(this.vmethod_52());
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_88());
			base.Controls.Add(this.vmethod_90());
			base.Controls.Add(this.vmethod_80());
			base.Controls.Add(this.vmethod_82());
			base.Controls.Add(this.vmethod_84());
			base.Controls.Add(this.vmethod_86());
			base.Controls.Add(this.vmethod_62());
			base.Controls.Add(this.vmethod_64());
			base.Controls.Add(this.vmethod_58());
			base.Controls.Add(this.vmethod_56());
			base.Controls.Add(this.vmethod_40());
			base.Controls.Add(this.vmethod_36());
			base.Controls.Add(this.vmethod_34());
			base.Controls.Add(this.vmethod_32());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new Size(515, 730);
			base.Name = "FlightPlanEditor";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Flightplan Editor for flight <Flight Name>";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_10().ResumeLayout(false);
			this.vmethod_12().ResumeLayout(false);
			this.vmethod_74().ResumeLayout(false);
			this.vmethod_74().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x00043705 File Offset: 0x00041905
		[CompilerGenerated]
		internal Control12 vmethod_0()
		{
			return this.control12_0;
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x0039ED50 File Offset: 0x0039CF50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control12 control12_1)
		{
			EventHandler value = new EventHandler(this.method_21);
			Control12 control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged -= value;
			}
			this.control12_0 = control12_1;
			control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x0004370D File Offset: 0x0004190D
		[CompilerGenerated]
		internal TabPage vmethod_2()
		{
			return this.tabPage_0;
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x00043715 File Offset: 0x00041915
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TabPage tabPage_12)
		{
			this.tabPage_0 = tabPage_12;
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x0004371E File Offset: 0x0004191E
		[CompilerGenerated]
		internal TabPage vmethod_4()
		{
			return this.tabPage_1;
		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x00043726 File Offset: 0x00041926
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabPage tabPage_12)
		{
			this.tabPage_1 = tabPage_12;
		}

		// Token: 0x06006A8E RID: 27278 RVA: 0x0004372F File Offset: 0x0004192F
		[CompilerGenerated]
		internal TabPage vmethod_6()
		{
			return this.tabPage_2;
		}

		// Token: 0x06006A8F RID: 27279 RVA: 0x00043737 File Offset: 0x00041937
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TabPage tabPage_12)
		{
			this.tabPage_2 = tabPage_12;
		}

		// Token: 0x06006A90 RID: 27280 RVA: 0x00043740 File Offset: 0x00041940
		[CompilerGenerated]
		internal TabPage vmethod_8()
		{
			return this.tabPage_3;
		}

		// Token: 0x06006A91 RID: 27281 RVA: 0x00043748 File Offset: 0x00041948
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TabPage tabPage_12)
		{
			this.tabPage_3 = tabPage_12;
		}

		// Token: 0x06006A92 RID: 27282 RVA: 0x00043751 File Offset: 0x00041951
		[CompilerGenerated]
		internal TabPage vmethod_10()
		{
			return this.tabPage_4;
		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x00043759 File Offset: 0x00041959
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TabPage tabPage_12)
		{
			this.tabPage_4 = tabPage_12;
		}

		// Token: 0x06006A94 RID: 27284 RVA: 0x00043762 File Offset: 0x00041962
		[CompilerGenerated]
		internal TabPage vmethod_12()
		{
			return this.tabPage_5;
		}

		// Token: 0x06006A95 RID: 27285 RVA: 0x0004376A File Offset: 0x0004196A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(TabPage tabPage_12)
		{
			this.tabPage_5 = tabPage_12;
		}

		// Token: 0x06006A96 RID: 27286 RVA: 0x00043773 File Offset: 0x00041973
		[CompilerGenerated]
		internal Label vmethod_14()
		{
			return this.label_0;
		}

		// Token: 0x06006A97 RID: 27287 RVA: 0x0004377B File Offset: 0x0004197B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_21)
		{
			this.label_0 = label_21;
		}

		// Token: 0x06006A98 RID: 27288 RVA: 0x00043784 File Offset: 0x00041984
		[CompilerGenerated]
		internal Label vmethod_16()
		{
			return this.label_1;
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x0004378C File Offset: 0x0004198C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_21)
		{
			this.label_1 = label_21;
		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x00043795 File Offset: 0x00041995
		[CompilerGenerated]
		internal Label vmethod_18()
		{
			return this.label_2;
		}

		// Token: 0x06006A9B RID: 27291 RVA: 0x0004379D File Offset: 0x0004199D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_21)
		{
			this.label_2 = label_21;
		}

		// Token: 0x06006A9C RID: 27292 RVA: 0x000437A6 File Offset: 0x000419A6
		[CompilerGenerated]
		internal Label vmethod_20()
		{
			return this.label_3;
		}

		// Token: 0x06006A9D RID: 27293 RVA: 0x000437AE File Offset: 0x000419AE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Label label_21)
		{
			this.label_3 = label_21;
		}

		// Token: 0x06006A9E RID: 27294 RVA: 0x000437B7 File Offset: 0x000419B7
		[CompilerGenerated]
		internal Class2451 vmethod_22()
		{
			return this.class2451_0;
		}

		// Token: 0x06006A9F RID: 27295 RVA: 0x0039ED94 File Offset: 0x0039CF94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_18);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_4;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06006AA0 RID: 27296 RVA: 0x000437BF File Offset: 0x000419BF
		[CompilerGenerated]
		internal Class2451 vmethod_24()
		{
			return this.class2451_1;
		}

		// Token: 0x06006AA1 RID: 27297 RVA: 0x0039EDD8 File Offset: 0x0039CFD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_19);
			Class2451 @class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_1 = class2451_4;
			@class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06006AA2 RID: 27298 RVA: 0x000437C7 File Offset: 0x000419C7
		[CompilerGenerated]
		internal Class2451 vmethod_26()
		{
			return this.class2451_2;
		}

		// Token: 0x06006AA3 RID: 27299 RVA: 0x0039EE1C File Offset: 0x0039D01C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_20);
			Class2451 @class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_2 = class2451_4;
			@class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06006AA4 RID: 27300 RVA: 0x000437CF File Offset: 0x000419CF
		[CompilerGenerated]
		internal Control8 vmethod_28()
		{
			return this.control8_0;
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x0039EE60 File Offset: 0x0039D060
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Control8 control8_1)
		{
			KeyPressEventHandler value = new KeyPressEventHandler(this.method_22);
			EventHandler value2 = new EventHandler(this.method_23);
			EventHandler value3 = new EventHandler(this.method_24);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.KeyPress -= value;
				control.Enter -= value2;
				control.Leave -= value3;
			}
			this.control8_0 = control8_1;
			control = this.control8_0;
			if (control != null)
			{
				control.KeyPress += value;
				control.Enter += value2;
				control.Leave += value3;
			}
		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x000437D7 File Offset: 0x000419D7
		[CompilerGenerated]
		internal Button vmethod_30()
		{
			return this.button_0;
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x0039EEDC File Offset: 0x0039D0DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Button button_12)
		{
			EventHandler value = new EventHandler(this.method_14);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_12;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x000437DF File Offset: 0x000419DF
		[CompilerGenerated]
		internal Label vmethod_32()
		{
			return this.label_4;
		}

		// Token: 0x06006AA9 RID: 27305 RVA: 0x000437E7 File Offset: 0x000419E7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Label label_21)
		{
			this.label_4 = label_21;
		}

		// Token: 0x06006AAA RID: 27306 RVA: 0x000437F0 File Offset: 0x000419F0
		[CompilerGenerated]
		internal Label vmethod_34()
		{
			return this.label_5;
		}

		// Token: 0x06006AAB RID: 27307 RVA: 0x000437F8 File Offset: 0x000419F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Label label_21)
		{
			this.label_5 = label_21;
		}

		// Token: 0x06006AAC RID: 27308 RVA: 0x00043801 File Offset: 0x00041A01
		[CompilerGenerated]
		internal Label vmethod_36()
		{
			return this.label_6;
		}

		// Token: 0x06006AAD RID: 27309 RVA: 0x00043809 File Offset: 0x00041A09
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Label label_21)
		{
			this.label_6 = label_21;
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x00043812 File Offset: 0x00041A12
		[CompilerGenerated]
		internal FlightPlanWaypoints vmethod_38()
		{
			return this.flightPlanWaypoints_0;
		}

		// Token: 0x06006AAF RID: 27311 RVA: 0x0004381A File Offset: 0x00041A1A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(FlightPlanWaypoints flightPlanWaypoints_7)
		{
			this.flightPlanWaypoints_0 = flightPlanWaypoints_7;
		}

		// Token: 0x06006AB0 RID: 27312 RVA: 0x00043823 File Offset: 0x00041A23
		[CompilerGenerated]
		internal Label vmethod_40()
		{
			return this.label_7;
		}

		// Token: 0x06006AB1 RID: 27313 RVA: 0x0004382B File Offset: 0x00041A2B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Label label_21)
		{
			this.label_7 = label_21;
		}

		// Token: 0x06006AB2 RID: 27314 RVA: 0x00043834 File Offset: 0x00041A34
		[CompilerGenerated]
		internal FlightPlanWaypoints vmethod_42()
		{
			return this.flightPlanWaypoints_1;
		}

		// Token: 0x06006AB3 RID: 27315 RVA: 0x0004383C File Offset: 0x00041A3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(FlightPlanWaypoints flightPlanWaypoints_7)
		{
			this.flightPlanWaypoints_1 = flightPlanWaypoints_7;
		}

		// Token: 0x06006AB4 RID: 27316 RVA: 0x00043845 File Offset: 0x00041A45
		[CompilerGenerated]
		internal FlightPlanWaypoints vmethod_44()
		{
			return this.flightPlanWaypoints_2;
		}

		// Token: 0x06006AB5 RID: 27317 RVA: 0x0004384D File Offset: 0x00041A4D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(FlightPlanWaypoints flightPlanWaypoints_7)
		{
			this.flightPlanWaypoints_2 = flightPlanWaypoints_7;
		}

		// Token: 0x06006AB6 RID: 27318 RVA: 0x00043856 File Offset: 0x00041A56
		[CompilerGenerated]
		internal FlightPlanWaypoints vmethod_46()
		{
			return this.flightPlanWaypoints_3;
		}

		// Token: 0x06006AB7 RID: 27319 RVA: 0x0004385E File Offset: 0x00041A5E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(FlightPlanWaypoints flightPlanWaypoints_7)
		{
			this.flightPlanWaypoints_3 = flightPlanWaypoints_7;
		}

		// Token: 0x06006AB8 RID: 27320 RVA: 0x00043867 File Offset: 0x00041A67
		[CompilerGenerated]
		internal FlightPlanWaypoints vmethod_48()
		{
			return this.flightPlanWaypoints_4;
		}

		// Token: 0x06006AB9 RID: 27321 RVA: 0x0004386F File Offset: 0x00041A6F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(FlightPlanWaypoints flightPlanWaypoints_7)
		{
			this.flightPlanWaypoints_4 = flightPlanWaypoints_7;
		}

		// Token: 0x06006ABA RID: 27322 RVA: 0x00043878 File Offset: 0x00041A78
		[CompilerGenerated]
		internal FlightPlanWaypoints vmethod_50()
		{
			return this.flightPlanWaypoints_5;
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x00043880 File Offset: 0x00041A80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(FlightPlanWaypoints flightPlanWaypoints_7)
		{
			this.flightPlanWaypoints_5 = flightPlanWaypoints_7;
		}

		// Token: 0x06006ABC RID: 27324 RVA: 0x00043889 File Offset: 0x00041A89
		[CompilerGenerated]
		internal Button vmethod_52()
		{
			return this.button_1;
		}

		// Token: 0x06006ABD RID: 27325 RVA: 0x0039EF20 File Offset: 0x0039D120
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Button button_12)
		{
			EventHandler value = new EventHandler(this.method_16);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_12;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006ABE RID: 27326 RVA: 0x00043891 File Offset: 0x00041A91
		[CompilerGenerated]
		internal Button vmethod_54()
		{
			return this.button_2;
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x0039EF64 File Offset: 0x0039D164
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Button button_12)
		{
			EventHandler value = new EventHandler(this.method_15);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_12;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006AC0 RID: 27328 RVA: 0x00043899 File Offset: 0x00041A99
		[CompilerGenerated]
		internal Label vmethod_56()
		{
			return this.label_8;
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x000438A1 File Offset: 0x00041AA1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(Label label_21)
		{
			this.label_8 = label_21;
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x000438AA File Offset: 0x00041AAA
		[CompilerGenerated]
		internal Label vmethod_58()
		{
			return this.label_9;
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x000438B2 File Offset: 0x00041AB2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(Label label_21)
		{
			this.label_9 = label_21;
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x000438BB File Offset: 0x00041ABB
		[CompilerGenerated]
		internal Button vmethod_60()
		{
			return this.button_3;
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x0039EFA8 File Offset: 0x0039D1A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(Button button_12)
		{
			EventHandler value = new EventHandler(this.method_17);
			Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_12;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x000438C3 File Offset: 0x00041AC3
		[CompilerGenerated]
		internal Label vmethod_62()
		{
			return this.label_10;
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x000438CB File Offset: 0x00041ACB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(Label label_21)
		{
			this.label_10 = label_21;
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x000438D4 File Offset: 0x00041AD4
		[CompilerGenerated]
		internal Label vmethod_64()
		{
			return this.label_11;
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x000438DC File Offset: 0x00041ADC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Label label_21)
		{
			this.label_11 = label_21;
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x000438E5 File Offset: 0x00041AE5
		[CompilerGenerated]
		internal Label vmethod_66()
		{
			return this.label_12;
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x000438ED File Offset: 0x00041AED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(Label label_21)
		{
			this.label_12 = label_21;
		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x000438F6 File Offset: 0x00041AF6
		[CompilerGenerated]
		internal Label vmethod_68()
		{
			return this.label_13;
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x000438FE File Offset: 0x00041AFE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(Label label_21)
		{
			this.label_13 = label_21;
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x00043907 File Offset: 0x00041B07
		[CompilerGenerated]
		internal Button vmethod_70()
		{
			return this.button_4;
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x0039EFEC File Offset: 0x0039D1EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(Button button_12)
		{
			EventHandler value = new EventHandler(this.method_26);
			Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_12;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x0004390F File Offset: 0x00041B0F
		[CompilerGenerated]
		internal Button vmethod_72()
		{
			return this.button_5;
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x0039F030 File Offset: 0x0039D230
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(Button button_12)
		{
			EventHandler value = new EventHandler(this.method_27);
			Button button = this.button_5;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_5 = button_12;
			button = this.button_5;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x00043917 File Offset: 0x00041B17
		[CompilerGenerated]
		internal GroupBox vmethod_74()
		{
			return this.groupBox_0;
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x0004391F File Offset: 0x00041B1F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(GroupBox groupBox_1)
		{
			this.groupBox_0 = groupBox_1;
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x00043928 File Offset: 0x00041B28
		[CompilerGenerated]
		internal Class2451 vmethod_76()
		{
			return this.class2451_3;
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x0039F074 File Offset: 0x0039D274
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_28);
			Class2451 @class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_3 = class2451_4;
			@class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x00043930 File Offset: 0x00041B30
		[CompilerGenerated]
		internal Label vmethod_78()
		{
			return this.label_14;
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x00043938 File Offset: 0x00041B38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(Label label_21)
		{
			this.label_14 = label_21;
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x00043941 File Offset: 0x00041B41
		[CompilerGenerated]
		internal Label vmethod_80()
		{
			return this.label_15;
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x00043949 File Offset: 0x00041B49
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(Label label_21)
		{
			this.label_15 = label_21;
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x00043952 File Offset: 0x00041B52
		[CompilerGenerated]
		internal Label vmethod_82()
		{
			return this.label_16;
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x0004395A File Offset: 0x00041B5A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(Label label_21)
		{
			this.label_16 = label_21;
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x00043963 File Offset: 0x00041B63
		[CompilerGenerated]
		internal Label vmethod_84()
		{
			return this.label_17;
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x0004396B File Offset: 0x00041B6B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(Label label_21)
		{
			this.label_17 = label_21;
		}

		// Token: 0x06006ADE RID: 27358 RVA: 0x00043974 File Offset: 0x00041B74
		[CompilerGenerated]
		internal Label vmethod_86()
		{
			return this.label_18;
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x0004397C File Offset: 0x00041B7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(Label label_21)
		{
			this.label_18 = label_21;
		}

		// Token: 0x06006AE0 RID: 27360 RVA: 0x00043985 File Offset: 0x00041B85
		[CompilerGenerated]
		internal Label vmethod_88()
		{
			return this.label_19;
		}

		// Token: 0x06006AE1 RID: 27361 RVA: 0x0004398D File Offset: 0x00041B8D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(Label label_21)
		{
			this.label_19 = label_21;
		}

		// Token: 0x06006AE2 RID: 27362 RVA: 0x00043996 File Offset: 0x00041B96
		[CompilerGenerated]
		internal Label vmethod_90()
		{
			return this.label_20;
		}

		// Token: 0x06006AE3 RID: 27363 RVA: 0x0004399E File Offset: 0x00041B9E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(Label label_21)
		{
			this.label_20 = label_21;
		}

		// Token: 0x06006AE4 RID: 27364 RVA: 0x000439A7 File Offset: 0x00041BA7
		[CompilerGenerated]
		internal Button vmethod_92()
		{
			return this.button_6;
		}

		// Token: 0x06006AE5 RID: 27365 RVA: 0x0039F0B8 File Offset: 0x0039D2B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(Button button_12)
		{
			EventHandler value = new EventHandler(this.method_29);
			Button button = this.button_6;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_6 = button_12;
			button = this.button_6;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006AE6 RID: 27366 RVA: 0x000439AF File Offset: 0x00041BAF
		[CompilerGenerated]
		internal Button vmethod_94()
		{
			return this.button_7;
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x0039F0FC File Offset: 0x0039D2FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(Button button_12)
		{
			EventHandler value = new EventHandler(this.method_30);
			Button button = this.button_7;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_7 = button_12;
			button = this.button_7;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x000439B7 File Offset: 0x00041BB7
		[CompilerGenerated]
		internal Button vmethod_96()
		{
			return this.button_8;
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x0039F140 File Offset: 0x0039D340
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(Button button_12)
		{
			EventHandler value = new EventHandler(this.method_31);
			Button button = this.button_8;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_8 = button_12;
			button = this.button_8;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x000439BF File Offset: 0x00041BBF
		[CompilerGenerated]
		internal Button vmethod_98()
		{
			return this.button_9;
		}

		// Token: 0x06006AEB RID: 27371 RVA: 0x0039F184 File Offset: 0x0039D384
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_99(Button button_12)
		{
			EventHandler value = new EventHandler(this.method_32);
			Button button = this.button_9;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_9 = button_12;
			button = this.button_9;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x000439C7 File Offset: 0x00041BC7
		[CompilerGenerated]
		internal Button vmethod_100()
		{
			return this.button_10;
		}

		// Token: 0x06006AED RID: 27373 RVA: 0x0039F1C8 File Offset: 0x0039D3C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_101(Button button_12)
		{
			EventHandler value = new EventHandler(this.method_33);
			Button button = this.button_10;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_10 = button_12;
			button = this.button_10;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006AEE RID: 27374 RVA: 0x000439CF File Offset: 0x00041BCF
		[CompilerGenerated]
		internal Button vmethod_102()
		{
			return this.button_11;
		}

		// Token: 0x06006AEF RID: 27375 RVA: 0x0039F20C File Offset: 0x0039D40C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_103(Button button_12)
		{
			EventHandler value = new EventHandler(this.method_36);
			Button button = this.button_11;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_11 = button_12;
			button = this.button_11;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x000439D7 File Offset: 0x00041BD7
		private void method_3(Class310 class310_0, bool? nullable_0, bool bool_5, bool bool_6, bool bool_7, bool bool_8)
		{
			if (!Information.IsNothing(class310_0) && class310_0.GetType() == typeof(Waypoint) && base.Visible && !bool_7 && (bool_6 || bool_8))
			{
				this.method_13();
			}
		}

		// Token: 0x06006AF1 RID: 27377 RVA: 0x000439D7 File Offset: 0x00041BD7
		private void method_4(Class310 class310_0, bool? nullable_0, bool bool_5, bool bool_6, bool bool_7, bool bool_8)
		{
			if (!Information.IsNothing(class310_0) && class310_0.GetType() == typeof(Waypoint) && base.Visible && !bool_7 && (bool_6 || bool_8))
			{
				this.method_13();
			}
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x00042F6B File Offset: 0x0004116B
		private void FlightPlanEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06006AF3 RID: 27379 RVA: 0x00043A0D File Offset: 0x00041C0D
		private void FlightPlanEditor_FormClosed(object sender, FormClosedEventArgs e)
		{
			Doctrine.smethod_1(new Doctrine.Delegate28(this.method_3));
			Doctrine.smethod_3(new Doctrine.Delegate29(this.method_4));
			MissionEditor.smethod_1(new MissionEditor.Delegate95(this.method_7));
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x00043A42 File Offset: 0x00041C42
		private void FlightPlanEditor_Load(object sender, EventArgs e)
		{
			Doctrine.smethod_0(new Doctrine.Delegate28(this.method_3));
			Doctrine.smethod_2(new Doctrine.Delegate29(this.method_4));
			MissionEditor.smethod_0(new MissionEditor.Delegate95(this.method_7));
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x00043A77 File Offset: 0x00041C77
		private void FlightPlanEditor_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.method_5();
			}
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06006AF6 RID: 27382 RVA: 0x0039F250 File Offset: 0x0039D450
		public void method_5()
		{
			this.method_12();
			this.method_9(false);
			if (Client.flightPlanTime_0.Visible && Client.flightPlanTime_0.bool_3)
			{
				Client.flightPlanTime_0.method_4(ref Client.smethod_32().mission_0, ref Client.smethod_32().flight_0, ref Client.smethod_32().waypoint_0, Client.smethod_32().flightPlanWaypoints_6.enum106_0, true);
			}
		}

		// Token: 0x06006AF7 RID: 27383 RVA: 0x00043A9C File Offset: 0x00041C9C
		public void method_6()
		{
			this.method_5();
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06006AF8 RID: 27384 RVA: 0x0039F2BC File Offset: 0x0039D4BC
		private void method_7(Class310 class310_0)
		{
			try
			{
				if (!Information.IsNothing(class310_0))
				{
					this.method_12();
					this.method_9(false);
					if (Client.flightPlanTime_0.Visible && Client.flightPlanTime_0.bool_3)
					{
						Client.flightPlanTime_0.method_4(ref Client.smethod_32().mission_0, ref Client.smethod_32().flight_0, ref Client.smethod_32().waypoint_0, Client.smethod_32().flightPlanWaypoints_6.enum106_0, true);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200630", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x0039F37C File Offset: 0x0039D57C
		private string method_8(ref ActiveUnit.Throttle throttle_0)
		{
			string result;
			switch (throttle_0)
			{
			case ActiveUnit.Throttle.FullStop:
				result = "Full Stop";
				break;
			case ActiveUnit.Throttle.Loiter:
				result = "Loiter";
				break;
			case ActiveUnit.Throttle.Cruise:
				result = "Cruise";
				break;
			case ActiveUnit.Throttle.Full:
				result = "Military";
				break;
			case ActiveUnit.Throttle.Flank:
				result = "Afterburner";
				break;
			default:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = throttle_0.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x0039F3E8 File Offset: 0x0039D5E8
		internal void method_9(bool bool_5)
		{
			try
			{
				this.vmethod_22().Items.Clear();
				int num = 0;
				try
				{
					foreach (Mission mission in Client.smethod_50().method_35())
					{
						if (mission.enum88_0 != Mission.Enum88.const_2)
						{
							this.vmethod_22().Items.Insert(num, mission.Name);
							if (mission == this.mission_0)
							{
								this.vmethod_22().SelectedIndex = num;
							}
							num++;
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
				this.vmethod_24().Items.Clear();
				num = 0;
				try
				{
					foreach (Mission.Flight flight in this.mission_0.list_1)
					{
						this.vmethod_24().Items.Insert(num, flight.string_4);
						if (!Information.IsNothing(this.flight_0))
						{
							if (flight == this.flight_0)
							{
								this.vmethod_24().SelectedIndex = num;
							}
							num++;
						}
					}
				}
				finally
				{
					List<Mission.Flight>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				if (Information.IsNothing(this.flight_0))
				{
					this.vmethod_24().SelectedIndex = -1;
					this.vmethod_24().Text = "";
					this.vmethod_28().Text = "";
				}
				else
				{
					this.vmethod_28().Text = this.flight_0.string_4;
				}
				if (Information.IsNothing(this.flight_0))
				{
					this.vmethod_26().DataSource = null;
					this.vmethod_26().Items.Clear();
					this.vmethod_26().SelectedIndex = -1;
					this.vmethod_76().DataSource = null;
					this.vmethod_76().Items.Clear();
					this.vmethod_76().SelectedIndex = -1;
				}
				else
				{
					DataTable dataSource = new DataTable();
					Mission.Flight.smethod_4(ref dataSource);
					Class2451 @class = this.vmethod_26();
					@class.DataSource = dataSource;
					@class.DisplayMember = "Description";
					@class.ValueMember = "ID";
					@class.DropDownWidth = 500;
					this.vmethod_26().SelectedIndex = Mission.Flight.smethod_6((int)this.flight_0._FlightTask_0);
					DataTable dataSource2 = new DataTable();
					Mission.Flight.smethod_14(ref dataSource2);
					Class2451 class2 = this.vmethod_76();
					class2.DataSource = dataSource2;
					class2.DisplayMember = "Description";
					class2.ValueMember = "ID";
					class2.DropDownWidth = 500;
					this.vmethod_76().SelectedIndex = Mission.Flight.smethod_16((int)this.flight_0.enum93_0);
				}
				this.method_10();
				if (bool_5)
				{
					this.vmethod_56().Text = this.flight_0.string_12;
					this.vmethod_58().Text = this.flight_0.method_13(Client.smethod_46());
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

		// Token: 0x06006AFB RID: 27387 RVA: 0x0039F714 File Offset: 0x0039D914
		private void method_10()
		{
			checked
			{
				try
				{
					if (Information.IsNothing(this.flight_0))
					{
						this.vmethod_72().Enabled = false;
						this.vmethod_70().Enabled = false;
						this.vmethod_102().Enabled = false;
						this.vmethod_30().Enabled = false;
						this.vmethod_54().Enabled = false;
						this.vmethod_52().Enabled = false;
						this.vmethod_60().Enabled = false;
						this.vmethod_92().Enabled = false;
						this.vmethod_94().Enabled = false;
						this.vmethod_96().Enabled = false;
						this.vmethod_98().Enabled = false;
						this.vmethod_100().Enabled = false;
					}
					else
					{
						this.vmethod_76().Enabled = false;
						if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
						{
							this.vmethod_76().Enabled = true;
						}
						else
						{
							this.vmethod_76().Enabled = false;
						}
						if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
						{
							if (Enumerable.Count<Waypoint>(this.flight_0.method_15()) > 0)
							{
								this.vmethod_70().Enabled = false;
								this.vmethod_102().Enabled = false;
							}
							else
							{
								this.vmethod_70().Enabled = true;
								this.vmethod_102().Enabled = true;
							}
						}
						else
						{
							this.vmethod_70().Enabled = false;
							this.vmethod_102().Enabled = false;
						}
						if (Enumerable.Count<Waypoint>(this.flight_0.method_15()) > 0)
						{
							this.vmethod_72().Enabled = true;
						}
						else
						{
							this.vmethod_72().Enabled = false;
						}
						this.vmethod_30().Enabled = true;
						if (this.flight_0.enum93_0 == Mission.Enum93.const_0)
						{
							if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
							{
								this.vmethod_54().Enabled = false;
								try
								{
									foreach (ActiveUnit activeUnit in this.mission_0.method_15(Client.smethod_46()))
									{
										if (activeUnit.vmethod_85().method_48() && activeUnit.vmethod_85().method_7() == this.flight_0)
										{
											this.vmethod_54().Enabled = true;
											break;
										}
									}
								}
								finally
								{
									List<ActiveUnit>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
								this.vmethod_52().Enabled = false;
								if (Information.IsNothing(this.mission_0.list_2))
								{
									goto IL_2CD;
								}
								try
								{
									List<Mission.EmptyAircraftSlot>.Enumerator enumerator2 = this.mission_0.list_2.GetEnumerator();
									while (enumerator2.MoveNext())
									{
										if (Operators.CompareString(enumerator2.Current.string_2, this.flight_0.string_0, false) == 0)
										{
											this.vmethod_52().Enabled = true;
											IL_28B:
											goto IL_2CD;
										}
									}
									goto IL_28B;
								}
								finally
								{
									List<Mission.EmptyAircraftSlot>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
							}
							this.vmethod_54().Enabled = false;
							this.vmethod_52().Enabled = false;
						}
						else
						{
							this.vmethod_54().Enabled = false;
							this.vmethod_52().Enabled = false;
						}
						IL_2CD:
						if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
						{
							this.vmethod_60().Enabled = true;
						}
						else
						{
							this.vmethod_60().Enabled = false;
						}
						if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
						{
							this.vmethod_96().Enabled = true;
							if (Enumerable.Count<Waypoint>(this.flight_0.method_15()) > 0)
							{
								if (this.flight_0.enum93_0 == Mission.Enum93.const_0)
								{
									this.vmethod_92().Enabled = true;
								}
								else
								{
									this.vmethod_92().Enabled = false;
								}
							}
							else
							{
								this.vmethod_92().Enabled = false;
							}
						}
						else
						{
							this.vmethod_96().Enabled = false;
							this.vmethod_92().Enabled = false;
						}
						this.vmethod_94().Enabled = false;
						if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_6)
						{
							this.vmethod_98().Enabled = false;
							this.vmethod_100().Enabled = false;
						}
						else
						{
							this.vmethod_98().Enabled = true;
							this.vmethod_100().Enabled = true;
							if (this.flight_0.enum93_0 == Mission.Enum93.const_0)
							{
								Waypoint[] array = this.flight_0.method_15();
								for (int i = 0; i < array.Length; i++)
								{
									Waypoint.WaypointType waypointType_ = array[i].waypointType_0;
									if (waypointType_ == Waypoint.WaypointType.Target || unchecked(waypointType_ - Waypoint.WaypointType.WeaponTarget) <= 5)
									{
										this.vmethod_94().Enabled = true;
										break;
									}
								}
							}
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
		}

		// Token: 0x06006AFC RID: 27388 RVA: 0x0039FBC4 File Offset: 0x0039DDC4
		public void method_11()
		{
			try
			{
				int num = 0;
				int num2 = 0;
				try
				{
					foreach (ActiveUnit activeUnit in this.mission_0.method_15(Client.smethod_46()))
					{
						if (activeUnit.bool_3 && activeUnit.vmethod_85().method_48() && activeUnit.vmethod_85().method_7() == Client.smethod_32().flight_0)
						{
							num++;
							Aircraft aircraft = (Aircraft)activeUnit;
							Aircraft aircraft2 = aircraft;
							string text = null;
							if (aircraft2.method_147(ref text) == Aircraft_AirOps.Enum44.const_0 && aircraft.vmethod_123())
							{
								num2++;
							}
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (this.vmethod_0().TabCount > 5 && !Information.IsNothing(this.vmethod_0().TabPages[5]))
				{
					TabPage tabPage = this.vmethod_0().TabPages[5];
					if (this.flight_0.enum93_0 != Mission.Enum93.const_1 && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
					{
						if (num > 5)
						{
							if (num2 > 5)
							{
								tabPage.Text = "#6";
							}
							else
							{
								tabPage.Text = "#6 (Not Ready)";
							}
						}
						else
						{
							tabPage.Text = "#6 (Empty)";
						}
					}
					else
					{
						tabPage.Text = "#6";
					}
				}
				if (this.vmethod_0().TabCount > 4 && !Information.IsNothing(this.vmethod_0().TabPages[4]))
				{
					TabPage tabPage = this.vmethod_0().TabPages[4];
					if (this.flight_0.enum93_0 != Mission.Enum93.const_1 && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
					{
						if (num > 4)
						{
							if (num2 > 4)
							{
								tabPage.Text = "#5";
							}
							else
							{
								tabPage.Text = "#5 (Not Ready)";
							}
						}
						else
						{
							tabPage.Text = "#5 (Empty)";
						}
					}
					else
					{
						tabPage.Text = "#5";
					}
				}
				if (this.vmethod_0().TabCount > 3 && !Information.IsNothing(this.vmethod_0().TabPages[3]))
				{
					TabPage tabPage = this.vmethod_0().TabPages[3];
					if (this.flight_0.enum93_0 != Mission.Enum93.const_1 && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
					{
						if (num > 3)
						{
							if (num2 > 3)
							{
								tabPage.Text = "#4";
							}
							else
							{
								tabPage.Text = "#4 (Not Ready)";
							}
						}
						else
						{
							tabPage.Text = "#4 (Empty)";
						}
					}
					else
					{
						tabPage.Text = "#4";
					}
				}
				if (this.vmethod_0().TabCount > 2 && !Information.IsNothing(this.vmethod_0().TabPages[2]))
				{
					TabPage tabPage = this.vmethod_0().TabPages[2];
					if (this.flight_0.enum93_0 != Mission.Enum93.const_1 && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
					{
						if (num > 2)
						{
							if (num2 > 2)
							{
								tabPage.Text = "#3";
							}
							else
							{
								tabPage.Text = "#3 (Not Ready)";
							}
						}
						else
						{
							tabPage.Text = "#3 (Empty)";
						}
					}
					else
					{
						tabPage.Text = "#3";
					}
				}
				if (this.vmethod_0().TabCount > 1 && !Information.IsNothing(this.vmethod_0().TabPages[1]))
				{
					TabPage tabPage = this.vmethod_0().TabPages[1];
					if (this.flight_0.enum93_0 != Mission.Enum93.const_1 && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
					{
						if (num > 1)
						{
							if (num2 > 1)
							{
								tabPage.Text = "#2";
							}
							else
							{
								tabPage.Text = "#2 (Not Ready)";
							}
						}
						else
						{
							tabPage.Text = "#2 (Empty)";
						}
					}
					else
					{
						tabPage.Text = "#2";
					}
				}
				if (this.vmethod_0().TabCount > 0 && !Information.IsNothing(this.vmethod_0().TabPages[0]))
				{
					TabPage tabPage = this.vmethod_0().TabPages[0];
					if (this.flight_0.enum93_0 != Mission.Enum93.const_1 && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
					{
						if (num > 0)
						{
							if (num2 > 0)
							{
								tabPage.Text = "Aircraft #1";
							}
							else
							{
								tabPage.Text = "Aircraft #1 (Not Ready)";
							}
						}
						else
						{
							tabPage.Text = "Aircraft #1 (Empty)";
						}
					}
					else
					{
						tabPage.Text = "Aircraft #1";
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

		// Token: 0x06006AFD RID: 27389 RVA: 0x003A0054 File Offset: 0x0039E254
		internal void method_12()
		{
			if (Information.IsNothing(this.mission_0))
			{
				this.dataTable_0.Clear();
				this.dataTable_1.Clear();
				this.dataTable_2.Clear();
				this.dataTable_3.Clear();
				this.dataTable_4.Clear();
				this.dataTable_5.Clear();
				this.method_9(false);
				return;
			}
			if (Information.IsNothing(this.flight_0))
			{
				this.dataTable_0.Clear();
				this.dataTable_1.Clear();
				this.dataTable_2.Clear();
				this.dataTable_3.Clear();
				this.dataTable_4.Clear();
				this.dataTable_5.Clear();
				this.method_9(false);
				return;
			}
			if (!this.mission_0.method_54())
			{
				this.dataTable_0.Clear();
				this.dataTable_1.Clear();
				this.dataTable_2.Clear();
				this.dataTable_3.Clear();
				this.dataTable_4.Clear();
				this.dataTable_5.Clear();
				this.method_9(false);
				return;
			}
			this.vmethod_38().vmethod_0().SuspendLayout();
			this.vmethod_42().vmethod_0().SuspendLayout();
			this.vmethod_44().vmethod_0().SuspendLayout();
			this.vmethod_46().vmethod_0().SuspendLayout();
			this.vmethod_48().vmethod_0().SuspendLayout();
			this.vmethod_50().vmethod_0().SuspendLayout();
			try
			{
				bool flag = false;
				if (Information.IsNothing(this.tabPage_6))
				{
					this.tabPage_6 = this.vmethod_0().TabPages[0];
				}
				if (Information.IsNothing(this.tabPage_7))
				{
					this.tabPage_7 = this.vmethod_0().TabPages[1];
				}
				if (Information.IsNothing(this.tabPage_8))
				{
					this.tabPage_8 = this.vmethod_0().TabPages[2];
				}
				if (Information.IsNothing(this.tabPage_9))
				{
					this.tabPage_9 = this.vmethod_0().TabPages[3];
				}
				if (Information.IsNothing(this.tabPage_10))
				{
					this.tabPage_10 = this.vmethod_0().TabPages[4];
				}
				if (Information.IsNothing(this.tabPage_11))
				{
					this.tabPage_11 = this.vmethod_0().TabPages[5];
				}
				switch (this.flight_0._FlightSize_0)
				{
				case Mission._FlightSize.SingleAircraft:
					if (this.vmethod_0().TabCount > 5 && !Information.IsNothing(this.vmethod_0().TabPages[5]))
					{
						TabPage value = this.vmethod_0().TabPages[5];
						this.vmethod_0().TabPages.Remove(value);
					}
					if (this.vmethod_0().TabCount > 4 && !Information.IsNothing(this.vmethod_0().TabPages[4]))
					{
						TabPage value = this.vmethod_0().TabPages[4];
						this.vmethod_0().TabPages.Remove(value);
					}
					if (this.vmethod_0().TabCount > 3 && !Information.IsNothing(this.vmethod_0().TabPages[3]))
					{
						TabPage value = this.vmethod_0().TabPages[3];
						this.vmethod_0().TabPages.Remove(value);
					}
					if (this.vmethod_0().TabCount > 2 && !Information.IsNothing(this.vmethod_0().TabPages[2]))
					{
						TabPage value = this.vmethod_0().TabPages[2];
						this.vmethod_0().TabPages.Remove(value);
					}
					if (this.vmethod_0().TabCount > 1 && !Information.IsNothing(this.vmethod_0().TabPages[1]))
					{
						TabPage value = this.vmethod_0().TabPages[1];
						this.vmethod_0().TabPages.Remove(value);
					}
					if (this.vmethod_0().SelectedIndex > 0)
					{
						this.vmethod_0().SelectedIndex = 0;
						goto IL_8A3;
					}
					goto IL_8A3;
				case Mission._FlightSize.TwoAircraft:
					if (this.vmethod_0().TabCount > 5 && !Information.IsNothing(this.vmethod_0().TabPages[5]))
					{
						TabPage value2 = this.vmethod_0().TabPages[5];
						this.vmethod_0().TabPages.Remove(value2);
					}
					if (this.vmethod_0().TabCount > 4 && !Information.IsNothing(this.vmethod_0().TabPages[4]))
					{
						TabPage value2 = this.vmethod_0().TabPages[4];
						this.vmethod_0().TabPages.Remove(value2);
					}
					if (this.vmethod_0().TabCount > 3 && !Information.IsNothing(this.vmethod_0().TabPages[3]))
					{
						TabPage value2 = this.vmethod_0().TabPages[3];
						this.vmethod_0().TabPages.Remove(value2);
					}
					if (this.vmethod_0().TabCount > 2 && !Information.IsNothing(this.vmethod_0().TabPages[2]))
					{
						TabPage value2 = this.vmethod_0().TabPages[2];
						this.vmethod_0().TabPages.Remove(value2);
					}
					if (this.vmethod_0().TabCount < 2)
					{
						this.vmethod_0().TabPages.Add(this.tabPage_7);
					}
					if (this.vmethod_0().SelectedIndex > 1)
					{
						this.vmethod_0().SelectedIndex = 0;
						goto IL_8A3;
					}
					goto IL_8A3;
				case Mission._FlightSize.ThreeAircraft:
					if (this.vmethod_0().TabCount > 5 && !Information.IsNothing(this.vmethod_0().TabPages[5]))
					{
						TabPage value3 = this.vmethod_0().TabPages[5];
						this.vmethod_0().TabPages.Remove(value3);
					}
					if (this.vmethod_0().TabCount > 4 && !Information.IsNothing(this.vmethod_0().TabPages[4]))
					{
						TabPage value3 = this.vmethod_0().TabPages[4];
						this.vmethod_0().TabPages.Remove(value3);
					}
					if (this.vmethod_0().TabCount > 3 && !Information.IsNothing(this.vmethod_0().TabPages[3]))
					{
						TabPage value3 = this.vmethod_0().TabPages[3];
						this.vmethod_0().TabPages.Remove(value3);
					}
					if (this.vmethod_0().TabCount < 2)
					{
						this.vmethod_0().TabPages.Add(this.tabPage_7);
					}
					if (this.vmethod_0().TabCount < 3)
					{
						this.vmethod_0().TabPages.Add(this.tabPage_8);
					}
					if (this.vmethod_0().SelectedIndex > 2)
					{
						this.vmethod_0().SelectedIndex = 0;
						goto IL_8A3;
					}
					goto IL_8A3;
				case Mission._FlightSize.FourAircraft:
					if (this.vmethod_0().TabCount > 5 && !Information.IsNothing(this.vmethod_0().TabPages[5]))
					{
						TabPage value4 = this.vmethod_0().TabPages[5];
						this.vmethod_0().TabPages.Remove(value4);
					}
					if (this.vmethod_0().TabCount > 4 && !Information.IsNothing(this.vmethod_0().TabPages[4]))
					{
						TabPage value4 = this.vmethod_0().TabPages[4];
						this.vmethod_0().TabPages.Remove(value4);
					}
					if (this.vmethod_0().TabCount < 2)
					{
						this.vmethod_0().TabPages.Add(this.tabPage_7);
					}
					if (this.vmethod_0().TabCount < 3)
					{
						this.vmethod_0().TabPages.Add(this.tabPage_8);
					}
					if (this.vmethod_0().TabCount < 4)
					{
						this.vmethod_0().TabPages.Add(this.tabPage_9);
					}
					if (this.vmethod_0().SelectedIndex > 3)
					{
						this.vmethod_0().SelectedIndex = 0;
						goto IL_8A3;
					}
					goto IL_8A3;
				case Mission._FlightSize.SixAircraft:
					if (this.vmethod_0().TabCount < 2)
					{
						this.vmethod_0().TabPages.Add(this.tabPage_7);
					}
					if (this.vmethod_0().TabCount < 3)
					{
						this.vmethod_0().TabPages.Add(this.tabPage_8);
					}
					if (this.vmethod_0().TabCount < 4)
					{
						this.vmethod_0().TabPages.Add(this.tabPage_9);
					}
					if (this.vmethod_0().TabCount < 5)
					{
						this.vmethod_0().TabPages.Add(this.tabPage_10);
					}
					if (this.vmethod_0().TabCount < 6)
					{
						this.vmethod_0().TabPages.Add(this.tabPage_11);
						goto IL_8A3;
					}
					goto IL_8A3;
				}
				return;
				IL_8A3:
				int num;
				if (!Information.IsNothing(this.flightPlanWaypoints_6) && !Information.IsNothing(this.flightPlanWaypoints_6.vmethod_0()))
				{
					num = this.flightPlanWaypoints_6.vmethod_0().SelectedRows.Count;
					if (num > 0)
					{
						this.int_0 = this.flightPlanWaypoints_6.vmethod_0().SelectedRows[0].Index;
						this.waypoint_0 = (Waypoint)this.flightPlanWaypoints_6.vmethod_0().Rows[this.int_0].Tag;
					}
				}
				else
				{
					num = 0;
					this.int_0 = 0;
					this.waypoint_0 = null;
				}
				if (this.vmethod_0().SelectedIndex == 0)
				{
					if (this.flightPlanWaypoints_6 != this.vmethod_38())
					{
						flag = true;
					}
					this.flightPlanWaypoints_6 = this.vmethod_38();
					this.dataTable_6 = this.dataTable_0;
				}
				else if (this.vmethod_0().SelectedIndex == 1)
				{
					if (this.flightPlanWaypoints_6 != this.vmethod_42())
					{
						flag = true;
					}
					this.flightPlanWaypoints_6 = this.vmethod_42();
					this.dataTable_6 = this.dataTable_1;
				}
				else if (this.vmethod_0().SelectedIndex == 2)
				{
					if (this.flightPlanWaypoints_6 != this.vmethod_44())
					{
						flag = true;
					}
					this.flightPlanWaypoints_6 = this.vmethod_44();
					this.dataTable_6 = this.dataTable_2;
				}
				else if (this.vmethod_0().SelectedIndex == 3)
				{
					if (this.flightPlanWaypoints_6 != this.vmethod_46())
					{
						flag = true;
					}
					this.flightPlanWaypoints_6 = this.vmethod_46();
					this.dataTable_6 = this.dataTable_3;
				}
				else if (this.vmethod_0().SelectedIndex == 4)
				{
					if (this.flightPlanWaypoints_6 != this.vmethod_48())
					{
						flag = true;
					}
					this.flightPlanWaypoints_6 = this.vmethod_48();
					this.dataTable_6 = this.dataTable_4;
				}
				else
				{
					if (this.vmethod_0().SelectedIndex != 5)
					{
						return;
					}
					if (this.flightPlanWaypoints_6 != this.vmethod_50())
					{
						flag = true;
					}
					this.flightPlanWaypoints_6 = this.vmethod_50();
					this.dataTable_6 = this.dataTable_5;
				}
				this.vmethod_38().enum106_0 = Mission.Flight.Enum106.const_1;
				this.vmethod_42().enum106_0 = Mission.Flight.Enum106.const_2;
				this.vmethod_44().enum106_0 = Mission.Flight.Enum106.const_3;
				this.vmethod_46().enum106_0 = Mission.Flight.Enum106.const_4;
				this.vmethod_48().enum106_0 = Mission.Flight.Enum106.const_5;
				this.vmethod_50().enum106_0 = Mission.Flight.Enum106.const_6;
				this.bool_3 = false;
				this.dataTable_6.Clear();
				this.dataTable_0.Clear();
				this.dataTable_1.Clear();
				this.dataTable_2.Clear();
				this.dataTable_3.Clear();
				this.dataTable_4.Clear();
				this.dataTable_5.Clear();
				this.bool_3 = true;
				this.method_11();
				if (this.dataTable_6.Columns.Count == 0)
				{
					if (!this.dataTable_6.Columns.Contains("ID"))
					{
						this.dataTable_6.Columns.Add("ID", typeof(string));
						this.int_1 = 0;
					}
					if (!this.dataTable_6.Columns.Contains("ObjectID"))
					{
						this.dataTable_6.Columns.Add("ObjectID", typeof(string));
						this.int_2 = 1;
					}
					if (!this.dataTable_6.Columns.Contains("Type"))
					{
						this.dataTable_6.Columns.Add("Type", typeof(int));
						this.int_3 = 2;
					}
					if (!this.dataTable_6.Columns.Contains("Time_Zulu"))
					{
						this.dataTable_6.Columns.Add("Time_Zulu", typeof(string));
						this.int_4 = 3;
					}
					if (!this.dataTable_6.Columns.Contains("Time_Local"))
					{
						this.dataTable_6.Columns.Add("Time_Local", typeof(string));
						this.int_5 = 4;
					}
					if (!this.dataTable_6.Columns.Contains("TimeFixedImg"))
					{
						this.dataTable_6.Columns.Add("TimeFixedImg", typeof(Image));
						this.int_7 = 5;
					}
					if (!this.dataTable_6.Columns.Contains("TimeFixed"))
					{
						this.dataTable_6.Columns.Add("TimeFixed", typeof(int));
						this.int_6 = 6;
					}
					if (!this.dataTable_6.Columns.Contains("DesiredSpeed"))
					{
						this.dataTable_6.Columns.Add("DesiredSpeed", typeof(string));
						this.int_8 = 7;
					}
					if (!this.dataTable_6.Columns.Contains("SpeedFixedImg"))
					{
						this.dataTable_6.Columns.Add("SpeedFixedImg", typeof(Image));
						this.int_10 = 8;
					}
					if (!this.dataTable_6.Columns.Contains("SpeedFixed"))
					{
						this.dataTable_6.Columns.Add("SpeedFixed", typeof(int));
						this.int_9 = 9;
					}
					if (!this.dataTable_6.Columns.Contains("DesiredAltitude"))
					{
						this.dataTable_6.Columns.Add("DesiredAltitude", typeof(string));
						this.int_11 = 10;
					}
					if (!this.dataTable_6.Columns.Contains("Leg_Distance"))
					{
						this.dataTable_6.Columns.Add("Leg_Distance", typeof(string));
						this.int_17 = 11;
					}
					if (!this.dataTable_6.Columns.Contains("Leg_TotalDistance"))
					{
						this.dataTable_6.Columns.Add("Leg_TotalDistance", typeof(string));
						this.int_18 = 12;
					}
					if (!this.dataTable_6.Columns.Contains("Leg_Time"))
					{
						this.dataTable_6.Columns.Add("Leg_Time", typeof(string));
						this.int_14 = 13;
					}
					if (!this.dataTable_6.Columns.Contains("Hold_Time"))
					{
						this.dataTable_6.Columns.Add("Hold_Time", typeof(string));
						this.int_15 = 14;
					}
					if (!this.dataTable_6.Columns.Contains("Leg_TotalTime"))
					{
						this.dataTable_6.Columns.Add("Leg_TotalTime", typeof(string));
						this.int_16 = 15;
					}
					if (!this.dataTable_6.Columns.Contains("Leg_FuelRequired"))
					{
						this.dataTable_6.Columns.Add("Leg_FuelRequired", typeof(string));
						this.int_12 = 16;
					}
					if (!this.dataTable_6.Columns.Contains("Leg_FuelRemaining"))
					{
						this.dataTable_6.Columns.Add("Leg_FuelRemaining", typeof(string));
						this.int_13 = 17;
					}
					if (!this.dataTable_6.Columns.Contains("SpeedToT"))
					{
						this.dataTable_6.Columns.Add("SpeedToT", typeof(int));
						this.int_27 = 18;
					}
					if (!this.dataTable_6.Columns.Contains("Formation"))
					{
						this.dataTable_6.Columns.Add("Formation", typeof(int));
						this.int_19 = 19;
					}
					if (!this.dataTable_6.Columns.Contains("AARUsage"))
					{
						this.dataTable_6.Columns.Add("AARUsage", typeof(int));
						this.int_21 = 20;
					}
					if (!this.dataTable_6.Columns.Contains("AARSelection"))
					{
						this.dataTable_6.Columns.Add("AARSelection", typeof(int));
						this.int_22 = 21;
					}
					if (!this.dataTable_6.Columns.Contains("AARSettings"))
					{
						this.dataTable_6.Columns.Add("AARSettings", typeof(int));
						this.int_20 = 22;
					}
					if (!this.dataTable_6.Columns.Contains("SensorUsage"))
					{
						this.dataTable_6.Columns.Add("SensorUsage", typeof(string));
						this.int_25 = 23;
					}
					if (!this.dataTable_6.Columns.Contains("Doctrine"))
					{
						this.dataTable_6.Columns.Add("Doctrine", typeof(string));
						this.int_24 = 24;
					}
					if (!this.dataTable_6.Columns.Contains("TurnRate"))
					{
						this.dataTable_6.Columns.Add("TurnRate", typeof(int));
						this.int_23 = 25;
					}
					if (!this.dataTable_6.Columns.Contains("Coordinates"))
					{
						this.dataTable_6.Columns.Add("Coordinates", typeof(string));
						this.int_26 = 26;
					}
				}
				if (flag)
				{
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn = (DataGridViewComboBoxColumn)this.flightPlanWaypoints_6.vmethod_0().Columns[this.flightPlanWaypoints_6.vmethod_0().Columns[this.int_3].Index];
					Waypoint.smethod_17(ref this.dataTable_7);
					dataGridViewComboBoxColumn.DataSource = this.dataTable_7;
					dataGridViewComboBoxColumn.DisplayMember = "Description";
					dataGridViewComboBoxColumn.ValueMember = "ID";
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn2 = (DataGridViewComboBoxColumn)this.flightPlanWaypoints_6.vmethod_0().Columns[this.flightPlanWaypoints_6.vmethod_0().Columns[this.int_21].Index];
					dataGridViewComboBoxColumn2.DataSource = this.dataTable_9;
					dataGridViewComboBoxColumn2.DisplayMember = "Description";
					dataGridViewComboBoxColumn2.ValueMember = "ID";
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn3 = (DataGridViewComboBoxColumn)this.flightPlanWaypoints_6.vmethod_0().Columns[this.flightPlanWaypoints_6.vmethod_0().Columns[this.int_22].Index];
					dataGridViewComboBoxColumn3.DataSource = this.dataTable_10;
					dataGridViewComboBoxColumn3.DisplayMember = "Description";
					dataGridViewComboBoxColumn3.ValueMember = "ID";
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn4 = (DataGridViewComboBoxColumn)this.flightPlanWaypoints_6.vmethod_0().Columns[this.flightPlanWaypoints_6.vmethod_0().Columns[this.int_19].Index];
					Waypoint.smethod_24(ref this.dataTable_8);
					dataGridViewComboBoxColumn4.DataSource = this.dataTable_8;
					dataGridViewComboBoxColumn4.DisplayMember = "Description";
					dataGridViewComboBoxColumn4.ValueMember = "ID";
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn5 = (DataGridViewComboBoxColumn)this.flightPlanWaypoints_6.vmethod_0().Columns[this.flightPlanWaypoints_6.vmethod_0().Columns[this.int_23].Index];
					Waypoint.smethod_25(ref this.dataTable_11);
					dataGridViewComboBoxColumn5.DataSource = this.dataTable_11;
					dataGridViewComboBoxColumn5.DisplayMember = "Description";
					dataGridViewComboBoxColumn5.ValueMember = "ID";
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn6 = (DataGridViewComboBoxColumn)this.flightPlanWaypoints_6.vmethod_0().Columns[this.flightPlanWaypoints_6.vmethod_0().Columns[this.int_27].Index];
					Waypoint.smethod_31(ref this.dataTable_12);
					dataGridViewComboBoxColumn6.DataSource = this.dataTable_12;
					dataGridViewComboBoxColumn6.DisplayMember = "Description";
					dataGridViewComboBoxColumn6.ValueMember = "ID";
				}
				this.bool_3 = false;
				Waypoint[] array = this.flight_0.method_15();
				int count;
				int num2;
				checked
				{
					for (int i = 0; i < array.Length; i++)
					{
						DataRow row = this.dataTable_6.NewRow();
						this.dataTable_6.Rows.Add(row);
					}
					if (num == 0 && this.flightPlanWaypoints_6.vmethod_0().Rows.Count > 0)
					{
						this.flightPlanWaypoints_6.vmethod_0().Rows[0].Selected = false;
					}
					this.bool_3 = true;
					this.method_13();
					if (Enumerable.Count<Waypoint>(this.flight_0.method_15()) > 0)
					{
						this.flight_0.method_15()[0].method_18().method_53(ref this.dataTable_9, Client.smethod_46(), new Doctrine.Enum56?(Doctrine.Enum56.const_1));
						this.flight_0.method_15()[0].method_18().method_54(ref this.dataTable_10, Client.smethod_46(), new Doctrine.Enum57?(Doctrine.Enum57.const_2));
					}
					this.bool_3 = false;
					this.flightPlanWaypoints_6.vmethod_0().DataSource = new DataView(this.dataTable_6);
					this.bool_3 = true;
					count = this.flightPlanWaypoints_6.vmethod_0().Rows.Count;
					num2 = Enumerable.Count<Waypoint>(this.flight_0.method_15());
				}
				for (int j = count - 1; j >= 0; j += -1)
				{
					if (j <= num2 - 1)
					{
						Waypoint expression = this.flight_0.method_15()[j];
						if (!Information.IsNothing(expression))
						{
							Waypoint tag = FlightPlanWaypoints.smethod_0(ref expression, this.flightPlanWaypoints_6.enum106_0);
							this.flightPlanWaypoints_6.vmethod_0().Rows[j].Tag = tag;
						}
					}
				}
				this.bool_3 = false;
				if (this.flightPlanWaypoints_6.vmethod_0().RowCount > 0)
				{
					if (this.int_0 > this.flightPlanWaypoints_6.vmethod_0().RowCount - 1)
					{
						this.flightPlanWaypoints_6.vmethod_0().Rows[0].Selected = false;
						this.flightPlanWaypoints_6.vmethod_0().Rows[this.flightPlanWaypoints_6.vmethod_0().RowCount - 1].Selected = true;
						this.waypoint_0 = (Waypoint)this.flightPlanWaypoints_6.vmethod_0().Rows[0].Tag;
					}
					else
					{
						this.flightPlanWaypoints_6.vmethod_0().Rows[0].Selected = false;
						this.flightPlanWaypoints_6.vmethod_0().Rows[this.int_0].Selected = true;
						this.waypoint_0 = (Waypoint)this.flightPlanWaypoints_6.vmethod_0().Rows[this.int_0].Tag;
					}
				}
				else
				{
					this.waypoint_0 = null;
				}
				this.bool_3 = true;
				this.bool_3 = false;
				this.flightPlanWaypoints_6.method_14();
				this.bool_3 = true;
				this.flightPlanWaypoints_6.method_15();
				this.flightPlanWaypoints_6.method_16();
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
			finally
			{
				if (this.vmethod_0().SelectedIndex == 0)
				{
					this.vmethod_38().vmethod_0().ResumeLayout();
				}
				else if (this.vmethod_0().SelectedIndex == 1)
				{
					this.vmethod_42().vmethod_0().ResumeLayout();
				}
				else if (this.vmethod_0().SelectedIndex == 2)
				{
					this.vmethod_44().vmethod_0().ResumeLayout();
				}
				else if (this.vmethod_0().SelectedIndex == 3)
				{
					this.vmethod_46().vmethod_0().ResumeLayout();
				}
				else if (this.vmethod_0().SelectedIndex == 4)
				{
					this.vmethod_48().vmethod_0().ResumeLayout();
				}
				else if (this.vmethod_0().SelectedIndex == 5)
				{
					this.vmethod_50().vmethod_0().ResumeLayout();
				}
			}
		}

		// Token: 0x06006AFE RID: 27390 RVA: 0x003A18CC File Offset: 0x0039FACC
		internal void method_13()
		{
			try
			{
				if (Information.IsNothing(this.mission_0))
				{
					this.Text = "Flightplan Editor for flight <NO MISSION OR FLIGHT SELECTED>";
				}
				else if (Information.IsNothing(this.flight_0))
				{
					this.Text = "Flightplan Editor for flight <NO FLIGHT SELECTED>";
				}
				else if (this.mission_0.method_54())
				{
					this.Text = "Flightplan Editor for flight " + this.flight_0.string_4;
					this.vmethod_56().Text = this.flight_0.string_12;
					this.vmethod_58().Text = this.flight_0.method_13(Client.smethod_46());
					this.vmethod_86().Text = this.flight_0.string_6;
					this.vmethod_82().Text = this.flight_0.string_8;
					this.vmethod_90().Text = this.flight_0.string_10;
					this.vmethod_68().Text = Mission.smethod_5(this.flight_0.method_10(Client.smethod_46()));
					if (string.IsNullOrEmpty(this.vmethod_56().Text))
					{
						this.vmethod_56().Text = "Not set";
					}
					if (string.IsNullOrEmpty(this.vmethod_58().Text))
					{
						this.vmethod_58().Text = "Not set";
					}
					if (string.IsNullOrEmpty(this.vmethod_86().Text))
					{
						this.vmethod_86().Text = "Not set";
					}
					if (string.IsNullOrEmpty(this.vmethod_82().Text))
					{
						this.vmethod_82().Text = "Not set";
					}
					if (string.IsNullOrEmpty(this.vmethod_90().Text))
					{
						this.vmethod_90().Text = "-";
					}
					if (string.IsNullOrEmpty(this.vmethod_68().Text))
					{
						this.vmethod_68().Text = "Not set";
					}
					int num = 1;
					DateTime dateTime_ = Client.smethod_46().method_31();
					bool bool_ = Client.smethod_46().method_33();
					string string_ = Client.smethod_46().method_35();
					string string_2 = Client.smethod_46().method_37();
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					bool flag4 = false;
					this.flightPlanWaypoints_6.vmethod_0().SuspendLayout();
					try
					{
						int num2 = Enumerable.Count<Waypoint>(this.flight_0.method_15()) - 1;
						int i = 0;
						while (i <= num2)
						{
							Waypoint waypoint;
							Waypoint waypoint2;
							if (this.vmethod_0().SelectedIndex == 0)
							{
								waypoint = this.flight_0.method_15()[i];
								waypoint2 = this.flight_0.method_15()[i];
							}
							else if (this.vmethod_0().SelectedIndex == 1)
							{
								if (Information.IsNothing(this.flight_0.method_15()[i].waypoint_0))
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i];
								}
								else if (!Information.IsNothing(this.flight_0.method_15()[i].waypoint_0) && this.flight_0.method_15()[i].enum83_0 != Waypoint.Enum83.const_2)
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i].waypoint_0;
								}
								else
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i].waypoint_0;
								}
							}
							else if (this.vmethod_0().SelectedIndex == 2)
							{
								if (Information.IsNothing(this.flight_0.method_15()[i].waypoint_1))
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i];
								}
								else if (!Information.IsNothing(this.flight_0.method_15()[i].waypoint_1) && this.flight_0.method_15()[i].enum83_0 != Waypoint.Enum83.const_2)
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i].waypoint_1;
								}
								else
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i].waypoint_1;
								}
							}
							else if (this.vmethod_0().SelectedIndex == 3)
							{
								if (Information.IsNothing(this.flight_0.method_15()[i].waypoint_2))
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i];
								}
								else if (!Information.IsNothing(this.flight_0.method_15()[i].waypoint_2) && this.flight_0.method_15()[i].enum83_0 != Waypoint.Enum83.const_2)
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i].waypoint_2;
								}
								else
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i].waypoint_2;
								}
							}
							else if (this.vmethod_0().SelectedIndex == 4)
							{
								if (Information.IsNothing(this.flight_0.method_15()[i].waypoint_3))
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i];
								}
								else if (!Information.IsNothing(this.flight_0.method_15()[i].waypoint_3) && this.flight_0.method_15()[i].enum83_0 != Waypoint.Enum83.const_2)
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i].waypoint_3;
								}
								else
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i].waypoint_3;
								}
							}
							else
							{
								if (this.vmethod_0().SelectedIndex != 5)
								{
									return;
								}
								if (Information.IsNothing(this.flight_0.method_15()[i].waypoint_4))
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i];
								}
								else if (!Information.IsNothing(this.flight_0.method_15()[i].waypoint_4) && this.flight_0.method_15()[i].enum83_0 != Waypoint.Enum83.const_2)
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i].waypoint_4;
								}
								else
								{
									waypoint = this.flight_0.method_15()[i];
									waypoint2 = this.flight_0.method_15()[i].waypoint_4;
								}
							}
							DataRow dataRow = this.dataTable_6.Rows[i];
							Waypoint waypoint3;
							if (waypoint.method_22())
							{
								waypoint3 = waypoint2;
							}
							else
							{
								waypoint3 = waypoint;
							}
							int num3 = Waypoint.smethod_19(waypoint.waypointType_0);
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_3]), num3))
							{
								dataRow[this.int_3] = num3;
							}
							if (waypoint.waypointType_0 == Waypoint.WaypointType.StationEnd && waypoint.float_25 == 0f)
							{
								flag = true;
								flag2 = true;
							}
							string text;
							if (string.IsNullOrEmpty(waypoint.string_2))
							{
								text = Conversions.ToString(num);
							}
							else
							{
								text = waypoint.string_2;
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_1]), text))
							{
								dataRow[this.int_1] = text;
							}
							num++;
							dataRow[this.int_2] = waypoint.string_0;
							DateTime? dateTime;
							string text2;
							if (!Information.IsNothing(waypoint3.nullable_7) && !flag)
							{
								if (Information.IsNothing(waypoint3.nullable_8))
								{
									dateTime = waypoint3.nullable_7;
								}
								else
								{
									dateTime = waypoint3.nullable_8;
								}
								if (dateTime.Value.Hour < 10)
								{
									text2 = "0" + dateTime.Value.Hour.ToString() + ":";
								}
								else
								{
									text2 = dateTime.Value.Hour.ToString() + ":";
								}
								if (dateTime.Value.Minute < 10)
								{
									text2 = text2 + "0" + dateTime.Value.Minute.ToString() + ":";
								}
								else
								{
									text2 = text2 + dateTime.Value.Minute.ToString() + ":";
								}
								if (dateTime.Value.Second < 10)
								{
									text2 = text2 + "0" + dateTime.Value.Second.ToString();
								}
								else
								{
									text2 += dateTime.Value.Second.ToString();
								}
								if (waypoint3.waypointType_0 == Waypoint.WaypointType.TakeOff)
								{
									string str = dateTime.Value.Year.ToString() + "-";
									if (dateTime.Value.Month < 10)
									{
										str = str + "0" + dateTime.Value.Month.ToString() + "-";
									}
									else
									{
										str = str + dateTime.Value.Month.ToString() + "-";
									}
									if (dateTime.Value.Day < 10)
									{
										str = str + "0" + dateTime.Value.Day.ToString();
									}
									else
									{
										str += dateTime.Value.Day.ToString();
									}
									string text3 = str + ", " + text2;
									if (Operators.CompareString(text3, this.vmethod_32().Text, false) != 0)
									{
										this.vmethod_32().Text = text3;
									}
									flag3 = true;
								}
								else if (waypoint3.waypointType_0 == Waypoint.WaypointType.Target || waypoint3.waypointType_0 == Waypoint.WaypointType.WeaponTarget || waypoint3.method_40())
								{
									string str2 = dateTime.Value.Year.ToString() + "-";
									if (dateTime.Value.Month < 10)
									{
										str2 = str2 + "0" + dateTime.Value.Month.ToString() + "-";
									}
									else
									{
										str2 = str2 + dateTime.Value.Month.ToString() + "-";
									}
									if (dateTime.Value.Day < 10)
									{
										str2 = str2 + "0" + dateTime.Value.Day.ToString();
									}
									else
									{
										str2 += dateTime.Value.Day.ToString();
									}
									string text4 = str2 + ", " + text2;
									if (Operators.CompareString(text4, this.vmethod_64().Text, false) != 0)
									{
										this.vmethod_64().Text = text4;
									}
									flag4 = true;
								}
							}
							else
							{
								text2 = "-";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_4]), text2))
							{
								dataRow[this.int_4] = text2;
							}
							string text5;
							if (!Information.IsNothing(dateTime) && !Information.IsNothing(waypoint3.nullable_9) && !flag)
							{
								DateTime? dateTime2;
								if (Information.IsNothing(waypoint3.nullable_8))
								{
									dateTime2 = waypoint3.nullable_9;
								}
								else
								{
									dateTime2 = waypoint3.nullable_10;
								}
								if (dateTime2.Value.Hour < 10)
								{
									text5 = "0" + dateTime2.Value.Hour.ToString() + ":";
								}
								else
								{
									text5 = dateTime2.Value.Hour.ToString() + ":";
								}
								if (dateTime2.Value.Minute < 10)
								{
									text5 = text5 + "0" + dateTime2.Value.Minute.ToString() + ":";
								}
								else
								{
									text5 = text5 + dateTime2.Value.Minute.ToString() + ":";
								}
								if (dateTime2.Value.Second < 10)
								{
									text5 = text5 + "0" + dateTime2.Value.Second.ToString();
								}
								else
								{
									text5 += dateTime2.Value.Second.ToString();
								}
								waypoint3.ttimeOfDayType_0 = Class418.smethod_1(null, dateTime.Value.Year, dateTime.Value.Month, dateTime.Value.Day, dateTime.Value.Hour, dateTime.Value.Minute, dateTime.Value.Second, false, waypoint3.imethod_2(), waypoint3.imethod_0(), 0.0);
								if (Information.IsNothing(waypoint3.nullable_8))
								{
									waypoint3.nullable_9 = new DateTime?(Misc.smethod_10(waypoint3.nullable_7.Value, waypoint3.imethod_0(), bool_, string_, string_2));
								}
								else
								{
									waypoint3.nullable_9 = new DateTime?(Misc.smethod_10(waypoint3.nullable_8.Value, waypoint3.imethod_0(), bool_, string_, string_2));
								}
								text5 = text5 + " (" + Class418.smethod_0(waypoint3.ttimeOfDayType_0, dateTime_, waypoint3.imethod_0(), bool_, string_, string_2) + ")";
							}
							else
							{
								text5 = "-";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_5]), text5))
							{
								dataRow[this.int_5] = text5;
							}
							Waypoint.Enum82 @enum;
							if (!Information.IsNothing(dateTime) && !flag)
							{
								@enum = waypoint3.enum82_0;
							}
							else
							{
								@enum = Waypoint.Enum82.const_4;
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_6]), @enum))
							{
								dataRow[this.int_6] = @enum;
							}
							if (waypoint2.method_18().method_7())
							{
								dataRow[this.int_25] = "Not configured";
							}
							else if (waypoint2.method_18().method_6(Client.smethod_46()).method_1() == Doctrine.Class275.Enum66.const_3 && waypoint2.method_18().method_6(Client.smethod_46()).method_2() == Doctrine.Class275.Enum66.const_3 && waypoint2.method_18().method_6(Client.smethod_46()).method_3() == Doctrine.Class275.Enum66.const_3)
							{
								dataRow[this.int_25] = "Use mission EMCON";
							}
							else
							{
								string text6 = "";
								if (waypoint2.method_18().method_6(Client.smethod_46()).method_1() == Doctrine.Class275.Enum66.const_1)
								{
									text6 = "Radar active";
								}
								else if (waypoint2.method_18().method_6(Client.smethod_46()).method_1() == Doctrine.Class275.Enum66.const_0)
								{
									text6 = "Radar passive";
								}
								if (waypoint2.method_18().method_6(Client.smethod_46()).method_2() == Doctrine.Class275.Enum66.const_1)
								{
									if (!string.IsNullOrEmpty(text6))
									{
										text6 += ", ";
									}
									text6 += "Sonar active";
								}
								else if (waypoint2.method_18().method_6(Client.smethod_46()).method_2() == Doctrine.Class275.Enum66.const_0)
								{
									if (!string.IsNullOrEmpty(text6))
									{
										text6 += ", ";
									}
									text6 += "Sonar passive";
								}
								if (waypoint2.method_18().method_6(Client.smethod_46()).method_3() == Doctrine.Class275.Enum66.const_1)
								{
									if (!string.IsNullOrEmpty(text6))
									{
										text6 += ", ";
									}
									text6 += "OECM active";
								}
								else if (waypoint2.method_18().method_6(Client.smethod_46()).method_3() == Doctrine.Class275.Enum66.const_0)
								{
									if (!string.IsNullOrEmpty(text6))
									{
										text6 += ", ";
									}
									text6 += "OECM passive";
								}
								if (string.IsNullOrEmpty(text6))
								{
									text6 = "Not configured";
								}
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_25]), text6))
								{
									dataRow[this.int_25] = text6;
								}
							}
							string text7 = Misc.smethod_8(waypoint3.imethod_2(), waypoint3.imethod_0());
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_26]), text7))
							{
								dataRow[this.int_26] = text7;
							}
							string text8;
							if (waypoint.float_2 < -2.1474836E+09f)
							{
								text8 = "Unknown, Aircraft Type and Loadout Type not set";
							}
							else if ((Information.IsNothing(waypoint.nullable_7) && (waypoint.waypointType_0 == Waypoint.WaypointType.HoldEnd || waypoint.waypointType_0 == Waypoint.WaypointType.StationEnd)) || waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
							{
								text8 = "-";
							}
							else
							{
								text8 = Conversions.ToString((int)Math.Round((double)waypoint2.float_2)) + " kg";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_12]), text8))
							{
								dataRow[this.int_12] = text8;
							}
							string text9;
							Doctrine.Enum56? enum2;
							Doctrine.Enum56? enum3;
							if (waypoint.float_3 > 2.1474836E+09f)
							{
								text9 = "Unknown";
							}
							else
							{
								byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
								bool? flag5 = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
								bool? flag6 = flag5 = ((flag5 != null) ? new bool?(!flag5.GetValueOrDefault()) : flag5);
								bool? flag7;
								bool? flag13;
								if (flag5 != null && !flag6.GetValueOrDefault())
								{
									flag7 = new bool?(false);
								}
								else
								{
									b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
									bool? flag9;
									bool? flag8 = flag9 = ((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null);
									bool? flag10 = flag8 = ((flag9 == null || flag8.GetValueOrDefault()) ? (flag8 & !Information.IsNothing(enum3)) : new bool?(false));
									bool? flag11;
									if (flag8 != null && !flag10.GetValueOrDefault())
									{
										flag11 = new bool?(false);
									}
									else
									{
										b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
										bool? flag12 = flag8 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
										flag11 = ((flag8 != null) ? (flag10 & flag12.GetValueOrDefault()) : null);
									}
									flag5 = flag11;
									flag13 = (flag5 = ((flag5 != null) ? new bool?(!flag5.GetValueOrDefault()) : flag5));
									flag7 = ((flag5 != null) ? (flag6 & flag13.GetValueOrDefault()) : null);
								}
								flag13 = flag7;
								if (flag13.GetValueOrDefault())
								{
									text9 = "Unknown, AAR allowed";
									flag2 = false;
								}
								else if (flag2)
								{
									text9 = "Unknown, Station Time not set";
								}
								else if (this.vmethod_0().SelectedIndex == 0)
								{
									text9 = Conversions.ToString((int)Math.Round((double)waypoint.float_3)) + " kg";
								}
								else if (waypoint.method_21())
								{
									if (this.vmethod_0().SelectedIndex == 1)
									{
										text9 = Conversions.ToString((int)Math.Round((double)waypoint.float_14)) + " kg";
									}
									else if (this.vmethod_0().SelectedIndex == 2)
									{
										text9 = Conversions.ToString((int)Math.Round((double)waypoint.float_15)) + " kg";
									}
									else if (this.vmethod_0().SelectedIndex == 3)
									{
										text9 = Conversions.ToString((int)Math.Round((double)waypoint.float_16)) + " kg";
									}
									else if (this.vmethod_0().SelectedIndex == 4)
									{
										text9 = Conversions.ToString((int)Math.Round((double)waypoint.float_17)) + " kg";
									}
									else if (this.vmethod_0().SelectedIndex == 5)
									{
										text9 = Conversions.ToString((int)Math.Round((double)waypoint.float_18)) + " kg";
									}
									else
									{
										text9 = Conversions.ToString((int)Math.Round((double)waypoint.float_3)) + " kg";
									}
								}
								else
								{
									text9 = Conversions.ToString((int)Math.Round((double)waypoint.float_3)) + " kg";
								}
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_13]), text9))
							{
								dataRow[this.int_13] = text9;
							}
							enum3 = enum2;
							enum2 = waypoint2.method_18().method_152(Client.smethod_46(), false, false, false, false);
							string text10 = Misc.smethod_11((long)Math.Round((double)(waypoint2.float_4 + waypoint2.float_5)), Aircraft_AirOps.Enum44.const_0, false, true);
							if (waypoint2.float_6 > 0f)
							{
								text10 = text10 + " (Weapon: " + Misc.smethod_11((long)Math.Round((double)waypoint2.float_6), Aircraft_AirOps.Enum44.const_0, false, true) + ")";
							}
							else if (waypoint.waypointType_0 == Waypoint.WaypointType.HoldEnd || waypoint.waypointType_0 == Waypoint.WaypointType.StationEnd || waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
							{
								text10 = "-";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_14]), text10))
							{
								dataRow[this.int_14] = text10;
							}
							if (flag)
							{
								goto IL_1615;
							}
							if (waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
							{
								goto IL_1615;
							}
							string text11 = Misc.smethod_11((long)Math.Round((double)waypoint2.float_7), Aircraft_AirOps.Enum44.const_0, false, true);
							IL_161C:
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_16]), text11))
							{
								dataRow[this.int_16] = text11;
							}
							string text12;
							if (waypoint.waypointType_0 != Waypoint.WaypointType.HoldEnd && waypoint.waypointType_0 != Waypoint.WaypointType.StationEnd && waypoint.waypointType_0 != Waypoint.WaypointType.TakeOff && (int)Math.Round((double)(waypoint2.float_9 + waypoint2.float_10)) != 0)
							{
								text12 = Conversions.ToString((int)Math.Round((double)(waypoint2.float_9 + waypoint2.float_10))) + " nm";
							}
							else
							{
								text12 = "-";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_17]), text12))
							{
								dataRow[this.int_17] = text12;
							}
							if (flag)
							{
								goto IL_189A;
							}
							if (waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
							{
								goto IL_189A;
							}
							string text13;
							if (this.vmethod_0().SelectedIndex == 0)
							{
								text13 = Conversions.ToString((int)Math.Round((double)waypoint.float_13)) + " nm";
							}
							else if (waypoint.method_21())
							{
								if (this.vmethod_0().SelectedIndex == 1 && waypoint.float_19 > 0f)
								{
									text13 = Conversions.ToString((int)Math.Round((double)waypoint.float_19)) + " nm";
								}
								else if (this.vmethod_0().SelectedIndex == 2 && waypoint.float_20 > 0f)
								{
									text13 = Conversions.ToString((int)Math.Round((double)waypoint.float_20)) + " nm";
								}
								else if (this.vmethod_0().SelectedIndex == 3 && waypoint.float_21 > 0f)
								{
									text13 = Conversions.ToString((int)Math.Round((double)waypoint.float_21)) + " nm";
								}
								else if (this.vmethod_0().SelectedIndex == 4 && waypoint.float_22 > 0f)
								{
									text13 = Conversions.ToString((int)Math.Round((double)waypoint.float_22)) + " nm";
								}
								else if (this.vmethod_0().SelectedIndex == 5 && waypoint.float_23 > 0f)
								{
									text13 = Conversions.ToString((int)Math.Round((double)waypoint.float_23)) + " nm";
								}
								else
								{
									text13 = Conversions.ToString((int)Math.Round((double)waypoint.float_13)) + " nm";
								}
							}
							else
							{
								text13 = Conversions.ToString((int)Math.Round((double)waypoint.float_13)) + " nm";
							}
							IL_18A1:
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_18]), text13))
							{
								dataRow[this.int_18] = text13;
							}
							string text14;
							if (waypoint3.float_24 > 0f && waypoint3.float_25 == 0f && waypoint3.float_26 == 0f)
							{
								if (!Information.IsNothing(dateTime))
								{
									text14 = Misc.smethod_11((long)Math.Round((double)waypoint3.float_24), Aircraft_AirOps.Enum44.const_0, false, true) + " Hold";
								}
								else
								{
									text14 = "N/A";
								}
							}
							else if (waypoint3.float_24 == 0f && waypoint3.float_25 == 0f && waypoint3.float_26 > 0f)
							{
								if (waypoint3.float_27 > 0f)
								{
									text14 = Misc.smethod_11((long)Math.Round((double)waypoint3.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " 90/90, " + Misc.smethod_11((long)Math.Round((double)waypoint3.float_27), Aircraft_AirOps.Enum44.const_0, false, true) + " Separation";
								}
								else
								{
									text14 = Misc.smethod_11((long)Math.Round((double)waypoint3.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " Spacing";
								}
							}
							else if (waypoint3.float_24 > 0f && waypoint3.float_25 == 0f && waypoint3.float_26 > 0f)
							{
								if (!Information.IsNothing(dateTime))
								{
									text14 = Misc.smethod_11((long)Math.Round((double)waypoint3.float_24), Aircraft_AirOps.Enum44.const_0, false, true) + " Hold, " + Misc.smethod_11((long)Math.Round((double)waypoint3.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " Spacing";
								}
								else
								{
									text14 = "N/A Hold, " + Misc.smethod_11((long)Math.Round((double)waypoint3.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " Spacing";
								}
							}
							else if (waypoint3.float_25 > 0f && this.flight_0.enum93_0 == Mission.Enum93.const_1)
							{
								text14 = Misc.smethod_11((long)Math.Round((double)waypoint3.float_25), Aircraft_AirOps.Enum44.const_0, false, true) + " Station";
							}
							else if (waypoint3.float_24 == 0f && waypoint3.float_25 > 0f && waypoint3.float_26 == 0f)
							{
								if (!Information.IsNothing(dateTime))
								{
									text14 = Misc.smethod_11((long)Math.Round((double)waypoint3.float_25), Aircraft_AirOps.Enum44.const_0, false, true) + " Station";
								}
								else
								{
									text14 = "N/A";
								}
							}
							else if (waypoint3.float_24 == 0f && waypoint3.float_25 > 0f && waypoint3.float_26 > 0f)
							{
								if (!Information.IsNothing(dateTime))
								{
									text14 = Misc.smethod_11((long)Math.Round((double)waypoint3.float_25), Aircraft_AirOps.Enum44.const_0, false, true) + " Station, " + Misc.smethod_11((long)Math.Round((double)waypoint3.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " Spacing";
								}
								else
								{
									text14 = "N/A Station, " + Misc.smethod_11((long)Math.Round((double)waypoint3.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " Spacing";
								}
							}
							else
							{
								text14 = "-";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_15]), text14))
							{
								dataRow[this.int_15] = text14;
							}
							int num4;
							Doctrine.Enum56 value;
							if (waypoint.method_18().method_154())
							{
								num4 = 3;
								value = waypoint.method_18().method_152(Client.smethod_46(), false, false, false, false).Value;
							}
							else
							{
								value = waypoint.method_18().method_152(Client.smethod_46(), false, false, false, false).Value;
								switch (value)
								{
								case Doctrine.Enum56.const_0:
									num4 = 1;
									break;
								case Doctrine.Enum56.const_1:
									num4 = 2;
									break;
								case Doctrine.Enum56.const_2:
									num4 = 0;
									break;
								case Doctrine.Enum56.const_4:
									num4 = 4;
									break;
								}
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_21]), num4))
							{
								dataRow[this.int_21] = num4;
							}
							if (waypoint.method_18().method_154())
							{
								goto IL_1D37;
							}
							if (value == Doctrine.Enum56.const_1)
							{
								goto IL_1D37;
							}
							int num5;
							if (waypoint.method_18().method_159())
							{
								num5 = 3;
							}
							else
							{
								switch (waypoint.method_18().method_157(Client.smethod_46(), false, false, false, false).Value)
								{
								case Doctrine.Enum57.const_0:
									num5 = 0;
									break;
								case Doctrine.Enum57.const_1:
									num5 = 1;
									break;
								case Doctrine.Enum57.const_2:
									num5 = 2;
									break;
								case Doctrine.Enum57.const_4:
									num5 = 4;
									break;
								}
							}
							IL_1D3A:
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_22]), num5))
							{
								dataRow[this.int_22] = num5;
							}
							if (waypoint.waypointType_0 == Waypoint.WaypointType.WeaponTarget)
							{
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_11]), "-"))
								{
									dataRow[this.int_11] = "-";
								}
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_8]), "-"))
								{
									dataRow[this.int_8] = "-";
								}
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_9]), Waypoint.Enum82.const_4))
								{
									dataRow[this.int_9] = Waypoint.Enum82.const_4;
								}
								int num6 = Waypoint.smethod_28(waypoint.enum83_0);
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_19]), num6))
								{
									dataRow[this.int_19] = num6;
								}
								int num7 = waypoint.int_1;
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_20]), num7))
								{
									dataRow[this.int_20] = num7;
								}
								Waypoint.Enum81 enum81_ = waypoint3.enum81_0;
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_23]), enum81_))
								{
									dataRow[this.int_23] = enum81_;
								}
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_27]), Waypoint.Enum84.const_0))
								{
									dataRow[this.int_27] = Waypoint.Enum84.const_0;
								}
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_24]), "-"))
								{
									dataRow[this.int_24] = "-";
								}
							}
							else
							{
								string text15;
								if (!Information.IsNothing(waypoint3.method_27()) && !Information.IsNothing(waypoint3.nullable_0))
								{
									float? nullable_;
									float? num8 = nullable_ = waypoint3.nullable_0;
									text15 = ((nullable_ != null) ? Conversions.ToString(num8.GetValueOrDefault()) : null) + " kt";
									if (!Information.IsNothing(this.flight_0.method_32(Client.smethod_46())) && waypoint3.method_29())
									{
										if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
										{
											string str3 = text15;
											string str4 = " (";
											ActiveUnit.Throttle throttle = this.flight_0.method_32(Client.smethod_46()).vmethod_87().vmethod_41(waypoint3.nullable_2.Value, waypoint3.nullable_0.Value);
											text15 = str3 + str4 + this.method_8(ref throttle) + ")";
										}
										else if (!Information.IsNothing(waypoint3.nullable_1))
										{
											string str5 = text15;
											string str6 = " (";
											ActiveUnit.Throttle throttle = this.flight_0.method_32(Client.smethod_46()).vmethod_87().vmethod_41(waypoint3.nullable_1.Value, waypoint3.nullable_0.Value);
											text15 = str5 + str6 + this.method_8(ref throttle) + ")";
										}
									}
								}
								else if (!Information.IsNothing(waypoint3.method_35()) && waypoint3.method_35() != ActiveUnit_Kinematics.UnitThrottlePreset.None)
								{
									ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)waypoint3.method_35();
									text15 = this.method_8(ref throttle);
									if (waypoint3.method_29() && !Information.IsNothing(waypoint3.nullable_0))
									{
										string str7 = text15;
										string str8 = " (";
										float? nullable_;
										float? num8 = nullable_ = waypoint3.nullable_0;
										text15 = str7 + str8 + ((nullable_ != null) ? Conversions.ToString(num8.GetValueOrDefault()) : null) + " kt)";
									}
								}
								else
								{
									text15 = "Speed Not set!";
								}
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_8]), text15))
								{
									dataRow[this.int_8] = text15;
								}
								Waypoint.Enum82 enum82_ = waypoint3.enum82_1;
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_9]), enum82_))
								{
									dataRow[this.int_9] = enum82_;
								}
								string text16 = "";
								if (!Information.IsNothing(waypoint3.method_29()) && (!Information.IsNothing(waypoint3.nullable_1) || (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))))
								{
									if (Class570.class280_0.method_12())
									{
										if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
										{
											if ((int)Math.Round((double)waypoint3.nullable_2.Value) == 0)
											{
												text16 = "Minimum";
											}
											else
											{
												text16 = Conversions.ToString((int)Math.Round((double)(waypoint3.nullable_2 * 3.28084f).Value)) + " ft AGL";
											}
										}
										else if (!Information.IsNothing(waypoint3.nullable_1))
										{
											if ((int)Math.Round((double)waypoint3.nullable_1.Value) == 0)
											{
												text16 = "Minimum";
											}
											else
											{
												text16 = Conversions.ToString((int)Math.Round((double)(waypoint3.nullable_1 * 3.28084f).Value)) + " ft ASL";
											}
										}
									}
									else if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
									{
										if ((int)Math.Round((double)waypoint3.nullable_2.Value) == 0)
										{
											text16 = "Minimum";
										}
										else
										{
											text16 = Conversions.ToString((int)Math.Round((double)waypoint3.nullable_2.Value)) + " m AGL";
										}
									}
									else if (!Information.IsNothing(waypoint3.nullable_1))
									{
										if ((int)Math.Round((double)waypoint3.nullable_1.Value) == 0)
										{
											text16 = "Minimum";
										}
										else
										{
											text16 = Conversions.ToString((int)Math.Round((double)waypoint3.nullable_1.Value)) + " m ASL";
										}
									}
								}
								else if (!Information.IsNothing(waypoint3.method_31()) && waypoint3.method_31() != ActiveUnit_AI.AircraftAltitudePreset.None)
								{
									switch (waypoint3.method_31())
									{
									case ActiveUnit_AI.AircraftAltitudePreset.MinAltitude:
										text16 = "Minimum";
										break;
									case ActiveUnit_AI.AircraftAltitudePreset.Low1000:
										if (Class570.class280_0.method_12())
										{
											if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
											{
												text16 = Conversions.ToString(305) + " ft AGL";
											}
											else if (!Information.IsNothing(waypoint3.nullable_1))
											{
												text16 = Conversions.ToString(305) + " ft ASL";
											}
										}
										else if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
										{
											text16 = Conversions.ToString(305) + " m AGL";
										}
										else if (!Information.IsNothing(waypoint3.nullable_1))
										{
											text16 = Conversions.ToString(305) + " m ASL";
										}
										break;
									case ActiveUnit_AI.AircraftAltitudePreset.Low2000:
										if (Class570.class280_0.method_12())
										{
											if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
											{
												text16 = Conversions.ToString(610) + " ft AGL";
											}
											else if (!Information.IsNothing(waypoint3.nullable_1))
											{
												text16 = Conversions.ToString(610) + " ft ASL";
											}
										}
										else if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
										{
											text16 = Conversions.ToString(610) + " m AGL";
										}
										else if (!Information.IsNothing(waypoint3.nullable_1))
										{
											text16 = Conversions.ToString(610) + " m ASL";
										}
										break;
									case ActiveUnit_AI.AircraftAltitudePreset.Medium12000:
										if (Class570.class280_0.method_12())
										{
											if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
											{
												text16 = Conversions.ToString(3658) + " ft AGL";
											}
											else if (!Information.IsNothing(waypoint3.nullable_1))
											{
												text16 = Conversions.ToString(3658) + " ft ASL";
											}
										}
										else if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
										{
											text16 = Conversions.ToString(3658) + " m AGL";
										}
										else if (!Information.IsNothing(waypoint3.nullable_1))
										{
											text16 = Conversions.ToString(3658) + " m ASL";
										}
										break;
									case ActiveUnit_AI.AircraftAltitudePreset.High25000:
										if (Class570.class280_0.method_12())
										{
											if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
											{
												text16 = Conversions.ToString(7620) + " ft AGL";
											}
											else if (!Information.IsNothing(waypoint3.nullable_1))
											{
												text16 = Conversions.ToString(7620) + " ft ASL";
											}
										}
										else if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
										{
											text16 = Conversions.ToString(7620) + " m AGL";
										}
										else if (!Information.IsNothing(waypoint3.nullable_1))
										{
											text16 = Conversions.ToString(7620) + " m ASL";
										}
										break;
									case ActiveUnit_AI.AircraftAltitudePreset.High36000:
										if (Class570.class280_0.method_12())
										{
											if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
											{
												text16 = Conversions.ToString(10973) + " ft AGL";
											}
											else if (!Information.IsNothing(waypoint3.nullable_1))
											{
												text16 = Conversions.ToString(10973) + " ft ASL";
											}
										}
										else if (waypoint3.method_37() && !Information.IsNothing(waypoint3.nullable_2))
										{
											text16 = Conversions.ToString(10973) + " m AGL";
										}
										else if (!Information.IsNothing(waypoint3.nullable_1))
										{
											text16 = Conversions.ToString(10973) + " m ASL";
										}
										break;
									case ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude:
										text16 = "Maximum";
										break;
									}
								}
								else
								{
									text16 = "Altitude not set!";
								}
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_11]), text16))
								{
									dataRow[this.int_11] = text16;
								}
								int num9 = Waypoint.smethod_28(waypoint.enum83_0);
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_19]), num9))
								{
									dataRow[this.int_19] = num9;
								}
								int num10 = waypoint.int_1;
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_20]), num10))
								{
									dataRow[this.int_20] = num10;
								}
								Waypoint.Enum81 enum81_2 = waypoint3.enum81_0;
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_23]), enum81_2))
								{
									dataRow[this.int_23] = enum81_2;
								}
								Waypoint.Enum84 enum84_ = waypoint3.enum84_0;
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_27]), enum84_))
								{
									dataRow[this.int_27] = enum84_;
								}
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_24]), "Something whatever"))
								{
									dataRow[this.int_24] = "Something whatever";
								}
							}
							i++;
							continue;
							IL_1D37:
							num5 = 0;
							goto IL_1D3A;
							IL_189A:
							text13 = "-";
							goto IL_18A1;
							IL_1615:
							text11 = "-";
							goto IL_161C;
						}
					}
					finally
					{
						this.flightPlanWaypoints_6.vmethod_0().ResumeLayout();
					}
					if (!flag3)
					{
						this.vmethod_32().Text = "-";
					}
					if (!flag4)
					{
						this.vmethod_64().Text = "-";
					}
					if (this.flightPlanWaypoints_6.vmethod_0().Rows.Count > 0)
					{
						this.bool_3 = false;
						if (this.flightPlanWaypoints_6.vmethod_0().SelectedRows.Count > 0 && this.flightPlanWaypoints_6.vmethod_0().SelectedRows[0].Index > 0 && this.int_0 != this.flightPlanWaypoints_6.vmethod_0().SelectedRows[0].Index)
						{
							if (this.int_0 <= this.flightPlanWaypoints_6.vmethod_0().Rows.Count - 1)
							{
								this.flightPlanWaypoints_6.vmethod_0().Rows[this.int_0].Selected = false;
							}
							this.int_0 = this.flightPlanWaypoints_6.vmethod_0().SelectedRows[0].Index;
						}
						this.flightPlanWaypoints_6.vmethod_0().Rows[0].Selected = false;
						if (this.flightPlanWaypoints_6.vmethod_0().RowCount > 0)
						{
							if (this.int_0 > this.flightPlanWaypoints_6.vmethod_0().RowCount - 1)
							{
								this.flightPlanWaypoints_6.vmethod_0().Rows[this.flightPlanWaypoints_6.vmethod_0().RowCount - 1].Selected = false;
								this.flightPlanWaypoints_6.vmethod_0().Rows[this.flightPlanWaypoints_6.vmethod_0().RowCount - 1].Selected = true;
							}
							else
							{
								this.flightPlanWaypoints_6.vmethod_0().Rows[this.int_0].Selected = false;
								this.flightPlanWaypoints_6.vmethod_0().Rows[this.int_0].Selected = true;
							}
						}
						this.waypoint_0 = (Waypoint)this.flightPlanWaypoints_6.vmethod_0().SelectedRows[0].Tag;
						this.bool_3 = true;
					}
					else
					{
						this.waypoint_0 = null;
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

		// Token: 0x06006AFF RID: 27391 RVA: 0x003A4570 File Offset: 0x003A2770
		private void method_14(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0))
			{
				Mission.Flight flight = this.flight_0;
				Scenario scenario = Client.smethod_46();
				Mission.Flight flight2 = new Mission.Flight();
				bool bool_ = false;
				int enum103_ = (int)this.flight_0.enum103_0;
				int enum103_2 = (int)this.flight_0.enum103_1;
				flight.method_31(ref scenario, ref this.flight_0, ref flight2, bool_, ref this.mission_0, ref enum103_, ref enum103_2, true, true);
				this.method_9(false);
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_4();
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				Client.bool_1 = true;
				Class2413.smethod_2().method_41().method_84();
			}
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x003A4638 File Offset: 0x003A2838
		private void method_15(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				Mission mission = this.mission_0;
				Scenario scenario = Client.smethod_46();
				Side side_ = Client.smethod_50();
				mission.method_20(ref scenario, ref side_, ref this.flight_0);
				Client.smethod_51(side_);
				this.method_9(false);
				this.method_11();
				this.method_13();
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_4();
				}
				if (Client.flightPlanAircraftLoadout_0.Visible)
				{
					Client.flightPlanAircraftLoadout_0.method_5();
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
			}
		}

		// Token: 0x06006B01 RID: 27393 RVA: 0x003A4700 File Offset: 0x003A2900
		private void method_16(object sender, EventArgs e)
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
				this.method_9(false);
				this.method_11();
				this.method_13();
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_6();
				}
				if (Client.flightPlanAircraftLoadout_0.Visible)
				{
					Client.flightPlanAircraftLoadout_0.method_5();
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
			}
		}

		// Token: 0x06006B02 RID: 27394 RVA: 0x003A47F8 File Offset: 0x003A29F8
		private void method_17(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				Client.flightPlanAircraftLoadout_0.mission_0 = this.mission_0;
				Client.flightPlanAircraftLoadout_0.flight_0 = this.flight_0;
				if (Client.flightPlanAircraftLoadout_0.Visible)
				{
					Client.flightPlanAircraftLoadout_0.method_3();
					Client.flightPlanAircraftLoadout_0.BringToFront();
					return;
				}
				Client.flightPlanAircraftLoadout_0.Show();
			}
		}

		// Token: 0x06006B03 RID: 27395 RVA: 0x003A487C File Offset: 0x003A2A7C
		private void method_18(object sender, EventArgs e)
		{
			try
			{
				foreach (Mission mission in Client.smethod_50().method_35())
				{
					if (Operators.CompareString(mission.Name, Conversions.ToString(this.vmethod_22().SelectedItem), false) == 0)
					{
						this.mission_0 = mission;
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
			if (this.mission_0.method_54())
			{
				this.flight_0 = this.mission_0.list_1[0];
			}
			this.method_12();
			this.method_9(false);
			if (Client.flightPlanTime_0.Visible && Client.flightPlanTime_0.bool_3)
			{
				Client.flightPlanTime_0.method_4(ref Client.smethod_32().mission_0, ref Client.smethod_32().flight_0, ref Client.smethod_32().waypoint_0, Client.smethod_32().flightPlanWaypoints_6.enum106_0, true);
			}
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x003A4970 File Offset: 0x003A2B70
		private void method_19(object sender, EventArgs e)
		{
			try
			{
				foreach (Mission.Flight flight in this.mission_0.list_1)
				{
					if (Operators.CompareString(flight.string_4, Conversions.ToString(this.vmethod_24().SelectedItem), false) == 0)
					{
						this.flight_0 = flight;
						break;
					}
				}
			}
			finally
			{
				List<Mission.Flight>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.method_12();
			this.method_9(false);
			if (Client.flightPlanTime_0.Visible && Client.flightPlanTime_0.bool_3)
			{
				Client.flightPlanTime_0.method_4(ref Client.smethod_32().mission_0, ref Client.smethod_32().flight_0, ref Client.smethod_32().waypoint_0, Client.smethod_32().flightPlanWaypoints_6.enum106_0, true);
			}
		}

		// Token: 0x06006B05 RID: 27397 RVA: 0x003A4A48 File Offset: 0x003A2C48
		private void method_20(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.flight_0))
			{
				bool flag = false;
				Mission._FlightTask flightTask = Mission.Flight.smethod_5(this.vmethod_26().SelectedIndex);
				if (flightTask == Mission._FlightTask.const_48)
				{
					if (this.mission_0._MissionClass_0 != Mission._MissionClass.Patrol && this.mission_0._MissionClass_0 != Mission._MissionClass.Support)
					{
						Interaction.MsgBox("Only patrol and support missions may use flights of type QRA.", MsgBoxStyle.OkOnly, null);
						this.method_9(false);
						return;
					}
					if (this.mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
					{
						Class343 @class = (Class343)this.mission_0;
						if (!@class.bool_30)
						{
							Interaction.MsgBox("The mission does not have Continous Coverage enabled, so QRA flights will not launch!", MsgBoxStyle.OkOnly, null);
						}
						else if (!@class.bool_31)
						{
							Interaction.MsgBox("The mission does not have QRA enabled, so QRA flights will not launch!", MsgBoxStyle.OkOnly, null);
						}
					}
					if (this.mission_0._MissionClass_0 == Mission._MissionClass.Support)
					{
						Class344 class2 = (Class344)this.mission_0;
						if (!class2.bool_28)
						{
							Interaction.MsgBox("The mission does not have Continous Coverage enabled, so QRA flights will not launch!", MsgBoxStyle.OkOnly, null);
						}
						else if (!class2.bool_29)
						{
							Interaction.MsgBox("The mission does not have QRA enabled, so QRA flights will not launch!", MsgBoxStyle.OkOnly, null);
						}
					}
					bool flag2;
					if (flag2 = (!Information.IsNothing(this.mission_0) && this.mission_0.enum88_0 == Mission.Enum88.const_1))
					{
						Interaction.MsgBox("Packages cannot use flights of type QRA.", MsgBoxStyle.OkOnly, null);
						this.method_9(false);
						return;
					}
					if (Enumerable.Count<Waypoint>(this.flight_0.method_15()) > 0 && !Information.IsNothing(this.flight_0.method_15()[0].nullable_7))
					{
						if (Interaction.MsgBox("Changing the flight task type to QRA will clear all waypoints times. Continue?", MsgBoxStyle.YesNo, null) != MsgBoxResult.Yes)
						{
							this.method_9(false);
							return;
						}
						AirTaskingOrder.smethod_3(this.flight_0, flag2);
						flag = true;
					}
				}
				this.flight_0._FlightTask_0 = flightTask;
				if (this.flight_0.method_8())
				{
					this.flight_0.bool_12 = true;
				}
				else
				{
					this.flight_0.bool_12 = false;
				}
				try
				{
					foreach (ActiveUnit activeUnit in this.mission_0.method_15(Client.smethod_46()))
					{
						if (activeUnit.vmethod_85().method_48() && activeUnit.vmethod_85().method_7() == this.flight_0)
						{
							activeUnit.vmethod_86().bool_2 = this.flight_0.bool_12;
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (!Information.IsNothing(this.mission_0.list_2))
				{
					try
					{
						foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in this.mission_0.list_2)
						{
							if (Operators.CompareString(emptyAircraftSlot.string_2, this.flight_0.string_0, false) == 0)
							{
								emptyAircraftSlot.bool_2 = this.flight_0.bool_12;
							}
						}
					}
					finally
					{
						List<Mission.EmptyAircraftSlot>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.flightPlanWaypoints_6.method_16();
				if (flag)
				{
					if (!Information.IsNothing(this.flight_0))
					{
						Scenario scenario_ = Client.smethod_46();
						Mission mission = this.mission_0;
						ActiveUnit activeUnit_ = this.flight_0.method_32(Client.smethod_46());
						Mission.Flight flight = this.flight_0;
						Mission.Flight flight2;
						Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
						float num = 0f;
						float num2 = 0f;
						Class514.smethod_28(scenario_, mission, activeUnit_, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
						flight2.method_16(waypoint_);
					}
					this.method_13();
					Class2413.smethod_2().method_41().method_235();
					Client.bool_1 = true;
					Class2413.smethod_2().method_41().method_84();
				}
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_4();
				}
			}
		}

		// Token: 0x06006B06 RID: 27398 RVA: 0x0039ADF4 File Offset: 0x00398FF4
		private void FlightPlanEditor_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06006B07 RID: 27399 RVA: 0x0000378C File Offset: 0x0000198C
		private void FlightPlanEditor_Shown(object sender, EventArgs e)
		{
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x003A4DF0 File Offset: 0x003A2FF0
		private void method_21(object sender, EventArgs e)
		{
			this.method_12();
			if (Client.flightPlanTime_0.Visible && Client.flightPlanTime_0.bool_3)
			{
				Client.flightPlanTime_0.method_4(ref Client.smethod_32().mission_0, ref Client.smethod_32().flight_0, ref Client.smethod_32().waypoint_0, Client.smethod_32().flightPlanWaypoints_6.enum106_0, true);
			}
		}

		// Token: 0x06006B09 RID: 27401 RVA: 0x00043AB9 File Offset: 0x00041CB9
		private void method_22(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x00043ACF File Offset: 0x00041CCF
		private void method_23(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x00043AD8 File Offset: 0x00041CD8
		private void method_24(object sender, EventArgs e)
		{
			this.method_25();
		}

		// Token: 0x06006B0C RID: 27404 RVA: 0x003A4E54 File Offset: 0x003A3054
		private void method_25()
		{
			if (this.bool_4 && !Information.IsNothing(this.flight_0))
			{
				Mission.Flight flight = this.flight_0;
				Scenario scenario = Client.smethod_46();
				flight.method_29(ref scenario, ref this.flight_0, this.flight_0.string_4, this.vmethod_28().Text);
				this.flight_0.string_4 = this.vmethod_28().Text;
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_4();
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				Client.bool_1 = true;
				Class2413.smethod_2().method_41().method_84();
			}
			this.bool_4 = false;
			this.method_9(false);
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x003A4F1C File Offset: 0x003A311C
		private void method_26(object sender, EventArgs e)
		{
			try
			{
				if (!Information.IsNothing(this.mission_0))
				{
					if (!Information.IsNothing(this.flight_0))
					{
						if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
						{
							if (this.flight_0.int_2 == 0)
							{
								Interaction.MsgBox("Select aircraft and loadout type before creating a flightplan.", MsgBoxStyle.OkOnly, null);
							}
							else if (this.flight_0.int_3 == 0)
							{
								Interaction.MsgBox("Select loadout type before creating a flightplan.", MsgBoxStyle.OkOnly, null);
							}
							else if (this.method_35())
							{
								bool flag = false;
								float num = 0f;
								Aircraft aircraft = (Aircraft)Client.smethod_32().flight_0.method_32(Client.smethod_46());
								float float_ = 0f;
								Scenario scenario = Client.smethod_46();
								Side side_ = Client.smethod_50();
								FlightPlanEditor flightPlanEditor = Client.smethod_32();
								bool? nullable_ = new bool?(false);
								bool bool_ = false;
								bool flag2 = false;
								string text = "";
								Class514.smethod_8(ref scenario, ref side_, ref this.mission_0, ref flightPlanEditor.flight_0, ref aircraft, nullable_, ref flag, bool_, flag2, ref num, ref text, false, float_, Waypoint.Enum81.const_2, true, null, null, false);
								Client.smethod_51(side_);
								this.method_5();
								if (Client.smethod_31().Visible)
								{
									Client.smethod_31().method_5();
								}
								if (Client.flightPlanAircraftLoadout_0.Visible)
								{
									Client.flightPlanAircraftLoadout_0.method_5();
								}
								if (Client.smethod_30().Visible)
								{
									Client.smethod_30().method_11();
									Client.smethod_30().method_13();
								}
								Client.bool_1 = true;
								Class2413.smethod_2().method_41().method_84();
							}
						}
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

		// Token: 0x06006B0E RID: 27406 RVA: 0x003A50F4 File Offset: 0x003A32F4
		private void method_27(object sender, EventArgs e)
		{
			try
			{
				if (!Information.IsNothing(this.mission_0))
				{
					if (!Information.IsNothing(this.flight_0))
					{
						Mission mission = this.mission_0;
						Scenario scenario = Client.smethod_46();
						Side side_ = Client.smethod_50();
						mission.method_58(ref scenario, ref side_, ref Client.smethod_32().flight_0);
						Client.smethod_51(side_);
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
						Client.bool_1 = true;
						Class2413.smethod_2().method_41().method_84();
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

		// Token: 0x06006B0F RID: 27407 RVA: 0x003A51EC File Offset: 0x003A33EC
		private void method_28(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				Mission.Enum93 enum93_ = Mission.Flight.smethod_15(this.vmethod_76().SelectedIndex);
				Mission.Flight flight_ = this.flight_0;
				Scenario scenario = Client.smethod_46();
				Side side_ = Client.smethod_50();
				AirTaskingOrder.smethod_1(flight_, ref scenario, ref side_, ref this.mission_0, enum93_);
				Client.smethod_51(side_);
				this.method_9(false);
				this.method_13();
				this.flightPlanWaypoints_6.method_16();
				this.flightPlanWaypoints_6.method_14();
				this.method_11();
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_4();
				}
				if (Client.flightPlanAircraftLoadout_0.Visible)
				{
					Client.flightPlanAircraftLoadout_0.method_5();
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				Class2413.smethod_2().method_41().method_235();
			}
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x003A52EC File Offset: 0x003A34EC
		private void method_29(object sender, EventArgs e)
		{
			try
			{
				if (!Information.IsNothing(this.flightPlanWaypoints_6))
				{
					if (!Information.IsNothing(this.flightPlanWaypoints_6.vmethod_0()))
					{
						if (!Information.IsNothing(this.mission_0))
						{
							if (!Information.IsNothing(this.flight_0))
							{
								if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
								{
									bool flag = false;
									int num = Client.smethod_32().flightPlanWaypoints_6.vmethod_0().Rows.Count - 1;
									for (int i = 0; i <= num; i++)
									{
										DataGridViewRow dataGridViewRow = Client.smethod_32().flightPlanWaypoints_6.vmethod_0().Rows[i];
										Waypoint waypoint = (Waypoint)dataGridViewRow.Tag;
										if (waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
										{
											dataGridViewRow.Selected = true;
											flag = true;
											IL_E0:
											if (flag && !Information.IsNothing(waypoint))
											{
												Client.flightPlanTime_0.bool_3 = true;
												Client.flightPlanTime_0.method_4(ref this.mission_0, ref this.flight_0, ref waypoint, this.flightPlanWaypoints_6.enum106_0, true);
												Client.flightPlanTime_0.Show();
												Client.flightPlanTime_0.BringToFront();
											}
											return;
										}
										if (dataGridViewRow.Selected)
										{
											dataGridViewRow.Selected = false;
										}
									}
									goto IL_E0;
								}
							}
						}
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

		// Token: 0x06006B11 RID: 27409 RVA: 0x003A5480 File Offset: 0x003A3680
		private void method_30(object sender, EventArgs e)
		{
			try
			{
				if (!Information.IsNothing(this.flightPlanWaypoints_6))
				{
					if (!Information.IsNothing(this.flightPlanWaypoints_6.vmethod_0()))
					{
						if (!Information.IsNothing(this.mission_0))
						{
							if (!Information.IsNothing(this.flight_0))
							{
								bool flag = false;
								int num = Client.smethod_32().flightPlanWaypoints_6.vmethod_0().Rows.Count - 1;
								for (int i = 0; i <= num; i++)
								{
									DataGridViewRow dataGridViewRow = Client.smethod_32().flightPlanWaypoints_6.vmethod_0().Rows[i];
									Waypoint waypoint = (Waypoint)dataGridViewRow.Tag;
									Waypoint.WaypointType waypointType_ = waypoint.waypointType_0;
									if (waypointType_ == Waypoint.WaypointType.Target || waypointType_ - Waypoint.WaypointType.WeaponTarget <= 5)
									{
										dataGridViewRow.Selected = true;
										flag = true;
										IL_D3:
										if (flag && !Information.IsNothing(waypoint))
										{
											Client.flightPlanTime_0.bool_3 = true;
											Client.flightPlanTime_0.method_4(ref this.mission_0, ref this.flight_0, ref waypoint, this.flightPlanWaypoints_6.enum106_0, true);
											Client.flightPlanTime_0.Show();
											Client.flightPlanTime_0.BringToFront();
										}
										return;
									}
									if (dataGridViewRow.Selected)
									{
										dataGridViewRow.Selected = false;
									}
								}
								goto IL_D3;
							}
						}
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

		// Token: 0x06006B12 RID: 27410 RVA: 0x003A5604 File Offset: 0x003A3804
		private void method_31(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.flight_0))
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
				this.method_5();
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_5();
				}
				if (Client.flightPlanAircraftLoadout_0.Visible)
				{
					Client.flightPlanAircraftLoadout_0.method_5();
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				Client.bool_1 = true;
				Class2413.smethod_2().method_41().method_84();
			}
		}

		// Token: 0x06006B13 RID: 27411 RVA: 0x003A56E0 File Offset: 0x003A38E0
		private void method_32(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.flight_0))
			{
				Scenario scenario = Client.smethod_46();
				Side side_ = Client.smethod_50();
				Mission.Flight flight_ = this.flight_0;
				Mission.Flight flight = this.flight_0;
				Mission.Flight flight2 = this.flight_0;
				Unit unit = Client.smethod_54();
				ReadOnlyCollection<Unit> readOnlyCollection = Client.smethod_50().method_56();
				FlightPlanEditor.smethod_0(ref scenario, ref side_, ref this.mission_0, flight_, ref flight.string_8, ref flight2.string_7, ref unit, ref readOnlyCollection, false, true, false);
				Client.smethod_51(side_);
				this.method_5();
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_5();
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				Client.bool_1 = true;
				Class2413.smethod_2().method_41().method_84();
			}
		}

		// Token: 0x06006B14 RID: 27412 RVA: 0x003A57A4 File Offset: 0x003A39A4
		private void method_33(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.flight_0))
			{
				Scenario scenario = Client.smethod_46();
				Side side_ = Client.smethod_50();
				Mission.Flight flight_ = this.flight_0;
				Mission.Flight flight = this.flight_0;
				Mission.Flight flight2 = this.flight_0;
				Unit unit = Client.smethod_54();
				ReadOnlyCollection<Unit> readOnlyCollection = Client.smethod_50().method_56();
				FlightPlanEditor.smethod_0(ref scenario, ref side_, ref this.mission_0, flight_, ref flight.string_10, ref flight2.string_9, ref unit, ref readOnlyCollection, false, false, true);
				Client.smethod_51(side_);
				this.method_5();
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_5();
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				Client.bool_1 = true;
				Class2413.smethod_2().method_41().method_84();
			}
		}

		// Token: 0x06006B15 RID: 27413 RVA: 0x003A5868 File Offset: 0x003A3A68
		public void method_34(bool bool_5, bool bool_6, bool bool_7, bool bool_8, bool bool_9)
		{
			try
			{
				if (!Information.IsNothing(this.flight_0))
				{
					Scenario scenario_ = Client.smethod_46();
					Mission mission = this.mission_0;
					ActiveUnit activeUnit_ = this.flight_0.method_32(Client.smethod_46());
					Mission.Flight flight = this.flight_0;
					Mission.Flight flight2;
					Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
					float num = 0f;
					float num2 = 0f;
					Class514.smethod_28(scenario_, mission, activeUnit_, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
					flight2.method_16(waypoint_);
				}
				if (base.Visible && bool_6)
				{
					if (bool_7)
					{
						Client.smethod_32().bool_3 = false;
						if (bool_8)
						{
							this.method_12();
						}
						else
						{
							this.method_13();
							if (bool_9)
							{
								this.flightPlanWaypoints_6.method_14();
							}
						}
						Client.smethod_32().bool_3 = true;
					}
					else if (bool_8)
					{
						this.method_12();
					}
					else
					{
						this.method_13();
						if (bool_9)
						{
							this.flightPlanWaypoints_6.method_14();
						}
					}
				}
				if (bool_5)
				{
					Class2413.smethod_2().method_41().method_235();
					Client.bool_1 = true;
					Class2413.smethod_2().method_41().method_84();
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

		// Token: 0x06006B16 RID: 27414 RVA: 0x003A59EC File Offset: 0x003A3BEC
		private bool method_35()
		{
			bool result;
			if (Information.IsNothing(this.flight_0))
			{
				result = false;
			}
			else
			{
				if (Information.IsNothing(Client.smethod_32().flight_0.method_32(Client.smethod_46())))
				{
					if (string.IsNullOrEmpty(Client.smethod_32().flight_0.string_5))
					{
						Interaction.MsgBox("No take-off location has been set. Select the airfield or ship on the tactical map from where you wish to take off, press the 'Change take-off location' button, and try creating the flightplan again.", MsgBoxStyle.OkOnly, null);
						return false;
					}
					if (string.IsNullOrEmpty(Client.smethod_32().flight_0.string_7))
					{
						Interaction.MsgBox("No landing location has been set. Select the airfield or ship on the tactical map from where you wish to take off, press the 'Change take-off location' button, and try creating the flightplan again.", MsgBoxStyle.OkOnly, null);
						return false;
					}
				}
				else
				{
					Aircraft aircraft = (Aircraft)Client.smethod_32().flight_0.method_32(Client.smethod_46());
					if (aircraft.vmethod_30(null) == 0.0 && aircraft.vmethod_28(null) == 0.0)
					{
						if (string.IsNullOrEmpty(Client.smethod_32().flight_0.string_5))
						{
							Interaction.MsgBox("No take-off location has been set. Select the airfield or ship on the tactical map from where you wish to take off, press the 'Change take-off location' button, and try creating the flightplan again.", MsgBoxStyle.OkOnly, null);
							return false;
						}
						if (string.IsNullOrEmpty(Client.smethod_32().flight_0.string_7))
						{
							Interaction.MsgBox("No landing location has been set. Select the airfield or ship on the tactical map from where you wish to take off, press the 'Change take-off location' button, and try creating the flightplan again.", MsgBoxStyle.OkOnly, null);
							return false;
						}
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x003A5B20 File Offset: 0x003A3D20
		private void method_36(object sender, EventArgs e)
		{
			try
			{
				if (!Information.IsNothing(this.mission_0))
				{
					if (!Information.IsNothing(this.flight_0))
					{
						if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
						{
							if (this.flight_0.int_2 == 0)
							{
								Interaction.MsgBox("Select aircraft and loadout type before creating a flightplan.", MsgBoxStyle.OkOnly, null);
							}
							else if (this.flight_0.int_3 == 0)
							{
								Interaction.MsgBox("Select loadout type before creating a flightplan.", MsgBoxStyle.OkOnly, null);
							}
							else if (this.method_35())
							{
								Aircraft aircraft = (Aircraft)this.flight_0.method_32(Client.smethod_46());
								Doctrine.Enum59? nullable_ = this.mission_0.doctrine_0.method_162(Client.smethod_46(), false, false, false);
								Scenario scenario = Client.smethod_46();
								Side side_ = Client.smethod_50();
								Mission mission = this.mission_0;
								bool bool_ = true;
								bool bool_2 = false;
								string string_ = this.flight_0.string_4;
								Mission._FlightSize flightSize_ = this.flight_0._FlightSize_0;
								Group group = null;
								Class514.smethod_1(ref scenario, ref side_, mission, bool_, bool_2, ref this.flight_0, string_, flightSize_, ref aircraft, ref group, true, nullable_);
								Client.smethod_51(side_);
								this.method_5();
								if (Client.smethod_31().Visible)
								{
									Client.smethod_31().method_5();
								}
								if (Client.flightPlanAircraftLoadout_0.Visible)
								{
									Client.flightPlanAircraftLoadout_0.method_5();
								}
								if (Client.smethod_30().Visible)
								{
									Client.smethod_30().method_11();
									Client.smethod_30().method_13();
								}
								Client.bool_1 = true;
								Class2413.smethod_2().method_41().method_84();
							}
						}
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

		// Token: 0x06006B18 RID: 27416 RVA: 0x003A5CE8 File Offset: 0x003A3EE8
		public static void smethod_0(ref Scenario scenario_0, ref Side side_0, ref Mission mission_1, Mission.Flight flight_1, ref string string_0, ref string string_1, ref Unit unit_0, ref ReadOnlyCollection<Unit> readOnlyCollection_0, bool bool_5, bool bool_6, bool bool_7)
		{
			FlightPlanEditor.Class2465 @class = new FlightPlanEditor.Class2465(@class);
			@class.flight_0 = flight_1;
			try
			{
				if (readOnlyCollection_0.Count > 1)
				{
					Interaction.MsgBox("Error! Multiple units on the map has been selected. To change the location, select a single base or ship that can host aircraft of this type, and try again.", MsgBoxStyle.OkOnly, null);
				}
				else if (Information.IsNothing(unit_0))
				{
					Interaction.MsgBox("Error! No unit has been selected on the map. To change the location, select a single base or ship that can host aircraft of this type, and try again.", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					if (bool_5 && @class.flight_0.method_10(scenario_0) != Mission.Enum102.const_0)
					{
						Interaction.MsgBox("Error! The flight has already launched, so cannot change take-off location!", MsgBoxStyle.OkOnly, null);
						if (!bool_6 || !bool_7)
						{
							return;
						}
						bool_5 = false;
					}
					if (Operators.CompareString(string_1, unit_0.string_0, false) != 0)
					{
						if (unit_0.bool_5)
						{
							Interaction.MsgBox("Error! Aircraft cannot take off or land on submarines.", MsgBoxStyle.OkOnly, null);
						}
						else
						{
							if (unit_0.bool_1)
							{
								Group group = (Group)unit_0;
								if (group.method_143() == Group.GroupType.SurfaceGroup)
								{
									Interaction.MsgBox("Error! Aircraft can only take off or land on ships, not ship groups.", MsgBoxStyle.OkOnly, null);
									return;
								}
								if (group.method_143() == Group.GroupType.SubGroup)
								{
									Interaction.MsgBox("Error! Aircraft can not take off or land on submarines.", MsgBoxStyle.OkOnly, null);
									return;
								}
							}
							if (bool_5)
							{
								List<ActiveUnit> list = new List<ActiveUnit>();
								list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(mission_1.method_15(scenario_0), new Func<ActiveUnit, bool>(@class.method_0))));
								if (list.Count > 0)
								{
									if (Interaction.MsgBox("You have selected to change the take-off location for this flightplan. The aircraft will be removed from the flightplan because they are not present at the take-off location, and replaced by empty slots that can be filled with aircraft later on. Do you wish to proceed?", MsgBoxStyle.YesNo, null) == MsgBoxResult.No)
									{
										return;
									}
									mission_1.method_20(ref scenario_0, ref side_0, ref @class.flight_0);
								}
							}
							if (unit_0.bool_0)
							{
								Aircraft aircraft = (Aircraft)@class.flight_0.method_32(scenario_0);
								bool flag = !unit_0.bool_1;
								bool flag2 = false;
								bool flag3 = false;
								if (unit_0.bool_1)
								{
									if (((Group)unit_0).method_143() == Group.GroupType.AirBase)
									{
										flag3 = true;
									}
									else
									{
										flag2 = true;
									}
								}
								if (!Information.IsNothing(aircraft))
								{
									if (flag || flag3)
									{
										if (Operators.CompareString(aircraft.method_164().method_26((ActiveUnit)unit_0), "OK", false) != 0)
										{
											Interaction.MsgBox("Error! " + unit_0.Name + " cannot host the aircraft. To change the location, select a single base or ship that can host aircraft of this type, and try again.", MsgBoxStyle.OkOnly, null);
											return;
										}
										string_0 = unit_0.Name;
										string_1 = unit_0.string_0;
									}
									if (flag2)
									{
										Unit unit = null;
										try
										{
											foreach (ActiveUnit activeUnit in ((Group)unit_0).vmethod_141().Values)
											{
												if (Operators.CompareString(aircraft.method_164().method_26(activeUnit), "OK", false) == 0)
												{
													string_0 = unit_0.Name;
													string_1 = unit_0.string_0;
													unit = activeUnit;
													break;
												}
											}
										}
										finally
										{
											IEnumerator<ActiveUnit> enumerator;
											if (enumerator != null)
											{
												enumerator.Dispose();
											}
										}
										if (unit == null)
										{
											Interaction.MsgBox("Error! " + unit_0.Name + " cannot host the aircraft. To change the location, select a single base or ship that can host aircraft of this type, and try again.", MsgBoxStyle.OkOnly, null);
											return;
										}
									}
								}
								else
								{
									string_0 = unit_0.Name;
									string_1 = unit_0.string_0;
								}
								if (bool_5)
								{
									if (Enumerable.Count<Waypoint>(@class.flight_0.method_15()) > 0)
									{
										foreach (Waypoint waypoint in @class.flight_0.method_15())
										{
											if (waypoint.waypointType_0 == Waypoint.WaypointType.Assemble)
											{
												Waypoint waypoint2 = waypoint;
											}
											else if (waypoint.waypointType_0 == Waypoint.WaypointType.HoldStart)
											{
												Waypoint waypoint3 = waypoint;
											}
											else if (waypoint.waypointType_0 == Waypoint.WaypointType.HoldEnd)
											{
												Waypoint waypoint4 = waypoint;
											}
											else if (waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
											{
												Waypoint waypoint5 = waypoint;
											}
											else
											{
												Waypoint waypoint6 = waypoint;
												IL_356:
												Waypoint waypoint5;
												if (Information.IsNothing(waypoint5))
												{
													Interaction.MsgBox("Error! Could not find the take-off waypoint in the flightplan!", MsgBoxStyle.OkOnly, null);
													return;
												}
												waypoint5.imethod_3(unit_0.vmethod_30(null));
												waypoint5.imethod_1(unit_0.vmethod_28(null));
												if (Information.IsNothing(waypoint6))
												{
													goto IL_683;
												}
												float num = Math2.smethod_15(waypoint5.imethod_2(), waypoint5.imethod_0(), waypoint6.imethod_2(), waypoint6.imethod_0());
												float num2 = Math2.smethod_17(waypoint5.imethod_2(), waypoint5.imethod_0(), waypoint6.imethod_2(), waypoint6.imethod_0());
												float num3 = (float)GameGeneral.smethod_5().Next(-45, 45);
												Waypoint waypoint2;
												if (!Information.IsNothing(waypoint2))
												{
													Waypoint waypoint7;
													double double_3;
													Waypoint waypoint8;
													double double_4;
													if (num > 15f)
													{
														double double_ = waypoint5.imethod_0();
														double double_2 = waypoint5.imethod_2();
														double_3 = (waypoint7 = waypoint2).imethod_0();
														double_4 = (waypoint8 = waypoint2).imethod_2();
														Class411.smethod_1(double_, double_2, ref double_3, ref double_4, 10.0, (double)Math2.smethod_7(num2 + num3));
														waypoint8.imethod_3(double_4);
														waypoint7.imethod_1(double_3);
														goto IL_683;
													}
													double double_5 = waypoint5.imethod_0();
													double double_6 = waypoint5.imethod_2();
													double_4 = (waypoint8 = waypoint2).imethod_0();
													double_3 = (waypoint7 = waypoint2).imethod_2();
													Class411.smethod_1(double_5, double_6, ref double_4, ref double_3, 10.0, (double)Math2.smethod_7(num2 + 180f + num3));
													waypoint7.imethod_3(double_3);
													waypoint8.imethod_1(double_4);
													goto IL_683;
												}
												else
												{
													Waypoint waypoint3;
													Waypoint waypoint4;
													if (Information.IsNothing(waypoint3) || Information.IsNothing(waypoint4))
													{
														goto IL_683;
													}
													Waypoint waypoint7;
													double double_3;
													Waypoint waypoint8;
													double double_4;
													if (num > 30f)
													{
														double double_7 = waypoint5.imethod_0();
														double double_8 = waypoint5.imethod_2();
														double_3 = (waypoint7 = waypoint3).imethod_0();
														double_4 = (waypoint8 = waypoint3).imethod_2();
														Class411.smethod_1(double_7, double_8, ref double_3, ref double_4, 10.0, (double)Math2.smethod_7(num2 + num3));
														waypoint8.imethod_3(double_4);
														waypoint7.imethod_1(double_3);
														float float_ = Math2.smethod_17(waypoint3.imethod_2(), waypoint3.imethod_0(), waypoint6.imethod_2(), waypoint6.imethod_0());
														double double_9 = waypoint3.imethod_0();
														double double_10 = waypoint3.imethod_2();
														double_4 = (waypoint8 = waypoint4).imethod_0();
														double_3 = (waypoint7 = waypoint4).imethod_2();
														Class411.smethod_1(double_9, double_10, ref double_4, ref double_3, 10.0, (double)Math2.smethod_7(float_));
														waypoint7.imethod_3(double_3);
														waypoint8.imethod_1(double_4);
														goto IL_683;
													}
													double double_11 = waypoint5.imethod_0();
													double double_12 = waypoint5.imethod_2();
													double_3 = (waypoint7 = waypoint3).imethod_0();
													double_4 = (waypoint8 = waypoint3).imethod_2();
													Class411.smethod_1(double_11, double_12, ref double_3, ref double_4, 10.0, (double)Math2.smethod_7(num2 + 180f + num3));
													waypoint8.imethod_3(double_4);
													waypoint7.imethod_1(double_3);
													double double_13 = waypoint5.imethod_0();
													double double_14 = waypoint5.imethod_2();
													double_4 = (waypoint8 = waypoint4).imethod_0();
													double_3 = (waypoint7 = waypoint4).imethod_2();
													Class411.smethod_1(double_13, double_14, ref double_4, ref double_3, 20.0, (double)Math2.smethod_7(num2 + 180f + num3));
													waypoint7.imethod_3(double_3);
													waypoint8.imethod_1(double_4);
													goto IL_683;
												}
											}
										}
										goto IL_356;
									}
									IL_683:
									if (!Information.IsNothing(mission_1.list_2))
									{
										for (int j = mission_1.list_2.Count - 1; j >= 0; j += -1)
										{
											Mission.EmptyAircraftSlot emptyAircraftSlot = mission_1.list_2[j];
											if (Operators.CompareString(emptyAircraftSlot.string_2, @class.flight_0.string_0, false) == 0)
											{
												emptyAircraftSlot.method_4(scenario_0, (ActiveUnit)unit_0);
												emptyAircraftSlot.string_4 = unit_0.Name;
												emptyAircraftSlot.string_3 = unit_0.string_0;
											}
										}
									}
									@class.flight_0.method_33(scenario_0, null);
								}
								if (bool_6 && Enumerable.Count<Waypoint>(@class.flight_0.method_15()) > 0)
								{
									foreach (Waypoint waypoint9 in @class.flight_0.method_15())
									{
										if (waypoint9.waypointType_0 == Waypoint.WaypointType.LandingMarshal)
										{
											Waypoint waypoint10 = waypoint9;
										}
										else if (waypoint9.waypointType_0 == Waypoint.WaypointType.Land)
										{
											Waypoint waypoint11 = waypoint9;
											IL_77D:
											if (!Information.IsNothing(waypoint11))
											{
												waypoint11.imethod_3(unit_0.vmethod_30(null));
												waypoint11.imethod_1(unit_0.vmethod_28(null));
												Waypoint waypoint10;
												if (!aircraft.method_169() && !Information.IsNothing(waypoint10))
												{
													Geopoint_Struct geopoint_Struct = ((ActiveUnit)unit_0).vmethod_92().method_5();
													waypoint10.imethod_3(geopoint_Struct.double_1);
													waypoint10.imethod_1(geopoint_Struct.double_0);
												}
												List<ActiveUnit> list2 = new List<ActiveUnit>();
												list2.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(mission_1.method_15(scenario_0), new Func<ActiveUnit, bool>(@class.method_1))));
												try
												{
													foreach (ActiveUnit activeUnit2 in list2)
													{
														Aircraft aircraft2 = (Aircraft)activeUnit2;
														if (Operators.CompareString(@class.flight_0.string_7, aircraft2.method_164().method_32(false).string_0, false) != 0)
														{
															if (scenario_0.vmethod_0().ContainsKey(@class.flight_0.string_7))
															{
																aircraft2.method_164().method_33(false, scenario_0.vmethod_0()[@class.flight_0.string_7]);
															}
															else if (Debugger.IsAttached)
															{
																Debugger.Break();
															}
														}
													}
													goto IL_8E0;
												}
												finally
												{
													List<ActiveUnit>.Enumerator enumerator2;
													((IDisposable)enumerator2).Dispose();
												}
											}
											Interaction.MsgBox("Error! Could not find the land waypoint in the flightplan!", MsgBoxStyle.OkOnly, null);
											return;
										}
									}
									goto IL_77D;
								}
								IL_8E0:
								Scenario scenario_ = scenario_0;
								Mission mission = mission_1;
								ActiveUnit activeUnit_ = @class.flight_0.method_32(scenario_0);
								Mission.Flight flight = @class.flight_0;
								Mission.Flight flight2;
								Waypoint[] waypoint_ = (flight2 = @class.flight_0).method_15();
								float num4 = 0f;
								float num5 = 0f;
								Class514.smethod_28(scenario_, mission, activeUnit_, flight, ref waypoint_, ref num4, ref num5, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
								flight2.method_16(waypoint_);
							}
							else
							{
								Interaction.MsgBox("Error! No unit has been selected on the map. To change the location, select a single base or ship that can host aircraft of this type, and try again.", MsgBoxStyle.OkOnly, null);
							}
						}
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

		// Token: 0x04003CD2 RID: 15570
		[CompilerGenerated]
		[AccessedThroughProperty("TabControl_Aircraft")]
		private Control12 control12_0;

		// Token: 0x04003CD3 RID: 15571
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage1")]
		private TabPage tabPage_0;

		// Token: 0x04003CD4 RID: 15572
		[AccessedThroughProperty("TabPage2")]
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04003CD5 RID: 15573
		[AccessedThroughProperty("TabPage3")]
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x04003CD6 RID: 15574
		[AccessedThroughProperty("TabPage4")]
		[CompilerGenerated]
		private TabPage tabPage_3;

		// Token: 0x04003CD7 RID: 15575
		[AccessedThroughProperty("TabPage5")]
		[CompilerGenerated]
		private TabPage tabPage_4;

		// Token: 0x04003CD8 RID: 15576
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage6")]
		private TabPage tabPage_5;

		// Token: 0x04003CD9 RID: 15577
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label label_0;

		// Token: 0x04003CDA RID: 15578
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Label label_1;

		// Token: 0x04003CDB RID: 15579
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Label label_2;

		// Token: 0x04003CDC RID: 15580
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04003CDD RID: 15581
		[AccessedThroughProperty("Combo_CurrentPackage")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04003CDE RID: 15582
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_CurrentFlightPlan")]
		private Class2451 class2451_1;

		// Token: 0x04003CDF RID: 15583
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_FlightTask")]
		private Class2451 class2451_2;

		// Token: 0x04003CE0 RID: 15584
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_FlightCallsign")]
		private Control8 control8_0;

		// Token: 0x04003CE1 RID: 15585
		[CompilerGenerated]
		[AccessedThroughProperty("Button_CopyFlightplan")]
		private Button button_0;

		// Token: 0x04003CE2 RID: 15586
		[CompilerGenerated]
		[AccessedThroughProperty("Label_LaunchDateAndTime")]
		private Label label_4;

		// Token: 0x04003CE3 RID: 15587
		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Label label_5;

		// Token: 0x04003CE4 RID: 15588
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Label label_6;

		// Token: 0x04003CE5 RID: 15589
		[CompilerGenerated]
		[AccessedThroughProperty("FlightPlanWaypoints1")]
		private FlightPlanWaypoints flightPlanWaypoints_0;

		// Token: 0x04003CE6 RID: 15590
		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Label label_7;

		// Token: 0x04003CE7 RID: 15591
		[CompilerGenerated]
		[AccessedThroughProperty("FlightPlanWaypoints2")]
		private FlightPlanWaypoints flightPlanWaypoints_1;

		// Token: 0x04003CE8 RID: 15592
		[AccessedThroughProperty("FlightPlanWaypoints3")]
		[CompilerGenerated]
		private FlightPlanWaypoints flightPlanWaypoints_2;

		// Token: 0x04003CE9 RID: 15593
		[AccessedThroughProperty("FlightPlanWaypoints4")]
		[CompilerGenerated]
		private FlightPlanWaypoints flightPlanWaypoints_3;

		// Token: 0x04003CEA RID: 15594
		[AccessedThroughProperty("FlightPlanWaypoints5")]
		[CompilerGenerated]
		private FlightPlanWaypoints flightPlanWaypoints_4;

		// Token: 0x04003CEB RID: 15595
		[AccessedThroughProperty("FlightPlanWaypoints6")]
		[CompilerGenerated]
		private FlightPlanWaypoints flightPlanWaypoints_5;

		// Token: 0x04003CEC RID: 15596
		[AccessedThroughProperty("Button_FillEmptySlots")]
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04003CED RID: 15597
		[AccessedThroughProperty("Button_ClearSlots")]
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04003CEE RID: 15598
		[AccessedThroughProperty("Label_AircraftType")]
		[CompilerGenerated]
		private Label label_8;

		// Token: 0x04003CEF RID: 15599
		[AccessedThroughProperty("Label_LoadoutName")]
		[CompilerGenerated]
		private Label label_9;

		// Token: 0x04003CF0 RID: 15600
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ChangeAircraftType")]
		private Button button_3;

		// Token: 0x04003CF1 RID: 15601
		[CompilerGenerated]
		[AccessedThroughProperty("Label8")]
		private Label label_10;

		// Token: 0x04003CF2 RID: 15602
		[AccessedThroughProperty("Label_ObjectiveDateAndTime")]
		[CompilerGenerated]
		private Label label_11;

		// Token: 0x04003CF3 RID: 15603
		[CompilerGenerated]
		[AccessedThroughProperty("Label10")]
		private Label label_12;

		// Token: 0x04003CF4 RID: 15604
		[AccessedThroughProperty("Label_FlightStatus")]
		[CompilerGenerated]
		private Label label_13;

		// Token: 0x04003CF5 RID: 15605
		[AccessedThroughProperty("Button_CreateFlightplanSkeleton")]
		[CompilerGenerated]
		private Button button_4;

		// Token: 0x04003CF6 RID: 15606
		[CompilerGenerated]
		[AccessedThroughProperty("Button_DeleteFlightplan")]
		private Button button_5;

		// Token: 0x04003CF7 RID: 15607
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox_SelectedFlight")]
		private GroupBox groupBox_0;

		// Token: 0x04003CF8 RID: 15608
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_FlightplanType")]
		private Class2451 class2451_3;

		// Token: 0x04003CF9 RID: 15609
		[CompilerGenerated]
		[AccessedThroughProperty("Label9")]
		private Label label_14;

		// Token: 0x04003CFA RID: 15610
		[CompilerGenerated]
		[AccessedThroughProperty("Label11")]
		private Label label_15;

		// Token: 0x04003CFB RID: 15611
		[AccessedThroughProperty("Label1_LandingLocation")]
		[CompilerGenerated]
		private Label label_16;

		// Token: 0x04003CFC RID: 15612
		[AccessedThroughProperty("Label13")]
		[CompilerGenerated]
		private Label label_17;

		// Token: 0x04003CFD RID: 15613
		[CompilerGenerated]
		[AccessedThroughProperty("Label_TakeOffLocation")]
		private Label label_18;

		// Token: 0x04003CFE RID: 15614
		[AccessedThroughProperty("Label15")]
		[CompilerGenerated]
		private Label label_19;

		// Token: 0x04003CFF RID: 15615
		[AccessedThroughProperty("Label_DiversionAirfield")]
		[CompilerGenerated]
		private Label label_20;

		// Token: 0x04003D00 RID: 15616
		[AccessedThroughProperty("Button_ChangeTakeOffTime")]
		[CompilerGenerated]
		private Button button_6;

		// Token: 0x04003D01 RID: 15617
		[AccessedThroughProperty("Button_ChangeObjectiveTime")]
		[CompilerGenerated]
		private Button button_7;

		// Token: 0x04003D02 RID: 15618
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ChangeTakeOffLocation")]
		private Button button_8;

		// Token: 0x04003D03 RID: 15619
		[AccessedThroughProperty("Button_ChangeLandingLocation")]
		[CompilerGenerated]
		private Button button_9;

		// Token: 0x04003D04 RID: 15620
		[AccessedThroughProperty("Button_ChangeDiversionLocation")]
		[CompilerGenerated]
		private Button button_10;

		// Token: 0x04003D05 RID: 15621
		[AccessedThroughProperty("Button_CreateFlightplanFull")]
		[CompilerGenerated]
		private Button button_11;

		// Token: 0x04003D06 RID: 15622
		public bool bool_3;

		// Token: 0x04003D07 RID: 15623
		public Mission mission_0;

		// Token: 0x04003D08 RID: 15624
		public Mission.Flight flight_0;

		// Token: 0x04003D09 RID: 15625
		public Waypoint waypoint_0;

		// Token: 0x04003D0A RID: 15626
		public int int_0;

		// Token: 0x04003D0B RID: 15627
		private bool bool_4;

		// Token: 0x04003D0C RID: 15628
		public FlightPlanWaypoints flightPlanWaypoints_6;

		// Token: 0x04003D0D RID: 15629
		private TabPage tabPage_6;

		// Token: 0x04003D0E RID: 15630
		private TabPage tabPage_7;

		// Token: 0x04003D0F RID: 15631
		private TabPage tabPage_8;

		// Token: 0x04003D10 RID: 15632
		private TabPage tabPage_9;

		// Token: 0x04003D11 RID: 15633
		private TabPage tabPage_10;

		// Token: 0x04003D12 RID: 15634
		private TabPage tabPage_11;

		// Token: 0x04003D13 RID: 15635
		private DataTable dataTable_0;

		// Token: 0x04003D14 RID: 15636
		private DataTable dataTable_1;

		// Token: 0x04003D15 RID: 15637
		private DataTable dataTable_2;

		// Token: 0x04003D16 RID: 15638
		private DataTable dataTable_3;

		// Token: 0x04003D17 RID: 15639
		private DataTable dataTable_4;

		// Token: 0x04003D18 RID: 15640
		private DataTable dataTable_5;

		// Token: 0x04003D19 RID: 15641
		private DataTable dataTable_6;

		// Token: 0x04003D1A RID: 15642
		private int int_1;

		// Token: 0x04003D1B RID: 15643
		private int int_2;

		// Token: 0x04003D1C RID: 15644
		private int int_3;

		// Token: 0x04003D1D RID: 15645
		private int int_4;

		// Token: 0x04003D1E RID: 15646
		private int int_5;

		// Token: 0x04003D1F RID: 15647
		private int int_6;

		// Token: 0x04003D20 RID: 15648
		private int int_7;

		// Token: 0x04003D21 RID: 15649
		private int int_8;

		// Token: 0x04003D22 RID: 15650
		private int int_9;

		// Token: 0x04003D23 RID: 15651
		private int int_10;

		// Token: 0x04003D24 RID: 15652
		private int int_11;

		// Token: 0x04003D25 RID: 15653
		private int int_12;

		// Token: 0x04003D26 RID: 15654
		private int int_13;

		// Token: 0x04003D27 RID: 15655
		private int int_14;

		// Token: 0x04003D28 RID: 15656
		private int int_15;

		// Token: 0x04003D29 RID: 15657
		private int int_16;

		// Token: 0x04003D2A RID: 15658
		private int int_17;

		// Token: 0x04003D2B RID: 15659
		private int int_18;

		// Token: 0x04003D2C RID: 15660
		private int int_19;

		// Token: 0x04003D2D RID: 15661
		private int int_20;

		// Token: 0x04003D2E RID: 15662
		private int int_21;

		// Token: 0x04003D2F RID: 15663
		private int int_22;

		// Token: 0x04003D30 RID: 15664
		private int int_23;

		// Token: 0x04003D31 RID: 15665
		private int int_24;

		// Token: 0x04003D32 RID: 15666
		private int int_25;

		// Token: 0x04003D33 RID: 15667
		private int int_26;

		// Token: 0x04003D34 RID: 15668
		private int int_27;

		// Token: 0x04003D35 RID: 15669
		private DataTable dataTable_7;

		// Token: 0x04003D36 RID: 15670
		private DataTable dataTable_8;

		// Token: 0x04003D37 RID: 15671
		private DataTable dataTable_9;

		// Token: 0x04003D38 RID: 15672
		private DataTable dataTable_10;

		// Token: 0x04003D39 RID: 15673
		private DataTable dataTable_11;

		// Token: 0x04003D3A RID: 15674
		private DataTable dataTable_12;

		// Token: 0x04003D3B RID: 15675
		public Bitmap bitmap_0;

		// Token: 0x04003D3C RID: 15676
		public Bitmap bitmap_1;

		// Token: 0x04003D3D RID: 15677
		public Bitmap bitmap_2;

		// Token: 0x04003D3E RID: 15678
		public Bitmap bitmap_3;

		// Token: 0x04003D3F RID: 15679
		public Bitmap bitmap_4;

		// Token: 0x02000E1B RID: 3611
		[CompilerGenerated]
		internal sealed class Class2465
		{
			// Token: 0x06006B19 RID: 27417 RVA: 0x00043AE0 File Offset: 0x00041CE0
			public Class2465(FlightPlanEditor.Class2465 class2465_0)
			{
				if (class2465_0 != null)
				{
					this.flight_0 = class2465_0.flight_0;
				}
			}

			// Token: 0x06006B1A RID: 27418 RVA: 0x00043AF7 File Offset: 0x00041CF7
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.vmethod_85().method_48() && activeUnit_0.bool_3 && !activeUnit_0.vmethod_127() && activeUnit_0.vmethod_85().method_7() == this.flight_0;
			}

			// Token: 0x06006B1B RID: 27419 RVA: 0x00043B2B File Offset: 0x00041D2B
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.vmethod_85().method_48() && activeUnit_0.bool_3 && activeUnit_0.vmethod_127() && activeUnit_0.vmethod_85().method_7() == this.flight_0;
			}

			// Token: 0x04003D40 RID: 15680
			public Mission.Flight flight_0;
		}
	}
}
