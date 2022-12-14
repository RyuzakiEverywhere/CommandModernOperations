using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace Command
{
	// Token: 0x02000DFE RID: 3582
	[DesignerGenerated]
	public sealed class MessageLogOuterControl : UserControl, IComponentConnector
	{
		// Token: 0x0600687A RID: 26746 RVA: 0x000426B7 File Offset: 0x000408B7
		public MessageLogOuterControl()
		{
			base.KeyDown += this.MessageLogOuterControl_KeyDown;
			this.InitializeComponent();
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x000426D7 File Offset: 0x000408D7
		public MessageLogControlViewModel method_0()
		{
			return (MessageLogControlViewModel)base.DataContext;
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x00389FDC File Offset: 0x003881DC
		public void MessageLogExpandCollapseButton_OnClick(object sender, RoutedEventArgs e)
		{
			if (this.method_0() != null)
			{
				if (this.method_0().LogCollapsed)
				{
					Class2413.smethod_2().method_41().vmethod_800().MaximumSize = new System.Drawing.Size(this.method_0().MainFormLogWidth, 400);
					Class2413.smethod_2().method_41().vmethod_800().MinimumSize = new System.Drawing.Size(this.method_0().MainFormLogWidth, 400);
					Class2413.smethod_2().method_41().vmethod_800().Location = new System.Drawing.Point(Class2413.smethod_2().method_41().vmethod_800().Location.X, Class2413.smethod_2().method_41().vmethod_800().Location.Y - 370);
					Class2413.smethod_2().method_41().vmethod_800().Height = 400;
					this.method_0().LogCollapsed = false;
					this.method_0().LogCollapseButtonRotation = 0.0;
					return;
				}
				Class2413.smethod_2().method_41().vmethod_800().MaximumSize = new System.Drawing.Size(this.method_0().MainFormLogWidth, 30);
				Class2413.smethod_2().method_41().vmethod_800().MinimumSize = new System.Drawing.Size(this.method_0().MainFormLogWidth, 30);
				Class2413.smethod_2().method_41().vmethod_800().Location = new System.Drawing.Point(Class2413.smethod_2().method_41().vmethod_800().Location.X, Class2413.smethod_2().method_41().vmethod_800().Location.Y + 370);
				Class2413.smethod_2().method_41().vmethod_800().Height = 30;
				this.method_0().LogCollapsed = true;
				this.method_0().LogCollapseButtonRotation = 180.0;
			}
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x000426E4 File Offset: 0x000408E4
		private void MessageLogOuterControl_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.M)
			{
				Class2413.smethod_2().method_41().method_175();
			}
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x0038A1C0 File Offset: 0x003883C0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/messagelog/messagelogoutercontrol.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x000426FF File Offset: 0x000408FF
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((Button)target).Click += this.MessageLogExpandCollapseButton_OnClick;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04003B66 RID: 15206
		private bool bool_0;
	}
}
