using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace Command
{
	// Token: 0x02000E48 RID: 3656
	[DesignerGenerated]
	public sealed class OrbitAnchor : Window, IComponentConnector
	{
		// Token: 0x06006E28 RID: 28200 RVA: 0x00045585 File Offset: 0x00043785
		public OrbitAnchor()
		{
			base.ContentRendered += this.OrbitAnchor_ContentRendered;
			this.InitializeComponent();
		}

		// Token: 0x06006E29 RID: 28201 RVA: 0x003BEBB4 File Offset: 0x003BCDB4
		private void Button_OK_Click(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_10().IsChecked.GetValueOrDefault())
			{
				if (!Versioned.IsNumeric(this.vmethod_0().Text))
				{
					DarkMessageBox.smethod_2("Longitude is not valid!", "Error", Enum11.const_0);
					return;
				}
				if (!Math2.smethod_18(Conversions.ToDouble(this.vmethod_0().Text)))
				{
					DarkMessageBox.smethod_2("Longitude is not valid!", "Error", Enum11.const_0);
					return;
				}
				if (!Versioned.IsNumeric(this.vmethod_2().Text))
				{
					DarkMessageBox.smethod_2("Latitude is not valid!", "Error", Enum11.const_0);
					return;
				}
				if (!Math2.smethod_19(Conversions.ToDouble(this.vmethod_2().Text)))
				{
					DarkMessageBox.smethod_2("Latitude is not valid!", "Error", Enum11.const_0);
					return;
				}
				if (!Versioned.IsNumeric(this.vmethod_4().Text))
				{
					DarkMessageBox.smethod_2("Altitude is not valid!", "Error", Enum11.const_0);
					return;
				}
				Satellite.Class296 @class = new Satellite.Class296();
				@class.double_0 = Conversions.ToDouble(this.vmethod_0().Text);
				@class.double_1 = Conversions.ToDouble(this.vmethod_2().Text);
				@class.float_0 = Conversions.ToSingle(this.vmethod_4().Text) * 1000f;
				this.satellite_0.class296_0 = @class;
			}
			else
			{
				this.satellite_0.class296_0 = null;
			}
			base.Close();
		}

		// Token: 0x06006E2A RID: 28202 RVA: 0x003BED08 File Offset: 0x003BCF08
		private void Button_UseCurrent_Click(object sender, RoutedEventArgs e)
		{
			this.vmethod_0().Text = Conversions.ToString(this.satellite_0.vmethod_28(null));
			this.vmethod_2().Text = Conversions.ToString(this.satellite_0.vmethod_30(null));
			this.vmethod_4().Text = Conversions.ToString(this.satellite_0.vmethod_14(false) / 1000f);
		}

		// Token: 0x06006E2B RID: 28203 RVA: 0x003BED80 File Offset: 0x003BCF80
		private void OrbitAnchor_ContentRendered(object sender, EventArgs e)
		{
			base.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			if (Information.IsNothing(this.satellite_0.class296_0))
			{
				this.vmethod_10().IsChecked = new bool?(false);
				this.vmethod_0().Text = "";
				this.vmethod_2().Text = "";
				this.vmethod_4().Text = "";
				return;
			}
			this.vmethod_10().IsChecked = new bool?(true);
			this.vmethod_0().Text = Conversions.ToString(this.satellite_0.class296_0.double_0);
			this.vmethod_2().Text = Conversions.ToString(this.satellite_0.class296_0.double_1);
			this.vmethod_4().Text = Conversions.ToString(this.satellite_0.class296_0.float_0 / 1000f);
		}

		// Token: 0x06006E2C RID: 28204 RVA: 0x000455A5 File Offset: 0x000437A5
		[CompilerGenerated]
		internal TextBox vmethod_0()
		{
			return this.textBox_0;
		}

		// Token: 0x06006E2D RID: 28205 RVA: 0x000455AD File Offset: 0x000437AD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TextBox textBox_3)
		{
			this.textBox_0 = textBox_3;
		}

		// Token: 0x06006E2E RID: 28206 RVA: 0x000455B6 File Offset: 0x000437B6
		[CompilerGenerated]
		internal TextBox vmethod_2()
		{
			return this.textBox_1;
		}

		// Token: 0x06006E2F RID: 28207 RVA: 0x000455BE File Offset: 0x000437BE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TextBox textBox_3)
		{
			this.textBox_1 = textBox_3;
		}

		// Token: 0x06006E30 RID: 28208 RVA: 0x000455C7 File Offset: 0x000437C7
		[CompilerGenerated]
		internal TextBox vmethod_4()
		{
			return this.textBox_2;
		}

		// Token: 0x06006E31 RID: 28209 RVA: 0x000455CF File Offset: 0x000437CF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TextBox textBox_3)
		{
			this.textBox_2 = textBox_3;
		}

		// Token: 0x06006E32 RID: 28210 RVA: 0x000455D8 File Offset: 0x000437D8
		[CompilerGenerated]
		internal Button vmethod_6()
		{
			return this.button_0;
		}

		// Token: 0x06006E33 RID: 28211 RVA: 0x000455E0 File Offset: 0x000437E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_2)
		{
			this.button_0 = button_2;
		}

		// Token: 0x06006E34 RID: 28212 RVA: 0x000455E9 File Offset: 0x000437E9
		[CompilerGenerated]
		internal Button vmethod_8()
		{
			return this.button_1;
		}

		// Token: 0x06006E35 RID: 28213 RVA: 0x003BEE60 File Offset: 0x003BD060
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_2)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_OK_Click);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_2;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006E36 RID: 28214 RVA: 0x000455F1 File Offset: 0x000437F1
		[CompilerGenerated]
		internal CheckBox vmethod_10()
		{
			return this.checkBox_0;
		}

		// Token: 0x06006E37 RID: 28215 RVA: 0x000455F9 File Offset: 0x000437F9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(CheckBox checkBox_1)
		{
			this.checkBox_0 = checkBox_1;
		}

		// Token: 0x06006E38 RID: 28216 RVA: 0x003BEEA4 File Offset: 0x003BD0A4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/units/orbitanchor.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006E39 RID: 28217 RVA: 0x003BEED4 File Offset: 0x003BD0D4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.vmethod_1((TextBox)target);
				return;
			}
			if (connectionId == 2)
			{
				this.vmethod_3((TextBox)target);
				return;
			}
			if (connectionId == 3)
			{
				this.vmethod_5((TextBox)target);
				return;
			}
			if (connectionId == 4)
			{
				this.vmethod_7((Button)target);
				this.vmethod_6().Click += this.Button_UseCurrent_Click;
				return;
			}
			if (connectionId == 5)
			{
				this.vmethod_9((Button)target);
				this.vmethod_8().Click += this.Button_OK_Click;
				return;
			}
			if (connectionId == 6)
			{
				this.vmethod_11((CheckBox)target);
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04003EA4 RID: 16036
		public Satellite satellite_0;

		// Token: 0x04003EA5 RID: 16037
		[AccessedThroughProperty("TB_Longitude")]
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04003EA6 RID: 16038
		[CompilerGenerated]
		[AccessedThroughProperty("TB_Latitude")]
		private TextBox textBox_1;

		// Token: 0x04003EA7 RID: 16039
		[CompilerGenerated]
		[AccessedThroughProperty("TB_Altitude")]
		private TextBox textBox_2;

		// Token: 0x04003EA8 RID: 16040
		[CompilerGenerated]
		[AccessedThroughProperty("Button_UseCurrent")]
		private Button button_0;

		// Token: 0x04003EA9 RID: 16041
		[AccessedThroughProperty("Button_OK")]
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04003EAA RID: 16042
		[CompilerGenerated]
		[AccessedThroughProperty("CB_ApplyAnchor")]
		private CheckBox checkBox_0;

		// Token: 0x04003EAB RID: 16043
		private bool bool_0;
	}
}
