using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns2;
using ns4;
using ns5;
using ns7;
using ns9;

namespace Command
{
	// Token: 0x02000E8A RID: 3722
	[DesignerGenerated]
	public sealed partial class InternalDBViewer : DarkSecondaryFormBase
	{
		// Token: 0x06007303 RID: 29443 RVA: 0x003DA910 File Offset: 0x003D8B10
		public InternalDBViewer()
		{
			base.FormClosing += this.InternalDBViewer_FormClosing;
			base.Load += this.InternalDBViewer_Load;
			base.Load += this.InternalDBViewer_Load_1;
			base.Shown += this.InternalDBViewer_Shown;
			base.KeyDown += this.InternalDBViewer_KeyDown;
			base.MouseWheel += this.InternalDBViewer_MouseWheel;
			this.dataTable_0 = new DataTable();
			this.InitializeComponent_1();
		}

		// Token: 0x06007305 RID: 29445 RVA: 0x003DA9E0 File Offset: 0x003D8BE0
		private void InitializeComponent_1()
		{
			this.vmethod_3(new Class115());
			this.vmethod_19(new Class2451());
			this.vmethod_21(new Class116());
			this.vmethod_5(new Class2451());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Class116());
			this.vmethod_11(new Control8());
			this.vmethod_13(new Class2451());
			this.vmethod_1(new Control4());
			this.vmethod_15(new Class116());
			this.vmethod_17(new WebBrowser());
			this.vmethod_2().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_2().Controls.Add(this.vmethod_18());
			this.vmethod_2().Controls.Add(this.vmethod_20());
			this.vmethod_2().Controls.Add(this.vmethod_4());
			this.vmethod_2().Controls.Add(this.vmethod_6());
			this.vmethod_2().Controls.Add(this.vmethod_8());
			this.vmethod_2().Controls.Add(this.vmethod_10());
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(4, 39);
			this.vmethod_2().Name = "GroupBox1";
			this.vmethod_2().Size = new Size(281, 93);
			this.vmethod_2().TabIndex = 21;
			this.vmethod_2().TabStop = false;
			this.vmethod_2().Text = "Filter by...";
			this.vmethod_18().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_18().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_18().Font = new Font("Segoe UI", 7f);
			this.vmethod_18().Location = new Point(91, 66);
			this.vmethod_18().Name = "CB_Hypothetical";
			this.vmethod_18().Size = new Size(184, 21);
			this.vmethod_18().TabIndex = 18;
			this.vmethod_20().method_2(true);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Location = new Point(7, 70);
			this.vmethod_20().Name = "Label7";
			this.vmethod_20().Size = new Size(78, 15);
			this.vmethod_20().TabIndex = 17;
			this.vmethod_20().Text = "Hypothetical:";
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_4().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_4().Font = new Font("Segoe UI", 7f);
			this.vmethod_4().Location = new Point(91, 41);
			this.vmethod_4().Name = "CB_Country";
			this.vmethod_4().Size = new Size(184, 21);
			this.vmethod_4().TabIndex = 13;
			this.vmethod_6().method_2(true);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(7, 45);
			this.vmethod_6().Name = "Label5";
			this.vmethod_6().Size = new Size(53, 15);
			this.vmethod_6().TabIndex = 12;
			this.vmethod_6().Text = "Country:";
			this.vmethod_8().method_2(true);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(7, 21);
			this.vmethod_8().Name = "Label4";
			this.vmethod_8().Size = new Size(37, 15);
			this.vmethod_8().TabIndex = 11;
			this.vmethod_8().Text = "Class:";
			this.vmethod_10().method_14(null);
			this.vmethod_10().method_15(AutoCompleteMode.None);
			this.vmethod_10().method_13(AutoCompleteSource.None);
			this.vmethod_10().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_10().method_17(new Font("Segoe UI", 8f));
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().method_12(null);
			this.vmethod_10().method_18(null);
			this.vmethod_10().Location = new Point(91, 17);
			this.vmethod_10().method_2(32767);
			this.vmethod_10().method_7(false);
			this.vmethod_10().Name = "TB_Class";
			this.vmethod_10().method_3(false);
			this.vmethod_10().method_19(ScrollBars.None);
			this.vmethod_10().method_9(0);
			this.vmethod_10().Size = new Size(184, 20);
			this.vmethod_10().TabIndex = 10;
			this.vmethod_10().method_1(HorizontalAlignment.Left);
			this.vmethod_10().method_5(false);
			this.vmethod_10().method_10("");
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_12().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_12().Font = new Font("Segoe UI", 7f);
			this.vmethod_12().Items.AddRange(new object[]
			{
				"Aircraft",
				"Ship",
				"Submarine",
				"Facility",
				"Satellite",
				"Weapon"
			});
			this.vmethod_12().Location = new Point(59, 12);
			this.vmethod_12().Name = "CB_ObjectType";
			this.vmethod_12().Size = new Size(226, 21);
			this.vmethod_12().TabIndex = 14;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().method_26(false);
			this.vmethod_0().Location = new Point(291, 12);
			this.vmethod_0().Name = "ListBox1";
			this.vmethod_0().Size = new Size(712, 121);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_14().method_2(true);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(7, 15);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Size = new Size(32, 15);
			this.vmethod_14().TabIndex = 22;
			this.vmethod_14().Text = "Type";
			this.vmethod_16().AllowWebBrowserDrop = false;
			this.vmethod_16().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_16().IsWebBrowserContextMenuEnabled = false;
			this.vmethod_16().Location = new Point(4, 139);
			this.vmethod_16().MinimumSize = new Size(20, 20);
			this.vmethod_16().Name = "WebBrowser1";
			this.vmethod_16().Size = new Size(999, 583);
			this.vmethod_16().TabIndex = 23;
			this.vmethod_16().WebBrowserShortcutsEnabled = false;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1008, 727);
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "InternalDBViewer";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Database Viewer";
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x00047F1D File Offset: 0x0004611D
		[CompilerGenerated]
		internal Control4 vmethod_0()
		{
			return this.control4_0;
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x003DB274 File Offset: 0x003D9474
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control4 control4_1)
		{
			EventHandler value = new EventHandler(this.method_44);
			EventHandler value2 = new EventHandler(this.method_45);
			EventHandler eventHandler_ = new EventHandler(this.method_49);
			Control4 control = this.control4_0;
			if (control != null)
			{
				control.MouseEnter -= value;
				control.MouseLeave -= value2;
				control.method_17(eventHandler_);
			}
			this.control4_0 = control4_1;
			control = this.control4_0;
			if (control != null)
			{
				control.MouseEnter += value;
				control.MouseLeave += value2;
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06007308 RID: 29448 RVA: 0x00047F25 File Offset: 0x00046125
		[CompilerGenerated]
		internal Class115 vmethod_2()
		{
			return this.class115_0;
		}

		// Token: 0x06007309 RID: 29449 RVA: 0x00047F2D File Offset: 0x0004612D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class115 class115_1)
		{
			this.class115_0 = class115_1;
		}

		// Token: 0x0600730A RID: 29450 RVA: 0x00047F36 File Offset: 0x00046136
		[CompilerGenerated]
		internal Class2451 vmethod_4()
		{
			return this.class2451_0;
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x003DB2F0 File Offset: 0x003D94F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class2451 class2451_3)
		{
			EventHandler value = new EventHandler(this.method_8);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_3;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x00047F3E File Offset: 0x0004613E
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_0;
		}

		// Token: 0x0600730D RID: 29453 RVA: 0x00047F46 File Offset: 0x00046146
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_4)
		{
			this.class116_0 = class116_4;
		}

		// Token: 0x0600730E RID: 29454 RVA: 0x00047F4F File Offset: 0x0004614F
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_1;
		}

		// Token: 0x0600730F RID: 29455 RVA: 0x00047F57 File Offset: 0x00046157
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_4)
		{
			this.class116_1 = class116_4;
		}

		// Token: 0x06007310 RID: 29456 RVA: 0x00047F60 File Offset: 0x00046160
		[CompilerGenerated]
		internal Control8 vmethod_10()
		{
			return this.control8_0;
		}

		// Token: 0x06007311 RID: 29457 RVA: 0x003DB334 File Offset: 0x003D9534
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control8 control8_1)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_5);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.method_22(delegate85_);
			}
			this.control8_0 = control8_1;
			control = this.control8_0;
			if (control != null)
			{
				control.method_21(delegate85_);
			}
		}

		// Token: 0x06007312 RID: 29458 RVA: 0x00047F68 File Offset: 0x00046168
		[CompilerGenerated]
		internal Class2451 vmethod_12()
		{
			return this.class2451_1;
		}

		// Token: 0x06007313 RID: 29459 RVA: 0x003DB378 File Offset: 0x003D9578
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class2451 class2451_3)
		{
			EventHandler value = new EventHandler(this.method_7);
			Class2451 @class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_1 = class2451_3;
			@class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06007314 RID: 29460 RVA: 0x00047F70 File Offset: 0x00046170
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_2;
		}

		// Token: 0x06007315 RID: 29461 RVA: 0x00047F78 File Offset: 0x00046178
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_4)
		{
			this.class116_2 = class116_4;
		}

		// Token: 0x06007316 RID: 29462 RVA: 0x00047F81 File Offset: 0x00046181
		[CompilerGenerated]
		internal WebBrowser vmethod_16()
		{
			return this.webBrowser_0;
		}

		// Token: 0x06007317 RID: 29463 RVA: 0x003DB3BC File Offset: 0x003D95BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(WebBrowser webBrowser_1)
		{
			PreviewKeyDownEventHandler value = new PreviewKeyDownEventHandler(this.method_47);
			WebBrowserNavigatingEventHandler value2 = new WebBrowserNavigatingEventHandler(this.method_48);
			WebBrowser webBrowser = this.webBrowser_0;
			if (webBrowser != null)
			{
				webBrowser.PreviewKeyDown -= value;
				webBrowser.Navigating -= value2;
			}
			this.webBrowser_0 = webBrowser_1;
			webBrowser = this.webBrowser_0;
			if (webBrowser != null)
			{
				webBrowser.PreviewKeyDown += value;
				webBrowser.Navigating += value2;
			}
		}

		// Token: 0x06007318 RID: 29464 RVA: 0x00047F89 File Offset: 0x00046189
		[CompilerGenerated]
		internal Class2451 vmethod_18()
		{
			return this.class2451_2;
		}

		// Token: 0x06007319 RID: 29465 RVA: 0x003DB41C File Offset: 0x003D961C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class2451 class2451_3)
		{
			EventHandler value = new EventHandler(this.method_46);
			Class2451 @class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_2 = class2451_3;
			@class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600731A RID: 29466 RVA: 0x00047F91 File Offset: 0x00046191
		[CompilerGenerated]
		internal Class116 vmethod_20()
		{
			return this.class116_3;
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x00047F99 File Offset: 0x00046199
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class116 class116_4)
		{
			this.class116_3 = class116_4;
		}

		// Token: 0x0600731C RID: 29468 RVA: 0x00044820 File Offset: 0x00042A20
		private void InternalDBViewer_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600731D RID: 29469 RVA: 0x00044489 File Offset: 0x00042689
		private void InternalDBViewer_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x0600731E RID: 29470 RVA: 0x003DB460 File Offset: 0x003D9660
		public void method_3(string string_5)
		{
			HtmlElementCollection all = this.vmethod_16().Document.Body.All;
			try
			{
				foreach (object obj in all)
				{
					HtmlElement htmlElement = (HtmlElement)obj;
					string attribute = htmlElement.GetAttribute("Name");
					if (!string.IsNullOrEmpty(attribute) && Operators.CompareString(attribute, string_5, false) == 0)
					{
						htmlElement.ScrollIntoView(true);
						break;
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
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x003DB4F0 File Offset: 0x003D96F0
		public void method_4(bool ApplyKeywordFilter, bool RetainPlatform = false)
		{
			if (!string.IsNullOrEmpty(this.string_0) && this.int_0 != 0)
			{
				this.string_0.Equals(RuntimeHelpers.GetObjectValue(this.vmethod_12().SelectedItem));
				if (!RetainPlatform)
				{
					this.vmethod_12().SelectedItem = this.string_0;
				}
				if (ApplyKeywordFilter || !RetainPlatform)
				{
					this.method_6();
				}
				if (!RetainPlatform)
				{
					this.bool_3 = true;
					Class117 @class = Enumerable.FirstOrDefault<Class117>(Enumerable.Where<Class117>(this.vmethod_0().method_18(), new Func<Class117, bool>(this.method_50)));
					if (@class != null)
					{
						this.vmethod_0().method_29(this.vmethod_0().method_18().IndexOf(@class));
					}
					this.bool_3 = false;
				}
				this.string_3 = this.vmethod_0().Text;
				string text = "";
				string left = this.string_0;
				if (Operators.CompareString(left, "Aircraft", false) != 0)
				{
					if (Operators.CompareString(left, "Ship", false) != 0)
					{
						if (Operators.CompareString(left, "Submarine", false) != 0)
						{
							if (Operators.CompareString(left, "Facility", false) != 0)
							{
								if (Operators.CompareString(left, "Satellite", false) != 0)
								{
									if (Operators.CompareString(left, "Weapon", false) == 0)
									{
										Weapon weapon = Client.smethod_46().method_87(this.int_0);
										this.string_4 = weapon.string_2;
										text = this.method_43(weapon);
									}
								}
								else
								{
									Scenario scenario = Client.smethod_46();
									Satellite satellite = new Satellite(ref scenario, null);
									scenario = Client.smethod_46();
									DBFunctions.smethod_74(ref scenario, ref satellite, this.int_0, 0, true);
									this.string_4 = satellite.string_2;
									text = this.method_13(satellite);
								}
							}
							else
							{
								Scenario scenario = Client.smethod_46();
								Facility facility = new Facility(ref scenario, "");
								scenario = Client.smethod_46();
								DBFunctions.smethod_57(ref scenario, ref facility, this.int_0, true);
								this.string_4 = facility.string_2;
								text = this.method_12(facility);
							}
						}
						else
						{
							Scenario scenario = Client.smethod_46();
							Submarine submarine = new Submarine(ref scenario, "");
							scenario = Client.smethod_46();
							DBFunctions.smethod_55(ref scenario, ref submarine, this.int_0, true);
							this.string_4 = submarine.string_2;
							text = this.method_11(submarine);
						}
					}
					else
					{
						Scenario scenario = Client.smethod_46();
						Ship ship = new Ship(ref scenario, "");
						scenario = Client.smethod_46();
						DBFunctions.smethod_53(ref scenario, ref ship, this.int_0, true);
						this.string_4 = ship.string_2;
						text = this.method_10(ship);
					}
				}
				else
				{
					Scenario scenario = Client.smethod_46();
					Aircraft aircraft = new Aircraft(ref scenario, "");
					scenario = Client.smethod_46();
					DBFunctions.smethod_19(ref scenario, ref aircraft, this.int_0, true);
					this.string_4 = aircraft.string_2;
					text = this.method_9(aircraft);
				}
				Class2558.smethod_11(this.vmethod_16(), text);
				this.string_2 = text;
				this.method_3(this.string_1);
				this.string_1 = null;
			}
		}

		// Token: 0x06007320 RID: 29472 RVA: 0x003DB7D0 File Offset: 0x003D99D0
		private void InternalDBViewer_Load_1(object sender, EventArgs e)
		{
			this.vmethod_12().SelectedIndex = 0;
			string str = ColorTranslator.ToHtml(this.BackColor);
			Class2558.smethod_11(this.vmethod_16(), "<html><body style='background-color:" + str + "'></body></html>");
		}

		// Token: 0x06007321 RID: 29473 RVA: 0x00047FA2 File Offset: 0x000461A2
		private void method_5(object object_0)
		{
			if (Operators.CompareString(this.vmethod_10().Text, "", false) != 0)
			{
				this.method_6();
			}
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x003DB810 File Offset: 0x003D9A10
		private void method_6()
		{
			switch (this.vmethod_12().SelectedIndex)
			{
			case 0:
				this.dataTable_0 = Client.smethod_46().Cache_Aircraft_DT;
				break;
			case 1:
				this.dataTable_0 = Client.smethod_46().Cache_Ships_DT;
				break;
			case 2:
				this.dataTable_0 = Client.smethod_46().Cache_Subs_DT;
				break;
			case 3:
				this.dataTable_0 = Client.smethod_46().Cache_Facilities_DT;
				break;
			case 4:
				this.dataTable_0 = Client.smethod_46().Cache_Satellites_DT;
				break;
			case 5:
				this.dataTable_0 = Client.smethod_46().Cache_Weapons_DT;
				break;
			default:
				return;
			}
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "LongName ASC";
			if (Operators.CompareString(this.vmethod_10().Text, "", false) != 0 || this.vmethod_4().SelectedIndex != 0 || this.vmethod_18().SelectedIndex != 0)
			{
				string text = "1=1 ";
				if (Operators.CompareString(this.vmethod_10().Text, "", false) != 0)
				{
					string str = this.vmethod_10().Text.Replace("'", "''");
					text = text + " AND LongName LIKE '%" + str + "%' ";
				}
				if (this.vmethod_4().Enabled && this.dataTable_0.Columns.Contains("OperatorCountry") && this.vmethod_4().SelectedIndex > 0)
				{
					text = text + " AND OperatorCountry=" + this.vmethod_4().SelectedValue.ToString();
				}
				if (this.vmethod_18().SelectedIndex == 1)
				{
					text += " AND Hypothetical=FALSE";
				}
				else if (this.vmethod_18().SelectedIndex == 2)
				{
					text += " AND Hypothetical=TRUE";
				}
				text = text.Replace("[", "[[");
				text = text.Replace("]", "]]");
				text = text.Replace("[[", "[[]");
				text = text.Replace("]]", "[]]");
				dataView.RowFilter = text;
			}
			this.bool_3 = true;
			this.vmethod_0().method_18().Clear();
			try
			{
				foreach (object obj in dataView)
				{
					DataRow row = ((DataRowView)obj).Row;
					Class117 @class = new Class117(row["LongName"].ToString());
					@class.Tag = RuntimeHelpers.GetObjectValue(row["ID"]);
					this.vmethod_0().method_18().Add(@class);
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
			this.vmethod_0().method_37();
			this.bool_3 = false;
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x003DBAD0 File Offset: 0x003D9CD0
		private void method_7(object sender, EventArgs e)
		{
			this.string_0 = Conversions.ToString(this.vmethod_12().SelectedItem);
			this.vmethod_10().method_20();
			this.vmethod_4().Enabled = (Operators.CompareString(this.string_0, "Weapon", false) != 0);
			this.method_6();
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x00047FC2 File Offset: 0x000461C2
		private void method_8(object sender, EventArgs e)
		{
			this.method_6();
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x003DBB24 File Offset: 0x003D9D24
		private void InternalDBViewer_Shown(object sender, EventArgs e)
		{
			base.SuspendLayout();
			if (string.IsNullOrEmpty(this.string_0))
			{
				this.string_0 = "Aircraft";
			}
			this.vmethod_4().Enabled = (Operators.CompareString(this.string_0, "Weapon", false) != 0);
			DataTable cache_OperatorCountries_DT = Client.smethod_46().Cache_OperatorCountries_DT;
			this.vmethod_4().DataSource = cache_OperatorCountries_DT;
			this.vmethod_4().DisplayMember = "Description";
			this.vmethod_4().ValueMember = "ID";
			this.vmethod_4().SelectedIndex = 0;
			this.vmethod_18().Items.Clear();
			this.vmethod_18().Items.Add("Show all platforms, both real-life and hypothetical");
			this.vmethod_18().Items.Add("Show real-life platforms only");
			this.vmethod_18().Items.Add("Show hypothetical platforms only");
			this.vmethod_18().SelectedIndex = 0;
			if (this.int_0 > 0)
			{
				this.method_4(true, false);
			}
			else
			{
				this.method_6();
			}
			this.vmethod_16().Focus();
			base.ResumeLayout();
		}

		// Token: 0x06007326 RID: 29478 RVA: 0x003DBC3C File Offset: 0x003D9E3C
		public string method_9(Aircraft aircraft_0)
		{
			StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "Templates\\Platform.html"));
			string text;
			using (streamReader)
			{
				text = streamReader.ReadToEnd();
			}
			string text2 = "";
			if (aircraft_0.bool_23)
			{
				text2 = " -- HYPOTHETICAL UNIT";
			}
			Tuple<string, string, string> tuple = DBFunctions.smethod_84(GlobalVariables.ActiveUnitType.Aircraft, aircraft_0.DBID, Client.smethod_46());
			text = text.Replace("<%PlatformName%>", string.Concat(new string[]
			{
				"#",
				Conversions.ToString(this.int_0),
				" - ",
				aircraft_0.string_2,
				" (",
				tuple.Item1,
				" - ",
				tuple.Item2,
				")",
				text2
			}));
			text = text.Replace("<%Image%>", this.method_23(aircraft_0));
			text = text.Replace("<%Description%>", this.method_25(aircraft_0));
			text = text.Replace("<%General%>", this.method_14(aircraft_0));
			text = text.Replace("<%Sensors%>", this.method_26(aircraft_0));
			text = text.Replace("<%MineCountermeasures%>", "");
			text = text.Replace("<%Mounts%>", this.method_28(aircraft_0));
			text = text.Replace("<%Stores%>", this.method_29(aircraft_0));
			text = text.Replace("<%Loadouts%>", this.method_30(aircraft_0));
			text = text.Replace("<%Magazines%>", "");
			text = text.Replace("<%Comms%>", this.method_32(aircraft_0));
			text = text.Replace("<%AirFacilities%>", "");
			text = text.Replace("<%DockingFacilities%>", "");
			text = text.Replace("<%Signatures%>", this.method_37(aircraft_0));
			text = text.Replace("<%Flags%>", this.method_38(aircraft_0));
			text = text.Replace("<%Propulsion%>", this.method_40(aircraft_0));
			text = text.Replace("<%Fuel%>", this.method_41(aircraft_0));
			return text;
		}

		// Token: 0x06007327 RID: 29479 RVA: 0x003DBE44 File Offset: 0x003DA044
		public string method_10(Ship ship_0)
		{
			StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "Templates\\Platform.html"));
			string text;
			using (streamReader)
			{
				text = streamReader.ReadToEnd();
			}
			string text2 = "";
			if (ship_0.bool_23)
			{
				text2 = " -- HYPOTHETICAL UNIT";
			}
			Tuple<string, string, string> tuple = DBFunctions.smethod_84(GlobalVariables.ActiveUnitType.Ship, ship_0.DBID, Client.smethod_46());
			text = text.Replace("<%PlatformName%>", string.Concat(new string[]
			{
				"#",
				Conversions.ToString(this.int_0),
				" - ",
				ship_0.string_2,
				" (",
				tuple.Item1,
				" - ",
				tuple.Item2,
				")",
				text2
			}));
			text = text.Replace("<%Image%>", this.method_23(ship_0));
			text = text.Replace("<%Description%>", this.method_25(ship_0));
			text = text.Replace("<%General%>", this.method_19(ship_0));
			text = text.Replace("<%Sensors%>", this.method_26(ship_0));
			text = text.Replace("<%MineCountermeasures%>", this.method_27(ship_0));
			text = text.Replace("<%Mounts%>", this.method_28(ship_0));
			text = text.Replace("<%Stores%>", "");
			text = text.Replace("<%Loadouts%>", "");
			text = text.Replace("<%Magazines%>", this.method_31(ship_0));
			text = text.Replace("<%Comms%>", this.method_32(ship_0));
			text = text.Replace("<%AirFacilities%>", this.method_33(ship_0));
			text = text.Replace("<%DockingFacilities%>", this.method_34(ship_0));
			text = text.Replace("<%Signatures%>", this.method_37(ship_0));
			text = text.Replace("<%Flags%>", this.method_38(ship_0));
			text = text.Replace("<%Propulsion%>", this.method_40(ship_0));
			text = text.Replace("<%Fuel%>", this.method_41(ship_0));
			return text;
		}

		// Token: 0x06007328 RID: 29480 RVA: 0x003DC050 File Offset: 0x003DA250
		public string method_11(Submarine submarine_0)
		{
			StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "Templates\\Platform.html"));
			string text;
			using (streamReader)
			{
				text = streamReader.ReadToEnd();
			}
			string text2 = "";
			if (submarine_0.bool_23)
			{
				text2 = " -- HYPOTHETICAL UNIT";
			}
			Tuple<string, string, string> tuple = DBFunctions.smethod_84(GlobalVariables.ActiveUnitType.Submarine, submarine_0.DBID, Client.smethod_46());
			text = text.Replace("<%PlatformName%>", string.Concat(new string[]
			{
				"#",
				Conversions.ToString(this.int_0),
				" - ",
				submarine_0.string_2,
				" (",
				tuple.Item1,
				" - ",
				tuple.Item2,
				")",
				text2
			}));
			text = text.Replace("<%Image%>", this.method_23(submarine_0));
			text = text.Replace("<%Description%>", this.method_25(submarine_0));
			text = text.Replace("<%General%>", this.method_20(submarine_0));
			text = text.Replace("<%Sensors%>", this.method_26(submarine_0));
			text = text.Replace("<%MineCountermeasures%>", "");
			text = text.Replace("<%Mounts%>", this.method_28(submarine_0));
			text = text.Replace("<%Stores%>", "");
			text = text.Replace("<%Loadouts%>", "");
			text = text.Replace("<%Magazines%>", this.method_31(submarine_0));
			text = text.Replace("<%Comms%>", this.method_32(submarine_0));
			text = text.Replace("<%AirFacilities%>", "");
			text = text.Replace("<%DockingFacilities%>", this.method_34(submarine_0));
			text = text.Replace("<%Signatures%>", this.method_37(submarine_0));
			text = text.Replace("<%Flags%>", this.method_38(submarine_0));
			text = text.Replace("<%Propulsion%>", this.method_40(submarine_0));
			text = text.Replace("<%Fuel%>", this.method_41(submarine_0));
			return text;
		}

		// Token: 0x06007329 RID: 29481 RVA: 0x003DC258 File Offset: 0x003DA458
		public string method_12(Facility facility_0)
		{
			StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "Templates\\Platform.html"));
			string text;
			using (streamReader)
			{
				text = streamReader.ReadToEnd();
			}
			string text2 = "";
			if (facility_0.bool_23)
			{
				text2 = " -- HYPOTHETICAL UNIT";
			}
			Tuple<string, string, string> tuple = DBFunctions.smethod_84(GlobalVariables.ActiveUnitType.Facility, facility_0.DBID, Client.smethod_46());
			text = text.Replace("<%PlatformName%>", string.Concat(new string[]
			{
				"#",
				Conversions.ToString(this.int_0),
				" - ",
				facility_0.string_2,
				" (",
				tuple.Item1,
				" - ",
				tuple.Item2,
				")",
				text2
			}));
			text = text.Replace("<%Image%>", this.method_23(facility_0));
			text = text.Replace("<%Description%>", this.method_25(facility_0));
			text = text.Replace("<%General%>", this.method_21(facility_0));
			text = text.Replace("<%Sensors%>", this.method_26(facility_0));
			text = text.Replace("<%MineCountermeasures%>", "");
			text = text.Replace("<%Mounts%>", this.method_28(facility_0));
			text = text.Replace("<%Stores%>", "");
			text = text.Replace("<%Loadouts%>", "");
			text = text.Replace("<%Magazines%>", this.method_31(facility_0));
			text = text.Replace("<%Comms%>", this.method_32(facility_0));
			text = text.Replace("<%AirFacilities%>", this.method_33(facility_0));
			text = text.Replace("<%DockingFacilities%>", this.method_34(facility_0));
			text = text.Replace("<%Signatures%>", this.method_37(facility_0));
			text = text.Replace("<%Flags%>", "");
			return text;
		}

		// Token: 0x0600732A RID: 29482 RVA: 0x003DC43C File Offset: 0x003DA63C
		public string method_13(Satellite satellite_0)
		{
			StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "Templates\\Platform.html"));
			string text;
			using (streamReader)
			{
				text = streamReader.ReadToEnd();
			}
			string text2 = "";
			if (satellite_0.bool_23)
			{
				text2 = " -- HYPOTHETICAL UNIT";
			}
			Tuple<string, string, string> tuple = DBFunctions.smethod_84(GlobalVariables.ActiveUnitType.Satellite, satellite_0.DBID, Client.smethod_46());
			text = text.Replace("<%PlatformName%>", string.Concat(new string[]
			{
				"#",
				Conversions.ToString(this.int_0),
				" - ",
				satellite_0.string_2,
				" (",
				tuple.Item1,
				" - ",
				tuple.Item2,
				")",
				text2
			}));
			text = text.Replace("<%Image%>", this.method_23(satellite_0));
			text = text.Replace("<%Description%>", this.method_25(satellite_0));
			text = text.Replace("<%General%>", this.method_22(satellite_0));
			text = text.Replace("<%Sensors%>", this.method_26(satellite_0));
			text = text.Replace("<%MineCountermeasures%>", "");
			text = text.Replace("<%Mounts%>", this.method_28(satellite_0));
			text = text.Replace("<%Stores%>", "");
			text = text.Replace("<%Loadouts%>", "");
			text = text.Replace("<%Magazines%>", "");
			text = text.Replace("<%AirFacilities%>", "");
			text = text.Replace("<%DockingFacilities%>", "");
			text = text.Replace("<%Signatures%>", this.method_37(satellite_0));
			text = text.Replace("<%Flags%>", this.method_38(satellite_0));
			return text;
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x003DC608 File Offset: 0x003DA808
		public string method_14(Aircraft aircraft_0)
		{
			string text = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>GENERAL DATA</strong></span></div>";
			StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "Templates\\Aircraft.html"));
			using (streamReader)
			{
				text += streamReader.ReadToEnd();
			}
			text += "<br/>";
			text = text.Replace("<%Category%>", Misc.smethod_32(aircraft_0.enum40_0, Client.smethod_46().method_39()));
			text = text.Replace("<%Type%>", Misc.smethod_31(aircraft_0._AircraftType_0, Client.smethod_46().method_39()));
			text = text.Replace("<%Length%>", Conversions.ToString(aircraft_0.float_13));
			text = text.Replace("<%ClimbRate%>", string.Format("{0:0.0}", aircraft_0.method_159().vmethod_14(false)));
			text = text.Replace("<%InstantaneousClimbRate%>", string.Format("{0:0.0}", aircraft_0.method_159().vmethod_14(false) * 3f));
			text = text.Replace("<%ClimbRateFeetPrMin%>", Conversions.ToString(Conversions.ToInteger(string.Format("{0:0.0}", (double)aircraft_0.method_159().vmethod_14(false) / 0.3048 * 60.0 / 10.0)) * 10));
			text = text.Replace("<%InstantaneousClimbRateFeetPrMin%>", Conversions.ToString(Conversions.ToInteger(string.Format("{0:0.0}", (double)(aircraft_0.method_159().vmethod_14(false) * 3f) / 0.3048 * 60.0 / 10.0)) * 10));
			text = text.Replace("<%Span%>", Conversions.ToString(aircraft_0.float_27));
			text = text.Replace("<%Height%>", Conversions.ToString(aircraft_0.float_28));
			text = text.Replace("<%Agility%>", Conversions.ToString(aircraft_0.float_25));
			text = text.Replace("<%EmptyWeight%>", Conversions.ToString(aircraft_0.int_0));
			text = text.Replace("<%MaxWeight%>", Conversions.ToString(aircraft_0.int_1));
			text = text.Replace("<%MaxPayloadWeight%>", Conversions.ToString(aircraft_0.int_2));
			text = text.Replace("<%Crew%>", Conversions.ToString(aircraft_0.int_6));
			text = text.Replace("<%Visibility%>", this.method_15(aircraft_0));
			text = text.Replace("<%Armor%>", this.method_16(aircraft_0));
			text = text.Replace("<%RunwayLengthNeeded%>", Misc.smethod_40(aircraft_0.enum146_0, Client.smethod_46().method_39()));
			text = text.Replace("<%PhysicalSize%>", Misc.smethod_33(aircraft_0.aircraftSizeClass_0, Client.smethod_46().method_39()));
			text = text.Replace("<%OODA%>", this.method_17(aircraft_0.vmethod_56(), aircraft_0.DBID));
			text = text.Replace("<%DamagePoints%>", Conversions.ToString(aircraft_0.vmethod_63(false, null)));
			return text;
		}

		// Token: 0x0600732C RID: 29484 RVA: 0x003DC904 File Offset: 0x003DAB04
		private string method_15(Aircraft aircraft_0)
		{
			string result;
			if (Client.smethod_46().FeatureCompatibility.CockpitVisibility)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("Forward: ").Append(Misc.smethod_19(aircraft_0.enum38_0)).Append("<br>");
				stringBuilder.Append("Sideways: ").Append(Misc.smethod_19(aircraft_0.enum38_1)).Append("<br>");
				stringBuilder.Append("Aft: ").Append(Misc.smethod_19(aircraft_0.enum38_2));
				result = stringBuilder.ToString();
			}
			else
			{
				result = "Not supported by this database.";
			}
			return result;
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x003DC9A0 File Offset: 0x003DABA0
		private string method_16(Aircraft aircraft_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Fuselage: ").Append(Misc.smethod_38(aircraft_0.armorRating_1, Client.smethod_46().method_39())).Append("<br>");
			stringBuilder.Append("Cockpit: ").Append(Misc.smethod_38(aircraft_0.armorRating_0, Client.smethod_46().method_39())).Append("<br>");
			stringBuilder.Append("Powerplant: ").Append(Misc.smethod_38(aircraft_0.armorRating_2, Client.smethod_46().method_39()));
			return stringBuilder.ToString();
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x003DCA40 File Offset: 0x003DAC40
		public string method_17(GlobalVariables.ActiveUnitType activeUnitType_0, int int_1)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int value;
			int num;
			int num2;
			DBFunctions.smethod_15(activeUnitType_0, int_1, Client.smethod_46().method_39(), ref value, ref num, ref num2);
			stringBuilder.Append("<table style='font-family:Verdana;font-size:8pt'>");
			stringBuilder.Append("<tr>");
			stringBuilder.Append("<td>Detection:</td><td>" + Conversions.ToString(value) + " seconds Observe, Orient, Decide, and Act (reaction time)<td>");
			stringBuilder.Append("</tr>");
			stringBuilder.Append("<tr>");
			stringBuilder.Append(string.Concat(new string[]
			{
				"<td valign=top>Targeting:</td><td>",
				string.Format("{0:0}", num * 2),
				" seconds (Novice Proficiency Level)<br>",
				string.Format("{0:0}", (double)num * 1.5),
				" seconds (Cadet)<br>",
				string.Format("{0:0}", (double)num * 1.2),
				" seconds (Regular)<br>",
				string.Format("{0:0}", num),
				" seconds (Veteran)<br>",
				string.Format("{0:0}", (double)num * 0.8),
				" seconds (Ace)</td>"
			}));
			stringBuilder.Append("</tr>");
			stringBuilder.Append("<tr>");
			stringBuilder.Append("<td>Evasion:</td><td>" + string.Format("{0:0}", num2) + " seconds</td>");
			stringBuilder.Append("</tr>");
			stringBuilder.Append("</table>");
			return stringBuilder.ToString();
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x003DCBDC File Offset: 0x003DADDC
		public string method_18(Weapon weapon_0)
		{
			string text = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>GENERAL DATA</strong></span></div>";
			StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "Templates\\Weapon.html"));
			using (streamReader)
			{
				text += streamReader.ReadToEnd();
			}
			text += "<br/>";
			text = text.Replace("<%Type%>", Misc.smethod_55(weapon_0.method_167()));
			if (weapon_0.float_25 > 0f)
			{
				text = text.Replace("<%Span%>", Conversions.ToString(weapon_0.float_25) + " m");
			}
			else
			{
				text = text.Replace("<%Span%>", "-");
			}
			if (weapon_0.float_13 > 0f)
			{
				text = text.Replace("<%Length%>", Conversions.ToString(weapon_0.float_13) + " m");
			}
			else
			{
				text = text.Replace("<%Length%>", "-");
			}
			if (weapon_0.float_26 > 0f)
			{
				text = text.Replace("<%Diameter%>", Conversions.ToString(weapon_0.float_26) + " m");
			}
			else
			{
				text = text.Replace("<%Diameter%>", "-");
			}
			if (weapon_0.int_0 > 0)
			{
				text = text.Replace("<%Weight%>", Conversions.ToString(weapon_0.int_0) + " kg");
			}
			else
			{
				text = text.Replace("<%Weight%>", "-");
			}
			if (weapon_0.int_6 > 0)
			{
				text = text.Replace("<%BurnoutWeight%>", Conversions.ToString(weapon_0.int_6) + " kg");
			}
			else
			{
				text = text.Replace("<%BurnoutWeight%>", "-");
			}
			if (weapon_0.float_27 > 0f)
			{
				text = text.Replace("<%CruiseAlt%>", string.Format("{0:0.0}", weapon_0.float_27) + " m AGL");
				text = text.Replace("<%CruiseAltFeet%>", string.Format("{0:0}", weapon_0.float_27 * 3.28084f) + " ft AGL, ");
			}
			else if (weapon_0.method_145() > 0f)
			{
				text = text.Replace("<%CruiseAlt%>", string.Format("{0:0.0}", weapon_0.method_145()) + " m ASL");
				text = text.Replace("<%CruiseAltFeet%>", string.Format("{0:0}", weapon_0.method_145() * 3.28084f) + " ft ASL, ");
			}
			else
			{
				text = text.Replace("<%CruiseAlt%>", "");
				text = text.Replace("<%CruiseAltFeet%>", "-");
			}
			if (weapon_0.float_29 > 0f)
			{
				if (weapon_0.float_30 > 0f)
				{
					text = text.Replace("<%RangeAAW%>", Conversions.ToString(weapon_0.float_30) + " - " + Conversions.ToString(weapon_0.float_29) + " nm");
				}
				else
				{
					text = text.Replace("<%RangeAAW%>", Conversions.ToString(weapon_0.float_29) + " nm");
				}
				text = text.Replace("<%AirPOK%>", Conversions.ToString(weapon_0.int_13) + " %");
			}
			else
			{
				text = text.Replace("<%RangeAAW%>", "-");
				text = text.Replace("<%AirPOK%>", "-");
			}
			if (weapon_0.float_31 > 0f)
			{
				if (weapon_0.float_32 > 0f)
				{
					text = text.Replace("<%RangeASUW%>", Conversions.ToString(weapon_0.float_32) + " - " + Conversions.ToString(weapon_0.float_31) + " nm");
				}
				else
				{
					text = text.Replace("<%RangeASUW%>", Conversions.ToString(weapon_0.float_31) + " nm");
				}
				text = text.Replace("<%SurfPOK%>", Conversions.ToString(weapon_0.int_14) + " %");
			}
			else
			{
				text = text.Replace("<%RangeASUW%>", "-");
				text = text.Replace("<%SurfPOK%>", "-");
			}
			if (weapon_0.float_33 > 0f)
			{
				if (weapon_0.float_34 > 0f)
				{
					text = text.Replace("<%RangeLand%>", Conversions.ToString(weapon_0.float_34) + " - " + Conversions.ToString(weapon_0.float_33) + " nm");
				}
				else
				{
					text = text.Replace("<%RangeLand%>", Conversions.ToString(weapon_0.float_33) + " nm");
				}
				text = text.Replace("<%LandPOK%>", Conversions.ToString(weapon_0.int_15) + " %");
			}
			else
			{
				text = text.Replace("<%RangeLand%>", "-");
				text = text.Replace("<%LandPOK%>", "-");
			}
			if (weapon_0.float_35 > 0f)
			{
				if (weapon_0.float_36 > 0f)
				{
					text = text.Replace("<%RangeASW%>", Conversions.ToString(weapon_0.float_36) + " - " + Conversions.ToString(weapon_0.float_35) + " nm");
				}
				else
				{
					text = text.Replace("<%RangeASW%>", Conversions.ToString(weapon_0.float_35) + " nm");
				}
				text = text.Replace("<%SubPOK%>", Conversions.ToString(weapon_0.int_16) + " %");
			}
			else
			{
				text = text.Replace("<%RangeASW%>", "-");
				text = text.Replace("<%SubPOK%>", "-");
			}
			if (weapon_0.float_31 > 0f && weapon_0.method_172() > 0)
			{
				text = text.Replace("<%CEP_Surface%>", Conversions.ToString(weapon_0.method_172()) + " m");
			}
			else
			{
				text = text.Replace("<%CEP_Surface%>", "-");
			}
			if (weapon_0.float_33 > 0f && weapon_0.method_174() > 0)
			{
				text = text.Replace("<%CEP_Land%>", Conversions.ToString(weapon_0.method_174()) + " m");
			}
			else
			{
				text = text.Replace("<%CEP_Land%>", "-");
			}
			if (weapon_0.float_39 > 0f && weapon_0.float_43 > 0f)
			{
				if (weapon_0.float_40 <= 0f && weapon_0.float_44 <= 0f)
				{
					text = text.Replace("<%LaunchAltMin%>", string.Format("{0:0.0}", weapon_0.float_43) + " m ASL and " + string.Format("{0:0.0}", weapon_0.float_39) + " m AGL ");
					text = text.Replace("<%LaunchAltFeetMin%>", string.Format("{0:0}", weapon_0.float_43 * 3.28084f) + " ft ASL and " + string.Format("{0:0}", weapon_0.float_39 * 3.28084f) + " ft AGL, ");
				}
				else
				{
					text = text.Replace("<%LaunchAltMin%>", string.Format("{0:0.0}", weapon_0.float_43) + " m ASL and " + string.Format("{0:0.0}", weapon_0.float_39) + " m AGL - ");
					text = text.Replace("<%LaunchAltFeetMin%>", string.Format("{0:0}", weapon_0.float_43 * 3.28084f) + " ft ASL and " + string.Format("{0:0}", weapon_0.float_39 * 3.28084f) + " ft AGL - ");
				}
			}
			else if (weapon_0.float_43 > 0f)
			{
				if (weapon_0.float_40 <= 0f && weapon_0.float_44 <= 0f)
				{
					text = text.Replace("<%LaunchAltMin%>", string.Format("{0:0.0}", weapon_0.float_43) + " m ASL");
					text = text.Replace("<%LaunchAltFeetMin%>", string.Format("{0:0}", weapon_0.float_43 * 3.28084f) + " ft ASL, ");
				}
				else
				{
					text = text.Replace("<%LaunchAltMin%>", string.Format("{0:0.0}", weapon_0.float_43) + " m ASL - ");
					text = text.Replace("<%LaunchAltFeetMin%>", string.Format("{0:0}", weapon_0.float_43 * 3.28084f) + " ft ASL - ");
				}
			}
			else if (weapon_0.float_39 > 0f)
			{
				if (weapon_0.float_40 <= 0f && weapon_0.float_44 <= 0f)
				{
					text = text.Replace("<%LaunchAltMin%>", string.Format("{0:0.0}", weapon_0.float_39) + " m AGL");
					text = text.Replace("<%LaunchAltFeetMin%>", string.Format("{0:0}", weapon_0.float_39 * 3.28084f) + " ft AGL, ");
				}
				else
				{
					text = text.Replace("<%LaunchAltMin%>", string.Format("{0:0.0}", weapon_0.float_39) + " m AGL -");
					text = text.Replace("<%LaunchAltFeetMin%>", string.Format("{0:0}", weapon_0.float_39 * 3.28084f) + " ft AGL - ");
				}
			}
			else if (weapon_0.float_43 > 0f && (weapon_0.float_40 <= 0f || weapon_0.float_44 <= 0f))
			{
				text = text.Replace("<%LaunchAltMin%>", string.Format("{0:0.0}", weapon_0.float_43) + " m ASL");
				text = text.Replace("<%LaunchAltFeetMin%>", string.Format("{0:0}", weapon_0.float_43 * 3.28084f) + " ft ASL, ");
			}
			else if (weapon_0.method_167() != Weapon._WeaponType.Torpedo && !weapon_0.method_155())
			{
				if (weapon_0.method_167() == Weapon._WeaponType.GuidedWeapon && weapon_0.float_39 < 0f)
				{
					text = text.Replace("<%LaunchAltMin%>", string.Format("{0:0.0}", weapon_0.float_43) + " m - ");
					text = text.Replace("<%LaunchAltFeetMin%>", string.Format("{0:0}", weapon_0.float_43 * 3.28084f) + " ft - ");
				}
				else if (weapon_0.method_167() == Weapon._WeaponType.GuidedWeapon && weapon_0.float_43 < 0f)
				{
					text = text.Replace("<%LaunchAltMin%>", string.Format("{0:0.0}", weapon_0.float_43) + " m - ");
					text = text.Replace("<%LaunchAltFeetMin%>", string.Format("{0:0}", weapon_0.float_43 * 3.28084f) + " ft - ");
				}
				else if (weapon_0.float_40 == 0f && weapon_0.float_44 == 0f && weapon_0.float_39 == 0f && weapon_0.float_43 == 0f)
				{
					text = text.Replace("<%LaunchAltMin%>", "-");
					text = text.Replace("<%LaunchAltFeetMin%>", "");
				}
				else if (weapon_0.method_167() == Weapon._WeaponType.RV | weapon_0.method_167() == Weapon._WeaponType.HGV)
				{
					text = text.Replace("<%LaunchAltMin%>", "-");
					text = text.Replace("<%LaunchAltFeetMin%>", "");
				}
				else
				{
					text = text.Replace("<%LaunchAltMin%>", "");
					text = text.Replace("<%LaunchAltFeetMin%>", "");
				}
			}
			else if (weapon_0.scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(weapon_0.scenario_0.method_39()))
			{
				text = text.Replace("<%LaunchAltMin%>", string.Format("{0:0.0}", weapon_0.float_43) + " m - ");
				text = text.Replace("<%LaunchAltFeetMin%>", string.Format("{0:0}", weapon_0.float_43 * 3.28084f) + " ft - ");
			}
			else
			{
				text = text.Replace("<%LaunchAltMin%>", string.Format("{0:0.0}", weapon_0.float_39) + " m - ");
				text = text.Replace("<%LaunchAltFeetMin%>", string.Format("{0:0}", weapon_0.float_39 * 3.28084f) + " ft, ");
			}
			if (weapon_0.float_40 > 0f && weapon_0.float_44 > 0f)
			{
				text = text.Replace("<%LaunchAltMax%>", string.Format("{0:0.0}", weapon_0.float_44, 0) + " m ASL and " + string.Format("{0:0.0}", weapon_0.float_40, 0) + " m AGL");
				text = text.Replace("<%LaunchAltFeetMax%>", string.Format("{0:0}", weapon_0.float_44 * 3.28084f) + " ft ASL and " + Conversions.ToString(Conversions.ToDouble(string.Format("{0:0.0}", (double)weapon_0.float_40 / 0.3048 / 10.0)) * 10.0) + " ft AGL, ");
			}
			else if (weapon_0.float_40 > 0f)
			{
				text = text.Replace("<%LaunchAltMax%>", string.Format("{0:0.0}", weapon_0.float_40, 0) + " m AGL");
				text = text.Replace("<%LaunchAltFeetMax%>", string.Format("{0:0}", weapon_0.float_40 * 3.28084f) + " ft AGL, ");
			}
			else if (weapon_0.float_44 > 0f)
			{
				text = text.Replace("<%LaunchAltMax%>", string.Format("{0:0.0}", weapon_0.float_44, 0) + " m ASL");
				text = text.Replace("<%LaunchAltFeetMax%>", string.Format("{0:0}", weapon_0.float_44 * 3.28084f) + " ft ASL, ");
			}
			else if (weapon_0.method_167() != Weapon._WeaponType.Torpedo && !weapon_0.method_155())
			{
				if (weapon_0.method_167() == Weapon._WeaponType.GuidedWeapon && weapon_0.float_39 < 0f)
				{
					text = text.Replace("<%LaunchAltMax%>", string.Format("{0:0.0}", weapon_0.float_40, 0) + " m AGL");
					text = text.Replace("<%LaunchAltFeetMax%>", string.Format("{0:0}", weapon_0.float_40 * 3.28084f) + " ft AGL, ");
				}
				else if (weapon_0.method_167() == Weapon._WeaponType.GuidedWeapon && weapon_0.float_43 < 0f)
				{
					text = text.Replace("<%LaunchAltMax%>", string.Format("{0:0.0}", weapon_0.float_44, 0) + " m ASL");
					text = text.Replace("<%LaunchAltFeetMax%>", string.Format("{0:0}", weapon_0.float_44 * 3.28084f) + " ft ASL, ");
				}
				else
				{
					text = text.Replace("<%LaunchAltMax%>", "");
					text = text.Replace("<%LaunchAltFeetMax%>", "");
				}
			}
			else if (weapon_0.scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(weapon_0.scenario_0.method_39()))
			{
				text = text.Replace("<%LaunchAltMax%>", string.Format("{0:0.0}", weapon_0.float_44, 0) + " m");
				text = text.Replace("<%LaunchAltFeetMax%>", string.Format("{0:0}", weapon_0.float_44 * 3.28084f) + " ft, ");
			}
			else
			{
				text = text.Replace("<%LaunchAltMax%>", string.Format("{0:0.0}", weapon_0.float_40, 0) + " m");
				text = text.Replace("<%LaunchAltFeetMax%>", string.Format("{0:0}", weapon_0.float_40 * 3.28084f) + " ft, ");
			}
			if (weapon_0.int_18 >= 0 && weapon_0.int_17 > 0)
			{
				text = text.Replace("<%LaunchSpdMin%>", Conversions.ToString(weapon_0.int_18) + " - ");
			}
			else if (weapon_0.int_18 > 0 && weapon_0.int_17 <= 0)
			{
				text = text.Replace("<%LaunchSpdMin%>", Conversions.ToString(weapon_0.int_18) + " kt");
			}
			else
			{
				text = text.Replace("<%LaunchSpdMin%>", "-");
			}
			if (weapon_0.int_17 > 0)
			{
				text = text.Replace("<%LaunchSpdMax%>", Conversions.ToString(weapon_0.int_17) + " kt");
			}
			else
			{
				text = text.Replace("<%LaunchSpdMax%>", "");
			}
			if (weapon_0.int_19 >= 0 && weapon_0.int_20 > 0)
			{
				text = text.Replace("<%TargetSpdMin%>", Conversions.ToString(weapon_0.int_19) + " - ");
			}
			else if (weapon_0.int_19 > 0 && weapon_0.int_20 <= 0)
			{
				text = text.Replace("<%TargetSpdMin%>", Conversions.ToString(weapon_0.int_19) + " kt");
			}
			else if (weapon_0.int_19 <= 0 && weapon_0.int_20 > 0)
			{
				text = text.Replace("<%TargetSpdMin%>", "n/a");
			}
			else
			{
				text = text.Replace("<%TargetSpdMin%>", "-");
			}
			if (weapon_0.int_20 > 0)
			{
				text = text.Replace("<%TargetSpdMax%>", Conversions.ToString(weapon_0.int_20) + " kt");
			}
			else
			{
				text = text.Replace("<%TargetSpdMax%>", "");
			}
			if (weapon_0.float_41 > 0f && (weapon_0.float_42 > 0f || weapon_0.float_46 > 0f))
			{
				text = text.Replace("<%TargetAltMin%>", string.Format("{0:0.0}", weapon_0.float_41, 0) + " m AGL - ");
				text = text.Replace("<%TargetAltFeetMin%>", string.Format("{0:0}", weapon_0.float_41 * 3.28084f) + " ft AGL - ");
			}
			else if (weapon_0.float_45 > 0f && (weapon_0.float_42 > 0f || weapon_0.float_46 > 0f))
			{
				text = text.Replace("<%TargetAltMin%>", string.Format("{0:0.0}", weapon_0.float_45, 0) + " m ASL - ");
				text = text.Replace("<%TargetAltFeetMin%>", string.Format("{0:0}", weapon_0.float_45 * 3.28084f) + " ft ASL - ");
			}
			else if (weapon_0.float_41 > 0f && (weapon_0.float_42 <= 0f || weapon_0.float_46 <= 0f))
			{
				text = text.Replace("<%TargetAltMin%>", string.Format("{0:0.0}", weapon_0.float_41, 0) + " m AGL - ");
				text = text.Replace("<%TargetAltFeetMin%>", string.Format("{0:0}", weapon_0.float_41 * 3.28084f) + " ft AGL - ");
			}
			else if (weapon_0.float_45 > 0f && (weapon_0.float_42 <= 0f || weapon_0.float_46 <= 0f))
			{
				text = text.Replace("<%TargetAltMin%>", string.Format("{0:0.0}", weapon_0.float_45, 0) + " m ASL - ");
				text = text.Replace("<%TargetAltFeetMin%>", string.Format("{0:0}", weapon_0.float_45 * 3.28084f) + " ft ASL - ");
			}
			else if (weapon_0.float_41 <= 0f && (weapon_0.float_42 > 0f || weapon_0.float_46 > 0f))
			{
				text = text.Replace("<%TargetAltMin%>", "n/a");
				text = text.Replace("<%TargetAltFeetMin%>", "n/a");
			}
			else if (weapon_0.float_45 <= 0f && (weapon_0.float_42 > 0f || weapon_0.float_46 > 0f))
			{
				text = text.Replace("<%TargetAltMin%>", "n/a");
				text = text.Replace("<%TargetAltFeetMin%>", "n/a");
			}
			else if (weapon_0.method_167() != Weapon._WeaponType.Torpedo && !weapon_0.method_155())
			{
				text = text.Replace("<%TargetAltMin%>", "-");
				text = text.Replace("<%TargetAltFeetMin%>", "");
			}
			else if (weapon_0.scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(weapon_0.scenario_0.method_39()))
			{
				text = text.Replace("<%TargetAltMin%>", string.Format("{0:0.0}", weapon_0.float_45, 0) + " m - ");
				text = text.Replace("<%TargetAltFeetMin%>", string.Format("{0:0}", weapon_0.float_45 * 3.28084f) + " ft - ");
			}
			else
			{
				text = text.Replace("<%TargetAltMin%>", string.Format("{0:0.0}", weapon_0.float_41, 0) + " m - ");
				text = text.Replace("<%TargetAltFeetMin%>", string.Format("{0:0}", weapon_0.float_41 * 3.28084f) + " ft - ");
			}
			if (weapon_0.float_42 > 0f)
			{
				text = text.Replace("<%TargetAltMax%>", string.Format("{0:0.0}", weapon_0.float_42, 0) + " m AGL");
				text = text.Replace("<%TargetAltFeetMax%>", string.Format("{0:0}", weapon_0.float_42 * 3.28084f) + " ft AGL, ");
			}
			else if (weapon_0.float_46 > 0f)
			{
				text = text.Replace("<%TargetAltMax%>", string.Format("{0:0.0}", weapon_0.float_46, 0) + " m ASL");
				text = text.Replace("<%TargetAltFeetMax%>", string.Format("{0:0}", weapon_0.float_46 * 3.28084f) + " ft ASL, ");
			}
			else if (weapon_0.method_167() != Weapon._WeaponType.Torpedo && !weapon_0.method_155())
			{
				text = text.Replace("<%TargetAltMax%>", "");
				text = text.Replace("<%TargetAltFeetMax%>", "");
			}
			else if (weapon_0.scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(weapon_0.scenario_0.method_39()))
			{
				text = text.Replace("<%TargetAltMax%>", string.Format("{0:0.0}", weapon_0.float_46, 0) + " m");
				text = text.Replace("<%TargetAltFeetMax%>", string.Format("{0:0}", weapon_0.float_46 * 3.28084f) + " ft, ");
			}
			else
			{
				text = text.Replace("<%TargetAltMax%>", string.Format("{0:0.0}", weapon_0.float_42, 0) + " m");
				text = text.Replace("<%TargetAltFeetMax%>", string.Format("{0:0}", weapon_0.float_42 * 3.28084f) + " ft, ");
			}
			if (weapon_0.vmethod_143().vmethod_14(true) > 0f)
			{
				text = text.Replace("<%ClimbRate%>", string.Format("{0:0.0}", weapon_0.vmethod_143().vmethod_14(true)) + " m/sec");
				text = text.Replace("<%ClimbRateFeetPrMin%>", string.Format("{0:0}", weapon_0.vmethod_143().vmethod_14(true) * 3.28084f) + " ft/min, ");
			}
			else
			{
				text = text.Replace("<%ClimbRate%>", "");
				text = text.Replace("<%ClimbRateFeetPrMin%>", "-");
			}
			if (weapon_0.method_167() == Weapon._WeaponType.GuidedWeapon && weapon_0.method_199() && weapon_0.float_47 > 0f)
			{
				text = text.Replace("<%SnapUpDownAltitude%>", string.Concat(new string[]
				{
					"<td>Snap Up / Down Altitude:</td><td colspan = 9>",
					string.Format("{0:0}", weapon_0.float_47 * 3.28084f),
					" ft, ",
					string.Format("{0:0.0}", weapon_0.float_47),
					" m</td>"
				}));
			}
			if (weapon_0.method_167() == Weapon._WeaponType.GuidedWeapon || weapon_0.method_167() == Weapon._WeaponType.Torpedo)
			{
				text = text.Replace("<%GuidanceType%>", "<td>Guidance Type:</td><td colspan = 9>" + weapon_0.method_274() + (weapon_0.struct36_0.bool_57 ? " - Capable of re-attack" : "") + "</td>");
			}
			List<float> list = new List<float>();
			try
			{
				list = DBFunctions.smethod_14(weapon_0.DBID, Client.smethod_46().method_39());
				if (list.Count > 0)
				{
					if (list[0] > 0f)
					{
						text = text.Replace("<%TorpedoKinematicRangeCruise%>", string.Concat(new string[]
						{
							"<td>Kinematic Range:</td><td>",
							Conversions.ToString(list[1]),
							" nm at ",
							Conversions.ToString(list[0]),
							" kt</td>"
						}));
					}
					else
					{
						text = text.Replace("<%TorpedoKinematicRangeCruise%>", "<td></td><td></td>");
					}
					if (list[3] > 0f)
					{
						text = text.Replace("<%TorpedoKinematicRangeFull%>", string.Concat(new string[]
						{
							"<td></td><td>",
							Conversions.ToString(list[3]),
							" nm at ",
							Conversions.ToString(list[2]),
							" kt</td>"
						}));
					}
					else
					{
						text = text.Replace("<%TorpedoKinematicRangeFull%>", "<td></td><td></td>");
					}
				}
				else
				{
					text = text.Replace("<%TorpedoKinematicRangeCruise%>", "<td></td><td></td>");
					text = text.Replace("<%TorpedoKinematicRangeFull%>", "<td></td><td></td>");
				}
			}
			catch (Exception ex)
			{
				text = text.Replace("<%TorpedoKinematicRangeCruise%>", "<td></td><td></td>");
				text = text.Replace("<%TorpedoKinematicRangeFull%>", "<td></td><td></td>");
				ex.Data.Add("Error at 200375", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return text;
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x003DE734 File Offset: 0x003DC934
		public string method_19(Ship ship_0)
		{
			string text = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>GENERAL DATA</strong></span></div>";
			StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "Templates\\Ship.html"));
			using (streamReader)
			{
				text += streamReader.ReadToEnd();
			}
			text += "<br/>";
			text = text.Replace("<%Category%>", Misc.smethod_35(ship_0.enum118_0, Client.smethod_46().method_39()));
			text = text.Replace("<%Type%>", Misc.smethod_34(ship_0._ShipType_0, Client.smethod_46().method_39()));
			text = text.Replace("<%DamagePts%>", Conversions.ToString(ship_0.method_60()));
			text = text.Replace("<%Length%>", Conversions.ToString(ship_0.float_13));
			text = text.Replace("<%Beam%>", Conversions.ToString(ship_0.float_25));
			text = text.Replace("<%Draft%>", Conversions.ToString(ship_0.float_26));
			text = text.Replace("<%Height%>", Conversions.ToString(ship_0.float_27));
			text = text.Replace("<%Crew%>", Conversions.ToString(ship_0.int_6));
			if (ship_0.imethod_4() > 0f)
			{
				text = text.Replace("<%Displacement_Empty%>", Conversions.ToString(ship_0.imethod_4()) + " tons");
			}
			else
			{
				text = text.Replace("<%Displacement_Empty%>", "-");
			}
			text = text.Replace("<%Displacement_Standard%>", Conversions.ToString(ship_0.imethod_6()) + " tons");
			if (ship_0.imethod_8() > 0f)
			{
				text = text.Replace("<%Displacement_Full%>", Conversions.ToString(ship_0.imethod_8()) + " tons");
			}
			else
			{
				text = text.Replace("<%Displacement_Full%>", "-");
			}
			text = text.Replace("<%DockingPhysicalSize%>", Misc.smethod_39(ship_0.enum50_0, Client.smethod_46().method_39()));
			text = text.Replace("<%MaxSeaState%>", Conversions.ToString(ship_0.byte_0));
			text = text.Replace("<%TroopCapacity%>", Class268.smethod_0(ship_0));
			text = text.Replace("<%CargoCapacity%>", Class268.smethod_1(ship_0));
			text = text.Replace("<%Armor_Belt%>", Misc.smethod_38(ship_0.armorRating_2, Client.smethod_46().method_39()));
			text = text.Replace("<%Armor_Bulkhead%>", Misc.smethod_38(ship_0.armorRating_3, Client.smethod_46().method_39()));
			text = text.Replace("<%Armor_Deck%>", Misc.smethod_38(ship_0.armorRating_4, Client.smethod_46().method_39()));
			text = text.Replace("<%Armor_Engineering%>", Misc.smethod_38(ship_0.armorRating_1, Client.smethod_46().method_39()));
			text = text.Replace("<%Armor_Bridge%>", Misc.smethod_38(ship_0.armorRating_0, Client.smethod_46().method_39()));
			text = text.Replace("<%Armor_CIC%>", Misc.smethod_38(ship_0.armorRating_5, Client.smethod_46().method_39()));
			text = text.Replace("<%Armor_Rudder%>", Misc.smethod_38(ship_0.armorRating_6, Client.smethod_46().method_39()));
			text = text.Replace("<%OODA%>", this.method_17(ship_0.vmethod_56(), ship_0.DBID));
			text = text.Replace("<%MissileDefence%>", Conversions.ToString((int)ship_0.short_5) + " Harpoon / SLAM / Maverick equivalents");
			return text;
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x003DEA88 File Offset: 0x003DCC88
		public string method_20(Submarine submarine_0)
		{
			string text = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>GENERAL DATA</strong></span></div>";
			StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "Templates\\Submarine.html"));
			using (streamReader)
			{
				text += streamReader.ReadToEnd();
			}
			text += "<br/>";
			text = text.Replace("<%Category%>", Misc.smethod_37(submarine_0.enum120_0, Client.smethod_46().method_39()));
			text = text.Replace("<%Type%>", Misc.smethod_36(submarine_0._SubmarineType_0, Client.smethod_46().method_39()));
			text = text.Replace("<%DamagePts%>", Conversions.ToString(submarine_0.method_60()));
			text = text.Replace("<%Length%>", Conversions.ToString(submarine_0.float_13));
			text = text.Replace("<%Beam%>", Conversions.ToString(submarine_0.float_25));
			text = text.Replace("<%Draft%>", Conversions.ToString(submarine_0.float_26));
			text = text.Replace("<%Height%>", Conversions.ToString(submarine_0.float_27));
			text = text.Replace("<%Crew%>", Conversions.ToString(submarine_0.int_6));
			if (submarine_0.imethod_4() > 0f)
			{
				text = text.Replace("<%Displacement_Empty%>", Conversions.ToString(submarine_0.imethod_4()) + " tons");
			}
			else
			{
				text = text.Replace("<%Displacement_Empty%>", "-");
			}
			text = text.Replace("<%Displacement_Standard%>", Conversions.ToString(submarine_0.imethod_6()) + " tons");
			if (submarine_0.imethod_8() > 0f)
			{
				text = text.Replace("<%Displacement_Full%>", Conversions.ToString(submarine_0.imethod_8()) + " tons");
			}
			else
			{
				text = text.Replace("<%Displacement_Full%>", "-");
			}
			text = text.Replace("<%DockingPhysicalSize%>", Misc.smethod_39(submarine_0.enum50_0, Client.smethod_46().method_39()));
			text = text.Replace("<%ROVRadius%>", Conversions.ToString((int)submarine_0.short_3));
			text = text.Replace("<%MaxDepth%>", Conversions.ToString(submarine_0.int_7));
			text = text.Replace("<%OODA%>", this.method_17(submarine_0.vmethod_56(), submarine_0.DBID));
			return text;
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x003DECC4 File Offset: 0x003DCEC4
		public string method_21(Facility facility_0)
		{
			string text = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>GENERAL DATA</strong></span></div>";
			StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "Templates\\Facility.html"));
			using (streamReader)
			{
				text += streamReader.ReadToEnd();
			}
			text += "<br/>";
			text = text.Replace("<%Category%>", Misc.smethod_27(facility_0._FacilityCategory_0, Client.smethod_46().method_39()));
			text = text.Replace("<%DamagePts%>", Conversions.ToString(facility_0.vmethod_63(false, null)));
			text = text.Replace("<%Length%>", Conversions.ToString(facility_0.float_13));
			text = text.Replace("<%Width%>", Conversions.ToString(facility_0.float_25));
			text = text.Replace("<%Area%>", Conversions.ToString(facility_0.double_4));
			text = text.Replace("<%Crew%>", Conversions.ToString(facility_0.int_6));
			text = text.Replace("<%Armor_General%>", Misc.smethod_38(facility_0.armorRating_0, Client.smethod_46().method_39()));
			text = text.Replace("<%MastHeight%>", Conversions.ToString(facility_0.int_7));
			text = text.Replace("<%AimpointDispersalRadius%>", Conversions.ToString(facility_0.int_9));
			text = text.Replace("<%OODA%>", this.method_17(facility_0.vmethod_56(), facility_0.DBID));
			text = text.Replace("<%MissileDefence%>", Conversions.ToString(facility_0.int_8) + " Harpoon / SLAM / Maverick equivalents");
			return text;
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x003DEE48 File Offset: 0x003DD048
		public string method_22(Satellite satellite_0)
		{
			string text = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>GENERAL DATA</strong></span></div>";
			StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "Templates\\Satellite.html"));
			using (streamReader)
			{
				text += streamReader.ReadToEnd();
			}
			text += "<br/>";
			text = text.Replace("<%Category%>", Misc.smethod_24(satellite_0._SatelliteCategory_0, Client.smethod_46().method_39()));
			text = text.Replace("<%Type%>", Misc.smethod_23(satellite_0._SatelliteType_0, Client.smethod_46().method_39()));
			text = text.Replace("<%DamagePts%>", Conversions.ToString(satellite_0.method_60()));
			text = text.Replace("<%Length%>", Conversions.ToString(satellite_0.float_13));
			text = text.Replace("<%Span%>", Conversions.ToString(satellite_0.float_25));
			text = text.Replace("<%Height%>", Conversions.ToString(satellite_0.float_26));
			text = text.Replace("<%WeightEmpty%>", Conversions.ToString(satellite_0.double_4));
			text = text.Replace("<%WeightMax%>", Conversions.ToString(satellite_0.double_5));
			text = text.Replace("<%WeightPayload%>", Conversions.ToString(satellite_0.double_6));
			text = text.Replace("<%Armor%>", Misc.smethod_38(satellite_0.armorRating_0, Client.smethod_46().method_39()));
			text = text.Replace("<%OODA%>", "-");
			return text;
		}

		// Token: 0x06007334 RID: 29492 RVA: 0x003DEFC0 File Offset: 0x003DD1C0
		public string method_23(ActiveUnit activeUnit_0)
		{
			InternalDBViewer.Class2490 @class = new InternalDBViewer.Class2490(@class);
			string str = "";
			DBRecord dbrecord = DBOps.smethod_10(Client.smethod_46().method_7(), ref this.dbfileCheckResult_0, false, false);
			switch (dbrecord.DBID)
			{
			case 1:
				str = "DB3000";
				break;
			case 2:
				str = "CWDB";
				break;
			case 3:
				str = "WW2DB";
				break;
			}
			this.Text = "Database Viewer: " + dbrecord.string_1;
			string path = Path.Combine(GameGeneral.string_7, "Images\\" + str);
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			@class.string_0 = Class2564.smethod_2(activeUnit_0);
			@class.list_0 = Class2564.smethod_3(activeUnit_0);
			string result;
			if (@class.list_0.Count == 0)
			{
				result = string.Empty;
			}
			else
			{
				string text = @class.list_0[0];
				string text2 = @class.list_0[1];
				string text3 = @class.list_0[2];
				string text4 = @class.list_0[3];
				string text5 = @class.list_0[4];
				string text6 = @class.list_0[5];
				Task.Factory.StartNew(new Action(@class.method_0));
				string text7;
				if (File.Exists(@class.string_0))
				{
					text7 = "<div><table width='100%'><tr><td width='10%'><td><td width='80%' align='center'><img src='" + @class.string_0 + "' width='900px'  style='float:middle;margin:0 5px 5px 0;' /></td><td width='10%'></td></tr></table></div><br/>";
					if (File.Exists(text) || File.Exists(text2) || File.Exists(text3))
					{
						text7 += "<div align = 'center'>";
						if (File.Exists(text))
						{
							text7 = text7 + "<img src='" + text + "' width='250px' style='float:middle;margin:0 5px 5px 0;'/>";
						}
						if (File.Exists(text2))
						{
							text7 = text7 + "<img src='" + text2 + "' width='250px' style='float:middle;margin:0 5px 5px 0;' />";
						}
						if (File.Exists(text3))
						{
							text7 = text7 + "<img src='" + text3 + "' width='250px' style='float:middle;margin:0 5px 5px 0;' />";
						}
						text7 += "</div><br/>";
					}
					if (File.Exists(text4) || File.Exists(text5) || File.Exists(text6))
					{
						text7 += "<div align = 'center'>";
						if (File.Exists(text4))
						{
							text7 = text7 + "<img src='" + text4 + "' width='250px' style='float:middle;margin:0 5px 5px 0;' />";
						}
						if (File.Exists(text5))
						{
							text7 = text7 + "<img src='" + text5 + "' width='250px' style='float:middle;margin:0 5px 5px 0;' />";
						}
						if (File.Exists(text6))
						{
							text7 = text7 + "<img src='" + text6 + "' width='250px' style='float:middle;margin:0 5px 5px 0;' />";
						}
						text7 += "</div><br/>";
					}
				}
				else
				{
					text7 = "";
				}
				result = text7;
			}
			return result;
		}

		// Token: 0x06007335 RID: 29493 RVA: 0x003DF258 File Offset: 0x003DD458
		public string method_24(ActiveUnit activeUnit_0)
		{
			string str;
			if (activeUnit_0.bool_3)
			{
				str = "Aircraft";
			}
			else if (activeUnit_0.bool_6)
			{
				str = "Ship";
			}
			else if (activeUnit_0.bool_5)
			{
				str = "Submarine";
			}
			else if (activeUnit_0.bool_8)
			{
				str = "Facility";
			}
			else if (activeUnit_0.method_1())
			{
				str = "Satellite";
			}
			else
			{
				if (!activeUnit_0.bool_2)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					return string.Empty;
				}
				str = "Weapon";
			}
			string str2 = "";
			switch (DBOps.smethod_10(Client.smethod_46().method_7(), ref this.dbfileCheckResult_0, false, false).DBID)
			{
			case 1:
				str2 = "DB3000";
				break;
			case 2:
				str2 = "CWDB";
				break;
			case 3:
				str2 = "WW2DB";
				break;
			}
			string text = Path.Combine(GameGeneral.string_7, "Images\\" + str2);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_i1.jpg");
			string text3 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_i2.jpg");
			string text4 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_i3.jpg");
			string text5 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_i4.jpg");
			string text6;
			if (File.Exists(text2))
			{
				text6 = "<img src='" + text2 + "' width='200'/>";
				if (File.Exists(text3))
				{
					text6 = text6 + "<br><br><img src='" + text3 + "' width='200'/>";
				}
				if (File.Exists(text4))
				{
					text6 = text6 + "<br><br><img src='" + text4 + "' width='200'/>";
				}
				if (File.Exists(text5))
				{
					text6 = text6 + "<br><br><img src='" + text5 + "' width='200'/>";
				}
			}
			else
			{
				text6 = "";
			}
			return text6;
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x003DF460 File Offset: 0x003DD660
		public string method_25(ActiveUnit activeUnit_0)
		{
			string str;
			if (activeUnit_0.bool_3)
			{
				str = "Aircraft";
			}
			else if (activeUnit_0.bool_6)
			{
				str = "Ship";
			}
			else if (activeUnit_0.bool_5)
			{
				str = "Submarine";
			}
			else if (activeUnit_0.bool_8)
			{
				str = "Facility";
			}
			else if (activeUnit_0.method_1())
			{
				str = "Satellite";
			}
			else
			{
				if (!activeUnit_0.bool_2)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					return string.Empty;
				}
				str = "Weapon";
			}
			string str2 = "";
			switch (DBOps.smethod_10(Client.smethod_46().method_7(), ref this.dbfileCheckResult_0, false, false).DBID)
			{
			case 1:
				str2 = "DB3000";
				break;
			case 2:
				str2 = "CWDB";
				break;
			case 3:
				str2 = "WW2DB";
				break;
			}
			string text = Path.Combine(GameGeneral.string_7, "Descriptions\\" + str2);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string path = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + ".txt");
			string text3;
			if (File.Exists(path))
			{
				StreamReader streamReader = new StreamReader(path);
				string text2 = "";
				using (streamReader)
				{
					text2 += streamReader.ReadToEnd();
				}
				text2 = HttpUtility.HtmlEncode(text2);
				text3 = "<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>GENERAL DESCRIPTION</strong></span></div>";
				text3 = string.Concat(new string[]
				{
					text3,
					"<div><span><table><tr><td valign='top'>",
					this.method_24(activeUnit_0),
					"</td><td valign='top' style='font-family:Verdana;font-size:8pt;'>",
					text2.Replace(Environment.NewLine, "<br/>"),
					"</td><tr></table></span></div> <br/>"
				});
			}
			else
			{
				text3 = "";
			}
			return text3;
		}

		// Token: 0x06007337 RID: 29495 RVA: 0x003DF630 File Offset: 0x003DD830
		public string method_26(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.method_78().Length > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>SENSORS / EW</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>Model</td><td align='center'>Max Range</td><td>Notes</td><td>Abilities</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, Sensor>> enumerable = Enumerable.GroupBy<Sensor, int>(activeUnit_0.method_78(), (InternalDBViewer._Closure$__.$I85-0 == null) ? (InternalDBViewer._Closure$__.$I85-0 = new Func<Sensor, int>(InternalDBViewer._Closure$__.$I.method_0)) : InternalDBViewer._Closure$__.$I85-0);
				try
				{
					foreach (IGrouping<int, Sensor> grouping in enumerable)
					{
						Sensor sensor = Enumerable.ElementAtOrDefault<Sensor>(grouping, 0);
						string text = "";
						if (Operators.CompareString("Sensor" + Conversions.ToString(sensor.DBID), this.string_1, false) == 0)
						{
							text = "background-color:DarkGreen;";
						}
						stringBuilder.Append(string.Concat(new string[]
						{
							"<tr Name='Sensor",
							Conversions.ToString(sensor.DBID),
							"' style='color:White;",
							text,
							"font-family:Verdana;font-size:8pt;'>"
						}));
						stringBuilder.Append(string.Concat(new string[]
						{
							"<td valign='top'>",
							Conversions.ToString(Enumerable.Count<Sensor>(grouping)),
							"x ",
							sensor.Name,
							"</td>"
						}));
						if (sensor.float_0 > 0f)
						{
							stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(sensor.float_0) + " nm</td>");
						}
						else
						{
							stringBuilder.Append("<td align='center' valign='top'>-</td>");
						}
						stringBuilder.Append("<td valign='top'>" + sensor.string_2 + "</td>");
						stringBuilder.Append("<td valign='top'>");
						List<string> list = new List<string>();
						if ((sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar || sensor.sensor_Type_0 == Sensor.Sensor_Type.ESM || sensor.sensor_Type_0 == Sensor.Sensor_Type.ECM || sensor.sensor_Type_0 == Sensor.Sensor_Type.Visual || sensor.sensor_Type_0 == Sensor.Sensor_Type.Infrared || sensor.sensor_Type_0 == Sensor.Sensor_Type.BottomFixedSonar_PassiveOnly || sensor.sensor_Type_0 == Sensor.Sensor_Type.DippingSonar_ActiveOnly || sensor.sensor_Type_0 == Sensor.Sensor_Type.DippingSonar_ActivePassive || sensor.sensor_Type_0 == Sensor.Sensor_Type.DippingSonar_PassiveOnly || sensor.sensor_Type_0 == Sensor.Sensor_Type.HullSonar_ActiveOnly || sensor.sensor_Type_0 == Sensor.Sensor_Type.HullSonar_ActivePassive || sensor.sensor_Type_0 == Sensor.Sensor_Type.HullSonar_PassiveOnly || sensor.sensor_Type_0 == Sensor.Sensor_Type.PingIntercept || sensor.sensor_Type_0 == Sensor.Sensor_Type.TowedArray_ActiveOnly || sensor.sensor_Type_0 == Sensor.Sensor_Type.TowedArray_ActivePassive || sensor.sensor_Type_0 == Sensor.Sensor_Type.TowedArray_PassiveOnly || sensor.sensor_Type_0 == Sensor.Sensor_Type.VDS_ActiveOnly || sensor.sensor_Type_0 == Sensor.Sensor_Type.VDS_ActivePassive || sensor.sensor_Type_0 == Sensor.Sensor_Type.VDS_PassiveOnly) && !sensor.method_98())
						{
							List<string> list2 = list;
							Scenario scenario = Client.smethod_46();
							list2.Add(DBFunctions.smethod_34(ref scenario, (int)sensor.techGenerationClass_0) + " Technology");
						}
						if (sensor.struct32_0.bool_0)
						{
							list.Add("Air Search");
						}
						if (sensor.struct32_0.bool_1)
						{
							list.Add("Surface Search");
						}
						if (sensor.struct32_0.bool_2)
						{
							list.Add("Underwater Search");
						}
						if (sensor.struct32_0.bool_7)
						{
							list.Add("Mine & Obstacle Search");
						}
						if (sensor.struct32_0.bool_4)
						{
							list.Add("Ground Search (Fixed)");
						}
						if (sensor.struct32_0.bool_3)
						{
							list.Add("Ground Search (Mobile)");
						}
						if (sensor.struct32_0.bool_13)
						{
							list.Add("Ground-mapping only");
						}
						if (sensor.struct32_0.bool_12)
						{
							list.Add("Navigation Only");
						}
						if (sensor.struct32_0.bool_6)
						{
							list.Add("ABM & Space Search");
						}
						if (sensor.struct32_0.bool_17)
						{
							list.Add("OTH (Backscatter)");
						}
						if (sensor.struct32_0.bool_18)
						{
							list.Add("OTH (Surface Wave)");
						}
						if (sensor.struct32_0.bool_14)
						{
							list.Add("Terrain Avoidance/Following");
						}
						if (sensor.struct32_0.bool_16)
						{
							list.Add("Weather & Navigation");
						}
						if (sensor.struct32_0.bool_15)
						{
							list.Add("Weather Only");
						}
						if (sensor.struct33_0.bool_2)
						{
							list.Add("NCTR - JEM");
						}
						if (sensor.struct33_0.bool_3)
						{
							list.Add("NCTR - NBILST");
						}
						if (sensor.sensor_Type_0 == Sensor.Sensor_Type.ESM && sensor.bool_13)
						{
							list.Add("Specific Emitter ID");
						}
						if (sensor.struct32_0.bool_8)
						{
							list.Add("Range Information");
						}
						if (sensor.struct32_0.bool_10)
						{
							list.Add("Altitude Info");
						}
						if (sensor.struct32_0.bool_11)
						{
							list.Add("Speed Information");
						}
						if (sensor.struct32_0.bool_9)
						{
							list.Add("Heading Info");
						}
						stringBuilder.Append(string.Join(", ", list));
						if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar)
						{
							if (sensor.radioElectronicFrequency_0.Length > 0)
							{
								stringBuilder.Append("<br/>Operating bands (search & track): ").Append(string.Join(" / ", Enumerable.Select<Sensor.RadioElectronicFrequency, string>(sensor.radioElectronicFrequency_0, (InternalDBViewer._Closure$__.$I85-1 == null) ? (InternalDBViewer._Closure$__.$I85-1 = new Func<Sensor.RadioElectronicFrequency, string>(InternalDBViewer._Closure$__.$I.method_1)) : InternalDBViewer._Closure$__.$I85-1)));
							}
							if (sensor.radioElectronicFrequency_1.Length > 0)
							{
								stringBuilder.Append("<br/>Operating bands (FC / illumination): ").Append(string.Join(" / ", Enumerable.Select<Sensor.RadioElectronicFrequency, string>(sensor.radioElectronicFrequency_1, (InternalDBViewer._Closure$__.$I85-2 == null) ? (InternalDBViewer._Closure$__.$I85-2 = new Func<Sensor.RadioElectronicFrequency, string>(InternalDBViewer._Closure$__.$I.method_2)) : InternalDBViewer._Closure$__.$I85-2)));
							}
						}
						if ((sensor.method_72() || sensor.method_69() || sensor.method_74()) && sensor.radioElectronicFrequency_0.Length > 0)
						{
							stringBuilder.Append("<br/>Operating bands: ").Append(string.Join(" / ", Enumerable.Select<Sensor.RadioElectronicFrequency, string>(sensor.radioElectronicFrequency_0, (InternalDBViewer._Closure$__.$I85-3 == null) ? (InternalDBViewer._Closure$__.$I85-3 = new Func<Sensor.RadioElectronicFrequency, string>(InternalDBViewer._Closure$__.$I.method_3)) : InternalDBViewer._Closure$__.$I85-3)));
						}
						stringBuilder.Append("</td></tr>");
					}
				}
				finally
				{
					IEnumerator<IGrouping<int, Sensor>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x003DFD1C File Offset: 0x003DDF1C
		public string method_27(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.vmethod_95().Count > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>MINE COUNTERMEASURES GEAR</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>Model</td><td>Notes</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, Sensor>> enumerable = Enumerable.GroupBy<Sensor, int>(activeUnit_0.vmethod_95(), (InternalDBViewer._Closure$__.$I86-0 == null) ? (InternalDBViewer._Closure$__.$I86-0 = new Func<Sensor, int>(InternalDBViewer._Closure$__.$I.method_4)) : InternalDBViewer._Closure$__.$I86-0);
				try
				{
					foreach (IGrouping<int, Sensor> grouping in enumerable)
					{
						Sensor sensor = Enumerable.ElementAtOrDefault<Sensor>(grouping, 0);
						stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append(string.Concat(new string[]
						{
							"<td valign='top'>",
							Conversions.ToString(Enumerable.Count<Sensor>(grouping)),
							"x ",
							sensor.Name,
							"</td>"
						}));
						stringBuilder.Append("<td valign='top'>" + sensor.string_2 + "</td>");
						stringBuilder.Append("</tr>");
					}
				}
				finally
				{
					IEnumerator<IGrouping<int, Sensor>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x003DFE84 File Offset: 0x003DE084
		public string method_28(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.vmethod_51().Count > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>MOUNTS / STORES / WEAPONS</strong></span></div>");
				stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>Mounts (Guns/Launchers/Ejectors/etc.)</span>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>Mount</td><td align='center'>Capacity</td><td align='center'>Launch Interval</td><td align='center'>Armor</td><td align='center'>Onboard Sensors</td><td>Weapons (per mount)</td>");
				stringBuilder.Append("<td>Notes</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, Mount>> enumerable = Enumerable.GroupBy<Mount, int>(activeUnit_0.vmethod_51(), (InternalDBViewer._Closure$__.$I87-0 == null) ? (InternalDBViewer._Closure$__.$I87-0 = new Func<Mount, int>(InternalDBViewer._Closure$__.$I.method_5)) : InternalDBViewer._Closure$__.$I87-0);
				try
				{
					foreach (IGrouping<int, Mount> grouping in enumerable)
					{
						InternalDBViewer.Class2491 @class = new InternalDBViewer.Class2491(@class);
						@class.mount_0 = Enumerable.ElementAtOrDefault<Mount>(grouping, 0);
						stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append(string.Concat(new string[]
						{
							"<td valign='top'>",
							Conversions.ToString(Enumerable.Count<Mount>(grouping)),
							"x ",
							@class.mount_0.Name,
							"</td>"
						}));
						if (@class.mount_0.method_32().int_1 > 0 & Strings.InStr(@class.mount_0.Name, "Rail", CompareMethod.Binary) > 0)
						{
							stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(@class.mount_0.method_32().int_1) + "</td>");
						}
						else
						{
							stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(@class.mount_0.int_1 + @class.mount_0.method_32().int_1) + "</td>");
						}
						if (@class.mount_0.method_32().int_1 > 0 & Strings.InStr(@class.mount_0.Name, "Rail", CompareMethod.Binary) > 0)
						{
							Mount mount_ = @class.mount_0;
							int num = 0;
							int num2 = 0;
							if (mount_.method_35(ref num, ref num2) > 1)
							{
								StringBuilder stringBuilder2 = stringBuilder;
								string[] array = new string[5];
								array[0] = "<td align='center' valign='top'>On-rail: ";
								array[1] = Conversions.ToString(@class.mount_0.int_0);
								array[2] = "<br>Salvo: ";
								int num3 = 3;
								int num4 = @class.mount_0.int_0;
								int num5 = @class.mount_0.method_32().int_0;
								Mount mount_2 = @class.mount_0;
								num2 = 0;
								num = 0;
								array[num3] = Conversions.ToString(num4 + num5 * mount_2.method_35(ref num2, ref num));
								array[4] = "</td>";
								stringBuilder2.Append(string.Concat(array));
							}
							else
							{
								stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(@class.mount_0.method_32().int_0) + "</td>");
							}
						}
						else
						{
							stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(@class.mount_0.int_0) + "</td>");
						}
						stringBuilder.Append("<td align='center' valign='top'>" + @class.mount_0.armorRating_0.ToString() + "</td>");
						stringBuilder.Append("<td valign='top'>" + string.Join("<br/>", Enumerable.ToArray<string>(Enumerable.Select<Sensor, string>(@class.mount_0.method_36(), (InternalDBViewer._Closure$__.$I87-1 == null) ? (InternalDBViewer._Closure$__.$I87-1 = new Func<Sensor, string>(InternalDBViewer._Closure$__.$I.method_6)) : InternalDBViewer._Closure$__.$I87-1))) + "</td>");
						stringBuilder.Append("<td valign='top'>");
						try
						{
							foreach (WeaponRec weaponRec in @class.mount_0.vmethod_10())
							{
								Weapon weapon = weaponRec.method_12(Client.smethod_46());
								stringBuilder.Append((weaponRec.method_9() == 0) ? "<i style='color:blue'>" : "");
								stringBuilder.Append(string.Concat(new string[]
								{
									Conversions.ToString(weaponRec.method_9()),
									"x <a href=Weapon_",
									Conversions.ToString(weapon.DBID),
									">",
									weapon.Name,
									"</a>"
								}));
								try
								{
									foreach (WeaponRec weaponRec2 in @class.mount_0.method_32().vmethod_10())
									{
										if (weaponRec2.int_5 == weaponRec.int_5)
										{
											stringBuilder.Append("(+" + Conversions.ToString(weaponRec2.method_9()) + " On mount magazine)");
										}
									}
								}
								finally
								{
									List<WeaponRec>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
								stringBuilder.Append((weaponRec.method_9() == 0) ? "</i>" : "");
								if (!weapon.method_208())
								{
									stringBuilder.Append("<br/><font style='color:gray'>" + this.method_42(activeUnit_0, weapon) + "</font>");
								}
								stringBuilder.Append("<br/>");
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						stringBuilder.Append("</td>");
						stringBuilder.Append("<td valign='top'>");
						if (@class.mount_0.hashSet_1.Count > 0)
						{
							IEnumerable<IGrouping<int, Sensor>> enumerable2 = Enumerable.GroupBy<Sensor, int>(Enumerable.Where<Sensor>(activeUnit_0.method_78(), new Func<Sensor, bool>(@class.method_0)), (InternalDBViewer._Closure$__.$I87-3 == null) ? (InternalDBViewer._Closure$__.$I87-3 = new Func<Sensor, int>(InternalDBViewer._Closure$__.$I.method_7)) : InternalDBViewer._Closure$__.$I87-3);
							if (Enumerable.Count<IGrouping<int, Sensor>>(enumerable2) > 0)
							{
								List<string> list = new List<string>();
								try
								{
									foreach (IGrouping<int, Sensor> grouping2 in enumerable2)
									{
										list.Add(Enumerable.ElementAtOrDefault<Sensor>(grouping2, 0).Name);
									}
								}
								finally
								{
									IEnumerator<IGrouping<int, Sensor>> enumerator4;
									if (enumerator4 != null)
									{
										enumerator4.Dispose();
									}
								}
								stringBuilder.Append("Can be directed by: " + string.Join(", ", list) + ". ");
							}
						}
						if (@class.mount_0.bool_13)
						{
							stringBuilder.Append("Local control possible. ");
						}
						if (@class.mount_0.bool_11)
						{
							stringBuilder.Append("Operates autonomously (no OODA delay). ");
						}
						stringBuilder.Append("</td>");
						stringBuilder.Append("</tr>");
					}
				}
				finally
				{
					IEnumerator<IGrouping<int, Mount>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600733A RID: 29498 RVA: 0x003E0534 File Offset: 0x003DE734
		public string method_29(Aircraft aircraft_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int dbid = aircraft_0.DBID;
			SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
			if (DBFunctions.smethod_43(dbid, ref sqliteConnection).Count > 0)
			{
				if (aircraft_0.vmethod_51().Count == 0)
				{
					stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>MOUNTS / STORES / WEAPONS</strong></span></div>");
				}
				stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>Aircraft Stores</span>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>Store</td><td align='center'>Speed Release Envelope</td><td align='center'>Altitude Release Envelope</td><td>Description</td>");
				stringBuilder.Append("</tr>");
				try
				{
					int dbid2 = aircraft_0.DBID;
					sqliteConnection = Client.smethod_46().method_39();
					foreach (int num in DBFunctions.smethod_43(dbid2, ref sqliteConnection))
					{
						Weapon weapon = Client.smethod_46().method_87(num);
						stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append("<td valign='top'>" + weapon.Name + "</td>");
						string str;
						if (weapon.int_18 <= 0 && weapon.int_17 <= 0)
						{
							str = "";
						}
						else
						{
							str = Conversions.ToString(weapon.int_18) + " - " + Conversions.ToString(weapon.int_17) + "kt";
						}
						string str2;
						if (weapon.float_39 <= 0f && weapon.float_40 <= 0f && weapon.float_43 <= 0f && weapon.float_44 <= 0f)
						{
							str2 = "";
						}
						else
						{
							float num2;
							string text;
							if (weapon.float_39 != 0f)
							{
								num2 = weapon.float_39;
								text = " AGL";
							}
							else
							{
								num2 = weapon.float_43;
								text = " ASL";
							}
							float num3;
							string text2;
							if (weapon.float_40 != 0f)
							{
								num3 = weapon.float_40;
								text2 = " AGL";
							}
							else
							{
								num3 = weapon.float_44;
								text2 = " ASL";
							}
							str2 = string.Concat(new string[]
							{
								string.Format("{0:0}", num2 * 3.28084f),
								" ft",
								text,
								" - ",
								string.Format("{0:0}", num3 * 3.28084f),
								" ft",
								text2,
								"<br>",
								string.Format("{0:0.0}", num2),
								" m",
								text,
								" - ",
								string.Format("{0:0.0}", num3),
								" m",
								text2
							});
						}
						stringBuilder.Append("<td valign='top' align='center'>" + str + "</td>");
						stringBuilder.Append("<td valign='top' align='center'>" + str2 + "</td>");
						if (!weapon.method_208() && !weapon.method_214() && weapon.method_167() != Weapon._WeaponType.SensorPod)
						{
							stringBuilder.Append("<td valign='top' align='left'>" + this.method_42(aircraft_0, weapon) + "</td>");
						}
						else
						{
							stringBuilder.Append("<td></td>");
						}
						stringBuilder.Append("</tr>");
					}
				}
				finally
				{
					List<int>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x003E08B4 File Offset: 0x003DEAB4
		public string method_30(Aircraft aircraft_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int dbid = aircraft_0.DBID;
			Dictionary<int, int> selectedAircraftTotalWeaponQty = null;
			SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
			Scenario theScen = Client.smethod_46();
			bool flag = false;
			Scenario scenario = null;
			Aircraft aircraft = null;
			int i = 0;
			bool flag2 = false;
			DataTable dataTable = DBFunctions.smethod_42(dbid, selectedAircraftTotalWeaponQty, ref sqliteConnection, theScen, ref flag, ref scenario, ref aircraft, ref i, ref flag2);
			if (dataTable.Rows.Count > 0)
			{
				bool flag3 = aircraft_0.vmethod_51().Count == 0;
				int dbid2 = aircraft_0.DBID;
				sqliteConnection = Client.smethod_46().method_39();
				if (flag3 & DBFunctions.smethod_43(dbid2, ref sqliteConnection).Count == 0)
				{
					stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>MOUNTS / STORES / WEAPONS</strong></span></div>");
				}
				stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>Aircraft Loadouts</span>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>Name</td><td>Stores</td><td>Range and Profile</td><td align='center'>Ready Time</td><td align='center'>Day/Night & Weather</td><td align='center'>Pre-Briefed Weapon State</td><td>DB ID#</td></td>");
				stringBuilder.Append("</tr>");
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						DBFunctions.smethod_48(ref aircraft_0, Conversions.ToInteger(dataRow["ID"]), false);
						Loadout loadout = aircraft_0.method_167();
						stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append("<td valign='middle'>" + loadout.Name);
						if (loadout.loadoutRole_0 != Loadout.LoadoutRole.Ferry && loadout.loadoutRole_0 != Loadout.LoadoutRole.Reserve && loadout.loadoutRole_0 != Loadout.LoadoutRole.Unavailable)
						{
							stringBuilder.Append("<br>(" + Misc.smethod_30(loadout.loadoutRole_0, Client.smethod_46().method_39()) + ")");
						}
						stringBuilder.Append("</td>");
						stringBuilder.Append("<td valign='middle'>");
						foreach (WeaponRec weaponRec in loadout.weaponRec_0)
						{
							stringBuilder.Append(string.Concat(new string[]
							{
								Conversions.ToString(weaponRec.method_9()),
								"x <a href=Weapon_",
								Conversions.ToString(weaponRec.method_12(Client.smethod_46()).DBID),
								">",
								weaponRec.method_12(Client.smethod_46()).Name,
								"</a><br/>"
							}));
						}
						stringBuilder.Append(loadout.bool_12 ? "<br/></br>Requires External Illumination." : "");
						stringBuilder.Append("</td>");
						stringBuilder.Append("<td valign='middle'>");
						string str = "";
						string text;
						if (!Information.IsNothing(loadout.method_15(Client.smethod_46())))
						{
							text = loadout.method_15(Client.smethod_46()).string_0;
							if (loadout.method_15(Client.smethod_46()).DBID == 1001)
							{
								str = "";
							}
							else if (loadout.short_0 > 0)
							{
								str = Conversions.ToString((int)loadout.short_0) + " minutes at " + Conversions.ToString(loadout.int_4) + " nm ";
							}
							else
							{
								str = Conversions.ToString(loadout.int_4) + " nm ";
							}
						}
						else
						{
							text = "n/a";
						}
						text = str + text;
						stringBuilder.Append(text);
						if (loadout.cargoType_0 != CargoType.NoCargo)
						{
							stringBuilder.Append("<br/>");
							CargoType cargoType_ = loadout.cargoType_0;
							if (cargoType_ <= CargoType.SmallCargo)
							{
								if (cargoType_ != CargoType.Personnel)
								{
									if (cargoType_ == CargoType.SmallCargo)
									{
										stringBuilder.Append("Cargo: Small");
									}
								}
								else
								{
									stringBuilder.Append("Cargo: Personnel");
								}
							}
							else if (cargoType_ != CargoType.MediumCargo)
							{
								if (cargoType_ != CargoType.LargeCargo)
								{
									if (cargoType_ == CargoType.VLargeCargo)
									{
										stringBuilder.Append("Cargo: Very Large");
									}
								}
								else
								{
									stringBuilder.Append("Cargo: Large");
								}
							}
							else
							{
								stringBuilder.Append("Cargo: Medium");
							}
						}
						if (loadout.bool_15)
						{
							stringBuilder.Append(" &amp; ");
							stringBuilder.Append("Paradop Capable");
						}
						stringBuilder.Append("</td>");
						string str2;
						if (loadout.int_2 > 0)
						{
							str2 = Misc.smethod_11((long)(loadout.int_2 * 60), Aircraft_AirOps.Enum44.const_0, false, false);
						}
						else
						{
							str2 = "";
						}
						stringBuilder.Append("<td align='center' valign='middle'>" + str2 + "</td>");
						stringBuilder.Append(string.Concat(new string[]
						{
							"<td align='center' valign='middle'>",
							Misc.smethod_28(loadout._LoadoutDayNight_0),
							"<br/>",
							Misc.smethod_29(loadout._LoadoutWeather_0),
							"</td>"
						}));
						string str3;
						if (Client.smethod_46().FeatureCompatibility.get_WeaponAGL_ASL(Client.smethod_46().method_39()))
						{
							int dbid3 = loadout.DBID;
							int weaponState_ = (int)loadout._WeaponState_0;
							sqliteConnection = Client.smethod_46().method_39();
							str3 = DBFunctions.smethod_37(dbid3, weaponState_, ref sqliteConnection, Client.smethod_46(), false, loadout.loadoutRole_0);
						}
						else
						{
							str3 = "Winchester: Mission-specific weapons have been expended. Disengage immediately.";
						}
						stringBuilder.Append("<td align='center' valign='middle'>" + str3 + "</td>");
						stringBuilder.Append("<td>" + Conversions.ToString(loadout.DBID) + "</td>");
						stringBuilder.Append("</tr>");
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
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x003E0E20 File Offset: 0x003DF020
		public string method_31(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.vmethod_117().Length > 0)
			{
				stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>Magazines</span>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>Magazine</td><td align='center'>Capacity</td><td align='center'>Reload Rate</td><td align='center'>Armor</td><td>Stores</td>");
				stringBuilder.Append("</tr>");
				foreach (Magazine magazine in activeUnit_0.vmethod_117())
				{
					stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
					stringBuilder.Append("<td valign='top'>" + magazine.Name + "</td>");
					stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(magazine.int_1) + "</td>");
					stringBuilder.Append("<td align='center' valign='top'>" + Conversions.ToString(magazine.int_0) + "</td>");
					stringBuilder.Append("<td align='center' valign='top'>" + magazine.armorRating_0.ToString() + "</td>");
					stringBuilder.Append("<td valign='top'>" + string.Join("<br/>", Enumerable.ToArray<string>(Enumerable.Select<WeaponRec, string>(magazine.vmethod_10(), (InternalDBViewer._Closure$__.$I90-0 == null) ? (InternalDBViewer._Closure$__.$I90-0 = new Func<WeaponRec, string>(InternalDBViewer._Closure$__.$I.method_8)) : InternalDBViewer._Closure$__.$I90-0))) + "</td>");
					stringBuilder.Append("</tr>");
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x003E0FAC File Offset: 0x003DF1AC
		public string method_32(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (Enumerable.Count<CommDevice>(activeUnit_0.vmethod_94()) > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>COMMS / DATALINKS</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>Name</td><td align='center'>Type</td><td align='center'>Max Range</td><td align='center'>Channels</td><td>Properties</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, CommDevice>> enumerable = Enumerable.GroupBy<CommDevice, int>(activeUnit_0.vmethod_94(), (InternalDBViewer._Closure$__.$I91-0 == null) ? (InternalDBViewer._Closure$__.$I91-0 = new Func<CommDevice, int>(InternalDBViewer._Closure$__.$I.method_9)) : InternalDBViewer._Closure$__.$I91-0);
				try
				{
					foreach (IGrouping<int, CommDevice> grouping in enumerable)
					{
						CommDevice commDevice = Enumerable.ElementAtOrDefault<CommDevice>(grouping, 0);
						stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append("<td>" + commDevice.Name + "</td>");
						stringBuilder.Append("<td align='center'>" + DBFunctions.smethod_17(commDevice.commLinkType_0, Client.smethod_46()) + "</td>");
						if (commDevice.double_0 > 0.0)
						{
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(commDevice.double_0) + " nm</td>");
						}
						else
						{
							stringBuilder.Append("<td align='center'>-</td>");
						}
						if (commDevice.int_0 > 0)
						{
							stringBuilder.Append("<td align='center'>" + Conversions.ToString(commDevice.int_0) + "</td>");
						}
						else
						{
							stringBuilder.Append("<td align='center'>-</td>");
						}
						stringBuilder.Append("<td>");
						List<string> list = new List<string>();
						if (!commDevice.bool_12)
						{
							list.Add("Supports CEC");
						}
						if (commDevice.struct31_0.bool_0)
						{
							list.Add("Broadcast");
						}
						if (commDevice.struct31_0.bool_5)
						{
							list.Add("ELF Radio");
						}
						if (commDevice.struct31_0.bool_11)
						{
							list.Add("HF Radio");
						}
						if (commDevice.struct31_0.bool_9)
						{
							list.Add("LF Radio");
						}
						if (commDevice.struct31_0.bool_4)
						{
							list.Add("LOS-limited");
						}
						if (commDevice.struct31_0.bool_10)
						{
							list.Add("MF Radio");
						}
						if (commDevice.struct31_0.bool_2)
						{
							list.Add("Receive-only");
						}
						if (commDevice.struct31_0.bool_1)
						{
							list.Add("Secure");
						}
						if (commDevice.struct31_0.bool_3)
						{
							list.Add("Send-only");
						}
						if (commDevice.struct31_0.bool_14)
						{
							list.Add("SHF Radio");
						}
						if (commDevice.struct31_0.bool_13)
						{
							list.Add("UHF Radio");
						}
						if (commDevice.struct31_0.bool_12)
						{
							list.Add("VHF Radio");
						}
						if (commDevice.struct31_0.bool_7)
						{
							list.Add("VLF Radio");
						}
						stringBuilder.Append(string.Join(", ", list) + "</td>");
						stringBuilder.Append("</tr>");
					}
				}
				finally
				{
					IEnumerator<IGrouping<int, CommDevice>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600733E RID: 29502 RVA: 0x003E1304 File Offset: 0x003DF504
		public string method_33(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.vmethod_99().Length > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>AIRCRAFT FACILITIES</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>Type</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, AirFacility>> enumerable = Enumerable.GroupBy<AirFacility, int>(activeUnit_0.vmethod_99(), (InternalDBViewer._Closure$__.$I92-0 == null) ? (InternalDBViewer._Closure$__.$I92-0 = new Func<AirFacility, int>(InternalDBViewer._Closure$__.$I.method_10)) : InternalDBViewer._Closure$__.$I92-0);
				try
				{
					foreach (IGrouping<int, AirFacility> grouping in enumerable)
					{
						AirFacility airFacility = Enumerable.ElementAtOrDefault<AirFacility>(grouping, 0);
						stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append(string.Concat(new string[]
						{
							"<td>",
							Conversions.ToString(Enumerable.Count<AirFacility>(grouping)),
							"x ",
							airFacility.Name,
							"</td>"
						}));
						stringBuilder.Append("</tr>");
					}
				}
				finally
				{
					IEnumerator<IGrouping<int, AirFacility>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600733F RID: 29503 RVA: 0x003E1448 File Offset: 0x003DF648
		public string method_34(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.vmethod_100().Length > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>DOCKING FACILITIES</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>Type</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, DockFacility>> enumerable = Enumerable.GroupBy<DockFacility, int>(activeUnit_0.vmethod_100(), (InternalDBViewer._Closure$__.$I93-0 == null) ? (InternalDBViewer._Closure$__.$I93-0 = new Func<DockFacility, int>(InternalDBViewer._Closure$__.$I.method_11)) : InternalDBViewer._Closure$__.$I93-0);
				try
				{
					foreach (IGrouping<int, DockFacility> grouping in enumerable)
					{
						DockFacility dockFacility = Enumerable.ElementAtOrDefault<DockFacility>(grouping, 0);
						stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append(string.Concat(new string[]
						{
							"<td>",
							Conversions.ToString(Enumerable.Count<DockFacility>(grouping)),
							"x ",
							dockFacility.Name,
							"</td>"
						}));
						stringBuilder.Append("</tr>");
					}
				}
				finally
				{
					IEnumerator<IGrouping<int, DockFacility>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06007340 RID: 29504 RVA: 0x003E158C File Offset: 0x003DF78C
		public string method_35(Weapon weapon_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (weapon_0.method_167() != Weapon._WeaponType.BuddyStore && weapon_0.method_167() != Weapon._WeaponType.Cargo && weapon_0.method_167() != Weapon._WeaponType.DropTank && weapon_0.method_167() != Weapon._WeaponType.FerryTank && weapon_0.method_167() != Weapon._WeaponType.HeliTowedPackage && weapon_0.method_167() != Weapon._WeaponType.None && weapon_0.method_167() != Weapon._WeaponType.Paratroops && weapon_0.method_167() != Weapon._WeaponType.SensorPod && weapon_0.method_167() != Weapon._WeaponType.TrainingRound && weapon_0.method_167() != Weapon._WeaponType.Troops)
			{
				if (weapon_0.method_167() != Weapon._WeaponType.Sonobuoy)
				{
					stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>VALID TARGETS</strong></span></div>");
					stringBuilder.Append("<div style='color:Black;background-;font-family:Verdana;font-size:8pt;'>");
					stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
					stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
					stringBuilder.Append("<td>");
					List<string> list = weapon_0.method_150();
					string value = (list.Count > 0) ? string.Join("<br/>", list) : "";
					stringBuilder.Append(value);
					stringBuilder.Append("</td>");
					stringBuilder.Append("</tr>");
					stringBuilder.Append("</table>");
					stringBuilder.Append("</div>");
					stringBuilder.Append("<br/>");
					return stringBuilder.ToString();
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x003E1708 File Offset: 0x003DF908
		public string method_36(Weapon weapon_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string result;
			if (Information.IsNothing(weapon_0.doctrine_0.method_27()))
			{
				result = stringBuilder.ToString();
			}
			else
			{
				string[] array = new string[4];
				array[2] = "EnumWeaponWRA";
				if (weapon_0.scenario_0.method_39().GetSchema("Tables", array).Rows.Count == 0)
				{
					result = stringBuilder.ToString();
				}
				else
				{
					stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>WEAPON RELEASE AUTHORIZATION (WRA) [DEFAULT]</strong></span></div>");
					stringBuilder.Append("<div style='color:Black;background-;font-family:Verdana;font-size:8pt;'>");
					stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
					stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
					stringBuilder.Append("<td>Target type</td><td align='left'>Number of weapons per salvo</td><td align='left'>Maximum number of shooters per salvo</td><td align='left'>Self-defence range</td>");
					stringBuilder.Append("</tr>");
					try
					{
						foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair in weapon_0.doctrine_0.method_27())
						{
							foreach (Doctrine.Class276 @class in keyValuePair.Value.class276_0)
							{
								stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
								stringBuilder.Append("<td>");
								stringBuilder.Append(Doctrine.smethod_8(@class._WRA_WeaponTargetType_0));
								stringBuilder.Append("</td>");
								stringBuilder.Append("<td>");
								StringBuilder stringBuilder2 = stringBuilder;
								Scenario scenario = Client.smethod_46();
								stringBuilder2.Append(DBFunctions.smethod_31(ref scenario, @class.nullable_0.Value));
								stringBuilder.Append("</td>");
								stringBuilder.Append("<td>");
								StringBuilder stringBuilder3 = stringBuilder;
								scenario = Client.smethod_46();
								stringBuilder3.Append(DBFunctions.smethod_32(ref scenario, @class.nullable_1.Value));
								stringBuilder.Append("</td>");
								stringBuilder.Append("<td>");
								StringBuilder stringBuilder4 = stringBuilder;
								scenario = Client.smethod_46();
								stringBuilder4.Append(DBFunctions.smethod_33(ref scenario, @class.nullable_3.Value));
								stringBuilder.Append("</td>");
								stringBuilder.Append("</tr>");
							}
						}
					}
					finally
					{
						Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					stringBuilder.Append("</table>");
					stringBuilder.Append("</div>");
					stringBuilder.Append("<br/>");
					result = stringBuilder.ToString();
				}
			}
			return result;
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x003E1960 File Offset: 0x003DFB60
		public string method_37(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string result;
			if (activeUnit_0.bool_2 && (((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.BuddyStore || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.Cargo || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.Dispenser || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.DropTank || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.FerryTank || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.Gun || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.HeliTowedPackage || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.IronBomb || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.Laser || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.None || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.Paratroops || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.Rocket || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.SensorPod || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.TrainingRound || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.Troops || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.DepthCharge || ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.Sonobuoy))
			{
				result = stringBuilder.ToString();
			}
			else
			{
				if (Enumerable.Count<XSection>(activeUnit_0.method_64()) > 0)
				{
					stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>SIGNATURES</strong></span></div>");
					stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
					stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
					stringBuilder.Append("<td>Signature Type</td><td align='center'>Front</td><td align='center'>Side</td><td align='center'>Rear</td>");
					stringBuilder.Append("</tr>");
				}
				foreach (XSection xsection in activeUnit_0.method_64())
				{
					if ((xsection.method_9(activeUnit_0) != 0f || xsection.method_10(activeUnit_0) != 0f || xsection.method_11(activeUnit_0) != 0f) && xsection.method_9(activeUnit_0) != -10000f && xsection.method_10(activeUnit_0) != -10000f && xsection.method_11(activeUnit_0) != -10000f)
					{
						stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
						stringBuilder.Append("<td>" + DBFunctions.smethod_18(xsection.enum132_0, Client.smethod_46()) + "</td>");
						if (xsection.enum132_0 == XSection.Enum132.const_0 || xsection.enum132_0 == XSection.Enum132.const_1 || xsection.enum132_0 == XSection.Enum132.const_2 || xsection.enum132_0 == XSection.Enum132.const_3)
						{
							goto IL_873;
						}
						if (xsection.enum132_0 == XSection.Enum132.const_4)
						{
							goto IL_873;
						}
						string str;
						string str2;
						string str3;
						if (xsection.enum132_0 != XSection.Enum132.const_5 && xsection.enum132_0 != XSection.Enum132.const_6 && xsection.enum132_0 != XSection.Enum132.const_7)
						{
							if (xsection.enum132_0 != XSection.Enum132.const_8)
							{
								if (xsection.enum132_0 != XSection.Enum132.const_9)
								{
									if (xsection.enum132_0 != XSection.Enum132.const_10)
									{
										str = "";
										str2 = "";
										str3 = "";
										goto IL_886;
									}
								}
								double num = Math.Pow(10.0, (double)(xsection.method_9(activeUnit_0) / 10f));
								if (num < 1.0 & num >= 0.1)
								{
									str = " dBsm, " + string.Format("{0:0.00}", Math.Pow(10.0, (double)(xsection.method_9(activeUnit_0) / 10f))) + " sq.m.";
									str2 = " dBsm, " + string.Format("{0:0.00}", Math.Pow(10.0, (double)(xsection.method_10(activeUnit_0) / 10f))) + " sq.m.";
									str3 = " dBsm, " + string.Format("{0:0.00}", Math.Pow(10.0, (double)(xsection.method_11(activeUnit_0) / 10f))) + " sq.m.";
									goto IL_886;
								}
								if (num < 0.1 & num >= 0.01)
								{
									str = " dBsm, " + string.Format("{0:0.000}", Math.Pow(10.0, (double)(xsection.method_9(activeUnit_0) / 10f))) + " sq.m.";
									str2 = " dBsm, " + string.Format("{0:0.000}", Math.Pow(10.0, (double)(xsection.method_10(activeUnit_0) / 10f))) + " sq.m.";
									str3 = " dBsm, " + string.Format("{0:0.000}", Math.Pow(10.0, (double)(xsection.method_11(activeUnit_0) / 10f))) + " sq.m.";
									goto IL_886;
								}
								if (num < 0.01 & num >= 0.001)
								{
									str = " dBsm, " + string.Format("{0:0.0000}", Math.Pow(10.0, (double)(xsection.method_9(activeUnit_0) / 10f))) + " sq.m.";
									str2 = " dBsm, " + string.Format("{0:0.0000}", Math.Pow(10.0, (double)(xsection.method_10(activeUnit_0) / 10f))) + " sq.m.";
									str3 = " dBsm, " + string.Format("{0:0.0000}", Math.Pow(10.0, (double)(xsection.method_11(activeUnit_0) / 10f))) + " sq.m.";
									goto IL_886;
								}
								if (num < 0.001 & num >= 0.0001)
								{
									str = " dBsm, " + string.Format("{0:0.00000}", Math.Pow(10.0, (double)(xsection.method_9(activeUnit_0) / 10f))) + " sq.m.";
									str2 = " dBsm, " + string.Format("{0:0.00000}", Math.Pow(10.0, (double)(xsection.method_10(activeUnit_0) / 10f))) + " sq.m.";
									str3 = " dBsm, " + string.Format("{0:0.00000}", Math.Pow(10.0, (double)(xsection.method_11(activeUnit_0) / 10f))) + " sq.m.";
									goto IL_886;
								}
								if (num < 0.0001 & num >= 1E-05)
								{
									str = " dBsm, " + string.Format("{0:0.000000}", Math.Pow(10.0, (double)(xsection.method_9(activeUnit_0) / 10f))) + " sq.m.";
									str2 = " dBsm, " + string.Format("{0:0.000000}", Math.Pow(10.0, (double)(xsection.method_10(activeUnit_0) / 10f))) + " sq.m.";
									str3 = " dBsm, " + string.Format("{0:0.000000}", Math.Pow(10.0, (double)(xsection.method_11(activeUnit_0) / 10f))) + " sq.m.";
									goto IL_886;
								}
								str = " dBsm, " + string.Format("{0:0.0}", Math.Pow(10.0, (double)(xsection.method_9(activeUnit_0) / 10f))) + " sq.m.";
								str2 = " dBsm, " + string.Format("{0:0.0}", Math.Pow(10.0, (double)(xsection.method_10(activeUnit_0) / 10f))) + " sq.m.";
								str3 = " dBsm, " + string.Format("{0:0.0}", Math.Pow(10.0, (double)(xsection.method_11(activeUnit_0) / 10f))) + " sq.m.";
								goto IL_886;
							}
						}
						str = " nm";
						str2 = " nm";
						str3 = " nm";
						IL_886:
						stringBuilder.Append("<td align='center'>" + string.Format("{0:0.00}", xsection.method_9(activeUnit_0)) + str + "</td>");
						stringBuilder.Append("<td align='center'>" + string.Format("{0:0.00}", xsection.method_10(activeUnit_0)) + str2 + "</td>");
						stringBuilder.Append("<td align='center'>" + string.Format("{0:0.00}", xsection.method_11(activeUnit_0)) + str3 + "</td>");
						stringBuilder.Append("</tr>");
						goto IL_91D;
						IL_873:
						str = " dB";
						str2 = " dB";
						str3 = " dB";
						goto IL_886;
					}
					IL_91D:;
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x003E22BC File Offset: 0x003E04BC
		public string method_38(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			new List<string>();
			if (DBFunctions.smethod_16(activeUnit_0.vmethod_56(), activeUnit_0.DBID, Client.smethod_46().method_39()).Count > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>PROPERTIES</strong></span></div>");
				stringBuilder.Append("<div style='color:Black;font-family:Verdana;font-size:8pt;'>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
				stringBuilder.Append("<td>");
				stringBuilder.Append(string.Join("<br/>", DBFunctions.smethod_16(activeUnit_0.vmethod_56(), activeUnit_0.DBID, Client.smethod_46().method_39())));
				stringBuilder.Append("</td>");
				stringBuilder.Append("</tr>");
				stringBuilder.Append("</table>");
				stringBuilder.Append("</div>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x003E23A8 File Offset: 0x003E05A8
		public string method_39(Weapon weapon_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (weapon_0.warhead_0.Length > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>WARHEADS</strong></span></div>");
				stringBuilder.Append("<div style='color:Black;background-;font-family:Verdana;font-size:8pt;'>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
				stringBuilder.Append("<td>");
				IEnumerable<IGrouping<string, Warhead>> enumerable = Enumerable.GroupBy<Warhead, string>(weapon_0.warhead_0, (InternalDBViewer._Closure$__.$I98-0 == null) ? (InternalDBViewer._Closure$__.$I98-0 = new Func<Warhead, string>(InternalDBViewer._Closure$__.$I.method_12)) : InternalDBViewer._Closure$__.$I98-0);
				List<string> list = new List<string>();
				try
				{
					foreach (IGrouping<string, Warhead> grouping in enumerable)
					{
						string text = "";
						if (Enumerable.Count<Warhead>(grouping) > 1)
						{
							text = Conversions.ToString(Enumerable.Count<Warhead>(grouping)) + "x ";
						}
						string text2;
						string text3;
						if (Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).method_14(Client.smethod_46()) & Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).warheadType_0 != Warhead.WarheadType.Weapon)
						{
							if (Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).float_0 >= 1E+09f)
							{
								text2 = Convert.ToString(Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).float_0 / 1E+09f);
								text3 = " mT";
							}
							else
							{
								text2 = Convert.ToString(Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).float_0 / 1000000f);
								text3 = " kT";
							}
						}
						else if (Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).warheadType_0 == Warhead.WarheadType.Weapon)
						{
							text2 = "";
							text3 = "";
						}
						else
						{
							text2 = Convert.ToString(Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).float_0);
							text3 = " DP";
						}
						list.Add(string.Concat(new string[]
						{
							text,
							"#",
							Conversions.ToString(Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).DBID),
							" - ",
							Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).Name,
							" (",
							text2,
							text3,
							")"
						}));
					}
				}
				finally
				{
					IEnumerator<IGrouping<string, Warhead>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				string value = (list.Count > 0) ? string.Join(" - ", list) : "";
				stringBuilder.Append(value);
				stringBuilder.Append("</td>");
				stringBuilder.Append("</tr>");
				stringBuilder.Append("</table>");
				stringBuilder.Append("</div>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x003E2644 File Offset: 0x003E0844
		public string method_40(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (activeUnit_0.vmethod_49().Count > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>PROPULSION</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>Engines</td><td>Type</td><td>Max Speed</td>");
				stringBuilder.Append("</tr>");
				IEnumerable<IGrouping<int, Engine>> enumerable = Enumerable.GroupBy<Engine, int>(activeUnit_0.vmethod_49(), (InternalDBViewer._Closure$__.$I99-0 == null) ? (InternalDBViewer._Closure$__.$I99-0 = new Func<Engine, int>(InternalDBViewer._Closure$__.$I.method_13)) : InternalDBViewer._Closure$__.$I99-0);
				try
				{
					foreach (IGrouping<int, Engine> grouping in enumerable)
					{
						string str;
						if (Enumerable.Count<Engine>(grouping) > 1)
						{
							str = Conversions.ToString(Enumerable.Count<Engine>(grouping)) + "x ";
						}
						else
						{
							str = "";
						}
						Engine engine = Enumerable.ElementAtOrDefault<Engine>(grouping, 0);
						stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
						try
						{
							if (Enumerable.Max(Enumerable.Select<AltBand, int>(engine.altBand_0, (InternalDBViewer._Closure$__.$I99-1 == null) ? (InternalDBViewer._Closure$__.$I99-1 = new Func<AltBand, int>(InternalDBViewer._Closure$__.$I.method_14)) : InternalDBViewer._Closure$__.$I99-1)) > 0)
							{
								stringBuilder.Append("<td>" + str + engine.Name + "</td>");
								stringBuilder.Append("<td valign='top'>" + Misc.smethod_25(engine.enum112_0, Client.smethod_46().method_39()) + "</td>");
								stringBuilder.Append("<td valign='top'>" + Conversions.ToString(Enumerable.Max(Enumerable.Select<AltBand, int>(engine.altBand_0, (InternalDBViewer._Closure$__.$I99-2 == null) ? (InternalDBViewer._Closure$__.$I99-2 = new Func<AltBand, int>(InternalDBViewer._Closure$__.$I.method_15)) : InternalDBViewer._Closure$__.$I99-2))) + " kts</td>");
							}
							else
							{
								stringBuilder.Append("<td>None</td>");
								stringBuilder.Append("<td></td>");
								stringBuilder.Append("<td></td>");
							}
						}
						catch (Exception ex)
						{
							stringBuilder.Append("<td>None</td>");
							stringBuilder.Append("<td></td>");
							stringBuilder.Append("<td></td>");
							ex.Data.Add("Error at 200376", ex.Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						stringBuilder.Append("</tr>");
					}
				}
				finally
				{
					IEnumerator<IGrouping<int, Engine>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
				if (activeUnit_0.bool_3)
				{
					try
					{
						foreach (IGrouping<int, Engine> grouping2 in enumerable)
						{
							Engine engine = Enumerable.ElementAtOrDefault<Engine>(grouping2, 0);
							List<float> list = new List<float>();
							try
							{
								list = DBFunctions.smethod_13(engine.DBID, Client.smethod_46().method_39());
								if (list.Count > 0)
								{
									stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>Technical Details</span>");
									stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
									stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
									stringBuilder.Append("<td>Military Static Thrust at S/L</td><td>Afterburner Static Thrust at S/L</td><td>Military Static SFC at S/L</td><td>Afterburner Static SFC at S/L</td>");
									stringBuilder.Append("</tr>");
									stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
									if (list[0] == 1f)
									{
										stringBuilder.Append("<td>" + Conversions.ToString(list[1]) + " kg</td>");
										if (list[2] > 0f)
										{
											stringBuilder.Append("<td>" + Conversions.ToString(list[2]) + " kg</td>");
										}
										else
										{
											stringBuilder.Append("<td>-</td>");
										}
									}
									else
									{
										stringBuilder.Append("<td>" + Conversions.ToString(list[1]) + " kg per engine</td>");
										if (list[2] > 0f)
										{
											stringBuilder.Append("<td>" + Conversions.ToString(list[2]) + " kg per engine</td>");
										}
										else
										{
											stringBuilder.Append("<td>-</td>");
										}
									}
									stringBuilder.Append("<td>" + Conversions.ToString(list[3]) + " kg/h/kg</td>");
									if (list[4] > 0f)
									{
										stringBuilder.Append("<td>" + Conversions.ToString(list[4]) + " kg/h/kg</td>");
									}
									else
									{
										stringBuilder.Append("<td>-</td>");
									}
									stringBuilder.Append("</tr>");
									stringBuilder.Append("</table>");
									stringBuilder.Append("<br/>");
								}
							}
							catch (Exception ex2)
							{
								ex2.Data.Add("Error at 200377", ex2.Message);
								GameGeneral.smethod_25(ref ex2);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
							}
						}
					}
					finally
					{
						IEnumerator<IGrouping<int, Engine>> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
				try
				{
					IEnumerator<IGrouping<int, Engine>> enumerator3 = enumerable.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						Engine engine = Enumerable.ElementAtOrDefault<Engine>(enumerator3.Current, 0);
						int num = 1;
						if (engine.altBand_0.Length > 0)
						{
							if (activeUnit_0.vmethod_49().Count > 1)
							{
								stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>Performance Details for " + DBFunctions.smethod_94(engine.DBID, ref activeUnit_0).Name + "</span>");
							}
							else
							{
								stringBuilder.Append("<span style='text-align: left; font-family: Arial; font-size: small; font-weight: bold;'>Performance Details</span>");
							}
							stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
							stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
							if (engine.enum112_0 == Engine.Enum112.const_9)
							{
								if (activeUnit_0.bool_5)
								{
									stringBuilder.Append("<td>Altitude Band & Throttle</td><td>Altitude</td><td>Speed</td>");
								}
								else
								{
									stringBuilder.Append("<td>Altitude Band & Throttle</td><td>Speed</td>");
								}
							}
							else if (!activeUnit_0.bool_3 && !activeUnit_0.method_2())
							{
								if (!activeUnit_0.bool_5 && !activeUnit_0.bool_7)
								{
									stringBuilder.Append("<td>Altitude Band & Throttle</td><td>Speed</td><td>Fuel Consumption</td>");
								}
								else
								{
									stringBuilder.Append("<td>Altitude Band & Throttle</td><td>Depth</td><td>Speed</td><td>Fuel Consumption</td>");
								}
							}
							else
							{
								stringBuilder.Append("<td>Altitude Band & Throttle</td><td>Altitude</td><td>Speed</td><td>Fuel Consumption</td>");
							}
							stringBuilder.Append("</tr>");
							foreach (AltBand altBand in engine.altBand_0)
							{
								try
								{
									if (altBand.int_0 > 0)
									{
										stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
										if (!activeUnit_0.bool_3 && !activeUnit_0.method_2())
										{
											if (!activeUnit_0.bool_5 && !activeUnit_0.bool_7)
											{
												stringBuilder.Append("<td valign='top'>Creep Throttle</td>");
											}
											else
											{
												stringBuilder.Append("<td valign='top'>Band " + Conversions.ToString(num) + ", Creep Throttle</td>");
											}
										}
										else
										{
											stringBuilder.Append("<td valign='top'>Band " + Conversions.ToString(num) + ", Loiter Speed</td>");
										}
										if (activeUnit_0.bool_3 || activeUnit_0.method_2())
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												string.Format("{0:0}", altBand.float_1 * 3.28084f),
												" - ",
												string.Format("{0:0}", altBand.float_0 * 3.28084f),
												" ft<br>",
												string.Format("{0:0.0}", altBand.float_1),
												" - ",
												string.Format("{0:0.0}", altBand.float_0),
												" m</td>"
											}));
										}
										if (activeUnit_0.bool_5 || activeUnit_0.bool_7)
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												string.Format("{0:0}", altBand.float_0 * 3.28084f * -1f),
												" - ",
												string.Format("{0:0}", altBand.float_1 * 3.28084f * -1f),
												" ft<br>",
												string.Format("{0:0.0}", altBand.float_0 * -1f),
												" - ",
												string.Format("{0:0.0}", altBand.float_1 * -1f),
												" m</td>"
											}));
										}
										stringBuilder.Append("<td>" + Conversions.ToString(altBand.int_0) + " kt");
										if (activeUnit_0.bool_3 || activeUnit_0.method_2())
										{
											stringBuilder.Append("<br>" + string.Format("{0:0.00}", Class437.smethod_0((double)altBand.float_1, (double)altBand.int_0)) + " Mach");
										}
										stringBuilder.Append("</td>");
										if (engine.enum112_0 != Engine.Enum112.const_9)
										{
											if (engine.enum112_0 != Engine.Enum112.const_10)
											{
												if (engine.enum112_0 != Engine.Enum112.const_11)
												{
													if (!activeUnit_0.bool_2)
													{
														stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.float_2) + " kg per minute</td>");
														goto IL_982;
													}
													if (altBand.float_2 == 1f)
													{
														stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.float_2) + " fuel point per second</td>");
														goto IL_982;
													}
													stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.float_2) + " fuel points per second</td>");
													goto IL_982;
												}
											}
											if (altBand.float_2 == 1f)
											{
												stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.float_2) + " battery unit per minute</td>");
											}
											else
											{
												stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.float_2) + " battery units per minute</td>");
											}
										}
										IL_982:
										stringBuilder.Append("</tr>");
									}
									if (altBand.int_1 > 0)
									{
										stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
										if (!activeUnit_0.bool_3 && !activeUnit_0.method_2())
										{
											if (!activeUnit_0.bool_5 && !activeUnit_0.bool_7)
											{
												stringBuilder.Append("<td valign='top'>Cruise Throttle</td>");
											}
											else
											{
												stringBuilder.Append("<td valign='top'>Band " + Conversions.ToString(num) + ", Cruise Throttle</td>");
											}
										}
										else
										{
											stringBuilder.Append("<td valign='top'>Band " + Conversions.ToString(num) + ", Cruise Speed</td>");
										}
										if (activeUnit_0.bool_3 || activeUnit_0.method_2())
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												string.Format("{0:0}", altBand.float_1 * 3.28084f),
												" - ",
												string.Format("{0:0}", altBand.float_0 * 3.28084f),
												" ft<br>",
												string.Format("{0:0.0}", altBand.float_1),
												" - ",
												string.Format("{0:0.0}", altBand.float_0),
												" m</td>"
											}));
										}
										if (activeUnit_0.bool_5 || activeUnit_0.bool_7)
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												Conversions.ToString(Conversions.ToDouble(string.Format("{0:0}", altBand.float_0 * 3.28084f)) * -1.0),
												" - ",
												Conversions.ToString(Conversions.ToDouble(string.Format("{0:0}", altBand.float_1 * 3.28084f)) * -1.0),
												" ft<br>",
												string.Format("{0:0.0}", altBand.float_0 * -1f),
												" - ",
												string.Format("{0:0.0}", altBand.float_1 * -1f),
												" m</td>"
											}));
										}
										stringBuilder.Append("<td>" + Conversions.ToString(altBand.int_1) + " kt");
										if (activeUnit_0.bool_3 || activeUnit_0.method_2())
										{
											stringBuilder.Append("<br>" + string.Format("{0:0.00}", Class437.smethod_0((double)altBand.float_1, (double)altBand.int_1)) + " Mach");
										}
										stringBuilder.Append("</td>");
										if (engine.enum112_0 != Engine.Enum112.const_9)
										{
											if (engine.enum112_0 != Engine.Enum112.const_10)
											{
												if (engine.enum112_0 != Engine.Enum112.const_11)
												{
													if (!activeUnit_0.bool_2)
													{
														stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.float_3) + " kg per minute</td>");
														goto IL_D44;
													}
													if (altBand.float_3 == 1f)
													{
														stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.float_3) + " fuel point per second</td>");
														goto IL_D44;
													}
													stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.float_3) + " fuel points per second</td>");
													goto IL_D44;
												}
											}
											if (altBand.float_3 == 1f)
											{
												stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.float_3) + " battery unit per minute</td>");
											}
											else
											{
												stringBuilder.Append("<td valign='top'>" + Conversions.ToString(altBand.float_3) + " battery units per minute</td>");
											}
										}
										IL_D44:
										stringBuilder.Append("</tr>");
									}
									if (altBand.nullable_0 != null)
									{
										stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
										if (!activeUnit_0.bool_3 && !activeUnit_0.method_2())
										{
											if (!activeUnit_0.bool_5 && !activeUnit_0.bool_7)
											{
												stringBuilder.Append("<td valign='top'>Full Throttle</td>");
											}
											else
											{
												stringBuilder.Append("<td valign='top'>Band " + Conversions.ToString(num) + ", Full Throttle</td>");
											}
										}
										else
										{
											stringBuilder.Append("<td valign='top'>Band " + Conversions.ToString(num) + ", Military Speed</td>");
										}
										if (activeUnit_0.bool_3 || activeUnit_0.method_2())
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												string.Format("{0:0}", altBand.float_1 * 3.28084f),
												" - ",
												string.Format("{0:0}", altBand.float_0 * 3.28084f),
												" ft<br>",
												string.Format("{0:0.0}", altBand.float_1),
												" - ",
												string.Format("{0:0.0}", altBand.float_0),
												" m</td>"
											}));
										}
										if (activeUnit_0.bool_5 || activeUnit_0.bool_7)
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												Conversions.ToString(Conversions.ToDouble(string.Format("{0:0}", altBand.float_0 * 3.28084f)) * -1.0),
												" - ",
												Conversions.ToString(Conversions.ToDouble(string.Format("{0:0}", altBand.float_1 * 3.28084f)) * -1.0),
												" ft<br>",
												string.Format("{0:0.0}", altBand.float_0 * -1f),
												" - ",
												string.Format("{0:0.0}", altBand.float_1 * -1f),
												" m</td>"
											}));
										}
										StringBuilder stringBuilder2 = stringBuilder;
										string str2 = "<td>";
										long? num3;
										long? num2 = num3 = altBand.nullable_0;
										stringBuilder2.Append(str2 + ((num3 != null) ? Conversions.ToString(num2.GetValueOrDefault()) : null) + " kt");
										if (activeUnit_0.bool_3 || activeUnit_0.method_2())
										{
											stringBuilder.Append("<br>" + string.Format("{0:0.00}", Class437.smethod_0((double)altBand.float_1, (double)altBand.nullable_0.Value)) + " Mach");
										}
										stringBuilder.Append("</td>");
										if (engine.enum112_0 != Engine.Enum112.const_9)
										{
											float? num4;
											if (engine.enum112_0 != Engine.Enum112.const_10)
											{
												if (engine.enum112_0 != Engine.Enum112.const_11)
												{
													float? num5;
													if (!activeUnit_0.bool_2)
													{
														StringBuilder stringBuilder3 = stringBuilder;
														string str3 = "<td valign='top'>";
														num4 = (num5 = altBand.nullable_2);
														stringBuilder3.Append(str3 + ((num5 != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + " kg per minute</td>");
														goto IL_1204;
													}
													num4 = altBand.nullable_2;
													if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 1f) : null).GetValueOrDefault())
													{
														StringBuilder stringBuilder4 = stringBuilder;
														string str4 = "<td valign='top'>";
														num4 = (num5 = altBand.nullable_2);
														stringBuilder4.Append(str4 + ((num5 != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + " fuel point per second</td>");
														goto IL_1204;
													}
													StringBuilder stringBuilder5 = stringBuilder;
													string str5 = "<td valign='top'>";
													num4 = (num5 = altBand.nullable_2);
													stringBuilder5.Append(str5 + ((num5 != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + " fuel points per second</td>");
													goto IL_1204;
												}
											}
											num4 = altBand.nullable_2;
											if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 1f) : null).GetValueOrDefault())
											{
												StringBuilder stringBuilder6 = stringBuilder;
												string str6 = "<td valign='top'>";
												float? num5;
												num4 = (num5 = altBand.nullable_2);
												stringBuilder6.Append(str6 + ((num5 != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + " battery unit per minute</td>");
											}
											else
											{
												StringBuilder stringBuilder7 = stringBuilder;
												string str7 = "<td valign='top'>";
												float? num5;
												num4 = (num5 = altBand.nullable_2);
												stringBuilder7.Append(str7 + ((num5 != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + " battery units per minute</td>");
											}
										}
										IL_1204:
										stringBuilder.Append("</tr>");
									}
									if (altBand.nullable_1 != null)
									{
										stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
										if (!activeUnit_0.bool_3 && !activeUnit_0.method_2())
										{
											if (!activeUnit_0.bool_5 && !activeUnit_0.bool_7)
											{
												stringBuilder.Append("<td valign='top'>Flank Throttle</td>");
											}
											else
											{
												stringBuilder.Append("<td valign='top'>Band " + Conversions.ToString(num) + ", Flank Throttle</td>");
											}
										}
										else
										{
											stringBuilder.Append("<td valign='top'>Band " + Conversions.ToString(num) + ", Afterburner Speed</td>");
										}
										if (activeUnit_0.bool_3 || activeUnit_0.method_2())
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												string.Format("{0:0}", altBand.float_1 * 3.28084f),
												" - ",
												string.Format("{0:0}", altBand.float_0 * 3.28084f),
												" ft<br>",
												Conversions.ToString(altBand.float_1),
												" - ",
												Conversions.ToString(altBand.float_0),
												" m</td>"
											}));
										}
										if (activeUnit_0.bool_5 || activeUnit_0.bool_7)
										{
											stringBuilder.Append(string.Concat(new string[]
											{
												"<td>",
												Conversions.ToString(Conversions.ToDouble(string.Format("{0:0}", altBand.float_0 * 3.28084f)) * -1.0),
												" - ",
												Conversions.ToString(Conversions.ToDouble(string.Format("{0:0}", altBand.float_1 * 3.28084f)) * -1.0),
												" ft<br>",
												Conversions.ToString(altBand.float_0 * -1f),
												" - ",
												Conversions.ToString(altBand.float_1 * -1f),
												" m</td>"
											}));
										}
										StringBuilder stringBuilder8 = stringBuilder;
										string str8 = "<td>";
										long? num3;
										long? num2 = num3 = altBand.nullable_1;
										stringBuilder8.Append(str8 + ((num3 != null) ? Conversions.ToString(num2.GetValueOrDefault()) : null) + " kt");
										if (activeUnit_0.bool_3 || activeUnit_0.method_2())
										{
											stringBuilder.Append("<br>" + string.Format("{0:0.00}", Class437.smethod_0((double)altBand.float_1, (double)altBand.nullable_1.Value)) + " Mach");
										}
										stringBuilder.Append("</td>");
										if (engine.enum112_0 != Engine.Enum112.const_9)
										{
											float? num4;
											if (engine.enum112_0 != Engine.Enum112.const_10)
											{
												if (engine.enum112_0 != Engine.Enum112.const_11)
												{
													float? num5;
													if (!activeUnit_0.bool_2)
													{
														StringBuilder stringBuilder9 = stringBuilder;
														string str9 = "<td valign='top'>";
														num4 = (num5 = altBand.nullable_3);
														stringBuilder9.Append(str9 + ((num5 != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + " kg per minute</td>");
														goto IL_169C;
													}
													num4 = altBand.nullable_3;
													if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 1f) : null).GetValueOrDefault())
													{
														StringBuilder stringBuilder10 = stringBuilder;
														string str10 = "<td valign='top'>";
														num4 = (num5 = altBand.nullable_3);
														stringBuilder10.Append(str10 + ((num5 != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + " fuel point per second</td>");
														goto IL_169C;
													}
													StringBuilder stringBuilder11 = stringBuilder;
													string str11 = "<td valign='top'>";
													num4 = (num5 = altBand.nullable_3);
													stringBuilder11.Append(str11 + ((num5 != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + " fuel points per second</td>");
													goto IL_169C;
												}
											}
											num4 = altBand.nullable_3;
											if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 1f) : null).GetValueOrDefault())
											{
												StringBuilder stringBuilder12 = stringBuilder;
												string str12 = "<td valign='top'>";
												float? num5;
												num4 = (num5 = altBand.nullable_3);
												stringBuilder12.Append(str12 + ((num5 != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + " battery unit per minute</td>");
											}
											else
											{
												StringBuilder stringBuilder13 = stringBuilder;
												string str13 = "<td valign='top'>";
												float? num5;
												num4 = (num5 = altBand.nullable_3);
												stringBuilder13.Append(str13 + ((num5 != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + " battery units per minute</td>");
											}
										}
										IL_169C:
										stringBuilder.Append("</tr>");
									}
									goto IL_1701;
								}
								catch (Exception ex3)
								{
									ex3.Data.Add("Error at 200378", ex3.Message);
									GameGeneral.smethod_25(ref ex3);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									goto IL_1701;
								}
								break;
								IL_1701:
								num++;
							}
							stringBuilder.Append("</table>");
							stringBuilder.Append("<br/>");
						}
					}
				}
				finally
				{
					IEnumerator<IGrouping<int, Engine>> enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x003E3E0C File Offset: 0x003E200C
		public string method_41(ActiveUnit activeUnit_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (Enumerable.Count<FuelRec>(activeUnit_0.vmethod_67()) > 0)
			{
				stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='color: dodgerblue; font-family: Arial'><strong>FUEL</strong></span></div>");
				stringBuilder.Append("<table width='100%' align='Center'  cellpadding='2' cellspacing='0' rules='rows' style=' font-size: medium;  font-weight: normal;  text-align: left;   height: 10px; '>");
				stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;font-weight:bold;'>");
				stringBuilder.Append("<td>Fuel Type</td><td>Quantity</td>");
				stringBuilder.Append("</tr>");
				foreach (FuelRec fuelRec in activeUnit_0.vmethod_67())
				{
					stringBuilder.Append("<tr style=';font-family:Verdana;font-size:8pt;'>");
					double num = (double)fuelRec.int_0;
					string str;
					if (!activeUnit_0.bool_3 & !activeUnit_0.bool_2)
					{
						if (fuelRec._FuelType_0 != FuelRec._FuelType.Battery)
						{
							if (fuelRec._FuelType_0 != FuelRec._FuelType.AirIndepedent)
							{
								num /= 1000.0;
								str = " tons";
								goto IL_128;
							}
						}
						if (num > 120.0)
						{
							num /= 60.0;
							str = " hours at creep throttle";
						}
						else
						{
							str = " minutes at creep throttle";
						}
					}
					else if (activeUnit_0.bool_2)
					{
						if (num > 120.0)
						{
							num /= 60.0;
							str = " minutes";
						}
						else
						{
							str = " seconds";
						}
					}
					else
					{
						str = " kg";
					}
					IL_128:
					stringBuilder.Append("<td>" + Misc.smethod_26(fuelRec._FuelType_0, Client.smethod_46().method_39()) + "</td>");
					stringBuilder.Append("<td>" + string.Format("{0:0.0}", num) + str + "</td>");
					stringBuilder.Append("</tr>");
				}
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br/>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x003E3FD0 File Offset: 0x003E21D0
		public string method_42(ActiveUnit activeUnit_0, Weapon weapon_0)
		{
			InternalDBViewer.Class2492 @class = new InternalDBViewer.Class2492(@class);
			@class.weapon_0 = weapon_0;
			string text = @class.weapon_0.method_151() + ". ";
			string text2 = "Targets: " + string.Join(", ", @class.weapon_0.method_150()) + ". ";
			string text3 = (@class.weapon_0.vmethod_143().vmethod_38() > 0) ? ("Max Speed: " + Conversions.ToString(@class.weapon_0.vmethod_143().vmethod_38()) + " kts. ") : "";
			string text4 = (@class.weapon_0.method_159() > 0f) ? ("Max Range: " + Conversions.ToString(@class.weapon_0.method_159()) + " nm. ") : "";
			IEnumerable<IGrouping<string, Warhead>> enumerable = Enumerable.GroupBy<Warhead, string>(@class.weapon_0.warhead_0, (InternalDBViewer._Closure$__.$I101-0 == null) ? (InternalDBViewer._Closure$__.$I101-0 = new Func<Warhead, string>(InternalDBViewer._Closure$__.$I.method_16)) : InternalDBViewer._Closure$__.$I101-0);
			List<string> list = new List<string>();
			try
			{
				foreach (IGrouping<string, Warhead> grouping in enumerable)
				{
					string text5 = "";
					if (Enumerable.Count<Warhead>(grouping) > 1)
					{
						text5 = Conversions.ToString(Enumerable.Count<Warhead>(grouping)) + "x ";
					}
					if (Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).method_14(Client.smethod_46()))
					{
						list.Add(text5 + Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).Name);
					}
					else if (Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).float_0 >= 0f)
					{
						list.Add(text5 + Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).Name);
					}
					else
					{
						list.Add(string.Concat(new string[]
						{
							text5,
							Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).Name,
							" (",
							Conversions.ToString(Enumerable.ElementAtOrDefault<Warhead>(grouping, 0).float_0),
							" DPs)"
						}));
					}
				}
			}
			finally
			{
				IEnumerator<IGrouping<string, Warhead>> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			string text6 = ((list.Count > 0) ? ((@class.weapon_0.warhead_0.Length > 1) ? ("Warheads: " + string.Join(" - ", list)) : ("Warhead: " + string.Join(" - ", list))) : "") + ". ";
			string text7;
			if (@class.weapon_0.method_0() && @class.weapon_0.hashSet_0.Count > 0)
			{
				IEnumerable<IGrouping<int, Sensor>> enumerable2 = Enumerable.GroupBy<Sensor, int>(Enumerable.Where<Sensor>(activeUnit_0.method_78(), new Func<Sensor, bool>(@class.method_0)), (InternalDBViewer._Closure$__.$I101-2 == null) ? (InternalDBViewer._Closure$__.$I101-2 = new Func<Sensor, int>(InternalDBViewer._Closure$__.$I.method_17)) : InternalDBViewer._Closure$__.$I101-2);
				if (Enumerable.Count<IGrouping<int, Sensor>>(enumerable2) > 0)
				{
					List<string> list2 = new List<string>();
					try
					{
						foreach (IGrouping<int, Sensor> grouping2 in enumerable2)
						{
							list2.Add(Enumerable.ElementAtOrDefault<Sensor>(grouping2, 0).Name);
						}
					}
					finally
					{
						IEnumerator<IGrouping<int, Sensor>> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					text7 = "Can be guided by: " + string.Join(", ", list2) + ". ";
				}
			}
			string text8 = "";
			if (@class.weapon_0.method_155())
			{
				text8 = string.Concat(new string[]
				{
					"Deployment depth: ",
					string.Format("{0:0}", @class.weapon_0.float_45 * 3.28084f),
					" ft - ",
					string.Format("{0:0}", @class.weapon_0.float_46 * 3.28084f),
					" ft, ",
					Conversions.ToString(@class.weapon_0.float_45),
					" m - ",
					Conversions.ToString(@class.weapon_0.float_46),
					" m. "
				});
			}
			return string.Concat(new string[]
			{
				text,
				text2,
				text3,
				text4,
				text6,
				text8,
				text7
			});
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x003E4414 File Offset: 0x003E2614
		public string method_43(Weapon weapon_0)
		{
			StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "Templates\\Platform.html"));
			string text;
			using (streamReader)
			{
				text = streamReader.ReadToEnd();
			}
			text = text.Replace("<%PlatformName%>", "#" + Conversions.ToString(this.int_0) + " - " + weapon_0.string_2);
			text = text.Replace("<%Image%>", this.method_23(weapon_0));
			text = text.Replace("<%Description%>", this.method_25(weapon_0));
			text = text.Replace("<%General%>", this.method_18(weapon_0));
			text = text.Replace("<%Sensors%>", this.method_26(weapon_0));
			text = text.Replace("<%MineCountermeasures%>", "");
			text = text.Replace("<%Comms%>", this.method_32(weapon_0));
			text = text.Replace("<%Signatures%>", this.method_37(weapon_0));
			text = text.Replace("<%Flags%>", this.method_38(weapon_0));
			text = text.Replace("<%Warheads%>", this.method_39(weapon_0));
			text = text.Replace("<%ValidTargets%>", this.method_35(weapon_0));
			text = text.Replace("<%WRA%>", this.method_36(weapon_0));
			text = text.Replace("<%Propulsion%>", this.method_40(weapon_0));
			text = text.Replace("<%Fuel%>", this.method_41(weapon_0));
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<div style='border-bottom: black 1px solid'><span style='font-family: Arial; color: dodgerblue;'><strong>DEFAULT WEAPON CARRIER PLATFORMS</strong></span></div>");
			stringBuilder.Append("<div style='color:Black;background-;font-family:Verdana;font-size:8pt;'>");
			List<string> list = Enumerable.ToList<string>(Enumerable.OrderBy<string, string>(DBFunctions.smethod_85(weapon_0.DBID, Client.smethod_46()), (InternalDBViewer._Closure$__.$I102-0 == null) ? (InternalDBViewer._Closure$__.$I102-0 = new Func<string, string>(InternalDBViewer._Closure$__.$I.method_18)) : InternalDBViewer._Closure$__.$I102-0, new Class440<string[]>(true)));
			try
			{
				foreach (string text2 in list)
				{
					string text3 = text2.Split(new char[]
					{
						'_'
					})[0];
					string text4 = text2.Split(new char[]
					{
						'_'
					})[1];
					string text5 = text2.Split(new char[]
					{
						'_'
					})[2];
					string text6 = text2.Split(new char[]
					{
						'_'
					})[3];
					string text7 = text2.Split(new char[]
					{
						'_'
					})[4];
					stringBuilder.Append(string.Concat(new string[]
					{
						"<a href=",
						text3,
						"_",
						text4,
						">",
						text5,
						" (",
						text6,
						" - ",
						text7,
						")</a><br/>"
					}));
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			stringBuilder.Append("</div>");
			text += stringBuilder.ToString();
			return text;
		}

		// Token: 0x06007349 RID: 29513 RVA: 0x003E4708 File Offset: 0x003E2908
		private void InternalDBViewer_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (!this.bool_4 && !this.vmethod_12().Focused && !this.vmethod_10().Focused && !this.vmethod_4().Focused && !this.vmethod_18().Focused && !this.vmethod_0().Focused && base.Visible && e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.End && e.KeyCode != Keys.Home)
			{
				Class2413.smethod_2().method_41().Focus();
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600734A RID: 29514 RVA: 0x00047FCA File Offset: 0x000461CA
		private void InternalDBViewer_MouseWheel(object sender, MouseEventArgs e)
		{
			if (this.bool_4)
			{
				this.vmethod_0().Focus();
				return;
			}
			this.vmethod_16().Focus();
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x00047FED File Offset: 0x000461ED
		private void method_44(object sender, EventArgs e)
		{
			if (!this.vmethod_0().Focused)
			{
				this.vmethod_0().Focus();
			}
			this.bool_4 = true;
		}

		// Token: 0x0600734C RID: 29516 RVA: 0x0004800F File Offset: 0x0004620F
		private void method_45(object sender, EventArgs e)
		{
			this.bool_4 = false;
			this.vmethod_16().Focus();
		}

		// Token: 0x0600734D RID: 29517 RVA: 0x00047FC2 File Offset: 0x000461C2
		private void method_46(object sender, EventArgs e)
		{
			this.method_6();
		}

		// Token: 0x0600734E RID: 29518 RVA: 0x003E4804 File Offset: 0x003E2A04
		private void method_47(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (!this.bool_4 && !this.vmethod_12().Focused && !this.vmethod_10().Focused && !this.vmethod_4().Focused && !this.vmethod_18().Focused && !this.vmethod_0().Focused && e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.End && e.KeyCode != Keys.Home)
			{
				Class2413.smethod_2().method_41().Focus();
				KeyEventArgs e2 = new KeyEventArgs(e.KeyData);
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e2);
			}
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x003E490C File Offset: 0x003E2B0C
		private void method_48(object sender, WebBrowserNavigatingEventArgs e)
		{
			if (e.Url.AbsolutePath.Contains("_"))
			{
				e.Cancel = true;
				string text = e.Url.AbsolutePath.Split(new char[]
				{
					'_'
				})[0];
				int num = Conversions.ToInteger(e.Url.AbsolutePath.Split(new char[]
				{
					'_'
				})[1]);
				bool retainPlatform = Operators.CompareString(this.string_0, "Weapon", false) != 0;
				this.string_0 = text;
				this.int_0 = num;
				this.method_4(false, retainPlatform);
			}
		}

		// Token: 0x06007350 RID: 29520 RVA: 0x003E49A4 File Offset: 0x003E2BA4
		private void method_49(object sender, EventArgs e)
		{
			if (!this.bool_3)
			{
				this.int_0 = Conversions.ToInteger(this.vmethod_0().method_21()[0].Tag);
				if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().SelectedItem)))
				{
					this.string_0 = Conversions.ToString(this.vmethod_12().SelectedItem);
				}
				if (!string.IsNullOrEmpty(this.string_0))
				{
					this.method_4(false, false);
				}
			}
		}

		// Token: 0x06007351 RID: 29521 RVA: 0x00048024 File Offset: 0x00046224
		[CompilerGenerated]
		private bool method_50(Class117 class117_0)
		{
			return Conversions.ToInteger(class117_0.Tag) == this.int_0;
		}

		// Token: 0x040040D2 RID: 16594
		[AccessedThroughProperty("ListBox1")]
		[CompilerGenerated]
		private Control4 control4_0;

		// Token: 0x040040D3 RID: 16595
		[AccessedThroughProperty("GroupBox1")]
		[CompilerGenerated]
		private Class115 class115_0;

		// Token: 0x040040D4 RID: 16596
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Country")]
		private Class2451 class2451_0;

		// Token: 0x040040D5 RID: 16597
		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Class116 class116_0;

		// Token: 0x040040D6 RID: 16598
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x040040D7 RID: 16599
		[AccessedThroughProperty("TB_Class")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x040040D8 RID: 16600
		[AccessedThroughProperty("CB_ObjectType")]
		[CompilerGenerated]
		private Class2451 class2451_1;

		// Token: 0x040040D9 RID: 16601
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_2;

		// Token: 0x040040DA RID: 16602
		[CompilerGenerated]
		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser webBrowser_0;

		// Token: 0x040040DB RID: 16603
		[AccessedThroughProperty("CB_Hypothetical")]
		[CompilerGenerated]
		private Class2451 class2451_2;

		// Token: 0x040040DC RID: 16604
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Class116 class116_3;

		// Token: 0x040040DD RID: 16605
		public string string_0;

		// Token: 0x040040DE RID: 16606
		public int int_0;

		// Token: 0x040040DF RID: 16607
		public string string_1;

		// Token: 0x040040E0 RID: 16608
		public string string_2;

		// Token: 0x040040E1 RID: 16609
		public string string_3;

		// Token: 0x040040E2 RID: 16610
		public string string_4;

		// Token: 0x040040E3 RID: 16611
		private DataTable dataTable_0;

		// Token: 0x040040E4 RID: 16612
		private bool bool_3;

		// Token: 0x040040E5 RID: 16613
		private bool bool_4;

		// Token: 0x040040E6 RID: 16614
		private DBOps.DBFileCheckResult dbfileCheckResult_0;

		// Token: 0x02000E8B RID: 3723
		[CompilerGenerated]
		internal sealed class Class2490
		{
			// Token: 0x06007352 RID: 29522 RVA: 0x00048039 File Offset: 0x00046239
			public Class2490(InternalDBViewer.Class2490 class2490_0)
			{
				if (class2490_0 != null)
				{
					this.string_0 = class2490_0.string_0;
					this.list_0 = class2490_0.list_0;
				}
			}

			// Token: 0x06007353 RID: 29523 RVA: 0x003E4A1C File Offset: 0x003E2C1C
			internal void method_0()
			{
				if (!File.Exists(this.string_0))
				{
					Class2564.smethod_5(this.string_0);
				}
				try
				{
					foreach (string text in this.list_0)
					{
						if (!File.Exists(text))
						{
							Class2564.smethod_5(text);
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}

			// Token: 0x040040E7 RID: 16615
			public string string_0;

			// Token: 0x040040E8 RID: 16616
			public List<string> list_0;
		}

		// Token: 0x02000E8D RID: 3725
		[CompilerGenerated]
		internal sealed class Class2491
		{
			// Token: 0x06007369 RID: 29545 RVA: 0x00048080 File Offset: 0x00046280
			public Class2491(InternalDBViewer.Class2491 class2491_0)
			{
				if (class2491_0 != null)
				{
					this.mount_0 = class2491_0.mount_0;
				}
			}

			// Token: 0x0600736A RID: 29546 RVA: 0x00048097 File Offset: 0x00046297
			internal bool method_0(Sensor sensor_0)
			{
				return this.mount_0.hashSet_1.Contains(sensor_0.DBID);
			}

			// Token: 0x040040FD RID: 16637
			public Mount mount_0;
		}

		// Token: 0x02000E8E RID: 3726
		[CompilerGenerated]
		internal sealed class Class2492
		{
			// Token: 0x0600736B RID: 29547 RVA: 0x000480AF File Offset: 0x000462AF
			public Class2492(InternalDBViewer.Class2492 class2492_0)
			{
				if (class2492_0 != null)
				{
					this.weapon_0 = class2492_0.weapon_0;
				}
			}

			// Token: 0x0600736C RID: 29548 RVA: 0x000480C6 File Offset: 0x000462C6
			internal bool method_0(Sensor sensor_0)
			{
				return this.weapon_0.hashSet_0.Contains(sensor_0.DBID);
			}

			// Token: 0x040040FE RID: 16638
			public Weapon weapon_0;
		}
	}
}
