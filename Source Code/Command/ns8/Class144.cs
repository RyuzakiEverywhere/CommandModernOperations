using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSMaterial.ClipperLib;

namespace ns8
{
	// Token: 0x020000FE RID: 254
	internal class Class144
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x000067F7 File Offset: 0x000049F7
		internal static bool smethod_0(double double_0)
		{
			return double_0 > -1E-20 && double_0 < 1E-20;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00006813 File Offset: 0x00004A13
		[CompilerGenerated]
		public bool method_0()
		{
			return this.bool_2;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0000681B File Offset: 0x00004A1B
		[CompilerGenerated]
		public void method_1(bool bool_3)
		{
			this.bool_2 = bool_3;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00006824 File Offset: 0x00004A24
		internal static bool smethod_1(Class136 class136_0)
		{
			return class136_0.intPoint_3.long_1 == 0L;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0006D7E8 File Offset: 0x0006B9E8
		internal static bool smethod_2(Class136 class136_0, Class136 class136_1, bool bool_3)
		{
			if (bool_3)
			{
				return Struct19.smethod_0(Struct19.smethod_2(class136_0.intPoint_3.long_1, class136_1.intPoint_3.long_0), Struct19.smethod_2(class136_0.intPoint_3.long_0, class136_1.intPoint_3.long_1));
			}
			return class136_0.intPoint_3.long_1 * class136_1.intPoint_3.long_0 == class136_0.intPoint_3.long_0 * class136_1.intPoint_3.long_1;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0006D864 File Offset: 0x0006BA64
		protected static bool smethod_3(IntPoint intPoint_0, IntPoint intPoint_1, IntPoint intPoint_2, bool bool_3)
		{
			if (bool_3)
			{
				return Struct19.smethod_0(Struct19.smethod_2(intPoint_0.long_1 - intPoint_1.long_1, intPoint_1.long_0 - intPoint_2.long_0), Struct19.smethod_2(intPoint_0.long_0 - intPoint_1.long_0, intPoint_1.long_1 - intPoint_2.long_1));
			}
			return (intPoint_0.long_1 - intPoint_1.long_1) * (intPoint_1.long_0 - intPoint_2.long_0) - (intPoint_0.long_0 - intPoint_1.long_0) * (intPoint_1.long_1 - intPoint_2.long_1) == 0L;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0000683C File Offset: 0x00004A3C
		internal Class144()
		{
			this.class139_0 = null;
			this.class139_1 = null;
			this.bool_0 = false;
			this.bool_1 = false;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0006D8FC File Offset: 0x0006BAFC
		private void method_2(IntPoint intPoint_0, ref bool bool_3)
		{
			if (bool_3)
			{
				if (intPoint_0.long_0 > 4611686018427387903L || intPoint_0.long_1 > 4611686018427387903L || -intPoint_0.long_0 > 4611686018427387903L || -intPoint_0.long_1 > 4611686018427387903L)
				{
					throw new Exception0("Coordinate outside allowed range");
				}
			}
			else if (intPoint_0.long_0 > 1073741823L || intPoint_0.long_1 > 1073741823L || -intPoint_0.long_0 > 1073741823L || -intPoint_0.long_1 > 1073741823L)
			{
				bool_3 = true;
				this.method_2(intPoint_0, ref bool_3);
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0000686B File Offset: 0x00004A6B
		private void method_3(Class136 class136_0, Class136 class136_1, Class136 class136_2, IntPoint intPoint_0)
		{
			class136_0.class136_0 = class136_1;
			class136_0.class136_1 = class136_2;
			class136_0.intPoint_1 = intPoint_0;
			class136_0.int_3 = -1;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0006D9B0 File Offset: 0x0006BBB0
		private void method_4(Class136 class136_0, Enum20 enum20_0)
		{
			if (class136_0.intPoint_1.long_1 >= class136_0.class136_0.intPoint_1.long_1)
			{
				class136_0.intPoint_0 = class136_0.intPoint_1;
				class136_0.intPoint_2 = class136_0.class136_0.intPoint_1;
			}
			else
			{
				class136_0.intPoint_2 = class136_0.intPoint_1;
				class136_0.intPoint_0 = class136_0.class136_0.intPoint_1;
			}
			this.method_11(class136_0);
			class136_0.enum20_0 = enum20_0;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0006DA24 File Offset: 0x0006BC24
		private Class136 method_5(Class136 class136_0)
		{
			Class136 @class;
			for (;;)
			{
				if (!IntPoint.smethod_1(class136_0.intPoint_0, class136_0.class136_1.intPoint_0) && !IntPoint.smethod_0(class136_0.intPoint_1, class136_0.intPoint_2))
				{
					if (class136_0.double_0 != -3.4E+38 && class136_0.class136_1.double_0 != -3.4E+38)
					{
						break;
					}
					while (class136_0.class136_1.double_0 == -3.4E+38)
					{
						class136_0 = class136_0.class136_1;
					}
					@class = class136_0;
					while (class136_0.double_0 == -3.4E+38)
					{
						class136_0 = class136_0.class136_0;
					}
					if (class136_0.intPoint_2.long_1 != class136_0.class136_1.intPoint_0.long_1)
					{
						goto Block_6;
					}
				}
				else
				{
					class136_0 = class136_0.class136_0;
				}
			}
			return class136_0;
			Block_6:
			if (@class.class136_1.intPoint_0.long_0 < class136_0.intPoint_0.long_0)
			{
				class136_0 = @class;
			}
			return class136_0;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0006DB20 File Offset: 0x0006BD20
		private Class136 method_6(Class136 class136_0, bool bool_3)
		{
			Class136 @class = class136_0;
			Class136 class2 = class136_0;
			if (class136_0.double_0 == -3.4E+38)
			{
				long long_;
				if (bool_3)
				{
					long_ = class136_0.class136_1.intPoint_0.long_0;
				}
				else
				{
					long_ = class136_0.class136_0.intPoint_0.long_0;
				}
				if (class136_0.intPoint_0.long_0 != long_)
				{
					this.method_14(class136_0);
				}
			}
			if (class2.int_3 != -2)
			{
				if (bool_3)
				{
					while (class2.intPoint_2.long_1 == class2.class136_0.intPoint_0.long_1)
					{
						if (class2.class136_0.int_3 == -2)
						{
							break;
						}
						class2 = class2.class136_0;
					}
					if (class2.double_0 == -3.4E+38 && class2.class136_0.int_3 != -2)
					{
						Class136 class3 = class2;
						while (class3.class136_1.double_0 == -3.4E+38)
						{
							class3 = class3.class136_1;
						}
						if (class3.class136_1.intPoint_2.long_0 == class2.class136_0.intPoint_2.long_0)
						{
							if (!bool_3)
							{
								class2 = class3.class136_1;
							}
						}
						else if (class3.class136_1.intPoint_2.long_0 > class2.class136_0.intPoint_2.long_0)
						{
							class2 = class3.class136_1;
						}
					}
					while (class136_0 != class2)
					{
						class136_0.class136_2 = class136_0.class136_0;
						if (class136_0.double_0 == -3.4E+38 && class136_0 != @class && class136_0.intPoint_0.long_0 != class136_0.class136_1.intPoint_2.long_0)
						{
							this.method_14(class136_0);
						}
						class136_0 = class136_0.class136_0;
					}
					if (class136_0.double_0 == -3.4E+38 && class136_0 != @class && class136_0.intPoint_0.long_0 != class136_0.class136_1.intPoint_2.long_0)
					{
						this.method_14(class136_0);
					}
					class2 = class2.class136_0;
				}
				else
				{
					while (class2.intPoint_2.long_1 == class2.class136_1.intPoint_0.long_1)
					{
						if (class2.class136_1.int_3 == -2)
						{
							break;
						}
						class2 = class2.class136_1;
					}
					if (class2.double_0 == -3.4E+38 && class2.class136_1.int_3 != -2)
					{
						Class136 class3 = class2;
						while (class3.class136_0.double_0 == -3.4E+38)
						{
							class3 = class3.class136_0;
						}
						if (class3.class136_0.intPoint_2.long_0 == class2.class136_1.intPoint_2.long_0)
						{
							if (!bool_3)
							{
								class2 = class3.class136_0;
							}
						}
						else if (class3.class136_0.intPoint_2.long_0 > class2.class136_1.intPoint_2.long_0)
						{
							class2 = class3.class136_0;
						}
					}
					while (class136_0 != class2)
					{
						class136_0.class136_2 = class136_0.class136_1;
						if (class136_0.double_0 == -3.4E+38 && class136_0 != @class && class136_0.intPoint_0.long_0 != class136_0.class136_0.intPoint_2.long_0)
						{
							this.method_14(class136_0);
						}
						class136_0 = class136_0.class136_1;
					}
					if (class136_0.double_0 == -3.4E+38 && class136_0 != @class && class136_0.intPoint_0.long_0 != class136_0.class136_0.intPoint_2.long_0)
					{
						this.method_14(class136_0);
					}
					class2 = class2.class136_1;
				}
			}
			if (class2.int_3 == -2)
			{
				class136_0 = class2;
				if (bool_3)
				{
					while (class136_0.intPoint_2.long_1 == class136_0.class136_0.intPoint_0.long_1)
					{
						class136_0 = class136_0.class136_0;
					}
					while (class136_0 != class2)
					{
						if (class136_0.double_0 != -3.4E+38)
						{
							break;
						}
						class136_0 = class136_0.class136_1;
					}
				}
				else
				{
					while (class136_0.intPoint_2.long_1 == class136_0.class136_1.intPoint_0.long_1)
					{
						class136_0 = class136_0.class136_1;
					}
					while (class136_0 != class2)
					{
						if (class136_0.double_0 != -3.4E+38)
						{
							break;
						}
						class136_0 = class136_0.class136_0;
					}
				}
				if (class136_0 == class2)
				{
					if (bool_3)
					{
						class2 = class136_0.class136_0;
					}
					else
					{
						class2 = class136_0.class136_1;
					}
				}
				else
				{
					if (bool_3)
					{
						class136_0 = class2.class136_0;
					}
					else
					{
						class136_0 = class2.class136_1;
					}
					Class139 class4 = new Class139();
					class4.class139_0 = null;
					class4.long_0 = class136_0.intPoint_0.long_1;
					class4.class136_0 = null;
					class4.class136_1 = class136_0;
					class4.class136_1.int_0 = 0;
					class2 = this.method_6(class4.class136_1, bool_3);
					this.method_12(class4);
				}
			}
			return class2;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0006DF98 File Offset: 0x0006C198
		public bool method_7(List<IntPoint> list_1, Enum20 enum20_0, bool bool_3)
		{
			if (!bool_3)
			{
				throw new Exception0("AddPath: Open paths have been disabled.");
			}
			int num = list_1.Count - 1;
			if (bool_3)
			{
				while (num > 0 && IntPoint.smethod_0(list_1[num], list_1[0]))
				{
					num--;
				}
			}
			while (num > 0 && IntPoint.smethod_0(list_1[num], list_1[num - 1]))
			{
				num--;
			}
			if ((bool_3 && num < 2) || (!bool_3 && num < 1))
			{
				return false;
			}
			List<Class136> list = new List<Class136>(num + 1);
			for (int i = 0; i <= num; i++)
			{
				list.Add(new Class136());
			}
			bool flag = true;
			list[1].intPoint_1 = list_1[1];
			this.method_2(list_1[0], ref this.bool_0);
			this.method_2(list_1[num], ref this.bool_0);
			this.method_3(list[0], list[1], list[num], list_1[0]);
			this.method_3(list[num], list[0], list[num - 1], list_1[num]);
			for (int j = num - 1; j >= 1; j--)
			{
				this.method_2(list_1[j], ref this.bool_0);
				this.method_3(list[j], list[j + 1], list[j - 1], list_1[j]);
			}
			Class136 @class = list[0];
			Class136 class2 = @class;
			Class136 class3 = @class;
			for (;;)
			{
				if (IntPoint.smethod_0(class2.intPoint_1, class2.class136_0.intPoint_1))
				{
					if (class2 == class2.class136_0)
					{
						break;
					}
					if (class2 == @class)
					{
						@class = class2.class136_0;
					}
					class2 = this.method_10(class2);
					class3 = class2;
				}
				else
				{
					if (class2.class136_1 == class2.class136_0)
					{
						break;
					}
					if (bool_3 && Class144.smethod_3(class2.class136_1.intPoint_1, class2.intPoint_1, class2.class136_0.intPoint_1, this.bool_0) && (!this.method_0() || !this.method_9(class2.class136_1.intPoint_1, class2.intPoint_1, class2.class136_0.intPoint_1)))
					{
						if (class2 == @class)
						{
							@class = class2.class136_0;
						}
						class2 = this.method_10(class2);
						class2 = class2.class136_1;
						class3 = class2;
					}
					else
					{
						class2 = class2.class136_0;
						if (class2 == class3)
						{
							break;
						}
					}
				}
			}
			if ((!bool_3 && class2 == class2.class136_0) || (bool_3 && class2.class136_1 == class2.class136_0))
			{
				return false;
			}
			if (!bool_3)
			{
				this.bool_1 = true;
				@class.class136_1.int_3 = -2;
			}
			class2 = @class;
			do
			{
				this.method_4(class2, enum20_0);
				class2 = class2.class136_0;
				if (flag && class2.intPoint_1.long_1 != @class.intPoint_1.long_1)
				{
					flag = false;
				}
			}
			while (class2 != @class);
			if (!flag)
			{
				this.list_0.Add(list);
				Class136 class4 = null;
				for (;;)
				{
					class2 = this.method_5(class2);
					if (class2 == class4)
					{
						break;
					}
					if (class4 == null)
					{
						class4 = class2;
					}
					Class139 class5 = new Class139();
					class5.class139_0 = null;
					class5.long_0 = class2.intPoint_0.long_1;
					bool flag2;
					if (class2.double_0 < class2.class136_1.double_0)
					{
						class5.class136_0 = class2.class136_1;
						class5.class136_1 = class2;
						flag2 = false;
					}
					else
					{
						class5.class136_0 = class2;
						class5.class136_1 = class2.class136_1;
						flag2 = true;
					}
					class5.class136_0.enum24_0 = Enum24.const_0;
					class5.class136_1.enum24_0 = Enum24.const_1;
					if (!bool_3)
					{
						class5.class136_0.int_0 = 0;
					}
					else if (class5.class136_0.class136_0 == class5.class136_1)
					{
						class5.class136_0.int_0 = -1;
					}
					else
					{
						class5.class136_0.int_0 = 1;
					}
					class5.class136_1.int_0 = -class5.class136_0.int_0;
					class2 = this.method_6(class5.class136_0, flag2);
					Class136 class6 = this.method_6(class5.class136_1, !flag2);
					if (class5.class136_0.int_3 == -2)
					{
						class5.class136_0 = null;
					}
					else if (class5.class136_1.int_3 == -2)
					{
						class5.class136_1 = null;
					}
					this.method_12(class5);
					if (!flag2)
					{
						class2 = class6;
					}
				}
				return true;
			}
			if (bool_3)
			{
				return false;
			}
			class2.class136_1.int_3 = -2;
			if (class2.class136_1.intPoint_0.long_0 < class2.class136_1.intPoint_2.long_0)
			{
				this.method_14(class2.class136_1);
			}
			Class139 class7 = new Class139();
			class7.class139_0 = null;
			class7.long_0 = class2.intPoint_0.long_1;
			class7.class136_0 = null;
			class7.class136_1 = class2;
			class7.class136_1.enum24_0 = Enum24.const_1;
			class7.class136_1.int_0 = 0;
			while (class2.class136_0.int_3 != -2)
			{
				class2.class136_2 = class2.class136_0;
				if (class2.intPoint_0.long_0 != class2.class136_1.intPoint_2.long_0)
				{
					this.method_14(class2);
				}
				class2 = class2.class136_0;
			}
			this.method_12(class7);
			this.list_0.Add(list);
			return true;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0006E4FC File Offset: 0x0006C6FC
		public bool method_8(List<List<IntPoint>> list_1, Enum20 enum20_0, bool bool_3)
		{
			bool result = false;
			for (int i = 0; i < list_1.Count; i++)
			{
				if (this.method_7(list_1[i], enum20_0, bool_3))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0006E530 File Offset: 0x0006C730
		internal bool method_9(IntPoint intPoint_0, IntPoint intPoint_1, IntPoint intPoint_2)
		{
			if (IntPoint.smethod_0(intPoint_0, intPoint_2) || IntPoint.smethod_0(intPoint_0, intPoint_1) || IntPoint.smethod_0(intPoint_2, intPoint_1))
			{
				return false;
			}
			if (intPoint_0.long_0 != intPoint_2.long_0)
			{
				return intPoint_1.long_0 > intPoint_0.long_0 == intPoint_1.long_0 < intPoint_2.long_0;
			}
			return intPoint_1.long_1 > intPoint_0.long_1 == intPoint_1.long_1 < intPoint_2.long_1;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0000688A File Offset: 0x00004A8A
		private Class136 method_10(Class136 class136_0)
		{
			class136_0.class136_1.class136_0 = class136_0.class136_0;
			class136_0.class136_0.class136_1 = class136_0.class136_1;
			Class136 class136_ = class136_0.class136_0;
			class136_0.class136_1 = null;
			return class136_;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0006E5A8 File Offset: 0x0006C7A8
		private void method_11(Class136 class136_0)
		{
			class136_0.intPoint_3.long_0 = class136_0.intPoint_2.long_0 - class136_0.intPoint_0.long_0;
			class136_0.intPoint_3.long_1 = class136_0.intPoint_2.long_1 - class136_0.intPoint_0.long_1;
			if (class136_0.intPoint_3.long_1 == 0L)
			{
				class136_0.double_0 = -3.4E+38;
				return;
			}
			class136_0.double_0 = (double)class136_0.intPoint_3.long_0 / (double)class136_0.intPoint_3.long_1;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0006E638 File Offset: 0x0006C838
		private void method_12(Class139 class139_2)
		{
			if (this.class139_0 == null)
			{
				this.class139_0 = class139_2;
				return;
			}
			if (class139_2.long_0 >= this.class139_0.long_0)
			{
				class139_2.class139_0 = this.class139_0;
				this.class139_0 = class139_2;
				return;
			}
			Class139 @class = this.class139_0;
			while (@class.class139_0 != null && class139_2.long_0 < @class.class139_0.long_0)
			{
				@class = @class.class139_0;
			}
			class139_2.class139_0 = @class.class139_0;
			@class.class139_0 = class139_2;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x000068BB File Offset: 0x00004ABB
		protected void method_13()
		{
			if (this.class139_1 == null)
			{
				return;
			}
			this.class139_1 = this.class139_1.class139_0;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0006E6BC File Offset: 0x0006C8BC
		private void method_14(Class136 class136_0)
		{
			long long_ = class136_0.intPoint_2.long_0;
			class136_0.intPoint_2.long_0 = class136_0.intPoint_0.long_0;
			class136_0.intPoint_0.long_0 = long_;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0006E6F8 File Offset: 0x0006C8F8
		protected virtual void vmethod_0()
		{
			this.class139_1 = this.class139_0;
			if (this.class139_1 == null)
			{
				return;
			}
			for (Class139 @class = this.class139_0; @class != null; @class = @class.class139_0)
			{
				Class136 class2 = @class.class136_0;
				if (class2 != null)
				{
					class2.intPoint_1 = class2.intPoint_0;
					class2.enum24_0 = Enum24.const_0;
					class2.int_3 = -1;
				}
				class2 = @class.class136_1;
				if (class2 != null)
				{
					class2.intPoint_1 = class2.intPoint_0;
					class2.enum24_0 = Enum24.const_1;
					class2.int_3 = -1;
				}
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0006E778 File Offset: 0x0006C978
		public static Struct20 smethod_4(List<List<IntPoint>> list_1)
		{
			int i = 0;
			int count = list_1.Count;
			while (i < count && list_1[i].Count == 0)
			{
				i++;
			}
			if (i == count)
			{
				return new Struct20(0L, 0L, 0L, 0L);
			}
			Struct20 @struct = default(Struct20);
			@struct.long_0 = list_1[i][0].long_0;
			@struct.long_2 = @struct.long_0;
			@struct.long_1 = list_1[i][0].long_1;
			@struct.long_3 = @struct.long_1;
			while (i < count)
			{
				for (int j = 0; j < list_1[i].Count; j++)
				{
					if (list_1[i][j].long_0 < @struct.long_0)
					{
						@struct.long_0 = list_1[i][j].long_0;
					}
					else if (list_1[i][j].long_0 > @struct.long_2)
					{
						@struct.long_2 = list_1[i][j].long_0;
					}
					if (list_1[i][j].long_1 < @struct.long_1)
					{
						@struct.long_1 = list_1[i][j].long_1;
					}
					else if (list_1[i][j].long_1 > @struct.long_3)
					{
						@struct.long_3 = list_1[i][j].long_1;
					}
				}
				i++;
			}
			return @struct;
		}

		// Token: 0x0400045E RID: 1118
		internal Class139 class139_0;

		// Token: 0x0400045F RID: 1119
		internal Class139 class139_1;

		// Token: 0x04000460 RID: 1120
		internal List<List<Class136>> list_0 = new List<List<Class136>>();

		// Token: 0x04000461 RID: 1121
		internal bool bool_0;

		// Token: 0x04000462 RID: 1122
		internal bool bool_1;

		// Token: 0x04000463 RID: 1123
		[CompilerGenerated]
		private bool bool_2;
	}
}
