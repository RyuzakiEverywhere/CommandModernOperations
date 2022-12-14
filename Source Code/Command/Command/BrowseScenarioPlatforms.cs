using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000ED4 RID: 3796
	[DesignerGenerated]
	public sealed partial class BrowseScenarioPlatforms : DarkSecondaryFormBase
	{
		// Token: 0x06008431 RID: 33841 RVA: 0x0046FE98 File Offset: 0x0046E098
		public BrowseScenarioPlatforms()
		{
			base.Load += this.BrowseScenarioPlatforms_Load;
			base.KeyDown += this.BrowseScenarioPlatforms_KeyDown;
			base.FormClosing += this.BrowseScenarioPlatforms_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x06008433 RID: 33843 RVA: 0x0046FF28 File Offset: 0x0046E128
		private void InitializeComponent_1()
		{
			this.vmethod_1(new ToolStripContainer());
			this.vmethod_11(new Control6());
			this.vmethod_3(new Class125());
			this.vmethod_5(new ToolStripLabel());
			this.vmethod_7(new ToolStripComboBox());
			this.vmethod_9(new ToolStripLabel());
			this.vmethod_13(new ToolStripContainer());
			this.vmethod_0().ContentPanel.SuspendLayout();
			this.vmethod_0().SuspendLayout();
			this.vmethod_2().SuspendLayout();
			this.vmethod_12().ContentPanel.SuspendLayout();
			this.vmethod_12().TopToolStripPanel.SuspendLayout();
			this.vmethod_12().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().ContentPanel.Controls.Add(this.vmethod_10());
			this.vmethod_0().ContentPanel.Size = new Size(604, 289);
			this.vmethod_0().Dock = DockStyle.Fill;
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "ToolStripContainer1";
			this.vmethod_0().Size = new Size(604, 289);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "ToolStripContainer1";
			this.vmethod_0().TopToolStripPanel.BackColor = Color.FromArgb(64, 64, 64);
			this.vmethod_10().Dock = DockStyle.Fill;
			this.vmethod_10().Location = new Point(0, 0);
			this.vmethod_10().method_6(20);
			this.vmethod_10().Name = "TreeView1";
			this.vmethod_10().Size = new Size(604, 289);
			this.vmethod_10().TabIndex = 0;
			this.vmethod_2().AutoSize = false;
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_4(),
				this.vmethod_6(),
				this.vmethod_8()
			});
			this.vmethod_2().Location = new Point(0, 0);
			this.vmethod_2().Name = "ToolStrip1";
			this.vmethod_2().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_2().Size = new Size(604, 27);
			this.vmethod_2().Stretch = true;
			this.vmethod_2().TabIndex = 0;
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Name = "ToolStripLabel1";
			this.vmethod_4().Size = new Size(32, 24);
			this.vmethod_4().Text = "Side:";
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Name = "TSCB_Side";
			this.vmethod_6().Size = new Size(200, 27);
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().Font = new Font("Segoe UI", 9f, FontStyle.Italic);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Name = "ToolStripLabel2";
			this.vmethod_8().Size = new Size(206, 24);
			this.vmethod_8().Text = "(double click platform to view DB info)";
			this.vmethod_12().ContentPanel.AutoScroll = true;
			this.vmethod_12().ContentPanel.Controls.Add(this.vmethod_0());
			this.vmethod_12().ContentPanel.Size = new Size(604, 289);
			this.vmethod_12().Dock = DockStyle.Fill;
			this.vmethod_12().Location = new Point(0, 0);
			this.vmethod_12().Name = "ToolStripContainer2";
			this.vmethod_12().Size = new Size(604, 316);
			this.vmethod_12().TabIndex = 1;
			this.vmethod_12().Text = "ToolStripContainer2";
			this.vmethod_12().TopToolStripPanel.Controls.Add(this.vmethod_2());
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(604, 316);
			base.Controls.Add(this.vmethod_12());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "BrowseScenarioPlatforms";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Browse Scenario Platforms";
			this.vmethod_0().ContentPanel.ResumeLayout(false);
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			this.vmethod_12().ContentPanel.ResumeLayout(false);
			this.vmethod_12().TopToolStripPanel.ResumeLayout(false);
			this.vmethod_12().ResumeLayout(false);
			this.vmethod_12().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06008434 RID: 33844 RVA: 0x00050113 File Offset: 0x0004E313
		[CompilerGenerated]
		internal ToolStripContainer vmethod_0()
		{
			return this.toolStripContainer_0;
		}

		// Token: 0x06008435 RID: 33845 RVA: 0x0005011B File Offset: 0x0004E31B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ToolStripContainer toolStripContainer_2)
		{
			this.toolStripContainer_0 = toolStripContainer_2;
		}

		// Token: 0x06008436 RID: 33846 RVA: 0x00050124 File Offset: 0x0004E324
		[CompilerGenerated]
		internal Class125 vmethod_2()
		{
			return this.class125_0;
		}

		// Token: 0x06008437 RID: 33847 RVA: 0x0005012C File Offset: 0x0004E32C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x06008438 RID: 33848 RVA: 0x00050135 File Offset: 0x0004E335
		[CompilerGenerated]
		internal ToolStripLabel vmethod_4()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x06008439 RID: 33849 RVA: 0x0005013D File Offset: 0x0004E33D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripLabel toolStripLabel_2)
		{
			this.toolStripLabel_0 = toolStripLabel_2;
		}

		// Token: 0x0600843A RID: 33850 RVA: 0x00050146 File Offset: 0x0004E346
		[CompilerGenerated]
		internal ToolStripComboBox vmethod_6()
		{
			return this.toolStripComboBox_0;
		}

		// Token: 0x0600843B RID: 33851 RVA: 0x0005014E File Offset: 0x0004E34E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripComboBox toolStripComboBox_1)
		{
			this.toolStripComboBox_0 = toolStripComboBox_1;
		}

		// Token: 0x0600843C RID: 33852 RVA: 0x00050157 File Offset: 0x0004E357
		[CompilerGenerated]
		internal ToolStripLabel vmethod_8()
		{
			return this.toolStripLabel_1;
		}

		// Token: 0x0600843D RID: 33853 RVA: 0x0005015F File Offset: 0x0004E35F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripLabel toolStripLabel_2)
		{
			this.toolStripLabel_1 = toolStripLabel_2;
		}

		// Token: 0x0600843E RID: 33854 RVA: 0x00050168 File Offset: 0x0004E368
		[CompilerGenerated]
		internal Control6 vmethod_10()
		{
			return this.control6_0;
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x004704E4 File Offset: 0x0046E6E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control6 control6_1)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_5);
			MouseEventHandler value2 = new MouseEventHandler(this.method_6);
			Control6 control = this.control6_0;
			if (control != null)
			{
				control.MouseDoubleClick -= value;
				control.MouseDoubleClick -= value2;
			}
			this.control6_0 = control6_1;
			control = this.control6_0;
			if (control != null)
			{
				control.MouseDoubleClick += value;
				control.MouseDoubleClick += value2;
			}
		}

		// Token: 0x06008440 RID: 33856 RVA: 0x00050170 File Offset: 0x0004E370
		[CompilerGenerated]
		internal ToolStripContainer vmethod_12()
		{
			return this.toolStripContainer_1;
		}

		// Token: 0x06008441 RID: 33857 RVA: 0x00050178 File Offset: 0x0004E378
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ToolStripContainer toolStripContainer_2)
		{
			this.toolStripContainer_1 = toolStripContainer_2;
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x00050181 File Offset: 0x0004E381
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox vmethod_14()
		{
			return this.comboBox_0;
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x00470544 File Offset: 0x0046E744
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_15(System.Windows.Forms.ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.method_4);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_1;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06008444 RID: 33860 RVA: 0x00470588 File Offset: 0x0046E788
		private void BrowseScenarioPlatforms_Load(object sender, EventArgs e)
		{
			if (Information.IsNothing(Client.smethod_50()))
			{
				base.Close();
				return;
			}
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.side_0 = Client.smethod_50();
			this.vmethod_15(this.vmethod_6().ComboBox);
			foreach (Side side in Client.smethod_46().method_44())
			{
				ComboBoxItem comboBoxItem = new ComboBoxItem();
				comboBoxItem.Content = side.method_51();
				comboBoxItem.Tag = side.string_0;
				this.vmethod_14().Items.Add(comboBoxItem);
			}
			this.vmethod_14().DisplayMember = "Content";
			this.vmethod_14().ValueMember = "Tag";
			this.vmethod_14().SelectedIndex = 0;
			this.method_3();
		}

		// Token: 0x06008445 RID: 33861 RVA: 0x00470658 File Offset: 0x0046E858
		private void method_3()
		{
			this.vmethod_10().method_20().Clear();
			IEnumerable<IGrouping<string, ActiveUnit>> enumerable = Enumerable.Select<IGrouping<string, ActiveUnit>, IGrouping<string, ActiveUnit>>(Enumerable.GroupBy<ActiveUnit, string>(Enumerable.Where<ActiveUnit>(Client.smethod_46().method_42(), new Func<ActiveUnit, bool>(this.method_7)), (BrowseScenarioPlatforms._Closure$__.$I38-1 == null) ? (BrowseScenarioPlatforms._Closure$__.$I38-1 = new Func<ActiveUnit, string>(BrowseScenarioPlatforms._Closure$__.$I.method_0)) : BrowseScenarioPlatforms._Closure$__.$I38-1), (BrowseScenarioPlatforms._Closure$__.$I38-2 == null) ? (BrowseScenarioPlatforms._Closure$__.$I38-2 = new Func<IGrouping<string, ActiveUnit>, IGrouping<string, ActiveUnit>>(BrowseScenarioPlatforms._Closure$__.$I.method_1)) : BrowseScenarioPlatforms._Closure$__.$I38-2);
			try
			{
				foreach (IGrouping<string, ActiveUnit> grouping in enumerable)
				{
					string text = Enumerable.ElementAtOrDefault<ActiveUnit>(grouping, 0).method_63();
					Class127 @class = new Class127(text);
					this.vmethod_10().method_20().method_4(@class);
					try
					{
						foreach (IGrouping<int, ActiveUnit> grouping2 in Enumerable.GroupBy<ActiveUnit, int>(grouping, (BrowseScenarioPlatforms._Closure$__.$I38-3 == null) ? (BrowseScenarioPlatforms._Closure$__.$I38-3 = new Func<ActiveUnit, int>(BrowseScenarioPlatforms._Closure$__.$I.method_2)) : BrowseScenarioPlatforms._Closure$__.$I38-3))
						{
							Class127 class2 = new Class127(Enumerable.ElementAtOrDefault<ActiveUnit>(grouping2, 0).string_2);
							class2.Tag = text + "_" + Conversions.ToString(Enumerable.ElementAtOrDefault<ActiveUnit>(grouping2, 0).DBID);
							@class.method_23().method_4(class2);
						}
					}
					finally
					{
						IEnumerator<IGrouping<int, ActiveUnit>> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<IGrouping<string, ActiveUnit>> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06008446 RID: 33862 RVA: 0x00050189 File Offset: 0x0004E389
		private void method_4(object sender, EventArgs e)
		{
			this.side_0 = Enumerable.ElementAtOrDefault<Side>(Enumerable.Where<Side>(Client.smethod_46().method_44(), new Func<Side, bool>(this.method_8)), 0);
			this.method_3();
		}

		// Token: 0x06008447 RID: 33863 RVA: 0x004707EC File Offset: 0x0046E9EC
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_10().method_22().Count != 0)
			{
				Class127 @class = this.vmethod_10().method_22()[0];
				if (!string.IsNullOrEmpty(Conversions.ToString(@class.Tag)))
				{
					string selectedObjectType = @class.Tag.ToString().Split(Conversions.ToCharArrayRankOne("_"))[0];
					int selectedObjectID = Conversions.ToInteger(@class.Tag.ToString().Split(Conversions.ToCharArrayRankOne("_"))[1]);
					Client.smethod_63(selectedObjectType, selectedObjectID, null);
				}
			}
		}

		// Token: 0x06008448 RID: 33864 RVA: 0x00470874 File Offset: 0x0046EA74
		private void BrowseScenarioPlatforms_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.End && e.KeyCode != Keys.Home && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06008449 RID: 33865 RVA: 0x00044820 File Offset: 0x00042A20
		private void BrowseScenarioPlatforms_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600844A RID: 33866 RVA: 0x0047091C File Offset: 0x0046EB1C
		private void method_6(object sender, MouseEventArgs e)
		{
			Class127 @class = this.vmethod_10().method_22()[0];
			if (!string.IsNullOrEmpty(Conversions.ToString(@class.Tag)))
			{
				string selectedObjectType = @class.Tag.ToString().Split(Conversions.ToCharArrayRankOne("_"))[0];
				int selectedObjectID = Conversions.ToInteger(@class.Tag.ToString().Split(Conversions.ToCharArrayRankOne("_"))[1]);
				Client.smethod_63(selectedObjectType, selectedObjectID, null);
			}
		}

		// Token: 0x0600844B RID: 33867 RVA: 0x000501B8 File Offset: 0x0004E3B8
		[CompilerGenerated]
		private bool method_7(ActiveUnit activeUnit_0)
		{
			return !Information.IsNothing(activeUnit_0) && activeUnit_0.vmethod_43() && activeUnit_0.vmethod_7(false) == this.side_0;
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x000501DB File Offset: 0x0004E3DB
		[CompilerGenerated]
		private bool method_8(Side side_1)
		{
			return Operators.CompareString(side_1.string_0, Conversions.ToString(((ComboBoxItem)this.vmethod_14().SelectedItem).Tag), false) == 0;
		}

		// Token: 0x0400485C RID: 18524
		[AccessedThroughProperty("ToolStripContainer1")]
		[CompilerGenerated]
		private ToolStripContainer toolStripContainer_0;

		// Token: 0x0400485D RID: 18525
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStrip1")]
		private Class125 class125_0;

		// Token: 0x0400485E RID: 18526
		[AccessedThroughProperty("ToolStripLabel1")]
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x0400485F RID: 18527
		[AccessedThroughProperty("TSCB_Side")]
		[CompilerGenerated]
		private ToolStripComboBox toolStripComboBox_0;

		// Token: 0x04004860 RID: 18528
		[AccessedThroughProperty("ToolStripLabel2")]
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_1;

		// Token: 0x04004861 RID: 18529
		[CompilerGenerated]
		[AccessedThroughProperty("TreeView1")]
		private Control6 control6_0;

		// Token: 0x04004862 RID: 18530
		[AccessedThroughProperty("ToolStripContainer2")]
		[CompilerGenerated]
		private ToolStripContainer toolStripContainer_1;

		// Token: 0x04004863 RID: 18531
		private Side side_0;

		// Token: 0x04004864 RID: 18532
		[AccessedThroughProperty("TSCB_Side_Combobox")]
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_0;
	}
}
