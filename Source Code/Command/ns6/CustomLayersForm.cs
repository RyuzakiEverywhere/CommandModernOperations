using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns21;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000E9E RID: 3742
	[DesignerGenerated]
	internal sealed partial class CustomLayersForm : DarkSecondaryFormBase
	{
		// Token: 0x06007546 RID: 30022 RVA: 0x003F4514 File Offset: 0x003F2714
		public CustomLayersForm()
		{
			base.Shown += this.CustomLayersForm_Shown;
			base.KeyDown += this.CustomLayersForm_KeyDown;
			base.FormClosing += this.CustomLayersForm_FormClosing;
			base.Load += this.CustomLayersForm_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x003F45B8 File Offset: 0x003F27B8
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CustomLayersForm));
			this.vmethod_1(new Class125());
			this.vmethod_3(new ToolStripButton());
			this.vmethod_5(new ToolStripButton());
			this.vmethod_7(new Control4());
			this.vmethod_0().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AutoSize = false;
			this.vmethod_0().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_0().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_2(),
				this.vmethod_4()
			});
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "ToolStrip1";
			this.vmethod_0().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_0().Size = new Size(727, 25);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "ToolStrip1";
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Image = (Image)componentResourceManager.GetObject("ToolStripButton1.Image");
			this.vmethod_2().ImageTransparentColor = Color.Magenta;
			this.vmethod_2().Name = "ToolStripButton1";
			this.vmethod_2().Size = new Size(80, 22);
			this.vmethod_2().Text = "Add Layer";
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Image = (Image)componentResourceManager.GetObject("ToolStripButton2.Image");
			this.vmethod_4().ImageTransparentColor = Color.Magenta;
			this.vmethod_4().Name = "ToolStripButton2";
			this.vmethod_4().Size = new Size(117, 22);
			this.vmethod_4().Text = "Remove Selected";
			this.vmethod_6().Dock = DockStyle.Fill;
			this.vmethod_6().Location = new Point(0, 25);
			this.vmethod_6().Name = "ListBox1";
			this.vmethod_6().Size = new Size(727, 282);
			this.vmethod_6().TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(727, 307);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CustomLayersForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Custom Layer Manager";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06007549 RID: 30025 RVA: 0x00048D9F File Offset: 0x00046F9F
		[CompilerGenerated]
		internal Class125 vmethod_0()
		{
			return this.class125_0;
		}

		// Token: 0x0600754A RID: 30026 RVA: 0x00048DA7 File Offset: 0x00046FA7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x0600754B RID: 30027 RVA: 0x00048DB0 File Offset: 0x00046FB0
		[CompilerGenerated]
		internal ToolStripButton vmethod_2()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x0600754C RID: 30028 RVA: 0x003F4928 File Offset: 0x003F2B28
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStripButton toolStripButton_2)
		{
			EventHandler value = new EventHandler(this.method_4);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_2;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600754D RID: 30029 RVA: 0x00048DB8 File Offset: 0x00046FB8
		[CompilerGenerated]
		internal ToolStripButton vmethod_4()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x003F496C File Offset: 0x003F2B6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_2)
		{
			EventHandler value = new EventHandler(this.method_5);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_2;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x00048DC0 File Offset: 0x00046FC0
		[CompilerGenerated]
		internal Control4 vmethod_6()
		{
			return this.control4_0;
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x00048DC8 File Offset: 0x00046FC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control4 control4_1)
		{
			this.control4_0 = control4_1;
		}

		// Token: 0x06007551 RID: 30033 RVA: 0x003F49B0 File Offset: 0x003F2BB0
		public void method_3()
		{
			this.vmethod_6().method_18().Clear();
			try
			{
				foreach (Class1870 @class in Client.list_0)
				{
					Class117 class2 = new Class117(@class.Name);
					class2.Tag = @class;
					this.vmethod_6().method_18().Add(class2);
				}
			}
			finally
			{
				List<Class1870>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06007552 RID: 30034 RVA: 0x00048DD1 File Offset: 0x00046FD1
		private void CustomLayersForm_Shown(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06007553 RID: 30035 RVA: 0x00048DD9 File Offset: 0x00046FD9
		private void method_4(object sender, EventArgs e)
		{
			Client.smethod_105();
			this.method_3();
		}

		// Token: 0x06007554 RID: 30036 RVA: 0x003F4A30 File Offset: 0x003F2C30
		private void method_5(object sender, EventArgs e)
		{
			try
			{
				foreach (Class117 @class in this.vmethod_6().method_21())
				{
					Class2413.smethod_2().method_41().vmethod_796().method_4().method_5().vmethod_20(((Class1870)@class.Tag).Name);
					Client.list_0.Remove((Class1870)@class.Tag);
				}
			}
			finally
			{
				List<Class117>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			Class2413.smethod_2().method_41().method_219();
			this.method_3();
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x000476BE File Offset: 0x000458BE
		private void CustomLayersForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06007556 RID: 30038 RVA: 0x00044820 File Offset: 0x00042A20
		private void CustomLayersForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06007557 RID: 30039 RVA: 0x00044489 File Offset: 0x00042689
		private void CustomLayersForm_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x040041DB RID: 16859
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStrip1")]
		private Class125 class125_0;

		// Token: 0x040041DC RID: 16860
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripButton1")]
		private ToolStripButton toolStripButton_0;

		// Token: 0x040041DD RID: 16861
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripButton2")]
		private ToolStripButton toolStripButton_1;

		// Token: 0x040041DE RID: 16862
		[CompilerGenerated]
		[AccessedThroughProperty("ListBox1")]
		private Control4 control4_0;
	}
}
