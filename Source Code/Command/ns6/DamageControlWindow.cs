using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns10;
using ns2;
using ns4;
using ns5;
using ns7;

namespace ns6
{
	// Token: 0x02000E89 RID: 3721
	[DesignerGenerated]
	internal sealed partial class DamageControlWindow : DarkSecondaryFormBase, Interface66
	{
		// Token: 0x060072D8 RID: 29400 RVA: 0x003D8F3C File Offset: 0x003D713C
		public DamageControlWindow()
		{
			base.Load += this.DamageControlWindow_Load;
			base.KeyDown += this.DamageControlWindow_KeyDown;
			base.FormClosing += this.DamageControlWindow_FormClosing;
			base.FormClosed += this.DamageControlWindow_FormClosed;
			this.InitializeComponent_1();
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x003D8FE0 File Offset: 0x003D71E0
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.vmethod_1(new Class50());
			this.vmethod_21(new Class44());
			this.vmethod_23(new Class44());
			this.vmethod_7(new Class44());
			this.vmethod_3(new Class125());
			this.vmethod_5(new ToolStripLabel());
			this.vmethod_9(new Class125());
			this.vmethod_11(new ToolStripLabel());
			this.vmethod_13(new ToolStripComboBox());
			this.vmethod_15(new ToolStripLabel());
			this.vmethod_17(new ToolStripTextBox());
			this.vmethod_19(new Timer(this.icontainer_1));
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_2().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToOrderColumns = true;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().BackgroundColor = Color.FromArgb(43, 43, 43);
			this.vmethod_0().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_0().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
			this.vmethod_0().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			this.vmethod_0().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_0().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font(Client.font_1.FontFamily, 8.25f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_20(),
				this.vmethod_22()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().method_9(null);
			this.vmethod_0().Location = new Point(2, 28);
			this.vmethod_0().Name = "TGV_Damage";
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().method_7(false);
			this.vmethod_0().Size = new Size(471, 233);
			this.vmethod_0().TabIndex = 5;
			this.vmethod_20().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_20().method_0(null);
			this.vmethod_20().HeaderText = "Name";
			this.vmethod_20().Name = "ComponentName";
			this.vmethod_20().ReadOnly = true;
			this.vmethod_20().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_20().Width = 39;
			this.vmethod_22().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_22().method_0(null);
			this.vmethod_22().HeaderText = "Status";
			this.vmethod_22().Name = "ComponentStatus";
			this.vmethod_22().ReadOnly = true;
			this.vmethod_22().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_6().method_0(null);
			this.vmethod_6().HeaderText = "Status";
			this.vmethod_6().Name = "Status";
			this.vmethod_6().ReadOnly = true;
			this.vmethod_6().Resizable = DataGridViewTriState.True;
			this.vmethod_6().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_2().AutoSize = false;
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_4()
			});
			this.vmethod_2().Location = new Point(0, 0);
			this.vmethod_2().Name = "ToolStrip1";
			this.vmethod_2().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_2().Size = new Size(475, 25);
			this.vmethod_2().TabIndex = 6;
			this.vmethod_2().Text = "ToolStrip1";
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Name = "ToolStripLabel1";
			this.vmethod_4().Size = new Size(54, 22);
			this.vmethod_4().Text = "Damage:";
			this.vmethod_8().AutoSize = false;
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().Dock = DockStyle.Bottom;
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_8().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_10(),
				this.vmethod_12(),
				this.vmethod_14(),
				this.vmethod_16()
			});
			this.vmethod_8().Location = new Point(0, 264);
			this.vmethod_8().Name = "TS_EditDamage";
			this.vmethod_8().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_8().Size = new Size(475, 25);
			this.vmethod_8().TabIndex = 7;
			this.vmethod_8().Text = "ToolStrip2";
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Name = "ToolStripLabel2";
			this.vmethod_10().Size = new Size(42, 22);
			this.vmethod_10().Text = "Status:";
			this.vmethod_12().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_12().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Items.AddRange(new object[]
			{
				"Operational",
				"Damaged (Light)",
				"Damaged (Medium)",
				"Damaged (Heavy)",
				"Destroyed"
			});
			this.vmethod_12().Name = "TSC_ComponentStatus";
			this.vmethod_12().Size = new Size(121, 25);
			this.vmethod_14().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Name = "ToolStripLabel3";
			this.vmethod_14().Size = new Size(94, 22);
			this.vmethod_14().Text = "Overall Damage:";
			this.vmethod_16().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Name = "TSTB_Damage";
			this.vmethod_16().Size = new Size(100, 25);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(475, 289);
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DamageControlWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Damage Control";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_8().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x060072DB RID: 29403 RVA: 0x00047DE9 File Offset: 0x00045FE9
		[CompilerGenerated]
		private Class50 vmethod_0()
		{
			return this.class50_0;
		}

		// Token: 0x060072DC RID: 29404 RVA: 0x003D98C0 File Offset: 0x003D7AC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_1(Class50 class50_1)
		{
			DataGridViewCellMouseEventHandler value = new DataGridViewCellMouseEventHandler(this.method_5);
			Class50 @class = this.class50_0;
			if (@class != null)
			{
				@class.CellMouseClick -= value;
			}
			this.class50_0 = class50_1;
			@class = this.class50_0;
			if (@class != null)
			{
				@class.CellMouseClick += value;
			}
		}

		// Token: 0x060072DD RID: 29405 RVA: 0x00047DF1 File Offset: 0x00045FF1
		[CompilerGenerated]
		internal Class125 vmethod_2()
		{
			return this.class125_0;
		}

		// Token: 0x060072DE RID: 29406 RVA: 0x00047DF9 File Offset: 0x00045FF9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class125 class125_2)
		{
			this.class125_0 = class125_2;
		}

		// Token: 0x060072DF RID: 29407 RVA: 0x00047E02 File Offset: 0x00046002
		[CompilerGenerated]
		internal ToolStripLabel vmethod_4()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x060072E0 RID: 29408 RVA: 0x00047E0A File Offset: 0x0004600A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripLabel toolStripLabel_3)
		{
			this.toolStripLabel_0 = toolStripLabel_3;
		}

		// Token: 0x060072E1 RID: 29409 RVA: 0x00047E13 File Offset: 0x00046013
		[CompilerGenerated]
		internal Class44 vmethod_6()
		{
			return this.class44_0;
		}

		// Token: 0x060072E2 RID: 29410 RVA: 0x00047E1B File Offset: 0x0004601B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class44 class44_3)
		{
			this.class44_0 = class44_3;
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x00047E24 File Offset: 0x00046024
		[CompilerGenerated]
		internal Class125 vmethod_8()
		{
			return this.class125_1;
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x00047E2C File Offset: 0x0004602C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class125 class125_2)
		{
			this.class125_1 = class125_2;
		}

		// Token: 0x060072E5 RID: 29413 RVA: 0x00047E35 File Offset: 0x00046035
		[CompilerGenerated]
		internal ToolStripLabel vmethod_10()
		{
			return this.toolStripLabel_1;
		}

		// Token: 0x060072E6 RID: 29414 RVA: 0x00047E3D File Offset: 0x0004603D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripLabel toolStripLabel_3)
		{
			this.toolStripLabel_1 = toolStripLabel_3;
		}

		// Token: 0x060072E7 RID: 29415 RVA: 0x00047E46 File Offset: 0x00046046
		[CompilerGenerated]
		internal ToolStripComboBox vmethod_12()
		{
			return this.toolStripComboBox_0;
		}

		// Token: 0x060072E8 RID: 29416 RVA: 0x00047E4E File Offset: 0x0004604E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ToolStripComboBox toolStripComboBox_1)
		{
			this.toolStripComboBox_0 = toolStripComboBox_1;
		}

		// Token: 0x060072E9 RID: 29417 RVA: 0x00047E57 File Offset: 0x00046057
		[CompilerGenerated]
		internal ToolStripLabel vmethod_14()
		{
			return this.toolStripLabel_2;
		}

		// Token: 0x060072EA RID: 29418 RVA: 0x00047E5F File Offset: 0x0004605F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripLabel toolStripLabel_3)
		{
			this.toolStripLabel_2 = toolStripLabel_3;
		}

		// Token: 0x060072EB RID: 29419 RVA: 0x00047E68 File Offset: 0x00046068
		[CompilerGenerated]
		internal ToolStripTextBox vmethod_16()
		{
			return this.toolStripTextBox_0;
		}

		// Token: 0x060072EC RID: 29420 RVA: 0x003D9904 File Offset: 0x003D7B04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(ToolStripTextBox toolStripTextBox_1)
		{
			EventHandler value = new EventHandler(this.method_8);
			EventHandler value2 = new EventHandler(this.method_10);
			EventHandler value3 = new EventHandler(this.method_11);
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

		// Token: 0x060072ED RID: 29421 RVA: 0x00047E70 File Offset: 0x00046070
		[CompilerGenerated]
		internal Timer vmethod_18()
		{
			return this.timer_0;
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x003D9980 File Offset: 0x003D7B80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_9);
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

		// Token: 0x060072EF RID: 29423 RVA: 0x00047E78 File Offset: 0x00046078
		[CompilerGenerated]
		internal Class44 vmethod_20()
		{
			return this.class44_1;
		}

		// Token: 0x060072F0 RID: 29424 RVA: 0x00047E80 File Offset: 0x00046080
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class44 class44_3)
		{
			this.class44_1 = class44_3;
		}

		// Token: 0x060072F1 RID: 29425 RVA: 0x00047E89 File Offset: 0x00046089
		[CompilerGenerated]
		internal Class44 vmethod_22()
		{
			return this.class44_2;
		}

		// Token: 0x060072F2 RID: 29426 RVA: 0x00047E91 File Offset: 0x00046091
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class44 class44_3)
		{
			this.class44_2 = class44_3;
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x00047E9A File Offset: 0x0004609A
		[CompilerGenerated]
		private ComboBox vmethod_24()
		{
			return this.comboBox_0;
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x003D99C4 File Offset: 0x003D7BC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_25(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x060072F5 RID: 29429 RVA: 0x003D9A08 File Offset: 0x003D7C08
		private void DamageControlWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (!Information.IsNothing(this.class279_0))
			{
				this.vmethod_8().Visible = (this.class279_0.method_1() == Class279.Enum67.const_2);
			}
			this.vmethod_25(this.vmethod_12().ComboBox);
			this.vmethod_18().Start();
			this.method_3();
			this.platformComponent_0 = (PlatformComponent)this.vmethod_0().method_5().Tag;
			PlatformComponent.smethod_0(new PlatformComponent.Delegate46(this.method_7));
		}

		// Token: 0x060072F6 RID: 29430 RVA: 0x003D9A9C File Offset: 0x003D7C9C
		private void DamageControlWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F10 && base.Visible)
			{
				base.Close();
				return;
			}
			if (this.bool_4 && (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (!this.bool_4)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060072F7 RID: 29431 RVA: 0x003D9B94 File Offset: 0x003D7D94
		private void method_3()
		{
			this.vmethod_0().method_0().Clear();
			this.vmethod_0().method_2().Clear();
			this.vmethod_4().Text = "Damage: " + string.Format("{0:0.0}", this.activeUnit_0.vmethod_91().method_0(), 1) + "%";
			this.Text = "Damage Status for " + Misc.smethod_9(this.activeUnit_0.Name);
			if (this.activeUnit_0.vmethod_51().Count > 0)
			{
				Class48 @class = new Class48();
				new Class48();
				@class = this.vmethod_0().method_2().method_0("Mounts");
				try
				{
					foreach (Mount mount in this.activeUnit_0.vmethod_51())
					{
						Class48 class2 = @class.method_7().method_1(new object[]
						{
							Misc.smethod_9(mount.Name),
							mount.vmethod_5().ToString()
						});
						class2.Tag = mount;
						class2.DefaultCellStyle.ForeColor = base.method_2(mount);
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				@class.vmethod_4();
			}
			if (Enumerable.Count<Magazine>(((Class350)this.activeUnit_0).magazine_0) > 0)
			{
				Class48 class3 = new Class48();
				new Class48();
				class3 = this.vmethod_0().method_2().method_0("Magazines");
				foreach (Magazine magazine in ((Class350)this.activeUnit_0).magazine_0)
				{
					Class48 class4 = class3.method_7().method_1(new object[]
					{
						Misc.smethod_9(magazine.Name),
						magazine.vmethod_5().ToString()
					});
					class4.Tag = magazine;
					class4.DefaultCellStyle.ForeColor = base.method_2(magazine);
				}
				class3.vmethod_4();
			}
			if (this.activeUnit_0.vmethod_96().Length > 0)
			{
				Class48 class5 = new Class48();
				new Class48();
				class5 = this.vmethod_0().method_2().method_0("Sensors");
				foreach (Sensor sensor in this.activeUnit_0.vmethod_96())
				{
					Class48 class6 = class5.method_7().method_1(new object[]
					{
						Misc.smethod_9(sensor.Name),
						sensor.vmethod_5().ToString()
					});
					class6.Tag = sensor;
					class6.DefaultCellStyle.ForeColor = base.method_2(sensor);
				}
				class5.vmethod_4();
			}
			if (Enumerable.Count<CommDevice>(this.activeUnit_0.vmethod_94()) > 0)
			{
				Class48 class7 = new Class48();
				Class48 class8 = new Class48();
				class7 = this.vmethod_0().method_2().method_0("Comms & Datalinks");
				foreach (CommDevice commDevice in this.activeUnit_0.vmethod_94())
				{
					string text = commDevice.vmethod_5().ToString();
					if (commDevice.vmethod_5() == PlatformComponent._ComponentStatus.Operational && commDevice.bool_14)
					{
						text += " - JAMMED";
					}
					class8 = class7.method_7().method_1(new object[]
					{
						Misc.smethod_9(commDevice.Name),
						text
					});
					class8.Tag = commDevice;
					class8.DefaultCellStyle.ForeColor = base.method_2(commDevice);
					if (commDevice.vmethod_5() == PlatformComponent._ComponentStatus.Operational && commDevice.bool_14)
					{
						class8.DefaultCellStyle.ForeColor = Color.Blue;
					}
				}
				class7.vmethod_4();
			}
			if (this.activeUnit_0.vmethod_100().Length > 0)
			{
				Class48 class9 = new Class48();
				new Class48();
				class9 = this.vmethod_0().method_2().method_0("Docking Facilities");
				foreach (DockFacility dockFacility in this.activeUnit_0.vmethod_100())
				{
					Class48 class10 = class9.method_7().method_1(new object[]
					{
						Misc.smethod_9(dockFacility.Name),
						dockFacility.vmethod_5().ToString()
					});
					class10.Tag = dockFacility;
					class10.DefaultCellStyle.ForeColor = base.method_2(dockFacility);
				}
				class9.vmethod_4();
			}
			if (this.activeUnit_0.vmethod_99().Length > 0)
			{
				Class48 class11 = new Class48();
				new Class48();
				class11 = this.vmethod_0().method_2().method_0("Air Facilities");
				for (int m = this.activeUnit_0.vmethod_99().Length - 1; m >= 0; m += -1)
				{
					AirFacility airFacility = this.activeUnit_0.vmethod_99()[m];
					string text2;
					if (airFacility.method_29() > airFacility.method_27())
					{
						text2 = "Operational, Reduced Capacity";
					}
					else
					{
						text2 = airFacility.vmethod_5().ToString();
					}
					Class48 class12 = class11.method_7().method_1(new object[]
					{
						Misc.smethod_9(airFacility.Name),
						text2
					});
					class12.Tag = airFacility;
					class12.DefaultCellStyle.ForeColor = base.method_2(airFacility);
				}
				class11.vmethod_4();
			}
			if (((Class350)this.activeUnit_0).vmethod_49().Count > 0)
			{
				Class48 class13 = new Class48();
				new Class48();
				class13 = this.vmethod_0().method_2().method_0("Engineering / Propulsion");
				try
				{
					foreach (Engine engine in this.activeUnit_0.vmethod_49())
					{
						Class48 class14 = class13.method_7().method_1(new object[]
						{
							Misc.smethod_9(engine.Name),
							engine.vmethod_5().ToString()
						});
						class14.Tag = engine;
						class14.DefaultCellStyle.ForeColor = base.method_2(engine);
					}
				}
				finally
				{
					List<Engine>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				class13.vmethod_4();
			}
			switch (this.activeUnit_0.vmethod_56())
			{
			case GlobalVariables.ActiveUnitType.Ship:
			{
				Class48 class15 = this.vmethod_0().method_2().method_1(new object[]
				{
					((Ship)this.activeUnit_0).class345_0.Name,
					((Ship)this.activeUnit_0).class345_0.vmethod_5().ToString()
				});
				class15.Tag = ((Ship)this.activeUnit_0).class345_0;
				class15.DefaultCellStyle.ForeColor = base.method_2(((Ship)this.activeUnit_0).class345_0);
				Class48 class16 = this.vmethod_0().method_2().method_1(new object[]
				{
					((Ship)this.activeUnit_0).class347_0.Name,
					((Ship)this.activeUnit_0).class347_0.vmethod_5().ToString()
				});
				class16.Tag = ((Ship)this.activeUnit_0).class347_0;
				class16.DefaultCellStyle.ForeColor = base.method_2(((Ship)this.activeUnit_0).class347_0);
				return;
			}
			case GlobalVariables.ActiveUnitType.Submarine:
			{
				Class48 class17 = this.vmethod_0().method_2().method_1(new object[]
				{
					((Submarine)this.activeUnit_0).class345_0.Name,
					((Submarine)this.activeUnit_0).class345_0.vmethod_5().ToString()
				});
				class17.Tag = ((Submarine)this.activeUnit_0).class345_0;
				class17.DefaultCellStyle.ForeColor = base.method_2(((Submarine)this.activeUnit_0).class345_0);
				Class48 class18 = this.vmethod_0().method_2().method_1(new object[]
				{
					((Submarine)this.activeUnit_0).class347_0.Name,
					((Submarine)this.activeUnit_0).class347_0.vmethod_5().ToString()
				});
				class18.Tag = ((Submarine)this.activeUnit_0).class347_0;
				class18.DefaultCellStyle.ForeColor = base.method_2(((Submarine)this.activeUnit_0).class347_0);
				return;
			}
			case GlobalVariables.ActiveUnitType.Facility:
			{
				Class48 class19 = this.vmethod_0().method_2().method_1(new object[]
				{
					((Facility)this.activeUnit_0).class345_0.Name,
					((Facility)this.activeUnit_0).class345_0.vmethod_5().ToString()
				});
				class19.Tag = ((Facility)this.activeUnit_0).class345_0;
				class19.DefaultCellStyle.ForeColor = base.method_2(((Facility)this.activeUnit_0).class345_0);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x003DA4D8 File Offset: 0x003D86D8
		public void imethod_0()
		{
			try
			{
				foreach (Class48 class48_ in this.vmethod_0().method_2())
				{
					this.method_4(class48_);
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

		// Token: 0x060072F9 RID: 29433 RVA: 0x003DA52C File Offset: 0x003D872C
		private void method_4(Class48 class48_0)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(class48_0.Tag)))
			{
				PlatformComponent platformComponent = (PlatformComponent)class48_0.Tag;
				string text = platformComponent.vmethod_5().ToString();
				if (platformComponent.GetType() == typeof(CommDevice) && platformComponent.vmethod_5() == PlatformComponent._ComponentStatus.Operational && ((CommDevice)platformComponent).bool_14)
				{
					text += " - JAMMED";
					class48_0.DefaultCellStyle.ForeColor = Color.Blue;
				}
				class48_0.SetValues(new object[]
				{
					platformComponent.Name,
					text
				});
				class48_0.DefaultCellStyle.ForeColor = base.method_2(platformComponent);
			}
			try
			{
				foreach (Class48 class48_ in class48_0.method_7())
				{
					this.method_4(class48_);
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

		// Token: 0x060072FA RID: 29434 RVA: 0x003DA624 File Offset: 0x003D8824
		private void method_5(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_0().method_5().Tag)))
			{
				this.platformComponent_0 = (PlatformComponent)this.vmethod_0().method_5().Tag;
				switch (this.platformComponent_0.vmethod_5())
				{
				case PlatformComponent._ComponentStatus.Operational:
					this.vmethod_12().SelectedIndex = 0;
					return;
				case PlatformComponent._ComponentStatus.Damaged:
					switch (this.platformComponent_0.method_16())
					{
					case PlatformComponent._DamageSeverityFactor.Light:
						this.vmethod_12().SelectedIndex = 1;
						return;
					case PlatformComponent._DamageSeverityFactor.Medium:
						this.vmethod_12().SelectedIndex = 2;
						return;
					case PlatformComponent._DamageSeverityFactor.Heavy:
						this.vmethod_12().SelectedIndex = 3;
						return;
					default:
						return;
					}
					break;
				case PlatformComponent._ComponentStatus.Destroyed:
					this.vmethod_12().SelectedIndex = 4;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060072FB RID: 29435 RVA: 0x003DA6EC File Offset: 0x003D88EC
		private void method_6(object sender, EventArgs e)
		{
			try
			{
				foreach (Class48 @class in Class2558.smethod_15(this.vmethod_0()))
				{
					if (@class.Selected && !Information.IsNothing(RuntimeHelpers.GetObjectValue(@class.Tag)))
					{
						this.platformComponent_0 = (PlatformComponent)@class.Tag;
						if (!Information.IsNothing(this.platformComponent_0))
						{
							switch (this.vmethod_24().SelectedIndex)
							{
							case 0:
								this.platformComponent_0.method_22(true);
								break;
							case 1:
								this.platformComponent_0.vmethod_8(PlatformComponent._DamageSeverityFactor.Light);
								break;
							case 2:
								this.platformComponent_0.vmethod_8(PlatformComponent._DamageSeverityFactor.Medium);
								break;
							case 3:
								this.platformComponent_0.vmethod_8(PlatformComponent._DamageSeverityFactor.Heavy);
								break;
							case 4:
								this.platformComponent_0.vmethod_6(this.activeUnit_0.vmethod_7(false), true, false);
								break;
							}
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

		// Token: 0x060072FC RID: 29436 RVA: 0x00047EA2 File Offset: 0x000460A2
		private void method_7(PlatformComponent platformComponent_1)
		{
			if (platformComponent_1.method_18() == this.activeUnit_0)
			{
				this.bool_3 = true;
			}
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x003DA7F4 File Offset: 0x003D89F4
		private void method_8(object sender, EventArgs e)
		{
			if (!(Operators.CompareString(this.vmethod_16().Text, "", false) == 0 | !Versioned.IsNumeric(this.vmethod_16().Text)))
			{
				if (Conversions.ToDouble(this.vmethod_16().Text) < 0.0)
				{
					this.vmethod_16().Text = 0.ToString();
				}
				if (Conversions.ToDouble(this.vmethod_16().Text) > 100.0)
				{
					this.vmethod_16().Text = 100.ToString();
				}
				this.activeUnit_0.vmethod_64(false, null, (float)((double)this.activeUnit_0.method_60() * ((100.0 - Conversions.ToDouble(this.vmethod_16().Text)) / 100.0)));
				this.vmethod_4().Text = "Damage: " + string.Format("{0:0.0}", this.activeUnit_0.vmethod_91().method_0(), 2) + "%";
			}
		}

		// Token: 0x060072FE RID: 29438 RVA: 0x00047EB9 File Offset: 0x000460B9
		private void method_9(object sender, EventArgs e)
		{
			if (this.bool_3)
			{
				this.imethod_0();
				this.bool_3 = false;
			}
		}

		// Token: 0x060072FF RID: 29439 RVA: 0x00047ED0 File Offset: 0x000460D0
		private void DamageControlWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
			Client.bool_1 = true;
			Client.bool_1 = true;
		}

		// Token: 0x06007300 RID: 29440 RVA: 0x00047EED File Offset: 0x000460ED
		private void DamageControlWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			PlatformComponent.smethod_1(new PlatformComponent.Delegate46(this.method_7));
		}

		// Token: 0x06007301 RID: 29441 RVA: 0x00047F00 File Offset: 0x00046100
		private void method_10(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x06007302 RID: 29442 RVA: 0x00047F09 File Offset: 0x00046109
		private void method_11(object sender, EventArgs e)
		{
			this.bool_4 = false;
			this.vmethod_10().Select();
		}

		// Token: 0x040040BF RID: 16575
		[CompilerGenerated]
		[AccessedThroughProperty("TGV_Damage")]
		private Class50 class50_0;

		// Token: 0x040040C0 RID: 16576
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStrip1")]
		private Class125 class125_0;

		// Token: 0x040040C1 RID: 16577
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x040040C2 RID: 16578
		[CompilerGenerated]
		[AccessedThroughProperty("Status")]
		private Class44 class44_0;

		// Token: 0x040040C3 RID: 16579
		[CompilerGenerated]
		[AccessedThroughProperty("TS_EditDamage")]
		private Class125 class125_1;

		// Token: 0x040040C4 RID: 16580
		[AccessedThroughProperty("ToolStripLabel2")]
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_1;

		// Token: 0x040040C5 RID: 16581
		[CompilerGenerated]
		[AccessedThroughProperty("TSC_ComponentStatus")]
		private ToolStripComboBox toolStripComboBox_0;

		// Token: 0x040040C6 RID: 16582
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripLabel3")]
		private ToolStripLabel toolStripLabel_2;

		// Token: 0x040040C7 RID: 16583
		[CompilerGenerated]
		[AccessedThroughProperty("TSTB_Damage")]
		private ToolStripTextBox toolStripTextBox_0;

		// Token: 0x040040C8 RID: 16584
		[CompilerGenerated]
		[AccessedThroughProperty("Timer2")]
		private Timer timer_0;

		// Token: 0x040040C9 RID: 16585
		[CompilerGenerated]
		[AccessedThroughProperty("ComponentName")]
		private Class44 class44_1;

		// Token: 0x040040CA RID: 16586
		[CompilerGenerated]
		[AccessedThroughProperty("ComponentStatus")]
		private Class44 class44_2;

		// Token: 0x040040CB RID: 16587
		public ActiveUnit activeUnit_0;

		// Token: 0x040040CC RID: 16588
		public Class279 class279_0;

		// Token: 0x040040CD RID: 16589
		private PlatformComponent platformComponent_0;

		// Token: 0x040040CE RID: 16590
		[AccessedThroughProperty("CB1")]
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x040040CF RID: 16591
		private bool bool_3;

		// Token: 0x040040D0 RID: 16592
		private bool bool_4;
	}
}
