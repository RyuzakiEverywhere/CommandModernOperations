using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;

namespace ns4
{
	// Token: 0x02000E45 RID: 3653
	[DesignerGenerated]
	internal sealed partial class ChanceOfAppearance : DarkSecondaryFormBase
	{
		// Token: 0x06006DF1 RID: 28145 RVA: 0x00045422 File Offset: 0x00043622
		public ChanceOfAppearance()
		{
			base.Shown += this.ChanceOfAppearance_Shown;
			this.InitializeComponent_1();
		}

		// Token: 0x06006DF3 RID: 28147 RVA: 0x003BD98C File Offset: 0x003BBB8C
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control9());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Control10());
			this.vmethod_7(new Class116());
			base.SuspendLayout();
			this.vmethod_0().BackColor = Color.Transparent;
			this.vmethod_0().DialogResult = DialogResult.Cancel;
			this.vmethod_0().ForeColor = SystemColors.Control;
			this.vmethod_0().Location = new Point(217, 53);
			this.vmethod_0().Name = "Button2";
			this.vmethod_0().method_1(0);
			this.vmethod_0().Size = new Size(75, 23);
			this.vmethod_0().TabIndex = 5;
			this.vmethod_0().Text = "Cancel";
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DialogResult = DialogResult.None;
			this.vmethod_2().ForeColor = SystemColors.Control;
			this.vmethod_2().Location = new Point(8, 53);
			this.vmethod_2().Name = "Button1";
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(75, 23);
			this.vmethod_2().TabIndex = 4;
			this.vmethod_2().Text = "OK";
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().Location = new Point(96, 22);
			this.vmethod_4().method_1(100);
			this.vmethod_4().method_3(0);
			this.vmethod_4().Name = "NumericUpDown1";
			this.vmethod_4().Size = new Size(120, 26);
			this.vmethod_4().TabIndex = 6;
			this.vmethod_4().Value = 5;
			this.vmethod_6().method_2(true);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(2, 4);
			this.vmethod_6().Name = "Label1";
			this.vmethod_6().Size = new Size(344, 15);
			this.vmethod_6().TabIndex = 7;
			this.vmethod_6().Text = "Set probability (%) that the unit will be present on scenario load:";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(301, 87);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ChanceOfAppearance";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Chance Of Appearance";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06006DF4 RID: 28148 RVA: 0x00045442 File Offset: 0x00043642
		[CompilerGenerated]
		internal Control9 vmethod_0()
		{
			return this.control9_0;
		}

		// Token: 0x06006DF5 RID: 28149 RVA: 0x003BDC7C File Offset: 0x003BBE7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_2;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006DF6 RID: 28150 RVA: 0x0004544A File Offset: 0x0004364A
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_1;
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x003BDCC0 File Offset: 0x003BBEC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_2;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006DF8 RID: 28152 RVA: 0x00045452 File Offset: 0x00043652
		[CompilerGenerated]
		internal Control10 vmethod_4()
		{
			return this.control10_0;
		}

		// Token: 0x06006DF9 RID: 28153 RVA: 0x0004545A File Offset: 0x0004365A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control10 control10_1)
		{
			this.control10_0 = control10_1;
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x00045463 File Offset: 0x00043663
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_0;
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x0004546B File Offset: 0x0004366B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x06006DFC RID: 28156 RVA: 0x003BDD04 File Offset: 0x003BBF04
		private void ChanceOfAppearance_Shown(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.string_0))
			{
				ActiveUnit activeUnit = Client.smethod_46().vmethod_0()[this.string_0];
				this.vmethod_4().Value = activeUnit.int_5;
			}
		}

		// Token: 0x06006DFD RID: 28157 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06006DFE RID: 28158 RVA: 0x003BDD48 File Offset: 0x003BBF48
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_4().Value != 0 || DarkMessageBox.smethod_1("Setting the chance of appearance to 0% will cause the unit to always show up, is this what you want?", "Warning", Enum11.const_0) != DialogResult.No)
			{
				Client.smethod_46().vmethod_0()[this.string_0].int_5 = this.vmethod_4().Value;
				base.Close();
			}
		}

		// Token: 0x04003E8E RID: 16014
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_0;

		// Token: 0x04003E8F RID: 16015
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_1;

		// Token: 0x04003E90 RID: 16016
		[CompilerGenerated]
		[AccessedThroughProperty("NumericUpDown1")]
		private Control10 control10_0;

		// Token: 0x04003E91 RID: 16017
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04003E92 RID: 16018
		public string string_0;
	}
}
