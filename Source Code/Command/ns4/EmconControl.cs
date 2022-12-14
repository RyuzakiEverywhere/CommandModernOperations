using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns17;
using ns2;
using ns3;
using ns5;

namespace ns4
{
	// Token: 0x02000E5D RID: 3677
	[DesignerGenerated]
	internal sealed class EmconControl : Control7
	{
		// Token: 0x06006F9A RID: 28570 RVA: 0x003C41B0 File Offset: 0x003C23B0
		public EmconControl()
		{
			base.Load += this.EmconControl_Load;
			base.VisibleChanged += this.EmconControl_VisibleChanged;
			this.bool_0 = true;
			this.bool_1 = true;
			this.bool_2 = false;
			this.InitializeComponent();
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x003C4204 File Offset: 0x003C2404
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_1 != null)
				{
					this.icontainer_1.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06006F9C RID: 28572 RVA: 0x003C4244 File Offset: 0x003C2444
		private void InitializeComponent()
		{
			this.vmethod_1(new Class111());
			this.vmethod_3(new Class111());
			this.vmethod_5(new Class112());
			this.vmethod_7(new Class2451());
			this.vmethod_9(new TableLayoutPanel());
			this.vmethod_11(new Class2451());
			this.vmethod_13(new Class2451());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Class116());
			this.vmethod_19(new Class116());
			this.vmethod_8().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "Button1";
			this.vmethod_0().Padding = new Padding(5);
			this.vmethod_0().Size = new Size(231, 21);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().method_1("EMCON Window (Ctrl + F9)");
			this.vmethod_2().Location = new Point(0, 21);
			this.vmethod_2().Name = "Button2";
			this.vmethod_2().Padding = new Padding(5);
			this.vmethod_2().Size = new Size(231, 21);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().method_1("Sensors Window (F9)");
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().Location = new Point(3, 43);
			this.vmethod_4().Name = "CB_EMCON_Inherits";
			this.vmethod_4().Size = new Size(111, 17);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Inherit from parent";
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_6().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_6().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_6().FormattingEnabled = true;
			this.vmethod_6().Location = new Point(111, 0);
			this.vmethod_6().Margin = new Padding(0, 0, 3, 3);
			this.vmethod_6().Name = "CB_EMCON_Radar";
			this.vmethod_6().Size = new Size(118, 21);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_8().ColumnCount = 2;
			this.vmethod_8().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111f));
			this.vmethod_8().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121f));
			this.vmethod_8().Controls.Add(this.vmethod_6(), 1, 0);
			this.vmethod_8().Controls.Add(this.vmethod_10(), 1, 1);
			this.vmethod_8().Controls.Add(this.vmethod_12(), 1, 2);
			this.vmethod_8().Controls.Add(this.vmethod_14(), 0, 0);
			this.vmethod_8().Controls.Add(this.vmethod_16(), 0, 1);
			this.vmethod_8().Controls.Add(this.vmethod_18(), 0, 2);
			this.vmethod_8().Location = new Point(0, 62);
			this.vmethod_8().Margin = new Padding(0);
			this.vmethod_8().Name = "TableLayoutPanel1";
			this.vmethod_8().RowCount = 4;
			this.vmethod_8().RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
			this.vmethod_8().RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
			this.vmethod_8().RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
			this.vmethod_8().RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
			this.vmethod_8().Size = new Size(232, 67);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_10().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_10().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_10().FormattingEnabled = true;
			this.vmethod_10().Location = new Point(111, 22);
			this.vmethod_10().Margin = new Padding(0, 0, 3, 3);
			this.vmethod_10().Name = "CB_EMCON_OECM";
			this.vmethod_10().Size = new Size(118, 21);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_12().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_12().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_12().FormattingEnabled = true;
			this.vmethod_12().Location = new Point(111, 44);
			this.vmethod_12().Margin = new Padding(0, 0, 3, 3);
			this.vmethod_12().Name = "CB_EMCON_Sonar";
			this.vmethod_12().Size = new Size(118, 21);
			this.vmethod_12().TabIndex = 5;
			this.vmethod_14().method_2(true);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(0, 0);
			this.vmethod_14().Margin = new Padding(0, 0, 3, 0);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Padding = new Padding(0, 6, 0, 0);
			this.vmethod_14().Size = new Size(39, 19);
			this.vmethod_14().TabIndex = 6;
			this.vmethod_14().Text = "Radar:";
			this.vmethod_16().method_2(true);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Location = new Point(0, 22);
			this.vmethod_16().Margin = new Padding(0, 0, 3, 0);
			this.vmethod_16().Name = "Label2";
			this.vmethod_16().Padding = new Padding(0, 6, 0, 0);
			this.vmethod_16().Size = new Size(41, 19);
			this.vmethod_16().TabIndex = 7;
			this.vmethod_16().Text = "OECM:";
			this.vmethod_18().method_2(true);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(0, 44);
			this.vmethod_18().Margin = new Padding(0, 0, 3, 0);
			this.vmethod_18().Name = "Label3";
			this.vmethod_18().Padding = new Padding(0, 6, 0, 0);
			this.vmethod_18().Size = new Size(38, 19);
			this.vmethod_18().TabIndex = 8;
			this.vmethod_18().Text = "Sonar:";
			base.AutoScaleMode = AutoScaleMode.None;
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.Margin = new Padding(0);
			base.Name = "EmconControl";
			base.Size = new Size(232, 142);
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_8().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x00046533 File Offset: 0x00044733
		[CompilerGenerated]
		internal Class111 vmethod_0()
		{
			return this.class111_0;
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x003C4A38 File Offset: 0x003C2C38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class111 class111_2)
		{
			EventHandler value = new EventHandler(this.method_5);
			Class111 @class = this.class111_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class111_0 = class111_2;
			@class = this.class111_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x0004653B File Offset: 0x0004473B
		[CompilerGenerated]
		internal Class111 vmethod_2()
		{
			return this.class111_1;
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x003C4A7C File Offset: 0x003C2C7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class111 class111_2)
		{
			EventHandler value = new EventHandler(this.method_6);
			Class111 @class = this.class111_1;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class111_1 = class111_2;
			@class = this.class111_1;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x00046543 File Offset: 0x00044743
		[CompilerGenerated]
		internal Class112 vmethod_4()
		{
			return this.class112_0;
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x003C4AC0 File Offset: 0x003C2CC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class112 class112_1)
		{
			EventHandler value = new EventHandler(this.method_10);
			MouseEventHandler value2 = new MouseEventHandler(this.method_11);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
				@class.MouseUp -= value2;
			}
			this.class112_0 = class112_1;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged += value;
				@class.MouseUp += value2;
			}
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x0004654B File Offset: 0x0004474B
		[CompilerGenerated]
		internal Class2451 vmethod_6()
		{
			return this.class2451_0;
		}

		// Token: 0x06006FA4 RID: 28580 RVA: 0x003C4B20 File Offset: 0x003C2D20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class2451 class2451_3)
		{
			EventHandler value = new EventHandler(this.method_7);
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

		// Token: 0x06006FA5 RID: 28581 RVA: 0x00046553 File Offset: 0x00044753
		[CompilerGenerated]
		internal TableLayoutPanel vmethod_8()
		{
			return this.tableLayoutPanel_0;
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x0004655B File Offset: 0x0004475B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TableLayoutPanel tableLayoutPanel_1)
		{
			this.tableLayoutPanel_0 = tableLayoutPanel_1;
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x00046564 File Offset: 0x00044764
		[CompilerGenerated]
		internal Class2451 vmethod_10()
		{
			return this.class2451_1;
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x003C4B64 File Offset: 0x003C2D64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class2451 class2451_3)
		{
			EventHandler value = new EventHandler(this.method_8);
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

		// Token: 0x06006FA9 RID: 28585 RVA: 0x0004656C File Offset: 0x0004476C
		[CompilerGenerated]
		internal Class2451 vmethod_12()
		{
			return this.class2451_2;
		}

		// Token: 0x06006FAA RID: 28586 RVA: 0x003C4BA8 File Offset: 0x003C2DA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class2451 class2451_3)
		{
			EventHandler value = new EventHandler(this.method_9);
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

		// Token: 0x06006FAB RID: 28587 RVA: 0x00046574 File Offset: 0x00044774
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_0;
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x0004657C File Offset: 0x0004477C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_3)
		{
			this.class116_0 = class116_3;
		}

		// Token: 0x06006FAD RID: 28589 RVA: 0x00046585 File Offset: 0x00044785
		[CompilerGenerated]
		internal Class116 vmethod_16()
		{
			return this.class116_1;
		}

		// Token: 0x06006FAE RID: 28590 RVA: 0x0004658D File Offset: 0x0004478D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class116 class116_3)
		{
			this.class116_1 = class116_3;
		}

		// Token: 0x06006FAF RID: 28591 RVA: 0x00046596 File Offset: 0x00044796
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_2;
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x0004659E File Offset: 0x0004479E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_3)
		{
			this.class116_2 = class116_3;
		}

		// Token: 0x06006FB1 RID: 28593 RVA: 0x003C4BEC File Offset: 0x003C2DEC
		[CompilerGenerated]
		public static void smethod_0(EmconControl.Delegate89 delegate89_1)
		{
			EmconControl.Delegate89 @delegate = EmconControl.delegate89_0;
			EmconControl.Delegate89 delegate2;
			do
			{
				delegate2 = @delegate;
				EmconControl.Delegate89 value = (EmconControl.Delegate89)Delegate.Combine(delegate2, delegate89_1);
				@delegate = Interlocked.CompareExchange<EmconControl.Delegate89>(ref EmconControl.delegate89_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06006FB2 RID: 28594 RVA: 0x000465A7 File Offset: 0x000447A7
		private void EmconControl_Load(object sender, EventArgs e)
		{
			Doctrine.smethod_2(new Doctrine.Delegate29(this.method_1));
			Client.smethod_14(new Client.Delegate78(this.method_2));
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06006FB3 RID: 28595 RVA: 0x003C4C20 File Offset: 0x003C2E20
		private void method_1(Class310 class310_1, bool? nullable_0, bool bool_3, bool bool_4, bool bool_5, bool bool_6)
		{
			checked
			{
				if (!bool_5 && !bool_6 && !Information.IsNothing(class310_1) && class310_1.bool_0 && (!bool_3 || class310_1 == Client.smethod_54()) && this.bool_1 && !Information.IsNothing(nullable_0) && base.Parent.GetType() == typeof(Class711) && ((Class711)base.Parent).method_2() == Enum165.const_0)
				{
					Form[] ownedForms = Class2413.smethod_2().method_41().OwnedForms;
					for (int i = 0; i < ownedForms.Length; i++)
					{
						if (ownedForms[i].GetType() == typeof(DoctrineForm))
						{
							Class2413.smethod_2().method_41().method_97().method_3(Client.smethod_54(), Client.smethod_54());
							return;
						}
					}
				}
			}
		}

		// Token: 0x06006FB4 RID: 28596 RVA: 0x000465DE File Offset: 0x000447DE
		private void method_2(Unit unit_0)
		{
			this.class310_0 = unit_0;
			this.bool_0 = true;
		}

		// Token: 0x06006FB5 RID: 28597 RVA: 0x003C4CF8 File Offset: 0x003C2EF8
		private Doctrine method_3()
		{
			if (Information.IsNothing(this.class310_0))
			{
				this.class310_0 = Client.smethod_54();
				if (Information.IsNothing(this.class310_0))
				{
					this.bool_2 = false;
					return null;
				}
			}
			Doctrine result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_2 = false;
				result = ((Side)this.class310_0).doctrine_0;
			}
			else if (this.class310_0.bool_9)
			{
				this.bool_2 = false;
				result = ((Mission)this.class310_0).doctrine_0;
			}
			else if (this.class310_0.bool_1)
			{
				Group group = (Group)Client.smethod_54();
				if (!Information.IsNothing(group.method_147()))
				{
					this.bool_2 = group.method_147().vmethod_86().bool_2;
				}
				else
				{
					this.bool_2 = false;
				}
				result = ((Group)this.class310_0).doctrine_0;
			}
			else if (this.class310_0.bool_0)
			{
				this.bool_2 = ((ActiveUnit)Client.smethod_54()).vmethod_86().bool_2;
				result = ((ActiveUnit)this.class310_0).doctrine_0;
			}
			else
			{
				this.bool_2 = false;
				result = null;
			}
			return result;
		}

		// Token: 0x06006FB6 RID: 28598 RVA: 0x003C4E34 File Offset: 0x003C3034
		public void method_4(bool bool_3)
		{
			if (!Information.IsNothing(Client.smethod_54()) && !Information.IsNothing(this.method_3()))
			{
				if (Client.float_1 != 1f)
				{
					if (this.int_0 == 0)
					{
						this.int_0 = base.Width;
					}
					if (this.int_0 == base.Width)
					{
						base.Width = (int)Math.Round((double)((float)base.Width * Client.float_1));
					}
				}
				base.Enabled = (Client.smethod_54().vmethod_7(false) == Client.smethod_50());
				this.vmethod_0().Visible = !Information.IsNothing(this.class310_0);
				this.vmethod_2().Visible = !Information.IsNothing(this.class310_0);
				if (bool_3)
				{
					Doctrine doctrine = this.method_3();
					CheckBox checkBox_ = this.vmethod_4();
					Doctrine doctrine2 = this.method_3();
					doctrine.method_340(checkBox_, ref this.class310_0, ref doctrine2);
					Doctrine doctrine3 = this.method_3();
					ComboBox comboBox_ = this.vmethod_6();
					Scenario scenario = Client.smethod_46();
					doctrine2 = this.method_3();
					doctrine3.method_337(comboBox_, ref scenario, ref doctrine2);
					Doctrine doctrine4 = this.method_3();
					ComboBox comboBox_2 = this.vmethod_10();
					scenario = Client.smethod_46();
					doctrine2 = this.method_3();
					doctrine4.method_338(comboBox_2, ref scenario, ref doctrine2);
					Doctrine doctrine5 = this.method_3();
					ComboBox comboBox_3 = this.vmethod_12();
					scenario = Client.smethod_46();
					doctrine2 = this.method_3();
					doctrine5.method_339(comboBox_3, ref scenario, ref doctrine2);
				}
				this.bool_0 = false;
			}
		}

		// Token: 0x06006FB7 RID: 28599 RVA: 0x000465EE File Offset: 0x000447EE
		private void EmconControl_VisibleChanged(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.method_4(false);
			}
			Class2475.smethod_0();
		}

		// Token: 0x06006FB8 RID: 28600 RVA: 0x00046604 File Offset: 0x00044804
		private void method_5(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.class310_0))
			{
				DoctrineForm doctrineForm = new DoctrineForm();
				doctrineForm.class310_0 = this.class310_0;
				doctrineForm.bool_8 = this.bool_2;
				doctrineForm.Show();
				doctrineForm.vmethod_0().SelectedIndex = 1;
			}
		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x003C4F88 File Offset: 0x003C3188
		private void method_6(object sender, EventArgs e)
		{
			EmconControl.Delegate89 @delegate = EmconControl.delegate89_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x003C4FA4 File Offset: 0x003C31A4
		private void method_7(object sender, EventArgs e)
		{
			ComboBox comboBox_ = this.vmethod_6();
			Scenario scenario = Client.smethod_46();
			Doctrine doctrine = this.method_3();
			bool bool_ = false;
			bool flag = true;
			EmconControl.smethod_1(comboBox_, ref scenario, ref doctrine, bool_, ref flag, ref this.bool_2, false, true);
			Class2413.smethod_2().method_41().vmethod_796().Focus();
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x003C5000 File Offset: 0x003C3200
		private void method_8(object sender, EventArgs e)
		{
			ComboBox comboBox_ = this.vmethod_10();
			Scenario scenario = Client.smethod_46();
			Doctrine doctrine = this.method_3();
			bool bool_ = false;
			bool flag = true;
			EmconControl.smethod_2(comboBox_, ref scenario, ref doctrine, bool_, ref flag, ref this.bool_2, false, true);
			Class2413.smethod_2().method_41().vmethod_796().Focus();
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x003C505C File Offset: 0x003C325C
		private void method_9(object sender, EventArgs e)
		{
			ComboBox comboBox_ = this.vmethod_12();
			Scenario scenario = Client.smethod_46();
			Doctrine doctrine = this.method_3();
			bool bool_ = false;
			bool flag = true;
			EmconControl.smethod_3(comboBox_, ref scenario, ref doctrine, bool_, ref flag, ref this.bool_2, false, true);
			Class2413.smethod_2().method_41().vmethod_796().Focus();
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x003C50B8 File Offset: 0x003C32B8
		private void method_10(object sender, EventArgs e)
		{
			Doctrine doctrine = this.method_3();
			CheckBox checkBox_ = this.vmethod_4();
			ComboBox comboBox_ = this.vmethod_6();
			ComboBox comboBox_2 = this.vmethod_10();
			ComboBox comboBox_3 = this.vmethod_12();
			Doctrine doctrine2 = this.method_3();
			doctrine.method_341(checkBox_, comboBox_, comboBox_2, comboBox_3, ref doctrine2, Client.smethod_46(), false, true);
			Doctrine doctrine3 = this.method_3();
			ComboBox comboBox_4 = this.vmethod_6();
			Scenario scenario = Client.smethod_46();
			doctrine2 = this.method_3();
			doctrine3.method_337(comboBox_4, ref scenario, ref doctrine2);
			Doctrine doctrine4 = this.method_3();
			ComboBox comboBox_5 = this.vmethod_10();
			scenario = Client.smethod_46();
			doctrine2 = this.method_3();
			doctrine4.method_338(comboBox_5, ref scenario, ref doctrine2);
			Doctrine doctrine5 = this.method_3();
			ComboBox comboBox_6 = this.vmethod_12();
			scenario = Client.smethod_46();
			doctrine2 = this.method_3();
			doctrine5.method_339(comboBox_6, ref scenario, ref doctrine2);
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x003C5160 File Offset: 0x003C3360
		private void method_11(object sender, MouseEventArgs e)
		{
			Doctrine doctrine = this.method_3();
			Side side_ = Client.smethod_50();
			Scenario scenario = Client.smethod_46();
			doctrine.method_342(ref side_, ref scenario, ref this.bool_2);
			Client.smethod_51(side_);
			this.bool_1 = false;
			this.method_3().method_2(this.class310_0, new bool?(false), false, false, true, false);
			this.bool_1 = true;
			Client.bool_1 = true;
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x003C51C4 File Offset: 0x003C33C4
		public static void smethod_1(ComboBox comboBox_0, ref Scenario scenario_0, ref Doctrine doctrine_0, bool bool_3, ref bool bool_4, ref bool bool_5, bool bool_6, bool bool_7)
		{
			doctrine_0.method_192(Doctrine.Class275.smethod_0(comboBox_0.SelectedIndex), scenario_0);
			if (!Information.IsNothing(doctrine_0.list_0))
			{
				try
				{
					foreach (ActiveUnit activeUnit in doctrine_0.list_0)
					{
						activeUnit.doctrine_0.method_192((Doctrine.Class275.Enum66)comboBox_0.SelectedIndex, scenario_0);
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (bool_4)
			{
				EmconControl.smethod_4(ref scenario_0, ref doctrine_0, ref bool_5, bool_6, bool_7);
			}
			Doctrine.smethod_4(doctrine_0.class310_0, new bool?(false), bool_3, bool_6, bool_7, false);
		}

		// Token: 0x06006FC0 RID: 28608 RVA: 0x003C5270 File Offset: 0x003C3470
		public static void smethod_2(ComboBox comboBox_0, ref Scenario scenario_0, ref Doctrine doctrine_0, bool bool_3, ref bool bool_4, ref bool bool_5, bool bool_6, bool bool_7)
		{
			doctrine_0.method_194(Doctrine.Class275.smethod_0(comboBox_0.SelectedIndex), scenario_0);
			if (!Information.IsNothing(doctrine_0.list_0))
			{
				try
				{
					foreach (ActiveUnit activeUnit in doctrine_0.list_0)
					{
						activeUnit.doctrine_0.method_194((Doctrine.Class275.Enum66)comboBox_0.SelectedIndex, scenario_0);
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (bool_4)
			{
				EmconControl.smethod_4(ref scenario_0, ref doctrine_0, ref bool_5, bool_6, bool_7);
			}
			Doctrine.smethod_4(doctrine_0.class310_0, new bool?(false), bool_3, bool_6, bool_7, false);
		}

		// Token: 0x06006FC1 RID: 28609 RVA: 0x003C531C File Offset: 0x003C351C
		public static void smethod_3(ComboBox comboBox_0, ref Scenario scenario_0, ref Doctrine doctrine_0, bool bool_3, ref bool bool_4, ref bool bool_5, bool bool_6, bool bool_7)
		{
			doctrine_0.method_193(Doctrine.Class275.smethod_0(comboBox_0.SelectedIndex), scenario_0);
			if (!Information.IsNothing(doctrine_0.list_0))
			{
				try
				{
					foreach (ActiveUnit activeUnit in doctrine_0.list_0)
					{
						activeUnit.doctrine_0.method_193((Doctrine.Class275.Enum66)comboBox_0.SelectedIndex, scenario_0);
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (bool_4)
			{
				EmconControl.smethod_4(ref scenario_0, ref doctrine_0, ref bool_5, bool_6, bool_7);
			}
			Doctrine.smethod_4(doctrine_0.class310_0, new bool?(false), bool_3, bool_6, bool_7, false);
		}

		// Token: 0x06006FC2 RID: 28610 RVA: 0x003C53C8 File Offset: 0x003C35C8
		public static void smethod_4(ref Scenario scenario_0, ref Doctrine doctrine_0, ref bool bool_3, bool bool_4, bool bool_5)
		{
			if (doctrine_0.class310_0.GetType() != typeof(Waypoint))
			{
				if (DarkMessageBox.smethod_0("Enforce EMCON obedience on all affected units? \r\n\r\nYes: Manual sensor settings for affected missions, groups and/or units will be reset to use the above EMCON settings.\r\nNo: Affected units retain customized EMCON (if any) and will not use the specified EMCON settings.", "EMCON obedience", Enum11.const_3) == DialogResult.Yes)
				{
					if (!Information.IsNothing(doctrine_0.list_0))
					{
						try
						{
							foreach (ActiveUnit activeUnit in doctrine_0.list_0)
							{
								try
								{
									foreach (ActiveUnit activeUnit2 in activeUnit.doctrine_0.method_5(scenario_0, new bool?(bool_3)))
									{
										activeUnit2.vmethod_88().vmethod_4(true);
									}
								}
								finally
								{
									List<ActiveUnit>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
							}
							goto IL_1E1;
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					try
					{
						foreach (ActiveUnit activeUnit3 in doctrine_0.method_5(scenario_0, new bool?(bool_3)))
						{
							activeUnit3.vmethod_88().vmethod_4(true);
						}
						goto IL_1E1;
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				if (!Information.IsNothing(doctrine_0.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in doctrine_0.list_0)
						{
							try
							{
								foreach (ActiveUnit activeUnit5 in activeUnit4.doctrine_0.method_5(scenario_0, new bool?(bool_3)))
								{
									activeUnit5.vmethod_88().vmethod_5(activeUnit4.method_78());
								}
							}
							finally
							{
								List<ActiveUnit>.Enumerator enumerator5;
								((IDisposable)enumerator5).Dispose();
							}
						}
						goto IL_1E1;
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				try
				{
					foreach (ActiveUnit activeUnit6 in doctrine_0.method_5(scenario_0, new bool?(bool_3)))
					{
						activeUnit6.vmethod_88().vmethod_5(activeUnit6.method_78());
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
				IL_1E1:
				if (!Information.IsNothing(doctrine_0.list_0))
				{
					try
					{
						foreach (ActiveUnit class310_ in doctrine_0.list_0)
						{
							Doctrine.smethod_4(class310_, new bool?(false), true, bool_4, bool_5, false);
						}
						return;
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator7;
						((IDisposable)enumerator7).Dispose();
					}
				}
				Doctrine.smethod_4(doctrine_0.class310_0, new bool?(false), false, bool_4, bool_5, false);
			}
		}

		// Token: 0x04003F3E RID: 16190
		private IContainer icontainer_1;

		// Token: 0x04003F3F RID: 16191
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Class111 class111_0;

		// Token: 0x04003F40 RID: 16192
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Class111 class111_1;

		// Token: 0x04003F41 RID: 16193
		[CompilerGenerated]
		[AccessedThroughProperty("CB_EMCON_Inherits")]
		private Class112 class112_0;

		// Token: 0x04003F42 RID: 16194
		[AccessedThroughProperty("CB_EMCON_Radar")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04003F43 RID: 16195
		[AccessedThroughProperty("TableLayoutPanel1")]
		[CompilerGenerated]
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x04003F44 RID: 16196
		[AccessedThroughProperty("CB_EMCON_OECM")]
		[CompilerGenerated]
		private Class2451 class2451_1;

		// Token: 0x04003F45 RID: 16197
		[AccessedThroughProperty("CB_EMCON_Sonar")]
		[CompilerGenerated]
		private Class2451 class2451_2;

		// Token: 0x04003F46 RID: 16198
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04003F47 RID: 16199
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_1;

		// Token: 0x04003F48 RID: 16200
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_2;

		// Token: 0x04003F49 RID: 16201
		private Class310 class310_0;

		// Token: 0x04003F4A RID: 16202
		private bool bool_0;

		// Token: 0x04003F4B RID: 16203
		private bool bool_1;

		// Token: 0x04003F4C RID: 16204
		private bool bool_2;

		// Token: 0x04003F4D RID: 16205
		private int int_0;

		// Token: 0x04003F4E RID: 16206
		[CompilerGenerated]
		private static EmconControl.Delegate89 delegate89_0;

		// Token: 0x02000E5E RID: 3678
		// (Invoke) Token: 0x06006FC6 RID: 28614
		internal delegate void Delegate89();
	}
}
