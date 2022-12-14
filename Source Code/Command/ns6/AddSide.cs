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
using ns2;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000EE4 RID: 3812
	[DesignerGenerated]
	internal sealed partial class AddSide : DarkSecondaryFormBase
	{
		// Token: 0x060085B9 RID: 34233 RVA: 0x0047C4EC File Offset: 0x0047A6EC
		public AddSide()
		{
			base.FormClosing += this.AddSide_FormClosing;
			base.Load += this.AddSide_Load;
			base.KeyDown += this.AddSide_KeyDown;
			this.InitializeComponent_1();
		}

		// Token: 0x060085BB RID: 34235 RVA: 0x0047C57C File Offset: 0x0047A77C
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class116());
			this.vmethod_3(new Control8());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Control9());
			base.SuspendLayout();
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(13, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(54, 17);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Name:";
			this.vmethod_2().method_14(null);
			this.vmethod_2().method_15(AutoCompleteMode.None);
			this.vmethod_2().method_13(AutoCompleteSource.None);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_2().method_12(null);
			this.vmethod_2().method_18(null);
			this.vmethod_2().Location = new Point(57, 10);
			this.vmethod_2().method_2(32767);
			this.vmethod_2().method_7(false);
			this.vmethod_2().Name = "TextBox1";
			this.vmethod_2().method_3(false);
			this.vmethod_2().method_19(ScrollBars.None);
			this.vmethod_2().method_9(0);
			this.vmethod_2().Size = new Size(212, 20);
			this.vmethod_2().TabIndex = 0;
			this.vmethod_2().method_1(HorizontalAlignment.Left);
			this.vmethod_2().method_5(false);
			this.vmethod_2().method_10("");
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(57, 36);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(75, 23);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "OK";
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.Cancel;
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(194, 36);
			this.vmethod_6().Name = "Button2";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(75, 23);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "Cancel";
			base.AcceptButton = this.vmethod_4();
			base.AutoScaleMode = AutoScaleMode.None;
			base.CancelButton = this.vmethod_6();
			base.ClientSize = new Size(281, 68);
			base.ControlBox = false;
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddSide";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Create a new side";
			base.ResumeLayout(false);
		}

		// Token: 0x060085BC RID: 34236 RVA: 0x00050CC7 File Offset: 0x0004EEC7
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x060085BD RID: 34237 RVA: 0x00050CCF File Offset: 0x0004EECF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x060085BE RID: 34238 RVA: 0x00050CD8 File Offset: 0x0004EED8
		[CompilerGenerated]
		internal Control8 vmethod_2()
		{
			return this.control8_0;
		}

		// Token: 0x060085BF RID: 34239 RVA: 0x0047C934 File Offset: 0x0047AB34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control8 control8_1)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_5);
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

		// Token: 0x060085C0 RID: 34240 RVA: 0x00050CE0 File Offset: 0x0004EEE0
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_0;
		}

		// Token: 0x060085C1 RID: 34241 RVA: 0x0047C978 File Offset: 0x0047AB78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_3);
			EventHandler value2 = new EventHandler(this.method_4);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
				control.DoubleClick -= value2;
			}
			this.control9_0 = control9_2;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
				control.DoubleClick += value2;
			}
		}

		// Token: 0x060085C2 RID: 34242 RVA: 0x00050CE8 File Offset: 0x0004EEE8
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_1;
		}

		// Token: 0x060085C3 RID: 34243 RVA: 0x0047C9D8 File Offset: 0x0047ABD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x060085C4 RID: 34244 RVA: 0x0047CA1C File Offset: 0x0047AC1C
		private void method_3(object sender, EventArgs e)
		{
			string text = this.vmethod_2().Text;
			Scenario scenario = Client.smethod_46();
			Client.smethod_74(text, ref scenario);
			base.Close();
		}

		// Token: 0x060085C5 RID: 34245 RVA: 0x0047CA1C File Offset: 0x0047AC1C
		private void method_4(object sender, EventArgs e)
		{
			string text = this.vmethod_2().Text;
			Scenario scenario = Client.smethod_46();
			Client.smethod_74(text, ref scenario);
			base.Close();
		}

		// Token: 0x060085C6 RID: 34246 RVA: 0x0047CA48 File Offset: 0x0047AC48
		private void method_5(object object_0)
		{
			this.vmethod_4().Enabled = (Operators.CompareString(this.vmethod_2().Text, "", false) != 0);
			Side[] array = Client.smethod_46().method_44();
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (Operators.CompareString(Strings.LCase(array[i].method_51()), Strings.LCase(this.vmethod_2().Text), false) == 0)
					{
						this.vmethod_4().Enabled = false;
					}
				}
			}
		}

		// Token: 0x060085C7 RID: 34247 RVA: 0x00044820 File Offset: 0x00042A20
		private void AddSide_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060085C8 RID: 34248 RVA: 0x0047CAC4 File Offset: 0x0047ACC4
		private void AddSide_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			Class2413.smethod_2().method_41().Enabled = false;
			this.vmethod_4().Enabled = (Operators.CompareString(this.vmethod_2().Text, "", false) != 0);
			SendKeys.Send("{TAB}");
		}

		// Token: 0x060085C9 RID: 34249 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_6(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060085CA RID: 34250 RVA: 0x0004B8B4 File Offset: 0x00049AB4
		private void AddSide_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x0400490C RID: 18700
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x0400490D RID: 18701
		[AccessedThroughProperty("TextBox1")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x0400490E RID: 18702
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x0400490F RID: 18703
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;
	}
}
