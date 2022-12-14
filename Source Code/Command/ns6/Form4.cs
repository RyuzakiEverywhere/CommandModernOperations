using System;
using System.Drawing;
using System.Windows.Forms;
using Command;
using ns5;
using ns7;

namespace ns6
{
	// Token: 0x02000E9D RID: 3741
	internal partial class Form4 : Form
	{
		// Token: 0x0600753E RID: 30014 RVA: 0x003F4440 File Offset: 0x003F2640
		public Form4()
		{
			base.Activated += this.Form4_Activated;
			base.FormClosing += this.Form4_FormClosing;
			this.bool_0 = true;
			this.bool_1 = true;
			this.bool_2 = true;
		}

		// Token: 0x0600753F RID: 30015 RVA: 0x003853B0 File Offset: 0x003835B0
		protected override void OnMove(EventArgs e)
		{
			base.OnMove(e);
			if (base.Visible)
			{
				Class2566.smethod_0(base.Name, base.Location.X, base.Location.Y, base.Width, base.Height);
			}
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x00385400 File Offset: 0x00383600
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			if (base.Visible)
			{
				Class2566.smethod_0(base.Name, base.Location.X, base.Location.Y, base.Width, base.Height);
			}
		}

		// Token: 0x06007541 RID: 30017 RVA: 0x00048D65 File Offset: 0x00046F65
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (base.Visible)
			{
				Class2566.smethod_1(this);
				if (!this.method_0(base.Location, base.Size, 0.1))
				{
					base.CenterToScreen();
				}
			}
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x00040977 File Offset: 0x0003EB77
		private void Form4_Activated(object sender, EventArgs e)
		{
			if (!Client.bool_6)
			{
				base.Owner = Class2413.smethod_2().method_41();
			}
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x00385450 File Offset: 0x00383650
		private bool method_0(Point RecLocation, Size RecSize, double MinPercentOnScreen = 0.1)
		{
			double num = 0.0;
			Rectangle a = new Rectangle(RecLocation, RecSize);
			foreach (Screen screen in Screen.AllScreens)
			{
				Rectangle rectangle = Rectangle.Intersect(a, screen.WorkingArea);
				if (rectangle.Width != 0 & rectangle.Height != 0)
				{
					num += (double)(rectangle.Width * rectangle.Height);
				}
			}
			return num >= (double)(a.Width * a.Height) * MinPercentOnScreen;
		}

		// Token: 0x06007544 RID: 30020 RVA: 0x00044820 File Offset: 0x00042A20
		private void Form4_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x003F448C File Offset: 0x003F268C
		protected override void WndProc(ref Message m)
		{
			if (this.bool_2 && !this.Focused && m.Msg == 528)
			{
				int num = (int)(65535L & (long)m.WParam);
				if (num <= 516)
				{
					if (num - 1 <= 1)
					{
						goto IL_72;
					}
					if (num != 513 && num != 516)
					{
						goto IL_72;
					}
				}
				else if (num != 519 && num != 523 && num != 582)
				{
					goto IL_72;
				}
				base.Activate();
			}
			IL_72:
			base.WndProc(ref m);
		}

		// Token: 0x040041D7 RID: 16855
		internal bool bool_0;

		// Token: 0x040041D8 RID: 16856
		internal bool bool_1;

		// Token: 0x040041D9 RID: 16857
		protected bool bool_2;
	}
}
