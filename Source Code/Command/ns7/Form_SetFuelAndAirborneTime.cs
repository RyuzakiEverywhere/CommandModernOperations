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
using ns10;
using ns2;
using ns3;
using ns4;
using ns5;
using ns8;

namespace ns7
{
	// Token: 0x02000F1C RID: 3868
	[DesignerGenerated]
	internal sealed partial class Form_SetFuelAndAirborneTime : DarkSecondaryFormBase
	{
		// Token: 0x0600895B RID: 35163 RVA: 0x00497170 File Offset: 0x00495370
		public Form_SetFuelAndAirborneTime()
		{
			base.Load += this.Form_SetFuelAndAirborneTime_Load;
			base.KeyDown += this.Form_SetFuelAndAirborneTime_KeyDown;
			base.FormClosing += this.Form_SetFuelAndAirborneTime_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x0600895D RID: 35165 RVA: 0x00497200 File Offset: 0x00495400
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class116());
			this.vmethod_3(new TextBox());
			this.vmethod_5(new MaskedTextBox());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Class112());
			base.SuspendLayout();
			this.vmethod_0().method_2(true);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(9, 36);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(127, 15);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Remaining fuel (units):";
			this.vmethod_2().BackColor = Color.Black;
			this.vmethod_2().ForeColor = Color.LightGray;
			this.vmethod_2().Location = new Point(172, 33);
			this.vmethod_2().Name = "TB_RemainingFuel";
			this.vmethod_2().Size = new Size(64, 23);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().BackColor = Color.Black;
			this.vmethod_4().ForeColor = Color.LightGray;
			this.vmethod_4().Location = new Point(172, 11);
			this.vmethod_4().Mask = "00:00:00";
			this.vmethod_4().Name = "TB_AirborneTime";
			this.vmethod_4().Size = new Size(64, 23);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_6().method_2(true);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(10, 14);
			this.vmethod_6().Name = "Label2";
			this.vmethod_6().Size = new Size(161, 15);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "Airborne time (hr : min : sec):";
			this.vmethod_8().Location = new Point(252, 14);
			this.vmethod_8().Name = "CheckBox1";
			this.vmethod_8().Size = new Size(169, 37);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "Automatically adjust fuel (optimum altitude + 10%)";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(509, 61);
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form_SetFuelAndAirborneTime";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Set fuel and airborne time for";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600895E RID: 35166 RVA: 0x0005274A File Offset: 0x0005094A
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x0600895F RID: 35167 RVA: 0x00052752 File Offset: 0x00050952
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_2)
		{
			this.class116_0 = class116_2;
		}

		// Token: 0x06008960 RID: 35168 RVA: 0x0005275B File Offset: 0x0005095B
		[CompilerGenerated]
		internal TextBox vmethod_2()
		{
			return this.textBox_0;
		}

		// Token: 0x06008961 RID: 35169 RVA: 0x0049754C File Offset: 0x0049574C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TextBox textBox_1)
		{
			EventHandler value = new EventHandler(this.method_5);
			EventHandler value2 = new EventHandler(this.method_7);
			TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
				textBox.Enter -= value2;
			}
			this.textBox_0 = textBox_1;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged += value;
				textBox.Enter += value2;
			}
		}

		// Token: 0x06008962 RID: 35170 RVA: 0x00052763 File Offset: 0x00050963
		[CompilerGenerated]
		internal MaskedTextBox vmethod_4()
		{
			return this.maskedTextBox_0;
		}

		// Token: 0x06008963 RID: 35171 RVA: 0x004975AC File Offset: 0x004957AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(MaskedTextBox maskedTextBox_1)
		{
			EventHandler value = new EventHandler(this.method_8);
			MaskedTextBox maskedTextBox = this.maskedTextBox_0;
			if (maskedTextBox != null)
			{
				maskedTextBox.TextChanged -= value;
			}
			this.maskedTextBox_0 = maskedTextBox_1;
			maskedTextBox = this.maskedTextBox_0;
			if (maskedTextBox != null)
			{
				maskedTextBox.TextChanged += value;
			}
		}

		// Token: 0x06008964 RID: 35172 RVA: 0x0005276B File Offset: 0x0005096B
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_1;
		}

		// Token: 0x06008965 RID: 35173 RVA: 0x00052773 File Offset: 0x00050973
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_2)
		{
			this.class116_1 = class116_2;
		}

		// Token: 0x06008966 RID: 35174 RVA: 0x0005277C File Offset: 0x0005097C
		[CompilerGenerated]
		internal Class112 vmethod_8()
		{
			return this.class112_0;
		}

		// Token: 0x06008967 RID: 35175 RVA: 0x004975F0 File Offset: 0x004957F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class112 class112_1)
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

		// Token: 0x06008968 RID: 35176 RVA: 0x00052784 File Offset: 0x00050984
		private void method_3(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.bool_3 && this.vmethod_8().Checked)
			{
				this.method_4();
			}
		}

		// Token: 0x06008969 RID: 35177 RVA: 0x00497634 File Offset: 0x00495834
		private void method_4()
		{
			double num = (double)this.activeUnit_0.vmethod_98(ActiveUnit.Throttle.Cruise, this.activeUnit_0.vmethod_49()[0].method_24(ActiveUnit.Throttle.Cruise), null, null, false, false, false, false, false);
			float float_ = ((Aircraft)this.activeUnit_0).float_26;
			float num2 = (float)(num * 1.1 * (double)float_);
			Aircraft aircraft = (Aircraft)this.activeUnit_0;
			float num3 = (float)aircraft.vmethod_115() - num2;
			if (num3 <= 0f)
			{
				DarkMessageBox.smethod_1("Fuel quantity will be zero or negative. Skipping auto-calculating fuel quantity.", "", Enum11.const_0);
				return;
			}
			aircraft.method_156(num3);
			this.bool_3 = false;
			this.vmethod_2().Text = Conversions.ToString(num3);
			this.bool_3 = true;
		}

		// Token: 0x0600896A RID: 35178 RVA: 0x004976F4 File Offset: 0x004958F4
		private void method_5(object sender, EventArgs e)
		{
			if (this.bool_3 && Versioned.IsNumeric(this.vmethod_2().Text))
			{
				if (Conversions.ToSingle(this.vmethod_2().Text) > 0f)
				{
					if (!Information.IsNothing(this.activeUnit_0))
					{
						((Aircraft)this.activeUnit_0).method_156(Conversions.ToSingle(this.vmethod_2().Text));
						return;
					}
				}
				else
				{
					this.vmethod_2().Text = Conversions.ToString(this.float_0);
					DarkMessageBox.smethod_2("Fuel quantity cannot be zero or negative.", "", Enum11.const_0);
				}
			}
		}

		// Token: 0x0600896B RID: 35179 RVA: 0x00497788 File Offset: 0x00495988
		private void Form_SetFuelAndAirborneTime_Load(object sender, EventArgs e)
		{
			this.vmethod_4().BackColor = Class129.smethod_4();
			this.vmethod_2().BackColor = Class129.smethod_4();
			this.bool_3 = false;
			this.Text = this.Text + " " + Client.smethod_54().Name;
			if (!Information.IsNothing(Client.smethod_54()) && Client.smethod_54().bool_3)
			{
				this.activeUnit_0 = (ActiveUnit)Client.smethod_54();
				Aircraft aircraft = (Aircraft)this.activeUnit_0;
				if (!Information.IsNothing(aircraft.method_167()))
				{
					aircraft.method_164();
					this.vmethod_4().Text = this.method_6((int)Math.Round((double)aircraft.float_26));
					this.vmethod_2().Text = Conversions.ToString(aircraft.vmethod_116());
				}
			}
			this.bool_3 = true;
		}

		// Token: 0x0600896C RID: 35180 RVA: 0x00497860 File Offset: 0x00495A60
		private string method_6(int int_0)
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds((double)int_0);
			string result;
			if (timeSpan.Hours > 0)
			{
				result = string.Concat(new string[]
				{
					Interaction.IIf(timeSpan.Hours < 10, "0", "").ToString(),
					Conversions.ToString(timeSpan.Hours),
					":",
					Interaction.IIf(timeSpan.Minutes == 0, "00", Interaction.IIf(timeSpan.Minutes < 10, "0", "").ToString() + Conversions.ToString(timeSpan.Minutes)).ToString(),
					":",
					Interaction.IIf(timeSpan.Seconds == 0, "00", Interaction.IIf(timeSpan.Seconds < 10, "0", "").ToString() + Conversions.ToString(timeSpan.Seconds)).ToString()
				});
			}
			else if (timeSpan.Minutes > 0)
			{
				result = string.Concat(new string[]
				{
					"00:",
					Interaction.IIf(timeSpan.Minutes < 10, "0", "").ToString(),
					Conversions.ToString(timeSpan.Minutes),
					":",
					Interaction.IIf(timeSpan.Seconds == 0, "00", Interaction.IIf(timeSpan.Seconds < 10, "0", "").ToString() + Conversions.ToString(timeSpan.Seconds)).ToString()
				});
			}
			else if (timeSpan.Seconds > 0)
			{
				result = "00:00:" + Interaction.IIf(timeSpan.Seconds < 10, "0", "").ToString() + Conversions.ToString(timeSpan.Seconds);
			}
			else
			{
				result = "00:00:00";
			}
			return result;
		}

		// Token: 0x0600896D RID: 35181 RVA: 0x003B6260 File Offset: 0x003B4460
		private void Form_SetFuelAndAirborneTime_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x0600896E RID: 35182 RVA: 0x000527B3 File Offset: 0x000509B3
		private void method_7(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_2().Text))
			{
				this.float_0 = Conversions.ToSingle(this.vmethod_2().Text);
			}
		}

		// Token: 0x0600896F RID: 35183 RVA: 0x00495A08 File Offset: 0x00493C08
		private void Form_SetFuelAndAirborneTime_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().Enabled = true;
			Client.bool_1 = true;
			if (Client.smethod_0().method_0() == Class279.Enum68.const_0)
			{
				Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54(), false);
			}
		}

		// Token: 0x06008970 RID: 35184 RVA: 0x00497A60 File Offset: 0x00495C60
		private void method_8(object sender, EventArgs e)
		{
			List<string> list = Enumerable.ToList<string>(this.vmethod_4().Text.Split(new char[]
			{
				':'
			}));
			if (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2]))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2]));
				if (this.activeUnit_0.bool_3)
				{
					((Aircraft)this.activeUnit_0).float_26 = (float)timeSpan.TotalSeconds;
				}
				if (this.vmethod_8().Checked)
				{
					this.method_4();
				}
			}
		}

		// Token: 0x04004AA9 RID: 19113
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004AAA RID: 19114
		[AccessedThroughProperty("TB_RemainingFuel")]
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04004AAB RID: 19115
		[CompilerGenerated]
		[AccessedThroughProperty("TB_AirborneTime")]
		private MaskedTextBox maskedTextBox_0;

		// Token: 0x04004AAC RID: 19116
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x04004AAD RID: 19117
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox1")]
		private Class112 class112_0;

		// Token: 0x04004AAE RID: 19118
		private bool bool_3;

		// Token: 0x04004AAF RID: 19119
		private ActiveUnit activeUnit_0;

		// Token: 0x04004AB0 RID: 19120
		private float float_0;
	}
}
