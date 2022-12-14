using System;
using System.Drawing;
using System.Windows.Forms;
using DarkUI.Docking;
using ns2;

namespace ns3
{
	// Token: 0x020000A6 RID: 166
	internal sealed class Class102 : IMessageFilter
	{
		// Token: 0x0600034B RID: 843 RVA: 0x00004F23 File Offset: 0x00003123
		public Class102(DarkDockPanel darkDockPanel_1)
		{
			this.darkDockPanel_0 = darkDockPanel_1;
			this.timer_0 = new Timer();
			this.timer_0.Interval = 1;
			this.timer_0.Tick += this.timer_0_Tick;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00061744 File Offset: 0x0005F944
		public bool PreFilterMessage(ref Message m)
		{
			if (m.Msg != 512 && m.Msg != 513 && m.Msg != 514 && m.Msg != 515 && m.Msg != 516 && m.Msg != 517 && m.Msg != 518)
			{
				return false;
			}
			if (m.Msg == 514 && this.bool_0)
			{
				this.method_1();
				return true;
			}
			if (m.Msg == 514 && !this.bool_0)
			{
				return false;
			}
			if (this.bool_0)
			{
				Cursor.Current = this.class107_0.method_2();
			}
			if (m.Msg == 512 && !this.bool_0 && this.darkDockPanel_0.method_9() != MouseButtons.None)
			{
				return false;
			}
			Control control = Control.FromHandle(m.HWnd);
			if (control == null)
			{
				return false;
			}
			if (control != this.darkDockPanel_0 && !this.darkDockPanel_0.Contains(control))
			{
				return false;
			}
			this.method_3();
			if (m.Msg == 513)
			{
				Class107 @class = this.method_2();
				if (@class != null)
				{
					this.method_0(@class);
					return true;
				}
			}
			return this.method_2() != null || this.bool_0;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00061884 File Offset: 0x0005FA84
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.darkDockPanel_0.method_9() != MouseButtons.Left)
			{
				this.method_1();
				return;
			}
			Point point = new Point(this.point_0.X - Cursor.Position.X, this.point_0.Y - Cursor.Position.Y);
			this.class107_0.method_6(point);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000618F0 File Offset: 0x0005FAF0
		private void method_0(Class107 class107_1)
		{
			this.class107_0 = class107_1;
			Cursor.Current = this.class107_0.method_2();
			this.point_0 = Cursor.Position;
			this.bool_0 = true;
			this.class107_0.method_4();
			this.timer_0.Start();
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0006193C File Offset: 0x0005FB3C
		private void method_1()
		{
			this.timer_0.Stop();
			this.class107_0.method_5();
			Point point = new Point(this.point_0.X - Cursor.Position.X, this.point_0.Y - Cursor.Position.Y);
			this.class107_0.method_7(point);
			this.bool_0 = false;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000619AC File Offset: 0x0005FBAC
		private Class107 method_2()
		{
			foreach (Class107 @class in this.darkDockPanel_0.method_7())
			{
				if (@class.method_0().Contains(Cursor.Position))
				{
					return @class;
				}
			}
			return null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00061A1C File Offset: 0x0005FC1C
		private void method_3()
		{
			if (this.bool_0)
			{
				return;
			}
			Class107 @class = this.method_2();
			if (@class != null)
			{
				Cursor.Current = @class.method_2();
			}
		}

		// Token: 0x040002BC RID: 700
		private DarkDockPanel darkDockPanel_0;

		// Token: 0x040002BD RID: 701
		private Timer timer_0;

		// Token: 0x040002BE RID: 702
		private bool bool_0;

		// Token: 0x040002BF RID: 703
		private Point point_0;

		// Token: 0x040002C0 RID: 704
		private Class107 class107_0;
	}
}
