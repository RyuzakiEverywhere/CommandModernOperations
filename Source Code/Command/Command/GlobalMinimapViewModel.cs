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
	// Token: 0x02000E0E RID: 3598
	[Attribute11]
	[Attribute12]
	[Attribute13]
	public sealed class GlobalMinimapViewModel : INotifyPropertyChanged
	{
		// Token: 0x060068F2 RID: 26866 RVA: 0x0038D314 File Offset: 0x0038B514
		public GlobalMinimapViewModel()
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

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060068F3 RID: 26867 RVA: 0x00042B59 File Offset: 0x00040D59
		// (set) Token: 0x060068F4 RID: 26868 RVA: 0x00042B61 File Offset: 0x00040D61
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

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060068F5 RID: 26869 RVA: 0x00042B81 File Offset: 0x00040D81
		// (set) Token: 0x060068F6 RID: 26870 RVA: 0x00042B89 File Offset: 0x00040D89
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

		// Token: 0x060068F7 RID: 26871 RVA: 0x0038D3FC File Offset: 0x0038B5FC
		private bool method_0(ref double GridHeight, ref double GridWidth, ref double CentroidLat, ref double CentroidLon, ref double MinCentroidRelativeLat, ref double MaxCentroidRelativeLat, ref double MinCentroidRelativeLon, ref double MaxCentroidRelativeLon, ref double SizeLat, ref double SizeLon)
		{
			GlobalMinimapViewModel.Class2461 @class = new GlobalMinimapViewModel.Class2461(@class);
			@class.globalMinimapViewModel_0 = this;
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
			List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().method_42(), (GlobalMinimapViewModel._Closure$__.$I11-1 == null) ? (GlobalMinimapViewModel._Closure$__.$I11-1 = new Func<ActiveUnit, bool>(GlobalMinimapViewModel._Closure$__.$I.method_0)) : GlobalMinimapViewModel._Closure$__.$I11-1));
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
				VB$AnonymousDelegate_2<object, object> vb$AnonymousDelegate_ = new VB$AnonymousDelegate_2<object, object>(GlobalMinimapViewModel._Closure$__.$I.method_1);
				CentroidLon = 0.0;
				CentroidLat = 0.0;
				MinCentroidRelativeLat = -1.5707963267948966;
				MaxCentroidRelativeLat = 1.5707963267948966;
				MinCentroidRelativeLon = -3.141592653589793;
				MaxCentroidRelativeLon = 3.141592653589793;
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

		// Token: 0x060068F8 RID: 26872 RVA: 0x0038D734 File Offset: 0x0038B934
		public void method_1()
		{
			GlobalMinimapViewModel.Class2462 @class = new GlobalMinimapViewModel.Class2462(@class);
			@class.globalMinimapViewModel_0 = this;
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

		// Token: 0x060068F9 RID: 26873 RVA: 0x0038D9A0 File Offset: 0x0038BBA0
		public void method_2()
		{
			GlobalMinimapViewModel.Class2463 @class = new GlobalMinimapViewModel.Class2463(@class);
			@class.globalMinimapViewModel_0 = this;
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

		// Token: 0x060068FA RID: 26874 RVA: 0x0038DE1C File Offset: 0x0038C01C
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

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x060068FB RID: 26875 RVA: 0x0038DEB4 File Offset: 0x0038C0B4
		// (remove) Token: 0x060068FC RID: 26876 RVA: 0x0038DEEC File Offset: 0x0038C0EC
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

		// Token: 0x060068FD RID: 26877 RVA: 0x0038DF24 File Offset: 0x0038C124
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003BD6 RID: 15318
		[CompilerGenerated]
		private WriteableBitmap writeableBitmap_0;

		// Token: 0x04003BD7 RID: 15319
		[CompilerGenerated]
		private WriteableBitmap writeableBitmap_1;

		// Token: 0x04003BD8 RID: 15320
		public Dispatcher dispatcher_0;

		// Token: 0x04003BD9 RID: 15321
		public Grid grid_0;

		// Token: 0x04003BDA RID: 15322
		private double double_0;

		// Token: 0x04003BDB RID: 15323
		private double double_1;

		// Token: 0x04003BDC RID: 15324
		private double double_2;

		// Token: 0x04003BDD RID: 15325
		private double double_3;

		// Token: 0x04003BDE RID: 15326
		private double double_4;

		// Token: 0x04003BDF RID: 15327
		private double double_5;

		// Token: 0x04003BE0 RID: 15328
		private double double_6;

		// Token: 0x04003BE1 RID: 15329
		private double double_7;

		// Token: 0x04003BE2 RID: 15330
		private double double_8;

		// Token: 0x04003BE3 RID: 15331
		private double double_9;

		// Token: 0x04003BE4 RID: 15332
		private double double_10;

		// Token: 0x04003BE5 RID: 15333
		private double double_11;

		// Token: 0x04003BE6 RID: 15334
		private double double_12;

		// Token: 0x04003BE7 RID: 15335
		private double double_13;

		// Token: 0x04003BE8 RID: 15336
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000E0F RID: 3599
		[CompilerGenerated]
		internal sealed class Class2461
		{
			// Token: 0x060068FE RID: 26878 RVA: 0x00042BA9 File Offset: 0x00040DA9
			public Class2461(GlobalMinimapViewModel.Class2461 arg0)
			{
				if (arg0 != null)
				{
					this.double_0 = arg0.double_0;
					this.double_1 = arg0.double_1;
				}
			}

			// Token: 0x060068FF RID: 26879 RVA: 0x00042BCC File Offset: 0x00040DCC
			internal void method_0()
			{
				this.double_0 = this.globalMinimapViewModel_0.grid_0.ActualWidth;
				this.double_1 = this.globalMinimapViewModel_0.grid_0.ActualHeight;
			}

			// Token: 0x04003BE9 RID: 15337
			public double double_0;

			// Token: 0x04003BEA RID: 15338
			public double double_1;

			// Token: 0x04003BEB RID: 15339
			public GlobalMinimapViewModel globalMinimapViewModel_0;
		}

		// Token: 0x02000E11 RID: 3601
		[CompilerGenerated]
		internal sealed class Class2462
		{
			// Token: 0x06006904 RID: 26884 RVA: 0x00042C06 File Offset: 0x00040E06
			public Class2462(GlobalMinimapViewModel.Class2462 arg0)
			{
				if (arg0 != null)
				{
					this.double_0 = arg0.double_0;
					this.double_1 = arg0.double_1;
					this.uint_0 = arg0.uint_0;
				}
			}

			// Token: 0x06006905 RID: 26885 RVA: 0x0038DF4C File Offset: 0x0038C14C
			internal void method_0()
			{
				bool flag = false;
				if (this.globalMinimapViewModel_0.BITMAP_terrain == null)
				{
					flag = true;
				}
				else if (this.globalMinimapViewModel_0.BITMAP_terrain.Width != this.double_0 | this.globalMinimapViewModel_0.BITMAP_terrain.Height != this.double_1)
				{
					flag = true;
				}
				if (flag)
				{
					this.globalMinimapViewModel_0.BITMAP_terrain = new WriteableBitmap((int)Math.Round(this.double_0), (int)Math.Round(this.double_1), 96.0, 96.0, PixelFormats.Bgra32, null);
				}
				this.globalMinimapViewModel_0.BITMAP_terrain.WritePixels(new Int32Rect(0, 0, (int)Math.Round(this.double_0), (int)Math.Round(this.double_1)), this.uint_0, (int)Math.Round(this.double_0 * 4.0), 0);
			}

			// Token: 0x04003BEF RID: 15343
			public double double_0;

			// Token: 0x04003BF0 RID: 15344
			public double double_1;

			// Token: 0x04003BF1 RID: 15345
			public uint[] uint_0;

			// Token: 0x04003BF2 RID: 15346
			public GlobalMinimapViewModel globalMinimapViewModel_0;
		}

		// Token: 0x02000E12 RID: 3602
		[CompilerGenerated]
		internal sealed class Class2463
		{
			// Token: 0x06006906 RID: 26886 RVA: 0x0038E038 File Offset: 0x0038C238
			public Class2463(GlobalMinimapViewModel.Class2463 arg0)
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

			// Token: 0x06006907 RID: 26887 RVA: 0x0038E0A4 File Offset: 0x0038C2A4
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

			// Token: 0x06006908 RID: 26888 RVA: 0x0038E180 File Offset: 0x0038C380
			internal void method_1()
			{
				bool flag = false;
				if (this.globalMinimapViewModel_0.BITMAP_units == null)
				{
					flag = true;
				}
				else if (this.globalMinimapViewModel_0.BITMAP_units.Width != this.double_0 | this.globalMinimapViewModel_0.BITMAP_units.Height != this.double_1)
				{
					flag = true;
				}
				if (flag)
				{
					this.globalMinimapViewModel_0.BITMAP_units = new WriteableBitmap((int)Math.Round(this.double_0), (int)Math.Round(this.double_1), 96.0, 96.0, PixelFormats.Bgra32, null);
				}
				this.globalMinimapViewModel_0.BITMAP_units.WritePixels(new Int32Rect(0, 0, (int)Math.Round(this.double_0), (int)Math.Round(this.double_1)), this.uint_0, (int)Math.Round(this.double_0 * 4.0), 0);
			}

			// Token: 0x04003BF3 RID: 15347
			public double double_0;

			// Token: 0x04003BF4 RID: 15348
			public uint[] uint_0;

			// Token: 0x04003BF5 RID: 15349
			public uint uint_1;

			// Token: 0x04003BF6 RID: 15350
			public uint uint_2;

			// Token: 0x04003BF7 RID: 15351
			public uint uint_3;

			// Token: 0x04003BF8 RID: 15352
			public uint uint_4;

			// Token: 0x04003BF9 RID: 15353
			public double double_1;

			// Token: 0x04003BFA RID: 15354
			public GlobalMinimapViewModel globalMinimapViewModel_0;
		}
	}
}
