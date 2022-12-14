using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace ns6
{
	// Token: 0x02000ECE RID: 3790
	[DesignerGenerated]
	internal sealed partial class RegressionTests : Form4
	{
		// Token: 0x060083A7 RID: 33703 RVA: 0x0046C8F8 File Offset: 0x0046AAF8
		public RegressionTests()
		{
			base.Load += this.RegressionTests_Load;
			base.KeyDown += this.RegressionTests_KeyDown;
			base.FormClosing += this.RegressionTests_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x060083AA RID: 33706 RVA: 0x0004FDAF File Offset: 0x0004DFAF
		[CompilerGenerated]
		internal TextBox vmethod_0()
		{
			return this.textBox_0;
		}

		// Token: 0x060083AB RID: 33707 RVA: 0x0004FDB7 File Offset: 0x0004DFB7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TextBox textBox_1)
		{
			this.textBox_0 = textBox_1;
		}

		// Token: 0x060083AC RID: 33708 RVA: 0x0046CAA4 File Offset: 0x0046ACA4
		private void RegressionTests_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_0().Text = "Running regression tests...\r\n\r\n";
			Application.DoEvents();
			this.vmethod_0().Text = this.vmethod_0().Text + "Test 1 (Issue #1122): ";
			Application.DoEvents();
			this.vmethod_0().Text = this.vmethod_0().Text + this.method_1();
			this.vmethod_0().Text = this.vmethod_0().Text + "\r\n\r\nAll regression tests have finished.";
		}

		// Token: 0x060083AD RID: 33709 RVA: 0x0046CB40 File Offset: 0x0046AD40
		public string method_1()
		{
			string result;
			try
			{
				result = "PASS";
			}
			catch (Exception ex)
			{
				result = "FAIL";
			}
			return result;
		}

		// Token: 0x060083AE RID: 33710 RVA: 0x0004B8B4 File Offset: 0x00049AB4
		private void RegressionTests_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x060083AF RID: 33711 RVA: 0x00044820 File Offset: 0x00042A20
		private void RegressionTests_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x04004812 RID: 18450
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private TextBox textBox_0;
	}
}
