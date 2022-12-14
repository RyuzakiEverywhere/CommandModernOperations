using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;

namespace Command
{
	// Token: 0x02000DD8 RID: 3544
	[DesignerGenerated]
	public sealed class PlayerNagWindow : Window, IComponentConnector
	{
		// Token: 0x060066AF RID: 26287 RVA: 0x00040EF0 File Offset: 0x0003F0F0
		public PlayerNagWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x00040EFE File Offset: 0x0003F0FE
		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			base.Close();
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x0038685C File Offset: 0x00384A5C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/dialogs/playernagwindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x00040F06 File Offset: 0x0003F106
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((Button)target).Click += this.ButtonBase_OnClick;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04003A8C RID: 14988
		private bool bool_0;
	}
}
