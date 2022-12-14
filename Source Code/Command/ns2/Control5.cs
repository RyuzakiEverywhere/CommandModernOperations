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
	// Token: 0x020000D9 RID: 217
	internal sealed class Control5 : Control3
	{
		// Token: 0x0600052E RID: 1326 RVA: 0x00006046 File Offset: 0x00004246
		public void method_16(string string_1)
		{
			this.string_0 = string_1;
			this.method_38();
			base.Invalidate();
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00069860 File Offset: 0x00067A60
		[CompilerGenerated]
		public void method_17(EventHandler eventHandler_3)
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

		// Token: 0x06000530 RID: 1328 RVA: 0x00069898 File Offset: 0x00067A98
		[CompilerGenerated]
		public void method_18(EventHandler eventHandler_3)
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

		// Token: 0x06000531 RID: 1329 RVA: 0x0000605B File Offset: 0x0000425B
		public ObservableList<Class126> method_19()
		{
			return this.observableList_0;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000698D0 File Offset: 0x00067AD0
		public void method_20(ObservableList<Class126> observableList_1)
		{
			if (this.observableList_0 != null)
			{
				this.observableList_0.method_1(new EventHandler<EventArgs5<Class126>>(this.method_29));
				this.observableList_0.method_3(new EventHandler<EventArgs5<Class126>>(this.method_30));
				foreach (Class126 class126_ in this.observableList_0)
				{
					this.method_37(class126_);
				}
			}
			this.observableList_0 = observableList_1;
			this.observableList_0.method_0(new EventHandler<EventArgs5<Class126>>(this.method_29));
			this.observableList_0.method_2(new EventHandler<EventArgs5<Class126>>(this.method_30));
			foreach (Class126 class126_2 in this.observableList_0)
			{
				this.method_36(class126_2);
			}
			this.method_38();
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00006063 File Offset: 0x00004263
		public ObservableCollection<Class126> method_21()
		{
			return this.observableCollection_0;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0000606B File Offset: 0x0000426B
		public int method_22()
		{
			return this.int_3;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00006073 File Offset: 0x00004273
		public int method_23()
		{
			return this.int_4;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0000607B File Offset: 0x0000427B
		[CompilerGenerated]
		public bool method_24()
		{
			return this.bool_4;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00006083 File Offset: 0x00004283
		[CompilerGenerated]
		public bool method_25()
		{
			return this.bool_5;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0000608B File Offset: 0x0000428B
		[CompilerGenerated]
		public bool method_26()
		{
			return this.bool_6;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00006093 File Offset: 0x00004293
		[CompilerGenerated]
		private void method_27(int int_6)
		{
			this.int_5 = int_6;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000609C File Offset: 0x0000429C
		[CompilerGenerated]
		public IComparer<Class126> method_28()
		{
			return this.icomparer_0;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000699D8 File Offset: 0x00067BD8
		public Control5()
		{
			this.method_20(new ObservableList<Class126>());
			this.observableCollection_0 = new ObservableCollection<Class126>();
			this.observableCollection_0.CollectionChanged += new NotifyCollectionChangedEventHandler(this.observableCollection_0_CollectionChanged);
			base.method_6(this.int_3);
			this.method_41();
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00069A4C File Offset: 0x00067C4C
		protected override void Dispose(bool disposing)
		{
			if (!this.bool_2)
			{
				this.method_42();
				if (this.eventHandler_2 != null)
				{
					this.eventHandler_2 = null;
				}
				if (this.delegate7_0 != null)
				{
					this.delegate7_0 = null;
				}
				if (this.delegate8_0 != null)
				{
					this.delegate7_0 = null;
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

		// Token: 0x0600053D RID: 1341 RVA: 0x00069AD4 File Offset: 0x00067CD4
		private void method_29(object sender, EventArgs5<Class126> e)
		{
			foreach (Class126 @class in e.method_0())
			{
				@class.method_26(this);
				@class.method_24(true);
				this.method_36(@class);
			}
			if (this.method_28() != null)
			{
				this.method_19().Sort(this.method_28());
			}
			this.method_38();
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00069B50 File Offset: 0x00067D50
		private void method_30(object sender, EventArgs5<Class126> e)
		{
			foreach (Class126 @class in e.method_0())
			{
				@class.method_26(this);
				@class.method_24(true);
				this.method_36(@class);
			}
			this.method_38();
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00069BB4 File Offset: 0x00067DB4
		private void method_31(object sender, EventArgs5<Class126> e)
		{
			foreach (Class126 class126_ in e.method_0())
			{
				this.method_36(class126_);
			}
			this.method_38();
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00069C08 File Offset: 0x00067E08
		private void method_32(object sender, EventArgs5<Class126> e)
		{
			foreach (Class126 @class in e.method_0())
			{
				if (this.method_21().Contains(@class))
				{
					this.method_21().Remove(@class);
				}
				this.method_37(@class);
			}
			this.method_38();
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000060A4 File Offset: 0x000042A4
		private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, null);
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000060BB File Offset: 0x000042BB
		private void method_33(object sender, EventArgs e)
		{
			this.method_38();
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000060C3 File Offset: 0x000042C3
		private void method_34(object sender, EventArgs e)
		{
			this.method_38();
			if (this.delegate7_0 != null)
			{
				this.delegate7_0(this, (Class126)sender);
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000060E5 File Offset: 0x000042E5
		private void method_35(object sender, EventArgs e)
		{
			this.method_38();
			if (this.delegate8_0 != null)
			{
				this.delegate8_0(this, (Class126)sender);
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00069C78 File Offset: 0x00067E78
		protected override void OnMouseMove(MouseEventArgs mea)
		{
			if (this.bool_3 && base.method_4() != this.point_1)
			{
				this.vmethod_0();
				this.method_55();
				return;
			}
			if (base.method_7() && this.class126_3 != null && !this.method_53(this.class126_3).Contains(base.method_4()))
			{
				this.class126_3 = null;
				base.Invalidate();
			}
			this.method_43();
			if (base.method_7())
			{
				this.method_55();
			}
			base.OnMouseMove(mea);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00006107 File Offset: 0x00004307
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			this.method_43();
			base.OnMouseWheel(e);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00069D04 File Offset: 0x00067F04
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
			{
				foreach (Class126 class126_ in this.method_19())
				{
					this.method_46(class126_, base.method_4(), e.Button);
				}
			}
			base.OnMouseDown(e);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00069D88 File Offset: 0x00067F88
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			if (base.method_7())
			{
				this.method_56();
			}
			if (this.bool_3)
			{
				if (this.class126_2 != null)
				{
					Point right = this.point_1;
					if (base.method_4() == right)
					{
						this.method_48(this.class126_2);
					}
				}
				this.bool_3 = false;
			}
			base.OnMouseUp(mevent);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00069DE4 File Offset: 0x00067FE4
		protected override void OnMouseDoubleClick(MouseEventArgs e)
		{
			if (Control.ModifierKeys == Keys.Control)
			{
				return;
			}
			if (e.Button == MouseButtons.Left)
			{
				foreach (Class126 class126_ in this.method_19())
				{
					this.method_47(class126_, base.method_4());
				}
			}
			base.OnMouseDoubleClick(e);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00069E60 File Offset: 0x00068060
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			foreach (Class126 class126_ in this.method_19())
			{
				this.method_44(class126_);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00069EBC File Offset: 0x000680BC
		protected override void OnKeyDown(KeyEventArgs ke)
		{
			base.OnKeyDown(ke);
			if (base.method_7())
			{
				return;
			}
			if (this.method_19().Count == 0)
			{
				return;
			}
			if (ke.KeyCode != Keys.Down && ke.KeyCode != Keys.Up && ke.KeyCode != Keys.Left && ke.KeyCode != Keys.Right)
			{
				return;
			}
			if (this.class126_1 == null)
			{
				if (this.method_19().Count > 0)
				{
					this.method_48(this.method_19()[0]);
				}
				return;
			}
			if (ke.KeyCode == Keys.Down || ke.KeyCode == Keys.Up)
			{
				if (this.method_24() && Control.ModifierKeys == Keys.Shift)
				{
					if (ke.KeyCode == Keys.Up)
					{
						if (this.class126_1.method_31() != null)
						{
							this.method_51(this.class126_1.method_31());
							this.method_54();
						}
					}
					else if (ke.KeyCode == Keys.Down && this.class126_1.method_33() != null)
					{
						this.method_51(this.class126_1.method_33());
						this.method_54();
					}
				}
				else if (ke.KeyCode == Keys.Up)
				{
					if (this.class126_1.method_31() != null)
					{
						this.method_48(this.class126_1.method_31());
						this.method_54();
					}
				}
				else if (ke.KeyCode == Keys.Down && this.class126_1.method_33() != null)
				{
					this.method_48(this.class126_1.method_33());
					this.method_54();
				}
			}
			if (ke.KeyCode == Keys.Left || ke.KeyCode == Keys.Right)
			{
				if (ke.KeyCode == Keys.Left)
				{
					if (this.class126_1.method_20() && this.class126_1.method_22().Count > 0)
					{
						this.class126_1.method_21(false);
						return;
					}
					if (this.class126_1.method_27() != null)
					{
						this.method_48(this.class126_1.method_27());
						this.method_54();
						return;
					}
				}
				else if (ke.KeyCode == Keys.Right)
				{
					if (!this.class126_1.method_20())
					{
						this.class126_1.method_21(true);
						return;
					}
					if (this.class126_1.method_22().Count > 0)
					{
						this.method_48(this.class126_1.method_22()[0]);
						this.method_54();
					}
				}
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0006A0F4 File Offset: 0x000682F4
		private void method_36(Class126 class126_4)
		{
			class126_4.method_22().method_0(new EventHandler<EventArgs5<Class126>>(this.method_31));
			class126_4.method_22().method_2(new EventHandler<EventArgs5<Class126>>(this.method_32));
			class126_4.method_0(new EventHandler(this.method_33));
			class126_4.method_2(new EventHandler(this.method_34));
			class126_4.method_4(new EventHandler(this.method_35));
			foreach (Class126 class126_5 in class126_4.method_22())
			{
				this.method_36(class126_5);
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0006A1AC File Offset: 0x000683AC
		private void method_37(Class126 class126_4)
		{
			class126_4.method_22().method_1(new EventHandler<EventArgs5<Class126>>(this.method_31));
			class126_4.method_22().method_3(new EventHandler<EventArgs5<Class126>>(this.method_32));
			class126_4.method_1(new EventHandler(this.method_33));
			class126_4.method_3(new EventHandler(this.method_34));
			class126_4.method_5(new EventHandler(this.method_35));
			foreach (Class126 class126_5 in class126_4.method_22())
			{
				this.method_37(class126_5);
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0006A264 File Offset: 0x00068464
		public void method_38()
		{
			Dictionary<Class126, bool> dictionary_ = new Dictionary<Class126, bool>();
			if (base.method_7())
			{
				return;
			}
			if (this.method_19().Count == 0)
			{
				return;
			}
			int height = 0;
			bool flag = false;
			int int_ = 0;
			Class126 @class = null;
			base.method_3(new Size(0, 0));
			for (int i = 0; i <= this.method_19().Count - 1; i++)
			{
				Class126 class126_ = this.method_19()[i];
				this.method_39(class126_, ref @class, 0, ref height, ref flag, ref int_, dictionary_);
			}
			base.method_3(new Size(base.method_2().Width, height));
			this.method_27(int_);
			base.Invalidate();
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0006A30C File Offset: 0x0006850C
		private void method_39(Class126 class126_4, ref Class126 class126_5, int int_6, ref int int_7, ref bool bool_7, ref int int_8, Dictionary<Class126, bool> dictionary_0)
		{
			this.method_40(class126_4, int_7, int_6);
			int_7 += this.method_22();
			class126_4.method_30(bool_7);
			bool_7 = !bool_7;
			class126_4.method_36(int_8);
			int_8++;
			class126_4.method_32(class126_5);
			if (class126_5 != null)
			{
				class126_5.method_34(class126_4);
			}
			class126_5 = class126_4;
			if (class126_4.method_20())
			{
				foreach (Class126 class126_6 in class126_4.method_22())
				{
					this.method_39(class126_6, ref class126_5, int_6 + this.method_23(), ref int_7, ref bool_7, ref int_8, dictionary_0);
				}
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0006A3CC File Offset: 0x000685CC
		private void method_40(Class126 class126_4, int int_6, int int_7)
		{
			int y = int_6 + this.method_22() / 2 - this.int_1 / 2;
			class126_4.method_9(new Rectangle(int_7 + 3, y, this.int_1, this.int_1));
			int y2 = int_6 + this.method_22() / 2 - this.int_2 / 2;
			if (this.method_26())
			{
				class126_4.method_11(new Rectangle(class126_4.method_8().Right + 2, y2, this.int_2, this.int_2));
			}
			else
			{
				class126_4.method_11(new Rectangle(class126_4.method_8().Right, y2, 0, 0));
			}
			using (Graphics graphics = base.CreateGraphics())
			{
				int num = (int)((double)graphics.MeasureString(class126_4.method_6(), this.Font).Width * 1.5);
				class126_4.method_13(new Rectangle(class126_4.method_10().Right + 2, int_6, num + 1, this.method_22()));
			}
			class126_4.method_15(new Rectangle(int_7, int_6, class126_4.method_12().Right - int_7, this.method_22()));
			if (base.method_2().Width < class126_4.method_12().Right + 2)
			{
				base.method_3(new Size(class126_4.method_12().Right + 2, base.method_2().Height));
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0006A54C File Offset: 0x0006874C
		private void method_41()
		{
			this.method_42();
			this.bitmap_0 = Class106.smethod_0(Class99.smethod_1(), Class129.smethod_11());
			this.bitmap_1 = Class106.smethod_0(Class99.smethod_1(), Class129.smethod_13());
			this.bitmap_2 = Class106.smethod_0(Class99.smethod_2(), Class129.smethod_11());
			this.bitmap_3 = Class106.smethod_0(Class99.smethod_3(), Class129.smethod_11());
			this.bitmap_4 = Class106.smethod_0(Class99.smethod_3(), Class129.smethod_13());
			this.bitmap_5 = Class106.smethod_0(Class99.smethod_4(), Class129.smethod_11());
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0006A5E0 File Offset: 0x000687E0
		private void method_42()
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

		// Token: 0x06000553 RID: 1363 RVA: 0x0006A660 File Offset: 0x00068860
		private void method_43()
		{
			if (!base.ClientRectangle.Contains(base.PointToClient(Control.MousePosition)))
			{
				if (base.method_7() && this.class126_3 != null)
				{
					this.class126_3 = null;
					base.Invalidate();
				}
				return;
			}
			foreach (Class126 class126_ in this.method_19())
			{
				this.method_45(class126_, base.method_4());
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0006A6F4 File Offset: 0x000688F4
		private void method_44(Class126 class126_4)
		{
			class126_4.method_17(false);
			foreach (Class126 class126_5 in class126_4.method_22())
			{
				this.method_44(class126_5);
			}
			base.Invalidate();
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0006A758 File Offset: 0x00068958
		private void method_45(Class126 class126_4, Point point_2)
		{
			if (base.method_7())
			{
				if (this.method_53(class126_4).Contains(base.method_4()))
				{
					Class126 @class = this.list_0.Contains(class126_4) ? null : class126_4;
					if (this.class126_3 != @class)
					{
						this.class126_3 = @class;
						base.Invalidate();
					}
				}
			}
			else
			{
				bool flag = class126_4.method_8().Contains(point_2);
				if (class126_4.method_16() != flag)
				{
					class126_4.method_17(flag);
					base.Invalidate();
				}
			}
			foreach (Class126 class126_5 in class126_4.method_22())
			{
				this.method_45(class126_5, point_2);
			}
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0006A820 File Offset: 0x00068A20
		private void method_46(Class126 class126_4, Point point_2, MouseButtons mouseButtons_0)
		{
			if (this.method_53(class126_4).Contains(point_2))
			{
				if (class126_4.method_8().Contains(point_2))
				{
					if (mouseButtons_0 == MouseButtons.Left)
					{
						class126_4.method_21(!class126_4.method_20());
					}
				}
				else if (mouseButtons_0 == MouseButtons.Left)
				{
					if (this.method_24() && Control.ModifierKeys == Keys.Shift)
					{
						this.method_51(class126_4);
						return;
					}
					if (this.method_24() && Control.ModifierKeys == Keys.Control)
					{
						this.method_52(class126_4);
						return;
					}
					if (!this.method_21().Contains(class126_4))
					{
						this.method_48(class126_4);
					}
					this.point_1 = base.method_4();
					this.bool_3 = true;
					this.class126_2 = class126_4;
					return;
				}
				else if (mouseButtons_0 == MouseButtons.Right)
				{
					if (this.method_24() && Control.ModifierKeys == Keys.Shift)
					{
						return;
					}
					if (this.method_24() && Control.ModifierKeys == Keys.Control)
					{
						return;
					}
					if (!this.method_21().Contains(class126_4))
					{
						this.method_48(class126_4);
					}
					return;
				}
			}
			if (class126_4.method_20())
			{
				foreach (Class126 class126_5 in class126_4.method_22())
				{
					this.method_46(class126_5, point_2, mouseButtons_0);
				}
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0006A97C File Offset: 0x00068B7C
		private void method_47(Class126 class126_4, Point point_2)
		{
			if (this.method_53(class126_4).Contains(point_2))
			{
				if (!class126_4.method_8().Contains(point_2))
				{
					class126_4.method_21(!class126_4.method_20());
				}
				return;
			}
			if (class126_4.method_20())
			{
				foreach (Class126 class126_5 in class126_4.method_22())
				{
					this.method_47(class126_5, point_2);
				}
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00006116 File Offset: 0x00004316
		public void method_48(Class126 class126_4)
		{
			this.observableCollection_0.Clear();
			this.observableCollection_0.Add(class126_4);
			this.class126_0 = class126_4;
			this.class126_1 = class126_4;
			base.Invalidate();
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0006AA0C File Offset: 0x00068C0C
		public void method_49(Class126 class126_4, Class126 class126_5)
		{
			List<Class126> list = new List<Class126>();
			if (class126_4 == class126_5)
			{
				list.Add(class126_4);
			}
			if (class126_4.method_35() < class126_5.method_35())
			{
				Class126 @class = class126_4;
				list.Add(@class);
				while (@class != class126_5 && @class != null)
				{
					@class = @class.method_33();
					list.Add(@class);
				}
			}
			else if (class126_4.method_35() > class126_5.method_35())
			{
				Class126 class2 = class126_4;
				list.Add(class2);
				while (class2 != class126_5 && class2 != null)
				{
					class2 = class2.method_31();
					list.Add(class2);
				}
			}
			this.method_50(list, false);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0006AA94 File Offset: 0x00068C94
		public void method_50(List<Class126> nodes, bool updateAnchors = true)
		{
			this.observableCollection_0.Clear();
			foreach (Class126 item in nodes)
			{
				this.observableCollection_0.Add(item);
			}
			if (updateAnchors && this.observableCollection_0.Count > 0)
			{
				this.class126_0 = this.observableCollection_0[this.observableCollection_0.Count - 1];
				this.class126_1 = this.observableCollection_0[this.observableCollection_0.Count - 1];
			}
			base.Invalidate();
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00006143 File Offset: 0x00004343
		private void method_51(Class126 class126_4)
		{
			this.class126_1 = class126_4;
			this.method_49(this.class126_0, this.class126_1);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0006AB48 File Offset: 0x00068D48
		public void method_52(Class126 class126_4)
		{
			if (this.observableCollection_0.Contains(class126_4))
			{
				this.observableCollection_0.Remove(class126_4);
				if (this.class126_0 == class126_4 && this.class126_1 == class126_4)
				{
					if (this.observableCollection_0.Count > 0)
					{
						this.class126_0 = this.observableCollection_0[0];
						this.class126_1 = this.observableCollection_0[0];
					}
					else
					{
						this.class126_0 = null;
						this.class126_1 = null;
					}
				}
				if (this.class126_0 == class126_4)
				{
					if (this.class126_1.method_35() < class126_4.method_35())
					{
						this.class126_0 = class126_4.method_31();
					}
					else if (this.class126_1.method_35() > class126_4.method_35())
					{
						this.class126_0 = class126_4.method_33();
					}
					else
					{
						this.class126_0 = this.class126_1;
					}
				}
				if (this.class126_1 == class126_4)
				{
					if (this.class126_0.method_35() < class126_4.method_35())
					{
						this.class126_1 = class126_4.method_31();
					}
					else if (this.class126_0.method_35() > class126_4.method_35())
					{
						this.class126_1 = class126_4.method_33();
					}
					else
					{
						this.class126_1 = this.class126_0;
					}
				}
			}
			else
			{
				this.observableCollection_0.Add(class126_4);
				this.class126_0 = class126_4;
				this.class126_1 = class126_4;
			}
			base.Invalidate();
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0006AC98 File Offset: 0x00068E98
		public Rectangle method_53(Class126 class126_4)
		{
			if (class126_4.method_27() != null && !class126_4.method_27().method_20())
			{
				return new Rectangle(-1, -1, -1, -1);
			}
			int width = Math.Max(base.method_2().Width, base.method_0().Width);
			return new Rectangle(0, class126_4.method_14().Top, width, this.method_22());
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0006AD04 File Offset: 0x00068F04
		public void method_54()
		{
			if (this.method_21().Count == 0)
			{
				return;
			}
			foreach (Class126 @class in this.method_21())
			{
				@class.method_41();
			}
			int top;
			if (!this.method_24())
			{
				top = this.method_21()[0].method_14().Top;
			}
			else
			{
				top = this.class126_1.method_14().Top;
			}
			int num = top + this.method_22();
			if (top < base.method_0().Top)
			{
				base.method_13(top);
			}
			if (num > base.method_0().Bottom)
			{
				base.method_13(num - base.method_0().Height);
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0006ADE0 File Offset: 0x00068FE0
		protected override void vmethod_0()
		{
			if (!this.method_25())
			{
				this.bool_3 = false;
				return;
			}
			this.list_0 = new List<Class126>();
			foreach (Class126 item in this.method_21())
			{
				this.list_0.Add(item);
			}
			foreach (Class126 @class in Enumerable.ToList<Class126>(this.list_0))
			{
				if (@class.method_27() != null && this.list_0.Contains(@class.method_27()))
				{
					this.list_0.Remove(@class);
				}
			}
			this.bool_3 = false;
			this.Cursor = Cursors.SizeAll;
			base.vmethod_0();
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0006AED0 File Offset: 0x000690D0
		private void method_55()
		{
			if (!this.method_25())
			{
				return;
			}
			Class126 @class = this.class126_3;
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
				@class = @class.method_27();
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

		// Token: 0x06000561 RID: 1377 RVA: 0x0006AF6C File Offset: 0x0006916C
		private void method_56()
		{
			if (!this.method_25())
			{
				return;
			}
			Class126 @class = this.class126_3;
			if (@class == null)
			{
				this.vmethod_1();
				return;
			}
			if (this.vmethod_3(@class))
			{
				@class = @class.method_27();
			}
			if (this.vmethod_4(this.list_0, @class, true))
			{
				List<Class126> list = Enumerable.ToList<Class126>(this.method_21());
				this.vmethod_5(this.list_0, @class);
				foreach (Class126 class2 in this.list_0)
				{
					if (class2.method_27() == null)
					{
						this.method_19().method_6(class2);
					}
					else
					{
						class2.method_27().method_22().method_6(class2);
					}
					@class.method_22().method_4(class2);
				}
				if (this.method_28() != null)
				{
					@class.method_22().Sort(this.method_28());
				}
				@class.method_21(true);
				this.vmethod_6(this.list_0);
				foreach (Class126 item in list)
				{
					this.observableCollection_0.Add(item);
				}
			}
			this.vmethod_1();
			this.method_38();
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0000615E File Offset: 0x0000435E
		protected override void vmethod_1()
		{
			this.list_0 = null;
			this.class126_3 = null;
			this.Cursor = Cursors.Default;
			base.Invalidate();
			base.vmethod_1();
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00003024 File Offset: 0x00001224
		protected bool vmethod_3(Class126 class126_4)
		{
			return false;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0006B0C0 File Offset: 0x000692C0
		protected bool vmethod_4(List<Class126> dragNodes, Class126 dropNode, bool isMoving = false)
		{
			if (dropNode == null)
			{
				return false;
			}
			foreach (Class126 @class in dragNodes)
			{
				if (@class == dropNode)
				{
					if (isMoving)
					{
						DarkMessageBox.smethod_2("Cannot move " + @class.method_6() + ". The destination folder is the same as the source folder.", Application.ProductName, Enum11.const_0);
					}
					return false;
				}
				if (@class.method_27() != null && @class.method_27() == dropNode)
				{
					if (isMoving)
					{
						DarkMessageBox.smethod_2("Cannot move " + @class.method_6() + ". The destination folder is the same as the source folder.", Application.ProductName, Enum11.const_0);
					}
					return false;
				}
				for (Class126 class2 = dropNode.method_27(); class2 != null; class2 = class2.method_27())
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

		// Token: 0x06000565 RID: 1381 RVA: 0x0000378C File Offset: 0x0000198C
		protected void vmethod_5(List<Class126> list_1, Class126 class126_4)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0000378C File Offset: 0x0000198C
		protected void vmethod_6(List<Class126> list_1)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0006B1C0 File Offset: 0x000693C0
		protected override void vmethod_2(Graphics graphics_0)
		{
			Dictionary<Class126, bool> dictionary_ = new Dictionary<Class126, bool>();
			foreach (Class126 class126_ in this.method_19())
			{
				this.method_58(class126_, graphics_0, dictionary_);
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0006B21C File Offset: 0x0006941C
		private bool method_57(Class126 class126_4, Dictionary<Class126, bool> dictionary_0)
		{
			if (string.IsNullOrWhiteSpace(this.string_0))
			{
				return false;
			}
			if (dictionary_0.ContainsKey(class126_4))
			{
				return dictionary_0[class126_4];
			}
			if (class126_4.method_6().ToLower().Contains(this.string_0.ToLower()))
			{
				dictionary_0[class126_4] = true;
				return true;
			}
			dictionary_0[class126_4] = false;
			return false;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0006B27C File Offset: 0x0006947C
		private void method_58(Class126 class126_4, Graphics graphics_0, Dictionary<Class126, bool> dictionary_0)
		{
			bool flag = this.method_57(class126_4, dictionary_0);
			Rectangle rect = this.method_53(class126_4);
			Color color = class126_4.method_29() ? Class129.smethod_1() : Class129.smethod_0();
			if (this.method_21().Count > 0 && this.method_21().Contains(class126_4))
			{
				color = (this.Focused ? Class129.smethod_14() : Class129.smethod_16());
			}
			if (base.method_7() && this.class126_3 == class126_4)
			{
				color = (this.Focused ? Class129.smethod_14() : Class129.smethod_16());
			}
			if (flag)
			{
				color = Color.DarkGreen;
			}
			using (SolidBrush solidBrush = new SolidBrush(color))
			{
				graphics_0.FillRectangle(solidBrush, rect);
			}
			if (class126_4.method_22().Count > 0)
			{
				Point point = new Point(class126_4.method_8().Location.X - 1, class126_4.method_8().Location.Y - 1);
				Bitmap image = this.bitmap_3;
				if (class126_4.method_20() && !class126_4.method_16())
				{
					image = this.bitmap_3;
				}
				else if (class126_4.method_20() && class126_4.method_16() && !this.method_21().Contains(class126_4))
				{
					image = this.bitmap_4;
				}
				else if (class126_4.method_20() && class126_4.method_16() && this.method_21().Contains(class126_4))
				{
					image = this.bitmap_5;
				}
				else if (!class126_4.method_20() && !class126_4.method_16())
				{
					image = this.bitmap_0;
				}
				else if (!class126_4.method_20() && class126_4.method_16() && !this.method_21().Contains(class126_4))
				{
					image = this.bitmap_1;
				}
				else if (!class126_4.method_20() && class126_4.method_16() && this.method_21().Contains(class126_4))
				{
					image = this.bitmap_2;
				}
				graphics_0.DrawImageUnscaled(image, point);
			}
			if (this.method_26() && class126_4.method_18() != null)
			{
				if (class126_4.method_20() && class126_4.method_19() != null)
				{
					graphics_0.DrawImageUnscaled(class126_4.method_19(), class126_4.method_10().Location);
				}
				else
				{
					graphics_0.DrawImageUnscaled(class126_4.method_18(), class126_4.method_10().Location);
				}
			}
			graphics_0.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			using (SolidBrush solidBrush2 = new SolidBrush(class126_4.method_37()))
			{
				StringFormat format = new StringFormat
				{
					Alignment = StringAlignment.Near,
					LineAlignment = StringAlignment.Center
				};
				if (class126_4.method_39() == null)
				{
					graphics_0.DrawString(class126_4.method_6(), this.Font, solidBrush2, class126_4.method_12(), format);
				}
				else
				{
					graphics_0.DrawString(class126_4.method_6(), class126_4.method_39(), solidBrush2, class126_4.method_12(), format);
				}
			}
			if (class126_4.method_20())
			{
				foreach (Class126 class126_5 in class126_4.method_22())
				{
					this.method_58(class126_5, graphics_0, dictionary_0);
				}
			}
		}

		// Token: 0x040003B9 RID: 953
		internal string string_0;

		// Token: 0x040003BA RID: 954
		[CompilerGenerated]
		private EventHandler eventHandler_2;

		// Token: 0x040003BB RID: 955
		[CompilerGenerated]
		private Control5.Delegate7 delegate7_0;

		// Token: 0x040003BC RID: 956
		[CompilerGenerated]
		private Control5.Delegate8 delegate8_0;

		// Token: 0x040003BD RID: 957
		private bool bool_2;

		// Token: 0x040003BE RID: 958
		private readonly int int_1 = 16;

		// Token: 0x040003BF RID: 959
		private readonly int int_2 = 16;

		// Token: 0x040003C0 RID: 960
		private int int_3 = 20;

		// Token: 0x040003C1 RID: 961
		private int int_4 = 20;

		// Token: 0x040003C2 RID: 962
		private ObservableList<Class126> observableList_0;

		// Token: 0x040003C3 RID: 963
		private ObservableCollection<Class126> observableCollection_0;

		// Token: 0x040003C4 RID: 964
		private Class126 class126_0;

		// Token: 0x040003C5 RID: 965
		private Class126 class126_1;

		// Token: 0x040003C6 RID: 966
		private Bitmap bitmap_0;

		// Token: 0x040003C7 RID: 967
		private Bitmap bitmap_1;

		// Token: 0x040003C8 RID: 968
		private Bitmap bitmap_2;

		// Token: 0x040003C9 RID: 969
		private Bitmap bitmap_3;

		// Token: 0x040003CA RID: 970
		private Bitmap bitmap_4;

		// Token: 0x040003CB RID: 971
		private Bitmap bitmap_5;

		// Token: 0x040003CC RID: 972
		private Class126 class126_2;

		// Token: 0x040003CD RID: 973
		private Class126 class126_3;

		// Token: 0x040003CE RID: 974
		private bool bool_3;

		// Token: 0x040003CF RID: 975
		private List<Class126> list_0;

		// Token: 0x040003D0 RID: 976
		private Point point_1;

		// Token: 0x040003D1 RID: 977
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x040003D2 RID: 978
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x040003D3 RID: 979
		[CompilerGenerated]
		private bool bool_6;

		// Token: 0x040003D4 RID: 980
		[CompilerGenerated]
		private int int_5;

		// Token: 0x040003D5 RID: 981
		[CompilerGenerated]
		private IComparer<Class126> icomparer_0;

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x0600056B RID: 1387
		internal delegate void Delegate7(Control5 tree, Class126 Node);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x0600056F RID: 1391
		internal delegate void Delegate8(Control5 tree, Class126 Node);
	}
}
