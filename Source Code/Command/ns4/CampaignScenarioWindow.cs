using System;
using System.Collections.Generic;
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
using ns10;
using ns2;
using ns5;
using ns7;
using ns9;

namespace ns4
{
	// Token: 0x02000E74 RID: 3700
	[DesignerGenerated]
	internal sealed partial class CampaignScenarioWindow : DarkSecondaryFormBase
	{
		// Token: 0x06007167 RID: 29031 RVA: 0x00047293 File Offset: 0x00045493
		public CampaignScenarioWindow()
		{
			base.Shown += this.CampaignScenarioWindow_Shown;
			base.Load += this.CampaignScenarioWindow_Load;
			this.vmethod_15(new BackgroundWorker());
			this.InitializeComponent_1();
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x003CFFF8 File Offset: 0x003CE1F8
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			this.vmethod_13(new Timer(this.icontainer_1));
			this.vmethod_9(new Control11());
			this.vmethod_11(new Class116());
			this.vmethod_7(new Control9());
			this.vmethod_5(new Control9());
			this.vmethod_3(new Class116());
			this.vmethod_1(new WebBrowser());
			base.SuspendLayout();
			this.vmethod_12().Interval = 50;
			this.vmethod_8().Anchor = AnchorStyles.Bottom;
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().Font = new Font(Client.font_1.FontFamily, 9f);
			this.vmethod_8().Location = new Point(309, 605);
			this.vmethod_8().method_1(100);
			this.vmethod_8().Name = "PB_PercentComplete";
			this.vmethod_8().method_3(true);
			this.vmethod_8().method_5(false);
			this.vmethod_8().Size = new Size(359, 12);
			this.vmethod_8().TabIndex = 21;
			this.vmethod_8().Value = 0;
			this.vmethod_10().Anchor = AnchorStyles.Bottom;
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Location = new Point(461, 588);
			this.vmethod_10().Name = "Label_Loading";
			this.vmethod_10().Size = new Size(54, 13);
			this.vmethod_10().TabIndex = 22;
			this.vmethod_10().Text = "Loading...";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_6().Font = new Font(Client.font_1.FontFamily, 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.vmethod_6().Location = new Point(735, 588);
			this.vmethod_6().Name = "Button2";
			this.vmethod_6().Padding = new Padding(5);
			this.vmethod_6().Size = new Size(249, 29);
			this.vmethod_6().TabIndex = 20;
			this.vmethod_6().Text = "Cancel (return to Campaigns)";
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_4().Font = new Font(Client.font_1.FontFamily, 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.vmethod_4().Location = new Point(1, 588);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().Padding = new Padding(5);
			this.vmethod_4().Size = new Size(249, 29);
			this.vmethod_4().TabIndex = 19;
			this.vmethod_4().Text = "Start Scenario";
			this.vmethod_2().method_2(true);
			this.vmethod_2().Cursor = Cursors.Arrow;
			this.vmethod_2().Font = new Font("Times New Roman", 36f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(3, 3);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new Size(284, 55);
			this.vmethod_2().TabIndex = 18;
			this.vmethod_2().Text = "Scenario Title";
			this.vmethod_0().AllowNavigation = false;
			this.vmethod_0().AllowWebBrowserDrop = false;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().IsWebBrowserContextMenuEnabled = false;
			this.vmethod_0().Location = new Point(1, 61);
			this.vmethod_0().MinimumSize = new Size(20, 20);
			this.vmethod_0().Name = "WebBrowser1";
			this.vmethod_0().Size = new Size(983, 507);
			this.vmethod_0().TabIndex = 17;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(985, 618);
			base.ControlBox = false;
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CampaignScenarioWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Campaign Scenario";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x000472D0 File Offset: 0x000454D0
		[CompilerGenerated]
		internal WebBrowser vmethod_0()
		{
			return this.webBrowser_0;
		}

		// Token: 0x0600716B RID: 29035 RVA: 0x000472D8 File Offset: 0x000454D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(WebBrowser webBrowser_1)
		{
			this.webBrowser_0 = webBrowser_1;
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x000472E1 File Offset: 0x000454E1
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x0600716D RID: 29037 RVA: 0x000472E9 File Offset: 0x000454E9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_2)
		{
			this.class116_0 = class116_2;
		}

		// Token: 0x0600716E RID: 29038 RVA: 0x000472F2 File Offset: 0x000454F2
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_0;
		}

		// Token: 0x0600716F RID: 29039 RVA: 0x003D0510 File Offset: 0x003CE710
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_8);
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

		// Token: 0x06007170 RID: 29040 RVA: 0x000472FA File Offset: 0x000454FA
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_1;
		}

		// Token: 0x06007171 RID: 29041 RVA: 0x003D0554 File Offset: 0x003CE754
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_7);
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

		// Token: 0x06007172 RID: 29042 RVA: 0x00047302 File Offset: 0x00045502
		[CompilerGenerated]
		internal Control11 vmethod_8()
		{
			return this.control11_0;
		}

		// Token: 0x06007173 RID: 29043 RVA: 0x0004730A File Offset: 0x0004550A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control11 control11_1)
		{
			this.control11_0 = control11_1;
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x00047313 File Offset: 0x00045513
		[CompilerGenerated]
		internal Class116 vmethod_10()
		{
			return this.class116_1;
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x0004731B File Offset: 0x0004551B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class116 class116_2)
		{
			this.class116_1 = class116_2;
		}

		// Token: 0x06007176 RID: 29046 RVA: 0x00047324 File Offset: 0x00045524
		[CompilerGenerated]
		internal Timer vmethod_12()
		{
			return this.timer_0;
		}

		// Token: 0x06007177 RID: 29047 RVA: 0x003D0598 File Offset: 0x003CE798
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_1;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06007178 RID: 29048 RVA: 0x0004732C File Offset: 0x0004552C
		[CompilerGenerated]
		private BackgroundWorker vmethod_14()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x06007179 RID: 29049 RVA: 0x003D05DC File Offset: 0x003CE7DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_15(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler doWorkEventHandler = new DoWorkEventHandler(this.method_3);
			RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(this.method_4);
			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted -= runWorkerCompletedEventHandler;
			}
			this.backgroundWorker_0 = backgroundWorker_1;
			backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted += runWorkerCompletedEventHandler;
			}
		}

		// Token: 0x0600717A RID: 29050 RVA: 0x003D063C File Offset: 0x003CE83C
		private void CampaignScenarioWindow_Shown(object sender, EventArgs e)
		{
			this.scenContainer_0 = ScenContainer.smethod_2(this.string_0);
			this.vmethod_12().Start();
			this.vmethod_4().Enabled = false;
			this.vmethod_10().Visible = true;
			this.vmethod_8().Visible = true;
			string text = Scenario.smethod_23(this.scenContainer_0.method_7(), "ContentTag");
			if (!Class2556.smethod_10(text))
			{
				Class2413.smethod_2().method_30().method_2(new List<Class2556.Enum209>
				{
					Class2556.smethod_12(text)
				});
				Class2413.smethod_2().method_30().Show();
				base.Close();
				return;
			}
			this.vmethod_14().RunWorkerAsync();
			this.vmethod_0().Visible = true;
			if (!this.method_5(this.vmethod_0(), this.scenContainer_0.ScenDescription, Path.GetDirectoryName(this.string_0)))
			{
				Class2558.smethod_11(this.vmethod_0(), this.scenContainer_0.ScenDescription);
			}
			this.vmethod_2().Text = this.scenContainer_0.ScenTitle;
		}

		// Token: 0x0600717B RID: 29051 RVA: 0x003D0744 File Offset: 0x003CE944
		private void method_3(object sender, DoWorkEventArgs e)
		{
			this.scenario_0 = this.scenContainer_0.method_8(ref Client.string_2, ref this.double_0, false);
			if (this.scenario_0.vmethod_2().Count > 0)
			{
				Class258.smethod_1(this.scenario_0, this.string_0);
			}
		}

		// Token: 0x0600717C RID: 29052 RVA: 0x00047334 File Offset: 0x00045534
		private void method_4(object sender, RunWorkerCompletedEventArgs e)
		{
			this.vmethod_10().Visible = false;
			this.vmethod_8().Visible = false;
			this.vmethod_4().Enabled = true;
		}

		// Token: 0x0600717D RID: 29053 RVA: 0x003D0794 File Offset: 0x003CE994
		private bool method_5(WebBrowser webBrowser_1, string string_3, string string_4)
		{
			bool result;
			if (string_3.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_3, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_3, "[/LOADDOC]", CompareMethod.Binary);
				string path = string_3.Substring(num, string_3.Length - num - (string_3.Length - num2 + 1));
				if (File.Exists(Path.Combine(string_4, path)))
				{
					webBrowser_1.Navigate(Path.Combine(string_4, path));
					result = true;
				}
				else
				{
					string text = this.scenContainer_0.CampaignID;
					if (string.IsNullOrEmpty(text))
					{
						text = Scenario.smethod_23(this.scenContainer_0.method_7(), "CampaignID");
					}
					Class264 @class = Class264.smethod_2(GameGeneral.string_4, text);
					if (!Information.IsNothing(@class))
					{
						webBrowser_1.Navigate(Path.Combine(@class.string_4, path));
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

		// Token: 0x0600717E RID: 29054 RVA: 0x0004735A File Offset: 0x0004555A
		private void method_6(object sender, EventArgs e)
		{
			this.vmethod_8().Value = (int)Math.Round(this.double_0 * 100.0);
		}

		// Token: 0x0600717F RID: 29055 RVA: 0x0004737D File Offset: 0x0004557D
		private void method_7(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_10().Show();
			base.Close();
		}

		// Token: 0x06007180 RID: 29056 RVA: 0x003D0874 File Offset: 0x003CEA74
		private void method_8(object sender, EventArgs e)
		{
			this.scenario_0.CampaignSessionID = this.string_1;
			this.scenario_0.CampaignID = this.class264_0.string_0;
			this.scenario_0.CampaignScore = this.int_0;
			this.scenario_0.LuaXmlPassed = this.string_2;
			Client.smethod_47(this.scenario_0, false);
			Client.smethod_103(Client.smethod_46(), this.string_0);
			if (Client.smethod_0().method_1() != Class279.Enum67.const_0)
			{
				Client.smethod_0().method_2(Class279.Enum67.const_0);
			}
			List<string> list = new List<string>();
			Class264.smethod_3(GameGeneral.string_4, list);
			string customFileName;
			try
			{
				foreach (string text in list)
				{
					Class264 @class = Class264.smethod_1(text);
					if (Operators.CompareString(@class.string_0, Client.smethod_46().CampaignID, false) == 0)
					{
						customFileName = Path.Combine(Path.GetDirectoryName(text), Guid.NewGuid().ToString() + ".save");
						break;
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			Client.smethod_75(false, customFileName, true);
			base.Close();
		}

		// Token: 0x06007181 RID: 29057 RVA: 0x00044489 File Offset: 0x00042689
		private void CampaignScenarioWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04003FFD RID: 16381
		[AccessedThroughProperty("WebBrowser1")]
		[CompilerGenerated]
		private WebBrowser webBrowser_0;

		// Token: 0x04003FFE RID: 16382
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04003FFF RID: 16383
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x04004000 RID: 16384
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x04004001 RID: 16385
		[CompilerGenerated]
		[AccessedThroughProperty("PB_PercentComplete")]
		private Control11 control11_0;

		// Token: 0x04004002 RID: 16386
		[AccessedThroughProperty("Label_Loading")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x04004003 RID: 16387
		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private Timer timer_0;

		// Token: 0x04004004 RID: 16388
		public Class264 class264_0;

		// Token: 0x04004005 RID: 16389
		public string string_0;

		// Token: 0x04004006 RID: 16390
		public string string_1;

		// Token: 0x04004007 RID: 16391
		public int int_0;

		// Token: 0x04004008 RID: 16392
		public string string_2;

		// Token: 0x04004009 RID: 16393
		private Scenario scenario_0;

		// Token: 0x0400400A RID: 16394
		[CompilerGenerated]
		[AccessedThroughProperty("theBW")]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x0400400B RID: 16395
		private double double_0;

		// Token: 0x0400400C RID: 16396
		private ScenContainer scenContainer_0;
	}
}
