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
using DarkUI.Collections;
using ns3;
using ns8;

namespace ns2
{
	// Token: 0x020000DC RID: 220
	internal sealed class Control6 : Control3
	{
		// Token: 0x06000572 RID: 1394 RVA: 0x0006B5A4 File Offset: 0x000697A4
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

		// Token: 0x06000573 RID: 1395 RVA: 0x0006B5DC File Offset: 0x000697DC
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

		// Token: 0x06000574 RID: 1396 RVA: 0x0006B614 File Offset: 0x00069814
		[CompilerGenerated]
		public void method_18(Control6.Delegate9 delegate9_1)
		{
			Control6.Delegate9 @delegate = this.delegate9_0;
			Control6.Delegate9 delegate2;
			do
			{
				delegate2 = @delegate;
				Control6.Delegate9 value = (Control6.Delegate9)Delegate.Combine(delegate2, delegate9_1);
				@delegate = Interlocked.CompareExchange<Control6.Delegate9>(ref this.delegate9_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0006B64C File Offset: 0x0006984C
		[CompilerGenerated]
		public void method_19(Control6.Delegate9 delegate9_1)
		{
			Control6.Delegate9 @delegate = this.delegate9_0;
			Control6.Delegate9 delegate2;
			do
			{
				delegate2 = @delegate;
				Control6.Delegate9 value = (Control6.Delegate9)Delegate.Remove(delegate2, delegate9_1);
				@delegate = Interlocked.CompareExchange<Control6.Delegate9>(ref this.delegate9_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00006185 File Offset: 0x00004385
		public ObservableList<Class127> method_20()
		{
			return this.observableList_0;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0006B684 File Offset: 0x00069884
		public void method_21(ObservableList<Class127> observableList_1)
		{
			if (this.observableList_0 != null)
			{
				this.observableList_0.method_1(new EventHandler<EventArgs5<Class127>>(this.method_32));
				this.observableList_0.method_3(new EventHandler<EventArgs5<Class127>>(this.method_33));
				foreach (Class127 class127_ in this.observableList_0)
				{
					this.method_40(class127_);
				}
			}
			this.observableList_0 = observableList_1;
			this.observableList_0.method_0(new EventHandler<EventArgs5<Class127>>(this.method_32));
			this.observableList_0.method_2(new EventHandler<EventArgs5<Class127>>(this.method_33));
			foreach (Class127 class127_2 in this.observableList_0)
			{
				this.method_39(class127_2);
			}
			this.method_41();
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0000618D File Offset: 0x0000438D
		public ObservableCollection<Class127> method_22()
		{
			return this.observableCollection_0;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00006195 File Offset: 0x00004395
		public int method_23()
		{
			return this.int_3;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0000619D File Offset: 0x0000439D
		public int method_24()
		{
			return this.int_4;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000061A5 File Offset: 0x000043A5
		[CompilerGenerated]
		public bool method_25()
		{
			return this.bool_4;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000061AD File Offset: 0x000043AD
		[CompilerGenerated]
		public void method_26(bool bool_7)
		{
			this.bool_4 = bool_7;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000061B6 File Offset: 0x000043B6
		[CompilerGenerated]
		public bool method_27()
		{
			return this.bool_5;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000061BE File Offset: 0x000043BE
		[CompilerGenerated]
		public bool method_28()
		{
			return this.bool_6;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000061C6 File Offset: 0x000043C6
		[CompilerGenerated]
		public void method_29(bool bool_7)
		{
			this.bool_6 = bool_7;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000061CF File Offset: 0x000043CF
		[CompilerGenerated]
		private void method_30(int int_6)
		{
			this.int_5 = int_6;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000061D8 File Offset: 0x000043D8
		[CompilerGenerated]
		public IComparer<Class127> method_31()
		{
			return this.icomparer_0;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0006B78C File Offset: 0x0006998C
		public Control6()
		{
			this.method_21(new ObservableList<Class127>());
			this.observableCollection_0 = new ObservableCollection<Class127>();
			this.observableCollection_0.CollectionChanged += new NotifyCollectionChangedEventHandler(this.observableCollection_0_CollectionChanged);
			base.method_6(this.int_3);
			this.method_44();
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0006B800 File Offset: 0x00069A00
		protected override void Dispose(bool disposing)
		{
			if (!this.bool_2)
			{
				this.method_45();
				if (this.eventHandler_2 != null)
				{
					this.eventHandler_2 = null;
				}
				if (this.delegate9_0 != null)
				{
					this.delegate9_0 = null;
				}
				if (this.delegate10_0 != null)
				{
					this.delegate9_0 = null;
				}
				if (this.observableList_0 != null)
				{
					this.observableList_0.Dispose();
				}
				if (this.observableCollection_0 != null)
				{
					this.observableCollection_0.CollectionChanged -= new NotifyCollectionChangedEventHandler(this.observableCollection_0_CollectionChanged);
				}
				this.bool_2 = true;
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0006B888 File Offset: 0x00069A88
		private void method_32(object sender, EventArgs5<Class127> e)
		{
			foreach (Class127 @class in e.method_0())
			{
				@class.method_27(this);
				@class.method_25(true);
				this.method_39(@class);
			}
			if (this.method_31() != null)
			{
				this.method_20().Sort(this.method_31());
			}
			this.method_41();
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0006B904 File Offset: 0x00069B04
		private void method_33(object sender, EventArgs5<Class127> e)
		{
			foreach (Class127 @class in e.method_0())
			{
				@class.method_27(this);
				@class.method_25(true);
				this.method_39(@class);
			}
			this.method_41();
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0006B968 File Offset: 0x00069B68
		private void method_34(object sender, EventArgs5<Class127> e)
		{
			foreach (Class127 class127_ in e.method_0())
			{
				this.method_39(class127_);
			}
			this.method_41();
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0006B9BC File Offset: 0x00069BBC
		private void method_35(object sender, EventArgs5<Class127> e)
		{
			foreach (Class127 @class in e.method_0())
			{
				if (this.method_22().Contains(@class))
				{
					this.method_22().Remove(@class);
				}
				this.method_40(@class);
			}
			this.method_41();
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000061E0 File Offset: 0x000043E0
		private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, null);
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000061F7 File Offset: 0x000043F7
		private void method_36(object sender, EventArgs e)
		{
			this.method_41();
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000061FF File Offset: 0x000043FF
		private void method_37(object sender, EventArgs e)
		{
			this.method_41();
			if (this.delegate9_0 != null)
			{
				this.delegate9_0(this, (Class127)sender);
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00006221 File Offset: 0x00004421
		private void method_38(object sender, EventArgs e)
		{
			this.method_41();
			if (this.delegate10_0 != null)
			{
				this.delegate10_0(this, (Class127)sender);
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0006BA2C File Offset: 0x00069C2C
		protected override void OnMouseMove(MouseEventArgs mea)
		{
			if (this.bool_3 && base.method_4() != this.point_1)
			{
				this.vmethod_0();
				this.method_58();
				return;
			}
			if (base.method_7() && this.class127_3 != null && !this.method_56(this.class127_3).Contains(base.method_4()))
			{
				this.class127_3 = null;
				base.Invalidate();
			}
			this.method_46();
			if (base.method_7())
			{
				this.method_58();
			}
			base.OnMouseMove(mea);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00006243 File Offset: 0x00004443
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			this.method_46();
			base.OnMouseWheel(e);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0006BAB8 File Offset: 0x00069CB8
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
			{
				foreach (Class127 class127_ in this.method_20())
				{
					this.method_49(class127_, base.method_4(), e.Button);
				}
			}
			base.OnMouseDown(e);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0006BB3C File Offset: 0x00069D3C
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			if (base.method_7())
			{
				this.method_59();
			}
			if (this.bool_3)
			{
				if (this.class127_2 != null)
				{
					Point right = this.point_1;
					if (base.method_4() == right)
					{
						this.method_51(this.class127_2);
					}
				}
				this.bool_3 = false;
			}
			base.OnMouseUp(mevent);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0006BB98 File Offset: 0x00069D98
		protected override void OnMouseDoubleClick(MouseEventArgs e)
		{
			if (Control.ModifierKeys == Keys.Control)
			{
				return;
			}
			if (e.Button == MouseButtons.Left)
			{
				foreach (Class127 class127_ in this.method_20())
				{
					this.method_50(class127_, base.method_4());
				}
			}
			base.OnMouseDoubleClick(e);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0006BC14 File Offset: 0x00069E14
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			foreach (Class127 class127_ in this.method_20())
			{
				this.method_47(class127_);
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0006BC70 File Offset: 0x00069E70
		protected override void OnKeyDown(KeyEventArgs ke)
		{
			base.OnKeyDown(ke);
			if (base.method_7())
			{
				return;
			}
			if (this.method_20().Count == 0)
			{
				return;
			}
			if (ke.KeyCode != Keys.Down && ke.KeyCode != Keys.Up && ke.KeyCode != Keys.Left && ke.KeyCode != Keys.Right)
			{
				return;
			}
			if (this.class127_1 == null)
			{
				if (this.method_20().Count > 0)
				{
					this.method_51(this.method_20()[0]);
				}
				return;
			}
			if (ke.KeyCode == Keys.Down || ke.KeyCode == Keys.Up)
			{
				if (this.method_25() && Control.ModifierKeys == Keys.Shift)
				{
					if (ke.KeyCode == Keys.Up)
					{
						if (this.class127_1.method_32() != null)
						{
							this.method_54(this.class127_1.method_32());
							this.method_57();
						}
					}
					else if (ke.KeyCode == Keys.Down && this.class127_1.method_34() != null)
					{
						this.method_54(this.class127_1.method_34());
						this.method_57();
					}
				}
				else if (ke.KeyCode == Keys.Up)
				{
					if (this.class127_1.method_32() != null)
					{
						this.method_51(this.class127_1.method_32());
						this.method_57();
					}
				}
				else if (ke.KeyCode == Keys.Down && this.class127_1.method_34() != null)
				{
					this.method_51(this.class127_1.method_34());
					this.method_57();
				}
			}
			if (ke.KeyCode == Keys.Left || ke.KeyCode == Keys.Right)
			{
				if (ke.KeyCode == Keys.Left)
				{
					if (this.class127_1.method_21() && this.class127_1.method_23().Count > 0)
					{
						this.class127_1.method_22(false);
						return;
					}
					if (this.class127_1.method_28() != null)
					{
						this.method_51(this.class127_1.method_28());
						this.method_57();
						return;
					}
				}
				else if (ke.KeyCode == Keys.Right)
				{
					if (!this.class127_1.method_21())
					{
						this.class127_1.method_22(true);
						return;
					}
					if (this.class127_1.method_23().Count > 0)
					{
						this.method_51(this.class127_1.method_23()[0]);
						this.method_57();
					}
				}
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0006BEA8 File Offset: 0x0006A0A8
		private void method_39(Class127 class127_4)
		{
			class127_4.method_23().method_0(new EventHandler<EventArgs5<Class127>>(this.method_34));
			class127_4.method_23().method_2(new EventHandler<EventArgs5<Class127>>(this.method_35));
			class127_4.method_0(new EventHandler(this.method_36));
			class127_4.method_2(new EventHandler(this.method_37));
			class127_4.method_4(new EventHandler(this.method_38));
			foreach (Class127 class127_5 in class127_4.method_23())
			{
				this.method_39(class127_5);
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0006BF60 File Offset: 0x0006A160
		private void method_40(Class127 class127_4)
		{
			class127_4.method_23().method_1(new EventHandler<EventArgs5<Class127>>(this.method_34));
			class127_4.method_23().method_3(new EventHandler<EventArgs5<Class127>>(this.method_35));
			class127_4.method_1(new EventHandler(this.method_36));
			class127_4.method_3(new EventHandler(this.method_37));
			class127_4.method_5(new EventHandler(this.method_38));
			foreach (Class127 class127_5 in class127_4.method_23())
			{
				this.method_40(class127_5);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0006C018 File Offset: 0x0006A218
		public void method_41()
		{
			if (base.method_7())
			{
				return;
			}
			if (this.method_20().Count == 0)
			{
				return;
			}
			int height = 0;
			bool flag = false;
			int int_ = 0;
			Class127 @class = null;
			base.method_3(new Size(0, 0));
			for (int i = 0; i <= this.method_20().Count - 1; i++)
			{
				Class127 class127_ = this.method_20()[i];
				this.method_42(class127_, ref @class, 0, ref height, ref flag, ref int_);
			}
			base.method_3(new Size(base.method_2().Width, height));
			this.method_30(int_);
			base.Invalidate();
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0006C0B8 File Offset: 0x0006A2B8
		private void method_42(Class127 class127_4, ref Class127 class127_5, int int_6, ref int int_7, ref bool bool_7, ref int int_8)
		{
			this.method_43(class127_4, int_7, int_6);
			int_7 += this.method_23();
			class127_4.method_31(bool_7);
			bool_7 = !bool_7;
			class127_4.method_37(int_8);
			int_8++;
			class127_4.method_33(class127_5);
			if (class127_5 != null)
			{
				class127_5.method_35(class127_4);
			}
			class127_5 = class127_4;
			if (class127_4.method_21())
			{
				foreach (Class127 class127_6 in class127_4.method_23())
				{
					this.method_42(class127_6, ref class127_5, int_6 + this.method_24(), ref int_7, ref bool_7, ref int_8);
				}
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0006C178 File Offset: 0x0006A378
		private void method_43(Class127 class127_4, int int_6, int int_7)
		{
			int y = int_6 + this.method_23() / 2 - this.int_1 / 2;
			class127_4.method_9(new Rectangle(int_7 + 3, y, this.int_1, this.int_1));
			int y2 = int_6 + this.method_23() / 2 - this.int_2 / 2;
			if (this.method_28())
			{
				class127_4.method_11(new Rectangle(class127_4.method_8().Right + 2, y2, this.int_2, this.int_2));
			}
			else
			{
				class127_4.method_11(new Rectangle(class127_4.method_8().Right, y2, 0, 0));
			}
			using (Graphics graphics = base.CreateGraphics())
			{
				int num = (int)((double)graphics.MeasureString(class127_4.method_6(), this.Font).Width * 1.5);
				class127_4.method_13(new Rectangle(class127_4.method_10().Right + 2, int_6, num + 1, this.method_23()));
			}
			class127_4.method_15(new Rectangle(int_7, int_6, class127_4.method_12().Right - int_7, this.method_23()));
			if (base.method_2().Width < class127_4.method_12().Right + 2)
			{
				base.method_3(new Size(class127_4.method_12().Right + 2, base.method_2().Height));
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0006C2F8 File Offset: 0x0006A4F8
		private void method_44()
		{
			this.method_45();
			this.bitmap_0 = Class106.smethod_0(Class99.smethod_1(), Class129.smethod_11());
			this.bitmap_1 = Class106.smethod_0(Class99.smethod_1(), Class129.smethod_13());
			this.bitmap_2 = Class106.smethod_0(Class99.smethod_2(), Class129.smethod_11());
			this.bitmap_3 = Class106.smethod_0(Class99.smethod_3(), Class129.smethod_11());
			this.bitmap_4 = Class106.smethod_0(Class99.smethod_3(), Class129.smethod_13());
			this.bitmap_5 = Class106.smethod_0(Class99.smethod_4(), Class129.smethod_11());
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0006C38C File Offset: 0x0006A58C
		private void method_45()
		{
			if (this.bitmap_0 != null)
			{
				this.bitmap_0.Dispose();
			}
			if (this.bitmap_1 != null)
			{
				this.bitmap_1.Dispose();
			}
			if (this.bitmap_2 != null)
			{
				this.bitmap_2.Dispose();
			}
			if (this.bitmap_3 != null)
			{
				this.bitmap_3.Dispose();
			}
			if (this.bitmap_4 != null)
			{
				this.bitmap_4.Dispose();
			}
			if (this.bitmap_5 != null)
			{
				this.bitmap_5.Dispose();
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0006C40C File Offset: 0x0006A60C
		private void method_46()
		{
			if (!base.ClientRectangle.Contains(base.PointToClient(Control.MousePosition)))
			{
				if (base.method_7() && this.class127_3 != null)
				{
					this.class127_3 = null;
					base.Invalidate();
				}
				return;
			}
			foreach (Class127 class127_ in this.method_20())
			{
				this.method_48(class127_, base.method_4());
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0006C4A0 File Offset: 0x0006A6A0
		private void method_47(Class127 class127_4)
		{
			class127_4.method_17(false);
			foreach (Class127 class127_5 in class127_4.method_23())
			{
				this.method_47(class127_5);
			}
			base.Invalidate();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0006C504 File Offset: 0x0006A704
		private void method_48(Class127 class127_4, Point point_2)
		{
			if (base.method_7())
			{
				if (this.method_56(class127_4).Contains(base.method_4()))
				{
					Class127 @class = this.list_0.Contains(class127_4) ? null : class127_4;
					if (this.class127_3 != @class)
					{
						this.class127_3 = @class;
						base.Invalidate();
					}
				}
			}
			else
			{
				bool flag = class127_4.method_8().Contains(point_2);
				if (class127_4.method_16() != flag)
				{
					class127_4.method_17(flag);
					base.Invalidate();
				}
			}
			foreach (Class127 class127_5 in class127_4.method_23())
			{
				this.method_48(class127_5, point_2);
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0006C5CC File Offset: 0x0006A7CC
		private void method_49(Class127 class127_4, Point point_2, MouseButtons mouseButtons_0)
		{
			if (this.method_56(class127_4).Contains(point_2))
			{
				if (class127_4.method_8().Contains(point_2))
				{
					if (mouseButtons_0 == MouseButtons.Left)
					{
						class127_4.method_22(!class127_4.method_21());
					}
				}
				else if (mouseButtons_0 == MouseButtons.Left)
				{
					if (this.method_25() && Control.ModifierKeys == Keys.Shift)
					{
						this.method_54(class127_4);
						return;
					}
					if (this.method_25() && Control.ModifierKeys == Keys.Control)
					{
						this.method_55(class127_4);
						return;
					}
					if (!this.method_22().Contains(class127_4))
					{
						this.method_51(class127_4);
					}
					this.point_1 = base.method_4();
					this.bool_3 = true;
					this.class127_2 = class127_4;
					return;
				}
				else if (mouseButtons_0 == MouseButtons.Right)
				{
					if (this.method_25() && Control.ModifierKeys == Keys.Shift)
					{
						return;
					}
					if (this.method_25() && Control.ModifierKeys == Keys.Control)
					{
						return;
					}
					if (!this.method_22().Contains(class127_4))
					{
						this.method_51(class127_4);
					}
					return;
				}
			}
			if (class127_4.method_21())
			{
				foreach (Class127 class127_5 in class127_4.method_23())
				{
					this.method_49(class127_5, point_2, mouseButtons_0);
				}
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0006C728 File Offset: 0x0006A928
		private void method_50(Class127 class127_4, Point point_2)
		{
			if (this.method_56(class127_4).Contains(point_2))
			{
				if (!class127_4.method_8().Contains(point_2))
				{
					class127_4.method_22(!class127_4.method_21());
				}
				return;
			}
			if (class127_4.method_21())
			{
				foreach (Class127 class127_5 in class127_4.method_23())
				{
					this.method_50(class127_5, point_2);
				}
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00006252 File Offset: 0x00004452
		public void method_51(Class127 class127_4)
		{
			this.observableCollection_0.Clear();
			this.observableCollection_0.Add(class127_4);
			this.class127_0 = class127_4;
			this.class127_1 = class127_4;
			base.Invalidate();
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0006C7B8 File Offset: 0x0006A9B8
		public void method_52(Class127 class127_4, Class127 class127_5)
		{
			List<Class127> list = new List<Class127>();
			if (class127_4 == class127_5)
			{
				list.Add(class127_4);
			}
			if (class127_4.method_36() < class127_5.method_36())
			{
				Class127 @class = class127_4;
				list.Add(@class);
				while (@class != class127_5 && @class != null)
				{
					@class = @class.method_34();
					list.Add(@class);
				}
			}
			else if (class127_4.method_36() > class127_5.method_36())
			{
				Class127 class2 = class127_4;
				list.Add(class2);
				while (class2 != class127_5 && class2 != null)
				{
					class2 = class2.method_32();
					list.Add(class2);
				}
			}
			this.method_53(list, false);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0006C840 File Offset: 0x0006AA40
		public void method_53(List<Class127> nodes, bool updateAnchors = true)
		{
			this.observableCollection_0.Clear();
			foreach (Class127 item in nodes)
			{
				this.observableCollection_0.Add(item);
			}
			if (updateAnchors && this.observableCollection_0.Count > 0)
			{
				this.class127_0 = this.observableCollection_0[this.observableCollection_0.Count - 1];
				this.class127_1 = this.observableCollection_0[this.observableCollection_0.Count - 1];
			}
			base.Invalidate();
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000627F File Offset: 0x0000447F
		private void method_54(Class127 class127_4)
		{
			this.class127_1 = class127_4;
			this.method_52(this.class127_0, this.class127_1);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0006C8F4 File Offset: 0x0006AAF4
		public void method_55(Class127 class127_4)
		{
			if (this.observableCollection_0.Contains(class127_4))
			{
				this.observableCollection_0.Remove(class127_4);
				if (this.class127_0 == class127_4 && this.class127_1 == class127_4)
				{
					if (this.observableCollection_0.Count > 0)
					{
						this.class127_0 = this.observableCollection_0[0];
						this.class127_1 = this.observableCollection_0[0];
					}
					else
					{
						this.class127_0 = null;
						this.class127_1 = null;
					}
				}
				if (this.class127_0 == class127_4)
				{
					if (this.class127_1.method_36() < class127_4.method_36())
					{
						this.class127_0 = class127_4.method_32();
					}
					else if (this.class127_1.method_36() > class127_4.method_36())
					{
						this.class127_0 = class127_4.method_34();
					}
					else
					{
						this.class127_0 = this.class127_1;
					}
				}
				if (this.class127_1 == class127_4)
				{
					if (this.class127_0.method_36() < class127_4.method_36())
					{
						this.class127_1 = class127_4.method_32();
					}
					else if (this.class127_0.method_36() > class127_4.method_36())
					{
						this.class127_1 = class127_4.method_34();
					}
					else
					{
						this.class127_1 = this.class127_0;
					}
				}
			}
			else
			{
				this.observableCollection_0.Add(class127_4);
				this.class127_0 = class127_4;
				this.class127_1 = class127_4;
			}
			base.Invalidate();
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0006CA44 File Offset: 0x0006AC44
		public Rectangle method_56(Class127 class127_4)
		{
			if (class127_4.method_28() != null && !class127_4.method_28().method_21())
			{
				return new Rectangle(-1, -1, -1, -1);
			}
			int width = Math.Max(base.method_2().Width, base.method_0().Width);
			return new Rectangle(0, class127_4.method_14().Top, width, this.method_23());
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0006CAB0 File Offset: 0x0006ACB0
		public void method_57()
		{
			if (this.method_22().Count == 0)
			{
				return;
			}
			foreach (Class127 @class in this.method_22())
			{
				@class.method_43();
			}
			int top;
			if (!this.method_25())
			{
				top = this.method_22()[0].method_14().Top;
			}
			else
			{
				top = this.class127_1.method_14().Top;
			}
			int num = top + this.method_23();
			if (top < base.method_0().Top)
			{
				base.method_13(top);
			}
			if (num > base.method_0().Bottom)
			{
				base.method_13(num - base.method_0().Height);
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0006CB8C File Offset: 0x0006AD8C
		protected override void vmethod_0()
		{
			if (!this.method_27())
			{
				this.bool_3 = false;
				return;
			}
			this.list_0 = new List<Class127>();
			foreach (Class127 item in this.method_22())
			{
				this.list_0.Add(item);
			}
			foreach (Class127 @class in Enumerable.ToList<Class127>(this.list_0))
			{
				if (@class.method_28() != null && this.list_0.Contains(@class.method_28()))
				{
					this.list_0.Remove(@class);
				}
			}
			this.bool_3 = false;
			this.Cursor = Cursors.SizeAll;
			base.vmethod_0();
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0006CC7C File Offset: 0x0006AE7C
		private void method_58()
		{
			if (!this.method_27())
			{
				return;
			}
			Class127 @class = this.class127_3;
			if (@class == null)
			{
				if (this.Cursor != Cursors.No)
				{
					this.Cursor = Cursors.No;
				}
				return;
			}
			if (this.vmethod_3(@class))
			{
				@class = @class.method_28();
			}
			if (!this.vmethod_4(this.list_0, @class, false))
			{
				if (this.Cursor != Cursors.No)
				{
					this.Cursor = Cursors.No;
				}
				return;
			}
			if (this.Cursor != Cursors.SizeAll)
			{
				this.Cursor = Cursors.SizeAll;
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0006CD18 File Offset: 0x0006AF18
		private void method_59()
		{
			if (!this.method_27())
			{
				return;
			}
			Class127 @class = this.class127_3;
			if (@class == null)
			{
				this.vmethod_1();
				return;
			}
			if (this.vmethod_3(@class))
			{
				@class = @class.method_28();
			}
			if (this.vmethod_4(this.list_0, @class, true))
			{
				List<Class127> list = Enumerable.ToList<Class127>(this.method_22());
				this.vmethod_5(this.list_0, @class);
				foreach (Class127 class2 in this.list_0)
				{
					if (class2.method_28() == null)
					{
						this.method_20().method_6(class2);
					}
					else
					{
						class2.method_28().method_23().method_6(class2);
					}
					@class.method_23().method_4(class2);
				}
				if (this.method_31() != null)
				{
					@class.method_23().Sort(this.method_31());
				}
				@class.method_22(true);
				this.vmethod_6(this.list_0);
				foreach (Class127 item in list)
				{
					this.observableCollection_0.Add(item);
				}
			}
			this.vmethod_1();
			this.method_41();
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000629A File Offset: 0x0000449A
		protected override void vmethod_1()
		{
			this.list_0 = null;
			this.class127_3 = null;
			this.Cursor = Cursors.Default;
			base.Invalidate();
			base.vmethod_1();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00003024 File Offset: 0x00001224
		protected bool vmethod_3(Class127 class127_4)
		{
			return false;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0006CE6C File Offset: 0x0006B06C
		protected bool vmethod_4(List<Class127> dragNodes, Class127 dropNode, bool isMoving = false)
		{
			if (dropNode == null)
			{
				return false;
			}
			foreach (Class127 @class in dragNodes)
			{
				if (@class == dropNode)
				{
					if (isMoving)
					{
						DarkMessageBox.smethod_2("Cannot move " + @class.method_6() + ". The destination folder is the same as the source folder.", Application.ProductName, Enum11.const_0);
					}
					return false;
				}
				if (@class.method_28() != null && @class.method_28() == dropNode)
				{
					if (isMoving)
					{
						DarkMessageBox.smethod_2("Cannot move " + @class.method_6() + ". The destination folder is the same as the source folder.", Application.ProductName, Enum11.const_0);
					}
					return false;
				}
				for (Class127 class2 = dropNode.method_28(); class2 != null; class2 = class2.method_28())
				{
					if (@class == class2)
					{
						if (isMoving)
						{
							DarkMessageBox.smethod_2("Cannot move " + @class.method_6() + ". The destination folder is a subfolder of the source folder.", Application.ProductName, Enum11.const_0);
						}
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000378C File Offset: 0x0000198C
		protected void vmethod_5(List<Class127> list_1, Class127 class127_4)
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0000378C File Offset: 0x0000198C
		protected void vmethod_6(List<Class127> list_1)
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0006CF6C File Offset: 0x0006B16C
		protected override void vmethod_2(Graphics graphics_0)
		{
			foreach (Class127 class127_ in this.method_20())
			{
				this.method_60(class127_, graphics_0);
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0006CFC4 File Offset: 0x0006B1C4
		private void method_60(Class127 class127_4, Graphics graphics_0)
		{
			Rectangle rect = this.method_56(class127_4);
			Color color = class127_4.method_30() ? Class129.smethod_1() : Class129.smethod_0();
			if (this.method_22().Count > 0 && this.method_22().Contains(class127_4))
			{
				color = (this.Focused ? Class129.smethod_14() : Class129.smethod_16());
			}
			if (base.method_7() && this.class127_3 == class127_4)
			{
				color = (this.Focused ? Class129.smethod_14() : Class129.smethod_16());
			}
			using (SolidBrush solidBrush = new SolidBrush(color))
			{
				graphics_0.FillRectangle(solidBrush, rect);
			}
			if (class127_4.method_23().Count > 0)
			{
				Point point = new Point(class127_4.method_8().Location.X - 1, class127_4.method_8().Location.Y - 1);
				Bitmap image = this.bitmap_3;
				if (class127_4.method_21() && !class127_4.method_16())
				{
					image = this.bitmap_3;
				}
				else if (class127_4.method_21() && class127_4.method_16() && !this.method_22().Contains(class127_4))
				{
					image = this.bitmap_4;
				}
				else if (class127_4.method_21() && class127_4.method_16() && this.method_22().Contains(class127_4))
				{
					image = this.bitmap_5;
				}
				else if (!class127_4.method_21() && !class127_4.method_16())
				{
					image = this.bitmap_0;
				}
				else if (!class127_4.method_21() && class127_4.method_16() && !this.method_22().Contains(class127_4))
				{
					image = this.bitmap_1;
				}
				else if (!class127_4.method_21() && class127_4.method_16() && this.method_22().Contains(class127_4))
				{
					image = this.bitmap_2;
				}
				graphics_0.DrawImageUnscaled(image, point);
			}
			if (this.method_28() && class127_4.method_18() != null)
			{
				if (class127_4.method_21() && class127_4.method_20() != null)
				{
					graphics_0.DrawImageUnscaled(class127_4.method_20(), class127_4.method_10().Location);
				}
				else
				{
					graphics_0.DrawImageUnscaled(class127_4.method_18(), class127_4.method_10().Location);
				}
			}
			graphics_0.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			using (SolidBrush solidBrush2 = new SolidBrush(class127_4.method_38()))
			{
				StringFormat format = new StringFormat
				{
					Alignment = StringAlignment.Near,
					LineAlignment = StringAlignment.Center
				};
				if (class127_4.method_40() == null)
				{
					graphics_0.DrawString(class127_4.method_6(), this.Font, solidBrush2, class127_4.method_12(), format);
				}
				else
				{
					graphics_0.DrawString(class127_4.method_6(), class127_4.method_40(), solidBrush2, class127_4.method_12(), format);
				}
			}
			if (class127_4.method_21())
			{
				foreach (Class127 class127_5 in class127_4.method_23())
				{
					this.method_60(class127_5, graphics_0);
				}
			}
		}

		// Token: 0x040003D6 RID: 982
		[CompilerGenerated]
		private EventHandler eventHandler_2;

		// Token: 0x040003D7 RID: 983
		[CompilerGenerated]
		private Control6.Delegate9 delegate9_0;

		// Token: 0x040003D8 RID: 984
		[CompilerGenerated]
		private Control6.Delegate10 delegate10_0;

		// Token: 0x040003D9 RID: 985
		private bool bool_2;

		// Token: 0x040003DA RID: 986
		private readonly int int_1 = 16;

		// Token: 0x040003DB RID: 987
		private readonly int int_2 = 16;

		// Token: 0x040003DC RID: 988
		private int int_3 = 20;

		// Token: 0x040003DD RID: 989
		private int int_4 = 20;

		// Token: 0x040003DE RID: 990
		private ObservableList<Class127> observableList_0;

		// Token: 0x040003DF RID: 991
		private ObservableCollection<Class127> observableCollection_0;

		// Token: 0x040003E0 RID: 992
		private Class127 class127_0;

		// Token: 0x040003E1 RID: 993
		private Class127 class127_1;

		// Token: 0x040003E2 RID: 994
		private Bitmap bitmap_0;

		// Token: 0x040003E3 RID: 995
		private Bitmap bitmap_1;

		// Token: 0x040003E4 RID: 996
		private Bitmap bitmap_2;

		// Token: 0x040003E5 RID: 997
		private Bitmap bitmap_3;

		// Token: 0x040003E6 RID: 998
		private Bitmap bitmap_4;

		// Token: 0x040003E7 RID: 999
		private Bitmap bitmap_5;

		// Token: 0x040003E8 RID: 1000
		private Class127 class127_2;

		// Token: 0x040003E9 RID: 1001
		private Class127 class127_3;

		// Token: 0x040003EA RID: 1002
		private bool bool_3;

		// Token: 0x040003EB RID: 1003
		private List<Class127> list_0;

		// Token: 0x040003EC RID: 1004
		private Point point_1;

		// Token: 0x040003ED RID: 1005
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x040003EE RID: 1006
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x040003EF RID: 1007
		[CompilerGenerated]
		private bool bool_6;

		// Token: 0x040003F0 RID: 1008
		[CompilerGenerated]
		private int int_5;

		// Token: 0x040003F1 RID: 1009
		[CompilerGenerated]
		private IComparer<Class127> icomparer_0;

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x060005B1 RID: 1457
		internal delegate void Delegate9(Control6 tree, Class127 Node);

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x060005B5 RID: 1461
		internal delegate void Delegate10(Control6 tree, Class127 Node);
	}
}
