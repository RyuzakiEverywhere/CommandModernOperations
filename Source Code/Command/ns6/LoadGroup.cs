using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns32;
using ns4;
using ns5;
using ns7;

namespace ns6
{
	// Token: 0x02000EC1 RID: 3777
	[DesignerGenerated]
	internal sealed partial class LoadGroup : DarkSecondaryFormBase
	{
		// Token: 0x06007A96 RID: 31382 RVA: 0x00428F94 File Offset: 0x00427194
		public LoadGroup()
		{
			base.FormClosing += this.LoadGroup_FormClosing;
			base.Load += this.LoadGroup_Load;
			base.VisibleChanged += this.LoadGroup_VisibleChanged;
			base.KeyDown += this.LoadGroup_KeyDown;
			this.InitializeComponent_1();
		}

		// Token: 0x06007A98 RID: 31384 RVA: 0x00429038 File Offset: 0x00427238
		private void InitializeComponent_1()
		{
			this.vmethod_1(new TreeView());
			this.vmethod_3(new Class116());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Class116());
			this.vmethod_11(new Class116());
			this.vmethod_13(new Class116());
			this.vmethod_15(new Class116());
			this.vmethod_17(new FlowLayoutPanel());
			this.vmethod_19(new Class116());
			this.vmethod_21(new Class116());
			this.vmethod_23(new Control4());
			this.vmethod_25(new Control9());
			this.vmethod_27(new Control9());
			this.vmethod_29(new Class125());
			this.vmethod_31(new ToolStripLabel());
			this.vmethod_33(new Class112());
			this.vmethod_16().SuspendLayout();
			this.vmethod_28().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_0().BackColor = Color.FromArgb(43, 43, 43);
			this.vmethod_0().CheckBoxes = true;
			this.vmethod_0().ForeColor = Color.LightGray;
			this.vmethod_0().Location = new Point(12, 36);
			this.vmethod_0().Name = "TV1";
			this.vmethod_0().Size = new Size(268, 523);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(287, 13);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new Size(70, 13);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Group Name:";
			this.vmethod_4().method_2(true);
			this.vmethod_4().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(384, 13);
			this.vmethod_4().Name = "Label_Name";
			this.vmethod_4().Size = new Size(14, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "?";
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(287, 38);
			this.vmethod_6().Name = "Label3";
			this.vmethod_6().Size = new Size(59, 13);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "Valid From:";
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(286, 61);
			this.vmethod_8().Name = "Label4";
			this.vmethod_8().Size = new Size(57, 13);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "Valid Until:";
			this.vmethod_10().method_2(true);
			this.vmethod_10().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Location = new Point(352, 38);
			this.vmethod_10().Name = "Label_ValidFrom";
			this.vmethod_10().Size = new Size(14, 13);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_10().Text = "?";
			this.vmethod_12().method_2(true);
			this.vmethod_12().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(352, 61);
			this.vmethod_12().Name = "label_ValidUntil";
			this.vmethod_12().Size = new Size(14, 13);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_12().Text = "?";
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(3, 0);
			this.vmethod_14().Name = "Label7";
			this.vmethod_14().Size = new Size(38, 13);
			this.vmethod_14().TabIndex = 7;
			this.vmethod_14().Text = "Notes:";
			this.vmethod_16().Anchor = (AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_16().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_16().Controls.Add(this.vmethod_14());
			this.vmethod_16().Controls.Add(this.vmethod_18());
			this.vmethod_16().Location = new Point(290, 95);
			this.vmethod_16().Name = "FlowLayoutPanel1";
			this.vmethod_16().Size = new Size(338, 165);
			this.vmethod_16().TabIndex = 8;
			this.vmethod_18().method_2(true);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(47, 0);
			this.vmethod_18().Name = "Label_Notes";
			this.vmethod_18().Size = new Size(13, 13);
			this.vmethod_18().TabIndex = 0;
			this.vmethod_18().Text = "?";
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Location = new Point(290, 263);
			this.vmethod_20().Name = "Label9";
			this.vmethod_20().Size = new Size(85, 13);
			this.vmethod_20().TabIndex = 9;
			this.vmethod_20().Text = "Group Members:";
			this.vmethod_22().Location = new Point(293, 280);
			this.vmethod_22().Name = "ListView1";
			this.vmethod_22().Size = new Size(335, 238);
			this.vmethod_22().TabIndex = 10;
			this.vmethod_24().BackColor = Color.Transparent;
			this.vmethod_24().DialogResult = DialogResult.None;
			this.vmethod_24().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_24().ForeColor = SystemColors.Control;
			this.vmethod_24().Location = new Point(293, 534);
			this.vmethod_24().Name = "Button1";
			this.vmethod_24().method_1(0);
			this.vmethod_24().Size = new Size(146, 25);
			this.vmethod_24().TabIndex = 11;
			this.vmethod_24().Text = "Load selected installation(s)";
			this.vmethod_26().BackColor = Color.Transparent;
			this.vmethod_26().DialogResult = DialogResult.None;
			this.vmethod_26().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_26().ForeColor = SystemColors.Control;
			this.vmethod_26().Location = new Point(553, 534);
			this.vmethod_26().Name = "Button2";
			this.vmethod_26().method_1(0);
			this.vmethod_26().Size = new Size(75, 25);
			this.vmethod_26().TabIndex = 12;
			this.vmethod_26().Text = "Close";
			this.vmethod_28().AutoSize = false;
			this.vmethod_28().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_28().Dock = DockStyle.Bottom;
			this.vmethod_28().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_28().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_28().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_30()
			});
			this.vmethod_28().Location = new Point(0, 562);
			this.vmethod_28().Name = "ToolStrip1";
			this.vmethod_28().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_28().Size = new Size(640, 25);
			this.vmethod_28().TabIndex = 13;
			this.vmethod_28().Text = "ToolStrip1";
			this.vmethod_30().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Name = "TSL_Loadingtext";
			this.vmethod_30().Size = new Size(95, 22);
			this.vmethod_30().Text = "TSL_LoadingText";
			this.vmethod_32().AutoSize = true;
			this.vmethod_32().Location = new Point(12, 13);
			this.vmethod_32().Name = "CheckBox_DoNotCheckDBCompatibility";
			this.vmethod_32().Size = new Size(184, 17);
			this.vmethod_32().TabIndex = 14;
			this.vmethod_32().Text = "Do not check for DB compatibility";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(640, 587);
			base.Controls.Add(this.vmethod_32());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_16());
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
			base.Name = "LoadGroup";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Load Group(s) from File";
			this.vmethod_16().ResumeLayout(false);
			this.vmethod_16().PerformLayout();
			this.vmethod_28().ResumeLayout(false);
			this.vmethod_28().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06007A99 RID: 31385 RVA: 0x0004B747 File Offset: 0x00049947
		[CompilerGenerated]
		internal TreeView vmethod_0()
		{
			return this.treeView_0;
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x00429C14 File Offset: 0x00427E14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TreeView treeView_1)
		{
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.method_5);
			TreeView treeView = this.treeView_0;
			if (treeView != null)
			{
				treeView.NodeMouseClick -= value;
			}
			this.treeView_0 = treeView_1;
			treeView = this.treeView_0;
			if (treeView != null)
			{
				treeView.NodeMouseClick += value;
			}
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x0004B74F File Offset: 0x0004994F
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x0004B757 File Offset: 0x00049957
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_9)
		{
			this.class116_0 = class116_9;
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x0004B760 File Offset: 0x00049960
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x0004B768 File Offset: 0x00049968
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_9)
		{
			this.class116_1 = class116_9;
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x0004B771 File Offset: 0x00049971
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_2;
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x0004B779 File Offset: 0x00049979
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_9)
		{
			this.class116_2 = class116_9;
		}

		// Token: 0x06007AA1 RID: 31393 RVA: 0x0004B782 File Offset: 0x00049982
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_3;
		}

		// Token: 0x06007AA2 RID: 31394 RVA: 0x0004B78A File Offset: 0x0004998A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_9)
		{
			this.class116_3 = class116_9;
		}

		// Token: 0x06007AA3 RID: 31395 RVA: 0x0004B793 File Offset: 0x00049993
		[CompilerGenerated]
		internal Class116 vmethod_10()
		{
			return this.class116_4;
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x0004B79B File Offset: 0x0004999B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class116 class116_9)
		{
			this.class116_4 = class116_9;
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x0004B7A4 File Offset: 0x000499A4
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_5;
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x0004B7AC File Offset: 0x000499AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_9)
		{
			this.class116_5 = class116_9;
		}

		// Token: 0x06007AA7 RID: 31399 RVA: 0x0004B7B5 File Offset: 0x000499B5
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_6;
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x0004B7BD File Offset: 0x000499BD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_9)
		{
			this.class116_6 = class116_9;
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x0004B7C6 File Offset: 0x000499C6
		[CompilerGenerated]
		internal FlowLayoutPanel vmethod_16()
		{
			return this.flowLayoutPanel_0;
		}

		// Token: 0x06007AAA RID: 31402 RVA: 0x0004B7CE File Offset: 0x000499CE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(FlowLayoutPanel flowLayoutPanel_1)
		{
			this.flowLayoutPanel_0 = flowLayoutPanel_1;
		}

		// Token: 0x06007AAB RID: 31403 RVA: 0x0004B7D7 File Offset: 0x000499D7
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_7;
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x0004B7DF File Offset: 0x000499DF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_9)
		{
			this.class116_7 = class116_9;
		}

		// Token: 0x06007AAD RID: 31405 RVA: 0x0004B7E8 File Offset: 0x000499E8
		[CompilerGenerated]
		internal Class116 vmethod_20()
		{
			return this.class116_8;
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x0004B7F0 File Offset: 0x000499F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class116 class116_9)
		{
			this.class116_8 = class116_9;
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x0004B7F9 File Offset: 0x000499F9
		[CompilerGenerated]
		internal Control4 vmethod_22()
		{
			return this.control4_0;
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x0004B801 File Offset: 0x00049A01
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Control4 control4_1)
		{
			this.control4_0 = control4_1;
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x0004B80A File Offset: 0x00049A0A
		[CompilerGenerated]
		internal Control9 vmethod_24()
		{
			return this.control9_0;
		}

		// Token: 0x06007AB2 RID: 31410 RVA: 0x00429C58 File Offset: 0x00427E58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Control9 control9_2)
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

		// Token: 0x06007AB3 RID: 31411 RVA: 0x0004B812 File Offset: 0x00049A12
		[CompilerGenerated]
		internal Control9 vmethod_26()
		{
			return this.control9_1;
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x00429C9C File Offset: 0x00427E9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x06007AB5 RID: 31413 RVA: 0x0004B81A File Offset: 0x00049A1A
		[CompilerGenerated]
		internal Class125 vmethod_28()
		{
			return this.class125_0;
		}

		// Token: 0x06007AB6 RID: 31414 RVA: 0x0004B822 File Offset: 0x00049A22
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x06007AB7 RID: 31415 RVA: 0x0004B82B File Offset: 0x00049A2B
		[CompilerGenerated]
		internal ToolStripLabel vmethod_30()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x06007AB8 RID: 31416 RVA: 0x0004B833 File Offset: 0x00049A33
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(ToolStripLabel toolStripLabel_1)
		{
			this.toolStripLabel_0 = toolStripLabel_1;
		}

		// Token: 0x06007AB9 RID: 31417 RVA: 0x0004B83C File Offset: 0x00049A3C
		[CompilerGenerated]
		internal Class112 vmethod_32()
		{
			return this.class112_0;
		}

		// Token: 0x06007ABA RID: 31418 RVA: 0x0004B844 File Offset: 0x00049A44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class112 class112_1)
		{
			this.class112_0 = class112_1;
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x0004B84D File Offset: 0x00049A4D
		private void LoadGroup_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().Enabled = true;
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x0004B86E File Offset: 0x00049A6E
		private void LoadGroup_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.method_3();
		}

		// Token: 0x06007ABD RID: 31421 RVA: 0x00429CE0 File Offset: 0x00427EE0
		private void method_3()
		{
			TreeNode treeNode = this.vmethod_0().Nodes.Add("Main");
			treeNode.Tag = "";
			this.method_4(ref treeNode, Application.StartupPath + "\\ImportExport");
			this.vmethod_30().Visible = false;
		}

		// Token: 0x06007ABE RID: 31422 RVA: 0x00429D34 File Offset: 0x00427F34
		private void method_4(ref TreeNode treeNode_0, string string_0)
		{
			TreeNode treeNode = treeNode_0.Nodes.Add(Path.GetFullPath(string_0), Path.GetFileName(string_0));
			treeNode.Tag = string_0;
			foreach (string string_ in Directory.GetDirectories(string_0))
			{
				this.method_4(ref treeNode, string_);
			}
			foreach (string text in Directory.GetFiles(string_0))
			{
				treeNode.Nodes.Add(Path.GetFullPath(text), Path.GetFileName(text)).Tag = text;
			}
		}

		// Token: 0x06007ABF RID: 31423 RVA: 0x00429DC8 File Offset: 0x00427FC8
		private void method_5(object sender, TreeNodeMouseClickEventArgs e)
		{
			try
			{
				if (Conversions.ToString(e.Node.Tag).Contains(".inst"))
				{
					this.vmethod_22().method_18().Clear();
					StreamReader streamReader = new StreamReader(Conversions.ToString(e.Node.Tag));
					using (streamReader)
					{
						string text = streamReader.ReadToEnd().Replace("\\\"", "");
						text = text.Replace("\\", "/");
						this.importExportRecord_0 = (ImportExportRecord)Class2330.smethod_29(text, typeof(ImportExportRecord));
					}
					if (this.importExportRecord_0.DB_ID != Client.smethod_40().DBID && !this.vmethod_32().Checked)
					{
						this.vmethod_4().Text = "CANNOT USE - INCOMPATIBLE DB";
						e.Node.Checked = false;
						goto IL_2CC;
					}
					this.vmethod_4().Text = this.importExportRecord_0.Name;
					this.vmethod_10().Text = this.importExportRecord_0.ValidFrom;
					this.vmethod_12().Text = this.importExportRecord_0.ValidUntil;
					this.vmethod_18().Text = this.importExportRecord_0.Comments;
					try
					{
						foreach (ImportExportRecord.MemberRecord memberRecord in this.importExportRecord_0.MemberRecords)
						{
							Class117 item = new Class117(memberRecord.MemberName);
							this.vmethod_22().method_18().Add(item);
						}
						goto IL_2CC;
					}
					finally
					{
						List<ImportExportRecord.MemberRecord>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (e.Node.Checked)
				{
					try
					{
						foreach (object obj in e.Node.Nodes)
						{
							TreeNode treeNode = (TreeNode)obj;
							StreamReader streamReader3 = new StreamReader(Conversions.ToString(treeNode.Tag));
							using (streamReader3)
							{
								string text2 = streamReader3.ReadToEnd().Replace("\\\"", "");
								text2 = text2.Replace("\\", "/");
								this.importExportRecord_0 = (ImportExportRecord)Class2330.smethod_29(text2, typeof(ImportExportRecord));
							}
							if (this.importExportRecord_0.DB_ID != Client.smethod_40().DBID && !this.vmethod_32().Checked)
							{
								treeNode.Checked = false;
							}
							else
							{
								treeNode.Checked = true;
							}
						}
						goto IL_2CC;
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
				try
				{
					foreach (object obj2 in e.Node.Nodes)
					{
						((TreeNode)obj2).Checked = false;
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
				IL_2CC:;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200272", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06007AC0 RID: 31424 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_6(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06007AC1 RID: 31425 RVA: 0x0042A174 File Offset: 0x00428374
		private void method_7(TreeNode treeNode_0)
		{
			try
			{
				foreach (object obj in treeNode_0.Nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					if (Conversions.ToString(treeNode.Tag).Contains(".inst"))
					{
						if (treeNode.Checked)
						{
							this.vmethod_30().Visible = true;
							this.vmethod_30().Text = "Loading: " + treeNode.Text;
							Client.smethod_46().method_81(Conversions.ToString(treeNode.Tag), Client.smethod_50());
							Client.bool_1 = true;
						}
					}
					else
					{
						this.method_7(treeNode);
					}
				}
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

		// Token: 0x06007AC2 RID: 31426 RVA: 0x0042A23C File Offset: 0x0042843C
		private void method_8(object sender, EventArgs e)
		{
			if (this.vmethod_0().Nodes.Count != 0)
			{
				this.method_7(this.vmethod_0().Nodes[0]);
				this.vmethod_30().Text = "Completed!";
				try
				{
					foreach (TreeNode treeNode in Class2558.smethod_5(this.vmethod_0()))
					{
						if (treeNode.Checked)
						{
							treeNode.Checked = false;
						}
					}
				}
				finally
				{
					IEnumerator<TreeNode> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				Client.bool_1 = true;
			}
		}

		// Token: 0x06007AC3 RID: 31427 RVA: 0x0004B889 File Offset: 0x00049A89
		private void LoadGroup_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				Class2413.smethod_2().method_41().Enabled = false;
				return;
			}
			Class2413.smethod_2().method_41().Enabled = true;
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x0004B8B4 File Offset: 0x00049AB4
		private void LoadGroup_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x04004460 RID: 17504
		[CompilerGenerated]
		[AccessedThroughProperty("TV1")]
		private TreeView treeView_0;

		// Token: 0x04004461 RID: 17505
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004462 RID: 17506
		[CompilerGenerated]
		[AccessedThroughProperty("Label_Name")]
		private Class116 class116_1;

		// Token: 0x04004463 RID: 17507
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_2;

		// Token: 0x04004464 RID: 17508
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x04004465 RID: 17509
		[CompilerGenerated]
		[AccessedThroughProperty("Label_ValidFrom")]
		private Class116 class116_4;

		// Token: 0x04004466 RID: 17510
		[CompilerGenerated]
		[AccessedThroughProperty("label_ValidUntil")]
		private Class116 class116_5;

		// Token: 0x04004467 RID: 17511
		[AccessedThroughProperty("Label7")]
		[CompilerGenerated]
		private Class116 class116_6;

		// Token: 0x04004468 RID: 17512
		[CompilerGenerated]
		[AccessedThroughProperty("FlowLayoutPanel1")]
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x04004469 RID: 17513
		[CompilerGenerated]
		[AccessedThroughProperty("Label_Notes")]
		private Class116 class116_7;

		// Token: 0x0400446A RID: 17514
		[CompilerGenerated]
		[AccessedThroughProperty("Label9")]
		private Class116 class116_8;

		// Token: 0x0400446B RID: 17515
		[AccessedThroughProperty("ListView1")]
		[CompilerGenerated]
		private Control4 control4_0;

		// Token: 0x0400446C RID: 17516
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x0400446D RID: 17517
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x0400446E RID: 17518
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStrip1")]
		private Class125 class125_0;

		// Token: 0x0400446F RID: 17519
		[CompilerGenerated]
		[AccessedThroughProperty("TSL_Loadingtext")]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x04004470 RID: 17520
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_DoNotCheckDBCompatibility")]
		private Class112 class112_0;

		// Token: 0x04004471 RID: 17521
		private ImportExportRecord importExportRecord_0;
	}
}
