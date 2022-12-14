using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns7;

namespace Command
{
	// Token: 0x02000D88 RID: 3464
	[DesignerGenerated]
	public sealed class FuelPanel_WPF : UserControl, IComponentConnector
	{
		// Token: 0x06005C6E RID: 23662 RVA: 0x0003B5B0 File Offset: 0x000397B0
		public FuelPanel_WPF()
		{
			this.InitializeComponent();
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x0032D054 File Offset: 0x0032B254
		public void method_0(ActiveUnit activeUnit_0)
		{
			try
			{
				if (activeUnit_0 == null)
				{
					base.Visibility = Visibility.Collapsed;
				}
				else if (!activeUnit_0.vmethod_90().vmethod_1() && !Class2558.smethod_17(activeUnit_0) && !Client.smethod_52().method_1())
				{
					base.Visibility = Visibility.Collapsed;
				}
				else
				{
					base.Visibility = Visibility.Visible;
					if (base.DataContext != null)
					{
						FuelViewModel fuelViewModel = (FuelViewModel)base.DataContext;
						if (fuelViewModel.activeUnit_0 == activeUnit_0)
						{
							fuelViewModel.Refresh();
						}
						else
						{
							base.DataContext = new FuelViewModel(activeUnit_0);
						}
					}
					else
					{
						base.DataContext = new FuelViewModel(activeUnit_0);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005C70 RID: 23664 RVA: 0x0032D128 File Offset: 0x0032B328
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/customcontrols/rightcolumn/fuelpanel_wpf.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06005C71 RID: 23665 RVA: 0x0003B5BE File Offset: 0x000397BE
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x040035E3 RID: 13795
		private bool bool_0;
	}
}
