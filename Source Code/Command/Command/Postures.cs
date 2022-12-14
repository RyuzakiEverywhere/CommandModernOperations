using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000EF7 RID: 3831
	[DesignerGenerated]
	public sealed partial class Postures : DarkSecondaryFormBase
	{
		// Token: 0x060086FF RID: 34559 RVA: 0x0048761C File Offset: 0x0048581C
		public Postures()
		{
			base.Load += this.Postures_Load;
			base.KeyDown += this.Postures_KeyDown;
			base.FormClosing += this.Postures_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x06008701 RID: 34561 RVA: 0x004876AC File Offset: 0x004858AC
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control4());
			this.vmethod_3(new Class116());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Class2451());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().Location = new Point(12, 25);
			this.vmethod_0().Name = "LB_Sides";
			this.vmethod_0().Size = new Size(214, 147);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_2().method_2(true);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(9, 9);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new Size(99, 15);
			this.vmethod_2().TabIndex = 4;
			this.vmethod_2().Text = "Select target side:";
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(9, 188);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new Size(148, 13);
			this.vmethod_4().TabIndex = 5;
			this.vmethod_4().Text = "Consider this side to be...";
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_6().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_6().Font = new Font("Segoe UI", 7f);
			this.vmethod_6().FormattingEnabled = true;
			this.vmethod_6().Items.AddRange(new object[]
			{
				"Neutral",
				"Friendly",
				"Unfriendly",
				"Hostile"
			});
			this.vmethod_6().Location = new Point(12, 204);
			this.vmethod_6().Name = "ComboBox1";
			this.vmethod_6().Size = new Size(216, 21);
			this.vmethod_6().TabIndex = 6;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(238, 233);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Postures";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Postures";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008702 RID: 34562 RVA: 0x00051476 File Offset: 0x0004F676
		[CompilerGenerated]
		internal Control4 vmethod_0()
		{
			return this.control4_0;
		}

		// Token: 0x06008703 RID: 34563 RVA: 0x004879C4 File Offset: 0x00485BC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control4 control4_1)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_3);
			Control4 control = this.control4_0;
			if (control != null)
			{
				control.method_17(eventHandler_);
			}
			this.control4_0 = control4_1;
			control = this.control4_0;
			if (control != null)
			{
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06008704 RID: 34564 RVA: 0x0005147E File Offset: 0x0004F67E
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x06008705 RID: 34565 RVA: 0x00051486 File Offset: 0x0004F686
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_2)
		{
			this.class116_0 = class116_2;
		}

		// Token: 0x06008706 RID: 34566 RVA: 0x0005148F File Offset: 0x0004F68F
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x06008707 RID: 34567 RVA: 0x00051497 File Offset: 0x0004F697
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_2)
		{
			this.class116_1 = class116_2;
		}

		// Token: 0x06008708 RID: 34568 RVA: 0x000514A0 File Offset: 0x0004F6A0
		[CompilerGenerated]
		internal Class2451 vmethod_6()
		{
			return this.class2451_0;
		}

		// Token: 0x06008709 RID: 34569 RVA: 0x00487A08 File Offset: 0x00485C08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_4);
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

		// Token: 0x0600870A RID: 34570 RVA: 0x00487A4C File Offset: 0x00485C4C
		private void Postures_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.Text = "Postures for side: " + this.side_0.method_51() + " (how this side views other sides)";
			try
			{
				foreach (Side side in Enumerable.OrderBy<Side, string>(Client.smethod_46().method_44(), (Postures._Closure$__.$I22-0 == null) ? (Postures._Closure$__.$I22-0 = new Func<Side, string>(Postures._Closure$__.$I.method_0)) : Postures._Closure$__.$I22-0))
				{
					if (side != this.side_0)
					{
						this.vmethod_0().method_18().Add(new Class117(side.method_51()));
					}
				}
			}
			finally
			{
				IEnumerator<Side> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (this.vmethod_0().method_18().Count > 0)
			{
				this.vmethod_0().method_29(0);
			}
		}

		// Token: 0x0600870B RID: 34571 RVA: 0x00487B38 File Offset: 0x00485D38
		private void method_3(object sender, EventArgs e)
		{
			if (this.vmethod_0().method_20().Count != 0)
			{
				foreach (Side side in Client.smethod_46().method_44())
				{
					if (Operators.CompareString(side.method_51(), this.vmethod_0().method_21()[0].method_2(), false) == 0)
					{
						this.side_1 = side;
						IL_5C:
						this.vmethod_6().SelectedIndex = (int)this.side_0.method_68(this.side_1);
						return;
					}
				}
				goto IL_5C;
			}
		}

		// Token: 0x0600870C RID: 34572 RVA: 0x00487BC0 File Offset: 0x00485DC0
		private void method_4(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.side_1))
			{
				DarkMessageBox.smethod_2("First, select a target side for which the posture will apply.", "No target side selected!", Enum11.const_0);
				return;
			}
			this.side_0.method_69(this.side_1, (Misc.PostureStance)this.vmethod_6().SelectedIndex);
			Client.bool_1 = true;
		}

		// Token: 0x0600870D RID: 34573 RVA: 0x0004B8B4 File Offset: 0x00049AB4
		private void Postures_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x00044820 File Offset: 0x00042A20
		private void Postures_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x04004994 RID: 18836
		[CompilerGenerated]
		[AccessedThroughProperty("LB_Sides")]
		private Control4 control4_0;

		// Token: 0x04004995 RID: 18837
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004996 RID: 18838
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_1;

		// Token: 0x04004997 RID: 18839
		[AccessedThroughProperty("ComboBox1")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04004998 RID: 18840
		public Side side_0;

		// Token: 0x04004999 RID: 18841
		public Side side_1;
	}
}
