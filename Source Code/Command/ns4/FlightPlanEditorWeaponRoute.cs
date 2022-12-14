using System;
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
using ns12;
using ns14;
using ns5;
using ns6;

namespace ns4
{
	// Token: 0x02000E23 RID: 3619
	[DesignerGenerated]
	internal sealed partial class FlightPlanEditorWeaponRoute : Form4
	{
		// Token: 0x06006BBB RID: 27579 RVA: 0x003B08C8 File Offset: 0x003AEAC8
		public FlightPlanEditorWeaponRoute()
		{
			base.FormClosing += this.FlightPlanEditorWeaponRoute_FormClosing;
			base.VisibleChanged += this.FlightPlanEditorWeaponRoute_VisibleChanged;
			base.KeyDown += this.FlightPlanEditorWeaponRoute_KeyDown;
			base.Shown += this.FlightPlanEditorWeaponRoute_Shown;
			this.bool_3 = true;
			this.int_0 = 0;
			this.dataTable_0 = new DataTable();
			this.dataTable_1 = new DataTable();
			this.bitmap_0 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Locked_16.png");
			this.bitmap_1 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Unlocked_16.png");
			this.bitmap_2 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\NotConfigured_16.png");
			this.bitmap_3 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\NotLockable_16.png");
			this.bitmap_4 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Relative_16.png");
			this.InitializeComponent();
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x00043F5C File Offset: 0x0004215C
		[CompilerGenerated]
		internal Button vmethod_0()
		{
			return this.button_0;
		}

		// Token: 0x06006BBF RID: 27583 RVA: 0x00043F64 File Offset: 0x00042164
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Button button_3)
		{
			this.button_0 = button_3;
		}

		// Token: 0x06006BC0 RID: 27584 RVA: 0x00043F6D File Offset: 0x0004216D
		[CompilerGenerated]
		internal Button vmethod_2()
		{
			return this.button_1;
		}

		// Token: 0x06006BC1 RID: 27585 RVA: 0x00043F75 File Offset: 0x00042175
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_3)
		{
			this.button_1 = button_3;
		}

		// Token: 0x06006BC2 RID: 27586 RVA: 0x00043F7E File Offset: 0x0004217E
		[CompilerGenerated]
		internal FlightPlanWaypointsWeapon vmethod_4()
		{
			return this.flightPlanWaypointsWeapon_0;
		}

		// Token: 0x06006BC3 RID: 27587 RVA: 0x00043F86 File Offset: 0x00042186
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(FlightPlanWaypointsWeapon flightPlanWaypointsWeapon_2)
		{
			this.flightPlanWaypointsWeapon_0 = flightPlanWaypointsWeapon_2;
		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x00043F8F File Offset: 0x0004218F
		[CompilerGenerated]
		internal Label vmethod_6()
		{
			return this.label_0;
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x00043F97 File Offset: 0x00042197
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_8)
		{
			this.label_0 = label_8;
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x00043FA0 File Offset: 0x000421A0
		[CompilerGenerated]
		internal Label vmethod_8()
		{
			return this.label_1;
		}

		// Token: 0x06006BC7 RID: 27591 RVA: 0x00043FA8 File Offset: 0x000421A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_8)
		{
			this.label_1 = label_8;
		}

		// Token: 0x06006BC8 RID: 27592 RVA: 0x00043FB1 File Offset: 0x000421B1
		[CompilerGenerated]
		internal Label vmethod_10()
		{
			return this.label_2;
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x00043FB9 File Offset: 0x000421B9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_8)
		{
			this.label_2 = label_8;
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x00043FC2 File Offset: 0x000421C2
		[CompilerGenerated]
		internal Label vmethod_12()
		{
			return this.label_3;
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x00043FCA File Offset: 0x000421CA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Label label_8)
		{
			this.label_3 = label_8;
		}

		// Token: 0x06006BCC RID: 27596 RVA: 0x00043FD3 File Offset: 0x000421D3
		[CompilerGenerated]
		internal Label vmethod_14()
		{
			return this.label_4;
		}

		// Token: 0x06006BCD RID: 27597 RVA: 0x00043FDB File Offset: 0x000421DB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_8)
		{
			this.label_4 = label_8;
		}

		// Token: 0x06006BCE RID: 27598 RVA: 0x00043FE4 File Offset: 0x000421E4
		[CompilerGenerated]
		internal Label vmethod_16()
		{
			return this.label_5;
		}

		// Token: 0x06006BCF RID: 27599 RVA: 0x00043FEC File Offset: 0x000421EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_8)
		{
			this.label_5 = label_8;
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x00043FF5 File Offset: 0x000421F5
		[CompilerGenerated]
		internal GroupBox vmethod_18()
		{
			return this.groupBox_0;
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x00043FFD File Offset: 0x000421FD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(GroupBox groupBox_1)
		{
			this.groupBox_0 = groupBox_1;
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x00044006 File Offset: 0x00042206
		[CompilerGenerated]
		internal ComboBox vmethod_20()
		{
			return this.comboBox_0;
		}

		// Token: 0x06006BD3 RID: 27603 RVA: 0x0004400E File Offset: 0x0004220E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(ComboBox comboBox_2)
		{
			this.comboBox_0 = comboBox_2;
		}

		// Token: 0x06006BD4 RID: 27604 RVA: 0x00044017 File Offset: 0x00042217
		[CompilerGenerated]
		internal Label vmethod_22()
		{
			return this.label_6;
		}

		// Token: 0x06006BD5 RID: 27605 RVA: 0x0004401F File Offset: 0x0004221F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Label label_8)
		{
			this.label_6 = label_8;
		}

		// Token: 0x06006BD6 RID: 27606 RVA: 0x00044028 File Offset: 0x00042228
		[CompilerGenerated]
		internal Label vmethod_24()
		{
			return this.label_7;
		}

		// Token: 0x06006BD7 RID: 27607 RVA: 0x00044030 File Offset: 0x00042230
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Label label_8)
		{
			this.label_7 = label_8;
		}

		// Token: 0x06006BD8 RID: 27608 RVA: 0x00044039 File Offset: 0x00042239
		[CompilerGenerated]
		internal ComboBox vmethod_26()
		{
			return this.comboBox_1;
		}

		// Token: 0x06006BD9 RID: 27609 RVA: 0x00044041 File Offset: 0x00042241
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(ComboBox comboBox_2)
		{
			this.comboBox_1 = comboBox_2;
		}

		// Token: 0x06006BDA RID: 27610 RVA: 0x0004404A File Offset: 0x0004224A
		[CompilerGenerated]
		internal Button vmethod_28()
		{
			return this.button_2;
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x00044052 File Offset: 0x00042252
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Button button_3)
		{
			this.button_2 = button_3;
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x00042F6B File Offset: 0x0004116B
		private void FlightPlanEditorWeaponRoute_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06006BDD RID: 27613 RVA: 0x0004405B File Offset: 0x0004225B
		private void FlightPlanEditorWeaponRoute_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.method_1();
			}
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x00044080 File Offset: 0x00042280
		public void method_1()
		{
			this.method_6();
			this.method_4(false);
			if (!Client.flightPlanTime_0.Visible)
			{
			}
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x0004409B File Offset: 0x0004229B
		public void method_2()
		{
			this.method_1();
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x0039F37C File Offset: 0x0039D57C
		private string method_3(ref ActiveUnit.Throttle throttle_0)
		{
			string result;
			switch (throttle_0)
			{
			case ActiveUnit.Throttle.FullStop:
				result = "Full Stop";
				break;
			case ActiveUnit.Throttle.Loiter:
				result = "Loiter";
				break;
			case ActiveUnit.Throttle.Cruise:
				result = "Cruise";
				break;
			case ActiveUnit.Throttle.Full:
				result = "Military";
				break;
			case ActiveUnit.Throttle.Flank:
				result = "Afterburner";
				break;
			default:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = throttle_0.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x003B1264 File Offset: 0x003AF464
		internal void method_4(bool bool_4)
		{
			try
			{
				this.method_5();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006BE2 RID: 27618 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_5()
		{
		}

		// Token: 0x06006BE3 RID: 27619 RVA: 0x003B12C0 File Offset: 0x003AF4C0
		internal void method_6()
		{
			this.flightPlanWaypointsWeapon_1 = this.vmethod_4();
			this.int_0 = 0;
			this.waypoint_1 = null;
			this.bool_3 = false;
			this.dataTable_0.Clear();
			this.bool_3 = true;
			if (this.dataTable_0.Columns.Count == 0)
			{
				if (!this.dataTable_0.Columns.Contains("ID"))
				{
					this.dataTable_0.Columns.Add("ID", typeof(string));
					this.int_1 = 0;
				}
				if (!this.dataTable_0.Columns.Contains("ObjectID"))
				{
					this.dataTable_0.Columns.Add("ObjectID", typeof(string));
					this.int_2 = 1;
				}
				if (!this.dataTable_0.Columns.Contains("Type"))
				{
					this.dataTable_0.Columns.Add("Type", typeof(int));
					this.int_3 = 2;
				}
				if (!this.dataTable_0.Columns.Contains("Time_Zulu"))
				{
					this.dataTable_0.Columns.Add("Time_Zulu", typeof(string));
					this.int_4 = 3;
				}
				if (!this.dataTable_0.Columns.Contains("Time_Local"))
				{
					this.dataTable_0.Columns.Add("Time_Local", typeof(string));
					this.int_5 = 4;
				}
				if (!this.dataTable_0.Columns.Contains("TimeFixedImg"))
				{
					this.dataTable_0.Columns.Add("TimeFixedImg", typeof(Image));
					this.int_7 = 5;
				}
				if (!this.dataTable_0.Columns.Contains("TimeFixed"))
				{
					this.dataTable_0.Columns.Add("TimeFixed", typeof(int));
					this.int_6 = 6;
				}
				if (!this.dataTable_0.Columns.Contains("DesiredSpeed"))
				{
					this.dataTable_0.Columns.Add("DesiredSpeed", typeof(string));
					this.int_8 = 7;
				}
				if (!this.dataTable_0.Columns.Contains("SpeedFixedImg"))
				{
					this.dataTable_0.Columns.Add("SpeedFixedImg", typeof(Image));
					this.int_10 = 8;
				}
				if (!this.dataTable_0.Columns.Contains("SpeedFixed"))
				{
					this.dataTable_0.Columns.Add("SpeedFixed", typeof(int));
					this.int_9 = 9;
				}
				if (!this.dataTable_0.Columns.Contains("DesiredAltitude"))
				{
					this.dataTable_0.Columns.Add("DesiredAltitude", typeof(string));
					this.int_11 = 10;
				}
				if (!this.dataTable_0.Columns.Contains("Leg_Distance"))
				{
					this.dataTable_0.Columns.Add("Leg_Distance", typeof(string));
					this.int_17 = 11;
				}
				if (!this.dataTable_0.Columns.Contains("Leg_TotalDistance"))
				{
					this.dataTable_0.Columns.Add("Leg_TotalDistance", typeof(string));
					this.int_18 = 12;
				}
				if (!this.dataTable_0.Columns.Contains("Leg_Time"))
				{
					this.dataTable_0.Columns.Add("Leg_Time", typeof(string));
					this.int_14 = 13;
				}
				if (!this.dataTable_0.Columns.Contains("Hold_Time"))
				{
					this.dataTable_0.Columns.Add("Hold_Time", typeof(string));
					this.int_15 = 14;
				}
				if (!this.dataTable_0.Columns.Contains("Leg_TotalTime"))
				{
					this.dataTable_0.Columns.Add("Leg_TotalTime", typeof(string));
					this.int_16 = 15;
				}
				if (!this.dataTable_0.Columns.Contains("Leg_FuelRequired"))
				{
					this.dataTable_0.Columns.Add("Leg_FuelRequired", typeof(string));
					this.int_12 = 16;
				}
				if (!this.dataTable_0.Columns.Contains("Leg_FuelRemaining"))
				{
					this.dataTable_0.Columns.Add("Leg_FuelRemaining", typeof(string));
					this.int_13 = 17;
				}
				if (!this.dataTable_0.Columns.Contains("Coordinates"))
				{
					this.dataTable_0.Columns.Add("Coordinates", typeof(string));
					this.int_19 = 18;
				}
			}
			DataGridViewComboBoxColumn dataGridViewComboBoxColumn = (DataGridViewComboBoxColumn)this.flightPlanWaypointsWeapon_1.vmethod_0().Columns[this.flightPlanWaypointsWeapon_1.vmethod_0().Columns[this.int_3].Index];
			Waypoint.smethod_20(ref this.dataTable_1);
			dataGridViewComboBoxColumn.DataSource = this.dataTable_1;
			dataGridViewComboBoxColumn.DisplayMember = "Description";
			dataGridViewComboBoxColumn.ValueMember = "ID";
			this.bool_3 = false;
			Waypoint[] array = this.waypoint_0;
			int count;
			int num;
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					DataRow row = this.dataTable_0.NewRow();
					this.dataTable_0.Rows.Add(row);
				}
				this.bool_3 = true;
				this.method_7();
				this.bool_3 = false;
				this.flightPlanWaypointsWeapon_1.vmethod_0().DataSource = new DataView(this.dataTable_0);
				this.bool_3 = true;
				count = this.flightPlanWaypointsWeapon_1.vmethod_0().Rows.Count;
				num = Enumerable.Count<Waypoint>(this.waypoint_0);
			}
			for (int j = count - 1; j >= 0; j += -1)
			{
				if (j <= num - 1)
				{
					Information.IsNothing(this.waypoint_0[j]);
				}
			}
			this.bool_3 = false;
			if (this.flightPlanWaypointsWeapon_1.vmethod_0().RowCount > 0)
			{
				if (this.int_0 > this.flightPlanWaypointsWeapon_1.vmethod_0().RowCount - 1)
				{
					this.flightPlanWaypointsWeapon_1.vmethod_0().Rows[0].Selected = false;
					this.flightPlanWaypointsWeapon_1.vmethod_0().Rows[this.flightPlanWaypointsWeapon_1.vmethod_0().RowCount - 1].Selected = true;
					this.waypoint_1 = (Waypoint)this.flightPlanWaypointsWeapon_1.vmethod_0().Rows[0].Tag;
				}
				else
				{
					this.flightPlanWaypointsWeapon_1.vmethod_0().Rows[0].Selected = false;
					this.flightPlanWaypointsWeapon_1.vmethod_0().Rows[this.int_0].Selected = true;
					this.waypoint_1 = (Waypoint)this.flightPlanWaypointsWeapon_1.vmethod_0().Rows[this.int_0].Tag;
				}
			}
			else
			{
				this.waypoint_1 = null;
			}
			this.bool_3 = true;
			this.bool_3 = false;
			this.flightPlanWaypointsWeapon_1.method_11();
			this.bool_3 = true;
			this.flightPlanWaypointsWeapon_1.method_12();
			this.flightPlanWaypointsWeapon_1.method_13();
		}

		// Token: 0x06006BE4 RID: 27620 RVA: 0x003B1A28 File Offset: 0x003AFC28
		internal void method_7()
		{
			try
			{
				if (Information.IsNothing(this.weapon_0))
				{
					this.Text = "Weapon Route Editor for aircraft and weapon <NO MISSION OR FLIGHT SELECTED>";
				}
				else if (Information.IsNothing(this.waypoint_0))
				{
					this.Text = "Flightplan Editor for flight <NO FLIGHT SELECTED>";
				}
				else
				{
					this.Text = "Flightplan Editor for flight ";
					int num = 1;
					DateTime dateTime_ = Client.smethod_46().method_31();
					bool bool_ = Client.smethod_46().method_33();
					string string_ = Client.smethod_46().method_35();
					string string_2 = Client.smethod_46().method_37();
					bool flag = false;
					bool flag2 = false;
					this.flightPlanWaypointsWeapon_1.vmethod_0().SuspendLayout();
					try
					{
						int num2 = Enumerable.Count<Waypoint>(this.waypoint_0) - 1;
						int i = 0;
						while (i <= num2)
						{
							Waypoint waypoint = this.waypoint_0[i];
							DataRow dataRow = this.dataTable_0.Rows[i];
							int num3 = Waypoint.smethod_22(waypoint.waypointType_0);
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_3]), num3))
							{
								dataRow[this.int_3] = num3;
							}
							string text;
							if (string.IsNullOrEmpty(waypoint.string_2))
							{
								text = Conversions.ToString(num);
							}
							else
							{
								text = waypoint.string_2;
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_1]), text))
							{
								dataRow[this.int_1] = text;
							}
							num++;
							dataRow[this.int_2] = waypoint.string_0;
							DateTime? dateTime;
							string text2;
							if (!Information.IsNothing(waypoint.nullable_7) && !flag)
							{
								if (Information.IsNothing(waypoint.nullable_8))
								{
									dateTime = waypoint.nullable_7;
								}
								else
								{
									dateTime = waypoint.nullable_8;
								}
								if (dateTime.Value.Hour < 10)
								{
									text2 = "0" + dateTime.Value.Hour.ToString() + ":";
								}
								else
								{
									text2 = dateTime.Value.Hour.ToString() + ":";
								}
								if (dateTime.Value.Minute < 10)
								{
									text2 = text2 + "0" + dateTime.Value.Minute.ToString() + ":";
								}
								else
								{
									text2 = text2 + dateTime.Value.Minute.ToString() + ":";
								}
								if (dateTime.Value.Second < 10)
								{
									text2 = text2 + "0" + dateTime.Value.Second.ToString();
								}
								else
								{
									text2 += dateTime.Value.Second.ToString();
								}
								if (waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
								{
									string str = dateTime.Value.Year.ToString() + "-";
									if (dateTime.Value.Month < 10)
									{
										str = str + "0" + dateTime.Value.Month.ToString() + "-";
									}
									else
									{
										str = str + dateTime.Value.Month.ToString() + "-";
									}
									if (dateTime.Value.Day < 10)
									{
										str = str + "0" + dateTime.Value.Day.ToString();
									}
									else
									{
										str += dateTime.Value.Day.ToString();
									}
									str + ", " + text2;
								}
								else if (waypoint.waypointType_0 == Waypoint.WaypointType.Target || waypoint.waypointType_0 == Waypoint.WaypointType.WeaponTarget || waypoint.method_40())
								{
									string str2 = dateTime.Value.Year.ToString() + "-";
									if (dateTime.Value.Month < 10)
									{
										str2 = str2 + "0" + dateTime.Value.Month.ToString() + "-";
									}
									else
									{
										str2 = str2 + dateTime.Value.Month.ToString() + "-";
									}
									if (dateTime.Value.Day < 10)
									{
										str2 = str2 + "0" + dateTime.Value.Day.ToString();
									}
									else
									{
										str2 += dateTime.Value.Day.ToString();
									}
									str2 + ", " + text2;
								}
							}
							else
							{
								text2 = "-";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_4]), text2))
							{
								dataRow[this.int_4] = text2;
							}
							string text3;
							if (!Information.IsNothing(dateTime) && !Information.IsNothing(waypoint.nullable_9) && !flag)
							{
								DateTime? dateTime2;
								if (Information.IsNothing(waypoint.nullable_8))
								{
									dateTime2 = waypoint.nullable_9;
								}
								else
								{
									dateTime2 = waypoint.nullable_10;
								}
								if (dateTime2.Value.Hour < 10)
								{
									text3 = "0" + dateTime2.Value.Hour.ToString() + ":";
								}
								else
								{
									text3 = dateTime2.Value.Hour.ToString() + ":";
								}
								if (dateTime2.Value.Minute < 10)
								{
									text3 = text3 + "0" + dateTime2.Value.Minute.ToString() + ":";
								}
								else
								{
									text3 = text3 + dateTime2.Value.Minute.ToString() + ":";
								}
								if (dateTime2.Value.Second < 10)
								{
									text3 = text3 + "0" + dateTime2.Value.Second.ToString();
								}
								else
								{
									text3 += dateTime2.Value.Second.ToString();
								}
								waypoint.ttimeOfDayType_0 = Class418.smethod_1(null, dateTime.Value.Year, dateTime.Value.Month, dateTime.Value.Day, dateTime.Value.Hour, dateTime.Value.Minute, dateTime.Value.Second, false, waypoint.imethod_2(), waypoint.imethod_0(), 0.0);
								if (Information.IsNothing(waypoint.nullable_8))
								{
									waypoint.nullable_9 = new DateTime?(Misc.smethod_10(waypoint.nullable_7.Value, waypoint.imethod_0(), bool_, string_, string_2));
								}
								else
								{
									waypoint.nullable_9 = new DateTime?(Misc.smethod_10(waypoint.nullable_8.Value, waypoint.imethod_0(), bool_, string_, string_2));
								}
								text3 = text3 + " (" + Class418.smethod_0(waypoint.ttimeOfDayType_0, dateTime_, waypoint.imethod_0(), bool_, string_, string_2) + ")";
							}
							else
							{
								text3 = "-";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_5]), text3))
							{
								dataRow[this.int_5] = text3;
							}
							Waypoint.Enum82 @enum;
							if (!Information.IsNothing(dateTime) && !flag)
							{
								@enum = waypoint.enum82_0;
							}
							else
							{
								@enum = Waypoint.Enum82.const_4;
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_6]), @enum))
							{
								dataRow[this.int_6] = @enum;
							}
							if (!waypoint.method_18().method_7() && (waypoint.method_18().method_6(Client.smethod_46()).method_1() != Doctrine.Class275.Enum66.const_3 || waypoint.method_18().method_6(Client.smethod_46()).method_2() != Doctrine.Class275.Enum66.const_3 || waypoint.method_18().method_6(Client.smethod_46()).method_3() != Doctrine.Class275.Enum66.const_3))
							{
								string text4 = "";
								if (waypoint.method_18().method_6(Client.smethod_46()).method_1() == Doctrine.Class275.Enum66.const_1)
								{
									text4 = "Radar active";
								}
								else if (waypoint.method_18().method_6(Client.smethod_46()).method_1() == Doctrine.Class275.Enum66.const_0)
								{
									text4 = "Radar passive";
								}
								if (waypoint.method_18().method_6(Client.smethod_46()).method_2() == Doctrine.Class275.Enum66.const_1)
								{
									if (!string.IsNullOrEmpty(text4))
									{
										text4 += ", ";
									}
									text4 += "Sonar active";
								}
								else if (waypoint.method_18().method_6(Client.smethod_46()).method_2() == Doctrine.Class275.Enum66.const_0)
								{
									if (!string.IsNullOrEmpty(text4))
									{
										text4 += ", ";
									}
									text4 += "Sonar passive";
								}
								if (waypoint.method_18().method_6(Client.smethod_46()).method_3() == Doctrine.Class275.Enum66.const_1)
								{
									if (!string.IsNullOrEmpty(text4))
									{
										text4 += ", ";
									}
									text4 += "OECM active";
								}
								else if (waypoint.method_18().method_6(Client.smethod_46()).method_3() == Doctrine.Class275.Enum66.const_0)
								{
									if (!string.IsNullOrEmpty(text4))
									{
										text4 += ", ";
									}
									text4 += "OECM passive";
								}
								if (string.IsNullOrEmpty(text4))
								{
								}
							}
							string text5 = Misc.smethod_8(waypoint.imethod_2(), waypoint.imethod_0());
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_19]), text5))
							{
								dataRow[this.int_19] = text5;
							}
							string text6;
							if (waypoint.float_2 < -2.1474836E+09f)
							{
								text6 = "Unknown, Aircraft Type and Loadout Type not set";
							}
							else if ((Information.IsNothing(waypoint.nullable_7) && (waypoint.waypointType_0 == Waypoint.WaypointType.HoldEnd || waypoint.waypointType_0 == Waypoint.WaypointType.StationEnd)) || waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
							{
								text6 = "-";
							}
							else
							{
								text6 = Conversions.ToString((int)Math.Round((double)waypoint.float_2)) + " kg";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_12]), text6))
							{
								dataRow[this.int_12] = text6;
							}
							string text7;
							Doctrine.Enum56? enum2;
							Doctrine.Enum56? enum3;
							if (waypoint.float_3 > 2.1474836E+09f)
							{
								text7 = "Unknown";
							}
							else
							{
								byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
								bool? flag3 = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
								bool? flag4 = flag3 = ((flag3 != null) ? new bool?(!flag3.GetValueOrDefault()) : flag3);
								bool? flag5;
								bool? flag11;
								if (flag3 != null && !flag4.GetValueOrDefault())
								{
									flag5 = new bool?(false);
								}
								else
								{
									b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
									bool? flag7;
									bool? flag6 = flag7 = ((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null);
									bool? flag8 = flag6 = ((flag7 == null || flag6.GetValueOrDefault()) ? (flag6 & !Information.IsNothing(enum3)) : new bool?(false));
									bool? flag9;
									if (flag6 != null && !flag8.GetValueOrDefault())
									{
										flag9 = new bool?(false);
									}
									else
									{
										b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
										bool? flag10 = flag6 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
										flag9 = ((flag6 != null) ? (flag8 & flag10.GetValueOrDefault()) : null);
									}
									flag3 = flag9;
									flag11 = (flag3 = ((flag3 != null) ? new bool?(!flag3.GetValueOrDefault()) : flag3));
									flag5 = ((flag3 != null) ? (flag4 & flag11.GetValueOrDefault()) : null);
								}
								flag11 = flag5;
								if (flag11.GetValueOrDefault())
								{
									text7 = "Unknown, AAR allowed";
									flag2 = false;
								}
								else if (flag2)
								{
									text7 = "Unknown, Station Time not set";
								}
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_13]), text7))
							{
								dataRow[this.int_13] = text7;
							}
							enum3 = enum2;
							enum2 = waypoint.method_18().method_152(Client.smethod_46(), false, false, false, false);
							string text8 = Misc.smethod_11((long)Math.Round((double)(waypoint.float_4 + waypoint.float_5)), Aircraft_AirOps.Enum44.const_0, false, true);
							if (waypoint.float_6 > 0f)
							{
								text8 = text8 + " (Weapon: " + Misc.smethod_11((long)Math.Round((double)waypoint.float_6), Aircraft_AirOps.Enum44.const_0, false, true) + ")";
							}
							else if (waypoint.waypointType_0 == Waypoint.WaypointType.HoldEnd || waypoint.waypointType_0 == Waypoint.WaypointType.StationEnd || waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
							{
								text8 = "-";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_14]), text8))
							{
								dataRow[this.int_14] = text8;
							}
							if (flag)
							{
								goto IL_DEB;
							}
							if (waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
							{
								goto IL_DEB;
							}
							string text9 = Misc.smethod_11((long)Math.Round((double)waypoint.float_7), Aircraft_AirOps.Enum44.const_0, false, true);
							IL_DF2:
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_16]), text9))
							{
								dataRow[this.int_16] = text9;
							}
							string text10;
							if (waypoint.waypointType_0 != Waypoint.WaypointType.HoldEnd && waypoint.waypointType_0 != Waypoint.WaypointType.StationEnd && waypoint.waypointType_0 != Waypoint.WaypointType.TakeOff && (int)Math.Round((double)(waypoint.float_9 + waypoint.float_10)) != 0)
							{
								text10 = Conversions.ToString((int)Math.Round((double)(waypoint.float_9 + waypoint.float_10))) + " nm";
							}
							else
							{
								text10 = "-";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_17]), text10))
							{
								dataRow[this.int_17] = text10;
							}
							string text11;
							if (flag || waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
							{
								text11 = "-";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_18]), text11))
							{
								dataRow[this.int_18] = text11;
							}
							string text12;
							if (waypoint.float_24 > 0f && waypoint.float_25 == 0f && waypoint.float_26 == 0f)
							{
								if (!Information.IsNothing(dateTime))
								{
									text12 = Misc.smethod_11((long)Math.Round((double)waypoint.float_24), Aircraft_AirOps.Enum44.const_0, false, true) + " Hold";
								}
								else
								{
									text12 = "N/A";
								}
							}
							else if (waypoint.float_24 == 0f && waypoint.float_25 == 0f && waypoint.float_26 > 0f)
							{
								if (waypoint.float_27 > 0f)
								{
									text12 = Misc.smethod_11((long)Math.Round((double)waypoint.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " 90/90, " + Misc.smethod_11((long)Math.Round((double)waypoint.float_27), Aircraft_AirOps.Enum44.const_0, false, true) + " Separation";
								}
								else
								{
									text12 = Misc.smethod_11((long)Math.Round((double)waypoint.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " Spacing";
								}
							}
							else if (waypoint.float_24 > 0f && waypoint.float_25 == 0f && waypoint.float_26 > 0f)
							{
								if (!Information.IsNothing(dateTime))
								{
									text12 = Misc.smethod_11((long)Math.Round((double)waypoint.float_24), Aircraft_AirOps.Enum44.const_0, false, true) + " Hold, " + Misc.smethod_11((long)Math.Round((double)waypoint.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " Spacing";
								}
								else
								{
									text12 = "N/A Hold, " + Misc.smethod_11((long)Math.Round((double)waypoint.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " Spacing";
								}
							}
							else if (waypoint.float_24 == 0f && waypoint.float_25 > 0f && waypoint.float_26 == 0f)
							{
								if (!Information.IsNothing(dateTime))
								{
									text12 = Misc.smethod_11((long)Math.Round((double)waypoint.float_25), Aircraft_AirOps.Enum44.const_0, false, true) + " Station";
								}
								else
								{
									text12 = "N/A";
								}
							}
							else if (waypoint.float_24 == 0f && waypoint.float_25 > 0f && waypoint.float_26 > 0f)
							{
								if (!Information.IsNothing(dateTime))
								{
									text12 = Misc.smethod_11((long)Math.Round((double)waypoint.float_25), Aircraft_AirOps.Enum44.const_0, false, true) + " Station, " + Misc.smethod_11((long)Math.Round((double)waypoint.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " Spacing";
								}
								else
								{
									text12 = "N/A Station, " + Misc.smethod_11((long)Math.Round((double)waypoint.float_26), Aircraft_AirOps.Enum44.const_0, false, true) + " Spacing";
								}
							}
							else
							{
								text12 = "-";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_15]), text12))
							{
								dataRow[this.int_15] = text12;
							}
							if (waypoint.waypointType_0 == Waypoint.WaypointType.WeaponTarget)
							{
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_11]), "-"))
								{
									dataRow[this.int_11] = "-";
								}
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_8]), "-"))
								{
									dataRow[this.int_8] = "-";
								}
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_9]), Waypoint.Enum82.const_4))
								{
									dataRow[this.int_9] = Waypoint.Enum82.const_4;
								}
							}
							else
							{
								string text13;
								if (!Information.IsNothing(waypoint.method_27()) && !Information.IsNothing(waypoint.nullable_0))
								{
									float? nullable_;
									float? num4 = nullable_ = waypoint.nullable_0;
									text13 = ((nullable_ != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + " kt";
								}
								else if (!Information.IsNothing(waypoint.method_35()) && waypoint.method_35() != ActiveUnit_Kinematics.UnitThrottlePreset.None)
								{
									ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)waypoint.method_35();
									text13 = this.method_3(ref throttle);
									if (waypoint.method_29() && !Information.IsNothing(waypoint.nullable_0))
									{
										string str3 = text13;
										string str4 = " (";
										float? nullable_;
										float? num4 = nullable_ = waypoint.nullable_0;
										text13 = str3 + str4 + ((nullable_ != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + " kt)";
									}
								}
								else
								{
									text13 = "Speed Not set!";
								}
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_8]), text13))
								{
									dataRow[this.int_8] = text13;
								}
								Waypoint.Enum82 enum82_ = waypoint.enum82_1;
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_9]), enum82_))
								{
									dataRow[this.int_9] = enum82_;
								}
								string text14 = "";
								if (!Information.IsNothing(waypoint.method_29()) && (!Information.IsNothing(waypoint.nullable_1) || (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))))
								{
									if (Class570.class280_0.method_12())
									{
										if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
										{
											if ((int)Math.Round((double)waypoint.nullable_2.Value) == 0)
											{
												text14 = "Minimum";
											}
											else
											{
												text14 = Conversions.ToString((int)Math.Round((double)(waypoint.nullable_2 * 3.28084f).Value)) + " ft AGL";
											}
										}
										else if (!Information.IsNothing(waypoint.nullable_1))
										{
											if ((int)Math.Round((double)waypoint.nullable_1.Value) == 0)
											{
												text14 = "Minimum";
											}
											else
											{
												text14 = Conversions.ToString((int)Math.Round((double)(waypoint.nullable_1 * 3.28084f).Value)) + " ft ASL";
											}
										}
									}
									else if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
									{
										if ((int)Math.Round((double)waypoint.nullable_2.Value) == 0)
										{
											text14 = "Minimum";
										}
										else
										{
											text14 = Conversions.ToString((int)Math.Round((double)waypoint.nullable_2.Value)) + " m AGL";
										}
									}
									else if (!Information.IsNothing(waypoint.nullable_1))
									{
										if ((int)Math.Round((double)waypoint.nullable_1.Value) == 0)
										{
											text14 = "Minimum";
										}
										else
										{
											text14 = Conversions.ToString((int)Math.Round((double)waypoint.nullable_1.Value)) + " m ASL";
										}
									}
								}
								else if (!Information.IsNothing(waypoint.method_31()) && waypoint.method_31() != ActiveUnit_AI.AircraftAltitudePreset.None)
								{
									switch (waypoint.method_31())
									{
									case ActiveUnit_AI.AircraftAltitudePreset.MinAltitude:
										text14 = "Minimum";
										break;
									case ActiveUnit_AI.AircraftAltitudePreset.Low1000:
										if (Class570.class280_0.method_12())
										{
											if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
											{
												text14 = Conversions.ToString(305) + " ft AGL";
											}
											else if (!Information.IsNothing(waypoint.nullable_1))
											{
												text14 = Conversions.ToString(305) + " ft ASL";
											}
										}
										else if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
										{
											text14 = Conversions.ToString(305) + " m AGL";
										}
										else if (!Information.IsNothing(waypoint.nullable_1))
										{
											text14 = Conversions.ToString(305) + " m ASL";
										}
										break;
									case ActiveUnit_AI.AircraftAltitudePreset.Low2000:
										if (Class570.class280_0.method_12())
										{
											if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
											{
												text14 = Conversions.ToString(610) + " ft AGL";
											}
											else if (!Information.IsNothing(waypoint.nullable_1))
											{
												text14 = Conversions.ToString(610) + " ft ASL";
											}
										}
										else if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
										{
											text14 = Conversions.ToString(610) + " m AGL";
										}
										else if (!Information.IsNothing(waypoint.nullable_1))
										{
											text14 = Conversions.ToString(610) + " m ASL";
										}
										break;
									case ActiveUnit_AI.AircraftAltitudePreset.Medium12000:
										if (Class570.class280_0.method_12())
										{
											if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
											{
												text14 = Conversions.ToString(3658) + " ft AGL";
											}
											else if (!Information.IsNothing(waypoint.nullable_1))
											{
												text14 = Conversions.ToString(3658) + " ft ASL";
											}
										}
										else if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
										{
											text14 = Conversions.ToString(3658) + " m AGL";
										}
										else if (!Information.IsNothing(waypoint.nullable_1))
										{
											text14 = Conversions.ToString(3658) + " m ASL";
										}
										break;
									case ActiveUnit_AI.AircraftAltitudePreset.High25000:
										if (Class570.class280_0.method_12())
										{
											if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
											{
												text14 = Conversions.ToString(7620) + " ft AGL";
											}
											else if (!Information.IsNothing(waypoint.nullable_1))
											{
												text14 = Conversions.ToString(7620) + " ft ASL";
											}
										}
										else if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
										{
											text14 = Conversions.ToString(7620) + " m AGL";
										}
										else if (!Information.IsNothing(waypoint.nullable_1))
										{
											text14 = Conversions.ToString(7620) + " m ASL";
										}
										break;
									case ActiveUnit_AI.AircraftAltitudePreset.High36000:
										if (Class570.class280_0.method_12())
										{
											if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
											{
												text14 = Conversions.ToString(10973) + " ft AGL";
											}
											else if (!Information.IsNothing(waypoint.nullable_1))
											{
												text14 = Conversions.ToString(10973) + " ft ASL";
											}
										}
										else if (waypoint.method_37() && !Information.IsNothing(waypoint.nullable_2))
										{
											text14 = Conversions.ToString(10973) + " m AGL";
										}
										else if (!Information.IsNothing(waypoint.nullable_1))
										{
											text14 = Conversions.ToString(10973) + " m ASL";
										}
										break;
									case ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude:
										text14 = "Maximum";
										break;
									}
								}
								else
								{
									text14 = "Altitude not set!";
								}
								if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_11]), text14))
								{
									dataRow[this.int_11] = text14;
								}
							}
							i++;
							continue;
							IL_DEB:
							text9 = "-";
							goto IL_DF2;
						}
					}
					finally
					{
						this.flightPlanWaypointsWeapon_1.vmethod_0().ResumeLayout();
					}
					if (this.flightPlanWaypointsWeapon_1.vmethod_0().Rows.Count > 0)
					{
						this.bool_3 = false;
						if (this.flightPlanWaypointsWeapon_1.vmethod_0().SelectedRows.Count > 0 && this.flightPlanWaypointsWeapon_1.vmethod_0().SelectedRows[0].Index > 0 && this.int_0 != this.flightPlanWaypointsWeapon_1.vmethod_0().SelectedRows[0].Index)
						{
							if (this.int_0 <= this.flightPlanWaypointsWeapon_1.vmethod_0().Rows.Count - 1)
							{
								this.flightPlanWaypointsWeapon_1.vmethod_0().Rows[this.int_0].Selected = false;
							}
							this.int_0 = this.flightPlanWaypointsWeapon_1.vmethod_0().SelectedRows[0].Index;
						}
						this.flightPlanWaypointsWeapon_1.vmethod_0().Rows[0].Selected = false;
						if (this.flightPlanWaypointsWeapon_1.vmethod_0().RowCount > 0)
						{
							if (this.int_0 > this.flightPlanWaypointsWeapon_1.vmethod_0().RowCount - 1)
							{
								this.flightPlanWaypointsWeapon_1.vmethod_0().Rows[this.flightPlanWaypointsWeapon_1.vmethod_0().RowCount - 1].Selected = false;
								this.flightPlanWaypointsWeapon_1.vmethod_0().Rows[this.flightPlanWaypointsWeapon_1.vmethod_0().RowCount - 1].Selected = true;
							}
							else
							{
								this.flightPlanWaypointsWeapon_1.vmethod_0().Rows[this.int_0].Selected = false;
								this.flightPlanWaypointsWeapon_1.vmethod_0().Rows[this.int_0].Selected = true;
							}
						}
						this.waypoint_1 = (Waypoint)this.flightPlanWaypointsWeapon_1.vmethod_0().SelectedRows[0].Tag;
						this.bool_3 = true;
					}
					else
					{
						this.waypoint_1 = null;
					}
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
			}
		}

		// Token: 0x06006BE5 RID: 27621 RVA: 0x0039ADF4 File Offset: 0x00398FF4
		private void FlightPlanEditorWeaponRoute_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Hide();
				return;
			}
			if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06006BE6 RID: 27622 RVA: 0x0000378C File Offset: 0x0000198C
		private void FlightPlanEditorWeaponRoute_Shown(object sender, EventArgs e)
		{
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x003B3770 File Offset: 0x003B1970
		public void method_8(bool bool_4, bool bool_5, bool bool_6, bool bool_7, bool bool_8)
		{
			try
			{
				if (base.Visible && bool_5)
				{
					if (bool_6)
					{
						Client.smethod_25().bool_3 = false;
						if (bool_7)
						{
							this.method_6();
						}
						else
						{
							this.method_7();
							if (bool_8)
							{
								this.flightPlanWaypointsWeapon_1.method_11();
							}
						}
						Client.smethod_25().bool_3 = true;
					}
					else if (bool_7)
					{
						this.method_6();
					}
					else
					{
						this.method_7();
						if (bool_8)
						{
							this.flightPlanWaypointsWeapon_1.method_11();
						}
					}
				}
				if (bool_4)
				{
					Class2413.smethod_2().method_41().method_235();
					Client.bool_1 = true;
					Class2413.smethod_2().method_41().method_84();
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
			}
		}

		// Token: 0x04003D85 RID: 15749
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ClearRoute")]
		private Button button_0;

		// Token: 0x04003D86 RID: 15750
		[AccessedThroughProperty("Button_CopyRouteFromWeapon1")]
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04003D87 RID: 15751
		[AccessedThroughProperty("FlightPlanWaypointsWeapon1")]
		[CompilerGenerated]
		private FlightPlanWaypointsWeapon flightPlanWaypointsWeapon_0;

		// Token: 0x04003D88 RID: 15752
		[AccessedThroughProperty("Label_AircraftType")]
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04003D89 RID: 15753
		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Label label_1;

		// Token: 0x04003D8A RID: 15754
		[AccessedThroughProperty("Label8")]
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04003D8B RID: 15755
		[AccessedThroughProperty("Label_ImpactDateAndTime")]
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04003D8C RID: 15756
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04003D8D RID: 15757
		[AccessedThroughProperty("Label_LaunchDateAndTime")]
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04003D8E RID: 15758
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox_SelectedFlight")]
		private GroupBox groupBox_0;

		// Token: 0x04003D8F RID: 15759
		[AccessedThroughProperty("Combo_CurrentWeapon")]
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04003D90 RID: 15760
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label label_6;

		// Token: 0x04003D91 RID: 15761
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Label label_7;

		// Token: 0x04003D92 RID: 15762
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_CurrentAircraft")]
		private ComboBox comboBox_1;

		// Token: 0x04003D93 RID: 15763
		[CompilerGenerated]
		[AccessedThroughProperty("Button_CopyRouteToAllWeapons")]
		private Button button_2;

		// Token: 0x04003D94 RID: 15764
		public bool bool_3;

		// Token: 0x04003D95 RID: 15765
		public Weapon weapon_0;

		// Token: 0x04003D96 RID: 15766
		public Waypoint[] waypoint_0;

		// Token: 0x04003D97 RID: 15767
		public Waypoint waypoint_1;

		// Token: 0x04003D98 RID: 15768
		public int int_0;

		// Token: 0x04003D99 RID: 15769
		public FlightPlanWaypointsWeapon flightPlanWaypointsWeapon_1;

		// Token: 0x04003D9A RID: 15770
		private DataTable dataTable_0;

		// Token: 0x04003D9B RID: 15771
		private int int_1;

		// Token: 0x04003D9C RID: 15772
		private int int_2;

		// Token: 0x04003D9D RID: 15773
		private int int_3;

		// Token: 0x04003D9E RID: 15774
		private int int_4;

		// Token: 0x04003D9F RID: 15775
		private int int_5;

		// Token: 0x04003DA0 RID: 15776
		private int int_6;

		// Token: 0x04003DA1 RID: 15777
		private int int_7;

		// Token: 0x04003DA2 RID: 15778
		private int int_8;

		// Token: 0x04003DA3 RID: 15779
		private int int_9;

		// Token: 0x04003DA4 RID: 15780
		private int int_10;

		// Token: 0x04003DA5 RID: 15781
		private int int_11;

		// Token: 0x04003DA6 RID: 15782
		private int int_12;

		// Token: 0x04003DA7 RID: 15783
		private int int_13;

		// Token: 0x04003DA8 RID: 15784
		private int int_14;

		// Token: 0x04003DA9 RID: 15785
		private int int_15;

		// Token: 0x04003DAA RID: 15786
		private int int_16;

		// Token: 0x04003DAB RID: 15787
		private int int_17;

		// Token: 0x04003DAC RID: 15788
		private int int_18;

		// Token: 0x04003DAD RID: 15789
		private int int_19;

		// Token: 0x04003DAE RID: 15790
		private DataTable dataTable_1;

		// Token: 0x04003DAF RID: 15791
		public Bitmap bitmap_0;

		// Token: 0x04003DB0 RID: 15792
		public Bitmap bitmap_1;

		// Token: 0x04003DB1 RID: 15793
		public Bitmap bitmap_2;

		// Token: 0x04003DB2 RID: 15794
		public Bitmap bitmap_3;

		// Token: 0x04003DB3 RID: 15795
		public Bitmap bitmap_4;
	}
}
