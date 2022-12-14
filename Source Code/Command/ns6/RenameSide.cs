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
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000EF9 RID: 3833
	[DesignerGenerated]
	internal sealed partial class RenameSide : DarkSecondaryFormBase
	{
		// Token: 0x06008712 RID: 34578 RVA: 0x000514B4 File Offset: 0x0004F6B4
		public RenameSide()
		{
			base.Load += this.RenameSide_Load;
			base.KeyDown += this.RenameSide_KeyDown;
			this.InitializeComponent_1();
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x00487C50 File Offset: 0x00485E50
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
			this.vmethod_0().Size = new Size(61, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "New name:";
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().method_14(null);
			this.vmethod_2().method_15(AutoCompleteMode.None);
			this.vmethod_2().method_13(AutoCompleteSource.None);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().method_17(new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161));
			this.vmethod_2().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_2().method_12(null);
			this.vmethod_2().method_18(null);
			this.vmethod_2().Location = new Point(16, 30);
			this.vmethod_2().method_2(32767);
			this.vmethod_2().method_7(false);
			this.vmethod_2().Name = "TextBox1";
			this.vmethod_2().method_3(false);
			this.vmethod_2().method_9(0);
			this.vmethod_2().Size = new Size(298, 24);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().method_1(HorizontalAlignment.Left);
			this.vmethod_2().method_5(false);
			this.vmethod_2().method_10("");
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_4().Location = new Point(16, 66);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(75, 23);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "OK";
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_6().Location = new Point(239, 66);
			this.vmethod_6().Name = "Button2";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(75, 23);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "Cancel";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(326, 95);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RenameSide";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Rename Side";
			base.ResumeLayout(false);
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x000514E6 File Offset: 0x0004F6E6
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x000514EE File Offset: 0x0004F6EE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x000514F7 File Offset: 0x0004F6F7
		[CompilerGenerated]
		internal Control8 vmethod_2()
		{
			return this.control8_0;
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x00488030 File Offset: 0x00486230
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control8 control8_1)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_4);
			EventHandler value = new EventHandler(this.method_6);
			EventHandler value2 = new EventHandler(this.method_7);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.method_22(delegate85_);
				control.Enter -= value;
				control.Leave -= value2;
			}
			this.control8_0 = control8_1;
			control = this.control8_0;
			if (control != null)
			{
				control.method_21(delegate85_);
				control.Enter += value;
				control.Leave += value2;
			}
		}

		// Token: 0x06008719 RID: 34585 RVA: 0x000514FF File Offset: 0x0004F6FF
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_0;
		}

		// Token: 0x0600871A RID: 34586 RVA: 0x004880AC File Offset: 0x004862AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_2)
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

		// Token: 0x0600871B RID: 34587 RVA: 0x00051507 File Offset: 0x0004F707
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_1;
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x004880F0 File Offset: 0x004862F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_5);
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

		// Token: 0x0600871D RID: 34589 RVA: 0x0005150F File Offset: 0x0004F70F
		private void method_3(object sender, EventArgs e)
		{
			this.side_0.method_52(this.vmethod_2().Text);
			if (Class2413.smethod_2().method_64().Visible)
			{
				Class2413.smethod_2().method_64().imethod_0();
			}
			base.Close();
		}

		// Token: 0x0600871E RID: 34590 RVA: 0x00488134 File Offset: 0x00486334
		private void method_4(object object_0)
		{
			this.vmethod_4().Enabled = (Operators.CompareString(this.vmethod_2().Text, "", false) != 0);
			Side[] array = Client.smethod_46().method_44();
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (string.Compare(array[i].method_51(), this.vmethod_2().Text, false) == 0)
					{
						this.vmethod_4().Enabled = false;
					}
				}
			}
		}

		// Token: 0x0600871F RID: 34591 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_5(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06008720 RID: 34592 RVA: 0x0005154D File Offset: 0x0004F74D
		private void RenameSide_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_2().Text = this.side_0.method_51();
		}

		// Token: 0x06008721 RID: 34593 RVA: 0x004881A8 File Offset: 0x004863A8
		private void RenameSide_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (this.bool_3)
			{
				if (e.KeyValue == 13 && base.Visible)
				{
					this.vmethod_0().Select();
					return;
				}
				if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
				{
					Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
			if (!this.bool_3 && (e.KeyValue != 32 || !base.Visible))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x00051578 File Offset: 0x0004F778
		private void method_6(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x00051581 File Offset: 0x0004F781
		private void method_7(object sender, EventArgs e)
		{
			this.bool_3 = false;
			this.vmethod_0().Select();
		}

		// Token: 0x0400499D RID: 18845
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x0400499E RID: 18846
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private Control8 control8_0;

		// Token: 0x0400499F RID: 18847
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x040049A0 RID: 18848
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x040049A1 RID: 18849
		private bool bool_3;

		// Token: 0x040049A2 RID: 18850
		public Side side_0;
	}
}
