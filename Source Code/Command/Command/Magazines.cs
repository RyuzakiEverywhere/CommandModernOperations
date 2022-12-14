using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns10;
using ns13;
using ns2;
using ns3;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000F0A RID: 3850
	[DesignerGenerated]
	public sealed partial class Magazines : DarkSecondaryFormBase, Interface66
	{
		// Token: 0x060088BE RID: 35006 RVA: 0x00493698 File Offset: 0x00491898
		public Magazines()
		{
			base.Load += this.Magazines_Load;
			base.Shown += this.Magazines_Shown;
			base.KeyDown += this.Magazines_KeyDown;
			base.FormClosing += this.Magazines_FormClosing;
			base.FormClosed += this.Magazines_FormClosed;
			base.Closed += this.Magazines_Closed;
			this.class2419_0 = new Class2419();
			this.InitializeComponent_1();
		}

		// Token: 0x060088C0 RID: 35008 RVA: 0x00493768 File Offset: 0x00491968
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Magazines));
			this.vmethod_1(new Class50());
			this.vmethod_3(new Class125());
			this.vmethod_19(new ToolStripButton());
			this.vmethod_21(new ToolStripButton());
			this.vmethod_15(new ToolStripButton());
			this.vmethod_5(new ToolStripButton());
			this.vmethod_7(new ToolStripLabel());
			this.vmethod_9(new ToolStripTextBox());
			this.vmethod_11(new ToolStripLabel());
			this.vmethod_13(new ToolStripComboBox());
			this.vmethod_17(new Timer(this.icontainer_1));
			this.vmethod_23(new Class44());
			this.vmethod_25(new Class44());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_2().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToOrderColumns = true;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().BackgroundColor = Color.FromArgb(43, 43, 43);
			this.vmethod_0().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_0().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_0().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_22(),
				this.vmethod_24()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().method_9(null);
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "TGV_Mags";
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().method_7(false);
			this.vmethod_0().Size = new Size(815, 300);
			this.vmethod_0().TabIndex = 5;
			this.vmethod_2().AutoSize = false;
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().Dock = DockStyle.Bottom;
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_18(),
				this.vmethod_20(),
				this.vmethod_14(),
				this.vmethod_4(),
				this.vmethod_6(),
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_12()
			});
			this.vmethod_2().Location = new Point(0, 303);
			this.vmethod_2().Name = "TS_Edit";
			this.vmethod_2().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_2().Size = new Size(815, 25);
			this.vmethod_2().TabIndex = 6;
			this.vmethod_2().Text = "ToolStrip1";
			this.vmethod_18().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Image = (Image)componentResourceManager.GetObject("TSB_AddMag.Image");
			this.vmethod_18().ImageScaling = ToolStripItemImageScaling.None;
			this.vmethod_18().ImageTransparentColor = Color.Magenta;
			this.vmethod_18().Name = "TSB_AddMag";
			this.vmethod_18().Size = new Size(103, 22);
			this.vmethod_18().Text = "Add Magazine";
			this.vmethod_20().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Image = (Image)componentResourceManager.GetObject("TSB_RemoveMag.Image");
			this.vmethod_20().ImageTransparentColor = Color.Magenta;
			this.vmethod_20().Name = "TSB_RemoveMag";
			this.vmethod_20().Size = new Size(124, 22);
			this.vmethod_20().Text = "Remove Magazine";
			this.vmethod_14().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Image = (Image)componentResourceManager.GetObject("TSB_AddRec.Image");
			this.vmethod_14().ImageTransparentColor = Color.Magenta;
			this.vmethod_14().Name = "TSB_AddRec";
			this.vmethod_14().Size = new Size(101, 22);
			this.vmethod_14().Text = "Add Weapons";
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Image = (Image)componentResourceManager.GetObject("TSB_RemoveRec.Image");
			this.vmethod_4().ImageTransparentColor = Color.Magenta;
			this.vmethod_4().Name = "TSB_RemoveRec";
			this.vmethod_4().Size = new Size(122, 22);
			this.vmethod_4().Text = "Remove Weapons";
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Name = "ToolStripLabel1";
			this.vmethod_6().Size = new Size(90, 22);
			this.vmethod_6().Text = "Weapon Count:";
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Name = "TSTB_RecCount";
			this.vmethod_8().Size = new Size(50, 25);
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Name = "ToolStripLabel2";
			this.vmethod_10().Size = new Size(42, 22);
			this.vmethod_10().Text = "Status:";
			this.vmethod_12().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Items.AddRange(new object[]
			{
				"Operational",
				"Damaged (Light)",
				"Damaged (Medium)",
				"Damaged (Heavy)",
				"Destroyed"
			});
			this.vmethod_12().Name = "TSC_MagStatus";
			this.vmethod_12().Size = new Size(121, 25);
			this.vmethod_16().Interval = 1000;
			this.vmethod_22().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_22().DataPropertyName = "Name";
			this.vmethod_22().method_0(null);
			this.vmethod_22().HeaderText = "Magazine";
			this.vmethod_22().Name = "Magazine";
			this.vmethod_22().Resizable = DataGridViewTriState.True;
			this.vmethod_22().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_24().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_24().method_0(null);
			this.vmethod_24().HeaderText = "Status";
			this.vmethod_24().Name = "Status";
			this.vmethod_24().ReadOnly = true;
			this.vmethod_24().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_24().Width = 43;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(815, 328);
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Magazines";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Magazines";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x060088C1 RID: 35009 RVA: 0x000521CE File Offset: 0x000503CE
		[CompilerGenerated]
		private Class50 vmethod_0()
		{
			return this.class50_0;
		}

		// Token: 0x060088C2 RID: 35010 RVA: 0x00494100 File Offset: 0x00492300
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_1(Class50 class50_1)
		{
			DataGridViewCellMouseEventHandler value = new DataGridViewCellMouseEventHandler(this.method_10);
			Delegate1 delegate1_ = new Delegate1(this.method_19);
			Delegate3 delegate3_ = new Delegate3(this.method_21);
			Class50 @class = this.class50_0;
			if (@class != null)
			{
				@class.CellMouseClick -= value;
				@class.method_12(delegate1_);
				@class.method_16(delegate3_);
			}
			this.class50_0 = class50_1;
			@class = this.class50_0;
			if (@class != null)
			{
				@class.CellMouseClick += value;
				@class.method_11(delegate1_);
				@class.method_15(delegate3_);
			}
		}

		// Token: 0x060088C3 RID: 35011 RVA: 0x000521D6 File Offset: 0x000503D6
		[CompilerGenerated]
		internal Class125 vmethod_2()
		{
			return this.class125_0;
		}

		// Token: 0x060088C4 RID: 35012 RVA: 0x000521DE File Offset: 0x000503DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x060088C5 RID: 35013 RVA: 0x000521E7 File Offset: 0x000503E7
		[CompilerGenerated]
		internal ToolStripButton vmethod_4()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x060088C6 RID: 35014 RVA: 0x0049417C File Offset: 0x0049237C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_4)
		{
			EventHandler value = new EventHandler(this.method_12);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_4;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060088C7 RID: 35015 RVA: 0x000521EF File Offset: 0x000503EF
		[CompilerGenerated]
		internal ToolStripLabel vmethod_6()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x060088C8 RID: 35016 RVA: 0x000521F7 File Offset: 0x000503F7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripLabel toolStripLabel_2)
		{
			this.toolStripLabel_0 = toolStripLabel_2;
		}

		// Token: 0x060088C9 RID: 35017 RVA: 0x00052200 File Offset: 0x00050400
		[CompilerGenerated]
		internal ToolStripTextBox vmethod_8()
		{
			return this.toolStripTextBox_0;
		}

		// Token: 0x060088CA RID: 35018 RVA: 0x004941C0 File Offset: 0x004923C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripTextBox toolStripTextBox_1)
		{
			EventHandler value = new EventHandler(this.method_13);
			EventHandler value2 = new EventHandler(this.method_15);
			EventHandler value3 = new EventHandler(this.method_16);
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

		// Token: 0x060088CB RID: 35019 RVA: 0x00052208 File Offset: 0x00050408
		[CompilerGenerated]
		internal ToolStripLabel vmethod_10()
		{
			return this.toolStripLabel_1;
		}

		// Token: 0x060088CC RID: 35020 RVA: 0x00052210 File Offset: 0x00050410
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripLabel toolStripLabel_2)
		{
			this.toolStripLabel_1 = toolStripLabel_2;
		}

		// Token: 0x060088CD RID: 35021 RVA: 0x00052219 File Offset: 0x00050419
		[CompilerGenerated]
		internal ToolStripComboBox vmethod_12()
		{
			return this.toolStripComboBox_0;
		}

		// Token: 0x060088CE RID: 35022 RVA: 0x00052221 File Offset: 0x00050421
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ToolStripComboBox toolStripComboBox_1)
		{
			this.toolStripComboBox_0 = toolStripComboBox_1;
		}

		// Token: 0x060088CF RID: 35023 RVA: 0x0005222A File Offset: 0x0005042A
		[CompilerGenerated]
		internal ToolStripButton vmethod_14()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x060088D0 RID: 35024 RVA: 0x0049423C File Offset: 0x0049243C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripButton toolStripButton_4)
		{
			EventHandler value = new EventHandler(this.method_11);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_4;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060088D1 RID: 35025 RVA: 0x00052232 File Offset: 0x00050432
		[CompilerGenerated]
		internal Timer vmethod_16()
		{
			return this.timer_0;
		}

		// Token: 0x060088D2 RID: 35026 RVA: 0x0005223A File Offset: 0x0005043A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Timer timer_1)
		{
			this.timer_0 = timer_1;
		}

		// Token: 0x060088D3 RID: 35027 RVA: 0x00052243 File Offset: 0x00050443
		[CompilerGenerated]
		internal ToolStripButton vmethod_18()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x060088D4 RID: 35028 RVA: 0x00494280 File Offset: 0x00492480
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(ToolStripButton toolStripButton_4)
		{
			EventHandler value = new EventHandler(this.method_17);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_4;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060088D5 RID: 35029 RVA: 0x0005224B File Offset: 0x0005044B
		[CompilerGenerated]
		internal ToolStripButton vmethod_20()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x060088D6 RID: 35030 RVA: 0x004942C4 File Offset: 0x004924C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(ToolStripButton toolStripButton_4)
		{
			EventHandler value = new EventHandler(this.method_18);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_3 = toolStripButton_4;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060088D7 RID: 35031 RVA: 0x00052253 File Offset: 0x00050453
		[CompilerGenerated]
		internal Class44 vmethod_22()
		{
			return this.class44_0;
		}

		// Token: 0x060088D8 RID: 35032 RVA: 0x0005225B File Offset: 0x0005045B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class44 class44_2)
		{
			this.class44_0 = class44_2;
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x00052264 File Offset: 0x00050464
		[CompilerGenerated]
		internal Class44 vmethod_24()
		{
			return this.class44_1;
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x0005226C File Offset: 0x0005046C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class44 class44_2)
		{
			this.class44_1 = class44_2;
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x00052275 File Offset: 0x00050475
		[CompilerGenerated]
		private ComboBox vmethod_26()
		{
			return this.comboBox_0;
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x00494308 File Offset: 0x00492508
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_27(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.method_14);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_1;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060088DD RID: 35037 RVA: 0x0005227D File Offset: 0x0005047D
		public void imethod_0()
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
		}

		// Token: 0x060088DE RID: 35038 RVA: 0x0049434C File Offset: 0x0049254C
		private void Magazines_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_27(this.vmethod_12().ComboBox);
			PlatformComponent.smethod_0(new PlatformComponent.Delegate46(this.method_6));
			WeaponRec.smethod_0(new WeaponRec.Delegate54(this.method_5));
			Magazine.smethod_2(new Magazine.Delegate42(this.method_3));
			Magazine.smethod_4(new Magazine.Delegate43(this.method_4));
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x004943C4 File Offset: 0x004925C4
		private void Magazines_Shown(object sender, EventArgs e)
		{
			this.vmethod_2().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_14().Enabled = false;
			this.vmethod_4().Enabled = false;
			this.method_7();
			this.Text = "Magazine status - " + this.activeUnit_0.Name;
		}

		// Token: 0x060088E0 RID: 35040 RVA: 0x00494424 File Offset: 0x00492624
		private void method_3(string string_0, string string_1)
		{
			try
			{
				IEnumerator<Class48> enumerator = this.vmethod_0().method_2().GetEnumerator();
				while (enumerator.MoveNext())
				{
					Magazines.Class2524 @class = new Magazines.Class2524(@class);
					@class.magazines_0 = this;
					@class.class48_0 = enumerator.Current;
					if (@class.class48_0.Tag != null && @class.class48_0.Tag.GetType() == typeof(Magazine))
					{
						Magazine magazine = (Magazine)@class.class48_0.Tag;
						if (Operators.CompareString(magazine.string_0, string_0, false) == 0)
						{
							try
							{
								List<WeaponRec>.Enumerator enumerator2 = magazine.vmethod_10().GetEnumerator();
								while (enumerator2.MoveNext())
								{
									Magazines.Class2525 class2 = new Magazines.Class2525(class2);
									class2.class2524_0 = @class;
									class2.weaponRec_0 = enumerator2.Current;
									if (Operators.CompareString(class2.weaponRec_0.string_0, string_1, false) == 0)
									{
										base.Invoke(new VB$AnonymousDelegate_0(class2.method_0));
										break;
									}
								}
							}
							finally
							{
								List<WeaponRec>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							break;
						}
					}
				}
			}
			finally
			{
				IEnumerator<Class48> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060088E1 RID: 35041 RVA: 0x0049454C File Offset: 0x0049274C
		private void method_4(string string_0, string string_1)
		{
			try
			{
				IEnumerator<Class48> enumerator = this.vmethod_0().method_2().GetEnumerator();
				while (enumerator.MoveNext())
				{
					Magazines.Class2526 @class = new Magazines.Class2526(@class);
					@class.class48_0 = enumerator.Current;
					if (@class.class48_0.Tag != null && @class.class48_0.Tag.GetType() == typeof(Magazine) && Operators.CompareString(((Magazine)@class.class48_0.Tag).string_0, string_0, false) == 0)
					{
						try
						{
							IEnumerator<Class48> enumerator2 = @class.class48_0.method_7().GetEnumerator();
							while (enumerator2.MoveNext())
							{
								Magazines.Class2527 class2 = new Magazines.Class2527(class2);
								class2.class2526_0 = @class;
								class2.class48_0 = enumerator2.Current;
								if (class2.class48_0.Tag != null && class2.class48_0.Tag.GetType() == typeof(WeaponRec) && Operators.CompareString(((WeaponRec)class2.class48_0.Tag).string_0, string_1, false) == 0)
								{
									base.Invoke(new VB$AnonymousDelegate_0(class2.method_0));
									break;
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						break;
					}
				}
			}
			finally
			{
				IEnumerator<Class48> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060088E2 RID: 35042 RVA: 0x004946B0 File Offset: 0x004928B0
		private void method_5(string string_0)
		{
			Magazines.Class2529 @class = new Magazines.Class2529(@class);
			@class.magazines_0 = this;
			if (this.activeUnit_0 != null)
			{
				try
				{
					foreach (Class48 class2 in this.vmethod_0().method_2())
					{
						if (class2.Tag != null && class2.Tag.GetType() == typeof(Magazine))
						{
							Magazine magazine = (Magazine)class2.Tag;
							try
							{
								IEnumerator<Class48> enumerator2 = class2.method_7().GetEnumerator();
								while (enumerator2.MoveNext())
								{
									Magazines.Class2528 class3 = new Magazines.Class2528(class3);
									class3.class2529_0 = @class;
									class3.class48_0 = enumerator2.Current;
									if (class3.class48_0.Tag != null && class3.class48_0.Tag.GetType() == typeof(WeaponRec))
									{
										class3.class2529_0.weaponRec_0 = (WeaponRec)class3.class48_0.Tag;
										if (Operators.CompareString(class3.class2529_0.weaponRec_0.string_0, string_0, false) == 0)
										{
											base.Invoke(new VB$AnonymousDelegate_0(class3.method_0));
											break;
										}
									}
								}
							}
							finally
							{
								IEnumerator<Class48> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
							break;
						}
					}
				}
				finally
				{
					IEnumerator<Class48> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x060088E3 RID: 35043 RVA: 0x0049482C File Offset: 0x00492A2C
		private void method_6(PlatformComponent platformComponent_0)
		{
			try
			{
				IEnumerator<Class48> enumerator = this.vmethod_0().method_2().GetEnumerator();
				while (enumerator.MoveNext())
				{
					Magazines.Class2530 @class = new Magazines.Class2530(@class);
					@class.magazines_0 = this;
					@class.class48_0 = enumerator.Current;
					if (@class.class48_0.Tag != null && @class.class48_0.Tag.GetType() == typeof(Magazine))
					{
						Magazines.Class2531 class2 = new Magazines.Class2531(class2);
						class2.class2530_0 = @class;
						class2.magazine_0 = (Magazine)class2.class2530_0.class48_0.Tag;
						if (Operators.CompareString(class2.magazine_0.string_0, platformComponent_0.string_0, false) == 0)
						{
							base.Invoke(new VB$AnonymousDelegate_0(class2.method_0));
							break;
						}
					}
				}
			}
			finally
			{
				IEnumerator<Class48> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x0005228B File Offset: 0x0005048B
		private void method_7()
		{
			if (this.activeUnit_0 != null)
			{
				this.vmethod_0().method_2().Clear();
				Task.Factory.StartNew(new Action(this.method_22));
			}
		}

		// Token: 0x060088E5 RID: 35045 RVA: 0x00494910 File Offset: 0x00492B10
		private void method_8(Magazine magazine_1)
		{
			Class48 @class = this.vmethod_0().method_2().method_0("New Node");
			this.method_9(@class, magazine_1);
			if (magazine_1.vmethod_10().Count > 0)
			{
				@class.method_7().method_0("Temp");
			}
		}

		// Token: 0x060088E6 RID: 35046 RVA: 0x0049495C File Offset: 0x00492B5C
		private void method_9(Class48 class48_0, Magazine magazine_1)
		{
			string text;
			if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_140())
			{
				text = Misc.smethod_9(magazine_1.Name) + " [" + magazine_1.method_18().Name + "]";
			}
			else
			{
				text = Misc.smethod_9(magazine_1.Name);
			}
			Color foreColor = base.method_2(magazine_1);
			class48_0.SetValues(new object[]
			{
				text,
				magazine_1.vmethod_5().ToString()
			});
			class48_0.DefaultCellStyle.ForeColor = foreColor;
			class48_0.Tag = magazine_1;
		}

		// Token: 0x060088E7 RID: 35047 RVA: 0x00494A00 File Offset: 0x00492C00
		private void method_10(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex != -1 && !Information.IsNothing(this.vmethod_0().method_5()))
			{
				if (this.vmethod_0().method_5().Tag.GetType() == typeof(Magazine))
				{
					this.magazine_0 = (Magazine)this.vmethod_0().method_5().Tag;
					this.vmethod_4().Enabled = false;
					this.vmethod_8().Enabled = false;
					this.vmethod_12().Enabled = true;
				}
				if (this.vmethod_0().method_5().Tag.GetType() == typeof(WeaponRec))
				{
					this.magazine_0 = (Magazine)this.vmethod_0().method_5().method_9().Tag;
					this.weaponRec_0 = (WeaponRec)this.vmethod_0().method_5().Tag;
					this.vmethod_4().Enabled = true;
					this.vmethod_8().Enabled = true;
					this.vmethod_12().Enabled = false;
				}
				switch (this.magazine_0.vmethod_5())
				{
				case PlatformComponent._ComponentStatus.Operational:
					this.vmethod_12().SelectedIndex = 0;
					return;
				case PlatformComponent._ComponentStatus.Damaged:
					this.vmethod_12().SelectedIndex = 1;
					return;
				case PlatformComponent._ComponentStatus.Destroyed:
					this.vmethod_12().SelectedIndex = 2;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060088E8 RID: 35048 RVA: 0x000522BC File Offset: 0x000504BC
		private void method_11(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_6().form_0 = this;
			Class2413.smethod_2().method_6().Show();
		}

		// Token: 0x060088E9 RID: 35049 RVA: 0x00494B54 File Offset: 0x00492D54
		private void method_12(object sender, EventArgs e)
		{
			int count = this.vmethod_0().SelectedRows.Count;
			if (count != 0)
			{
				if (count == 1)
				{
					this.magazine_0.vmethod_10().method_6(this.weaponRec_0);
					return;
				}
				List<DataGridViewRow> list = new List<DataGridViewRow>();
				try
				{
					foreach (object obj in this.vmethod_0().SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (dataGridViewRow.Tag.GetType() == typeof(WeaponRec))
						{
							list.Add(dataGridViewRow);
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
				if (DarkMessageBox.smethod_1("Are you sure?", "Remove " + Conversions.ToString(list.Count) + " weapon records", Enum11.const_2) == DialogResult.OK)
				{
					try
					{
						foreach (DataGridViewRow dataGridViewRow2 in list)
						{
							this.magazine_0.vmethod_10().method_6((WeaponRec)dataGridViewRow2.Tag);
						}
					}
					finally
					{
						List<DataGridViewRow>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
		}

		// Token: 0x060088EA RID: 35050 RVA: 0x00494C80 File Offset: 0x00492E80
		private void method_13(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.weaponRec_0) && (Operators.CompareString(this.vmethod_8().Text, "", false) != 0 & Versioned.IsNumeric(this.vmethod_8().Text)))
			{
				int num = Conversions.ToInteger(this.vmethod_8().Text);
				if (num < 0)
				{
					num = 0;
				}
				if (num > this.weaponRec_0.int_2)
				{
					num = this.weaponRec_0.int_2;
				}
				if ((double)num / (double)this.weaponRec_0.int_4 > (double)this.weaponRec_0.int_2)
				{
					num = this.weaponRec_0.int_2;
				}
				this.weaponRec_0.method_10(0);
				Magazine magazine = this.magazine_0;
				int num2 = 0;
				int num3 = 0;
				int num4 = magazine.method_27(ref num2, ref num3);
				if ((double)num / (double)this.weaponRec_0.int_4 > (double)(this.magazine_0.int_1 - num4))
				{
					num = this.magazine_0.int_1 - num4 * this.weaponRec_0.int_4;
				}
				if (num < 0)
				{
					num = 0;
				}
				this.weaponRec_0.method_10(num);
				try
				{
					foreach (Class48 @class in this.vmethod_0().method_2())
					{
						try
						{
							foreach (Class48 class2 in @class.method_7())
							{
								if (class2.Tag == this.weaponRec_0)
								{
									class2.SetValues(new object[]
									{
										string.Concat(new string[]
										{
											Conversions.ToString(this.weaponRec_0.method_9()),
											"/",
											Conversions.ToString(this.weaponRec_0.int_2),
											" ",
											Misc.smethod_9(Strings.Trim(this.weaponRec_0.method_12(Client.smethod_46()).Name))
										})
									});
									return;
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
				}
				finally
				{
					IEnumerator<Class48> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x060088EB RID: 35051 RVA: 0x00494EA4 File Offset: 0x004930A4
		private void method_14(object sender, EventArgs e)
		{
			switch (this.vmethod_26().SelectedIndex)
			{
			case 0:
				this.magazine_0.method_22(true);
				return;
			case 1:
				this.magazine_0.vmethod_8(PlatformComponent._DamageSeverityFactor.Light);
				return;
			case 2:
				this.magazine_0.vmethod_8(PlatformComponent._DamageSeverityFactor.Medium);
				return;
			case 3:
				this.magazine_0.vmethod_8(PlatformComponent._DamageSeverityFactor.Heavy);
				return;
			case 4:
				this.magazine_0.vmethod_6(this.activeUnit_0.vmethod_7(false), true, this.magazine_0.method_18().method_6());
				return;
			default:
				return;
			}
		}

		// Token: 0x060088EC RID: 35052 RVA: 0x00494F34 File Offset: 0x00493134
		private void Magazines_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F5 && base.Visible)
			{
				base.Close();
				return;
			}
			if (this.bool_3 && (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (!this.bool_3 && (e.KeyValue != 32 || !base.Visible))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060088ED RID: 35053 RVA: 0x00044820 File Offset: 0x00042A20
		private void Magazines_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060088EE RID: 35054 RVA: 0x000522DD File Offset: 0x000504DD
		private void method_15(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x060088EF RID: 35055 RVA: 0x000522E6 File Offset: 0x000504E6
		private void method_16(object sender, EventArgs e)
		{
			this.bool_3 = false;
			this.vmethod_10().Select();
		}

		// Token: 0x060088F0 RID: 35056 RVA: 0x000522FA File Offset: 0x000504FA
		private void Magazines_FormClosed(object sender, FormClosedEventArgs e)
		{
			PlatformComponent.smethod_1(new PlatformComponent.Delegate46(this.method_6));
			WeaponRec.smethod_1(new WeaponRec.Delegate54(this.method_5));
		}

		// Token: 0x060088F1 RID: 35057 RVA: 0x0005231E File Offset: 0x0005051E
		private void method_17(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && !this.activeUnit_0.bool_1)
			{
				Class2413.smethod_2().method_1().form_0 = this;
				Class2413.smethod_2().method_1().Show();
			}
		}

		// Token: 0x060088F2 RID: 35058 RVA: 0x0049503C File Offset: 0x0049323C
		private void method_18(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) & !Information.IsNothing(this.magazine_0))
			{
				if (this.activeUnit_0.vmethod_43())
				{
					((Class350)this.activeUnit_0).method_141(this.magazine_0);
					return;
				}
				if (this.activeUnit_0.bool_1)
				{
					try
					{
						foreach (ActiveUnit activeUnit in ((Group)this.activeUnit_0).vmethod_141().Values)
						{
							if (activeUnit.vmethod_43() && Enumerable.Contains<Magazine>(((Class350)activeUnit).magazine_0, this.magazine_0))
							{
								((Class350)activeUnit).method_141(this.magazine_0);
								break;
							}
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
				}
			}
		}

		// Token: 0x060088F3 RID: 35059 RVA: 0x00495118 File Offset: 0x00493318
		private void method_19(object sender, EventArgs1 e)
		{
			if (e.method_0().Tag != null && e.method_0().Tag.GetType() == typeof(Magazine))
			{
				Magazines.Class2534 @class = new Magazines.Class2534(@class);
				@class.magazines_0 = this;
				@class.class48_0 = e.method_0();
				Magazine magazine = (Magazine)e.method_0().Tag;
				@class.class48_0.method_7().Clear();
				@class.list_0 = Enumerable.ToList<WeaponRec>(Enumerable.OrderBy<WeaponRec, string>(Enumerable.Where<WeaponRec>(magazine.vmethod_10(), (Magazines._Closure$__.$I87-0 == null) ? (Magazines._Closure$__.$I87-0 = new Func<WeaponRec, bool>(Magazines._Closure$__.$I.method_0)) : Magazines._Closure$__.$I87-0), (Magazines._Closure$__.$I87-1 == null) ? (Magazines._Closure$__.$I87-1 = new Func<WeaponRec, string>(Magazines._Closure$__.$I.method_1)) : Magazines._Closure$__.$I87-1, new Class440<string[]>(true)));
				@class.list_1 = Enumerable.ToList<WeaponRec>(Enumerable.OrderBy<WeaponRec, string>(Enumerable.Where<WeaponRec>(magazine.vmethod_10(), (Magazines._Closure$__.$I87-2 == null) ? (Magazines._Closure$__.$I87-2 = new Func<WeaponRec, bool>(Magazines._Closure$__.$I.method_2)) : Magazines._Closure$__.$I87-2), (Magazines._Closure$__.$I87-3 == null) ? (Magazines._Closure$__.$I87-3 = new Func<WeaponRec, string>(Magazines._Closure$__.$I.method_3)) : Magazines._Closure$__.$I87-3, new Class440<string[]>(true)));
				Task.Factory.StartNew(new Action(@class.method_0));
			}
		}

		// Token: 0x060088F4 RID: 35060 RVA: 0x00495278 File Offset: 0x00493478
		private void method_20(Class48 class48_0, WeaponRec weaponRec_1)
		{
			class48_0.method_7().method_0(string.Concat(new string[]
			{
				Conversions.ToString(weaponRec_1.method_9()),
				"/",
				Conversions.ToString(weaponRec_1.int_2),
				" ",
				Misc.smethod_9(Strings.Trim(weaponRec_1.method_12(this.activeUnit_0.scenario_0).Name))
			})).Tag = weaponRec_1;
		}

		// Token: 0x060088F5 RID: 35061 RVA: 0x004952F0 File Offset: 0x004934F0
		private void Magazines_Closed(object sender, EventArgs e)
		{
			PlatformComponent.smethod_1(new PlatformComponent.Delegate46(this.method_6));
			WeaponRec.smethod_1(new WeaponRec.Delegate54(this.method_5));
			Magazine.smethod_3(new Magazine.Delegate42(this.method_3));
			Magazine.smethod_5(new Magazine.Delegate43(this.method_4));
		}

		// Token: 0x060088F6 RID: 35062 RVA: 0x00052359 File Offset: 0x00050559
		private void method_21(object sender, EventArgs0 e)
		{
			e.method_0().method_7().Clear();
			e.method_0().method_7().method_0("Temp");
		}

		// Token: 0x060088F7 RID: 35063 RVA: 0x00495344 File Offset: 0x00493544
		[CompilerGenerated]
		private void method_22()
		{
			try
			{
				List<Mount>.Enumerator enumerator = this.activeUnit_0.vmethod_51().GetEnumerator();
				while (enumerator.MoveNext())
				{
					Magazines.Class2532 @class = new Magazines.Class2532(@class);
					@class.magazines_0 = this;
					@class.mount_0 = enumerator.Current;
					if (@class.mount_0.method_32().vmethod_10().Count > 0)
					{
						base.Invoke(new VB$AnonymousDelegate_0(@class.method_0));
					}
				}
			}
			finally
			{
				List<Mount>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			Magazine[] array = this.activeUnit_0.vmethod_117();
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					Magazines.Class2533 class2 = new Magazines.Class2533(class2);
					class2.magazines_0 = this;
					class2.magazine_0 = array[i];
					base.Invoke(new VB$AnonymousDelegate_0(class2.method_0));
				}
				base.Invoke(new VB$AnonymousDelegate_0(this.method_23));
			}
		}

		// Token: 0x060088F8 RID: 35064 RVA: 0x00495430 File Offset: 0x00493630
		[CompilerGenerated]
		private void method_23()
		{
			if (this.vmethod_0().method_2().Count > 0)
			{
				this.magazine_0 = (Magazine)this.vmethod_0().method_2()[0].Tag;
				this.vmethod_14().Enabled = true;
				this.vmethod_4().Enabled = true;
			}
			else
			{
				this.vmethod_14().Enabled = false;
				this.vmethod_4().Enabled = false;
			}
			this.vmethod_18().Visible = !this.activeUnit_0.bool_1;
		}

		// Token: 0x04004A53 RID: 19027
		[CompilerGenerated]
		[AccessedThroughProperty("TGV_Mags")]
		private Class50 class50_0;

		// Token: 0x04004A54 RID: 19028
		[CompilerGenerated]
		[AccessedThroughProperty("TS_Edit")]
		private Class125 class125_0;

		// Token: 0x04004A55 RID: 19029
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_RemoveRec")]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04004A56 RID: 19030
		[AccessedThroughProperty("ToolStripLabel1")]
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x04004A57 RID: 19031
		[AccessedThroughProperty("TSTB_RecCount")]
		[CompilerGenerated]
		private ToolStripTextBox toolStripTextBox_0;

		// Token: 0x04004A58 RID: 19032
		[AccessedThroughProperty("ToolStripLabel2")]
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_1;

		// Token: 0x04004A59 RID: 19033
		[AccessedThroughProperty("TSC_MagStatus")]
		[CompilerGenerated]
		private ToolStripComboBox toolStripComboBox_0;

		// Token: 0x04004A5A RID: 19034
		[AccessedThroughProperty("TSB_AddRec")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04004A5B RID: 19035
		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private Timer timer_0;

		// Token: 0x04004A5C RID: 19036
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_AddMag")]
		private ToolStripButton toolStripButton_2;

		// Token: 0x04004A5D RID: 19037
		[AccessedThroughProperty("TSB_RemoveMag")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_3;

		// Token: 0x04004A5E RID: 19038
		[AccessedThroughProperty("Column_Magazine")]
		[CompilerGenerated]
		private Class44 class44_0;

		// Token: 0x04004A5F RID: 19039
		[AccessedThroughProperty("Status")]
		[CompilerGenerated]
		private Class44 class44_1;

		// Token: 0x04004A60 RID: 19040
		public ActiveUnit activeUnit_0;

		// Token: 0x04004A61 RID: 19041
		public Magazine magazine_0;

		// Token: 0x04004A62 RID: 19042
		private WeaponRec weaponRec_0;

		// Token: 0x04004A63 RID: 19043
		private Class2419 class2419_0;

		// Token: 0x04004A64 RID: 19044
		[AccessedThroughProperty("CB1")]
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04004A65 RID: 19045
		private bool bool_3;

		// Token: 0x02000F0B RID: 3851
		[CompilerGenerated]
		internal sealed class Class2524
		{
			// Token: 0x060088F9 RID: 35065 RVA: 0x00052381 File Offset: 0x00050581
			public Class2524(Magazines.Class2524 class2524_0)
			{
				if (class2524_0 != null)
				{
					this.class48_0 = class2524_0.class48_0;
				}
			}

			// Token: 0x04004A66 RID: 19046
			public Class48 class48_0;

			// Token: 0x04004A67 RID: 19047
			public Magazines magazines_0;
		}

		// Token: 0x02000F0C RID: 3852
		[CompilerGenerated]
		internal sealed class Class2525
		{
			// Token: 0x060088FA RID: 35066 RVA: 0x00052398 File Offset: 0x00050598
			public Class2525(Magazines.Class2525 class2525_0)
			{
				if (class2525_0 != null)
				{
					this.weaponRec_0 = class2525_0.weaponRec_0;
				}
			}

			// Token: 0x060088FB RID: 35067 RVA: 0x004954BC File Offset: 0x004936BC
			internal void method_0()
			{
				this.class2524_0.magazines_0.method_20(this.class2524_0.class48_0, this.weaponRec_0);
				if (!this.class2524_0.class48_0.method_0())
				{
					this.class2524_0.class48_0.vmethod_4();
				}
			}

			// Token: 0x04004A68 RID: 19048
			public WeaponRec weaponRec_0;

			// Token: 0x04004A69 RID: 19049
			public Magazines.Class2524 class2524_0;
		}

		// Token: 0x02000F0D RID: 3853
		[CompilerGenerated]
		internal sealed class Class2526
		{
			// Token: 0x060088FC RID: 35068 RVA: 0x000523AF File Offset: 0x000505AF
			public Class2526(Magazines.Class2526 class2526_0)
			{
				if (class2526_0 != null)
				{
					this.class48_0 = class2526_0.class48_0;
				}
			}

			// Token: 0x04004A6A RID: 19050
			public Class48 class48_0;
		}

		// Token: 0x02000F0E RID: 3854
		[CompilerGenerated]
		internal sealed class Class2527
		{
			// Token: 0x060088FD RID: 35069 RVA: 0x000523C6 File Offset: 0x000505C6
			public Class2527(Magazines.Class2527 class2527_0)
			{
				if (class2527_0 != null)
				{
					this.class48_0 = class2527_0.class48_0;
				}
			}

			// Token: 0x060088FE RID: 35070 RVA: 0x000523DD File Offset: 0x000505DD
			internal void method_0()
			{
				this.class2526_0.class48_0.method_7().Remove(this.class48_0);
			}

			// Token: 0x04004A6B RID: 19051
			public Class48 class48_0;

			// Token: 0x04004A6C RID: 19052
			public Magazines.Class2526 class2526_0;
		}

		// Token: 0x02000F0F RID: 3855
		[CompilerGenerated]
		internal sealed class Class2528
		{
			// Token: 0x060088FF RID: 35071 RVA: 0x000523FB File Offset: 0x000505FB
			public Class2528(Magazines.Class2528 class2528_0)
			{
				if (class2528_0 != null)
				{
					this.class48_0 = class2528_0.class48_0;
				}
			}

			// Token: 0x06008900 RID: 35072 RVA: 0x00495510 File Offset: 0x00493710
			internal void method_0()
			{
				this.class48_0.SetValues(new object[]
				{
					string.Concat(new string[]
					{
						Conversions.ToString(this.class2529_0.weaponRec_0.method_9()),
						"/",
						Conversions.ToString(this.class2529_0.weaponRec_0.int_2),
						" ",
						Misc.smethod_9(Strings.Trim(this.class2529_0.weaponRec_0.method_12(this.class2529_0.magazines_0.activeUnit_0.scenario_0).Name))
					})
				});
			}

			// Token: 0x04004A6D RID: 19053
			public Class48 class48_0;

			// Token: 0x04004A6E RID: 19054
			public Magazines.Class2529 class2529_0;
		}

		// Token: 0x02000F10 RID: 3856
		[CompilerGenerated]
		internal sealed class Class2529
		{
			// Token: 0x06008901 RID: 35073 RVA: 0x00052412 File Offset: 0x00050612
			public Class2529(Magazines.Class2529 class2529_0)
			{
				if (class2529_0 != null)
				{
					this.weaponRec_0 = class2529_0.weaponRec_0;
				}
			}

			// Token: 0x04004A6F RID: 19055
			public WeaponRec weaponRec_0;

			// Token: 0x04004A70 RID: 19056
			public Magazines magazines_0;
		}

		// Token: 0x02000F11 RID: 3857
		[CompilerGenerated]
		internal sealed class Class2530
		{
			// Token: 0x06008902 RID: 35074 RVA: 0x00052429 File Offset: 0x00050629
			public Class2530(Magazines.Class2530 class2530_0)
			{
				if (class2530_0 != null)
				{
					this.class48_0 = class2530_0.class48_0;
				}
			}

			// Token: 0x04004A71 RID: 19057
			public Class48 class48_0;

			// Token: 0x04004A72 RID: 19058
			public Magazines magazines_0;
		}

		// Token: 0x02000F12 RID: 3858
		[CompilerGenerated]
		internal sealed class Class2531
		{
			// Token: 0x06008903 RID: 35075 RVA: 0x00052440 File Offset: 0x00050640
			public Class2531(Magazines.Class2531 class2531_0)
			{
				if (class2531_0 != null)
				{
					this.magazine_0 = class2531_0.magazine_0;
				}
			}

			// Token: 0x06008904 RID: 35076 RVA: 0x00052457 File Offset: 0x00050657
			internal void method_0()
			{
				this.class2530_0.magazines_0.method_9(this.class2530_0.class48_0, this.magazine_0);
			}

			// Token: 0x04004A73 RID: 19059
			public Magazine magazine_0;

			// Token: 0x04004A74 RID: 19060
			public Magazines.Class2530 class2530_0;
		}

		// Token: 0x02000F13 RID: 3859
		[CompilerGenerated]
		internal sealed class Class2532
		{
			// Token: 0x06008905 RID: 35077 RVA: 0x0005247A File Offset: 0x0005067A
			public Class2532(Magazines.Class2532 class2532_0)
			{
				if (class2532_0 != null)
				{
					this.mount_0 = class2532_0.mount_0;
				}
			}

			// Token: 0x06008906 RID: 35078 RVA: 0x00052491 File Offset: 0x00050691
			internal void method_0()
			{
				this.magazines_0.method_8(this.mount_0.method_32());
			}

			// Token: 0x04004A75 RID: 19061
			public Mount mount_0;

			// Token: 0x04004A76 RID: 19062
			public Magazines magazines_0;
		}

		// Token: 0x02000F14 RID: 3860
		[CompilerGenerated]
		internal sealed class Class2533
		{
			// Token: 0x06008907 RID: 35079 RVA: 0x000524A9 File Offset: 0x000506A9
			public Class2533(Magazines.Class2533 class2533_0)
			{
				if (class2533_0 != null)
				{
					this.magazine_0 = class2533_0.magazine_0;
				}
			}

			// Token: 0x06008908 RID: 35080 RVA: 0x000524C0 File Offset: 0x000506C0
			internal void method_0()
			{
				this.magazines_0.method_8(this.magazine_0);
			}

			// Token: 0x04004A77 RID: 19063
			public Magazine magazine_0;

			// Token: 0x04004A78 RID: 19064
			public Magazines magazines_0;
		}

		// Token: 0x02000F15 RID: 3861
		[CompilerGenerated]
		internal sealed class Class2534
		{
			// Token: 0x06008909 RID: 35081 RVA: 0x000524D3 File Offset: 0x000506D3
			public Class2534(Magazines.Class2534 class2534_0)
			{
				if (class2534_0 != null)
				{
					this.list_0 = class2534_0.list_0;
					this.class48_0 = class2534_0.class48_0;
					this.list_1 = class2534_0.list_1;
				}
			}

			// Token: 0x0600890A RID: 35082 RVA: 0x004955B4 File Offset: 0x004937B4
			internal void method_0()
			{
				try
				{
					List<WeaponRec>.Enumerator enumerator = this.list_0.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Magazines.Class2535 @class = new Magazines.Class2535(@class);
						@class.class2534_0 = this;
						@class.weaponRec_0 = enumerator.Current;
						this.magazines_0.Invoke(new VB$AnonymousDelegate_0(@class.method_0));
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					List<WeaponRec>.Enumerator enumerator2 = this.list_1.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Magazines.Class2536 class2 = new Magazines.Class2536(class2);
						class2.class2534_0 = this;
						class2.weaponRec_0 = enumerator2.Current;
						this.magazines_0.Invoke(new VB$AnonymousDelegate_0(class2.method_0));
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}

			// Token: 0x04004A79 RID: 19065
			public List<WeaponRec> list_0;

			// Token: 0x04004A7A RID: 19066
			public Class48 class48_0;

			// Token: 0x04004A7B RID: 19067
			public List<WeaponRec> list_1;

			// Token: 0x04004A7C RID: 19068
			public Magazines magazines_0;
		}

		// Token: 0x02000F16 RID: 3862
		[CompilerGenerated]
		internal sealed class Class2535
		{
			// Token: 0x0600890B RID: 35083 RVA: 0x00052502 File Offset: 0x00050702
			public Class2535(Magazines.Class2535 class2535_0)
			{
				if (class2535_0 != null)
				{
					this.weaponRec_0 = class2535_0.weaponRec_0;
				}
			}

			// Token: 0x0600890C RID: 35084 RVA: 0x00052519 File Offset: 0x00050719
			internal void method_0()
			{
				this.class2534_0.magazines_0.method_20(this.class2534_0.class48_0, this.weaponRec_0);
			}

			// Token: 0x04004A7D RID: 19069
			public WeaponRec weaponRec_0;

			// Token: 0x04004A7E RID: 19070
			public Magazines.Class2534 class2534_0;
		}

		// Token: 0x02000F17 RID: 3863
		[CompilerGenerated]
		internal sealed class Class2536
		{
			// Token: 0x0600890D RID: 35085 RVA: 0x0005253C File Offset: 0x0005073C
			public Class2536(Magazines.Class2536 class2536_0)
			{
				if (class2536_0 != null)
				{
					this.weaponRec_0 = class2536_0.weaponRec_0;
				}
			}

			// Token: 0x0600890E RID: 35086 RVA: 0x00052553 File Offset: 0x00050753
			internal void method_0()
			{
				this.class2534_0.magazines_0.method_20(this.class2534_0.class48_0, this.weaponRec_0);
			}

			// Token: 0x04004A7F RID: 19071
			public WeaponRec weaponRec_0;

			// Token: 0x04004A80 RID: 19072
			public Magazines.Class2534 class2534_0;
		}
	}
}
