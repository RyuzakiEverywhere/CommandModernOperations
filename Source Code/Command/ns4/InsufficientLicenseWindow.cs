using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns7;

namespace ns4
{
	// Token: 0x02000E7B RID: 3707
	[DesignerGenerated]
	internal sealed partial class InsufficientLicenseWindow : Form0
	{
		// Token: 0x060071FA RID: 29178 RVA: 0x003D3A80 File Offset: 0x003D1C80
		public InsufficientLicenseWindow()
		{
			base.Shown += this.InsufficientLicenseWindow_Shown;
			base.Load += this.InsufficientLicenseWindow_Load;
			base.Closing += new CancelEventHandler(this.InsufficientLicenseWindow_Closing);
			this.InitializeComponent();
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x0004771C File Offset: 0x0004591C
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x060071FE RID: 29182 RVA: 0x00047724 File Offset: 0x00045924
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x060071FF RID: 29183 RVA: 0x0004772D File Offset: 0x0004592D
		[CompilerGenerated]
		internal SplitContainer vmethod_2()
		{
			return this.splitContainer_0;
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x00047735 File Offset: 0x00045935
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(SplitContainer splitContainer_1)
		{
			this.splitContainer_0 = splitContainer_1;
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x0004773E File Offset: 0x0004593E
		[CompilerGenerated]
		internal FlowLayoutPanel vmethod_4()
		{
			return this.flowLayoutPanel_0;
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x00047746 File Offset: 0x00045946
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(FlowLayoutPanel flowLayoutPanel_1)
		{
			this.flowLayoutPanel_0 = flowLayoutPanel_1;
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x0004774F File Offset: 0x0004594F
		[CompilerGenerated]
		private Button vmethod_6()
		{
			return this.button_0;
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x00047757 File Offset: 0x00045957
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_7(Button button_1)
		{
			this.button_0 = button_1;
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x00047760 File Offset: 0x00045960
		private void InsufficientLicenseWindow_Shown(object sender, EventArgs e)
		{
			MessageBox.Show("welcome1");
		}

		// Token: 0x06007206 RID: 29190 RVA: 0x0004776D File Offset: 0x0004596D
		public List<Class2556.Enum209> method_1()
		{
			return this.list_0;
		}

		// Token: 0x06007207 RID: 29191 RVA: 0x00047775 File Offset: 0x00045975
		public void method_2(List<Class2556.Enum209> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x06007208 RID: 29192 RVA: 0x00044489 File Offset: 0x00042689
		private void InsufficientLicenseWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06007209 RID: 29193 RVA: 0x0004777E File Offset: 0x0004597E
		private void method_3(object sender, EventArgs e)
		{
			Process.Start(Conversions.ToString(NewLateBinding.LateGet(sender, null, "Tag", new object[0], null, null, null)));
		}

		// Token: 0x0600720A RID: 29194 RVA: 0x00047139 File Offset: 0x00045339
		private void method_4(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x0600720B RID: 29195 RVA: 0x00047146 File Offset: 0x00045346
		private void method_5(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Arrow;
		}

		// Token: 0x0600720C RID: 29196 RVA: 0x003D3E4C File Offset: 0x003D204C
		private void InsufficientLicenseWindow_Closing(object sender, CancelEventArgs e)
		{
			try
			{
				foreach (object obj in this.vmethod_4().Controls)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					this.vmethod_7((Button)objectValue);
					this.vmethod_6().Click -= this.method_3;
					this.vmethod_6().MouseEnter -= this.method_4;
					this.vmethod_6().MouseLeave -= this.method_5;
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

		// Token: 0x04004046 RID: 16454
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04004047 RID: 16455
		[AccessedThroughProperty("SplitContainer1")]
		[CompilerGenerated]
		private SplitContainer splitContainer_0;

		// Token: 0x04004048 RID: 16456
		[CompilerGenerated]
		[AccessedThroughProperty("FlowLayoutPanel1")]
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x04004049 RID: 16457
		private List<Class2556.Enum209> list_0;

		// Token: 0x0400404A RID: 16458
		private string string_0;

		// Token: 0x0400404B RID: 16459
		[CompilerGenerated]
		[AccessedThroughProperty("theButton")]
		private Button button_0;
	}
}
