using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns2;
using ns5;

namespace ns4
{
	// Token: 0x02000E25 RID: 3621
	[DesignerGenerated]
	internal sealed partial class FlightPlanTime : DarkSecondaryFormBase
	{
		// Token: 0x06006BF0 RID: 27632 RVA: 0x003B39DC File Offset: 0x003B1BDC
		public FlightPlanTime()
		{
			base.Load += this.FlightPlanTime_Load;
			base.KeyDown += this.FlightPlanTime_KeyDown;
			base.FormClosing += this.FlightPlanTime_FormClosing;
			this.bool_4 = false;
			this.InitializeComponent_1();
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x003B3A74 File Offset: 0x003B1C74
		private void InitializeComponent_1()
		{
			this.vmethod_27(new Class116());
			this.vmethod_13(new Class118());
			this.vmethod_25(new Class116());
			this.vmethod_11(new Class2451());
			this.vmethod_23(new Class116());
			this.vmethod_9(new Class118());
			this.vmethod_21(new Class116());
			this.vmethod_7(new Class118());
			this.vmethod_19(new Class116());
			this.vmethod_5(new Class118());
			this.vmethod_17(new Class116());
			this.vmethod_15(new Class116());
			this.vmethod_3(new Class118());
			this.vmethod_1(new Class118());
			base.SuspendLayout();
			this.vmethod_26().method_2(true);
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Location = new Point(13, 172);
			this.vmethod_26().Name = "Label7";
			this.vmethod_26().Size = new Size(107, 15);
			this.vmethod_26().TabIndex = 22;
			this.vmethod_26().Text = "Aircraft separation:";
			this.vmethod_12().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_12().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(198, 168);
			this.vmethod_12().Name = "DateTimePicker_Separation";
			this.vmethod_12().Size = new Size(115, 23);
			this.vmethod_12().TabIndex = 21;
			this.vmethod_24().method_2(true);
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().Location = new Point(323, 175);
			this.vmethod_24().Name = "Label6";
			this.vmethod_24().Size = new Size(52, 15);
			this.vmethod_24().TabIndex = 20;
			this.vmethod_24().Text = "Method:";
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_10().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_10().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_10().FormattingEnabled = true;
			this.vmethod_10().Location = new Point(381, 169);
			this.vmethod_10().Name = "ComboBox_AttackMethod";
			this.vmethod_10().Size = new Size(121, 21);
			this.vmethod_10().TabIndex = 19;
			this.vmethod_22().method_2(true);
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().Location = new Point(13, 120);
			this.vmethod_22().Name = "Label5";
			this.vmethod_22().Size = new Size(95, 15);
			this.vmethod_22().TabIndex = 18;
			this.vmethod_22().Text = "Station duration:";
			this.vmethod_8().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_8().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(198, 116);
			this.vmethod_8().Name = "DateTimePicker_Station";
			this.vmethod_8().Size = new Size(115, 23);
			this.vmethod_8().TabIndex = 17;
			this.vmethod_20().method_2(true);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Location = new Point(13, 146);
			this.vmethod_20().Name = "Label4";
			this.vmethod_20().Size = new Size(139, 15);
			this.vmethod_20().TabIndex = 16;
			this.vmethod_20().Text = "Spacing maneuver delay:";
			this.vmethod_6().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_6().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(198, 142);
			this.vmethod_6().Name = "DateTimePicker_Spacing";
			this.vmethod_6().Size = new Size(115, 23);
			this.vmethod_6().TabIndex = 15;
			this.vmethod_18().method_2(true);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(13, 95);
			this.vmethod_18().Name = "Label3";
			this.vmethod_18().Size = new Size(84, 15);
			this.vmethod_18().TabIndex = 14;
			this.vmethod_18().Text = "Hold duration:";
			this.vmethod_4().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_4().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(198, 91);
			this.vmethod_4().Name = "DateTimePicker_Hold";
			this.vmethod_4().Size = new Size(115, 23);
			this.vmethod_4().TabIndex = 13;
			this.vmethod_16().method_2(true);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Location = new Point(13, 37);
			this.vmethod_16().Name = "Label1";
			this.vmethod_16().Size = new Size(119, 15);
			this.vmethod_16().TabIndex = 12;
			this.vmethod_16().Text = "Date and time (Zulu):";
			this.vmethod_14().method_2(true);
			this.vmethod_14().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(13, 13);
			this.vmethod_14().Name = "Label2";
			this.vmethod_14().Size = new Size(41, 13);
			this.vmethod_14().TabIndex = 10;
			this.vmethod_14().Text = "Label2";
			this.vmethod_2().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_2().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(198, 61);
			this.vmethod_2().Name = "DateTimePicker_Time";
			this.vmethod_2().Size = new Size(115, 23);
			this.vmethod_2().TabIndex = 3;
			this.vmethod_0().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_0().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(198, 37);
			this.vmethod_0().Name = "DateTimePicker_Date";
			this.vmethod_0().Size = new Size(115, 23);
			this.vmethod_0().TabIndex = 2;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(541, 205);
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new Size(557, 244);
			base.Name = "FlightPlanTime";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Waypoint Time";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x000440E1 File Offset: 0x000422E1
		[CompilerGenerated]
		internal Class118 vmethod_0()
		{
			return this.class118_0;
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x003B4420 File Offset: 0x003B2620
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class118 class118_6)
		{
			EventHandler value = new EventHandler(this.method_18);
			EventHandler value2 = new EventHandler(this.method_19);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_22);
			Class118 @class = this.class118_0;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
				@class.KeyPress -= value3;
			}
			this.class118_0 = class118_6;
			@class = this.class118_0;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
				@class.KeyPress += value3;
			}
		}

		// Token: 0x06006BF5 RID: 27637 RVA: 0x000440E9 File Offset: 0x000422E9
		[CompilerGenerated]
		internal Class118 vmethod_2()
		{
			return this.class118_1;
		}

		// Token: 0x06006BF6 RID: 27638 RVA: 0x003B449C File Offset: 0x003B269C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class118 class118_6)
		{
			EventHandler value = new EventHandler(this.method_7);
			EventHandler value2 = new EventHandler(this.method_8);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_23);
			Class118 @class = this.class118_1;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
				@class.KeyPress -= value3;
			}
			this.class118_1 = class118_6;
			@class = this.class118_1;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
				@class.KeyPress += value3;
			}
		}

		// Token: 0x06006BF7 RID: 27639 RVA: 0x000440F1 File Offset: 0x000422F1
		[CompilerGenerated]
		internal Class118 vmethod_4()
		{
			return this.class118_2;
		}

		// Token: 0x06006BF8 RID: 27640 RVA: 0x003B4518 File Offset: 0x003B2718
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class118 class118_6)
		{
			EventHandler value = new EventHandler(this.method_9);
			EventHandler value2 = new EventHandler(this.method_10);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_24);
			Class118 @class = this.class118_2;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
				@class.KeyPress -= value3;
			}
			this.class118_2 = class118_6;
			@class = this.class118_2;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
				@class.KeyPress += value3;
			}
		}

		// Token: 0x06006BF9 RID: 27641 RVA: 0x000440F9 File Offset: 0x000422F9
		[CompilerGenerated]
		internal Class118 vmethod_6()
		{
			return this.class118_3;
		}

		// Token: 0x06006BFA RID: 27642 RVA: 0x003B4594 File Offset: 0x003B2794
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class118 class118_6)
		{
			EventHandler value = new EventHandler(this.method_13);
			EventHandler value2 = new EventHandler(this.method_14);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_25);
			Class118 @class = this.class118_3;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
				@class.KeyPress -= value3;
			}
			this.class118_3 = class118_6;
			@class = this.class118_3;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
				@class.KeyPress += value3;
			}
		}

		// Token: 0x06006BFB RID: 27643 RVA: 0x00044101 File Offset: 0x00042301
		[CompilerGenerated]
		internal Class118 vmethod_8()
		{
			return this.class118_4;
		}

		// Token: 0x06006BFC RID: 27644 RVA: 0x003B4610 File Offset: 0x003B2810
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class118 class118_6)
		{
			EventHandler value = new EventHandler(this.method_11);
			EventHandler value2 = new EventHandler(this.method_12);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_26);
			Class118 @class = this.class118_4;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
				@class.KeyPress -= value3;
			}
			this.class118_4 = class118_6;
			@class = this.class118_4;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
				@class.KeyPress += value3;
			}
		}

		// Token: 0x06006BFD RID: 27645 RVA: 0x00044109 File Offset: 0x00042309
		[CompilerGenerated]
		internal Class2451 vmethod_10()
		{
			return this.class2451_0;
		}

		// Token: 0x06006BFE RID: 27646 RVA: 0x003B468C File Offset: 0x003B288C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_28);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_1;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06006BFF RID: 27647 RVA: 0x00044111 File Offset: 0x00042311
		[CompilerGenerated]
		internal Class118 vmethod_12()
		{
			return this.class118_5;
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x003B46D0 File Offset: 0x003B28D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class118 class118_6)
		{
			EventHandler value = new EventHandler(this.method_15);
			EventHandler value2 = new EventHandler(this.method_16);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_27);
			Class118 @class = this.class118_5;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.Leave -= value2;
				@class.KeyPress -= value3;
			}
			this.class118_5 = class118_6;
			@class = this.class118_5;
			if (@class != null)
			{
				@class.Enter += value;
				@class.Leave += value2;
				@class.KeyPress += value3;
			}
		}

		// Token: 0x06006C01 RID: 27649 RVA: 0x00044119 File Offset: 0x00042319
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_0;
		}

		// Token: 0x06006C02 RID: 27650 RVA: 0x00044121 File Offset: 0x00042321
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_7)
		{
			this.class116_0 = class116_7;
		}

		// Token: 0x06006C03 RID: 27651 RVA: 0x0004412A File Offset: 0x0004232A
		[CompilerGenerated]
		internal Class116 vmethod_16()
		{
			return this.class116_1;
		}

		// Token: 0x06006C04 RID: 27652 RVA: 0x00044132 File Offset: 0x00042332
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class116 class116_7)
		{
			this.class116_1 = class116_7;
		}

		// Token: 0x06006C05 RID: 27653 RVA: 0x0004413B File Offset: 0x0004233B
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_2;
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x00044143 File Offset: 0x00042343
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_7)
		{
			this.class116_2 = class116_7;
		}

		// Token: 0x06006C07 RID: 27655 RVA: 0x0004414C File Offset: 0x0004234C
		[CompilerGenerated]
		internal Class116 vmethod_20()
		{
			return this.class116_3;
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x00044154 File Offset: 0x00042354
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class116 class116_7)
		{
			this.class116_3 = class116_7;
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x0004415D File Offset: 0x0004235D
		[CompilerGenerated]
		internal Class116 vmethod_22()
		{
			return this.class116_4;
		}

		// Token: 0x06006C0A RID: 27658 RVA: 0x00044165 File Offset: 0x00042365
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class116 class116_7)
		{
			this.class116_4 = class116_7;
		}

		// Token: 0x06006C0B RID: 27659 RVA: 0x0004416E File Offset: 0x0004236E
		[CompilerGenerated]
		internal Class116 vmethod_24()
		{
			return this.class116_5;
		}

		// Token: 0x06006C0C RID: 27660 RVA: 0x00044176 File Offset: 0x00042376
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class116 class116_7)
		{
			this.class116_5 = class116_7;
		}

		// Token: 0x06006C0D RID: 27661 RVA: 0x0004417F File Offset: 0x0004237F
		[CompilerGenerated]
		internal Class116 vmethod_26()
		{
			return this.class116_6;
		}

		// Token: 0x06006C0E RID: 27662 RVA: 0x00044187 File Offset: 0x00042387
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class116 class116_7)
		{
			this.class116_6 = class116_7;
		}

		// Token: 0x06006C0F RID: 27663 RVA: 0x003B474C File Offset: 0x003B294C
		private void method_3()
		{
			if (Information.IsNothing(this.flight_0))
			{
				this.vmethod_14().Text = "No flight selected!";
				Client.flightPlanTime_0.Text = "Waypoint time for flight <NO FLIGHT OR WAYPOINT SELECTED>";
			}
			else if (Information.IsNothing(this.waypoint_0))
			{
				this.vmethod_14().Text = "No waypoint selected!";
				Client.flightPlanTime_0.Text = "Waypoint time for flight <NO WAYPOINT SELECTED>";
			}
			if (this.waypoint_0.nullable_7 != null)
			{
				if (this.flight_0.method_12())
				{
					this.vmethod_14().Text = string.Concat(new string[]
					{
						"Mission is already active (Start time: ",
						this.waypoint_0.nullable_7.Value.ToShortDateString(),
						" - ",
						this.waypoint_0.nullable_7.Value.ToLongTimeString(),
						" Zulu)"
					});
				}
				else
				{
					this.vmethod_14().Text = "Mission is being planned.";
				}
			}
			else
			{
				this.vmethod_14().Text = "Mission has no waypoint times set.";
			}
			string text = string.Concat(new string[]
			{
				"Waypoint time for ",
				this.flight_0.string_4,
				", waypoint ",
				this.waypoint_0.string_2,
				" (",
				Waypoint.smethod_23(this.waypoint_0.waypointType_0),
				")"
			});
			this.Text = text;
		}

		// Token: 0x06006C10 RID: 27664 RVA: 0x00044190 File Offset: 0x00042390
		private void FlightPlanTime_Load(object sender, EventArgs e)
		{
			this.bool_4 = false;
			this.vmethod_0().Enabled = true;
			this.vmethod_2().Enabled = true;
			this.bool_4 = true;
		}

		// Token: 0x06006C11 RID: 27665 RVA: 0x003B48C0 File Offset: 0x003B2AC0
		public void method_4(ref Mission mission_1, ref Mission.Flight flight_1, ref Waypoint waypoint_1, Mission.Flight.Enum106 enum106_1, bool bool_5)
		{
			try
			{
				if (bool_5 && this.bool_4)
				{
					this.bool_4 = false;
					Mission mission = null;
					Mission.Flight flight = null;
					Waypoint waypoint = null;
					this.method_21(ref mission, ref flight, ref waypoint, Mission.Flight.Enum106.const_0);
				}
				if (!Information.IsNothing(mission_1))
				{
					this.mission_0 = mission_1;
				}
				if (!Information.IsNothing(flight_1))
				{
					this.flight_0 = flight_1;
				}
				if (!Information.IsNothing(waypoint_1))
				{
					this.waypoint_0 = waypoint_1;
				}
				if (enum106_1 != Mission.Flight.Enum106.const_0)
				{
					this.enum106_0 = enum106_1;
				}
				this.method_3();
				if (!Information.IsNothing(this.mission_0))
				{
					if (!Information.IsNothing(this.flight_0))
					{
						if (!Information.IsNothing(this.waypoint_0))
						{
							if (this.flight_0.enum93_0 != Mission.Enum93.const_1)
							{
								if (this.waypoint_0.nullable_8 != null && this.waypoint_0.float_6 > 0f)
								{
									DateTime value = this.waypoint_0.nullable_8.Value;
									string text;
									GameGeneral.smethod_47(ref value, ref text);
									string text2;
									GameGeneral.smethod_48(ref value, ref text2, false);
									this.vmethod_0().Text = text2;
									this.vmethod_2().Text = text;
								}
								else if (this.waypoint_0.nullable_7 != null)
								{
									DateTime value2 = this.waypoint_0.nullable_7.Value;
									string text3;
									GameGeneral.smethod_47(ref value2, ref text3);
									string text4;
									GameGeneral.smethod_48(ref value2, ref text4, false);
									this.vmethod_0().Text = text4;
									this.vmethod_2().Text = text3;
								}
								else
								{
									DateTime dateTime = Client.smethod_46().method_27();
									string text5;
									GameGeneral.smethod_47(ref dateTime, ref text5);
									string text6;
									GameGeneral.smethod_48(ref dateTime, ref text6, false);
									this.vmethod_0().Text = text6;
									this.vmethod_2().Text = text5;
								}
							}
							else
							{
								DateTime dateTime2 = new DateTime(2000, 1, 1, 0, 0, 0);
								this.vmethod_0().Enabled = false;
								dateTime2 = new DateTime(2000, 1, 1, 0, 0, 0);
								this.vmethod_2().Enabled = false;
								string text7;
								GameGeneral.smethod_47(ref dateTime2, ref text7);
								string text8;
								GameGeneral.smethod_48(ref dateTime2, ref text8, false);
								this.vmethod_0().Text = text8;
								this.vmethod_2().Text = text7;
							}
							if (this.flight_0.enum93_0 != Mission.Enum93.const_1 && (this.waypoint_0.waypointType_0 == Waypoint.WaypointType.Assemble || this.waypoint_0.waypointType_0 == Waypoint.WaypointType.HoldEnd))
							{
								DateTime dateTime3 = new DateTime(2000, 1, 1, 0, 0, 1);
								this.vmethod_4().Enabled = true;
								dateTime3 = dateTime3.AddSeconds((double)(this.waypoint_0.float_24 - 1f));
								string text9;
								GameGeneral.smethod_47(ref dateTime3, ref text9);
								this.vmethod_4().Text = text9;
							}
							else
							{
								DateTime dateTime4 = new DateTime(2000, 1, 1, 0, 0, 0);
								this.vmethod_4().Enabled = false;
								string text10;
								GameGeneral.smethod_47(ref dateTime4, ref text10);
								this.vmethod_4().Text = text10;
							}
							if (this.waypoint_0.waypointType_0 == Waypoint.WaypointType.StationEnd)
							{
								DateTime dateTime5 = new DateTime(2000, 1, 1, 0, 0, 1);
								this.vmethod_8().Enabled = true;
								dateTime5 = dateTime5.AddSeconds((double)(this.waypoint_0.float_25 - 1f));
								string text11;
								GameGeneral.smethod_47(ref dateTime5, ref text11);
								this.vmethod_8().Text = text11;
							}
							else
							{
								DateTime dateTime6 = new DateTime(2000, 1, 1, 0, 0, 0);
								this.vmethod_8().Enabled = false;
								string text12;
								GameGeneral.smethod_47(ref dateTime6, ref text12);
								this.vmethod_8().Text = text12;
							}
							if (this.flight_0.enum93_0 != Mission.Enum93.const_1 && !this.waypoint_0.method_39() && this.waypoint_0.waypointType_0 != Waypoint.WaypointType.TakeOff && this.waypoint_0.waypointType_0 != Waypoint.WaypointType.Land && this.waypoint_0.waypointType_0 != Waypoint.WaypointType.LandingMarshal && !this.waypoint_0.method_45())
							{
								DateTime dateTime7 = new DateTime(2000, 1, 1, 0, 0, 1);
								if (this.method_5())
								{
									DataTable dataTable = new DataTable();
									Class2451 class2451_ = this.vmethod_10();
									MissionEditor.smethod_2(ref class2451_, ref dataTable, this.waypoint_0.enum94_0);
									this.vmethod_11(class2451_);
									this.vmethod_10().Enabled = true;
								}
								else
								{
									this.vmethod_10().DataSource = null;
									this.vmethod_10().Items.Clear();
									this.vmethod_10().Enabled = false;
								}
								if (this.method_6())
								{
									this.vmethod_12().Enabled = true;
									DateTime dateTime8 = dateTime7.AddSeconds((double)(this.waypoint_0.float_27 - 1f));
									string text13;
									GameGeneral.smethod_47(ref dateTime8, ref text13);
									this.vmethod_12().Text = text13;
								}
								else
								{
									DateTime dateTime9 = new DateTime(2000, 1, 1, 0, 0, 0);
									this.vmethod_12().Enabled = false;
									string text14;
									GameGeneral.smethod_47(ref dateTime9, ref text14);
									this.vmethod_12().Text = text14;
								}
								this.vmethod_6().Enabled = true;
								DateTime dateTime10 = dateTime7.AddSeconds((double)(this.waypoint_0.float_26 - 1f));
								string text15;
								GameGeneral.smethod_47(ref dateTime10, ref text15);
								this.vmethod_6().Text = text15;
							}
							else
							{
								DateTime dateTime11 = new DateTime(2000, 1, 1, 0, 0, 0);
								this.vmethod_6().Enabled = false;
								this.vmethod_12().Enabled = false;
								this.vmethod_10().DataSource = null;
								this.vmethod_10().Items.Clear();
								this.vmethod_10().Enabled = false;
								string text16;
								GameGeneral.smethod_47(ref dateTime11, ref text16);
								string text17;
								GameGeneral.smethod_47(ref dateTime11, ref text17);
								this.vmethod_6().Text = text16;
								this.vmethod_12().Text = text17;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101344", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x003B4E8C File Offset: 0x003B308C
		private bool method_5()
		{
			bool result;
			try
			{
				if (Information.IsNothing(this.waypoint_0))
				{
					result = false;
				}
				else if (this.waypoint_0.waypointType_0 == Waypoint.WaypointType.Target && !this.waypoint_0.method_21() && !this.waypoint_0.method_22())
				{
					if (!Information.IsNothing(this.flight_0) && Enumerable.Count<Waypoint>(this.flight_0.method_15()) > 0)
					{
						foreach (Waypoint waypoint in this.flight_0.method_15())
						{
							if (waypoint == this.waypoint_0)
							{
								return true;
							}
							if (!Information.IsNothing(waypoint.waypoint_0) && waypoint.waypoint_0 == this.waypoint_0)
							{
								return false;
							}
							if (!Information.IsNothing(waypoint.waypoint_1) && waypoint.waypoint_1 == this.waypoint_0)
							{
								return false;
							}
							if (!Information.IsNothing(waypoint.waypoint_2) && waypoint.waypoint_2 == this.waypoint_0)
							{
								return false;
							}
							if (!Information.IsNothing(waypoint.waypoint_3) && waypoint.waypoint_3 == this.waypoint_0)
							{
								return false;
							}
							if (!Information.IsNothing(waypoint.waypoint_4) && waypoint.waypoint_4 == this.waypoint_0)
							{
								return false;
							}
						}
					}
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x003B5044 File Offset: 0x003B3244
		private bool method_6()
		{
			bool result;
			try
			{
				if (this.waypoint_0.waypointType_0 != Waypoint.WaypointType.Target && this.waypoint_0.waypointType_0 != Waypoint.WaypointType.WeaponTarget)
				{
					result = false;
				}
				else if (!this.waypoint_0.method_21() && this.waypoint_0.enum94_0 != Mission.Enum94.const_4 && this.waypoint_0.enum94_0 != Mission.Enum94.const_3)
				{
					result = false;
				}
				else
				{
					if (!Information.IsNothing(this.flight_0) && Enumerable.Count<Waypoint>(this.flight_0.method_15()) > 0)
					{
						foreach (Waypoint waypoint in this.flight_0.method_15())
						{
							if (!Information.IsNothing(waypoint.waypoint_0) && waypoint.waypoint_0 == this.waypoint_0)
							{
								return false;
							}
							if (!Information.IsNothing(waypoint.waypoint_1) && waypoint.waypoint_1 == this.waypoint_0)
							{
								return false;
							}
							if (!Information.IsNothing(waypoint.waypoint_2) && waypoint.waypoint_2 == this.waypoint_0)
							{
								return false;
							}
							if (!Information.IsNothing(waypoint.waypoint_3) && waypoint.waypoint_3 == this.waypoint_0)
							{
								return false;
							}
							if (!Information.IsNothing(waypoint.waypoint_4) && waypoint.waypoint_4 == this.waypoint_0)
							{
								return false;
							}
						}
					}
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x000441B8 File Offset: 0x000423B8
		private void method_7(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x000441C1 File Offset: 0x000423C1
		private void method_8(object sender, EventArgs e)
		{
			this.method_17();
		}

		// Token: 0x06006C16 RID: 27670 RVA: 0x000441B8 File Offset: 0x000423B8
		private void method_9(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x000441C1 File Offset: 0x000423C1
		private void method_10(object sender, EventArgs e)
		{
			this.method_17();
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x000441B8 File Offset: 0x000423B8
		private void method_11(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x000441C1 File Offset: 0x000423C1
		private void method_12(object sender, EventArgs e)
		{
			this.method_17();
		}

		// Token: 0x06006C1A RID: 27674 RVA: 0x000441B8 File Offset: 0x000423B8
		private void method_13(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x06006C1B RID: 27675 RVA: 0x000441C1 File Offset: 0x000423C1
		private void method_14(object sender, EventArgs e)
		{
			this.method_17();
		}

		// Token: 0x06006C1C RID: 27676 RVA: 0x000441B8 File Offset: 0x000423B8
		private void method_15(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x06006C1D RID: 27677 RVA: 0x000441C1 File Offset: 0x000423C1
		private void method_16(object sender, EventArgs e)
		{
			this.method_17();
		}

		// Token: 0x06006C1E RID: 27678 RVA: 0x003B51F8 File Offset: 0x003B33F8
		private void method_17()
		{
			if (this.bool_4)
			{
				this.bool_4 = false;
				Mission mission = null;
				Mission.Flight flight = null;
				Waypoint waypoint = null;
				this.method_21(ref mission, ref flight, ref waypoint, Mission.Flight.Enum106.const_0);
			}
		}

		// Token: 0x06006C1F RID: 27679 RVA: 0x000441B8 File Offset: 0x000423B8
		private void method_18(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x06006C20 RID: 27680 RVA: 0x000441C9 File Offset: 0x000423C9
		private void method_19(object sender, EventArgs e)
		{
			this.method_20();
		}

		// Token: 0x06006C21 RID: 27681 RVA: 0x003B51F8 File Offset: 0x003B33F8
		private void method_20()
		{
			if (this.bool_4)
			{
				this.bool_4 = false;
				Mission mission = null;
				Mission.Flight flight = null;
				Waypoint waypoint = null;
				this.method_21(ref mission, ref flight, ref waypoint, Mission.Flight.Enum106.const_0);
			}
		}

		// Token: 0x06006C22 RID: 27682 RVA: 0x003B5228 File Offset: 0x003B3428
		private void method_21(ref Mission mission_1, ref Mission.Flight flight_1, ref Waypoint waypoint_1, Mission.Flight.Enum106 enum106_1)
		{
			try
			{
				Mission.Flight flight;
				Waypoint[] waypoint_2;
				if (this.flight_0.enum93_0 != Mission.Enum93.const_1)
				{
					if (!Information.IsNothing(mission_1))
					{
						this.mission_0 = mission_1;
					}
					if (!Information.IsNothing(flight_1))
					{
						this.flight_0 = flight_1;
					}
					if (!Information.IsNothing(waypoint_1))
					{
						this.waypoint_0 = waypoint_1;
					}
					if (enum106_1 != Mission.Flight.Enum106.const_0)
					{
						this.enum106_0 = enum106_1;
					}
					List<string> list = Enumerable.ToList<string>(this.vmethod_2().Text.Split(new char[]
					{
						':'
					}));
					if (!(Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2])))
					{
						return;
					}
					List<string> list2 = Enumerable.ToList<string>(this.vmethod_0().Text.Split(new char[]
					{
						'-'
					}));
					if (!(Versioned.IsNumeric(list2[0]) & Versioned.IsNumeric(list2[1]) & Versioned.IsNumeric(list2[2])))
					{
						return;
					}
					DateTime dateTime = new DateTime(Conversions.ToInteger(list2[0]), Conversions.ToInteger(list2[1]), Conversions.ToInteger(list2[2]), Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2]));
					DateTime t;
					if (Information.IsNothing(this.waypoint_0.nullable_7))
					{
						t = new DateTime(Client.smethod_46().method_27().Year, Client.smethod_46().method_27().Month, Client.smethod_46().method_27().Day, Client.smethod_46().method_27().Hour, Client.smethod_46().method_27().Minute, Client.smethod_46().method_27().Second);
					}
					else
					{
						t = new DateTime(this.waypoint_0.nullable_7.Value.Year, this.waypoint_0.nullable_7.Value.Month, this.waypoint_0.nullable_7.Value.Day, this.waypoint_0.nullable_7.Value.Hour, this.waypoint_0.nullable_7.Value.Minute, this.waypoint_0.nullable_7.Value.Second);
					}
					DateTime t2;
					if (Information.IsNothing(this.waypoint_0.nullable_8))
					{
						t2 = new DateTime(Client.smethod_46().method_27().Year, Client.smethod_46().method_27().Month, Client.smethod_46().method_27().Day, Client.smethod_46().method_27().Hour, Client.smethod_46().method_27().Minute, Client.smethod_46().method_27().Second);
					}
					else
					{
						t2 = new DateTime(this.waypoint_0.nullable_8.Value.Year, this.waypoint_0.nullable_8.Value.Month, this.waypoint_0.nullable_8.Value.Day, this.waypoint_0.nullable_8.Value.Hour, this.waypoint_0.nullable_8.Value.Minute, this.waypoint_0.nullable_8.Value.Second);
					}
					DateTime d = new DateTime(2000, 1, 1, 0, 0, 1);
					List<string> list3 = Enumerable.ToList<string>(this.vmethod_4().Text.Split(new char[]
					{
						':'
					}));
					if (!(Versioned.IsNumeric(list3[0]) & Versioned.IsNumeric(list3[1]) & Versioned.IsNumeric(list3[2])))
					{
						return;
					}
					double num = Math.Abs((new DateTime(2000, 1, 1, Conversions.ToInteger(list3[0]), Conversions.ToInteger(list3[1]), Conversions.ToInteger(list3[2])) - d).TotalSeconds + 1.0);
					List<string> list4 = Enumerable.ToList<string>(this.vmethod_8().Text.Split(new char[]
					{
						':'
					}));
					if (!(Versioned.IsNumeric(list4[0]) & Versioned.IsNumeric(list4[1]) & Versioned.IsNumeric(list4[2])))
					{
						return;
					}
					double num2 = Math.Abs((new DateTime(2000, 1, 1, Conversions.ToInteger(list4[0]), Conversions.ToInteger(list4[1]), Conversions.ToInteger(list4[2])) - d).TotalSeconds + 1.0);
					List<string> list5 = Enumerable.ToList<string>(this.vmethod_6().Text.Split(new char[]
					{
						':'
					}));
					if (!(Versioned.IsNumeric(list5[0]) & Versioned.IsNumeric(list5[1]) & Versioned.IsNumeric(list5[2])))
					{
						return;
					}
					double num3 = Math.Abs((new DateTime(2000, 1, 1, Conversions.ToInteger(list5[0]), Conversions.ToInteger(list5[1]), Conversions.ToInteger(list5[2])) - d).TotalSeconds + 1.0);
					List<string> list6 = Enumerable.ToList<string>(this.vmethod_12().Text.Split(new char[]
					{
						':'
					}));
					if (!(Versioned.IsNumeric(list6[0]) & Versioned.IsNumeric(list6[1]) & Versioned.IsNumeric(list6[2])))
					{
						return;
					}
					double num4 = Math.Abs((new DateTime(2000, 1, 1, Conversions.ToInteger(list6[0]), Conversions.ToInteger(list6[1]), Conversions.ToInteger(list6[2])) - d).TotalSeconds + 1.0);
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					bool flag4 = false;
					bool flag5 = false;
					int num5 = Enumerable.Count<Waypoint>(this.flight_0.method_15());
					if (this.waypoint_0.float_6 > 0f)
					{
						if (DateTime.Compare(t2, dateTime) != 0 && (dateTime.Year != Client.smethod_46().method_27().Year || dateTime.Month != Client.smethod_46().method_27().Month || dateTime.Day != Client.smethod_46().method_27().Day || dateTime.Hour != Client.smethod_46().method_27().Hour || dateTime.Minute != Client.smethod_46().method_27().Minute || dateTime.Second != Client.smethod_46().method_27().Second))
						{
							flag = true;
						}
					}
					else if (DateTime.Compare(t, dateTime) != 0)
					{
						flag = true;
					}
					if ((double)this.waypoint_0.float_24 != num)
					{
						flag2 = true;
						if (Information.IsNothing(this.waypoint_0.nullable_7))
						{
							flag = true;
						}
					}
					if ((double)this.waypoint_0.float_25 != num2)
					{
						flag3 = true;
						if (Information.IsNothing(this.waypoint_0.nullable_7))
						{
							flag = true;
						}
					}
					if ((double)this.waypoint_0.float_26 != num3)
					{
						flag4 = true;
					}
					if ((double)this.waypoint_0.float_27 != num4)
					{
						flag5 = true;
					}
					if (!flag && !flag2 && !flag3 && !flag4 && !flag5)
					{
						return;
					}
					if (flag5)
					{
						this.waypoint_0.float_27 = (float)((long)Math.Round(num4));
					}
					if (flag)
					{
						if (this.waypoint_0.float_6 > 0f)
						{
							this.waypoint_0.nullable_7 = new DateTime?(dateTime.AddSeconds((double)(-(double)this.waypoint_0.float_6)));
							this.waypoint_0.nullable_8 = new DateTime?(dateTime);
							this.waypoint_0.enum82_0 = Waypoint.Enum82.const_1;
						}
						else
						{
							this.waypoint_0.nullable_7 = new DateTime?(dateTime);
							this.waypoint_0.nullable_8 = null;
							this.waypoint_0.enum82_0 = Waypoint.Enum82.const_1;
						}
						if (!flag3 && this.waypoint_0.waypointType_0 == Waypoint.WaypointType.StationEnd)
						{
							int num6 = num5 - 1;
							Waypoint waypoint;
							Waypoint waypoint2;
							for (int i = 0; i <= num6; i++)
							{
								waypoint = this.flight_0.method_15()[i];
								if (!Information.IsNothing(waypoint))
								{
									if (waypoint == this.waypoint_0)
									{
										break;
									}
									if (waypoint.method_40())
									{
										waypoint2 = waypoint;
									}
								}
							}
							if (!Information.IsNothing(waypoint2) && !Information.IsNothing(waypoint2.nullable_7) && !Information.IsNothing(waypoint.nullable_7.Value))
							{
								double a = Math.Max((this.waypoint_0.nullable_7.Value - waypoint2.nullable_7.Value).TotalSeconds, 0.0);
								this.waypoint_0.float_25 = (float)((long)Math.Round(a));
							}
							else
							{
								Interaction.MsgBox("Give the Station End waypoint a Station Time before setting the Zulu Time.", MsgBoxStyle.OkOnly, null);
							}
						}
						if (this.waypoint_0.method_44() && Information.IsNothing(this.waypoint_0.nullable_7))
						{
							this.waypoint_0.nullable_7 = new DateTime?(dateTime);
						}
						Mission.Flight flight_2 = this.flight_0;
						waypoint_2 = (flight = this.flight_0).method_15();
						AirTaskingOrder.smethod_0(flight_2, ref this.waypoint_0, ref this.mission_0, ref waypoint_2, this.enum106_0);
						flight.method_16(waypoint_2);
						if (this.waypoint_0.enum83_0 != Waypoint.Enum83.const_2)
						{
							if (!Information.IsNothing(this.waypoint_0.waypoint_0))
							{
								this.waypoint_0.waypoint_0.nullable_7 = this.waypoint_0.nullable_7;
								this.waypoint_0.waypoint_0.nullable_8 = this.waypoint_0.nullable_8;
								this.waypoint_0.waypoint_0.enum82_0 = Waypoint.Enum82.const_1;
							}
							if (!Information.IsNothing(this.waypoint_0.waypoint_1))
							{
								this.waypoint_0.waypoint_1.nullable_7 = this.waypoint_0.nullable_7;
								this.waypoint_0.waypoint_1.nullable_8 = this.waypoint_0.nullable_8;
								this.waypoint_0.waypoint_1.enum82_0 = Waypoint.Enum82.const_1;
							}
							if (!Information.IsNothing(this.waypoint_0.waypoint_2))
							{
								this.waypoint_0.waypoint_2.nullable_7 = this.waypoint_0.nullable_7;
								this.waypoint_0.waypoint_2.nullable_8 = this.waypoint_0.nullable_8;
								this.waypoint_0.waypoint_2.enum82_0 = Waypoint.Enum82.const_1;
							}
							if (!Information.IsNothing(this.waypoint_0.waypoint_3))
							{
								this.waypoint_0.waypoint_3.nullable_7 = this.waypoint_0.nullable_7;
								this.waypoint_0.waypoint_3.nullable_8 = this.waypoint_0.nullable_8;
								this.waypoint_0.waypoint_3.enum82_0 = Waypoint.Enum82.const_1;
							}
							if (!Information.IsNothing(this.waypoint_0.waypoint_4))
							{
								this.waypoint_0.waypoint_4.nullable_7 = this.waypoint_0.nullable_7;
								this.waypoint_0.waypoint_4.nullable_8 = this.waypoint_0.nullable_8;
								this.waypoint_0.waypoint_4.enum82_0 = Waypoint.Enum82.const_1;
							}
						}
					}
					else if (flag5)
					{
						Mission.Flight flight_3 = this.flight_0;
						waypoint_2 = (flight = this.flight_0).method_15();
						AirTaskingOrder.smethod_0(flight_3, ref this.waypoint_0, ref this.mission_0, ref waypoint_2, this.enum106_0);
						flight.method_16(waypoint_2);
					}
					if (flag2 && (this.waypoint_0.waypointType_0 == Waypoint.WaypointType.Assemble || this.waypoint_0.waypointType_0 == Waypoint.WaypointType.HoldEnd) && !Information.IsNothing(this.waypoint_0.nullable_7))
					{
						this.waypoint_0.float_24 = (float)((long)Math.Round(num));
					}
					if (flag3 && this.waypoint_0.waypointType_0 == Waypoint.WaypointType.StationEnd && !Information.IsNothing(this.waypoint_0.nullable_7))
					{
						this.waypoint_0.float_25 = (float)((long)Math.Round(num2));
					}
					if (flag4)
					{
						this.waypoint_0.float_26 = (float)((long)Math.Round(num3));
					}
					if (flag5)
					{
						this.waypoint_0.float_27 = (float)((long)Math.Round(num4));
						Mission.Flight flight_4 = this.flight_0;
						waypoint_2 = (flight = this.flight_0).method_15();
						AirTaskingOrder.smethod_0(flight_4, ref this.waypoint_0, ref this.mission_0, ref waypoint_2, this.enum106_0);
						flight.method_16(waypoint_2);
					}
					if (flag2 || flag3)
					{
						int num7 = num5 - 1;
						for (int j = 0; j <= num7; j++)
						{
							Waypoint waypoint = this.flight_0.method_15()[j];
							if (!Information.IsNothing(waypoint) && waypoint.enum82_0 != Waypoint.Enum82.const_1 && Information.IsNothing(waypoint.nullable_7))
							{
								waypoint.nullable_7 = new DateTime?(dateTime);
							}
						}
					}
				}
				else
				{
					DateTime d2 = new DateTime(2000, 1, 1, 0, 0, 1);
					List<string> list7 = Enumerable.ToList<string>(this.vmethod_8().Text.Split(new char[]
					{
						':'
					}));
					if (!(Versioned.IsNumeric(list7[0]) & Versioned.IsNumeric(list7[1]) & Versioned.IsNumeric(list7[2])))
					{
						return;
					}
					double a2 = Math.Abs((new DateTime(2000, 1, 1, Conversions.ToInteger(list7[0]), Conversions.ToInteger(list7[1]), Conversions.ToInteger(list7[2])) - d2).TotalSeconds + 1.0);
					if (this.waypoint_0.waypointType_0 == Waypoint.WaypointType.StationEnd)
					{
						this.waypoint_0.float_25 = (float)((long)Math.Round(a2));
					}
				}
				Scenario scenario_ = Client.smethod_46();
				Mission mission = this.mission_0;
				ActiveUnit activeUnit_ = this.flight_0.method_32(Client.smethod_46());
				Mission.Flight flight2 = this.flight_0;
				waypoint_2 = (flight = this.flight_0).method_15();
				float num8 = 0f;
				float num9 = 0f;
				Class514.smethod_28(scenario_, mission, activeUnit_, flight2, ref waypoint_2, ref num8, ref num9, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
				flight.method_16(waypoint_2);
				Class2413.smethod_2().method_41().method_235();
				if (Client.smethod_32().Visible)
				{
					if (Client.smethod_32().flightPlanWaypoints_6.vmethod_0().SelectedRows.Count > 0)
					{
						Client.smethod_32().bool_3 = false;
						Client.smethod_32().int_0 = Client.smethod_32().flightPlanWaypoints_6.vmethod_0().SelectedRows[0].Index;
						Client.smethod_32().waypoint_0 = (Waypoint)Client.smethod_32().flightPlanWaypoints_6.vmethod_0().Rows[Client.smethod_32().int_0].Tag;
						Client.smethod_32().flightPlanWaypoints_6.vmethod_0().Rows[0].Selected = false;
						Client.smethod_32().bool_3 = true;
					}
					Client.smethod_32().method_9(false);
					Client.smethod_32().method_13();
					Client.smethod_32().flightPlanWaypoints_6.method_14();
				}
				if (Client.smethod_31().Visible)
				{
					Client.smethod_31().method_4();
				}
				Mission mission2 = null;
				flight = null;
				Waypoint waypoint3 = null;
				this.method_4(ref mission2, ref flight, ref waypoint3, Mission.Flight.Enum106.const_0, true);
				Client.bool_1 = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101345", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006C23 RID: 27683 RVA: 0x00043AB9 File Offset: 0x00041CB9
		private void method_22(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x06006C24 RID: 27684 RVA: 0x00043AB9 File Offset: 0x00041CB9
		private void method_23(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x06006C25 RID: 27685 RVA: 0x00043AB9 File Offset: 0x00041CB9
		private void method_24(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x00043AB9 File Offset: 0x00041CB9
		private void method_25(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x06006C27 RID: 27687 RVA: 0x00043AB9 File Offset: 0x00041CB9
		private void method_26(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x00043AB9 File Offset: 0x00041CB9
		private void method_27(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x003B6260 File Offset: 0x003B4460
		private void FlightPlanTime_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x003B6314 File Offset: 0x003B4514
		private void FlightPlanTime_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			if (this.vmethod_0().Focused)
			{
				this.method_20();
			}
			if (this.vmethod_2().Focused)
			{
				this.method_17();
			}
			if (this.vmethod_4().Focused)
			{
				this.method_17();
			}
			if (this.vmethod_6().Focused)
			{
				this.method_17();
			}
			if (this.vmethod_12().Focused)
			{
				this.method_17();
			}
			this.vmethod_14().Select();
			base.Hide();
			if (Client.smethod_30().Visible)
			{
				Client.smethod_30().method_10();
			}
			if (Client.smethod_31().Visible)
			{
				Client.smethod_31().method_4();
			}
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x003B63D4 File Offset: 0x003B45D4
		private void method_28(object sender, EventArgs e)
		{
			Class2451 @class = this.vmethod_10();
			int selectedIndex = @class.SelectedIndex;
			Mission.Flight.smethod_10(ref selectedIndex, ref this.waypoint_0.enum94_0);
			@class.SelectedIndex = selectedIndex;
			Scenario scenario_ = Client.smethod_46();
			Mission mission = this.mission_0;
			ActiveUnit activeUnit_ = this.flight_0.method_32(Client.smethod_46());
			Mission.Flight flight = this.flight_0;
			Mission.Flight flight2;
			Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
			float num = 0f;
			float num2 = 0f;
			Class514.smethod_28(scenario_, mission, activeUnit_, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
			flight2.method_16(waypoint_);
			Class2413.smethod_2().method_41().method_235();
			if (Client.smethod_32().Visible)
			{
				if (Client.smethod_32().flightPlanWaypoints_6.vmethod_0().SelectedRows.Count > 0)
				{
					Client.smethod_32().bool_3 = false;
					Client.smethod_32().int_0 = Client.smethod_32().flightPlanWaypoints_6.vmethod_0().SelectedRows[0].Index;
					Client.smethod_32().waypoint_0 = (Waypoint)Client.smethod_32().flightPlanWaypoints_6.vmethod_0().Rows[Client.smethod_32().int_0].Tag;
					Client.smethod_32().flightPlanWaypoints_6.vmethod_0().Rows[0].Selected = false;
					Client.smethod_32().bool_3 = true;
				}
				Client.smethod_32().method_9(false);
				Client.smethod_32().method_13();
				Client.smethod_32().flightPlanWaypoints_6.method_14();
			}
			if (Client.smethod_31().Visible)
			{
				Client.smethod_31().method_4();
			}
			Mission mission2 = null;
			flight2 = null;
			Waypoint waypoint = null;
			this.method_4(ref mission2, ref flight2, ref waypoint, Mission.Flight.Enum106.const_0, true);
			Client.bool_1 = true;
		}

		// Token: 0x04003DB7 RID: 15799
		[AccessedThroughProperty("DateTimePicker_Date")]
		[CompilerGenerated]
		private Class118 class118_0;

		// Token: 0x04003DB8 RID: 15800
		[CompilerGenerated]
		[AccessedThroughProperty("DateTimePicker_Time")]
		private Class118 class118_1;

		// Token: 0x04003DB9 RID: 15801
		[CompilerGenerated]
		[AccessedThroughProperty("DateTimePicker_Hold")]
		private Class118 class118_2;

		// Token: 0x04003DBA RID: 15802
		[CompilerGenerated]
		[AccessedThroughProperty("DateTimePicker_Spacing")]
		private Class118 class118_3;

		// Token: 0x04003DBB RID: 15803
		[CompilerGenerated]
		[AccessedThroughProperty("DateTimePicker_Station")]
		private Class118 class118_4;

		// Token: 0x04003DBC RID: 15804
		[AccessedThroughProperty("ComboBox_AttackMethod")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04003DBD RID: 15805
		[CompilerGenerated]
		[AccessedThroughProperty("DateTimePicker_Separation")]
		private Class118 class118_5;

		// Token: 0x04003DBE RID: 15806
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_0;

		// Token: 0x04003DBF RID: 15807
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_1;

		// Token: 0x04003DC0 RID: 15808
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_2;

		// Token: 0x04003DC1 RID: 15809
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x04003DC2 RID: 15810
		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Class116 class116_4;

		// Token: 0x04003DC3 RID: 15811
		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Class116 class116_5;

		// Token: 0x04003DC4 RID: 15812
		[AccessedThroughProperty("Label7")]
		[CompilerGenerated]
		private Class116 class116_6;

		// Token: 0x04003DC5 RID: 15813
		public Waypoint waypoint_0;

		// Token: 0x04003DC6 RID: 15814
		public Mission.Flight flight_0;

		// Token: 0x04003DC7 RID: 15815
		public Mission mission_0;

		// Token: 0x04003DC8 RID: 15816
		public Mission.Flight.Enum106 enum106_0;

		// Token: 0x04003DC9 RID: 15817
		public bool bool_3;

		// Token: 0x04003DCA RID: 15818
		private bool bool_4;
	}
}
