using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000E08 RID: 3592
	[Attribute11]
	[Attribute12]
	[Attribute13]
	public sealed class ScenarioMinimapViewModel : INotifyPropertyChanged
	{
		// Token: 0x060068C9 RID: 26825 RVA: 0x0038BEF4 File Offset: 0x0038A0F4
		public ScenarioMinimapViewModel()
		{
			this.double_0 = 0.0;
			this.double_1 = 0.0;
			this.double_2 = 0.0;
			this.double_3 = 0.0;
			this.double_4 = 0.0;
			this.double_5 = 0.0;
			this.double_6 = 0.0;
			this.double_7 = 0.0;
			this.double_8 = 0.0;
			this.double_9 = 0.0;
			this.double_10 = 0.0;
			this.double_11 = 0.0;
			this.double_12 = 0.0;
			this.double_13 = 0.0;
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060068CA RID: 26826 RVA: 0x000429C5 File Offset: 0x00040BC5
		// (set) Token: 0x060068CB RID: 26827 RVA: 0x000429CD File Offset: 0x00040BCD
		public WriteableBitmap BITMAP_terrain
		{
			[CompilerGenerated]
			get
			{
				return this.writeableBitmap_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.writeableBitmap_0 == value)
				{
					return;
				}
				this.writeableBitmap_0 = value;
				this.vmethod_0("BITMAP_terrain");
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060068CC RID: 26828 RVA: 0x000429ED File Offset: 0x00040BED
		// (set) Token: 0x060068CD RID: 26829 RVA: 0x000429F5 File Offset: 0x00040BF5
		public WriteableBitmap BITMAP_units
		{
			[CompilerGenerated]
			get
			{
				return this.writeableBitmap_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.writeableBitmap_1 == value)
				{
					return;
				}
				this.writeableBitmap_1 = value;
				this.vmethod_0("BITMAP_units");
			}
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x0038BFDC File Offset: 0x0038A1DC
		private bool method_0(ref double GridHeight, ref double GridWidth, ref double CentroidLat, ref double CentroidLon, ref double MinCentroidRelativeLat, ref double MaxCentroidRelativeLat, ref double MinCentroidRelativeLon, ref double MaxCentroidRelativeLon, ref double SizeLat, ref double SizeLon)
		{
			ScenarioMinimapViewModel.Class2458 @class = new ScenarioMinimapViewModel.Class2458(@class);
			@class.scenarioMinimapViewModel_0 = this;
			MinCentroidRelativeLat = double.MaxValue;
			MaxCentroidRelativeLat = double.MinValue;
			MinCentroidRelativeLon = double.MaxValue;
			MaxCentroidRelativeLon = double.MinValue;
			@class.double_0 = 0.0;
			@class.double_1 = 0.0;
			this.dispatcher_0.Invoke(new VB$AnonymousDelegate_0(@class.method_0), new object[0]);
			GridWidth = @class.double_0;
			GridHeight = @class.double_1;
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().method_42(), (ScenarioMinimapViewModel._Closure$__.$I11-1 == null) ? (ScenarioMinimapViewModel._Closure$__.$I11-1 = new Func<ActiveUnit, bool>(ScenarioMinimapViewModel._Closure$__.$I.method_0)) : ScenarioMinimapViewModel._Closure$__.$I11-1));
			bool result;
			if (list.Count < 2)
			{
				result = false;
			}
			else
			{
				double num4 = 1.0 / (double)list.Count;
				try
				{
					foreach (ActiveUnit activeUnit in list)
					{
						double num5 = 1.0 * Math.Cos(activeUnit.vmethod_28(null) * 3.141592653589793 / 180.0) * Math.Cos(activeUnit.vmethod_30(null) * 3.141592653589793 / 180.0);
						double num6 = 1.0 * Math.Sin(activeUnit.vmethod_28(null) * 3.141592653589793 / 180.0) * Math.Cos(activeUnit.vmethod_30(null) * 3.141592653589793 / 180.0);
						double num7 = 1.0 * Math.Sin(activeUnit.vmethod_30(null) * 3.141592653589793 / 180.0);
						num += num5 * num4;
						num2 += num6 * num4;
						num3 += num7 * num4;
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				@class.vb$AnonymousDelegate_2_0 = ((ScenarioMinimapViewModel._Closure$__.$I11-2 == null) ? (ScenarioMinimapViewModel._Closure$__.$I11-2 = new VB$AnonymousDelegate_2<object, object>(ScenarioMinimapViewModel._Closure$__.$I.method_1)) : ScenarioMinimapViewModel._Closure$__.$I11-2);
				CentroidLon = Math.Atan2(num2, num);
				CentroidLat = 1.5707963267948966 - Math.Acos(num3);
				MinCentroidRelativeLat = double.MaxValue;
				MaxCentroidRelativeLat = double.MinValue;
				MinCentroidRelativeLon = double.MaxValue;
				MaxCentroidRelativeLon = double.MinValue;
				@class.double_2 = CentroidLat;
				@class.double_3 = CentroidLon;
				List<Tuple<double, double>> list2 = Enumerable.ToList<Tuple<double, double>>(Enumerable.Select<ActiveUnit, Tuple<double, double>>(list, new Func<ActiveUnit, Tuple<double, double>>(@class.method_1)));
				try
				{
					foreach (Tuple<double, double> tuple in list2)
					{
						MinCentroidRelativeLat = Math.Min(MinCentroidRelativeLat, tuple.Item1);
						MaxCentroidRelativeLat = Math.Max(MaxCentroidRelativeLat, tuple.Item1);
						MinCentroidRelativeLon = Math.Min(MinCentroidRelativeLon, tuple.Item2);
						MaxCentroidRelativeLon = Math.Max(MaxCentroidRelativeLon, tuple.Item2);
					}
				}
				finally
				{
					List<Tuple<double, double>>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				double num8 = MaxCentroidRelativeLat - MinCentroidRelativeLat;
				double num9 = MaxCentroidRelativeLon - MinCentroidRelativeLon;
				MinCentroidRelativeLat -= num8 * 0.1;
				MaxCentroidRelativeLat += num8 * 0.1;
				MinCentroidRelativeLon -= num9 * 0.1;
				MaxCentroidRelativeLon += num9 * 0.1;
				SizeLat = MaxCentroidRelativeLat - MinCentroidRelativeLat;
				SizeLon = MaxCentroidRelativeLon - MinCentroidRelativeLon;
				this.double_0 = MinCentroidRelativeLat;
				this.double_1 = MinCentroidRelativeLon;
				this.double_2 = GridWidth;
				this.double_3 = GridHeight;
				this.double_4 = SizeLat;
				this.double_5 = SizeLon;
				this.double_6 = CentroidLat;
				this.double_7 = CentroidLon;
				result = true;
			}
			return result;
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x0038C43C File Offset: 0x0038A63C
		public void method_1()
		{
			ScenarioMinimapViewModel.Class2459 @class = new ScenarioMinimapViewModel.Class2459(@class);
			@class.scenarioMinimapViewModel_0 = this;
			@class.double_0 = 0.0;
			@class.double_1 = 0.0;
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			double num5;
			double num6;
			double num7;
			double num8;
			if (this.method_0(ref @class.double_1, ref @class.double_0, ref num4, ref num3, ref num5, ref num6, ref num7, ref num8, ref num, ref num2) && (this.double_8 != num5 || this.double_9 != num7 || this.double_10 != @class.double_0 || this.double_11 != @class.double_1 || this.double_12 != num || this.double_13 != num2))
			{
				this.double_8 = num5;
				this.double_9 = num7;
				this.double_10 = @class.double_0;
				this.double_11 = @class.double_1;
				this.double_12 = num;
				this.double_13 = num2;
				@class.uint_0 = new uint[(int)Math.Round(@class.double_1 * @class.double_0) + 1];
				int num9 = (int)Math.Round(@class.double_0 - 1.0);
				for (int i = 0; i <= num9; i++)
				{
					Thread.Sleep(1);
					int num10 = (int)Math.Round(@class.double_1 - 1.0);
					for (int j = 0; j <= num10; j++)
					{
						int num11 = (int)Math.Round(@class.double_0 * (double)j + (double)i);
						double num12 = num5 + (@class.double_1 - (double)j) * (num / @class.double_1);
						double num13 = num7 + (double)i * (num2 / @class.double_0);
						double num14 = num12 + num4;
						double num15 = num13 + num3;
						double num16 = num14 * 180.0 / 3.141592653589793;
						double num17 = num15 * 180.0 / 3.141592653589793;
						int num18 = (int)Terrain.smethod_7(num16, num17, false);
						uint num19 = 0U;
						uint num20 = 0U;
						uint num21 = 0U;
						uint num22 = 255U;
						if (num18 > 0)
						{
							num20 = 64U;
						}
						else
						{
							num21 = 64U;
						}
						@class.uint_0[num11] = (num22 << 24) + (num19 << 16) + (num20 << 8) + num21;
					}
				}
				this.dispatcher_0.Invoke(new VB$AnonymousDelegate_0(@class.method_0), new object[0]);
			}
		}

		// Token: 0x060068D0 RID: 26832 RVA: 0x0038C6A8 File Offset: 0x0038A8A8
		public void method_2()
		{
			ScenarioMinimapViewModel.Class2460 @class = new ScenarioMinimapViewModel.Class2460(@class);
			@class.scenarioMinimapViewModel_0 = this;
			@class.double_0 = 0.0;
			@class.double_1 = 0.0;
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			double num5;
			double num6;
			double num7;
			double num8;
			if (this.method_0(ref @class.double_1, ref @class.double_0, ref num4, ref num3, ref num5, ref num6, ref num7, ref num8, ref num, ref num2))
			{
				@class.uint_0 = new uint[(int)Math.Round(@class.double_1 * @class.double_0) + 1];
				@class.uint_1 = 0U;
				@class.uint_2 = 0U;
				@class.uint_3 = 0U;
				@class.uint_4 = 0U;
				Delegate76<object, object, object> @delegate = new Delegate76<object, object, object>(@class.method_0);
				foreach (ActiveUnit activeUnit in Client.smethod_50().activeUnit_0)
				{
					Thread.Sleep(1);
					double num9 = activeUnit.vmethod_30(null) * 3.141592653589793 / 180.0;
					double num10 = activeUnit.vmethod_28(null) * 3.141592653589793 / 180.0;
					double a = -((num9 - num4 - num5) * @class.double_1) / num + @class.double_1;
					double a2 = (num10 - num3 - num7) * (@class.double_0 / num2);
					int num11 = (int)Math.Round(a);
					int num12 = (int)Math.Round(a2);
					@class.uint_2 = 0U;
					@class.uint_3 = 0U;
					@class.uint_4 = 255U;
					@class.uint_1 = 255U;
					@delegate(num12, num11, 1);
				}
				foreach (Side side in Client.smethod_46().method_44())
				{
					if (side != Client.smethod_50() && side.method_67(Client.smethod_50()) && Client.smethod_50().method_67(side))
					{
						Thread.Sleep(1);
						foreach (ActiveUnit activeUnit2 in side.activeUnit_0)
						{
							Thread.Sleep(1);
							double num13 = activeUnit2.vmethod_30(null) * 3.141592653589793 / 180.0;
							double num14 = activeUnit2.vmethod_28(null) * 3.141592653589793 / 180.0;
							double a3 = -((num13 - num4 - num5) * @class.double_1) / num + @class.double_1;
							double a4 = (num14 - num3 - num7) * (@class.double_0 / num2);
							int num15 = (int)Math.Round(a3);
							int num16 = (int)Math.Round(a4);
							@class.uint_2 = 0U;
							@class.uint_3 = 0U;
							@class.uint_4 = 255U;
							@class.uint_1 = 255U;
							@delegate(num16, num15, 1);
						}
					}
				}
				try
				{
					foreach (Contact contact in Client.smethod_50().method_44())
					{
						Thread.Sleep(1);
						System.Drawing.Color color = Client.smethod_29(contact.method_130(Client.smethod_50()));
						double num17 = contact.vmethod_30(null) * 3.141592653589793 / 180.0;
						double num18 = contact.vmethod_28(null) * 3.141592653589793 / 180.0;
						double a5 = -((num17 - num4 - num5) * @class.double_1) / num + @class.double_1;
						double a6 = (num18 - num3 - num7) * (@class.double_0 / num2);
						int num19 = (int)Math.Round(a5);
						int num20 = (int)Math.Round(a6);
						@class.uint_2 = (uint)color.R;
						@class.uint_3 = (uint)color.G;
						@class.uint_4 = (uint)color.B;
						@class.uint_1 = 255U;
						@delegate(num20, num19, 1);
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.dispatcher_0.Invoke(new VB$AnonymousDelegate_0(@class.method_1), new object[0]);
			}
		}

		// Token: 0x060068D1 RID: 26833 RVA: 0x0038CB24 File Offset: 0x0038AD24
		public void method_3(int xprime, int yprime)
		{
			double num = this.double_0 + (this.double_3 - (double)yprime) * (this.double_4 / this.double_3);
			double num2 = this.double_1 + (double)xprime * (this.double_5 / this.double_2);
			double num3 = num + this.double_6;
			double num4 = num2 + this.double_7;
			double num5 = num3 * 180.0 / 3.141592653589793;
			double num6 = num4 * 180.0 / 3.141592653589793;
			Class2413.smethod_2().method_41().method_161(true, new GeoPoint(num6, num5));
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x060068D2 RID: 26834 RVA: 0x0038CBBC File Offset: 0x0038ADBC
		// (remove) Token: 0x060068D3 RID: 26835 RVA: 0x0038CBF4 File Offset: 0x0038ADF4
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

		// Token: 0x060068D4 RID: 26836 RVA: 0x0038CC2C File Offset: 0x0038AE2C
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003BA4 RID: 15268
		[CompilerGenerated]
		private WriteableBitmap writeableBitmap_0;

		// Token: 0x04003BA5 RID: 15269
		[CompilerGenerated]
		private WriteableBitmap writeableBitmap_1;

		// Token: 0x04003BA6 RID: 15270
		public Dispatcher dispatcher_0;

		// Token: 0x04003BA7 RID: 15271
		public Grid grid_0;

		// Token: 0x04003BA8 RID: 15272
		private double double_0;

		// Token: 0x04003BA9 RID: 15273
		private double double_1;

		// Token: 0x04003BAA RID: 15274
		private double double_2;

		// Token: 0x04003BAB RID: 15275
		private double double_3;

		// Token: 0x04003BAC RID: 15276
		private double double_4;

		// Token: 0x04003BAD RID: 15277
		private double double_5;

		// Token: 0x04003BAE RID: 15278
		private double double_6;

		// Token: 0x04003BAF RID: 15279
		private double double_7;

		// Token: 0x04003BB0 RID: 15280
		private double double_8;

		// Token: 0x04003BB1 RID: 15281
		private double double_9;

		// Token: 0x04003BB2 RID: 15282
		private double double_10;

		// Token: 0x04003BB3 RID: 15283
		private double double_11;

		// Token: 0x04003BB4 RID: 15284
		private double double_12;

		// Token: 0x04003BB5 RID: 15285
		private double double_13;

		// Token: 0x04003BB6 RID: 15286
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000E09 RID: 3593
		[CompilerGenerated]
		internal sealed class Class2458
		{
			// Token: 0x060068D5 RID: 26837 RVA: 0x0038CC54 File Offset: 0x0038AE54
			public Class2458(ScenarioMinimapViewModel.Class2458 arg0)
			{
				if (arg0 != null)
				{
					this.double_0 = arg0.double_0;
					this.double_1 = arg0.double_1;
					this.vb$AnonymousDelegate_2_0 = arg0.vb$AnonymousDelegate_2_0;
					this.double_2 = arg0.double_2;
					this.double_3 = arg0.double_3;
				}
			}

			// Token: 0x060068D6 RID: 26838 RVA: 0x00042A15 File Offset: 0x00040C15
			internal void method_0()
			{
				this.double_0 = this.scenarioMinimapViewModel_0.grid_0.ActualWidth;
				this.double_1 = this.scenarioMinimapViewModel_0.grid_0.ActualHeight;
			}

			// Token: 0x060068D7 RID: 26839 RVA: 0x0038CCA8 File Offset: 0x0038AEA8
			internal Tuple<double, double> method_1(ActiveUnit F)
			{
				return new Tuple<double, double>(Conversions.ToDouble(this.vb$AnonymousDelegate_2_0(F.vmethod_30(null) * 3.141592653589793 / 180.0 - this.double_2)), Conversions.ToDouble(this.vb$AnonymousDelegate_2_0(F.vmethod_28(null) * 3.141592653589793 / 180.0 - this.double_3)));
			}

			// Token: 0x04003BB7 RID: 15287
			public double double_0;

			// Token: 0x04003BB8 RID: 15288
			public double double_1;

			// Token: 0x04003BB9 RID: 15289
			public VB$AnonymousDelegate_2<object, object> vb$AnonymousDelegate_2_0;

			// Token: 0x04003BBA RID: 15290
			public double double_2;

			// Token: 0x04003BBB RID: 15291
			public double double_3;

			// Token: 0x04003BBC RID: 15292
			public ScenarioMinimapViewModel scenarioMinimapViewModel_0;
		}

		// Token: 0x02000E0B RID: 3595
		[CompilerGenerated]
		internal sealed class Class2459
		{
			// Token: 0x060068DC RID: 26844 RVA: 0x00042A5A File Offset: 0x00040C5A
			public Class2459(ScenarioMinimapViewModel.Class2459 arg0)
			{
				if (arg0 != null)
				{
					this.double_0 = arg0.double_0;
					this.double_1 = arg0.double_1;
					this.uint_0 = arg0.uint_0;
				}
			}

			// Token: 0x060068DD RID: 26845 RVA: 0x0038CD38 File Offset: 0x0038AF38
			internal void method_0()
			{
				bool flag = false;
				if (this.scenarioMinimapViewModel_0.BITMAP_terrain == null)
				{
					flag = true;
				}
				else if (this.scenarioMinimapViewModel_0.BITMAP_terrain.Width != this.double_0 | this.scenarioMinimapViewModel_0.BITMAP_terrain.Height != this.double_1)
				{
					flag = true;
				}
				if (flag)
				{
					this.scenarioMinimapViewModel_0.BITMAP_terrain = new WriteableBitmap((int)Math.Round(this.double_0), (int)Math.Round(this.double_1), 96.0, 96.0, PixelFormats.Bgra32, null);
				}
				this.scenarioMinimapViewModel_0.BITMAP_terrain.WritePixels(new Int32Rect(0, 0, (int)Math.Round(this.double_0), (int)Math.Round(this.double_1)), this.uint_0, (int)Math.Round(this.double_0 * 4.0), 0);
			}

			// Token: 0x04003BC0 RID: 15296
			public double double_0;

			// Token: 0x04003BC1 RID: 15297
			public double double_1;

			// Token: 0x04003BC2 RID: 15298
			public uint[] uint_0;

			// Token: 0x04003BC3 RID: 15299
			public ScenarioMinimapViewModel scenarioMinimapViewModel_0;
		}

		// Token: 0x02000E0C RID: 3596
		[CompilerGenerated]
		internal sealed class Class2460
		{
			// Token: 0x060068DE RID: 26846 RVA: 0x0038CE24 File Offset: 0x0038B024
			public Class2460(ScenarioMinimapViewModel.Class2460 arg0)
			{
				if (arg0 != null)
				{
					this.double_0 = arg0.double_0;
					this.uint_0 = arg0.uint_0;
					this.uint_1 = arg0.uint_1;
					this.uint_2 = arg0.uint_2;
					this.uint_3 = arg0.uint_3;
					this.uint_4 = arg0.uint_4;
					this.double_1 = arg0.double_1;
				}
			}

			// Token: 0x060068DF RID: 26847 RVA: 0x0038CE90 File Offset: 0x0038B090
			internal void method_0(object xbar, object ybar, object PipSize)
			{
				object obj;
				object loopObj;
				if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, Operators.NegateObject(PipSize), PipSize, 1, ref loopObj, ref obj))
				{
					do
					{
						object obj2;
						object loopObj2;
						if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj2, Operators.NegateObject(PipSize), PipSize, 1, ref loopObj2, ref obj2))
						{
							do
							{
								int num = Conversions.ToInteger(Operators.AddObject(Operators.MultiplyObject(this.double_0, Operators.AddObject(ybar, obj2)), Operators.AddObject(xbar, obj)));
								if (num >= 0 && num < Enumerable.Count<uint>(this.uint_0))
								{
									this.uint_0[num] = (this.uint_1 << 24) + (this.uint_2 << 16) + (this.uint_3 << 8) + this.uint_4;
								}
							}
							while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj2, loopObj2, ref obj2));
						}
					}
					while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, loopObj, ref obj));
				}
			}

			// Token: 0x060068E0 RID: 26848 RVA: 0x0038CF6C File Offset: 0x0038B16C
			internal void method_1()
			{
				bool flag = false;
				if (this.scenarioMinimapViewModel_0.BITMAP_units == null)
				{
					flag = true;
				}
				else if (this.scenarioMinimapViewModel_0.BITMAP_units.Width != this.double_0 | this.scenarioMinimapViewModel_0.BITMAP_units.Height != this.double_1)
				{
					flag = true;
				}
				if (flag)
				{
					this.scenarioMinimapViewModel_0.BITMAP_units = new WriteableBitmap((int)Math.Round(this.double_0), (int)Math.Round(this.double_1), 96.0, 96.0, PixelFormats.Bgra32, null);
				}
				this.scenarioMinimapViewModel_0.BITMAP_units.WritePixels(new Int32Rect(0, 0, (int)Math.Round(this.double_0), (int)Math.Round(this.double_1)), this.uint_0, (int)Math.Round(this.double_0 * 4.0), 0);
			}

			// Token: 0x04003BC4 RID: 15300
			public double double_0;

			// Token: 0x04003BC5 RID: 15301
			public uint[] uint_0;

			// Token: 0x04003BC6 RID: 15302
			public uint uint_1;

			// Token: 0x04003BC7 RID: 15303
			public uint uint_2;

			// Token: 0x04003BC8 RID: 15304
			public uint uint_3;

			// Token: 0x04003BC9 RID: 15305
			public uint uint_4;

			// Token: 0x04003BCA RID: 15306
			public double double_1;

			// Token: 0x04003BCB RID: 15307
			public ScenarioMinimapViewModel scenarioMinimapViewModel_0;
		}
	}
}
