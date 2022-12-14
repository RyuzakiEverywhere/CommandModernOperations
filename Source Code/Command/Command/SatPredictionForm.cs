using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using DarkUI.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns2;
using ns4;
using ns5;
using ns8;

namespace Command
{
	// Token: 0x02000E7E RID: 3710
	[DesignerGenerated]
	public sealed partial class SatPredictionForm : DarkSecondaryFormBase
	{
		// Token: 0x06007240 RID: 29248 RVA: 0x003D5728 File Offset: 0x003D3928
		public SatPredictionForm()
		{
			base.Shown += this.SatPredictionForm_Shown;
			base.FormClosing += this.SatPredictionForm_FormClosing;
			base.Load += this.SatPredictionForm_Load;
			this.bool_3 = false;
			this.InitializeComponent_1();
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x003D57C0 File Offset: 0x003D39C0
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class114());
			this.vmethod_19(new DataGridViewTextBoxColumn());
			this.vmethod_21(new DataGridViewTextBoxColumn());
			this.vmethod_23(new DataGridViewTextBoxColumn());
			this.vmethod_25(new DataGridViewTextBoxColumn());
			this.vmethod_3(new DataGridViewTextBoxColumn());
			this.vmethod_5(new DataGridViewTextBoxColumn());
			this.vmethod_7(new DataGridViewTextBoxColumn());
			this.vmethod_9(new DataGridViewTextBoxColumn());
			this.vmethod_11(new Class116());
			this.vmethod_13(new Control10());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Control9());
			this.vmethod_27(new Control11());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToOrderColumns = true;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_0().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_0().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_18(),
				this.vmethod_20(),
				this.vmethod_22(),
				this.vmethod_24()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().Location = new Point(0, 44);
			this.vmethod_0().Name = "DataGridView1";
			this.vmethod_0().ReadOnly = true;
			this.vmethod_0().RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().Size = new Size(804, 440);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_18().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_18().HeaderText = "Satellite";
			this.vmethod_18().Name = "Satellite";
			this.vmethod_18().ReadOnly = true;
			this.vmethod_18().Width = 71;
			this.vmethod_20().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_20().HeaderText = "Side";
			this.vmethod_20().Name = "Side";
			this.vmethod_20().ReadOnly = true;
			this.vmethod_20().Width = 52;
			this.vmethod_22().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_22().HeaderText = "Enters coverage at:";
			this.vmethod_22().Name = "CoverageStart";
			this.vmethod_22().ReadOnly = true;
			this.vmethod_22().Width = 106;
			this.vmethod_24().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_24().HeaderText = "DwellTime";
			this.vmethod_24().Name = "DwellTime";
			this.vmethod_24().ReadOnly = true;
			this.vmethod_2().HeaderText = "Satellite";
			this.vmethod_2().Name = "DataGridViewTextBoxColumn1";
			this.vmethod_2().ReadOnly = true;
			this.vmethod_4().HeaderText = "Side";
			this.vmethod_4().Name = "DataGridViewTextBoxColumn2";
			this.vmethod_4().ReadOnly = true;
			this.vmethod_6().HeaderText = "Enters coverage at:";
			this.vmethod_6().Name = "DataGridViewTextBoxColumn3";
			this.vmethod_6().ReadOnly = true;
			this.vmethod_8().HeaderText = "DwellTime";
			this.vmethod_8().Name = "DataGridViewTextBoxColumn4";
			this.vmethod_8().ReadOnly = true;
			this.vmethod_10().method_2(true);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Location = new Point(12, 17);
			this.vmethod_10().Name = "Label1";
			this.vmethod_10().Size = new Size(107, 15);
			this.vmethod_10().TabIndex = 1;
			this.vmethod_10().Text = "Predict for the next";
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_12().Location = new Point(120, 12);
			this.vmethod_12().method_1(100);
			this.vmethod_12().method_3(0);
			this.vmethod_12().Name = "NumericUpDown1";
			this.vmethod_12().Size = new Size(58, 26);
			this.vmethod_12().TabIndex = 2;
			this.vmethod_12().Value = 0;
			this.vmethod_14().method_2(true);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(194, 17);
			this.vmethod_14().Name = "Label2";
			this.vmethod_14().Size = new Size(31, 15);
			this.vmethod_14().TabIndex = 3;
			this.vmethod_14().Text = "days";
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().DialogResult = DialogResult.None;
			this.vmethod_16().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_16().ForeColor = SystemColors.Control;
			this.vmethod_16().Location = new Point(242, 12);
			this.vmethod_16().Name = "Button1";
			this.vmethod_16().method_1(0);
			this.vmethod_16().Size = new Size(75, 26);
			this.vmethod_16().TabIndex = 4;
			this.vmethod_16().Text = "Recalculate";
			this.vmethod_26().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_26().BackColor = Color.Transparent;
			this.vmethod_26().Location = new Point(323, 12);
			this.vmethod_26().method_1(100);
			this.vmethod_26().Name = "DarkUIProgressBar1";
			this.vmethod_26().method_3(true);
			this.vmethod_26().method_5(true);
			this.vmethod_26().Size = new Size(469, 26);
			this.vmethod_26().TabIndex = 5;
			this.vmethod_26().Text = "Calculating...";
			this.vmethod_26().Value = 0;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(804, 484);
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SatPredictionForm";
			base.ShowIcon = false;
			this.Text = "Satellite pass predictions";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x0004792F File Offset: 0x00045B2F
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x00047937 File Offset: 0x00045B37
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			this.class114_0 = class114_1;
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x00047940 File Offset: 0x00045B40
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_2()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x00047948 File Offset: 0x00045B48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x00047951 File Offset: 0x00045B51
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_4()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x00047959 File Offset: 0x00045B59
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x00047962 File Offset: 0x00045B62
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_6()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x0004796A File Offset: 0x00045B6A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x0600724B RID: 29259 RVA: 0x00047973 File Offset: 0x00045B73
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_8()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x0004797B File Offset: 0x00045B7B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x00047984 File Offset: 0x00045B84
		[CompilerGenerated]
		internal Class116 vmethod_10()
		{
			return this.class116_0;
		}

		// Token: 0x0600724E RID: 29262 RVA: 0x0004798C File Offset: 0x00045B8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class116 class116_2)
		{
			this.class116_0 = class116_2;
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x00047995 File Offset: 0x00045B95
		[CompilerGenerated]
		internal Control10 vmethod_12()
		{
			return this.control10_0;
		}

		// Token: 0x06007250 RID: 29264 RVA: 0x003D6050 File Offset: 0x003D4250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control10 control10_1)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control10 control = this.control10_0;
			if (control != null)
			{
				control.TextChanged -= value;
			}
			this.control10_0 = control10_1;
			control = this.control10_0;
			if (control != null)
			{
				control.TextChanged += value;
			}
		}

		// Token: 0x06007251 RID: 29265 RVA: 0x0004799D File Offset: 0x00045B9D
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_1;
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x000479A5 File Offset: 0x00045BA5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_2)
		{
			this.class116_1 = class116_2;
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x000479AE File Offset: 0x00045BAE
		[CompilerGenerated]
		internal Control9 vmethod_16()
		{
			return this.control9_0;
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x003D6094 File Offset: 0x003D4294
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control9 control9_1)
		{
			EventHandler value = new EventHandler(this.method_5);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_1;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007255 RID: 29269 RVA: 0x000479B6 File Offset: 0x00045BB6
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_18()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06007256 RID: 29270 RVA: 0x000479BE File Offset: 0x00045BBE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06007257 RID: 29271 RVA: 0x000479C7 File Offset: 0x00045BC7
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_20()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06007258 RID: 29272 RVA: 0x000479CF File Offset: 0x00045BCF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06007259 RID: 29273 RVA: 0x000479D8 File Offset: 0x00045BD8
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_22()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x0600725A RID: 29274 RVA: 0x000479E0 File Offset: 0x00045BE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x0600725B RID: 29275 RVA: 0x000479E9 File Offset: 0x00045BE9
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_24()
		{
			return this.dataGridViewTextBoxColumn_7;
		}

		// Token: 0x0600725C RID: 29276 RVA: 0x000479F1 File Offset: 0x00045BF1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x0600725D RID: 29277 RVA: 0x000479FA File Offset: 0x00045BFA
		[CompilerGenerated]
		internal Control11 vmethod_26()
		{
			return this.control11_0;
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x00047A02 File Offset: 0x00045C02
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Control11 control11_1)
		{
			this.control11_0 = control11_1;
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x00047A0B File Offset: 0x00045C0B
		[CompilerGenerated]
		private BackgroundWorker vmethod_28()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x06007260 RID: 29280 RVA: 0x003D60D8 File Offset: 0x003D42D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_29(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler doWorkEventHandler = new DoWorkEventHandler(this.method_6);
			RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(this.method_7);
			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted -= runWorkerCompletedEventHandler;
			}
			this.backgroundWorker_0 = backgroundWorker_1;
			backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted += runWorkerCompletedEventHandler;
			}
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x00047A13 File Offset: 0x00045C13
		[CompilerGenerated]
		private ObservableList<SatPredictionForm.Class2484> vmethod_30()
		{
			return this.observableList_0;
		}

		// Token: 0x06007262 RID: 29282 RVA: 0x003D6138 File Offset: 0x003D4338
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_31(ObservableList<SatPredictionForm.Class2484> observableList_1)
		{
			EventHandler<EventArgs5<SatPredictionForm.Class2484>> eventHandler_ = new EventHandler<EventArgs5<SatPredictionForm.Class2484>>(this.method_8);
			ObservableList<SatPredictionForm.Class2484> observableList = this.observableList_0;
			if (observableList != null)
			{
				observableList.method_1(eventHandler_);
			}
			this.observableList_0 = observableList_1;
			observableList = this.observableList_0;
			if (observableList != null)
			{
				observableList.method_0(eventHandler_);
			}
		}

		// Token: 0x06007263 RID: 29283 RVA: 0x003D617C File Offset: 0x003D437C
		public void method_3()
		{
			if (!this.bool_3)
			{
				this.vmethod_16().Text = "Calculating...";
				this.vmethod_16().Enabled = false;
				this.vmethod_12().Enabled = false;
				this.vmethod_0().Rows.Clear();
				this.vmethod_29(new BackgroundWorker());
				this.vmethod_28().WorkerSupportsCancellation = true;
				this.vmethod_28().RunWorkerAsync();
			}
		}

		// Token: 0x06007264 RID: 29284 RVA: 0x00047A1B File Offset: 0x00045C1B
		private void method_4(object sender, EventArgs e)
		{
			this.int_0 = this.vmethod_12().Value;
		}

		// Token: 0x06007265 RID: 29285 RVA: 0x00047A2E File Offset: 0x00045C2E
		private void method_5(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06007266 RID: 29286 RVA: 0x00047A36 File Offset: 0x00045C36
		private void SatPredictionForm_Shown(object sender, EventArgs e)
		{
			this.int_0 = 3;
			this.vmethod_12().Value = this.int_0;
			this.method_3();
		}

		// Token: 0x06007267 RID: 29287 RVA: 0x003D61EC File Offset: 0x003D43EC
		private void method_6(object sender, DoWorkEventArgs e)
		{
			try
			{
				this.bool_3 = true;
				Geopoint_Struct geopoint_Struct_ = new Geopoint_Struct(this.double_0, this.double_1);
				Unit unit = new Unit();
				bool flag = false;
				this.vmethod_31(new ObservableList<SatPredictionForm.Class2484>());
				int num = this.int_0 * 24 * 3600;
				this.int_1 = Enumerable.Count<ActiveUnit>(Enumerable.Where<ActiveUnit>(Client.smethod_46().method_42(), (SatPredictionForm._Closure$__.$I79-0 == null) ? (SatPredictionForm._Closure$__.$I79-0 = new Func<ActiveUnit, bool>(SatPredictionForm._Closure$__.$I.method_0)) : SatPredictionForm._Closure$__.$I79-0)) * (num - 15);
				this.int_2 = 0;
				try
				{
					foreach (ActiveUnit activeUnit in Client.smethod_46().method_42())
					{
						if (!Information.IsNothing(activeUnit) && activeUnit.method_1())
						{
							Satellite satellite = (Satellite)activeUnit;
							float num2 = Enumerable.Max(Enumerable.Select<Sensor, float>(satellite.method_78(), (SatPredictionForm._Closure$__.$I79-1 == null) ? (SatPredictionForm._Closure$__.$I79-1 = new Func<Sensor, float>(SatPredictionForm._Closure$__.$I.method_1)) : SatPredictionForm._Closure$__.$I79-1));
							int num3 = num;
							for (int i = 15; i <= num3; i++)
							{
								if (this.vmethod_28().CancellationPending)
								{
									return;
								}
								DateTime dateTime = Client.smethod_46().method_31().AddSeconds((double)i);
								Class201 @class = satellite.method_142();
								DateTime dateTime_ = dateTime;
								Unit unit3;
								Unit unit2 = unit3 = unit;
								bool? hintIsOperating = null;
								double value = unit2.vmethod_30(hintIsOperating);
								Unit unit5;
								Unit unit4 = unit5 = unit;
								bool? hintIsOperating2 = null;
								double value2 = unit4.vmethod_28(hintIsOperating2);
								float num5;
								double num4 = (double)num5;
								double num6;
								@class.method_21(dateTime_, ref value, ref value2, ref num6, ref num4);
								num5 = (float)num4;
								unit5.vmethod_29(hintIsOperating2, value2);
								unit3.vmethod_31(hintIsOperating, value);
								unit.vmethod_15(false, (float)(num6 * 1000.0));
								if (unit.method_26(geopoint_Struct_) < num2)
								{
									if (!flag)
									{
										SatPredictionForm.Class2484 class2 = new SatPredictionForm.Class2484();
										class2.satellite_0 = satellite;
										class2.dateTime_0 = dateTime;
										class2.long_0 = 0L;
										flag = true;
									}
									else
									{
										SatPredictionForm.Class2484 class2;
										SatPredictionForm.Class2484 class3 = class2;
										ref long ptr = ref class3.long_0;
										class3.long_0 = ptr + 15L;
									}
								}
								else if (flag)
								{
									SatPredictionForm.Class2484 class2;
									SatPredictionForm.Class2484 class4 = class2;
									ref long ptr = ref class4.long_0;
									class4.long_0 = ptr + 15L;
									this.vmethod_30().method_4(class2);
									flag = false;
								}
								this.int_2++;
							}
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200403", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.bool_3 = false;
			}
		}

		// Token: 0x06007268 RID: 29288 RVA: 0x003D64D0 File Offset: 0x003D46D0
		private void method_7(object sender, RunWorkerCompletedEventArgs e)
		{
			try
			{
				this.vmethod_16().Text = "Recalculate";
				this.vmethod_16().Enabled = true;
				this.vmethod_12().Enabled = true;
				this.vmethod_26().Value = 100;
				this.bool_3 = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200404", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.bool_3 = false;
			}
		}

		// Token: 0x06007269 RID: 29289 RVA: 0x00047A56 File Offset: 0x00045C56
		private void SatPredictionForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.vmethod_28().CancelAsync();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600726A RID: 29290 RVA: 0x00044489 File Offset: 0x00042689
		private void SatPredictionForm_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x0600726B RID: 29291 RVA: 0x003D656C File Offset: 0x003D476C
		private void method_8(object sender, EventArgs5<SatPredictionForm.Class2484> e)
		{
			try
			{
				foreach (SatPredictionForm.Class2484 @class in e.method_0())
				{
					SatPredictionForm.Class2485 class2 = new SatPredictionForm.Class2485(class2);
					class2.satPredictionForm_0 = this;
					class2.dataGridViewRow_0 = new DataGridViewRow();
					class2.dataGridViewRow_0.CreateCells(this.vmethod_0());
					class2.dataGridViewRow_0.Cells[0].Value = @class.satellite_0.Name + " (" + @class.satellite_0.string_2 + ")";
					class2.dataGridViewRow_0.Cells[1].Value = @class.satellite_0.vmethod_7(false).method_51();
					class2.dataGridViewRow_0.Cells[2].Value = Strings.Format(@class.dateTime_0, "yyyy/MM/dd HH:mm:ss") + " (" + Misc.smethod_11((long)Math.Round((@class.dateTime_0 - Client.smethod_46().method_31()).TotalSeconds), Aircraft_AirOps.Enum44.const_0, false, false) + " from now)";
					class2.dataGridViewRow_0.Cells[3].Value = Misc.smethod_11(@class.long_0, Aircraft_AirOps.Enum44.const_0, false, false);
					base.Invoke(new VB$AnonymousDelegate_0(class2.method_0));
				}
			}
			finally
			{
				IEnumerator<SatPredictionForm.Class2484> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x04004060 RID: 16480
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x04004061 RID: 16481
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004062 RID: 16482
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004063 RID: 16483
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04004064 RID: 16484
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04004065 RID: 16485
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004066 RID: 16486
		[CompilerGenerated]
		[AccessedThroughProperty("NumericUpDown1")]
		private Control10 control10_0;

		// Token: 0x04004067 RID: 16487
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_1;

		// Token: 0x04004068 RID: 16488
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x04004069 RID: 16489
		[CompilerGenerated]
		[AccessedThroughProperty("Satellite")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x0400406A RID: 16490
		[CompilerGenerated]
		[AccessedThroughProperty("Side")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x0400406B RID: 16491
		[AccessedThroughProperty("CoverageStart")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x0400406C RID: 16492
		[AccessedThroughProperty("DwellTime")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x0400406D RID: 16493
		[CompilerGenerated]
		[AccessedThroughProperty("DarkUIProgressBar1")]
		private Control11 control11_0;

		// Token: 0x0400406E RID: 16494
		public double double_0;

		// Token: 0x0400406F RID: 16495
		public double double_1;

		// Token: 0x04004070 RID: 16496
		private int int_0;

		// Token: 0x04004071 RID: 16497
		[CompilerGenerated]
		[AccessedThroughProperty("theBW")]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04004072 RID: 16498
		[AccessedThroughProperty("CovRecords")]
		[CompilerGenerated]
		private ObservableList<SatPredictionForm.Class2484> observableList_0;

		// Token: 0x04004073 RID: 16499
		private bool bool_3;

		// Token: 0x04004074 RID: 16500
		private int int_1;

		// Token: 0x04004075 RID: 16501
		private int int_2;

		// Token: 0x02000E7F RID: 3711
		private sealed class Class2484
		{
			// Token: 0x04004076 RID: 16502
			public Satellite satellite_0;

			// Token: 0x04004077 RID: 16503
			public DateTime dateTime_0;

			// Token: 0x04004078 RID: 16504
			public long long_0;
		}

		// Token: 0x02000E81 RID: 3713
		[CompilerGenerated]
		internal sealed class Class2485
		{
			// Token: 0x06007271 RID: 29297 RVA: 0x00047A86 File Offset: 0x00045C86
			public Class2485(SatPredictionForm.Class2485 class2485_0)
			{
				if (class2485_0 != null)
				{
					this.dataGridViewRow_0 = class2485_0.dataGridViewRow_0;
				}
			}

			// Token: 0x06007272 RID: 29298 RVA: 0x003D66EC File Offset: 0x003D48EC
			internal void method_0()
			{
				this.satPredictionForm_0.vmethod_0().Rows.Add(this.dataGridViewRow_0);
				this.satPredictionForm_0.vmethod_26().Value = (int)Math.Round(100.0 * ((double)this.satPredictionForm_0.int_2 / (double)this.satPredictionForm_0.int_1));
			}

			// Token: 0x0400407C RID: 16508
			public DataGridViewRow dataGridViewRow_0;

			// Token: 0x0400407D RID: 16509
			public SatPredictionForm satPredictionForm_0;
		}
	}
}
