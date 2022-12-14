using System;
using System.Collections.Concurrent;

namespace Command_Core
{
	// Token: 0x020001C9 RID: 457
	public class Contact_Base : Unit
	{
		// Token: 0x06000E6D RID: 3693 RVA: 0x00118798 File Offset: 0x00116998
		public string method_56()
		{
			string result;
			switch (this.contactType_0)
			{
			case Contact_Base.ContactType.Air:
				result = "Air";
				break;
			case Contact_Base.ContactType.Missile:
				result = "Missile";
				break;
			case Contact_Base.ContactType.Surface:
				result = "Surface";
				break;
			case Contact_Base.ContactType.Submarine:
				result = "Submarine";
				break;
			case Contact_Base.ContactType.UndeterminedNaval:
				result = "Undetermined Naval";
				break;
			case Contact_Base.ContactType.Aimpoint:
				result = "Aimpoint";
				break;
			case Contact_Base.ContactType.Orbital:
				result = "Orbital";
				break;
			case Contact_Base.ContactType.Facility_Fixed:
				result = "Fixed Facility";
				break;
			case Contact_Base.ContactType.Facility_Mobile:
				result = "Mobile Unit";
				break;
			case Contact_Base.ContactType.Torpedo:
				result = "Torpedo";
				break;
			case Contact_Base.ContactType.Mine:
				result = "Mine";
				break;
			case Contact_Base.ContactType.Explosion:
				result = "Explosion";
				break;
			case Contact_Base.ContactType.Undetermined:
				result = "Undetermined";
				break;
			case Contact_Base.ContactType.Decoy_Air:
				result = "Decoy (Air)";
				break;
			case Contact_Base.ContactType.Decoy_Surface:
				result = "Decoy (Surface)";
				break;
			case Contact_Base.ContactType.Decoy_Land:
				result = "Decoy (Land)";
				break;
			case Contact_Base.ContactType.Decoy_Sub:
				result = "Decoy (Underwater)";
				break;
			case Contact_Base.ContactType.Sonobuoy:
				result = "Sonobuoy";
				break;
			case Contact_Base.ContactType.Installation:
				result = "Fixed Installation";
				break;
			case Contact_Base.ContactType.AirBase:
				result = "AirBase";
				break;
			case Contact_Base.ContactType.NavalBase:
				result = "Naval Base";
				break;
			case Contact_Base.ContactType.MobileGroup:
				result = "Mobile Group";
				break;
			case Contact_Base.ContactType.ActivationPoint:
				result = "Activation Point";
				break;
			default:
				result = this.contactType_0.ToString();
				break;
			}
			return result;
		}

		// Token: 0x04000951 RID: 2385
		public Contact_Base.ContactType contactType_0;

		// Token: 0x04000952 RID: 2386
		public bool bool_12;

		// Token: 0x04000953 RID: 2387
		protected ConcurrentDictionary<string, ActiveUnit> concurrentDictionary_0;

		// Token: 0x04000954 RID: 2388
		protected int int_0;

		// Token: 0x04000955 RID: 2389
		protected Contact_Base.IdentificationStatus identificationStatus_0;

		// Token: 0x04000956 RID: 2390
		public Side side_1;

		// Token: 0x04000957 RID: 2391
		protected string string_4;

		// Token: 0x020001CA RID: 458
		public enum ContactType : byte
		{
			// Token: 0x04000959 RID: 2393
			Air,
			// Token: 0x0400095A RID: 2394
			Missile,
			// Token: 0x0400095B RID: 2395
			Surface,
			// Token: 0x0400095C RID: 2396
			Submarine,
			// Token: 0x0400095D RID: 2397
			UndeterminedNaval,
			// Token: 0x0400095E RID: 2398
			Aimpoint,
			// Token: 0x0400095F RID: 2399
			Orbital,
			// Token: 0x04000960 RID: 2400
			Facility_Fixed,
			// Token: 0x04000961 RID: 2401
			Facility_Mobile,
			// Token: 0x04000962 RID: 2402
			Torpedo,
			// Token: 0x04000963 RID: 2403
			Mine,
			// Token: 0x04000964 RID: 2404
			Explosion,
			// Token: 0x04000965 RID: 2405
			Undetermined,
			// Token: 0x04000966 RID: 2406
			Decoy_Air,
			// Token: 0x04000967 RID: 2407
			Decoy_Surface,
			// Token: 0x04000968 RID: 2408
			Decoy_Land,
			// Token: 0x04000969 RID: 2409
			Decoy_Sub,
			// Token: 0x0400096A RID: 2410
			Sonobuoy,
			// Token: 0x0400096B RID: 2411
			Installation,
			// Token: 0x0400096C RID: 2412
			AirBase,
			// Token: 0x0400096D RID: 2413
			NavalBase,
			// Token: 0x0400096E RID: 2414
			MobileGroup,
			// Token: 0x0400096F RID: 2415
			ActivationPoint
		}

		// Token: 0x020001CB RID: 459
		public enum IdentificationStatus : short
		{
			// Token: 0x04000971 RID: 2417
			Unknown,
			// Token: 0x04000972 RID: 2418
			KnownDomain,
			// Token: 0x04000973 RID: 2419
			KnownType,
			// Token: 0x04000974 RID: 2420
			KnownClass,
			// Token: 0x04000975 RID: 2421
			PreciseID
		}
	}
}
