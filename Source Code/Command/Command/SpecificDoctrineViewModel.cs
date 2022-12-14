using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Command_Core;
using ns14;
using ns7;

namespace Command
{
	// Token: 0x02000D8E RID: 3470
	[Attribute3]
	[Attribute0]
	[Attribute2]
	public sealed class SpecificDoctrineViewModel : INotifyPropertyChanged
	{
		// Token: 0x06005CCA RID: 23754 RVA: 0x0032E330 File Offset: 0x0032C530
		public SpecificDoctrineViewModel(string doctrineName, string doctrineGroup, Action<Doctrine, ComboBox, Scenario> PopulateAction, Action<Doctrine, ComboBox, Scenario> SelectionChangedAction, Func<Doctrine, Scenario, bool> PlayerEditableFunc)
		{
			this.SelectionChangedCommand = new Class2569(new Action<object>(this.method_0));
			this.DoctrineName = doctrineName;
			this.DoctrineGroup = doctrineGroup;
			this.action_0 = PopulateAction;
			this.action_1 = SelectionChangedAction;
			this.func_0 = PlayerEditableFunc;
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06005CCB RID: 23755 RVA: 0x0003B976 File Offset: 0x00039B76
		// (set) Token: 0x06005CCC RID: 23756 RVA: 0x0003B97E File Offset: 0x00039B7E
		public Class2569 SelectionChangedCommand
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
				this.vmethod_0("SelectionChangedCommand");
			}
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x0032E380 File Offset: 0x0032C580
		[Attribute2]
		[Attribute0]
		public void SelectionChanged()
		{
			if (this.activeUnit_0 != null && this.comboBox_0 != null && Client.smethod_46() != null && this.activeUnit_0.doctrine_0 != null)
			{
				this.comboBox_0.SelectedIndex = this.SelectedIndex;
				this.action_1(this.activeUnit_0.doctrine_0, this.comboBox_0, Client.smethod_46());
			}
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x0032E3E4 File Offset: 0x0032C5E4
		[Attribute2]
		[Attribute0]
		public void Refresh()
		{
			try
			{
				if (this.activeUnit_0 != null)
				{
					if (this.comboBox_0 == null)
					{
						this.comboBox_0 = new ComboBox();
						int num = 1;
						do
						{
							this.comboBox_0.Items.Add("Dummy");
							num++;
						}
						while (num <= 25);
					}
					int num2 = 5;
					do
					{
						num2--;
						if (num2 < 0)
						{
							break;
						}
						this.action_0(this.activeUnit_0.doctrine_0, this.comboBox_0, Client.smethod_46());
						this.DataTable = (DataTable)this.comboBox_0.DataSource;
						this.SelectedIndex = this.comboBox_0.SelectedIndex;
					}
					while (this.SelectedIndex == -1);
					this.IsEnabled = this.func_0(this.activeUnit_0.doctrine_0, Client.smethod_46());
				}
			}
			catch (Exception ex)
			{
				this.comboBox_0 = null;
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06005CCF RID: 23759 RVA: 0x0003B99E File Offset: 0x00039B9E
		// (set) Token: 0x06005CD0 RID: 23760 RVA: 0x0003B9A6 File Offset: 0x00039BA6
		public DataTable DataTable
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
				this.vmethod_0("DataTable");
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06005CD1 RID: 23761 RVA: 0x0003B9C6 File Offset: 0x00039BC6
		// (set) Token: 0x06005CD2 RID: 23762 RVA: 0x0003B9CE File Offset: 0x00039BCE
		public int SelectedIndex
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
				this.vmethod_0("SelectedIndex");
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06005CD3 RID: 23763 RVA: 0x0003B9EE File Offset: 0x00039BEE
		// (set) Token: 0x06005CD4 RID: 23764 RVA: 0x0003B9F6 File Offset: 0x00039BF6
		public bool IsEnabled
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
				this.vmethod_0("IsEnabled");
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06005CD5 RID: 23765 RVA: 0x0003BA16 File Offset: 0x00039C16
		// (set) Token: 0x06005CD6 RID: 23766 RVA: 0x0003BA1E File Offset: 0x00039C1E
		public string DoctrineName
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
				this.vmethod_0("DoctrineName");
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06005CD7 RID: 23767 RVA: 0x0003BA42 File Offset: 0x00039C42
		// (set) Token: 0x06005CD8 RID: 23768 RVA: 0x0003BA4A File Offset: 0x00039C4A
		public string DoctrineGroup
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
				this.vmethod_0("DoctrineGroup");
			}
		}

		// Token: 0x06005CD9 RID: 23769 RVA: 0x0003BA6E File Offset: 0x00039C6E
		[CompilerGenerated]
		private void method_0(object a0)
		{
			this.SelectionChanged();
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06005CDA RID: 23770 RVA: 0x0032E4E8 File Offset: 0x0032C6E8
		// (remove) Token: 0x06005CDB RID: 23771 RVA: 0x0032E520 File Offset: 0x0032C720
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

		// Token: 0x06005CDC RID: 23772 RVA: 0x0032E558 File Offset: 0x0032C758
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400360C RID: 13836
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x0400360D RID: 13837
		public ActiveUnit activeUnit_0;

		// Token: 0x0400360E RID: 13838
		[CompilerGenerated]
		private DataTable dataTable_0;

		// Token: 0x0400360F RID: 13839
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003610 RID: 13840
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003611 RID: 13841
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003612 RID: 13842
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04003613 RID: 13843
		private ComboBox comboBox_0;

		// Token: 0x04003614 RID: 13844
		private Action<Doctrine, ComboBox, Scenario> action_0;

		// Token: 0x04003615 RID: 13845
		private Action<Doctrine, ComboBox, Scenario> action_1;

		// Token: 0x04003616 RID: 13846
		private Func<Doctrine, Scenario, bool> func_0;

		// Token: 0x04003617 RID: 13847
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
