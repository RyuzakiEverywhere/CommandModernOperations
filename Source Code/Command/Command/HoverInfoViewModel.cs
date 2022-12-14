using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns14;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000DEE RID: 3566
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class HoverInfoViewModel : INotifyPropertyChanged
	{
		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06006724 RID: 26404 RVA: 0x00041401 File Offset: 0x0003F601
		// (set) Token: 0x06006725 RID: 26405 RVA: 0x00041409 File Offset: 0x0003F609
		public Unit Unit
		{
			[CompilerGenerated]
			get
			{
				return this.unit_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.unit_0 == value)
				{
					return;
				}
				this.unit_0 = value;
				this.vmethod_0("Unit");
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06006726 RID: 26406 RVA: 0x00041429 File Offset: 0x0003F629
		// (set) Token: 0x06006727 RID: 26407 RVA: 0x00041431 File Offset: 0x0003F631
		public string UnitName
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
				this.vmethod_0("UnitName");
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06006728 RID: 26408 RVA: 0x00041455 File Offset: 0x0003F655
		// (set) Token: 0x06006729 RID: 26409 RVA: 0x0004145D File Offset: 0x0003F65D
		public string UnitType
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
				this.vmethod_0("UnitType");
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600672A RID: 26410 RVA: 0x00041481 File Offset: 0x0003F681
		// (set) Token: 0x0600672B RID: 26411 RVA: 0x00041489 File Offset: 0x0003F689
		public string SideString
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
				this.vmethod_0("SideString");
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600672C RID: 26412 RVA: 0x000414AD File Offset: 0x0003F6AD
		// (set) Token: 0x0600672D RID: 26413 RVA: 0x000414B5 File Offset: 0x0003F6B5
		public string CourseString
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
				this.vmethod_0("CourseString");
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600672E RID: 26414 RVA: 0x000414D9 File Offset: 0x0003F6D9
		// (set) Token: 0x0600672F RID: 26415 RVA: 0x000414E1 File Offset: 0x0003F6E1
		public string SpeedString
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
				this.vmethod_0("SpeedString");
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06006730 RID: 26416 RVA: 0x00041505 File Offset: 0x0003F705
		// (set) Token: 0x06006731 RID: 26417 RVA: 0x0004150D File Offset: 0x0003F70D
		public string AltString
		{
			[CompilerGenerated]
			get
			{
				return this.string_5;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_5, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_5 = value;
				this.vmethod_0("AltString");
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06006732 RID: 26418 RVA: 0x00041531 File Offset: 0x0003F731
		// (set) Token: 0x06006733 RID: 26419 RVA: 0x00041539 File Offset: 0x0003F739
		public string StatusString
		{
			[CompilerGenerated]
			get
			{
				return this.string_6;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_6, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_6 = value;
				this.vmethod_0("StatusString");
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06006734 RID: 26420 RVA: 0x0004155D File Offset: 0x0003F75D
		// (set) Token: 0x06006735 RID: 26421 RVA: 0x00041565 File Offset: 0x0003F765
		public string LoadoutString
		{
			[CompilerGenerated]
			get
			{
				return this.string_7;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_7, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_7 = value;
				this.vmethod_0("LoadoutString");
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06006736 RID: 26422 RVA: 0x00041589 File Offset: 0x0003F789
		// (set) Token: 0x06006737 RID: 26423 RVA: 0x00041591 File Offset: 0x0003F791
		public BitmapImage ImageSource
		{
			[CompilerGenerated]
			get
			{
				return this.bitmapImage_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.bitmapImage_0 == value)
				{
					return;
				}
				this.bitmapImage_0 = value;
				this.vmethod_0("ImageSource");
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06006738 RID: 26424 RVA: 0x000415B1 File Offset: 0x0003F7B1
		// (set) Token: 0x06006739 RID: 26425 RVA: 0x000415B9 File Offset: 0x0003F7B9
		public List<BitmapImage> GroupImages
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
				this.vmethod_0("GroupImages");
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600673A RID: 26426 RVA: 0x000415D9 File Offset: 0x0003F7D9
		// (set) Token: 0x0600673B RID: 26427 RVA: 0x000415E1 File Offset: 0x0003F7E1
		public Visibility GroupMembersVisibility
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
				this.vmethod_0("GroupMembersVisibility");
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600673C RID: 26428 RVA: 0x00041601 File Offset: 0x0003F801
		// (set) Token: 0x0600673D RID: 26429 RVA: 0x00041609 File Offset: 0x0003F809
		public List<HoverInfoGroupMemberViewModel> GroupMembers
		{
			[CompilerGenerated]
			get
			{
				return this.list_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.list_1 == value)
				{
					return;
				}
				this.list_1 = value;
				this.vmethod_0("GroupMembers");
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600673E RID: 26430 RVA: 0x00041629 File Offset: 0x0003F829
		// (set) Token: 0x0600673F RID: 26431 RVA: 0x00041631 File Offset: 0x0003F831
		public Visibility MissionVisibility
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
				this.vmethod_0("MissionVisibility");
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06006740 RID: 26432 RVA: 0x00041651 File Offset: 0x0003F851
		// (set) Token: 0x06006741 RID: 26433 RVA: 0x00041659 File Offset: 0x0003F859
		public string MissionName
		{
			[CompilerGenerated]
			get
			{
				return this.string_8;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_8, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_8 = value;
				this.vmethod_0("MissionName");
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06006742 RID: 26434 RVA: 0x0004167D File Offset: 0x0003F87D
		// (set) Token: 0x06006743 RID: 26435 RVA: 0x00041685 File Offset: 0x0003F885
		public string MissionClass
		{
			[CompilerGenerated]
			get
			{
				return this.string_9;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_9, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_9 = value;
				this.vmethod_0("MissionClass");
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06006744 RID: 26436 RVA: 0x000416A9 File Offset: 0x0003F8A9
		// (set) Token: 0x06006745 RID: 26437 RVA: 0x000416B1 File Offset: 0x0003F8B1
		public string MissionStatus
		{
			[CompilerGenerated]
			get
			{
				return this.string_10;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_10, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_10 = value;
				this.vmethod_0("MissionStatus");
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06006746 RID: 26438 RVA: 0x000416D5 File Offset: 0x0003F8D5
		// (set) Token: 0x06006747 RID: 26439 RVA: 0x000416DD File Offset: 0x0003F8DD
		public string TypeString
		{
			[CompilerGenerated]
			get
			{
				return this.string_11;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_11, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_11 = value;
				this.vmethod_0("TypeString");
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06006748 RID: 26440 RVA: 0x00041701 File Offset: 0x0003F901
		// (set) Token: 0x06006749 RID: 26441 RVA: 0x00041709 File Offset: 0x0003F909
		public int AIR_LR
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
				this.vmethod_0("AIR_LR");
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600674A RID: 26442 RVA: 0x00041729 File Offset: 0x0003F929
		// (set) Token: 0x0600674B RID: 26443 RVA: 0x00041731 File Offset: 0x0003F931
		public int SURF_LR
		{
			[CompilerGenerated]
			get
			{
				return this.int_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_1 == value)
				{
					return;
				}
				this.int_1 = value;
				this.vmethod_0("SURF_LR");
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600674C RID: 26444 RVA: 0x00041751 File Offset: 0x0003F951
		// (set) Token: 0x0600674D RID: 26445 RVA: 0x00041759 File Offset: 0x0003F959
		public int LAND_LR
		{
			[CompilerGenerated]
			get
			{
				return this.int_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_2 == value)
				{
					return;
				}
				this.int_2 = value;
				this.vmethod_0("LAND_LR");
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600674E RID: 26446 RVA: 0x00041779 File Offset: 0x0003F979
		// (set) Token: 0x0600674F RID: 26447 RVA: 0x00041781 File Offset: 0x0003F981
		public int SUB_LR
		{
			[CompilerGenerated]
			get
			{
				return this.int_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_3 == value)
				{
					return;
				}
				this.int_3 = value;
				this.vmethod_0("SUB_LR");
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06006750 RID: 26448 RVA: 0x000417A1 File Offset: 0x0003F9A1
		// (set) Token: 0x06006751 RID: 26449 RVA: 0x000417A9 File Offset: 0x0003F9A9
		public int AIR_MR
		{
			[CompilerGenerated]
			get
			{
				return this.int_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_4 == value)
				{
					return;
				}
				this.int_4 = value;
				this.vmethod_0("AIR_MR");
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06006752 RID: 26450 RVA: 0x000417C9 File Offset: 0x0003F9C9
		// (set) Token: 0x06006753 RID: 26451 RVA: 0x000417D1 File Offset: 0x0003F9D1
		public int SURF_MR
		{
			[CompilerGenerated]
			get
			{
				return this.int_5;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_5 == value)
				{
					return;
				}
				this.int_5 = value;
				this.vmethod_0("SURF_MR");
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06006754 RID: 26452 RVA: 0x000417F1 File Offset: 0x0003F9F1
		// (set) Token: 0x06006755 RID: 26453 RVA: 0x000417F9 File Offset: 0x0003F9F9
		public int LAND_MR
		{
			[CompilerGenerated]
			get
			{
				return this.int_6;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_6 == value)
				{
					return;
				}
				this.int_6 = value;
				this.vmethod_0("LAND_MR");
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06006756 RID: 26454 RVA: 0x00041819 File Offset: 0x0003FA19
		// (set) Token: 0x06006757 RID: 26455 RVA: 0x00041821 File Offset: 0x0003FA21
		public int SUB_MR
		{
			[CompilerGenerated]
			get
			{
				return this.int_7;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_7 == value)
				{
					return;
				}
				this.int_7 = value;
				this.vmethod_0("SUB_MR");
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06006758 RID: 26456 RVA: 0x00041841 File Offset: 0x0003FA41
		// (set) Token: 0x06006759 RID: 26457 RVA: 0x00041849 File Offset: 0x0003FA49
		public int AIR_SR
		{
			[CompilerGenerated]
			get
			{
				return this.int_8;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_8 == value)
				{
					return;
				}
				this.int_8 = value;
				this.vmethod_0("AIR_SR");
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600675A RID: 26458 RVA: 0x00041869 File Offset: 0x0003FA69
		// (set) Token: 0x0600675B RID: 26459 RVA: 0x00041871 File Offset: 0x0003FA71
		public int SURF_SR
		{
			[CompilerGenerated]
			get
			{
				return this.int_9;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_9 == value)
				{
					return;
				}
				this.int_9 = value;
				this.vmethod_0("SURF_SR");
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600675C RID: 26460 RVA: 0x00041891 File Offset: 0x0003FA91
		// (set) Token: 0x0600675D RID: 26461 RVA: 0x00041899 File Offset: 0x0003FA99
		public int LAND_SR
		{
			[CompilerGenerated]
			get
			{
				return this.int_10;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_10 == value)
				{
					return;
				}
				this.int_10 = value;
				this.vmethod_0("LAND_SR");
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600675E RID: 26462 RVA: 0x000418B9 File Offset: 0x0003FAB9
		// (set) Token: 0x0600675F RID: 26463 RVA: 0x000418C1 File Offset: 0x0003FAC1
		public int SUB_SR
		{
			[CompilerGenerated]
			get
			{
				return this.int_11;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_11 == value)
				{
					return;
				}
				this.int_11 = value;
				this.vmethod_0("SUB_SR");
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06006760 RID: 26464 RVA: 0x000418E1 File Offset: 0x0003FAE1
		// (set) Token: 0x06006761 RID: 26465 RVA: 0x000418E9 File Offset: 0x0003FAE9
		public Visibility RadarOnVisibility
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
				this.vmethod_0("RadarOnVisibility");
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06006762 RID: 26466 RVA: 0x00041909 File Offset: 0x0003FB09
		// (set) Token: 0x06006763 RID: 26467 RVA: 0x00041911 File Offset: 0x0003FB11
		public Visibility SonarOnVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_3 == value)
				{
					return;
				}
				this.visibility_3 = value;
				this.vmethod_0("SonarOnVisibility");
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06006764 RID: 26468 RVA: 0x00041931 File Offset: 0x0003FB31
		// (set) Token: 0x06006765 RID: 26469 RVA: 0x00041939 File Offset: 0x0003FB39
		public Visibility OECMOnVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_4 == value)
				{
					return;
				}
				this.visibility_4 = value;
				this.vmethod_0("OECMOnVisibility");
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06006766 RID: 26470 RVA: 0x00041959 File Offset: 0x0003FB59
		// (set) Token: 0x06006767 RID: 26471 RVA: 0x00041961 File Offset: 0x0003FB61
		public Visibility RadarOffVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_5;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_5 == value)
				{
					return;
				}
				this.visibility_5 = value;
				this.vmethod_0("RadarOffVisibility");
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06006768 RID: 26472 RVA: 0x00041981 File Offset: 0x0003FB81
		// (set) Token: 0x06006769 RID: 26473 RVA: 0x00041989 File Offset: 0x0003FB89
		public Visibility SonarOffVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_6;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_6 == value)
				{
					return;
				}
				this.visibility_6 = value;
				this.vmethod_0("SonarOffVisibility");
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600676A RID: 26474 RVA: 0x000419A9 File Offset: 0x0003FBA9
		// (set) Token: 0x0600676B RID: 26475 RVA: 0x000419B1 File Offset: 0x0003FBB1
		public Visibility OECMOffVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_7;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_7 == value)
				{
					return;
				}
				this.visibility_7 = value;
				this.vmethod_0("OECMOffVisibility");
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600676C RID: 26476 RVA: 0x000419D1 File Offset: 0x0003FBD1
		// (set) Token: 0x0600676D RID: 26477 RVA: 0x000419D9 File Offset: 0x0003FBD9
		public Visibility SensorVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_8;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_8 == value)
				{
					return;
				}
				this.visibility_8 = value;
				this.vmethod_0("SensorVisibility");
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600676E RID: 26478 RVA: 0x000419F9 File Offset: 0x0003FBF9
		// (set) Token: 0x0600676F RID: 26479 RVA: 0x00041A01 File Offset: 0x0003FC01
		public Visibility AirParasiteVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_9;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_9 == value)
				{
					return;
				}
				this.visibility_9 = value;
				this.vmethod_0("AirParasiteVisibility");
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06006770 RID: 26480 RVA: 0x00041A21 File Offset: 0x0003FC21
		// (set) Token: 0x06006771 RID: 26481 RVA: 0x00041A29 File Offset: 0x0003FC29
		public List<HoverInfoParasiteViewModel> AirParasites
		{
			[CompilerGenerated]
			get
			{
				return this.list_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.list_2 == value)
				{
					return;
				}
				this.list_2 = value;
				this.vmethod_0("AirParasites");
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06006772 RID: 26482 RVA: 0x00041A49 File Offset: 0x0003FC49
		// (set) Token: 0x06006773 RID: 26483 RVA: 0x00041A51 File Offset: 0x0003FC51
		public Visibility BoatParasiteVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_10;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_10 == value)
				{
					return;
				}
				this.visibility_10 = value;
				this.vmethod_0("BoatParasiteVisibility");
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06006774 RID: 26484 RVA: 0x00041A71 File Offset: 0x0003FC71
		// (set) Token: 0x06006775 RID: 26485 RVA: 0x00041A79 File Offset: 0x0003FC79
		public List<HoverInfoParasiteViewModel> BoatParasites
		{
			[CompilerGenerated]
			get
			{
				return this.list_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.list_3 == value)
				{
					return;
				}
				this.list_3 = value;
				this.vmethod_0("BoatParasites");
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06006776 RID: 26486 RVA: 0x00041A99 File Offset: 0x0003FC99
		// (set) Token: 0x06006777 RID: 26487 RVA: 0x00041AA1 File Offset: 0x0003FCA1
		public Visibility CargoVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_11;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_11 == value)
				{
					return;
				}
				this.visibility_11 = value;
				this.vmethod_0("CargoVisibility");
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06006778 RID: 26488 RVA: 0x00041AC1 File Offset: 0x0003FCC1
		// (set) Token: 0x06006779 RID: 26489 RVA: 0x00041AC9 File Offset: 0x0003FCC9
		public List<HoverInfoCargoViewModel> Cargo
		{
			[CompilerGenerated]
			get
			{
				return this.list_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.list_4 == value)
				{
					return;
				}
				this.list_4 = value;
				this.vmethod_0("Cargo");
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600677A RID: 26490 RVA: 0x00041AE9 File Offset: 0x0003FCE9
		// (set) Token: 0x0600677B RID: 26491 RVA: 0x00041AF1 File Offset: 0x0003FCF1
		public Visibility WeaponSummaryVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_12;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_12 == value)
				{
					return;
				}
				this.visibility_12 = value;
				this.vmethod_0("WeaponSummaryVisibility");
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600677C RID: 26492 RVA: 0x00041B11 File Offset: 0x0003FD11
		// (set) Token: 0x0600677D RID: 26493 RVA: 0x00041B19 File Offset: 0x0003FD19
		public Visibility WeaponDetailsVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_13;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_13 == value)
				{
					return;
				}
				this.visibility_13 = value;
				this.vmethod_0("WeaponDetailsVisibility");
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600677E RID: 26494 RVA: 0x00041B39 File Offset: 0x0003FD39
		// (set) Token: 0x0600677F RID: 26495 RVA: 0x00041B41 File Offset: 0x0003FD41
		public Visibility WeaponVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_14;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_14 == value)
				{
					return;
				}
				this.visibility_14 = value;
				this.vmethod_0("WeaponVisibility");
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06006780 RID: 26496 RVA: 0x00041B61 File Offset: 0x0003FD61
		// (set) Token: 0x06006781 RID: 26497 RVA: 0x00041B69 File Offset: 0x0003FD69
		public List<HoverInfoWeaponViewModel> WeaponsDetails
		{
			[CompilerGenerated]
			get
			{
				return this.list_5;
			}
			[CompilerGenerated]
			set
			{
				if (this.list_5 == value)
				{
					return;
				}
				this.list_5 = value;
				this.vmethod_0("WeaponsDetails");
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06006782 RID: 26498 RVA: 0x00041B89 File Offset: 0x0003FD89
		// (set) Token: 0x06006783 RID: 26499 RVA: 0x00041B91 File Offset: 0x0003FD91
		public Visibility MountsDetailsVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_15;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_15 == value)
				{
					return;
				}
				this.visibility_15 = value;
				this.vmethod_0("MountsDetailsVisibility");
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06006784 RID: 26500 RVA: 0x00041BB1 File Offset: 0x0003FDB1
		// (set) Token: 0x06006785 RID: 26501 RVA: 0x00041BB9 File Offset: 0x0003FDB9
		public List<HoverInfoMountViewModel> MountsDetails
		{
			[CompilerGenerated]
			get
			{
				return this.list_6;
			}
			[CompilerGenerated]
			set
			{
				if (this.list_6 == value)
				{
					return;
				}
				this.list_6 = value;
				this.vmethod_0("MountsDetails");
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06006786 RID: 26502 RVA: 0x00041BD9 File Offset: 0x0003FDD9
		// (set) Token: 0x06006787 RID: 26503 RVA: 0x00041BE1 File Offset: 0x0003FDE1
		public string ContactClass
		{
			[CompilerGenerated]
			get
			{
				return this.string_12;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_12, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_12 = value;
				this.vmethod_0("ContactClass");
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06006788 RID: 26504 RVA: 0x00041C05 File Offset: 0x0003FE05
		// (set) Token: 0x06006789 RID: 26505 RVA: 0x00041C0D File Offset: 0x0003FE0D
		public string UnitDamage
		{
			[CompilerGenerated]
			get
			{
				return this.string_13;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_13, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_13 = value;
				this.vmethod_0("UnitDamage");
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600678A RID: 26506 RVA: 0x00041C31 File Offset: 0x0003FE31
		// (set) Token: 0x0600678B RID: 26507 RVA: 0x00041C39 File Offset: 0x0003FE39
		public FuelViewModel FuelViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.fuelViewModel_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.fuelViewModel_0 == value)
				{
					return;
				}
				this.fuelViewModel_0 = value;
				this.vmethod_0("FuelViewModel");
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600678C RID: 26508 RVA: 0x00041C59 File Offset: 0x0003FE59
		// (set) Token: 0x0600678D RID: 26509 RVA: 0x00041C61 File Offset: 0x0003FE61
		public Visibility FuelSummaryVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_16;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_16 == value)
				{
					return;
				}
				this.visibility_16 = value;
				this.vmethod_0("FuelSummaryVisibility");
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600678E RID: 26510 RVA: 0x00041C81 File Offset: 0x0003FE81
		// (set) Token: 0x0600678F RID: 26511 RVA: 0x00041C89 File Offset: 0x0003FE89
		public Visibility FuelDetailsVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_17;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_17 == value)
				{
					return;
				}
				this.visibility_17 = value;
				this.vmethod_0("FuelDetailsVisibility");
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06006790 RID: 26512 RVA: 0x00041CA9 File Offset: 0x0003FEA9
		// (set) Token: 0x06006791 RID: 26513 RVA: 0x00041CB1 File Offset: 0x0003FEB1
		public Visibility DamageVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_18;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_18 == value)
				{
					return;
				}
				this.visibility_18 = value;
				this.vmethod_0("DamageVisibility");
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06006792 RID: 26514 RVA: 0x00041CD1 File Offset: 0x0003FED1
		// (set) Token: 0x06006793 RID: 26515 RVA: 0x00041CD9 File Offset: 0x0003FED9
		public Visibility DamageComponentVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_19;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_19 == value)
				{
					return;
				}
				this.visibility_19 = value;
				this.vmethod_0("DamageComponentVisibility");
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06006794 RID: 26516 RVA: 0x00041CF9 File Offset: 0x0003FEF9
		// (set) Token: 0x06006795 RID: 26517 RVA: 0x00041D01 File Offset: 0x0003FF01
		public Visibility DamageFireVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_20;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_20 == value)
				{
					return;
				}
				this.visibility_20 = value;
				this.vmethod_0("DamageFireVisibility");
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06006796 RID: 26518 RVA: 0x00041D21 File Offset: 0x0003FF21
		// (set) Token: 0x06006797 RID: 26519 RVA: 0x00041D29 File Offset: 0x0003FF29
		public Visibility DamageFloodVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_21;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_21 == value)
				{
					return;
				}
				this.visibility_21 = value;
				this.vmethod_0("DamageFloodVisibility");
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06006798 RID: 26520 RVA: 0x00041D49 File Offset: 0x0003FF49
		// (set) Token: 0x06006799 RID: 26521 RVA: 0x00041D51 File Offset: 0x0003FF51
		public Visibility DamagePointsVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_22;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_22 == value)
				{
					return;
				}
				this.visibility_22 = value;
				this.vmethod_0("DamagePointsVisibility");
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x0600679A RID: 26522 RVA: 0x00041D71 File Offset: 0x0003FF71
		// (set) Token: 0x0600679B RID: 26523 RVA: 0x00041D79 File Offset: 0x0003FF79
		public GridLength DamageComponentOK
		{
			[CompilerGenerated]
			get
			{
				return this.gridLength_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.gridLength_0 == value)
				{
					return;
				}
				this.gridLength_0 = value;
				this.vmethod_0("DamageComponentOK");
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600679C RID: 26524 RVA: 0x00041D9C File Offset: 0x0003FF9C
		// (set) Token: 0x0600679D RID: 26525 RVA: 0x00041DA4 File Offset: 0x0003FFA4
		public GridLength DamageComponentLight
		{
			[CompilerGenerated]
			get
			{
				return this.gridLength_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.gridLength_1 == value)
				{
					return;
				}
				this.gridLength_1 = value;
				this.vmethod_0("DamageComponentLight");
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600679E RID: 26526 RVA: 0x00041DC7 File Offset: 0x0003FFC7
		// (set) Token: 0x0600679F RID: 26527 RVA: 0x00041DCF File Offset: 0x0003FFCF
		public GridLength DamageComponentMedium
		{
			[CompilerGenerated]
			get
			{
				return this.gridLength_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.gridLength_2 == value)
				{
					return;
				}
				this.gridLength_2 = value;
				this.vmethod_0("DamageComponentMedium");
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060067A0 RID: 26528 RVA: 0x00041DF2 File Offset: 0x0003FFF2
		// (set) Token: 0x060067A1 RID: 26529 RVA: 0x00041DFA File Offset: 0x0003FFFA
		public GridLength DamageComponentHeavy
		{
			[CompilerGenerated]
			get
			{
				return this.gridLength_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.gridLength_3 == value)
				{
					return;
				}
				this.gridLength_3 = value;
				this.vmethod_0("DamageComponentHeavy");
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060067A2 RID: 26530 RVA: 0x00041E1D File Offset: 0x0004001D
		// (set) Token: 0x060067A3 RID: 26531 RVA: 0x00041E25 File Offset: 0x00040025
		public GridLength DamageComponentDestroyed
		{
			[CompilerGenerated]
			get
			{
				return this.gridLength_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.gridLength_4 == value)
				{
					return;
				}
				this.gridLength_4 = value;
				this.vmethod_0("DamageComponentDestroyed");
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060067A4 RID: 26532 RVA: 0x00041E48 File Offset: 0x00040048
		// (set) Token: 0x060067A5 RID: 26533 RVA: 0x00041E50 File Offset: 0x00040050
		public int DamageFlood
		{
			[CompilerGenerated]
			get
			{
				return this.int_12;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_12 == value)
				{
					return;
				}
				this.int_12 = value;
				this.vmethod_0("DamageFlood");
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060067A6 RID: 26534 RVA: 0x00041E70 File Offset: 0x00040070
		// (set) Token: 0x060067A7 RID: 26535 RVA: 0x00041E78 File Offset: 0x00040078
		public int DamageFire
		{
			[CompilerGenerated]
			get
			{
				return this.int_13;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_13 == value)
				{
					return;
				}
				this.int_13 = value;
				this.vmethod_0("DamageFire");
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060067A8 RID: 26536 RVA: 0x00041E98 File Offset: 0x00040098
		// (set) Token: 0x060067A9 RID: 26537 RVA: 0x00041EA0 File Offset: 0x000400A0
		public int DamagePoints
		{
			[CompilerGenerated]
			get
			{
				return this.int_14;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_14 == value)
				{
					return;
				}
				this.int_14 = value;
				this.vmethod_0("DamagePoints");
			}
		}

		// Token: 0x060067AA RID: 26538 RVA: 0x00041EC0 File Offset: 0x000400C0
		public HoverInfoViewModel(ContentControl MyContentControl, ElementHost theElementHost)
		{
			this.contentControl_0 = MyContentControl;
			this.elementHost_0 = theElementHost;
		}

		// Token: 0x060067AB RID: 26539 RVA: 0x00387184 File Offset: 0x00385384
		public void method_0(Unit theUnit)
		{
			this.Unit = theUnit;
			this.UnitName = theUnit.Name;
			this.UnitType = theUnit.string_2;
			this.SideString = string.Format("Side: {0}", theUnit.vmethod_7(false).method_51());
			this.CourseString = string.Format("Course: {0:00}°", theUnit.vmethod_9());
			this.SpeedString = string.Format("Speed: {0:0} kts", theUnit.vmethod_40());
			int num;
			int num2;
			Class2572.smethod_4(Class2413.smethod_2().method_41().vmethod_796(), theUnit.vmethod_30(null), theUnit.vmethod_28(null), ref num, ref num2);
			this.elementHost_0.Top = 0;
			this.elementHost_0.Left = -1000;
			this.elementHost_0.Height = 1000;
			if (theUnit is Weapon)
			{
				Weapon weapon = (Weapon)theUnit;
				this.StatusString = "Status: " + Misc.smethod_57(weapon.vmethod_108(), weapon);
				this.LoadoutString = "";
				this.method_15();
			}
			else if (theUnit is Contact)
			{
				this.method_3();
			}
			else if (theUnit is Group)
			{
				Group group = (Group)theUnit;
				this.StatusString = "Status: " + Misc.smethod_57(group.vmethod_108(), group);
				this.LoadoutString = "";
				if (Enumerable.Any<ActiveUnit>(group.vmethod_141().Values, (HoverInfoViewModel._Closure$__.$I273-0 == null) ? (HoverInfoViewModel._Closure$__.$I273-0 = new Func<ActiveUnit, bool>(HoverInfoViewModel._Closure$__.$I.method_0)) : HoverInfoViewModel._Closure$__.$I273-0))
				{
					this.LoadoutString = ((Aircraft)Enumerable.First<ActiveUnit>(group.vmethod_141().Values)).method_165();
				}
				this.method_18();
				this.method_8();
				this.method_14();
				this.method_12();
				this.method_13();
				this.method_16();
				this.method_17();
				this.method_5();
				this.method_1();
			}
			else if (theUnit is ActiveUnit)
			{
				ActiveUnit activeUnit = (ActiveUnit)theUnit;
				this.StatusString = "Status: " + Misc.smethod_57(activeUnit.vmethod_108(), activeUnit);
				if (activeUnit.vmethod_56() == GlobalVariables.ActiveUnitType.Aircraft)
				{
					this.LoadoutString = ((Aircraft)activeUnit).method_165();
				}
				this.method_6();
				this.method_15();
				this.method_18();
				this.method_2();
				this.method_7();
				this.method_13();
				this.method_16();
				this.method_17();
				this.method_5();
				this.method_1();
			}
			HoverInfoViewModel.dispatcherTimer_0.Interval = TimeSpan.FromMilliseconds(1.0);
			HoverInfoViewModel.dispatcherTimer_0.Tick += this.method_4;
			HoverInfoViewModel.dispatcherTimer_0.Start();
		}

		// Token: 0x060067AC RID: 26540 RVA: 0x00387448 File Offset: 0x00385648
		private void method_1()
		{
			ActiveUnit activeUnit = (ActiveUnit)this.Unit;
			if (activeUnit.bool_6 && ((Ship)activeUnit).method_151())
			{
				this.FuelSummaryVisibility = Visibility.Collapsed;
				this.FuelDetailsVisibility = Visibility.Collapsed;
			}
			else if (activeUnit.bool_5 && (((Submarine)activeUnit).method_160() || Enumerable.Count<FuelRec>(((Submarine)activeUnit).vmethod_67()) == 0))
			{
				this.FuelSummaryVisibility = Visibility.Collapsed;
				this.FuelDetailsVisibility = Visibility.Collapsed;
			}
			else if (activeUnit.bool_8)
			{
				this.FuelSummaryVisibility = Visibility.Collapsed;
				this.FuelDetailsVisibility = Visibility.Collapsed;
			}
			else if (activeUnit.bool_2)
			{
				this.FuelSummaryVisibility = Visibility.Collapsed;
				this.FuelDetailsVisibility = Visibility.Collapsed;
			}
			else if (activeUnit.method_1())
			{
				this.FuelSummaryVisibility = Visibility.Collapsed;
				this.FuelDetailsVisibility = Visibility.Collapsed;
			}
			else
			{
				this.FuelViewModel = new FuelViewModel(activeUnit);
				this.FuelSummaryVisibility = Visibility.Visible;
				this.FuelDetailsVisibility = Visibility.Visible;
			}
			if (HoverInfoOptionsViewModel.Singleton.Fuel == HoverInfoEnableDetailedEnum.const_0)
			{
				this.FuelSummaryVisibility = Visibility.Collapsed;
				return;
			}
			if (HoverInfoOptionsViewModel.Singleton.Fuel == HoverInfoEnableDetailedEnum.const_1)
			{
				this.FuelDetailsVisibility = Visibility.Collapsed;
				return;
			}
			this.FuelSummaryVisibility = Visibility.Collapsed;
			this.FuelDetailsVisibility = Visibility.Collapsed;
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x0038755C File Offset: 0x0038575C
		private void method_2()
		{
			ActiveUnit activeUnit = (ActiveUnit)this.Unit;
			int num;
			int num2;
			int num3;
			int num4;
			int num5;
			int num6;
			try
			{
				foreach (PlatformComponent platformComponent in activeUnit.vmethod_120())
				{
					switch (platformComponent.vmethod_5())
					{
					case PlatformComponent._ComponentStatus.Operational:
						num++;
						break;
					case PlatformComponent._ComponentStatus.Damaged:
						switch (platformComponent.method_16())
						{
						case PlatformComponent._DamageSeverityFactor.Light:
							num2++;
							break;
						case PlatformComponent._DamageSeverityFactor.Medium:
							num3++;
							break;
						case PlatformComponent._DamageSeverityFactor.Heavy:
							num4++;
							break;
						}
						break;
					case PlatformComponent._ComponentStatus.Destroyed:
						num5++;
						break;
					}
					num6++;
				}
			}
			finally
			{
				IEnumerator<PlatformComponent> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.DamageComponentOK = new GridLength((double)num, GridUnitType.Star);
			this.DamageComponentLight = new GridLength((double)num2, GridUnitType.Star);
			this.DamageComponentMedium = new GridLength((double)num3, GridUnitType.Star);
			this.DamageComponentHeavy = new GridLength((double)num4, GridUnitType.Star);
			this.DamageComponentDestroyed = new GridLength((double)num5, GridUnitType.Star);
			switch (activeUnit.vmethod_91().vmethod_1())
			{
			case ActiveUnit_Damage.FloodingIntensityLevel.NoFlooding:
				this.DamageFlood = 0;
				break;
			case ActiveUnit_Damage.FloodingIntensityLevel.Minor:
				this.DamageFlood = 25;
				break;
			case ActiveUnit_Damage.FloodingIntensityLevel.Major:
				this.DamageFlood = 50;
				break;
			case ActiveUnit_Damage.FloodingIntensityLevel.Severe:
				this.DamageFlood = 75;
				break;
			case ActiveUnit_Damage.FloodingIntensityLevel.Capsizing:
				this.DamageFlood = 100;
				break;
			}
			switch (activeUnit.vmethod_91().vmethod_3())
			{
			case ActiveUnit_Damage.FireIntensityLevel.NoFire:
				this.DamageFire = 0;
				break;
			case ActiveUnit_Damage.FireIntensityLevel.Minor:
				this.DamageFire = 25;
				break;
			case ActiveUnit_Damage.FireIntensityLevel.Major:
				this.DamageFire = 50;
				break;
			case ActiveUnit_Damage.FireIntensityLevel.Severe:
				this.DamageFire = 75;
				break;
			case ActiveUnit_Damage.FireIntensityLevel.Conflagration:
				this.DamageFire = 100;
				break;
			}
			this.DamagePoints = (int)Math.Round((double)activeUnit.vmethod_91().method_0());
			if (HoverInfoOptionsViewModel.Singleton.Damage == HoverInfoEnableEnum.const_1)
			{
				this.DamageVisibility = Visibility.Collapsed;
				this.DamageComponentVisibility = Visibility.Collapsed;
				this.DamageFireVisibility = Visibility.Collapsed;
				this.DamageFloodVisibility = Visibility.Collapsed;
				this.DamagePointsVisibility = Visibility.Collapsed;
				return;
			}
			this.DamageVisibility = Visibility.Collapsed;
			if (this.DamageFire > 1)
			{
				this.DamageVisibility = Visibility.Visible;
				this.DamageFireVisibility = Visibility.Visible;
			}
			else
			{
				this.DamageFireVisibility = Visibility.Collapsed;
			}
			if (this.DamageFlood > 1)
			{
				this.DamageVisibility = Visibility.Visible;
				this.DamageFloodVisibility = Visibility.Visible;
			}
			else
			{
				this.DamageFloodVisibility = Visibility.Collapsed;
			}
			if (this.DamagePoints > 1)
			{
				this.DamageVisibility = Visibility.Visible;
				this.DamagePointsVisibility = Visibility.Visible;
			}
			else
			{
				this.DamagePointsVisibility = Visibility.Collapsed;
			}
			if (num6 != num)
			{
				this.DamageVisibility = Visibility.Visible;
				this.DamageComponentVisibility = Visibility.Visible;
				return;
			}
			this.DamageComponentVisibility = Visibility.Collapsed;
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x003877DC File Offset: 0x003859DC
		private void method_3()
		{
			Contact contact = (Contact)this.Unit;
			if (contact.method_125() > Contact_Base.IdentificationStatus.KnownType)
			{
				this.ContactClass = Misc.smethod_9(contact.activeUnit_0.string_2);
				if (Class570.class280_0.method_42())
				{
					this.ImageSource = Class2564.smethod_0(Class2564.smethod_2(contact.activeUnit_0));
				}
			}
			else
			{
				this.ContactClass = "Unknown class";
			}
			this.CourseString = string.Format("Course: {0}", contact.method_88());
			if ((contact.contactType_0 == Contact_Base.ContactType.Air | contact.contactType_0 == Contact_Base.ContactType.Missile) & contact.bool_19)
			{
				this.SpeedString = string.Concat(new string[]
				{
					"Speed: ",
					Conversions.ToString((int)Math.Round((double)contact.vmethod_40())),
					" kts (M ",
					string.Format("{0:0.00}", Class437.smethod_0((double)contact.vmethod_14(false), (double)contact.vmethod_40())),
					")"
				});
			}
			else
			{
				this.SpeedString = "Speed: " + contact.method_89();
			}
			if (contact.bool_12)
			{
				if (!Information.IsNothing(contact.activeUnit_0.vmethod_7(false)))
				{
					this.SideString = "Side: " + contact.activeUnit_0.vmethod_7(false).method_51();
				}
			}
			else
			{
				this.SideString = "Side: Unknown";
			}
			this.UnitDamage = "BDA: " + Misc.smethod_54(contact.method_74(Client.smethod_50()));
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x0038795C File Offset: 0x00385B5C
		private void method_4(object sender, EventArgs e)
		{
			HoverInfoViewModel.dispatcherTimer_0.Stop();
			HoverInfoViewModel.dispatcherTimer_0.Tick -= this.method_4;
			int num;
			int num2;
			Class2572.smethod_4(Class2413.smethod_2().method_41().vmethod_796(), this.Unit.vmethod_30(null), this.Unit.vmethod_28(null), ref num, ref num2);
			this.elementHost_0.Left = num + 25;
			this.elementHost_0.Height = (int)Math.Round(this.contentControl_0.ActualHeight + 25.0);
			this.elementHost_0.Top = (int)Math.Round(Math.Max(0.0, (double)num2 - (double)this.elementHost_0.Height / 2.0));
			this.elementHost_0.BringToFront();
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x00387A44 File Offset: 0x00385C44
		private void method_5()
		{
			this.Cargo = Enumerable.ToList<HoverInfoCargoViewModel>(Enumerable.Select<IGrouping<string, Cargo>, HoverInfoCargoViewModel>(Enumerable.GroupBy<Cargo, string>(Enumerable.SelectMany<ActiveUnit, Cargo>(this.method_9(), (HoverInfoViewModel._Closure$__.$I278-0 == null) ? (HoverInfoViewModel._Closure$__.$I278-0 = new Func<ActiveUnit, IEnumerable<Cargo>>(HoverInfoViewModel._Closure$__.$I.method_1)) : HoverInfoViewModel._Closure$__.$I278-0), (HoverInfoViewModel._Closure$__.$I278-1 == null) ? (HoverInfoViewModel._Closure$__.$I278-1 = new Func<Cargo, string>(HoverInfoViewModel._Closure$__.$I.method_2)) : HoverInfoViewModel._Closure$__.$I278-1), (HoverInfoViewModel._Closure$__.$I278-2 == null) ? (HoverInfoViewModel._Closure$__.$I278-2 = new Func<IGrouping<string, Cargo>, HoverInfoCargoViewModel>(HoverInfoViewModel._Closure$__.$I.method_3)) : HoverInfoViewModel._Closure$__.$I278-2));
			if (Enumerable.Any<HoverInfoCargoViewModel>(this.Cargo))
			{
				this.CargoVisibility = Visibility.Visible;
			}
			else
			{
				this.CargoVisibility = Visibility.Collapsed;
			}
			if (HoverInfoOptionsViewModel.Singleton.Cargo == HoverInfoEnableEnum.const_1)
			{
				this.CargoVisibility = Visibility.Collapsed;
			}
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x00041ED6 File Offset: 0x000400D6
		private void method_6()
		{
			ActiveUnit activeUnit = (ActiveUnit)this.Unit;
			if (HoverInfoOptionsViewModel.Singleton.Sensor == HoverInfoEnableEnum.const_0)
			{
				this.SensorVisibility = Visibility.Visible;
				return;
			}
			this.SensorVisibility = Visibility.Collapsed;
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x00387B10 File Offset: 0x00385D10
		private void method_7()
		{
			ActiveUnit activeUnit = (ActiveUnit)this.Unit;
			this.MountsDetails = Enumerable.ToList<HoverInfoMountViewModel>(Enumerable.OrderBy<HoverInfoMountViewModel, string>(Enumerable.Select<IGrouping<string, string>, HoverInfoMountViewModel>(Enumerable.GroupBy<string, string>(Enumerable.Select<Mount, string>(activeUnit.vmethod_51(), (HoverInfoViewModel._Closure$__.$I280-0 == null) ? (HoverInfoViewModel._Closure$__.$I280-0 = new Func<Mount, string>(HoverInfoViewModel._Closure$__.$I.method_4)) : HoverInfoViewModel._Closure$__.$I280-0), (HoverInfoViewModel._Closure$__.$I280-1 == null) ? (HoverInfoViewModel._Closure$__.$I280-1 = new Func<string, string>(HoverInfoViewModel._Closure$__.$I.method_5)) : HoverInfoViewModel._Closure$__.$I280-1), (HoverInfoViewModel._Closure$__.$I280-2 == null) ? (HoverInfoViewModel._Closure$__.$I280-2 = new Func<IGrouping<string, string>, HoverInfoMountViewModel>(HoverInfoViewModel._Closure$__.$I.method_6)) : HoverInfoViewModel._Closure$__.$I280-2), (HoverInfoViewModel._Closure$__.$I280-3 == null) ? (HoverInfoViewModel._Closure$__.$I280-3 = new Func<HoverInfoMountViewModel, string>(HoverInfoViewModel._Closure$__.$I.method_7)) : HoverInfoViewModel._Closure$__.$I280-3));
			if (!Enumerable.Any<HoverInfoMountViewModel>(this.MountsDetails))
			{
				this.MountsDetailsVisibility = Visibility.Collapsed;
				return;
			}
			if (HoverInfoOptionsViewModel.Singleton.Vehicles == HoverInfoEnableEnum.const_0)
			{
				this.MountsDetailsVisibility = Visibility.Visible;
				return;
			}
			this.MountsDetailsVisibility = Visibility.Collapsed;
		}

		// Token: 0x060067B3 RID: 26547 RVA: 0x00387C10 File Offset: 0x00385E10
		private void method_8()
		{
			Group group = (Group)this.Unit;
			if (Class570.class280_0.method_12())
			{
				if (group.vmethod_13() > 3048f)
				{
					if (group.method_143() == Group.GroupType.AirGroup)
					{
						this.AltString = "Altitude: " + string.Format("{0:0}", group.vmethod_14(false) * 3.28084f).ToString() + " ft ASL";
						return;
					}
					this.AltString = "Altitude: " + string.Format("{0:0}", group.vmethod_14(false) * 3.28084f).ToString() + " ft";
					return;
				}
				else
				{
					if (group.method_143() != Group.GroupType.AirGroup)
					{
						this.AltString = "Altitude: " + string.Format("{0:0}", group.vmethod_14(false) * 3.28084f).ToString() + " ft";
						return;
					}
					if (group.method_15())
					{
						this.AltString = string.Concat(new string[]
						{
							"Altitude: ",
							string.Format("{0:0}", group.vmethod_14(false) * 3.28084f),
							" ft ASL (",
							string.Format("{0:0}", group.vmethod_13() * 3.28084f),
							" ft AGL)"
						});
						return;
					}
					this.AltString = "Altitude: " + string.Format("{0:0}", group.vmethod_14(false) * 3.28084f) + " ft ASL";
					return;
				}
			}
			else if (group.vmethod_13() > 3048f)
			{
				if (group.method_143() == Group.GroupType.AirGroup)
				{
					this.AltString = "Altitude: " + string.Format("{0:0.0}", group.vmethod_14(false), 0).ToString() + " m ASL";
					return;
				}
				this.AltString = "Altitude: " + string.Format("{0:0.0}", group.vmethod_14(false), 0).ToString() + " m";
				return;
			}
			else
			{
				if (group.method_143() != Group.GroupType.AirGroup)
				{
					this.AltString = "Altitude: " + string.Format("{0:0.0}", group.vmethod_14(false), 0).ToString() + " m";
					return;
				}
				if (group.method_15())
				{
					this.AltString = string.Concat(new string[]
					{
						"Altitude: ",
						string.Format("{0:0.0}", group.vmethod_14(false), 0),
						" m ASL (",
						string.Format("{0:0.0}", group.vmethod_13(), 0),
						" m AGL)"
					});
					return;
				}
				this.AltString = "Altitude: " + string.Format("{0:0.0}", group.vmethod_14(false), 0) + " m ASL";
				return;
			}
		}

		// Token: 0x060067B4 RID: 26548 RVA: 0x00387F04 File Offset: 0x00386104
		private IEnumerable<ActiveUnit> method_9()
		{
			IEnumerable<ActiveUnit> result;
			if (this.Unit is Group)
			{
				result = ((Group)this.Unit).vmethod_141().Values;
			}
			else
			{
				result = new List<ActiveUnit>
				{
					(ActiveUnit)this.Unit
				};
			}
			return result;
		}

		// Token: 0x060067B5 RID: 26549 RVA: 0x00387F50 File Offset: 0x00386150
		private string method_10(string text, bool preserveAcronyms = true)
		{
			string result;
			if (string.IsNullOrWhiteSpace(text))
			{
				result = string.Empty;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder(text.Length * 2);
				stringBuilder.Append(text[0]);
				int num = text.Length - 1;
				for (int i = 1; i <= num; i++)
				{
					if (char.IsUpper(text[i]) && ((text[i - 1] != ' ' && !char.IsUpper(text[i - 1])) || (preserveAcronyms && char.IsUpper(text[i - 1]) && i < text.Length - 1 && !char.IsUpper(text[i + 1]))))
					{
						stringBuilder.Append(' ');
					}
					stringBuilder.Append(text[i]);
				}
				result = stringBuilder.Replace('_', ' ').Replace("  ", " ").Replace("  ", " ").ToString();
			}
			return result;
		}

		// Token: 0x060067B6 RID: 26550 RVA: 0x00388040 File Offset: 0x00386240
		private string method_11(ActiveUnit theAU)
		{
			string result;
			if (theAU is Ship)
			{
				Ship ship = (Ship)theAU;
				result = this.method_10(ship._ShipType_0.ToString(), true);
			}
			else if (theAU is Aircraft)
			{
				Aircraft aircraft = (Aircraft)theAU;
				result = this.method_10(aircraft._AircraftType_0.ToString(), true);
			}
			else if (theAU is Submarine)
			{
				Submarine submarine = (Submarine)theAU;
				result = this.method_10(submarine._SubmarineType_0.ToString(), true);
			}
			else if (theAU is Facility)
			{
				Facility facility = (Facility)theAU;
				result = this.method_10(facility._FacilityCategory_0.ToString(), true);
			}
			else if (theAU is Weapon)
			{
				result = ((Weapon)theAU).method_151();
			}
			else if (theAU is Satellite)
			{
				Satellite satellite = (Satellite)theAU;
				result = this.method_10(satellite._SatelliteType_0.ToString(), true);
			}
			else
			{
				result = "Unit";
			}
			return result;
		}

		// Token: 0x060067B7 RID: 26551 RVA: 0x00388148 File Offset: 0x00386348
		private void method_12()
		{
			Group group = (Group)this.Unit;
			this.GroupMembers = Enumerable.ToList<HoverInfoGroupMemberViewModel>(Enumerable.OrderBy<HoverInfoGroupMemberViewModel, string>(Enumerable.Select<IGrouping<string, ActiveUnit>, HoverInfoGroupMemberViewModel>(Enumerable.GroupBy<ActiveUnit, string>(group.vmethod_141().Values, new Func<ActiveUnit, string>(this.method_11)), (HoverInfoViewModel._Closure$__.$I285-0 == null) ? (HoverInfoViewModel._Closure$__.$I285-0 = new Func<IGrouping<string, ActiveUnit>, HoverInfoGroupMemberViewModel>(HoverInfoViewModel._Closure$__.$I.method_8)) : HoverInfoViewModel._Closure$__.$I285-0), (HoverInfoViewModel._Closure$__.$I285-1 == null) ? (HoverInfoViewModel._Closure$__.$I285-1 = new Func<HoverInfoGroupMemberViewModel, string>(HoverInfoViewModel._Closure$__.$I.method_9)) : HoverInfoViewModel._Closure$__.$I285-1));
			if (HoverInfoOptionsViewModel.Singleton.GroupMembers == HoverInfoEnableEnum.const_0)
			{
				this.GroupMembersVisibility = Visibility.Visible;
				return;
			}
			this.GroupMembersVisibility = Visibility.Collapsed;
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x003881F8 File Offset: 0x003863F8
		private void method_13()
		{
			this.AirParasites = Enumerable.ToList<HoverInfoParasiteViewModel>(Enumerable.Select<IGrouping<string, Aircraft>, HoverInfoParasiteViewModel>(Enumerable.GroupBy<Aircraft, string>(Enumerable.SelectMany<ActiveUnit, Aircraft>(this.method_9(), (HoverInfoViewModel._Closure$__.$I286-0 == null) ? (HoverInfoViewModel._Closure$__.$I286-0 = new Func<ActiveUnit, IEnumerable<Aircraft>>(HoverInfoViewModel._Closure$__.$I.method_10)) : HoverInfoViewModel._Closure$__.$I286-0), new Func<Aircraft, string>(this.method_11)), (HoverInfoViewModel._Closure$__.$I286-1 == null) ? (HoverInfoViewModel._Closure$__.$I286-1 = new Func<IGrouping<string, Aircraft>, HoverInfoParasiteViewModel>(HoverInfoViewModel._Closure$__.$I.method_11)) : HoverInfoViewModel._Closure$__.$I286-1));
			this.BoatParasites = Enumerable.ToList<HoverInfoParasiteViewModel>(Enumerable.Select<IGrouping<string, ActiveUnit>, HoverInfoParasiteViewModel>(Enumerable.GroupBy<ActiveUnit, string>(Enumerable.SelectMany<ActiveUnit, ActiveUnit>(this.method_9(), (HoverInfoViewModel._Closure$__.$I286-3 == null) ? (HoverInfoViewModel._Closure$__.$I286-3 = new Func<ActiveUnit, IEnumerable<ActiveUnit>>(HoverInfoViewModel._Closure$__.$I.method_13)) : HoverInfoViewModel._Closure$__.$I286-3), new Func<ActiveUnit, string>(this.method_11)), (HoverInfoViewModel._Closure$__.$I286-4 == null) ? (HoverInfoViewModel._Closure$__.$I286-4 = new Func<IGrouping<string, ActiveUnit>, HoverInfoParasiteViewModel>(HoverInfoViewModel._Closure$__.$I.method_14)) : HoverInfoViewModel._Closure$__.$I286-4));
			if (Enumerable.Any<HoverInfoParasiteViewModel>(this.AirParasites))
			{
				this.AirParasiteVisibility = Visibility.Visible;
			}
			else
			{
				this.AirParasiteVisibility = Visibility.Collapsed;
			}
			if (Enumerable.Any<HoverInfoParasiteViewModel>(this.BoatParasites))
			{
				this.BoatParasiteVisibility = Visibility.Visible;
			}
			else
			{
				this.BoatParasiteVisibility = Visibility.Collapsed;
			}
			if (HoverInfoOptionsViewModel.Singleton.AirParasite == HoverInfoEnableEnum.const_1)
			{
				this.AirParasiteVisibility = Visibility.Collapsed;
			}
			if (HoverInfoOptionsViewModel.Singleton.BoatParasite == HoverInfoEnableEnum.const_1)
			{
				this.BoatParasiteVisibility = Visibility.Collapsed;
			}
		}

		// Token: 0x060067B9 RID: 26553 RVA: 0x00388350 File Offset: 0x00386550
		private void method_14()
		{
			Group group = (Group)this.Unit;
			if (Class570.class280_0.method_42())
			{
				this.GroupImages = Enumerable.ToList<BitmapImage>(Enumerable.Where<BitmapImage>(Enumerable.Select<KeyValuePair<string, ActiveUnit>, BitmapImage>(group.vmethod_141(), (HoverInfoViewModel._Closure$__.$I287-0 == null) ? (HoverInfoViewModel._Closure$__.$I287-0 = new Func<KeyValuePair<string, ActiveUnit>, BitmapImage>(HoverInfoViewModel._Closure$__.$I.method_16)) : HoverInfoViewModel._Closure$__.$I287-0), (HoverInfoViewModel._Closure$__.$I287-1 == null) ? (HoverInfoViewModel._Closure$__.$I287-1 = new Func<BitmapImage, bool>(HoverInfoViewModel._Closure$__.$I.method_17)) : HoverInfoViewModel._Closure$__.$I287-1));
			}
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x003883D8 File Offset: 0x003865D8
		private void method_15()
		{
			ActiveUnit activeUnit_ = (ActiveUnit)this.Unit;
			if (Class570.class280_0.method_42())
			{
				this.ImageSource = Class2564.smethod_0(Class2564.smethod_2(activeUnit_));
			}
		}

		// Token: 0x060067BB RID: 26555 RVA: 0x00388410 File Offset: 0x00386610
		private void method_16()
		{
			ActiveUnit activeUnit = (ActiveUnit)this.Unit;
			if (activeUnit.vmethod_101() == null)
			{
				this.MissionVisibility = Visibility.Collapsed;
				return;
			}
			this.MissionName = string.Format("{0}", activeUnit.vmethod_101().Name);
			this.MissionClass = string.Format("{0}", activeUnit.vmethod_101()._MissionClass_0);
			this.MissionStatus = string.Format("{0}", activeUnit.vmethod_101().method_10(Client.smethod_46()));
			if (HoverInfoOptionsViewModel.Singleton.Mission == HoverInfoEnableEnum.const_1)
			{
				this.MissionVisibility = Visibility.Collapsed;
			}
			if (HoverInfoOptionsViewModel.Singleton.Mission == HoverInfoEnableEnum.const_0)
			{
				this.MissionVisibility = Visibility.Visible;
			}
		}

		// Token: 0x060067BC RID: 26556 RVA: 0x003884C0 File Offset: 0x003866C0
		private void method_17()
		{
			HoverInfoViewModel.Class2454 @class = new HoverInfoViewModel.Class2454(@class);
			@class.int_0 = 0;
			@class.int_1 = 0;
			@class.int_2 = 0;
			@class.int_3 = 0;
			@class.int_4 = 0;
			@class.int_5 = 0;
			@class.int_6 = 0;
			@class.int_7 = 0;
			@class.int_8 = 0;
			@class.int_9 = 0;
			@class.int_10 = 0;
			@class.int_11 = 0;
			List<Tuple<Weapon, int>> list = new List<Tuple<Weapon, int>>();
			Delegate75<Weapon, int> @delegate = new Delegate75<Weapon, int>(@class.method_0);
			try
			{
				foreach (ActiveUnit activeUnit in this.method_9())
				{
					try
					{
						foreach (Mount mount in activeUnit.vmethod_51())
						{
							try
							{
								foreach (WeaponRec weaponRec in mount.vmethod_10())
								{
									Weapon weapon = Client.smethod_46().method_87(weaponRec.int_5);
									int num = weaponRec.method_9();
									list.Add(new Tuple<Weapon, int>(weapon, num));
									@delegate(weapon, num);
								}
							}
							finally
							{
								List<WeaponRec>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
						}
					}
					finally
					{
						List<Mount>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					foreach (Magazine magazine in activeUnit.method_91())
					{
						try
						{
							foreach (WeaponRec weaponRec2 in magazine.vmethod_10())
							{
								Weapon weapon2 = Client.smethod_46().method_87(weaponRec2.int_5);
								int num2 = weaponRec2.method_9();
								list.Add(new Tuple<Weapon, int>(weapon2, num2));
								@delegate(weapon2, num2);
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
					if (activeUnit.bool_3 && ((Aircraft)activeUnit).method_167() != null)
					{
						foreach (WeaponRec weaponRec3 in ((Aircraft)activeUnit).method_167().weaponRec_0)
						{
							Weapon weapon3 = Client.smethod_46().method_87(weaponRec3.int_5);
							int num3 = weaponRec3.method_9();
							list.Add(new Tuple<Weapon, int>(weapon3, num3));
							@delegate(weapon3, num3);
						}
					}
				}
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.AIR_LR = @class.int_0;
			this.AIR_MR = @class.int_1;
			this.AIR_SR = @class.int_2;
			this.SURF_LR = @class.int_3;
			this.SURF_MR = @class.int_4;
			this.SURF_SR = @class.int_5;
			this.LAND_LR = @class.int_6;
			this.LAND_MR = @class.int_7;
			this.LAND_SR = @class.int_8;
			this.SUB_LR = @class.int_9;
			this.SUB_MR = @class.int_10;
			this.SUB_SR = @class.int_11;
			this.WeaponsDetails = Enumerable.ToList<HoverInfoWeaponViewModel>(Enumerable.OrderBy<HoverInfoWeaponViewModel, string>(Enumerable.Where<HoverInfoWeaponViewModel>(Enumerable.Select<IGrouping<string, Tuple<Weapon, int>>, HoverInfoWeaponViewModel>(Enumerable.GroupBy<Tuple<Weapon, int>, string>(list, new Func<Tuple<Weapon, int>, string>(this.method_19)), (HoverInfoViewModel._Closure$__.$I290-2 == null) ? (HoverInfoViewModel._Closure$__.$I290-2 = new Func<IGrouping<string, Tuple<Weapon, int>>, HoverInfoWeaponViewModel>(HoverInfoViewModel._Closure$__.$I.method_18)) : HoverInfoViewModel._Closure$__.$I290-2), (HoverInfoViewModel._Closure$__.$I290-4 == null) ? (HoverInfoViewModel._Closure$__.$I290-4 = new Func<HoverInfoWeaponViewModel, bool>(HoverInfoViewModel._Closure$__.$I.method_20)) : HoverInfoViewModel._Closure$__.$I290-4), (HoverInfoViewModel._Closure$__.$I290-5 == null) ? (HoverInfoViewModel._Closure$__.$I290-5 = new Func<HoverInfoWeaponViewModel, string>(HoverInfoViewModel._Closure$__.$I.method_21)) : HoverInfoViewModel._Closure$__.$I290-5));
			if (!Enumerable.Any<HoverInfoWeaponViewModel>(this.WeaponsDetails))
			{
				this.WeaponDetailsVisibility = Visibility.Collapsed;
				this.WeaponSummaryVisibility = Visibility.Collapsed;
				this.WeaponVisibility = Visibility.Collapsed;
				return;
			}
			this.WeaponVisibility = Visibility.Visible;
			if (HoverInfoOptionsViewModel.Singleton.Weapons == HoverInfoEnableDetailedEnum.const_0)
			{
				this.WeaponDetailsVisibility = Visibility.Visible;
				this.WeaponSummaryVisibility = Visibility.Collapsed;
			}
			if (HoverInfoOptionsViewModel.Singleton.Weapons == HoverInfoEnableDetailedEnum.const_1)
			{
				this.WeaponDetailsVisibility = Visibility.Collapsed;
				this.WeaponSummaryVisibility = Visibility.Visible;
			}
		}

		// Token: 0x060067BD RID: 26557 RVA: 0x003888F4 File Offset: 0x00386AF4
		private void method_18()
		{
			ActiveUnit activeUnit = (ActiveUnit)this.Unit;
			bool flag = Enumerable.Any<Sensor>(activeUnit.vmethod_96(), (HoverInfoViewModel._Closure$__.$I291-0 == null) ? (HoverInfoViewModel._Closure$__.$I291-0 = new Func<Sensor, bool>(HoverInfoViewModel._Closure$__.$I.method_22)) : HoverInfoViewModel._Closure$__.$I291-0);
			bool flag2 = Enumerable.Any<Sensor>(activeUnit.vmethod_96(), (HoverInfoViewModel._Closure$__.$I291-1 == null) ? (HoverInfoViewModel._Closure$__.$I291-1 = new Func<Sensor, bool>(HoverInfoViewModel._Closure$__.$I.method_23)) : HoverInfoViewModel._Closure$__.$I291-1);
			bool flag3 = Enumerable.Any<Sensor>(activeUnit.vmethod_96(), (HoverInfoViewModel._Closure$__.$I291-2 == null) ? (HoverInfoViewModel._Closure$__.$I291-2 = new Func<Sensor, bool>(HoverInfoViewModel._Closure$__.$I.method_24)) : HoverInfoViewModel._Closure$__.$I291-2);
			if (flag)
			{
				this.RadarOnVisibility = Visibility.Visible;
				this.RadarOffVisibility = Visibility.Collapsed;
			}
			else
			{
				this.RadarOnVisibility = Visibility.Collapsed;
				this.RadarOffVisibility = Visibility.Visible;
			}
			if (flag2)
			{
				this.SonarOnVisibility = Visibility.Visible;
				this.SonarOffVisibility = Visibility.Collapsed;
			}
			else
			{
				this.SonarOnVisibility = Visibility.Collapsed;
				this.SonarOffVisibility = Visibility.Visible;
			}
			if (flag3)
			{
				this.OECMOnVisibility = Visibility.Visible;
				this.OECMOffVisibility = Visibility.Collapsed;
				return;
			}
			this.OECMOnVisibility = Visibility.Collapsed;
			this.OECMOffVisibility = Visibility.Visible;
		}

		// Token: 0x060067BE RID: 26558 RVA: 0x00041EFF File Offset: 0x000400FF
		[CompilerGenerated]
		private string method_19(Tuple<Weapon, int> F)
		{
			return this.method_11(F.Item1);
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x060067BF RID: 26559 RVA: 0x00388A00 File Offset: 0x00386C00
		// (remove) Token: 0x060067C0 RID: 26560 RVA: 0x00388A38 File Offset: 0x00386C38
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

		// Token: 0x060067C1 RID: 26561 RVA: 0x00388A70 File Offset: 0x00386C70
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003ABD RID: 15037
		[CompilerGenerated]
		private Unit unit_0;

		// Token: 0x04003ABE RID: 15038
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003ABF RID: 15039
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04003AC0 RID: 15040
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04003AC1 RID: 15041
		[CompilerGenerated]
		private string string_3;

		// Token: 0x04003AC2 RID: 15042
		[CompilerGenerated]
		private string string_4;

		// Token: 0x04003AC3 RID: 15043
		[CompilerGenerated]
		private string string_5;

		// Token: 0x04003AC4 RID: 15044
		[CompilerGenerated]
		private string string_6;

		// Token: 0x04003AC5 RID: 15045
		[CompilerGenerated]
		private string string_7;

		// Token: 0x04003AC6 RID: 15046
		[CompilerGenerated]
		private BitmapImage bitmapImage_0;

		// Token: 0x04003AC7 RID: 15047
		[CompilerGenerated]
		private List<BitmapImage> list_0;

		// Token: 0x04003AC8 RID: 15048
		[CompilerGenerated]
		private Visibility visibility_0;

		// Token: 0x04003AC9 RID: 15049
		[CompilerGenerated]
		private List<HoverInfoGroupMemberViewModel> list_1;

		// Token: 0x04003ACA RID: 15050
		[CompilerGenerated]
		private Visibility visibility_1;

		// Token: 0x04003ACB RID: 15051
		[CompilerGenerated]
		private string string_8;

		// Token: 0x04003ACC RID: 15052
		[CompilerGenerated]
		private string string_9;

		// Token: 0x04003ACD RID: 15053
		[CompilerGenerated]
		private string string_10;

		// Token: 0x04003ACE RID: 15054
		[CompilerGenerated]
		private string string_11;

		// Token: 0x04003ACF RID: 15055
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003AD0 RID: 15056
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04003AD1 RID: 15057
		[CompilerGenerated]
		private int int_2;

		// Token: 0x04003AD2 RID: 15058
		[CompilerGenerated]
		private int int_3;

		// Token: 0x04003AD3 RID: 15059
		[CompilerGenerated]
		private int int_4;

		// Token: 0x04003AD4 RID: 15060
		[CompilerGenerated]
		private int int_5;

		// Token: 0x04003AD5 RID: 15061
		[CompilerGenerated]
		private int int_6;

		// Token: 0x04003AD6 RID: 15062
		[CompilerGenerated]
		private int int_7;

		// Token: 0x04003AD7 RID: 15063
		[CompilerGenerated]
		private int int_8;

		// Token: 0x04003AD8 RID: 15064
		[CompilerGenerated]
		private int int_9;

		// Token: 0x04003AD9 RID: 15065
		[CompilerGenerated]
		private int int_10;

		// Token: 0x04003ADA RID: 15066
		[CompilerGenerated]
		private int int_11;

		// Token: 0x04003ADB RID: 15067
		[CompilerGenerated]
		private Visibility visibility_2;

		// Token: 0x04003ADC RID: 15068
		[CompilerGenerated]
		private Visibility visibility_3;

		// Token: 0x04003ADD RID: 15069
		[CompilerGenerated]
		private Visibility visibility_4;

		// Token: 0x04003ADE RID: 15070
		[CompilerGenerated]
		private Visibility visibility_5;

		// Token: 0x04003ADF RID: 15071
		[CompilerGenerated]
		private Visibility visibility_6;

		// Token: 0x04003AE0 RID: 15072
		[CompilerGenerated]
		private Visibility visibility_7;

		// Token: 0x04003AE1 RID: 15073
		[CompilerGenerated]
		private Visibility visibility_8;

		// Token: 0x04003AE2 RID: 15074
		[CompilerGenerated]
		private Visibility visibility_9;

		// Token: 0x04003AE3 RID: 15075
		[CompilerGenerated]
		private List<HoverInfoParasiteViewModel> list_2;

		// Token: 0x04003AE4 RID: 15076
		[CompilerGenerated]
		private Visibility visibility_10;

		// Token: 0x04003AE5 RID: 15077
		[CompilerGenerated]
		private List<HoverInfoParasiteViewModel> list_3;

		// Token: 0x04003AE6 RID: 15078
		[CompilerGenerated]
		private Visibility visibility_11;

		// Token: 0x04003AE7 RID: 15079
		[CompilerGenerated]
		private List<HoverInfoCargoViewModel> list_4;

		// Token: 0x04003AE8 RID: 15080
		[CompilerGenerated]
		private Visibility visibility_12;

		// Token: 0x04003AE9 RID: 15081
		[CompilerGenerated]
		private Visibility visibility_13;

		// Token: 0x04003AEA RID: 15082
		[CompilerGenerated]
		private Visibility visibility_14;

		// Token: 0x04003AEB RID: 15083
		[CompilerGenerated]
		private List<HoverInfoWeaponViewModel> list_5;

		// Token: 0x04003AEC RID: 15084
		[CompilerGenerated]
		private Visibility visibility_15;

		// Token: 0x04003AED RID: 15085
		[CompilerGenerated]
		private List<HoverInfoMountViewModel> list_6;

		// Token: 0x04003AEE RID: 15086
		[CompilerGenerated]
		private string string_12;

		// Token: 0x04003AEF RID: 15087
		[CompilerGenerated]
		private string string_13;

		// Token: 0x04003AF0 RID: 15088
		private static DispatcherTimer dispatcherTimer_0 = new DispatcherTimer();

		// Token: 0x04003AF1 RID: 15089
		private ContentControl contentControl_0;

		// Token: 0x04003AF2 RID: 15090
		private ElementHost elementHost_0;

		// Token: 0x04003AF3 RID: 15091
		[CompilerGenerated]
		private FuelViewModel fuelViewModel_0;

		// Token: 0x04003AF4 RID: 15092
		[CompilerGenerated]
		private Visibility visibility_16;

		// Token: 0x04003AF5 RID: 15093
		[CompilerGenerated]
		private Visibility visibility_17;

		// Token: 0x04003AF6 RID: 15094
		[CompilerGenerated]
		private Visibility visibility_18;

		// Token: 0x04003AF7 RID: 15095
		[CompilerGenerated]
		private Visibility visibility_19;

		// Token: 0x04003AF8 RID: 15096
		[CompilerGenerated]
		private Visibility visibility_20;

		// Token: 0x04003AF9 RID: 15097
		[CompilerGenerated]
		private Visibility visibility_21;

		// Token: 0x04003AFA RID: 15098
		[CompilerGenerated]
		private Visibility visibility_22;

		// Token: 0x04003AFB RID: 15099
		[CompilerGenerated]
		private GridLength gridLength_0;

		// Token: 0x04003AFC RID: 15100
		[CompilerGenerated]
		private GridLength gridLength_1;

		// Token: 0x04003AFD RID: 15101
		[CompilerGenerated]
		private GridLength gridLength_2;

		// Token: 0x04003AFE RID: 15102
		[CompilerGenerated]
		private GridLength gridLength_3;

		// Token: 0x04003AFF RID: 15103
		[CompilerGenerated]
		private GridLength gridLength_4;

		// Token: 0x04003B00 RID: 15104
		[CompilerGenerated]
		private int int_12;

		// Token: 0x04003B01 RID: 15105
		[CompilerGenerated]
		private int int_13;

		// Token: 0x04003B02 RID: 15106
		[CompilerGenerated]
		private int int_14;

		// Token: 0x04003B03 RID: 15107
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000DF0 RID: 3568
		[CompilerGenerated]
		internal sealed class Class2454
		{
			// Token: 0x060067DD RID: 26589 RVA: 0x00388BD0 File Offset: 0x00386DD0
			public Class2454(HoverInfoViewModel.Class2454 arg0)
			{
				if (arg0 != null)
				{
					this.int_0 = arg0.int_0;
					this.int_1 = arg0.int_1;
					this.int_2 = arg0.int_2;
					this.int_3 = arg0.int_3;
					this.int_4 = arg0.int_4;
					this.int_5 = arg0.int_5;
					this.int_6 = arg0.int_6;
					this.int_7 = arg0.int_7;
					this.int_8 = arg0.int_8;
					this.int_9 = arg0.int_9;
					this.int_10 = arg0.int_10;
					this.int_11 = arg0.int_11;
				}
			}

			// Token: 0x060067DE RID: 26590 RVA: 0x00388C7C File Offset: 0x00386E7C
			internal void method_0(Weapon myWeapon, int myCount)
			{
				if (myWeapon.method_199())
				{
					if (myWeapon.float_29 > 25f)
					{
						this.int_0 += myCount;
					}
					else if (myWeapon.float_29 > 5f)
					{
						this.int_1 += myCount;
					}
					else
					{
						this.int_2 += myCount;
					}
				}
				if (myWeapon.method_196())
				{
					if (myWeapon.float_31 > 25f)
					{
						this.int_3 += myCount;
					}
					else if (myWeapon.float_31 > 5f)
					{
						this.int_4 += myCount;
					}
					else
					{
						this.int_5 += myCount;
					}
				}
				if (myWeapon.method_195())
				{
					if (myWeapon.float_33 > 25f)
					{
						this.int_6 += myCount;
					}
					else if (myWeapon.float_33 > 5f)
					{
						this.int_7 += myCount;
					}
					else
					{
						this.int_8 += myCount;
					}
				}
				if (myWeapon.method_197())
				{
					if (myWeapon.float_35 > 25f)
					{
						this.int_9 += myCount;
						return;
					}
					if (myWeapon.float_35 > 5f)
					{
						this.int_10 += myCount;
						return;
					}
					this.int_11 += myCount;
				}
			}

			// Token: 0x04003B1E RID: 15134
			public int int_0;

			// Token: 0x04003B1F RID: 15135
			public int int_1;

			// Token: 0x04003B20 RID: 15136
			public int int_2;

			// Token: 0x04003B21 RID: 15137
			public int int_3;

			// Token: 0x04003B22 RID: 15138
			public int int_4;

			// Token: 0x04003B23 RID: 15139
			public int int_5;

			// Token: 0x04003B24 RID: 15140
			public int int_6;

			// Token: 0x04003B25 RID: 15141
			public int int_7;

			// Token: 0x04003B26 RID: 15142
			public int int_8;

			// Token: 0x04003B27 RID: 15143
			public int int_9;

			// Token: 0x04003B28 RID: 15144
			public int int_10;

			// Token: 0x04003B29 RID: 15145
			public int int_11;
		}
	}
}
