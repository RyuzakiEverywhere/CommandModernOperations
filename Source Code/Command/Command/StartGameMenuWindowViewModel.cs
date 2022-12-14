using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns7;

namespace Command
{
	// Token: 0x02000E3B RID: 3643
	[Attribute11]
	[Attribute12]
	[Attribute13]
	public sealed class StartGameMenuWindowViewModel : INotifyPropertyChanged
	{
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06006D63 RID: 28003 RVA: 0x00044CC7 File Offset: 0x00042EC7
		// (set) Token: 0x06006D64 RID: 28004 RVA: 0x00044CCF File Offset: 0x00042ECF
		public Class2569 StartNewCampaignCommand
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
				this.vmethod_0("StartNewCampaignCommand");
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06006D65 RID: 28005 RVA: 0x00044CEF File Offset: 0x00042EEF
		// (set) Token: 0x06006D66 RID: 28006 RVA: 0x00044CF7 File Offset: 0x00042EF7
		public Class2569 QuickBattleCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_1 == value)
				{
					return;
				}
				this.class2569_1 = value;
				this.vmethod_0("QuickBattleCommand");
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06006D67 RID: 28007 RVA: 0x00044D17 File Offset: 0x00042F17
		// (set) Token: 0x06006D68 RID: 28008 RVA: 0x00044D1F File Offset: 0x00042F1F
		public Class2569 NewGameCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_2 == value)
				{
					return;
				}
				this.class2569_2 = value;
				this.vmethod_0("NewGameCommand");
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06006D69 RID: 28009 RVA: 0x00044D3F File Offset: 0x00042F3F
		// (set) Token: 0x06006D6A RID: 28010 RVA: 0x00044D47 File Offset: 0x00042F47
		public Class2569 LoadGameCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_3 == value)
				{
					return;
				}
				this.class2569_3 = value;
				this.vmethod_0("LoadGameCommand");
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06006D6B RID: 28011 RVA: 0x00044D67 File Offset: 0x00042F67
		// (set) Token: 0x06006D6C RID: 28012 RVA: 0x00044D6F File Offset: 0x00042F6F
		public Class2569 ResumeGameCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_4 == value)
				{
					return;
				}
				this.class2569_4 = value;
				this.vmethod_0("ResumeGameCommand");
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06006D6D RID: 28013 RVA: 0x00044D8F File Offset: 0x00042F8F
		// (set) Token: 0x06006D6E RID: 28014 RVA: 0x00044D97 File Offset: 0x00042F97
		public Class2569 CreateScenCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_5;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_5 == value)
				{
					return;
				}
				this.class2569_5 = value;
				this.vmethod_0("CreateScenCommand");
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06006D6F RID: 28015 RVA: 0x00044DB7 File Offset: 0x00042FB7
		// (set) Token: 0x06006D70 RID: 28016 RVA: 0x00044DBF File Offset: 0x00042FBF
		public Class2569 LoadScenCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_6;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_6 == value)
				{
					return;
				}
				this.class2569_6 = value;
				this.vmethod_0("LoadScenCommand");
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06006D71 RID: 28017 RVA: 0x00044DDF File Offset: 0x00042FDF
		// (set) Token: 0x06006D72 RID: 28018 RVA: 0x00044DE7 File Offset: 0x00042FE7
		public Class2569 ExitCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_7;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_7 == value)
				{
					return;
				}
				this.class2569_7 = value;
				this.vmethod_0("ExitCommand");
			}
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x00044E07 File Offset: 0x00043007
		private void method_0(object obj)
		{
			Client.dispatcher_0.InvokeAsync((StartGameMenuWindowViewModel._Closure$__.$I32-0 == null) ? (StartGameMenuWindowViewModel._Closure$__.$I32-0 = new Action(StartGameMenuWindowViewModel._Closure$__.$I.method_0)) : StartGameMenuWindowViewModel._Closure$__.$I32-0);
			this.startGameMenuWindow_0.Close();
		}

		// Token: 0x06006D74 RID: 28020 RVA: 0x00044E43 File Offset: 0x00043043
		private void method_1(object obj)
		{
			Client.dispatcher_0.InvokeAsync((StartGameMenuWindowViewModel._Closure$__.$I33-0 == null) ? (StartGameMenuWindowViewModel._Closure$__.$I33-0 = new Action(StartGameMenuWindowViewModel._Closure$__.$I.method_1)) : StartGameMenuWindowViewModel._Closure$__.$I33-0);
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x00044E74 File Offset: 0x00043074
		private void method_2(object obj)
		{
			Client.dispatcher_0.InvokeAsync((StartGameMenuWindowViewModel._Closure$__.$I34-0 == null) ? (StartGameMenuWindowViewModel._Closure$__.$I34-0 = new Action(StartGameMenuWindowViewModel._Closure$__.$I.method_2)) : StartGameMenuWindowViewModel._Closure$__.$I34-0);
		}

		// Token: 0x06006D76 RID: 28022 RVA: 0x00044EA5 File Offset: 0x000430A5
		private void method_3(object obj)
		{
			Client.dispatcher_0.InvokeAsync((StartGameMenuWindowViewModel._Closure$__.$I35-0 == null) ? (StartGameMenuWindowViewModel._Closure$__.$I35-0 = new Action(StartGameMenuWindowViewModel._Closure$__.$I.method_3)) : StartGameMenuWindowViewModel._Closure$__.$I35-0);
			this.startGameMenuWindow_0.Close();
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x00044EE1 File Offset: 0x000430E1
		private void method_4(object obj)
		{
			Client.dispatcher_0.InvokeAsync((StartGameMenuWindowViewModel._Closure$__.$I36-0 == null) ? (StartGameMenuWindowViewModel._Closure$__.$I36-0 = new Action(StartGameMenuWindowViewModel._Closure$__.$I.method_4)) : StartGameMenuWindowViewModel._Closure$__.$I36-0);
		}

		// Token: 0x06006D78 RID: 28024 RVA: 0x00044F12 File Offset: 0x00043112
		private void method_5(object obj)
		{
			Client.dispatcher_0.InvokeAsync((StartGameMenuWindowViewModel._Closure$__.$I37-0 == null) ? (StartGameMenuWindowViewModel._Closure$__.$I37-0 = new Action(StartGameMenuWindowViewModel._Closure$__.$I.method_5)) : StartGameMenuWindowViewModel._Closure$__.$I37-0);
		}

		// Token: 0x06006D79 RID: 28025 RVA: 0x00044F43 File Offset: 0x00043143
		private void method_6(object obj)
		{
			Client.dispatcher_0.InvokeAsync((StartGameMenuWindowViewModel._Closure$__.$I38-0 == null) ? (StartGameMenuWindowViewModel._Closure$__.$I38-0 = new Action(StartGameMenuWindowViewModel._Closure$__.$I.method_6)) : StartGameMenuWindowViewModel._Closure$__.$I38-0);
		}

		// Token: 0x06006D7A RID: 28026 RVA: 0x00044F74 File Offset: 0x00043174
		private void method_7(object obj)
		{
			Client.dispatcher_0.InvokeAsync((StartGameMenuWindowViewModel._Closure$__.$I39-0 == null) ? (StartGameMenuWindowViewModel._Closure$__.$I39-0 = new Action(StartGameMenuWindowViewModel._Closure$__.$I.method_7)) : StartGameMenuWindowViewModel._Closure$__.$I39-0);
		}

		// Token: 0x06006D7B RID: 28027 RVA: 0x003BC2E8 File Offset: 0x003BA4E8
		[Obsolete]
		public StartGameMenuWindowViewModel()
		{
			this.StartNewCampaignCommand = new Class2569(new Action<object>(this.method_7));
			this.QuickBattleCommand = new Class2569(new Action<object>(this.method_0));
			this.NewGameCommand = new Class2569(new Action<object>(this.method_6));
			this.LoadGameCommand = new Class2569(new Action<object>(this.method_5));
			this.ResumeGameCommand = new Class2569(new Action<object>(this.method_4));
			this.CreateScenCommand = new Class2569(new Action<object>(this.method_3));
			this.LoadScenCommand = new Class2569(new Action<object>(this.method_2));
			this.ExitCommand = new Class2569(new Action<object>(this.method_1));
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x003BC3B4 File Offset: 0x003BA5B4
		public StartGameMenuWindowViewModel(StartGameMenuWindow sg)
		{
			this.StartNewCampaignCommand = new Class2569(new Action<object>(this.method_7));
			this.QuickBattleCommand = new Class2569(new Action<object>(this.method_0));
			this.NewGameCommand = new Class2569(new Action<object>(this.method_6));
			this.LoadGameCommand = new Class2569(new Action<object>(this.method_5));
			this.ResumeGameCommand = new Class2569(new Action<object>(this.method_4));
			this.CreateScenCommand = new Class2569(new Action<object>(this.method_3));
			this.LoadScenCommand = new Class2569(new Action<object>(this.method_2));
			this.ExitCommand = new Class2569(new Action<object>(this.method_1));
			this.startGameMenuWindow_0 = sg;
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06006D7D RID: 28029 RVA: 0x003BC488 File Offset: 0x003BA688
		// (remove) Token: 0x06006D7E RID: 28030 RVA: 0x003BC4C0 File Offset: 0x003BA6C0
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

		// Token: 0x06006D7F RID: 28031 RVA: 0x003BC4F8 File Offset: 0x003BA6F8
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003E4C RID: 15948
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x04003E4D RID: 15949
		[CompilerGenerated]
		private Class2569 class2569_1;

		// Token: 0x04003E4E RID: 15950
		[CompilerGenerated]
		private Class2569 class2569_2;

		// Token: 0x04003E4F RID: 15951
		[CompilerGenerated]
		private Class2569 class2569_3;

		// Token: 0x04003E50 RID: 15952
		[CompilerGenerated]
		private Class2569 class2569_4;

		// Token: 0x04003E51 RID: 15953
		[CompilerGenerated]
		private Class2569 class2569_5;

		// Token: 0x04003E52 RID: 15954
		[CompilerGenerated]
		private Class2569 class2569_6;

		// Token: 0x04003E53 RID: 15955
		[CompilerGenerated]
		private Class2569 class2569_7;

		// Token: 0x04003E54 RID: 15956
		private StartGameMenuWindow startGameMenuWindow_0;

		// Token: 0x04003E55 RID: 15957
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
