using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000F04 RID: 3844
	[DesignerGenerated]
	internal sealed partial class ContactReport : DarkSecondaryFormBase
	{
		// Token: 0x06008853 RID: 34899 RVA: 0x0048FEF0 File Offset: 0x0048E0F0
		public ContactReport()
		{
			base.Shown += this.ContactReport_Shown;
			base.KeyDown += this.ContactReport_KeyDown;
			base.FormClosing += this.ContactReport_FormClosing;
			base.Load += this.ContactReport_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x06008855 RID: 34901 RVA: 0x0048FF94 File Offset: 0x0048E194
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class116());
			this.vmethod_3(new Class116());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Control4());
			this.vmethod_9(new Control4());
			this.vmethod_11(new Class116());
			this.vmethod_13(new Control12());
			this.vmethod_15(new TabPage());
			this.vmethod_21(new SplitContainer());
			this.vmethod_17(new TabPage());
			this.vmethod_19(new Class116());
			this.vmethod_12().SuspendLayout();
			this.vmethod_14().SuspendLayout();
			((ISupportInitialize)this.vmethod_20()).BeginInit();
			this.vmethod_20().Panel1.SuspendLayout();
			this.vmethod_20().Panel2.SuspendLayout();
			this.vmethod_20().SuspendLayout();
			this.vmethod_16().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Location = new Point(2, 9);
			this.vmethod_0().Name = "Label_UnitType";
			this.vmethod_0().Size = new Size(52, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Unit type:";
			this.vmethod_2().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_2().Location = new Point(3, 0);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new Size(121, 13);
			this.vmethod_2().TabIndex = 3;
			this.vmethod_2().Text = "Detected emissions:";
			this.vmethod_4().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_4().Location = new Point(3, -1);
			this.vmethod_4().Name = "Label3";
			this.vmethod_4().Size = new Size(112, 13);
			this.vmethod_4().TabIndex = 4;
			this.vmethod_4().Text = "Potential matches:";
			this.vmethod_6().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_6().Location = new Point(6, 16);
			this.vmethod_6().Name = "LB_Emissions";
			this.vmethod_6().Size = new Size(606, 147);
			this.vmethod_6().TabIndex = 5;
			this.vmethod_8().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_8().Location = new Point(3, 17);
			this.vmethod_8().Name = "LB_Matches";
			this.vmethod_8().Size = new Size(609, 199);
			this.vmethod_8().TabIndex = 6;
			this.vmethod_10().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Italic, GraphicsUnit.Point, 0);
			this.vmethod_10().Location = new Point(121, -1);
			this.vmethod_10().Name = "Label2";
			this.vmethod_10().Size = new Size(123, 13);
			this.vmethod_10().TabIndex = 7;
			this.vmethod_10().Text = "(double click for DB info)";
			this.vmethod_12().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_12().Controls.Add(this.vmethod_14());
			this.vmethod_12().Controls.Add(this.vmethod_16());
			this.vmethod_12().Location = new Point(5, 36);
			this.vmethod_12().Name = "TabControl1";
			this.vmethod_12().SelectedIndex = 0;
			this.vmethod_12().Size = new Size(630, 435);
			this.vmethod_12().TabIndex = 8;
			this.vmethod_14().BackColor = SystemColors.Control;
			this.vmethod_14().Controls.Add(this.vmethod_20());
			this.vmethod_14().Location = new Point(4, 22);
			this.vmethod_14().Name = "TabPage1";
			this.vmethod_14().Padding = new Padding(3);
			this.vmethod_14().Size = new Size(622, 409);
			this.vmethod_14().TabIndex = 0;
			this.vmethod_14().Text = "Emissions";
			this.vmethod_20().Dock = DockStyle.Fill;
			this.vmethod_20().Location = new Point(3, 3);
			this.vmethod_20().Name = "SplitContainer1";
			this.vmethod_20().Orientation = Orientation.Horizontal;
			this.vmethod_20().Panel1.Controls.Add(this.vmethod_2());
			this.vmethod_20().Panel1.Controls.Add(this.vmethod_6());
			this.vmethod_20().Panel2.Controls.Add(this.vmethod_10());
			this.vmethod_20().Panel2.Controls.Add(this.vmethod_8());
			this.vmethod_20().Panel2.Controls.Add(this.vmethod_4());
			this.vmethod_20().Size = new Size(616, 403);
			this.vmethod_20().SplitterDistance = 173;
			this.vmethod_20().TabIndex = 8;
			this.vmethod_16().BackColor = SystemColors.Control;
			this.vmethod_16().Controls.Add(this.vmethod_18());
			this.vmethod_16().Location = new Point(4, 22);
			this.vmethod_16().Name = "TabPage2";
			this.vmethod_16().Padding = new Padding(3);
			this.vmethod_16().Size = new Size(622, 409);
			this.vmethod_16().TabIndex = 1;
			this.vmethod_16().Text = "Spotted hosted units";
			this.vmethod_18().method_2(true);
			this.vmethod_18().Location = new Point(6, 3);
			this.vmethod_18().Name = "Label_HostedUnits";
			this.vmethod_18().Size = new Size(97, 13);
			this.vmethod_18().TabIndex = 0;
			this.vmethod_18().Text = "Label_HostedUnits";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(636, 475);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ContactReport";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Contact Report";
			this.vmethod_12().ResumeLayout(false);
			this.vmethod_14().ResumeLayout(false);
			this.vmethod_20().Panel1.ResumeLayout(false);
			this.vmethod_20().Panel1.PerformLayout();
			this.vmethod_20().Panel2.ResumeLayout(false);
			this.vmethod_20().Panel2.PerformLayout();
			((ISupportInitialize)this.vmethod_20()).EndInit();
			this.vmethod_20().ResumeLayout(false);
			this.vmethod_16().ResumeLayout(false);
			this.vmethod_16().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008856 RID: 34902 RVA: 0x00051F8C File Offset: 0x0005018C
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x06008857 RID: 34903 RVA: 0x00051F94 File Offset: 0x00050194
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_5)
		{
			this.class116_0 = class116_5;
		}

		// Token: 0x06008858 RID: 34904 RVA: 0x00051F9D File Offset: 0x0005019D
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_1;
		}

		// Token: 0x06008859 RID: 34905 RVA: 0x00051FA5 File Offset: 0x000501A5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_5)
		{
			this.class116_1 = class116_5;
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x00051FAE File Offset: 0x000501AE
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_2;
		}

		// Token: 0x0600885B RID: 34907 RVA: 0x00051FB6 File Offset: 0x000501B6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_5)
		{
			this.class116_2 = class116_5;
		}

		// Token: 0x0600885C RID: 34908 RVA: 0x00051FBF File Offset: 0x000501BF
		[CompilerGenerated]
		internal Control4 vmethod_6()
		{
			return this.control4_0;
		}

		// Token: 0x0600885D RID: 34909 RVA: 0x00051FC7 File Offset: 0x000501C7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control4 control4_2)
		{
			this.control4_0 = control4_2;
		}

		// Token: 0x0600885E RID: 34910 RVA: 0x00051FD0 File Offset: 0x000501D0
		[CompilerGenerated]
		internal Control4 vmethod_8()
		{
			return this.control4_1;
		}

		// Token: 0x0600885F RID: 34911 RVA: 0x00490700 File Offset: 0x0048E900
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control4 control4_2)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control4 control = this.control4_1;
			if (control != null)
			{
				control.DoubleClick -= value;
			}
			this.control4_1 = control4_2;
			control = this.control4_1;
			if (control != null)
			{
				control.DoubleClick += value;
			}
		}

		// Token: 0x06008860 RID: 34912 RVA: 0x00051FD8 File Offset: 0x000501D8
		[CompilerGenerated]
		internal Class116 vmethod_10()
		{
			return this.class116_3;
		}

		// Token: 0x06008861 RID: 34913 RVA: 0x00051FE0 File Offset: 0x000501E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class116 class116_5)
		{
			this.class116_3 = class116_5;
		}

		// Token: 0x06008862 RID: 34914 RVA: 0x00051FE9 File Offset: 0x000501E9
		[CompilerGenerated]
		internal Control12 vmethod_12()
		{
			return this.control12_0;
		}

		// Token: 0x06008863 RID: 34915 RVA: 0x00490744 File Offset: 0x0048E944
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control12 control12_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			Control12 control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged -= value;
			}
			this.control12_0 = control12_1;
			control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06008864 RID: 34916 RVA: 0x00051FF1 File Offset: 0x000501F1
		[CompilerGenerated]
		internal TabPage vmethod_14()
		{
			return this.tabPage_0;
		}

		// Token: 0x06008865 RID: 34917 RVA: 0x00051FF9 File Offset: 0x000501F9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(TabPage tabPage_2)
		{
			this.tabPage_0 = tabPage_2;
		}

		// Token: 0x06008866 RID: 34918 RVA: 0x00052002 File Offset: 0x00050202
		[CompilerGenerated]
		internal TabPage vmethod_16()
		{
			return this.tabPage_1;
		}

		// Token: 0x06008867 RID: 34919 RVA: 0x0005200A File Offset: 0x0005020A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(TabPage tabPage_2)
		{
			this.tabPage_1 = tabPage_2;
		}

		// Token: 0x06008868 RID: 34920 RVA: 0x00052013 File Offset: 0x00050213
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_4;
		}

		// Token: 0x06008869 RID: 34921 RVA: 0x0005201B File Offset: 0x0005021B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_5)
		{
			this.class116_4 = class116_5;
		}

		// Token: 0x0600886A RID: 34922 RVA: 0x00052024 File Offset: 0x00050224
		[CompilerGenerated]
		internal SplitContainer vmethod_20()
		{
			return this.splitContainer_0;
		}

		// Token: 0x0600886B RID: 34923 RVA: 0x0005202C File Offset: 0x0005022C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(SplitContainer splitContainer_1)
		{
			this.splitContainer_0 = splitContainer_1;
		}

		// Token: 0x0600886C RID: 34924 RVA: 0x00490788 File Offset: 0x0048E988
		private void method_3(object sender, EventArgs e)
		{
			string selectedObjectType = Misc.smethod_43(this.activeUnitType_0);
			int selectedObjectID = Conversions.ToInteger(this.vmethod_8().method_21()[0].Tag);
			Client.smethod_63(selectedObjectType, selectedObjectID, null);
		}

		// Token: 0x0600886D RID: 34925 RVA: 0x004907C4 File Offset: 0x0048E9C4
		private void method_4()
		{
			this.Text = "Contact Report: " + this.contact_0.Name;
			if (!Information.IsNothing(this.contact_0.activeUnit_0))
			{
				switch (this.contact_0.method_125())
				{
				case Contact_Base.IdentificationStatus.Unknown:
				case Contact_Base.IdentificationStatus.KnownDomain:
					this.vmethod_0().Text = "Type: Unknown";
					break;
				case Contact_Base.IdentificationStatus.KnownType:
					this.vmethod_0().Text = "Type: " + this.contact_0.activeUnit_0.vmethod_58();
					break;
				case Contact_Base.IdentificationStatus.KnownClass:
					this.vmethod_0().Text = "Class: " + this.contact_0.activeUnit_0.string_2;
					break;
				case Contact_Base.IdentificationStatus.PreciseID:
					this.vmethod_0().Text = "Identified: " + this.contact_0.activeUnit_0.Name;
					break;
				}
			}
			this.vmethod_6().method_18().Clear();
			this.vmethod_8().method_18().Clear();
			if (!this.contact_0.method_67())
			{
				this.vmethod_6().Enabled = false;
				this.vmethod_2().Text = "No detected emissions";
				return;
			}
			List<int> list = Enumerable.ToList<int>(this.contact_0.method_68().Keys);
			int num2;
			if (this.contact_0.method_68().Count > 0)
			{
				this.vmethod_6().Enabled = true;
				try
				{
					foreach (int num in list)
					{
						EmissionContainer emissionContainer = this.contact_0.method_68()[num];
						string str = emissionContainer.method_1(num, Client.smethod_46());
						this.vmethod_6().method_18().Add(new Class117(str + " (Last: " + Misc.smethod_11((long)Math.Round((double)emissionContainer.float_0), Aircraft_AirOps.Enum44.const_0, false, true) + " ago)"));
						if (emissionContainer.bool_1)
						{
							num2++;
						}
					}
				}
				finally
				{
					List<int>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.vmethod_2().Text = "Detected emissions (" + Conversions.ToString(num2) + " emitters identified):";
			}
			else
			{
				this.vmethod_6().Enabled = false;
				this.vmethod_2().Text = "No detected emissions";
			}
			if (num2 == 0)
			{
				this.vmethod_8().Enabled = false;
				this.vmethod_4().Text = "No emitters positively identified - unable to narrow down possible matches";
				return;
			}
			this.vmethod_4().Text = "Possible matches:";
			DataTable table = null;
			switch (this.contact_0.contactType_0)
			{
			case Contact_Base.ContactType.Air:
				this.activeUnitType_0 = GlobalVariables.ActiveUnitType.Aircraft;
				table = DBFunctions.smethod_1(Client.smethod_46().method_39());
				break;
			case Contact_Base.ContactType.Missile:
			case Contact_Base.ContactType.Torpedo:
				this.activeUnitType_0 = GlobalVariables.ActiveUnitType.Weapon;
				table = DBFunctions.smethod_6(Client.smethod_46().method_39());
				break;
			case Contact_Base.ContactType.Surface:
				this.activeUnitType_0 = GlobalVariables.ActiveUnitType.Ship;
				table = DBFunctions.smethod_2(Client.smethod_46().method_39());
				break;
			case Contact_Base.ContactType.Submarine:
				this.activeUnitType_0 = GlobalVariables.ActiveUnitType.Submarine;
				table = DBFunctions.smethod_3(Client.smethod_46().method_39());
				break;
			case Contact_Base.ContactType.Orbital:
				this.activeUnitType_0 = GlobalVariables.ActiveUnitType.Satellite;
				table = DBFunctions.smethod_5(Client.smethod_46().method_39());
				break;
			case Contact_Base.ContactType.Facility_Fixed:
			case Contact_Base.ContactType.Facility_Mobile:
				this.activeUnitType_0 = GlobalVariables.ActiveUnitType.Facility;
				table = DBFunctions.smethod_4(Client.smethod_46().method_39());
				break;
			}
			List<int> list2 = this.contact_0.method_70();
			if (list2.Count > 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				int count = list2.Count;
				stringBuilder.Append("(" + string.Join<int>(",", list2) + ")");
				DataView dataView = new DataView(table);
				dataView.RowFilter = "ID IN " + stringBuilder.ToString();
				dataView.Sort = "LongName ASC";
				this.vmethod_8().Enabled = true;
				try
				{
					foreach (object obj in dataView)
					{
						DataRow row = ((DataRowView)obj).Row;
						Class117 @class = new Class117(Conversions.ToString(row["LongName"]));
						@class.Tag = RuntimeHelpers.GetObjectValue(row["ID"]);
						this.vmethod_8().method_18().Add(@class);
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				this.vmethod_8().Refresh();
				return;
			}
			this.vmethod_8().Enabled = false;
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x00490C5C File Offset: 0x0048EE5C
		private void method_5()
		{
			if (this.contact_0.method_73(Client.smethod_50()).Count > 0)
			{
				Dictionary<string, int> dictionary = new Dictionary<string, int>();
				try
				{
					foreach (Contact.Class269 @class in this.contact_0.method_73(Client.smethod_50()))
					{
						string text;
						switch (@class.identificationStatus_0)
						{
						case Contact_Base.IdentificationStatus.Unknown:
							text = "Unknown unit";
							break;
						case Contact_Base.IdentificationStatus.KnownDomain:
							try
							{
								ActiveUnit activeUnit = Client.smethod_46().vmethod_0()[@class.string_0];
								text = Misc.smethod_56(activeUnit.vmethod_121()) + " " + activeUnit.method_63();
								break;
							}
							catch (Exception ex)
							{
								ex.Data.Add("Error at 999999", ex.Message);
								GameGeneral.smethod_25(ref ex);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								text = "Unknown unit";
								break;
							}
							goto IL_FF;
						case Contact_Base.IdentificationStatus.KnownType:
							goto IL_FF;
						case Contact_Base.IdentificationStatus.KnownClass:
							goto IL_17E;
						case Contact_Base.IdentificationStatus.PreciseID:
							goto IL_1E0;
						}
						IL_23F:
						text = text + " (Last Recon: " + ((@class.float_0 > 0f) ? (Misc.smethod_11((long)Math.Round((double)@class.float_0), Aircraft_AirOps.Enum44.const_0, false, true) + " ago)") : "Now)");
						if (dictionary.ContainsKey(text))
						{
							dictionary[text]++;
							continue;
						}
						dictionary.Add(text, 1);
						continue;
						IL_FF:
						try
						{
							ActiveUnit activeUnit2 = Client.smethod_46().vmethod_0()[@class.string_0];
							text = Misc.smethod_56(activeUnit2.vmethod_121()) + " " + activeUnit2.vmethod_58();
							goto IL_23F;
						}
						catch (Exception ex2)
						{
							ex2.Data.Add("Error at 200409", ex2.Message);
							GameGeneral.smethod_25(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							text = "Unknown unit";
							goto IL_23F;
						}
						IL_17E:
						try
						{
							text = Client.smethod_46().vmethod_0()[@class.string_0].string_2;
							goto IL_23F;
						}
						catch (Exception ex3)
						{
							ex3.Data.Add("Error at 200410", ex3.Message);
							GameGeneral.smethod_25(ref ex3);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							text = "Unknown unit";
							goto IL_23F;
						}
						IL_1E0:
						try
						{
							text = Client.smethod_46().vmethod_0()[@class.string_0].Name;
						}
						catch (Exception ex4)
						{
							ex4.Data.Add("Error at 200411", ex4.Message);
							GameGeneral.smethod_25(ref ex4);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							text = "Unknown unit";
						}
						goto IL_23F;
					}
				}
				finally
				{
					List<Contact.Class269>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				List<string> list = new List<string>();
				try
				{
					foreach (KeyValuePair<string, int> keyValuePair in dictionary)
					{
						list.Add(Conversions.ToString(keyValuePair.Value) + "x " + keyValuePair.Key);
					}
				}
				finally
				{
					Dictionary<string, int>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				this.vmethod_18().Text = string.Join("\r\n", list);
				return;
			}
			this.vmethod_18().Text = "No hosted units spotted.";
		}

		// Token: 0x0600886F RID: 34927 RVA: 0x00052035 File Offset: 0x00050235
		private void ContactReport_Shown(object sender, EventArgs e)
		{
			this.method_4();
			this.method_5();
			this.vmethod_12().SelectedIndex = Client.int_2;
		}

		// Token: 0x06008870 RID: 34928 RVA: 0x000476BE File Offset: 0x000458BE
		private void ContactReport_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06008871 RID: 34929 RVA: 0x00044820 File Offset: 0x00042A20
		private void ContactReport_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06008872 RID: 34930 RVA: 0x00052053 File Offset: 0x00050253
		private void method_6(object sender, EventArgs e)
		{
			Client.int_2 = this.vmethod_12().SelectedIndex;
		}

		// Token: 0x06008873 RID: 34931 RVA: 0x00044489 File Offset: 0x00042689
		private void ContactReport_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04004A1F RID: 18975
		[CompilerGenerated]
		[AccessedThroughProperty("Label_UnitType")]
		private Class116 class116_0;

		// Token: 0x04004A20 RID: 18976
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x04004A21 RID: 18977
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x04004A22 RID: 18978
		[CompilerGenerated]
		[AccessedThroughProperty("LB_Emissions")]
		private Control4 control4_0;

		// Token: 0x04004A23 RID: 18979
		[CompilerGenerated]
		[AccessedThroughProperty("LB_Matches")]
		private Control4 control4_1;

		// Token: 0x04004A24 RID: 18980
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x04004A25 RID: 18981
		[AccessedThroughProperty("TabControl1")]
		[CompilerGenerated]
		private Control12 control12_0;

		// Token: 0x04004A26 RID: 18982
		[AccessedThroughProperty("TabPage1")]
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04004A27 RID: 18983
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage2")]
		private TabPage tabPage_1;

		// Token: 0x04004A28 RID: 18984
		[CompilerGenerated]
		[AccessedThroughProperty("Label_HostedUnits")]
		private Class116 class116_4;

		// Token: 0x04004A29 RID: 18985
		[AccessedThroughProperty("SplitContainer1")]
		[CompilerGenerated]
		private SplitContainer splitContainer_0;

		// Token: 0x04004A2A RID: 18986
		public Contact contact_0;

		// Token: 0x04004A2B RID: 18987
		private GlobalVariables.ActiveUnitType activeUnitType_0;
	}
}
