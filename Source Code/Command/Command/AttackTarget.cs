using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns13;
using ns14;
using ns2;
using ns4;
using ns5;
using ns8;

namespace Command
{
	// Token: 0x02000F35 RID: 3893
	[DesignerGenerated]
	public sealed partial class AttackTarget : DarkSecondaryFormBase, Interface66
	{
		// Token: 0x06008B10 RID: 35600 RVA: 0x004ACF20 File Offset: 0x004AB120
		public AttackTarget()
		{
			base.FormClosing += this.AttackTarget_FormClosing;
			base.Load += this.AttackTarget_Load;
			base.KeyDown += this.AttackTarget_KeyDown;
			this.list_0 = new List<Contact>();
			this.list_1 = new List<ActiveUnit>();
			this.list_2 = new List<ActiveUnit>();
			this.list_3 = new List<Contact>();
			this.bool_4 = true;
			this.InitializeComponent_1();
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x004ACFE4 File Offset: 0x004AB1E4
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			this.vmethod_17(new Timer(this.icontainer_1));
			this.vmethod_59(new TableLayoutPanel());
			this.vmethod_61(new Panel());
			this.vmethod_49(new Control9());
			this.vmethod_31(new Class116());
			this.vmethod_33(new Control4());
			this.vmethod_43(new Control9());
			this.vmethod_45(new Control9());
			this.vmethod_63(new Panel());
			this.vmethod_73(new Class112());
			this.vmethod_71(new Class112());
			this.vmethod_53(new Control9());
			this.vmethod_41(new Control9());
			this.vmethod_35(new Class116());
			this.vmethod_39(new Control9());
			this.vmethod_85(new Class120());
			this.vmethod_37(new Control6());
			this.vmethod_65(new Panel());
			this.vmethod_75(new Control9());
			this.vmethod_77(new Control9());
			this.vmethod_57(new Control9());
			this.vmethod_21(new Control12());
			this.vmethod_23(new TabPage());
			this.vmethod_25(new Control6());
			this.vmethod_27(new TabPage());
			this.vmethod_29(new Control6());
			this.vmethod_19(new Class116());
			this.vmethod_67(new Panel());
			this.vmethod_79(new Control9());
			this.vmethod_55(new Control9());
			this.vmethod_81(new Control9());
			this.vmethod_5(new Control12());
			this.vmethod_7(new TabPage());
			this.vmethod_13(new Control6());
			this.vmethod_9(new TabPage());
			this.vmethod_15(new Control6());
			this.vmethod_3(new Class116());
			this.vmethod_69(new Panel());
			this.vmethod_51(new Control9());
			this.vmethod_47(new Control9());
			this.vmethod_11(new Control4());
			this.vmethod_1(new Class116());
			this.vmethod_83(new Class113());
			this.vmethod_87(new Class128());
			this.vmethod_58().SuspendLayout();
			this.vmethod_60().SuspendLayout();
			this.vmethod_62().SuspendLayout();
			((ISupportInitialize)this.vmethod_84()).BeginInit();
			this.vmethod_64().SuspendLayout();
			this.vmethod_20().SuspendLayout();
			this.vmethod_22().SuspendLayout();
			this.vmethod_26().SuspendLayout();
			this.vmethod_66().SuspendLayout();
			this.vmethod_4().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			this.vmethod_68().SuspendLayout();
			this.vmethod_82().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_58().ColumnCount = 3;
			this.vmethod_58().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32f));
			this.vmethod_58().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36f));
			this.vmethod_58().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32f));
			this.vmethod_58().Controls.Add(this.vmethod_60(), 0, 0);
			this.vmethod_58().Controls.Add(this.vmethod_62(), 1, 0);
			this.vmethod_58().Controls.Add(this.vmethod_64(), 2, 0);
			this.vmethod_58().Controls.Add(this.vmethod_66(), 2, 1);
			this.vmethod_58().Controls.Add(this.vmethod_68(), 0, 1);
			this.vmethod_58().Dock = DockStyle.Fill;
			this.vmethod_58().Location = new Point(0, 0);
			this.vmethod_58().Name = "TableLayoutPanel1";
			this.vmethod_58().RowCount = 2;
			this.vmethod_58().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.vmethod_58().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.vmethod_58().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.vmethod_58().Size = new Size(1008, 661);
			this.vmethod_58().TabIndex = 17;
			this.vmethod_60().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_60().Controls.Add(this.vmethod_48());
			this.vmethod_60().Controls.Add(this.vmethod_30());
			this.vmethod_60().Controls.Add(this.vmethod_32());
			this.vmethod_60().Controls.Add(this.vmethod_42());
			this.vmethod_60().Controls.Add(this.vmethod_44());
			this.vmethod_60().Location = new Point(3, 3);
			this.vmethod_60().Name = "Panel1";
			this.vmethod_60().Size = new Size(316, 324);
			this.vmethod_60().TabIndex = 0;
			this.vmethod_48().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_48().BackColor = Color.Transparent;
			this.vmethod_48().DialogResult = DialogResult.None;
			this.vmethod_48().Font = new Font("Segoe UI", 10f);
			this.vmethod_48().ForeColor = SystemColors.Control;
			this.vmethod_48().Location = new Point(-1, 302);
			this.vmethod_48().Name = "Button_RemoveAttacker";
			this.vmethod_48().method_1(0);
			this.vmethod_48().Size = new Size(317, 23);
			this.vmethod_48().TabIndex = 11;
			this.vmethod_48().Text = "Remove selected unit(s) from list";
			this.vmethod_30().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_30().method_2(true);
			this.vmethod_30().Font = new Font("Segoe UI", 12f);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Location = new Point(0, 0);
			this.vmethod_30().Name = "Label1";
			this.vmethod_30().Size = new Size(123, 21);
			this.vmethod_30().TabIndex = 1;
			this.vmethod_30().Text = "Attacking unit(s)";
			this.vmethod_32().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_32().Font = new Font("Segoe UI", 9f);
			this.vmethod_32().method_23(15);
			this.vmethod_32().Location = new Point(0, 25);
			this.vmethod_32().Name = "LB_Attackers";
			this.vmethod_32().Size = new Size(315, 230);
			this.vmethod_32().TabIndex = 2;
			this.vmethod_42().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_42().BackColor = Color.Transparent;
			this.vmethod_42().DialogResult = DialogResult.None;
			this.vmethod_42().Font = new Font("Segoe UI", 10f);
			this.vmethod_42().ForeColor = SystemColors.Control;
			this.vmethod_42().Location = new Point(-1, 256);
			this.vmethod_42().Name = "Button_UnitWRA";
			this.vmethod_42().method_1(0);
			this.vmethod_42().Size = new Size(317, 23);
			this.vmethod_42().TabIndex = 8;
			this.vmethod_42().Text = "Weapon Release Authorization (WRA)";
			this.vmethod_44().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_44().BackColor = Color.Transparent;
			this.vmethod_44().DialogResult = DialogResult.None;
			this.vmethod_44().Font = new Font("Segoe UI", 10f);
			this.vmethod_44().ForeColor = SystemColors.Control;
			this.vmethod_44().Location = new Point(-1, 279);
			this.vmethod_44().Name = "Button_AddAttacker";
			this.vmethod_44().method_1(0);
			this.vmethod_44().Size = new Size(317, 23);
			this.vmethod_44().TabIndex = 9;
			this.vmethod_44().Text = "Add selected unit(s) from tactical map";
			this.vmethod_62().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_62().Controls.Add(this.vmethod_72());
			this.vmethod_62().Controls.Add(this.vmethod_70());
			this.vmethod_62().Controls.Add(this.vmethod_52());
			this.vmethod_62().Controls.Add(this.vmethod_40());
			this.vmethod_62().Controls.Add(this.vmethod_34());
			this.vmethod_62().Controls.Add(this.vmethod_38());
			this.vmethod_62().Controls.Add(this.vmethod_84());
			this.vmethod_62().Controls.Add(this.vmethod_36());
			this.vmethod_62().Location = new Point(325, 3);
			this.vmethod_62().Name = "Panel2";
			this.vmethod_58().SetRowSpan(this.vmethod_62(), 2);
			this.vmethod_62().Size = new Size(356, 655);
			this.vmethod_62().TabIndex = 1;
			this.vmethod_72().Location = new Point(167, 4);
			this.vmethod_72().Name = "CB_ShowAutomaticFireInfo";
			this.vmethod_72().Size = new Size(190, 17);
			this.vmethod_72().TabIndex = 15;
			this.vmethod_72().Text = "Show Automatic Fire Information";
			this.vmethod_70().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_70().Font = new Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_70().Location = new Point(74, 631);
			this.vmethod_70().MaximumSize = new Size(350, 0);
			this.vmethod_70().Name = "CB_AllowTimeout";
			this.vmethod_70().Size = new Size(186, 15);
			this.vmethod_70().TabIndex = 14;
			this.vmethod_70().Text = "Allow automatic salvo timeout";
			this.vmethod_52().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_52().BackColor = Color.Transparent;
			this.vmethod_52().DialogResult = DialogResult.None;
			this.vmethod_52().Font = new Font("Segoe UI", 10f);
			this.vmethod_52().ForeColor = SystemColors.Control;
			this.vmethod_52().Location = new Point(-1, 573);
			this.vmethod_52().Name = "Button_AllocateSalvo";
			this.vmethod_52().method_1(0);
			this.vmethod_52().Size = new Size(357, 23);
			this.vmethod_52().TabIndex = 13;
			this.vmethod_52().Text = "Allocate one salvo to selected target(s)";
			this.vmethod_40().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_40().BackColor = Color.Transparent;
			this.vmethod_40().DialogResult = DialogResult.None;
			this.vmethod_40().Font = new Font("Segoe UI", 10f);
			this.vmethod_40().ForeColor = SystemColors.Control;
			this.vmethod_40().Location = new Point(-1, 602);
			this.vmethod_40().Name = "Button_AllocateAllWeapons";
			this.vmethod_40().method_1(0);
			this.vmethod_40().Size = new Size(357, 23);
			this.vmethod_40().TabIndex = 6;
			this.vmethod_40().Text = "Allocate all weapons of this type";
			this.vmethod_34().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_34().method_2(true);
			this.vmethod_34().Font = new Font("Segoe UI", 12f);
			this.vmethod_34().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_34().Location = new Point(0, 0);
			this.vmethod_34().Name = "Label5";
			this.vmethod_34().Size = new Size(132, 21);
			this.vmethod_34().TabIndex = 3;
			this.vmethod_34().Text = "Suitable weapons";
			this.vmethod_38().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_38().BackColor = Color.Transparent;
			this.vmethod_38().DialogResult = DialogResult.None;
			this.vmethod_38().Font = new Font("Segoe UI", 10f);
			this.vmethod_38().ForeColor = SystemColors.Control;
			this.vmethod_38().Location = new Point(-1, 541);
			this.vmethod_38().Name = "Button_Allocate";
			this.vmethod_38().method_1(0);
			this.vmethod_38().Size = new Size(279, 26);
			this.vmethod_38().TabIndex = 5;
			this.vmethod_38().Text = "Allocate weapons to selected target(s):";
			this.vmethod_84().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_84().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_84().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_84().Font = new Font("Segoe UI", 10f);
			this.vmethod_84().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_84().Location = new Point(278, 541);
			this.vmethod_84().Name = "NUD_NumberOfWeapons";
			this.vmethod_84().Size = new Size(75, 25);
			this.vmethod_84().TabIndex = 7;
			this.vmethod_36().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_36().Font = new Font("Segoe UI", 9f);
			this.vmethod_36().Location = new Point(0, 25);
			this.vmethod_36().method_6(20);
			this.vmethod_36().Name = "TV_AvailableWeapons";
			this.vmethod_36().Size = new Size(355, 510);
			this.vmethod_36().TabIndex = 4;
			this.vmethod_64().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_64().Controls.Add(this.vmethod_74());
			this.vmethod_64().Controls.Add(this.vmethod_76());
			this.vmethod_64().Controls.Add(this.vmethod_56());
			this.vmethod_64().Controls.Add(this.vmethod_20());
			this.vmethod_64().Controls.Add(this.vmethod_18());
			this.vmethod_64().Location = new Point(687, 3);
			this.vmethod_64().Name = "Panel3";
			this.vmethod_64().Size = new Size(318, 324);
			this.vmethod_64().TabIndex = 2;
			this.vmethod_74().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_74().BackColor = Color.Transparent;
			this.vmethod_74().DialogResult = DialogResult.None;
			this.vmethod_74().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_74().ForeColor = SystemColors.Control;
			this.vmethod_74().Location = new Point(83, 302);
			this.vmethod_74().Name = "Button_ClearCourse_Attacker";
			this.vmethod_74().method_1(0);
			this.vmethod_74().Size = new Size(76, 23);
			this.vmethod_74().TabIndex = 17;
			this.vmethod_74().Text = "Clear course";
			this.vmethod_76().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_76().BackColor = Color.Transparent;
			this.vmethod_76().DialogResult = DialogResult.None;
			this.vmethod_76().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_76().ForeColor = SystemColors.Control;
			this.vmethod_76().Location = new Point(4, 302);
			this.vmethod_76().Name = "Button_PlotCourse_Attacker";
			this.vmethod_76().method_1(0);
			this.vmethod_76().Size = new Size(73, 23);
			this.vmethod_76().TabIndex = 16;
			this.vmethod_76().Text = "Plot course";
			this.vmethod_56().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_56().BackColor = Color.Transparent;
			this.vmethod_56().DialogResult = DialogResult.None;
			this.vmethod_56().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_56().ForeColor = SystemColors.Control;
			this.vmethod_56().Location = new Point(207, 302);
			this.vmethod_56().Name = "Button_RemoveWeapons_Attacker";
			this.vmethod_56().method_1(0);
			this.vmethod_56().Size = new Size(112, 23);
			this.vmethod_56().TabIndex = 15;
			this.vmethod_56().Text = "De-allocate selected";
			this.vmethod_20().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_20().Controls.Add(this.vmethod_22());
			this.vmethod_20().Controls.Add(this.vmethod_26());
			this.vmethod_20().Cursor = Cursors.Hand;
			this.vmethod_20().Font = new Font("Segoe UI", 10f);
			this.vmethod_20().ItemSize = new Size(80, 20);
			this.vmethod_20().Location = new Point(0, 25);
			this.vmethod_20().Name = "TabControl2";
			this.vmethod_20().SelectedIndex = 0;
			this.vmethod_20().Size = new Size(318, 276);
			this.vmethod_20().TabIndex = 2;
			this.vmethod_22().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_22().Controls.Add(this.vmethod_24());
			this.vmethod_22().Location = new Point(4, 24);
			this.vmethod_22().Name = "Tab_Attacker_ToSelectedOnly";
			this.vmethod_22().Padding = new Padding(3);
			this.vmethod_22().Size = new Size(310, 248);
			this.vmethod_22().TabIndex = 0;
			this.vmethod_22().Text = "To selected target only";
			this.vmethod_24().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_24().Dock = DockStyle.Fill;
			this.vmethod_24().Font = new Font("Segoe UI", 9f);
			this.vmethod_24().Location = new Point(3, 3);
			this.vmethod_24().method_6(20);
			this.vmethod_24().Name = "TV_Allocations_ToTargetsOnly";
			this.vmethod_24().Size = new Size(304, 242);
			this.vmethod_24().TabIndex = 5;
			this.vmethod_26().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_26().Controls.Add(this.vmethod_28());
			this.vmethod_26().Location = new Point(4, 24);
			this.vmethod_26().Name = "Tab_Attacker_ToAnyone";
			this.vmethod_26().Padding = new Padding(3);
			this.vmethod_26().Size = new Size(310, 248);
			this.vmethod_26().TabIndex = 1;
			this.vmethod_26().Text = "To anyone";
			this.vmethod_28().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_28().Dock = DockStyle.Fill;
			this.vmethod_28().Font = new Font("Segoe UI", 9f);
			this.vmethod_28().Location = new Point(3, 3);
			this.vmethod_28().method_6(20);
			this.vmethod_28().Name = "TV_Allocations_ToAnyone";
			this.vmethod_28().Size = new Size(304, 242);
			this.vmethod_28().TabIndex = 6;
			this.vmethod_18().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_18().method_2(true);
			this.vmethod_18().Font = new Font("Segoe UI", 12f);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(0, 0);
			this.vmethod_18().Name = "Label2";
			this.vmethod_18().Size = new Size(297, 21);
			this.vmethod_18().TabIndex = 3;
			this.vmethod_18().Text = "Weapons allocated by selected attacker(s)";
			this.vmethod_66().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_66().Controls.Add(this.vmethod_78());
			this.vmethod_66().Controls.Add(this.vmethod_54());
			this.vmethod_66().Controls.Add(this.vmethod_80());
			this.vmethod_66().Controls.Add(this.vmethod_4());
			this.vmethod_66().Controls.Add(this.vmethod_2());
			this.vmethod_66().Location = new Point(687, 333);
			this.vmethod_66().Name = "Panel4";
			this.vmethod_66().Size = new Size(318, 325);
			this.vmethod_66().TabIndex = 3;
			this.vmethod_78().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_78().BackColor = Color.Transparent;
			this.vmethod_78().DialogResult = DialogResult.None;
			this.vmethod_78().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_78().ForeColor = SystemColors.Control;
			this.vmethod_78().Location = new Point(83, 302);
			this.vmethod_78().Name = "Button_ClearCourse_Target";
			this.vmethod_78().method_1(0);
			this.vmethod_78().Size = new Size(76, 23);
			this.vmethod_78().TabIndex = 19;
			this.vmethod_78().Text = "Clear course";
			this.vmethod_54().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_54().BackColor = Color.Transparent;
			this.vmethod_54().DialogResult = DialogResult.None;
			this.vmethod_54().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_54().ForeColor = SystemColors.Control;
			this.vmethod_54().Location = new Point(207, 303);
			this.vmethod_54().Name = "Button_RemoveWeapons_Target";
			this.vmethod_54().method_1(0);
			this.vmethod_54().Size = new Size(112, 23);
			this.vmethod_54().TabIndex = 14;
			this.vmethod_54().Text = "De-allocate selected";
			this.vmethod_80().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_80().BackColor = Color.Transparent;
			this.vmethod_80().DialogResult = DialogResult.None;
			this.vmethod_80().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_80().ForeColor = SystemColors.Control;
			this.vmethod_80().Location = new Point(4, 302);
			this.vmethod_80().Name = "Button_PlotCourse_Target";
			this.vmethod_80().method_1(0);
			this.vmethod_80().Size = new Size(73, 23);
			this.vmethod_80().TabIndex = 18;
			this.vmethod_80().Text = "Plot course";
			this.vmethod_4().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_4().Controls.Add(this.vmethod_6());
			this.vmethod_4().Controls.Add(this.vmethod_8());
			this.vmethod_4().Cursor = Cursors.Hand;
			this.vmethod_4().Font = new Font("Segoe UI", 10f);
			this.vmethod_4().ItemSize = new Size(80, 20);
			this.vmethod_4().Location = new Point(0, 25);
			this.vmethod_4().Name = "TabControl4";
			this.vmethod_4().SelectedIndex = 0;
			this.vmethod_4().Size = new Size(318, 277);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().Controls.Add(this.vmethod_12());
			this.vmethod_6().Location = new Point(4, 24);
			this.vmethod_6().Name = "Tab_Target_BySelected";
			this.vmethod_6().Padding = new Padding(3);
			this.vmethod_6().Size = new Size(310, 249);
			this.vmethod_6().TabIndex = 0;
			this.vmethod_6().Text = "By selected attacker(s) only";
			this.vmethod_12().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_12().Dock = DockStyle.Fill;
			this.vmethod_12().Font = new Font("Segoe UI", 9f);
			this.vmethod_12().Location = new Point(3, 3);
			this.vmethod_12().method_6(20);
			this.vmethod_12().Name = "TV_Allocations_ByAttackersOnly";
			this.vmethod_12().Size = new Size(304, 243);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().Controls.Add(this.vmethod_14());
			this.vmethod_8().Location = new Point(4, 24);
			this.vmethod_8().Name = "Tab_Target_ByAnyone";
			this.vmethod_8().Padding = new Padding(3);
			this.vmethod_8().Size = new Size(310, 249);
			this.vmethod_8().TabIndex = 1;
			this.vmethod_8().Text = "By anyone";
			this.vmethod_14().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_14().Dock = DockStyle.Fill;
			this.vmethod_14().Font = new Font("Segoe UI", 9f);
			this.vmethod_14().Location = new Point(3, 3);
			this.vmethod_14().method_6(20);
			this.vmethod_14().Name = "TV_Allocations_ByAnyone";
			this.vmethod_14().Size = new Size(304, 243);
			this.vmethod_14().TabIndex = 7;
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().method_2(true);
			this.vmethod_2().Font = new Font("Segoe UI", 12f);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(0, 0);
			this.vmethod_2().Name = "Label4";
			this.vmethod_2().Size = new Size(263, 21);
			this.vmethod_2().TabIndex = 3;
			this.vmethod_2().Text = "Weapons allocated to selected target";
			this.vmethod_68().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_68().Controls.Add(this.vmethod_50());
			this.vmethod_68().Controls.Add(this.vmethod_46());
			this.vmethod_68().Controls.Add(this.vmethod_10());
			this.vmethod_68().Controls.Add(this.vmethod_0());
			this.vmethod_68().Location = new Point(3, 333);
			this.vmethod_68().Name = "Panel5";
			this.vmethod_68().Size = new Size(316, 325);
			this.vmethod_68().TabIndex = 4;
			this.vmethod_50().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_50().BackColor = Color.Transparent;
			this.vmethod_50().DialogResult = DialogResult.None;
			this.vmethod_50().Font = new Font("Segoe UI", 10f);
			this.vmethod_50().ForeColor = SystemColors.Control;
			this.vmethod_50().Location = new Point(-1, 303);
			this.vmethod_50().Name = "Button_RemoveTargets";
			this.vmethod_50().method_1(0);
			this.vmethod_50().Size = new Size(317, 23);
			this.vmethod_50().TabIndex = 12;
			this.vmethod_50().Text = "Remove selected target(s) from list";
			this.vmethod_46().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_46().BackColor = Color.Transparent;
			this.vmethod_46().DialogResult = DialogResult.None;
			this.vmethod_46().Font = new Font("Segoe UI", 10f);
			this.vmethod_46().ForeColor = SystemColors.Control;
			this.vmethod_46().Location = new Point(-1, 280);
			this.vmethod_46().Name = "Button_AddTarget";
			this.vmethod_46().method_1(0);
			this.vmethod_46().Size = new Size(317, 23);
			this.vmethod_46().TabIndex = 10;
			this.vmethod_46().Text = "Add selected targets(s) from tactical map";
			this.vmethod_10().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_10().Font = new Font("Segoe UI", 9f);
			this.vmethod_10().method_23(15);
			this.vmethod_10().Location = new Point(0, 25);
			this.vmethod_10().method_25(true);
			this.vmethod_10().Name = "LB_Targets";
			this.vmethod_10().Size = new Size(315, 254);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().method_2(true);
			this.vmethod_0().Font = new Font("Segoe UI", 12f);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "Label3";
			this.vmethod_0().Size = new Size(142, 21);
			this.vmethod_0().TabIndex = 3;
			this.vmethod_0().Text = "Selectable target(s)";
			this.vmethod_82().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_82().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_82().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_86()
			});
			this.vmethod_82().Name = "ContextMenuStrip1";
			this.vmethod_82().Size = new Size(251, 26);
			this.vmethod_86().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_86().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_86().Name = "TSMI_HighAltitudeDetonation";
			this.vmethod_86().Size = new Size(250, 22);
			this.vmethod_86().Text = "Special: High Altitude Detonation";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1008, 661);
			base.Controls.Add(this.vmethod_58());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AttackTarget";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Weapon Allocation";
			this.vmethod_58().ResumeLayout(false);
			this.vmethod_60().ResumeLayout(false);
			this.vmethod_60().PerformLayout();
			this.vmethod_62().ResumeLayout(false);
			this.vmethod_62().PerformLayout();
			((ISupportInitialize)this.vmethod_84()).EndInit();
			this.vmethod_64().ResumeLayout(false);
			this.vmethod_64().PerformLayout();
			this.vmethod_20().ResumeLayout(false);
			this.vmethod_22().ResumeLayout(false);
			this.vmethod_26().ResumeLayout(false);
			this.vmethod_66().ResumeLayout(false);
			this.vmethod_66().PerformLayout();
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_68().ResumeLayout(false);
			this.vmethod_68().PerformLayout();
			this.vmethod_82().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x0005333A File Offset: 0x0005153A
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x00053342 File Offset: 0x00051542
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_5)
		{
			this.class116_0 = class116_5;
		}

		// Token: 0x06008B15 RID: 35605 RVA: 0x0005334B File Offset: 0x0005154B
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_1;
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x00053353 File Offset: 0x00051553
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_5)
		{
			this.class116_1 = class116_5;
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x0005335C File Offset: 0x0005155C
		[CompilerGenerated]
		internal Control12 vmethod_4()
		{
			return this.control12_0;
		}

		// Token: 0x06008B18 RID: 35608 RVA: 0x004AF148 File Offset: 0x004AD348
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control12 control12_2)
		{
			EventHandler value = new EventHandler(this.method_37);
			Control12 control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged -= value;
			}
			this.control12_0 = control12_2;
			control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06008B19 RID: 35609 RVA: 0x00053364 File Offset: 0x00051564
		[CompilerGenerated]
		internal TabPage vmethod_6()
		{
			return this.tabPage_0;
		}

		// Token: 0x06008B1A RID: 35610 RVA: 0x0005336C File Offset: 0x0005156C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TabPage tabPage_4)
		{
			this.tabPage_0 = tabPage_4;
		}

		// Token: 0x06008B1B RID: 35611 RVA: 0x00053375 File Offset: 0x00051575
		[CompilerGenerated]
		internal TabPage vmethod_8()
		{
			return this.tabPage_1;
		}

		// Token: 0x06008B1C RID: 35612 RVA: 0x0005337D File Offset: 0x0005157D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TabPage tabPage_4)
		{
			this.tabPage_1 = tabPage_4;
		}

		// Token: 0x06008B1D RID: 35613 RVA: 0x00053386 File Offset: 0x00051586
		[CompilerGenerated]
		internal Control4 vmethod_10()
		{
			return this.control4_0;
		}

		// Token: 0x06008B1E RID: 35614 RVA: 0x004AF18C File Offset: 0x004AD38C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control4 control4_2)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_16);
			Control4 control = this.control4_0;
			if (control != null)
			{
				control.method_17(eventHandler_);
			}
			this.control4_0 = control4_2;
			control = this.control4_0;
			if (control != null)
			{
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06008B1F RID: 35615 RVA: 0x0005338E File Offset: 0x0005158E
		[CompilerGenerated]
		internal Control6 vmethod_12()
		{
			return this.control6_0;
		}

		// Token: 0x06008B20 RID: 35616 RVA: 0x004AF1D0 File Offset: 0x004AD3D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control6 control6_5)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_47);
			MouseEventHandler value2 = new MouseEventHandler(this.method_54);
			EventHandler eventHandler_ = new EventHandler(this.method_57);
			Control6 control = this.control6_0;
			if (control != null)
			{
				control.MouseClick -= value;
				control.MouseDoubleClick -= value2;
				control.method_17(eventHandler_);
			}
			this.control6_0 = control6_5;
			control = this.control6_0;
			if (control != null)
			{
				control.MouseClick += value;
				control.MouseDoubleClick += value2;
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06008B21 RID: 35617 RVA: 0x00053396 File Offset: 0x00051596
		[CompilerGenerated]
		internal Control6 vmethod_14()
		{
			return this.control6_1;
		}

		// Token: 0x06008B22 RID: 35618 RVA: 0x004AF24C File Offset: 0x004AD44C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control6 control6_5)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_46);
			MouseEventHandler value2 = new MouseEventHandler(this.method_55);
			EventHandler eventHandler_ = new EventHandler(this.method_59);
			Control6 control = this.control6_1;
			if (control != null)
			{
				control.MouseClick -= value;
				control.MouseDoubleClick -= value2;
				control.method_17(eventHandler_);
			}
			this.control6_1 = control6_5;
			control = this.control6_1;
			if (control != null)
			{
				control.MouseClick += value;
				control.MouseDoubleClick += value2;
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06008B23 RID: 35619 RVA: 0x0005339E File Offset: 0x0005159E
		[CompilerGenerated]
		internal Timer vmethod_16()
		{
			return this.timer_0;
		}

		// Token: 0x06008B24 RID: 35620 RVA: 0x004AF2C8 File Offset: 0x004AD4C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_4);
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

		// Token: 0x06008B25 RID: 35621 RVA: 0x000533A6 File Offset: 0x000515A6
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_2;
		}

		// Token: 0x06008B26 RID: 35622 RVA: 0x000533AE File Offset: 0x000515AE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_5)
		{
			this.class116_2 = class116_5;
		}

		// Token: 0x06008B27 RID: 35623 RVA: 0x000533B7 File Offset: 0x000515B7
		[CompilerGenerated]
		internal Control12 vmethod_20()
		{
			return this.control12_1;
		}

		// Token: 0x06008B28 RID: 35624 RVA: 0x004AF30C File Offset: 0x004AD50C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Control12 control12_2)
		{
			EventHandler value = new EventHandler(this.method_17);
			Control12 control = this.control12_1;
			if (control != null)
			{
				control.SelectedIndexChanged -= value;
			}
			this.control12_1 = control12_2;
			control = this.control12_1;
			if (control != null)
			{
				control.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06008B29 RID: 35625 RVA: 0x000533BF File Offset: 0x000515BF
		[CompilerGenerated]
		internal TabPage vmethod_22()
		{
			return this.tabPage_2;
		}

		// Token: 0x06008B2A RID: 35626 RVA: 0x000533C7 File Offset: 0x000515C7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(TabPage tabPage_4)
		{
			this.tabPage_2 = tabPage_4;
		}

		// Token: 0x06008B2B RID: 35627 RVA: 0x000533D0 File Offset: 0x000515D0
		[CompilerGenerated]
		internal Control6 vmethod_24()
		{
			return this.control6_2;
		}

		// Token: 0x06008B2C RID: 35628 RVA: 0x004AF350 File Offset: 0x004AD550
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Control6 control6_5)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_49);
			MouseEventHandler value2 = new MouseEventHandler(this.method_51);
			EventHandler eventHandler_ = new EventHandler(this.method_56);
			Control6 control = this.control6_2;
			if (control != null)
			{
				control.MouseClick -= value;
				control.MouseDoubleClick -= value2;
				control.method_17(eventHandler_);
			}
			this.control6_2 = control6_5;
			control = this.control6_2;
			if (control != null)
			{
				control.MouseClick += value;
				control.MouseDoubleClick += value2;
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06008B2D RID: 35629 RVA: 0x000533D8 File Offset: 0x000515D8
		[CompilerGenerated]
		internal TabPage vmethod_26()
		{
			return this.tabPage_3;
		}

		// Token: 0x06008B2E RID: 35630 RVA: 0x000533E0 File Offset: 0x000515E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(TabPage tabPage_4)
		{
			this.tabPage_3 = tabPage_4;
		}

		// Token: 0x06008B2F RID: 35631 RVA: 0x000533E9 File Offset: 0x000515E9
		[CompilerGenerated]
		internal Control6 vmethod_28()
		{
			return this.control6_3;
		}

		// Token: 0x06008B30 RID: 35632 RVA: 0x004AF3CC File Offset: 0x004AD5CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Control6 control6_5)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_48);
			MouseEventHandler value2 = new MouseEventHandler(this.method_52);
			EventHandler eventHandler_ = new EventHandler(this.method_58);
			Control6 control = this.control6_3;
			if (control != null)
			{
				control.MouseClick -= value;
				control.MouseDoubleClick -= value2;
				control.method_17(eventHandler_);
			}
			this.control6_3 = control6_5;
			control = this.control6_3;
			if (control != null)
			{
				control.MouseClick += value;
				control.MouseDoubleClick += value2;
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06008B31 RID: 35633 RVA: 0x000533F1 File Offset: 0x000515F1
		[CompilerGenerated]
		internal Class116 vmethod_30()
		{
			return this.class116_3;
		}

		// Token: 0x06008B32 RID: 35634 RVA: 0x000533F9 File Offset: 0x000515F9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class116 class116_5)
		{
			this.class116_3 = class116_5;
		}

		// Token: 0x06008B33 RID: 35635 RVA: 0x00053402 File Offset: 0x00051602
		[CompilerGenerated]
		internal Control4 vmethod_32()
		{
			return this.control4_1;
		}

		// Token: 0x06008B34 RID: 35636 RVA: 0x004AF448 File Offset: 0x004AD648
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Control4 control4_2)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_15);
			Control4 control = this.control4_1;
			if (control != null)
			{
				control.method_17(eventHandler_);
			}
			this.control4_1 = control4_2;
			control = this.control4_1;
			if (control != null)
			{
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06008B35 RID: 35637 RVA: 0x0005340A File Offset: 0x0005160A
		[CompilerGenerated]
		internal Class116 vmethod_34()
		{
			return this.class116_4;
		}

		// Token: 0x06008B36 RID: 35638 RVA: 0x00053412 File Offset: 0x00051612
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Class116 class116_5)
		{
			this.class116_4 = class116_5;
		}

		// Token: 0x06008B37 RID: 35639 RVA: 0x0005341B File Offset: 0x0005161B
		[CompilerGenerated]
		internal Control6 vmethod_36()
		{
			return this.control6_4;
		}

		// Token: 0x06008B38 RID: 35640 RVA: 0x004AF48C File Offset: 0x004AD68C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Control6 control6_5)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_32);
			EventHandler eventHandler_ = new EventHandler(this.method_53);
			Control6 control = this.control6_4;
			if (control != null)
			{
				control.MouseDoubleClick -= value;
				control.method_17(eventHandler_);
			}
			this.control6_4 = control6_5;
			control = this.control6_4;
			if (control != null)
			{
				control.MouseDoubleClick += value;
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06008B39 RID: 35641 RVA: 0x00053423 File Offset: 0x00051623
		[CompilerGenerated]
		internal Control9 vmethod_38()
		{
			return this.control9_0;
		}

		// Token: 0x06008B3A RID: 35642 RVA: 0x004AF4EC File Offset: 0x004AD6EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_27);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_14;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B3B RID: 35643 RVA: 0x0005342B File Offset: 0x0005162B
		[CompilerGenerated]
		internal Control9 vmethod_40()
		{
			return this.control9_1;
		}

		// Token: 0x06008B3C RID: 35644 RVA: 0x004AF530 File Offset: 0x004AD730
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_29);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_14;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B3D RID: 35645 RVA: 0x00053433 File Offset: 0x00051633
		[CompilerGenerated]
		internal Control9 vmethod_42()
		{
			return this.control9_2;
		}

		// Token: 0x06008B3E RID: 35646 RVA: 0x004AF574 File Offset: 0x004AD774
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_20);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_14;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B3F RID: 35647 RVA: 0x0005343B File Offset: 0x0005163B
		[CompilerGenerated]
		internal Control9 vmethod_44()
		{
			return this.control9_3;
		}

		// Token: 0x06008B40 RID: 35648 RVA: 0x004AF5B8 File Offset: 0x004AD7B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_21);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_14;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B41 RID: 35649 RVA: 0x00053443 File Offset: 0x00051643
		[CompilerGenerated]
		internal Control9 vmethod_46()
		{
			return this.control9_4;
		}

		// Token: 0x06008B42 RID: 35650 RVA: 0x004AF5FC File Offset: 0x004AD7FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_23);
			Control9 control = this.control9_4;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_4 = control9_14;
			control = this.control9_4;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B43 RID: 35651 RVA: 0x0005344B File Offset: 0x0005164B
		[CompilerGenerated]
		internal Control9 vmethod_48()
		{
			return this.control9_5;
		}

		// Token: 0x06008B44 RID: 35652 RVA: 0x004AF640 File Offset: 0x004AD840
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_22);
			Control9 control = this.control9_5;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_5 = control9_14;
			control = this.control9_5;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B45 RID: 35653 RVA: 0x00053453 File Offset: 0x00051653
		[CompilerGenerated]
		internal Control9 vmethod_50()
		{
			return this.control9_6;
		}

		// Token: 0x06008B46 RID: 35654 RVA: 0x004AF684 File Offset: 0x004AD884
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_24);
			Control9 control = this.control9_6;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_6 = control9_14;
			control = this.control9_6;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B47 RID: 35655 RVA: 0x0005345B File Offset: 0x0005165B
		[CompilerGenerated]
		internal Control9 vmethod_52()
		{
			return this.control9_7;
		}

		// Token: 0x06008B48 RID: 35656 RVA: 0x004AF6C8 File Offset: 0x004AD8C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_25);
			Control9 control = this.control9_7;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_7 = control9_14;
			control = this.control9_7;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B49 RID: 35657 RVA: 0x00053463 File Offset: 0x00051663
		[CompilerGenerated]
		internal Control9 vmethod_54()
		{
			return this.control9_8;
		}

		// Token: 0x06008B4A RID: 35658 RVA: 0x004AF70C File Offset: 0x004AD90C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_31);
			Control9 control = this.control9_8;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_8 = control9_14;
			control = this.control9_8;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B4B RID: 35659 RVA: 0x0005346B File Offset: 0x0005166B
		[CompilerGenerated]
		internal Control9 vmethod_56()
		{
			return this.control9_9;
		}

		// Token: 0x06008B4C RID: 35660 RVA: 0x004AF750 File Offset: 0x004AD950
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_30);
			Control9 control = this.control9_9;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_9 = control9_14;
			control = this.control9_9;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B4D RID: 35661 RVA: 0x00053473 File Offset: 0x00051673
		[CompilerGenerated]
		internal TableLayoutPanel vmethod_58()
		{
			return this.tableLayoutPanel_0;
		}

		// Token: 0x06008B4E RID: 35662 RVA: 0x0005347B File Offset: 0x0005167B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(TableLayoutPanel tableLayoutPanel_1)
		{
			this.tableLayoutPanel_0 = tableLayoutPanel_1;
		}

		// Token: 0x06008B4F RID: 35663 RVA: 0x00053484 File Offset: 0x00051684
		[CompilerGenerated]
		internal Panel vmethod_60()
		{
			return this.panel_0;
		}

		// Token: 0x06008B50 RID: 35664 RVA: 0x0005348C File Offset: 0x0005168C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(Panel panel_5)
		{
			this.panel_0 = panel_5;
		}

		// Token: 0x06008B51 RID: 35665 RVA: 0x00053495 File Offset: 0x00051695
		[CompilerGenerated]
		internal Panel vmethod_62()
		{
			return this.panel_1;
		}

		// Token: 0x06008B52 RID: 35666 RVA: 0x0005349D File Offset: 0x0005169D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(Panel panel_5)
		{
			this.panel_1 = panel_5;
		}

		// Token: 0x06008B53 RID: 35667 RVA: 0x000534A6 File Offset: 0x000516A6
		[CompilerGenerated]
		internal Panel vmethod_64()
		{
			return this.panel_2;
		}

		// Token: 0x06008B54 RID: 35668 RVA: 0x000534AE File Offset: 0x000516AE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Panel panel_5)
		{
			this.panel_2 = panel_5;
		}

		// Token: 0x06008B55 RID: 35669 RVA: 0x000534B7 File Offset: 0x000516B7
		[CompilerGenerated]
		internal Panel vmethod_66()
		{
			return this.panel_3;
		}

		// Token: 0x06008B56 RID: 35670 RVA: 0x000534BF File Offset: 0x000516BF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(Panel panel_5)
		{
			this.panel_3 = panel_5;
		}

		// Token: 0x06008B57 RID: 35671 RVA: 0x000534C8 File Offset: 0x000516C8
		[CompilerGenerated]
		internal Panel vmethod_68()
		{
			return this.panel_4;
		}

		// Token: 0x06008B58 RID: 35672 RVA: 0x000534D0 File Offset: 0x000516D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(Panel panel_5)
		{
			this.panel_4 = panel_5;
		}

		// Token: 0x06008B59 RID: 35673 RVA: 0x000534D9 File Offset: 0x000516D9
		[CompilerGenerated]
		internal Class112 vmethod_70()
		{
			return this.class112_0;
		}

		// Token: 0x06008B5A RID: 35674 RVA: 0x004AF794 File Offset: 0x004AD994
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(Class112 class112_2)
		{
			EventHandler value = new EventHandler(this.method_38);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_0 = class112_2;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06008B5B RID: 35675 RVA: 0x000534E1 File Offset: 0x000516E1
		[CompilerGenerated]
		internal Class112 vmethod_72()
		{
			return this.class112_1;
		}

		// Token: 0x06008B5C RID: 35676 RVA: 0x004AF7D8 File Offset: 0x004AD9D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(Class112 class112_2)
		{
			EventHandler value = new EventHandler(this.method_39);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_1 = class112_2;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06008B5D RID: 35677 RVA: 0x000534E9 File Offset: 0x000516E9
		[CompilerGenerated]
		internal Control9 vmethod_74()
		{
			return this.control9_10;
		}

		// Token: 0x06008B5E RID: 35678 RVA: 0x004AF81C File Offset: 0x004ADA1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_41);
			Control9 control = this.control9_10;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_10 = control9_14;
			control = this.control9_10;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B5F RID: 35679 RVA: 0x000534F1 File Offset: 0x000516F1
		[CompilerGenerated]
		internal Control9 vmethod_76()
		{
			return this.control9_11;
		}

		// Token: 0x06008B60 RID: 35680 RVA: 0x004AF860 File Offset: 0x004ADA60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_40);
			Control9 control = this.control9_11;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_11 = control9_14;
			control = this.control9_11;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B61 RID: 35681 RVA: 0x000534F9 File Offset: 0x000516F9
		[CompilerGenerated]
		internal Control9 vmethod_78()
		{
			return this.control9_12;
		}

		// Token: 0x06008B62 RID: 35682 RVA: 0x004AF8A4 File Offset: 0x004ADAA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_43);
			Control9 control = this.control9_12;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_12 = control9_14;
			control = this.control9_12;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B63 RID: 35683 RVA: 0x00053501 File Offset: 0x00051701
		[CompilerGenerated]
		internal Control9 vmethod_80()
		{
			return this.control9_13;
		}

		// Token: 0x06008B64 RID: 35684 RVA: 0x004AF8E8 File Offset: 0x004ADAE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(Control9 control9_14)
		{
			EventHandler value = new EventHandler(this.method_42);
			Control9 control = this.control9_13;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_13 = control9_14;
			control = this.control9_13;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008B65 RID: 35685 RVA: 0x00053509 File Offset: 0x00051709
		[CompilerGenerated]
		internal Class113 vmethod_82()
		{
			return this.class113_0;
		}

		// Token: 0x06008B66 RID: 35686 RVA: 0x00053511 File Offset: 0x00051711
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(Class113 class113_1)
		{
			this.class113_0 = class113_1;
		}

		// Token: 0x06008B67 RID: 35687 RVA: 0x0005351A File Offset: 0x0005171A
		[CompilerGenerated]
		internal Class120 vmethod_84()
		{
			return this.class120_0;
		}

		// Token: 0x06008B68 RID: 35688 RVA: 0x00053522 File Offset: 0x00051722
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(Class120 class120_1)
		{
			this.class120_0 = class120_1;
		}

		// Token: 0x06008B69 RID: 35689 RVA: 0x0005352B File Offset: 0x0005172B
		[CompilerGenerated]
		internal Class128 vmethod_86()
		{
			return this.class128_0;
		}

		// Token: 0x06008B6A RID: 35690 RVA: 0x004AF92C File Offset: 0x004ADB2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(Class128 class128_1)
		{
			EventHandler value = new EventHandler(this.method_44);
			Class128 @class = this.class128_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_0 = class128_1;
			@class = this.class128_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008B6B RID: 35691 RVA: 0x004AF970 File Offset: 0x004ADB70
		private void AttackTarget_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.bool_3 && Client.smethod_61() != Client.Enum197.const_23)
			{
				Client.smethod_0().method_3();
			}
			Class2413.smethod_2().method_41().vmethod_796().Focus();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06008B6C RID: 35692 RVA: 0x004AF9BC File Offset: 0x004ADBBC
		public void method_3()
		{
			this.bool_3 = (Client.smethod_0().method_0() == Class279.Enum68.const_1);
			if (this.bool_3)
			{
				Client.smethod_0().method_4();
			}
			this.method_7();
			this.method_8();
			if (this.list_0.Count > 0 && this.list_1.Count > 0 && this.vmethod_36().method_20().Count > 0)
			{
				this.bool_4 = false;
				this.vmethod_36().method_51(this.vmethod_36().method_20()[0]);
				this.vmethod_36().Select();
				this.bool_4 = true;
			}
			this.bool_4 = false;
			this.vmethod_70().Checked = Class570.class280_0.method_44();
			this.vmethod_72().Checked = Class570.class280_0.method_46();
			this.bool_4 = true;
			new ToolTip().SetToolTip(this.vmethod_70(), "Enable automatic salvo cancellation when last weapon in first volley impacts, or after 40 seconds if weapons cannot be fired. Note! Disabling salvo cancellation will not drop salvos until all weapons have been fired, and may prevent other units from automatically firing at a contact should it move out of firing parameters!");
		}

		// Token: 0x06008B6D RID: 35693 RVA: 0x004AFAAC File Offset: 0x004ADCAC
		public void imethod_0()
		{
			if (!base.IsDisposed)
			{
				try
				{
					this.method_18();
					this.method_14();
					this.method_6();
					if (Information.IsNothing(this.list_2) && this.list_1.Count > 0)
					{
						this.list_2.Add(this.list_1[0]);
						this.list_3.Add(this.list_0[0]);
					}
					List<ActiveUnit> list = new List<ActiveUnit>();
					try
					{
						foreach (ActiveUnit activeUnit in this.list_1)
						{
							if (Information.IsNothing(activeUnit) || activeUnit.method_82() || (activeUnit.bool_6 && ((Ship)activeUnit).method_152()))
							{
								list.Add(activeUnit);
							}
							if (!activeUnit.vmethod_127())
							{
								list.Add(activeUnit);
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (list.Count > 0)
					{
						try
						{
							foreach (ActiveUnit item in list)
							{
								this.list_1.Remove(item);
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						this.method_7();
					}
					List<Contact> list2 = new List<Contact>();
					try
					{
						foreach (Contact contact in this.list_0)
						{
							if (Information.IsNothing(contact) || (!Information.IsNothing(contact.activeUnit_0) && contact.activeUnit_0.method_82()))
							{
								list2.Add(contact);
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					if (list2.Count > 0)
					{
						try
						{
							foreach (Contact item2 in list2)
							{
								this.list_0.Remove(item2);
								this.method_8();
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
					this.method_19(true);
				}
				catch (Exception ex)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06008B6E RID: 35694 RVA: 0x00053533 File Offset: 0x00051733
		private void AttackTarget_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_16().Interval = 1000;
			this.vmethod_16().Start();
			this.method_3();
		}

		// Token: 0x06008B6F RID: 35695 RVA: 0x00053569 File Offset: 0x00051769
		private void method_4(object sender, EventArgs e)
		{
			if (Client.smethod_0().method_0() == Class279.Enum68.const_1)
			{
				this.imethod_0();
			}
		}

		// Token: 0x06008B70 RID: 35696 RVA: 0x004AFD28 File Offset: 0x004ADF28
		private void method_5()
		{
			if (this.vmethod_20().SelectedIndex == 0)
			{
				if (this.vmethod_24().method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_24().method_22()[0].Tag)))
				{
					if (this.vmethod_24().method_22()[0].Tag.GetType() == typeof(Class316))
					{
						this.vmethod_56().Enabled = true;
						Class316 @class = (Class316)this.vmethod_24().method_22()[0].Tag;
						bool flag = Enumerable.Count<Waypoint>(@class.waypoint_0) > 0;
						bool flag2 = @class.method_11(Client.smethod_46()).method_153();
						this.vmethod_76().Enabled = flag2;
						this.vmethod_74().Enabled = (flag2 && flag);
						goto IL_1EA;
					}
				}
				this.vmethod_56().Enabled = false;
				this.vmethod_76().Enabled = false;
				this.vmethod_74().Enabled = false;
			}
			else
			{
				if (this.vmethod_28().method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_28().method_22()[0].Tag)))
				{
					if (this.vmethod_28().method_22()[0].Tag.GetType() == typeof(Class316))
					{
						this.vmethod_56().Enabled = true;
						Class316 class2 = (Class316)this.vmethod_28().method_22()[0].Tag;
						bool flag = Enumerable.Count<Waypoint>(class2.waypoint_0) > 0;
						bool flag2 = class2.method_11(Client.smethod_46()).method_153();
						this.vmethod_76().Enabled = flag2;
						this.vmethod_74().Enabled = (flag2 && flag);
						goto IL_1EA;
					}
				}
				this.vmethod_56().Enabled = false;
				this.vmethod_76().Enabled = false;
				this.vmethod_74().Enabled = false;
			}
			IL_1EA:
			if (this.vmethod_4().SelectedIndex == 0)
			{
				if (this.vmethod_12().method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().method_22()[0].Tag)))
				{
					if (this.vmethod_12().method_22()[0].Tag.GetType() == typeof(Class316))
					{
						this.vmethod_54().Enabled = true;
						Class316 class3 = (Class316)this.vmethod_12().method_22()[0].Tag;
						bool flag = Enumerable.Count<Waypoint>(class3.waypoint_0) > 0;
						bool flag2 = class3.method_11(Client.smethod_46()).method_153();
						this.vmethod_80().Enabled = flag2;
						this.vmethod_78().Enabled = (flag2 && flag);
						return;
					}
				}
				this.vmethod_54().Enabled = false;
				this.vmethod_80().Enabled = false;
				this.vmethod_78().Enabled = false;
				return;
			}
			if (this.vmethod_14().method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_14().method_22()[0].Tag)))
			{
				if (this.vmethod_14().method_22()[0].Tag.GetType() == typeof(Class316))
				{
					this.vmethod_54().Enabled = true;
					Class316 class4 = (Class316)this.vmethod_14().method_22()[0].Tag;
					bool flag = Enumerable.Count<Waypoint>(class4.waypoint_0) > 0;
					bool flag2 = class4.method_11(Client.smethod_46()).method_153();
					this.vmethod_80().Enabled = flag2;
					this.vmethod_78().Enabled = (flag2 && flag);
					return;
				}
			}
			this.vmethod_54().Enabled = false;
			this.vmethod_80().Enabled = false;
			this.vmethod_78().Enabled = false;
		}

		// Token: 0x06008B71 RID: 35697 RVA: 0x0005357E File Offset: 0x0005177E
		private void method_6()
		{
			if (this.vmethod_20().SelectedIndex == 0)
			{
				this.method_9();
			}
			else
			{
				this.method_10();
			}
			if (this.vmethod_4().SelectedIndex == 0)
			{
				this.method_11();
			}
			else
			{
				this.method_12();
			}
			this.method_5();
		}

		// Token: 0x06008B72 RID: 35698 RVA: 0x004B0100 File Offset: 0x004AE300
		private void method_7()
		{
			this.vmethod_32().method_18().Clear();
			List<ActiveUnit> list = new List<ActiveUnit>();
			List<ActiveUnit> list2 = new List<ActiveUnit>();
			this.list_1 = Enumerable.ToList<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, string>(this.list_1, (AttackTarget._Closure$__.$I201-0 == null) ? (AttackTarget._Closure$__.$I201-0 = new Func<ActiveUnit, string>(AttackTarget._Closure$__.$I.method_0)) : AttackTarget._Closure$__.$I201-0));
			try
			{
				foreach (ActiveUnit activeUnit in this.list_1)
				{
					if (activeUnit.bool_1)
					{
						try
						{
							foreach (ActiveUnit activeUnit2 in ((Group)activeUnit).vmethod_141().Values)
							{
								Side side_ = Client.smethod_50();
								Unit unit_ = activeUnit2;
								bool bool_ = false;
								string text = null;
								if (GameGeneral.smethod_45(side_, unit_, bool_, ref text, Client.smethod_52().method_59()) && !this.list_1.Contains(activeUnit2))
								{
									list.Add(activeUnit2);
								}
							}
						}
						finally
						{
							IEnumerator<ActiveUnit> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						list2.Add(activeUnit);
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (ActiveUnit item in list2)
				{
					this.list_1.Remove(item);
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			try
			{
				foreach (ActiveUnit item2 in list)
				{
					this.list_1.Add(item2);
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator4;
				((IDisposable)enumerator4).Dispose();
			}
			try
			{
				foreach (ActiveUnit activeUnit3 in this.list_1)
				{
					Class117 @class = new Class117();
					@class.method_3(activeUnit3.Name + " (" + Misc.smethod_9(activeUnit3.string_2) + ")");
					@class.Tag = activeUnit3;
					this.vmethod_32().method_18().Add(@class);
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator5;
				((IDisposable)enumerator5).Dispose();
			}
			if (this.vmethod_32().method_18().Count > 0)
			{
				if (this.int_0 <= this.vmethod_32().method_18().Count - 1)
				{
					this.vmethod_32().method_29(this.int_0);
					return;
				}
				this.vmethod_32().method_29(this.vmethod_32().method_18().Count - 1);
			}
		}

		// Token: 0x06008B73 RID: 35699 RVA: 0x004B03A4 File Offset: 0x004AE5A4
		private void method_8()
		{
			this.vmethod_10().method_18().Clear();
			this.list_0 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, string>(this.list_0, (AttackTarget._Closure$__.$I202-0 == null) ? (AttackTarget._Closure$__.$I202-0 = new Func<Contact, string>(AttackTarget._Closure$__.$I.method_1)) : AttackTarget._Closure$__.$I202-0));
			try
			{
				foreach (Contact contact in this.list_0)
				{
					string str = "";
					if (contact.method_73(Client.smethod_50()).Count > 0)
					{
						Dictionary<string, int> dictionary = new Dictionary<string, int>();
						try
						{
							foreach (Contact.Class269 @class in contact.method_73(Client.smethod_50()))
							{
								string text;
								switch (@class.identificationStatus_0)
								{
								case Contact_Base.IdentificationStatus.Unknown:
									text = "Unknown unit";
									goto IL_2D4;
								case Contact_Base.IdentificationStatus.KnownDomain:
									try
									{
										ActiveUnit activeUnit = Client.smethod_46().vmethod_0()[@class.string_0];
										text = Misc.smethod_56(activeUnit.vmethod_121()) + " " + activeUnit.method_63();
										goto IL_2D4;
									}
									catch (Exception ex)
									{
										ex.Data.Add("Error at 999999", ex.Message);
										GameGeneral.smethod_25(ref ex);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										text = "Unknown unit";
										goto IL_2D4;
									}
									goto IL_163;
								case Contact_Base.IdentificationStatus.KnownType:
									goto IL_163;
								case Contact_Base.IdentificationStatus.KnownClass:
									goto IL_1E4;
								case Contact_Base.IdentificationStatus.PreciseID:
									goto IL_24B;
								default:
									goto IL_2D4;
								}
								IL_2AC:
								dictionary[text]++;
								continue;
								IL_24B:
								try
								{
									text = Client.smethod_46().vmethod_0()[@class.string_0].Name;
									goto IL_2D4;
								}
								catch (Exception ex2)
								{
									ex2.Data.Add("Error at 200411", ex2.Message);
									GameGeneral.smethod_25(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									text = "Unknown unit";
									goto IL_2D4;
								}
								goto IL_2AC;
								IL_2D4:
								text = text + " (Last Recon: " + Conversions.ToString(Interaction.IIf(@class.float_0 > 0f, Misc.smethod_11((long)Math.Round((double)@class.float_0), Aircraft_AirOps.Enum44.const_0, false, true) + " ago)", "Now)"));
								if (dictionary.ContainsKey(text))
								{
									goto IL_2AC;
								}
								dictionary.Add(text, 1);
								continue;
								IL_1E4:
								try
								{
									text = Client.smethod_46().vmethod_0()[@class.string_0].string_2;
									goto IL_2D4;
								}
								catch (Exception ex3)
								{
									ex3.Data.Add("Error at 200410", ex3.Message);
									GameGeneral.smethod_25(ref ex3);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									text = "Unknown unit";
									goto IL_2D4;
								}
								goto IL_24B;
								IL_163:
								try
								{
									ActiveUnit activeUnit2 = Client.smethod_46().vmethod_0()[@class.string_0];
									text = Misc.smethod_56(activeUnit2.vmethod_121()) + " " + activeUnit2.vmethod_58();
									goto IL_2D4;
								}
								catch (Exception ex4)
								{
									ex4.Data.Add("Error at 200409", ex4.Message);
									GameGeneral.smethod_25(ref ex4);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									text = "Unknown unit";
									goto IL_2D4;
								}
								goto IL_1E4;
							}
						}
						finally
						{
							List<Contact.Class269>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						List<string> list = new List<string>();
						try
						{
							foreach (KeyValuePair<string, int> keyValuePair in dictionary)
							{
								list.Add(Conversions.ToString(keyValuePair.Value) + "x " + keyValuePair.Key);
							}
						}
						finally
						{
							Dictionary<string, int>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						str = " - " + string.Join(" - ", list);
					}
					Class117 class2 = new Class117();
					class2.method_3(contact.Name + str);
					class2.Tag = contact;
					this.vmethod_10().method_18().Add(class2);
				}
			}
			finally
			{
				List<Contact>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (this.vmethod_10().method_18().Count > 0)
			{
				if (this.int_1 <= this.vmethod_10().method_18().Count - 1)
				{
					this.vmethod_10().method_29(this.int_1);
					return;
				}
				this.vmethod_10().method_29(this.vmethod_10().method_18().Count - 1);
			}
		}

		// Token: 0x06008B74 RID: 35700 RVA: 0x004B08B0 File Offset: 0x004AEAB0
		private void method_9()
		{
			this.vmethod_24().method_20().Clear();
			if (this.list_3.Count == 1)
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.list_2)
					{
						Class127 @class = new Class127();
						@class.method_7("By: " + activeUnit.Name);
						@class.Tag = activeUnit;
						this.vmethod_24().method_20().method_4(@class);
						Side side = activeUnit.vmethod_7(false);
						List<Contact> list;
						Contact value = (list = this.list_3)[0];
						List<Class316> list2 = side.method_78(ref activeUnit, ref value);
						list[0] = value;
						List<Class316> list3 = list2;
						try
						{
							foreach (Class316 class2 in list3)
							{
								foreach (Class316.Class273 class3 in class2.class273_0)
								{
									if (Operators.CompareString(activeUnit.string_0, class3.string_0, false) == 0)
									{
										if (class3.int_0 - class3.int_1 > 0)
										{
											string text;
											if (class3.int_0 > 2147473647)
											{
												text = "All weapons ";
											}
											else
											{
												text = Conversions.ToString(class3.int_0 - class3.int_1) + "x ";
											}
											Class127 class4 = new Class127();
											this.string_0 = "";
											Weapon.Enum130 enum130_ = class2.enum130_0;
											if (enum130_ == Weapon.Enum130.const_1)
											{
												ref string ptr = ref this.string_0;
												this.string_0 = ptr + "[HIGH ALT]";
											}
											if (Enumerable.Count<Waypoint>(class2.waypoint_0) > 0)
											{
												ref string ptr = ref this.string_0;
												this.string_0 = ptr + "[" + Conversions.ToString(Enumerable.Count<Waypoint>(class2.waypoint_0)) + " legs]";
											}
											class4.method_7(string.Concat(new string[]
											{
												"Alloc: ",
												this.string_0,
												" ",
												text,
												class2.method_11(activeUnit.scenario_0).Name
											}));
											class4.Tag = class2;
											@class.method_23().method_4(class4);
										}
										if (class3.int_1 > 0)
										{
											Class127 class5 = new Class127();
											class5.method_7("Fired: " + Conversions.ToString(class3.int_1) + "x " + class2.method_11(activeUnit.scenario_0).Name);
											@class.method_23().method_4(class5);
										}
									}
								}
							}
						}
						finally
						{
							List<Class316>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						@class.method_22(true);
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06008B75 RID: 35701 RVA: 0x004B0B90 File Offset: 0x004AED90
		private void method_10()
		{
			this.vmethod_28().method_20().Clear();
			try
			{
				foreach (ActiveUnit activeUnit in this.list_2)
				{
					Class127 @class = new Class127();
					@class.method_7("By: " + activeUnit.Name);
					@class.Tag = activeUnit;
					this.vmethod_28().method_20().method_4(@class);
					List<Class316> list = activeUnit.vmethod_7(false).method_79(ref activeUnit);
					try
					{
						foreach (Class316 class2 in list)
						{
							foreach (Class316.Class273 class3 in class2.class273_0)
							{
								if (Operators.CompareString(activeUnit.string_0, class3.string_0, false) == 0)
								{
									if (class3.int_0 - class3.int_1 > 0)
									{
										string text;
										if (class3.int_0 > 2147473647)
										{
											text = "All weapons ";
										}
										else
										{
											text = Conversions.ToString(class3.int_0 - class3.int_1) + "x ";
										}
										Class127 class4 = new Class127();
										class4.method_7(string.Concat(new string[]
										{
											"Allocated to ",
											class2.contact_0.Name,
											": ",
											text,
											class2.method_11(activeUnit.scenario_0).Name
										}));
										class4.Tag = class2;
										@class.method_23().method_4(class4);
									}
									if (class3.int_1 > 0)
									{
										Class127 class5 = new Class127();
										class5.method_7(string.Concat(new string[]
										{
											"Fired at ",
											class2.contact_0.Name,
											": ",
											Conversions.ToString(class3.int_1),
											"x ",
											class2.method_11(activeUnit.scenario_0).Name
										}));
										@class.method_23().method_4(class5);
									}
								}
							}
						}
					}
					finally
					{
						List<Class316>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					@class.method_22(true);
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06008B76 RID: 35702 RVA: 0x004B0E04 File Offset: 0x004AF004
		private void method_11()
		{
			this.vmethod_12().method_20().Clear();
			if (this.list_3.Count == 1)
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.list_2)
					{
						Class127 @class = new Class127();
						@class.method_7("By: " + activeUnit.Name);
						@class.Tag = activeUnit;
						this.vmethod_12().method_20().method_4(@class);
						Side side = activeUnit.vmethod_7(false);
						List<Contact> list;
						Contact value = (list = this.list_3)[0];
						List<Class316> list2 = side.method_78(ref activeUnit, ref value);
						list[0] = value;
						List<Class316> list3 = list2;
						try
						{
							foreach (Class316 class2 in list3)
							{
								foreach (Class316.Class273 class3 in class2.class273_0)
								{
									if (Operators.CompareString(activeUnit.string_0, class3.string_0, false) == 0)
									{
										if (class3.int_0 - class3.int_1 > 0)
										{
											string str;
											if (class3.int_0 > 2147473647)
											{
												str = "All weapons ";
											}
											else
											{
												str = Conversions.ToString(class3.int_0 - class3.int_1) + "x ";
											}
											this.string_0 = "";
											Weapon.Enum130 enum130_ = class2.enum130_0;
											if (enum130_ == Weapon.Enum130.const_1)
											{
												ref string ptr = ref this.string_0;
												this.string_0 = ptr + "[HIGH ALT]";
											}
											if (Enumerable.Count<Waypoint>(class2.waypoint_0) > 0)
											{
												ref string ptr = ref this.string_0;
												this.string_0 = ptr + "[" + Conversions.ToString(Enumerable.Count<Waypoint>(class2.waypoint_0)) + " legs]";
											}
											Class127 class4 = new Class127();
											class4.method_7("Alloc: " + this.string_0 + str + class2.method_11(activeUnit.scenario_0).Name);
											class4.Tag = class2;
											@class.method_23().method_4(class4);
										}
										if (class3.int_1 > 0)
										{
											Class127 class5 = new Class127();
											class5.method_7("Fired: " + Conversions.ToString(class3.int_1) + "x " + class2.method_11(activeUnit.scenario_0).Name);
											@class.method_23().method_4(class5);
										}
									}
								}
							}
						}
						finally
						{
							List<Class316>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						@class.method_22(true);
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06008B77 RID: 35703 RVA: 0x004B10C8 File Offset: 0x004AF2C8
		private void method_12()
		{
			this.vmethod_14().method_20().Clear();
			try
			{
				foreach (ActiveUnit activeUnit in Client.smethod_46().method_42())
				{
					if (!Information.IsNothing(activeUnit) && !activeUnit.bool_2 && !activeUnit.bool_1)
					{
						Side side = activeUnit.vmethod_7(false);
						List<Contact> list;
						Contact value = (list = this.list_3)[0];
						List<Class316> list2 = side.method_78(ref activeUnit, ref value);
						list[0] = value;
						List<Class316> list3 = list2;
						if (list3.Count > 0)
						{
							Class127 @class = new Class127();
							@class.method_7("By: " + activeUnit.Name);
							@class.Tag = activeUnit;
							this.vmethod_14().method_20().method_4(@class);
							try
							{
								foreach (Class316 class2 in list3)
								{
									foreach (Class316.Class273 class3 in class2.class273_0)
									{
										if (Operators.CompareString(activeUnit.string_0, class3.string_0, false) == 0)
										{
											if (class3.int_0 - class3.int_1 > 0)
											{
												string str;
												if (class3.int_0 > 2147473647)
												{
													str = "All weapons ";
												}
												else
												{
													str = Conversions.ToString(class3.int_0 - class3.int_1) + "x ";
												}
												this.string_0 = "";
												Weapon.Enum130 enum130_ = class2.enum130_0;
												if (enum130_ == Weapon.Enum130.const_1)
												{
													ref string ptr = ref this.string_0;
													this.string_0 = ptr + "[HIGH ALT]";
												}
												if (Enumerable.Count<Waypoint>(class2.waypoint_0) > 0)
												{
													ref string ptr = ref this.string_0;
													this.string_0 = ptr + "[" + Conversions.ToString(Enumerable.Count<Waypoint>(class2.waypoint_0)) + " legs]";
												}
												Class127 class4 = new Class127();
												class4.method_7("Alloc: " + this.string_0 + str + class2.method_11(activeUnit.scenario_0).Name);
												class4.Tag = class2;
												@class.method_23().method_4(class4);
											}
											if (class3.int_1 > 0)
											{
												Class127 class5 = new Class127();
												class5.method_7("Fired: " + Conversions.ToString(class3.int_1) + "x " + class2.method_11(activeUnit.scenario_0).Name);
												@class.method_23().method_4(class5);
											}
										}
									}
								}
							}
							finally
							{
								List<Class316>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							@class.method_22(true);
						}
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.vmethod_14().Refresh();
		}

		// Token: 0x06008B78 RID: 35704 RVA: 0x004B13BC File Offset: 0x004AF5BC
		private void method_13()
		{
			if (this.vmethod_36().method_22().Count == 0)
			{
				this.vmethod_38().Enabled = false;
				this.vmethod_40().Enabled = false;
				this.vmethod_52().Enabled = false;
				return;
			}
			if (this.list_2.Count <= 0)
			{
				this.vmethod_38().Enabled = false;
				this.vmethod_40().Enabled = false;
				this.vmethod_52().Enabled = false;
				return;
			}
			if (this.list_3.Count == 1)
			{
				this.vmethod_40().Enabled = true;
			}
			else
			{
				this.vmethod_40().Enabled = false;
			}
			Weapon weapon;
			if (this.vmethod_36().method_22()[0].Tag.GetType() == typeof(string))
			{
				weapon = (Weapon)this.vmethod_36().method_22()[0].method_28().Tag;
			}
			else
			{
				weapon = (Weapon)this.vmethod_36().method_22()[0].Tag;
			}
			if (this.list_3.Count > 0)
			{
				if (this.list_2[0].doctrine_0.method_239(ref weapon))
				{
					this.vmethod_52().Enabled = true;
				}
				else
				{
					this.vmethod_52().Enabled = false;
				}
				this.vmethod_38().Enabled = true;
				return;
			}
			this.vmethod_52().Enabled = false;
			this.vmethod_38().Enabled = false;
		}

		// Token: 0x06008B79 RID: 35705 RVA: 0x004B152C File Offset: 0x004AF72C
		private void method_14()
		{
			this.vmethod_36().method_20().Clear();
			this.method_13();
			if (this.list_2.Count != 1)
			{
				this.vmethod_36().Enabled = false;
				return;
			}
			if (this.list_3.Count == 0)
			{
				this.vmethod_36().Enabled = false;
				return;
			}
			if (this.list_3.Count > 1)
			{
				int num = 0;
				try
				{
					foreach (Contact contact in this.list_3)
					{
						Contact_Base.ContactType contactType_;
						if (num == 0)
						{
							contactType_ = contact.contactType_0;
						}
						else if (contactType_ != contact.contactType_0)
						{
							this.vmethod_36().Enabled = false;
							return;
						}
						num++;
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			this.vmethod_36().Enabled = true;
			try
			{
				foreach (ActiveUnit activeUnit in this.list_2)
				{
					bool flag = true;
					Weapon[] array = activeUnit.vmethod_89().vmethod_4().ToArray();
					bool? flag2 = null;
					foreach (Weapon weapon in array)
					{
						int dbid = weapon.DBID;
						Weapon weapon2 = weapon;
						Scenario scenario_ = activeUnit.scenario_0;
						List<Contact> list;
						Contact value = (list = this.list_3)[0];
						bool flag3 = weapon2.method_253(scenario_, ref value, ref flag2);
						list[0] = value;
						if (flag3)
						{
							int num2 = activeUnit.vmethod_89().method_5(dbid, true);
							int num3 = activeUnit.vmethod_7(false).method_76(ref activeUnit, dbid);
							string text = Conversions.ToString(num2) + "x " + Misc.smethod_9(weapon.Name);
							if (num3 > 2147473647)
							{
								text += " (All weapons allocated)";
							}
							else if (num3 > 0)
							{
								text = text + " (" + Conversions.ToString(num3) + "x allocated)";
							}
							Class127 @class = new Class127(text);
							Dictionary<string, int> dictionary = new Dictionary<string, int>();
							@class.Tag = weapon;
							this.vmethod_36().method_20().method_4(@class);
							if (num3 != num2)
							{
								short? num5;
								try
								{
									foreach (Mount mount in activeUnit.vmethod_51())
									{
										int num4 = activeUnit.vmethod_89().method_33(mount, dbid);
										if (num4 > 0)
										{
											ActiveUnit_Weaponry activeUnit_Weaponry = activeUnit.vmethod_89();
											Weapon theWeapon = weapon;
											Contact theTarget = this.list_3[0];
											bool manualFire = flag;
											bool ignoreAircraftOrientation = false;
											Mount theMount = mount;
											Sensor sensor = null;
											string item = activeUnit_Weaponry.method_23(theWeapon, theTarget, ref num5, manualFire, ignoreAircraftOrientation, theMount, ref sensor).Item1;
											if (dictionary.ContainsKey(item))
											{
												dictionary[item] += num4;
											}
											else
											{
												dictionary.Add(item, num4);
											}
										}
									}
								}
								finally
								{
									List<Mount>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
								if (activeUnit.bool_3 && !Information.IsNothing(((Aircraft)activeUnit).method_167()))
								{
									int num6 = activeUnit.vmethod_89().vmethod_9(((Aircraft)activeUnit).method_167(), dbid);
									if (num6 > 0)
									{
										ActiveUnit_Weaponry activeUnit_Weaponry2 = activeUnit.vmethod_89();
										Weapon theWeapon2 = weapon;
										Contact theTarget2 = this.list_3[0];
										bool manualFire2 = flag;
										bool ignoreAircraftOrientation2 = false;
										Mount theMount2 = null;
										Sensor sensor = null;
										string item2 = activeUnit_Weaponry2.method_23(theWeapon2, theTarget2, ref num5, manualFire2, ignoreAircraftOrientation2, theMount2, ref sensor).Item1;
										if (dictionary.ContainsKey(item2))
										{
											dictionary[item2] += num6;
										}
										else
										{
											dictionary.Add(item2, num6);
										}
									}
								}
								int num7 = activeUnit.vmethod_89().vmethod_8(dbid);
								if (num7 > 0)
								{
									dictionary.Add("Weapon is on magazines", num7);
								}
								if (Class570.class280_0.method_46())
								{
									bool flag4 = true;
									string string_ = "Automatic fire is not allowed";
									Doctrine.Enum52 @enum = activeUnit.vmethod_89().method_8(this.list_3[0].contactType_0);
									string str;
									if (@enum == Doctrine.Enum52.const_0)
									{
										str = "WEAPONS FREE";
									}
									else if (@enum == Doctrine.Enum52.const_1)
									{
										str = "WEAPONS TIGHT";
									}
									else
									{
										str = "WEAPONS HOLD";
									}
									Doctrine._WRA_WeaponTargetType wra_WeaponTargetType;
									if (weapon.class394_0.bool_5)
									{
										wra_WeaponTargetType = Doctrine._WRA_WeaponTargetType.Radar_Unspecified;
									}
									else
									{
										value = (list = this.list_3)[0];
										Doctrine._WRA_WeaponTargetType wra_WeaponTargetType2 = Doctrine.smethod_7(ref value);
										list[0] = value;
										wra_WeaponTargetType = wra_WeaponTargetType2;
									}
									string str2 = " Target type is " + Doctrine.smethod_8(wra_WeaponTargetType);
									Doctrine doctrine_ = activeUnit.doctrine_0;
									Scenario scenario_2 = activeUnit.scenario_0;
									int theWeaponDBID = dbid;
									Doctrine._WRA_WeaponTargetType selectedNodeTargetType = wra_WeaponTargetType;
									bool findInheritedValuesOnly = false;
									int? num8 = null;
									int? num9 = null;
									int? num10 = doctrine_.method_23(scenario_2, theWeaponDBID, selectedNodeTargetType, findInheritedValuesOnly, ref num8, ref num9);
									if (Information.IsNothing(num10))
									{
										num10 = new int?(-99);
									}
									num9 = num10;
									bool? flag5 = (num9 != null) ? new bool?(num9.GetValueOrDefault() == 0) : null;
									int? num11;
									if (((flag5 != null) ? new bool?(!flag5.GetValueOrDefault()) : flag5).GetValueOrDefault())
									{
										Doctrine doctrine_2 = activeUnit.doctrine_0;
										Scenario scenario_3 = activeUnit.scenario_0;
										Weapon theWeapon3 = weapon;
										Doctrine._WRA_WeaponTargetType selectedNodeTargetType2 = wra_WeaponTargetType;
										bool findInheritedValuesOnly2 = false;
										num9 = null;
										num8 = null;
										num11 = doctrine_2.method_9(scenario_3, theWeapon3, selectedNodeTargetType2, findInheritedValuesOnly2, ref num9, ref num8);
										if (Information.IsNothing(num11))
										{
											num11 = new int?(0);
										}
									}
									else
									{
										num11 = new int?(0);
									}
									string str3;
									string text2;
									if (Information.IsNothing(num11))
									{
										str3 = "Do not use weapon type against this target type";
										text2 = "";
									}
									else
									{
										num8 = num10;
										if (((num8 != null) ? new bool?(num8.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											str3 = "";
										}
										else
										{
											str3 = activeUnit.doctrine_0.method_225(num11, activeUnit, this.list_3[0], weapon) + ". ";
										}
										num8 = num11;
										bool? flag6;
										if (!((num8 != null) ? new bool?(num8.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											flag6 = new bool?(false);
										}
										else
										{
											num8 = num10;
											flag5 = ((num8 != null) ? new bool?(num8.GetValueOrDefault() == 0) : null);
											flag6 = ((flag5 != null) ? new bool?(!flag5.GetValueOrDefault()) : flag5);
										}
										flag5 = flag6;
										if (flag5.GetValueOrDefault())
										{
											text2 = "";
										}
										else
										{
											text2 = activeUnit.doctrine_0.method_226(num10) + ". ";
										}
									}
									if (this.list_3[0].contactType_0 != Contact_Base.ContactType.ActivationPoint)
									{
										Misc.PostureStance postureStance = this.list_3[0].method_130(activeUnit.vmethod_7(false));
										if (!Information.IsNothing(postureStance))
										{
											if (postureStance == Misc.PostureStance.Hostile)
											{
												if (@enum == Doctrine.Enum52.const_2)
												{
													flag4 = false;
													string_ = "Automatic fire is NOT allowed, Weapon Control Status (WCS) is WEAPONS HOLD";
												}
											}
											else if (postureStance == Misc.PostureStance.Unknown || postureStance == Misc.PostureStance.Unfriendly)
											{
												if (@enum == Doctrine.Enum52.const_1)
												{
													flag4 = false;
													string_ = "Automatic fire is NOT allowed, Weapon Control Status (WCS) is WEAPONS TIGHT and target is not identified as Hostile";
												}
												else if (@enum == Doctrine.Enum52.const_2)
												{
													flag4 = false;
													string_ = "Automatic fire is NOT allowed, Weapon Control Status (WCS) is WEAPONS HOLD";
												}
											}
										}
										else
										{
											flag4 = false;
											string_ = "COULD NOT DETERMINE CONTACT POSTURE STANCE!";
										}
									}
									else
									{
										flag4 = false;
										string_ = "Automatic fire is NOT possible, target is Bearing Only Launch (BOL) point or Impact point!";
									}
									if (flag4)
									{
										num8 = num10;
										if (((num8 != null) ? new bool?(num8.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											flag4 = false;
											string_ = "Automatic fire is NOT allowed, Weapon Release Authorization (WRA) says " + text2;
										}
										else
										{
											num8 = num11;
											if (((num8 != null) ? new bool?(num8.GetValueOrDefault() == 0) : null).GetValueOrDefault())
											{
												flag4 = false;
												string_ = "Automatic fire is NOT allowed, Weapon Release Authorization (WRA) says " + str3;
											}
										}
									}
									if (activeUnit.bool_3 && weapon.method_167() == Weapon._WeaponType.Gun && this.list_3[0].method_134())
									{
										Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets;
										if (Information.IsNothing(gunStrafeGroundTargets))
										{
											gunStrafeGroundTargets = activeUnit.doctrine_0.method_147(activeUnit.scenario_0, false, false, false);
										}
										byte? b = (gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
										if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											flag4 = false;
											string_ = "Automatic fire is NOT possible, doctrine says 'Do not use guns against ground and ship targets'";
										}
									}
									if (flag4)
									{
										if (dictionary.ContainsKey("OK"))
										{
											string_ = "Automatic fire is allowed.";
										}
										else
										{
											flag4 = false;
											string_ = "Automatic fire is NOT possible, " + Enumerable.ElementAtOrDefault<string>(dictionary.Keys, 0);
										}
									}
									Class127 class2 = new Class127();
									class2.method_7(string_);
									class2.Tag = "";
									if (flag4)
									{
										class2.method_39(Color.LightGreen);
									}
									else
									{
										class2.method_39(Color.Red);
									}
									@class.method_23().method_4(class2);
									Class127 class3 = new Class127();
									class3.method_7("Weapon Control Status (WCS): " + str);
									class3.Tag = "";
									class3.method_39(Color.DarkGray);
									@class.method_23().method_4(class3);
									Class127 class4 = new Class127();
									class4.method_7("Weapon Release Authorization (WRA): " + str3 + text2 + str2);
									class4.Tag = "";
									class4.method_39(Color.DarkGray);
									@class.method_23().method_4(class4);
								}
								try
								{
									foreach (KeyValuePair<string, int> keyValuePair in dictionary)
									{
										Class127 class5 = new Class127();
										string key = keyValuePair.Key;
										string str4 = Conversions.ToString(keyValuePair.Value);
										if (string.CompareOrdinal(key, "OK") == 0)
										{
											class5.method_7(str4 + "x can FIRE (manual weapon allocation)");
											class5.method_39(Color.LightGreen);
										}
										else
										{
											class5.method_7(str4 + "x can NOT fire. " + key);
											class5.method_39(Color.Red);
										}
										class5.Tag = key;
										@class.method_23().method_4(class5);
									}
								}
								finally
								{
									Dictionary<string, int>.Enumerator enumerator4;
									((IDisposable)enumerator4).Dispose();
								}
								@class.method_22(true);
							}
						}
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			if (!Information.IsNothing(this.nullable_0) && this.vmethod_36().method_22().Count == 0)
			{
				try
				{
					foreach (Class127 class6 in this.vmethod_36().method_20())
					{
						if (class6.method_36() == this.int_2)
						{
							try
							{
								foreach (Class127 class7 in class6.method_23())
								{
									if (class7.method_36() == this.nullable_0.Value)
									{
										this.bool_4 = false;
										this.vmethod_36().method_51(class7);
										this.bool_4 = true;
										break;
									}
								}
							}
							finally
							{
								List<Class127>.Enumerator enumerator6;
								((IDisposable)enumerator6).Dispose();
							}
						}
						if (this.vmethod_36().method_22().Count != 0)
						{
							break;
						}
					}
				}
				finally
				{
					List<Class127>.Enumerator enumerator5;
					((IDisposable)enumerator5).Dispose();
				}
			}
		}

		// Token: 0x06008B7A RID: 35706 RVA: 0x004B20A4 File Offset: 0x004B02A4
		private void method_15(object sender, EventArgs e)
		{
			this.list_2.Clear();
			try
			{
				foreach (Class117 @class in this.vmethod_32().method_21())
				{
					this.list_2.Add((ActiveUnit)@class.Tag);
				}
			}
			finally
			{
				List<Class117>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (this.list_2.Count == 1)
			{
				this.vmethod_42().Enabled = true;
			}
			else
			{
				this.vmethod_42().Enabled = false;
			}
			if (this.bool_4)
			{
				this.int_0 = this.vmethod_32().method_20()[0];
				this.method_14();
				this.method_6();
			}
		}

		// Token: 0x06008B7B RID: 35707 RVA: 0x004B216C File Offset: 0x004B036C
		private void method_16(object sender, EventArgs e)
		{
			this.list_3.Clear();
			try
			{
				foreach (Class117 @class in this.vmethod_10().method_21())
				{
					this.list_3.Add((Contact)@class.Tag);
				}
			}
			finally
			{
				List<Class117>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (this.bool_4)
			{
				if (this.vmethod_10().method_20().Count != 0)
				{
					this.int_1 = this.vmethod_10().method_20()[0];
				}
				this.method_14();
				this.method_6();
			}
		}

		// Token: 0x06008B7C RID: 35708 RVA: 0x000535BC File Offset: 0x000517BC
		private void method_17(object sender, EventArgs e)
		{
			this.method_6();
		}

		// Token: 0x06008B7D RID: 35709 RVA: 0x004B221C File Offset: 0x004B041C
		private void AttackTarget_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F1 && e.Modifiers == Keys.Shift && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06008B7E RID: 35710
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SendMessage(IntPtr intptr_0, int int_3, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x06008B7F RID: 35711 RVA: 0x004B22F8 File Offset: 0x004B04F8
		private void method_18()
		{
			try
			{
				AttackTarget.SendMessage(base.Handle, 11, new IntPtr(0), IntPtr.Zero);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200372", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008B80 RID: 35712 RVA: 0x004B2368 File Offset: 0x004B0568
		private void method_19(bool Refresh = true)
		{
			try
			{
				AttackTarget.SendMessage(base.Handle, 11, new IntPtr(-1), IntPtr.Zero);
				if (Refresh)
				{
					this.Refresh();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200373", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008B81 RID: 35713 RVA: 0x000535C4 File Offset: 0x000517C4
		private void method_20(object sender, EventArgs e)
		{
			if (this.list_2.Count == 1)
			{
				DoctrineForm doctrineForm = new DoctrineForm();
				doctrineForm.class310_0 = this.list_2[0];
				doctrineForm.Show();
				doctrineForm.vmethod_0().SelectedIndex = 2;
			}
		}

		// Token: 0x06008B82 RID: 35714 RVA: 0x004B23E0 File Offset: 0x004B05E0
		private void method_21(object sender, EventArgs e)
		{
			if (!Information.IsNothing(Client.smethod_54()) && !Information.IsNothing(Client.smethod_54().vmethod_7(false)) && ((Client.smethod_50().method_56().Count > 0 && !Information.IsNothing(Client.smethod_54())) || (Client.smethod_50().method_56().Count == 0 && !Information.IsNothing(Client.smethod_54()) && Information.IsNothing(Client.smethod_58()))))
			{
				try
				{
					foreach (Unit unit in Client.smethod_50().method_56())
					{
						if (unit.bool_0 && !unit.bool_2 && unit.vmethod_7(false) == Client.smethod_50())
						{
							ActiveUnit item = (ActiveUnit)unit;
							if (!this.list_1.Contains(item))
							{
								this.list_1.Add(item);
							}
						}
					}
				}
				finally
				{
					IEnumerator<Unit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.method_7();
			}
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x004B24E0 File Offset: 0x004B06E0
		private void method_22(object sender, EventArgs e)
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			if (this.list_2.Count > 0)
			{
				try
				{
					foreach (ActiveUnit item in this.list_2)
					{
						list.Add(item);
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			try
			{
				foreach (ActiveUnit item2 in list)
				{
					this.list_1.Remove(item2);
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			this.list_2.Clear();
			this.method_7();
			this.method_14();
		}

		// Token: 0x06008B84 RID: 35716 RVA: 0x004B25A4 File Offset: 0x004B07A4
		private void method_23(object sender, EventArgs e)
		{
			if (!Information.IsNothing(Client.smethod_54()) && Client.smethod_50().method_56().Count > 0 && !Information.IsNothing(Client.smethod_54()))
			{
				try
				{
					foreach (Unit unit in Client.smethod_50().method_56())
					{
						if (unit.method_14())
						{
							Contact item = (Contact)unit;
							if (!this.list_0.Contains(item))
							{
								this.list_0.Add(item);
							}
						}
					}
				}
				finally
				{
					IEnumerator<Unit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.method_8();
			}
		}

		// Token: 0x06008B85 RID: 35717 RVA: 0x004B2648 File Offset: 0x004B0848
		private void method_24(object sender, EventArgs e)
		{
			List<Contact> list = new List<Contact>();
			if (this.list_3.Count > 0)
			{
				try
				{
					foreach (Contact item in this.list_3)
					{
						list.Add(item);
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			try
			{
				foreach (Contact item2 in list)
				{
					this.list_0.Remove(item2);
				}
			}
			finally
			{
				List<Contact>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			this.list_3.Clear();
			this.method_8();
			this.method_14();
		}

		// Token: 0x06008B86 RID: 35718 RVA: 0x004B270C File Offset: 0x004B090C
		private void method_25(object sender, EventArgs e)
		{
			if (this.vmethod_36().method_22().Count != 0)
			{
				Class127 @class = this.vmethod_36().method_22()[0];
				Weapon weapon;
				if (@class.Tag.GetType() == typeof(string))
				{
					weapon = (Weapon)@class.method_28().Tag;
				}
				else
				{
					weapon = (Weapon)@class.Tag;
				}
				try
				{
					foreach (Contact contact in this.list_3)
					{
						List<ActiveUnit> list;
						ActiveUnit value = (list = this.list_2)[0];
						this.method_26(ref value, ref contact, ref weapon);
						list[0] = value;
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.method_14();
				this.method_6();
			}
		}

		// Token: 0x06008B87 RID: 35719 RVA: 0x004B27EC File Offset: 0x004B09EC
		private void method_26(ref ActiveUnit activeUnit_0, ref Contact contact_0, ref Weapon weapon_0)
		{
			try
			{
				Doctrine._WRA_WeaponTargetType wra_WeaponTargetType;
				if (weapon_0.class394_0.bool_5)
				{
					wra_WeaponTargetType = Doctrine._WRA_WeaponTargetType.Radar_Unspecified;
				}
				else
				{
					wra_WeaponTargetType = Doctrine.smethod_7(ref contact_0);
				}
				Doctrine doctrine_ = activeUnit_0.doctrine_0;
				Scenario scenario_ = activeUnit_0.scenario_0;
				Weapon theWeapon = weapon_0;
				Doctrine._WRA_WeaponTargetType selectedNodeTargetType = wra_WeaponTargetType;
				bool findInheritedValuesOnly = false;
				int? num = null;
				int? num2 = null;
				int? num3 = doctrine_.method_9(scenario_, theWeapon, selectedNodeTargetType, findInheritedValuesOnly, ref num, ref num2);
				if (!Information.IsNothing(num3))
				{
					num2 = num3;
					if (!((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						num2 = num3;
						if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
						{
							num3 = new int?(int.MaxValue);
						}
						else
						{
							num2 = num3;
							if (((num2 != null) ? new bool?(num2.GetValueOrDefault() < 0) : null).GetValueOrDefault())
							{
								num3 = activeUnit_0.vmethod_7(false).method_80(num3, ref activeUnit_0, ref contact_0, ref weapon_0);
							}
						}
						int num4 = activeUnit_0.vmethod_89().method_5(weapon_0.DBID, false);
						num4 -= activeUnit_0.vmethod_7(false).method_76(ref activeUnit_0, weapon_0.DBID);
						num2 = num3;
						if (((num2 != null) ? new bool?(num2.GetValueOrDefault() > num4) : null).GetValueOrDefault())
						{
							num3 = new int?(num4);
						}
						num2 = num3;
						if (((num2 != null) ? new bool?(num2.GetValueOrDefault() > 0) : null).GetValueOrDefault())
						{
							ActiveUnit_Weaponry activeUnit_Weaponry = activeUnit_0.vmethod_89();
							Contact contact_ = contact_0;
							int dbid = weapon_0.DBID;
							int value = num3.Value;
							bool bool_ = true;
							Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
							activeUnit_Weaponry.method_11(contact_, dbid, value, bool_, ref gunStrafeGroundTargets, DateTime.MinValue);
							Class2413.smethod_2().method_41().method_84();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101234", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008B88 RID: 35720 RVA: 0x004B2A3C File Offset: 0x004B0C3C
		private void method_27(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.vmethod_84().Value);
			if (Versioned.IsNumeric(this.vmethod_84().Value) && decimal.Compare(this.vmethod_84().Value, 0m) > 0 && this.vmethod_36().method_22().Count != 0)
			{
				Class127 @class = this.vmethod_36().method_22()[0];
				Weapon weapon;
				if (@class.Tag.GetType() == typeof(string))
				{
					weapon = (Weapon)@class.method_28().Tag;
				}
				else
				{
					weapon = (Weapon)@class.Tag;
				}
				try
				{
					foreach (Contact contact in this.list_3)
					{
						List<ActiveUnit> list;
						ActiveUnit value = (list = this.list_2)[0];
						this.method_28(ref value, ref contact, ref weapon, ref num);
						list[0] = value;
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.method_14();
				this.method_6();
			}
		}

		// Token: 0x06008B89 RID: 35721 RVA: 0x004B2B64 File Offset: 0x004B0D64
		private void method_28(ref ActiveUnit activeUnit_0, ref Contact contact_0, ref Weapon weapon_0, ref int int_3)
		{
			try
			{
				int num = activeUnit_0.vmethod_89().method_5(weapon_0.DBID, false);
				num -= activeUnit_0.vmethod_7(false).method_76(ref activeUnit_0, weapon_0.DBID);
				if (int_3 > num)
				{
					int_3 = num;
				}
				if (int_3 > 0)
				{
					ActiveUnit_Weaponry activeUnit_Weaponry = activeUnit_0.vmethod_89();
					Contact contact_ = contact_0;
					int dbid = weapon_0.DBID;
					int num2 = int_3;
					bool bool_ = true;
					Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
					activeUnit_Weaponry.method_11(contact_, dbid, num2, bool_, ref gunStrafeGroundTargets, DateTime.MinValue);
					Client.bool_1 = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101235", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008B8A RID: 35722 RVA: 0x004B2C28 File Offset: 0x004B0E28
		private void method_29(object sender, EventArgs e)
		{
			try
			{
				if (this.vmethod_36().method_22().Count != 0)
				{
					Class127 @class = this.vmethod_36().method_22()[0];
					Weapon weapon;
					if (@class.Tag.GetType() == typeof(string))
					{
						weapon = (Weapon)@class.method_28().Tag;
					}
					else
					{
						weapon = (Weapon)@class.Tag;
					}
					int num = this.list_2[0].vmethod_89().method_5(weapon.DBID, false);
					int num2 = num;
					Side side = this.list_2[0].vmethod_7(false);
					List<ActiveUnit> list;
					ActiveUnit value = (list = this.list_2)[0];
					int num3 = side.method_76(ref value, weapon.DBID);
					list[0] = value;
					num = num2 - num3;
					if (num > 0)
					{
						ActiveUnit_Weaponry activeUnit_Weaponry = this.list_2[0].vmethod_89();
						Contact contact_ = this.list_3[0];
						int dbid = weapon.DBID;
						int num4 = num;
						bool bool_ = true;
						Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
						activeUnit_Weaponry.method_11(contact_, dbid, num4, bool_, ref gunStrafeGroundTargets, DateTime.MinValue);
						Client.bool_1 = true;
					}
					this.method_14();
					this.method_6();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101236", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008B8B RID: 35723 RVA: 0x000535FC File Offset: 0x000517FC
		private void method_30(object sender, EventArgs e)
		{
			if (this.vmethod_20().SelectedIndex == 0)
			{
				this.method_33(true);
				return;
			}
			this.method_34(true);
		}

		// Token: 0x06008B8C RID: 35724 RVA: 0x0005361A File Offset: 0x0005181A
		private void method_31(object sender, EventArgs e)
		{
			if (this.vmethod_4().SelectedIndex == 0)
			{
				this.method_35(true);
				return;
			}
			this.method_36(true);
		}

		// Token: 0x06008B8D RID: 35725 RVA: 0x004B2D94 File Offset: 0x004B0F94
		private void method_32(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.vmethod_36().method_22().Count != 0)
				{
					if (this.list_3.Count <= 1)
					{
						Weapon weapon;
						if (this.vmethod_36().method_22()[0].Tag.GetType() == typeof(string))
						{
							weapon = (Weapon)this.vmethod_36().method_22()[0].method_28().Tag;
						}
						else
						{
							weapon = (Weapon)this.vmethod_36().method_22()[0].Tag;
						}
						if (!Enumerable.Contains<Contact>(this.list_2[0].vmethod_86().method_12(), this.list_3[0]))
						{
							this.list_2[0].vmethod_86().vmethod_12(this.list_3[0], true, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc);
						}
						ActiveUnit_Weaponry activeUnit_Weaponry = this.list_2[0].vmethod_89();
						Contact contact_ = this.list_3[0];
						int dbid = weapon.DBID;
						int num = 1;
						bool bool_ = true;
						Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
						activeUnit_Weaponry.method_11(contact_, dbid, num, bool_, ref gunStrafeGroundTargets, DateTime.MinValue);
						Client.bool_1 = true;
						this.method_14();
						this.method_6();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101237", "");
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008B8E RID: 35726 RVA: 0x004B2F18 File Offset: 0x004B1118
		private void method_33(bool bool_5)
		{
			if (this.vmethod_24().method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_24().method_22()[0].Tag)) && this.vmethod_24().method_22()[0].Tag.GetType() == typeof(Class316))
			{
				Class316 @class = (Class316)this.vmethod_24().method_22()[0].Tag;
				if (!Information.IsNothing(@class))
				{
					foreach (Class316.Class273 class2 in @class.class273_0)
					{
						try
						{
							foreach (ActiveUnit activeUnit in this.list_2)
							{
								if (Operators.CompareString(class2.string_0, activeUnit.string_0, false) == 0 && class2.int_0 - class2.int_1 > 0)
								{
									if (!bool_5)
									{
										class2.int_0--;
									}
									else
									{
										class2.int_0 = class2.int_1;
									}
									Side side = this.list_2[0].vmethod_7(false);
									Scenario scenario = Client.smethod_46();
									side.method_89(ref scenario, @class);
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					this.method_14();
					this.method_6();
				}
			}
		}

		// Token: 0x06008B8F RID: 35727 RVA: 0x004B3084 File Offset: 0x004B1284
		private void method_34(bool bool_5)
		{
			if (this.vmethod_28().method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_28().method_22()[0].Tag)) && this.vmethod_28().method_22()[0].Tag.GetType() == typeof(Class316))
			{
				Class316 @class = (Class316)this.vmethod_28().method_22()[0].Tag;
				if (!Information.IsNothing(@class))
				{
					foreach (Class316.Class273 class2 in @class.class273_0)
					{
						try
						{
							foreach (ActiveUnit activeUnit in this.list_2)
							{
								if (Operators.CompareString(class2.string_0, activeUnit.string_0, false) == 0 && class2.int_0 - class2.int_1 > 0)
								{
									if (!bool_5)
									{
										class2.int_0--;
									}
									else
									{
										class2.int_0 = class2.int_1;
									}
									Side side = this.list_2[0].vmethod_7(false);
									Scenario scenario = Client.smethod_46();
									side.method_89(ref scenario, @class);
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					this.method_14();
					this.method_6();
				}
			}
		}

		// Token: 0x06008B90 RID: 35728 RVA: 0x004B31F0 File Offset: 0x004B13F0
		private void method_35(bool bool_5)
		{
			if (this.vmethod_12().method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().method_22()[0].Tag)) && this.vmethod_12().method_22()[0].Tag.GetType() == typeof(Class316))
			{
				Class316 @class = (Class316)this.vmethod_12().method_22()[0].Tag;
				if (!Information.IsNothing(@class))
				{
					foreach (Class316.Class273 class2 in @class.class273_0)
					{
						if (Operators.CompareString(class2.string_0, this.list_2[0].string_0, false) == 0 && class2.int_0 - class2.int_1 > 0)
						{
							if (!bool_5)
							{
								class2.int_0--;
							}
							else
							{
								class2.int_0 = class2.int_1;
							}
							Side side = this.list_2[0].vmethod_7(false);
							Scenario scenario = Client.smethod_46();
							side.method_89(ref scenario, @class);
						}
					}
					this.method_14();
					this.method_6();
				}
			}
		}

		// Token: 0x06008B91 RID: 35729 RVA: 0x004B331C File Offset: 0x004B151C
		private void method_36(bool bool_5)
		{
			if (this.vmethod_14().method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_14().method_22()[0].Tag)) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_14().method_22()[0].method_28().Tag)) && this.vmethod_14().method_22()[0].Tag.GetType() == typeof(Class316))
			{
				Class316 @class = (Class316)this.vmethod_14().method_22()[0].Tag;
				if (!Information.IsNothing(@class))
				{
					foreach (Class316.Class273 class2 in @class.class273_0)
					{
						if (Operators.CompareString(class2.string_0, ((ActiveUnit)this.vmethod_14().method_22()[0].method_28().Tag).string_0, false) == 0 && class2.int_0 - class2.int_1 > 0)
						{
							if (!bool_5)
							{
								class2.int_0--;
							}
							else
							{
								class2.int_0 = class2.int_1;
							}
							Side side = this.list_2[0].vmethod_7(false);
							Scenario scenario = Client.smethod_46();
							side.method_89(ref scenario, @class);
						}
					}
					this.method_14();
					this.method_6();
				}
			}
		}

		// Token: 0x06008B92 RID: 35730 RVA: 0x000535BC File Offset: 0x000517BC
		private void method_37(object sender, EventArgs e)
		{
			this.method_6();
		}

		// Token: 0x06008B93 RID: 35731 RVA: 0x00053638 File Offset: 0x00051838
		private void method_38(object sender, EventArgs e)
		{
			if (this.bool_4)
			{
				Class570.class280_0.method_45(this.vmethod_70().Checked);
			}
		}

		// Token: 0x06008B94 RID: 35732 RVA: 0x00053657 File Offset: 0x00051857
		private void method_39(object sender, EventArgs e)
		{
			if (this.bool_4)
			{
				Class570.class280_0.method_47(this.vmethod_72().Checked);
				this.method_14();
			}
		}

		// Token: 0x06008B95 RID: 35733 RVA: 0x004B348C File Offset: 0x004B168C
		private void method_40(object sender, EventArgs e)
		{
			Class316 expression;
			if (this.vmethod_20().SelectedIndex == 0)
			{
				if (this.vmethod_24().method_22().Count == 0 || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_24().method_22()[0].Tag)) || this.vmethod_24().method_22()[0].Tag.GetType() != typeof(Class316))
				{
					return;
				}
				expression = (Class316)this.vmethod_24().method_22()[0].Tag;
				if (Information.IsNothing(expression))
				{
					return;
				}
			}
			else
			{
				if (this.vmethod_28().method_22().Count == 0 || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_28().method_22()[0].Tag)) || this.vmethod_28().method_22()[0].Tag.GetType() != typeof(Class316))
				{
					return;
				}
				expression = (Class316)this.vmethod_28().method_22()[0].Tag;
				if (Information.IsNothing(expression))
				{
					return;
				}
			}
			Client.class316_0 = expression;
			Client.smethod_62(Client.Enum197.const_23);
		}

		// Token: 0x06008B96 RID: 35734 RVA: 0x004B35C4 File Offset: 0x004B17C4
		private void method_41(object sender, EventArgs e)
		{
			Class316 @class;
			if (this.vmethod_20().SelectedIndex == 0)
			{
				if (this.vmethod_24().method_22().Count == 0 || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_24().method_22()[0].Tag)) || this.vmethod_24().method_22()[0].Tag.GetType() != typeof(Class316))
				{
					return;
				}
				@class = (Class316)this.vmethod_24().method_22()[0].Tag;
				if (Information.IsNothing(@class))
				{
					return;
				}
			}
			else
			{
				if (this.vmethod_28().method_22().Count == 0 || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_28().method_22()[0].Tag)) || this.vmethod_28().method_22()[0].Tag.GetType() != typeof(Class316))
				{
					return;
				}
				@class = (Class316)this.vmethod_28().method_22()[0].Tag;
				if (Information.IsNothing(@class))
				{
					return;
				}
			}
			if (!Information.IsNothing(@class))
			{
				Class429.smethod_38(ref @class.waypoint_0);
				this.imethod_0();
			}
		}

		// Token: 0x06008B97 RID: 35735 RVA: 0x004B3708 File Offset: 0x004B1908
		private void method_42(object sender, EventArgs e)
		{
			Class316 expression;
			if (this.vmethod_4().SelectedIndex == 0)
			{
				if (this.vmethod_12().method_22().Count == 0 || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().method_22()[0].Tag)) || this.vmethod_12().method_22()[0].Tag.GetType() != typeof(Class316))
				{
					return;
				}
				expression = (Class316)this.vmethod_12().method_22()[0].Tag;
				if (Information.IsNothing(expression))
				{
					return;
				}
			}
			else
			{
				if (this.vmethod_14().method_22().Count == 0 || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_14().method_22()[0].Tag)) || this.vmethod_14().method_22()[0].Tag.GetType() != typeof(Class316))
				{
					return;
				}
				expression = (Class316)this.vmethod_14().method_22()[0].Tag;
				if (Information.IsNothing(expression))
				{
					return;
				}
			}
			Client.class316_0 = expression;
			Client.smethod_62(Client.Enum197.const_23);
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x004B3840 File Offset: 0x004B1A40
		private void method_43(object sender, EventArgs e)
		{
			Class316 @class;
			if (this.vmethod_4().SelectedIndex == 0)
			{
				if (this.vmethod_12().method_22().Count == 0 || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().method_22()[0].Tag)) || this.vmethod_12().method_22()[0].Tag.GetType() != typeof(Class316))
				{
					return;
				}
				@class = (Class316)this.vmethod_12().method_22()[0].Tag;
				if (Information.IsNothing(@class))
				{
					return;
				}
			}
			else
			{
				if (this.vmethod_14().method_22().Count == 0 || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_14().method_22()[0].Tag)) || this.vmethod_14().method_22()[0].Tag.GetType() != typeof(Class316))
				{
					return;
				}
				@class = (Class316)this.vmethod_14().method_22()[0].Tag;
				if (Information.IsNothing(@class))
				{
					return;
				}
			}
			if (!Information.IsNothing(@class))
			{
				Class429.smethod_38(ref @class.waypoint_0);
				this.imethod_0();
			}
		}

		// Token: 0x06008B99 RID: 35737 RVA: 0x004B3984 File Offset: 0x004B1B84
		private void method_44(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.class316_0))
			{
				this.vmethod_86().Checked = !this.vmethod_86().Checked;
				if (this.vmethod_86().Checked)
				{
					this.class316_0.enum130_0 = Weapon.Enum130.const_1;
				}
				else
				{
					this.class316_0.enum130_0 = Weapon.Enum130.const_0;
				}
				this.imethod_0();
			}
		}

		// Token: 0x06008B9A RID: 35738 RVA: 0x004B39E4 File Offset: 0x004B1BE4
		private void method_45()
		{
			Weapon weapon = this.class316_0.method_11(Client.smethod_46());
			this.vmethod_86().Enabled = weapon.list_3.Contains(Weapon.Enum130.const_1);
			this.vmethod_86().Checked = (this.class316_0.enum130_0 == Weapon.Enum130.const_1);
		}

		// Token: 0x06008B9B RID: 35739 RVA: 0x0005367C File Offset: 0x0005187C
		private void method_46(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.method_50(this.vmethod_14(), e);
			}
		}

		// Token: 0x06008B9C RID: 35740 RVA: 0x00053698 File Offset: 0x00051898
		private void method_47(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.method_50(this.vmethod_12(), e);
			}
		}

		// Token: 0x06008B9D RID: 35741 RVA: 0x000536B4 File Offset: 0x000518B4
		private void method_48(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.method_50(this.vmethod_28(), e);
			}
		}

		// Token: 0x06008B9E RID: 35742 RVA: 0x000536D0 File Offset: 0x000518D0
		private void method_49(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.method_50(this.vmethod_24(), e);
			}
		}

		// Token: 0x06008B9F RID: 35743 RVA: 0x004B3A34 File Offset: 0x004B1C34
		private void method_50(Control6 control6_5, MouseEventArgs mouseEventArgs_0)
		{
			if (control6_5.method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(control6_5.method_22()[0].Tag)) && control6_5.method_22()[0].Tag.GetType() == typeof(Class316))
			{
				this.class316_0 = (Class316)control6_5.method_22()[0].Tag;
				this.method_45();
				this.vmethod_82().Show(control6_5, mouseEventArgs_0.X, mouseEventArgs_0.Y);
			}
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x000536EC File Offset: 0x000518EC
		private void method_51(object sender, MouseEventArgs e)
		{
			this.method_33(false);
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x000536F5 File Offset: 0x000518F5
		private void method_52(object sender, MouseEventArgs e)
		{
			this.method_34(false);
		}

		// Token: 0x06008BA2 RID: 35746 RVA: 0x004B3AC8 File Offset: 0x004B1CC8
		private void method_53(object sender, EventArgs e)
		{
			if (this.bool_4 && this.vmethod_36().method_22().Count > 0)
			{
				this.nullable_0 = new int?(this.vmethod_36().method_22()[0].method_36());
				if (!Information.IsNothing(this.vmethod_36().method_22()[0].method_28()))
				{
					this.int_2 = this.vmethod_36().method_22()[0].method_28().method_36();
				}
			}
			this.method_13();
		}

		// Token: 0x06008BA3 RID: 35747 RVA: 0x000536FE File Offset: 0x000518FE
		private void method_54(object sender, MouseEventArgs e)
		{
			this.method_35(false);
		}

		// Token: 0x06008BA4 RID: 35748 RVA: 0x00053707 File Offset: 0x00051907
		private void method_55(object sender, MouseEventArgs e)
		{
			this.method_36(false);
		}

		// Token: 0x06008BA5 RID: 35749 RVA: 0x00053710 File Offset: 0x00051910
		private void method_56(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x06008BA6 RID: 35750 RVA: 0x00053710 File Offset: 0x00051910
		private void method_57(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x06008BA7 RID: 35751 RVA: 0x00053710 File Offset: 0x00051910
		private void method_58(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x06008BA8 RID: 35752 RVA: 0x00053710 File Offset: 0x00051910
		private void method_59(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x04004B73 RID: 19315
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04004B74 RID: 19316
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x04004B75 RID: 19317
		[CompilerGenerated]
		[AccessedThroughProperty("TabControl4")]
		private Control12 control12_0;

		// Token: 0x04004B76 RID: 19318
		[CompilerGenerated]
		[AccessedThroughProperty("Tab_Target_BySelected")]
		private TabPage tabPage_0;

		// Token: 0x04004B77 RID: 19319
		[AccessedThroughProperty("Tab_Target_ByAnyone")]
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04004B78 RID: 19320
		[AccessedThroughProperty("LB_Targets")]
		[CompilerGenerated]
		private Control4 control4_0;

		// Token: 0x04004B79 RID: 19321
		[CompilerGenerated]
		[AccessedThroughProperty("TV_Allocations_ByAttackersOnly")]
		private Control6 control6_0;

		// Token: 0x04004B7A RID: 19322
		[CompilerGenerated]
		[AccessedThroughProperty("TV_Allocations_ByAnyone")]
		private Control6 control6_1;

		// Token: 0x04004B7B RID: 19323
		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private Timer timer_0;

		// Token: 0x04004B7C RID: 19324
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_2;

		// Token: 0x04004B7D RID: 19325
		[AccessedThroughProperty("TabControl2")]
		[CompilerGenerated]
		private Control12 control12_1;

		// Token: 0x04004B7E RID: 19326
		[CompilerGenerated]
		[AccessedThroughProperty("Tab_Attacker_ToSelectedOnly")]
		private TabPage tabPage_2;

		// Token: 0x04004B7F RID: 19327
		[AccessedThroughProperty("TV_Allocations_ToTargetsOnly")]
		[CompilerGenerated]
		private Control6 control6_2;

		// Token: 0x04004B80 RID: 19328
		[CompilerGenerated]
		[AccessedThroughProperty("Tab_Attacker_ToAnyone")]
		private TabPage tabPage_3;

		// Token: 0x04004B81 RID: 19329
		[CompilerGenerated]
		[AccessedThroughProperty("TV_Allocations_ToAnyone")]
		private Control6 control6_3;

		// Token: 0x04004B82 RID: 19330
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_3;

		// Token: 0x04004B83 RID: 19331
		[CompilerGenerated]
		[AccessedThroughProperty("LB_Attackers")]
		private Control4 control4_1;

		// Token: 0x04004B84 RID: 19332
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x04004B85 RID: 19333
		[CompilerGenerated]
		[AccessedThroughProperty("TV_AvailableWeapons")]
		private Control6 control6_4;

		// Token: 0x04004B86 RID: 19334
		[AccessedThroughProperty("Button_Allocate")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04004B87 RID: 19335
		[CompilerGenerated]
		[AccessedThroughProperty("Button_AllocateAllWeapons")]
		private Control9 control9_1;

		// Token: 0x04004B88 RID: 19336
		[CompilerGenerated]
		[AccessedThroughProperty("Button_UnitWRA")]
		private Control9 control9_2;

		// Token: 0x04004B89 RID: 19337
		[CompilerGenerated]
		[AccessedThroughProperty("Button_AddAttacker")]
		private Control9 control9_3;

		// Token: 0x04004B8A RID: 19338
		[AccessedThroughProperty("Button_AddTarget")]
		[CompilerGenerated]
		private Control9 control9_4;

		// Token: 0x04004B8B RID: 19339
		[CompilerGenerated]
		[AccessedThroughProperty("Button_RemoveAttacker")]
		private Control9 control9_5;

		// Token: 0x04004B8C RID: 19340
		[AccessedThroughProperty("Button_RemoveTargets")]
		[CompilerGenerated]
		private Control9 control9_6;

		// Token: 0x04004B8D RID: 19341
		[CompilerGenerated]
		[AccessedThroughProperty("Button_AllocateSalvo")]
		private Control9 control9_7;

		// Token: 0x04004B8E RID: 19342
		[AccessedThroughProperty("Button_RemoveWeapons_Target")]
		[CompilerGenerated]
		private Control9 control9_8;

		// Token: 0x04004B8F RID: 19343
		[CompilerGenerated]
		[AccessedThroughProperty("Button_RemoveWeapons_Attacker")]
		private Control9 control9_9;

		// Token: 0x04004B90 RID: 19344
		[CompilerGenerated]
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x04004B91 RID: 19345
		[AccessedThroughProperty("Panel1")]
		[CompilerGenerated]
		private Panel panel_0;

		// Token: 0x04004B92 RID: 19346
		[CompilerGenerated]
		[AccessedThroughProperty("Panel2")]
		private Panel panel_1;

		// Token: 0x04004B93 RID: 19347
		[AccessedThroughProperty("Panel3")]
		[CompilerGenerated]
		private Panel panel_2;

		// Token: 0x04004B94 RID: 19348
		[AccessedThroughProperty("Panel4")]
		[CompilerGenerated]
		private Panel panel_3;

		// Token: 0x04004B95 RID: 19349
		[AccessedThroughProperty("Panel5")]
		[CompilerGenerated]
		private Panel panel_4;

		// Token: 0x04004B96 RID: 19350
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AllowTimeout")]
		private Class112 class112_0;

		// Token: 0x04004B97 RID: 19351
		[AccessedThroughProperty("CB_ShowAutomaticFireInfo")]
		[CompilerGenerated]
		private Class112 class112_1;

		// Token: 0x04004B98 RID: 19352
		[AccessedThroughProperty("Button_ClearCourse_Attacker")]
		[CompilerGenerated]
		private Control9 control9_10;

		// Token: 0x04004B99 RID: 19353
		[AccessedThroughProperty("Button_PlotCourse_Attacker")]
		[CompilerGenerated]
		private Control9 control9_11;

		// Token: 0x04004B9A RID: 19354
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ClearCourse_Target")]
		private Control9 control9_12;

		// Token: 0x04004B9B RID: 19355
		[AccessedThroughProperty("Button_PlotCourse_Target")]
		[CompilerGenerated]
		private Control9 control9_13;

		// Token: 0x04004B9C RID: 19356
		[CompilerGenerated]
		[AccessedThroughProperty("SalvoContextMenu")]
		private Class113 class113_0;

		// Token: 0x04004B9D RID: 19357
		[CompilerGenerated]
		[AccessedThroughProperty("NUD_NumberOfWeapons")]
		private Class120 class120_0;

		// Token: 0x04004B9E RID: 19358
		[CompilerGenerated]
		[AccessedThroughProperty("TSMI_HighAltitudeDetonation")]
		private Class128 class128_0;

		// Token: 0x04004B9F RID: 19359
		public List<Contact> list_0;

		// Token: 0x04004BA0 RID: 19360
		public List<ActiveUnit> list_1;

		// Token: 0x04004BA1 RID: 19361
		private List<ActiveUnit> list_2;

		// Token: 0x04004BA2 RID: 19362
		private int int_0;

		// Token: 0x04004BA3 RID: 19363
		private List<Contact> list_3;

		// Token: 0x04004BA4 RID: 19364
		private int int_1;

		// Token: 0x04004BA5 RID: 19365
		private int? nullable_0;

		// Token: 0x04004BA6 RID: 19366
		private int int_2;

		// Token: 0x04004BA7 RID: 19367
		private bool bool_3;

		// Token: 0x04004BA8 RID: 19368
		private bool bool_4;

		// Token: 0x04004BA9 RID: 19369
		private string string_0;

		// Token: 0x04004BAA RID: 19370
		private Class316 class316_0;
	}
}
