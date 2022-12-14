using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using ns12;
using ns14;
using ns5;

namespace Command
{
	// Token: 0x02000DD2 RID: 3538
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class DatabaseControlViewModel : INotifyPropertyChanged
	{
		// Token: 0x06006648 RID: 26184 RVA: 0x000409CD File Offset: 0x0003EBCD
		public DatabaseControlViewModel()
		{
			this.HighlightTarget = null;
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06006649 RID: 26185 RVA: 0x000409DC File Offset: 0x0003EBDC
		// (set) Token: 0x0600664A RID: 26186 RVA: 0x000409E4 File Offset: 0x0003EBE4
		public string WindowTitle
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
				this.vmethod_0("WindowTitle");
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x0600664B RID: 26187 RVA: 0x00040A08 File Offset: 0x0003EC08
		// (set) Token: 0x0600664C RID: 26188 RVA: 0x00040A10 File Offset: 0x0003EC10
		public DatabaseControl DatabaseControl
		{
			[CompilerGenerated]
			get
			{
				return this.databaseControl_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.databaseControl_0 == value)
				{
					return;
				}
				this.databaseControl_0 = value;
				this.vmethod_0("DatabaseControl");
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x0600664D RID: 26189 RVA: 0x00040A30 File Offset: 0x0003EC30
		// (set) Token: 0x0600664E RID: 26190 RVA: 0x00040A38 File Offset: 0x0003EC38
		public string SelectedObjectType
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_1, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_1 = value;
				this.vmethod_0("SelectedObjectType");
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x0600664F RID: 26191 RVA: 0x00040A5C File Offset: 0x0003EC5C
		// (set) Token: 0x06006650 RID: 26192 RVA: 0x00040A64 File Offset: 0x0003EC64
		public int SelectedObjectID
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
				this.vmethod_0("SelectedObjectID");
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06006651 RID: 26193 RVA: 0x00040A84 File Offset: 0x0003EC84
		// (set) Token: 0x06006652 RID: 26194 RVA: 0x00040A8C File Offset: 0x0003EC8C
		public string SelectedObjectName
		{
			[CompilerGenerated]
			get
			{
				return this.string_2;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_2, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_2 = value;
				this.vmethod_0("SelectedObjectName");
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06006653 RID: 26195 RVA: 0x00040AB0 File Offset: 0x0003ECB0
		// (set) Token: 0x06006654 RID: 26196 RVA: 0x00040AB8 File Offset: 0x0003ECB8
		public string HighlightTarget
		{
			[CompilerGenerated]
			get
			{
				return this.string_3;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_3, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_3 = value;
				this.vmethod_0("HighlightTarget");
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06006655 RID: 26197 RVA: 0x00040ADC File Offset: 0x0003ECDC
		// (set) Token: 0x06006656 RID: 26198 RVA: 0x00040AE4 File Offset: 0x0003ECE4
		public List<DatabaseControlTypeViewModel> Types
		{
			[CompilerGenerated]
			get
			{
				return this.list_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.list_0 == value)
				{
					return;
				}
				this.list_0 = value;
				this.vmethod_0("Types");
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06006657 RID: 26199 RVA: 0x00040B04 File Offset: 0x0003ED04
		// (set) Token: 0x06006658 RID: 26200 RVA: 0x00040B0C File Offset: 0x0003ED0C
		public DataView Countries
		{
			[CompilerGenerated]
			get
			{
				return this.dataView_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataView_0 == value)
				{
					return;
				}
				this.dataView_0 = value;
				this.vmethod_0("Countries");
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06006659 RID: 26201 RVA: 0x00040B2C File Offset: 0x0003ED2C
		// (set) Token: 0x0600665A RID: 26202 RVA: 0x00040B34 File Offset: 0x0003ED34
		public long UnitsDataViewSelectedUnitID
		{
			get
			{
				return this.long_0;
			}
			set
			{
				if (this.long_0 != value)
				{
					this.long_0 = value;
					this.vmethod_0("UnitsDataViewSelectedUnitID");
					this.SelectedObjectID = (int)value;
					this.method_0();
				}
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600665B RID: 26203 RVA: 0x00040B5F File Offset: 0x0003ED5F
		// (set) Token: 0x0600665C RID: 26204 RVA: 0x00040B67 File Offset: 0x0003ED67
		public long SelectedCountryID
		{
			get
			{
				return this.long_1;
			}
			set
			{
				if (this.long_1 != value)
				{
					this.long_1 = value;
					this.vmethod_0("SelectedCountryID");
					this.method_0();
				}
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600665D RID: 26205 RVA: 0x00040B8A File Offset: 0x0003ED8A
		// (set) Token: 0x0600665E RID: 26206 RVA: 0x00040B92 File Offset: 0x0003ED92
		public DataView UnitsDataView
		{
			[CompilerGenerated]
			get
			{
				return this.dataView_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataView_1 == value)
				{
					return;
				}
				this.dataView_1 = value;
				this.vmethod_0("UnitsDataView");
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600665F RID: 26207 RVA: 0x00040BB2 File Offset: 0x0003EDB2
		// (set) Token: 0x06006660 RID: 26208 RVA: 0x00040BBA File Offset: 0x0003EDBA
		public string SearchString
		{
			get
			{
				return this.string_4;
			}
			set
			{
				if (string.Equals(this.string_4, value, StringComparison.Ordinal))
				{
					return;
				}
				if (Operators.CompareString(this.string_4, value, false) != 0)
				{
					this.string_4 = value;
					this.vmethod_0("SearchString");
					this.method_0();
				}
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06006661 RID: 26209 RVA: 0x00040BF3 File Offset: 0x0003EDF3
		// (set) Token: 0x06006662 RID: 26210 RVA: 0x00040BFB File Offset: 0x0003EDFB
		public DataView UnitTypes
		{
			[CompilerGenerated]
			get
			{
				return this.dataView_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataView_2 == value)
				{
					return;
				}
				this.dataView_2 = value;
				this.vmethod_0("UnitTypes");
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06006663 RID: 26211 RVA: 0x00040C1B File Offset: 0x0003EE1B
		// (set) Token: 0x06006664 RID: 26212 RVA: 0x00040C23 File Offset: 0x0003EE23
		public long SelectedUnitTypeID
		{
			get
			{
				return this.long_2;
			}
			set
			{
				if (this.long_2 != value)
				{
					this.long_2 = value;
					this.vmethod_0("SelectedUnitTypeID");
					this.method_0();
				}
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06006665 RID: 26213 RVA: 0x00040C46 File Offset: 0x0003EE46
		// (set) Token: 0x06006666 RID: 26214 RVA: 0x00040C4E File Offset: 0x0003EE4E
		public bool ShowHypothetical
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.bool_0 == value)
				{
					return;
				}
				this.bool_0 = value;
				this.vmethod_0("ShowHypothetical");
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06006667 RID: 26215 RVA: 0x00040C6E File Offset: 0x0003EE6E
		// (set) Token: 0x06006668 RID: 26216 RVA: 0x00385604 File Offset: 0x00383804
		public DatabaseControlTypeViewModel SelectedType
		{
			get
			{
				return this.databaseControlTypeViewModel_0;
			}
			set
			{
				if (this.databaseControlTypeViewModel_0 == value)
				{
					return;
				}
				bool flag = false;
				if (this.databaseControlTypeViewModel_0 == null)
				{
					flag = true;
				}
				else if (value != null && Operators.CompareString(this.databaseControlTypeViewModel_0.Name, value.Name, false) != 0)
				{
					flag = true;
				}
				if (flag)
				{
					this.databaseControlTypeViewModel_0 = value;
					this.vmethod_0("SelectedType");
					this.SelectedObjectType = value.Name;
					this.method_0();
				}
			}
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x00385670 File Offset: 0x00383870
		public void method_0()
		{
			if (!this.bool_1)
			{
				this.bool_1 = true;
				if (this.Types == null)
				{
					this.Types = new List<DatabaseControlTypeViewModel>();
					this.Types.Add(new DatabaseControlTypeViewModel
					{
						Name = "Aircraft"
					});
					this.Types.Add(new DatabaseControlTypeViewModel
					{
						Name = "Ship"
					});
					this.Types.Add(new DatabaseControlTypeViewModel
					{
						Name = "Submarine"
					});
					this.Types.Add(new DatabaseControlTypeViewModel
					{
						Name = "Facility"
					});
					this.Types.Add(new DatabaseControlTypeViewModel
					{
						Name = "Satellite"
					});
					this.Types.Add(new DatabaseControlTypeViewModel
					{
						Name = "Weapon"
					});
				}
				if (string.IsNullOrWhiteSpace(this.SelectedObjectType))
				{
					this.SelectedObjectType = "Aircraft";
				}
				this.SelectedType = Enumerable.FirstOrDefault<DatabaseControlTypeViewModel>(this.Types, new Func<DatabaseControlTypeViewModel, bool>(this.method_1));
				this.Countries = Client.smethod_46().Cache_OperatorCountries_DT.DefaultView;
				if (this.SelectedCountryID == 0L)
				{
					this.SelectedCountryID = 1001L;
				}
				string text = "";
				string selectedObjectType = this.SelectedObjectType;
				if (Operators.CompareString(selectedObjectType, "Aircraft", false) != 0 && Operators.CompareString(selectedObjectType, "Ship", false) != 0 && Operators.CompareString(selectedObjectType, "Submarine", false) != 0 && Operators.CompareString(selectedObjectType, "Satellite", false) != 0 && Operators.CompareString(selectedObjectType, "Weapon", false) != 0)
				{
					if (Operators.CompareString(selectedObjectType, "Facility", false) == 0)
					{
						text = string.Format("SELECT ID, Description from Enum{0}Category ORDER BY CASE WHEN ID >= 2000 THEN Description END ASC, CASE WHEN ID < 2000 THEN ID END ASC ", this.SelectedObjectType);
					}
				}
				else
				{
					text = string.Format("SELECT ID, Description from Enum{0}Type ORDER BY CASE WHEN ID >= 2000 THEN Description END ASC, CASE WHEN ID < 2000 THEN ID END ASC ", this.SelectedObjectType);
				}
				this.UnitTypes = Class401.smethod_1(new Class403(Client.smethod_46().method_39()), text).DefaultView;
				if (this.SelectedUnitTypeID == 0L)
				{
					this.SelectedUnitTypeID = 1001L;
				}
				string name = this.SelectedType.Name;
				DataTable table;
				if (Operators.CompareString(name, "Aircraft", false) != 0)
				{
					if (Operators.CompareString(name, "Ship", false) != 0)
					{
						if (Operators.CompareString(name, "Submarine", false) != 0)
						{
							if (Operators.CompareString(name, "Facility", false) != 0)
							{
								if (Operators.CompareString(name, "Satellite", false) != 0)
								{
									if (Operators.CompareString(name, "Weapon", false) != 0)
									{
										throw new Exception();
									}
									table = Client.smethod_46().Cache_Weapons_DT;
								}
								else
								{
									table = Client.smethod_46().Cache_Satellites_DT;
								}
							}
							else
							{
								table = Client.smethod_46().Cache_Facilities_DT;
							}
						}
						else
						{
							table = Client.smethod_46().Cache_Subs_DT;
						}
					}
					else
					{
						table = Client.smethod_46().Cache_Ships_DT;
					}
				}
				else
				{
					table = Client.smethod_46().Cache_Aircraft_DT;
				}
				DataView dataView = new DataView(table);
				dataView.Sort = "LongName ASC";
				if (!string.IsNullOrWhiteSpace(this.SearchString) || this.SelectedCountryID != 1001L || this.SelectedUnitTypeID != 1001L)
				{
					string text2 = "1=1 ";
					if (!string.IsNullOrWhiteSpace(this.SearchString))
					{
						string arg = this.SearchString.Replace("'", "''");
						text2 += string.Format(" AND LongName LIKE '%{0}%' ", arg);
					}
					if (this.SelectedCountryID != 1001L)
					{
						text2 += string.Format(" AND OperatorCountry={0}", this.SelectedCountryID);
					}
					if (!this.ShowHypothetical)
					{
						text2 += " AND Hypothetical=FALSE";
					}
					text2 = text2.Replace("[", "[[");
					text2 = text2.Replace("]", "]]");
					text2 = text2.Replace("[[", "[[]");
					text2 = text2.Replace("]]", "[]]");
					dataView.RowFilter = text2;
				}
				this.UnitsDataView = dataView;
				object obj = DatabaseControlViewModel.object_0;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				lock (obj)
				{
					if (this.SelectedObjectID == 0)
					{
						this.DatabaseControl.WebBrowser1.NavigateToString("<html><body style='background-color:#555555;color:white;'></body></html>");
					}
					else
					{
						Class2413.smethod_2().method_31().string_0 = this.SelectedObjectType;
						Class2413.smethod_2().method_31().int_0 = this.SelectedObjectID;
						Class2413.smethod_2().method_31().string_1 = this.HighlightTarget;
						Class2413.smethod_2().method_31().method_4(false, false);
						this.SelectedObjectName = Class2413.smethod_2().method_31().string_4;
						this.WindowTitle = string.Format("DB: {0}", this.SelectedObjectName);
						this.DatabaseControl.WebBrowser1.NavigateToString(string.Format("<html><body style='background-color:#555555;color:white;'>{0}</body></html>", Class2413.smethod_2().method_31().string_2));
					}
				}
				this.bool_1 = false;
			}
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x00040C76 File Offset: 0x0003EE76
		[CompilerGenerated]
		private bool method_1(DatabaseControlTypeViewModel F)
		{
			return Operators.CompareString(F.Name, this.SelectedObjectType, false) == 0;
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x0600666B RID: 26219 RVA: 0x00385B4C File Offset: 0x00383D4C
		// (remove) Token: 0x0600666C RID: 26220 RVA: 0x00385B84 File Offset: 0x00383D84
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

		// Token: 0x0600666D RID: 26221 RVA: 0x00385BBC File Offset: 0x00383DBC
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003A5A RID: 14938
		public static object object_0 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04003A5B RID: 14939
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003A5C RID: 14940
		[CompilerGenerated]
		private DatabaseControl databaseControl_0;

		// Token: 0x04003A5D RID: 14941
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04003A5E RID: 14942
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003A5F RID: 14943
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04003A60 RID: 14944
		[CompilerGenerated]
		private string string_3;

		// Token: 0x04003A61 RID: 14945
		[CompilerGenerated]
		private List<DatabaseControlTypeViewModel> list_0;

		// Token: 0x04003A62 RID: 14946
		[CompilerGenerated]
		private DataView dataView_0;

		// Token: 0x04003A63 RID: 14947
		private long long_0;

		// Token: 0x04003A64 RID: 14948
		private long long_1;

		// Token: 0x04003A65 RID: 14949
		[CompilerGenerated]
		private DataView dataView_1;

		// Token: 0x04003A66 RID: 14950
		private string string_4;

		// Token: 0x04003A67 RID: 14951
		[CompilerGenerated]
		private DataView dataView_2;

		// Token: 0x04003A68 RID: 14952
		private long long_2;

		// Token: 0x04003A69 RID: 14953
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003A6A RID: 14954
		private DatabaseControlTypeViewModel databaseControlTypeViewModel_0;

		// Token: 0x04003A6B RID: 14955
		private bool bool_1;

		// Token: 0x04003A6C RID: 14956
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
