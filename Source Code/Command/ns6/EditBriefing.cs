using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MSDN.Html.Editor;
using ns10;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000EE5 RID: 3813
	[DesignerGenerated]
	internal sealed partial class EditBriefing : DarkSecondaryFormBase
	{
		// Token: 0x060085CB RID: 34251 RVA: 0x0047CB24 File Offset: 0x0047AD24
		public EditBriefing()
		{
			base.Load += this.EditBriefing_Load;
			base.Shown += this.EditBriefing_Shown;
			base.ResizeEnd += this.EditBriefing_ResizeEnd;
			base.FormClosing += this.EditBriefing_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x060085CD RID: 34253 RVA: 0x0047CBC8 File Offset: 0x0047ADC8
		private void InitializeComponent_1()
		{
			this.vmethod_1(new SplitContainer());
			this.vmethod_7(new HtmlEditorControl());
			this.vmethod_9(new Control9());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Control9());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_0().Panel1.SuspendLayout();
			this.vmethod_0().Panel2.SuspendLayout();
			this.vmethod_0().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Dock = DockStyle.Fill;
			this.vmethod_0().FixedPanel = FixedPanel.Panel2;
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "SplitContainer1";
			this.vmethod_0().Orientation = Orientation.Horizontal;
			this.vmethod_0().Panel1.Controls.Add(this.vmethod_6());
			this.vmethod_0().Panel2.Controls.Add(this.vmethod_8());
			this.vmethod_0().Panel2.Controls.Add(this.vmethod_2());
			this.vmethod_0().Panel2.Controls.Add(this.vmethod_4());
			this.vmethod_0().Size = new Size(709, 516);
			this.vmethod_0().SplitterDistance = 476;
			this.vmethod_0().TabIndex = 0;
			this.vmethod_6().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_6().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_6().BodyBackColor = Color.FromArgb(43, 43, 43);
			this.vmethod_6().BodyForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().InnerText = null;
			this.vmethod_6().Location = new Point(0, 0);
			this.vmethod_6().Name = "Editor1";
			this.vmethod_6().Size = new Size(709, 476);
			this.vmethod_6().TabIndex = 28;
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_8().Location = new Point(278, 7);
			this.vmethod_8().Name = "Button_EditHTML";
			this.vmethod_8().Size = new Size(144, 23);
			this.vmethod_8().TabIndex = 2;
			this.vmethod_8().Text = "Edit HTML";
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_2().Location = new Point(629, 7);
			this.vmethod_2().Name = "Button2";
			this.vmethod_2().Size = new Size(75, 23);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Cancel";
			this.vmethod_4().Location = new Point(9, 7);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().Size = new Size(75, 23);
			this.vmethod_4().TabIndex = 0;
			this.vmethod_4().Text = "OK";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.CancelButton = this.vmethod_2();
			base.ClientSize = new Size(709, 516);
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditBriefing";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Briefing";
			this.vmethod_0().Panel1.ResumeLayout(false);
			this.vmethod_0().Panel2.ResumeLayout(false);
			((ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_0().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x060085CE RID: 34254 RVA: 0x00050CF0 File Offset: 0x0004EEF0
		[CompilerGenerated]
		internal SplitContainer vmethod_0()
		{
			return this.splitContainer_0;
		}

		// Token: 0x060085CF RID: 34255 RVA: 0x00050CF8 File Offset: 0x0004EEF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(SplitContainer splitContainer_1)
		{
			this.splitContainer_0 = splitContainer_1;
		}

		// Token: 0x060085D0 RID: 34256 RVA: 0x00050D01 File Offset: 0x0004EF01
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x060085D1 RID: 34257 RVA: 0x0047CFF0 File Offset: 0x0047B1F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_3;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060085D2 RID: 34258 RVA: 0x00050D09 File Offset: 0x0004EF09
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_1;
		}

		// Token: 0x060085D3 RID: 34259 RVA: 0x0047D034 File Offset: 0x0047B234
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_3;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060085D4 RID: 34260 RVA: 0x00050D11 File Offset: 0x0004EF11
		[CompilerGenerated]
		private HtmlEditorControl vmethod_6()
		{
			return this.htmlEditorControl_0;
		}

		// Token: 0x060085D5 RID: 34261 RVA: 0x00050D19 File Offset: 0x0004EF19
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_7(HtmlEditorControl htmlEditorControl_1)
		{
			this.htmlEditorControl_0 = htmlEditorControl_1;
		}

		// Token: 0x060085D6 RID: 34262 RVA: 0x00050D22 File Offset: 0x0004EF22
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_2;
		}

		// Token: 0x060085D7 RID: 34263 RVA: 0x0047D078 File Offset: 0x0047B278
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_5);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_3;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060085D8 RID: 34264 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060085D9 RID: 34265 RVA: 0x0047D0BC File Offset: 0x0047B2BC
		private void EditBriefing_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
			{
				this.Text = "Edit Briefing for side: " + this.side_0.method_51();
				this.vmethod_2().Visible = true;
				this.vmethod_8().Visible = true;
			}
			else
			{
				this.Text = "Side Briefing";
				this.vmethod_2().Visible = false;
				this.vmethod_8().Visible = false;
			}
			if (!string.IsNullOrEmpty(this.side_0.string_3))
			{
				if (!string.IsNullOrEmpty(Client.string_0))
				{
					if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
					{
						this.vmethod_6().BodyHtml = this.side_0.string_3.ToString();
					}
					else if (!this.method_6(this.vmethod_6(), this.side_0.string_3.ToString(), Path.GetDirectoryName(Client.string_0)))
					{
						this.vmethod_6().BodyHtml = this.side_0.string_3.ToString();
					}
				}
				else
				{
					this.vmethod_6().BodyHtml = this.side_0.string_3.ToString();
				}
			}
			this.vmethod_6().ToolbarVisible = true;
		}

		// Token: 0x060085DA RID: 34266 RVA: 0x00050D2A File Offset: 0x0004EF2A
		private void method_4(object sender, EventArgs e)
		{
			if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
			{
				this.side_0.string_3 = this.vmethod_6().BodyHtml;
			}
			base.Close();
		}

		// Token: 0x060085DB RID: 34267 RVA: 0x00050A6E File Offset: 0x0004EC6E
		private void EditBriefing_Shown(object sender, EventArgs e)
		{
			if (base.Height != 510)
			{
				base.Width--;
				base.Width++;
			}
		}

		// Token: 0x060085DC RID: 34268 RVA: 0x00050A99 File Offset: 0x0004EC99
		private void EditBriefing_ResizeEnd(object sender, EventArgs e)
		{
			base.Width--;
			base.Width++;
		}

		// Token: 0x060085DD RID: 34269 RVA: 0x00044820 File Offset: 0x00042A20
		private void EditBriefing_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060085DE RID: 34270 RVA: 0x00050D55 File Offset: 0x0004EF55
		private void method_5(object sender, EventArgs e)
		{
			this.vmethod_6().HtmlContentsEdit();
		}

		// Token: 0x060085DF RID: 34271 RVA: 0x0047D1F8 File Offset: 0x0047B3F8
		private bool method_6(HtmlEditorControl htmlEditorControl_1, string string_0, string string_1)
		{
			bool result;
			if (string_0.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_0, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_0, "[/LOADDOC]", CompareMethod.Binary);
				string path = string_0.Substring(num, string_0.Length - num - (string_0.Length - num2 + 1));
				htmlEditorControl_1.NavigateToUrl(Path.Combine(string_1, path));
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04004911 RID: 18705
		[AccessedThroughProperty("SplitContainer1")]
		[CompilerGenerated]
		private SplitContainer splitContainer_0;

		// Token: 0x04004912 RID: 18706
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04004913 RID: 18707
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_1;

		// Token: 0x04004914 RID: 18708
		[AccessedThroughProperty("Editor1")]
		[CompilerGenerated]
		private HtmlEditorControl htmlEditorControl_0;

		// Token: 0x04004915 RID: 18709
		[AccessedThroughProperty("Button_EditHTML")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x04004916 RID: 18710
		public Side side_0;
	}
}
