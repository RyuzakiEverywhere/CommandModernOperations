using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using ns8;

namespace DarkUI.Collections
{
	// Token: 0x020000E4 RID: 228
	public sealed class ObservableList<T> : List<T>, IDisposable
	{
		// Token: 0x060005D6 RID: 1494 RVA: 0x0006D2DC File Offset: 0x0006B4DC
		[CompilerGenerated]
		public void method_0(EventHandler<EventArgs5<T>> eventHandler_2)
		{
			EventHandler<EventArgs5<T>> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs5<T>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs5<T>> value = (EventHandler<EventArgs5<T>>)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs5<T>>>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0006D314 File Offset: 0x0006B514
		[CompilerGenerated]
		public void method_1(EventHandler<EventArgs5<T>> eventHandler_2)
		{
			EventHandler<EventArgs5<T>> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs5<T>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs5<T>> value = (EventHandler<EventArgs5<T>>)Delegate.Remove(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs5<T>>>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0006D34C File Offset: 0x0006B54C
		[CompilerGenerated]
		public void method_2(EventHandler<EventArgs5<T>> eventHandler_2)
		{
			EventHandler<EventArgs5<T>> eventHandler = this.eventHandler_1;
			EventHandler<EventArgs5<T>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs5<T>> value = (EventHandler<EventArgs5<T>>)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs5<T>>>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0006D384 File Offset: 0x0006B584
		[CompilerGenerated]
		public void method_3(EventHandler<EventArgs5<T>> eventHandler_2)
		{
			EventHandler<EventArgs5<T>> eventHandler = this.eventHandler_1;
			EventHandler<EventArgs5<T>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs5<T>> value = (EventHandler<EventArgs5<T>>)Delegate.Remove(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs5<T>>>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0006D3BC File Offset: 0x0006B5BC
		~ObservableList()
		{
			this.vmethod_0(false);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000064BB File Offset: 0x000046BB
		public void Dispose()
		{
			this.vmethod_0(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000064CA File Offset: 0x000046CA
		protected void vmethod_0(bool bool_1)
		{
			if (!this.bool_0)
			{
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0 = null;
				}
				if (this.eventHandler_1 != null)
				{
					this.eventHandler_1 = null;
				}
				this.bool_0 = true;
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000064F9 File Offset: 0x000046F9
		public void method_4(T gparam_0)
		{
			base.Add(gparam_0);
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs5<T>(new List<T>
				{
					gparam_0
				}));
			}
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0006D3EC File Offset: 0x0006B5EC
		public void method_5(IEnumerable<T> ienumerable_0)
		{
			List<T> list = Enumerable.ToList<T>(ienumerable_0);
			base.AddRange(list);
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs5<T>(list));
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00006527 File Offset: 0x00004727
		public void method_6(T gparam_0)
		{
			base.Remove(gparam_0);
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, new EventArgs5<T>(new List<T>
				{
					gparam_0
				}));
			}
		}

		// Token: 0x040003FA RID: 1018
		private bool bool_0;

		// Token: 0x040003FB RID: 1019
		[CompilerGenerated]
		private EventHandler<EventArgs5<T>> eventHandler_0;

		// Token: 0x040003FC RID: 1020
		[CompilerGenerated]
		private EventHandler<EventArgs5<T>> eventHandler_1;
	}
}
