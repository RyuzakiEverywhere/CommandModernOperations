using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000ED3 RID: 3795
	[DesignerGenerated]
	internal sealed partial class ScoringWindow : DarkSecondaryFormBase
	{
		// Token: 0x06008413 RID: 33811 RVA: 0x0046F2B4 File Offset: 0x0046D4B4
		public ScoringWindow()
		{
			base.Load += this.ScoringWindow_Load;
			base.KeyDown += this.ScoringWindow_KeyDown;
			base.FormClosing += this.ScoringWindow_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x06008415 RID: 33813 RVA: 0x0046F344 File Offset: 0x0046D544
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class116());
			this.vmethod_3(new Class116());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Class116());
			this.vmethod_11(new Class116());
			this.vmethod_13(new Class116());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Class120());
			this.vmethod_19(new Class120());
			((ISupportInitialize)this.vmethod_16()).BeginInit();
			((ISupportInitialize)this.vmethod_18()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(13, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(217, 20);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Victory/Defeat Thresholds";
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(14, 56);
			this.vmethod_2().Name = "Label2";
			this.vmethod_2().Size = new Size(48, 13);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Disaster:";
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(14, 228);
			this.vmethod_4().Name = "Label8";
			this.vmethod_4().Size = new Size(48, 13);
			this.vmethod_4().TabIndex = 11;
			this.vmethod_4().Text = "Triumph:";
			this.vmethod_6().method_2(true);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(14, 199);
			this.vmethod_6().Name = "Label_MajorVictory";
			this.vmethod_6().Size = new Size(81, 15);
			this.vmethod_6().TabIndex = 10;
			this.vmethod_6().Text = "Major Victory:";
			this.vmethod_8().method_2(true);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(14, 171);
			this.vmethod_8().Name = "Label_MinorVictory";
			this.vmethod_8().Size = new Size(82, 15);
			this.vmethod_8().TabIndex = 9;
			this.vmethod_8().Text = "Minor Victory:";
			this.vmethod_10().method_2(true);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Location = new Point(14, 142);
			this.vmethod_10().Name = "Label_Average";
			this.vmethod_10().Size = new Size(53, 15);
			this.vmethod_10().TabIndex = 7;
			this.vmethod_10().Text = "Average:";
			this.vmethod_12().method_2(true);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(14, 114);
			this.vmethod_12().Name = "Label_MinorDefeat";
			this.vmethod_12().Size = new Size(79, 15);
			this.vmethod_12().TabIndex = 5;
			this.vmethod_12().Text = "Minor Defeat:";
			this.vmethod_14().method_2(true);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(14, 87);
			this.vmethod_14().Name = "Label_MajorDefeat";
			this.vmethod_14().Size = new Size(78, 15);
			this.vmethod_14().TabIndex = 3;
			this.vmethod_14().Text = "Major Defeat:";
			this.vmethod_16().BackColor = Color.FromArgb(28, 28, 28);
			this.vmethod_16().BorderStyle = BorderStyle.None;
			this.vmethod_16().Font = new Font("Segoe UI", 12f);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Location = new Point(98, 52);
			this.vmethod_16().Name = "NUD_Disaster";
			this.vmethod_16().Size = new Size(132, 25);
			this.vmethod_16().TabIndex = 24;
			this.vmethod_18().BackColor = Color.FromArgb(28, 28, 28);
			this.vmethod_18().BorderStyle = BorderStyle.None;
			this.vmethod_18().Font = new Font("Segoe UI", 12f);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(98, 224);
			this.vmethod_18().Name = "NUD_Triumph";
			this.vmethod_18().Size = new Size(132, 25);
			this.vmethod_18().TabIndex = 25;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(243, 260);
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ScoringWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Scoring";
			((ISupportInitialize)this.vmethod_16()).EndInit();
			((ISupportInitialize)this.vmethod_18()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008416 RID: 33814 RVA: 0x0005006B File Offset: 0x0004E26B
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x06008417 RID: 33815 RVA: 0x00050073 File Offset: 0x0004E273
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_8)
		{
			this.class116_0 = class116_8;
		}

		// Token: 0x06008418 RID: 33816 RVA: 0x0005007C File Offset: 0x0004E27C
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_1;
		}

		// Token: 0x06008419 RID: 33817 RVA: 0x00050084 File Offset: 0x0004E284
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_8)
		{
			this.class116_1 = class116_8;
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x0005008D File Offset: 0x0004E28D
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_2;
		}

		// Token: 0x0600841B RID: 33819 RVA: 0x00050095 File Offset: 0x0004E295
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_8)
		{
			this.class116_2 = class116_8;
		}

		// Token: 0x0600841C RID: 33820 RVA: 0x0005009E File Offset: 0x0004E29E
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_3;
		}

		// Token: 0x0600841D RID: 33821 RVA: 0x000500A6 File Offset: 0x0004E2A6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_8)
		{
			this.class116_3 = class116_8;
		}

		// Token: 0x0600841E RID: 33822 RVA: 0x000500AF File Offset: 0x0004E2AF
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_4;
		}

		// Token: 0x0600841F RID: 33823 RVA: 0x000500B7 File Offset: 0x0004E2B7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_8)
		{
			this.class116_4 = class116_8;
		}

		// Token: 0x06008420 RID: 33824 RVA: 0x000500C0 File Offset: 0x0004E2C0
		[CompilerGenerated]
		internal Class116 vmethod_10()
		{
			return this.class116_5;
		}

		// Token: 0x06008421 RID: 33825 RVA: 0x000500C8 File Offset: 0x0004E2C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class116 class116_8)
		{
			this.class116_5 = class116_8;
		}

		// Token: 0x06008422 RID: 33826 RVA: 0x000500D1 File Offset: 0x0004E2D1
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_6;
		}

		// Token: 0x06008423 RID: 33827 RVA: 0x000500D9 File Offset: 0x0004E2D9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_8)
		{
			this.class116_6 = class116_8;
		}

		// Token: 0x06008424 RID: 33828 RVA: 0x000500E2 File Offset: 0x0004E2E2
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_7;
		}

		// Token: 0x06008425 RID: 33829 RVA: 0x000500EA File Offset: 0x0004E2EA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_8)
		{
			this.class116_7 = class116_8;
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x000500F3 File Offset: 0x0004E2F3
		[CompilerGenerated]
		internal Class120 vmethod_16()
		{
			return this.class120_0;
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x0046FA54 File Offset: 0x0046DC54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class120 class120_2)
		{
			EventHandler value = new EventHandler(this.method_5);
			Class120 @class = this.class120_0;
			if (@class != null)
			{
				@class.ValueChanged -= value;
			}
			this.class120_0 = class120_2;
			@class = this.class120_0;
			if (@class != null)
			{
				@class.ValueChanged += value;
			}
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x000500FB File Offset: 0x0004E2FB
		[CompilerGenerated]
		internal Class120 vmethod_18()
		{
			return this.class120_1;
		}

		// Token: 0x06008429 RID: 33833 RVA: 0x0046FA98 File Offset: 0x0046DC98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class120 class120_2)
		{
			EventHandler value = new EventHandler(this.method_6);
			Class120 @class = this.class120_1;
			if (@class != null)
			{
				@class.ValueChanged -= value;
			}
			this.class120_1 = class120_2;
			@class = this.class120_1;
			if (@class != null)
			{
				@class.ValueChanged += value;
			}
		}

		// Token: 0x0600842A RID: 33834 RVA: 0x0046FADC File Offset: 0x0046DCDC
		private void ScoringWindow_Load(object sender, EventArgs e)
		{
			this.vmethod_16().Maximum = 2147483647m;
			this.vmethod_16().Minimum = -2147483648m;
			this.vmethod_18().Maximum = 2147483647m;
			this.vmethod_18().Minimum = -2147483648m;
			if (Client.smethod_50().nullable_0 == null)
			{
				Client.smethod_50().nullable_0 = new int?(-100);
			}
			this.vmethod_16().Value = new decimal(Client.smethod_50().nullable_0.Value);
			if (Client.smethod_50().nullable_1 == null)
			{
				Client.smethod_50().nullable_1 = new int?(100);
			}
			this.vmethod_18().Value = new decimal(Client.smethod_50().nullable_1.Value);
		}

		// Token: 0x0600842B RID: 33835 RVA: 0x0046FBD0 File Offset: 0x0046DDD0
		private void method_3()
		{
			if (Versioned.IsNumeric(this.vmethod_16().Value))
			{
				Client.smethod_50().nullable_0 = new int?(Convert.ToInt32(this.vmethod_16().Value));
				this.vmethod_14().Text = "Major Defeat: " + Conversions.ToString(Client.smethod_50().method_30());
				this.vmethod_12().Text = "Minor Defeat: " + Conversions.ToString(Client.smethod_50().method_31());
				this.vmethod_10().Text = "Average: " + Conversions.ToString(Client.smethod_50().method_32());
				this.vmethod_8().Text = "Minor Victory: " + Conversions.ToString(Client.smethod_50().method_33());
				this.vmethod_6().Text = "Major Victory: " + Conversions.ToString(Client.smethod_50().method_34());
			}
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x0046FCCC File Offset: 0x0046DECC
		private void method_4()
		{
			if (Versioned.IsNumeric(this.vmethod_18().Value))
			{
				Client.smethod_50().nullable_1 = new int?(Convert.ToInt32(this.vmethod_18().Value));
				this.vmethod_14().Text = "Major Defeat: " + Conversions.ToString(Client.smethod_50().method_30());
				this.vmethod_12().Text = "Minor Defeat: " + Conversions.ToString(Client.smethod_50().method_31());
				this.vmethod_10().Text = "Average: " + Conversions.ToString(Client.smethod_50().method_32());
				this.vmethod_8().Text = "Minor Victory: " + Conversions.ToString(Client.smethod_50().method_33());
				this.vmethod_6().Text = "Major Victory: " + Conversions.ToString(Client.smethod_50().method_34());
			}
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x0046FDC8 File Offset: 0x0046DFC8
		private void ScoringWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (!base.Visible || (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.End && e.KeyCode != Keys.Home && (e.KeyCode != Keys.C || e.Modifiers != Keys.Control) && (e.KeyCode != Keys.X || e.Modifiers != Keys.Control) && (e.KeyCode != Keys.V || e.Modifiers != Keys.Control)))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x00044820 File Offset: 0x00042A20
		private void ScoringWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x00050103 File Offset: 0x0004E303
		[CompilerGenerated]
		private void method_5(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x0005010B File Offset: 0x0004E30B
		[CompilerGenerated]
		private void method_6(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x04004851 RID: 18513
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04004852 RID: 18514
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x04004853 RID: 18515
		[AccessedThroughProperty("Label8")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x04004854 RID: 18516
		[AccessedThroughProperty("Label_MajorVictory")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x04004855 RID: 18517
		[AccessedThroughProperty("Label_MinorVictory")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x04004856 RID: 18518
		[CompilerGenerated]
		[AccessedThroughProperty("Label_Average")]
		private Class116 class116_5;

		// Token: 0x04004857 RID: 18519
		[CompilerGenerated]
		[AccessedThroughProperty("Label_MinorDefeat")]
		private Class116 class116_6;

		// Token: 0x04004858 RID: 18520
		[CompilerGenerated]
		[AccessedThroughProperty("Label_MajorDefeat")]
		private Class116 class116_7;

		// Token: 0x04004859 RID: 18521
		[CompilerGenerated]
		[AccessedThroughProperty("NUD_Disaster")]
		private Class120 class120_0;

		// Token: 0x0400485A RID: 18522
		[AccessedThroughProperty("NUD_Triumph")]
		[CompilerGenerated]
		private Class120 class120_1;
	}
}
