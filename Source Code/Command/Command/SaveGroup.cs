using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns2;
using ns3;
using ns32;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000EC2 RID: 3778
	[DesignerGenerated]
	public sealed partial class SaveGroup : DarkSecondaryFormBase
	{
		// Token: 0x06007AC5 RID: 31429 RVA: 0x0042A2D8 File Offset: 0x004284D8
		public SaveGroup()
		{
			base.Load += this.SaveGroup_Load;
			base.KeyDown += this.SaveGroup_KeyDown;
			base.FormClosing += this.SaveGroup_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x06007AC7 RID: 31431 RVA: 0x0042A368 File Offset: 0x00428568
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class116());
			this.vmethod_3(new Control8());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Control8());
			this.vmethod_9(new Class116());
			this.vmethod_11(new Control8());
			this.vmethod_13(new Control8());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Control9());
			this.vmethod_19(new Control9());
			this.vmethod_21(new SaveFileDialog());
			base.SuspendLayout();
			this.vmethod_0().Location = new Point(13, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(38, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Name:";
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().Location = new Point(78, 10);
			this.vmethod_2().Name = "TB_Name";
			this.vmethod_2().Size = new Size(439, 20);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().Location = new Point(12, 39);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new Size(56, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Valid from:";
			this.vmethod_6().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_6().Location = new Point(78, 36);
			this.vmethod_6().Name = "TB_ValidFrom";
			this.vmethod_6().Size = new Size(439, 20);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_8().Location = new Point(13, 65);
			this.vmethod_8().Name = "Label3";
			this.vmethod_8().Size = new Size(57, 13);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "Valid Until:";
			this.vmethod_10().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_10().Location = new Point(78, 62);
			this.vmethod_10().Name = "TB_ValidUntil";
			this.vmethod_10().Size = new Size(438, 20);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_12().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_12().Location = new Point(78, 89);
			this.vmethod_12().method_7(true);
			this.vmethod_12().Name = "TB_Notes";
			this.vmethod_12().Size = new Size(438, 113);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_14().Location = new Point(13, 89);
			this.vmethod_14().Name = "Label4";
			this.vmethod_14().Size = new Size(38, 13);
			this.vmethod_14().TabIndex = 7;
			this.vmethod_14().Text = "Notes:";
			this.vmethod_16().Location = new Point(78, 208);
			this.vmethod_16().Name = "Button1";
			this.vmethod_16().Size = new Size(70, 37);
			this.vmethod_16().TabIndex = 8;
			this.vmethod_16().Text = "Save";
			this.vmethod_18().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_18().Location = new Point(426, 208);
			this.vmethod_18().Name = "Button2";
			this.vmethod_18().Size = new Size(91, 37);
			this.vmethod_18().TabIndex = 9;
			this.vmethod_18().Text = "Cancel";
			this.vmethod_20().DefaultExt = "inst";
			this.vmethod_20().Filter = "Import/Export file (*.inst)|*.inst|All Files (*.*)|*.*";
			this.vmethod_20().InitialDirectory = "Installations";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.CancelButton = this.vmethod_18();
			base.ClientSize = new Size(529, 257);
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.Fixed3D;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SaveGroup";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Export units/groups to file";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06007AC8 RID: 31432 RVA: 0x0004B8CE File Offset: 0x00049ACE
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x06007AC9 RID: 31433 RVA: 0x0004B8D6 File Offset: 0x00049AD6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_4)
		{
			this.class116_0 = class116_4;
		}

		// Token: 0x06007ACA RID: 31434 RVA: 0x0004B8DF File Offset: 0x00049ADF
		[CompilerGenerated]
		internal Control8 vmethod_2()
		{
			return this.control8_0;
		}

		// Token: 0x06007ACB RID: 31435 RVA: 0x0004B8E7 File Offset: 0x00049AE7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control8 control8_4)
		{
			this.control8_0 = control8_4;
		}

		// Token: 0x06007ACC RID: 31436 RVA: 0x0004B8F0 File Offset: 0x00049AF0
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x06007ACD RID: 31437 RVA: 0x0004B8F8 File Offset: 0x00049AF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_4)
		{
			this.class116_1 = class116_4;
		}

		// Token: 0x06007ACE RID: 31438 RVA: 0x0004B901 File Offset: 0x00049B01
		[CompilerGenerated]
		internal Control8 vmethod_6()
		{
			return this.control8_1;
		}

		// Token: 0x06007ACF RID: 31439 RVA: 0x0004B909 File Offset: 0x00049B09
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control8 control8_4)
		{
			this.control8_1 = control8_4;
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x0004B912 File Offset: 0x00049B12
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_2;
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x0004B91A File Offset: 0x00049B1A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_4)
		{
			this.class116_2 = class116_4;
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x0004B923 File Offset: 0x00049B23
		[CompilerGenerated]
		internal Control8 vmethod_10()
		{
			return this.control8_2;
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x0004B92B File Offset: 0x00049B2B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control8 control8_4)
		{
			this.control8_2 = control8_4;
		}

		// Token: 0x06007AD4 RID: 31444 RVA: 0x0004B934 File Offset: 0x00049B34
		[CompilerGenerated]
		internal Control8 vmethod_12()
		{
			return this.control8_3;
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x0004B93C File Offset: 0x00049B3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control8 control8_4)
		{
			this.control8_3 = control8_4;
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x0004B945 File Offset: 0x00049B45
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_3;
		}

		// Token: 0x06007AD7 RID: 31447 RVA: 0x0004B94D File Offset: 0x00049B4D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_4)
		{
			this.class116_3 = class116_4;
		}

		// Token: 0x06007AD8 RID: 31448 RVA: 0x0004B956 File Offset: 0x00049B56
		[CompilerGenerated]
		internal Control9 vmethod_16()
		{
			return this.control9_0;
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x0042A8CC File Offset: 0x00428ACC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_2;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007ADA RID: 31450 RVA: 0x0004B95E File Offset: 0x00049B5E
		[CompilerGenerated]
		internal Control9 vmethod_18()
		{
			return this.control9_1;
		}

		// Token: 0x06007ADB RID: 31451 RVA: 0x0042A910 File Offset: 0x00428B10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_2;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007ADC RID: 31452 RVA: 0x0004B966 File Offset: 0x00049B66
		[CompilerGenerated]
		internal SaveFileDialog vmethod_20()
		{
			return this.saveFileDialog_0;
		}

		// Token: 0x06007ADD RID: 31453 RVA: 0x0004B96E File Offset: 0x00049B6E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(SaveFileDialog saveFileDialog_1)
		{
			this.saveFileDialog_0 = saveFileDialog_1;
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06007ADF RID: 31455 RVA: 0x0004B977 File Offset: 0x00049B77
		private void SaveGroup_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.readOnlyCollection_0 = Client.smethod_50().method_56();
		}

		// Token: 0x06007AE0 RID: 31456 RVA: 0x0042A954 File Offset: 0x00428B54
		private void method_4(object sender, EventArgs e)
		{
			ImportExportRecord importExportRecord = new ImportExportRecord();
			importExportRecord.Name = this.vmethod_2().Text;
			importExportRecord.ValidFrom = this.vmethod_6().Text;
			importExportRecord.ValidUntil = this.vmethod_10().Text;
			importExportRecord.Comments = this.vmethod_12().Text;
			importExportRecord.DB_ID = Client.smethod_40().DBID;
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.IndentChars = "    ";
			xmlWriterSettings.ConformanceLevel = ConformanceLevel.Auto;
			int num = 0;
			try
			{
				foreach (Unit unit in Enumerable.ToList<Unit>(Enumerable.Where<Unit>(this.readOnlyCollection_0, (SaveGroup._Closure$__.$I51-0 == null) ? (SaveGroup._Closure$__.$I51-0 = new Func<Unit, bool>(SaveGroup._Closure$__.$I.method_0)) : SaveGroup._Closure$__.$I51-0)))
				{
					ActiveUnit activeUnit = (ActiveUnit)unit;
					ImportExportRecord.MemberRecord memberRecord;
					StreamWriter streamWriter_;
					if (activeUnit.bool_1)
					{
						try
						{
							foreach (ActiveUnit activeUnit2 in ((Group)activeUnit).vmethod_141().Values)
							{
								memberRecord = new ImportExportRecord.MemberRecord();
								memberRecord.Member_DBID = activeUnit2.DBID;
								memberRecord.Member_GUID = activeUnit2.string_0;
								switch (activeUnit2.vmethod_56())
								{
								case GlobalVariables.ActiveUnitType.Aircraft:
									memberRecord.MemberType = "Aircraft";
									break;
								case GlobalVariables.ActiveUnitType.Ship:
									memberRecord.MemberType = "Ship";
									break;
								case GlobalVariables.ActiveUnitType.Submarine:
									memberRecord.MemberType = "Submarine";
									break;
								case GlobalVariables.ActiveUnitType.Facility:
									memberRecord.MemberType = "Facility";
									break;
								case GlobalVariables.ActiveUnitType.Weapon:
									memberRecord.MemberType = "Weapon";
									break;
								}
								memberRecord.Orientation = activeUnit2.vmethod_9();
								memberRecord.Latitude = activeUnit2.vmethod_30(null);
								memberRecord.Longitude = activeUnit2.vmethod_28(null);
								memberRecord.MemberName = activeUnit2.Name;
								memberRecord.ParentGroupName = activeUnit2.vmethod_65(false).Name;
								MemoryStream memoryStream = new MemoryStream();
								using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings))
								{
									xmlWriter.WriteStartElement("DeltaUnit");
									Class559.smethod_4(activeUnit2, activeUnit2.scenario_0, xmlWriter, streamWriter_, ref num);
									xmlWriter.WriteEndElement();
									xmlWriter.Flush();
								}
								if (Operators.CompareString(Misc.smethod_45(memoryStream), "<DeltaUnit />", false) != 0)
								{
									memberRecord.Member_SBR = Misc.smethod_45(memoryStream);
								}
								this.method_5(ref activeUnit2, ref memberRecord);
								this.method_6(ref activeUnit2, ref memberRecord);
								importExportRecord.MemberRecords.Add(memberRecord);
							}
							continue;
						}
						finally
						{
							IEnumerator<ActiveUnit> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
					memberRecord = new ImportExportRecord.MemberRecord();
					memberRecord.Member_DBID = activeUnit.DBID;
					memberRecord.Member_GUID = activeUnit.string_0;
					switch (activeUnit.vmethod_56())
					{
					case GlobalVariables.ActiveUnitType.Aircraft:
						memberRecord.MemberType = "Aircraft";
						break;
					case GlobalVariables.ActiveUnitType.Ship:
						memberRecord.MemberType = "Ship";
						break;
					case GlobalVariables.ActiveUnitType.Submarine:
						memberRecord.MemberType = "Submarine";
						break;
					case GlobalVariables.ActiveUnitType.Facility:
						memberRecord.MemberType = "Facility";
						break;
					case GlobalVariables.ActiveUnitType.Weapon:
						memberRecord.MemberType = "Weapon";
						break;
					}
					memberRecord.Orientation = activeUnit.vmethod_9();
					memberRecord.Latitude = activeUnit.vmethod_30(null);
					memberRecord.Longitude = activeUnit.vmethod_28(null);
					memberRecord.MemberName = activeUnit.Name;
					if (activeUnit.method_120())
					{
						memberRecord.ParentGroupName = activeUnit.vmethod_65(false).Name;
					}
					if (activeUnit.GetType() == typeof(Aircraft))
					{
						if (!Information.IsNothing(((Aircraft)activeUnit).method_167()))
						{
							memberRecord.LoadoutID = ((Aircraft)activeUnit).method_167().DBID;
						}
						else
						{
							memberRecord.LoadoutID = 0;
						}
					}
					MemoryStream memoryStream2 = new MemoryStream();
					using (XmlWriter xmlWriter2 = XmlWriter.Create(memoryStream2, xmlWriterSettings))
					{
						xmlWriter2.WriteStartElement("DeltaUnit");
						Class559.smethod_4(activeUnit, activeUnit.scenario_0, xmlWriter2, streamWriter_, ref num);
						xmlWriter2.WriteEndElement();
						xmlWriter2.Flush();
					}
					if (Operators.CompareString(Misc.smethod_45(memoryStream2), "<DeltaUnit />", false) != 0)
					{
						memberRecord.Member_SBR = Misc.smethod_45(memoryStream2);
					}
					this.method_5(ref activeUnit, ref memberRecord);
					this.method_6(ref activeUnit, ref memberRecord);
					importExportRecord.MemberRecords.Add(memberRecord);
				}
			}
			finally
			{
				List<Unit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.vmethod_20().InitialDirectory = Application.StartupPath + "\\ImportExport";
			if (this.vmethod_20().ShowDialog() == DialogResult.OK)
			{
				StreamWriter streamWriter = new StreamWriter(this.vmethod_20().FileName);
				Class2331 @class = new Class2331();
				using (streamWriter)
				{
					Class2275 class2 = new Class2275(streamWriter);
					class2.method_3(Enum196.const_1);
					using (class2)
					{
						@class.method_1(class2, importExportRecord);
					}
				}
				base.Close();
				return;
			}
			DarkMessageBox.smethod_2(this.vmethod_20().ShowDialog().ToString(), "", Enum11.const_0);
		}

		// Token: 0x06007AE1 RID: 31457 RVA: 0x001A9D6C File Offset: 0x001A7F6C
		private void method_5(ref ActiveUnit activeUnit_0, ref ImportExportRecord.MemberRecord memberRecord_0)
		{
			if (activeUnit_0.vmethod_92().vmethod_4().Count > 0)
			{
				try
				{
					foreach (Aircraft aircraft in activeUnit_0.vmethod_92().vmethod_4())
					{
						int int_;
						if (Information.IsNothing(aircraft.method_167()))
						{
							int_ = 0;
						}
						else
						{
							int_ = aircraft.method_167().DBID;
						}
						ImportExportRecord.HostedAircraftRecord item = new ImportExportRecord.HostedAircraftRecord(aircraft.Name, aircraft.DBID, int_, (int)Math.Round((double)(aircraft.method_164().method_38() / 60f)));
						memberRecord_0.HostedAircraftRecords.Add(item);
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x001A9E2C File Offset: 0x001A802C
		private void method_6(ref ActiveUnit activeUnit_0, ref ImportExportRecord.MemberRecord memberRecord_0)
		{
			if (activeUnit_0.vmethod_93().method_14().Count > 0)
			{
				try
				{
					foreach (ActiveUnit activeUnit in activeUnit_0.vmethod_93().method_14())
					{
						ImportExportRecord.EmbarkedBoatRecord item = new ImportExportRecord.EmbarkedBoatRecord(activeUnit.Name, activeUnit.DBID, (int)Math.Round((double)(activeUnit.vmethod_93().method_0() / 60f)), activeUnit.method_63());
						memberRecord_0.EmbarkedBoatRecords.Add(item);
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x06007AE3 RID: 31459 RVA: 0x003B6260 File Offset: 0x003B4460
		private void SaveGroup_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06007AE4 RID: 31460 RVA: 0x00044820 File Offset: 0x00042A20
		private void SaveGroup_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x04004473 RID: 17523
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004474 RID: 17524
		[AccessedThroughProperty("TB_Name")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x04004475 RID: 17525
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_1;

		// Token: 0x04004476 RID: 17526
		[CompilerGenerated]
		[AccessedThroughProperty("TB_ValidFrom")]
		private Control8 control8_1;

		// Token: 0x04004477 RID: 17527
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_2;

		// Token: 0x04004478 RID: 17528
		[CompilerGenerated]
		[AccessedThroughProperty("TB_ValidUntil")]
		private Control8 control8_2;

		// Token: 0x04004479 RID: 17529
		[CompilerGenerated]
		[AccessedThroughProperty("TB_Notes")]
		private Control8 control8_3;

		// Token: 0x0400447A RID: 17530
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_3;

		// Token: 0x0400447B RID: 17531
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x0400447C RID: 17532
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x0400447D RID: 17533
		[CompilerGenerated]
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog saveFileDialog_0;

		// Token: 0x0400447E RID: 17534
		private ReadOnlyCollection<Unit> readOnlyCollection_0;
	}
}
