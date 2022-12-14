using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using KeraLua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using NLua.Exceptions;
using ns12;
using ns13;
using ns14;
using ns9;

namespace Command_Core.Lua
{
	// Token: 0x02000454 RID: 1108
	[Attribute1]
	public sealed class LuaSandBox
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600219D RID: 8605 RVA: 0x0025F0BC File Offset: 0x0025D2BC
		// (remove) Token: 0x0600219E RID: 8606 RVA: 0x0025F0F4 File Offset: 0x0025D2F4
		public event LuaSandBox.LuaPrintEventHandler LuaPrint;

		// Token: 0x0600219F RID: 8607 RVA: 0x0001094B File Offset: 0x0000EB4B
		public static LuaSandBox Singleton()
		{
			return LuaSandBox._LuaSandbox;
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x00010952 File Offset: 0x0000EB52
		public LuaTable CreateTable()
		{
			return (LuaTable)Enumerable.First<object>(this.lua.DoString("return {}", "chunk"));
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0025F12C File Offset: 0x0025D32C
		public int SB_Getinfo(string string_0, ref LuaDebug luaDebug_0)
		{
			luaDebug_0 = default(LuaDebug);
			return 0;
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00010973 File Offset: 0x0000EB73
		public NLua.Lua SB_Lua()
		{
			return this.lua;
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x0025F14C File Offset: 0x0025D34C
		public LuaSandBox()
		{
			this.initalLoad = true;
			this.SecurityString = new StringBuilder();
			this.AliasString = new StringBuilder();
			this.UnitX = null;
			this.UnitY = null;
			this.UnitC = null;
			this.SensorsThatMadeDetection = null;
			this.EventX = null;
			this.enumTable = null;
			this.currentFunction = "";
			this.currentLine = 0;
			this.lastError = "";
			this.luaDynamicFunctions = null;
			this.InitializeStats();
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x0001097B File Offset: 0x0000EB7B
		public void InitializeStats()
		{
			LuaSandBox._LuaSandbox = this;
			this.lua = new NLua.Lua();
			this.lua.LoadCLRPackage();
			this.LuaPrint += this.HandleLuaPrint;
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x0025F1D0 File Offset: 0x0025D3D0
		public void RefreshStats(Scenario scenario_0)
		{
			this.ScenarioContext = scenario_0;
			this.luaDynamicFunctions = new CMANO(this.ScenarioContext);
			this.AliasString.Clear();
			this.SecurityString.Clear();
			this.SecurityString.Append("dofile=nil").Append("\r\n");
			if (!GameGeneral.bool_3)
			{
				this.SecurityString.Append("io=nil").Append("\r\n");
			}
			this.SecurityString.Append("load=nil\r\nloadfile=nil\r\nloadstring=nil\r\nrawequal=nil\r\nrawget=nil\r\nrawset=nil\r\nmodule=nil\r\nrequire=nil\r\npackage.loaded=nil\r\npackage.loaders=nil\r\npackage.loadlib=nil\r\npackage.path=nil\r\npackage.cpath=nil\r\npackage.preload=nil\r\npackage.seeall=nil\r\nstring.dump=nil\r\nos.execute=nil\r\nos.exit=nil\r\nos.getenv=nil\r\nos.remove=nil\r\nos.rename=nil\r\nos.tmpname=nil\r\nnewproxy=nil\r\n");
			if (this.initalLoad)
			{
				this.SecurityString.Append("os.default_date = os.date;\r\n");
				this.SecurityString.Append("local function date_override(format, x)\r\n");
				this.SecurityString.Append("  local now = os.time()\r\n");
				this.SecurityString.Append("  if format == nil or format == '' then\r\n");
				this.SecurityString.Append("    format = '!%a %b %d %X %Y UTC';\r\n");
				this.SecurityString.Append("  elseif string.sub(format,1,1) ~= '!' then\r\n");
				this.SecurityString.Append("      format = '!' .. format;\r\n");
				this.SecurityString.Append("  end\r\n");
				this.SecurityString.Append("  if x ~= nil then\r\n");
				this.SecurityString.Append("    return os.default_date(format,x);\r\n");
				this.SecurityString.Append("  else\r\n");
				this.SecurityString.Append("    return os.default_date(format,now);\r\n");
				this.SecurityString.Append("  end\r\n");
				this.SecurityString.Append("end\r\n");
				this.SecurityString.Append("os.date = date_override;\r\n");
				this.initalLoad = false;
			}
			MethodInfo method = base.GetType().GetMethod("LUA_Echo");
			this.lua.RegisterFunction("Echo", this, method);
			LuaSandBox.LuaMethods.Clear();
			this.RegisterFunction("GetScenarioTitle", base.GetType().GetMethod("LUA_GetScenarioTitle"));
			LuaSandBox.LuaMethods.Add("GetScenarioTitle()");
			this.RegisterFunction("GetBuildNumber", base.GetType().GetMethod("LUA_GetBuildNumber"));
			LuaSandBox.LuaMethods.Add("GetBuildNumber()");
			this.RegisterFunction("VP_GetSide", base.GetType().GetMethod("LUA_VP_GetSide"));
			LuaSandBox.LuaMethods.Add("VP_GetSide(table)");
			this.RegisterFunction("VP_GetUnit", base.GetType().GetMethod("LUA_VP_GetUnit"));
			LuaSandBox.LuaMethods.Add("VP_GetUnit(table)");
			this.RegisterFunction("VP_GetContact", base.GetType().GetMethod("LUA_VP_GetContact"));
			LuaSandBox.LuaMethods.Add("VP_GetContact(table)");
			this.RegisterFunction("VP_ExportUnits", base.GetType().GetMethod("LUA_VP_ExportUnits"));
			this.RegisterFunction("ScenEdit_AddAircraft", base.GetType().GetMethod("LUA_ScenEdit_AddAircraft"));
			this.RegisterFunction("ScenEdit_AddShip", base.GetType().GetMethod("LUA_ScenEdit_AddShip"));
			this.RegisterFunction("ScenEdit_AddSubmarine", base.GetType().GetMethod("LUA_ScenEdit_AddSubmarine"));
			this.RegisterFunction("ScenEdit_AddFacility", base.GetType().GetMethod("LUA_ScenEdit_AddFacility"));
			this.RegisterFunction("ScenEdit_AssignUnitToMission", base.GetType().GetMethod("LUA_ScenEdit_AssignUnitToMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AssignUnitToMission('AUNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_SetWeather", base.GetType().GetMethod("LUA_ScenEdit_SetWeather"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetWeather(AvgTemp, RainfallRate, FractionUnderRain, SeaState)");
			this.RegisterFunction("ScenEdit_GetWeather", base.GetType().GetMethod("LUA_ScenEdit_GetWeather"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetWeather()");
			this.RegisterFunction("ScenEdit_SetSidePosture", base.GetType().GetMethod("LUA_ScenEdit_SetSidePosture"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetSidePosture('SideANameOrID', 'SideBNameOrID', 'PostureCode')");
			this.RegisterFunction("ScenEdit_GetSidePosture", base.GetType().GetMethod("LUA_ScenEdit_GetSidePosture"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetSidePosture('SideANameOrID', 'SideBNameOrID')");
			this.RegisterFunction("ScenEdit_GetSideIsHuman", base.GetType().GetMethod("LUA_ScenEdit_GetSideIsHuman"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetSideIsHuman('SideANameOrID')");
			this.RegisterFunction("ScenEdit_GetScenHasStarted", base.GetType().GetMethod("LUA_ScenEdit_GetScenHasStarted"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetScenHasStarted()");
			this.RegisterFunction("ScenEdit_SetEMCON", base.GetType().GetMethod("LUA_ScenEdit_SetEMCON"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetEMCON('EMCONSubjectType', 'EMCONSubjectNameOrID', 'EMCONSettings')");
			this.RegisterFunction("ScenEdit_MsgBox", base.GetType().GetMethod("LUA_ScenEdit_MsgBox"));
			LuaSandBox.LuaMethods.Add("ScenEdit_MsgBox('str', style)");
			this.RegisterFunction("ScenEdit_RunScript", base.GetType().GetMethod("LUA_ScenEdit_RunScript"));
			LuaSandBox.LuaMethods.Add("ScenEdit_RunScript('str')");
			this.RegisterFunction("ScenEdit_AddUnit", base.GetType().GetMethod("LUA_ScenEdit_AddUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddUnit(table)");
			this.RegisterFunction("ScenEdit_UpdateUnit", base.GetType().GetMethod("LUA_ScenEdit_UpdateUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UpdateUnit(table)");
			this.RegisterFunction("ScenEdit_SetUnit", base.GetType().GetMethod("LUA_ScenEdit_SetUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetUnit(table)");
			this.RegisterFunction("ScenEdit_GetUnit", base.GetType().GetMethod("LUA_ScenEdit_GetUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetUnit(table)");
			this.RegisterFunction("ScenEdit_SetKeyValue", base.GetType().GetMethod("LUA_ScenEdit_SetKeyValue"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetKeyValue('key', 'value' [, false/true])");
			this.RegisterFunction("ScenEdit_GetKeyValue", base.GetType().GetMethod("LUA_ScenEdit_GetKeyValue"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetKeyValue('key' [,false/true])");
			this.RegisterFunction("ScenEdit_ClearKeyValue", base.GetType().GetMethod("LUA_ScenEdit_ClearKeyValue"));
			LuaSandBox.LuaMethods.Add("ScenEdit_ClearKeyValue('key' [,false/true])");
			this.RegisterFunction("ScenEdit_DeleteUnit", base.GetType().GetMethod("LUA_ScenEdit_DeleteUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_DeleteUnit(table[, false/true])");
			this.RegisterFunction("ScenEdit_KillUnit", base.GetType().GetMethod("LUA_ScenEdit_KillUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_KillUnit(table)");
			if (GameGeneral.smethod_6())
			{
				this.RegisterFunction("ScenEdit_ExportScenarioToXML", base.GetType().GetMethod("LUA_ScenEdit_ExportScenarioToXML"));
				LuaSandBox.LuaMethods.Add("ScenEdit_ExportScenarioToXML()");
				this.RegisterFunction("ScenEdit_ImportScenarioFromXML", base.GetType().GetMethod("LUA_ScenEdit_ImportScenarioFromXML"));
				LuaSandBox.LuaMethods.Add("ScenEdit_ImportScenarioFromXML(table)");
			}
			this.RegisterFunction("ScenEdit_SetSpecialAction", base.GetType().GetMethod("LUA_ScenEdit_SetSpecialAction"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetSpecialAction(table)");
			this.RegisterFunction("ScenEdit_SetUnitSide", base.GetType().GetMethod("LUA_ScenEdit_SetUnitSide"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetUnitSide(table)");
			this.RegisterFunction("ScenEdit_SetTime", base.GetType().GetMethod("LUA_ScenEdit_SetTime"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetTime(table)");
			this.RegisterFunction("ScenEdit_AddReferencePoint", base.GetType().GetMethod("LUA_ScenEdit_AddReferencePoint"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddReferencePoint(table)");
			this.RegisterFunction("ScenEdit_AddExplosion", base.GetType().GetMethod("LUA_ScenEdit_AddExplosion"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddExplosion(table)");
			this.RegisterFunction("ScenEdit_SetReferencePoint", base.GetType().GetMethod("LUA_ScenEdit_SetReferencePoint"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetReferencePoint(table)");
			this.RegisterFunction("ScenEdit_GetReferencePoint", base.GetType().GetMethod("LUA_ScenEdit_GetReferencePoint"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetReferencePoint(table)");
			this.RegisterFunction("ScenEdit_GetReferencePoints", base.GetType().GetMethod("LUA_ScenEdit_GetReferencePoints"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetReferencePoints(table)");
			this.RegisterFunction("ScenEdit_DeleteReferencePoint", base.GetType().GetMethod("LUA_ScenEdit_DeleteReferencePoint"));
			LuaSandBox.LuaMethods.Add("ScenEdit_DeleteReferencePoint(table)");
			this.RegisterFunction("print", base.GetType().GetMethod("LUA_ScenEdit_Print"));
			LuaSandBox.LuaMethods.Add("print(obj)");
			this.RegisterFunction("print_escaped", base.GetType().GetMethod("LUA_ScenEdit_PrintEscaped"));
			LuaSandBox.LuaMethods.Add("print_escaped(obj)");
			this.RegisterFunction("ScenEdit_SetDoctrine", base.GetType().GetMethod("LUA_ScenEdit_SetDoctrine"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetDoctrine(table,doctrine)");
			this.RegisterFunction("ScenEdit_SetDoctrineWRA", base.GetType().GetMethod("LUA_ScenEdit_SetDoctrineWRA"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetDoctrineWRA(table)");
			this.RegisterFunction("ScenEdit_GetDoctrine", base.GetType().GetMethod("LUA_ScenEdit_GetDoctrine"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetDoctrine(table)");
			this.RegisterFunction("ScenEdit_GetDoctrineWRA", base.GetType().GetMethod("LUA_ScenEdit_GetDoctrineWRA"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetDoctrineWRA(table)");
			this.RegisterFunction("ScenEdit_HostUnitToParent", base.GetType().GetMethod("LUA_ScenEdit_HostUnitToParent"));
			LuaSandBox.LuaMethods.Add("ScenEdit_HostUnitToParent(table)");
			this.RegisterFunction("ScenEdit_CurrentTime", base.GetType().GetMethod("LUA_ScenEdit_CurrentTime"));
			LuaSandBox.LuaMethods.Add("ScenEdit_CurrentTime()");
			this.RegisterFunction("ScenEdit_CurrentLocalTime", base.GetType().GetMethod("LUA_ScenEdit_CurrentLocalTime"));
			LuaSandBox.LuaMethods.Add("ScenEdit_CurrentLocalTime()");
			this.RegisterFunction("ScenEdit_UnitX", base.GetType().GetMethod("LUA_ScenEdit_UnitX"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UnitX()");
			this.RunScript("UnitX = ScenEdit_UnitX", false, "Initializing");
			this.RegisterFunction("ScenEdit_UnitY", base.GetType().GetMethod("LUA_ScenEdit_UnitY"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UnitY()");
			this.RunScript("UnitY = ScenEdit_UnitY", false, "Initializing");
			this.RegisterFunction("ScenEdit_UnitC", base.GetType().GetMethod("LUA_ScenEdit_UnitC"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UnitC()");
			this.RunScript("UnitC = ScenEdit_UnitC", false, "Initializing");
			this.RegisterFunction("ScenEdit_UseAttachment", base.GetType().GetMethod("LUA_ScenEdit_UseAttachment"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UseAttachment('AttachmentNameOrID')");
			this.RegisterFunction("ScenEdit_UseAttachmentOnSide", base.GetType().GetMethod("LUA_ScenEdit_UseAttachmentOnSide"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UseAttachmentOnSide('AttachmentNameOrID', 'SideNameOrID')");
			this.RegisterFunction("ScenEdit_GetScore", base.GetType().GetMethod("LUA_ScenEdit_GetScore"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetScore('SideNameOrID')");
			this.RegisterFunction("ScenEdit_SetLoadout", base.GetType().GetMethod("LUA_ScenEdit_SetLoadout"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetLoadout(table)");
			this.RegisterFunction("ScenEdit_SetScore", base.GetType().GetMethod("LUA_ScenEdit_SetScore"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetScore('SideNameOrID',Score,'ReasonForChange')");
			this.RegisterFunction("ScenEdit_SpecialMessage", base.GetType().GetMethod("LUA_ScenEdit_SpecialMessage"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SpecialMessage('SideNameOrID','Text' [,{lat=,lon=}])");
			this.RegisterFunction("ScenEdit_PlayerSide", base.GetType().GetMethod("LUA_ScenEdit_PlayerSide"));
			LuaSandBox.LuaMethods.Add("ScenEdit_PlayerSide()");
			this.RegisterFunction("ScenEdit_EndScenario", base.GetType().GetMethod("LUA_ScenEdit_EndScenario"));
			LuaSandBox.LuaMethods.Add("ScenEdit_EndScenario()");
			this.RegisterFunction("ScenEdit_ImportInst", base.GetType().GetMethod("LUA_ScenEdit_ImportInst"));
			LuaSandBox.LuaMethods.Add("ScenEdit_ImportInst('SideNameOrID', 'InstFile')");
			this.RegisterFunction("ScenEdit_ExportInst", base.GetType().GetMethod("LUA_ScenEdit_ExportInst"));
			LuaSandBox.LuaMethods.Add("ScenEdit_ExportInst('SideNameOrID', 'units', 'fileData')");
			this.RegisterFunction("ScenEdit_AddWeaponToUnitMagazine", base.GetType().GetMethod("LUA_ScenEdit_AddWeaponToUnitMagazine"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddWeaponToUnitMagazine(table)");
			this.RegisterFunction("ScenEdit_AddReloadsToUnit", base.GetType().GetMethod("LUA_ScenEdit_AddReloadsToUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddReloadsToUnit(table)");
			this.RegisterFunction("ScenEdit_GetSideOptions", base.GetType().GetMethod("LUA_ScenEdit_GetSideOptions"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetSideOptions(table)");
			this.RegisterFunction("ScenEdit_SetSideOptions", base.GetType().GetMethod("LUA_ScenEdit_SetSideOptions"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetSideOptions(table)");
			this.RegisterFunction("ScenEdit_SetUnitDamage", base.GetType().GetMethod("LUA_ScenEdit_SetUnitDamage"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetUnitDamage(table)");
			this.RegisterFunction("ScenEdit_GetMission", base.GetType().GetMethod("LUA_ScenEdit_GetMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetMission('SideNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_SetMission", base.GetType().GetMethod("LUA_ScenEdit_SetMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetMission('SideNameOrID', 'MissionNameOrID',table)");
			this.RegisterFunction("ScenEdit_AddMission", base.GetType().GetMethod("LUA_ScenEdit_AddMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddMission('SideNameOrID', 'MissionNameOrID', 'MissionType', table)");
			this.RegisterFunction("ScenEdit_DeleteMission", base.GetType().GetMethod("LUA_ScenEdit_DeleteMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_DeleteMission('SideNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_ImportMission", base.GetType().GetMethod("LUA_ScenEdit_ImportMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_ImportMission('SideNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_ExportMission", base.GetType().GetMethod("LUA_ScenEdit_ExportMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_ExportMission('SideNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_AssignUnitAsTarget", base.GetType().GetMethod("LUA_ScenEdit_AssignUnitAsTarget"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AssignUnitAsTarget('AUNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_RemoveUnitAsTarget", base.GetType().GetMethod("LUA_ScenEdit_RemoveUnitAsTarget"));
			LuaSandBox.LuaMethods.Add("ScenEdit_RemoveUnitAsTarget('AUNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_RefuelUnit", base.GetType().GetMethod("LUA_ScenEdit_RefuelUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_RefuelUnit(table)");
			this.RegisterFunction("ScenEdit_ExecuteEventAction", base.GetType().GetMethod("LUA_ScenEdit_ExecuteEventAction"));
			LuaSandBox.LuaMethods.Add("ScenEdit_ExecuteEventAction('EventNameOrId')");
			this.RegisterFunction("ScenEdit_SetEvent", base.GetType().GetMethod("LUA_ScenEdit_SetEvent"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetEvent('EventNameOrId', table)");
			this.RegisterFunction("ScenEdit_SetTrigger", base.GetType().GetMethod("LUA_ScenEdit_SetTrigger"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetTrigger( table)");
			this.RegisterFunction("ScenEdit_SetCondition", base.GetType().GetMethod("LUA_ScenEdit_SetCondition"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetCondition( table)");
			this.RegisterFunction("ScenEdit_SetAction", base.GetType().GetMethod("LUA_ScenEdit_SetAction"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetAction( table)");
			this.RegisterFunction("ScenEdit_SetEventTrigger", base.GetType().GetMethod("LUA_ScenEdit_SetEventTrigger"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetEventTrigger('EventNameOrId', table)");
			this.RegisterFunction("ScenEdit_SetEventCondition", base.GetType().GetMethod("LUA_ScenEdit_SetEventCondition"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetEventCondition('EventNameOrId', table)");
			this.RegisterFunction("ScenEdit_SetEventAction", base.GetType().GetMethod("LUA_ScenEdit_SetEventAction"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetEventAction('EventNameOrId', table)");
			this.RegisterFunction("ScenEdit_GetEvent", base.GetType().GetMethod("LUA_ScenEdit_GetEvent"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetEvent('EventNameOrId',[level])");
			this.RegisterFunction("ScenEdit_UpdateEvent", base.GetType().GetMethod("LUA_ScenEdit_UpdateEvent"));
			this.RegisterFunction("ScenEdit_GetSpecialAction", base.GetType().GetMethod("LUA_ScenEdit_GetSpecialAction"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetSpecialAction(table)");
			this.RegisterFunction("ScenEdit_ExecuteSpecialAction", base.GetType().GetMethod("LUA_ScenEdit_ExecuteSpecialAction"));
			LuaSandBox.LuaMethods.Add("ScenEdit_ExecuteSpecialAction('EventNameOrId')");
			this.RegisterFunction("ScenEdit_GetContacts", base.GetType().GetMethod("LUA_ScenEdit_GetContacts"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetContacts('SideName')");
			this.RegisterFunction("ScenEdit_FillMagsForLoadout", base.GetType().GetMethod("LUA_ScenEdit_FillMagsForLoadout"));
			LuaSandBox.LuaMethods.Add("ScenEdit_FillMagsForLoadout(table)");
			this.RegisterFunction("ScenEdit_GetContact", base.GetType().GetMethod("LUA_ScenEdit_GetContact"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetContact(table)");
			this.RegisterFunction("ScenEdit_AttackContact", base.GetType().GetMethod("LUA_ScenEdit_AttackContact"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AttackContact('AttackerNameOrId','ContactNameOrId', table)");
			this.RegisterFunction("ScenEdit_InputBox", base.GetType().GetMethod("LUA_ScenEdit_InputBox"));
			LuaSandBox.LuaMethods.Add("ScenEdit_InputBox('str')");
			this.RegisterFunction("ScenEdit_AddSide", base.GetType().GetMethod("LUA_ScenEdit_AddSide"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddSide(table)");
			this.RegisterFunction("ScenEdit_RemoveSide", base.GetType().GetMethod("LUA_ScenEdit_RemoveSide"));
			LuaSandBox.LuaMethods.Add("ScenEdit_RemoveSide(table)");
			this.RegisterFunction("ScenEdit_AddZone", base.GetType().GetMethod("LUA_ScenEdit_AddZone"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddZone(sideName, zoneType, table)");
			this.RegisterFunction("ScenEdit_SetZone", base.GetType().GetMethod("LUA_ScenEdit_SetZone"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetZone(sideName, zoneType, table)");
			this.RegisterFunction("ScenEdit_RemoveZone", base.GetType().GetMethod("LUA_ScenEdit_RemoveZone"));
			LuaSandBox.LuaMethods.Add("ScenEdit_RemoveZone(sideName, zoneType, table)");
			this.RegisterFunction("ScenEdit_TransferCargo", base.GetType().GetMethod("LUA_ScenEdit_TransferCargo"));
			LuaSandBox.LuaMethods.Add("ScenEdit_TransferCargo(from, to, table)");
			this.RegisterFunction("ScenEdit_UnloadCargo", base.GetType().GetMethod("LUA_ScenEdit_UnloadCargo"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UnloadCargo(from, [table])");
			this.RegisterFunction("ScenEdit_SelectedUnits", base.GetType().GetMethod("LUA_ScenEdit_SelectedUnits"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SelectedUnits()");
			this.RegisterFunction("ScenEdit_EventX", base.GetType().GetMethod("LUA_ScenEdit_EventX"));
			LuaSandBox.LuaMethods.Add("ScenEdit_EventX()");
			this.RunScript("EventX = ScenEdit_EventX", false, "Initializing");
			this.RegisterFunction("ScenEdit_GetFormation", base.GetType().GetMethod("LUA_ScenEdit_GetFormation"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetFormation(table)");
			this.RegisterFunction("ScenEdit_GetLoadout", base.GetType().GetMethod("LUA_ScenEdit_GetLoadout"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetLoadout(table)");
			this.RegisterFunction("ScenEdit_UpdateUnitCargo", base.GetType().GetMethod("LUA_ScenEdit_UpdateUnitCargo"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UpdateUnitCargo(table)");
			this.RegisterFunction("ScenEdit_GetTimeOfDay", base.GetType().GetMethod("LUA_ScenEdit_GetTimeOfDay"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetTimeOfDay(table)");
			this.RegisterFunction("ScenEdit_QueryDB", base.GetType().GetMethod("LUA_ScenEdit_QueryDB"));
			LuaSandBox.LuaMethods.Add("ScenEdit_QueryDB(type, DBID)");
			this.RegisterFunction("ScenEdit_PlaySound", base.GetType().GetMethod("LUA_ScenEdit_PlaySound"));
			LuaSandBox.LuaMethods.Add("ScenEdit_PlaySound(file, delay)");
			this.RegisterFunction("ScenEdit_PlayVideo", base.GetType().GetMethod("LUA_ScenEdit_PlayVideo"));
			LuaSandBox.LuaMethods.Add("ScenEdit_PlayVideo(file, fullscreen, delay)");
			this.RegisterFunction("World_GetElevation", base.GetType().GetMethod("LUA_World_GetElevation"));
			LuaSandBox.LuaMethods.Add("World_GetElevation(table)");
			this.RegisterFunction("World_GetCircleFromPoint", base.GetType().GetMethod("LUA_World_GetCircleFromPoint"));
			LuaSandBox.LuaMethods.Add("World_GetCircleFromPoint(table)");
			this.RegisterFunction("World_GetPointFromBearing", base.GetType().GetMethod("LUA_World_GetPointFromBearing"));
			LuaSandBox.LuaMethods.Add("World_GetPointFromBearing(table)");
			this.RegisterFunction("Tool_DumpEvents", base.GetType().GetMethod("Tool_DumpEvents"));
			LuaSandBox.LuaMethods.Add("Tool_DumpEvents()");
			this.RegisterFunction("Tool_EmulateNoConsole", base.GetType().GetMethod("Tool_EmulateNoConsole"));
			LuaSandBox.LuaMethods.Add("Tool_EmulateNoConsole()");
			this.RegisterFunction("Tool_Range", base.GetType().GetMethod("Tool_Range"));
			LuaSandBox.LuaMethods.Add("Tool_Range(from, to)");
			this.RegisterFunction("Tool_Bearing", base.GetType().GetMethod("Tool_Bearing"));
			LuaSandBox.LuaMethods.Add("Tool_Bearing(from, to)");
			this.lua.DoString("math.randomseed( os.time() )", "chunk");
			this.lua["_errmsg_"] = "none";
			this.lua["_errfnc_"] = "none";
			this.enumTable = new LuaEnuNames();
			this.lua["_enumTable_"] = this.enumTable;
			this.lua["CMANO"] = this.luaDynamicFunctions;
			this.SetUpAliases();
			if (this.AliasString.Length > 0)
			{
				this.lua.DoString(this.AliasString.ToString(), "chunk");
			}
			this.lua.DoString(this.SecurityString.ToString(), "chunk");
			string path = Path.Combine(Application.StartupPath, "Defaults", ".startup.lua");
			if (File.Exists(path))
			{
				string str = File.ReadAllText(path);
				this.RunScript(str, false, "Initializing");
			}
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x0026078C File Offset: 0x0025E98C
		public void ClearStats()
		{
			this.luaDynamicFunctions = null;
			this.enumTable = null;
			this.ScenarioContext = null;
			this.UnitX = null;
			this.UnitY = null;
			this.UnitC = null;
			this.SensorsThatMadeDetection = null;
			this.EventX = null;
			LuaSandBox.LuaMethods.Clear();
			this.lua.Close();
			Thread.Sleep(100);
			this.lua = new NLua.Lua();
			this.lua.LoadCLRPackage();
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00260804 File Offset: 0x0025EA04
		private void HandleLuaPrint(object object_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(object_0)));
			string text = "";
			object obj = stringBuilder.ToString();
			LuaUtility.smethod_34(ref text, ref obj, false);
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00260840 File Offset: 0x0025EA40
		private void ClearLuaErrorCondition(string string_0)
		{
			this.currentFunction = string_0;
			this.lua["_errmsg_"] = "";
			this.lua["_errfnc_"] = "";
			this.lua["_errnum_"] = 0;
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x00260894 File Offset: 0x0025EA94
		public void RegisterFunction(string string_0, MethodInfo methodInfo_0)
		{
			try
			{
				this.lua.RegisterFunction(string_0, this, methodInfo_0);
				List<string> list = new List<string>();
				foreach (ParameterInfo parameterInfo in methodInfo_0.GetParameters())
				{
					if (Operators.CompareString(parameterInfo.Name, "CoordsFormat", false) == 0)
					{
						list.Add("'DEC'/'DEG'");
					}
					else if (parameterInfo.ParameterType == typeof(string))
					{
						list.Add("'" + parameterInfo.Name + "'");
					}
					else
					{
						list.Add(parameterInfo.Name);
					}
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x0026095C File Offset: 0x0025EB5C
		[Attribute2]
		public void LUA_ScenEdit_Print(object object_0)
		{
			LuaSandBox.LuaPrintEventHandler luaPrintEvent = this.LuaPrintEvent;
			if (luaPrintEvent != null)
			{
				luaPrintEvent(RuntimeHelpers.GetObjectValue(object_0));
			}
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x00260980 File Offset: 0x0025EB80
		[Attribute2]
		public void LUA_ScenEdit_PrintEscaped(object object_0)
		{
			string text = Conversions.ToString(object_0);
			text = text.Replace("\"", "\\\"").Replace("'", "\\'");
			this.LUA_ScenEdit_Print(text);
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x002609BC File Offset: 0x0025EBBC
		public object[] RunScript(string str, bool RunInteractively, string script = null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string text = str.Split(new char[]
			{
				'('
			})[0];
			this.RunInteractive = RunInteractively;
			if (Operators.CompareString(text, "ScenEdit_SetScore", false) == 0)
			{
				List<string> list = Enumerable.ToList<string>(Strings.Left(str.Split(new char[]
				{
					'('
				})[1], Strings.Len(str.Split(new char[]
				{
					'('
				})[1]) - 1).Split(new char[]
				{
					','
				}));
				if (list.Count == 2)
				{
					list.Add("'No reason given'");
				}
				str = text + "(" + string.Join(",", list) + ")";
			}
			if (!Information.IsNothing(LuaSandBox._LuaSandbox) & !this.RunInteractive)
			{
				stringBuilder.Append(str);
				if (!Information.IsNothing(this.lua))
				{
					string text2 = null;
					try
					{
						text2 = this.lua.GetString("_lua_event");
					}
					catch (Exception ex)
					{
					}
					if (!Information.IsNothing(text2))
					{
						bool? flag = LuaUtility.smethod_10(text2);
						if (((flag != null) ? new bool?(flag.GetValueOrDefault()) : null).GetValueOrDefault())
						{
							LuaSandBox._lua_event = true;
						}
						else
						{
							LuaSandBox._lua_event = false;
						}
					}
				}
				if (LuaSandBox._lua_event)
				{
					string text3 = "Script:" + script;
					object obj = stringBuilder.ToString();
					LuaUtility.smethod_34(ref text3, ref obj, true);
				}
			}
			this.currentLine = 0;
			object[] result;
			try
			{
				object[] array;
				if (Operators.CompareString(str, "_VERSION", false) == 0)
				{
					array = this.lua.DoString("return _VERSION", "chunk");
				}
				else
				{
					try
					{
						if (this.RunInteractive)
						{
							array = this.lua.DoString(str, "Console");
						}
						else
						{
							array = this.lua.DoString(str, script);
						}
					}
					catch (LuaScriptException ex2)
					{
						if (ex2.InnerException is Exception3)
						{
							if (this.RunInteractive)
							{
								if (Information.IsNothing(((Exception3)ex2.InnerException).string_1))
								{
									GameGeneral.smethod_1(((Exception3)ex2.InnerException).string_0);
								}
								else
								{
									GameGeneral.smethod_1(string.Concat(new string[]
									{
										((Exception3)ex2.InnerException).string_1,
										" ",
										((Exception3)ex2.InnerException).int_0.ToString(),
										" : ",
										((Exception3)ex2.InnerException).string_0
									}));
								}
							}
							array = new object[]
							{
								null,
								((Exception3)ex2.InnerException).string_0
							};
							array[0] = ((Exception3)ex2.InnerException).string_1 + " " + ((Exception3)ex2.InnerException).int_0.ToString() + " : ";
							return array;
						}
						throw;
					}
				}
				result = array;
			}
			catch (Exception ex3)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (!this.RunInteractive)
				{
					string text3 = "";
					object obj = ex3;
					LuaUtility.smethod_34(ref text3, ref obj, false);
					throw;
				}
				object[] array = new object[2];
				array[0] = ex3;
				result = array;
			}
			return result;
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00260D4C File Offset: 0x0025EF4C
		[Attribute0]
		[Attribute2]
		public LuaWrapper_ActiveUnit_SE LUA_ScenEdit_UnitX()
		{
			this.ClearLuaErrorCondition("ScenEdit_UnitX");
			LuaWrapper_ActiveUnit_SE result;
			if (this.UnitX == null)
			{
				result = null;
			}
			else
			{
				try
				{
					result = new LuaWrapper_ActiveUnit_SE(this.UnitX, this.ScenarioContext);
				}
				catch (Exception ex)
				{
					if (this.RunInteractive)
					{
						throw;
					}
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00260DB0 File Offset: 0x0025EFB0
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_UnitY()
		{
			this.ClearLuaErrorCondition("ScenEdit_UnitY");
			LuaTable result;
			if (this.UnitY == null)
			{
				result = null;
			}
			else
			{
				try
				{
					LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
					LuaWrapper_ActiveUnit_SE value = new LuaWrapper_ActiveUnit_SE(this.UnitY, this.ScenarioContext);
					luaTable["unit"] = value;
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					if (Information.IsNothing(this.SensorsThatMadeDetection))
					{
						result = luaTable;
					}
					else
					{
						try
						{
							foreach (Sensor sensor in this.SensorsThatMadeDetection)
							{
								LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
								luaTable3["name"] = sensor.Name;
								luaTable3["type"] = sensor.sensor_Type_0.ToString();
								luaTable2[luaTable2.Keys.Count + 1] = luaTable3;
							}
						}
						finally
						{
							List<Sensor>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						luaTable["sensor"] = luaTable2;
						result = luaTable;
					}
				}
				catch (Exception ex)
				{
					if (this.RunInteractive)
					{
						throw;
					}
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00260EF0 File Offset: 0x0025F0F0
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Contact LUA_ScenEdit_UnitC()
		{
			this.ClearLuaErrorCondition("ScenEdit_UnitC");
			LuaWrapper_Contact result;
			if (this.UnitY == null)
			{
				result = null;
			}
			else
			{
				try
				{
					result = new LuaWrapper_Contact(this.UnitC, this.ScenarioContext, this.UnitY.vmethod_7(false));
				}
				catch (Exception ex)
				{
					if (this.RunInteractive)
					{
						throw;
					}
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00260F60 File Offset: 0x0025F160
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Event LUA_ScenEdit_EventX()
		{
			this.ClearLuaErrorCondition("ScenEdit_EventX");
			LuaWrapper_Event result;
			if (this.EventX == null)
			{
				result = null;
			}
			else
			{
				try
				{
					result = new LuaWrapper_Event(this.EventX, 0, false, this.ScenarioContext);
				}
				catch (Exception ex)
				{
					if (this.RunInteractive)
					{
						throw;
					}
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00260FC4 File Offset: 0x0025F1C4
		[Attribute0]
		[Attribute2]
		public double LUA_ScenEdit_CurrentTime()
		{
			this.ClearLuaErrorCondition("ScenEdit_CurrentTime");
			double result;
			try
			{
				result = (this.ScenarioContext.method_31() - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0.0;
			}
			return result;
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x00261038 File Offset: 0x0025F238
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_CurrentLocalTime()
		{
			this.ClearLuaErrorCondition("ScenEdit_CurrentLocalTime");
			string result;
			try
			{
				Side side = this.ScenarioContext.method_54();
				GeoPoint geoPoint;
				if (!Information.IsNothing(side))
				{
					geoPoint = side.method_26();
				}
				else
				{
					geoPoint = new GeoPoint(0.0, 0.0);
				}
				DateTime dateTime = Misc.smethod_10(this.ScenarioContext.method_31(), geoPoint.imethod_0(), this.ScenarioContext.method_33(), this.ScenarioContext.method_35(), this.ScenarioContext.method_37());
				result = string.Concat(new string[]
				{
					dateTime.Hour.ToString("D2"),
					":",
					dateTime.Minute.ToString("D2"),
					":",
					dateTime.Second.ToString("D2")
				});
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x000073AD File Offset: 0x000055AD
		[Attribute0]
		[Attribute2]
		public string LUA_Echo(string string_0)
		{
			return string_0;
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x000109AB File Offset: 0x0000EBAB
		[Attribute0]
		[Attribute2]
		public string LUA_GetBuildNumber()
		{
			this.ClearLuaErrorCondition("GetBuildNumber");
			return "1115.6";
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x000109BD File Offset: 0x0000EBBD
		[Attribute0]
		[Attribute2]
		public string LUA_GetScenarioTitle()
		{
			this.ClearLuaErrorCondition("GetScenarioTitle");
			return this.ScenarioContext.method_0();
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0026114C File Offset: 0x0025F34C
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Side LUA_VP_GetSide(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("VP_GetSide");
			LuaWrapper_Side result;
			try
			{
				result = PrivateMethods.smethod_61(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0026119C File Offset: 0x0025F39C
		[Attribute0]
		[Attribute2]
		public LuaWrapper_ActiveUnit LUA_VP_GetUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("VP_GetUnit");
			LuaWrapper_ActiveUnit result;
			try
			{
				result = PrivateMethods.smethod_59(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x002611EC File Offset: 0x0025F3EC
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Contact LUA_VP_GetContact(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("VP_GetContact");
			LuaWrapper_Contact result;
			try
			{
				result = PrivateMethods.smethod_60(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x000109D5 File Offset: 0x0000EBD5
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_AddAircraft(string string_0, string string_1, int int_0, int int_1, string string_2, string string_3, string string_4)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddAircraft");
			return PrivateMethods.smethod_4(string_0, string_1, int_0, int_1, string_2, string_3, string_4, this.ScenarioContext);
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x000109F8 File Offset: 0x0000EBF8
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_AddShip(string string_0, string string_1, int int_0, string string_2, string string_3, string string_4)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddShip");
			return PrivateMethods.smethod_5(string_0, string_1, int_0, string_2, string_3, string_4, this.ScenarioContext);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x00010A19 File Offset: 0x0000EC19
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_AddSubmarine(string string_0, string string_1, int int_0, string string_2, string string_3, string string_4)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddSubmarine");
			return PrivateMethods.smethod_6(string_0, string_1, int_0, string_2, string_3, string_4, this.ScenarioContext);
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00010A3A File Offset: 0x0000EC3A
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_AddFacility(string string_0, string string_1, int int_0, int int_1, string string_2, string string_3, string string_4)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddFacility");
			return PrivateMethods.smethod_8(string_0, string_1, int_0, int_1, string_2, string_3, string_4, this.ScenarioContext);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0026123C File Offset: 0x0025F43C
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_AssignUnitToMission(string AUNameOrID, string MissionNameOrID, bool Escort = false, bool MissionPlanner = false)
		{
			this.ClearLuaErrorCondition("ScenEdit_AssignUnitToMission");
			bool value = LuaUtility.smethod_10(Escort).Value;
			bool value2 = LuaUtility.smethod_10(MissionPlanner).Value;
			bool result;
			try
			{
				result = PrivateMethods.smethod_12(AUNameOrID, MissionNameOrID, this.ScenarioContext, this.UnitX, value, value2);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x002612C0 File Offset: 0x0025F4C0
		[Attribute0]
		[Attribute2]
		public double LUA_ScenEdit_SetTime(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetTime");
			double result;
			try
			{
				result = PrivateMethods.smethod_30(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0.0;
			}
			return result;
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00261318 File Offset: 0x0025F518
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_SetWeather(int int_0, int int_1, float float_0, int int_2)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetWeather");
			bool result;
			try
			{
				result = PrivateMethods.smethod_15(int_0, int_1, float_0, int_2, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0026136C File Offset: 0x0025F56C
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_GetWeather()
		{
			this.ClearLuaErrorCondition("ScenEdit_GetWeather");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_16(this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x002613BC File Offset: 0x0025F5BC
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_SetSidePosture(string string_0, string string_1, string string_2)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetSidePosture");
			bool result;
			try
			{
				result = PrivateMethods.smethod_17(string_0, string_1, string_2, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x00261410 File Offset: 0x0025F610
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_SetSideOptions(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetSideOptions");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_18(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00261460 File Offset: 0x0025F660
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_SetUnitDamage(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetUnitDamage");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_20(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x002614B0 File Offset: 0x0025F6B0
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_SetSpecialAction(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetSpecialAction");
			bool result;
			try
			{
				result = Class448.smethod_4(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x00261500 File Offset: 0x0025F700
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_SetEMCON(string string_0, string string_1, string string_2)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetEMCON");
			bool result;
			try
			{
				result = PrivateMethods.smethod_21(string_0, string_1, string_2, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00010A5D File Offset: 0x0000EC5D
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_MsgBox(string string_0, int int_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_MsgBox");
			return PrivateMethods.smethod_22(string_0, int_0, this.ScenarioContext);
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00010A77 File Offset: 0x0000EC77
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_InputBox(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_InputBox");
			return PrivateMethods.smethod_23(string_0);
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00261554 File Offset: 0x0025F754
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_RunScript(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_RunScript");
			string path = Path.Combine(Class160.smethod_1().Info.DirectoryPath, "Lua") + "\\" + string_0;
			string result;
			try
			{
				string chunk;
				if (!File.Exists(path))
				{
					if (!string_0.Contains(GameGeneral.string_6))
					{
						throw new Exception3("File path '" + string_0 + "' not found");
					}
					chunk = File.ReadAllText(string_0);
					string text = "Script";
					object obj = this.currentFunction + " executing " + string_0;
					LuaUtility.smethod_34(ref text, ref obj, true);
				}
				else
				{
					chunk = File.ReadAllText(path);
					string text = "Script";
					object obj = this.currentFunction + " executing Lua\\" + string_0;
					LuaUtility.smethod_34(ref text, ref obj, true);
				}
				this.lua.DoString(chunk, string_0);
				result = "";
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00261654 File Offset: 0x0025F854
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_SetKeyValue(string key, object value, bool forCampaign = false)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetKeyValue");
			if (this.ScenarioContext.method_16() && forCampaign)
			{
				if (string.IsNullOrWhiteSpace(this.ScenarioContext.LuaXmlPassed))
				{
					this.ScenarioContext.LuaXmlPassed = "<KeyValueDatastore></KeyValueDatastore>";
				}
				XElement xelement = XElement.Parse(this.ScenarioContext.LuaXmlPassed);
				XElement xelement2 = xelement.Element(key);
				if (Information.IsNothing(xelement2))
				{
					xelement2 = new XElement(key, RuntimeHelpers.GetObjectValue(value));
					xelement.Add(xelement2);
				}
				else
				{
					xelement2.Value = value.ToString();
				}
				this.ScenarioContext.LuaXmlPassed = xelement.ToString();
			}
			else
			{
				if (forCampaign)
				{
					return "Not in campaign mode";
				}
				if (string.IsNullOrWhiteSpace(this.ScenarioContext.LuaXml))
				{
					this.ScenarioContext.LuaXml = "<KeyValueDatastore></KeyValueDatastore>";
				}
				XElement xelement = XElement.Parse(this.ScenarioContext.LuaXml);
				XElement xelement3 = xelement.Element(key);
				if (Information.IsNothing(xelement3))
				{
					xelement3 = new XElement(key, RuntimeHelpers.GetObjectValue(value));
					xelement.Add(xelement3);
				}
				else
				{
					xelement3.Value = value.ToString();
				}
				this.ScenarioContext.LuaXml = xelement.ToString();
			}
			return "Saved";
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x0026179C File Offset: 0x0025F99C
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_GetKeyValue(string key, bool forCampaign = false)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetKeyValue");
			XElement xelement;
			if (this.ScenarioContext.method_16() && forCampaign)
			{
				if (string.IsNullOrWhiteSpace(this.ScenarioContext.LuaXmlPassed))
				{
					this.ScenarioContext.LuaXmlPassed = "<KeyValueDatastore></KeyValueDatastore>";
				}
				xelement = XElement.Parse(this.ScenarioContext.LuaXmlPassed);
			}
			else
			{
				if (string.IsNullOrWhiteSpace(this.ScenarioContext.LuaXml))
				{
					this.ScenarioContext.LuaXml = "<KeyValueDatastore></KeyValueDatastore>";
				}
				xelement = XElement.Parse(this.ScenarioContext.LuaXml);
			}
			XElement xelement2 = xelement.Element(key);
			string result;
			if (Information.IsNothing(xelement2))
			{
				result = "";
			}
			else
			{
				result = xelement2.Value;
			}
			return result;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00261854 File Offset: 0x0025FA54
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_ClearKeyValue(string key, bool forCampaign = false)
		{
			this.ClearLuaErrorCondition("ScenEdit_ClearKeyValue");
			XElement xelement;
			if (this.ScenarioContext.method_16() && forCampaign)
			{
				if (Operators.CompareString(key, "", false) == 0)
				{
					this.ScenarioContext.LuaXmlPassed = null;
					return true;
				}
				if (string.IsNullOrWhiteSpace(this.ScenarioContext.LuaXmlPassed))
				{
					this.ScenarioContext.LuaXmlPassed = "<KeyValueDatastore></KeyValueDatastore>";
				}
				xelement = XElement.Parse(this.ScenarioContext.LuaXmlPassed);
			}
			else
			{
				if (forCampaign)
				{
					return false;
				}
				if (Operators.CompareString(key, "", false) == 0)
				{
					this.ScenarioContext.LuaXml = null;
					return true;
				}
				if (string.IsNullOrWhiteSpace(this.ScenarioContext.LuaXml))
				{
					this.ScenarioContext.LuaXml = "<KeyValueDatastore></KeyValueDatastore>";
				}
				xelement = XElement.Parse(this.ScenarioContext.LuaXml);
			}
			XElement xelement2 = xelement.Element(key);
			bool result;
			if (!Information.IsNothing(xelement2))
			{
				xelement2.Remove();
				if (forCampaign)
				{
					this.ScenarioContext.LuaXmlPassed = xelement.ToString();
				}
				else
				{
					this.ScenarioContext.LuaXml = xelement.ToString();
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00261978 File Offset: 0x0025FB78
		[Attribute0]
		[Attribute2]
		public LuaWrapper_ActiveUnit_SE LUA_ScenEdit_AddUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddUnit");
			LuaWrapper_ActiveUnit_SE result;
			try
			{
				result = PrivateMethods.smethod_33(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x002619C8 File Offset: 0x0025FBC8
		[Attribute0]
		[Attribute2]
		public LuaWrapper_ActiveUnit_SE LUA_ScenEdit_UpdateUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_UpdateUnit");
			LuaWrapper_ActiveUnit_SE result;
			try
			{
				result = PrivateMethods.smethod_34(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00261A18 File Offset: 0x0025FC18
		[Attribute0]
		[Attribute2]
		public LuaWrapper_ActiveUnit_SE LUA_ScenEdit_UpdateUnitCargo(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_UpdateUnitCargo");
			LuaWrapper_ActiveUnit_SE result;
			try
			{
				result = PrivateMethods.smethod_35(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x00261A68 File Offset: 0x0025FC68
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_AddExplosion(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddExplosion");
			bool result;
			try
			{
				result = PrivateMethods.smethod_7(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00261AB8 File Offset: 0x0025FCB8
		[Attribute0]
		[Attribute2]
		public LuaWrapper_ActiveUnit_SE LUA_ScenEdit_SetUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetUnit");
			LuaWrapper_ActiveUnit_SE result;
			try
			{
				result = PrivateMethods.smethod_38(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00261B08 File Offset: 0x0025FD08
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_GetTimeOfDay(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetTimeOfDay");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_57(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00261B58 File Offset: 0x0025FD58
		[Attribute0]
		[Attribute2]
		public LuaWrapper_ActiveUnit_SE LUA_ScenEdit_GetUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetUnit");
			LuaWrapper_ActiveUnit_SE result;
			try
			{
				result = PrivateMethods.smethod_36(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00261BA8 File Offset: 0x0025FDA8
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_DeleteUnit(LuaTable table, bool withGroup = false)
		{
			this.ClearLuaErrorCondition("ScenEdit_DeleteUnit");
			bool result;
			try
			{
				result = PrivateMethods.smethod_39(table, withGroup, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00261BFC File Offset: 0x0025FDFC
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_KillUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_KillUnit");
			bool result;
			try
			{
				result = PrivateMethods.smethod_40(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x00261C4C File Offset: 0x0025FE4C
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_SetUnitSide(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetUnitSide");
			bool result;
			try
			{
				result = PrivateMethods.smethod_41(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00261C9C File Offset: 0x0025FE9C
		[Attribute0]
		[Attribute2]
		public LuaWrapper_ReferencePoint LUA_ScenEdit_AddReferencePoint(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddReferencePoint");
			LuaWrapper_ReferencePoint result;
			try
			{
				result = Class478.smethod_0(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00261CEC File Offset: 0x0025FEEC
		[Attribute0]
		[Attribute2]
		public LuaWrapper_ReferencePoint LUA_ScenEdit_SetReferencePoint(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetReferencePoint");
			LuaWrapper_ReferencePoint result;
			try
			{
				result = Class478.smethod_1(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00261D3C File Offset: 0x0025FF3C
		[Attribute0]
		[Attribute2]
		public LuaWrapper_ReferencePoint LUA_ScenEdit_GetReferencePoint(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetReferencePoint");
			LuaWrapper_ReferencePoint result;
			try
			{
				result = Class478.smethod_2(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x00261D8C File Offset: 0x0025FF8C
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_GetReferencePoints(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetReferencePoints");
			LuaTable result;
			try
			{
				result = Class478.smethod_3(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x00261DDC File Offset: 0x0025FFDC
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_DeleteReferencePoint(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_DeleteReferencePoint");
			bool result;
			try
			{
				result = Class478.smethod_4(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x00261E2C File Offset: 0x0026002C
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_SetDoctrine(LuaTable luaTable_0, LuaTable luaTable_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetDoctrine");
			LuaTable result;
			try
			{
				result = Class469.smethod_0(luaTable_0, luaTable_1, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x00261E80 File Offset: 0x00260080
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_SetDoctrineWRA(LuaTable luaTable_0, LuaTable luaTable_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetDoctrineWRA");
			LuaTable result;
			try
			{
				result = Class469.smethod_3(luaTable_0, luaTable_1, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x00261ED4 File Offset: 0x002600D4
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_GetDoctrine(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetDoctrine");
			LuaTable result;
			try
			{
				result = Class469.smethod_1(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x00261F24 File Offset: 0x00260124
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_GetDoctrineWRA(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetDoctrineWRA");
			LuaTable result;
			try
			{
				result = Class469.smethod_2(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x00261F74 File Offset: 0x00260174
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_HostUnitToParent(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_HostUnitToParent");
			bool result;
			try
			{
				result = PrivateMethods.smethod_9(luaTable_0, this.ScenarioContext, this.UnitX);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00261FCC File Offset: 0x002601CC
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_GetSideOptions(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetSideOptions");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_28(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0026201C File Offset: 0x0026021C
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_GetSidePosture(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetSidePosture");
			string result;
			try
			{
				result = PrivateMethods.smethod_27(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00262070 File Offset: 0x00260270
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_GetSideIsHuman(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetSideIsHuman");
			bool result;
			try
			{
				result = PrivateMethods.smethod_29(string_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x002620C0 File Offset: 0x002602C0
		[Attribute2]
		public bool LUA_ScenEdit_UseAttachment(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_UseAttachment");
			bool result;
			try
			{
				result = Class508.smethod_0(string_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x00262110 File Offset: 0x00260310
		[Attribute2]
		public bool LUA_ScenEdit_UseAttachmentOnSide(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_UseAttachmentOnSide");
			bool result;
			try
			{
				result = Class508.smethod_1(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x00262164 File Offset: 0x00260364
		[Attribute2]
		public bool LUA_ScenEdit_PlaySound(string FileName, int delay = 0)
		{
			this.ClearLuaErrorCondition("ScenEdit_PlaySound");
			bool result;
			try
			{
				result = PrivateMethods.smethod_25(FileName, delay);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x002621B0 File Offset: 0x002603B0
		[Attribute2]
		public string LUA_ScenEdit_PlayVideo(string FileName, bool FullScreen = true, int delay = 0)
		{
			this.ClearLuaErrorCondition("ScenEdit_PlayVideo");
			string result;
			try
			{
				result = PrivateMethods.smethod_24(FileName, FullScreen, delay);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x002621FC File Offset: 0x002603FC
		[Attribute0]
		[Attribute2]
		public int LUA_ScenEdit_GetScore(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetScore");
			int result;
			try
			{
				result = PrivateMethods.smethod_26(string_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x0026224C File Offset: 0x0026044C
		[Attribute0]
		[Attribute2]
		public int LUA_ScenEdit_SetScore(string string_0, int int_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetScore");
			int result;
			try
			{
				result = PrivateMethods.smethod_31(string_0, int_0, this.ScenarioContext, string_1);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00010A8A File Offset: 0x0000EC8A
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_GetScenHasStarted()
		{
			this.ClearLuaErrorCondition("ScenEdit_GetScenHasStarted");
			return this.ScenarioContext.method_26();
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x002622A0 File Offset: 0x002604A0
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_SetLoadout(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetLoadout");
			bool result;
			try
			{
				result = PrivateMethods.smethod_13(luaTable_0, this.ScenarioContext, this.UnitX);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x002622F8 File Offset: 0x002604F8
		[Attribute0]
		[Attribute2]
		public int LUA_ScenEdit_SpecialMessage(string SideNameOrID, string Text, LuaTable location = null)
		{
			this.ClearLuaErrorCondition("ScenEdit_SpecialMessage");
			int result;
			try
			{
				result = PrivateMethods.smethod_32(SideNameOrID, Text, this.ScenarioContext, location);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00010AA2 File Offset: 0x0000ECA2
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_PlayerSide()
		{
			this.ClearLuaErrorCondition("ScenEdit_PlayerSide");
			return this.ScenarioContext.method_54().method_51();
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00010ABF File Offset: 0x0000ECBF
		[Attribute0]
		[Attribute2]
		public int LUA_ScenEdit_EndScenario()
		{
			this.ClearLuaErrorCondition("ScenEdit_EndScenario");
			this.ScenarioContext.method_48();
			return 1;
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x0026234C File Offset: 0x0026054C
		[Attribute0]
		[Attribute2]
		public int LUA_ScenEdit_ExportInst(string string_0, LuaTable luaTable_0, LuaTable luaTable_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_ExportInst");
			int result;
			try
			{
				result = Class507.smethod_1(string_0, luaTable_0, luaTable_1, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x002623A0 File Offset: 0x002605A0
		[Attribute0]
		[Attribute2]
		public int LUA_ScenEdit_ImportInst(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_ImportInst");
			int result;
			try
			{
				result = Class507.smethod_0(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x002623F4 File Offset: 0x002605F4
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Side LUA_ScenEdit_AddSide(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddSide");
			LuaWrapper_Side result;
			try
			{
				result = PrivateMethods.smethod_48(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x00262444 File Offset: 0x00260644
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Side LUA_ScenEdit_RemoveSide(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_RemoveSide");
			LuaWrapper_Side result;
			try
			{
				result = PrivateMethods.smethod_49(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x00262494 File Offset: 0x00260694
		[Attribute0]
		[Attribute2]
		public int LUA_World_GetElevation(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("World_GetElevation");
			int result;
			try
			{
				result = PrivateMethods.smethod_63(luaTable_0);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x002624E0 File Offset: 0x002606E0
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_World_GetCircleFromPoint(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("World_GetCircleFromPoint");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_64(luaTable_0);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0026252C File Offset: 0x0026072C
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_World_GetPointFromBearing(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("World_GetPointFromBearing");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_65(luaTable_0);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00262578 File Offset: 0x00260778
		[Attribute0]
		[Attribute2]
		public int LUA_ScenEdit_AddReloadsToUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddReloadsToUnit");
			int result;
			try
			{
				result = PrivateMethods.smethod_42(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x002625C8 File Offset: 0x002607C8
		[Attribute0]
		[Attribute2]
		public int LUA_ScenEdit_AddWeaponToUnitMagazine(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddWeaponToUnitMagazine");
			int result;
			try
			{
				result = PrivateMethods.smethod_43(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00262618 File Offset: 0x00260818
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_RefuelUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_RefuelUnit");
			string result;
			try
			{
				result = PrivateMethods.smethod_45(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00262668 File Offset: 0x00260868
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Mission LUA_ScenEdit_AddMission(string string_0, string string_1, string string_2, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddMission");
			LuaWrapper_Mission result;
			try
			{
				result = Class461.smethod_1(string_0, string_1, string_2, luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x002626BC File Offset: 0x002608BC
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Mission LUA_ScenEdit_GetMission(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetMission");
			LuaWrapper_Mission result;
			try
			{
				result = Class461.smethod_0(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x00262710 File Offset: 0x00260910
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_DeleteMission(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_DeleteMission");
			bool result;
			try
			{
				result = Class461.smethod_2(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00262764 File Offset: 0x00260964
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Mission LUA_ScenEdit_SetMission(string string_0, string string_1, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetMission");
			LuaWrapper_Mission result;
			try
			{
				result = Class461.smethod_5(string_0, string_1, luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x002627B8 File Offset: 0x002609B8
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_ImportMission(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_ImportMission");
			LuaTable result;
			try
			{
				result = Class461.smethod_4(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x0026280C File Offset: 0x00260A0C
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_FillMagsForLoadout(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_FillMagsForLoadout");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_19(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x0026285C File Offset: 0x00260A5C
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_ExportMission(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_ExportMission");
			LuaTable result;
			try
			{
				result = Class461.smethod_3(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x002628B0 File Offset: 0x00260AB0
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_ImportScenarioFromXML(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_ImportScenarioFromXML");
			bool result;
			try
			{
				if (!GameGeneral.smethod_6())
				{
					throw new Exception3("This method is available only in Command PE.");
				}
				result = PrivateMethods.smethod_11(ref this.ScenarioContext, luaTable_0);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00262914 File Offset: 0x00260B14
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_ExportScenarioToXML()
		{
			this.ClearLuaErrorCondition("ScenEdit_ExportScenarioToXML");
			string result;
			try
			{
				if (!GameGeneral.smethod_6())
				{
					throw new Exception3("This method is available only in Command PE.");
				}
				result = PrivateMethods.smethod_10(this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00262978 File Offset: 0x00260B78
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_AssignUnitAsTarget(object object_0, string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AssignUnitAsTarget");
			LuaTable result;
			try
			{
				result = Class461.smethod_6(RuntimeHelpers.GetObjectValue(object_0), string_0, this.ScenarioContext, this.UnitX);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x002629D4 File Offset: 0x00260BD4
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_RemoveUnitAsTarget(object object_0, string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_RemoveUnitAsTarget");
			LuaTable result;
			try
			{
				result = Class461.smethod_7(RuntimeHelpers.GetObjectValue(object_0), string_0, this.ScenarioContext, this.UnitX);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x00262A30 File Offset: 0x00260C30
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_GetContacts(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetContacts");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_46(string_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x00262A80 File Offset: 0x00260C80
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Contact LUA_ScenEdit_GetContact(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_Contact");
			LuaWrapper_Contact result;
			try
			{
				result = PrivateMethods.smethod_37(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00262AD0 File Offset: 0x00260CD0
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_ExecuteEventAction(string string_0)
		{
			string text = null;
			this.ClearLuaErrorCondition("ScenEdit_ExecuteEventAction");
			try
			{
				text = Class448.smethod_0(string_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				return null;
			}
			string result;
			if (text != null && Operators.CompareString(text, "", false) != 0)
			{
				try
				{
					this.lua.DoString(text, string_0);
				}
				catch (Exception ex2)
				{
					if (this.RunInteractive)
					{
						throw;
					}
					return null;
				}
				result = "OK";
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00262B78 File Offset: 0x00260D78
		[Attribute0]
		[Attribute2]
		public string LUA_ScenEdit_ExecuteSpecialAction(string string_0)
		{
			string text = null;
			this.ClearLuaErrorCondition("ScenEdit_ExecuteSpecialAction");
			try
			{
				text = Class448.smethod_6(string_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				return null;
			}
			string result;
			if (text != null && Operators.CompareString(text, "", false) != 0)
			{
				try
				{
					this.lua.DoString(text, string_0);
				}
				catch (Exception ex2)
				{
					if (this.RunInteractive)
					{
						throw;
					}
					return null;
				}
				result = "OK";
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00262C20 File Offset: 0x00260E20
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Zone LUA_ScenEdit_AddZone(string string_0, int int_0, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddZone");
			LuaWrapper_Zone result;
			try
			{
				result = PrivateMethods.smethod_50(string_0, int_0, luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00262C74 File Offset: 0x00260E74
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Zone LUA_ScenEdit_RemoveZone(string string_0, int int_0, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_RemoveZone");
			LuaWrapper_Zone result;
			try
			{
				result = PrivateMethods.smethod_52(string_0, int_0, luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x00262CC8 File Offset: 0x00260EC8
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Zone LUA_ScenEdit_SetZone(string string_0, int int_0, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetZone");
			LuaWrapper_Zone result;
			try
			{
				result = PrivateMethods.smethod_51(string_0, int_0, luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00262D1C File Offset: 0x00260F1C
		[Attribute0]
		[Attribute2]
		public object LUA_ScenEdit_SetEvent(string string_0, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetEvent");
			object result;
			try
			{
				result = Class448.smethod_7(string_0, luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x00262D70 File Offset: 0x00260F70
		[Attribute0]
		[Attribute2]
		public object LUA_ScenEdit_SetTrigger(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetTrigger");
			object result;
			try
			{
				result = Class448.smethod_8(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x00262DC0 File Offset: 0x00260FC0
		[Attribute0]
		[Attribute2]
		public object LUA_ScenEdit_SetCondition(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetCondition");
			object result;
			try
			{
				result = Class448.smethod_9(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x00262E10 File Offset: 0x00261010
		[Attribute0]
		[Attribute2]
		public object LUA_ScenEdit_SetAction(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetAction");
			object result;
			try
			{
				result = Class448.smethod_10(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x00262E60 File Offset: 0x00261060
		[Attribute0]
		[Attribute2]
		public object LUA_ScenEdit_SetEventTrigger(string string_0, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetEventTrigger");
			object result;
			try
			{
				result = Class448.smethod_11(string_0, luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x00262EB4 File Offset: 0x002610B4
		[Attribute0]
		[Attribute2]
		public object LUA_ScenEdit_SetEventCondition(string string_0, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetEventCondition");
			object result;
			try
			{
				result = Class448.smethod_12(string_0, luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x00262F08 File Offset: 0x00261108
		[Attribute0]
		[Attribute2]
		public object LUA_ScenEdit_SetEventAction(string string_0, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetEventAction");
			object result;
			try
			{
				result = Class448.smethod_13(string_0, luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00262F5C File Offset: 0x0026115C
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Event LUA_ScenEdit_GetEvent(string eventName, int level = 0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetEvent");
			LuaWrapper_Event result;
			try
			{
				result = Class448.smethod_2(eventName, level, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x00262FB0 File Offset: 0x002611B0
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_GetEvents(string eventName, int level = 0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetEvents");
			LuaTable result;
			try
			{
				result = Class448.smethod_3(level, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00263000 File Offset: 0x00261200
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_GetSpecialAction(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetSpecialAction");
			LuaTable result;
			try
			{
				result = Class448.smethod_5(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x00263050 File Offset: 0x00261250
		[Attribute0]
		[Attribute2]
		public object LUA_ScenEdit_UpdateEvent(string string_0, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit__UpdateEvent");
			object result;
			try
			{
				result = Class448.smethod_1(string_0, luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x002630A4 File Offset: 0x002612A4
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_AttackContact(string string_0, string string_1, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AttackContact");
			bool result;
			try
			{
				result = PrivateMethods.smethod_47(string_0, string_1, luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x002630F8 File Offset: 0x002612F8
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_TransferCargo(string string_0, string string_1, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_TransferCargo");
			bool result;
			try
			{
				result = PrivateMethods.smethod_53(string_0, string_1, luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x0026314C File Offset: 0x0026134C
		[Attribute0]
		[Attribute2]
		public bool LUA_ScenEdit_UnloadCargo(string fromUnit, LuaTable cargo = null)
		{
			this.ClearLuaErrorCondition("ScenEdit_UnloadCargo");
			bool result;
			try
			{
				result = PrivateMethods.smethod_54(fromUnit, cargo, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x002631A0 File Offset: 0x002613A0
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_GetFormation(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetFormation");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_55(luaTable_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x002631F0 File Offset: 0x002613F0
		[Attribute0]
		[Attribute2]
		public LuaWrapper_Device_Loadout LUA_ScenEdit_GetLoadout(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetLoadout");
			LuaWrapper_Device_Loadout result;
			try
			{
				result = PrivateMethods.smethod_14(luaTable_0, this.ScenarioContext, this.UnitX);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00263248 File Offset: 0x00261448
		[Attribute0]
		[Attribute2]
		public object LUA_ScenEdit_QueryDB(string string_0, int int_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_QueryDB");
			object result;
			try
			{
				result = PrivateMethods.smethod_58(string_0, int_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0026329C File Offset: 0x0026149C
		[Attribute0]
		[Attribute2]
		public LuaTable LUA_ScenEdit_SelectedUnits()
		{
			this.ClearLuaErrorCondition("ScenEdit_SelectedUnits");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_56(this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x002632EC File Offset: 0x002614EC
		[Attribute0]
		[Attribute2]
		public bool LUA_VP_ExportUnits(LuaTable luaTable_0, string string_0)
		{
			this.ClearLuaErrorCondition("VP_ExportUnits");
			bool result;
			try
			{
				result = PrivateMethods.smethod_62(luaTable_0, string_0, this.ScenarioContext);
			}
			catch (Exception ex)
			{
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x00263340 File Offset: 0x00261540
		[Attribute0]
		[Attribute2]
		public string Tool_DumpEvents()
		{
			this.ClearLuaErrorCondition("Tool_DumpEvents");
			string text = Class448.smethod_14(true, this.ScenarioContext);
			if (!Directory.Exists(Class160.smethod_1().Info.DirectoryPath + "\\Scenarios"))
			{
				Directory.CreateDirectory(Class160.smethod_1().Info.DirectoryPath + "\\Scenarios");
			}
			StreamWriter streamWriter = new StreamWriter(Class160.smethod_1().Info.DirectoryPath + "\\Scenarios\\" + this.ScenarioContext.FileName + " events.xml");
			using (streamWriter)
			{
				streamWriter.Write(text);
			}
			return text;
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		[Attribute0]
		[Attribute2]
		public bool Tool_EmulateNoConsole(bool mode = true)
		{
			this.ClearLuaErrorCondition("Tool_EmulateNoConsole");
			this.RunInteractive = !mode;
			return this.RunInteractive;
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x002633FC File Offset: 0x002615FC
		[Attribute0]
		[Attribute2]
		public double Tool_Range(object object_0, object object_1)
		{
			this.ClearLuaErrorCondition("Tool_Range");
			GeoPoint geoPoint = null;
			GeoPoint geoPoint2 = null;
			if (object_0 is LuaTable)
			{
				LuaTable luaTable = (LuaTable)object_0;
				Dictionary<string, object> dictionary_ = LuaUtility.smethod_1(luaTable.GetEnumerator());
				double? num = LuaUtility.smethod_13(dictionary_);
				double? num2 = LuaUtility.smethod_11(dictionary_);
				if (num == null | num == null)
				{
					throw new Exception3("From table object " + LuaUtility.smethod_33(luaTable) + " needs latitude and longitude.");
				}
				geoPoint = new GeoPoint(num.Value, num2.Value);
			}
			if (object_1 is LuaTable)
			{
				LuaTable luaTable2 = (LuaTable)object_1;
				Dictionary<string, object> dictionary_2 = LuaUtility.smethod_1(luaTable2.GetEnumerator());
				double? num3 = LuaUtility.smethod_13(dictionary_2);
				double? num4 = LuaUtility.smethod_11(dictionary_2);
				if (num3 == null | num3 == null)
				{
					throw new Exception3("To table object " + LuaUtility.smethod_33(luaTable2) + " needs latitude and longitude.");
				}
				geoPoint2 = new GeoPoint(num3.Value, num4.Value);
			}
			if (object_0 is string)
			{
				string text = Conversions.ToString(object_0);
				ActiveUnit activeUnit = null;
				Contact contact = null;
				try
				{
					activeUnit = this.ScenarioContext.vmethod_0()[text];
				}
				catch (Exception ex)
				{
				}
				if (activeUnit == null)
				{
					try
					{
						contact = PrivateMethods.smethod_69(text, this.ScenarioContext);
					}
					catch (Exception ex2)
					{
					}
				}
				if (activeUnit == null & contact == null)
				{
					throw new Exception3("Can't find guid " + text);
				}
				if (activeUnit != null)
				{
					double double_ = activeUnit.vmethod_28(null);
					double double_2 = activeUnit.vmethod_30(null);
					geoPoint = new GeoPoint(double_, double_2);
				}
				else if (contact != null)
				{
					double double_3 = contact.vmethod_28(null);
					double double_4 = contact.vmethod_30(null);
					geoPoint = new GeoPoint(double_3, double_4);
				}
			}
			if (object_1 is string)
			{
				string text2 = Conversions.ToString(object_1);
				ActiveUnit activeUnit2 = null;
				Contact contact2 = null;
				try
				{
					activeUnit2 = this.ScenarioContext.vmethod_0()[text2];
				}
				catch (Exception ex3)
				{
				}
				if (activeUnit2 == null)
				{
					try
					{
						contact2 = PrivateMethods.smethod_69(text2, this.ScenarioContext);
					}
					catch (Exception ex4)
					{
					}
				}
				if (activeUnit2 == null & contact2 == null)
				{
					throw new Exception3("Can't find guid " + text2);
				}
				if (activeUnit2 != null)
				{
					double double_5 = activeUnit2.vmethod_28(null);
					double double_6 = activeUnit2.vmethod_30(null);
					geoPoint2 = new GeoPoint(double_5, double_6);
				}
				else if (contact2 != null)
				{
					double double_7 = contact2.vmethod_28(null);
					double double_8 = contact2.vmethod_30(null);
					geoPoint2 = new GeoPoint(double_7, double_8);
				}
			}
			if (geoPoint == null || geoPoint2 == null)
			{
				throw new Exception3("No points have been set");
			}
			return Class410.smethod_2(geoPoint.imethod_2(), geoPoint.imethod_0(), geoPoint2.imethod_2(), geoPoint2.imethod_0());
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x0026372C File Offset: 0x0026192C
		[Attribute0]
		[Attribute2]
		public double Tool_Bearing(object object_0, object object_1)
		{
			this.ClearLuaErrorCondition("Tool_Bearing");
			GeoPoint geoPoint = null;
			GeoPoint geoPoint2 = null;
			if (object_0 is LuaTable)
			{
				LuaTable luaTable = (LuaTable)object_0;
				Dictionary<string, object> dictionary_ = LuaUtility.smethod_1(luaTable.GetEnumerator());
				double? num = LuaUtility.smethod_13(dictionary_);
				double? num2 = LuaUtility.smethod_11(dictionary_);
				if (num == null | num == null)
				{
					throw new Exception3("From table object " + LuaUtility.smethod_33(luaTable) + " needs latitude and longitude.");
				}
				geoPoint = new GeoPoint(num.Value, num2.Value);
			}
			if (object_1 is LuaTable)
			{
				LuaTable luaTable2 = (LuaTable)object_1;
				Dictionary<string, object> dictionary_2 = LuaUtility.smethod_1(luaTable2.GetEnumerator());
				double? num3 = LuaUtility.smethod_13(dictionary_2);
				double? num4 = LuaUtility.smethod_11(dictionary_2);
				if (num3 == null | num3 == null)
				{
					throw new Exception3("To table object " + LuaUtility.smethod_33(luaTable2) + " needs latitude and longitude.");
				}
				geoPoint2 = new GeoPoint(num3.Value, num4.Value);
			}
			if (object_0 is string)
			{
				string text = Conversions.ToString(object_0);
				ActiveUnit activeUnit = null;
				Contact contact = null;
				try
				{
					activeUnit = this.ScenarioContext.vmethod_0()[text];
				}
				catch (Exception ex)
				{
				}
				if (activeUnit == null)
				{
					try
					{
						contact = PrivateMethods.smethod_69(text, this.ScenarioContext);
					}
					catch (Exception ex2)
					{
					}
				}
				if (activeUnit == null & contact == null)
				{
					throw new Exception3("Can't find guid " + text);
				}
				if (activeUnit != null)
				{
					double double_ = activeUnit.vmethod_28(null);
					double double_2 = activeUnit.vmethod_30(null);
					geoPoint = new GeoPoint(double_, double_2);
				}
				else if (contact != null)
				{
					double double_3 = contact.vmethod_28(null);
					double double_4 = contact.vmethod_30(null);
					geoPoint = new GeoPoint(double_3, double_4);
				}
			}
			if (object_1 is string)
			{
				string text2 = Conversions.ToString(object_1);
				ActiveUnit activeUnit2 = null;
				Contact contact2 = null;
				try
				{
					activeUnit2 = this.ScenarioContext.vmethod_0()[text2];
				}
				catch (Exception ex3)
				{
				}
				if (activeUnit2 == null)
				{
					try
					{
						contact2 = PrivateMethods.smethod_69(text2, this.ScenarioContext);
					}
					catch (Exception ex4)
					{
					}
				}
				if (activeUnit2 == null & contact2 == null)
				{
					throw new Exception3("Can't find guid " + text2);
				}
				if (activeUnit2 != null)
				{
					double double_5 = activeUnit2.vmethod_28(null);
					double double_6 = activeUnit2.vmethod_30(null);
					geoPoint2 = new GeoPoint(double_5, double_6);
				}
				else if (contact2 != null)
				{
					double double_7 = contact2.vmethod_28(null);
					double double_8 = contact2.vmethod_30(null);
					geoPoint2 = new GeoPoint(double_7, double_8);
				}
			}
			if (geoPoint == null || geoPoint2 == null)
			{
				throw new Exception3("No points have been set");
			}
			double result = (double)Math2.smethod_17(geoPoint.imethod_2(), geoPoint.imethod_0(), geoPoint2.imethod_2(), geoPoint2.imethod_0());
			double num5 = (double)Math2.smethod_15(geoPoint.imethod_2(), geoPoint.imethod_0(), geoPoint2.imethod_2(), geoPoint2.imethod_0());
			return result;
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x00010AF5 File Offset: 0x0000ECF5
		private void SetUpAliases()
		{
			this.AliasString.Append("SE_GetUnit=ScenEdit_GetUnit\r\nSE_SetUnit=ScenEdit_SetUnit");
		}

		// Token: 0x04001D35 RID: 7477
		private bool initalLoad;

		// Token: 0x04001D36 RID: 7478
		public static List<string> LuaMethods = new List<string>();

		// Token: 0x04001D38 RID: 7480
		private NLua.Lua lua;

		// Token: 0x04001D39 RID: 7481
		private StringBuilder SecurityString;

		// Token: 0x04001D3A RID: 7482
		private StringBuilder AliasString;

		// Token: 0x04001D3B RID: 7483
		private Scenario ScenarioContext;

		// Token: 0x04001D3C RID: 7484
		public ActiveUnit UnitX;

		// Token: 0x04001D3D RID: 7485
		public ActiveUnit UnitY;

		// Token: 0x04001D3E RID: 7486
		public Contact UnitC;

		// Token: 0x04001D3F RID: 7487
		public List<Sensor> SensorsThatMadeDetection;

		// Token: 0x04001D40 RID: 7488
		public SimEvent EventX;

		// Token: 0x04001D41 RID: 7489
		public LuaEnuNames enumTable;

		// Token: 0x04001D42 RID: 7490
		public static bool _lua_event = false;

		// Token: 0x04001D43 RID: 7491
		public static bool _lua_console = true;

		// Token: 0x04001D44 RID: 7492
		public string currentFunction;

		// Token: 0x04001D45 RID: 7493
		public int currentLine;

		// Token: 0x04001D46 RID: 7494
		public string lastError;

		// Token: 0x04001D47 RID: 7495
		public bool RunInteractive;

		// Token: 0x04001D48 RID: 7496
		public CMANO luaDynamicFunctions;

		// Token: 0x04001D49 RID: 7497
		private static LuaSandBox _LuaSandbox;

		// Token: 0x02000455 RID: 1109
		// (Invoke) Token: 0x06002225 RID: 8741
		public delegate void LuaPrintEventHandler(object obj);
	}
}
