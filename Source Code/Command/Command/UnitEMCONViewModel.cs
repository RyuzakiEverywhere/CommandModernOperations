using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using ns14;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000D90 RID: 3472
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class UnitEMCONViewModel : INotifyPropertyChanged
	{
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06005CE6 RID: 23782 RVA: 0x0003BAC6 File Offset: 0x00039CC6
		// (set) Token: 0x06005CE7 RID: 23783 RVA: 0x0003BACE File Offset: 0x00039CCE
		public InvertableBool Inherit
		{
			[CompilerGenerated]
			get
			{
				return this.invertableBool_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.invertableBool_0 == value)
				{
					return;
				}
				this.invertableBool_0 = value;
				this.vmethod_0("Inherit");
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06005CE8 RID: 23784 RVA: 0x0003BAEE File Offset: 0x00039CEE
		// (set) Token: 0x06005CE9 RID: 23785 RVA: 0x0003BAF6 File Offset: 0x00039CF6
		public InvertableBool RadarActive
		{
			[CompilerGenerated]
			get
			{
				return this.invertableBool_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.invertableBool_1 == value)
				{
					return;
				}
				this.invertableBool_1 = value;
				this.vmethod_0("RadarActive");
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06005CEA RID: 23786 RVA: 0x0003BB16 File Offset: 0x00039D16
		// (set) Token: 0x06005CEB RID: 23787 RVA: 0x0003BB1E File Offset: 0x00039D1E
		public InvertableBool SonarActive
		{
			[CompilerGenerated]
			get
			{
				return this.invertableBool_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.invertableBool_2 == value)
				{
					return;
				}
				this.invertableBool_2 = value;
				this.vmethod_0("SonarActive");
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06005CEC RID: 23788 RVA: 0x0003BB3E File Offset: 0x00039D3E
		// (set) Token: 0x06005CED RID: 23789 RVA: 0x0003BB46 File Offset: 0x00039D46
		public InvertableBool OECMActive
		{
			[CompilerGenerated]
			get
			{
				return this.invertableBool_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.invertableBool_3 == value)
				{
					return;
				}
				this.invertableBool_3 = value;
				this.vmethod_0("OECMActive");
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06005CEE RID: 23790 RVA: 0x0032E6CC File Offset: 0x0032C8CC
		// (remove) Token: 0x06005CEF RID: 23791 RVA: 0x0032E700 File Offset: 0x0032C900
		public static event UnitEMCONViewModel.Delegate84 SensorsFormRequested
		{
			[CompilerGenerated]
			add
			{
				UnitEMCONViewModel.Delegate84 @delegate = UnitEMCONViewModel.delegate84_0;
				UnitEMCONViewModel.Delegate84 delegate2;
				do
				{
					delegate2 = @delegate;
					UnitEMCONViewModel.Delegate84 value2 = (UnitEMCONViewModel.Delegate84)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<UnitEMCONViewModel.Delegate84>(ref UnitEMCONViewModel.delegate84_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				UnitEMCONViewModel.Delegate84 @delegate = UnitEMCONViewModel.delegate84_0;
				UnitEMCONViewModel.Delegate84 delegate2;
				do
				{
					delegate2 = @delegate;
					UnitEMCONViewModel.Delegate84 value2 = (UnitEMCONViewModel.Delegate84)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<UnitEMCONViewModel.Delegate84>(ref UnitEMCONViewModel.delegate84_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06005CF0 RID: 23792 RVA: 0x0003BB66 File Offset: 0x00039D66
		// (set) Token: 0x06005CF1 RID: 23793 RVA: 0x0003BB6E File Offset: 0x00039D6E
		public InvertableBool ObeysEMCON
		{
			[CompilerGenerated]
			get
			{
				return this.invertableBool_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.invertableBool_4 == value)
				{
					return;
				}
				this.invertableBool_4 = value;
				this.vmethod_0("ObeysEMCON");
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06005CF2 RID: 23794 RVA: 0x0003BB8E File Offset: 0x00039D8E
		// (set) Token: 0x06005CF3 RID: 23795 RVA: 0x0003BB96 File Offset: 0x00039D96
		public Class2569 UpdateEMCONCommand
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
				this.vmethod_0("UpdateEMCONCommand");
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06005CF4 RID: 23796 RVA: 0x0003BBB6 File Offset: 0x00039DB6
		// (set) Token: 0x06005CF5 RID: 23797 RVA: 0x0003BBBE File Offset: 0x00039DBE
		public Class2569 EMCONWindowCommand
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
				this.vmethod_0("EMCONWindowCommand");
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06005CF6 RID: 23798 RVA: 0x0003BBDE File Offset: 0x00039DDE
		// (set) Token: 0x06005CF7 RID: 23799 RVA: 0x0003BBE6 File Offset: 0x00039DE6
		public Class2569 SensorsWindowCommand
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
				this.vmethod_0("SensorsWindowCommand");
			}
		}

		// Token: 0x06005CF8 RID: 23800 RVA: 0x0003BC06 File Offset: 0x00039E06
		public void method_0()
		{
			DoctrineForm doctrineForm = new DoctrineForm();
			doctrineForm.class310_0 = this.activeUnit_0;
			doctrineForm.Show();
			doctrineForm.vmethod_0().SelectedIndex = 1;
		}

		// Token: 0x06005CF9 RID: 23801 RVA: 0x0032E734 File Offset: 0x0032C934
		public void method_1()
		{
			UnitEMCONViewModel.Delegate84 @delegate = UnitEMCONViewModel.delegate84_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06005CFA RID: 23802 RVA: 0x0032E750 File Offset: 0x0032C950
		public void method_2()
		{
			this.ObeysEMCON = InvertableBool.smethod_0(this.activeUnit_0.vmethod_88().vmethod_3());
			if (InvertableBool.smethod_1(this.Inherit))
			{
				this.activeUnit_0.doctrine_0.method_8(true);
				this.RadarActive = InvertableBool.smethod_0(this.activeUnit_0.doctrine_0.method_6(Client.smethod_46()).method_1() > Doctrine.Class275.Enum66.const_0);
				this.SonarActive = InvertableBool.smethod_0(this.activeUnit_0.doctrine_0.method_6(Client.smethod_46()).method_2() > Doctrine.Class275.Enum66.const_0);
				this.OECMActive = InvertableBool.smethod_0(this.activeUnit_0.doctrine_0.method_6(Client.smethod_46()).method_3() > Doctrine.Class275.Enum66.const_0);
			}
			else
			{
				this.activeUnit_0.doctrine_0.method_8(false);
				this.activeUnit_0.doctrine_0.method_192(InvertableBool.smethod_1(this.RadarActive) ? Doctrine.Class275.Enum66.const_1 : Doctrine.Class275.Enum66.const_0, Client.smethod_46());
				this.activeUnit_0.doctrine_0.method_193(InvertableBool.smethod_1(this.SonarActive) ? Doctrine.Class275.Enum66.const_1 : Doctrine.Class275.Enum66.const_0, Client.smethod_46());
				this.activeUnit_0.doctrine_0.method_194(InvertableBool.smethod_1(this.OECMActive) ? Doctrine.Class275.Enum66.const_1 : Doctrine.Class275.Enum66.const_0, Client.smethod_46());
			}
			this.activeUnit_0.doctrine_0.method_2(this.activeUnit_0, new bool?(false), false, false, true, false);
			Class2413.smethod_2().method_41().vmethod_796().Focus();
			Client.bool_1 = true;
		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x0032E8D4 File Offset: 0x0032CAD4
		public void method_3()
		{
			this.Inherit = InvertableBool.smethod_0(this.activeUnit_0.doctrine_0.method_7());
			this.ObeysEMCON = InvertableBool.smethod_0(this.activeUnit_0.vmethod_88().vmethod_3());
			this.RadarActive = InvertableBool.smethod_0(this.activeUnit_0.doctrine_0.method_6(Client.smethod_46()).method_1() > Doctrine.Class275.Enum66.const_0);
			this.SonarActive = InvertableBool.smethod_0(this.activeUnit_0.doctrine_0.method_6(Client.smethod_46()).method_2() > Doctrine.Class275.Enum66.const_0);
			this.OECMActive = InvertableBool.smethod_0(this.activeUnit_0.doctrine_0.method_6(Client.smethod_46()).method_3() > Doctrine.Class275.Enum66.const_0);
		}

		// Token: 0x06005CFC RID: 23804 RVA: 0x0032E990 File Offset: 0x0032CB90
		public UnitEMCONViewModel(ActiveUnit theUnit)
		{
			this.UpdateEMCONCommand = new Class2569(new Action<object>(this.method_4));
			this.EMCONWindowCommand = new Class2569(new Action<object>(this.method_5));
			this.SensorsWindowCommand = new Class2569(new Action<object>(this.method_6));
			try
			{
				this.activeUnit_0 = theUnit;
				this.method_3();
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005CFD RID: 23805 RVA: 0x0003BC2A File Offset: 0x00039E2A
		[CompilerGenerated]
		private void method_4(object a0)
		{
			this.method_2();
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x0003BC32 File Offset: 0x00039E32
		[CompilerGenerated]
		private void method_5(object a0)
		{
			this.method_0();
		}

		// Token: 0x06005CFF RID: 23807 RVA: 0x0003BC3A File Offset: 0x00039E3A
		[CompilerGenerated]
		private void method_6(object a0)
		{
			this.method_1();
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06005D00 RID: 23808 RVA: 0x0032EA24 File Offset: 0x0032CC24
		// (remove) Token: 0x06005D01 RID: 23809 RVA: 0x0032EA5C File Offset: 0x0032CC5C
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

		// Token: 0x06005D02 RID: 23810 RVA: 0x0032EA94 File Offset: 0x0032CC94
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400361C RID: 13852
		[CompilerGenerated]
		private InvertableBool invertableBool_0;

		// Token: 0x0400361D RID: 13853
		[CompilerGenerated]
		private InvertableBool invertableBool_1;

		// Token: 0x0400361E RID: 13854
		[CompilerGenerated]
		private InvertableBool invertableBool_2;

		// Token: 0x0400361F RID: 13855
		[CompilerGenerated]
		private InvertableBool invertableBool_3;

		// Token: 0x04003620 RID: 13856
		[CompilerGenerated]
		private static UnitEMCONViewModel.Delegate84 delegate84_0;

		// Token: 0x04003621 RID: 13857
		[CompilerGenerated]
		private InvertableBool invertableBool_4;

		// Token: 0x04003622 RID: 13858
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x04003623 RID: 13859
		[CompilerGenerated]
		private Class2569 class2569_1;

		// Token: 0x04003624 RID: 13860
		[CompilerGenerated]
		private Class2569 class2569_2;

		// Token: 0x04003625 RID: 13861
		public ActiveUnit activeUnit_0;

		// Token: 0x04003626 RID: 13862
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000D91 RID: 3473
		// (Invoke) Token: 0x06005D06 RID: 23814
		internal delegate void Delegate84();
	}
}
