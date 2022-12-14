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
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MSDN.Html.Editor;
using ns10;
using ns13;
using ns2;
using ns3;
using ns4;
using ns5;
using ns9;

namespace Command
{
	// Token: 0x02000EAD RID: 3757
	[DesignerGenerated]
	public sealed partial class EditAction : DarkSecondaryFormBase
	{
		// Token: 0x06007841 RID: 30785 RVA: 0x00417D04 File Offset: 0x00415F04
		public EditAction()
		{
			base.FormClosing += this.EditAction_FormClosing;
			base.Load += this.EditAction_Load;
			base.KeyDown += this.EditAction_KeyDown;
			this.InitializeComponent_1();
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x00417D94 File Offset: 0x00415F94
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control8());
			this.vmethod_3(new Class116());
			this.vmethod_5(new Control12());
			this.vmethod_7(new TabPage());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Class120());
			this.vmethod_19(new Class2451());
			this.vmethod_21(new Class116());
			this.vmethod_23(new Class116());
			this.vmethod_25(new TabPage());
			this.vmethod_27(new TabPage());
			this.vmethod_33(new AreaEditor());
			this.vmethod_29(new Control4());
			this.vmethod_31(new Class116());
			this.vmethod_35(new TabPage());
			this.vmethod_73(new Control9());
			this.vmethod_57(new HtmlEditorControl());
			this.vmethod_37(new Class2451());
			this.vmethod_39(new Class116());
			this.vmethod_41(new Class116());
			this.vmethod_43(new TabPage());
			this.vmethod_55(new Class2451());
			this.vmethod_45(new Class116());
			this.vmethod_47(new Class2451());
			this.vmethod_49(new Class2451());
			this.vmethod_51(new Class116());
			this.vmethod_53(new Class116());
			this.vmethod_59(new TabPage());
			this.vmethod_69(new Control10());
			this.vmethod_71(new Class116());
			this.vmethod_61(new Control9());
			this.vmethod_63(new Class2451());
			this.vmethod_65(new Class116());
			this.vmethod_67(new Class124());
			this.vmethod_9(new Class116());
			this.vmethod_11(new Control9());
			this.vmethod_13(new Control9());
			this.vmethod_4().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			((ISupportInitialize)this.vmethod_16()).BeginInit();
			this.vmethod_26().SuspendLayout();
			this.vmethod_34().SuspendLayout();
			this.vmethod_42().SuspendLayout();
			this.vmethod_58().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().method_14(null);
			this.vmethod_0().method_15(AutoCompleteMode.None);
			this.vmethod_0().method_13(AutoCompleteSource.None);
			this.vmethod_0().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_0().method_17(new Font("Segoe UI", 10f));
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().method_12(null);
			this.vmethod_0().method_18(null);
			this.vmethod_0().Location = new Point(90, 12);
			this.vmethod_0().method_2(32767);
			this.vmethod_0().method_7(false);
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().method_3(false);
			this.vmethod_0().method_19(ScrollBars.None);
			this.vmethod_0().method_9(0);
			this.vmethod_0().Size = new Size(632, 20);
			this.vmethod_0().TabIndex = 6;
			this.vmethod_0().method_1(HorizontalAlignment.Left);
			this.vmethod_0().method_5(false);
			this.vmethod_0().method_10("");
			this.vmethod_2().method_2(true);
			this.vmethod_2().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(4, 16);
			this.vmethod_2().Name = "Label2";
			this.vmethod_2().Size = new Size(69, 13);
			this.vmethod_2().TabIndex = 5;
			this.vmethod_2().Text = "Description:";
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_4().Controls.Add(this.vmethod_6());
			this.vmethod_4().Controls.Add(this.vmethod_24());
			this.vmethod_4().Controls.Add(this.vmethod_26());
			this.vmethod_4().Controls.Add(this.vmethod_34());
			this.vmethod_4().Controls.Add(this.vmethod_42());
			this.vmethod_4().Controls.Add(this.vmethod_58());
			this.vmethod_4().Cursor = Cursors.Hand;
			this.vmethod_4().Font = new Font("Segoe UI", 8f);
			this.vmethod_4().ItemSize = new Size(80, 20);
			this.vmethod_4().Location = new Point(4, 64);
			this.vmethod_4().Multiline = true;
			this.vmethod_4().Name = "TC_ActionOptions";
			this.vmethod_4().SelectedIndex = 0;
			this.vmethod_4().Size = new Size(722, 382);
			this.vmethod_4().TabIndex = 22;
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().Controls.Add(this.vmethod_14());
			this.vmethod_6().Controls.Add(this.vmethod_16());
			this.vmethod_6().Controls.Add(this.vmethod_18());
			this.vmethod_6().Controls.Add(this.vmethod_20());
			this.vmethod_6().Controls.Add(this.vmethod_22());
			this.vmethod_6().Location = new Point(4, 24);
			this.vmethod_6().Name = "TabPage1";
			this.vmethod_6().Padding = new Padding(3);
			this.vmethod_6().Size = new Size(714, 354);
			this.vmethod_6().TabIndex = 0;
			this.vmethod_6().Text = "Points";
			this.vmethod_14().method_2(true);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(372, 120);
			this.vmethod_14().Name = "Label5";
			this.vmethod_14().Size = new Size(116, 13);
			this.vmethod_14().TabIndex = 4;
			this.vmethod_14().Text = "(negative to subtract)";
			this.vmethod_16().BackColor = Color.FromArgb(35, 35, 35);
			this.vmethod_16().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_16().Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.vmethod_16().ForeColor = Color.White;
			this.vmethod_16().Location = new Point(174, 113);
			NumericUpDown numericUpDown = this.vmethod_16();
			int[] array = new int[4];
			array[0] = 999999;
			numericUpDown.Maximum = new decimal(array);
			this.vmethod_16().Minimum = new decimal(new int[]
			{
				999999,
				0,
				0,
				int.MinValue
			});
			this.vmethod_16().Name = "NUD_Points";
			this.vmethod_16().Size = new Size(192, 29);
			this.vmethod_16().TabIndex = 3;
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_18().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_18().Font = new Font("Segoe UI", 7f);
			this.vmethod_18().FormattingEnabled = true;
			this.vmethod_18().Location = new Point(174, 85);
			this.vmethod_18().Name = "CB_Points_Sides";
			this.vmethod_18().Size = new Size(192, 21);
			this.vmethod_18().TabIndex = 2;
			this.vmethod_20().method_2(true);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Location = new Point(89, 121);
			this.vmethod_20().Name = "Label4";
			this.vmethod_20().Size = new Size(80, 13);
			this.vmethod_20().TabIndex = 1;
			this.vmethod_20().Text = "Point Change:";
			this.vmethod_22().method_2(true);
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().Location = new Point(137, 88);
			this.vmethod_22().Name = "Label1";
			this.vmethod_22().Size = new Size(32, 13);
			this.vmethod_22().TabIndex = 0;
			this.vmethod_22().Text = "Side:";
			this.vmethod_24().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_24().Location = new Point(4, 24);
			this.vmethod_24().Name = "TabPage2";
			this.vmethod_24().Padding = new Padding(3);
			this.vmethod_24().Size = new Size(714, 354);
			this.vmethod_24().TabIndex = 1;
			this.vmethod_24().Text = "End Scenario";
			this.vmethod_26().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_26().Controls.Add(this.vmethod_32());
			this.vmethod_26().Controls.Add(this.vmethod_28());
			this.vmethod_26().Controls.Add(this.vmethod_30());
			this.vmethod_26().Location = new Point(4, 24);
			this.vmethod_26().Name = "TabPage3";
			this.vmethod_26().Padding = new Padding(3);
			this.vmethod_26().Size = new Size(714, 354);
			this.vmethod_26().TabIndex = 2;
			this.vmethod_26().Text = "Teleport in Area";
			this.vmethod_32().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_32().Location = new Point(356, 7);
			this.vmethod_32().Name = "AreaEditor1";
			this.vmethod_32().Size = new Size(351, 124);
			this.vmethod_32().TabIndex = 2;
			this.vmethod_32().method_1("Edit teleport area");
			this.vmethod_28().Location = new Point(10, 23);
			this.vmethod_28().Name = "ListBox_UnitsToTeleport";
			this.vmethod_28().Size = new Size(340, 316);
			this.vmethod_28().TabIndex = 1;
			this.vmethod_30().method_2(true);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Location = new Point(7, 7);
			this.vmethod_30().Name = "Label6";
			this.vmethod_30().Size = new Size(152, 13);
			this.vmethod_30().TabIndex = 0;
			this.vmethod_30().Text = "Highlight unit(s) to teleport:";
			this.vmethod_34().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_34().Controls.Add(this.vmethod_72());
			this.vmethod_34().Controls.Add(this.vmethod_56());
			this.vmethod_34().Controls.Add(this.vmethod_36());
			this.vmethod_34().Controls.Add(this.vmethod_38());
			this.vmethod_34().Controls.Add(this.vmethod_40());
			this.vmethod_34().Location = new Point(4, 24);
			this.vmethod_34().Name = "TabPage4";
			this.vmethod_34().Size = new Size(714, 354);
			this.vmethod_34().TabIndex = 3;
			this.vmethod_34().Text = "Message";
			this.vmethod_72().BackColor = Color.Transparent;
			this.vmethod_72().DialogResult = DialogResult.None;
			this.vmethod_72().Font = new Font("Segoe UI", 10f);
			this.vmethod_72().ForeColor = SystemColors.Control;
			this.vmethod_72().Location = new Point(636, 18);
			this.vmethod_72().Name = "Button3";
			this.vmethod_72().Padding = new Padding(5);
			this.vmethod_72().method_1(0);
			this.vmethod_72().Size = new Size(75, 23);
			this.vmethod_72().TabIndex = 29;
			this.vmethod_72().Text = "Edit HTML";
			this.vmethod_56().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_56().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_56().BodyBackColor = Color.FromArgb(43, 43, 43);
			this.vmethod_56().BodyForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_56().BorderSize = 0;
			this.vmethod_56().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_56().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_56().InnerText = null;
			this.vmethod_56().Location = new Point(72, 47);
			this.vmethod_56().Name = "Editor_Message_Text";
			this.vmethod_56().Size = new Size(639, 307);
			this.vmethod_56().TabIndex = 28;
			this.vmethod_36().BackColor = Color.Transparent;
			this.vmethod_36().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_36().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_36().Font = new Font("Segoe UI", 7f);
			this.vmethod_36().FormattingEnabled = true;
			this.vmethod_36().Location = new Point(73, 14);
			this.vmethod_36().Name = "CB_Message_Side";
			this.vmethod_36().Size = new Size(231, 21);
			this.vmethod_36().TabIndex = 7;
			this.vmethod_38().method_2(true);
			this.vmethod_38().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_38().Location = new Point(13, 47);
			this.vmethod_38().Name = "Label8";
			this.vmethod_38().Size = new Size(55, 13);
			this.vmethod_38().TabIndex = 6;
			this.vmethod_38().Text = "Message:";
			this.vmethod_40().method_2(true);
			this.vmethod_40().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_40().Location = new Point(13, 17);
			this.vmethod_40().Name = "Label9";
			this.vmethod_40().Size = new Size(32, 13);
			this.vmethod_40().TabIndex = 5;
			this.vmethod_40().Text = "Side:";
			this.vmethod_42().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_42().Controls.Add(this.vmethod_54());
			this.vmethod_42().Controls.Add(this.vmethod_44());
			this.vmethod_42().Controls.Add(this.vmethod_46());
			this.vmethod_42().Controls.Add(this.vmethod_48());
			this.vmethod_42().Controls.Add(this.vmethod_50());
			this.vmethod_42().Controls.Add(this.vmethod_52());
			this.vmethod_42().Location = new Point(4, 24);
			this.vmethod_42().Name = "TabPage5";
			this.vmethod_42().Size = new Size(714, 354);
			this.vmethod_42().TabIndex = 4;
			this.vmethod_42().Text = "Mission Status";
			this.vmethod_54().BackColor = Color.Transparent;
			this.vmethod_54().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_54().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_54().Font = new Font("Segoe UI", 7f);
			this.vmethod_54().FormattingEnabled = true;
			this.vmethod_54().Items.AddRange(new object[]
			{
				"Active",
				"Inactive"
			});
			this.vmethod_54().Location = new Point(73, 68);
			this.vmethod_54().Name = "CB_MissionStatus_Status";
			this.vmethod_54().Size = new Size(231, 21);
			this.vmethod_54().TabIndex = 14;
			this.vmethod_44().method_2(true);
			this.vmethod_44().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_44().Location = new Point(13, 71);
			this.vmethod_44().Name = "Label11";
			this.vmethod_44().Size = new Size(67, 13);
			this.vmethod_44().TabIndex = 13;
			this.vmethod_44().Text = "New status:";
			this.vmethod_46().BackColor = Color.Transparent;
			this.vmethod_46().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_46().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_46().Font = new Font("Segoe UI", 7f);
			this.vmethod_46().FormattingEnabled = true;
			this.vmethod_46().Location = new Point(73, 41);
			this.vmethod_46().Name = "CB_MissionStatus_Mission";
			this.vmethod_46().Size = new Size(231, 21);
			this.vmethod_46().TabIndex = 12;
			this.vmethod_48().BackColor = Color.Transparent;
			this.vmethod_48().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_48().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_48().Font = new Font("Segoe UI", 7f);
			this.vmethod_48().FormattingEnabled = true;
			this.vmethod_48().Location = new Point(73, 14);
			this.vmethod_48().Name = "CB_MissionStatus_Side";
			this.vmethod_48().Size = new Size(231, 21);
			this.vmethod_48().TabIndex = 11;
			this.vmethod_50().method_2(true);
			this.vmethod_50().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_50().Location = new Point(13, 44);
			this.vmethod_50().Name = "Label7";
			this.vmethod_50().Size = new Size(50, 13);
			this.vmethod_50().TabIndex = 10;
			this.vmethod_50().Text = "Mission:";
			this.vmethod_52().method_2(true);
			this.vmethod_52().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_52().Location = new Point(13, 17);
			this.vmethod_52().Name = "Label10";
			this.vmethod_52().Size = new Size(32, 13);
			this.vmethod_52().TabIndex = 9;
			this.vmethod_52().Text = "Side:";
			this.vmethod_58().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_58().Controls.Add(this.vmethod_68());
			this.vmethod_58().Controls.Add(this.vmethod_70());
			this.vmethod_58().Controls.Add(this.vmethod_60());
			this.vmethod_58().Controls.Add(this.vmethod_62());
			this.vmethod_58().Controls.Add(this.vmethod_64());
			this.vmethod_58().Controls.Add(this.vmethod_66());
			this.vmethod_58().Location = new Point(4, 24);
			this.vmethod_58().Name = "TabPage6";
			this.vmethod_58().Padding = new Padding(3);
			this.vmethod_58().Size = new Size(714, 354);
			this.vmethod_58().TabIndex = 5;
			this.vmethod_58().Text = "Lua script";
			this.vmethod_68().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_68().Font = new Font("Segoe UI", 10f);
			this.vmethod_68().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_68().Location = new Point(660, 7);
			this.vmethod_68().method_1(100);
			this.vmethod_68().method_3(0);
			this.vmethod_68().Name = "NUD_LuaScript";
			this.vmethod_68().Size = new Size(54, 26);
			this.vmethod_68().TabIndex = 5;
			this.vmethod_68().Value = 0;
			this.vmethod_70().method_2(true);
			this.vmethod_70().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_70().Location = new Point(600, 13);
			this.vmethod_70().Name = "Label13";
			this.vmethod_70().Size = new Size(52, 13);
			this.vmethod_70().TabIndex = 4;
			this.vmethod_70().Text = "Text Size:";
			this.vmethod_60().BackColor = Color.Transparent;
			this.vmethod_60().DialogResult = DialogResult.None;
			this.vmethod_60().Font = new Font("Segoe UI", 10f);
			this.vmethod_60().ForeColor = SystemColors.Control;
			this.vmethod_60().Location = new Point(521, 9);
			this.vmethod_60().Name = "Button_AddLuaScript";
			this.vmethod_60().Padding = new Padding(5);
			this.vmethod_60().method_1(0);
			this.vmethod_60().Size = new Size(75, 21);
			this.vmethod_60().TabIndex = 3;
			this.vmethod_60().Text = "ADD";
			this.vmethod_62().BackColor = Color.Transparent;
			this.vmethod_62().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_62().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_62().Font = new Font("Segoe UI", 7f);
			this.vmethod_62().FormattingEnabled = true;
			this.vmethod_62().Location = new Point(109, 9);
			this.vmethod_62().Name = "CB_LuaTemplate";
			this.vmethod_62().Size = new Size(406, 21);
			this.vmethod_62().TabIndex = 2;
			this.vmethod_64().method_2(true);
			this.vmethod_64().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_64().Location = new Point(6, 12);
			this.vmethod_64().Name = "Label12";
			this.vmethod_64().Size = new Size(110, 13);
			this.vmethod_64().TabIndex = 1;
			this.vmethod_64().Text = "Add script template:";
			this.vmethod_66().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_66().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_66().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_66().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_66().Location = new Point(0, 37);
			this.vmethod_66().MaxLength = 999999999;
			this.vmethod_66().Multiline = true;
			this.vmethod_66().Name = "TextBox2";
			this.vmethod_66().ScrollBars = ScrollBars.Both;
			this.vmethod_66().Size = new Size(714, 317);
			this.vmethod_66().TabIndex = 0;
			this.vmethod_8().method_2(true);
			this.vmethod_8().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(3, 48);
			this.vmethod_8().Name = "Label3";
			this.vmethod_8().Size = new Size(102, 13);
			this.vmethod_8().TabIndex = 21;
			this.vmethod_8().Text = "Settings for action";
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DialogResult = DialogResult.None;
			this.vmethod_10().Font = new Font("Segoe UI", 10f);
			this.vmethod_10().ForeColor = SystemColors.Control;
			this.vmethod_10().Location = new Point(651, 448);
			this.vmethod_10().Name = "Button2";
			this.vmethod_10().Padding = new Padding(5);
			this.vmethod_10().method_1(0);
			this.vmethod_10().Size = new Size(75, 23);
			this.vmethod_10().TabIndex = 24;
			this.vmethod_10().Text = "Cancel";
			this.vmethod_12().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font("Segoe UI", 10f);
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(4, 448);
			this.vmethod_12().Name = "Button1";
			this.vmethod_12().Padding = new Padding(5);
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(75, 23);
			this.vmethod_12().TabIndex = 23;
			this.vmethod_12().Text = "OK";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(727, 473);
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditAction";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Edit event action";
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_6().PerformLayout();
			((ISupportInitialize)this.vmethod_16()).EndInit();
			this.vmethod_26().ResumeLayout(false);
			this.vmethod_26().PerformLayout();
			this.vmethod_34().ResumeLayout(false);
			this.vmethod_34().PerformLayout();
			this.vmethod_42().ResumeLayout(false);
			this.vmethod_42().PerformLayout();
			this.vmethod_58().ResumeLayout(false);
			this.vmethod_58().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x0004A6E2 File Offset: 0x000488E2
		[CompilerGenerated]
		internal Control8 vmethod_0()
		{
			return this.control8_0;
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x004199C4 File Offset: 0x00417BC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control8 control8_1)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_15);
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

		// Token: 0x06007846 RID: 30790 RVA: 0x0004A6EA File Offset: 0x000488EA
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x0004A6F2 File Offset: 0x000488F2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_13)
		{
			this.class116_0 = class116_13;
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x0004A6FB File Offset: 0x000488FB
		[CompilerGenerated]
		internal Control12 vmethod_4()
		{
			return this.control12_0;
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x0004A703 File Offset: 0x00048903
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control12 control12_1)
		{
			this.control12_0 = control12_1;
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x0004A70C File Offset: 0x0004890C
		[CompilerGenerated]
		internal TabPage vmethod_6()
		{
			return this.tabPage_0;
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x0004A714 File Offset: 0x00048914
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TabPage tabPage_6)
		{
			this.tabPage_0 = tabPage_6;
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x0004A71D File Offset: 0x0004891D
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_1;
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x0004A725 File Offset: 0x00048925
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_13)
		{
			this.class116_1 = class116_13;
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x0004A72E File Offset: 0x0004892E
		[CompilerGenerated]
		internal Control9 vmethod_10()
		{
			return this.control9_0;
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x00419A08 File Offset: 0x00417C08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_4;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x0004A736 File Offset: 0x00048936
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_1;
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x00419A4C File Offset: 0x00417C4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_4;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x0004A73E File Offset: 0x0004893E
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_2;
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x0004A746 File Offset: 0x00048946
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_13)
		{
			this.class116_2 = class116_13;
		}

		// Token: 0x06007854 RID: 30804 RVA: 0x0004A74F File Offset: 0x0004894F
		[CompilerGenerated]
		internal Class120 vmethod_16()
		{
			return this.class120_0;
		}

		// Token: 0x06007855 RID: 30805 RVA: 0x00419A90 File Offset: 0x00417C90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class120 class120_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			Class120 @class = this.class120_0;
			if (@class != null)
			{
				@class.TextChanged -= value;
			}
			this.class120_0 = class120_1;
			@class = this.class120_0;
			if (@class != null)
			{
				@class.TextChanged += value;
			}
		}

		// Token: 0x06007856 RID: 30806 RVA: 0x0004A757 File Offset: 0x00048957
		[CompilerGenerated]
		internal Class2451 vmethod_18()
		{
			return this.class2451_0;
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x00419AD4 File Offset: 0x00417CD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class2451 class2451_6)
		{
			EventHandler value = new EventHandler(this.method_5);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_6;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x0004A75F File Offset: 0x0004895F
		[CompilerGenerated]
		internal Class116 vmethod_20()
		{
			return this.class116_3;
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x0004A767 File Offset: 0x00048967
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class116 class116_13)
		{
			this.class116_3 = class116_13;
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x0004A770 File Offset: 0x00048970
		[CompilerGenerated]
		internal Class116 vmethod_22()
		{
			return this.class116_4;
		}

		// Token: 0x0600785B RID: 30811 RVA: 0x0004A778 File Offset: 0x00048978
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class116 class116_13)
		{
			this.class116_4 = class116_13;
		}

		// Token: 0x0600785C RID: 30812 RVA: 0x0004A781 File Offset: 0x00048981
		[CompilerGenerated]
		internal TabPage vmethod_24()
		{
			return this.tabPage_1;
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x0004A789 File Offset: 0x00048989
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(TabPage tabPage_6)
		{
			this.tabPage_1 = tabPage_6;
		}

		// Token: 0x0600785E RID: 30814 RVA: 0x0004A792 File Offset: 0x00048992
		[CompilerGenerated]
		internal TabPage vmethod_26()
		{
			return this.tabPage_2;
		}

		// Token: 0x0600785F RID: 30815 RVA: 0x0004A79A File Offset: 0x0004899A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(TabPage tabPage_6)
		{
			this.tabPage_2 = tabPage_6;
		}

		// Token: 0x06007860 RID: 30816 RVA: 0x0004A7A3 File Offset: 0x000489A3
		[CompilerGenerated]
		internal Control4 vmethod_28()
		{
			return this.control4_0;
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x00419B18 File Offset: 0x00417D18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Control4 control4_1)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_7);
			Control4 control = this.control4_0;
			if (control != null)
			{
				control.method_17(eventHandler_);
			}
			this.control4_0 = control4_1;
			control = this.control4_0;
			if (control != null)
			{
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x0004A7AB File Offset: 0x000489AB
		[CompilerGenerated]
		internal Class116 vmethod_30()
		{
			return this.class116_5;
		}

		// Token: 0x06007863 RID: 30819 RVA: 0x0004A7B3 File Offset: 0x000489B3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class116 class116_13)
		{
			this.class116_5 = class116_13;
		}

		// Token: 0x06007864 RID: 30820 RVA: 0x0004A7BC File Offset: 0x000489BC
		[CompilerGenerated]
		internal AreaEditor vmethod_32()
		{
			return this.areaEditor_0;
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x0004A7C4 File Offset: 0x000489C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(AreaEditor areaEditor_1)
		{
			this.areaEditor_0 = areaEditor_1;
		}

		// Token: 0x06007866 RID: 30822 RVA: 0x0004A7CD File Offset: 0x000489CD
		[CompilerGenerated]
		internal TabPage vmethod_34()
		{
			return this.tabPage_3;
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x0004A7D5 File Offset: 0x000489D5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(TabPage tabPage_6)
		{
			this.tabPage_3 = tabPage_6;
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x0004A7DE File Offset: 0x000489DE
		[CompilerGenerated]
		internal Class2451 vmethod_36()
		{
			return this.class2451_1;
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x00419B5C File Offset: 0x00417D5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class2451 class2451_6)
		{
			EventHandler value = new EventHandler(this.method_8);
			Class2451 @class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_1 = class2451_6;
			@class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x0004A7E6 File Offset: 0x000489E6
		[CompilerGenerated]
		internal Class116 vmethod_38()
		{
			return this.class116_6;
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x0004A7EE File Offset: 0x000489EE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Class116 class116_13)
		{
			this.class116_6 = class116_13;
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x0004A7F7 File Offset: 0x000489F7
		[CompilerGenerated]
		internal Class116 vmethod_40()
		{
			return this.class116_7;
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x0004A7FF File Offset: 0x000489FF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Class116 class116_13)
		{
			this.class116_7 = class116_13;
		}

		// Token: 0x0600786E RID: 30830 RVA: 0x0004A808 File Offset: 0x00048A08
		[CompilerGenerated]
		internal TabPage vmethod_42()
		{
			return this.tabPage_4;
		}

		// Token: 0x0600786F RID: 30831 RVA: 0x0004A810 File Offset: 0x00048A10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(TabPage tabPage_6)
		{
			this.tabPage_4 = tabPage_6;
		}

		// Token: 0x06007870 RID: 30832 RVA: 0x0004A819 File Offset: 0x00048A19
		[CompilerGenerated]
		internal Class116 vmethod_44()
		{
			return this.class116_8;
		}

		// Token: 0x06007871 RID: 30833 RVA: 0x0004A821 File Offset: 0x00048A21
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Class116 class116_13)
		{
			this.class116_8 = class116_13;
		}

		// Token: 0x06007872 RID: 30834 RVA: 0x0004A82A File Offset: 0x00048A2A
		[CompilerGenerated]
		internal Class2451 vmethod_46()
		{
			return this.class2451_2;
		}

		// Token: 0x06007873 RID: 30835 RVA: 0x00419BA0 File Offset: 0x00417DA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Class2451 class2451_6)
		{
			EventHandler value = new EventHandler(this.method_10);
			Class2451 @class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_2 = class2451_6;
			@class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06007874 RID: 30836 RVA: 0x0004A832 File Offset: 0x00048A32
		[CompilerGenerated]
		internal Class2451 vmethod_48()
		{
			return this.class2451_3;
		}

		// Token: 0x06007875 RID: 30837 RVA: 0x00419BE4 File Offset: 0x00417DE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Class2451 class2451_6)
		{
			EventHandler value = new EventHandler(this.method_9);
			Class2451 @class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_3 = class2451_6;
			@class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06007876 RID: 30838 RVA: 0x0004A83A File Offset: 0x00048A3A
		[CompilerGenerated]
		internal Class116 vmethod_50()
		{
			return this.class116_9;
		}

		// Token: 0x06007877 RID: 30839 RVA: 0x0004A842 File Offset: 0x00048A42
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(Class116 class116_13)
		{
			this.class116_9 = class116_13;
		}

		// Token: 0x06007878 RID: 30840 RVA: 0x0004A84B File Offset: 0x00048A4B
		[CompilerGenerated]
		internal Class116 vmethod_52()
		{
			return this.class116_10;
		}

		// Token: 0x06007879 RID: 30841 RVA: 0x0004A853 File Offset: 0x00048A53
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Class116 class116_13)
		{
			this.class116_10 = class116_13;
		}

		// Token: 0x0600787A RID: 30842 RVA: 0x0004A85C File Offset: 0x00048A5C
		[CompilerGenerated]
		internal Class2451 vmethod_54()
		{
			return this.class2451_4;
		}

		// Token: 0x0600787B RID: 30843 RVA: 0x00419C28 File Offset: 0x00417E28
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Class2451 class2451_6)
		{
			EventHandler value = new EventHandler(this.method_11);
			Class2451 @class = this.class2451_4;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_4 = class2451_6;
			@class = this.class2451_4;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600787C RID: 30844 RVA: 0x0004A864 File Offset: 0x00048A64
		[CompilerGenerated]
		private HtmlEditorControl vmethod_56()
		{
			return this.htmlEditorControl_0;
		}

		// Token: 0x0600787D RID: 30845 RVA: 0x0004A86C File Offset: 0x00048A6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_57(HtmlEditorControl htmlEditorControl_1)
		{
			this.htmlEditorControl_0 = htmlEditorControl_1;
		}

		// Token: 0x0600787E RID: 30846 RVA: 0x0004A875 File Offset: 0x00048A75
		[CompilerGenerated]
		internal TabPage vmethod_58()
		{
			return this.tabPage_5;
		}

		// Token: 0x0600787F RID: 30847 RVA: 0x0004A87D File Offset: 0x00048A7D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(TabPage tabPage_6)
		{
			this.tabPage_5 = tabPage_6;
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x0004A886 File Offset: 0x00048A86
		[CompilerGenerated]
		internal Control9 vmethod_60()
		{
			return this.control9_2;
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x00419C6C File Offset: 0x00417E6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_12);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_4;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x0004A88E File Offset: 0x00048A8E
		[CompilerGenerated]
		internal Class2451 vmethod_62()
		{
			return this.class2451_5;
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x0004A896 File Offset: 0x00048A96
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(Class2451 class2451_6)
		{
			this.class2451_5 = class2451_6;
		}

		// Token: 0x06007884 RID: 30852 RVA: 0x0004A89F File Offset: 0x00048A9F
		[CompilerGenerated]
		internal Class116 vmethod_64()
		{
			return this.class116_11;
		}

		// Token: 0x06007885 RID: 30853 RVA: 0x0004A8A7 File Offset: 0x00048AA7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Class116 class116_13)
		{
			this.class116_11 = class116_13;
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x0004A8B0 File Offset: 0x00048AB0
		[CompilerGenerated]
		internal Class124 vmethod_66()
		{
			return this.class124_0;
		}

		// Token: 0x06007887 RID: 30855 RVA: 0x0004A8B8 File Offset: 0x00048AB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(Class124 class124_1)
		{
			this.class124_0 = class124_1;
		}

		// Token: 0x06007888 RID: 30856 RVA: 0x0004A8C1 File Offset: 0x00048AC1
		[CompilerGenerated]
		internal Control10 vmethod_68()
		{
			return this.control10_0;
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x00419CB0 File Offset: 0x00417EB0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(Control10 control10_1)
		{
			EventHandler value = new EventHandler(this.method_13);
			Control10 control = this.control10_0;
			if (control != null)
			{
				control.TextChanged -= value;
			}
			this.control10_0 = control10_1;
			control = this.control10_0;
			if (control != null)
			{
				control.TextChanged += value;
			}
		}

		// Token: 0x0600788A RID: 30858 RVA: 0x0004A8C9 File Offset: 0x00048AC9
		[CompilerGenerated]
		internal Class116 vmethod_70()
		{
			return this.class116_12;
		}

		// Token: 0x0600788B RID: 30859 RVA: 0x0004A8D1 File Offset: 0x00048AD1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(Class116 class116_13)
		{
			this.class116_12 = class116_13;
		}

		// Token: 0x0600788C RID: 30860 RVA: 0x0004A8DA File Offset: 0x00048ADA
		[CompilerGenerated]
		internal Control9 vmethod_72()
		{
			return this.control9_3;
		}

		// Token: 0x0600788D RID: 30861 RVA: 0x00419CF4 File Offset: 0x00417EF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_14);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_4;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600788E RID: 30862 RVA: 0x0004A8E2 File Offset: 0x00048AE2
		private void EditAction_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_32().method_3();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x00419D38 File Offset: 0x00417F38
		private void EditAction_Load(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.eventAction_0))
			{
				base.Close();
			}
			this.vmethod_4().SizeMode = TabSizeMode.Normal;
			this.vmethod_0().Text = this.eventAction_0.string_2;
			this.vmethod_12().Visible = true;
			this.vmethod_10().Visible = this.vmethod_12().Visible;
			switch (this.eventAction_0.eventActionType_0)
			{
			case EventAction.EventActionType.Points:
				this.vmethod_4().SelectedIndex = 0;
				this.vmethod_18().Items.Clear();
				this.vmethod_18().DisplayMember = "Content";
				foreach (Side side in Client.smethod_46().method_44())
				{
					ComboBoxItem comboBoxItem = new ComboBoxItem();
					comboBoxItem.Content = side.method_51();
					comboBoxItem.Tag = side.string_0;
					this.vmethod_18().Items.Add(comboBoxItem);
				}
				try
				{
					foreach (object obj in this.vmethod_18().Items)
					{
						ComboBoxItem comboBoxItem2 = (ComboBoxItem)obj;
						if (Operators.CompareString(Conversions.ToString(comboBoxItem2.Tag), ((Class321)this.eventAction_0).string_3, false) == 0)
						{
							this.vmethod_18().SelectedItem = comboBoxItem2;
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
				this.vmethod_16().Value = new decimal(((Class321)this.eventAction_0).int_0);
				break;
			case EventAction.EventActionType.EndScenario:
				this.vmethod_4().SelectedIndex = 1;
				break;
			case EventAction.EventActionType.TeleportInArea:
			{
				this.vmethod_4().SelectedIndex = 2;
				this.vmethod_28().method_18().Clear();
				Class117 @class = new Class117();
				List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, string>(Client.smethod_46().method_42(), (EditAction._Closure$__.$I155-0 == null) ? (EditAction._Closure$__.$I155-0 = new Func<ActiveUnit, string>(EditAction._Closure$__.$I.method_0)) : EditAction._Closure$__.$I155-0, new Class440<string[]>(true)));
				try
				{
					foreach (ActiveUnit activeUnit in list)
					{
						@class = new Class117(activeUnit.Name);
						@class.Tag = activeUnit;
						this.vmethod_28().method_18().Add(@class);
						if (((EventAction_TeleportInArea)this.eventAction_0).hashSet_0.Contains(activeUnit.string_0))
						{
							this.vmethod_28().method_29(this.vmethod_28().method_18().IndexOf(@class));
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				this.vmethod_32().list_0 = ((EventAction_TeleportInArea)this.eventAction_0).list_0;
				this.vmethod_32().imethod_0();
				break;
			}
			case EventAction.EventActionType.Message:
				this.vmethod_4().SelectedIndex = 3;
				this.vmethod_36().Items.Clear();
				this.vmethod_36().DisplayMember = "Content";
				foreach (Side side2 in Client.smethod_46().method_44())
				{
					ComboBoxItem comboBoxItem3 = new ComboBoxItem();
					comboBoxItem3.Content = side2.method_51();
					comboBoxItem3.Tag = side2.string_0;
					this.vmethod_36().Items.Add(comboBoxItem3);
				}
				try
				{
					foreach (object obj2 in this.vmethod_36().Items)
					{
						ComboBoxItem comboBoxItem4 = (ComboBoxItem)obj2;
						if (Operators.CompareString(Conversions.ToString(comboBoxItem4.Tag), ((Class319)this.eventAction_0).string_3, false) == 0)
						{
							this.vmethod_36().SelectedItem = comboBoxItem4;
							break;
						}
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
				if (!string.IsNullOrEmpty(((Class319)this.eventAction_0).string_4))
				{
					this.vmethod_56().BodyHtml = ((Class319)this.eventAction_0).string_4;
				}
				break;
			case EventAction.EventActionType.ChangeMissionStatus:
			{
				this.vmethod_4().SelectedIndex = 4;
				if (Client.smethod_46().method_44().Length == 0)
				{
					return;
				}
				Side side3 = Client.smethod_46().method_44()[0];
				this.vmethod_48().Items.Clear();
				this.vmethod_48().DisplayMember = "Content";
				foreach (Side side4 in Client.smethod_46().method_44())
				{
					ComboBoxItem comboBoxItem5 = new ComboBoxItem();
					comboBoxItem5.Content = side4.method_51();
					comboBoxItem5.Tag = side4.string_0;
					this.vmethod_48().Items.Add(comboBoxItem5);
				}
				foreach (Side side5 in Client.smethod_46().method_44())
				{
					try
					{
						IEnumerator<Mission> enumerator4 = side5.method_35().GetEnumerator();
						while (enumerator4.MoveNext())
						{
							if (Operators.CompareString(enumerator4.Current.string_0, ((Class318)this.eventAction_0).string_3, false) == 0)
							{
								try
								{
									foreach (object obj3 in this.vmethod_48().Items)
									{
										ComboBoxItem comboBoxItem6 = (ComboBoxItem)obj3;
										if (Operators.CompareString(Conversions.ToString(comboBoxItem6.Tag), side5.string_0, false) == 0)
										{
											side3 = side5;
											this.vmethod_48().SelectedItem = comboBoxItem6;
											break;
										}
									}
								}
								finally
								{
									IEnumerator enumerator5;
									if (enumerator5 is IDisposable)
									{
										(enumerator5 as IDisposable).Dispose();
									}
								}
							}
						}
					}
					finally
					{
						IEnumerator<Mission> enumerator4;
						if (enumerator4 != null)
						{
							enumerator4.Dispose();
						}
					}
				}
				if (Client.smethod_50().method_35().Count != 0)
				{
					this.vmethod_46().Items.Clear();
					this.vmethod_46().DisplayMember = "Content";
					try
					{
						foreach (Mission mission in side3.method_35())
						{
							ComboBoxItem comboBoxItem7 = new ComboBoxItem();
							comboBoxItem7.Content = mission.Name;
							comboBoxItem7.Tag = mission.string_0;
							this.vmethod_46().Items.Add(comboBoxItem7);
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
					if (side3.method_35().Count > 0)
					{
						Mission mission2 = side3.method_35()[0];
						try
						{
							foreach (Mission mission3 in side3.method_35())
							{
								if (Operators.CompareString(mission3.string_0, ((Class318)this.eventAction_0).string_3, false) == 0)
								{
									mission2 = mission3;
									break;
								}
							}
						}
						finally
						{
							IEnumerator<Mission> enumerator7;
							if (enumerator7 != null)
							{
								enumerator7.Dispose();
							}
						}
						try
						{
							foreach (object obj4 in this.vmethod_46().Items)
							{
								ComboBoxItem comboBoxItem8 = (ComboBoxItem)obj4;
								if (Operators.CompareString(Conversions.ToString(comboBoxItem8.Tag), mission2.string_0, false) == 0)
								{
									this.vmethod_46().SelectedItem = comboBoxItem8;
									break;
								}
							}
						}
						finally
						{
							IEnumerator enumerator8;
							if (enumerator8 is IDisposable)
							{
								(enumerator8 as IDisposable).Dispose();
							}
						}
					}
					this.vmethod_54().SelectedIndex = (int)((Class318)this.eventAction_0).enum89_0;
				}
				break;
			}
			case EventAction.EventActionType.LuaScript:
				this.vmethod_4().SelectedIndex = 5;
				if (!string.IsNullOrEmpty(((Class317)this.eventAction_0).string_3))
				{
					this.vmethod_66().Text = ((Class317)this.eventAction_0).string_3;
				}
				this.vmethod_68().Value = (int)Math.Round((double)this.vmethod_66().Font.Size);
				this.vmethod_62().Items.AddRange(Enumerable.ToArray<string>(Enumerable.OrderBy<string, string>(LuaSandBox.LuaMethods, (EditAction._Closure$__.$I155-1 == null) ? (EditAction._Closure$__.$I155-1 = new Func<string, string>(EditAction._Closure$__.$I.method_1)) : EditAction._Closure$__.$I155-1)));
				this.vmethod_62().SelectedIndex = 0;
				break;
			}
			this.vmethod_4().method_0();
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x0041A5A0 File Offset: 0x004187A0
		private void method_4(object sender, EventArgs e)
		{
			switch (this.eventAction_0.eventActionType_0)
			{
			case EventAction.EventActionType.TeleportInArea:
				if (((EventAction_TeleportInArea)this.eventAction_0).list_0.Count < 3)
				{
					DarkMessageBox.smethod_2("You must define at least 3 reference points for the teleport area.", "Not enough reference points!", Enum11.const_0);
					return;
				}
				break;
			case EventAction.EventActionType.Message:
				((Class319)this.eventAction_0).string_4 = this.vmethod_56().BodyHtml;
				break;
			case EventAction.EventActionType.LuaScript:
				((Class317)this.eventAction_0).string_3 = this.vmethod_66().Text;
				break;
			}
			this.eventAction_0.string_2 = this.vmethod_0().Text;
			EditAction.Enum204 @enum = this.enum204_0;
			if (@enum != EditAction.Enum204.const_0)
			{
				if (@enum != EditAction.Enum204.const_1)
				{
				}
			}
			else
			{
				Client.smethod_46().vmethod_8().Add(this.eventAction_0.string_0, this.eventAction_0);
			}
			base.Close();
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x0004A902 File Offset: 0x00048B02
		private void method_5(object sender, EventArgs e)
		{
			((Class321)this.eventAction_0).string_3 = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_18().SelectedItem, null, "tag", new object[0], null, null, null));
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x0004A938 File Offset: 0x00048B38
		private void method_6(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_16().Value))
			{
				((Class321)this.eventAction_0).int_0 = Convert.ToInt32(this.vmethod_16().Value);
			}
		}

		// Token: 0x06007894 RID: 30868 RVA: 0x0041A684 File Offset: 0x00418884
		private void method_7(object sender, EventArgs e)
		{
			HashSet<string> hashSet_ = ((EventAction_TeleportInArea)this.eventAction_0).hashSet_0;
			List<object> list = new List<object>();
			try
			{
				foreach (object obj in this.vmethod_28().method_18())
				{
					list.Add(RuntimeHelpers.GetObjectValue(obj));
				}
			}
			finally
			{
				IEnumerator<Class117> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (object obj2 in this.vmethod_28().method_21())
				{
					list.Remove(RuntimeHelpers.GetObjectValue(obj2));
				}
			}
			finally
			{
				List<Class117>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			try
			{
				foreach (Class117 @class in this.vmethod_28().method_21())
				{
					hashSet_.Add(((ActiveUnit)@class.Tag).string_0);
				}
			}
			finally
			{
				List<Class117>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			try
			{
				foreach (object obj3 in list)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj3);
					hashSet_.Remove(((ActiveUnit)NewLateBinding.LateGet(objectValue, null, "Tag", new object[0], null, null, null)).string_0);
				}
			}
			finally
			{
				List<object>.Enumerator enumerator4;
				((IDisposable)enumerator4).Dispose();
			}
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x0004A971 File Offset: 0x00048B71
		private void method_8(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventAction_0))
			{
				((Class319)this.eventAction_0).string_3 = Conversions.ToString(((ComboBoxItem)this.vmethod_36().SelectedItem).Tag);
			}
		}

		// Token: 0x06007896 RID: 30870 RVA: 0x0041A804 File Offset: 0x00418A04
		private void method_9(object sender, EventArgs e)
		{
			checked
			{
				if (Client.smethod_46().method_44().Length != 0)
				{
					Side side = Client.smethod_46().method_44()[0];
					Side[] array = Client.smethod_46().method_44();
					int i = 0;
					while (i < array.Length)
					{
						Side side2 = array[i];
						if (Operators.CompareString(side2.string_0, Conversions.ToString(((ComboBoxItem)this.vmethod_48().SelectedItem).Tag), false) != 0)
						{
							i++;
						}
						else
						{
							side = side2;
							IL_67:
							this.vmethod_46().Items.Clear();
							this.vmethod_46().DisplayMember = "Content";
							try
							{
								foreach (Mission mission in side.method_35())
								{
									ComboBoxItem comboBoxItem = new ComboBoxItem();
									comboBoxItem.Content = mission.Name;
									comboBoxItem.Tag = mission.string_0;
									this.vmethod_46().Items.Add(comboBoxItem);
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
							if (Information.IsNothing(this.eventAction_0) || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_46().SelectedItem)))
							{
								return;
							}
							((Class318)this.eventAction_0).string_3 = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_46().SelectedItem, null, "Tag", new object[0], null, null, null));
							if (side.method_35().Count > 0)
							{
								this.vmethod_54().SelectedIndex = (int)side.method_35()[0].method_10(Client.smethod_46());
								return;
							}
							return;
						}
					}
					goto IL_67;
				}
			}
		}

		// Token: 0x06007897 RID: 30871 RVA: 0x0041A994 File Offset: 0x00418B94
		private void method_10(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventAction_0))
			{
				((Class318)this.eventAction_0).string_3 = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_46().SelectedItem, null, "Tag", new object[0], null, null, null));
			}
		}

		// Token: 0x06007898 RID: 30872 RVA: 0x0004A9AA File Offset: 0x00048BAA
		private void method_11(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventAction_0))
			{
				((Class318)this.eventAction_0).enum89_0 = (Mission.Enum89)this.vmethod_54().SelectedIndex;
			}
		}

		// Token: 0x06007899 RID: 30873 RVA: 0x003B6260 File Offset: 0x003B4460
		private void EditAction_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x0600789A RID: 30874 RVA: 0x0004A9D5 File Offset: 0x00048BD5
		private void method_12(object sender, EventArgs e)
		{
			this.vmethod_66().Text = this.vmethod_66().Text.Insert(this.vmethod_66().SelectionStart, Conversions.ToString(this.vmethod_62().SelectedItem));
		}

		// Token: 0x0600789B RID: 30875 RVA: 0x0041A9E4 File Offset: 0x00418BE4
		private void method_13(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_68().Value))
			{
				this.vmethod_66().Font = new Font(this.vmethod_66().Font.FontFamily, (float)this.vmethod_68().Value);
			}
		}

		// Token: 0x0600789C RID: 30876 RVA: 0x0004AA0D File Offset: 0x00048C0D
		private void method_14(object sender, EventArgs e)
		{
			this.vmethod_56().HtmlContentsEdit();
		}

		// Token: 0x0600789D RID: 30877 RVA: 0x0004AA1A File Offset: 0x00048C1A
		private void method_15(object object_0)
		{
			this.eventAction_0.string_2 = this.vmethod_0().Text;
		}

		// Token: 0x04004357 RID: 17239
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private Control8 control8_0;

		// Token: 0x04004358 RID: 17240
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04004359 RID: 17241
		[CompilerGenerated]
		[AccessedThroughProperty("TC_ActionOptions")]
		private Control12 control12_0;

		// Token: 0x0400435A RID: 17242
		[AccessedThroughProperty("TabPage1")]
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x0400435B RID: 17243
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x0400435C RID: 17244
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_0;

		// Token: 0x0400435D RID: 17245
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_1;

		// Token: 0x0400435E RID: 17246
		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Class116 class116_2;

		// Token: 0x0400435F RID: 17247
		[CompilerGenerated]
		[AccessedThroughProperty("NUD_Points")]
		private Class120 class120_0;

		// Token: 0x04004360 RID: 17248
		[AccessedThroughProperty("CB_Points_Sides")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04004361 RID: 17249
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x04004362 RID: 17250
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_4;

		// Token: 0x04004363 RID: 17251
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage2")]
		private TabPage tabPage_1;

		// Token: 0x04004364 RID: 17252
		[AccessedThroughProperty("TabPage3")]
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x04004365 RID: 17253
		[AccessedThroughProperty("ListBox_UnitsToTeleport")]
		[CompilerGenerated]
		private Control4 control4_0;

		// Token: 0x04004366 RID: 17254
		[AccessedThroughProperty("Label6")]
		[CompilerGenerated]
		private Class116 class116_5;

		// Token: 0x04004367 RID: 17255
		[AccessedThroughProperty("AreaEditor1")]
		[CompilerGenerated]
		private AreaEditor areaEditor_0;

		// Token: 0x04004368 RID: 17256
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage4")]
		private TabPage tabPage_3;

		// Token: 0x04004369 RID: 17257
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Message_Side")]
		private Class2451 class2451_1;

		// Token: 0x0400436A RID: 17258
		[AccessedThroughProperty("Label8")]
		[CompilerGenerated]
		private Class116 class116_6;

		// Token: 0x0400436B RID: 17259
		[CompilerGenerated]
		[AccessedThroughProperty("Label9")]
		private Class116 class116_7;

		// Token: 0x0400436C RID: 17260
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage5")]
		private TabPage tabPage_4;

		// Token: 0x0400436D RID: 17261
		[AccessedThroughProperty("Label11")]
		[CompilerGenerated]
		private Class116 class116_8;

		// Token: 0x0400436E RID: 17262
		[AccessedThroughProperty("CB_MissionStatus_Mission")]
		[CompilerGenerated]
		private Class2451 class2451_2;

		// Token: 0x0400436F RID: 17263
		[CompilerGenerated]
		[AccessedThroughProperty("CB_MissionStatus_Side")]
		private Class2451 class2451_3;

		// Token: 0x04004370 RID: 17264
		[AccessedThroughProperty("Label7")]
		[CompilerGenerated]
		private Class116 class116_9;

		// Token: 0x04004371 RID: 17265
		[AccessedThroughProperty("Label10")]
		[CompilerGenerated]
		private Class116 class116_10;

		// Token: 0x04004372 RID: 17266
		[AccessedThroughProperty("CB_MissionStatus_Status")]
		[CompilerGenerated]
		private Class2451 class2451_4;

		// Token: 0x04004373 RID: 17267
		[AccessedThroughProperty("Editor_Message_Text")]
		[CompilerGenerated]
		private HtmlEditorControl htmlEditorControl_0;

		// Token: 0x04004374 RID: 17268
		[AccessedThroughProperty("TabPage6")]
		[CompilerGenerated]
		private TabPage tabPage_5;

		// Token: 0x04004375 RID: 17269
		[CompilerGenerated]
		[AccessedThroughProperty("Button_AddLuaScript")]
		private Control9 control9_2;

		// Token: 0x04004376 RID: 17270
		[CompilerGenerated]
		[AccessedThroughProperty("CB_LuaTemplate")]
		private Class2451 class2451_5;

		// Token: 0x04004377 RID: 17271
		[AccessedThroughProperty("Label12")]
		[CompilerGenerated]
		private Class116 class116_11;

		// Token: 0x04004378 RID: 17272
		[AccessedThroughProperty("TextBox2")]
		[CompilerGenerated]
		private Class124 class124_0;

		// Token: 0x04004379 RID: 17273
		[AccessedThroughProperty("NUD_LuaScript")]
		[CompilerGenerated]
		private Control10 control10_0;

		// Token: 0x0400437A RID: 17274
		[CompilerGenerated]
		[AccessedThroughProperty("Label13")]
		private Class116 class116_12;

		// Token: 0x0400437B RID: 17275
		[CompilerGenerated]
		[AccessedThroughProperty("Button3")]
		private Control9 control9_3;

		// Token: 0x0400437C RID: 17276
		public EventAction eventAction_0;

		// Token: 0x0400437D RID: 17277
		public EditAction.Enum204 enum204_0;

		// Token: 0x02000EAE RID: 3758
		internal enum Enum204 : byte
		{
			// Token: 0x0400437F RID: 17279
			const_0,
			// Token: 0x04004380 RID: 17280
			const_1
		}
	}
}
