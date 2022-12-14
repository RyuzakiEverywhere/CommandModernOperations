using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns5;

namespace ns4
{
	// Token: 0x02000E5A RID: 3674
	[DesignerGenerated]
	internal sealed class AreaEditor : Control7, Interface66
	{
		// Token: 0x06006F77 RID: 28535 RVA: 0x000464A4 File Offset: 0x000446A4
		public AreaEditor()
		{
			base.Load += this.AreaEditor_Load;
			this.InitializeComponent();
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x003C346C File Offset: 0x003C166C
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

		// Token: 0x06006F79 RID: 28537 RVA: 0x003C34AC File Offset: 0x003C16AC
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AreaEditor));
			this.vmethod_1(new Class115());
			this.vmethod_15(new Control9());
			this.vmethod_13(new Control9());
			this.vmethod_11(new Control9());
			this.vmethod_9(new Class111());
			this.vmethod_7(new Class111());
			this.vmethod_5(new Control9());
			this.vmethod_3(new Control4());
			this.vmethod_0().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Controls.Add(this.vmethod_14());
			this.vmethod_0().Controls.Add(this.vmethod_12());
			this.vmethod_0().Controls.Add(this.vmethod_10());
			this.vmethod_0().Controls.Add(this.vmethod_8());
			this.vmethod_0().Controls.Add(this.vmethod_6());
			this.vmethod_0().Controls.Add(this.vmethod_4());
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Dock = DockStyle.Fill;
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "GroupBox1";
			this.vmethod_0().Size = new Size(351, 124);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().TabStop = false;
			this.vmethod_0().Text = "Title";
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().DialogResult = DialogResult.None;
			this.vmethod_14().Font = new Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_14().ForeColor = SystemColors.Control;
			this.vmethod_14().Location = new Point(223, 99);
			this.vmethod_14().Name = "Button_ValidateArea";
			this.vmethod_14().method_1(0);
			this.vmethod_14().Size = new Size(125, 22);
			this.vmethod_14().TabIndex = 6;
			this.vmethod_14().Text = "Validate Area";
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(223, 65);
			this.vmethod_12().Name = "Button_HighLightCenterOnSelected";
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(125, 34);
			this.vmethod_12().TabIndex = 5;
			this.vmethod_12().Text = "Highlight + center on selected point";
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DialogResult = DialogResult.None;
			this.vmethod_10().Font = new Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_10().ForeColor = SystemColors.Control;
			this.vmethod_10().Location = new Point(223, 43);
			this.vmethod_10().Name = "Button_RemoveSelected";
			this.vmethod_10().method_1(0);
			this.vmethod_10().Size = new Size(125, 22);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_10().Text = "Remove selected points";
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().BackgroundImage = (Image)componentResourceManager.GetObject("Button_ListDown.BackgroundImage");
			this.vmethod_8().Font = new Font("Segoe UI", 10f);
			this.vmethod_8().Image = (Image)componentResourceManager.GetObject("Button_ListDown.Image");
			this.vmethod_8().Location = new Point(178, 49);
			this.vmethod_8().Name = "Button_ListDown";
			this.vmethod_8().Padding = new Padding(5);
			this.vmethod_8().Size = new Size(27, 24);
			this.vmethod_8().TabIndex = 3;
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().BackgroundImage = (Image)componentResourceManager.GetObject("Button_ListUp.BackgroundImage");
			this.vmethod_6().Font = new Font("Segoe UI", 10f);
			this.vmethod_6().Image = (Image)componentResourceManager.GetObject("Button_ListUp.Image");
			this.vmethod_6().Location = new Point(178, 19);
			this.vmethod_6().Name = "Button_ListUp";
			this.vmethod_6().Padding = new Padding(5);
			this.vmethod_6().Size = new Size(27, 24);
			this.vmethod_6().TabIndex = 2;
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().Font = new Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(223, 8);
			this.vmethod_4().Name = "Button_AddHighlighted";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(125, 35);
			this.vmethod_4().TabIndex = 1;
			this.vmethod_4().Text = "Add points currently highlighted on map";
			this.vmethod_2().Location = new Point(6, 19);
			this.vmethod_2().method_25(true);
			this.vmethod_2().Name = "ListBox1";
			this.vmethod_2().Size = new Size(166, 95);
			this.vmethod_2().TabIndex = 0;
			base.AutoScaleMode = AutoScaleMode.None;
			base.Controls.Add(this.vmethod_0());
			base.Name = "AreaEditor";
			base.Size = new Size(351, 124);
			this.vmethod_0().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x06006F7A RID: 28538 RVA: 0x000464C4 File Offset: 0x000446C4
		[CompilerGenerated]
		internal Class115 vmethod_0()
		{
			return this.class115_0;
		}

		// Token: 0x06006F7B RID: 28539 RVA: 0x000464CC File Offset: 0x000446CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class115 class115_1)
		{
			this.class115_0 = class115_1;
		}

		// Token: 0x06006F7C RID: 28540 RVA: 0x000464D5 File Offset: 0x000446D5
		[CompilerGenerated]
		internal Control4 vmethod_2()
		{
			return this.control4_0;
		}

		// Token: 0x06006F7D RID: 28541 RVA: 0x000464DD File Offset: 0x000446DD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control4 control4_1)
		{
			this.control4_0 = control4_1;
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x000464E6 File Offset: 0x000446E6
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_0;
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x003C3B24 File Offset: 0x003C1D24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_4;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x000464EE File Offset: 0x000446EE
		[CompilerGenerated]
		internal Class111 vmethod_6()
		{
			return this.class111_0;
		}

		// Token: 0x06006F81 RID: 28545 RVA: 0x003C3B68 File Offset: 0x003C1D68
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class111 class111_2)
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

		// Token: 0x06006F82 RID: 28546 RVA: 0x000464F6 File Offset: 0x000446F6
		[CompilerGenerated]
		internal Class111 vmethod_8()
		{
			return this.class111_1;
		}

		// Token: 0x06006F83 RID: 28547 RVA: 0x003C3BAC File Offset: 0x003C1DAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class111 class111_2)
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

		// Token: 0x06006F84 RID: 28548 RVA: 0x000464FE File Offset: 0x000446FE
		[CompilerGenerated]
		internal Control9 vmethod_10()
		{
			return this.control9_1;
		}

		// Token: 0x06006F85 RID: 28549 RVA: 0x003C3BF0 File Offset: 0x003C1DF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_4;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006F86 RID: 28550 RVA: 0x00046506 File Offset: 0x00044706
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_2;
		}

		// Token: 0x06006F87 RID: 28551 RVA: 0x003C3C34 File Offset: 0x003C1E34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_7);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_4;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006F88 RID: 28552 RVA: 0x0004650E File Offset: 0x0004470E
		[CompilerGenerated]
		internal Control9 vmethod_14()
		{
			return this.control9_3;
		}

		// Token: 0x06006F89 RID: 28553 RVA: 0x003C3C78 File Offset: 0x003C1E78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_8);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_4;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006F8A RID: 28554 RVA: 0x00046516 File Offset: 0x00044716
		public void method_1(string string_1)
		{
			this.string_0 = string_1;
			this.vmethod_0().Text = string_1;
		}

		// Token: 0x06006F8B RID: 28555 RVA: 0x0004652B File Offset: 0x0004472B
		public void imethod_0()
		{
			this.method_2();
		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x003C3CBC File Offset: 0x003C1EBC
		private void method_2()
		{
			if (!Information.IsNothing(this.list_0))
			{
				this.vmethod_2().method_18().Clear();
				try
				{
					foreach (ReferencePoint referencePoint in this.list_0)
					{
						Class117 @class = new Class117(referencePoint.Name);
						@class.Tag = referencePoint;
						this.vmethod_2().method_18().Add(@class);
					}
				}
				finally
				{
					List<ReferencePoint>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06006F8D RID: 28557 RVA: 0x003C3D4C File Offset: 0x003C1F4C
		private void method_3(object sender, EventArgs e)
		{
			try
			{
				foreach (ReferencePoint referencePoint in Client.smethod_50().vmethod_12())
				{
					if (referencePoint.method_19() && !Information.IsNothing(this.list_0) && !this.list_0.Contains(referencePoint))
					{
						Class117 @class = new Class117(referencePoint.Name);
						this.list_0.Add(referencePoint);
						@class.Tag = referencePoint;
						this.vmethod_2().method_18().Add(@class);
					}
				}
			}
			finally
			{
				List<ReferencePoint>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			Client.bool_1 = true;
		}

		// Token: 0x06006F8E RID: 28558 RVA: 0x003C3DF8 File Offset: 0x003C1FF8
		private void method_4(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.list_0))
			{
				try
				{
					foreach (Class117 @class in this.vmethod_2().method_21())
					{
						this.list_0.Remove((ReferencePoint)@class.Tag);
					}
				}
				finally
				{
					List<Class117>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.method_2();
				Client.bool_1 = true;
			}
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x003C3E7C File Offset: 0x003C207C
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_2().method_21().Count > 1)
			{
				DarkMessageBox.smethod_2("Only one reference point can be re-arranged at a time", "One point a time!", Enum11.const_0);
				return;
			}
			if (this.vmethod_2().method_20().Count != 0)
			{
				int num = this.vmethod_2().method_20()[0];
				if (num != -1 && num > 0)
				{
					Class117 item = this.vmethod_2().method_18()[num];
					ReferencePoint item2 = this.list_0[num];
					this.vmethod_2().method_18().RemoveAt(num);
					this.list_0.RemoveAt(num);
					num--;
					this.list_0.Insert(num, item2);
					this.vmethod_2().method_18().Insert(num, item);
					this.vmethod_2().method_29(num);
					Client.bool_1 = true;
				}
			}
		}

		// Token: 0x06006F90 RID: 28560 RVA: 0x003C3F50 File Offset: 0x003C2150
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_2().method_21().Count > 1)
			{
				DarkMessageBox.smethod_2("Only one reference point can be re-arranged at a time", "One point a time!", Enum11.const_0);
				return;
			}
			if (this.vmethod_2().method_20().Count != 0)
			{
				int num = this.vmethod_2().method_20()[0];
				if (num != -1 && num < this.vmethod_2().method_18().Count - 1)
				{
					Class117 item = this.vmethod_2().method_18()[num];
					ReferencePoint item2 = this.list_0[num];
					this.vmethod_2().method_18().RemoveAt(num);
					this.list_0.RemoveAt(num);
					num++;
					this.list_0.Insert(num, item2);
					this.vmethod_2().method_18().Insert(num, item);
					this.vmethod_2().method_29(num);
					Client.bool_1 = true;
				}
			}
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x003C4038 File Offset: 0x003C2238
		private void method_7(object sender, EventArgs e)
		{
			List<ReferencePoint> list = new List<ReferencePoint>();
			if (!Information.IsNothing(this.list_0))
			{
				try
				{
					foreach (Class117 @class in this.vmethod_2().method_21())
					{
						list.Add((ReferencePoint)@class.Tag);
					}
				}
				finally
				{
					List<Class117>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				int count = list.Count;
				if (count != 0)
				{
					if (count == 1)
					{
						Class2413.smethod_2().method_41().method_161(true, list[0]);
					}
					else
					{
						GeoPoint value = Misc.smethod_48(list).method_1();
						Class2413.smethod_2().method_41().method_161(true, value);
					}
					try
					{
						foreach (ReferencePoint referencePoint in list)
						{
							referencePoint.method_20(true);
						}
					}
					finally
					{
						List<ReferencePoint>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					Client.bool_1 = true;
				}
			}
		}

		// Token: 0x06006F92 RID: 28562 RVA: 0x003C4140 File Offset: 0x003C2340
		private void method_8(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.list_0))
			{
				string message;
				if (!ActiveUnit_Navigator.smethod_7(ref this.list_0, ref message, null, Client.smethod_46(), ""))
				{
					DarkMessageBox.smethod_1(message, "", Enum11.const_0);
					return;
				}
				DarkMessageBox.smethod_0("Area validation OK.", "", Enum11.const_0);
			}
		}

		// Token: 0x06006F93 RID: 28563 RVA: 0x00044489 File Offset: 0x00042689
		private void AreaEditor_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04003F32 RID: 16178
		private IContainer icontainer_1;

		// Token: 0x04003F33 RID: 16179
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox1")]
		private Class115 class115_0;

		// Token: 0x04003F34 RID: 16180
		[CompilerGenerated]
		[AccessedThroughProperty("ListBox1")]
		private Control4 control4_0;

		// Token: 0x04003F35 RID: 16181
		[CompilerGenerated]
		[AccessedThroughProperty("Button_AddHighlighted")]
		private Control9 control9_0;

		// Token: 0x04003F36 RID: 16182
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ListUp")]
		private Class111 class111_0;

		// Token: 0x04003F37 RID: 16183
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ListDown")]
		private Class111 class111_1;

		// Token: 0x04003F38 RID: 16184
		[CompilerGenerated]
		[AccessedThroughProperty("Button_RemoveSelected")]
		private Control9 control9_1;

		// Token: 0x04003F39 RID: 16185
		[CompilerGenerated]
		[AccessedThroughProperty("Button_HighLightCenterOnSelected")]
		private Control9 control9_2;

		// Token: 0x04003F3A RID: 16186
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ValidateArea")]
		private Control9 control9_3;

		// Token: 0x04003F3B RID: 16187
		public List<ReferencePoint> list_0;

		// Token: 0x04003F3C RID: 16188
		private string string_0;
	}
}
