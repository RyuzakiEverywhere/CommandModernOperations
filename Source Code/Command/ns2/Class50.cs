using System;
using System.Drawing;
using System.Windows.Forms;
using AdvancedDataGridView;
using ns8;

namespace ns2
{
	// Token: 0x020000D6 RID: 214
	internal sealed class Class50 : TreeGridView
	{
		// Token: 0x060004C9 RID: 1225 RVA: 0x00068FB8 File Offset: 0x000671B8
		public Class50()
		{
			this.BackColor = Class129.smethod_4();
			this.ForeColor = Class129.smethod_11();
			base.BackgroundColor = Class129.smethod_4();
			base.BorderStyle = BorderStyle.FixedSingle;
			base.DefaultCellStyle = new DataGridViewCellStyle
			{
				BackColor = Class129.smethod_0(),
				Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0),
				ForeColor = Color.LightGray
			};
			base.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
			{
				Alignment = DataGridViewContentAlignment.MiddleLeft,
				BackColor = Class129.smethod_2(),
				Font = new Font("Segoe UI", 8.25f),
				ForeColor = Color.LightGray,
				SelectionBackColor = Class129.smethod_14(),
				SelectionForeColor = Class129.smethod_15(),
				WrapMode = DataGridViewTriState.True
			};
			base.EnableHeadersVisualStyles = false;
			base.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			base.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			base.BorderStyle = BorderStyle.None;
		}
	}
}
