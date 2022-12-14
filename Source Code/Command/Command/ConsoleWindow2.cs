using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua.Exceptions;
using ns1;
using ns2;
using ns4;
using ns8;
using ScintillaNET;

namespace Command
{
	// Token: 0x02000E56 RID: 3670
	[DesignerGenerated]
	public sealed partial class ConsoleWindow2 : DarkSecondaryFormBase
	{
		// Token: 0x06006ED7 RID: 28375 RVA: 0x00045F66 File Offset: 0x00044166
		public ConsoleWindow2()
		{
			base.Load += this.ConsoleWindow2_Load;
			base.Closing += new CancelEventHandler(this.ConsoleWindow2_Closing);
			this.bool_3 = false;
			this.InitializeComponent_1();
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x003C0420 File Offset: 0x003BE620
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class119());
			this.vmethod_3(new Class128());
			this.vmethod_5(new Class128());
			this.vmethod_7(new Class128());
			this.vmethod_9(new Class128());
			this.vmethod_11(new Class128());
			this.vmethod_13(new Class128());
			this.vmethod_15(new ToolStripSeparator());
			this.vmethod_17(new Class128());
			this.vmethod_19(new Class128());
			this.vmethod_21(new Class128());
			this.vmethod_23(new ToolStripSeparator());
			this.vmethod_25(new Class128());
			this.vmethod_27(new Class128());
			this.vmethod_29(new ToolStripSeparator());
			this.vmethod_31(new Class128());
			this.vmethod_33(new Class128());
			this.vmethod_83(new Class128());
			this.vmethod_85(new Class128());
			this.vmethod_87(new Class128());
			this.vmethod_89(new Class128());
			this.vmethod_35(new Class128());
			this.vmethod_37(new Class128());
			this.vmethod_39(new Class128());
			this.vmethod_41(new Class128());
			this.vmethod_43(new ToolStripSeparator());
			this.vmethod_45(new Class128());
			this.vmethod_47(new Class128());
			this.vmethod_49(new Class128());
			this.vmethod_51(new Class128());
			this.vmethod_53(new Class128());
			this.vmethod_55(new ToolStripSeparator());
			this.vmethod_57(new Class128());
			this.vmethod_59(new Class128());
			this.vmethod_61(new Class128());
			this.vmethod_63(new ToolStripSeparator());
			this.vmethod_65(new Class128());
			this.vmethod_67(new Class128());
			this.vmethod_69(new Panel());
			this.vmethod_71(new OpenFileDialog());
			this.vmethod_73(new Class124());
			this.vmethod_75(new Control9());
			this.vmethod_77(new Class2451());
			this.vmethod_79(new Control9());
			this.vmethod_81(new Panel());
			this.vmethod_91(new Class112());
			this.vmethod_0().SuspendLayout();
			this.vmethod_80().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().Font = new Font("Segoe UI", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_2(),
				this.vmethod_6(),
				this.vmethod_34(),
				this.vmethod_46()
			});
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "menuStrip1";
			this.vmethod_0().Padding = new Padding(3, 2, 0, 2);
			this.vmethod_0().Size = new Size(1008, 27);
			this.vmethod_0().TabIndex = 3;
			this.vmethod_0().Text = "menuStrip1";
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().DropDownItems.AddRange(new ToolStripItem[]
			{
				this.vmethod_4()
			});
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Name = "fileToolStripMenuItem";
			this.vmethod_2().Size = new Size(41, 23);
			this.vmethod_2().Text = "File";
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Name = "openToolStripMenuItem";
			this.vmethod_4().Size = new Size(121, 24);
			this.vmethod_4().Text = "Open...";
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().DropDownItems.AddRange(new ToolStripItem[]
			{
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_12(),
				this.vmethod_14(),
				this.vmethod_16(),
				this.vmethod_18(),
				this.vmethod_20(),
				this.vmethod_22(),
				this.vmethod_24(),
				this.vmethod_26(),
				this.vmethod_28(),
				this.vmethod_30(),
				this.vmethod_32(),
				this.vmethod_82()
			});
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Name = "editToolStripMenuItem";
			this.vmethod_6().Size = new Size(44, 23);
			this.vmethod_6().Text = "Edit";
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Name = "cutToolStripMenuItem";
			this.vmethod_8().ShortcutKeyDisplayString = "Ctrl+X";
			this.vmethod_8().Size = new Size(204, 24);
			this.vmethod_8().Text = "Cut";
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Name = "copyToolStripMenuItem";
			this.vmethod_10().ShortcutKeyDisplayString = "Ctrl+C";
			this.vmethod_10().Size = new Size(204, 24);
			this.vmethod_10().Text = "Copy";
			this.vmethod_12().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Name = "pasteToolStripMenuItem";
			this.vmethod_12().ShortcutKeyDisplayString = "Ctrl+V";
			this.vmethod_12().Size = new Size(204, 24);
			this.vmethod_12().Text = "Paste";
			this.vmethod_14().Name = "toolStripSeparator1";
			this.vmethod_14().Size = new Size(201, 6);
			this.vmethod_16().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Name = "selectLineToolStripMenuItem";
			this.vmethod_16().Size = new Size(204, 24);
			this.vmethod_16().Text = "Select Line";
			this.vmethod_18().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Name = "selectAllToolStripMenuItem";
			this.vmethod_18().ShortcutKeyDisplayString = "Ctrl+A";
			this.vmethod_18().Size = new Size(204, 24);
			this.vmethod_18().Text = "Select All";
			this.vmethod_20().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Name = "clearSelectionToolStripMenuItem";
			this.vmethod_20().Size = new Size(204, 24);
			this.vmethod_20().Text = "Clear Selection";
			this.vmethod_22().Name = "toolStripSeparator2";
			this.vmethod_22().Size = new Size(201, 6);
			this.vmethod_24().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().Name = "indentSelectionToolStripMenuItem";
			this.vmethod_24().ShortcutKeyDisplayString = "Tab";
			this.vmethod_24().Size = new Size(204, 24);
			this.vmethod_24().Text = "Indent";
			this.vmethod_26().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Name = "outdentSelectionToolStripMenuItem";
			this.vmethod_26().ShortcutKeyDisplayString = "Shift+Tab";
			this.vmethod_26().Size = new Size(204, 24);
			this.vmethod_26().Text = "Outdent";
			this.vmethod_28().Name = "toolStripSeparator3";
			this.vmethod_28().Size = new Size(201, 6);
			this.vmethod_30().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Name = "uppercaseSelectionToolStripMenuItem";
			this.vmethod_30().ShortcutKeyDisplayString = "Ctrl+U";
			this.vmethod_30().Size = new Size(204, 24);
			this.vmethod_30().Text = "Uppercase";
			this.vmethod_32().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_32().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_32().Name = "lowercaseSelectionToolStripMenuItem";
			this.vmethod_32().ShortcutKeyDisplayString = "Ctrl+L";
			this.vmethod_32().Size = new Size(204, 24);
			this.vmethod_32().Text = "Lowercase";
			this.vmethod_82().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_82().DropDownItems.AddRange(new ToolStripItem[]
			{
				this.vmethod_84(),
				this.vmethod_86(),
				this.vmethod_88()
			});
			this.vmethod_82().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_82().Name = "EncloseSelectionInToolStripMenuItem";
			this.vmethod_82().Size = new Size(204, 24);
			this.vmethod_82().Text = "Enclose selection in...";
			this.vmethod_84().Name = "TSMI_EncloseInQuotes";
			this.vmethod_84().Size = new Size(195, 24);
			this.vmethod_84().Text = "Quotes  - \"abc\"";
			this.vmethod_86().Name = "TSMI_EncloseInParentheses";
			this.vmethod_86().Size = new Size(195, 24);
			this.vmethod_86().Text = "Parentheses - (abc)";
			this.vmethod_88().Name = "TSMI_EncloseInBrackets";
			this.vmethod_88().Size = new Size(195, 24);
			this.vmethod_88().Text = "Brackets - {abc}";
			this.vmethod_34().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_34().DropDownItems.AddRange(new ToolStripItem[]
			{
				this.vmethod_36(),
				this.vmethod_38(),
				this.vmethod_40(),
				this.vmethod_42(),
				this.vmethod_44()
			});
			this.vmethod_34().Enabled = false;
			this.vmethod_34().ForeColor = Color.FromArgb(153, 153, 153);
			this.vmethod_34().Name = "searchToolStripMenuItem";
			this.vmethod_34().Size = new Size(61, 23);
			this.vmethod_34().Text = "Search";
			this.vmethod_36().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_36().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_36().Name = "findToolStripMenuItem";
			this.vmethod_36().ShortcutKeyDisplayString = "Ctrl+F";
			this.vmethod_36().Size = new Size(241, 24);
			this.vmethod_36().Text = "Quick Find...";
			this.vmethod_38().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_38().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_38().Name = "findDialogToolStripMenuItem";
			this.vmethod_38().ShortcutKeyDisplayString = "Ctrl+Alt+F";
			this.vmethod_38().Size = new Size(241, 24);
			this.vmethod_38().Text = "Find...";
			this.vmethod_40().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_40().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_40().Name = "findAndReplaceToolStripMenuItem";
			this.vmethod_40().ShortcutKeyDisplayString = "Ctrl+H";
			this.vmethod_40().Size = new Size(241, 24);
			this.vmethod_40().Text = "Find and Replace...";
			this.vmethod_42().Name = "toolStripSeparator7";
			this.vmethod_42().Size = new Size(238, 6);
			this.vmethod_44().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_44().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_44().Name = "goToLineToolStripMenuItem";
			this.vmethod_44().ShortcutKeyDisplayString = "Ctrl+G";
			this.vmethod_44().Size = new Size(241, 24);
			this.vmethod_44().Text = "Go To Line...";
			this.vmethod_46().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_46().DropDownItems.AddRange(new ToolStripItem[]
			{
				this.vmethod_48(),
				this.vmethod_50(),
				this.vmethod_52(),
				this.vmethod_54(),
				this.vmethod_56(),
				this.vmethod_58(),
				this.vmethod_60(),
				this.vmethod_62(),
				this.vmethod_64(),
				this.vmethod_66()
			});
			this.vmethod_46().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_46().Name = "viewToolStripMenuItem";
			this.vmethod_46().Size = new Size(50, 23);
			this.vmethod_46().Text = "View";
			this.vmethod_48().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_48().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_48().Name = "wordWrapItem";
			this.vmethod_48().Size = new Size(221, 24);
			this.vmethod_48().Text = "Word Wrap";
			this.vmethod_50().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_50().Checked = true;
			this.vmethod_50().CheckState = CheckState.Checked;
			this.vmethod_50().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_50().Name = "indentGuidesItem";
			this.vmethod_50().Size = new Size(221, 24);
			this.vmethod_50().Text = "Show Indent Guides";
			this.vmethod_52().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_52().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_52().Name = "hiddenCharactersItem";
			this.vmethod_52().Size = new Size(221, 24);
			this.vmethod_52().Text = "Show Whitespace";
			this.vmethod_54().Name = "toolStripSeparator4";
			this.vmethod_54().Size = new Size(218, 6);
			this.vmethod_56().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_56().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_56().Name = "zoomInToolStripMenuItem";
			this.vmethod_56().ShortcutKeyDisplayString = "Ctrl+Plus";
			this.vmethod_56().Size = new Size(221, 24);
			this.vmethod_56().Text = "Zoom In";
			this.vmethod_58().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_58().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_58().Name = "zoomOutToolStripMenuItem";
			this.vmethod_58().ShortcutKeyDisplayString = "Ctrl+Minus";
			this.vmethod_58().Size = new Size(221, 24);
			this.vmethod_58().Text = "Zoom Out";
			this.vmethod_60().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_60().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_60().Name = "zoom100ToolStripMenuItem";
			this.vmethod_60().ShortcutKeyDisplayString = "Ctrl+0";
			this.vmethod_60().Size = new Size(221, 24);
			this.vmethod_60().Text = "Zoom 100%";
			this.vmethod_62().Name = "toolStripSeparator5";
			this.vmethod_62().Size = new Size(218, 6);
			this.vmethod_64().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_64().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_64().Name = "collapseAllToolStripMenuItem";
			this.vmethod_64().Size = new Size(221, 24);
			this.vmethod_64().Text = "Collapse All";
			this.vmethod_66().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_66().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_66().Name = "expandAllToolStripMenuItem";
			this.vmethod_66().Size = new Size(221, 24);
			this.vmethod_66().Text = "Expand All";
			this.vmethod_68().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_68().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_68().Location = new Point(0, 246);
			this.vmethod_68().Margin = new Padding(3, 4, 3, 4);
			this.vmethod_68().Name = "TextPanel";
			this.vmethod_68().Size = new Size(1008, 483);
			this.vmethod_68().TabIndex = 11;
			this.vmethod_70().FileName = "OpenFileDialog1";
			this.vmethod_72().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_72().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_72().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_72().Location = new Point(0, 30);
			this.vmethod_72().Multiline = true;
			this.vmethod_72().Name = "TextBox1";
			this.vmethod_72().Size = new Size(1008, 178);
			this.vmethod_72().TabIndex = 12;
			this.vmethod_74().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_74().BackColor = Color.Transparent;
			this.vmethod_74().DialogResult = DialogResult.None;
			this.vmethod_74().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_74().ForeColor = SystemColors.Control;
			this.vmethod_74().Location = new Point(615, 0);
			this.vmethod_74().Name = "Button_InsertScript";
			this.vmethod_74().method_1(0);
			this.vmethod_74().Size = new Size(67, 23);
			this.vmethod_74().TabIndex = 14;
			this.vmethod_74().Text = "Insert";
			this.vmethod_76().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_76().BackColor = Color.Transparent;
			this.vmethod_76().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_76().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_76().Font = new Font("Lucida Console", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_76().FormattingEnabled = true;
			this.vmethod_76().Location = new Point(3, 0);
			this.vmethod_76().Name = "ComboBox1";
			this.vmethod_76().Size = new Size(606, 21);
			this.vmethod_76().TabIndex = 13;
			this.vmethod_78().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_78().BackColor = Color.Transparent;
			this.vmethod_78().DialogResult = DialogResult.None;
			this.vmethod_78().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_78().ForeColor = Color.LightGreen;
			this.vmethod_78().Location = new Point(929, 0);
			this.vmethod_78().Name = "Button_Run";
			this.vmethod_78().method_1(0);
			this.vmethod_78().Size = new Size(79, 23);
			this.vmethod_78().TabIndex = 15;
			this.vmethod_78().Text = "RUN";
			this.vmethod_80().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_80().Controls.Add(this.vmethod_90());
			this.vmethod_80().Controls.Add(this.vmethod_78());
			this.vmethod_80().Controls.Add(this.vmethod_76());
			this.vmethod_80().Controls.Add(this.vmethod_74());
			this.vmethod_80().Location = new Point(0, 216);
			this.vmethod_80().Name = "Panel1";
			this.vmethod_80().Size = new Size(1008, 23);
			this.vmethod_80().TabIndex = 13;
			this.vmethod_90().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_90().AutoSize = true;
			this.vmethod_90().Checked = true;
			this.vmethod_90().CheckState = CheckState.Checked;
			this.vmethod_90().Location = new Point(724, 3);
			this.vmethod_90().Name = "CB_EchoInput";
			this.vmethod_90().Size = new Size(171, 17);
			this.vmethod_90().TabIndex = 16;
			this.vmethod_90().Text = "Echo input script on result text ";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1008, 729);
			base.Controls.Add(this.vmethod_80());
			base.Controls.Add(this.vmethod_72());
			base.Controls.Add(this.vmethod_68());
			base.Controls.Add(this.vmethod_0());
			base.Name = "ConsoleWindow2";
			this.Text = "Lua Console v2";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			this.vmethod_80().ResumeLayout(false);
			this.vmethod_80().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x00045F9F File Offset: 0x0004419F
		[CompilerGenerated]
		private Class119 vmethod_0()
		{
			return this.class119_0;
		}

		// Token: 0x06006EDB RID: 28379 RVA: 0x00045FA7 File Offset: 0x000441A7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_1(Class119 class119_1)
		{
			this.class119_0 = class119_1;
		}

		// Token: 0x06006EDC RID: 28380 RVA: 0x00045FB0 File Offset: 0x000441B0
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_2()
		{
			return this.toolStripMenuItem_0;
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x00045FB8 File Offset: 0x000441B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_3(ToolStripMenuItem toolStripMenuItem_31)
		{
			this.toolStripMenuItem_0 = toolStripMenuItem_31;
		}

		// Token: 0x06006EDE RID: 28382 RVA: 0x00045FC1 File Offset: 0x000441C1
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_4()
		{
			return this.toolStripMenuItem_1;
		}

		// Token: 0x06006EDF RID: 28383 RVA: 0x003C1C7C File Offset: 0x003BFE7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_5(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_27);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_1 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006EE0 RID: 28384 RVA: 0x00045FC9 File Offset: 0x000441C9
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_6()
		{
			return this.toolStripMenuItem_2;
		}

		// Token: 0x06006EE1 RID: 28385 RVA: 0x00045FD1 File Offset: 0x000441D1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_7(ToolStripMenuItem toolStripMenuItem_31)
		{
			this.toolStripMenuItem_2 = toolStripMenuItem_31;
		}

		// Token: 0x06006EE2 RID: 28386 RVA: 0x00045FDA File Offset: 0x000441DA
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_8()
		{
			return this.toolStripMenuItem_3;
		}

		// Token: 0x06006EE3 RID: 28387 RVA: 0x003C1CC0 File Offset: 0x003BFEC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_9(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_28);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_3;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_3 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_3;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x00045FE2 File Offset: 0x000441E2
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_10()
		{
			return this.toolStripMenuItem_4;
		}

		// Token: 0x06006EE5 RID: 28389 RVA: 0x003C1D04 File Offset: 0x003BFF04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_11(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_29);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_4;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_4 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_4;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006EE6 RID: 28390 RVA: 0x00045FEA File Offset: 0x000441EA
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_12()
		{
			return this.toolStripMenuItem_5;
		}

		// Token: 0x06006EE7 RID: 28391 RVA: 0x003C1D48 File Offset: 0x003BFF48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_13(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_30);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_5;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_5 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_5;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x00045FF2 File Offset: 0x000441F2
		[CompilerGenerated]
		private ToolStripSeparator vmethod_14()
		{
			return this.toolStripSeparator_0;
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x00045FFA File Offset: 0x000441FA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_15(ToolStripSeparator toolStripSeparator_6)
		{
			this.toolStripSeparator_0 = toolStripSeparator_6;
		}

		// Token: 0x06006EEA RID: 28394 RVA: 0x00046003 File Offset: 0x00044203
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_16()
		{
			return this.toolStripMenuItem_6;
		}

		// Token: 0x06006EEB RID: 28395 RVA: 0x003C1D8C File Offset: 0x003BFF8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_17(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_31);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_6;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_6 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_6;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x0004600B File Offset: 0x0004420B
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_18()
		{
			return this.toolStripMenuItem_7;
		}

		// Token: 0x06006EED RID: 28397 RVA: 0x003C1DD0 File Offset: 0x003BFFD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_19(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_32);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_7;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_7 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_7;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006EEE RID: 28398 RVA: 0x00046013 File Offset: 0x00044213
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_20()
		{
			return this.toolStripMenuItem_8;
		}

		// Token: 0x06006EEF RID: 28399 RVA: 0x003C1E14 File Offset: 0x003C0014
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_21(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_33);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_8;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_8 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_8;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006EF0 RID: 28400 RVA: 0x0004601B File Offset: 0x0004421B
		[CompilerGenerated]
		private ToolStripSeparator vmethod_22()
		{
			return this.toolStripSeparator_1;
		}

		// Token: 0x06006EF1 RID: 28401 RVA: 0x00046023 File Offset: 0x00044223
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_23(ToolStripSeparator toolStripSeparator_6)
		{
			this.toolStripSeparator_1 = toolStripSeparator_6;
		}

		// Token: 0x06006EF2 RID: 28402 RVA: 0x0004602C File Offset: 0x0004422C
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_24()
		{
			return this.toolStripMenuItem_9;
		}

		// Token: 0x06006EF3 RID: 28403 RVA: 0x003C1E58 File Offset: 0x003C0058
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_25(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_34);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_9;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_9 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_9;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006EF4 RID: 28404 RVA: 0x00046034 File Offset: 0x00044234
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_26()
		{
			return this.toolStripMenuItem_10;
		}

		// Token: 0x06006EF5 RID: 28405 RVA: 0x003C1E9C File Offset: 0x003C009C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_27(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_35);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_10;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_10 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_10;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006EF6 RID: 28406 RVA: 0x0004603C File Offset: 0x0004423C
		[CompilerGenerated]
		private ToolStripSeparator vmethod_28()
		{
			return this.toolStripSeparator_2;
		}

		// Token: 0x06006EF7 RID: 28407 RVA: 0x00046044 File Offset: 0x00044244
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_29(ToolStripSeparator toolStripSeparator_6)
		{
			this.toolStripSeparator_2 = toolStripSeparator_6;
		}

		// Token: 0x06006EF8 RID: 28408 RVA: 0x0004604D File Offset: 0x0004424D
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_30()
		{
			return this.toolStripMenuItem_11;
		}

		// Token: 0x06006EF9 RID: 28409 RVA: 0x003C1EE0 File Offset: 0x003C00E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_31(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_36);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_11;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_11 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_11;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x00046055 File Offset: 0x00044255
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_32()
		{
			return this.toolStripMenuItem_12;
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x003C1F24 File Offset: 0x003C0124
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_33(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_37);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_12;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_12 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_12;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x0004605D File Offset: 0x0004425D
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_34()
		{
			return this.toolStripMenuItem_13;
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x00046065 File Offset: 0x00044265
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_35(ToolStripMenuItem toolStripMenuItem_31)
		{
			this.toolStripMenuItem_13 = toolStripMenuItem_31;
		}

		// Token: 0x06006EFE RID: 28414 RVA: 0x0004606E File Offset: 0x0004426E
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_36()
		{
			return this.toolStripMenuItem_14;
		}

		// Token: 0x06006EFF RID: 28415 RVA: 0x00046076 File Offset: 0x00044276
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_37(ToolStripMenuItem toolStripMenuItem_31)
		{
			this.toolStripMenuItem_14 = toolStripMenuItem_31;
		}

		// Token: 0x06006F00 RID: 28416 RVA: 0x0004607F File Offset: 0x0004427F
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_38()
		{
			return this.toolStripMenuItem_15;
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x00046087 File Offset: 0x00044287
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_39(ToolStripMenuItem toolStripMenuItem_31)
		{
			this.toolStripMenuItem_15 = toolStripMenuItem_31;
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x00046090 File Offset: 0x00044290
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_40()
		{
			return this.toolStripMenuItem_16;
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x00046098 File Offset: 0x00044298
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_41(ToolStripMenuItem toolStripMenuItem_31)
		{
			this.toolStripMenuItem_16 = toolStripMenuItem_31;
		}

		// Token: 0x06006F04 RID: 28420 RVA: 0x000460A1 File Offset: 0x000442A1
		[CompilerGenerated]
		private ToolStripSeparator vmethod_42()
		{
			return this.toolStripSeparator_3;
		}

		// Token: 0x06006F05 RID: 28421 RVA: 0x000460A9 File Offset: 0x000442A9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_43(ToolStripSeparator toolStripSeparator_6)
		{
			this.toolStripSeparator_3 = toolStripSeparator_6;
		}

		// Token: 0x06006F06 RID: 28422 RVA: 0x000460B2 File Offset: 0x000442B2
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_44()
		{
			return this.toolStripMenuItem_17;
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x000460BA File Offset: 0x000442BA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_45(ToolStripMenuItem toolStripMenuItem_31)
		{
			this.toolStripMenuItem_17 = toolStripMenuItem_31;
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x000460C3 File Offset: 0x000442C3
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_46()
		{
			return this.toolStripMenuItem_18;
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x000460CB File Offset: 0x000442CB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_47(ToolStripMenuItem toolStripMenuItem_31)
		{
			this.toolStripMenuItem_18 = toolStripMenuItem_31;
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x000460D4 File Offset: 0x000442D4
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_48()
		{
			return this.toolStripMenuItem_19;
		}

		// Token: 0x06006F0B RID: 28427 RVA: 0x003C1F68 File Offset: 0x003C0168
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_49(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_38);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_19;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_19 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_19;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x000460DC File Offset: 0x000442DC
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_50()
		{
			return this.toolStripMenuItem_20;
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x003C1FAC File Offset: 0x003C01AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_51(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_39);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_20;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_20 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_20;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006F0E RID: 28430 RVA: 0x000460E4 File Offset: 0x000442E4
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_52()
		{
			return this.toolStripMenuItem_21;
		}

		// Token: 0x06006F0F RID: 28431 RVA: 0x003C1FF0 File Offset: 0x003C01F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_53(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_40);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_21;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_21 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_21;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006F10 RID: 28432 RVA: 0x000460EC File Offset: 0x000442EC
		[CompilerGenerated]
		private ToolStripSeparator vmethod_54()
		{
			return this.toolStripSeparator_4;
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x000460F4 File Offset: 0x000442F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_55(ToolStripSeparator toolStripSeparator_6)
		{
			this.toolStripSeparator_4 = toolStripSeparator_6;
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x000460FD File Offset: 0x000442FD
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_56()
		{
			return this.toolStripMenuItem_22;
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x003C2034 File Offset: 0x003C0234
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_57(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_41);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_22;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_22 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_22;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x00046105 File Offset: 0x00044305
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_58()
		{
			return this.toolStripMenuItem_23;
		}

		// Token: 0x06006F15 RID: 28437 RVA: 0x003C2078 File Offset: 0x003C0278
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_59(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_42);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_23;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_23 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_23;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006F16 RID: 28438 RVA: 0x0004610D File Offset: 0x0004430D
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_60()
		{
			return this.toolStripMenuItem_24;
		}

		// Token: 0x06006F17 RID: 28439 RVA: 0x003C20BC File Offset: 0x003C02BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_61(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_43);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_24;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_24 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_24;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006F18 RID: 28440 RVA: 0x00046115 File Offset: 0x00044315
		[CompilerGenerated]
		private ToolStripSeparator vmethod_62()
		{
			return this.toolStripSeparator_5;
		}

		// Token: 0x06006F19 RID: 28441 RVA: 0x0004611D File Offset: 0x0004431D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_63(ToolStripSeparator toolStripSeparator_6)
		{
			this.toolStripSeparator_5 = toolStripSeparator_6;
		}

		// Token: 0x06006F1A RID: 28442 RVA: 0x00046126 File Offset: 0x00044326
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_64()
		{
			return this.toolStripMenuItem_25;
		}

		// Token: 0x06006F1B RID: 28443 RVA: 0x003C2100 File Offset: 0x003C0300
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_65(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_44);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_25;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_25 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_25;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006F1C RID: 28444 RVA: 0x0004612E File Offset: 0x0004432E
		[CompilerGenerated]
		private ToolStripMenuItem vmethod_66()
		{
			return this.toolStripMenuItem_26;
		}

		// Token: 0x06006F1D RID: 28445 RVA: 0x003C2144 File Offset: 0x003C0344
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_67(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_45);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_26;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_26 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_26;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x00046136 File Offset: 0x00044336
		[CompilerGenerated]
		private Panel vmethod_68()
		{
			return this.panel_0;
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x0004613E File Offset: 0x0004433E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_69(Panel panel_2)
		{
			this.panel_0 = panel_2;
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x00046147 File Offset: 0x00044347
		[CompilerGenerated]
		internal OpenFileDialog vmethod_70()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x0004614F File Offset: 0x0004434F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x06006F22 RID: 28450 RVA: 0x00046158 File Offset: 0x00044358
		[CompilerGenerated]
		internal Class124 vmethod_72()
		{
			return this.class124_0;
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x00046160 File Offset: 0x00044360
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(Class124 class124_1)
		{
			this.class124_0 = class124_1;
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x00046169 File Offset: 0x00044369
		[CompilerGenerated]
		internal Control9 vmethod_74()
		{
			return this.control9_0;
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x003C2188 File Offset: 0x003C0388
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_47);
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

		// Token: 0x06006F26 RID: 28454 RVA: 0x00046171 File Offset: 0x00044371
		[CompilerGenerated]
		internal Class2451 vmethod_76()
		{
			return this.class2451_0;
		}

		// Token: 0x06006F27 RID: 28455 RVA: 0x00046179 File Offset: 0x00044379
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Class2451 class2451_1)
		{
			this.class2451_0 = class2451_1;
		}

		// Token: 0x06006F28 RID: 28456 RVA: 0x00046182 File Offset: 0x00044382
		[CompilerGenerated]
		internal Control9 vmethod_78()
		{
			return this.control9_1;
		}

		// Token: 0x06006F29 RID: 28457 RVA: 0x003C21CC File Offset: 0x003C03CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_46);
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

		// Token: 0x06006F2A RID: 28458 RVA: 0x0004618A File Offset: 0x0004438A
		[CompilerGenerated]
		internal Panel vmethod_80()
		{
			return this.panel_1;
		}

		// Token: 0x06006F2B RID: 28459 RVA: 0x00046192 File Offset: 0x00044392
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(Panel panel_2)
		{
			this.panel_1 = panel_2;
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x0004619B File Offset: 0x0004439B
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_82()
		{
			return this.toolStripMenuItem_27;
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x000461A3 File Offset: 0x000443A3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(ToolStripMenuItem toolStripMenuItem_31)
		{
			this.toolStripMenuItem_27 = toolStripMenuItem_31;
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x000461AC File Offset: 0x000443AC
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_84()
		{
			return this.toolStripMenuItem_28;
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x003C2210 File Offset: 0x003C0410
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_48);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_28;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_28 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_28;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x000461B4 File Offset: 0x000443B4
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_86()
		{
			return this.toolStripMenuItem_29;
		}

		// Token: 0x06006F31 RID: 28465 RVA: 0x003C2254 File Offset: 0x003C0454
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_50);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_29;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_29 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_29;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006F32 RID: 28466 RVA: 0x000461BC File Offset: 0x000443BC
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_88()
		{
			return this.toolStripMenuItem_30;
		}

		// Token: 0x06006F33 RID: 28467 RVA: 0x003C2298 File Offset: 0x003C0498
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(ToolStripMenuItem toolStripMenuItem_31)
		{
			EventHandler value = new EventHandler(this.method_51);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_30;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_30 = toolStripMenuItem_31;
			toolStripMenuItem = this.toolStripMenuItem_30;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06006F34 RID: 28468 RVA: 0x000461C4 File Offset: 0x000443C4
		[CompilerGenerated]
		internal Class112 vmethod_90()
		{
			return this.class112_0;
		}

		// Token: 0x06006F35 RID: 28469 RVA: 0x000461CC File Offset: 0x000443CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(Class112 class112_1)
		{
			this.class112_0 = class112_1;
		}

		// Token: 0x06006F36 RID: 28470 RVA: 0x000461D5 File Offset: 0x000443D5
		[CompilerGenerated]
		private Scintilla vmethod_92()
		{
			return this.scintilla_0;
		}

		// Token: 0x06006F37 RID: 28471 RVA: 0x003C22DC File Offset: 0x003C04DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_93(Scintilla scintilla_1)
		{
			DragEventHandler value = new DragEventHandler(this.method_16);
			DragEventHandler value2 = new DragEventHandler(this.method_17);
			Scintilla scintilla = this.scintilla_0;
			if (scintilla != null)
			{
				scintilla.DragEnter -= value;
				scintilla.DragDrop -= value2;
			}
			this.scintilla_0 = scintilla_1;
			scintilla = this.scintilla_0;
			if (scintilla != null)
			{
				scintilla.DragEnter += value;
				scintilla.DragDrop += value2;
			}
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x003C233C File Offset: 0x003C053C
		private void ConsoleWindow2_Load(object sender, EventArgs e)
		{
			this.vmethod_93(new Scintilla());
			this.vmethod_68().Controls.Add(this.vmethod_92());
			this.vmethod_92().Dock = DockStyle.Fill;
			this.vmethod_92().WrapMode = WrapMode.None;
			this.vmethod_92().IndentationGuides = IndentView.LookBoth;
			this.method_4();
			this.method_6();
			this.method_7();
			this.method_8();
			this.method_9();
			this.method_15();
			this.method_5();
			this.luaSandBox_0 = Client.smethod_46().method_10();
			this.vmethod_72().AppendText("Lua version: " + this.luaSandBox_0.RunScript("_VERSION", true, null)[0].ToString());
			this.vmethod_76().Items.AddRange(Enumerable.ToArray<string>(Enumerable.OrderBy<string, string>(LuaSandBox.LuaMethods, (ConsoleWindow2._Closure$__.$I193-0 == null) ? (ConsoleWindow2._Closure$__.$I193-0 = new Func<string, string>(ConsoleWindow2._Closure$__.$I.method_0)) : ConsoleWindow2._Closure$__.$I193-0)));
			this.vmethod_76().SelectedIndex = 0;
			this.luaSandBox_0.LuaPrint += this.luaSandBox_0_LuaPrint;
			Client.smethod_13(new Client.Delegate77(this.method_3));
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_3()
		{
			base.Close();
		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x003C2470 File Offset: 0x003C0670
		private void luaSandBox_0_LuaPrint(object object_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(object_0)));
			if (this.luaSandBox_0.RunInteractive)
			{
				try
				{
					this.vmethod_72().AppendText("\r\n" + stringBuilder.ToString());
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06006F3B RID: 28475 RVA: 0x000461DD File Offset: 0x000443DD
		private void method_4()
		{
			this.vmethod_92().SetSelectionBackColor(true, ConsoleWindow2.smethod_0(1133980));
		}

		// Token: 0x06006F3C RID: 28476 RVA: 0x003C24DC File Offset: 0x003C06DC
		private void method_5()
		{
			Class53.smethod_0(this, new Action(this.method_11), Keys.F, true, false, false);
			Class53.smethod_0(this, new Action(this.method_13), Keys.F, true, false, true);
			Class53.smethod_0(this, new Action(this.method_14), Keys.R, true, false, false);
			Class53.smethod_0(this, new Action(this.method_14), Keys.H, true, false, false);
			Class53.smethod_0(this, new Action(this.method_20), Keys.U, true, false, false);
			Class53.smethod_0(this, new Action(this.method_19), Keys.L, true, false, false);
			Class53.smethod_0(this, new Action(this.method_24), Keys.Oemplus, true, false, false);
			Class53.smethod_0(this, new Action(this.method_25), Keys.OemMinus, true, false, false);
			Class53.smethod_0(this, new Action(this.method_26), Keys.D0, true, false, false);
			Class53.smethod_0(this, new Action(this.method_12), Keys.Escape, false, false, false);
			this.vmethod_92().ClearCmdKey((Keys)131142);
			this.vmethod_92().ClearCmdKey((Keys)131154);
			this.vmethod_92().ClearCmdKey((Keys)131144);
			this.vmethod_92().ClearCmdKey((Keys)131148);
			this.vmethod_92().ClearCmdKey((Keys)131157);
		}

		// Token: 0x06006F3D RID: 28477 RVA: 0x003C2628 File Offset: 0x003C0828
		private void method_6()
		{
			string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
			string str2 = "0123456789";
			string str3 = "ŠšŒœŸÿÀàÁáÂâÃãÄäÅåÆæÇçÈèÉéÊêËëÌìÍíÎîÏïÐðÑñÒòÓóÔôÕõÖØøÙùÚúÛûÜüÝýÞþßö";
			this.vmethod_92().StyleResetDefault();
			this.vmethod_92().Styles[32].Font = "Consolas";
			this.vmethod_92().Styles[32].Size = 10;
			this.vmethod_92().StyleClearAll();
			this.vmethod_92().Styles[0].ForeColor = Color.Silver;
			this.vmethod_92().Styles[1].ForeColor = Color.LightGreen;
			this.vmethod_92().Styles[2].ForeColor = Color.LightGreen;
			this.vmethod_92().Styles[4].ForeColor = Color.Olive;
			this.vmethod_92().Styles[5].ForeColor = Color.Blue;
			this.vmethod_92().Styles[13].ForeColor = Color.BlueViolet;
			this.vmethod_92().Styles[14].ForeColor = Color.DarkSlateBlue;
			this.vmethod_92().Styles[15].ForeColor = Color.DarkSlateBlue;
			this.vmethod_92().Styles[6].ForeColor = Color.Red;
			this.vmethod_92().Styles[7].ForeColor = Color.Red;
			this.vmethod_92().Styles[8].ForeColor = Color.Red;
			this.vmethod_92().Styles[12].BackColor = Color.Pink;
			this.vmethod_92().Styles[10].ForeColor = Color.Purple;
			this.vmethod_92().Styles[9].ForeColor = Color.Maroon;
			this.vmethod_92().Lexer = Lexer.Lua;
			this.vmethod_92().WordChars = str + str2 + str3;
			this.vmethod_92().SetKeywords(0, "and break do else elseif end for function if in local nil not or repeat return then until while false true goto");
			this.vmethod_92().SetKeywords(1, "assert collectgarbage dofile error _G getmetatable ipairs loadfile next pairs pcall print rawequal rawget rawset setmetatable tonumber tostring type _VERSION xpcall string table math coroutine io os debug getfenv gcinfo load loadlib loadstring require select setfenv unpack _LOADED LUA_PATH _REQUIREDNAME package rawlen package bit32 utf8 _ENV");
			this.vmethod_92().SetKeywords(2, "string.byte string.char string.dump string.find string.format string.gsub string.len string.lower string.rep string.sub string.upper table.concat table.insert table.remove table.sort math.abs math.acos math.asin math.atan math.atan2 math.ceil math.cos math.deg math.exp math.floor math.frexp math.ldexp math.log math.max math.min math.pi math.pow math.rad math.random math.randomseed math.sin math.sqrt math.tan string.gfind string.gmatch string.match string.reverse string.pack string.packsize string.unpack table.foreach table.foreachi table.getn table.setn table.maxn table.pack table.unpack table.move math.cosh math.fmod math.huge math.log10 math.modf math.mod math.sinh math.tanh math.maxinteger math.mininteger math.tointeger math.type math.ult bit32.arshift bit32.band bit32.bnot bit32.bor bit32.btest bit32.bxor bit32.extract bit32.replace bit32.lrotate bit32.lshift bit32.rrotate bit32.rshift utf8.char utf8.charpattern utf8.codes utf8.codepoint utf8.len utf8.offset");
			this.vmethod_92().SetKeywords(3, "coroutine.create coroutine.resume coroutine.status coroutine.wrap coroutine.yield io.close io.flush io.input io.lines io.open io.output io.read io.tmpfile io.type io.write io.stdin io.stdout io.stderr os.clock os.date os.difftime os.execute os.exit os.getenv os.remove os.rename os.setlocale os.time os.tmpname coroutine.isyieldable coroutine.running io.popen module package.loaders package.seeall package.config package.searchers package.searchpath require package.cpath package.loaded package.loadlib package.path package.preload");
			this.vmethod_92().SetProperty("fold", "1");
			this.vmethod_92().SetProperty("fold.compact", "1");
			this.vmethod_92().Margins[2].Type = MarginType.Symbol;
			this.vmethod_92().Margins[2].Mask = 4261412864U;
			this.vmethod_92().Margins[2].Sensitive = true;
			this.vmethod_92().Margins[2].Width = 20;
			int num = 25;
			do
			{
				this.vmethod_92().Markers[num].SetForeColor(SystemColors.ControlLightLight);
				this.vmethod_92().Markers[num].SetBackColor(SystemColors.ControlDark);
				num++;
			}
			while (num <= 31);
			this.vmethod_92().Markers[30].Symbol = MarkerSymbol.BoxPlus;
			this.vmethod_92().Markers[31].Symbol = MarkerSymbol.BoxMinus;
			this.vmethod_92().Markers[25].Symbol = MarkerSymbol.BoxPlusConnected;
			this.vmethod_92().Markers[27].Symbol = MarkerSymbol.TCorner;
			this.vmethod_92().Markers[26].Symbol = MarkerSymbol.BoxMinusConnected;
			this.vmethod_92().Markers[29].Symbol = MarkerSymbol.VLine;
			this.vmethod_92().Markers[28].Symbol = MarkerSymbol.LCorner;
			this.vmethod_92().AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x003C2A00 File Offset: 0x003C0C00
		private void method_7()
		{
			this.vmethod_92().Styles[33].BackColor = ConsoleWindow2.smethod_0(2760988);
			this.vmethod_92().Styles[33].ForeColor = ConsoleWindow2.smethod_0(12040119);
			this.vmethod_92().Styles[37].ForeColor = ConsoleWindow2.smethod_0(12040119);
			this.vmethod_92().Styles[37].BackColor = ConsoleWindow2.smethod_0(2760988);
			Margin margin = this.vmethod_92().Margins[1];
			margin.Width = 30;
			margin.Type = MarginType.Number;
			margin.Sensitive = true;
			margin.Mask = 0U;
			this.vmethod_92().MarginClick += this.method_10;
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x003C2AD8 File Offset: 0x003C0CD8
		private void method_8()
		{
			Margin margin = this.vmethod_92().Margins[2];
			margin.Width = 20;
			margin.Sensitive = true;
			margin.Type = MarginType.Symbol;
			margin.Mask = 4U;
			Marker marker = this.vmethod_92().Markers[2];
			marker.Symbol = MarkerSymbol.Circle;
			marker.SetBackColor(ConsoleWindow2.smethod_0(16711739));
			marker.SetForeColor(ConsoleWindow2.smethod_0(0));
			marker.SetAlpha(100);
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x003C2B50 File Offset: 0x003C0D50
		private void method_9()
		{
			this.vmethod_92().SetFoldMarginColor(true, ConsoleWindow2.smethod_0(2760988));
			this.vmethod_92().SetFoldMarginHighlightColor(true, ConsoleWindow2.smethod_0(2760988));
			this.vmethod_92().SetProperty("fold", "1");
			this.vmethod_92().SetProperty("fold.compact", "1");
			this.vmethod_92().Margins[3].Type = MarginType.Symbol;
			this.vmethod_92().Margins[3].Mask = 4261412864U;
			this.vmethod_92().Margins[3].Sensitive = true;
			this.vmethod_92().Margins[3].Width = 20;
			int num = 25;
			do
			{
				this.vmethod_92().Markers[num].SetForeColor(ConsoleWindow2.smethod_0(2760988));
				this.vmethod_92().Markers[num].SetBackColor(ConsoleWindow2.smethod_0(12040119));
				num++;
			}
			while (num <= 31);
			this.vmethod_92().Markers[30].Symbol = MarkerSymbol.CirclePlus;
			this.vmethod_92().Markers[31].Symbol = MarkerSymbol.CircleMinus;
			this.vmethod_92().Markers[25].Symbol = MarkerSymbol.CirclePlusConnected;
			this.vmethod_92().Markers[27].Symbol = MarkerSymbol.TCorner;
			this.vmethod_92().Markers[26].Symbol = MarkerSymbol.CircleMinusConnected;
			this.vmethod_92().Markers[29].Symbol = MarkerSymbol.VLine;
			this.vmethod_92().Markers[28].Symbol = MarkerSymbol.LCorner;
			this.vmethod_92().AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x003C2D1C File Offset: 0x003C0F1C
		private void method_10(object sender, MarginClickEventArgs e)
		{
			if (e.Margin == 2)
			{
				Line line = this.vmethod_92().Lines[this.vmethod_92().LineFromPosition(e.Position)];
				if ((ulong)(line.MarkerGet() & 4U) > 0UL)
				{
					line.MarkerDelete(2);
					return;
				}
				line.MarkerAdd(2);
			}
		}

		// Token: 0x06006F42 RID: 28482 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_11()
		{
		}

		// Token: 0x06006F43 RID: 28483 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_12()
		{
		}

		// Token: 0x06006F44 RID: 28484 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_13()
		{
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_14()
		{
		}

		// Token: 0x06006F46 RID: 28486 RVA: 0x000461F5 File Offset: 0x000443F5
		public void method_15()
		{
			this.vmethod_92().AllowDrop = true;
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x00046203 File Offset: 0x00044403
		private void method_16(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
				return;
			}
			e.Effect = DragDropEffects.None;
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x003C2D78 File Offset: 0x003C0F78
		private void method_17(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				Array array = (Array)e.Data.GetData(DataFormats.FileDrop);
				if (array != null)
				{
					string string_ = array.GetValue(0).ToString();
					this.method_18(string_);
				}
			}
		}

		// Token: 0x06006F49 RID: 28489 RVA: 0x00046226 File Offset: 0x00044426
		private void method_18(string string_0)
		{
			if (File.Exists(string_0))
			{
				this.vmethod_92().Text = File.ReadAllText(string_0);
			}
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x003C2DC4 File Offset: 0x003C0FC4
		private void method_19()
		{
			int selectionStart = this.vmethod_92().SelectionStart;
			int selectionEnd = this.vmethod_92().SelectionEnd;
			this.vmethod_92().ReplaceSelection(this.vmethod_92().GetTextRange(selectionStart, selectionEnd - selectionStart).ToLower());
			this.vmethod_92().SetSelection(selectionStart, selectionEnd);
		}

		// Token: 0x06006F4B RID: 28491 RVA: 0x003C2E18 File Offset: 0x003C1018
		private void method_20()
		{
			int selectionStart = this.vmethod_92().SelectionStart;
			int selectionEnd = this.vmethod_92().SelectionEnd;
			this.vmethod_92().ReplaceSelection(this.vmethod_92().GetTextRange(selectionStart, selectionEnd - selectionStart).ToUpper());
			this.vmethod_92().SetSelection(selectionStart, selectionEnd);
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x00046241 File Offset: 0x00044441
		private void method_21()
		{
			this.method_23("{TAB}");
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x0004624E File Offset: 0x0004444E
		private void method_22()
		{
			this.method_23("+{TAB}");
		}

		// Token: 0x06006F4E RID: 28494 RVA: 0x0004625B File Offset: 0x0004445B
		private void method_23(string string_0)
		{
			Class53.bool_0 = false;
			this.vmethod_92().Focus();
			SendKeys.Send(string_0);
			Class53.bool_0 = true;
		}

		// Token: 0x06006F4F RID: 28495 RVA: 0x0004627B File Offset: 0x0004447B
		private void method_24()
		{
			this.vmethod_92().ZoomIn();
		}

		// Token: 0x06006F50 RID: 28496 RVA: 0x00046288 File Offset: 0x00044488
		private void method_25()
		{
			this.vmethod_92().ZoomOut();
		}

		// Token: 0x06006F51 RID: 28497 RVA: 0x00046295 File Offset: 0x00044495
		private void method_26()
		{
			this.vmethod_92().Zoom = 0;
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x000462A3 File Offset: 0x000444A3
		private void method_27(object sender, EventArgs e)
		{
			if (this.vmethod_70().ShowDialog() == DialogResult.OK)
			{
				this.method_18(this.vmethod_70().FileName);
			}
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x000462C4 File Offset: 0x000444C4
		public static Color smethod_0(int int_0)
		{
			return Color.FromArgb(int_0);
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x000462CC File Offset: 0x000444CC
		private void method_28(object sender, EventArgs e)
		{
			this.vmethod_92().Cut();
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x000462D9 File Offset: 0x000444D9
		private void method_29(object sender, EventArgs e)
		{
			this.vmethod_92().Copy();
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x000462E6 File Offset: 0x000444E6
		private void method_30(object sender, EventArgs e)
		{
			this.vmethod_92().Paste();
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x003C2E6C File Offset: 0x003C106C
		private void method_31(object sender, EventArgs e)
		{
			Line line = this.vmethod_92().Lines[this.vmethod_92().CurrentLine];
			this.vmethod_92().SetSelection(line.Position + line.Length, line.Position);
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x000462F3 File Offset: 0x000444F3
		private void method_32(object sender, EventArgs e)
		{
			this.vmethod_92().SelectAll();
		}

		// Token: 0x06006F59 RID: 28505 RVA: 0x00046300 File Offset: 0x00044500
		private void method_33(object sender, EventArgs e)
		{
			this.vmethod_92().SetEmptySelection(0);
		}

		// Token: 0x06006F5A RID: 28506 RVA: 0x0004630E File Offset: 0x0004450E
		private void method_34(object sender, EventArgs e)
		{
			this.method_21();
		}

		// Token: 0x06006F5B RID: 28507 RVA: 0x00046316 File Offset: 0x00044516
		private void method_35(object sender, EventArgs e)
		{
			this.method_22();
		}

		// Token: 0x06006F5C RID: 28508 RVA: 0x0004631E File Offset: 0x0004451E
		private void method_36(object sender, EventArgs e)
		{
			this.method_20();
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x00046326 File Offset: 0x00044526
		private void method_37(object sender, EventArgs e)
		{
			this.method_19();
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x0004632E File Offset: 0x0004452E
		private void method_38(object sender, EventArgs e)
		{
			this.vmethod_48().Checked = !this.vmethod_48().Checked;
			this.vmethod_92().WrapMode = (this.vmethod_48().Checked ? WrapMode.Word : WrapMode.None);
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x00046365 File Offset: 0x00044565
		private void method_39(object sender, EventArgs e)
		{
			this.vmethod_50().Checked = !this.vmethod_50().Checked;
			this.vmethod_92().IndentationGuides = (this.vmethod_50().Checked ? IndentView.LookBoth : IndentView.None);
		}

		// Token: 0x06006F60 RID: 28512 RVA: 0x0004639C File Offset: 0x0004459C
		private void method_40(object sender, EventArgs e)
		{
			this.vmethod_52().Checked = !this.vmethod_52().Checked;
			this.vmethod_92().ViewWhitespace = (this.vmethod_52().Checked ? WhitespaceMode.VisibleAlways : WhitespaceMode.Invisible);
		}

		// Token: 0x06006F61 RID: 28513 RVA: 0x000463D3 File Offset: 0x000445D3
		private void method_41(object sender, EventArgs e)
		{
			this.method_24();
		}

		// Token: 0x06006F62 RID: 28514 RVA: 0x000463DB File Offset: 0x000445DB
		private void method_42(object sender, EventArgs e)
		{
			this.method_25();
		}

		// Token: 0x06006F63 RID: 28515 RVA: 0x000463E3 File Offset: 0x000445E3
		private void method_43(object sender, EventArgs e)
		{
			this.method_26();
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x000463EB File Offset: 0x000445EB
		private void method_44(object sender, EventArgs e)
		{
			this.vmethod_92().FoldAll(FoldAction.Contract);
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x000463F9 File Offset: 0x000445F9
		private void method_45(object sender, EventArgs e)
		{
			this.vmethod_92().FoldAll(FoldAction.Expand);
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x003C2EB4 File Offset: 0x003C10B4
		private void method_46(object sender, EventArgs e)
		{
			if (!Client.smethod_46().method_10().Equals(this.luaSandBox_0))
			{
				this.luaSandBox_0.LuaPrint -= this.luaSandBox_0_LuaPrint;
				this.luaSandBox_0 = Client.smethod_46().method_10();
				this.luaSandBox_0.LuaPrint += this.luaSandBox_0_LuaPrint;
			}
			if (Operators.CompareString(this.vmethod_92().Text.ToString(), "", false) != 0)
			{
				if (this.vmethod_90().Checked)
				{
					Class124 @class;
					(@class = this.vmethod_72()).Text = @class.Text + "\r\n>> " + this.vmethod_92().Text;
				}
				StringBuilder stringBuilder = new StringBuilder();
				if (this.vmethod_92().Text.Length != 0)
				{
					stringBuilder.Append(this.vmethod_92().Text);
					string text = "Console: ";
					object obj = stringBuilder.ToString();
					LuaUtility.smethod_34(ref text, ref obj, true);
					stringBuilder.Clear();
				}
				object[] array = null;
				try
				{
					array = this.luaSandBox_0.RunScript(this.vmethod_92().Text, true, "Console");
				}
				catch (Exception ex)
				{
					this.vmethod_72().AppendText("\r\nInternal ERROR: " + ex.Message);
					stringBuilder.Append("Internal ERROR: " + ex.Message).Append("\r\n");
				}
				if (!Information.IsNothing(array) && array[0] != null)
				{
					if (array[0].GetType() == typeof(LuaScriptException))
					{
						if (!Information.IsNothing(((LuaScriptException)array[0]).InnerException))
						{
							this.vmethod_72().AppendText("\r\nERROR: " + ((LuaScriptException)array[0]).InnerException.Message);
							stringBuilder.Append("ERROR: " + ((LuaScriptException)array[0]).InnerException.Message).Append("\r\n");
						}
						else
						{
							this.vmethod_72().AppendText("\r\nERROR: " + ((LuaScriptException)array[0]).Source + " " + ((LuaScriptException)array[0]).Message);
							stringBuilder.Append("ERROR: " + ((LuaScriptException)array[0]).Source + " " + ((LuaScriptException)array[0]).Message).Append("\r\n");
						}
					}
					else
					{
						this.vmethod_72().AppendText("\r\n" + LuaUtility.smethod_33(array));
						stringBuilder.Append(LuaUtility.smethod_33(array));
					}
				}
				this.vmethod_72().Select(this.vmethod_72().TextLength, 0);
				this.vmethod_72().ScrollToCaret();
				Client.bool_1 = true;
				if (stringBuilder != null)
				{
					string text;
					object obj;
					if (stringBuilder.Length > 0)
					{
						text = "";
						obj = stringBuilder.ToString();
						LuaUtility.smethod_34(ref text, ref obj, false);
						return;
					}
					text = "...";
					obj = "";
					LuaUtility.smethod_34(ref text, ref obj, false);
				}
			}
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x00046407 File Offset: 0x00044607
		private void method_47(object sender, EventArgs e)
		{
			this.vmethod_92().ReplaceSelection(Conversions.ToString(this.vmethod_76().SelectedItem));
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x00046424 File Offset: 0x00044624
		private void method_48(object sender, EventArgs e)
		{
			this.method_49("\"", "\"");
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x003C31C8 File Offset: 0x003C13C8
		private void method_49(string string_0, string string_1)
		{
			int selectionStart = this.vmethod_92().SelectionStart;
			int selectionEnd = this.vmethod_92().SelectionEnd;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string_0);
			stringBuilder.Append(this.vmethod_92().GetTextRange(selectionStart, selectionEnd - selectionStart));
			stringBuilder.Append(string_1);
			this.vmethod_92().ReplaceSelection(stringBuilder.ToString());
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x00046436 File Offset: 0x00044636
		private void method_50(object sender, EventArgs e)
		{
			this.method_49("(", ")");
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x00046448 File Offset: 0x00044648
		private void method_51(object sender, EventArgs e)
		{
			this.method_49("{", "}");
		}

		// Token: 0x06006F6C RID: 28524 RVA: 0x0004645A File Offset: 0x0004465A
		private void ConsoleWindow2_Closing(object sender, CancelEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x04003EFC RID: 16124
		[AccessedThroughProperty("menuStrip1")]
		[CompilerGenerated]
		private Class119 class119_0;

		// Token: 0x04003EFD RID: 16125
		[CompilerGenerated]
		[AccessedThroughProperty("fileToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04003EFE RID: 16126
		[CompilerGenerated]
		[AccessedThroughProperty("openToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04003EFF RID: 16127
		[AccessedThroughProperty("editToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04003F00 RID: 16128
		[AccessedThroughProperty("cutToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x04003F01 RID: 16129
		[AccessedThroughProperty("copyToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04003F02 RID: 16130
		[CompilerGenerated]
		[AccessedThroughProperty("pasteToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_5;

		// Token: 0x04003F03 RID: 16131
		[AccessedThroughProperty("toolStripSeparator1")]
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x04003F04 RID: 16132
		[AccessedThroughProperty("selectLineToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_6;

		// Token: 0x04003F05 RID: 16133
		[AccessedThroughProperty("selectAllToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_7;

		// Token: 0x04003F06 RID: 16134
		[AccessedThroughProperty("clearSelectionToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_8;

		// Token: 0x04003F07 RID: 16135
		[AccessedThroughProperty("toolStripSeparator2")]
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_1;

		// Token: 0x04003F08 RID: 16136
		[AccessedThroughProperty("indentSelectionToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_9;

		// Token: 0x04003F09 RID: 16137
		[AccessedThroughProperty("outdentSelectionToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_10;

		// Token: 0x04003F0A RID: 16138
		[AccessedThroughProperty("toolStripSeparator3")]
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_2;

		// Token: 0x04003F0B RID: 16139
		[CompilerGenerated]
		[AccessedThroughProperty("uppercaseSelectionToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_11;

		// Token: 0x04003F0C RID: 16140
		[AccessedThroughProperty("lowercaseSelectionToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_12;

		// Token: 0x04003F0D RID: 16141
		[CompilerGenerated]
		[AccessedThroughProperty("searchToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_13;

		// Token: 0x04003F0E RID: 16142
		[AccessedThroughProperty("findToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_14;

		// Token: 0x04003F0F RID: 16143
		[AccessedThroughProperty("findDialogToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_15;

		// Token: 0x04003F10 RID: 16144
		[CompilerGenerated]
		[AccessedThroughProperty("findAndReplaceToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_16;

		// Token: 0x04003F11 RID: 16145
		[CompilerGenerated]
		[AccessedThroughProperty("toolStripSeparator7")]
		private ToolStripSeparator toolStripSeparator_3;

		// Token: 0x04003F12 RID: 16146
		[CompilerGenerated]
		[AccessedThroughProperty("goToLineToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_17;

		// Token: 0x04003F13 RID: 16147
		[CompilerGenerated]
		[AccessedThroughProperty("viewToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_18;

		// Token: 0x04003F14 RID: 16148
		[CompilerGenerated]
		[AccessedThroughProperty("wordWrapItem")]
		private ToolStripMenuItem toolStripMenuItem_19;

		// Token: 0x04003F15 RID: 16149
		[CompilerGenerated]
		[AccessedThroughProperty("indentGuidesItem")]
		private ToolStripMenuItem toolStripMenuItem_20;

		// Token: 0x04003F16 RID: 16150
		[AccessedThroughProperty("hiddenCharactersItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_21;

		// Token: 0x04003F17 RID: 16151
		[AccessedThroughProperty("toolStripSeparator4")]
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_4;

		// Token: 0x04003F18 RID: 16152
		[CompilerGenerated]
		[AccessedThroughProperty("zoomInToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_22;

		// Token: 0x04003F19 RID: 16153
		[CompilerGenerated]
		[AccessedThroughProperty("zoomOutToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_23;

		// Token: 0x04003F1A RID: 16154
		[CompilerGenerated]
		[AccessedThroughProperty("zoom100ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_24;

		// Token: 0x04003F1B RID: 16155
		[AccessedThroughProperty("toolStripSeparator5")]
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_5;

		// Token: 0x04003F1C RID: 16156
		[AccessedThroughProperty("collapseAllToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_25;

		// Token: 0x04003F1D RID: 16157
		[CompilerGenerated]
		[AccessedThroughProperty("expandAllToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_26;

		// Token: 0x04003F1E RID: 16158
		[CompilerGenerated]
		[AccessedThroughProperty("TextPanel")]
		private Panel panel_0;

		// Token: 0x04003F1F RID: 16159
		[CompilerGenerated]
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04003F20 RID: 16160
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private Class124 class124_0;

		// Token: 0x04003F21 RID: 16161
		[CompilerGenerated]
		[AccessedThroughProperty("Button_InsertScript")]
		private Control9 control9_0;

		// Token: 0x04003F22 RID: 16162
		[AccessedThroughProperty("ComboBox1")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04003F23 RID: 16163
		[AccessedThroughProperty("Button_Run")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x04003F24 RID: 16164
		[AccessedThroughProperty("Panel1")]
		[CompilerGenerated]
		private Panel panel_1;

		// Token: 0x04003F25 RID: 16165
		[CompilerGenerated]
		[AccessedThroughProperty("EncloseSelectionInToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_27;

		// Token: 0x04003F26 RID: 16166
		[CompilerGenerated]
		[AccessedThroughProperty("TSMI_EncloseInQuotes")]
		private ToolStripMenuItem toolStripMenuItem_28;

		// Token: 0x04003F27 RID: 16167
		[AccessedThroughProperty("TSMI_EncloseInParentheses")]
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_29;

		// Token: 0x04003F28 RID: 16168
		[CompilerGenerated]
		[AccessedThroughProperty("TSMI_EncloseInBrackets")]
		private ToolStripMenuItem toolStripMenuItem_30;

		// Token: 0x04003F29 RID: 16169
		[AccessedThroughProperty("CB_EchoInput")]
		[CompilerGenerated]
		private Class112 class112_0;

		// Token: 0x04003F2A RID: 16170
		[CompilerGenerated]
		[AccessedThroughProperty("TextArea")]
		private Scintilla scintilla_0;

		// Token: 0x04003F2B RID: 16171
		private LuaSandBox luaSandBox_0;

		// Token: 0x04003F2C RID: 16172
		private bool bool_3;
	}
}
