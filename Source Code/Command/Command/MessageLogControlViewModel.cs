using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using Command_Core;
using MathNet.Numerics.LinearAlgebra.Double;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns14;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000E4D RID: 3661
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class MessageLogControlViewModel : INotifyPropertyChanged
	{
		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06006EA1 RID: 28321 RVA: 0x00045D41 File Offset: 0x00043F41
		// (set) Token: 0x06006EA2 RID: 28322 RVA: 0x00045D49 File Offset: 0x00043F49
		public int MainFormLogWidth
		{
			[CompilerGenerated]
			get
			{
				return this.int_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_0 == value)
				{
					return;
				}
				this.int_0 = value;
				this.vmethod_0("MainFormLogWidth");
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06006EA3 RID: 28323 RVA: 0x00045D69 File Offset: 0x00043F69
		// (set) Token: 0x06006EA4 RID: 28324 RVA: 0x00045D71 File Offset: 0x00043F71
		public bool LogCollapsed
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.bool_0 == value)
				{
					return;
				}
				this.bool_0 = value;
				this.vmethod_0("LogCollapsed");
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06006EA5 RID: 28325 RVA: 0x00045D91 File Offset: 0x00043F91
		// (set) Token: 0x06006EA6 RID: 28326 RVA: 0x00045D99 File Offset: 0x00043F99
		public double LogCollapseButtonRotation
		{
			[CompilerGenerated]
			get
			{
				return this.double_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_0 == value)
				{
					return;
				}
				this.double_0 = value;
				this.vmethod_0("LogCollapseButtonRotation");
			}
		}

		// Token: 0x06006EA7 RID: 28327 RVA: 0x003BF268 File Offset: 0x003BD468
		public void method_0()
		{
			if (Class2413.smethod_2().method_41().vmethod_796().Width != this.int_1)
			{
				this.int_1 = Class2413.smethod_2().method_41().vmethod_796().Width;
				this.MainFormLogWidth = (int)Math.Round((double)Class2413.smethod_2().method_41().vmethod_796().Width / 3.0);
				Class2413.smethod_2().method_41().int_3 = (int)Math.Round((double)Class2413.smethod_2().method_41().vmethod_796().Width / 3.0);
				int mainFormLogWidth = this.MainFormLogWidth;
				int height = Class2413.smethod_2().method_41().vmethod_800().Height;
				Class2413.smethod_2().method_41().vmethod_800().MaximumSize = new System.Drawing.Size(mainFormLogWidth, height);
				Class2413.smethod_2().method_41().vmethod_800().MinimumSize = new System.Drawing.Size(mainFormLogWidth, height);
				Class2413.smethod_2().method_41().vmethod_800().Size = new System.Drawing.Size(mainFormLogWidth, height);
			}
			this.method_3();
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x00045DBC File Offset: 0x00043FBC
		public void method_1()
		{
			this.SummaryItems.Clear();
			this.Balloons.Clear();
		}

		// Token: 0x06006EA9 RID: 28329 RVA: 0x00045DD4 File Offset: 0x00043FD4
		public void method_2()
		{
			this.long_0 = 0L;
			this.SummaryItems.Clear();
			this.Balloons.Clear();
		}

		// Token: 0x06006EAA RID: 28330 RVA: 0x003BF380 File Offset: 0x003BD580
		public void method_3()
		{
			if (this.dispatcherTimer_0 == null)
			{
				this.dispatcherTimer_0 = new DispatcherTimer();
				this.dispatcherTimer_0.Tick += this.dispatcherTimer_0_Tick;
				this.dispatcherTimer_0.Interval = new TimeSpan(0, 0, 0, 0, 100);
				this.dispatcherTimer_0.Start();
			}
			if (Client.smethod_50() != null)
			{
				LoggedMessage[] array = Enumerable.ToArray<LoggedMessage>(Enumerable.Where<LoggedMessage>(Client.smethod_50().method_55(Client.smethod_46()), new Func<LoggedMessage, bool>(this.method_8)));
				if (Enumerable.Count<LoggedMessage>(array) != 0)
				{
					this.long_0 = Enumerable.Max<LoggedMessage>(array, (MessageLogControlViewModel._Closure$__.$I18-1 == null) ? (MessageLogControlViewModel._Closure$__.$I18-1 = new Func<LoggedMessage, long>(MessageLogControlViewModel._Closure$__.$I.method_0)) : MessageLogControlViewModel._Closure$__.$I18-1);
					foreach (LoggedMessage theM in array)
					{
						this.method_4(theM);
					}
					this.SummaryItems = new ObservableCollection<MLSummaryViewModel>(Enumerable.OrderByDescending<MLSummaryViewModel, DateTime>(this.SummaryItems, (MessageLogControlViewModel._Closure$__.$I18-2 == null) ? (MessageLogControlViewModel._Closure$__.$I18-2 = new Func<MLSummaryViewModel, DateTime>(MessageLogControlViewModel._Closure$__.$I.method_1)) : MessageLogControlViewModel._Closure$__.$I18-2));
				}
			}
		}

		// Token: 0x06006EAB RID: 28331 RVA: 0x003BF498 File Offset: 0x003BD698
		public static void smethod_0(MLBalloonViewModel theB)
		{
			try
			{
				DenseVector denseVector = new DenseVector(2);
				System.Drawing.Point point = Class2572.smethod_0(Class2413.smethod_2().method_41().vmethod_796(), theB.Lat, theB.Lon);
				denseVector[0] = (double)point.X;
				denseVector[1] = (double)point.Y;
				DenseVector denseVector2 = new DenseVector(2);
				denseVector2[0] = theB.Radius * Math.Cos(theB.Theta);
				denseVector2[1] = theB.Radius * Math.Sin(theB.Theta);
				DenseVector denseVector3 = new DenseVector(2);
				denseVector3[0] = theB.ObservedWidth / 2.0;
				denseVector3[1] = theB.ObservedHeight / 2.0;
				DenseVector denseVector4 = denseVector - denseVector3 - denseVector2;
				theB.CanvasLeft = denseVector4[0];
				theB.CanvasTop = denseVector4[1];
				DenseVector denseVector5 = new DenseVector(2);
				DenseVector denseVector6 = denseVector4 + denseVector3;
				denseVector5[0] = Math.Min(denseVector6[0], (denseVector6 + denseVector2)[0]);
				denseVector5[1] = Math.Min(denseVector6[1], (denseVector6 + denseVector2)[1]);
				if (denseVector2[0] < 0.0)
				{
					if (denseVector2[1] < 0.0)
					{
						theB.X1 = 0.0;
						theB.Y1 = 0.0;
						theB.X2 = denseVector2[0];
						theB.Y2 = denseVector2[1];
						theB.StemCanvasLeft = denseVector5[0] - denseVector2[0];
						theB.StemCanvasTop = denseVector5[1] - denseVector2[1];
					}
					else
					{
						theB.X1 = denseVector2[0];
						theB.Y1 = denseVector2[1];
						theB.X2 = 0.0;
						theB.Y2 = 0.0;
						theB.StemCanvasLeft = denseVector5[0] - denseVector2[0];
						theB.StemCanvasTop = denseVector5[1];
					}
				}
				else if (denseVector2[1] < 0.0)
				{
					theB.X1 = 0.0;
					theB.Y1 = 0.0;
					theB.X2 = denseVector2[0];
					theB.Y2 = denseVector2[1];
					theB.StemCanvasLeft = denseVector5[0];
					theB.StemCanvasTop = denseVector5[1] - denseVector2[1];
				}
				else
				{
					theB.X1 = 0.0;
					theB.Y1 = 0.0;
					theB.X2 = denseVector2[0];
					theB.Y2 = denseVector2[1];
					theB.StemCanvasLeft = denseVector5[0];
					theB.StemCanvasTop = denseVector5[1];
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06006EAC RID: 28332 RVA: 0x003BF7B8 File Offset: 0x003BD9B8
		private void dispatcherTimer_0_Tick(object sender, EventArgs e)
		{
			foreach (MLBalloonViewModel mlballoonViewModel in Enumerable.ToArray<MLBalloonViewModel>(this.Balloons))
			{
				if (!mlballoonViewModel.Hover)
				{
					mlballoonViewModel.Opacity -= (DateTime.Now - this.dateTime_0).TotalSeconds;
				}
				if (mlballoonViewModel.Opacity < 0.0)
				{
					this.Balloons.Remove(mlballoonViewModel);
				}
			}
			try
			{
				foreach (MLSummaryViewModel mlsummaryViewModel in this.SummaryItems)
				{
					if (mlsummaryViewModel.Expanded)
					{
						try
						{
							foreach (MLDetailViewModel mldetailViewModel in mlsummaryViewModel.Details)
							{
								mldetailViewModel.Read = true;
							}
						}
						finally
						{
							IEnumerator<MLDetailViewModel> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						mlsummaryViewModel.Header = mlsummaryViewModel.Summary;
					}
					else
					{
						int num = 0;
						try
						{
							IEnumerator<MLDetailViewModel> enumerator3 = mlsummaryViewModel.Details.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								if (!enumerator3.Current.Read)
								{
									num++;
								}
							}
						}
						finally
						{
							IEnumerator<MLDetailViewModel> enumerator3;
							if (enumerator3 != null)
							{
								enumerator3.Dispose();
							}
						}
						mlsummaryViewModel.Header = mlsummaryViewModel.Summary + string.Format(" ({0})", num);
					}
				}
			}
			finally
			{
				IEnumerator<MLSummaryViewModel> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.dateTime_0 = DateTime.Now;
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x003BF948 File Offset: 0x003BDB48
		public MessageLogControlViewModel()
		{
			this.MainFormLogWidth = 400;
			this.long_0 = 0L;
			this.dispatcherTimer_0 = null;
			this.LogCollapsed = false;
			this.LogCollapseButtonRotation = 0.0;
			this.int_1 = -1;
			this.dateTime_0 = DateTime.Now;
			this.SummaryItems = new ObservableCollection<MLSummaryViewModel>();
			this.Balloons = new ObservableCollection<MLBalloonViewModel>();
			this.random_0 = new Random();
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x003BF9C8 File Offset: 0x003BDBC8
		public static string smethod_1(LoggedMessage.MessageType theMessageType)
		{
			switch (theMessageType)
			{
			case LoggedMessage.MessageType.NewContact:
				return "New Contact";
			case LoggedMessage.MessageType.ContactChange:
				return "Contact Change";
			case LoggedMessage.MessageType.WeaponEndgame:
				return "Weapon Endgame";
			case LoggedMessage.MessageType.WeaponDamage:
				return "Weapon Damage";
			case LoggedMessage.MessageType.AirOps:
				return "Air Ops";
			case LoggedMessage.MessageType.UnitLost:
				return "UNIT LOST";
			case LoggedMessage.MessageType.UnitDamage:
				return "Damage";
			case LoggedMessage.MessageType.PointDefence:
				return "Point Defence";
			case LoggedMessage.MessageType.WeaponLogic:
				return "Weapon Logic";
			case LoggedMessage.MessageType.UnitAI:
				return "Crew AI";
			case LoggedMessage.MessageType.EventEngine:
				return "Event";
			case LoggedMessage.MessageType.NewWeaponContact:
				return "New Weapon Contact";
			case LoggedMessage.MessageType.DockingOps:
				return "Docking Ops";
			case LoggedMessage.MessageType.NewMineContact:
				return "New Mine Contact";
			case LoggedMessage.MessageType.CommsIsolatedMessage:
				return "Comms Isolation";
			case LoggedMessage.MessageType.NewAirContact:
				return "New Air Contact";
			case LoggedMessage.MessageType.NewSurfaceContact:
				return "New Surface Contact";
			case LoggedMessage.MessageType.NewUnderwaterContact:
				return "New Underwater Contact";
			case LoggedMessage.MessageType.NewGroundContact:
				return "New Ground Contact";
			case LoggedMessage.MessageType.UnguidedWeaponModifiers:
				return "Unguided Weapon";
			}
			return "Event";
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x003BFAF0 File Offset: 0x003BDCF0
		private void method_4(LoggedMessage theM)
		{
			MessageLogControlViewModel.Class2470 @class = new MessageLogControlViewModel.Class2470();
			@class.loggedMessage_0 = theM;
			try
			{
				if (string.IsNullOrEmpty(@class.loggedMessage_0.string_4))
				{
					@class.loggedMessage_0.string_4 = "Log element lacking summary!";
				}
				MLSummaryViewModel mlsummaryViewModel = Enumerable.FirstOrDefault<MLSummaryViewModel>(this.SummaryItems, new Func<MLSummaryViewModel, bool>(@class.method_0));
				System.Drawing.Color color = @class.loggedMessage_0.method_8();
				MLDetailViewModel mldetailViewModel = new MLDetailViewModel();
				MLDetailViewModel mldetailViewModel2 = mldetailViewModel;
				mldetailViewModel2.LongText = Class441.smethod_1(@class.loggedMessage_0.string_2);
				mldetailViewModel2.Summary = Class441.smethod_1(@class.loggedMessage_0.string_4);
				mldetailViewModel2.Text = Class441.smethod_1(@class.loggedMessage_0.string_4);
				mldetailViewModel2.PlusVisibility = Visibility.Visible;
				mldetailViewModel2.Expanded = false;
				mldetailViewModel2.Timestamp = @class.loggedMessage_0.dateTime_0;
				if (@class.loggedMessage_0.nullable_0 != null)
				{
					mldetailViewModel2.Lat = @class.loggedMessage_0.nullable_0.Value.double_1;
					mldetailViewModel2.Lon = @class.loggedMessage_0.nullable_0.Value.double_0;
				}
				mldetailViewModel2.LoggedMessage = @class.loggedMessage_0;
				mldetailViewModel2.Brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B));
				mldetailViewModel2.Read = false;
				if (mlsummaryViewModel == null)
				{
					mlsummaryViewModel = new MLSummaryViewModel
					{
						Header = MessageLogControlViewModel.smethod_1(@class.loggedMessage_0.messageType_0),
						Summary = MessageLogControlViewModel.smethod_1(@class.loggedMessage_0.messageType_0)
					};
					this.SummaryItems.Add(mlsummaryViewModel);
				}
				this.SummaryItems = new ObservableCollection<MLSummaryViewModel>(Enumerable.OrderByDescending<MLSummaryViewModel, DateTime>(this.SummaryItems, (MessageLogControlViewModel._Closure$__.$I24-1 == null) ? (MessageLogControlViewModel._Closure$__.$I24-1 = new Func<MLSummaryViewModel, DateTime>(MessageLogControlViewModel._Closure$__.$I.method_2)) : MessageLogControlViewModel._Closure$__.$I24-1));
				mlsummaryViewModel.Details.Add(mldetailViewModel);
				mlsummaryViewModel.Details = new ObservableCollection<MLDetailViewModel>(Enumerable.OrderByDescending<MLDetailViewModel, DateTime>(mlsummaryViewModel.Details, (MessageLogControlViewModel._Closure$__.$I24-2 == null) ? (MessageLogControlViewModel._Closure$__.$I24-2 = new Func<MLDetailViewModel, DateTime>(MessageLogControlViewModel._Closure$__.$I.method_3)) : MessageLogControlViewModel._Closure$__.$I24-2));
				mlsummaryViewModel.Timestamp = mldetailViewModel.Timestamp;
				if (!string.IsNullOrEmpty(@class.loggedMessage_0.string_4) && Class570.class280_0.dictionary_0[@class.loggedMessage_0.messageType_0].bool_2)
				{
					this.method_5(mldetailViewModel);
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06006EB0 RID: 28336 RVA: 0x00045DFB File Offset: 0x00043FFB
		// (set) Token: 0x06006EB1 RID: 28337 RVA: 0x00045E03 File Offset: 0x00044003
		public ObservableCollection<MLSummaryViewModel> SummaryItems
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
				this.vmethod_0("SummaryItems");
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06006EB2 RID: 28338 RVA: 0x00045E23 File Offset: 0x00044023
		// (set) Token: 0x06006EB3 RID: 28339 RVA: 0x00045E2B File Offset: 0x0004402B
		public ObservableCollection<MLBalloonViewModel> Balloons
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_1 == value)
				{
					return;
				}
				this.observableCollection_1 = value;
				this.vmethod_0("Balloons");
			}
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x003BFD90 File Offset: 0x003BDF90
		public MLBalloonViewModel method_5(MLDetailViewModel theDetails)
		{
			MessageLogControlViewModel.Class2471 @class = new MessageLogControlViewModel.Class2471();
			@class.mldetailViewModel_0 = theDetails;
			MLBalloonViewModel result;
			if (Enumerable.Any<MLBalloonViewModel>(this.Balloons, new Func<MLBalloonViewModel, bool>(@class.method_0)))
			{
				result = null;
			}
			else
			{
				System.Drawing.Color color = @class.mldetailViewModel_0.LoggedMessage.method_8();
				@class.mlballoonViewModel_0 = new MLBalloonViewModel();
				@class.mlballoonViewModel_0.Text = MessageLogControlViewModel.smethod_1(@class.mldetailViewModel_0.LoggedMessage.messageType_0);
				@class.mlballoonViewModel_0.Lon = @class.mldetailViewModel_0.Lon;
				Class2572.smethod_0(Class2413.smethod_2().method_41().vmethod_796(), @class.mldetailViewModel_0.Lat, @class.mldetailViewModel_0.Lon);
				@class.mlballoonViewModel_0.Lat = @class.mldetailViewModel_0.Lat;
				@class.mlballoonViewModel_0.Tag = @class.mldetailViewModel_0;
				@class.mlballoonViewModel_0.Opacity = 5.0;
				@class.mlballoonViewModel_0.Summary = Class441.smethod_1(@class.mldetailViewModel_0.Summary);
				@class.mlballoonViewModel_0.Color = color;
				@class.mlballoonViewModel_0.Radius = 100.0 + this.random_0.NextDouble() * 50.0;
				@class.mlballoonViewModel_0.Theta = this.random_0.NextDouble() * 3.141592653589793 * 2.0;
				this.Balloons.Add(@class.mlballoonViewModel_0);
				Dispatcher.CurrentDispatcher.Invoke(new VB$AnonymousDelegate_0(@class.method_1), new object[0]);
				result = @class.mlballoonViewModel_0;
			}
			return result;
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x00045E4B File Offset: 0x0004404B
		internal void method_6()
		{
			this.method_1();
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x00045E53 File Offset: 0x00044053
		internal void method_7()
		{
			this.method_2();
		}

		// Token: 0x06006EB7 RID: 28343 RVA: 0x00045E5B File Offset: 0x0004405B
		[CompilerGenerated]
		private bool method_8(LoggedMessage theM)
		{
			return theM.long_0 > this.long_0;
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06006EB8 RID: 28344 RVA: 0x003BFF34 File Offset: 0x003BE134
		// (remove) Token: 0x06006EB9 RID: 28345 RVA: 0x003BFF6C File Offset: 0x003BE16C
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

		// Token: 0x06006EBA RID: 28346 RVA: 0x003BFFA4 File Offset: 0x003BE1A4
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003ED9 RID: 16089
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003EDA RID: 16090
		public long long_0;

		// Token: 0x04003EDB RID: 16091
		private DispatcherTimer dispatcherTimer_0;

		// Token: 0x04003EDC RID: 16092
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003EDD RID: 16093
		[CompilerGenerated]
		private double double_0;

		// Token: 0x04003EDE RID: 16094
		private int int_1;

		// Token: 0x04003EDF RID: 16095
		private DateTime dateTime_0;

		// Token: 0x04003EE0 RID: 16096
		[CompilerGenerated]
		private ObservableCollection<MLSummaryViewModel> observableCollection_0;

		// Token: 0x04003EE1 RID: 16097
		[CompilerGenerated]
		private ObservableCollection<MLBalloonViewModel> observableCollection_1;

		// Token: 0x04003EE2 RID: 16098
		private readonly Random random_0;

		// Token: 0x04003EE3 RID: 16099
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000E4F RID: 3663
		[CompilerGenerated]
		internal sealed class Class2470
		{
			// Token: 0x06006EC2 RID: 28354 RVA: 0x00045E87 File Offset: 0x00044087
			internal bool method_0(MLSummaryViewModel MLSVM)
			{
				return Operators.CompareString(MLSVM.Summary, MessageLogControlViewModel.smethod_1(this.loggedMessage_0.messageType_0), false) == 0;
			}

			// Token: 0x04003EE9 RID: 16105
			public LoggedMessage loggedMessage_0;
		}

		// Token: 0x02000E50 RID: 3664
		[CompilerGenerated]
		internal sealed class Class2471
		{
			// Token: 0x06006EC4 RID: 28356 RVA: 0x00045EA8 File Offset: 0x000440A8
			internal bool method_0(MLBalloonViewModel F)
			{
				return ((MLDetailViewModel)F.Tag).LoggedMessage == this.mldetailViewModel_0.LoggedMessage;
			}

			// Token: 0x06006EC5 RID: 28357 RVA: 0x003BFFCC File Offset: 0x003BE1CC
			internal void method_1()
			{
				Class2449 @class = new Class2449();
				Class2449 class2 = @class;
				class2.int_0 = (int)Math.Round(this.mlballoonViewModel_0.CanvasLeft);
				class2.int_1 = (int)Math.Round(this.mlballoonViewModel_0.CanvasTop);
				class2.int_2 = (int)Math.Round(this.mlballoonViewModel_0.StemCanvasLeft);
				class2.int_3 = (int)Math.Round(this.mlballoonViewModel_0.StemCanvasTop);
				class2.int_4 = (int)Math.Round(this.mlballoonViewModel_0.ObservedHeight);
				class2.int_5 = (int)Math.Round(this.mlballoonViewModel_0.ObservedWidth);
				class2.string_0 = this.mlballoonViewModel_0.Text;
				class2.string_1 = this.mlballoonViewModel_0.Summary;
				class2.Tag = RuntimeHelpers.GetObjectValue(this.mlballoonViewModel_0.Tag);
				class2.double_0 = this.mlballoonViewModel_0.Lat;
				class2.double_1 = this.mlballoonViewModel_0.Lon;
				class2.double_2 = this.mlballoonViewModel_0.Opacity;
				class2.bool_0 = this.mlballoonViewModel_0.Hover;
				class2.color_0 = this.mlballoonViewModel_0.Color;
				class2.double_3 = this.mlballoonViewModel_0.X1;
				class2.double_4 = this.mlballoonViewModel_0.X2;
				class2.double_5 = this.mlballoonViewModel_0.Y1;
				class2.double_6 = this.mlballoonViewModel_0.Y2;
				class2.double_7 = this.mlballoonViewModel_0.Radius;
				class2.double_8 = this.mlballoonViewModel_0.Theta;
				Class2413.smethod_2().method_41().list_49.Add(@class);
				Class2413.smethod_2().method_41().method_106(5.0);
			}

			// Token: 0x04003EEA RID: 16106
			public MLDetailViewModel mldetailViewModel_0;

			// Token: 0x04003EEB RID: 16107
			public MLBalloonViewModel mlballoonViewModel_0;
		}
	}
}
