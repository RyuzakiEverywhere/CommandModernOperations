using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
using ns4;
using ns5;
using ns7;

namespace ns6
{
	// Token: 0x02000ECB RID: 3787
	[DesignerGenerated]
	internal sealed partial class NewMessageForm : DarkSecondaryFormBase
	{
		// Token: 0x06008285 RID: 33413 RVA: 0x00465AC4 File Offset: 0x00463CC4
		public NewMessageForm()
		{
			base.FormClosing += this.NewMessageForm_FormClosing;
			base.Load += this.NewMessageForm_Load;
			base.KeyDown += this.NewMessageForm_KeyDown;
			this.vmethod_15(new ObservableCollection<LoggedMessage>());
			this.InitializeComponent_1();
		}

		// Token: 0x06008287 RID: 33415 RVA: 0x00465B60 File Offset: 0x00463D60
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(NewMessageForm));
			this.vmethod_1(new Class125());
			this.vmethod_9(new ToolStripButton());
			this.vmethod_11(new ToolStripButton());
			this.vmethod_3(new ToolStripButton());
			this.vmethod_5(new ToolStripButton());
			this.vmethod_7(new ToolStripButton());
			this.vmethod_13(new WebBrowser());
			this.vmethod_0().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AutoSize = false;
			this.vmethod_0().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().Dock = DockStyle.Bottom;
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_0().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_2(),
				this.vmethod_4(),
				this.vmethod_6()
			});
			this.vmethod_0().Location = new Point(0, 167);
			this.vmethod_0().Name = "ToolStrip1";
			this.vmethod_0().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_0().Size = new Size(434, 25);
			this.vmethod_0().Stretch = true;
			this.vmethod_0().TabIndex = 4;
			this.vmethod_0().Text = "ToolStrip1";
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Image = (Image)componentResourceManager.GetObject("TSB_PrevMessage.Image");
			this.vmethod_8().ImageTransparentColor = Color.Magenta;
			this.vmethod_8().Name = "TSB_PrevMessage";
			this.vmethod_8().Size = new Size(72, 22);
			this.vmethod_8().Text = "Previous";
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Image = (Image)componentResourceManager.GetObject("TSB_NextMessage.Image");
			this.vmethod_10().ImageTransparentColor = Color.Magenta;
			this.vmethod_10().Name = "TSB_NextMessage";
			this.vmethod_10().Size = new Size(51, 22);
			this.vmethod_10().Text = "Next";
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Image = (Image)componentResourceManager.GetObject("ToolStripButton1.Image");
			this.vmethod_2().ImageTransparentColor = Color.Magenta;
			this.vmethod_2().Name = "ToolStripButton1";
			this.vmethod_2().Size = new Size(119, 22);
			this.vmethod_2().Text = "Jump to Location";
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Image = (Image)componentResourceManager.GetObject("ToolStripButton2.Image");
			this.vmethod_4().ImageTransparentColor = Color.Magenta;
			this.vmethod_4().Name = "ToolStripButton2";
			this.vmethod_4().Size = new Size(56, 22);
			this.vmethod_4().Text = "Close";
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Image = (Image)componentResourceManager.GetObject("ToolStripButton3.Image");
			this.vmethod_6().ImageTransparentColor = Color.Magenta;
			this.vmethod_6().Name = "ToolStripButton3";
			this.vmethod_6().Size = new Size(112, 22);
			this.vmethod_6().Text = "Close + Resume";
			this.vmethod_12().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_12().Location = new Point(0, -1);
			this.vmethod_12().MinimumSize = new Size(20, 20);
			this.vmethod_12().Name = "WebBrowser1";
			this.vmethod_12().Size = new Size(434, 165);
			this.vmethod_12().TabIndex = 16;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(434, 192);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "NewMessageForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "New Message";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x0004F44D File Offset: 0x0004D64D
		[CompilerGenerated]
		internal Class125 vmethod_0()
		{
			return this.class125_0;
		}

		// Token: 0x06008289 RID: 33417 RVA: 0x0004F455 File Offset: 0x0004D655
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x0600828A RID: 33418 RVA: 0x0004F45E File Offset: 0x0004D65E
		[CompilerGenerated]
		internal ToolStripButton vmethod_2()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x0600828B RID: 33419 RVA: 0x004660F8 File Offset: 0x004642F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_4);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_5;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600828C RID: 33420 RVA: 0x0004F466 File Offset: 0x0004D666
		[CompilerGenerated]
		internal ToolStripButton vmethod_4()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x0600828D RID: 33421 RVA: 0x0046613C File Offset: 0x0046433C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_5);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_5;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600828E RID: 33422 RVA: 0x0004F46E File Offset: 0x0004D66E
		[CompilerGenerated]
		internal ToolStripButton vmethod_6()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x0600828F RID: 33423 RVA: 0x00466180 File Offset: 0x00464380
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_6);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_5;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008290 RID: 33424 RVA: 0x0004F476 File Offset: 0x0004D676
		[CompilerGenerated]
		internal ToolStripButton vmethod_8()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x06008291 RID: 33425 RVA: 0x004661C4 File Offset: 0x004643C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_8);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_3 = toolStripButton_5;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008292 RID: 33426 RVA: 0x0004F47E File Offset: 0x0004D67E
		[CompilerGenerated]
		internal ToolStripButton vmethod_10()
		{
			return this.toolStripButton_4;
		}

		// Token: 0x06008293 RID: 33427 RVA: 0x00466208 File Offset: 0x00464408
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_9);
			ToolStripButton toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_4 = toolStripButton_5;
			toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008294 RID: 33428 RVA: 0x0004F486 File Offset: 0x0004D686
		[CompilerGenerated]
		internal WebBrowser vmethod_12()
		{
			return this.webBrowser_0;
		}

		// Token: 0x06008295 RID: 33429 RVA: 0x0046624C File Offset: 0x0046444C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(WebBrowser webBrowser_1)
		{
			PreviewKeyDownEventHandler value = new PreviewKeyDownEventHandler(this.method_10);
			WebBrowser webBrowser = this.webBrowser_0;
			if (webBrowser != null)
			{
				webBrowser.PreviewKeyDown -= value;
			}
			this.webBrowser_0 = webBrowser_1;
			webBrowser = this.webBrowser_0;
			if (webBrowser != null)
			{
				webBrowser.PreviewKeyDown += value;
			}
		}

		// Token: 0x06008296 RID: 33430 RVA: 0x0004F48E File Offset: 0x0004D68E
		[CompilerGenerated]
		public ObservableCollection<LoggedMessage> vmethod_14()
		{
			return this.observableCollection_0;
		}

		// Token: 0x06008297 RID: 33431 RVA: 0x00466290 File Offset: 0x00464490
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_15(ObservableCollection<LoggedMessage> observableCollection_1)
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = new NotifyCollectionChangedEventHandler(this.method_7);
			ObservableCollection<LoggedMessage> observableCollection = this.observableCollection_0;
			if (observableCollection != null)
			{
				observableCollection.CollectionChanged -= notifyCollectionChangedEventHandler;
			}
			this.observableCollection_0 = observableCollection_1;
			observableCollection = this.observableCollection_0;
			if (observableCollection != null)
			{
				observableCollection.CollectionChanged += notifyCollectionChangedEventHandler;
			}
		}

		// Token: 0x06008298 RID: 33432 RVA: 0x004662D4 File Offset: 0x004644D4
		private void NewMessageForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				Client.dictionary_5.Remove(this.vmethod_14()[0].messageType_0);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200393", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06008299 RID: 33433 RVA: 0x00466358 File Offset: 0x00464558
		private void NewMessageForm_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (this.vmethod_14().Count == 0)
			{
				base.Close();
			}
			this.loggedMessage_0 = this.vmethod_14()[0];
			this.method_3(this.loggedMessage_0);
			this.vmethod_8().Enabled = false;
			this.vmethod_10().Enabled = (this.vmethod_14().Count > 1);
			base.BringToFront();
		}

		// Token: 0x0600829A RID: 33434 RVA: 0x004663D4 File Offset: 0x004645D4
		private void method_3(LoggedMessage loggedMessage_1)
		{
			loggedMessage_1.string_2 = loggedMessage_1.string_2.Replace("�", Conversions.ToString(Strings.Chr(176)));
			Class2558.smethod_11(this.vmethod_12(), "<span style='font:Arial'>" + loggedMessage_1.string_2 + "<span>");
			this.vmethod_2().Visible = !Information.IsNothing(loggedMessage_1.nullable_0);
			this.vmethod_8().Enabled = (this.vmethod_14().IndexOf(this.loggedMessage_0) != 0);
			this.vmethod_10().Enabled = (this.vmethod_14().IndexOf(this.loggedMessage_0) != this.vmethod_14().Count - 1);
			base.BringToFront();
		}

		// Token: 0x0600829B RID: 33435 RVA: 0x00466498 File Offset: 0x00464698
		private void method_4(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.loggedMessage_0.nullable_0))
			{
				Class2413.smethod_2().method_41().method_161(true, this.loggedMessage_0.nullable_0.Value.method_1());
			}
		}

		// Token: 0x0600829C RID: 33436 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_5(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600829D RID: 33437 RVA: 0x0004F496 File Offset: 0x0004D696
		private void method_6(object sender, EventArgs e)
		{
			Client.smethod_0().method_3();
			base.Close();
		}

		// Token: 0x0600829E RID: 33438 RVA: 0x0004F4A8 File Offset: 0x0004D6A8
		private void method_7(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.Text = Conversions.ToString(this.vmethod_14().Count) + " new messages of type: " + Misc.smethod_22(((LoggedMessage)e.NewItems[0]).messageType_0);
		}

		// Token: 0x0600829F RID: 33439 RVA: 0x004664E4 File Offset: 0x004646E4
		private void method_8(object sender, EventArgs e)
		{
			if (this.vmethod_14().IndexOf(this.loggedMessage_0) != 0)
			{
				this.loggedMessage_0 = this.vmethod_14()[this.vmethod_14().IndexOf(this.loggedMessage_0) - 1];
				this.method_3(this.loggedMessage_0);
			}
		}

		// Token: 0x060082A0 RID: 33440 RVA: 0x00466534 File Offset: 0x00464734
		private void method_9(object sender, EventArgs e)
		{
			if (this.vmethod_14().IndexOf(this.loggedMessage_0) != this.vmethod_14().Count - 1)
			{
				this.loggedMessage_0 = this.vmethod_14()[this.vmethod_14().IndexOf(this.loggedMessage_0) + 1];
				this.method_3(this.loggedMessage_0);
			}
		}

		// Token: 0x060082A1 RID: 33441 RVA: 0x00466594 File Offset: 0x00464794
		private void NewMessageForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				Client.smethod_0().method_3();
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F12 && base.Visible)
			{
				base.Close();
				Client.smethod_0().method_3();
				return;
			}
			Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x060082A2 RID: 33442 RVA: 0x00466600 File Offset: 0x00464800
		private void method_10(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				Client.smethod_0().method_3();
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F12 && base.Visible)
			{
				base.Close();
				Client.smethod_0().method_3();
				return;
			}
			KeyEventArgs e2 = new KeyEventArgs(e.KeyCode);
			Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e2);
		}

		// Token: 0x040047A1 RID: 18337
		[AccessedThroughProperty("ToolStrip1")]
		[CompilerGenerated]
		private Class125 class125_0;

		// Token: 0x040047A2 RID: 18338
		[AccessedThroughProperty("ToolStripButton1")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x040047A3 RID: 18339
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripButton2")]
		private ToolStripButton toolStripButton_1;

		// Token: 0x040047A4 RID: 18340
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripButton3")]
		private ToolStripButton toolStripButton_2;

		// Token: 0x040047A5 RID: 18341
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_PrevMessage")]
		private ToolStripButton toolStripButton_3;

		// Token: 0x040047A6 RID: 18342
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_NextMessage")]
		private ToolStripButton toolStripButton_4;

		// Token: 0x040047A7 RID: 18343
		[AccessedThroughProperty("WebBrowser1")]
		[CompilerGenerated]
		private WebBrowser webBrowser_0;

		// Token: 0x040047A8 RID: 18344
		[CompilerGenerated]
		[AccessedThroughProperty("Messages")]
		private ObservableCollection<LoggedMessage> observableCollection_0;

		// Token: 0x040047A9 RID: 18345
		private LoggedMessage loggedMessage_0;
	}
}
