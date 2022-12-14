using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns4;
using ns6;
using ns7;

namespace ns5
{
	// Token: 0x02000D60 RID: 3424
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[StandardModule]
	internal sealed class Class2413
	{
		// Token: 0x0600599B RID: 22939 RVA: 0x00039AC5 File Offset: 0x00037CC5
		internal static Class2412 smethod_0()
		{
			return Class2413.class2416_0.method_0();
		}

		// Token: 0x0600599C RID: 22940 RVA: 0x00039AD1 File Offset: 0x00037CD1
		internal static Form3 smethod_1()
		{
			return Class2413.class2416_1.method_0();
		}

		// Token: 0x0600599D RID: 22941 RVA: 0x00039ADD File Offset: 0x00037CDD
		internal static Class2413.Class2414 smethod_2()
		{
			return Class2413.class2416_3.method_0();
		}

		// Token: 0x04003418 RID: 13336
		private static readonly Class2413.Class2416<Class2412> class2416_0 = new Class2413.Class2416<Class2412>();

		// Token: 0x04003419 RID: 13337
		private static readonly Class2413.Class2416<Form3> class2416_1 = new Class2413.Class2416<Form3>();

		// Token: 0x0400341A RID: 13338
		private static readonly Class2413.Class2416<User> class2416_2 = new Class2413.Class2416<User>();

		// Token: 0x0400341B RID: 13339
		private static Class2413.Class2416<Class2413.Class2414> class2416_3 = new Class2413.Class2416<Class2413.Class2414>();

		// Token: 0x0400341C RID: 13340
		private static readonly Class2413.Class2416<Class2413.Class2415> class2416_4 = new Class2413.Class2416<Class2413.Class2415>();

		// Token: 0x02000D61 RID: 3425
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class Class2414
		{
			// Token: 0x0600599E RID: 22942 RVA: 0x003167D4 File Offset: 0x003149D4
			private static T smethod_0<T>(T gparam_0) where T : Form, new()
			{
				T result;
				if (gparam_0 != null && !gparam_0.IsDisposed)
				{
					result = gparam_0;
				}
				else
				{
					if (Class2413.Class2414.hashtable_0 != null)
					{
						if (Class2413.Class2414.hashtable_0.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						Class2413.Class2414.hashtable_0 = new Hashtable();
					}
					Class2413.Class2414.hashtable_0.Add(typeof(T), null);
					try
					{
						result = Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						}), ex.InnerException);
					}
					finally
					{
						Class2413.Class2414.hashtable_0.Remove(typeof(T));
					}
				}
				return result;
			}

			// Token: 0x0600599F RID: 22943 RVA: 0x00002977 File Offset: 0x00000B77
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Class2414()
			{
			}

			// Token: 0x060059A0 RID: 22944 RVA: 0x00006E33 File Offset: 0x00005033
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object obj)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(obj));
			}

			// Token: 0x060059A1 RID: 22945 RVA: 0x00006E41 File Offset: 0x00005041
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x060059A2 RID: 22946 RVA: 0x00006E49 File Offset: 0x00005049
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x060059A3 RID: 22947 RVA: 0x00039AE9 File Offset: 0x00037CE9
			public AboutBox1 method_0()
			{
				this.aboutBox1_0 = Class2413.Class2414.smethod_0<AboutBox1>(this.aboutBox1_0);
				return this.aboutBox1_0;
			}

			// Token: 0x060059A4 RID: 22948 RVA: 0x00039B02 File Offset: 0x00037D02
			public AddMagazine method_1()
			{
				this.addMagazine_0 = Class2413.Class2414.smethod_0<AddMagazine>(this.addMagazine_0);
				return this.addMagazine_0;
			}

			// Token: 0x060059A5 RID: 22949 RVA: 0x00039B1B File Offset: 0x00037D1B
			public AddMount method_2()
			{
				this.addMount_0 = Class2413.Class2414.smethod_0<AddMount>(this.addMount_0);
				return this.addMount_0;
			}

			// Token: 0x060059A6 RID: 22950 RVA: 0x00039B34 File Offset: 0x00037D34
			public AddSensor method_3()
			{
				this.addSensor_0 = Class2413.Class2414.smethod_0<AddSensor>(this.addSensor_0);
				return this.addSensor_0;
			}

			// Token: 0x060059A7 RID: 22951 RVA: 0x00039B4D File Offset: 0x00037D4D
			public AddSide method_4()
			{
				this.addSide_0 = Class2413.Class2414.smethod_0<AddSide>(this.addSide_0);
				return this.addSide_0;
			}

			// Token: 0x060059A8 RID: 22952 RVA: 0x00039B66 File Offset: 0x00037D66
			public AddUnit method_5()
			{
				this.addUnit_0 = Class2413.Class2414.smethod_0<AddUnit>(this.addUnit_0);
				return this.addUnit_0;
			}

			// Token: 0x060059A9 RID: 22953 RVA: 0x00039B7F File Offset: 0x00037D7F
			public AddWeaponRecord method_6()
			{
				this.addWeaponRecord_0 = Class2413.Class2414.smethod_0<AddWeaponRecord>(this.addWeaponRecord_0);
				return this.addWeaponRecord_0;
			}

			// Token: 0x060059AA RID: 22954 RVA: 0x00039B98 File Offset: 0x00037D98
			public AirOps method_7()
			{
				this.airOps_0 = Class2413.Class2414.smethod_0<AirOps>(this.airOps_0);
				return this.airOps_0;
			}

			// Token: 0x060059AB RID: 22955 RVA: 0x00039BB1 File Offset: 0x00037DB1
			public BrowseScenarioPlatforms method_8()
			{
				this.browseScenarioPlatforms_0 = Class2413.Class2414.smethod_0<BrowseScenarioPlatforms>(this.browseScenarioPlatforms_0);
				return this.browseScenarioPlatforms_0;
			}

			// Token: 0x060059AC RID: 22956 RVA: 0x00039BCA File Offset: 0x00037DCA
			public CampaignEnd method_9()
			{
				this.campaignEnd_0 = Class2413.Class2414.smethod_0<CampaignEnd>(this.campaignEnd_0);
				return this.campaignEnd_0;
			}

			// Token: 0x060059AD RID: 22957 RVA: 0x00039BE3 File Offset: 0x00037DE3
			public CampaignPlayWindow method_10()
			{
				this.campaignPlayWindow_0 = Class2413.Class2414.smethod_0<CampaignPlayWindow>(this.campaignPlayWindow_0);
				return this.campaignPlayWindow_0;
			}

			// Token: 0x060059AE RID: 22958 RVA: 0x00039BFC File Offset: 0x00037DFC
			public CampaignScenarioWindow method_11()
			{
				this.campaignScenarioWindow_0 = Class2413.Class2414.smethod_0<CampaignScenarioWindow>(this.campaignScenarioWindow_0);
				return this.campaignScenarioWindow_0;
			}

			// Token: 0x060059AF RID: 22959 RVA: 0x00039C15 File Offset: 0x00037E15
			public CargoOps method_12()
			{
				this.cargoOps_0 = Class2413.Class2414.smethod_0<CargoOps>(this.cargoOps_0);
				return this.cargoOps_0;
			}

			// Token: 0x060059B0 RID: 22960 RVA: 0x00039C2E File Offset: 0x00037E2E
			public ChooseSide method_13()
			{
				this.chooseSide_0 = Class2413.Class2414.smethod_0<ChooseSide>(this.chooseSide_0);
				return this.chooseSide_0;
			}

			// Token: 0x060059B1 RID: 22961 RVA: 0x00039C47 File Offset: 0x00037E47
			public ConsoleWindow2 method_14()
			{
				this.consoleWindow2_0 = Class2413.Class2414.smethod_0<ConsoleWindow2>(this.consoleWindow2_0);
				return this.consoleWindow2_0;
			}

			// Token: 0x060059B2 RID: 22962 RVA: 0x00039C60 File Offset: 0x00037E60
			public ContactReport method_15()
			{
				this.contactReport_0 = Class2413.Class2414.smethod_0<ContactReport>(this.contactReport_0);
				return this.contactReport_0;
			}

			// Token: 0x060059B3 RID: 22963 RVA: 0x00039C79 File Offset: 0x00037E79
			public CustomLayersForm method_16()
			{
				this.customLayersForm_0 = Class2413.Class2414.smethod_0<CustomLayersForm>(this.customLayersForm_0);
				return this.customLayersForm_0;
			}

			// Token: 0x060059B4 RID: 22964 RVA: 0x00039C92 File Offset: 0x00037E92
			public DebugForm method_17()
			{
				this.debugForm_0 = Class2413.Class2414.smethod_0<DebugForm>(this.debugForm_0);
				return this.debugForm_0;
			}

			// Token: 0x060059B5 RID: 22965 RVA: 0x00039CAB File Offset: 0x00037EAB
			public DockingOps method_18()
			{
				this.dockingOps_0 = Class2413.Class2414.smethod_0<DockingOps>(this.dockingOps_0);
				return this.dockingOps_0;
			}

			// Token: 0x060059B6 RID: 22966 RVA: 0x00039CC4 File Offset: 0x00037EC4
			public EditAC method_19()
			{
				this.editAC_0 = Class2413.Class2414.smethod_0<EditAC>(this.editAC_0);
				return this.editAC_0;
			}

			// Token: 0x060059B7 RID: 22967 RVA: 0x00039CDD File Offset: 0x00037EDD
			public EditBoats method_20()
			{
				this.editBoats_0 = Class2413.Class2414.smethod_0<EditBoats>(this.editBoats_0);
				return this.editBoats_0;
			}

			// Token: 0x060059B8 RID: 22968 RVA: 0x00039CF6 File Offset: 0x00037EF6
			public EditBriefing method_21()
			{
				this.editBriefing_0 = Class2413.Class2414.smethod_0<EditBriefing>(this.editBriefing_0);
				return this.editBriefing_0;
			}

			// Token: 0x060059B9 RID: 22969 RVA: 0x00039D0F File Offset: 0x00037F0F
			public EditCargo method_22()
			{
				this.editCargo_0 = Class2413.Class2414.smethod_0<EditCargo>(this.editCargo_0);
				return this.editCargo_0;
			}

			// Token: 0x060059BA RID: 22970 RVA: 0x00039D28 File Offset: 0x00037F28
			public EditEvent method_23()
			{
				this.editEvent_0 = Class2413.Class2414.smethod_0<EditEvent>(this.editEvent_0);
				return this.editEvent_0;
			}

			// Token: 0x060059BB RID: 22971 RVA: 0x00039D41 File Offset: 0x00037F41
			public EditWeather method_24()
			{
				this.editWeather_0 = Class2413.Class2414.smethod_0<EditWeather>(this.editWeather_0);
				return this.editWeather_0;
			}

			// Token: 0x060059BC RID: 22972 RVA: 0x00039D5A File Offset: 0x00037F5A
			public Evaluation method_25()
			{
				this.evaluation_0 = Class2413.Class2414.smethod_0<Evaluation>(this.evaluation_0);
				return this.evaluation_0;
			}

			// Token: 0x060059BD RID: 22973 RVA: 0x00039D73 File Offset: 0x00037F73
			public Form_QuickTurnaround method_26()
			{
				this.form_QuickTurnaround_0 = Class2413.Class2414.smethod_0<Form_QuickTurnaround>(this.form_QuickTurnaround_0);
				return this.form_QuickTurnaround_0;
			}

			// Token: 0x060059BE RID: 22974 RVA: 0x00039D8C File Offset: 0x00037F8C
			public Form_SetFuelAndAirborneTime method_27()
			{
				this.form_SetFuelAndAirborneTime_0 = Class2413.Class2414.smethod_0<Form_SetFuelAndAirborneTime>(this.form_SetFuelAndAirborneTime_0);
				return this.form_SetFuelAndAirborneTime_0;
			}

			// Token: 0x060059BF RID: 22975 RVA: 0x00039DA5 File Offset: 0x00037FA5
			public FormationEditor method_28()
			{
				this.formationEditor_0 = Class2413.Class2414.smethod_0<FormationEditor>(this.formationEditor_0);
				return this.formationEditor_0;
			}

			// Token: 0x060059C0 RID: 22976 RVA: 0x00039DBE File Offset: 0x00037FBE
			public Hotkeys method_29()
			{
				this.hotkeys_0 = Class2413.Class2414.smethod_0<Hotkeys>(this.hotkeys_0);
				return this.hotkeys_0;
			}

			// Token: 0x060059C1 RID: 22977 RVA: 0x00039DD7 File Offset: 0x00037FD7
			public InsufficientLicenseWindow method_30()
			{
				this.insufficientLicenseWindow_0 = Class2413.Class2414.smethod_0<InsufficientLicenseWindow>(this.insufficientLicenseWindow_0);
				return this.insufficientLicenseWindow_0;
			}

			// Token: 0x060059C2 RID: 22978 RVA: 0x00039DF0 File Offset: 0x00037FF0
			public InternalDBViewer method_31()
			{
				this.internalDBViewer_0 = Class2413.Class2414.smethod_0<InternalDBViewer>(this.internalDBViewer_0);
				return this.internalDBViewer_0;
			}

			// Token: 0x060059C3 RID: 22979 RVA: 0x00039E09 File Offset: 0x00038009
			public ListActions method_32()
			{
				this.listActions_0 = Class2413.Class2414.smethod_0<ListActions>(this.listActions_0);
				return this.listActions_0;
			}

			// Token: 0x060059C4 RID: 22980 RVA: 0x00039E22 File Offset: 0x00038022
			public ListConditions method_33()
			{
				this.listConditions_0 = Class2413.Class2414.smethod_0<ListConditions>(this.listConditions_0);
				return this.listConditions_0;
			}

			// Token: 0x060059C5 RID: 22981 RVA: 0x00039E3B File Offset: 0x0003803B
			public ListEvents method_34()
			{
				this.listEvents_0 = Class2413.Class2414.smethod_0<ListEvents>(this.listEvents_0);
				return this.listEvents_0;
			}

			// Token: 0x060059C6 RID: 22982 RVA: 0x00039E54 File Offset: 0x00038054
			public ListSpecialActions method_35()
			{
				this.listSpecialActions_0 = Class2413.Class2414.smethod_0<ListSpecialActions>(this.listSpecialActions_0);
				return this.listSpecialActions_0;
			}

			// Token: 0x060059C7 RID: 22983 RVA: 0x00039E6D File Offset: 0x0003806D
			public ListTriggers method_36()
			{
				this.listTriggers_0 = Class2413.Class2414.smethod_0<ListTriggers>(this.listTriggers_0);
				return this.listTriggers_0;
			}

			// Token: 0x060059C8 RID: 22984 RVA: 0x00039E86 File Offset: 0x00038086
			public LoadGroup method_37()
			{
				this.loadGroup_0 = Class2413.Class2414.smethod_0<LoadGroup>(this.loadGroup_0);
				return this.loadGroup_0;
			}

			// Token: 0x060059C9 RID: 22985 RVA: 0x00039E9F File Offset: 0x0003809F
			public LoadScenario method_38()
			{
				this.loadScenario_0 = Class2413.Class2414.smethod_0<LoadScenario>(this.loadScenario_0);
				return this.loadScenario_0;
			}

			// Token: 0x060059CA RID: 22986 RVA: 0x00039EB8 File Offset: 0x000380B8
			public Losses method_39()
			{
				this.losses_0 = Class2413.Class2414.smethod_0<Losses>(this.losses_0);
				return this.losses_0;
			}

			// Token: 0x060059CB RID: 22987 RVA: 0x00039ED1 File Offset: 0x000380D1
			public LOSTool method_40()
			{
				this.lostool_0 = Class2413.Class2414.smethod_0<LOSTool>(this.lostool_0);
				return this.lostool_0;
			}

			// Token: 0x060059CC RID: 22988 RVA: 0x00039EEA File Offset: 0x000380EA
			public MainForm method_41()
			{
				this.mainForm_0 = Class2413.Class2414.smethod_0<MainForm>(this.mainForm_0);
				return this.mainForm_0;
			}

			// Token: 0x060059CD RID: 22989 RVA: 0x00039F03 File Offset: 0x00038103
			public MainSplash method_42()
			{
				this.mainSplash_0 = Class2413.Class2414.smethod_0<MainSplash>(this.mainSplash_0);
				return this.mainSplash_0;
			}

			// Token: 0x060059CE RID: 22990 RVA: 0x00039F1C File Offset: 0x0003811C
			public MCMWindow method_43()
			{
				this.mcmwindow_0 = Class2413.Class2414.smethod_0<MCMWindow>(this.mcmwindow_0);
				return this.mcmwindow_0;
			}

			// Token: 0x060059CF RID: 22991 RVA: 0x00039F35 File Offset: 0x00038135
			public MessageLogWindow_RawText method_44()
			{
				this.messageLogWindow_RawText_0 = Class2413.Class2414.smethod_0<MessageLogWindow_RawText>(this.messageLogWindow_RawText_0);
				return this.messageLogWindow_RawText_0;
			}

			// Token: 0x060059D0 RID: 22992 RVA: 0x00039F4E File Offset: 0x0003814E
			public Migration method_45()
			{
				this.migration_0 = Class2413.Class2414.smethod_0<Migration>(this.migration_0);
				return this.migration_0;
			}

			// Token: 0x060059D1 RID: 22993 RVA: 0x00039F67 File Offset: 0x00038167
			public MultipleUnitSensors method_46()
			{
				this.multipleUnitSensors_0 = Class2413.Class2414.smethod_0<MultipleUnitSensors>(this.multipleUnitSensors_0);
				return this.multipleUnitSensors_0;
			}

			// Token: 0x060059D2 RID: 22994 RVA: 0x00039F80 File Offset: 0x00038180
			public Options method_47()
			{
				this.options_0 = Class2413.Class2414.smethod_0<Options>(this.options_0);
				return this.options_0;
			}

			// Token: 0x060059D3 RID: 22995 RVA: 0x00039F99 File Offset: 0x00038199
			public ORBAT method_48()
			{
				this.orbat_0 = Class2413.Class2414.smethod_0<ORBAT>(this.orbat_0);
				return this.orbat_0;
			}

			// Token: 0x060059D4 RID: 22996 RVA: 0x00039FB2 File Offset: 0x000381B2
			public Postures method_49()
			{
				this.postures_0 = Class2413.Class2414.smethod_0<Postures>(this.postures_0);
				return this.postures_0;
			}

			// Token: 0x060059D5 RID: 22997 RVA: 0x00039FCB File Offset: 0x000381CB
			public QuickBattle method_50()
			{
				this.quickBattle_0 = Class2413.Class2414.smethod_0<QuickBattle>(this.quickBattle_0);
				return this.quickBattle_0;
			}

			// Token: 0x060059D6 RID: 22998 RVA: 0x00039FE4 File Offset: 0x000381E4
			public ReadyAircraft method_51()
			{
				this.readyAircraft_0 = Class2413.Class2414.smethod_0<ReadyAircraft>(this.readyAircraft_0);
				return this.readyAircraft_0;
			}

			// Token: 0x060059D7 RID: 22999 RVA: 0x00039FFD File Offset: 0x000381FD
			public RealismDialog method_52()
			{
				this.realismDialog_0 = Class2413.Class2414.smethod_0<RealismDialog>(this.realismDialog_0);
				return this.realismDialog_0;
			}

			// Token: 0x060059D8 RID: 23000 RVA: 0x0003A016 File Offset: 0x00038216
			public RegressionTests method_53()
			{
				this.regressionTests_0 = Class2413.Class2414.smethod_0<RegressionTests>(this.regressionTests_0);
				return this.regressionTests_0;
			}

			// Token: 0x060059D9 RID: 23001 RVA: 0x0003A02F File Offset: 0x0003822F
			public RenameObject method_54()
			{
				this.renameObject_0 = Class2413.Class2414.smethod_0<RenameObject>(this.renameObject_0);
				return this.renameObject_0;
			}

			// Token: 0x060059DA RID: 23002 RVA: 0x0003A048 File Offset: 0x00038248
			public ResumeFromSave method_55()
			{
				this.resumeFromSave_0 = Class2413.Class2414.smethod_0<ResumeFromSave>(this.resumeFromSave_0);
				return this.resumeFromSave_0;
			}

			// Token: 0x060059DB RID: 23003 RVA: 0x0003A061 File Offset: 0x00038261
			public SatPredictionForm method_56()
			{
				this.satPredictionForm_0 = Class2413.Class2414.smethod_0<SatPredictionForm>(this.satPredictionForm_0);
				return this.satPredictionForm_0;
			}

			// Token: 0x060059DC RID: 23004 RVA: 0x0003A07A File Offset: 0x0003827A
			public SaveGroup method_57()
			{
				this.saveGroup_0 = Class2413.Class2414.smethod_0<SaveGroup>(this.saveGroup_0);
				return this.saveGroup_0;
			}

			// Token: 0x060059DD RID: 23005 RVA: 0x0003A093 File Offset: 0x00038293
			public ScenarioMerge method_58()
			{
				this.scenarioMerge_0 = Class2413.Class2414.smethod_0<ScenarioMerge>(this.scenarioMerge_0);
				return this.scenarioMerge_0;
			}

			// Token: 0x060059DE RID: 23006 RVA: 0x0003A0AC File Offset: 0x000382AC
			public ScenarioTitle method_59()
			{
				this.scenarioTitle_0 = Class2413.Class2414.smethod_0<ScenarioTitle>(this.scenarioTitle_0);
				return this.scenarioTitle_0;
			}

			// Token: 0x060059DF RID: 23007 RVA: 0x0003A0C5 File Offset: 0x000382C5
			public ScenAttachmentsWindow method_60()
			{
				this.scenAttachmentsWindow_0 = Class2413.Class2414.smethod_0<ScenAttachmentsWindow>(this.scenAttachmentsWindow_0);
				return this.scenAttachmentsWindow_0;
			}

			// Token: 0x060059E0 RID: 23008 RVA: 0x0003A0DE File Offset: 0x000382DE
			public ScoringWindow method_61()
			{
				this.scoringWindow_0 = Class2413.Class2414.smethod_0<ScoringWindow>(this.scoringWindow_0);
				return this.scoringWindow_0;
			}

			// Token: 0x060059E1 RID: 23009 RVA: 0x0003A0F7 File Offset: 0x000382F7
			public SelectLoadout method_62()
			{
				this.selectLoadout_0 = Class2413.Class2414.smethod_0<SelectLoadout>(this.selectLoadout_0);
				return this.selectLoadout_0;
			}

			// Token: 0x060059E2 RID: 23010 RVA: 0x0003A110 File Offset: 0x00038310
			public Form1 method_63()
			{
				this.form1_0 = Class2413.Class2414.smethod_0<Form1>(this.form1_0);
				return this.form1_0;
			}

			// Token: 0x060059E3 RID: 23011 RVA: 0x0003A129 File Offset: 0x00038329
			public Sides method_64()
			{
				this.sides_0 = Class2413.Class2414.smethod_0<Sides>(this.sides_0);
				return this.sides_0;
			}

			// Token: 0x060059E4 RID: 23012 RVA: 0x0003A142 File Offset: 0x00038342
			public SpecialActionsForm method_65()
			{
				this.specialActionsForm_0 = Class2413.Class2414.smethod_0<SpecialActionsForm>(this.specialActionsForm_0);
				return this.specialActionsForm_0;
			}

			// Token: 0x060059E5 RID: 23013 RVA: 0x0003A15B File Offset: 0x0003835B
			public SpeedAlt method_66()
			{
				this.speedAlt_0 = Class2413.Class2414.smethod_0<SpeedAlt>(this.speedAlt_0);
				return this.speedAlt_0;
			}

			// Token: 0x060059E6 RID: 23014 RVA: 0x0003A174 File Offset: 0x00038374
			public StartGame method_67()
			{
				this.startGame_0 = Class2413.Class2414.smethod_0<StartGame>(this.startGame_0);
				return this.startGame_0;
			}

			// Token: 0x060059E7 RID: 23015 RVA: 0x0003A18D File Offset: 0x0003838D
			public SteamPublishScenarioForm method_68()
			{
				this.steamPublishScenarioForm_0 = Class2413.Class2414.smethod_0<SteamPublishScenarioForm>(this.steamPublishScenarioForm_0);
				return this.steamPublishScenarioForm_0;
			}

			// Token: 0x060059E8 RID: 23016 RVA: 0x0003A1A6 File Offset: 0x000383A6
			public SteamUpdateScenarioForm method_69()
			{
				this.steamUpdateScenarioForm_0 = Class2413.Class2414.smethod_0<SteamUpdateScenarioForm>(this.steamUpdateScenarioForm_0);
				return this.steamUpdateScenarioForm_0;
			}

			// Token: 0x060059E9 RID: 23017 RVA: 0x0003A1BF File Offset: 0x000383BF
			public TankerPlanner method_70()
			{
				this.tankerPlanner_0 = Class2413.Class2414.smethod_0<TankerPlanner>(this.tankerPlanner_0);
				return this.tankerPlanner_0;
			}

			// Token: 0x060059EA RID: 23018 RVA: 0x0003A1D8 File Offset: 0x000383D8
			public TimesAndDuration method_71()
			{
				this.timesAndDuration_0 = Class2413.Class2414.smethod_0<TimesAndDuration>(this.timesAndDuration_0);
				return this.timesAndDuration_0;
			}

			// Token: 0x060059EB RID: 23019 RVA: 0x0003A1F1 File Offset: 0x000383F1
			public TimeToReadyWindow method_72()
			{
				this.timeToReadyWindow_0 = Class2413.Class2414.smethod_0<TimeToReadyWindow>(this.timeToReadyWindow_0);
				return this.timeToReadyWindow_0;
			}

			// Token: 0x060059EC RID: 23020 RVA: 0x0003A20A File Offset: 0x0003840A
			public TitleAndDescription method_73()
			{
				this.titleAndDescription_0 = Class2413.Class2414.smethod_0<TitleAndDescription>(this.titleAndDescription_0);
				return this.titleAndDescription_0;
			}

			// Token: 0x060059ED RID: 23021 RVA: 0x0003A223 File Offset: 0x00038423
			public UnitMessageLog method_74()
			{
				this.unitMessageLog_0 = Class2413.Class2414.smethod_0<UnitMessageLog>(this.unitMessageLog_0);
				return this.unitMessageLog_0;
			}

			// Token: 0x0400341D RID: 13341
			[ThreadStatic]
			private static Hashtable hashtable_0;

			// Token: 0x0400341E RID: 13342
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AboutBox1 aboutBox1_0;

			// Token: 0x0400341F RID: 13343
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AddMagazine addMagazine_0;

			// Token: 0x04003420 RID: 13344
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AddMount addMount_0;

			// Token: 0x04003421 RID: 13345
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AddSensor addSensor_0;

			// Token: 0x04003422 RID: 13346
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AddSide addSide_0;

			// Token: 0x04003423 RID: 13347
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AddUnit addUnit_0;

			// Token: 0x04003424 RID: 13348
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AddWeaponRecord addWeaponRecord_0;

			// Token: 0x04003425 RID: 13349
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AirOps airOps_0;

			// Token: 0x04003426 RID: 13350
			[EditorBrowsable(EditorBrowsableState.Never)]
			public BrowseScenarioPlatforms browseScenarioPlatforms_0;

			// Token: 0x04003427 RID: 13351
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CampaignEnd campaignEnd_0;

			// Token: 0x04003428 RID: 13352
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CampaignPlayWindow campaignPlayWindow_0;

			// Token: 0x04003429 RID: 13353
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CampaignScenarioWindow campaignScenarioWindow_0;

			// Token: 0x0400342A RID: 13354
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CargoOps cargoOps_0;

			// Token: 0x0400342B RID: 13355
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ChooseSide chooseSide_0;

			// Token: 0x0400342C RID: 13356
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ConsoleWindow2 consoleWindow2_0;

			// Token: 0x0400342D RID: 13357
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ContactReport contactReport_0;

			// Token: 0x0400342E RID: 13358
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CustomLayersForm customLayersForm_0;

			// Token: 0x0400342F RID: 13359
			[EditorBrowsable(EditorBrowsableState.Never)]
			public DebugForm debugForm_0;

			// Token: 0x04003430 RID: 13360
			[EditorBrowsable(EditorBrowsableState.Never)]
			public DockingOps dockingOps_0;

			// Token: 0x04003431 RID: 13361
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditAC editAC_0;

			// Token: 0x04003432 RID: 13362
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditBoats editBoats_0;

			// Token: 0x04003433 RID: 13363
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditBriefing editBriefing_0;

			// Token: 0x04003434 RID: 13364
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditCargo editCargo_0;

			// Token: 0x04003435 RID: 13365
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditEvent editEvent_0;

			// Token: 0x04003436 RID: 13366
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditWeather editWeather_0;

			// Token: 0x04003437 RID: 13367
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Evaluation evaluation_0;

			// Token: 0x04003438 RID: 13368
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Form_QuickTurnaround form_QuickTurnaround_0;

			// Token: 0x04003439 RID: 13369
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Form_SetFuelAndAirborneTime form_SetFuelAndAirborneTime_0;

			// Token: 0x0400343A RID: 13370
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FormationEditor formationEditor_0;

			// Token: 0x0400343B RID: 13371
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Hotkeys hotkeys_0;

			// Token: 0x0400343C RID: 13372
			[EditorBrowsable(EditorBrowsableState.Never)]
			public InsufficientLicenseWindow insufficientLicenseWindow_0;

			// Token: 0x0400343D RID: 13373
			[EditorBrowsable(EditorBrowsableState.Never)]
			public InternalDBViewer internalDBViewer_0;

			// Token: 0x0400343E RID: 13374
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ListActions listActions_0;

			// Token: 0x0400343F RID: 13375
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ListConditions listConditions_0;

			// Token: 0x04003440 RID: 13376
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ListEvents listEvents_0;

			// Token: 0x04003441 RID: 13377
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ListSpecialActions listSpecialActions_0;

			// Token: 0x04003442 RID: 13378
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ListTriggers listTriggers_0;

			// Token: 0x04003443 RID: 13379
			[EditorBrowsable(EditorBrowsableState.Never)]
			public LoadGroup loadGroup_0;

			// Token: 0x04003444 RID: 13380
			[EditorBrowsable(EditorBrowsableState.Never)]
			public LoadScenario loadScenario_0;

			// Token: 0x04003445 RID: 13381
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Losses losses_0;

			// Token: 0x04003446 RID: 13382
			[EditorBrowsable(EditorBrowsableState.Never)]
			public LOSTool lostool_0;

			// Token: 0x04003447 RID: 13383
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MainForm mainForm_0;

			// Token: 0x04003448 RID: 13384
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MainSplash mainSplash_0;

			// Token: 0x04003449 RID: 13385
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MCMWindow mcmwindow_0;

			// Token: 0x0400344A RID: 13386
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MessageLogWindow_RawText messageLogWindow_RawText_0;

			// Token: 0x0400344B RID: 13387
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Migration migration_0;

			// Token: 0x0400344C RID: 13388
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MultipleUnitSensors multipleUnitSensors_0;

			// Token: 0x0400344D RID: 13389
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Options options_0;

			// Token: 0x0400344E RID: 13390
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ORBAT orbat_0;

			// Token: 0x0400344F RID: 13391
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Postures postures_0;

			// Token: 0x04003450 RID: 13392
			[EditorBrowsable(EditorBrowsableState.Never)]
			public QuickBattle quickBattle_0;

			// Token: 0x04003451 RID: 13393
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ReadyAircraft readyAircraft_0;

			// Token: 0x04003452 RID: 13394
			[EditorBrowsable(EditorBrowsableState.Never)]
			public RealismDialog realismDialog_0;

			// Token: 0x04003453 RID: 13395
			[EditorBrowsable(EditorBrowsableState.Never)]
			public RegressionTests regressionTests_0;

			// Token: 0x04003454 RID: 13396
			[EditorBrowsable(EditorBrowsableState.Never)]
			public RenameObject renameObject_0;

			// Token: 0x04003455 RID: 13397
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ResumeFromSave resumeFromSave_0;

			// Token: 0x04003456 RID: 13398
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SatPredictionForm satPredictionForm_0;

			// Token: 0x04003457 RID: 13399
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SaveGroup saveGroup_0;

			// Token: 0x04003458 RID: 13400
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ScenarioMerge scenarioMerge_0;

			// Token: 0x04003459 RID: 13401
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ScenarioTitle scenarioTitle_0;

			// Token: 0x0400345A RID: 13402
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ScenAttachmentsWindow scenAttachmentsWindow_0;

			// Token: 0x0400345B RID: 13403
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ScoringWindow scoringWindow_0;

			// Token: 0x0400345C RID: 13404
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SelectLoadout selectLoadout_0;

			// Token: 0x0400345D RID: 13405
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Form1 form1_0;

			// Token: 0x0400345E RID: 13406
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Sides sides_0;

			// Token: 0x0400345F RID: 13407
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SpecialActionsForm specialActionsForm_0;

			// Token: 0x04003460 RID: 13408
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SpeedAlt speedAlt_0;

			// Token: 0x04003461 RID: 13409
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StartGame startGame_0;

			// Token: 0x04003462 RID: 13410
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SteamPublishScenarioForm steamPublishScenarioForm_0;

			// Token: 0x04003463 RID: 13411
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SteamUpdateScenarioForm steamUpdateScenarioForm_0;

			// Token: 0x04003464 RID: 13412
			[EditorBrowsable(EditorBrowsableState.Never)]
			public TankerPlanner tankerPlanner_0;

			// Token: 0x04003465 RID: 13413
			[EditorBrowsable(EditorBrowsableState.Never)]
			public TimesAndDuration timesAndDuration_0;

			// Token: 0x04003466 RID: 13414
			[EditorBrowsable(EditorBrowsableState.Never)]
			public TimeToReadyWindow timeToReadyWindow_0;

			// Token: 0x04003467 RID: 13415
			[EditorBrowsable(EditorBrowsableState.Never)]
			public TitleAndDescription titleAndDescription_0;

			// Token: 0x04003468 RID: 13416
			[EditorBrowsable(EditorBrowsableState.Never)]
			public UnitMessageLog unitMessageLog_0;
		}

		// Token: 0x02000D62 RID: 3426
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class Class2415
		{
			// Token: 0x060059EE RID: 23022 RVA: 0x00006E33 File Offset: 0x00005033
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object obj)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(obj));
			}

			// Token: 0x060059EF RID: 23023 RVA: 0x00006E41 File Offset: 0x00005041
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x060059F0 RID: 23024 RVA: 0x00006E49 File Offset: 0x00005049
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x060059F1 RID: 23025 RVA: 0x00002977 File Offset: 0x00000B77
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Class2415()
			{
			}
		}

		// Token: 0x02000D63 RID: 3427
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class Class2416<T> where T : new()
		{
			// Token: 0x060059F2 RID: 23026 RVA: 0x0003A23C File Offset: 0x0003843C
			internal T method_0()
			{
				if (Class2413.Class2416<T>.gparam_0 == null)
				{
					Class2413.Class2416<T>.gparam_0 = Activator.CreateInstance<T>();
				}
				return Class2413.Class2416<T>.gparam_0;
			}

			// Token: 0x060059F3 RID: 23027 RVA: 0x00002977 File Offset: 0x00000B77
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Class2416()
			{
			}

			// Token: 0x04003469 RID: 13417
			[CompilerGenerated]
			[ThreadStatic]
			private static T gparam_0;
		}
	}
}
