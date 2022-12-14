using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// Token: 0x0200048F RID: 1167
	[StandardModule]
	public sealed class GlobalVariables
	{
		// Token: 0x02000490 RID: 1168
		public enum ProficiencyLevel
		{
			// Token: 0x04001DE7 RID: 7655
			Novice,
			// Token: 0x04001DE8 RID: 7656
			Cadet,
			// Token: 0x04001DE9 RID: 7657
			Regular,
			// Token: 0x04001DEA RID: 7658
			Veteran,
			// Token: 0x04001DEB RID: 7659
			Ace
		}

		// Token: 0x02000491 RID: 1169
		public enum ArmorRating : short
		{
			// Token: 0x04001DED RID: 7661
			None = 1001,
			// Token: 0x04001DEE RID: 7662
			Armor_Handgun = 1005,
			// Token: 0x04001DEF RID: 7663
			Armor_Rifle = 1010,
			// Token: 0x04001DF0 RID: 7664
			Armor_HMG = 1015,
			// Token: 0x04001DF1 RID: 7665
			RHA_20mm = 1020,
			// Token: 0x04001DF2 RID: 7666
			RHA_25mm = 1025,
			// Token: 0x04001DF3 RID: 7667
			RHA_30mm = 1030,
			// Token: 0x04001DF4 RID: 7668
			RHA_35mm = 1035,
			// Token: 0x04001DF5 RID: 7669
			Light = 2001,
			// Token: 0x04001DF6 RID: 7670
			Medium,
			// Token: 0x04001DF7 RID: 7671
			Heavy,
			// Token: 0x04001DF8 RID: 7672
			Special
		}

		// Token: 0x02000492 RID: 1170
		public enum PatrolType : byte
		{
			// Token: 0x04001DFA RID: 7674
			ASW,
			// Token: 0x04001DFB RID: 7675
			ASuW_Naval,
			// Token: 0x04001DFC RID: 7676
			AAW,
			// Token: 0x04001DFD RID: 7677
			ASuW_Land,
			// Token: 0x04001DFE RID: 7678
			ASuW_Mixed,
			// Token: 0x04001DFF RID: 7679
			SEAD,
			// Token: 0x04001E00 RID: 7680
			SeaControl
		}

		// Token: 0x02000493 RID: 1171
		public enum TargetVisualSizeClass : byte
		{
			// Token: 0x04001E02 RID: 7682
			Stealthy,
			// Token: 0x04001E03 RID: 7683
			VSmall,
			// Token: 0x04001E04 RID: 7684
			Small,
			// Token: 0x04001E05 RID: 7685
			Medium,
			// Token: 0x04001E06 RID: 7686
			Large,
			// Token: 0x04001E07 RID: 7687
			VLarge,
			// Token: 0x04001E08 RID: 7688
			Unknown
		}

		// Token: 0x02000494 RID: 1172
		internal enum Enum145 : byte
		{
			// Token: 0x04001E0A RID: 7690
			const_0,
			// Token: 0x04001E0B RID: 7691
			const_1,
			// Token: 0x04001E0C RID: 7692
			const_2,
			// Token: 0x04001E0D RID: 7693
			const_3,
			// Token: 0x04001E0E RID: 7694
			const_4
		}

		// Token: 0x02000495 RID: 1173
		public enum ActiveUnitType : byte
		{
			// Token: 0x04001E10 RID: 7696
			None,
			// Token: 0x04001E11 RID: 7697
			Aircraft,
			// Token: 0x04001E12 RID: 7698
			Ship,
			// Token: 0x04001E13 RID: 7699
			Submarine,
			// Token: 0x04001E14 RID: 7700
			Facility,
			// Token: 0x04001E15 RID: 7701
			Aimpoint,
			// Token: 0x04001E16 RID: 7702
			Weapon,
			// Token: 0x04001E17 RID: 7703
			Satellite
		}

		// Token: 0x02000496 RID: 1174
		public enum AircraftSizeClass : byte
		{
			// Token: 0x04001E19 RID: 7705
			None,
			// Token: 0x04001E1A RID: 7706
			Small,
			// Token: 0x04001E1B RID: 7707
			Medium,
			// Token: 0x04001E1C RID: 7708
			Large,
			// Token: 0x04001E1D RID: 7709
			VLarge
		}

		// Token: 0x02000497 RID: 1175
		internal enum Enum146
		{
			// Token: 0x04001E1F RID: 7711
			const_0 = 1001,
			// Token: 0x04001E20 RID: 7712
			const_1 = 2001,
			// Token: 0x04001E21 RID: 7713
			const_2,
			// Token: 0x04001E22 RID: 7714
			const_3,
			// Token: 0x04001E23 RID: 7715
			const_4,
			// Token: 0x04001E24 RID: 7716
			const_5,
			// Token: 0x04001E25 RID: 7717
			const_6,
			// Token: 0x04001E26 RID: 7718
			const_7,
			// Token: 0x04001E27 RID: 7719
			const_8,
			// Token: 0x04001E28 RID: 7720
			const_9
		}

		// Token: 0x02000498 RID: 1176
		public enum TechGenerationClass
		{
			// Token: 0x04001E2A RID: 7722
			None = 1001,
			// Token: 0x04001E2B RID: 7723
			NotApplicable,
			// Token: 0x04001E2C RID: 7724
			Early1950s = 2001,
			// Token: 0x04001E2D RID: 7725
			Late1950s,
			// Token: 0x04001E2E RID: 7726
			Early1960s,
			// Token: 0x04001E2F RID: 7727
			Late1960s,
			// Token: 0x04001E30 RID: 7728
			Early1970s,
			// Token: 0x04001E31 RID: 7729
			Late1970s,
			// Token: 0x04001E32 RID: 7730
			Early1980s,
			// Token: 0x04001E33 RID: 7731
			Late1980s,
			// Token: 0x04001E34 RID: 7732
			Early1990s,
			// Token: 0x04001E35 RID: 7733
			Late1990s,
			// Token: 0x04001E36 RID: 7734
			Early2000s,
			// Token: 0x04001E37 RID: 7735
			Late2000s,
			// Token: 0x04001E38 RID: 7736
			Early2010s,
			// Token: 0x04001E39 RID: 7737
			Late2010s,
			// Token: 0x04001E3A RID: 7738
			Early2020s,
			// Token: 0x04001E3B RID: 7739
			Late2020s,
			// Token: 0x04001E3C RID: 7740
			IR_SingleSpectral = 3001,
			// Token: 0x04001E3D RID: 7741
			IR_DualSpectral,
			// Token: 0x04001E3E RID: 7742
			IR_Imaging_FPA
		}
	}
}
