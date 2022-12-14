using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSMaterial.ClipperLib;

namespace ns8
{
	// Token: 0x02000100 RID: 256
	internal sealed class Class146
	{
		// Token: 0x0600067A RID: 1658 RVA: 0x00006A8D File Offset: 0x00004C8D
		[CompilerGenerated]
		public double method_0()
		{
			return this.double_6;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00006A95 File Offset: 0x00004C95
		[CompilerGenerated]
		public void method_1(double double_8)
		{
			this.double_6 = double_8;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00006A9E File Offset: 0x00004C9E
		[CompilerGenerated]
		public double method_2()
		{
			return this.double_7;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00006AA6 File Offset: 0x00004CA6
		[CompilerGenerated]
		public void method_3(double double_8)
		{
			this.double_7 = double_8;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00006AAF File Offset: 0x00004CAF
		public Class146(double miterLimit = 2.0, double arcTolerance = 0.25)
		{
			this.method_3(miterLimit);
			this.method_1(arcTolerance);
			this.intPoint_0.long_0 = -1L;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00006A37 File Offset: 0x00004C37
		internal static long smethod_0(double double_8)
		{
			if (double_8 >= 0.0)
			{
				return (long)(double_8 + 0.5);
			}
			return (long)(double_8 - 0.5);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00072DB8 File Offset: 0x00070FB8
		public void method_4(List<IntPoint> list_4, Enum22 enum22_0, Enum23 enum23_0)
		{
			int num = list_4.Count - 1;
			if (num < 0)
			{
				return;
			}
			Class135 @class = new Class135();
			@class.enum22_0 = enum22_0;
			@class.enum23_0 = enum23_0;
			if (enum23_0 != Enum23.const_1)
			{
				if (enum23_0 != Enum23.const_0)
				{
					goto IL_48;
				}
			}
			while (num > 0 && IntPoint.smethod_0(list_4[0], list_4[num]))
			{
				num--;
			}
			IL_48:
			@class.list_0.Capacity = num + 1;
			@class.list_0.Add(list_4[0]);
			int num2 = 0;
			int num3 = 0;
			for (int i = 1; i <= num; i++)
			{
				if (IntPoint.smethod_1(@class.list_0[num2], list_4[i]))
				{
					num2++;
					@class.list_0.Add(list_4[i]);
					if (list_4[i].long_1 > @class.list_0[num3].long_1 || (list_4[i].long_1 == @class.list_0[num3].long_1 && list_4[i].long_0 < @class.list_0[num3].long_0))
					{
						num3 = num2;
					}
				}
			}
			if ((enum23_0 == Enum23.const_0 && num2 < 2) || (enum23_0 != Enum23.const_0 && num2 < 0))
			{
				return;
			}
			this.class135_0.method_1(@class);
			if (enum23_0 != Enum23.const_0)
			{
				return;
			}
			if (this.intPoint_0.long_0 < 0L)
			{
				this.intPoint_0 = new IntPoint(0L, (long)num3);
				return;
			}
			IntPoint intPoint = this.class135_0.method_2()[(int)this.intPoint_0.long_0].list_0[(int)this.intPoint_0.long_1];
			if (@class.list_0[num3].long_1 > intPoint.long_1 || (@class.list_0[num3].long_1 == intPoint.long_1 && @class.list_0[num3].long_0 < intPoint.long_0))
			{
				this.intPoint_0 = new IntPoint((long)(this.class135_0.method_0() - 1), (long)num3);
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00072FC4 File Offset: 0x000711C4
		public void method_5(List<List<IntPoint>> list_4, Enum22 enum22_0, Enum23 enum23_0)
		{
			foreach (List<IntPoint> list_5 in list_4)
			{
				this.method_4(list_5, enum22_0, enum23_0);
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00073018 File Offset: 0x00071218
		private void method_6()
		{
			if (this.intPoint_0.long_0 >= 0L && !Class145.smethod_9(this.class135_0.method_2()[(int)this.intPoint_0.long_0].list_0))
			{
				for (int i = 0; i < this.class135_0.method_0(); i++)
				{
					Class135 @class = this.class135_0.method_2()[i];
					if (@class.enum23_0 == Enum23.const_0 || (@class.enum23_0 == Enum23.const_1 && Class145.smethod_9(@class.list_0)))
					{
						@class.list_0.Reverse();
					}
				}
				return;
			}
			for (int j = 0; j < this.class135_0.method_0(); j++)
			{
				Class135 class2 = this.class135_0.method_2()[j];
				if (class2.enum23_0 == Enum23.const_1 && !Class145.smethod_9(class2.list_0))
				{
					class2.list_0.Reverse();
				}
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00073100 File Offset: 0x00071300
		internal static Struct18 smethod_1(IntPoint intPoint_1, IntPoint intPoint_2)
		{
			double num = (double)(intPoint_2.long_0 - intPoint_1.long_0);
			double num2 = (double)(intPoint_2.long_1 - intPoint_1.long_1);
			if (num == 0.0 && num2 == 0.0)
			{
				return default(Struct18);
			}
			double num3 = 1.0 / Math.Sqrt(num * num + num2 * num2);
			num *= num3;
			num2 *= num3;
			return new Struct18(num2, -num);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00073174 File Offset: 0x00071374
		private void method_7(double double_8)
		{
			this.list_0 = new List<List<IntPoint>>();
			this.double_0 = double_8;
			if (Class144.smethod_0(double_8))
			{
				this.list_0.Capacity = this.class135_0.method_0();
				for (int i = 0; i < this.class135_0.method_0(); i++)
				{
					Class135 @class = this.class135_0.method_2()[i];
					if (@class.enum23_0 == Enum23.const_0)
					{
						this.list_0.Add(@class.list_0);
					}
				}
				return;
			}
			if (this.method_2() > 2.0)
			{
				this.double_4 = 2.0 / (this.method_2() * this.method_2());
			}
			else
			{
				this.double_4 = 0.5;
			}
			double num;
			if (this.method_0() <= 0.0)
			{
				num = 0.25;
			}
			else if (this.method_0() > Math.Abs(double_8) * 0.25)
			{
				num = Math.Abs(double_8) * 0.25;
			}
			else
			{
				num = this.method_0();
			}
			double num2 = 3.141592653589793 / Math.Acos(1.0 - num / Math.Abs(double_8));
			this.double_2 = Math.Sin(6.283185307179586 / num2);
			this.double_3 = Math.Cos(6.283185307179586 / num2);
			this.double_5 = num2 / 6.283185307179586;
			if (double_8 < 0.0)
			{
				this.double_2 = -this.double_2;
			}
			this.list_0.Capacity = this.class135_0.method_0() * 2;
			for (int j = 0; j < this.class135_0.method_0(); j++)
			{
				Class135 class2 = this.class135_0.method_2()[j];
				this.list_1 = class2.list_0;
				int count = this.list_1.Count;
				if (count != 0 && (double_8 > 0.0 || (count >= 3 && class2.enum23_0 == Enum23.const_0)))
				{
					this.list_2 = new List<IntPoint>();
					if (count == 1)
					{
						if (class2.enum22_0 == Enum22.const_1)
						{
							double num3 = 1.0;
							double num4 = 0.0;
							int num5 = 1;
							while ((double)num5 <= num2)
							{
								this.list_2.Add(new IntPoint(Class146.smethod_0((double)this.list_1[0].long_0 + num3 * double_8), Class146.smethod_0((double)this.list_1[0].long_1 + num4 * double_8)));
								double num6 = num3;
								num3 = num3 * this.double_3 - this.double_2 * num4;
								num4 = num6 * this.double_2 + num4 * this.double_3;
								num5++;
							}
						}
						else
						{
							double num7 = -1.0;
							double num8 = -1.0;
							for (int k = 0; k < 4; k++)
							{
								this.list_2.Add(new IntPoint(Class146.smethod_0((double)this.list_1[0].long_0 + num7 * double_8), Class146.smethod_0((double)this.list_1[0].long_1 + num8 * double_8)));
								if (num7 < 0.0)
								{
									num7 = 1.0;
								}
								else if (num8 < 0.0)
								{
									num8 = 1.0;
								}
								else
								{
									num7 = -1.0;
								}
							}
						}
						this.list_0.Add(this.list_2);
					}
					else
					{
						this.list_3.Clear();
						this.list_3.Capacity = count;
						for (int l = 0; l < count - 1; l++)
						{
							this.list_3.Add(Class146.smethod_1(this.list_1[l], this.list_1[l + 1]));
						}
						if (class2.enum23_0 != Enum23.const_1 && class2.enum23_0 != Enum23.const_0)
						{
							this.list_3.Add(new Struct18(this.list_3[count - 2]));
						}
						else
						{
							this.list_3.Add(Class146.smethod_1(this.list_1[count - 1], this.list_1[0]));
						}
						if (class2.enum23_0 == Enum23.const_0)
						{
							int num9 = count - 1;
							for (int m = 0; m < count; m++)
							{
								this.method_9(m, ref num9, class2.enum22_0);
							}
							this.list_0.Add(this.list_2);
						}
						else if (class2.enum23_0 == Enum23.const_1)
						{
							int num10 = count - 1;
							for (int n = 0; n < count; n++)
							{
								this.method_9(n, ref num10, class2.enum22_0);
							}
							this.list_0.Add(this.list_2);
							this.list_2 = new List<IntPoint>();
							Struct18 @struct = this.list_3[count - 1];
							for (int num11 = count - 1; num11 > 0; num11--)
							{
								this.list_3[num11] = new Struct18(-this.list_3[num11 - 1].double_0, -this.list_3[num11 - 1].double_1);
							}
							this.list_3[0] = new Struct18(-@struct.double_0, -@struct.double_1);
							num10 = 0;
							for (int num12 = count - 1; num12 >= 0; num12--)
							{
								this.method_9(num12, ref num10, class2.enum22_0);
							}
							this.list_0.Add(this.list_2);
						}
						else
						{
							int num13 = 0;
							for (int num14 = 1; num14 < count - 1; num14++)
							{
								this.method_9(num14, ref num13, class2.enum22_0);
							}
							if (class2.enum23_0 == Enum23.const_2)
							{
								int index = count - 1;
								IntPoint item = new IntPoint(Class146.smethod_0((double)this.list_1[index].long_0 + this.list_3[index].double_0 * double_8), Class146.smethod_0((double)this.list_1[index].long_1 + this.list_3[index].double_1 * double_8));
								this.list_2.Add(item);
								item = new IntPoint(Class146.smethod_0((double)this.list_1[index].long_0 - this.list_3[index].double_0 * double_8), Class146.smethod_0((double)this.list_1[index].long_1 - this.list_3[index].double_1 * double_8));
								this.list_2.Add(item);
							}
							else
							{
								int num15 = count - 1;
								num13 = count - 2;
								this.double_1 = 0.0;
								this.list_3[num15] = new Struct18(-this.list_3[num15].double_0, -this.list_3[num15].double_1);
								if (class2.enum23_0 == Enum23.const_3)
								{
									this.method_10(num15, num13);
								}
								else
								{
									this.method_12(num15, num13);
								}
							}
							for (int num16 = count - 1; num16 > 0; num16--)
							{
								this.list_3[num16] = new Struct18(-this.list_3[num16 - 1].double_0, -this.list_3[num16 - 1].double_1);
							}
							this.list_3[0] = new Struct18(-this.list_3[1].double_0, -this.list_3[1].double_1);
							num13 = count - 1;
							for (int num17 = num13 - 1; num17 > 0; num17--)
							{
								this.method_9(num17, ref num13, class2.enum22_0);
							}
							if (class2.enum23_0 == Enum23.const_2)
							{
								IntPoint item = new IntPoint(Class146.smethod_0((double)this.list_1[0].long_0 - this.list_3[0].double_0 * double_8), Class146.smethod_0((double)this.list_1[0].long_1 - this.list_3[0].double_1 * double_8));
								this.list_2.Add(item);
								item = new IntPoint(Class146.smethod_0((double)this.list_1[0].long_0 + this.list_3[0].double_0 * double_8), Class146.smethod_0((double)this.list_1[0].long_1 + this.list_3[0].double_1 * double_8));
								this.list_2.Add(item);
							}
							else
							{
								num13 = 1;
								this.double_1 = 0.0;
								if (class2.enum23_0 == Enum23.const_3)
								{
									this.method_10(0, 1);
								}
								else
								{
									this.method_12(0, 1);
								}
							}
							this.list_0.Add(this.list_2);
						}
					}
				}
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00073A74 File Offset: 0x00071C74
		public void method_8(ref List<List<IntPoint>> list_4, double double_8)
		{
			list_4.Clear();
			this.method_6();
			this.method_7(double_8);
			Class145 @class = new Class145(0);
			@class.method_8(this.list_0, Enum20.const_0, true);
			if (double_8 > 0.0)
			{
				@class.method_20(Enum19.const_1, list_4, Enum21.const_2, Enum21.const_2);
				return;
			}
			Struct20 @struct = Class144.smethod_4(this.list_0);
			@class.method_7(new List<IntPoint>(4)
			{
				new IntPoint(@struct.long_0 - 10L, @struct.long_3 + 10L),
				new IntPoint(@struct.long_2 + 10L, @struct.long_3 + 10L),
				new IntPoint(@struct.long_2 + 10L, @struct.long_1 - 10L),
				new IntPoint(@struct.long_0 - 10L, @struct.long_1 - 10L)
			}, Enum20.const_0, true);
			@class.method_16(true);
			@class.method_20(Enum19.const_1, list_4, Enum21.const_3, Enum21.const_3);
			if (list_4.Count > 0)
			{
				list_4.RemoveAt(0);
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00073BB4 File Offset: 0x00071DB4
		private void method_9(int int_0, ref int int_1, Enum22 enum22_0)
		{
			this.double_1 = this.list_3[int_1].double_0 * this.list_3[int_0].double_1 - this.list_3[int_0].double_0 * this.list_3[int_1].double_1;
			if (this.double_1 < 5E-05 && this.double_1 > -5E-05)
			{
				return;
			}
			if (this.double_1 > 1.0)
			{
				this.double_1 = 1.0;
			}
			else if (this.double_1 < -1.0)
			{
				this.double_1 = -1.0;
			}
			if (this.double_1 * this.double_0 < 0.0)
			{
				this.list_2.Add(new IntPoint(Class146.smethod_0((double)this.list_1[int_0].long_0 + this.list_3[int_1].double_0 * this.double_0), Class146.smethod_0((double)this.list_1[int_0].long_1 + this.list_3[int_1].double_1 * this.double_0)));
				this.list_2.Add(this.list_1[int_0]);
				this.list_2.Add(new IntPoint(Class146.smethod_0((double)this.list_1[int_0].long_0 + this.list_3[int_0].double_0 * this.double_0), Class146.smethod_0((double)this.list_1[int_0].long_1 + this.list_3[int_0].double_1 * this.double_0)));
			}
			else
			{
				switch (enum22_0)
				{
				case Enum22.const_0:
					this.method_10(int_0, int_1);
					break;
				case Enum22.const_1:
					this.method_12(int_0, int_1);
					break;
				case Enum22.const_2:
				{
					double num = 1.0 + (this.list_3[int_0].double_0 * this.list_3[int_1].double_0 + this.list_3[int_0].double_1 * this.list_3[int_1].double_1);
					if (num >= this.double_4)
					{
						this.method_11(int_0, int_1, num);
					}
					else
					{
						this.method_10(int_0, int_1);
					}
					break;
				}
				}
			}
			int_1 = int_0;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00073E30 File Offset: 0x00072030
		internal void method_10(int int_0, int int_1)
		{
			double num = Math.Tan(Math.Atan2(this.double_1, this.list_3[int_1].double_0 * this.list_3[int_0].double_0 + this.list_3[int_1].double_1 * this.list_3[int_0].double_1) / 4.0);
			this.list_2.Add(new IntPoint(Class146.smethod_0((double)this.list_1[int_0].long_0 + this.double_0 * (this.list_3[int_1].double_0 - this.list_3[int_1].double_1 * num)), Class146.smethod_0((double)this.list_1[int_0].long_1 + this.double_0 * (this.list_3[int_1].double_1 + this.list_3[int_1].double_0 * num))));
			this.list_2.Add(new IntPoint(Class146.smethod_0((double)this.list_1[int_0].long_0 + this.double_0 * (this.list_3[int_0].double_0 + this.list_3[int_0].double_1 * num)), Class146.smethod_0((double)this.list_1[int_0].long_1 + this.double_0 * (this.list_3[int_0].double_1 - this.list_3[int_0].double_0 * num))));
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00073FD0 File Offset: 0x000721D0
		internal void method_11(int int_0, int int_1, double double_8)
		{
			double num = this.double_0 / double_8;
			this.list_2.Add(new IntPoint(Class146.smethod_0((double)this.list_1[int_0].long_0 + (this.list_3[int_1].double_0 + this.list_3[int_0].double_0) * num), Class146.smethod_0((double)this.list_1[int_0].long_1 + (this.list_3[int_1].double_1 + this.list_3[int_0].double_1) * num)));
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00074070 File Offset: 0x00072270
		internal void method_12(int int_0, int int_1)
		{
			double value = Math.Atan2(this.double_1, this.list_3[int_1].double_0 * this.list_3[int_0].double_0 + this.list_3[int_1].double_1 * this.list_3[int_0].double_1);
			int num = (int)Class146.smethod_0(this.double_5 * Math.Abs(value));
			double num2 = this.list_3[int_1].double_0;
			double num3 = this.list_3[int_1].double_1;
			for (int i = 0; i < num; i++)
			{
				this.list_2.Add(new IntPoint(Class146.smethod_0((double)this.list_1[int_0].long_0 + num2 * this.double_0), Class146.smethod_0((double)this.list_1[int_0].long_1 + num3 * this.double_0)));
				double num4 = num2;
				num2 = num2 * this.double_3 - this.double_2 * num3;
				num3 = num4 * this.double_2 + num3 * this.double_3;
			}
			this.list_2.Add(new IntPoint(Class146.smethod_0((double)this.list_1[int_0].long_0 + this.list_3[int_0].double_0 * this.double_0), Class146.smethod_0((double)this.list_1[int_0].long_1 + this.list_3[int_0].double_1 * this.double_0)));
		}

		// Token: 0x04000473 RID: 1139
		private List<List<IntPoint>> list_0;

		// Token: 0x04000474 RID: 1140
		private List<IntPoint> list_1;

		// Token: 0x04000475 RID: 1141
		private List<IntPoint> list_2;

		// Token: 0x04000476 RID: 1142
		private List<Struct18> list_3 = new List<Struct18>();

		// Token: 0x04000477 RID: 1143
		private double double_0;

		// Token: 0x04000478 RID: 1144
		private double double_1;

		// Token: 0x04000479 RID: 1145
		private double double_2;

		// Token: 0x0400047A RID: 1146
		private double double_3;

		// Token: 0x0400047B RID: 1147
		private double double_4;

		// Token: 0x0400047C RID: 1148
		private double double_5;

		// Token: 0x0400047D RID: 1149
		private IntPoint intPoint_0;

		// Token: 0x0400047E RID: 1150
		private Class135 class135_0 = new Class135();

		// Token: 0x0400047F RID: 1151
		[CompilerGenerated]
		private double double_6;

		// Token: 0x04000480 RID: 1152
		[CompilerGenerated]
		private double double_7;
	}
}
