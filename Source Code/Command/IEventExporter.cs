using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Command_Core
{
	// Token: 0x020003D9 RID: 985
	public interface IEventExporter
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06001D79 RID: 7545
		string Name { get; }

		// Token: 0x06001D7A RID: 7546
		int imethod_0();

		// Token: 0x06001D7B RID: 7547
		string imethod_1();

		// Token: 0x06001D7C RID: 7548
		void imethod_2(string string_0);

		// Token: 0x06001D7D RID: 7549
		IEventExporter.Enum142 imethod_3();

		// Token: 0x06001D7E RID: 7550
		bool imethod_4();

		// Token: 0x06001D7F RID: 7551
		void imethod_5(IEventExporter.Enum141 enum141_0);

		// Token: 0x06001D80 RID: 7552
		void imethod_6(IEventExporter.ExportedEventType exportedEventType_0, Dictionary<string, IEventExporter.EventNotificationParameter> dictionary_0, Scenario scenario_0);

		// Token: 0x06001D81 RID: 7553
		void imethod_7();

		// Token: 0x06001D82 RID: 7554
		bool imethod_8();

		// Token: 0x06001D83 RID: 7555
		void imethod_9(bool bool_0);

		// Token: 0x06001D84 RID: 7556
		bool imethod_10();

		// Token: 0x06001D85 RID: 7557
		void imethod_11(bool bool_0);

		// Token: 0x06001D86 RID: 7558
		void imethod_12(bool bool_0);

		// Token: 0x06001D87 RID: 7559
		void imethod_13(bool bool_0);

		// Token: 0x06001D88 RID: 7560
		bool imethod_14();

		// Token: 0x06001D89 RID: 7561
		void imethod_15(bool bool_0);

		// Token: 0x06001D8A RID: 7562
		bool imethod_16();

		// Token: 0x06001D8B RID: 7563
		void imethod_17(bool bool_0);

		// Token: 0x06001D8C RID: 7564
		bool imethod_18();

		// Token: 0x06001D8D RID: 7565
		void imethod_19(bool bool_0);

		// Token: 0x06001D8E RID: 7566
		bool imethod_20();

		// Token: 0x06001D8F RID: 7567
		void imethod_21(bool bool_0);

		// Token: 0x06001D90 RID: 7568
		void imethod_22(bool bool_0);

		// Token: 0x06001D91 RID: 7569
		void imethod_23(bool bool_0);

		// Token: 0x06001D92 RID: 7570
		bool imethod_24();

		// Token: 0x06001D93 RID: 7571
		bool imethod_25();

		// Token: 0x06001D94 RID: 7572
		void imethod_26(bool bool_0);

		// Token: 0x06001D95 RID: 7573
		bool imethod_27();

		// Token: 0x06001D96 RID: 7574
		void imethod_28(bool bool_0);

		// Token: 0x020003DA RID: 986
		[Serializable]
		public struct EventNotificationParameter
		{
			// Token: 0x06001D97 RID: 7575 RVA: 0x0000E7CB File Offset: 0x0000C9CB
			public EventNotificationParameter(object theValue, Type theDataType, int theMaxStringLength = 0)
			{
				this = default(IEventExporter.EventNotificationParameter);
				this.Value = RuntimeHelpers.GetObjectValue(theValue);
				this.DataType = theDataType;
				this.MaxStringLength = theMaxStringLength;
			}

			// Token: 0x04001C11 RID: 7185
			public object Value;

			// Token: 0x04001C12 RID: 7186
			public Type DataType;

			// Token: 0x04001C13 RID: 7187
			public int MaxStringLength;
		}

		// Token: 0x020003DB RID: 987
		public enum ExportedEventType
		{
			// Token: 0x04001C15 RID: 7189
			None,
			// Token: 0x04001C16 RID: 7190
			WeaponFired,
			// Token: 0x04001C17 RID: 7191
			WeaponEndgame,
			// Token: 0x04001C18 RID: 7192
			FuelConsumed,
			// Token: 0x04001C19 RID: 7193
			UnitDestroyed,
			// Token: 0x04001C1A RID: 7194
			SensorDetectionAttempt,
			// Token: 0x04001C1B RID: 7195
			PointDefenceAndDECM,
			// Token: 0x04001C1C RID: 7196
			UnitPositions,
			// Token: 0x04001C1D RID: 7197
			EngagementCycle,
			// Token: 0x04001C1E RID: 7198
			FuelTransfer,
			// Token: 0x04001C1F RID: 7199
			WeaponImpact,
			// Token: 0x04001C20 RID: 7200
			Explosion,
			// Token: 0x04001C21 RID: 7201
			AirOps,
			// Token: 0x04001C22 RID: 7202
			DockingOps,
			// Token: 0x04001C23 RID: 7203
			WaterSplash
		}

		// Token: 0x020003DC RID: 988
		internal enum Enum141
		{
			// Token: 0x04001C25 RID: 7205
			const_0,
			// Token: 0x04001C26 RID: 7206
			const_1
		}

		// Token: 0x020003DD RID: 989
		[Serializable]
		public sealed class EventExportNotification
		{
			// Token: 0x04001C27 RID: 7207
			public IEventExporter.ExportedEventType EventType;

			// Token: 0x04001C28 RID: 7208
			public Dictionary<string, IEventExporter.EventNotificationParameter> EventParameters;

			// Token: 0x04001C29 RID: 7209
			public string FileExportFolder;

			// Token: 0x04001C2A RID: 7210
			public Scenario ParentScen;
		}

		// Token: 0x020003DE RID: 990
		internal enum Enum142
		{
			// Token: 0x04001C2C RID: 7212
			const_0,
			// Token: 0x04001C2D RID: 7213
			const_1,
			// Token: 0x04001C2E RID: 7214
			const_2,
			// Token: 0x04001C2F RID: 7215
			const_3,
			// Token: 0x04001C30 RID: 7216
			const_4,
			// Token: 0x04001C31 RID: 7217
			const_5,
			// Token: 0x04001C32 RID: 7218
			const_6,
			// Token: 0x04001C33 RID: 7219
			const_7,
			// Token: 0x04001C34 RID: 7220
			const_8,
			// Token: 0x04001C35 RID: 7221
			const_9,
			// Token: 0x04001C36 RID: 7222
			const_10
		}
	}
}
