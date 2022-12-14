using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;
using ns9;

namespace Command
{
	// Token: 0x02000ED6 RID: 3798
	[DesignerGenerated]
	public sealed partial class ChooseSide : DarkSecondaryFormBase
	{
		// Token: 0x06008453 RID: 33875 RVA: 0x004709D4 File Offset: 0x0046EBD4
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class116());
			this.vmethod_3(new Class2451());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Control9());
			this.vmethod_9(new Control9());
			this.vmethod_11(new WebBrowser());
			base.SuspendLayout();
			this.vmethod_0().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(9, 15);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(98, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Available Sides:";
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_2().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_2().Font = new Font("Segoe UI", 7f);
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Location = new Point(117, 10);
			this.vmethod_2().Name = "ComboBox1";
			this.vmethod_2().Size = new Size(556, 21);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(9, 48);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new Size(152, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Briefing for selected side:";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font("Segoe UI", 10f);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(12, 433);
			this.vmethod_6().Name = "Button1";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(169, 27);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().Text = "Enter scenario";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DialogResult = DialogResult.None;
			this.vmethod_8().Font = new Font("Segoe UI", 10f);
			this.vmethod_8().ForeColor = SystemColors.Control;
			this.vmethod_8().Location = new Point(482, 433);
			this.vmethod_8().Name = "Button2";
			this.vmethod_8().method_1(0);
			this.vmethod_8().Size = new Size(191, 27);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_8().Text = "Cancel (return to main menu)";
			this.vmethod_10().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_10().Location = new Point(12, 64);
			this.vmethod_10().MinimumSize = new Size(20, 20);
			this.vmethod_10().Name = "WebBrowser1";
			this.vmethod_10().Size = new Size(661, 363);
			this.vmethod_10().TabIndex = 16;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(685, 472);
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ChooseSide";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Side selection and briefing";
			base.ResumeLayout(false);
		}

		// Token: 0x06008454 RID: 33876 RVA: 0x0005021F File Offset: 0x0004E41F
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x00050227 File Offset: 0x0004E427
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_2)
		{
			this.class116_0 = class116_2;
		}

		// Token: 0x06008456 RID: 33878 RVA: 0x00050230 File Offset: 0x0004E430
		[CompilerGenerated]
		internal Class2451 vmethod_2()
		{
			return this.class2451_0;
		}

		// Token: 0x06008457 RID: 33879 RVA: 0x00470E98 File Offset: 0x0046F098
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_1;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06008458 RID: 33880 RVA: 0x00050238 File Offset: 0x0004E438
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x06008459 RID: 33881 RVA: 0x00050240 File Offset: 0x0004E440
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_2)
		{
			this.class116_1 = class116_2;
		}

		// Token: 0x0600845A RID: 33882 RVA: 0x00050249 File Offset: 0x0004E449
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_0;
		}

		// Token: 0x0600845B RID: 33883 RVA: 0x00470EDC File Offset: 0x0046F0DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_2;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600845C RID: 33884 RVA: 0x00050251 File Offset: 0x0004E451
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_1;
		}

		// Token: 0x0600845D RID: 33885 RVA: 0x00470F20 File Offset: 0x0046F120
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_7);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_2;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x00050259 File Offset: 0x0004E459
		[CompilerGenerated]
		internal WebBrowser vmethod_10()
		{
			return this.webBrowser_0;
		}

		// Token: 0x0600845F RID: 33887 RVA: 0x00050261 File Offset: 0x0004E461
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(WebBrowser webBrowser_1)
		{
			this.webBrowser_0 = webBrowser_1;
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x00470F64 File Offset: 0x0046F164
		public ChooseSide()
		{
			base.FormClosing += this.ChooseSide_FormClosing;
			base.KeyDown += this.ChooseSide_KeyDown;
			base.FormClosed += this.ChooseSide_FormClosed;
			base.Shown += this.ChooseSide_Shown;
			base.Load += this.ChooseSide_Load;
			this.list_0 = new List<Side>();
			this.InitializeComponent_1();
			this.bool_1 = false;
			this.bool_2 = false;
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x00470FF0 File Offset: 0x0046F1F0
		private void method_3(object sender, EventArgs e)
		{
			try
			{
				this.method_4();
				StartGameMenuWindow.smethod_2();
			}
			catch (Exception ex)
			{
				StartGameMenuWindow.smethod_1();
				base.Close();
			}
		}

		// Token: 0x06008462 RID: 33890 RVA: 0x00471034 File Offset: 0x0046F234
		private void method_4()
		{
			foreach (Side side in this.scenario_0.method_44())
			{
				if (Operators.CompareString(side.method_51(), this.vmethod_2().SelectedItem.ToString(), false) == 0)
				{
					this.scenario_0.method_53(side);
					IL_4A:
					Client.smethod_47(this.scenario_0, false);
					if (Information.IsNothing(Client.smethod_50()))
					{
						Class2413.smethod_2().method_41().method_153(3000000);
					}
					else
					{
						Class2413.smethod_2().method_41().method_161(true, Client.smethod_50().method_26());
						Class2413.smethod_2().method_41().method_153((int)Math.Round(Client.smethod_50().double_0));
					}
					Client.smethod_0().method_4();
					Client.bool_1 = true;
					Class2413.smethod_2().method_41().method_234();
					Class2413.smethod_2().method_41().method_316();
					Class2413.smethod_2().method_41().Enabled = true;
					Class2413.smethod_2().method_41().method_219();
					Enumerable.FirstOrDefault<ActiveUnit>(Client.smethod_50().activeUnit_0);
					if (Client.smethod_46().LastSavedInScenEdit && Client.smethod_0().method_1() != Class279.Enum67.const_2)
					{
						Class2413.smethod_2().method_52().method_0(Client.smethod_46());
						Class2413.smethod_2().method_52().Show();
					}
					base.Close();
					return;
				}
			}
			goto IL_4A;
		}

		// Token: 0x06008463 RID: 33891 RVA: 0x00471194 File Offset: 0x0046F394
		private bool method_5(WebBrowser webBrowser_1, string string_1, string string_2)
		{
			bool result;
			if (string_1.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_1, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_1, "[/LOADDOC]", CompareMethod.Binary);
				string path;
				try
				{
					path = string_1.Substring(num, string_1.Length - num - (string_1.Length - num2 + 1));
				}
				catch (Exception ex)
				{
					return false;
				}
				if (File.Exists(Path.Combine(string_2, path)))
				{
					webBrowser_1.Navigate(Path.Combine(string_2, path));
					result = true;
				}
				else
				{
					string campaignID = this.scenario_0.CampaignID;
					Class264 @class = Class264.smethod_2(GameGeneral.string_4, campaignID);
					if (!Information.IsNothing(@class))
					{
						webBrowser_1.Navigate(Path.Combine(@class.string_4, path));
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06008464 RID: 33892 RVA: 0x0005026A File Offset: 0x0004E46A
		private void ChooseSide_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().Enabled = true;
		}

		// Token: 0x06008465 RID: 33893 RVA: 0x00471278 File Offset: 0x0046F478
		private void method_6(object sender, EventArgs e)
		{
			Side side = this.list_0[this.vmethod_2().SelectedIndex];
			if (!string.IsNullOrEmpty(side.string_3))
			{
				if (!this.method_5(this.vmethod_10(), side.string_3.ToString(), Path.GetDirectoryName(this.string_0)))
				{
					string value = side.string_3.ToString();
					if (string.IsNullOrEmpty(value))
					{
						Class2558.smethod_11(this.vmethod_10(), "No briefing currently provided for this side.");
						return;
					}
					Class2558.smethod_11(this.vmethod_10(), value);
					return;
				}
			}
			else
			{
				Class2558.smethod_11(this.vmethod_10(), "No briefing currently provided for this side.");
			}
		}

		// Token: 0x06008466 RID: 33894 RVA: 0x00047153 File Offset: 0x00045353
		private void method_7(object sender, EventArgs e)
		{
			StartGameMenuWindow.smethod_1();
			base.Close();
		}

		// Token: 0x06008467 RID: 33895 RVA: 0x0005027C File Offset: 0x0004E47C
		private void ChooseSide_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				Class2413.smethod_2().method_41().Enabled = true;
				base.Close();
			}
		}

		// Token: 0x06008468 RID: 33896 RVA: 0x000502A6 File Offset: 0x0004E4A6
		private void ChooseSide_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.scenario_0 = null;
			this.list_0 = null;
		}

		// Token: 0x06008469 RID: 33897 RVA: 0x00471310 File Offset: 0x0046F510
		private void ChooseSide_Shown(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			Side side = null;
			Class2413.smethod_2().method_41().Enabled = false;
			this.list_0 = Enumerable.ToList<Side>(Enumerable.Where<Side>(this.scenario_0.method_44(), (ChooseSide._Closure$__.$I39-0 == null) ? (ChooseSide._Closure$__.$I39-0 = new Func<Side, bool>(ChooseSide._Closure$__.$I.method_0)) : ChooseSide._Closure$__.$I39-0));
			if (this.list_0.Count == 0)
			{
				this.scenario_0.method_44()[0].method_54(false);
				this.list_0.Add(this.scenario_0.method_44()[0]);
				if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
				{
					DarkMessageBox.smethod_1("WARNING - The scenario has no player-selectable sides. Avoiding this by making side: " + this.scenario_0.method_44()[0].method_51() + " player-selectable. Please review the AI-only status of sides!", "", Enum11.const_0);
				}
			}
			if (this.list_0.Count == 1)
			{
				side = this.list_0[0];
				this.vmethod_2().Enabled = false;
				this.vmethod_2().Items.Add(this.list_0[0].method_51());
				this.vmethod_2().SelectedIndex = 0;
			}
			else
			{
				this.vmethod_2().Visible = true;
				try
				{
					foreach (Side side2 in this.list_0)
					{
						this.vmethod_2().Items.Add(side2.method_51());
					}
				}
				finally
				{
					List<Side>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (this.vmethod_2().Items.Count > 0)
				{
					this.vmethod_2().SelectedIndex = 0;
				}
				foreach (Side side3 in this.scenario_0.method_44())
				{
					if (Operators.CompareString(side3.method_51(), this.vmethod_2().SelectedItem.ToString(), false) == 0)
					{
						side = side3;
						break;
					}
				}
			}
			foreach (Side side4 in this.scenario_0.method_44())
			{
				if (Operators.CompareString(side4.method_51(), this.vmethod_2().SelectedItem.ToString(), false) == 0)
				{
					side = side4;
					IL_234:
					if (!Information.IsNothing(side))
					{
						if (!string.IsNullOrEmpty(side.string_3))
						{
							if (!this.method_5(this.vmethod_10(), side.string_3.ToString(), Path.GetDirectoryName(this.string_0)))
							{
								string value = side.string_3.ToString();
								if (string.IsNullOrEmpty(value))
								{
									Class2558.smethod_11(this.vmethod_10(), "No briefing currently provided for this side.");
									return;
								}
								Class2558.smethod_11(this.vmethod_10(), value);
								return;
							}
						}
						else
						{
							Class2558.smethod_11(this.vmethod_10(), "No briefing currently provided for this side.");
						}
					}
					return;
				}
			}
			goto IL_234;
		}

		// Token: 0x0600846A RID: 33898 RVA: 0x000502B6 File Offset: 0x0004E4B6
		private void ChooseSide_Load(object sender, EventArgs e)
		{
			this.vmethod_0().ForeColor = Color.Gainsboro;
		}

		// Token: 0x0400486A RID: 18538
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x0400486B RID: 18539
		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox1")]
		private Class2451 class2451_0;

		// Token: 0x0400486C RID: 18540
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x0400486D RID: 18541
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x0400486E RID: 18542
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x0400486F RID: 18543
		[AccessedThroughProperty("WebBrowser1")]
		[CompilerGenerated]
		private WebBrowser webBrowser_0;

		// Token: 0x04004870 RID: 18544
		public Scenario scenario_0;

		// Token: 0x04004871 RID: 18545
		public string string_0;

		// Token: 0x04004872 RID: 18546
		private List<Side> list_0;
	}
}
