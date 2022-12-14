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
	// Token: 0x02000E02 RID: 3586
	[Attribute12]
	[Attribute13]
	[Attribute11]
	public sealed class CameraFollowingMinimapViewModel : INotifyPropertyChanged
	{
		// Token: 0x060068A1 RID: 26785 RVA: 0x0038ACA4 File Offset: 0x00388EA4
		public CameraFollowingMinimapViewModel()
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

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060068A2 RID: 26786 RVA: 0x00042848 File Offset: 0x00040A48
		// (set) Token: 0x060068A3 RID: 26787 RVA: 0x00042850 File Offset: 0x00040A50
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

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060068A4 RID: 26788 RVA: 0x00042870 File Offset: 0x00040A70
		// (set) Token: 0x060068A5 RID: 26789 RVA: 0x00042878 File Offset: 0x00040A78
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

		// Token: 0x060068A6 RID: 26790 RVA: 0x0038AD8C File Offset: 0x00388F8C
		private bool method_0(ref double GridHeight, ref double GridWidth, ref double CentroidLat, ref double CentroidLon, ref double MinCentroidRelativeLat, ref double MaxCentroidRelativeLat, ref double MinCentroidRelativeLon, ref double MaxCentroidRelativeLon, ref double SizeLat, ref double SizeLon)
		{
			CameraFollowingMinimapViewModel.Class2455 @class = new CameraFollowingMinimapViewModel.Class2455(@class);
			@class.cameraFollowingMinimapViewModel_0 = this;
			@class.double_0 = 0.0;
			@class.double_1 = 0.0;
			@class.double_2 = 0.0;
			@class.double_3 = 0.0;
			@class.double_4 = 0.0;
			this.dispatcher_0.Invoke(new VB$AnonymousDelegate_0(@class.method_0), new object[0]);
			GridWidth = @class.double_0;
			GridHeight = @class.double_1;
			VB$AnonymousDelegate_2<object, object> vb$AnonymousDelegate_ = (CameraFollowingMinimapViewModel._Closure$__.$I11-1 == null) ? (CameraFollowingMinimapViewModel._Closure$__.$I11-1 = new VB$AnonymousDelegate_2<object, object>(CameraFollowingMinimapViewModel._Closure$__.$I.method_0)) : CameraFollowingMinimapViewModel._Closure$__.$I11-1;
			CentroidLat = Conversions.ToDouble(vb$AnonymousDelegate_(@class.double_2));
			CentroidLon = Conversions.ToDouble(vb$AnonymousDelegate_(@class.double_3));
			this.dispatcher_0.Invoke(new VB$AnonymousDelegate_0(@class.method_1), new object[0]);
			bool result;
			if (@class.geoPoint_0.imethod_2() == 0.0)
			{
				result = false;
			}
			else
			{
				object objectValue = RuntimeHelpers.GetObjectValue(vb$AnonymousDelegate_(@class.geoPoint_0.imethod_2() * 3.141592653589793 / 180.0 - CentroidLat));
				object objectValue2 = RuntimeHelpers.GetObjectValue(vb$AnonymousDelegate_(@class.geoPoint_0.imethod_0() * 3.141592653589793 / 180.0 - CentroidLon));
				MinCentroidRelativeLat = Conversions.ToDouble(Operators.NegateObject(objectValue));
				MinCentroidRelativeLon = Conversions.ToDouble(objectValue2);
				MaxCentroidRelativeLat = Conversions.ToDouble(objectValue);
				MaxCentroidRelativeLon = Conversions.ToDouble(Operators.NegateObject(objectValue2));
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

		// Token: 0x060068A7 RID: 26791 RVA: 0x0038AFA8 File Offset: 0x003891A8
		public void method_1()
		{
			CameraFollowingMinimapViewModel.Class2456 @class = new CameraFollowingMinimapViewModel.Class2456(@class);
			@class.cameraFollowingMinimapViewModel_0 = this;
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

		// Token: 0x060068A8 RID: 26792 RVA: 0x0038B20C File Offset: 0x0038940C
		public void method_2()
		{
			CameraFollowingMinimapViewModel.Class2457 @class = new CameraFollowingMinimapViewModel.Class2457(@class);
			@class.cameraFollowingMinimapViewModel_0 = this;
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
			if (this.method_0(ref @class.double_1, ref @class.double_0, ref num4, ref num3, ref num5, ref num6, ref num7, ref num8, ref num, ref num2) && Client.smethod_50() != null)
			{
				@class.uint_0 = new uint[(int)Math.Round(@class.double_1 * @class.double_0) + 1];
				@class.uint_1 = 0U;
				@class.uint_2 = 0U;
				@class.uint_3 = 0U;
				@class.uint_4 = 0U;
				Delegate76<object, object, object> @delegate = new Delegate76<object, object, object>(@class.method_0);
				foreach (ActiveUnit activeUnit in Client.smethod_50().activeUnit_0)
				{
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
						foreach (ActiveUnit activeUnit2 in side.activeUnit_0)
						{
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

		// Token: 0x060068A9 RID: 26793 RVA: 0x0038B678 File Offset: 0x00389878
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

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x060068AA RID: 26794 RVA: 0x0038B710 File Offset: 0x00389910
		// (remove) Token: 0x060068AB RID: 26795 RVA: 0x0038B748 File Offset: 0x00389948
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

		// Token: 0x060068AC RID: 26796 RVA: 0x0038B780 File Offset: 0x00389980
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003B72 RID: 15218
		[CompilerGenerated]
		private WriteableBitmap writeableBitmap_0;

		// Token: 0x04003B73 RID: 15219
		[CompilerGenerated]
		private WriteableBitmap writeableBitmap_1;

		// Token: 0x04003B74 RID: 15220
		public Dispatcher dispatcher_0;

		// Token: 0x04003B75 RID: 15221
		public Grid grid_0;

		// Token: 0x04003B76 RID: 15222
		private double double_0;

		// Token: 0x04003B77 RID: 15223
		private double double_1;

		// Token: 0x04003B78 RID: 15224
		private double double_2;

		// Token: 0x04003B79 RID: 15225
		private double double_3;

		// Token: 0x04003B7A RID: 15226
		private double double_4;

		// Token: 0x04003B7B RID: 15227
		private double double_5;

		// Token: 0x04003B7C RID: 15228
		private double double_6;

		// Token: 0x04003B7D RID: 15229
		private double double_7;

		// Token: 0x04003B7E RID: 15230
		private double double_8;

		// Token: 0x04003B7F RID: 15231
		private double double_9;

		// Token: 0x04003B80 RID: 15232
		private double double_10;

		// Token: 0x04003B81 RID: 15233
		private double double_11;

		// Token: 0x04003B82 RID: 15234
		private double double_12;

		// Token: 0x04003B83 RID: 15235
		private double double_13;

		// Token: 0x04003B84 RID: 15236
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000E03 RID: 3587
		[CompilerGenerated]
		internal sealed class Class2455
		{
			// Token: 0x060068AD RID: 26797 RVA: 0x0038B7A8 File Offset: 0x003899A8
			public Class2455(CameraFollowingMinimapViewModel.Class2455 arg0)
			{
				if (arg0 != null)
				{
					this.double_0 = arg0.double_0;
					this.double_1 = arg0.double_1;
					this.double_2 = arg0.double_2;
					this.double_3 = arg0.double_3;
					this.double_4 = arg0.double_4;
					this.geoPoint_0 = arg0.geoPoint_0;
				}
			}

			// Token: 0x060068AE RID: 26798 RVA: 0x0038B808 File Offset: 0x00389A08
			internal void method_0()
			{
				this.double_0 = this.cameraFollowingMinimapViewModel_0.grid_0.ActualWidth;
				this.double_1 = this.cameraFollowingMinimapViewModel_0.grid_0.ActualHeight;
				GeoPoint geoPoint = Class2413.smethod_2().method_41().method_160(false);
				this.double_2 = geoPoint.imethod_2() * 3.141592653589793 / 180.0;
				this.double_3 = geoPoint.imethod_0() * 3.141592653589793 / 180.0;
				this.double_4 = (double)Class2413.smethod_2().method_41().method_152();
			}

			// Token: 0x060068AF RID: 26799 RVA: 0x00042898 File Offset: 0x00040A98
			internal void method_1()
			{
				this.geoPoint_0 = Class2572.smethod_1(Class2413.smethod_2().method_41().vmethod_796(), 0, 0);
			}

			// Token: 0x04003B85 RID: 15237
			public double double_0;

			// Token: 0x04003B86 RID: 15238
			public double double_1;

			// Token: 0x04003B87 RID: 15239
			public double double_2;

			// Token: 0x04003B88 RID: 15240
			public double double_3;

			// Token: 0x04003B89 RID: 15241
			public double double_4;

			// Token: 0x04003B8A RID: 15242
			public GeoPoint geoPoint_0;

			// Token: 0x04003B8B RID: 15243
			public CameraFollowingMinimapViewModel cameraFollowingMinimapViewModel_0;
		}

		// Token: 0x02000E05 RID: 3589
		[CompilerGenerated]
		internal sealed class Class2456
		{
			// Token: 0x060068B3 RID: 26803 RVA: 0x000428C2 File Offset: 0x00040AC2
			public Class2456(CameraFollowingMinimapViewModel.Class2456 arg0)
			{
				if (arg0 != null)
				{
					this.double_0 = arg0.double_0;
					this.double_1 = arg0.double_1;
					this.uint_0 = arg0.uint_0;
				}
			}

			// Token: 0x060068B4 RID: 26804 RVA: 0x0038B918 File Offset: 0x00389B18
			internal void method_0()
			{
				bool flag = false;
				if (this.cameraFollowingMinimapViewModel_0.BITMAP_terrain == null)
				{
					flag = true;
				}
				else if (this.cameraFollowingMinimapViewModel_0.BITMAP_terrain.Width != this.double_0 | this.cameraFollowingMinimapViewModel_0.BITMAP_terrain.Height != this.double_1)
				{
					flag = true;
				}
				if (flag)
				{
					this.cameraFollowingMinimapViewModel_0.BITMAP_terrain = new WriteableBitmap((int)Math.Round(this.double_0), (int)Math.Round(this.double_1), 96.0, 96.0, PixelFormats.Bgra32, null);
				}
				this.cameraFollowingMinimapViewModel_0.BITMAP_terrain.WritePixels(new Int32Rect(0, 0, (int)Math.Round(this.double_0), (int)Math.Round(this.double_1)), this.uint_0, (int)Math.Round(this.double_0 * 4.0), 0);
			}

			// Token: 0x04003B8E RID: 15246
			public double double_0;

			// Token: 0x04003B8F RID: 15247
			public double double_1;

			// Token: 0x04003B90 RID: 15248
			public uint[] uint_0;

			// Token: 0x04003B91 RID: 15249
			public CameraFollowingMinimapViewModel cameraFollowingMinimapViewModel_0;
		}

		// Token: 0x02000E06 RID: 3590
		[CompilerGenerated]
		internal sealed class Class2457
		{
			// Token: 0x060068B5 RID: 26805 RVA: 0x0038BA04 File Offset: 0x00389C04
			public Class2457(CameraFollowingMinimapViewModel.Class2457 arg0)
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

			// Token: 0x060068B6 RID: 26806 RVA: 0x0038BA70 File Offset: 0x00389C70
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

			// Token: 0x060068B7 RID: 26807 RVA: 0x0038BB4C File Offset: 0x00389D4C
			internal void method_1()
			{
				bool flag = false;
				if (this.cameraFollowingMinimapViewModel_0.BITMAP_units == null)
				{
					flag = true;
				}
				else if (this.cameraFollowingMinimapViewModel_0.BITMAP_units.Width != this.double_0 | this.cameraFollowingMinimapViewModel_0.BITMAP_units.Height != this.double_1)
				{
					flag = true;
				}
				if (flag)
				{
					this.cameraFollowingMinimapViewModel_0.BITMAP_units = new WriteableBitmap((int)Math.Round(this.double_0), (int)Math.Round(this.double_1), 96.0, 96.0, PixelFormats.Bgra32, null);
				}
				this.cameraFollowingMinimapViewModel_0.BITMAP_units.WritePixels(new Int32Rect(0, 0, (int)Math.Round(this.double_0), (int)Math.Round(this.double_1)), this.uint_0, (int)Math.Round(this.double_0 * 4.0), 0);
			}

			// Token: 0x04003B92 RID: 15250
			public double double_0;

			// Token: 0x04003B93 RID: 15251
			public uint[] uint_0;

			// Token: 0x04003B94 RID: 15252
			public uint uint_1;

			// Token: 0x04003B95 RID: 15253
			public uint uint_2;

			// Token: 0x04003B96 RID: 15254
			public uint uint_3;

			// Token: 0x04003B97 RID: 15255
			public uint uint_4;

			// Token: 0x04003B98 RID: 15256
			public double double_1;

			// Token: 0x04003B99 RID: 15257
			public CameraFollowingMinimapViewModel cameraFollowingMinimapViewModel_0;
		}
	}
}
