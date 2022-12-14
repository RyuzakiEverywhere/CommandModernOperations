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
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns14;
using ns2;
using ns4;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000E46 RID: 3654
	[DesignerGenerated]
	public sealed partial class UnitMessageLog : DarkSecondaryFormBase
	{
		// Token: 0x06006E00 RID: 28160 RVA: 0x003BDDE0 File Offset: 0x003BBFE0
		private void InitializeComponent_1()
		{
			this.vmethod_1(new WebBrowser());
			this.vmethod_3(new Class125());
			this.vmethod_5(new ToolStripLabel());
			this.vmethod_7(new ToolStripTextBox());
			this.vmethod_9(new Control12());
			this.vmethod_11(new TabPage());
			this.vmethod_15(new TabPage());
			this.vmethod_13(new TabPage());
			this.vmethod_17(new TabPage());
			this.vmethod_19(new TabPage());
			this.vmethod_2().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().Location = new Point(0, 55);
			this.vmethod_0().Margin = new Padding(0);
			this.vmethod_0().MinimumSize = new Size(20, 20);
			this.vmethod_0().Name = "WebBrowser1";
			this.vmethod_0().Size = new Size(643, 295);
			this.vmethod_0().TabIndex = 24;
			this.vmethod_2().AutoSize = false;
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_4(),
				this.vmethod_6()
			});
			this.vmethod_2().Location = new Point(0, 0);
			this.vmethod_2().Name = "ToolStrip1";
			this.vmethod_2().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_2().Size = new Size(643, 25);
			this.vmethod_2().TabIndex = 25;
			this.vmethod_2().Text = "ToolStrip1";
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Name = "ToolStripLabel1";
			this.vmethod_4().Size = new Size(36, 22);
			this.vmethod_4().Text = "Filter:";
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Name = "TSTB_Filter";
			this.vmethod_6().Size = new Size(500, 25);
			this.vmethod_8().Controls.Add(this.vmethod_10());
			this.vmethod_8().Controls.Add(this.vmethod_14());
			this.vmethod_8().Controls.Add(this.vmethod_12());
			this.vmethod_8().Controls.Add(this.vmethod_16());
			this.vmethod_8().Controls.Add(this.vmethod_18());
			this.vmethod_8().Cursor = Cursors.Hand;
			this.vmethod_8().Font = new Font("Segoe UI", 8f);
			this.vmethod_8().ItemSize = new Size(80, 20);
			this.vmethod_8().Location = new Point(0, 27);
			this.vmethod_8().Name = "DarkUITabControl1";
			this.vmethod_8().SelectedIndex = 0;
			this.vmethod_8().Size = new Size(1040, 25);
			this.vmethod_8().TabIndex = 26;
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().Location = new Point(4, 24);
			this.vmethod_10().Name = "TabPage1";
			this.vmethod_10().Padding = new Padding(3);
			this.vmethod_10().Size = new Size(1032, 0);
			this.vmethod_10().TabIndex = 0;
			this.vmethod_10().Text = "Sensory & Contacts";
			this.vmethod_14().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_14().Location = new Point(4, 24);
			this.vmethod_14().Name = "TabPage5";
			this.vmethod_14().Size = new Size(1032, 0);
			this.vmethod_14().TabIndex = 4;
			this.vmethod_14().Text = "Weaponry";
			this.vmethod_12().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_12().Location = new Point(4, 24);
			this.vmethod_12().Name = "TabPage2";
			this.vmethod_12().Padding = new Padding(3);
			this.vmethod_12().Size = new Size(1032, 0);
			this.vmethod_12().TabIndex = 1;
			this.vmethod_12().Text = "Crew AI";
			this.vmethod_16().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_16().Location = new Point(4, 24);
			this.vmethod_16().Name = "TabPage3";
			this.vmethod_16().Size = new Size(1032, 0);
			this.vmethod_16().TabIndex = 2;
			this.vmethod_16().Text = "Damage";
			this.vmethod_18().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_18().Location = new Point(4, 24);
			this.vmethod_18().Name = "TabPage4";
			this.vmethod_18().Size = new Size(1032, 0);
			this.vmethod_18().TabIndex = 3;
			this.vmethod_18().Text = "Air/Docking Ops";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(643, 345);
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UnitMessageLog";
			base.ShowIcon = false;
			this.Text = "Unit Message Log";
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			this.vmethod_8().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x00045474 File Offset: 0x00043674
		[CompilerGenerated]
		internal WebBrowser vmethod_0()
		{
			return this.webBrowser_0;
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x0004547C File Offset: 0x0004367C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(WebBrowser webBrowser_1)
		{
			this.webBrowser_0 = webBrowser_1;
		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x00045485 File Offset: 0x00043685
		[CompilerGenerated]
		internal Class125 vmethod_2()
		{
			return this.class125_0;
		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x0004548D File Offset: 0x0004368D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x06006E05 RID: 28165 RVA: 0x00045496 File Offset: 0x00043696
		[CompilerGenerated]
		internal ToolStripLabel vmethod_4()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x06006E06 RID: 28166 RVA: 0x0004549E File Offset: 0x0004369E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripLabel toolStripLabel_1)
		{
			this.toolStripLabel_0 = toolStripLabel_1;
		}

		// Token: 0x06006E07 RID: 28167 RVA: 0x000454A7 File Offset: 0x000436A7
		[CompilerGenerated]
		internal ToolStripTextBox vmethod_6()
		{
			return this.toolStripTextBox_0;
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x003BE47C File Offset: 0x003BC67C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripTextBox toolStripTextBox_1)
		{
			EventHandler value = new EventHandler(this.method_5);
			EventHandler value2 = new EventHandler(this.method_6);
			EventHandler value3 = new EventHandler(this.method_7);
			ToolStripTextBox toolStripTextBox = this.toolStripTextBox_0;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.TextChanged -= value;
				toolStripTextBox.Enter -= value2;
				toolStripTextBox.Leave -= value3;
			}
			this.toolStripTextBox_0 = toolStripTextBox_1;
			toolStripTextBox = this.toolStripTextBox_0;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.TextChanged += value;
				toolStripTextBox.Enter += value2;
				toolStripTextBox.Leave += value3;
			}
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x000454AF File Offset: 0x000436AF
		[CompilerGenerated]
		internal Control12 vmethod_8()
		{
			return this.control12_0;
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x003BE4F8 File Offset: 0x003BC6F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control12 control12_1)
		{
			EventHandler value = new EventHandler(this.method_8);
			Control12 control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged -= value;
			}
			this.control12_0 = control12_1;
			control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x000454B7 File Offset: 0x000436B7
		[CompilerGenerated]
		internal TabPage vmethod_10()
		{
			return this.tabPage_0;
		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x000454BF File Offset: 0x000436BF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TabPage tabPage_5)
		{
			this.tabPage_0 = tabPage_5;
		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x000454C8 File Offset: 0x000436C8
		[CompilerGenerated]
		internal TabPage vmethod_12()
		{
			return this.tabPage_1;
		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x000454D0 File Offset: 0x000436D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(TabPage tabPage_5)
		{
			this.tabPage_1 = tabPage_5;
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x000454D9 File Offset: 0x000436D9
		[CompilerGenerated]
		internal TabPage vmethod_14()
		{
			return this.tabPage_2;
		}

		// Token: 0x06006E10 RID: 28176 RVA: 0x000454E1 File Offset: 0x000436E1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(TabPage tabPage_5)
		{
			this.tabPage_2 = tabPage_5;
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x000454EA File Offset: 0x000436EA
		[CompilerGenerated]
		internal TabPage vmethod_16()
		{
			return this.tabPage_3;
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x000454F2 File Offset: 0x000436F2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(TabPage tabPage_5)
		{
			this.tabPage_3 = tabPage_5;
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x000454FB File Offset: 0x000436FB
		[CompilerGenerated]
		internal TabPage vmethod_18()
		{
			return this.tabPage_4;
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x00045503 File Offset: 0x00043703
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(TabPage tabPage_5)
		{
			this.tabPage_4 = tabPage_5;
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x0004550C File Offset: 0x0004370C
		private void UnitMessageLog_Resize(object sender, EventArgs e)
		{
			this.method_4(false, false);
		}

		// Token: 0x06006E16 RID: 28182 RVA: 0x003BE53C File Offset: 0x003BC73C
		public UnitMessageLog()
		{
			base.Resize += this.UnitMessageLog_Resize;
			base.FormClosing += this.UnitMessageLog_FormClosing;
			base.Load += this.UnitMessageLog_Load;
			base.Resize += this.UnitMessageLog_Resize_1;
			base.Shown += this.UnitMessageLog_Shown;
			base.KeyDown += this.UnitMessageLog_KeyDown;
			this.InitializeComponent_1();
			base.SetStyle(ControlStyles.Selectable, false);
		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x003BE5D0 File Offset: 0x003BC7D0
		private void UnitMessageLog_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing & !Client.bool_6)
			{
				Class570.class280_0.method_7(false);
				Class570.smethod_2(Class2566.dictionary_0, Client.list_1);
			}
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x00044489 File Offset: 0x00042689
		private void UnitMessageLog_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06006E19 RID: 28185 RVA: 0x0004550C File Offset: 0x0004370C
		private void UnitMessageLog_Resize_1(object sender, EventArgs e)
		{
			this.method_4(false, false);
		}

		// Token: 0x06006E1A RID: 28186 RVA: 0x003BE620 File Offset: 0x003BC820
		private void UnitMessageLog_Shown(object sender, EventArgs e)
		{
			Client.bool_1 = true;
			ActiveUnit activeUnit = Client.smethod_46().vmethod_0()[this.string_0];
			if (activeUnit != null)
			{
				this.Text = "Personal message log for: " + activeUnit.Name;
			}
			this.method_4(false, false);
		}

		// Token: 0x06006E1B RID: 28187 RVA: 0x003BE66C File Offset: 0x003BC86C
		private bool method_3(LoggedMessage.MessageType messageType_0)
		{
			switch (messageType_0)
			{
			case LoggedMessage.MessageType.None:
				return false;
			case LoggedMessage.MessageType.NewContact:
			case LoggedMessage.MessageType.ContactChange:
			case LoggedMessage.MessageType.NewWeaponContact:
			case LoggedMessage.MessageType.NewMineContact:
			case LoggedMessage.MessageType.CommsIsolatedMessage:
			case LoggedMessage.MessageType.NewAirContact:
			case LoggedMessage.MessageType.NewSurfaceContact:
			case LoggedMessage.MessageType.NewUnderwaterContact:
			case LoggedMessage.MessageType.NewGroundContact:
				return this.vmethod_8().SelectedIndex == 0;
			case LoggedMessage.MessageType.WeaponEndgame:
			case LoggedMessage.MessageType.WeaponDamage:
			case LoggedMessage.MessageType.PointDefence:
			case LoggedMessage.MessageType.WeaponLogic:
			case LoggedMessage.MessageType.UnguidedWeaponModifiers:
				return this.vmethod_8().SelectedIndex == 1;
			case LoggedMessage.MessageType.AirOps:
			case LoggedMessage.MessageType.DockingOps:
				return this.vmethod_8().SelectedIndex == 4;
			case LoggedMessage.MessageType.UnitLost:
			case LoggedMessage.MessageType.UnitDamage:
				return this.vmethod_8().SelectedIndex == 3;
			case LoggedMessage.MessageType.UI:
				return false;
			case LoggedMessage.MessageType.UnitAI:
				return this.vmethod_8().SelectedIndex == 2;
			case LoggedMessage.MessageType.EventEngine:
				return false;
			case LoggedMessage.MessageType.SpecialMessage:
				return false;
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			return false;
		}

		// Token: 0x06006E1C RID: 28188 RVA: 0x003BE758 File Offset: 0x003BC958
		public void method_4(bool OnlyIfNewMessages, bool TriggeredByMainform = false)
		{
			if (base.Visible)
			{
				StringBuilder stringBuilder;
				string text;
				if (Client.smethod_50() == null)
				{
					stringBuilder = new StringBuilder();
					stringBuilder.Append("<div style='margin:-20 -10 -10 -10; padding:10 5 5 5;font-family:Verdana;height:" + Conversions.ToString(this.vmethod_0().Height) + ";background-color:black;font-size:9pt;'>");
					stringBuilder.Append("</div>");
					text = stringBuilder.ToString();
					Class2558.smethod_11(this.vmethod_0(), text);
					return;
				}
				List<LoggedMessage> list = Enumerable.ToList<LoggedMessage>(Enumerable.ThenByDescending<LoggedMessage, long>(Enumerable.OrderByDescending<LoggedMessage, DateTime>(Enumerable.Where<LoggedMessage>(Client.smethod_50().method_55(Client.smethod_46()), new Func<LoggedMessage, bool>(this.method_9)), (UnitMessageLog._Closure$__.$I55-1 == null) ? (UnitMessageLog._Closure$__.$I55-1 = new Func<LoggedMessage, DateTime>(UnitMessageLog._Closure$__.$I.method_0)) : UnitMessageLog._Closure$__.$I55-1), (UnitMessageLog._Closure$__.$I55-2 == null) ? (UnitMessageLog._Closure$__.$I55-2 = new Func<LoggedMessage, long>(UnitMessageLog._Closure$__.$I.method_1)) : UnitMessageLog._Closure$__.$I55-2));
				if (OnlyIfNewMessages)
				{
					if (list.Count <= 0 || this.long_0 == list[0].long_0)
					{
						return;
					}
					this.long_0 = list[0].long_0;
				}
				if (!string.IsNullOrEmpty(this.vmethod_6().Text))
				{
					list = Enumerable.ToList<LoggedMessage>(Enumerable.Where<LoggedMessage>(list, new Func<LoggedMessage, bool>(this.method_10)));
				}
				stringBuilder = new StringBuilder();
				stringBuilder.Append("<div style='margin:-20 -10 -10 -10; padding:10 5 5 5;font-family:Verdana;height:" + Conversions.ToString(this.vmethod_0().Height) + ";background-color:black;font-size:9pt;'>");
				try
				{
					foreach (LoggedMessage loggedMessage in list)
					{
						string text2 = "";
						if (loggedMessage.side_0 != null)
						{
							text2 = loggedMessage.side_0.string_0;
						}
						string value;
						if (!string.IsNullOrEmpty(text2) && Operators.CompareString(text2, Client.smethod_50().string_0, false) != 0)
						{
							value = string.Concat(new string[]
							{
								loggedMessage.dateTime_0.ToLongTimeString(),
								" - [",
								loggedMessage.side_0.method_51(),
								"] ",
								Class441.smethod_1(loggedMessage.string_2)
							});
						}
						else
						{
							value = loggedMessage.dateTime_0.ToLongTimeString() + " - " + Class441.smethod_1(loggedMessage.string_2);
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
						stringBuilder.Append(value);
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
				text = stringBuilder.ToString();
				Class2558.smethod_11(this.vmethod_0(), text);
				if (!this.bool_3)
				{
					this.vmethod_2().Select();
				}
			}
		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x0004550C File Offset: 0x0004370C
		private void method_5(object sender, EventArgs e)
		{
			this.method_4(false, false);
		}

		// Token: 0x06006E1E RID: 28190 RVA: 0x003BEAC8 File Offset: 0x003BCCC8
		private void UnitMessageLog_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.bool_3)
			{
				if ((e.KeyValue == 13 || e.KeyValue == 27) && base.Visible)
				{
					this.vmethod_2().Select();
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

		// Token: 0x06006E1F RID: 28191 RVA: 0x00045516 File Offset: 0x00043716
		private void method_6(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x06006E20 RID: 28192 RVA: 0x0004551F File Offset: 0x0004371F
		private void method_7(object sender, EventArgs e)
		{
			this.bool_3 = false;
			this.vmethod_2().Select();
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x0004550C File Offset: 0x0004370C
		private void method_8(object sender, EventArgs e)
		{
			this.method_4(false, false);
		}

		// Token: 0x06006E22 RID: 28194 RVA: 0x00045533 File Offset: 0x00043733
		[CompilerGenerated]
		private bool method_9(LoggedMessage loggedMessage_0)
		{
			return Operators.CompareString(loggedMessage_0.string_3, this.string_0, false) == 0 && this.method_3(loggedMessage_0.messageType_0);
		}

		// Token: 0x06006E23 RID: 28195 RVA: 0x00045557 File Offset: 0x00043757
		[CompilerGenerated]
		private bool method_10(LoggedMessage loggedMessage_0)
		{
			return loggedMessage_0.string_2.ToLower().Contains(this.vmethod_6().Text.ToLower());
		}

		// Token: 0x04003E94 RID: 16020
		[CompilerGenerated]
		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser webBrowser_0;

		// Token: 0x04003E95 RID: 16021
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStrip1")]
		private Class125 class125_0;

		// Token: 0x04003E96 RID: 16022
		[AccessedThroughProperty("ToolStripLabel1")]
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x04003E97 RID: 16023
		[CompilerGenerated]
		[AccessedThroughProperty("TSTB_Filter")]
		private ToolStripTextBox toolStripTextBox_0;

		// Token: 0x04003E98 RID: 16024
		[CompilerGenerated]
		[AccessedThroughProperty("DarkUITabControl1")]
		private Control12 control12_0;

		// Token: 0x04003E99 RID: 16025
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage1")]
		private TabPage tabPage_0;

		// Token: 0x04003E9A RID: 16026
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage2")]
		private TabPage tabPage_1;

		// Token: 0x04003E9B RID: 16027
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage5")]
		private TabPage tabPage_2;

		// Token: 0x04003E9C RID: 16028
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage3")]
		private TabPage tabPage_3;

		// Token: 0x04003E9D RID: 16029
		[AccessedThroughProperty("TabPage4")]
		[CompilerGenerated]
		private TabPage tabPage_4;

		// Token: 0x04003E9E RID: 16030
		private long long_0;

		// Token: 0x04003E9F RID: 16031
		private bool bool_3;

		// Token: 0x04003EA0 RID: 16032
		public string string_0;
	}
}
