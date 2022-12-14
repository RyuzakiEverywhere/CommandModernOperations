using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000E75 RID: 3701
	[DesignerGenerated]
	public sealed partial class EditSpecialAction : DarkSecondaryFormBase
	{
		// Token: 0x06007182 RID: 29058 RVA: 0x003D09A4 File Offset: 0x003CEBA4
		public EditSpecialAction()
		{
			base.FormClosing += this.EditSpecialAction_FormClosing;
			base.Load += this.EditSpecialAction_Load;
			base.KeyDown += this.EditSpecialAction_KeyDown;
			this.InitializeComponent_1();
		}

		// Token: 0x06007184 RID: 29060 RVA: 0x003D0A34 File Offset: 0x003CEC34
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control8());
			this.vmethod_3(new Class116());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Control9());
			this.vmethod_9(new Control9());
			this.vmethod_11(new Control8());
			this.vmethod_13(new Class116());
			this.vmethod_15(new Control10());
			this.vmethod_17(new Class116());
			this.vmethod_19(new Control9());
			this.vmethod_21(new Class2451());
			this.vmethod_23(new Class116());
			this.vmethod_25(new Control8());
			base.SuspendLayout();
			this.vmethod_0().method_14(null);
			this.vmethod_0().method_15(AutoCompleteMode.None);
			this.vmethod_0().method_13(AutoCompleteSource.None);
			this.vmethod_0().BackColor = Color.Transparent;
			this.vmethod_0().method_17(new Font("Segoe UI", 10f));
			this.vmethod_0().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_0().method_12(null);
			this.vmethod_0().method_18(null);
			this.vmethod_0().Location = new Point(90, 12);
			this.vmethod_0().method_2(32767);
			this.vmethod_0().method_7(false);
			this.vmethod_0().Name = "TB_Name";
			this.vmethod_0().method_3(false);
			this.vmethod_0().method_19(ScrollBars.None);
			this.vmethod_0().method_9(0);
			this.vmethod_0().Size = new Size(632, 20);
			this.vmethod_0().TabIndex = 6;
			this.vmethod_0().method_1(HorizontalAlignment.Left);
			this.vmethod_0().method_5(false);
			this.vmethod_0().method_10("");
			this.vmethod_2().method_2(true);
			this.vmethod_2().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(4, 16);
			this.vmethod_2().Name = "Label2";
			this.vmethod_2().Size = new Size(41, 13);
			this.vmethod_2().TabIndex = 5;
			this.vmethod_2().Text = "Name:";
			this.vmethod_4().method_2(true);
			this.vmethod_4().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(4, 48);
			this.vmethod_4().Name = "Label3";
			this.vmethod_4().Size = new Size(69, 13);
			this.vmethod_4().TabIndex = 21;
			this.vmethod_4().Text = "Description:";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font("Segoe UI", 10f);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(647, 614);
			this.vmethod_6().Name = "Button2";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(75, 23);
			this.vmethod_6().TabIndex = 24;
			this.vmethod_6().Text = "Cancel";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DialogResult = DialogResult.None;
			this.vmethod_8().Font = new Font("Segoe UI", 10f);
			this.vmethod_8().ForeColor = SystemColors.Control;
			this.vmethod_8().Location = new Point(4, 614);
			this.vmethod_8().Name = "Button1";
			this.vmethod_8().method_1(0);
			this.vmethod_8().Size = new Size(75, 23);
			this.vmethod_8().TabIndex = 23;
			this.vmethod_8().Text = "OK";
			this.vmethod_10().method_14(null);
			this.vmethod_10().method_15(AutoCompleteMode.None);
			this.vmethod_10().method_13(AutoCompleteSource.None);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().method_17(new Font("Segoe UI", 10f));
			this.vmethod_10().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_10().method_12(null);
			this.vmethod_10().method_18(null);
			this.vmethod_10().Location = new Point(7, 64);
			this.vmethod_10().method_2(32767);
			this.vmethod_10().method_7(true);
			this.vmethod_10().Name = "TB_Description";
			this.vmethod_10().method_3(false);
			this.vmethod_10().method_19(ScrollBars.None);
			this.vmethod_10().method_9(0);
			this.vmethod_10().Size = new Size(715, 96);
			this.vmethod_10().TabIndex = 25;
			this.vmethod_10().method_1(HorizontalAlignment.Left);
			this.vmethod_10().method_5(false);
			this.vmethod_10().method_10("");
			this.vmethod_12().method_2(true);
			this.vmethod_12().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(4, 174);
			this.vmethod_12().Name = "Label1";
			this.vmethod_12().Size = new Size(61, 13);
			this.vmethod_12().TabIndex = 21;
			this.vmethod_12().Text = "Lua Script:";
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().Font = new Font("Segoe UI", 10f);
			this.vmethod_14().Location = new Point(658, 192);
			this.vmethod_14().method_1(100);
			this.vmethod_14().method_3(0);
			this.vmethod_14().Name = "NUD_LuaScript";
			this.vmethod_14().Size = new Size(64, 26);
			this.vmethod_14().TabIndex = 31;
			this.vmethod_14().Value = 0;
			this.vmethod_16().method_2(true);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Location = new Point(605, 197);
			this.vmethod_16().Name = "Label13";
			this.vmethod_16().Size = new Size(54, 15);
			this.vmethod_16().TabIndex = 30;
			this.vmethod_16().Text = "Text Size:";
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().DialogResult = DialogResult.None;
			this.vmethod_18().Font = new Font("Segoe UI", 10f);
			this.vmethod_18().ForeColor = SystemColors.Control;
			this.vmethod_18().Location = new Point(529, 193);
			this.vmethod_18().Name = "Button_AddLuaScript";
			this.vmethod_18().method_1(0);
			this.vmethod_18().Size = new Size(75, 24);
			this.vmethod_18().TabIndex = 29;
			this.vmethod_18().Text = "ADD";
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_20().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_20().Font = new Font("Segoe UI", 7f);
			this.vmethod_20().FormattingEnabled = true;
			this.vmethod_20().Location = new Point(124, 193);
			this.vmethod_20().Name = "CB_LuaTemplate";
			this.vmethod_20().Size = new Size(400, 21);
			this.vmethod_20().TabIndex = 28;
			this.vmethod_22().method_2(true);
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().Location = new Point(4, 197);
			this.vmethod_22().Name = "Label12";
			this.vmethod_22().Size = new Size(114, 15);
			this.vmethod_22().TabIndex = 27;
			this.vmethod_22().Text = "Add script template:";
			this.vmethod_24().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_24().method_14(null);
			this.vmethod_24().method_15(AutoCompleteMode.None);
			this.vmethod_24().method_13(AutoCompleteSource.None);
			this.vmethod_24().BackColor = Color.Transparent;
			this.vmethod_24().method_17(new Font("Segoe UI", 10f));
			this.vmethod_24().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_24().method_12(null);
			this.vmethod_24().method_18(null);
			this.vmethod_24().Location = new Point(4, 221);
			this.vmethod_24().method_2(999999999);
			this.vmethod_24().method_7(true);
			this.vmethod_24().Name = "TB_Script";
			this.vmethod_24().method_3(false);
			this.vmethod_24().method_19(ScrollBars.None);
			this.vmethod_24().method_9(0);
			this.vmethod_24().Size = new Size(718, 387);
			this.vmethod_24().TabIndex = 26;
			this.vmethod_24().method_1(HorizontalAlignment.Left);
			this.vmethod_24().method_5(false);
			this.vmethod_24().method_10("");
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(726, 639);
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditSpecialAction";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Edit special action";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06007185 RID: 29061 RVA: 0x00047394 File Offset: 0x00045594
		[CompilerGenerated]
		internal Control8 vmethod_0()
		{
			return this.control8_0;
		}

		// Token: 0x06007186 RID: 29062 RVA: 0x003D1618 File Offset: 0x003CF818
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control8 control8_3)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_5);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.method_22(delegate85_);
			}
			this.control8_0 = control8_3;
			control = this.control8_0;
			if (control != null)
			{
				control.method_21(delegate85_);
			}
		}

		// Token: 0x06007187 RID: 29063 RVA: 0x0004739C File Offset: 0x0004559C
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x06007188 RID: 29064 RVA: 0x000473A4 File Offset: 0x000455A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_5)
		{
			this.class116_0 = class116_5;
		}

		// Token: 0x06007189 RID: 29065 RVA: 0x000473AD File Offset: 0x000455AD
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x0600718A RID: 29066 RVA: 0x000473B5 File Offset: 0x000455B5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_5)
		{
			this.class116_1 = class116_5;
		}

		// Token: 0x0600718B RID: 29067 RVA: 0x000473BE File Offset: 0x000455BE
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_0;
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x003D165C File Offset: 0x003CF85C
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

		// Token: 0x0600718D RID: 29069 RVA: 0x000473C6 File Offset: 0x000455C6
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_1;
		}

		// Token: 0x0600718E RID: 29070 RVA: 0x003D16A0 File Offset: 0x003CF8A0
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

		// Token: 0x0600718F RID: 29071 RVA: 0x000473CE File Offset: 0x000455CE
		[CompilerGenerated]
		internal Control8 vmethod_10()
		{
			return this.control8_1;
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x000473D6 File Offset: 0x000455D6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control8 control8_3)
		{
			this.control8_1 = control8_3;
		}

		// Token: 0x06007191 RID: 29073 RVA: 0x000473DF File Offset: 0x000455DF
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_2;
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x000473E7 File Offset: 0x000455E7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_5)
		{
			this.class116_2 = class116_5;
		}

		// Token: 0x06007193 RID: 29075 RVA: 0x000473F0 File Offset: 0x000455F0
		[CompilerGenerated]
		internal Control10 vmethod_14()
		{
			return this.control10_0;
		}

		// Token: 0x06007194 RID: 29076 RVA: 0x003D16E4 File Offset: 0x003CF8E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control10 control10_1)
		{
			EventHandler value = new EventHandler(this.method_7);
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

		// Token: 0x06007195 RID: 29077 RVA: 0x000473F8 File Offset: 0x000455F8
		[CompilerGenerated]
		internal Class116 vmethod_16()
		{
			return this.class116_3;
		}

		// Token: 0x06007196 RID: 29078 RVA: 0x00047400 File Offset: 0x00045600
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class116 class116_5)
		{
			this.class116_3 = class116_5;
		}

		// Token: 0x06007197 RID: 29079 RVA: 0x00047409 File Offset: 0x00045609
		[CompilerGenerated]
		internal Control9 vmethod_18()
		{
			return this.control9_2;
		}

		// Token: 0x06007198 RID: 29080 RVA: 0x003D1728 File Offset: 0x003CF928
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x06007199 RID: 29081 RVA: 0x00047411 File Offset: 0x00045611
		[CompilerGenerated]
		internal Class2451 vmethod_20()
		{
			return this.class2451_0;
		}

		// Token: 0x0600719A RID: 29082 RVA: 0x00047419 File Offset: 0x00045619
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class2451 class2451_1)
		{
			this.class2451_0 = class2451_1;
		}

		// Token: 0x0600719B RID: 29083 RVA: 0x00047422 File Offset: 0x00045622
		[CompilerGenerated]
		internal Class116 vmethod_22()
		{
			return this.class116_4;
		}

		// Token: 0x0600719C RID: 29084 RVA: 0x0004742A File Offset: 0x0004562A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class116 class116_5)
		{
			this.class116_4 = class116_5;
		}

		// Token: 0x0600719D RID: 29085 RVA: 0x00047433 File Offset: 0x00045633
		[CompilerGenerated]
		internal Control8 vmethod_24()
		{
			return this.control8_2;
		}

		// Token: 0x0600719E RID: 29086 RVA: 0x0004743B File Offset: 0x0004563B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Control8 control8_3)
		{
			this.control8_2 = control8_3;
		}

		// Token: 0x0600719F RID: 29087 RVA: 0x00047444 File Offset: 0x00045644
		private void EditSpecialAction_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_35().method_3();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060071A0 RID: 29088 RVA: 0x003D176C File Offset: 0x003CF96C
		private void EditSpecialAction_Load(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.specialAction_0))
			{
				base.Close();
			}
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_0().Text = this.specialAction_0.Name;
			this.vmethod_10().Text = this.specialAction_0.string_2;
			this.vmethod_8().Visible = true;
			this.vmethod_6().Visible = this.vmethod_8().Visible;
			if (!string.IsNullOrEmpty(this.specialAction_0.string_3))
			{
				this.vmethod_24().Text = this.specialAction_0.string_3;
			}
			this.vmethod_14().Value = (int)Math.Round((double)this.vmethod_24().method_16().Size);
			this.vmethod_20().Items.AddRange(Enumerable.ToArray<string>(Enumerable.OrderBy<string, string>(LuaSandBox.LuaMethods, (EditSpecialAction._Closure$__.$I59-0 == null) ? (EditSpecialAction._Closure$__.$I59-0 = new Func<string, string>(EditSpecialAction._Closure$__.$I.method_0)) : EditSpecialAction._Closure$__.$I59-0)));
			this.vmethod_20().SelectedIndex = 0;
		}

		// Token: 0x060071A1 RID: 29089 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060071A2 RID: 29090 RVA: 0x003D1888 File Offset: 0x003CFA88
		private void method_4(object sender, EventArgs e)
		{
			this.specialAction_0.Name = this.vmethod_0().Text;
			this.specialAction_0.string_3 = this.vmethod_24().Text;
			this.specialAction_0.string_2 = this.vmethod_10().Text;
			EditSpecialAction.Enum203 @enum = this.enum203_0;
			if (@enum != EditSpecialAction.Enum203.const_0)
			{
				if (@enum != EditSpecialAction.Enum203.const_1)
				{
				}
			}
			else
			{
				Client.smethod_50().dictionary_2.Add(this.specialAction_0.string_0, this.specialAction_0);
			}
			base.Close();
		}

		// Token: 0x060071A3 RID: 29091 RVA: 0x00047464 File Offset: 0x00045664
		private void method_5(object object_0)
		{
			this.specialAction_0.Name = this.vmethod_0().Text;
		}

		// Token: 0x060071A4 RID: 29092 RVA: 0x003B6260 File Offset: 0x003B4460
		private void EditSpecialAction_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060071A5 RID: 29093 RVA: 0x0004747C File Offset: 0x0004567C
		private void method_6(object sender, EventArgs e)
		{
			this.vmethod_24().Text = this.vmethod_24().Text.Insert(this.vmethod_24().method_8(), Conversions.ToString(this.vmethod_20().SelectedItem));
		}

		// Token: 0x060071A6 RID: 29094 RVA: 0x000474B4 File Offset: 0x000456B4
		private void method_7(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_14()))
			{
				this.vmethod_24().method_17(new Font(this.vmethod_24().method_16().FontFamily, (float)this.vmethod_14().Value));
			}
		}

		// Token: 0x0400400E RID: 16398
		[CompilerGenerated]
		[AccessedThroughProperty("TB_Name")]
		private Control8 control8_0;

		// Token: 0x0400400F RID: 16399
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04004010 RID: 16400
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x04004011 RID: 16401
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_0;

		// Token: 0x04004012 RID: 16402
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x04004013 RID: 16403
		[CompilerGenerated]
		[AccessedThroughProperty("TB_Description")]
		private Control8 control8_1;

		// Token: 0x04004014 RID: 16404
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_2;

		// Token: 0x04004015 RID: 16405
		[CompilerGenerated]
		[AccessedThroughProperty("NUD_LuaScript")]
		private Control10 control10_0;

		// Token: 0x04004016 RID: 16406
		[CompilerGenerated]
		[AccessedThroughProperty("Label13")]
		private Class116 class116_3;

		// Token: 0x04004017 RID: 16407
		[CompilerGenerated]
		[AccessedThroughProperty("Button_AddLuaScript")]
		private Control9 control9_2;

		// Token: 0x04004018 RID: 16408
		[AccessedThroughProperty("CB_LuaTemplate")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04004019 RID: 16409
		[CompilerGenerated]
		[AccessedThroughProperty("Label12")]
		private Class116 class116_4;

		// Token: 0x0400401A RID: 16410
		[CompilerGenerated]
		[AccessedThroughProperty("TB_Script")]
		private Control8 control8_2;

		// Token: 0x0400401B RID: 16411
		public SpecialAction specialAction_0;

		// Token: 0x0400401C RID: 16412
		public EditSpecialAction.Enum203 enum203_0;

		// Token: 0x02000E76 RID: 3702
		internal enum Enum203 : byte
		{
			// Token: 0x0400401E RID: 16414
			const_0,
			// Token: 0x0400401F RID: 16415
			const_1
		}
	}
}
