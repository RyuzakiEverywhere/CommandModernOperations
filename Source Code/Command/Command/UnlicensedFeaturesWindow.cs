using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000DFC RID: 3580
	[DesignerGenerated]
	[Attribute11]
	[Attribute12]
	[Attribute13]
	public sealed class UnlicensedFeaturesWindow : Window, IComponentConnector
	{
		// Token: 0x06006872 RID: 26738 RVA: 0x0004263C File Offset: 0x0004083C
		public UnlicensedFeaturesWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x0004264A File Offset: 0x0004084A
		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
			Class2413.smethod_2().method_38().Show();
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x00389F7C File Offset: 0x0038817C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/licensing/unlicensedfeatures.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x00042661 File Offset: 0x00040861
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((Button)target).Click += this.CloseButton_Click;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04003B63 RID: 15203
		private bool bool_0;
	}
}
