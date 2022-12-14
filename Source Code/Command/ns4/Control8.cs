using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ns5;

namespace ns4
{
	// Token: 0x02000DC8 RID: 3528
	internal sealed class Control8 : Control
	{
		// Token: 0x060065E0 RID: 26080 RVA: 0x000404F9 File Offset: 0x0003E6F9
		private TextBox method_0()
		{
			return this.textBox_0;
		}

		// Token: 0x060065E1 RID: 26081
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

		// Token: 0x060065E2 RID: 26082 RVA: 0x00040501 File Offset: 0x0003E701
		public void method_1(HorizontalAlignment horizontalAlignment_1)
		{
			this.horizontalAlignment_0 = horizontalAlignment_1;
			if (this.method_0() != null)
			{
				this.method_0().TextAlign = horizontalAlignment_1;
			}
			base.Invalidate();
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x00040524 File Offset: 0x0003E724
		public void method_2(int int_1)
		{
			this.int_0 = int_1;
			if (this.method_0() != null)
			{
				this.method_0().MaxLength = int_1;
			}
			base.Invalidate();
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x00040547 File Offset: 0x0003E747
		public void method_3(bool bool_3)
		{
			this.bool_0 = bool_3;
			if (this.method_0() != null)
			{
				this.method_0().ReadOnly = bool_3;
			}
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x00040564 File Offset: 0x0003E764
		public bool method_4()
		{
			return this.bool_1;
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x0004056C File Offset: 0x0003E76C
		public void method_5(bool bool_3)
		{
			this.bool_1 = bool_3;
			if (this.method_0() != null)
			{
				this.method_0().UseSystemPasswordChar = bool_3;
			}
		}

		// Token: 0x060065E7 RID: 26087 RVA: 0x00040589 File Offset: 0x0003E789
		public bool method_6()
		{
			return this.bool_2;
		}

		// Token: 0x060065E8 RID: 26088 RVA: 0x00383974 File Offset: 0x00381B74
		public void method_7(bool bool_3)
		{
			this.bool_2 = bool_3;
			if (this.method_0() != null)
			{
				this.method_0().Multiline = bool_3;
				if (bool_3)
				{
					this.method_0().Height = base.Height - 10;
					return;
				}
				base.Height = this.method_0().Height + 10;
			}
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x00040591 File Offset: 0x0003E791
		public int method_8()
		{
			return this.method_0().SelectionStart;
		}

		// Token: 0x060065EA RID: 26090 RVA: 0x0004059E File Offset: 0x0003E79E
		public void method_9(int int_1)
		{
			this.method_0().SelectionStart = int_1;
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060065EB RID: 26091 RVA: 0x000405AC File Offset: 0x0003E7AC
		// (set) Token: 0x060065EC RID: 26092 RVA: 0x000405B4 File Offset: 0x0003E7B4
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
				if (this.method_0() != null)
				{
					this.method_0().Text = value;
				}
			}
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x000405D1 File Offset: 0x0003E7D1
		public void method_10(string string_2)
		{
			this.string_0 = string_2;
			Control8.SendMessage(this.method_0().Handle, 5377, 0, string_2);
			base.Invalidate();
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x000405F8 File Offset: 0x0003E7F8
		public Image method_11()
		{
			return this.image_0;
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x00040600 File Offset: 0x0003E800
		public void method_12(Image image_1)
		{
			this.image_0 = image_1;
			base.Invalidate();
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x0004060F File Offset: 0x0003E80F
		public void method_13(AutoCompleteSource autoCompleteSource_1)
		{
			this.autoCompleteSource_0 = autoCompleteSource_1;
			if (this.method_0() != null)
			{
				this.method_0().AutoCompleteSource = autoCompleteSource_1;
			}
			base.Invalidate();
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x00040632 File Offset: 0x0003E832
		public void method_14(AutoCompleteStringCollection autoCompleteStringCollection_1)
		{
			this.autoCompleteStringCollection_0 = autoCompleteStringCollection_1;
			if (this.method_0() != null)
			{
				this.method_0().AutoCompleteCustomSource = autoCompleteStringCollection_1;
			}
			base.Invalidate();
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x00040655 File Offset: 0x0003E855
		public void method_15(AutoCompleteMode autoCompleteMode_1)
		{
			this.autoCompleteMode_0 = autoCompleteMode_1;
			if (this.method_0() != null)
			{
				this.method_0().AutoCompleteMode = autoCompleteMode_1;
			}
			base.Invalidate();
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x00004269 File Offset: 0x00002469
		public Font method_16()
		{
			return base.Font;
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x003839C8 File Offset: 0x00381BC8
		public void method_17(Font font_0)
		{
			base.Font = font_0;
			if (this.method_0() != null)
			{
				this.method_0().Font = font_0;
				this.method_0().Location = new Point(5, 5);
				this.method_0().Width = base.Width - 8;
				if (!this.method_6())
				{
					base.Height = this.method_0().Height + 11;
				}
			}
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x00040678 File Offset: 0x0003E878
		public void method_18(string[] string_2)
		{
			this.string_1 = string_2;
			if (this.method_0() != null)
			{
				this.method_0().Lines = string_2;
				base.Invalidate();
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060065F6 RID: 26102 RVA: 0x0004069B File Offset: 0x0003E89B
		// (set) Token: 0x060065F7 RID: 26103 RVA: 0x000406A3 File Offset: 0x0003E8A3
		public override ContextMenuStrip ContextMenuStrip
		{
			get
			{
				return base.ContextMenuStrip;
			}
			set
			{
				base.ContextMenuStrip = value;
				if (this.method_0() != null)
				{
					this.method_0().ContextMenuStrip = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060065F8 RID: 26104 RVA: 0x000406C6 File Offset: 0x0003E8C6
		public override bool Focused
		{
			get
			{
				return this.method_0().Focused;
			}
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x000406D3 File Offset: 0x0003E8D3
		public void method_19(ScrollBars scrollBars_0)
		{
			this.method_0().ScrollBars = scrollBars_0;
		}

		// Token: 0x060065FA RID: 26106 RVA: 0x00383A34 File Offset: 0x00381C34
		public Control8()
		{
			this.textBox_0 = new TextBox();
			this.horizontalAlignment_0 = HorizontalAlignment.Left;
			this.int_0 = 32767;
			this.bool_0 = false;
			this.bool_1 = false;
			this.string_0 = string.Empty;
			this.autoCompleteSource_0 = AutoCompleteSource.None;
			this.autoCompleteMode_0 = AutoCompleteMode.None;
			this.bool_2 = false;
			this.string_1 = null;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.UpdateStyles();
			this.BackColor = Color.Transparent;
			this.ForeColor = Color.FromArgb(189, 189, 189);
			this.method_0().Multiline = false;
			this.method_0().Cursor = Cursors.IBeam;
			this.method_0().BackColor = Color.FromArgb(31, 31, 31);
			this.method_0().ForeColor = this.ForeColor;
			this.method_0().BorderStyle = BorderStyle.None;
			this.method_0().Location = new Point(7, 4);
			this.method_0().Font = this.method_16();
			this.method_0().UseSystemPasswordChar = this.method_4();
			base.Size = new Size(135, 30);
			if (this.method_6())
			{
				this.method_0().Height = base.Height - 11;
			}
			else
			{
				base.Height = this.method_0().Height + 11;
			}
			this.textBox_0.TextChanged += this.textBox_0_TextChanged;
			this.textBox_0.KeyDown += this.textBox_0_KeyDown;
		}

		// Token: 0x060065FB RID: 26107 RVA: 0x000406E1 File Offset: 0x0003E8E1
		public void method_20()
		{
			this.method_0().Clear();
			this.Text = string.Empty;
		}

		// Token: 0x060065FC RID: 26108 RVA: 0x00383BD0 File Offset: 0x00381DD0
		[CompilerGenerated]
		public void method_21(Control8.Delegate85 delegate85_1)
		{
			Control8.Delegate85 @delegate = this.delegate85_0;
			Control8.Delegate85 delegate2;
			do
			{
				delegate2 = @delegate;
				Control8.Delegate85 value = (Control8.Delegate85)Delegate.Combine(delegate2, delegate85_1);
				@delegate = Interlocked.CompareExchange<Control8.Delegate85>(ref this.delegate85_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060065FD RID: 26109 RVA: 0x00383C08 File Offset: 0x00381E08
		[CompilerGenerated]
		public void method_22(Control8.Delegate85 delegate85_1)
		{
			Control8.Delegate85 @delegate = this.delegate85_0;
			Control8.Delegate85 delegate2;
			do
			{
				delegate2 = @delegate;
				Control8.Delegate85 value = (Control8.Delegate85)Delegate.Remove(delegate2, delegate85_1);
				@delegate = Interlocked.CompareExchange<Control8.Delegate85>(ref this.delegate85_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060065FE RID: 26110 RVA: 0x000406F9 File Offset: 0x0003E8F9
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			if (!base.Controls.Contains(this.method_0()))
			{
				base.Controls.Add(this.method_0());
			}
		}

		// Token: 0x060065FF RID: 26111 RVA: 0x00040725 File Offset: 0x0003E925
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.method_0().Size = new Size(base.Width - 10, base.Height - 10);
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x00383C40 File Offset: 0x00381E40
		private void textBox_0_TextChanged(object sender, EventArgs e)
		{
			this.Text = this.method_0().Text;
			if (this.delegate85_0 != null)
			{
				Control8.Delegate85 @delegate = this.delegate85_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
			base.Invalidate();
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x00383C80 File Offset: 0x00381E80
		private void textBox_0_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				e.SuppressKeyPress = true;
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				this.method_0().Copy();
				e.SuppressKeyPress = true;
			}
			base.Invalidate();
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x00383CD0 File Offset: 0x00381ED0
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			Rectangle rect = new Rectangle(0, 0, this.method_0().Width + 8, this.method_0().Height + 8);
			using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(31, 31, 31)))
			{
				Class2450.smethod_0(graphics, solidBrush, rect, 2, true, true, true, true);
				Class2450.smethod_1(graphics, Color.FromArgb(22, 22, 22), 1f, rect, 2, true, true, true, true);
			}
			if (this.method_11() != null)
			{
				this.method_0().Location = new Point(31, 2);
				this.method_0().Width = base.Width - 60;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.DrawImage(this.method_11(), new Rectangle(8, 6, 16, 16));
				return;
			}
			this.method_0().Location = new Point(5, 2);
		}

		// Token: 0x04003A39 RID: 14905
		private TextBox textBox_0;

		// Token: 0x04003A3A RID: 14906
		private HorizontalAlignment horizontalAlignment_0;

		// Token: 0x04003A3B RID: 14907
		private int int_0;

		// Token: 0x04003A3C RID: 14908
		private bool bool_0;

		// Token: 0x04003A3D RID: 14909
		private bool bool_1;

		// Token: 0x04003A3E RID: 14910
		private string string_0;

		// Token: 0x04003A3F RID: 14911
		private Image image_0;

		// Token: 0x04003A40 RID: 14912
		private AutoCompleteSource autoCompleteSource_0;

		// Token: 0x04003A41 RID: 14913
		private AutoCompleteMode autoCompleteMode_0;

		// Token: 0x04003A42 RID: 14914
		private AutoCompleteStringCollection autoCompleteStringCollection_0;

		// Token: 0x04003A43 RID: 14915
		private bool bool_2;

		// Token: 0x04003A44 RID: 14916
		private string[] string_1;

		// Token: 0x04003A45 RID: 14917
		[CompilerGenerated]
		private Control8.Delegate85 delegate85_0;

		// Token: 0x02000DC9 RID: 3529
		// (Invoke) Token: 0x06006606 RID: 26118
		internal delegate void Delegate85(object sender);
	}
}
