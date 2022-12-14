using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using ns8;

namespace ns2
{
	// Token: 0x020000C8 RID: 200
	internal sealed class Class117
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x00066660 File Offset: 0x00064860
		[CompilerGenerated]
		public void method_0(EventHandler eventHandler_1)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00066698 File Offset: 0x00064898
		[CompilerGenerated]
		public void method_1(EventHandler eventHandler_1)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00005855 File Offset: 0x00003A55
		public string method_2()
		{
			return this.string_0;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000585D File Offset: 0x00003A5D
		public void method_3(string string_1)
		{
			this.string_0 = string_1;
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs());
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000587F File Offset: 0x00003A7F
		[CompilerGenerated]
		public Rectangle method_4()
		{
			return this.rectangle_0;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00005887 File Offset: 0x00003A87
		[CompilerGenerated]
		public void method_5(Rectangle rectangle_1)
		{
			this.rectangle_0 = rectangle_1;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00005890 File Offset: 0x00003A90
		[CompilerGenerated]
		public Color method_6()
		{
			return this.color_0;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00005898 File Offset: 0x00003A98
		[CompilerGenerated]
		public void method_7(Color color_1)
		{
			this.color_0 = color_1;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000058A1 File Offset: 0x00003AA1
		[CompilerGenerated]
		public FontStyle method_8()
		{
			return this.fontStyle_0;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000058A9 File Offset: 0x00003AA9
		[CompilerGenerated]
		public void method_9(FontStyle fontStyle_1)
		{
			this.fontStyle_0 = fontStyle_1;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000058B2 File Offset: 0x00003AB2
		[CompilerGenerated]
		public Bitmap method_10()
		{
			return this.bitmap_0;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000058BA File Offset: 0x00003ABA
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x000058C2 File Offset: 0x00003AC2
		public object Tag { get; set; }

		// Token: 0x0600045A RID: 1114 RVA: 0x000058CB File Offset: 0x00003ACB
		public Class117()
		{
			this.method_7(Class129.smethod_11());
			this.method_9(FontStyle.Regular);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000058E5 File Offset: 0x00003AE5
		public Class117(string string_1) : this()
		{
			this.method_3(string_1);
		}

		// Token: 0x0400034E RID: 846
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x0400034F RID: 847
		private string string_0;

		// Token: 0x04000350 RID: 848
		[CompilerGenerated]
		private Rectangle rectangle_0;

		// Token: 0x04000351 RID: 849
		[CompilerGenerated]
		private Color color_0;

		// Token: 0x04000352 RID: 850
		[CompilerGenerated]
		private FontStyle fontStyle_0;

		// Token: 0x04000353 RID: 851
		[CompilerGenerated]
		private Bitmap bitmap_0;

		// Token: 0x04000354 RID: 852
		[CompilerGenerated]
		private object object_0;
	}
}
