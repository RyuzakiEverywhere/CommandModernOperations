using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using DarkUI.Collections;
using ns8;

namespace ns2
{
	// Token: 0x020000D8 RID: 216
	internal sealed class Class127
	{
		// Token: 0x060004FB RID: 1275 RVA: 0x00069484 File Offset: 0x00067684
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

		// Token: 0x060004FC RID: 1276 RVA: 0x000694BC File Offset: 0x000676BC
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

		// Token: 0x060004FD RID: 1277 RVA: 0x000694F4 File Offset: 0x000676F4
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

		// Token: 0x060004FE RID: 1278 RVA: 0x0006952C File Offset: 0x0006772C
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

		// Token: 0x060004FF RID: 1279 RVA: 0x00069564 File Offset: 0x00067764
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

		// Token: 0x06000500 RID: 1280 RVA: 0x0006959C File Offset: 0x0006779C
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

		// Token: 0x06000501 RID: 1281 RVA: 0x00005E84 File Offset: 0x00004084
		public string method_6()
		{
			return this.string_0;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00005E8C File Offset: 0x0000408C
		public void method_7(string string_1)
		{
			if (this.string_0 == string_1)
			{
				return;
			}
			this.string_0 = string_1;
			this.method_44();
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00005EAA File Offset: 0x000040AA
		[CompilerGenerated]
		public Rectangle method_8()
		{
			return this.rectangle_0;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00005EB2 File Offset: 0x000040B2
		[CompilerGenerated]
		public void method_9(Rectangle rectangle_4)
		{
			this.rectangle_0 = rectangle_4;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00005EBB File Offset: 0x000040BB
		[CompilerGenerated]
		public Rectangle method_10()
		{
			return this.rectangle_1;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00005EC3 File Offset: 0x000040C3
		[CompilerGenerated]
		public void method_11(Rectangle rectangle_4)
		{
			this.rectangle_1 = rectangle_4;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00005ECC File Offset: 0x000040CC
		[CompilerGenerated]
		public Rectangle method_12()
		{
			return this.rectangle_2;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00005ED4 File Offset: 0x000040D4
		[CompilerGenerated]
		public void method_13(Rectangle rectangle_4)
		{
			this.rectangle_2 = rectangle_4;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00005EDD File Offset: 0x000040DD
		[CompilerGenerated]
		public Rectangle method_14()
		{
			return this.rectangle_3;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00005EE5 File Offset: 0x000040E5
		[CompilerGenerated]
		public void method_15(Rectangle rectangle_4)
		{
			this.rectangle_3 = rectangle_4;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00005EEE File Offset: 0x000040EE
		[CompilerGenerated]
		public bool method_16()
		{
			return this.bool_2;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00005EF6 File Offset: 0x000040F6
		[CompilerGenerated]
		public void method_17(bool bool_4)
		{
			this.bool_2 = bool_4;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00005EFF File Offset: 0x000040FF
		[CompilerGenerated]
		public Bitmap method_18()
		{
			return this.bitmap_0;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00005F07 File Offset: 0x00004107
		[CompilerGenerated]
		public void method_19(Bitmap bitmap_2)
		{
			this.bitmap_0 = bitmap_2;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00005F10 File Offset: 0x00004110
		[CompilerGenerated]
		public Bitmap method_20()
		{
			return this.bitmap_1;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00005F18 File Offset: 0x00004118
		public bool method_21()
		{
			return this.bool_1;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000695D4 File Offset: 0x000677D4
		public void method_22(bool bool_4)
		{
			if (this.bool_1 == bool_4)
			{
				return;
			}
			if (bool_4 && this.method_23().Count == 0)
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
			Control6 control = this.method_26();
			if (control == null)
			{
				return;
			}
			control.method_41();
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00005F20 File Offset: 0x00004120
		public ObservableList<Class127> method_23()
		{
			return this.observableList_0;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00069648 File Offset: 0x00067848
		public void method_24(ObservableList<Class127> observableList_1)
		{
			if (this.observableList_0 != null)
			{
				this.observableList_0.method_1(new EventHandler<EventArgs5<Class127>>(this.method_45));
				this.observableList_0.method_3(new EventHandler<EventArgs5<Class127>>(this.method_46));
			}
			this.observableList_0 = observableList_1;
			this.observableList_0.method_0(new EventHandler<EventArgs5<Class127>>(this.method_45));
			this.observableList_0.method_2(new EventHandler<EventArgs5<Class127>>(this.method_46));
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00005F28 File Offset: 0x00004128
		public void method_25(bool bool_4)
		{
			this.bool_0 = bool_4;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00005F31 File Offset: 0x00004131
		public Control6 method_26()
		{
			return this.control6_0;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000696C0 File Offset: 0x000678C0
		public void method_27(Control6 control6_1)
		{
			if (this.control6_0 == control6_1)
			{
				return;
			}
			this.control6_0 = control6_1;
			foreach (Class127 @class in this.method_23())
			{
				@class.method_27(this.control6_0);
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00005F39 File Offset: 0x00004139
		public Class127 method_28()
		{
			return this.class127_0;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00005F41 File Offset: 0x00004141
		public void method_29(Class127 class127_3)
		{
			this.class127_0 = class127_3;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00005F4A File Offset: 0x0000414A
		[CompilerGenerated]
		public bool method_30()
		{
			return this.bool_3;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00005F52 File Offset: 0x00004152
		[CompilerGenerated]
		public void method_31(bool bool_4)
		{
			this.bool_3 = bool_4;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00005F5B File Offset: 0x0000415B
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00005F63 File Offset: 0x00004163
		public object Tag { get; set; }

		// Token: 0x0600051D RID: 1309 RVA: 0x00005F6C File Offset: 0x0000416C
		[CompilerGenerated]
		public Class127 method_32()
		{
			return this.class127_1;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00005F74 File Offset: 0x00004174
		[CompilerGenerated]
		public void method_33(Class127 class127_3)
		{
			this.class127_1 = class127_3;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00005F7D File Offset: 0x0000417D
		[CompilerGenerated]
		public Class127 method_34()
		{
			return this.class127_2;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00005F85 File Offset: 0x00004185
		[CompilerGenerated]
		public void method_35(Class127 class127_3)
		{
			this.class127_2 = class127_3;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00005F8E File Offset: 0x0000418E
		[CompilerGenerated]
		public int method_36()
		{
			return this.int_0;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00005F96 File Offset: 0x00004196
		[CompilerGenerated]
		public void method_37(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00005F9F File Offset: 0x0000419F
		[CompilerGenerated]
		public Color method_38()
		{
			return this.color_0;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00005FA7 File Offset: 0x000041A7
		[CompilerGenerated]
		public void method_39(Color color_1)
		{
			this.color_0 = color_1;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00005FB0 File Offset: 0x000041B0
		[CompilerGenerated]
		public Font method_40()
		{
			return this.font_0;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00005FB8 File Offset: 0x000041B8
		[CompilerGenerated]
		public void method_41(Font font_1)
		{
			this.font_0 = font_1;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00005FC1 File Offset: 0x000041C1
		public Class127()
		{
			this.method_24(new ObservableList<Class127>());
			this.method_39(Class129.smethod_11());
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00005FDF File Offset: 0x000041DF
		public Class127(string string_1) : this()
		{
			this.method_7(string_1);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00005FEE File Offset: 0x000041EE
		public void method_42()
		{
			if (this.method_28() != null)
			{
				this.method_28().method_23().method_6(this);
				return;
			}
			this.method_26().method_20().method_6(this);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00069728 File Offset: 0x00067928
		public void method_43()
		{
			for (Class127 @class = this.method_28(); @class != null; @class = @class.method_28())
			{
				@class.method_22(true);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00069750 File Offset: 0x00067950
		private void method_44()
		{
			if (this.method_26() != null && this.method_26().method_31() != null)
			{
				if (this.method_28() != null)
				{
					this.method_28().method_23().Sort(this.method_26().method_31());
				}
				else
				{
					this.method_26().method_20().Sort(this.method_26().method_31());
				}
			}
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, null);
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000697C8 File Offset: 0x000679C8
		private void method_45(object sender, EventArgs5<Class127> e)
		{
			foreach (Class127 @class in e.method_0())
			{
				@class.method_29(this);
				@class.method_27(this.method_26());
			}
			if (this.method_26() != null && this.method_26().method_31() != null)
			{
				this.method_23().Sort(this.method_26().method_31());
			}
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, e);
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0000601B File Offset: 0x0000421B
		private void method_46(object sender, EventArgs5<Class127> e)
		{
			if (this.method_23().Count == 0)
			{
				this.method_22(false);
			}
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, e);
			}
		}

		// Token: 0x040003A0 RID: 928
		[CompilerGenerated]
		private EventHandler<EventArgs5<Class127>> eventHandler_0;

		// Token: 0x040003A1 RID: 929
		[CompilerGenerated]
		private EventHandler<EventArgs5<Class127>> eventHandler_1;

		// Token: 0x040003A2 RID: 930
		[CompilerGenerated]
		private EventHandler eventHandler_2;

		// Token: 0x040003A3 RID: 931
		[CompilerGenerated]
		private EventHandler eventHandler_3;

		// Token: 0x040003A4 RID: 932
		[CompilerGenerated]
		private EventHandler eventHandler_4;

		// Token: 0x040003A5 RID: 933
		private string string_0;

		// Token: 0x040003A6 RID: 934
		private bool bool_0;

		// Token: 0x040003A7 RID: 935
		private Control6 control6_0;

		// Token: 0x040003A8 RID: 936
		private Class127 class127_0;

		// Token: 0x040003A9 RID: 937
		private ObservableList<Class127> observableList_0;

		// Token: 0x040003AA RID: 938
		private bool bool_1;

		// Token: 0x040003AB RID: 939
		[CompilerGenerated]
		private Rectangle rectangle_0;

		// Token: 0x040003AC RID: 940
		[CompilerGenerated]
		private Rectangle rectangle_1;

		// Token: 0x040003AD RID: 941
		[CompilerGenerated]
		private Rectangle rectangle_2;

		// Token: 0x040003AE RID: 942
		[CompilerGenerated]
		private Rectangle rectangle_3;

		// Token: 0x040003AF RID: 943
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x040003B0 RID: 944
		[CompilerGenerated]
		private Bitmap bitmap_0;

		// Token: 0x040003B1 RID: 945
		[CompilerGenerated]
		private Bitmap bitmap_1;

		// Token: 0x040003B2 RID: 946
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x040003B3 RID: 947
		[CompilerGenerated]
		private object object_0;

		// Token: 0x040003B4 RID: 948
		[CompilerGenerated]
		private Class127 class127_1;

		// Token: 0x040003B5 RID: 949
		[CompilerGenerated]
		private Class127 class127_2;

		// Token: 0x040003B6 RID: 950
		[CompilerGenerated]
		private int int_0;

		// Token: 0x040003B7 RID: 951
		[CompilerGenerated]
		private Color color_0;

		// Token: 0x040003B8 RID: 952
		[CompilerGenerated]
		private Font font_0;
	}
}
