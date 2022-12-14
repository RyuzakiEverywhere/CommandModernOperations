using System;

namespace ns1
{
	// Token: 0x02000078 RID: 120
	internal sealed class Class76 : Class75
	{
		// Token: 0x06000227 RID: 551 RVA: 0x0005B224 File Offset: 0x00059424
		public Class76(Class78 class78_1) : base(class78_1)
		{
			double num = Math.Sin(base.method_0().method_14());
			double num2 = Math.Cos(base.method_0().method_14());
			Class74 @class = base.method_0().method_2();
			this.double_82 = @class.method_3();
			double num3 = base.method_0().method_12();
			double num4 = 1.0 / base.method_0().method_7();
			this.double_56 = base.method_0().method_11();
			double num5 = base.method_0().method_16();
			double num6 = this.double_25 + this.double_26;
			double num7 = Math.Sin(base.method_0().method_13());
			double num8 = Math.Cos(base.method_0().method_13());
			this.double_73 = base.method_0().method_14();
			double num9 = @class.method_0();
			double num10 = 4.523602 - 0.00092422029 * num9;
			double num11 = Math.Sin(num10);
			double num12 = Math.Cos(num10);
			double num13 = 0.91375164 - 0.03568096 * num12;
			double num14 = Math.Sqrt(1.0 - num13 * num13);
			double num15 = 0.089683511 * num11 / num14;
			double num16 = Math.Sqrt(1.0 - num15 * num15);
			double num17 = 4.7199672 + 0.2299715 * num9;
			double num18 = 5.8351514 + 0.001944368 * num9;
			this.double_57 = Class73.smethod_1(num17 - num18);
			double double_ = 0.39785416 * num11 / num14;
			double double_2 = num16 * num12 + 0.91744867 * num15 * num11;
			double num19 = Class73.smethod_2(double_, double_2) + num18 - num10;
			double num20 = Math.Cos(num19);
			double num21 = Math.Sin(num19);
			this.double_58 = 6.2565837 + 0.017201977 * num9;
			this.double_58 = Class73.smethod_1(this.double_58);
			double num22 = 0.1945905;
			double num23 = -0.98088458;
			double num24 = 0.91744867;
			double num25 = 0.39785416;
			double num26 = num8;
			double num27 = num7;
			double num28 = 2.9864797E-06;
			double num29 = 1.19459E-05;
			double num30 = 0.01675;
			double num31 = 1.0 / base.method_0().method_8();
			double num32 = 0.0;
			double num33 = 0.0;
			double num34 = 0.0;
			double num35 = 0.0;
			double num36 = 0.0;
			double num37 = Class73.smethod_0(base.method_0().method_12());
			for (int i = 1; i <= 2; i++)
			{
				double num38 = num22 * num26 + num23 * num24 * num27;
				double num39 = -num23 * num26 + num22 * num24 * num27;
				double num40 = -num22 * num27 + num23 * num24 * num26;
				double num41 = num23 * num25;
				double num42 = num23 * num27 + num22 * num24 * num26;
				double num43 = num22 * num25;
				double num44 = this.double_2 * num40 + this.double_22 * num41;
				double num45 = this.double_2 * num42 + this.double_22 * num43;
				double num46 = -this.double_22 * num40 + this.double_2 * num41;
				double num47 = -this.double_22 * num42 + this.double_2 * num43;
				double num48 = num38 * num2 + num44 * num;
				double num49 = num39 * num2 + num45 * num;
				double num50 = -num38 * num + num44 * num2;
				double num51 = -num39 * num + num45 * num2;
				double num52 = num46 * num;
				double num53 = num47 * num;
				double num54 = num46 * num2;
				double num55 = num47 * num2;
				double num56 = 12.0 * num48 * num48 - 3.0 * num50 * num50;
				double num57 = 24.0 * num48 * num49 - 6.0 * num50 * num51;
				double num58 = 12.0 * num49 * num49 - 3.0 * num51 * num51;
				double num59 = 3.0 * (num38 * num38 + num44 * num44) + num56 * num37;
				double num60 = 6.0 * (num38 * num39 + num44 * num45) + num57 * num37;
				double num61 = 3.0 * (num39 * num39 + num45 * num45) + num58 * num37;
				double num62 = -6.0 * num38 * num46 + num37 * (-24.0 * num48 * num54 - 6.0 * num50 * num52);
				double num63 = -6.0 * (num38 * num47 + num39 * num46) + num37 * (-24.0 * (num49 * num54 + num48 * num55) - 6.0 * (num50 * num53 + num51 * num52));
				double num64 = -6.0 * num39 * num47 + num37 * (-24.0 * num49 * num55 - 6.0 * num51 * num53);
				double num65 = 6.0 * num44 * num46 + num37 * (24.0 * num48 * num52 - 6.0 * num50 * num54);
				double num66 = 6.0 * (num45 * num46 + num44 * num47) + num37 * (24.0 * (num49 * num52 + num48 * num53) - 6.0 * (num51 * num54 + num50 * num55));
				double num67 = 6.0 * num45 * num47 + num37 * (24.0 * num49 * num53 - 6.0 * num51 * num55);
				num59 = num59 + num59 + this.double_6 * num56;
				num60 = num60 + num60 + this.double_6 * num57;
				num61 = num61 + num61 + this.double_6 * num58;
				double num68 = num28 * num31;
				double num69 = -0.5 * num68 / this.double_7;
				double num70 = num68 * this.double_7;
				double num71 = -15.0 * num3 * num70;
				double num72 = num48 * num50 + num49 * num51;
				double num73 = num49 * num50 + num48 * num51;
				double num74 = num49 * num51 - num48 * num50;
				num32 = num71 * num29 * num72;
				num33 = num69 * num29 * (num62 + num64);
				num34 = -num29 * num68 * (num59 + num61 - 14.0 - 6.0 * num37);
				num35 = num70 * num29 * (num56 + num58 - 6.0);
				if (base.method_0().method_11() < 0.052359877)
				{
					num36 = 0.0;
				}
				else
				{
					num36 = -num29 * num69 * (num65 + num67);
				}
				this.double_33 = 2.0 * num71 * num73;
				this.double_32 = 2.0 * num71 * num74;
				this.double_51 = 2.0 * num69 * num63;
				this.double_52 = 2.0 * num69 * (num64 - num62);
				this.double_53 = -2.0 * num68 * num60;
				this.double_54 = -2.0 * num68 * (num61 - num59);
				this.double_55 = -2.0 * num68 * (-21.0 - 9.0 * num37) * num30;
				this.double_46 = 2.0 * num70 * num57;
				this.double_47 = 2.0 * num70 * (num58 - num56);
				this.double_48 = -18.0 * num70 * num30;
				this.double_49 = -2.0 * num69 * num66;
				this.double_50 = -2.0 * num69 * (num67 - num65);
				if (i == 1)
				{
					this.double_74 = num32;
					this.double_77 = num33;
					this.double_78 = num34;
					this.double_76 = num36 / this.double_22;
					this.double_75 = num35 - this.double_2 * this.double_76;
					this.double_34 = this.double_33;
					this.double_41 = this.double_51;
					this.double_43 = this.double_53;
					this.double_36 = this.double_46;
					this.double_39 = this.double_49;
					this.double_35 = this.double_32;
					this.double_42 = this.double_52;
					this.double_44 = this.double_54;
					this.double_37 = this.double_47;
					this.double_40 = this.double_50;
					this.double_45 = this.double_55;
					this.double_38 = this.double_48;
					num22 = num20;
					num23 = num21;
					num24 = num13;
					num25 = num14;
					num26 = num16 * num8 + num15 * num7;
					num27 = num7 * num16 - num8 * num15;
					num29 = 0.00015835218;
					num28 = 4.7968065E-07;
					num30 = 0.0549;
				}
			}
			this.double_74 += num32;
			this.double_77 += num33;
			this.double_78 += num34;
			this.double_75 = this.double_75 + num35 - this.double_2 / this.double_22 * num36;
			this.double_76 += num36 / this.double_22;
			this.bool_0 = false;
			this.bool_1 = false;
			double num75 = 0.0;
			if (base.method_0().method_8() > 0.0034906585 && base.method_0().method_8() < 0.0052359877)
			{
				this.bool_0 = true;
				this.bool_1 = true;
				double num76 = 1.0 + num37 * (-2.5 + 0.8125 * num37);
				double num77 = 1.0 + 2.0 * num37;
				double num78 = 1.0 + num37 * (-6.0 + 6.60937 * num37);
				double num79 = 0.75 * (1.0 + this.double_2) * (1.0 + this.double_2);
				double num80 = 0.9375 * this.double_22 * this.double_22 * (1.0 + 3.0 * this.double_2) - 0.75 * (1.0 + this.double_2);
				double num81 = 1.0 + this.double_2;
				num81 = 1.875 * num81 * num81 * num81;
				this.double_70 = 3.0 * this.double_9 * this.double_9 * num4 * num4;
				this.double_71 = 2.0 * this.double_70 * num79 * num76 * 1.7891679E-06;
				this.double_72 = 3.0 * this.double_70 * num81 * num78 * 2.2123015E-07 * num4;
				this.double_70 = this.double_70 * num80 * num77 * 2.1460748E-06 * num4;
				this.double_84 = num5 + base.method_0().method_13() + base.method_0().method_14() - this.double_82;
				num75 = this.double_24 + num6 - 0.0043752691;
				num75 = num75 + this.double_78 + this.double_75 + this.double_76;
			}
			else if (base.method_0().method_8() >= 0.00826 && base.method_0().method_8() <= 0.00924 && num3 >= 0.5)
			{
				this.bool_0 = true;
				double num82 = num3 * num37;
				double num83 = -0.306 - (num3 - 0.64) * 0.44;
				double num77;
				double num84;
				double num85;
				double num86;
				double num87;
				double num88;
				if (num3 <= 0.65)
				{
					num84 = 3.616 - 13.247 * num3 + 16.29 * num37;
					num77 = -19.302 + 117.39 * num3 - 228.419 * num37 + 156.591 * num82;
					num85 = -18.9068 + 109.7927 * num3 - 214.6334 * num37 + 146.5816 * num82;
					num86 = -41.122 + 242.694 * num3 - 471.094 * num37 + 313.953 * num82;
					num87 = -146.407 + 841.88 * num3 - 1629.014 * num37 + 1083.435 * num82;
					num88 = -532.114 + 3017.977 * num3 - 5740.0 * num37 + 3708.276 * num82;
				}
				else
				{
					num84 = -72.099 + 331.819 * num3 - 508.738 * num37 + 266.724 * num82;
					num77 = -346.844 + 1582.851 * num3 - 2415.925 * num37 + 1246.113 * num82;
					num85 = -342.585 + 1554.908 * num3 - 2366.899 * num37 + 1215.972 * num82;
					num86 = -1052.797 + 4758.686 * num3 - 7193.992 * num37 + 3651.957 * num82;
					num87 = -3581.69 + 16178.11 * num3 - 24462.77 * num37 + 12422.52 * num82;
					if (num3 <= 0.715)
					{
						num88 = 1464.74 - 4664.75 * num3 + 3763.64 * num37;
					}
					else
					{
						num88 = -5149.66 + 29936.92 * num3 - 54087.36 * num37 + 31324.56 * num82;
					}
				}
				double num89;
				double num90;
				double num91;
				if (num3 < 0.7)
				{
					num89 = -919.2277 + 4988.61 * num3 - 9064.77 * num37 + 5542.21 * num82;
					num90 = -822.71072 + 4568.6173 * num3 - 8491.4146 * num37 + 5337.524 * num82;
					num91 = -853.666 + 4690.25 * num3 - 8624.77 * num37 + 5341.4 * num82;
				}
				else
				{
					num89 = -37995.78 + 161616.52 * num3 - 229838.2 * num37 + 109377.94 * num82;
					num90 = -51752.104 + 218913.95 * num3 - 309468.16 * num37 + 146349.42 * num82;
					num91 = -40023.88 + 170470.89 * num3 - 242699.48 * num37 + 115605.82 * num82;
				}
				double num92 = this.double_22 * this.double_22;
				double num93 = this.double_2 * this.double_2;
				double num79 = 0.75 * (1.0 + 2.0 * this.double_2 + num93);
				double num94 = 1.5 * num92;
				double num95 = 1.875 * this.double_22 * (1.0 - 2.0 * this.double_2 - 3.0 * num93);
				double num96 = -1.875 * this.double_22 * (1.0 + 2.0 * this.double_2 - 3.0 * num93);
				double num97 = 35.0 * num92 * num79;
				double num98 = 39.375 * num92 * num92;
				double num99 = 9.84375 * this.double_22 * (num92 * (1.0 - 2.0 * this.double_2 - 5.0 * num93) + 0.33333333 * (-2.0 + 4.0 * this.double_2 + 6.0 * num93));
				double num100 = this.double_22 * (4.92187512 * num92 * (-2.0 - 4.0 * this.double_2 + 10.0 * num93) + 6.56250012 * (1.0 + 2.0 * this.double_2 - 3.0 * num93));
				double num101 = 29.53125 * this.double_22 * (2.0 - 8.0 * this.double_2 + num93 * (-12.0 + 8.0 * this.double_2 + 10.0 * num93));
				double num102 = 29.53125 * this.double_22 * (-2.0 - 8.0 * this.double_2 + num93 * (12.0 + 8.0 * this.double_2 - 10.0 * num93));
				double num103 = this.double_9 * this.double_9;
				double num104 = num4 * num4;
				double num105 = 3.0 * num103 * num104;
				double num106 = num105 * 1.7891679E-06;
				this.double_60 = num106 * num79 * num83;
				this.double_61 = num106 * num94 * num84;
				num105 *= num4;
				num106 = num105 * 3.7393792E-07;
				this.double_62 = num106 * num95 * num77;
				this.double_63 = num106 * num96 * num85;
				num105 *= num4;
				num106 = 2.0 * num105 * 7.3636953E-09;
				this.double_64 = num106 * num97 * num86;
				this.double_65 = num106 * num98 * num87;
				num105 *= num4;
				num106 = num105 * 1.1428639E-07;
				this.double_66 = num106 * num99 * num88;
				this.double_67 = num106 * num100 * num91;
				num106 = 2.0 * num105 * 2.1765803E-09;
				this.double_68 = num106 * num101 * num90;
				this.double_69 = num106 * num102 * num89;
				this.double_84 = num5 + base.method_0().method_13() + base.method_0().method_13() - this.double_82 - this.double_82;
				num75 = this.double_24 + this.double_26 + this.double_26 - 0.0043752691 - 0.0043752691;
				num75 = num75 + this.double_78 + this.double_76 + this.double_76;
			}
			if (this.bool_0 || this.bool_1)
			{
				this.double_83 = num75 - this.double_9;
				this.double_85 = this.double_84;
				this.double_86 = this.double_9;
				this.double_81 = 720.0;
				this.double_80 = -720.0;
				this.double_79 = 259200.0;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0005C698 File Offset: 0x0005A898
		private bool method_4(ref double double_87, ref double double_88, ref double double_89)
		{
			if (this.bool_1)
			{
				double_87 = this.double_70 * Math.Sin(this.double_85 - 0.13130908) + this.double_71 * Math.Sin(2.0 * (this.double_85 - 2.8843198)) + this.double_72 * Math.Sin(3.0 * (this.double_85 - 0.37448087));
				double_88 = this.double_70 * Math.Cos(this.double_85 - 0.13130908) + 2.0 * this.double_71 * Math.Cos(2.0 * (this.double_85 - 2.8843198)) + 3.0 * this.double_72 * Math.Cos(3.0 * (this.double_85 - 0.37448087));
			}
			else
			{
				double num = this.double_73 + this.double_25 * this.double_59;
				double num2 = num + num;
				double num3 = this.double_85 + this.double_85;
				double_87 = this.double_60 * Math.Sin(num2 + this.double_85 - 5.7686396) + this.double_61 * Math.Sin(this.double_85 - 5.7686396) + this.double_62 * Math.Sin(num + this.double_85 - 0.95240898) + this.double_63 * Math.Sin(-num + this.double_85 - 0.95240898) + this.double_64 * Math.Sin(num2 + num3 - 1.8014998) + this.double_65 * Math.Sin(num3 - 1.8014998) + this.double_66 * Math.Sin(num + this.double_85 - 1.050833) + this.double_67 * Math.Sin(-num + this.double_85 - 1.050833) + this.double_68 * Math.Sin(num + num3 - 4.4108898) + this.double_69 * Math.Sin(-num + num3 - 4.4108898);
				double_88 = this.double_60 * Math.Cos(num2 + this.double_85 - 5.7686396) + this.double_61 * Math.Cos(this.double_85 - 5.7686396) + this.double_62 * Math.Cos(num + this.double_85 - 0.95240898) + this.double_63 * Math.Cos(-num + this.double_85 - 0.95240898) + this.double_66 * Math.Cos(num + this.double_85 - 1.050833) + this.double_67 * Math.Cos(-num + this.double_85 - 1.050833) + 2.0 * (this.double_64 * Math.Cos(num2 + num3 - 1.8014998) + this.double_65 * Math.Cos(num3 - 1.8014998) + this.double_68 * Math.Cos(num + num3 - 4.4108898) + this.double_69 * Math.Cos(-num + num3 - 4.4108898));
			}
			double_89 = this.double_86 + this.double_83;
			double_88 *= double_89;
			return true;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0005CA30 File Offset: 0x0005AC30
		private void method_5(ref double double_87, ref double double_88, ref double double_89, double double_90)
		{
			this.method_4(ref double_87, ref double_88, ref double_89);
			this.double_85 = this.double_85 + double_89 * double_90 + double_87 * this.double_79;
			this.double_86 = this.double_86 + double_87 * double_90 + double_88 * this.double_79;
			this.double_59 += double_90;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0005CA90 File Offset: 0x0005AC90
		private bool method_6(ref double double_87, ref double double_88, ref double double_89, ref double double_90, ref double double_91, ref double double_92, ref double double_93)
		{
			double_87 += this.double_78 * double_93;
			double_88 += this.double_75 * double_93;
			double_89 += this.double_76 * double_93;
			double_90 = base.method_0().method_12() + this.double_74 * double_93;
			double_91 = base.method_0().method_11() + this.double_77 * double_93;
			if (double_91 < 0.0)
			{
				double_91 = -double_91;
				double_89 += 3.141592653589793;
				double_88 -= 3.141592653589793;
			}
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double double_94 = 0.0;
			bool flag = false;
			if (this.bool_0)
			{
				while (!flag)
				{
					if (this.double_59 != 0.0 && (double_93 < 0.0 || this.double_59 >= 0.0) && (double_93 >= 0.0 || this.double_59 < 0.0))
					{
						if (Math.Abs(double_93) < Math.Abs(this.double_59))
						{
							double_94 = this.double_81;
							if (double_93 >= 0.0)
							{
								double_94 = this.double_80;
							}
							this.method_5(ref num2, ref num, ref num3, double_94);
						}
						else
						{
							double_94 = this.double_80;
							if (double_93 > 0.0)
							{
								double_94 = this.double_81;
							}
							flag = true;
						}
					}
					else
					{
						double_94 = ((double_93 < 0.0) ? this.double_80 : this.double_81);
						this.double_59 = 0.0;
						this.double_86 = this.double_9;
						this.double_85 = this.double_84;
						flag = true;
					}
				}
				while (Math.Abs(double_93 - this.double_59) >= this.double_81)
				{
					this.method_5(ref num2, ref num, ref num3, double_94);
				}
				double num4 = double_93 - this.double_59;
				this.method_4(ref num2, ref num, ref num3);
				double_92 = this.double_86 + num2 * num4 + num * num4 * num4 * 0.5;
				double num5 = this.double_85 + num3 * num4 + num2 * num4 * num4 * 0.5;
				double num6 = -double_89 + this.double_82 + double_93 * 0.0043752691;
				double_87 = num5 - double_88 + num6;
				if (!this.bool_1)
				{
					double_87 = num5 + num6 + num6;
				}
			}
			return true;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0005CD2C File Offset: 0x0005AF2C
		private bool method_7(ref double double_87, ref double double_88, ref double double_89, ref double double_90, ref double double_91, double double_92)
		{
			double num = Math.Sin(double_88);
			double num2 = Math.Cos(double_88);
			double num3 = this.double_58 + 1.19459E-05 * double_92;
			double num4 = num3 + 0.0335 * Math.Sin(num3);
			double num5 = Math.Sin(num4);
			double num6 = 0.5 * num5 * num5 - 0.25;
			double num7 = -0.5 * num5 * Math.Cos(num4);
			double num8 = this.double_34 * num6 + this.double_35 * num7;
			double num9 = this.double_41 * num6 + this.double_42 * num7;
			double num10 = this.double_43 * num6 + this.double_44 * num7 + this.double_45 * num5;
			double num11 = this.double_36 * num6 + this.double_37 * num7 + this.double_38 * num5;
			double num12 = this.double_39 * num6 + this.double_40 * num7;
			num3 = this.double_57 + 0.00015835218 * double_92;
			num4 = num3 + 0.1098 * Math.Sin(num3);
			num5 = Math.Sin(num4);
			num6 = 0.5 * num5 * num5 - 0.25;
			num7 = -0.5 * num5 * Math.Cos(num4);
			double num13 = this.double_33 * num6 + this.double_32 * num7;
			double num14 = this.double_51 * num6 + this.double_52 * num7;
			double num15 = this.double_53 * num6 + this.double_54 * num7 + this.double_55 * num5;
			double num16 = this.double_46 * num6 + this.double_47 * num7 + this.double_48 * num5;
			double num17 = this.double_49 * num6 + this.double_50 * num7;
			double num18 = num8 + num13;
			double num19 = num9 + num14;
			double num20 = num10 + num15;
			double num21 = num11 + num16;
			double num22 = num12 + num17;
			double_88 += num19;
			double_87 += num18;
			if (this.double_56 >= 0.2)
			{
				num22 /= this.double_22;
				num21 -= this.double_2 * num22;
				double_89 += num21;
				double_90 += num22;
				double_91 += num20;
			}
			else
			{
				double num23 = Math.Sin(double_90);
				double num24 = Math.Cos(double_90);
				double num25 = num * num23;
				double num26 = num * num24;
				double num27 = num22 * num24 + num19 * num2 * num23;
				double num28 = -num22 * num23 + num19 * num2 * num24;
				num25 += num27;
				num26 += num28;
				double num29 = double_91 + double_89 + num2 * double_90;
				double num30 = num20 + num21 - num19 * double_90 * num;
				num29 += num30;
				double_90 = Class73.smethod_2(num25, num26);
				double_91 += num20;
				double_89 = num29 - double_91 - Math.Cos(double_88) * double_90;
			}
			return true;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0005D05C File Offset: 0x0005B25C
		public override Class72 vmethod_0(double double_87)
		{
			double num = base.method_0().method_16() + this.double_24 * double_87;
			double num2 = base.method_0().method_14() + this.double_25 * double_87;
			double num3 = base.method_0().method_13() + this.double_26 * double_87;
			double num4 = double_87 * double_87;
			double num5 = num3 + this.double_27 * num4;
			double double_88 = 1.0 - this.double_19 * double_87;
			double num6 = base.method_0().method_15() * this.double_21 * double_87;
			double num7 = this.double_28 * num4;
			double num8 = this.double_9;
			double num9 = 0.0;
			double num10 = 0.0;
			this.method_6(ref num, ref num2, ref num5, ref num9, ref num10, ref num8, ref double_87);
			double x = Math.Pow(Class73.double_0 / num8, 0.6666666666666666) * Class73.smethod_0(double_88);
			double num11 = num9 - num6;
			double num12 = num + this.double_9 * num7;
			this.method_7(ref num11, ref num10, ref num2, ref num5, ref num12, double_87);
			double num13 = num12 + num2 + num5;
			num8 = Class73.double_0 / Math.Pow(x, 1.5);
			return base.method_3(num10, num2, num11, x, num13, num5, num8, double_87);
		}

		// Token: 0x04000179 RID: 377
		private double double_32;

		// Token: 0x0400017A RID: 378
		private double double_33;

		// Token: 0x0400017B RID: 379
		private double double_34;

		// Token: 0x0400017C RID: 380
		private double double_35;

		// Token: 0x0400017D RID: 381
		private double double_36;

		// Token: 0x0400017E RID: 382
		private double double_37;

		// Token: 0x0400017F RID: 383
		private double double_38;

		// Token: 0x04000180 RID: 384
		private double double_39;

		// Token: 0x04000181 RID: 385
		private double double_40;

		// Token: 0x04000182 RID: 386
		private double double_41;

		// Token: 0x04000183 RID: 387
		private double double_42;

		// Token: 0x04000184 RID: 388
		private double double_43;

		// Token: 0x04000185 RID: 389
		private double double_44;

		// Token: 0x04000186 RID: 390
		private double double_45;

		// Token: 0x04000187 RID: 391
		private double double_46;

		// Token: 0x04000188 RID: 392
		private double double_47;

		// Token: 0x04000189 RID: 393
		private double double_48;

		// Token: 0x0400018A RID: 394
		private double double_49;

		// Token: 0x0400018B RID: 395
		private double double_50;

		// Token: 0x0400018C RID: 396
		private double double_51;

		// Token: 0x0400018D RID: 397
		private double double_52;

		// Token: 0x0400018E RID: 398
		private double double_53;

		// Token: 0x0400018F RID: 399
		private double double_54;

		// Token: 0x04000190 RID: 400
		private double double_55;

		// Token: 0x04000191 RID: 401
		private double double_56;

		// Token: 0x04000192 RID: 402
		private double double_57;

		// Token: 0x04000193 RID: 403
		private double double_58;

		// Token: 0x04000194 RID: 404
		private double double_59;

		// Token: 0x04000195 RID: 405
		private double double_60;

		// Token: 0x04000196 RID: 406
		private double double_61;

		// Token: 0x04000197 RID: 407
		private double double_62;

		// Token: 0x04000198 RID: 408
		private double double_63;

		// Token: 0x04000199 RID: 409
		private double double_64;

		// Token: 0x0400019A RID: 410
		private double double_65;

		// Token: 0x0400019B RID: 411
		private double double_66;

		// Token: 0x0400019C RID: 412
		private double double_67;

		// Token: 0x0400019D RID: 413
		private double double_68;

		// Token: 0x0400019E RID: 414
		private double double_69;

		// Token: 0x0400019F RID: 415
		private double double_70;

		// Token: 0x040001A0 RID: 416
		private double double_71;

		// Token: 0x040001A1 RID: 417
		private double double_72;

		// Token: 0x040001A2 RID: 418
		private double double_73;

		// Token: 0x040001A3 RID: 419
		private double double_74;

		// Token: 0x040001A4 RID: 420
		private double double_75;

		// Token: 0x040001A5 RID: 421
		private double double_76;

		// Token: 0x040001A6 RID: 422
		private double double_77;

		// Token: 0x040001A7 RID: 423
		private double double_78;

		// Token: 0x040001A8 RID: 424
		private double double_79;

		// Token: 0x040001A9 RID: 425
		private double double_80;

		// Token: 0x040001AA RID: 426
		private double double_81;

		// Token: 0x040001AB RID: 427
		private double double_82;

		// Token: 0x040001AC RID: 428
		private double double_83;

		// Token: 0x040001AD RID: 429
		private double double_84;

		// Token: 0x040001AE RID: 430
		private double double_85;

		// Token: 0x040001AF RID: 431
		private double double_86;

		// Token: 0x040001B0 RID: 432
		private bool bool_0;

		// Token: 0x040001B1 RID: 433
		private bool bool_1;
	}
}
