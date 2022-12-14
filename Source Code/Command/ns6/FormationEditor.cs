using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns2;
using ns4;
using ns5;
using ns7;
using ns8;

namespace ns6
{
	// Token: 0x02000EC0 RID: 3776
	[DesignerGenerated]
	internal sealed partial class FormationEditor : DarkSecondaryFormBase
	{
		// Token: 0x06007A74 RID: 31348 RVA: 0x00427F7C File Offset: 0x0042617C
		public FormationEditor()
		{
			base.FormClosing += this.FormationEditor_FormClosing;
			base.Load += this.FormationEditor_Load;
			base.KeyDown += this.FormationEditor_KeyDown;
			base.FormClosed += this.FormationEditor_FormClosed;
			this.class112_0 = new Class112();
			this.InitializeComponent_1();
		}

		// Token: 0x06007A76 RID: 31350 RVA: 0x00428028 File Offset: 0x00426228
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormationEditor));
			this.vmethod_1(new Class125());
			this.vmethod_3(new ToolStripButton());
			this.vmethod_5(new ToolStripSeparator());
			this.vmethod_15(new ToolStripButton());
			this.vmethod_17(new ToolStripButton());
			this.vmethod_7(new Class113());
			this.vmethod_9(new Class128());
			this.vmethod_11(new Class128());
			this.vmethod_13(new Control6());
			this.vmethod_0().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AutoSize = false;
			this.vmethod_0().BackColor = Color.FromArgb(43, 43, 43);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_0().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_2(),
				this.vmethod_4(),
				this.vmethod_14(),
				this.vmethod_16()
			});
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "ToolStrip1";
			this.vmethod_0().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_0().Size = new Size(590, 25);
			this.vmethod_0().TabIndex = 7;
			this.vmethod_0().Text = "ToolStrip1";
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Image = (Image)componentResourceManager.GetObject("ToolStripButton1.Image");
			this.vmethod_2().ImageTransparentColor = Color.Magenta;
			this.vmethod_2().Name = "ToolStripButton1";
			this.vmethod_2().Size = new Size(107, 22);
			this.vmethod_2().Text = "Set Group Lead";
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Margin = new Padding(0, 0, 2, 0);
			this.vmethod_4().Name = "ToolStripSeparator1";
			this.vmethod_4().Size = new Size(6, 25);
			this.vmethod_14().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Image = (Image)componentResourceManager.GetObject("ToolStripButton2.Image");
			this.vmethod_14().ImageTransparentColor = Color.Magenta;
			this.vmethod_14().Name = "ToolStripButton2";
			this.vmethod_14().Size = new Size(174, 22);
			this.vmethod_14().Text = "Set station (relative bearing)";
			this.vmethod_16().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Image = (Image)componentResourceManager.GetObject("ToolStripButton3.Image");
			this.vmethod_16().ImageTransparentColor = Color.Magenta;
			this.vmethod_16().Name = "ToolStripButton3";
			this.vmethod_16().Size = new Size(161, 22);
			this.vmethod_16().Text = "Set station (fixed bearing)";
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_8(),
				this.vmethod_10()
			});
			this.vmethod_6().Name = "CMenu_ThreatAxis";
			this.vmethod_6().Size = new Size(181, 48);
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Name = "AssignToPatrol_TSMI";
			this.vmethod_8().Size = new Size(180, 22);
			this.vmethod_8().Text = "Assign to Patrol...";
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Name = "RemoveFromPatrol_TSMI";
			this.vmethod_10().Size = new Size(180, 22);
			this.vmethod_10().Text = "Remove from Patrol";
			this.vmethod_12().AllowDrop = true;
			this.vmethod_12().Dock = DockStyle.Fill;
			this.vmethod_12().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_12().Location = new Point(0, 25);
			this.vmethod_12().method_6(20);
			this.vmethod_12().Name = "TV_Units";
			this.vmethod_12().Size = new Size(590, 433);
			this.vmethod_12().TabIndex = 12;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(590, 458);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormationEditor";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Formation Editor";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			this.vmethod_6().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x06007A77 RID: 31351 RVA: 0x0004B68D File Offset: 0x0004988D
		[CompilerGenerated]
		internal Class125 vmethod_0()
		{
			return this.class125_0;
		}

		// Token: 0x06007A78 RID: 31352 RVA: 0x0004B695 File Offset: 0x00049895
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x06007A79 RID: 31353 RVA: 0x0004B69E File Offset: 0x0004989E
		[CompilerGenerated]
		internal ToolStripButton vmethod_2()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06007A7A RID: 31354 RVA: 0x00428698 File Offset: 0x00426898
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStripButton toolStripButton_3)
		{
			EventHandler value = new EventHandler(this.method_5);
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

		// Token: 0x06007A7B RID: 31355 RVA: 0x0004B6A6 File Offset: 0x000498A6
		[CompilerGenerated]
		internal ToolStripSeparator vmethod_4()
		{
			return this.toolStripSeparator_0;
		}

		// Token: 0x06007A7C RID: 31356 RVA: 0x0004B6AE File Offset: 0x000498AE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripSeparator toolStripSeparator_1)
		{
			this.toolStripSeparator_0 = toolStripSeparator_1;
		}

		// Token: 0x06007A7D RID: 31357 RVA: 0x0004B6B7 File Offset: 0x000498B7
		[CompilerGenerated]
		internal Class113 vmethod_6()
		{
			return this.class113_0;
		}

		// Token: 0x06007A7E RID: 31358 RVA: 0x0004B6BF File Offset: 0x000498BF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class113 class113_1)
		{
			this.class113_0 = class113_1;
		}

		// Token: 0x06007A7F RID: 31359 RVA: 0x0004B6C8 File Offset: 0x000498C8
		[CompilerGenerated]
		internal Class128 vmethod_8()
		{
			return this.class128_0;
		}

		// Token: 0x06007A80 RID: 31360 RVA: 0x004286DC File Offset: 0x004268DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class128 class128_2)
		{
			EventHandler value = new EventHandler(this.method_7);
			Class128 @class = this.class128_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_0 = class128_2;
			@class = this.class128_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x0004B6D0 File Offset: 0x000498D0
		[CompilerGenerated]
		internal Class128 vmethod_10()
		{
			return this.class128_1;
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x0004B6D8 File Offset: 0x000498D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class128 class128_2)
		{
			this.class128_1 = class128_2;
		}

		// Token: 0x06007A83 RID: 31363 RVA: 0x0004B6E1 File Offset: 0x000498E1
		[CompilerGenerated]
		internal Control6 vmethod_12()
		{
			return this.control6_0;
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x00428720 File Offset: 0x00426920
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control6 control6_1)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_8);
			Control6 control = this.control6_0;
			if (control != null)
			{
				control.MouseClick -= value;
			}
			this.control6_0 = control6_1;
			control = this.control6_0;
			if (control != null)
			{
				control.MouseClick += value;
			}
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x0004B6E9 File Offset: 0x000498E9
		[CompilerGenerated]
		internal ToolStripButton vmethod_14()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x00428764 File Offset: 0x00426964
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripButton toolStripButton_3)
		{
			EventHandler value = new EventHandler(this.method_9);
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

		// Token: 0x06007A87 RID: 31367 RVA: 0x0004B6F1 File Offset: 0x000498F1
		[CompilerGenerated]
		internal ToolStripButton vmethod_16()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x06007A88 RID: 31368 RVA: 0x004287A8 File Offset: 0x004269A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(ToolStripButton toolStripButton_3)
		{
			EventHandler value = new EventHandler(this.method_10);
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

		// Token: 0x06007A89 RID: 31369 RVA: 0x004287EC File Offset: 0x004269EC
		public void method_3()
		{
			base.SuspendLayout();
			this.vmethod_12().method_20().Clear();
			try
			{
				foreach (ActiveUnit activeUnit in this.group_0.vmethod_141().Values)
				{
					string text = activeUnit.Name;
					if (activeUnit.method_122())
					{
						text = "[LEAD] " + text;
					}
					string str;
					if (activeUnit.bool_3)
					{
						Aircraft aircraft = (Aircraft)activeUnit;
						if (Information.IsNothing(aircraft.method_167()))
						{
							str = "";
						}
						else
						{
							str = " (" + aircraft.method_167().Name + ")";
						}
					}
					else
					{
						str = "";
					}
					string str2;
					if (string.IsNullOrEmpty(activeUnit.string_2))
					{
						str2 = "";
					}
					else
					{
						str2 = " (" + Misc.smethod_9(activeUnit.string_2) + ")";
					}
					Class127 @class = new Class127(text + str2 + str);
					this.vmethod_12().method_20().method_4(@class);
					@class.Tag = activeUnit;
				}
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			Class2558.smethod_6(this.vmethod_12());
			base.ResumeLayout();
		}

		// Token: 0x06007A8A RID: 31370 RVA: 0x0004B6F9 File Offset: 0x000498F9
		private void FormationEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			Client.smethod_52().enum87_0 = Class285.Enum87.const_0;
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06007A8B RID: 31371 RVA: 0x0042892C File Offset: 0x00426B2C
		private void FormationEditor_Load(object sender, EventArgs e)
		{
			this.Text = "Formation Editor - " + this.group_0.Name;
			this.class112_0.Text = "Sprint and drift";
			this.class112_0.Click += this.class112_0_Click;
			ToolStripControlHost value = new ToolStripControlHost(this.class112_0);
			this.vmethod_0().Items.Add(value);
			Client.smethod_14(new Client.Delegate78(this.method_4));
			this.method_3();
		}

		// Token: 0x06007A8C RID: 31372 RVA: 0x004289B0 File Offset: 0x00426BB0
		private void method_4(Unit unit_0)
		{
			try
			{
				foreach (Class127 @class in Class2558.smethod_9(this.vmethod_12()))
				{
					if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(@class.Tag)) && @class.Tag == unit_0)
					{
						this.vmethod_12().method_51(@class);
						if (((ActiveUnit)unit_0).method_122())
						{
							this.class112_0.Enabled = false;
						}
						else
						{
							this.class112_0.Enabled = true;
							this.class112_0.Checked = ((ActiveUnit)unit_0).vmethod_85().vmethod_3();
						}
						if (base.Visible)
						{
							base.Focus();
							break;
						}
						break;
					}
				}
			}
			finally
			{
				IEnumerator<Class127> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x00428A7C File Offset: 0x00426C7C
		private void class112_0_Click(object sender, EventArgs e)
		{
			if (this.vmethod_12().method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().method_22()[0].Tag)))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.vmethod_12().method_22()[0].Tag);
				if (objectValue.GetType().BaseType == typeof(Class350))
				{
					ActiveUnit activeUnit = (ActiveUnit)objectValue;
					if (!activeUnit.method_122())
					{
						activeUnit.vmethod_85().vmethod_4(this.class112_0.Checked);
					}
				}
			}
		}

		// Token: 0x06007A8E RID: 31374 RVA: 0x00428B18 File Offset: 0x00426D18
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_12().method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().method_22()[0].Tag)))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.vmethod_12().method_22()[0].Tag);
				if (objectValue.GetType().BaseType == typeof(Class350))
				{
					ActiveUnit activeUnit_ = (ActiveUnit)objectValue;
					this.group_0.method_153(activeUnit_);
					this.method_3();
					Client.bool_1 = true;
				}
			}
		}

		// Token: 0x06007A8F RID: 31375 RVA: 0x00428BAC File Offset: 0x00426DAC
		private void method_6(ActiveUnit activeUnit_0)
		{
			if (Information.IsNothing(activeUnit_0.vmethod_101()))
			{
				this.vmethod_10().Enabled = false;
			}
			else
			{
				this.vmethod_10().Enabled = (activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol);
			}
			this.vmethod_8().DropDownItems.Clear();
			try
			{
				foreach (Class343 @class in this.group_0.vmethod_139())
				{
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(@class.Name);
					toolStripMenuItem.Tag = @class;
					toolStripMenuItem.MouseDown += new MouseEventHandler(this.method_7);
					this.vmethod_8().DropDownItems.Add(toolStripMenuItem);
				}
			}
			finally
			{
				List<Class343>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06007A90 RID: 31376 RVA: 0x00428C78 File Offset: 0x00426E78
		private void method_7(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(toolStripMenuItem.Tag)) && toolStripMenuItem.Tag.GetType() == typeof(Class343))
			{
				try
				{
					foreach (Class343 @class in this.group_0.vmethod_139())
					{
						if (Operators.CompareString(@class.Name, toolStripMenuItem.Text, false) == 0)
						{
							ActiveUnit activeUnit = (ActiveUnit)Client.smethod_54();
							Mission value = @class;
							bool setMissionOnly = false;
							Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
							activeUnit.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
							this.method_3();
							break;
						}
					}
				}
				finally
				{
					List<Class343>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06007A91 RID: 31377 RVA: 0x00428D2C File Offset: 0x00426F2C
		private void method_8(object sender, MouseEventArgs e)
		{
			if (this.vmethod_12().method_22().Count != 0)
			{
				Class127 @class = this.vmethod_12().method_22()[0];
				if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(@class.Tag)) && @class.Tag.GetType().BaseType.BaseType == typeof(ActiveUnit))
				{
					Client.smethod_56((Unit)@class.Tag, true);
					if (e.Button == MouseButtons.Right)
					{
						this.method_6((ActiveUnit)@class.Tag);
						this.vmethod_6().Show(this.vmethod_12(), e.X, e.Y);
					}
				}
			}
		}

		// Token: 0x06007A92 RID: 31378 RVA: 0x00428DE0 File Offset: 0x00426FE0
		private void method_9(object sender, EventArgs e)
		{
			if (this.vmethod_12().method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().method_22()[0].Tag)))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.vmethod_12().method_22()[0].Tag);
				if (objectValue.GetType().BaseType == typeof(Class350) && !((ActiveUnit)objectValue).method_122())
				{
					Client.orientationType_0 = ReferencePoint.OrientationType.Rotating;
					Client.smethod_62(Client.Enum197.const_14);
				}
			}
		}

		// Token: 0x06007A93 RID: 31379 RVA: 0x00428E70 File Offset: 0x00427070
		private void method_10(object sender, EventArgs e)
		{
			if (this.vmethod_12().method_22().Count != 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().method_22()[0].Tag)))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.vmethod_12().method_22()[0].Tag);
				if (objectValue.GetType().BaseType == typeof(Class350) && !((ActiveUnit)objectValue).method_122())
				{
					Client.orientationType_0 = ReferencePoint.OrientationType.Fixed;
					Client.smethod_62(Client.Enum197.const_14);
				}
			}
		}

		// Token: 0x06007A94 RID: 31380 RVA: 0x0004B715 File Offset: 0x00049915
		private void FormationEditor_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			if (e.KeyCode == Keys.F4 && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x06007A95 RID: 31381 RVA: 0x00428F00 File Offset: 0x00427100
		private void FormationEditor_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.class112_0.Click -= this.class112_0_Click;
			Client.smethod_15(new Client.Delegate78(this.method_4));
			try
			{
				foreach (object obj in this.vmethod_8().DropDownItems)
				{
					((ToolStripMenuItem)obj).MouseDown -= new MouseEventHandler(this.method_7);
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

		// Token: 0x04004454 RID: 17492
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStrip1")]
		private Class125 class125_0;

		// Token: 0x04004455 RID: 17493
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripButton1")]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04004456 RID: 17494
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x04004457 RID: 17495
		[CompilerGenerated]
		[AccessedThroughProperty("CMenu_Unit")]
		private Class113 class113_0;

		// Token: 0x04004458 RID: 17496
		[CompilerGenerated]
		[AccessedThroughProperty("AssignToPatrol_TSMI")]
		private Class128 class128_0;

		// Token: 0x04004459 RID: 17497
		[CompilerGenerated]
		[AccessedThroughProperty("RemoveFromPatrol_TSMI")]
		private Class128 class128_1;

		// Token: 0x0400445A RID: 17498
		[CompilerGenerated]
		[AccessedThroughProperty("TV_Units")]
		private Control6 control6_0;

		// Token: 0x0400445B RID: 17499
		[AccessedThroughProperty("ToolStripButton2")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x0400445C RID: 17500
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripButton3")]
		private ToolStripButton toolStripButton_2;

		// Token: 0x0400445D RID: 17501
		public Group group_0;

		// Token: 0x0400445E RID: 17502
		private Class112 class112_0;
	}
}
