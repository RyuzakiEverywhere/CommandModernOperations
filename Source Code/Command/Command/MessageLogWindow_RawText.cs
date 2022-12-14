using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns2;
using ns4;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000DFF RID: 3583
	[DesignerGenerated]
	public sealed partial class MessageLogWindow_RawText : DarkSecondaryFormBase
	{
		// Token: 0x06006880 RID: 26752 RVA: 0x0038A1F0 File Offset: 0x003883F0
		public MessageLogWindow_RawText()
		{
			base.FormClosing += this.MessageLogWindow_RawText_FormClosing;
			base.Load += this.MessageLogWindow_RawText_Load;
			base.Resize += this.MessageLogWindow_RawText_Resize;
			base.Shown += this.MessageLogWindow_RawText_Shown;
			base.KeyDown += this.MessageLogWindow_RawText_KeyDown;
			base.ResizeEnd += this.MessageLogWindow_RawText_ResizeEnd;
			this.InitializeComponent_1();
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x0038A2B8 File Offset: 0x003884B8
		private void InitializeComponent_1()
		{
			this.vmethod_1(new WebBrowser());
			this.vmethod_3(new Control8());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Class116());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().Location = new Point(0, 32);
			this.vmethod_0().Margin = new Padding(0);
			this.vmethod_0().MinimumSize = new Size(20, 20);
			this.vmethod_0().Name = "WebBrowser1";
			this.vmethod_0().Size = new Size(1040, 700);
			this.vmethod_0().TabIndex = 24;
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().method_14(null);
			this.vmethod_2().method_15(AutoCompleteMode.None);
			this.vmethod_2().method_13(AutoCompleteSource.None);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_2().method_12(null);
			this.vmethod_2().method_18(null);
			this.vmethod_2().Location = new Point(47, 5);
			this.vmethod_2().method_2(32767);
			this.vmethod_2().method_7(false);
			this.vmethod_2().Name = "TSTB_Filter";
			this.vmethod_2().method_3(false);
			this.vmethod_2().method_19(ScrollBars.None);
			this.vmethod_2().method_9(0);
			this.vmethod_2().Size = new Size(813, 24);
			this.vmethod_2().TabIndex = 26;
			this.vmethod_2().method_1(HorizontalAlignment.Left);
			this.vmethod_2().method_5(false);
			this.vmethod_2().method_10("");
			this.vmethod_4().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(871, 5);
			this.vmethod_4().Name = "DarkUIButton1";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(162, 23);
			this.vmethod_4().TabIndex = 27;
			this.vmethod_4().Text = "Switch to Interactive view";
			this.vmethod_6().method_2(true);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(5, 9);
			this.vmethod_6().Name = "DarkLabel1";
			this.vmethod_6().Size = new Size(36, 15);
			this.vmethod_6().TabIndex = 28;
			this.vmethod_6().Text = "Filter:";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1040, 732);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.Name = "MessageLogWindow";
			base.ShowIcon = false;
			this.Text = "Message Log - Raw text view";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x00042724 File Offset: 0x00040924
		[CompilerGenerated]
		internal WebBrowser vmethod_0()
		{
			return this.webBrowser_0;
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x0004272C File Offset: 0x0004092C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(WebBrowser webBrowser_1)
		{
			this.webBrowser_0 = webBrowser_1;
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x00042735 File Offset: 0x00040935
		[CompilerGenerated]
		internal Control8 vmethod_2()
		{
			return this.control8_0;
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x0038A650 File Offset: 0x00388850
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control8 control8_1)
		{
			EventHandler value = new EventHandler(this.method_4);
			EventHandler value2 = new EventHandler(this.method_5);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.Enter -= value;
				control.Leave -= value2;
			}
			this.control8_0 = control8_1;
			control = this.control8_0;
			if (control != null)
			{
				control.Enter += value;
				control.Leave += value2;
			}
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x0004273D File Offset: 0x0004093D
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_0;
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x0038A6B0 File Offset: 0x003888B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_1;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x00042745 File Offset: 0x00040945
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_0;
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x0004274D File Offset: 0x0004094D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x0038A6F4 File Offset: 0x003888F4
		private void MessageLogWindow_RawText_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().method_128();
			if (e.CloseReason == CloseReason.UserClosing & !Client.bool_6)
			{
				Class570.class280_0.method_7(false);
				Class570.smethod_2(Class2566.dictionary_0, Client.list_1);
			}
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x0000378C File Offset: 0x0000198C
		private void MessageLogWindow_RawText_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x00042756 File Offset: 0x00040956
		private void MessageLogWindow_RawText_Resize(object sender, EventArgs e)
		{
			this.method_3(false);
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x0004275F File Offset: 0x0004095F
		private void MessageLogWindow_RawText_Shown(object sender, EventArgs e)
		{
			Client.bool_1 = true;
			this.method_3(false);
		}

		// Token: 0x0600688F RID: 26767 RVA: 0x0038A754 File Offset: 0x00388954
		public void method_3(bool bool_4)
		{
			StringBuilder stringBuilder;
			string string_;
			if (Information.IsNothing(Client.smethod_50()))
			{
				stringBuilder = new StringBuilder();
				stringBuilder.Append("<div style='margin:-20 -10 -10 -10; padding:10 5 5 5;font-family:Verdana;height:" + Conversions.ToString(this.vmethod_0().Height) + ";background-color:#333333;font-size:9pt;'>");
				stringBuilder.Append("</div>");
				string_ = stringBuilder.ToString();
				Class2558.smethod_11(this.vmethod_0(), string_);
				return;
			}
			List<LoggedMessage> list = Enumerable.ToList<LoggedMessage>(Enumerable.ThenByDescending<LoggedMessage, long>(Enumerable.OrderByDescending<LoggedMessage, DateTime>(Client.smethod_50().method_55(Client.smethod_46()), (MessageLogWindow_RawText._Closure$__.$I27-0 == null) ? (MessageLogWindow_RawText._Closure$__.$I27-0 = new Func<LoggedMessage, DateTime>(MessageLogWindow_RawText._Closure$__.$I.method_0)) : MessageLogWindow_RawText._Closure$__.$I27-0), (MessageLogWindow_RawText._Closure$__.$I27-1 == null) ? (MessageLogWindow_RawText._Closure$__.$I27-1 = new Func<LoggedMessage, long>(MessageLogWindow_RawText._Closure$__.$I.method_1)) : MessageLogWindow_RawText._Closure$__.$I27-1));
			if (bool_4 && list.Count > 0)
			{
				if (this.long_0 == list[0].long_0)
				{
					return;
				}
				this.long_0 = list[0].long_0;
			}
			if (!string.IsNullOrEmpty(this.vmethod_2().Text))
			{
				list = Enumerable.ToList<LoggedMessage>(Enumerable.Where<LoggedMessage>(list, new Func<LoggedMessage, bool>(this.method_7)));
			}
			stringBuilder = new StringBuilder();
			stringBuilder.Append("<div style='margin:-20 -10 -10 -10; padding:10 5 5 5;font-family:Verdana;height:" + Conversions.ToString(this.vmethod_0().Height) + ";background-color:#333333;font-size:9pt;'>");
			try
			{
				foreach (LoggedMessage loggedMessage in list)
				{
					string text = "";
					if (loggedMessage.side_0 != null)
					{
						text = loggedMessage.side_0.string_0;
					}
					Color color = loggedMessage.method_8();
					if (loggedMessage.method_9(this.Font).Style == FontStyle.Italic)
					{
						stringBuilder.Append("<i>");
					}
					stringBuilder.Append(string.Concat(new string[]
					{
						"<div style='color:#",
						color.R.ToString("X2"),
						color.G.ToString("X2"),
						color.B.ToString("X2"),
						"'>"
					}));
					stringBuilder.Append(loggedMessage.dateTime_0.ToLongTimeString());
					if (!string.IsNullOrEmpty(text) && Operators.CompareString(text, Client.smethod_50().string_0, false) != 0)
					{
						stringBuilder.Append(" - [").Append(loggedMessage.side_0.method_51()).Append("] ").Append(loggedMessage.string_2);
					}
					else
					{
						stringBuilder.Append(" - ").Append(loggedMessage.string_2);
					}
					stringBuilder.Append("</div>");
					if (loggedMessage.method_9(this.Font).Style == FontStyle.Italic)
					{
						stringBuilder.Append("</i>");
					}
					stringBuilder.Append("<br/>");
				}
			}
			finally
			{
				List<LoggedMessage>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			stringBuilder.Append("</div>");
			string_ = stringBuilder.ToString();
			Class2558.smethod_11(this.vmethod_0(), string_);
			if (!this.bool_3)
			{
				base.Select();
			}
		}

		// Token: 0x06006890 RID: 26768 RVA: 0x0038AA90 File Offset: 0x00388C90
		private void MessageLogWindow_RawText_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.bool_3)
			{
				if ((e.KeyValue == 13 || e.KeyValue == 27) && base.Visible)
				{
					base.Select();
				}
				if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
				{
					Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
			if (!this.bool_3)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06006891 RID: 26769 RVA: 0x0004276E File Offset: 0x0004096E
		private void method_4(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x06006892 RID: 26770 RVA: 0x00042777 File Offset: 0x00040977
		private void method_5(object sender, EventArgs e)
		{
			this.bool_3 = false;
			base.Select();
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x00042786 File Offset: 0x00040986
		private void method_6(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_41().method_126(base.Left, base.Top, base.Width, base.Height);
			base.Hide();
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x0000378C File Offset: 0x0000198C
		private void MessageLogWindow_RawText_ResizeEnd(object sender, EventArgs e)
		{
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x000427B5 File Offset: 0x000409B5
		[CompilerGenerated]
		private bool method_7(LoggedMessage loggedMessage_0)
		{
			return loggedMessage_0.string_2.ToLower().Contains(this.vmethod_2().Text.ToLower());
		}

		// Token: 0x04003B68 RID: 15208
		[CompilerGenerated]
		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser webBrowser_0;

		// Token: 0x04003B69 RID: 15209
		[CompilerGenerated]
		[AccessedThroughProperty("TSTB_Filter")]
		private Control8 control8_0;

		// Token: 0x04003B6A RID: 15210
		[CompilerGenerated]
		[AccessedThroughProperty("DarkUIButton1")]
		private Control9 control9_0;

		// Token: 0x04003B6B RID: 15211
		[CompilerGenerated]
		[AccessedThroughProperty("DarkLabel1")]
		private Class116 class116_0;

		// Token: 0x04003B6C RID: 15212
		private long long_0;

		// Token: 0x04003B6D RID: 15213
		private bool bool_3;
	}
}
