using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using AdvancedDataGridView;
using ns0;

namespace ns1
{
	// Token: 0x02000051 RID: 81
	internal sealed class Class48 : DataGridViewRow
	{
		// Token: 0x0600010C RID: 268 RVA: 0x0000336B File Offset: 0x0000156B
		internal Class48(TreeGridView treeGridView_1) : this()
		{
			this.treeGridView_0 = treeGridView_1;
			this.bool_0 = true;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00056B44 File Offset: 0x00054D44
		public Class48()
		{
			this.int_2 = -1;
			this.int_3 = -1;
			this.bool_0 = false;
			this.int_1 = this.random_0.Next();
			this.bool_2 = false;
			this.bool_3 = false;
			this.bool_4 = false;
			this.int_0 = -1;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00056BAC File Offset: 0x00054DAC
		public override object Clone()
		{
			Class48 @class = (Class48)base.Clone();
			@class.int_1 = -1;
			@class.int_3 = this.int_3;
			@class.treeGridView_0 = this.treeGridView_0;
			@class.class48_0 = this.method_9();
			@class.int_0 = this.int_0;
			if (@class.int_0 == -1)
			{
				@class.method_5(this.method_4());
			}
			@class.bool_0 = this.bool_0;
			return @class;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00003381 File Offset: 0x00001581
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00056C20 File Offset: 0x00054E20
		protected internal void vmethod_0()
		{
			foreach (object obj in this.Cells)
			{
				Class43 @class = ((DataGridViewCell)obj) as Class43;
				if (@class != null)
				{
					@class.vmethod_0();
				}
			}
			this.bool_2 = false;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00056C88 File Offset: 0x00054E88
		protected internal void vmethod_1()
		{
			this.bool_2 = true;
			this.bool_5 = true;
			foreach (object obj in this.Cells)
			{
				Class43 @class = ((DataGridViewCell)obj) as Class43;
				if (@class != null)
				{
					@class.vmethod_1();
				}
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00003389 File Offset: 0x00001589
		public int method_1()
		{
			return base.Index;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00003391 File Offset: 0x00001591
		public int method_2()
		{
			if (this.int_2 == -1)
			{
				this.int_2 = this.class49_0.IndexOf(this);
			}
			return this.int_2;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000033B4 File Offset: 0x000015B4
		public ImageList method_3()
		{
			if (this.treeGridView_0 != null)
			{
				return this.treeGridView_0.method_8();
			}
			return null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00056CF8 File Offset: 0x00054EF8
		public Image method_4()
		{
			if (this.image_0 != null || this.int_0 == -1)
			{
				return this.image_0;
			}
			if (this.method_3() != null && this.int_0 < this.method_3().Images.Count)
			{
				return this.method_3().Images[this.int_0];
			}
			return null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00056D58 File Offset: 0x00054F58
		public void method_5(Image image_1)
		{
			this.image_0 = image_1;
			if (this.image_0 != null)
			{
				this.int_0 = -1;
			}
			if (this.bool_2)
			{
				this.class43_0.vmethod_2();
				if (this.Displayed)
				{
					this.treeGridView_0.InvalidateRow(this.method_1());
				}
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000033CB File Offset: 0x000015CB
		protected override DataGridViewCellCollection CreateCellsInstance()
		{
			DataGridViewCellCollection dataGridViewCellCollection = base.CreateCellsInstance();
			dataGridViewCellCollection.CollectionChanged += this.method_6;
			return dataGridViewCellCollection;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00056DA8 File Offset: 0x00054FA8
		private void method_6(object sender, CollectionChangeEventArgs e)
		{
			if (this.class43_0 != null)
			{
				return;
			}
			if (e.Action == CollectionChangeAction.Add || e.Action == CollectionChangeAction.Refresh)
			{
				Class43 @class = null;
				if (e.Element == null)
				{
					using (IEnumerator enumerator = base.Cells.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							DataGridViewCell dataGridViewCell = (DataGridViewCell)obj;
							if (dataGridViewCell.GetType().IsAssignableFrom(typeof(Class43)))
							{
								@class = (Class43)dataGridViewCell;
								break;
							}
						}
						goto IL_87;
					}
				}
				@class = (e.Element as Class43);
				IL_87:
				if (@class != null)
				{
					this.class43_0 = @class;
				}
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000033E5 File Offset: 0x000015E5
		public Class49 method_7()
		{
			if (this.class49_1 == null)
			{
				this.class49_1 = new Class49(this);
			}
			return this.class49_1;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00003401 File Offset: 0x00001601
		public new DataGridViewCellCollection Cells
		{
			get
			{
				if (!this.bool_5 && base.DataGridView == null)
				{
					if (this.treeGridView_0 == null)
					{
						return null;
					}
					base.CreateCells(this.treeGridView_0);
					this.bool_5 = true;
				}
				return base.Cells;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00056E58 File Offset: 0x00055058
		public int method_8()
		{
			if (this.int_3 == -1)
			{
				int num = 0;
				for (Class48 @class = this.method_9(); @class != null; @class = @class.method_9())
				{
					num++;
				}
				this.int_3 = num;
			}
			return this.int_3;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00003436 File Offset: 0x00001636
		public Class48 method_9()
		{
			return this.class48_0;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000343E File Offset: 0x0000163E
		public bool vmethod_2()
		{
			return this.class49_1 != null && this.method_7().Count != 0;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00003458 File Offset: 0x00001658
		public bool method_10()
		{
			return this.bool_2;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00003460 File Offset: 0x00001660
		public bool method_11()
		{
			return this.method_2() == 0;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00056E94 File Offset: 0x00055094
		public bool method_12()
		{
			Class48 @class = this.method_9();
			return @class == null || !@class.vmethod_2() || this.method_2() == @class.method_7().Count - 1;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000346B File Offset: 0x0000166B
		public bool vmethod_3()
		{
			return this.treeGridView_0.vmethod_1(this);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00003479 File Offset: 0x00001679
		public bool vmethod_4()
		{
			if (this.treeGridView_0 != null)
			{
				return this.treeGridView_0.vmethod_4(this);
			}
			this.bool_0 = true;
			return true;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00056ECC File Offset: 0x000550CC
		protected internal bool vmethod_5(int int_4, Class48 class48_1)
		{
			class48_1.class48_0 = this;
			class48_1.treeGridView_0 = this.treeGridView_0;
			if (this.treeGridView_0 != null)
			{
				this.method_13(class48_1);
			}
			if ((this.bool_2 || this.bool_1) && this.bool_0)
			{
				this.treeGridView_0.vmethod_2(class48_1);
			}
			return true;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00056F20 File Offset: 0x00055120
		protected internal bool vmethod_6(Class48 class48_1)
		{
			class48_1.class48_0 = this;
			class48_1.treeGridView_0 = this.treeGridView_0;
			if (this.treeGridView_0 != null)
			{
				this.method_13(class48_1);
			}
			if ((this.bool_2 || this.bool_1) && this.bool_0 && !class48_1.bool_2)
			{
				this.treeGridView_0.vmethod_2(class48_1);
			}
			return true;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00003498 File Offset: 0x00001698
		protected internal bool vmethod_7(Class48 class48_1)
		{
			if ((this.bool_1 || this.bool_2) && this.bool_0)
			{
				this.treeGridView_0.vmethod_0(class48_1);
			}
			class48_1.treeGridView_0 = null;
			class48_1.class48_0 = null;
			return true;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00056F7C File Offset: 0x0005517C
		protected internal bool vmethod_8()
		{
			if (this.vmethod_2())
			{
				for (int i = this.method_7().Count - 1; i >= 0; i--)
				{
					this.method_7().RemoveAt(i);
				}
			}
			return true;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00056FB8 File Offset: 0x000551B8
		private void method_13(Class48 class48_1)
		{
			if (class48_1.vmethod_2())
			{
				foreach (Class48 @class in class48_1.method_7())
				{
					@class.treeGridView_0 = class48_1.treeGridView_0;
					this.method_13(@class);
				}
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0005701C File Offset: 0x0005521C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(36);
			stringBuilder.Append("TreeGridNode { Index=");
			stringBuilder.Append(this.method_1().ToString(CultureInfo.CurrentCulture));
			stringBuilder.Append(" }");
			return stringBuilder.ToString();
		}

		// Token: 0x040000AD RID: 173
		internal TreeGridView treeGridView_0;

		// Token: 0x040000AE RID: 174
		internal Class48 class48_0;

		// Token: 0x040000AF RID: 175
		internal Class49 class49_0;

		// Token: 0x040000B0 RID: 176
		internal bool bool_0;

		// Token: 0x040000B1 RID: 177
		internal bool bool_1;

		// Token: 0x040000B2 RID: 178
		internal bool bool_2;

		// Token: 0x040000B3 RID: 179
		internal bool bool_3;

		// Token: 0x040000B4 RID: 180
		internal bool bool_4;

		// Token: 0x040000B5 RID: 181
		internal Image image_0;

		// Token: 0x040000B6 RID: 182
		internal int int_0;

		// Token: 0x040000B7 RID: 183
		private Random random_0 = new Random();

		// Token: 0x040000B8 RID: 184
		public int int_1 = -1;

		// Token: 0x040000B9 RID: 185
		private Class43 class43_0;

		// Token: 0x040000BA RID: 186
		private Class49 class49_1;

		// Token: 0x040000BB RID: 187
		private int int_2;

		// Token: 0x040000BC RID: 188
		private int int_3;

		// Token: 0x040000BD RID: 189
		private bool bool_5;
	}
}
