using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns2;
using ns3;
using ns5;
using ns9;

namespace ns4
{
	// Token: 0x02000E6B RID: 3691
	[DesignerGenerated]
	internal sealed partial class CampaignEditorWindow : DarkSecondaryFormBase
	{
		// Token: 0x060070EA RID: 28906 RVA: 0x003CC764 File Offset: 0x003CA964
		public CampaignEditorWindow()
		{
			base.FormClosing += this.CampaignEditorWindow_FormClosing;
			base.VisibleChanged += this.CampaignEditorWindow_VisibleChanged;
			base.Load += this.CampaignEditorWindow_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x060070EC RID: 28908 RVA: 0x003CC7F4 File Offset: 0x003CA9F4
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CampaignEditorWindow));
			this.vmethod_1(new Class114());
			this.vmethod_31(new DataGridViewTextBoxColumn());
			this.vmethod_33(new DataGridViewTextBoxColumn());
			this.vmethod_35(new DataGridViewTextBoxColumn());
			this.vmethod_37(new DataGridViewButtonColumn());
			this.vmethod_39(new Class125());
			this.vmethod_3(new ToolStripButton());
			this.vmethod_19(new ToolStripButton());
			this.vmethod_5(new ToolStripButton());
			this.vmethod_7(new ToolStripButton());
			this.vmethod_9(new ToolStripButton());
			this.vmethod_17(new ToolStripButton());
			this.vmethod_21(new ToolStripButton());
			this.vmethod_11(new ToolStripButton());
			this.vmethod_13(new OpenFileDialog());
			this.vmethod_15(new SaveFileDialog());
			this.vmethod_23(new Class125());
			this.vmethod_25(new ToolStripLabel());
			this.vmethod_27(new ToolStripTextBox());
			this.vmethod_29(new ToolStripButton());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_38().SuspendLayout();
			this.vmethod_22().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToResizeRows = false;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_0().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_0().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font(Client.font_1.FontFamily, 8f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_30(),
				this.vmethod_32(),
				this.vmethod_34(),
				this.vmethod_36()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EditMode = DataGridViewEditMode.EditOnEnter;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().GridColor = SystemColors.ControlText;
			this.vmethod_0().Location = new Point(2, 28);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DGV_CampaignItems";
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().RowHeadersWidth = 10;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new Size(905, 376);
			this.vmethod_0().TabIndex = 9;
			this.vmethod_30().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_30().HeaderText = "Name";
			this.vmethod_30().Name = "Column1";
			this.vmethod_30().ReadOnly = true;
			this.vmethod_30().Width = 58;
			this.vmethod_32().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_32().HeaderText = "Pass Score";
			this.vmethod_32().Name = "Column2";
			this.vmethod_32().ReadOnly = true;
			this.vmethod_32().Width = 84;
			this.vmethod_34().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_34().HeaderText = "Scenario ID";
			this.vmethod_34().Name = "ScenarioID";
			this.vmethod_34().ReadOnly = true;
			this.vmethod_36().HeaderText = "Change ID";
			this.vmethod_36().Name = "ChangeScenID";
			this.vmethod_36().Text = "Change ID";
			this.vmethod_38().AutoSize = false;
			this.vmethod_38().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_38().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_38().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_38().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_2(),
				this.vmethod_18(),
				this.vmethod_4(),
				this.vmethod_6(),
				this.vmethod_8(),
				this.vmethod_16(),
				this.vmethod_20(),
				this.vmethod_10()
			});
			this.vmethod_38().Location = new Point(0, 0);
			this.vmethod_38().Name = "ToolStrip1";
			this.vmethod_38().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_38().Size = new Size(907, 25);
			this.vmethod_38().TabIndex = 10;
			this.vmethod_38().Text = "ToolStrip1";
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().ImageTransparentColor = Color.Magenta;
			this.vmethod_2().Name = "TSB_AddScenario";
			this.vmethod_2().Size = new Size(81, 22);
			this.vmethod_2().Text = "Add Scenario";
			this.vmethod_18().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().ImageTransparentColor = Color.Magenta;
			this.vmethod_18().Name = "TSB_AddAttachment";
			this.vmethod_18().Size = new Size(99, 22);
			this.vmethod_18().Text = "Add Attachment";
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().ImageTransparentColor = Color.Magenta;
			this.vmethod_4().Name = "TSB_RemoveSelected";
			this.vmethod_4().Size = new Size(101, 22);
			this.vmethod_4().Text = "Remove Selected";
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Image = (Image)componentResourceManager.GetObject("TSB_MoveUp.Image");
			this.vmethod_6().ImageTransparentColor = Color.Magenta;
			this.vmethod_6().Name = "TSB_MoveUp";
			this.vmethod_6().Size = new Size(75, 22);
			this.vmethod_6().Text = "Move Up";
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Image = (Image)componentResourceManager.GetObject("TSB_MoveDown.Image");
			this.vmethod_8().ImageTransparentColor = Color.Magenta;
			this.vmethod_8().Name = "TSB_MoveDown";
			this.vmethod_8().Size = new Size(91, 22);
			this.vmethod_8().Text = "Move Down";
			this.vmethod_16().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Image = (Image)componentResourceManager.GetObject("TSB_Description.Image");
			this.vmethod_16().ImageTransparentColor = Color.Magenta;
			this.vmethod_16().Name = "TSB_Description";
			this.vmethod_16().Size = new Size(124, 22);
			this.vmethod_16().Text = "Title + Description";
			this.vmethod_20().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Image = (Image)componentResourceManager.GetObject("TSB_CampaignEnding.Image");
			this.vmethod_20().ImageTransparentColor = Color.Magenta;
			this.vmethod_20().Name = "TSB_CampaignEnding";
			this.vmethod_20().Size = new Size(88, 22);
			this.vmethod_20().Text = "Ending Text";
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Image = (Image)componentResourceManager.GetObject("TSB_Save.Image");
			this.vmethod_10().ImageTransparentColor = Color.Magenta;
			this.vmethod_10().Name = "TSB_Save";
			this.vmethod_10().Size = new Size(109, 22);
			this.vmethod_10().Text = "Save Campaign";
			this.vmethod_22().AutoSize = false;
			this.vmethod_22().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_22().Dock = DockStyle.Bottom;
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_22().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_24(),
				this.vmethod_26(),
				this.vmethod_28()
			});
			this.vmethod_22().Location = new Point(0, 407);
			this.vmethod_22().Name = "TS_PassScore";
			this.vmethod_22().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_22().Size = new Size(907, 25);
			this.vmethod_22().TabIndex = 12;
			this.vmethod_22().Text = "ToolStrip2";
			this.vmethod_24().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().Name = "TSL_PassScore";
			this.vmethod_24().Size = new Size(160, 22);
			this.vmethod_24().Text = "Selected scenario pass-score:";
			this.vmethod_26().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Name = "TSTB_PassScore";
			this.vmethod_26().Size = new Size(100, 25);
			this.vmethod_28().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_28().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_28().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_28().Image = (Image)componentResourceManager.GetObject("TSL_SetScore.Image");
			this.vmethod_28().ImageTransparentColor = Color.Magenta;
			this.vmethod_28().Name = "TSL_SetScore";
			this.vmethod_28().Size = new Size(30, 22);
			this.vmethod_28().Text = "SET";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(907, 432);
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_38());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CampaignEditorWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Campaign Editor";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_38().ResumeLayout(false);
			this.vmethod_38().PerformLayout();
			this.vmethod_22().ResumeLayout(false);
			this.vmethod_22().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x00046F16 File Offset: 0x00045116
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x003CD550 File Offset: 0x003CB750
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			EventHandler value = new EventHandler(this.method_10);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_14);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.SelectionChanged -= value;
				@class.CellContentClick -= value2;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.SelectionChanged += value;
				@class.CellContentClick += value2;
			}
		}

		// Token: 0x060070EF RID: 28911 RVA: 0x00046F1E File Offset: 0x0004511E
		[CompilerGenerated]
		internal ToolStripButton vmethod_2()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x003CD5B0 File Offset: 0x003CB7B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_4);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_9;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060070F1 RID: 28913 RVA: 0x00046F26 File Offset: 0x00045126
		[CompilerGenerated]
		internal ToolStripButton vmethod_4()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x060070F2 RID: 28914 RVA: 0x003CD5F4 File Offset: 0x003CB7F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_5);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_9;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x00046F2E File Offset: 0x0004512E
		[CompilerGenerated]
		internal ToolStripButton vmethod_6()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x003CD638 File Offset: 0x003CB838
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_6);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_9;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x00046F36 File Offset: 0x00045136
		[CompilerGenerated]
		internal ToolStripButton vmethod_8()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x003CD67C File Offset: 0x003CB87C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_7);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_3 = toolStripButton_9;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x00046F3E File Offset: 0x0004513E
		[CompilerGenerated]
		internal ToolStripButton vmethod_10()
		{
			return this.toolStripButton_4;
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x003CD6C0 File Offset: 0x003CB8C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_8);
			ToolStripButton toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_4 = toolStripButton_9;
			toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x00046F46 File Offset: 0x00045146
		[CompilerGenerated]
		internal OpenFileDialog vmethod_12()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x060070FA RID: 28922 RVA: 0x00046F4E File Offset: 0x0004514E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x060070FB RID: 28923 RVA: 0x00046F57 File Offset: 0x00045157
		[CompilerGenerated]
		internal SaveFileDialog vmethod_14()
		{
			return this.saveFileDialog_0;
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x00046F5F File Offset: 0x0004515F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(SaveFileDialog saveFileDialog_1)
		{
			this.saveFileDialog_0 = saveFileDialog_1;
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x00046F68 File Offset: 0x00045168
		[CompilerGenerated]
		internal ToolStripButton vmethod_16()
		{
			return this.toolStripButton_5;
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x003CD704 File Offset: 0x003CB904
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_9);
			ToolStripButton toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_5 = toolStripButton_9;
			toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x00046F70 File Offset: 0x00045170
		[CompilerGenerated]
		internal ToolStripButton vmethod_18()
		{
			return this.toolStripButton_6;
		}

		// Token: 0x06007100 RID: 28928 RVA: 0x003CD748 File Offset: 0x003CB948
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_11);
			ToolStripButton toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_6 = toolStripButton_9;
			toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x00046F78 File Offset: 0x00045178
		[CompilerGenerated]
		internal ToolStripButton vmethod_20()
		{
			return this.toolStripButton_7;
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x003CD78C File Offset: 0x003CB98C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_12);
			ToolStripButton toolStripButton = this.toolStripButton_7;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_7 = toolStripButton_9;
			toolStripButton = this.toolStripButton_7;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x00046F80 File Offset: 0x00045180
		[CompilerGenerated]
		internal Class125 vmethod_22()
		{
			return this.class125_0;
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x00046F88 File Offset: 0x00045188
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class125 class125_2)
		{
			this.class125_0 = class125_2;
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x00046F91 File Offset: 0x00045191
		[CompilerGenerated]
		internal ToolStripLabel vmethod_24()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x06007106 RID: 28934 RVA: 0x00046F99 File Offset: 0x00045199
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(ToolStripLabel toolStripLabel_1)
		{
			this.toolStripLabel_0 = toolStripLabel_1;
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x00046FA2 File Offset: 0x000451A2
		[CompilerGenerated]
		internal ToolStripTextBox vmethod_26()
		{
			return this.toolStripTextBox_0;
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x00046FAA File Offset: 0x000451AA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(ToolStripTextBox toolStripTextBox_1)
		{
			this.toolStripTextBox_0 = toolStripTextBox_1;
		}

		// Token: 0x06007109 RID: 28937 RVA: 0x00046FB3 File Offset: 0x000451B3
		[CompilerGenerated]
		internal ToolStripButton vmethod_28()
		{
			return this.toolStripButton_8;
		}

		// Token: 0x0600710A RID: 28938 RVA: 0x003CD7D0 File Offset: 0x003CB9D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_13);
			ToolStripButton toolStripButton = this.toolStripButton_8;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_8 = toolStripButton_9;
			toolStripButton = this.toolStripButton_8;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600710B RID: 28939 RVA: 0x00046FBB File Offset: 0x000451BB
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_30()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x0600710C RID: 28940 RVA: 0x00046FC3 File Offset: 0x000451C3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x00046FCC File Offset: 0x000451CC
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_32()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x00046FD4 File Offset: 0x000451D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x00046FDD File Offset: 0x000451DD
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_34()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x00046FE5 File Offset: 0x000451E5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06007111 RID: 28945 RVA: 0x00046FEE File Offset: 0x000451EE
		[CompilerGenerated]
		internal DataGridViewButtonColumn vmethod_36()
		{
			return this.dataGridViewButtonColumn_0;
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x00046FF6 File Offset: 0x000451F6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DataGridViewButtonColumn dataGridViewButtonColumn_1)
		{
			this.dataGridViewButtonColumn_0 = dataGridViewButtonColumn_1;
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x00046FFF File Offset: 0x000451FF
		[CompilerGenerated]
		internal Class125 vmethod_38()
		{
			return this.class125_1;
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x00047007 File Offset: 0x00045207
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Class125 class125_2)
		{
			this.class125_1 = class125_2;
		}

		// Token: 0x06007115 RID: 28949 RVA: 0x003CD814 File Offset: 0x003CBA14
		private void method_3()
		{
			object objectValue;
			if (this.vmethod_0().SelectedRows.Count > 0)
			{
				objectValue = RuntimeHelpers.GetObjectValue(this.vmethod_0().SelectedRows[0].Tag);
			}
			this.vmethod_0().Rows.Clear();
			try
			{
				foreach (Class264.Class265 @class in this.class264_0.list_0)
				{
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					dataGridViewRow.ReadOnly = false;
					dataGridViewRow.CreateCells(this.vmethod_0());
					Type type = @class.GetType();
					if (type == typeof(Class264.Class266))
					{
						dataGridViewRow.Cells[0].Value = "Scenario: " + @class.string_0;
						dataGridViewRow.Cells[1].Value = ((Class264.Class266)@class).method_0();
						dataGridViewRow.Cells[2].Value = ((Class264.Class266)@class).string_1;
					}
					else if (type == typeof(Class264.Class267))
					{
						dataGridViewRow.Cells[0].Value = "Attachment: " + @class.string_0;
						dataGridViewRow.Cells[1].Value = "";
					}
					dataGridViewRow.Tag = @class;
					this.vmethod_0().Rows.Add(dataGridViewRow);
				}
			}
			finally
			{
				List<Class264.Class265>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue)))
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.vmethod_0().Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj;
						if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Tag)) && objectValue == dataGridViewRow2.Tag)
						{
							dataGridViewRow2.Selected = true;
							break;
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
			}
		}

		// Token: 0x06007116 RID: 28950 RVA: 0x0004645A File Offset: 0x0004465A
		private void CampaignEditorWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x06007117 RID: 28951 RVA: 0x003CDA40 File Offset: 0x003CBC40
		private void method_4(object sender, EventArgs e)
		{
			this.vmethod_12().Filter = "Command scenario file (*.scen)|*.scen";
			if (this.vmethod_12().ShowDialog() == DialogResult.OK)
			{
				try
				{
					ScenContainer scenContainer = ScenContainer.smethod_2(this.vmethod_12().FileName);
					string text = null;
					double num = 0.0;
					Scenario scenario = scenContainer.method_8(ref text, ref num, false);
					scenario.CampaignID = this.class264_0.string_0;
					Class434.smethod_1(scenario, scenario.method_44()[0], this.vmethod_12().FileName, false, false);
					Class264.Class266 @class = new Class264.Class266();
					@class.string_0 = scenario.method_0();
					@class.string_1 = scenario.method_2();
					@class.string_2 = Path.GetFileName(this.vmethod_12().FileName);
					this.class264_0.list_0.Add(@class);
					this.method_3();
				}
				catch (Exception ex)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					DarkMessageBox.smethod_2("Unable to load selected scenario. The error was: " + ex.Message, "Error", Enum11.const_0);
				}
			}
		}

		// Token: 0x06007118 RID: 28952 RVA: 0x003CDB58 File Offset: 0x003CBD58
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count > 0)
			{
				try
				{
					foreach (object obj in this.vmethod_0().SelectedRows)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						this.class264_0.list_0.Remove((Class264.Class265)NewLateBinding.LateGet(objectValue, null, "Tag", new object[0], null, null, null));
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
				this.method_3();
			}
		}

		// Token: 0x06007119 RID: 28953 RVA: 0x003CDBF8 File Offset: 0x003CBDF8
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				if (this.vmethod_0().SelectedRows.Count > 1)
				{
					DarkMessageBox.smethod_2("Only one item can be re-arranged at a time", "One item a time!", Enum11.const_0);
					return;
				}
				Class264.Class265 item = (Class264.Class265)this.vmethod_0().SelectedRows[0].Tag;
				int num = this.class264_0.list_0.IndexOf(item);
				if (num != 0)
				{
					this.class264_0.list_0.Remove(item);
					this.class264_0.list_0.Insert(num - 1, item);
					this.method_3();
				}
			}
		}

		// Token: 0x0600711A RID: 28954 RVA: 0x003CDC9C File Offset: 0x003CBE9C
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				if (this.vmethod_0().SelectedRows.Count > 1)
				{
					DarkMessageBox.smethod_2("Only one item can be re-arranged at a time", "One item a time!", Enum11.const_0);
					return;
				}
				Class264.Class265 item = (Class264.Class265)this.vmethod_0().SelectedRows[0].Tag;
				int num = this.class264_0.list_0.IndexOf(item);
				if (num != this.class264_0.list_0.Count - 1)
				{
					this.class264_0.list_0.Remove(item);
					this.class264_0.list_0.Insert(num + 1, item);
					this.method_3();
				}
			}
		}

		// Token: 0x0600711B RID: 28955 RVA: 0x003CDD54 File Offset: 0x003CBF54
		private void method_8(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.string_0))
			{
				this.vmethod_14().Filter = "Command campaign file (*.campaign)|*.campaign";
				if (this.vmethod_14().ShowDialog() == DialogResult.OK)
				{
					this.class264_0.method_1(this.vmethod_14().FileName);
					this.string_0 = this.vmethod_14().FileName;
					return;
				}
			}
			else
			{
				this.class264_0.method_1(this.string_0);
			}
		}

		// Token: 0x0600711C RID: 28956 RVA: 0x00047010 File Offset: 0x00045210
		private void CampaignEditorWindow_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.method_3();
			}
		}

		// Token: 0x0600711D RID: 28957 RVA: 0x003CDDC8 File Offset: 0x003CBFC8
		private void method_9(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_73().string_0 = this.class264_0.string_1;
			Class2413.smethod_2().method_73().string_1 = this.class264_0.string_2;
			if (Class2413.smethod_2().method_73().ShowDialog() == DialogResult.OK)
			{
				this.class264_0.string_1 = Class2413.smethod_2().method_73().string_0;
				this.class264_0.string_2 = Class2413.smethod_2().method_73().string_1;
			}
		}

		// Token: 0x0600711E RID: 28958 RVA: 0x003CDE50 File Offset: 0x003CC050
		private void method_10(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				Class264.Class265 @class = (Class264.Class265)this.vmethod_0().SelectedRows[0].Tag;
				if (@class.GetType() == typeof(Class264.Class266))
				{
					this.vmethod_22().Visible = true;
					this.vmethod_26().Text = Conversions.ToString(((Class264.Class266)@class).method_0());
					return;
				}
				this.vmethod_22().Visible = false;
			}
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x003CDED4 File Offset: 0x003CC0D4
		private void method_11(object sender, EventArgs e)
		{
			if (Class2413.smethod_2().method_63().ShowDialog() == DialogResult.OK)
			{
				try
				{
					foreach (ScenAttachmentObject scenAttachmentObject in Class2413.smethod_2().method_63().list_0)
					{
						Class264.Class267 @class = new Class264.Class267();
						@class.string_0 = scenAttachmentObject.method_1();
						@class.string_1 = scenAttachmentObject.method_0();
						this.class264_0.list_0.Add(@class);
					}
				}
				finally
				{
					List<ScenAttachmentObject>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (Class2413.smethod_2().method_63().list_0.Count > 0)
				{
					this.method_3();
				}
			}
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x003CDF8C File Offset: 0x003CC18C
		private void method_12(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_73().string_0 = "Ending Text";
			Class2413.smethod_2().method_73().string_1 = this.class264_0.string_3;
			if (Class2413.smethod_2().method_73().ShowDialog() == DialogResult.OK)
			{
				this.class264_0.string_3 = Class2413.smethod_2().method_73().string_1;
			}
		}

		// Token: 0x06007121 RID: 28961 RVA: 0x003CDFF4 File Offset: 0x003CC1F4
		private void method_13(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count > 0)
			{
				try
				{
					foreach (object obj in this.vmethod_0().SelectedRows)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null))) && NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null).GetType() == typeof(Class264.Class266))
						{
							((Class264.Class266)NewLateBinding.LateGet(objectValue, null, "Tag", new object[0], null, null, null)).method_1(Conversions.ToInteger(this.vmethod_26().Text));
							this.method_3();
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
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x00044489 File Offset: 0x00042689
		private void CampaignEditorWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x003CE0E8 File Offset: 0x003CC2E8
		private void method_14(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && this.vmethod_0().Columns[e.ColumnIndex].CellType == typeof(DataGridViewButtonCell))
			{
				CampaignEditorWindow.Class2478 @class = new CampaignEditorWindow.Class2478();
				@class.campaignEditorWindow_0 = this;
				@class.class265_0 = (Class264.Class265)this.vmethod_0().Rows[e.RowIndex].Tag;
				if (@class.class265_0.enum46_0 == Class264.Enum46.const_0)
				{
					CampaignEditorWindow.Class2479 class2 = new CampaignEditorWindow.Class2479();
					class2.class2478_0 = @class;
					class2.string_0 = Guid.NewGuid().ToString();
					Task.Factory.StartNew(new Action(class2.method_0));
					((Class264.Class266)class2.class2478_0.class265_0).string_1 = class2.string_0;
					this.method_3();
				}
			}
		}

		// Token: 0x04003FBC RID: 16316
		[CompilerGenerated]
		[AccessedThroughProperty("DGV_CampaignItems")]
		private Class114 class114_0;

		// Token: 0x04003FBD RID: 16317
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_AddScenario")]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04003FBE RID: 16318
		[AccessedThroughProperty("TSB_RemoveSelected")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04003FBF RID: 16319
		[AccessedThroughProperty("TSB_MoveUp")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_2;

		// Token: 0x04003FC0 RID: 16320
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_MoveDown")]
		private ToolStripButton toolStripButton_3;

		// Token: 0x04003FC1 RID: 16321
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_Save")]
		private ToolStripButton toolStripButton_4;

		// Token: 0x04003FC2 RID: 16322
		[AccessedThroughProperty("OpenFileDialog_AddScen")]
		[CompilerGenerated]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04003FC3 RID: 16323
		[AccessedThroughProperty("SaveFileDialog_SaveCampaign")]
		[CompilerGenerated]
		private SaveFileDialog saveFileDialog_0;

		// Token: 0x04003FC4 RID: 16324
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_Description")]
		private ToolStripButton toolStripButton_5;

		// Token: 0x04003FC5 RID: 16325
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_AddAttachment")]
		private ToolStripButton toolStripButton_6;

		// Token: 0x04003FC6 RID: 16326
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_CampaignEnding")]
		private ToolStripButton toolStripButton_7;

		// Token: 0x04003FC7 RID: 16327
		[CompilerGenerated]
		[AccessedThroughProperty("TS_PassScore")]
		private Class125 class125_0;

		// Token: 0x04003FC8 RID: 16328
		[CompilerGenerated]
		[AccessedThroughProperty("TSL_PassScore")]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x04003FC9 RID: 16329
		[CompilerGenerated]
		[AccessedThroughProperty("TSTB_PassScore")]
		private ToolStripTextBox toolStripTextBox_0;

		// Token: 0x04003FCA RID: 16330
		[CompilerGenerated]
		[AccessedThroughProperty("TSL_SetScore")]
		private ToolStripButton toolStripButton_8;

		// Token: 0x04003FCB RID: 16331
		[AccessedThroughProperty("Column1")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04003FCC RID: 16332
		[AccessedThroughProperty("Column2")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04003FCD RID: 16333
		[CompilerGenerated]
		[AccessedThroughProperty("ScenarioID")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04003FCE RID: 16334
		[CompilerGenerated]
		[AccessedThroughProperty("ChangeScenID")]
		private DataGridViewButtonColumn dataGridViewButtonColumn_0;

		// Token: 0x04003FCF RID: 16335
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStrip1")]
		private Class125 class125_1;

		// Token: 0x04003FD0 RID: 16336
		public Class264 class264_0;

		// Token: 0x04003FD1 RID: 16337
		public string string_0;

		// Token: 0x02000E6C RID: 3692
		[CompilerGenerated]
		internal sealed class Class2478
		{
			// Token: 0x04003FD2 RID: 16338
			public Class264.Class265 class265_0;

			// Token: 0x04003FD3 RID: 16339
			public CampaignEditorWindow campaignEditorWindow_0;
		}

		// Token: 0x02000E6D RID: 3693
		[CompilerGenerated]
		internal sealed class Class2479
		{
			// Token: 0x06007126 RID: 28966 RVA: 0x003CE1CC File Offset: 0x003CC3CC
			internal void method_0()
			{
				string text = Path.Combine(Path.GetDirectoryName(Class264.smethod_4(this.class2478_0.campaignEditorWindow_0.class264_0.string_0)), ((Class264.Class266)this.class2478_0.class265_0).string_2);
				ScenContainer scenContainer = ScenContainer.smethod_2(text);
				string text2 = null;
				double num = 0.0;
				Scenario scenario = scenContainer.method_8(ref text2, ref num, false);
				scenario.method_3(this.string_0);
				File.Move(text, text + ".OLD");
				Class434.smethod_1(scenario, scenario.method_54(), text, false, false);
				File.Delete(text + ".OLD");
			}

			// Token: 0x04003FD4 RID: 16340
			public string string_0;

			// Token: 0x04003FD5 RID: 16341
			public CampaignEditorWindow.Class2478 class2478_0;
		}
	}
}
