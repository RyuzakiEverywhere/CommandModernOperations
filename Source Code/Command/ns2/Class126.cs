using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using DarkUI.Collections;
using ns8;

namespace ns2
{
	// Token: 0x020000D7 RID: 215
	internal sealed class Class126
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x000690A8 File Offset: 0x000672A8
		[CompilerGenerated]
		public void method_0(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000690E0 File Offset: 0x000672E0
		[CompilerGenerated]
		public void method_1(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00069118 File Offset: 0x00067318
		[CompilerGenerated]
		public void method_2(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_3;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00069150 File Offset: 0x00067350
		[CompilerGenerated]
		public void method_3(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_3;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00069188 File Offset: 0x00067388
		[CompilerGenerated]
		public void method_4(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x000691C0 File Offset: 0x000673C0
		[CompilerGenerated]
		public void method_5(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public string method_6()
		{
			return this.string_0;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00005D00 File Offset: 0x00003F00
		public void method_7(string string_1)
		{
			if (this.string_0 == string_1)
			{
				return;
			}
			this.string_0 = string_1;
			this.method_42();
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00005D1E File Offset: 0x00003F1E
		[CompilerGenerated]
		public Rectangle method_8()
		{
			return this.rectangle_0;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00005D26 File Offset: 0x00003F26
		[CompilerGenerated]
		public void method_9(Rectangle rectangle_4)
		{
			this.rectangle_0 = rectangle_4;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00005D2F File Offset: 0x00003F2F
		[CompilerGenerated]
		public Rectangle method_10()
		{
			return this.rectangle_1;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00005D37 File Offset: 0x00003F37
		[CompilerGenerated]
		public void method_11(Rectangle rectangle_4)
		{
			this.rectangle_1 = rectangle_4;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00005D40 File Offset: 0x00003F40
		[CompilerGenerated]
		public Rectangle method_12()
		{
			return this.rectangle_2;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00005D48 File Offset: 0x00003F48
		[CompilerGenerated]
		public void method_13(Rectangle rectangle_4)
		{
			this.rectangle_2 = rectangle_4;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00005D51 File Offset: 0x00003F51
		[CompilerGenerated]
		public Rectangle method_14()
		{
			return this.rectangle_3;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00005D59 File Offset: 0x00003F59
		[CompilerGenerated]
		public void method_15(Rectangle rectangle_4)
		{
			this.rectangle_3 = rectangle_4;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00005D62 File Offset: 0x00003F62
		[CompilerGenerated]
		public bool method_16()
		{
			return this.bool_2;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00005D6A File Offset: 0x00003F6A
		[CompilerGenerated]
		public void method_17(bool bool_4)
		{
			this.bool_2 = bool_4;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00005D73 File Offset: 0x00003F73
		[CompilerGenerated]
		public Bitmap method_18()
		{
			return this.bitmap_0;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00005D7B File Offset: 0x00003F7B
		[CompilerGenerated]
		public Bitmap method_19()
		{
			return this.bitmap_1;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00005D83 File Offset: 0x00003F83
		public bool method_20()
		{
			return this.bool_1;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000691F8 File Offset: 0x000673F8
		public void method_21(bool bool_4)
		{
			if (this.bool_1 == bool_4)
			{
				return;
			}
			if (bool_4 && this.method_22().Count == 0)
			{
				return;
			}
			this.bool_1 = bool_4;
			if (this.bool_1)
			{
				if (this.eventHandler_3 != null)
				{
					this.eventHandler_3(this, null);
				}
			}
			else if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, null);
			}
			Control5 control = this.method_25();
			if (control == null)
			{
				return;
			}
			control.method_38();
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00005D8B File Offset: 0x00003F8B
		public ObservableList<Class126> method_22()
		{
			return this.observableList_0;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0006926C File Offset: 0x0006746C
		public void method_23(ObservableList<Class126> observableList_1)
		{
			if (this.observableList_0 != null)
			{
				this.observableList_0.method_1(new EventHandler<EventArgs5<Class126>>(this.method_43));
				this.observableList_0.method_3(new EventHandler<EventArgs5<Class126>>(this.method_44));
			}
			this.observableList_0 = observableList_1;
			this.observableList_0.method_0(new EventHandler<EventArgs5<Class126>>(this.method_43));
			this.observableList_0.method_2(new EventHandler<EventArgs5<Class126>>(this.method_44));
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00005D93 File Offset: 0x00003F93
		public void method_24(bool bool_4)
		{
			this.bool_0 = bool_4;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00005D9C File Offset: 0x00003F9C
		public Control5 method_25()
		{
			return this.control5_0;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000692E4 File Offset: 0x000674E4
		public void method_26(Control5 control5_1)
		{
			if (this.control5_0 == control5_1)
			{
				return;
			}
			this.control5_0 = control5_1;
			foreach (Class126 @class in this.method_22())
			{
				@class.method_26(this.control5_0);
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00005DA4 File Offset: 0x00003FA4
		public Class126 method_27()
		{
			return this.class126_0;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00005DAC File Offset: 0x00003FAC
		public void method_28(Class126 class126_3)
		{
			this.class126_0 = class126_3;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00005DB5 File Offset: 0x00003FB5
		[CompilerGenerated]
		public bool method_29()
		{
			return this.bool_3;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00005DBD File Offset: 0x00003FBD
		[CompilerGenerated]
		public void method_30(bool bool_4)
		{
			this.bool_3 = bool_4;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00005DC6 File Offset: 0x00003FC6
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00005DCE File Offset: 0x00003FCE
		public object Tag { get; set; }

		// Token: 0x060004EB RID: 1259 RVA: 0x00005DD7 File Offset: 0x00003FD7
		[CompilerGenerated]
		public Class126 method_31()
		{
			return this.class126_1;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00005DDF File Offset: 0x00003FDF
		[CompilerGenerated]
		public void method_32(Class126 class126_3)
		{
			this.class126_1 = class126_3;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00005DE8 File Offset: 0x00003FE8
		[CompilerGenerated]
		public Class126 method_33()
		{
			return this.class126_2;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[CompilerGenerated]
		public void method_34(Class126 class126_3)
		{
			this.class126_2 = class126_3;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00005DF9 File Offset: 0x00003FF9
		[CompilerGenerated]
		public int method_35()
		{
			return this.int_0;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00005E01 File Offset: 0x00004001
		[CompilerGenerated]
		public void method_36(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00005E0A File Offset: 0x0000400A
		[CompilerGenerated]
		public Color method_37()
		{
			return this.color_0;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00005E12 File Offset: 0x00004012
		[CompilerGenerated]
		public void method_38(Color color_1)
		{
			this.color_0 = color_1;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00005E1B File Offset: 0x0000401B
		[CompilerGenerated]
		public Font method_39()
		{
			return this.font_0;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00005E23 File Offset: 0x00004023
		[CompilerGenerated]
		public void method_40(Font font_1)
		{
			this.font_0 = font_1;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00005E2C File Offset: 0x0000402C
		public Class126()
		{
			this.method_23(new ObservableList<Class126>());
			this.method_38(Class129.smethod_11());
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00005E4A File Offset: 0x0000404A
		public Class126(string string_1) : this()
		{
			this.method_7(string_1);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0006934C File Offset: 0x0006754C
		public void method_41()
		{
			for (Class126 @class = this.method_27(); @class != null; @class = @class.method_27())
			{
				@class.method_21(true);
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00069374 File Offset: 0x00067574
		private void method_42()
		{
			if (this.method_25() != null && this.method_25().method_28() != null)
			{
				if (this.method_27() != null)
				{
					this.method_27().method_22().Sort(this.method_25().method_28());
				}
				else
				{
					this.method_25().method_19().Sort(this.method_25().method_28());
				}
			}
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, null);
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000693EC File Offset: 0x000675EC
		private void method_43(object sender, EventArgs5<Class126> e)
		{
			foreach (Class126 @class in e.method_0())
			{
				@class.method_28(this);
				@class.method_26(this.method_25());
			}
			if (this.method_25() != null && this.method_25().method_28() != null)
			{
				this.method_22().Sort(this.method_25().method_28());
			}
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, e);
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00005E59 File Offset: 0x00004059
		private void method_44(object sender, EventArgs5<Class126> e)
		{
			if (this.method_22().Count == 0)
			{
				this.method_21(false);
			}
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, e);
			}
		}

		// Token: 0x04000387 RID: 903
		[CompilerGenerated]
		private EventHandler<EventArgs5<Class126>> eventHandler_0;

		// Token: 0x04000388 RID: 904
		[CompilerGenerated]
		private EventHandler<EventArgs5<Class126>> eventHandler_1;

		// Token: 0x04000389 RID: 905
		[CompilerGenerated]
		private EventHandler eventHandler_2;

		// Token: 0x0400038A RID: 906
		[CompilerGenerated]
		private EventHandler eventHandler_3;

		// Token: 0x0400038B RID: 907
		[CompilerGenerated]
		private EventHandler eventHandler_4;

		// Token: 0x0400038C RID: 908
		private string string_0;

		// Token: 0x0400038D RID: 909
		private bool bool_0;

		// Token: 0x0400038E RID: 910
		private Control5 control5_0;

		// Token: 0x0400038F RID: 911
		private Class126 class126_0;

		// Token: 0x04000390 RID: 912
		private ObservableList<Class126> observableList_0;

		// Token: 0x04000391 RID: 913
		private bool bool_1;

		// Token: 0x04000392 RID: 914
		[CompilerGenerated]
		private Rectangle rectangle_0;

		// Token: 0x04000393 RID: 915
		[CompilerGenerated]
		private Rectangle rectangle_1;

		// Token: 0x04000394 RID: 916
		[CompilerGenerated]
		private Rectangle rectangle_2;

		// Token: 0x04000395 RID: 917
		[CompilerGenerated]
		private Rectangle rectangle_3;

		// Token: 0x04000396 RID: 918
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04000397 RID: 919
		[CompilerGenerated]
		private Bitmap bitmap_0;

		// Token: 0x04000398 RID: 920
		[CompilerGenerated]
		private Bitmap bitmap_1;

		// Token: 0x04000399 RID: 921
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x0400039A RID: 922
		[CompilerGenerated]
		private object object_0;

		// Token: 0x0400039B RID: 923
		[CompilerGenerated]
		private Class126 class126_1;

		// Token: 0x0400039C RID: 924
		[CompilerGenerated]
		private Class126 class126_2;

		// Token: 0x0400039D RID: 925
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400039E RID: 926
		[CompilerGenerated]
		private Color color_0;

		// Token: 0x0400039F RID: 927
		[CompilerGenerated]
		private Font font_0;
	}
}
