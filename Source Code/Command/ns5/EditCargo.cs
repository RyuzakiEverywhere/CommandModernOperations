using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns4;

namespace ns5
{
	// Token: 0x02000DB5 RID: 3509
	[DesignerGenerated]
	internal sealed partial class EditCargo : DarkSecondaryFormBase
	{
		// Token: 0x06005EC1 RID: 24257 RVA: 0x0003D472 File Offset: 0x0003B672
		public EditCargo()
		{
			base.Load += this.EditCargo_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x06005EC3 RID: 24259 RVA: 0x00333A00 File Offset: 0x00331C00
		private void InitializeComponent_1()
		{
			this.vmethod_1(new ElementHost());
			this.editCargoControl_0 = new EditCargoControl();
			base.SuspendLayout();
			this.vmethod_0().Dock = DockStyle.Fill;
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "ElementHost1";
			this.vmethod_0().Size = new Size(746, 328);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "ElementHost1";
			this.vmethod_0().Child = this.editCargoControl_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(746, 328);
			base.Controls.Add(this.vmethod_0());
			base.Name = "EditCargo";
			this.Text = "EditCargo";
			base.ResumeLayout(false);
		}

		// Token: 0x06005EC4 RID: 24260 RVA: 0x0003D492 File Offset: 0x0003B692
		[CompilerGenerated]
		internal ElementHost vmethod_0()
		{
			return this.elementHost_0;
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x0003D49A File Offset: 0x0003B69A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ElementHost elementHost_1)
		{
			this.elementHost_0 = elementHost_1;
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x00333B00 File Offset: 0x00331D00
		private void EditCargo_Load(object sender, EventArgs e)
		{
			if (this.activeUnit_0 is Group)
			{
				DarkMessageBox.smethod_2("Please choose an individual unit, not a group.", "Error", Enum11.const_0);
				base.Close();
				return;
			}
			((EditCargoControl)this.vmethod_0().Child).DataContext = new EditCargoViewModel(this, (EditCargoControl)this.vmethod_0().Child, this.activeUnit_0);
		}

		// Token: 0x040036F9 RID: 14073
		[AccessedThroughProperty("ElementHost1")]
		[CompilerGenerated]
		private ElementHost elementHost_0;

		// Token: 0x040036FA RID: 14074
		internal EditCargoControl editCargoControl_0;

		// Token: 0x040036FB RID: 14075
		public ActiveUnit activeUnit_0;
	}
}
