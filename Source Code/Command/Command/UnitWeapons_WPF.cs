using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns7;

namespace Command
{
	// Token: 0x02000D9B RID: 3483
	[Attribute0]
	[Attribute2]
	[Attribute3]
	[DesignerGenerated]
	public sealed class UnitWeapons_WPF : UserControl, INotifyPropertyChanged, IComponentConnector
	{
		// Token: 0x06005D81 RID: 23937 RVA: 0x0003C331 File Offset: 0x0003A531
		public UnitWeapons_WPF()
		{
			this.InitializeComponent();
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x0032FC14 File Offset: 0x0032DE14
		public void method_0(ActiveUnit theUnit, ref bool theUnitHasWeapons, ref bool thePanelIsExpanded = false)
		{
			if (base.DataContext == null)
			{
				base.DataContext = new UnitWeaponViewModel(theUnit);
				theUnitHasWeapons = ((UnitWeaponViewModel)base.DataContext).HasWeapons;
				return;
			}
			UnitWeaponViewModel unitWeaponViewModel = (UnitWeaponViewModel)base.DataContext;
			if (theUnit != null && !theUnit.vmethod_90().vmethod_1() && !Class2558.smethod_17(theUnit) && !Client.smethod_52().method_1())
			{
				base.DataContext = new UnitWeaponViewModel(theUnit);
				theUnitHasWeapons = false;
				return;
			}
			if (unitWeaponViewModel.activeUnit_0 == theUnit)
			{
				unitWeaponViewModel.method_4();
				theUnitHasWeapons = unitWeaponViewModel.HasWeapons;
				return;
			}
			if (theUnit == null)
			{
				base.DataContext = new UnitWeaponViewModel(theUnit);
				theUnitHasWeapons = false;
				return;
			}
			base.DataContext = new UnitWeaponViewModel(theUnit);
			theUnitHasWeapons = ((UnitWeaponViewModel)base.DataContext).HasWeapons;
			if (theUnitHasWeapons && unitWeaponViewModel.Weapons_Sorted != null && unitWeaponViewModel.Weapons_Sorted.Count < ((UnitWeaponViewModel)base.DataContext).Weapons_Sorted.Count)
			{
				thePanelIsExpanded = true;
				return;
			}
			thePanelIsExpanded = false;
		}

		// Token: 0x06005D83 RID: 23939 RVA: 0x0032FD0C File Offset: 0x0032DF0C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/customcontrols/rightcolumn/unitweapons_wpf.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06005D84 RID: 23940 RVA: 0x0003C33F File Offset: 0x0003A53F
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06005D85 RID: 23941 RVA: 0x0032FD3C File Offset: 0x0032DF3C
		// (remove) Token: 0x06005D86 RID: 23942 RVA: 0x0032FD74 File Offset: 0x0032DF74
		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x0032FDAC File Offset: 0x0032DFAC
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400365A RID: 13914
		private bool bool_0;

		// Token: 0x0400365B RID: 13915
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
