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
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;
using ns9;

namespace ns6
{
	// Token: 0x02000EE2 RID: 3810
	[DesignerGenerated]
	internal sealed partial class ScenarioTitle : DarkSecondaryFormBase
	{
		// Token: 0x0600855D RID: 34141 RVA: 0x00479740 File Offset: 0x00477940
		public ScenarioTitle()
		{
			base.FormClosing += this.ScenarioTitle_FormClosing;
			base.Load += this.ScenarioTitle_Load;
			base.KeyDown += this.ScenarioTitle_KeyDown;
			base.Shown += this.ScenarioTitle_Shown;
			base.ResizeEnd += this.ScenarioTitle_ResizeEnd;
			this.InitializeComponent_1();
		}

		// Token: 0x0600855F RID: 34143 RVA: 0x004797B4 File Offset: 0x004779B4
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class116());
			this.vmethod_3(new Control8());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Control9());
			this.vmethod_9(new Control9());
			this.vmethod_11(new HtmlEditorControl());
			this.vmethod_13(new Control9());
			base.SuspendLayout();
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(9, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(30, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Title:";
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().method_14(null);
			this.vmethod_2().method_15(AutoCompleteMode.None);
			this.vmethod_2().method_13(AutoCompleteSource.None);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().method_17(new Font("Segoe UI", 10f));
			this.vmethod_2().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_2().method_12(null);
			this.vmethod_2().method_18(null);
			this.vmethod_2().Location = new Point(49, 10);
			this.vmethod_2().method_2(32767);
			this.vmethod_2().method_7(false);
			this.vmethod_2().Name = "TextBox1";
			this.vmethod_2().method_3(false);
			this.vmethod_2().method_19(ScrollBars.None);
			this.vmethod_2().method_9(0);
			this.vmethod_2().Size = new Size(601, 20);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().method_1(HorizontalAlignment.Left);
			this.vmethod_2().method_5(false);
			this.vmethod_2().method_10("");
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(9, 49);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new Size(78, 22);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Description:";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font("Segoe UI", 10f);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(12, 458);
			this.vmethod_6().Name = "Button1";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(75, 23);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().Text = "OK";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DialogResult = DialogResult.None;
			this.vmethod_8().Font = new Font("Segoe UI", 10f);
			this.vmethod_8().ForeColor = SystemColors.Control;
			this.vmethod_8().Location = new Point(575, 458);
			this.vmethod_8().Name = "Button2";
			this.vmethod_8().method_1(0);
			this.vmethod_8().Size = new Size(75, 23);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_8().Text = "Cancel";
			this.vmethod_10().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_10().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_10().BodyBackColor = Color.FromArgb(43, 43, 43);
			this.vmethod_10().BodyForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().InnerText = null;
			this.vmethod_10().Location = new Point(12, 65);
			this.vmethod_10().Name = "Editor1";
			this.vmethod_10().Size = new Size(638, 387);
			this.vmethod_10().TabIndex = 27;
			this.vmethod_12().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font("Segoe UI", 10f);
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(575, 39);
			this.vmethod_12().Name = "Button3";
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(75, 23);
			this.vmethod_12().TabIndex = 28;
			this.vmethod_12().Text = "Edit HTML";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(662, 485);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ScenarioTitle";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Create a new scenario";
			base.ResumeLayout(false);
		}

		// Token: 0x06008560 RID: 34144 RVA: 0x000509B4 File Offset: 0x0004EBB4
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x06008561 RID: 34145 RVA: 0x000509BC File Offset: 0x0004EBBC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_2)
		{
			this.class116_0 = class116_2;
		}

		// Token: 0x06008562 RID: 34146 RVA: 0x000509C5 File Offset: 0x0004EBC5
		[CompilerGenerated]
		internal Control8 vmethod_2()
		{
			return this.control8_0;
		}

		// Token: 0x06008563 RID: 34147 RVA: 0x00479E0C File Offset: 0x0047800C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control8 control8_1)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_3);
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

		// Token: 0x06008564 RID: 34148 RVA: 0x000509CD File Offset: 0x0004EBCD
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x06008565 RID: 34149 RVA: 0x000509D5 File Offset: 0x0004EBD5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_2)
		{
			this.class116_1 = class116_2;
		}

		// Token: 0x06008566 RID: 34150 RVA: 0x000509DE File Offset: 0x0004EBDE
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_0;
		}

		// Token: 0x06008567 RID: 34151 RVA: 0x00479E50 File Offset: 0x00478050
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_4);
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

		// Token: 0x06008568 RID: 34152 RVA: 0x000509E6 File Offset: 0x0004EBE6
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_1;
		}

		// Token: 0x06008569 RID: 34153 RVA: 0x00479E94 File Offset: 0x00478094
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x0600856A RID: 34154 RVA: 0x000509EE File Offset: 0x0004EBEE
		[CompilerGenerated]
		private HtmlEditorControl vmethod_10()
		{
			return this.htmlEditorControl_0;
		}

		// Token: 0x0600856B RID: 34155 RVA: 0x000509F6 File Offset: 0x0004EBF6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_11(HtmlEditorControl htmlEditorControl_1)
		{
			this.htmlEditorControl_0 = htmlEditorControl_1;
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x000509FF File Offset: 0x0004EBFF
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_2;
		}

		// Token: 0x0600856D RID: 34157 RVA: 0x00479ED8 File Offset: 0x004780D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_7);
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

		// Token: 0x0600856E RID: 34158 RVA: 0x00050A07 File Offset: 0x0004EC07
		private void method_3(object object_0)
		{
			if (Client.smethod_61() == Client.Enum197.const_3)
			{
				this.vmethod_6().Enabled = (Operators.CompareString(this.vmethod_2().Text, "", false) != 0);
			}
		}

		// Token: 0x0600856F RID: 34159 RVA: 0x00479F1C File Offset: 0x0047811C
		private void method_4(object sender, EventArgs e)
		{
			string text = Class2558.smethod_0(this.vmethod_2().Text);
			if (Operators.CompareString(text, "", false) == 0)
			{
				DarkMessageBox.smethod_2("Please use valid filename characters for the scenario name", "", Enum11.const_0);
				return;
			}
			Client.Enum197 @enum = Client.smethod_61();
			if (@enum == Client.Enum197.const_4)
			{
				Client.smethod_46().method_1(this.vmethod_2().Text);
				Client.smethod_46().method_5(this.vmethod_10().BodyHtml);
				Class2413.smethod_2().method_41().Enabled = true;
				base.Close();
				return;
			}
			if (@enum == Client.Enum197.const_5)
			{
				Client.smethod_46().method_1(this.vmethod_2().Text);
				Client.smethod_46().FileName = text;
				Client.smethod_46().method_5(this.vmethod_10().BodyHtml);
				Class2413.smethod_2().method_41().vmethod_28().FileName = text;
				Class2413.smethod_2().method_41().vmethod_28().AddExtension = true;
				if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
				{
					Class2413.smethod_2().method_41().vmethod_28().Filter = "Command scenario file (*.scen)|*.scen|Command saved game (*.save)|*.save|All Files (*.*)|*.*";
				}
				else
				{
					Class2413.smethod_2().method_41().vmethod_28().Filter = "Command saved game (*.save)|*.save|Command scenario file (*.scen)|*.scen|All Files (*.*)|*.*";
				}
				if (string.IsNullOrEmpty(Class2413.smethod_2().method_41().vmethod_28().InitialDirectory))
				{
					Class2413.smethod_2().method_41().vmethod_28().InitialDirectory = GameGeneral.string_4;
				}
				else if (!Path.GetFullPath(Class2413.smethod_2().method_41().vmethod_28().InitialDirectory).StartsWith(GameGeneral.string_4))
				{
					Class2413.smethod_2().method_41().vmethod_28().InitialDirectory = GameGeneral.string_4;
				}
				if (Class2413.smethod_2().method_41().vmethod_28().ShowDialog() == DialogResult.OK)
				{
					Client.smethod_75(true, "", false);
					Client.smethod_102(Class2413.smethod_2().method_41().vmethod_28().FileName);
					Class2413.smethod_2().method_41().Enabled = true;
					base.Close();
				}
				else
				{
					DarkMessageBox.smethod_2(Class2413.smethod_2().method_41().vmethod_28().ShowDialog().ToString(), "", Enum11.const_0);
				}
				Client.string_3 = Class2413.smethod_2().method_41().vmethod_28().FileName;
				return;
			}
			if (@enum != Client.Enum197.const_22)
			{
				return;
			}
			Client.smethod_46().method_1(this.vmethod_2().Text);
			Client.smethod_46().FileName = text;
			Client.smethod_46().method_5(this.vmethod_10().BodyHtml);
			Class2413.smethod_2().method_41().vmethod_28().FileName = text;
			Class2413.smethod_2().method_41().vmethod_28().AddExtension = true;
			Class2413.smethod_2().method_41().vmethod_28().Filter = "Packaged scenario file (*.zip)|*.zip";
			if (string.IsNullOrEmpty(Class2413.smethod_2().method_41().vmethod_28().InitialDirectory))
			{
				Class2413.smethod_2().method_41().vmethod_28().InitialDirectory = GameGeneral.string_4;
			}
			else if (!Path.GetFullPath(Class2413.smethod_2().method_41().vmethod_28().InitialDirectory).StartsWith(GameGeneral.string_4))
			{
				Class2413.smethod_2().method_41().vmethod_28().InitialDirectory = GameGeneral.string_4;
			}
			if (Class2413.smethod_2().method_41().vmethod_28().ShowDialog() == DialogResult.OK)
			{
				Class258.smethod_0(Client.smethod_46(), Client.smethod_50(), Class2413.smethod_2().method_41().vmethod_28().FileName);
				Class2413.smethod_2().method_41().Enabled = true;
				base.Close();
			}
			else
			{
				DarkMessageBox.smethod_2(Class2413.smethod_2().method_41().vmethod_28().ShowDialog().ToString(), "", Enum11.const_0);
			}
			Client.string_3 = Class2413.smethod_2().method_41().vmethod_28().FileName;
		}

		// Token: 0x06008570 RID: 34160 RVA: 0x00050A35 File Offset: 0x0004EC35
		private void ScenarioTitle_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.bool_3)
			{
				Client.smethod_0().method_3();
			}
			Class2413.smethod_2().method_41().Enabled = true;
			Client.smethod_62(Client.Enum197.const_0);
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x0047A2EC File Offset: 0x004784EC
		private void ScenarioTitle_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.bool_3 = (Client.smethod_0().method_0() == Class279.Enum68.const_1);
			if (this.bool_3)
			{
				Client.smethod_0().method_4();
			}
			switch (Client.smethod_61())
			{
			case Client.Enum197.const_3:
				this.Text = "Create new scenario";
				this.vmethod_6().Enabled = (Operators.CompareString(this.vmethod_2().Text, "", false) != 0);
				this.vmethod_2().Enabled = true;
				this.vmethod_6().Visible = true;
				this.vmethod_8().Visible = true;
				return;
			case Client.Enum197.const_4:
				if (!Information.IsNothing(Client.smethod_46().method_0()))
				{
					this.vmethod_2().Text = Client.smethod_46().method_0().ToString();
				}
				if (!Information.IsNothing(Client.smethod_46().method_4()))
				{
					this.vmethod_10().BodyHtml = Client.smethod_46().method_4().ToString();
				}
				this.vmethod_2().Enabled = true;
				this.vmethod_6().Visible = true;
				this.vmethod_8().Visible = true;
				return;
			case Client.Enum197.const_5:
				this.Text = "Save scenario";
				if (!Information.IsNothing(Client.smethod_46().method_0()))
				{
					this.vmethod_2().Text = Client.smethod_46().method_0().ToString();
				}
				if (!Information.IsNothing(Client.smethod_46().method_4()))
				{
					this.vmethod_10().BodyHtml = Client.smethod_46().method_4().ToString();
				}
				this.vmethod_2().Enabled = true;
				this.vmethod_6().Visible = true;
				this.vmethod_8().Visible = true;
				return;
			default:
				if (!Information.IsNothing(Client.smethod_46().method_0()))
				{
					this.vmethod_2().Text = Client.smethod_46().method_0().ToString();
				}
				if (!Information.IsNothing(Client.smethod_46().method_4()))
				{
					if (!string.IsNullOrEmpty(Client.string_0))
					{
						if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
						{
							if (!this.method_5(this.vmethod_10(), Client.smethod_46().method_4().ToString(), Path.GetDirectoryName(Client.string_0)))
							{
								this.vmethod_10().BodyHtml = Client.smethod_46().method_4().ToString();
							}
						}
						else
						{
							this.vmethod_10().BodyHtml = Client.smethod_46().method_4().ToString();
						}
					}
					else
					{
						this.vmethod_10().BodyHtml = Client.smethod_46().method_4().ToString();
					}
				}
				this.Text = "Scenario Description";
				this.vmethod_2().Enabled = false;
				this.vmethod_6().Visible = false;
				this.vmethod_8().Visible = false;
				return;
			}
		}

		// Token: 0x06008572 RID: 34162 RVA: 0x0047A5A0 File Offset: 0x004787A0
		private bool method_5(HtmlEditorControl htmlEditorControl_1, string string_0, string string_1)
		{
			bool result;
			if (string_0.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_0, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_0, "[/LOADDOC]", CompareMethod.Binary);
				string path = string_0.Substring(num, string_0.Length - num - (string_0.Length - num2 + 1));
				if (File.Exists(Path.Combine(string_1, path)))
				{
					htmlEditorControl_1.NavigateToUrl(Path.Combine(string_1, path));
					result = true;
				}
				else
				{
					string campaignID = Client.smethod_46().CampaignID;
					Class264 @class = Class264.smethod_2(GameGeneral.string_4, campaignID);
					if (!Information.IsNothing(@class))
					{
						htmlEditorControl_1.NavigateToUrl(Path.Combine(@class.string_4, path));
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06008573 RID: 34163 RVA: 0x00050763 File Offset: 0x0004E963
		private void method_6(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_41().Enabled = true;
			base.Close();
		}

		// Token: 0x06008574 RID: 34164 RVA: 0x0005027C File Offset: 0x0004E47C
		private void ScenarioTitle_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				Class2413.smethod_2().method_41().Enabled = true;
				base.Close();
			}
		}

		// Token: 0x06008575 RID: 34165 RVA: 0x00050A6E File Offset: 0x0004EC6E
		private void ScenarioTitle_Shown(object sender, EventArgs e)
		{
			if (base.Height != 510)
			{
				base.Width--;
				base.Width++;
			}
		}

		// Token: 0x06008576 RID: 34166 RVA: 0x00050A99 File Offset: 0x0004EC99
		private void ScenarioTitle_ResizeEnd(object sender, EventArgs e)
		{
			base.Width--;
			base.Width++;
		}

		// Token: 0x06008577 RID: 34167 RVA: 0x00050AB7 File Offset: 0x0004ECB7
		private void method_7(object sender, EventArgs e)
		{
			this.vmethod_10().HtmlContentsEdit();
		}

		// Token: 0x040048E7 RID: 18663
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x040048E8 RID: 18664
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private Control8 control8_0;

		// Token: 0x040048E9 RID: 18665
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_1;

		// Token: 0x040048EA RID: 18666
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x040048EB RID: 18667
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x040048EC RID: 18668
		[AccessedThroughProperty("Editor1")]
		[CompilerGenerated]
		private HtmlEditorControl htmlEditorControl_0;

		// Token: 0x040048ED RID: 18669
		[AccessedThroughProperty("Button3")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x040048EE RID: 18670
		private bool bool_3;
	}
}
