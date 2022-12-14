using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns5;

namespace ns4
{
	// Token: 0x02000E2F RID: 3631
	[DesignerGenerated]
	internal sealed partial class ScenarioMerge : DarkSecondaryFormBase
	{
		// Token: 0x06006CC1 RID: 27841 RVA: 0x003BA09C File Offset: 0x003B829C
		public ScenarioMerge()
		{
			base.Shown += this.ScenarioMerge_Shown;
			base.KeyDown += this.ScenarioMerge_KeyDown;
			base.FormClosing += this.ScenarioMerge_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x06006CC3 RID: 27843 RVA: 0x003BA12C File Offset: 0x003B832C
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			this.vmethod_1(new Class116());
			this.vmethod_3(new Control8());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Control8());
			this.vmethod_11(new Control9());
			this.vmethod_13(new Class116());
			this.vmethod_15(new Control8());
			this.vmethod_17(new Control9());
			this.vmethod_19(new Control9());
			this.vmethod_21(new OpenFileDialog());
			this.vmethod_23(new Class116());
			this.vmethod_25(new Class2451());
			this.vmethod_27(new SaveFileDialog());
			this.vmethod_29(new Timer(this.icontainer_1));
			this.vmethod_31(new Control8());
			this.vmethod_33(new Class112());
			base.SuspendLayout();
			this.vmethod_0().method_2(true);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(0, 16);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(71, 15);
			this.vmethod_0().TabIndex = 8;
			this.vmethod_0().Text = "Scenario #1:";
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().method_14(null);
			this.vmethod_2().method_15(AutoCompleteMode.None);
			this.vmethod_2().method_13(AutoCompleteSource.None);
			this.vmethod_2().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().method_12(null);
			this.vmethod_2().method_18(null);
			this.vmethod_2().Location = new Point(120, 12);
			this.vmethod_2().method_2(32767);
			this.vmethod_2().method_7(false);
			this.vmethod_2().Name = "TextBox_Scenario1";
			this.vmethod_2().method_3(false);
			this.vmethod_2().method_19(ScrollBars.None);
			this.vmethod_2().method_9(0);
			this.vmethod_2().Size = new Size(413, 23);
			this.vmethod_2().TabIndex = 9;
			this.vmethod_2().method_1(HorizontalAlignment.Left);
			this.vmethod_2().method_5(false);
			this.vmethod_2().method_10("");
			this.vmethod_4().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(539, 12);
			this.vmethod_4().Name = "Button_Scenario1File";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(73, 23);
			this.vmethod_4().TabIndex = 10;
			this.vmethod_4().Text = "Select...";
			this.vmethod_6().method_2(true);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(0, 42);
			this.vmethod_6().Name = "Label2";
			this.vmethod_6().Size = new Size(71, 15);
			this.vmethod_6().TabIndex = 11;
			this.vmethod_6().Text = "Scenario #2:";
			this.vmethod_8().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_8().method_14(null);
			this.vmethod_8().method_15(AutoCompleteMode.None);
			this.vmethod_8().method_13(AutoCompleteSource.None);
			this.vmethod_8().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().method_12(null);
			this.vmethod_8().method_18(null);
			this.vmethod_8().Location = new Point(120, 39);
			this.vmethod_8().method_2(32767);
			this.vmethod_8().method_7(false);
			this.vmethod_8().Name = "TextBox_Scenario2";
			this.vmethod_8().method_3(false);
			this.vmethod_8().method_19(ScrollBars.None);
			this.vmethod_8().method_9(0);
			this.vmethod_8().Size = new Size(413, 23);
			this.vmethod_8().TabIndex = 12;
			this.vmethod_8().method_1(HorizontalAlignment.Left);
			this.vmethod_8().method_5(false);
			this.vmethod_8().method_10("");
			this.vmethod_10().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DialogResult = DialogResult.None;
			this.vmethod_10().ForeColor = SystemColors.Control;
			this.vmethod_10().Location = new Point(539, 39);
			this.vmethod_10().Name = "Button_Scenario2File";
			this.vmethod_10().method_1(0);
			this.vmethod_10().Size = new Size(73, 23);
			this.vmethod_10().TabIndex = 13;
			this.vmethod_10().Text = "Select...";
			this.vmethod_12().method_2(true);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(0, 68);
			this.vmethod_12().Name = "Label4";
			this.vmethod_12().Size = new Size(98, 15);
			this.vmethod_12().TabIndex = 14;
			this.vmethod_12().Text = "Merged scenario:";
			this.vmethod_14().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_14().method_14(null);
			this.vmethod_14().method_15(AutoCompleteMode.None);
			this.vmethod_14().method_13(AutoCompleteSource.None);
			this.vmethod_14().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().method_12(null);
			this.vmethod_14().method_18(null);
			this.vmethod_14().Location = new Point(120, 65);
			this.vmethod_14().method_2(32767);
			this.vmethod_14().method_7(false);
			this.vmethod_14().Name = "TextBox_MergeResult";
			this.vmethod_14().method_3(false);
			this.vmethod_14().method_19(ScrollBars.None);
			this.vmethod_14().method_9(0);
			this.vmethod_14().Size = new Size(413, 23);
			this.vmethod_14().TabIndex = 15;
			this.vmethod_14().method_1(HorizontalAlignment.Left);
			this.vmethod_14().method_5(false);
			this.vmethod_14().method_10("");
			this.vmethod_16().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().DialogResult = DialogResult.None;
			this.vmethod_16().ForeColor = SystemColors.Control;
			this.vmethod_16().Location = new Point(539, 65);
			this.vmethod_16().Name = "Button_MergeResultFile";
			this.vmethod_16().method_1(0);
			this.vmethod_16().Size = new Size(73, 23);
			this.vmethod_16().TabIndex = 16;
			this.vmethod_16().Text = "Select...";
			this.vmethod_18().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().DialogResult = DialogResult.None;
			this.vmethod_18().Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_18().ForeColor = SystemColors.Control;
			this.vmethod_18().Location = new Point(266, 145);
			this.vmethod_18().MaximumSize = new Size(100, 34);
			this.vmethod_18().Name = "Button_Merge";
			this.vmethod_18().method_1(0);
			this.vmethod_18().Size = new Size(100, 34);
			this.vmethod_18().TabIndex = 17;
			this.vmethod_18().Text = "MERGE";
			this.vmethod_20().FileName = "OpenFileDialog1";
			this.vmethod_22().method_2(true);
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().Location = new Point(0, 94);
			this.vmethod_22().Name = "Label_DBMatch";
			this.vmethod_22().Size = new Size(114, 15);
			this.vmethod_22().TabIndex = 18;
			this.vmethod_22().Text = "DB match tolerance:";
			this.vmethod_24().BackColor = Color.Transparent;
			this.vmethod_24().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_24().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_24().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_24().FormattingEnabled = true;
			this.vmethod_24().Items.AddRange(new object[]
			{
				"Scenarios must use same exact DB version (safe)",
				"Scenarios must use same general DB (risky)",
				"Do not check for DB match at all (seatbelts off!)"
			});
			this.vmethod_24().Location = new Point(120, 91);
			this.vmethod_24().Name = "Combo_DBMatch";
			this.vmethod_24().Size = new Size(413, 21);
			this.vmethod_24().TabIndex = 19;
			this.vmethod_30().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_30().method_14(null);
			this.vmethod_30().method_15(AutoCompleteMode.None);
			this.vmethod_30().method_13(AutoCompleteSource.None);
			this.vmethod_30().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().method_12(null);
			this.vmethod_30().method_18(null);
			this.vmethod_30().Location = new Point(1, 185);
			this.vmethod_30().method_2(32767);
			this.vmethod_30().method_7(true);
			this.vmethod_30().Name = "TextBox1";
			this.vmethod_30().method_3(false);
			this.vmethod_30().method_19(ScrollBars.Vertical);
			this.vmethod_30().method_9(0);
			this.vmethod_30().Size = new Size(611, 196);
			this.vmethod_30().TabIndex = 20;
			this.vmethod_30().method_1(HorizontalAlignment.Left);
			this.vmethod_30().method_5(false);
			this.vmethod_30().method_10("");
			this.vmethod_32().BackColor = Color.Transparent;
			this.vmethod_32().Cursor = Cursors.Hand;
			this.vmethod_32().ForeColor = Color.FromArgb(209, 209, 209);
			this.vmethod_32().Location = new Point(120, 118);
			this.vmethod_32().Name = "CB_AllowSameSide";
			this.vmethod_32().Size = new Size(205, 18);
			this.vmethod_32().TabIndex = 21;
			this.vmethod_32().Text = "Allow merging clones of the same side";
			base.AutoScaleDimensions = new SizeF(7f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(613, 379);
			base.Controls.Add(this.vmethod_32());
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ScenarioMerge";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Merge scenarios";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x000446F6 File Offset: 0x000428F6
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x000446FE File Offset: 0x000428FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_4)
		{
			this.class116_0 = class116_4;
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x00044707 File Offset: 0x00042907
		[CompilerGenerated]
		internal Control8 vmethod_2()
		{
			return this.control8_0;
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x0004470F File Offset: 0x0004290F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control8 control8_4)
		{
			this.control8_0 = control8_4;
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x00044718 File Offset: 0x00042918
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_0;
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x003BAE60 File Offset: 0x003B9060
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_4;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006CCA RID: 27850 RVA: 0x00044720 File Offset: 0x00042920
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_1;
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x00044728 File Offset: 0x00042928
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_4)
		{
			this.class116_1 = class116_4;
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x00044731 File Offset: 0x00042931
		[CompilerGenerated]
		internal Control8 vmethod_8()
		{
			return this.control8_1;
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x00044739 File Offset: 0x00042939
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control8 control8_4)
		{
			this.control8_1 = control8_4;
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x00044742 File Offset: 0x00042942
		[CompilerGenerated]
		internal Control9 vmethod_10()
		{
			return this.control9_1;
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x003BAEA4 File Offset: 0x003B90A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_5);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_4;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x0004474A File Offset: 0x0004294A
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_2;
		}

		// Token: 0x06006CD1 RID: 27857 RVA: 0x00044752 File Offset: 0x00042952
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_4)
		{
			this.class116_2 = class116_4;
		}

		// Token: 0x06006CD2 RID: 27858 RVA: 0x0004475B File Offset: 0x0004295B
		[CompilerGenerated]
		internal Control8 vmethod_14()
		{
			return this.control8_2;
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x00044763 File Offset: 0x00042963
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control8 control8_4)
		{
			this.control8_2 = control8_4;
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x0004476C File Offset: 0x0004296C
		[CompilerGenerated]
		internal Control9 vmethod_16()
		{
			return this.control9_2;
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x003BAEE8 File Offset: 0x003B90E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_6);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_4;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006CD6 RID: 27862 RVA: 0x00044774 File Offset: 0x00042974
		[CompilerGenerated]
		internal Control9 vmethod_18()
		{
			return this.control9_3;
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x003BAF2C File Offset: 0x003B912C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_4;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x0004477C File Offset: 0x0004297C
		[CompilerGenerated]
		internal OpenFileDialog vmethod_20()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x00044784 File Offset: 0x00042984
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x0004478D File Offset: 0x0004298D
		[CompilerGenerated]
		internal Class116 vmethod_22()
		{
			return this.class116_3;
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x00044795 File Offset: 0x00042995
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class116 class116_4)
		{
			this.class116_3 = class116_4;
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x0004479E File Offset: 0x0004299E
		[CompilerGenerated]
		internal Class2451 vmethod_24()
		{
			return this.class2451_0;
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x000447A6 File Offset: 0x000429A6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class2451 class2451_1)
		{
			this.class2451_0 = class2451_1;
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x000447AF File Offset: 0x000429AF
		[CompilerGenerated]
		internal SaveFileDialog vmethod_26()
		{
			return this.saveFileDialog_0;
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x000447B7 File Offset: 0x000429B7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(SaveFileDialog saveFileDialog_1)
		{
			this.saveFileDialog_0 = saveFileDialog_1;
		}

		// Token: 0x06006CE0 RID: 27872 RVA: 0x000447C0 File Offset: 0x000429C0
		[CompilerGenerated]
		internal Timer vmethod_28()
		{
			return this.timer_0;
		}

		// Token: 0x06006CE1 RID: 27873 RVA: 0x003BAF70 File Offset: 0x003B9170
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_7);
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

		// Token: 0x06006CE2 RID: 27874 RVA: 0x000447C8 File Offset: 0x000429C8
		[CompilerGenerated]
		internal Control8 vmethod_30()
		{
			return this.control8_3;
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x000447D0 File Offset: 0x000429D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Control8 control8_4)
		{
			this.control8_3 = control8_4;
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x000447D9 File Offset: 0x000429D9
		[CompilerGenerated]
		internal Class112 vmethod_32()
		{
			return this.class112_0;
		}

		// Token: 0x06006CE5 RID: 27877 RVA: 0x000447E1 File Offset: 0x000429E1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class112 class112_1)
		{
			this.class112_0 = class112_1;
		}

		// Token: 0x06006CE6 RID: 27878 RVA: 0x003BAFB4 File Offset: 0x003B91B4
		private void ScenarioMerge_Shown(object sender, EventArgs e)
		{
			this.vmethod_24().SelectedIndex = 0;
			if (!GameGeneral.smethod_6() && !GameGeneral.smethod_7())
			{
				this.vmethod_22().Visible = false;
				this.vmethod_24().Visible = false;
				this.vmethod_32().Visible = false;
				return;
			}
			this.vmethod_22().Visible = true;
			this.vmethod_24().Visible = true;
			this.vmethod_32().Visible = true;
		}

		// Token: 0x06006CE7 RID: 27879 RVA: 0x003BB024 File Offset: 0x003B9224
		private void method_3(object sender, EventArgs e)
		{
			ScenarioMerge.Class2468 @class = new ScenarioMerge.Class2468();
			@class.scenarioMerge_0 = this;
			this.vmethod_30().method_20();
			this.string_1 = string.Empty;
			this.string_0 = string.Empty;
			@class.string_0 = this.vmethod_2().Text;
			@class.string_1 = this.vmethod_8().Text;
			@class.string_2 = this.vmethod_14().Text;
			@class.enum134_0 = DBOps.Enum134.const_1;
			switch (this.vmethod_24().SelectedIndex)
			{
			case 0:
				@class.enum134_0 = DBOps.Enum134.const_1;
				break;
			case 1:
				@class.enum134_0 = DBOps.Enum134.const_2;
				break;
			case 2:
				@class.enum134_0 = DBOps.Enum134.const_3;
				break;
			default:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					return;
				}
				return;
			}
			this.vmethod_28().Start();
			Task.Factory.StartNew(new Action(@class.method_0));
		}

		// Token: 0x06006CE8 RID: 27880 RVA: 0x003BB100 File Offset: 0x003B9300
		private void method_4(object sender, EventArgs e)
		{
			this.vmethod_20().DefaultExt = "*.scen";
			this.vmethod_20().FileName = "*.scen";
			if (this.vmethod_20().ShowDialog() == DialogResult.OK)
			{
				this.vmethod_2().Text = this.vmethod_20().FileName;
			}
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x003BB154 File Offset: 0x003B9354
		private void method_5(object sender, EventArgs e)
		{
			this.vmethod_20().DefaultExt = "*.scen";
			this.vmethod_20().FileName = "*.scen";
			if (this.vmethod_20().ShowDialog() == DialogResult.OK)
			{
				this.vmethod_8().Text = this.vmethod_20().FileName;
			}
		}

		// Token: 0x06006CEA RID: 27882 RVA: 0x000447EA File Offset: 0x000429EA
		private void method_6(object sender, EventArgs e)
		{
			this.vmethod_26().DefaultExt = "*.scen";
			if (this.vmethod_26().ShowDialog() == DialogResult.OK)
			{
				this.vmethod_14().Text = this.vmethod_26().FileName;
			}
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x003BB1A8 File Offset: 0x003B93A8
		private void ScenarioMerge_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode != Keys.Space || !base.Visible)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x00044820 File Offset: 0x00042A20
		private void ScenarioMerge_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x00044831 File Offset: 0x00042A31
		private void method_7(object sender, EventArgs e)
		{
			this.method_8();
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x003BB1F8 File Offset: 0x003B93F8
		private void method_8()
		{
			if (string.CompareOrdinal(this.string_0, this.string_1) > 0)
			{
				this.vmethod_30().SuspendLayout();
				this.vmethod_30().method_20();
				this.vmethod_30().Text = this.string_0;
				this.vmethod_30().ResumeLayout();
				this.string_1 = this.string_0;
			}
		}

		// Token: 0x06006CEF RID: 27887 RVA: 0x00044839 File Offset: 0x00042A39
		[CompilerGenerated]
		private void method_9()
		{
			this.vmethod_28().Stop();
			this.method_8();
		}

		// Token: 0x04003E08 RID: 15880
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04003E09 RID: 15881
		[AccessedThroughProperty("TextBox_Scenario1")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x04003E0A RID: 15882
		[AccessedThroughProperty("Button_Scenario1File")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04003E0B RID: 15883
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x04003E0C RID: 15884
		[AccessedThroughProperty("TextBox_Scenario2")]
		[CompilerGenerated]
		private Control8 control8_1;

		// Token: 0x04003E0D RID: 15885
		[CompilerGenerated]
		[AccessedThroughProperty("Button_Scenario2File")]
		private Control9 control9_1;

		// Token: 0x04003E0E RID: 15886
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x04003E0F RID: 15887
		[AccessedThroughProperty("TextBox_MergeResult")]
		[CompilerGenerated]
		private Control8 control8_2;

		// Token: 0x04003E10 RID: 15888
		[CompilerGenerated]
		[AccessedThroughProperty("Button_MergeResultFile")]
		private Control9 control9_2;

		// Token: 0x04003E11 RID: 15889
		[CompilerGenerated]
		[AccessedThroughProperty("Button_Merge")]
		private Control9 control9_3;

		// Token: 0x04003E12 RID: 15890
		[AccessedThroughProperty("OpenFileDialog1")]
		[CompilerGenerated]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04003E13 RID: 15891
		[AccessedThroughProperty("Label_DBMatch")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x04003E14 RID: 15892
		[AccessedThroughProperty("Combo_DBMatch")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04003E15 RID: 15893
		[CompilerGenerated]
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog saveFileDialog_0;

		// Token: 0x04003E16 RID: 15894
		[AccessedThroughProperty("Timer1")]
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x04003E17 RID: 15895
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private Control8 control8_3;

		// Token: 0x04003E18 RID: 15896
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AllowSameSide")]
		private Class112 class112_0;

		// Token: 0x04003E19 RID: 15897
		private string string_0;

		// Token: 0x04003E1A RID: 15898
		private string string_1;

		// Token: 0x02000E30 RID: 3632
		[CompilerGenerated]
		internal sealed class Class2468
		{
			// Token: 0x06006CF1 RID: 27889 RVA: 0x003BB258 File Offset: 0x003B9458
			internal void method_0()
			{
				Scenario.smethod_25(this.string_0, this.string_1, this.string_2, this.enum134_0, this.scenarioMerge_0.vmethod_32().Checked, ref this.scenarioMerge_0.string_0);
				this.scenarioMerge_0.Invoke(new VB$AnonymousDelegate_0(this.scenarioMerge_0.method_9));
			}

			// Token: 0x04003E1B RID: 15899
			public string string_0;

			// Token: 0x04003E1C RID: 15900
			public string string_1;

			// Token: 0x04003E1D RID: 15901
			public string string_2;

			// Token: 0x04003E1E RID: 15902
			public DBOps.Enum134 enum134_0;

			// Token: 0x04003E1F RID: 15903
			public ScenarioMerge scenarioMerge_0;
		}
	}
}
