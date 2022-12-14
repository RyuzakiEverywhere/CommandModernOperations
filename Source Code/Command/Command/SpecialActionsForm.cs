using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;

namespace Command
{
	// Token: 0x02000E82 RID: 3714
	[DesignerGenerated]
	public sealed partial class SpecialActionsForm : DarkSecondaryFormBase
	{
		// Token: 0x06007273 RID: 29299 RVA: 0x00047A9D File Offset: 0x00045C9D
		public SpecialActionsForm()
		{
			base.VisibleChanged += this.SpecialActionsForm_VisibleChanged;
			base.Load += this.SpecialActionsForm_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x06007275 RID: 29301 RVA: 0x003D6790 File Offset: 0x003D4990
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_3(new Class116());
			this.vmethod_1(new Class114());
			this.vmethod_5(new DataGridViewTextBoxColumn());
			this.vmethod_7(new DataGridViewTextBoxColumn());
			this.vmethod_9(new DataGridViewButtonColumn());
			this.vmethod_11(new Class112());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_2().method_2(true);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(0, 367);
			this.vmethod_2().Margin = new Padding(3);
			this.vmethod_2().MaximumSize = new Size(770, 0);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new Size(39, 13);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Label1";
			this.vmethod_2().TextAlign = ContentAlignment.BottomLeft;
			this.vmethod_2().Visible = false;
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_0().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_0().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font(Client.font_1.FontFamily, 8f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_4(),
				this.vmethod_6(),
				this.vmethod_8()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().Location = new Point(1, 1);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DataGridView1";
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().Size = new Size(766, 362);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_4().DataPropertyName = "ID";
			this.vmethod_4().HeaderText = "ID";
			this.vmethod_4().Name = "ID";
			this.vmethod_4().ReadOnly = true;
			this.vmethod_4().Visible = false;
			this.vmethod_6().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_6().DataPropertyName = "Name";
			this.vmethod_6().HeaderText = "Name";
			this.vmethod_6().Name = "ActionName";
			this.vmethod_6().ReadOnly = true;
			this.vmethod_8().HeaderText = "";
			this.vmethod_8().Name = "ExecuteAction";
			this.vmethod_8().ReadOnly = true;
			this.vmethod_8().Text = "Execute";
			this.vmethod_8().UseColumnTextForButtonValue = true;
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Checked = true;
			this.vmethod_10().CheckState = CheckState.Checked;
			this.vmethod_10().Location = new Point(3, 487);
			this.vmethod_10().Name = "CB_AllowActionPopup";
			this.vmethod_10().Size = new Size(236, 17);
			this.vmethod_10().TabIndex = 2;
			this.vmethod_10().Text = "Show pop-up message with action feedback";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(768, 507);
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SpecialActionsForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Special Actions";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06007276 RID: 29302 RVA: 0x00047ACF File Offset: 0x00045CCF
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x003D6D1C File Offset: 0x003D4F1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_4);
			DataGridViewCellFormattingEventHandler value2 = new DataGridViewCellFormattingEventHandler(this.method_5);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.CellClick -= value;
				@class.CellFormatting -= value2;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.CellClick += value;
				@class.CellFormatting += value2;
			}
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x00047AD7 File Offset: 0x00045CD7
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x00047ADF File Offset: 0x00045CDF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x0600727A RID: 29306 RVA: 0x00047AE8 File Offset: 0x00045CE8
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_4()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x00047AF0 File Offset: 0x00045CF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x00047AF9 File Offset: 0x00045CF9
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_6()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600727D RID: 29309 RVA: 0x00047B01 File Offset: 0x00045D01
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x00047B0A File Offset: 0x00045D0A
		[CompilerGenerated]
		internal DataGridViewButtonColumn vmethod_8()
		{
			return this.dataGridViewButtonColumn_0;
		}

		// Token: 0x0600727F RID: 29311 RVA: 0x00047B12 File Offset: 0x00045D12
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(DataGridViewButtonColumn dataGridViewButtonColumn_1)
		{
			this.dataGridViewButtonColumn_0 = dataGridViewButtonColumn_1;
		}

		// Token: 0x06007280 RID: 29312 RVA: 0x00047B1B File Offset: 0x00045D1B
		[CompilerGenerated]
		internal Class112 vmethod_10()
		{
			return this.class112_0;
		}

		// Token: 0x06007281 RID: 29313 RVA: 0x00047B23 File Offset: 0x00045D23
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class112 class112_1)
		{
			this.class112_0 = class112_1;
		}

		// Token: 0x06007282 RID: 29314 RVA: 0x00047B2C File Offset: 0x00045D2C
		private void SpecialActionsForm_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.method_3();
			}
		}

		// Token: 0x06007283 RID: 29315 RVA: 0x003D6D7C File Offset: 0x003D4F7C
		public void method_3()
		{
			if (Client.smethod_50() != null)
			{
				try
				{
					this.vmethod_0().SuspendLayout();
					DataTable dataTable = new DataTable();
					dataTable.Columns.Add("ID", typeof(string));
					dataTable.Columns.Add("Name", typeof(string));
					try
					{
						foreach (SpecialAction specialAction in Enumerable.OrderBy<SpecialAction, string>(Enumerable.Where<SpecialAction>(Client.smethod_50().dictionary_2.Values, (SpecialActionsForm._Closure$__.$I29-0 == null) ? (SpecialActionsForm._Closure$__.$I29-0 = new Func<SpecialAction, bool>(SpecialActionsForm._Closure$__.$I.method_0)) : SpecialActionsForm._Closure$__.$I29-0), (SpecialActionsForm._Closure$__.$I29-1 == null) ? (SpecialActionsForm._Closure$__.$I29-1 = new Func<SpecialAction, string>(SpecialActionsForm._Closure$__.$I.method_1)) : SpecialActionsForm._Closure$__.$I29-1))
						{
							DataRow dataRow = dataTable.NewRow();
							dataRow["ID"] = specialAction.string_0;
							dataRow["Name"] = specialAction.Name;
							dataTable.Rows.Add(dataRow);
						}
					}
					finally
					{
						IEnumerator<SpecialAction> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					this.vmethod_0().AutoGenerateColumns = false;
					this.vmethod_0().DataSource = dataTable;
					this.vmethod_0().ResumeLayout();
					if (this.vmethod_0().Rows.Count > 0)
					{
						this.vmethod_0().Rows[0].Selected = true;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200406", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					this.method_3();
				}
			}
		}

		// Token: 0x06007284 RID: 29316 RVA: 0x003D6F58 File Offset: 0x003D5158
		private void method_4(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1 && e.RowIndex <= this.vmethod_0().Rows.Count - 1)
			{
				DataGridViewColumn dataGridViewColumn = this.vmethod_0().Columns[e.ColumnIndex];
				string key = Conversions.ToString(this.vmethod_0().Rows[e.RowIndex].Cells["ID"].Value);
				if (Client.smethod_50().dictionary_2.ContainsKey(key))
				{
					SpecialAction specialAction = Client.smethod_50().dictionary_2[key];
					this.vmethod_2().Visible = true;
					this.vmethod_2().Text = specialAction.string_2;
					if (Operators.CompareString(dataGridViewColumn.Name, "ExecuteAction", false) == 0)
					{
						string text = specialAction.method_9(Client.smethod_46());
						if (this.vmethod_10().Checked)
						{
							if (text != null && Operators.CompareString(text, "", false) != 0)
							{
								DarkMessageBox.smethod_0(text, "", Enum11.const_0);
							}
							else
							{
								DarkMessageBox.smethod_2("Special Action script failed!", "Error", Enum11.const_0);
							}
						}
						this.method_3();
						Client.bool_1 = true;
					}
				}
			}
		}

		// Token: 0x06007285 RID: 29317 RVA: 0x00044489 File Offset: 0x00042689
		private void SpecialActionsForm_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x003D7090 File Offset: 0x003D5290
		private void method_5(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (Client.smethod_50().dictionary_2.Count > 0)
			{
				string key = Conversions.ToString(this.vmethod_0().Rows[e.RowIndex].Cells["ID"].Value);
				if (Client.smethod_50().dictionary_2.ContainsKey(key))
				{
					SpecialAction specialAction = Client.smethod_50().dictionary_2[key];
					this.vmethod_0().Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = specialAction.string_2;
				}
			}
		}

		// Token: 0x0400407F RID: 16511
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x04004080 RID: 16512
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004081 RID: 16513
		[CompilerGenerated]
		[AccessedThroughProperty("ID")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004082 RID: 16514
		[AccessedThroughProperty("ActionName")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004083 RID: 16515
		[AccessedThroughProperty("ExecuteAction")]
		[CompilerGenerated]
		private DataGridViewButtonColumn dataGridViewButtonColumn_0;

		// Token: 0x04004084 RID: 16516
		[AccessedThroughProperty("CB_AllowActionPopup")]
		[CompilerGenerated]
		private Class112 class112_0;
	}
}
