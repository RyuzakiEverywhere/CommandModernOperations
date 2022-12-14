using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns5;
using ns7;

namespace ns4
{
	// Token: 0x02000E2E RID: 3630
	[DesignerGenerated]
	internal sealed partial class QuickBattle : DarkSecondaryFormBase
	{
		// Token: 0x06006CB1 RID: 27825 RVA: 0x0004468E File Offset: 0x0004288E
		public QuickBattle()
		{
			base.Shown += this.QuickBattle_Shown;
			this.string_0 = Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "QuickBattle");
			this.InitializeComponent_1();
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x003B9AD4 File Offset: 0x003B7CD4
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(QuickBattle));
			this.vmethod_1(new Control6());
			this.vmethod_3(new WebBrowser());
			this.vmethod_5(new Control9());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_0().Location = new Point(7, 5);
			this.vmethod_0().method_6(20);
			this.vmethod_0().Name = "TV_Scens";
			this.vmethod_0().Size = new Size(209, 479);
			this.vmethod_0().TabIndex = 6;
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().Location = new Point(222, 0);
			this.vmethod_2().MinimumSize = new Size(20, 20);
			this.vmethod_2().Name = "theBrowser";
			this.vmethod_2().Size = new Size(629, 529);
			this.vmethod_2().TabIndex = 16;
			this.vmethod_2().Visible = false;
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(66, 490);
			this.vmethod_4().Name = "Button_Start";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(79, 29);
			this.vmethod_4().TabIndex = 17;
			this.vmethod_4().Text = "START";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(850, 530);
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "QuickBattle";
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Quick Battle Generator";
			base.ResumeLayout(false);
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x000446CD File Offset: 0x000428CD
		[CompilerGenerated]
		internal Control6 vmethod_0()
		{
			return this.control6_0;
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x003B9D48 File Offset: 0x003B7F48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control6 control6_1)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_8);
			Control6 control = this.control6_0;
			if (control != null)
			{
				control.method_17(eventHandler_);
			}
			this.control6_0 = control6_1;
			control = this.control6_0;
			if (control != null)
			{
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x000446D5 File Offset: 0x000428D5
		[CompilerGenerated]
		internal WebBrowser vmethod_2()
		{
			return this.webBrowser_0;
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x000446DD File Offset: 0x000428DD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(WebBrowser webBrowser_1)
		{
			this.webBrowser_0 = webBrowser_1;
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x000446E6 File Offset: 0x000428E6
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_0;
		}

		// Token: 0x06006CB9 RID: 27833 RVA: 0x003B9D8C File Offset: 0x003B7F8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_1)
		{
			EventHandler value = new EventHandler(this.method_5);
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

		// Token: 0x06006CBA RID: 27834 RVA: 0x000446EE File Offset: 0x000428EE
		private void QuickBattle_Shown(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06006CBB RID: 27835 RVA: 0x003B9DD0 File Offset: 0x003B7FD0
		private void method_3()
		{
			this.vmethod_0().method_20().Clear();
			foreach (string text in Directory.GetDirectories(this.string_0))
			{
				if (this.method_4(text))
				{
					Class127 @class = new Class127(Path.GetFileName(text));
					this.vmethod_0().method_20().method_4(@class);
					@class.Tag = text;
				}
			}
			if (this.vmethod_0().method_20().Count > 0)
			{
				this.vmethod_0().method_51(this.vmethod_0().method_20()[0]);
			}
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x003B9E68 File Offset: 0x003B8068
		private bool method_4(string string_1)
		{
			checked
			{
				if (Enumerable.Count<string>(Directory.GetFiles(string_1)) > 0)
				{
					string[] files = Directory.GetFiles(string_1);
					for (int i = 0; i < files.Length; i++)
					{
						if (files[i].EndsWith(".html"))
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x003B9EB0 File Offset: 0x003B80B0
		private void method_5(object sender, EventArgs e)
		{
			try
			{
				Client.smethod_76();
				this.method_6();
				this.method_7();
				Class2413.smethod_2().method_41().method_161(true, Client.smethod_50().method_26());
				base.Close();
			}
			catch (Exception ex)
			{
				DarkMessageBox.smethod_2("Error: " + ex.Message, "Error", Enum11.const_0);
			}
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x003B9F2C File Offset: 0x003B812C
		private void method_6()
		{
			HtmlDocument document = this.vmethod_2().Document;
			try
			{
				foreach (object obj in document.All)
				{
					HtmlElement htmlElement = (HtmlElement)obj;
					if (!string.IsNullOrEmpty(htmlElement.Name))
					{
						string attribute = htmlElement.GetAttribute("value");
						string str;
						if (Versioned.IsNumeric(attribute))
						{
							str = attribute;
						}
						else
						{
							str = "'" + attribute + "'";
						}
						Client.smethod_46().method_10().RunScript(htmlElement.Name + " = " + str, false, null);
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

		// Token: 0x06006CBF RID: 27839 RVA: 0x003B9FEC File Offset: 0x003B81EC
		private void method_7()
		{
			string str = File.ReadAllText(Path.Combine(Conversions.ToString(this.vmethod_0().method_22()[0].Tag), "Script.lua"));
			Client.smethod_46().method_10().RunScript(str, false, null);
		}

		// Token: 0x06006CC0 RID: 27840 RVA: 0x003BA038 File Offset: 0x003B8238
		private void method_8(object sender, EventArgs e)
		{
			if (this.vmethod_0().method_22().Count > 0)
			{
				string path = Path.Combine(Conversions.ToString(this.vmethod_0().method_22()[0].Tag), "Form.html");
				Class2558.smethod_11(this.vmethod_2(), File.ReadAllText(path));
				this.vmethod_2().Visible = true;
			}
		}

		// Token: 0x04003E03 RID: 15875
		[CompilerGenerated]
		[AccessedThroughProperty("TV_Scens")]
		private Control6 control6_0;

		// Token: 0x04003E04 RID: 15876
		[AccessedThroughProperty("theBrowser")]
		[CompilerGenerated]
		private WebBrowser webBrowser_0;

		// Token: 0x04003E05 RID: 15877
		[AccessedThroughProperty("Button_Start")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04003E06 RID: 15878
		public string string_0;
	}
}
