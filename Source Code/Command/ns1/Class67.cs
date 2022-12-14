using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns1
{
	// Token: 0x0200006C RID: 108
	internal sealed class Class67
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x00058A8C File Offset: 0x00056C8C
		public Class67(int[,] int_11)
		{
			if (int_11 == null)
			{
				throw new Exception("Grid cannot be null");
			}
			this.int_0 = int_11;
			this.ushort_4 = (ushort)(this.int_0.GetUpperBound(0) + 1);
			this.ushort_5 = (ushort)(this.int_0.GetUpperBound(1) + 1);
			this.ushort_6 = this.ushort_4 - 1;
			this.ushort_7 = (ushort)Math.Log((double)this.ushort_5, 2.0);
			if (Math.Log((double)this.ushort_4, 2.0) == (double)((int)Math.Log((double)this.ushort_4, 2.0)))
			{
				if (Math.Log((double)this.ushort_5, 2.0) == (double)((int)Math.Log((double)this.ushort_5, 2.0)))
				{
					if (this.struct14_0 == null || this.struct14_0.Length != (int)(this.ushort_4 * this.ushort_5))
					{
						this.struct14_0 = new Class67.Struct14[(int)(this.ushort_4 * this.ushort_5)];
					}
					this.class69_0 = new Class69<int>(new Class67.Class68(this.struct14_0));
					return;
				}
			}
			throw new Exception("Invalid Grid, size in X and Y must be power of 2");
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00003B89 File Offset: 0x00001D89
		public void vmethod_0(Enum3 enum3_1)
		{
			this.enum3_0 = enum3_1;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00058C20 File Offset: 0x00056E20
		public void vmethod_1(bool bool_12)
		{
			this.bool_2 = bool_12;
			if (this.bool_2)
			{
				this.sbyte_0 = new sbyte[,]
				{
					{
						0,
						-1
					},
					{
						1,
						0
					},
					{
						0,
						1
					},
					{
						-1,
						0
					},
					{
						1,
						-1
					},
					{
						1,
						1
					},
					{
						-1,
						1
					},
					{
						-1,
						-1
					}
				};
				return;
			}
			this.sbyte_0 = new sbyte[,]
			{
				{
					0,
					-1
				},
				{
					1,
					0
				},
				{
					0,
					1
				},
				{
					-1,
					0
				}
			};
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00003B92 File Offset: 0x00001D92
		public void vmethod_2(bool bool_12)
		{
			this.bool_8 = bool_12;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00003B9B File Offset: 0x00001D9B
		public void vmethod_3(bool bool_12)
		{
			this.bool_3 = bool_12;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00003BA4 File Offset: 0x00001DA4
		public void method_0(bool bool_12)
		{
			this.bool_4 = bool_12;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00003BAD File Offset: 0x00001DAD
		public void method_1(bool bool_12)
		{
			this.bool_5 = bool_12;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00003BB6 File Offset: 0x00001DB6
		public void vmethod_4(bool bool_12)
		{
			this.bool_6 = bool_12;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00003BBF File Offset: 0x00001DBF
		public void vmethod_5(bool bool_12)
		{
			this.bool_7 = bool_12;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00003BC8 File Offset: 0x00001DC8
		public void vmethod_6(int int_11)
		{
			this.int_3 = int_11;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00003BD1 File Offset: 0x00001DD1
		public void method_2(int int_11)
		{
			this.int_4 = int_11;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00003BDA File Offset: 0x00001DDA
		public void vmethod_7(bool bool_12)
		{
			this.bool_9 = bool_12;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00058C70 File Offset: 0x00056E70
		public List<Struct13> vmethod_8(Point point_0, Point point_1)
		{
			List<Struct13> result;
			lock (this)
			{
				Class64.smethod_0();
				this.bool_11 = false;
				this.bool_0 = false;
				this.bool_1 = false;
				this.int_8 = 0;
				this.byte_0 += 2;
				this.byte_1 += 2;
				this.class69_0.method_1();
				this.list_0.Clear();
				if (this.bool_9 && this.delegate5_0 != null)
				{
					this.delegate5_0(0, 0, point_0.X, point_0.Y, Enum2.const_0, -1, -1);
				}
				if (this.bool_9 && this.delegate5_0 != null)
				{
					this.delegate5_0(0, 0, point_1.X, point_1.Y, Enum2.const_1, -1, -1);
				}
				this.int_6 = (point_0.Y << (int)this.ushort_7) + point_0.X;
				this.int_9 = (point_1.Y << (int)this.ushort_7) + point_1.X;
				this.struct14_0[this.int_6].int_1 = 0;
				this.struct14_0[this.int_6].int_0 = this.int_2;
				this.struct14_0[this.int_6].ushort_0 = (ushort)point_0.X;
				this.struct14_0[this.int_6].ushort_1 = (ushort)point_0.Y;
				this.struct14_0[this.int_6].byte_0 = this.byte_0;
				this.class69_0.vmethod_1(this.int_6);
				while (this.class69_0.method_2() > 0 && !this.bool_0)
				{
					this.int_6 = this.class69_0.vmethod_2();
					if (this.struct14_0[this.int_6].byte_0 != this.byte_1)
					{
						this.ushort_0 = (ushort)(this.int_6 & (int)this.ushort_6);
						this.ushort_1 = (ushort)(this.int_6 >> (int)this.ushort_7);
						if (this.bool_9 && this.delegate5_0 != null)
						{
							this.delegate5_0(0, 0, this.int_6 & (int)this.ushort_6, this.int_6 >> (int)this.ushort_7, Enum2.const_4, -1, -1);
						}
						if (this.int_6 == this.int_9)
						{
							this.struct14_0[this.int_6].byte_0 = this.byte_1;
							this.bool_11 = true;
							break;
						}
						if (this.int_8 > this.int_3)
						{
							this.bool_1 = true;
							this.double_0 = Class64.smethod_1();
							return null;
						}
						if (this.bool_3)
						{
							this.int_1 = (int)(this.ushort_0 - this.struct14_0[this.int_6].ushort_0);
						}
						for (int i = 0; i < ((!this.bool_2) ? 4 : 8); i++)
						{
							this.ushort_2 = this.ushort_0 + (ushort)this.sbyte_0[i, 0];
							this.ushort_3 = this.ushort_1 + (ushort)this.sbyte_0[i, 1];
							this.int_7 = ((int)this.ushort_3 << (int)this.ushort_7) + (int)this.ushort_2;
							if (this.ushort_2 < this.ushort_4 && this.ushort_3 < this.ushort_5 && (this.struct14_0[this.int_7].byte_0 != this.byte_1 || this.bool_6) && this.int_0[(int)this.ushort_2, (int)this.ushort_3] != 0)
							{
								if (this.int_0[(int)this.ushort_2, (int)this.ushort_3] == this.int_4)
								{
									this.struct14_0[this.int_7].bool_0 = true;
								}
								if (this.bool_8 && i > 3)
								{
									this.int_10 = this.struct14_0[this.int_6].int_1 + (int)((double)this.int_0[(int)this.ushort_2, (int)this.ushort_3] * 2.41);
								}
								else if (i > 3)
								{
									this.int_10 = this.struct14_0[this.int_6].int_1 + (int)((double)this.int_0[(int)this.ushort_2, (int)this.ushort_3] * Class67.double_1);
								}
								else
								{
									this.int_10 = this.struct14_0[this.int_6].int_1 + this.int_0[(int)this.ushort_2, (int)this.ushort_3];
								}
								if (this.bool_3)
								{
									if (this.ushort_2 - this.ushort_0 != 0 && this.int_1 == 0)
									{
										this.int_10 += Math.Abs((int)this.ushort_2 - point_1.X) + Math.Abs((int)this.ushort_3 - point_1.Y);
									}
									if (this.ushort_3 - this.ushort_1 != 0 && this.int_1 != 0)
									{
										this.int_10 += Math.Abs((int)this.ushort_2 - point_1.X) + Math.Abs((int)this.ushort_3 - point_1.Y);
									}
								}
								if ((this.struct14_0[this.int_7].byte_0 != this.byte_0 && this.struct14_0[this.int_7].byte_0 != this.byte_1) || this.struct14_0[this.int_7].int_1 > this.int_10)
								{
									this.struct14_0[this.int_7].ushort_0 = this.ushort_0;
									this.struct14_0[this.int_7].ushort_1 = this.ushort_1;
									this.struct14_0[this.int_7].int_1 = this.int_10;
									switch (this.enum3_0)
									{
									default:
										this.int_5 = this.int_2 * (Math.Abs((int)this.ushort_2 - point_1.X) + Math.Abs((int)this.ushort_3 - point_1.Y));
										break;
									case Enum3.const_1:
										this.int_5 = this.int_2 * Math.Max(Math.Abs((int)this.ushort_2 - point_1.X), Math.Abs((int)this.ushort_3 - point_1.Y));
										break;
									case Enum3.const_2:
									{
										int num = Math.Min(Math.Abs((int)this.ushort_2 - point_1.X), Math.Abs((int)this.ushort_3 - point_1.Y));
										int num2 = Math.Abs((int)this.ushort_2 - point_1.X) + Math.Abs((int)this.ushort_3 - point_1.Y);
										this.int_5 = this.int_2 * 2 * num + this.int_2 * (num2 - 2 * num);
										break;
									}
									case Enum3.const_3:
										this.int_5 = (int)((double)this.int_2 * Math.Sqrt(Math.Pow((double)((int)this.ushort_2 - point_1.X), 2.0) + Math.Pow((double)((int)this.ushort_3 - point_1.Y), 2.0)));
										break;
									case Enum3.const_4:
										this.int_5 = (int)((double)this.int_2 * (Math.Pow((double)((int)this.ushort_2 - point_1.X), 2.0) + Math.Pow((double)((int)this.ushort_3 - point_1.Y), 2.0)));
										break;
									case Enum3.const_5:
									{
										Point point = new Point(Math.Abs(point_1.X - (int)this.ushort_2), Math.Abs(point_1.Y - (int)this.ushort_3));
										int num3 = Math.Abs(point.X - point.Y);
										int num4 = Math.Abs((point.X + point.Y - num3) / 2);
										this.int_5 = this.int_2 * (num4 + num3 + point.X + point.Y);
										break;
									}
									}
									if (this.bool_7)
									{
										int num5 = (int)this.ushort_0 - point_1.X;
										int num6 = (int)this.ushort_1 - point_1.Y;
										int num7 = point_0.X - point_1.X;
										int num8 = point_0.Y - point_1.Y;
										int num9 = Math.Abs(num5 * num8 - num7 * num6);
										this.int_5 = (int)((double)this.int_5 + (double)num9 * 0.001);
									}
									this.struct14_0[this.int_7].int_0 = this.int_10 + this.int_5;
									if (this.bool_9 && this.delegate5_0 != null)
									{
										this.delegate5_0((int)this.ushort_0, (int)this.ushort_1, (int)this.ushort_2, (int)this.ushort_3, Enum2.const_2, this.struct14_0[this.int_7].int_0, this.struct14_0[this.int_7].int_1);
									}
									this.class69_0.vmethod_1(this.int_7);
									this.struct14_0[this.int_7].byte_0 = this.byte_0;
								}
							}
						}
						this.int_8++;
						this.struct14_0[this.int_6].byte_0 = this.byte_1;
						if (this.bool_9 && this.delegate5_0 != null)
						{
							this.delegate5_0(0, 0, (int)this.ushort_0, (int)this.ushort_1, Enum2.const_3, this.struct14_0[this.int_6].int_0, this.struct14_0[this.int_6].int_1);
						}
					}
				}
				if (this.bool_4)
				{
					for (int j = 0; j < ((!this.bool_2) ? 4 : 8); j++)
					{
						ushort num10 = (ushort)(point_0.X + (int)this.sbyte_0[j, 0]);
						ushort num11 = (ushort)(point_0.Y + (int)this.sbyte_0[j, 1]);
						if (num10 < this.ushort_4 && num11 < this.ushort_5 && this.int_0[(int)num10, (int)num11] == 0)
						{
							this.struct14_0[this.int_6].bool_0 = true;
							break;
						}
					}
					for (int k = 0; k < ((!this.bool_2) ? 4 : 8); k++)
					{
						ushort num12 = (ushort)(point_1.X + (int)this.sbyte_0[k, 0]);
						ushort num13 = (ushort)(point_1.Y + (int)this.sbyte_0[k, 1]);
						if (num12 < this.ushort_4 && num13 < this.ushort_5 && this.int_0[(int)num12, (int)num13] == 0)
						{
							this.struct14_0[this.int_9].bool_0 = true;
							break;
						}
					}
				}
				this.double_0 = Class64.smethod_1();
				if (this.bool_11)
				{
					this.list_0.Clear();
					int x = point_1.X;
					int y = point_1.Y;
					Class67.Struct14 @struct = this.struct14_0[(point_1.Y << (int)this.ushort_7) + point_1.X];
					Struct13 struct2;
					struct2.int_0 = @struct.int_0;
					struct2.int_1 = @struct.int_1;
					struct2.int_2 = 0;
					struct2.int_5 = (int)@struct.ushort_0;
					struct2.int_6 = (int)@struct.ushort_1;
					struct2.int_3 = point_1.X;
					struct2.int_4 = point_1.Y;
					struct2.bool_0 = @struct.bool_0;
					struct2.bool_1 = @struct.bool_1;
					while (struct2.int_3 != struct2.int_5 || struct2.int_4 != struct2.int_6)
					{
						this.list_0.Add(struct2);
						if (this.bool_10 && this.delegate5_0 != null)
						{
							this.delegate5_0(struct2.int_5, struct2.int_6, struct2.int_3, struct2.int_4, Enum2.const_5, struct2.int_0, struct2.int_1);
						}
						x = struct2.int_5;
						y = struct2.int_6;
						@struct = this.struct14_0[(y << (int)this.ushort_7) + x];
						struct2.int_0 = @struct.int_0;
						struct2.int_1 = @struct.int_1;
						struct2.int_2 = 0;
						struct2.int_5 = (int)@struct.ushort_0;
						struct2.int_6 = (int)@struct.ushort_1;
						struct2.int_3 = x;
						struct2.int_4 = y;
						struct2.bool_0 = @struct.bool_0;
						struct2.bool_1 = @struct.bool_1;
					}
					this.list_0.Add(struct2);
					if (this.bool_10 && this.delegate5_0 != null)
					{
						this.delegate5_0(struct2.int_5, struct2.int_6, struct2.int_3, struct2.int_4, Enum2.const_5, struct2.int_0, struct2.int_1);
					}
					int count = this.list_0.Count;
					if (this.bool_5 && count > 0)
					{
						List<Struct13> list = new List<Struct13>();
						for (int l = count - 1; l > -1; l--)
						{
							Struct13 struct3 = this.list_0[l];
							if (this.method_3(ref l, ref count, ref struct3, false))
							{
								struct3 = this.list_0[l];
								struct3.bool_1 = true;
								this.list_0[l] = struct3;
							}
						}
						for (int m = 0; m < count; m++)
						{
							Struct13 struct3 = this.list_0[m];
							if (!struct3.bool_1 && (m >= count - 1 || !this.list_0[m + 1].bool_1) && (m <= 1 || !this.list_0[m - 1].bool_1) && this.method_3(ref m, ref count, ref struct3, true))
							{
								struct3 = this.list_0[m];
								struct3.bool_1 = true;
								this.list_0[m] = struct3;
							}
						}
						for (int n = 0; n < count; n++)
						{
							Struct13 struct3 = this.list_0[n];
							if (struct3.bool_1)
							{
								list.Add(struct3);
							}
						}
						if (list.Count > 0)
						{
							this.list_0 = null;
							this.list_0 = list;
						}
					}
					this.bool_1 = true;
					result = this.list_0;
				}
				else
				{
					this.bool_1 = true;
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00059B78 File Offset: 0x00057D78
		public bool method_3(ref int int_11, ref int int_12, ref Struct13 struct13_0, bool bool_12)
		{
			if (int_11 == int_12 - 1)
			{
				return struct13_0.bool_0;
			}
			if (int_11 == 0)
			{
				return struct13_0.bool_0;
			}
			if (struct13_0.bool_0)
			{
				return true;
			}
			int num = struct13_0.int_3;
			int num2 = struct13_0.int_4;
			int num5;
			int num6;
			if (bool_12)
			{
				int num3 = this.list_0[int_11 - 1].int_3;
				int num4 = this.list_0[int_11 - 1].int_4;
				num5 = num3 - num;
				num6 = num4 - num2;
			}
			else
			{
				int num3 = this.list_0[int_11 + 1].int_3;
				int num4 = this.list_0[int_11 + 1].int_4;
				num5 = num - num3;
				num6 = num2 - num4;
			}
			int num7;
			if (num5 > 0)
			{
				if (num6 > 0)
				{
					num7 = 1;
				}
				else if (num6 < 0)
				{
					num7 = 3;
				}
				else
				{
					num7 = 2;
				}
			}
			else if (num5 < 0)
			{
				if (num6 > 0)
				{
					num7 = 7;
				}
				else if (num6 < 0)
				{
					num7 = 5;
				}
				else
				{
					num7 = 6;
				}
			}
			else if (num6 > 0)
			{
				num7 = 0;
			}
			else
			{
				if (num6 >= 0)
				{
					return false;
				}
				num7 = 4;
			}
			int num8 = struct13_0.int_3;
			int num9 = struct13_0.int_3;
			int num10 = struct13_0.int_4;
			int num11 = struct13_0.int_4;
			int i = int_11;
			while (i >= 1)
			{
				if (i > int_12 - 2)
				{
					int_11 = i - 1;
					return false;
				}
				Struct13 @struct = this.list_0[i];
				Struct13 struct2;
				if (bool_12)
				{
					struct2 = this.list_0[i + 1];
					num5 = @struct.int_3 - struct2.int_3;
					num6 = @struct.int_4 - struct2.int_4;
				}
				else
				{
					struct2 = this.list_0[i - 1];
					num5 = struct2.int_3 - @struct.int_3;
					num6 = struct2.int_4 - @struct.int_4;
				}
				if (num7 == 0)
				{
					if (num5 > Math.Abs(num6))
					{
						int_11 = i;
						return true;
					}
				}
				else
				{
					if (num7 == 1)
					{
						if (num6 >= 0)
						{
							if (num5 >= 0)
							{
								goto IL_25D;
							}
						}
						int_11 = i;
						return true;
					}
					if (num7 == 2)
					{
						if (num6 > Math.Abs(num5))
						{
							int_11 = i;
							return true;
						}
					}
					else
					{
						if (num7 == 3)
						{
							if (num6 <= 0)
							{
								if (num5 >= 0)
								{
									goto IL_25D;
								}
							}
							int_11 = i;
							return true;
						}
						if (num7 == 4)
						{
							if (Math.Abs(num5) > Math.Abs(num6))
							{
								int_11 = i;
								return true;
							}
						}
						else
						{
							if (num7 == 5)
							{
								if (num6 <= 0)
								{
									if (num5 <= 0)
									{
										goto IL_25D;
									}
								}
								int_11 = i;
								return true;
							}
							if (num7 == 6)
							{
								if (Math.Abs(num6) > Math.Abs(num5))
								{
									int_11 = i;
									return true;
								}
							}
							else if (num7 == 7 && (num6 < 0 || num5 > 0))
							{
								int_11 = i;
								return true;
							}
						}
					}
				}
				IL_25D:
				if (struct2.int_3 > num8)
				{
					num8 = struct2.int_3;
					for (int j = num11; j <= num10; j++)
					{
						if (this.int_0[struct2.int_3, j] == 0 || struct2.bool_0)
						{
							int_11 = i;
							return true;
						}
					}
				}
				else if (struct2.int_3 < num9)
				{
					num9 = struct2.int_3;
					for (int k = num11; k <= num10; k++)
					{
						if (this.int_0[struct2.int_3, k] == 0 || struct2.bool_0)
						{
							int_11 = i;
							return true;
						}
					}
				}
				if (struct2.int_4 > num10)
				{
					num10 = struct2.int_4;
					for (int l = num9; l <= num8; l++)
					{
						if (this.int_0[l, struct2.int_4] == 0 || struct2.bool_0)
						{
							int_11 = i;
							return true;
						}
					}
				}
				else if (struct2.int_4 < num11)
				{
					num11 = struct2.int_4;
					for (int m = num9; m <= num8; m++)
					{
						if (this.int_0[m, struct2.int_4] == 0 || struct2.bool_0)
						{
							int_11 = i;
							return true;
						}
					}
				}
				if (bool_12)
				{
					i++;
				}
				else
				{
					i--;
				}
			}
			int_11 = i + 1;
			return false;
		}

		// Token: 0x04000118 RID: 280
		[CompilerGenerated]
		private Delegate5 delegate5_0;

		// Token: 0x04000119 RID: 281
		private int[,] int_0;

		// Token: 0x0400011A RID: 282
		private Class69<int> class69_0;

		// Token: 0x0400011B RID: 283
		private List<Struct13> list_0 = new List<Struct13>();

		// Token: 0x0400011C RID: 284
		private bool bool_0;

		// Token: 0x0400011D RID: 285
		private bool bool_1 = true;

		// Token: 0x0400011E RID: 286
		private int int_1;

		// Token: 0x0400011F RID: 287
		private Enum3 enum3_0 = Enum3.const_0;

		// Token: 0x04000120 RID: 288
		private bool bool_2 = true;

		// Token: 0x04000121 RID: 289
		private int int_2 = 2;

		// Token: 0x04000122 RID: 290
		private bool bool_3;

		// Token: 0x04000123 RID: 291
		private bool bool_4;

		// Token: 0x04000124 RID: 292
		private bool bool_5;

		// Token: 0x04000125 RID: 293
		private bool bool_6 = true;

		// Token: 0x04000126 RID: 294
		private bool bool_7;

		// Token: 0x04000127 RID: 295
		private bool bool_8;

		// Token: 0x04000128 RID: 296
		private int int_3 = 2000;

		// Token: 0x04000129 RID: 297
		private double double_0;

		// Token: 0x0400012A RID: 298
		private bool bool_9;

		// Token: 0x0400012B RID: 299
		private bool bool_10;

		// Token: 0x0400012C RID: 300
		private Class67.Struct14[] struct14_0;

		// Token: 0x0400012D RID: 301
		private byte byte_0 = 1;

		// Token: 0x0400012E RID: 302
		private byte byte_1 = 2;

		// Token: 0x0400012F RID: 303
		private int int_4;

		// Token: 0x04000130 RID: 304
		private int int_5;

		// Token: 0x04000131 RID: 305
		private int int_6;

		// Token: 0x04000132 RID: 306
		private int int_7;

		// Token: 0x04000133 RID: 307
		private ushort ushort_0;

		// Token: 0x04000134 RID: 308
		private ushort ushort_1;

		// Token: 0x04000135 RID: 309
		private ushort ushort_2;

		// Token: 0x04000136 RID: 310
		private ushort ushort_3;

		// Token: 0x04000137 RID: 311
		private int int_8;

		// Token: 0x04000138 RID: 312
		private ushort ushort_4;

		// Token: 0x04000139 RID: 313
		private ushort ushort_5;

		// Token: 0x0400013A RID: 314
		private ushort ushort_6;

		// Token: 0x0400013B RID: 315
		private ushort ushort_7;

		// Token: 0x0400013C RID: 316
		private bool bool_11;

		// Token: 0x0400013D RID: 317
		private sbyte[,] sbyte_0 = new sbyte[,]
		{
			{
				0,
				-1
			},
			{
				1,
				0
			},
			{
				0,
				1
			},
			{
				-1,
				0
			},
			{
				1,
				-1
			},
			{
				1,
				1
			},
			{
				-1,
				1
			},
			{
				-1,
				-1
			}
		};

		// Token: 0x0400013E RID: 318
		private int int_9;

		// Token: 0x0400013F RID: 319
		private int int_10;

		// Token: 0x04000140 RID: 320
		private static readonly double double_1 = Math.Sqrt(2.0);

		// Token: 0x0200006D RID: 109
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct Struct14
		{
			// Token: 0x04000141 RID: 321
			public int int_0;

			// Token: 0x04000142 RID: 322
			public int int_1;

			// Token: 0x04000143 RID: 323
			public ushort ushort_0;

			// Token: 0x04000144 RID: 324
			public ushort ushort_1;

			// Token: 0x04000145 RID: 325
			public byte byte_0;

			// Token: 0x04000146 RID: 326
			public bool bool_0;

			// Token: 0x04000147 RID: 327
			public bool bool_1;
		}

		// Token: 0x0200006E RID: 110
		internal sealed class Class68 : IComparer<int>
		{
			// Token: 0x060001E8 RID: 488 RVA: 0x00003BF8 File Offset: 0x00001DF8
			public Class68(Class67.Struct14[] struct14_1)
			{
				this.struct14_0 = struct14_1;
			}

			// Token: 0x060001E9 RID: 489 RVA: 0x00059F84 File Offset: 0x00058184
			public int Compare(int x, int y)
			{
				if (this.struct14_0[x].int_0 > this.struct14_0[y].int_0)
				{
					return 1;
				}
				if (this.struct14_0[x].int_0 < this.struct14_0[y].int_0)
				{
					return -1;
				}
				return 0;
			}

			// Token: 0x04000148 RID: 328
			private Class67.Struct14[] struct14_0;
		}
	}
}
