using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns4
{
	// Token: 0x02000E5F RID: 3679
	[DesignerGenerated]
	internal sealed class PlatformComponentArcControl : Control7
	{
		// Token: 0x06006FC7 RID: 28615 RVA: 0x00046641 File Offset: 0x00044841
		public PlatformComponentArcControl()
		{
			base.DoubleClick += this.PlatformComponentArcControl_DoubleClick;
			base.Load += this.PlatformComponentArcControl_Load;
			this.class295_0 = new PlatformComponent.Class295();
			this.InitializeComponent();
		}

		// Token: 0x06006FC8 RID: 28616 RVA: 0x003C5674 File Offset: 0x003C3874
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_1 != null)
				{
					this.icontainer_1.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06006FC9 RID: 28617 RVA: 0x003C56B4 File Offset: 0x003C38B4
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PlatformComponentArcControl));
			this.vmethod_1(new Class112());
			this.vmethod_3(new Class112());
			this.vmethod_5(new Class112());
			this.vmethod_7(new Class112());
			this.vmethod_9(new Class112());
			this.vmethod_11(new Class112());
			this.vmethod_13(new Class112());
			this.vmethod_15(new Class112());
			this.vmethod_17(new Class112());
			this.vmethod_19(new Class112());
			this.vmethod_21(new Class112());
			this.vmethod_23(new Class112());
			this.vmethod_25(new Class112());
			this.vmethod_27(new Class112());
			this.vmethod_29(new Class112());
			this.vmethod_31(new Class112());
			this.vmethod_33(new PictureBox());
			((ISupportInitialize)this.vmethod_32()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Location = new Point(20, 8);
			this.vmethod_0().Name = "CB_PB1";
			this.vmethod_0().Size = new Size(15, 14);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_2().Location = new Point(34, 4);
			this.vmethod_2().Name = "CB_PB2";
			this.vmethod_2().Size = new Size(15, 14);
			this.vmethod_2().TabIndex = 2;
			this.vmethod_4().Location = new Point(48, 4);
			this.vmethod_4().Name = "CB_SB1";
			this.vmethod_4().Size = new Size(15, 14);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_6().Location = new Point(62, 7);
			this.vmethod_6().Name = "CB_SB2";
			this.vmethod_6().Size = new Size(15, 14);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_8().Location = new Point(5, 36);
			this.vmethod_8().Name = "CB_PMF1";
			this.vmethod_8().Size = new Size(15, 14);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_10().Location = new Point(9, 22);
			this.vmethod_10().Name = "CB_PMF2";
			this.vmethod_10().Size = new Size(15, 14);
			this.vmethod_10().TabIndex = 6;
			this.vmethod_12().Location = new Point(78, 35);
			this.vmethod_12().Name = "CB_SMF2";
			this.vmethod_12().Size = new Size(15, 14);
			this.vmethod_12().TabIndex = 7;
			this.vmethod_14().Location = new Point(72, 21);
			this.vmethod_14().Name = "CB_SMF1";
			this.vmethod_14().Size = new Size(15, 14);
			this.vmethod_14().TabIndex = 8;
			this.vmethod_16().Location = new Point(5, 51);
			this.vmethod_16().Name = "CB_PMA2";
			this.vmethod_16().Size = new Size(15, 14);
			this.vmethod_16().TabIndex = 9;
			this.vmethod_18().Location = new Point(9, 65);
			this.vmethod_18().Name = "CB_PMA1";
			this.vmethod_18().Size = new Size(15, 14);
			this.vmethod_18().TabIndex = 10;
			this.vmethod_20().Location = new Point(20, 79);
			this.vmethod_20().Name = "CB_PS2";
			this.vmethod_20().Size = new Size(15, 14);
			this.vmethod_20().TabIndex = 11;
			this.vmethod_22().Location = new Point(34, 82);
			this.vmethod_22().Name = "CB_PS1";
			this.vmethod_22().Size = new Size(15, 14);
			this.vmethod_22().TabIndex = 12;
			this.vmethod_24().Location = new Point(49, 82);
			this.vmethod_24().Name = "CB_SS2";
			this.vmethod_24().Size = new Size(15, 14);
			this.vmethod_24().TabIndex = 13;
			this.vmethod_26().Location = new Point(63, 77);
			this.vmethod_26().Name = "CB_SS1";
			this.vmethod_26().Size = new Size(15, 14);
			this.vmethod_26().TabIndex = 14;
			this.vmethod_28().Location = new Point(78, 49);
			this.vmethod_28().Name = "CB_SMA1";
			this.vmethod_28().Size = new Size(15, 14);
			this.vmethod_28().TabIndex = 15;
			this.vmethod_30().Location = new Point(72, 63);
			this.vmethod_30().Name = "CB_SMA2";
			this.vmethod_30().Size = new Size(15, 14);
			this.vmethod_30().TabIndex = 16;
			this.vmethod_32().Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.vmethod_32().Location = new Point(22, 20);
			this.vmethod_32().Name = "PictureBox1";
			this.vmethod_32().Size = new Size(50, 61);
			this.vmethod_32().TabIndex = 17;
			this.vmethod_32().TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_32());
			base.Name = "PlatformComponentArcControl";
			base.Size = new Size(100, 100);
			((ISupportInitialize)this.vmethod_32()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x0004667E File Offset: 0x0004487E
		[CompilerGenerated]
		internal Class112 vmethod_0()
		{
			return this.class112_0;
		}

		// Token: 0x06006FCB RID: 28619 RVA: 0x003C5DB4 File Offset: 0x003C3FB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_11);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_0 = class112_16;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FCC RID: 28620 RVA: 0x00046686 File Offset: 0x00044886
		[CompilerGenerated]
		internal Class112 vmethod_2()
		{
			return this.class112_1;
		}

		// Token: 0x06006FCD RID: 28621 RVA: 0x003C5DF8 File Offset: 0x003C3FF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_12);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_1 = class112_16;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FCE RID: 28622 RVA: 0x0004668E File Offset: 0x0004488E
		[CompilerGenerated]
		internal Class112 vmethod_4()
		{
			return this.class112_2;
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x003C5E3C File Offset: 0x003C403C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_3);
			Class112 @class = this.class112_2;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_2 = class112_16;
			@class = this.class112_2;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x00046696 File Offset: 0x00044896
		[CompilerGenerated]
		internal Class112 vmethod_6()
		{
			return this.class112_3;
		}

		// Token: 0x06006FD1 RID: 28625 RVA: 0x003C5E80 File Offset: 0x003C4080
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_4);
			Class112 @class = this.class112_3;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_3 = class112_16;
			@class = this.class112_3;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FD2 RID: 28626 RVA: 0x0004669E File Offset: 0x0004489E
		[CompilerGenerated]
		internal Class112 vmethod_8()
		{
			return this.class112_4;
		}

		// Token: 0x06006FD3 RID: 28627 RVA: 0x003C5EC4 File Offset: 0x003C40C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_13);
			Class112 @class = this.class112_4;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_4 = class112_16;
			@class = this.class112_4;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FD4 RID: 28628 RVA: 0x000466A6 File Offset: 0x000448A6
		[CompilerGenerated]
		internal Class112 vmethod_10()
		{
			return this.class112_5;
		}

		// Token: 0x06006FD5 RID: 28629 RVA: 0x003C5F08 File Offset: 0x003C4108
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_14);
			Class112 @class = this.class112_5;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_5 = class112_16;
			@class = this.class112_5;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FD6 RID: 28630 RVA: 0x000466AE File Offset: 0x000448AE
		[CompilerGenerated]
		internal Class112 vmethod_12()
		{
			return this.class112_6;
		}

		// Token: 0x06006FD7 RID: 28631 RVA: 0x003C5F4C File Offset: 0x003C414C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_6);
			Class112 @class = this.class112_6;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_6 = class112_16;
			@class = this.class112_6;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FD8 RID: 28632 RVA: 0x000466B6 File Offset: 0x000448B6
		[CompilerGenerated]
		internal Class112 vmethod_14()
		{
			return this.class112_7;
		}

		// Token: 0x06006FD9 RID: 28633 RVA: 0x003C5F90 File Offset: 0x003C4190
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_5);
			Class112 @class = this.class112_7;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_7 = class112_16;
			@class = this.class112_7;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FDA RID: 28634 RVA: 0x000466BE File Offset: 0x000448BE
		[CompilerGenerated]
		internal Class112 vmethod_16()
		{
			return this.class112_8;
		}

		// Token: 0x06006FDB RID: 28635 RVA: 0x003C5FD4 File Offset: 0x003C41D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_16);
			Class112 @class = this.class112_8;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_8 = class112_16;
			@class = this.class112_8;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FDC RID: 28636 RVA: 0x000466C6 File Offset: 0x000448C6
		[CompilerGenerated]
		internal Class112 vmethod_18()
		{
			return this.class112_9;
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x003C6018 File Offset: 0x003C4218
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_15);
			Class112 @class = this.class112_9;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_9 = class112_16;
			@class = this.class112_9;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FDE RID: 28638 RVA: 0x000466CE File Offset: 0x000448CE
		[CompilerGenerated]
		internal Class112 vmethod_20()
		{
			return this.class112_10;
		}

		// Token: 0x06006FDF RID: 28639 RVA: 0x003C605C File Offset: 0x003C425C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_18);
			Class112 @class = this.class112_10;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_10 = class112_16;
			@class = this.class112_10;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FE0 RID: 28640 RVA: 0x000466D6 File Offset: 0x000448D6
		[CompilerGenerated]
		internal Class112 vmethod_22()
		{
			return this.class112_11;
		}

		// Token: 0x06006FE1 RID: 28641 RVA: 0x003C60A0 File Offset: 0x003C42A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_17);
			Class112 @class = this.class112_11;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_11 = class112_16;
			@class = this.class112_11;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FE2 RID: 28642 RVA: 0x000466DE File Offset: 0x000448DE
		[CompilerGenerated]
		internal Class112 vmethod_24()
		{
			return this.class112_12;
		}

		// Token: 0x06006FE3 RID: 28643 RVA: 0x003C60E4 File Offset: 0x003C42E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_10);
			Class112 @class = this.class112_12;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_12 = class112_16;
			@class = this.class112_12;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FE4 RID: 28644 RVA: 0x000466E6 File Offset: 0x000448E6
		[CompilerGenerated]
		internal Class112 vmethod_26()
		{
			return this.class112_13;
		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x003C6128 File Offset: 0x003C4328
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_9);
			Class112 @class = this.class112_13;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_13 = class112_16;
			@class = this.class112_13;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x000466EE File Offset: 0x000448EE
		[CompilerGenerated]
		internal Class112 vmethod_28()
		{
			return this.class112_14;
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x003C616C File Offset: 0x003C436C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_7);
			Class112 @class = this.class112_14;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_14 = class112_16;
			@class = this.class112_14;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x000466F6 File Offset: 0x000448F6
		[CompilerGenerated]
		internal Class112 vmethod_30()
		{
			return this.class112_15;
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x003C61B0 File Offset: 0x003C43B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class112 class112_16)
		{
			EventHandler value = new EventHandler(this.method_8);
			Class112 @class = this.class112_15;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_15 = class112_16;
			@class = this.class112_15;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06006FEA RID: 28650 RVA: 0x000466FE File Offset: 0x000448FE
		[CompilerGenerated]
		internal PictureBox vmethod_32()
		{
			return this.pictureBox_0;
		}

		// Token: 0x06006FEB RID: 28651 RVA: 0x003C61F4 File Offset: 0x003C43F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(PictureBox pictureBox_1)
		{
			EventHandler value = new EventHandler(this.method_22);
			PictureBox pictureBox = this.pictureBox_0;
			if (pictureBox != null)
			{
				pictureBox.DoubleClick -= value;
			}
			this.pictureBox_0 = pictureBox_1;
			pictureBox = this.pictureBox_0;
			if (pictureBox != null)
			{
				pictureBox.DoubleClick += value;
			}
		}

		// Token: 0x06006FEC RID: 28652 RVA: 0x003C6238 File Offset: 0x003C4438
		public bool method_1()
		{
			return !this.class295_0.bool_7 && !this.class295_0.bool_15 && !this.class295_0.bool_6 && !this.class295_0.bool_14 && !this.class295_0.bool_5 && !this.class295_0.bool_13 && !this.class295_0.bool_4 && !this.class295_0.bool_12 && !this.class295_0.bool_3 && !this.class295_0.bool_11 && !this.class295_0.bool_2 && !this.class295_0.bool_10 && !this.class295_0.bool_1 && !this.class295_0.bool_9 && !this.class295_0.bool_0 && !this.class295_0.bool_8;
		}

		// Token: 0x06006FED RID: 28653 RVA: 0x003C6370 File Offset: 0x003C4570
		public bool method_2()
		{
			return this.class295_0.bool_7 && this.class295_0.bool_15 && this.class295_0.bool_6 && this.class295_0.bool_14 && this.class295_0.bool_5 && this.class295_0.bool_13 && this.class295_0.bool_4 && this.class295_0.bool_12 && this.class295_0.bool_3 && this.class295_0.bool_11 && this.class295_0.bool_2 && this.class295_0.bool_10 && this.class295_0.bool_1 && this.class295_0.bool_9 && this.class295_0.bool_0 && this.class295_0.bool_8;
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x00046706 File Offset: 0x00044906
		private void method_3(object sender, EventArgs e)
		{
			this.class295_0.bool_7 = this.vmethod_4().Checked;
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x0004671E File Offset: 0x0004491E
		private void method_4(object sender, EventArgs e)
		{
			this.class295_0.bool_15 = this.vmethod_6().Checked;
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x00046736 File Offset: 0x00044936
		private void method_5(object sender, EventArgs e)
		{
			this.class295_0.bool_6 = this.vmethod_14().Checked;
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x0004674E File Offset: 0x0004494E
		private void method_6(object sender, EventArgs e)
		{
			this.class295_0.bool_14 = this.vmethod_12().Checked;
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x00046766 File Offset: 0x00044966
		private void method_7(object sender, EventArgs e)
		{
			this.class295_0.bool_5 = this.vmethod_28().Checked;
		}

		// Token: 0x06006FF3 RID: 28659 RVA: 0x0004677E File Offset: 0x0004497E
		private void method_8(object sender, EventArgs e)
		{
			this.class295_0.bool_13 = this.vmethod_30().Checked;
		}

		// Token: 0x06006FF4 RID: 28660 RVA: 0x00046796 File Offset: 0x00044996
		private void method_9(object sender, EventArgs e)
		{
			this.class295_0.bool_4 = this.vmethod_26().Checked;
		}

		// Token: 0x06006FF5 RID: 28661 RVA: 0x000467AE File Offset: 0x000449AE
		private void method_10(object sender, EventArgs e)
		{
			this.class295_0.bool_12 = this.vmethod_24().Checked;
		}

		// Token: 0x06006FF6 RID: 28662 RVA: 0x000467C6 File Offset: 0x000449C6
		private void method_11(object sender, EventArgs e)
		{
			this.class295_0.bool_3 = this.vmethod_0().Checked;
		}

		// Token: 0x06006FF7 RID: 28663 RVA: 0x000467DE File Offset: 0x000449DE
		private void method_12(object sender, EventArgs e)
		{
			this.class295_0.bool_11 = this.vmethod_2().Checked;
		}

		// Token: 0x06006FF8 RID: 28664 RVA: 0x000467F6 File Offset: 0x000449F6
		private void method_13(object sender, EventArgs e)
		{
			this.class295_0.bool_2 = this.vmethod_8().Checked;
		}

		// Token: 0x06006FF9 RID: 28665 RVA: 0x0004680E File Offset: 0x00044A0E
		private void method_14(object sender, EventArgs e)
		{
			this.class295_0.bool_10 = this.vmethod_10().Checked;
		}

		// Token: 0x06006FFA RID: 28666 RVA: 0x00046826 File Offset: 0x00044A26
		private void method_15(object sender, EventArgs e)
		{
			this.class295_0.bool_1 = this.vmethod_18().Checked;
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x0004683E File Offset: 0x00044A3E
		private void method_16(object sender, EventArgs e)
		{
			this.class295_0.bool_9 = this.vmethod_16().Checked;
		}

		// Token: 0x06006FFC RID: 28668 RVA: 0x00046856 File Offset: 0x00044A56
		private void method_17(object sender, EventArgs e)
		{
			this.class295_0.bool_0 = this.vmethod_22().Checked;
		}

		// Token: 0x06006FFD RID: 28669 RVA: 0x0004686E File Offset: 0x00044A6E
		private void method_18(object sender, EventArgs e)
		{
			this.class295_0.bool_8 = this.vmethod_20().Checked;
		}

		// Token: 0x06006FFE RID: 28670 RVA: 0x00046886 File Offset: 0x00044A86
		private void PlatformComponentArcControl_DoubleClick(object sender, EventArgs e)
		{
			this.method_19();
		}

		// Token: 0x06006FFF RID: 28671 RVA: 0x0004688E File Offset: 0x00044A8E
		private void method_19()
		{
			if (this.method_2())
			{
				this.method_21();
				return;
			}
			this.method_20();
		}

		// Token: 0x06007000 RID: 28672 RVA: 0x003C64A8 File Offset: 0x003C46A8
		private void method_20()
		{
			this.class295_0.bool_3 = true;
			this.class295_0.bool_11 = true;
			this.class295_0.bool_1 = true;
			this.class295_0.bool_9 = true;
			this.class295_0.bool_2 = true;
			this.class295_0.bool_10 = true;
			this.class295_0.bool_0 = true;
			this.class295_0.bool_8 = true;
			this.class295_0.bool_7 = true;
			this.class295_0.bool_15 = true;
			this.class295_0.bool_5 = true;
			this.class295_0.bool_13 = true;
			this.class295_0.bool_6 = true;
			this.class295_0.bool_14 = true;
			this.class295_0.bool_4 = true;
			this.class295_0.bool_12 = true;
			this.vmethod_0().Checked = true;
			this.vmethod_2().Checked = true;
			this.vmethod_18().Checked = true;
			this.vmethod_16().Checked = true;
			this.vmethod_8().Checked = true;
			this.vmethod_10().Checked = true;
			this.vmethod_22().Checked = true;
			this.vmethod_20().Checked = true;
			this.vmethod_4().Checked = true;
			this.vmethod_6().Checked = true;
			this.vmethod_28().Checked = true;
			this.vmethod_30().Checked = true;
			this.vmethod_14().Checked = true;
			this.vmethod_12().Checked = true;
			this.vmethod_26().Checked = true;
			this.vmethod_24().Checked = true;
			this.Refresh();
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x003C663C File Offset: 0x003C483C
		private void method_21()
		{
			this.class295_0.bool_3 = false;
			this.class295_0.bool_11 = false;
			this.class295_0.bool_1 = false;
			this.class295_0.bool_9 = false;
			this.class295_0.bool_2 = false;
			this.class295_0.bool_10 = false;
			this.class295_0.bool_0 = false;
			this.class295_0.bool_8 = false;
			this.class295_0.bool_7 = false;
			this.class295_0.bool_15 = false;
			this.class295_0.bool_5 = false;
			this.class295_0.bool_13 = false;
			this.class295_0.bool_6 = false;
			this.class295_0.bool_14 = false;
			this.class295_0.bool_4 = false;
			this.class295_0.bool_12 = false;
			this.vmethod_0().Checked = false;
			this.vmethod_2().Checked = false;
			this.vmethod_18().Checked = false;
			this.vmethod_16().Checked = false;
			this.vmethod_8().Checked = false;
			this.vmethod_10().Checked = false;
			this.vmethod_22().Checked = false;
			this.vmethod_20().Checked = false;
			this.vmethod_4().Checked = false;
			this.vmethod_6().Checked = false;
			this.vmethod_28().Checked = false;
			this.vmethod_30().Checked = false;
			this.vmethod_14().Checked = false;
			this.vmethod_12().Checked = false;
			this.vmethod_26().Checked = false;
			this.vmethod_24().Checked = false;
			this.Refresh();
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x00046886 File Offset: 0x00044A86
		private void method_22(object sender, EventArgs e)
		{
			this.method_19();
		}

		// Token: 0x06007003 RID: 28675 RVA: 0x00044489 File Offset: 0x00042689
		private void PlatformComponentArcControl_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04003F4F RID: 16207
		private IContainer icontainer_1;

		// Token: 0x04003F50 RID: 16208
		[AccessedThroughProperty("CB_PB1")]
		[CompilerGenerated]
		private Class112 class112_0;

		// Token: 0x04003F51 RID: 16209
		[AccessedThroughProperty("CB_PB2")]
		[CompilerGenerated]
		private Class112 class112_1;

		// Token: 0x04003F52 RID: 16210
		[CompilerGenerated]
		[AccessedThroughProperty("CB_SB1")]
		private Class112 class112_2;

		// Token: 0x04003F53 RID: 16211
		[CompilerGenerated]
		[AccessedThroughProperty("CB_SB2")]
		private Class112 class112_3;

		// Token: 0x04003F54 RID: 16212
		[AccessedThroughProperty("CB_PMF1")]
		[CompilerGenerated]
		private Class112 class112_4;

		// Token: 0x04003F55 RID: 16213
		[AccessedThroughProperty("CB_PMF2")]
		[CompilerGenerated]
		private Class112 class112_5;

		// Token: 0x04003F56 RID: 16214
		[CompilerGenerated]
		[AccessedThroughProperty("CB_SMF2")]
		private Class112 class112_6;

		// Token: 0x04003F57 RID: 16215
		[AccessedThroughProperty("CB_SMF1")]
		[CompilerGenerated]
		private Class112 class112_7;

		// Token: 0x04003F58 RID: 16216
		[CompilerGenerated]
		[AccessedThroughProperty("CB_PMA2")]
		private Class112 class112_8;

		// Token: 0x04003F59 RID: 16217
		[CompilerGenerated]
		[AccessedThroughProperty("CB_PMA1")]
		private Class112 class112_9;

		// Token: 0x04003F5A RID: 16218
		[CompilerGenerated]
		[AccessedThroughProperty("CB_PS2")]
		private Class112 class112_10;

		// Token: 0x04003F5B RID: 16219
		[CompilerGenerated]
		[AccessedThroughProperty("CB_PS1")]
		private Class112 class112_11;

		// Token: 0x04003F5C RID: 16220
		[CompilerGenerated]
		[AccessedThroughProperty("CB_SS2")]
		private Class112 class112_12;

		// Token: 0x04003F5D RID: 16221
		[CompilerGenerated]
		[AccessedThroughProperty("CB_SS1")]
		private Class112 class112_13;

		// Token: 0x04003F5E RID: 16222
		[CompilerGenerated]
		[AccessedThroughProperty("CB_SMA1")]
		private Class112 class112_14;

		// Token: 0x04003F5F RID: 16223
		[CompilerGenerated]
		[AccessedThroughProperty("CB_SMA2")]
		private Class112 class112_15;

		// Token: 0x04003F60 RID: 16224
		[CompilerGenerated]
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox pictureBox_0;

		// Token: 0x04003F61 RID: 16225
		public PlatformComponent.Class295 class295_0;
	}
}
