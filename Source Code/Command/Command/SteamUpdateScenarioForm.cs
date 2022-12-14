using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;
using ns6;
using Steamworks;

namespace Command
{
	// Token: 0x02000E40 RID: 3648
	[DesignerGenerated]
	public sealed partial class SteamUpdateScenarioForm : DarkSecondaryFormBase
	{
		// Token: 0x06006DC0 RID: 28096 RVA: 0x0004528B File Offset: 0x0004348B
		public SteamUpdateScenarioForm()
		{
			base.Load += this.SteamUpdateScenarioForm_Load;
			base.Load += this.SteamUpdateScenarioForm_Load_1;
			this.InitializeComponent_1();
		}

		// Token: 0x06006DC2 RID: 28098 RVA: 0x003BCB60 File Offset: 0x003BAD60
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control9());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Control4());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_0().Location = new Point(6, 322);
			this.vmethod_0().Name = "Button1";
			this.vmethod_0().Size = new Size(75, 23);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_0().Text = "Update";
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_2().Location = new Point(359, 322);
			this.vmethod_2().Name = "Button2";
			this.vmethod_2().Size = new Size(75, 23);
			this.vmethod_2().TabIndex = 2;
			this.vmethod_2().Text = "Cancel";
			this.vmethod_4().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_4().Location = new Point(6, 5);
			this.vmethod_4().Name = "ListView1";
			this.vmethod_4().Size = new Size(428, 311);
			this.vmethod_4().TabIndex = 3;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(437, 348);
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SteamUpdateScenarioForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Steam Workshop Update Selection";
			base.ResumeLayout(false);
		}

		// Token: 0x06006DC3 RID: 28099 RVA: 0x000452BD File Offset: 0x000434BD
		[CompilerGenerated]
		internal Control9 vmethod_0()
		{
			return this.control9_0;
		}

		// Token: 0x06006DC4 RID: 28100 RVA: 0x003BCD50 File Offset: 0x003BAF50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_4);
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

		// Token: 0x06006DC5 RID: 28101 RVA: 0x000452C5 File Offset: 0x000434C5
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_1;
		}

		// Token: 0x06006DC6 RID: 28102 RVA: 0x003BCD94 File Offset: 0x003BAF94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_3);
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

		// Token: 0x06006DC7 RID: 28103 RVA: 0x000452CD File Offset: 0x000434CD
		[CompilerGenerated]
		internal Control4 vmethod_4()
		{
			return this.control4_0;
		}

		// Token: 0x06006DC8 RID: 28104 RVA: 0x000452D5 File Offset: 0x000434D5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control4 control4_1)
		{
			this.control4_0 = control4_1;
		}

		// Token: 0x06006DC9 RID: 28105 RVA: 0x003BCDD8 File Offset: 0x003BAFD8
		private void SteamUpdateScenarioForm_Load(object sender, EventArgs e)
		{
			foreach (ListViewItem listViewItem in Enumerable.ToArray<ListViewItem>(Enumerable.Select<SteamUGCDetails_t, ListViewItem>(Class2486.list_2, (SteamUpdateScenarioForm._Closure$__.$I17-0 == null) ? (SteamUpdateScenarioForm._Closure$__.$I17-0 = new Func<SteamUGCDetails_t, ListViewItem>(SteamUpdateScenarioForm._Closure$__.$I.method_0)) : SteamUpdateScenarioForm._Closure$__.$I17-0)))
			{
				this.vmethod_4().method_18().Add(new Class117(listViewItem.Name));
			}
		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x003BCE48 File Offset: 0x003BB048
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_4().method_21().Count == 1)
			{
				object tag = this.vmethod_4().method_21()[0].Tag;
				SteamUGCDetails_t steamUGCDetails_t_ = (tag != null) ? ((SteamUGCDetails_t)tag) : default(SteamUGCDetails_t);
				Class2486.smethod_0(SteamUpdateScenarioForm.class2488_0, steamUGCDetails_t_);
			}
		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x00044489 File Offset: 0x00042689
		private void SteamUpdateScenarioForm_Load_1(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04003E79 RID: 15993
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x04003E7A RID: 15994
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x04003E7B RID: 15995
		[AccessedThroughProperty("ListView1")]
		[CompilerGenerated]
		private Control4 control4_0;

		// Token: 0x04003E7C RID: 15996
		public static Class2486.Class2488 class2488_0;
	}
}
