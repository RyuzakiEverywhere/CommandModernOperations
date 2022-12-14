using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns2;
using ns3;
using ns4;

namespace ns5
{
	// Token: 0x02000D9C RID: 3484
	[DesignerGenerated]
	internal sealed partial class LOSTool : DarkSecondaryFormBase
	{
		// Token: 0x06005D88 RID: 23944 RVA: 0x0032FDD4 File Offset: 0x0032DFD4
		public LOSTool()
		{
			base.Shown += this.LOSTool_Shown;
			base.Closing += new CancelEventHandler(this.LOSTool_Closing);
			base.Load += this.LOSTool_Load;
			this.bool_3 = false;
			this.InitializeComponent_1();
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x0032FE6C File Offset: 0x0032E06C
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			this.vmethod_1(new Class116());
			this.vmethod_3(new Control12());
			this.vmethod_5(new TabPage());
			this.vmethod_31(new Class116());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Class116());
			this.vmethod_11(new Control8());
			this.vmethod_13(new Control8());
			this.vmethod_23(new Class112());
			this.vmethod_15(new Control9());
			this.vmethod_17(new Timer(this.icontainer_1));
			this.vmethod_19(new Class116());
			this.vmethod_21(new Class2451());
			this.vmethod_25(new Class116());
			this.vmethod_27(new Control9());
			this.vmethod_29(new ColorDialog());
			this.vmethod_2().SuspendLayout();
			this.vmethod_4().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().method_2(true);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(4, 11);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(103, 15);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Observation from:";
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().Controls.Add(this.vmethod_4());
			this.vmethod_2().Cursor = Cursors.Hand;
			this.vmethod_2().ItemSize = new Size(80, 20);
			this.vmethod_2().Location = new Point(3, 27);
			this.vmethod_2().Name = "TabControl1";
			this.vmethod_2().SelectedIndex = 0;
			this.vmethod_2().Size = new Size(405, 52);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().Controls.Add(this.vmethod_30());
			this.vmethod_4().Location = new Point(4, 24);
			this.vmethod_4().Name = "TabPage1";
			this.vmethod_4().Padding = new Padding(3);
			this.vmethod_4().Size = new Size(397, 24);
			this.vmethod_4().TabIndex = 0;
			this.vmethod_4().Text = "Selected Unit";
			this.vmethod_30().method_2(true);
			this.vmethod_30().Location = new Point(6, 3);
			this.vmethod_30().Name = "Label_SelectedUnitName";
			this.vmethod_30().Size = new Size(76, 15);
			this.vmethod_30().TabIndex = 0;
			this.vmethod_30().Text = "Selected Unit";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().method_2(true);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(7, 89);
			this.vmethod_6().Name = "Label3";
			this.vmethod_6().Size = new Size(112, 15);
			this.vmethod_6().TabIndex = 2;
			this.vmethod_6().Text = "Max Distance (NM):";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_8().method_2(true);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(7, 111);
			this.vmethod_8().Name = "Label4";
			this.vmethod_8().Size = new Size(107, 15);
			this.vmethod_8().TabIndex = 3;
			this.vmethod_8().Text = "Target Alt (m AGL):";
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_10().method_14(null);
			this.vmethod_10().method_15(AutoCompleteMode.None);
			this.vmethod_10().method_13(AutoCompleteSource.None);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_10().method_12(null);
			this.vmethod_10().method_18(null);
			this.vmethod_10().Location = new Point(114, 88);
			this.vmethod_10().method_2(32767);
			this.vmethod_10().method_7(false);
			this.vmethod_10().Name = "TB_MaxRange";
			this.vmethod_10().method_3(false);
			this.vmethod_10().method_19(ScrollBars.None);
			this.vmethod_10().method_9(0);
			this.vmethod_10().Size = new Size(100, 20);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_10().Text = "100";
			this.vmethod_10().method_1(HorizontalAlignment.Left);
			this.vmethod_10().method_5(false);
			this.vmethod_10().method_10("");
			this.vmethod_12().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_12().method_14(null);
			this.vmethod_12().method_15(AutoCompleteMode.None);
			this.vmethod_12().method_13(AutoCompleteSource.None);
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_12().method_12(null);
			this.vmethod_12().method_18(null);
			this.vmethod_12().Location = new Point(114, 111);
			this.vmethod_12().method_2(32767);
			this.vmethod_12().method_7(false);
			this.vmethod_12().Name = "TB_TargetAlt";
			this.vmethod_12().method_3(false);
			this.vmethod_12().method_19(ScrollBars.None);
			this.vmethod_12().method_9(0);
			this.vmethod_12().Size = new Size(100, 20);
			this.vmethod_12().TabIndex = 5;
			this.vmethod_12().Text = "10";
			this.vmethod_12().method_1(HorizontalAlignment.Left);
			this.vmethod_12().method_5(false);
			this.vmethod_12().method_10("");
			this.vmethod_22().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_22().AutoSize = true;
			this.vmethod_22().Location = new Point(220, 112);
			this.vmethod_22().Name = "CB_AltitudeSameAsObserver";
			this.vmethod_22().Size = new Size(117, 19);
			this.vmethod_22().TabIndex = 6;
			this.vmethod_22().Text = "Same as observer";
			this.vmethod_14().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().DialogResult = DialogResult.None;
			this.vmethod_14().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_14().ForeColor = SystemColors.Control;
			this.vmethod_14().Location = new Point(329, 143);
			this.vmethod_14().Name = "Button1";
			this.vmethod_14().method_1(0);
			this.vmethod_14().Size = new Size(75, 23);
			this.vmethod_14().TabIndex = 7;
			this.vmethod_14().Text = "REFRESH";
			this.vmethod_16().Interval = 50;
			this.vmethod_18().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_18().method_2(true);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(225, 90);
			this.vmethod_18().Name = "Label2";
			this.vmethod_18().Size = new Size(52, 15);
			this.vmethod_18().TabIndex = 8;
			this.vmethod_18().Text = "Horizon:";
			this.vmethod_20().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_20().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_20().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_20().FormattingEnabled = true;
			this.vmethod_20().Items.AddRange(new object[]
			{
				"Radar/ESM",
				"Visual/EO/Laser"
			});
			this.vmethod_20().Location = new Point(281, 89);
			this.vmethod_20().Name = "CB_HorizonType";
			this.vmethod_20().Size = new Size(127, 21);
			this.vmethod_20().TabIndex = 9;
			this.vmethod_24().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_24().method_2(true);
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().Location = new Point(4, 148);
			this.vmethod_24().Name = "Label5";
			this.vmethod_24().Size = new Size(74, 15);
			this.vmethod_24().TabIndex = 10;
			this.vmethod_24().Text = "Shade Color:";
			this.vmethod_26().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_26().BackColor = Color.Transparent;
			this.vmethod_26().DialogResult = DialogResult.None;
			this.vmethod_26().ForeColor = SystemColors.Control;
			this.vmethod_26().Location = new Point(124, 143);
			this.vmethod_26().Name = "Button_ShadeColor";
			this.vmethod_26().method_1(0);
			this.vmethod_26().Size = new Size(75, 23);
			this.vmethod_26().TabIndex = 11;
			this.vmethod_26().Text = "CHANGE";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(411, 170);
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.Name = "LOSTool";
			base.ShowIcon = false;
			this.Text = "Line-of-sight Tool";
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_4().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x0003C348 File Offset: 0x0003A548
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x0003C350 File Offset: 0x0003A550
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_6)
		{
			this.class116_0 = class116_6;
		}

		// Token: 0x06005D8D RID: 23949 RVA: 0x0003C359 File Offset: 0x0003A559
		[CompilerGenerated]
		internal Control12 vmethod_2()
		{
			return this.control12_0;
		}

		// Token: 0x06005D8E RID: 23950 RVA: 0x0003C361 File Offset: 0x0003A561
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control12 control12_1)
		{
			this.control12_0 = control12_1;
		}

		// Token: 0x06005D8F RID: 23951 RVA: 0x0003C36A File Offset: 0x0003A56A
		[CompilerGenerated]
		internal TabPage vmethod_4()
		{
			return this.tabPage_0;
		}

		// Token: 0x06005D90 RID: 23952 RVA: 0x0003C372 File Offset: 0x0003A572
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabPage tabPage_1)
		{
			this.tabPage_0 = tabPage_1;
		}

		// Token: 0x06005D91 RID: 23953 RVA: 0x0003C37B File Offset: 0x0003A57B
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_1;
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x0003C383 File Offset: 0x0003A583
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_6)
		{
			this.class116_1 = class116_6;
		}

		// Token: 0x06005D93 RID: 23955 RVA: 0x0003C38C File Offset: 0x0003A58C
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_2;
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x0003C394 File Offset: 0x0003A594
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_6)
		{
			this.class116_2 = class116_6;
		}

		// Token: 0x06005D95 RID: 23957 RVA: 0x0003C39D File Offset: 0x0003A59D
		[CompilerGenerated]
		internal Control8 vmethod_10()
		{
			return this.control8_0;
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x003309D8 File Offset: 0x0032EBD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control8 control8_2)
		{
			EventHandler value = new EventHandler(this.method_7);
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_13);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.Leave -= value;
				control.method_22(delegate85_);
			}
			this.control8_0 = control8_2;
			control = this.control8_0;
			if (control != null)
			{
				control.Leave += value;
				control.method_21(delegate85_);
			}
		}

		// Token: 0x06005D97 RID: 23959 RVA: 0x0003C3A5 File Offset: 0x0003A5A5
		[CompilerGenerated]
		internal Control8 vmethod_12()
		{
			return this.control8_1;
		}

		// Token: 0x06005D98 RID: 23960 RVA: 0x00330A38 File Offset: 0x0032EC38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control8 control8_2)
		{
			EventHandler value = new EventHandler(this.method_8);
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_12);
			Control8 control = this.control8_1;
			if (control != null)
			{
				control.Leave -= value;
				control.method_22(delegate85_);
			}
			this.control8_1 = control8_2;
			control = this.control8_1;
			if (control != null)
			{
				control.Leave += value;
				control.method_21(delegate85_);
			}
		}

		// Token: 0x06005D99 RID: 23961 RVA: 0x0003C3AD File Offset: 0x0003A5AD
		[CompilerGenerated]
		internal Control9 vmethod_14()
		{
			return this.control9_0;
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x00330A98 File Offset: 0x0032EC98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_2;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06005D9B RID: 23963 RVA: 0x0003C3B5 File Offset: 0x0003A5B5
		[CompilerGenerated]
		internal Timer vmethod_16()
		{
			return this.timer_0;
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x00330ADC File Offset: 0x0032ECDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_5);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_1;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x0003C3BD File Offset: 0x0003A5BD
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_3;
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x0003C3C5 File Offset: 0x0003A5C5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_6)
		{
			this.class116_3 = class116_6;
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x0003C3CE File Offset: 0x0003A5CE
		[CompilerGenerated]
		internal Class2451 vmethod_20()
		{
			return this.class2451_0;
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x00330B20 File Offset: 0x0032ED20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_9);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_1;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x0003C3D6 File Offset: 0x0003A5D6
		[CompilerGenerated]
		internal Class112 vmethod_22()
		{
			return this.class112_0;
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x0003C3DE File Offset: 0x0003A5DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class112 class112_1)
		{
			this.class112_0 = class112_1;
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x0003C3E7 File Offset: 0x0003A5E7
		[CompilerGenerated]
		internal Class116 vmethod_24()
		{
			return this.class116_4;
		}

		// Token: 0x06005DA4 RID: 23972 RVA: 0x0003C3EF File Offset: 0x0003A5EF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class116 class116_6)
		{
			this.class116_4 = class116_6;
		}

		// Token: 0x06005DA5 RID: 23973 RVA: 0x0003C3F8 File Offset: 0x0003A5F8
		[CompilerGenerated]
		internal Control9 vmethod_26()
		{
			return this.control9_1;
		}

		// Token: 0x06005DA6 RID: 23974 RVA: 0x00330B64 File Offset: 0x0032ED64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_10);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_2;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06005DA7 RID: 23975 RVA: 0x0003C400 File Offset: 0x0003A600
		[CompilerGenerated]
		internal ColorDialog vmethod_28()
		{
			return this.colorDialog_0;
		}

		// Token: 0x06005DA8 RID: 23976 RVA: 0x0003C408 File Offset: 0x0003A608
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(ColorDialog colorDialog_1)
		{
			this.colorDialog_0 = colorDialog_1;
		}

		// Token: 0x06005DA9 RID: 23977 RVA: 0x0003C411 File Offset: 0x0003A611
		[CompilerGenerated]
		internal Class116 vmethod_30()
		{
			return this.class116_5;
		}

		// Token: 0x06005DAA RID: 23978 RVA: 0x0003C419 File Offset: 0x0003A619
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class116 class116_6)
		{
			this.class116_5 = class116_6;
		}

		// Token: 0x06005DAB RID: 23979 RVA: 0x0003C422 File Offset: 0x0003A622
		private void method_3(object sender, EventArgs e)
		{
			this.method_6();
		}

		// Token: 0x06005DAC RID: 23980 RVA: 0x00330BA8 File Offset: 0x0032EDA8
		private void method_4()
		{
			if (!Information.IsNothing(Client.smethod_54()))
			{
				try
				{
					this.bool_3 = true;
					LOSTool.Enum198 @enum = this.enum198_0;
					float float_;
					float num;
					if (@enum != LOSTool.Enum198.const_0)
					{
						if (@enum == LOSTool.Enum198.const_1)
						{
							float_ = Client.smethod_54().vmethod_14(false) + (float)Client.smethod_54().vmethod_12();
							num = Class562.smethod_4(float_, (float)this.int_0);
						}
					}
					else
					{
						float_ = Client.smethod_54().vmethod_14(false) + (float)Client.smethod_54().vmethod_11();
						num = Class562.smethod_2(float_, (float)this.int_0);
					}
					if (this.float_1 > num)
					{
						this.float_1 = num;
					}
					this.concurrentBag_0 = Terrain.smethod_4(Client.smethod_54().vmethod_30(null), Client.smethod_54().vmethod_28(null), float_, (float)this.int_0, this.float_1);
					List<Geopoint_Struct[]> list = new List<Geopoint_Struct[]>(this.concurrentBag_0.Count);
					try
					{
						foreach (Terrain.Struct55 @struct in this.concurrentBag_0)
						{
							list.Add(new Geopoint_Struct[]
							{
								@struct.method_0(),
								@struct.method_1(),
								@struct.method_3(),
								@struct.method_2()
							});
						}
					}
					finally
					{
						IEnumerator<Terrain.Struct55> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					int count;
					do
					{
						count = list.Count;
						list = Math2.smethod_32(list);
					}
					while (list.Count != count);
					Client.list_2 = list;
				}
				catch (Exception ex)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				finally
				{
					this.bool_3 = false;
				}
				Client.bool_1 = true;
			}
		}

		// Token: 0x06005DAD RID: 23981 RVA: 0x0003C42A File Offset: 0x0003A62A
		private void LOSTool_Shown(object sender, EventArgs e)
		{
			this.vmethod_26().BackColor = Client.color_5;
			this.vmethod_16().Start();
			this.vmethod_20().SelectedIndex = 0;
		}

		// Token: 0x06005DAE RID: 23982 RVA: 0x00330DA0 File Offset: 0x0032EFA0
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_22().Checked)
			{
				this.vmethod_12().Enabled = false;
				this.vmethod_12().Text = string.Format("{0:0.0}", Client.smethod_54().vmethod_14(false), 1);
			}
			else
			{
				this.vmethod_12().Enabled = true;
			}
			if (!this.bool_3 && !Information.IsNothing(Client.smethod_54()))
			{
				bool flag = false;
				if (this.double_0 != Client.smethod_54().vmethod_30(null))
				{
					flag = true;
				}
				if (this.double_1 != Client.smethod_54().vmethod_28(null))
				{
					flag = true;
				}
				if ((int)Math.Round((double)this.float_0) != (int)Math.Round((double)Client.smethod_54().vmethod_14(false)))
				{
					flag = true;
				}
				if (Versioned.IsNumeric(this.vmethod_10().Text) && Versioned.IsNumeric(this.vmethod_12().Text) && flag)
				{
					this.method_6();
				}
			}
		}

		// Token: 0x06005DAF RID: 23983 RVA: 0x00330EA8 File Offset: 0x0032F0A8
		private void method_6()
		{
			this.double_0 = Client.smethod_54().vmethod_30(null);
			this.double_1 = Client.smethod_54().vmethod_28(null);
			this.float_0 = Client.smethod_54().vmethod_14(false);
			Task.Factory.StartNew(new Action(this.method_14));
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x0003C453 File Offset: 0x0003A653
		private void method_7(object sender, EventArgs e)
		{
			if (!Versioned.IsNumeric(this.vmethod_10().Text))
			{
				DarkMessageBox.smethod_1("The max range value must be a valid number", "Invalid value", Enum11.const_0);
			}
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x0003C478 File Offset: 0x0003A678
		private void method_8(object sender, EventArgs e)
		{
			if (!Versioned.IsNumeric(this.vmethod_12().Text))
			{
				DarkMessageBox.smethod_1("The target altitude value must be a valid number", "Invalid value", Enum11.const_0);
			}
		}

		// Token: 0x06005DB2 RID: 23986 RVA: 0x0003C49D File Offset: 0x0003A69D
		private void method_9(object sender, EventArgs e)
		{
			this.enum198_0 = (LOSTool.Enum198)this.vmethod_20().SelectedIndex;
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x0003C4B1 File Offset: 0x0003A6B1
		private void LOSTool_Closing(object sender, CancelEventArgs e)
		{
			Client.smethod_15(new Client.Delegate78(this.method_11));
			Client.list_2 = null;
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x00330F10 File Offset: 0x0032F110
		private void method_10(object sender, EventArgs e)
		{
			this.vmethod_28().Color = Client.color_5;
			this.vmethod_28().ShowDialog();
			Client.color_5 = this.vmethod_28().Color;
			this.vmethod_26().BackColor = Client.color_5;
			Client.bool_1 = true;
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x0003C4CA File Offset: 0x0003A6CA
		private void LOSTool_Load(object sender, EventArgs e)
		{
			if (!Information.IsNothing(Client.smethod_54()))
			{
				this.vmethod_30().Text = Client.smethod_54().Name;
			}
			Client.smethod_14(new Client.Delegate78(this.method_11));
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x0003C4FE File Offset: 0x0003A6FE
		private void method_11(Unit unit_0)
		{
			if (Information.IsNothing(Client.smethod_54()))
			{
				this.vmethod_30().Text = string.Empty;
				return;
			}
			this.vmethod_30().Text = Client.smethod_54().Name;
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x0003C532 File Offset: 0x0003A732
		private void method_12(object object_0)
		{
			if (Versioned.IsNumeric(this.vmethod_12().Text))
			{
				this.int_0 = Conversions.ToInteger(this.vmethod_12().Text);
			}
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x0003C55C File Offset: 0x0003A75C
		private void method_13(object object_0)
		{
			if (Versioned.IsNumeric(this.vmethod_10().Text))
			{
				this.float_1 = Conversions.ToSingle(this.vmethod_10().Text);
			}
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x0003C586 File Offset: 0x0003A786
		[CompilerGenerated]
		private void method_14()
		{
			this.method_4();
		}

		// Token: 0x0400365D RID: 13917
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x0400365E RID: 13918
		[CompilerGenerated]
		[AccessedThroughProperty("TabControl1")]
		private Control12 control12_0;

		// Token: 0x0400365F RID: 13919
		[AccessedThroughProperty("TabPage1")]
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04003660 RID: 13920
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_1;

		// Token: 0x04003661 RID: 13921
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_2;

		// Token: 0x04003662 RID: 13922
		[CompilerGenerated]
		[AccessedThroughProperty("TB_MaxRange")]
		private Control8 control8_0;

		// Token: 0x04003663 RID: 13923
		[CompilerGenerated]
		[AccessedThroughProperty("TB_TargetAlt")]
		private Control8 control8_1;

		// Token: 0x04003664 RID: 13924
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04003665 RID: 13925
		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private Timer timer_0;

		// Token: 0x04003666 RID: 13926
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_3;

		// Token: 0x04003667 RID: 13927
		[AccessedThroughProperty("CB_HorizonType")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04003668 RID: 13928
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AltitudeSameAsObserver")]
		private Class112 class112_0;

		// Token: 0x04003669 RID: 13929
		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Class116 class116_4;

		// Token: 0x0400366A RID: 13930
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ShadeColor")]
		private Control9 control9_1;

		// Token: 0x0400366B RID: 13931
		[CompilerGenerated]
		[AccessedThroughProperty("ColorDialog_Shade")]
		private ColorDialog colorDialog_0;

		// Token: 0x0400366C RID: 13932
		[CompilerGenerated]
		[AccessedThroughProperty("Label_SelectedUnitName")]
		private Class116 class116_5;

		// Token: 0x0400366D RID: 13933
		private double double_0;

		// Token: 0x0400366E RID: 13934
		private double double_1;

		// Token: 0x0400366F RID: 13935
		private float float_0;

		// Token: 0x04003670 RID: 13936
		private bool bool_3;

		// Token: 0x04003671 RID: 13937
		private ConcurrentBag<Terrain.Struct55> concurrentBag_0;

		// Token: 0x04003672 RID: 13938
		private LOSTool.Enum198 enum198_0;

		// Token: 0x04003673 RID: 13939
		private int int_0;

		// Token: 0x04003674 RID: 13940
		private float float_1;

		// Token: 0x02000D9D RID: 3485
		private enum Enum198 : short
		{
			// Token: 0x04003676 RID: 13942
			const_0,
			// Token: 0x04003677 RID: 13943
			const_1
		}
	}
}
