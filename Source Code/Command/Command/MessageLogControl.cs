using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace Command
{
	// Token: 0x02000E51 RID: 3665
	[DesignerGenerated]
	public sealed class MessageLogControl : UserControl, IComponentConnector, IStyleConnector
	{
		// Token: 0x06006EC6 RID: 28358 RVA: 0x00045EC7 File Offset: 0x000440C7
		public MessageLogControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x06006EC7 RID: 28359 RVA: 0x000426D7 File Offset: 0x000408D7
		public MessageLogControlViewModel method_0()
		{
			return (MessageLogControlViewModel)base.DataContext;
		}

		// Token: 0x06006EC8 RID: 28360 RVA: 0x003C018C File Offset: 0x003BE38C
		private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
		{
			TextBlock textBlock = (TextBlock)sender;
			if (textBlock != null)
			{
				MLDetailViewModel theDetails = (MLDetailViewModel)textBlock.Tag;
				if (this.method_0() != null)
				{
					this.method_0().method_5(theDetails);
				}
			}
		}

		// Token: 0x06006EC9 RID: 28361 RVA: 0x003C01C4 File Offset: 0x003BE3C4
		private void UIElement_OnMouseLeave(object sender, MouseEventArgs e)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(((TextBlock)sender).Tag);
			foreach (MLBalloonViewModel mlballoonViewModel in Enumerable.ToArray<MLBalloonViewModel>(this.method_0().Balloons))
			{
				if (mlballoonViewModel.Tag == objectValue)
				{
					mlballoonViewModel.Hover = false;
				}
			}
		}

		// Token: 0x06006ECA RID: 28362 RVA: 0x00045ED5 File Offset: 0x000440D5
		private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
		{
			MLDetailViewModel mldetailViewModel = (MLDetailViewModel)NewLateBinding.LateGet(sender, null, "Tag", new object[0], null, null, null);
		}

		// Token: 0x06006ECB RID: 28363 RVA: 0x003C0218 File Offset: 0x003BE418
		private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			try
			{
				MLDetailViewModel mldetailViewModel = (MLDetailViewModel)((Grid)sender).DataContext;
				if (mldetailViewModel.Lon != 0.0 || mldetailViewModel.Lat != 0.0)
				{
					Class2413.smethod_2().method_41().method_161(true, new GeoPoint(mldetailViewModel.Lon, mldetailViewModel.Lat));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x003C029C File Offset: 0x003BE49C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/messagelog/messagelogcontrol.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x00045EF2 File Offset: 0x000440F2
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x003C02CC File Offset: 0x003BE4CC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((Grid)target).MouseLeftButtonDown += this.UIElement_OnMouseLeftButtonDown;
			}
			if (connectionId == 2)
			{
				((TextBlock)target).MouseEnter += this.UIElement_OnMouseEnter;
				((TextBlock)target).MouseLeave += this.UIElement_OnMouseLeave;
				((TextBlock)target).MouseDown += this.UIElement_OnMouseDown;
			}
			if (connectionId == 3)
			{
				((TextBlock)target).MouseEnter += this.UIElement_OnMouseEnter;
				((TextBlock)target).MouseLeave += this.UIElement_OnMouseLeave;
				((TextBlock)target).MouseDown += this.UIElement_OnMouseDown;
			}
		}

		// Token: 0x04003EEC RID: 16108
		private bool bool_0;
	}
}
