using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns4;
using ns5;
using ns7;

namespace ns6
{
	// Token: 0x02000ED2 RID: 3794
	[DesignerGenerated]
	internal sealed partial class ResumeFromSave : DarkSecondaryFormBase
	{
		// Token: 0x06008408 RID: 33800 RVA: 0x00050015 File Offset: 0x0004E215
		public ResumeFromSave()
		{
			base.Shown += this.ResumeFromSave_Shown;
			base.FormClosing += this.ResumeFromSave_FormClosing;
			this.vmethod_3(new BackgroundWorker());
			this.InitializeComponent_1();
		}

		// Token: 0x0600840A RID: 33802 RVA: 0x0046EE4C File Offset: 0x0046D04C
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control11());
			base.SuspendLayout();
			this.vmethod_0().BackColor = Color.Transparent;
			this.vmethod_0().Dock = DockStyle.Fill;
			this.vmethod_0().Font = new Font("Segoe UI", 9f);
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().method_1(100);
			this.vmethod_0().Name = "PB_PercentComplete";
			this.vmethod_0().method_3(true);
			this.vmethod_0().method_5(false);
			this.vmethod_0().Size = new Size(298, 65);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Value = 0;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(298, 65);
			base.ControlBox = false;
			base.Controls.Add(this.vmethod_0());
			this.DoubleBuffered = true;
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ResumeFromSave";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Loading....";
			base.ResumeLayout(false);
		}

		// Token: 0x0600840B RID: 33803 RVA: 0x00050052 File Offset: 0x0004E252
		[CompilerGenerated]
		internal Control11 vmethod_0()
		{
			return this.control11_0;
		}

		// Token: 0x0600840C RID: 33804 RVA: 0x0005005A File Offset: 0x0004E25A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control11 control11_1)
		{
			this.control11_0 = control11_1;
		}

		// Token: 0x0600840D RID: 33805 RVA: 0x00050063 File Offset: 0x0004E263
		[CompilerGenerated]
		private BackgroundWorker vmethod_2()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x0600840E RID: 33806 RVA: 0x0046EF98 File Offset: 0x0046D198
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_3(BackgroundWorker backgroundWorker_1)
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

		// Token: 0x0600840F RID: 33807 RVA: 0x0046EFF8 File Offset: 0x0046D1F8
		private void ResumeFromSave_Shown(object sender, EventArgs e)
		{
			MainForm.bool_2 = true;
			if (!string.IsNullOrEmpty(this.string_1))
			{
				this.string_2 = this.string_1;
				this.string_1 = null;
			}
			else
			{
				this.string_2 = null;
			}
			try
			{
				this.scenContainer_0 = ScenContainer.smethod_2(this.string_0);
				string text = this.scenContainer_0.method_7();
				this.string_3 = Scenario.smethod_23(text, "ContentTag");
				if (string.IsNullOrEmpty(this.string_3))
				{
					this.string_3 = "";
				}
				if (!Class2556.smethod_10(this.string_3))
				{
					Class2413.smethod_2().method_30().method_2(new List<Class2556.Enum209>
					{
						Class2556.smethod_12(this.string_3)
					});
					Class2413.smethod_2().method_30().Show();
					base.Close();
					return;
				}
				this.bool_3 = false;
				this.scenario_0 = null;
				this.vmethod_2().RunWorkerAsync();
				this.vmethod_0().Visible = true;
				while (!this.bool_3)
				{
					Application.DoEvents();
					this.vmethod_0().Value = (int)Math.Round(this.double_0 * 100.0);
					Thread.Sleep(50);
				}
			}
			catch (Exception ex)
			{
				MainForm.bool_2 = false;
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				DarkMessageBox.smethod_2("An error has occured: " + ex.Message, "Error during load", Enum11.const_0);
			}
			MainForm.bool_2 = false;
		}

		// Token: 0x06008410 RID: 33808 RVA: 0x0046F178 File Offset: 0x0046D378
		private void method_3(object sender, DoWorkEventArgs e)
		{
			try
			{
				Scenario scenario = this.scenContainer_0.method_8(ref Client.string_2, ref this.double_0, false);
				this.scenario_0 = scenario;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200106", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				DarkMessageBox.smethod_2("An error has occured: " + ex.Message, "Error during load", Enum11.const_0);
			}
		}

		// Token: 0x06008411 RID: 33809 RVA: 0x0046F20C File Offset: 0x0046D40C
		private void method_4(object sender, RunWorkerCompletedEventArgs e)
		{
			try
			{
				if (!Information.IsNothing(this.scenario_0))
				{
					if (!string.IsNullOrEmpty(this.string_2))
					{
						this.scenario_0.CampaignSessionID = this.string_2;
						this.string_2 = null;
					}
					Client.smethod_103(this.scenario_0, this.string_0);
					this.bool_3 = true;
					base.Close();
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				DarkMessageBox.smethod_2("An error has occured: " + ex.Message, "Error during load", Enum11.const_0);
			}
		}

		// Token: 0x06008412 RID: 33810 RVA: 0x00044820 File Offset: 0x00042A20
		private void ResumeFromSave_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x04004846 RID: 18502
		[CompilerGenerated]
		[AccessedThroughProperty("PB_PercentComplete")]
		private Control11 control11_0;

		// Token: 0x04004847 RID: 18503
		private ScenContainer scenContainer_0;

		// Token: 0x04004848 RID: 18504
		public string string_0;

		// Token: 0x04004849 RID: 18505
		public string string_1;

		// Token: 0x0400484A RID: 18506
		private string string_2;

		// Token: 0x0400484B RID: 18507
		[AccessedThroughProperty("BW_LoadScen")]
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x0400484C RID: 18508
		private Scenario scenario_0;

		// Token: 0x0400484D RID: 18509
		private bool bool_3;

		// Token: 0x0400484E RID: 18510
		private double double_0;

		// Token: 0x0400484F RID: 18511
		private string string_3;
	}
}
