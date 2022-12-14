using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000E01 RID: 3585
	[DesignerGenerated]
	[Attribute11]
	[Attribute12]
	[Attribute13]
	public sealed class MessageLogWPFWindow : Window, IComponentConnector
	{
		// Token: 0x0600689A RID: 26778 RVA: 0x000427EB File Offset: 0x000409EB
		public MessageLogWPFWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x000427F9 File Offset: 0x000409F9
		private void MessageLogWPFWindow_OnLoaded(object sender, RoutedEventArgs e)
		{
			new WindowInteropHelper(this).Owner = Class2413.smethod_2().method_41().Handle;
		}

		// Token: 0x0600689C RID: 26780 RVA: 0x00042815 File Offset: 0x00040A15
		private void MessageLogWPFWindow_OnClosed(object sender, EventArgs e)
		{
			if (!Client.bool_6)
			{
				Class570.class280_0.method_7(false);
				Class570.smethod_2(Class2566.dictionary_0, Client.list_1);
			}
			Class2413.smethod_2().method_41().messageLogWPFWindow_0 = null;
		}

		// Token: 0x0600689D RID: 26781 RVA: 0x0038AB78 File Offset: 0x00388D78
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_44().Show();
			Class2413.smethod_2().method_44().Left = (int)Math.Round(base.Left);
			Class2413.smethod_2().method_44().Top = (int)Math.Round(base.Top);
			Class2413.smethod_2().method_44().Width = (int)Math.Round(base.Width);
			Class2413.smethod_2().method_44().Height = (int)Math.Round(base.Height);
			Class2413.smethod_2().method_41().method_127(false);
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x0038AC10 File Offset: 0x00388E10
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/messagelog/messagelogwpfwindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x00042076 File Offset: 0x00040276
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x060068A0 RID: 26784 RVA: 0x0038AC40 File Offset: 0x00388E40
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((MessageLogWPFWindow)target).Loaded += this.MessageLogWPFWindow_OnLoaded;
				((MessageLogWPFWindow)target).Closed += this.MessageLogWPFWindow_OnClosed;
				return;
			}
			if (connectionId == 2)
			{
				((Button)target).Click += this.Button_Click;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04003B71 RID: 15217
		private bool bool_0;
	}
}
