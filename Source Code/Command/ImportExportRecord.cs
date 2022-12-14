using System;
using System.Collections.Generic;

namespace Command_Core
{
	// Token: 0x0200027C RID: 636
	[Serializable]
	public sealed class ImportExportRecord
	{
		// Token: 0x0600138F RID: 5007 RVA: 0x0000AE9E File Offset: 0x0000909E
		public ImportExportRecord()
		{
			this.MemberRecords = new List<ImportExportRecord.MemberRecord>();
		}

		// Token: 0x04000DE6 RID: 3558
		public int DB_ID;

		// Token: 0x04000DE7 RID: 3559
		public int FormatVersion;

		// Token: 0x04000DE8 RID: 3560
		public List<ImportExportRecord.MemberRecord> MemberRecords;

		// Token: 0x04000DE9 RID: 3561
		public string ValidFrom;

		// Token: 0x04000DEA RID: 3562
		public string ValidUntil;

		// Token: 0x04000DEB RID: 3563
		public string Name;

		// Token: 0x04000DEC RID: 3564
		public string Comments;

		// Token: 0x0200027D RID: 637
		[Serializable]
		public sealed class MemberRecord
		{
			// Token: 0x06001390 RID: 5008 RVA: 0x0000AEB1 File Offset: 0x000090B1
			public MemberRecord()
			{
				this.HostedAircraftRecords = new List<ImportExportRecord.HostedAircraftRecord>();
				this.EmbarkedBoatRecords = new List<ImportExportRecord.EmbarkedBoatRecord>();
				this.MagazineRecords = new List<ImportExportRecord.MagazineRecord>();
			}

			// Token: 0x04000DED RID: 3565
			public int Member_DBID;

			// Token: 0x04000DEE RID: 3566
			public string Member_GUID;

			// Token: 0x04000DEF RID: 3567
			public string MemberType;

			// Token: 0x04000DF0 RID: 3568
			public string MemberName;

			// Token: 0x04000DF1 RID: 3569
			public string ParentGroupName;

			// Token: 0x04000DF2 RID: 3570
			public double Longitude;

			// Token: 0x04000DF3 RID: 3571
			public double Latitude;

			// Token: 0x04000DF4 RID: 3572
			public double Altitude;

			// Token: 0x04000DF5 RID: 3573
			public int LoadoutID;

			// Token: 0x04000DF6 RID: 3574
			public float Orientation;

			// Token: 0x04000DF7 RID: 3575
			public List<ImportExportRecord.HostedAircraftRecord> HostedAircraftRecords;

			// Token: 0x04000DF8 RID: 3576
			public List<ImportExportRecord.EmbarkedBoatRecord> EmbarkedBoatRecords;

			// Token: 0x04000DF9 RID: 3577
			public List<ImportExportRecord.MagazineRecord> MagazineRecords;

			// Token: 0x04000DFA RID: 3578
			public string Member_SBR;
		}

		// Token: 0x0200027E RID: 638
		[Serializable]
		public sealed class HostedAircraftRecord
		{
			// Token: 0x06001391 RID: 5009 RVA: 0x0000AEDA File Offset: 0x000090DA
			public HostedAircraftRecord(string string_0, int int_0, int int_1, int int_2)
			{
				this.Name = string_0;
				this.AC_DBID = int_0;
				this.Loadout_ID = int_1;
				this.ReadyTime_Mins = int_2;
			}

			// Token: 0x06001392 RID: 5010 RVA: 0x00002977 File Offset: 0x00000B77
			public HostedAircraftRecord()
			{
			}

			// Token: 0x04000DFB RID: 3579
			public string Name;

			// Token: 0x04000DFC RID: 3580
			public int AC_DBID;

			// Token: 0x04000DFD RID: 3581
			public int Loadout_ID;

			// Token: 0x04000DFE RID: 3582
			public int ReadyTime_Mins;
		}

		// Token: 0x0200027F RID: 639
		[Serializable]
		public sealed class EmbarkedBoatRecord
		{
			// Token: 0x06001393 RID: 5011 RVA: 0x0000AEFF File Offset: 0x000090FF
			public EmbarkedBoatRecord(string string_0, int int_0, int int_1, string string_1)
			{
				this.Name = string_0;
				this.Boat_DBID = int_0;
				this.ReadyTime_Mins = int_1;
				this.Type = string_1;
			}

			// Token: 0x06001394 RID: 5012 RVA: 0x00002977 File Offset: 0x00000B77
			public EmbarkedBoatRecord()
			{
			}

			// Token: 0x04000DFF RID: 3583
			public string Name;

			// Token: 0x04000E00 RID: 3584
			public int Boat_DBID;

			// Token: 0x04000E01 RID: 3585
			public int ReadyTime_Mins;

			// Token: 0x04000E02 RID: 3586
			public string Type;
		}

		// Token: 0x02000280 RID: 640
		[Serializable]
		public sealed class WeaponRecord
		{
			// Token: 0x04000E03 RID: 3587
			public string Name;

			// Token: 0x04000E04 RID: 3588
			public int Weapon_DBID;

			// Token: 0x04000E05 RID: 3589
			public int Weapon_MaxLoad;

			// Token: 0x04000E06 RID: 3590
			public int Weapon_Multiple;

			// Token: 0x04000E07 RID: 3591
			public int Weapon_CurrentLoad;

			// Token: 0x04000E08 RID: 3592
			public int Weapon_ROF;

			// Token: 0x04000E09 RID: 3593
			public string Type;
		}

		// Token: 0x02000281 RID: 641
		[Serializable]
		public sealed class MagazineRecord
		{
			// Token: 0x06001396 RID: 5014 RVA: 0x0000AF24 File Offset: 0x00009124
			public MagazineRecord()
			{
				this.WeaponRecords = new List<ImportExportRecord.WeaponRecord>();
			}

			// Token: 0x04000E0A RID: 3594
			public string Name;

			// Token: 0x04000E0B RID: 3595
			public int Mag_DBID;

			// Token: 0x04000E0C RID: 3596
			public int ReadyTime_Mins;

			// Token: 0x04000E0D RID: 3597
			public string Type;

			// Token: 0x04000E0E RID: 3598
			public List<ImportExportRecord.WeaponRecord> WeaponRecords;
		}
	}
}
