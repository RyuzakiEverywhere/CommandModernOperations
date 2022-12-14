using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Command_Core;
using ns14;

namespace Command
{
	// Token: 0x02000D85 RID: 3461
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class ShipFuelViewModel : PlatFormViewModel
	{
		// Token: 0x06005C5A RID: 23642 RVA: 0x0003B239 File Offset: 0x00039439
		[Obsolete("Used for design time only", true)]
		public ShipFuelViewModel()
		{
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06005C5B RID: 23643 RVA: 0x0003B4B7 File Offset: 0x000396B7
		// (set) Token: 0x06005C5C RID: 23644 RVA: 0x0003B4BF File Offset: 0x000396BF
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

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06005C5D RID: 23645 RVA: 0x0003B4E2 File Offset: 0x000396E2
		// (set) Token: 0x06005C5E RID: 23646 RVA: 0x0003B4EA File Offset: 0x000396EA
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

		// Token: 0x06005C5F RID: 23647 RVA: 0x0032CB04 File Offset: 0x0032AD04
		[Attribute0]
		[Attribute2]
		public void Refresh()
		{
			base.UnitName = this.activeUnit_0.Name;
			double num;
			double num2;
			this.Percentage = (double)((int)Math.Round(this.activeUnit_0.vmethod_119(ref num, ref num2, false) * 100.0));
			long num3 = ((Ship)this.activeUnit_0).vmethod_114(this.activeUnit_0.vmethod_84(), null, new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?(0f));
			HashSet<string> hashSet = new HashSet<string>();
			string text = "";
			foreach (FuelRec fuelRec in this.activeUnit_0.vmethod_67())
			{
				hashSet.Add(fuelRec._FuelType_0.ToString());
			}
			if (hashSet.Count > 0)
			{
				text = " (" + string.Join(", ", Enumerable.ToArray<string>(hashSet)) + ")";
				if (hashSet.Count > 1)
				{
					text = "\r\n" + text;
				}
			}
			string str = string.Format("{0:0.0}", num, 0) + " fuel units remaining";
			if (!string.IsNullOrEmpty(text))
			{
				str += text;
			}
			string str2;
			if (this.activeUnit_0.vmethod_84() == ActiveUnit.Throttle.FullStop)
			{
				str2 = "Unit is at full stop";
			}
			else
			{
				str2 = Misc.smethod_11(num3, Aircraft_AirOps.Enum44.const_0, false, true) + ", " + string.Format("{0:0.0}", (float)num3 * this.activeUnit_0.vmethod_40() / 3600f, 0) + " nm";
			}
			this.Text = str + "\r\n" + str2;
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x0003B50E File Offset: 0x0003970E
		public ShipFuelViewModel(Ship theUnit)
		{
			this.activeUnit_0 = theUnit;
			this.Refresh();
		}

		// Token: 0x040035DC RID: 13788
		[CompilerGenerated]
		private double double_0;

		// Token: 0x040035DD RID: 13789
		[CompilerGenerated]
		private string string_1;
	}
}
