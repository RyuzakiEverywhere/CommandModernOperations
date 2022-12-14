using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns11;
using ns2;
using ns4;
using ns5;
using ns9;

namespace Command
{
	// Token: 0x02000EB0 RID: 3760
	[DesignerGenerated]
	public sealed partial class EditCondition : DarkSecondaryFormBase
	{
		// Token: 0x060078A2 RID: 30882 RVA: 0x0041AA34 File Offset: 0x00418C34
		public EditCondition()
		{
			base.FormClosing += this.EditCondition_FormClosing;
			base.Load += this.EditCondition_Load;
			base.KeyDown += this.EditCondition_KeyDown;
			this.InitializeComponent_1();
		}

		// Token: 0x060078A4 RID: 30884 RVA: 0x0041AAC4 File Offset: 0x00418CC4
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control8());
			this.vmethod_3(new Class116());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Control9());
			this.vmethod_9(new Control9());
			this.vmethod_11(new TabPage());
			this.vmethod_19(new Class2451());
			this.vmethod_21(new Class116());
			this.vmethod_23(new Class2451());
			this.vmethod_25(new Class116());
			this.vmethod_27(new Class112());
			this.vmethod_13(new Class2451());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Control12());
			this.vmethod_29(new TabPage());
			this.vmethod_31(new Class112());
			this.vmethod_33(new TabPage());
			this.vmethod_35(new Control10());
			this.vmethod_37(new Class116());
			this.vmethod_39(new Control9());
			this.vmethod_41(new Class2451());
			this.vmethod_43(new Class116());
			this.vmethod_45(new Control8());
			this.vmethod_10().SuspendLayout();
			this.vmethod_16().SuspendLayout();
			this.vmethod_28().SuspendLayout();
			this.vmethod_32().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().method_14(null);
			this.vmethod_0().method_15(AutoCompleteMode.None);
			this.vmethod_0().method_13(AutoCompleteSource.None);
			this.vmethod_0().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_0().method_17(new Font("Segoe UI", 10f));
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().method_12(null);
			this.vmethod_0().method_18(null);
			this.vmethod_0().Location = new Point(90, 12);
			this.vmethod_0().method_2(32767);
			this.vmethod_0().method_7(false);
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().method_3(false);
			this.vmethod_0().method_9(0);
			this.vmethod_0().Size = new Size(632, 20);
			this.vmethod_0().TabIndex = 6;
			this.vmethod_0().method_1(HorizontalAlignment.Left);
			this.vmethod_0().method_5(false);
			this.vmethod_0().method_10("");
			this.vmethod_2().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(4, 16);
			this.vmethod_2().Name = "Label2";
			this.vmethod_2().Size = new Size(75, 13);
			this.vmethod_2().TabIndex = 5;
			this.vmethod_2().Text = "Description:";
			this.vmethod_4().method_2(true);
			this.vmethod_4().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(3, 48);
			this.vmethod_4().Name = "Label3";
			this.vmethod_4().Size = new Size(120, 13);
			this.vmethod_4().TabIndex = 21;
			this.vmethod_4().Text = "Settings for condition";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font("Segoe UI", 10f);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(651, 448);
			this.vmethod_6().Name = "Button2";
			this.vmethod_6().Padding = new Padding(5);
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(75, 23);
			this.vmethod_6().TabIndex = 24;
			this.vmethod_6().Text = "Cancel";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DialogResult = DialogResult.None;
			this.vmethod_8().Font = new Font("Segoe UI", 10f);
			this.vmethod_8().ForeColor = SystemColors.Control;
			this.vmethod_8().Location = new Point(4, 448);
			this.vmethod_8().Name = "Button1";
			this.vmethod_8().Padding = new Padding(5);
			this.vmethod_8().method_1(0);
			this.vmethod_8().Size = new Size(75, 23);
			this.vmethod_8().TabIndex = 23;
			this.vmethod_8().Text = "OK";
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().Controls.Add(this.vmethod_18());
			this.vmethod_10().Controls.Add(this.vmethod_20());
			this.vmethod_10().Controls.Add(this.vmethod_22());
			this.vmethod_10().Controls.Add(this.vmethod_24());
			this.vmethod_10().Controls.Add(this.vmethod_26());
			this.vmethod_10().Controls.Add(this.vmethod_12());
			this.vmethod_10().Controls.Add(this.vmethod_14());
			this.vmethod_10().Location = new Point(4, 24);
			this.vmethod_10().Name = "TabPage1";
			this.vmethod_10().Padding = new Padding(3);
			this.vmethod_10().Size = new Size(714, 354);
			this.vmethod_10().TabIndex = 0;
			this.vmethod_10().Text = "Side Posture";
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_18().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_18().Font = new Font("Segoe UI", 7f);
			this.vmethod_18().FormattingEnabled = true;
			this.vmethod_18().Items.AddRange(new object[]
			{
				"Neutral",
				"Friendly",
				"Unfriendly",
				"Hostile",
				"Unknown"
			});
			this.vmethod_18().Location = new Point(557, 56);
			this.vmethod_18().Name = "CB_Postures";
			this.vmethod_18().Size = new Size(130, 21);
			this.vmethod_18().TabIndex = 13;
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Location = new Point(530, 59);
			this.vmethod_20().Name = "Label7";
			this.vmethod_20().Size = new Size(21, 13);
			this.vmethod_20().TabIndex = 12;
			this.vmethod_20().Text = "as:";
			this.vmethod_22().BackColor = Color.Transparent;
			this.vmethod_22().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_22().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_22().Font = new Font("Segoe UI", 7f);
			this.vmethod_22().FormattingEnabled = true;
			this.vmethod_22().Location = new Point(332, 56);
			this.vmethod_22().Name = "CB_TargetSides";
			this.vmethod_22().Size = new Size(192, 21);
			this.vmethod_22().TabIndex = 11;
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().Location = new Point(249, 59);
			this.vmethod_24().Name = "Label6";
			this.vmethod_24().Size = new Size(77, 13);
			this.vmethod_24().TabIndex = 10;
			this.vmethod_24().Text = "considers side:";
			this.vmethod_26().BackColor = Color.FromArgb(39, 39, 39);
			this.vmethod_26().Location = new Point(17, 24);
			this.vmethod_26().Name = "CB_SidePosture_ModifierNOT";
			this.vmethod_26().Size = new Size(92, 17);
			this.vmethod_26().TabIndex = 9;
			this.vmethod_26().Text = "Modifier: NOT";
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_12().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_12().Font = new Font("Segoe UI", 7f);
			this.vmethod_12().FormattingEnabled = true;
			this.vmethod_12().Location = new Point(51, 56);
			this.vmethod_12().Name = "CB_ObserverSides";
			this.vmethod_12().Size = new Size(192, 21);
			this.vmethod_12().TabIndex = 2;
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(14, 59);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Size = new Size(31, 13);
			this.vmethod_14().TabIndex = 0;
			this.vmethod_14().Text = "Side:";
			this.vmethod_16().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_16().Controls.Add(this.vmethod_10());
			this.vmethod_16().Controls.Add(this.vmethod_28());
			this.vmethod_16().Controls.Add(this.vmethod_32());
			this.vmethod_16().Cursor = Cursors.Hand;
			this.vmethod_16().Font = new Font("Segoe UI", 8f);
			this.vmethod_16().ItemSize = new Size(80, 20);
			this.vmethod_16().Location = new Point(4, 64);
			this.vmethod_16().Multiline = true;
			this.vmethod_16().Name = "TC_ConditionOptions";
			this.vmethod_16().SelectedIndex = 0;
			this.vmethod_16().Size = new Size(722, 382);
			this.vmethod_16().TabIndex = 22;
			this.vmethod_28().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_28().Controls.Add(this.vmethod_30());
			this.vmethod_28().Location = new Point(4, 24);
			this.vmethod_28().Name = "TabPage2";
			this.vmethod_28().Size = new Size(714, 354);
			this.vmethod_28().TabIndex = 1;
			this.vmethod_28().Text = "Scenario Has Started";
			this.vmethod_30().Location = new Point(16, 14);
			this.vmethod_30().Name = "CB_ScenHasStarted_ModifierNOT";
			this.vmethod_30().Size = new Size(92, 17);
			this.vmethod_30().TabIndex = 10;
			this.vmethod_30().Text = "Modifier: NOT";
			this.vmethod_32().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_32().Controls.Add(this.vmethod_34());
			this.vmethod_32().Controls.Add(this.vmethod_36());
			this.vmethod_32().Controls.Add(this.vmethod_38());
			this.vmethod_32().Controls.Add(this.vmethod_40());
			this.vmethod_32().Controls.Add(this.vmethod_42());
			this.vmethod_32().Controls.Add(this.vmethod_44());
			this.vmethod_32().Location = new Point(4, 24);
			this.vmethod_32().Name = "TabPage3";
			this.vmethod_32().Size = new Size(714, 354);
			this.vmethod_32().TabIndex = 2;
			this.vmethod_32().Text = "Lua Script";
			this.vmethod_34().BackColor = Color.Transparent;
			this.vmethod_34().Font = new Font("Segoe UI", 10f);
			this.vmethod_34().Location = new Point(669, 4);
			this.vmethod_34().method_1(100);
			this.vmethod_34().method_3(0);
			this.vmethod_34().Name = "NUD_LuaScript";
			this.vmethod_34().Size = new Size(45, 26);
			this.vmethod_34().TabIndex = 11;
			this.vmethod_34().Value = 0;
			this.vmethod_36().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_36().Location = new Point(609, 10);
			this.vmethod_36().Name = "Label13";
			this.vmethod_36().Size = new Size(54, 13);
			this.vmethod_36().TabIndex = 10;
			this.vmethod_36().Text = "Text Size:";
			this.vmethod_38().BackColor = Color.Transparent;
			this.vmethod_38().DialogResult = DialogResult.None;
			this.vmethod_38().Font = new Font("Segoe UI", 10f);
			this.vmethod_38().ForeColor = SystemColors.Control;
			this.vmethod_38().Location = new Point(533, 6);
			this.vmethod_38().Name = "Button_AddLuaScript";
			this.vmethod_38().Padding = new Padding(5);
			this.vmethod_38().method_1(0);
			this.vmethod_38().Size = new Size(75, 24);
			this.vmethod_38().TabIndex = 9;
			this.vmethod_38().Text = "ADD";
			this.vmethod_40().BackColor = Color.Transparent;
			this.vmethod_40().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_40().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_40().Font = new Font("Segoe UI", 7f);
			this.vmethod_40().FormattingEnabled = true;
			this.vmethod_40().Location = new Point(110, 6);
			this.vmethod_40().Name = "CB_LuaTemplate";
			this.vmethod_40().Size = new Size(417, 21);
			this.vmethod_40().TabIndex = 8;
			this.vmethod_42().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_42().Location = new Point(7, 9);
			this.vmethod_42().Name = "Label12";
			this.vmethod_42().Size = new Size(100, 13);
			this.vmethod_42().TabIndex = 7;
			this.vmethod_42().Text = "Add script template:";
			this.vmethod_44().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_44().method_14(null);
			this.vmethod_44().method_15(AutoCompleteMode.None);
			this.vmethod_44().method_13(AutoCompleteSource.None);
			this.vmethod_44().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_44().method_17(new Font("Segoe UI", 10f));
			this.vmethod_44().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_44().method_12(null);
			this.vmethod_44().method_18(null);
			this.vmethod_44().Location = new Point(0, 36);
			this.vmethod_44().method_2(999999999);
			this.vmethod_44().method_7(true);
			this.vmethod_44().Name = "TextBox2";
			this.vmethod_44().method_3(false);
			this.vmethod_44().method_9(0);
			this.vmethod_44().Size = new Size(714, 318);
			this.vmethod_44().TabIndex = 6;
			this.vmethod_44().method_1(HorizontalAlignment.Left);
			this.vmethod_44().method_5(false);
			this.vmethod_44().method_10("");
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(727, 473);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditCondition";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Edit event condition";
			this.vmethod_10().ResumeLayout(false);
			this.vmethod_16().ResumeLayout(false);
			this.vmethod_28().ResumeLayout(false);
			this.vmethod_32().ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x0004AA3E File Offset: 0x00048C3E
		[CompilerGenerated]
		internal Control8 vmethod_0()
		{
			return this.control8_0;
		}

		// Token: 0x060078A6 RID: 30886 RVA: 0x0041BCB4 File Offset: 0x00419EB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control8 control8_2)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_8);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.method_22(delegate85_);
			}
			this.control8_0 = control8_2;
			control = this.control8_0;
			if (control != null)
			{
				control.method_21(delegate85_);
			}
		}

		// Token: 0x060078A7 RID: 30887 RVA: 0x0004AA46 File Offset: 0x00048C46
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x060078A8 RID: 30888 RVA: 0x0004AA4E File Offset: 0x00048C4E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_7)
		{
			this.class116_0 = class116_7;
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x0004AA57 File Offset: 0x00048C57
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x060078AA RID: 30890 RVA: 0x0004AA5F File Offset: 0x00048C5F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_7)
		{
			this.class116_1 = class116_7;
		}

		// Token: 0x060078AB RID: 30891 RVA: 0x0004AA68 File Offset: 0x00048C68
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_0;
		}

		// Token: 0x060078AC RID: 30892 RVA: 0x0041BCF8 File Offset: 0x00419EF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_3;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060078AD RID: 30893 RVA: 0x0004AA70 File Offset: 0x00048C70
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_1;
		}

		// Token: 0x060078AE RID: 30894 RVA: 0x0041BD3C File Offset: 0x00419F3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_3;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060078AF RID: 30895 RVA: 0x0004AA78 File Offset: 0x00048C78
		[CompilerGenerated]
		internal TabPage vmethod_10()
		{
			return this.tabPage_0;
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x0004AA80 File Offset: 0x00048C80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TabPage tabPage_3)
		{
			this.tabPage_0 = tabPage_3;
		}

		// Token: 0x060078B1 RID: 30897 RVA: 0x0004AA89 File Offset: 0x00048C89
		[CompilerGenerated]
		internal Class2451 vmethod_12()
		{
			return this.class2451_0;
		}

		// Token: 0x060078B2 RID: 30898 RVA: 0x0041BD80 File Offset: 0x00419F80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_5);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_4;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060078B3 RID: 30899 RVA: 0x0004AA91 File Offset: 0x00048C91
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_2;
		}

		// Token: 0x060078B4 RID: 30900 RVA: 0x0004AA99 File Offset: 0x00048C99
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_7)
		{
			this.class116_2 = class116_7;
		}

		// Token: 0x060078B5 RID: 30901 RVA: 0x0004AAA2 File Offset: 0x00048CA2
		[CompilerGenerated]
		internal Control12 vmethod_16()
		{
			return this.control12_0;
		}

		// Token: 0x060078B6 RID: 30902 RVA: 0x0004AAAA File Offset: 0x00048CAA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control12 control12_1)
		{
			this.control12_0 = control12_1;
		}

		// Token: 0x060078B7 RID: 30903 RVA: 0x0004AAB3 File Offset: 0x00048CB3
		[CompilerGenerated]
		internal Class2451 vmethod_18()
		{
			return this.class2451_1;
		}

		// Token: 0x060078B8 RID: 30904 RVA: 0x0041BDC4 File Offset: 0x00419FC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_7);
			Class2451 @class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_1 = class2451_4;
			@class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x0004AABB File Offset: 0x00048CBB
		[CompilerGenerated]
		internal Class116 vmethod_20()
		{
			return this.class116_3;
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x0004AAC3 File Offset: 0x00048CC3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class116 class116_7)
		{
			this.class116_3 = class116_7;
		}

		// Token: 0x060078BB RID: 30907 RVA: 0x0004AACC File Offset: 0x00048CCC
		[CompilerGenerated]
		internal Class2451 vmethod_22()
		{
			return this.class2451_2;
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x0041BE08 File Offset: 0x0041A008
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_6);
			Class2451 @class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_2 = class2451_4;
			@class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x0004AAD4 File Offset: 0x00048CD4
		[CompilerGenerated]
		internal Class116 vmethod_24()
		{
			return this.class116_4;
		}

		// Token: 0x060078BE RID: 30910 RVA: 0x0004AADC File Offset: 0x00048CDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class116 class116_7)
		{
			this.class116_4 = class116_7;
		}

		// Token: 0x060078BF RID: 30911 RVA: 0x0004AAE5 File Offset: 0x00048CE5
		[CompilerGenerated]
		internal Class112 vmethod_26()
		{
			return this.class112_0;
		}

		// Token: 0x060078C0 RID: 30912 RVA: 0x0041BE4C File Offset: 0x0041A04C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class112 class112_2)
		{
			EventHandler value = new EventHandler(this.method_9);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_0 = class112_2;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060078C1 RID: 30913 RVA: 0x0004AAED File Offset: 0x00048CED
		[CompilerGenerated]
		internal TabPage vmethod_28()
		{
			return this.tabPage_1;
		}

		// Token: 0x060078C2 RID: 30914 RVA: 0x0004AAF5 File Offset: 0x00048CF5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(TabPage tabPage_3)
		{
			this.tabPage_1 = tabPage_3;
		}

		// Token: 0x060078C3 RID: 30915 RVA: 0x0004AAFE File Offset: 0x00048CFE
		[CompilerGenerated]
		internal Class112 vmethod_30()
		{
			return this.class112_1;
		}

		// Token: 0x060078C4 RID: 30916 RVA: 0x0041BE90 File Offset: 0x0041A090
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class112 class112_2)
		{
			EventHandler value = new EventHandler(this.method_10);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_1 = class112_2;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060078C5 RID: 30917 RVA: 0x0004AB06 File Offset: 0x00048D06
		[CompilerGenerated]
		internal TabPage vmethod_32()
		{
			return this.tabPage_2;
		}

		// Token: 0x060078C6 RID: 30918 RVA: 0x0004AB0E File Offset: 0x00048D0E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(TabPage tabPage_3)
		{
			this.tabPage_2 = tabPage_3;
		}

		// Token: 0x060078C7 RID: 30919 RVA: 0x0004AB17 File Offset: 0x00048D17
		[CompilerGenerated]
		internal Control10 vmethod_34()
		{
			return this.control10_0;
		}

		// Token: 0x060078C8 RID: 30920 RVA: 0x0041BED4 File Offset: 0x0041A0D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Control10 control10_1)
		{
			EventHandler value = new EventHandler(this.method_12);
			Control10 control = this.control10_0;
			if (control != null)
			{
				control.TextChanged -= value;
			}
			this.control10_0 = control10_1;
			control = this.control10_0;
			if (control != null)
			{
				control.TextChanged += value;
			}
		}

		// Token: 0x060078C9 RID: 30921 RVA: 0x0004AB1F File Offset: 0x00048D1F
		[CompilerGenerated]
		internal Class116 vmethod_36()
		{
			return this.class116_5;
		}

		// Token: 0x060078CA RID: 30922 RVA: 0x0004AB27 File Offset: 0x00048D27
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class116 class116_7)
		{
			this.class116_5 = class116_7;
		}

		// Token: 0x060078CB RID: 30923 RVA: 0x0004AB30 File Offset: 0x00048D30
		[CompilerGenerated]
		internal Control9 vmethod_38()
		{
			return this.control9_2;
		}

		// Token: 0x060078CC RID: 30924 RVA: 0x0041BF18 File Offset: 0x0041A118
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_11);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_3;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060078CD RID: 30925 RVA: 0x0004AB38 File Offset: 0x00048D38
		[CompilerGenerated]
		internal Class2451 vmethod_40()
		{
			return this.class2451_3;
		}

		// Token: 0x060078CE RID: 30926 RVA: 0x0004AB40 File Offset: 0x00048D40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Class2451 class2451_4)
		{
			this.class2451_3 = class2451_4;
		}

		// Token: 0x060078CF RID: 30927 RVA: 0x0004AB49 File Offset: 0x00048D49
		[CompilerGenerated]
		internal Class116 vmethod_42()
		{
			return this.class116_6;
		}

		// Token: 0x060078D0 RID: 30928 RVA: 0x0004AB51 File Offset: 0x00048D51
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Class116 class116_7)
		{
			this.class116_6 = class116_7;
		}

		// Token: 0x060078D1 RID: 30929 RVA: 0x0004AB5A File Offset: 0x00048D5A
		[CompilerGenerated]
		internal Control8 vmethod_44()
		{
			return this.control8_1;
		}

		// Token: 0x060078D2 RID: 30930 RVA: 0x0004AB62 File Offset: 0x00048D62
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Control8 control8_2)
		{
			this.control8_1 = control8_2;
		}

		// Token: 0x060078D3 RID: 30931 RVA: 0x0004AB6B File Offset: 0x00048D6B
		private void EditCondition_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_33().method_3();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060078D4 RID: 30932 RVA: 0x0041BF5C File Offset: 0x0041A15C
		private void EditCondition_Load(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.eventCondition_0))
			{
				base.Close();
			}
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_0().Text = this.eventCondition_0.string_2;
			this.vmethod_8().Visible = true;
			this.vmethod_6().Visible = this.vmethod_8().Visible;
			switch (this.eventCondition_0.eventConditionType_0)
			{
			case EventCondition.EventConditionType.SidePosture:
				this.vmethod_16().SelectedIndex = 0;
				this.vmethod_12().Items.Clear();
				this.vmethod_12().DisplayMember = "Content";
				this.vmethod_26().Checked = ((Class324)this.eventCondition_0).bool_11;
				foreach (Side side in Client.smethod_46().method_44())
				{
					ComboBoxItem comboBoxItem = new ComboBoxItem();
					comboBoxItem.Content = side.method_51();
					comboBoxItem.Tag = side.string_0;
					this.vmethod_12().Items.Add(comboBoxItem);
				}
				try
				{
					foreach (object obj in this.vmethod_12().Items)
					{
						ComboBoxItem comboBoxItem2 = (ComboBoxItem)obj;
						if (Operators.CompareString(Conversions.ToString(comboBoxItem2.Tag), ((Class324)this.eventCondition_0).string_3, false) == 0)
						{
							this.vmethod_12().SelectedItem = comboBoxItem2;
							break;
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
				this.vmethod_22().Items.Clear();
				this.vmethod_22().DisplayMember = "Content";
				foreach (Side side2 in Client.smethod_46().method_44())
				{
					ComboBoxItem comboBoxItem3 = new ComboBoxItem();
					comboBoxItem3.Content = side2.method_51();
					comboBoxItem3.Tag = side2.string_0;
					this.vmethod_22().Items.Add(comboBoxItem3);
				}
				try
				{
					foreach (object obj2 in this.vmethod_22().Items)
					{
						ComboBoxItem comboBoxItem4 = (ComboBoxItem)obj2;
						if (Operators.CompareString(Conversions.ToString(comboBoxItem4.Tag), ((Class324)this.eventCondition_0).string_4, false) == 0)
						{
							this.vmethod_22().SelectedItem = comboBoxItem4;
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
				this.vmethod_18().SelectedIndex = (int)((Class324)this.eventCondition_0).postureStance_0;
				break;
			case EventCondition.EventConditionType.ScenHasStarted:
				this.vmethod_16().SelectedIndex = 1;
				this.vmethod_30().Checked = ((Class323)this.eventCondition_0).bool_11;
				break;
			case EventCondition.EventConditionType.LuaScript:
				this.vmethod_16().SelectedIndex = 2;
				this.vmethod_34().Value = (int)Math.Round((double)this.vmethod_44().method_16().Size);
				this.vmethod_44().Text = ((Class322)this.eventCondition_0).string_3;
				this.vmethod_40().Items.AddRange(Enumerable.ToArray<string>(Enumerable.OrderBy<string, string>(LuaSandBox.LuaMethods, (EditCondition._Closure$__.$I99-0 == null) ? (EditCondition._Closure$__.$I99-0 = new Func<string, string>(EditCondition._Closure$__.$I.method_0)) : EditCondition._Closure$__.$I99-0)));
				this.vmethod_40().SelectedIndex = 0;
				break;
			}
			this.vmethod_16().method_0();
		}

		// Token: 0x060078D5 RID: 30933 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x0041C2F8 File Offset: 0x0041A4F8
		private void method_4(object sender, EventArgs e)
		{
			EventCondition.EventConditionType eventConditionType_ = this.eventCondition_0.eventConditionType_0;
			if (eventConditionType_ == EventCondition.EventConditionType.LuaScript)
			{
				((Class322)this.eventCondition_0).string_3 = this.vmethod_44().Text;
			}
			EditCondition.Enum205 @enum = this.enum205_0;
			if (@enum != EditCondition.Enum205.const_0)
			{
				if (@enum != EditCondition.Enum205.const_1)
				{
				}
			}
			else
			{
				Client.smethod_46().vmethod_6().Add(this.eventCondition_0.string_0, this.eventCondition_0);
			}
			base.Close();
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x0004AB8B File Offset: 0x00048D8B
		private void method_5(object sender, EventArgs e)
		{
			((Class324)this.eventCondition_0).string_3 = Conversions.ToString(((ComboBoxItem)this.vmethod_12().SelectedItem).Tag);
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x0004ABB7 File Offset: 0x00048DB7
		private void method_6(object sender, EventArgs e)
		{
			((Class324)this.eventCondition_0).string_4 = Conversions.ToString(((ComboBoxItem)this.vmethod_22().SelectedItem).Tag);
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x0004ABE3 File Offset: 0x00048DE3
		private void method_7(object sender, EventArgs e)
		{
			((Class324)this.eventCondition_0).postureStance_0 = (Misc.PostureStance)this.vmethod_18().SelectedIndex;
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x0004AC01 File Offset: 0x00048E01
		private void method_8(object object_0)
		{
			this.eventCondition_0.string_2 = this.vmethod_0().Text;
		}

		// Token: 0x060078DB RID: 30939 RVA: 0x003B6260 File Offset: 0x003B4460
		private void EditCondition_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060078DC RID: 30940 RVA: 0x0004AC19 File Offset: 0x00048E19
		private void method_9(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventCondition_0) && this.eventCondition_0.eventConditionType_0 == EventCondition.EventConditionType.SidePosture)
			{
				((Class324)this.eventCondition_0).bool_11 = this.vmethod_26().Checked;
			}
		}

		// Token: 0x060078DD RID: 30941 RVA: 0x0004AC50 File Offset: 0x00048E50
		private void method_10(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventCondition_0) && this.eventCondition_0.eventConditionType_0 == EventCondition.EventConditionType.ScenHasStarted)
			{
				((Class323)this.eventCondition_0).bool_11 = this.vmethod_30().Checked;
			}
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x0004AC88 File Offset: 0x00048E88
		private void method_11(object sender, EventArgs e)
		{
			this.vmethod_44().Text = this.vmethod_44().Text.Insert(this.vmethod_44().method_8(), Conversions.ToString(this.vmethod_40().SelectedItem));
		}

		// Token: 0x060078DF RID: 30943 RVA: 0x0041C368 File Offset: 0x0041A568
		private void method_12(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_34().Value))
			{
				this.vmethod_44().method_17(new Font(this.vmethod_44().method_16().FontFamily, (float)this.vmethod_34().Value));
			}
		}

		// Token: 0x04004385 RID: 17285
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private Control8 control8_0;

		// Token: 0x04004386 RID: 17286
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_0;

		// Token: 0x04004387 RID: 17287
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_1;

		// Token: 0x04004388 RID: 17288
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04004389 RID: 17289
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_1;

		// Token: 0x0400438A RID: 17290
		[AccessedThroughProperty("TabPage1")]
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x0400438B RID: 17291
		[AccessedThroughProperty("CB_ObserverSides")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x0400438C RID: 17292
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_2;

		// Token: 0x0400438D RID: 17293
		[CompilerGenerated]
		[AccessedThroughProperty("TC_ConditionOptions")]
		private Control12 control12_0;

		// Token: 0x0400438E RID: 17294
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Postures")]
		private Class2451 class2451_1;

		// Token: 0x0400438F RID: 17295
		[AccessedThroughProperty("Label7")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x04004390 RID: 17296
		[CompilerGenerated]
		[AccessedThroughProperty("CB_TargetSides")]
		private Class2451 class2451_2;

		// Token: 0x04004391 RID: 17297
		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Class116 class116_4;

		// Token: 0x04004392 RID: 17298
		[CompilerGenerated]
		[AccessedThroughProperty("CB_SidePosture_ModifierNOT")]
		private Class112 class112_0;

		// Token: 0x04004393 RID: 17299
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage2")]
		private TabPage tabPage_1;

		// Token: 0x04004394 RID: 17300
		[AccessedThroughProperty("CB_ScenHasStarted_ModifierNOT")]
		[CompilerGenerated]
		private Class112 class112_1;

		// Token: 0x04004395 RID: 17301
		[AccessedThroughProperty("TabPage3")]
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x04004396 RID: 17302
		[CompilerGenerated]
		[AccessedThroughProperty("NUD_LuaScript")]
		private Control10 control10_0;

		// Token: 0x04004397 RID: 17303
		[AccessedThroughProperty("Label13")]
		[CompilerGenerated]
		private Class116 class116_5;

		// Token: 0x04004398 RID: 17304
		[CompilerGenerated]
		[AccessedThroughProperty("Button_AddLuaScript")]
		private Control9 control9_2;

		// Token: 0x04004399 RID: 17305
		[CompilerGenerated]
		[AccessedThroughProperty("CB_LuaTemplate")]
		private Class2451 class2451_3;

		// Token: 0x0400439A RID: 17306
		[CompilerGenerated]
		[AccessedThroughProperty("Label12")]
		private Class116 class116_6;

		// Token: 0x0400439B RID: 17307
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox2")]
		private Control8 control8_1;

		// Token: 0x0400439C RID: 17308
		public EventCondition eventCondition_0;

		// Token: 0x0400439D RID: 17309
		public EditCondition.Enum205 enum205_0;

		// Token: 0x02000EB1 RID: 3761
		internal enum Enum205 : byte
		{
			// Token: 0x0400439F RID: 17311
			const_0,
			// Token: 0x040043A0 RID: 17312
			const_1
		}
	}
}
