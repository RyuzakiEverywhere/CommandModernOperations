using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns2;
using ns3;
using ns4;

namespace Command
{
	// Token: 0x02000ECF RID: 3791
	[DesignerGenerated]
	public sealed class UnitFilter : Control7
	{
		// Token: 0x060083B0 RID: 33712 RVA: 0x0004FDC0 File Offset: 0x0004DFC0
		public UnitFilter()
		{
			base.Load += this.UnitFilter_Load;
			this.InitializeComponent();
		}

		// Token: 0x060083B1 RID: 33713 RVA: 0x0046CB78 File Offset: 0x0046AD78
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_1 != null)
				{
					this.icontainer_1.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060083B2 RID: 33714 RVA: 0x0046CBB8 File Offset: 0x0046ADB8
		private void InitializeComponent()
		{
			this.vmethod_1(new Class116());
			this.vmethod_3(new Class2451());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Class116());
			this.vmethod_11(new Class116());
			this.vmethod_13(new Class2451());
			this.vmethod_15(new Class2451());
			this.vmethod_17(new Class2451());
			this.vmethod_19(new Class2451());
			base.SuspendLayout();
			this.vmethod_0().method_2(true);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(13, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(63, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Target side:";
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_2().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_2().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Location = new Point(102, 10);
			this.vmethod_2().Name = "CB_TargetSide";
			this.vmethod_2().Size = new Size(196, 21);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().method_2(true);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(13, 46);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new Size(64, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Target type:";
			this.vmethod_6().method_2(true);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(13, 79);
			this.vmethod_6().Name = "Label3";
			this.vmethod_6().Size = new Size(81, 13);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "Target subtype:";
			this.vmethod_8().method_2(true);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(13, 111);
			this.vmethod_8().Name = "Label4";
			this.vmethod_8().Size = new Size(68, 13);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "Target class:";
			this.vmethod_10().method_2(true);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Location = new Point(13, 146);
			this.vmethod_10().Name = "Label5";
			this.vmethod_10().Size = new Size(68, 13);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_10().Text = "Specific unit:";
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_12().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_12().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_12().FormattingEnabled = true;
			this.vmethod_12().Items.AddRange(new object[]
			{
				"None",
				"Aircraft",
				"Surface Ship",
				"Submarine",
				"Land facility",
				"Aimpoint / mobile unit [INOPERATIVE]",
				"Weapon",
				"Satellite"
			});
			this.vmethod_12().Location = new Point(102, 43);
			this.vmethod_12().Name = "CB_TargetType";
			this.vmethod_12().Size = new Size(196, 21);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_14().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_14().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_14().FormattingEnabled = true;
			this.vmethod_14().Location = new Point(102, 76);
			this.vmethod_14().Name = "CB_TargetSubtype";
			this.vmethod_14().Size = new Size(196, 21);
			this.vmethod_14().TabIndex = 7;
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_16().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_16().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_16().FormattingEnabled = true;
			this.vmethod_16().Location = new Point(102, 108);
			this.vmethod_16().Name = "CB_TargetUnitClass";
			this.vmethod_16().Size = new Size(196, 21);
			this.vmethod_16().TabIndex = 8;
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_18().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_18().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_18().FormattingEnabled = true;
			this.vmethod_18().Location = new Point(102, 143);
			this.vmethod_18().Name = "CB_SpecificUnit";
			this.vmethod_18().Size = new Size(196, 21);
			this.vmethod_18().TabIndex = 9;
			base.AutoScaleMode = AutoScaleMode.None;
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.Name = "UnitFilter";
			base.Size = new Size(311, 177);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060083B3 RID: 33715 RVA: 0x0004FDE0 File Offset: 0x0004DFE0
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x060083B4 RID: 33716 RVA: 0x0004FDE8 File Offset: 0x0004DFE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_5)
		{
			this.class116_0 = class116_5;
		}

		// Token: 0x060083B5 RID: 33717 RVA: 0x0004FDF1 File Offset: 0x0004DFF1
		[CompilerGenerated]
		internal Class2451 vmethod_2()
		{
			return this.class2451_0;
		}

		// Token: 0x060083B6 RID: 33718 RVA: 0x0046D2FC File Offset: 0x0046B4FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class2451 class2451_5)
		{
			EventHandler value = new EventHandler(this.method_10);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_5;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060083B7 RID: 33719 RVA: 0x0004FDF9 File Offset: 0x0004DFF9
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x060083B8 RID: 33720 RVA: 0x0004FE01 File Offset: 0x0004E001
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_5)
		{
			this.class116_1 = class116_5;
		}

		// Token: 0x060083B9 RID: 33721 RVA: 0x0004FE0A File Offset: 0x0004E00A
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_2;
		}

		// Token: 0x060083BA RID: 33722 RVA: 0x0004FE12 File Offset: 0x0004E012
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_5)
		{
			this.class116_2 = class116_5;
		}

		// Token: 0x060083BB RID: 33723 RVA: 0x0004FE1B File Offset: 0x0004E01B
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_3;
		}

		// Token: 0x060083BC RID: 33724 RVA: 0x0004FE23 File Offset: 0x0004E023
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_5)
		{
			this.class116_3 = class116_5;
		}

		// Token: 0x060083BD RID: 33725 RVA: 0x0004FE2C File Offset: 0x0004E02C
		[CompilerGenerated]
		internal Class116 vmethod_10()
		{
			return this.class116_4;
		}

		// Token: 0x060083BE RID: 33726 RVA: 0x0004FE34 File Offset: 0x0004E034
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class116 class116_5)
		{
			this.class116_4 = class116_5;
		}

		// Token: 0x060083BF RID: 33727 RVA: 0x0004FE3D File Offset: 0x0004E03D
		[CompilerGenerated]
		internal Class2451 vmethod_12()
		{
			return this.class2451_1;
		}

		// Token: 0x060083C0 RID: 33728 RVA: 0x0046D340 File Offset: 0x0046B540
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class2451 class2451_5)
		{
			EventHandler value = new EventHandler(this.method_7);
			Class2451 @class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_1 = class2451_5;
			@class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x0004FE45 File Offset: 0x0004E045
		[CompilerGenerated]
		internal Class2451 vmethod_14()
		{
			return this.class2451_2;
		}

		// Token: 0x060083C2 RID: 33730 RVA: 0x0046D384 File Offset: 0x0046B584
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class2451 class2451_5)
		{
			EventHandler value = new EventHandler(this.method_8);
			Class2451 @class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_2 = class2451_5;
			@class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060083C3 RID: 33731 RVA: 0x0004FE4D File Offset: 0x0004E04D
		[CompilerGenerated]
		internal Class2451 vmethod_16()
		{
			return this.class2451_3;
		}

		// Token: 0x060083C4 RID: 33732 RVA: 0x0046D3C8 File Offset: 0x0046B5C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class2451 class2451_5)
		{
			EventHandler value = new EventHandler(this.method_9);
			Class2451 @class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_3 = class2451_5;
			@class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060083C5 RID: 33733 RVA: 0x0004FE55 File Offset: 0x0004E055
		[CompilerGenerated]
		internal Class2451 vmethod_18()
		{
			return this.class2451_4;
		}

		// Token: 0x060083C6 RID: 33734 RVA: 0x0046D40C File Offset: 0x0046B60C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class2451 class2451_5)
		{
			EventHandler value = new EventHandler(this.method_11);
			Class2451 @class = this.class2451_4;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_4 = class2451_5;
			@class = this.class2451_4;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060083C7 RID: 33735 RVA: 0x0004FE5D File Offset: 0x0004E05D
		public GlobalVariables.ActiveUnitType method_1()
		{
			return (GlobalVariables.ActiveUnitType)this.vmethod_12().SelectedIndex;
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x0004FE6B File Offset: 0x0004E06B
		public void method_2(Class349 class349_1)
		{
			bool flag = class349_1 != this.class349_0;
			this.class349_0 = class349_1;
			if (flag)
			{
				this.method_3();
			}
		}

		// Token: 0x060083C9 RID: 33737 RVA: 0x0046D450 File Offset: 0x0046B650
		private void method_3()
		{
			if (!Information.IsNothing(Client.smethod_46()) && !Information.IsNothing(this.class349_0))
			{
				this.vmethod_2().Items.Clear();
				this.vmethod_2().DisplayMember = "Content";
				foreach (Side side in Client.smethod_46().method_44())
				{
					ComboBoxItem comboBoxItem = new ComboBoxItem();
					comboBoxItem.Content = side.method_51();
					comboBoxItem.Tag = side.string_0;
					this.vmethod_2().Items.Add(comboBoxItem);
				}
				if (string.IsNullOrEmpty(this.class349_0.string_2))
				{
					this.vmethod_2().SelectedIndex = -1;
				}
				else
				{
					try
					{
						foreach (object obj in this.vmethod_2().Items)
						{
							ComboBoxItem comboBoxItem2 = (ComboBoxItem)obj;
							if (Operators.CompareString(Conversions.ToString(comboBoxItem2.Tag), this.class349_0.string_2, false) == 0)
							{
								this.vmethod_2().SelectedItem = comboBoxItem2;
								break;
							}
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
					if (this.vmethod_2().SelectedItem == null)
					{
						return;
					}
				}
				if (this.class349_0.activeUnitType_0 != GlobalVariables.ActiveUnitType.None)
				{
					this.vmethod_12().SelectedIndex = (int)this.class349_0.activeUnitType_0;
					this.method_4();
					try
					{
						foreach (object obj2 in this.vmethod_14().Items)
						{
							ComboBoxItem comboBoxItem3 = (ComboBoxItem)obj2;
							if (this.class349_0.int_0 == Conversions.ToInteger(comboBoxItem3.Tag))
							{
								this.vmethod_14().SelectedItem = comboBoxItem3;
								break;
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
					if (this.vmethod_14().SelectedItem != null)
					{
						this.method_5();
						try
						{
							foreach (object obj3 in this.vmethod_16().Items)
							{
								ComboBoxItem comboBoxItem4 = (ComboBoxItem)obj3;
								if (this.class349_0.int_1 == Conversions.ToInteger(comboBoxItem4.Tag))
								{
									this.vmethod_16().SelectedItem = comboBoxItem4;
									break;
								}
							}
						}
						finally
						{
							IEnumerator enumerator3;
							if (enumerator3 is IDisposable)
							{
								(enumerator3 as IDisposable).Dispose();
							}
						}
						if (this.vmethod_16().SelectedItem != null)
						{
							this.method_6();
							bool flag = false;
							if (!Information.IsNothing(this.class349_0.string_3))
							{
								try
								{
									foreach (object obj4 in this.vmethod_18().Items)
									{
										ComboBoxItem comboBoxItem5 = (ComboBoxItem)obj4;
										if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(comboBoxItem5.Tag)) && Operators.CompareString(this.class349_0.string_3, ((Class310)comboBoxItem5.Tag).string_0, false) == 0)
										{
											this.vmethod_18().SelectedItem = comboBoxItem5;
											flag = true;
											break;
										}
									}
								}
								finally
								{
									IEnumerator enumerator4;
									if (enumerator4 is IDisposable)
									{
										(enumerator4 as IDisposable).Dispose();
									}
								}
							}
							if (!flag & !Information.IsNothing(this.class349_0.string_3))
							{
								ComboBoxItem comboBoxItem6 = new ComboBoxItem();
								comboBoxItem6.Content = this.class349_0.string_3 + " [NOT FOUND!]";
								comboBoxItem6.Tag = this.class349_0.string_3;
								this.vmethod_18().Items.Add(comboBoxItem6);
								this.vmethod_18().SelectedItem = comboBoxItem6;
								DarkMessageBox.smethod_2("The specific unit does not exist in this scenario. Please select another unit.", "Error", Enum11.const_0);
							}
						}
					}
				}
			}
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x00044489 File Offset: 0x00042689
		private void UnitFilter_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x0046D81C File Offset: 0x0046BA1C
		private void method_4()
		{
			this.vmethod_14().Items.Clear();
			this.vmethod_14().DisplayMember = "Content";
			ComboBoxItem comboBoxItem = new ComboBoxItem();
			comboBoxItem.Content = "None";
			this.vmethod_14().Items.Add(comboBoxItem);
			switch (this.class349_0.activeUnitType_0)
			{
			case GlobalVariables.ActiveUnitType.None:
			case GlobalVariables.ActiveUnitType.Aimpoint:
				goto IL_785;
			case GlobalVariables.ActiveUnitType.Aircraft:
			{
				IEnumerable<ActiveUnit> enumerable = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, (UnitFilter._Closure$__.$I60-0 == null) ? (UnitFilter._Closure$__.$I60-0 = new Func<ActiveUnit, bool>(UnitFilter._Closure$__.$I.method_0)) : UnitFilter._Closure$__.$I60-0), (UnitFilter._Closure$__.$I60-1 == null) ? (UnitFilter._Closure$__.$I60-1 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_1)) : UnitFilter._Closure$__.$I60-1);
				if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)))
				{
					goto IL_785;
				}
				enumerable = Enumerable.Where<ActiveUnit>(enumerable, new Func<ActiveUnit, bool>(this.method_12));
				IEnumerable<Aircraft._AircraftType> enumerable2 = Enumerable.Distinct<Aircraft._AircraftType>(Enumerable.Select<ActiveUnit, Aircraft._AircraftType>(enumerable, (UnitFilter._Closure$__.$I60-3 == null) ? (UnitFilter._Closure$__.$I60-3 = new Func<ActiveUnit, Aircraft._AircraftType>(UnitFilter._Closure$__.$I.method_2)) : UnitFilter._Closure$__.$I60-3));
				try
				{
					foreach (Aircraft._AircraftType aircraftType in enumerable2)
					{
						ComboBoxItem comboBoxItem2 = new ComboBoxItem();
						comboBoxItem2.Content = aircraftType.ToString();
						comboBoxItem2.Tag = aircraftType;
						this.vmethod_14().Items.Add(comboBoxItem2);
					}
					goto IL_785;
				}
				finally
				{
					IEnumerator<Aircraft._AircraftType> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				break;
			}
			case GlobalVariables.ActiveUnitType.Ship:
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				goto IL_2D0;
			case GlobalVariables.ActiveUnitType.Facility:
				goto IL_3FE;
			case GlobalVariables.ActiveUnitType.Weapon:
				goto IL_52C;
			case GlobalVariables.ActiveUnitType.Satellite:
				goto IL_65A;
			default:
				goto IL_785;
			}
			IEnumerable<ActiveUnit> enumerable3 = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, (UnitFilter._Closure$__.$I60-4 == null) ? (UnitFilter._Closure$__.$I60-4 = new Func<ActiveUnit, bool>(UnitFilter._Closure$__.$I.method_3)) : UnitFilter._Closure$__.$I60-4), (UnitFilter._Closure$__.$I60-5 == null) ? (UnitFilter._Closure$__.$I60-5 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_4)) : UnitFilter._Closure$__.$I60-5);
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)))
			{
				goto IL_785;
			}
			enumerable3 = Enumerable.Where<ActiveUnit>(enumerable3, new Func<ActiveUnit, bool>(this.method_13));
			IEnumerable<Ship._ShipType> enumerable4 = Enumerable.Distinct<Ship._ShipType>(Enumerable.Select<ActiveUnit, Ship._ShipType>(enumerable3, (UnitFilter._Closure$__.$I60-7 == null) ? (UnitFilter._Closure$__.$I60-7 = new Func<ActiveUnit, Ship._ShipType>(UnitFilter._Closure$__.$I.method_5)) : UnitFilter._Closure$__.$I60-7));
			try
			{
				foreach (Ship._ShipType shipType in enumerable4)
				{
					ComboBoxItem comboBoxItem3 = new ComboBoxItem();
					comboBoxItem3.Content = shipType.ToString();
					comboBoxItem3.Tag = shipType;
					this.vmethod_14().Items.Add(comboBoxItem3);
				}
				goto IL_785;
			}
			finally
			{
				IEnumerator<Ship._ShipType> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			IL_2D0:
			IEnumerable<ActiveUnit> enumerable5 = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, (UnitFilter._Closure$__.$I60-8 == null) ? (UnitFilter._Closure$__.$I60-8 = new Func<ActiveUnit, bool>(UnitFilter._Closure$__.$I.method_6)) : UnitFilter._Closure$__.$I60-8), (UnitFilter._Closure$__.$I60-9 == null) ? (UnitFilter._Closure$__.$I60-9 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_7)) : UnitFilter._Closure$__.$I60-9);
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)))
			{
				goto IL_785;
			}
			enumerable5 = Enumerable.Where<ActiveUnit>(enumerable5, new Func<ActiveUnit, bool>(this.method_14));
			IEnumerable<Submarine._SubmarineType> enumerable6 = Enumerable.Distinct<Submarine._SubmarineType>(Enumerable.Select<ActiveUnit, Submarine._SubmarineType>(enumerable5, (UnitFilter._Closure$__.$I60-11 == null) ? (UnitFilter._Closure$__.$I60-11 = new Func<ActiveUnit, Submarine._SubmarineType>(UnitFilter._Closure$__.$I.method_8)) : UnitFilter._Closure$__.$I60-11));
			try
			{
				foreach (Submarine._SubmarineType submarineType in enumerable6)
				{
					ComboBoxItem comboBoxItem4 = new ComboBoxItem();
					comboBoxItem4.Content = submarineType.ToString();
					comboBoxItem4.Tag = submarineType;
					this.vmethod_14().Items.Add(comboBoxItem4);
				}
				goto IL_785;
			}
			finally
			{
				IEnumerator<Submarine._SubmarineType> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			IL_3FE:
			IEnumerable<ActiveUnit> enumerable7 = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, (UnitFilter._Closure$__.$I60-12 == null) ? (UnitFilter._Closure$__.$I60-12 = new Func<ActiveUnit, bool>(UnitFilter._Closure$__.$I.method_9)) : UnitFilter._Closure$__.$I60-12), (UnitFilter._Closure$__.$I60-13 == null) ? (UnitFilter._Closure$__.$I60-13 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_10)) : UnitFilter._Closure$__.$I60-13);
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)))
			{
				goto IL_785;
			}
			enumerable7 = Enumerable.Where<ActiveUnit>(enumerable7, new Func<ActiveUnit, bool>(this.method_15));
			IEnumerable<Facility._FacilityCategory> enumerable8 = Enumerable.Distinct<Facility._FacilityCategory>(Enumerable.Select<ActiveUnit, Facility._FacilityCategory>(enumerable7, (UnitFilter._Closure$__.$I60-15 == null) ? (UnitFilter._Closure$__.$I60-15 = new Func<ActiveUnit, Facility._FacilityCategory>(UnitFilter._Closure$__.$I.method_11)) : UnitFilter._Closure$__.$I60-15));
			try
			{
				foreach (Facility._FacilityCategory facilityCategory in enumerable8)
				{
					ComboBoxItem comboBoxItem5 = new ComboBoxItem();
					comboBoxItem5.Content = facilityCategory.ToString();
					comboBoxItem5.Tag = facilityCategory;
					this.vmethod_14().Items.Add(comboBoxItem5);
				}
				goto IL_785;
			}
			finally
			{
				IEnumerator<Facility._FacilityCategory> enumerator4;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
			}
			IL_52C:
			IEnumerable<ActiveUnit> enumerable9 = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, (UnitFilter._Closure$__.$I60-16 == null) ? (UnitFilter._Closure$__.$I60-16 = new Func<ActiveUnit, bool>(UnitFilter._Closure$__.$I.method_12)) : UnitFilter._Closure$__.$I60-16), (UnitFilter._Closure$__.$I60-17 == null) ? (UnitFilter._Closure$__.$I60-17 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_13)) : UnitFilter._Closure$__.$I60-17);
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)))
			{
				goto IL_785;
			}
			enumerable9 = Enumerable.Where<ActiveUnit>(enumerable9, new Func<ActiveUnit, bool>(this.method_16));
			IEnumerable<Weapon._WeaponType> enumerable10 = Enumerable.Distinct<Weapon._WeaponType>(Enumerable.Select<ActiveUnit, Weapon._WeaponType>(enumerable9, (UnitFilter._Closure$__.$I60-19 == null) ? (UnitFilter._Closure$__.$I60-19 = new Func<ActiveUnit, Weapon._WeaponType>(UnitFilter._Closure$__.$I.method_14)) : UnitFilter._Closure$__.$I60-19));
			try
			{
				foreach (Weapon._WeaponType weaponType in enumerable10)
				{
					ComboBoxItem comboBoxItem6 = new ComboBoxItem();
					comboBoxItem6.Content = weaponType.ToString();
					comboBoxItem6.Tag = weaponType;
					this.vmethod_14().Items.Add(comboBoxItem6);
				}
				goto IL_785;
			}
			finally
			{
				IEnumerator<Weapon._WeaponType> enumerator5;
				if (enumerator5 != null)
				{
					enumerator5.Dispose();
				}
			}
			IL_65A:
			IEnumerable<ActiveUnit> enumerable11 = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, (UnitFilter._Closure$__.$I60-20 == null) ? (UnitFilter._Closure$__.$I60-20 = new Func<ActiveUnit, bool>(UnitFilter._Closure$__.$I.method_15)) : UnitFilter._Closure$__.$I60-20), (UnitFilter._Closure$__.$I60-21 == null) ? (UnitFilter._Closure$__.$I60-21 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_16)) : UnitFilter._Closure$__.$I60-21);
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)))
			{
				enumerable11 = Enumerable.Where<ActiveUnit>(enumerable11, new Func<ActiveUnit, bool>(this.method_17));
				IEnumerable<Satellite._SatelliteType> enumerable12 = Enumerable.Distinct<Satellite._SatelliteType>(Enumerable.Select<ActiveUnit, Satellite._SatelliteType>(enumerable11, (UnitFilter._Closure$__.$I60-23 == null) ? (UnitFilter._Closure$__.$I60-23 = new Func<ActiveUnit, Satellite._SatelliteType>(UnitFilter._Closure$__.$I.method_17)) : UnitFilter._Closure$__.$I60-23));
				try
				{
					foreach (Satellite._SatelliteType satelliteType in enumerable12)
					{
						ComboBoxItem comboBoxItem7 = new ComboBoxItem();
						comboBoxItem7.Content = satelliteType.ToString();
						comboBoxItem7.Tag = satelliteType;
						this.vmethod_14().Items.Add(comboBoxItem7);
					}
				}
				finally
				{
					IEnumerator<Satellite._SatelliteType> enumerator6;
					if (enumerator6 != null)
					{
						enumerator6.Dispose();
					}
				}
			}
			IL_785:
			this.vmethod_14().SelectedIndex = 0;
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x0046E008 File Offset: 0x0046C208
		private void method_5()
		{
			this.vmethod_16().Items.Clear();
			this.vmethod_16().DisplayMember = "Content";
			ComboBoxItem comboBoxItem = new ComboBoxItem();
			comboBoxItem.Content = "None";
			this.vmethod_16().Items.Add(comboBoxItem);
			HashSet<int> hashSet = new HashSet<int>();
			switch (this.vmethod_12().SelectedIndex)
			{
			case 0:
			case 5:
				goto IL_8C5;
			case 1:
			{
				IEnumerable<ActiveUnit> enumerable = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, (UnitFilter._Closure$__.$I61-0 == null) ? (UnitFilter._Closure$__.$I61-0 = new Func<ActiveUnit, bool>(UnitFilter._Closure$__.$I.method_18)) : UnitFilter._Closure$__.$I61-0), (UnitFilter._Closure$__.$I61-1 == null) ? (UnitFilter._Closure$__.$I61-1 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_19)) : UnitFilter._Closure$__.$I61-1);
				if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
				{
					enumerable = Enumerable.Where<ActiveUnit>(enumerable, new Func<ActiveUnit, bool>(this.method_18));
				}
				try
				{
					foreach (ActiveUnit activeUnit in enumerable)
					{
						if (((Aircraft)activeUnit)._AircraftType_0 == (Aircraft._AircraftType)Conversions.ToInteger(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "Tag", new object[0], null, null, null)) && !hashSet.Contains(activeUnit.DBID))
						{
							hashSet.Add(activeUnit.DBID);
							ComboBoxItem comboBoxItem2 = new ComboBoxItem();
							comboBoxItem2.Content = activeUnit.string_2;
							comboBoxItem2.Tag = activeUnit.DBID;
							this.vmethod_16().Items.Add(comboBoxItem2);
						}
					}
					goto IL_8C5;
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				break;
			}
			case 2:
				break;
			case 3:
				goto IL_340;
			case 4:
				goto IL_4A2;
			case 6:
				goto IL_604;
			case 7:
				goto IL_766;
			default:
				goto IL_8C5;
			}
			IEnumerable<ActiveUnit> enumerable2 = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, (UnitFilter._Closure$__.$I61-3 == null) ? (UnitFilter._Closure$__.$I61-3 = new Func<ActiveUnit, bool>(UnitFilter._Closure$__.$I.method_20)) : UnitFilter._Closure$__.$I61-3), (UnitFilter._Closure$__.$I61-4 == null) ? (UnitFilter._Closure$__.$I61-4 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_21)) : UnitFilter._Closure$__.$I61-4);
			if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
			{
				enumerable2 = Enumerable.Where<ActiveUnit>(enumerable2, new Func<ActiveUnit, bool>(this.method_19));
			}
			try
			{
				foreach (ActiveUnit activeUnit2 in enumerable2)
				{
					if (((Ship)activeUnit2)._ShipType_0 == (Ship._ShipType)Conversions.ToInteger(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "Tag", new object[0], null, null, null)) && !hashSet.Contains(activeUnit2.DBID))
					{
						hashSet.Add(activeUnit2.DBID);
						ComboBoxItem comboBoxItem3 = new ComboBoxItem();
						comboBoxItem3.Content = activeUnit2.string_2;
						comboBoxItem3.Tag = activeUnit2.DBID;
						this.vmethod_16().Items.Add(comboBoxItem3);
					}
				}
				goto IL_8C5;
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			IL_340:
			IEnumerable<ActiveUnit> enumerable3 = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, (UnitFilter._Closure$__.$I61-6 == null) ? (UnitFilter._Closure$__.$I61-6 = new Func<ActiveUnit, bool>(UnitFilter._Closure$__.$I.method_22)) : UnitFilter._Closure$__.$I61-6), (UnitFilter._Closure$__.$I61-7 == null) ? (UnitFilter._Closure$__.$I61-7 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_23)) : UnitFilter._Closure$__.$I61-7);
			if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
			{
				enumerable3 = Enumerable.Where<ActiveUnit>(enumerable3, new Func<ActiveUnit, bool>(this.method_20));
			}
			try
			{
				foreach (ActiveUnit activeUnit3 in enumerable3)
				{
					if (((Submarine)activeUnit3)._SubmarineType_0 == (Submarine._SubmarineType)Conversions.ToInteger(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "Tag", new object[0], null, null, null)) && !hashSet.Contains(activeUnit3.DBID))
					{
						hashSet.Add(activeUnit3.DBID);
						ComboBoxItem comboBoxItem4 = new ComboBoxItem();
						comboBoxItem4.Content = activeUnit3.string_2;
						comboBoxItem4.Tag = activeUnit3.DBID;
						this.vmethod_16().Items.Add(comboBoxItem4);
					}
				}
				goto IL_8C5;
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			IL_4A2:
			IEnumerable<ActiveUnit> enumerable4 = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, (UnitFilter._Closure$__.$I61-9 == null) ? (UnitFilter._Closure$__.$I61-9 = new Func<ActiveUnit, bool>(UnitFilter._Closure$__.$I.method_24)) : UnitFilter._Closure$__.$I61-9), (UnitFilter._Closure$__.$I61-10 == null) ? (UnitFilter._Closure$__.$I61-10 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_25)) : UnitFilter._Closure$__.$I61-10);
			if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
			{
				enumerable4 = Enumerable.Where<ActiveUnit>(enumerable4, new Func<ActiveUnit, bool>(this.method_21));
			}
			try
			{
				foreach (ActiveUnit activeUnit4 in enumerable4)
				{
					if (((Facility)activeUnit4)._FacilityCategory_0 == (Facility._FacilityCategory)Conversions.ToShort(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "Tag", new object[0], null, null, null)) && !hashSet.Contains(activeUnit4.DBID))
					{
						hashSet.Add(activeUnit4.DBID);
						ComboBoxItem comboBoxItem5 = new ComboBoxItem();
						comboBoxItem5.Content = activeUnit4.string_2;
						comboBoxItem5.Tag = activeUnit4.DBID;
						this.vmethod_16().Items.Add(comboBoxItem5);
					}
				}
				goto IL_8C5;
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator4;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
			}
			IL_604:
			IEnumerable<ActiveUnit> enumerable5 = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, (UnitFilter._Closure$__.$I61-12 == null) ? (UnitFilter._Closure$__.$I61-12 = new Func<ActiveUnit, bool>(UnitFilter._Closure$__.$I.method_26)) : UnitFilter._Closure$__.$I61-12), (UnitFilter._Closure$__.$I61-13 == null) ? (UnitFilter._Closure$__.$I61-13 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_27)) : UnitFilter._Closure$__.$I61-13);
			if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
			{
				enumerable5 = Enumerable.Where<ActiveUnit>(enumerable5, new Func<ActiveUnit, bool>(this.method_22));
			}
			try
			{
				foreach (ActiveUnit activeUnit5 in enumerable5)
				{
					if (((Weapon)activeUnit5).method_167() == (Weapon._WeaponType)Conversions.ToShort(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "Tag", new object[0], null, null, null)) && !hashSet.Contains(activeUnit5.DBID))
					{
						hashSet.Add(activeUnit5.DBID);
						ComboBoxItem comboBoxItem6 = new ComboBoxItem();
						comboBoxItem6.Content = activeUnit5.string_2;
						comboBoxItem6.Tag = activeUnit5.DBID;
						this.vmethod_16().Items.Add(comboBoxItem6);
					}
				}
				goto IL_8C5;
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator5;
				if (enumerator5 != null)
				{
					enumerator5.Dispose();
				}
			}
			IL_766:
			IEnumerable<ActiveUnit> enumerable6 = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, (UnitFilter._Closure$__.$I61-15 == null) ? (UnitFilter._Closure$__.$I61-15 = new Func<ActiveUnit, bool>(UnitFilter._Closure$__.$I.method_28)) : UnitFilter._Closure$__.$I61-15), (UnitFilter._Closure$__.$I61-16 == null) ? (UnitFilter._Closure$__.$I61-16 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_29)) : UnitFilter._Closure$__.$I61-16);
			if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
			{
				enumerable6 = Enumerable.Where<ActiveUnit>(enumerable6, new Func<ActiveUnit, bool>(this.method_23));
			}
			try
			{
				foreach (ActiveUnit activeUnit6 in enumerable6)
				{
					if (((Satellite)activeUnit6)._SatelliteType_0 == (Satellite._SatelliteType)Conversions.ToInteger(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "Tag", new object[0], null, null, null)) && !hashSet.Contains(activeUnit6.DBID))
					{
						hashSet.Add(activeUnit6.DBID);
						ComboBoxItem comboBoxItem7 = new ComboBoxItem();
						comboBoxItem7.Content = activeUnit6.string_2;
						comboBoxItem7.Tag = activeUnit6.DBID;
						this.vmethod_16().Items.Add(comboBoxItem7);
					}
				}
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator6;
				if (enumerator6 != null)
				{
					enumerator6.Dispose();
				}
			}
			IL_8C5:
			this.vmethod_16().SelectedIndex = 0;
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x0046E934 File Offset: 0x0046CB34
		private void method_6()
		{
			UnitFilter.Class2509 @class = new UnitFilter.Class2509(@class);
			@class.unitFilter_0 = this;
			this.vmethod_18().Items.Clear();
			this.vmethod_18().DisplayMember = "Content";
			ComboBoxItem comboBoxItem = new ComboBoxItem();
			comboBoxItem.Content = "None";
			this.vmethod_18().Items.Add(comboBoxItem);
			@class.string_0 = "";
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
			{
				@class.string_0 = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null));
			}
			@class.int_0 = 0;
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_16().SelectedItem)) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(((ComboBoxItem)this.vmethod_16().SelectedItem).Tag)))
			{
				@class.int_0 = Conversions.ToInteger(((ComboBoxItem)this.vmethod_16().SelectedItem).Tag);
			}
			GlobalVariables.ActiveUnitType activeUnitType_ = this.class349_0.activeUnitType_0;
			if (activeUnitType_ != GlobalVariables.ActiveUnitType.None)
			{
				if (activeUnitType_ == GlobalVariables.ActiveUnitType.Aimpoint)
				{
					IEnumerable<ActiveUnit> enumerable = Enumerable.OrderBy<ActiveUnit, string>(Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, new Func<ActiveUnit, bool>(@class.method_0)), (UnitFilter._Closure$__.$I62-1 == null) ? (UnitFilter._Closure$__.$I62-1 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_30)) : UnitFilter._Closure$__.$I62-1), (UnitFilter._Closure$__.$I62-2 == null) ? (UnitFilter._Closure$__.$I62-2 = new Func<ActiveUnit, string>(UnitFilter._Closure$__.$I.method_31)) : UnitFilter._Closure$__.$I62-2);
					if (!string.IsNullOrEmpty(@class.string_0))
					{
						enumerable = Enumerable.Where<ActiveUnit>(enumerable, new Func<ActiveUnit, bool>(@class.method_1));
					}
					try
					{
						foreach (ActiveUnit activeUnit in enumerable)
						{
							ComboBoxItem comboBoxItem2 = new ComboBoxItem();
							comboBoxItem2.Content = activeUnit.Name;
							comboBoxItem2.Tag = activeUnit;
							this.vmethod_18().Items.Add(comboBoxItem2);
						}
						goto IL_325;
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				IEnumerable<ActiveUnit> enumerable2 = Enumerable.OrderBy<ActiveUnit, string>(Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().vmethod_0().Values, new Func<ActiveUnit, bool>(@class.method_2)), (UnitFilter._Closure$__.$I62-5 == null) ? (UnitFilter._Closure$__.$I62-5 = new Func<ActiveUnit, ActiveUnit>(UnitFilter._Closure$__.$I.method_32)) : UnitFilter._Closure$__.$I62-5), (UnitFilter._Closure$__.$I62-6 == null) ? (UnitFilter._Closure$__.$I62-6 = new Func<ActiveUnit, string>(UnitFilter._Closure$__.$I.method_33)) : UnitFilter._Closure$__.$I62-6);
				if (!string.IsNullOrEmpty(@class.string_0))
				{
					enumerable2 = Enumerable.Where<ActiveUnit>(enumerable2, new Func<ActiveUnit, bool>(@class.method_3));
				}
				try
				{
					foreach (ActiveUnit activeUnit2 in enumerable2)
					{
						ComboBoxItem comboBoxItem3 = new ComboBoxItem();
						comboBoxItem3.Content = activeUnit2.Name;
						comboBoxItem3.Tag = activeUnit2;
						this.vmethod_18().Items.Add(comboBoxItem3);
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
			}
			IL_325:
			this.vmethod_18().SelectedIndex = 0;
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x0046EC90 File Offset: 0x0046CE90
		private void method_7(object sender, EventArgs e)
		{
			switch (this.vmethod_12().SelectedIndex)
			{
			case 0:
				this.class349_0.activeUnitType_0 = GlobalVariables.ActiveUnitType.None;
				break;
			case 1:
				this.class349_0.activeUnitType_0 = GlobalVariables.ActiveUnitType.Aircraft;
				break;
			case 2:
				this.class349_0.activeUnitType_0 = GlobalVariables.ActiveUnitType.Ship;
				break;
			case 3:
				this.class349_0.activeUnitType_0 = GlobalVariables.ActiveUnitType.Submarine;
				break;
			case 4:
				this.class349_0.activeUnitType_0 = GlobalVariables.ActiveUnitType.Facility;
				break;
			case 6:
				this.class349_0.activeUnitType_0 = GlobalVariables.ActiveUnitType.Weapon;
				break;
			case 7:
				this.class349_0.activeUnitType_0 = GlobalVariables.ActiveUnitType.Satellite;
				break;
			}
			this.method_4();
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x0046ED38 File Offset: 0x0046CF38
		private void method_8(object sender, EventArgs e)
		{
			if (this.vmethod_14().Items.Count != 0)
			{
				this.class349_0.int_0 = Conversions.ToInteger(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "tag", new object[0], null, null, null));
				this.method_5();
				this.class349_0.string_3 = null;
			}
		}

		// Token: 0x060083D0 RID: 33744 RVA: 0x0004FE88 File Offset: 0x0004E088
		private void method_9(object sender, EventArgs e)
		{
			if (this.vmethod_16().Items.Count != 0)
			{
				this.class349_0.int_1 = Conversions.ToInteger(((ComboBoxItem)this.vmethod_16().SelectedItem).Tag);
				this.method_6();
			}
		}

		// Token: 0x060083D1 RID: 33745 RVA: 0x0004FEC7 File Offset: 0x0004E0C7
		private void method_10(object sender, EventArgs e)
		{
			this.class349_0.string_2 = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "tag", new object[0], null, null, null));
		}

		// Token: 0x060083D2 RID: 33746 RVA: 0x0046ED98 File Offset: 0x0046CF98
		private void method_11(object sender, EventArgs e)
		{
			if (NewLateBinding.LateGet(this.vmethod_18().SelectedItem, null, "tag", new object[0], null, null, null) is ActiveUnit)
			{
				this.class349_0.string_3 = ((ActiveUnit)NewLateBinding.LateGet(this.vmethod_18().SelectedItem, null, "tag", new object[0], null, null, null)).string_0;
				return;
			}
			this.class349_0.string_3 = null;
		}

		// Token: 0x060083D3 RID: 33747 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CompilerGenerated]
		private bool method_12(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.vmethod_7(false).string_0, NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x060083D4 RID: 33748 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CompilerGenerated]
		private bool method_13(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.vmethod_7(false).string_0, NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CompilerGenerated]
		private bool method_14(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.vmethod_7(false).string_0, NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CompilerGenerated]
		private bool method_15(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.vmethod_7(false).string_0, NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x060083D7 RID: 33751 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CompilerGenerated]
		private bool method_16(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.vmethod_7(false).string_0, NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x060083D8 RID: 33752 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CompilerGenerated]
		private bool method_17(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.vmethod_7(false).string_0, NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x060083D9 RID: 33753 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CompilerGenerated]
		private bool method_18(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.vmethod_7(false).string_0, NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x060083DA RID: 33754 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CompilerGenerated]
		private bool method_19(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.vmethod_7(false).string_0, NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x060083DB RID: 33755 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CompilerGenerated]
		private bool method_20(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.vmethod_7(false).string_0, NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x060083DC RID: 33756 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CompilerGenerated]
		private bool method_21(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.vmethod_7(false).string_0, NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x060083DD RID: 33757 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CompilerGenerated]
		private bool method_22(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.vmethod_7(false).string_0, NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x060083DE RID: 33758 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CompilerGenerated]
		private bool method_23(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.vmethod_7(false).string_0, NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x04004813 RID: 18451
		private IContainer icontainer_1;

		// Token: 0x04004814 RID: 18452
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004815 RID: 18453
		[AccessedThroughProperty("CB_TargetSide")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04004816 RID: 18454
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_1;

		// Token: 0x04004817 RID: 18455
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_2;

		// Token: 0x04004818 RID: 18456
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_3;

		// Token: 0x04004819 RID: 18457
		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Class116 class116_4;

		// Token: 0x0400481A RID: 18458
		[CompilerGenerated]
		[AccessedThroughProperty("CB_TargetType")]
		private Class2451 class2451_1;

		// Token: 0x0400481B RID: 18459
		[CompilerGenerated]
		[AccessedThroughProperty("CB_TargetSubtype")]
		private Class2451 class2451_2;

		// Token: 0x0400481C RID: 18460
		[CompilerGenerated]
		[AccessedThroughProperty("CB_TargetUnitClass")]
		private Class2451 class2451_3;

		// Token: 0x0400481D RID: 18461
		[CompilerGenerated]
		[AccessedThroughProperty("CB_SpecificUnit")]
		private Class2451 class2451_4;

		// Token: 0x0400481E RID: 18462
		private Class349 class349_0;

		// Token: 0x02000ED1 RID: 3793
		[CompilerGenerated]
		internal sealed class Class2509
		{
			// Token: 0x06008403 RID: 33795 RVA: 0x0004FF8D File Offset: 0x0004E18D
			public Class2509(UnitFilter.Class2509 class2509_0)
			{
				if (class2509_0 != null)
				{
					this.int_0 = class2509_0.int_0;
					this.string_0 = class2509_0.string_0;
				}
			}

			// Token: 0x06008404 RID: 33796 RVA: 0x0004FFB0 File Offset: 0x0004E1B0
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return !activeUnit_0.bool_1 & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x06008405 RID: 33797 RVA: 0x0004FFCA File Offset: 0x0004E1CA
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.vmethod_7(false).string_0, this.string_0, false) == 0;
			}

			// Token: 0x06008406 RID: 33798 RVA: 0x0004FFE7 File Offset: 0x0004E1E7
			internal bool method_2(ActiveUnit activeUnit_0)
			{
				return !activeUnit_0.bool_1 & activeUnit_0.vmethod_56() == this.unitFilter_0.method_1() & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x06008407 RID: 33799 RVA: 0x0004FFCA File Offset: 0x0004E1CA
			internal bool method_3(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.vmethod_7(false).string_0, this.string_0, false) == 0;
			}

			// Token: 0x04004842 RID: 18498
			public int int_0;

			// Token: 0x04004843 RID: 18499
			public string string_0;

			// Token: 0x04004844 RID: 18500
			public UnitFilter unitFilter_0;
		}
	}
}
