using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns14;
using ns3;
using ns5;
using ns7;
using ns9;

namespace Command
{
	// Token: 0x02000DB8 RID: 3512
	[Attribute3]
	[Attribute2]
	[Attribute0]
	public sealed class EditCargoViewModel : INotifyPropertyChanged
	{
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06005ED5 RID: 24277 RVA: 0x0003D564 File Offset: 0x0003B764
		// (set) Token: 0x06005ED6 RID: 24278 RVA: 0x0003D56C File Offset: 0x0003B76C
		public ActiveUnit ActiveUnit
		{
			[CompilerGenerated]
			get
			{
				return this.activeUnit_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.activeUnit_0 == value)
				{
					return;
				}
				this.activeUnit_0 = value;
				this.vmethod_0("ActiveUnit");
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06005ED7 RID: 24279 RVA: 0x0003D58C File Offset: 0x0003B78C
		// (set) Token: 0x06005ED8 RID: 24280 RVA: 0x0003D594 File Offset: 0x0003B794
		public ObservableCollection<EditCargoCargoItemViewModel> Inventory
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
				this.vmethod_0("Inventory");
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06005ED9 RID: 24281 RVA: 0x0003D5B4 File Offset: 0x0003B7B4
		// (set) Token: 0x06005EDA RID: 24282 RVA: 0x0003D5BC File Offset: 0x0003B7BC
		public DataTable AllMounts
		{
			[CompilerGenerated]
			get
			{
				return this.dataTable_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTable_0 == value)
				{
					return;
				}
				this.dataTable_0 = value;
				this.vmethod_0("AllMounts");
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06005EDB RID: 24283 RVA: 0x0003D5DC File Offset: 0x0003B7DC
		// (set) Token: 0x06005EDC RID: 24284 RVA: 0x0003D5E4 File Offset: 0x0003B7E4
		public DataRowView SelectedMountToAdd
		{
			[CompilerGenerated]
			get
			{
				return this.dataRowView_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataRowView_0 == value)
				{
					return;
				}
				this.dataRowView_0 = value;
				this.vmethod_0("SelectedMountToAdd");
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06005EDD RID: 24285 RVA: 0x0003D604 File Offset: 0x0003B804
		// (set) Token: 0x06005EDE RID: 24286 RVA: 0x0003D60C File Offset: 0x0003B80C
		public int Quantity
		{
			[CompilerGenerated]
			get
			{
				return this.int_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_0 == value)
				{
					return;
				}
				this.int_0 = value;
				this.vmethod_0("Quantity");
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06005EDF RID: 24287 RVA: 0x0003D62C File Offset: 0x0003B82C
		// (set) Token: 0x06005EE0 RID: 24288 RVA: 0x0003D634 File Offset: 0x0003B834
		public EditCargoCargoItemViewModel SelectedCargoToRemove
		{
			[CompilerGenerated]
			get
			{
				return this.editCargoCargoItemViewModel_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.editCargoCargoItemViewModel_0 == value)
				{
					return;
				}
				this.editCargoCargoItemViewModel_0 = value;
				this.vmethod_0("SelectedCargoToRemove");
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06005EE1 RID: 24289 RVA: 0x0003D654 File Offset: 0x0003B854
		// (set) Token: 0x06005EE2 RID: 24290 RVA: 0x0003D65C File Offset: 0x0003B85C
		public EditCargo Form
		{
			[CompilerGenerated]
			get
			{
				return this.editCargo_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.editCargo_0 == value)
				{
					return;
				}
				this.editCargo_0 = value;
				this.vmethod_0("Form");
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06005EE3 RID: 24291 RVA: 0x0003D67C File Offset: 0x0003B87C
		// (set) Token: 0x06005EE4 RID: 24292 RVA: 0x0003D684 File Offset: 0x0003B884
		public Class2569 AddCargoCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_0 == value)
				{
					return;
				}
				this.class2569_0 = value;
				this.vmethod_0("AddCargoCommand");
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06005EE5 RID: 24293 RVA: 0x0003D6A4 File Offset: 0x0003B8A4
		// (set) Token: 0x06005EE6 RID: 24294 RVA: 0x0003D6AC File Offset: 0x0003B8AC
		public Class2569 RemoveCargoCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_1 == value)
				{
					return;
				}
				this.class2569_1 = value;
				this.vmethod_0("RemoveCargoCommand");
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06005EE7 RID: 24295 RVA: 0x0003D6CC File Offset: 0x0003B8CC
		// (set) Token: 0x06005EE8 RID: 24296 RVA: 0x0003D6D4 File Offset: 0x0003B8D4
		public Class2569 OKCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_2 == value)
				{
					return;
				}
				this.class2569_2 = value;
				this.vmethod_0("OKCommand");
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06005EE9 RID: 24297 RVA: 0x0003D6F4 File Offset: 0x0003B8F4
		// (set) Token: 0x06005EEA RID: 24298 RVA: 0x0003D6FC File Offset: 0x0003B8FC
		public Class2569 CancelCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_3 == value)
				{
					return;
				}
				this.class2569_3 = value;
				this.vmethod_0("CancelCommand");
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06005EEB RID: 24299 RVA: 0x0003D71C File Offset: 0x0003B91C
		// (set) Token: 0x06005EEC RID: 24300 RVA: 0x0003D724 File Offset: 0x0003B924
		public string LastError
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_0, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_0 = value;
				this.vmethod_0("LastError");
			}
		}

		// Token: 0x06005EED RID: 24301 RVA: 0x00333C2C File Offset: 0x00331E2C
		public void method_0()
		{
			EditCargoViewModel.Class2441 @class = new EditCargoViewModel.Class2441();
			if (this.SelectedMountToAdd != null)
			{
				@class.int_0 = Conversions.ToInteger(this.SelectedMountToAdd["ID"]);
				EditCargoCargoItemViewModel editCargoCargoItemViewModel = Enumerable.FirstOrDefault<EditCargoCargoItemViewModel>(Enumerable.Where<EditCargoCargoItemViewModel>(this.Inventory, new Func<EditCargoCargoItemViewModel, bool>(@class.method_0)));
				int mountDBID = @class.int_0;
				Scenario scenario = Client.smethod_46();
				Mount mount = DBFunctions.smethod_110(mountDBID, ref scenario, true);
				Interface3 @interface = (Interface3)this.ActiveUnit;
				if (mount.cargoType_0 > @interface.imethod_2())
				{
					this.LastError = "Unable to add cargo to platform, due to cargo type limitations.";
					return;
				}
				if (editCargoCargoItemViewModel == null)
				{
					editCargoCargoItemViewModel = new EditCargoCargoItemViewModel
					{
						Cargo = new Cargo(this.ActiveUnit, DBFunctions.smethod_110(@class.int_0, ref this.ActiveUnit.scenario_0, true)),
						Quantity = 0
					};
					this.Inventory.Add(editCargoCargoItemViewModel);
				}
				EditCargoCargoItemViewModel editCargoCargoItemViewModel2;
				(editCargoCargoItemViewModel2 = editCargoCargoItemViewModel).Quantity = editCargoCargoItemViewModel2.Quantity + this.Quantity;
			}
		}

		// Token: 0x06005EEE RID: 24302 RVA: 0x00333D18 File Offset: 0x00331F18
		public void method_1()
		{
			if (this.SelectedCargoToRemove != null)
			{
				EditCargoCargoItemViewModel selectedCargoToRemove;
				(selectedCargoToRemove = this.SelectedCargoToRemove).Quantity = selectedCargoToRemove.Quantity - this.Quantity;
				if (this.SelectedCargoToRemove.Quantity <= 0)
				{
					this.Inventory.Remove(this.SelectedCargoToRemove);
				}
			}
		}

		// Token: 0x06005EEF RID: 24303 RVA: 0x00333D68 File Offset: 0x00331F68
		public void method_2()
		{
			Cargo[] cargo_ = this.ActiveUnit.cargo_0;
			Cargo[] array = new Cargo[0];
			try
			{
				IEnumerator<EditCargoCargoItemViewModel> enumerator = this.Inventory.GetEnumerator();
				while (enumerator.MoveNext())
				{
					EditCargoViewModel.Class2442 @class = new EditCargoViewModel.Class2442(@class);
					@class.editCargoCargoItemViewModel_0 = enumerator.Current;
					IEnumerator<Cargo> enumerator2 = Enumerable.Select<Cargo, Cargo>(Enumerable.Where<Cargo>(Enumerable.Where<Cargo>(this.ActiveUnit.cargo_0, (EditCargoViewModel._Closure$__.$I50-0 == null) ? (EditCargoViewModel._Closure$__.$I50-0 = new Func<Cargo, bool>(EditCargoViewModel._Closure$__.$I.method_0)) : EditCargoViewModel._Closure$__.$I50-0), new Func<Cargo, bool>(@class.method_0)), (EditCargoViewModel._Closure$__.$I50-2 == null) ? (EditCargoViewModel._Closure$__.$I50-2 = new Func<Cargo, Cargo>(EditCargoViewModel._Closure$__.$I.method_1)) : EditCargoViewModel._Closure$__.$I50-2).GetEnumerator();
					for (int i = @class.editCargoCargoItemViewModel_0.Quantity; i > 0; i--)
					{
						if (enumerator2.MoveNext())
						{
							Class429.smethod_6(ref array, enumerator2.Current);
						}
						else
						{
							Class429.smethod_6(ref array, new Cargo(this.ActiveUnit, DBFunctions.smethod_110(((Mount)@class.editCargoCargoItemViewModel_0.Cargo.method_25()).DBID, ref this.ActiveUnit.scenario_0, true)));
						}
					}
				}
			}
			finally
			{
				IEnumerator<EditCargoCargoItemViewModel> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			Interface3 @interface = (Interface3)this.ActiveUnit;
			float num = @interface.imethod_3();
			float num2 = @interface.imethod_1();
			float num3 = @interface.imethod_0();
			foreach (Cargo cargo in array)
			{
				if (cargo.method_23() == Cargo.Enum111.const_1)
				{
					Mount mount = (Mount)cargo.method_25();
					num -= (float)mount.short_2;
					num2 -= (float)mount.short_1;
					num3 -= (float)mount.short_0;
				}
				else if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			if (num < 0f | num2 < 0f | num3 < 0f)
			{
				this.LastError = "The cargo limits on this unit have been exceeded.";
				return;
			}
			Class429.smethod_8(ref cargo_);
			this.ActiveUnit.cargo_0 = array;
			Class2413.smethod_2().method_41().method_97().method_3(Client.smethod_54(), Client.smethod_54());
			this.Form.Close();
		}

		// Token: 0x06005EF0 RID: 24304 RVA: 0x0003D748 File Offset: 0x0003B948
		public void method_3()
		{
			this.Form.Close();
		}

		// Token: 0x06005EF1 RID: 24305 RVA: 0x00333FBC File Offset: 0x003321BC
		private DataTrigger method_4(object value)
		{
			DataTrigger dataTrigger = new DataTrigger();
			dataTrigger.Binding = new Binding("Cargo_Type");
			dataTrigger.Value = RuntimeHelpers.GetObjectValue(value);
			Setter setter = new Setter();
			dataTrigger.Setters.Add(setter);
			setter.Property = Control.BackgroundProperty;
			setter.Value = Brushes.Red;
			return dataTrigger;
		}

		// Token: 0x06005EF2 RID: 24306 RVA: 0x00334014 File Offset: 0x00332214
		public EditCargoViewModel(EditCargo Form, EditCargoControl Control, ActiveUnit selectedHost)
		{
			this.Inventory = new ObservableCollection<EditCargoCargoItemViewModel>();
			this.AddCargoCommand = new Class2569(new Action<object>(this.method_5));
			this.RemoveCargoCommand = new Class2569(new Action<object>(this.method_6));
			this.OKCommand = new Class2569(new Action<object>(this.method_7));
			this.CancelCommand = new Class2569(new Action<object>(this.method_8));
			this.Form = Form;
			this.Quantity = 1;
			this.ActiveUnit = selectedHost;
			Interface3 @interface = (Interface3)this.ActiveUnit;
			Style style = new Style();
			string value = "Not Cargo Capable";
			string value2 = "Personnel (Squads, MANPADS, ATGM)";
			string value3 = "Small Cargo (Cars, AAA Guns)";
			string value4 = "Medium Cargo (APC, Towed Arty)";
			string value5 = "Large Cargo (Tank, TEL, Trailer)";
			string value6 = "Very Large Cargo (IRBM / ICBM TEL)";
			if (@interface.imethod_2() < CargoType.VLargeCargo)
			{
				style.Triggers.Add(this.method_4(value6));
			}
			if (@interface.imethod_2() < CargoType.LargeCargo)
			{
				style.Triggers.Add(this.method_4(value5));
			}
			if (@interface.imethod_2() < CargoType.MediumCargo)
			{
				style.Triggers.Add(this.method_4(value4));
			}
			if (@interface.imethod_2() < CargoType.SmallCargo)
			{
				style.Triggers.Add(this.method_4(value3));
			}
			if (@interface.imethod_2() < CargoType.Personnel)
			{
				style.Triggers.Add(this.method_4(value2));
			}
			if (@interface.imethod_2() < CargoType.NoCargo)
			{
				style.Triggers.Add(this.method_4(value));
			}
			Control.MyDataGrid.RowStyle = style;
			Form.Text = "Edit Cargo for " + selectedHost.Name;
			DataTable dataTable;
			try
			{
				SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
				dataTable = DBFunctions.smethod_68(ref sqliteConnection);
			}
			catch (Exception ex)
			{
				DarkMessageBox.smethod_2("Unable to use currently loaded database for cargo related tasks. Please upgrade scenario to latest database.", "Error", Enum11.const_0);
				Form.Close();
				return;
			}
			this.AllMounts = dataTable.Clone();
			this.AllMounts.Columns["Cargo_Type"].DataType = typeof(string);
			this.AllMounts.Columns["Cargo_Type"].Caption = "Cargo Type";
			this.AllMounts.Columns["Cargo_Mass"].Caption = "Cargo Mass (tons)";
			this.AllMounts.Columns["Cargo_Area"].Caption = "Cargo Area (sq. m)";
			this.AllMounts.Columns["Cargo_Crew"].Caption = "Cargo Crew";
			this.AllMounts.Columns["Cargo_ParadropCapable"].Caption = "Paradrop Capable";
			try
			{
				foreach (object obj in dataTable.Rows)
				{
					DataRow row = (DataRow)obj;
					this.AllMounts.ImportRow(row);
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			try
			{
				foreach (object obj2 in this.AllMounts.Rows)
				{
					DataRow dataRow = (DataRow)obj2;
					string left = Conversions.ToString(dataRow["Cargo_Type"]);
					if (Operators.CompareString(left, "0", false) != 0)
					{
						if (Operators.CompareString(left, "1000", false) != 0)
						{
							if (Operators.CompareString(left, "2000", false) != 0)
							{
								if (Operators.CompareString(left, "3000", false) != 0)
								{
									if (Operators.CompareString(left, "4000", false) != 0)
									{
										if (Operators.CompareString(left, "5000", false) != 0)
										{
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
										}
										else
										{
											dataRow["Cargo_Type"] = value6;
										}
									}
									else
									{
										dataRow["Cargo_Type"] = value5;
									}
								}
								else
								{
									dataRow["Cargo_Type"] = value4;
								}
							}
							else
							{
								dataRow["Cargo_Type"] = value3;
							}
						}
						else
						{
							dataRow["Cargo_Type"] = value2;
						}
					}
					else
					{
						dataRow["Cargo_Type"] = value;
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			var enumerable = Enumerable.GroupBy(Enumerable.Where<Cargo>(this.ActiveUnit.cargo_0, (EditCargoViewModel._Closure$__.$I53-0 == null) ? (EditCargoViewModel._Closure$__.$I53-0 = new Func<Cargo, bool>(EditCargoViewModel._Closure$__.$I.method_2)) : EditCargoViewModel._Closure$__.$I53-0), (EditCargoViewModel._Closure$__.$I53-1 == null) ? (EditCargoViewModel._Closure$__.$I53-1 = new Func<Cargo, int>(EditCargoViewModel._Closure$__.$I.method_3)) : EditCargoViewModel._Closure$__.$I53-1, (EditCargoViewModel._Closure$__.$I53-2 == null) ? (EditCargoViewModel._Closure$__.$I53-2 = new Func<int, IEnumerable<Cargo>, VB$AnonymousType_0<int, int>>(EditCargoViewModel._Closure$__.$I.method_4)) : EditCargoViewModel._Closure$__.$I53-2);
			try
			{
				foreach (var vb$AnonymousType_ in enumerable)
				{
					EditCargoCargoItemViewModel item = new EditCargoCargoItemViewModel
					{
						Cargo = new Cargo(this.ActiveUnit, DBFunctions.smethod_110(vb$AnonymousType_.DBID, ref this.ActiveUnit.scenario_0, true)),
						Quantity = vb$AnonymousType_.method_0()
					};
					this.Inventory.Add(item);
				}
			}
			finally
			{
				var enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			if (@interface.imethod_2() == CargoType.NoCargo)
			{
				this.LastError = "This unit is unable to host cargo.";
			}
		}

		// Token: 0x06005EF3 RID: 24307 RVA: 0x0003D755 File Offset: 0x0003B955
		[CompilerGenerated]
		private void method_5(object a0)
		{
			this.method_0();
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x0003D75D File Offset: 0x0003B95D
		[CompilerGenerated]
		private void method_6(object a0)
		{
			this.method_1();
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x0003D765 File Offset: 0x0003B965
		[CompilerGenerated]
		private void method_7(object a0)
		{
			this.method_2();
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x0003D76D File Offset: 0x0003B96D
		[CompilerGenerated]
		private void method_8(object a0)
		{
			this.method_3();
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06005EF7 RID: 24311 RVA: 0x003345A8 File Offset: 0x003327A8
		// (remove) Token: 0x06005EF8 RID: 24312 RVA: 0x003345E0 File Offset: 0x003327E0
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

		// Token: 0x06005EF9 RID: 24313 RVA: 0x00334618 File Offset: 0x00332818
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003701 RID: 14081
		[CompilerGenerated]
		private ActiveUnit activeUnit_0;

		// Token: 0x04003702 RID: 14082
		[CompilerGenerated]
		private ObservableCollection<EditCargoCargoItemViewModel> observableCollection_0;

		// Token: 0x04003703 RID: 14083
		[CompilerGenerated]
		private DataTable dataTable_0;

		// Token: 0x04003704 RID: 14084
		[CompilerGenerated]
		private DataRowView dataRowView_0;

		// Token: 0x04003705 RID: 14085
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003706 RID: 14086
		[CompilerGenerated]
		private EditCargoCargoItemViewModel editCargoCargoItemViewModel_0;

		// Token: 0x04003707 RID: 14087
		[CompilerGenerated]
		private EditCargo editCargo_0;

		// Token: 0x04003708 RID: 14088
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x04003709 RID: 14089
		[CompilerGenerated]
		private Class2569 class2569_1;

		// Token: 0x0400370A RID: 14090
		[CompilerGenerated]
		private Class2569 class2569_2;

		// Token: 0x0400370B RID: 14091
		[CompilerGenerated]
		private Class2569 class2569_3;

		// Token: 0x0400370C RID: 14092
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400370D RID: 14093
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000DB9 RID: 3513
		[CompilerGenerated]
		internal sealed class Class2441
		{
			// Token: 0x06005EFB RID: 24315 RVA: 0x0003D775 File Offset: 0x0003B975
			internal bool method_0(EditCargoCargoItemViewModel a)
			{
				return a.Cargo.method_23() == Cargo.Enum111.const_1 & ((Mount)a.Cargo.method_25()).DBID == this.int_0;
			}

			// Token: 0x0400370E RID: 14094
			public int int_0;
		}

		// Token: 0x02000DBA RID: 3514
		[CompilerGenerated]
		internal sealed class Class2442
		{
			// Token: 0x06005EFC RID: 24316 RVA: 0x0003D7A3 File Offset: 0x0003B9A3
			public Class2442(EditCargoViewModel.Class2442 arg0)
			{
				if (arg0 != null)
				{
					this.editCargoCargoItemViewModel_0 = arg0.editCargoCargoItemViewModel_0;
				}
			}

			// Token: 0x06005EFD RID: 24317 RVA: 0x0003D7BA File Offset: 0x0003B9BA
			internal bool method_0(Cargo C)
			{
				return ((Mount)C.method_25()).DBID == ((Mount)this.editCargoCargoItemViewModel_0.Cargo.method_25()).DBID;
			}

			// Token: 0x0400370F RID: 14095
			public EditCargoCargoItemViewModel editCargoCargoItemViewModel_0;
		}
	}
}
