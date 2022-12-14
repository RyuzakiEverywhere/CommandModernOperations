using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command
{
	// Token: 0x02000DF3 RID: 3571
	[DesignerGenerated]
	[Attribute3]
	[Attribute2]
	[Attribute0]
	public sealed class HoverInfoWeapons : UserControl, IComponentConnector
	{
		// Token: 0x060067E6 RID: 26598 RVA: 0x00042089 File Offset: 0x00040289
		public HoverInfoWeapons()
		{
			this.InitializeComponent();
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x00388E28 File Offset: 0x00387028
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfoweapons.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x00042076 File Offset: 0x00040276
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Delegate method_0(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x00042097 File Offset: 0x00040297
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003B2C RID: 15148
		private bool bool_0;
	}
}
