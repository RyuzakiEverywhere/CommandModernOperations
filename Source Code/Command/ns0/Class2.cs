using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000004 RID: 4
	internal sealed class Class2
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00053E74 File Offset: 0x00052074
		public static byte[] smethod_0(byte[] byte_0)
		{
			Assembly callingAssembly = Assembly.GetCallingAssembly();
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (callingAssembly != Assembly.GetExecutingAssembly())
			{
				byte[] publicKey = executingAssembly.GetName().GetPublicKey();
				byte[] publicKey2 = callingAssembly.GetName().GetPublicKey();
				if (publicKey2 == null != (publicKey == null))
				{
					return null;
				}
				if (publicKey2 != null)
				{
					for (int i = 0; i < publicKey2.Length; i++)
					{
						if (publicKey2[i] != publicKey[i])
						{
							return null;
						}
					}
				}
			}
			Class2.Stream0 stream = new Class2.Stream0(byte_0);
			byte[] array = new byte[0];
			int num = stream.method_1();
			if (num == 67324752)
			{
				short num2 = (short)stream.method_0();
				int num3 = stream.method_0();
				int num4 = stream.method_0();
				checked
				{
					if (num == 67324752 && num2 == 20 && num3 == 0)
					{
						if (num4 == 8)
						{
							stream.method_1();
							stream.method_1();
							stream.method_1();
							int num5 = stream.method_1();
							int num6 = stream.method_0();
							int num7 = stream.method_0();
							if (num6 > 0)
							{
								byte[] buffer = new byte[(uint)num6];
								stream.Read(buffer, 0, num6);
							}
							if (num7 > 0)
							{
								byte[] buffer2 = new byte[(uint)num7];
								stream.Read(buffer2, 0, num7);
							}
							byte[] array2 = new byte[(uint)(unchecked(stream.Length - stream.Position))];
							stream.Read(array2, 0, array2.Length);
							Class2.Class3 @class = new Class2.Class3(array2);
							array = new byte[(uint)num5];
							@class.method_2(array, 0, array.Length);
							goto IL_2E2;
						}
					}
					throw new FormatException("Wrong Header Signature");
				}
			}
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 == 1)
			{
				int num9 = stream.method_1();
				array = new byte[checked((uint)num9)];
				int num11;
				for (int j = 0; j < num9; j += num11)
				{
					int num10 = stream.method_1();
					num11 = stream.method_1();
					byte[] array3 = new byte[checked((uint)num10)];
					stream.Read(array3, 0, array3.Length);
					Class2.Class3 class2 = new Class2.Class3(array3);
					class2.method_2(array, j, num11);
				}
			}
			if (num8 == 2)
			{
				Class1 class3 = new Class1();
				byte[] byte_ = new byte[]
				{
					106,
					217,
					218,
					144,
					35,
					234,
					150,
					127
				};
				byte[] byte_2 = new byte[]
				{
					195,
					103,
					15,
					150,
					123,
					122,
					140,
					123
				};
				ICryptoTransform cryptoTransform = class3.method_0(byte_, byte_2, true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				class3.method_1();
				array = Class2.smethod_0(byte_3);
			}
			if (num8 == 3)
			{
				Class0 class4 = new Class0();
				byte[] byte_4 = new byte[]
				{
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1
				};
				byte[] byte_5 = new byte[]
				{
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2
				};
				ICryptoTransform cryptoTransform2 = class4.method_0(byte_4, byte_5, true);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				class4.method_1();
				array = Class2.smethod_0(byte_6);
			}
			IL_2E2:
			stream.Close();
			return array;
		}

		// Token: 0x02000005 RID: 5
		internal sealed class Class3
		{
			// Token: 0x06000008 RID: 8 RVA: 0x00002840 File Offset: 0x00000A40
			public Class3(byte[] byte_0)
			{
				this.class4_0 = new Class2.Class4();
				this.class5_0 = new Class2.Class5();
				this.int_4 = 2;
				this.class4_0.method_7(byte_0, 0, byte_0.Length);
			}

			// Token: 0x06000009 RID: 9 RVA: 0x00054170 File Offset: 0x00052370
			private bool method_0()
			{
				int i = this.class5_0.method_4();
				while (i >= 258)
				{
					int num;
					switch (this.int_4)
					{
					case 7:
						while (((num = this.class6_0.method_1(this.class4_0)) & -256) == 0)
						{
							this.class5_0.method_0(num);
							if (--i < 258)
							{
								return true;
							}
						}
						if (num >= 257)
						{
							this.int_6 = Class2.Class3.int_0[num - 257];
							this.int_5 = Class2.Class3.int_1[num - 257];
							goto IL_9E;
						}
						if (num < 0)
						{
							return false;
						}
						this.class6_1 = null;
						this.class6_0 = null;
						this.int_4 = 2;
						return true;
					case 8:
						goto IL_9E;
					case 9:
						goto IL_EE;
					case 10:
						break;
					default:
						continue;
					}
					IL_121:
					if (this.int_5 > 0)
					{
						this.int_4 = 10;
						int num2 = this.class4_0.method_0(this.int_5);
						if (num2 < 0)
						{
							return false;
						}
						this.class4_0.method_1(this.int_5);
						this.int_7 += num2;
					}
					this.class5_0.method_2(this.int_6, this.int_7);
					i -= this.int_6;
					this.int_4 = 7;
					continue;
					IL_EE:
					num = this.class6_1.method_1(this.class4_0);
					if (num >= 0)
					{
						this.int_7 = Class2.Class3.int_2[num];
						this.int_5 = Class2.Class3.int_3[num];
						goto IL_121;
					}
					return false;
					IL_9E:
					if (this.int_5 > 0)
					{
						this.int_4 = 8;
						int num3 = this.class4_0.method_0(this.int_5);
						if (num3 < 0)
						{
							return false;
						}
						this.class4_0.method_1(this.int_5);
						this.int_6 += num3;
					}
					this.int_4 = 9;
					goto IL_EE;
				}
				return true;
			}

			// Token: 0x0600000A RID: 10 RVA: 0x0005433C File Offset: 0x0005253C
			private bool method_1()
			{
				switch (this.int_4)
				{
				case 2:
				{
					if (this.bool_0)
					{
						this.int_4 = 12;
						return false;
					}
					int num = this.class4_0.method_0(3);
					if (num < 0)
					{
						return false;
					}
					this.class4_0.method_1(3);
					if ((num & 1) != 0)
					{
						this.bool_0 = true;
					}
					switch (num >> 1)
					{
					case 0:
						this.class4_0.method_4();
						this.int_4 = 3;
						break;
					case 1:
						this.class6_0 = Class2.Class6.class6_0;
						this.class6_1 = Class2.Class6.class6_1;
						this.int_4 = 7;
						break;
					case 2:
						this.class7_0 = new Class2.Class7();
						this.int_4 = 6;
						break;
					}
					return true;
				}
				case 3:
					if ((this.int_8 = this.class4_0.method_0(16)) < 0)
					{
						return false;
					}
					this.class4_0.method_1(16);
					this.int_4 = 4;
					break;
				case 4:
					break;
				case 5:
					goto IL_133;
				case 6:
					if (!this.class7_0.method_0(this.class4_0))
					{
						return false;
					}
					this.class6_0 = this.class7_0.method_1();
					this.class6_1 = this.class7_0.method_2();
					this.int_4 = 7;
					goto IL_1B7;
				case 7:
				case 8:
				case 9:
				case 10:
					goto IL_1B7;
				case 11:
					return false;
				case 12:
					return false;
				default:
					return false;
				}
				int num2 = this.class4_0.method_0(16);
				if (num2 < 0)
				{
					return false;
				}
				this.class4_0.method_1(16);
				this.int_4 = 5;
				IL_133:
				int num3 = this.class5_0.method_3(this.class4_0, this.int_8);
				this.int_8 -= num3;
				if (this.int_8 == 0)
				{
					this.int_4 = 2;
					return true;
				}
				return !this.class4_0.method_5();
				IL_1B7:
				return this.method_0();
			}

			// Token: 0x0600000B RID: 11 RVA: 0x0005450C File Offset: 0x0005270C
			public int method_2(byte[] byte_0, int int_9, int int_10)
			{
				int num = 0;
				for (;;)
				{
					if (this.int_4 != 11)
					{
						int num2 = this.class5_0.method_6(byte_0, int_9, int_10);
						int_9 += num2;
						num += num2;
						int_10 -= num2;
						if (int_10 == 0)
						{
							return num;
						}
					}
					if (!this.method_1())
					{
						if (this.class5_0.method_5() <= 0)
						{
							break;
						}
						if (this.int_4 == 11)
						{
							break;
						}
					}
				}
				return num;
			}

			// Token: 0x04000005 RID: 5
			private static int[] int_0 = new int[]
			{
				3,
				4,
				5,
				6,
				7,
				8,
				9,
				10,
				11,
				13,
				15,
				17,
				19,
				23,
				27,
				31,
				35,
				43,
				51,
				59,
				67,
				83,
				99,
				115,
				131,
				163,
				195,
				227,
				258
			};

			// Token: 0x04000006 RID: 6
			private static int[] int_1 = new int[]
			{
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				1,
				1,
				1,
				2,
				2,
				2,
				2,
				3,
				3,
				3,
				3,
				4,
				4,
				4,
				4,
				5,
				5,
				5,
				5,
				0
			};

			// Token: 0x04000007 RID: 7
			private static int[] int_2 = new int[]
			{
				1,
				2,
				3,
				4,
				5,
				7,
				9,
				13,
				17,
				25,
				33,
				49,
				65,
				97,
				129,
				193,
				257,
				385,
				513,
				769,
				1025,
				1537,
				2049,
				3073,
				4097,
				6145,
				8193,
				12289,
				16385,
				24577
			};

			// Token: 0x04000008 RID: 8
			private static int[] int_3 = new int[]
			{
				0,
				0,
				0,
				0,
				1,
				1,
				2,
				2,
				3,
				3,
				4,
				4,
				5,
				5,
				6,
				6,
				7,
				7,
				8,
				8,
				9,
				9,
				10,
				10,
				11,
				11,
				12,
				12,
				13,
				13
			};

			// Token: 0x04000009 RID: 9
			private int int_4;

			// Token: 0x0400000A RID: 10
			private int int_5;

			// Token: 0x0400000B RID: 11
			private int int_6;

			// Token: 0x0400000C RID: 12
			private int int_7;

			// Token: 0x0400000D RID: 13
			private int int_8;

			// Token: 0x0400000E RID: 14
			private bool bool_0;

			// Token: 0x0400000F RID: 15
			private Class2.Class4 class4_0;

			// Token: 0x04000010 RID: 16
			private Class2.Class5 class5_0;

			// Token: 0x04000011 RID: 17
			private Class2.Class7 class7_0;

			// Token: 0x04000012 RID: 18
			private Class2.Class6 class6_0;

			// Token: 0x04000013 RID: 19
			private Class2.Class6 class6_1;
		}

		// Token: 0x02000006 RID: 6
		internal sealed class Class4
		{
			// Token: 0x0600000D RID: 13 RVA: 0x000545DC File Offset: 0x000527DC
			public int method_0(int int_3)
			{
				if (this.int_2 < int_3)
				{
					if (this.int_0 == this.int_1)
					{
						return -1;
					}
					this.uint_0 |= (uint)((uint)((int)(this.byte_0[this.int_0++] & byte.MaxValue) | (int)(this.byte_0[this.int_0++] & byte.MaxValue) << 8) << this.int_2);
					this.int_2 += 16;
				}
				return (int)((ulong)this.uint_0 & (ulong)((long)((1 << int_3) - 1)));
			}

			// Token: 0x0600000E RID: 14 RVA: 0x00002875 File Offset: 0x00000A75
			public void method_1(int int_3)
			{
				this.uint_0 >>= int_3;
				this.int_2 -= int_3;
			}

			// Token: 0x0600000F RID: 15 RVA: 0x00002896 File Offset: 0x00000A96
			public int method_2()
			{
				return this.int_2;
			}

			// Token: 0x06000010 RID: 16 RVA: 0x0000289E File Offset: 0x00000A9E
			public int method_3()
			{
				return this.int_1 - this.int_0 + (this.int_2 >> 3);
			}

			// Token: 0x06000011 RID: 17 RVA: 0x000028B6 File Offset: 0x00000AB6
			public void method_4()
			{
				this.uint_0 >>= (this.int_2 & 7);
				this.int_2 &= -8;
			}

			// Token: 0x06000012 RID: 18 RVA: 0x000028DF File Offset: 0x00000ADF
			public bool method_5()
			{
				return this.int_0 == this.int_1;
			}

			// Token: 0x06000013 RID: 19 RVA: 0x0005467C File Offset: 0x0005287C
			public int method_6(byte[] byte_1, int int_3, int int_4)
			{
				int num = 0;
				while (this.int_2 > 0 && int_4 > 0)
				{
					byte_1[int_3++] = (byte)this.uint_0;
					this.uint_0 >>= 8;
					this.int_2 -= 8;
					int_4--;
					num++;
				}
				if (int_4 == 0)
				{
					return num;
				}
				int num2 = this.int_1 - this.int_0;
				if (int_4 > num2)
				{
					int_4 = num2;
				}
				Array.Copy(this.byte_0, this.int_0, byte_1, int_3, int_4);
				this.int_0 += int_4;
				if ((this.int_0 - this.int_1 & 1) != 0)
				{
					this.uint_0 = (uint)(this.byte_0[this.int_0++] & byte.MaxValue);
					this.int_2 = 8;
				}
				return num + int_4;
			}

			// Token: 0x06000015 RID: 21 RVA: 0x0005474C File Offset: 0x0005294C
			public void method_7(byte[] byte_1, int int_3, int int_4)
			{
				if (this.int_0 < this.int_1)
				{
					throw new InvalidOperationException();
				}
				int num = int_3 + int_4;
				if (0 <= int_3 && int_3 <= num && num <= byte_1.Length)
				{
					if ((int_4 & 1) != 0)
					{
						this.uint_0 |= (uint)((uint)(byte_1[int_3++] & byte.MaxValue) << this.int_2);
						this.int_2 += 8;
					}
					this.byte_0 = byte_1;
					this.int_0 = int_3;
					this.int_1 = num;
					return;
				}
				throw new ArgumentOutOfRangeException();
			}

			// Token: 0x04000014 RID: 20
			private byte[] byte_0;

			// Token: 0x04000015 RID: 21
			private int int_0 = 0;

			// Token: 0x04000016 RID: 22
			private int int_1 = 0;

			// Token: 0x04000017 RID: 23
			private uint uint_0 = 0U;

			// Token: 0x04000018 RID: 24
			private int int_2 = 0;
		}

		// Token: 0x02000007 RID: 7
		internal sealed class Class5
		{
			// Token: 0x06000016 RID: 22 RVA: 0x000547D4 File Offset: 0x000529D4
			public void method_0(int int_4)
			{
				if (this.int_3++ == Class2.Class5.int_0)
				{
					throw new InvalidOperationException();
				}
				this.byte_0[this.int_2++] = (byte)int_4;
				this.int_2 &= Class2.Class5.int_1;
			}

			// Token: 0x06000017 RID: 23 RVA: 0x0005482C File Offset: 0x00052A2C
			private void method_1(int int_4, int int_5, int int_6)
			{
				while (int_5-- > 0)
				{
					this.byte_0[this.int_2++] = this.byte_0[int_4++];
					this.int_2 &= Class2.Class5.int_1;
					int_4 &= Class2.Class5.int_1;
				}
			}

			// Token: 0x06000018 RID: 24 RVA: 0x00054888 File Offset: 0x00052A88
			public void method_2(int int_4, int int_5)
			{
				if ((this.int_3 += int_4) > Class2.Class5.int_0)
				{
					throw new InvalidOperationException();
				}
				int num = this.int_2 - int_5 & Class2.Class5.int_1;
				int num2 = Class2.Class5.int_0 - int_4;
				if (num > num2 || this.int_2 >= num2)
				{
					this.method_1(num, int_4, int_5);
					return;
				}
				if (int_4 <= int_5)
				{
					Array.Copy(this.byte_0, num, this.byte_0, this.int_2, int_4);
					this.int_2 += int_4;
					return;
				}
				while (int_4-- > 0)
				{
					this.byte_0[this.int_2++] = this.byte_0[num++];
				}
			}

			// Token: 0x06000019 RID: 25 RVA: 0x0005493C File Offset: 0x00052B3C
			public int method_3(Class2.Class4 class4_0, int int_4)
			{
				int_4 = Math.Min(Math.Min(int_4, Class2.Class5.int_0 - this.int_3), class4_0.method_3());
				int num = Class2.Class5.int_0 - this.int_2;
				int num2;
				if (int_4 > num)
				{
					num2 = class4_0.method_6(this.byte_0, this.int_2, num);
					if (num2 == num)
					{
						num2 += class4_0.method_6(this.byte_0, 0, int_4 - num);
					}
				}
				else
				{
					num2 = class4_0.method_6(this.byte_0, this.int_2, int_4);
				}
				this.int_2 = (this.int_2 + num2 & Class2.Class5.int_1);
				this.int_3 += num2;
				return num2;
			}

			// Token: 0x0600001A RID: 26 RVA: 0x00002913 File Offset: 0x00000B13
			public int method_4()
			{
				return Class2.Class5.int_0 - this.int_3;
			}

			// Token: 0x0600001B RID: 27 RVA: 0x00002921 File Offset: 0x00000B21
			public int method_5()
			{
				return this.int_3;
			}

			// Token: 0x0600001C RID: 28 RVA: 0x000549E0 File Offset: 0x00052BE0
			public int method_6(byte[] byte_1, int int_4, int int_5)
			{
				int num = this.int_2;
				if (int_5 > this.int_3)
				{
					int_5 = this.int_3;
				}
				else
				{
					num = (this.int_2 - this.int_3 + int_5 & Class2.Class5.int_1);
				}
				int num2 = int_5;
				int num3 = int_5 - num;
				if (num3 > 0)
				{
					Array.Copy(this.byte_0, Class2.Class5.int_0 - num3, byte_1, int_4, num3);
					int_4 += num3;
					int_5 = num;
				}
				Array.Copy(this.byte_0, num - int_5, byte_1, int_4, int_5);
				this.int_3 -= num2;
				if (this.int_3 < 0)
				{
					throw new InvalidOperationException();
				}
				return num2;
			}

			// Token: 0x04000019 RID: 25
			private static int int_0 = 32768;

			// Token: 0x0400001A RID: 26
			private static int int_1 = Class2.Class5.int_0 - 1;

			// Token: 0x0400001B RID: 27
			private byte[] byte_0 = new byte[checked((uint)Class2.Class5.int_0)];

			// Token: 0x0400001C RID: 28
			private int int_2 = 0;

			// Token: 0x0400001D RID: 29
			private int int_3 = 0;
		}

		// Token: 0x02000008 RID: 8
		internal sealed class Class6
		{
			// Token: 0x0600001F RID: 31 RVA: 0x00054A74 File Offset: 0x00052C74
			static Class6()
			{
				byte[] array = new byte[288];
				int i = 0;
				while (i < 144)
				{
					array[i++] = 8;
				}
				while (i < 256)
				{
					array[i++] = 9;
				}
				while (i < 280)
				{
					array[i++] = 7;
				}
				while (i < 288)
				{
					array[i++] = 8;
				}
				Class2.Class6.class6_0 = new Class2.Class6(array);
				array = new byte[32];
				i = 0;
				while (i < 32)
				{
					array[i++] = 5;
				}
				Class2.Class6.class6_1 = new Class2.Class6(array);
			}

			// Token: 0x06000020 RID: 32 RVA: 0x00002968 File Offset: 0x00000B68
			public Class6(byte[] byte_0)
			{
				this.method_0(byte_0);
			}

			// Token: 0x06000021 RID: 33 RVA: 0x00054B10 File Offset: 0x00052D10
			private void method_0(byte[] byte_0)
			{
				int[] array;
				int[] array2;
				checked
				{
					array = new int[(uint)(unchecked(Class2.Class6.int_0 + 1))];
					array2 = new int[(uint)(unchecked(Class2.Class6.int_0 + 1))];
				}
				foreach (int num in byte_0)
				{
					if (num > 0)
					{
						int[] array3;
						IntPtr intPtr;
						(array3 = array)[(int)(intPtr = (IntPtr)num)] = array3[(int)intPtr] + 1;
					}
				}
				int num2 = 0;
				int num3 = 512;
				for (int j = 1; j <= Class2.Class6.int_0; j++)
				{
					array2[j] = num2;
					num2 += array[j] << 16 - j;
					if (j >= 10)
					{
						int num4 = array2[j] & 130944;
						int num5 = num2 & 130944;
						num3 += num5 - num4 >> 16 - j;
					}
				}
				this.short_0 = new short[checked((uint)num3)];
				int num6 = 512;
				for (int k = Class2.Class6.int_0; k >= 10; k--)
				{
					int num7 = num2 & 130944;
					num2 -= array[k] << 16 - k;
					int num8 = num2 & 130944;
					for (int l = num8; l < num7; l += 128)
					{
						this.short_0[(int)Class2.Class8.smethod_0(l)] = (short)(-num6 << 4 | k);
						num6 += 1 << k - 9;
					}
				}
				for (int m = 0; m < byte_0.Length; m++)
				{
					int num9 = (int)byte_0[m];
					if (num9 != 0)
					{
						num2 = array2[num9];
						int num10 = (int)Class2.Class8.smethod_0(num2);
						if (num9 <= 9)
						{
							do
							{
								this.short_0[num10] = (short)(m << 4 | num9);
								num10 += 1 << num9;
							}
							while (num10 < 512);
						}
						else
						{
							int num11 = (int)this.short_0[num10 & 511];
							int num12 = 1 << (num11 & 15);
							num11 = -(num11 >> 4);
							do
							{
								this.short_0[num11 | num10 >> 9] = (short)(m << 4 | num9);
								num10 += 1 << num9;
							}
							while (num10 < num12);
						}
						array2[num9] = num2 + (1 << 16 - num9);
					}
				}
			}

			// Token: 0x06000022 RID: 34 RVA: 0x00054D10 File Offset: 0x00052F10
			public int method_1(Class2.Class4 class4_0)
			{
				int num;
				if ((num = class4_0.method_0(9)) >= 0)
				{
					int num2;
					if ((num2 = (int)this.short_0[num]) >= 0)
					{
						class4_0.method_1(num2 & 15);
						return num2 >> 4;
					}
					int num3 = -(num2 >> 4);
					int int_ = num2 & 15;
					if ((num = class4_0.method_0(int_)) >= 0)
					{
						num2 = (int)this.short_0[num3 | num >> 9];
						class4_0.method_1(num2 & 15);
						return num2 >> 4;
					}
					int num4 = class4_0.method_2();
					num = class4_0.method_0(num4);
					num2 = (int)this.short_0[num3 | num >> 9];
					if ((num2 & 15) <= num4)
					{
						class4_0.method_1(num2 & 15);
						return num2 >> 4;
					}
					return -1;
				}
				else
				{
					int num5 = class4_0.method_2();
					num = class4_0.method_0(num5);
					int num2 = (int)this.short_0[num];
					if (num2 >= 0 && (num2 & 15) <= num5)
					{
						class4_0.method_1(num2 & 15);
						return num2 >> 4;
					}
					return -1;
				}
			}

			// Token: 0x0400001E RID: 30
			private static int int_0 = 15;

			// Token: 0x0400001F RID: 31
			private short[] short_0;

			// Token: 0x04000020 RID: 32
			public static Class2.Class6 class6_0;

			// Token: 0x04000021 RID: 33
			public static Class2.Class6 class6_1;
		}

		// Token: 0x02000009 RID: 9
		internal sealed class Class7
		{
			// Token: 0x06000024 RID: 36 RVA: 0x00054DE8 File Offset: 0x00052FE8
			public bool method_0(Class2.Class4 class4_0)
			{
				for (;;)
				{
					switch (this.int_2)
					{
					case 0:
						this.int_3 = class4_0.method_0(5);
						if (this.int_3 >= 0)
						{
							this.int_3 += 257;
							class4_0.method_1(5);
							this.int_2 = 1;
							goto IL_1DD;
						}
						return false;
					case 1:
						goto IL_1DD;
					case 2:
						goto IL_18F;
					case 3:
						goto IL_156;
					case 4:
						break;
					case 5:
						goto IL_2C;
					default:
						continue;
					}
					IL_E1:
					int num;
					while (((num = this.class6_0.method_1(class4_0)) & -16) == 0)
					{
						this.byte_1[this.int_8++] = (this.byte_2 = (byte)num);
						if (this.int_8 == this.int_6)
						{
							return true;
						}
					}
					if (num >= 0)
					{
						if (num >= 17)
						{
							this.byte_2 = 0;
						}
						this.int_7 = num - 16;
						this.int_2 = 5;
						goto IL_2C;
					}
					return false;
					IL_156:
					while (this.int_8 < this.int_5)
					{
						int num2 = class4_0.method_0(3);
						if (num2 < 0)
						{
							return false;
						}
						class4_0.method_1(3);
						this.byte_0[Class2.Class7.int_9[this.int_8]] = (byte)num2;
						this.int_8++;
					}
					this.class6_0 = new Class2.Class6(this.byte_0);
					this.byte_0 = null;
					this.int_8 = 0;
					this.int_2 = 4;
					goto IL_E1;
					IL_2C:
					int num3 = Class2.Class7.int_1[this.int_7];
					int num4 = class4_0.method_0(num3);
					if (num4 < 0)
					{
						return false;
					}
					class4_0.method_1(num3);
					num4 += Class2.Class7.int_0[this.int_7];
					while (num4-- > 0)
					{
						this.byte_1[this.int_8++] = this.byte_2;
					}
					if (this.int_8 == this.int_6)
					{
						break;
					}
					this.int_2 = 4;
					continue;
					IL_18F:
					this.int_5 = class4_0.method_0(4);
					if (this.int_5 >= 0)
					{
						this.int_5 += 4;
						class4_0.method_1(4);
						this.byte_0 = new byte[19];
						this.int_8 = 0;
						this.int_2 = 3;
						goto IL_156;
					}
					return false;
					IL_1DD:
					this.int_4 = class4_0.method_0(5);
					if (this.int_4 >= 0)
					{
						this.int_4++;
						class4_0.method_1(5);
						this.int_6 = this.int_3 + this.int_4;
						this.byte_1 = new byte[checked((uint)this.int_6)];
						this.int_2 = 2;
						goto IL_18F;
					}
					return false;
				}
				return true;
			}

			// Token: 0x06000025 RID: 37 RVA: 0x00055084 File Offset: 0x00053284
			public Class2.Class6 method_1()
			{
				byte[] destinationArray = new byte[checked((uint)this.int_3)];
				Array.Copy(this.byte_1, 0, destinationArray, 0, this.int_3);
				return new Class2.Class6(destinationArray);
			}

			// Token: 0x06000026 RID: 38 RVA: 0x000550B8 File Offset: 0x000532B8
			public Class2.Class6 method_2()
			{
				byte[] destinationArray = new byte[checked((uint)this.int_4)];
				Array.Copy(this.byte_1, this.int_3, destinationArray, 0, this.int_4);
				return new Class2.Class6(destinationArray);
			}

			// Token: 0x04000022 RID: 34
			private static readonly int[] int_0 = new int[]
			{
				3,
				3,
				11
			};

			// Token: 0x04000023 RID: 35
			private static readonly int[] int_1 = new int[]
			{
				2,
				3,
				7
			};

			// Token: 0x04000024 RID: 36
			private byte[] byte_0;

			// Token: 0x04000025 RID: 37
			private byte[] byte_1;

			// Token: 0x04000026 RID: 38
			private Class2.Class6 class6_0;

			// Token: 0x04000027 RID: 39
			private int int_2;

			// Token: 0x04000028 RID: 40
			private int int_3;

			// Token: 0x04000029 RID: 41
			private int int_4;

			// Token: 0x0400002A RID: 42
			private int int_5;

			// Token: 0x0400002B RID: 43
			private int int_6;

			// Token: 0x0400002C RID: 44
			private int int_7;

			// Token: 0x0400002D RID: 45
			private byte byte_2;

			// Token: 0x0400002E RID: 46
			private int int_8;

			// Token: 0x0400002F RID: 47
			private static readonly int[] int_9 = new int[]
			{
				16,
				17,
				18,
				0,
				8,
				7,
				9,
				6,
				10,
				5,
				11,
				4,
				12,
				3,
				13,
				2,
				14,
				1,
				15
			};
		}

		// Token: 0x0200000A RID: 10
		internal sealed class Class8
		{
			// Token: 0x06000028 RID: 40 RVA: 0x0000297F File Offset: 0x00000B7F
			public static short smethod_0(int int_9)
			{
				return (short)((int)Class2.Class8.byte_0[int_9 & 15] << 12 | (int)Class2.Class8.byte_0[int_9 >> 4 & 15] << 8 | (int)Class2.Class8.byte_0[int_9 >> 8 & 15] << 4 | (int)Class2.Class8.byte_0[int_9 >> 12]);
			}

			// Token: 0x06000029 RID: 41 RVA: 0x00055144 File Offset: 0x00053344
			static Class8()
			{
				int i;
				checked
				{
					Class2.Class8.short_0 = new short[(uint)Class2.Class8.int_1];
					Class2.Class8.byte_1 = new byte[(uint)Class2.Class8.int_1];
					i = 0;
				}
				while (i < 144)
				{
					Class2.Class8.short_0[i] = Class2.Class8.smethod_0(48 + i << 8);
					Class2.Class8.byte_1[i++] = 8;
				}
				while (i < 256)
				{
					Class2.Class8.short_0[i] = Class2.Class8.smethod_0(256 + i << 7);
					Class2.Class8.byte_1[i++] = 9;
				}
				while (i < 280)
				{
					Class2.Class8.short_0[i] = Class2.Class8.smethod_0(-256 + i << 9);
					Class2.Class8.byte_1[i++] = 7;
				}
				while (i < Class2.Class8.int_1)
				{
					Class2.Class8.short_0[i] = Class2.Class8.smethod_0(-88 + i << 8);
					Class2.Class8.byte_1[i++] = 8;
				}
				checked
				{
					Class2.Class8.short_1 = new short[(uint)Class2.Class8.int_2];
					Class2.Class8.byte_2 = new byte[(uint)Class2.Class8.int_2];
				}
				for (i = 0; i < Class2.Class8.int_2; i++)
				{
					Class2.Class8.short_1[i] = Class2.Class8.smethod_0(i << 11);
					Class2.Class8.byte_2[i] = 5;
				}
			}

			// Token: 0x04000030 RID: 48
			private static int int_0 = 16384;

			// Token: 0x04000031 RID: 49
			private static int int_1 = 286;

			// Token: 0x04000032 RID: 50
			private static int int_2 = 30;

			// Token: 0x04000033 RID: 51
			private static int int_3 = 19;

			// Token: 0x04000034 RID: 52
			private static int int_4 = 16;

			// Token: 0x04000035 RID: 53
			private static int int_5 = 17;

			// Token: 0x04000036 RID: 54
			private static int int_6 = 18;

			// Token: 0x04000037 RID: 55
			private static int int_7 = 256;

			// Token: 0x04000038 RID: 56
			private static int[] int_8 = new int[]
			{
				16,
				17,
				18,
				0,
				8,
				7,
				9,
				6,
				10,
				5,
				11,
				4,
				12,
				3,
				13,
				2,
				14,
				1,
				15
			};

			// Token: 0x04000039 RID: 57
			private static byte[] byte_0 = new byte[]
			{
				0,
				8,
				4,
				12,
				2,
				10,
				6,
				14,
				1,
				9,
				5,
				13,
				3,
				11,
				7,
				15
			};

			// Token: 0x0400003A RID: 58
			private static short[] short_0;

			// Token: 0x0400003B RID: 59
			private static byte[] byte_1;

			// Token: 0x0400003C RID: 60
			private static short[] short_1;

			// Token: 0x0400003D RID: 61
			private static byte[] byte_2;
		}

		// Token: 0x0200000B RID: 11
		internal sealed class Stream0 : MemoryStream
		{
			// Token: 0x0600002A RID: 42 RVA: 0x000029B8 File Offset: 0x00000BB8
			public int method_0()
			{
				return this.ReadByte() | this.ReadByte() << 8;
			}

			// Token: 0x0600002B RID: 43 RVA: 0x000029C9 File Offset: 0x00000BC9
			public int method_1()
			{
				return this.method_0() | this.method_0() << 16;
			}

			// Token: 0x0600002C RID: 44 RVA: 0x000029DB File Offset: 0x00000BDB
			public Stream0(byte[] byte_0) : base(byte_0, false)
			{
			}
		}
	}
}
