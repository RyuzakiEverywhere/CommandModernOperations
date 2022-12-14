namespace ns4
{
	// Token: 0x02000E22 RID: 3618
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	internal sealed partial class FlightPlanEditorTargetsPreliminary : global::ns6.Form4
	{
		// Token: 0x06006BA9 RID: 27561 RVA: 0x003B039C File Offset: 0x003AE59C
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

		// Token: 0x06006BAA RID: 27562 RVA: 0x003B03DC File Offset: 0x003AE5DC
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.ComboBox());
			this.vmethod_5(new global::System.Windows.Forms.ComboBox());
			this.vmethod_7(new global::System.Windows.Forms.Label());
			this.vmethod_9(new global::System.Windows.Forms.Label());
			this.vmethod_11(new global::System.Windows.Forms.TextBox());
			this.vmethod_13(new global::System.Windows.Forms.Button());
			this.vmethod_15(new global::Command.UnitFilter());
			base.SuspendLayout();
			this.vmethod_0().AutoSize = true;
			this.vmethod_0().Location = new global::System.Drawing.Point(29, 99);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new global::System.Drawing.Size(192, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Aquire mission-relevant contacts within:";
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Items.AddRange(new object[]
			{
				"2 nm",
				"5 nm",
				"10 nm",
				"50 nm",
				"200 nm",
				"unlimited distance"
			});
			this.vmethod_2().Location = new global::System.Drawing.Point(242, 94);
			this.vmethod_2().Name = "ComboBox1";
			this.vmethod_2().Size = new global::System.Drawing.Size(167, 21);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_4().FormattingEnabled = true;
			this.vmethod_4().Items.AddRange(new object[]
			{
				"Unknown",
				"Unfriendly",
				"Hostile"
			});
			this.vmethod_4().Location = new global::System.Drawing.Point(232, 129);
			this.vmethod_4().Name = "Combo_Strike_MinimumContactStanceToTrigger";
			this.vmethod_4().Size = new global::System.Drawing.Size(90, 21);
			this.vmethod_4().TabIndex = 10;
			this.vmethod_6().AutoSize = true;
			this.vmethod_6().Location = new global::System.Drawing.Point(29, 133);
			this.vmethod_6().Name = "Label7";
			this.vmethod_6().Size = new global::System.Drawing.Size(171, 13);
			this.vmethod_6().TabIndex = 9;
			this.vmethod_6().Text = "Contact is targeted when minimum:";
			this.vmethod_8().AutoSize = true;
			this.vmethod_8().Location = new global::System.Drawing.Point(29, 18);
			this.vmethod_8().Name = "Label2";
			this.vmethod_8().Size = new global::System.Drawing.Size(130, 13);
			this.vmethod_8().TabIndex = 11;
			this.vmethod_8().Text = "Preliminary target location:";
			this.vmethod_10().Location = new global::System.Drawing.Point(181, 14);
			this.vmethod_10().Name = "TextBox1";
			this.vmethod_10().Size = new global::System.Drawing.Size(170, 20);
			this.vmethod_10().TabIndex = 12;
			this.vmethod_12().Location = new global::System.Drawing.Point(373, 14);
			this.vmethod_12().Name = "Button1";
			this.vmethod_12().Size = new global::System.Drawing.Size(147, 30);
			this.vmethod_12().TabIndex = 13;
			this.vmethod_12().Text = "Get point from map";
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_14().method_2(null);
			this.vmethod_14().Location = new global::System.Drawing.Point(32, 174);
			this.vmethod_14().MinimumSize = new global::System.Drawing.Size(311, 177);
			this.vmethod_14().Name = "UnitFilter_UnitDestroyed";
			this.vmethod_14().Size = new global::System.Drawing.Size(311, 177);
			this.vmethod_14().TabIndex = 14;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1074, 423);
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FlightPlanEditorTargetsPreliminary";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "FlightPlanEditorTargetsPreliminary";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04003D7B RID: 15739
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
