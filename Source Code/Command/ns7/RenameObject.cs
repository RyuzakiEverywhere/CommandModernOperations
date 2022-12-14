using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;
using ns5;

namespace ns7
{
	// Token: 0x02000F1A RID: 3866
	[DesignerGenerated]
	internal sealed partial class RenameObject : DarkSecondaryFormBase
	{
		// Token: 0x06008925 RID: 35109 RVA: 0x00495DEC File Offset: 0x00493FEC
		public RenameObject()
		{
			base.FormClosing += this.RenameObject_FormClosing;
			base.Load += this.RenameObject_Load;
			base.KeyDown += this.RenameObject_KeyDown;
			this.InitializeComponent_1();
		}

		// Token: 0x06008927 RID: 35111 RVA: 0x00495E7C File Offset: 0x0049407C
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control8());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Control9());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().Location = new Point(12, 12);
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().Size = new Size(317, 20);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().Location = new Point(12, 44);
			this.vmethod_2().Name = "Button1";
			this.vmethod_2().Size = new Size(75, 23);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "OK";
			this.vmethod_4().Location = new Point(254, 44);
			this.vmethod_4().Name = "Button2";
			this.vmethod_4().Size = new Size(75, 23);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Cancel";
			base.AcceptButton = this.vmethod_2();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.CancelButton = this.vmethod_4();
			base.ClientSize = new Size(341, 77);
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RenameObject";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Rename Object";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008928 RID: 35112 RVA: 0x000525D6 File Offset: 0x000507D6
		[CompilerGenerated]
		internal Control8 vmethod_0()
		{
			return this.control8_0;
		}

		// Token: 0x06008929 RID: 35113 RVA: 0x000525DE File Offset: 0x000507DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control8 control8_1)
		{
			this.control8_0 = control8_1;
		}

		// Token: 0x0600892A RID: 35114 RVA: 0x000525E7 File Offset: 0x000507E7
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x0600892B RID: 35115 RVA: 0x0049607C File Offset: 0x0049427C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_2)
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

		// Token: 0x0600892C RID: 35116 RVA: 0x000525EF File Offset: 0x000507EF
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_1;
		}

		// Token: 0x0600892D RID: 35117 RVA: 0x004960C0 File Offset: 0x004942C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_2)
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

		// Token: 0x0600892E RID: 35118 RVA: 0x00496104 File Offset: 0x00494304
		private void RenameObject_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().Enabled = true;
			Client.bool_1 = true;
			Client.bool_1 = true;
			if (!Information.IsNothing(Class2413.smethod_2().method_7()) && Class2413.smethod_2().method_7().Visible)
			{
				Class2413.smethod_2().method_7().imethod_0();
			}
			Class2413.smethod_2().method_41().BringToFront();
			if (Class2413.smethod_2().method_60().Visible)
			{
				Class2413.smethod_2().method_60().method_7();
			}
		}

		// Token: 0x0600892F RID: 35119 RVA: 0x000525F7 File Offset: 0x000507F7
		private void RenameObject_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			Class2413.smethod_2().method_41().Enabled = false;
			this.vmethod_0().Text = this.string_0;
		}

		// Token: 0x06008930 RID: 35120 RVA: 0x0005262D File Offset: 0x0005082D
		private void method_3(object sender, EventArgs e)
		{
			this.string_0 = this.vmethod_0().Text;
			Class2413.smethod_2().method_41().Enabled = true;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06008931 RID: 35121 RVA: 0x00046EC9 File Offset: 0x000450C9
		private void method_4(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06008932 RID: 35122 RVA: 0x0004B8B4 File Offset: 0x00049AB4
		private void RenameObject_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x04004A8E RID: 19086
		[AccessedThroughProperty("TextBox1")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x04004A8F RID: 19087
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04004A90 RID: 19088
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x04004A91 RID: 19089
		public string string_0;
	}
}
