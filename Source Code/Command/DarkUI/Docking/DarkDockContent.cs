using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns3;

namespace DarkUI.Docking
{
	// Token: 0x020000B2 RID: 178
	public sealed class DarkDockContent : UserControl
	{
		// Token: 0x06000385 RID: 901 RVA: 0x00063180 File Offset: 0x00061380
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

		// Token: 0x06000386 RID: 902 RVA: 0x000631B8 File Offset: 0x000613B8
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

		// Token: 0x06000387 RID: 903 RVA: 0x0000512E File Offset: 0x0000332E
		public string method_2()
		{
			return this.string_0;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00005136 File Offset: 0x00003336
		public Image method_3()
		{
			return this.image_0;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000513E File Offset: 0x0000333E
		[CompilerGenerated]
		public Enum13 method_4()
		{
			return this.enum13_0;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00005146 File Offset: 0x00003346
		[CompilerGenerated]
		public DarkDockPanel method_5()
		{
			return this.darkDockPanel_0;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000514E File Offset: 0x0000334E
		[CompilerGenerated]
		internal void method_6(DarkDockPanel darkDockPanel_1)
		{
			this.darkDockPanel_0 = darkDockPanel_1;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00005157 File Offset: 0x00003357
		[CompilerGenerated]
		public DarkDockRegion method_7()
		{
			return this.darkDockRegion_0;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000515F File Offset: 0x0000335F
		[CompilerGenerated]
		internal void method_8(DarkDockRegion darkDockRegion_1)
		{
			this.darkDockRegion_0 = darkDockRegion_1;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00005168 File Offset: 0x00003368
		[CompilerGenerated]
		public DarkDockGroup method_9()
		{
			return this.darkDockGroup_0;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00005170 File Offset: 0x00003370
		[CompilerGenerated]
		internal void method_10(DarkDockGroup darkDockGroup_1)
		{
			this.darkDockGroup_0 = darkDockGroup_1;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00005179 File Offset: 0x00003379
		[CompilerGenerated]
		public Enum13 method_11()
		{
			return this.enum13_1;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00005181 File Offset: 0x00003381
		[CompilerGenerated]
		public void method_12(Enum13 enum13_2)
		{
			this.enum13_1 = enum13_2;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000518A File Offset: 0x0000338A
		[CompilerGenerated]
		public int method_13()
		{
			return this.int_0;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00005192 File Offset: 0x00003392
		[CompilerGenerated]
		public void method_14(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000051A3 File Offset: 0x000033A3
		public void vmethod_0()
		{
			if (this.method_5() != null)
			{
				this.method_5().method_13(this);
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000051B9 File Offset: 0x000033B9
		protected override void OnEnter(EventArgs e)
		{
			base.OnEnter(e);
			if (this.method_5() == null)
			{
				return;
			}
			this.method_5().method_1(this);
		}

		// Token: 0x040002E8 RID: 744
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x040002E9 RID: 745
		private string string_0;

		// Token: 0x040002EA RID: 746
		private Image image_0;

		// Token: 0x040002EB RID: 747
		[CompilerGenerated]
		private Enum13 enum13_0;

		// Token: 0x040002EC RID: 748
		[CompilerGenerated]
		private DarkDockPanel darkDockPanel_0;

		// Token: 0x040002ED RID: 749
		[CompilerGenerated]
		private DarkDockRegion darkDockRegion_0;

		// Token: 0x040002EE RID: 750
		[CompilerGenerated]
		private DarkDockGroup darkDockGroup_0;

		// Token: 0x040002EF RID: 751
		[CompilerGenerated]
		private Enum13 enum13_1;

		// Token: 0x040002F0 RID: 752
		[CompilerGenerated]
		private int int_0;
	}
}
