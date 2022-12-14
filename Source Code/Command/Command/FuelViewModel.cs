using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using ns14;

namespace Command
{
	// Token: 0x02000D86 RID: 3462
	[Attribute0]
	[Attribute3]
	[Attribute2]
	public sealed class FuelViewModel : INotifyPropertyChanged
	{
		// Token: 0x06005C61 RID: 23649 RVA: 0x0032CCBC File Offset: 0x0032AEBC
		[Obsolete("Used for design time only", true)]
		public FuelViewModel()
		{
			this.Items = new ObservableCollection<PlatFormViewModel>();
			AircraftFuelViewModel aircraftFuelViewModel = new AircraftFuelViewModel();
			aircraftFuelViewModel.Percentage = 50.0;
			aircraftFuelViewModel.Text = "Test Text";
			aircraftFuelViewModel.UnitName = "Aircraft Unit";
			this.Items.Add(aircraftFuelViewModel);
			ShipFuelViewModel shipFuelViewModel = new ShipFuelViewModel();
			shipFuelViewModel.Percentage = 25.0;
			shipFuelViewModel.Text = "Test Text";
			shipFuelViewModel.UnitName = "Ship Unit";
			this.Items.Add(shipFuelViewModel);
			SubmarineFuelViewModel submarineFuelViewModel = new SubmarineFuelViewModel();
			submarineFuelViewModel.Percentage = 50.0;
			submarineFuelViewModel.EnduranceText = "Test Text";
			submarineFuelViewModel.UnitName = "Submarine Unit";
			this.Items.Add(submarineFuelViewModel);
			this.SelectedItem = Enumerable.First<PlatFormViewModel>(this.Items);
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x0032CD90 File Offset: 0x0032AF90
		private void method_0(ActiveUnit theUnit)
		{
			FuelViewModel.Class2426 @class = new FuelViewModel.Class2426();
			@class.activeUnit_0 = theUnit;
			try
			{
				PlatFormViewModel platFormViewModel = Enumerable.FirstOrDefault<PlatFormViewModel>(this.Items, new Func<PlatFormViewModel, bool>(@class.method_0));
				if (platFormViewModel == null)
				{
					if (@class.activeUnit_0 is Aircraft)
					{
						platFormViewModel = new AircraftFuelViewModel((Aircraft)@class.activeUnit_0);
						this.Items.Add(platFormViewModel);
					}
					else if (@class.activeUnit_0 is Submarine)
					{
						platFormViewModel = new SubmarineFuelViewModel((Submarine)@class.activeUnit_0);
						this.Items.Add(platFormViewModel);
					}
					else if (@class.activeUnit_0 is Ship)
					{
						platFormViewModel = new ShipFuelViewModel((Ship)@class.activeUnit_0);
						this.Items.Add(platFormViewModel);
					}
				}
				else if (platFormViewModel is AircraftFuelViewModel)
				{
					((AircraftFuelViewModel)platFormViewModel).Refresh();
				}
				else if (platFormViewModel is SubmarineFuelViewModel)
				{
					((SubmarineFuelViewModel)platFormViewModel).Refresh();
				}
				else if (platFormViewModel is ShipFuelViewModel)
				{
					((ShipFuelViewModel)platFormViewModel).Refresh();
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

		// Token: 0x06005C63 RID: 23651 RVA: 0x0032CED4 File Offset: 0x0032B0D4
		[Attribute0]
		[Attribute2]
		public void Refresh()
		{
			try
			{
				if (this.activeUnit_0 is Group)
				{
					try
					{
						foreach (KeyValuePair<string, ActiveUnit> keyValuePair in ((Group)this.activeUnit_0).vmethod_141())
						{
							this.method_0(keyValuePair.Value);
						}
						goto IL_59;
					}
					finally
					{
						IEnumerator<KeyValuePair<string, ActiveUnit>> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				this.method_0(this.activeUnit_0);
				IL_59:
				if (this.SelectedItem == null & this.Items.Count != 0)
				{
					this.SelectedItem = Enumerable.First<PlatFormViewModel>(this.Items);
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

		// Token: 0x06005C64 RID: 23652 RVA: 0x0003B523 File Offset: 0x00039723
		public FuelViewModel(ActiveUnit theUnit)
		{
			this.Items = new ObservableCollection<PlatFormViewModel>();
			this.activeUnit_0 = theUnit;
			this.Refresh();
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06005C65 RID: 23653 RVA: 0x0003B543 File Offset: 0x00039743
		// (set) Token: 0x06005C66 RID: 23654 RVA: 0x0003B54B File Offset: 0x0003974B
		public ObservableCollection<PlatFormViewModel> Items
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_0 == value)
				{
					return;
				}
				this.observableCollection_0 = value;
				this.vmethod_0("Items");
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06005C67 RID: 23655 RVA: 0x0003B56B File Offset: 0x0003976B
		// (set) Token: 0x06005C68 RID: 23656 RVA: 0x0003B573 File Offset: 0x00039773
		public object SelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.object_0;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.object_0, value))
				{
					return;
				}
				this.object_0 = RuntimeHelpers.GetObjectValue(value);
				this.vmethod_0("SelectedItem");
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06005C69 RID: 23657 RVA: 0x0032CFBC File Offset: 0x0032B1BC
		// (remove) Token: 0x06005C6A RID: 23658 RVA: 0x0032CFF4 File Offset: 0x0032B1F4
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

		// Token: 0x06005C6B RID: 23659 RVA: 0x0032D02C File Offset: 0x0032B22C
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040035DE RID: 13790
		[CompilerGenerated]
		private ObservableCollection<PlatFormViewModel> observableCollection_0;

		// Token: 0x040035DF RID: 13791
		[CompilerGenerated]
		private object object_0;

		// Token: 0x040035E0 RID: 13792
		public ActiveUnit activeUnit_0;

		// Token: 0x040035E1 RID: 13793
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000D87 RID: 3463
		[CompilerGenerated]
		internal sealed class Class2426
		{
			// Token: 0x06005C6D RID: 23661 RVA: 0x0003B59B File Offset: 0x0003979B
			internal bool method_0(PlatFormViewModel s)
			{
				return s != null && s.activeUnit_0 == this.activeUnit_0;
			}

			// Token: 0x040035E2 RID: 13794
			public ActiveUnit activeUnit_0;
		}
	}
}
