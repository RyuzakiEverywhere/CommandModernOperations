using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace Command
{
	// Token: 0x02000D89 RID: 3465
	[DesignerGenerated]
	public sealed class RecentDetections_WPF : UserControl, IComponentConnector
	{
		// Token: 0x06005C72 RID: 23666 RVA: 0x0003B5C7 File Offset: 0x000397C7
		public RecentDetections_WPF()
		{
			this.observableCollection_0 = new ObservableCollection<RecentDetectionViewModel>();
			this.InitializeComponent();
		}

		// Token: 0x06005C73 RID: 23667 RVA: 0x0032D158 File Offset: 0x0032B358
		public void method_0(Contact contact_0, Scenario scenario_0)
		{
			try
			{
				this.observableCollection_0.Clear();
				if (contact_0 == null)
				{
					base.Visibility = Visibility.Collapsed;
				}
				else
				{
					if (contact_0.queue_0.Count > 0)
					{
						RecentDetections_WPF.Class2427 @class = new RecentDetections_WPF.Class2427(@class);
						int i = contact_0.queue_0.Count - 1;
						while (i >= 0)
						{
							try
							{
								@class.valueTuple_0 = Enumerable.ElementAtOrDefault<ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime>>(contact_0.queue_0, i);
							}
							catch (Exception ex)
							{
								goto IL_2BD;
							}
							goto IL_6B;
							IL_2BD:
							i += -1;
							continue;
							IL_6B:
							Sensor sensor = null;
							if (!string.IsNullOrEmpty(@class.valueTuple_0.Item1) && Client.smethod_46().vmethod_0().ContainsKey(@class.valueTuple_0.Item1))
							{
								ActiveUnit activeUnit = Client.smethod_46().vmethod_0()[@class.valueTuple_0.Item1];
								sensor = Enumerable.FirstOrDefault<Sensor>(Enumerable.Where<Sensor>(activeUnit.vmethod_96(), (@class.func_0 == null) ? (@class.func_0 = new Func<Sensor, bool>(@class.method_0)) : @class.func_0));
							}
							float item = @class.valueTuple_0.Item3;
							ActiveUnit_Sensory.Enum35 item2 = @class.valueTuple_0.Item4;
							DateTime item3 = @class.valueTuple_0.Item5;
							RecentDetectionViewModel recentDetectionViewModel = new RecentDetectionViewModel();
							if (sensor != null)
							{
								recentDetectionViewModel.SensorDBID = sensor.DBID;
								recentDetectionViewModel.SensorName = sensor.Name;
								ActiveUnit activeUnit = sensor.method_18();
								if (activeUnit != null)
								{
									recentDetectionViewModel.PlatformDBID = activeUnit.DBID;
									recentDetectionViewModel.PlatformName = activeUnit.Name;
									recentDetectionViewModel.PlatformGUID = activeUnit.string_0;
								}
							}
							else
							{
								recentDetectionViewModel.PlatformName = "[None]";
								recentDetectionViewModel.SensorName = "[None]";
								switch (item2)
								{
								case ActiveUnit_Sensory.Enum35.const_1:
									recentDetectionViewModel.SensorName = "POSSUB from torpedo detection";
									break;
								case ActiveUnit_Sensory.Enum35.const_2:
									recentDetectionViewModel.SensorName = "POSSUB from missile detection";
									break;
								case ActiveUnit_Sensory.Enum35.const_3:
									recentDetectionViewModel.SensorName = "POSSUB from torpedo detonation (flaming datum)";
									break;
								case ActiveUnit_Sensory.Enum35.const_4:
									recentDetectionViewModel.SensorName = "Automatic detection";
									break;
								}
							}
							if (contact_0.method_112() == null)
							{
								recentDetectionViewModel.DetectionRange_String = string.Format("{0:0.0}", item) + "nm";
							}
							else if (sensor != null)
							{
								recentDetectionViewModel.DetectionRange_String = "Estimated " + string.Format("{0:0.0}", sensor.method_18().method_36(contact_0)) + "nm";
							}
							else
							{
								recentDetectionViewModel.DetectionRange_String = "Unknown";
							}
							recentDetectionViewModel.DetectionRange_String = " - Range: " + recentDetectionViewModel.DetectionRange_String;
							recentDetectionViewModel.TimeSinceDetection_String = Misc.smethod_11((long)Math.Round((Client.smethod_46().method_31() - item3).TotalSeconds), Aircraft_AirOps.Enum44.const_0, false, true) + " ago ";
							if (item2 == ActiveUnit_Sensory.Enum35.const_4)
							{
								recentDetectionViewModel.TimeSinceDetection_String = null;
								recentDetectionViewModel.DetectionRange_String = null;
							}
							this.observableCollection_0.Add(recentDetectionViewModel);
							goto IL_2BD;
						}
					}
					base.DataContext = new AllRecentDetectionsViewModel
					{
						Items = this.observableCollection_0
					};
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005C74 RID: 23668 RVA: 0x0032D4B8 File Offset: 0x0032B6B8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/customcontrols/rightcolumn/recentdetections_wpf.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06005C75 RID: 23669 RVA: 0x0003B5E0 File Offset: 0x000397E0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x040035E4 RID: 13796
		private ObservableCollection<RecentDetectionViewModel> observableCollection_0;

		// Token: 0x040035E5 RID: 13797
		private bool bool_0;

		// Token: 0x02000D8A RID: 3466
		[CompilerGenerated]
		internal sealed class Class2427
		{
			// Token: 0x06005C76 RID: 23670 RVA: 0x0003B5E9 File Offset: 0x000397E9
			public Class2427(RecentDetections_WPF.Class2427 class2427_0)
			{
				if (class2427_0 != null)
				{
					this.valueTuple_0 = class2427_0.valueTuple_0;
				}
			}

			// Token: 0x06005C77 RID: 23671 RVA: 0x0003B600 File Offset: 0x00039800
			internal bool method_0(Sensor sensor_0)
			{
				return Operators.CompareString(sensor_0.string_0, this.valueTuple_0.Item2, false) == 0;
			}

			// Token: 0x040035E6 RID: 13798
			public ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime> valueTuple_0;

			// Token: 0x040035E7 RID: 13799
			public Func<Sensor, bool> func_0;
		}
	}
}
