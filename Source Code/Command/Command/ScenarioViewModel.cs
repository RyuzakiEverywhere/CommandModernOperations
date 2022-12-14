using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;
using ns7;

namespace Command
{
	// Token: 0x02000E28 RID: 3624
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public abstract class ScenarioViewModel : INotifyPropertyChanged
	{
		// Token: 0x06006C85 RID: 27781 RVA: 0x000444D4 File Offset: 0x000426D4
		protected ScenarioViewModel()
		{
			this.SelectCommand = new Class2569(new Action<object>(this.method_1));
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06006C86 RID: 27782 RVA: 0x000444F3 File Offset: 0x000426F3
		// (set) Token: 0x06006C87 RID: 27783 RVA: 0x000444FB File Offset: 0x000426FB
		public string ScenarioDate
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
				this.vmethod_0("ScenarioDate");
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06006C88 RID: 27784 RVA: 0x0004451F File Offset: 0x0004271F
		// (set) Token: 0x06006C89 RID: 27785 RVA: 0x00044527 File Offset: 0x00042727
		public string ScenarioComplexity
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
				this.vmethod_0("ScenarioComplexity");
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06006C8A RID: 27786 RVA: 0x0004454B File Offset: 0x0004274B
		// (set) Token: 0x06006C8B RID: 27787 RVA: 0x00044553 File Offset: 0x00042753
		public string ScenarioDifficulty
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
				this.vmethod_0("ScenarioDifficulty");
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06006C8C RID: 27788 RVA: 0x00044577 File Offset: 0x00042777
		// (set) Token: 0x06006C8D RID: 27789 RVA: 0x0004457F File Offset: 0x0004277F
		public string ScenarioName
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
				this.vmethod_0("ScenarioName");
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06006C8E RID: 27790 RVA: 0x000445A3 File Offset: 0x000427A3
		// (set) Token: 0x06006C8F RID: 27791 RVA: 0x000445AB File Offset: 0x000427AB
		public string ScenarioPath
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
				this.vmethod_0("ScenarioPath");
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06006C90 RID: 27792 RVA: 0x000445CF File Offset: 0x000427CF
		// (set) Token: 0x06006C91 RID: 27793 RVA: 0x000445D7 File Offset: 0x000427D7
		public Class2569 SelectCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_0 == value)
				{
					return;
				}
				this.class2569_0 = value;
				this.vmethod_0("SelectCommand");
			}
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x003B94EC File Offset: 0x003B76EC
		public void method_0()
		{
			this.scenarioSelectControlViewModel_0.loadScenario_0.vmethod_14().Visible = true;
			this.scenarioSelectControlViewModel_0.loadScenario_0.vmethod_22().Visible = true;
			this.scenarioSelectControlViewModel_0.loadScenario_0.vmethod_26().Visible = true;
			this.scenarioSelectControlViewModel_0.loadScenario_0.vmethod_24().Visible = true;
			this.scenarioSelectControlViewModel_0.loadScenario_0.vmethod_28().Visible = true;
			this.scenarioSelectControlViewModel_0.loadScenario_0.vmethod_30().Visible = true;
			this.scenarioSelectControlViewModel_0.loadScenario_0.method_19(this.ScenarioPath, this.ScenarioName);
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x000445F7 File Offset: 0x000427F7
		[CompilerGenerated]
		private void method_1(object a0)
		{
			this.method_0();
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06006C94 RID: 27796 RVA: 0x003B959C File Offset: 0x003B779C
		// (remove) Token: 0x06006C95 RID: 27797 RVA: 0x003B95D4 File Offset: 0x003B77D4
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

		// Token: 0x06006C96 RID: 27798 RVA: 0x003B960C File Offset: 0x003B780C
		public virtual void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003DEF RID: 15855
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003DF0 RID: 15856
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04003DF1 RID: 15857
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04003DF2 RID: 15858
		[CompilerGenerated]
		private string string_3;

		// Token: 0x04003DF3 RID: 15859
		[CompilerGenerated]
		private string string_4;

		// Token: 0x04003DF4 RID: 15860
		public ScenarioSelectControlViewModel scenarioSelectControlViewModel_0;

		// Token: 0x04003DF5 RID: 15861
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x04003DF6 RID: 15862
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
