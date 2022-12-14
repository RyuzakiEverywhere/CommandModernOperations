using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns1
{
	// Token: 0x02000081 RID: 129
	[Description("Displays a value on an analog gauge. Raises an event if the value enters one of the definable ranges.")]
	internal sealed class Control0 : Control
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000424B File Offset: 0x0000244B
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00004253 File Offset: 0x00002453
		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00004269 File Offset: 0x00002469
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00004271 File Offset: 0x00002471
		public override Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				base.Font = value;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00004287 File Offset: 0x00002487
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0000428F File Offset: 0x0000248F
		public override ImageLayout BackgroundImageLayout
		{
			get
			{
				return base.BackgroundImageLayout;
			}
			set
			{
				base.BackgroundImageLayout = value;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0005DF9C File Offset: 0x0005C19C
		public Control0()
		{
			bool[] array = new bool[5];
			array[0] = true;
			array[1] = true;
			this.bool_2 = array;
			this.color_5 = new Color[]
			{
				Color.LightGreen,
				Color.Red,
				Color.FromKnownColor(KnownColor.Control),
				Color.FromKnownColor(KnownColor.Control),
				Color.FromKnownColor(KnownColor.Control)
			};
			float[] array2 = new float[5];
			array2[0] = -100f;
			array2[1] = 300f;
			this.float_6 = array2;
			float[] array3 = new float[5];
			array3[0] = 300f;
			array3[1] = 400f;
			this.float_7 = array3;
			this.int_14 = new int[]
			{
				70,
				70,
				70,
				70,
				70
			};
			this.int_15 = new int[]
			{
				80,
				80,
				80,
				80,
				80
			};
			this.int_16 = 95;
			this.color_6 = Color.Black;
			this.int_18 = 1;
			this.int_21 = 80;
			this.color_7 = Color.DimGray;
			this.int_22 = 2;
			base..ctor();
			this.method_57();
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000042A5 File Offset: 0x000024A5
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0005E27C File Offset: 0x0005C47C
		[Category("AGauge")]
		[Description("The value.")]
		public float Value
		{
			get
			{
				return this.float_2;
			}
			set
			{
				if (this.float_2 != value)
				{
					this.float_2 = Math.Min(Math.Max(value, this.float_3), this.float_4);
					if (base.DesignMode)
					{
						this.bool_0 = true;
					}
					for (int i = 0; i < 4; i++)
					{
						if (this.float_6[i] <= this.float_2 && this.float_2 <= this.float_7[i] && this.bool_2[i])
						{
							if (!this.bool_1[i] && this.delegate6_0 != null)
							{
								this.delegate6_0(this, new Control0.EventArgs2(i));
							}
						}
						else
						{
							this.bool_1[i] = false;
						}
					}
					this.Refresh();
				}
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000042AD File Offset: 0x000024AD
		public void method_0(byte byte_2)
		{
			if (this.byte_0 != byte_2 && 0 <= byte_2 && byte_2 < 5)
			{
				this.byte_0 = byte_2;
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000042C7 File Offset: 0x000024C7
		public void method_1(Color[] color_8)
		{
			this.color_0 = color_8;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000042D0 File Offset: 0x000024D0
		public void method_2(string string_2)
		{
			if (this.string_0[(int)this.byte_0] != string_2)
			{
				this.string_0[(int)this.byte_0] = string_2;
				this.method_3(this.string_0);
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0005E32C File Offset: 0x0005C52C
		public void method_3(string[] string_2)
		{
			for (int i = 0; i < 5; i++)
			{
				this.string_0[i] = string_2[i];
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0005E350 File Offset: 0x0005C550
		public void method_4(Point point_2)
		{
			if (this.point_0[(int)this.byte_0] != point_2)
			{
				this.point_0[(int)this.byte_0] = point_2;
				this.method_5(this.point_0);
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000430E File Offset: 0x0000250E
		public void method_5(Point[] point_2)
		{
			this.point_0 = point_2;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00004317 File Offset: 0x00002517
		public Point method_6()
		{
			return this.point_1;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000431F File Offset: 0x0000251F
		public void method_7(Point point_2)
		{
			if (this.point_1 != point_2)
			{
				this.point_1 = point_2;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00004343 File Offset: 0x00002543
		public float method_8()
		{
			return this.float_3;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000434B File Offset: 0x0000254B
		public void method_9(float float_8)
		{
			if (this.float_3 != float_8 && float_8 < this.float_4)
			{
				this.float_3 = float_8;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00004373 File Offset: 0x00002573
		public float method_10()
		{
			return this.float_4;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000437B File Offset: 0x0000257B
		public void method_11(float float_8)
		{
			if (this.float_4 != float_8 && float_8 > this.float_3)
			{
				this.float_4 = float_8;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000043A3 File Offset: 0x000025A3
		public void method_12(Color color_8)
		{
			if (this.color_1 != color_8)
			{
				this.color_1 = color_8;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000043C7 File Offset: 0x000025C7
		public void method_13(int int_23)
		{
			if (this.int_0 != int_23)
			{
				this.int_0 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000043E6 File Offset: 0x000025E6
		public void method_14(int int_23)
		{
			if (this.int_1 != int_23)
			{
				this.int_1 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00004405 File Offset: 0x00002605
		public void method_15(int int_23)
		{
			if (this.int_2 != int_23)
			{
				this.int_2 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00004424 File Offset: 0x00002624
		public void method_16(int int_23)
		{
			if (this.int_3 != int_23)
			{
				this.int_3 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00004443 File Offset: 0x00002643
		public void method_17(Color color_8)
		{
			if (this.color_2 != color_8)
			{
				this.color_2 = color_8;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00004467 File Offset: 0x00002667
		public void method_18(int int_23)
		{
			if (this.int_4 != int_23)
			{
				this.int_4 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00004486 File Offset: 0x00002686
		public void method_19(int int_23)
		{
			if (this.int_5 != int_23)
			{
				this.int_5 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000044A5 File Offset: 0x000026A5
		public void method_20(int int_23)
		{
			if (this.int_6 != int_23)
			{
				this.int_6 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000044C4 File Offset: 0x000026C4
		public void method_21(int int_23)
		{
			if (this.int_7 != int_23)
			{
				this.int_7 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000044E3 File Offset: 0x000026E3
		public void method_22(Color color_8)
		{
			if (this.color_3 != color_8)
			{
				this.color_3 = color_8;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00004507 File Offset: 0x00002707
		public void method_23(int int_23)
		{
			if (this.int_8 != int_23)
			{
				this.int_8 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00004526 File Offset: 0x00002726
		public void method_24(int int_23)
		{
			if (this.int_9 != int_23)
			{
				this.int_9 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00004545 File Offset: 0x00002745
		public void method_25(int int_23)
		{
			if (this.int_10 != int_23)
			{
				this.int_10 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00004564 File Offset: 0x00002764
		public void method_26(float float_8)
		{
			if (this.float_5 != float_8 && float_8 > 0f)
			{
				this.float_5 = Math.Max(Math.Min(float_8, this.float_4), this.float_3);
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000045A1 File Offset: 0x000027A1
		public void method_27(Color color_8)
		{
			if (this.color_4 != color_8)
			{
				this.color_4 = color_8;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000045C5 File Offset: 0x000027C5
		public void method_28(int int_23)
		{
			if (this.int_11 != int_23)
			{
				this.int_11 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000045E4 File Offset: 0x000027E4
		public void method_29(int int_23)
		{
			if (this.int_12 != int_23)
			{
				this.int_12 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00004603 File Offset: 0x00002803
		public void method_30(int int_23)
		{
			if (this.int_13 != int_23)
			{
				this.int_13 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00004622 File Offset: 0x00002822
		public void method_31(byte byte_2)
		{
			if (this.byte_1 != byte_2 && 0 <= byte_2 && byte_2 < 5)
			{
				this.byte_1 = byte_2;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00004649 File Offset: 0x00002849
		public void method_32(bool bool_3)
		{
			if (this.bool_2[(int)this.byte_1] != bool_3)
			{
				this.bool_2[(int)this.byte_1] = bool_3;
				this.method_33(this.bool_2);
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00004682 File Offset: 0x00002882
		public void method_33(bool[] bool_3)
		{
			this.bool_2 = bool_3;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0005E3A4 File Offset: 0x0005C5A4
		public void method_34(Color color_8)
		{
			if (this.color_5[(int)this.byte_1] != color_8)
			{
				this.color_5[(int)this.byte_1] = color_8;
				this.method_35(this.color_5);
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000468B File Offset: 0x0000288B
		public void method_35(Color[] color_8)
		{
			this.color_5 = color_8;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0005E3F8 File Offset: 0x0005C5F8
		public void method_36(float float_8)
		{
			if (this.float_6[(int)this.byte_1] != float_8 && float_8 < this.float_7[(int)this.byte_1])
			{
				this.float_6[(int)this.byte_1] = float_8;
				this.method_37(this.float_6);
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00004694 File Offset: 0x00002894
		public void method_37(float[] float_8)
		{
			this.float_6 = float_8;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0005E44C File Offset: 0x0005C64C
		public void method_38(float float_8)
		{
			if (this.float_7[(int)this.byte_1] != float_8 && this.float_6[(int)this.byte_1] < float_8)
			{
				this.float_7[(int)this.byte_1] = float_8;
				this.method_39(this.float_7);
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000469D File Offset: 0x0000289D
		public void method_39(float[] float_8)
		{
			this.float_7 = float_8;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000046A6 File Offset: 0x000028A6
		public void method_40(int int_23)
		{
			if (this.int_14[(int)this.byte_1] != int_23)
			{
				this.int_14[(int)this.byte_1] = int_23;
				this.method_41(this.int_14);
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000046DF File Offset: 0x000028DF
		public void method_41(int[] int_23)
		{
			this.int_14 = int_23;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000046E8 File Offset: 0x000028E8
		public void method_42(int int_23)
		{
			if (this.int_15[(int)this.byte_1] != int_23)
			{
				this.int_15[(int)this.byte_1] = int_23;
				this.method_43(this.int_15);
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00004721 File Offset: 0x00002921
		public void method_43(int[] int_23)
		{
			this.int_15 = int_23;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000472A File Offset: 0x0000292A
		public void method_44(int int_23)
		{
			if (this.int_16 != int_23)
			{
				this.int_16 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00004749 File Offset: 0x00002949
		public void method_45(Color color_8)
		{
			if (this.color_6 != color_8)
			{
				this.color_6 = color_8;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000476D File Offset: 0x0000296D
		public void method_46(string string_2)
		{
			if (this.string_1 != string_2)
			{
				this.string_1 = string_2;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00004791 File Offset: 0x00002991
		public int method_47()
		{
			return this.int_17;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00004799 File Offset: 0x00002999
		public void method_48(int int_23)
		{
			if (this.int_17 != int_23)
			{
				this.int_17 = Math.Max(int_23, 1);
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000047BE File Offset: 0x000029BE
		public void method_49(int int_23)
		{
			if (this.int_18 != int_23)
			{
				this.int_18 = Math.Max(int_23, 1);
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000047E3 File Offset: 0x000029E3
		public void method_50(int int_23)
		{
			if (this.int_19 != int_23)
			{
				this.int_19 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00004802 File Offset: 0x00002A02
		public void method_51(int int_23)
		{
			if (this.int_20 != int_23)
			{
				this.int_20 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00004821 File Offset: 0x00002A21
		public void method_52(int int_23)
		{
			if (this.int_21 != int_23)
			{
				this.int_21 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00004840 File Offset: 0x00002A40
		public void method_53(Control0.Enum6 enum6_1)
		{
			if (this.enum6_0 != enum6_1)
			{
				this.enum6_0 = enum6_1;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000485F File Offset: 0x00002A5F
		public void method_54(Color color_8)
		{
			if (this.color_7 != color_8)
			{
				this.color_7 = color_8;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00004883 File Offset: 0x00002A83
		public void method_55(int int_23)
		{
			if (this.int_22 != int_23)
			{
				this.int_22 = int_23;
				this.bool_0 = true;
				this.Refresh();
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0005E4A0 File Offset: 0x0005C6A0
		private void method_56()
		{
			SolidBrush solidBrush = new SolidBrush(Color.White);
			SolidBrush brush = new SolidBrush(Color.Black);
			Bitmap bitmap = new Bitmap(5, 5);
			SizeF sizeF = Graphics.FromImage(bitmap).MeasureString("0123456789", this.Font, -1, StringFormat.GenericTypographic);
			bitmap = new Bitmap((int)sizeF.Width, (int)sizeF.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.FillRectangle(solidBrush, 0f, 0f, sizeF.Width, sizeF.Height);
			graphics.DrawString("0123456789", this.Font, brush, 0f, 0f, StringFormat.GenericTypographic);
			this.float_0 = 0f;
			this.float_1 = 0f;
			int num = 0;
			bool flag = false;
			while (num < bitmap.Height && !flag)
			{
				int num2 = 0;
				while (num2 < bitmap.Width && !flag)
				{
					if (bitmap.GetPixel(num2, num) != solidBrush.Color)
					{
						this.float_0 = (float)num;
						flag = true;
					}
					num2++;
				}
				num++;
			}
			num = bitmap.Height - 1;
			flag = false;
			while (0 < num && !flag)
			{
				int num2 = 0;
				while (num2 < bitmap.Width && !flag)
				{
					if (bitmap.GetPixel(num2, num) != solidBrush.Color)
					{
						this.float_1 = (float)num;
						flag = true;
					}
					num2++;
				}
				num--;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000378C File Offset: 0x0000198C
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0005E5F4 File Offset: 0x0005C7F4
		protected override void OnPaint(PaintEventArgs e)
		{
			if (base.Width >= 10)
			{
				int height = base.Height;
			}
			if (this.bool_0)
			{
				this.bool_0 = false;
				this.method_56();
				this.bitmap_0 = new Bitmap(base.Width, base.Height, e.Graphics);
				Graphics graphics = Graphics.FromImage(this.bitmap_0);
				graphics.FillRectangle(new SolidBrush(this.BackColor), base.ClientRectangle);
				if (this.BackgroundImage != null)
				{
					switch (this.BackgroundImageLayout)
					{
					case ImageLayout.None:
						graphics.DrawImageUnscaled(this.BackgroundImage, 0, 0);
						break;
					case ImageLayout.Tile:
						for (int i = 0; i < base.Width; i += this.BackgroundImage.Width)
						{
							for (int j = 0; j < base.Height; j += this.BackgroundImage.Height)
							{
								graphics.DrawImageUnscaled(this.BackgroundImage, i, j);
							}
						}
						break;
					case ImageLayout.Center:
						graphics.DrawImageUnscaled(this.BackgroundImage, base.Width / 2 - this.BackgroundImage.Width / 2, base.Height / 2 - this.BackgroundImage.Height / 2);
						break;
					case ImageLayout.Stretch:
						graphics.DrawImage(this.BackgroundImage, 0, 0, base.Width, base.Height);
						break;
					case ImageLayout.Zoom:
						if ((float)(this.BackgroundImage.Width / base.Width) < (float)(this.BackgroundImage.Height / base.Height))
						{
							graphics.DrawImage(this.BackgroundImage, 0, 0, base.Height, base.Height);
						}
						else
						{
							graphics.DrawImage(this.BackgroundImage, 0, 0, base.Width, base.Width);
						}
						break;
					}
				}
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				GraphicsPath graphicsPath = new GraphicsPath();
				for (int k = 0; k < 5; k++)
				{
					if (this.float_7[k] > this.float_6[k] && this.bool_2[k])
					{
						float startAngle = (float)this.int_1 + (this.float_6[k] - this.float_3) * (float)this.int_2 / (this.float_4 - this.float_3);
						float sweepAngle = (this.float_7[k] - this.float_6[k]) * (float)this.int_2 / (this.float_4 - this.float_3);
						graphicsPath.Reset();
						graphicsPath.AddPie(new Rectangle(this.point_1.X - this.int_15[k], this.point_1.Y - this.int_15[k], 2 * this.int_15[k], 2 * this.int_15[k]), startAngle, sweepAngle);
						graphicsPath.Reverse();
						graphicsPath.AddPie(new Rectangle(this.point_1.X - this.int_14[k], this.point_1.Y - this.int_14[k], 2 * this.int_14[k], 2 * this.int_14[k]), startAngle, sweepAngle);
						graphicsPath.Reverse();
						graphics.SetClip(graphicsPath);
						graphics.FillPie(new SolidBrush(this.color_5[k]), new Rectangle(this.point_1.X - this.int_15[k], this.point_1.Y - this.int_15[k], 2 * this.int_15[k], 2 * this.int_15[k]), startAngle, sweepAngle);
					}
				}
				graphics.SetClip(base.ClientRectangle);
				if (this.int_0 > 0)
				{
					graphics.DrawArc(new Pen(this.color_1, (float)this.int_3), new Rectangle(this.point_1.X - this.int_0, this.point_1.Y - this.int_0, 2 * this.int_0, 2 * this.int_0), (float)this.int_1, (float)this.int_2);
				}
				float num = 0f;
				int num2 = 0;
				while (num <= this.float_4 - this.float_3)
				{
					string text = (this.float_3 + num).ToString(this.string_1);
					graphics.ResetTransform();
					SizeF sizeF = graphics.MeasureString(text, this.Font, -1, StringFormat.GenericTypographic);
					graphicsPath.Reset();
					graphicsPath.AddEllipse(new Rectangle(this.point_1.X - this.int_12, this.point_1.Y - this.int_12, 2 * this.int_12, 2 * this.int_12));
					graphicsPath.Reverse();
					graphicsPath.AddEllipse(new Rectangle(this.point_1.X - this.int_11, this.point_1.Y - this.int_11, 2 * this.int_11, 2 * this.int_11));
					graphicsPath.Reverse();
					graphics.SetClip(graphicsPath);
					graphics.DrawLine(new Pen(this.color_4, (float)this.int_13), (float)this.method_6().X, (float)this.method_6().Y, (float)((double)this.method_6().X + (double)(2 * this.int_12) * Math.Cos((double)((float)this.int_1 + num * (float)this.int_2 / (this.float_4 - this.float_3)) * 3.141592653589793 / 180.0)), (float)((double)this.method_6().Y + (double)(2 * this.int_12) * Math.Sin((double)((float)this.int_1 + num * (float)this.int_2 / (this.float_4 - this.float_3)) * 3.141592653589793 / 180.0)));
					graphicsPath.Reset();
					graphicsPath.AddEllipse(new Rectangle(this.point_1.X - this.int_9, this.point_1.Y - this.int_9, 2 * this.int_9, 2 * this.int_9));
					graphicsPath.Reverse();
					graphicsPath.AddEllipse(new Rectangle(this.point_1.X - this.int_8, this.point_1.Y - this.int_8, 2 * this.int_8, 2 * this.int_8));
					graphicsPath.Reverse();
					graphics.SetClip(graphicsPath);
					if (num < this.float_4 - this.float_3)
					{
						for (int l = 1; l <= this.int_7; l++)
						{
							if (this.int_7 % 2 == 1 && this.int_7 / 2 + 1 == l)
							{
								graphicsPath.Reset();
								graphicsPath.AddEllipse(new Rectangle(this.point_1.X - this.int_5, this.point_1.Y - this.int_5, 2 * this.int_5, 2 * this.int_5));
								graphicsPath.Reverse();
								graphicsPath.AddEllipse(new Rectangle(this.point_1.X - this.int_4, this.point_1.Y - this.int_4, 2 * this.int_4, 2 * this.int_4));
								graphicsPath.Reverse();
								graphics.SetClip(graphicsPath);
								graphics.DrawLine(new Pen(this.color_2, (float)this.int_6), (float)this.method_6().X, (float)this.method_6().Y, (float)((double)this.method_6().X + (double)(2 * this.int_5) * Math.Cos((double)((float)this.int_1 + num * (float)this.int_2 / (this.float_4 - this.float_3) + (float)(l * this.int_2) / ((this.float_4 - this.float_3) / this.float_5 * (float)(this.int_7 + 1))) * 3.141592653589793 / 180.0)), (float)((double)this.method_6().Y + (double)(2 * this.int_5) * Math.Sin((double)((float)this.int_1 + num * (float)this.int_2 / (this.float_4 - this.float_3) + (float)(l * this.int_2) / ((this.float_4 - this.float_3) / this.float_5 * (float)(this.int_7 + 1))) * 3.141592653589793 / 180.0)));
								graphicsPath.Reset();
								graphicsPath.AddEllipse(new Rectangle(this.point_1.X - this.int_9, this.point_1.Y - this.int_9, 2 * this.int_9, 2 * this.int_9));
								graphicsPath.Reverse();
								graphicsPath.AddEllipse(new Rectangle(this.point_1.X - this.int_8, this.point_1.Y - this.int_8, 2 * this.int_8, 2 * this.int_8));
								graphicsPath.Reverse();
								graphics.SetClip(graphicsPath);
							}
							else
							{
								graphics.DrawLine(new Pen(this.color_3, (float)this.int_10), (float)this.method_6().X, (float)this.method_6().Y, (float)((double)this.method_6().X + (double)(2 * this.int_9) * Math.Cos((double)((float)this.int_1 + num * (float)this.int_2 / (this.float_4 - this.float_3) + (float)(l * this.int_2) / ((this.float_4 - this.float_3) / this.float_5 * (float)(this.int_7 + 1))) * 3.141592653589793 / 180.0)), (float)((double)this.method_6().Y + (double)(2 * this.int_9) * Math.Sin((double)((float)this.int_1 + num * (float)this.int_2 / (this.float_4 - this.float_3) + (float)(l * this.int_2) / ((this.float_4 - this.float_3) / this.float_5 * (float)(this.int_7 + 1))) * 3.141592653589793 / 180.0)));
							}
						}
					}
					graphics.SetClip(base.ClientRectangle);
					if (this.int_19 != 0)
					{
						graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
						graphics.RotateTransform(90f + (float)this.int_1 + num * (float)this.int_2 / (this.float_4 - this.float_3));
					}
					graphics.TranslateTransform((float)((double)this.method_6().X + (double)this.int_16 * Math.Cos((double)((float)this.int_1 + num * (float)this.int_2 / (this.float_4 - this.float_3)) * 3.141592653589793 / 180.0)), (float)((double)this.method_6().Y + (double)this.int_16 * Math.Sin((double)((float)this.int_1 + num * (float)this.int_2 / (this.float_4 - this.float_3)) * 3.141592653589793 / 180.0)), MatrixOrder.Append);
					if (num2 >= this.method_47() - 1)
					{
						graphics.DrawString(text, this.Font, new SolidBrush(this.color_6), -sizeF.Width / 2f, -this.float_0 - (this.float_1 - this.float_0 + 1f) / 2f, StringFormat.GenericTypographic);
					}
					num += this.float_5;
					num2++;
				}
				graphics.ResetTransform();
				graphics.SetClip(base.ClientRectangle);
				if (this.int_19 != 0)
				{
					graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
				}
				for (int m = 0; m < 5; m++)
				{
					if (this.string_0[m] != "")
					{
						graphics.DrawString(this.string_0[m], this.Font, new SolidBrush(this.color_0[m]), (float)this.point_0[m].X, (float)this.point_0[m].Y, StringFormat.GenericTypographic);
					}
				}
			}
			if (!base.Enabled)
			{
				return;
			}
			e.Graphics.DrawImageUnscaled(this.bitmap_0, 0, 0);
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			float num3 = (float)((int)((float)this.int_1 + (this.float_2 - this.float_3) * (float)this.int_2 / (this.float_4 - this.float_3)) % 360);
			double num4 = (double)num3 * 3.141592653589793 / 180.0;
			int num5 = this.int_20;
			if (num5 == 0)
			{
				PointF[] array = new PointF[3];
				Brush brush = Brushes.White;
				Brush brush2 = Brushes.White;
				Brush brush3 = Brushes.White;
				Brush brush4 = Brushes.White;
				Brush white = Brushes.White;
				int num6 = (int)((num3 + 225f) % 180f * 100f / 180f);
				int num7 = (int)((num3 + 135f) % 180f * 100f / 180f);
				e.Graphics.FillEllipse(new SolidBrush(this.color_7), this.method_6().X - this.int_22 * 3, this.method_6().Y - this.int_22 * 3, this.int_22 * 6, this.int_22 * 6);
				switch (this.enum6_0)
				{
				case Control0.Enum6.const_0:
					brush = new SolidBrush(Color.FromArgb(80 + num6, 80 + num6, 80 + num6));
					brush2 = new SolidBrush(Color.FromArgb(180 - num6, 180 - num6, 180 - num6));
					brush3 = new SolidBrush(Color.FromArgb(80 + num7, 80 + num7, 80 + num7));
					brush4 = new SolidBrush(Color.FromArgb(180 - num7, 180 - num7, 180 - num7));
					e.Graphics.DrawEllipse(Pens.Gray, this.method_6().X - this.int_22 * 3, this.method_6().Y - this.int_22 * 3, this.int_22 * 6, this.int_22 * 6);
					break;
				case Control0.Enum6.const_1:
					brush = new SolidBrush(Color.FromArgb(145 + num6, num6, num6));
					brush2 = new SolidBrush(Color.FromArgb(245 - num6, 100 - num6, 100 - num6));
					brush3 = new SolidBrush(Color.FromArgb(145 + num7, num7, num7));
					brush4 = new SolidBrush(Color.FromArgb(245 - num7, 100 - num7, 100 - num7));
					e.Graphics.DrawEllipse(Pens.Red, this.method_6().X - this.int_22 * 3, this.method_6().Y - this.int_22 * 3, this.int_22 * 6, this.int_22 * 6);
					break;
				case Control0.Enum6.const_2:
					brush = new SolidBrush(Color.FromArgb(num6, 145 + num6, num6));
					brush2 = new SolidBrush(Color.FromArgb(100 - num6, 245 - num6, 100 - num6));
					brush3 = new SolidBrush(Color.FromArgb(num7, 145 + num7, num7));
					brush4 = new SolidBrush(Color.FromArgb(100 - num7, 245 - num7, 100 - num7));
					e.Graphics.DrawEllipse(Pens.Green, this.method_6().X - this.int_22 * 3, this.method_6().Y - this.int_22 * 3, this.int_22 * 6, this.int_22 * 6);
					break;
				case Control0.Enum6.const_3:
					brush = new SolidBrush(Color.FromArgb(num6, num6, 145 + num6));
					brush2 = new SolidBrush(Color.FromArgb(100 - num6, 100 - num6, 245 - num6));
					brush3 = new SolidBrush(Color.FromArgb(num7, num7, 145 + num7));
					brush4 = new SolidBrush(Color.FromArgb(100 - num7, 100 - num7, 245 - num7));
					e.Graphics.DrawEllipse(Pens.Blue, this.method_6().X - this.int_22 * 3, this.method_6().Y - this.int_22 * 3, this.int_22 * 6, this.int_22 * 6);
					break;
				case Control0.Enum6.const_4:
					brush = new SolidBrush(Color.FromArgb(145 + num6, 145 + num6, num6));
					brush2 = new SolidBrush(Color.FromArgb(245 - num6, 245 - num6, 100 - num6));
					brush3 = new SolidBrush(Color.FromArgb(145 + num7, 145 + num7, num7));
					brush4 = new SolidBrush(Color.FromArgb(245 - num7, 245 - num7, 100 - num7));
					e.Graphics.DrawEllipse(Pens.Violet, this.method_6().X - this.int_22 * 3, this.method_6().Y - this.int_22 * 3, this.int_22 * 6, this.int_22 * 6);
					break;
				case Control0.Enum6.const_5:
					brush = new SolidBrush(Color.FromArgb(145 + num6, num6, 145 + num6));
					brush2 = new SolidBrush(Color.FromArgb(245 - num6, 100 - num6, 245 - num6));
					brush3 = new SolidBrush(Color.FromArgb(145 + num7, num7, 145 + num7));
					brush4 = new SolidBrush(Color.FromArgb(245 - num7, 100 - num7, 245 - num7));
					e.Graphics.DrawEllipse(Pens.Violet, this.method_6().X - this.int_22 * 3, this.method_6().Y - this.int_22 * 3, this.int_22 * 6, this.int_22 * 6);
					break;
				case Control0.Enum6.const_6:
					brush = new SolidBrush(Color.FromArgb(num6, 145 + num6, 145 + num6));
					brush2 = new SolidBrush(Color.FromArgb(100 - num6, 245 - num6, 245 - num6));
					brush3 = new SolidBrush(Color.FromArgb(num7, 145 + num7, 145 + num7));
					brush4 = new SolidBrush(Color.FromArgb(100 - num7, 245 - num7, 245 - num7));
					e.Graphics.DrawEllipse(Pens.Magenta, this.method_6().X - this.int_22 * 3, this.method_6().Y - this.int_22 * 3, this.int_22 * 6, this.int_22 * 6);
					break;
				}
				if (Math.Floor((double)((float)((double)((num3 + 225f) % 360f) / 180.0))) == 0.0)
				{
					Brush brush5 = brush;
					brush = brush2;
					brush2 = brush5;
				}
				if (Math.Floor((double)((float)((double)((num3 + 135f) % 360f) / 180.0))) == 0.0)
				{
					brush4 = brush3;
				}
				array[0].X = (float)((double)this.method_6().X + (double)this.int_21 * Math.Cos(num4));
				array[0].Y = (float)((double)this.method_6().Y + (double)this.int_21 * Math.Sin(num4));
				array[1].X = (float)((double)this.method_6().X - (double)(this.int_21 / 20) * Math.Cos(num4));
				array[1].Y = (float)((double)this.method_6().Y - (double)(this.int_21 / 20) * Math.Sin(num4));
				array[2].X = (float)((double)this.method_6().X - (double)(this.int_21 / 5) * Math.Cos(num4) + (double)(this.int_22 * 2) * Math.Cos(num4 + 1.5707963267948966));
				array[2].Y = (float)((double)this.method_6().Y - (double)(this.int_21 / 5) * Math.Sin(num4) + (double)(this.int_22 * 2) * Math.Sin(num4 + 1.5707963267948966));
				e.Graphics.FillPolygon(brush, array);
				array[2].X = (float)((double)this.method_6().X - (double)(this.int_21 / 5) * Math.Cos(num4) + (double)(this.int_22 * 2) * Math.Cos(num4 - 1.5707963267948966));
				array[2].Y = (float)((double)this.method_6().Y - (double)(this.int_21 / 5) * Math.Sin(num4) + (double)(this.int_22 * 2) * Math.Sin(num4 - 1.5707963267948966));
				e.Graphics.FillPolygon(brush2, array);
				array[0].X = (float)((double)this.method_6().X - (double)(this.int_21 / 20 - 1) * Math.Cos(num4));
				array[0].Y = (float)((double)this.method_6().Y - (double)(this.int_21 / 20 - 1) * Math.Sin(num4));
				array[1].X = (float)((double)this.method_6().X - (double)(this.int_21 / 5) * Math.Cos(num4) + (double)(this.int_22 * 2) * Math.Cos(num4 + 1.5707963267948966));
				array[1].Y = (float)((double)this.method_6().Y - (double)(this.int_21 / 5) * Math.Sin(num4) + (double)(this.int_22 * 2) * Math.Sin(num4 + 1.5707963267948966));
				array[2].X = (float)((double)this.method_6().X - (double)(this.int_21 / 5) * Math.Cos(num4) + (double)(this.int_22 * 2) * Math.Cos(num4 - 1.5707963267948966));
				array[2].Y = (float)((double)this.method_6().Y - (double)(this.int_21 / 5) * Math.Sin(num4) + (double)(this.int_22 * 2) * Math.Sin(num4 - 1.5707963267948966));
				e.Graphics.FillPolygon(brush4, array);
				array[0].X = (float)((double)this.method_6().X - (double)(this.int_21 / 20) * Math.Cos(num4));
				array[0].Y = (float)((double)this.method_6().Y - (double)(this.int_21 / 20) * Math.Sin(num4));
				array[1].X = (float)((double)this.method_6().X + (double)this.int_21 * Math.Cos(num4));
				array[1].Y = (float)((double)this.method_6().Y + (double)this.int_21 * Math.Sin(num4));
				e.Graphics.DrawLine(new Pen(this.color_7), (float)this.method_6().X, (float)this.method_6().Y, array[0].X, array[0].Y);
				e.Graphics.DrawLine(new Pen(this.color_7), (float)this.method_6().X, (float)this.method_6().Y, array[1].X, array[1].Y);
				return;
			}
			if (num5 != 1)
			{
				return;
			}
			Point point = new Point((int)((double)this.method_6().X - (double)(this.int_21 / 8) * Math.Cos(num4)), (int)((double)this.method_6().Y - (double)(this.int_21 / 8) * Math.Sin(num4)));
			Point point2 = new Point((int)((double)this.method_6().X + (double)this.int_21 * Math.Cos(num4)), (int)((double)this.method_6().Y + (double)this.int_21 * Math.Sin(num4)));
			e.Graphics.FillEllipse(new SolidBrush(this.color_7), this.method_6().X - this.int_22 * 3, this.method_6().Y - this.int_22 * 3, this.int_22 * 6, this.int_22 * 6);
			switch (this.enum6_0)
			{
			case Control0.Enum6.const_0:
				e.Graphics.DrawLine(new Pen(Color.DarkGray, (float)this.int_22), this.method_6().X, this.method_6().Y, point2.X, point2.Y);
				e.Graphics.DrawLine(new Pen(Color.DarkGray, (float)this.int_22), this.method_6().X, this.method_6().Y, point.X, point.Y);
				return;
			case Control0.Enum6.const_1:
				e.Graphics.DrawLine(new Pen(Color.Red, (float)this.int_22), this.method_6().X, this.method_6().Y, point2.X, point2.Y);
				e.Graphics.DrawLine(new Pen(Color.Red, (float)this.int_22), this.method_6().X, this.method_6().Y, point.X, point.Y);
				return;
			case Control0.Enum6.const_2:
				e.Graphics.DrawLine(new Pen(Color.Green, (float)this.int_22), this.method_6().X, this.method_6().Y, point2.X, point2.Y);
				e.Graphics.DrawLine(new Pen(Color.Green, (float)this.int_22), this.method_6().X, this.method_6().Y, point.X, point.Y);
				return;
			case Control0.Enum6.const_3:
				e.Graphics.DrawLine(new Pen(Color.Blue, (float)this.int_22), this.method_6().X, this.method_6().Y, point2.X, point2.Y);
				e.Graphics.DrawLine(new Pen(Color.Blue, (float)this.int_22), this.method_6().X, this.method_6().Y, point.X, point.Y);
				return;
			case Control0.Enum6.const_4:
				e.Graphics.DrawLine(new Pen(Color.Yellow, (float)this.int_22), this.method_6().X, this.method_6().Y, point2.X, point2.Y);
				e.Graphics.DrawLine(new Pen(Color.Yellow, (float)this.int_22), this.method_6().X, this.method_6().Y, point.X, point.Y);
				return;
			case Control0.Enum6.const_5:
				e.Graphics.DrawLine(new Pen(Color.Violet, (float)this.int_22), this.method_6().X, this.method_6().Y, point2.X, point2.Y);
				e.Graphics.DrawLine(new Pen(Color.Violet, (float)this.int_22), this.method_6().X, this.method_6().Y, point.X, point.Y);
				return;
			case Control0.Enum6.const_6:
				e.Graphics.DrawLine(new Pen(Color.Magenta, (float)this.int_22), this.method_6().X, this.method_6().Y, point2.X, point2.Y);
				e.Graphics.DrawLine(new Pen(Color.Magenta, (float)this.int_22), this.method_6().X, this.method_6().Y, point.X, point.Y);
				return;
			default:
				return;
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000048A2 File Offset: 0x00002AA2
		protected override void OnResize(EventArgs e)
		{
			this.bool_0 = true;
			this.Refresh();
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000048B1 File Offset: 0x00002AB1
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000048D0 File Offset: 0x00002AD0
		private void method_57()
		{
			this.icontainer_0 = new Container();
		}

		// Token: 0x040001EB RID: 491
		private float float_0;

		// Token: 0x040001EC RID: 492
		private float float_1;

		// Token: 0x040001ED RID: 493
		private Bitmap bitmap_0;

		// Token: 0x040001EE RID: 494
		private bool bool_0 = true;

		// Token: 0x040001EF RID: 495
		private float float_2;

		// Token: 0x040001F0 RID: 496
		private bool[] bool_1 = new bool[5];

		// Token: 0x040001F1 RID: 497
		private byte byte_0 = 1;

		// Token: 0x040001F2 RID: 498
		private Color[] color_0 = new Color[]
		{
			Color.Black,
			Color.Black,
			Color.Black,
			Color.Black,
			Color.Black
		};

		// Token: 0x040001F3 RID: 499
		private string[] string_0 = new string[]
		{
			"",
			"",
			"",
			"",
			""
		};

		// Token: 0x040001F4 RID: 500
		private Point[] point_0 = new Point[]
		{
			new Point(10, 10),
			new Point(10, 10),
			new Point(10, 10),
			new Point(10, 10),
			new Point(10, 10)
		};

		// Token: 0x040001F5 RID: 501
		private Point point_1 = new Point(100, 100);

		// Token: 0x040001F6 RID: 502
		private float float_3 = -100f;

		// Token: 0x040001F7 RID: 503
		private float float_4 = 400f;

		// Token: 0x040001F8 RID: 504
		private Color color_1 = Color.Gray;

		// Token: 0x040001F9 RID: 505
		private int int_0 = 80;

		// Token: 0x040001FA RID: 506
		private int int_1 = 135;

		// Token: 0x040001FB RID: 507
		private int int_2 = 270;

		// Token: 0x040001FC RID: 508
		private int int_3 = 2;

		// Token: 0x040001FD RID: 509
		private Color color_2 = Color.Black;

		// Token: 0x040001FE RID: 510
		private int int_4 = 73;

		// Token: 0x040001FF RID: 511
		private int int_5 = 80;

		// Token: 0x04000200 RID: 512
		private int int_6 = 1;

		// Token: 0x04000201 RID: 513
		private int int_7 = 9;

		// Token: 0x04000202 RID: 514
		private Color color_3 = Color.Gray;

		// Token: 0x04000203 RID: 515
		private int int_8 = 75;

		// Token: 0x04000204 RID: 516
		private int int_9 = 80;

		// Token: 0x04000205 RID: 517
		private int int_10 = 1;

		// Token: 0x04000206 RID: 518
		private float float_5 = 50f;

		// Token: 0x04000207 RID: 519
		private Color color_4 = Color.Black;

		// Token: 0x04000208 RID: 520
		private int int_11 = 70;

		// Token: 0x04000209 RID: 521
		private int int_12 = 80;

		// Token: 0x0400020A RID: 522
		private int int_13 = 2;

		// Token: 0x0400020B RID: 523
		private byte byte_1;

		// Token: 0x0400020C RID: 524
		private bool[] bool_2;

		// Token: 0x0400020D RID: 525
		private Color[] color_5;

		// Token: 0x0400020E RID: 526
		private float[] float_6;

		// Token: 0x0400020F RID: 527
		private float[] float_7;

		// Token: 0x04000210 RID: 528
		private int[] int_14;

		// Token: 0x04000211 RID: 529
		private int[] int_15;

		// Token: 0x04000212 RID: 530
		private int int_16;

		// Token: 0x04000213 RID: 531
		private Color color_6;

		// Token: 0x04000214 RID: 532
		private string string_1;

		// Token: 0x04000215 RID: 533
		private int int_17;

		// Token: 0x04000216 RID: 534
		private int int_18;

		// Token: 0x04000217 RID: 535
		private int int_19;

		// Token: 0x04000218 RID: 536
		private int int_20;

		// Token: 0x04000219 RID: 537
		private int int_21;

		// Token: 0x0400021A RID: 538
		private Control0.Enum6 enum6_0;

		// Token: 0x0400021B RID: 539
		private Color color_7;

		// Token: 0x0400021C RID: 540
		private int int_22;

		// Token: 0x0400021D RID: 541
		[CompilerGenerated]
		private Control0.Delegate6 delegate6_0;

		// Token: 0x0400021E RID: 542
		private IContainer icontainer_0;

		// Token: 0x02000082 RID: 130
		internal enum Enum6
		{
			// Token: 0x04000220 RID: 544
			const_0,
			// Token: 0x04000221 RID: 545
			const_1,
			// Token: 0x04000222 RID: 546
			const_2,
			// Token: 0x04000223 RID: 547
			const_3,
			// Token: 0x04000224 RID: 548
			const_4,
			// Token: 0x04000225 RID: 549
			const_5,
			// Token: 0x04000226 RID: 550
			const_6
		}

		// Token: 0x02000083 RID: 131
		internal sealed class EventArgs2 : EventArgs
		{
			// Token: 0x060002C2 RID: 706 RVA: 0x000048DD File Offset: 0x00002ADD
			public EventArgs2(int int_1)
			{
				this.int_0 = int_1;
			}

			// Token: 0x04000227 RID: 551
			public int int_0;
		}

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060002C4 RID: 708
		internal delegate void Delegate6(object sender, Control0.EventArgs2 e);
	}
}
