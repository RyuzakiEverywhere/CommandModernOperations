using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns5;
using ns7;

namespace ns4
{
	// Token: 0x02000DD0 RID: 3536
	[DesignerGenerated]
	internal partial class DarkSecondaryFormBase : Form0
	{
		// Token: 0x06006638 RID: 26168 RVA: 0x0004090F File Offset: 0x0003EB0F
		public DarkSecondaryFormBase()
		{
			base.Activated += this.DarkSecondaryFormBase_Activated;
			this.bool_1 = true;
			this.bool_2 = true;
			this.InitializeComponent();
		}

		// Token: 0x0600663B RID: 26171 RVA: 0x003853B0 File Offset: 0x003835B0
		protected override void OnMove(EventArgs e)
		{
			base.OnMove(e);
			if (base.Visible)
			{
				Class2566.smethod_0(base.Name, base.Location.X, base.Location.Y, base.Width, base.Height);
			}
		}

		// Token: 0x0600663C RID: 26172 RVA: 0x00385400 File Offset: 0x00383600
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			if (base.Visible)
			{
				Class2566.smethod_0(base.Name, base.Location.X, base.Location.Y, base.Width, base.Height);
			}
		}

		// Token: 0x0600663D RID: 26173 RVA: 0x0004093D File Offset: 0x0003EB3D
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (base.Visible)
			{
				Class2566.smethod_2(this);
				if (!this.method_1(base.Location, base.Size, 0.1))
				{
					base.CenterToScreen();
				}
			}
		}

		// Token: 0x0600663E RID: 26174 RVA: 0x00385450 File Offset: 0x00383650
		private bool method_1(Point RecLocation, Size RecSize, double MinPercentOnScreen = 0.1)
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

		// Token: 0x0600663F RID: 26175 RVA: 0x00040977 File Offset: 0x0003EB77
		private void DarkSecondaryFormBase_Activated(object sender, EventArgs e)
		{
			if (!Client.bool_6)
			{
				base.Owner = Class2413.smethod_2().method_41();
			}
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x003854DC File Offset: 0x003836DC
		public Color method_2(PlatformComponent platformComponent_0)
		{
			if (platformComponent_0.vmethod_5() == PlatformComponent._ComponentStatus.Damaged)
			{
				switch (platformComponent_0.method_16())
				{
				case PlatformComponent._DamageSeverityFactor.Light:
					return Color.Yellow;
				case PlatformComponent._DamageSeverityFactor.Medium:
					return Color.Orange;
				case PlatformComponent._DamageSeverityFactor.Heavy:
					return Color.OrangeRed;
				}
			}
			Color result;
			if (platformComponent_0.vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
			{
				result = Color.Red;
			}
			else
			{
				if (platformComponent_0.GetType() == typeof(AirFacility))
				{
					AirFacility airFacility = (AirFacility)platformComponent_0;
					if (airFacility.method_29() > airFacility.method_27())
					{
						return Color.Yellow;
					}
				}
				result = Color.LightGray;
			}
			return result;
		}

		// Token: 0x04003A56 RID: 14934
		internal bool bool_1;

		// Token: 0x04003A57 RID: 14935
		internal bool bool_2;
	}
}
