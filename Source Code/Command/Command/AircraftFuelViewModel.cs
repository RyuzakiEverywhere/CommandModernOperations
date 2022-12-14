using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command
{
	// Token: 0x02000D82 RID: 3458
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class AircraftFuelViewModel : PlatFormViewModel
	{
		// Token: 0x06005C2F RID: 23599 RVA: 0x0003B1AF File Offset: 0x000393AF
		[Obsolete("Used for design time only", true)]
		public AircraftFuelViewModel()
		{
			this.stringBuilder_0 = new StringBuilder();
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06005C30 RID: 23600 RVA: 0x0003B1C2 File Offset: 0x000393C2
		// (set) Token: 0x06005C31 RID: 23601 RVA: 0x0003B1CA File Offset: 0x000393CA
		public double Percentage
		{
			[CompilerGenerated]
			get
			{
				return this.double_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_0 == value)
				{
					return;
				}
				this.double_0 = value;
				this.vmethod_0("Percentage");
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06005C32 RID: 23602 RVA: 0x0003B1ED File Offset: 0x000393ED
		// (set) Token: 0x06005C33 RID: 23603 RVA: 0x0003B1F5 File Offset: 0x000393F5
		public string Text
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
				this.vmethod_0("Text");
			}
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x0032BEE4 File Offset: 0x0032A0E4
		[Attribute0]
		[Attribute2]
		public void Refresh()
		{
			try
			{
				base.UnitName = this.activeUnit_0.Name;
				this.stringBuilder_0.Clear();
				Aircraft aircraft = (Aircraft)this.activeUnit_0;
				Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
				ActiveUnit._ActiveUnitFuelState activeUnitFuelState = this.activeUnit_0.vmethod_61(null, this.activeUnit_0.doctrine_0.method_206(this.activeUnit_0.scenario_0, false, true, false, false));
				ActiveUnit activeUnit_ = this.activeUnit_0;
				double num = 0.0;
				double num2;
				this.Percentage = (double)((int)Math.Round(activeUnit_.vmethod_119(ref num2, ref num, false) * 100.0));
				float num3 = aircraft.vmethod_98(this.activeUnit_0.vmethod_84(), null, new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?(this.activeUnit_0.vmethod_14(false)), false, false, false, false, false);
				long num4;
				if (this.activeUnit_0.vmethod_84() == ActiveUnit.Throttle.FullStop)
				{
					if (this.activeUnit_0.vmethod_87().vmethod_42(this.activeUnit_0.vmethod_14(false), false).nullable_0 != null)
					{
						num4 = aircraft.vmethod_114(ActiveUnit.Throttle.Full, null, new float?(this.activeUnit_0.vmethod_40()), new float?(this.activeUnit_0.vmethod_14(false)));
					}
					else
					{
						num4 = 0L;
					}
				}
				else
				{
					num4 = aircraft.vmethod_114(this.activeUnit_0.vmethod_84(), null, new float?(this.activeUnit_0.vmethod_40()), new float?(this.activeUnit_0.vmethod_14(false)));
				}
				long num5;
				if (num3 == 0f)
				{
					num5 = long.MaxValue;
				}
				else if (float.IsInfinity(aircraft.float_33))
				{
					num5 = long.MaxValue;
				}
				else
				{
					num5 = (long)Math.Round((double)(aircraft.float_33 / num3));
				}
				long num6;
				if (num3 == 0f)
				{
					num6 = long.MaxValue;
				}
				else if (float.IsInfinity(aircraft.float_34))
				{
					num6 = long.MaxValue;
				}
				else
				{
					num6 = (long)Math.Round((double)(aircraft.float_34 / num3));
				}
				double num7 = Conversions.ToDouble(string.Format("{0:0.0}", num2 - (double)this.activeUnit_0.vmethod_87().vmethod_4(), 0));
				string value;
				if (num4 > 0L)
				{
					if (this.activeUnit_0.vmethod_84() == ActiveUnit.Throttle.FullStop)
					{
						value = string.Format("{0:0.0}", num2, 0) + " kg total fuel, " + Misc.smethod_11(num4, Aircraft_AirOps.Enum44.const_0, true, false);
					}
					else
					{
						value = string.Concat(new string[]
						{
							string.Format("{0:0.0}", num2, 0),
							" kg total fuel, ",
							Misc.smethod_11(num4, Aircraft_AirOps.Enum44.const_0, true, false),
							", ",
							string.Format("{0:0.0}", (float)num4 * this.activeUnit_0.vmethod_40() / 3600f, 0),
							" nm"
						});
					}
				}
				else
				{
					value = string.Format("{0:0.0}", num2, 0) + " kg total fuel";
				}
				string value2;
				if (num7 > 0.0)
				{
					value2 = Conversions.ToString(num7) + " kg mission fuel, " + string.Format("{0:0.0}", this.activeUnit_0.vmethod_87().vmethod_4(), 0) + " kg reserve";
				}
				else
				{
					value2 = "No mission fuel remaining, using reserve.";
				}
				string value3 = string.Format("{0:0.0}", num3 * 60f, 1) + " kg / minute fuel burn rate";
				Doctrine._FuelState? fuelState = aircraft.doctrine_0.method_206(aircraft.scenario_0, false, true, false, false);
				string value4;
				if (aircraft_AirOps.method_32(false) == null)
				{
					value4 = "Aircraft has no home base selected!";
				}
				else
				{
					byte? b = (fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault() && activeUnitFuelState != ActiveUnit._ActiveUnitFuelState.IsBingo && num5 > 0L)
					{
						value4 = string.Concat(new string[]
						{
							string.Format("{0:0.0}", aircraft.float_33, 0),
							" kg to Bingo fuel, ",
							Misc.smethod_11(num5, Aircraft_AirOps.Enum44.const_0, false, true),
							", ",
							string.Format("{0:0.0}", (float)num5 * this.activeUnit_0.vmethod_40() / 3600f, 0),
							" nm"
						});
					}
					else if (activeUnitFuelState != ActiveUnit._ActiveUnitFuelState.IsBingo && activeUnitFuelState != ActiveUnit._ActiveUnitFuelState.IsJoker && num6 > 0L)
					{
						value4 = string.Concat(new string[]
						{
							string.Format("{0:0.0}", aircraft.float_34, 0),
							" kg to Joker fuel, ",
							Misc.smethod_11(num6, Aircraft_AirOps.Enum44.const_0, false, true),
							", ",
							string.Format("{0:0.0}", (float)num6 * this.activeUnit_0.vmethod_40() / 3600f, 0),
							" nm"
						});
					}
					else
					{
						b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							value4 = "Has reached BINGO FUEL!";
						}
						else
						{
							value4 = "Has reached JOKER FUEL! " + string.Format("{0:0.0}", aircraft.float_33, 0) + " kg to Bingo";
						}
					}
				}
				string value5 = "";
				if (aircraft_AirOps.method_32(false) == null)
				{
					value5 = "";
				}
				else if (aircraft_AirOps.method_24() != null)
				{
					value5 = string.Format("{0:0.0}", aircraft.float_32, 0) + " nm to tanker: " + aircraft_AirOps.method_24().Name;
				}
				else if (aircraft.method_121())
				{
					if (aircraft.vmethod_65(false).method_147() != null)
					{
						Aircraft_AirOps aircraft_AirOps2 = ((Aircraft)aircraft.vmethod_65(false).method_147()).method_164();
						if (aircraft_AirOps2.method_24() != null)
						{
							value5 = string.Format("{0:0.0}", aircraft.float_32, 0) + " nm to tanker: " + aircraft_AirOps2.method_24().Name;
						}
						else if (aircraft.activeUnit_0 != null)
						{
							if (aircraft.activeUnit_0.bool_3)
							{
								value5 = string.Format("{0:0.0}", aircraft.float_32, 0) + " nm to tanker: " + aircraft.activeUnit_0.Name;
							}
							else
							{
								value5 = string.Format("{0:0.0}", aircraft.float_32, 0) + " nm to base: " + aircraft.activeUnit_0.Name;
							}
						}
						else
						{
							value5 = "No Bingo fuel destination selected.";
						}
					}
				}
				else if (aircraft.activeUnit_0 != null)
				{
					if (aircraft.activeUnit_0.bool_3)
					{
						value5 = string.Format("{0:0.0}", aircraft.float_32, 0) + " nm to tanker: " + aircraft.activeUnit_0.Name;
					}
					else
					{
						value5 = string.Format("{0:0.0}", aircraft.float_32, 0) + " nm to base: " + aircraft.activeUnit_0.Name;
					}
				}
				else
				{
					value5 = "No Bingo fuel destination selected.";
				}
				string value6;
				if (aircraft.float_26 <= 0f)
				{
					value6 = "";
				}
				else
				{
					value6 = Misc.smethod_11((long)Math.Round((double)aircraft.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " flying time";
				}
				this.stringBuilder_0.Append(value).Append("\r\n").Append(value2).Append("\r\n").Append(value3).Append("\r\n").Append(value4).Append("\r\n").Append(value5).Append("\r\n").Append(value6);
				this.Text = this.stringBuilder_0.ToString();
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

		// Token: 0x06005C35 RID: 23605 RVA: 0x0003B219 File Offset: 0x00039419
		public AircraftFuelViewModel(Aircraft theUnit)
		{
			this.stringBuilder_0 = new StringBuilder();
			this.activeUnit_0 = theUnit;
			this.Refresh();
		}

		// Token: 0x040035C7 RID: 13767
		[CompilerGenerated]
		private double double_0;

		// Token: 0x040035C8 RID: 13768
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040035C9 RID: 13769
		private StringBuilder stringBuilder_0;
	}
}
