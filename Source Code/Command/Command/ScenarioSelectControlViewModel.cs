using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns6;

namespace Command
{
	// Token: 0x02000E2B RID: 3627
	[Attribute3]
	[Attribute2]
	[Attribute0]
	public sealed class ScenarioSelectControlViewModel : INotifyPropertyChanged
	{
		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06006C9A RID: 27802 RVA: 0x00044607 File Offset: 0x00042807
		// (set) Token: 0x06006C9B RID: 27803 RVA: 0x0004460F File Offset: 0x0004280F
		public ObservableCollection<ScenarioViewModel> Scenarios
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_0 == value)
				{
					return;
				}
				this.observableCollection_0 = value;
				this.vmethod_0("Scenarios");
			}
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x003B9634 File Offset: 0x003B7834
		public void method_0()
		{
			List<ScenarioViewModel> list = new List<ScenarioViewModel>();
			try
			{
				foreach (Class2486.Class2487 @class in Class2486.list_1)
				{
					if (@class.method_13() && @class.method_17() != null)
					{
						try
						{
							foreach (string text in Directory.EnumerateFiles(@class.method_17()))
							{
								if (Operators.CompareString(Path.GetExtension(text), ".scen", false) == 0)
								{
									list.Add(new SteamScenarioViewModel
									{
										scenarioSelectControlViewModel_0 = this,
										ScenarioName = Path.GetFileName(text),
										ScenarioDate = ScenContainer.smethod_1(text, "ScenDate"),
										ScenarioDifficulty = ScenContainer.smethod_1(text, "Difficulty"),
										ScenarioComplexity = ScenContainer.smethod_1(text, "Complexity"),
										ScenarioPath = text
									});
								}
							}
						}
						finally
						{
							IEnumerator<string> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
				}
			}
			finally
			{
				List<Class2486.Class2487>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.Scenarios = new ObservableCollection<ScenarioViewModel>(list);
			this.Scenarios = new ObservableCollection<ScenarioViewModel>(Enumerable.OrderBy<ScenarioViewModel, string>(this.Scenarios, (ScenarioSelectControlViewModel._Closure$__.$I6-0 == null) ? (ScenarioSelectControlViewModel._Closure$__.$I6-0 = new Func<ScenarioViewModel, string>(ScenarioSelectControlViewModel._Closure$__.$I.method_0)) : ScenarioSelectControlViewModel._Closure$__.$I6-0));
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x003B97A4 File Offset: 0x003B79A4
		public void method_1(int selectedIndex)
		{
			switch (selectedIndex)
			{
			case 0:
				this.Scenarios = new ObservableCollection<ScenarioViewModel>(Enumerable.OrderBy<ScenarioViewModel, string>(this.Scenarios, (ScenarioSelectControlViewModel._Closure$__.$I7-0 == null) ? (ScenarioSelectControlViewModel._Closure$__.$I7-0 = new Func<ScenarioViewModel, string>(ScenarioSelectControlViewModel._Closure$__.$I.method_1)) : ScenarioSelectControlViewModel._Closure$__.$I7-0));
				return;
			case 1:
				this.Scenarios = new ObservableCollection<ScenarioViewModel>(Enumerable.OrderBy<ScenarioViewModel, string>(this.Scenarios, (ScenarioSelectControlViewModel._Closure$__.$I7-1 == null) ? (ScenarioSelectControlViewModel._Closure$__.$I7-1 = new Func<ScenarioViewModel, string>(ScenarioSelectControlViewModel._Closure$__.$I.method_2)) : ScenarioSelectControlViewModel._Closure$__.$I7-1));
				return;
			case 2:
				this.Scenarios = new ObservableCollection<ScenarioViewModel>(Enumerable.OrderBy<ScenarioViewModel, string>(this.Scenarios, (ScenarioSelectControlViewModel._Closure$__.$I7-2 == null) ? (ScenarioSelectControlViewModel._Closure$__.$I7-2 = new Func<ScenarioViewModel, string>(ScenarioSelectControlViewModel._Closure$__.$I.method_3)) : ScenarioSelectControlViewModel._Closure$__.$I7-2));
				return;
			case 3:
				this.Scenarios = new ObservableCollection<ScenarioViewModel>(Enumerable.OrderBy<ScenarioViewModel, string>(this.Scenarios, (ScenarioSelectControlViewModel._Closure$__.$I7-3 == null) ? (ScenarioSelectControlViewModel._Closure$__.$I7-3 = new Func<ScenarioViewModel, string>(ScenarioSelectControlViewModel._Closure$__.$I.method_4)) : ScenarioSelectControlViewModel._Closure$__.$I7-3));
				return;
			default:
				return;
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06006C9E RID: 27806 RVA: 0x003B98B8 File Offset: 0x003B7AB8
		// (remove) Token: 0x06006C9F RID: 27807 RVA: 0x003B98F0 File Offset: 0x003B7AF0
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

		// Token: 0x06006CA0 RID: 27808 RVA: 0x003B9928 File Offset: 0x003B7B28
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003DF7 RID: 15863
		public LoadScenario loadScenario_0;

		// Token: 0x04003DF8 RID: 15864
		[CompilerGenerated]
		private ObservableCollection<ScenarioViewModel> observableCollection_0;

		// Token: 0x04003DF9 RID: 15865
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
