using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command
{
	// Token: 0x02000E39 RID: 3641
	[Attribute2]
	[DesignerGenerated]
	[Attribute3]
	[Attribute0]
	public sealed class ScoringGraphDataTooltip : UserControl, IComponentConnector, IChartTooltip
	{
		// Token: 0x06006D4E RID: 27982 RVA: 0x00044B88 File Offset: 0x00042D88
		public ScoringGraphDataTooltip()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06006D4F RID: 27983 RVA: 0x00044B96 File Offset: 0x00042D96
		// (set) Token: 0x06006D50 RID: 27984 RVA: 0x003BC15C File Offset: 0x003BA35C
		public TooltipData Data
		{
			get
			{
				return this.tooltipData_0;
			}
			set
			{
				if (this.tooltipData_0 == value)
				{
					return;
				}
				this.tooltipData_0 = value;
				this.method_0("Data");
				ScoringDatapointViewModel scoringDatapointViewModel = (ScoringDatapointViewModel)Enumerable.First<DataPointViewModel>(this.tooltipData_0.Points).ChartPoint.Instance;
				this.TB_2.Text = scoringDatapointViewModel.Reason;
				this.TB_1.Text = "Score: " + scoringDatapointViewModel.ScoreValue.ToString();
				this.TB_3.Text = scoringDatapointViewModel.DateTime.ToString();
			}
		}

		// Token: 0x06006D51 RID: 27985 RVA: 0x003BC1F4 File Offset: 0x003BA3F4
		private void method_0(string info)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(info));
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06006D52 RID: 27986 RVA: 0x00044B9E File Offset: 0x00042D9E
		// (set) Token: 0x06006D53 RID: 27987 RVA: 0x00044BA6 File Offset: 0x00042DA6
		public TooltipSelectionMode? SelectionMode
		{
			[CompilerGenerated]
			get
			{
				return this.nullable_0;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<TooltipSelectionMode>(this.nullable_0, value))
				{
					return;
				}
				this.nullable_0 = value;
				this.method_0("SelectionMode");
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06006D54 RID: 27988 RVA: 0x003BC218 File Offset: 0x003BA418
		// (remove) Token: 0x06006D55 RID: 27989 RVA: 0x003BC250 File Offset: 0x003BA450
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
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
			[CompilerGenerated]
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

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06006D56 RID: 27990 RVA: 0x00044BC9 File Offset: 0x00042DC9
		// (set) Token: 0x06006D57 RID: 27991 RVA: 0x00044BD1 File Offset: 0x00042DD1
		internal TextBlock TB_1
		{
			[CompilerGenerated]
			get
			{
				return this.textBlock_0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this.textBlock_0 == value)
				{
					return;
				}
				this.textBlock_0 = value;
				this.method_0("TB_1");
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06006D58 RID: 27992 RVA: 0x00044BF1 File Offset: 0x00042DF1
		// (set) Token: 0x06006D59 RID: 27993 RVA: 0x00044BF9 File Offset: 0x00042DF9
		internal TextBlock TB_2
		{
			[CompilerGenerated]
			get
			{
				return this.textBlock_1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this.textBlock_1 == value)
				{
					return;
				}
				this.textBlock_1 = value;
				this.method_0("TB_2");
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06006D5A RID: 27994 RVA: 0x00044C19 File Offset: 0x00042E19
		// (set) Token: 0x06006D5B RID: 27995 RVA: 0x00044C21 File Offset: 0x00042E21
		internal TextBlock TB_3
		{
			[CompilerGenerated]
			get
			{
				return this.textBlock_2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this.textBlock_2 == value)
				{
					return;
				}
				this.textBlock_2 = value;
				this.method_0("TB_3");
			}
		}

		// Token: 0x06006D5C RID: 27996 RVA: 0x003BC288 File Offset: 0x003BA488
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/scenario/scoringgraphdatatooltip.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x00044C41 File Offset: 0x00042E41
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.TB_1 = (TextBlock)target;
				return;
			}
			if (connectionId == 2)
			{
				this.TB_2 = (TextBlock)target;
				return;
			}
			if (connectionId == 3)
			{
				this.TB_3 = (TextBlock)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04003E44 RID: 15940
		private TooltipData tooltipData_0;

		// Token: 0x04003E45 RID: 15941
		[CompilerGenerated]
		private TooltipSelectionMode? nullable_0;

		// Token: 0x04003E46 RID: 15942
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x04003E47 RID: 15943
		[AccessedThroughProperty("TB_1")]
		[CompilerGenerated]
		private TextBlock textBlock_0;

		// Token: 0x04003E48 RID: 15944
		[AccessedThroughProperty("TB_2")]
		[CompilerGenerated]
		private TextBlock textBlock_1;

		// Token: 0x04003E49 RID: 15945
		[AccessedThroughProperty("TB_3")]
		[CompilerGenerated]
		private TextBlock textBlock_2;

		// Token: 0x04003E4A RID: 15946
		private bool bool_0;
	}
}
