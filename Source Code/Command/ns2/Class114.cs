using System;
using System.Drawing;
using System.Windows.Forms;
using ns8;

namespace ns2
{
	// Token: 0x020000C5 RID: 197
	internal sealed class Class114 : DataGridView
	{
		// Token: 0x06000443 RID: 1091 RVA: 0x0006647C File Offset: 0x0006467C
		public Class114()
		{
			this.DoubleBuffered = true;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.UpdateStyles();
			base.Padding = new Padding(2, 2, 2, 2);
			base.BorderStyle = BorderStyle.None;
			base.BackgroundColor = Class129.smethod_0();
			base.DefaultCellStyle = new DataGridViewCellStyle
			{
				Alignment = DataGridViewContentAlignment.MiddleLeft,
				BackColor = Class129.smethod_0(),
				Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0),
				ForeColor = Color.LightGray,
				SelectionBackColor = Class129.smethod_14(),
				SelectionForeColor = Class129.smethod_15(),
				WrapMode = DataGridViewTriState.False
			};
			base.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
			{
				Alignment = DataGridViewContentAlignment.MiddleLeft,
				BackColor = Class129.smethod_2(),
				Font = new Font("Segoe UI", 8f),
				ForeColor = Color.LightGray,
				SelectionBackColor = Class129.smethod_14(),
				SelectionForeColor = Class129.smethod_15(),
				WrapMode = DataGridViewTriState.True
			};
			base.RowsDefaultCellStyle = new DataGridViewCellStyle
			{
				BackColor = Class129.smethod_0(),
				ForeColor = Color.LightGray,
				SelectionBackColor = Class129.smethod_14(),
				SelectionForeColor = Color.LightGray
			};
			base.EnableHeadersVisualStyles = false;
			base.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			base.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			base.BorderStyle = BorderStyle.None;
		}
	}
}
