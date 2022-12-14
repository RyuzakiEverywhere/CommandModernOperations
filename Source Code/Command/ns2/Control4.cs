using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns8;

namespace ns2
{
	// Token: 0x020000C9 RID: 201
	internal sealed class Control4 : Control3
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x000666D0 File Offset: 0x000648D0
		[CompilerGenerated]
		public void method_16(EventHandler eventHandler_3)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_3);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00066708 File Offset: 0x00064908
		[CompilerGenerated]
		public void method_17(EventHandler eventHandler_3)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_3);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000058F4 File Offset: 0x00003AF4
		public ObservableCollection<Class117> method_18()
		{
			return this.observableCollection_0;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00066740 File Offset: 0x00064940
		public void method_19(ObservableCollection<Class117> observableCollection_1)
		{
			if (this.observableCollection_0 != null)
			{
				this.observableCollection_0.CollectionChanged -= new NotifyCollectionChangedEventHandler(this.observableCollection_0_CollectionChanged);
			}
			this.observableCollection_0 = observableCollection_1;
			this.observableCollection_0.CollectionChanged += new NotifyCollectionChangedEventHandler(this.observableCollection_0_CollectionChanged);
			this.method_33();
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000058FC File Offset: 0x00003AFC
		public List<int> method_20()
		{
			return this.list_0;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00066790 File Offset: 0x00064990
		public List<Class117> method_21()
		{
			List<Class117> list = new List<Class117>();
			foreach (int index in this.method_20())
			{
				list.Add(this.method_18()[index]);
			}
			return list;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00005904 File Offset: 0x00003B04
		public int method_22()
		{
			return this.int_1;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000590C File Offset: 0x00003B0C
		public void method_23(int int_5)
		{
			this.int_1 = int_5;
			this.method_33();
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000591B File Offset: 0x00003B1B
		public bool method_24()
		{
			return this.bool_2;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00005923 File Offset: 0x00003B23
		public void method_25(bool bool_5)
		{
			this.bool_2 = bool_5;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000592C File Offset: 0x00003B2C
		public void method_26(bool bool_5)
		{
			this.bool_3 = bool_5;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00005935 File Offset: 0x00003B35
		[CompilerGenerated]
		public bool method_27()
		{
			return this.bool_4;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000667F8 File Offset: 0x000649F8
		public Control4()
		{
			this.method_19(new ObservableCollection<Class117>());
			this.list_0 = new List<int>();
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00066848 File Offset: 0x00064A48
		private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.NewItems != null)
			{
				using (Graphics graphics = base.CreateGraphics())
				{
					foreach (object obj in e.NewItems)
					{
						Class117 @class = (Class117)obj;
						@class.method_0(new EventHandler(this.method_28));
						this.method_35(@class, graphics);
					}
				}
				if (e.NewStartingIndex < this.method_18().Count - 1)
				{
					for (int i = e.NewStartingIndex; i <= this.method_18().Count - 1; i++)
					{
						this.method_36(this.method_18()[i], i);
					}
				}
			}
			if (e.OldItems != null)
			{
				foreach (object obj2 in e.OldItems)
				{
					((Class117)obj2).method_1(new EventHandler(this.method_28));
				}
				if (e.OldStartingIndex < this.method_18().Count - 1)
				{
					for (int j = e.OldStartingIndex; j <= this.method_18().Count - 1; j++)
					{
						this.method_36(this.method_18()[j], j);
					}
				}
			}
			if (this.method_18().Count == 0 && this.list_0.Count > 0)
			{
				this.list_0.Clear();
				if (this.eventHandler_2 != null)
				{
					this.eventHandler_2(this, null);
				}
			}
			if (this.bool_3)
			{
				this.method_37();
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00066A1C File Offset: 0x00064C1C
		private void method_28(object sender, EventArgs e)
		{
			Class117 class117_ = (Class117)sender;
			this.method_34(class117_);
			this.method_38(class117_);
			base.Invalidate();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00066A44 File Offset: 0x00064C44
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (this.method_18().Count == 0)
			{
				return;
			}
			if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
			{
				return;
			}
			Point pt = base.method_4();
			List<int> list = Enumerable.ToList<int>(this.method_40());
			int num = Enumerable.Min(list);
			int num2 = Enumerable.Max(list);
			int width = Math.Max(base.method_2().Width, base.method_0().Width);
			for (int i = num; i <= num2; i++)
			{
				Rectangle rectangle = new Rectangle(0, i * this.method_22(), width, this.method_22());
				if (rectangle.Contains(pt))
				{
					if (this.method_24() && Control.ModifierKeys == Keys.Shift)
					{
						this.method_32(i);
					}
					else if (this.method_24() && Control.ModifierKeys == Keys.Control)
					{
						this.method_30(i);
					}
					else
					{
						this.method_29(i);
					}
				}
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00066B3C File Offset: 0x00064D3C
		protected override void OnKeyDown(KeyEventArgs ke)
		{
			base.OnKeyDown(ke);
			if (this.method_18().Count == 0)
			{
				return;
			}
			if (ke.KeyCode != Keys.Down && ke.KeyCode != Keys.Up)
			{
				return;
			}
			if (this.method_24() && Control.ModifierKeys == Keys.Shift)
			{
				if (ke.KeyCode == Keys.Up)
				{
					if (this.int_4 - 1 >= 0)
					{
						this.method_32(this.int_4 - 1);
						this.method_39();
					}
				}
				else if (ke.KeyCode == Keys.Down && this.int_4 + 1 <= this.method_18().Count - 1)
				{
					this.method_32(this.int_4 + 1);
				}
			}
			else if (ke.KeyCode == Keys.Up)
			{
				if (this.int_4 - 1 >= 0)
				{
					this.method_29(this.int_4 - 1);
				}
			}
			else if (ke.KeyCode == Keys.Down && this.int_4 + 1 <= this.method_18().Count - 1)
			{
				this.method_29(this.int_4 + 1);
			}
			this.method_39();
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00066C44 File Offset: 0x00064E44
		public void method_29(int int_5)
		{
			if (int_5 >= 0 && int_5 <= this.method_18().Count - 1)
			{
				this.list_0.Clear();
				this.list_0.Add(int_5);
				if (this.eventHandler_2 != null)
				{
					this.eventHandler_2(this, null);
				}
				this.int_3 = int_5;
				this.int_4 = int_5;
				base.Invalidate();
				return;
			}
			throw new IndexOutOfRangeException(string.Format("Value '{0}' is outside of valid range.", int_5));
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00066CC0 File Offset: 0x00064EC0
		public void method_30(int int_5)
		{
			if (this.list_0.Contains(int_5))
			{
				this.list_0.Remove(int_5);
				if (this.int_3 == int_5 && this.int_4 == int_5)
				{
					if (this.list_0.Count > 0)
					{
						this.int_3 = this.list_0[0];
						this.int_4 = this.list_0[0];
					}
					else
					{
						this.int_3 = -1;
						this.int_4 = -1;
					}
				}
				if (this.int_3 == int_5)
				{
					if (this.int_4 < int_5)
					{
						this.int_3 = int_5 - 1;
					}
					else if (this.int_4 > int_5)
					{
						this.int_3 = int_5 + 1;
					}
					else
					{
						this.int_3 = this.int_4;
					}
				}
				if (this.int_4 == int_5)
				{
					if (this.int_3 < int_5)
					{
						this.int_4 = int_5 - 1;
					}
					else if (this.int_3 > int_5)
					{
						this.int_4 = int_5 + 1;
					}
					else
					{
						this.int_4 = this.int_3;
					}
				}
			}
			else
			{
				this.list_0.Add(int_5);
				this.int_3 = int_5;
				this.int_4 = int_5;
			}
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, null);
			}
			base.Invalidate();
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00066DF0 File Offset: 0x00064FF0
		public void method_31(int int_5, int int_6)
		{
			this.list_0.Clear();
			if (int_5 == int_6)
			{
				this.list_0.Add(int_5);
			}
			if (int_5 < int_6)
			{
				for (int i = int_5; i <= int_6; i++)
				{
					this.list_0.Add(i);
				}
			}
			else if (int_5 > int_6)
			{
				for (int j = int_5; j >= int_6; j--)
				{
					this.list_0.Add(j);
				}
			}
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, null);
			}
			base.Invalidate();
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000593D File Offset: 0x00003B3D
		private void method_32(int int_5)
		{
			this.int_4 = int_5;
			this.method_31(this.int_3, int_5);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00066E70 File Offset: 0x00065070
		private void method_33()
		{
			using (Graphics graphics = base.CreateGraphics())
			{
				for (int i = 0; i <= this.method_18().Count - 1; i++)
				{
					Class117 class117_ = this.method_18()[i];
					this.method_35(class117_, graphics);
					this.method_36(class117_, i);
				}
			}
			this.method_37();
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00066EDC File Offset: 0x000650DC
		private void method_34(Class117 class117_0)
		{
			using (Graphics graphics = base.CreateGraphics())
			{
				this.method_35(class117_0, graphics);
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00066F14 File Offset: 0x00065114
		private void method_35(Class117 class117_0, Graphics graphics_0)
		{
			SizeF sizeF = graphics_0.MeasureString(class117_0.method_2(), this.Font);
			float width = sizeF.Width;
			sizeF.Width = width + 1f;
			if (this.method_27())
			{
				sizeF.Width += (float)(this.int_2 + 8);
			}
			class117_0.method_5(new Rectangle(class117_0.method_4().Left, class117_0.method_4().Top, (int)sizeF.Width, class117_0.method_4().Height));
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00066FA8 File Offset: 0x000651A8
		private void method_36(Class117 class117_0, int int_5)
		{
			class117_0.method_5(new Rectangle(2, int_5 * this.method_22(), class117_0.method_4().Width, this.method_22()));
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00066FE0 File Offset: 0x000651E0
		public void method_37()
		{
			int num = 0;
			foreach (Class117 @class in this.method_18())
			{
				if (@class.method_4().Right + 1 > num)
				{
					num = @class.method_4().Right + 1;
				}
			}
			int num2 = num;
			int num3 = this.method_18().Count * this.method_22();
			if (base.method_2().Width != num2 || base.method_2().Height != num3)
			{
				base.method_3(new Size(num2, num3));
				base.Invalidate();
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000670A0 File Offset: 0x000652A0
		private void method_38(Class117 class117_0)
		{
			int num = class117_0.method_4().Right + 1;
			if (num == base.method_2().Width)
			{
				this.method_37();
				return;
			}
			if (num > base.method_2().Width)
			{
				base.method_3(new Size(num, base.method_2().Height));
				base.Invalidate();
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00067108 File Offset: 0x00065308
		public void method_39()
		{
			if (this.method_20().Count == 0)
			{
				return;
			}
			int num;
			if (!this.method_24())
			{
				num = this.method_20()[0] * this.method_22();
			}
			else
			{
				num = this.int_4 * this.method_22();
			}
			int num2 = num + this.method_22();
			if (num < base.method_0().Top)
			{
				base.method_13(num);
			}
			if (num2 > base.method_0().Bottom)
			{
				base.method_13(num2 - base.method_0().Height);
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0006719C File Offset: 0x0006539C
		private IEnumerable<int> method_40()
		{
			int num = base.method_0().Top / this.method_22() - 1;
			if (num < 0)
			{
				num = 0;
			}
			int num2 = (base.method_0().Top + base.method_0().Height) / this.method_22() + 1;
			if (num2 > this.method_18().Count)
			{
				num2 = this.method_18().Count;
			}
			return Enumerable.Range(num, num2 - num);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00067214 File Offset: 0x00065414
		protected override void vmethod_2(Graphics graphics_0)
		{
			List<int> list = Enumerable.ToList<int>(this.method_40());
			if (list.Count == 0)
			{
				return;
			}
			int num = Enumerable.Min(list);
			int num2 = Enumerable.Max(list);
			for (int i = num; i <= num2; i++)
			{
				int width = Math.Max(base.method_2().Width, base.method_0().Width);
				Rectangle rect = new Rectangle(0, i * this.method_22(), width, this.method_22());
				Color color = (i % 2 == 0) ? Class129.smethod_1() : Class129.smethod_0();
				if (this.method_20().Count > 0 && this.method_20().Contains(i))
				{
					color = (this.Focused ? Class129.smethod_14() : Class129.smethod_16());
				}
				using (SolidBrush solidBrush = new SolidBrush(color))
				{
					graphics_0.FillRectangle(solidBrush, rect);
				}
				if (this.method_27() && this.method_18()[i].method_10() != null)
				{
					graphics_0.DrawImageUnscaled(this.method_18()[i].method_10(), new Point(rect.Left + 5, rect.Top + rect.Height / 2 - this.int_2 / 2));
				}
				using (SolidBrush solidBrush2 = new SolidBrush(this.method_18()[i].method_6()))
				{
					StringFormat format = new StringFormat
					{
						Alignment = StringAlignment.Near,
						LineAlignment = StringAlignment.Center
					};
					Font font = new Font(this.Font, this.method_18()[i].method_8());
					Rectangle r = new Rectangle(rect.Left + 2, rect.Top, rect.Width, rect.Height);
					if (this.method_27())
					{
						r.X += this.int_2 + 8;
					}
					graphics_0.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
					graphics_0.DrawString(this.method_18()[i].method_2(), font, solidBrush2, r, format);
				}
			}
		}

		// Token: 0x04000355 RID: 853
		[CompilerGenerated]
		private EventHandler eventHandler_2;

		// Token: 0x04000356 RID: 854
		private int int_1 = 20;

		// Token: 0x04000357 RID: 855
		private bool bool_2;

		// Token: 0x04000358 RID: 856
		private readonly int int_2 = 16;

		// Token: 0x04000359 RID: 857
		private ObservableCollection<Class117> observableCollection_0;

		// Token: 0x0400035A RID: 858
		private List<int> list_0;

		// Token: 0x0400035B RID: 859
		private int int_3 = -1;

		// Token: 0x0400035C RID: 860
		private int int_4 = -1;

		// Token: 0x0400035D RID: 861
		private bool bool_3 = true;

		// Token: 0x0400035E RID: 862
		[CompilerGenerated]
		private bool bool_4;
	}
}
