using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns2;
using ns4;
using ns5;

namespace ns7
{
	// Token: 0x02000F19 RID: 3865
	[DesignerGenerated]
	internal sealed partial class Form_QuickTurnaround : DarkSecondaryFormBase
	{
		// Token: 0x06008915 RID: 35093 RVA: 0x00495694 File Offset: 0x00493894
		public Form_QuickTurnaround()
		{
			base.FormClosing += this.Form_QuickTurnaround_FormClosing;
			base.Load += this.Form_QuickTurnaround_Load;
			base.KeyDown += this.Form_QuickTurnaround_KeyDown;
			this.InitializeComponent_1();
		}

		// Token: 0x06008917 RID: 35095 RVA: 0x00495724 File Offset: 0x00493924
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class112());
			this.vmethod_3(new Class2451());
			this.vmethod_5(new Class116());
			base.SuspendLayout();
			this.vmethod_0().AutoSize = true;
			this.vmethod_0().Location = new Point(11, 12);
			this.vmethod_0().Name = "CB_QuickTurnaround";
			this.vmethod_0().Size = new Size(161, 19);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Enable Quick Turnaround";
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_2().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_2().Font = new Font("Segoe UI", 7f);
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Location = new Point(178, 11);
			this.vmethod_2().Name = "Combo_NumberOfSorties";
			this.vmethod_2().Size = new Size(147, 21);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().method_2(true);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(331, 16);
			this.vmethod_4().Name = "Label_QuickTurnaroundInfo";
			this.vmethod_4().Size = new Size(155, 15);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Label_QuickTurnaroundInfo";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(483, 44);
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form_QuickTurnaround";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Quick Turnaround configuration for airborne aircraft for";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008918 RID: 35096 RVA: 0x00052594 File Offset: 0x00050794
		[CompilerGenerated]
		internal Class112 vmethod_0()
		{
			return this.class112_0;
		}

		// Token: 0x06008919 RID: 35097 RVA: 0x00495980 File Offset: 0x00493B80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class112 class112_1)
		{
			EventHandler value = new EventHandler(this.method_3);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_0 = class112_1;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x0600891A RID: 35098 RVA: 0x0005259C File Offset: 0x0005079C
		[CompilerGenerated]
		internal Class2451 vmethod_2()
		{
			return this.class2451_0;
		}

		// Token: 0x0600891B RID: 35099 RVA: 0x004959C4 File Offset: 0x00493BC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectedIndexChanged -= value;
			}
			this.class2451_0 = class2451_1;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectedIndexChanged += value;
			}
		}

		// Token: 0x0600891C RID: 35100 RVA: 0x000525A4 File Offset: 0x000507A4
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_0;
		}

		// Token: 0x0600891D RID: 35101 RVA: 0x000525AC File Offset: 0x000507AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x0600891E RID: 35102 RVA: 0x00495A08 File Offset: 0x00493C08
		private void Form_QuickTurnaround_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().Enabled = true;
			Client.bool_1 = true;
			if (Client.smethod_0().method_0() == Class279.Enum68.const_0)
			{
				Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54(), false);
			}
		}

		// Token: 0x0600891F RID: 35103 RVA: 0x00495A5C File Offset: 0x00493C5C
		private void Form_QuickTurnaround_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			Class2413.smethod_2().method_41().Enabled = false;
			this.Text = this.Text + " " + Client.smethod_54().Name;
			this.bool_3 = false;
			this.vmethod_4().Text = "";
			this.vmethod_0().Enabled = false;
			this.vmethod_2().Enabled = false;
			if (!Information.IsNothing(Client.smethod_54()) && Client.smethod_54().bool_3)
			{
				this.aircraft_0 = (Aircraft)Client.smethod_54();
				if (!Information.IsNothing(this.aircraft_0.method_167()) && this.aircraft_0.method_167().bool_13)
				{
					Aircraft_AirOps aircraft_AirOps = this.aircraft_0.method_164();
					this.int_0 = this.aircraft_0.method_167().int_10;
					this.vmethod_0().Enabled = true;
					this.vmethod_0().Checked = aircraft_AirOps.bool_0;
					this.vmethod_2().Enabled = aircraft_AirOps.bool_0;
					this.method_4(new int?(aircraft_AirOps.int_2), ref this.aircraft_0);
				}
			}
			this.bool_3 = true;
		}

		// Token: 0x06008920 RID: 35104 RVA: 0x000525B5 File Offset: 0x000507B5
		private void method_3(object sender, EventArgs e)
		{
			if (this.bool_3)
			{
				this.method_4(new int?(this.int_0), ref this.aircraft_0);
			}
		}

		// Token: 0x06008921 RID: 35105 RVA: 0x00495B9C File Offset: 0x00493D9C
		private void method_4(int? nullable_0, ref Aircraft aircraft_1)
		{
			Aircraft_AirOps aircraft_AirOps = aircraft_1.method_164();
			if (aircraft_AirOps.int_1 <= 0)
			{
				aircraft_AirOps.int_1 = 1;
			}
			if (this.vmethod_0().Checked)
			{
				this.vmethod_2().Enabled = true;
				this.method_5(nullable_0);
				this.vmethod_4().Enabled = true;
				this.vmethod_4().Text = Class2413.smethod_2().method_7().method_46();
				if (this.bool_3)
				{
					aircraft_AirOps.bool_0 = true;
					return;
				}
			}
			else
			{
				this.vmethod_2().Enabled = false;
				this.method_5(nullable_0);
				this.vmethod_4().Enabled = false;
				this.vmethod_4().Text = "";
				if (this.bool_3)
				{
					aircraft_AirOps.bool_0 = false;
				}
			}
		}

		// Token: 0x06008922 RID: 35106 RVA: 0x00495C58 File Offset: 0x00493E58
		private void method_5(int? nullable_0)
		{
			this.vmethod_2().Items.Clear();
			this.vmethod_2().SelectedIndex = -1;
			if (this.vmethod_0().Checked)
			{
				int num = this.int_0;
				for (int i = 2; i <= num; i++)
				{
					if (i == this.int_0)
					{
						this.vmethod_2().Items.Add(Conversions.ToString(i) + " Sorties (Maximum)");
					}
					else
					{
						this.vmethod_2().Items.Add(Conversions.ToString(i) + " Sorties");
					}
				}
				Aircraft_AirOps aircraft_AirOps = this.aircraft_0.method_164();
				if (this.bool_3)
				{
					this.vmethod_2().SelectedIndex = this.int_0 - 2;
				}
				else
				{
					this.vmethod_2().SelectedIndex = aircraft_AirOps.int_2 - 2;
				}
				if (this.vmethod_2().SelectedIndex + 2 <= this.aircraft_0.method_167().int_10)
				{
					aircraft_AirOps.int_2 = this.vmethod_2().SelectedIndex + 2;
				}
			}
			this.vmethod_4().Text = Class2413.smethod_2().method_7().method_46();
		}

		// Token: 0x06008923 RID: 35107 RVA: 0x003B6260 File Offset: 0x003B4460
		private void Form_QuickTurnaround_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06008924 RID: 35108 RVA: 0x00495D7C File Offset: 0x00493F7C
		private void method_6(object sender, EventArgs e)
		{
			this.vmethod_4().Text = Class2413.smethod_2().method_7().method_46();
			if (this.bool_3)
			{
				Aircraft_AirOps aircraft_AirOps = this.aircraft_0.method_164();
				if (this.vmethod_2().SelectedIndex + 2 <= this.aircraft_0.method_167().int_10)
				{
					aircraft_AirOps.int_2 = this.vmethod_2().SelectedIndex + 2;
				}
			}
		}

		// Token: 0x04004A87 RID: 19079
		[AccessedThroughProperty("CB_QuickTurnaround")]
		[CompilerGenerated]
		private Class112 class112_0;

		// Token: 0x04004A88 RID: 19080
		[AccessedThroughProperty("Combo_NumberOfSorties")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04004A89 RID: 19081
		[AccessedThroughProperty("Label_QuickTurnaroundInfo")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04004A8A RID: 19082
		private Aircraft aircraft_0;

		// Token: 0x04004A8B RID: 19083
		private int int_0;

		// Token: 0x04004A8C RID: 19084
		private bool bool_3;
	}
}
