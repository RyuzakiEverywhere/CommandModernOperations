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
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;
using ns5;
using ns9;

namespace ns6
{
	// Token: 0x02000E7C RID: 3708
	[DesignerGenerated]
	internal sealed partial class ScenAttachmentsWindow : DarkSecondaryFormBase
	{
		// Token: 0x0600720D RID: 29197 RVA: 0x000477A0 File Offset: 0x000459A0
		public ScenAttachmentsWindow()
		{
			base.Shown += this.ScenAttachmentsWindow_Shown;
			base.Load += this.ScenAttachmentsWindow_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x0600720F RID: 29199 RVA: 0x003D3F38 File Offset: 0x003D2138
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ScenAttachmentsWindow));
			this.vmethod_1(new Control4());
			this.vmethod_3(new Class125());
			this.vmethod_5(new ToolStripButton());
			this.vmethod_9(new ToolStripComboBox());
			this.vmethod_11(new ToolStripButton());
			this.vmethod_7(new ToolStripButton());
			this.vmethod_13(new PropertyGrid());
			this.vmethod_15(new Class116());
			this.vmethod_2().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().Location = new Point(0, 25);
			this.vmethod_0().Name = "ListBox1";
			this.vmethod_0().Size = new Size(530, 264);
			this.vmethod_0().TabIndex = 3;
			this.vmethod_2().AutoSize = false;
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_4(),
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_6()
			});
			this.vmethod_2().Location = new Point(0, 0);
			this.vmethod_2().Name = "ToolStrip1";
			this.vmethod_2().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_2().Size = new Size(742, 25);
			this.vmethod_2().TabIndex = 2;
			this.vmethod_2().Text = "ToolStrip1";
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().ImageTransparentColor = Color.Magenta;
			this.vmethod_4().Name = "ToolStripButton1";
			this.vmethod_4().Size = new Size(119, 22);
			this.vmethod_4().Text = "Create new, of type :";
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Items.AddRange(new object[]
			{
				"Map Overlay (Single Image)",
				"Lua Script",
				"Inst Import",
				"Local Video",
				"Local Sound"
			});
			this.vmethod_8().Name = "TSCB1";
			this.vmethod_8().Size = new Size(180, 25);
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Image = (Image)componentResourceManager.GetObject("ToolStripButton3.Image");
			this.vmethod_10().ImageTransparentColor = Color.Magenta;
			this.vmethod_10().Name = "ToolStripButton3";
			this.vmethod_10().Size = new Size(92, 22);
			this.vmethod_10().Text = "Add existing";
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Image = (Image)componentResourceManager.GetObject("ToolStripButton2.Image");
			this.vmethod_6().ImageTransparentColor = Color.Magenta;
			this.vmethod_6().Name = "ToolStripButton2";
			this.vmethod_6().Size = new Size(117, 22);
			this.vmethod_6().Text = "Remove Selected";
			this.vmethod_12().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_12().CategoryForeColor = SystemColors.InactiveCaptionText;
			this.vmethod_12().Location = new Point(536, 25);
			this.vmethod_12().Name = "PropertyGrid1";
			this.vmethod_12().Size = new Size(206, 264);
			this.vmethod_12().TabIndex = 4;
			this.vmethod_14().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(535, 4);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Size = new Size(128, 15);
			this.vmethod_14().TabIndex = 5;
			this.vmethod_14().Text = "Properties of selected:";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(742, 288);
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ScenAttachmentsWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Scenario Attachments";
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x000477D2 File Offset: 0x000459D2
		[CompilerGenerated]
		internal Control4 vmethod_0()
		{
			return this.control4_0;
		}

		// Token: 0x06007211 RID: 29201 RVA: 0x003D4520 File Offset: 0x003D2720
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control4 control4_1)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_9);
			Control4 control = this.control4_0;
			if (control != null)
			{
				control.method_17(eventHandler_);
			}
			this.control4_0 = control4_1;
			control = this.control4_0;
			if (control != null)
			{
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x000477DA File Offset: 0x000459DA
		[CompilerGenerated]
		internal Class125 vmethod_2()
		{
			return this.class125_0;
		}

		// Token: 0x06007213 RID: 29203 RVA: 0x000477E2 File Offset: 0x000459E2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x000477EB File Offset: 0x000459EB
		[CompilerGenerated]
		internal ToolStripButton vmethod_4()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06007215 RID: 29205 RVA: 0x003D4564 File Offset: 0x003D2764
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_3)
		{
			EventHandler value = new EventHandler(this.method_4);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_3;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x000477F3 File Offset: 0x000459F3
		[CompilerGenerated]
		internal ToolStripButton vmethod_6()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x003D45A8 File Offset: 0x003D27A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripButton toolStripButton_3)
		{
			EventHandler value = new EventHandler(this.method_6);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_3;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06007218 RID: 29208 RVA: 0x000477FB File Offset: 0x000459FB
		[CompilerGenerated]
		internal ToolStripComboBox vmethod_8()
		{
			return this.toolStripComboBox_0;
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x00047803 File Offset: 0x00045A03
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripComboBox toolStripComboBox_1)
		{
			this.toolStripComboBox_0 = toolStripComboBox_1;
		}

		// Token: 0x0600721A RID: 29210 RVA: 0x0004780C File Offset: 0x00045A0C
		[CompilerGenerated]
		internal ToolStripButton vmethod_10()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x0600721B RID: 29211 RVA: 0x003D45EC File Offset: 0x003D27EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripButton toolStripButton_3)
		{
			EventHandler value = new EventHandler(this.method_8);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_3;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x00047814 File Offset: 0x00045A14
		[CompilerGenerated]
		internal PropertyGrid vmethod_12()
		{
			return this.propertyGrid_0;
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x0004781C File Offset: 0x00045A1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(PropertyGrid propertyGrid_1)
		{
			this.propertyGrid_0 = propertyGrid_1;
		}

		// Token: 0x0600721E RID: 29214 RVA: 0x00047825 File Offset: 0x00045A25
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_0;
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x0004782D File Offset: 0x00045A2D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x00047836 File Offset: 0x00045A36
		private void ScenAttachmentsWindow_Shown(object sender, EventArgs e)
		{
			this.vmethod_8().SelectedIndex = 0;
			this.method_3();
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x003D4630 File Offset: 0x003D2830
		public void method_3()
		{
			this.vmethod_0().method_18().Clear();
			try
			{
				foreach (KeyValuePair<string, ScenAttachmentObject> keyValuePair in Client.smethod_46().vmethod_2())
				{
					Class117 @class = new Class117(keyValuePair.Value.string_1);
					@class.Tag = keyValuePair.Key;
					this.vmethod_0().method_18().Add(@class);
				}
			}
			finally
			{
				IEnumerator<KeyValuePair<string, ScenAttachmentObject>> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x0004784A File Offset: 0x00045A4A
		private void method_4(object sender, EventArgs e)
		{
			this.method_5();
			this.method_3();
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x003D46BC File Offset: 0x003D28BC
		public void method_5()
		{
			switch (this.vmethod_8().SelectedIndex)
			{
			case 0:
				Class2413.smethod_2().method_41().vmethod_102().InitialDirectory = Application.StartupPath;
				if (Class2413.smethod_2().method_41().vmethod_102().ShowDialog() != DialogResult.OK)
				{
					return;
				}
				try
				{
					string fileName = Class2413.smethod_2().method_41().vmethod_102().FileName;
					Class263 @class = new Class263();
					@class.ImageFileName = Path.GetFileName(fileName);
					@class.string_1 = "Map Overlay Image: " + @class.ImageFileName;
					@class.vmethod_0(fileName);
					@class.vmethod_2(Path.Combine(GameGeneral.string_6, @class.method_0()));
					Client.smethod_46().vmethod_2().Add(@class.method_0(), @class);
					return;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200395", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					return;
				}
				break;
			case 1:
				break;
			case 2:
				goto IL_213;
			case 3:
				goto IL_31D;
			case 4:
				goto IL_427;
			default:
				return;
			}
			Class2413.smethod_2().method_41().vmethod_102().InitialDirectory = Application.StartupPath;
			Class2413.smethod_2().method_41().vmethod_102().Filter = "Lua script file (*.lua)|*.lua";
			if (Class2413.smethod_2().method_41().vmethod_102().ShowDialog() != DialogResult.OK)
			{
				return;
			}
			try
			{
				string fileName2 = Class2413.smethod_2().method_41().vmethod_102().FileName;
				Class262 class2 = new Class262();
				class2.ScriptFileName = Path.GetFileName(fileName2);
				class2.string_1 = "Lua script: " + class2.ScriptFileName;
				class2.vmethod_0(fileName2);
				class2.vmethod_2(Path.Combine(GameGeneral.string_6, class2.method_0()));
				Client.smethod_46().vmethod_2().Add(class2.method_0(), class2);
				return;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 200396", ex2.Message);
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				return;
			}
			IL_213:
			Class2413.smethod_2().method_41().vmethod_102().InitialDirectory = Application.StartupPath;
			Class2413.smethod_2().method_41().vmethod_102().Filter = "Inst Import file (*.inst)|*.inst";
			if (Class2413.smethod_2().method_41().vmethod_102().ShowDialog() != DialogResult.OK)
			{
				return;
			}
			try
			{
				string fileName3 = Class2413.smethod_2().method_41().vmethod_102().FileName;
				Class259 class3 = new Class259();
				class3.InstFileName = Path.GetFileName(fileName3);
				class3.string_1 = "Inst File: " + class3.InstFileName;
				class3.vmethod_0(fileName3);
				class3.vmethod_2(Path.Combine(GameGeneral.string_6, class3.method_0()));
				Client.smethod_46().vmethod_2().Add(class3.method_0(), class3);
				return;
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 200397", ex3.Message);
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				return;
			}
			IL_31D:
			Class2413.smethod_2().method_41().vmethod_102().InitialDirectory = Application.StartupPath;
			Class2413.smethod_2().method_41().vmethod_102().Filter = "Video file (*.*)|*.*";
			if (Class2413.smethod_2().method_41().vmethod_102().ShowDialog() != DialogResult.OK)
			{
				return;
			}
			try
			{
				string fileName4 = Class2413.smethod_2().method_41().vmethod_102().FileName;
				Class261 class4 = new Class261();
				class4.VideoFileName = Path.GetFileName(fileName4);
				class4.string_1 = "Local Video: " + class4.VideoFileName;
				class4.vmethod_0(fileName4);
				class4.vmethod_2(Path.Combine(GameGeneral.string_6, class4.method_0()));
				Client.smethod_46().vmethod_2().Add(class4.method_0(), class4);
				return;
			}
			catch (Exception ex4)
			{
				ex4.Data.Add("Error at 200398", ex4.Message);
				GameGeneral.smethod_25(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				return;
			}
			IL_427:
			Class2413.smethod_2().method_41().vmethod_102().InitialDirectory = Application.StartupPath;
			Class2413.smethod_2().method_41().vmethod_102().Filter = "sound file (*.*)|*.*";
			if (Class2413.smethod_2().method_41().vmethod_102().ShowDialog() == DialogResult.OK)
			{
				try
				{
					string fileName5 = Class2413.smethod_2().method_41().vmethod_102().FileName;
					Class260 class5 = new Class260();
					class5.SoundFileName = Path.GetFileName(fileName5);
					class5.string_1 = "Local Sound: " + class5.SoundFileName;
					class5.vmethod_0(fileName5);
					class5.vmethod_2(Path.Combine(GameGeneral.string_6, class5.method_0()));
					Client.smethod_46().vmethod_2().Add(class5.method_0(), class5);
				}
				catch (Exception ex5)
				{
					ex5.Data.Add("Error at 200399", ex5.Message);
					GameGeneral.smethod_25(ref ex5);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06007224 RID: 29220 RVA: 0x003D4C34 File Offset: 0x003D2E34
		private void method_6(object sender, EventArgs e)
		{
			try
			{
				foreach (Class117 @class in this.vmethod_0().method_21())
				{
					Client.smethod_46().vmethod_2().Remove(@class.Tag.ToString());
				}
			}
			finally
			{
				List<Class117>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.method_3();
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x00047858 File Offset: 0x00045A58
		public void method_7()
		{
			this.method_3();
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x003D4CA8 File Offset: 0x003D2EA8
		private void method_8(object sender, EventArgs e)
		{
			bool flag = false;
			if (Class2413.smethod_2().method_63().ShowDialog() == DialogResult.OK)
			{
				try
				{
					foreach (ScenAttachmentObject scenAttachmentObject in Class2413.smethod_2().method_63().list_0)
					{
						if (!Client.smethod_46().vmethod_2().ContainsKey(scenAttachmentObject.method_0()))
						{
							Client.smethod_46().vmethod_2().Add(scenAttachmentObject.method_0(), scenAttachmentObject);
							flag = true;
						}
					}
				}
				finally
				{
					List<ScenAttachmentObject>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.method_3();
			}
			if (flag)
			{
				this.method_3();
			}
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x003D4D50 File Offset: 0x003D2F50
		private void method_9(object sender, EventArgs e)
		{
			if (this.vmethod_0().method_21().Count > 0)
			{
				this.vmethod_12().SelectedObject = Client.smethod_46().vmethod_2()[Conversions.ToString(this.vmethod_0().method_21()[0].Tag).ToString()];
				return;
			}
			this.vmethod_12().SelectedObject = null;
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x00044489 File Offset: 0x00042689
		private void ScenAttachmentsWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x0400404D RID: 16461
		[CompilerGenerated]
		[AccessedThroughProperty("ListBox1")]
		private Control4 control4_0;

		// Token: 0x0400404E RID: 16462
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStrip1")]
		private Class125 class125_0;

		// Token: 0x0400404F RID: 16463
		[AccessedThroughProperty("ToolStripButton1")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04004050 RID: 16464
		[AccessedThroughProperty("ToolStripButton2")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04004051 RID: 16465
		[AccessedThroughProperty("TSCB1")]
		[CompilerGenerated]
		private ToolStripComboBox toolStripComboBox_0;

		// Token: 0x04004052 RID: 16466
		[AccessedThroughProperty("ToolStripButton3")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_2;

		// Token: 0x04004053 RID: 16467
		[AccessedThroughProperty("PropertyGrid1")]
		[CompilerGenerated]
		private PropertyGrid propertyGrid_0;

		// Token: 0x04004054 RID: 16468
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;
	}
}
