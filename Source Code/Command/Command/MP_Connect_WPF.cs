using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;

namespace Command
{
	// Token: 0x02000ECA RID: 3786
	[DesignerGenerated]
	public sealed class MP_Connect_WPF : UserControl, IComponentConnector
	{
		// Token: 0x0600827C RID: 33404 RVA: 0x0004F41B File Offset: 0x0004D61B
		public MP_Connect_WPF()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600827D RID: 33405 RVA: 0x0000378C File Offset: 0x0000198C
		private void Button1_Click(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x0600827E RID: 33406 RVA: 0x0004F429 File Offset: 0x0004D629
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_0(Label label_2)
		{
			this.label_0 = label_2;
		}

		// Token: 0x0600827F RID: 33407 RVA: 0x0004F432 File Offset: 0x0004D632
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TextBox textBox_2)
		{
			this.textBox_0 = textBox_2;
		}

		// Token: 0x06008280 RID: 33408 RVA: 0x0004F43B File Offset: 0x0004D63B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_2(Label label_2)
		{
			this.label_1 = label_2;
		}

		// Token: 0x06008281 RID: 33409 RVA: 0x0004F444 File Offset: 0x0004D644
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TextBox textBox_2)
		{
			this.textBox_1 = textBox_2;
		}

		// Token: 0x06008282 RID: 33410 RVA: 0x004659E4 File Offset: 0x00463BE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_4(Button button_1)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button1_Click);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_1;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06008283 RID: 33411 RVA: 0x00465A28 File Offset: 0x00463C28
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/mp/mp_connect_wpf.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06008284 RID: 33412 RVA: 0x00465A58 File Offset: 0x00463C58
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.vmethod_0((Label)target);
				return;
			}
			if (connectionId == 2)
			{
				this.vmethod_1((TextBox)target);
				return;
			}
			if (connectionId == 3)
			{
				this.vmethod_2((Label)target);
				return;
			}
			if (connectionId == 4)
			{
				this.vmethod_3((TextBox)target);
				return;
			}
			if (connectionId == 5)
			{
				this.vmethod_4((Button)target);
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x0400479A RID: 18330
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label label_0;

		// Token: 0x0400479B RID: 18331
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private TextBox textBox_0;

		// Token: 0x0400479C RID: 18332
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Label label_1;

		// Token: 0x0400479D RID: 18333
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox2")]
		private TextBox textBox_1;

		// Token: 0x0400479E RID: 18334
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Button button_0;

		// Token: 0x0400479F RID: 18335
		private bool bool_0;
	}
}
