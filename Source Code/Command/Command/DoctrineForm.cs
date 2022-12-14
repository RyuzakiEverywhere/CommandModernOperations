using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns10;
using ns13;
using ns2;
using ns4;
using ns5;
using ns8;

namespace Command
{
	// Token: 0x02000EAB RID: 3755
	[DesignerGenerated]
	public sealed partial class DoctrineForm : DarkSecondaryFormBase
	{
		// Token: 0x0600765C RID: 30300 RVA: 0x003FBEDC File Offset: 0x003FA0DC
		public DoctrineForm()
		{
			base.Load += this.DoctrineForm_Load;
			base.KeyDown += this.DoctrineForm_KeyDown;
			base.FormClosed += this.DoctrineForm_FormClosed;
			base.FormClosing += this.DoctrineForm_FormClosing;
			base.Shown += this.DoctrineForm_Shown;
			this.list_1 = new List<int>();
			this.bool_5 = true;
			this.bool_6 = false;
			this.bool_7 = false;
			this.bool_8 = false;
			this.InitializeComponent_1();
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x003FBFB8 File Offset: 0x003FA1B8
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.vmethod_23(new Class50());
			this.vmethod_203(new Class44());
			this.vmethod_205(new DataGridViewComboBoxColumn());
			this.vmethod_207(new DataGridViewComboBoxColumn());
			this.vmethod_209(new DataGridViewComboBoxColumn());
			this.vmethod_211(new DataGridViewComboBoxColumn());
			this.vmethod_1(new Control12());
			this.vmethod_3(new TabPage());
			this.vmethod_123(new Control9());
			this.vmethod_119(new Control9());
			this.vmethod_121(new Control9());
			this.vmethod_27(new TableLayoutPanel());
			this.vmethod_55(new Class2451());
			this.vmethod_57(new Class2451());
			this.vmethod_59(new Class116());
			this.vmethod_61(new Class2451());
			this.vmethod_107(new Class116());
			this.vmethod_109(new Class116());
			this.vmethod_41(new Class116());
			this.vmethod_79(new Class2451());
			this.vmethod_135(new Class116());
			this.vmethod_137(new Class2451());
			this.vmethod_45(new Class116());
			this.vmethod_141(new Class116());
			this.vmethod_143(new Class116());
			this.vmethod_145(new Class116());
			this.vmethod_153(new Class2451());
			this.vmethod_155(new Class2451());
			this.vmethod_157(new Class2451());
			this.vmethod_49(new Class112());
			this.vmethod_149(new Class112());
			this.vmethod_47(new Class112());
			this.vmethod_147(new Class112());
			this.vmethod_151(new Class112());
			this.vmethod_139(new Class112());
			this.vmethod_63(new Class112());
			this.vmethod_113(new Class116());
			this.vmethod_101(new Class116());
			this.vmethod_91(new Class116());
			this.vmethod_105(new Class112());
			this.vmethod_97(new Class112());
			this.vmethod_219(new Class116());
			this.vmethod_103(new Class2451());
			this.vmethod_93(new Class2451());
			this.vmethod_223(new Class116());
			this.vmethod_267(new Class2451());
			this.vmethod_225(new Class112());
			this.vmethod_71(new Class2451());
			this.vmethod_39(new Class116());
			this.vmethod_33(new Class116());
			this.vmethod_83(new Class2451());
			this.vmethod_73(new Class112());
			this.vmethod_85(new Class112());
			this.vmethod_111(new Class116());
			this.vmethod_159(new Class116());
			this.vmethod_163(new Class2451());
			this.vmethod_161(new Class112());
			this.vmethod_51(new Class116());
			this.vmethod_53(new Class2451());
			this.vmethod_43(new Class112());
			this.vmethod_221(new Class116());
			this.vmethod_269(new Class2451());
			this.vmethod_227(new Class112());
			this.vmethod_271(new Class2451());
			this.vmethod_229(new Class116());
			this.vmethod_231(new Class112());
			this.vmethod_233(new Class112());
			this.vmethod_273(new Class2451());
			this.vmethod_235(new Class116());
			this.vmethod_35(new Class116());
			this.vmethod_81(new Class112());
			this.vmethod_289(new Class116());
			this.vmethod_291(new Class112());
			this.vmethod_293(new Class2451());
			this.vmethod_263(new Class116());
			this.vmethod_265(new Class112());
			this.vmethod_287(new Class2451());
			this.vmethod_259(new Class116());
			this.vmethod_255(new Class116());
			this.vmethod_251(new Class116());
			this.vmethod_245(new Class116());
			this.vmethod_243(new Class116());
			this.vmethod_239(new Class116());
			this.vmethod_285(new Class2451());
			this.vmethod_283(new Class2451());
			this.vmethod_281(new Class2451());
			this.vmethod_279(new Class2451());
			this.vmethod_277(new Class2451());
			this.vmethod_261(new Class112());
			this.vmethod_257(new Class112());
			this.vmethod_253(new Class112());
			this.vmethod_249(new Class112());
			this.vmethod_247(new Class112());
			this.vmethod_295(new Class116());
			this.vmethod_297(new Class116());
			this.vmethod_299(new Class116());
			this.vmethod_301(new Class116());
			this.vmethod_303(new Class112());
			this.vmethod_305(new Class112());
			this.vmethod_307(new Class112());
			this.vmethod_309(new Class2451());
			this.vmethod_311(new Class2451());
			this.vmethod_313(new Class2451());
			this.vmethod_117(new Class116());
			this.vmethod_31(new Class116());
			this.vmethod_115(new Class116());
			this.vmethod_29(new Class116());
			this.vmethod_65(new Class116());
			this.vmethod_37(new Class116());
			this.vmethod_213(new Class116());
			this.vmethod_237(new Class116());
			this.vmethod_87(new Class2451());
			this.vmethod_95(new Class2451());
			this.vmethod_67(new Class2451());
			this.vmethod_75(new Class2451());
			this.vmethod_217(new Class2451());
			this.vmethod_275(new Class2451());
			this.vmethod_89(new Class112());
			this.vmethod_99(new Class112());
			this.vmethod_69(new Class112());
			this.vmethod_77(new Class112());
			this.vmethod_215(new Class112());
			this.vmethod_241(new Class112());
			this.vmethod_5(new TabPage());
			this.vmethod_129(new Control9());
			this.vmethod_131(new Control9());
			this.vmethod_133(new Control9());
			this.vmethod_17(new Class2451());
			this.vmethod_19(new Class116());
			this.vmethod_13(new Class2451());
			this.vmethod_15(new Class116());
			this.vmethod_11(new Class112());
			this.vmethod_7(new Class2451());
			this.vmethod_9(new Class116());
			this.vmethod_21(new TabPage());
			this.vmethod_125(new Control9());
			this.vmethod_127(new Control9());
			this.vmethod_25(new Control9());
			this.vmethod_165(new TabPage());
			this.vmethod_185(new Class2451());
			this.vmethod_187(new Class2451());
			this.vmethod_189(new Class2451());
			this.vmethod_191(new Class116());
			this.vmethod_193(new Class116());
			this.vmethod_195(new Class116());
			this.vmethod_197(new Class116());
			this.vmethod_199(new Class2451());
			this.vmethod_201(new Class116());
			this.vmethod_167(new Class2451());
			this.vmethod_169(new Class2451());
			this.vmethod_171(new Class2451());
			this.vmethod_173(new Class116());
			this.vmethod_175(new Class116());
			this.vmethod_177(new Class116());
			this.vmethod_179(new Class116());
			this.vmethod_181(new Class2451());
			this.vmethod_183(new Class116());
			((ISupportInitialize)this.vmethod_22()).BeginInit();
			this.vmethod_0().SuspendLayout();
			this.vmethod_2().SuspendLayout();
			this.vmethod_26().SuspendLayout();
			this.vmethod_4().SuspendLayout();
			this.vmethod_20().SuspendLayout();
			this.vmethod_164().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_22().AllowUserToAddRows = false;
			this.vmethod_22().AllowUserToDeleteRows = false;
			this.vmethod_22().AllowUserToOrderColumns = true;
			this.vmethod_22().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_22().BackgroundColor = Color.FromArgb(43, 43, 43);
			this.vmethod_22().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_22().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_22().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font("Segoe UI", 8f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_22().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_22().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_202(),
				this.vmethod_204(),
				this.vmethod_206(),
				this.vmethod_208(),
				this.vmethod_210()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 8f);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_22().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_22().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_22().EnableHeadersVisualStyles = false;
			this.vmethod_22().method_9(null);
			this.vmethod_22().Location = new Point(0, 0);
			this.vmethod_22().MultiSelect = false;
			this.vmethod_22().Name = "TGV_WRA";
			this.vmethod_22().RowHeadersVisible = false;
			this.vmethod_22().RowHeadersWidth = 20;
			this.vmethod_22().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_22().method_7(false);
			this.vmethod_22().Size = new Size(1000, 622);
			this.vmethod_22().TabIndex = 8;
			this.vmethod_202().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_202().method_0(null);
			this.vmethod_202().HeaderText = "Weapon Vs. Target Type";
			this.vmethod_202().Name = "TargetType";
			this.vmethod_202().Resizable = DataGridViewTriState.True;
			this.vmethod_202().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_204().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_204().DropDownWidth = 2;
			this.vmethod_204().FlatStyle = FlatStyle.Flat;
			this.vmethod_204().HeaderText = "Weapons per Salvo";
			this.vmethod_204().MaxDropDownItems = 20;
			this.vmethod_204().MinimumWidth = 170;
			this.vmethod_204().Name = "WeaponsPerSalvo";
			this.vmethod_204().Width = 170;
			this.vmethod_206().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_206().DropDownWidth = 2;
			this.vmethod_206().FlatStyle = FlatStyle.Flat;
			this.vmethod_206().HeaderText = "Shooters Per Salvo";
			this.vmethod_206().MaxDropDownItems = 20;
			this.vmethod_206().MinimumWidth = 170;
			this.vmethod_206().Name = "ShootersPerSalvo";
			this.vmethod_206().Resizable = DataGridViewTriState.True;
			this.vmethod_206().Width = 170;
			this.vmethod_208().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_208().DropDownWidth = 2;
			this.vmethod_208().FlatStyle = FlatStyle.Flat;
			this.vmethod_208().HeaderText = "Automatic Firing Range";
			this.vmethod_208().MinimumWidth = 170;
			this.vmethod_208().Name = "FiringRange";
			this.vmethod_208().Resizable = DataGridViewTriState.True;
			this.vmethod_208().Width = 170;
			this.vmethod_210().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_210().DropDownWidth = 2;
			this.vmethod_210().FlatStyle = FlatStyle.Flat;
			this.vmethod_210().HeaderText = "Self Defence";
			this.vmethod_210().MaxDropDownItems = 20;
			this.vmethod_210().MinimumWidth = 170;
			this.vmethod_210().Name = "SelfDefenceRange";
			this.vmethod_210().Width = 170;
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Controls.Add(this.vmethod_4());
			this.vmethod_0().Controls.Add(this.vmethod_20());
			this.vmethod_0().Controls.Add(this.vmethod_164());
			this.vmethod_0().Cursor = Cursors.Hand;
			this.vmethod_0().Dock = DockStyle.Fill;
			this.vmethod_0().Font = new Font("Segoe UI", 8f);
			this.vmethod_0().ItemSize = new Size(80, 32);
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "TabControl1A";
			this.vmethod_0().SelectedIndex = 0;
			this.vmethod_0().Size = new Size(1008, 691);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().Controls.Add(this.vmethod_122());
			this.vmethod_2().Controls.Add(this.vmethod_118());
			this.vmethod_2().Controls.Add(this.vmethod_120());
			this.vmethod_2().Controls.Add(this.vmethod_26());
			this.vmethod_2().Location = new Point(4, 36);
			this.vmethod_2().Name = "TabPage1";
			this.vmethod_2().Padding = new Padding(3);
			this.vmethod_2().Size = new Size(1000, 651);
			this.vmethod_2().TabIndex = 0;
			this.vmethod_2().Text = "General";
			this.vmethod_122().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_122().BackColor = Color.Transparent;
			this.vmethod_122().DialogResult = DialogResult.None;
			this.vmethod_122().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_122().ForeColor = SystemColors.Control;
			this.vmethod_122().Location = new Point(3, 622);
			this.vmethod_122().Name = "Button_ResetCurrent_Doctrine";
			this.vmethod_122().Padding = new Padding(5);
			this.vmethod_122().method_1(0);
			this.vmethod_122().Size = new Size(265, 23);
			this.vmethod_122().TabIndex = 0;
			this.vmethod_122().Text = "Reset Doctrine (use inherited settings)";
			this.vmethod_118().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_118().BackColor = Color.Transparent;
			this.vmethod_118().DialogResult = DialogResult.None;
			this.vmethod_118().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_118().ForeColor = SystemColors.Control;
			this.vmethod_118().Location = new Point(545, 622);
			this.vmethod_118().Name = "Button_ResetAffectedMissions_Doctrine";
			this.vmethod_118().Padding = new Padding(5);
			this.vmethod_118().method_1(0);
			this.vmethod_118().Size = new Size(271, 23);
			this.vmethod_118().TabIndex = 2;
			this.vmethod_118().Text = "Reset affected missions (inherit from above Doctrine)";
			this.vmethod_120().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_120().BackColor = Color.Transparent;
			this.vmethod_120().DialogResult = DialogResult.None;
			this.vmethod_120().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_120().ForeColor = SystemColors.Control;
			this.vmethod_120().Location = new Point(274, 622);
			this.vmethod_120().Name = "Button_ResetAffectedUnits_Doctrine";
			this.vmethod_120().Padding = new Padding(5);
			this.vmethod_120().method_1(0);
			this.vmethod_120().Size = new Size(265, 23);
			this.vmethod_120().TabIndex = 1;
			this.vmethod_120().Text = "Reset affected units (inherit from above Doctrine)";
			this.vmethod_26().ColumnCount = 6;
			this.vmethod_26().ColumnStyles.Add(new ColumnStyle());
			this.vmethod_26().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.vmethod_26().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30f));
			this.vmethod_26().ColumnStyles.Add(new ColumnStyle());
			this.vmethod_26().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.vmethod_26().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23f));
			this.vmethod_26().Controls.Add(this.vmethod_54(), 1, 3);
			this.vmethod_26().Controls.Add(this.vmethod_56(), 1, 1);
			this.vmethod_26().Controls.Add(this.vmethod_58(), 0, 8);
			this.vmethod_26().Controls.Add(this.vmethod_60(), 1, 8);
			this.vmethod_26().Controls.Add(this.vmethod_106(), 0, 0);
			this.vmethod_26().Controls.Add(this.vmethod_108(), 0, 2);
			this.vmethod_26().Controls.Add(this.vmethod_40(), 0, 1);
			this.vmethod_26().Controls.Add(this.vmethod_78(), 1, 9);
			this.vmethod_26().Controls.Add(this.vmethod_134(), 0, 7);
			this.vmethod_26().Controls.Add(this.vmethod_136(), 1, 7);
			this.vmethod_26().Controls.Add(this.vmethod_44(), 0, 3);
			this.vmethod_26().Controls.Add(this.vmethod_140(), 0, 4);
			this.vmethod_26().Controls.Add(this.vmethod_142(), 0, 5);
			this.vmethod_26().Controls.Add(this.vmethod_144(), 0, 6);
			this.vmethod_26().Controls.Add(this.vmethod_152(), 1, 4);
			this.vmethod_26().Controls.Add(this.vmethod_154(), 1, 5);
			this.vmethod_26().Controls.Add(this.vmethod_156(), 1, 6);
			this.vmethod_26().Controls.Add(this.vmethod_48(), 2, 1);
			this.vmethod_26().Controls.Add(this.vmethod_148(), 2, 5);
			this.vmethod_26().Controls.Add(this.vmethod_46(), 2, 3);
			this.vmethod_26().Controls.Add(this.vmethod_146(), 2, 4);
			this.vmethod_26().Controls.Add(this.vmethod_150(), 2, 6);
			this.vmethod_26().Controls.Add(this.vmethod_138(), 2, 7);
			this.vmethod_26().Controls.Add(this.vmethod_62(), 2, 8);
			this.vmethod_26().Controls.Add(this.vmethod_112(), 3, 0);
			this.vmethod_26().Controls.Add(this.vmethod_100(), 3, 1);
			this.vmethod_26().Controls.Add(this.vmethod_90(), 3, 2);
			this.vmethod_26().Controls.Add(this.vmethod_104(), 5, 1);
			this.vmethod_26().Controls.Add(this.vmethod_96(), 5, 2);
			this.vmethod_26().Controls.Add(this.vmethod_218(), 3, 3);
			this.vmethod_26().Controls.Add(this.vmethod_102(), 4, 1);
			this.vmethod_26().Controls.Add(this.vmethod_92(), 4, 2);
			this.vmethod_26().Controls.Add(this.vmethod_222(), 1, 0);
			this.vmethod_26().Controls.Add(this.vmethod_266(), 4, 3);
			this.vmethod_26().Controls.Add(this.vmethod_224(), 5, 3);
			this.vmethod_26().Controls.Add(this.vmethod_70(), 4, 12);
			this.vmethod_26().Controls.Add(this.vmethod_38(), 3, 12);
			this.vmethod_26().Controls.Add(this.vmethod_32(), 3, 11);
			this.vmethod_26().Controls.Add(this.vmethod_82(), 4, 11);
			this.vmethod_26().Controls.Add(this.vmethod_72(), 5, 12);
			this.vmethod_26().Controls.Add(this.vmethod_84(), 5, 11);
			this.vmethod_26().Controls.Add(this.vmethod_110(), 3, 10);
			this.vmethod_26().Controls.Add(this.vmethod_158(), 3, 7);
			this.vmethod_26().Controls.Add(this.vmethod_162(), 4, 7);
			this.vmethod_26().Controls.Add(this.vmethod_160(), 5, 7);
			this.vmethod_26().Controls.Add(this.vmethod_50(), 3, 6);
			this.vmethod_26().Controls.Add(this.vmethod_52(), 4, 6);
			this.vmethod_26().Controls.Add(this.vmethod_42(), 5, 6);
			this.vmethod_26().Controls.Add(this.vmethod_220(), 3, 5);
			this.vmethod_26().Controls.Add(this.vmethod_268(), 4, 5);
			this.vmethod_26().Controls.Add(this.vmethod_226(), 5, 5);
			this.vmethod_26().Controls.Add(this.vmethod_270(), 4, 8);
			this.vmethod_26().Controls.Add(this.vmethod_228(), 3, 8);
			this.vmethod_26().Controls.Add(this.vmethod_230(), 5, 8);
			this.vmethod_26().Controls.Add(this.vmethod_232(), 5, 4);
			this.vmethod_26().Controls.Add(this.vmethod_272(), 4, 4);
			this.vmethod_26().Controls.Add(this.vmethod_234(), 3, 4);
			this.vmethod_26().Controls.Add(this.vmethod_34(), 0, 9);
			this.vmethod_26().Controls.Add(this.vmethod_80(), 2, 9);
			this.vmethod_26().Controls.Add(this.vmethod_288(), 3, 9);
			this.vmethod_26().Controls.Add(this.vmethod_290(), 5, 9);
			this.vmethod_26().Controls.Add(this.vmethod_292(), 4, 9);
			this.vmethod_26().Controls.Add(this.vmethod_262(), 3, 20);
			this.vmethod_26().Controls.Add(this.vmethod_264(), 5, 20);
			this.vmethod_26().Controls.Add(this.vmethod_286(), 4, 20);
			this.vmethod_26().Controls.Add(this.vmethod_258(), 3, 19);
			this.vmethod_26().Controls.Add(this.vmethod_254(), 3, 18);
			this.vmethod_26().Controls.Add(this.vmethod_250(), 3, 17);
			this.vmethod_26().Controls.Add(this.vmethod_244(), 3, 16);
			this.vmethod_26().Controls.Add(this.vmethod_242(), 3, 15);
			this.vmethod_26().Controls.Add(this.vmethod_238(), 3, 14);
			this.vmethod_26().Controls.Add(this.vmethod_284(), 4, 19);
			this.vmethod_26().Controls.Add(this.vmethod_282(), 4, 18);
			this.vmethod_26().Controls.Add(this.vmethod_280(), 4, 17);
			this.vmethod_26().Controls.Add(this.vmethod_278(), 4, 16);
			this.vmethod_26().Controls.Add(this.vmethod_276(), 4, 15);
			this.vmethod_26().Controls.Add(this.vmethod_260(), 5, 19);
			this.vmethod_26().Controls.Add(this.vmethod_256(), 5, 18);
			this.vmethod_26().Controls.Add(this.vmethod_252(), 5, 17);
			this.vmethod_26().Controls.Add(this.vmethod_248(), 5, 16);
			this.vmethod_26().Controls.Add(this.vmethod_246(), 5, 15);
			this.vmethod_26().Controls.Add(this.vmethod_294(), 3, 13);
			this.vmethod_26().Controls.Add(this.vmethod_296(), 3, 21);
			this.vmethod_26().Controls.Add(this.vmethod_298(), 3, 22);
			this.vmethod_26().Controls.Add(this.vmethod_300(), 3, 23);
			this.vmethod_26().Controls.Add(this.vmethod_302(), 5, 13);
			this.vmethod_26().Controls.Add(this.vmethod_304(), 5, 21);
			this.vmethod_26().Controls.Add(this.vmethod_306(), 5, 23);
			this.vmethod_26().Controls.Add(this.vmethod_308(), 4, 13);
			this.vmethod_26().Controls.Add(this.vmethod_310(), 4, 21);
			this.vmethod_26().Controls.Add(this.vmethod_312(), 4, 23);
			this.vmethod_26().Controls.Add(this.vmethod_116(), 0, 10);
			this.vmethod_26().Controls.Add(this.vmethod_30(), 0, 11);
			this.vmethod_26().Controls.Add(this.vmethod_114(), 0, 12);
			this.vmethod_26().Controls.Add(this.vmethod_28(), 0, 13);
			this.vmethod_26().Controls.Add(this.vmethod_64(), 0, 14);
			this.vmethod_26().Controls.Add(this.vmethod_36(), 0, 15);
			this.vmethod_26().Controls.Add(this.vmethod_212(), 0, 16);
			this.vmethod_26().Controls.Add(this.vmethod_236(), 0, 17);
			this.vmethod_26().Controls.Add(this.vmethod_86(), 1, 11);
			this.vmethod_26().Controls.Add(this.vmethod_94(), 1, 13);
			this.vmethod_26().Controls.Add(this.vmethod_66(), 1, 14);
			this.vmethod_26().Controls.Add(this.vmethod_74(), 1, 15);
			this.vmethod_26().Controls.Add(this.vmethod_216(), 1, 16);
			this.vmethod_26().Controls.Add(this.vmethod_274(), 1, 17);
			this.vmethod_26().Controls.Add(this.vmethod_88(), 2, 11);
			this.vmethod_26().Controls.Add(this.vmethod_98(), 2, 13);
			this.vmethod_26().Controls.Add(this.vmethod_68(), 2, 14);
			this.vmethod_26().Controls.Add(this.vmethod_76(), 2, 15);
			this.vmethod_26().Controls.Add(this.vmethod_214(), 2, 16);
			this.vmethod_26().Controls.Add(this.vmethod_240(), 2, 17);
			this.vmethod_26().Dock = DockStyle.Top;
			this.vmethod_26().Location = new Point(3, 3);
			this.vmethod_26().Name = "TableLayoutPanel1";
			this.vmethod_26().RowCount = 27;
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.vmethod_26().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.vmethod_26().Size = new Size(994, 613);
			this.vmethod_26().TabIndex = 7;
			this.vmethod_54().BackColor = Color.Transparent;
			this.vmethod_54().Dock = DockStyle.Fill;
			this.vmethod_54().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_54().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_54().DropDownWidth = 450;
			this.vmethod_54().Font = new Font("Segoe UI", 7f);
			this.vmethod_54().FormattingEnabled = true;
			this.vmethod_54().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_54().Location = new Point(230, 78);
			this.vmethod_54().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_54().Name = "Combo_WeaponControlStatus_Air";
			this.vmethod_54().Size = new Size(245, 21);
			this.vmethod_54().TabIndex = 1;
			this.vmethod_56().BackColor = Color.Transparent;
			this.vmethod_56().Dock = DockStyle.Fill;
			this.vmethod_56().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_56().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_56().DropDownWidth = 450;
			this.vmethod_56().Font = new Font("Segoe UI", 7f);
			this.vmethod_56().FormattingEnabled = true;
			this.vmethod_56().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_56().Location = new Point(230, 28);
			this.vmethod_56().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_56().Name = "Combo_UseNukes";
			this.vmethod_56().Size = new Size(245, 21);
			this.vmethod_56().TabIndex = 0;
			this.vmethod_58().method_2(true);
			this.vmethod_58().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_58().Location = new Point(0, 206);
			this.vmethod_58().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_58().Name = "Label5";
			this.vmethod_58().Size = new Size(149, 13);
			this.vmethod_58().TabIndex = 5;
			this.vmethod_58().Text = "Engage ambiguous targets:";
			this.vmethod_60().BackColor = Color.Transparent;
			this.vmethod_60().Dock = DockStyle.Fill;
			this.vmethod_60().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_60().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_60().Font = new Font("Segoe UI", 7f);
			this.vmethod_60().FormattingEnabled = true;
			this.vmethod_60().Items.AddRange(new object[]
			{
				"Ignore ambiguity",
				"Optimistic",
				"Pessimistic",
				"Inherit"
			});
			this.vmethod_60().Location = new Point(230, 203);
			this.vmethod_60().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_60().Name = "Combo_BehaviorTowardsAmbigousTarget";
			this.vmethod_60().Size = new Size(245, 21);
			this.vmethod_60().TabIndex = 6;
			this.vmethod_106().method_2(true);
			this.vmethod_106().Font = new Font("Segoe UI", 9.25f, FontStyle.Bold);
			this.vmethod_106().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_106().Location = new Point(0, 9);
			this.vmethod_106().Margin = new Padding(0, 9, 0, 0);
			this.vmethod_106().Name = "Label19";
			this.vmethod_106().Size = new Size(62, 16);
			this.vmethod_106().TabIndex = 28;
			this.vmethod_106().Text = "Strategic";
			this.vmethod_108().method_2(true);
			this.vmethod_108().Font = new Font("Segoe UI", 9.25f, FontStyle.Bold);
			this.vmethod_108().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_108().Location = new Point(0, 59);
			this.vmethod_108().Margin = new Padding(0, 9, 0, 0);
			this.vmethod_108().Name = "Label20";
			this.vmethod_108().Size = new Size(176, 16);
			this.vmethod_108().TabIndex = 29;
			this.vmethod_108().Text = "Rules of Engagement (RoE)";
			this.vmethod_40().method_2(true);
			this.vmethod_40().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_40().Location = new Point(0, 31);
			this.vmethod_40().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_40().Name = "Label12";
			this.vmethod_40().Size = new Size(120, 13);
			this.vmethod_40().TabIndex = 4;
			this.vmethod_40().Text = "Use nuclear weapons:";
			this.vmethod_78().BackColor = Color.Transparent;
			this.vmethod_78().Dock = DockStyle.Fill;
			this.vmethod_78().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_78().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_78().Font = new Font("Segoe UI", 7f);
			this.vmethod_78().FormattingEnabled = true;
			this.vmethod_78().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_78().Location = new Point(230, 228);
			this.vmethod_78().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_78().Name = "Combo_ShootTourists";
			this.vmethod_78().Size = new Size(245, 21);
			this.vmethod_78().TabIndex = 7;
			this.vmethod_134().method_2(true);
			this.vmethod_134().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_134().Location = new Point(0, 181);
			this.vmethod_134().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_134().Name = "Label1";
			this.vmethod_134().Size = new Size(205, 13);
			this.vmethod_134().TabIndex = 35;
			this.vmethod_134().Text = "Ignore plotted course when attacking:";
			this.vmethod_136().BackColor = Color.Transparent;
			this.vmethod_136().Dock = DockStyle.Fill;
			this.vmethod_136().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_136().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_136().Font = new Font("Segoe UI", 7f);
			this.vmethod_136().FormattingEnabled = true;
			this.vmethod_136().Location = new Point(230, 178);
			this.vmethod_136().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_136().Name = "Combo_IgnorePlottedCourse";
			this.vmethod_136().Size = new Size(245, 21);
			this.vmethod_136().TabIndex = 5;
			this.vmethod_44().method_2(true);
			this.vmethod_44().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_44().Location = new Point(0, 81);
			this.vmethod_44().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_44().Name = "Label13";
			this.vmethod_44().Size = new Size(183, 13);
			this.vmethod_44().TabIndex = 5;
			this.vmethod_44().Text = "Weapon Control Status (WCS), air:";
			this.vmethod_140().method_2(true);
			this.vmethod_140().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_140().Location = new Point(0, 106);
			this.vmethod_140().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_140().Name = "Label2";
			this.vmethod_140().Size = new Size(207, 13);
			this.vmethod_140().TabIndex = 5;
			this.vmethod_140().Text = "Weapon Control Status (WCS), surface:";
			this.vmethod_142().method_2(true);
			this.vmethod_142().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_142().Location = new Point(0, 131);
			this.vmethod_142().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_142().Name = "Label23";
			this.vmethod_142().Size = new Size(230, 13);
			this.vmethod_142().TabIndex = 5;
			this.vmethod_142().Text = "Weapon Control Status (WCS), sub-surface:";
			this.vmethod_144().method_2(true);
			this.vmethod_144().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_144().Location = new Point(0, 156);
			this.vmethod_144().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_144().Name = "Label26";
			this.vmethod_144().Size = new Size(193, 13);
			this.vmethod_144().TabIndex = 5;
			this.vmethod_144().Text = "Weapon Control Status (WCS), land:";
			this.vmethod_152().BackColor = Color.Transparent;
			this.vmethod_152().Dock = DockStyle.Fill;
			this.vmethod_152().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_152().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_152().DropDownWidth = 450;
			this.vmethod_152().Font = new Font("Segoe UI", 7f);
			this.vmethod_152().FormattingEnabled = true;
			this.vmethod_152().Location = new Point(230, 103);
			this.vmethod_152().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_152().Name = "Combo_WeaponControlStatus_Surface";
			this.vmethod_152().Size = new Size(245, 21);
			this.vmethod_152().TabIndex = 2;
			this.vmethod_154().BackColor = Color.Transparent;
			this.vmethod_154().Dock = DockStyle.Fill;
			this.vmethod_154().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_154().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_154().DropDownWidth = 450;
			this.vmethod_154().Font = new Font("Segoe UI", 7f);
			this.vmethod_154().FormattingEnabled = true;
			this.vmethod_154().Location = new Point(230, 128);
			this.vmethod_154().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_154().Name = "Combo_WeaponControlStatus_Submarine";
			this.vmethod_154().Size = new Size(245, 21);
			this.vmethod_154().TabIndex = 3;
			this.vmethod_156().BackColor = Color.Transparent;
			this.vmethod_156().Dock = DockStyle.Fill;
			this.vmethod_156().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_156().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_156().DropDownWidth = 450;
			this.vmethod_156().Font = new Font("Segoe UI", 7f);
			this.vmethod_156().FormattingEnabled = true;
			this.vmethod_156().Location = new Point(230, 153);
			this.vmethod_156().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_156().Name = "Combo_WeaponControlStatus_Land";
			this.vmethod_156().Size = new Size(245, 21);
			this.vmethod_156().TabIndex = 4;
			this.vmethod_48().Location = new Point(478, 31);
			this.vmethod_48().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_48().Name = "CB_UseNukes_PlayerEditable";
			this.vmethod_48().Size = new Size(15, 14);
			this.vmethod_48().TabIndex = 29;
			this.vmethod_148().Location = new Point(478, 131);
			this.vmethod_148().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_148().Name = "CB_WeaponControlStatus_Submarine_PlayerEditable";
			this.vmethod_148().Size = new Size(15, 14);
			this.vmethod_148().TabIndex = 32;
			this.vmethod_46().Location = new Point(478, 81);
			this.vmethod_46().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_46().Name = "CB_WeaponControlStatus_Air_PlayerEditable";
			this.vmethod_46().Size = new Size(15, 14);
			this.vmethod_46().TabIndex = 30;
			this.vmethod_146().Location = new Point(478, 106);
			this.vmethod_146().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_146().Name = "CB_WeaponControlStatus_Surface_PlayerEditable";
			this.vmethod_146().Size = new Size(15, 14);
			this.vmethod_146().TabIndex = 31;
			this.vmethod_150().Location = new Point(478, 156);
			this.vmethod_150().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_150().Name = "CB_WeaponControlStatus_Land_PlayerEditable";
			this.vmethod_150().Size = new Size(15, 14);
			this.vmethod_150().TabIndex = 33;
			this.vmethod_138().Location = new Point(478, 181);
			this.vmethod_138().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_138().Name = "CB_IgnorePlottedCourse_PlayerEditable";
			this.vmethod_138().Size = new Size(15, 14);
			this.vmethod_138().TabIndex = 34;
			this.vmethod_62().Location = new Point(478, 206);
			this.vmethod_62().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_62().Name = "CB_BehaviorTowardsAmbigousTarget_PlayerEditable";
			this.vmethod_62().Size = new Size(15, 14);
			this.vmethod_62().TabIndex = 35;
			this.vmethod_112().method_2(true);
			this.vmethod_26().SetColumnSpan(this.vmethod_112(), 2);
			this.vmethod_112().Font = new Font("Segoe UI", 9.25f, FontStyle.Bold);
			this.vmethod_112().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_112().Location = new Point(505, 9);
			this.vmethod_112().Margin = new Padding(0, 9, 0, 0);
			this.vmethod_112().Name = "Label22";
			this.vmethod_112().Size = new Size(158, 16);
			this.vmethod_112().TabIndex = 31;
			this.vmethod_112().Text = "Air Operations (Air Ops)";
			this.vmethod_100().method_2(true);
			this.vmethod_100().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_100().Location = new Point(505, 31);
			this.vmethod_100().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_100().Name = "Label18";
			this.vmethod_100().Size = new Size(121, 13);
			this.vmethod_100().TabIndex = 27;
			this.vmethod_100().Text = "Air Operations Tempo:";
			this.vmethod_90().method_2(true);
			this.vmethod_90().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_90().Location = new Point(505, 56);
			this.vmethod_90().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_90().Name = "Label17";
			this.vmethod_90().Size = new Size(102, 13);
			this.vmethod_90().TabIndex = 27;
			this.vmethod_90().Text = "Quick turnaround:";
			this.vmethod_104().Location = new Point(974, 31);
			this.vmethod_104().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_104().Name = "CB_AirOpsTempo_PlayerEditable";
			this.vmethod_104().Size = new Size(17, 16);
			this.vmethod_104().TabIndex = 42;
			this.vmethod_104().Text = "Player Editable";
			this.vmethod_96().Location = new Point(974, 56);
			this.vmethod_96().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_96().Name = "CB_QuickTurnAroundForAicraft_PlayerEditable";
			this.vmethod_96().Size = new Size(17, 16);
			this.vmethod_96().TabIndex = 43;
			this.vmethod_96().Text = "Player Editable";
			this.vmethod_218().method_2(true);
			this.vmethod_218().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_218().Location = new Point(505, 81);
			this.vmethod_218().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_218().Name = "Label28";
			this.vmethod_218().Size = new Size(129, 13);
			this.vmethod_218().TabIndex = 5;
			this.vmethod_218().Text = "Fuel State, Pre-Planned:";
			this.vmethod_102().BackColor = Color.Transparent;
			this.vmethod_102().Dock = DockStyle.Fill;
			this.vmethod_102().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_102().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_102().Font = new Font("Segoe UI", 7f);
			this.vmethod_102().FormattingEnabled = true;
			this.vmethod_102().Items.AddRange(new object[]
			{
				"Surge",
				"Sustained"
			});
			this.vmethod_102().Location = new Point(726, 28);
			this.vmethod_102().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_102().Name = "Combo_AirOpsTempo";
			this.vmethod_102().Size = new Size(245, 21);
			this.vmethod_102().TabIndex = 13;
			this.vmethod_92().BackColor = Color.Transparent;
			this.vmethod_92().Dock = DockStyle.Fill;
			this.vmethod_92().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_92().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_92().Font = new Font("Segoe UI", 7f);
			this.vmethod_92().FormattingEnabled = true;
			this.vmethod_92().Items.AddRange(new object[]
			{
				"Yes",
				"Fighters & ASW",
				"No",
				"Inherit"
			});
			this.vmethod_92().Location = new Point(726, 53);
			this.vmethod_92().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_92().Name = "Combo_QuickTurnAroundForAicraft";
			this.vmethod_92().Size = new Size(245, 21);
			this.vmethod_92().TabIndex = 14;
			this.vmethod_222().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_222().method_2(true);
			this.vmethod_26().SetColumnSpan(this.vmethod_222(), 2);
			this.vmethod_222().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_222().Location = new Point(230, 6);
			this.vmethod_222().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_222().Name = "Label30";
			this.vmethod_222().RightToLeft = RightToLeft.No;
			this.vmethod_222().Size = new Size(275, 19);
			this.vmethod_222().TabIndex = 58;
			this.vmethod_222().Text = "Tips: use check boxes to set doctrines player-editable:";
			this.vmethod_266().BackColor = Color.Transparent;
			this.vmethod_266().Dock = DockStyle.Fill;
			this.vmethod_266().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_266().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_266().DropDownWidth = 550;
			this.vmethod_266().Font = new Font("Segoe UI", 7f);
			this.vmethod_266().FormattingEnabled = true;
			this.vmethod_266().Location = new Point(726, 78);
			this.vmethod_266().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_266().Name = "Combo_FuelState";
			this.vmethod_266().Size = new Size(245, 21);
			this.vmethod_266().TabIndex = 15;
			this.vmethod_224().Location = new Point(974, 81);
			this.vmethod_224().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_224().Name = "CB_FuelState_PlayerEditable";
			this.vmethod_224().Size = new Size(17, 16);
			this.vmethod_224().TabIndex = 44;
			this.vmethod_224().Text = "Player Editable";
			this.vmethod_70().BackColor = Color.Transparent;
			this.vmethod_70().Dock = DockStyle.Fill;
			this.vmethod_70().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_70().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_70().Font = new Font("Segoe UI", 7f);
			this.vmethod_70().FormattingEnabled = true;
			this.vmethod_70().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_70().Location = new Point(726, 303);
			this.vmethod_70().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_70().Name = "Combo_Standoff";
			this.vmethod_70().Size = new Size(245, 21);
			this.vmethod_70().TabIndex = 22;
			this.vmethod_38().method_2(true);
			this.vmethod_38().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_38().Location = new Point(505, 306);
			this.vmethod_38().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_38().Name = "Label6";
			this.vmethod_38().Size = new Size(151, 13);
			this.vmethod_38().TabIndex = 11;
			this.vmethod_38().Text = "Maintain standoff to target:";
			this.vmethod_32().method_2(true);
			this.vmethod_32().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_32().Location = new Point(505, 281);
			this.vmethod_32().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_32().Name = "Label14";
			this.vmethod_32().Size = new Size(139, 13);
			this.vmethod_32().TabIndex = 21;
			this.vmethod_32().Text = "Use SAMs in ASuW mode:";
			this.vmethod_82().BackColor = Color.Transparent;
			this.vmethod_82().Dock = DockStyle.Fill;
			this.vmethod_82().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_82().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_82().Font = new Font("Segoe UI", 7f);
			this.vmethod_82().FormattingEnabled = true;
			this.vmethod_82().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_82().Location = new Point(726, 278);
			this.vmethod_82().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_82().Name = "Combo_UseSAMsOnASuW";
			this.vmethod_82().Size = new Size(245, 21);
			this.vmethod_82().TabIndex = 21;
			this.vmethod_72().Location = new Point(974, 306);
			this.vmethod_72().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_72().Name = "CB_Standoff_PlayerEditable";
			this.vmethod_72().Size = new Size(17, 16);
			this.vmethod_72().TabIndex = 51;
			this.vmethod_72().Text = "Player Editable";
			this.vmethod_84().Location = new Point(974, 281);
			this.vmethod_84().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_84().Name = "CB_UseSAMsOnASuW_PlayerEditable";
			this.vmethod_84().Size = new Size(17, 16);
			this.vmethod_84().TabIndex = 50;
			this.vmethod_84().Text = "Player Editable";
			this.vmethod_110().method_2(true);
			this.vmethod_26().SetColumnSpan(this.vmethod_110(), 2);
			this.vmethod_110().Font = new Font("Segoe UI", 9.25f, FontStyle.Bold);
			this.vmethod_110().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_110().Location = new Point(505, 259);
			this.vmethod_110().Margin = new Padding(0, 9, 0, 0);
			this.vmethod_110().Name = "Label21";
			this.vmethod_110().Size = new Size(187, 16);
			this.vmethod_110().TabIndex = 30;
			this.vmethod_110().Text = "Anti-Surface Warfare (ASuW)";
			this.vmethod_158().method_2(true);
			this.vmethod_158().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_158().Location = new Point(505, 181);
			this.vmethod_158().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_158().Name = "Label27";
			this.vmethod_158().Size = new Size(102, 13);
			this.vmethod_158().TabIndex = 5;
			this.vmethod_158().Text = "A/G strafing (gun):";
			this.vmethod_162().BackColor = Color.Transparent;
			this.vmethod_162().Dock = DockStyle.Fill;
			this.vmethod_162().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_162().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_162().Font = new Font("Segoe UI", 7f);
			this.vmethod_162().FormattingEnabled = true;
			this.vmethod_162().Location = new Point(726, 178);
			this.vmethod_162().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_162().Name = "Combo_GunStrafing";
			this.vmethod_162().Size = new Size(245, 21);
			this.vmethod_162().TabIndex = 19;
			this.vmethod_160().Location = new Point(974, 181);
			this.vmethod_160().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_160().Name = "CB_GunStrafing_PlayerEditable";
			this.vmethod_160().Size = new Size(17, 16);
			this.vmethod_160().TabIndex = 48;
			this.vmethod_160().Text = "Player Editable";
			this.vmethod_50().method_2(true);
			this.vmethod_50().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_50().Location = new Point(505, 156);
			this.vmethod_50().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_50().Name = "Label4";
			this.vmethod_50().Size = new Size(105, 13);
			this.vmethod_50().TabIndex = 5;
			this.vmethod_50().Text = "Weapon State RTB:";
			this.vmethod_52().BackColor = Color.Transparent;
			this.vmethod_52().Dock = DockStyle.Fill;
			this.vmethod_52().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_52().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_52().DropDownWidth = 550;
			this.vmethod_52().Font = new Font("Segoe UI", 7f);
			this.vmethod_52().FormattingEnabled = true;
			this.vmethod_52().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_52().Location = new Point(726, 153);
			this.vmethod_52().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_52().Name = "Combo_WeaponStateRTB";
			this.vmethod_52().Size = new Size(245, 21);
			this.vmethod_52().TabIndex = 18;
			this.vmethod_42().Location = new Point(974, 156);
			this.vmethod_42().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_42().Name = "CB_WeaponStateRTB_PlayerEditable";
			this.vmethod_42().Size = new Size(17, 16);
			this.vmethod_42().TabIndex = 47;
			this.vmethod_42().Text = "Player Editable";
			this.vmethod_220().method_2(true);
			this.vmethod_220().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_220().Location = new Point(505, 131);
			this.vmethod_220().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_220().Name = "Label29";
			this.vmethod_220().Size = new Size(151, 13);
			this.vmethod_220().TabIndex = 5;
			this.vmethod_220().Text = "Weapon State, Pre-Planned:";
			this.vmethod_268().BackColor = Color.Transparent;
			this.vmethod_268().Dock = DockStyle.Fill;
			this.vmethod_268().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_268().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_268().DropDownWidth = 750;
			this.vmethod_268().Font = new Font("Segoe UI", 7f);
			this.vmethod_268().FormattingEnabled = true;
			this.vmethod_268().Location = new Point(726, 128);
			this.vmethod_268().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_268().Name = "Combo_WeaponState";
			this.vmethod_268().Size = new Size(245, 21);
			this.vmethod_268().TabIndex = 17;
			this.vmethod_226().Location = new Point(974, 131);
			this.vmethod_226().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_226().Name = "CB_WeaponState_PlayerEditable";
			this.vmethod_226().Size = new Size(17, 16);
			this.vmethod_226().TabIndex = 46;
			this.vmethod_226().Text = "Player Editable";
			this.vmethod_270().BackColor = Color.Transparent;
			this.vmethod_270().Dock = DockStyle.Fill;
			this.vmethod_270().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_270().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_270().Font = new Font("Segoe UI", 7f);
			this.vmethod_270().FormattingEnabled = true;
			this.vmethod_270().Location = new Point(726, 203);
			this.vmethod_270().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_270().Name = "Combo_Jettison";
			this.vmethod_270().Size = new Size(245, 21);
			this.vmethod_270().TabIndex = 20;
			this.vmethod_228().method_2(true);
			this.vmethod_228().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_228().Location = new Point(505, 206);
			this.vmethod_228().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_228().Name = "Label31";
			this.vmethod_228().Size = new Size(104, 13);
			this.vmethod_228().TabIndex = 5;
			this.vmethod_228().Text = "Jettison Ordnance:";
			this.vmethod_230().Location = new Point(974, 206);
			this.vmethod_230().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_230().Name = "CB_JettisonOrdnance_PlayerEditable";
			this.vmethod_230().Size = new Size(17, 16);
			this.vmethod_230().TabIndex = 49;
			this.vmethod_230().Text = "Player Editable";
			this.vmethod_232().Location = new Point(974, 106);
			this.vmethod_232().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_232().Name = "CB_FuelStateRTB_PlayerEditable";
			this.vmethod_232().Size = new Size(17, 16);
			this.vmethod_232().TabIndex = 45;
			this.vmethod_232().Text = "Player Editable";
			this.vmethod_272().BackColor = Color.Transparent;
			this.vmethod_272().Dock = DockStyle.Fill;
			this.vmethod_272().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_272().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_272().DropDownWidth = 550;
			this.vmethod_272().Font = new Font("Segoe UI", 7f);
			this.vmethod_272().FormattingEnabled = true;
			this.vmethod_272().Location = new Point(726, 103);
			this.vmethod_272().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_272().Name = "Combo_FuelStateRTB";
			this.vmethod_272().Size = new Size(245, 21);
			this.vmethod_272().TabIndex = 16;
			this.vmethod_234().method_2(true);
			this.vmethod_234().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_234().Location = new Point(505, 106);
			this.vmethod_234().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_234().Name = "Label32";
			this.vmethod_234().Size = new Size(83, 13);
			this.vmethod_234().TabIndex = 5;
			this.vmethod_234().Text = "Fuel State RTB:";
			this.vmethod_34().method_2(true);
			this.vmethod_34().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_34().Location = new Point(0, 231);
			this.vmethod_34().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_34().Name = "Label11";
			this.vmethod_34().Size = new Size(153, 13);
			this.vmethod_34().TabIndex = 19;
			this.vmethod_34().Text = "Engage opportunity targets:";
			this.vmethod_80().Location = new Point(478, 231);
			this.vmethod_80().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_80().Name = "CB_ShootTourists_PlayerEditable";
			this.vmethod_80().Size = new Size(15, 14);
			this.vmethod_80().TabIndex = 36;
			this.vmethod_288().method_2(true);
			this.vmethod_288().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_288().Location = new Point(505, 231);
			this.vmethod_288().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_288().Name = "Label52";
			this.vmethod_288().Size = new Size(127, 13);
			this.vmethod_288().TabIndex = 5;
			this.vmethod_288().Text = "BVR engagement logic:";
			this.vmethod_290().Location = new Point(974, 231);
			this.vmethod_290().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_290().Name = "CB_BVRLogic_PlayerEditable";
			this.vmethod_290().Size = new Size(17, 16);
			this.vmethod_290().TabIndex = 49;
			this.vmethod_290().Text = "Player Editable";
			this.vmethod_292().BackColor = Color.Transparent;
			this.vmethod_292().Dock = DockStyle.Fill;
			this.vmethod_292().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_292().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_292().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_292().FormattingEnabled = true;
			this.vmethod_292().Location = new Point(726, 228);
			this.vmethod_292().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_292().Name = "Combo_BVRLogic";
			this.vmethod_292().Size = new Size(245, 21);
			this.vmethod_292().TabIndex = 59;
			this.vmethod_262().method_2(true);
			this.vmethod_262().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_262().Location = new Point(505, 506);
			this.vmethod_262().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_262().Name = "Label40";
			this.vmethod_262().Size = new Size(84, 13);
			this.vmethod_262().TabIndex = 11;
			this.vmethod_262().Text = "Dipping sonar:";
			this.vmethod_264().Location = new Point(974, 506);
			this.vmethod_264().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_264().Name = "CB_DippingSonar_PlayerEditable";
			this.vmethod_264().Size = new Size(17, 16);
			this.vmethod_264().TabIndex = 57;
			this.vmethod_264().Text = "Player Editable";
			this.vmethod_286().BackColor = Color.Transparent;
			this.vmethod_286().Dock = DockStyle.Fill;
			this.vmethod_286().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_286().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_286().DropDownWidth = 450;
			this.vmethod_286().Font = new Font("Segoe UI", 7f);
			this.vmethod_286().FormattingEnabled = true;
			this.vmethod_286().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_286().Location = new Point(726, 503);
			this.vmethod_286().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_286().Name = "Combo_DippingSonar";
			this.vmethod_286().Size = new Size(245, 21);
			this.vmethod_286().TabIndex = 28;
			this.vmethod_258().method_2(true);
			this.vmethod_258().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_258().Location = new Point(505, 481);
			this.vmethod_258().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_258().Name = "Label39";
			this.vmethod_258().Size = new Size(213, 13);
			this.vmethod_258().TabIndex = 11;
			this.vmethod_258().Text = "Air-Independent Propulsion (AIP) usage:";
			this.vmethod_254().method_2(true);
			this.vmethod_254().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_254().Location = new Point(505, 456);
			this.vmethod_254().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_254().Name = "Label38";
			this.vmethod_254().Size = new Size(221, 13);
			this.vmethod_254().TabIndex = 11;
			this.vmethod_254().Text = "Recharge battery %, offensive / defensive:";
			this.vmethod_250().method_2(true);
			this.vmethod_250().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_250().Location = new Point(505, 431);
			this.vmethod_250().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_250().Name = "Label37";
			this.vmethod_250().Size = new Size(194, 13);
			this.vmethod_250().TabIndex = 11;
			this.vmethod_250().Text = "Recharge battery %, transit / station:";
			this.vmethod_244().method_2(true);
			this.vmethod_244().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_244().Location = new Point(505, 406);
			this.vmethod_244().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_244().Name = "Label36";
			this.vmethod_244().Size = new Size(157, 13);
			this.vmethod_244().TabIndex = 11;
			this.vmethod_244().Text = "Dive when threat is detected:";
			this.vmethod_242().method_2(true);
			this.vmethod_242().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_242().Location = new Point(505, 381);
			this.vmethod_242().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_242().Name = "Label35";
			this.vmethod_242().Size = new Size(80, 13);
			this.vmethod_242().TabIndex = 11;
			this.vmethod_242().Text = "Avoid contact:";
			this.vmethod_238().method_2(true);
			this.vmethod_238().Font = new Font("Segoe UI", 9.25f, FontStyle.Bold);
			this.vmethod_238().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_238().Location = new Point(505, 359);
			this.vmethod_238().Margin = new Padding(0, 9, 0, 0);
			this.vmethod_238().Name = "Label34";
			this.vmethod_238().Size = new Size(200, 16);
			this.vmethod_238().TabIndex = 30;
			this.vmethod_238().Text = "Anti-Submarine Warfare (ASW)";
			this.vmethod_284().BackColor = Color.Transparent;
			this.vmethod_284().Dock = DockStyle.Fill;
			this.vmethod_284().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_284().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_284().DropDownWidth = 450;
			this.vmethod_284().Font = new Font("Segoe UI", 7f);
			this.vmethod_284().FormattingEnabled = true;
			this.vmethod_284().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_284().Location = new Point(726, 478);
			this.vmethod_284().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_284().Name = "Combo_AIP_Usage";
			this.vmethod_284().Size = new Size(245, 21);
			this.vmethod_284().TabIndex = 27;
			this.vmethod_282().BackColor = Color.Transparent;
			this.vmethod_282().Dock = DockStyle.Fill;
			this.vmethod_282().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_282().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_282().Font = new Font("Segoe UI", 7f);
			this.vmethod_282().FormattingEnabled = true;
			this.vmethod_282().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_282().Location = new Point(726, 453);
			this.vmethod_282().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_282().Name = "Combo_BatteryRechargeAttack";
			this.vmethod_282().Size = new Size(245, 21);
			this.vmethod_282().TabIndex = 26;
			this.vmethod_280().BackColor = Color.Transparent;
			this.vmethod_280().Dock = DockStyle.Fill;
			this.vmethod_280().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_280().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_280().Font = new Font("Segoe UI", 7f);
			this.vmethod_280().FormattingEnabled = true;
			this.vmethod_280().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_280().Location = new Point(726, 428);
			this.vmethod_280().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_280().Name = "Combo_BatteryRechargePatrol";
			this.vmethod_280().Size = new Size(245, 21);
			this.vmethod_280().TabIndex = 25;
			this.vmethod_278().BackColor = Color.Transparent;
			this.vmethod_278().Dock = DockStyle.Fill;
			this.vmethod_278().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_278().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_278().DropDownWidth = 450;
			this.vmethod_278().Font = new Font("Segoe UI", 7f);
			this.vmethod_278().FormattingEnabled = true;
			this.vmethod_278().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_278().Location = new Point(726, 403);
			this.vmethod_278().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_278().Name = "Combo_DiveWhenThreatsDetected";
			this.vmethod_278().Size = new Size(245, 21);
			this.vmethod_278().TabIndex = 24;
			this.vmethod_276().BackColor = Color.Transparent;
			this.vmethod_276().Dock = DockStyle.Fill;
			this.vmethod_276().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_276().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_276().Font = new Font("Segoe UI", 7f);
			this.vmethod_276().FormattingEnabled = true;
			this.vmethod_276().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_276().Location = new Point(726, 378);
			this.vmethod_276().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_276().Name = "Combo_AvoidContact";
			this.vmethod_276().Size = new Size(245, 21);
			this.vmethod_276().TabIndex = 23;
			this.vmethod_260().Location = new Point(974, 481);
			this.vmethod_260().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_260().Name = "CB_AIP_Usage_PlayerEditable";
			this.vmethod_260().Size = new Size(17, 16);
			this.vmethod_260().TabIndex = 56;
			this.vmethod_260().Text = "Player Editable";
			this.vmethod_256().Location = new Point(974, 456);
			this.vmethod_256().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_256().Name = "CB_BatteryRechargeAttack_PlayerEditable";
			this.vmethod_256().Size = new Size(17, 16);
			this.vmethod_256().TabIndex = 55;
			this.vmethod_256().Text = "Player Editable";
			this.vmethod_252().Location = new Point(974, 431);
			this.vmethod_252().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_252().Name = "CB_BatteryRechargePatrol_PlayerEditable";
			this.vmethod_252().Size = new Size(17, 16);
			this.vmethod_252().TabIndex = 54;
			this.vmethod_252().Text = "Player Editable";
			this.vmethod_248().Location = new Point(974, 406);
			this.vmethod_248().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_248().Name = "CB_DiveWhenThreatsDetected_PlayerEditable";
			this.vmethod_248().Size = new Size(17, 16);
			this.vmethod_248().TabIndex = 53;
			this.vmethod_248().Text = "Player Editable";
			this.vmethod_246().Location = new Point(974, 381);
			this.vmethod_246().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_246().Name = "CB_AvoidContact_PlayerEditable";
			this.vmethod_246().Size = new Size(17, 16);
			this.vmethod_246().TabIndex = 52;
			this.vmethod_246().Text = "Player Editable";
			this.vmethod_294().method_2(true);
			this.vmethod_294().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_294().Location = new Point(505, 331);
			this.vmethod_294().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_294().Name = "DarkLabel1";
			this.vmethod_294().Size = new Size(66, 13);
			this.vmethod_294().TabIndex = 60;
			this.vmethod_294().Text = "Navigation:";
			this.vmethod_296().method_2(true);
			this.vmethod_296().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_296().Location = new Point(505, 531);
			this.vmethod_296().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_296().Name = "DarkLabel2";
			this.vmethod_296().Size = new Size(66, 13);
			this.vmethod_296().TabIndex = 61;
			this.vmethod_296().Text = "Navigation:";
			this.vmethod_298().method_2(true);
			this.vmethod_298().Font = new Font("Segoe UI", 9.25f, FontStyle.Bold);
			this.vmethod_298().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_298().Location = new Point(505, 559);
			this.vmethod_298().Margin = new Padding(0, 9, 0, 0);
			this.vmethod_298().Name = "DarkLabel3";
			this.vmethod_298().Size = new Size(90, 16);
			this.vmethod_298().TabIndex = 62;
			this.vmethod_298().Text = "Land Warfare";
			this.vmethod_300().method_2(true);
			this.vmethod_300().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_300().Location = new Point(505, 581);
			this.vmethod_300().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_300().Name = "DarkLabel4";
			this.vmethod_300().Size = new Size(66, 13);
			this.vmethod_300().TabIndex = 63;
			this.vmethod_300().Text = "Navigation:";
			this.vmethod_302().AutoSize = true;
			this.vmethod_302().Location = new Point(974, 331);
			this.vmethod_302().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_302().Name = "CB_Surface_Navigation_PlayerEditable";
			this.vmethod_302().Size = new Size(17, 16);
			this.vmethod_302().TabIndex = 64;
			this.vmethod_302().Text = "DarkCheckBox1";
			this.vmethod_304().AutoSize = true;
			this.vmethod_304().Location = new Point(974, 531);
			this.vmethod_304().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_304().Name = "CB_Submarine_Navigation_PlayerEditable";
			this.vmethod_304().Size = new Size(17, 16);
			this.vmethod_304().TabIndex = 65;
			this.vmethod_304().Text = "DarkCheckBox2";
			this.vmethod_306().AutoSize = true;
			this.vmethod_306().Location = new Point(974, 581);
			this.vmethod_306().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_306().Name = "CB_Land_Navigation_PlayerEditable";
			this.vmethod_306().Size = new Size(17, 16);
			this.vmethod_306().TabIndex = 66;
			this.vmethod_306().Text = "DarkCheckBox3";
			this.vmethod_308().BackColor = Color.Transparent;
			this.vmethod_308().Dock = DockStyle.Fill;
			this.vmethod_308().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_308().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_308().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_308().FormattingEnabled = true;
			this.vmethod_308().Location = new Point(726, 328);
			this.vmethod_308().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_308().Name = "Combo_Surface_Navigation";
			this.vmethod_308().Size = new Size(245, 21);
			this.vmethod_308().TabIndex = 67;
			this.vmethod_310().BackColor = Color.Transparent;
			this.vmethod_310().Dock = DockStyle.Fill;
			this.vmethod_310().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_310().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_310().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_310().FormattingEnabled = true;
			this.vmethod_310().Location = new Point(726, 528);
			this.vmethod_310().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_310().Name = "Combo_Submarine_Navigation";
			this.vmethod_310().Size = new Size(245, 21);
			this.vmethod_310().TabIndex = 68;
			this.vmethod_312().BackColor = Color.Transparent;
			this.vmethod_312().Dock = DockStyle.Fill;
			this.vmethod_312().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_312().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_312().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_312().FormattingEnabled = true;
			this.vmethod_312().Location = new Point(726, 578);
			this.vmethod_312().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_312().Name = "Combo_Land_Navigation";
			this.vmethod_312().Size = new Size(245, 21);
			this.vmethod_312().TabIndex = 69;
			this.vmethod_116().method_2(true);
			this.vmethod_116().Font = new Font("Segoe UI", 9.25f, FontStyle.Bold);
			this.vmethod_116().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_116().Location = new Point(0, 259);
			this.vmethod_116().Margin = new Padding(0, 9, 0, 0);
			this.vmethod_116().Name = "Label25";
			this.vmethod_116().Size = new Size(174, 16);
			this.vmethod_116().TabIndex = 34;
			this.vmethod_116().Text = "Emission Control (EMCON)";
			this.vmethod_30().method_2(true);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Location = new Point(0, 281);
			this.vmethod_30().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_30().Name = "Label15";
			this.vmethod_30().Size = new Size(186, 13);
			this.vmethod_30().TabIndex = 25;
			this.vmethod_30().Text = "Ignore EMCON while under attack:";
			this.vmethod_114().method_2(true);
			this.vmethod_114().Font = new Font("Segoe UI", 9.25f, FontStyle.Bold);
			this.vmethod_114().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_114().Location = new Point(0, 309);
			this.vmethod_114().Margin = new Padding(0, 9, 0, 0);
			this.vmethod_114().Name = "Label24";
			this.vmethod_114().Size = new Size(36, 16);
			this.vmethod_114().TabIndex = 33;
			this.vmethod_114().Text = "Misc";
			this.vmethod_28().method_2(true);
			this.vmethod_28().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_28().Location = new Point(0, 331);
			this.vmethod_28().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_28().Name = "Label16";
			this.vmethod_28().Size = new Size(166, 13);
			this.vmethod_28().TabIndex = 26;
			this.vmethod_28().Text = "Kinematic range for torpedoes:";
			this.vmethod_64().method_2(true);
			this.vmethod_64().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_64().Location = new Point(0, 356);
			this.vmethod_64().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_64().Name = "Label7";
			this.vmethod_64().Size = new Size(104, 13);
			this.vmethod_64().TabIndex = 7;
			this.vmethod_64().Text = "Automatic evasion:";
			this.vmethod_36().method_2(true);
			this.vmethod_36().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_36().Location = new Point(0, 381);
			this.vmethod_36().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_36().Name = "Label10";
			this.vmethod_36().Size = new Size(82, 13);
			this.vmethod_36().TabIndex = 15;
			this.vmethod_36().Text = "Refuel/UNREP:";
			this.vmethod_212().method_2(true);
			this.vmethod_212().Font = new Font("Segoe UI", 8.25f);
			this.vmethod_212().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_212().Location = new Point(0, 406);
			this.vmethod_212().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_212().Name = "Label51";
			this.vmethod_212().Size = new Size(131, 13);
			this.vmethod_212().TabIndex = 15;
			this.vmethod_212().Text = "Refuel/UNREP selection:";
			this.vmethod_236().method_2(true);
			this.vmethod_236().Font = new Font("Segoe UI", 8.25f);
			this.vmethod_236().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_236().Location = new Point(0, 431);
			this.vmethod_236().Margin = new Padding(0, 6, 0, 0);
			this.vmethod_236().Name = "Label33";
			this.vmethod_236().Size = new Size(142, 13);
			this.vmethod_236().TabIndex = 15;
			this.vmethod_236().Text = "Refuel/UNREP allied units:";
			this.vmethod_86().BackColor = Color.Transparent;
			this.vmethod_86().Dock = DockStyle.Fill;
			this.vmethod_86().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_86().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_86().Font = new Font("Segoe UI", 7f);
			this.vmethod_86().FormattingEnabled = true;
			this.vmethod_86().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_86().Location = new Point(230, 278);
			this.vmethod_86().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_86().Name = "Combo_IgnoreEMCONunderAttack";
			this.vmethod_86().Size = new Size(245, 21);
			this.vmethod_86().TabIndex = 8;
			this.vmethod_94().BackColor = Color.Transparent;
			this.vmethod_94().Dock = DockStyle.Fill;
			this.vmethod_94().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_94().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_94().Font = new Font("Segoe UI", 7f);
			this.vmethod_94().FormattingEnabled = true;
			this.vmethod_94().Items.AddRange(new object[]
			{
				"Automatic & Manual Fire",
				"Manual Fire Only",
				"No",
				"Inherit"
			});
			this.vmethod_94().Location = new Point(230, 328);
			this.vmethod_94().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_94().Name = "Combo_UseKinematicRangeForTorpedoes";
			this.vmethod_94().Size = new Size(245, 21);
			this.vmethod_94().TabIndex = 9;
			this.vmethod_66().BackColor = Color.Transparent;
			this.vmethod_66().Dock = DockStyle.Fill;
			this.vmethod_66().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_66().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_66().Font = new Font("Segoe UI", 7f);
			this.vmethod_66().FormattingEnabled = true;
			this.vmethod_66().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_66().Location = new Point(230, 353);
			this.vmethod_66().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_66().Name = "Combo_AutoEvade";
			this.vmethod_66().Size = new Size(245, 21);
			this.vmethod_66().TabIndex = 10;
			this.vmethod_74().BackColor = Color.Transparent;
			this.vmethod_74().Dock = DockStyle.Fill;
			this.vmethod_74().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_74().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_74().DropDownWidth = 450;
			this.vmethod_74().Font = new Font("Segoe UI", 7f);
			this.vmethod_74().FormattingEnabled = true;
			this.vmethod_74().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_74().Location = new Point(230, 378);
			this.vmethod_74().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_74().Name = "Combo_UseRefuel";
			this.vmethod_74().Size = new Size(245, 21);
			this.vmethod_74().TabIndex = 11;
			this.vmethod_216().BackColor = Color.Transparent;
			this.vmethod_216().Dock = DockStyle.Fill;
			this.vmethod_216().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_216().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_216().DropDownWidth = 450;
			this.vmethod_216().Font = new Font("Segoe UI", 7f);
			this.vmethod_216().FormattingEnabled = true;
			this.vmethod_216().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_216().Location = new Point(230, 403);
			this.vmethod_216().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_216().Name = "Combo_ReplenishmentSelection";
			this.vmethod_216().Size = new Size(245, 21);
			this.vmethod_216().TabIndex = 11;
			this.vmethod_274().BackColor = Color.Transparent;
			this.vmethod_274().Dock = DockStyle.Fill;
			this.vmethod_274().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_274().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_274().Font = new Font("Segoe UI", 7f);
			this.vmethod_274().FormattingEnabled = true;
			this.vmethod_274().Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Inherit"
			});
			this.vmethod_274().Location = new Point(230, 428);
			this.vmethod_274().Margin = new Padding(0, 3, 0, 3);
			this.vmethod_274().Name = "Combo_RefuelAllies";
			this.vmethod_274().Size = new Size(245, 21);
			this.vmethod_274().TabIndex = 12;
			this.vmethod_88().Location = new Point(478, 281);
			this.vmethod_88().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_88().Name = "CB_IgnoreEMCONunderAttack_PlayerEditable";
			this.vmethod_88().Size = new Size(15, 14);
			this.vmethod_88().TabIndex = 37;
			this.vmethod_98().Location = new Point(478, 331);
			this.vmethod_98().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_98().Name = "CB_UseKinematicRangeForTorpedoes_PlayerEditable";
			this.vmethod_98().Size = new Size(15, 14);
			this.vmethod_98().TabIndex = 38;
			this.vmethod_68().Location = new Point(478, 356);
			this.vmethod_68().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_68().Name = "CB_AutoEvade_PlayerEditable";
			this.vmethod_68().Size = new Size(15, 14);
			this.vmethod_68().TabIndex = 39;
			this.vmethod_76().Location = new Point(478, 381);
			this.vmethod_76().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_76().Name = "CB_UseRefuel_PlayerEditable";
			this.vmethod_76().Size = new Size(15, 14);
			this.vmethod_76().TabIndex = 40;
			this.vmethod_214().Location = new Point(478, 406);
			this.vmethod_214().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_214().Name = "CB_ReplenishmentSelection_PlayerEditable";
			this.vmethod_214().Size = new Size(15, 14);
			this.vmethod_214().TabIndex = 40;
			this.vmethod_240().Location = new Point(478, 431);
			this.vmethod_240().Margin = new Padding(3, 6, 3, 3);
			this.vmethod_240().Name = "CB_RefuelAllies_PlayerEditable";
			this.vmethod_240().Size = new Size(15, 14);
			this.vmethod_240().TabIndex = 41;
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().Controls.Add(this.vmethod_128());
			this.vmethod_4().Controls.Add(this.vmethod_130());
			this.vmethod_4().Controls.Add(this.vmethod_132());
			this.vmethod_4().Controls.Add(this.vmethod_16());
			this.vmethod_4().Controls.Add(this.vmethod_18());
			this.vmethod_4().Controls.Add(this.vmethod_12());
			this.vmethod_4().Controls.Add(this.vmethod_14());
			this.vmethod_4().Controls.Add(this.vmethod_10());
			this.vmethod_4().Controls.Add(this.vmethod_6());
			this.vmethod_4().Controls.Add(this.vmethod_8());
			this.vmethod_4().Location = new Point(4, 36);
			this.vmethod_4().Name = "TabPage2";
			this.vmethod_4().Padding = new Padding(3);
			this.vmethod_4().Size = new Size(1000, 651);
			this.vmethod_4().TabIndex = 1;
			this.vmethod_4().Text = "EMCON Settings";
			this.vmethod_128().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_128().BackColor = Color.Transparent;
			this.vmethod_128().DialogResult = DialogResult.None;
			this.vmethod_128().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_128().ForeColor = SystemColors.Control;
			this.vmethod_128().Location = new Point(531, 631);
			this.vmethod_128().Name = "Button_ResetAffectedMissions_EMCON";
			this.vmethod_128().Padding = new Padding(5);
			this.vmethod_128().method_1(0);
			this.vmethod_128().Size = new Size(272, 23);
			this.vmethod_128().TabIndex = 14;
			this.vmethod_128().Text = "Reset affected missions (inherit from above EMCON)";
			this.vmethod_130().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_130().BackColor = Color.Transparent;
			this.vmethod_130().DialogResult = DialogResult.None;
			this.vmethod_130().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_130().ForeColor = SystemColors.Control;
			this.vmethod_130().Location = new Point(265, 631);
			this.vmethod_130().Name = "Button_ResetAffectedUnits_EMCON";
			this.vmethod_130().Padding = new Padding(5);
			this.vmethod_130().method_1(0);
			this.vmethod_130().Size = new Size(265, 23);
			this.vmethod_130().TabIndex = 13;
			this.vmethod_130().Text = "Reset affected units (inherit from above EMCON)";
			this.vmethod_132().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_132().BackColor = Color.Transparent;
			this.vmethod_132().DialogResult = DialogResult.None;
			this.vmethod_132().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_132().ForeColor = SystemColors.Control;
			this.vmethod_132().Location = new Point(-1, 631);
			this.vmethod_132().Name = "Button_ResetCurrent_EMCON";
			this.vmethod_132().Padding = new Padding(5);
			this.vmethod_132().method_1(0);
			this.vmethod_132().Size = new Size(265, 23);
			this.vmethod_132().TabIndex = 12;
			this.vmethod_132().Text = "Reset EMCON (use inherited settings)";
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_16().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_16().Font = new Font("Segoe UI", 7f);
			this.vmethod_16().FormattingEnabled = true;
			this.vmethod_16().Location = new Point(51, 95);
			this.vmethod_16().Name = "CB_EMCON_Sonar";
			this.vmethod_16().Size = new Size(146, 21);
			this.vmethod_16().TabIndex = 6;
			this.vmethod_18().method_2(true);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(9, 98);
			this.vmethod_18().Name = "Label9";
			this.vmethod_18().Size = new Size(40, 13);
			this.vmethod_18().TabIndex = 5;
			this.vmethod_18().Text = "Sonar:";
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_12().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_12().Font = new Font("Segoe UI", 7f);
			this.vmethod_12().FormattingEnabled = true;
			this.vmethod_12().Location = new Point(51, 68);
			this.vmethod_12().Name = "CB_EMCON_OECM";
			this.vmethod_12().Size = new Size(146, 21);
			this.vmethod_12().TabIndex = 4;
			this.vmethod_14().method_2(true);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(9, 71);
			this.vmethod_14().Name = "Label8";
			this.vmethod_14().Size = new Size(42, 13);
			this.vmethod_14().TabIndex = 3;
			this.vmethod_14().Text = "OECM:";
			this.vmethod_10().Location = new Point(8, 6);
			this.vmethod_10().Name = "CB_EMCON_Inherits";
			this.vmethod_10().Size = new Size(111, 17);
			this.vmethod_10().TabIndex = 2;
			this.vmethod_10().Text = "Inherit from parent";
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_6().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_6().Font = new Font("Segoe UI", 7f);
			this.vmethod_6().FormattingEnabled = true;
			this.vmethod_6().Location = new Point(51, 41);
			this.vmethod_6().Name = "CB_EMCON_Radar";
			this.vmethod_6().Size = new Size(146, 21);
			this.vmethod_6().TabIndex = 1;
			this.vmethod_8().method_2(true);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(6, 44);
			this.vmethod_8().Name = "Label3";
			this.vmethod_8().Size = new Size(40, 13);
			this.vmethod_8().TabIndex = 0;
			this.vmethod_8().Text = "Radar:";
			this.vmethod_20().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_20().Controls.Add(this.vmethod_124());
			this.vmethod_20().Controls.Add(this.vmethod_126());
			this.vmethod_20().Controls.Add(this.vmethod_24());
			this.vmethod_20().Controls.Add(this.vmethod_22());
			this.vmethod_20().Location = new Point(4, 36);
			this.vmethod_20().Name = "TabPage3";
			this.vmethod_20().Padding = new Padding(3);
			this.vmethod_20().Size = new Size(1000, 651);
			this.vmethod_20().TabIndex = 2;
			this.vmethod_20().Text = "Weapon Release Authorization (WRA)";
			this.vmethod_124().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_124().BackColor = Color.Transparent;
			this.vmethod_124().DialogResult = DialogResult.None;
			this.vmethod_124().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_124().ForeColor = SystemColors.Control;
			this.vmethod_124().Location = new Point(542, 628);
			this.vmethod_124().Name = "Button_ResetAffectedMissions_WRA";
			this.vmethod_124().Padding = new Padding(5);
			this.vmethod_124().method_1(0);
			this.vmethod_124().Size = new Size(265, 23);
			this.vmethod_124().TabIndex = 11;
			this.vmethod_124().Text = "Reset affected missions (inherit from above WRA)";
			this.vmethod_126().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_126().BackColor = Color.Transparent;
			this.vmethod_126().DialogResult = DialogResult.None;
			this.vmethod_126().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_126().ForeColor = SystemColors.Control;
			this.vmethod_126().Location = new Point(271, 628);
			this.vmethod_126().Name = "Button_ResetAffectedUnits_WRA";
			this.vmethod_126().Padding = new Padding(5);
			this.vmethod_126().method_1(0);
			this.vmethod_126().Size = new Size(265, 23);
			this.vmethod_126().TabIndex = 10;
			this.vmethod_126().Text = "Reset affected units (inherit from above WRA)";
			this.vmethod_24().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_24().BackColor = Color.Transparent;
			this.vmethod_24().DialogResult = DialogResult.None;
			this.vmethod_24().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_24().ForeColor = SystemColors.Control;
			this.vmethod_24().Location = new Point(0, 628);
			this.vmethod_24().Name = "Button_ResetCurrent_WRA";
			this.vmethod_24().Padding = new Padding(5);
			this.vmethod_24().method_1(0);
			this.vmethod_24().Size = new Size(265, 23);
			this.vmethod_24().TabIndex = 9;
			this.vmethod_24().Text = "Reset WRA (use inherited settings)";
			this.vmethod_164().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_164().Controls.Add(this.vmethod_184());
			this.vmethod_164().Controls.Add(this.vmethod_186());
			this.vmethod_164().Controls.Add(this.vmethod_188());
			this.vmethod_164().Controls.Add(this.vmethod_190());
			this.vmethod_164().Controls.Add(this.vmethod_192());
			this.vmethod_164().Controls.Add(this.vmethod_194());
			this.vmethod_164().Controls.Add(this.vmethod_196());
			this.vmethod_164().Controls.Add(this.vmethod_198());
			this.vmethod_164().Controls.Add(this.vmethod_200());
			this.vmethod_164().Controls.Add(this.vmethod_166());
			this.vmethod_164().Controls.Add(this.vmethod_168());
			this.vmethod_164().Controls.Add(this.vmethod_170());
			this.vmethod_164().Controls.Add(this.vmethod_172());
			this.vmethod_164().Controls.Add(this.vmethod_174());
			this.vmethod_164().Controls.Add(this.vmethod_176());
			this.vmethod_164().Controls.Add(this.vmethod_178());
			this.vmethod_164().Controls.Add(this.vmethod_180());
			this.vmethod_164().Controls.Add(this.vmethod_182());
			this.vmethod_164().Location = new Point(4, 36);
			this.vmethod_164().Name = "TabPage4";
			this.vmethod_164().Size = new Size(1000, 651);
			this.vmethod_164().TabIndex = 3;
			this.vmethod_164().Text = "Withdraw & Redeploy (Ships / Subs / Land)";
			this.vmethod_184().BackColor = Color.Transparent;
			this.vmethod_184().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_184().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_184().Font = new Font("Segoe UI", 7f);
			this.vmethod_184().FormattingEnabled = true;
			this.vmethod_184().Location = new Point(261, 307);
			this.vmethod_184().Name = "Combo_RedeployDefenceThreshold";
			this.vmethod_184().Size = new Size(159, 21);
			this.vmethod_184().TabIndex = 17;
			this.vmethod_186().BackColor = Color.Transparent;
			this.vmethod_186().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_186().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_186().Font = new Font("Segoe UI", 7f);
			this.vmethod_186().FormattingEnabled = true;
			this.vmethod_186().Location = new Point(261, 280);
			this.vmethod_186().Name = "Combo_RedeployAttackThreshold";
			this.vmethod_186().Size = new Size(159, 21);
			this.vmethod_186().TabIndex = 16;
			this.vmethod_188().BackColor = Color.Transparent;
			this.vmethod_188().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_188().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_188().Font = new Font("Segoe UI", 7f);
			this.vmethod_188().FormattingEnabled = true;
			this.vmethod_188().Location = new Point(261, 253);
			this.vmethod_188().Name = "Combo_RedeployFuelThreshold";
			this.vmethod_188().Size = new Size(159, 21);
			this.vmethod_188().TabIndex = 15;
			this.vmethod_190().method_2(true);
			this.vmethod_190().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_190().Location = new Point(10, 310);
			this.vmethod_190().Name = "Label46";
			this.vmethod_190().Size = new Size(247, 13);
			this.vmethod_190().TabIndex = 14;
			this.vmethod_190().Text = "AND the primary defence weapon is at least at:";
			this.vmethod_192().method_2(true);
			this.vmethod_192().Font = new Font("Segoe UI", 16f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_192().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_192().Location = new Point(8, 185);
			this.vmethod_192().Name = "Label47";
			this.vmethod_192().Size = new Size(182, 30);
			this.vmethod_192().TabIndex = 13;
			this.vmethod_192().Text = "Redeploy when....";
			this.vmethod_194().method_2(true);
			this.vmethod_194().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_194().Location = new Point(10, 283);
			this.vmethod_194().Name = "Label48";
			this.vmethod_194().Size = new Size(237, 13);
			this.vmethod_194().TabIndex = 11;
			this.vmethod_194().Text = "AND the primary attack weapon is at least at:";
			this.vmethod_196().method_2(true);
			this.vmethod_196().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_196().Location = new Point(10, 256);
			this.vmethod_196().Name = "Label49";
			this.vmethod_196().Size = new Size(122, 13);
			this.vmethod_196().TabIndex = 12;
			this.vmethod_196().Text = "AND Fuel is at least at:";
			this.vmethod_198().BackColor = Color.Transparent;
			this.vmethod_198().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_198().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_198().Font = new Font("Segoe UI", 7f);
			this.vmethod_198().FormattingEnabled = true;
			this.vmethod_198().Location = new Point(261, 226);
			this.vmethod_198().Name = "Combo_RedeployDamageThreshold";
			this.vmethod_198().Size = new Size(159, 21);
			this.vmethod_198().TabIndex = 10;
			this.vmethod_200().method_2(true);
			this.vmethod_200().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_200().Location = new Point(10, 229);
			this.vmethod_200().Name = "Label50";
			this.vmethod_200().Size = new Size(112, 13);
			this.vmethod_200().TabIndex = 9;
			this.vmethod_200().Text = "Damage is less than:";
			this.vmethod_166().BackColor = Color.Transparent;
			this.vmethod_166().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_166().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_166().Font = new Font("Segoe UI", 7f);
			this.vmethod_166().FormattingEnabled = true;
			this.vmethod_166().Location = new Point(261, 135);
			this.vmethod_166().Name = "Combo_WithdrawDefenceThreshold";
			this.vmethod_166().Size = new Size(159, 21);
			this.vmethod_166().TabIndex = 8;
			this.vmethod_168().BackColor = Color.Transparent;
			this.vmethod_168().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_168().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_168().Font = new Font("Segoe UI", 7f);
			this.vmethod_168().FormattingEnabled = true;
			this.vmethod_168().Location = new Point(261, 108);
			this.vmethod_168().Name = "Combo_WithdrawAttackThreshold";
			this.vmethod_168().Size = new Size(159, 21);
			this.vmethod_168().TabIndex = 7;
			this.vmethod_170().BackColor = Color.Transparent;
			this.vmethod_170().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_170().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_170().Font = new Font("Segoe UI", 7f);
			this.vmethod_170().FormattingEnabled = true;
			this.vmethod_170().Location = new Point(261, 81);
			this.vmethod_170().Name = "Combo_WithdrawFuelThreshold";
			this.vmethod_170().Size = new Size(159, 21);
			this.vmethod_170().TabIndex = 6;
			this.vmethod_172().method_2(true);
			this.vmethod_172().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_172().Location = new Point(10, 138);
			this.vmethod_172().Name = "Label45";
			this.vmethod_172().Size = new Size(249, 13);
			this.vmethod_172().TabIndex = 5;
			this.vmethod_172().Text = "OR the primary defence weapon is at less than:";
			this.vmethod_174().method_2(true);
			this.vmethod_174().Font = new Font("Segoe UI", 16f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_174().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_174().Location = new Point(8, 13);
			this.vmethod_174().Name = "Label43";
			this.vmethod_174().Size = new Size(184, 30);
			this.vmethod_174().TabIndex = 4;
			this.vmethod_174().Text = "Withdraw when....";
			this.vmethod_176().method_2(true);
			this.vmethod_176().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_176().Location = new Point(10, 111);
			this.vmethod_176().Name = "Label44";
			this.vmethod_176().Size = new Size(239, 13);
			this.vmethod_176().TabIndex = 2;
			this.vmethod_176().Text = "OR the primary attack weapon is at less than:";
			this.vmethod_178().method_2(true);
			this.vmethod_178().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_178().Location = new Point(10, 84);
			this.vmethod_178().Name = "Label42";
			this.vmethod_178().Size = new Size(111, 13);
			this.vmethod_178().TabIndex = 2;
			this.vmethod_178().Text = "OR Fuel is less than:";
			this.vmethod_180().BackColor = Color.Transparent;
			this.vmethod_180().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_180().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_180().Font = new Font("Segoe UI", 7f);
			this.vmethod_180().FormattingEnabled = true;
			this.vmethod_180().Location = new Point(261, 54);
			this.vmethod_180().Name = "Combo_WithdrawDamageThreshold";
			this.vmethod_180().Size = new Size(159, 21);
			this.vmethod_180().TabIndex = 1;
			this.vmethod_182().method_2(true);
			this.vmethod_182().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_182().Location = new Point(10, 57);
			this.vmethod_182().Name = "Label41";
			this.vmethod_182().Size = new Size(119, 13);
			this.vmethod_182().TabIndex = 0;
			this.vmethod_182().Text = "Damage is more than:";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1008, 691);
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DoctrineForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "DoctrineForm";
			((ISupportInitialize)this.vmethod_22()).EndInit();
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_26().ResumeLayout(false);
			this.vmethod_26().PerformLayout();
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_4().PerformLayout();
			this.vmethod_20().ResumeLayout(false);
			this.vmethod_164().ResumeLayout(false);
			this.vmethod_164().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x00049456 File Offset: 0x00047656
		[CompilerGenerated]
		internal Control12 vmethod_0()
		{
			return this.control12_0;
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x00403C8C File Offset: 0x00401E8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control12 control12_1)
		{
			EventHandler value = new EventHandler(this.method_15);
			Control12 control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged -= value;
			}
			this.control12_0 = control12_1;
			control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06007661 RID: 30305 RVA: 0x0004945E File Offset: 0x0004765E
		[CompilerGenerated]
		internal TabPage vmethod_2()
		{
			return this.tabPage_0;
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x00049466 File Offset: 0x00047666
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TabPage tabPage_4)
		{
			this.tabPage_0 = tabPage_4;
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x0004946F File Offset: 0x0004766F
		[CompilerGenerated]
		internal TabPage vmethod_4()
		{
			return this.tabPage_1;
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x00049477 File Offset: 0x00047677
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabPage tabPage_4)
		{
			this.tabPage_1 = tabPage_4;
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x00049480 File Offset: 0x00047680
		[CompilerGenerated]
		internal Class2451 vmethod_6()
		{
			return this.class2451_0;
		}

		// Token: 0x06007666 RID: 30310 RVA: 0x00403CD0 File Offset: 0x00401ED0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_54);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_45;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06007667 RID: 30311 RVA: 0x00049488 File Offset: 0x00047688
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_0;
		}

		// Token: 0x06007668 RID: 30312 RVA: 0x00049490 File Offset: 0x00047690
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_56)
		{
			this.class116_0 = class116_56;
		}

		// Token: 0x06007669 RID: 30313 RVA: 0x00049499 File Offset: 0x00047699
		[CompilerGenerated]
		internal Class112 vmethod_10()
		{
			return this.class112_0;
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x00403D14 File Offset: 0x00401F14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_53);
			MouseEventHandler value2 = new MouseEventHandler(this.method_113);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.Click -= value;
				@class.MouseUp -= value2;
			}
			this.class112_0 = class112_35;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.Click += value;
				@class.MouseUp += value2;
			}
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x000494A1 File Offset: 0x000476A1
		[CompilerGenerated]
		internal Class2451 vmethod_12()
		{
			return this.class2451_1;
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x00403D74 File Offset: 0x00401F74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_55);
			Class2451 @class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_1 = class2451_45;
			@class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x000494A9 File Offset: 0x000476A9
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_1;
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x000494B1 File Offset: 0x000476B1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_56)
		{
			this.class116_1 = class116_56;
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x000494BA File Offset: 0x000476BA
		[CompilerGenerated]
		internal Class2451 vmethod_16()
		{
			return this.class2451_2;
		}

		// Token: 0x06007670 RID: 30320 RVA: 0x00403DB8 File Offset: 0x00401FB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_56);
			Class2451 @class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_2 = class2451_45;
			@class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06007671 RID: 30321 RVA: 0x000494C2 File Offset: 0x000476C2
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_2;
		}

		// Token: 0x06007672 RID: 30322 RVA: 0x000494CA File Offset: 0x000476CA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_56)
		{
			this.class116_2 = class116_56;
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x000494D3 File Offset: 0x000476D3
		[CompilerGenerated]
		internal TabPage vmethod_20()
		{
			return this.tabPage_2;
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x000494DB File Offset: 0x000476DB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(TabPage tabPage_4)
		{
			this.tabPage_2 = tabPage_4;
		}

		// Token: 0x06007675 RID: 30325 RVA: 0x000494E4 File Offset: 0x000476E4
		[CompilerGenerated]
		private Class50 vmethod_22()
		{
			return this.class50_0;
		}

		// Token: 0x06007676 RID: 30326 RVA: 0x00403DFC File Offset: 0x00401FFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_23(Class50 class50_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_97);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_98);
			EventHandler value3 = new EventHandler(this.method_99);
			Delegate1 delegate1_ = new Delegate1(this.method_102);
			Delegate3 delegate3_ = new Delegate3(this.method_103);
			DataGridViewDataErrorEventHandler value4 = new DataGridViewDataErrorEventHandler(this.method_118);
			Class50 @class = this.class50_0;
			if (@class != null)
			{
				@class.CellClick -= value;
				@class.CellValueChanged -= value2;
				@class.CurrentCellDirtyStateChanged -= value3;
				@class.method_12(delegate1_);
				@class.method_16(delegate3_);
				@class.DataError -= value4;
			}
			this.class50_0 = class50_1;
			@class = this.class50_0;
			if (@class != null)
			{
				@class.CellClick += value;
				@class.CellValueChanged += value2;
				@class.CurrentCellDirtyStateChanged += value3;
				@class.method_11(delegate1_);
				@class.method_15(delegate3_);
				@class.DataError += value4;
			}
		}

		// Token: 0x06007677 RID: 30327 RVA: 0x000494EC File Offset: 0x000476EC
		[CompilerGenerated]
		internal Control9 vmethod_24()
		{
			return this.control9_0;
		}

		// Token: 0x06007678 RID: 30328 RVA: 0x00403EDC File Offset: 0x004020DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_104);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_9;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x000494F4 File Offset: 0x000476F4
		[CompilerGenerated]
		internal TableLayoutPanel vmethod_26()
		{
			return this.tableLayoutPanel_0;
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x000494FC File Offset: 0x000476FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(TableLayoutPanel tableLayoutPanel_1)
		{
			this.tableLayoutPanel_0 = tableLayoutPanel_1;
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x00049505 File Offset: 0x00047705
		[CompilerGenerated]
		internal Class116 vmethod_28()
		{
			return this.class116_3;
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x0004950D File Offset: 0x0004770D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class116 class116_56)
		{
			this.class116_3 = class116_56;
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x00049516 File Offset: 0x00047716
		[CompilerGenerated]
		internal Class116 vmethod_30()
		{
			return this.class116_4;
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x0004951E File Offset: 0x0004771E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class116 class116_56)
		{
			this.class116_4 = class116_56;
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x00049527 File Offset: 0x00047727
		[CompilerGenerated]
		internal Class116 vmethod_32()
		{
			return this.class116_5;
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x0004952F File Offset: 0x0004772F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class116 class116_56)
		{
			this.class116_5 = class116_56;
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x00049538 File Offset: 0x00047738
		[CompilerGenerated]
		internal Class116 vmethod_34()
		{
			return this.class116_6;
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x00049540 File Offset: 0x00047740
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Class116 class116_56)
		{
			this.class116_6 = class116_56;
		}

		// Token: 0x06007683 RID: 30339 RVA: 0x00049549 File Offset: 0x00047749
		[CompilerGenerated]
		internal Class116 vmethod_36()
		{
			return this.class116_7;
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x00049551 File Offset: 0x00047751
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class116 class116_56)
		{
			this.class116_7 = class116_56;
		}

		// Token: 0x06007685 RID: 30341 RVA: 0x0004955A File Offset: 0x0004775A
		[CompilerGenerated]
		internal Class116 vmethod_38()
		{
			return this.class116_8;
		}

		// Token: 0x06007686 RID: 30342 RVA: 0x00049562 File Offset: 0x00047762
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Class116 class116_56)
		{
			this.class116_8 = class116_56;
		}

		// Token: 0x06007687 RID: 30343 RVA: 0x0004956B File Offset: 0x0004776B
		[CompilerGenerated]
		internal Class116 vmethod_40()
		{
			return this.class116_9;
		}

		// Token: 0x06007688 RID: 30344 RVA: 0x00049573 File Offset: 0x00047773
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Class116 class116_56)
		{
			this.class116_9 = class116_56;
		}

		// Token: 0x06007689 RID: 30345 RVA: 0x0004957C File Offset: 0x0004777C
		[CompilerGenerated]
		internal Class112 vmethod_42()
		{
			return this.class112_1;
		}

		// Token: 0x0600768A RID: 30346 RVA: 0x00403F20 File Offset: 0x00402120
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_52);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_1 = class112_35;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x00049584 File Offset: 0x00047784
		[CompilerGenerated]
		internal Class116 vmethod_44()
		{
			return this.class116_10;
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x0004958C File Offset: 0x0004778C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Class116 class116_56)
		{
			this.class116_10 = class116_56;
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x00049595 File Offset: 0x00047795
		[CompilerGenerated]
		internal Class112 vmethod_46()
		{
			return this.class112_2;
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x00403F64 File Offset: 0x00402164
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_20);
			Class112 @class = this.class112_2;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_2 = class112_35;
			@class = this.class112_2;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x0004959D File Offset: 0x0004779D
		[CompilerGenerated]
		internal Class112 vmethod_48()
		{
			return this.class112_3;
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x00403FA8 File Offset: 0x004021A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_17);
			Class112 @class = this.class112_3;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_3 = class112_35;
			@class = this.class112_3;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007691 RID: 30353 RVA: 0x000495A5 File Offset: 0x000477A5
		[CompilerGenerated]
		internal Class116 vmethod_50()
		{
			return this.class116_11;
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x000495AD File Offset: 0x000477AD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(Class116 class116_56)
		{
			this.class116_11 = class116_56;
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x000495B6 File Offset: 0x000477B6
		[CompilerGenerated]
		internal Class2451 vmethod_52()
		{
			return this.class2451_3;
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x00403FEC File Offset: 0x004021EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_57);
			EventHandler value2 = new EventHandler(this.method_58);
			Class2451 @class = this.class2451_3;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_3 = class2451_45;
			@class = this.class2451_3;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06007695 RID: 30357 RVA: 0x000495BE File Offset: 0x000477BE
		[CompilerGenerated]
		internal Class2451 vmethod_54()
		{
			return this.class2451_4;
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x0040404C File Offset: 0x0040224C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_35);
			EventHandler value2 = new EventHandler(this.method_46);
			Class2451 @class = this.class2451_4;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_4 = class2451_45;
			@class = this.class2451_4;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x000495C6 File Offset: 0x000477C6
		[CompilerGenerated]
		internal Class2451 vmethod_56()
		{
			return this.class2451_5;
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x004040AC File Offset: 0x004022AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_29);
			EventHandler value2 = new EventHandler(this.method_40);
			Class2451 @class = this.class2451_5;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_5 = class2451_45;
			@class = this.class2451_5;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06007699 RID: 30361 RVA: 0x000495CE File Offset: 0x000477CE
		[CompilerGenerated]
		internal Class116 vmethod_58()
		{
			return this.class116_12;
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x000495D6 File Offset: 0x000477D6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(Class116 class116_56)
		{
			this.class116_12 = class116_56;
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x000495DF File Offset: 0x000477DF
		[CompilerGenerated]
		internal Class2451 vmethod_60()
		{
			return this.class2451_6;
		}

		// Token: 0x0600769C RID: 30364 RVA: 0x0040410C File Offset: 0x0040230C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_65);
			EventHandler value2 = new EventHandler(this.method_66);
			Class2451 @class = this.class2451_6;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_6 = class2451_45;
			@class = this.class2451_6;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x000495E7 File Offset: 0x000477E7
		[CompilerGenerated]
		internal Class112 vmethod_62()
		{
			return this.class112_4;
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x0040416C File Offset: 0x0040236C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_67);
			Class112 @class = this.class112_4;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_4 = class112_35;
			@class = this.class112_4;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x000495EF File Offset: 0x000477EF
		[CompilerGenerated]
		internal Class116 vmethod_64()
		{
			return this.class116_13;
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x000495F7 File Offset: 0x000477F7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Class116 class116_56)
		{
			this.class116_13 = class116_56;
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x00049600 File Offset: 0x00047800
		[CompilerGenerated]
		internal Class2451 vmethod_66()
		{
			return this.class2451_7;
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x004041B0 File Offset: 0x004023B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_68);
			EventHandler value2 = new EventHandler(this.method_69);
			Class2451 @class = this.class2451_7;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_7 = class2451_45;
			@class = this.class2451_7;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x00049608 File Offset: 0x00047808
		[CompilerGenerated]
		internal Class112 vmethod_68()
		{
			return this.class112_5;
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x00404210 File Offset: 0x00402410
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_70);
			Class112 @class = this.class112_5;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_5 = class112_35;
			@class = this.class112_5;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x00049610 File Offset: 0x00047810
		[CompilerGenerated]
		internal Class2451 vmethod_70()
		{
			return this.class2451_8;
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x00404254 File Offset: 0x00402454
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_72);
			EventHandler value2 = new EventHandler(this.method_139);
			Class2451 @class = this.class2451_8;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
				@class.Enter -= value2;
			}
			this.class2451_8 = class2451_45;
			@class = this.class2451_8;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
				@class.Enter += value2;
			}
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x00049618 File Offset: 0x00047818
		[CompilerGenerated]
		internal Class112 vmethod_72()
		{
			return this.class112_6;
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x004042B4 File Offset: 0x004024B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_71);
			Class112 @class = this.class112_6;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_6 = class112_35;
			@class = this.class112_6;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x00049620 File Offset: 0x00047820
		[CompilerGenerated]
		internal Class2451 vmethod_74()
		{
			return this.class2451_9;
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x004042F8 File Offset: 0x004024F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_75);
			EventHandler value2 = new EventHandler(this.method_76);
			Class2451 @class = this.class2451_9;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_9 = class2451_45;
			@class = this.class2451_9;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x00049628 File Offset: 0x00047828
		[CompilerGenerated]
		internal Class112 vmethod_76()
		{
			return this.class112_7;
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x00404358 File Offset: 0x00402558
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_25);
			Class112 @class = this.class112_7;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_7 = class112_35;
			@class = this.class112_7;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x00049630 File Offset: 0x00047830
		[CompilerGenerated]
		internal Class2451 vmethod_78()
		{
			return this.class2451_10;
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x0040439C File Offset: 0x0040259C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_73);
			EventHandler value2 = new EventHandler(this.method_74);
			Class2451 @class = this.class2451_10;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_10 = class2451_45;
			@class = this.class2451_10;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x00049638 File Offset: 0x00047838
		[CompilerGenerated]
		internal Class112 vmethod_80()
		{
			return this.class112_8;
		}

		// Token: 0x060076B0 RID: 30384 RVA: 0x004043FC File Offset: 0x004025FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_85);
			Class112 @class = this.class112_8;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_8 = class112_35;
			@class = this.class112_8;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060076B1 RID: 30385 RVA: 0x00049640 File Offset: 0x00047840
		[CompilerGenerated]
		internal Class2451 vmethod_82()
		{
			return this.class2451_11;
		}

		// Token: 0x060076B2 RID: 30386 RVA: 0x00404440 File Offset: 0x00402640
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_86);
			EventHandler value2 = new EventHandler(this.method_87);
			EventHandler value3 = new EventHandler(this.method_88);
			Class2451 @class = this.class2451_11;
			if (@class != null)
			{
				@class.Click -= value;
				@class.Enter -= value2;
				@class.SelectionChangeCommitted -= value3;
			}
			this.class2451_11 = class2451_45;
			@class = this.class2451_11;
			if (@class != null)
			{
				@class.Click += value;
				@class.Enter += value2;
				@class.SelectionChangeCommitted += value3;
			}
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x00049648 File Offset: 0x00047848
		[CompilerGenerated]
		internal Class112 vmethod_84()
		{
			return this.class112_9;
		}

		// Token: 0x060076B4 RID: 30388 RVA: 0x004044BC File Offset: 0x004026BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_27);
			EventHandler value2 = new EventHandler(this.method_27);
			Class112 @class = this.class112_9;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
				@class.Click -= value2;
			}
			this.class112_9 = class112_35;
			@class = this.class112_9;
			if (@class != null)
			{
				@class.CheckedChanged += value;
				@class.Click += value2;
			}
		}

		// Token: 0x060076B5 RID: 30389 RVA: 0x00049650 File Offset: 0x00047850
		[CompilerGenerated]
		internal Class2451 vmethod_86()
		{
			return this.class2451_12;
		}

		// Token: 0x060076B6 RID: 30390 RVA: 0x0040451C File Offset: 0x0040271C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_89);
			EventHandler value2 = new EventHandler(this.method_90);
			EventHandler value3 = new EventHandler(this.method_91);
			Class2451 @class = this.class2451_12;
			if (@class != null)
			{
				@class.Click -= value;
				@class.Enter -= value2;
				@class.SelectionChangeCommitted -= value3;
			}
			this.class2451_12 = class2451_45;
			@class = this.class2451_12;
			if (@class != null)
			{
				@class.Click += value;
				@class.Enter += value2;
				@class.SelectionChangeCommitted += value3;
			}
		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x00049658 File Offset: 0x00047858
		[CompilerGenerated]
		internal Class112 vmethod_88()
		{
			return this.class112_10;
		}

		// Token: 0x060076B8 RID: 30392 RVA: 0x00404598 File Offset: 0x00402798
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_24);
			Class112 @class = this.class112_10;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_10 = class112_35;
			@class = this.class112_10;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x00049660 File Offset: 0x00047860
		[CompilerGenerated]
		internal Class116 vmethod_90()
		{
			return this.class116_14;
		}

		// Token: 0x060076BA RID: 30394 RVA: 0x00049668 File Offset: 0x00047868
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(Class116 class116_56)
		{
			this.class116_14 = class116_56;
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x00049671 File Offset: 0x00047871
		[CompilerGenerated]
		internal Class2451 vmethod_92()
		{
			return this.class2451_13;
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x004045DC File Offset: 0x004027DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_30);
			EventHandler value2 = new EventHandler(this.method_41);
			Class2451 @class = this.class2451_13;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_13 = class2451_45;
			@class = this.class2451_13;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x060076BD RID: 30397 RVA: 0x00049679 File Offset: 0x00047879
		[CompilerGenerated]
		internal Class2451 vmethod_94()
		{
			return this.class2451_14;
		}

		// Token: 0x060076BE RID: 30398 RVA: 0x0040463C File Offset: 0x0040283C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_34);
			EventHandler value2 = new EventHandler(this.method_45);
			Class2451 @class = this.class2451_14;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_14 = class2451_45;
			@class = this.class2451_14;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x060076BF RID: 30399 RVA: 0x00049681 File Offset: 0x00047881
		[CompilerGenerated]
		internal Class112 vmethod_96()
		{
			return this.class112_11;
		}

		// Token: 0x060076C0 RID: 30400 RVA: 0x0040469C File Offset: 0x0040289C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_93);
			Class112 @class = this.class112_11;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_11 = class112_35;
			@class = this.class112_11;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x00049689 File Offset: 0x00047889
		[CompilerGenerated]
		internal Class112 vmethod_98()
		{
			return this.class112_12;
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x004046E0 File Offset: 0x004028E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_99(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_96);
			Class112 @class = this.class112_12;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_12 = class112_35;
			@class = this.class112_12;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060076C3 RID: 30403 RVA: 0x00049691 File Offset: 0x00047891
		[CompilerGenerated]
		internal Class116 vmethod_100()
		{
			return this.class116_15;
		}

		// Token: 0x060076C4 RID: 30404 RVA: 0x00049699 File Offset: 0x00047899
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_101(Class116 class116_56)
		{
			this.class116_15 = class116_56;
		}

		// Token: 0x060076C5 RID: 30405 RVA: 0x000496A2 File Offset: 0x000478A2
		[CompilerGenerated]
		internal Class2451 vmethod_102()
		{
			return this.class2451_15;
		}

		// Token: 0x060076C6 RID: 30406 RVA: 0x00404724 File Offset: 0x00402924
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_103(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_31);
			EventHandler value2 = new EventHandler(this.method_42);
			Class2451 @class = this.class2451_15;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_15 = class2451_45;
			@class = this.class2451_15;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x060076C7 RID: 30407 RVA: 0x000496AA File Offset: 0x000478AA
		[CompilerGenerated]
		internal Class112 vmethod_104()
		{
			return this.class112_13;
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x00404784 File Offset: 0x00402984
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_105(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_92);
			Class112 @class = this.class112_13;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_13 = class112_35;
			@class = this.class112_13;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060076C9 RID: 30409 RVA: 0x000496B2 File Offset: 0x000478B2
		[CompilerGenerated]
		internal Class116 vmethod_106()
		{
			return this.class116_16;
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x000496BA File Offset: 0x000478BA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_107(Class116 class116_56)
		{
			this.class116_16 = class116_56;
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x000496C3 File Offset: 0x000478C3
		[CompilerGenerated]
		internal Class116 vmethod_108()
		{
			return this.class116_17;
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x000496CB File Offset: 0x000478CB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_109(Class116 class116_56)
		{
			this.class116_17 = class116_56;
		}

		// Token: 0x060076CD RID: 30413 RVA: 0x000496D4 File Offset: 0x000478D4
		[CompilerGenerated]
		internal Class116 vmethod_110()
		{
			return this.class116_18;
		}

		// Token: 0x060076CE RID: 30414 RVA: 0x000496DC File Offset: 0x000478DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_111(Class116 class116_56)
		{
			this.class116_18 = class116_56;
		}

		// Token: 0x060076CF RID: 30415 RVA: 0x000496E5 File Offset: 0x000478E5
		[CompilerGenerated]
		internal Class116 vmethod_112()
		{
			return this.class116_19;
		}

		// Token: 0x060076D0 RID: 30416 RVA: 0x000496ED File Offset: 0x000478ED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_113(Class116 class116_56)
		{
			this.class116_19 = class116_56;
		}

		// Token: 0x060076D1 RID: 30417 RVA: 0x000496F6 File Offset: 0x000478F6
		[CompilerGenerated]
		internal Class116 vmethod_114()
		{
			return this.class116_20;
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x000496FE File Offset: 0x000478FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_115(Class116 class116_56)
		{
			this.class116_20 = class116_56;
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x00049707 File Offset: 0x00047907
		[CompilerGenerated]
		internal Class116 vmethod_116()
		{
			return this.class116_21;
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x0004970F File Offset: 0x0004790F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_117(Class116 class116_56)
		{
			this.class116_21 = class116_56;
		}

		// Token: 0x060076D5 RID: 30421 RVA: 0x00049718 File Offset: 0x00047918
		[CompilerGenerated]
		internal Control9 vmethod_118()
		{
			return this.control9_1;
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x004047C8 File Offset: 0x004029C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_119(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_109);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_9;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x00049720 File Offset: 0x00047920
		[CompilerGenerated]
		internal Control9 vmethod_120()
		{
			return this.control9_2;
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x0040480C File Offset: 0x00402A0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_121(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_108);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_9;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x00049728 File Offset: 0x00047928
		[CompilerGenerated]
		internal Control9 vmethod_122()
		{
			return this.control9_3;
		}

		// Token: 0x060076DA RID: 30426 RVA: 0x00404850 File Offset: 0x00402A50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_123(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_107);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_9;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060076DB RID: 30427 RVA: 0x00049730 File Offset: 0x00047930
		[CompilerGenerated]
		internal Control9 vmethod_124()
		{
			return this.control9_4;
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x00404894 File Offset: 0x00402A94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_125(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_106);
			Control9 control = this.control9_4;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_4 = control9_9;
			control = this.control9_4;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060076DD RID: 30429 RVA: 0x00049738 File Offset: 0x00047938
		[CompilerGenerated]
		internal Control9 vmethod_126()
		{
			return this.control9_5;
		}

		// Token: 0x060076DE RID: 30430 RVA: 0x004048D8 File Offset: 0x00402AD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_127(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_105);
			Control9 control = this.control9_5;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_5 = control9_9;
			control = this.control9_5;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x00049740 File Offset: 0x00047940
		[CompilerGenerated]
		internal Control9 vmethod_128()
		{
			return this.control9_6;
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x0040491C File Offset: 0x00402B1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_129(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_112);
			Control9 control = this.control9_6;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_6 = control9_9;
			control = this.control9_6;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060076E1 RID: 30433 RVA: 0x00049748 File Offset: 0x00047948
		[CompilerGenerated]
		internal Control9 vmethod_130()
		{
			return this.control9_7;
		}

		// Token: 0x060076E2 RID: 30434 RVA: 0x00404960 File Offset: 0x00402B60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_131(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_111);
			Control9 control = this.control9_7;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_7 = control9_9;
			control = this.control9_7;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060076E3 RID: 30435 RVA: 0x00049750 File Offset: 0x00047950
		[CompilerGenerated]
		internal Control9 vmethod_132()
		{
			return this.control9_8;
		}

		// Token: 0x060076E4 RID: 30436 RVA: 0x004049A4 File Offset: 0x00402BA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_133(Control9 control9_9)
		{
			EventHandler value = new EventHandler(this.method_110);
			Control9 control = this.control9_8;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_8 = control9_9;
			control = this.control9_8;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x00049758 File Offset: 0x00047958
		[CompilerGenerated]
		internal Class116 vmethod_134()
		{
			return this.class116_22;
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x00049760 File Offset: 0x00047960
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_135(Class116 class116_56)
		{
			this.class116_22 = class116_56;
		}

		// Token: 0x060076E7 RID: 30439 RVA: 0x00049769 File Offset: 0x00047969
		[CompilerGenerated]
		internal Class2451 vmethod_136()
		{
			return this.class2451_16;
		}

		// Token: 0x060076E8 RID: 30440 RVA: 0x004049E8 File Offset: 0x00402BE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_137(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_19);
			EventHandler value2 = new EventHandler(this.method_51);
			Class2451 @class = this.class2451_16;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_16 = class2451_45;
			@class = this.class2451_16;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x00049771 File Offset: 0x00047971
		[CompilerGenerated]
		internal Class112 vmethod_138()
		{
			return this.class112_14;
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x00404A48 File Offset: 0x00402C48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_139(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_18);
			Class112 @class = this.class112_14;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_14 = class112_35;
			@class = this.class112_14;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x00049779 File Offset: 0x00047979
		[CompilerGenerated]
		internal Class116 vmethod_140()
		{
			return this.class116_23;
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x00049781 File Offset: 0x00047981
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_141(Class116 class116_56)
		{
			this.class116_23 = class116_56;
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x0004978A File Offset: 0x0004798A
		[CompilerGenerated]
		internal Class116 vmethod_142()
		{
			return this.class116_24;
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x00049792 File Offset: 0x00047992
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_143(Class116 class116_56)
		{
			this.class116_24 = class116_56;
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x0004979B File Offset: 0x0004799B
		[CompilerGenerated]
		internal Class116 vmethod_144()
		{
			return this.class116_25;
		}

		// Token: 0x060076F0 RID: 30448 RVA: 0x000497A3 File Offset: 0x000479A3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_145(Class116 class116_56)
		{
			this.class116_25 = class116_56;
		}

		// Token: 0x060076F1 RID: 30449 RVA: 0x000497AC File Offset: 0x000479AC
		[CompilerGenerated]
		internal Class112 vmethod_146()
		{
			return this.class112_15;
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x00404A8C File Offset: 0x00402C8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_147(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_21);
			Class112 @class = this.class112_15;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_15 = class112_35;
			@class = this.class112_15;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x000497B4 File Offset: 0x000479B4
		[CompilerGenerated]
		internal Class112 vmethod_148()
		{
			return this.class112_16;
		}

		// Token: 0x060076F4 RID: 30452 RVA: 0x00404AD0 File Offset: 0x00402CD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_149(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_22);
			Class112 @class = this.class112_16;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_16 = class112_35;
			@class = this.class112_16;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060076F5 RID: 30453 RVA: 0x000497BC File Offset: 0x000479BC
		[CompilerGenerated]
		internal Class112 vmethod_150()
		{
			return this.class112_17;
		}

		// Token: 0x060076F6 RID: 30454 RVA: 0x00404B14 File Offset: 0x00402D14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_151(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_23);
			Class112 @class = this.class112_17;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_17 = class112_35;
			@class = this.class112_17;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x000497C4 File Offset: 0x000479C4
		[CompilerGenerated]
		internal Class2451 vmethod_152()
		{
			return this.class2451_17;
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x00404B58 File Offset: 0x00402D58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_153(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_36);
			EventHandler value2 = new EventHandler(this.method_47);
			Class2451 @class = this.class2451_17;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_17 = class2451_45;
			@class = this.class2451_17;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x000497CC File Offset: 0x000479CC
		[CompilerGenerated]
		internal Class2451 vmethod_154()
		{
			return this.class2451_18;
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x00404BB8 File Offset: 0x00402DB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_155(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_37);
			EventHandler value2 = new EventHandler(this.method_48);
			Class2451 @class = this.class2451_18;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_18 = class2451_45;
			@class = this.class2451_18;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x000497D4 File Offset: 0x000479D4
		[CompilerGenerated]
		internal Class2451 vmethod_156()
		{
			return this.class2451_19;
		}

		// Token: 0x060076FC RID: 30460 RVA: 0x00404C18 File Offset: 0x00402E18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_157(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_38);
			EventHandler value2 = new EventHandler(this.method_49);
			Class2451 @class = this.class2451_19;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_19 = class2451_45;
			@class = this.class2451_19;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x060076FD RID: 30461 RVA: 0x000497DC File Offset: 0x000479DC
		[CompilerGenerated]
		internal Class116 vmethod_158()
		{
			return this.class116_26;
		}

		// Token: 0x060076FE RID: 30462 RVA: 0x000497E4 File Offset: 0x000479E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_159(Class116 class116_56)
		{
			this.class116_26 = class116_56;
		}

		// Token: 0x060076FF RID: 30463 RVA: 0x000497ED File Offset: 0x000479ED
		[CompilerGenerated]
		internal Class112 vmethod_160()
		{
			return this.class112_18;
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x00404C78 File Offset: 0x00402E78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_161(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_28);
			Class112 @class = this.class112_18;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_18 = class112_35;
			@class = this.class112_18;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x000497F5 File Offset: 0x000479F5
		[CompilerGenerated]
		internal Class2451 vmethod_162()
		{
			return this.class2451_20;
		}

		// Token: 0x06007702 RID: 30466 RVA: 0x00404CBC File Offset: 0x00402EBC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_163(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_39);
			EventHandler value2 = new EventHandler(this.method_50);
			Class2451 @class = this.class2451_20;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_20 = class2451_45;
			@class = this.class2451_20;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06007703 RID: 30467 RVA: 0x000497FD File Offset: 0x000479FD
		[CompilerGenerated]
		internal TabPage vmethod_164()
		{
			return this.tabPage_3;
		}

		// Token: 0x06007704 RID: 30468 RVA: 0x00049805 File Offset: 0x00047A05
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_165(TabPage tabPage_4)
		{
			this.tabPage_3 = tabPage_4;
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x0004980E File Offset: 0x00047A0E
		[CompilerGenerated]
		internal Class2451 vmethod_166()
		{
			return this.class2451_21;
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x00404D1C File Offset: 0x00402F1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_167(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_156);
			EventHandler value2 = new EventHandler(this.method_157);
			Class2451 @class = this.class2451_21;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_21 = class2451_45;
			@class = this.class2451_21;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x00049816 File Offset: 0x00047A16
		[CompilerGenerated]
		internal Class2451 vmethod_168()
		{
			return this.class2451_22;
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x00404D7C File Offset: 0x00402F7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_169(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_152);
			EventHandler value2 = new EventHandler(this.method_153);
			Class2451 @class = this.class2451_22;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_22 = class2451_45;
			@class = this.class2451_22;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x0004981E File Offset: 0x00047A1E
		[CompilerGenerated]
		internal Class2451 vmethod_170()
		{
			return this.class2451_23;
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x00404DDC File Offset: 0x00402FDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_171(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_148);
			EventHandler value2 = new EventHandler(this.method_149);
			Class2451 @class = this.class2451_23;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_23 = class2451_45;
			@class = this.class2451_23;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x0600770B RID: 30475 RVA: 0x00049826 File Offset: 0x00047A26
		[CompilerGenerated]
		internal Class116 vmethod_172()
		{
			return this.class116_27;
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x0004982E File Offset: 0x00047A2E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_173(Class116 class116_56)
		{
			this.class116_27 = class116_56;
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x00049837 File Offset: 0x00047A37
		[CompilerGenerated]
		internal Class116 vmethod_174()
		{
			return this.class116_28;
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x0004983F File Offset: 0x00047A3F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_175(Class116 class116_56)
		{
			this.class116_28 = class116_56;
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x00049848 File Offset: 0x00047A48
		[CompilerGenerated]
		internal Class116 vmethod_176()
		{
			return this.class116_29;
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x00049850 File Offset: 0x00047A50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_177(Class116 class116_56)
		{
			this.class116_29 = class116_56;
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x00049859 File Offset: 0x00047A59
		[CompilerGenerated]
		internal Class116 vmethod_178()
		{
			return this.class116_30;
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x00049861 File Offset: 0x00047A61
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_179(Class116 class116_56)
		{
			this.class116_30 = class116_56;
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x0004986A File Offset: 0x00047A6A
		[CompilerGenerated]
		internal Class2451 vmethod_180()
		{
			return this.class2451_24;
		}

		// Token: 0x06007714 RID: 30484 RVA: 0x00404E3C File Offset: 0x0040303C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_181(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_144);
			EventHandler value2 = new EventHandler(this.method_146);
			Class2451 @class = this.class2451_24;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_24 = class2451_45;
			@class = this.class2451_24;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x00049872 File Offset: 0x00047A72
		[CompilerGenerated]
		internal Class116 vmethod_182()
		{
			return this.class116_31;
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x0004987A File Offset: 0x00047A7A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_183(Class116 class116_56)
		{
			this.class116_31 = class116_56;
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x00049883 File Offset: 0x00047A83
		[CompilerGenerated]
		internal Class2451 vmethod_184()
		{
			return this.class2451_25;
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x00404E9C File Offset: 0x0040309C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_185(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_158);
			EventHandler value2 = new EventHandler(this.method_159);
			Class2451 @class = this.class2451_25;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_25 = class2451_45;
			@class = this.class2451_25;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x0004988B File Offset: 0x00047A8B
		[CompilerGenerated]
		internal Class2451 vmethod_186()
		{
			return this.class2451_26;
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x00404EFC File Offset: 0x004030FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_187(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_154);
			EventHandler value2 = new EventHandler(this.method_155);
			Class2451 @class = this.class2451_26;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_26 = class2451_45;
			@class = this.class2451_26;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x0600771B RID: 30491 RVA: 0x00049893 File Offset: 0x00047A93
		[CompilerGenerated]
		internal Class2451 vmethod_188()
		{
			return this.class2451_27;
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x00404F5C File Offset: 0x0040315C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_189(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_150);
			EventHandler value2 = new EventHandler(this.method_151);
			Class2451 @class = this.class2451_27;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_27 = class2451_45;
			@class = this.class2451_27;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x0004989B File Offset: 0x00047A9B
		[CompilerGenerated]
		internal Class116 vmethod_190()
		{
			return this.class116_32;
		}

		// Token: 0x0600771E RID: 30494 RVA: 0x000498A3 File Offset: 0x00047AA3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_191(Class116 class116_56)
		{
			this.class116_32 = class116_56;
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x000498AC File Offset: 0x00047AAC
		[CompilerGenerated]
		internal Class116 vmethod_192()
		{
			return this.class116_33;
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x000498B4 File Offset: 0x00047AB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_193(Class116 class116_56)
		{
			this.class116_33 = class116_56;
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x000498BD File Offset: 0x00047ABD
		[CompilerGenerated]
		internal Class116 vmethod_194()
		{
			return this.class116_34;
		}

		// Token: 0x06007722 RID: 30498 RVA: 0x000498C5 File Offset: 0x00047AC5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_195(Class116 class116_56)
		{
			this.class116_34 = class116_56;
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x000498CE File Offset: 0x00047ACE
		[CompilerGenerated]
		internal Class116 vmethod_196()
		{
			return this.class116_35;
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x000498D6 File Offset: 0x00047AD6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_197(Class116 class116_56)
		{
			this.class116_35 = class116_56;
		}

		// Token: 0x06007725 RID: 30501 RVA: 0x000498DF File Offset: 0x00047ADF
		[CompilerGenerated]
		internal Class2451 vmethod_198()
		{
			return this.class2451_28;
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x00404FBC File Offset: 0x004031BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_199(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_145);
			EventHandler value2 = new EventHandler(this.method_147);
			Class2451 @class = this.class2451_28;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_28 = class2451_45;
			@class = this.class2451_28;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x000498E7 File Offset: 0x00047AE7
		[CompilerGenerated]
		internal Class116 vmethod_200()
		{
			return this.class116_36;
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x000498EF File Offset: 0x00047AEF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_201(Class116 class116_56)
		{
			this.class116_36 = class116_56;
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x000498F8 File Offset: 0x00047AF8
		[CompilerGenerated]
		internal Class44 vmethod_202()
		{
			return this.class44_0;
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00049900 File Offset: 0x00047B00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_203(Class44 class44_1)
		{
			this.class44_0 = class44_1;
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x00049909 File Offset: 0x00047B09
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_204()
		{
			return this.dataGridViewComboBoxColumn_0;
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x00049911 File Offset: 0x00047B11
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_205(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_0 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x0004991A File Offset: 0x00047B1A
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_206()
		{
			return this.dataGridViewComboBoxColumn_1;
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x00049922 File Offset: 0x00047B22
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_207(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_1 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x0600772F RID: 30511 RVA: 0x0004992B File Offset: 0x00047B2B
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_208()
		{
			return this.dataGridViewComboBoxColumn_2;
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x00049933 File Offset: 0x00047B33
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_209(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_2 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x0004993C File Offset: 0x00047B3C
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_210()
		{
			return this.dataGridViewComboBoxColumn_3;
		}

		// Token: 0x06007732 RID: 30514 RVA: 0x00049944 File Offset: 0x00047B44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_211(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_3 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x0004994D File Offset: 0x00047B4D
		[CompilerGenerated]
		internal Class116 vmethod_212()
		{
			return this.class116_37;
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x00049955 File Offset: 0x00047B55
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_213(Class116 class116_56)
		{
			this.class116_37 = class116_56;
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x0004995E File Offset: 0x00047B5E
		[CompilerGenerated]
		internal Class112 vmethod_214()
		{
			return this.class112_19;
		}

		// Token: 0x06007736 RID: 30518 RVA: 0x0040501C File Offset: 0x0040321C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_215(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_26);
			Class112 @class = this.class112_19;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_19 = class112_35;
			@class = this.class112_19;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06007737 RID: 30519 RVA: 0x00049966 File Offset: 0x00047B66
		[CompilerGenerated]
		internal Class2451 vmethod_216()
		{
			return this.class2451_29;
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x00405060 File Offset: 0x00403260
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_217(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_77);
			EventHandler value2 = new EventHandler(this.method_78);
			Class2451 @class = this.class2451_29;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_29 = class2451_45;
			@class = this.class2451_29;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x0004996E File Offset: 0x00047B6E
		[CompilerGenerated]
		internal Class116 vmethod_218()
		{
			return this.class116_38;
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x00049976 File Offset: 0x00047B76
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_219(Class116 class116_56)
		{
			this.class116_38 = class116_56;
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x0004997F File Offset: 0x00047B7F
		[CompilerGenerated]
		internal Class116 vmethod_220()
		{
			return this.class116_39;
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x00049987 File Offset: 0x00047B87
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_221(Class116 class116_56)
		{
			this.class116_39 = class116_56;
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00049990 File Offset: 0x00047B90
		[CompilerGenerated]
		internal Class116 vmethod_222()
		{
			return this.class116_40;
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x00049998 File Offset: 0x00047B98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_223(Class116 class116_56)
		{
			this.class116_40 = class116_56;
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x000499A1 File Offset: 0x00047BA1
		[CompilerGenerated]
		internal Class112 vmethod_224()
		{
			return this.class112_20;
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x004050C0 File Offset: 0x004032C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_225(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_95);
			Class112 @class = this.class112_20;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_20 = class112_35;
			@class = this.class112_20;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x000499A9 File Offset: 0x00047BA9
		[CompilerGenerated]
		internal Class112 vmethod_226()
		{
			return this.class112_21;
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x00405104 File Offset: 0x00403304
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_227(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_94);
			Class112 @class = this.class112_21;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_21 = class112_35;
			@class = this.class112_21;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x000499B1 File Offset: 0x00047BB1
		[CompilerGenerated]
		internal Class116 vmethod_228()
		{
			return this.class116_41;
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x000499B9 File Offset: 0x00047BB9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_229(Class116 class116_56)
		{
			this.class116_41 = class116_56;
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x000499C2 File Offset: 0x00047BC2
		[CompilerGenerated]
		internal Class112 vmethod_230()
		{
			return this.class112_22;
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x00405148 File Offset: 0x00403348
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_231(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_120);
			Class112 @class = this.class112_22;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_22 = class112_35;
			@class = this.class112_22;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x000499CA File Offset: 0x00047BCA
		[CompilerGenerated]
		internal Class112 vmethod_232()
		{
			return this.class112_23;
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x0040518C File Offset: 0x0040338C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_233(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_119);
			Class112 @class = this.class112_23;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_23 = class112_35;
			@class = this.class112_23;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x000499D2 File Offset: 0x00047BD2
		[CompilerGenerated]
		internal Class116 vmethod_234()
		{
			return this.class116_42;
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x000499DA File Offset: 0x00047BDA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_235(Class116 class116_56)
		{
			this.class116_42 = class116_56;
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x000499E3 File Offset: 0x00047BE3
		[CompilerGenerated]
		internal Class116 vmethod_236()
		{
			return this.class116_43;
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x000499EB File Offset: 0x00047BEB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_237(Class116 class116_56)
		{
			this.class116_43 = class116_56;
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x000499F4 File Offset: 0x00047BF4
		[CompilerGenerated]
		internal Class116 vmethod_238()
		{
			return this.class116_44;
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x000499FC File Offset: 0x00047BFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_239(Class116 class116_56)
		{
			this.class116_44 = class116_56;
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x00049A05 File Offset: 0x00047C05
		[CompilerGenerated]
		internal Class112 vmethod_240()
		{
			return this.class112_24;
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x004051D0 File Offset: 0x004033D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_241(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_121);
			Class112 @class = this.class112_24;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_24 = class112_35;
			@class = this.class112_24;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x00049A0D File Offset: 0x00047C0D
		[CompilerGenerated]
		internal Class116 vmethod_242()
		{
			return this.class116_45;
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x00049A15 File Offset: 0x00047C15
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_243(Class116 class116_56)
		{
			this.class116_45 = class116_56;
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x00049A1E File Offset: 0x00047C1E
		[CompilerGenerated]
		internal Class116 vmethod_244()
		{
			return this.class116_46;
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x00049A26 File Offset: 0x00047C26
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_245(Class116 class116_56)
		{
			this.class116_46 = class116_56;
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x00049A2F File Offset: 0x00047C2F
		[CompilerGenerated]
		internal Class112 vmethod_246()
		{
			return this.class112_25;
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x00405214 File Offset: 0x00403414
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_247(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_122);
			Class112 @class = this.class112_25;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_25 = class112_35;
			@class = this.class112_25;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00049A37 File Offset: 0x00047C37
		[CompilerGenerated]
		internal Class112 vmethod_248()
		{
			return this.class112_26;
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x00405258 File Offset: 0x00403458
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_249(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_123);
			Class112 @class = this.class112_26;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_26 = class112_35;
			@class = this.class112_26;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00049A3F File Offset: 0x00047C3F
		[CompilerGenerated]
		internal Class116 vmethod_250()
		{
			return this.class116_47;
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x00049A47 File Offset: 0x00047C47
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_251(Class116 class116_56)
		{
			this.class116_47 = class116_56;
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x00049A50 File Offset: 0x00047C50
		[CompilerGenerated]
		internal Class112 vmethod_252()
		{
			return this.class112_27;
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x0040529C File Offset: 0x0040349C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_253(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_124);
			Class112 @class = this.class112_27;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_27 = class112_35;
			@class = this.class112_27;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x00049A58 File Offset: 0x00047C58
		[CompilerGenerated]
		internal Class116 vmethod_254()
		{
			return this.class116_48;
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x00049A60 File Offset: 0x00047C60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_255(Class116 class116_56)
		{
			this.class116_48 = class116_56;
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x00049A69 File Offset: 0x00047C69
		[CompilerGenerated]
		internal Class112 vmethod_256()
		{
			return this.class112_28;
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x004052E0 File Offset: 0x004034E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_257(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_125);
			Class112 @class = this.class112_28;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_28 = class112_35;
			@class = this.class112_28;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x00049A71 File Offset: 0x00047C71
		[CompilerGenerated]
		internal Class116 vmethod_258()
		{
			return this.class116_49;
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x00049A79 File Offset: 0x00047C79
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_259(Class116 class116_56)
		{
			this.class116_49 = class116_56;
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x00049A82 File Offset: 0x00047C82
		[CompilerGenerated]
		internal Class112 vmethod_260()
		{
			return this.class112_29;
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x00405324 File Offset: 0x00403524
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_261(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_126);
			Class112 @class = this.class112_29;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_29 = class112_35;
			@class = this.class112_29;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x00049A8A File Offset: 0x00047C8A
		[CompilerGenerated]
		internal Class116 vmethod_262()
		{
			return this.class116_50;
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x00049A92 File Offset: 0x00047C92
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_263(Class116 class116_56)
		{
			this.class116_50 = class116_56;
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x00049A9B File Offset: 0x00047C9B
		[CompilerGenerated]
		internal Class112 vmethod_264()
		{
			return this.class112_30;
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x00405368 File Offset: 0x00403568
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_265(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_127);
			Class112 @class = this.class112_30;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_30 = class112_35;
			@class = this.class112_30;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x00049AA3 File Offset: 0x00047CA3
		[CompilerGenerated]
		internal Class2451 vmethod_266()
		{
			return this.class2451_30;
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x004053AC File Offset: 0x004035AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_267(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_32);
			EventHandler value2 = new EventHandler(this.method_43);
			Class2451 @class = this.class2451_30;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_30 = class2451_45;
			@class = this.class2451_30;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x00049AAB File Offset: 0x00047CAB
		[CompilerGenerated]
		internal Class2451 vmethod_268()
		{
			return this.class2451_31;
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x0040540C File Offset: 0x0040360C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_269(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_33);
			EventHandler value2 = new EventHandler(this.method_44);
			Class2451 @class = this.class2451_31;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_31 = class2451_45;
			@class = this.class2451_31;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x00049AB3 File Offset: 0x00047CB3
		[CompilerGenerated]
		internal Class2451 vmethod_270()
		{
			return this.class2451_32;
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x0040546C File Offset: 0x0040366C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_271(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_61);
			EventHandler value2 = new EventHandler(this.method_62);
			Class2451 @class = this.class2451_32;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_32 = class2451_45;
			@class = this.class2451_32;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x00049ABB File Offset: 0x00047CBB
		[CompilerGenerated]
		internal Class2451 vmethod_272()
		{
			return this.class2451_33;
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x004054CC File Offset: 0x004036CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_273(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_59);
			EventHandler value2 = new EventHandler(this.method_60);
			Class2451 @class = this.class2451_33;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_33 = class2451_45;
			@class = this.class2451_33;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x00049AC3 File Offset: 0x00047CC3
		[CompilerGenerated]
		internal Class2451 vmethod_274()
		{
			return this.class2451_34;
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x0040552C File Offset: 0x0040372C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_275(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_129);
			EventHandler value2 = new EventHandler(this.method_136);
			Class2451 @class = this.class2451_34;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
				@class.Enter -= value2;
			}
			this.class2451_34 = class2451_45;
			@class = this.class2451_34;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
				@class.Enter += value2;
			}
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x00049ACB File Offset: 0x00047CCB
		[CompilerGenerated]
		internal Class2451 vmethod_276()
		{
			return this.class2451_35;
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x0040558C File Offset: 0x0040378C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_277(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_130);
			EventHandler value2 = new EventHandler(this.method_137);
			Class2451 @class = this.class2451_35;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
				@class.Enter -= value2;
			}
			this.class2451_35 = class2451_45;
			@class = this.class2451_35;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
				@class.Enter += value2;
			}
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x00049AD3 File Offset: 0x00047CD3
		[CompilerGenerated]
		internal Class2451 vmethod_278()
		{
			return this.class2451_36;
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x004055EC File Offset: 0x004037EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_279(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_131);
			EventHandler value2 = new EventHandler(this.method_138);
			Class2451 @class = this.class2451_36;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
				@class.Enter -= value2;
			}
			this.class2451_36 = class2451_45;
			@class = this.class2451_36;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
				@class.Enter += value2;
			}
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x00049ADB File Offset: 0x00047CDB
		[CompilerGenerated]
		internal Class2451 vmethod_280()
		{
			return this.class2451_37;
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x0040564C File Offset: 0x0040384C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_281(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_132);
			EventHandler value2 = new EventHandler(this.method_140);
			Class2451 @class = this.class2451_37;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
				@class.Enter -= value2;
			}
			this.class2451_37 = class2451_45;
			@class = this.class2451_37;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
				@class.Enter += value2;
			}
		}

		// Token: 0x06007779 RID: 30585 RVA: 0x00049AE3 File Offset: 0x00047CE3
		[CompilerGenerated]
		internal Class2451 vmethod_282()
		{
			return this.class2451_38;
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x004056AC File Offset: 0x004038AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_283(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_133);
			EventHandler value2 = new EventHandler(this.method_141);
			Class2451 @class = this.class2451_38;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
				@class.Enter -= value2;
			}
			this.class2451_38 = class2451_45;
			@class = this.class2451_38;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
				@class.Enter += value2;
			}
		}

		// Token: 0x0600777B RID: 30587 RVA: 0x00049AEB File Offset: 0x00047CEB
		[CompilerGenerated]
		internal Class2451 vmethod_284()
		{
			return this.class2451_39;
		}

		// Token: 0x0600777C RID: 30588 RVA: 0x0040570C File Offset: 0x0040390C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_285(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_134);
			EventHandler value2 = new EventHandler(this.method_142);
			Class2451 @class = this.class2451_39;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
				@class.Enter -= value2;
			}
			this.class2451_39 = class2451_45;
			@class = this.class2451_39;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
				@class.Enter += value2;
			}
		}

		// Token: 0x0600777D RID: 30589 RVA: 0x00049AF3 File Offset: 0x00047CF3
		[CompilerGenerated]
		internal Class2451 vmethod_286()
		{
			return this.class2451_40;
		}

		// Token: 0x0600777E RID: 30590 RVA: 0x0040576C File Offset: 0x0040396C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_287(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_135);
			EventHandler value2 = new EventHandler(this.method_143);
			Class2451 @class = this.class2451_40;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
				@class.Enter -= value2;
			}
			this.class2451_40 = class2451_45;
			@class = this.class2451_40;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
				@class.Enter += value2;
			}
		}

		// Token: 0x0600777F RID: 30591 RVA: 0x00049AFB File Offset: 0x00047CFB
		[CompilerGenerated]
		internal Class116 vmethod_288()
		{
			return this.class116_51;
		}

		// Token: 0x06007780 RID: 30592 RVA: 0x00049B03 File Offset: 0x00047D03
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_289(Class116 class116_56)
		{
			this.class116_51 = class116_56;
		}

		// Token: 0x06007781 RID: 30593 RVA: 0x00049B0C File Offset: 0x00047D0C
		[CompilerGenerated]
		internal Class112 vmethod_290()
		{
			return this.class112_31;
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x004057CC File Offset: 0x004039CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_291(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_120);
			EventHandler value2 = new EventHandler(this.method_128);
			Class112 @class = this.class112_31;
			if (@class != null)
			{
				@class.Click -= value;
				@class.Click -= value2;
			}
			this.class112_31 = class112_35;
			@class = this.class112_31;
			if (@class != null)
			{
				@class.Click += value;
				@class.Click += value2;
			}
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x00049B14 File Offset: 0x00047D14
		[CompilerGenerated]
		internal Class2451 vmethod_292()
		{
			return this.class2451_41;
		}

		// Token: 0x06007784 RID: 30596 RVA: 0x0040582C File Offset: 0x00403A2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_293(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_63);
			EventHandler value2 = new EventHandler(this.method_64);
			Class2451 @class = this.class2451_41;
			if (@class != null)
			{
				@class.Enter -= value;
				@class.SelectionChangeCommitted -= value2;
			}
			this.class2451_41 = class2451_45;
			@class = this.class2451_41;
			if (@class != null)
			{
				@class.Enter += value;
				@class.SelectionChangeCommitted += value2;
			}
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x00049B1C File Offset: 0x00047D1C
		[CompilerGenerated]
		internal Class116 vmethod_294()
		{
			return this.class116_52;
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x00049B24 File Offset: 0x00047D24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_295(Class116 class116_56)
		{
			this.class116_52 = class116_56;
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x00049B2D File Offset: 0x00047D2D
		[CompilerGenerated]
		internal Class116 vmethod_296()
		{
			return this.class116_53;
		}

		// Token: 0x06007788 RID: 30600 RVA: 0x00049B35 File Offset: 0x00047D35
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_297(Class116 class116_56)
		{
			this.class116_53 = class116_56;
		}

		// Token: 0x06007789 RID: 30601 RVA: 0x00049B3E File Offset: 0x00047D3E
		[CompilerGenerated]
		internal Class116 vmethod_298()
		{
			return this.class116_54;
		}

		// Token: 0x0600778A RID: 30602 RVA: 0x00049B46 File Offset: 0x00047D46
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_299(Class116 class116_56)
		{
			this.class116_54 = class116_56;
		}

		// Token: 0x0600778B RID: 30603 RVA: 0x00049B4F File Offset: 0x00047D4F
		[CompilerGenerated]
		internal Class116 vmethod_300()
		{
			return this.class116_55;
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x00049B57 File Offset: 0x00047D57
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_301(Class116 class116_56)
		{
			this.class116_55 = class116_56;
		}

		// Token: 0x0600778D RID: 30605 RVA: 0x00049B60 File Offset: 0x00047D60
		[CompilerGenerated]
		internal Class112 vmethod_302()
		{
			return this.class112_32;
		}

		// Token: 0x0600778E RID: 30606 RVA: 0x0040588C File Offset: 0x00403A8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_303(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_79);
			Class112 @class = this.class112_32;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_32 = class112_35;
			@class = this.class112_32;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x00049B68 File Offset: 0x00047D68
		[CompilerGenerated]
		internal Class112 vmethod_304()
		{
			return this.class112_33;
		}

		// Token: 0x06007790 RID: 30608 RVA: 0x004058D0 File Offset: 0x00403AD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_305(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_81);
			Class112 @class = this.class112_33;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_33 = class112_35;
			@class = this.class112_33;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007791 RID: 30609 RVA: 0x00049B70 File Offset: 0x00047D70
		[CompilerGenerated]
		internal Class112 vmethod_306()
		{
			return this.class112_34;
		}

		// Token: 0x06007792 RID: 30610 RVA: 0x00405914 File Offset: 0x00403B14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_307(Class112 class112_35)
		{
			EventHandler value = new EventHandler(this.method_83);
			Class112 @class = this.class112_34;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_34 = class112_35;
			@class = this.class112_34;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007793 RID: 30611 RVA: 0x00049B78 File Offset: 0x00047D78
		[CompilerGenerated]
		internal Class2451 vmethod_308()
		{
			return this.class2451_42;
		}

		// Token: 0x06007794 RID: 30612 RVA: 0x00405958 File Offset: 0x00403B58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_309(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_80);
			Class2451 @class = this.class2451_42;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_42 = class2451_45;
			@class = this.class2451_42;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06007795 RID: 30613 RVA: 0x00049B80 File Offset: 0x00047D80
		[CompilerGenerated]
		internal Class2451 vmethod_310()
		{
			return this.class2451_43;
		}

		// Token: 0x06007796 RID: 30614 RVA: 0x0040599C File Offset: 0x00403B9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_311(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_82);
			Class2451 @class = this.class2451_43;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_43 = class2451_45;
			@class = this.class2451_43;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06007797 RID: 30615 RVA: 0x00049B88 File Offset: 0x00047D88
		[CompilerGenerated]
		internal Class2451 vmethod_312()
		{
			return this.class2451_44;
		}

		// Token: 0x06007798 RID: 30616 RVA: 0x004059E0 File Offset: 0x00403BE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_313(Class2451 class2451_45)
		{
			EventHandler value = new EventHandler(this.method_84);
			Class2451 @class = this.class2451_44;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_44 = class2451_45;
			@class = this.class2451_44;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x00405A24 File Offset: 0x00403C24
		private void method_3(Class310 class310_1, bool? nullable_42, bool bool_9, bool bool_10, bool bool_11, bool bool_12)
		{
			try
			{
				if (!bool_10)
				{
					if (!bool_12)
					{
						if (!Information.IsNothing(class310_1))
						{
							if (class310_1.bool_0)
							{
								if (((ActiveUnit)class310_1).vmethod_127())
								{
									if (!bool_9 || class310_1 == Client.smethod_54())
									{
										if (!Information.IsNothing(nullable_42))
										{
											if (base.Visible)
											{
												if ((class310_1 == this.class310_0 || Information.IsNothing(this.class310_0)) && this.vmethod_0().SelectedIndex == 0)
												{
													this.method_16();
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				bool isAttached = Debugger.IsAttached;
			}
		}

		// Token: 0x0600779A RID: 30618 RVA: 0x00405AF8 File Offset: 0x00403CF8
		private void method_4(Class310 class310_1, bool? nullable_42, bool bool_9, bool bool_10, bool bool_11, bool bool_12)
		{
			try
			{
				if (!bool_10)
				{
					if (!bool_12)
					{
						if (!Information.IsNothing(class310_1))
						{
							if (class310_1.bool_0)
							{
								if (!bool_9 || class310_1 == Client.smethod_54())
								{
									if (this.bool_5)
									{
										if (!Information.IsNothing(nullable_42))
										{
											if (base.Visible)
											{
												if ((class310_1 == this.class310_0 || Information.IsNothing(this.class310_0)) && this.vmethod_0().SelectedIndex == 1)
												{
													this.method_16();
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600779B RID: 30619 RVA: 0x00405BCC File Offset: 0x00403DCC
		private void DoctrineForm_Load(object sender, EventArgs e)
		{
			Doctrine.smethod_0(new Doctrine.Delegate28(this.method_3));
			Doctrine.smethod_2(new Doctrine.Delegate29(this.method_4));
			this.vmethod_0().SizeMode = TabSizeMode.Normal;
			if (!Information.IsNothing(this.list_0))
			{
				if (this.bool_6)
				{
					this.Text = "Doctrine & ROE for aircraft on ground";
				}
				else if (this.bool_7)
				{
					this.Text = "Doctrine & ROE for boats in dock / davit";
				}
				else
				{
					this.Text = "Doctrine & ROE for multiple units";
				}
				this.doctrine_0 = this.method_114();
			}
			else
			{
				if (this.class310_0.GetType() == typeof(Side))
				{
					this.Text = "Doctrine & ROE for side: " + ((Side)this.class310_0).method_51();
					this.doctrine_0 = ((Side)this.class310_0).doctrine_0;
				}
				else if (this.class310_0.bool_9)
				{
					if (this.bool_8)
					{
						this.Text = "Doctrine & ROE for mission escorts: " + ((Mission)this.class310_0).Name;
						this.doctrine_0 = ((Strike)this.class310_0).doctrine_1;
					}
					else
					{
						this.Text = "Doctrine & ROE for mission: " + ((Mission)this.class310_0).Name;
						this.doctrine_0 = ((Mission)this.class310_0).doctrine_0;
					}
				}
				else if (this.class310_0.GetType() == typeof(Group))
				{
					this.Text = "Doctrine & ROE for group: " + ((Group)this.class310_0).Name;
					this.doctrine_0 = ((Group)this.class310_0).doctrine_0;
				}
				else if (this.class310_0.GetType() == typeof(Waypoint))
				{
					string text = ((Waypoint)this.class310_0).Name;
					if (string.IsNullOrEmpty(text))
					{
						text = "Not named";
					}
					this.Text = string.Concat(new string[]
					{
						"Doctrine & ROE for waypoint: ",
						text,
						" (Type: ",
						Waypoint.smethod_23(((Waypoint)this.class310_0).waypointType_0),
						")"
					});
					this.doctrine_0 = ((Waypoint)this.class310_0).method_18();
				}
				else
				{
					this.Text = "Doctrine & ROE for unit: " + ((ActiveUnit)this.class310_0).Name;
					this.doctrine_0 = ((ActiveUnit)this.class310_0).doctrine_0;
				}
				this.doctrine_0.method_4();
			}
			this.vmethod_0().SelectedIndex = 0;
			this.method_16();
		}

		// Token: 0x0600779C RID: 30620 RVA: 0x00405E70 File Offset: 0x00404070
		private void method_5()
		{
			this.method_116();
			if (!Information.IsNothing(this.class310_0))
			{
				if (this.class310_0.GetType() == typeof(Side))
				{
					this.vmethod_122().Enabled = false;
					this.vmethod_120().Enabled = true;
					this.vmethod_118().Enabled = true;
				}
				else if (this.class310_0.bool_9)
				{
					this.vmethod_122().Enabled = true;
					this.vmethod_120().Enabled = true;
					this.vmethod_118().Enabled = false;
				}
				else if (this.class310_0.GetType() == typeof(Group))
				{
					this.vmethod_122().Enabled = true;
					this.vmethod_120().Enabled = true;
					this.vmethod_118().Enabled = false;
				}
				else if (this.class310_0.GetType() == typeof(Waypoint))
				{
					this.vmethod_122().Enabled = false;
					this.vmethod_120().Enabled = false;
					this.vmethod_118().Enabled = false;
				}
				else
				{
					this.vmethod_122().Enabled = true;
					this.vmethod_120().Enabled = false;
					this.vmethod_118().Enabled = false;
				}
			}
			else
			{
				this.vmethod_122().Enabled = true;
				this.vmethod_120().Enabled = false;
				try
				{
					List<ActiveUnit>.Enumerator enumerator = this.list_0.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.bool_1)
						{
							this.vmethod_120().Enabled = true;
							break;
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.vmethod_118().Enabled = false;
			}
			if (!Information.IsNothing(this.list_0))
			{
				this.doctrine_0 = this.method_114();
			}
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_222().Visible = false;
			}
			this.vmethod_48().Checked = this.doctrine_0.method_34(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_48().Visible = false;
				this.vmethod_56().Enabled = this.doctrine_0.method_34(Client.smethod_46());
			}
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_56();
			Scenario scenario = Client.smethod_46();
			doctrine.method_283(comboBox_, ref scenario, this.nullable_0);
			this.vmethod_46().Checked = this.doctrine_0.method_66(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_46().Visible = false;
				this.vmethod_54().Enabled = this.doctrine_0.method_66(Client.smethod_46());
			}
			Doctrine doctrine2 = this.doctrine_0;
			ComboBox comboBox_2 = this.vmethod_54();
			scenario = Client.smethod_46();
			doctrine2.method_285(comboBox_2, ref scenario, this.nullable_1);
			this.vmethod_146().Checked = this.doctrine_0.method_71(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_146().Visible = false;
				this.vmethod_152().Enabled = this.doctrine_0.method_71(Client.smethod_46());
			}
			Doctrine doctrine3 = this.doctrine_0;
			ComboBox comboBox_3 = this.vmethod_152();
			scenario = Client.smethod_46();
			doctrine3.method_287(comboBox_3, ref scenario, this.nullable_2);
			this.vmethod_148().Checked = this.doctrine_0.method_76(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_148().Visible = false;
				this.vmethod_154().Enabled = this.doctrine_0.method_76(Client.smethod_46());
			}
			Doctrine doctrine4 = this.doctrine_0;
			ComboBox comboBox_4 = this.vmethod_154();
			scenario = Client.smethod_46();
			doctrine4.method_289(comboBox_4, ref scenario, this.nullable_3);
			this.vmethod_150().Checked = this.doctrine_0.method_81(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_150().Visible = false;
				this.vmethod_156().Enabled = this.doctrine_0.method_81(Client.smethod_46());
			}
			Doctrine doctrine5 = this.doctrine_0;
			ComboBox comboBox_5 = this.vmethod_156();
			scenario = Client.smethod_46();
			doctrine5.method_291(comboBox_5, ref scenario, this.nullable_4);
			this.vmethod_160().Checked = this.doctrine_0.method_150(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_160().Visible = false;
				this.vmethod_162().Enabled = this.doctrine_0.method_150(Client.smethod_46());
			}
			Doctrine doctrine6 = this.doctrine_0;
			ComboBox comboBox_6 = this.vmethod_162();
			scenario = Client.smethod_46();
			doctrine6.method_315(comboBox_6, ref scenario, this.nullable_23);
			this.vmethod_138().Checked = this.doctrine_0.method_86(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_138().Visible = false;
				this.vmethod_136().Enabled = this.doctrine_0.method_86(Client.smethod_46());
			}
			Doctrine doctrine7 = this.doctrine_0;
			ComboBox comboBox_7 = this.vmethod_136();
			scenario = Client.smethod_46();
			doctrine7.method_293(comboBox_7, ref scenario, this.nullable_5);
			this.vmethod_42().Checked = this.doctrine_0.method_120(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_42().Visible = false;
				this.vmethod_52().Enabled = this.doctrine_0.method_120(Client.smethod_46());
			}
			Doctrine doctrine8 = this.doctrine_0;
			ComboBox comboBox_8 = this.vmethod_52();
			scenario = Client.smethod_46();
			doctrine8.method_295(comboBox_8, ref scenario, this.nullable_6);
			this.vmethod_232().Checked = this.doctrine_0.method_125(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_232().Visible = false;
				this.vmethod_272().Enabled = this.doctrine_0.method_125(Client.smethod_46());
			}
			Doctrine doctrine9 = this.doctrine_0;
			ComboBox comboBox_9 = this.vmethod_272();
			scenario = Client.smethod_46();
			doctrine9.method_297(comboBox_9, ref scenario, this.nullable_7);
			this.vmethod_230().Checked = this.doctrine_0.method_130(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_230().Visible = false;
				this.vmethod_270().Enabled = this.doctrine_0.method_130(Client.smethod_46());
			}
			Doctrine doctrine10 = this.doctrine_0;
			ComboBox comboBox_10 = this.vmethod_270();
			scenario = Client.smethod_46();
			doctrine10.method_299(comboBox_10, ref scenario, this.nullable_8);
			this.vmethod_290().Checked = this.doctrine_0.method_135(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_290().Visible = false;
				this.vmethod_292().Enabled = this.doctrine_0.method_135(Client.smethod_46());
			}
			Doctrine doctrine11 = this.doctrine_0;
			ComboBox comboBox_11 = this.vmethod_292();
			scenario = Client.smethod_46();
			doctrine11.method_301(comboBox_11, ref scenario, this.nullable_9);
			this.vmethod_62().Checked = this.doctrine_0.method_91(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_62().Visible = false;
				this.vmethod_60().Enabled = this.doctrine_0.method_91(Client.smethod_46());
			}
			Doctrine doctrine12 = this.doctrine_0;
			ComboBox comboBox_12 = this.vmethod_60();
			scenario = Client.smethod_46();
			doctrine12.method_303(comboBox_12, ref scenario, this.nullable_10);
			this.vmethod_68().Checked = this.doctrine_0.method_140(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_68().Visible = false;
				this.vmethod_66().Enabled = this.doctrine_0.method_140(Client.smethod_46());
			}
			Doctrine doctrine13 = this.doctrine_0;
			ComboBox comboBox_13 = this.vmethod_66();
			scenario = Client.smethod_46();
			doctrine13.method_305(comboBox_13, ref scenario, this.nullable_11);
			this.vmethod_72().Checked = this.doctrine_0.method_145(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_72().Visible = false;
				this.vmethod_70().Enabled = this.doctrine_0.method_145(Client.smethod_46());
			}
			Doctrine doctrine14 = this.doctrine_0;
			ComboBox comboBox_14 = this.vmethod_70();
			scenario = Client.smethod_46();
			doctrine14.method_307(comboBox_14, ref scenario, this.nullable_12);
			this.vmethod_76().Checked = this.doctrine_0.method_155(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_76().Visible = false;
				this.vmethod_74().Enabled = this.doctrine_0.method_155(Client.smethod_46());
			}
			Doctrine doctrine15 = this.doctrine_0;
			ComboBox comboBox_15 = this.vmethod_74();
			scenario = Client.smethod_46();
			doctrine15.method_317(comboBox_15, ref scenario, this.nullable_13);
			this.vmethod_214().Checked = this.doctrine_0.method_160(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_214().Visible = false;
				this.vmethod_216().Enabled = this.doctrine_0.method_160(Client.smethod_46());
			}
			Doctrine doctrine16 = this.doctrine_0;
			ComboBox comboBox_16 = this.vmethod_216();
			scenario = Client.smethod_46();
			doctrine16.method_319(comboBox_16, ref scenario, this.nullable_14);
			this.vmethod_80().Checked = this.doctrine_0.method_165(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_80().Visible = false;
				this.vmethod_78().Enabled = this.doctrine_0.method_165(Client.smethod_46());
			}
			Doctrine doctrine17 = this.doctrine_0;
			ComboBox comboBox_17 = this.vmethod_78();
			scenario = Client.smethod_46();
			doctrine17.method_321(comboBox_17, ref scenario, this.nullable_15);
			this.vmethod_84().Checked = this.doctrine_0.method_170(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_84().Visible = false;
				this.vmethod_82().Enabled = this.doctrine_0.method_170(Client.smethod_46());
			}
			Doctrine doctrine18 = this.doctrine_0;
			ComboBox comboBox_18 = this.vmethod_82();
			scenario = Client.smethod_46();
			doctrine18.method_323(comboBox_18, ref scenario, this.nullable_16);
			this.vmethod_88().Checked = this.doctrine_0.method_175(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_88().Visible = false;
				this.vmethod_86().Enabled = this.doctrine_0.method_175(Client.smethod_46());
			}
			Doctrine doctrine19 = this.doctrine_0;
			ComboBox comboBox_19 = this.vmethod_86();
			scenario = Client.smethod_46();
			doctrine19.method_325(comboBox_19, ref scenario, this.nullable_17);
			this.vmethod_96().Checked = this.doctrine_0.method_199(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_96().Visible = false;
				this.vmethod_92().Enabled = this.doctrine_0.method_199(Client.smethod_46());
			}
			Doctrine doctrine20 = this.doctrine_0;
			ComboBox comboBox_20 = this.vmethod_92();
			scenario = Client.smethod_46();
			doctrine20.method_327(comboBox_20, ref scenario, ref this.bool_3, this.nullable_18);
			this.vmethod_104().Checked = this.doctrine_0.method_204(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_104().Visible = false;
				this.vmethod_102().Enabled = this.doctrine_0.method_204(Client.smethod_46());
			}
			Doctrine doctrine21 = this.doctrine_0;
			ComboBox comboBox_21 = this.vmethod_102();
			scenario = Client.smethod_46();
			doctrine21.method_329(comboBox_21, ref scenario, ref this.bool_3, this.nullable_19);
			this.vmethod_224().Checked = this.doctrine_0.method_209(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_224().Visible = false;
				this.vmethod_266().Enabled = this.doctrine_0.method_209(Client.smethod_46());
			}
			Doctrine doctrine22 = this.doctrine_0;
			ComboBox comboBox_22 = this.vmethod_266();
			scenario = Client.smethod_46();
			doctrine22.method_331(comboBox_22, ref scenario, ref this.bool_3, this.nullable_20);
			this.vmethod_226().Checked = this.doctrine_0.method_214(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_226().Visible = false;
				this.vmethod_268().Enabled = this.doctrine_0.method_214(Client.smethod_46());
			}
			Doctrine doctrine23 = this.doctrine_0;
			ComboBox comboBox_23 = this.vmethod_268();
			scenario = Client.smethod_46();
			doctrine23.method_333(comboBox_23, ref scenario, ref this.bool_3, this.nullable_21);
			this.vmethod_98().Checked = this.doctrine_0.method_219(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_98().Visible = false;
				this.vmethod_94().Enabled = this.doctrine_0.method_219(Client.smethod_46());
			}
			Doctrine doctrine24 = this.doctrine_0;
			ComboBox comboBox_24 = this.vmethod_94();
			scenario = Client.smethod_46();
			doctrine24.method_335(comboBox_24, ref scenario, this.nullable_22);
			this.vmethod_240().Checked = this.doctrine_0.method_243(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_240().Visible = false;
				this.vmethod_274().Enabled = this.doctrine_0.method_243(Client.smethod_46());
			}
			Doctrine doctrine25 = this.doctrine_0;
			ComboBox comboBox_25 = this.vmethod_274();
			scenario = Client.smethod_46();
			doctrine25.method_343(comboBox_25, ref scenario, this.nullable_24);
			this.vmethod_246().Checked = this.doctrine_0.method_249(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_246().Visible = false;
				this.vmethod_276().Enabled = this.doctrine_0.method_249(Client.smethod_46());
			}
			Doctrine doctrine26 = this.doctrine_0;
			ComboBox comboBox_26 = this.vmethod_276();
			scenario = Client.smethod_46();
			doctrine26.method_345(comboBox_26, ref scenario, this.nullable_25);
			this.vmethod_248().Checked = this.doctrine_0.method_255(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_248().Visible = false;
				this.vmethod_278().Enabled = this.doctrine_0.method_255(Client.smethod_46());
			}
			Doctrine doctrine27 = this.doctrine_0;
			ComboBox comboBox_27 = this.vmethod_278();
			scenario = Client.smethod_46();
			doctrine27.method_347(comboBox_27, ref scenario, this.nullable_26);
			this.vmethod_252().Checked = this.doctrine_0.method_261(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_252().Visible = false;
				this.vmethod_280().Enabled = this.doctrine_0.method_261(Client.smethod_46());
			}
			Doctrine doctrine28 = this.doctrine_0;
			ComboBox comboBox_28 = this.vmethod_280();
			scenario = Client.smethod_46();
			doctrine28.method_349(comboBox_28, ref scenario, this.nullable_27);
			this.vmethod_256().Checked = this.doctrine_0.method_267(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_256().Visible = false;
				this.vmethod_282().Enabled = this.doctrine_0.method_267(Client.smethod_46());
			}
			Doctrine doctrine29 = this.doctrine_0;
			ComboBox comboBox_29 = this.vmethod_282();
			scenario = Client.smethod_46();
			doctrine29.method_351(comboBox_29, ref scenario, this.nullable_28);
			this.vmethod_260().Checked = this.doctrine_0.method_273(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_260().Visible = false;
				this.vmethod_284().Enabled = this.doctrine_0.method_273(Client.smethod_46());
			}
			Doctrine doctrine30 = this.doctrine_0;
			ComboBox comboBox_30 = this.vmethod_284();
			scenario = Client.smethod_46();
			doctrine30.method_353(comboBox_30, ref scenario, this.nullable_29);
			this.vmethod_264().Checked = this.doctrine_0.method_279(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_264().Visible = false;
				this.vmethod_286().Enabled = this.doctrine_0.method_279(Client.smethod_46());
			}
			Doctrine doctrine31 = this.doctrine_0;
			ComboBox comboBox_31 = this.vmethod_286();
			scenario = Client.smethod_46();
			doctrine31.method_355(comboBox_31, ref scenario, this.nullable_30);
			this.vmethod_302().Checked = this.doctrine_0.method_180(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_302().Visible = false;
				this.vmethod_308().Enabled = this.doctrine_0.method_180(Client.smethod_46());
			}
			Doctrine doctrine32 = this.doctrine_0;
			ComboBox comboBox_32 = this.vmethod_308();
			scenario = Client.smethod_46();
			doctrine32.method_309(comboBox_32, ref scenario, this.nullable_31);
			this.vmethod_304().Checked = this.doctrine_0.method_185(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_304().Visible = false;
				this.vmethod_310().Enabled = this.doctrine_0.method_185(Client.smethod_46());
			}
			Doctrine doctrine33 = this.doctrine_0;
			ComboBox comboBox_33 = this.vmethod_310();
			scenario = Client.smethod_46();
			doctrine33.method_311(comboBox_33, ref scenario, this.nullable_32);
			this.vmethod_306().Checked = this.doctrine_0.method_190(Client.smethod_46());
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_306().Visible = false;
				this.vmethod_312().Enabled = this.doctrine_0.method_190(Client.smethod_46());
			}
			Doctrine doctrine34 = this.doctrine_0;
			ComboBox comboBox_34 = this.vmethod_312();
			scenario = Client.smethod_46();
			doctrine34.method_313(comboBox_34, ref scenario, this.nullable_33);
			this.method_117(true);
		}

		// Token: 0x0600779D RID: 30621 RVA: 0x00406F14 File Offset: 0x00405114
		private void method_6()
		{
			this.method_116();
			if (!Information.IsNothing(this.class310_0))
			{
				if (this.class310_0.GetType() == typeof(Side))
				{
					this.vmethod_132().Enabled = false;
					this.vmethod_130().Enabled = true;
					this.vmethod_128().Enabled = true;
				}
				else if (this.class310_0.bool_9)
				{
					this.vmethod_132().Enabled = true;
					this.vmethod_130().Enabled = true;
					this.vmethod_128().Enabled = false;
				}
				else if (this.class310_0.GetType() == typeof(Group))
				{
					this.vmethod_132().Enabled = true;
					this.vmethod_130().Enabled = true;
					this.vmethod_128().Enabled = false;
				}
				else if (this.class310_0.GetType() == typeof(Waypoint))
				{
					this.vmethod_132().Enabled = false;
					this.vmethod_130().Enabled = false;
					this.vmethod_128().Enabled = false;
				}
				else
				{
					this.vmethod_132().Enabled = true;
					this.vmethod_130().Enabled = false;
					this.vmethod_128().Enabled = false;
				}
			}
			else
			{
				this.vmethod_132().Enabled = true;
				this.vmethod_130().Enabled = false;
				try
				{
					List<ActiveUnit>.Enumerator enumerator = this.list_0.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.bool_1)
						{
							this.vmethod_130().Enabled = true;
							break;
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.vmethod_128().Enabled = false;
			}
			if (!Information.IsNothing(this.list_0))
			{
				this.doctrine_0 = this.method_114();
			}
			this.doctrine_0.bool_34 = true;
			this.doctrine_0.method_340(this.vmethod_10(), ref this.class310_0, ref this.doctrine_0);
			this.doctrine_0.bool_34 = false;
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_6();
			Scenario scenario = Client.smethod_46();
			doctrine.method_337(comboBox_, ref scenario, ref this.doctrine_0);
			Doctrine doctrine2 = this.doctrine_0;
			ComboBox comboBox_2 = this.vmethod_12();
			scenario = Client.smethod_46();
			doctrine2.method_338(comboBox_2, ref scenario, ref this.doctrine_0);
			Doctrine doctrine3 = this.doctrine_0;
			ComboBox comboBox_3 = this.vmethod_16();
			scenario = Client.smethod_46();
			doctrine3.method_339(comboBox_3, ref scenario, ref this.doctrine_0);
			this.method_117(true);
		}

		// Token: 0x0600779E RID: 30622 RVA: 0x0040717C File Offset: 0x0040537C
		private void method_7()
		{
			if (this.class310_0 != null)
			{
				if (this.class310_0.GetType() == typeof(Side))
				{
					this.vmethod_24().Enabled = true;
					this.vmethod_126().Enabled = true;
					this.vmethod_124().Enabled = true;
					this.vmethod_24().Text = "Reset WRA (use system defaults)";
				}
				else if (this.class310_0.bool_9)
				{
					this.vmethod_24().Enabled = true;
					this.vmethod_126().Enabled = true;
					this.vmethod_124().Enabled = false;
				}
				else if (this.class310_0.GetType() == typeof(Group))
				{
					this.vmethod_24().Enabled = true;
					this.vmethod_126().Enabled = true;
					this.vmethod_124().Enabled = false;
				}
				else if (this.class310_0.GetType() == typeof(Waypoint))
				{
					this.vmethod_24().Enabled = false;
					this.vmethod_126().Enabled = false;
					this.vmethod_124().Enabled = false;
				}
				else
				{
					this.vmethod_24().Enabled = true;
					this.vmethod_126().Enabled = false;
					this.vmethod_124().Enabled = false;
				}
			}
			else
			{
				this.vmethod_24().Enabled = true;
				this.vmethod_126().Enabled = false;
				try
				{
					List<ActiveUnit>.Enumerator enumerator = this.list_0.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.bool_1)
						{
							this.vmethod_126().Enabled = true;
							break;
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.vmethod_124().Enabled = false;
			}
			checked
			{
				try
				{
					if (Client.smethod_50() != null)
					{
						if (Client.smethod_50().activeUnit_0.Length != 0)
						{
							this.method_116();
							int num = 0;
							int index = 0;
							int firstDisplayedScrollingRowIndex = this.vmethod_22().FirstDisplayedScrollingRowIndex;
							if (this.vmethod_22().SelectedCells.Count > 0)
							{
								num = this.vmethod_22().SelectedCells[0].RowIndex;
								index = this.vmethod_22().SelectedCells[0].ColumnIndex;
							}
							this.vmethod_22().method_2().Clear();
							this.dictionary_0 = new Dictionary<int, Doctrine.WRA_Weapon>();
							if (Information.IsNothing(this.list_0))
							{
								this.method_9(ref this.doctrine_0);
							}
							else
							{
								try
								{
									foreach (ActiveUnit activeUnit in this.list_0)
									{
										this.method_9(ref activeUnit.doctrine_0);
									}
								}
								finally
								{
									List<ActiveUnit>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
							}
							if (!Information.IsNothing(this.class310_0) && this.class310_0.GetType() == typeof(Side))
							{
								try
								{
									foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair in this.dictionary_0)
									{
										int key = keyValuePair.Key;
										Weapon weapon = keyValuePair.Value.method_1(Client.smethod_46(), key);
										if (!Information.IsNothing(weapon.doctrine_0.method_27()))
										{
											try
											{
												foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair2 in weapon.doctrine_0.method_27())
												{
													Doctrine.Class276[] class276_ = keyValuePair2.Value.class276_0;
													int i = 0;
													IL_3A7:
													while (i < class276_.Length)
													{
														Doctrine.Class276 @class = class276_[i];
														foreach (Doctrine.Class276 class2 in keyValuePair.Value.class276_0)
														{
															if (class2._WRA_WeaponTargetType_0 == @class._WRA_WeaponTargetType_0)
															{
																class2.nullable_0 = new int?(-1);
																class2.nullable_1 = new int?(-1);
																class2.nullable_3 = new int?(-1);
																IL_3A1:
																i++;
																goto IL_3A7;
															}
														}
														goto IL_3A1;
													}
												}
											}
											finally
											{
												Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator4;
												((IDisposable)enumerator4).Dispose();
											}
										}
									}
								}
								finally
								{
									Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
							}
							if (!Information.IsNothing(this.list_0))
							{
								this.method_115();
							}
							this.method_10(ref this.doctrine_0);
							List<KeyValuePair<int, Doctrine.WRA_Weapon>> list = Enumerable.ToList<KeyValuePair<int, Doctrine.WRA_Weapon>>(Enumerable.OrderBy<KeyValuePair<int, Doctrine.WRA_Weapon>, string>(this.dictionary_0, (DoctrineForm._Closure$__.$I735-0 == null) ? (DoctrineForm._Closure$__.$I735-0 = new Func<KeyValuePair<int, Doctrine.WRA_Weapon>, string>(DoctrineForm._Closure$__.$I.method_0)) : DoctrineForm._Closure$__.$I735-0, new Class440<string[]>(true)));
							try
							{
								foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair3 in list)
								{
									Class49 class3 = this.vmethod_22().method_2();
									object[] array = new object[3];
									array[0] = keyValuePair3.Value.method_1(Client.smethod_46(), keyValuePair3.Key).Name;
									Class48 class4 = class3.method_1(array);
									class4.Tag = keyValuePair3;
									class4.method_7().method_0("Temp only");
									DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
									DataGridViewTextBoxCell dataGridViewTextBoxCell2 = new DataGridViewTextBoxCell();
									DataGridViewTextBoxCell dataGridViewTextBoxCell3 = new DataGridViewTextBoxCell();
									DataGridViewTextBoxCell dataGridViewTextBoxCell4 = new DataGridViewTextBoxCell();
									dataGridViewTextBoxCell3.Value = "";
									this.vmethod_22()[this.vmethod_204().Index, class4.method_1()] = dataGridViewTextBoxCell;
									this.vmethod_22()[this.vmethod_206().Index, class4.method_1()] = dataGridViewTextBoxCell4;
									this.vmethod_22()[this.vmethod_208().Index, class4.method_1()] = dataGridViewTextBoxCell2;
									this.vmethod_22()[this.vmethod_210().Index, class4.method_1()] = dataGridViewTextBoxCell3;
									dataGridViewTextBoxCell.ReadOnly = true;
									dataGridViewTextBoxCell2.ReadOnly = true;
									dataGridViewTextBoxCell3.ReadOnly = true;
									dataGridViewTextBoxCell4.ReadOnly = true;
									try
									{
										foreach (int num2 in this.list_1)
										{
											try
											{
												foreach (Class48 class5 in this.vmethod_22().method_2())
												{
													try
													{
														if (((KeyValuePair<int, Doctrine.WRA_Weapon>)class5.Tag).Key == num2)
														{
															class5.vmethod_4();
														}
													}
													catch (Exception ex)
													{
														ex.Data.Add("Error at 200268", ex.Message);
														GameGeneral.smethod_25(ref ex);
														if (Debugger.IsAttached)
														{
															Debugger.Break();
														}
													}
												}
											}
											finally
											{
												IEnumerator<Class48> enumerator7;
												if (enumerator7 != null)
												{
													enumerator7.Dispose();
												}
											}
										}
									}
									finally
									{
										List<int>.Enumerator enumerator6;
										((IDisposable)enumerator6).Dispose();
									}
								}
							}
							finally
							{
								List<KeyValuePair<int, Doctrine.WRA_Weapon>>.Enumerator enumerator5;
								((IDisposable)enumerator5).Dispose();
							}
							if (this.vmethod_22().method_0().Count != 0 & num != 0)
							{
								this.vmethod_22().method_0()[num].Cells[index].Selected = true;
								if (firstDisplayedScrollingRowIndex != -1)
								{
									this.vmethod_22().FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
								}
							}
							this.method_117(true);
						}
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 101195", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0600779F RID: 30623 RVA: 0x0040794C File Offset: 0x00405B4C
		private void method_8()
		{
			this.method_116();
			if (!Information.IsNothing(this.list_0))
			{
				this.doctrine_0 = this.method_114();
			}
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_180();
			Scenario scenario = Client.smethod_46();
			doctrine.method_366(comboBox_, ref scenario, this.nullable_34);
			Doctrine doctrine2 = this.doctrine_0;
			ComboBox comboBox_2 = this.vmethod_170();
			scenario = Client.smethod_46();
			doctrine2.method_367(comboBox_2, ref scenario, this.nullable_35);
			Doctrine doctrine3 = this.doctrine_0;
			ComboBox comboBox_3 = this.vmethod_168();
			scenario = Client.smethod_46();
			doctrine3.method_368(comboBox_3, ref scenario, this.nullable_36);
			Doctrine doctrine4 = this.doctrine_0;
			ComboBox comboBox_4 = this.vmethod_166();
			scenario = Client.smethod_46();
			doctrine4.method_369(comboBox_4, ref scenario, this.nullable_37);
			Doctrine doctrine5 = this.doctrine_0;
			ComboBox comboBox_5 = this.vmethod_198();
			scenario = Client.smethod_46();
			doctrine5.method_370(comboBox_5, ref scenario, this.nullable_38);
			Doctrine doctrine6 = this.doctrine_0;
			ComboBox comboBox_6 = this.vmethod_188();
			scenario = Client.smethod_46();
			doctrine6.method_371(comboBox_6, ref scenario, this.nullable_39);
			Doctrine doctrine7 = this.doctrine_0;
			ComboBox comboBox_7 = this.vmethod_186();
			scenario = Client.smethod_46();
			doctrine7.method_372(comboBox_7, ref scenario, this.nullable_40);
			Doctrine doctrine8 = this.doctrine_0;
			ComboBox comboBox_8 = this.vmethod_184();
			scenario = Client.smethod_46();
			doctrine8.method_373(comboBox_8, ref scenario, this.nullable_41);
			this.method_117(true);
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x00407A78 File Offset: 0x00405C78
		private void method_9(ref Doctrine doctrine_1)
		{
			try
			{
				foreach (ActiveUnit activeUnit in doctrine_1.method_5(Client.smethod_46(), new bool?(this.bool_8)))
				{
					if (activeUnit.vmethod_7(false) == Client.smethod_50() && !activeUnit.bool_2)
					{
						if (activeUnit.bool_3)
						{
							this.method_13(activeUnit);
							this.method_11(activeUnit);
						}
						else if (activeUnit.bool_6 || activeUnit.bool_5 || activeUnit.bool_8)
						{
							this.method_13(activeUnit);
							this.method_12(activeUnit);
						}
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x00407B2C File Offset: 0x00405D2C
		private void method_10(ref Doctrine doctrine_1)
		{
			if (!Information.IsNothing(doctrine_1.method_27()))
			{
				try
				{
					foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair in doctrine_1.method_27())
					{
						int key = keyValuePair.Key;
						foreach (Doctrine.Class276 @class in keyValuePair.Value.class276_0)
						{
							if (this.dictionary_0.ContainsKey(key))
							{
								Doctrine.WRA_Weapon wra_Weapon = new Doctrine.WRA_Weapon();
								this.dictionary_0.TryGetValue(key, out wra_Weapon);
								foreach (Doctrine.Class276 class2 in wra_Weapon.class276_0)
								{
									if (class2._WRA_WeaponTargetType_0 == @class._WRA_WeaponTargetType_0)
									{
										class2.nullable_0 = @class.nullable_0;
										class2.nullable_1 = @class.nullable_1;
										class2.nullable_3 = @class.nullable_3;
										class2.nullable_2 = @class.nullable_2;
										break;
									}
								}
							}
						}
					}
				}
				finally
				{
					Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x00407C5C File Offset: 0x00405E5C
		public void method_11(ActiveUnit activeUnit_0)
		{
			checked
			{
				if (!Information.IsNothing(((Aircraft)activeUnit_0).method_167()))
				{
					WeaponRec[] weaponRec_ = ((Aircraft)activeUnit_0).method_167().weaponRec_0;
					for (int i = 0; i < weaponRec_.Length; i++)
					{
						Weapon weapon = weaponRec_[i].method_12(Client.smethod_46());
						if (this.doctrine_0.method_239(ref weapon))
						{
							this.method_14(ref weapon);
						}
					}
				}
			}
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x00407CC0 File Offset: 0x00405EC0
		public void method_12(ActiveUnit activeUnit_0)
		{
			IEnumerable<Magazine> enumerable = Enumerable.OrderBy<Magazine, string>(activeUnit_0.vmethod_117(), (DoctrineForm._Closure$__.$I740-0 == null) ? (DoctrineForm._Closure$__.$I740-0 = new Func<Magazine, string>(DoctrineForm._Closure$__.$I.method_1)) : DoctrineForm._Closure$__.$I740-0);
			try
			{
				foreach (Magazine magazine in enumerable)
				{
					if (magazine.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						try
						{
							foreach (WeaponRec weaponRec in magazine.vmethod_10())
							{
								Weapon weapon = weaponRec.method_12(Client.smethod_46());
								if (this.doctrine_0.method_239(ref weapon))
								{
									this.method_14(ref weapon);
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<Magazine> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x00407D98 File Offset: 0x00405F98
		public void method_13(ActiveUnit activeUnit_0)
		{
			IEnumerable<Mount> enumerable = Enumerable.OrderBy<Mount, string>(activeUnit_0.vmethod_51(), (DoctrineForm._Closure$__.$I741-0 == null) ? (DoctrineForm._Closure$__.$I741-0 = new Func<Mount, string>(DoctrineForm._Closure$__.$I.method_2)) : DoctrineForm._Closure$__.$I741-0);
			try
			{
				foreach (Mount mount in enumerable)
				{
					if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						try
						{
							foreach (WeaponRec weaponRec in mount.vmethod_10())
							{
								Weapon weapon = weaponRec.method_12(Client.smethod_46());
								if (this.doctrine_0.method_239(ref weapon))
								{
									this.method_14(ref weapon);
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<Mount> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x00407E70 File Offset: 0x00406070
		public void method_14(ref Weapon weapon_0)
		{
			if (!this.dictionary_0.ContainsKey(weapon_0.DBID))
			{
				Doctrine.WRA_Weapon value = new Doctrine.WRA_Weapon(ref weapon_0, Client.smethod_46());
				this.dictionary_0.Add(weapon_0.DBID, value);
			}
		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x00049B90 File Offset: 0x00047D90
		private void method_15(object sender, EventArgs e)
		{
			this.method_16();
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x00407EB0 File Offset: 0x004060B0
		private void method_16()
		{
			if (!Class2413.smethod_2().method_41().rightColumnWPF_0.bool_1 && (!Information.IsNothing(this.class310_0) || !Information.IsNothing(this.list_0)))
			{
				switch (this.vmethod_0().SelectedIndex)
				{
				case 0:
					this.method_5();
					return;
				case 1:
					this.method_6();
					return;
				case 2:
					this.method_7();
					return;
				case 3:
					this.method_8();
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x00049B98 File Offset: 0x00047D98
		private void method_17(object sender, EventArgs e)
		{
			this.doctrine_0.method_35(Client.smethod_46(), this.vmethod_48().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x00049BCF File Offset: 0x00047DCF
		private void method_18(object sender, EventArgs e)
		{
			this.doctrine_0.method_87(Client.smethod_46(), this.vmethod_138().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x00049C06 File Offset: 0x00047E06
		private void method_19(object sender, EventArgs e)
		{
			this.int_5 = this.vmethod_136().SelectedIndex;
		}

		// Token: 0x060077AB RID: 30635 RVA: 0x00049C19 File Offset: 0x00047E19
		private void method_20(object sender, EventArgs e)
		{
			this.doctrine_0.method_67(Client.smethod_46(), this.vmethod_46().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077AC RID: 30636 RVA: 0x00049C50 File Offset: 0x00047E50
		private void method_21(object sender, EventArgs e)
		{
			this.doctrine_0.method_72(Client.smethod_46(), this.vmethod_146().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077AD RID: 30637 RVA: 0x00049C87 File Offset: 0x00047E87
		private void method_22(object sender, EventArgs e)
		{
			this.doctrine_0.method_77(Client.smethod_46(), this.vmethod_148().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077AE RID: 30638 RVA: 0x00049CBE File Offset: 0x00047EBE
		private void method_23(object sender, EventArgs e)
		{
			this.doctrine_0.method_82(Client.smethod_46(), this.vmethod_150().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077AF RID: 30639 RVA: 0x00049CF5 File Offset: 0x00047EF5
		private void method_24(object sender, EventArgs e)
		{
			this.doctrine_0.method_176(Client.smethod_46(), this.vmethod_88().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x00049D2C File Offset: 0x00047F2C
		private void method_25(object sender, EventArgs e)
		{
			this.doctrine_0.method_156(Client.smethod_46(), this.vmethod_76().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077B1 RID: 30641 RVA: 0x00049D63 File Offset: 0x00047F63
		private void method_26(object sender, EventArgs e)
		{
			this.doctrine_0.method_161(Client.smethod_46(), this.vmethod_214().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077B2 RID: 30642 RVA: 0x00049D9A File Offset: 0x00047F9A
		private void method_27(object sender, EventArgs e)
		{
			this.doctrine_0.method_171(Client.smethod_46(), this.vmethod_84().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x00049DD1 File Offset: 0x00047FD1
		private void method_28(object sender, EventArgs e)
		{
			this.doctrine_0.method_151(Client.smethod_46(), this.vmethod_160().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x00049E08 File Offset: 0x00048008
		private void method_29(object sender, EventArgs e)
		{
			this.int_0 = this.vmethod_56().SelectedIndex;
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x00049E1B File Offset: 0x0004801B
		private void method_30(object sender, EventArgs e)
		{
			this.int_16 = this.vmethod_92().SelectedIndex;
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x00049E2E File Offset: 0x0004802E
		private void method_31(object sender, EventArgs e)
		{
			this.int_17 = this.vmethod_102().SelectedIndex;
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x00049E41 File Offset: 0x00048041
		private void method_32(object sender, EventArgs e)
		{
			this.int_18 = this.vmethod_266().SelectedIndex;
		}

		// Token: 0x060077B8 RID: 30648 RVA: 0x00049E54 File Offset: 0x00048054
		private void method_33(object sender, EventArgs e)
		{
			this.int_20 = this.vmethod_268().SelectedIndex;
		}

		// Token: 0x060077B9 RID: 30649 RVA: 0x00049E67 File Offset: 0x00048067
		private void method_34(object sender, EventArgs e)
		{
			this.int_22 = this.vmethod_94().SelectedIndex;
		}

		// Token: 0x060077BA RID: 30650 RVA: 0x00049E7A File Offset: 0x0004807A
		private void method_35(object sender, EventArgs e)
		{
			this.int_1 = this.vmethod_54().SelectedIndex;
		}

		// Token: 0x060077BB RID: 30651 RVA: 0x00049E8D File Offset: 0x0004808D
		private void method_36(object sender, EventArgs e)
		{
			this.int_2 = this.vmethod_152().SelectedIndex;
		}

		// Token: 0x060077BC RID: 30652 RVA: 0x00049EA0 File Offset: 0x000480A0
		private void method_37(object sender, EventArgs e)
		{
			this.int_3 = this.vmethod_154().SelectedIndex;
		}

		// Token: 0x060077BD RID: 30653 RVA: 0x00049EB3 File Offset: 0x000480B3
		private void method_38(object sender, EventArgs e)
		{
			this.int_4 = this.vmethod_156().SelectedIndex;
		}

		// Token: 0x060077BE RID: 30654 RVA: 0x00049EC6 File Offset: 0x000480C6
		private void method_39(object sender, EventArgs e)
		{
			this.int_23 = this.vmethod_162().SelectedIndex;
		}

		// Token: 0x060077BF RID: 30655 RVA: 0x00407F2C File Offset: 0x0040612C
		private void method_40(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_56();
			Scenario scenario = Client.smethod_46();
			doctrine.method_284(comboBox_, ref scenario, ref this.int_0, true, false);
			this.method_16();
		}

		// Token: 0x060077C0 RID: 30656 RVA: 0x00407F60 File Offset: 0x00406160
		private void method_41(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_92();
			Scenario scenario = Client.smethod_46();
			doctrine.method_328(comboBox_, ref scenario, ref this.int_16, ref this.bool_3, true, false);
			this.method_16();
		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x00407F9C File Offset: 0x0040619C
		private void method_42(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_102();
			Scenario scenario = Client.smethod_46();
			doctrine.method_330(comboBox_, ref scenario, ref this.int_17, ref this.bool_3, true, false);
			this.method_16();
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x00407FD8 File Offset: 0x004061D8
		private void method_43(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_266();
			Scenario scenario = Client.smethod_46();
			doctrine.method_332(comboBox_, ref scenario, ref this.int_18, ref this.bool_3, ref this.bool_8, true, false);
			this.method_16();
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x00408018 File Offset: 0x00406218
		private void method_44(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_268();
			Scenario scenario = Client.smethod_46();
			doctrine.method_334(comboBox_, ref scenario, ref this.int_20, ref this.bool_3, true, false);
			this.method_16();
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x00408054 File Offset: 0x00406254
		private void method_45(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_94();
			Scenario scenario = Client.smethod_46();
			doctrine.method_336(comboBox_, ref scenario, ref this.int_22, true, false);
			this.method_16();
		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x00408088 File Offset: 0x00406288
		private void method_46(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_54();
			Scenario scenario = Client.smethod_46();
			doctrine.method_286(comboBox_, ref scenario, ref this.int_1, true, false);
			this.method_16();
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x004080BC File Offset: 0x004062BC
		private void method_47(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_152();
			Scenario scenario = Client.smethod_46();
			doctrine.method_288(comboBox_, ref scenario, ref this.int_2, true, false);
			this.method_16();
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x004080F0 File Offset: 0x004062F0
		private void method_48(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_154();
			Scenario scenario = Client.smethod_46();
			doctrine.method_290(comboBox_, ref scenario, ref this.int_3, true, false);
			this.method_16();
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x00408124 File Offset: 0x00406324
		private void method_49(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_156();
			Scenario scenario = Client.smethod_46();
			doctrine.method_292(comboBox_, ref scenario, ref this.int_4, true, false);
			this.method_16();
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x00408158 File Offset: 0x00406358
		private void method_50(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_162();
			Scenario scenario = Client.smethod_46();
			doctrine.method_316(comboBox_, ref scenario, ref this.int_23, true, false);
			this.method_16();
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x0040818C File Offset: 0x0040638C
		private void method_51(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_136();
			Scenario scenario = Client.smethod_46();
			doctrine.method_294(comboBox_, ref scenario, ref this.int_5, true, false);
			this.method_16();
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x00049ED9 File Offset: 0x000480D9
		private void method_52(object sender, EventArgs e)
		{
			this.doctrine_0.method_121(Client.smethod_46(), this.vmethod_42().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x004081C0 File Offset: 0x004063C0
		private void method_53(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.class310_0) && this.class310_0.GetType() == typeof(Side))
			{
				this.vmethod_10().Checked = false;
				this.vmethod_10().Enabled = false;
				return;
			}
			this.doctrine_0.method_341(this.vmethod_10(), this.vmethod_6(), this.vmethod_12(), this.vmethod_16(), ref this.doctrine_0, Client.smethod_46(), true, false);
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_6();
			Scenario scenario = Client.smethod_46();
			doctrine.method_337(comboBox_, ref scenario, ref this.doctrine_0);
			Doctrine doctrine2 = this.doctrine_0;
			ComboBox comboBox_2 = this.vmethod_12();
			scenario = Client.smethod_46();
			doctrine2.method_338(comboBox_2, ref scenario, ref this.doctrine_0);
			Doctrine doctrine3 = this.doctrine_0;
			ComboBox comboBox_3 = this.vmethod_16();
			scenario = Client.smethod_46();
			doctrine3.method_339(comboBox_3, ref scenario, ref this.doctrine_0);
		}

		// Token: 0x060077CD RID: 30669 RVA: 0x00408298 File Offset: 0x00406498
		private void method_54(object sender, EventArgs e)
		{
			ComboBox comboBox_ = this.vmethod_6();
			Scenario scenario = Client.smethod_46();
			bool flag = false;
			bool flag2 = !this.bool_6 && !this.bool_7;
			EmconControl.smethod_1(comboBox_, ref scenario, ref this.doctrine_0, flag, ref flag2, ref this.bool_8, true, false);
			Client.bool_1 = true;
			this.method_16();
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x004082EC File Offset: 0x004064EC
		private void method_55(object sender, EventArgs e)
		{
			ComboBox comboBox_ = this.vmethod_12();
			Scenario scenario = Client.smethod_46();
			bool flag = false;
			bool flag2 = !this.bool_6 && !this.bool_7;
			EmconControl.smethod_2(comboBox_, ref scenario, ref this.doctrine_0, flag, ref flag2, ref this.bool_8, true, false);
			Client.bool_1 = true;
			this.method_16();
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x00408340 File Offset: 0x00406540
		private void method_56(object sender, EventArgs e)
		{
			ComboBox comboBox_ = this.vmethod_16();
			Scenario scenario = Client.smethod_46();
			bool flag = false;
			bool flag2 = !this.bool_6 && !this.bool_7;
			EmconControl.smethod_3(comboBox_, ref scenario, ref this.doctrine_0, flag, ref flag2, ref this.bool_8, true, false);
			Client.bool_1 = true;
			this.method_16();
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x00049F10 File Offset: 0x00048110
		private void method_57(object sender, EventArgs e)
		{
			this.int_21 = this.vmethod_52().SelectedIndex;
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x00408394 File Offset: 0x00406594
		private void method_58(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_52();
			Scenario scenario = Client.smethod_46();
			doctrine.method_296(comboBox_, ref scenario, ref this.int_21, true, false);
			this.method_16();
		}

		// Token: 0x060077D2 RID: 30674 RVA: 0x00049F23 File Offset: 0x00048123
		private void method_59(object sender, EventArgs e)
		{
			this.int_19 = this.vmethod_272().SelectedIndex;
		}

		// Token: 0x060077D3 RID: 30675 RVA: 0x004083C8 File Offset: 0x004065C8
		private void method_60(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_272();
			Scenario scenario = Client.smethod_46();
			doctrine.method_298(comboBox_, ref scenario, ref this.int_19, true, false);
			this.method_16();
		}

		// Token: 0x060077D4 RID: 30676 RVA: 0x00049F36 File Offset: 0x00048136
		private void method_61(object sender, EventArgs e)
		{
			this.int_6 = this.vmethod_270().SelectedIndex;
		}

		// Token: 0x060077D5 RID: 30677 RVA: 0x004083FC File Offset: 0x004065FC
		private void method_62(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_270();
			Scenario scenario = Client.smethod_46();
			doctrine.method_300(comboBox_, ref scenario, ref this.int_6, true, false);
			this.method_16();
		}

		// Token: 0x060077D6 RID: 30678 RVA: 0x00049F49 File Offset: 0x00048149
		private void method_63(object sender, EventArgs e)
		{
			this.int_7 = this.vmethod_292().SelectedIndex;
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x00408430 File Offset: 0x00406630
		private void method_64(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_292();
			Scenario scenario = Client.smethod_46();
			doctrine.method_302(comboBox_, ref scenario, ref this.int_7, true, false);
			this.method_16();
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x00049F5C File Offset: 0x0004815C
		private void method_65(object sender, EventArgs e)
		{
			this.int_8 = this.vmethod_60().SelectedIndex;
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x00408464 File Offset: 0x00406664
		private void method_66(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_60();
			Scenario scenario = Client.smethod_46();
			doctrine.method_304(comboBox_, ref scenario, ref this.int_8, true, false);
			this.method_16();
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x00049F6F File Offset: 0x0004816F
		private void method_67(object sender, EventArgs e)
		{
			this.doctrine_0.method_92(Client.smethod_46(), this.vmethod_62().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x00049FA6 File Offset: 0x000481A6
		private void method_68(object sender, EventArgs e)
		{
			this.int_9 = this.vmethod_66().SelectedIndex;
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x00408498 File Offset: 0x00406698
		private void method_69(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_66();
			Scenario scenario = Client.smethod_46();
			doctrine.method_306(comboBox_, ref scenario, ref this.int_9, true, false);
			this.method_16();
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x00049FB9 File Offset: 0x000481B9
		private void method_70(object sender, EventArgs e)
		{
			this.doctrine_0.method_141(Client.smethod_46(), this.vmethod_68().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077DE RID: 30686 RVA: 0x00049FF0 File Offset: 0x000481F0
		private void method_71(object sender, EventArgs e)
		{
			this.doctrine_0.method_146(Client.smethod_46(), this.vmethod_72().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x004084CC File Offset: 0x004066CC
		private void method_72(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_70();
			Scenario scenario = Client.smethod_46();
			doctrine.method_308(comboBox_, ref scenario, ref this.int_10, true, false);
			this.method_16();
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x0004A027 File Offset: 0x00048227
		private void method_73(object sender, EventArgs e)
		{
			this.int_13 = this.vmethod_78().SelectedIndex;
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x00408500 File Offset: 0x00406700
		private void method_74(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_78();
			Scenario scenario = Client.smethod_46();
			doctrine.method_322(comboBox_, ref scenario, ref this.int_13, true, false);
			Doctrine doctrine2 = this.doctrine_0;
			scenario = Client.smethod_46();
			Side side_ = Client.smethod_50();
			doctrine2.method_357(ref scenario, ref side_);
			Client.smethod_51(side_);
			this.method_16();
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x0004A03A File Offset: 0x0004823A
		private void method_75(object sender, EventArgs e)
		{
			this.int_11 = this.vmethod_74().SelectedIndex;
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x00408558 File Offset: 0x00406758
		private void method_76(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			int selectedIndex = this.vmethod_74().SelectedIndex;
			Scenario scenario = Client.smethod_46();
			doctrine.method_318(selectedIndex, ref scenario, ref this.int_11, true, false, false);
			this.method_16();
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x0004A04D File Offset: 0x0004824D
		private void method_77(object sender, EventArgs e)
		{
			this.int_12 = this.vmethod_216().SelectedIndex;
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x00408594 File Offset: 0x00406794
		private void method_78(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			int selectedIndex = this.vmethod_216().SelectedIndex;
			Scenario scenario = Client.smethod_46();
			doctrine.method_320(selectedIndex, ref scenario, ref this.int_12, true, false, false);
			this.method_16();
		}

		// Token: 0x060077E6 RID: 30694 RVA: 0x0004A060 File Offset: 0x00048260
		private void method_79(object sender, EventArgs e)
		{
			this.doctrine_0.method_181(Client.smethod_46(), this.vmethod_302().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x004085D0 File Offset: 0x004067D0
		private void method_80(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_308();
			Scenario scenario = Client.smethod_46();
			doctrine.method_310(comboBox_, ref scenario, ref this.int_31, true, false);
			this.method_16();
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x0004A097 File Offset: 0x00048297
		private void method_81(object sender, EventArgs e)
		{
			this.doctrine_0.method_186(Client.smethod_46(), this.vmethod_304().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x00408604 File Offset: 0x00406804
		private void method_82(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_310();
			Scenario scenario = Client.smethod_46();
			doctrine.method_312(comboBox_, ref scenario, ref this.int_32, true, false);
			this.method_16();
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x0004A0CE File Offset: 0x000482CE
		private void method_83(object sender, EventArgs e)
		{
			this.doctrine_0.method_191(Client.smethod_46(), this.vmethod_306().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x00408638 File Offset: 0x00406838
		private void method_84(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_312();
			Scenario scenario = Client.smethod_46();
			doctrine.method_314(comboBox_, ref scenario, ref this.int_33, true, false);
			this.method_16();
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x0040866C File Offset: 0x0040686C
		private void DoctrineForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (Operators.CompareString(e.KeyValue.ToString(), "120", false) == 0 && e.Control && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060077ED RID: 30701 RVA: 0x0004A105 File Offset: 0x00048305
		private void method_85(object sender, EventArgs e)
		{
			this.doctrine_0.method_166(Client.smethod_46(), this.vmethod_80().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077EE RID: 30702 RVA: 0x0004A13C File Offset: 0x0004833C
		private void method_86(object sender, EventArgs e)
		{
			this.doctrine_0.method_171(Client.smethod_46(), this.vmethod_84().Checked);
		}

		// Token: 0x060077EF RID: 30703 RVA: 0x0004A159 File Offset: 0x00048359
		private void method_87(object sender, EventArgs e)
		{
			this.int_14 = this.vmethod_82().SelectedIndex;
		}

		// Token: 0x060077F0 RID: 30704 RVA: 0x00408754 File Offset: 0x00406954
		private void method_88(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_82();
			Scenario scenario = Client.smethod_46();
			doctrine.method_324(comboBox_, ref scenario, ref this.int_15, true, false);
			this.method_16();
		}

		// Token: 0x060077F1 RID: 30705 RVA: 0x0004A16C File Offset: 0x0004836C
		private void method_89(object sender, EventArgs e)
		{
			this.doctrine_0.method_176(Client.smethod_46(), this.vmethod_88().Checked);
		}

		// Token: 0x060077F2 RID: 30706 RVA: 0x0004A189 File Offset: 0x00048389
		private void method_90(object sender, EventArgs e)
		{
			this.int_15 = this.vmethod_86().SelectedIndex;
		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x00408788 File Offset: 0x00406988
		private void method_91(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_86();
			Scenario scenario = Client.smethod_46();
			doctrine.method_326(comboBox_, ref scenario, ref this.int_15, true, false);
			this.method_16();
		}

		// Token: 0x060077F4 RID: 30708 RVA: 0x0004A19C File Offset: 0x0004839C
		private void method_92(object sender, EventArgs e)
		{
			this.doctrine_0.method_205(Client.smethod_46(), this.vmethod_104().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077F5 RID: 30709 RVA: 0x0004A1D3 File Offset: 0x000483D3
		private void method_93(object sender, EventArgs e)
		{
			this.doctrine_0.method_200(Client.smethod_46(), this.vmethod_96().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077F6 RID: 30710 RVA: 0x0004A20A File Offset: 0x0004840A
		private void method_94(object sender, EventArgs e)
		{
			this.doctrine_0.method_215(Client.smethod_46(), this.vmethod_226().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077F7 RID: 30711 RVA: 0x0004A241 File Offset: 0x00048441
		private void method_95(object sender, EventArgs e)
		{
			this.doctrine_0.method_210(Client.smethod_46(), this.vmethod_224().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077F8 RID: 30712 RVA: 0x0004A278 File Offset: 0x00048478
		private void method_96(object sender, EventArgs e)
		{
			this.doctrine_0.method_220(Client.smethod_46(), this.vmethod_98().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x004087BC File Offset: 0x004069BC
		private void method_97(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex != -1)
				{
					if (e.ColumnIndex != -1)
					{
						try
						{
							foreach (Class48 @class in this.vmethod_22().method_2())
							{
								if (@class.Selected)
								{
									break;
								}
								int key = ((KeyValuePair<int, Doctrine.WRA_Weapon>)@class.Tag).Key;
								Weapon weapon = ((KeyValuePair<int, Doctrine.WRA_Weapon>)@class.Tag).Value.method_1(Client.smethod_46(), key);
								try
								{
									foreach (Class48 class2 in @class.method_7())
									{
										if (class2.Selected)
										{
											DataTable dataSource = new DataTable();
											DataTable dataSource2 = new DataTable();
											DataTable dataSource3 = new DataTable();
											DataTable dataSource4 = new DataTable();
											Doctrine._WRA_WeaponTargetType wra_WeaponTargetType_ = ((Doctrine.Class276)class2.Tag)._WRA_WeaponTargetType_0;
											DataGridViewColumn dataGridViewColumn = this.vmethod_22().Columns[e.ColumnIndex];
											if (Operators.CompareString(dataGridViewColumn.Name, "WeaponsPerSalvo", false) != 0)
											{
												if (Operators.CompareString(dataGridViewColumn.Name, "ShootersPerSalvo", false) != 0)
												{
													if (Operators.CompareString(dataGridViewColumn.Name, "SelfDefenceRange", false) != 0)
													{
														if (Operators.CompareString(dataGridViewColumn.Name, "FiringRange", false) != 0)
														{
															continue;
														}
														DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.vmethod_22()[this.vmethod_208().Index, class2.method_1()];
														this.doctrine_0.method_224(ref dataSource4, wra_WeaponTargetType_, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell.Value), !Information.IsNothing(this.list_0) && this.list_0.Count > 1);
														DataGridViewComboBoxCell dataGridViewComboBoxCell2 = dataGridViewComboBoxCell;
														dataGridViewComboBoxCell2.DataSource = dataSource4;
														dataGridViewComboBoxCell2.DropDownWidth = 500;
														dataGridViewComboBoxCell2.DisplayMember = "Description";
														dataGridViewComboBoxCell2.ValueMember = "ID";
														this.vmethod_22().BeginEdit(true);
														((DataGridViewComboBoxEditingControl)this.vmethod_22().EditingControl).DroppedDown = true;
													}
													else
													{
														DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)this.vmethod_22()[this.vmethod_210().Index, class2.method_1()];
														this.doctrine_0.method_223(ref dataSource3, wra_WeaponTargetType_, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell3.Value), !Information.IsNothing(this.list_0) && this.list_0.Count > 1);
														DataGridViewComboBoxCell dataGridViewComboBoxCell4 = dataGridViewComboBoxCell3;
														dataGridViewComboBoxCell4.DataSource = dataSource3;
														dataGridViewComboBoxCell4.DropDownWidth = 500;
														dataGridViewComboBoxCell4.DisplayMember = "Description";
														dataGridViewComboBoxCell4.ValueMember = "ID";
														this.vmethod_22().BeginEdit(true);
														((DataGridViewComboBoxEditingControl)this.vmethod_22().EditingControl).DroppedDown = true;
													}
												}
												else
												{
													DataGridViewComboBoxCell dataGridViewComboBoxCell5 = (DataGridViewComboBoxCell)this.vmethod_22()[this.vmethod_206().Index, class2.method_1()];
													this.doctrine_0.method_222(ref dataSource2, wra_WeaponTargetType_, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell5.Value), !Information.IsNothing(this.list_0) && this.list_0.Count > 1);
													DataGridViewComboBoxCell dataGridViewComboBoxCell6 = dataGridViewComboBoxCell5;
													dataGridViewComboBoxCell6.DataSource = dataSource2;
													dataGridViewComboBoxCell6.DisplayMember = "Description";
													dataGridViewComboBoxCell6.ValueMember = "ID";
													dataGridViewComboBoxCell6.DropDownWidth = 500;
													this.vmethod_22().BeginEdit(true);
													((DataGridViewComboBoxEditingControl)this.vmethod_22().EditingControl).DroppedDown = true;
												}
											}
											else
											{
												DataGridViewComboBoxCell dataGridViewComboBoxCell7 = (DataGridViewComboBoxCell)this.vmethod_22()[this.vmethod_204().Index, class2.method_1()];
												this.doctrine_0.method_221(ref dataSource, wra_WeaponTargetType_, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell7.Value), !Information.IsNothing(this.list_0) && this.list_0.Count > 1);
												DataGridViewComboBoxCell dataGridViewComboBoxCell8 = dataGridViewComboBoxCell7;
												dataGridViewComboBoxCell8.DataSource = dataSource;
												dataGridViewComboBoxCell8.DisplayMember = "Description";
												dataGridViewComboBoxCell8.ValueMember = "ID";
												dataGridViewComboBoxCell8.DropDownWidth = 500;
												this.vmethod_22().BeginEdit(true);
												((DataGridViewComboBoxEditingControl)this.vmethod_22().EditingControl).DroppedDown = true;
											}
											break;
										}
									}
								}
								finally
								{
									IEnumerator<Class48> enumerator2;
									if (enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200123", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x00408C88 File Offset: 0x00406E88
		private void method_98(object sender, DataGridViewCellEventArgs e)
		{
			if (this.bool_4 && this.vmethod_22().SelectedRows.Count != 0)
			{
				Class48 class3;
				try
				{
					foreach (Class48 @class in this.vmethod_22().method_2())
					{
						bool flag;
						try
						{
							foreach (Class48 class2 in @class.method_7())
							{
								if (class2.Selected)
								{
									class3 = class2;
									flag = true;
									break;
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						if (flag)
						{
							break;
						}
					}
				}
				finally
				{
					IEnumerator<Class48> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (!Information.IsNothing(class3) && !Information.IsNothing(class3.method_9()))
				{
					Class48 class48_ = class3.method_9();
					this.method_100(e, class3, class48_);
				}
			}
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x0004A2AF File Offset: 0x000484AF
		private void method_99(object sender, EventArgs e)
		{
			this.bool_4 = true;
			if (this.vmethod_22().IsCurrentCellDirty)
			{
				this.vmethod_22().CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x00408D6C File Offset: 0x00406F6C
		private void method_100(DataGridViewCellEventArgs dataGridViewCellEventArgs_0, Class48 class48_0, Class48 class48_1)
		{
			RuntimeHelpers.GetObjectValue(this.vmethod_22()[dataGridViewCellEventArgs_0.ColumnIndex, dataGridViewCellEventArgs_0.RowIndex].Value);
			object objectValue = RuntimeHelpers.GetObjectValue(this.vmethod_22()[this.vmethod_204().Index, dataGridViewCellEventArgs_0.RowIndex].Value);
			object objectValue2 = RuntimeHelpers.GetObjectValue(this.vmethod_22()[this.vmethod_206().Index, dataGridViewCellEventArgs_0.RowIndex].Value);
			object objectValue3 = RuntimeHelpers.GetObjectValue(this.vmethod_22()[this.vmethod_210().Index, dataGridViewCellEventArgs_0.RowIndex].Value);
			object objectValue4 = RuntimeHelpers.GetObjectValue(this.vmethod_22()[this.vmethod_208().Index, dataGridViewCellEventArgs_0.RowIndex].Value);
			Doctrine._WRA_WeaponTargetType wra_WeaponTargetType_ = ((Doctrine.Class276)class48_0.Tag)._WRA_WeaponTargetType_0;
			bool bool_;
			int? nullable_;
			if (dataGridViewCellEventArgs_0.RowIndex != -1 && dataGridViewCellEventArgs_0.ColumnIndex == this.vmethod_204().Index)
			{
				bool_ = true;
				nullable_ = this.doctrine_0.method_227(ref wra_WeaponTargetType_, ref objectValue);
			}
			bool bool_2;
			int? nullable_2;
			if (dataGridViewCellEventArgs_0.RowIndex != -1 && dataGridViewCellEventArgs_0.ColumnIndex == this.vmethod_206().Index)
			{
				bool_2 = true;
				nullable_2 = this.doctrine_0.method_229(ref objectValue2);
			}
			bool bool_3;
			int? nullable_3;
			if (dataGridViewCellEventArgs_0.RowIndex != -1 && dataGridViewCellEventArgs_0.ColumnIndex == this.vmethod_210().Index)
			{
				bool_3 = true;
				nullable_3 = this.doctrine_0.method_231(ref wra_WeaponTargetType_, ref objectValue3);
			}
			bool bool_4;
			int? nullable_4;
			if (dataGridViewCellEventArgs_0.RowIndex != -1 && dataGridViewCellEventArgs_0.ColumnIndex == this.vmethod_208().Index)
			{
				bool_4 = true;
				nullable_4 = this.doctrine_0.method_233(ref objectValue4);
			}
			int key = ((KeyValuePair<int, Doctrine.WRA_Weapon>)class48_1.Tag).Key;
			KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair = (KeyValuePair<int, Doctrine.WRA_Weapon>)class48_1.Tag;
			this.method_101(ref this.doctrine_0, nullable_, bool_, nullable_2, bool_2, nullable_4, bool_4, nullable_3, bool_3, key, wra_WeaponTargetType_);
			if (!Information.IsNothing(this.list_0))
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.list_0)
					{
						this.method_101(ref activeUnit.doctrine_0, nullable_, bool_, nullable_2, bool_2, nullable_4, bool_4, nullable_3, bool_3, key, wra_WeaponTargetType_);
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (this.doctrine_0.method_29(ref wra_WeaponTargetType_))
			{
				this.method_16();
			}
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x00408FCC File Offset: 0x004071CC
		private void method_101(ref Doctrine doctrine_1, int? nullable_42, bool bool_9, int? nullable_43, bool bool_10, int? nullable_44, bool bool_11, int? nullable_45, bool bool_12, int int_42, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			new Doctrine.Class276();
			bool flag;
			if (!Information.IsNothing(doctrine_1.method_27()) && doctrine_1.method_27().ContainsKey(int_42))
			{
				Doctrine.WRA_Weapon wra_Weapon = new Doctrine.WRA_Weapon();
				doctrine_1.method_27().TryGetValue(int_42, out wra_Weapon);
				if (!Information.IsNothing(wra_Weapon))
				{
					foreach (Doctrine.Class276 @class in wra_Weapon.class276_0)
					{
						if (@class._WRA_WeaponTargetType_0 == _WRA_WeaponTargetType_0)
						{
							if (bool_9)
							{
								@class.nullable_0 = nullable_42;
							}
							else if (bool_10)
							{
								@class.nullable_1 = nullable_43;
							}
							else if (bool_12)
							{
								@class.nullable_3 = nullable_45;
							}
							else if (bool_11)
							{
								@class.nullable_2 = nullable_44;
							}
							flag = true;
						}
					}
				}
			}
			checked
			{
				if (!flag)
				{
					if (Information.IsNothing(doctrine_1.method_27()))
					{
						doctrine_1.method_28(new Dictionary<int, Doctrine.WRA_Weapon>());
					}
					if (!doctrine_1.method_27().ContainsKey(int_42))
					{
						doctrine_1.method_27().Add(int_42, null);
					}
					Doctrine.WRA_Weapon wra_Weapon2 = new Doctrine.WRA_Weapon();
					doctrine_1.method_27().TryGetValue(int_42, out wra_Weapon2);
					if (Information.IsNothing(wra_Weapon2))
					{
						wra_Weapon2 = new Doctrine.WRA_Weapon();
						if (doctrine_1.method_27().ContainsKey(int_42))
						{
							doctrine_1.method_27()[int_42] = wra_Weapon2;
						}
					}
					Doctrine.Class276[] class276_2 = wra_Weapon2.class276_0;
					int j = 0;
					while (j < class276_2.Length)
					{
						if (class276_2[j]._WRA_WeaponTargetType_0 == _WRA_WeaponTargetType_0)
						{
							bool flag2 = true;
							IL_15D:
							Doctrine.Class276 class2 = new Doctrine.Class276(_WRA_WeaponTargetType_0);
							if (!flag2)
							{
								if (bool_9)
								{
									class2.nullable_0 = nullable_42;
								}
								else if (bool_10)
								{
									class2.nullable_1 = nullable_43;
								}
								else if (bool_12)
								{
									class2.nullable_3 = nullable_45;
								}
								else if (bool_11)
								{
									class2.nullable_2 = nullable_44;
								}
								Class429.smethod_46(ref wra_Weapon2.class276_0, class2);
								goto IL_1B0;
							}
							goto IL_1B0;
						}
						else
						{
							j++;
						}
					}
					goto IL_15D;
				}
				IL_1B0:
				if (!Information.IsNothing(doctrine_1.method_27()) && Information.IsNothing(nullable_42) && Information.IsNothing(nullable_43) && Information.IsNothing(nullable_45) && Information.IsNothing(nullable_44))
				{
					List<Doctrine.Class276> list = new List<Doctrine.Class276>();
					Doctrine.WRA_Weapon wra_Weapon3 = new Doctrine.WRA_Weapon();
					if (doctrine_1.method_27().Count > 0)
					{
						doctrine_1.method_27().TryGetValue(int_42, out wra_Weapon3);
						if (!Information.IsNothing(wra_Weapon3.class276_0))
						{
							foreach (Doctrine.Class276 class3 in wra_Weapon3.class276_0)
							{
								if (class3._WRA_WeaponTargetType_0 == _WRA_WeaponTargetType_0 && Information.IsNothing(class3.nullable_0) && Information.IsNothing(class3.nullable_3) && Information.IsNothing(class3.nullable_2))
								{
									list.Add(class3);
								}
							}
							if (list.Count > 0)
							{
								try
								{
									foreach (Doctrine.Class276 class276_4 in list)
									{
										Class429.smethod_47(ref wra_Weapon3.class276_0, class276_4);
									}
								}
								finally
								{
									List<Doctrine.Class276>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
							}
							if (Enumerable.Count<Doctrine.Class276>(wra_Weapon3.class276_0) == 0)
							{
								wra_Weapon3.class276_0 = null;
							}
						}
					}
					if (Information.IsNothing(wra_Weapon3.class276_0))
					{
						doctrine_1.method_27().Remove(int_42);
					}
					if (Information.IsNothing(doctrine_1.method_27()) || doctrine_1.method_27().Count == 0)
					{
						doctrine_1.method_28(null);
					}
				}
			}
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x0040933C File Offset: 0x0040753C
		private void method_102(object sender, EventArgs1 e)
		{
			if (e.method_0().method_8() == 1)
			{
				int key = ((KeyValuePair<int, Doctrine.WRA_Weapon>)e.method_0().Tag).Key;
				if (!this.list_1.Contains(key))
				{
					this.list_1.Add(key);
				}
				Weapon weapon = ((KeyValuePair<int, Doctrine.WRA_Weapon>)e.method_0().Tag).Value.method_1(Client.smethod_46(), key);
				KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair = (KeyValuePair<int, Doctrine.WRA_Weapon>)e.method_0().Tag;
				e.method_0().method_7().Clear();
				foreach (Doctrine.Class276 @class in keyValuePair.Value.class276_0)
				{
					int num = this.doctrine_0.method_228(ref @class._WRA_WeaponTargetType_0, @class.nullable_0);
					int num2 = this.doctrine_0.method_230(@class.nullable_1);
					int num3 = this.doctrine_0.method_232(ref @class._WRA_WeaponTargetType_0, @class.nullable_3);
					int num4 = this.doctrine_0.method_234(@class.nullable_2);
					Class48 class2 = e.method_0().method_7().method_1(new object[]
					{
						Doctrine.smethod_8(@class._WRA_WeaponTargetType_0),
						num,
						num2,
						num4,
						num3
					});
					class2.Tag = @class;
					if (this.doctrine_0.method_29(ref @class._WRA_WeaponTargetType_0))
					{
						class2.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
					}
				}
				try
				{
					foreach (Class48 class3 in e.method_0().method_7())
					{
						DataTable dataSource = new DataTable();
						DataTable dataSource2 = new DataTable();
						DataTable dataSource3 = new DataTable();
						DataTable dataSource4 = new DataTable();
						Doctrine._WRA_WeaponTargetType wra_WeaponTargetType_ = ((Doctrine.Class276)class3.Tag)._WRA_WeaponTargetType_0;
						DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)class3.Cells[this.vmethod_204().Index];
						DataGridViewComboBoxCell dataGridViewComboBoxCell2 = (DataGridViewComboBoxCell)class3.Cells[this.vmethod_206().Index];
						DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)class3.Cells[this.vmethod_210().Index];
						DataGridViewComboBoxCell dataGridViewComboBoxCell4 = (DataGridViewComboBoxCell)class3.Cells[this.vmethod_208().Index];
						this.doctrine_0.method_221(ref dataSource, wra_WeaponTargetType_, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell.Value), !Information.IsNothing(this.list_0) && this.list_0.Count > 1);
						this.doctrine_0.method_222(ref dataSource2, wra_WeaponTargetType_, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell2.Value), !Information.IsNothing(this.list_0) && this.list_0.Count > 1);
						this.doctrine_0.method_223(ref dataSource3, wra_WeaponTargetType_, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell3.Value), !Information.IsNothing(this.list_0) && this.list_0.Count > 1);
						this.doctrine_0.method_224(ref dataSource4, wra_WeaponTargetType_, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell4.Value), !Information.IsNothing(this.list_0) && this.list_0.Count > 1);
						DataGridViewComboBoxCell dataGridViewComboBoxCell5 = dataGridViewComboBoxCell;
						dataGridViewComboBoxCell5.DataSource = dataSource;
						dataGridViewComboBoxCell5.DisplayMember = "Description";
						dataGridViewComboBoxCell5.ValueMember = "ID";
						DataGridViewComboBoxCell dataGridViewComboBoxCell6 = dataGridViewComboBoxCell2;
						dataGridViewComboBoxCell6.DataSource = dataSource2;
						dataGridViewComboBoxCell6.DisplayMember = "Description";
						dataGridViewComboBoxCell6.ValueMember = "ID";
						DataGridViewComboBoxCell dataGridViewComboBoxCell7 = dataGridViewComboBoxCell3;
						dataGridViewComboBoxCell7.DataSource = dataSource3;
						dataGridViewComboBoxCell7.DisplayMember = "Description";
						dataGridViewComboBoxCell7.ValueMember = "ID";
						DataGridViewComboBoxCell dataGridViewComboBoxCell8 = dataGridViewComboBoxCell4;
						dataGridViewComboBoxCell8.DataSource = dataSource4;
						dataGridViewComboBoxCell8.DisplayMember = "Description";
						dataGridViewComboBoxCell8.ValueMember = "ID";
					}
				}
				finally
				{
					IEnumerator<Class48> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x00409740 File Offset: 0x00407940
		private void method_103(object sender, EventArgs0 e)
		{
			if (e.method_0().method_8() == 1)
			{
				this.list_1.Remove(((KeyValuePair<int, Doctrine.WRA_Weapon>)e.method_0().Tag).Key);
			}
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x00409780 File Offset: 0x00407980
		private void method_104(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.list_0))
			{
				if (!Information.IsNothing(this.doctrine_0.method_27()))
				{
					this.doctrine_0.method_28(null);
				}
				try
				{
					foreach (ActiveUnit activeUnit in this.list_0)
					{
						if (!Information.IsNothing(activeUnit.doctrine_0.method_27()))
						{
							activeUnit.doctrine_0.method_28(null);
						}
					}
					goto IL_1EF;
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (this.class310_0.GetType() == typeof(Side))
			{
				if (!Information.IsNothing(((Side)this.class310_0).doctrine_0.method_27()))
				{
					((Side)this.class310_0).doctrine_0.method_28(null);
				}
			}
			else if (this.class310_0.bool_9)
			{
				if (this.bool_8)
				{
					if (((Strike)this.class310_0)._MissionClass_0 == Mission._MissionClass.Strike && !Information.IsNothing(((Strike)this.class310_0).doctrine_1.method_27()))
					{
						((Strike)this.class310_0).doctrine_1.method_28(null);
					}
				}
				else if (!Information.IsNothing(((Mission)this.class310_0).doctrine_0.method_27()))
				{
					((Mission)this.class310_0).doctrine_0.method_28(null);
				}
			}
			else if (this.class310_0.bool_1)
			{
				if (!Information.IsNothing(((Group)this.class310_0).doctrine_0.method_27()))
				{
					((Group)this.class310_0).doctrine_0.method_28(null);
				}
			}
			else if (this.class310_0.bool_0)
			{
				ActiveUnit activeUnit2 = (ActiveUnit)this.class310_0;
				if (activeUnit2.bool_2)
				{
					return;
				}
				if (!Information.IsNothing(activeUnit2.doctrine_0.method_27()))
				{
					activeUnit2.doctrine_0.method_28(null);
				}
			}
			IL_1EF:
			this.method_7();
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x00409994 File Offset: 0x00407B94
		private void method_105(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.list_0))
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.list_0)
					{
						try
						{
							foreach (ActiveUnit activeUnit2 in activeUnit.doctrine_0.method_5(Client.smethod_46(), new bool?(this.bool_8)))
							{
								if (activeUnit2.bool_1)
								{
									if (!Information.IsNothing(activeUnit2.doctrine_0.method_27()))
									{
										activeUnit2.doctrine_0.method_28(null);
									}
								}
								else if (activeUnit2.bool_0 && !activeUnit2.bool_2 && !Information.IsNothing(activeUnit2.doctrine_0.method_27()))
								{
									activeUnit2.doctrine_0.method_28(null);
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
					return;
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (!Information.IsNothing(this.class310_0))
			{
				if (this.class310_0.GetType() == typeof(Side))
				{
					foreach (ActiveUnit activeUnit3 in Client.smethod_50().activeUnit_0)
					{
						if (!activeUnit3.bool_2 && !Information.IsNothing(activeUnit3.doctrine_0.method_27()))
						{
							activeUnit3.doctrine_0.method_28(null);
						}
					}
					return;
				}
				try
				{
					foreach (ActiveUnit activeUnit4 in this.doctrine_0.method_5(Client.smethod_46(), new bool?(this.bool_8)))
					{
						if (activeUnit4.bool_1)
						{
							if (!Information.IsNothing(activeUnit4.doctrine_0.method_27()))
							{
								activeUnit4.doctrine_0.method_28(null);
							}
						}
						else if (activeUnit4.bool_0 && !activeUnit4.bool_2 && !Information.IsNothing(activeUnit4.doctrine_0.method_27()))
						{
							activeUnit4.doctrine_0.method_28(null);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
			}
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x00409BC8 File Offset: 0x00407DC8
		private void method_106(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.class310_0) && this.class310_0.GetType() == typeof(Side))
			{
				try
				{
					foreach (Mission mission in Client.smethod_50().method_35())
					{
						if (!Information.IsNothing(mission.doctrine_0.method_27()))
						{
							mission.doctrine_0.method_28(null);
						}
					}
				}
				finally
				{
					IEnumerator<Mission> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x00409C54 File Offset: 0x00407E54
		private void method_107(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.list_0))
			{
				ActiveUnit activeUnit = null;
				Doctrine.smethod_10(ref activeUnit, ref this.doctrine_0, Client.smethod_46());
				try
				{
					foreach (ActiveUnit activeUnit2 in this.list_0)
					{
						if (!activeUnit2.bool_2)
						{
							Doctrine.smethod_10(ref activeUnit2, ref activeUnit2.doctrine_0, Client.smethod_46());
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.doctrine_0 = this.method_114();
			}
			else
			{
				if (this.class310_0.GetType() != typeof(Side))
				{
					if (this.class310_0.bool_9)
					{
						Doctrine doctrine_;
						if (this.bool_8)
						{
							doctrine_ = ((Strike)this.class310_0).doctrine_1;
						}
						else
						{
							doctrine_ = ((Mission)this.class310_0).doctrine_0;
						}
						ActiveUnit activeUnit = null;
						Doctrine.smethod_10(ref activeUnit, ref doctrine_, Client.smethod_46());
					}
					else if (this.class310_0.bool_1)
					{
						Doctrine doctrine = ((Group)this.class310_0).doctrine_0;
						ActiveUnit activeUnit = null;
						Doctrine.smethod_10(ref activeUnit, ref doctrine, Client.smethod_46());
					}
					else if (this.class310_0.bool_0)
					{
						ActiveUnit activeUnit3 = (ActiveUnit)this.class310_0;
						if (activeUnit3.bool_2)
						{
							return;
						}
						Doctrine.smethod_10(ref activeUnit3, ref activeUnit3.doctrine_0, Client.smethod_46());
					}
				}
				this.doctrine_0.method_4();
			}
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(true);
			this.method_5();
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x00409DE4 File Offset: 0x00407FE4
		private void method_108(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.list_0))
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.list_0)
					{
						try
						{
							foreach (ActiveUnit activeUnit2 in activeUnit.doctrine_0.method_5(Client.smethod_46(), new bool?(this.bool_8)))
							{
								if (activeUnit2.bool_1)
								{
									Doctrine.smethod_10(ref activeUnit2, ref activeUnit2.doctrine_0, Client.smethod_46());
								}
								else if (activeUnit2.bool_0 && !activeUnit2.bool_2)
								{
									Doctrine.smethod_10(ref activeUnit2, ref activeUnit2.doctrine_0, Client.smethod_46());
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
					return;
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (!Information.IsNothing(this.class310_0))
			{
				if (this.class310_0.GetType() == typeof(Side))
				{
					foreach (ActiveUnit activeUnit3 in Client.smethod_50().activeUnit_0)
					{
						if (activeUnit3.bool_1)
						{
							Doctrine.smethod_10(ref activeUnit3, ref activeUnit3.doctrine_0, Client.smethod_46());
						}
						else if (activeUnit3.bool_0 && !activeUnit3.bool_2)
						{
							Doctrine.smethod_10(ref activeUnit3, ref activeUnit3.doctrine_0, Client.smethod_46());
						}
					}
				}
				else
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.doctrine_0.method_5(Client.smethod_46(), new bool?(this.bool_8)))
						{
							if (activeUnit4.bool_1)
							{
								Doctrine.smethod_10(ref activeUnit4, ref activeUnit4.doctrine_0, Client.smethod_46());
							}
							else if (activeUnit4.bool_0 && !activeUnit4.bool_2)
							{
								Doctrine.smethod_10(ref activeUnit4, ref activeUnit4.doctrine_0, Client.smethod_46());
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
			}
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(true);
			this.method_5();
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x0040A024 File Offset: 0x00408224
		private void method_109(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.class310_0) && this.class310_0.GetType() == typeof(Side))
			{
				try
				{
					foreach (Mission mission in Client.smethod_50().method_35())
					{
						ActiveUnit activeUnit = null;
						Doctrine.smethod_10(ref activeUnit, ref mission.doctrine_0, Client.smethod_46());
					}
				}
				finally
				{
					IEnumerator<Mission> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(true);
			this.method_5();
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x0040A0C8 File Offset: 0x004082C8
		private void method_110(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.list_0))
			{
				ActiveUnit activeUnit = null;
				Doctrine.smethod_10(ref activeUnit, ref this.doctrine_0, Client.smethod_46());
				try
				{
					foreach (Unit unit in this.list_0)
					{
						if (unit.bool_1)
						{
							if (!((Group)unit).doctrine_0.method_7())
							{
								((Group)unit).doctrine_0.method_8(true);
							}
						}
						else if (unit.bool_0)
						{
							ActiveUnit activeUnit2 = (ActiveUnit)unit;
							if (activeUnit2.bool_2)
							{
								return;
							}
							if (!activeUnit2.doctrine_0.method_7())
							{
								activeUnit2.doctrine_0.method_8(true);
							}
						}
					}
					goto IL_1C8;
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (this.class310_0.GetType() != typeof(Side))
			{
				if (this.class310_0.bool_9)
				{
					if (this.bool_8)
					{
						if (!((Strike)this.class310_0).doctrine_1.method_7())
						{
							((Strike)this.class310_0).doctrine_1.method_8(true);
						}
					}
					else if (!((Mission)this.class310_0).doctrine_0.method_7())
					{
						((Mission)this.class310_0).doctrine_0.method_8(true);
					}
				}
				else if (this.class310_0.bool_1)
				{
					if (!((Group)this.class310_0).doctrine_0.method_7())
					{
						((Group)this.class310_0).doctrine_0.method_8(true);
					}
				}
				else if (this.class310_0.bool_0)
				{
					ActiveUnit activeUnit3 = (ActiveUnit)this.class310_0;
					if (activeUnit3.bool_2)
					{
						return;
					}
					if (!activeUnit3.doctrine_0.method_7())
					{
						activeUnit3.doctrine_0.method_8(true);
					}
				}
			}
			IL_1C8:
			if (!this.bool_6 && !this.bool_7)
			{
				Scenario scenario = Client.smethod_46();
				EmconControl.smethod_4(ref scenario, ref this.doctrine_0, ref this.bool_8, true, false);
				Client.bool_1 = true;
			}
			Class2413.smethod_2().method_41().method_97().class2424_0.method_0(true);
			this.method_6();
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x0040A300 File Offset: 0x00408500
		private void method_111(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.list_0))
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.list_0)
					{
						try
						{
							foreach (ActiveUnit activeUnit2 in activeUnit.doctrine_0.method_5(Client.smethod_46(), new bool?(this.bool_8)))
							{
								if (activeUnit2.bool_1)
								{
									if (!activeUnit2.doctrine_0.method_7())
									{
										activeUnit2.doctrine_0.method_8(true);
									}
								}
								else if (activeUnit2.bool_0)
								{
									if (activeUnit2.bool_2)
									{
										continue;
									}
									if (!activeUnit2.doctrine_0.method_7())
									{
										activeUnit2.doctrine_0.method_8(true);
									}
								}
								activeUnit2.vmethod_88().vmethod_5(activeUnit2.method_78());
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
					goto IL_241;
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			checked
			{
				if (this.class310_0.GetType() == typeof(Side))
				{
					ActiveUnit[] activeUnit_ = Client.smethod_50().activeUnit_0;
					int i = 0;
					while (i < activeUnit_.Length)
					{
						ActiveUnit activeUnit3 = activeUnit_[i];
						if (activeUnit3.bool_1)
						{
							if (!activeUnit3.doctrine_0.method_7())
							{
								activeUnit3.doctrine_0.method_8(true);
								goto IL_16E;
							}
							goto IL_16E;
						}
						else
						{
							if (!activeUnit3.bool_0)
							{
								goto IL_16E;
							}
							if (!activeUnit3.bool_2)
							{
								if (!activeUnit3.doctrine_0.method_7())
								{
									activeUnit3.doctrine_0.method_8(true);
									goto IL_16E;
								}
								goto IL_16E;
							}
						}
						IL_181:
						i++;
						continue;
						IL_16E:
						activeUnit3.vmethod_88().vmethod_5(activeUnit3.method_78());
						goto IL_181;
					}
				}
				else
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.doctrine_0.method_5(Client.smethod_46(), new bool?(this.bool_8)))
						{
							if (activeUnit4.bool_1)
							{
								if (!activeUnit4.doctrine_0.method_7())
								{
									activeUnit4.doctrine_0.method_8(true);
								}
							}
							else if (activeUnit4.bool_0)
							{
								if (activeUnit4.bool_2)
								{
									continue;
								}
								if (!activeUnit4.doctrine_0.method_7())
								{
									activeUnit4.doctrine_0.method_8(true);
								}
							}
							activeUnit4.vmethod_88().vmethod_5(activeUnit4.method_78());
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				IL_241:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (Unit unit in this.list_0)
						{
							((ActiveUnit)unit).doctrine_0.method_2(unit, new bool?(false), true, true, false, false);
						}
						goto IL_2B7;
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.doctrine_0.method_2(this.class310_0, new bool?(false), false, true, false, false);
				IL_2B7:
				Client.bool_1 = true;
				Class2413.smethod_2().method_41().method_97().class2424_0.method_0(true);
				this.method_6();
			}
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x0040A620 File Offset: 0x00408820
		private void method_112(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.class310_0) && this.class310_0.GetType() == typeof(Side))
			{
				try
				{
					foreach (Mission mission in Client.smethod_50().method_35())
					{
						if (!mission.doctrine_0.method_7())
						{
							mission.doctrine_0.method_8(true);
						}
					}
				}
				finally
				{
					IEnumerator<Mission> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			if (!Information.IsNothing(this.list_0))
			{
				try
				{
					foreach (Unit unit in this.list_0)
					{
						((ActiveUnit)unit).doctrine_0.method_2(unit, new bool?(false), true, true, false, false);
					}
					goto IL_DC;
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			this.doctrine_0.method_2(this.class310_0, new bool?(false), false, true, false, false);
			IL_DC:
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_97().class2424_0.method_0(true);
			this.method_6();
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x0004A2D6 File Offset: 0x000484D6
		private void DoctrineForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Doctrine.smethod_1(new Doctrine.Delegate28(this.method_3));
			Doctrine.smethod_3(new Doctrine.Delegate29(this.method_4));
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x0040A74C File Offset: 0x0040894C
		private void DoctrineForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
			checked
			{
				if (!Information.IsNothing(this.class310_0) && this.class310_0.GetType() == typeof(Waypoint))
				{
					bool flag = false;
					Waypoint waypoint = (Waypoint)this.class310_0;
					Side[] array = Client.smethod_46().method_44();
					int i = 0;
					while (i < array.Length)
					{
						Side side = array[i];
						try
						{
							foreach (Mission mission in side.method_35())
							{
								try
								{
									foreach (Mission.Flight flight in mission.list_1)
									{
										if (Enumerable.Contains<Waypoint>(flight.method_15(), waypoint))
										{
											Scenario scenario_ = Client.smethod_46();
											Mission mission_ = mission;
											ActiveUnit activeUnit_ = flight.method_32(Client.smethod_46());
											Mission.Flight flight_ = flight;
											Mission.Flight flight2;
											Waypoint[] waypoint_ = (flight2 = flight).method_15();
											float num = 0f;
											float num2 = 0f;
											Class514.smethod_28(scenario_, mission_, activeUnit_, flight_, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
											flight2.method_16(waypoint_);
											Class2413.smethod_2().method_41().method_235();
											flag = true;
											break;
										}
									}
								}
								finally
								{
									List<Mission.Flight>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
								if (flag)
								{
									break;
								}
							}
							goto IL_174;
						}
						finally
						{
							IEnumerator<Mission> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						IL_16B:
						i++;
						continue;
						IL_174:
						if (flag)
						{
							break;
						}
						goto IL_16B;
					}
					if (Client.smethod_32().Visible)
					{
						Client.smethod_32().method_13();
					}
				}
			}
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x0040A904 File Offset: 0x00408B04
		private void method_113(object sender, MouseEventArgs e)
		{
			Side side_;
			Scenario scenario;
			if (!Information.IsNothing(this.list_0))
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.list_0)
					{
						Doctrine doctrine = activeUnit.doctrine_0;
						side_ = Client.smethod_50();
						scenario = Client.smethod_46();
						doctrine.method_342(ref side_, ref scenario, ref this.bool_8);
						Client.smethod_51(side_);
					}
					goto IL_88;
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			Doctrine doctrine2 = this.doctrine_0;
			side_ = Client.smethod_50();
			scenario = Client.smethod_46();
			doctrine2.method_342(ref side_, ref scenario, ref this.bool_8);
			Client.smethod_51(side_);
			IL_88:
			this.bool_5 = false;
			this.doctrine_0.method_2(this.class310_0, new bool?(false), !Information.IsNothing(this.list_0) && this.list_0.Count > 1, true, false, false);
			this.bool_5 = true;
			Client.bool_1 = true;
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x0040A9F8 File Offset: 0x00408BF8
		private Doctrine method_114()
		{
			int num = 0;
			try
			{
				foreach (ActiveUnit activeUnit in this.list_0)
				{
					activeUnit.doctrine_0.method_4();
					num++;
					if (num == 1)
					{
						Aircraft aircraft = new Aircraft(ref activeUnit.scenario_0, null);
						aircraft.vmethod_8(false, activeUnit.vmethod_7(false));
						if (!Information.IsNothing(activeUnit.vmethod_101()))
						{
							ActiveUnit activeUnit2 = aircraft;
							Mission value = activeUnit.vmethod_101();
							bool setMissionOnly = true;
							Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
							activeUnit2.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
						}
						aircraft.method_158().bool_2 = activeUnit.vmethod_86().bool_2;
						if (activeUnit.bool_3)
						{
							aircraft.method_164().method_37(((Aircraft)activeUnit).method_164().method_36());
						}
						else
						{
							aircraft.vmethod_93().method_9(activeUnit.vmethod_93().method_8());
						}
						this.doctrine_0 = new Doctrine(aircraft, ref this.list_0);
						this.nullable_0 = null;
						this.nullable_1 = null;
						this.nullable_2 = null;
						this.nullable_3 = null;
						this.nullable_4 = null;
						this.nullable_23 = null;
						this.nullable_5 = null;
						this.nullable_6 = null;
						this.nullable_21 = null;
						this.nullable_20 = null;
						this.nullable_7 = null;
						this.nullable_10 = null;
						this.nullable_11 = null;
						this.nullable_12 = null;
						this.nullable_13 = null;
						this.nullable_14 = null;
						this.nullable_15 = null;
						this.nullable_16 = null;
						this.nullable_17 = null;
						this.nullable_18 = null;
						this.nullable_19 = null;
						this.nullable_22 = null;
						this.enum66_0 = Doctrine.Class275.Enum66.const_0;
						this.enum66_1 = Doctrine.Class275.Enum66.const_0;
						this.enum66_2 = Doctrine.Class275.Enum66.const_0;
						this.nullable_24 = null;
						this.nullable_25 = null;
						this.nullable_26 = null;
						this.nullable_27 = null;
						this.nullable_27 = null;
						this.nullable_29 = null;
						this.nullable_30 = null;
						this.nullable_8 = null;
						this.nullable_31 = null;
						this.nullable_32 = null;
						this.nullable_33 = null;
						this.nullable_34 = null;
						this.nullable_35 = null;
						this.nullable_36 = null;
						this.nullable_37 = null;
						this.nullable_38 = null;
						this.nullable_39 = null;
						this.nullable_40 = null;
						this.nullable_41 = null;
						if (!activeUnit.doctrine_0.method_33())
						{
							this.doctrine_0.method_32(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_31(Client.smethod_46(), false, false, false));
							Doctrine doctrine = activeUnit.doctrine_0;
							Scenario scenario_ = Client.smethod_46();
							bool flag = true;
							this.nullable_0 = doctrine.method_3(scenario_, ref flag).method_31(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_0 = activeUnit.doctrine_0.method_31(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_65())
						{
							this.doctrine_0.method_64(Client.smethod_46(), false, new bool?(false), true, true, activeUnit.doctrine_0.method_63(Client.smethod_46(), false, new bool?(false), false, false));
							Doctrine doctrine2 = activeUnit.doctrine_0;
							Scenario scenario_2 = Client.smethod_46();
							bool flag = true;
							this.nullable_1 = doctrine2.method_3(scenario_2, ref flag).method_63(Client.smethod_46(), true, null, false, false);
						}
						else
						{
							this.nullable_1 = activeUnit.doctrine_0.method_63(Client.smethod_46(), false, new bool?(false), false, false);
						}
						if (!activeUnit.doctrine_0.method_70())
						{
							this.doctrine_0.method_69(Client.smethod_46(), false, new bool?(false), true, true, activeUnit.doctrine_0.method_68(Client.smethod_46(), false, new bool?(false), false, false));
							Doctrine doctrine3 = activeUnit.doctrine_0;
							Scenario scenario_3 = Client.smethod_46();
							bool flag = true;
							this.nullable_2 = doctrine3.method_3(scenario_3, ref flag).method_68(Client.smethod_46(), true, null, false, false);
						}
						else
						{
							this.nullable_2 = activeUnit.doctrine_0.method_68(Client.smethod_46(), false, new bool?(false), false, false);
						}
						if (!activeUnit.doctrine_0.method_75())
						{
							this.doctrine_0.method_74(Client.smethod_46(), false, new bool?(false), true, true, activeUnit.doctrine_0.method_73(Client.smethod_46(), false, new bool?(false), false, false));
							Doctrine doctrine4 = activeUnit.doctrine_0;
							Scenario scenario_4 = Client.smethod_46();
							bool flag = true;
							this.nullable_3 = doctrine4.method_3(scenario_4, ref flag).method_73(Client.smethod_46(), true, null, false, false);
						}
						else
						{
							this.nullable_3 = activeUnit.doctrine_0.method_73(Client.smethod_46(), false, new bool?(false), false, false);
						}
						if (!activeUnit.doctrine_0.method_80())
						{
							this.doctrine_0.method_79(Client.smethod_46(), false, new bool?(false), true, true, activeUnit.doctrine_0.method_78(Client.smethod_46(), false, new bool?(false), false, false));
							Doctrine doctrine5 = activeUnit.doctrine_0;
							Scenario scenario_5 = Client.smethod_46();
							bool flag = true;
							this.nullable_4 = doctrine5.method_3(scenario_5, ref flag).method_78(Client.smethod_46(), true, null, false, false);
						}
						else
						{
							this.nullable_4 = activeUnit.doctrine_0.method_78(Client.smethod_46(), false, new bool?(false), false, false);
						}
						if (!activeUnit.doctrine_0.method_149())
						{
							this.doctrine_0.method_148(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_147(Client.smethod_46(), false, false, false));
							Doctrine doctrine6 = activeUnit.doctrine_0;
							Scenario scenario_6 = Client.smethod_46();
							bool flag = true;
							this.nullable_23 = doctrine6.method_3(scenario_6, ref flag).method_147(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_23 = activeUnit.doctrine_0.method_147(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_85())
						{
							this.doctrine_0.method_84(Client.smethod_46(), false, new bool?(false), true, true, activeUnit.doctrine_0.method_83(Client.smethod_46(), false, new bool?(false), false, false));
							Doctrine doctrine7 = activeUnit.doctrine_0;
							Scenario scenario_7 = Client.smethod_46();
							bool flag = true;
							this.nullable_5 = doctrine7.method_3(scenario_7, ref flag).method_83(Client.smethod_46(), true, null, false, false);
						}
						else
						{
							this.nullable_5 = activeUnit.doctrine_0.method_83(Client.smethod_46(), false, new bool?(false), false, false);
						}
						if (!activeUnit.doctrine_0.method_119())
						{
							this.doctrine_0.method_118(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_117(Client.smethod_46(), false, false, false));
							Doctrine doctrine8 = activeUnit.doctrine_0;
							Scenario scenario_8 = Client.smethod_46();
							bool flag = true;
							this.nullable_6 = doctrine8.method_3(scenario_8, ref flag).method_117(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_6 = activeUnit.doctrine_0.method_117(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_213())
						{
							this.doctrine_0.method_212(Client.smethod_46(), false, false, true, true, activeUnit.doctrine_0.method_211(Client.smethod_46(), false, false, false, false));
							Doctrine doctrine9 = activeUnit.doctrine_0;
							Scenario scenario_9 = Client.smethod_46();
							bool flag = true;
							this.nullable_21 = doctrine9.method_3(scenario_9, ref flag).method_211(Client.smethod_46(), true, false, false, false);
						}
						else
						{
							this.nullable_21 = activeUnit.doctrine_0.method_211(Client.smethod_46(), false, false, false, false);
						}
						if (!activeUnit.doctrine_0.method_124())
						{
							this.doctrine_0.method_123(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_122(Client.smethod_46(), false, false, false));
							Doctrine doctrine10 = activeUnit.doctrine_0;
							Scenario scenario_10 = Client.smethod_46();
							bool flag = true;
							this.nullable_7 = doctrine10.method_3(scenario_10, ref flag).method_122(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_7 = activeUnit.doctrine_0.method_122(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_208())
						{
							this.doctrine_0.method_207(Client.smethod_46(), false, false, true, true, activeUnit.doctrine_0.method_206(Client.smethod_46(), false, false, false, false));
							Doctrine doctrine11 = activeUnit.doctrine_0;
							Scenario scenario_11 = Client.smethod_46();
							bool flag = true;
							this.nullable_20 = doctrine11.method_3(scenario_11, ref flag).method_206(Client.smethod_46(), true, false, false, false);
						}
						else
						{
							this.nullable_20 = activeUnit.doctrine_0.method_206(Client.smethod_46(), false, false, false, false);
						}
						if (!activeUnit.doctrine_0.method_90())
						{
							this.doctrine_0.method_89(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_88(Client.smethod_46(), false, false, false));
							Doctrine doctrine12 = activeUnit.doctrine_0;
							Scenario scenario_12 = Client.smethod_46();
							bool flag = true;
							this.nullable_10 = doctrine12.method_3(scenario_12, ref flag).method_88(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_10 = activeUnit.doctrine_0.method_88(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_139())
						{
							this.doctrine_0.method_138(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_137(Client.smethod_46(), false, false, false));
							Doctrine doctrine13 = activeUnit.doctrine_0;
							Scenario scenario_13 = Client.smethod_46();
							bool flag = true;
							this.nullable_11 = doctrine13.method_3(scenario_13, ref flag).method_137(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_11 = activeUnit.doctrine_0.method_137(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_144())
						{
							this.doctrine_0.method_143(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_142(Client.smethod_46(), false, false, false));
							Doctrine doctrine14 = activeUnit.doctrine_0;
							Scenario scenario_14 = Client.smethod_46();
							bool flag = true;
							this.nullable_12 = doctrine14.method_3(scenario_14, ref flag).method_142(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_12 = activeUnit.doctrine_0.method_142(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_154())
						{
							this.doctrine_0.method_153(Client.smethod_46(), false, true, true, false, activeUnit.doctrine_0.method_152(Client.smethod_46(), false, false, false, false));
							Doctrine doctrine15 = activeUnit.doctrine_0;
							Scenario scenario_15 = Client.smethod_46();
							bool flag = true;
							this.nullable_13 = doctrine15.method_3(scenario_15, ref flag).method_152(Client.smethod_46(), true, false, false, false);
						}
						else
						{
							this.nullable_13 = activeUnit.doctrine_0.method_152(Client.smethod_46(), false, false, false, false);
						}
						if (!activeUnit.doctrine_0.method_159())
						{
							this.doctrine_0.method_158(Client.smethod_46(), false, true, true, false, activeUnit.doctrine_0.method_157(Client.smethod_46(), false, false, false, false));
							Doctrine doctrine16 = activeUnit.doctrine_0;
							Scenario scenario_16 = Client.smethod_46();
							bool flag = true;
							this.nullable_14 = doctrine16.method_3(scenario_16, ref flag).method_157(Client.smethod_46(), true, false, false, false);
						}
						else
						{
							this.nullable_14 = activeUnit.doctrine_0.method_157(Client.smethod_46(), false, false, false, false);
						}
						if (!activeUnit.doctrine_0.method_164())
						{
							this.doctrine_0.method_163(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_162(Client.smethod_46(), false, false, false));
							Doctrine doctrine17 = activeUnit.doctrine_0;
							Scenario scenario_17 = Client.smethod_46();
							bool flag = true;
							this.nullable_15 = doctrine17.method_3(scenario_17, ref flag).method_162(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_15 = activeUnit.doctrine_0.method_162(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_169())
						{
							this.doctrine_0.method_168(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_167(Client.smethod_46(), false, false, false));
							Doctrine doctrine18 = activeUnit.doctrine_0;
							Scenario scenario_18 = Client.smethod_46();
							bool flag = true;
							this.nullable_16 = doctrine18.method_3(scenario_18, ref flag).method_167(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_16 = activeUnit.doctrine_0.method_167(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_174())
						{
							this.doctrine_0.method_173(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_172(Client.smethod_46(), false, false, false));
							Doctrine doctrine19 = activeUnit.doctrine_0;
							Scenario scenario_19 = Client.smethod_46();
							bool flag = true;
							this.nullable_17 = doctrine19.method_3(scenario_19, ref flag).method_172(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_17 = activeUnit.doctrine_0.method_172(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_198())
						{
							this.doctrine_0.method_197(Client.smethod_46(), false, this.bool_3, true, true, activeUnit.doctrine_0.method_196(Client.smethod_46(), false, this.bool_3, false, false));
							this.nullable_18 = activeUnit.doctrine_0.method_3(Client.smethod_46(), ref this.bool_3).method_196(Client.smethod_46(), true, true, false, false);
						}
						else
						{
							this.nullable_18 = activeUnit.doctrine_0.method_196(Client.smethod_46(), false, this.bool_3, false, false);
						}
						if (!activeUnit.doctrine_0.method_203())
						{
							this.doctrine_0.method_202(Client.smethod_46(), false, this.bool_3, true, true, activeUnit.doctrine_0.method_201(Client.smethod_46(), false, this.bool_3, false, false));
							this.nullable_19 = activeUnit.doctrine_0.method_3(Client.smethod_46(), ref this.bool_3).method_201(Client.smethod_46(), true, true, false, false);
						}
						else
						{
							this.nullable_19 = activeUnit.doctrine_0.method_201(Client.smethod_46(), false, this.bool_3, false, false);
						}
						if (!activeUnit.doctrine_0.method_218())
						{
							this.doctrine_0.method_217(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_216(Client.smethod_46(), false, false, false));
							Doctrine doctrine20 = activeUnit.doctrine_0;
							Scenario scenario_20 = Client.smethod_46();
							bool flag = true;
							this.nullable_22 = doctrine20.method_3(scenario_20, ref flag).method_216(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_22 = activeUnit.doctrine_0.method_216(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_95())
						{
							this.doctrine_0.method_94(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_93(Client.smethod_46(), false, false, false));
							Doctrine doctrine21 = activeUnit.doctrine_0;
							Scenario scenario_21 = Client.smethod_46();
							bool flag = true;
							this.nullable_34 = doctrine21.method_3(scenario_21, ref flag).method_93(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_34 = activeUnit.doctrine_0.method_93(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_98())
						{
							this.doctrine_0.method_97(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_96(Client.smethod_46(), false, false, false));
							Doctrine doctrine22 = activeUnit.doctrine_0;
							Scenario scenario_22 = Client.smethod_46();
							bool flag = true;
							this.nullable_35 = doctrine22.method_3(scenario_22, ref flag).method_96(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_35 = activeUnit.doctrine_0.method_96(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_101())
						{
							this.doctrine_0.method_100(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_99(Client.smethod_46(), false, false, false));
							Doctrine doctrine23 = activeUnit.doctrine_0;
							Scenario scenario_23 = Client.smethod_46();
							bool flag = true;
							this.nullable_36 = doctrine23.method_3(scenario_23, ref flag).method_99(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_36 = activeUnit.doctrine_0.method_99(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_104())
						{
							this.doctrine_0.method_103(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_102(Client.smethod_46(), false, false, false));
							Doctrine doctrine24 = activeUnit.doctrine_0;
							Scenario scenario_24 = Client.smethod_46();
							bool flag = true;
							this.nullable_37 = doctrine24.method_3(scenario_24, ref flag).method_102(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_37 = activeUnit.doctrine_0.method_102(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_107())
						{
							this.doctrine_0.method_106(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_105(Client.smethod_46(), false, false, false));
							Doctrine doctrine25 = activeUnit.doctrine_0;
							Scenario scenario_25 = Client.smethod_46();
							bool flag = true;
							this.nullable_38 = doctrine25.method_3(scenario_25, ref flag).method_105(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_38 = activeUnit.doctrine_0.method_105(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_110())
						{
							this.doctrine_0.method_109(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_108(Client.smethod_46(), false, false, false));
							Doctrine doctrine26 = activeUnit.doctrine_0;
							Scenario scenario_26 = Client.smethod_46();
							bool flag = true;
							this.nullable_39 = doctrine26.method_3(scenario_26, ref flag).method_108(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_39 = activeUnit.doctrine_0.method_108(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_113())
						{
							this.doctrine_0.method_112(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_111(Client.smethod_46(), false, false, false));
							Doctrine doctrine27 = activeUnit.doctrine_0;
							Scenario scenario_27 = Client.smethod_46();
							bool flag = true;
							this.nullable_40 = doctrine27.method_3(scenario_27, ref flag).method_111(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_40 = activeUnit.doctrine_0.method_111(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_116())
						{
							this.doctrine_0.method_115(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_114(Client.smethod_46(), false, false, false));
							Doctrine doctrine28 = activeUnit.doctrine_0;
							Scenario scenario_28 = Client.smethod_46();
							bool flag = true;
							this.nullable_41 = doctrine28.method_3(scenario_28, ref flag).method_114(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_41 = activeUnit.doctrine_0.method_114(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_7())
						{
							this.doctrine_0.method_8(false);
							this.doctrine_0.method_192(activeUnit.doctrine_0.method_6(Client.smethod_46()).method_1(), Client.smethod_46());
							this.doctrine_0.method_193(activeUnit.doctrine_0.method_6(Client.smethod_46()).method_2(), Client.smethod_46());
							this.doctrine_0.method_194(activeUnit.doctrine_0.method_6(Client.smethod_46()).method_3(), Client.smethod_46());
						}
						else
						{
							this.doctrine_0.method_8(true);
							this.enum66_0 = activeUnit.doctrine_0.method_6(Client.smethod_46()).method_1();
							this.enum66_1 = activeUnit.doctrine_0.method_6(Client.smethod_46()).method_2();
							this.enum66_2 = activeUnit.doctrine_0.method_6(Client.smethod_46()).method_3();
						}
						if (!activeUnit.doctrine_0.method_242())
						{
							this.doctrine_0.method_241(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_240(Client.smethod_46(), false, false, false));
							Doctrine doctrine29 = activeUnit.doctrine_0;
							Scenario scenario_29 = Client.smethod_46();
							bool flag = true;
							this.nullable_24 = doctrine29.method_3(scenario_29, ref flag).method_240(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_24 = activeUnit.doctrine_0.method_240(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_248())
						{
							this.doctrine_0.method_247(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_246(Client.smethod_46(), false, false, false));
							Doctrine doctrine30 = activeUnit.doctrine_0;
							Scenario scenario_30 = Client.smethod_46();
							bool flag = true;
							this.nullable_25 = doctrine30.method_3(scenario_30, ref flag).method_246(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_25 = activeUnit.doctrine_0.method_246(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_254())
						{
							this.doctrine_0.method_253(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_252(Client.smethod_46(), false, false, false));
							Doctrine doctrine31 = activeUnit.doctrine_0;
							Scenario scenario_31 = Client.smethod_46();
							bool flag = true;
							this.nullable_26 = doctrine31.method_3(scenario_31, ref flag).method_252(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_26 = activeUnit.doctrine_0.method_252(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_260())
						{
							this.doctrine_0.method_259(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_258(Client.smethod_46(), false, false, false));
							Doctrine doctrine32 = activeUnit.doctrine_0;
							Scenario scenario_32 = Client.smethod_46();
							bool flag = true;
							this.nullable_27 = doctrine32.method_3(scenario_32, ref flag).method_258(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_27 = activeUnit.doctrine_0.method_258(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_266())
						{
							this.doctrine_0.method_265(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_264(Client.smethod_46(), false, false, false));
							Doctrine doctrine33 = activeUnit.doctrine_0;
							Scenario scenario_33 = Client.smethod_46();
							bool flag = true;
							this.nullable_28 = doctrine33.method_3(scenario_33, ref flag).method_264(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_28 = activeUnit.doctrine_0.method_264(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_272())
						{
							this.doctrine_0.method_271(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_270(Client.smethod_46(), false, false, false));
							Doctrine doctrine34 = activeUnit.doctrine_0;
							Scenario scenario_34 = Client.smethod_46();
							bool flag = true;
							this.nullable_29 = doctrine34.method_3(scenario_34, ref flag).method_270(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_29 = activeUnit.doctrine_0.method_270(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_278())
						{
							this.doctrine_0.method_277(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_276(Client.smethod_46(), false, false, false));
							Doctrine doctrine35 = activeUnit.doctrine_0;
							Scenario scenario_35 = Client.smethod_46();
							bool flag = true;
							this.nullable_30 = doctrine35.method_3(scenario_35, ref flag).method_276(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_30 = activeUnit.doctrine_0.method_276(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_129())
						{
							this.doctrine_0.method_128(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_127(Client.smethod_46(), false, false, false));
							Doctrine doctrine36 = activeUnit.doctrine_0;
							Scenario scenario_36 = Client.smethod_46();
							bool flag = true;
							this.nullable_8 = doctrine36.method_3(scenario_36, ref flag).method_127(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_8 = activeUnit.doctrine_0.method_127(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_134())
						{
							this.doctrine_0.method_133(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_132(Client.smethod_46(), false, false, false));
							Doctrine doctrine37 = activeUnit.doctrine_0;
							Scenario scenario_37 = Client.smethod_46();
							bool flag = true;
							this.nullable_9 = doctrine37.method_3(scenario_37, ref flag).method_132(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_9 = activeUnit.doctrine_0.method_132(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_179())
						{
							this.doctrine_0.method_178(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_177(Client.smethod_46(), false, false, false));
							Doctrine doctrine38 = activeUnit.doctrine_0;
							Scenario scenario_38 = Client.smethod_46();
							bool flag = true;
							this.nullable_31 = doctrine38.method_3(scenario_38, ref flag).method_177(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_31 = activeUnit.doctrine_0.method_177(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_184())
						{
							this.doctrine_0.method_183(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_182(Client.smethod_46(), false, false, false));
							Doctrine doctrine39 = activeUnit.doctrine_0;
							Scenario scenario_39 = Client.smethod_46();
							bool flag = true;
							this.nullable_32 = doctrine39.method_3(scenario_39, ref flag).method_182(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_32 = activeUnit.doctrine_0.method_182(Client.smethod_46(), false, false, false);
						}
						if (!activeUnit.doctrine_0.method_189())
						{
							this.doctrine_0.method_188(Client.smethod_46(), false, true, true, activeUnit.doctrine_0.method_187(Client.smethod_46(), false, false, false));
							Doctrine doctrine40 = activeUnit.doctrine_0;
							Scenario scenario_40 = Client.smethod_46();
							bool flag = true;
							this.nullable_33 = doctrine40.method_3(scenario_40, ref flag).method_187(Client.smethod_46(), true, false, false);
						}
						else
						{
							this.nullable_33 = activeUnit.doctrine_0.method_187(Client.smethod_46(), false, false, false);
						}
					}
					else
					{
						Doctrine.Enum65? @enum = this.doctrine_0.method_31(Client.smethod_46(), false, false, false);
						byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
						bool? flag2 = (b != null) ? new bool?(b.GetValueOrDefault() == 2) : null;
						byte? b2;
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_33() && !activeUnit.doctrine_0.method_33())
							{
								@enum = this.doctrine_0.method_31(Client.smethod_46(), false, false, false);
								b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
								@enum = activeUnit.doctrine_0.method_31(Client.smethod_46(), false, false, false);
								b2 = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_32(Client.smethod_46(), false, true, true, new Doctrine.Enum65?(Doctrine.Enum65.const_2));
								}
							}
							else if (this.doctrine_0.method_33() && !activeUnit.doctrine_0.method_33())
							{
								this.doctrine_0.method_32(Client.smethod_46(), false, true, true, new Doctrine.Enum65?(Doctrine.Enum65.const_2));
							}
							else if (!this.doctrine_0.method_33() && activeUnit.doctrine_0.method_33())
							{
								this.doctrine_0.method_32(Client.smethod_46(), false, true, true, new Doctrine.Enum65?(Doctrine.Enum65.const_2));
							}
						}
						@enum = this.nullable_0;
						b2 = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_33())
							{
								@enum = this.nullable_0;
								b2 = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
								Doctrine doctrine41 = activeUnit.doctrine_0;
								Scenario scenario_41 = Client.smethod_46();
								bool flag = true;
								@enum = doctrine41.method_3(scenario_41, ref flag).method_31(Client.smethod_46(), true, false, false);
								b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_0 = new Doctrine.Enum65?(Doctrine.Enum65.const_2);
								}
							}
							else
							{
								@enum = this.nullable_0;
								b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
								@enum = activeUnit.doctrine_0.method_31(Client.smethod_46(), false, false, false);
								b2 = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_0 = new Doctrine.Enum65?(Doctrine.Enum65.const_2);
								}
							}
						}
						Doctrine.Enum52? enum2 = this.doctrine_0.method_63(Client.smethod_46(), false, new bool?(false), false, false);
						b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_65() && !activeUnit.doctrine_0.method_65())
							{
								enum2 = this.doctrine_0.method_63(Client.smethod_46(), false, new bool?(false), false, false);
								b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								enum2 = activeUnit.doctrine_0.method_63(Client.smethod_46(), false, new bool?(false), false, false);
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_64(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_3));
								}
							}
							else if (this.doctrine_0.method_65() && !activeUnit.doctrine_0.method_65())
							{
								this.doctrine_0.method_64(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_3));
							}
							else if (!this.doctrine_0.method_65() && activeUnit.doctrine_0.method_65())
							{
								this.doctrine_0.method_64(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_3));
							}
						}
						enum2 = this.nullable_1;
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_65())
							{
								enum2 = this.nullable_1;
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								Doctrine doctrine42 = activeUnit.doctrine_0;
								Scenario scenario_42 = Client.smethod_46();
								bool flag = true;
								enum2 = doctrine42.method_3(scenario_42, ref flag).method_63(Client.smethod_46(), false, new bool?(true), false, false);
								b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_1 = new Doctrine.Enum52?(Doctrine.Enum52.const_3);
								}
							}
							else
							{
								enum2 = this.nullable_1;
								b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								enum2 = activeUnit.doctrine_0.method_63(Client.smethod_46(), false, new bool?(false), false, false);
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_1 = new Doctrine.Enum52?(Doctrine.Enum52.const_3);
								}
							}
						}
						enum2 = this.doctrine_0.method_68(Client.smethod_46(), false, new bool?(false), false, false);
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_70() && !activeUnit.doctrine_0.method_70())
							{
								enum2 = this.doctrine_0.method_68(Client.smethod_46(), false, new bool?(false), false, false);
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								enum2 = activeUnit.doctrine_0.method_68(Client.smethod_46(), false, new bool?(false), false, false);
								b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_69(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_3));
								}
							}
							else if (this.doctrine_0.method_70() && !activeUnit.doctrine_0.method_70())
							{
								this.doctrine_0.method_69(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_3));
							}
							else if (!this.doctrine_0.method_70() && activeUnit.doctrine_0.method_70())
							{
								this.doctrine_0.method_69(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_3));
							}
						}
						enum2 = this.nullable_2;
						b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_70())
							{
								enum2 = this.nullable_2;
								b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								Doctrine doctrine43 = activeUnit.doctrine_0;
								Scenario scenario_43 = Client.smethod_46();
								bool flag = true;
								enum2 = doctrine43.method_3(scenario_43, ref flag).method_68(Client.smethod_46(), false, new bool?(true), false, false);
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_2 = new Doctrine.Enum52?(Doctrine.Enum52.const_3);
								}
							}
							else
							{
								enum2 = this.nullable_2;
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								enum2 = activeUnit.doctrine_0.method_68(Client.smethod_46(), false, new bool?(false), false, false);
								b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_2 = new Doctrine.Enum52?(Doctrine.Enum52.const_3);
								}
							}
						}
						enum2 = this.doctrine_0.method_73(Client.smethod_46(), false, new bool?(false), false, false);
						b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_75() && !activeUnit.doctrine_0.method_75())
							{
								enum2 = this.doctrine_0.method_73(Client.smethod_46(), false, new bool?(false), false, false);
								b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								enum2 = activeUnit.doctrine_0.method_73(Client.smethod_46(), false, new bool?(false), false, false);
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_74(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_3));
								}
							}
							else if (this.doctrine_0.method_75() && !activeUnit.doctrine_0.method_75())
							{
								this.doctrine_0.method_74(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_3));
							}
							else if (!this.doctrine_0.method_75() && activeUnit.doctrine_0.method_75())
							{
								this.doctrine_0.method_74(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_3));
							}
						}
						enum2 = this.nullable_3;
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_75())
							{
								enum2 = this.nullable_3;
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								Doctrine doctrine44 = activeUnit.doctrine_0;
								Scenario scenario_44 = Client.smethod_46();
								bool flag = true;
								enum2 = doctrine44.method_3(scenario_44, ref flag).method_73(Client.smethod_46(), false, new bool?(true), false, false);
								b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_3 = new Doctrine.Enum52?(Doctrine.Enum52.const_3);
								}
							}
							else
							{
								enum2 = this.nullable_3;
								b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								enum2 = activeUnit.doctrine_0.method_73(Client.smethod_46(), false, new bool?(false), false, false);
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_3 = new Doctrine.Enum52?(Doctrine.Enum52.const_3);
								}
							}
						}
						enum2 = this.doctrine_0.method_78(Client.smethod_46(), false, new bool?(false), false, false);
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_80() && !activeUnit.doctrine_0.method_80())
							{
								enum2 = this.doctrine_0.method_78(Client.smethod_46(), false, new bool?(false), false, false);
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								enum2 = activeUnit.doctrine_0.method_78(Client.smethod_46(), false, new bool?(false), false, false);
								b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_79(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_3));
								}
							}
							else if (this.doctrine_0.method_80() && !activeUnit.doctrine_0.method_80())
							{
								this.doctrine_0.method_79(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_3));
							}
							else if (!this.doctrine_0.method_80() && activeUnit.doctrine_0.method_80())
							{
								this.doctrine_0.method_79(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_3));
							}
						}
						enum2 = this.nullable_4;
						b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_80())
							{
								enum2 = this.nullable_4;
								b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								Doctrine doctrine45 = activeUnit.doctrine_0;
								Scenario scenario_45 = Client.smethod_46();
								bool flag = true;
								enum2 = doctrine45.method_3(scenario_45, ref flag).method_78(Client.smethod_46(), false, new bool?(true), false, false);
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_4 = new Doctrine.Enum52?(Doctrine.Enum52.const_3);
								}
							}
							else
							{
								enum2 = this.nullable_4;
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								enum2 = activeUnit.doctrine_0.method_78(Client.smethod_46(), false, new bool?(false), false, false);
								b2 = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_4 = new Doctrine.Enum52?(Doctrine.Enum52.const_3);
								}
							}
						}
						Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = this.doctrine_0.method_147(Client.smethod_46(), false, false, false);
						b2 = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_149() && !activeUnit.doctrine_0.method_149())
							{
								gunStrafeGroundTargets = this.doctrine_0.method_147(Client.smethod_46(), false, false, false);
								b2 = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
								gunStrafeGroundTargets = activeUnit.doctrine_0.method_147(Client.smethod_46(), false, false, false);
								b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_148(Client.smethod_46(), false, true, true, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Various));
								}
							}
							else if (this.doctrine_0.method_149() && !activeUnit.doctrine_0.method_149())
							{
								this.doctrine_0.method_148(Client.smethod_46(), false, true, true, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Various));
							}
							else if (!this.doctrine_0.method_149() && activeUnit.doctrine_0.method_149())
							{
								this.doctrine_0.method_148(Client.smethod_46(), false, true, true, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Various));
							}
						}
						gunStrafeGroundTargets = this.nullable_23;
						b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_149())
							{
								gunStrafeGroundTargets = this.nullable_23;
								b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
								Doctrine doctrine46 = activeUnit.doctrine_0;
								Scenario scenario_46 = Client.smethod_46();
								bool flag = true;
								gunStrafeGroundTargets = doctrine46.method_3(scenario_46, ref flag).method_147(Client.smethod_46(), false, false, false);
								b2 = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_23 = new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Various);
								}
							}
							else
							{
								gunStrafeGroundTargets = this.nullable_23;
								b2 = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
								gunStrafeGroundTargets = activeUnit.doctrine_0.method_147(Client.smethod_46(), false, false, false);
								b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_23 = new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Various);
								}
							}
						}
						Doctrine.Enum64? enum3 = this.doctrine_0.method_83(Client.smethod_46(), false, new bool?(false), false, false);
						b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_85() && !activeUnit.doctrine_0.method_85())
							{
								enum3 = this.doctrine_0.method_83(Client.smethod_46(), false, new bool?(false), false, false);
								b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
								enum3 = activeUnit.doctrine_0.method_83(Client.smethod_46(), false, new bool?(false), false, false);
								b2 = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_84(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum64?(Doctrine.Enum64.const_2));
								}
							}
							else if (this.doctrine_0.method_85() && !activeUnit.doctrine_0.method_85())
							{
								this.doctrine_0.method_84(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum64?(Doctrine.Enum64.const_2));
							}
							else if (!this.doctrine_0.method_85() && activeUnit.doctrine_0.method_85())
							{
								this.doctrine_0.method_84(Client.smethod_46(), false, new bool?(false), true, true, new Doctrine.Enum64?(Doctrine.Enum64.const_2));
							}
						}
						enum3 = this.nullable_5;
						b2 = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_85())
							{
								enum3 = this.nullable_5;
								b2 = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
								Doctrine doctrine47 = activeUnit.doctrine_0;
								Scenario scenario_47 = Client.smethod_46();
								bool flag = true;
								enum3 = doctrine47.method_3(scenario_47, ref flag).method_83(Client.smethod_46(), false, new bool?(true), false, false);
								b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_5 = new Doctrine.Enum64?(Doctrine.Enum64.const_2);
								}
							}
							else
							{
								enum3 = this.nullable_5;
								b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
								enum3 = activeUnit.doctrine_0.method_83(Client.smethod_46(), false, new bool?(false), false, false);
								b2 = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_5 = new Doctrine.Enum64?(Doctrine.Enum64.const_2);
								}
							}
						}
						Doctrine._WeaponStateRTB? weaponStateRTB = this.doctrine_0.method_117(Client.smethod_46(), false, false, false);
						b2 = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 4) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_119() && !activeUnit.doctrine_0.method_119())
							{
								weaponStateRTB = this.doctrine_0.method_117(Client.smethod_46(), false, false, false);
								b2 = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
								weaponStateRTB = activeUnit.doctrine_0.method_117(Client.smethod_46(), false, false, false);
								b = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_118(Client.smethod_46(), false, true, true, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.Various));
								}
							}
							else if (this.doctrine_0.method_119() && !activeUnit.doctrine_0.method_119())
							{
								this.doctrine_0.method_118(Client.smethod_46(), false, true, true, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.Various));
							}
							else if (!this.doctrine_0.method_119() && activeUnit.doctrine_0.method_119())
							{
								this.doctrine_0.method_118(Client.smethod_46(), false, true, true, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.Various));
							}
						}
						weaponStateRTB = this.nullable_6;
						b = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_119())
							{
								weaponStateRTB = this.nullable_6;
								b = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
								Doctrine doctrine48 = activeUnit.doctrine_0;
								Scenario scenario_48 = Client.smethod_46();
								bool flag = true;
								weaponStateRTB = doctrine48.method_3(scenario_48, ref flag).method_117(Client.smethod_46(), true, false, false);
								b2 = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_6 = new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.Various);
								}
							}
							else
							{
								weaponStateRTB = this.nullable_6;
								b2 = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
								weaponStateRTB = activeUnit.doctrine_0.method_117(Client.smethod_46(), false, false, false);
								b = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_6 = new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.Various);
								}
							}
						}
						Doctrine._WeaponState? weaponState = this.doctrine_0.method_211(Client.smethod_46(), false, false, false, false);
						int? num2 = (weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null;
						flag2 = ((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null);
						int? num3;
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_213() && !activeUnit.doctrine_0.method_213())
							{
								weaponState = this.doctrine_0.method_211(Client.smethod_46(), false, false, false, false);
								num2 = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
								weaponState = activeUnit.doctrine_0.method_211(Client.smethod_46(), false, false, false, false);
								num3 = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
								if (((num2 != null & num3 != null) ? new bool?(num2.GetValueOrDefault() != num3.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_212(Client.smethod_46(), false, false, true, true, new Doctrine._WeaponState?(Doctrine._WeaponState.Various));
								}
							}
							else if (this.doctrine_0.method_213() && !activeUnit.doctrine_0.method_213())
							{
								this.doctrine_0.method_212(Client.smethod_46(), false, false, true, true, new Doctrine._WeaponState?(Doctrine._WeaponState.Various));
							}
							else if (!this.doctrine_0.method_213() && activeUnit.doctrine_0.method_213())
							{
								this.doctrine_0.method_212(Client.smethod_46(), false, false, true, true, new Doctrine._WeaponState?(Doctrine._WeaponState.Various));
							}
						}
						weaponState = this.nullable_21;
						num3 = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
						flag2 = ((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_213())
							{
								weaponState = this.nullable_21;
								num3 = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
								Doctrine doctrine49 = activeUnit.doctrine_0;
								Scenario scenario_49 = Client.smethod_46();
								bool flag = true;
								weaponState = doctrine49.method_3(scenario_49, ref flag).method_211(Client.smethod_46(), true, false, false, false);
								num2 = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
								if (((num3 != null & num2 != null) ? new bool?(num3.GetValueOrDefault() != num2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_21 = new Doctrine._WeaponState?(Doctrine._WeaponState.Various);
								}
							}
							else
							{
								weaponState = this.nullable_21;
								num2 = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
								weaponState = activeUnit.doctrine_0.method_211(Client.smethod_46(), false, false, false, false);
								num3 = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
								if (((num2 != null & num3 != null) ? new bool?(num2.GetValueOrDefault() != num3.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_21 = new Doctrine._WeaponState?(Doctrine._WeaponState.Various);
								}
							}
						}
						Doctrine._FuelStateRTB? fuelStateRTB = this.doctrine_0.method_122(Client.smethod_46(), false, false, false);
						b = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_124() && !activeUnit.doctrine_0.method_124())
							{
								fuelStateRTB = this.doctrine_0.method_122(Client.smethod_46(), false, false, false);
								b = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
								fuelStateRTB = activeUnit.doctrine_0.method_122(Client.smethod_46(), false, false, false);
								b2 = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_123(Client.smethod_46(), false, true, true, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.Various));
								}
							}
							else if (this.doctrine_0.method_124() && !activeUnit.doctrine_0.method_124())
							{
								this.doctrine_0.method_123(Client.smethod_46(), false, true, true, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.Various));
							}
							else if (!this.doctrine_0.method_124() && activeUnit.doctrine_0.method_124())
							{
								this.doctrine_0.method_123(Client.smethod_46(), false, true, true, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.Various));
							}
						}
						fuelStateRTB = this.nullable_7;
						b2 = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 4) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_124())
							{
								fuelStateRTB = this.nullable_7;
								b2 = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
								Doctrine doctrine50 = activeUnit.doctrine_0;
								Scenario scenario_50 = Client.smethod_46();
								bool flag = true;
								fuelStateRTB = doctrine50.method_3(scenario_50, ref flag).method_122(Client.smethod_46(), true, false, false);
								b = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_7 = new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.Various);
								}
							}
							else
							{
								fuelStateRTB = this.nullable_7;
								b = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
								fuelStateRTB = activeUnit.doctrine_0.method_122(Client.smethod_46(), false, false, false);
								b2 = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_7 = new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.Various);
								}
							}
						}
						Doctrine._FuelState? fuelState = this.doctrine_0.method_206(Client.smethod_46(), false, false, false, false);
						b2 = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 12) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_208() && !activeUnit.doctrine_0.method_208())
							{
								fuelState = this.doctrine_0.method_206(Client.smethod_46(), false, false, false, false);
								b2 = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
								fuelState = activeUnit.doctrine_0.method_206(Client.smethod_46(), false, false, false, false);
								b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_207(Client.smethod_46(), false, false, true, true, new Doctrine._FuelState?(Doctrine._FuelState.Various));
								}
							}
							else if (this.doctrine_0.method_208() && !activeUnit.doctrine_0.method_208())
							{
								this.doctrine_0.method_207(Client.smethod_46(), false, false, true, true, new Doctrine._FuelState?(Doctrine._FuelState.Various));
							}
							else if (!this.doctrine_0.method_208() && activeUnit.doctrine_0.method_208())
							{
								this.doctrine_0.method_207(Client.smethod_46(), false, false, true, true, new Doctrine._FuelState?(Doctrine._FuelState.Various));
							}
						}
						fuelState = this.nullable_20;
						b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 12) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_208())
							{
								fuelState = this.nullable_20;
								b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
								Doctrine doctrine51 = activeUnit.doctrine_0;
								Scenario scenario_51 = Client.smethod_46();
								bool flag = true;
								fuelState = doctrine51.method_3(scenario_51, ref flag).method_206(Client.smethod_46(), true, false, false, false);
								b2 = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_20 = new Doctrine._FuelState?(Doctrine._FuelState.Various);
								}
							}
							else
							{
								fuelState = this.nullable_20;
								b2 = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
								fuelState = activeUnit.doctrine_0.method_206(Client.smethod_46(), false, false, false, false);
								b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_20 = new Doctrine._FuelState?(Doctrine._FuelState.Various);
								}
							}
						}
						Doctrine.Enum51? enum4 = this.doctrine_0.method_88(Client.smethod_46(), false, false, false);
						b = ((enum4 != null) ? new byte?((byte)enum4.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_90() && !activeUnit.doctrine_0.method_90())
							{
								enum4 = this.doctrine_0.method_88(Client.smethod_46(), false, false, false);
								b = ((enum4 != null) ? new byte?((byte)enum4.GetValueOrDefault()) : null);
								enum4 = activeUnit.doctrine_0.method_88(Client.smethod_46(), false, false, false);
								b2 = ((enum4 != null) ? new byte?((byte)enum4.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_89(Client.smethod_46(), false, true, true, new Doctrine.Enum51?(Doctrine.Enum51.const_3));
								}
							}
							else if (this.doctrine_0.method_90() && !activeUnit.doctrine_0.method_90())
							{
								this.doctrine_0.method_89(Client.smethod_46(), false, true, true, new Doctrine.Enum51?(Doctrine.Enum51.const_3));
							}
							else if (!this.doctrine_0.method_90() && activeUnit.doctrine_0.method_90())
							{
								this.doctrine_0.method_89(Client.smethod_46(), false, true, true, new Doctrine.Enum51?(Doctrine.Enum51.const_3));
							}
						}
						enum4 = this.nullable_10;
						b2 = ((enum4 != null) ? new byte?((byte)enum4.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_90())
							{
								enum4 = this.nullable_10;
								b2 = ((enum4 != null) ? new byte?((byte)enum4.GetValueOrDefault()) : null);
								Doctrine doctrine52 = activeUnit.doctrine_0;
								Scenario scenario_52 = Client.smethod_46();
								bool flag = true;
								enum4 = doctrine52.method_3(scenario_52, ref flag).method_88(Client.smethod_46(), true, false, false);
								b = ((enum4 != null) ? new byte?((byte)enum4.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_10 = new Doctrine.Enum51?(Doctrine.Enum51.const_3);
								}
							}
							else
							{
								enum4 = this.nullable_10;
								b = ((enum4 != null) ? new byte?((byte)enum4.GetValueOrDefault()) : null);
								enum4 = activeUnit.doctrine_0.method_88(Client.smethod_46(), false, false, false);
								b2 = ((enum4 != null) ? new byte?((byte)enum4.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_10 = new Doctrine.Enum51?(Doctrine.Enum51.const_3);
								}
							}
						}
						Doctrine.Enum61? enum5 = this.doctrine_0.method_137(Client.smethod_46(), false, false, false);
						b2 = ((enum5 != null) ? new byte?((byte)enum5.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_139() && !activeUnit.doctrine_0.method_139())
							{
								enum5 = this.doctrine_0.method_137(Client.smethod_46(), false, false, false);
								b2 = ((enum5 != null) ? new byte?((byte)enum5.GetValueOrDefault()) : null);
								enum5 = activeUnit.doctrine_0.method_137(Client.smethod_46(), false, false, false);
								b = ((enum5 != null) ? new byte?((byte)enum5.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_138(Client.smethod_46(), false, true, true, new Doctrine.Enum61?(Doctrine.Enum61.const_2));
								}
							}
							else if (this.doctrine_0.method_139() && !activeUnit.doctrine_0.method_139())
							{
								this.doctrine_0.method_138(Client.smethod_46(), false, true, true, new Doctrine.Enum61?(Doctrine.Enum61.const_2));
							}
							else if (!this.doctrine_0.method_139() && activeUnit.doctrine_0.method_139())
							{
								this.doctrine_0.method_138(Client.smethod_46(), false, true, true, new Doctrine.Enum61?(Doctrine.Enum61.const_2));
							}
						}
						enum5 = this.nullable_11;
						b = ((enum5 != null) ? new byte?((byte)enum5.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_139())
							{
								enum5 = this.nullable_11;
								b = ((enum5 != null) ? new byte?((byte)enum5.GetValueOrDefault()) : null);
								Doctrine doctrine53 = activeUnit.doctrine_0;
								Scenario scenario_53 = Client.smethod_46();
								bool flag = true;
								enum5 = doctrine53.method_3(scenario_53, ref flag).method_137(Client.smethod_46(), true, false, false);
								b2 = ((enum5 != null) ? new byte?((byte)enum5.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_11 = new Doctrine.Enum61?(Doctrine.Enum61.const_2);
								}
							}
							else
							{
								enum5 = this.nullable_11;
								b2 = ((enum5 != null) ? new byte?((byte)enum5.GetValueOrDefault()) : null);
								enum5 = activeUnit.doctrine_0.method_137(Client.smethod_46(), false, false, false);
								b = ((enum5 != null) ? new byte?((byte)enum5.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_11 = new Doctrine.Enum61?(Doctrine.Enum61.const_2);
								}
							}
						}
						Doctrine.Enum62? enum6 = this.doctrine_0.method_142(Client.smethod_46(), false, false, false);
						b = ((enum6 != null) ? new byte?((byte)enum6.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_144() && !activeUnit.doctrine_0.method_144())
							{
								enum6 = this.doctrine_0.method_142(Client.smethod_46(), false, false, false);
								b = ((enum6 != null) ? new byte?((byte)enum6.GetValueOrDefault()) : null);
								enum6 = activeUnit.doctrine_0.method_142(Client.smethod_46(), false, false, false);
								b2 = ((enum6 != null) ? new byte?((byte)enum6.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_143(Client.smethod_46(), false, true, true, new Doctrine.Enum62?(Doctrine.Enum62.const_2));
								}
							}
							else if (this.doctrine_0.method_144() && !activeUnit.doctrine_0.method_144())
							{
								this.doctrine_0.method_143(Client.smethod_46(), false, true, true, new Doctrine.Enum62?(Doctrine.Enum62.const_2));
							}
							else if (!this.doctrine_0.method_144() && activeUnit.doctrine_0.method_144())
							{
								this.doctrine_0.method_143(Client.smethod_46(), false, true, true, new Doctrine.Enum62?(Doctrine.Enum62.const_2));
							}
						}
						enum6 = this.nullable_12;
						b2 = ((enum6 != null) ? new byte?((byte)enum6.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_144())
							{
								enum6 = this.nullable_12;
								b2 = ((enum6 != null) ? new byte?((byte)enum6.GetValueOrDefault()) : null);
								Doctrine doctrine54 = activeUnit.doctrine_0;
								Scenario scenario_54 = Client.smethod_46();
								bool flag = true;
								enum6 = doctrine54.method_3(scenario_54, ref flag).method_142(Client.smethod_46(), true, false, false);
								b = ((enum6 != null) ? new byte?((byte)enum6.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_12 = new Doctrine.Enum62?(Doctrine.Enum62.const_2);
								}
							}
							else
							{
								enum6 = this.nullable_12;
								b = ((enum6 != null) ? new byte?((byte)enum6.GetValueOrDefault()) : null);
								enum6 = activeUnit.doctrine_0.method_142(Client.smethod_46(), false, false, false);
								b2 = ((enum6 != null) ? new byte?((byte)enum6.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_12 = new Doctrine.Enum62?(Doctrine.Enum62.const_2);
								}
							}
						}
						Doctrine.Enum56? enum7 = this.doctrine_0.method_152(Client.smethod_46(), false, false, false, false);
						b2 = ((enum7 != null) ? new byte?((byte)enum7.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_154() && !activeUnit.doctrine_0.method_154())
							{
								enum7 = this.doctrine_0.method_152(Client.smethod_46(), false, false, false, false);
								b2 = ((enum7 != null) ? new byte?((byte)enum7.GetValueOrDefault()) : null);
								enum7 = activeUnit.doctrine_0.method_152(Client.smethod_46(), false, false, false, false);
								b = ((enum7 != null) ? new byte?((byte)enum7.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_153(Client.smethod_46(), false, true, true, false, new Doctrine.Enum56?(Doctrine.Enum56.const_3));
								}
							}
							else if (this.doctrine_0.method_154() && !activeUnit.doctrine_0.method_154())
							{
								this.doctrine_0.method_153(Client.smethod_46(), false, true, true, false, new Doctrine.Enum56?(Doctrine.Enum56.const_3));
							}
							else if (!this.doctrine_0.method_154() && activeUnit.doctrine_0.method_154())
							{
								this.doctrine_0.method_153(Client.smethod_46(), false, true, true, false, new Doctrine.Enum56?(Doctrine.Enum56.const_3));
							}
						}
						enum7 = this.nullable_13;
						b = ((enum7 != null) ? new byte?((byte)enum7.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_154())
							{
								enum7 = this.nullable_13;
								b = ((enum7 != null) ? new byte?((byte)enum7.GetValueOrDefault()) : null);
								Doctrine doctrine55 = activeUnit.doctrine_0;
								Scenario scenario_55 = Client.smethod_46();
								bool flag = true;
								enum7 = doctrine55.method_3(scenario_55, ref flag).method_152(Client.smethod_46(), true, false, false, false);
								b2 = ((enum7 != null) ? new byte?((byte)enum7.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_13 = new Doctrine.Enum56?(Doctrine.Enum56.const_3);
								}
							}
							else
							{
								enum7 = this.nullable_13;
								b2 = ((enum7 != null) ? new byte?((byte)enum7.GetValueOrDefault()) : null);
								enum7 = activeUnit.doctrine_0.method_152(Client.smethod_46(), false, false, false, false);
								b = ((enum7 != null) ? new byte?((byte)enum7.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_13 = new Doctrine.Enum56?(Doctrine.Enum56.const_3);
								}
							}
						}
						Doctrine.Enum57? enum8 = this.doctrine_0.method_157(Client.smethod_46(), false, false, false, false);
						b = ((enum8 != null) ? new byte?((byte)enum8.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_159() && !activeUnit.doctrine_0.method_159())
							{
								enum8 = this.doctrine_0.method_157(Client.smethod_46(), false, false, false, false);
								b = ((enum8 != null) ? new byte?((byte)enum8.GetValueOrDefault()) : null);
								enum8 = activeUnit.doctrine_0.method_157(Client.smethod_46(), false, false, false, false);
								b2 = ((enum8 != null) ? new byte?((byte)enum8.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_158(Client.smethod_46(), false, true, true, false, new Doctrine.Enum57?(Doctrine.Enum57.const_3));
								}
							}
							else if (this.doctrine_0.method_159() && !activeUnit.doctrine_0.method_159())
							{
								this.doctrine_0.method_158(Client.smethod_46(), false, true, true, false, new Doctrine.Enum57?(Doctrine.Enum57.const_3));
							}
							else if (!this.doctrine_0.method_159() && activeUnit.doctrine_0.method_159())
							{
								this.doctrine_0.method_158(Client.smethod_46(), false, true, true, false, new Doctrine.Enum57?(Doctrine.Enum57.const_3));
							}
						}
						enum8 = this.nullable_14;
						b2 = ((enum8 != null) ? new byte?((byte)enum8.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_159())
							{
								enum8 = this.nullable_14;
								b2 = ((enum8 != null) ? new byte?((byte)enum8.GetValueOrDefault()) : null);
								Doctrine doctrine56 = activeUnit.doctrine_0;
								Scenario scenario_56 = Client.smethod_46();
								bool flag = true;
								enum8 = doctrine56.method_3(scenario_56, ref flag).method_157(Client.smethod_46(), true, false, false, false);
								b = ((enum8 != null) ? new byte?((byte)enum8.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_14 = new Doctrine.Enum57?(Doctrine.Enum57.const_3);
								}
							}
							else
							{
								enum8 = this.nullable_14;
								b = ((enum8 != null) ? new byte?((byte)enum8.GetValueOrDefault()) : null);
								enum8 = activeUnit.doctrine_0.method_157(Client.smethod_46(), false, false, false, false);
								b2 = ((enum8 != null) ? new byte?((byte)enum8.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_14 = new Doctrine.Enum57?(Doctrine.Enum57.const_3);
								}
							}
						}
						Doctrine.Enum59? enum9 = this.doctrine_0.method_162(Client.smethod_46(), false, false, false);
						b2 = ((enum9 != null) ? new byte?((byte)enum9.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_164() && !activeUnit.doctrine_0.method_164())
							{
								enum9 = this.doctrine_0.method_162(Client.smethod_46(), false, false, false);
								b2 = ((enum9 != null) ? new byte?((byte)enum9.GetValueOrDefault()) : null);
								enum9 = activeUnit.doctrine_0.method_162(Client.smethod_46(), false, false, false);
								b = ((enum9 != null) ? new byte?((byte)enum9.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_163(Client.smethod_46(), false, true, true, new Doctrine.Enum59?(Doctrine.Enum59.const_2));
								}
							}
							else if (this.doctrine_0.method_164() && !activeUnit.doctrine_0.method_164())
							{
								this.doctrine_0.method_163(Client.smethod_46(), false, true, true, new Doctrine.Enum59?(Doctrine.Enum59.const_2));
							}
							else if (!this.doctrine_0.method_164() && activeUnit.doctrine_0.method_164())
							{
								this.doctrine_0.method_163(Client.smethod_46(), false, true, true, new Doctrine.Enum59?(Doctrine.Enum59.const_2));
							}
						}
						enum9 = this.nullable_15;
						b = ((enum9 != null) ? new byte?((byte)enum9.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_164())
							{
								enum9 = this.nullable_15;
								b = ((enum9 != null) ? new byte?((byte)enum9.GetValueOrDefault()) : null);
								Doctrine doctrine57 = activeUnit.doctrine_0;
								Scenario scenario_57 = Client.smethod_46();
								bool flag = true;
								enum9 = doctrine57.method_3(scenario_57, ref flag).method_162(Client.smethod_46(), true, false, false);
								b2 = ((enum9 != null) ? new byte?((byte)enum9.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_15 = new Doctrine.Enum59?(Doctrine.Enum59.const_2);
								}
							}
							else
							{
								enum9 = this.nullable_15;
								b2 = ((enum9 != null) ? new byte?((byte)enum9.GetValueOrDefault()) : null);
								enum9 = activeUnit.doctrine_0.method_162(Client.smethod_46(), false, false, false);
								b = ((enum9 != null) ? new byte?((byte)enum9.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_15 = new Doctrine.Enum59?(Doctrine.Enum59.const_2);
								}
							}
						}
						Doctrine.Enum58? enum10 = this.doctrine_0.method_167(Client.smethod_46(), false, false, false);
						b = ((enum10 != null) ? new byte?((byte)enum10.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_169() && !activeUnit.doctrine_0.method_169())
							{
								enum10 = this.doctrine_0.method_167(Client.smethod_46(), false, false, false);
								b = ((enum10 != null) ? new byte?((byte)enum10.GetValueOrDefault()) : null);
								enum10 = activeUnit.doctrine_0.method_167(Client.smethod_46(), false, false, false);
								b2 = ((enum10 != null) ? new byte?((byte)enum10.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_168(Client.smethod_46(), false, true, true, new Doctrine.Enum58?(Doctrine.Enum58.const_2));
								}
							}
							else if (this.doctrine_0.method_169() && !activeUnit.doctrine_0.method_169())
							{
								this.doctrine_0.method_168(Client.smethod_46(), false, true, true, new Doctrine.Enum58?(Doctrine.Enum58.const_2));
							}
							else if (!this.doctrine_0.method_169() && activeUnit.doctrine_0.method_169())
							{
								this.doctrine_0.method_168(Client.smethod_46(), false, true, true, new Doctrine.Enum58?(Doctrine.Enum58.const_2));
							}
						}
						enum10 = this.nullable_16;
						b2 = ((enum10 != null) ? new byte?((byte)enum10.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_169())
							{
								enum10 = this.nullable_16;
								b2 = ((enum10 != null) ? new byte?((byte)enum10.GetValueOrDefault()) : null);
								Doctrine doctrine58 = activeUnit.doctrine_0;
								Scenario scenario_58 = Client.smethod_46();
								bool flag = true;
								enum10 = doctrine58.method_3(scenario_58, ref flag).method_167(Client.smethod_46(), true, false, false);
								b = ((enum10 != null) ? new byte?((byte)enum10.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_16 = new Doctrine.Enum58?(Doctrine.Enum58.const_2);
								}
							}
							else
							{
								enum10 = this.nullable_16;
								b = ((enum10 != null) ? new byte?((byte)enum10.GetValueOrDefault()) : null);
								enum10 = activeUnit.doctrine_0.method_167(Client.smethod_46(), false, false, false);
								b2 = ((enum10 != null) ? new byte?((byte)enum10.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_16 = new Doctrine.Enum58?(Doctrine.Enum58.const_2);
								}
							}
						}
						Doctrine.Enum60? enum11 = this.doctrine_0.method_172(Client.smethod_46(), false, false, false);
						b2 = ((enum11 != null) ? new byte?((byte)enum11.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_174() && !activeUnit.doctrine_0.method_174())
							{
								enum11 = this.doctrine_0.method_172(Client.smethod_46(), false, false, false);
								b2 = ((enum11 != null) ? new byte?((byte)enum11.GetValueOrDefault()) : null);
								enum11 = activeUnit.doctrine_0.method_172(Client.smethod_46(), false, false, false);
								b = ((enum11 != null) ? new byte?((byte)enum11.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_173(Client.smethod_46(), false, true, true, new Doctrine.Enum60?(Doctrine.Enum60.const_2));
								}
							}
							else if (this.doctrine_0.method_174() && !activeUnit.doctrine_0.method_174())
							{
								this.doctrine_0.method_173(Client.smethod_46(), false, true, true, new Doctrine.Enum60?(Doctrine.Enum60.const_2));
							}
							else if (!this.doctrine_0.method_174() && activeUnit.doctrine_0.method_174())
							{
								this.doctrine_0.method_173(Client.smethod_46(), false, true, true, new Doctrine.Enum60?(Doctrine.Enum60.const_2));
							}
						}
						enum11 = this.nullable_17;
						b = ((enum11 != null) ? new byte?((byte)enum11.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_174())
							{
								enum11 = this.nullable_17;
								b = ((enum11 != null) ? new byte?((byte)enum11.GetValueOrDefault()) : null);
								Doctrine doctrine59 = activeUnit.doctrine_0;
								Scenario scenario_59 = Client.smethod_46();
								bool flag = true;
								enum11 = doctrine59.method_3(scenario_59, ref flag).method_172(Client.smethod_46(), true, false, false);
								b2 = ((enum11 != null) ? new byte?((byte)enum11.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_17 = new Doctrine.Enum60?(Doctrine.Enum60.const_2);
								}
							}
							else
							{
								enum11 = this.nullable_17;
								b2 = ((enum11 != null) ? new byte?((byte)enum11.GetValueOrDefault()) : null);
								enum11 = activeUnit.doctrine_0.method_172(Client.smethod_46(), false, false, false);
								b = ((enum11 != null) ? new byte?((byte)enum11.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_17 = new Doctrine.Enum60?(Doctrine.Enum60.const_2);
								}
							}
						}
						Doctrine.Enum53? enum12 = this.doctrine_0.method_196(Client.smethod_46(), false, this.bool_3, false, false);
						b = ((enum12 != null) ? new byte?((byte)enum12.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_198() && !activeUnit.doctrine_0.method_198())
							{
								enum12 = this.doctrine_0.method_196(Client.smethod_46(), false, this.bool_3, false, false);
								b = ((enum12 != null) ? new byte?((byte)enum12.GetValueOrDefault()) : null);
								enum12 = activeUnit.doctrine_0.method_196(Client.smethod_46(), false, this.bool_3, false, false);
								b2 = ((enum12 != null) ? new byte?((byte)enum12.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_197(Client.smethod_46(), false, this.bool_3, true, true, new Doctrine.Enum53?(Doctrine.Enum53.const_3));
								}
							}
							else if (this.doctrine_0.method_198() && !activeUnit.doctrine_0.method_198())
							{
								this.doctrine_0.method_197(Client.smethod_46(), false, this.bool_3, true, true, new Doctrine.Enum53?(Doctrine.Enum53.const_3));
							}
							else if (!this.doctrine_0.method_198() && activeUnit.doctrine_0.method_198())
							{
								this.doctrine_0.method_197(Client.smethod_46(), false, this.bool_3, true, true, new Doctrine.Enum53?(Doctrine.Enum53.const_3));
							}
						}
						enum12 = this.nullable_18;
						b2 = ((enum12 != null) ? new byte?((byte)enum12.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_198())
							{
								enum12 = this.nullable_18;
								b2 = ((enum12 != null) ? new byte?((byte)enum12.GetValueOrDefault()) : null);
								Doctrine doctrine60 = activeUnit.doctrine_0;
								Scenario scenario_60 = Client.smethod_46();
								bool flag = true;
								enum12 = doctrine60.method_3(scenario_60, ref flag).method_196(Client.smethod_46(), false, this.bool_3, false, false);
								b = ((enum12 != null) ? new byte?((byte)enum12.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_18 = new Doctrine.Enum53?(Doctrine.Enum53.const_3);
								}
							}
							else
							{
								enum12 = this.nullable_18;
								b = ((enum12 != null) ? new byte?((byte)enum12.GetValueOrDefault()) : null);
								enum12 = activeUnit.doctrine_0.method_196(Client.smethod_46(), false, this.bool_3, false, false);
								b2 = ((enum12 != null) ? new byte?((byte)enum12.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_18 = new Doctrine.Enum53?(Doctrine.Enum53.const_3);
								}
							}
						}
						Doctrine.Enum54? enum13 = this.doctrine_0.method_201(Client.smethod_46(), false, this.bool_3, false, false);
						b2 = ((enum13 != null) ? new byte?((byte)enum13.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_203() && !activeUnit.doctrine_0.method_203())
							{
								enum13 = this.doctrine_0.method_201(Client.smethod_46(), false, this.bool_3, false, false);
								b2 = ((enum13 != null) ? new byte?((byte)enum13.GetValueOrDefault()) : null);
								enum13 = activeUnit.doctrine_0.method_201(Client.smethod_46(), false, this.bool_3, false, false);
								b = ((enum13 != null) ? new byte?((byte)enum13.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_202(Client.smethod_46(), false, this.bool_3, true, true, new Doctrine.Enum54?(Doctrine.Enum54.const_2));
								}
							}
							else if (this.doctrine_0.method_203() && !activeUnit.doctrine_0.method_203())
							{
								this.doctrine_0.method_202(Client.smethod_46(), false, this.bool_3, true, true, new Doctrine.Enum54?(Doctrine.Enum54.const_2));
							}
							else if (!this.doctrine_0.method_203() && activeUnit.doctrine_0.method_203())
							{
								this.doctrine_0.method_202(Client.smethod_46(), false, this.bool_3, true, true, new Doctrine.Enum54?(Doctrine.Enum54.const_2));
							}
						}
						enum13 = this.nullable_19;
						b = ((enum13 != null) ? new byte?((byte)enum13.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_203())
							{
								enum13 = this.nullable_19;
								b = ((enum13 != null) ? new byte?((byte)enum13.GetValueOrDefault()) : null);
								Doctrine doctrine61 = activeUnit.doctrine_0;
								Scenario scenario_61 = Client.smethod_46();
								bool flag = true;
								enum13 = doctrine61.method_3(scenario_61, ref flag).method_201(Client.smethod_46(), false, this.bool_3, false, false);
								b2 = ((enum13 != null) ? new byte?((byte)enum13.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_19 = new Doctrine.Enum54?(Doctrine.Enum54.const_2);
								}
							}
							else
							{
								enum13 = this.nullable_19;
								b2 = ((enum13 != null) ? new byte?((byte)enum13.GetValueOrDefault()) : null);
								enum13 = activeUnit.doctrine_0.method_201(Client.smethod_46(), false, this.bool_3, false, false);
								b = ((enum13 != null) ? new byte?((byte)enum13.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_19 = new Doctrine.Enum54?(Doctrine.Enum54.const_2);
								}
							}
						}
						Doctrine.Enum55? enum14 = this.doctrine_0.method_216(Client.smethod_46(), false, false, false);
						b = ((enum14 != null) ? new byte?((byte)enum14.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_218() && !activeUnit.doctrine_0.method_218())
							{
								enum14 = this.doctrine_0.method_216(Client.smethod_46(), false, false, false);
								b = ((enum14 != null) ? new byte?((byte)enum14.GetValueOrDefault()) : null);
								enum14 = activeUnit.doctrine_0.method_216(Client.smethod_46(), false, false, false);
								b2 = ((enum14 != null) ? new byte?((byte)enum14.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_217(Client.smethod_46(), false, true, true, new Doctrine.Enum55?(Doctrine.Enum55.const_3));
								}
							}
							else if (this.doctrine_0.method_218() && !activeUnit.doctrine_0.method_218())
							{
								this.doctrine_0.method_217(Client.smethod_46(), false, true, true, new Doctrine.Enum55?(Doctrine.Enum55.const_3));
							}
							else if (!this.doctrine_0.method_218() && activeUnit.doctrine_0.method_218())
							{
								this.doctrine_0.method_217(Client.smethod_46(), false, true, true, new Doctrine.Enum55?(Doctrine.Enum55.const_3));
							}
						}
						enum14 = this.nullable_22;
						b2 = ((enum14 != null) ? new byte?((byte)enum14.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_218())
							{
								enum14 = this.nullable_22;
								b2 = ((enum14 != null) ? new byte?((byte)enum14.GetValueOrDefault()) : null);
								Doctrine doctrine62 = activeUnit.doctrine_0;
								Scenario scenario_62 = Client.smethod_46();
								bool flag = true;
								enum14 = doctrine62.method_3(scenario_62, ref flag).method_216(Client.smethod_46(), true, false, false);
								b = ((enum14 != null) ? new byte?((byte)enum14.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_22 = new Doctrine.Enum55?(Doctrine.Enum55.const_3);
								}
							}
							else
							{
								enum14 = this.nullable_22;
								b = ((enum14 != null) ? new byte?((byte)enum14.GetValueOrDefault()) : null);
								enum14 = activeUnit.doctrine_0.method_216(Client.smethod_46(), false, false, false);
								b2 = ((enum14 != null) ? new byte?((byte)enum14.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_22 = new Doctrine.Enum55?(Doctrine.Enum55.const_3);
								}
							}
						}
						Doctrine._DamageThreshold? damageThreshold = this.doctrine_0.method_93(Client.smethod_46(), false, false, false);
						short? num4 = (damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null;
						flag2 = ((num4 != null) ? new bool?(num4.GetValueOrDefault() == 5) : null);
						short? num5;
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_95() && !activeUnit.doctrine_0.method_95())
							{
								damageThreshold = this.doctrine_0.method_93(Client.smethod_46(), false, false, false);
								num4 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								damageThreshold = activeUnit.doctrine_0.method_93(Client.smethod_46(), false, false, false);
								num5 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								if (((num4 != null & num5 != null) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_94(Client.smethod_46(), false, true, true, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various));
								}
							}
							else if (this.doctrine_0.method_95() && !activeUnit.doctrine_0.method_95())
							{
								this.doctrine_0.method_94(Client.smethod_46(), false, true, true, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various));
							}
							else if (!this.doctrine_0.method_95() && activeUnit.doctrine_0.method_95())
							{
								this.doctrine_0.method_94(Client.smethod_46(), false, true, true, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various));
							}
						}
						damageThreshold = this.nullable_34;
						num5 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
						flag2 = ((num5 != null) ? new bool?(num5.GetValueOrDefault() == 5) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_95())
							{
								damageThreshold = this.nullable_34;
								num5 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								Doctrine doctrine63 = activeUnit.doctrine_0;
								Scenario scenario_63 = Client.smethod_46();
								bool flag = true;
								damageThreshold = doctrine63.method_3(scenario_63, ref flag).method_93(Client.smethod_46(), true, false, false);
								num4 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								if (((num5 != null & num4 != null) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_34 = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various);
								}
							}
							else
							{
								damageThreshold = this.nullable_34;
								num4 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								damageThreshold = activeUnit.doctrine_0.method_93(Client.smethod_46(), false, false, false);
								num5 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								if (((num4 != null & num5 != null) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_34 = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various);
								}
							}
						}
						Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = this.doctrine_0.method_96(Client.smethod_46(), false, false, false);
						num5 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
						flag2 = ((num5 != null) ? new bool?(num5.GetValueOrDefault() == 6) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_98() && !activeUnit.doctrine_0.method_98())
							{
								fuelQuantityThreshold = this.doctrine_0.method_96(Client.smethod_46(), false, false, false);
								num5 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								fuelQuantityThreshold = activeUnit.doctrine_0.method_96(Client.smethod_46(), false, false, false);
								num4 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								if (((num5 != null & num4 != null) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_97(Client.smethod_46(), false, true, true, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various));
								}
							}
							else if (this.doctrine_0.method_98() && !activeUnit.doctrine_0.method_98())
							{
								this.doctrine_0.method_97(Client.smethod_46(), false, true, true, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various));
							}
							else if (!this.doctrine_0.method_98() && activeUnit.doctrine_0.method_98())
							{
								this.doctrine_0.method_97(Client.smethod_46(), false, true, true, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various));
							}
						}
						fuelQuantityThreshold = this.nullable_35;
						num4 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
						flag2 = ((num4 != null) ? new bool?(num4.GetValueOrDefault() == 5) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_98())
							{
								fuelQuantityThreshold = this.nullable_35;
								num4 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								Doctrine doctrine64 = activeUnit.doctrine_0;
								Scenario scenario_64 = Client.smethod_46();
								bool flag = true;
								fuelQuantityThreshold = doctrine64.method_3(scenario_64, ref flag).method_96(Client.smethod_46(), true, false, false);
								num5 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								if (((num4 != null & num5 != null) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_35 = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various);
								}
							}
							else
							{
								fuelQuantityThreshold = this.nullable_35;
								num5 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								fuelQuantityThreshold = activeUnit.doctrine_0.method_96(Client.smethod_46(), false, false, false);
								num4 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								if (((num5 != null & num4 != null) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_35 = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various);
								}
							}
						}
						Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.doctrine_0.method_99(Client.smethod_46(), false, false, false);
						num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						flag2 = ((num4 != null) ? new bool?(num4.GetValueOrDefault() == 7) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_101() && !activeUnit.doctrine_0.method_101())
							{
								weaponQuantityThreshold = this.doctrine_0.method_99(Client.smethod_46(), false, false, false);
								num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								weaponQuantityThreshold = activeUnit.doctrine_0.method_99(Client.smethod_46(), false, false, false);
								num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num4 != null & num5 != null) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_100(Client.smethod_46(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
								}
							}
							else if (this.doctrine_0.method_101() && !activeUnit.doctrine_0.method_101())
							{
								this.doctrine_0.method_100(Client.smethod_46(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
							}
							else if (!this.doctrine_0.method_101() && activeUnit.doctrine_0.method_101())
							{
								this.doctrine_0.method_100(Client.smethod_46(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
							}
						}
						weaponQuantityThreshold = this.nullable_36;
						num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						flag2 = ((num5 != null) ? new bool?(num5.GetValueOrDefault() == 5) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_101())
							{
								weaponQuantityThreshold = this.nullable_36;
								num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								Doctrine doctrine65 = activeUnit.doctrine_0;
								Scenario scenario_65 = Client.smethod_46();
								bool flag = true;
								weaponQuantityThreshold = doctrine65.method_3(scenario_65, ref flag).method_99(Client.smethod_46(), true, false, false);
								num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num5 != null & num4 != null) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_36 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
								}
							}
							else
							{
								weaponQuantityThreshold = this.nullable_36;
								num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								weaponQuantityThreshold = activeUnit.doctrine_0.method_99(Client.smethod_46(), false, false, false);
								num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num4 != null & num5 != null) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_36 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
								}
							}
						}
						weaponQuantityThreshold = this.doctrine_0.method_102(Client.smethod_46(), false, false, false);
						num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						flag2 = ((num5 != null) ? new bool?(num5.GetValueOrDefault() == 7) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_104() && !activeUnit.doctrine_0.method_104())
							{
								weaponQuantityThreshold = this.doctrine_0.method_102(Client.smethod_46(), false, false, false);
								num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								weaponQuantityThreshold = activeUnit.doctrine_0.method_102(Client.smethod_46(), false, false, false);
								num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num5 != null & num4 != null) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_103(Client.smethod_46(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
								}
							}
							else if (this.doctrine_0.method_104() && !activeUnit.doctrine_0.method_104())
							{
								this.doctrine_0.method_103(Client.smethod_46(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
							}
							else if (!this.doctrine_0.method_104() && activeUnit.doctrine_0.method_104())
							{
								this.doctrine_0.method_103(Client.smethod_46(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
							}
						}
						weaponQuantityThreshold = this.nullable_37;
						num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						flag2 = ((num4 != null) ? new bool?(num4.GetValueOrDefault() == 5) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_104())
							{
								weaponQuantityThreshold = this.nullable_37;
								num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								Doctrine doctrine66 = activeUnit.doctrine_0;
								Scenario scenario_66 = Client.smethod_46();
								bool flag = true;
								weaponQuantityThreshold = doctrine66.method_3(scenario_66, ref flag).method_102(Client.smethod_46(), true, false, false);
								num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num4 != null & num5 != null) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_37 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
								}
							}
							else
							{
								weaponQuantityThreshold = this.nullable_37;
								num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								weaponQuantityThreshold = activeUnit.doctrine_0.method_102(Client.smethod_46(), false, false, false);
								num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num5 != null & num4 != null) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_37 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
								}
							}
						}
						damageThreshold = this.doctrine_0.method_105(Client.smethod_46(), false, false, false);
						num4 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
						flag2 = ((num4 != null) ? new bool?(num4.GetValueOrDefault() == 5) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_107() && !activeUnit.doctrine_0.method_107())
							{
								damageThreshold = this.doctrine_0.method_105(Client.smethod_46(), false, false, false);
								num4 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								damageThreshold = activeUnit.doctrine_0.method_105(Client.smethod_46(), false, false, false);
								num5 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								if (((num4 != null & num5 != null) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_106(Client.smethod_46(), false, true, true, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various));
								}
							}
							else if (this.doctrine_0.method_107() && !activeUnit.doctrine_0.method_107())
							{
								this.doctrine_0.method_106(Client.smethod_46(), false, true, true, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various));
							}
							else if (!this.doctrine_0.method_107() && activeUnit.doctrine_0.method_107())
							{
								this.doctrine_0.method_106(Client.smethod_46(), false, true, true, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various));
							}
						}
						damageThreshold = this.nullable_38;
						num5 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
						flag2 = ((num5 != null) ? new bool?(num5.GetValueOrDefault() == 5) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_107())
							{
								damageThreshold = this.nullable_38;
								num5 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								Doctrine doctrine67 = activeUnit.doctrine_0;
								Scenario scenario_67 = Client.smethod_46();
								bool flag = true;
								damageThreshold = doctrine67.method_3(scenario_67, ref flag).method_105(Client.smethod_46(), true, false, false);
								num4 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								if (((num5 != null & num4 != null) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_38 = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various);
								}
							}
							else
							{
								damageThreshold = this.nullable_38;
								num4 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								damageThreshold = activeUnit.doctrine_0.method_105(Client.smethod_46(), false, false, false);
								num5 = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								if (((num4 != null & num5 != null) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_38 = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Various);
								}
							}
						}
						fuelQuantityThreshold = this.doctrine_0.method_108(Client.smethod_46(), false, false, false);
						num5 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
						flag2 = ((num5 != null) ? new bool?(num5.GetValueOrDefault() == 6) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_110() && !activeUnit.doctrine_0.method_110())
							{
								fuelQuantityThreshold = this.doctrine_0.method_108(Client.smethod_46(), false, false, false);
								num5 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								fuelQuantityThreshold = activeUnit.doctrine_0.method_108(Client.smethod_46(), false, false, false);
								num4 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								if (((num5 != null & num4 != null) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_109(Client.smethod_46(), false, true, true, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various));
								}
							}
							else if (this.doctrine_0.method_110() && !activeUnit.doctrine_0.method_110())
							{
								this.doctrine_0.method_109(Client.smethod_46(), false, true, true, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various));
							}
							else if (!this.doctrine_0.method_110() && activeUnit.doctrine_0.method_110())
							{
								this.doctrine_0.method_109(Client.smethod_46(), false, true, true, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various));
							}
						}
						fuelQuantityThreshold = this.nullable_39;
						num4 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
						flag2 = ((num4 != null) ? new bool?(num4.GetValueOrDefault() == 5) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_110())
							{
								fuelQuantityThreshold = this.nullable_39;
								num4 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								Doctrine doctrine68 = activeUnit.doctrine_0;
								Scenario scenario_68 = Client.smethod_46();
								bool flag = true;
								fuelQuantityThreshold = doctrine68.method_3(scenario_68, ref flag).method_108(Client.smethod_46(), true, false, false);
								num5 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								if (((num4 != null & num5 != null) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_39 = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various);
								}
							}
							else
							{
								fuelQuantityThreshold = this.nullable_39;
								num5 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								fuelQuantityThreshold = activeUnit.doctrine_0.method_108(Client.smethod_46(), false, false, false);
								num4 = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								if (((num5 != null & num4 != null) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_39 = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Various);
								}
							}
						}
						weaponQuantityThreshold = this.doctrine_0.method_111(Client.smethod_46(), false, false, false);
						num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						flag2 = ((num4 != null) ? new bool?(num4.GetValueOrDefault() == 7) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_113() && !activeUnit.doctrine_0.method_113())
							{
								weaponQuantityThreshold = this.doctrine_0.method_111(Client.smethod_46(), false, false, false);
								num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								weaponQuantityThreshold = activeUnit.doctrine_0.method_111(Client.smethod_46(), false, false, false);
								num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num4 != null & num5 != null) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_112(Client.smethod_46(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
								}
							}
							else if (this.doctrine_0.method_113() && !activeUnit.doctrine_0.method_113())
							{
								this.doctrine_0.method_112(Client.smethod_46(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
							}
							else if (!this.doctrine_0.method_113() && activeUnit.doctrine_0.method_113())
							{
								this.doctrine_0.method_112(Client.smethod_46(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
							}
						}
						weaponQuantityThreshold = this.nullable_40;
						num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						flag2 = ((num5 != null) ? new bool?(num5.GetValueOrDefault() == 5) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_113())
							{
								weaponQuantityThreshold = this.nullable_40;
								num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								Doctrine doctrine69 = activeUnit.doctrine_0;
								Scenario scenario_69 = Client.smethod_46();
								bool flag = true;
								weaponQuantityThreshold = doctrine69.method_3(scenario_69, ref flag).method_111(Client.smethod_46(), true, false, false);
								num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num5 != null & num4 != null) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_40 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
								}
							}
							else
							{
								weaponQuantityThreshold = this.nullable_40;
								num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								weaponQuantityThreshold = activeUnit.doctrine_0.method_111(Client.smethod_46(), false, false, false);
								num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num4 != null & num5 != null) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_40 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
								}
							}
						}
						weaponQuantityThreshold = this.doctrine_0.method_114(Client.smethod_46(), false, false, false);
						num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						flag2 = ((num5 != null) ? new bool?(num5.GetValueOrDefault() == 7) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_116() && !activeUnit.doctrine_0.method_116())
							{
								weaponQuantityThreshold = this.doctrine_0.method_114(Client.smethod_46(), false, false, false);
								num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								weaponQuantityThreshold = activeUnit.doctrine_0.method_114(Client.smethod_46(), false, false, false);
								num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num5 != null & num4 != null) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_115(Client.smethod_46(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
								}
							}
							else if (this.doctrine_0.method_116() && !activeUnit.doctrine_0.method_116())
							{
								this.doctrine_0.method_115(Client.smethod_46(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
							}
							else if (!this.doctrine_0.method_116() && activeUnit.doctrine_0.method_116())
							{
								this.doctrine_0.method_115(Client.smethod_46(), false, true, true, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various));
							}
						}
						weaponQuantityThreshold = this.nullable_41;
						num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						flag2 = ((num4 != null) ? new bool?(num4.GetValueOrDefault() == 5) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_116())
							{
								weaponQuantityThreshold = this.nullable_41;
								num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								Doctrine doctrine70 = activeUnit.doctrine_0;
								Scenario scenario_70 = Client.smethod_46();
								bool flag = true;
								weaponQuantityThreshold = doctrine70.method_3(scenario_70, ref flag).method_114(Client.smethod_46(), true, false, false);
								num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num4 != null & num5 != null) ? new bool?(num4.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_41 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
								}
							}
							else
							{
								weaponQuantityThreshold = this.nullable_41;
								num5 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								weaponQuantityThreshold = activeUnit.doctrine_0.method_114(Client.smethod_46(), false, false, false);
								num4 = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num5 != null & num4 != null) ? new bool?(num5.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_41 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Various);
								}
							}
						}
						Doctrine._RefuelAlliedUnits? refuelAlliedUnits = this.doctrine_0.method_240(Client.smethod_46(), false, false, false);
						b2 = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 4) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_242() && !activeUnit.doctrine_0.method_242())
							{
								refuelAlliedUnits = this.doctrine_0.method_240(Client.smethod_46(), false, false, false);
								b2 = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
								refuelAlliedUnits = activeUnit.doctrine_0.method_240(Client.smethod_46(), false, false, false);
								b = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_241(Client.smethod_46(), false, true, true, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Various));
								}
							}
							else if (this.doctrine_0.method_242() && !activeUnit.doctrine_0.method_242())
							{
								this.doctrine_0.method_241(Client.smethod_46(), false, true, true, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Various));
							}
							else if (!this.doctrine_0.method_242() && activeUnit.doctrine_0.method_242())
							{
								this.doctrine_0.method_241(Client.smethod_46(), false, true, true, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Various));
							}
						}
						refuelAlliedUnits = this.nullable_24;
						b = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_242())
							{
								refuelAlliedUnits = this.nullable_24;
								b = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
								Doctrine doctrine71 = activeUnit.doctrine_0;
								Scenario scenario_71 = Client.smethod_46();
								bool flag = true;
								refuelAlliedUnits = doctrine71.method_3(scenario_71, ref flag).method_240(Client.smethod_46(), true, false, false);
								b2 = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_24 = new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Various);
								}
							}
							else
							{
								refuelAlliedUnits = this.nullable_24;
								b2 = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
								refuelAlliedUnits = activeUnit.doctrine_0.method_240(Client.smethod_46(), false, false, false);
								b = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_24 = new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Various);
								}
							}
						}
						Doctrine._AvoidContactWhenPossible? avoidContactWhenPossible = this.doctrine_0.method_246(Client.smethod_46(), false, false, false);
						b = ((avoidContactWhenPossible != null) ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_248() && !activeUnit.doctrine_0.method_248())
							{
								avoidContactWhenPossible = this.doctrine_0.method_246(Client.smethod_46(), false, false, false);
								b = ((avoidContactWhenPossible != null) ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
								avoidContactWhenPossible = activeUnit.doctrine_0.method_246(Client.smethod_46(), false, false, false);
								b2 = ((avoidContactWhenPossible != null) ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_247(Client.smethod_46(), false, true, true, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Various));
								}
							}
							else if (this.doctrine_0.method_248() && !activeUnit.doctrine_0.method_248())
							{
								this.doctrine_0.method_247(Client.smethod_46(), false, true, true, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Various));
							}
							else if (!this.doctrine_0.method_248() && activeUnit.doctrine_0.method_248())
							{
								this.doctrine_0.method_247(Client.smethod_46(), false, true, true, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Various));
							}
						}
						avoidContactWhenPossible = this.nullable_25;
						b2 = ((avoidContactWhenPossible != null) ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_248())
							{
								avoidContactWhenPossible = this.nullable_25;
								b2 = ((avoidContactWhenPossible != null) ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
								Doctrine doctrine72 = activeUnit.doctrine_0;
								Scenario scenario_72 = Client.smethod_46();
								bool flag = true;
								avoidContactWhenPossible = doctrine72.method_3(scenario_72, ref flag).method_246(Client.smethod_46(), true, false, false);
								b = ((avoidContactWhenPossible != null) ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_25 = new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Various);
								}
							}
							else
							{
								avoidContactWhenPossible = this.nullable_25;
								b = ((avoidContactWhenPossible != null) ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
								avoidContactWhenPossible = activeUnit.doctrine_0.method_246(Client.smethod_46(), false, false, false);
								b2 = ((avoidContactWhenPossible != null) ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_25 = new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Various);
								}
							}
						}
						Doctrine._DiveOnContact? diveOnContact = this.doctrine_0.method_252(Client.smethod_46(), false, false, false);
						b2 = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 4) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_254() && !activeUnit.doctrine_0.method_254())
							{
								diveOnContact = this.doctrine_0.method_252(Client.smethod_46(), false, false, false);
								b2 = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
								diveOnContact = activeUnit.doctrine_0.method_252(Client.smethod_46(), false, false, false);
								b = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_253(Client.smethod_46(), false, true, true, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Various));
								}
							}
							else if (this.doctrine_0.method_254() && !activeUnit.doctrine_0.method_254())
							{
								this.doctrine_0.method_253(Client.smethod_46(), false, true, true, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Various));
							}
							else if (!this.doctrine_0.method_254() && activeUnit.doctrine_0.method_254())
							{
								this.doctrine_0.method_253(Client.smethod_46(), false, true, true, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Various));
							}
						}
						diveOnContact = this.nullable_26;
						b = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_254())
							{
								diveOnContact = this.nullable_26;
								b = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
								Doctrine doctrine73 = activeUnit.doctrine_0;
								Scenario scenario_73 = Client.smethod_46();
								bool flag = true;
								diveOnContact = doctrine73.method_3(scenario_73, ref flag).method_252(Client.smethod_46(), true, false, false);
								b2 = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_26 = new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Various);
								}
							}
							else
							{
								diveOnContact = this.nullable_26;
								b2 = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
								diveOnContact = activeUnit.doctrine_0.method_252(Client.smethod_46(), false, false, false);
								b = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_26 = new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Various);
								}
							}
						}
						Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage = this.doctrine_0.method_258(Client.smethod_46(), false, false, false);
						num3 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
						flag2 = ((num3 != null) ? new bool?(num3.GetValueOrDefault() == -100) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_260() && !activeUnit.doctrine_0.method_260())
							{
								rechargeBatteryPercentage = this.doctrine_0.method_258(Client.smethod_46(), false, false, false);
								num3 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								rechargeBatteryPercentage = activeUnit.doctrine_0.method_258(Client.smethod_46(), false, false, false);
								num2 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								if (((num3 != null & num2 != null) ? new bool?(num3.GetValueOrDefault() != num2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_259(Client.smethod_46(), false, true, true, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various));
								}
							}
							else if (this.doctrine_0.method_260() && !activeUnit.doctrine_0.method_260())
							{
								this.doctrine_0.method_259(Client.smethod_46(), false, true, true, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various));
							}
							else if (!this.doctrine_0.method_260() && activeUnit.doctrine_0.method_260())
							{
								this.doctrine_0.method_259(Client.smethod_46(), false, true, true, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various));
							}
						}
						rechargeBatteryPercentage = this.nullable_27;
						num2 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
						flag2 = ((num2 != null) ? new bool?(num2.GetValueOrDefault() == -100) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_260())
							{
								rechargeBatteryPercentage = this.nullable_27;
								num2 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								Doctrine doctrine74 = activeUnit.doctrine_0;
								Scenario scenario_74 = Client.smethod_46();
								bool flag = true;
								rechargeBatteryPercentage = doctrine74.method_3(scenario_74, ref flag).method_258(Client.smethod_46(), true, false, false);
								num3 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								if (((num2 != null & num3 != null) ? new bool?(num2.GetValueOrDefault() != num3.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_27 = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various);
								}
							}
							else
							{
								rechargeBatteryPercentage = this.nullable_27;
								num3 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								rechargeBatteryPercentage = activeUnit.doctrine_0.method_258(Client.smethod_46(), false, false, false);
								num2 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								if (((num3 != null & num2 != null) ? new bool?(num3.GetValueOrDefault() != num2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_27 = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various);
								}
							}
						}
						rechargeBatteryPercentage = this.doctrine_0.method_264(Client.smethod_46(), false, false, false);
						num2 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
						flag2 = ((num2 != null) ? new bool?(num2.GetValueOrDefault() == -100) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_266() && !activeUnit.doctrine_0.method_266())
							{
								rechargeBatteryPercentage = this.doctrine_0.method_264(Client.smethod_46(), false, false, false);
								num2 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								rechargeBatteryPercentage = activeUnit.doctrine_0.method_264(Client.smethod_46(), false, false, false);
								num3 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								if (((num2 != null & num3 != null) ? new bool?(num2.GetValueOrDefault() != num3.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_265(Client.smethod_46(), false, true, true, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various));
								}
							}
							else if (this.doctrine_0.method_266() && !activeUnit.doctrine_0.method_266())
							{
								this.doctrine_0.method_265(Client.smethod_46(), false, true, true, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various));
							}
							else if (!this.doctrine_0.method_266() && activeUnit.doctrine_0.method_266())
							{
								this.doctrine_0.method_265(Client.smethod_46(), false, true, true, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various));
							}
						}
						rechargeBatteryPercentage = this.nullable_28;
						num3 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
						flag2 = ((num3 != null) ? new bool?(num3.GetValueOrDefault() == -100) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_266())
							{
								rechargeBatteryPercentage = this.nullable_28;
								num3 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								Doctrine doctrine75 = activeUnit.doctrine_0;
								Scenario scenario_75 = Client.smethod_46();
								bool flag = true;
								rechargeBatteryPercentage = doctrine75.method_3(scenario_75, ref flag).method_264(Client.smethod_46(), true, false, false);
								num2 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								if (((num3 != null & num2 != null) ? new bool?(num3.GetValueOrDefault() != num2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_28 = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various);
								}
							}
							else
							{
								rechargeBatteryPercentage = this.nullable_28;
								num2 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								rechargeBatteryPercentage = activeUnit.doctrine_0.method_264(Client.smethod_46(), false, false, false);
								num3 = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								if (((num2 != null & num3 != null) ? new bool?(num2.GetValueOrDefault() != num3.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_28 = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Various);
								}
							}
						}
						Doctrine._UseAIP? useAIP = this.doctrine_0.method_270(Client.smethod_46(), false, false, false);
						b = ((useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_272() && !activeUnit.doctrine_0.method_272())
							{
								useAIP = this.doctrine_0.method_270(Client.smethod_46(), false, false, false);
								b = ((useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
								useAIP = activeUnit.doctrine_0.method_270(Client.smethod_46(), false, false, false);
								b2 = ((useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_271(Client.smethod_46(), false, true, true, new Doctrine._UseAIP?(Doctrine._UseAIP.Various));
								}
							}
							else if (this.doctrine_0.method_272() && !activeUnit.doctrine_0.method_272())
							{
								this.doctrine_0.method_271(Client.smethod_46(), false, true, true, new Doctrine._UseAIP?(Doctrine._UseAIP.Various));
							}
							else if (!this.doctrine_0.method_272() && activeUnit.doctrine_0.method_272())
							{
								this.doctrine_0.method_271(Client.smethod_46(), false, true, true, new Doctrine._UseAIP?(Doctrine._UseAIP.Various));
							}
						}
						useAIP = this.nullable_29;
						b2 = ((useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_272())
							{
								useAIP = this.nullable_29;
								b2 = ((useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
								Doctrine doctrine76 = activeUnit.doctrine_0;
								Scenario scenario_76 = Client.smethod_46();
								bool flag = true;
								useAIP = doctrine76.method_3(scenario_76, ref flag).method_270(Client.smethod_46(), true, false, false);
								b = ((useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_29 = new Doctrine._UseAIP?(Doctrine._UseAIP.Various);
								}
							}
							else
							{
								useAIP = this.nullable_29;
								b = ((useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
								useAIP = activeUnit.doctrine_0.method_270(Client.smethod_46(), false, false, false);
								b2 = ((useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_29 = new Doctrine._UseAIP?(Doctrine._UseAIP.Various);
								}
							}
						}
						Doctrine._UseDippingSonar? useDippingSonar = this.doctrine_0.method_276(Client.smethod_46(), false, false, false);
						b2 = ((useDippingSonar != null) ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_278() && !activeUnit.doctrine_0.method_278())
							{
								useDippingSonar = this.doctrine_0.method_276(Client.smethod_46(), false, false, false);
								b2 = ((useDippingSonar != null) ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
								useDippingSonar = activeUnit.doctrine_0.method_276(Client.smethod_46(), false, false, false);
								b = ((useDippingSonar != null) ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_277(Client.smethod_46(), false, true, true, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Various));
								}
							}
							else if (this.doctrine_0.method_278() && !activeUnit.doctrine_0.method_278())
							{
								this.doctrine_0.method_277(Client.smethod_46(), false, true, true, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Various));
							}
							else if (!this.doctrine_0.method_278() && activeUnit.doctrine_0.method_278())
							{
								this.doctrine_0.method_277(Client.smethod_46(), false, true, true, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Various));
							}
						}
						useDippingSonar = this.nullable_30;
						b = ((useDippingSonar != null) ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_278())
							{
								useDippingSonar = this.nullable_30;
								b = ((useDippingSonar != null) ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
								Doctrine doctrine77 = activeUnit.doctrine_0;
								Scenario scenario_77 = Client.smethod_46();
								bool flag = true;
								useDippingSonar = doctrine77.method_3(scenario_77, ref flag).method_276(Client.smethod_46(), true, false, false);
								b2 = ((useDippingSonar != null) ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_30 = new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Various);
								}
							}
							else
							{
								useDippingSonar = this.nullable_30;
								b2 = ((useDippingSonar != null) ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
								useDippingSonar = activeUnit.doctrine_0.method_276(Client.smethod_46(), false, false, false);
								b = ((useDippingSonar != null) ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_30 = new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Various);
								}
							}
						}
						Doctrine._JettisonOrdnance? jettisonOrdnance = this.doctrine_0.method_127(Client.smethod_46(), false, false, false);
						b = ((jettisonOrdnance != null) ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_129() && !activeUnit.doctrine_0.method_129())
							{
								jettisonOrdnance = this.doctrine_0.method_127(Client.smethod_46(), false, false, false);
								b = ((jettisonOrdnance != null) ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
								jettisonOrdnance = activeUnit.doctrine_0.method_127(Client.smethod_46(), false, false, false);
								b2 = ((jettisonOrdnance != null) ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_128(Client.smethod_46(), false, true, true, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Various));
								}
							}
							else if (this.doctrine_0.method_129() && !activeUnit.doctrine_0.method_129())
							{
								this.doctrine_0.method_128(Client.smethod_46(), false, true, true, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Various));
							}
							else if (!this.doctrine_0.method_129() && activeUnit.doctrine_0.method_129())
							{
								this.doctrine_0.method_128(Client.smethod_46(), false, true, true, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Various));
							}
						}
						jettisonOrdnance = this.nullable_8;
						b2 = ((jettisonOrdnance != null) ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 2) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_129())
							{
								jettisonOrdnance = this.nullable_8;
								b2 = ((jettisonOrdnance != null) ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
								Doctrine doctrine78 = activeUnit.doctrine_0;
								Scenario scenario_78 = Client.smethod_46();
								bool flag = true;
								jettisonOrdnance = doctrine78.method_3(scenario_78, ref flag).method_127(Client.smethod_46(), true, false, false);
								b = ((jettisonOrdnance != null) ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_8 = new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Various);
								}
							}
							else
							{
								jettisonOrdnance = this.nullable_8;
								b = ((jettisonOrdnance != null) ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
								jettisonOrdnance = activeUnit.doctrine_0.method_127(Client.smethod_46(), false, false, false);
								b2 = ((jettisonOrdnance != null) ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_8 = new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Various);
								}
							}
						}
						Doctrine._BVRLogicEnum? bvrlogicEnum = this.doctrine_0.method_132(Client.smethod_46(), false, false, false);
						b2 = ((bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_134() && !activeUnit.doctrine_0.method_134())
							{
								bvrlogicEnum = this.doctrine_0.method_132(Client.smethod_46(), false, false, false);
								b2 = ((bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null);
								bvrlogicEnum = activeUnit.doctrine_0.method_132(Client.smethod_46(), false, false, false);
								b = ((bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_133(Client.smethod_46(), false, true, true, new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.Various));
								}
							}
							else if (this.doctrine_0.method_134() && !activeUnit.doctrine_0.method_134())
							{
								this.doctrine_0.method_133(Client.smethod_46(), false, true, true, new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.Various));
							}
							else if (!this.doctrine_0.method_134() && activeUnit.doctrine_0.method_134())
							{
								this.doctrine_0.method_133(Client.smethod_46(), false, true, true, new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.Various));
							}
						}
						bvrlogicEnum = this.nullable_9;
						b = ((bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_134())
							{
								bvrlogicEnum = this.nullable_9;
								b = ((bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null);
								Doctrine doctrine79 = activeUnit.doctrine_0;
								Scenario scenario_79 = Client.smethod_46();
								bool flag = true;
								bvrlogicEnum = doctrine79.method_3(scenario_79, ref flag).method_132(Client.smethod_46(), true, false, false);
								b2 = ((bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_9 = new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.Various);
								}
							}
							else
							{
								bvrlogicEnum = this.nullable_9;
								b2 = ((bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null);
								bvrlogicEnum = activeUnit.doctrine_0.method_132(Client.smethod_46(), false, false, false);
								b = ((bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_9 = new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.Various);
								}
							}
						}
						if (this.doctrine_0.method_7() != activeUnit.doctrine_0.method_7() && !this.doctrine_0.method_7())
						{
							this.doctrine_0.method_8(true);
						}
						if (Information.IsNothing(this.enum66_0))
						{
							if (this.doctrine_0.method_6(Client.smethod_46()).method_1() != Doctrine.Class275.Enum66.const_2 && this.doctrine_0.method_6(Client.smethod_46()).method_1() != activeUnit.doctrine_0.method_6(Client.smethod_46()).method_1())
							{
								this.doctrine_0.method_192(Doctrine.Class275.Enum66.const_2, Client.smethod_46());
							}
						}
						else if (!activeUnit.doctrine_0.method_7())
						{
							if (this.doctrine_0.method_6(Client.smethod_46()).method_1() != activeUnit.doctrine_0.method_6(Client.smethod_46()).method_1())
							{
								this.doctrine_0.method_192(Doctrine.Class275.Enum66.const_2, Client.smethod_46());
							}
						}
						else if (this.enum66_0 != activeUnit.doctrine_0.method_6(Client.smethod_46()).method_1())
						{
							this.enum66_0 = Doctrine.Class275.Enum66.const_2;
						}
						if (Information.IsNothing(this.enum66_1))
						{
							if (this.doctrine_0.method_6(Client.smethod_46()).method_2() != Doctrine.Class275.Enum66.const_2 && this.doctrine_0.method_6(Client.smethod_46()).method_2() != activeUnit.doctrine_0.method_6(Client.smethod_46()).method_2())
							{
								this.doctrine_0.method_193(Doctrine.Class275.Enum66.const_2, Client.smethod_46());
							}
						}
						else if (!activeUnit.doctrine_0.method_7())
						{
							if (this.doctrine_0.method_6(Client.smethod_46()).method_2() != activeUnit.doctrine_0.method_6(Client.smethod_46()).method_2())
							{
								this.doctrine_0.method_193(Doctrine.Class275.Enum66.const_2, Client.smethod_46());
							}
						}
						else if (this.enum66_1 != activeUnit.doctrine_0.method_6(Client.smethod_46()).method_2())
						{
							this.enum66_1 = Doctrine.Class275.Enum66.const_2;
						}
						if (Information.IsNothing(this.enum66_2))
						{
							if (this.doctrine_0.method_6(Client.smethod_46()).method_3() != Doctrine.Class275.Enum66.const_2 && this.doctrine_0.method_6(Client.smethod_46()).method_3() != activeUnit.doctrine_0.method_6(Client.smethod_46()).method_3())
							{
								this.doctrine_0.method_194(Doctrine.Class275.Enum66.const_2, Client.smethod_46());
							}
						}
						else if (!activeUnit.doctrine_0.method_7())
						{
							if (this.doctrine_0.method_6(Client.smethod_46()).method_3() != activeUnit.doctrine_0.method_6(Client.smethod_46()).method_3())
							{
								this.doctrine_0.method_194(Doctrine.Class275.Enum66.const_2, Client.smethod_46());
							}
						}
						else if (this.enum66_2 != activeUnit.doctrine_0.method_6(Client.smethod_46()).method_3())
						{
							this.enum66_2 = Doctrine.Class275.Enum66.const_2;
						}
						Doctrine.Enum63? enum15 = this.doctrine_0.method_177(Client.smethod_46(), false, false, false);
						b = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_179() && !activeUnit.doctrine_0.method_179())
							{
								enum15 = this.doctrine_0.method_177(Client.smethod_46(), false, false, false);
								b = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								enum15 = activeUnit.doctrine_0.method_177(Client.smethod_46(), false, false, false);
								b2 = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_178(Client.smethod_46(), false, true, true, new Doctrine.Enum63?(Doctrine.Enum63.const_6));
								}
							}
							else if (this.doctrine_0.method_179() && !activeUnit.doctrine_0.method_179())
							{
								this.doctrine_0.method_178(Client.smethod_46(), false, true, true, new Doctrine.Enum63?(Doctrine.Enum63.const_6));
							}
							else if (!this.doctrine_0.method_179() && activeUnit.doctrine_0.method_179())
							{
								this.doctrine_0.method_178(Client.smethod_46(), false, true, true, new Doctrine.Enum63?(Doctrine.Enum63.const_6));
							}
						}
						enum15 = this.nullable_31;
						b2 = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 6) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_179())
							{
								enum15 = this.nullable_31;
								b2 = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								Doctrine doctrine80 = activeUnit.doctrine_0;
								Scenario scenario_80 = Client.smethod_46();
								bool flag = true;
								enum15 = doctrine80.method_3(scenario_80, ref flag).method_177(Client.smethod_46(), true, false, false);
								b = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_31 = new Doctrine.Enum63?(Doctrine.Enum63.const_6);
								}
							}
							else
							{
								enum15 = this.nullable_31;
								b = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								enum15 = activeUnit.doctrine_0.method_177(Client.smethod_46(), false, false, false);
								b2 = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_31 = new Doctrine.Enum63?(Doctrine.Enum63.const_6);
								}
							}
						}
						enum15 = this.doctrine_0.method_182(Client.smethod_46(), false, false, false);
						b2 = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 6) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_184() && !activeUnit.doctrine_0.method_184())
							{
								enum15 = this.doctrine_0.method_182(Client.smethod_46(), false, false, false);
								b2 = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								enum15 = activeUnit.doctrine_0.method_182(Client.smethod_46(), false, false, false);
								b = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_183(Client.smethod_46(), false, true, true, new Doctrine.Enum63?(Doctrine.Enum63.const_6));
								}
							}
							else if (this.doctrine_0.method_184() && !activeUnit.doctrine_0.method_184())
							{
								this.doctrine_0.method_183(Client.smethod_46(), false, true, true, new Doctrine.Enum63?(Doctrine.Enum63.const_6));
							}
							else if (!this.doctrine_0.method_184() && activeUnit.doctrine_0.method_184())
							{
								this.doctrine_0.method_183(Client.smethod_46(), false, true, true, new Doctrine.Enum63?(Doctrine.Enum63.const_6));
							}
						}
						enum15 = this.nullable_32;
						b = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_184())
							{
								enum15 = this.nullable_32;
								b = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								Doctrine doctrine81 = activeUnit.doctrine_0;
								Scenario scenario_81 = Client.smethod_46();
								bool flag = true;
								enum15 = doctrine81.method_3(scenario_81, ref flag).method_182(Client.smethod_46(), true, false, false);
								b2 = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_32 = new Doctrine.Enum63?(Doctrine.Enum63.const_6);
								}
							}
							else
							{
								enum15 = this.nullable_32;
								b2 = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								enum15 = activeUnit.doctrine_0.method_182(Client.smethod_46(), false, false, false);
								b = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_32 = new Doctrine.Enum63?(Doctrine.Enum63.const_6);
								}
							}
						}
						enum15 = this.doctrine_0.method_187(Client.smethod_46(), false, false, false);
						b = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
						flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!this.doctrine_0.method_189() && !activeUnit.doctrine_0.method_189())
							{
								enum15 = this.doctrine_0.method_187(Client.smethod_46(), false, false, false);
								b = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								enum15 = activeUnit.doctrine_0.method_187(Client.smethod_46(), false, false, false);
								b2 = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.doctrine_0.method_188(Client.smethod_46(), false, true, true, new Doctrine.Enum63?(Doctrine.Enum63.const_6));
								}
							}
							else if (this.doctrine_0.method_189() && !activeUnit.doctrine_0.method_189())
							{
								this.doctrine_0.method_188(Client.smethod_46(), false, true, true, new Doctrine.Enum63?(Doctrine.Enum63.const_6));
							}
							else if (!this.doctrine_0.method_189() && activeUnit.doctrine_0.method_189())
							{
								this.doctrine_0.method_188(Client.smethod_46(), false, true, true, new Doctrine.Enum63?(Doctrine.Enum63.const_6));
							}
						}
						enum15 = this.nullable_33;
						b2 = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
						flag2 = ((b2 != null) ? new bool?(b2.GetValueOrDefault() == 6) : null);
						if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
						{
							if (!activeUnit.doctrine_0.method_189())
							{
								enum15 = this.nullable_33;
								b2 = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								Doctrine doctrine82 = activeUnit.doctrine_0;
								Scenario scenario_82 = Client.smethod_46();
								bool flag = true;
								enum15 = doctrine82.method_3(scenario_82, ref flag).method_187(Client.smethod_46(), true, false, false);
								b = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								if (((b2 != null & b != null) ? new bool?(b2.GetValueOrDefault() != b.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_33 = new Doctrine.Enum63?(Doctrine.Enum63.const_6);
								}
							}
							else
							{
								enum15 = this.nullable_33;
								b = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								enum15 = activeUnit.doctrine_0.method_187(Client.smethod_46(), false, false, false);
								b2 = ((enum15 != null) ? new byte?((byte)enum15.GetValueOrDefault()) : null);
								if (((b != null & b2 != null) ? new bool?(b.GetValueOrDefault() != b2.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									this.nullable_33 = new Doctrine.Enum63?(Doctrine.Enum63.const_6);
								}
							}
						}
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return this.doctrine_0;
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x004168E0 File Offset: 0x00414AE0
		private void method_115()
		{
			int num = 0;
			try
			{
				foreach (ActiveUnit activeUnit in this.list_0)
				{
					num++;
					if (num == 1)
					{
						if (Information.IsNothing(activeUnit.doctrine_0.method_27()))
						{
							continue;
						}
						try
						{
							foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair in activeUnit.doctrine_0.method_27())
							{
								int key = keyValuePair.Key;
								Doctrine.WRA_Weapon wra_Weapon = new Doctrine.WRA_Weapon();
								activeUnit.doctrine_0.method_27().TryGetValue(key, out wra_Weapon);
								foreach (Doctrine.Class276 @class in wra_Weapon.class276_0)
								{
									if (Information.IsNothing(this.doctrine_0.method_27()))
									{
										this.doctrine_0.method_28(new Dictionary<int, Doctrine.WRA_Weapon>());
									}
									if (!this.doctrine_0.method_27().ContainsKey(key))
									{
										Doctrine.WRA_Weapon value = new Doctrine.WRA_Weapon();
										this.doctrine_0.method_27().Add(key, value);
									}
									if (this.doctrine_0.method_27().ContainsKey(key))
									{
										Doctrine.WRA_Weapon wra_Weapon2 = new Doctrine.WRA_Weapon();
										this.doctrine_0.method_27().TryGetValue(key, out wra_Weapon2);
										Doctrine.Class276 class2 = new Doctrine.Class276(@class._WRA_WeaponTargetType_0);
										class2.nullable_0 = @class.nullable_0;
										class2.nullable_1 = @class.nullable_1;
										class2.nullable_3 = @class.nullable_3;
										class2.nullable_2 = @class.nullable_2;
										Class429.smethod_46(ref wra_Weapon2.class276_0, class2);
									}
								}
							}
							continue;
						}
						finally
						{
							Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
					if (!Information.IsNothing(this.doctrine_0.method_27()))
					{
						try
						{
							foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair2 in this.doctrine_0.method_27())
							{
								int key2 = keyValuePair2.Key;
								Doctrine.WRA_Weapon wra_Weapon3 = new Doctrine.WRA_Weapon();
								this.doctrine_0.method_27().TryGetValue(key2, out wra_Weapon3);
								foreach (Doctrine.Class276 class3 in wra_Weapon3.class276_0)
								{
									int? num2 = null;
									int? num3 = null;
									int? num4 = null;
									int? num5 = null;
									if (!Information.IsNothing(activeUnit.doctrine_0.method_27()) && activeUnit.doctrine_0.method_27().ContainsKey(key2))
									{
										Doctrine.WRA_Weapon wra_Weapon4 = new Doctrine.WRA_Weapon();
										activeUnit.doctrine_0.method_27().TryGetValue(key2, out wra_Weapon4);
										if (!Information.IsNothing(wra_Weapon4))
										{
											foreach (Doctrine.Class276 class4 in wra_Weapon4.class276_0)
											{
												if (class3._WRA_WeaponTargetType_0 == class4._WRA_WeaponTargetType_0)
												{
													num2 = class4.nullable_0;
													num3 = class4.nullable_1;
													num4 = class4.nullable_3;
													num5 = class4.nullable_2;
													break;
												}
											}
										}
									}
									int? num6 = class3.nullable_0;
									bool? flag = (num6 != null) ? new bool?(num6.GetValueOrDefault() == -100) : null;
									if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
									{
										if (!Information.IsNothing(class3.nullable_0) && !Information.IsNothing(num2))
										{
											num6 = class3.nullable_0;
											if (((num6 != null & num2 != null) ? new bool?(num6.GetValueOrDefault() != num2.GetValueOrDefault()) : null).GetValueOrDefault())
											{
												class3.nullable_0 = new int?(-100);
											}
										}
										else if (Information.IsNothing(class3.nullable_0) && !Information.IsNothing(num2))
										{
											class3.nullable_0 = new int?(-100);
										}
										else if (!Information.IsNothing(class3.nullable_0) && Information.IsNothing(num2))
										{
											class3.nullable_0 = new int?(-100);
										}
									}
									num6 = class3.nullable_1;
									flag = ((num6 != null) ? new bool?(num6.GetValueOrDefault() == -100) : null);
									if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
									{
										if (!Information.IsNothing(class3.nullable_1) && !Information.IsNothing(num3))
										{
											num6 = class3.nullable_1;
											if (((num6 != null & num3 != null) ? new bool?(num6.GetValueOrDefault() != num3.GetValueOrDefault()) : null).GetValueOrDefault())
											{
												class3.nullable_1 = new int?(-100);
											}
										}
										else if (Information.IsNothing(class3.nullable_1) && !Information.IsNothing(num3))
										{
											class3.nullable_1 = new int?(-100);
										}
										else if (!Information.IsNothing(class3.nullable_1) && Information.IsNothing(num3))
										{
											class3.nullable_1 = new int?(-100);
										}
									}
									num6 = class3.nullable_3;
									flag = ((num6 != null) ? new bool?(num6.GetValueOrDefault() == -100) : null);
									if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
									{
										if (!Information.IsNothing(class3.nullable_3) && !Information.IsNothing(num4))
										{
											num6 = class3.nullable_3;
											if (((num6 != null & num4 != null) ? new bool?(num6.GetValueOrDefault() != num4.GetValueOrDefault()) : null).GetValueOrDefault())
											{
												class3.nullable_3 = new int?(-100);
											}
										}
										else if (Information.IsNothing(class3.nullable_3) && !Information.IsNothing(num4))
										{
											class3.nullable_3 = new int?(-100);
										}
										else if (!Information.IsNothing(class3.nullable_3) && Information.IsNothing(num4))
										{
											class3.nullable_3 = new int?(-100);
										}
									}
									num6 = class3.nullable_2;
									flag = ((num6 != null) ? new bool?(num6.GetValueOrDefault() == -100) : null);
									if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
									{
										if (!Information.IsNothing(class3.nullable_2) && !Information.IsNothing(num5))
										{
											num6 = class3.nullable_2;
											if (((num6 != null & num5 != null) ? new bool?(num6.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
											{
												class3.nullable_2 = new int?(-100);
											}
										}
										else if (Information.IsNothing(class3.nullable_2) && !Information.IsNothing(num5))
										{
											class3.nullable_2 = new int?(-100);
										}
										else if (!Information.IsNothing(class3.nullable_2) && Information.IsNothing(num5))
										{
											class3.nullable_2 = new int?(-100);
										}
									}
								}
							}
						}
						finally
						{
							Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
					}
					checked
					{
						if (!Information.IsNothing(activeUnit.doctrine_0.method_27()))
						{
							try
							{
								foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair3 in activeUnit.doctrine_0.method_27())
								{
									int key3 = keyValuePair3.Key;
									Doctrine.WRA_Weapon wra_Weapon5 = new Doctrine.WRA_Weapon();
									activeUnit.doctrine_0.method_27().TryGetValue(key3, out wra_Weapon5);
									foreach (Doctrine.Class276 class5 in wra_Weapon5.class276_0)
									{
										if (Information.IsNothing(this.doctrine_0.method_27()))
										{
											this.doctrine_0.method_28(new Dictionary<int, Doctrine.WRA_Weapon>());
										}
										if (!this.doctrine_0.method_27().ContainsKey(key3))
										{
											Doctrine.WRA_Weapon value2 = new Doctrine.WRA_Weapon();
											this.doctrine_0.method_27().Add(key3, value2);
										}
										if (this.doctrine_0.method_27().ContainsKey(key3))
										{
											Doctrine.WRA_Weapon wra_Weapon6 = new Doctrine.WRA_Weapon();
											this.doctrine_0.method_27().TryGetValue(key3, out wra_Weapon6);
											bool flag2 = false;
											Doctrine.Class276[] class276_5 = wra_Weapon6.class276_0;
											int m = 0;
											while (m < class276_5.Length)
											{
												Doctrine.Class276 class6 = class276_5[m];
												if (class6._WRA_WeaponTargetType_0 == class5._WRA_WeaponTargetType_0)
												{
													flag2 = true;
													int? num6 = class6.nullable_0;
													bool? flag3 = (num6 != null) ? new bool?(num6.GetValueOrDefault() == -100) : null;
													bool? flag = flag3 = ((flag3 != null) ? new bool?(!flag3.GetValueOrDefault()) : flag3);
													int? num7;
													if (((flag3 == null || !flag.GetValueOrDefault()) ? (flag | Information.IsNothing(class6.nullable_0)) : new bool?(true)).GetValueOrDefault())
													{
														if (!Information.IsNothing(class6.nullable_0) && !Information.IsNothing(class5.nullable_0))
														{
															num6 = class6.nullable_0;
															num7 = class5.nullable_0;
															if (((num6 != null & num7 != null) ? new bool?(num6.GetValueOrDefault() != num7.GetValueOrDefault()) : null).GetValueOrDefault())
															{
																class6.nullable_0 = new int?(-100);
															}
														}
														else if (Information.IsNothing(class6.nullable_0) && !Information.IsNothing(class5.nullable_0))
														{
															class6.nullable_0 = new int?(-100);
														}
														else if (!Information.IsNothing(class6.nullable_0) && Information.IsNothing(class5.nullable_0))
														{
															class6.nullable_0 = new int?(-100);
														}
													}
													num7 = class6.nullable_1;
													flag3 = ((num7 != null) ? new bool?(num7.GetValueOrDefault() == -100) : null);
													flag = (flag3 = ((flag3 != null) ? new bool?(!flag3.GetValueOrDefault()) : flag3));
													if (((flag3 == null || !flag.GetValueOrDefault()) ? (flag | Information.IsNothing(class6.nullable_1)) : new bool?(true)).GetValueOrDefault())
													{
														if (!Information.IsNothing(class6.nullable_1) && !Information.IsNothing(class5.nullable_1))
														{
															num7 = class6.nullable_1;
															num6 = class5.nullable_1;
															if (((num7 != null & num6 != null) ? new bool?(num7.GetValueOrDefault() != num6.GetValueOrDefault()) : null).GetValueOrDefault())
															{
																class6.nullable_1 = new int?(-100);
															}
														}
														else if (Information.IsNothing(class6.nullable_1) && !Information.IsNothing(class5.nullable_1))
														{
															class6.nullable_1 = new int?(-100);
														}
														else if (!Information.IsNothing(class6.nullable_1) && Information.IsNothing(class5.nullable_1))
														{
															class6.nullable_1 = new int?(-100);
														}
													}
													num6 = class6.nullable_3;
													flag3 = ((num6 != null) ? new bool?(num6.GetValueOrDefault() == -100) : null);
													flag = (flag3 = ((flag3 != null) ? new bool?(!flag3.GetValueOrDefault()) : flag3));
													if (((flag3 == null || !flag.GetValueOrDefault()) ? (flag | Information.IsNothing(class6.nullable_3)) : new bool?(true)).GetValueOrDefault())
													{
														if (!Information.IsNothing(class6.nullable_3) && !Information.IsNothing(class5.nullable_3))
														{
															num6 = class6.nullable_3;
															num7 = class5.nullable_3;
															if (((num6 != null & num7 != null) ? new bool?(num6.GetValueOrDefault() != num7.GetValueOrDefault()) : null).GetValueOrDefault())
															{
																class6.nullable_3 = new int?(-100);
															}
														}
														else if (Information.IsNothing(class6.nullable_3) && !Information.IsNothing(class5.nullable_3))
														{
															class6.nullable_3 = new int?(-100);
														}
														else if (!Information.IsNothing(class6.nullable_3) && Information.IsNothing(class5.nullable_3))
														{
															class6.nullable_3 = new int?(-100);
														}
													}
													num7 = class6.nullable_2;
													flag3 = ((num7 != null) ? new bool?(num7.GetValueOrDefault() == -100) : null);
													flag = (flag3 = ((flag3 != null) ? new bool?(!flag3.GetValueOrDefault()) : flag3));
													if (((flag3 == null || !flag.GetValueOrDefault()) ? (flag | Information.IsNothing(class6.nullable_2)) : new bool?(true)).GetValueOrDefault())
													{
														if (!Information.IsNothing(class6.nullable_2) && !Information.IsNothing(class5.nullable_2))
														{
															num7 = class6.nullable_2;
															num6 = class5.nullable_2;
															if (((num7 != null & num6 != null) ? new bool?(num7.GetValueOrDefault() != num6.GetValueOrDefault()) : null).GetValueOrDefault())
															{
																class6.nullable_2 = new int?(-100);
															}
														}
														else if (Information.IsNothing(class6.nullable_2) && !Information.IsNothing(class5.nullable_2))
														{
															class6.nullable_2 = new int?(-100);
														}
														else if (!Information.IsNothing(class6.nullable_2) && Information.IsNothing(class5.nullable_2))
														{
															class6.nullable_2 = new int?(-100);
														}
													}
													IL_F2D:
													if (!flag2)
													{
														Doctrine.Class276 class7 = new Doctrine.Class276(class5._WRA_WeaponTargetType_0);
														if (!Information.IsNothing(class5.nullable_0))
														{
															class7.nullable_0 = new int?(-100);
														}
														if (!Information.IsNothing(class5.nullable_1))
														{
															class7.nullable_1 = new int?(-100);
														}
														if (!Information.IsNothing(class5.nullable_3))
														{
															class7.nullable_3 = new int?(-100);
														}
														if (!Information.IsNothing(class5.nullable_2))
														{
															class7.nullable_2 = new int?(-100);
														}
														Class429.smethod_46(ref wra_Weapon6.class276_0, class7);
														goto IL_FD4;
													}
													goto IL_FD4;
												}
												else
												{
													m++;
												}
											}
											goto IL_F2D;
										}
										IL_FD4:;
									}
								}
							}
							finally
							{
								Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
						}
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x0600780E RID: 30734
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SendMessage(IntPtr intptr_0, int int_42, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x0600780F RID: 30735 RVA: 0x0004A2FA File Offset: 0x000484FA
		private void method_116()
		{
			DoctrineForm.SendMessage(base.Handle, 11, new IntPtr(0), IntPtr.Zero);
			Class2413.smethod_2().method_41().rightColumnWPF_0.method_0();
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x0004A329 File Offset: 0x00048529
		private void method_117(bool Refresh = true)
		{
			DoctrineForm.SendMessage(base.Handle, 11, new IntPtr(-1), IntPtr.Zero);
			if (Refresh)
			{
				this.Refresh();
			}
			Class2413.smethod_2().method_41().rightColumnWPF_0.method_1();
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_118(object sender, DataGridViewDataErrorEventArgs e)
		{
		}

		// Token: 0x06007812 RID: 30738 RVA: 0x0004A361 File Offset: 0x00048561
		private void method_119(object sender, EventArgs e)
		{
			this.doctrine_0.method_126(Client.smethod_46(), this.vmethod_232().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x06007813 RID: 30739 RVA: 0x0004A398 File Offset: 0x00048598
		private void method_120(object sender, EventArgs e)
		{
			this.doctrine_0.method_131(Client.smethod_46(), this.vmethod_230().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x0004A3CF File Offset: 0x000485CF
		private void method_121(object sender, EventArgs e)
		{
			this.doctrine_0.method_244(Client.smethod_46(), this.vmethod_240().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x0004A406 File Offset: 0x00048606
		private void method_122(object sender, EventArgs e)
		{
			this.doctrine_0.method_250(Client.smethod_46(), this.vmethod_246().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x0004A43D File Offset: 0x0004863D
		private void method_123(object sender, EventArgs e)
		{
			this.doctrine_0.method_256(Client.smethod_46(), this.vmethod_248().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x0004A474 File Offset: 0x00048674
		private void method_124(object sender, EventArgs e)
		{
			this.doctrine_0.method_262(Client.smethod_46(), this.vmethod_252().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x0004A4AB File Offset: 0x000486AB
		private void method_125(object sender, EventArgs e)
		{
			this.doctrine_0.method_268(Client.smethod_46(), this.vmethod_256().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x0004A4E2 File Offset: 0x000486E2
		private void method_126(object sender, EventArgs e)
		{
			this.doctrine_0.method_274(Client.smethod_46(), this.vmethod_260().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x0004A519 File Offset: 0x00048719
		private void method_127(object sender, EventArgs e)
		{
			this.doctrine_0.method_280(Client.smethod_46(), this.vmethod_264().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x0004A550 File Offset: 0x00048750
		private void method_128(object sender, EventArgs e)
		{
			this.doctrine_0.method_136(Client.smethod_46(), this.vmethod_290().Checked);
			Class2413.smethod_2().method_41().method_97().class2423_0.method_0(false);
		}

		// Token: 0x0600781C RID: 30748 RVA: 0x00417970 File Offset: 0x00415B70
		private void method_129(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_274();
			Scenario scenario = Client.smethod_46();
			doctrine.method_344(comboBox_, ref scenario, ref this.int_24, true, false);
			Doctrine doctrine2 = this.doctrine_0;
			scenario = Client.smethod_46();
			Side side_ = Client.smethod_50();
			doctrine2.method_357(ref scenario, ref side_);
			Client.smethod_51(side_);
			this.method_16();
		}

		// Token: 0x0600781D RID: 30749 RVA: 0x004179C8 File Offset: 0x00415BC8
		private void method_130(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_276();
			Scenario scenario = Client.smethod_46();
			doctrine.method_346(comboBox_, ref scenario, ref this.int_25, true, false);
			this.method_16();
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x004179FC File Offset: 0x00415BFC
		private void method_131(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_278();
			Scenario scenario = Client.smethod_46();
			doctrine.method_348(comboBox_, ref scenario, ref this.int_26, true, false);
			this.method_16();
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x00417A30 File Offset: 0x00415C30
		private void method_132(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_280();
			Scenario scenario = Client.smethod_46();
			doctrine.method_350(comboBox_, ref scenario, ref this.int_27, true, false);
			this.method_16();
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x00417A64 File Offset: 0x00415C64
		private void method_133(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_282();
			Scenario scenario = Client.smethod_46();
			doctrine.method_352(comboBox_, ref scenario, ref this.int_28, true, false);
			this.method_16();
		}

		// Token: 0x06007821 RID: 30753 RVA: 0x00417A98 File Offset: 0x00415C98
		private void method_134(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_284();
			Scenario scenario = Client.smethod_46();
			doctrine.method_354(comboBox_, ref scenario, ref this.int_29, true, false);
			this.method_16();
		}

		// Token: 0x06007822 RID: 30754 RVA: 0x00417ACC File Offset: 0x00415CCC
		private void method_135(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_286();
			Scenario scenario = Client.smethod_46();
			doctrine.method_356(comboBox_, ref scenario, ref this.int_30, true, false);
			this.method_16();
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x0004A587 File Offset: 0x00048787
		private void method_136(object sender, EventArgs e)
		{
			this.int_24 = this.vmethod_274().SelectedIndex;
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x0004A59A File Offset: 0x0004879A
		private void method_137(object sender, EventArgs e)
		{
			this.int_25 = this.vmethod_276().SelectedIndex;
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x0004A5AD File Offset: 0x000487AD
		private void method_138(object sender, EventArgs e)
		{
			this.int_26 = this.vmethod_278().SelectedIndex;
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x0004A5C0 File Offset: 0x000487C0
		private void method_139(object sender, EventArgs e)
		{
			this.int_10 = this.vmethod_70().SelectedIndex;
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x0004A5D3 File Offset: 0x000487D3
		private void method_140(object sender, EventArgs e)
		{
			this.int_27 = this.vmethod_280().SelectedIndex;
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x0004A5E6 File Offset: 0x000487E6
		private void method_141(object sender, EventArgs e)
		{
			this.int_28 = this.vmethod_282().SelectedIndex;
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x0004A5F9 File Offset: 0x000487F9
		private void method_142(object sender, EventArgs e)
		{
			this.int_29 = this.vmethod_284().SelectedIndex;
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x0004A60C File Offset: 0x0004880C
		private void method_143(object sender, EventArgs e)
		{
			this.int_30 = this.vmethod_286().SelectedIndex;
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x0004A61F File Offset: 0x0004881F
		private void method_144(object sender, EventArgs e)
		{
			this.int_34 = this.vmethod_180().SelectedIndex;
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x0004A632 File Offset: 0x00048832
		private void method_145(object sender, EventArgs e)
		{
			this.int_38 = this.vmethod_198().SelectedIndex;
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x00417B00 File Offset: 0x00415D00
		private void method_146(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_180();
			Scenario scenario = Client.smethod_46();
			int num = 0;
			doctrine.method_374(comboBox_, ref scenario, ref num, true, true);
			this.method_16();
		}

		// Token: 0x0600782E RID: 30766 RVA: 0x00417B34 File Offset: 0x00415D34
		private void method_147(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_198();
			Scenario scenario = Client.smethod_46();
			int num = 0;
			doctrine.method_375(comboBox_, ref scenario, ref num, true, true);
			this.method_16();
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x0004A645 File Offset: 0x00048845
		private void method_148(object sender, EventArgs e)
		{
			this.int_35 = this.vmethod_170().SelectedIndex;
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x00417B68 File Offset: 0x00415D68
		private void method_149(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_170();
			Scenario scenario = Client.smethod_46();
			int num = 0;
			doctrine.method_376(comboBox_, ref scenario, ref num, true, true);
			this.method_16();
		}

		// Token: 0x06007831 RID: 30769 RVA: 0x0004A658 File Offset: 0x00048858
		private void method_150(object sender, EventArgs e)
		{
			this.int_39 = this.vmethod_188().SelectedIndex;
		}

		// Token: 0x06007832 RID: 30770 RVA: 0x00417B9C File Offset: 0x00415D9C
		private void method_151(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_188();
			Scenario scenario = Client.smethod_46();
			int num = 0;
			doctrine.method_377(comboBox_, ref scenario, ref num, true, true);
			this.method_16();
		}

		// Token: 0x06007833 RID: 30771 RVA: 0x0004A66B File Offset: 0x0004886B
		private void method_152(object sender, EventArgs e)
		{
			this.int_36 = this.vmethod_168().SelectedIndex;
		}

		// Token: 0x06007834 RID: 30772 RVA: 0x00417BD0 File Offset: 0x00415DD0
		private void method_153(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_168();
			Scenario scenario = Client.smethod_46();
			int num = 0;
			doctrine.method_378(comboBox_, ref scenario, ref num, true, true);
			this.method_16();
		}

		// Token: 0x06007835 RID: 30773 RVA: 0x0004A67E File Offset: 0x0004887E
		private void method_154(object sender, EventArgs e)
		{
			this.int_40 = this.vmethod_186().SelectedIndex;
		}

		// Token: 0x06007836 RID: 30774 RVA: 0x00417C04 File Offset: 0x00415E04
		private void method_155(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_186();
			Scenario scenario = Client.smethod_46();
			int num = 0;
			doctrine.method_379(comboBox_, ref scenario, ref num, true, true);
			this.method_16();
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x0004A691 File Offset: 0x00048891
		private void method_156(object sender, EventArgs e)
		{
			this.int_37 = this.vmethod_166().SelectedIndex;
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x00417C38 File Offset: 0x00415E38
		private void method_157(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_166();
			Scenario scenario = Client.smethod_46();
			int num = 0;
			doctrine.method_380(comboBox_, ref scenario, ref num, true, true);
			this.method_16();
		}

		// Token: 0x06007839 RID: 30777 RVA: 0x0004A6A4 File Offset: 0x000488A4
		private void method_158(object sender, EventArgs e)
		{
			this.int_41 = this.vmethod_184().SelectedIndex;
		}

		// Token: 0x0600783A RID: 30778 RVA: 0x00417C6C File Offset: 0x00415E6C
		private void method_159(object sender, EventArgs e)
		{
			Doctrine doctrine = this.doctrine_0;
			ComboBox comboBox_ = this.vmethod_184();
			Scenario scenario = Client.smethod_46();
			int num = 0;
			doctrine.method_381(comboBox_, ref scenario, ref num, true, true);
			this.method_16();
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x00417CA0 File Offset: 0x00415EA0
		private void DoctrineForm_Shown(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.vmethod_0().TabPages)
				{
					((TabPage)obj).BackColor = Class129.smethod_0();
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x04004253 RID: 16979
		[CompilerGenerated]
		[AccessedThroughProperty("TabControl1A")]
		private Control12 control12_0;

		// Token: 0x04004254 RID: 16980
		[AccessedThroughProperty("TabPage1")]
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04004255 RID: 16981
		[AccessedThroughProperty("TabPage2")]
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04004256 RID: 16982
		[CompilerGenerated]
		[AccessedThroughProperty("CB_EMCON_Radar")]
		private Class2451 class2451_0;

		// Token: 0x04004257 RID: 16983
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_0;

		// Token: 0x04004258 RID: 16984
		[CompilerGenerated]
		[AccessedThroughProperty("CB_EMCON_Inherits")]
		private Class112 class112_0;

		// Token: 0x04004259 RID: 16985
		[CompilerGenerated]
		[AccessedThroughProperty("CB_EMCON_OECM")]
		private Class2451 class2451_1;

		// Token: 0x0400425A RID: 16986
		[CompilerGenerated]
		[AccessedThroughProperty("Label8")]
		private Class116 class116_1;

		// Token: 0x0400425B RID: 16987
		[AccessedThroughProperty("CB_EMCON_Sonar")]
		[CompilerGenerated]
		private Class2451 class2451_2;

		// Token: 0x0400425C RID: 16988
		[CompilerGenerated]
		[AccessedThroughProperty("Label9")]
		private Class116 class116_2;

		// Token: 0x0400425D RID: 16989
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage3")]
		private TabPage tabPage_2;

		// Token: 0x0400425E RID: 16990
		[CompilerGenerated]
		[AccessedThroughProperty("TGV_WRA")]
		private Class50 class50_0;

		// Token: 0x0400425F RID: 16991
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ResetCurrent_WRA")]
		private Control9 control9_0;

		// Token: 0x04004260 RID: 16992
		[CompilerGenerated]
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x04004261 RID: 16993
		[CompilerGenerated]
		[AccessedThroughProperty("Label16")]
		private Class116 class116_3;

		// Token: 0x04004262 RID: 16994
		[AccessedThroughProperty("Label15")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x04004263 RID: 16995
		[AccessedThroughProperty("Label14")]
		[CompilerGenerated]
		private Class116 class116_5;

		// Token: 0x04004264 RID: 16996
		[CompilerGenerated]
		[AccessedThroughProperty("Label11")]
		private Class116 class116_6;

		// Token: 0x04004265 RID: 16997
		[CompilerGenerated]
		[AccessedThroughProperty("Label10")]
		private Class116 class116_7;

		// Token: 0x04004266 RID: 16998
		[AccessedThroughProperty("Label6")]
		[CompilerGenerated]
		private Class116 class116_8;

		// Token: 0x04004267 RID: 16999
		[CompilerGenerated]
		[AccessedThroughProperty("Label12")]
		private Class116 class116_9;

		// Token: 0x04004268 RID: 17000
		[AccessedThroughProperty("CB_WeaponStateRTB_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_1;

		// Token: 0x04004269 RID: 17001
		[CompilerGenerated]
		[AccessedThroughProperty("Label13")]
		private Class116 class116_10;

		// Token: 0x0400426A RID: 17002
		[CompilerGenerated]
		[AccessedThroughProperty("CB_WeaponControlStatus_Air_PlayerEditable")]
		private Class112 class112_2;

		// Token: 0x0400426B RID: 17003
		[AccessedThroughProperty("CB_UseNukes_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_3;

		// Token: 0x0400426C RID: 17004
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_11;

		// Token: 0x0400426D RID: 17005
		[AccessedThroughProperty("Combo_WeaponStateRTB")]
		[CompilerGenerated]
		private Class2451 class2451_3;

		// Token: 0x0400426E RID: 17006
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_WeaponControlStatus_Air")]
		private Class2451 class2451_4;

		// Token: 0x0400426F RID: 17007
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_UseNukes")]
		private Class2451 class2451_5;

		// Token: 0x04004270 RID: 17008
		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Class116 class116_12;

		// Token: 0x04004271 RID: 17009
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_BehaviorTowardsAmbigousTarget")]
		private Class2451 class2451_6;

		// Token: 0x04004272 RID: 17010
		[CompilerGenerated]
		[AccessedThroughProperty("CB_BehaviorTowardsAmbigousTarget_PlayerEditable")]
		private Class112 class112_4;

		// Token: 0x04004273 RID: 17011
		[AccessedThroughProperty("Label7")]
		[CompilerGenerated]
		private Class116 class116_13;

		// Token: 0x04004274 RID: 17012
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_AutoEvade")]
		private Class2451 class2451_7;

		// Token: 0x04004275 RID: 17013
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AutoEvade_PlayerEditable")]
		private Class112 class112_5;

		// Token: 0x04004276 RID: 17014
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_Standoff")]
		private Class2451 class2451_8;

		// Token: 0x04004277 RID: 17015
		[AccessedThroughProperty("CB_Standoff_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_6;

		// Token: 0x04004278 RID: 17016
		[AccessedThroughProperty("Combo_UseRefuel")]
		[CompilerGenerated]
		private Class2451 class2451_9;

		// Token: 0x04004279 RID: 17017
		[CompilerGenerated]
		[AccessedThroughProperty("CB_UseRefuel_PlayerEditable")]
		private Class112 class112_7;

		// Token: 0x0400427A RID: 17018
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_ShootTourists")]
		private Class2451 class2451_10;

		// Token: 0x0400427B RID: 17019
		[CompilerGenerated]
		[AccessedThroughProperty("CB_ShootTourists_PlayerEditable")]
		private Class112 class112_8;

		// Token: 0x0400427C RID: 17020
		[AccessedThroughProperty("Combo_UseSAMsOnASuW")]
		[CompilerGenerated]
		private Class2451 class2451_11;

		// Token: 0x0400427D RID: 17021
		[AccessedThroughProperty("CB_UseSAMsOnASuW_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_9;

		// Token: 0x0400427E RID: 17022
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_IgnoreEMCONunderAttack")]
		private Class2451 class2451_12;

		// Token: 0x0400427F RID: 17023
		[CompilerGenerated]
		[AccessedThroughProperty("CB_IgnoreEMCONunderAttack_PlayerEditable")]
		private Class112 class112_10;

		// Token: 0x04004280 RID: 17024
		[AccessedThroughProperty("Label17")]
		[CompilerGenerated]
		private Class116 class116_14;

		// Token: 0x04004281 RID: 17025
		[AccessedThroughProperty("Combo_QuickTurnAroundForAicraft")]
		[CompilerGenerated]
		private Class2451 class2451_13;

		// Token: 0x04004282 RID: 17026
		[AccessedThroughProperty("Combo_UseKinematicRangeForTorpedoes")]
		[CompilerGenerated]
		private Class2451 class2451_14;

		// Token: 0x04004283 RID: 17027
		[AccessedThroughProperty("CB_QuickTurnAroundForAicraft_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_11;

		// Token: 0x04004284 RID: 17028
		[AccessedThroughProperty("CB_UseKinematicRangeForTorpedoes_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_12;

		// Token: 0x04004285 RID: 17029
		[CompilerGenerated]
		[AccessedThroughProperty("Label18")]
		private Class116 class116_15;

		// Token: 0x04004286 RID: 17030
		[AccessedThroughProperty("Combo_AirOpsTempo")]
		[CompilerGenerated]
		private Class2451 class2451_15;

		// Token: 0x04004287 RID: 17031
		[AccessedThroughProperty("CB_AirOpsTempo_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_13;

		// Token: 0x04004288 RID: 17032
		[CompilerGenerated]
		[AccessedThroughProperty("Label19")]
		private Class116 class116_16;

		// Token: 0x04004289 RID: 17033
		[CompilerGenerated]
		[AccessedThroughProperty("Label20")]
		private Class116 class116_17;

		// Token: 0x0400428A RID: 17034
		[CompilerGenerated]
		[AccessedThroughProperty("Label21")]
		private Class116 class116_18;

		// Token: 0x0400428B RID: 17035
		[CompilerGenerated]
		[AccessedThroughProperty("Label22")]
		private Class116 class116_19;

		// Token: 0x0400428C RID: 17036
		[AccessedThroughProperty("Label24")]
		[CompilerGenerated]
		private Class116 class116_20;

		// Token: 0x0400428D RID: 17037
		[CompilerGenerated]
		[AccessedThroughProperty("Label25")]
		private Class116 class116_21;

		// Token: 0x0400428E RID: 17038
		[AccessedThroughProperty("Button_ResetAffectedMissions_Doctrine")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x0400428F RID: 17039
		[AccessedThroughProperty("Button_ResetAffectedUnits_Doctrine")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x04004290 RID: 17040
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ResetCurrent_Doctrine")]
		private Control9 control9_3;

		// Token: 0x04004291 RID: 17041
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ResetAffectedMissions_WRA")]
		private Control9 control9_4;

		// Token: 0x04004292 RID: 17042
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ResetAffectedUnits_WRA")]
		private Control9 control9_5;

		// Token: 0x04004293 RID: 17043
		[AccessedThroughProperty("Button_ResetAffectedMissions_EMCON")]
		[CompilerGenerated]
		private Control9 control9_6;

		// Token: 0x04004294 RID: 17044
		[AccessedThroughProperty("Button_ResetAffectedUnits_EMCON")]
		[CompilerGenerated]
		private Control9 control9_7;

		// Token: 0x04004295 RID: 17045
		[AccessedThroughProperty("Button_ResetCurrent_EMCON")]
		[CompilerGenerated]
		private Control9 control9_8;

		// Token: 0x04004296 RID: 17046
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_22;

		// Token: 0x04004297 RID: 17047
		[AccessedThroughProperty("Combo_IgnorePlottedCourse")]
		[CompilerGenerated]
		private Class2451 class2451_16;

		// Token: 0x04004298 RID: 17048
		[AccessedThroughProperty("CB_IgnorePlottedCourse_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_14;

		// Token: 0x04004299 RID: 17049
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_23;

		// Token: 0x0400429A RID: 17050
		[CompilerGenerated]
		[AccessedThroughProperty("Label23")]
		private Class116 class116_24;

		// Token: 0x0400429B RID: 17051
		[CompilerGenerated]
		[AccessedThroughProperty("Label26")]
		private Class116 class116_25;

		// Token: 0x0400429C RID: 17052
		[CompilerGenerated]
		[AccessedThroughProperty("CB_WeaponControlStatus_Surface_PlayerEditable")]
		private Class112 class112_15;

		// Token: 0x0400429D RID: 17053
		[CompilerGenerated]
		[AccessedThroughProperty("CB_WeaponControlStatus_Submarine_PlayerEditable")]
		private Class112 class112_16;

		// Token: 0x0400429E RID: 17054
		[CompilerGenerated]
		[AccessedThroughProperty("CB_WeaponControlStatus_Land_PlayerEditable")]
		private Class112 class112_17;

		// Token: 0x0400429F RID: 17055
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_WeaponControlStatus_Surface")]
		private Class2451 class2451_17;

		// Token: 0x040042A0 RID: 17056
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_WeaponControlStatus_Submarine")]
		private Class2451 class2451_18;

		// Token: 0x040042A1 RID: 17057
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_WeaponControlStatus_Land")]
		private Class2451 class2451_19;

		// Token: 0x040042A2 RID: 17058
		[CompilerGenerated]
		[AccessedThroughProperty("Label27")]
		private Class116 class116_26;

		// Token: 0x040042A3 RID: 17059
		[CompilerGenerated]
		[AccessedThroughProperty("CB_GunStrafing_PlayerEditable")]
		private Class112 class112_18;

		// Token: 0x040042A4 RID: 17060
		[AccessedThroughProperty("Combo_GunStrafing")]
		[CompilerGenerated]
		private Class2451 class2451_20;

		// Token: 0x040042A5 RID: 17061
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage4")]
		private TabPage tabPage_3;

		// Token: 0x040042A6 RID: 17062
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_WithdrawDefenceThreshold")]
		private Class2451 class2451_21;

		// Token: 0x040042A7 RID: 17063
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_WithdrawAttackThreshold")]
		private Class2451 class2451_22;

		// Token: 0x040042A8 RID: 17064
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_WithdrawFuelThreshold")]
		private Class2451 class2451_23;

		// Token: 0x040042A9 RID: 17065
		[CompilerGenerated]
		[AccessedThroughProperty("Label45")]
		private Class116 class116_27;

		// Token: 0x040042AA RID: 17066
		[AccessedThroughProperty("Label43")]
		[CompilerGenerated]
		private Class116 class116_28;

		// Token: 0x040042AB RID: 17067
		[AccessedThroughProperty("Label44")]
		[CompilerGenerated]
		private Class116 class116_29;

		// Token: 0x040042AC RID: 17068
		[CompilerGenerated]
		[AccessedThroughProperty("Label42")]
		private Class116 class116_30;

		// Token: 0x040042AD RID: 17069
		[AccessedThroughProperty("Combo_WithdrawDamageThreshold")]
		[CompilerGenerated]
		private Class2451 class2451_24;

		// Token: 0x040042AE RID: 17070
		[CompilerGenerated]
		[AccessedThroughProperty("Label41")]
		private Class116 class116_31;

		// Token: 0x040042AF RID: 17071
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_RedeployDefenceThreshold")]
		private Class2451 class2451_25;

		// Token: 0x040042B0 RID: 17072
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_RedeployAttackThreshold")]
		private Class2451 class2451_26;

		// Token: 0x040042B1 RID: 17073
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_RedeployFuelThreshold")]
		private Class2451 class2451_27;

		// Token: 0x040042B2 RID: 17074
		[AccessedThroughProperty("Label46")]
		[CompilerGenerated]
		private Class116 class116_32;

		// Token: 0x040042B3 RID: 17075
		[CompilerGenerated]
		[AccessedThroughProperty("Label47")]
		private Class116 class116_33;

		// Token: 0x040042B4 RID: 17076
		[CompilerGenerated]
		[AccessedThroughProperty("Label48")]
		private Class116 class116_34;

		// Token: 0x040042B5 RID: 17077
		[CompilerGenerated]
		[AccessedThroughProperty("Label49")]
		private Class116 class116_35;

		// Token: 0x040042B6 RID: 17078
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_RedeployDamageThreshold")]
		private Class2451 class2451_28;

		// Token: 0x040042B7 RID: 17079
		[CompilerGenerated]
		[AccessedThroughProperty("Label50")]
		private Class116 class116_36;

		// Token: 0x040042B8 RID: 17080
		[CompilerGenerated]
		[AccessedThroughProperty("TargetType")]
		private Class44 class44_0;

		// Token: 0x040042B9 RID: 17081
		[CompilerGenerated]
		[AccessedThroughProperty("WeaponsPerSalvo")]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		// Token: 0x040042BA RID: 17082
		[AccessedThroughProperty("ShootersPerSalvo")]
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;

		// Token: 0x040042BB RID: 17083
		[AccessedThroughProperty("FiringRange")]
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;

		// Token: 0x040042BC RID: 17084
		[CompilerGenerated]
		[AccessedThroughProperty("SelfDefenceRange")]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_3;

		// Token: 0x040042BD RID: 17085
		[CompilerGenerated]
		[AccessedThroughProperty("Label51")]
		private Class116 class116_37;

		// Token: 0x040042BE RID: 17086
		[AccessedThroughProperty("CB_ReplenishmentSelection_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_19;

		// Token: 0x040042BF RID: 17087
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_ReplenishmentSelection")]
		private Class2451 class2451_29;

		// Token: 0x040042C0 RID: 17088
		[CompilerGenerated]
		[AccessedThroughProperty("Label28")]
		private Class116 class116_38;

		// Token: 0x040042C1 RID: 17089
		[CompilerGenerated]
		[AccessedThroughProperty("Label29")]
		private Class116 class116_39;

		// Token: 0x040042C2 RID: 17090
		[CompilerGenerated]
		[AccessedThroughProperty("Label30")]
		private Class116 class116_40;

		// Token: 0x040042C3 RID: 17091
		[AccessedThroughProperty("CB_FuelState_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_20;

		// Token: 0x040042C4 RID: 17092
		[CompilerGenerated]
		[AccessedThroughProperty("CB_WeaponState_PlayerEditable")]
		private Class112 class112_21;

		// Token: 0x040042C5 RID: 17093
		[CompilerGenerated]
		[AccessedThroughProperty("Label31")]
		private Class116 class116_41;

		// Token: 0x040042C6 RID: 17094
		[CompilerGenerated]
		[AccessedThroughProperty("CB_JettisonOrdnance_PlayerEditable")]
		private Class112 class112_22;

		// Token: 0x040042C7 RID: 17095
		[CompilerGenerated]
		[AccessedThroughProperty("CB_FuelStateRTB_PlayerEditable")]
		private Class112 class112_23;

		// Token: 0x040042C8 RID: 17096
		[CompilerGenerated]
		[AccessedThroughProperty("Label32")]
		private Class116 class116_42;

		// Token: 0x040042C9 RID: 17097
		[CompilerGenerated]
		[AccessedThroughProperty("Label33")]
		private Class116 class116_43;

		// Token: 0x040042CA RID: 17098
		[AccessedThroughProperty("Label34")]
		[CompilerGenerated]
		private Class116 class116_44;

		// Token: 0x040042CB RID: 17099
		[AccessedThroughProperty("CB_RefuelAllies_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_24;

		// Token: 0x040042CC RID: 17100
		[AccessedThroughProperty("Label35")]
		[CompilerGenerated]
		private Class116 class116_45;

		// Token: 0x040042CD RID: 17101
		[AccessedThroughProperty("Label36")]
		[CompilerGenerated]
		private Class116 class116_46;

		// Token: 0x040042CE RID: 17102
		[CompilerGenerated]
		[AccessedThroughProperty("CB_AvoidContact_PlayerEditable")]
		private Class112 class112_25;

		// Token: 0x040042CF RID: 17103
		[CompilerGenerated]
		[AccessedThroughProperty("CB_DiveWhenThreatsDetected_PlayerEditable")]
		private Class112 class112_26;

		// Token: 0x040042D0 RID: 17104
		[AccessedThroughProperty("Label37")]
		[CompilerGenerated]
		private Class116 class116_47;

		// Token: 0x040042D1 RID: 17105
		[CompilerGenerated]
		[AccessedThroughProperty("CB_BatteryRechargePatrol_PlayerEditable")]
		private Class112 class112_27;

		// Token: 0x040042D2 RID: 17106
		[AccessedThroughProperty("Label38")]
		[CompilerGenerated]
		private Class116 class116_48;

		// Token: 0x040042D3 RID: 17107
		[CompilerGenerated]
		[AccessedThroughProperty("CB_BatteryRechargeAttack_PlayerEditable")]
		private Class112 class112_28;

		// Token: 0x040042D4 RID: 17108
		[CompilerGenerated]
		[AccessedThroughProperty("Label39")]
		private Class116 class116_49;

		// Token: 0x040042D5 RID: 17109
		[AccessedThroughProperty("CB_AIP_Usage_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_29;

		// Token: 0x040042D6 RID: 17110
		[AccessedThroughProperty("Label40")]
		[CompilerGenerated]
		private Class116 class116_50;

		// Token: 0x040042D7 RID: 17111
		[AccessedThroughProperty("CB_DippingSonar_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_30;

		// Token: 0x040042D8 RID: 17112
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_FuelState")]
		private Class2451 class2451_30;

		// Token: 0x040042D9 RID: 17113
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_WeaponState")]
		private Class2451 class2451_31;

		// Token: 0x040042DA RID: 17114
		[AccessedThroughProperty("Combo_Jettison")]
		[CompilerGenerated]
		private Class2451 class2451_32;

		// Token: 0x040042DB RID: 17115
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_FuelStateRTB")]
		private Class2451 class2451_33;

		// Token: 0x040042DC RID: 17116
		[AccessedThroughProperty("Combo_RefuelAllies")]
		[CompilerGenerated]
		private Class2451 class2451_34;

		// Token: 0x040042DD RID: 17117
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_AvoidContact")]
		private Class2451 class2451_35;

		// Token: 0x040042DE RID: 17118
		[AccessedThroughProperty("Combo_DiveWhenThreatsDetected")]
		[CompilerGenerated]
		private Class2451 class2451_36;

		// Token: 0x040042DF RID: 17119
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_BatteryRechargePatrol")]
		private Class2451 class2451_37;

		// Token: 0x040042E0 RID: 17120
		[AccessedThroughProperty("Combo_BatteryRechargeAttack")]
		[CompilerGenerated]
		private Class2451 class2451_38;

		// Token: 0x040042E1 RID: 17121
		[AccessedThroughProperty("Combo_AIP_Usage")]
		[CompilerGenerated]
		private Class2451 class2451_39;

		// Token: 0x040042E2 RID: 17122
		[AccessedThroughProperty("Combo_DippingSonar")]
		[CompilerGenerated]
		private Class2451 class2451_40;

		// Token: 0x040042E3 RID: 17123
		[AccessedThroughProperty("Label52")]
		[CompilerGenerated]
		private Class116 class116_51;

		// Token: 0x040042E4 RID: 17124
		[AccessedThroughProperty("CB_BVRLogic_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_31;

		// Token: 0x040042E5 RID: 17125
		[AccessedThroughProperty("Combo_BVRLogic")]
		[CompilerGenerated]
		private Class2451 class2451_41;

		// Token: 0x040042E6 RID: 17126
		[CompilerGenerated]
		[AccessedThroughProperty("DarkLabel1")]
		private Class116 class116_52;

		// Token: 0x040042E7 RID: 17127
		[AccessedThroughProperty("DarkLabel2")]
		[CompilerGenerated]
		private Class116 class116_53;

		// Token: 0x040042E8 RID: 17128
		[CompilerGenerated]
		[AccessedThroughProperty("DarkLabel3")]
		private Class116 class116_54;

		// Token: 0x040042E9 RID: 17129
		[AccessedThroughProperty("DarkLabel4")]
		[CompilerGenerated]
		private Class116 class116_55;

		// Token: 0x040042EA RID: 17130
		[AccessedThroughProperty("CB_Surface_Navigation_PlayerEditable")]
		[CompilerGenerated]
		private Class112 class112_32;

		// Token: 0x040042EB RID: 17131
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Submarine_Navigation_PlayerEditable")]
		private Class112 class112_33;

		// Token: 0x040042EC RID: 17132
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Land_Navigation_PlayerEditable")]
		private Class112 class112_34;

		// Token: 0x040042ED RID: 17133
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_Surface_Navigation")]
		private Class2451 class2451_42;

		// Token: 0x040042EE RID: 17134
		[AccessedThroughProperty("Combo_Submarine_Navigation")]
		[CompilerGenerated]
		private Class2451 class2451_43;

		// Token: 0x040042EF RID: 17135
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_Land_Navigation")]
		private Class2451 class2451_44;

		// Token: 0x040042F0 RID: 17136
		public Class310 class310_0;

		// Token: 0x040042F1 RID: 17137
		public List<ActiveUnit> list_0;

		// Token: 0x040042F2 RID: 17138
		public bool bool_3;

		// Token: 0x040042F3 RID: 17139
		private Doctrine doctrine_0;

		// Token: 0x040042F4 RID: 17140
		private Dictionary<int, Doctrine.WRA_Weapon> dictionary_0;

		// Token: 0x040042F5 RID: 17141
		private List<int> list_1;

		// Token: 0x040042F6 RID: 17142
		private int int_0;

		// Token: 0x040042F7 RID: 17143
		private int int_1;

		// Token: 0x040042F8 RID: 17144
		private int int_2;

		// Token: 0x040042F9 RID: 17145
		private int int_3;

		// Token: 0x040042FA RID: 17146
		private int int_4;

		// Token: 0x040042FB RID: 17147
		private int int_5;

		// Token: 0x040042FC RID: 17148
		private int int_6;

		// Token: 0x040042FD RID: 17149
		private int int_7;

		// Token: 0x040042FE RID: 17150
		private int int_8;

		// Token: 0x040042FF RID: 17151
		private int int_9;

		// Token: 0x04004300 RID: 17152
		private int int_10;

		// Token: 0x04004301 RID: 17153
		private int int_11;

		// Token: 0x04004302 RID: 17154
		private int int_12;

		// Token: 0x04004303 RID: 17155
		private int int_13;

		// Token: 0x04004304 RID: 17156
		private int int_14;

		// Token: 0x04004305 RID: 17157
		private int int_15;

		// Token: 0x04004306 RID: 17158
		private int int_16;

		// Token: 0x04004307 RID: 17159
		private int int_17;

		// Token: 0x04004308 RID: 17160
		private int int_18;

		// Token: 0x04004309 RID: 17161
		private int int_19;

		// Token: 0x0400430A RID: 17162
		private int int_20;

		// Token: 0x0400430B RID: 17163
		private int int_21;

		// Token: 0x0400430C RID: 17164
		private int int_22;

		// Token: 0x0400430D RID: 17165
		private int int_23;

		// Token: 0x0400430E RID: 17166
		private int int_24;

		// Token: 0x0400430F RID: 17167
		private int int_25;

		// Token: 0x04004310 RID: 17168
		private int int_26;

		// Token: 0x04004311 RID: 17169
		private int int_27;

		// Token: 0x04004312 RID: 17170
		private int int_28;

		// Token: 0x04004313 RID: 17171
		private int int_29;

		// Token: 0x04004314 RID: 17172
		private int int_30;

		// Token: 0x04004315 RID: 17173
		private int int_31;

		// Token: 0x04004316 RID: 17174
		private int int_32;

		// Token: 0x04004317 RID: 17175
		private int int_33;

		// Token: 0x04004318 RID: 17176
		private int int_34;

		// Token: 0x04004319 RID: 17177
		private int int_35;

		// Token: 0x0400431A RID: 17178
		private int int_36;

		// Token: 0x0400431B RID: 17179
		private int int_37;

		// Token: 0x0400431C RID: 17180
		private int int_38;

		// Token: 0x0400431D RID: 17181
		private int int_39;

		// Token: 0x0400431E RID: 17182
		private int int_40;

		// Token: 0x0400431F RID: 17183
		private int int_41;

		// Token: 0x04004320 RID: 17184
		private Doctrine.Enum65? nullable_0;

		// Token: 0x04004321 RID: 17185
		private Doctrine.Enum52? nullable_1;

		// Token: 0x04004322 RID: 17186
		private Doctrine.Enum52? nullable_2;

		// Token: 0x04004323 RID: 17187
		private Doctrine.Enum52? nullable_3;

		// Token: 0x04004324 RID: 17188
		private Doctrine.Enum52? nullable_4;

		// Token: 0x04004325 RID: 17189
		private Doctrine.Enum64? nullable_5;

		// Token: 0x04004326 RID: 17190
		private Doctrine._WeaponStateRTB? nullable_6;

		// Token: 0x04004327 RID: 17191
		private Doctrine._FuelStateRTB? nullable_7;

		// Token: 0x04004328 RID: 17192
		private Doctrine._JettisonOrdnance? nullable_8;

		// Token: 0x04004329 RID: 17193
		private Doctrine._BVRLogicEnum? nullable_9;

		// Token: 0x0400432A RID: 17194
		private Doctrine.Enum51? nullable_10;

		// Token: 0x0400432B RID: 17195
		private Doctrine.Enum61? nullable_11;

		// Token: 0x0400432C RID: 17196
		private Doctrine.Enum62? nullable_12;

		// Token: 0x0400432D RID: 17197
		private Doctrine.Enum56? nullable_13;

		// Token: 0x0400432E RID: 17198
		private Doctrine.Enum57? nullable_14;

		// Token: 0x0400432F RID: 17199
		private Doctrine.Enum59? nullable_15;

		// Token: 0x04004330 RID: 17200
		private Doctrine.Enum58? nullable_16;

		// Token: 0x04004331 RID: 17201
		private Doctrine.Enum60? nullable_17;

		// Token: 0x04004332 RID: 17202
		private Doctrine.Enum53? nullable_18;

		// Token: 0x04004333 RID: 17203
		private Doctrine.Enum54? nullable_19;

		// Token: 0x04004334 RID: 17204
		private Doctrine._FuelState? nullable_20;

		// Token: 0x04004335 RID: 17205
		private Doctrine._WeaponState? nullable_21;

		// Token: 0x04004336 RID: 17206
		private Doctrine.Enum55? nullable_22;

		// Token: 0x04004337 RID: 17207
		private Doctrine.Class275.Enum66 enum66_0;

		// Token: 0x04004338 RID: 17208
		private Doctrine.Class275.Enum66 enum66_1;

		// Token: 0x04004339 RID: 17209
		private Doctrine.Class275.Enum66 enum66_2;

		// Token: 0x0400433A RID: 17210
		private Doctrine._GunStrafeGroundTargets? nullable_23;

		// Token: 0x0400433B RID: 17211
		private Doctrine._RefuelAlliedUnits? nullable_24;

		// Token: 0x0400433C RID: 17212
		private Doctrine._AvoidContactWhenPossible? nullable_25;

		// Token: 0x0400433D RID: 17213
		private Doctrine._DiveOnContact? nullable_26;

		// Token: 0x0400433E RID: 17214
		private Doctrine._RechargeBatteryPercentage? nullable_27;

		// Token: 0x0400433F RID: 17215
		private Doctrine._RechargeBatteryPercentage? nullable_28;

		// Token: 0x04004340 RID: 17216
		private Doctrine._UseAIP? nullable_29;

		// Token: 0x04004341 RID: 17217
		private Doctrine._UseDippingSonar? nullable_30;

		// Token: 0x04004342 RID: 17218
		private Doctrine.Enum63? nullable_31;

		// Token: 0x04004343 RID: 17219
		private Doctrine.Enum63? nullable_32;

		// Token: 0x04004344 RID: 17220
		private Doctrine.Enum63? nullable_33;

		// Token: 0x04004345 RID: 17221
		private Doctrine._DamageThreshold? nullable_34;

		// Token: 0x04004346 RID: 17222
		private Doctrine._FuelQuantityThreshold? nullable_35;

		// Token: 0x04004347 RID: 17223
		private Doctrine._WeaponQuantityThreshold? nullable_36;

		// Token: 0x04004348 RID: 17224
		private Doctrine._WeaponQuantityThreshold? nullable_37;

		// Token: 0x04004349 RID: 17225
		private Doctrine._DamageThreshold? nullable_38;

		// Token: 0x0400434A RID: 17226
		private Doctrine._FuelQuantityThreshold? nullable_39;

		// Token: 0x0400434B RID: 17227
		private Doctrine._WeaponQuantityThreshold? nullable_40;

		// Token: 0x0400434C RID: 17228
		private Doctrine._WeaponQuantityThreshold? nullable_41;

		// Token: 0x0400434D RID: 17229
		private bool bool_4;

		// Token: 0x0400434E RID: 17230
		private bool bool_5;

		// Token: 0x0400434F RID: 17231
		public bool bool_6;

		// Token: 0x04004350 RID: 17232
		public bool bool_7;

		// Token: 0x04004351 RID: 17233
		public bool bool_8;
	}
}
