using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns5;
using ns7;
using ns9;

namespace ns4
{
	// Token: 0x02000E69 RID: 3689
	[DesignerGenerated]
	internal sealed partial class CampaignEnd : DarkSecondaryFormBase
	{
		// Token: 0x060070C6 RID: 28870 RVA: 0x003CBBB0 File Offset: 0x003C9DB0
		public CampaignEnd()
		{
			base.Shown += this.CampaignEnd_Shown;
			base.KeyDown += this.CampaignEnd_KeyDown;
			base.Load += this.CampaignEnd_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x003CBC40 File Offset: 0x003C9E40
		private void InitializeComponent_1()
		{
			this.vmethod_1(new WebBrowser());
			this.vmethod_3(new Class116());
			base.SuspendLayout();
			this.vmethod_0().AllowNavigation = false;
			this.vmethod_0().AllowWebBrowserDrop = false;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().IsWebBrowserContextMenuEnabled = false;
			this.vmethod_0().Location = new Point(2, 2);
			this.vmethod_0().MinimumSize = new Size(20, 20);
			this.vmethod_0().Name = "WebBrowser1";
			this.vmethod_0().Size = new Size(1080, 606);
			this.vmethod_0().TabIndex = 18;
			this.vmethod_2().Anchor = AnchorStyles.Bottom;
			this.vmethod_2().method_2(true);
			this.vmethod_2().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Italic, GraphicsUnit.Point, 161);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(479, 614);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new Size(129, 13);
			this.vmethod_2().TabIndex = 19;
			this.vmethod_2().Text = "Press any key to continue";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1085, 653);
			base.ControlBox = false;
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CampaignEnd";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "CampaignEnd";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x00046DD2 File Offset: 0x00044FD2
		[CompilerGenerated]
		internal WebBrowser vmethod_0()
		{
			return this.webBrowser_0;
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x003CBE4C File Offset: 0x003CA04C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(WebBrowser webBrowser_1)
		{
			PreviewKeyDownEventHandler value = new PreviewKeyDownEventHandler(this.method_5);
			WebBrowser webBrowser = this.webBrowser_0;
			if (webBrowser != null)
			{
				webBrowser.PreviewKeyDown -= value;
			}
			this.webBrowser_0 = webBrowser_1;
			webBrowser = this.webBrowser_0;
			if (webBrowser != null)
			{
				webBrowser.PreviewKeyDown += value;
			}
		}

		// Token: 0x060070CB RID: 28875 RVA: 0x00046DDA File Offset: 0x00044FDA
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x060070CC RID: 28876 RVA: 0x00046DE2 File Offset: 0x00044FE2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x060070CD RID: 28877 RVA: 0x003CBE90 File Offset: 0x003CA090
		private void CampaignEnd_Shown(object sender, EventArgs e)
		{
			if (!this.method_4(this.vmethod_0(), this.class264_0.string_3, this.class264_0.string_4))
			{
				Class2558.smethod_11(this.vmethod_0(), this.class264_0.string_3);
			}
			this.method_3();
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x00046DEB File Offset: 0x00044FEB
		private void method_3()
		{
			base.TopMost = true;
			base.FormBorderStyle = FormBorderStyle.None;
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x003CBEE0 File Offset: 0x003CA0E0
		private bool method_4(WebBrowser webBrowser_1, string string_0, string string_1)
		{
			bool result;
			if (string_0.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_0, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_0, "[/LOADDOC]", CompareMethod.Binary);
				string path = string_0.Substring(num, string_0.Length - num - (string_0.Length - num2 + 1));
				webBrowser_1.Navigate(Path.Combine(string_1, path));
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x00046E02 File Offset: 0x00045002
		private void CampaignEnd_KeyDown(object sender, KeyEventArgs e)
		{
			this.method_6();
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x00046E02 File Offset: 0x00045002
		private void method_5(object sender, PreviewKeyDownEventArgs e)
		{
			this.method_6();
		}

		// Token: 0x060070D2 RID: 28882 RVA: 0x003CBF50 File Offset: 0x003CA150
		private void method_6()
		{
			try
			{
				foreach (object obj in Class2413.smethod_1().OpenForms)
				{
					Form form = (Form)obj;
					if (form != this && form != Class2413.smethod_2().mainForm_0 && form.Visible)
					{
						form.Hide();
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
			StartGameMenuWindow.smethod_1();
			base.Close();
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x00044489 File Offset: 0x00042689
		private void CampaignEnd_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04003FAE RID: 16302
		[CompilerGenerated]
		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser webBrowser_0;

		// Token: 0x04003FAF RID: 16303
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04003FB0 RID: 16304
		public Class264 class264_0;
	}
}
