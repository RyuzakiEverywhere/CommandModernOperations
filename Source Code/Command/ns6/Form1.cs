using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace ns6
{
	// Token: 0x02000E7D RID: 3709
	[DesignerGenerated]
	internal sealed partial class Form1 : DarkSecondaryFormBase
	{
		// Token: 0x06007229 RID: 29225 RVA: 0x00047860 File Offset: 0x00045A60
		public Form1()
		{
			base.Shown += this.Form1_Shown;
			base.Load += this.Form1_Load;
			this.list_0 = new List<ScenAttachmentObject>();
			this.InitializeComponent_1();
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x003D4DF8 File Offset: 0x003D2FF8
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class125());
			this.vmethod_9(new ToolStripButton());
			this.vmethod_3(new TabPage());
			this.vmethod_5(new Class114());
			this.vmethod_11(new DataGridViewTextBoxColumn());
			this.vmethod_13(new DataGridViewTextBoxColumn());
			this.vmethod_15(new DataGridViewTextBoxColumn());
			this.vmethod_7(new Control12());
			this.vmethod_0().SuspendLayout();
			this.vmethod_2().SuspendLayout();
			((ISupportInitialize)this.vmethod_4()).BeginInit();
			this.vmethod_6().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AutoSize = false;
			this.vmethod_0().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_0().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_8()
			});
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "ToolStrip1";
			this.vmethod_0().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_0().Size = new Size(845, 25);
			this.vmethod_0().TabIndex = 2;
			this.vmethod_0().Text = "ToolStrip1";
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Image = (Image)componentResourceManager.GetObject("ToolStripButton1.Image");
			this.vmethod_8().ImageTransparentColor = Color.Magenta;
			this.vmethod_8().Name = "ToolStripButton1";
			this.vmethod_8().Size = new Size(176, 22);
			this.vmethod_8().Text = "Load selected attachment(s)";
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().Controls.Add(this.vmethod_4());
			this.vmethod_2().Location = new Point(4, 24);
			this.vmethod_2().Name = "TabPage1";
			this.vmethod_2().Padding = new Padding(3);
			this.vmethod_2().Size = new Size(837, 294);
			this.vmethod_2().TabIndex = 0;
			this.vmethod_2().Text = "Local repository";
			this.vmethod_4().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_4().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_4().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font(Client.font_1.FontFamily, 8f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_4().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_4().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_4().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_10(),
				this.vmethod_12(),
				this.vmethod_14()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font(Client.font_1.FontFamily, 8f);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_4().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_4().Dock = DockStyle.Fill;
			this.vmethod_4().EnableHeadersVisualStyles = false;
			this.vmethod_4().Location = new Point(3, 3);
			this.vmethod_4().Name = "DataGridView1";
			this.vmethod_4().RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_4().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_4().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_4().Size = new Size(831, 288);
			this.vmethod_4().TabIndex = 0;
			this.vmethod_10().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_10().HeaderText = "Name";
			this.vmethod_10().Name = "Name";
			this.vmethod_10().ReadOnly = true;
			this.vmethod_10().Width = 58;
			this.vmethod_12().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_12().HeaderText = "Type";
			this.vmethod_12().Name = "Type";
			this.vmethod_12().ReadOnly = true;
			this.vmethod_12().Width = 54;
			this.vmethod_14().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_14().HeaderText = "GUID";
			this.vmethod_14().Name = "GUID";
			this.vmethod_14().ReadOnly = true;
			this.vmethod_6().Controls.Add(this.vmethod_2());
			this.vmethod_6().Cursor = Cursors.Hand;
			this.vmethod_6().Font = new Font(Client.font_1.FontFamily, 8f);
			this.vmethod_6().ItemSize = new Size(80, 20);
			this.vmethod_6().Location = new Point(0, 28);
			this.vmethod_6().Name = "TabControl1";
			this.vmethod_6().SelectedIndex = 0;
			this.vmethod_6().Size = new Size(845, 322);
			this.vmethod_6().TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(845, 347);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Select SAO";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Load existing scenario attachment";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			this.vmethod_2().ResumeLayout(false);
			((ISupportInitialize)this.vmethod_4()).EndInit();
			this.vmethod_6().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x0004789D File Offset: 0x00045A9D
		[CompilerGenerated]
		internal Class125 vmethod_0()
		{
			return this.class125_0;
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x000478A5 File Offset: 0x00045AA5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x000478AE File Offset: 0x00045AAE
		[CompilerGenerated]
		internal TabPage vmethod_2()
		{
			return this.tabPage_0;
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x000478B6 File Offset: 0x00045AB6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TabPage tabPage_1)
		{
			this.tabPage_0 = tabPage_1;
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x000478BF File Offset: 0x00045ABF
		[CompilerGenerated]
		internal Class114 vmethod_4()
		{
			return this.class114_0;
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x000478C7 File Offset: 0x00045AC7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class114 class114_1)
		{
			this.class114_0 = class114_1;
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x000478D0 File Offset: 0x00045AD0
		[CompilerGenerated]
		internal Control12 vmethod_6()
		{
			return this.control12_0;
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x000478D8 File Offset: 0x00045AD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control12 control12_1)
		{
			this.control12_0 = control12_1;
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x000478E1 File Offset: 0x00045AE1
		[CompilerGenerated]
		internal ToolStripButton vmethod_8()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06007235 RID: 29237 RVA: 0x003D5518 File Offset: 0x003D3718
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripButton toolStripButton_1)
		{
			EventHandler value = new EventHandler(this.method_4);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_1;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06007236 RID: 29238 RVA: 0x000478E9 File Offset: 0x00045AE9
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_10()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06007237 RID: 29239 RVA: 0x000478F1 File Offset: 0x00045AF1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x000478FA File Offset: 0x00045AFA
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_12()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06007239 RID: 29241 RVA: 0x00047902 File Offset: 0x00045B02
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x0600723A RID: 29242 RVA: 0x0004790B File Offset: 0x00045B0B
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_14()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x00047913 File Offset: 0x00045B13
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x0004791C File Offset: 0x00045B1C
		private void Form1_Shown(object sender, EventArgs e)
		{
			this.list_0.Clear();
			this.method_3();
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x003D555C File Offset: 0x003D375C
		public void method_3()
		{
			List<ScenAttachmentObject> list = new List<ScenAttachmentObject>();
			string[] directories = Directory.GetDirectories(GameGeneral.string_6);
			checked
			{
				for (int i = 0; i < directories.Length; i++)
				{
					ScenAttachmentObject item = ScenAttachmentObject.smethod_1(directories[i]);
					list.Add(item);
				}
				this.vmethod_4().SuspendLayout();
				this.vmethod_4().Rows.Clear();
				try
				{
					foreach (ScenAttachmentObject scenAttachmentObject in list)
					{
						DataGridViewRow dataGridViewRow = new DataGridViewRow();
						dataGridViewRow.CreateCells(this.vmethod_4());
						dataGridViewRow.Cells[0].Value = scenAttachmentObject.method_1();
						dataGridViewRow.Cells[1].Value = scenAttachmentObject.attachmentObjectType_0.ToString();
						dataGridViewRow.Cells[2].Value = scenAttachmentObject.method_0();
						dataGridViewRow.Tag = scenAttachmentObject;
						this.vmethod_4().Rows.Add(dataGridViewRow);
					}
				}
				finally
				{
					List<ScenAttachmentObject>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.vmethod_4().ResumeLayout();
			}
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x003D5688 File Offset: 0x003D3888
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_4().SelectedRows.Count != 0)
			{
				try
				{
					foreach (object obj in this.vmethod_4().SelectedRows)
					{
						ScenAttachmentObject item = (ScenAttachmentObject)NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), null, "tag", new object[0], null, null, null);
						this.list_0.Add(item);
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x00044489 File Offset: 0x00042689
		private void Form1_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04004056 RID: 16470
		[AccessedThroughProperty("ToolStrip1")]
		[CompilerGenerated]
		private Class125 class125_0;

		// Token: 0x04004057 RID: 16471
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage1")]
		private TabPage tabPage_0;

		// Token: 0x04004058 RID: 16472
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x04004059 RID: 16473
		[AccessedThroughProperty("TabControl1")]
		[CompilerGenerated]
		private Control12 control12_0;

		// Token: 0x0400405A RID: 16474
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripButton1")]
		private ToolStripButton toolStripButton_0;

		// Token: 0x0400405B RID: 16475
		[AccessedThroughProperty("Column_name")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x0400405C RID: 16476
		[CompilerGenerated]
		[AccessedThroughProperty("Type")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x0400405D RID: 16477
		[CompilerGenerated]
		[AccessedThroughProperty("GUID")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x0400405E RID: 16478
		public List<ScenAttachmentObject> list_0;
	}
}
