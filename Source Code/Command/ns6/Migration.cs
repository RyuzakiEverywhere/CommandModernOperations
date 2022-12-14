using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000EE1 RID: 3809
	[DesignerGenerated]
	internal sealed partial class Migration : DarkSecondaryFormBase
	{
		// Token: 0x06008533 RID: 34099 RVA: 0x00477708 File Offset: 0x00475908
		public Migration()
		{
			base.Load += this.Migration_Load;
			base.KeyDown += this.Migration_KeyDown;
			base.FormClosing += this.Migration_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x06008535 RID: 34101 RVA: 0x00477798 File Offset: 0x00475998
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Migration));
			this.vmethod_1(new Class115());
			this.vmethod_23(new Control9());
			this.vmethod_25(new Class116());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Control8());
			this.vmethod_9(new Class115());
			this.vmethod_11(new Class112());
			this.vmethod_13(new Class112());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Class116());
			this.vmethod_19(new Class116());
			this.vmethod_21(new Control9());
			this.vmethod_0().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Controls.Add(this.vmethod_22());
			this.vmethod_0().Controls.Add(this.vmethod_24());
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Controls.Add(this.vmethod_4());
			this.vmethod_0().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(12, 241);
			this.vmethod_0().Name = "MigrationAllScenarios";
			this.vmethod_0().Size = new Size(632, 84);
			this.vmethod_0().TabIndex = 7;
			this.vmethod_0().TabStop = false;
			this.vmethod_0().Text = "Batch-Rebuild Multiple Scenarios";
			this.vmethod_22().BackColor = Color.Transparent;
			this.vmethod_22().DialogResult = DialogResult.None;
			this.vmethod_22().ForeColor = SystemColors.Control;
			this.vmethod_22().Location = new Point(287, 57);
			this.vmethod_22().Name = "Button_BatchRebuildManual";
			this.vmethod_22().method_1(0);
			this.vmethod_22().Size = new Size(231, 23);
			this.vmethod_22().TabIndex = 6;
			this.vmethod_22().Text = "Deep-Rebuild (select manually)";
			this.vmethod_24().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().Location = new Point(284, 15);
			this.vmethod_24().Name = "Label4";
			this.vmethod_24().Size = new Size(334, 52);
			this.vmethod_24().TabIndex = 5;
			this.vmethod_24().Text = "Manually select multiple scenario files and perform deep-rebuild on them and apply INI files (if present)";
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DialogResult = DialogResult.None;
			this.vmethod_2().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_2().ForeColor = SystemColors.Control;
			this.vmethod_2().Location = new Point(9, 57);
			this.vmethod_2().Name = "Button2";
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(239, 23);
			this.vmethod_2().TabIndex = 4;
			this.vmethod_2().Text = "Deep-Rebuild All Scenarios In List";
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(6, 16);
			this.vmethod_4().Name = "Label3";
			this.vmethod_4().Size = new Size(242, 51);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Read scenarios from a 'scenario list' file, and perform deep-rebuild on them and apply INI files (if present)";
			this.vmethod_6().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_6().method_14(null);
			this.vmethod_6().method_15(AutoCompleteMode.None);
			this.vmethod_6().method_13(AutoCompleteSource.None);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().method_17(new Font("Segoe UI", 10f));
			this.vmethod_6().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_6().method_12(null);
			this.vmethod_6().method_18(null);
			this.vmethod_6().Location = new Point(0, 331);
			this.vmethod_6().method_2(32767);
			this.vmethod_6().method_7(true);
			this.vmethod_6().Name = "TextBox1";
			this.vmethod_6().method_3(false);
			this.vmethod_6().method_19(ScrollBars.None);
			this.vmethod_6().method_9(0);
			this.vmethod_6().Size = new Size(657, 316);
			this.vmethod_6().TabIndex = 6;
			this.vmethod_6().method_1(HorizontalAlignment.Left);
			this.vmethod_6().method_5(false);
			this.vmethod_6().method_10("");
			this.vmethod_8().Controls.Add(this.vmethod_10());
			this.vmethod_8().Controls.Add(this.vmethod_12());
			this.vmethod_8().Controls.Add(this.vmethod_14());
			this.vmethod_8().Controls.Add(this.vmethod_16());
			this.vmethod_8().Controls.Add(this.vmethod_18());
			this.vmethod_8().Controls.Add(this.vmethod_20());
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(12, 11);
			this.vmethod_8().Name = "MigrationSingleScenario";
			this.vmethod_8().Size = new Size(632, 224);
			this.vmethod_8().TabIndex = 8;
			this.vmethod_8().TabStop = false;
			this.vmethod_8().Text = "Rebuild Current Scenario";
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Location = new Point(390, 189);
			this.vmethod_10().Name = "CB_ApplyINI";
			this.vmethod_10().Size = new Size(96, 19);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_10().Text = "Apply INI File";
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Location = new Point(254, 189);
			this.vmethod_12().Name = "CB_DeepRebuild";
			this.vmethod_12().Size = new Size(130, 19);
			this.vmethod_12().TabIndex = 3;
			this.vmethod_12().Text = "Force Deep-Rebuild";
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(6, 16);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Size = new Size(612, 63);
			this.vmethod_14().TabIndex = 1;
			this.vmethod_14().Text = componentResourceManager.GetString("Label1.Text");
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Location = new Point(6, 130);
			this.vmethod_16().Name = "Label5";
			this.vmethod_16().Size = new Size(612, 49);
			this.vmethod_16().TabIndex = 2;
			this.vmethod_16().Text = componentResourceManager.GetString("Label5.Text");
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(6, 79);
			this.vmethod_18().Name = "Label2";
			this.vmethod_18().Size = new Size(612, 47);
			this.vmethod_18().TabIndex = 2;
			this.vmethod_18().Text = componentResourceManager.GetString("Label2.Text");
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().DialogResult = DialogResult.None;
			this.vmethod_20().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_20().ForeColor = SystemColors.Control;
			this.vmethod_20().Location = new Point(9, 185);
			this.vmethod_20().Name = "Button1";
			this.vmethod_20().method_1(0);
			this.vmethod_20().Size = new Size(217, 23);
			this.vmethod_20().TabIndex = 3;
			this.vmethod_20().Text = "I understand - Rebuild Current Scenario";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(657, 644);
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Migration";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Scenario Migration";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_8().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06008536 RID: 34102 RVA: 0x000508B1 File Offset: 0x0004EAB1
		[CompilerGenerated]
		internal Class115 vmethod_0()
		{
			return this.class115_0;
		}

		// Token: 0x06008537 RID: 34103 RVA: 0x000508B9 File Offset: 0x0004EAB9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class115 class115_2)
		{
			this.class115_0 = class115_2;
		}

		// Token: 0x06008538 RID: 34104 RVA: 0x000508C2 File Offset: 0x0004EAC2
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x06008539 RID: 34105 RVA: 0x004781A0 File Offset: 0x004763A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_5);
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

		// Token: 0x0600853A RID: 34106 RVA: 0x000508CA File Offset: 0x0004EACA
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_0;
		}

		// Token: 0x0600853B RID: 34107 RVA: 0x000508D2 File Offset: 0x0004EAD2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_5)
		{
			this.class116_0 = class116_5;
		}

		// Token: 0x0600853C RID: 34108 RVA: 0x000508DB File Offset: 0x0004EADB
		[CompilerGenerated]
		internal Control8 vmethod_6()
		{
			return this.control8_0;
		}

		// Token: 0x0600853D RID: 34109 RVA: 0x000508E3 File Offset: 0x0004EAE3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control8 control8_1)
		{
			this.control8_0 = control8_1;
		}

		// Token: 0x0600853E RID: 34110 RVA: 0x000508EC File Offset: 0x0004EAEC
		[CompilerGenerated]
		internal Class115 vmethod_8()
		{
			return this.class115_1;
		}

		// Token: 0x0600853F RID: 34111 RVA: 0x000508F4 File Offset: 0x0004EAF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class115 class115_2)
		{
			this.class115_1 = class115_2;
		}

		// Token: 0x06008540 RID: 34112 RVA: 0x000508FD File Offset: 0x0004EAFD
		[CompilerGenerated]
		internal Class112 vmethod_10()
		{
			return this.class112_0;
		}

		// Token: 0x06008541 RID: 34113 RVA: 0x00050905 File Offset: 0x0004EB05
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class112 class112_2)
		{
			this.class112_0 = class112_2;
		}

		// Token: 0x06008542 RID: 34114 RVA: 0x0005090E File Offset: 0x0004EB0E
		[CompilerGenerated]
		internal Class112 vmethod_12()
		{
			return this.class112_1;
		}

		// Token: 0x06008543 RID: 34115 RVA: 0x00050916 File Offset: 0x0004EB16
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class112 class112_2)
		{
			this.class112_1 = class112_2;
		}

		// Token: 0x06008544 RID: 34116 RVA: 0x0005091F File Offset: 0x0004EB1F
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_1;
		}

		// Token: 0x06008545 RID: 34117 RVA: 0x00050927 File Offset: 0x0004EB27
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_5)
		{
			this.class116_1 = class116_5;
		}

		// Token: 0x06008546 RID: 34118 RVA: 0x00050930 File Offset: 0x0004EB30
		[CompilerGenerated]
		internal Class116 vmethod_16()
		{
			return this.class116_2;
		}

		// Token: 0x06008547 RID: 34119 RVA: 0x00050938 File Offset: 0x0004EB38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class116 class116_5)
		{
			this.class116_2 = class116_5;
		}

		// Token: 0x06008548 RID: 34120 RVA: 0x00050941 File Offset: 0x0004EB41
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_3;
		}

		// Token: 0x06008549 RID: 34121 RVA: 0x00050949 File Offset: 0x0004EB49
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_5)
		{
			this.class116_3 = class116_5;
		}

		// Token: 0x0600854A RID: 34122 RVA: 0x00050952 File Offset: 0x0004EB52
		[CompilerGenerated]
		internal Control9 vmethod_20()
		{
			return this.control9_1;
		}

		// Token: 0x0600854B RID: 34123 RVA: 0x004781E4 File Offset: 0x004763E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Control9 control9_3)
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

		// Token: 0x0600854C RID: 34124 RVA: 0x0005095A File Offset: 0x0004EB5A
		[CompilerGenerated]
		internal Control9 vmethod_22()
		{
			return this.control9_2;
		}

		// Token: 0x0600854D RID: 34125 RVA: 0x00478228 File Offset: 0x00476428
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x0600854E RID: 34126 RVA: 0x00050962 File Offset: 0x0004EB62
		[CompilerGenerated]
		internal Class116 vmethod_24()
		{
			return this.class116_4;
		}

		// Token: 0x0600854F RID: 34127 RVA: 0x0005096A File Offset: 0x0004EB6A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class116 class116_5)
		{
			this.class116_4 = class116_5;
		}

		// Token: 0x06008550 RID: 34128 RVA: 0x00050973 File Offset: 0x0004EB73
		[CompilerGenerated]
		internal OpenFileDialog vmethod_26()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06008551 RID: 34129 RVA: 0x0005097B File Offset: 0x0004EB7B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(OpenFileDialog openFileDialog_2)
		{
			this.openFileDialog_0 = openFileDialog_2;
		}

		// Token: 0x06008552 RID: 34130 RVA: 0x00050984 File Offset: 0x0004EB84
		[CompilerGenerated]
		internal OpenFileDialog vmethod_28()
		{
			return this.openFileDialog_1;
		}

		// Token: 0x06008553 RID: 34131 RVA: 0x0005098C File Offset: 0x0004EB8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(OpenFileDialog openFileDialog_2)
		{
			this.openFileDialog_1 = openFileDialog_2;
		}

		// Token: 0x06008554 RID: 34132 RVA: 0x0047826C File Offset: 0x0047646C
		private void Migration_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			DBOps.DBFileCheckResult value;
			DBRecord dbrecord = DBOps.smethod_10(DBOps.smethod_12(Client.smethod_40().DBID), ref value, true, true);
			if (Information.IsNothing(dbrecord))
			{
				DarkMessageBox.smethod_2("Error while preparing to migrate:" + Conversions.ToString((int)value) + "\r\nAborting...", "Error", Enum11.const_0);
			}
			this.string_0 = dbrecord.string_2;
			this.Text = "Scenario Migration (Selected DB: " + this.string_0 + ")";
		}

		// Token: 0x06008555 RID: 34133 RVA: 0x004782F8 File Offset: 0x004764F8
		private void method_3()
		{
			this.vmethod_6().Text = "Beginning migration... \r\n\r\n";
			Application.DoEvents();
			Control8 control;
			(control = this.vmethod_6()).Text = string.Concat(new string[]
			{
				control.Text,
				"Saving copy of current scenario to [",
				GameGeneral.string_4,
				"\\",
				Client.smethod_46().FileName,
				".OLD]... "
			});
			Application.DoEvents();
			Client.smethod_75(true, GameGeneral.string_4 + "\\" + Client.smethod_46().FileName + ".OLD", false);
			(control = this.vmethod_6()).Text = control.Text + "Done.\r\n\r\n";
			Application.DoEvents();
			(control = this.vmethod_6()).Text = control.Text + "Switching DB version to current... ";
			Client.smethod_100(DBOps.smethod_12(Client.smethod_40().DBID));
			Application.DoEvents();
			(control = this.vmethod_6()).Text = control.Text + "Done.\r\n\r\n";
			Application.DoEvents();
			(control = this.vmethod_6()).Text = control.Text + "Autosaving... ";
			Application.DoEvents();
			Class434.smethod_1(Client.smethod_46(), Client.smethod_46().method_44()[0], GameGeneral.string_4 + "\\SBR.scen", false, false);
			(control = this.vmethod_6()).Text = control.Text + "Done.\r\n\r\n";
			Application.DoEvents();
			(control = this.vmethod_6()).Text = control.Text + "Re-loading migrated scenario... ";
			Application.DoEvents();
			Scenario scenario = Client.smethod_46();
			GameGeneral.smethod_12(ref scenario, false);
			scenario = null;
			ScenContainer scenContainer = ScenContainer.smethod_2(GameGeneral.string_4 + "\\SBR.scen");
			string text = "";
			double num = 0.0;
			Scenario scenario2 = scenContainer.method_8(ref text, ref num, this.vmethod_12().Checked);
			(control = this.vmethod_6()).Text = control.Text + "Done.\r\n\r\n";
			Application.DoEvents();
			string text2;
			if (this.vmethod_10().Checked)
			{
				(control = this.vmethod_6()).Text = control.Text + "Select INI configuration file... ";
				Application.DoEvents();
				this.vmethod_27(new OpenFileDialog());
				this.vmethod_26().InitialDirectory = GameGeneral.string_4;
				if (this.vmethod_26().ShowDialog() == DialogResult.OK)
				{
					(control = this.vmethod_6()).Text = control.Text + "Done.\r\n\r\n";
					Application.DoEvents();
					(control = this.vmethod_6()).Text = control.Text + "Applying INI configuration from [" + this.vmethod_26().FileName + "]... ";
					Application.DoEvents();
					if (!Directory.Exists(GameGeneral.string_10))
					{
						Directory.CreateDirectory(GameGeneral.string_10);
					}
					text2 = "\r\n\r\nScenario : " + scenario2.method_0() + "\r\nConfig file: " + this.vmethod_26().FileName;
					StreamWriter streamWriter = File.AppendText(Path.Combine(GameGeneral.string_10, "SBR log file.txt"));
					streamWriter.Write("\r\n\r\n" + text2);
					streamWriter.Close();
					Class559.smethod_9(scenario2, this.vmethod_26().FileName, false, null);
					text2 = "Scenario " + scenario2.method_0() + ": Rebuild Completed";
					StreamWriter streamWriter2 = File.AppendText(Path.Combine(GameGeneral.string_10, "SBR log file.txt"));
					streamWriter2.Write("\r\n" + text2);
					streamWriter2.Close();
					Class434.smethod_1(scenario2, scenario2.method_44()[0], GameGeneral.string_4 + "\\SBR.scen", true, false);
					scenario = Client.smethod_46();
					GameGeneral.smethod_12(ref scenario, false);
					scenario = null;
					GameGeneral.smethod_10();
					Thread.Sleep(2000);
					ScenContainer scenContainer2 = ScenContainer.smethod_2(GameGeneral.string_4 + "\\SBR.scen");
					text = "";
					num = 0.0;
					scenario2 = scenContainer2.method_8(ref text, ref num, false);
					(control = this.vmethod_6()).Text = control.Text + "Done.\r\n\r\n";
					Application.DoEvents();
				}
			}
			text2 = "\r\n\r\nScenario : " + scenario2.method_0();
			StreamWriter streamWriter3 = File.AppendText(Path.Combine(GameGeneral.string_10, "SBR plaform list.txt"));
			streamWriter3.Write("\r\n\r\n" + text2);
			streamWriter3.Close();
			Class559.smethod_10(scenario2);
			try
			{
				foreach (ActiveUnit activeUnit in scenario2.method_42())
				{
					if (!Information.IsNothing(activeUnit))
					{
						activeUnit.vmethod_88().vmethod_5(activeUnit.method_78());
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			text2 = "Scenario " + scenario2.method_0() + ": Rebuild Completed";
			StreamWriter streamWriter4 = File.AppendText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt");
			streamWriter4.Write(text2);
			streamWriter4.Close();
			List<string> list = Class559.smethod_13(scenario2);
			if (list.Count > 0)
			{
				text2 = "  ERROR: ONE OR MORE AIRCRAFT FEATURED IN THIS SCENARIO CARRY A LOADOUT THAT IS NOT IN THE AIRCRAFT'S LOADOUT LIST.\r\n  PLATFORMS ARE AS FOLLOWS:\r\n";
				try
				{
					foreach (string str in list)
					{
						text2 = text2 + "  " + str + "\r\n";
					}
				}
				finally
				{
					List<string>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				text2 += "  Please contact the author of this DB in order to have this problem rectified.\r\n";
				DarkMessageBox.smethod_1(text2, "Missing platforms from new DB!", Enum11.const_0);
			}
			List<string> list2 = new List<string>();
			foreach (Side side in scenario2.method_44())
			{
				if (!Information.IsNothing(side.method_35()))
				{
					try
					{
						foreach (Mission mission in side.method_36(scenario2))
						{
							list2.AddRange(scenario2.method_96(ref side, ref mission));
						}
					}
					finally
					{
						IEnumerator<Mission> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
				}
			}
			if (list2.Count > 0)
			{
				text2 = "WARNING: SOME AIRCRAFT IN THIS SCENARIO WILL NOT BE ABLE TO TAKE OFF DUE TO THE MISSION'S FLIGHT SIZE RESTRICTIONS!\r\n\r\nTo rectify this, you can change the flight size of the mission, add more aircraft to the mission, change loadouts on existing aircraft so there are enough aircraft armed with identical loadouts, or uncheck the flag Aircraft numbers below Flight Size do not take off.\r\n\r\n";
				try
				{
					foreach (string str2 in list2)
					{
						text2 = text2 + "\r\n" + str2;
					}
				}
				finally
				{
					List<string>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
				DarkMessageBox.smethod_1(text2, "Missing platforms from new DB!", Enum11.const_0);
			}
			if (scenario2.LoadingNotices.Count > 0)
			{
				(control = this.vmethod_6()).Text = control.Text + "Notices:\r\n";
				(control = this.vmethod_6()).Text = control.Text + "--------\r\n";
				try
				{
					foreach (string str3 in Client.smethod_46().LoadingNotices)
					{
						(control = this.vmethod_6()).Text = control.Text + str3 + "\r\n";
					}
				}
				finally
				{
					List<string>.Enumerator enumerator5;
					((IDisposable)enumerator5).Dispose();
				}
				(control = this.vmethod_6()).Text = control.Text + "--------\r\n";
			}
			scenario2.FeatureCompatibility = default(Scenario._FeatureCompatibility);
			(control = this.vmethod_6()).Text = control.Text + "All done! The scenario has been migrated to the current version of this database. You can now close this window.";
			Application.DoEvents();
			Client.smethod_47(scenario2, false);
			Client.smethod_0().method_4();
		}

		// Token: 0x06008556 RID: 34134 RVA: 0x00478A64 File Offset: 0x00476C64
		private void method_4(object sender, EventArgs e)
		{
			if (!Enumerable.Any<Side>(Client.smethod_46().method_44()))
			{
				DarkMessageBox.smethod_2("The scenario must have at least one side present!", "No side present", Enum11.const_0);
				return;
			}
			string text = DBOps.smethod_12(Client.smethod_40().DBID);
			List<string> list = Class559.smethod_12(Client.smethod_46(), text, !this.vmethod_12().Checked);
			if (list.Count > 0)
			{
				string text2 = "One or more platforms featured in this scenario are missing from the DB you are attempting to migrate to. The missing platforms are as follows:\r\n\r\n";
				try
				{
					foreach (string str in list)
					{
						text2 = text2 + str + "\r\n";
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				text2 += "\r\n";
				text2 += "Please contact the author of this DB in order to have this problem rectified. The unit(s) have to be deleted and replaced with units that actually exist in the database.\r\n\r\n";
				text2 += "...MIGRATION ABORTED...";
				DarkMessageBox.smethod_2(text2, "Missing platforms from new DB!", Enum11.const_0);
				return;
			}
			list.Clear();
			this.method_3();
		}

		// Token: 0x06008557 RID: 34135 RVA: 0x00478B58 File Offset: 0x00476D58
		private void method_5(object sender, EventArgs e)
		{
			this.vmethod_6().Text = "Select scenario list file... ";
			Application.DoEvents();
			this.vmethod_27(new OpenFileDialog());
			this.vmethod_26().InitialDirectory = GameGeneral.string_4;
			if (this.vmethod_26().ShowDialog() == DialogResult.OK)
			{
				Control8 control;
				(control = this.vmethod_6()).Text = control.Text + "Done!\r\n\r\n";
				Application.DoEvents();
				(control = this.vmethod_6()).Text = control.Text + "Starting rebuilding all scenarios listed in '" + this.vmethod_26().FileName + "'.\r\n\r\n";
				Application.DoEvents();
				Migration.smethod_0(this.vmethod_26().FileName);
				(control = this.vmethod_6()).Text = control.Text + "Rebuilding done! Please check '" + Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR log file.txt' for errors.\r\n\r\n";
				Application.DoEvents();
			}
		}

		// Token: 0x06008558 RID: 34136 RVA: 0x00478C40 File Offset: 0x00476E40
		private void method_6(object sender, EventArgs e)
		{
			this.vmethod_6().Text = "Select scenario files... ";
			Application.DoEvents();
			this.vmethod_29(new OpenFileDialog());
			this.vmethod_28().InitialDirectory = GameGeneral.string_4;
			this.vmethod_28().Multiselect = true;
			if (this.vmethod_28().ShowDialog() == DialogResult.OK)
			{
				Control8 control;
				(control = this.vmethod_6()).Text = control.Text + Conversions.ToString(this.vmethod_28().FileNames.Length) + " files selected\r\n\r\n";
				Application.DoEvents();
				(control = this.vmethod_6()).Text = control.Text + "Starting rebuilding all selected scenarios.\r\n\r\n";
				Application.DoEvents();
				int num = 0;
				foreach (string text in this.vmethod_28().FileNames)
				{
					string string_ = Path.GetDirectoryName(text) + "\\" + Path.GetFileNameWithoutExtension(Path.GetFullPath(text)) + ".ini";
					num++;
					Migration.smethod_1(text, string_, ref num);
				}
				(control = this.vmethod_6()).Text = control.Text + "Rebuilding done! Please check '" + Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR log file.txt' for errors.\r\n\r\n";
				Application.DoEvents();
			}
		}

		// Token: 0x06008559 RID: 34137 RVA: 0x00478D7C File Offset: 0x00476F7C
		public static void smethod_0(string string_1)
		{
			FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read);
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				using (fileStream)
				{
					try
					{
						xmlDocument.Load(fileStream);
					}
					catch (Exception ex)
					{
						DarkMessageBox.smethod_2("Scenario List file is improperly formatted, read failed!", "Error", Enum11.const_0);
					}
				}
				XmlNode xmlNode = xmlDocument.SelectSingleNode("/ScenarioList");
				if (xmlNode != null)
				{
					XmlNodeList childNodes = xmlNode.ChildNodes;
					try
					{
						foreach (XmlNode xmlNode2 in childNodes)
						{
							try
							{
								string innerText;
								string innerText2;
								try
								{
									foreach (object obj in xmlNode2.ChildNodes)
									{
										XmlNode xmlNode3 = (XmlNode)obj;
										string left = xmlNode3.Name.Split(new char[]
										{
											'_'
										})[0];
										if (Operators.CompareString(left, "ScenarioFilePath", false) != 0)
										{
											if (Operators.CompareString(left, "ConfigFilePath", false) != 0)
											{
												continue;
											}
											try
											{
												try
												{
													foreach (object obj2 in xmlNode3.ChildNodes)
													{
														XmlNode xmlNode4 = (XmlNode)obj2;
														string left2 = xmlNode4.Name.Split(new char[]
														{
															'_'
														})[0];
														if (Operators.CompareString(left2, "#comment", false) == 0)
														{
															innerText = xmlNode4.InnerText;
														}
													}
												}
												finally
												{
													IEnumerator enumerator3;
													if (enumerator3 is IDisposable)
													{
														(enumerator3 as IDisposable).Dispose();
													}
												}
												continue;
											}
											catch (Exception ex2)
											{
												DarkMessageBox.smethod_2("No config file path found.", "Error", Enum11.const_0);
												continue;
											}
										}
										try
										{
											try
											{
												foreach (object obj3 in xmlNode3.ChildNodes)
												{
													XmlNode xmlNode5 = (XmlNode)obj3;
													string left2 = xmlNode5.Name.Split(new char[]
													{
														'_'
													})[0];
													if (Operators.CompareString(left2, "#comment", false) == 0)
													{
														innerText2 = xmlNode5.InnerText;
														Application.DoEvents();
													}
												}
											}
											finally
											{
												IEnumerator enumerator4;
												if (enumerator4 is IDisposable)
												{
													(enumerator4 as IDisposable).Dispose();
												}
											}
										}
										catch (Exception ex3)
										{
											DarkMessageBox.smethod_2("No scenario file path found.", "Error", Enum11.const_0);
										}
									}
								}
								finally
								{
									IEnumerator enumerator2;
									if (enumerator2 is IDisposable)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
								int num;
								num++;
								Migration.smethod_1(innerText2, innerText, ref num);
							}
							catch (Exception ex4)
							{
								int num;
								string str = "Scenario " + Conversions.ToString(num) + ": ERROR: LOAD FAILED!";
								File.AppendAllText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR log file.txt", "\r\n\r\n" + str);
							}
							GameGeneral.smethod_10();
							Thread.Sleep(2000);
						}
						goto IL_2D5;
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				DarkMessageBox.smethod_2("No XML data found.", "Error", Enum11.const_0);
				IL_2D5:;
			}
			catch (Exception ex5)
			{
				ex5.Data.Add("Error at 101120", "");
				GameGeneral.smethod_25(ref ex5);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600855A RID: 34138 RVA: 0x0047918C File Offset: 0x0047738C
		private static void smethod_1(string string_1, string string_2, ref int int_0)
		{
			string text;
			if (!File.Exists(string_1))
			{
				text = "Scenario " + Conversions.ToString(int_0) + ": ERROR: FILE NOT FOUND!";
				File.AppendAllText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR log file.txt", "\r\n\r\n" + text);
				File.AppendAllText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt", "\r\n\r\n" + text);
				return;
			}
			ScenContainer scenContainer = ScenContainer.smethod_2(string_1);
			string text2 = "";
			double num = 0.0;
			Scenario scenario = scenContainer.method_8(ref text2, ref num, false);
			text = string.Concat(new string[]
			{
				"Scenario ",
				Conversions.ToString(int_0),
				": ",
				scenario.method_0(),
				"\r\nScenario file: ",
				string_1,
				"\r\nConfig file:   ",
				string_2
			});
			File.AppendAllText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR log file.txt", "\r\n\r\n" + text);
			File.AppendAllText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt", "\r\n\r\n" + text);
			DBOps.DBFileCheckResult dbfileCheckResult_;
			DBRecord dbrecord = DBOps.smethod_10(scenario.method_7(), ref dbfileCheckResult_, true, true);
			if (Information.IsNothing(dbrecord))
			{
				Interaction.MsgBox("Error: " + DBOps.smethod_7(dbfileCheckResult_) + "\r\nAborting...", MsgBoxStyle.OkOnly, null);
				return;
			}
			scenario.method_7();
			string text3 = DBOps.smethod_12(dbrecord.DBID);
			scenario.method_8(text3);
			List<string> list = Class559.smethod_12(scenario, text3, false);
			if (list.Count > 0)
			{
				text = "  ERROR: ONE OR MORE PLATFORMS FEATURED IN THIS SCENARIO IS MISSING FROM THE DATABASE YOU ARE ATTEMPTING TO MIGRATE TO.\r\n  THE MISSING PLATFORMS ARE AS FOLLOWS:\r\n";
				try
				{
					foreach (string str in list)
					{
						text = text + "  " + str + "\r\n";
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				text += "  Please contact the author of this DB in order to have this problem rectified. The unit(s) have to be deleted and replaced with units that actually exist in the database.\r\n";
				text += "  MIGRATION ABORTED!";
				File.AppendAllText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR log file.txt", text);
				text = "Scenario " + Conversions.ToString(int_0) + ": ERROR: REBUILD FAILED!";
				File.AppendAllText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR log file.txt", "\r\n\r\n" + text);
				return;
			}
			scenario.LastSavedInScenEdit = true;
			Class434.smethod_1(scenario, scenario.method_44()[0], string_1, true, false);
			Scenario expression = scenario;
			if (!Information.IsNothing(expression))
			{
				GameGeneral.smethod_12(ref expression, false);
			}
			GameGeneral.smethod_10();
			Thread.Sleep(2000);
			scenario = null;
			expression = null;
			GameGeneral.smethod_10();
			Thread.Sleep(2000);
			ScenContainer scenContainer2 = ScenContainer.smethod_2(string_1);
			text2 = "";
			num = 0.0;
			scenario = scenContainer2.method_8(ref text2, ref num, true);
			List<string> list2 = Class559.smethod_13(scenario);
			if (list2.Count > 0)
			{
				text = "  ERROR: ONE OR MORE AIRCRAFT FEATURED IN THIS SCENARIO CARRY A LOADOUT THAT IS NOT IN THE AIRCRAFT'S LOADOUT LIST.\r\n  PLATFORMS ARE AS FOLLOWS:\r\n";
				try
				{
					foreach (string str2 in list2)
					{
						text = text + "  " + str2 + "\r\n";
					}
				}
				finally
				{
					List<string>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				text += "  Please contact the author of this DB in order to have this problem rectified.";
				File.AppendAllText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR log file.txt", "\r\n" + text);
			}
			List<string> list3 = new List<string>();
			foreach (Side side in scenario.method_44())
			{
				if (!Information.IsNothing(side.method_35()))
				{
					try
					{
						foreach (Mission mission in side.method_36(scenario))
						{
							list3.AddRange(scenario.method_96(ref side, ref mission));
						}
					}
					finally
					{
						IEnumerator<Mission> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
				}
			}
			if (list3.Count > 0)
			{
				text = "  WARNING: SOME AIRCRAFT IN THIS SCENARIO WILL NOT BE ABLE TO TAKE OFF DUE TO THE MISSION'S FLIGHT SIZE RESTRICTIONS!\r\n  To rectify this, you can change the flight size of the mission, add more aircraft to the mission, change loadouts on existing aircraft so there are enough aircraft armed with identical loadouts, or uncheck the flag Aircraft numbers below Flight Size do not take off.\r\n";
				try
				{
					foreach (string str3 in list3)
					{
						text = text + "\r\n    " + str3;
					}
				}
				finally
				{
					List<string>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
				File.AppendAllText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR log file.txt", "\r\n" + text);
			}
			text = "";
			Client.smethod_49(scenario, true, ref text);
			if (!string.IsNullOrEmpty(text))
			{
				text = "  ERROR: SOME AREAS IN THIS SCENARIO HAS PROBLEMS!\r\n" + text;
				File.AppendAllText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR log file.txt", "\r\n" + text);
			}
			if (File.Exists(string_2))
			{
				Class559.smethod_9(scenario, string_2, false, null);
			}
			Class559.smethod_10(scenario);
			try
			{
				foreach (ActiveUnit activeUnit in scenario.method_42())
				{
					if (!Information.IsNothing(activeUnit))
					{
						activeUnit.vmethod_88().vmethod_5(activeUnit.method_78());
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator5;
				((IDisposable)enumerator5).Dispose();
			}
			scenario.LastSavedInScenEdit = true;
			Class434.smethod_1(scenario, scenario.method_44()[0], string_1, true, false);
			text = "Scenario " + Conversions.ToString(int_0) + ": Rebuild Completed";
			File.AppendAllText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR log file.txt", "\r\n" + text);
			File.AppendAllText(Class2413.smethod_1().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt", text);
		}

		// Token: 0x0600855B RID: 34139 RVA: 0x003BB1A8 File Offset: 0x003B93A8
		private void Migration_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode != Keys.Space || !base.Visible)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600855C RID: 34140 RVA: 0x00044820 File Offset: 0x00042A20
		private void Migration_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x040048D6 RID: 18646
		[CompilerGenerated]
		[AccessedThroughProperty("MigrationAllScenarios")]
		private Class115 class115_0;

		// Token: 0x040048D7 RID: 18647
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_0;

		// Token: 0x040048D8 RID: 18648
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_0;

		// Token: 0x040048D9 RID: 18649
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private Control8 control8_0;

		// Token: 0x040048DA RID: 18650
		[AccessedThroughProperty("MigrationSingleScenario")]
		[CompilerGenerated]
		private Class115 class115_1;

		// Token: 0x040048DB RID: 18651
		[CompilerGenerated]
		[AccessedThroughProperty("CB_ApplyINI")]
		private Class112 class112_0;

		// Token: 0x040048DC RID: 18652
		[CompilerGenerated]
		[AccessedThroughProperty("CB_DeepRebuild")]
		private Class112 class112_1;

		// Token: 0x040048DD RID: 18653
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_1;

		// Token: 0x040048DE RID: 18654
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x040048DF RID: 18655
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x040048E0 RID: 18656
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x040048E1 RID: 18657
		[AccessedThroughProperty("Button_BatchRebuildManual")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x040048E2 RID: 18658
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x040048E3 RID: 18659
		[CompilerGenerated]
		[AccessedThroughProperty("FD_LoadINI")]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x040048E4 RID: 18660
		[CompilerGenerated]
		[AccessedThroughProperty("FD_ManualSelect")]
		private OpenFileDialog openFileDialog_1;

		// Token: 0x040048E5 RID: 18661
		private string string_0;
	}
}
