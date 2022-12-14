namespace ns4
{
	// Token: 0x02000E23 RID: 3619
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	internal sealed partial class FlightPlanEditorWeaponRoute : global::ns6.Form4
	{
		// Token: 0x06006BBC RID: 27580 RVA: 0x003B09E8 File Offset: 0x003AEBE8
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x003B0A28 File Offset: 0x003AEC28
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Button());
			this.vmethod_3(new global::System.Windows.Forms.Button());
			this.vmethod_5(new global::ns5.FlightPlanWaypointsWeapon());
			this.vmethod_7(new global::System.Windows.Forms.Label());
			this.vmethod_9(new global::System.Windows.Forms.Label());
			this.vmethod_11(new global::System.Windows.Forms.Label());
			this.vmethod_13(new global::System.Windows.Forms.Label());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_17(new global::System.Windows.Forms.Label());
			this.vmethod_19(new global::System.Windows.Forms.GroupBox());
			this.vmethod_21(new global::System.Windows.Forms.ComboBox());
			this.vmethod_23(new global::System.Windows.Forms.Label());
			this.vmethod_25(new global::System.Windows.Forms.Label());
			this.vmethod_27(new global::System.Windows.Forms.ComboBox());
			this.vmethod_29(new global::System.Windows.Forms.Button());
			this.vmethod_18().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Enabled = false;
			this.vmethod_0().Location = new global::System.Drawing.Point(302, 55);
			this.vmethod_0().Name = "Button_ClearRoute";
			this.vmethod_0().Size = new global::System.Drawing.Size(185, 24);
			this.vmethod_0().TabIndex = 37;
			this.vmethod_0().Text = "Clear Route";
			this.vmethod_0().UseVisualStyleBackColor = true;
			this.vmethod_2().Location = new global::System.Drawing.Point(302, 80);
			this.vmethod_2().Name = "Button_CopyRouteFromWeapon1";
			this.vmethod_2().Size = new global::System.Drawing.Size(185, 24);
			this.vmethod_2().TabIndex = 35;
			this.vmethod_2().Text = "Copy Route From Weapon #1";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_4().Location = new global::System.Drawing.Point(0, 220);
			this.vmethod_4().Name = "FlightPlanWaypointsWeapon1";
			this.vmethod_4().Size = new global::System.Drawing.Size(499, 561);
			this.vmethod_4().TabIndex = 38;
			this.vmethod_6().AutoSize = true;
			this.vmethod_6().Location = new global::System.Drawing.Point(108, 123);
			this.vmethod_6().Name = "Label_AircraftType";
			this.vmethod_6().Size = new global::System.Drawing.Size(83, 13);
			this.vmethod_6().TabIndex = 40;
			this.vmethod_6().Text = "<Weapon type>";
			this.vmethod_8().AutoSize = true;
			this.vmethod_8().Location = new global::System.Drawing.Point(12, 123);
			this.vmethod_8().Name = "Label6";
			this.vmethod_8().Size = new global::System.Drawing.Size(51, 13);
			this.vmethod_8().TabIndex = 39;
			this.vmethod_8().Text = "Weapon:";
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(12, 180);
			this.vmethod_10().Name = "Label8";
			this.vmethod_10().Size = new global::System.Drawing.Size(87, 13);
			this.vmethod_10().TabIndex = 44;
			this.vmethod_10().Text = "Zulu impact time:";
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Location = new global::System.Drawing.Point(108, 180);
			this.vmethod_12().Name = "Label_ImpactDateAndTime";
			this.vmethod_12().Size = new global::System.Drawing.Size(118, 13);
			this.vmethod_12().TabIndex = 43;
			this.vmethod_12().Text = "<Impact date and time>";
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new global::System.Drawing.Point(12, 159);
			this.vmethod_14().Name = "Label5";
			this.vmethod_14().Size = new global::System.Drawing.Size(88, 13);
			this.vmethod_14().TabIndex = 42;
			this.vmethod_14().Text = "Zulu launch time:";
			this.vmethod_16().AutoSize = true;
			this.vmethod_16().Location = new global::System.Drawing.Point(108, 159);
			this.vmethod_16().Name = "Label_LaunchDateAndTime";
			this.vmethod_16().Size = new global::System.Drawing.Size(122, 13);
			this.vmethod_16().TabIndex = 41;
			this.vmethod_16().Text = "<Launch date and time>";
			this.vmethod_18().Controls.Add(this.vmethod_20());
			this.vmethod_18().Controls.Add(this.vmethod_22());
			this.vmethod_18().Controls.Add(this.vmethod_24());
			this.vmethod_18().Controls.Add(this.vmethod_26());
			this.vmethod_18().Location = new global::System.Drawing.Point(15, 11);
			this.vmethod_18().Name = "GroupBox_SelectedFlight";
			this.vmethod_18().Size = new global::System.Drawing.Size(225, 68);
			this.vmethod_18().TabIndex = 45;
			this.vmethod_18().TabStop = false;
			this.vmethod_18().Text = "Selected Weapon Route";
			this.vmethod_20().FormattingEnabled = true;
			this.vmethod_20().Location = new global::System.Drawing.Point(62, 38);
			this.vmethod_20().Name = "Combo_CurrentWeapon";
			this.vmethod_20().Size = new global::System.Drawing.Size(153, 21);
			this.vmethod_20().TabIndex = 12;
			this.vmethod_22().AutoSize = true;
			this.vmethod_22().Location = new global::System.Drawing.Point(6, 20);
			this.vmethod_22().Name = "Label1";
			this.vmethod_22().Size = new global::System.Drawing.Size(43, 13);
			this.vmethod_22().TabIndex = 11;
			this.vmethod_22().Text = "Aircraft:";
			this.vmethod_24().AutoSize = true;
			this.vmethod_24().Location = new global::System.Drawing.Point(6, 42);
			this.vmethod_24().Name = "Label2";
			this.vmethod_24().Size = new global::System.Drawing.Size(51, 13);
			this.vmethod_24().TabIndex = 11;
			this.vmethod_24().Text = "Weapon:";
			this.vmethod_26().FormattingEnabled = true;
			this.vmethod_26().Location = new global::System.Drawing.Point(62, 16);
			this.vmethod_26().Name = "Combo_CurrentAircraft";
			this.vmethod_26().Size = new global::System.Drawing.Size(153, 21);
			this.vmethod_26().TabIndex = 12;
			this.vmethod_28().Location = new global::System.Drawing.Point(302, 110);
			this.vmethod_28().Name = "Button_CopyRouteToAllWeapons";
			this.vmethod_28().Size = new global::System.Drawing.Size(185, 24);
			this.vmethod_28().TabIndex = 46;
			this.vmethod_28().Text = "Copy Route To All Weapons";
			this.vmethod_28().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(499, 782);
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(515, 821);
			base.Name = "FlightPlanEditorWeaponRoute";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit route for weapon <Weapon Name>";
			this.vmethod_18().ResumeLayout(false);
			this.vmethod_18().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04003D84 RID: 15748
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
