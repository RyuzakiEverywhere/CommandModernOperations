using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns7
{
	// Token: 0x02000F07 RID: 3847
	[DesignerGenerated]
	internal sealed partial class MinefieldForm : DarkSecondaryFormBase
	{
		// Token: 0x0600888F RID: 34959 RVA: 0x00491D34 File Offset: 0x0048FF34
		public MinefieldForm()
		{
			base.Load += this.MinefieldForm_Load;
			base.KeyDown += this.MinefieldForm_KeyDown;
			base.FormClosing += this.MinefieldForm_FormClosing;
			this.list_0 = new List<ReferencePoint>();
			this.dataTable_0 = new DataTable();
			this.vmethod_13(new BackgroundWorker());
			this.InitializeComponent_1();
		}

		// Token: 0x06008891 RID: 34961 RVA: 0x00491DE4 File Offset: 0x0048FFE4
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class116());
			this.vmethod_3(new Class2451());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Control10());
			this.vmethod_9(new Control9());
			this.vmethod_11(new Control11());
			base.SuspendLayout();
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(13, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(34, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Type:";
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_2().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_2().Font = new Font("Segoe UI", 10f);
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Location = new Point(82, 10);
			this.vmethod_2().Name = "CB_Weapon";
			this.vmethod_2().Size = new Size(392, 26);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(13, 44);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new Size(60, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "How many:";
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().Font = new Font("Segoe UI", 10f);
			this.vmethod_6().Location = new Point(82, 37);
			this.vmethod_6().method_1(100);
			this.vmethod_6().method_3(1);
			this.vmethod_6().Name = "NumericUpDown1";
			this.vmethod_6().Size = new Size(124, 26);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Value = 1;
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DialogResult = DialogResult.None;
			this.vmethod_8().Font = new Font("Segoe UI", 10f);
			this.vmethod_8().ForeColor = SystemColors.Control;
			this.vmethod_8().Location = new Point(399, 37);
			this.vmethod_8().Name = "Button1";
			this.vmethod_8().method_1(0);
			this.vmethod_8().Size = new Size(75, 29);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "ADD";
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().Font = new Font("Segoe UI", 9f);
			this.vmethod_10().Location = new Point(16, 72);
			this.vmethod_10().method_1(100);
			this.vmethod_10().Name = "ProgressBar1";
			this.vmethod_10().method_3(true);
			this.vmethod_10().method_5(false);
			this.vmethod_10().Size = new Size(458, 12);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_10().Value = 0;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(486, 95);
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MinefieldForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Add mines in designated area";
			base.ResumeLayout(false);
		}

		// Token: 0x06008892 RID: 34962 RVA: 0x00052100 File Offset: 0x00050300
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x06008893 RID: 34963 RVA: 0x00052108 File Offset: 0x00050308
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_2)
		{
			this.class116_0 = class116_2;
		}

		// Token: 0x06008894 RID: 34964 RVA: 0x00052111 File Offset: 0x00050311
		[CompilerGenerated]
		internal Class2451 vmethod_2()
		{
			return this.class2451_0;
		}

		// Token: 0x06008895 RID: 34965 RVA: 0x00052119 File Offset: 0x00050319
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class2451 class2451_1)
		{
			this.class2451_0 = class2451_1;
		}

		// Token: 0x06008896 RID: 34966 RVA: 0x00052122 File Offset: 0x00050322
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x06008897 RID: 34967 RVA: 0x0005212A File Offset: 0x0005032A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_2)
		{
			this.class116_1 = class116_2;
		}

		// Token: 0x06008898 RID: 34968 RVA: 0x00052133 File Offset: 0x00050333
		[CompilerGenerated]
		internal Control10 vmethod_6()
		{
			return this.control10_0;
		}

		// Token: 0x06008899 RID: 34969 RVA: 0x0005213B File Offset: 0x0005033B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control10 control10_1)
		{
			this.control10_0 = control10_1;
		}

		// Token: 0x0600889A RID: 34970 RVA: 0x00052144 File Offset: 0x00050344
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_0;
		}

		// Token: 0x0600889B RID: 34971 RVA: 0x00492258 File Offset: 0x00490458
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control9 control9_1)
		{
			EventHandler value = new EventHandler(this.method_3);
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

		// Token: 0x0600889C RID: 34972 RVA: 0x0005214C File Offset: 0x0005034C
		[CompilerGenerated]
		internal Control11 vmethod_10()
		{
			return this.control11_0;
		}

		// Token: 0x0600889D RID: 34973 RVA: 0x00052154 File Offset: 0x00050354
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control11 control11_1)
		{
			this.control11_0 = control11_1;
		}

		// Token: 0x0600889E RID: 34974 RVA: 0x0005215D File Offset: 0x0005035D
		[CompilerGenerated]
		private BackgroundWorker vmethod_12()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x0600889F RID: 34975 RVA: 0x0049229C File Offset: 0x0049049C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_13(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler doWorkEventHandler = new DoWorkEventHandler(this.method_4);
			RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(this.method_5);
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

		// Token: 0x060088A0 RID: 34976 RVA: 0x004922FC File Offset: 0x004904FC
		private void MinefieldForm_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			bool bool_ = true;
			Scenario scenario = Client.smethod_46();
			SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
			this.dataTable_0 = DBFunctions.smethod_72(bool_, ref scenario, ref sqliteConnection);
			if (!this.dataTable_0.Columns.Contains("FullName"))
			{
				this.dataTable_0.Columns.Add("FullName", typeof(string));
			}
			try
			{
				foreach (object obj in this.dataTable_0.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (Client.smethod_46().FeatureCompatibility.get_WeaponAGL_ASL(Client.smethod_46().method_39()))
					{
						dataRow["FullName"] = string.Concat(new string[]
						{
							Strings.Trim(Conversions.ToString(dataRow["Name"])),
							" [",
							Conversions.ToString(Math.Abs(Conversions.ToInteger(dataRow["TargetAltitudeMax_ASL"]))),
							"m - ",
							Conversions.ToString(Math.Abs(Conversions.ToInteger(dataRow["TargetAltitudeMin_ASL"]))),
							"m]"
						});
					}
					else
					{
						dataRow["FullName"] = string.Concat(new string[]
						{
							Strings.Trim(Conversions.ToString(dataRow["Name"])),
							" [",
							Conversions.ToString(Math.Abs(Conversions.ToInteger(dataRow["TargetAltitudeMax"]))),
							"m - ",
							Conversions.ToString(Math.Abs(Conversions.ToInteger(dataRow["TargetAltitudeMin"]))),
							"m]"
						});
					}
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
			this.dataView_0 = new DataView(this.dataTable_0);
			this.dataView_0.Sort = "FULLNAME ASC";
			this.dataView_0.RowFilter = "TYPE IN (4004, 4005, 4006, 4007, 4008)";
			this.vmethod_2().DataSource = this.dataView_0;
			this.vmethod_2().DisplayMember = "FullName";
			this.vmethod_2().ValueMember = "ID";
			this.vmethod_10().Visible = false;
		}

		// Token: 0x060088A1 RID: 34977 RVA: 0x00492568 File Offset: 0x00490768
		private void method_3(object sender, EventArgs e)
		{
			this.vmethod_8().Text = "WORKING...";
			this.vmethod_8().Enabled = false;
			this.vmethod_10().Visible = true;
			this.int_0 = Conversions.ToInteger(this.vmethod_2().SelectedValue);
			this.vmethod_12().RunWorkerAsync();
		}

		// Token: 0x060088A2 RID: 34978 RVA: 0x004925C0 File Offset: 0x004907C0
		private void method_4(object sender, DoWorkEventArgs e)
		{
			this.int_1 = this.vmethod_6().Value;
			this.int_2 = 0;
			int num = this.int_1;
			for (int i = 0; i <= num; i++)
			{
				i++;
				if (!Information.IsNothing(Client.smethod_46().method_77(Client.smethod_50(), this.int_0, this.list_0)))
				{
					ref int ptr = ref this.int_2;
					this.int_2 = ptr + 1;
				}
			}
		}

		// Token: 0x060088A3 RID: 34979 RVA: 0x0049262C File Offset: 0x0049082C
		private void method_5(object sender, RunWorkerCompletedEventArgs e)
		{
			this.vmethod_8().Text = "ADD";
			this.vmethod_8().Enabled = true;
			this.vmethod_10().Visible = false;
			Client.bool_1 = true;
			string message;
			if (this.int_1 == this.int_2)
			{
				message = "All mines were successfully laid.";
			}
			else
			{
				message = "Only " + Conversions.ToString(this.int_2) + " of the mines were laid successfully.";
			}
			DarkMessageBox.smethod_0(message, "Mine placement complete!", Enum11.const_0);
		}

		// Token: 0x060088A4 RID: 34980 RVA: 0x000476BE File Offset: 0x000458BE
		private void MinefieldForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x060088A5 RID: 34981 RVA: 0x00044820 File Offset: 0x00042A20
		private void MinefieldForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x04004A36 RID: 18998
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004A37 RID: 18999
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Weapon")]
		private Class2451 class2451_0;

		// Token: 0x04004A38 RID: 19000
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_1;

		// Token: 0x04004A39 RID: 19001
		[CompilerGenerated]
		[AccessedThroughProperty("NumericUpDown1")]
		private Control10 control10_0;

		// Token: 0x04004A3A RID: 19002
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x04004A3B RID: 19003
		[AccessedThroughProperty("ProgressBar1")]
		[CompilerGenerated]
		private Control11 control11_0;

		// Token: 0x04004A3C RID: 19004
		public List<ReferencePoint> list_0;

		// Token: 0x04004A3D RID: 19005
		private DataTable dataTable_0;

		// Token: 0x04004A3E RID: 19006
		private DataView dataView_0;

		// Token: 0x04004A3F RID: 19007
		[AccessedThroughProperty("BW1")]
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04004A40 RID: 19008
		private int int_0;

		// Token: 0x04004A41 RID: 19009
		private int int_1;

		// Token: 0x04004A42 RID: 19010
		private int int_2;
	}
}
