using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;

namespace ns7
{
	// Token: 0x02000F53 RID: 3923
	internal sealed class Class2569 : ICommand
	{
		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06008C3E RID: 35902 RVA: 0x004B7984 File Offset: 0x004B5B84
		// (remove) Token: 0x06008C3F RID: 35903 RVA: 0x004B79BC File Offset: 0x004B5BBC
		event EventHandler ICommand.CanExecuteChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06008C40 RID: 35904 RVA: 0x00053AFF File Offset: 0x00051CFF
		public Class2569(Action<object> action_1) : this(action_1, null)
		{
		}

		// Token: 0x06008C41 RID: 35905 RVA: 0x00053B09 File Offset: 0x00051D09
		public Class2569(Action<object> action_1, Predicate<object> predicate_1)
		{
			if (action_1 == null)
			{
				throw new ArgumentNullException("execute");
			}
			this.action_0 = action_1;
			this.predicate_0 = predicate_1;
		}

		// Token: 0x06008C42 RID: 35906 RVA: 0x00053B2D File Offset: 0x00051D2D
		public bool CanExecute(object parameter)
		{
			return this.predicate_0 == null || this.predicate_0(RuntimeHelpers.GetObjectValue(parameter));
		}

		// Token: 0x06008C43 RID: 35907 RVA: 0x00053B4A File Offset: 0x00051D4A
		public void Execute(object parameter)
		{
			this.action_0(RuntimeHelpers.GetObjectValue(parameter));
		}

		// Token: 0x04004BF4 RID: 19444
		private readonly Action<object> action_0;

		// Token: 0x04004BF5 RID: 19445
		private readonly Predicate<object> predicate_0;

		// Token: 0x04004BF6 RID: 19446
		[CompilerGenerated]
		private EventHandler eventHandler_0;
	}
}
