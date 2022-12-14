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
using ns2;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000E9C RID: 3740
	[DesignerGenerated]
	internal sealed partial class TimeToReadyWindow : DarkSecondaryFormBase
	{
		// Token: 0x06007530 RID: 30000 RVA: 0x003F3EFC File Offset: 0x003F20FC
		public TimeToReadyWindow()
		{
			base.Shown += this.TimeToReadyWindow_Shown;
			base.KeyDown += this.TimeToReadyWindow_KeyDown;
			base.FormClosing += this.TimeToReadyWindow_FormClosing;
			base.Load += this.TimeToReadyWindow_Load;
			this.list_0 = new List<ActiveUnit>();
			this.InitializeComponent_1();
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x003F3FA8 File Offset: 0x003F21A8
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class118());
			this.vmethod_3(new Class116());
			this.vmethod_5(new Control9());
			base.SuspendLayout();
			this.vmethod_0().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_0().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(105, 6);
			this.vmethod_0().Mask = "00:00:00";
			this.vmethod_0().Name = "MaskedTextBox1";
			this.vmethod_0().Size = new Size(86, 23);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().method_2(true);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(3, 9);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new Size(96, 15);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Days:Hours:Mins";
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(197, 6);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(81, 23);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "OK";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(284, 31);
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "TimeToReadyWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Time To Ready";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x00048D26 File Offset: 0x00046F26
		[CompilerGenerated]
		internal Class118 vmethod_0()
		{
			return this.class118_0;
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x00048D2E File Offset: 0x00046F2E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class118 class118_1)
		{
			this.class118_0 = class118_1;
		}

		// Token: 0x06007535 RID: 30005 RVA: 0x00048D37 File Offset: 0x00046F37
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x06007536 RID: 30006 RVA: 0x00048D3F File Offset: 0x00046F3F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x06007537 RID: 30007 RVA: 0x00048D48 File Offset: 0x00046F48
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_0;
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x003F4224 File Offset: 0x003F2424
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_1)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_1;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007539 RID: 30009 RVA: 0x00048D50 File Offset: 0x00046F50
		private void TimeToReadyWindow_Shown(object sender, EventArgs e)
		{
			if (this.list_0.Count == 0)
			{
				base.Close();
			}
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x003F4268 File Offset: 0x003F2468
		private void method_3(object sender, EventArgs e)
		{
			List<string> list = Enumerable.ToList<string>(this.vmethod_0().Text.Replace(".", ":").Split(Conversions.ToCharArrayRankOne(":")));
			if (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2]))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2]), 0);
				try
				{
					foreach (ActiveUnit activeUnit in this.list_0)
					{
						if (activeUnit.bool_3)
						{
							((Aircraft_AirOps)activeUnit.vmethod_92()).method_39((float)timeSpan.TotalSeconds);
							if (((Aircraft_AirOps)activeUnit.vmethod_92()).method_38() > 0f)
							{
								if (((Aircraft_AirOps)activeUnit.vmethod_92()).method_36() == Aircraft_AirOps._AirOpsCondition.Parked)
								{
									((Aircraft_AirOps)activeUnit.vmethod_92()).method_37(Aircraft_AirOps._AirOpsCondition.Readying);
								}
							}
							else if (((Aircraft_AirOps)activeUnit.vmethod_92()).method_36() == Aircraft_AirOps._AirOpsCondition.Readying)
							{
								((Aircraft_AirOps)activeUnit.vmethod_92()).method_37(Aircraft_AirOps._AirOpsCondition.Parked);
							}
						}
						else
						{
							activeUnit.vmethod_93().method_1((float)timeSpan.TotalSeconds);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (!Information.IsNothing(Class2413.smethod_2().method_7()) && Class2413.smethod_2().method_7().Visible)
				{
					Class2413.smethod_2().method_7().method_13();
				}
				if (!Information.IsNothing(Class2413.smethod_2().method_18()) && Class2413.smethod_2().method_18().Visible)
				{
					Class2413.smethod_2().method_18().method_6();
				}
				base.Close();
			}
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x003B6260 File Offset: 0x003B4460
		private void TimeToReadyWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600753C RID: 30012 RVA: 0x00044820 File Offset: 0x00042A20
		private void TimeToReadyWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600753D RID: 30013 RVA: 0x00044489 File Offset: 0x00042689
		private void TimeToReadyWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x040041D3 RID: 16851
		[AccessedThroughProperty("MaskedTextBox1")]
		[CompilerGenerated]
		private Class118 class118_0;

		// Token: 0x040041D4 RID: 16852
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x040041D5 RID: 16853
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x040041D6 RID: 16854
		public List<ActiveUnit> list_0;
	}
}
