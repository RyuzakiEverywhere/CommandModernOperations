using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000F08 RID: 3848
	[DesignerGenerated]
	public sealed partial class MultipleUnitSensors : DarkSecondaryFormBase
	{
		// Token: 0x060088A6 RID: 34982 RVA: 0x004926AC File Offset: 0x004908AC
		public MultipleUnitSensors()
		{
			base.Load += this.MultipleUnitSensors_Load;
			base.KeyDown += this.MultipleUnitSensors_KeyDown;
			base.FormClosing += this.MultipleUnitSensors_FormClosing;
			this.list_1 = new List<Sensor>();
			this.list_2 = new List<Sensor>();
			this.list_3 = new List<Sensor>();
			this.InitializeComponent_1();
		}

		// Token: 0x060088A8 RID: 34984 RVA: 0x0049275C File Offset: 0x0049095C
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class112());
			this.vmethod_3(new Class112());
			this.vmethod_5(new Class112());
			this.vmethod_7(new Class116());
			base.SuspendLayout();
			this.vmethod_0().AutoSize = true;
			this.vmethod_0().CheckAlign = ContentAlignment.MiddleRight;
			this.vmethod_0().Location = new Point(8, 31);
			this.vmethod_0().Name = "CB_radar";
			this.vmethod_0().RightToLeft = RightToLeft.Yes;
			this.vmethod_0().Size = new Size(61, 19);
			this.vmethod_0().TabIndex = 4;
			this.vmethod_0().Text = "Radars";
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().CheckAlign = ContentAlignment.MiddleRight;
			this.vmethod_2().Location = new Point(83, 31);
			this.vmethod_2().Name = "CB_Sonar";
			this.vmethod_2().RightToLeft = RightToLeft.Yes;
			this.vmethod_2().Size = new Size(61, 19);
			this.vmethod_2().TabIndex = 5;
			this.vmethod_2().Text = "Sonars";
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().CheckAlign = ContentAlignment.MiddleRight;
			this.vmethod_4().Location = new Point(151, 31);
			this.vmethod_4().Name = "CB_ECM";
			this.vmethod_4().RightToLeft = RightToLeft.Yes;
			this.vmethod_4().Size = new Size(104, 19);
			this.vmethod_4().TabIndex = 6;
			this.vmethod_4().Text = "Offensive ECM";
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(5, 5);
			this.vmethod_6().Name = "Label1";
			this.vmethod_6().Size = new Size(115, 23);
			this.vmethod_6().TabIndex = 7;
			this.vmethod_6().Text = "(Checked = Active)";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(251, 55);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MultipleUnitSensors";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Multiple unit sensors";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060088A9 RID: 34985 RVA: 0x00052165 File Offset: 0x00050365
		[CompilerGenerated]
		internal Class112 vmethod_0()
		{
			return this.class112_0;
		}

		// Token: 0x060088AA RID: 34986 RVA: 0x00492A2C File Offset: 0x00490C2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class112 class112_3)
		{
			EventHandler value = new EventHandler(this.method_4);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_0 = class112_3;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060088AB RID: 34987 RVA: 0x0005216D File Offset: 0x0005036D
		[CompilerGenerated]
		internal Class112 vmethod_2()
		{
			return this.class112_1;
		}

		// Token: 0x060088AC RID: 34988 RVA: 0x00492A70 File Offset: 0x00490C70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class112 class112_3)
		{
			EventHandler value = new EventHandler(this.method_5);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_1 = class112_3;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060088AD RID: 34989 RVA: 0x00052175 File Offset: 0x00050375
		[CompilerGenerated]
		internal Class112 vmethod_4()
		{
			return this.class112_2;
		}

		// Token: 0x060088AE RID: 34990 RVA: 0x00492AB4 File Offset: 0x00490CB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class112 class112_3)
		{
			EventHandler value = new EventHandler(this.method_6);
			Class112 @class = this.class112_2;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_2 = class112_3;
			@class = this.class112_2;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060088AF RID: 34991 RVA: 0x0005217D File Offset: 0x0005037D
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_0;
		}

		// Token: 0x060088B0 RID: 34992 RVA: 0x00052185 File Offset: 0x00050385
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x060088B1 RID: 34993 RVA: 0x00492AF8 File Offset: 0x00490CF8
		private void MultipleUnitSensors_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (!Information.IsNothing(Client.smethod_58()))
			{
				if (Operators.CompareString(Client.smethod_58().Name, "", false) == 0)
				{
					this.Text = "Sensors for: Navigation Waypoint";
				}
				else
				{
					this.Text = "Sensors for: " + Client.smethod_58().Name;
				}
			}
			else if (Client.smethod_54().bool_0)
			{
				this.Text = "Multiple sensors for: " + Client.smethod_54().Name;
			}
			if (!Information.IsNothing(Client.smethod_58()))
			{
				if (Client.smethod_58().method_18().method_7())
				{
					this.vmethod_0().CheckState = CheckState.Indeterminate;
				}
				else if (Client.smethod_58().method_18().method_6(Client.smethod_46()).method_1() == Doctrine.Class275.Enum66.const_1)
				{
					this.vmethod_0().Checked = true;
				}
				else if (Client.smethod_58().method_18().method_6(Client.smethod_46()).method_1() == Doctrine.Class275.Enum66.const_3)
				{
					this.vmethod_0().CheckState = CheckState.Indeterminate;
				}
				else
				{
					this.vmethod_0().Checked = false;
				}
				if (Client.smethod_58().method_18().method_7())
				{
					this.vmethod_2().CheckState = CheckState.Indeterminate;
				}
				else if (Client.smethod_58().method_18().method_6(Client.smethod_46()).method_2() == Doctrine.Class275.Enum66.const_1)
				{
					this.vmethod_2().Checked = true;
				}
				else if (Client.smethod_58().method_18().method_6(Client.smethod_46()).method_2() == Doctrine.Class275.Enum66.const_3)
				{
					this.vmethod_2().CheckState = CheckState.Indeterminate;
				}
				else
				{
					this.vmethod_2().Checked = false;
				}
				if (Client.smethod_58().method_18().method_7())
				{
					this.vmethod_4().CheckState = CheckState.Indeterminate;
					return;
				}
				if (Client.smethod_58().method_18().method_6(Client.smethod_46()).method_3() == Doctrine.Class275.Enum66.const_1)
				{
					this.vmethod_4().Checked = true;
					return;
				}
				if (Client.smethod_58().method_18().method_6(Client.smethod_46()).method_3() == Doctrine.Class275.Enum66.const_3)
				{
					this.vmethod_4().CheckState = CheckState.Indeterminate;
					return;
				}
				this.vmethod_4().Checked = false;
				return;
			}
			else
			{
				this.ienumerable_0 = Enumerable.Where<Unit>(this.list_0, (MultipleUnitSensors._Closure$__.$I25-0 == null) ? (MultipleUnitSensors._Closure$__.$I25-0 = new Func<Unit, bool>(MultipleUnitSensors._Closure$__.$I.method_0)) : MultipleUnitSensors._Closure$__.$I25-0);
				try
				{
					foreach (Unit unit in this.ienumerable_0)
					{
						foreach (Sensor sensor in ((ActiveUnit)unit).vmethod_96())
						{
							if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								this.list_1.Add(sensor);
							}
						}
					}
				}
				finally
				{
					IEnumerator<Unit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				IEnumerable<Sensor> enumerable = Enumerable.Where<Sensor>(this.list_1, (MultipleUnitSensors._Closure$__.$I25-1 == null) ? (MultipleUnitSensors._Closure$__.$I25-1 = new Func<Sensor, bool>(MultipleUnitSensors._Closure$__.$I.method_1)) : MultipleUnitSensors._Closure$__.$I25-1);
				if (Enumerable.Count<Sensor>(enumerable) == 0)
				{
					this.vmethod_0().Checked = false;
				}
				else if (Enumerable.Count<Sensor>(enumerable) == this.list_1.Count)
				{
					this.vmethod_0().Checked = true;
				}
				else
				{
					this.vmethod_0().CheckState = CheckState.Indeterminate;
				}
				try
				{
					foreach (Unit unit2 in this.ienumerable_0)
					{
						foreach (Sensor sensor2 in ((ActiveUnit)unit2).vmethod_96())
						{
							if (sensor2.method_74())
							{
								this.list_2.Add(sensor2);
							}
						}
					}
				}
				finally
				{
					IEnumerator<Unit> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				IEnumerable<Sensor> enumerable2 = Enumerable.Where<Sensor>(this.list_2, (MultipleUnitSensors._Closure$__.$I25-2 == null) ? (MultipleUnitSensors._Closure$__.$I25-2 = new Func<Sensor, bool>(MultipleUnitSensors._Closure$__.$I.method_2)) : MultipleUnitSensors._Closure$__.$I25-2);
				if (Enumerable.Count<Sensor>(enumerable2) == 0)
				{
					this.vmethod_2().Checked = false;
				}
				else if (Enumerable.Count<Sensor>(enumerable2) == this.list_2.Count)
				{
					this.vmethod_2().Checked = true;
				}
				else
				{
					this.vmethod_2().CheckState = CheckState.Indeterminate;
				}
				try
				{
					foreach (Unit unit3 in this.ienumerable_0)
					{
						foreach (Sensor sensor3 in ((ActiveUnit)unit3).vmethod_96())
						{
							if (sensor3.method_72())
							{
								this.list_3.Add(sensor3);
							}
						}
					}
				}
				finally
				{
					IEnumerator<Unit> enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
				IEnumerable<Sensor> enumerable3 = Enumerable.Where<Sensor>(this.list_3, (MultipleUnitSensors._Closure$__.$I25-3 == null) ? (MultipleUnitSensors._Closure$__.$I25-3 = new Func<Sensor, bool>(MultipleUnitSensors._Closure$__.$I.method_3)) : MultipleUnitSensors._Closure$__.$I25-3);
				if (Enumerable.Count<Sensor>(enumerable3) == 0)
				{
					this.vmethod_4().Checked = false;
					return;
				}
				if (Enumerable.Count<Sensor>(enumerable3) == this.list_3.Count)
				{
					this.vmethod_4().Checked = true;
					return;
				}
				this.vmethod_4().CheckState = CheckState.Indeterminate;
				return;
			}
		}

		// Token: 0x060088B2 RID: 34994 RVA: 0x0005218E File Offset: 0x0005038E
		private bool method_3()
		{
			return DarkMessageBox.smethod_1("Override strict obedience to EMCON settings if present?", "Override EMCON?", Enum11.const_3) == DialogResult.Yes;
		}

		// Token: 0x060088B3 RID: 34995 RVA: 0x00493008 File Offset: 0x00491208
		private void method_4(object sender, EventArgs e)
		{
			if (Information.IsNothing(Client.smethod_58()))
			{
				bool flag = this.method_3();
				bool @checked;
				if (@checked = this.vmethod_0().Checked)
				{
					if (!@checked)
					{
						goto IL_1ED;
					}
					try
					{
						foreach (Sensor sensor in this.list_1)
						{
							if (!(sensor.method_18().vmethod_88().vmethod_3() & !flag))
							{
								sensor.method_18().vmethod_88().vmethod_4(false);
								if (!sensor.method_49() && !sensor.method_43())
								{
									sensor.method_77();
								}
							}
						}
						goto IL_1ED;
					}
					finally
					{
						List<Sensor>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				try
				{
					foreach (Sensor sensor2 in this.list_1)
					{
						if (!(sensor2.method_18().vmethod_88().vmethod_3() & !flag))
						{
							sensor2.method_18().vmethod_88().vmethod_4(false);
							if (!sensor2.method_49() && sensor2.method_43())
							{
								sensor2.method_78();
							}
						}
					}
				}
				finally
				{
					List<Sensor>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				IL_1ED:
				Client.bool_1 = true;
				return;
			}
			this.vmethod_0().method_1(true);
			switch (this.vmethod_0().CheckState)
			{
			case CheckState.Unchecked:
				Client.smethod_58().method_18().method_8(false);
				Client.smethod_58().method_18().method_192(Doctrine.Class275.Enum66.const_0, Client.smethod_46());
				return;
			case CheckState.Checked:
				Client.smethod_58().method_18().method_8(false);
				Client.smethod_58().method_18().method_192(Doctrine.Class275.Enum66.const_1, Client.smethod_46());
				return;
			case CheckState.Indeterminate:
				if (Client.smethod_58().method_18().method_6(Client.smethod_46()).method_2() == Doctrine.Class275.Enum66.const_3 && Client.smethod_58().method_18().method_6(Client.smethod_46()).method_3() == Doctrine.Class275.Enum66.const_3)
				{
					Client.smethod_58().method_18().method_8(true);
				}
				Client.smethod_58().method_18().method_192(Doctrine.Class275.Enum66.const_3, Client.smethod_46());
				return;
			default:
				return;
			}
		}

		// Token: 0x060088B4 RID: 34996 RVA: 0x00493224 File Offset: 0x00491424
		private void method_5(object sender, EventArgs e)
		{
			if (Information.IsNothing(Client.smethod_58()))
			{
				bool flag = this.method_3();
				bool @checked;
				if (@checked = this.vmethod_2().Checked)
				{
					if (!@checked)
					{
						goto IL_1D1;
					}
					try
					{
						foreach (Sensor sensor in this.list_2)
						{
							if (!(sensor.method_18().vmethod_88().vmethod_3() & !flag) && !sensor.method_49() && (!sensor.method_43() & sensor.method_58()))
							{
								sensor.method_77();
							}
						}
						goto IL_1D1;
					}
					finally
					{
						List<Sensor>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				try
				{
					foreach (Sensor sensor2 in this.list_2)
					{
						if (!(sensor2.method_18().vmethod_88().vmethod_3() & !flag) && !sensor2.method_49() && sensor2.method_43())
						{
							sensor2.method_78();
						}
					}
				}
				finally
				{
					List<Sensor>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				IL_1D1:
				Client.bool_1 = true;
				return;
			}
			this.vmethod_2().method_1(true);
			switch (this.vmethod_2().CheckState)
			{
			case CheckState.Unchecked:
				Client.smethod_58().method_18().method_8(false);
				Client.smethod_58().method_18().method_193(Doctrine.Class275.Enum66.const_0, Client.smethod_46());
				return;
			case CheckState.Checked:
				Client.smethod_58().method_18().method_8(false);
				Client.smethod_58().method_18().method_193(Doctrine.Class275.Enum66.const_1, Client.smethod_46());
				return;
			case CheckState.Indeterminate:
				if (Client.smethod_58().method_18().method_6(Client.smethod_46()).method_1() == Doctrine.Class275.Enum66.const_3 && Client.smethod_58().method_18().method_6(Client.smethod_46()).method_3() == Doctrine.Class275.Enum66.const_3)
				{
					Client.smethod_58().method_18().method_8(true);
				}
				Client.smethod_58().method_18().method_193(Doctrine.Class275.Enum66.const_3, Client.smethod_46());
				return;
			default:
				return;
			}
		}

		// Token: 0x060088B5 RID: 34997 RVA: 0x00493424 File Offset: 0x00491624
		private void method_6(object sender, EventArgs e)
		{
			if (Information.IsNothing(Client.smethod_58()))
			{
				bool flag = this.method_3();
				bool @checked;
				if (@checked = this.vmethod_4().Checked)
				{
					if (!@checked)
					{
						goto IL_1B4;
					}
					try
					{
						foreach (Sensor sensor in this.list_3)
						{
							if (!(sensor.method_18().vmethod_88().vmethod_3() & !flag) && !sensor.method_43())
							{
								sensor.method_77();
							}
						}
						goto IL_1B4;
					}
					finally
					{
						List<Sensor>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				try
				{
					foreach (Sensor sensor2 in this.list_3)
					{
						if (!(sensor2.method_18().vmethod_88().vmethod_3() & !flag) && sensor2.method_43())
						{
							sensor2.method_78();
						}
					}
				}
				finally
				{
					List<Sensor>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				IL_1B4:
				Client.bool_1 = true;
				return;
			}
			this.vmethod_4().method_1(true);
			switch (this.vmethod_4().CheckState)
			{
			case CheckState.Unchecked:
				Client.smethod_58().method_18().method_8(false);
				Client.smethod_58().method_18().method_194(Doctrine.Class275.Enum66.const_0, Client.smethod_46());
				return;
			case CheckState.Checked:
				Client.smethod_58().method_18().method_8(false);
				Client.smethod_58().method_18().method_194(Doctrine.Class275.Enum66.const_1, Client.smethod_46());
				return;
			case CheckState.Indeterminate:
				if (Client.smethod_58().method_18().method_6(Client.smethod_46()).method_1() == Doctrine.Class275.Enum66.const_3 && Client.smethod_58().method_18().method_6(Client.smethod_46()).method_2() == Doctrine.Class275.Enum66.const_3)
				{
					Client.smethod_58().method_18().method_8(true);
				}
				Client.smethod_58().method_18().method_194(Doctrine.Class275.Enum66.const_3, Client.smethod_46());
				return;
			default:
				return;
			}
		}

		// Token: 0x060088B6 RID: 34998 RVA: 0x00493608 File Offset: 0x00491808
		private void MultipleUnitSensors_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F9 && base.Visible)
			{
				base.Close();
				return;
			}
			if (!base.Visible || (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Space))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060088B7 RID: 34999 RVA: 0x00044820 File Offset: 0x00042A20
		private void MultipleUnitSensors_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x04004A44 RID: 19012
		[CompilerGenerated]
		[AccessedThroughProperty("CB_radar")]
		private Class112 class112_0;

		// Token: 0x04004A45 RID: 19013
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Sonar")]
		private Class112 class112_1;

		// Token: 0x04004A46 RID: 19014
		[CompilerGenerated]
		[AccessedThroughProperty("CB_ECM")]
		private Class112 class112_2;

		// Token: 0x04004A47 RID: 19015
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004A48 RID: 19016
		public List<Unit> list_0;

		// Token: 0x04004A49 RID: 19017
		private List<Sensor> list_1;

		// Token: 0x04004A4A RID: 19018
		private List<Sensor> list_2;

		// Token: 0x04004A4B RID: 19019
		private List<Sensor> list_3;

		// Token: 0x04004A4C RID: 19020
		private IEnumerable<Unit> ienumerable_0;
	}
}
