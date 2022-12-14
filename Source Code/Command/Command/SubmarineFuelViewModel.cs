using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using Command_Core;
using ns14;

namespace Command
{
	// Token: 0x02000D83 RID: 3459
	[Attribute3]
	[Attribute2]
	[Attribute0]
	public sealed class SubmarineFuelViewModel : PlatFormViewModel
	{
		// Token: 0x06005C36 RID: 23606 RVA: 0x0003B239 File Offset: 0x00039439
		[Obsolete("Used for design time only", true)]
		public SubmarineFuelViewModel()
		{
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06005C37 RID: 23607 RVA: 0x0003B241 File Offset: 0x00039441
		// (set) Token: 0x06005C38 RID: 23608 RVA: 0x0003B249 File Offset: 0x00039449
		public Visibility VisibilityDiesel
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_0 == value)
				{
					return;
				}
				this.visibility_0 = value;
				this.vmethod_0("VisibilityDiesel");
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06005C39 RID: 23609 RVA: 0x0003B269 File Offset: 0x00039469
		// (set) Token: 0x06005C3A RID: 23610 RVA: 0x0003B271 File Offset: 0x00039471
		public double PercentageDiesel
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
				this.vmethod_0("PercentageDiesel");
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06005C3B RID: 23611 RVA: 0x0003B294 File Offset: 0x00039494
		// (set) Token: 0x06005C3C RID: 23612 RVA: 0x0003B29C File Offset: 0x0003949C
		public string PercentageDieselText
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
				this.vmethod_0("PercentageDieselText");
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06005C3D RID: 23613 RVA: 0x0003B2C0 File Offset: 0x000394C0
		// (set) Token: 0x06005C3E RID: 23614 RVA: 0x0003B2C8 File Offset: 0x000394C8
		public FontWeight FontWeightDiesel
		{
			[CompilerGenerated]
			get
			{
				return this.fontWeight_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.fontWeight_0 == value)
				{
					return;
				}
				this.fontWeight_0 = value;
				this.vmethod_0("FontWeightDiesel");
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06005C3F RID: 23615 RVA: 0x0003B2EB File Offset: 0x000394EB
		// (set) Token: 0x06005C40 RID: 23616 RVA: 0x0003B2F3 File Offset: 0x000394F3
		public Visibility VisibilityBattery
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_1 == value)
				{
					return;
				}
				this.visibility_1 = value;
				this.vmethod_0("VisibilityBattery");
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06005C41 RID: 23617 RVA: 0x0003B313 File Offset: 0x00039513
		// (set) Token: 0x06005C42 RID: 23618 RVA: 0x0003B31B File Offset: 0x0003951B
		public double PercentageBattery
		{
			[CompilerGenerated]
			get
			{
				return this.double_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_1 == value)
				{
					return;
				}
				this.double_1 = value;
				this.vmethod_0("PercentageBattery");
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06005C43 RID: 23619 RVA: 0x0003B33E File Offset: 0x0003953E
		// (set) Token: 0x06005C44 RID: 23620 RVA: 0x0003B346 File Offset: 0x00039546
		public string PercentageBatteryText
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
				this.vmethod_0("PercentageBatteryText");
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06005C45 RID: 23621 RVA: 0x0003B36A File Offset: 0x0003956A
		// (set) Token: 0x06005C46 RID: 23622 RVA: 0x0003B372 File Offset: 0x00039572
		public FontWeight FontWeightBattery
		{
			[CompilerGenerated]
			get
			{
				return this.fontWeight_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.fontWeight_1 == value)
				{
					return;
				}
				this.fontWeight_1 = value;
				this.vmethod_0("FontWeightBattery");
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06005C47 RID: 23623 RVA: 0x0003B395 File Offset: 0x00039595
		// (set) Token: 0x06005C48 RID: 23624 RVA: 0x0003B39D File Offset: 0x0003959D
		public Visibility VisibilityAIP
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_2 == value)
				{
					return;
				}
				this.visibility_2 = value;
				this.vmethod_0("VisibilityAIP");
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06005C49 RID: 23625 RVA: 0x0003B3BD File Offset: 0x000395BD
		// (set) Token: 0x06005C4A RID: 23626 RVA: 0x0003B3C5 File Offset: 0x000395C5
		public double PercentageAIP
		{
			[CompilerGenerated]
			get
			{
				return this.double_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_2 == value)
				{
					return;
				}
				this.double_2 = value;
				this.vmethod_0("PercentageAIP");
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06005C4B RID: 23627 RVA: 0x0003B3E8 File Offset: 0x000395E8
		// (set) Token: 0x06005C4C RID: 23628 RVA: 0x0003B3F0 File Offset: 0x000395F0
		public string PercentageAIPText
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
				this.vmethod_0("PercentageAIPText");
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06005C4D RID: 23629 RVA: 0x0003B414 File Offset: 0x00039614
		// (set) Token: 0x06005C4E RID: 23630 RVA: 0x0003B41C File Offset: 0x0003961C
		public FontWeight FontWeightAIP
		{
			[CompilerGenerated]
			get
			{
				return this.fontWeight_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.fontWeight_2 == value)
				{
					return;
				}
				this.fontWeight_2 = value;
				this.vmethod_0("FontWeightAIP");
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06005C4F RID: 23631 RVA: 0x0003B43F File Offset: 0x0003963F
		// (set) Token: 0x06005C50 RID: 23632 RVA: 0x0003B447 File Offset: 0x00039647
		public string EnduranceText
		{
			[CompilerGenerated]
			get
			{
				return this.string_4;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_4, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_4 = value;
				this.vmethod_0("EnduranceText");
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06005C51 RID: 23633 RVA: 0x0003B46B File Offset: 0x0003966B
		// (set) Token: 0x06005C52 RID: 23634 RVA: 0x0003B473 File Offset: 0x00039673
		public double Percentage
		{
			[CompilerGenerated]
			get
			{
				return this.double_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_3 == value)
				{
					return;
				}
				this.double_3 = value;
				this.vmethod_0("Percentage");
			}
		}

		// Token: 0x06005C53 RID: 23635 RVA: 0x0032C7A8 File Offset: 0x0032A9A8
		[Attribute0]
		[Attribute2]
		public void Refresh()
		{
			base.UnitName = this.activeUnit_0.Name;
			if (Enumerable.Count<FuelRec>(this.activeUnit_0.vmethod_67()) != 0)
			{
				Submarine submarine = (Submarine)this.activeUnit_0;
				if (submarine.method_160())
				{
					this.VisibilityDiesel = Visibility.Collapsed;
					this.VisibilityBattery = Visibility.Collapsed;
					this.VisibilityAIP = Visibility.Collapsed;
					return;
				}
				this.VisibilityDiesel = Visibility.Visible;
				FuelRec fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(this.activeUnit_0.vmethod_67(), (SubmarineFuelViewModel._Closure$__.$I57-0 == null) ? (SubmarineFuelViewModel._Closure$__.$I57-0 = new Func<FuelRec, bool>(SubmarineFuelViewModel._Closure$__.$I.method_0)) : SubmarineFuelViewModel._Closure$__.$I57-0), 0);
				if (fuelRec != null)
				{
					this.PercentageDiesel = (double)((int)Math.Round((double)(fuelRec.method_9() * 100f)));
					this.PercentageDieselText = string.Format("{0:0.0}", fuelRec.float_0, 0) + " fuel units remaining";
				}
				this.VisibilityBattery = Visibility.Visible;
				FuelRec fuelRec2 = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(this.activeUnit_0.vmethod_67(), (SubmarineFuelViewModel._Closure$__.$I57-1 == null) ? (SubmarineFuelViewModel._Closure$__.$I57-1 = new Func<FuelRec, bool>(SubmarineFuelViewModel._Closure$__.$I.method_1)) : SubmarineFuelViewModel._Closure$__.$I57-1), 0);
				if (fuelRec2 != null)
				{
					this.PercentageBattery = (double)((int)Math.Round((double)(fuelRec2.method_9() * 100f)));
					this.PercentageBatteryText = string.Format("{0:0.0}", fuelRec2.float_0, 0) + " fuel units remaining";
				}
				if (submarine.method_169())
				{
					this.VisibilityAIP = Visibility.Visible;
					FuelRec fuelRec3 = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(this.activeUnit_0.vmethod_67(), (SubmarineFuelViewModel._Closure$__.$I57-2 == null) ? (SubmarineFuelViewModel._Closure$__.$I57-2 = new Func<FuelRec, bool>(SubmarineFuelViewModel._Closure$__.$I.method_2)) : SubmarineFuelViewModel._Closure$__.$I57-2), 0);
					this.PercentageAIP = (double)((int)Math.Round((double)(fuelRec3.method_9() * 100f)));
					this.PercentageAIPText = string.Format("{0:0.0}", fuelRec3.float_0, 0) + " fuel units remaining";
				}
				else
				{
					this.VisibilityAIP = Visibility.Collapsed;
				}
				FuelRec._FuelType fuelType = submarine.method_153().method_116(submarine.method_146());
				this.FontWeightDiesel = FontWeights.Normal;
				this.FontWeightAIP = FontWeights.Normal;
				this.FontWeightBattery = FontWeights.Normal;
				if (fuelType != FuelRec._FuelType.DieselFuel)
				{
					if (fuelType != FuelRec._FuelType.Battery)
					{
						if (fuelType == FuelRec._FuelType.AirIndepedent)
						{
							this.FontWeightAIP = FontWeights.Bold;
							this.Percentage = this.PercentageAIP;
						}
					}
					else
					{
						this.FontWeightBattery = FontWeights.Bold;
						this.Percentage = this.PercentageBattery;
					}
				}
				else
				{
					this.FontWeightDiesel = FontWeights.Bold;
					this.Percentage = this.PercentageDiesel;
				}
				long num = submarine.method_168(this.activeUnit_0.vmethod_84(), null, new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?(this.activeUnit_0.vmethod_14(false)), submarine.method_146(), submarine.method_148());
				string str;
				if (this.activeUnit_0.vmethod_84() == ActiveUnit.Throttle.FullStop)
				{
					str = "Unit is at full stop";
				}
				else
				{
					str = Misc.smethod_11(num, Aircraft_AirOps.Enum44.const_0, false, true) + ", " + string.Format("{0:0.0}", (float)num * this.activeUnit_0.vmethod_40() / 3600f, 0) + " nm";
				}
				this.EnduranceText = "Endurance: " + str;
			}
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x0003B496 File Offset: 0x00039696
		public SubmarineFuelViewModel(Submarine theUnit)
		{
			this.activeUnit_0 = theUnit;
			this.Refresh();
		}

		// Token: 0x040035CA RID: 13770
		[CompilerGenerated]
		private Visibility visibility_0;

		// Token: 0x040035CB RID: 13771
		[CompilerGenerated]
		private double double_0;

		// Token: 0x040035CC RID: 13772
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040035CD RID: 13773
		[CompilerGenerated]
		private FontWeight fontWeight_0;

		// Token: 0x040035CE RID: 13774
		[CompilerGenerated]
		private Visibility visibility_1;

		// Token: 0x040035CF RID: 13775
		[CompilerGenerated]
		private double double_1;

		// Token: 0x040035D0 RID: 13776
		[CompilerGenerated]
		private string string_2;

		// Token: 0x040035D1 RID: 13777
		[CompilerGenerated]
		private FontWeight fontWeight_1;

		// Token: 0x040035D2 RID: 13778
		[CompilerGenerated]
		private Visibility visibility_2;

		// Token: 0x040035D3 RID: 13779
		[CompilerGenerated]
		private double double_2;

		// Token: 0x040035D4 RID: 13780
		[CompilerGenerated]
		private string string_3;

		// Token: 0x040035D5 RID: 13781
		[CompilerGenerated]
		private FontWeight fontWeight_2;

		// Token: 0x040035D6 RID: 13782
		[CompilerGenerated]
		private string string_4;

		// Token: 0x040035D7 RID: 13783
		[CompilerGenerated]
		private double double_3;
	}
}
