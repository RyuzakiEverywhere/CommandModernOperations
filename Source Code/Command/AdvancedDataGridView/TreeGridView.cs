using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns1;

namespace AdvancedDataGridView
{
	// Token: 0x02000053 RID: 83
	[ComplexBindingProperties]
	public class TreeGridView : DataGridView
	{
		// Token: 0x06000149 RID: 329 RVA: 0x000571D0 File Offset: 0x000553D0
		public TreeGridView()
		{
			base.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.method_1(new Class48());
			base.AllowUserToAddRows = false;
			base.AllowUserToDeleteRows = false;
			this.class48_0 = new Class48(this);
			this.class48_0.bool_1 = true;
			base.Rows.CollectionChanged += TreeGridView.<>c.<>9.method_0;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0005724C File Offset: 0x0005544C
		protected override void OnKeyDown(KeyEventArgs ke)
		{
			base.OnKeyDown(ke);
			if (!ke.Handled)
			{
				if (ke.KeyCode == Keys.F2 && base.CurrentCellAddress.X > -1 && base.CurrentCellAddress.Y > -1)
				{
					if (!base.CurrentCell.Displayed)
					{
						base.FirstDisplayedScrollingRowIndex = base.CurrentCellAddress.Y;
					}
					base.SelectionMode = DataGridViewSelectionMode.CellSelect;
					this.BeginEdit(true);
					return;
				}
				if (ke.KeyCode == Keys.Return && !base.IsCurrentCellInEditMode)
				{
					base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					base.CurrentCell.OwningRow.Selected = true;
				}
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00003618 File Offset: 0x00001818
		public DataGridViewRowCollection method_0()
		{
			return base.Rows;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00003620 File Offset: 0x00001820
		public void method_1(DataGridViewRow dataGridViewRow_0)
		{
			base.RowTemplate = dataGridViewRow_0;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00003629 File Offset: 0x00001829
		public Class49 method_2()
		{
			return this.class48_0.method_7();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00003636 File Offset: 0x00001836
		public Class48 method_3()
		{
			return base.CurrentRow as Class48;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00003643 File Offset: 0x00001843
		public bool method_4()
		{
			return this.bool_4;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000364B File Offset: 0x0000184B
		public Class48 method_5()
		{
			return this.method_3();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00003653 File Offset: 0x00001853
		public bool method_6()
		{
			return this.bool_3;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000365B File Offset: 0x0000185B
		public void method_7(bool bool_5)
		{
			if (bool_5 != this.bool_3)
			{
				this.bool_3 = bool_5;
				base.Invalidate();
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00003673 File Offset: 0x00001873
		public ImageList method_8()
		{
			return this.imageList_0;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000367B File Offset: 0x0000187B
		public void method_9(ImageList imageList_1)
		{
			this.imageList_0 = imageList_1;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000572F4 File Offset: 0x000554F4
		protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
		{
			base.OnRowsAdded(e);
			Class48 @class = base.Rows[e.RowIndex] as Class48;
			if (@class != null)
			{
				@class.vmethod_1();
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00003684 File Offset: 0x00001884
		protected internal void method_10()
		{
			this.vmethod_0(this.class48_0);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00057328 File Offset: 0x00055528
		protected internal virtual void vmethod_0(Class48 class48_1)
		{
			try
			{
				if (class48_1.method_10() || class48_1.bool_1)
				{
					foreach (Class48 class48_2 in class48_1.method_7())
					{
						this.vmethod_0(class48_2);
					}
					if (!class48_1.bool_1)
					{
						base.Rows.Remove(class48_1);
						class48_1.vmethod_0();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000573B4 File Offset: 0x000555B4
		protected internal virtual bool vmethod_1(Class48 class48_1)
		{
			if (class48_1.bool_0)
			{
				EventArgs0 eventArgs = new EventArgs0(class48_1);
				this.vmethod_7(eventArgs);
				if (!eventArgs.Cancel)
				{
					this.method_17(true);
					base.SuspendLayout();
					this.bool_1 = true;
					class48_1.bool_0 = false;
					foreach (Class48 class48_2 in class48_1.method_7())
					{
						this.vmethod_0(class48_2);
					}
					Class46 class46_ = new Class46(class48_1);
					this.vmethod_8(class46_);
					this.bool_1 = false;
					this.method_17(false);
					base.ResumeLayout(true);
					base.InvalidateCell(class48_1.Cells[0]);
				}
				return !eventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00057484 File Offset: 0x00055684
		protected internal virtual void vmethod_2(Class48 class48_1)
		{
			class48_1.treeGridView_0 = this;
			Class48 @class;
			if (class48_1.method_9() != null && !class48_1.method_9().bool_1)
			{
				if (class48_1.method_2() > 0)
				{
					@class = class48_1.method_9().method_7()[class48_1.method_2() - 1];
				}
				else
				{
					@class = class48_1.method_9();
				}
			}
			else if (class48_1.method_2() > 0)
			{
				@class = class48_1.method_9().method_7()[class48_1.method_2() - 1];
			}
			else
			{
				@class = null;
			}
			int int_;
			if (@class != null)
			{
				while (@class.method_8() >= class48_1.method_8() && @class.method_1() < base.Rows.Count - 1)
				{
					@class = (base.Rows[@class.method_1() + 1] as Class48);
				}
				if (@class == class48_1.method_9())
				{
					int_ = @class.method_1() + 1;
				}
				else if (@class.method_8() < class48_1.method_8())
				{
					int_ = @class.method_1();
				}
				else
				{
					int_ = @class.method_1() + 1;
				}
			}
			else
			{
				int_ = 0;
			}
			this.vmethod_3(class48_1, int_);
			if (class48_1.bool_0)
			{
				foreach (Class48 class48_2 in class48_1.method_7())
				{
					this.vmethod_2(class48_2);
				}
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00003692 File Offset: 0x00001892
		protected internal virtual void vmethod_3(Class48 class48_1, int int_0)
		{
			if (int_0 < base.Rows.Count)
			{
				base.Rows.Insert(int_0, class48_1);
				return;
			}
			base.Rows.Add(class48_1);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000575CC File Offset: 0x000557CC
		protected internal virtual bool vmethod_4(Class48 class48_1)
		{
			if (class48_1.bool_0 && !this.bool_4)
			{
				return false;
			}
			EventArgs1 eventArgs = new EventArgs1(class48_1);
			this.vmethod_5(eventArgs);
			if (!eventArgs.Cancel)
			{
				this.method_17(true);
				base.SuspendLayout();
				this.bool_1 = true;
				class48_1.bool_0 = true;
				foreach (Class48 class48_2 in class48_1.method_7())
				{
					this.vmethod_2(class48_2);
				}
				Class47 class47_ = new Class47(class48_1);
				this.vmethod_6(class47_);
				this.bool_1 = false;
				this.method_17(false);
				base.ResumeLayout(true);
				base.InvalidateCell(class48_1.Cells[0]);
			}
			return !eventArgs.Cancel;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000036BD File Offset: 0x000018BD
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			this.bool_2 = false;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000036CD File Offset: 0x000018CD
		protected override void OnMouseMove(MouseEventArgs mea)
		{
			if (!this.bool_2)
			{
				base.OnMouseMove(mea);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000576A0 File Offset: 0x000558A0
		[CompilerGenerated]
		public void method_11(Delegate1 delegate1_1)
		{
			Delegate1 @delegate = this.delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_1);
				@delegate = Interlocked.CompareExchange<Delegate1>(ref this.delegate1_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000576D8 File Offset: 0x000558D8
		[CompilerGenerated]
		public void method_12(Delegate1 delegate1_1)
		{
			Delegate1 @delegate = this.delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value = (Delegate1)Delegate.Remove(delegate2, delegate1_1);
				@delegate = Interlocked.CompareExchange<Delegate1>(ref this.delegate1_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00057710 File Offset: 0x00055910
		[CompilerGenerated]
		public void method_13(Delegate2 delegate2_1)
		{
			Delegate2 @delegate = this.delegate2_0;
			Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate2 value = (Delegate2)Delegate.Combine(delegate2, delegate2_1);
				@delegate = Interlocked.CompareExchange<Delegate2>(ref this.delegate2_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00057748 File Offset: 0x00055948
		[CompilerGenerated]
		public void method_14(Delegate2 delegate2_1)
		{
			Delegate2 @delegate = this.delegate2_0;
			Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate2 value = (Delegate2)Delegate.Remove(delegate2, delegate2_1);
				@delegate = Interlocked.CompareExchange<Delegate2>(ref this.delegate2_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00057780 File Offset: 0x00055980
		[CompilerGenerated]
		public void method_15(Delegate3 delegate3_1)
		{
			Delegate3 @delegate = this.delegate3_0;
			Delegate3 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate3 value = (Delegate3)Delegate.Combine(delegate2, delegate3_1);
				@delegate = Interlocked.CompareExchange<Delegate3>(ref this.delegate3_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000577B8 File Offset: 0x000559B8
		[CompilerGenerated]
		public void method_16(Delegate3 delegate3_1)
		{
			Delegate3 @delegate = this.delegate3_0;
			Delegate3 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate3 value = (Delegate3)Delegate.Remove(delegate2, delegate3_1);
				@delegate = Interlocked.CompareExchange<Delegate3>(ref this.delegate3_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000036DE File Offset: 0x000018DE
		protected virtual void vmethod_5(EventArgs1 eventArgs1_0)
		{
			if (this.delegate1_0 != null)
			{
				this.delegate1_0(this, eventArgs1_0);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000036F5 File Offset: 0x000018F5
		protected virtual void vmethod_6(Class47 class47_0)
		{
			if (this.delegate2_0 != null)
			{
				this.delegate2_0(this, class47_0);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000370C File Offset: 0x0000190C
		protected virtual void vmethod_7(EventArgs0 eventArgs0_0)
		{
			if (this.delegate3_0 != null)
			{
				this.delegate3_0(this, eventArgs0_0);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00003723 File Offset: 0x00001923
		protected virtual void vmethod_8(Class46 class46_0)
		{
			if (this.delegate4_0 != null)
			{
				this.delegate4_0(this, class46_0);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000373A File Offset: 0x0000193A
		protected override void Dispose(bool disposing)
		{
			this.bool_0 = true;
			base.Dispose(base.Disposing);
			this.method_10();
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000577F0 File Offset: 0x000559F0
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			this.control_0 = new Control();
			this.control_0.Visible = false;
			this.control_0.Enabled = false;
			this.control_0.TabStop = false;
			base.Controls.Add(this.control_0);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00057844 File Offset: 0x00055A44
		protected override void OnRowEnter(DataGridViewCellEventArgs e)
		{
			base.OnRowEnter(e);
			if (base.SelectionMode == DataGridViewSelectionMode.CellSelect || (base.SelectionMode == DataGridViewSelectionMode.FullRowSelect && !base.Rows[e.RowIndex].Selected))
			{
				base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				base.Rows[e.RowIndex].Selected = true;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00003755 File Offset: 0x00001955
		private void method_17(bool bool_5)
		{
			if (!this.bool_1)
			{
				if (bool_5)
				{
					base.VerticalScrollBar.Parent = this.control_0;
					return;
				}
				base.VerticalScrollBar.Parent = this;
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000578A0 File Offset: 0x00055AA0
		protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
		{
			if (typeof(Class44).IsAssignableFrom(e.Column.GetType()) && this.class44_0 == null)
			{
				this.class44_0 = (Class44)e.Column;
			}
			e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
			base.OnColumnAdded(e);
		}

		// Token: 0x040000C0 RID: 192
		private Class48 class48_0;

		// Token: 0x040000C1 RID: 193
		private Class44 class44_0;

		// Token: 0x040000C2 RID: 194
		private bool bool_0;

		// Token: 0x040000C3 RID: 195
		internal ImageList imageList_0;

		// Token: 0x040000C4 RID: 196
		private bool bool_1;

		// Token: 0x040000C5 RID: 197
		internal bool bool_2;

		// Token: 0x040000C6 RID: 198
		private Control control_0;

		// Token: 0x040000C7 RID: 199
		private bool bool_3 = true;

		// Token: 0x040000C8 RID: 200
		private bool bool_4;

		// Token: 0x040000C9 RID: 201
		[CompilerGenerated]
		private Delegate1 delegate1_0;

		// Token: 0x040000CA RID: 202
		[CompilerGenerated]
		private Delegate2 delegate2_0;

		// Token: 0x040000CB RID: 203
		[CompilerGenerated]
		private Delegate3 delegate3_0;

		// Token: 0x040000CC RID: 204
		[CompilerGenerated]
		private Delegate4 delegate4_0;
	}
}
