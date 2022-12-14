using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;

namespace Command
{
	// Token: 0x02000EFA RID: 3834
	[DesignerGenerated]
	public sealed partial class Sides : DarkSecondaryFormBase, Interface66
	{
		// Token: 0x06008724 RID: 34596 RVA: 0x004882B8 File Offset: 0x004864B8
		public Sides()
		{
			base.FormClosing += this.Sides_FormClosing;
			base.Load += this.Sides_Load;
			base.KeyDown += this.Sides_KeyDown;
			this.InitializeComponent_1();
		}

		// Token: 0x06008726 RID: 34598 RVA: 0x00488308 File Offset: 0x00486508
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control4());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Control9());
			this.vmethod_9(new Class112());
			this.vmethod_11(new Control9());
			this.vmethod_13(new Control9());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Class2451());
			this.vmethod_19(new Class112());
			this.vmethod_21(new Class116());
			this.vmethod_23(new TrackBar());
			this.vmethod_25(new Class112());
			this.vmethod_27(new Class125());
			this.vmethod_29(new ToolStripLabel());
			this.vmethod_31(new Control9());
			((ISupportInitialize)this.vmethod_22()).BeginInit();
			this.vmethod_26().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_0().Location = new Point(1, 9);
			this.vmethod_0().Name = "LB_Sides";
			this.vmethod_0().Size = new Size(213, 390);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DialogResult = DialogResult.None;
			this.vmethod_2().Font = new Font("Segoe UI", 10f);
			this.vmethod_2().ForeColor = SystemColors.Control;
			this.vmethod_2().Location = new Point(220, 9);
			this.vmethod_2().Name = "Button1";
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(134, 23);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Add";
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().Font = new Font("Segoe UI", 10f);
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(220, 38);
			this.vmethod_4().Name = "Button2";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(133, 23);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Remove";
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font("Segoe UI", 10f);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(221, 141);
			this.vmethod_6().Name = "Button3";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(133, 23);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "Postures";
			this.vmethod_8().AutoSize = true;
			this.vmethod_8().Enabled = false;
			this.vmethod_8().Location = new Point(221, 199);
			this.vmethod_8().Name = "CB_AIOnly";
			this.vmethod_8().Size = new Size(142, 19);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "Side is computer-only";
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DialogResult = DialogResult.None;
			this.vmethod_10().Font = new Font("Segoe UI", 10f);
			this.vmethod_10().ForeColor = SystemColors.Control;
			this.vmethod_10().Location = new Point(221, 83);
			this.vmethod_10().Name = "Button4";
			this.vmethod_10().method_1(0);
			this.vmethod_10().Size = new Size(132, 23);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_10().Text = "Rename";
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font("Segoe UI", 10f);
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(221, 170);
			this.vmethod_12().Name = "Button5";
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(133, 23);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_12().Text = "Doctrine - ROE";
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(217, 262);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Size = new Size(91, 13);
			this.vmethod_14().TabIndex = 8;
			this.vmethod_14().Text = "Awareness Level:";
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_16().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_16().Font = new Font("Segoe UI", 7f);
			this.vmethod_16().FormattingEnabled = true;
			this.vmethod_16().Items.AddRange(new object[]
			{
				"Blind",
				"Normal",
				"AutoSideID",
				"AutoSideAndUnitID",
				"Omniscient"
			});
			this.vmethod_16().Location = new Point(220, 278);
			this.vmethod_16().Name = "CB_Awareness";
			this.vmethod_16().Size = new Size(133, 21);
			this.vmethod_16().TabIndex = 9;
			this.vmethod_18().Location = new Point(221, 219);
			this.vmethod_18().Name = "CB_CollRespons";
			this.vmethod_18().Size = new Size(140, 17);
			this.vmethod_18().TabIndex = 10;
			this.vmethod_18().Text = "Collective responsibility";
			this.vmethod_20().method_2(true);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Location = new Point(219, 309);
			this.vmethod_20().Name = "Label_Proficiency";
			this.vmethod_20().Size = new Size(69, 15);
			this.vmethod_20().TabIndex = 11;
			this.vmethod_20().Text = "Proficiency:";
			this.vmethod_22().Location = new Point(220, 325);
			this.vmethod_22().Maximum = 4;
			this.vmethod_22().Name = "TrackBar_Proficiency";
			this.vmethod_22().Size = new Size(133, 45);
			this.vmethod_22().TabIndex = 12;
			this.vmethod_24().Location = new Point(221, 238);
			this.vmethod_24().Name = "CB_AutoTrackCivs";
			this.vmethod_24().Size = new Size(136, 17);
			this.vmethod_24().TabIndex = 13;
			this.vmethod_24().Text = "Can auto-track civilians";
			this.vmethod_26().AutoSize = false;
			this.vmethod_26().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_26().Dock = DockStyle.Bottom;
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_26().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_28()
			});
			this.vmethod_26().Location = new Point(0, 393);
			this.vmethod_26().Name = "DarkToolStrip1";
			this.vmethod_26().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_26().Size = new Size(366, 28);
			this.vmethod_26().TabIndex = 14;
			this.vmethod_26().Text = "DarkToolStrip1";
			this.vmethod_28().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_28().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_28().Name = "ToolStripLabel1";
			this.vmethod_28().Size = new Size(314, 25);
			this.vmethod_28().Text = "Double-clicking on a side selects it and closes this window";
			this.vmethod_30().BackColor = Color.Transparent;
			this.vmethod_30().DialogResult = DialogResult.None;
			this.vmethod_30().Font = new Font("Segoe UI", 10f);
			this.vmethod_30().ForeColor = SystemColors.Control;
			this.vmethod_30().Location = new Point(220, 112);
			this.vmethod_30().Name = "Button_SideBriefing";
			this.vmethod_30().method_1(0);
			this.vmethod_30().Size = new Size(132, 23);
			this.vmethod_30().TabIndex = 15;
			this.vmethod_30().Text = "Briefing";
			base.AutoScaleMode = AutoScaleMode.None;
			this.AutoSize = true;
			base.ClientSize = new Size(366, 421);
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_26());
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Sides";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Edit Sides";
			((ISupportInitialize)this.vmethod_22()).EndInit();
			this.vmethod_26().ResumeLayout(false);
			this.vmethod_26().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008727 RID: 34599 RVA: 0x000515B4 File Offset: 0x0004F7B4
		[CompilerGenerated]
		internal Control4 vmethod_0()
		{
			return this.control4_0;
		}

		// Token: 0x06008728 RID: 34600 RVA: 0x00488E94 File Offset: 0x00487094
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control4 control4_1)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_4);
			EventHandler eventHandler_ = new EventHandler(this.method_5);
			Control4 control = this.control4_0;
			if (control != null)
			{
				control.MouseDoubleClick -= value;
				control.method_17(eventHandler_);
			}
			this.control4_0 = control4_1;
			control = this.control4_0;
			if (control != null)
			{
				control.MouseDoubleClick += value;
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06008729 RID: 34601 RVA: 0x000515BC File Offset: 0x0004F7BC
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x0600872A RID: 34602 RVA: 0x00488EF4 File Offset: 0x004870F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_6)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_6;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600872B RID: 34603 RVA: 0x000515C4 File Offset: 0x0004F7C4
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_1;
		}

		// Token: 0x0600872C RID: 34604 RVA: 0x00488F38 File Offset: 0x00487138
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_6)
		{
			EventHandler value = new EventHandler(this.method_6);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_6;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600872D RID: 34605 RVA: 0x000515CC File Offset: 0x0004F7CC
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_2;
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x00488F7C File Offset: 0x0048717C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_6)
		{
			EventHandler value = new EventHandler(this.method_7);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_6;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x000515D4 File Offset: 0x0004F7D4
		[CompilerGenerated]
		internal Class112 vmethod_8()
		{
			return this.class112_0;
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x00488FC0 File Offset: 0x004871C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class112 class112_3)
		{
			EventHandler value = new EventHandler(this.method_8);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_0 = class112_3;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06008731 RID: 34609 RVA: 0x000515DC File Offset: 0x0004F7DC
		[CompilerGenerated]
		internal Control9 vmethod_10()
		{
			return this.control9_3;
		}

		// Token: 0x06008732 RID: 34610 RVA: 0x00489004 File Offset: 0x00487204
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control9 control9_6)
		{
			EventHandler value = new EventHandler(this.method_9);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_6;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008733 RID: 34611 RVA: 0x000515E4 File Offset: 0x0004F7E4
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_4;
		}

		// Token: 0x06008734 RID: 34612 RVA: 0x00489048 File Offset: 0x00487248
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_6)
		{
			EventHandler value = new EventHandler(this.method_10);
			Control9 control = this.control9_4;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_4 = control9_6;
			control = this.control9_4;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008735 RID: 34613 RVA: 0x000515EC File Offset: 0x0004F7EC
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_0;
		}

		// Token: 0x06008736 RID: 34614 RVA: 0x000515F4 File Offset: 0x0004F7F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_2)
		{
			this.class116_0 = class116_2;
		}

		// Token: 0x06008737 RID: 34615 RVA: 0x000515FD File Offset: 0x0004F7FD
		[CompilerGenerated]
		internal Class2451 vmethod_16()
		{
			return this.class2451_0;
		}

		// Token: 0x06008738 RID: 34616 RVA: 0x0048908C File Offset: 0x0048728C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_11);
			EventHandler value2 = new EventHandler(this.method_14);
			EventHandler value3 = new EventHandler(this.method_15);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
				@class.Enter -= value2;
				@class.Leave -= value3;
			}
			this.class2451_0 = class2451_1;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
				@class.Enter += value2;
				@class.Leave += value3;
			}
		}

		// Token: 0x06008739 RID: 34617 RVA: 0x00051605 File Offset: 0x0004F805
		[CompilerGenerated]
		internal Class112 vmethod_18()
		{
			return this.class112_1;
		}

		// Token: 0x0600873A RID: 34618 RVA: 0x00489108 File Offset: 0x00487308
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class112 class112_3)
		{
			EventHandler value = new EventHandler(this.method_12);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_1 = class112_3;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x0600873B RID: 34619 RVA: 0x0005160D File Offset: 0x0004F80D
		[CompilerGenerated]
		internal Class116 vmethod_20()
		{
			return this.class116_1;
		}

		// Token: 0x0600873C RID: 34620 RVA: 0x00051615 File Offset: 0x0004F815
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class116 class116_2)
		{
			this.class116_1 = class116_2;
		}

		// Token: 0x0600873D RID: 34621 RVA: 0x0005161E File Offset: 0x0004F81E
		[CompilerGenerated]
		internal TrackBar vmethod_22()
		{
			return this.trackBar_0;
		}

		// Token: 0x0600873E RID: 34622 RVA: 0x0048914C File Offset: 0x0048734C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(TrackBar trackBar_1)
		{
			EventHandler value = new EventHandler(this.method_13);
			TrackBar trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_0 = trackBar_1;
			trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x0600873F RID: 34623 RVA: 0x00051626 File Offset: 0x0004F826
		[CompilerGenerated]
		internal Class112 vmethod_24()
		{
			return this.class112_2;
		}

		// Token: 0x06008740 RID: 34624 RVA: 0x00489190 File Offset: 0x00487390
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class112 class112_3)
		{
			EventHandler value = new EventHandler(this.method_16);
			Class112 @class = this.class112_2;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_2 = class112_3;
			@class = this.class112_2;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06008741 RID: 34625 RVA: 0x0005162E File Offset: 0x0004F82E
		[CompilerGenerated]
		internal Class125 vmethod_26()
		{
			return this.class125_0;
		}

		// Token: 0x06008742 RID: 34626 RVA: 0x00051636 File Offset: 0x0004F836
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x06008743 RID: 34627 RVA: 0x0005163F File Offset: 0x0004F83F
		[CompilerGenerated]
		internal ToolStripLabel vmethod_28()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x06008744 RID: 34628 RVA: 0x00051647 File Offset: 0x0004F847
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(ToolStripLabel toolStripLabel_1)
		{
			this.toolStripLabel_0 = toolStripLabel_1;
		}

		// Token: 0x06008745 RID: 34629 RVA: 0x00051650 File Offset: 0x0004F850
		[CompilerGenerated]
		internal Control9 vmethod_30()
		{
			return this.control9_5;
		}

		// Token: 0x06008746 RID: 34630 RVA: 0x004891D4 File Offset: 0x004873D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Control9 control9_6)
		{
			EventHandler value = new EventHandler(this.method_17);
			Control9 control = this.control9_5;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_5 = control9_6;
			control = this.control9_5;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008747 RID: 34631 RVA: 0x00051658 File Offset: 0x0004F858
		private void Sides_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Class2413.smethod_2().method_5().Visible)
			{
				Class2413.smethod_2().method_41().Enabled = true;
			}
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06008748 RID: 34632 RVA: 0x0005168A File Offset: 0x0004F88A
		private void Sides_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.imethod_0();
		}

		// Token: 0x06008749 RID: 34633 RVA: 0x000516A5 File Offset: 0x0004F8A5
		private void method_3(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_4().Show();
		}

		// Token: 0x0600874A RID: 34634 RVA: 0x00489218 File Offset: 0x00487418
		public void imethod_0()
		{
			this.vmethod_0().method_18().Clear();
			try
			{
				foreach (Side side in Enumerable.OrderBy<Side, string>(Client.smethod_46().method_44(), (Sides._Closure$__.$I73-0 == null) ? (Sides._Closure$__.$I73-0 = new Func<Side, string>(Sides._Closure$__.$I.method_0)) : Sides._Closure$__.$I73-0))
				{
					this.vmethod_0().method_18().Add(new Class117(side.method_51()));
				}
			}
			finally
			{
				IEnumerator<Side> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.vmethod_4().Enabled = (this.vmethod_0().method_18().Count > 0 & this.vmethod_0().method_20().Count > 0);
			this.vmethod_6().Enabled = (this.vmethod_0().method_18().Count > 0 & this.vmethod_0().method_20().Count > 0);
			this.vmethod_20().Visible = (this.vmethod_0().method_18().Count > 0 & this.vmethod_0().method_20().Count > 0);
			this.vmethod_22().Visible = (this.vmethod_0().method_18().Count > 0 & this.vmethod_0().method_20().Count > 0);
			if (Class2413.smethod_2().method_5().Visible)
			{
				Class2413.smethod_2().method_5().method_7();
			}
		}

		// Token: 0x0600874B RID: 34635 RVA: 0x004893A0 File Offset: 0x004875A0
		private void method_4(object sender, MouseEventArgs e)
		{
			if (this.vmethod_0().method_20().Count != 0)
			{
				foreach (Side side in Client.smethod_46().method_44())
				{
					if (Operators.CompareString(side.method_51(), this.vmethod_0().method_21()[0].method_2(), false) == 0)
					{
						Client.smethod_51(side);
						IL_5B:
						base.Close();
						return;
					}
				}
				goto IL_5B;
			}
		}

		// Token: 0x0600874C RID: 34636 RVA: 0x00489410 File Offset: 0x00487610
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().method_20().Count != 0)
			{
				foreach (Side side in Client.smethod_46().method_44())
				{
					if (Operators.CompareString(side.method_51(), this.vmethod_0().method_21()[0].method_2(), false) == 0)
					{
						this.side_0 = side;
						IL_5F:
						this.vmethod_4().Enabled = (this.vmethod_0().method_18().Count > 0);
						this.vmethod_6().Enabled = (this.vmethod_0().method_18().Count > 0);
						this.vmethod_8().Enabled = (this.vmethod_0().method_18().Count > 0);
						this.vmethod_18().Enabled = (this.vmethod_0().method_18().Count > 0);
						this.vmethod_8().Checked = this.side_0.method_53();
						this.vmethod_18().Checked = this.side_0.bool_13;
						this.vmethod_24().Checked = this.side_0.bool_14;
						switch (this.side_0.method_28())
						{
						case Side.AwarenessLevel_Enum.Blind:
							this.vmethod_16().SelectedIndex = 0;
							break;
						case Side.AwarenessLevel_Enum.Normal:
							this.vmethod_16().SelectedIndex = 1;
							break;
						case Side.AwarenessLevel_Enum.AutoSideID:
							this.vmethod_16().SelectedIndex = 2;
							break;
						case Side.AwarenessLevel_Enum.AutoSideAndUnitID:
							this.vmethod_16().SelectedIndex = 3;
							break;
						case Side.AwarenessLevel_Enum.Omniscient:
							this.vmethod_16().SelectedIndex = 4;
							break;
						}
						this.vmethod_20().Visible = true;
						this.vmethod_22().Visible = true;
						this.vmethod_20().Text = "Proficiency: " + Misc.smethod_20(this.side_0.method_24());
						this.vmethod_22().Value = (int)this.side_0.method_24();
						return;
					}
				}
				goto IL_5F;
			}
		}

		// Token: 0x0600874D RID: 34637 RVA: 0x004895F8 File Offset: 0x004877F8
		private void method_6(object sender, EventArgs e)
		{
			if (DarkMessageBox.smethod_1("Are you sure? All units, missions and any other object of that side will be deleted!", "Remove Side: " + this.side_0.method_51(), Enum11.const_2) == DialogResult.OK)
			{
				Collection<ActiveUnit> collection = new Collection<ActiveUnit>();
				foreach (ActiveUnit item in this.side_0.activeUnit_0)
				{
					collection.Add(item);
				}
				try
				{
					foreach (ActiveUnit activeUnit in collection)
					{
						Client.smethod_46().method_66(activeUnit.string_0, true);
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
				Client.smethod_46().method_70(this.side_0);
				Client.bool_1 = true;
				this.imethod_0();
			}
		}

		// Token: 0x0600874E RID: 34638 RVA: 0x000516B6 File Offset: 0x0004F8B6
		private void method_7(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_49().side_0 = this.side_0;
			Class2413.smethod_2().method_49().Show();
		}

		// Token: 0x0600874F RID: 34639 RVA: 0x000516DC File Offset: 0x0004F8DC
		private void method_8(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				this.side_0.method_54(this.vmethod_8().Checked);
			}
		}

		// Token: 0x06008750 RID: 34640 RVA: 0x00051701 File Offset: 0x0004F901
		private void method_9(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				new RenameSide
				{
					side_0 = this.side_0
				}.Show();
			}
		}

		// Token: 0x06008751 RID: 34641 RVA: 0x00051726 File Offset: 0x0004F926
		private void method_10(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				new DoctrineForm
				{
					class310_0 = this.side_0
				}.Show();
			}
		}

		// Token: 0x06008752 RID: 34642 RVA: 0x004896C0 File Offset: 0x004878C0
		private void method_11(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				switch (this.vmethod_16().SelectedIndex)
				{
				case 0:
					this.side_0.method_29(Side.AwarenessLevel_Enum.Blind);
					return;
				case 1:
					this.side_0.method_29(Side.AwarenessLevel_Enum.Normal);
					return;
				case 2:
					this.side_0.method_29(Side.AwarenessLevel_Enum.AutoSideID);
					return;
				case 3:
					this.side_0.method_29(Side.AwarenessLevel_Enum.AutoSideAndUnitID);
					return;
				case 4:
					this.side_0.method_29(Side.AwarenessLevel_Enum.Omniscient);
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06008753 RID: 34643 RVA: 0x0005174B File Offset: 0x0004F94B
		private void method_12(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				this.side_0.bool_13 = this.vmethod_18().Checked;
			}
		}

		// Token: 0x06008754 RID: 34644 RVA: 0x00489744 File Offset: 0x00487944
		private void method_13(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				this.side_0.method_25((GlobalVariables.ProficiencyLevel)this.vmethod_22().Value);
				this.vmethod_20().Text = "Proficiency: " + Misc.smethod_20(this.side_0.method_24());
			}
		}

		// Token: 0x06008755 RID: 34645 RVA: 0x0048979C File Offset: 0x0048799C
		private void Sides_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (this.bool_3)
			{
				if (e.KeyValue == 13 && base.Visible)
				{
					this.vmethod_18().Select();
					return;
				}
				if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
				{
					Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
			if (!this.bool_3 && (e.KeyValue != 32 || !base.Visible))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06008756 RID: 34646 RVA: 0x00051770 File Offset: 0x0004F970
		private void method_14(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x06008757 RID: 34647 RVA: 0x00051779 File Offset: 0x0004F979
		private void method_15(object sender, EventArgs e)
		{
			this.bool_3 = false;
			this.vmethod_18().Select();
		}

		// Token: 0x06008758 RID: 34648 RVA: 0x0005178D File Offset: 0x0004F98D
		private void method_16(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				this.side_0.bool_14 = this.vmethod_24().Checked;
			}
		}

		// Token: 0x06008759 RID: 34649 RVA: 0x004898AC File Offset: 0x00487AAC
		private void method_17(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.side_0))
			{
				DarkMessageBox.smethod_2("You must have a side selected before you can edit its briefing", "No side selected!", Enum11.const_0);
				return;
			}
			try
			{
				Class2413.smethod_2().method_21().side_0 = this.side_0;
				Class2413.smethod_2().method_21().Show();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200202", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x040049A4 RID: 18852
		[AccessedThroughProperty("LB_Sides")]
		[CompilerGenerated]
		private Control4 control4_0;

		// Token: 0x040049A5 RID: 18853
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x040049A6 RID: 18854
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x040049A7 RID: 18855
		[CompilerGenerated]
		[AccessedThroughProperty("Button3")]
		private Control9 control9_2;

		// Token: 0x040049A8 RID: 18856
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AIOnly")]
		private Class112 class112_0;

		// Token: 0x040049A9 RID: 18857
		[CompilerGenerated]
		[AccessedThroughProperty("Button4")]
		private Control9 control9_3;

		// Token: 0x040049AA RID: 18858
		[AccessedThroughProperty("Button5")]
		[CompilerGenerated]
		private Control9 control9_4;

		// Token: 0x040049AB RID: 18859
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x040049AC RID: 18860
		[AccessedThroughProperty("CB_Awareness")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x040049AD RID: 18861
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CollRespons")]
		private Class112 class112_1;

		// Token: 0x040049AE RID: 18862
		[AccessedThroughProperty("Label_Proficiency")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x040049AF RID: 18863
		[AccessedThroughProperty("TrackBar_Proficiency")]
		[CompilerGenerated]
		private TrackBar trackBar_0;

		// Token: 0x040049B0 RID: 18864
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AutoTrackCivs")]
		private Class112 class112_2;

		// Token: 0x040049B1 RID: 18865
		[CompilerGenerated]
		[AccessedThroughProperty("DarkToolStrip1")]
		private Class125 class125_0;

		// Token: 0x040049B2 RID: 18866
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x040049B3 RID: 18867
		[CompilerGenerated]
		[AccessedThroughProperty("Button_SideBriefing")]
		private Control9 control9_5;

		// Token: 0x040049B4 RID: 18868
		private Side side_0;

		// Token: 0x040049B5 RID: 18869
		private bool bool_3;
	}
}
