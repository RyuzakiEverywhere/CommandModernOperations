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
using ns2;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000E26 RID: 3622
	[DesignerGenerated]
	public sealed partial class TankerPlanner : DarkSecondaryFormBase
	{
		// Token: 0x06006C2C RID: 27692 RVA: 0x003B65B4 File Offset: 0x003B47B4
		public TankerPlanner()
		{
			base.VisibleChanged += this.TankerPlanner_VisibleChanged;
			base.FormClosing += this.TankerPlanner_FormClosing;
			base.KeyDown += this.TankerPlanner_KeyDown;
			base.Load += this.TankerPlanner_Load;
			this.bool_3 = false;
			this.bool_4 = false;
			this.bool_5 = false;
			this.bool_6 = false;
			this.bool_7 = false;
			this.bool_8 = false;
			this.InitializeComponent_1();
		}

		// Token: 0x06006C2E RID: 27694 RVA: 0x003B6680 File Offset: 0x003B4880
		private void InitializeComponent_1()
		{
			this.vmethod_1(new RadioButton());
			this.vmethod_3(new RadioButton());
			this.vmethod_43(new Class115());
			this.vmethod_5(new RadioButton());
			this.vmethod_7(new RadioButton());
			this.vmethod_9(new RadioButton());
			this.vmethod_11(new RadioButton());
			this.vmethod_13(new RadioButton());
			this.vmethod_15(new Control8());
			this.vmethod_17(new Label());
			this.vmethod_19(new Label());
			this.vmethod_21(new Control8());
			this.vmethod_23(new Label());
			this.vmethod_25(new Control8());
			this.vmethod_27(new Control4());
			this.vmethod_29(new Label());
			this.vmethod_31(new Control8());
			this.vmethod_33(new CheckBox());
			this.vmethod_45(new Class115());
			this.vmethod_47(new Class115());
			this.vmethod_49(new Class2451());
			this.vmethod_35(new Label());
			this.vmethod_37(new Control8());
			this.vmethod_41(new CheckBox());
			this.vmethod_39(new Label());
			this.vmethod_42().SuspendLayout();
			this.vmethod_44().SuspendLayout();
			this.vmethod_46().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().BackColor = Color.Transparent;
			this.vmethod_0().Cursor = Cursors.Hand;
			this.vmethod_0().Font = new Font("Segoe UI", 9f);
			this.vmethod_0().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_0().Location = new Point(12, 29);
			this.vmethod_0().Name = "RadioButton_Mission";
			this.vmethod_0().Size = new Size(283, 21);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Use tankers assigned to specific missions";
			this.vmethod_0().UseVisualStyleBackColor = false;
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().Cursor = Cursors.Hand;
			this.vmethod_2().Font = new Font("Segoe UI", 9f);
			this.vmethod_2().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_2().Location = new Point(12, 12);
			this.vmethod_2().Name = "RadioButton_Automatic";
			this.vmethod_2().Size = new Size(283, 21);
			this.vmethod_2().TabIndex = 3;
			this.vmethod_2().Text = "Use nearest tanker with enough fuel to serve receivers";
			this.vmethod_2().UseVisualStyleBackColor = false;
			this.vmethod_42().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_42().Controls.Add(this.vmethod_4());
			this.vmethod_42().Controls.Add(this.vmethod_6());
			this.vmethod_42().Controls.Add(this.vmethod_8());
			this.vmethod_42().Controls.Add(this.vmethod_10());
			this.vmethod_42().Controls.Add(this.vmethod_12());
			this.vmethod_42().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_42().Location = new Point(352, 217);
			this.vmethod_42().Name = "GroupBox1";
			this.vmethod_42().Size = new Size(423, 112);
			this.vmethod_42().TabIndex = 4;
			this.vmethod_42().TabStop = false;
			this.vmethod_42().Text = "Airborne receivers can book tankers within...";
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().Cursor = Cursors.Hand;
			this.vmethod_4().Font = new Font("Segoe UI", 9f);
			this.vmethod_4().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_4().Location = new Point(6, 85);
			this.vmethod_4().Name = "RadioButton_TankerMaxDistance_Airborne_50";
			this.vmethod_4().Size = new Size(54, 21);
			this.vmethod_4().TabIndex = 4;
			this.vmethod_4().Text = "50 nm";
			this.vmethod_4().UseVisualStyleBackColor = false;
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().Cursor = Cursors.Hand;
			this.vmethod_6().Font = new Font("Segoe UI", 9f);
			this.vmethod_6().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_6().Location = new Point(6, 68);
			this.vmethod_6().Name = "RadioButton_TankerMaxDistance_Airborne_100";
			this.vmethod_6().Size = new Size(60, 21);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "100 nm";
			this.vmethod_6().UseVisualStyleBackColor = false;
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().Cursor = Cursors.Hand;
			this.vmethod_8().Font = new Font("Segoe UI", 9f);
			this.vmethod_8().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_8().Location = new Point(6, 51);
			this.vmethod_8().Name = "RadioButton_TankerMaxDistance_Airborne_250";
			this.vmethod_8().Size = new Size(60, 21);
			this.vmethod_8().TabIndex = 2;
			this.vmethod_8().Text = "250 nm";
			this.vmethod_8().UseVisualStyleBackColor = false;
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().Cursor = Cursors.Hand;
			this.vmethod_10().Font = new Font("Segoe UI", 9f);
			this.vmethod_10().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_10().Location = new Point(6, 34);
			this.vmethod_10().Name = "RadioButton_TankerMaxDistance_Airborne_500";
			this.vmethod_10().Size = new Size(60, 21);
			this.vmethod_10().TabIndex = 1;
			this.vmethod_10().Text = "500 nm";
			this.vmethod_10().UseVisualStyleBackColor = false;
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().Cursor = Cursors.Hand;
			this.vmethod_12().Font = new Font("Segoe UI", 9f);
			this.vmethod_12().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_12().Location = new Point(6, 17);
			this.vmethod_12().Name = "RadioButton_TankerMaxDistance_Airborne_Tactical";
			this.vmethod_12().Size = new Size(381, 21);
			this.vmethod_12().TabIndex = 0;
			this.vmethod_12().Text = "Receiver's tactical range with current fuel load and flight profile";
			this.vmethod_12().UseVisualStyleBackColor = false;
			this.vmethod_14().method_14(null);
			this.vmethod_14().method_15(AutoCompleteMode.None);
			this.vmethod_14().method_13(AutoCompleteSource.None);
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().method_17(new Font("Segoe UI", 8f));
			this.vmethod_14().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_14().method_12(null);
			this.vmethod_14().method_18(null);
			this.vmethod_14().Location = new Point(264, 14);
			this.vmethod_14().method_2(32767);
			this.vmethod_14().method_7(false);
			this.vmethod_14().Name = "TextBox_TankerMinimum_Total";
			this.vmethod_14().method_3(false);
			this.vmethod_14().method_9(0);
			this.vmethod_14().Size = new Size(100, 20);
			this.vmethod_14().TabIndex = 6;
			this.vmethod_14().method_1(HorizontalAlignment.Left);
			this.vmethod_14().method_5(false);
			this.vmethod_14().method_10("");
			this.vmethod_16().Location = new Point(4, 17);
			this.vmethod_16().Name = "Label1";
			this.vmethod_16().Size = new Size(178, 13);
			this.vmethod_16().TabIndex = 7;
			this.vmethod_16().Text = "Minimum number of tankers needed:";
			this.vmethod_18().Location = new Point(4, 38);
			this.vmethod_18().Name = "Label2";
			this.vmethod_18().Size = new Size(180, 13);
			this.vmethod_18().TabIndex = 9;
			this.vmethod_18().Text = "Minimum number of tankers airborne:";
			this.vmethod_20().method_14(null);
			this.vmethod_20().method_15(AutoCompleteMode.None);
			this.vmethod_20().method_13(AutoCompleteSource.None);
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().method_17(new Font("Segoe UI", 8f));
			this.vmethod_20().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_20().method_12(null);
			this.vmethod_20().method_18(null);
			this.vmethod_20().Location = new Point(264, 35);
			this.vmethod_20().method_2(32767);
			this.vmethod_20().method_7(false);
			this.vmethod_20().Name = "TextBox_TankerMinimum_Airborne";
			this.vmethod_20().method_3(false);
			this.vmethod_20().method_9(0);
			this.vmethod_20().Size = new Size(100, 20);
			this.vmethod_20().TabIndex = 8;
			this.vmethod_20().method_1(HorizontalAlignment.Left);
			this.vmethod_20().method_5(false);
			this.vmethod_20().method_10("");
			this.vmethod_22().Location = new Point(4, 59);
			this.vmethod_22().Name = "Label3";
			this.vmethod_22().Size = new Size(188, 13);
			this.vmethod_22().TabIndex = 11;
			this.vmethod_22().Text = "Minimum number of tankers on station:";
			this.vmethod_24().method_14(null);
			this.vmethod_24().method_15(AutoCompleteMode.None);
			this.vmethod_24().method_13(AutoCompleteSource.None);
			this.vmethod_24().BackColor = Color.Transparent;
			this.vmethod_24().method_17(new Font("Segoe UI", 8f));
			this.vmethod_24().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_24().method_12(null);
			this.vmethod_24().method_18(null);
			this.vmethod_24().Location = new Point(264, 56);
			this.vmethod_24().method_2(32767);
			this.vmethod_24().method_7(false);
			this.vmethod_24().Name = "TextBox_TankerMinimum_Station";
			this.vmethod_24().method_3(false);
			this.vmethod_24().method_9(0);
			this.vmethod_24().Size = new Size(100, 20);
			this.vmethod_24().TabIndex = 10;
			this.vmethod_24().method_1(HorizontalAlignment.Left);
			this.vmethod_24().method_5(false);
			this.vmethod_24().method_10("");
			this.vmethod_26().Location = new Point(12, 50);
			this.vmethod_26().Name = "ListBox_Tankers";
			this.vmethod_26().Size = new Size(334, 279);
			this.vmethod_26().TabIndex = 15;
			this.vmethod_28().Location = new Point(4, 22);
			this.vmethod_28().Name = "Label6";
			this.vmethod_28().Size = new Size(245, 13);
			this.vmethod_28().TabIndex = 18;
			this.vmethod_28().Text = "Maximum number of receivers in queue per tanker:";
			this.vmethod_30().method_14(null);
			this.vmethod_30().method_15(AutoCompleteMode.None);
			this.vmethod_30().method_13(AutoCompleteSource.None);
			this.vmethod_30().BackColor = Color.Transparent;
			this.vmethod_30().method_17(new Font("Segoe UI", 8f));
			this.vmethod_30().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_30().method_12(null);
			this.vmethod_30().method_18(null);
			this.vmethod_30().Location = new Point(262, 19);
			this.vmethod_30().method_2(32767);
			this.vmethod_30().method_7(false);
			this.vmethod_30().Name = "TextBox_MaxReceiversInQueuePerTanker_Airborne";
			this.vmethod_30().method_3(false);
			this.vmethod_30().method_9(0);
			this.vmethod_30().Size = new Size(100, 20);
			this.vmethod_30().TabIndex = 17;
			this.vmethod_30().method_1(HorizontalAlignment.Left);
			this.vmethod_30().method_5(false);
			this.vmethod_30().method_10("");
			this.vmethod_32().AutoSize = true;
			this.vmethod_32().Location = new Point(6, 78);
			this.vmethod_32().Name = "CheckBox_LaunchMissionWithoutTankersInPlace";
			this.vmethod_32().Size = new Size(330, 19);
			this.vmethod_32().TabIndex = 19;
			this.vmethod_32().Text = "Launch mission without tankers in place (extremely risky!)";
			this.vmethod_32().UseVisualStyleBackColor = true;
			this.vmethod_44().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_44().Controls.Add(this.vmethod_16());
			this.vmethod_44().Controls.Add(this.vmethod_14());
			this.vmethod_44().Controls.Add(this.vmethod_32());
			this.vmethod_44().Controls.Add(this.vmethod_20());
			this.vmethod_44().Controls.Add(this.vmethod_18());
			this.vmethod_44().Controls.Add(this.vmethod_24());
			this.vmethod_44().Controls.Add(this.vmethod_22());
			this.vmethod_44().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_44().Location = new Point(352, 12);
			this.vmethod_44().Name = "GroupBox3";
			this.vmethod_44().Size = new Size(423, 100);
			this.vmethod_44().TabIndex = 21;
			this.vmethod_44().TabStop = false;
			this.vmethod_44().Text = "Mission planning details";
			this.vmethod_46().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_46().Controls.Add(this.vmethod_48());
			this.vmethod_46().Controls.Add(this.vmethod_34());
			this.vmethod_46().Controls.Add(this.vmethod_36());
			this.vmethod_46().Controls.Add(this.vmethod_40());
			this.vmethod_46().Controls.Add(this.vmethod_38());
			this.vmethod_46().Controls.Add(this.vmethod_30());
			this.vmethod_46().Controls.Add(this.vmethod_28());
			this.vmethod_46().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_46().Location = new Point(352, 118);
			this.vmethod_46().Name = "GroupBox4";
			this.vmethod_46().Size = new Size(423, 90);
			this.vmethod_46().TabIndex = 22;
			this.vmethod_46().TabStop = false;
			this.vmethod_46().Text = "Mission execution details";
			this.vmethod_48().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_48().BackColor = Color.Transparent;
			this.vmethod_48().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_48().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_48().DropDownWidth = 500;
			this.vmethod_48().Font = new Font("Segoe UI", 7f);
			this.vmethod_48().FormattingEnabled = true;
			this.vmethod_48().Location = new Point(312, 62);
			this.vmethod_48().Name = "Combo_FollowReceiversNumber";
			this.vmethod_48().Size = new Size(102, 21);
			this.vmethod_48().TabIndex = 28;
			this.vmethod_34().Location = new Point(272, 43);
			this.vmethod_34().Name = "Label8";
			this.vmethod_34().Size = new Size(115, 13);
			this.vmethod_34().TabIndex = 21;
			this.vmethod_34().Text = "percent of mission fuel.";
			this.vmethod_36().method_14(null);
			this.vmethod_36().method_15(AutoCompleteMode.None);
			this.vmethod_36().method_13(AutoCompleteSource.None);
			this.vmethod_36().BackColor = Color.Transparent;
			this.vmethod_36().method_17(new Font("Segoe UI", 8f));
			this.vmethod_36().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_36().method_12(null);
			this.vmethod_36().method_18(null);
			this.vmethod_36().Location = new Point(238, 40);
			this.vmethod_36().method_2(32767);
			this.vmethod_36().method_7(false);
			this.vmethod_36().Name = "TextBox_FuelQtyToStartLookingForTanker";
			this.vmethod_36().method_3(false);
			this.vmethod_36().method_9(0);
			this.vmethod_36().Size = new Size(32, 20);
			this.vmethod_36().TabIndex = 19;
			this.vmethod_36().method_1(HorizontalAlignment.Left);
			this.vmethod_36().method_5(false);
			this.vmethod_36().method_10("");
			this.vmethod_40().AutoSize = true;
			this.vmethod_40().Location = new Point(6, 64);
			this.vmethod_40().Name = "CB_FollowReceivers";
			this.vmethod_40().Size = new Size(310, 19);
			this.vmethod_40().TabIndex = 19;
			this.vmethod_40().Text = "Tanker follows receiver's flightplan (enroute refueling)";
			this.vmethod_40().UseVisualStyleBackColor = true;
			this.vmethod_38().Location = new Point(4, 43);
			this.vmethod_38().Name = "Label7";
			this.vmethod_38().Size = new Size(236, 13);
			this.vmethod_38().TabIndex = 20;
			this.vmethod_38().Text = "Receivers start looking for tanker when down to ";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(789, 335);
			base.Controls.Add(this.vmethod_46());
			base.Controls.Add(this.vmethod_44());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_42());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new Size(805, 374);
			base.Name = "TankerPlanner";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Tanker Planner";
			base.TopMost = true;
			this.vmethod_42().ResumeLayout(false);
			this.vmethod_44().ResumeLayout(false);
			this.vmethod_44().PerformLayout();
			this.vmethod_46().ResumeLayout(false);
			this.vmethod_46().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06006C2F RID: 27695 RVA: 0x000441D1 File Offset: 0x000423D1
		[CompilerGenerated]
		internal RadioButton vmethod_0()
		{
			return this.radioButton_0;
		}

		// Token: 0x06006C30 RID: 27696 RVA: 0x003B7B1C File Offset: 0x003B5D1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_21);
			RadioButton radioButton = this.radioButton_0;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_0 = radioButton_7;
			radioButton = this.radioButton_0;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06006C31 RID: 27697 RVA: 0x000441D9 File Offset: 0x000423D9
		[CompilerGenerated]
		internal RadioButton vmethod_2()
		{
			return this.radioButton_1;
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x003B7B60 File Offset: 0x003B5D60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_29);
			RadioButton radioButton = this.radioButton_1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_1 = radioButton_7;
			radioButton = this.radioButton_1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06006C33 RID: 27699 RVA: 0x000441E1 File Offset: 0x000423E1
		[CompilerGenerated]
		internal RadioButton vmethod_4()
		{
			return this.radioButton_2;
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x003B7BA4 File Offset: 0x003B5DA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_26);
			RadioButton radioButton = this.radioButton_2;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_2 = radioButton_7;
			radioButton = this.radioButton_2;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x000441E9 File Offset: 0x000423E9
		[CompilerGenerated]
		internal RadioButton vmethod_6()
		{
			return this.radioButton_3;
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x003B7BE8 File Offset: 0x003B5DE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_25);
			RadioButton radioButton = this.radioButton_3;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_3 = radioButton_7;
			radioButton = this.radioButton_3;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x000441F1 File Offset: 0x000423F1
		[CompilerGenerated]
		internal RadioButton vmethod_8()
		{
			return this.radioButton_4;
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x003B7C2C File Offset: 0x003B5E2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_24);
			RadioButton radioButton = this.radioButton_4;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_4 = radioButton_7;
			radioButton = this.radioButton_4;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x000441F9 File Offset: 0x000423F9
		[CompilerGenerated]
		internal RadioButton vmethod_10()
		{
			return this.radioButton_5;
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x003B7C70 File Offset: 0x003B5E70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_23);
			RadioButton radioButton = this.radioButton_5;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_5 = radioButton_7;
			radioButton = this.radioButton_5;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06006C3B RID: 27707 RVA: 0x00044201 File Offset: 0x00042401
		[CompilerGenerated]
		internal RadioButton vmethod_12()
		{
			return this.radioButton_6;
		}

		// Token: 0x06006C3C RID: 27708 RVA: 0x003B7CB4 File Offset: 0x003B5EB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_22);
			RadioButton radioButton = this.radioButton_6;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_6 = radioButton_7;
			radioButton = this.radioButton_6;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06006C3D RID: 27709 RVA: 0x00044209 File Offset: 0x00042409
		[CompilerGenerated]
		internal Control8 vmethod_14()
		{
			return this.control8_0;
		}

		// Token: 0x06006C3E RID: 27710 RVA: 0x003B7CF8 File Offset: 0x003B5EF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control8 control8_5)
		{
			EventHandler value = new EventHandler(this.method_6);
			EventHandler value2 = new EventHandler(this.method_7);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.Enter -= value;
				control.Leave -= value2;
			}
			this.control8_0 = control8_5;
			control = this.control8_0;
			if (control != null)
			{
				control.Enter += value;
				control.Leave += value2;
			}
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x00044211 File Offset: 0x00042411
		[CompilerGenerated]
		internal Label vmethod_16()
		{
			return this.label_0;
		}

		// Token: 0x06006C40 RID: 27712 RVA: 0x00044219 File Offset: 0x00042419
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_6)
		{
			this.label_0 = label_6;
		}

		// Token: 0x06006C41 RID: 27713 RVA: 0x00044222 File Offset: 0x00042422
		[CompilerGenerated]
		internal Label vmethod_18()
		{
			return this.label_1;
		}

		// Token: 0x06006C42 RID: 27714 RVA: 0x0004422A File Offset: 0x0004242A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_6)
		{
			this.label_1 = label_6;
		}

		// Token: 0x06006C43 RID: 27715 RVA: 0x00044233 File Offset: 0x00042433
		[CompilerGenerated]
		internal Control8 vmethod_20()
		{
			return this.control8_1;
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x003B7D58 File Offset: 0x003B5F58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Control8 control8_5)
		{
			EventHandler value = new EventHandler(this.method_8);
			EventHandler value2 = new EventHandler(this.method_9);
			Control8 control = this.control8_1;
			if (control != null)
			{
				control.Enter -= value;
				control.Leave -= value2;
			}
			this.control8_1 = control8_5;
			control = this.control8_1;
			if (control != null)
			{
				control.Enter += value;
				control.Leave += value2;
			}
		}

		// Token: 0x06006C45 RID: 27717 RVA: 0x0004423B File Offset: 0x0004243B
		[CompilerGenerated]
		internal Label vmethod_22()
		{
			return this.label_2;
		}

		// Token: 0x06006C46 RID: 27718 RVA: 0x00044243 File Offset: 0x00042443
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Label label_6)
		{
			this.label_2 = label_6;
		}

		// Token: 0x06006C47 RID: 27719 RVA: 0x0004424C File Offset: 0x0004244C
		[CompilerGenerated]
		internal Control8 vmethod_24()
		{
			return this.control8_2;
		}

		// Token: 0x06006C48 RID: 27720 RVA: 0x003B7DB8 File Offset: 0x003B5FB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Control8 control8_5)
		{
			EventHandler value = new EventHandler(this.method_10);
			EventHandler value2 = new EventHandler(this.method_11);
			Control8 control = this.control8_2;
			if (control != null)
			{
				control.Enter -= value;
				control.Leave -= value2;
			}
			this.control8_2 = control8_5;
			control = this.control8_2;
			if (control != null)
			{
				control.Enter += value;
				control.Leave += value2;
			}
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x00044254 File Offset: 0x00042454
		[CompilerGenerated]
		internal Control4 vmethod_26()
		{
			return this.control4_0;
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x003B7E18 File Offset: 0x003B6018
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Control4 control4_1)
		{
			EventHandler value = new EventHandler(this.method_5);
			Control4 control = this.control4_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control4_0 = control4_1;
			control = this.control4_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006C4B RID: 27723 RVA: 0x0004425C File Offset: 0x0004245C
		[CompilerGenerated]
		internal Label vmethod_28()
		{
			return this.label_3;
		}

		// Token: 0x06006C4C RID: 27724 RVA: 0x00044264 File Offset: 0x00042464
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Label label_6)
		{
			this.label_3 = label_6;
		}

		// Token: 0x06006C4D RID: 27725 RVA: 0x0004426D File Offset: 0x0004246D
		[CompilerGenerated]
		internal Control8 vmethod_30()
		{
			return this.control8_3;
		}

		// Token: 0x06006C4E RID: 27726 RVA: 0x003B7E5C File Offset: 0x003B605C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Control8 control8_5)
		{
			EventHandler value = new EventHandler(this.method_12);
			EventHandler value2 = new EventHandler(this.method_13);
			Control8 control = this.control8_3;
			if (control != null)
			{
				control.Enter -= value;
				control.Leave -= value2;
			}
			this.control8_3 = control8_5;
			control = this.control8_3;
			if (control != null)
			{
				control.Enter += value;
				control.Leave += value2;
			}
		}

		// Token: 0x06006C4F RID: 27727 RVA: 0x00044275 File Offset: 0x00042475
		[CompilerGenerated]
		internal CheckBox vmethod_32()
		{
			return this.checkBox_0;
		}

		// Token: 0x06006C50 RID: 27728 RVA: 0x003B7EBC File Offset: 0x003B60BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(CheckBox checkBox_2)
		{
			EventHandler value = new EventHandler(this.method_27);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_0 = checkBox_2;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x0004427D File Offset: 0x0004247D
		[CompilerGenerated]
		internal Label vmethod_34()
		{
			return this.label_4;
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x00044285 File Offset: 0x00042485
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Label label_6)
		{
			this.label_4 = label_6;
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x0004428E File Offset: 0x0004248E
		[CompilerGenerated]
		internal Control8 vmethod_36()
		{
			return this.control8_4;
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x003B7F00 File Offset: 0x003B6100
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Control8 control8_5)
		{
			EventHandler value = new EventHandler(this.method_14);
			EventHandler value2 = new EventHandler(this.method_15);
			Control8 control = this.control8_4;
			if (control != null)
			{
				control.Enter -= value;
				control.Leave -= value2;
			}
			this.control8_4 = control8_5;
			control = this.control8_4;
			if (control != null)
			{
				control.Enter += value;
				control.Leave += value2;
			}
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x00044296 File Offset: 0x00042496
		[CompilerGenerated]
		internal Label vmethod_38()
		{
			return this.label_5;
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x0004429E File Offset: 0x0004249E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Label label_6)
		{
			this.label_5 = label_6;
		}

		// Token: 0x06006C57 RID: 27735 RVA: 0x000442A7 File Offset: 0x000424A7
		[CompilerGenerated]
		internal CheckBox vmethod_40()
		{
			return this.checkBox_1;
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x003B7F60 File Offset: 0x003B6160
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(CheckBox checkBox_2)
		{
			EventHandler value = new EventHandler(this.method_28);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_1 = checkBox_2;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x000442AF File Offset: 0x000424AF
		[CompilerGenerated]
		internal Class115 vmethod_42()
		{
			return this.class115_0;
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x000442B7 File Offset: 0x000424B7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Class115 class115_3)
		{
			this.class115_0 = class115_3;
		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x000442C0 File Offset: 0x000424C0
		[CompilerGenerated]
		internal Class115 vmethod_44()
		{
			return this.class115_1;
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x000442C8 File Offset: 0x000424C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Class115 class115_3)
		{
			this.class115_1 = class115_3;
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x000442D1 File Offset: 0x000424D1
		[CompilerGenerated]
		internal Class115 vmethod_46()
		{
			return this.class115_2;
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x000442D9 File Offset: 0x000424D9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Class115 class115_3)
		{
			this.class115_2 = class115_3;
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x000442E2 File Offset: 0x000424E2
		[CompilerGenerated]
		internal Class2451 vmethod_48()
		{
			return this.class2451_0;
		}

		// Token: 0x06006C60 RID: 27744 RVA: 0x003B7FA4 File Offset: 0x003B61A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_30);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_1;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06006C61 RID: 27745 RVA: 0x003B7FE8 File Offset: 0x003B61E8
		private void method_3()
		{
			this.vmethod_26().method_18().Clear();
			foreach (Side side in Client.smethod_46().method_44())
			{
				if (side == Client.smethod_50() || side.method_67(Client.smethod_50()))
				{
					try
					{
						foreach (Mission mission in Enumerable.OrderBy<Mission, string>(side.method_35(), (TankerPlanner._Closure$__.$I112-0 == null) ? (TankerPlanner._Closure$__.$I112-0 = new Func<Mission, string>(TankerPlanner._Closure$__.$I.method_0)) : TankerPlanner._Closure$__.$I112-0))
						{
							if (mission._MissionClass_0 == Mission._MissionClass.Support || mission._MissionClass_0 == Mission._MissionClass.Ferry)
							{
								Class117 @class = new Class117();
								if (side == Client.smethod_50())
								{
									@class.method_3(mission.Name);
								}
								else
								{
									@class.method_3(mission.Name + " (" + side.method_51() + ")");
								}
								@class.Tag = mission;
								this.vmethod_26().method_18().Add(@class);
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
			int num = this.vmethod_26().method_18().Count - 1;
			for (int j = 0; j <= num; j++)
			{
				if (!Information.IsNothing(this.mission_0))
				{
					if (this.mission_0.list_4.Contains((Mission)this.vmethod_26().method_18()[j].Tag))
					{
						this.vmethod_26().method_29(j);
					}
				}
				else if (!Information.IsNothing(this.waypoint_0) && this.waypoint_0.list_1.Contains((Mission)this.vmethod_26().method_18()[j].Tag))
				{
					this.vmethod_26().method_29(j);
				}
			}
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x003B81D8 File Offset: 0x003B63D8
		private void TankerPlanner_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				if (!Information.IsNothing(this.mission_0))
				{
					Mission.TankerMethod tankerMethod_ = this.mission_0.tankerMethod_0;
					if (tankerMethod_ != Mission.TankerMethod.Automatic)
					{
						if (tankerMethod_ == Mission.TankerMethod.Mission)
						{
							this.vmethod_2().Checked = false;
							this.vmethod_0().Checked = true;
						}
					}
					else
					{
						this.vmethod_2().Checked = true;
						this.vmethod_0().Checked = false;
					}
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					Mission.TankerMethod tankerMethod_2 = this.waypoint_0.tankerMethod_0;
					if (tankerMethod_2 != Mission.TankerMethod.Automatic)
					{
						if (tankerMethod_2 == Mission.TankerMethod.Mission)
						{
							this.vmethod_2().Checked = false;
							this.vmethod_0().Checked = true;
						}
					}
					else
					{
						this.vmethod_2().Checked = true;
						this.vmethod_0().Checked = false;
					}
				}
				this.method_4();
			}
		}

		// Token: 0x06006C63 RID: 27747 RVA: 0x003B82A4 File Offset: 0x003B64A4
		private void TankerPlanner_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.method_16();
			this.method_17();
			this.method_18();
			this.method_19();
			this.method_20();
			if (!Information.IsNothing(this.mission_0))
			{
				if (this.mission_0.tankerMethod_0 == Mission.TankerMethod.Mission && this.mission_0.list_4.Count == 0)
				{
					this.mission_0.tankerMethod_0 = Mission.TankerMethod.Automatic;
				}
			}
			else if (!Information.IsNothing(this.waypoint_0) && this.waypoint_0.tankerMethod_0 == Mission.TankerMethod.Mission && this.waypoint_0.list_1.Count == 0)
			{
				this.waypoint_0.tankerMethod_0 = Mission.TankerMethod.Automatic;
			}
			base.Hide();
			this.vmethod_26().Select();
			Client.smethod_30().BringToFront();
		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x003B8368 File Offset: 0x003B6568
		private void method_4()
		{
			if (!Information.IsNothing(this.mission_0))
			{
				this.vmethod_36().Enabled = true;
				this.vmethod_38().Enabled = true;
				this.vmethod_34().Enabled = true;
				this.vmethod_48().Enabled = false;
				this.vmethod_42().Enabled = true;
				this.vmethod_44().Enabled = true;
				this.vmethod_46().Enabled = true;
				this.vmethod_32().Enabled = true;
				Mission.TankerMethod tankerMethod_ = this.mission_0.tankerMethod_0;
				if (tankerMethod_ != Mission.TankerMethod.Automatic)
				{
					if (tankerMethod_ == Mission.TankerMethod.Mission)
					{
						this.vmethod_26().Enabled = true;
						this.vmethod_14().Enabled = true;
						this.vmethod_20().Enabled = true;
						this.vmethod_24().Enabled = true;
						this.vmethod_16().Enabled = true;
						this.vmethod_18().Enabled = true;
						this.vmethod_22().Enabled = true;
						this.method_3();
					}
				}
				else
				{
					this.vmethod_26().Enabled = false;
					this.vmethod_14().Enabled = false;
					this.vmethod_20().Enabled = false;
					this.vmethod_24().Enabled = false;
					this.vmethod_16().Enabled = false;
					this.vmethod_18().Enabled = false;
					this.vmethod_22().Enabled = false;
					this.vmethod_26().method_18().Clear();
				}
			}
			else if (!Information.IsNothing(this.waypoint_0))
			{
				this.vmethod_36().Enabled = false;
				this.vmethod_38().Enabled = false;
				this.vmethod_34().Enabled = false;
				this.vmethod_42().Enabled = true;
				this.vmethod_46().Enabled = true;
				this.vmethod_44().Enabled = false;
				Mission.TankerMethod tankerMethod_2 = this.waypoint_0.tankerMethod_0;
				if (tankerMethod_2 != Mission.TankerMethod.Automatic)
				{
					if (tankerMethod_2 == Mission.TankerMethod.Mission)
					{
						this.vmethod_26().Enabled = true;
						this.method_3();
					}
				}
				else
				{
					this.vmethod_26().Enabled = false;
					this.vmethod_26().method_18().Clear();
				}
				if (this.waypoint_0.bool_16)
				{
					this.vmethod_48().Enabled = true;
				}
				else
				{
					this.vmethod_48().Enabled = false;
				}
			}
			if (!Information.IsNothing(this.mission_0))
			{
				if (this.mission_0.tankerMethod_0 == Mission.TankerMethod.Mission)
				{
					if (this.mission_0.int_1 <= 0)
					{
						this.vmethod_14().Text = "Not specified";
					}
					else
					{
						this.vmethod_14().Text = Conversions.ToString(this.mission_0.int_1);
					}
					if (this.mission_0.int_2 <= 0)
					{
						this.vmethod_20().Text = "Not specified";
					}
					else
					{
						this.vmethod_20().Text = Conversions.ToString(this.mission_0.int_2);
					}
					if (this.mission_0.int_3 <= 0)
					{
						this.vmethod_24().Text = "Not specified";
					}
					else
					{
						this.vmethod_24().Text = Conversions.ToString(this.mission_0.int_3);
					}
					this.vmethod_32().Checked = this.mission_0.bool_17;
				}
			}
			else if (!Information.IsNothing(this.waypoint_0) && this.waypoint_0.tankerMethod_0 == Mission.TankerMethod.Mission)
			{
				this.vmethod_14().Text = "N/A";
				this.vmethod_20().Text = "N/A";
				this.vmethod_24().Text = "N/A";
				this.vmethod_32().Checked = false;
			}
			DataTable dataTable = new DataTable();
			if (!Information.IsNothing(this.mission_0))
			{
				this.vmethod_40().Checked = this.mission_0.bool_18;
				if (this.mission_0.int_4 <= 0)
				{
					this.vmethod_30().Text = "Not specified";
				}
				else
				{
					this.vmethod_30().Text = Conversions.ToString(this.mission_0.int_4);
				}
				if (this.mission_0.int_5 <= 0)
				{
					this.vmethod_36().Text = "None";
				}
				else
				{
					this.vmethod_36().Text = Conversions.ToString(this.mission_0.int_5);
				}
				this.vmethod_48().SelectedIndex = -1;
			}
			else if (!Information.IsNothing(this.waypoint_0))
			{
				this.vmethod_40().Checked = this.waypoint_0.bool_16;
				if (this.waypoint_0.int_0 <= 0)
				{
					this.vmethod_30().Text = "Not specified";
				}
				else
				{
					this.vmethod_30().Text = Conversions.ToString(this.waypoint_0.int_0);
				}
				this.vmethod_36().Text = "N/A";
				ComboBox comboBox = this.vmethod_48();
				TankerPlanner.smethod_0(ref comboBox, ref dataTable, this.waypoint_0.int_2);
				this.vmethod_49((Class2451)comboBox);
			}
			if (!Information.IsNothing(this.mission_0))
			{
				if (this.mission_0.int_6 == 2147483647)
				{
					this.vmethod_12().Checked = true;
					this.vmethod_10().Checked = false;
					this.vmethod_8().Checked = false;
					this.vmethod_6().Checked = false;
					this.vmethod_4().Checked = false;
					return;
				}
				if (this.mission_0.int_6 == 500)
				{
					this.vmethod_12().Checked = false;
					this.vmethod_10().Checked = true;
					this.vmethod_8().Checked = false;
					this.vmethod_6().Checked = false;
					this.vmethod_4().Checked = false;
					return;
				}
				if (this.mission_0.int_6 == 250)
				{
					this.vmethod_12().Checked = false;
					this.vmethod_10().Checked = false;
					this.vmethod_8().Checked = true;
					this.vmethod_6().Checked = false;
					this.vmethod_4().Checked = false;
					return;
				}
				if (this.mission_0.int_6 == 100)
				{
					this.vmethod_12().Checked = false;
					this.vmethod_10().Checked = false;
					this.vmethod_8().Checked = false;
					this.vmethod_6().Checked = true;
					this.vmethod_4().Checked = false;
					return;
				}
				if (this.mission_0.int_6 == 50)
				{
					this.vmethod_12().Checked = false;
					this.vmethod_10().Checked = false;
					this.vmethod_8().Checked = false;
					this.vmethod_6().Checked = false;
					this.vmethod_4().Checked = true;
					return;
				}
			}
			else if (!Information.IsNothing(this.waypoint_0))
			{
				if (this.waypoint_0.int_1 == 2147483647)
				{
					this.vmethod_12().Checked = true;
					this.vmethod_10().Checked = false;
					this.vmethod_8().Checked = false;
					this.vmethod_6().Checked = false;
					this.vmethod_4().Checked = false;
					return;
				}
				if (this.waypoint_0.int_1 == 500)
				{
					this.vmethod_12().Checked = false;
					this.vmethod_10().Checked = true;
					this.vmethod_8().Checked = false;
					this.vmethod_6().Checked = false;
					this.vmethod_4().Checked = false;
					return;
				}
				if (this.waypoint_0.int_1 == 250)
				{
					this.vmethod_12().Checked = false;
					this.vmethod_10().Checked = false;
					this.vmethod_8().Checked = true;
					this.vmethod_6().Checked = false;
					this.vmethod_4().Checked = false;
					return;
				}
				if (this.waypoint_0.int_1 == 100)
				{
					this.vmethod_12().Checked = false;
					this.vmethod_10().Checked = false;
					this.vmethod_8().Checked = false;
					this.vmethod_6().Checked = true;
					this.vmethod_4().Checked = false;
					return;
				}
				if (this.waypoint_0.int_1 == 50)
				{
					this.vmethod_12().Checked = false;
					this.vmethod_10().Checked = false;
					this.vmethod_8().Checked = false;
					this.vmethod_6().Checked = false;
					this.vmethod_4().Checked = true;
				}
			}
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x003B8B44 File Offset: 0x003B6D44
		public static void smethod_0(ref ComboBox comboBox_0, ref DataTable dataTable_0, int int_0)
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
				Mission.smethod_8(Mission.Enum104.const_0)
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				Mission.smethod_8(Mission.Enum104.const_1)
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				Mission.smethod_8(Mission.Enum104.const_2)
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				Mission.smethod_8(Mission.Enum104.const_3)
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				Mission.smethod_8(Mission.Enum104.const_4)
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				Mission.smethod_8(Mission.Enum104.const_5)
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				Mission.smethod_8(Mission.Enum104.const_6)
			});
			ComboBox comboBox = comboBox_0;
			comboBox.DataSource = dataTable_0;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			comboBox.SelectedIndex = Mission.smethod_7(int_0);
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x003B6260 File Offset: 0x003B4460
		private void TankerPlanner_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06006C67 RID: 27751 RVA: 0x003B8CE0 File Offset: 0x003B6EE0
		private void method_5(object sender, EventArgs e)
		{
			int num = this.vmethod_26().method_18().Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (this.vmethod_26().method_21().Contains(this.vmethod_26().method_18()[i]))
				{
					if (!Information.IsNothing(this.mission_0))
					{
						if (!this.mission_0.list_4.Contains((Mission)this.vmethod_26().method_18()[i].Tag))
						{
							this.mission_0.list_4.Add((Mission)this.vmethod_26().method_18()[i].Tag);
						}
					}
					else if (!Information.IsNothing(this.waypoint_0) && !this.waypoint_0.list_1.Contains((Mission)this.vmethod_26().method_18()[i].Tag))
					{
						this.waypoint_0.list_1.Add((Mission)this.vmethod_26().method_18()[i].Tag);
					}
				}
				else if (!Information.IsNothing(this.mission_0))
				{
					if (this.mission_0.list_4.Contains((Mission)this.vmethod_26().method_18()[i].Tag))
					{
						this.mission_0.list_4.Remove((Mission)this.vmethod_26().method_18()[i].Tag);
					}
				}
				else if (!Information.IsNothing(this.waypoint_0) && this.waypoint_0.list_1.Contains((Mission)this.vmethod_26().method_18()[i].Tag))
				{
					this.waypoint_0.list_1.Remove((Mission)this.vmethod_26().method_18()[i].Tag);
				}
			}
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x000442EA File Offset: 0x000424EA
		private void method_6(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x06006C69 RID: 27753 RVA: 0x000442F3 File Offset: 0x000424F3
		private void method_7(object sender, EventArgs e)
		{
			this.method_16();
		}

		// Token: 0x06006C6A RID: 27754 RVA: 0x000442FB File Offset: 0x000424FB
		private void method_8(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x06006C6B RID: 27755 RVA: 0x00044304 File Offset: 0x00042504
		private void method_9(object sender, EventArgs e)
		{
			this.method_17();
		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x0004430C File Offset: 0x0004250C
		private void method_10(object sender, EventArgs e)
		{
			this.bool_5 = true;
		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x00044315 File Offset: 0x00042515
		private void method_11(object sender, EventArgs e)
		{
			this.method_18();
		}

		// Token: 0x06006C6E RID: 27758 RVA: 0x0004431D File Offset: 0x0004251D
		private void method_12(object sender, EventArgs e)
		{
			this.bool_7 = true;
		}

		// Token: 0x06006C6F RID: 27759 RVA: 0x00044326 File Offset: 0x00042526
		private void method_13(object sender, EventArgs e)
		{
			this.method_19();
		}

		// Token: 0x06006C70 RID: 27760 RVA: 0x0004432E File Offset: 0x0004252E
		private void method_14(object sender, EventArgs e)
		{
			this.bool_8 = true;
		}

		// Token: 0x06006C71 RID: 27761 RVA: 0x00044337 File Offset: 0x00042537
		private void method_15(object sender, EventArgs e)
		{
			this.method_20();
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x003B8EE8 File Offset: 0x003B70E8
		private void method_16()
		{
			if (this.bool_3)
			{
				if (Information.IsNothing(this.mission_0))
				{
					return;
				}
				if (string.IsNullOrEmpty(this.vmethod_14().Text))
				{
					this.mission_0.int_1 = 0;
					this.vmethod_14().Text = "Not specified";
				}
				if (!Versioned.IsNumeric(this.vmethod_14().Text))
				{
					return;
				}
				int num = Conversions.ToInteger(this.vmethod_14().Text);
				if (num < 0)
				{
					num = 0;
				}
				this.mission_0.int_1 = num;
				if (num == 0)
				{
					this.vmethod_14().Text = "Not specified";
				}
				else
				{
					this.vmethod_14().Text = Conversions.ToString(num);
				}
			}
			this.bool_3 = false;
		}

		// Token: 0x06006C73 RID: 27763 RVA: 0x003B8FA0 File Offset: 0x003B71A0
		private void method_17()
		{
			if (this.bool_4)
			{
				if (Information.IsNothing(this.mission_0))
				{
					return;
				}
				if (string.IsNullOrEmpty(this.vmethod_20().Text))
				{
					this.mission_0.int_2 = 0;
					this.vmethod_20().Text = "Not specified";
				}
				if (!Versioned.IsNumeric(this.vmethod_20().Text))
				{
					return;
				}
				int num = Conversions.ToInteger(this.vmethod_20().Text);
				if (num < 0)
				{
					num = 0;
				}
				this.mission_0.int_2 = num;
				if (num == 0)
				{
					this.vmethod_20().Text = "Not specified";
				}
				else
				{
					this.vmethod_20().Text = Conversions.ToString(num);
				}
			}
			this.bool_4 = false;
		}

		// Token: 0x06006C74 RID: 27764 RVA: 0x003B9058 File Offset: 0x003B7258
		private void method_18()
		{
			if (this.bool_5)
			{
				if (Information.IsNothing(this.mission_0))
				{
					return;
				}
				if (string.IsNullOrEmpty(this.vmethod_24().Text))
				{
					this.mission_0.int_3 = 0;
					this.vmethod_24().Text = "Not specified";
				}
				if (!Versioned.IsNumeric(this.vmethod_24().Text))
				{
					return;
				}
				int num = Conversions.ToInteger(this.vmethod_24().Text);
				if (num < 0)
				{
					num = 0;
				}
				this.mission_0.int_3 = num;
				if (num == 0)
				{
					this.vmethod_24().Text = "Not specified";
				}
				else
				{
					this.vmethod_24().Text = Conversions.ToString(num);
				}
			}
			this.bool_5 = false;
		}

		// Token: 0x06006C75 RID: 27765 RVA: 0x003B9110 File Offset: 0x003B7310
		private void method_19()
		{
			if (this.bool_7)
			{
				if (!Information.IsNothing(this.mission_0))
				{
					if (string.IsNullOrEmpty(this.vmethod_30().Text))
					{
						this.mission_0.int_4 = 0;
						this.vmethod_30().Text = "Not specified";
					}
					if (!Versioned.IsNumeric(this.vmethod_30().Text))
					{
						return;
					}
					int num = Conversions.ToInteger(this.vmethod_30().Text);
					if (num < 0)
					{
						num = 0;
					}
					this.mission_0.int_4 = num;
					if (num == 0)
					{
						this.vmethod_30().Text = "Not specified";
					}
					else
					{
						this.vmethod_30().Text = Conversions.ToString(num);
					}
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					if (string.IsNullOrEmpty(this.vmethod_30().Text))
					{
						this.waypoint_0.int_0 = 0;
						this.vmethod_30().Text = "Not specified";
					}
					if (!Versioned.IsNumeric(this.vmethod_30().Text))
					{
						return;
					}
					int num2 = Conversions.ToInteger(this.vmethod_30().Text);
					if (num2 < 0)
					{
						num2 = 0;
					}
					this.waypoint_0.int_0 = num2;
					if (num2 == 0)
					{
						this.vmethod_30().Text = "Not specified";
					}
					else
					{
						this.vmethod_30().Text = Conversions.ToString(num2);
					}
				}
			}
			this.bool_7 = false;
		}

		// Token: 0x06006C76 RID: 27766 RVA: 0x003B926C File Offset: 0x003B746C
		private void method_20()
		{
			if (this.bool_8)
			{
				if (Information.IsNothing(this.mission_0))
				{
					return;
				}
				if (string.IsNullOrEmpty(this.vmethod_36().Text))
				{
					if (this.mission_0._MissionClass_0 == Mission._MissionClass.Strike)
					{
						this.mission_0.int_5 = 85;
						this.vmethod_36().Text = "85";
					}
					else if (this.mission_0._MissionClass_0 == Mission._MissionClass.Ferry)
					{
						this.mission_0.int_5 = 80;
						this.vmethod_36().Text = "80";
					}
					else if (this.mission_0._MissionClass_0 == Mission._MissionClass.Support)
					{
						this.mission_0.int_5 = 0;
						this.vmethod_36().Text = "0";
					}
					else
					{
						this.mission_0.int_5 = 60;
						this.vmethod_36().Text = "60";
					}
				}
				if (!Versioned.IsNumeric(this.vmethod_36().Text))
				{
					return;
				}
				int num = Conversions.ToInteger(this.vmethod_36().Text);
				if (num > 90)
				{
					this.vmethod_36().Text = "90";
					this.mission_0.int_5 = 90;
				}
				else if (num < 0)
				{
					this.vmethod_36().Text = "0";
					this.mission_0.int_5 = 0;
				}
				else
				{
					this.mission_0.int_5 = num;
				}
			}
			this.bool_8 = false;
		}

		// Token: 0x06006C77 RID: 27767 RVA: 0x003B93C8 File Offset: 0x003B75C8
		private void method_21(object sender, EventArgs e)
		{
			if (this.vmethod_0().Checked)
			{
				if (!Information.IsNothing(this.mission_0))
				{
					this.mission_0.tankerMethod_0 = Mission.TankerMethod.Mission;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.tankerMethod_0 = Mission.TankerMethod.Mission;
				}
				this.method_4();
			}
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x0004433F File Offset: 0x0004253F
		private void method_22(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0))
			{
				this.mission_0.int_6 = int.MaxValue;
				return;
			}
			if (!Information.IsNothing(this.waypoint_0))
			{
				this.waypoint_0.int_1 = int.MaxValue;
			}
		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x0004437C File Offset: 0x0004257C
		private void method_23(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0))
			{
				this.mission_0.int_6 = 500;
				return;
			}
			if (!Information.IsNothing(this.waypoint_0))
			{
				this.waypoint_0.int_1 = 500;
			}
		}

		// Token: 0x06006C7A RID: 27770 RVA: 0x000443B9 File Offset: 0x000425B9
		private void method_24(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0))
			{
				this.mission_0.int_6 = 250;
				return;
			}
			if (!Information.IsNothing(this.waypoint_0))
			{
				this.waypoint_0.int_1 = 250;
			}
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x000443F6 File Offset: 0x000425F6
		private void method_25(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0))
			{
				this.mission_0.int_6 = 100;
				return;
			}
			if (!Information.IsNothing(this.waypoint_0))
			{
				this.waypoint_0.int_1 = 100;
			}
		}

		// Token: 0x06006C7C RID: 27772 RVA: 0x0004442D File Offset: 0x0004262D
		private void method_26(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0))
			{
				this.mission_0.int_6 = 50;
				return;
			}
			if (!Information.IsNothing(this.waypoint_0))
			{
				this.waypoint_0.int_1 = 50;
			}
		}

		// Token: 0x06006C7D RID: 27773 RVA: 0x00044464 File Offset: 0x00042664
		private void method_27(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0))
			{
				this.mission_0.bool_17 = this.vmethod_32().Checked;
			}
		}

		// Token: 0x06006C7E RID: 27774 RVA: 0x00044489 File Offset: 0x00042689
		private void TankerPlanner_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x003B941C File Offset: 0x003B761C
		private void method_28(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0))
			{
				this.mission_0.bool_18 = this.vmethod_40().Checked;
				return;
			}
			if (!Information.IsNothing(this.waypoint_0))
			{
				this.waypoint_0.bool_16 = this.vmethod_40().Checked;
				if (this.waypoint_0.bool_16)
				{
					this.vmethod_48().Enabled = true;
					return;
				}
				this.vmethod_48().Enabled = false;
			}
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x003B9498 File Offset: 0x003B7698
		private void method_29(object sender, EventArgs e)
		{
			if (this.vmethod_2().Checked)
			{
				if (!Information.IsNothing(this.mission_0))
				{
					this.mission_0.tankerMethod_0 = Mission.TankerMethod.Automatic;
				}
				else if (!Information.IsNothing(this.waypoint_0))
				{
					this.waypoint_0.tankerMethod_0 = Mission.TankerMethod.Automatic;
				}
				this.method_4();
			}
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x0004449E File Offset: 0x0004269E
		private void method_30(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.waypoint_0))
			{
				this.waypoint_0.int_2 = (int)Mission.smethod_6(this.vmethod_48().SelectedIndex);
			}
		}

		// Token: 0x04003DCC RID: 15820
		[CompilerGenerated]
		[AccessedThroughProperty("RadioButton_Mission")]
		private RadioButton radioButton_0;

		// Token: 0x04003DCD RID: 15821
		[AccessedThroughProperty("RadioButton_Automatic")]
		[CompilerGenerated]
		private RadioButton radioButton_1;

		// Token: 0x04003DCE RID: 15822
		[AccessedThroughProperty("RadioButton_TankerMaxDistance_Airborne_50")]
		[CompilerGenerated]
		private RadioButton radioButton_2;

		// Token: 0x04003DCF RID: 15823
		[AccessedThroughProperty("RadioButton_TankerMaxDistance_Airborne_100")]
		[CompilerGenerated]
		private RadioButton radioButton_3;

		// Token: 0x04003DD0 RID: 15824
		[CompilerGenerated]
		[AccessedThroughProperty("RadioButton_TankerMaxDistance_Airborne_250")]
		private RadioButton radioButton_4;

		// Token: 0x04003DD1 RID: 15825
		[CompilerGenerated]
		[AccessedThroughProperty("RadioButton_TankerMaxDistance_Airborne_500")]
		private RadioButton radioButton_5;

		// Token: 0x04003DD2 RID: 15826
		[CompilerGenerated]
		[AccessedThroughProperty("RadioButton_TankerMaxDistance_Airborne_Tactical")]
		private RadioButton radioButton_6;

		// Token: 0x04003DD3 RID: 15827
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_TankerMinimum_Total")]
		private Control8 control8_0;

		// Token: 0x04003DD4 RID: 15828
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label label_0;

		// Token: 0x04003DD5 RID: 15829
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Label label_1;

		// Token: 0x04003DD6 RID: 15830
		[AccessedThroughProperty("TextBox_TankerMinimum_Airborne")]
		[CompilerGenerated]
		private Control8 control8_1;

		// Token: 0x04003DD7 RID: 15831
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04003DD8 RID: 15832
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_TankerMinimum_Station")]
		private Control8 control8_2;

		// Token: 0x04003DD9 RID: 15833
		[CompilerGenerated]
		[AccessedThroughProperty("ListBox_Tankers")]
		private Control4 control4_0;

		// Token: 0x04003DDA RID: 15834
		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Label label_3;

		// Token: 0x04003DDB RID: 15835
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_MaxReceiversInQueuePerTanker_Airborne")]
		private Control8 control8_3;

		// Token: 0x04003DDC RID: 15836
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_LaunchMissionWithoutTankersInPlace")]
		private CheckBox checkBox_0;

		// Token: 0x04003DDD RID: 15837
		[CompilerGenerated]
		[AccessedThroughProperty("Label8")]
		private Label label_4;

		// Token: 0x04003DDE RID: 15838
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_FuelQtyToStartLookingForTanker")]
		private Control8 control8_4;

		// Token: 0x04003DDF RID: 15839
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Label label_5;

		// Token: 0x04003DE0 RID: 15840
		[CompilerGenerated]
		[AccessedThroughProperty("CB_FollowReceivers")]
		private CheckBox checkBox_1;

		// Token: 0x04003DE1 RID: 15841
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox1")]
		private Class115 class115_0;

		// Token: 0x04003DE2 RID: 15842
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox3")]
		private Class115 class115_1;

		// Token: 0x04003DE3 RID: 15843
		[AccessedThroughProperty("GroupBox4")]
		[CompilerGenerated]
		private Class115 class115_2;

		// Token: 0x04003DE4 RID: 15844
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_FollowReceiversNumber")]
		private Class2451 class2451_0;

		// Token: 0x04003DE5 RID: 15845
		public Mission mission_0;

		// Token: 0x04003DE6 RID: 15846
		public Waypoint waypoint_0;

		// Token: 0x04003DE7 RID: 15847
		private bool bool_3;

		// Token: 0x04003DE8 RID: 15848
		private bool bool_4;

		// Token: 0x04003DE9 RID: 15849
		private bool bool_5;

		// Token: 0x04003DEA RID: 15850
		private bool bool_6;

		// Token: 0x04003DEB RID: 15851
		private bool bool_7;

		// Token: 0x04003DEC RID: 15852
		private bool bool_8;
	}
}
