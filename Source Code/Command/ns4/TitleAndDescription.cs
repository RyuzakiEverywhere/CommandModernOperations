using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using MSDN.Html.Editor;
using ns2;

namespace ns4
{
	// Token: 0x02000E6A RID: 3690
	[DesignerGenerated]
	internal sealed partial class TitleAndDescription : DarkSecondaryFormBase
	{
		// Token: 0x060070D4 RID: 28884 RVA: 0x00046E0A File Offset: 0x0004500A
		public TitleAndDescription()
		{
			base.Shown += this.TitleAndDescription_Shown;
			base.Load += this.TitleAndDescription_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x003CC014 File Offset: 0x003CA214
		private void InitializeComponent_1()
		{
			this.vmethod_1(new HtmlEditorControl());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Control8());
			this.vmethod_11(new Class116());
			this.vmethod_13(new Control9());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_0().BodyBackColor = Color.FromArgb(43, 43, 43);
			this.vmethod_0().BodyForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().BorderSize = 0;
			this.vmethod_0().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().InnerText = null;
			this.vmethod_0().Location = new Point(6, 67);
			this.vmethod_0().Name = "Editor1";
			this.vmethod_0().Size = new Size(869, 414);
			this.vmethod_0().TabIndex = 33;
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DialogResult = DialogResult.None;
			this.vmethod_2().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_2().ForeColor = SystemColors.Control;
			this.vmethod_2().Location = new Point(800, 487);
			this.vmethod_2().Name = "Button2";
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(75, 23);
			this.vmethod_2().TabIndex = 32;
			this.vmethod_2().Text = "Cancel";
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(6, 487);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(75, 23);
			this.vmethod_4().TabIndex = 31;
			this.vmethod_4().Text = "OK";
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(3, 51);
			this.vmethod_6().Name = "Label2";
			this.vmethod_6().Size = new Size(63, 13);
			this.vmethod_6().TabIndex = 30;
			this.vmethod_6().Text = "Description:";
			this.vmethod_8().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_8().method_14(null);
			this.vmethod_8().method_15(AutoCompleteMode.None);
			this.vmethod_8().method_13(AutoCompleteSource.None);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().method_17(new Font(Client.font_1.FontFamily, 8f));
			this.vmethod_8().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_8().method_12(null);
			this.vmethod_8().method_18(null);
			this.vmethod_8().Location = new Point(43, 12);
			this.vmethod_8().method_2(32767);
			this.vmethod_8().method_7(false);
			this.vmethod_8().Name = "TextBox1";
			this.vmethod_8().method_3(false);
			this.vmethod_8().method_9(0);
			this.vmethod_8().Size = new Size(832, 20);
			this.vmethod_8().TabIndex = 29;
			this.vmethod_8().method_1(HorizontalAlignment.Left);
			this.vmethod_8().method_5(false);
			this.vmethod_8().method_10("");
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Location = new Point(3, 15);
			this.vmethod_10().Name = "Label1";
			this.vmethod_10().Size = new Size(30, 13);
			this.vmethod_10().TabIndex = 28;
			this.vmethod_10().Text = "Title:";
			this.vmethod_12().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(745, 41);
			this.vmethod_12().Name = "Button_EditHTML";
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(130, 23);
			this.vmethod_12().TabIndex = 34;
			this.vmethod_12().Text = "Edit HTML source";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(878, 513);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "TitleAndDescription";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Title And Description";
			base.ResumeLayout(false);
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x00046E3C File Offset: 0x0004503C
		[CompilerGenerated]
		private HtmlEditorControl vmethod_0()
		{
			return this.htmlEditorControl_0;
		}

		// Token: 0x060070D8 RID: 28888 RVA: 0x00046E44 File Offset: 0x00045044
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_1(HtmlEditorControl htmlEditorControl_1)
		{
			this.htmlEditorControl_0 = htmlEditorControl_1;
		}

		// Token: 0x060070D9 RID: 28889 RVA: 0x00046E4D File Offset: 0x0004504D
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x060070DA RID: 28890 RVA: 0x003CC698 File Offset: 0x003CA898
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_4);
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

		// Token: 0x060070DB RID: 28891 RVA: 0x00046E55 File Offset: 0x00045055
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_1;
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x003CC6DC File Offset: 0x003CA8DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_3);
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

		// Token: 0x060070DD RID: 28893 RVA: 0x00046E5D File Offset: 0x0004505D
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_0;
		}

		// Token: 0x060070DE RID: 28894 RVA: 0x00046E65 File Offset: 0x00045065
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_2)
		{
			this.class116_0 = class116_2;
		}

		// Token: 0x060070DF RID: 28895 RVA: 0x00046E6E File Offset: 0x0004506E
		[CompilerGenerated]
		internal Control8 vmethod_8()
		{
			return this.control8_0;
		}

		// Token: 0x060070E0 RID: 28896 RVA: 0x00046E76 File Offset: 0x00045076
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control8 control8_1)
		{
			this.control8_0 = control8_1;
		}

		// Token: 0x060070E1 RID: 28897 RVA: 0x00046E7F File Offset: 0x0004507F
		[CompilerGenerated]
		internal Class116 vmethod_10()
		{
			return this.class116_1;
		}

		// Token: 0x060070E2 RID: 28898 RVA: 0x00046E87 File Offset: 0x00045087
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class116 class116_2)
		{
			this.class116_1 = class116_2;
		}

		// Token: 0x060070E3 RID: 28899 RVA: 0x00046E90 File Offset: 0x00045090
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_2;
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x003CC720 File Offset: 0x003CA920
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_5);
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

		// Token: 0x060070E5 RID: 28901 RVA: 0x00046E98 File Offset: 0x00045098
		private void method_3(object sender, EventArgs e)
		{
			this.string_0 = this.vmethod_8().Text;
			this.string_1 = this.vmethod_0().BodyHtml;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x060070E6 RID: 28902 RVA: 0x00046EC9 File Offset: 0x000450C9
		private void method_4(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x060070E7 RID: 28903 RVA: 0x00046ED8 File Offset: 0x000450D8
		private void TitleAndDescription_Shown(object sender, EventArgs e)
		{
			this.vmethod_8().Text = this.string_0;
			if (!string.IsNullOrEmpty(this.string_1))
			{
				this.vmethod_0().BodyHtml = this.string_1;
			}
		}

		// Token: 0x060070E8 RID: 28904 RVA: 0x00046F09 File Offset: 0x00045109
		private void method_5(object sender, EventArgs e)
		{
			this.vmethod_0().HtmlContentsEdit();
		}

		// Token: 0x060070E9 RID: 28905 RVA: 0x00044489 File Offset: 0x00042689
		private void TitleAndDescription_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04003FB2 RID: 16306
		[AccessedThroughProperty("Editor1")]
		[CompilerGenerated]
		private HtmlEditorControl htmlEditorControl_0;

		// Token: 0x04003FB3 RID: 16307
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04003FB4 RID: 16308
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_1;

		// Token: 0x04003FB5 RID: 16309
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04003FB6 RID: 16310
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private Control8 control8_0;

		// Token: 0x04003FB7 RID: 16311
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x04003FB8 RID: 16312
		[AccessedThroughProperty("Button_EditHTML")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x04003FB9 RID: 16313
		public string string_0;

		// Token: 0x04003FBA RID: 16314
		public string string_1;
	}
}
