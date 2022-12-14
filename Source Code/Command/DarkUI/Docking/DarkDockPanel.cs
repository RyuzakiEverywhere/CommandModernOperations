using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns2;
using ns3;
using ns8;

namespace DarkUI.Docking
{
	// Token: 0x020000B5 RID: 181
	public sealed class DarkDockPanel : UserControl
	{
		// Token: 0x060003BE RID: 958 RVA: 0x000649CC File Offset: 0x00062BCC
		[CompilerGenerated]
		public void method_0(EventHandler<EventArgs3> eventHandler_3)
		{
			EventHandler<EventArgs3> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs3> value = (EventHandler<EventArgs3>)Delegate.Combine(eventHandler2, eventHandler_3);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs3>>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00064A04 File Offset: 0x00062C04
		public void method_1(DarkDockContent darkDockContent_1)
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			this.darkDockContent_0 = darkDockContent_1;
			this.method_4(this.darkDockContent_0.method_9());
			this.method_2(this.method_3().method_2());
			foreach (DarkDockRegion darkDockRegion in this.dictionary_0.Values)
			{
				darkDockRegion.method_15();
			}
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs3(this.darkDockContent_0));
			}
			this.bool_0 = false;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000052E2 File Offset: 0x000034E2
		[CompilerGenerated]
		internal void method_2(DarkDockRegion darkDockRegion_1)
		{
			this.darkDockRegion_0 = darkDockRegion_1;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000052EB File Offset: 0x000034EB
		[CompilerGenerated]
		public DarkDockGroup method_3()
		{
			return this.darkDockGroup_0;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000052F3 File Offset: 0x000034F3
		[CompilerGenerated]
		internal void method_4(DarkDockGroup darkDockGroup_1)
		{
			this.darkDockGroup_0 = darkDockGroup_1;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000052FC File Offset: 0x000034FC
		[CompilerGenerated]
		private void method_5(Class101 class101_1)
		{
			this.class101_0 = class101_1;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00005305 File Offset: 0x00003505
		[CompilerGenerated]
		private void method_6(Class102 class102_1)
		{
			this.class102_0 = class102_1;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000530E File Offset: 0x0000350E
		[CompilerGenerated]
		public List<Class107> method_7()
		{
			return this.list_1;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00005316 File Offset: 0x00003516
		[CompilerGenerated]
		private void method_8(List<Class107> list_2)
		{
			this.list_1 = list_2;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000531F File Offset: 0x0000351F
		public MouseButtons method_9()
		{
			return Control.MouseButtons;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00064ABC File Offset: 0x00062CBC
		public DarkDockPanel()
		{
			this.method_8(new List<Class107>());
			this.method_5(new Class101(this));
			this.method_6(new Class102(this));
			this.dictionary_0 = new Dictionary<Enum13, DarkDockRegion>();
			this.list_0 = new List<DarkDockContent>();
			this.BackColor = Class129.smethod_0();
			this.method_14();
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00005326 File Offset: 0x00003526
		public void method_10(DarkDockContent darkDockContent_1)
		{
			this.method_11(darkDockContent_1, null);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00064B1C File Offset: 0x00062D1C
		public void method_11(DarkDockContent darkDockContent_1, DarkDockGroup darkDockGroup_1)
		{
			if (this.list_0.Contains(darkDockContent_1))
			{
				this.method_13(darkDockContent_1);
			}
			darkDockContent_1.method_6(this);
			this.list_0.Add(darkDockContent_1);
			if (darkDockGroup_1 != null)
			{
				darkDockContent_1.method_12(darkDockGroup_1.method_4());
			}
			if (darkDockContent_1.method_11() == Enum13.const_0)
			{
				darkDockContent_1.method_12(darkDockContent_1.method_4());
			}
			this.dictionary_0[darkDockContent_1.method_11()].method_4(darkDockContent_1, darkDockGroup_1);
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, new EventArgs3(darkDockContent_1));
			}
			darkDockContent_1.Select();
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00064BAC File Offset: 0x00062DAC
		public void method_12(DarkDockContent darkDockContent_1, DarkDockGroup darkDockGroup_1, Enum15 enum15_0)
		{
			if (this.list_0.Contains(darkDockContent_1))
			{
				this.method_13(darkDockContent_1);
			}
			darkDockContent_1.method_6(this);
			this.list_0.Add(darkDockContent_1);
			darkDockContent_1.method_12(darkDockGroup_1.method_4());
			this.dictionary_0[darkDockGroup_1.method_4()].method_5(darkDockContent_1, darkDockGroup_1, enum15_0);
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, new EventArgs3(darkDockContent_1));
			}
			darkDockContent_1.Select();
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00064C28 File Offset: 0x00062E28
		public void method_13(DarkDockContent darkDockContent_1)
		{
			if (!this.list_0.Contains(darkDockContent_1))
			{
				return;
			}
			darkDockContent_1.method_6(null);
			this.list_0.Remove(darkDockContent_1);
			this.dictionary_0[darkDockContent_1.method_11()].method_6(darkDockContent_1);
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, new EventArgs3(darkDockContent_1));
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00064C8C File Offset: 0x00062E8C
		private void method_14()
		{
			DarkDockRegion darkDockRegion = new DarkDockRegion(this, Enum13.const_1);
			this.dictionary_0.Add(Enum13.const_1, darkDockRegion);
			DarkDockRegion darkDockRegion2 = new DarkDockRegion(this, Enum13.const_2);
			this.dictionary_0.Add(Enum13.const_2, darkDockRegion2);
			DarkDockRegion darkDockRegion3 = new DarkDockRegion(this, Enum13.const_3);
			this.dictionary_0.Add(Enum13.const_3, darkDockRegion3);
			DarkDockRegion darkDockRegion4 = new DarkDockRegion(this, Enum13.const_4);
			this.dictionary_0.Add(Enum13.const_4, darkDockRegion4);
			base.Controls.Add(darkDockRegion);
			base.Controls.Add(darkDockRegion4);
			base.Controls.Add(darkDockRegion2);
			base.Controls.Add(darkDockRegion3);
			darkDockRegion.TabIndex = 0;
			darkDockRegion3.TabIndex = 1;
			darkDockRegion4.TabIndex = 2;
			darkDockRegion2.TabIndex = 3;
		}

		// Token: 0x040002FF RID: 767
		[CompilerGenerated]
		private EventHandler<EventArgs3> eventHandler_0;

		// Token: 0x04000300 RID: 768
		[CompilerGenerated]
		private EventHandler<EventArgs3> eventHandler_1;

		// Token: 0x04000301 RID: 769
		[CompilerGenerated]
		private EventHandler<EventArgs3> eventHandler_2;

		// Token: 0x04000302 RID: 770
		private List<DarkDockContent> list_0;

		// Token: 0x04000303 RID: 771
		private Dictionary<Enum13, DarkDockRegion> dictionary_0;

		// Token: 0x04000304 RID: 772
		private DarkDockContent darkDockContent_0;

		// Token: 0x04000305 RID: 773
		private bool bool_0;

		// Token: 0x04000306 RID: 774
		[CompilerGenerated]
		private DarkDockRegion darkDockRegion_0;

		// Token: 0x04000307 RID: 775
		[CompilerGenerated]
		private DarkDockGroup darkDockGroup_0;

		// Token: 0x04000308 RID: 776
		[CompilerGenerated]
		private Class101 class101_0;

		// Token: 0x04000309 RID: 777
		[CompilerGenerated]
		private Class102 class102_0;

		// Token: 0x0400030A RID: 778
		[CompilerGenerated]
		private List<Class107> list_1;
	}
}
