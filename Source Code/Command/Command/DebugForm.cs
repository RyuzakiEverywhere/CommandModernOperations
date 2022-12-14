using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command.Tacview;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns5;
using Worldwind.Component;

namespace Command
{
	// Token: 0x02000DD6 RID: 3542
	[DesignerGenerated]
	public sealed partial class DebugForm : Form
	{
		// Token: 0x06006688 RID: 26248 RVA: 0x00385FB4 File Offset: 0x003841B4
		public DebugForm()
		{
			base.FormClosing += this.DebugForm_FormClosing;
			base.Load += this.DebugForm_Load;
			this.concurrentQueue_0 = new ConcurrentQueue<string>();
			this.bool_0 = false;
			this.InitializeComponent();
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x00040D6C File Offset: 0x0003EF6C
		[CompilerGenerated]
		internal TextBox vmethod_0()
		{
			return this.textBox_0;
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x00040D74 File Offset: 0x0003EF74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TextBox textBox_2)
		{
			this.textBox_0 = textBox_2;
		}

		// Token: 0x0600668D RID: 26253 RVA: 0x00040D7D File Offset: 0x0003EF7D
		[CompilerGenerated]
		internal Timer vmethod_2()
		{
			return this.timer_0;
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x003864CC File Offset: 0x003846CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_1);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_1;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x00040D85 File Offset: 0x0003EF85
		[CompilerGenerated]
		internal Label vmethod_4()
		{
			return this.label_0;
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x00040D8D File Offset: 0x0003EF8D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x00040D96 File Offset: 0x0003EF96
		[CompilerGenerated]
		internal TextBox vmethod_6()
		{
			return this.textBox_1;
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x00040D9E File Offset: 0x0003EF9E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TextBox textBox_2)
		{
			this.textBox_1 = textBox_2;
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x00040DA7 File Offset: 0x0003EFA7
		[CompilerGenerated]
		internal Button vmethod_8()
		{
			return this.button_0;
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x00386510 File Offset: 0x00384710
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_2);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_3;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x00040DAF File Offset: 0x0003EFAF
		[CompilerGenerated]
		internal CheckedListBox vmethod_10()
		{
			return this.checkedListBox_0;
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x00386554 File Offset: 0x00384754
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(CheckedListBox checkedListBox_1)
		{
			ItemCheckEventHandler value = new ItemCheckEventHandler(this.method_3);
			CheckedListBox checkedListBox = this.checkedListBox_0;
			if (checkedListBox != null)
			{
				checkedListBox.ItemCheck -= value;
			}
			this.checkedListBox_0 = checkedListBox_1;
			checkedListBox = this.checkedListBox_0;
			if (checkedListBox != null)
			{
				checkedListBox.ItemCheck += value;
			}
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x00040DB7 File Offset: 0x0003EFB7
		[CompilerGenerated]
		internal Button vmethod_12()
		{
			return this.button_1;
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x00386598 File Offset: 0x00384798
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_4);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_3;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x00040DBF File Offset: 0x0003EFBF
		[CompilerGenerated]
		internal Button vmethod_14()
		{
			return this.button_2;
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x003865DC File Offset: 0x003847DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_5);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_3;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x00386620 File Offset: 0x00384820
		public void method_0(string string_0)
		{
			try
			{
				this.concurrentQueue_0.Enqueue(string_0);
			}
			catch (Exception ex)
			{
				this.concurrentQueue_0.Enqueue("Error in DebugForm.Write!");
			}
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x00040DC7 File Offset: 0x0003EFC7
		private void DebugForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Visible = false;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x0000378C File Offset: 0x0000198C
		private void DebugForm_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x0038666C File Offset: 0x0038486C
		private void method_1(object sender, EventArgs e)
		{
			this.vmethod_2().Enabled = false;
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x00040DE8 File Offset: 0x0003EFE8
		private void method_2(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_41().vmethod_796().method_18();
		}

		// Token: 0x060066A0 RID: 26272 RVA: 0x00040DFE File Offset: 0x0003EFFE
		private void method_3(object sender, ItemCheckEventArgs e)
		{
			CommandLayer.smethod_2(Conversions.ToString(this.vmethod_10().Items[e.Index]), e.NewValue == CheckState.Checked);
		}

		// Token: 0x060066A1 RID: 26273 RVA: 0x00386688 File Offset: 0x00384888
		private void method_4(object sender, EventArgs e)
		{
			TacviewClient tacviewClient = Enumerable.FirstOrDefault<TacviewClient>(TacviewServer.smethod_0());
			if (tacviewClient == null)
			{
				Interaction.MsgBox("No TVC", MsgBoxStyle.OkOnly, null);
				return;
			}
			tacviewClient.method_0();
			TacviewServer.smethod_7();
		}

		// Token: 0x060066A2 RID: 26274 RVA: 0x00040E29 File Offset: 0x0003F029
		private void method_5(object sender, EventArgs e)
		{
			if (Enumerable.FirstOrDefault<TacviewClient>(TacviewServer.smethod_0()) == null)
			{
				Interaction.MsgBox("No TVC", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x04003A7D RID: 14973
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private TextBox textBox_0;

		// Token: 0x04003A7E RID: 14974
		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private Timer timer_0;

		// Token: 0x04003A7F RID: 14975
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label label_0;

		// Token: 0x04003A80 RID: 14976
		[AccessedThroughProperty("TextBox2")]
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x04003A81 RID: 14977
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Button button_0;

		// Token: 0x04003A82 RID: 14978
		[AccessedThroughProperty("CheckedListBox1")]
		[CompilerGenerated]
		private CheckedListBox checkedListBox_0;

		// Token: 0x04003A83 RID: 14979
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04003A84 RID: 14980
		[AccessedThroughProperty("Button3")]
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04003A85 RID: 14981
		private ConcurrentQueue<string> concurrentQueue_0;

		// Token: 0x04003A86 RID: 14982
		private bool bool_0;
	}
}
