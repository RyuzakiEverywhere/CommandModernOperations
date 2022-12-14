using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ns1
{
	// Token: 0x02000062 RID: 98
	internal sealed class Class61<TPathNode, TUserContext> where TPathNode : Interface0<TUserContext>
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x0000396F File Offset: 0x00001B6F
		[CompilerGenerated]
		private void method_0(TPathNode[,] gparam_1)
		{
			this.gparam_0 = gparam_1;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00003978 File Offset: 0x00001B78
		[CompilerGenerated]
		public short method_1()
		{
			return this.short_0;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00003980 File Offset: 0x00001B80
		[CompilerGenerated]
		private void method_2(short short_2)
		{
			this.short_0 = short_2;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00003989 File Offset: 0x00001B89
		[CompilerGenerated]
		public short method_3()
		{
			return this.short_1;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00003991 File Offset: 0x00001B91
		[CompilerGenerated]
		private void method_4(short short_2)
		{
			this.short_1 = short_2;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000582D0 File Offset: 0x000564D0
		public Class61(TPathNode[,] gparam_1)
		{
			this.method_0(gparam_1);
			this.method_2((short)gparam_1.GetLength(0));
			this.method_4((short)gparam_1.GetLength(1));
			this.class62_1 = new Class61<TPathNode, TUserContext>.Class62[(int)this.method_1(), (int)this.method_3()];
			this.class63_0 = new Class61<TPathNode, TUserContext>.Class63((int)this.method_1(), (int)this.method_3());
			this.class63_1 = new Class61<TPathNode, TUserContext>.Class63((int)this.method_1(), (int)this.method_3());
			this.class62_0 = new Class61<TPathNode, TUserContext>.Class62[(int)this.method_1(), (int)this.method_3()];
			this.class63_2 = new Class61<TPathNode, TUserContext>.Class63((int)this.method_1(), (int)this.method_3());
			this.class60_0 = new Class60<Class61<TPathNode, TUserContext>.Class62>(Class61<TPathNode, TUserContext>.Class62.class62_0);
			for (short num = 0; num < this.method_1(); num += 1)
			{
				for (short num2 = 0; num2 < this.method_3(); num2 += 1)
				{
					if (gparam_1[(int)num, (int)num2] == null)
					{
						throw new ArgumentNullException(string.Concat(new object[]
						{
							"Null exception at grid X:",
							num,
							" - Y: ",
							num2
						}));
					}
					this.class62_1[(int)num, (int)num2] = new Class61<TPathNode, TUserContext>.Class62(num, num2, gparam_1[(int)num, (int)num2]);
				}
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000399A File Offset: 0x00001B9A
		protected double vmethod_0(Class61<TPathNode, TUserContext>.Class62 class62_2, Class61<TPathNode, TUserContext>.Class62 class62_3)
		{
			return Math.Sqrt((double)((class62_2.method_8() - class62_3.method_8()) * (class62_2.method_8() - class62_3.method_8()) + (class62_2.method_10() - class62_3.method_10()) * (class62_2.method_10() - class62_3.method_10())));
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00058410 File Offset: 0x00056610
		protected double vmethod_1(Class61<TPathNode, TUserContext>.Class62 class62_2, Class61<TPathNode, TUserContext>.Class62 class62_3)
		{
			int num = Math.Abs(class62_2.method_8() - class62_3.method_8());
			int num2 = Math.Abs(class62_2.method_10() - class62_3.method_10());
			switch (num + num2)
			{
			case 0:
				return 0.0;
			case 1:
				return 1.0;
			case 2:
				return Class61<TPathNode, TUserContext>.double_0;
			default:
				throw new ApplicationException();
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00058478 File Offset: 0x00056678
		public LinkedList<TPathNode> method_5(Point point_0, Point point_1, TUserContext gparam_1)
		{
			Class61<TPathNode, TUserContext>.Class62 @class = this.class62_1[point_0.X, point_0.Y];
			Class61<TPathNode, TUserContext>.Class62 class2 = this.class62_1[point_1.X, point_1.Y];
			if (@class == class2)
			{
				return new LinkedList<TPathNode>(new TPathNode[]
				{
					@class.method_0()
				});
			}
			Class61<TPathNode, TUserContext>.Class62[] array = new Class61<TPathNode, TUserContext>.Class62[8];
			this.class63_0.method_10();
			this.class63_1.method_10();
			this.class63_2.method_10();
			this.class60_0.method_4();
			for (int i = 0; i < (int)this.method_1(); i++)
			{
				for (int j = 0; j < (int)this.method_3(); j++)
				{
					this.class62_0[i, j] = null;
				}
			}
			@class.method_3(0f);
			@class.method_5((float)this.vmethod_0(@class, class2));
			@class.method_7(@class.method_4());
			this.class63_1.method_7(@class);
			this.class60_0.method_1(@class);
			this.class63_2.method_7(@class);
			int num = 0;
			while (!this.class63_1.method_6())
			{
				Class61<TPathNode, TUserContext>.Class62 class3 = this.class60_0.method_2();
				if (class3 == class2)
				{
					LinkedList<TPathNode> linkedList = this.method_6(this.class62_0, this.class62_0[class2.method_8(), class2.method_10()]);
					linkedList.AddLast(class2.method_0());
					return linkedList;
				}
				this.class63_1.method_9(class3);
				this.class63_0.method_7(class3);
				this.method_8(class3, array);
				foreach (Class61<TPathNode, TUserContext>.Class62 class4 in array)
				{
					if (class4 != null)
					{
						TPathNode tpathNode = class4.method_0();
						if (tpathNode.imethod_0(gparam_1) && !this.class63_0.method_8(class4))
						{
							num++;
							double num2 = (double)this.class63_2[class3].method_2() + this.vmethod_1(class3, class4);
							bool flag = false;
							bool flag2;
							if (!this.class63_1.method_8(class4))
							{
								this.class63_1.method_7(class4);
								flag2 = true;
								flag = true;
							}
							else
							{
								flag2 = (num2 < (double)this.class63_2[class4].method_2());
							}
							if (flag2)
							{
								this.class62_0[class4.method_8(), class4.method_10()] = class3;
								if (!this.class63_2.method_8(class4))
								{
									this.class63_2.method_7(class4);
								}
								this.class63_2[class4].method_3((float)num2);
								this.class63_2[class4].method_5((float)this.vmethod_0(class4, class2));
								this.class63_2[class4].method_7(this.class63_2[class4].method_2() + this.class63_2[class4].method_4());
								if (flag)
								{
									this.class60_0.method_1(class4);
								}
								else
								{
									this.class60_0.method_3(class4);
								}
							}
						}
					}
				}
			}
			return null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00058798 File Offset: 0x00056998
		private LinkedList<TPathNode> method_6(Class61<TPathNode, TUserContext>.Class62[,] class62_2, Class61<TPathNode, TUserContext>.Class62 class62_3)
		{
			LinkedList<TPathNode> linkedList = new LinkedList<TPathNode>();
			this.method_7(class62_2, class62_3, linkedList);
			return linkedList;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000587B8 File Offset: 0x000569B8
		private void method_7(Class61<TPathNode, TUserContext>.Class62[,] class62_2, Class61<TPathNode, TUserContext>.Class62 class62_3, LinkedList<TPathNode> linkedList_0)
		{
			Class61<TPathNode, TUserContext>.Class62 @class = class62_2[class62_3.method_8(), class62_3.method_10()];
			if (@class != null)
			{
				this.method_7(class62_2, @class, linkedList_0);
				linkedList_0.AddLast(class62_3.method_0());
				return;
			}
			linkedList_0.AddLast(class62_3.method_0());
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00058800 File Offset: 0x00056A00
		private void method_8(Class61<TPathNode, TUserContext>.Class62 class62_2, Class61<TPathNode, TUserContext>.Class62[] class62_3)
		{
			int num = class62_2.method_8();
			int num2 = class62_2.method_10();
			if (num > 0 && num2 > 0)
			{
				class62_3[0] = this.class62_1[num - 1, num2 - 1];
			}
			else
			{
				class62_3[0] = null;
			}
			if (num2 > 0)
			{
				class62_3[1] = this.class62_1[num, num2 - 1];
			}
			else
			{
				class62_3[1] = null;
			}
			if (num < (int)(this.method_1() - 1) && num2 > 0)
			{
				class62_3[2] = this.class62_1[num + 1, num2 - 1];
			}
			else
			{
				class62_3[2] = null;
			}
			if (num > 0)
			{
				class62_3[3] = this.class62_1[num - 1, num2];
			}
			else
			{
				class62_3[3] = null;
			}
			if (num < (int)(this.method_1() - 1))
			{
				class62_3[4] = this.class62_1[num + 1, num2];
			}
			else
			{
				class62_3[4] = null;
			}
			if (num > 0 && num2 < (int)(this.method_3() - 1))
			{
				class62_3[5] = this.class62_1[num - 1, num2 + 1];
			}
			else
			{
				class62_3[5] = null;
			}
			if (num2 < (int)(this.method_3() - 1))
			{
				class62_3[6] = this.class62_1[num, num2 + 1];
			}
			else
			{
				class62_3[6] = null;
			}
			if (num < (int)(this.method_1() - 1) && num2 < (int)(this.method_3() - 1))
			{
				class62_3[7] = this.class62_1[num + 1, num2 + 1];
				return;
			}
			class62_3[7] = null;
		}

		// Token: 0x040000E9 RID: 233
		private Class61<TPathNode, TUserContext>.Class63 class63_0;

		// Token: 0x040000EA RID: 234
		private Class61<TPathNode, TUserContext>.Class63 class63_1;

		// Token: 0x040000EB RID: 235
		private Class60<Class61<TPathNode, TUserContext>.Class62> class60_0;

		// Token: 0x040000EC RID: 236
		private Class61<TPathNode, TUserContext>.Class62[,] class62_0;

		// Token: 0x040000ED RID: 237
		private Class61<TPathNode, TUserContext>.Class63 class63_2;

		// Token: 0x040000EE RID: 238
		private Class61<TPathNode, TUserContext>.Class62[,] class62_1;

		// Token: 0x040000EF RID: 239
		[CompilerGenerated]
		private TPathNode[,] gparam_0;

		// Token: 0x040000F0 RID: 240
		[CompilerGenerated]
		private short short_0;

		// Token: 0x040000F1 RID: 241
		[CompilerGenerated]
		private short short_1;

		// Token: 0x040000F2 RID: 242
		private static readonly double double_0 = Math.Sqrt(2.0);

		// Token: 0x02000063 RID: 99
		protected sealed class Class62 : Interface0<TUserContext>, IComparer<Class61<TPathNode, TUserContext>.Class62>, Interface1
		{
			// Token: 0x060001AE RID: 430 RVA: 0x000039EE File Offset: 0x00001BEE
			[CompilerGenerated]
			public TPathNode method_0()
			{
				return this.gparam_0;
			}

			// Token: 0x060001AF RID: 431 RVA: 0x000039F6 File Offset: 0x00001BF6
			[CompilerGenerated]
			internal void method_1(TPathNode gparam_1)
			{
				this.gparam_0 = gparam_1;
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x000039FF File Offset: 0x00001BFF
			[CompilerGenerated]
			public float method_2()
			{
				return this.float_0;
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x00003A07 File Offset: 0x00001C07
			[CompilerGenerated]
			internal void method_3(float float_3)
			{
				this.float_0 = float_3;
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x00003A10 File Offset: 0x00001C10
			[CompilerGenerated]
			public float method_4()
			{
				return this.float_1;
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x00003A18 File Offset: 0x00001C18
			[CompilerGenerated]
			internal void method_5(float float_3)
			{
				this.float_1 = float_3;
			}

			// Token: 0x060001B4 RID: 436 RVA: 0x00003A21 File Offset: 0x00001C21
			[CompilerGenerated]
			public float method_6()
			{
				return this.float_2;
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x00003A29 File Offset: 0x00001C29
			[CompilerGenerated]
			internal void method_7(float float_3)
			{
				this.float_2 = float_3;
			}

			// Token: 0x060001B6 RID: 438 RVA: 0x00003A32 File Offset: 0x00001C32
			[CompilerGenerated]
			public int imethod_1()
			{
				return this.int_0;
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x00003A3A File Offset: 0x00001C3A
			[CompilerGenerated]
			public void imethod_2(int int_3)
			{
				this.int_0 = int_3;
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x0005893C File Offset: 0x00056B3C
			public bool imethod_0(TUserContext gparam_1)
			{
				TPathNode tpathNode = this.method_0();
				return tpathNode.imethod_0(gparam_1);
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x00003A43 File Offset: 0x00001C43
			[CompilerGenerated]
			public int method_8()
			{
				return this.int_1;
			}

			// Token: 0x060001BA RID: 442 RVA: 0x00003A4B File Offset: 0x00001C4B
			[CompilerGenerated]
			internal void method_9(int int_3)
			{
				this.int_1 = int_3;
			}

			// Token: 0x060001BB RID: 443 RVA: 0x00003A54 File Offset: 0x00001C54
			[CompilerGenerated]
			public int method_10()
			{
				return this.int_2;
			}

			// Token: 0x060001BC RID: 444 RVA: 0x00003A5C File Offset: 0x00001C5C
			[CompilerGenerated]
			internal void method_11(int int_3)
			{
				this.int_2 = int_3;
			}

			// Token: 0x060001BD RID: 445 RVA: 0x00003A65 File Offset: 0x00001C65
			public int Compare(Class61<TPathNode, TUserContext>.Class62 x, Class61<TPathNode, TUserContext>.Class62 y)
			{
				if (x.method_6() < y.method_6())
				{
					return -1;
				}
				if (x.method_6() > y.method_6())
				{
					return 1;
				}
				return 0;
			}

			// Token: 0x060001BE RID: 446 RVA: 0x00003A88 File Offset: 0x00001C88
			public Class62(short short_0, short short_1, TPathNode gparam_1)
			{
				this.method_9((int)short_0);
				this.method_11((int)short_1);
				this.method_1(gparam_1);
			}

			// Token: 0x040000F3 RID: 243
			public static readonly Class61<TPathNode, TUserContext>.Class62 class62_0 = new Class61<TPathNode, TUserContext>.Class62(0, 0, default(TPathNode));

			// Token: 0x040000F4 RID: 244
			[CompilerGenerated]
			private TPathNode gparam_0;

			// Token: 0x040000F5 RID: 245
			[CompilerGenerated]
			private float float_0;

			// Token: 0x040000F6 RID: 246
			[CompilerGenerated]
			private float float_1;

			// Token: 0x040000F7 RID: 247
			[CompilerGenerated]
			private float float_2;

			// Token: 0x040000F8 RID: 248
			[CompilerGenerated]
			private int int_0;

			// Token: 0x040000F9 RID: 249
			[CompilerGenerated]
			private int int_1;

			// Token: 0x040000FA RID: 250
			[CompilerGenerated]
			private int int_2;
		}

		// Token: 0x02000064 RID: 100
		private sealed class Class63
		{
			// Token: 0x060001C0 RID: 448 RVA: 0x00003AA5 File Offset: 0x00001CA5
			[CompilerGenerated]
			public int method_0()
			{
				return this.int_0;
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x00003AAD File Offset: 0x00001CAD
			[CompilerGenerated]
			private void method_1(int int_3)
			{
				this.int_0 = int_3;
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x00003AB6 File Offset: 0x00001CB6
			[CompilerGenerated]
			public int method_2()
			{
				return this.int_1;
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x00003ABE File Offset: 0x00001CBE
			[CompilerGenerated]
			private void method_3(int int_3)
			{
				this.int_1 = int_3;
			}

			// Token: 0x060001C4 RID: 452 RVA: 0x00003AC7 File Offset: 0x00001CC7
			[CompilerGenerated]
			public int method_4()
			{
				return this.int_2;
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x00003ACF File Offset: 0x00001CCF
			[CompilerGenerated]
			private void method_5(int int_3)
			{
				this.int_2 = int_3;
			}

			// Token: 0x17000017 RID: 23
			public Class61<TPathNode, TUserContext>.Class62 this[int int_3, int int_4]
			{
				get
				{
					return this.class62_0[int_3, int_4];
				}
			}

			// Token: 0x17000018 RID: 24
			public Class61<TPathNode, TUserContext>.Class62 this[Class61<TPathNode, TUserContext>.Class62 class62_1]
			{
				get
				{
					return this.class62_0[class62_1.method_8(), class62_1.method_10()];
				}
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00003B00 File Offset: 0x00001D00
			public bool method_6()
			{
				return this.method_4() == 0;
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x00003B0B File Offset: 0x00001D0B
			public Class63(int int_3, int int_4)
			{
				this.class62_0 = new Class61<TPathNode, TUserContext>.Class62[int_3, int_4];
				this.method_1(int_3);
				this.method_3(int_4);
			}

			// Token: 0x060001CA RID: 458 RVA: 0x00058984 File Offset: 0x00056B84
			public void method_7(Class61<TPathNode, TUserContext>.Class62 class62_1)
			{
				this.class62_0[class62_1.method_8(), class62_1.method_10()];
				int num = this.method_4();
				this.method_5(num + 1);
				this.class62_0[class62_1.method_8(), class62_1.method_10()] = class62_1;
			}

			// Token: 0x060001CB RID: 459 RVA: 0x00003B2E File Offset: 0x00001D2E
			public bool method_8(Class61<TPathNode, TUserContext>.Class62 class62_1)
			{
				return this.class62_0[class62_1.method_8(), class62_1.method_10()] != null;
			}

			// Token: 0x060001CC RID: 460 RVA: 0x000589D4 File Offset: 0x00056BD4
			public void method_9(Class61<TPathNode, TUserContext>.Class62 class62_1)
			{
				this.class62_0[class62_1.method_8(), class62_1.method_10()];
				int num = this.method_4();
				this.method_5(num - 1);
				this.class62_0[class62_1.method_8(), class62_1.method_10()] = null;
			}

			// Token: 0x060001CD RID: 461 RVA: 0x00058A24 File Offset: 0x00056C24
			public void method_10()
			{
				this.method_5(0);
				for (int i = 0; i < this.method_0(); i++)
				{
					for (int j = 0; j < this.method_2(); j++)
					{
						this.class62_0[i, j] = null;
					}
				}
			}

			// Token: 0x040000FB RID: 251
			private Class61<TPathNode, TUserContext>.Class62[,] class62_0;

			// Token: 0x040000FC RID: 252
			[CompilerGenerated]
			private int int_0;

			// Token: 0x040000FD RID: 253
			[CompilerGenerated]
			private int int_1;

			// Token: 0x040000FE RID: 254
			[CompilerGenerated]
			private int int_2;
		}
	}
}
