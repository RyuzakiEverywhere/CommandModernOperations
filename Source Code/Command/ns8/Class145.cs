using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSMaterial.ClipperLib;

namespace ns8
{
	// Token: 0x020000FF RID: 255
	internal sealed class Class145 : Class144
	{
		// Token: 0x06000628 RID: 1576 RVA: 0x0006E928 File Offset: 0x0006CB28
		public Class145(int InitOptions = 0)
		{
			this.class140_0 = null;
			this.class136_0 = null;
			this.class136_1 = null;
			this.list_2 = new List<Class137>();
			this.icomparer_0 = new Class138();
			this.bool_3 = false;
			this.bool_4 = false;
			this.list_1 = new List<Class141>();
			this.list_3 = new List<Class143>();
			this.list_4 = new List<Class143>();
			this.method_16((1 & InitOptions) != 0);
			this.method_18((2 & InitOptions) != 0);
			base.method_1((4 & InitOptions) != 0);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0006E9BC File Offset: 0x0006CBBC
		protected override void vmethod_0()
		{
			base.vmethod_0();
			this.class140_0 = null;
			this.class136_0 = null;
			this.class136_1 = null;
			for (Class139 class139_ = this.class139_0; class139_ != null; class139_ = class139_.class139_0)
			{
				this.method_19(class139_.long_0);
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000068D7 File Offset: 0x00004AD7
		[CompilerGenerated]
		public bool method_15()
		{
			return this.bool_5;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000068DF File Offset: 0x00004ADF
		[CompilerGenerated]
		public void method_16(bool bool_7)
		{
			this.bool_5 = bool_7;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x000068E8 File Offset: 0x00004AE8
		[CompilerGenerated]
		public bool method_17()
		{
			return this.bool_6;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x000068F0 File Offset: 0x00004AF0
		[CompilerGenerated]
		public void method_18(bool bool_7)
		{
			this.bool_6 = bool_7;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0006EA04 File Offset: 0x0006CC04
		private void method_19(long long_0)
		{
			if (this.class140_0 == null)
			{
				this.class140_0 = new Class140();
				this.class140_0.class140_0 = null;
				this.class140_0.long_0 = long_0;
				return;
			}
			if (long_0 > this.class140_0.long_0)
			{
				this.class140_0 = new Class140
				{
					long_0 = long_0,
					class140_0 = this.class140_0
				};
				return;
			}
			Class140 @class = this.class140_0;
			while (@class.class140_0 != null && long_0 <= @class.class140_0.long_0)
			{
				@class = @class.class140_0;
			}
			if (long_0 == @class.long_0)
			{
				return;
			}
			@class.class140_0 = new Class140
			{
				long_0 = long_0,
				class140_0 = @class.class140_0
			};
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0006EABC File Offset: 0x0006CCBC
		public bool method_20(Enum19 enum19_1, List<List<IntPoint>> list_5, Enum21 enum21_2, Enum21 enum21_3)
		{
			if (this.bool_3)
			{
				return false;
			}
			if (this.bool_1)
			{
				throw new Exception0("Error: PolyTree struct is need for open path clipping.");
			}
			this.bool_3 = true;
			list_5.Clear();
			this.enum21_1 = enum21_2;
			this.enum21_0 = enum21_3;
			this.enum19_0 = enum19_1;
			this.bool_4 = false;
			bool result;
			try
			{
				if (result = this.method_21())
				{
					this.method_74(list_5);
				}
			}
			finally
			{
				this.method_23();
				this.bool_3 = false;
			}
			return result;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0006EB44 File Offset: 0x0006CD44
		private bool method_21()
		{
			bool result;
			try
			{
				this.vmethod_0();
				if (this.class139_1 == null)
				{
					result = false;
				}
				else
				{
					long long_ = this.method_22();
					for (;;)
					{
						this.method_28(long_);
						this.list_4.Clear();
						this.method_57(false);
						if (this.class140_0 == null)
						{
							goto IL_72;
						}
						long num = this.method_22();
						if (!this.method_65(long_, num))
						{
							break;
						}
						this.method_71(num);
						long_ = num;
						if (this.class140_0 == null && this.class139_1 == null)
						{
							goto IL_72;
						}
					}
					return false;
					IL_72:
					for (int i = 0; i < this.list_1.Count; i++)
					{
						Class141 @class = this.list_1[i];
						if (@class.class142_0 != null && !@class.bool_1 && (@class.bool_0 ^ this.method_15()) == this.method_87(@class) > 0.0)
						{
							this.method_52(@class.class142_0);
						}
					}
					this.method_84();
					for (int j = 0; j < this.list_1.Count; j++)
					{
						Class141 class2 = this.list_1[j];
						if (class2.class142_0 != null && !class2.bool_1)
						{
							this.method_75(class2);
						}
					}
					if (this.method_17())
					{
						this.method_86();
					}
					result = true;
				}
			}
			finally
			{
				this.list_3.Clear();
				this.list_4.Clear();
			}
			return result;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x000068F9 File Offset: 0x00004AF9
		private long method_22()
		{
			long long_ = this.class140_0.long_0;
			this.class140_0 = this.class140_0.class140_0;
			return long_;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0006ECB8 File Offset: 0x0006CEB8
		private void method_23()
		{
			for (int i = 0; i < this.list_1.Count; i++)
			{
				this.method_24(i);
			}
			this.list_1.Clear();
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0006ECF0 File Offset: 0x0006CEF0
		private void method_24(int int_0)
		{
			Class141 @class = this.list_1[int_0];
			if (@class.class142_0 != null)
			{
				this.method_25(@class.class142_0);
			}
			this.list_1[int_0] = null;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00006917 File Offset: 0x00004B17
		private void method_25(Class142 class142_0)
		{
			if (class142_0 == null)
			{
				return;
			}
			class142_0.class142_1.class142_0 = null;
			while (class142_0 != null)
			{
				class142_0 = class142_0.class142_0;
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0006ED30 File Offset: 0x0006CF30
		private void method_26(Class142 class142_0, Class142 class142_1, IntPoint intPoint_0)
		{
			Class143 @class = new Class143();
			@class.class142_0 = class142_0;
			@class.class142_1 = class142_1;
			@class.intPoint_0 = intPoint_0;
			this.list_3.Add(@class);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0006ED64 File Offset: 0x0006CF64
		private void method_27(Class142 class142_0, IntPoint intPoint_0)
		{
			Class143 @class = new Class143();
			@class.class142_0 = class142_0;
			@class.intPoint_0 = intPoint_0;
			this.list_4.Add(@class);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0006ED94 File Offset: 0x0006CF94
		private void method_28(long long_0)
		{
			while (this.class139_1 != null)
			{
				if (this.class139_1.long_0 != long_0)
				{
					break;
				}
				Class136 @class = this.class139_1.class136_0;
				Class136 class2 = this.class139_1.class136_1;
				base.method_13();
				Class142 class3 = null;
				if (@class == null)
				{
					this.method_29(class2, null);
					this.method_34(class2);
					if (this.method_33(class2))
					{
						class3 = this.method_42(class2, class2.intPoint_0);
					}
				}
				else if (class2 == null)
				{
					this.method_29(@class, null);
					this.method_34(@class);
					if (this.method_33(@class))
					{
						class3 = this.method_42(@class, @class.intPoint_0);
					}
					this.method_19(@class.intPoint_2.long_1);
				}
				else
				{
					this.method_29(@class, null);
					this.method_29(class2, @class);
					this.method_34(@class);
					class2.int_1 = @class.int_1;
					class2.int_2 = @class.int_2;
					if (this.method_33(@class))
					{
						class3 = this.method_40(@class, class2, @class.intPoint_0);
					}
					this.method_19(@class.intPoint_2.long_1);
				}
				if (class2 != null)
				{
					if (Class144.smethod_1(class2))
					{
						this.method_35(class2);
					}
					else
					{
						this.method_19(class2.intPoint_2.long_1);
					}
				}
				if (@class != null && class2 != null)
				{
					if (class3 != null && Class144.smethod_1(class2) && this.list_4.Count > 0 && class2.int_0 != 0)
					{
						for (int i = 0; i < this.list_4.Count; i++)
						{
							Class143 class4 = this.list_4[i];
							if (this.method_43(class4.class142_0.intPoint_0, class4.intPoint_0, class2.intPoint_0, class2.intPoint_2))
							{
								this.method_26(class4.class142_0, class3, class4.intPoint_0);
							}
						}
					}
					if (@class.int_3 >= 0 && @class.class136_4 != null && @class.class136_4.intPoint_1.long_0 == @class.intPoint_0.long_0 && @class.class136_4.int_3 >= 0 && Class144.smethod_2(@class.class136_4, @class, this.bool_0) && @class.int_0 != 0 && @class.class136_4.int_0 != 0)
					{
						Class142 class142_ = this.method_42(@class.class136_4, @class.intPoint_0);
						this.method_26(class3, class142_, @class.intPoint_2);
					}
					if (@class.class136_3 != class2)
					{
						if (class2.int_3 >= 0 && class2.class136_4.int_3 >= 0 && Class144.smethod_2(class2.class136_4, class2, this.bool_0) && class2.int_0 != 0 && class2.class136_4.int_0 != 0)
						{
							Class142 class142_2 = this.method_42(class2.class136_4, class2.intPoint_0);
							this.method_26(class3, class142_2, class2.intPoint_2);
						}
						Class136 class136_ = @class.class136_3;
						if (class136_ != null)
						{
							while (class136_ != class2)
							{
								this.method_53(class2, class136_, @class.intPoint_1, false);
								class136_ = class136_.class136_3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0006F080 File Offset: 0x0006D280
		private void method_29(Class136 class136_2, Class136 class136_3)
		{
			if (this.class136_0 == null)
			{
				class136_2.class136_4 = null;
				class136_2.class136_3 = null;
				this.class136_0 = class136_2;
				return;
			}
			if (class136_3 == null && this.method_30(this.class136_0, class136_2))
			{
				class136_2.class136_4 = null;
				class136_2.class136_3 = this.class136_0;
				this.class136_0.class136_4 = class136_2;
				this.class136_0 = class136_2;
				return;
			}
			if (class136_3 == null)
			{
				class136_3 = this.class136_0;
			}
			while (class136_3.class136_3 != null && !this.method_30(class136_3.class136_3, class136_2))
			{
				class136_3 = class136_3.class136_3;
			}
			class136_2.class136_3 = class136_3.class136_3;
			if (class136_3.class136_3 != null)
			{
				class136_3.class136_3.class136_4 = class136_2;
			}
			class136_2.class136_4 = class136_3;
			class136_3.class136_3 = class136_2;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0006F140 File Offset: 0x0006D340
		private bool method_30(Class136 class136_2, Class136 class136_3)
		{
			if (class136_3.intPoint_1.long_0 != class136_2.intPoint_1.long_0)
			{
				return class136_3.intPoint_1.long_0 < class136_2.intPoint_1.long_0;
			}
			if (class136_3.intPoint_2.long_1 > class136_2.intPoint_2.long_1)
			{
				return class136_3.intPoint_2.long_0 < Class145.smethod_8(class136_2, class136_3.intPoint_2.long_1);
			}
			return class136_2.intPoint_2.long_0 > Class145.smethod_8(class136_3, class136_2.intPoint_2.long_1);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00006936 File Offset: 0x00004B36
		private bool method_31(Class136 class136_2)
		{
			if (class136_2.enum20_0 == Enum20.const_0)
			{
				return this.enum21_1 == Enum21.const_0;
			}
			return this.enum21_0 == Enum21.const_0;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00006953 File Offset: 0x00004B53
		private bool method_32(Class136 class136_2)
		{
			if (class136_2.enum20_0 == Enum20.const_0)
			{
				return this.enum21_0 == Enum21.const_0;
			}
			return this.enum21_1 == Enum21.const_0;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0006F1D4 File Offset: 0x0006D3D4
		private bool method_33(Class136 class136_2)
		{
			Enum21 @enum;
			Enum21 enum2;
			if (class136_2.enum20_0 == Enum20.const_0)
			{
				@enum = this.enum21_1;
				enum2 = this.enum21_0;
			}
			else
			{
				@enum = this.enum21_0;
				enum2 = this.enum21_1;
			}
			switch (@enum)
			{
			case Enum21.const_0:
				if (class136_2.int_0 == 0 && class136_2.int_1 != 1)
				{
					return false;
				}
				break;
			case Enum21.const_1:
				if (Math.Abs(class136_2.int_1) != 1)
				{
					return false;
				}
				break;
			case Enum21.const_2:
				if (class136_2.int_1 != 1)
				{
					return false;
				}
				break;
			default:
				if (class136_2.int_1 != -1)
				{
					return false;
				}
				break;
			}
			switch (this.enum19_0)
			{
			case Enum19.const_0:
				if (enum2 <= Enum21.const_1)
				{
					return class136_2.int_2 != 0;
				}
				if (enum2 != Enum21.const_2)
				{
					return class136_2.int_2 < 0;
				}
				return class136_2.int_2 > 0;
			case Enum19.const_1:
				if (enum2 <= Enum21.const_1)
				{
					return class136_2.int_2 == 0;
				}
				if (enum2 != Enum21.const_2)
				{
					return class136_2.int_2 >= 0;
				}
				return class136_2.int_2 <= 0;
			case Enum19.const_2:
				if (class136_2.enum20_0 == Enum20.const_0)
				{
					if (enum2 <= Enum21.const_1)
					{
						return class136_2.int_2 == 0;
					}
					if (enum2 != Enum21.const_2)
					{
						return class136_2.int_2 >= 0;
					}
					return class136_2.int_2 <= 0;
				}
				else
				{
					if (enum2 <= Enum21.const_1)
					{
						return class136_2.int_2 != 0;
					}
					if (enum2 != Enum21.const_2)
					{
						return class136_2.int_2 < 0;
					}
					return class136_2.int_2 > 0;
				}
				break;
			case Enum19.const_3:
				if (class136_2.int_0 != 0)
				{
					return true;
				}
				if (enum2 <= Enum21.const_1)
				{
					return class136_2.int_2 == 0;
				}
				if (enum2 != Enum21.const_2)
				{
					return class136_2.int_2 >= 0;
				}
				return class136_2.int_2 <= 0;
			default:
				return true;
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0006F354 File Offset: 0x0006D554
		private void method_34(Class136 class136_2)
		{
			Class136 @class = class136_2.class136_4;
			while (@class != null && (@class.enum20_0 != class136_2.enum20_0 || @class.int_0 == 0))
			{
				@class = @class.class136_4;
			}
			if (@class == null)
			{
				class136_2.int_1 = ((class136_2.int_0 == 0) ? 1 : class136_2.int_0);
				class136_2.int_2 = 0;
				@class = this.class136_0;
			}
			else if (class136_2.int_0 == 0 && this.enum19_0 != Enum19.const_1)
			{
				class136_2.int_1 = 1;
				class136_2.int_2 = @class.int_2;
				@class = @class.class136_3;
			}
			else if (this.method_31(class136_2))
			{
				if (class136_2.int_0 == 0)
				{
					bool flag = true;
					for (Class136 class136_3 = @class.class136_4; class136_3 != null; class136_3 = class136_3.class136_4)
					{
						if (class136_3.enum20_0 == @class.enum20_0 && class136_3.int_0 != 0)
						{
							flag = !flag;
						}
					}
					class136_2.int_1 = (flag ? 0 : 1);
				}
				else
				{
					class136_2.int_1 = class136_2.int_0;
				}
				class136_2.int_2 = @class.int_2;
				@class = @class.class136_3;
			}
			else
			{
				if (@class.int_1 * @class.int_0 < 0)
				{
					if (Math.Abs(@class.int_1) > 1)
					{
						if (@class.int_0 * class136_2.int_0 < 0)
						{
							class136_2.int_1 = @class.int_1;
						}
						else
						{
							class136_2.int_1 = @class.int_1 + class136_2.int_0;
						}
					}
					else
					{
						class136_2.int_1 = ((class136_2.int_0 == 0) ? 1 : class136_2.int_0);
					}
				}
				else if (class136_2.int_0 == 0)
				{
					class136_2.int_1 = ((@class.int_1 < 0) ? (@class.int_1 - 1) : (@class.int_1 + 1));
				}
				else if (@class.int_0 * class136_2.int_0 < 0)
				{
					class136_2.int_1 = @class.int_1;
				}
				else
				{
					class136_2.int_1 = @class.int_1 + class136_2.int_0;
				}
				class136_2.int_2 = @class.int_2;
				@class = @class.class136_3;
			}
			if (this.method_32(class136_2))
			{
				while (@class != class136_2)
				{
					if (@class.int_0 != 0)
					{
						class136_2.int_2 = ((class136_2.int_2 == 0) ? 1 : 0);
					}
					@class = @class.class136_3;
				}
				return;
			}
			while (@class != class136_2)
			{
				class136_2.int_2 += @class.int_0;
				@class = @class.class136_3;
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0006F588 File Offset: 0x0006D788
		private void method_35(Class136 class136_2)
		{
			if (this.class136_1 == null)
			{
				this.class136_1 = class136_2;
				class136_2.class136_6 = null;
				class136_2.class136_5 = null;
				return;
			}
			class136_2.class136_5 = this.class136_1;
			class136_2.class136_6 = null;
			this.class136_1.class136_6 = class136_2;
			this.class136_1 = class136_2;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0006F5DC File Offset: 0x0006D7DC
		private void method_36()
		{
			Class136 class136_ = this.class136_0;
			this.class136_1 = class136_;
			while (class136_ != null)
			{
				class136_.class136_6 = class136_.class136_4;
				class136_.class136_5 = class136_.class136_3;
				class136_ = class136_.class136_3;
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0006F61C File Offset: 0x0006D81C
		private void method_37(Class136 class136_2, Class136 class136_3)
		{
			if (class136_2.class136_3 != class136_2.class136_4)
			{
				if (class136_3.class136_3 != class136_3.class136_4)
				{
					if (class136_2.class136_3 == class136_3)
					{
						Class136 class136_4 = class136_3.class136_3;
						if (class136_4 != null)
						{
							class136_4.class136_4 = class136_2;
						}
						Class136 class136_5 = class136_2.class136_4;
						if (class136_5 != null)
						{
							class136_5.class136_3 = class136_3;
						}
						class136_3.class136_4 = class136_5;
						class136_3.class136_3 = class136_2;
						class136_2.class136_4 = class136_3;
						class136_2.class136_3 = class136_4;
					}
					else if (class136_3.class136_3 == class136_2)
					{
						Class136 class136_6 = class136_2.class136_3;
						if (class136_6 != null)
						{
							class136_6.class136_4 = class136_3;
						}
						Class136 class136_7 = class136_3.class136_4;
						if (class136_7 != null)
						{
							class136_7.class136_3 = class136_2;
						}
						class136_2.class136_4 = class136_7;
						class136_2.class136_3 = class136_3;
						class136_3.class136_4 = class136_2;
						class136_3.class136_3 = class136_6;
					}
					else
					{
						Class136 class136_8 = class136_2.class136_3;
						Class136 class136_9 = class136_2.class136_4;
						class136_2.class136_3 = class136_3.class136_3;
						if (class136_2.class136_3 != null)
						{
							class136_2.class136_3.class136_4 = class136_2;
						}
						class136_2.class136_4 = class136_3.class136_4;
						if (class136_2.class136_4 != null)
						{
							class136_2.class136_4.class136_3 = class136_2;
						}
						class136_3.class136_3 = class136_8;
						if (class136_3.class136_3 != null)
						{
							class136_3.class136_3.class136_4 = class136_3;
						}
						class136_3.class136_4 = class136_9;
						if (class136_3.class136_4 != null)
						{
							class136_3.class136_4.class136_3 = class136_3;
						}
					}
					if (class136_2.class136_4 == null)
					{
						this.class136_0 = class136_2;
						return;
					}
					if (class136_3.class136_4 == null)
					{
						this.class136_0 = class136_3;
					}
					return;
				}
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0006F790 File Offset: 0x0006D990
		private void method_38(Class136 class136_2, Class136 class136_3)
		{
			if (class136_2.class136_5 == null && class136_2.class136_6 == null)
			{
				return;
			}
			if (class136_3.class136_5 == null && class136_3.class136_6 == null)
			{
				return;
			}
			if (class136_2.class136_5 == class136_3)
			{
				Class136 class136_4 = class136_3.class136_5;
				if (class136_4 != null)
				{
					class136_4.class136_6 = class136_2;
				}
				Class136 class136_5 = class136_2.class136_6;
				if (class136_5 != null)
				{
					class136_5.class136_5 = class136_3;
				}
				class136_3.class136_6 = class136_5;
				class136_3.class136_5 = class136_2;
				class136_2.class136_6 = class136_3;
				class136_2.class136_5 = class136_4;
			}
			else if (class136_3.class136_5 == class136_2)
			{
				Class136 class136_6 = class136_2.class136_5;
				if (class136_6 != null)
				{
					class136_6.class136_6 = class136_3;
				}
				Class136 class136_7 = class136_3.class136_6;
				if (class136_7 != null)
				{
					class136_7.class136_5 = class136_2;
				}
				class136_2.class136_6 = class136_7;
				class136_2.class136_5 = class136_3;
				class136_3.class136_6 = class136_2;
				class136_3.class136_5 = class136_6;
			}
			else
			{
				Class136 class136_8 = class136_2.class136_5;
				Class136 class136_9 = class136_2.class136_6;
				class136_2.class136_5 = class136_3.class136_5;
				if (class136_2.class136_5 != null)
				{
					class136_2.class136_5.class136_6 = class136_2;
				}
				class136_2.class136_6 = class136_3.class136_6;
				if (class136_2.class136_6 != null)
				{
					class136_2.class136_6.class136_5 = class136_2;
				}
				class136_3.class136_5 = class136_8;
				if (class136_3.class136_5 != null)
				{
					class136_3.class136_5.class136_6 = class136_3;
				}
				class136_3.class136_6 = class136_9;
				if (class136_3.class136_6 != null)
				{
					class136_3.class136_6.class136_5 = class136_3;
				}
			}
			if (class136_2.class136_6 == null)
			{
				this.class136_1 = class136_2;
				return;
			}
			if (class136_3.class136_6 == null)
			{
				this.class136_1 = class136_3;
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0006F900 File Offset: 0x0006DB00
		private void method_39(Class136 class136_2, Class136 class136_3, IntPoint intPoint_0)
		{
			this.method_42(class136_2, intPoint_0);
			if (class136_3.int_0 == 0)
			{
				this.method_42(class136_3, intPoint_0);
			}
			if (class136_2.int_3 == class136_3.int_3)
			{
				class136_2.int_3 = -1;
				class136_3.int_3 = -1;
				return;
			}
			if (class136_2.int_3 < class136_3.int_3)
			{
				this.method_51(class136_2, class136_3);
				return;
			}
			this.method_51(class136_3, class136_2);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0006F964 File Offset: 0x0006DB64
		private Class142 method_40(Class136 class136_2, Class136 class136_3, IntPoint intPoint_0)
		{
			Class142 @class;
			Class136 class2;
			Class136 class136_4;
			if (!Class144.smethod_1(class136_3) && class136_2.double_0 <= class136_3.double_0)
			{
				@class = this.method_42(class136_3, intPoint_0);
				class136_2.int_3 = class136_3.int_3;
				class136_2.enum24_0 = Enum24.const_1;
				class136_3.enum24_0 = Enum24.const_0;
				class2 = class136_3;
				if (class2.class136_4 == class136_2)
				{
					class136_4 = class136_2.class136_4;
				}
				else
				{
					class136_4 = class2.class136_4;
				}
			}
			else
			{
				@class = this.method_42(class136_2, intPoint_0);
				class136_3.int_3 = class136_2.int_3;
				class136_2.enum24_0 = Enum24.const_0;
				class136_3.enum24_0 = Enum24.const_1;
				class2 = class136_2;
				if (class2.class136_4 == class136_3)
				{
					class136_4 = class136_3.class136_4;
				}
				else
				{
					class136_4 = class2.class136_4;
				}
			}
			if (class136_4 != null && class136_4.int_3 >= 0 && Class145.smethod_8(class136_4, intPoint_0.long_1) == Class145.smethod_8(class2, intPoint_0.long_1) && Class144.smethod_2(class2, class136_4, this.bool_0) && class2.int_0 != 0 && class136_4.int_0 != 0)
			{
				Class142 class142_ = this.method_42(class136_4, intPoint_0);
				this.method_26(@class, class142_, class2.intPoint_2);
			}
			return @class;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0006FA64 File Offset: 0x0006DC64
		private Class141 method_41()
		{
			Class141 @class = new Class141();
			@class.int_0 = -1;
			@class.bool_0 = false;
			@class.bool_1 = false;
			@class.class141_0 = null;
			@class.class142_0 = null;
			@class.class142_1 = null;
			@class.class135_0 = null;
			this.list_1.Add(@class);
			@class.int_0 = this.list_1.Count - 1;
			return @class;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0006FAC8 File Offset: 0x0006DCC8
		private Class142 method_42(Class136 class136_2, IntPoint intPoint_0)
		{
			bool flag = class136_2.enum24_0 == Enum24.const_0;
			if (class136_2.int_3 < 0)
			{
				Class141 @class = this.method_41();
				@class.bool_1 = (class136_2.int_0 == 0);
				Class142 class2 = new Class142();
				@class.class142_0 = class2;
				class2.int_0 = @class.int_0;
				class2.intPoint_0 = intPoint_0;
				class2.class142_0 = class2;
				class2.class142_1 = class2;
				if (!@class.bool_1)
				{
					this.method_44(class136_2, @class);
				}
				class136_2.int_3 = @class.int_0;
				return class2;
			}
			Class141 class3 = this.list_1[class136_2.int_3];
			Class142 class142_ = class3.class142_0;
			if (flag && IntPoint.smethod_0(intPoint_0, class142_.intPoint_0))
			{
				return class142_;
			}
			if (!flag && IntPoint.smethod_0(intPoint_0, class142_.class142_1.intPoint_0))
			{
				return class142_.class142_1;
			}
			Class142 class4 = new Class142();
			class4.int_0 = class3.int_0;
			class4.intPoint_0 = intPoint_0;
			class4.class142_0 = class142_;
			class4.class142_1 = class142_.class142_1;
			class4.class142_1.class142_0 = class4;
			class142_.class142_1 = class4;
			if (flag)
			{
				class3.class142_0 = class4;
			}
			return class4;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0006FBF0 File Offset: 0x0006DDF0
		private bool method_43(IntPoint intPoint_0, IntPoint intPoint_1, IntPoint intPoint_2, IntPoint intPoint_3)
		{
			return intPoint_0.long_0 > intPoint_2.long_0 == intPoint_0.long_0 < intPoint_3.long_0 || intPoint_1.long_0 > intPoint_2.long_0 == intPoint_1.long_0 < intPoint_3.long_0 || intPoint_2.long_0 > intPoint_0.long_0 == intPoint_2.long_0 < intPoint_1.long_0 || intPoint_3.long_0 > intPoint_0.long_0 == intPoint_3.long_0 < intPoint_1.long_0 || (intPoint_0.long_0 == intPoint_2.long_0 && intPoint_1.long_0 == intPoint_3.long_0) || (intPoint_0.long_0 == intPoint_3.long_0 && intPoint_1.long_0 == intPoint_2.long_0);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0006FCC0 File Offset: 0x0006DEC0
		private void method_44(Class136 class136_2, Class141 class141_0)
		{
			bool flag = false;
			for (Class136 class136_3 = class136_2.class136_4; class136_3 != null; class136_3 = class136_3.class136_4)
			{
				if (class136_3.int_3 >= 0 && class136_3.int_0 != 0)
				{
					flag = !flag;
					if (class141_0.class141_0 == null)
					{
						class141_0.class141_0 = this.list_1[class136_3.int_3];
					}
				}
			}
			if (flag)
			{
				class141_0.bool_0 = true;
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00006970 File Offset: 0x00004B70
		private double method_45(IntPoint intPoint_0, IntPoint intPoint_1)
		{
			if (intPoint_0.long_1 == intPoint_1.long_1)
			{
				return -3.4E+38;
			}
			return (double)(intPoint_1.long_0 - intPoint_0.long_0) / (double)(intPoint_1.long_1 - intPoint_0.long_1);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0006FD24 File Offset: 0x0006DF24
		private bool method_46(Class142 class142_0, Class142 class142_1)
		{
			Class142 @class = class142_0.class142_1;
			while (IntPoint.smethod_0(@class.intPoint_0, class142_0.intPoint_0))
			{
				if (@class == class142_0)
				{
					break;
				}
				@class = @class.class142_1;
			}
			double num = Math.Abs(this.method_45(class142_0.intPoint_0, @class.intPoint_0));
			@class = class142_0.class142_0;
			while (IntPoint.smethod_0(@class.intPoint_0, class142_0.intPoint_0))
			{
				if (@class == class142_0)
				{
					break;
				}
				@class = @class.class142_0;
			}
			double num2 = Math.Abs(this.method_45(class142_0.intPoint_0, @class.intPoint_0));
			@class = class142_1.class142_1;
			while (IntPoint.smethod_0(@class.intPoint_0, class142_1.intPoint_0))
			{
				if (@class == class142_1)
				{
					break;
				}
				@class = @class.class142_1;
			}
			double num3 = Math.Abs(this.method_45(class142_1.intPoint_0, @class.intPoint_0));
			@class = class142_1.class142_0;
			while (IntPoint.smethod_0(@class.intPoint_0, class142_1.intPoint_0))
			{
				if (@class == class142_1)
				{
					break;
				}
				@class = @class.class142_0;
			}
			double num4 = Math.Abs(this.method_45(class142_1.intPoint_0, @class.intPoint_0));
			return (num >= num3 && num >= num4) || (num2 >= num3 && num2 >= num4);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0006FE50 File Offset: 0x0006E050
		private Class142 method_47(Class142 class142_0)
		{
			Class142 @class = null;
			Class142 class142_;
			for (class142_ = class142_0.class142_0; class142_ != class142_0; class142_ = class142_.class142_0)
			{
				if (class142_.intPoint_0.long_1 > class142_0.intPoint_0.long_1)
				{
					class142_0 = class142_;
					@class = null;
				}
				else if (class142_.intPoint_0.long_1 == class142_0.intPoint_0.long_1 && class142_.intPoint_0.long_0 <= class142_0.intPoint_0.long_0)
				{
					if (class142_.intPoint_0.long_0 < class142_0.intPoint_0.long_0)
					{
						@class = null;
						class142_0 = class142_;
					}
					else if (class142_.class142_0 != class142_0 && class142_.class142_1 != class142_0)
					{
						@class = class142_;
					}
				}
			}
			if (@class != null)
			{
				while (@class != class142_)
				{
					if (!this.method_46(class142_, @class))
					{
						class142_0 = @class;
					}
					@class = @class.class142_0;
					while (IntPoint.smethod_1(@class.intPoint_0, class142_0.intPoint_0))
					{
						@class = @class.class142_0;
					}
				}
			}
			return class142_0;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0006FF38 File Offset: 0x0006E138
		private Class141 method_48(Class141 class141_0, Class141 class141_1)
		{
			if (class141_0.class142_1 == null)
			{
				class141_0.class142_1 = this.method_47(class141_0.class142_0);
			}
			if (class141_1.class142_1 == null)
			{
				class141_1.class142_1 = this.method_47(class141_1.class142_0);
			}
			Class142 class142_ = class141_0.class142_1;
			Class142 class142_2 = class141_1.class142_1;
			if (class142_.intPoint_0.long_1 > class142_2.intPoint_0.long_1)
			{
				return class141_0;
			}
			if (class142_.intPoint_0.long_1 < class142_2.intPoint_0.long_1)
			{
				return class141_1;
			}
			if (class142_.intPoint_0.long_0 < class142_2.intPoint_0.long_0)
			{
				return class141_0;
			}
			if (class142_.intPoint_0.long_0 > class142_2.intPoint_0.long_0)
			{
				return class141_1;
			}
			if (class142_.class142_0 == class142_)
			{
				return class141_1;
			}
			if (class142_2.class142_0 == class142_2)
			{
				return class141_0;
			}
			if (this.method_46(class142_, class142_2))
			{
				return class141_0;
			}
			return class141_1;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000069A7 File Offset: 0x00004BA7
		private bool method_49(Class141 class141_0, Class141 class141_1)
		{
			for (;;)
			{
				class141_0 = class141_0.class141_0;
				if (class141_0 == class141_1)
				{
					break;
				}
				if (class141_0 == null)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00070014 File Offset: 0x0006E214
		private Class141 method_50(int int_0)
		{
			Class141 @class;
			for (@class = this.list_1[int_0]; @class != this.list_1[@class.int_0]; @class = this.list_1[@class.int_0])
			{
			}
			return @class;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00070058 File Offset: 0x0006E258
		private void method_51(Class136 class136_2, Class136 class136_3)
		{
			Class141 @class = this.list_1[class136_2.int_3];
			Class141 class2 = this.list_1[class136_3.int_3];
			Class141 class3;
			if (this.method_49(@class, class2))
			{
				class3 = class2;
			}
			else if (this.method_49(class2, @class))
			{
				class3 = @class;
			}
			else
			{
				class3 = this.method_48(@class, class2);
			}
			Class142 class142_ = @class.class142_0;
			Class142 class142_2 = class142_.class142_1;
			Class142 class142_3 = class2.class142_0;
			Class142 class142_4 = class142_3.class142_1;
			Enum24 enum24_;
			if (class136_2.enum24_0 == Enum24.const_0)
			{
				if (class136_3.enum24_0 == Enum24.const_0)
				{
					this.method_52(class142_3);
					class142_3.class142_0 = class142_;
					class142_.class142_1 = class142_3;
					class142_2.class142_0 = class142_4;
					class142_4.class142_1 = class142_2;
					@class.class142_0 = class142_4;
				}
				else
				{
					class142_4.class142_0 = class142_;
					class142_.class142_1 = class142_4;
					class142_3.class142_1 = class142_2;
					class142_2.class142_0 = class142_3;
					@class.class142_0 = class142_3;
				}
				enum24_ = Enum24.const_0;
			}
			else
			{
				if (class136_3.enum24_0 == Enum24.const_1)
				{
					this.method_52(class142_3);
					class142_2.class142_0 = class142_4;
					class142_4.class142_1 = class142_2;
					class142_3.class142_0 = class142_;
					class142_.class142_1 = class142_3;
				}
				else
				{
					class142_2.class142_0 = class142_3;
					class142_3.class142_1 = class142_2;
					class142_.class142_1 = class142_4;
					class142_4.class142_0 = class142_;
				}
				enum24_ = Enum24.const_1;
			}
			@class.class142_1 = null;
			if (class3 == class2)
			{
				if (class2.class141_0 != @class)
				{
					@class.class141_0 = class2.class141_0;
				}
				@class.bool_0 = class2.bool_0;
			}
			class2.class142_0 = null;
			class2.class142_1 = null;
			class2.class141_0 = @class;
			int int_ = class136_2.int_3;
			int int_2 = class136_3.int_3;
			class136_2.int_3 = -1;
			class136_3.int_3 = -1;
			for (Class136 class136_4 = this.class136_0; class136_4 != null; class136_4 = class136_4.class136_3)
			{
				if (class136_4.int_3 == int_2)
				{
					class136_4.int_3 = int_;
					class136_4.enum24_0 = enum24_;
					IL_1CD:
					class2.int_0 = @class.int_0;
					return;
				}
			}
			goto IL_1CD;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00070240 File Offset: 0x0006E440
		private void method_52(Class142 class142_0)
		{
			if (class142_0 == null)
			{
				return;
			}
			Class142 @class = class142_0;
			do
			{
				Class142 class142_ = @class.class142_0;
				@class.class142_0 = @class.class142_1;
				@class.class142_1 = class142_;
				@class = class142_;
			}
			while (@class != class142_0);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00070274 File Offset: 0x0006E474
		private static void smethod_5(Class136 class136_2, Class136 class136_3)
		{
			Enum24 enum24_ = class136_2.enum24_0;
			class136_2.enum24_0 = class136_3.enum24_0;
			class136_3.enum24_0 = enum24_;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0007029C File Offset: 0x0006E49C
		private static void smethod_6(Class136 class136_2, Class136 class136_3)
		{
			int int_ = class136_2.int_3;
			class136_2.int_3 = class136_3.int_3;
			class136_3.int_3 = int_;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000702C4 File Offset: 0x0006E4C4
		private void method_53(Class136 e1, Class136 e2, IntPoint pt, bool protect = false)
		{
			bool flag = !protect && e1.class136_2 == null && e1.intPoint_2.long_0 == pt.long_0 && e1.intPoint_2.long_1 == pt.long_1;
			bool flag2 = !protect && e2.class136_2 == null && e2.intPoint_2.long_0 == pt.long_0 && e2.intPoint_2.long_1 == pt.long_1;
			bool flag3 = e1.int_3 >= 0;
			bool flag4 = e2.int_3 >= 0;
			if (e1.enum20_0 == e2.enum20_0)
			{
				if (this.method_31(e1))
				{
					int int_ = e1.int_1;
					e1.int_1 = e2.int_1;
					e2.int_1 = int_;
				}
				else
				{
					if (e1.int_1 + e2.int_0 == 0)
					{
						e1.int_1 = -e1.int_1;
					}
					else
					{
						e1.int_1 += e2.int_0;
					}
					if (e2.int_1 - e1.int_0 == 0)
					{
						e2.int_1 = -e2.int_1;
					}
					else
					{
						e2.int_1 -= e1.int_0;
					}
				}
			}
			else
			{
				if (!this.method_31(e2))
				{
					e1.int_2 += e2.int_0;
				}
				else
				{
					e1.int_2 = ((e1.int_2 == 0) ? 1 : 0);
				}
				if (!this.method_31(e1))
				{
					e2.int_2 -= e1.int_0;
				}
				else
				{
					e2.int_2 = ((e2.int_2 == 0) ? 1 : 0);
				}
			}
			Enum21 @enum;
			Enum21 enum2;
			if (e1.enum20_0 == Enum20.const_0)
			{
				@enum = this.enum21_1;
				enum2 = this.enum21_0;
			}
			else
			{
				@enum = this.enum21_0;
				enum2 = this.enum21_1;
			}
			Enum21 enum3;
			Enum21 enum4;
			if (e2.enum20_0 == Enum20.const_0)
			{
				enum3 = this.enum21_1;
				enum4 = this.enum21_0;
			}
			else
			{
				enum3 = this.enum21_0;
				enum4 = this.enum21_1;
			}
			int num;
			if (@enum != Enum21.const_2)
			{
				if (@enum != Enum21.const_3)
				{
					num = Math.Abs(e1.int_1);
				}
				else
				{
					num = -e1.int_1;
				}
			}
			else
			{
				num = e1.int_1;
			}
			int num2;
			if (enum3 != Enum21.const_2)
			{
				if (enum3 != Enum21.const_3)
				{
					num2 = Math.Abs(e2.int_1);
				}
				else
				{
					num2 = -e2.int_1;
				}
			}
			else
			{
				num2 = e2.int_1;
			}
			if (flag3 && flag4)
			{
				if (!flag && !flag2 && (num == 0 || num == 1) && (num2 == 0 || num2 == 1))
				{
					if (e1.enum20_0 == e2.enum20_0 || this.enum19_0 == Enum19.const_3)
					{
						this.method_42(e1, pt);
						this.method_42(e2, pt);
						Class145.smethod_5(e1, e2);
						Class145.smethod_6(e1, e2);
						goto IL_47B;
					}
				}
				this.method_39(e1, e2, pt);
			}
			else if (flag3)
			{
				if (num2 == 0 || num2 == 1)
				{
					this.method_42(e1, pt);
					Class145.smethod_5(e1, e2);
					Class145.smethod_6(e1, e2);
				}
			}
			else if (flag4)
			{
				if (num == 0 || num == 1)
				{
					this.method_42(e2, pt);
					Class145.smethod_5(e1, e2);
					Class145.smethod_6(e1, e2);
				}
			}
			else if ((num == 0 || num == 1) && (num2 == 0 || num2 == 1) && !flag && !flag2)
			{
				long num3;
				if (enum2 != Enum21.const_2)
				{
					if (enum2 != Enum21.const_3)
					{
						num3 = (long)Math.Abs(e1.int_2);
					}
					else
					{
						num3 = (long)(-(long)e1.int_2);
					}
				}
				else
				{
					num3 = (long)e1.int_2;
				}
				long num4;
				if (enum4 != Enum21.const_2)
				{
					if (enum4 != Enum21.const_3)
					{
						num4 = (long)Math.Abs(e2.int_2);
					}
					else
					{
						num4 = (long)(-(long)e2.int_2);
					}
				}
				else
				{
					num4 = (long)e2.int_2;
				}
				if (e1.enum20_0 != e2.enum20_0)
				{
					this.method_40(e1, e2, pt);
				}
				else if (num == 1 && num2 == 1)
				{
					switch (this.enum19_0)
					{
					case Enum19.const_0:
						if (num3 > 0L && num4 > 0L)
						{
							this.method_40(e1, e2, pt);
						}
						break;
					case Enum19.const_1:
						if (num3 <= 0L && num4 <= 0L)
						{
							this.method_40(e1, e2, pt);
						}
						break;
					case Enum19.const_2:
						if ((e1.enum20_0 == Enum20.const_1 && num3 > 0L && num4 > 0L) || (e1.enum20_0 == Enum20.const_0 && num3 <= 0L && num4 <= 0L))
						{
							this.method_40(e1, e2, pt);
						}
						break;
					case Enum19.const_3:
						this.method_40(e1, e2, pt);
						break;
					}
				}
				else
				{
					Class145.smethod_5(e1, e2);
				}
			}
			IL_47B:
			if (flag != flag2 && ((flag && e1.int_3 >= 0) || (flag2 && e2.int_3 >= 0)))
			{
				Class145.smethod_5(e1, e2);
				Class145.smethod_6(e1, e2);
			}
			if (flag)
			{
				this.method_54(e1);
			}
			if (flag2)
			{
				this.method_54(e2);
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0007078C File Offset: 0x0006E98C
		private void method_54(Class136 class136_2)
		{
			Class136 class136_3 = class136_2.class136_4;
			Class136 class136_4 = class136_2.class136_3;
			if (class136_3 == null && class136_4 == null && class136_2 != this.class136_0)
			{
				return;
			}
			if (class136_3 != null)
			{
				class136_3.class136_3 = class136_4;
			}
			else
			{
				this.class136_0 = class136_4;
			}
			if (class136_4 != null)
			{
				class136_4.class136_4 = class136_3;
			}
			class136_2.class136_3 = null;
			class136_2.class136_4 = null;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000707E4 File Offset: 0x0006E9E4
		private void method_55(Class136 class136_2)
		{
			Class136 class136_3 = class136_2.class136_6;
			Class136 class136_4 = class136_2.class136_5;
			if (class136_3 == null && class136_4 == null && class136_2 != this.class136_1)
			{
				return;
			}
			if (class136_3 != null)
			{
				class136_3.class136_5 = class136_4;
			}
			else
			{
				this.class136_1 = class136_4;
			}
			if (class136_4 != null)
			{
				class136_4.class136_6 = class136_3;
			}
			class136_2.class136_5 = null;
			class136_2.class136_6 = null;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0007083C File Offset: 0x0006EA3C
		private void method_56(ref Class136 class136_2)
		{
			if (class136_2.class136_2 == null)
			{
				throw new Exception0("UpdateEdgeIntoAEL: invalid call");
			}
			Class136 class136_3 = class136_2.class136_4;
			Class136 class136_4 = class136_2.class136_3;
			class136_2.class136_2.int_3 = class136_2.int_3;
			if (class136_3 != null)
			{
				class136_3.class136_3 = class136_2.class136_2;
			}
			else
			{
				this.class136_0 = class136_2.class136_2;
			}
			if (class136_4 != null)
			{
				class136_4.class136_4 = class136_2.class136_2;
			}
			class136_2.class136_2.enum24_0 = class136_2.enum24_0;
			class136_2.class136_2.int_0 = class136_2.int_0;
			class136_2.class136_2.int_1 = class136_2.int_1;
			class136_2.class136_2.int_2 = class136_2.int_2;
			class136_2 = class136_2.class136_2;
			class136_2.intPoint_1 = class136_2.intPoint_0;
			class136_2.class136_4 = class136_3;
			class136_2.class136_3 = class136_4;
			if (!Class144.smethod_1(class136_2))
			{
				this.method_19(class136_2.intPoint_2.long_1);
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00070940 File Offset: 0x0006EB40
		private void method_57(bool bool_7)
		{
			for (Class136 class136_ = this.class136_1; class136_ != null; class136_ = this.class136_1)
			{
				this.method_55(class136_);
				this.method_60(class136_, bool_7);
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00070970 File Offset: 0x0006EB70
		private void method_58(Class136 HorzEdge, out Enum25 Dir, out long Left, out long Right)
		{
			if (HorzEdge.intPoint_0.long_0 < HorzEdge.intPoint_2.long_0)
			{
				Left = HorzEdge.intPoint_0.long_0;
				Right = HorzEdge.intPoint_2.long_0;
				Dir = Enum25.const_1;
				return;
			}
			Left = HorzEdge.intPoint_2.long_0;
			Right = HorzEdge.intPoint_0.long_0;
			Dir = Enum25.const_0;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000709D4 File Offset: 0x0006EBD4
		private void method_59(Class136 class136_2, bool bool_7)
		{
			Class142 @class = this.list_1[class136_2.int_3].class142_0;
			if (class136_2.enum24_0 != Enum24.const_0)
			{
				@class = @class.class142_1;
			}
			if (bool_7)
			{
				if (IntPoint.smethod_0(@class.intPoint_0, class136_2.intPoint_2))
				{
					this.method_27(@class, class136_2.intPoint_0);
					return;
				}
				this.method_27(@class, class136_2.intPoint_2);
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00070A38 File Offset: 0x0006EC38
		private void method_60(Class136 class136_2, bool bool_7)
		{
			Enum25 @enum;
			long num;
			long num2;
			this.method_58(class136_2, out @enum, out num, out num2);
			Class136 @class = class136_2;
			Class136 class2 = null;
			while (@class.class136_2 != null && Class144.smethod_1(@class.class136_2))
			{
				@class = @class.class136_2;
			}
			if (@class.class136_2 == null)
			{
				class2 = this.method_64(@class);
			}
			Class136 class3;
			for (;;)
			{
				bool flag = class136_2 == @class;
				class3 = this.method_61(class136_2, @enum);
				while (class3 != null && (class3.intPoint_1.long_0 != class136_2.intPoint_2.long_0 || class136_2.class136_2 == null || class3.double_0 >= class136_2.class136_2.double_0))
				{
					Class136 class4 = this.method_61(class3, @enum);
					if ((@enum == Enum25.const_1 && class3.intPoint_1.long_0 <= num2) || (@enum == Enum25.const_0 && class3.intPoint_1.long_0 >= num))
					{
						if (class136_2.int_3 >= 0 && class136_2.int_0 != 0)
						{
							this.method_59(class136_2, bool_7);
						}
						if (class3 == class2 && flag)
						{
							goto IL_1E2;
						}
						if (@enum == Enum25.const_1)
						{
							IntPoint pt = new IntPoint(class3.intPoint_1.long_0, class136_2.intPoint_1.long_1);
							this.method_53(class136_2, class3, pt, true);
						}
						else
						{
							IntPoint pt2 = new IntPoint(class3.intPoint_1.long_0, class136_2.intPoint_1.long_1);
							this.method_53(class3, class136_2, pt2, true);
						}
						this.method_37(class136_2, class3);
					}
					else if ((@enum == Enum25.const_1 && class3.intPoint_1.long_0 >= num2) || (@enum == Enum25.const_0 && class3.intPoint_1.long_0 <= num))
					{
						break;
					}
					class3 = class4;
				}
				if (class136_2.int_3 >= 0 && class136_2.int_0 != 0)
				{
					this.method_59(class136_2, bool_7);
				}
				if (class136_2.class136_2 == null || !Class144.smethod_1(class136_2.class136_2))
				{
					goto IL_220;
				}
				this.method_56(ref class136_2);
				if (class136_2.int_3 >= 0)
				{
					this.method_42(class136_2, class136_2.intPoint_0);
				}
				this.method_58(class136_2, out @enum, out num, out num2);
			}
			IL_1E2:
			if (@enum == Enum25.const_1)
			{
				this.method_53(class136_2, class3, class3.intPoint_2, false);
			}
			else
			{
				this.method_53(class3, class136_2, class3.intPoint_2, false);
			}
			if (class2.int_3 >= 0)
			{
				throw new Exception0("ProcessHorizontal error");
			}
			return;
			IL_220:
			if (class136_2.class136_2 != null)
			{
				if (class136_2.int_3 < 0)
				{
					this.method_56(ref class136_2);
					return;
				}
				Class142 class142_ = this.method_42(class136_2, class136_2.intPoint_2);
				this.method_56(ref class136_2);
				if (class136_2.int_0 == 0)
				{
					return;
				}
				Class136 class136_3 = class136_2.class136_4;
				Class136 class136_4 = class136_2.class136_3;
				if (class136_3 != null && class136_3.intPoint_1.long_0 == class136_2.intPoint_0.long_0 && class136_3.intPoint_1.long_1 == class136_2.intPoint_0.long_1 && class136_3.int_0 != 0 && class136_3.int_3 >= 0 && class136_3.intPoint_1.long_1 > class136_3.intPoint_2.long_1 && Class144.smethod_2(class136_2, class136_3, this.bool_0))
				{
					Class142 class142_2 = this.method_42(class136_3, class136_2.intPoint_0);
					this.method_26(class142_, class142_2, class136_2.intPoint_2);
					return;
				}
				if (class136_4 != null && class136_4.intPoint_1.long_0 == class136_2.intPoint_0.long_0 && class136_4.intPoint_1.long_1 == class136_2.intPoint_0.long_1 && class136_4.int_0 != 0 && class136_4.int_3 >= 0 && class136_4.intPoint_1.long_1 > class136_4.intPoint_2.long_1 && Class144.smethod_2(class136_2, class136_4, this.bool_0))
				{
					Class142 class142_3 = this.method_42(class136_4, class136_2.intPoint_0);
					this.method_26(class142_, class142_3, class136_2.intPoint_2);
					return;
				}
			}
			else if (class2 != null)
			{
				if (class2.int_3 < 0)
				{
					this.method_54(class136_2);
					this.method_54(class2);
					return;
				}
				if (@enum == Enum25.const_1)
				{
					this.method_53(class136_2, class2, class136_2.intPoint_2, false);
				}
				else
				{
					this.method_53(class2, class136_2, class136_2.intPoint_2, false);
				}
				if (class2.int_3 >= 0)
				{
					throw new Exception0("ProcessHorizontal error");
				}
			}
			else
			{
				if (class136_2.int_3 >= 0)
				{
					this.method_42(class136_2, class136_2.intPoint_2);
				}
				this.method_54(class136_2);
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000069BF File Offset: 0x00004BBF
		private Class136 method_61(Class136 class136_2, Enum25 enum25_0)
		{
			if (enum25_0 != Enum25.const_1)
			{
				return class136_2.class136_4;
			}
			return class136_2.class136_3;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000069D2 File Offset: 0x00004BD2
		private bool method_62(Class136 class136_2, double double_0)
		{
			return class136_2 != null && (double)class136_2.intPoint_2.long_1 == double_0 && class136_2.class136_2 == null;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000069F1 File Offset: 0x00004BF1
		private bool method_63(Class136 class136_2, double double_0)
		{
			return (double)class136_2.intPoint_2.long_1 == double_0 && class136_2.class136_2 != null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00070E6C File Offset: 0x0006F06C
		private Class136 method_64(Class136 class136_2)
		{
			Class136 @class = null;
			if (IntPoint.smethod_0(class136_2.class136_0.intPoint_2, class136_2.intPoint_2) && class136_2.class136_0.class136_2 == null)
			{
				@class = class136_2.class136_0;
			}
			else if (IntPoint.smethod_0(class136_2.class136_1.intPoint_2, class136_2.intPoint_2) && class136_2.class136_1.class136_2 == null)
			{
				@class = class136_2.class136_1;
			}
			if (@class != null && (@class.int_3 == -2 || (@class.class136_3 == @class.class136_4 && !Class144.smethod_1(@class))))
			{
				return null;
			}
			return @class;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00070EFC File Offset: 0x0006F0FC
		private bool method_65(long long_0, long long_1)
		{
			if (this.class136_0 == null)
			{
				return true;
			}
			try
			{
				this.method_66(long_0, long_1);
				if (this.list_2.Count == 0)
				{
					return true;
				}
				if (this.list_2.Count != 1 && !this.method_68())
				{
					return false;
				}
				this.method_69();
			}
			catch
			{
				this.class136_1 = null;
				this.list_2.Clear();
				throw new Exception0("ProcessIntersections error");
			}
			this.class136_1 = null;
			return true;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00070F88 File Offset: 0x0006F188
		private void method_66(long long_0, long long_1)
		{
			if (this.class136_0 == null)
			{
				return;
			}
			Class136 @class = this.class136_0;
			this.class136_1 = @class;
			while (@class != null)
			{
				@class.class136_6 = @class.class136_4;
				@class.class136_5 = @class.class136_3;
				@class.intPoint_1.long_0 = Class145.smethod_8(@class, long_1);
				@class = @class.class136_3;
			}
			bool flag = true;
			while (flag && this.class136_1 != null)
			{
				flag = false;
				@class = this.class136_1;
				while (@class.class136_5 != null)
				{
					Class136 class136_ = @class.class136_5;
					if (@class.intPoint_1.long_0 > class136_.intPoint_1.long_0)
					{
						IntPoint intPoint;
						if (!this.method_70(@class, class136_, out intPoint) && @class.intPoint_1.long_0 > class136_.intPoint_1.long_0 + 1L)
						{
							throw new Exception0("Intersection error");
						}
						if (intPoint.long_1 > long_0)
						{
							intPoint.long_1 = long_0;
							if (Math.Abs(@class.double_0) > Math.Abs(class136_.double_0))
							{
								intPoint.long_0 = Class145.smethod_8(class136_, long_0);
							}
							else
							{
								intPoint.long_0 = Class145.smethod_8(@class, long_0);
							}
						}
						Class137 class2 = new Class137();
						class2.class136_0 = @class;
						class2.class136_1 = class136_;
						class2.intPoint_0 = intPoint;
						this.list_2.Add(class2);
						this.method_38(@class, class136_);
						flag = true;
					}
					else
					{
						@class = class136_;
					}
				}
				if (@class.class136_6 == null)
				{
					break;
				}
				@class.class136_6.class136_5 = null;
			}
			this.class136_1 = null;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00006A0D File Offset: 0x00004C0D
		private bool method_67(Class137 class137_0)
		{
			return class137_0.class136_0.class136_5 == class137_0.class136_1 || class137_0.class136_0.class136_6 == class137_0.class136_1;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00071110 File Offset: 0x0006F310
		private bool method_68()
		{
			this.list_2.Sort(this.icomparer_0);
			this.method_36();
			int count = this.list_2.Count;
			for (int i = 0; i < count; i++)
			{
				if (!this.method_67(this.list_2[i]))
				{
					int num = i + 1;
					while (num < count && !this.method_67(this.list_2[num]))
					{
						num++;
					}
					if (num == count)
					{
						return false;
					}
					Class137 value = this.list_2[i];
					this.list_2[i] = this.list_2[num];
					this.list_2[num] = value;
				}
				this.method_38(this.list_2[i].class136_0, this.list_2[i].class136_1);
			}
			return true;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000711EC File Offset: 0x0006F3EC
		private void method_69()
		{
			for (int i = 0; i < this.list_2.Count; i++)
			{
				Class137 @class = this.list_2[i];
				this.method_53(@class.class136_0, @class.class136_1, @class.intPoint_0, true);
				this.method_37(@class.class136_0, @class.class136_1);
			}
			this.list_2.Clear();
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00006A37 File Offset: 0x00004C37
		internal static long smethod_7(double double_0)
		{
			if (double_0 >= 0.0)
			{
				return (long)(double_0 + 0.5);
			}
			return (long)(double_0 - 0.5);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00071254 File Offset: 0x0006F454
		private static long smethod_8(Class136 class136_2, long long_0)
		{
			if (long_0 == class136_2.intPoint_2.long_1)
			{
				return class136_2.intPoint_2.long_0;
			}
			return class136_2.intPoint_0.long_0 + Class145.smethod_7(class136_2.double_0 * (double)(long_0 - class136_2.intPoint_0.long_1));
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000712A4 File Offset: 0x0006F4A4
		private bool method_70(Class136 edge1, Class136 edge2, out IntPoint ip)
		{
			ip = default(IntPoint);
			if (!Class144.smethod_2(edge1, edge2, this.bool_0))
			{
				if (edge1.double_0 != edge2.double_0)
				{
					if (edge1.intPoint_3.long_0 == 0L)
					{
						ip.long_0 = edge1.intPoint_0.long_0;
						if (Class144.smethod_1(edge2))
						{
							ip.long_1 = edge2.intPoint_0.long_1;
						}
						else
						{
							double num = (double)edge2.intPoint_0.long_1 - (double)edge2.intPoint_0.long_0 / edge2.double_0;
							ip.long_1 = Class145.smethod_7((double)ip.long_0 / edge2.double_0 + num);
						}
					}
					else if (edge2.intPoint_3.long_0 == 0L)
					{
						ip.long_0 = edge2.intPoint_0.long_0;
						if (Class144.smethod_1(edge1))
						{
							ip.long_1 = edge1.intPoint_0.long_1;
						}
						else
						{
							double num2 = (double)edge1.intPoint_0.long_1 - (double)edge1.intPoint_0.long_0 / edge1.double_0;
							ip.long_1 = Class145.smethod_7((double)ip.long_0 / edge1.double_0 + num2);
						}
					}
					else
					{
						double num2 = (double)edge1.intPoint_0.long_0 - (double)edge1.intPoint_0.long_1 * edge1.double_0;
						double num = (double)edge2.intPoint_0.long_0 - (double)edge2.intPoint_0.long_1 * edge2.double_0;
						double num3 = (num - num2) / (edge1.double_0 - edge2.double_0);
						ip.long_1 = Class145.smethod_7(num3);
						if (Math.Abs(edge1.double_0) < Math.Abs(edge2.double_0))
						{
							ip.long_0 = Class145.smethod_7(edge1.double_0 * num3 + num2);
						}
						else
						{
							ip.long_0 = Class145.smethod_7(edge2.double_0 * num3 + num);
						}
					}
					if (ip.long_1 < edge1.intPoint_2.long_1 || ip.long_1 < edge2.intPoint_2.long_1)
					{
						if (edge1.intPoint_2.long_1 > edge2.intPoint_2.long_1)
						{
							ip.long_1 = edge1.intPoint_2.long_1;
						}
						else
						{
							ip.long_1 = edge2.intPoint_2.long_1;
						}
						if (Math.Abs(edge1.double_0) < Math.Abs(edge2.double_0))
						{
							ip.long_0 = Class145.smethod_8(edge1, ip.long_1);
						}
						else
						{
							ip.long_0 = Class145.smethod_8(edge2, ip.long_1);
						}
					}
					return true;
				}
			}
			if (edge2.intPoint_0.long_1 > edge1.intPoint_0.long_1)
			{
				ip = edge2.intPoint_0;
			}
			else
			{
				ip = edge1.intPoint_0;
			}
			return false;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00071550 File Offset: 0x0006F750
		private void method_71(long long_0)
		{
			Class136 class136_ = this.class136_0;
			while (class136_ != null)
			{
				bool flag;
				if (flag = this.method_62(class136_, (double)long_0))
				{
					Class136 @class = this.method_64(class136_);
					flag = (@class == null || !Class144.smethod_1(@class));
				}
				if (flag)
				{
					Class136 class136_2 = class136_.class136_4;
					this.method_72(class136_);
					if (class136_2 == null)
					{
						class136_ = this.class136_0;
					}
					else
					{
						class136_ = class136_2.class136_3;
					}
				}
				else
				{
					if (this.method_63(class136_, (double)long_0) && Class144.smethod_1(class136_.class136_2))
					{
						this.method_56(ref class136_);
						if (class136_.int_3 >= 0)
						{
							this.method_42(class136_, class136_.intPoint_0);
						}
						this.method_35(class136_);
					}
					else
					{
						class136_.intPoint_1.long_0 = Class145.smethod_8(class136_, long_0);
						class136_.intPoint_1.long_1 = long_0;
					}
					if (this.method_17())
					{
						Class136 class136_3 = class136_.class136_4;
						if (class136_.int_3 >= 0 && class136_.int_0 != 0 && class136_3 != null && class136_3.int_3 >= 0 && class136_3.intPoint_1.long_0 == class136_.intPoint_1.long_0 && class136_3.int_0 != 0)
						{
							Class142 class142_ = this.method_42(class136_3, class136_.intPoint_1);
							Class142 class142_2 = this.method_42(class136_, class136_.intPoint_1);
							this.method_26(class142_, class142_2, class136_.intPoint_1);
						}
					}
					class136_ = class136_.class136_3;
				}
			}
			this.method_57(true);
			for (class136_ = this.class136_0; class136_ != null; class136_ = class136_.class136_3)
			{
				if (this.method_63(class136_, (double)long_0))
				{
					Class142 class2 = null;
					if (class136_.int_3 >= 0)
					{
						class2 = this.method_42(class136_, class136_.intPoint_2);
					}
					this.method_56(ref class136_);
					Class136 class136_4 = class136_.class136_4;
					Class136 class136_5 = class136_.class136_3;
					if (class136_4 != null && class136_4.intPoint_1.long_0 == class136_.intPoint_0.long_0 && class136_4.intPoint_1.long_1 == class136_.intPoint_0.long_1 && class2 != null && class136_4.int_3 >= 0 && class136_4.intPoint_1.long_1 > class136_4.intPoint_2.long_1 && Class144.smethod_2(class136_, class136_4, this.bool_0) && class136_.int_0 != 0 && class136_4.int_0 != 0)
					{
						Class142 class142_3 = this.method_42(class136_4, class136_.intPoint_0);
						this.method_26(class2, class142_3, class136_.intPoint_2);
					}
					else if (class136_5 != null && class136_5.intPoint_1.long_0 == class136_.intPoint_0.long_0 && class136_5.intPoint_1.long_1 == class136_.intPoint_0.long_1 && class2 != null && class136_5.int_3 >= 0 && class136_5.intPoint_1.long_1 > class136_5.intPoint_2.long_1 && Class144.smethod_2(class136_, class136_5, this.bool_0) && class136_.int_0 != 0 && class136_5.int_0 != 0)
					{
						Class142 class142_4 = this.method_42(class136_5, class136_.intPoint_0);
						this.method_26(class2, class142_4, class136_.intPoint_2);
					}
				}
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00071858 File Offset: 0x0006FA58
		private void method_72(Class136 class136_2)
		{
			Class136 @class = this.method_64(class136_2);
			if (@class == null)
			{
				if (class136_2.int_3 >= 0)
				{
					this.method_42(class136_2, class136_2.intPoint_2);
				}
				this.method_54(class136_2);
				return;
			}
			for (Class136 class136_3 = class136_2.class136_3; class136_3 != null; class136_3 = class136_2.class136_3)
			{
				if (class136_3 == @class)
				{
					break;
				}
				this.method_53(class136_2, class136_3, class136_2.intPoint_2, true);
				this.method_37(class136_2, class136_3);
			}
			if (class136_2.int_3 == -1 && @class.int_3 == -1)
			{
				this.method_54(class136_2);
				this.method_54(@class);
				return;
			}
			if (class136_2.int_3 < 0 || @class.int_3 < 0)
			{
				throw new Exception0("DoMaxima error");
			}
			this.method_53(class136_2, @class, class136_2.intPoint_2, false);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00006A5E File Offset: 0x00004C5E
		public static bool smethod_9(List<IntPoint> list_5)
		{
			return Class145.smethod_11(list_5) >= 0.0;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0007190C File Offset: 0x0006FB0C
		private int method_73(Class142 class142_0)
		{
			if (class142_0 == null)
			{
				return 0;
			}
			int num = 0;
			Class142 @class = class142_0;
			do
			{
				num++;
				@class = @class.class142_0;
			}
			while (@class != class142_0);
			return num;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00071934 File Offset: 0x0006FB34
		private void method_74(List<List<IntPoint>> list_5)
		{
			list_5.Clear();
			list_5.Capacity = this.list_1.Count;
			for (int i = 0; i < this.list_1.Count; i++)
			{
				Class141 @class = this.list_1[i];
				if (@class.class142_0 != null)
				{
					Class142 class142_ = @class.class142_0.class142_1;
					int num = this.method_73(class142_);
					if (num >= 2)
					{
						List<IntPoint> list = new List<IntPoint>(num);
						for (int j = 0; j < num; j++)
						{
							list.Add(class142_.intPoint_0);
							class142_ = class142_.class142_1;
						}
						list_5.Add(list);
					}
				}
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x000719D0 File Offset: 0x0006FBD0
		private void method_75(Class141 class141_0)
		{
			Class142 @class = null;
			class141_0.class142_1 = null;
			Class142 class2 = class141_0.class142_0;
			while (class2.class142_1 != class2)
			{
				if (class2.class142_1 == class2.class142_0)
				{
					break;
				}
				if (!IntPoint.smethod_0(class2.intPoint_0, class2.class142_0.intPoint_0) && !IntPoint.smethod_0(class2.intPoint_0, class2.class142_1.intPoint_0) && (!Class144.smethod_3(class2.class142_1.intPoint_0, class2.intPoint_0, class2.class142_0.intPoint_0, this.bool_0) || (base.method_0() && base.method_9(class2.class142_1.intPoint_0, class2.intPoint_0, class2.class142_0.intPoint_0))))
				{
					if (class2 == @class)
					{
						class141_0.class142_0 = class2;
						return;
					}
					if (@class == null)
					{
						@class = class2;
					}
					class2 = class2.class142_0;
				}
				else
				{
					@class = null;
					class2.class142_1.class142_0 = class2.class142_0;
					class2.class142_0.class142_1 = class2.class142_1;
					class2 = class2.class142_1;
				}
			}
			this.method_25(class2);
			class141_0.class142_0 = null;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00071AEC File Offset: 0x0006FCEC
		private Class142 method_76(Class142 class142_0, bool bool_7)
		{
			Class142 @class = new Class142();
			@class.intPoint_0 = class142_0.intPoint_0;
			@class.int_0 = class142_0.int_0;
			if (bool_7)
			{
				@class.class142_0 = class142_0.class142_0;
				@class.class142_1 = class142_0;
				class142_0.class142_0.class142_1 = @class;
				class142_0.class142_0 = @class;
			}
			else
			{
				@class.class142_1 = class142_0.class142_1;
				@class.class142_0 = class142_0;
				class142_0.class142_1.class142_0 = @class;
				class142_0.class142_1 = @class;
			}
			return @class;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00071B6C File Offset: 0x0006FD6C
		private bool method_77(long a1, long a2, long b1, long b2, out long Left, out long Right)
		{
			if (a1 < a2)
			{
				if (b1 < b2)
				{
					Left = Math.Max(a1, b1);
					Right = Math.Min(a2, b2);
				}
				else
				{
					Left = Math.Max(a1, b2);
					Right = Math.Min(a2, b1);
				}
			}
			else if (b1 < b2)
			{
				Left = Math.Max(a2, b1);
				Right = Math.Min(a1, b2);
			}
			else
			{
				Left = Math.Max(a2, b2);
				Right = Math.Min(a1, b1);
			}
			return Left < Right;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00071BEC File Offset: 0x0006FDEC
		private bool method_78(Class142 class142_0, Class142 class142_1, Class142 class142_2, Class142 class142_3, IntPoint intPoint_0, bool bool_7)
		{
			Enum25 @enum = (class142_0.intPoint_0.long_0 > class142_1.intPoint_0.long_0) ? Enum25.const_0 : Enum25.const_1;
			Enum25 enum2 = (class142_2.intPoint_0.long_0 > class142_3.intPoint_0.long_0) ? Enum25.const_0 : Enum25.const_1;
			if (@enum == enum2)
			{
				return false;
			}
			if (@enum == Enum25.const_1)
			{
				while (class142_0.class142_0.intPoint_0.long_0 <= intPoint_0.long_0 && class142_0.class142_0.intPoint_0.long_0 >= class142_0.intPoint_0.long_0)
				{
					if (class142_0.class142_0.intPoint_0.long_1 != intPoint_0.long_1)
					{
						break;
					}
					class142_0 = class142_0.class142_0;
				}
				if (bool_7 && class142_0.intPoint_0.long_0 != intPoint_0.long_0)
				{
					class142_0 = class142_0.class142_0;
				}
				class142_1 = this.method_76(class142_0, !bool_7);
				if (IntPoint.smethod_1(class142_1.intPoint_0, intPoint_0))
				{
					class142_0 = class142_1;
					class142_0.intPoint_0 = intPoint_0;
					class142_1 = this.method_76(class142_0, !bool_7);
				}
			}
			else
			{
				while (class142_0.class142_0.intPoint_0.long_0 >= intPoint_0.long_0 && class142_0.class142_0.intPoint_0.long_0 <= class142_0.intPoint_0.long_0)
				{
					if (class142_0.class142_0.intPoint_0.long_1 != intPoint_0.long_1)
					{
						break;
					}
					class142_0 = class142_0.class142_0;
				}
				if (!bool_7 && class142_0.intPoint_0.long_0 != intPoint_0.long_0)
				{
					class142_0 = class142_0.class142_0;
				}
				class142_1 = this.method_76(class142_0, bool_7);
				if (IntPoint.smethod_1(class142_1.intPoint_0, intPoint_0))
				{
					class142_0 = class142_1;
					class142_0.intPoint_0 = intPoint_0;
					class142_1 = this.method_76(class142_0, bool_7);
				}
			}
			if (enum2 == Enum25.const_1)
			{
				while (class142_2.class142_0.intPoint_0.long_0 <= intPoint_0.long_0 && class142_2.class142_0.intPoint_0.long_0 >= class142_2.intPoint_0.long_0)
				{
					if (class142_2.class142_0.intPoint_0.long_1 != intPoint_0.long_1)
					{
						break;
					}
					class142_2 = class142_2.class142_0;
				}
				if (bool_7 && class142_2.intPoint_0.long_0 != intPoint_0.long_0)
				{
					class142_2 = class142_2.class142_0;
				}
				class142_3 = this.method_76(class142_2, !bool_7);
				if (IntPoint.smethod_1(class142_3.intPoint_0, intPoint_0))
				{
					class142_2 = class142_3;
					class142_2.intPoint_0 = intPoint_0;
					class142_3 = this.method_76(class142_2, !bool_7);
				}
			}
			else
			{
				while (class142_2.class142_0.intPoint_0.long_0 >= intPoint_0.long_0 && class142_2.class142_0.intPoint_0.long_0 <= class142_2.intPoint_0.long_0)
				{
					if (class142_2.class142_0.intPoint_0.long_1 != intPoint_0.long_1)
					{
						break;
					}
					class142_2 = class142_2.class142_0;
				}
				if (!bool_7 && class142_2.intPoint_0.long_0 != intPoint_0.long_0)
				{
					class142_2 = class142_2.class142_0;
				}
				class142_3 = this.method_76(class142_2, bool_7);
				if (IntPoint.smethod_1(class142_3.intPoint_0, intPoint_0))
				{
					class142_2 = class142_3;
					class142_2.intPoint_0 = intPoint_0;
					class142_3 = this.method_76(class142_2, bool_7);
				}
			}
			if (@enum == Enum25.const_1 == bool_7)
			{
				class142_0.class142_1 = class142_2;
				class142_2.class142_0 = class142_0;
				class142_1.class142_0 = class142_3;
				class142_3.class142_1 = class142_1;
			}
			else
			{
				class142_0.class142_0 = class142_2;
				class142_2.class142_1 = class142_0;
				class142_1.class142_1 = class142_3;
				class142_3.class142_0 = class142_1;
			}
			return true;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00071F58 File Offset: 0x00070158
		private bool method_79(Class143 class143_0, Class141 class141_0, Class141 class141_1)
		{
			Class142 @class = class143_0.class142_0;
			Class142 class142_ = class143_0.class142_1;
			bool flag;
			if ((flag = (class143_0.class142_0.intPoint_0.long_1 == class143_0.intPoint_0.long_1)) && IntPoint.smethod_0(class143_0.intPoint_0, class143_0.class142_0.intPoint_0) && IntPoint.smethod_0(class143_0.intPoint_0, class143_0.class142_1.intPoint_0))
			{
				Class142 class2 = class143_0.class142_0.class142_0;
				while (class2 != @class && IntPoint.smethod_0(class2.intPoint_0, class143_0.intPoint_0))
				{
					class2 = class2.class142_0;
				}
				bool flag2 = class2.intPoint_0.long_1 > class143_0.intPoint_0.long_1;
				Class142 class3 = class143_0.class142_1.class142_0;
				while (class3 != class142_ && IntPoint.smethod_0(class3.intPoint_0, class143_0.intPoint_0))
				{
					class3 = class3.class142_0;
				}
				bool flag3 = class3.intPoint_0.long_1 > class143_0.intPoint_0.long_1;
				if (flag2 == flag3)
				{
					return false;
				}
				if (flag2)
				{
					class2 = this.method_76(@class, false);
					class3 = this.method_76(class142_, true);
					@class.class142_1 = class142_;
					class142_.class142_0 = @class;
					class2.class142_0 = class3;
					class3.class142_1 = class2;
					class143_0.class142_0 = @class;
					class143_0.class142_1 = class2;
					return true;
				}
				class2 = this.method_76(@class, true);
				class3 = this.method_76(class142_, false);
				@class.class142_0 = class142_;
				class142_.class142_1 = @class;
				class2.class142_1 = class3;
				class3.class142_0 = class2;
				class143_0.class142_0 = @class;
				class143_0.class142_1 = class2;
				return true;
			}
			else
			{
				Class142 class2;
				Class142 class3;
				if (flag)
				{
					class2 = @class;
					while (@class.class142_1.intPoint_0.long_1 == @class.intPoint_0.long_1 && @class.class142_1 != class2)
					{
						if (@class.class142_1 == class142_)
						{
							break;
						}
						@class = @class.class142_1;
					}
					while (class2.class142_0.intPoint_0.long_1 == class2.intPoint_0.long_1 && class2.class142_0 != @class)
					{
						if (class2.class142_0 == class142_)
						{
							break;
						}
						class2 = class2.class142_0;
					}
					if (class2.class142_0 != @class)
					{
						if (class2.class142_0 != class142_)
						{
							class3 = class142_;
							while (class142_.class142_1.intPoint_0.long_1 == class142_.intPoint_0.long_1 && class142_.class142_1 != class3)
							{
								if (class142_.class142_1 == class2)
								{
									break;
								}
								class142_ = class142_.class142_1;
							}
							while (class3.class142_0.intPoint_0.long_1 == class3.intPoint_0.long_1 && class3.class142_0 != class142_)
							{
								if (class3.class142_0 == @class)
								{
									break;
								}
								class3 = class3.class142_0;
							}
							if (class3.class142_0 != class142_)
							{
								if (class3.class142_0 != @class)
								{
									long num;
									long num2;
									if (!this.method_77(@class.intPoint_0.long_0, class2.intPoint_0.long_0, class142_.intPoint_0.long_0, class3.intPoint_0.long_0, out num, out num2))
									{
										return false;
									}
									IntPoint intPoint_;
									bool bool_;
									if (@class.intPoint_0.long_0 >= num && @class.intPoint_0.long_0 <= num2)
									{
										intPoint_ = @class.intPoint_0;
										bool_ = (@class.intPoint_0.long_0 > class2.intPoint_0.long_0);
									}
									else if (class142_.intPoint_0.long_0 >= num && class142_.intPoint_0.long_0 <= num2)
									{
										intPoint_ = class142_.intPoint_0;
										bool_ = (class142_.intPoint_0.long_0 > class3.intPoint_0.long_0);
									}
									else if (class2.intPoint_0.long_0 >= num && class2.intPoint_0.long_0 <= num2)
									{
										intPoint_ = class2.intPoint_0;
										bool_ = (class2.intPoint_0.long_0 > @class.intPoint_0.long_0);
									}
									else
									{
										intPoint_ = class3.intPoint_0;
										bool_ = (class3.intPoint_0.long_0 > class142_.intPoint_0.long_0);
									}
									class143_0.class142_0 = @class;
									class143_0.class142_1 = class142_;
									return this.method_78(@class, class2, class142_, class3, intPoint_, bool_);
								}
							}
							return false;
						}
					}
					return false;
				}
				class2 = @class.class142_0;
				while (IntPoint.smethod_0(class2.intPoint_0, @class.intPoint_0))
				{
					if (class2 == @class)
					{
						break;
					}
					class2 = class2.class142_0;
				}
				bool flag4;
				if (flag4 = (class2.intPoint_0.long_1 > @class.intPoint_0.long_1 || !Class144.smethod_3(@class.intPoint_0, class2.intPoint_0, class143_0.intPoint_0, this.bool_0)))
				{
					class2 = @class.class142_1;
					while (IntPoint.smethod_0(class2.intPoint_0, @class.intPoint_0))
					{
						if (class2 == @class)
						{
							break;
						}
						class2 = class2.class142_1;
					}
					if (class2.intPoint_0.long_1 > @class.intPoint_0.long_1 || !Class144.smethod_3(@class.intPoint_0, class2.intPoint_0, class143_0.intPoint_0, this.bool_0))
					{
						return false;
					}
				}
				class3 = class142_.class142_0;
				while (IntPoint.smethod_0(class3.intPoint_0, class142_.intPoint_0))
				{
					if (class3 == class142_)
					{
						break;
					}
					class3 = class3.class142_0;
				}
				bool flag5;
				if (flag5 = (class3.intPoint_0.long_1 > class142_.intPoint_0.long_1 || !Class144.smethod_3(class142_.intPoint_0, class3.intPoint_0, class143_0.intPoint_0, this.bool_0)))
				{
					class3 = class142_.class142_1;
					while (IntPoint.smethod_0(class3.intPoint_0, class142_.intPoint_0))
					{
						if (class3 == class142_)
						{
							break;
						}
						class3 = class3.class142_1;
					}
					if (class3.intPoint_0.long_1 > class142_.intPoint_0.long_1 || !Class144.smethod_3(class142_.intPoint_0, class3.intPoint_0, class143_0.intPoint_0, this.bool_0))
					{
						return false;
					}
				}
				if (class2 != @class && class3 != class142_ && class2 != class3)
				{
					if (class141_0 != class141_1 || flag4 != flag5)
					{
						if (flag4)
						{
							class2 = this.method_76(@class, false);
							class3 = this.method_76(class142_, true);
							@class.class142_1 = class142_;
							class142_.class142_0 = @class;
							class2.class142_0 = class3;
							class3.class142_1 = class2;
							class143_0.class142_0 = @class;
							class143_0.class142_1 = class2;
							return true;
						}
						class2 = this.method_76(@class, true);
						class3 = this.method_76(class142_, false);
						@class.class142_0 = class142_;
						class142_.class142_1 = @class;
						class2.class142_1 = class3;
						class3.class142_0 = class2;
						class143_0.class142_0 = @class;
						class143_0.class142_1 = class2;
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00072594 File Offset: 0x00070794
		private int method_80(IntPoint intPoint_0, Class142 class142_0)
		{
			int num = 0;
			Class142 @class = class142_0;
			for (;;)
			{
				double num2 = (double)class142_0.intPoint_0.long_0;
				double num3 = (double)class142_0.intPoint_0.long_1;
				double num4 = (double)class142_0.class142_0.intPoint_0.long_0;
				double num5 = (double)class142_0.class142_0.intPoint_0.long_1;
				if (num5 == (double)intPoint_0.long_1)
				{
					if (num4 == (double)intPoint_0.long_0)
					{
						return -1;
					}
					if (num3 == (double)intPoint_0.long_1 && num4 > (double)intPoint_0.long_0 == num2 < (double)intPoint_0.long_0)
					{
						return -1;
					}
				}
				if (num3 < (double)intPoint_0.long_1 != num5 < (double)intPoint_0.long_1)
				{
					if (num2 >= (double)intPoint_0.long_0)
					{
						if (num4 > (double)intPoint_0.long_0)
						{
							num = 1 - num;
						}
						else
						{
							double num6 = (num2 - (double)intPoint_0.long_0) * (num5 - (double)intPoint_0.long_1) - (num4 - (double)intPoint_0.long_0) * (num3 - (double)intPoint_0.long_1);
							if (num6 == 0.0)
							{
								break;
							}
							if (num6 > 0.0 == num5 > num3)
							{
								num = 1 - num;
							}
						}
					}
					else if (num4 > (double)intPoint_0.long_0)
					{
						double num7 = (num2 - (double)intPoint_0.long_0) * (num5 - (double)intPoint_0.long_1) - (num4 - (double)intPoint_0.long_0) * (num3 - (double)intPoint_0.long_1);
						if (num7 == 0.0)
						{
							return -1;
						}
						if (num7 > 0.0 == num5 > num3)
						{
							num = 1 - num;
						}
					}
				}
				class142_0 = class142_0.class142_0;
				if (@class == class142_0)
				{
					return num;
				}
			}
			return -1;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0007273C File Offset: 0x0007093C
		private bool method_81(Class142 class142_0, Class142 class142_1)
		{
			Class142 @class = class142_0;
			int num;
			do
			{
				num = this.method_80(@class.intPoint_0, class142_1);
				if (num >= 0)
				{
					goto Block_2;
				}
				@class = @class.class142_0;
			}
			while (@class != class142_0);
			return true;
			Block_2:
			return num != 0;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00072774 File Offset: 0x00070974
		private void method_82(Class141 class141_0, Class141 class141_1)
		{
			for (int i = 0; i < this.list_1.Count; i++)
			{
				Class141 @class = this.list_1[i];
				if (@class.class142_0 != null && @class.class141_0 == class141_0 && this.method_81(@class.class142_0, class141_1.class142_0))
				{
					@class.class141_0 = class141_1;
				}
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000727D0 File Offset: 0x000709D0
		private void method_83(Class141 class141_0, Class141 class141_1)
		{
			foreach (Class141 @class in this.list_1)
			{
				if (@class.class141_0 == class141_0)
				{
					@class.class141_0 = class141_1;
				}
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00006A74 File Offset: 0x00004C74
		private static Class141 smethod_10(Class141 class141_0)
		{
			while (class141_0 != null && class141_0.class142_0 == null)
			{
				class141_0 = class141_0.class141_0;
			}
			return class141_0;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00072830 File Offset: 0x00070A30
		private void method_84()
		{
			for (int i = 0; i < this.list_3.Count; i++)
			{
				Class143 @class = this.list_3[i];
				Class141 class2 = this.method_50(@class.class142_0.int_0);
				Class141 class3 = this.method_50(@class.class142_1.int_0);
				if (class2.class142_0 != null && class3.class142_0 != null)
				{
					Class141 class4;
					if (class2 == class3)
					{
						class4 = class2;
					}
					else if (this.method_49(class2, class3))
					{
						class4 = class3;
					}
					else if (this.method_49(class3, class2))
					{
						class4 = class2;
					}
					else
					{
						class4 = this.method_48(class2, class3);
					}
					if (this.method_79(@class, class2, class3))
					{
						if (class2 == class3)
						{
							class2.class142_0 = @class.class142_0;
							class2.class142_1 = null;
							class3 = this.method_41();
							class3.class142_0 = @class.class142_1;
							this.method_85(class3);
							if (this.bool_4)
							{
								for (int j = 0; j < this.list_1.Count - 1; j++)
								{
									Class141 class5 = this.list_1[j];
									if (class5.class142_0 != null && Class145.smethod_10(class5.class141_0) == class2 && class5.bool_0 != class2.bool_0 && this.method_81(class5.class142_0, @class.class142_1))
									{
										class5.class141_0 = class3;
									}
								}
							}
							if (this.method_81(class3.class142_0, class2.class142_0))
							{
								class3.bool_0 = !class2.bool_0;
								class3.class141_0 = class2;
								if (this.bool_4)
								{
									this.method_83(class3, class2);
								}
								if ((class3.bool_0 ^ this.method_15()) == this.method_87(class3) > 0.0)
								{
									this.method_52(class3.class142_0);
								}
							}
							else if (this.method_81(class2.class142_0, class3.class142_0))
							{
								class3.bool_0 = class2.bool_0;
								class2.bool_0 = !class3.bool_0;
								class3.class141_0 = class2.class141_0;
								class2.class141_0 = class3;
								if (this.bool_4)
								{
									this.method_83(class2, class3);
								}
								if ((class2.bool_0 ^ this.method_15()) == this.method_87(class2) > 0.0)
								{
									this.method_52(class2.class142_0);
								}
							}
							else
							{
								class3.bool_0 = class2.bool_0;
								class3.class141_0 = class2.class141_0;
								if (this.bool_4)
								{
									this.method_82(class2, class3);
								}
							}
						}
						else
						{
							class3.class142_0 = null;
							class3.class142_1 = null;
							class3.int_0 = class2.int_0;
							class2.bool_0 = class4.bool_0;
							if (class4 == class3)
							{
								class2.class141_0 = class3.class141_0;
							}
							class3.class141_0 = class2;
							if (this.bool_4)
							{
								this.method_83(class3, class2);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00072AF8 File Offset: 0x00070CF8
		private void method_85(Class141 class141_0)
		{
			Class142 @class = class141_0.class142_0;
			do
			{
				@class.int_0 = class141_0.int_0;
				@class = @class.class142_1;
			}
			while (@class != class141_0.class142_0);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00072B28 File Offset: 0x00070D28
		private void method_86()
		{
			int i = 0;
			while (i < this.list_1.Count)
			{
				Class141 @class = this.list_1[i++];
				Class142 class142_ = @class.class142_0;
				if (class142_ != null)
				{
					do
					{
						for (Class142 class2 = class142_.class142_0; class2 != @class.class142_0; class2 = class2.class142_0)
						{
							if (IntPoint.smethod_0(class142_.intPoint_0, class2.intPoint_0) && class2.class142_0 != class142_ && class2.class142_1 != class142_)
							{
								Class142 class142_2 = class142_.class142_1;
								Class142 class142_3 = class2.class142_1;
								class142_.class142_1 = class142_3;
								class142_3.class142_0 = class142_;
								class2.class142_1 = class142_2;
								class142_2.class142_0 = class2;
								@class.class142_0 = class142_;
								Class141 class3 = this.method_41();
								class3.class142_0 = class2;
								this.method_85(class3);
								if (this.method_81(class3.class142_0, @class.class142_0))
								{
									class3.bool_0 = !@class.bool_0;
									class3.class141_0 = @class;
								}
								else if (this.method_81(@class.class142_0, class3.class142_0))
								{
									class3.bool_0 = @class.bool_0;
									@class.bool_0 = !class3.bool_0;
									class3.class141_0 = @class.class141_0;
									@class.class141_0 = class3;
								}
								else
								{
									class3.bool_0 = @class.bool_0;
									class3.class141_0 = @class.class141_0;
								}
								class2 = class142_;
							}
						}
						class142_ = class142_.class142_0;
					}
					while (class142_ != @class.class142_0);
				}
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00072CB0 File Offset: 0x00070EB0
		public static double smethod_11(List<IntPoint> list_5)
		{
			int count = list_5.Count;
			if (count < 3)
			{
				return 0.0;
			}
			double num = 0.0;
			int i = 0;
			int index = count - 1;
			while (i < count)
			{
				num += ((double)list_5[index].long_0 + (double)list_5[i].long_0) * ((double)list_5[index].long_1 - (double)list_5[i].long_1);
				index = i;
				i++;
			}
			return -num * 0.5;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00072D34 File Offset: 0x00070F34
		private double method_87(Class141 class141_0)
		{
			Class142 class142_ = class141_0.class142_0;
			if (class142_ == null)
			{
				return 0.0;
			}
			double num = 0.0;
			do
			{
				num += (double)(class142_.class142_1.intPoint_0.long_0 + class142_.intPoint_0.long_0) * (double)(class142_.class142_1.intPoint_0.long_1 - class142_.intPoint_0.long_1);
				class142_ = class142_.class142_0;
			}
			while (class142_ != class141_0.class142_0);
			return num * 0.5;
		}

		// Token: 0x04000464 RID: 1124
		private List<Class141> list_1;

		// Token: 0x04000465 RID: 1125
		private Enum19 enum19_0;

		// Token: 0x04000466 RID: 1126
		private Class140 class140_0;

		// Token: 0x04000467 RID: 1127
		private Class136 class136_0;

		// Token: 0x04000468 RID: 1128
		private Class136 class136_1;

		// Token: 0x04000469 RID: 1129
		private List<Class137> list_2;

		// Token: 0x0400046A RID: 1130
		private IComparer<Class137> icomparer_0;

		// Token: 0x0400046B RID: 1131
		private bool bool_3;

		// Token: 0x0400046C RID: 1132
		private Enum21 enum21_0;

		// Token: 0x0400046D RID: 1133
		private Enum21 enum21_1;

		// Token: 0x0400046E RID: 1134
		private List<Class143> list_3;

		// Token: 0x0400046F RID: 1135
		private List<Class143> list_4;

		// Token: 0x04000470 RID: 1136
		private bool bool_4;

		// Token: 0x04000471 RID: 1137
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x04000472 RID: 1138
		[CompilerGenerated]
		private bool bool_6;
	}
}
