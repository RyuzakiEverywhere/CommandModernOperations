using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Command_Core.DAL;
using Command_Core.Lua;
using DarkUI.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns12;
using ns13;
using ns14;
using ns32;
using ns5;
using ns8;
using ns9;

namespace Command_Core
{
	// Token: 0x020002FB RID: 763
	[Serializable]
	public sealed class Scenario
	{
		// Token: 0x0600168A RID: 5770 RVA: 0x0000BF50 File Offset: 0x0000A150
		[CompilerGenerated]
		public ObservableDictionary<string, ActiveUnit> vmethod_0()
		{
			return this._ActiveUnits;
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x001A3510 File Offset: 0x001A1710
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_1(ObservableDictionary<string, ActiveUnit> observableDictionary_0)
		{
			INotifyDictionaryChanged<string, ActiveUnit>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<string, ActiveUnit>.DictionaryChangedEventHandler(this.method_88);
			ObservableDictionary<string, ActiveUnit> activeUnits = this._ActiveUnits;
			if (activeUnits != null)
			{
				activeUnits.DictionaryChanged -= obj;
			}
			this._ActiveUnits = observableDictionary_0;
			activeUnits = this._ActiveUnits;
			if (activeUnits != null)
			{
				activeUnits.DictionaryChanged += obj;
			}
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0000BF58 File Offset: 0x0000A158
		[CompilerGenerated]
		public ObservableDictionary<string, ScenAttachmentObject> vmethod_2()
		{
			return this._ScenAttachments;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x001A3554 File Offset: 0x001A1754
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_3(ObservableDictionary<string, ScenAttachmentObject> observableDictionary_0)
		{
			INotifyDictionaryChanged<string, ScenAttachmentObject>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<string, ScenAttachmentObject>.DictionaryChangedEventHandler(this.method_94);
			ObservableDictionary<string, ScenAttachmentObject> scenAttachments = this._ScenAttachments;
			if (scenAttachments != null)
			{
				scenAttachments.DictionaryChanged -= obj;
			}
			this._ScenAttachments = observableDictionary_0;
			scenAttachments = this._ScenAttachments;
			if (scenAttachments != null)
			{
				scenAttachments.DictionaryChanged += obj;
			}
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0000BF60 File Offset: 0x0000A160
		[CompilerGenerated]
		public ObservableDictionary<string, EventTrigger> vmethod_4()
		{
			return this._EventTriggers;
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x001A3598 File Offset: 0x001A1798
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_5(ObservableDictionary<string, EventTrigger> observableDictionary_0)
		{
			INotifyDictionaryChanged<string, EventTrigger>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<string, EventTrigger>.DictionaryChangedEventHandler(this.method_90);
			ObservableDictionary<string, EventTrigger> eventTriggers = this._EventTriggers;
			if (eventTriggers != null)
			{
				eventTriggers.DictionaryChanged -= obj;
			}
			this._EventTriggers = observableDictionary_0;
			eventTriggers = this._EventTriggers;
			if (eventTriggers != null)
			{
				eventTriggers.DictionaryChanged += obj;
			}
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0000BF68 File Offset: 0x0000A168
		[CompilerGenerated]
		public ObservableDictionary<string, EventCondition> vmethod_6()
		{
			return this._EventConditions;
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x001A35DC File Offset: 0x001A17DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_7(ObservableDictionary<string, EventCondition> observableDictionary_0)
		{
			INotifyDictionaryChanged<string, EventCondition>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<string, EventCondition>.DictionaryChangedEventHandler(this.method_91);
			ObservableDictionary<string, EventCondition> eventConditions = this._EventConditions;
			if (eventConditions != null)
			{
				eventConditions.DictionaryChanged -= obj;
			}
			this._EventConditions = observableDictionary_0;
			eventConditions = this._EventConditions;
			if (eventConditions != null)
			{
				eventConditions.DictionaryChanged += obj;
			}
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x0000BF70 File Offset: 0x0000A170
		[CompilerGenerated]
		public ObservableDictionary<string, EventAction> vmethod_8()
		{
			return this._EventActions;
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x001A3620 File Offset: 0x001A1820
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_9(ObservableDictionary<string, EventAction> observableDictionary_0)
		{
			INotifyDictionaryChanged<string, EventAction>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<string, EventAction>.DictionaryChangedEventHandler(this.method_92);
			ObservableDictionary<string, EventAction> eventActions = this._EventActions;
			if (eventActions != null)
			{
				eventActions.DictionaryChanged -= obj;
			}
			this._EventActions = observableDictionary_0;
			eventActions = this._EventActions;
			if (eventActions != null)
			{
				eventActions.DictionaryChanged += obj;
			}
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0000BF78 File Offset: 0x0000A178
		[CompilerGenerated]
		public ObservableDictionary<string, SimEvent> vmethod_10()
		{
			return this._SimEvents;
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0000BF80 File Offset: 0x0000A180
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_11(ObservableDictionary<string, SimEvent> observableDictionary_0)
		{
			this._SimEvents = observableDictionary_0;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0000BF89 File Offset: 0x0000A189
		[CompilerGenerated]
		public ObservableList<Explosion> vmethod_12()
		{
			return this._Explosions;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x001A3664 File Offset: 0x001A1864
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_13(ObservableList<Explosion> observableList_0)
		{
			EventHandler<EventArgs5<Explosion>> eventHandler_ = new EventHandler<EventArgs5<Explosion>>(this.method_98);
			ObservableList<Explosion> explosions = this._Explosions;
			if (explosions != null)
			{
				explosions.method_1(eventHandler_);
			}
			this._Explosions = observableList_0;
			explosions = this._Explosions;
			if (explosions != null)
			{
				explosions.method_0(eventHandler_);
			}
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0000BF91 File Offset: 0x0000A191
		[CompilerGenerated]
		public ObservableList<WeaponImpact> vmethod_14()
		{
			return this._WeaponImpacts;
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x001A36A8 File Offset: 0x001A18A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_15(ObservableList<WeaponImpact> observableList_0)
		{
			EventHandler<EventArgs5<WeaponImpact>> eventHandler_ = new EventHandler<EventArgs5<WeaponImpact>>(this.method_97);
			ObservableList<WeaponImpact> weaponImpacts = this._WeaponImpacts;
			if (weaponImpacts != null)
			{
				weaponImpacts.method_1(eventHandler_);
			}
			this._WeaponImpacts = observableList_0;
			weaponImpacts = this._WeaponImpacts;
			if (weaponImpacts != null)
			{
				weaponImpacts.method_0(eventHandler_);
			}
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0000BF99 File Offset: 0x0000A199
		[CompilerGenerated]
		public List<WaterSplash> vmethod_16()
		{
			return this._WaterSplashes;
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0000BFA1 File Offset: 0x0000A1A1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_17(List<WaterSplash> list_0)
		{
			this._WaterSplashes = list_0;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x0000BFAA File Offset: 0x0000A1AA
		[CompilerGenerated]
		public List<GroundImpact> vmethod_18()
		{
			return this._GroundImpacts;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x0000BFB2 File Offset: 0x0000A1B2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_19(List<GroundImpact> list_0)
		{
			this._GroundImpacts = list_0;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0000BFBB File Offset: 0x0000A1BB
		[CompilerGenerated]
		public ObservableDictionary<string, UnguidedWeapon> vmethod_20()
		{
			return this._UnguidedWeapons;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x001A36EC File Offset: 0x001A18EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_21(ObservableDictionary<string, UnguidedWeapon> observableDictionary_0)
		{
			INotifyDictionaryChanged<string, UnguidedWeapon>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<string, UnguidedWeapon>.DictionaryChangedEventHandler(this.method_89);
			ObservableDictionary<string, UnguidedWeapon> unguidedWeapons = this._UnguidedWeapons;
			if (unguidedWeapons != null)
			{
				unguidedWeapons.DictionaryChanged -= obj;
			}
			this._UnguidedWeapons = observableDictionary_0;
			unguidedWeapons = this._UnguidedWeapons;
			if (unguidedWeapons != null)
			{
				unguidedWeapons.DictionaryChanged += obj;
			}
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x001A3730 File Offset: 0x001A1930
		[CompilerGenerated]
		public static void smethod_0(Scenario.TitleChangedEventHandler titleChangedEventHandler_0)
		{
			Scenario.TitleChangedEventHandler titleChangedEventHandler = Scenario.TitleChangedEvent;
			Scenario.TitleChangedEventHandler titleChangedEventHandler2;
			do
			{
				titleChangedEventHandler2 = titleChangedEventHandler;
				Scenario.TitleChangedEventHandler value = (Scenario.TitleChangedEventHandler)Delegate.Combine(titleChangedEventHandler2, titleChangedEventHandler_0);
				titleChangedEventHandler = Interlocked.CompareExchange<Scenario.TitleChangedEventHandler>(ref Scenario.TitleChangedEvent, value, titleChangedEventHandler2);
			}
			while (titleChangedEventHandler != titleChangedEventHandler2);
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x001A3764 File Offset: 0x001A1964
		[CompilerGenerated]
		public static void smethod_1(Scenario.CurrentScenarioChangedEventHandler currentScenarioChangedEventHandler_0)
		{
			Scenario.CurrentScenarioChangedEventHandler currentScenarioChangedEventHandler = Scenario.CurrentScenarioChangedEvent;
			Scenario.CurrentScenarioChangedEventHandler currentScenarioChangedEventHandler2;
			do
			{
				currentScenarioChangedEventHandler2 = currentScenarioChangedEventHandler;
				Scenario.CurrentScenarioChangedEventHandler value = (Scenario.CurrentScenarioChangedEventHandler)Delegate.Combine(currentScenarioChangedEventHandler2, currentScenarioChangedEventHandler_0);
				currentScenarioChangedEventHandler = Interlocked.CompareExchange<Scenario.CurrentScenarioChangedEventHandler>(ref Scenario.CurrentScenarioChangedEvent, value, currentScenarioChangedEventHandler2);
			}
			while (currentScenarioChangedEventHandler != currentScenarioChangedEventHandler2);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x001A3798 File Offset: 0x001A1998
		[CompilerGenerated]
		public static void smethod_2(Scenario.CurrentSideChangedEventHandler currentSideChangedEventHandler_0)
		{
			Scenario.CurrentSideChangedEventHandler currentSideChangedEventHandler = Scenario.CurrentSideChangedEvent;
			Scenario.CurrentSideChangedEventHandler currentSideChangedEventHandler2;
			do
			{
				currentSideChangedEventHandler2 = currentSideChangedEventHandler;
				Scenario.CurrentSideChangedEventHandler value = (Scenario.CurrentSideChangedEventHandler)Delegate.Combine(currentSideChangedEventHandler2, currentSideChangedEventHandler_0);
				currentSideChangedEventHandler = Interlocked.CompareExchange<Scenario.CurrentSideChangedEventHandler>(ref Scenario.CurrentSideChangedEvent, value, currentSideChangedEventHandler2);
			}
			while (currentSideChangedEventHandler != currentSideChangedEventHandler2);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x001A37CC File Offset: 0x001A19CC
		[CompilerGenerated]
		public static void smethod_3(Scenario.SidesChangedEventHandler sidesChangedEventHandler_0)
		{
			Scenario.SidesChangedEventHandler sidesChangedEventHandler = Scenario.SidesChangedEvent;
			Scenario.SidesChangedEventHandler sidesChangedEventHandler2;
			do
			{
				sidesChangedEventHandler2 = sidesChangedEventHandler;
				Scenario.SidesChangedEventHandler value = (Scenario.SidesChangedEventHandler)Delegate.Combine(sidesChangedEventHandler2, sidesChangedEventHandler_0);
				sidesChangedEventHandler = Interlocked.CompareExchange<Scenario.SidesChangedEventHandler>(ref Scenario.SidesChangedEvent, value, sidesChangedEventHandler2);
			}
			while (sidesChangedEventHandler != sidesChangedEventHandler2);
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x001A3800 File Offset: 0x001A1A00
		[CompilerGenerated]
		public static void smethod_4(Scenario.TimeCompressionChangedEventHandler timeCompressionChangedEventHandler_0)
		{
			Scenario.TimeCompressionChangedEventHandler timeCompressionChangedEventHandler = Scenario.TimeCompressionChangedEvent;
			Scenario.TimeCompressionChangedEventHandler timeCompressionChangedEventHandler2;
			do
			{
				timeCompressionChangedEventHandler2 = timeCompressionChangedEventHandler;
				Scenario.TimeCompressionChangedEventHandler value = (Scenario.TimeCompressionChangedEventHandler)Delegate.Combine(timeCompressionChangedEventHandler2, timeCompressionChangedEventHandler_0);
				timeCompressionChangedEventHandler = Interlocked.CompareExchange<Scenario.TimeCompressionChangedEventHandler>(ref Scenario.TimeCompressionChangedEvent, value, timeCompressionChangedEventHandler2);
			}
			while (timeCompressionChangedEventHandler != timeCompressionChangedEventHandler2);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x001A3834 File Offset: 0x001A1A34
		[CompilerGenerated]
		public static void smethod_5(Scenario.UnitAddedEventHandler unitAddedEventHandler_0)
		{
			Scenario.UnitAddedEventHandler unitAddedEventHandler = Scenario.UnitAddedEvent;
			Scenario.UnitAddedEventHandler unitAddedEventHandler2;
			do
			{
				unitAddedEventHandler2 = unitAddedEventHandler;
				Scenario.UnitAddedEventHandler value = (Scenario.UnitAddedEventHandler)Delegate.Combine(unitAddedEventHandler2, unitAddedEventHandler_0);
				unitAddedEventHandler = Interlocked.CompareExchange<Scenario.UnitAddedEventHandler>(ref Scenario.UnitAddedEvent, value, unitAddedEventHandler2);
			}
			while (unitAddedEventHandler != unitAddedEventHandler2);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x001A3868 File Offset: 0x001A1A68
		[CompilerGenerated]
		public static void smethod_6(Scenario.UnitAddedEventHandler unitAddedEventHandler_0)
		{
			Scenario.UnitAddedEventHandler unitAddedEventHandler = Scenario.UnitAddedEvent;
			Scenario.UnitAddedEventHandler unitAddedEventHandler2;
			do
			{
				unitAddedEventHandler2 = unitAddedEventHandler;
				Scenario.UnitAddedEventHandler value = (Scenario.UnitAddedEventHandler)Delegate.Remove(unitAddedEventHandler2, unitAddedEventHandler_0);
				unitAddedEventHandler = Interlocked.CompareExchange<Scenario.UnitAddedEventHandler>(ref Scenario.UnitAddedEvent, value, unitAddedEventHandler2);
			}
			while (unitAddedEventHandler != unitAddedEventHandler2);
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x001A389C File Offset: 0x001A1A9C
		[CompilerGenerated]
		public static void smethod_7(Scenario.UnitRemovedEventHandler unitRemovedEventHandler_0)
		{
			Scenario.UnitRemovedEventHandler unitRemovedEventHandler = Scenario.UnitRemovedEvent;
			Scenario.UnitRemovedEventHandler unitRemovedEventHandler2;
			do
			{
				unitRemovedEventHandler2 = unitRemovedEventHandler;
				Scenario.UnitRemovedEventHandler value = (Scenario.UnitRemovedEventHandler)Delegate.Combine(unitRemovedEventHandler2, unitRemovedEventHandler_0);
				unitRemovedEventHandler = Interlocked.CompareExchange<Scenario.UnitRemovedEventHandler>(ref Scenario.UnitRemovedEvent, value, unitRemovedEventHandler2);
			}
			while (unitRemovedEventHandler != unitRemovedEventHandler2);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x001A38D0 File Offset: 0x001A1AD0
		[CompilerGenerated]
		public static void smethod_8(Scenario.UnitRemovedEventHandler unitRemovedEventHandler_0)
		{
			Scenario.UnitRemovedEventHandler unitRemovedEventHandler = Scenario.UnitRemovedEvent;
			Scenario.UnitRemovedEventHandler unitRemovedEventHandler2;
			do
			{
				unitRemovedEventHandler2 = unitRemovedEventHandler;
				Scenario.UnitRemovedEventHandler value = (Scenario.UnitRemovedEventHandler)Delegate.Remove(unitRemovedEventHandler2, unitRemovedEventHandler_0);
				unitRemovedEventHandler = Interlocked.CompareExchange<Scenario.UnitRemovedEventHandler>(ref Scenario.UnitRemovedEvent, value, unitRemovedEventHandler2);
			}
			while (unitRemovedEventHandler != unitRemovedEventHandler2);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x001A3904 File Offset: 0x001A1B04
		[CompilerGenerated]
		public static void smethod_9(Scenario.EventTriggersChangedEventHandler eventTriggersChangedEventHandler_0)
		{
			Scenario.EventTriggersChangedEventHandler eventTriggersChangedEventHandler = Scenario.EventTriggersChangedEvent;
			Scenario.EventTriggersChangedEventHandler eventTriggersChangedEventHandler2;
			do
			{
				eventTriggersChangedEventHandler2 = eventTriggersChangedEventHandler;
				Scenario.EventTriggersChangedEventHandler value = (Scenario.EventTriggersChangedEventHandler)Delegate.Combine(eventTriggersChangedEventHandler2, eventTriggersChangedEventHandler_0);
				eventTriggersChangedEventHandler = Interlocked.CompareExchange<Scenario.EventTriggersChangedEventHandler>(ref Scenario.EventTriggersChangedEvent, value, eventTriggersChangedEventHandler2);
			}
			while (eventTriggersChangedEventHandler != eventTriggersChangedEventHandler2);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x001A3938 File Offset: 0x001A1B38
		[CompilerGenerated]
		public static void smethod_10(Scenario.EventTriggersChangedEventHandler eventTriggersChangedEventHandler_0)
		{
			Scenario.EventTriggersChangedEventHandler eventTriggersChangedEventHandler = Scenario.EventTriggersChangedEvent;
			Scenario.EventTriggersChangedEventHandler eventTriggersChangedEventHandler2;
			do
			{
				eventTriggersChangedEventHandler2 = eventTriggersChangedEventHandler;
				Scenario.EventTriggersChangedEventHandler value = (Scenario.EventTriggersChangedEventHandler)Delegate.Remove(eventTriggersChangedEventHandler2, eventTriggersChangedEventHandler_0);
				eventTriggersChangedEventHandler = Interlocked.CompareExchange<Scenario.EventTriggersChangedEventHandler>(ref Scenario.EventTriggersChangedEvent, value, eventTriggersChangedEventHandler2);
			}
			while (eventTriggersChangedEventHandler != eventTriggersChangedEventHandler2);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x001A396C File Offset: 0x001A1B6C
		[CompilerGenerated]
		public static void smethod_11(Scenario.EventConditionsChangedEventHandler eventConditionsChangedEventHandler_0)
		{
			Scenario.EventConditionsChangedEventHandler eventConditionsChangedEventHandler = Scenario.EventConditionsChangedEvent;
			Scenario.EventConditionsChangedEventHandler eventConditionsChangedEventHandler2;
			do
			{
				eventConditionsChangedEventHandler2 = eventConditionsChangedEventHandler;
				Scenario.EventConditionsChangedEventHandler value = (Scenario.EventConditionsChangedEventHandler)Delegate.Combine(eventConditionsChangedEventHandler2, eventConditionsChangedEventHandler_0);
				eventConditionsChangedEventHandler = Interlocked.CompareExchange<Scenario.EventConditionsChangedEventHandler>(ref Scenario.EventConditionsChangedEvent, value, eventConditionsChangedEventHandler2);
			}
			while (eventConditionsChangedEventHandler != eventConditionsChangedEventHandler2);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x001A39A0 File Offset: 0x001A1BA0
		[CompilerGenerated]
		public static void smethod_12(Scenario.EventConditionsChangedEventHandler eventConditionsChangedEventHandler_0)
		{
			Scenario.EventConditionsChangedEventHandler eventConditionsChangedEventHandler = Scenario.EventConditionsChangedEvent;
			Scenario.EventConditionsChangedEventHandler eventConditionsChangedEventHandler2;
			do
			{
				eventConditionsChangedEventHandler2 = eventConditionsChangedEventHandler;
				Scenario.EventConditionsChangedEventHandler value = (Scenario.EventConditionsChangedEventHandler)Delegate.Remove(eventConditionsChangedEventHandler2, eventConditionsChangedEventHandler_0);
				eventConditionsChangedEventHandler = Interlocked.CompareExchange<Scenario.EventConditionsChangedEventHandler>(ref Scenario.EventConditionsChangedEvent, value, eventConditionsChangedEventHandler2);
			}
			while (eventConditionsChangedEventHandler != eventConditionsChangedEventHandler2);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x001A39D4 File Offset: 0x001A1BD4
		[CompilerGenerated]
		public static void smethod_13(Scenario.EventActionsChangedEventHandler eventActionsChangedEventHandler_0)
		{
			Scenario.EventActionsChangedEventHandler eventActionsChangedEventHandler = Scenario.EventActionsChangedEvent;
			Scenario.EventActionsChangedEventHandler eventActionsChangedEventHandler2;
			do
			{
				eventActionsChangedEventHandler2 = eventActionsChangedEventHandler;
				Scenario.EventActionsChangedEventHandler value = (Scenario.EventActionsChangedEventHandler)Delegate.Combine(eventActionsChangedEventHandler2, eventActionsChangedEventHandler_0);
				eventActionsChangedEventHandler = Interlocked.CompareExchange<Scenario.EventActionsChangedEventHandler>(ref Scenario.EventActionsChangedEvent, value, eventActionsChangedEventHandler2);
			}
			while (eventActionsChangedEventHandler != eventActionsChangedEventHandler2);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x001A3A08 File Offset: 0x001A1C08
		[CompilerGenerated]
		public static void smethod_14(Scenario.EventActionsChangedEventHandler eventActionsChangedEventHandler_0)
		{
			Scenario.EventActionsChangedEventHandler eventActionsChangedEventHandler = Scenario.EventActionsChangedEvent;
			Scenario.EventActionsChangedEventHandler eventActionsChangedEventHandler2;
			do
			{
				eventActionsChangedEventHandler2 = eventActionsChangedEventHandler;
				Scenario.EventActionsChangedEventHandler value = (Scenario.EventActionsChangedEventHandler)Delegate.Remove(eventActionsChangedEventHandler2, eventActionsChangedEventHandler_0);
				eventActionsChangedEventHandler = Interlocked.CompareExchange<Scenario.EventActionsChangedEventHandler>(ref Scenario.EventActionsChangedEvent, value, eventActionsChangedEventHandler2);
			}
			while (eventActionsChangedEventHandler != eventActionsChangedEventHandler2);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x001A3A3C File Offset: 0x001A1C3C
		[CompilerGenerated]
		public static void smethod_15(Scenario.ScenCompletedEventHandler scenCompletedEventHandler_0)
		{
			Scenario.ScenCompletedEventHandler scenCompletedEventHandler = Scenario.ScenCompletedEvent;
			Scenario.ScenCompletedEventHandler scenCompletedEventHandler2;
			do
			{
				scenCompletedEventHandler2 = scenCompletedEventHandler;
				Scenario.ScenCompletedEventHandler value = (Scenario.ScenCompletedEventHandler)Delegate.Combine(scenCompletedEventHandler2, scenCompletedEventHandler_0);
				scenCompletedEventHandler = Interlocked.CompareExchange<Scenario.ScenCompletedEventHandler>(ref Scenario.ScenCompletedEvent, value, scenCompletedEventHandler2);
			}
			while (scenCompletedEventHandler != scenCompletedEventHandler2);
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0000BFC3 File Offset: 0x0000A1C3
		public string method_0()
		{
			return this._Title;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x001A3A70 File Offset: 0x001A1C70
		public void method_1(string string_0)
		{
			this._Title = string_0;
			Scenario.TitleChangedEventHandler titleChangedEvent = Scenario.TitleChangedEvent;
			if (titleChangedEvent != null)
			{
				titleChangedEvent(this, string_0);
			}
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x001A3A98 File Offset: 0x001A1C98
		public string method_2()
		{
			if (string.IsNullOrEmpty(this._ObjectID))
			{
				this._ObjectID = Guid.NewGuid().ToString();
			}
			return this._ObjectID;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0000BFCB File Offset: 0x0000A1CB
		public void method_3(string string_0)
		{
			this._ObjectID = string_0;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0000BFD4 File Offset: 0x0000A1D4
		public string method_4()
		{
			return this._Description;
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0000BFDC File Offset: 0x0000A1DC
		public void method_5(string string_0)
		{
			this._Description = string_0;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x0000BFE5 File Offset: 0x0000A1E5
		public IEventExporter[] method_6()
		{
			return Class428.ieventExporter_0;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0000BFEC File Offset: 0x0000A1EC
		public string method_7()
		{
			return this._DBUsed;
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x001A3AD4 File Offset: 0x001A1CD4
		public void method_8(string string_0)
		{
			bool flag = string.IsNullOrEmpty(this._DBUsed) || string.IsNullOrEmpty(string_0) || Operators.CompareString(string_0, this._DBUsed, false) != 0;
			this._DBUsed = string_0;
			if (flag)
			{
				this._DBConnection = null;
				SQLiteConnection sqliteConnection = this.method_39();
				DBFunctions.smethod_0(ref this.Cache_Aircraft_DT, ref this.Cache_Ships_DT, ref this.Cache_Subs_DT, ref this.Cache_Facilities_DT, ref this.Cache_Satellites_DT, ref this.Cache_Weapons_DT, ref sqliteConnection);
				sqliteConnection = this.method_39();
				this.Cache_OperatorCountries_DT = DBFunctions.smethod_8(ref sqliteConnection);
			}
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x001A3B64 File Offset: 0x001A1D64
		public void method_9()
		{
			if (!this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_5))
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.method_42())
					{
						if (!Information.IsNothing(activeUnit) && !activeUnit.vmethod_90().vmethod_1())
						{
							this.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_5);
							break;
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (EventAction eventAction in this.vmethod_8().Values)
					{
						if (eventAction.eventActionType_0 == EventAction.EventActionType.LuaScript && Misc.smethod_64(((Class317)eventAction).string_3, "OUTOFCOMMS", StringComparison.OrdinalIgnoreCase))
						{
							this.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_5);
							break;
						}
					}
				}
				finally
				{
					IEnumerator<EventAction> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
			}
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x001A3C50 File Offset: 0x001A1E50
		public static bool smethod_16(ref double Lat_Src, ref double Lon_Src, ref float Alt_Src, ref double Lat_Dest, ref double Lon_Dest, ref float Alt_Dest, bool LandMassCheck, int ExtraSensorHeight = 0, bool IgnoreRadarHorizon = false)
		{
			bool result;
			try
			{
				float num = 900f;
				float num2 = 9000f;
				float num3 = 0f;
				float num4 = 18900f;
				double num5;
				double num6;
				double num7;
				Class432.smethod_3(Lat_Src, Lon_Src, (double)(Alt_Src + (float)ExtraSensorHeight), ref num5, ref num6, ref num7);
				double num8;
				double num9;
				double num10;
				Class432.smethod_3(Lat_Dest, Lon_Dest, (double)Alt_Dest, ref num8, ref num9, ref num10);
				double num11 = num8 - num5;
				double num12 = num9 - num6;
				double num13 = num10 - num7;
				double num14 = Math.Sqrt(num11 * num11 + num12 * num12 + num13 * num13);
				if (num14 >= (double)37800f)
				{
					float num15 = num4;
					float num16 = num4;
					double num17 = num14 - (double)(num4 * 2f);
					float num18 = (float)(num14 - (double)num4);
					while (num15 > num)
					{
						num3 += num;
						if (num3 > num4)
						{
							IL_121:
							if (num17 > (double)(num2 * 2f))
							{
								double num19 = num17;
								num3 = num4;
								while (num19 > (double)num2)
								{
									num3 += num2;
									if (num3 > num18)
									{
										break;
									}
									if (Scenario.smethod_17(num3, num14, num5, num6, num7, num11, num12, num13, Alt_Src, Alt_Dest, LandMassCheck, IgnoreRadarHorizon))
									{
										return false;
									}
									num19 -= (double)num2;
								}
							}
							num3 = (float)num14 - num4;
							while (num16 > num)
							{
								num3 += num;
								if ((double)num3 > num14)
								{
									break;
								}
								if (Scenario.smethod_17(num3, num14, num5, num6, num7, num11, num12, num13, Alt_Src, Alt_Dest, LandMassCheck, IgnoreRadarHorizon))
								{
									return false;
								}
								num16 -= num;
							}
							goto IL_1B7;
						}
						if (Scenario.smethod_17(num3, num14, num5, num6, num7, num11, num12, num13, Alt_Src, Alt_Dest, LandMassCheck, IgnoreRadarHorizon))
						{
							return false;
						}
						num15 -= num;
					}
					goto IL_121;
				}
				for (double num20 = num14; num20 > (double)num; num20 -= (double)num)
				{
					num3 += num;
					if ((double)num3 > num14)
					{
						break;
					}
					if (Scenario.smethod_17(num3, num14, num5, num6, num7, num11, num12, num13, Alt_Src, Alt_Dest, LandMassCheck, IgnoreRadarHorizon))
					{
						return false;
					}
				}
				IL_1B7:
				result = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100872", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x001A3E70 File Offset: 0x001A2070
		private static bool smethod_17(float float_0, double double_0, double double_1, double double_2, double double_3, double double_4, double double_5, double double_6, float float_1, float float_2, bool bool_0, bool bool_1)
		{
			float num = (float)((double)float_0 / double_0);
			bool result;
			if (num > 1f)
			{
				result = false;
			}
			else
			{
				double double_7 = double_1 + double_4 * (double)num;
				double double_8 = double_2 + double_5 * (double)num;
				double double_9 = double_3 + double_6 * (double)num;
				double double_10;
				double double_11;
				double num2;
				Class432.smethod_4(double_7, double_8, double_9, ref double_10, ref double_11, ref num2);
				if (num2 > (double)float_1 && num2 > (double)float_2)
				{
					result = false;
				}
				else
				{
					int? num3;
					if (num2 < (double)float_1 && num2 < (double)float_2)
					{
						num3 = new int?((int)Terrain.smethod_7(double_10, double_11, false));
						if (num2 < (double)num3.Value)
						{
							return true;
						}
					}
					short num4 = Class444.smethod_3(double_10, double_11);
					if (num2 > (double)num4)
					{
						result = false;
					}
					else
					{
						if (num3 == null)
						{
							num3 = new int?((int)Terrain.smethod_7(double_10, double_11, false));
						}
						if (bool_0)
						{
							int? num5 = num3;
							if (((num5 != null) ? new bool?(num5.GetValueOrDefault() > 0) : null).GetValueOrDefault())
							{
								return true;
							}
						}
						else
						{
							bool? flag;
							if (!bool_1)
							{
								flag = new bool?(false);
							}
							else
							{
								int? num5 = num3;
								flag = ((num5 != null) ? new bool?(num5.GetValueOrDefault() <= 0) : null);
							}
							bool? flag2 = flag;
							if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
							{
								double num6 = num2;
								double? num7 = (num3 != null) ? new double?((double)num3.GetValueOrDefault()) : null;
								if (((num7 != null) ? new bool?(num6 <= num7.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									return true;
								}
							}
						}
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
		public LuaSandBox method_10()
		{
			if (Information.IsNothing(this._Scenario_LuaSandbox))
			{
				this._Scenario_LuaSandbox = new LuaSandBox();
			}
			return this._Scenario_LuaSandbox;
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x0000C014 File Offset: 0x0000A214
		public void method_11(LuaSandBox luaSandBox_0)
		{
			this._Scenario_LuaSandbox = luaSandBox_0;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x001A4034 File Offset: 0x001A2234
		public void method_12(Stream stream_0, bool bool_0)
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			if (!bool_0)
			{
				xmlWriterSettings.Indent = true;
				xmlWriterSettings.IndentChars = "    ";
			}
			XmlWriter xmlWriter_ = XmlWriter.Create(stream_0, xmlWriterSettings);
			this.method_13(xmlWriter_);
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x001A406C File Offset: 0x001A226C
		private void method_13(XmlWriter xmlWriter_0)
		{
			try
			{
				HashSet<string> hashSet_ = new HashSet<string>();
				using (xmlWriter_0)
				{
					if (string.IsNullOrEmpty(this.ContentTag))
					{
						xmlWriter_0.WriteStartElement("Scenario");
					}
					else
					{
						xmlWriter_0.WriteStartElement("ContentScenario");
					}
					xmlWriter_0.WriteElementString("TimelineID", this.TimelineID.ToString());
					xmlWriter_0.WriteElementString("ObjectID", this.method_2().ToString());
					xmlWriter_0.WriteElementString("ContentTag", this.ContentTag);
					xmlWriter_0.WriteElementString("CampaignID", this.CampaignID);
					xmlWriter_0.WriteElementString("CampaignSessionID", this.CampaignSessionID);
					xmlWriter_0.WriteElementString("CampaignScore", this.CampaignScore.ToString());
					xmlWriter_0.WriteElementString("Title", this._Title);
					xmlWriter_0.WriteElementString("Description", this._Description);
					xmlWriter_0.WriteElementString("Meta_Complexity", Conversions.ToString((int)this.Meta_Complexity));
					xmlWriter_0.WriteElementString("Meta_Difficulty", Conversions.ToString((int)this.Meta_Difficulty));
					xmlWriter_0.WriteElementString("Meta_ScenSetting", this.Meta_ScenSetting);
					xmlWriter_0.WriteElementString("FileName", this.FileName);
					xmlWriter_0.WriteElementString("Time", this._Time.ToBinary().ToString());
					xmlWriter_0.WriteElementString("ZeroHour", this.ZeroHour.ToBinary().ToString());
					if (this._StartTime != null)
					{
						xmlWriter_0.WriteElementString("StartTime", this._StartTime.Value.ToBinary().ToString());
					}
					if (this._Duration != null)
					{
						xmlWriter_0.WriteElementString("Duration", this._Duration.Value.Ticks.ToString());
					}
					xmlWriter_0.WriteElementString("DaylightSavingTime", this._DaylightSavingTime.ToString());
					if (Information.IsNothing(this._DaylightSavingTime_Start))
					{
						this._DaylightSavingTime_Start = "00.00";
					}
					if (Information.IsNothing(this._DaylightSavingTime_End))
					{
						this._DaylightSavingTime_End = "00.00";
					}
					xmlWriter_0.WriteElementString("DaylightSavingTime_Start", this._DaylightSavingTime_Start.ToString());
					xmlWriter_0.WriteElementString("DaylightSavingTime_End", this._DaylightSavingTime_End.ToString());
					xmlWriter_0.WriteStartElement("Sides");
					foreach (Side side in this.method_44())
					{
						Scenario scenario = this;
						side.method_8(ref xmlWriter_0, ref hashSet_, ref scenario);
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("NonActiveUnits");
					xmlWriter_0.WriteStartElement("Explosions");
					try
					{
						foreach (Explosion explosion in this.vmethod_12())
						{
							explosion.vmethod_4(ref xmlWriter_0, ref hashSet_);
						}
					}
					finally
					{
						List<Explosion>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("WeaponImpacts");
					for (int j = this.vmethod_14().Count - 1; j >= 0; j += -1)
					{
						this.vmethod_14()[j].vmethod_4(ref xmlWriter_0, ref hashSet_);
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("UnguidedWeapons");
					try
					{
						foreach (UnguidedWeapon unguidedWeapon in this.vmethod_20().Values)
						{
							unguidedWeapon.vmethod_4(ref xmlWriter_0, ref hashSet_);
						}
					}
					finally
					{
						IEnumerator<UnguidedWeapon> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("ChaffClouds");
					try
					{
						foreach (ChaffCorridorCloud chaffCorridorCloud in this.ChaffClouds)
						{
							chaffCorridorCloud.vmethod_4(ref xmlWriter_0, ref hashSet_);
						}
					}
					finally
					{
						List<ChaffCorridorCloud>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("ActiveUnits");
					try
					{
						foreach (ActiveUnit activeUnit in this.method_42())
						{
							if (!Information.IsNothing(activeUnit))
							{
								activeUnit.vmethod_4(ref xmlWriter_0, ref hashSet_);
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("Groups");
					try
					{
						foreach (Group group in this.Groups)
						{
							if (!Information.IsNothing(group))
							{
								xmlWriter_0.WriteElementString("ID", group.string_0);
							}
						}
					}
					finally
					{
						IEnumerator<Group> enumerator5;
						if (enumerator5 != null)
						{
							enumerator5.Dispose();
						}
					}
					xmlWriter_0.WriteEndElement();
					XmlWriter xmlWriter2 = xmlWriter_0;
					string localName = "WeatherModel";
					byte weatherLevel = (byte)this.WeatherLevel;
					xmlWriter2.WriteElementString(localName, weatherLevel.ToString());
					xmlWriter_0.WriteStartElement("GlobalWeather");
					this.method_23().method_0(ref xmlWriter_0);
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("EventTriggers");
					try
					{
						foreach (EventTrigger eventTrigger in this.vmethod_4().Values)
						{
							eventTrigger.vmethod_4(xmlWriter_0, hashSet_, this);
						}
					}
					finally
					{
						IEnumerator<EventTrigger> enumerator6;
						if (enumerator6 != null)
						{
							enumerator6.Dispose();
						}
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("EventConditions");
					try
					{
						foreach (EventCondition eventCondition in this.vmethod_6().Values)
						{
							eventCondition.vmethod_5(xmlWriter_0, hashSet_, this);
						}
					}
					finally
					{
						IEnumerator<EventCondition> enumerator7;
						if (enumerator7 != null)
						{
							enumerator7.Dispose();
						}
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("EventActions");
					try
					{
						foreach (EventAction eventAction in this.vmethod_8().Values)
						{
							eventAction.vmethod_4(xmlWriter_0, hashSet_, this);
						}
					}
					finally
					{
						IEnumerator<EventAction> enumerator8;
						if (enumerator8 != null)
						{
							enumerator8.Dispose();
						}
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("SimEvents");
					try
					{
						foreach (SimEvent simEvent in this.vmethod_10().Values)
						{
							simEvent.method_8(xmlWriter_0, hashSet_, this);
						}
					}
					finally
					{
						IEnumerator<SimEvent> enumerator9;
						if (enumerator9 != null)
						{
							enumerator9.Dispose();
						}
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("ScenAttachmentObjects");
					try
					{
						foreach (ScenAttachmentObject scenAttachmentObject in this.vmethod_2().Values)
						{
							scenAttachmentObject.vmethod_1(xmlWriter_0, hashSet_, this);
						}
					}
					finally
					{
						IEnumerator<ScenAttachmentObject> enumerator10;
						if (enumerator10 != null)
						{
							enumerator10.Dispose();
						}
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("FlightplanErrors");
					try
					{
						foreach (string value in this.MissionPlannerErrorList)
						{
							xmlWriter_0.WriteElementString("Message", value);
						}
					}
					finally
					{
						List<string>.Enumerator enumerator11;
						((IDisposable)enumerator11).Dispose();
					}
					xmlWriter_0.WriteEndElement();
					XmlWriter xmlWriter3 = xmlWriter_0;
					string localName2 = "TimeCompression";
					int timeCompression = (int)this._TimeCompression;
					xmlWriter3.WriteElementString(localName2, timeCompression.ToString());
					xmlWriter_0.WriteElementString("GameResolution", XmlConvert.ToString(this._GameResolution));
					this.method_93(xmlWriter_0);
					xmlWriter_0.WriteElementString("MessageIncrement", this._MessageIncrement.ToString());
					xmlWriter_0.WriteElementString("UnitsAutoIncrement", this.UnitsAutoIncrement.ToString());
					if (!Information.IsNothing(this.method_54()))
					{
						xmlWriter_0.WriteElementString("CurrentSide", this.method_54().method_51());
					}
					xmlWriter_0.WriteElementString("GameVersion", this.GameVersion);
					xmlWriter_0.WriteElementString("DBUsed", this.method_7().ToString());
					if (this.LastSavedInScenEdit)
					{
						xmlWriter_0.WriteElementString("LastSavedInScenEdit", "True");
					}
					if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_1))
					{
						xmlWriter_0.WriteElementString("Realism_DetailedGunFireControl", "True");
					}
					if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2))
					{
						xmlWriter_0.WriteElementString("Realism_UnlimitedBaseMags", "True");
					}
					if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_9))
					{
						xmlWriter_0.WriteElementString("Realism_RealisticSubComms", "True");
					}
					if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_10))
					{
						xmlWriter_0.WriteElementString("Realism_LandTypeEffects", "True");
					}
					if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_4))
					{
						xmlWriter_0.WriteElementString("Realism_CommsJamming", "True");
					}
					if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_5))
					{
						xmlWriter_0.WriteElementString("Realism_CommsDisruption", "True");
					}
					if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_3))
					{
						xmlWriter_0.WriteElementString("Realism_AircraftDamage", "True");
					}
					if (!string.IsNullOrEmpty(this.LuaXml))
					{
						xmlWriter_0.WriteElementString("LuaXml", this.LuaXml);
					}
					if (!string.IsNullOrEmpty(this.LuaXmlPassed))
					{
						xmlWriter_0.WriteElementString("LuaXmlPassed", this.LuaXmlPassed);
					}
					xmlWriter_0.WriteEndElement();
				}
				hashSet_ = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101022", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x001A4A1C File Offset: 0x001A2C1C
		private static Scenario smethod_18(XmlDocument XMLDoc, ref string ErrorFeedback, ref double PercentageComplete, bool ForceDeepRebuild = false, bool CheckForDBTampering = true)
		{
			Scenario result;
			try
			{
				Scenario scenario = new Scenario("", "", "");
				Dictionary<string, Class310> dictionary = new Dictionary<string, Class310>();
				XmlNode xmlNode = XMLDoc.SelectSingleNode("/Scenario");
				string str;
				if (!Information.IsNothing(xmlNode))
				{
					str = "Scenario";
				}
				else
				{
					str = "ContentScenario";
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/GameGUID");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.TimelineID = xmlNode.InnerText;
				}
				else
				{
					scenario.TimelineID = XMLDoc.SelectSingleNode("/" + str + "/TimelineID").InnerText;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/ObjectID");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.method_3(xmlNode.InnerText);
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/ContentTag");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.ContentTag = xmlNode.InnerText;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/CampaignID");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.CampaignID = xmlNode.InnerText;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/CampaignSessionID");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.CampaignSessionID = xmlNode.InnerText;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/CampaignScore");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.CampaignScore = Conversions.ToInteger(xmlNode.InnerText);
				}
				scenario.method_1(XMLDoc.SelectSingleNode("/" + str + "/Title").InnerText);
				scenario.method_5(XMLDoc.SelectSingleNode("/" + str + "/Description").InnerText);
				scenario.method_5(scenario.method_4().Replace("<HR>", ""));
				try
				{
					scenario.Meta_Complexity = Conversions.ToShort(XMLDoc.SelectSingleNode("/" + str + "/Meta_Complexity").InnerText);
					scenario.Meta_Difficulty = Conversions.ToShort(XMLDoc.SelectSingleNode("/" + str + "/Meta_Difficulty").InnerText);
					scenario.Meta_ScenSetting = XMLDoc.SelectSingleNode("/" + str + "/Meta_ScenSetting").InnerText;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200051", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				scenario.FileName = XMLDoc.SelectSingleNode("/" + str + "/FileName").InnerText;
				scenario._Time = DateTime.FromBinary(Conversions.ToLong(XMLDoc.SelectSingleNode("/" + str + "/Time").InnerText));
				try
				{
					scenario.ZeroHour = DateTime.FromBinary(Conversions.ToLong(XMLDoc.SelectSingleNode("/" + str + "/ZeroHour").InnerText));
				}
				catch (Exception ex2)
				{
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/StartTime");
				if (!Information.IsNothing(xmlNode) && Operators.CompareString(xmlNode.InnerText, "0", false) != 0)
				{
					scenario._StartTime = new DateTime?(DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText)));
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/DaylightSavingTime");
				if (!Information.IsNothing(xmlNode))
				{
					scenario._DaylightSavingTime = Conversions.ToBoolean(xmlNode.InnerText);
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/DaylightSavingTime_Start");
				if (!Information.IsNothing(xmlNode) && Operators.CompareString(xmlNode.InnerText, "0", false) != 0)
				{
					scenario._DaylightSavingTime_Start = XMLDoc.SelectSingleNode("/" + str + "/DaylightSavingTime_Start").InnerText.Replace(",", ".");
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Duration");
				if (!Information.IsNothing(xmlNode) && Operators.CompareString(xmlNode.InnerText, "0", false) != 0)
				{
					scenario._Duration = new TimeSpan?(new TimeSpan(Conversions.ToLong(xmlNode.InnerText)));
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/DaylightSavingTime_End");
				if (!Information.IsNothing(xmlNode) && Operators.CompareString(xmlNode.InnerText, "0", false) != 0)
				{
					scenario._DaylightSavingTime_End = XMLDoc.SelectSingleNode("/" + str + "/DaylightSavingTime_End").InnerText.Replace(",", ".");
				}
				try
				{
					scenario.method_8(XMLDoc.SelectSingleNode("/" + str + "/DBUsed").InnerText.ToString());
				}
				catch (Exception ex3)
				{
					ex3.Data.Add("Error at 999999", ex3.Message);
					GameGeneral.smethod_25(ref ex3);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					if (string.IsNullOrEmpty(ex3.Message))
					{
						GameGeneral.smethod_1("ERROR! The scenario file is probably corrupted, could not determine which database to use!");
					}
					else
					{
						GameGeneral.smethod_1("ERROR: " + ex3.Message);
					}
					return null;
				}
				if (Versioned.IsNumeric(scenario.method_7()))
				{
					scenario.method_8(DBOps.smethod_12(Conversions.ToInteger(scenario.method_7())));
				}
				DBOps.DBFileCheckResult dbfileCheckResult_;
				DBRecord dbrecord = DBOps.smethod_10(scenario.method_7(), ref dbfileCheckResult_, true, CheckForDBTampering);
				if (Information.IsNothing(dbrecord))
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw new Exception("Error: " + DBOps.smethod_7(dbfileCheckResult_));
				}
				if (dbrecord.method_1())
				{
					bool? nullable_ = dbrecord.nullable_0;
					if (((nullable_ != null) ? new bool?(!nullable_.GetValueOrDefault()) : nullable_).GetValueOrDefault())
					{
						ErrorFeedback += "CAUTION! The database version matching this scenario is no longer supported by the simulation engine. The loaded scenario was automatically matched to the current version of this database. This change will persist on the next scenario save.\r\nNOTE: All units in the scenario will be rebuilt as brand-new from the DB (thus erasing any modified state on them, e.g. damage or expended fuel/weapons). Please use the SBR to restore any unit customizations (damage, ammo etc.) after the rebuild process.";
						scenario.method_8(DBOps.smethod_12(dbrecord.DBID));
						scenario.LoadStockUnits = true;
					}
				}
				if (ForceDeepRebuild)
				{
					scenario.LoadStockUnits = true;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Sides");
				XmlNodeList childNodes;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/NonActiveUnits/Explosions");
				XmlNodeList childNodes2;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes2 = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/NonActiveUnits/WeaponImpacts");
				XmlNodeList childNodes3;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes3 = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/NonActiveUnits/UnguidedWeapons");
				XmlNodeList childNodes4;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes4 = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/NonActiveUnits/ChaffClouds");
				XmlNodeList childNodes5;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes5 = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/ActiveUnits");
				XmlNodeList childNodes6;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes6 = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Groups");
				XmlNodeList childNodes7;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes7 = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/EventTriggers");
				XmlNodeList childNodes8;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes8 = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/EventConditions");
				XmlNodeList childNodes9;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes9 = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/EventActions");
				XmlNodeList childNodes10;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes10 = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/SimEvents");
				XmlNodeList childNodes11;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes11 = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/ScenAttachmentObjects");
				XmlNodeList childNodes12;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes12 = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/MessageLog");
				XmlNodeList childNodes13;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes13 = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/FlightplanErrors");
				XmlNodeList childNodes14;
				if (!Information.IsNothing(xmlNode))
				{
					childNodes14 = xmlNode.ChildNodes;
				}
				int num;
				if (!Information.IsNothing(childNodes))
				{
					num += childNodes.Count;
				}
				if (!Information.IsNothing(childNodes2))
				{
					num += childNodes2.Count;
				}
				if (!Information.IsNothing(childNodes3))
				{
					num += childNodes3.Count;
				}
				if (!Information.IsNothing(childNodes4))
				{
					num += childNodes4.Count;
				}
				if (!Information.IsNothing(childNodes5))
				{
					num += childNodes5.Count;
				}
				if (!Information.IsNothing(childNodes6))
				{
					num += childNodes6.Count;
				}
				if (!Information.IsNothing(childNodes7))
				{
					num += childNodes7.Count;
				}
				if (!Information.IsNothing(childNodes8))
				{
					num += childNodes8.Count;
				}
				if (!Information.IsNothing(childNodes9))
				{
					num += childNodes9.Count;
				}
				if (!Information.IsNothing(childNodes10))
				{
					num += childNodes10.Count;
				}
				if (!Information.IsNothing(childNodes11))
				{
					num += childNodes11.Count;
				}
				if (!Information.IsNothing(childNodes12))
				{
					num += childNodes12.Count;
				}
				if (!Information.IsNothing(childNodes13))
				{
					num += childNodes13.Count;
				}
				int num2 = 0;
				if (!Information.IsNothing(childNodes))
				{
					try
					{
						foreach (object obj in childNodes)
						{
							XmlNode xmlNode2 = (XmlNode)obj;
							Side side_ = Side.smethod_12(ref xmlNode2, ref scenario, ref dictionary);
							scenario.method_69(side_);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
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
				if (!Information.IsNothing(childNodes2))
				{
					try
					{
						foreach (object obj2 in childNodes2)
						{
							XmlNode xmlNode3 = (XmlNode)obj2;
							Explosion gparam_ = Explosion.smethod_0(ref xmlNode3, ref dictionary);
							scenario.vmethod_12().method_4(gparam_);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(childNodes3))
				{
					try
					{
						foreach (object obj3 in childNodes3)
						{
							XmlNode xmlNode4 = (XmlNode)obj3;
							WeaponImpact gparam_2 = WeaponImpact.smethod_0(ref xmlNode4, ref dictionary);
							scenario.vmethod_14().method_4(gparam_2);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						IEnumerator enumerator3;
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(childNodes4))
				{
					try
					{
						foreach (object obj4 in childNodes4)
						{
							XmlNode xmlNode5 = (XmlNode)obj4;
							UnguidedWeapon unguidedWeapon = UnguidedWeapon.smethod_2(ref xmlNode5, ref dictionary, ref scenario);
							scenario.vmethod_20().Add(unguidedWeapon.string_0, unguidedWeapon);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						IEnumerator enumerator4;
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(childNodes5))
				{
					try
					{
						foreach (object obj5 in childNodes5)
						{
							XmlNode xmlNode6 = (XmlNode)obj5;
							ChaffCorridorCloud item = ChaffCorridorCloud.smethod_0(ref xmlNode6, ref dictionary);
							scenario.ChaffClouds.Add(item);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						IEnumerator enumerator5;
						if (enumerator5 is IDisposable)
						{
							(enumerator5 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(childNodes6))
				{
					try
					{
						foreach (object obj6 in childNodes6)
						{
							XmlNode xmlNode7 = (XmlNode)obj6;
							ActiveUnit activeUnit = ActiveUnit.smethod_9(ref xmlNode7, ref dictionary, ref scenario);
							if (activeUnit != null)
							{
								if (!scenario.vmethod_0().ContainsKey(activeUnit.string_0))
								{
									scenario.vmethod_0().Add(activeUnit.string_0, activeUnit);
								}
								num2++;
								PercentageComplete = (double)num2 / (double)num;
								if (!Information.IsNothing(activeUnit.vmethod_101()))
								{
									if (activeUnit.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike && activeUnit.vmethod_86().bool_2)
									{
										activeUnit.vmethod_86().bool_2 = false;
									}
								}
								else if (activeUnit.vmethod_86().bool_2)
								{
									activeUnit.vmethod_86().bool_2 = false;
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator6;
						if (enumerator6 is IDisposable)
						{
							(enumerator6 as IDisposable).Dispose();
						}
					}
					try
					{
						foreach (ActiveUnit activeUnit2 in scenario.vmethod_0().Values)
						{
							activeUnit2.scenario_0 = scenario;
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator7;
						if (enumerator7 != null)
						{
							enumerator7.Dispose();
						}
					}
				}
				try
				{
					foreach (XmlNode xmlNode8 in scenario.UnitsForLateInstantiation)
					{
						ActiveUnit activeUnit3 = ActiveUnit.smethod_9(ref xmlNode8, ref dictionary, ref scenario);
						scenario.vmethod_0()[activeUnit3.string_0] = activeUnit3;
					}
				}
				finally
				{
					HashSet<XmlNode>.Enumerator enumerator8;
					enumerator8.Dispose();
				}
				scenario.UnitsForLateInstantiation.Clear();
				if (!Information.IsNothing(childNodes7))
				{
					try
					{
						foreach (object obj7 in childNodes7)
						{
							XmlNode xmlNode9 = (XmlNode)obj7;
							Group group = (Group)dictionary[xmlNode9.InnerText];
							scenario.Groups.Add(group);
							group.scenario_0 = scenario;
							group.bool_27 = true;
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						IEnumerator enumerator9;
						if (enumerator9 is IDisposable)
						{
							(enumerator9 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(childNodes8))
				{
					try
					{
						foreach (object obj8 in childNodes8)
						{
							XmlNode xmlNode10 = (XmlNode)obj8;
							EventTrigger eventTrigger = EventTrigger.smethod_0(ref xmlNode10, ref dictionary, ref scenario);
							scenario.vmethod_4().Add(eventTrigger.string_0, eventTrigger);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						IEnumerator enumerator10;
						if (enumerator10 is IDisposable)
						{
							(enumerator10 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(childNodes9))
				{
					try
					{
						foreach (object obj9 in childNodes9)
						{
							XmlNode xmlNode11 = (XmlNode)obj9;
							EventCondition eventCondition = EventCondition.smethod_0(ref xmlNode11, ref dictionary, ref scenario);
							scenario.vmethod_6().Add(eventCondition.string_0, eventCondition);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						IEnumerator enumerator11;
						if (enumerator11 is IDisposable)
						{
							(enumerator11 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(childNodes10))
				{
					try
					{
						foreach (object obj10 in childNodes10)
						{
							XmlNode xmlNode12 = (XmlNode)obj10;
							EventAction eventAction = EventAction.smethod_0(ref xmlNode12, ref dictionary, ref scenario);
							scenario.vmethod_8().Add(eventAction.string_0, eventAction);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						IEnumerator enumerator12;
						if (enumerator12 is IDisposable)
						{
							(enumerator12 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(childNodes11))
				{
					try
					{
						foreach (object obj11 in childNodes11)
						{
							SimEvent simEvent = SimEvent.smethod_0((XmlNode)obj11, dictionary, scenario);
							scenario.vmethod_10().Add(simEvent.string_0, simEvent);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						IEnumerator enumerator13;
						if (enumerator13 is IDisposable)
						{
							(enumerator13 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(childNodes12))
				{
					try
					{
						foreach (object obj12 in childNodes12)
						{
							ScenAttachmentObject scenAttachmentObject = ScenAttachmentObject.smethod_0((XmlNode)obj12, dictionary, scenario);
							scenario.vmethod_2().Add(scenAttachmentObject.method_0(), scenAttachmentObject);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						IEnumerator enumerator14;
						if (enumerator14 is IDisposable)
						{
							(enumerator14 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(childNodes14))
				{
					try
					{
						foreach (object obj13 in childNodes14)
						{
							string innerText = ((XmlNode)obj13).InnerText;
							scenario.MissionPlannerErrorList.Add(innerText);
						}
					}
					finally
					{
						IEnumerator enumerator15;
						if (enumerator15 is IDisposable)
						{
							(enumerator15 as IDisposable).Dispose();
						}
					}
				}
				XmlNode xmlNode13 = XMLDoc.SelectSingleNode("/" + str + "/WeatherModel");
				if (Information.IsNothing(xmlNode13))
				{
					scenario.WeatherLevel = Scenario.WeatherModellingLevel.Level0;
				}
				else
				{
					scenario.WeatherLevel = (Scenario.WeatherModellingLevel)Conversions.ToByte(xmlNode13.InnerText);
				}
				xmlNode13 = XMLDoc.SelectSingleNode("/" + str + "/GlobalWeather");
				if (!Information.IsNothing(xmlNode13))
				{
					scenario._GlobalWeather = Weather.WeatherProfile.smethod_0(ref xmlNode13);
				}
				string innerText2 = XMLDoc.SelectSingleNode("/" + str + "/TimeCompression").InnerText;
				if (Versioned.IsNumeric(innerText2))
				{
					try
					{
						scenario._TimeCompression = (Scenario.enumTimeCompression)Conversions.ToByte(innerText2);
						goto IL_1093;
					}
					catch (Exception ex4)
					{
						scenario._TimeCompression = Scenario.enumTimeCompression.OneSec;
						goto IL_1093;
					}
				}
				scenario._TimeCompression = (Scenario.enumTimeCompression)Enum.Parse(typeof(Scenario.enumTimeCompression), innerText2, true);
				IL_1093:
				scenario._GameResolution = XmlConvert.ToSingle(XMLDoc.SelectSingleNode("/" + str + "/GameResolution").InnerText.Replace(",", "."));
				try
				{
					foreach (object obj14 in childNodes13)
					{
						XmlNode xmlNode14 = (XmlNode)obj14;
						LoggedMessage loggedMessage = LoggedMessage.smethod_0(ref xmlNode14, ref dictionary);
						if (!Information.IsNothing(loggedMessage))
						{
							scenario.MessageLog.Add(loggedMessage);
						}
						num2++;
						PercentageComplete = (double)num2 / (double)num;
					}
				}
				finally
				{
					IEnumerator enumerator16;
					if (enumerator16 is IDisposable)
					{
						(enumerator16 as IDisposable).Dispose();
					}
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/MessageIncrement");
				if (!Information.IsNothing(xmlNode))
				{
					scenario._MessageIncrement = (long)Conversions.ToInteger(xmlNode.InnerText);
				}
				scenario.UnitsAutoIncrement = Conversions.ToInteger(XMLDoc.SelectSingleNode("/" + str + "/UnitsAutoIncrement").InnerText);
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/MessageIncrement");
				if (!Information.IsNothing(xmlNode))
				{
					scenario._MessageIncrement = (long)Conversions.ToInteger(xmlNode.InnerText);
				}
				if (!Information.IsNothing(XMLDoc.SelectSingleNode("/" + str + "/CurrentSide")))
				{
					string innerText3 = XMLDoc.SelectSingleNode("/" + str + "/CurrentSide").InnerText;
					foreach (Side side in scenario.method_44())
					{
						if (Operators.CompareString(side.method_51(), innerText3, false) == 0)
						{
							scenario.method_53(side);
						}
					}
				}
				scenario.GameVersion = XMLDoc.SelectSingleNode("/" + str + "/GameVersion").InnerText;
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/LastSavedInScenEdit");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.LastSavedInScenEdit = true;
				}
				if (scenario.LastSavedInScenEdit)
				{
					scenario.ZeroHour = scenario._Time;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_DetailedGunFireControl");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_1);
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_RealisticSubComms");
				if (xmlNode != null)
				{
					scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_9);
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_LandTypeEffects");
				if (xmlNode != null)
				{
					scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_10);
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_UnlimitedAirWeapons");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_2);
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_UnlimitedBaseMags");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_2);
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_CommsJamming");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_4);
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_AircraftDamage");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_3);
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_CommsDisruption");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_5);
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/LuaXml");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.LuaXml = xmlNode.InnerText;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/LuaXmlPassed");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.LuaXmlPassed = xmlNode.InnerText;
				}
				checked
				{
					foreach (Side side2 in scenario.method_44())
					{
						side2.method_10(ref scenario, dictionary, false);
						List<Contact> list = new List<Contact>();
						list.AddRange(side2.method_44());
						try
						{
							foreach (Contact contact in list)
							{
								if (contact.method_64(ref scenario, ref dictionary, ref side2))
								{
									if (contact.activeUnit_0.method_92(side2) && contact.queue_0.Count == 0 && contact.method_125() == Contact_Base.IdentificationStatus.PreciseID)
									{
										contact.method_142(new ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime>(null, null, 0f, ActiveUnit_Sensory.Enum35.const_4, contact.activeUnit_0.scenario_0.method_31()));
									}
								}
								else
								{
									side2.method_11().Remove(contact.string_6);
								}
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator17;
							((IDisposable)enumerator17).Dispose();
						}
						List<Contact> list2 = new List<Contact>();
						list2.AddRange(side2.method_46());
						try
						{
							foreach (Contact contact2 in list2)
							{
								if (contact2.method_64(ref scenario, ref dictionary, ref side2))
								{
									if (contact2.activeUnit_0.method_92(side2) && contact2.queue_0.Count == 0 && contact2.method_125() == Contact_Base.IdentificationStatus.PreciseID)
									{
										contact2.method_142(new ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime>(null, null, 0f, ActiveUnit_Sensory.Enum35.const_4, contact2.activeUnit_0.scenario_0.method_31()));
									}
								}
								else
								{
									side2.method_12().Remove(contact2.string_6);
								}
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator18;
							((IDisposable)enumerator18).Dispose();
						}
						try
						{
							foreach (ReferencePoint referencePoint in side2.vmethod_12())
							{
								referencePoint.method_18(dictionary);
							}
						}
						finally
						{
							List<ReferencePoint>.Enumerator enumerator19;
							((IDisposable)enumerator19).Dispose();
						}
						try
						{
							foreach (Mission mission in side2.method_36(scenario))
							{
								if (!Information.IsNothing(mission))
								{
									mission.vmethod_6(ref scenario, side2, false);
									try
									{
										foreach (Mission.Flight flight in mission.list_1)
										{
											if (!Information.IsNothing(flight) && Enumerable.Count<Waypoint>(flight.method_15()) != 0)
											{
												Waypoint[] array3 = flight.method_15();
												for (int k = 0; k < array3.Length; k++)
												{
													array3[k].method_46(ref scenario, side2, false);
												}
											}
										}
									}
									finally
									{
										List<Mission.Flight>.Enumerator enumerator21;
										((IDisposable)enumerator21).Dispose();
									}
								}
							}
						}
						finally
						{
							IEnumerator<Mission> enumerator20;
							if (enumerator20 != null)
							{
								enumerator20.Dispose();
							}
						}
						List<ActiveUnit> list3 = Enumerable.ToList<ActiveUnit>(side2.activeUnit_0);
						try
						{
							foreach (ActiveUnit activeUnit4 in list3)
							{
								ActiveUnit activeUnit5 = (ActiveUnit)activeUnit4;
								activeUnit5.vmethod_88().method_73(ref activeUnit5, dictionary);
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator22;
							((IDisposable)enumerator22).Dispose();
						}
					}
					try
					{
						foreach (ActiveUnit activeUnit6 in scenario.vmethod_0().Values)
						{
							activeUnit6.method_100(ref scenario, dictionary);
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator23;
						if (enumerator23 != null)
						{
							enumerator23.Dispose();
						}
					}
					List<ActiveUnit> list4 = new List<ActiveUnit>();
					try
					{
						foreach (ActiveUnit activeUnit7 in scenario.vmethod_0().Values)
						{
							activeUnit7.vmethod_122(ref scenario, dictionary, list4, false);
							if (!activeUnit7.bool_1)
							{
								List<Class312> list5 = new List<Class312>();
								list5.AddRange(activeUnit7.vmethod_90().method_2());
								try
								{
									foreach (Class312 @class in list5)
									{
										try
										{
											@class.method_9(ref dictionary);
										}
										catch (Exception ex5)
										{
											activeUnit7.vmethod_90().method_5(@class);
											ex5.Data.Add("Error at 200052", ex5.Message);
											GameGeneral.smethod_25(ref ex5);
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
										}
									}
								}
								finally
								{
									List<Class312>.Enumerator enumerator25;
									((IDisposable)enumerator25).Dispose();
								}
								foreach (Sensor sensor in activeUnit7.vmethod_96())
								{
									sensor.method_40(ref scenario);
									if (Information.IsNothing(sensor.method_18()))
									{
										sensor.method_19(activeUnit7);
									}
								}
							}
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator24;
						if (enumerator24 != null)
						{
							enumerator24.Dispose();
						}
					}
					try
					{
						foreach (ActiveUnit activeUnit8 in list4)
						{
							scenario.vmethod_0().Remove(activeUnit8.string_0);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator26;
						((IDisposable)enumerator26).Dispose();
					}
					try
					{
						foreach (Explosion explosion in scenario.vmethod_12())
						{
							explosion.method_60(ref dictionary);
						}
					}
					finally
					{
						List<Explosion>.Enumerator enumerator27;
						((IDisposable)enumerator27).Dispose();
					}
					try
					{
						foreach (UnguidedWeapon unguidedWeapon2 in scenario.vmethod_20().Values)
						{
							unguidedWeapon2.method_60(ref scenario);
						}
					}
					finally
					{
						IEnumerator<UnguidedWeapon> enumerator28;
						if (enumerator28 != null)
						{
							enumerator28.Dispose();
						}
					}
					try
					{
						foreach (Group group2 in scenario.Groups)
						{
							group2.bool_27 = false;
						}
					}
					finally
					{
						IEnumerator<Group> enumerator29;
						if (enumerator29 != null)
						{
							enumerator29.Dispose();
						}
					}
					dictionary.Clear();
					try
					{
						foreach (string str2 in scenario.LoadingNotices)
						{
							ErrorFeedback = ErrorFeedback + "\r\n" + str2 + "\r\n";
						}
					}
					finally
					{
						List<string>.Enumerator enumerator30;
						((IDisposable)enumerator30).Dispose();
					}
					scenario.method_18(null);
					scenario.method_20(null);
					scenario.method_22(null);
					scenario.method_17();
					scenario.method_95();
					result = scenario;
				}
			}
			catch (Exception ex6)
			{
				ex6.Data.Add("Error at 101023", "");
				GameGeneral.smethod_25(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x001A67B0 File Offset: 0x001A49B0
		public static Scenario smethod_19(string theXMLText, ref string ErrorFeedback, ref double PercentageComplete, bool ForceDeepRebuild, bool CheckForDBTampering = true)
		{
			Scenario result;
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				try
				{
					xmlDocument.LoadXml(theXMLText);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200465", ex.Message);
					GameGeneral.smethod_25(ref ex);
					bool isAttached = Debugger.IsAttached;
					try
					{
						theXMLText = Misc.smethod_3(theXMLText);
						xmlDocument.LoadXml(theXMLText);
					}
					catch (Exception ex2)
					{
						ex.Data.Add("Error at 200466", ex.Message);
						GameGeneral.smethod_25(ref ex);
						bool isAttached2 = Debugger.IsAttached;
						theXMLText = Misc.smethod_5(theXMLText);
						xmlDocument.LoadXml(theXMLText);
					}
				}
				result = Scenario.smethod_18(xmlDocument, ref ErrorFeedback, ref PercentageComplete, ForceDeepRebuild, CheckForDBTampering);
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 101024", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x001A68B8 File Offset: 0x001A4AB8
		public static Scenario smethod_20(string string_0, ref string string_1, ref double double_0)
		{
			Scenario result;
			try
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
				XmlDocument xmlDocument = new XmlDocument();
				using (fileStream)
				{
					xmlDocument.Load(fileStream);
				}
				result = Scenario.smethod_18(xmlDocument, ref string_1, ref double_0, false, true);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101025", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x001A6950 File Offset: 0x001A4B50
		public bool method_14()
		{
			return this.method_47() < 15;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x001A6970 File Offset: 0x001A4B70
		public void method_15()
		{
			List<EventTrigger> list = new List<EventTrigger>();
			try
			{
				foreach (EventTrigger eventTrigger in this.vmethod_4().Values)
				{
					if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.ScenLoaded)
					{
						list.Add(eventTrigger);
					}
				}
			}
			finally
			{
				IEnumerator<EventTrigger> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (list.Count > 0)
			{
				this.method_24(list);
			}
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x001A69E4 File Offset: 0x001A4BE4
		public static string[] smethod_21(string string_0, List<string> list_0)
		{
			string[] array = new string[list_0.Count - 1 + 1];
			string s = ScenContainer.smethod_2(string_0).method_7();
			int num = list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				XmlReader xmlReader = XmlReader.Create(new StringReader(s));
				using (xmlReader)
				{
					if (xmlReader.ReadToDescendant(list_0[i]))
					{
						array[i] = xmlReader.ReadElementContentAsString();
					}
					else
					{
						array[i] = "";
					}
				}
			}
			return array;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x0000C01D File Offset: 0x0000A21D
		public static string smethod_22(string string_0, string string_1)
		{
			new List<string>();
			return Scenario.smethod_23(ScenContainer.smethod_2(string_0).method_7(), string_1);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x001A6A7C File Offset: 0x001A4C7C
		public static string smethod_23(string string_0, string string_1)
		{
			string result;
			try
			{
				XmlReader xmlReader = XmlReader.Create(new StringReader(string_0));
				using (xmlReader)
				{
					if (xmlReader.ReadToDescendant(string_1))
					{
						result = xmlReader.ReadElementContentAsString();
					}
					else
					{
						result = null;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101285", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x0000C036 File Offset: 0x0000A236
		public bool method_16()
		{
			return !string.IsNullOrEmpty(this.CampaignID) && !string.IsNullOrEmpty(this.CampaignSessionID);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x001A6B0C File Offset: 0x001A4D0C
		public List<Weapon> method_17()
		{
			List<Weapon> guidedWeaponsInAir;
			try
			{
				if (Information.IsNothing(this._GuidedWeaponsInAir) || Information.IsNothing(this._SonobuoysInWater) || Information.IsNothing(this._AllWeaponsAlive))
				{
					object lockObject = this.LockObject2;
					ObjectFlowControl.CheckForSyncLockOnValueType(lockObject);
					lock (lockObject)
					{
						if (Information.IsNothing(this._GuidedWeaponsInAir) || Information.IsNothing(this._SonobuoysInWater) || Information.IsNothing(this._AllWeaponsAlive))
						{
							List<Weapon> list = new List<Weapon>();
							List<Weapon> list2 = new List<Weapon>();
							List<Weapon> list3 = new List<Weapon>();
							List<ActiveUnit> list4 = this.method_42();
							int count = list4.Count;
							ActiveUnit activeUnit = null;
							int num = count - 1;
							int i = 0;
							while (i <= num)
							{
								try
								{
									activeUnit = list4[i];
								}
								catch (Exception ex)
								{
									goto IL_14A;
								}
								goto IL_BB;
								IL_14A:
								i++;
								continue;
								IL_BB:
								if (activeUnit == null || !activeUnit.bool_2)
								{
									goto IL_14A;
								}
								list3.Add((Weapon)activeUnit);
								Weapon weapon = (Weapon)activeUnit;
								if (weapon.method_0() || weapon.vmethod_2() || weapon.vmethod_3() || weapon.method_204() || (weapon.method_167() == Weapon._WeaponType.Torpedo && weapon.vmethod_94().Length > 0))
								{
									list.Add((Weapon)activeUnit);
									goto IL_14A;
								}
								if (weapon.method_167() == Weapon._WeaponType.Sonobuoy)
								{
									list2.Add((Weapon)activeUnit);
									goto IL_14A;
								}
								goto IL_14A;
							}
							this._GuidedWeaponsInAir = list;
							this._SonobuoysInWater = list2;
							this._AllWeaponsAlive = list3;
						}
					}
				}
				guidedWeaponsInAir = this._GuidedWeaponsInAir;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 101026", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				guidedWeaponsInAir = this._GuidedWeaponsInAir;
			}
			return guidedWeaponsInAir;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x0000C055 File Offset: 0x0000A255
		public void method_18(List<Weapon> list_0)
		{
			this._GuidedWeaponsInAir = list_0;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x001A6D2C File Offset: 0x001A4F2C
		public List<Weapon> method_19()
		{
			List<Weapon> sonobuoysInWater;
			try
			{
				if (Information.IsNothing(this._SonobuoysInWater))
				{
					this.method_17();
				}
				sonobuoysInWater = this._SonobuoysInWater;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101274", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				sonobuoysInWater = this._SonobuoysInWater;
			}
			return sonobuoysInWater;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x0000C05E File Offset: 0x0000A25E
		public void method_20(List<Weapon> list_0)
		{
			this._SonobuoysInWater = list_0;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x001A6DA4 File Offset: 0x001A4FA4
		public List<Weapon> method_21()
		{
			List<Weapon> allWeaponsAlive;
			try
			{
				if (this._AllWeaponsAlive == null)
				{
					this.method_17();
				}
				allWeaponsAlive = this._AllWeaponsAlive;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101275", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				allWeaponsAlive = this._AllWeaponsAlive;
			}
			return allWeaponsAlive;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0000C067 File Offset: 0x0000A267
		public void method_22(List<Weapon> list_0)
		{
			this._AllWeaponsAlive = list_0;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0000C070 File Offset: 0x0000A270
		public Weather.WeatherProfile method_23()
		{
			if (Information.IsNothing(this._GlobalWeather))
			{
				this._GlobalWeather = Weather.smethod_5();
			}
			return this._GlobalWeather;
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x001A6E18 File Offset: 0x001A5018
		public void method_24(List<EventTrigger> list_0)
		{
			try
			{
				try
				{
					foreach (EventTrigger eventTrigger in list_0)
					{
						List<SimEvent> list = Enumerable.ToList<SimEvent>(this.vmethod_10().Values);
						try
						{
							foreach (SimEvent simEvent in list)
							{
								if (simEvent.bool_12)
								{
									LuaSandBox.Singleton().EventX = simEvent;
									if (simEvent.list_0.Contains(eventTrigger))
									{
										if (simEvent.method_9(this))
										{
											if (simEvent.short_0 != 100 && GameGeneral.smethod_5().Next(0, 100) > (int)simEvent.short_0)
											{
												if (simEvent.bool_13)
												{
													this.method_59("Event: '" + simEvent.string_2 + "' was triggered but did NOT fire (failed probability check).", "Event triggered but not fired", LoggedMessage.MessageType.EventEngine, 1, "", null, default(Geopoint_Struct));
												}
												if (!simEvent.bool_11)
												{
													simEvent.bool_12 = false;
													continue;
												}
												continue;
											}
											else
											{
												ActiveUnit activeUnit = null;
												ActiveUnit activeUnit2 = null;
												Contact contact = null;
												List<Sensor> sensorsThatMadeDetection = null;
												if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitRemainsInArea)
												{
													activeUnit = ((Class333)eventTrigger).activeUnit_0;
												}
												else if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitEntersArea)
												{
													activeUnit = ((Class332)eventTrigger).activeUnit_0;
													if (Information.IsNothing(activeUnit))
													{
														if (!((Class332)eventTrigger).bool_11)
														{
															continue;
														}
													}
													else if (((Class332)eventTrigger).bool_12)
													{
														if (((Class332)eventTrigger).bool_15)
														{
															activeUnit.list_0.Add(((Class332)eventTrigger).string_0);
															continue;
														}
														if (((Class332)eventTrigger).bool_13)
														{
															activeUnit.list_0.Remove(((Class332)eventTrigger).string_0);
														}
													}
													else if (((Class332)eventTrigger).bool_15)
													{
														activeUnit.list_0.Add(((Class332)eventTrigger).string_0);
													}
													else if (((Class332)eventTrigger).bool_13)
													{
														activeUnit.list_0.Remove(((Class332)eventTrigger).string_0);
													}
												}
												else if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitDamaged)
												{
													activeUnit = ((Class336)eventTrigger).activeUnit_0;
													activeUnit2 = ((Class336)eventTrigger).activeUnit_1;
													this.method_10().UnitY = null;
												}
												else if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitDestroyed)
												{
													activeUnit = ((Class337)eventTrigger).activeUnit_0;
													activeUnit2 = ((Class337)eventTrigger).activeUnit_1;
													this.method_10().UnitY = null;
												}
												else if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitDetected)
												{
													activeUnit = ((Class329)eventTrigger).activeUnit_0;
													activeUnit2 = ((Class329)eventTrigger).activeUnit_1;
													sensorsThatMadeDetection = ((Class329)eventTrigger).list_1;
													contact = ((Class329)eventTrigger).contact_0;
													if (((Class329)eventTrigger).nullable_0 != null)
													{
														bool? nullable_ = ((Class329)eventTrigger).nullable_0;
														if (((nullable_ != null) ? new bool?(nullable_.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(contact))
														{
															contact.list_0.Add(((Class329)eventTrigger).string_0);
														}
													}
												}
												else if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitBaseStatus)
												{
													activeUnit = ((Class328)eventTrigger).activeUnit_0;
												}
												else if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.unitCargoMoved)
												{
													((Class330)eventTrigger).method_10();
													activeUnit = ((Class330)eventTrigger).activeUnit_0;
												}
												if (!Information.IsNothing(activeUnit))
												{
													this.method_10().UnitX = activeUnit;
												}
												if (!(Information.IsNothing(activeUnit) & Information.IsNothing(activeUnit2) & Information.IsNothing(contact)))
												{
													if (!Information.IsNothing(activeUnit2))
													{
														this.method_10().UnitY = activeUnit2;
														this.method_10().SensorsThatMadeDetection = sensorsThatMadeDetection;
													}
													else
													{
														LuaSandBox.Singleton().UnitY = null;
													}
													if (!Information.IsNothing(contact))
													{
														this.method_10().UnitC = contact;
													}
													else
													{
														LuaSandBox.Singleton().UnitC = null;
													}
												}
												if (simEvent.bool_13)
												{
													this.method_59("Event: '" + simEvent.string_2 + "' has been fired.", "Scenario event fired", LoggedMessage.MessageType.EventEngine, 1, "", null, default(Geopoint_Struct));
												}
												if (!simEvent.bool_11)
												{
													simEvent.bool_12 = false;
												}
												try
												{
													foreach (EventAction eventAction in simEvent.list_2)
													{
														eventAction.vmethod_5(this, simEvent);
													}
													continue;
												}
												finally
												{
													List<EventAction>.Enumerator enumerator3;
													((IDisposable)enumerator3).Dispose();
												}
											}
										}
										if (simEvent.bool_13)
										{
											this.method_59("Event: '" + simEvent.string_2 + "' was triggered but did NOT fire (at least one condition failed).", "Event triggered but NOT fired (insufficient conditions)", LoggedMessage.MessageType.EventEngine, 1, "", null, default(Geopoint_Struct));
										}
										if (!simEvent.bool_11)
										{
											simEvent.bool_12 = false;
										}
									}
								}
							}
						}
						finally
						{
							List<SimEvent>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					List<EventTrigger>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101028", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x0000C090 File Offset: 0x0000A290
		public bool method_25()
		{
			return this._HasEnded;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x0000C098 File Offset: 0x0000A298
		public bool method_26()
		{
			return DateTime.Compare(this.method_31(), this.method_27()) > 0;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x0000C0AE File Offset: 0x0000A2AE
		public DateTime method_27()
		{
			if (this._StartTime == null)
			{
				this._StartTime = new DateTime?(this.method_31());
			}
			return this._StartTime.Value;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x0000C0D9 File Offset: 0x0000A2D9
		public void method_28(DateTime dateTime_0)
		{
			this._StartTime = new DateTime?(dateTime_0);
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x0000C0E7 File Offset: 0x0000A2E7
		public TimeSpan method_29()
		{
			if (this._Duration == null)
			{
				this._Duration = new TimeSpan?(new TimeSpan(24, 0, 0));
			}
			return this._Duration.Value;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0000C115 File Offset: 0x0000A315
		public void method_30(TimeSpan timeSpan_0)
		{
			this._Duration = new TimeSpan?(timeSpan_0);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0000C123 File Offset: 0x0000A323
		public DateTime method_31()
		{
			return this._Time;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x001A73B4 File Offset: 0x001A55B4
		public void method_32(bool bool_0, DateTime dateTime_0)
		{
			try
			{
				if (this._TimeCompression > Scenario.enumTimeCompression.FiveSec)
				{
					this.SecondIsChangingOnThisPulse = true;
				}
				else if (this._Time.Second == dateTime_0.Second)
				{
					this.SecondIsChangingOnThisPulse = false;
				}
				else
				{
					this.SecondIsChangingOnThisPulse = true;
				}
				this.FifthSecondIsChangingOnThisPulse = false;
				this.FifteenthSecondIsChangingOnThisPulse = false;
				this.ThirtiethSecondIsChangingOnThisPulse = false;
				this.MinuteIsChangingOnThisPulse = false;
				this.FifthMinuteIsChangingOnThisPulse = false;
				this.FifteenthMinuteIsChangingOnThisPulse = false;
				this.ThirtiethMinuteIsChangingOnThisPulse = false;
				this.HourIsChangingOnThisPulse = false;
				this.SixHourIsChangingOnThisPulse = false;
				this.TwelveHourIsChangingOnThisPulse = false;
				this.TwentyFourHourIsChangingOnThisPulse = false;
				if (this.SecondIsChangingOnThisPulse && dateTime_0.Second % 5 == 0)
				{
					this.FifthSecondIsChangingOnThisPulse = true;
					if (dateTime_0.Second % 15 == 0)
					{
						this.FifteenthSecondIsChangingOnThisPulse = true;
						if (dateTime_0.Second % 30 == 0)
						{
							this.ThirtiethSecondIsChangingOnThisPulse = true;
							if (dateTime_0.Second % 60 == 0)
							{
								this.MinuteIsChangingOnThisPulse = true;
								if (dateTime_0.Minute % 5 == 0)
								{
									this.FifthMinuteIsChangingOnThisPulse = true;
									if (dateTime_0.Minute % 15 == 0)
									{
										this.FifteenthMinuteIsChangingOnThisPulse = true;
										if (dateTime_0.Minute % 30 == 0)
										{
											this.ThirtiethMinuteIsChangingOnThisPulse = true;
											if (this._Time.Hour != dateTime_0.Hour)
											{
												this.HourIsChangingOnThisPulse = true;
											}
										}
									}
								}
							}
						}
					}
				}
				TimeSpan timeSpan = dateTime_0 - this.method_27();
				if (timeSpan.TotalHours > 0.0 && this.HourIsChangingOnThisPulse && (timeSpan.Hours % 6 == 0 || timeSpan.TotalHours % 6.0 == 0.0))
				{
					this.SixHourIsChangingOnThisPulse = true;
					if (timeSpan.Hours % 12 == 0 || timeSpan.TotalHours % 12.0 == 0.0)
					{
						this.TwelveHourIsChangingOnThisPulse = true;
						if (timeSpan.Hours % 24 == 0 || timeSpan.TotalHours % 24.0 == 0.0)
						{
							this.TwentyFourHourIsChangingOnThisPulse = true;
						}
					}
				}
				List<EventTrigger> list = new List<EventTrigger>();
				if (bool_0)
				{
					Scenario.TimeChangedManuallyEventHandler timeChangedManuallyEvent = Scenario.TimeChangedManuallyEvent;
					if (timeChangedManuallyEvent != null)
					{
						timeChangedManuallyEvent(this, dateTime_0);
					}
					try
					{
						foreach (EventTrigger eventTrigger in this.vmethod_4().Values)
						{
							if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.Time)
							{
								TimeSpan t = dateTime_0 - this._Time;
								Class335 @class = (Class335)eventTrigger;
								ref DateTime ptr = ref @class.dateTime_0;
								@class.dateTime_0 = ptr + t;
							}
						}
						goto IL_368;
					}
					finally
					{
						IEnumerator<EventTrigger> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				try
				{
					foreach (EventTrigger eventTrigger2 in this.vmethod_4().Values)
					{
						if (eventTrigger2.eventTriggerType_0 == EventTrigger.EventTriggerType.Time && ((Class335)eventTrigger2).method_8(dateTime_0))
						{
							list.Add(eventTrigger2);
						}
						if (eventTrigger2.eventTriggerType_0 == EventTrigger.EventTriggerType.RandomTime && ((Class327)eventTrigger2).method_9(dateTime_0))
						{
							list.Add(eventTrigger2);
						}
						if (eventTrigger2.eventTriggerType_0 == EventTrigger.EventTriggerType.RegularTime && ((EventTrigger_RegularTime)eventTrigger2).method_8(this))
						{
							list.Add(eventTrigger2);
						}
					}
				}
				finally
				{
					IEnumerator<EventTrigger> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				if (this.SecondIsChangingOnThisPulse)
				{
					try
					{
						foreach (EventTrigger eventTrigger3 in this.vmethod_4().Values)
						{
							if (eventTrigger3.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitEntersArea && ((Class332)eventTrigger3).method_8(this))
							{
								list.Add(eventTrigger3);
							}
						}
					}
					finally
					{
						IEnumerator<EventTrigger> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
				}
				IL_368:
				this._Time = dateTime_0;
				this.method_24(list);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101029", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0000C12B File Offset: 0x0000A32B
		public bool method_33()
		{
			return this._DaylightSavingTime;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x0000C133 File Offset: 0x0000A333
		public void method_34(bool bool_0)
		{
			this._DaylightSavingTime = bool_0;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x0000C13C File Offset: 0x0000A33C
		public string method_35()
		{
			return this._DaylightSavingTime_Start;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0000C144 File Offset: 0x0000A344
		public void method_36(string string_0)
		{
			this._DaylightSavingTime_Start = string_0;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0000C14D File Offset: 0x0000A34D
		public string method_37()
		{
			return this._DaylightSavingTime_End;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0000C155 File Offset: 0x0000A355
		public void method_38(string string_0)
		{
			this._DaylightSavingTime_End = string_0;
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x001A77D8 File Offset: 0x001A59D8
		public SQLiteConnection method_39()
		{
			if (Information.IsNothing(this._DBConnection))
			{
				if (string.IsNullOrEmpty(this.method_7()))
				{
					this._DBConnection = null;
				}
				else
				{
					this._DBConnection = new SQLiteConnection(DBOps.smethod_13(Class160.smethod_1().Info.DirectoryPath, this.method_7()));
				}
			}
			return this._DBConnection;
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x0000C15E File Offset: 0x0000A35E
		public float method_40()
		{
			return this._GameResolution;
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x0000C166 File Offset: 0x0000A366
		public void method_41(float float_0)
		{
			this._GameResolution = float_0;
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x001A7834 File Offset: 0x001A5A34
		public List<ActiveUnit> method_42()
		{
			List<ActiveUnit> result;
			try
			{
				if (this._ActiveUnits_List == null || this._ActiveUnits_List.Count != this.vmethod_0().Count)
				{
					object lockObject = this.LockObject1;
					ObjectFlowControl.CheckForSyncLockOnValueType(lockObject);
					lock (lockObject)
					{
						if (this._ActiveUnits_List == null || this._ActiveUnits_List.Count != this.vmethod_0().Count)
						{
							this._ActiveUnits_List = new List<ActiveUnit>(this.vmethod_0().Count);
							try
							{
								foreach (KeyValuePair<string, ActiveUnit> keyValuePair in this.vmethod_0())
								{
									this._ActiveUnits_List.Add(keyValuePair.Value);
								}
							}
							finally
							{
								IEnumerator<KeyValuePair<string, ActiveUnit>> enumerator;
								if (enumerator != null)
								{
									enumerator.Dispose();
								}
							}
						}
					}
				}
				result = this._ActiveUnits_List;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200053", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Enumerable.ToList<ActiveUnit>(this.vmethod_0().Values);
			}
			return result;
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x001A7978 File Offset: 0x001A5B78
		public void method_43(List<ActiveUnit> list_0)
		{
			object lockObject = this.LockObject1;
			ObjectFlowControl.CheckForSyncLockOnValueType(lockObject);
			lock (lockObject)
			{
				this._ActiveUnits_List = list_0;
			}
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x0000C16F File Offset: 0x0000A36F
		public Side[] method_44()
		{
			return this._Sides;
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0000C177 File Offset: 0x0000A377
		public List<ActiveUnit> method_45()
		{
			return this._UnitAdditions;
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0000C17F File Offset: 0x0000A37F
		public List<ActiveUnit> method_46()
		{
			return this._UnitRemovals;
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x001A79C0 File Offset: 0x001A5BC0
		public int method_47()
		{
			int result;
			switch (this._TimeCompression)
			{
			case Scenario.enumTimeCompression.OneSec:
				result = 1;
				break;
			case Scenario.enumTimeCompression.TwoSec:
				result = 2;
				break;
			case Scenario.enumTimeCompression.FiveSec:
				result = 5;
				break;
			case Scenario.enumTimeCompression.Turbo:
				result = 15;
				break;
			default:
				result = 1;
				break;
			}
			return result;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x001A7A00 File Offset: 0x001A5C00
		public void method_48()
		{
			this._HasEnded = true;
			Scenario.ScenCompletedEventHandler scenCompletedEvent = Scenario.ScenCompletedEvent;
			if (scenCompletedEvent != null)
			{
				scenCompletedEvent(this);
			}
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x0000C187 File Offset: 0x0000A387
		private void method_49()
		{
			if (this._TimeCompression < Scenario.enumTimeCompression.Turbo)
			{
				this.method_41(0.1f);
				return;
			}
			this.method_41(1f);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x001A7A24 File Offset: 0x001A5C24
		public void method_50()
		{
			if (this._TimeCompression < Scenario.enumTimeCompression.Turbo)
			{
				this._TimeCompression += 1;
				this.method_49();
				Scenario.TimeCompressionChangedEventHandler timeCompressionChangedEvent = Scenario.TimeCompressionChangedEvent;
				if (timeCompressionChangedEvent != null)
				{
					timeCompressionChangedEvent();
				}
			}
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x001A7A60 File Offset: 0x001A5C60
		public void method_51()
		{
			if (this._TimeCompression > Scenario.enumTimeCompression.OneSec)
			{
				this._TimeCompression = (Scenario.enumTimeCompression)(this._TimeCompression - Scenario.enumTimeCompression.TwoSec);
				this.method_49();
				Scenario.TimeCompressionChangedEventHandler timeCompressionChangedEvent = Scenario.TimeCompressionChangedEvent;
				if (timeCompressionChangedEvent != null)
				{
					timeCompressionChangedEvent();
				}
			}
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x001A7A9C File Offset: 0x001A5C9C
		public void method_52(Scenario.enumTimeCompression enumTimeCompression_0)
		{
			this._TimeCompression = enumTimeCompression_0;
			this.method_49();
			Scenario.TimeCompressionChangedEventHandler timeCompressionChangedEvent = Scenario.TimeCompressionChangedEvent;
			if (timeCompressionChangedEvent != null)
			{
				timeCompressionChangedEvent();
			}
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x001A7AC8 File Offset: 0x001A5CC8
		public void method_53(Side side_0)
		{
			this._CurrentSide = side_0;
			Scenario.CurrentSideChangedEventHandler currentSideChangedEvent = Scenario.CurrentSideChangedEvent;
			if (currentSideChangedEvent != null)
			{
				currentSideChangedEvent(this);
			}
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x001A7AEC File Offset: 0x001A5CEC
		public Side method_54()
		{
			Side result;
			if (this.method_44().Length == 0)
			{
				result = null;
			}
			else if (Information.IsNothing(this._CurrentSide))
			{
				result = this.method_44()[0];
			}
			else
			{
				result = this._CurrentSide;
			}
			return result;
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x001A7B28 File Offset: 0x001A5D28
		public Scenario()
		{
			this.RunningInMonteCarloMode = false;
			this.vmethod_1(new ObservableDictionary<string, ActiveUnit>());
			this.Groups = new GroupsCollection();
			this._GuidedWeaponsInAir = new List<Weapon>();
			this._SonobuoysInWater = new List<Weapon>();
			this._AllWeaponsAlive = new List<Weapon>();
			this._Sides = new Side[0];
			this._UnitAdditions = new List<ActiveUnit>();
			this._UnitRemovals = new List<ActiveUnit>();
			this._UnitDeletions = new List<ActiveUnit>();
			this.Navigation_FinegrainedThresholdDistance = 8f;
			this.Navigation_FinegrainedMaxDistance = 0.5f;
			this.UserIsPlottingCourse = false;
			this.vmethod_3(new ObservableDictionary<string, ScenAttachmentObject>());
			this.UnhandledPopUpMessages = new Queue<LoggedMessage>();
			this.MessageLog = new List<LoggedMessage>();
			this.MessageLogQueue = new ConcurrentQueue<LoggedMessage>();
			this.UnitsForLateInstantiation = new HashSet<XmlNode>();
			this.Cache_FacilitiesWithPiers = new List<ActiveUnit>();
			this.Cache_Weapons = new ConcurrentDictionary<int, Weapon>();
			this.Cache_SensorCompatibleFrequencies = new ConcurrentDictionary<int, ConcurrentDictionary<int, bool>>();
			this.Cache_XSections = new ConcurrentDictionary<string, XSection[]>();
			this.Cache_Aircraft_DT = new DataTable();
			this.Cache_Ships_DT = new DataTable();
			this.Cache_Subs_DT = new DataTable();
			this.Cache_Facilities_DT = new DataTable();
			this.Cache_Satellites_DT = new DataTable();
			this.Cache_Weapons_DT = new DataTable();
			this.Cache_OperatorCountries_DT = new DataTable();
			this.Cache_FuelForPitchEnabledWeapons = new ConcurrentDictionary<int, int>();
			this.Cache_TimeOfDay = new Weather.TTimeOfDayType?[360][];
			this.Cache_AssociatedSensors = new Dictionary<int, Sensor>();
			this.Cache_PowerplantAltBands = new ConcurrentDictionary<int, AltBand[]>();
			this.CandidatesForDetectionByMines = new ActiveUnit[0];
			this.LoadingNotices = new List<string>();
			this.ThreadedOpsMustStop = false;
			this.DeclaredFeatures = new HashSet<Scenario.ScenarioFeatureOption>();
			this.LastSavedInScenEdit = false;
			this.FeatureCompatibility = default(Scenario._FeatureCompatibility);
			this.EventWaitHandle_FinishPulse = new EventWaitHandle(false, EventResetMode.AutoReset);
			this.MissionPlannerErrorList = new List<string>();
			this.vmethod_5(new ObservableDictionary<string, EventTrigger>());
			this.vmethod_7(new ObservableDictionary<string, EventCondition>());
			this.vmethod_9(new ObservableDictionary<string, EventAction>());
			this.vmethod_11(new ObservableDictionary<string, SimEvent>());
			this.vmethod_13(new ObservableList<Explosion>());
			this.vmethod_15(new ObservableList<WeaponImpact>());
			this.vmethod_17(new List<WaterSplash>());
			this.vmethod_19(new List<GroundImpact>());
			this.vmethod_21(new ObservableDictionary<string, UnguidedWeapon>());
			this.ChaffClouds = new List<ChaffCorridorCloud>();
			this.LockObject1 = RuntimeHelpers.GetObjectValue(new object());
			this.LockObject2 = RuntimeHelpers.GetObjectValue(new object());
			this.TimelineID = Guid.NewGuid().ToString();
			this._ObjectID = Guid.NewGuid().ToString();
			this.ZeroHour = this._Time;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x001A7DC4 File Offset: 0x001A5FC4
		public Scenario(string string_0, string string_1, string string_2)
		{
			this.RunningInMonteCarloMode = false;
			this.vmethod_1(new ObservableDictionary<string, ActiveUnit>());
			this.Groups = new GroupsCollection();
			this._GuidedWeaponsInAir = new List<Weapon>();
			this._SonobuoysInWater = new List<Weapon>();
			this._AllWeaponsAlive = new List<Weapon>();
			this._Sides = new Side[0];
			this._UnitAdditions = new List<ActiveUnit>();
			this._UnitRemovals = new List<ActiveUnit>();
			this._UnitDeletions = new List<ActiveUnit>();
			this.Navigation_FinegrainedThresholdDistance = 8f;
			this.Navigation_FinegrainedMaxDistance = 0.5f;
			this.UserIsPlottingCourse = false;
			this.vmethod_3(new ObservableDictionary<string, ScenAttachmentObject>());
			this.UnhandledPopUpMessages = new Queue<LoggedMessage>();
			this.MessageLog = new List<LoggedMessage>();
			this.MessageLogQueue = new ConcurrentQueue<LoggedMessage>();
			this.UnitsForLateInstantiation = new HashSet<XmlNode>();
			this.Cache_FacilitiesWithPiers = new List<ActiveUnit>();
			this.Cache_Weapons = new ConcurrentDictionary<int, Weapon>();
			this.Cache_SensorCompatibleFrequencies = new ConcurrentDictionary<int, ConcurrentDictionary<int, bool>>();
			this.Cache_XSections = new ConcurrentDictionary<string, XSection[]>();
			this.Cache_Aircraft_DT = new DataTable();
			this.Cache_Ships_DT = new DataTable();
			this.Cache_Subs_DT = new DataTable();
			this.Cache_Facilities_DT = new DataTable();
			this.Cache_Satellites_DT = new DataTable();
			this.Cache_Weapons_DT = new DataTable();
			this.Cache_OperatorCountries_DT = new DataTable();
			this.Cache_FuelForPitchEnabledWeapons = new ConcurrentDictionary<int, int>();
			this.Cache_TimeOfDay = new Weather.TTimeOfDayType?[360][];
			this.Cache_AssociatedSensors = new Dictionary<int, Sensor>();
			this.Cache_PowerplantAltBands = new ConcurrentDictionary<int, AltBand[]>();
			this.CandidatesForDetectionByMines = new ActiveUnit[0];
			this.LoadingNotices = new List<string>();
			this.ThreadedOpsMustStop = false;
			this.DeclaredFeatures = new HashSet<Scenario.ScenarioFeatureOption>();
			this.LastSavedInScenEdit = false;
			this.FeatureCompatibility = default(Scenario._FeatureCompatibility);
			this.EventWaitHandle_FinishPulse = new EventWaitHandle(false, EventResetMode.AutoReset);
			this.MissionPlannerErrorList = new List<string>();
			this.vmethod_5(new ObservableDictionary<string, EventTrigger>());
			this.vmethod_7(new ObservableDictionary<string, EventCondition>());
			this.vmethod_9(new ObservableDictionary<string, EventAction>());
			this.vmethod_11(new ObservableDictionary<string, SimEvent>());
			this.vmethod_13(new ObservableList<Explosion>());
			this.vmethod_15(new ObservableList<WeaponImpact>());
			this.vmethod_17(new List<WaterSplash>());
			this.vmethod_19(new List<GroundImpact>());
			this.vmethod_21(new ObservableDictionary<string, UnguidedWeapon>());
			this.ChaffClouds = new List<ChaffCorridorCloud>();
			this.LockObject1 = RuntimeHelpers.GetObjectValue(new object());
			this.LockObject2 = RuntimeHelpers.GetObjectValue(new object());
			this.method_1(string_0);
			this.method_5(string_1);
			this.FileName = string_2;
			this.method_32(false, DateTime.UtcNow);
			this.TimelineID = Guid.NewGuid().ToString();
			this._ObjectID = Guid.NewGuid().ToString();
			this.ZeroHour = this._Time;
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x001A8084 File Offset: 0x001A6284
		public Scenario(string string_0)
		{
			this.RunningInMonteCarloMode = false;
			this.vmethod_1(new ObservableDictionary<string, ActiveUnit>());
			this.Groups = new GroupsCollection();
			this._GuidedWeaponsInAir = new List<Weapon>();
			this._SonobuoysInWater = new List<Weapon>();
			this._AllWeaponsAlive = new List<Weapon>();
			this._Sides = new Side[0];
			this._UnitAdditions = new List<ActiveUnit>();
			this._UnitRemovals = new List<ActiveUnit>();
			this._UnitDeletions = new List<ActiveUnit>();
			this.Navigation_FinegrainedThresholdDistance = 8f;
			this.Navigation_FinegrainedMaxDistance = 0.5f;
			this.UserIsPlottingCourse = false;
			this.vmethod_3(new ObservableDictionary<string, ScenAttachmentObject>());
			this.UnhandledPopUpMessages = new Queue<LoggedMessage>();
			this.MessageLog = new List<LoggedMessage>();
			this.MessageLogQueue = new ConcurrentQueue<LoggedMessage>();
			this.UnitsForLateInstantiation = new HashSet<XmlNode>();
			this.Cache_FacilitiesWithPiers = new List<ActiveUnit>();
			this.Cache_Weapons = new ConcurrentDictionary<int, Weapon>();
			this.Cache_SensorCompatibleFrequencies = new ConcurrentDictionary<int, ConcurrentDictionary<int, bool>>();
			this.Cache_XSections = new ConcurrentDictionary<string, XSection[]>();
			this.Cache_Aircraft_DT = new DataTable();
			this.Cache_Ships_DT = new DataTable();
			this.Cache_Subs_DT = new DataTable();
			this.Cache_Facilities_DT = new DataTable();
			this.Cache_Satellites_DT = new DataTable();
			this.Cache_Weapons_DT = new DataTable();
			this.Cache_OperatorCountries_DT = new DataTable();
			this.Cache_FuelForPitchEnabledWeapons = new ConcurrentDictionary<int, int>();
			this.Cache_TimeOfDay = new Weather.TTimeOfDayType?[360][];
			this.Cache_AssociatedSensors = new Dictionary<int, Sensor>();
			this.Cache_PowerplantAltBands = new ConcurrentDictionary<int, AltBand[]>();
			this.CandidatesForDetectionByMines = new ActiveUnit[0];
			this.LoadingNotices = new List<string>();
			this.ThreadedOpsMustStop = false;
			this.DeclaredFeatures = new HashSet<Scenario.ScenarioFeatureOption>();
			this.LastSavedInScenEdit = false;
			this.FeatureCompatibility = default(Scenario._FeatureCompatibility);
			this.EventWaitHandle_FinishPulse = new EventWaitHandle(false, EventResetMode.AutoReset);
			this.MissionPlannerErrorList = new List<string>();
			this.vmethod_5(new ObservableDictionary<string, EventTrigger>());
			this.vmethod_7(new ObservableDictionary<string, EventCondition>());
			this.vmethod_9(new ObservableDictionary<string, EventAction>());
			this.vmethod_11(new ObservableDictionary<string, SimEvent>());
			this.vmethod_13(new ObservableList<Explosion>());
			this.vmethod_15(new ObservableList<WeaponImpact>());
			this.vmethod_17(new List<WaterSplash>());
			this.vmethod_19(new List<GroundImpact>());
			this.vmethod_21(new ObservableDictionary<string, UnguidedWeapon>());
			this.ChaffClouds = new List<ChaffCorridorCloud>();
			this.LockObject1 = RuntimeHelpers.GetObjectValue(new object());
			this.LockObject2 = RuntimeHelpers.GetObjectValue(new object());
			this._Time = DateAndTime.Now.ToUniversalTime();
			this.method_8(string_0);
			this.TimelineID = Guid.NewGuid().ToString();
			this._ObjectID = Guid.NewGuid().ToString();
			this.ZeroHour = this._Time;
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0000C1A9 File Offset: 0x0000A3A9
		public long method_55()
		{
			return this._MessageIncrement;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x001A833C File Offset: 0x001A653C
		public void method_56()
		{
			ref long ptr = ref this._MessageIncrement;
			this._MessageIncrement = ptr + 1L;
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x001A8360 File Offset: 0x001A6560
		private void method_57()
		{
			this.CurrentlyInsertingMessages = true;
			while (this.MessageLogQueue.Count > 0)
			{
				try
				{
					Scenario.Class297 @class = new Scenario.Class297(@class);
					LoggedMessage loggedMessage;
					this.MessageLogQueue.TryDequeue(out loggedMessage);
					if (loggedMessage != null)
					{
						@class.side_0 = loggedMessage.side_0;
						@class.dateTime_0 = loggedMessage.dateTime_0;
						@class.string_0 = loggedMessage.string_2;
						List<LoggedMessage> messageLog = this.MessageLog;
						int count = messageLog.Count;
						@class.bool_0 = false;
						if (!this.RunningInMonteCarloMode && @class.side_0 != null)
						{
							try
							{
								Parallel.ForEach<LoggedMessage>(messageLog, new Action<LoggedMessage, ParallelLoopState>(@class.method_0));
							}
							catch (Exception ex)
							{
							}
						}
						if (!@class.bool_0)
						{
							this.MessageLog.Add(loggedMessage);
						}
						if (@class.side_0 != null)
						{
							LoggedMessage.MessageType messageType_ = loggedMessage.messageType_0;
							if (messageType_ - LoggedMessage.MessageType.NewContact <= 1 || messageType_ - LoggedMessage.MessageType.UnitLost <= 1 || messageType_ - LoggedMessage.MessageType.NewAirContact <= 3)
							{
								Side[] array = this.method_44();
								checked
								{
									for (int i = 0; i < array.Length; i++)
									{
										Scenario.Class298 class2 = new Scenario.Class298(class2);
										class2.class297_0 = @class;
										class2.side_0 = array[i];
										if (class2.side_0 != loggedMessage.side_0 && loggedMessage.side_0.method_68(class2.side_0) == Misc.PostureStance.Friendly)
										{
											Scenario.Class299 class3 = new Scenario.Class299(class3);
											class3.class298_0 = class2;
											class3.bool_0 = false;
											if (this.RunningInMonteCarloMode)
											{
												goto IL_1D9;
											}
											try
											{
												Parallel.ForEach<LoggedMessage>(messageLog, new Action<LoggedMessage, ParallelLoopState>(class3.method_0));
												goto IL_1D9;
											}
											catch (Exception ex2)
											{
												goto IL_1D9;
											}
											IL_178:
											this.method_56();
											LoggedMessage item = new LoggedMessage(this._MessageIncrement, loggedMessage.string_2, loggedMessage.string_4, loggedMessage.messageType_0, loggedMessage.dateTime_0, loggedMessage.string_3, loggedMessage.byte_0, class3.class298_0.side_0, loggedMessage.nullable_0);
											this.MessageLog.Add(item);
											goto IL_1CE;
											IL_1D9:
											if (!class3.bool_0)
											{
												goto IL_178;
											}
										}
										IL_1CE:;
									}
								}
							}
						}
					}
				}
				catch (Exception ex3)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			this.CurrentlyInsertingMessages = false;
			this.EventWaitHandle_FinishPulse.Set();
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x001A85E0 File Offset: 0x001A67E0
		public void method_58(LoggedMessage loggedMessage_0)
		{
			if (loggedMessage_0 != null)
			{
				Scenario.NewMessageEventHandler newMessageEvent = Scenario.NewMessageEvent;
				if (newMessageEvent != null)
				{
					newMessageEvent(loggedMessage_0);
				}
				if (Class570.class280_0.dictionary_0[loggedMessage_0.messageType_0].bool_0)
				{
					this.MessageLogQueue.Enqueue(loggedMessage_0);
					if (!this.CurrentlyInsertingMessages)
					{
						Task.Factory.StartNew(new Action(this.method_57));
					}
				}
				if (Class570.class280_0.dictionary_0[loggedMessage_0.messageType_0].bool_1)
				{
					this.UnhandledPopUpMessages.Enqueue(loggedMessage_0);
				}
			}
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x001A8670 File Offset: 0x001A6870
		public void method_59(string MessageText, string MessageSummary, LoggedMessage.MessageType MessageType, byte MessageLevel, string ReporterID, Side theSide = null, Geopoint_Struct theLocation = default(Geopoint_Struct))
		{
			try
			{
				if (MessageType != LoggedMessage.MessageType.UnguidedWeaponModifiers || GameGeneral.smethod_6() || GameGeneral.smethod_8() || GameGeneral.smethod_7() || GameGeneral.smethod_9())
				{
					if (this._MessageIncrement == 9223372036854775807L)
					{
						this._MessageIncrement = 1L;
					}
					else
					{
						this._MessageIncrement += 1L;
					}
					LoggedMessage loggedMessage_ = new LoggedMessage(this._MessageIncrement, MessageText, MessageSummary, MessageType, this._Time, ReporterID, MessageLevel, theSide, new Geopoint_Struct?(theLocation));
					this.method_58(loggedMessage_);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101031", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x001A874C File Offset: 0x001A694C
		public void method_60()
		{
			try
			{
				List<Explosion> list = new List<Explosion>();
				try
				{
					foreach (Explosion explosion in this.vmethod_12())
					{
						if (explosion.method_63())
						{
							list.Add(explosion);
						}
					}
				}
				finally
				{
					List<Explosion>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (Explosion gparam_ in list)
					{
						this.vmethod_12().method_6(gparam_);
					}
				}
				finally
				{
					List<Explosion>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101032", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x001A8838 File Offset: 0x001A6A38
		public void method_61()
		{
			try
			{
				List<WeaponImpact> list = new List<WeaponImpact>();
				try
				{
					foreach (WeaponImpact weaponImpact in this.vmethod_14())
					{
						if (weaponImpact.float_9 > 5f)
						{
							list.Add(weaponImpact);
						}
					}
				}
				finally
				{
					List<WeaponImpact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (WeaponImpact gparam_ in list)
					{
						this.vmethod_14().method_6(gparam_);
					}
				}
				finally
				{
					List<WeaponImpact>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 10324052394609", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x0000C1B1 File Offset: 0x0000A3B1
		public void method_62()
		{
			this.MessageLog.Clear();
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x001A892C File Offset: 0x001A6B2C
		public void method_63()
		{
			try
			{
				for (int i = this._UnitAdditions.Count - 1; i >= 0; i += -1)
				{
					ActiveUnit activeUnit = this._UnitAdditions[i];
					if (string.IsNullOrEmpty(activeUnit.string_0))
					{
						activeUnit.vmethod_1();
					}
					if (!this.vmethod_0().ContainsKey(activeUnit.string_0))
					{
						this.vmethod_0().Add(activeUnit.string_0, activeUnit);
					}
					this._UnitAdditions.Remove(activeUnit);
				}
				for (int j = this._UnitRemovals.Count - 1; j >= 0; j += -1)
				{
					ActiveUnit activeUnit = this._UnitRemovals[j];
					if (this._UnitDeletions.Contains(activeUnit))
					{
						this._UnitDeletions.Remove(activeUnit);
					}
					this.vmethod_0().Remove(activeUnit.string_0);
					this._UnitRemovals.Remove(activeUnit);
					activeUnit.vmethod_133(false, false, false);
				}
				for (int k = this._UnitDeletions.Count - 1; k >= 0; k += -1)
				{
					ActiveUnit activeUnit = this._UnitDeletions[k];
					activeUnit.vmethod_133(true, false, false);
					this.vmethod_0().Remove(activeUnit.string_0);
					this._UnitDeletions.Remove(activeUnit);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101033", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0000C1BE File Offset: 0x0000A3BE
		public void method_64(ActiveUnit activeUnit_0)
		{
			if (!this._UnitDeletions.Contains(activeUnit_0))
			{
				this._UnitDeletions.Add(activeUnit_0);
			}
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0000C1DA File Offset: 0x0000A3DA
		public void method_65(ActiveUnit activeUnit_0)
		{
			if (!this._UnitRemovals.Contains(activeUnit_0))
			{
				this._UnitRemovals.Add(activeUnit_0);
			}
			this.method_67(activeUnit_0);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x001A8AB0 File Offset: 0x001A6CB0
		public void method_66(string string_0, bool bool_0)
		{
			ActiveUnit activeUnit = null;
			try
			{
				if (this.vmethod_0().TryGetValue(string_0, ref activeUnit))
				{
					this.method_67(activeUnit);
					activeUnit.vmethod_133(bool_0, false, false);
				}
				else if (this.vmethod_20().ContainsKey(string_0))
				{
					this.method_67(activeUnit);
					UnguidedWeapon unguidedWeapon = this.vmethod_20()[string_0];
					Scenario scenario = this;
					unguidedWeapon.method_75(ref scenario);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 300018", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x001A8B54 File Offset: 0x001A6D54
		private void method_67(Unit unit_0)
		{
			foreach (IEventExporter eventExporter in this.method_6())
			{
				if (eventExporter.imethod_8() && eventExporter.imethod_20())
				{
					Dictionary<string, IEventExporter.EventNotificationParameter> dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>(9);
					if (this.MonteCarloIteration > 0)
					{
						dictionary.Add("Scenario", new IEventExporter.EventNotificationParameter(this.method_0(), typeof(string), 500));
						dictionary.Add("MC_Run", new IEventExporter.EventNotificationParameter(this.MonteCarloIteration, typeof(int), 0));
					}
					dictionary.Add("TimelineID", new IEventExporter.EventNotificationParameter(this.TimelineID, typeof(string), 40));
					if (eventExporter.imethod_10())
					{
						dictionary.Add("Time", new IEventExporter.EventNotificationParameter(this.method_31().Subtract(this.ZeroHour).ToString("c"), typeof(TimeSpan), 0));
					}
					else
					{
						dictionary.Add("Time", new IEventExporter.EventNotificationParameter(this.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + this.method_31().Millisecond.ToString("D3"), typeof(DateTime), 0));
					}
					dictionary.Add("UnitID", new IEventExporter.EventNotificationParameter(unit_0.string_0, typeof(string), 40));
					dictionary.Add("UnitName", new IEventExporter.EventNotificationParameter(unit_0.Name, typeof(string), 500));
					dictionary.Add("UnitClass", new IEventExporter.EventNotificationParameter(unit_0.string_2, typeof(string), 500));
					dictionary.Add("UnitSide", new IEventExporter.EventNotificationParameter(unit_0.vmethod_7(false).method_51(), typeof(string), 500));
					dictionary.Add("MiscInfo", new IEventExporter.EventNotificationParameter(string.Empty, typeof(string), 0));
					eventExporter.imethod_6(IEventExporter.ExportedEventType.UnitDestroyed, dictionary, this);
				}
			}
			foreach (Interface8 @interface in Class409.interface8_0)
			{
				if (@interface.imethod_3() && (@interface.imethod_0() != Interface8.Enum136.const_1 || unit_0.enum122_0 != Unit.Enum122.const_1))
				{
					@interface.imethod_1(Interface8.Enum135.const_5, new Dictionary<string, Tuple<Type, string>>
					{
						{
							"TimelineID",
							new Tuple<Type, string>(typeof(string), this.TimelineID)
						},
						{
							"Time",
							new Tuple<Type, string>(typeof(DateTime), this.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + this.method_31().Millisecond.ToString("D3"))
						},
						{
							"UnitID",
							new Tuple<Type, string>(typeof(string), unit_0.string_0)
						},
						{
							"UnitName",
							new Tuple<Type, string>(typeof(string), unit_0.Name)
						},
						{
							"UnitClass",
							new Tuple<Type, string>(typeof(string), unit_0.string_2)
						},
						{
							"UnitSide",
							new Tuple<Type, string>(typeof(string), unit_0.vmethod_7(false).method_51())
						},
						{
							"MiscInfo",
							new Tuple<Type, string>(typeof(string), "")
						}
					}, this);
				}
			}
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0000C1FD File Offset: 0x0000A3FD
		public void method_68(ActiveUnit activeUnit_0)
		{
			if (!this._UnitAdditions.Contains(activeUnit_0))
			{
				this._UnitAdditions.Add(activeUnit_0);
			}
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x001A8EF0 File Offset: 0x001A70F0
		public void method_69(Side side_0)
		{
			if (!Enumerable.Contains<Side>(this._Sides, side_0))
			{
				Class429.smethod_30(ref this._Sides, side_0);
				Scenario.SidesChangedEventHandler sidesChangedEvent = Scenario.SidesChangedEvent;
				if (sidesChangedEvent != null)
				{
					sidesChangedEvent(this, Scenario.Enum117.const_0);
				}
			}
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x001A8F28 File Offset: 0x001A7128
		public void method_70(Side side_0)
		{
			Class429.smethod_31(ref this._Sides, side_0);
			Scenario.SidesChangedEventHandler sidesChangedEvent = Scenario.SidesChangedEvent;
			if (sidesChangedEvent != null)
			{
				sidesChangedEvent(this, Scenario.Enum117.const_1);
			}
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x001A8F54 File Offset: 0x001A7154
		public static void smethod_24(Scenario scenario_0)
		{
			Scenario.CurrentScenarioChangedEventHandler currentScenarioChangedEvent = Scenario.CurrentScenarioChangedEvent;
			if (currentScenarioChangedEvent != null)
			{
				currentScenarioChangedEvent(scenario_0);
			}
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x001A8F74 File Offset: 0x001A7174
		public Aircraft method_71(Side theSide, string theName, double Longitude, double Latitude, int AircraftDBID, int LoadoutID, float Altitude, Unit.Enum122 theRemoteSimEntityType = Unit.Enum122.const_0, string theGUID = null)
		{
			Aircraft result;
			try
			{
				if (this.method_74(theGUID))
				{
					throw new Exception("Requested custom GUID is already in use in this scenario");
				}
				Scenario scenario = this;
				Aircraft aircraft = new Aircraft(ref scenario, theGUID);
				scenario = this;
				DBFunctions.smethod_19(ref scenario, ref aircraft, AircraftDBID, true);
				this.UnitsAutoIncrement++;
				aircraft.Name = theName;
				aircraft.vmethod_8(false, theSide);
				if (LoadoutID > 0)
				{
					DBFunctions.smethod_48(ref aircraft, LoadoutID, false);
				}
				aircraft.vmethod_134(ActiveUnit.Throttle.Loiter, null);
				aircraft.method_159().vmethod_7();
				aircraft.vmethod_10(0f);
				aircraft.vmethod_41((float)aircraft.method_159().vmethod_40(Altitude, ActiveUnit.Throttle.Loiter, false));
				aircraft.vmethod_31(null, Latitude);
				aircraft.vmethod_29(null, Longitude);
				aircraft.vmethod_15(false, Altitude);
				aircraft.method_164().method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
				aircraft.vmethod_69(ActiveUnit.Enum28.const_0, 0f);
				aircraft.vmethod_73(Altitude);
				ActiveUnit activeUnit = aircraft;
				scenario = this;
				GameGeneral.smethod_22(ref activeUnit, ref scenario);
				checked
				{
					if (aircraft.method_167() != null)
					{
						WeaponRec[] weaponRec_ = aircraft.method_167().weaponRec_0;
						for (int i = 0; i < weaponRec_.Length; i++)
						{
							Weapon weapon = weaponRec_[i].method_12(aircraft.scenario_0);
							weapon.vmethod_29(null, aircraft.vmethod_28(null));
							weapon.vmethod_31(null, aircraft.vmethod_30(null));
							weapon.vmethod_15(false, aircraft.vmethod_14(false));
							weapon.vmethod_10(aircraft.vmethod_9());
							weapon.vmethod_41(aircraft.vmethod_40());
						}
					}
					aircraft.method_159().method_16(true);
					result = aircraft;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101034", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x001A9178 File Offset: 0x001A7378
		public Satellite method_72(Side theSide, string theName, int SatelliteDBID, int OrbitIndex, Unit.Enum122 theRemoteSimEntityType = Unit.Enum122.const_0, string theGUID = null)
		{
			Satellite result;
			try
			{
				if (this.method_74(theGUID))
				{
					throw new Exception("Requested custom GUID is already in use in this scenario");
				}
				Scenario scenario = this;
				Satellite satellite = new Satellite(ref scenario, theGUID);
				scenario = this;
				DBFunctions.smethod_74(ref scenario, ref satellite, SatelliteDBID, OrbitIndex, true);
				this.UnitsAutoIncrement++;
				satellite.method_142().vmethod_46(1f, false, false, this.method_31());
				foreach (Side side_ in this.method_44())
				{
					satellite.method_93(side_, true);
				}
				if (!string.IsNullOrEmpty(theName))
				{
					satellite.Name = theName;
				}
				satellite.vmethod_8(false, theSide);
				ActiveUnit activeUnit = satellite;
				scenario = this;
				GameGeneral.smethod_22(ref activeUnit, ref scenario);
				satellite.method_142().method_16(true);
				result = satellite;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101035", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x001A927C File Offset: 0x001A747C
		public Ship method_73(Side theSide, int ShipDBID, string theName, double Longitude, double Latitude, bool IgnoreElevationCheck = false, Unit.Enum122 theRemoteSimEntityType = Unit.Enum122.const_0, string theGUID = null)
		{
			Ship result;
			try
			{
				if (this.method_74(theGUID))
				{
					throw new Exception("Requested custom GUID is already in use in this scenario");
				}
				double num = (double)Terrain.smethod_7(Latitude, Longitude, false);
				if (!IgnoreElevationCheck && num > 0.0)
				{
					throw new Exception("You cannot place a ship overland!");
				}
				Scenario scenario = this;
				Ship ship = new Ship(ref scenario, theGUID);
				scenario = this;
				DBFunctions.smethod_53(ref scenario, ref ship, ShipDBID, true);
				this.UnitsAutoIncrement++;
				ship.Name = theName;
				ship.vmethod_8(false, theSide);
				ship.vmethod_10(0f);
				ship.vmethod_41(0f);
				ship.vmethod_31(null, Latitude);
				ship.vmethod_29(null, Longitude);
				ship.vmethod_71(0f);
				ship.vmethod_69(ActiveUnit.Enum28.const_0, 0f);
				ActiveUnit activeUnit = ship;
				scenario = this;
				GameGeneral.smethod_22(ref activeUnit, ref scenario);
				ship.method_146().method_16(true);
				result = ship;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101036", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x001A93B0 File Offset: 0x001A75B0
		private bool method_74(string string_0)
		{
			bool result;
			if (string.IsNullOrEmpty(string_0))
			{
				result = false;
			}
			else
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.method_42())
					{
						if (!Information.IsNothing(activeUnit) && Operators.CompareString(activeUnit.string_0, string_0, false) == 0)
						{
							return true;
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x001A9428 File Offset: 0x001A7628
		public Submarine method_75(Side theSide, int SubDBID, string theName, double Longitude, double Latitude, bool IgnoreElevationCheck = false, Unit.Enum122 theRemoteSimEntityType = Unit.Enum122.const_0, string theGUID = null)
		{
			Submarine result;
			try
			{
				if (this.method_74(theGUID))
				{
					throw new Exception("Requested custom GUID is already in use in this scenario");
				}
				double num = (double)Terrain.smethod_7(Latitude, Longitude, false);
				if (!IgnoreElevationCheck && num > 0.0)
				{
					throw new Exception("You cannot place a submarine overland!");
				}
				Scenario scenario = this;
				Submarine submarine = new Submarine(ref scenario, theGUID);
				scenario = this;
				DBFunctions.smethod_55(ref scenario, ref submarine, SubDBID, true);
				this.UnitsAutoIncrement++;
				submarine.Name = theName;
				submarine.vmethod_8(false, theSide);
				submarine.vmethod_10(0f);
				submarine.vmethod_41(4f);
				submarine.vmethod_15(false, Math.Max(-40f, submarine.method_154().vmethod_31()));
				submarine.vmethod_31(null, Latitude);
				submarine.vmethod_29(null, Longitude);
				submarine.vmethod_71(0f);
				submarine.vmethod_69(ActiveUnit.Enum28.const_0, 0f);
				submarine.vmethod_73(-20f);
				ActiveUnit activeUnit = submarine;
				scenario = this;
				GameGeneral.smethod_22(ref activeUnit, ref scenario);
				submarine.method_154().method_16(true);
				result = submarine;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101037", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x001A9590 File Offset: 0x001A7790
		public Facility method_76(Side theSide, int FacilityDBID, string theName, double Longitude, double Latitude, bool IgnoreElevationCheck = false, Unit.Enum122 theRemoteSimEntityType = Unit.Enum122.const_0, string theGUID = null)
		{
			Facility result;
			try
			{
				if (this.method_74(theGUID))
				{
					throw new Exception("Requested custom GUID is already in use in this scenario");
				}
				Scenario scenario = this;
				Facility facility = new Facility(ref scenario, theGUID);
				int num = (int)Terrain.smethod_7(Latitude, Longitude, false);
				scenario = this;
				DBFunctions.smethod_57(ref scenario, ref facility, FacilityDBID, true);
				if (facility.method_5())
				{
					facility.method_93(null, true);
				}
				facility.Name = theName;
				if (!IgnoreElevationCheck && num < 0 && facility._FacilityCategory_0 != Facility._FacilityCategory.Underwater)
				{
					throw new Exception(string.Concat(new string[]
					{
						"Attempted to place facility: ",
						facility.Name,
						" (Class: ",
						facility.string_2,
						" - DBID: ",
						Conversions.ToString(facility.DBID),
						") at coordinates: Lat: ",
						Conversions.ToString(Latitude),
						" - Lon: ",
						Conversions.ToString(Longitude),
						" . This point appears to be underwater. Placement aborted!"
					}));
				}
				this.UnitsAutoIncrement++;
				facility.vmethod_8(false, theSide);
				facility.vmethod_10(0f);
				facility.vmethod_41(0f);
				facility.vmethod_31(null, Latitude);
				facility.vmethod_29(null, Longitude);
				facility.vmethod_15(false, (float)num);
				facility.vmethod_71(0f);
				facility.vmethod_69(ActiveUnit.Enum28.const_0, 0f);
				ActiveUnit activeUnit = facility;
				scenario = this;
				GameGeneral.smethod_22(ref activeUnit, ref scenario);
				facility.method_149().method_16(true);
				result = facility;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101286", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x001A9760 File Offset: 0x001A7960
		public UnguidedWeapon method_77(Side side_0, int int_0, List<ReferencePoint> list_0)
		{
			UnguidedWeapon result;
			try
			{
				Geopoint_Struct geopoint_Struct = Math2.smethod_23(list_0);
				if (!Information.IsNothing(geopoint_Struct) && !geopoint_Struct.method_0())
				{
					Weapon theReferenceWeapon = this.method_87(int_0);
					UnguidedWeapon unguidedWeapon = new UnguidedWeapon(theReferenceWeapon, null, null, 0.0, 0.0, 0L);
					unguidedWeapon.vmethod_8(false, side_0);
					if (string.CompareOrdinal(UnguidedWeapon.smethod_3(ref unguidedWeapon, geopoint_Struct.double_1, geopoint_Struct.double_0, (float)Terrain.smethod_7(geopoint_Struct.double_1, geopoint_Struct.double_0, false), this), "OK") == 0)
					{
						this.vmethod_20().Add(unguidedWeapon.string_0, unguidedWeapon);
						result = unguidedWeapon;
					}
					else
					{
						result = null;
					}
				}
				else
				{
					result = null;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101039", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x001A9860 File Offset: 0x001A7A60
		public bool method_78(string string_0, string string_1, string string_2, string string_3, Side side_0, Collection<ActiveUnit> collection_0)
		{
			ImportExportRecord importExportRecord = new ImportExportRecord();
			importExportRecord.Name = string_1;
			importExportRecord.Comments = string_2;
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.IndentChars = "    ";
			xmlWriterSettings.ConformanceLevel = ConformanceLevel.Auto;
			int num = 0;
			try
			{
				foreach (ActiveUnit activeUnit in Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(collection_0, (Scenario._Closure$__.$I342-0 == null) ? (Scenario._Closure$__.$I342-0 = new Func<ActiveUnit, bool>(Scenario._Closure$__.$I.method_0)) : Scenario._Closure$__.$I342-0)))
				{
					ImportExportRecord.MemberRecord memberRecord;
					StreamWriter streamWriter_;
					if (activeUnit.bool_1)
					{
						try
						{
							foreach (ActiveUnit activeUnit2 in ((Group)activeUnit).vmethod_141().Values)
							{
								memberRecord = new ImportExportRecord.MemberRecord();
								memberRecord.Member_DBID = activeUnit2.DBID;
								memberRecord.Member_GUID = activeUnit2.string_0;
								switch (activeUnit2.vmethod_56())
								{
								case GlobalVariables.ActiveUnitType.Aircraft:
									memberRecord.MemberType = "Aircraft";
									break;
								case GlobalVariables.ActiveUnitType.Ship:
									memberRecord.MemberType = "Ship";
									break;
								case GlobalVariables.ActiveUnitType.Submarine:
									memberRecord.MemberType = "Submarine";
									break;
								case GlobalVariables.ActiveUnitType.Facility:
									memberRecord.MemberType = "Facility";
									break;
								case GlobalVariables.ActiveUnitType.Weapon:
									memberRecord.MemberType = "Weapon";
									break;
								}
								memberRecord.Orientation = activeUnit2.vmethod_9();
								memberRecord.Latitude = activeUnit2.vmethod_30(null);
								memberRecord.Longitude = activeUnit2.vmethod_28(null);
								memberRecord.MemberName = activeUnit2.Name;
								memberRecord.ParentGroupName = activeUnit2.vmethod_65(false).Name;
								MemoryStream memoryStream = new MemoryStream();
								using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings))
								{
									xmlWriter.WriteStartElement("DeltaUnit");
									Class559.smethod_4(activeUnit2, activeUnit2.scenario_0, xmlWriter, streamWriter_, ref num);
									xmlWriter.WriteEndElement();
									xmlWriter.Flush();
								}
								if (Operators.CompareString(Misc.smethod_45(memoryStream), "<DeltaUnit />", false) != 0)
								{
									memberRecord.Member_SBR = Misc.smethod_45(memoryStream);
								}
								this.method_79(ref activeUnit2, ref memberRecord);
								this.method_80(ref activeUnit2, ref memberRecord);
								importExportRecord.MemberRecords.Add(memberRecord);
							}
							continue;
						}
						finally
						{
							IEnumerator<ActiveUnit> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
					memberRecord = new ImportExportRecord.MemberRecord();
					memberRecord.Member_DBID = activeUnit.DBID;
					memberRecord.Member_GUID = activeUnit.string_0;
					switch (activeUnit.vmethod_56())
					{
					case GlobalVariables.ActiveUnitType.Aircraft:
						memberRecord.MemberType = "Aircraft";
						break;
					case GlobalVariables.ActiveUnitType.Ship:
						memberRecord.MemberType = "Ship";
						break;
					case GlobalVariables.ActiveUnitType.Submarine:
						memberRecord.MemberType = "Submarine";
						break;
					case GlobalVariables.ActiveUnitType.Facility:
						memberRecord.MemberType = "Facility";
						break;
					case GlobalVariables.ActiveUnitType.Weapon:
						memberRecord.MemberType = "Weapon";
						break;
					}
					memberRecord.Orientation = activeUnit.vmethod_9();
					memberRecord.Latitude = activeUnit.vmethod_30(null);
					memberRecord.Longitude = activeUnit.vmethod_28(null);
					memberRecord.MemberName = activeUnit.Name;
					if (activeUnit.method_120())
					{
						memberRecord.ParentGroupName = activeUnit.vmethod_65(false).Name;
					}
					if (activeUnit.GetType() == typeof(Aircraft))
					{
						if (!Information.IsNothing(((Aircraft)activeUnit).method_167()))
						{
							memberRecord.LoadoutID = ((Aircraft)activeUnit).method_167().DBID;
						}
						else
						{
							memberRecord.LoadoutID = 0;
						}
					}
					MemoryStream memoryStream2 = new MemoryStream();
					using (XmlWriter xmlWriter2 = XmlWriter.Create(memoryStream2, xmlWriterSettings))
					{
						xmlWriter2.WriteStartElement("DeltaUnit");
						Class559.smethod_4(activeUnit, activeUnit.scenario_0, xmlWriter2, streamWriter_, ref num);
						xmlWriter2.WriteEndElement();
						xmlWriter2.Flush();
					}
					if (Operators.CompareString(Misc.smethod_45(memoryStream2), "<DeltaUnit />", false) != 0)
					{
						memberRecord.Member_SBR = Misc.smethod_45(memoryStream2);
					}
					this.method_79(ref activeUnit, ref memberRecord);
					this.method_80(ref activeUnit, ref memberRecord);
					importExportRecord.MemberRecords.Add(memberRecord);
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			StreamWriter streamWriter = new StreamWriter(string_0);
			Class2331 @class = new Class2331();
			using (streamWriter)
			{
				Class2275 class2 = new Class2275(streamWriter);
				class2.method_3(Enum196.const_1);
				using (class2)
				{
					@class.method_1(class2, importExportRecord);
				}
			}
			return true;
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x001A9D6C File Offset: 0x001A7F6C
		internal void method_79(ref ActiveUnit activeUnit_0, ref ImportExportRecord.MemberRecord memberRecord_0)
		{
			if (activeUnit_0.vmethod_92().vmethod_4().Count > 0)
			{
				try
				{
					foreach (Aircraft aircraft in activeUnit_0.vmethod_92().vmethod_4())
					{
						int int_;
						if (Information.IsNothing(aircraft.method_167()))
						{
							int_ = 0;
						}
						else
						{
							int_ = aircraft.method_167().DBID;
						}
						ImportExportRecord.HostedAircraftRecord item = new ImportExportRecord.HostedAircraftRecord(aircraft.Name, aircraft.DBID, int_, (int)Math.Round((double)(aircraft.method_164().method_38() / 60f)));
						memberRecord_0.HostedAircraftRecords.Add(item);
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x001A9E2C File Offset: 0x001A802C
		internal void method_80(ref ActiveUnit activeUnit_0, ref ImportExportRecord.MemberRecord memberRecord_0)
		{
			if (activeUnit_0.vmethod_93().method_14().Count > 0)
			{
				try
				{
					foreach (ActiveUnit activeUnit in activeUnit_0.vmethod_93().method_14())
					{
						ImportExportRecord.EmbarkedBoatRecord item = new ImportExportRecord.EmbarkedBoatRecord(activeUnit.Name, activeUnit.DBID, (int)Math.Round((double)(activeUnit.vmethod_93().method_0() / 60f)), activeUnit.method_63());
						memberRecord_0.EmbarkedBoatRecords.Add(item);
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x001A9ECC File Offset: 0x001A80CC
		public List<ActiveUnit> method_81(string string_0, Side side_0)
		{
			List<ActiveUnit> result;
			try
			{
				StreamReader streamReader = new StreamReader(string_0);
				List<ActiveUnit> list = new List<ActiveUnit>();
				new List<string>();
				ImportExportRecord importExportRecord;
				using (streamReader)
				{
					importExportRecord = (ImportExportRecord)Class2330.smethod_29(streamReader.ReadToEnd(), typeof(ImportExportRecord));
				}
				try
				{
					foreach (ImportExportRecord.MemberRecord memberRecord_ in importExportRecord.MemberRecords)
					{
						try
						{
							this.method_82(memberRecord_, ref list, ref side_0);
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200054", ex.Message);
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
					List<ImportExportRecord.MemberRecord>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				List<Group> list2 = new List<Group>();
				List<ActiveUnit> list3 = Enumerable.ToList<ActiveUnit>(side_0.activeUnit_0);
				try
				{
					foreach (ActiveUnit activeUnit in list3)
					{
						if (activeUnit.bool_1 && ((Group)activeUnit).vmethod_141().Count < 2)
						{
							list2.Add((Group)activeUnit);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				try
				{
					foreach (Group group in list2)
					{
						this.method_66(group.string_0, true);
					}
				}
				finally
				{
					List<Group>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				result = list;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 101040", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit>();
			}
			return result;
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x001AA114 File Offset: 0x001A8314
		private void method_82(ImportExportRecord.MemberRecord memberRecord_0, ref List<ActiveUnit> list_0, ref Side side_0)
		{
			XmlDocument xmlDocument = new XmlDocument();
			ActiveUnit activeUnit;
			if (Information.IsNothing(memberRecord_0.MemberType))
			{
				Facility facility = this.method_76(side_0, memberRecord_0.Member_DBID, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, false, Unit.Enum122.const_0, memberRecord_0.Member_GUID);
				facility.vmethod_10(memberRecord_0.Orientation);
				list_0.Add(facility);
				activeUnit = facility;
				this.method_85(ref memberRecord_0, ref side_0, ref activeUnit);
				return;
			}
			if (!Information.IsNothing(memberRecord_0.Member_SBR) && memberRecord_0.Member_SBR.Length > 0)
			{
				xmlDocument.LoadXml(memberRecord_0.Member_SBR);
			}
			string memberType = memberRecord_0.MemberType;
			uint num = Class582.smethod_0(memberType);
			if (num <= 2722002328U)
			{
				if (num <= 746798495U)
				{
					if (num != 200131980U)
					{
						if (num != 746798495U)
						{
							return;
						}
						if (Operators.CompareString(memberType, "Ship", false) != 0)
						{
							return;
						}
						goto IL_1C5;
					}
					else
					{
						if (Operators.CompareString(memberType, "Command_Core.Aircraft", false) != 0)
						{
							return;
						}
						goto IL_25E;
					}
				}
				else if (num != 1158526071U)
				{
					if (num != 2722002328U)
					{
						return;
					}
					if (Operators.CompareString(memberType, "Facility", false) != 0)
					{
						return;
					}
					goto IL_2DE;
				}
				else if (Operators.CompareString(memberType, "Submarine", false) != 0)
				{
					return;
				}
			}
			else if (num <= 3043739066U)
			{
				if (num != 3015506108U)
				{
					if (num != 3043739066U)
					{
						return;
					}
					if (Operators.CompareString(memberType, "Command_Core.Submarine", false) != 0)
					{
						return;
					}
				}
				else
				{
					if (Operators.CompareString(memberType, "Command_Core.Ship", false) != 0)
					{
						return;
					}
					goto IL_1C5;
				}
			}
			else if (num != 3409620667U)
			{
				if (num != 4032298643U)
				{
					return;
				}
				if (Operators.CompareString(memberType, "Aircraft", false) != 0)
				{
					return;
				}
				goto IL_25E;
			}
			else
			{
				if (Operators.CompareString(memberType, "Command_Core.Facility", false) != 0)
				{
					return;
				}
				goto IL_2DE;
			}
			Submarine submarine = this.method_75(side_0, memberRecord_0.Member_DBID, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, false, Unit.Enum122.const_0, memberRecord_0.Member_GUID);
			submarine.vmethod_10(memberRecord_0.Orientation);
			activeUnit = submarine;
			this.method_83(ref activeUnit, side_0, ref memberRecord_0);
			activeUnit = submarine;
			this.method_84(ref activeUnit, side_0, ref memberRecord_0);
			Class559.smethod_14(this, xmlDocument);
			list_0.Add(submarine);
			activeUnit = submarine;
			this.method_85(ref memberRecord_0, ref side_0, ref activeUnit);
			return;
			IL_1C5:
			Ship ship = this.method_73(side_0, memberRecord_0.Member_DBID, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, false, Unit.Enum122.const_0, memberRecord_0.Member_GUID);
			ship.vmethod_10(memberRecord_0.Orientation);
			activeUnit = ship;
			this.method_83(ref activeUnit, side_0, ref memberRecord_0);
			activeUnit = ship;
			this.method_84(ref activeUnit, side_0, ref memberRecord_0);
			Class559.smethod_14(this, xmlDocument);
			list_0.Add(ship);
			activeUnit = ship;
			this.method_85(ref memberRecord_0, ref side_0, ref activeUnit);
			return;
			IL_25E:
			Aircraft aircraft = this.method_71(side_0, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, memberRecord_0.Member_DBID, memberRecord_0.LoadoutID, (float)memberRecord_0.Altitude, Unit.Enum122.const_0, memberRecord_0.Member_GUID);
			aircraft.vmethod_10(memberRecord_0.Orientation);
			activeUnit = aircraft;
			this.method_83(ref activeUnit, side_0, ref memberRecord_0);
			Class559.smethod_14(this, xmlDocument);
			list_0.Add(aircraft);
			activeUnit = aircraft;
			this.method_85(ref memberRecord_0, ref side_0, ref activeUnit);
			return;
			IL_2DE:
			Facility facility2 = this.method_76(side_0, memberRecord_0.Member_DBID, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, false, Unit.Enum122.const_0, memberRecord_0.Member_GUID);
			facility2.vmethod_10(memberRecord_0.Orientation);
			activeUnit = facility2;
			this.method_83(ref activeUnit, side_0, ref memberRecord_0);
			activeUnit = facility2;
			this.method_84(ref activeUnit, side_0, ref memberRecord_0);
			Class559.smethod_14(this, xmlDocument);
			list_0.Add(facility2);
			activeUnit = facility2;
			this.method_85(ref memberRecord_0, ref side_0, ref activeUnit);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x001AA474 File Offset: 0x001A8674
		private void method_83(ref ActiveUnit activeUnit_0, Side side_0, ref ImportExportRecord.MemberRecord memberRecord_0)
		{
			if (!Information.IsNothing(memberRecord_0.HostedAircraftRecords) && memberRecord_0.HostedAircraftRecords.Count != 0)
			{
				try
				{
					try
					{
						foreach (ImportExportRecord.HostedAircraftRecord hostedAircraftRecord in memberRecord_0.HostedAircraftRecords)
						{
							Aircraft aircraft_ = this.method_71(side_0, hostedAircraftRecord.Name, 0.0, 0.0, hostedAircraftRecord.AC_DBID, hostedAircraftRecord.Loadout_ID, 0f, Unit.Enum122.const_0, null);
							activeUnit_0.vmethod_92().method_18(aircraft_, false);
						}
					}
					finally
					{
						List<ImportExportRecord.HostedAircraftRecord>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101041", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x001AA56C File Offset: 0x001A876C
		private void method_84(ref ActiveUnit activeUnit_0, Side side_0, ref ImportExportRecord.MemberRecord memberRecord_0)
		{
			if (!Information.IsNothing(memberRecord_0.EmbarkedBoatRecords) && memberRecord_0.EmbarkedBoatRecords.Count != 0)
			{
				try
				{
					try
					{
						foreach (ImportExportRecord.EmbarkedBoatRecord embarkedBoatRecord in memberRecord_0.EmbarkedBoatRecords)
						{
							ActiveUnit activeUnit = null;
							if (Operators.CompareString(embarkedBoatRecord.Type, "Ship", false) == 0)
							{
								activeUnit = this.method_73(side_0, embarkedBoatRecord.Boat_DBID, embarkedBoatRecord.Name, 0.0, 0.0, false, Unit.Enum122.const_0, null);
							}
							else if (Operators.CompareString(embarkedBoatRecord.Type, "Submarine", false) == 0)
							{
								activeUnit = this.method_75(side_0, embarkedBoatRecord.Boat_DBID, embarkedBoatRecord.Name, 0.0, 0.0, false, Unit.Enum122.const_0, null);
							}
							if (!Information.IsNothing(activeUnit))
							{
								activeUnit_0.vmethod_93().method_42(activeUnit);
							}
						}
					}
					finally
					{
						List<ImportExportRecord.EmbarkedBoatRecord>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101041", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x001AA6B8 File Offset: 0x001A88B8
		private void method_85(ref ImportExportRecord.MemberRecord memberRecord_0, ref Side side_0, ref ActiveUnit activeUnit_0)
		{
			try
			{
				if (!Information.IsNothing(memberRecord_0.ParentGroupName))
				{
					if (this.Groups.method_1(memberRecord_0.ParentGroupName))
					{
						activeUnit_0.vmethod_66(false, this.Groups.method_0(memberRecord_0.ParentGroupName));
					}
					else
					{
						List<ActiveUnit> list = new List<ActiveUnit>();
						list.Add(activeUnit_0);
						Scenario scenario = this;
						new Group(ref scenario, ref side_0, list, false, null, null).Name = memberRecord_0.ParentGroupName;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101042", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x001AA774 File Offset: 0x001A8974
		public void method_86(ActiveUnit activeUnit_0, float float_0)
		{
			try
			{
				if (!activeUnit_0.bool_1)
				{
					List<EventTrigger> list = new List<EventTrigger>();
					try
					{
						foreach (EventTrigger eventTrigger in this.vmethod_4().Values)
						{
							if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitDestroyed && ((Class337)eventTrigger).method_8(activeUnit_0, null))
							{
								list.Add(eventTrigger);
							}
						}
					}
					finally
					{
						IEnumerator<EventTrigger> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					try
					{
						foreach (EventTrigger eventTrigger2 in this.vmethod_4().Values)
						{
							if (eventTrigger2.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitDamaged && ((Class336)eventTrigger2).method_8(activeUnit_0, float_0, 101f, null))
							{
								list.Add(eventTrigger2);
							}
						}
					}
					finally
					{
						IEnumerator<EventTrigger> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					this.method_24(list);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101043", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x001AA8A4 File Offset: 0x001A8AA4
		public Weapon method_87(int int_0)
		{
			Weapon weapon = null;
			if (!this.Cache_Weapons.TryGetValue(int_0, ref weapon))
			{
				Scenario scenario = this;
				weapon = Weapon.smethod_16(ref scenario, int_0, null);
				this.Cache_Weapons.TryAdd(int_0, weapon);
			}
			return weapon;
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x001AA8E0 File Offset: 0x001A8AE0
		private void method_88(object sender, NotifyDictionaryChangedEventArgs<string, ActiveUnit> e)
		{
			checked
			{
				try
				{
					this._ActiveUnits_List = null;
					Side[] array = this.method_44();
					for (int i = 0; i < array.Length; i++)
					{
						array[i].method_50(this, null);
					}
					NotifyCollectionChangedAction action = e.Action;
					if (action != null)
					{
						if (action == 1)
						{
							Scenario.UnitRemovedEventHandler unitRemovedEvent = Scenario.UnitRemovedEvent;
							if (unitRemovedEvent != null)
							{
								unitRemovedEvent(this, e.OldItem.Value);
							}
							if (e.OldItem.Value.vmethod_7(false) != null)
							{
								Class429.smethod_1(ref e.OldItem.Value.vmethod_7(false).activeUnit_0, e.OldItem.Value);
							}
						}
					}
					else
					{
						if (!Information.IsNothing(e.NewItem.Value.vmethod_7(false)) && !Enumerable.Contains<ActiveUnit>(e.NewItem.Value.vmethod_7(false).activeUnit_0, e.NewItem.Value))
						{
							Class429.smethod_0(ref e.NewItem.Value.vmethod_7(false).activeUnit_0, e.NewItem.Value);
							Scenario.UnitAddedEventHandler unitAddedEvent = Scenario.UnitAddedEvent;
							if (unitAddedEvent != null)
							{
								unitAddedEvent(this, e.NewItem.Value.string_0);
							}
						}
						if (e.NewItem.Value.method_5())
						{
							e.NewItem.Value.vmethod_87().method_16(true);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200568", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x001AAABC File Offset: 0x001A8CBC
		private void method_89(object sender, NotifyDictionaryChangedEventArgs<string, UnguidedWeapon> e)
		{
			checked
			{
				try
				{
					NotifyCollectionChangedAction action = e.Action;
					if (action == 1)
					{
						Side[] array = this.method_44();
						for (int i = 0; i < array.Length; i++)
						{
							array[i].hashSet_0.Remove(e.OldItem.Key);
						}
					}
					this.Mines = Enumerable.ToList<UnguidedWeapon>(Enumerable.Where<UnguidedWeapon>(this.vmethod_20().Values, (Scenario._Closure$__.$I356-0 == null) ? (Scenario._Closure$__.$I356-0 = new Func<UnguidedWeapon, bool>(Scenario._Closure$__.$I.method_1)) : Scenario._Closure$__.$I356-0));
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101045", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x001AAB90 File Offset: 0x001A8D90
		private void method_90(object sender, NotifyDictionaryChangedEventArgs<string, EventTrigger> e)
		{
			Scenario.EventTriggersChangedEventHandler eventTriggersChangedEvent = Scenario.EventTriggersChangedEvent;
			if (eventTriggersChangedEvent != null)
			{
				eventTriggersChangedEvent(this);
			}
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x001AABB0 File Offset: 0x001A8DB0
		private void method_91(object sender, NotifyDictionaryChangedEventArgs<string, EventCondition> e)
		{
			Scenario.EventConditionsChangedEventHandler eventConditionsChangedEvent = Scenario.EventConditionsChangedEvent;
			if (eventConditionsChangedEvent != null)
			{
				eventConditionsChangedEvent(this);
			}
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x001AABD0 File Offset: 0x001A8DD0
		private void method_92(object sender, NotifyDictionaryChangedEventArgs<string, EventAction> e)
		{
			Scenario.EventActionsChangedEventHandler eventActionsChangedEvent = Scenario.EventActionsChangedEvent;
			if (eventActionsChangedEvent != null)
			{
				eventActionsChangedEvent(this);
			}
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x001AABF0 File Offset: 0x001A8DF0
		private void method_93(XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("MessageLog");
				List<LoggedMessage> list = Enumerable.ToList<LoggedMessage>(this.MessageLog);
				try
				{
					foreach (LoggedMessage loggedMessage in list)
					{
						if (loggedMessage != null && Enumerable.Contains<Side>(this.method_44(), loggedMessage.side_0))
						{
							xmlWriter_0.WriteRaw(loggedMessage.method_10());
						}
					}
				}
				finally
				{
					List<LoggedMessage>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101046", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x001AACBC File Offset: 0x001A8EBC
		private void method_94(object sender, NotifyDictionaryChangedEventArgs<string, ScenAttachmentObject> e)
		{
			Scenario.ScenAttachmentsChangedEventHandler scenAttachmentsChangedEvent = Scenario.ScenAttachmentsChangedEvent;
			if (scenAttachmentsChangedEvent != null)
			{
				scenAttachmentsChangedEvent();
			}
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x001AACD8 File Offset: 0x001A8ED8
		private void method_95()
		{
			foreach (Side side in this.method_44())
			{
				if (!Information.IsNothing(side.method_35()))
				{
					try
					{
						foreach (Mission mission in side.method_36(this))
						{
							if (!Information.IsNothing(mission))
							{
								int num = 99;
								Mission._FlightSize flightSize_;
								switch (mission._MissionClass_0)
								{
								case Mission._MissionClass.Strike:
									flightSize_ = ((Strike)mission)._FlightSize_0;
									break;
								case Mission._MissionClass.Patrol:
									flightSize_ = ((Class343)mission)._FlightSize_0;
									break;
								case Mission._MissionClass.Support:
									flightSize_ = ((Class344)mission)._FlightSize_0;
									break;
								case Mission._MissionClass.Ferry:
									flightSize_ = ((FerryMission)mission)._FlightSize_0;
									break;
								case Mission._MissionClass.Mining:
									flightSize_ = ((Class340)mission)._FlightSize_0;
									break;
								case Mission._MissionClass.MineClearing:
									flightSize_ = ((Class341)mission)._FlightSize_0;
									break;
								case Mission._MissionClass.Escort:
									flightSize_ = ((Class339)mission)._FlightSize_0;
									break;
								}
								if (flightSize_ == Mission._FlightSize.None)
								{
									Mission mission2 = mission;
									Scenario scenario = this;
									Dictionary<string, Dictionary<string, Dictionary<string, int>>> dictionary = mission2.method_23(ref scenario, false, false);
									try
									{
										foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, int>>> keyValuePair in dictionary)
										{
											Dictionary<string, Dictionary<string, int>> value = keyValuePair.Value;
											try
											{
												foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair2 in value)
												{
													Dictionary<string, int> value2 = keyValuePair2.Value;
													try
													{
														foreach (KeyValuePair<string, int> keyValuePair3 in value2)
														{
															if (keyValuePair3.Value < num)
															{
																num = keyValuePair3.Value;
															}
														}
													}
													finally
													{
														Dictionary<string, int>.Enumerator enumerator4;
														((IDisposable)enumerator4).Dispose();
													}
												}
											}
											finally
											{
												Dictionary<string, Dictionary<string, int>>.Enumerator enumerator3;
												((IDisposable)enumerator3).Dispose();
											}
										}
									}
									finally
									{
										Dictionary<string, Dictionary<string, Dictionary<string, int>>>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
									switch (mission._MissionClass_0)
									{
									case Mission._MissionClass.Strike:
									{
										Strike strike = (Strike)mission;
										Strike.StrikeType strikeType_ = strike.strikeType_0;
										if (strikeType_ != Strike.StrikeType.Air_Intercept)
										{
											if (strikeType_ != Strike.StrikeType.Sub_Strike)
											{
												if (num == 1)
												{
													strike._FlightSize_0 = Mission._FlightSize.SingleAircraft;
												}
												else if (num == 2)
												{
													strike._FlightSize_0 = Mission._FlightSize.TwoAircraft;
												}
												else if (num == 3)
												{
													strike._FlightSize_0 = Mission._FlightSize.ThreeAircraft;
												}
												else if (num <= 5)
												{
													strike._FlightSize_0 = Mission._FlightSize.FourAircraft;
												}
												else if (num <= 7)
												{
													strike._FlightSize_0 = Mission._FlightSize.SixAircraft;
												}
												else
												{
													strike._FlightSize_0 = Mission._FlightSize.FourAircraft;
												}
											}
											else
											{
												strike._FlightSize_0 = Mission._FlightSize.SingleAircraft;
											}
										}
										else if (num == 1)
										{
											strike._FlightSize_0 = Mission._FlightSize.SingleAircraft;
										}
										else
										{
											strike._FlightSize_0 = Mission._FlightSize.TwoAircraft;
										}
										break;
									}
									case Mission._MissionClass.Patrol:
									{
										Class343 @class = (Class343)mission;
										switch (@class.patrolType_0)
										{
										case GlobalVariables.PatrolType.ASW:
											@class._FlightSize_0 = Mission._FlightSize.SingleAircraft;
											continue;
										case GlobalVariables.PatrolType.AAW:
											if (num == 1)
											{
												@class._FlightSize_0 = Mission._FlightSize.SingleAircraft;
												continue;
											}
											@class._FlightSize_0 = Mission._FlightSize.TwoAircraft;
											continue;
										case GlobalVariables.PatrolType.ASuW_Land:
											if (num == 1)
											{
												@class._FlightSize_0 = Mission._FlightSize.SingleAircraft;
												continue;
											}
											@class._FlightSize_0 = Mission._FlightSize.TwoAircraft;
											continue;
										case GlobalVariables.PatrolType.ASuW_Mixed:
											if (num == 1)
											{
												@class._FlightSize_0 = Mission._FlightSize.SingleAircraft;
												continue;
											}
											@class._FlightSize_0 = Mission._FlightSize.TwoAircraft;
											continue;
										case GlobalVariables.PatrolType.SEAD:
											if (num == 1)
											{
												@class._FlightSize_0 = Mission._FlightSize.SingleAircraft;
												continue;
											}
											@class._FlightSize_0 = Mission._FlightSize.TwoAircraft;
											continue;
										}
										@class._FlightSize_0 = Mission._FlightSize.SingleAircraft;
										break;
									}
									case Mission._MissionClass.Support:
										((Class344)mission)._FlightSize_0 = Mission._FlightSize.SingleAircraft;
										break;
									case Mission._MissionClass.Ferry:
									{
										FerryMission ferryMission = (FerryMission)mission;
										if (num == 1)
										{
											ferryMission._FlightSize_0 = Mission._FlightSize.SingleAircraft;
										}
										else if (num == 2)
										{
											ferryMission._FlightSize_0 = Mission._FlightSize.TwoAircraft;
										}
										else if (num == 3)
										{
											ferryMission._FlightSize_0 = Mission._FlightSize.ThreeAircraft;
										}
										else if (num <= 5)
										{
											ferryMission._FlightSize_0 = Mission._FlightSize.FourAircraft;
										}
										else if (num <= 7)
										{
											ferryMission._FlightSize_0 = Mission._FlightSize.SixAircraft;
										}
										else
										{
											ferryMission._FlightSize_0 = Mission._FlightSize.FourAircraft;
										}
										break;
									}
									case Mission._MissionClass.Mining:
									{
										Class340 class2 = (Class340)mission;
										if (num == 1)
										{
											class2._FlightSize_0 = Mission._FlightSize.SingleAircraft;
										}
										else if (num == 2)
										{
											class2._FlightSize_0 = Mission._FlightSize.TwoAircraft;
										}
										else if (num == 3)
										{
											class2._FlightSize_0 = Mission._FlightSize.ThreeAircraft;
										}
										else if (num <= 5)
										{
											class2._FlightSize_0 = Mission._FlightSize.FourAircraft;
										}
										else if (num <= 7)
										{
											class2._FlightSize_0 = Mission._FlightSize.SixAircraft;
										}
										else
										{
											class2._FlightSize_0 = Mission._FlightSize.FourAircraft;
										}
										break;
									}
									case Mission._MissionClass.MineClearing:
										((Class341)mission)._FlightSize_0 = Mission._FlightSize.SingleAircraft;
										break;
									case Mission._MissionClass.Escort:
										flightSize_ = ((Class339)mission)._FlightSize_0;
										break;
									}
								}
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
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x001AB1C8 File Offset: 0x001A93C8
		public List<string> method_96(ref Side side_0, ref Mission mission_0)
		{
			List<string> list = new List<string>();
			if (!Information.IsNothing(this) && !Information.IsNothing(mission_0))
			{
				bool flag = false;
				bool flag2 = false;
				try
				{
					Mission mission = mission_0;
					Scenario scenario = this;
					Dictionary<string, Dictionary<string, Dictionary<string, int>>> dictionary = mission.method_23(ref scenario, false, false);
					Dictionary<string, Dictionary<string, Dictionary<string, int>>> dictionary2;
					Dictionary<string, Dictionary<string, Dictionary<string, int>>> dictionary3;
					if (mission_0._MissionClass_0 == Mission._MissionClass.Strike && ((Strike)mission_0)._FlightSize_2 == Mission._FlightSize.None)
					{
						Mission mission2 = mission_0;
						scenario = this;
						dictionary2 = mission2.method_23(ref scenario, true, true);
						dictionary3 = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
					}
					else
					{
						Mission mission3 = mission_0;
						scenario = this;
						dictionary2 = mission3.method_23(ref scenario, true, false);
						Mission mission4 = mission_0;
						scenario = this;
						dictionary3 = mission4.method_23(ref scenario, false, true);
					}
					if (dictionary.Count > 0 || dictionary2.Count > 0 || dictionary3.Count > 0)
					{
						Mission._FlightSize flightSize_;
						Mission._FlightSize flightSize_2;
						Mission._FlightSize flightSize_3;
						switch (mission_0._MissionClass_0)
						{
						case Mission._MissionClass.Strike:
						{
							Strike strike = (Strike)mission_0;
							flightSize_ = strike._FlightSize_0;
							flightSize_2 = strike._FlightSize_1;
							flightSize_3 = strike._FlightSize_2;
							new int?(strike.method_34(ref flightSize_, ref strike._FlightQty_0));
							new int?(strike.method_34(ref flightSize_2, ref strike._FlightQty_1));
							new int?(strike.method_34(ref flightSize_3, ref strike._FlightQty_2));
							flag = strike.bool_12;
							flag2 = strike.bool_28;
							break;
						}
						case Mission._MissionClass.Patrol:
						{
							Class343 @class = (Class343)mission_0;
							flightSize_ = @class._FlightSize_0;
							new int?(@class.method_34(ref flightSize_, ref @class._FlightQty_0));
							flag = @class.bool_12;
							break;
						}
						case Mission._MissionClass.Support:
						{
							Class344 class2 = (Class344)mission_0;
							flightSize_ = class2._FlightSize_0;
							new int?(class2.method_34(ref flightSize_, ref class2._FlightQty_0));
							flag = class2.bool_12;
							break;
						}
						case Mission._MissionClass.Ferry:
						{
							FerryMission ferryMission = (FerryMission)mission_0;
							flightSize_ = ferryMission._FlightSize_0;
							flag = ferryMission.bool_12;
							break;
						}
						case Mission._MissionClass.Mining:
						{
							Class340 class3 = (Class340)mission_0;
							flightSize_ = class3._FlightSize_0;
							new int?(class3.method_34(ref flightSize_, ref class3._FlightQty_0));
							flag = class3.bool_12;
							break;
						}
						case Mission._MissionClass.MineClearing:
						{
							Class341 class4 = (Class341)mission_0;
							flightSize_ = class4._FlightSize_0;
							new int?(class4.method_34(ref flightSize_, ref class4._FlightQty_0));
							flag = class4.bool_12;
							break;
						}
						case Mission._MissionClass.Escort:
						{
							Class339 class5 = (Class339)mission_0;
							flightSize_ = class5._FlightSize_0;
							flag2 = class5.bool_12;
							break;
						}
						}
						if (flag)
						{
							try
							{
								foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, int>>> keyValuePair in dictionary)
								{
									Dictionary<string, Dictionary<string, int>> value = keyValuePair.Value;
									string key = keyValuePair.Key;
									try
									{
										foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair2 in value)
										{
											Dictionary<string, int> value2 = keyValuePair2.Value;
											string key2 = keyValuePair2.Key;
											try
											{
												foreach (KeyValuePair<string, int> keyValuePair3 in value2)
												{
													string key3 = keyValuePair3.Key;
													int value3 = keyValuePair3.Value;
													if (value3 < (int)flightSize_)
													{
														string item;
														if (Information.IsNothing(side_0))
														{
															item = string.Concat(new string[]
															{
																"Mission: ",
																mission_0.Name,
																", aircraft ",
																key2,
																", loadout ",
																key3,
																" on ship/base ",
																key,
																": Number of aircraft (",
																Conversions.ToString(value3),
																") is lower than minimum flight size (",
																Conversions.ToString((int)flightSize_),
																")"
															});
														}
														else
														{
															item = string.Concat(new string[]
															{
																"Side: ",
																side_0.method_51(),
																", mission: ",
																mission_0.Name,
																", aircraft ",
																key2,
																", loadout ",
																key3,
																" on ship/base ",
																key,
																": Number of aircraft (",
																Conversions.ToString(value3),
																") is lower than minimum flight size (",
																Conversions.ToString((int)flightSize_),
																")"
															});
														}
														list.Add(item);
													}
												}
											}
											finally
											{
												Dictionary<string, int>.Enumerator enumerator3;
												((IDisposable)enumerator3).Dispose();
											}
										}
									}
									finally
									{
										Dictionary<string, Dictionary<string, int>>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
							finally
							{
								Dictionary<string, Dictionary<string, Dictionary<string, int>>>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						if (flag2)
						{
							try
							{
								foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, int>>> keyValuePair4 in dictionary2)
								{
									Dictionary<string, Dictionary<string, int>> value4 = keyValuePair4.Value;
									string key4 = keyValuePair4.Key;
									try
									{
										foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair5 in value4)
										{
											Dictionary<string, int> value5 = keyValuePair5.Value;
											string key5 = keyValuePair5.Key;
											try
											{
												foreach (KeyValuePair<string, int> keyValuePair6 in value5)
												{
													string key6 = keyValuePair6.Key;
													int value6 = keyValuePair6.Value;
													if (value6 < (int)flightSize_2)
													{
														string item2;
														if (Information.IsNothing(side_0))
														{
															item2 = string.Concat(new string[]
															{
																"Fighter/SEAD escort on mission: ",
																mission_0.Name,
																", aircraft ",
																key5,
																", loadout ",
																key6,
																" on ship/base ",
																key4,
																": Number of aircraft (",
																Conversions.ToString(value6),
																") is lower than minimum flight size (",
																Conversions.ToString((int)flightSize_2),
																")"
															});
														}
														else
														{
															item2 = string.Concat(new string[]
															{
																"Side: ",
																side_0.method_51(),
																", fighter/SEAD escort on mission: ",
																mission_0.Name,
																", aircraft ",
																key5,
																", loadout ",
																key6,
																" on ship/base ",
																key4,
																": Number of aircraft (",
																Conversions.ToString(value6),
																") is lower than minimum flight size (",
																Conversions.ToString((int)flightSize_2),
																")"
															});
														}
														list.Add(item2);
													}
												}
											}
											finally
											{
												Dictionary<string, int>.Enumerator enumerator6;
												((IDisposable)enumerator6).Dispose();
											}
										}
									}
									finally
									{
										Dictionary<string, Dictionary<string, int>>.Enumerator enumerator5;
										((IDisposable)enumerator5).Dispose();
									}
								}
							}
							finally
							{
								Dictionary<string, Dictionary<string, Dictionary<string, int>>>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
							if (!Information.IsNothing(flightSize_3))
							{
								try
								{
									foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, int>>> keyValuePair7 in dictionary3)
									{
										Dictionary<string, Dictionary<string, int>> value7 = keyValuePair7.Value;
										string key7 = keyValuePair7.Key;
										try
										{
											foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair8 in value7)
											{
												Dictionary<string, int> value8 = keyValuePair8.Value;
												string key8 = keyValuePair8.Key;
												try
												{
													foreach (KeyValuePair<string, int> keyValuePair9 in value8)
													{
														string key9 = keyValuePair9.Key;
														int value9 = keyValuePair9.Value;
														if (value9 < (int)flightSize_3)
														{
															string item3;
															if (Information.IsNothing(side_0))
															{
																item3 = string.Concat(new string[]
																{
																	"Support escort on mission: ",
																	mission_0.Name,
																	", aircraft ",
																	key8,
																	", loadout ",
																	key9,
																	" on ship/base ",
																	key7,
																	": Number of aircraft (",
																	Conversions.ToString(value9),
																	") is lower than minimum flight size (",
																	Conversions.ToString((int)flightSize_3),
																	")"
																});
															}
															else
															{
																item3 = string.Concat(new string[]
																{
																	"Side: ",
																	side_0.method_51(),
																	", support escort on mission: ",
																	mission_0.Name,
																	", aircraft ",
																	key8,
																	", loadout ",
																	key9,
																	" on ship/base ",
																	key7,
																	": Number of aircraft (",
																	Conversions.ToString(value9),
																	") is lower than minimum flight size (",
																	Conversions.ToString((int)flightSize_3),
																	")"
																});
															}
															list.Add(item3);
														}
													}
												}
												finally
												{
													Dictionary<string, int>.Enumerator enumerator9;
													((IDisposable)enumerator9).Dispose();
												}
											}
										}
										finally
										{
											Dictionary<string, Dictionary<string, int>>.Enumerator enumerator8;
											((IDisposable)enumerator8).Dispose();
										}
									}
								}
								finally
								{
									Dictionary<string, Dictionary<string, Dictionary<string, int>>>.Enumerator enumerator7;
									((IDisposable)enumerator7).Dispose();
								}
							}
						}
					}
					return list;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101252", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					return new List<string>();
				}
			}
			return list;
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x001ABB44 File Offset: 0x001A9D44
		private void method_97(object sender, EventArgs5<WeaponImpact> e)
		{
			try
			{
				foreach (WeaponImpact weaponImpact_ in e.method_0())
				{
					WeaponImpact.smethod_1(weaponImpact_, this);
				}
			}
			finally
			{
				IEnumerator<WeaponImpact> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x001ABB90 File Offset: 0x001A9D90
		private void method_98(object sender, EventArgs5<Explosion> e)
		{
			try
			{
				foreach (Explosion explosion_ in e.method_0())
				{
					Explosion.smethod_3(explosion_, this);
				}
			}
			finally
			{
				IEnumerator<Explosion> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x001ABBDC File Offset: 0x001A9DDC
		public static bool smethod_25(string string_0, string string_1, string string_2, DBOps.Enum134 enum134_0, bool bool_0, ref string string_3)
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool result;
			try
			{
				if (string.IsNullOrEmpty(string_0))
				{
					stringBuilder.Append("No filename selected for scenario #1!");
					string_3 = stringBuilder.ToString();
					result = false;
				}
				else if (!File.Exists(string_0))
				{
					stringBuilder.Append("Filename set for scenario #1 is not valid!");
					string_3 = stringBuilder.ToString();
					result = false;
				}
				else if (string.IsNullOrEmpty(string_1))
				{
					stringBuilder.Append("No filename selected for scenario #2!");
					string_3 = stringBuilder.ToString();
					result = false;
				}
				else if (!File.Exists(string_1))
				{
					stringBuilder.Append("Filename set for scenario #2 is not valid!");
					string_3 = stringBuilder.ToString();
					result = false;
				}
				else if (string.IsNullOrEmpty(string_2))
				{
					stringBuilder.Append("No filename selected for the merge result!");
					string_3 = stringBuilder.ToString();
					result = false;
				}
				else if (!Directory.Exists(Path.GetDirectoryName(string_2)))
				{
					stringBuilder.Append("The directory set for the merge result file does not exist!");
					string_3 = stringBuilder.ToString();
					result = false;
				}
				else
				{
					Scenario scenario;
					try
					{
						stringBuilder.Append("Loading scenario #1...");
						string_3 = stringBuilder.ToString();
						ScenContainer scenContainer = ScenContainer.smethod_2(string_0);
						string text = null;
						double num = 0.0;
						scenario = scenContainer.method_8(ref text, ref num, false);
						stringBuilder.Append(" Done.");
						string_3 = stringBuilder.ToString();
					}
					catch (Exception ex)
					{
						stringBuilder.Append(" Error: " + ex.Message).Append("\r\n").Append("\r\n").Append("Merge aborted, please correct error and try again.");
						string_3 = stringBuilder.ToString();
						return false;
					}
					stringBuilder.Append("\r\n").Append("\r\n");
					string_3 = stringBuilder.ToString();
					Scenario scenario2;
					try
					{
						stringBuilder.Append("Loading scenario #2...");
						string_3 = stringBuilder.ToString();
						ScenContainer scenContainer2 = ScenContainer.smethod_2(string_1);
						string text = null;
						double num = 0.0;
						scenario2 = scenContainer2.method_8(ref text, ref num, false);
						stringBuilder.Append(" Done.");
						string_3 = stringBuilder.ToString();
					}
					catch (Exception ex2)
					{
						stringBuilder.Append(" Error: " + ex2.Message).Append("\r\n").Append("\r\n").Append("Merge aborted, please correct error and try again.");
						string_3 = stringBuilder.ToString();
						return false;
					}
					DBOps.Enum134 @enum = DBOps.smethod_3(scenario.method_7(), scenario2.method_7());
					if (enum134_0 != DBOps.Enum134.const_1)
					{
						if (enum134_0 == DBOps.Enum134.const_2)
						{
							if (@enum != DBOps.Enum134.const_1 && @enum != DBOps.Enum134.const_2)
							{
								stringBuilder.Append("'Same family' DB match level specified, but the two scenarios do not use the same general database. Merge aborted.");
								string_3 = stringBuilder.ToString();
								return false;
							}
						}
					}
					else if (@enum != DBOps.Enum134.const_1)
					{
						stringBuilder.Append("'Exact version' DB match level specified, but the two scenarios do not reference the exact same database. Merge aborted.");
						string_3 = stringBuilder.ToString();
						return false;
					}
					checked
					{
						if (scenario2._Sides.Length > 0)
						{
							stringBuilder.Append("\r\n").Append("\r\n").Append("Merging sides (and their missions, contacts and ref. points) from scenario #2 into scenario #1...");
							string_3 = stringBuilder.ToString();
							Side[] sides = scenario2._Sides;
							for (int i = 0; i < sides.Length; i++)
							{
								Scenario.Class300 @class = new Scenario.Class300(@class);
								@class.side_0 = sides[i];
								stringBuilder.Append("\r\n").Append(@class.side_0.method_51()).Append(": ");
								string_3 = stringBuilder.ToString();
								bool flag;
								if ((flag = (Enumerable.Count<Side>(Enumerable.Where<Side>(scenario.method_44(), new Func<Side, bool>(@class.method_0))) > 0)) && !bool_0)
								{
									stringBuilder.Append("A side with the same unique ID already exists on scenario #1 - skipping.");
									string_3 = stringBuilder.ToString();
								}
								else if (flag && bool_0)
								{
									stringBuilder.Append("\r\n").Append("\r\n").Append("A side with the same unique ID already exists on scenario #1, and merging side clones is allowed. Proceeding... ");
									string_3 = stringBuilder.ToString();
									Side side_ = @class.side_0;
									Side side = Enumerable.ElementAtOrDefault<Side>(Enumerable.Where<Side>(scenario.method_44(), new Func<Side, bool>(@class.method_1)), 0);
									stringBuilder.Append("\r\n").Append("\r\n").Append("Merging postures of side: " + side_.method_51() + " (base version wins on conflicts)...");
									string_3 = stringBuilder.ToString();
									ReadOnlyCollection<KeyValuePair<Side, Misc.PostureStance>> readOnlyCollection = side_.method_9();
									if (readOnlyCollection.Count > 0)
									{
										ReadOnlyCollection<KeyValuePair<Side, Misc.PostureStance>> readOnlyCollection2 = side.method_9();
										try
										{
											IEnumerator<KeyValuePair<Side, Misc.PostureStance>> enumerator = readOnlyCollection.GetEnumerator();
											while (enumerator.MoveNext())
											{
												Scenario.Class301 class2 = new Scenario.Class301(class2);
												class2.keyValuePair_0 = enumerator.Current;
												if (Enumerable.Count<KeyValuePair<Side, Misc.PostureStance>>(Enumerable.Where<KeyValuePair<Side, Misc.PostureStance>>(readOnlyCollection2, new Func<KeyValuePair<Side, Misc.PostureStance>, bool>(class2.method_0))) == 0)
												{
													side.method_69(class2.keyValuePair_0.Key, class2.keyValuePair_0.Value);
												}
											}
										}
										finally
										{
											IEnumerator<KeyValuePair<Side, Misc.PostureStance>> enumerator;
											if (enumerator != null)
											{
												enumerator.Dispose();
											}
										}
									}
									stringBuilder.Append("\r\n").Append("\r\n").Append("Merging reference points of side: " + side_.method_51() + " (base version wins on conflicts)...");
									string_3 = stringBuilder.ToString();
									List<ReferencePoint> list = Enumerable.ToList<ReferencePoint>(side_.vmethod_12());
									if (list.Count > 0)
									{
										try
										{
											List<ReferencePoint>.Enumerator enumerator2 = list.GetEnumerator();
											while (enumerator2.MoveNext())
											{
												Scenario.Class302 class3 = new Scenario.Class302(class3);
												class3.referencePoint_0 = enumerator2.Current;
												if (Enumerable.Count<ReferencePoint>(Enumerable.Where<ReferencePoint>(side.vmethod_12(), new Func<ReferencePoint, bool>(class3.method_0))) <= 0)
												{
													side.vmethod_12().method_4(class3.referencePoint_0);
												}
											}
										}
										finally
										{
											List<ReferencePoint>.Enumerator enumerator2;
											((IDisposable)enumerator2).Dispose();
										}
									}
									stringBuilder.Append("\r\n").Append("\r\n").Append("Merging exclusion zones of side: " + side_.method_51() + " (base version wins on conflicts)...");
									string_3 = stringBuilder.ToString();
									List<ExclusionZone> list_ = side_.list_6;
									if (list_.Count > 0)
									{
										try
										{
											List<ExclusionZone>.Enumerator enumerator3 = list_.GetEnumerator();
											while (enumerator3.MoveNext())
											{
												Scenario.Class303 class4 = new Scenario.Class303(class4);
												class4.exclusionZone_0 = enumerator3.Current;
												if (Enumerable.Count<ExclusionZone>(Enumerable.Where<ExclusionZone>(side.list_6, new Func<ExclusionZone, bool>(class4.method_0))) <= 0)
												{
													side.list_6.Add(class4.exclusionZone_0);
												}
											}
										}
										finally
										{
											List<ExclusionZone>.Enumerator enumerator3;
											((IDisposable)enumerator3).Dispose();
										}
									}
									stringBuilder.Append("\r\n").Append("\r\n").Append("Merging no-nav zones of side: " + side_.method_51() + " (base version wins on conflicts)...");
									string_3 = stringBuilder.ToString();
									List<NoNavZone> list_2 = side_.list_7;
									if (list_2.Count > 0)
									{
										try
										{
											List<NoNavZone>.Enumerator enumerator4 = list_2.GetEnumerator();
											while (enumerator4.MoveNext())
											{
												Scenario.Class304 class5 = new Scenario.Class304(class5);
												class5.noNavZone_0 = enumerator4.Current;
												if (Enumerable.Count<NoNavZone>(Enumerable.Where<NoNavZone>(side.list_7, new Func<NoNavZone, bool>(class5.method_0))) <= 0)
												{
													side.list_7.Add(class5.noNavZone_0);
												}
											}
										}
										finally
										{
											List<NoNavZone>.Enumerator enumerator4;
											((IDisposable)enumerator4).Dispose();
										}
									}
									stringBuilder.Append("\r\n").Append("\r\n").Append("Merging quick-jump slots of side: " + side_.method_51() + " (base version wins on conflicts)...");
									string_3 = stringBuilder.ToString();
									Dictionary<byte, QuickJumpSlot> dictionary_ = side_.dictionary_3;
									if (dictionary_.Count > 0)
									{
										try
										{
											foreach (KeyValuePair<byte, QuickJumpSlot> keyValuePair in dictionary_)
											{
												if (!side.dictionary_3.ContainsKey(keyValuePair.Key))
												{
													side.dictionary_3.Add(keyValuePair.Key, keyValuePair.Value);
												}
											}
										}
										finally
										{
											Dictionary<byte, QuickJumpSlot>.Enumerator enumerator5;
											((IDisposable)enumerator5).Dispose();
										}
									}
									stringBuilder.Append("\r\n").Append("\r\n").Append("Merging contacts zones of side: " + side_.method_51() + " (base version wins on conflicts)...");
									string_3 = stringBuilder.ToString();
									ObservableDictionary<string, Contact> observableDictionary = side_.method_11();
									if (observableDictionary.Count > 0)
									{
										try
										{
											foreach (KeyValuePair<string, Contact> keyValuePair2 in observableDictionary)
											{
												if (!side.method_11().ContainsKey(keyValuePair2.Key))
												{
													side.method_11().Add(keyValuePair2.Key, keyValuePair2.Value);
												}
											}
										}
										finally
										{
											IEnumerator<KeyValuePair<string, Contact>> enumerator6;
											if (enumerator6 != null)
											{
												enumerator6.Dispose();
											}
										}
									}
									stringBuilder.Append("\r\n").Append("\r\n").Append("Merging base-contacts zones of side: " + side_.method_51() + " (base version wins on conflicts)...");
									string_3 = stringBuilder.ToString();
									ObservableDictionary<string, Contact> observableDictionary2 = side_.method_12();
									if (observableDictionary2.Count > 0)
									{
										try
										{
											foreach (KeyValuePair<string, Contact> keyValuePair3 in observableDictionary2)
											{
												if (!side.method_12().ContainsKey(keyValuePair3.Key))
												{
													side.method_12().Add(keyValuePair3.Key, keyValuePair3.Value);
												}
											}
										}
										finally
										{
											IEnumerator<KeyValuePair<string, Contact>> enumerator7;
											if (enumerator7 != null)
											{
												enumerator7.Dispose();
											}
										}
									}
									stringBuilder.Append("\r\n").Append("\r\n").Append("Merging non-AU contacts zones of side: " + side_.method_51() + "...");
									string_3 = stringBuilder.ToString();
									HashSet<string> hashSet_ = side_.hashSet_0;
									if (hashSet_.Count > 0)
									{
										try
										{
											foreach (string text2 in hashSet_)
											{
												side.hashSet_0.Add(text2);
											}
										}
										finally
										{
											HashSet<string>.Enumerator enumerator8;
											enumerator8.Dispose();
										}
									}
									stringBuilder.Append("\r\n").Append("\r\n").Append("Merging missions of side: " + side_.method_51() + " (base version wins on conflicts)...");
									string_3 = stringBuilder.ToString();
									ReadOnlyCollection<Mission> readOnlyCollection3 = side_.method_35();
									if (readOnlyCollection3.Count > 0)
									{
										try
										{
											IEnumerator<Mission> enumerator9 = readOnlyCollection3.GetEnumerator();
											while (enumerator9.MoveNext())
											{
												Scenario.Class305 class6 = new Scenario.Class305(class6);
												class6.mission_0 = enumerator9.Current;
												if (Enumerable.Count<Mission>(Enumerable.Where<Mission>(side.method_35(), new Func<Mission, bool>(class6.method_0))) <= 0)
												{
													side.method_38(class6.mission_0);
													try
													{
														foreach (ActiveUnit activeUnit in scenario2.method_42())
														{
															ActiveUnit activeUnit2;
															if (activeUnit.vmethod_101() != null && activeUnit.vmethod_101() == class6.mission_0 && scenario.vmethod_0().TryGetValue(activeUnit.string_0, ref activeUnit2) && activeUnit2.vmethod_101() == null)
															{
																ActiveUnit activeUnit3 = activeUnit2;
																Mission mission_ = class6.mission_0;
																bool setMissionOnly = true;
																Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
																activeUnit3.vmethod_102(mission_, setMissionOnly, ref missionAssignmentAttemptResult);
															}
														}
													}
													finally
													{
														List<ActiveUnit>.Enumerator enumerator10;
														((IDisposable)enumerator10).Dispose();
													}
												}
											}
										}
										finally
										{
											IEnumerator<Mission> enumerator9;
											if (enumerator9 != null)
											{
												enumerator9.Dispose();
											}
										}
									}
									stringBuilder.Append("\r\n").Append("\r\n").Append("Merging special actions of side: " + side_.method_51() + " (base version wins on conflicts)...");
									string_3 = stringBuilder.ToString();
									Dictionary<string, SpecialAction> dictionary_2 = side_.dictionary_2;
									if (dictionary_2.Count > 0)
									{
										try
										{
											foreach (KeyValuePair<string, SpecialAction> keyValuePair4 in dictionary_2)
											{
												if (!side.dictionary_2.ContainsKey(keyValuePair4.Key))
												{
													side.dictionary_2.Add(keyValuePair4.Key, keyValuePair4.Value);
												}
											}
										}
										finally
										{
											Dictionary<string, SpecialAction>.Enumerator enumerator11;
											((IDisposable)enumerator11).Dispose();
										}
									}
									stringBuilder.Append("\r\n").Append("\r\n").Append("Merging weapon salvos of side: " + side_.method_51() + " (base version wins on conflicts)...");
									string_3 = stringBuilder.ToString();
									Class316[] class316_ = side_.class316_0;
									if (class316_.Length > 0)
									{
										Class316[] array = class316_;
										for (int j = 0; j < array.Length; j++)
										{
											Scenario.Class306 class7 = new Scenario.Class306(class7);
											class7.class316_0 = array[j];
											if (Enumerable.Count<Class316>(Enumerable.Where<Class316>(side.class316_0, new Func<Class316, bool>(class7.method_0))) <= 0)
											{
												Class429.smethod_42(ref side.class316_0, class7.class316_0);
											}
										}
									}
									stringBuilder.Append("Finished merging objects of side: " + side_.method_51());
									string_3 = stringBuilder.ToString();
								}
								else
								{
									scenario.method_69(@class.side_0);
									stringBuilder.Append("OK");
									string_3 = stringBuilder.ToString();
								}
							}
						}
						if (scenario2.vmethod_12().Count > 0)
						{
							stringBuilder.Append("\r\n").Append("\r\n").Append("Merging explosions from scenario #2 into scenario #1...");
							string_3 = stringBuilder.ToString();
							try
							{
								List<Explosion>.Enumerator enumerator12 = scenario2.vmethod_12().GetEnumerator();
								while (enumerator12.MoveNext())
								{
									Scenario.Class307 class8 = new Scenario.Class307(class8);
									class8.explosion_0 = enumerator12.Current;
									stringBuilder.Append("\r\n").Append(class8.explosion_0.string_0).Append(": ");
									string_3 = stringBuilder.ToString();
									if (Enumerable.Count<Explosion>(Enumerable.Where<Explosion>(scenario.vmethod_12(), new Func<Explosion, bool>(class8.method_0))) > 0)
									{
										stringBuilder.Append("An explosion with the same unique ID already exists on scenario #1 - skipping.");
										string_3 = stringBuilder.ToString();
									}
									else
									{
										scenario.vmethod_12().method_4(class8.explosion_0);
										stringBuilder.Append("OK");
										string_3 = stringBuilder.ToString();
									}
								}
							}
							finally
							{
								List<Explosion>.Enumerator enumerator12;
								((IDisposable)enumerator12).Dispose();
							}
						}
						if (scenario2.vmethod_14().Count > 0)
						{
							stringBuilder.Append("\r\n").Append("\r\n").Append("Merging weapon impacts from scenario #2 into scenario #1...");
							string_3 = stringBuilder.ToString();
							try
							{
								List<WeaponImpact>.Enumerator enumerator13 = scenario2.vmethod_14().GetEnumerator();
								while (enumerator13.MoveNext())
								{
									Scenario.Class308 class9 = new Scenario.Class308(class9);
									class9.weaponImpact_0 = enumerator13.Current;
									stringBuilder.Append("\r\n").Append(class9.weaponImpact_0.string_0).Append(": ");
									string_3 = stringBuilder.ToString();
									if (Enumerable.Count<WeaponImpact>(Enumerable.Where<WeaponImpact>(scenario.vmethod_14(), new Func<WeaponImpact, bool>(class9.method_0))) > 0)
									{
										stringBuilder.Append("A weapon impact with the same unique ID already exists on scenario #1 - skipping.");
										string_3 = stringBuilder.ToString();
									}
									else
									{
										scenario.vmethod_14().method_4(class9.weaponImpact_0);
										stringBuilder.Append("OK");
										string_3 = stringBuilder.ToString();
									}
								}
							}
							finally
							{
								List<WeaponImpact>.Enumerator enumerator13;
								((IDisposable)enumerator13).Dispose();
							}
						}
						if (scenario2.vmethod_20().Count > 0)
						{
							stringBuilder.Append("\r\n").Append("\r\n").Append("Merging unguided weapons from scenario #2 into scenario #1...");
							string_3 = stringBuilder.ToString();
							try
							{
								foreach (KeyValuePair<string, UnguidedWeapon> keyValuePair5 in scenario2.vmethod_20())
								{
									stringBuilder.Append("\r\n").Append(keyValuePair5.Key).Append(" (").Append(keyValuePair5.Value.Name).Append("): ");
									string_3 = stringBuilder.ToString();
									if (scenario.vmethod_20().ContainsKey(keyValuePair5.Key))
									{
										stringBuilder.Append("An unguided weapon with the same unique ID already exists on scenario #1 - skipping.");
										string_3 = stringBuilder.ToString();
									}
									else
									{
										scenario.vmethod_20().Add(keyValuePair5.Key, keyValuePair5.Value);
										stringBuilder.Append("OK");
										string_3 = stringBuilder.ToString();
									}
								}
							}
							finally
							{
								IEnumerator<KeyValuePair<string, UnguidedWeapon>> enumerator14;
								if (enumerator14 != null)
								{
									enumerator14.Dispose();
								}
							}
						}
						if (scenario2.ChaffClouds.Count > 0)
						{
							stringBuilder.Append("\r\n").Append("\r\n").Append("Merging chaff clouds from scenario #2 into scenario #1...");
							string_3 = stringBuilder.ToString();
							try
							{
								List<ChaffCorridorCloud>.Enumerator enumerator15 = scenario2.ChaffClouds.GetEnumerator();
								while (enumerator15.MoveNext())
								{
									Scenario.Class309 class10 = new Scenario.Class309(class10);
									class10.chaffCorridorCloud_0 = enumerator15.Current;
									stringBuilder.Append("\r\n").Append(class10.chaffCorridorCloud_0.string_0).Append(": ");
									string_3 = stringBuilder.ToString();
									if (Enumerable.Count<ChaffCorridorCloud>(Enumerable.Where<ChaffCorridorCloud>(scenario.ChaffClouds, new Func<ChaffCorridorCloud, bool>(class10.method_0))) > 0)
									{
										stringBuilder.Append("A chaff cloud with the same unique ID already exists on scenario #1 - skipping.");
										string_3 = stringBuilder.ToString();
									}
									else
									{
										scenario.ChaffClouds.Add(class10.chaffCorridorCloud_0);
										stringBuilder.Append("OK");
										string_3 = stringBuilder.ToString();
									}
								}
							}
							finally
							{
								List<ChaffCorridorCloud>.Enumerator enumerator15;
								((IDisposable)enumerator15).Dispose();
							}
						}
						if (scenario2.vmethod_0().Count > 0)
						{
							stringBuilder.Append("\r\n").Append("\r\n").Append("Merging active units from scenario #2 into scenario #1...");
							string_3 = stringBuilder.ToString();
							try
							{
								foreach (KeyValuePair<string, ActiveUnit> keyValuePair6 in scenario2.vmethod_0())
								{
									stringBuilder.Append("\r\n").Append(keyValuePair6.Value.Name).Append(" (").Append(keyValuePair6.Value.string_2).Append("): ");
									string_3 = stringBuilder.ToString();
									if (scenario.vmethod_0().ContainsKey(keyValuePair6.Key))
									{
										stringBuilder.Append("An active unit with the same unique ID already exists on scenario #1 - skipping.");
										string_3 = stringBuilder.ToString();
									}
									else
									{
										scenario.vmethod_0().Add(keyValuePair6.Key, keyValuePair6.Value);
										stringBuilder.Append("OK");
										string_3 = stringBuilder.ToString();
									}
								}
							}
							finally
							{
								IEnumerator<KeyValuePair<string, ActiveUnit>> enumerator16;
								if (enumerator16 != null)
								{
									enumerator16.Dispose();
								}
							}
						}
						if (scenario2.Groups.Count > 0)
						{
							stringBuilder.Append("\r\n").Append("\r\n").Append("Merging groups from scenario #2 into scenario #1...");
							string_3 = stringBuilder.ToString();
							try
							{
								foreach (Group group in scenario2.Groups)
								{
									stringBuilder.Append("\r\n").Append(group.Name).Append(": ");
									string_3 = stringBuilder.ToString();
									if (scenario.Groups.method_1(group.Name))
									{
										stringBuilder.Append("A group with the same name already exists on scenario #1 - skipping.");
										string_3 = stringBuilder.ToString();
									}
									else
									{
										scenario.Groups.Add(group);
										stringBuilder.Append("OK");
										string_3 = stringBuilder.ToString();
									}
								}
							}
							finally
							{
								IEnumerator<Group> enumerator17;
								if (enumerator17 != null)
								{
									enumerator17.Dispose();
								}
							}
						}
						if (scenario2.vmethod_4().Count > 0)
						{
							stringBuilder.Append("\r\n").Append("\r\n").Append("Merging event triggers from scenario #2 into scenario #1...");
							string_3 = stringBuilder.ToString();
							try
							{
								foreach (KeyValuePair<string, EventTrigger> keyValuePair7 in scenario2.vmethod_4())
								{
									stringBuilder.Append("\r\n").Append(keyValuePair7.Value.Name).Append(" (").Append(keyValuePair7.Key).Append("): ");
									string_3 = stringBuilder.ToString();
									if (scenario.vmethod_4().ContainsKey(keyValuePair7.Key))
									{
										stringBuilder.Append("An event trigger with the same unique ID already exists on scenario #1 - skipping.");
										string_3 = stringBuilder.ToString();
									}
									else
									{
										scenario.vmethod_4().Add(keyValuePair7.Key, keyValuePair7.Value);
										stringBuilder.Append("OK");
										string_3 = stringBuilder.ToString();
									}
								}
							}
							finally
							{
								IEnumerator<KeyValuePair<string, EventTrigger>> enumerator18;
								if (enumerator18 != null)
								{
									enumerator18.Dispose();
								}
							}
						}
						if (scenario2.vmethod_6().Count > 0)
						{
							stringBuilder.Append("\r\n").Append("\r\n").Append("Merging event conditions from scenario #2 into scenario #1...");
							string_3 = stringBuilder.ToString();
							try
							{
								foreach (KeyValuePair<string, EventCondition> keyValuePair8 in scenario2.vmethod_6())
								{
									stringBuilder.Append("\r\n").Append(keyValuePair8.Value.Name).Append(" (").Append(keyValuePair8.Key).Append("): ");
									string_3 = stringBuilder.ToString();
									if (scenario.vmethod_6().ContainsKey(keyValuePair8.Key))
									{
										stringBuilder.Append("An event condition with the same unique ID already exists on scenario #1 - skipping.");
										string_3 = stringBuilder.ToString();
									}
									else
									{
										scenario.vmethod_6().Add(keyValuePair8.Key, keyValuePair8.Value);
										stringBuilder.Append("OK");
										string_3 = stringBuilder.ToString();
									}
								}
							}
							finally
							{
								IEnumerator<KeyValuePair<string, EventCondition>> enumerator19;
								if (enumerator19 != null)
								{
									enumerator19.Dispose();
								}
							}
						}
						if (scenario2.vmethod_8().Count > 0)
						{
							stringBuilder.Append("\r\n").Append("\r\n").Append("Merging event actions from scenario #2 into scenario #1...");
							string_3 = stringBuilder.ToString();
							try
							{
								foreach (KeyValuePair<string, EventAction> keyValuePair9 in scenario2.vmethod_8())
								{
									stringBuilder.Append("\r\n").Append(keyValuePair9.Value.Name).Append(" (").Append(keyValuePair9.Key).Append("): ");
									string_3 = stringBuilder.ToString();
									if (scenario.vmethod_8().ContainsKey(keyValuePair9.Key))
									{
										stringBuilder.Append("An event action with the same unique ID already exists on scenario #1 - skipping.");
										string_3 = stringBuilder.ToString();
									}
									else
									{
										scenario.vmethod_8().Add(keyValuePair9.Key, keyValuePair9.Value);
										stringBuilder.Append("OK");
										string_3 = stringBuilder.ToString();
									}
								}
							}
							finally
							{
								IEnumerator<KeyValuePair<string, EventAction>> enumerator20;
								if (enumerator20 != null)
								{
									enumerator20.Dispose();
								}
							}
						}
						if (scenario2.vmethod_10().Count > 0)
						{
							stringBuilder.Append("\r\n").Append("\r\n").Append("Merging sim events from scenario #2 into scenario #1...");
							string_3 = stringBuilder.ToString();
							try
							{
								foreach (KeyValuePair<string, SimEvent> keyValuePair10 in scenario2.vmethod_10())
								{
									stringBuilder.Append("\r\n").Append(keyValuePair10.Value.Name).Append(" (").Append(keyValuePair10.Key).Append("): ");
									string_3 = stringBuilder.ToString();
									if (scenario.vmethod_10().ContainsKey(keyValuePair10.Key))
									{
										stringBuilder.Append("A sim event with the same unique ID already exists on scenario #1 - skipping.");
										string_3 = stringBuilder.ToString();
									}
									else
									{
										scenario.vmethod_10().Add(keyValuePair10.Key, keyValuePair10.Value);
										stringBuilder.Append("OK");
										string_3 = stringBuilder.ToString();
									}
								}
							}
							finally
							{
								IEnumerator<KeyValuePair<string, SimEvent>> enumerator21;
								if (enumerator21 != null)
								{
									enumerator21.Dispose();
								}
							}
						}
						if (scenario2.vmethod_2().Count > 0)
						{
							stringBuilder.Append("\r\n").Append("\r\n").Append("Merging scenario attachments from scenario #2 into scenario #1...");
							string_3 = stringBuilder.ToString();
							try
							{
								foreach (KeyValuePair<string, ScenAttachmentObject> keyValuePair11 in scenario2.vmethod_2())
								{
									stringBuilder.Append("\r\n").Append(keyValuePair11.Value.method_1()).Append(" (").Append(keyValuePair11.Key).Append("): ");
									string_3 = stringBuilder.ToString();
									if (scenario.vmethod_2().ContainsKey(keyValuePair11.Key))
									{
										stringBuilder.Append("A scen attachment object with the same unique ID already exists on scenario #1 - skipping.");
										string_3 = stringBuilder.ToString();
									}
									else
									{
										scenario.vmethod_2().Add(keyValuePair11.Key, keyValuePair11.Value);
										stringBuilder.Append("OK");
										string_3 = stringBuilder.ToString();
									}
								}
							}
							finally
							{
								IEnumerator<KeyValuePair<string, ScenAttachmentObject>> enumerator22;
								if (enumerator22 != null)
								{
									enumerator22.Dispose();
								}
							}
						}
					}
					int unitsAutoIncrement = scenario.vmethod_0().Count + scenario.Groups.Count + scenario.vmethod_20().Count + Enumerable.Sum(Enumerable.Select<Side, int>(scenario.method_44(), (Scenario._Closure$__.$I367-11 == null) ? (Scenario._Closure$__.$I367-11 = new Func<Side, int>(Scenario._Closure$__.$I.method_2)) : Scenario._Closure$__.$I367-11)) + 10;
					scenario.UnitsAutoIncrement = unitsAutoIncrement;
					stringBuilder.Append("\r\n").Append("\r\n").Append("Finished merging objects - saving result...");
					string_3 = stringBuilder.ToString();
					Class434.smethod_1(scenario, scenario.method_54(), string_2, false, false);
					stringBuilder.Append("\r\n").Append("\r\n").Append("Merging completed successfully!");
					string_3 = stringBuilder.ToString();
					scenario = null;
					scenario2 = null;
					GameGeneral.smethod_10();
					result = true;
				}
			}
			catch (Exception ex3)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				GameGeneral.smethod_1("Unhandled exception during merge: " + ex3.Message + "\r\n\r\nStacktrace: " + ex3.StackTrace);
				result = false;
			}
			return result;
		}

		// Token: 0x040013F4 RID: 5108
		public string TimelineID;

		// Token: 0x040013F5 RID: 5109
		public string ParentTimelineID;

		// Token: 0x040013F6 RID: 5110
		public int MonteCarloIteration;

		// Token: 0x040013F7 RID: 5111
		private string _ObjectID;

		// Token: 0x040013F8 RID: 5112
		public string ContentTag;

		// Token: 0x040013F9 RID: 5113
		public string CampaignID;

		// Token: 0x040013FA RID: 5114
		public string CampaignSessionID;

		// Token: 0x040013FB RID: 5115
		public int CampaignScore;

		// Token: 0x040013FC RID: 5116
		public bool RunningInMonteCarloMode;

		// Token: 0x040013FD RID: 5117
		private string _Title;

		// Token: 0x040013FE RID: 5118
		private string _Description;

		// Token: 0x040013FF RID: 5119
		public short Meta_Complexity;

		// Token: 0x04001400 RID: 5120
		public short Meta_Difficulty;

		// Token: 0x04001401 RID: 5121
		public string Meta_ScenSetting;

		// Token: 0x04001402 RID: 5122
		public string FileName;

		// Token: 0x04001403 RID: 5123
		private DateTime _Time;

		// Token: 0x04001404 RID: 5124
		public DateTime ZeroHour;

		// Token: 0x04001405 RID: 5125
		private bool _DaylightSavingTime;

		// Token: 0x04001406 RID: 5126
		private string _DaylightSavingTime_Start;

		// Token: 0x04001407 RID: 5127
		private string _DaylightSavingTime_End;

		// Token: 0x04001408 RID: 5128
		private DateTime? _StartTime;

		// Token: 0x04001409 RID: 5129
		private TimeSpan? _Duration;

		// Token: 0x0400140A RID: 5130
		private bool _HasEnded;

		// Token: 0x0400140B RID: 5131
		[CompilerGenerated]
		[AccessedThroughProperty("ActiveUnits")]
		private ObservableDictionary<string, ActiveUnit> _ActiveUnits;

		// Token: 0x0400140C RID: 5132
		private List<ActiveUnit> _ActiveUnits_List;

		// Token: 0x0400140D RID: 5133
		public GroupsCollection Groups;

		// Token: 0x0400140E RID: 5134
		private List<Weapon> _GuidedWeaponsInAir;

		// Token: 0x0400140F RID: 5135
		private List<Weapon> _SonobuoysInWater;

		// Token: 0x04001410 RID: 5136
		private List<Weapon> _AllWeaponsAlive;

		// Token: 0x04001411 RID: 5137
		private Scenario.enumTimeCompression _TimeCompression;

		// Token: 0x04001412 RID: 5138
		private float _GameResolution;

		// Token: 0x04001413 RID: 5139
		private Side[] _Sides;

		// Token: 0x04001414 RID: 5140
		private List<ActiveUnit> _UnitAdditions;

		// Token: 0x04001415 RID: 5141
		private List<ActiveUnit> _UnitRemovals;

		// Token: 0x04001416 RID: 5142
		private List<ActiveUnit> _UnitDeletions;

		// Token: 0x04001417 RID: 5143
		public int UnitsAutoIncrement;

		// Token: 0x04001418 RID: 5144
		private Side _CurrentSide;

		// Token: 0x04001419 RID: 5145
		public string GameVersion;

		// Token: 0x0400141A RID: 5146
		public bool ExecutionInProgress;

		// Token: 0x0400141B RID: 5147
		public bool SerializationInProgress;

		// Token: 0x0400141C RID: 5148
		public float Navigation_FinegrainedThresholdDistance;

		// Token: 0x0400141D RID: 5149
		public float Navigation_FinegrainedMaxDistance;

		// Token: 0x0400141E RID: 5150
		public bool UserIsPlottingCourse;

		// Token: 0x0400141F RID: 5151
		[CompilerGenerated]
		[AccessedThroughProperty("ScenAttachments")]
		private ObservableDictionary<string, ScenAttachmentObject> _ScenAttachments;

		// Token: 0x04001420 RID: 5152
		public Queue<LoggedMessage> UnhandledPopUpMessages;

		// Token: 0x04001421 RID: 5153
		public List<LoggedMessage> MessageLog;

		// Token: 0x04001422 RID: 5154
		private ConcurrentQueue<LoggedMessage> MessageLogQueue;

		// Token: 0x04001423 RID: 5155
		private long _MessageIncrement;

		// Token: 0x04001424 RID: 5156
		private string _DBUsed;

		// Token: 0x04001425 RID: 5157
		private SQLiteConnection _DBConnection;

		// Token: 0x04001426 RID: 5158
		public bool LoadStockUnits;

		// Token: 0x04001427 RID: 5159
		private List<ActiveUnit> _OperativeUnits;

		// Token: 0x04001428 RID: 5160
		private List<ActiveUnit> _NonoperativeUnits;

		// Token: 0x04001429 RID: 5161
		internal HashSet<XmlNode> UnitsForLateInstantiation;

		// Token: 0x0400142A RID: 5162
		public bool SecondIsChangingOnThisPulse;

		// Token: 0x0400142B RID: 5163
		public bool FifthSecondIsChangingOnThisPulse;

		// Token: 0x0400142C RID: 5164
		public bool FifteenthSecondIsChangingOnThisPulse;

		// Token: 0x0400142D RID: 5165
		public bool ThirtiethSecondIsChangingOnThisPulse;

		// Token: 0x0400142E RID: 5166
		public bool MinuteIsChangingOnThisPulse;

		// Token: 0x0400142F RID: 5167
		public bool FifthMinuteIsChangingOnThisPulse;

		// Token: 0x04001430 RID: 5168
		public bool FifteenthMinuteIsChangingOnThisPulse;

		// Token: 0x04001431 RID: 5169
		public bool ThirtiethMinuteIsChangingOnThisPulse;

		// Token: 0x04001432 RID: 5170
		public bool HourIsChangingOnThisPulse;

		// Token: 0x04001433 RID: 5171
		public bool SixHourIsChangingOnThisPulse;

		// Token: 0x04001434 RID: 5172
		public bool TwelveHourIsChangingOnThisPulse;

		// Token: 0x04001435 RID: 5173
		public bool TwentyFourHourIsChangingOnThisPulse;

		// Token: 0x04001436 RID: 5174
		internal List<ActiveUnit> Cache_FacilitiesWithPiers;

		// Token: 0x04001437 RID: 5175
		public ConcurrentDictionary<int, Weapon> Cache_Weapons;

		// Token: 0x04001438 RID: 5176
		internal ConcurrentDictionary<int, ConcurrentDictionary<int, bool>> Cache_SensorCompatibleFrequencies;

		// Token: 0x04001439 RID: 5177
		internal ConcurrentDictionary<string, XSection[]> Cache_XSections;

		// Token: 0x0400143A RID: 5178
		public DataTable Cache_Aircraft_DT;

		// Token: 0x0400143B RID: 5179
		public DataTable Cache_Ships_DT;

		// Token: 0x0400143C RID: 5180
		public DataTable Cache_Subs_DT;

		// Token: 0x0400143D RID: 5181
		public DataTable Cache_Facilities_DT;

		// Token: 0x0400143E RID: 5182
		public DataTable Cache_Satellites_DT;

		// Token: 0x0400143F RID: 5183
		public DataTable Cache_Weapons_DT;

		// Token: 0x04001440 RID: 5184
		public DataTable Cache_OperatorCountries_DT;

		// Token: 0x04001441 RID: 5185
		internal ConcurrentDictionary<int, int> Cache_FuelForPitchEnabledWeapons;

		// Token: 0x04001442 RID: 5186
		public Weather.TTimeOfDayType?[][] Cache_TimeOfDay;

		// Token: 0x04001443 RID: 5187
		internal Dictionary<int, Sensor> Cache_AssociatedSensors;

		// Token: 0x04001444 RID: 5188
		internal ConcurrentDictionary<int, AltBand[]> Cache_PowerplantAltBands;

		// Token: 0x04001445 RID: 5189
		internal ActiveUnit[] CandidatesForDetectionByMines;

		// Token: 0x04001446 RID: 5190
		public List<string> LoadingNotices;

		// Token: 0x04001447 RID: 5191
		internal bool ThreadedOpsMustStop;

		// Token: 0x04001448 RID: 5192
		public HashSet<Scenario.ScenarioFeatureOption> DeclaredFeatures;

		// Token: 0x04001449 RID: 5193
		public bool LastSavedInScenEdit;

		// Token: 0x0400144A RID: 5194
		public Scenario._FeatureCompatibility FeatureCompatibility;

		// Token: 0x0400144B RID: 5195
		public int? MaxRisingMineRange_meters;

		// Token: 0x0400144C RID: 5196
		private LuaSandBox _Scenario_LuaSandbox;

		// Token: 0x0400144D RID: 5197
		public bool UIRefreshTrigger;

		// Token: 0x0400144E RID: 5198
		public bool CurrentlyInsertingMessages;

		// Token: 0x0400144F RID: 5199
		internal EventWaitHandle EventWaitHandle_FinishPulse;

		// Token: 0x04001450 RID: 5200
		public Scenario.WeatherModellingLevel WeatherLevel;

		// Token: 0x04001451 RID: 5201
		private Weather.WeatherProfile _GlobalWeather;

		// Token: 0x04001452 RID: 5202
		public List<string> MissionPlannerErrorList;

		// Token: 0x04001453 RID: 5203
		[CompilerGenerated]
		[AccessedThroughProperty("EventTriggers")]
		private ObservableDictionary<string, EventTrigger> _EventTriggers;

		// Token: 0x04001454 RID: 5204
		[CompilerGenerated]
		[AccessedThroughProperty("EventConditions")]
		private ObservableDictionary<string, EventCondition> _EventConditions;

		// Token: 0x04001455 RID: 5205
		[CompilerGenerated]
		[AccessedThroughProperty("EventActions")]
		private ObservableDictionary<string, EventAction> _EventActions;

		// Token: 0x04001456 RID: 5206
		[CompilerGenerated]
		[AccessedThroughProperty("SimEvents")]
		private ObservableDictionary<string, SimEvent> _SimEvents;

		// Token: 0x04001457 RID: 5207
		[CompilerGenerated]
		[AccessedThroughProperty("Explosions")]
		private ObservableList<Explosion> _Explosions;

		// Token: 0x04001458 RID: 5208
		[CompilerGenerated]
		[AccessedThroughProperty("WeaponImpacts")]
		private ObservableList<WeaponImpact> _WeaponImpacts;

		// Token: 0x04001459 RID: 5209
		[CompilerGenerated]
		[AccessedThroughProperty("WaterSplashes")]
		private List<WaterSplash> _WaterSplashes;

		// Token: 0x0400145A RID: 5210
		[CompilerGenerated]
		[AccessedThroughProperty("GroundImpacts")]
		private List<GroundImpact> _GroundImpacts;

		// Token: 0x0400145B RID: 5211
		[CompilerGenerated]
		[AccessedThroughProperty("UnguidedWeapons")]
		private ObservableDictionary<string, UnguidedWeapon> _UnguidedWeapons;

		// Token: 0x0400145C RID: 5212
		public List<UnguidedWeapon> Mines;

		// Token: 0x0400145D RID: 5213
		public List<ChaffCorridorCloud> ChaffClouds;

		// Token: 0x0400145E RID: 5214
		[CompilerGenerated]
		private static Scenario.TitleChangedEventHandler TitleChangedEvent;

		// Token: 0x0400145F RID: 5215
		[CompilerGenerated]
		private static Scenario.CurrentScenarioChangedEventHandler CurrentScenarioChangedEvent;

		// Token: 0x04001460 RID: 5216
		[CompilerGenerated]
		private static Scenario.CurrentSideChangedEventHandler CurrentSideChangedEvent;

		// Token: 0x04001461 RID: 5217
		[CompilerGenerated]
		private static Scenario.SidesChangedEventHandler SidesChangedEvent;

		// Token: 0x04001462 RID: 5218
		[CompilerGenerated]
		private static Scenario.TimeCompressionChangedEventHandler TimeCompressionChangedEvent;

		// Token: 0x04001463 RID: 5219
		[CompilerGenerated]
		private static Scenario.TimeChangedManuallyEventHandler TimeChangedManuallyEvent;

		// Token: 0x04001464 RID: 5220
		[CompilerGenerated]
		private static Scenario.NewMessageEventHandler NewMessageEvent;

		// Token: 0x04001465 RID: 5221
		[CompilerGenerated]
		private static Scenario.UnitAddedEventHandler UnitAddedEvent;

		// Token: 0x04001466 RID: 5222
		[CompilerGenerated]
		private static Scenario.UnitRemovedEventHandler UnitRemovedEvent;

		// Token: 0x04001467 RID: 5223
		[CompilerGenerated]
		private static Scenario.EventTriggersChangedEventHandler EventTriggersChangedEvent;

		// Token: 0x04001468 RID: 5224
		[CompilerGenerated]
		private static Scenario.EventConditionsChangedEventHandler EventConditionsChangedEvent;

		// Token: 0x04001469 RID: 5225
		[CompilerGenerated]
		private static Scenario.EventActionsChangedEventHandler EventActionsChangedEvent;

		// Token: 0x0400146A RID: 5226
		[CompilerGenerated]
		private static Scenario.ScenAttachmentsChangedEventHandler ScenAttachmentsChangedEvent;

		// Token: 0x0400146B RID: 5227
		[CompilerGenerated]
		private static Scenario.ScenCompletedEventHandler ScenCompletedEvent;

		// Token: 0x0400146C RID: 5228
		public string LuaXml;

		// Token: 0x0400146D RID: 5229
		public string LuaXmlPassed;

		// Token: 0x0400146E RID: 5230
		public static List<Tuple<string, CargoTracker>> CargoMovement = new List<Tuple<string, CargoTracker>>();

		// Token: 0x0400146F RID: 5231
		private object LockObject1;

		// Token: 0x04001470 RID: 5232
		private object LockObject2;

		// Token: 0x020002FC RID: 764
		// (Invoke) Token: 0x06001723 RID: 5923
		public delegate void TitleChangedEventHandler(Scenario theScen, string NewTitle);

		// Token: 0x020002FD RID: 765
		// (Invoke) Token: 0x06001727 RID: 5927
		public delegate void CurrentScenarioChangedEventHandler(Scenario theNewScen);

		// Token: 0x020002FE RID: 766
		// (Invoke) Token: 0x0600172B RID: 5931
		public delegate void CurrentSideChangedEventHandler(Scenario theScen);

		// Token: 0x020002FF RID: 767
		// (Invoke) Token: 0x0600172F RID: 5935
		public delegate void SidesChangedEventHandler(Scenario theScen, Scenario.Enum117 AddOrRemove);

		// Token: 0x02000300 RID: 768
		// (Invoke) Token: 0x06001733 RID: 5939
		public delegate void TimeCompressionChangedEventHandler();

		// Token: 0x02000301 RID: 769
		// (Invoke) Token: 0x06001737 RID: 5943
		public delegate void TimeChangedManuallyEventHandler(Scenario theScen, DateTime NewTime);

		// Token: 0x02000302 RID: 770
		// (Invoke) Token: 0x0600173B RID: 5947
		public delegate void NewMessageEventHandler(LoggedMessage theM);

		// Token: 0x02000303 RID: 771
		// (Invoke) Token: 0x0600173F RID: 5951
		public delegate void UnitAddedEventHandler(Scenario theScen, string theUnitObjectID);

		// Token: 0x02000304 RID: 772
		// (Invoke) Token: 0x06001743 RID: 5955
		public delegate void UnitRemovedEventHandler(Scenario theScen, ActiveUnit theUnit);

		// Token: 0x02000305 RID: 773
		// (Invoke) Token: 0x06001747 RID: 5959
		public delegate void EventTriggersChangedEventHandler(Scenario theScen);

		// Token: 0x02000306 RID: 774
		// (Invoke) Token: 0x0600174B RID: 5963
		public delegate void EventConditionsChangedEventHandler(Scenario theScen);

		// Token: 0x02000307 RID: 775
		// (Invoke) Token: 0x0600174F RID: 5967
		public delegate void EventActionsChangedEventHandler(Scenario theScen);

		// Token: 0x02000308 RID: 776
		// (Invoke) Token: 0x06001753 RID: 5971
		public delegate void ScenAttachmentsChangedEventHandler();

		// Token: 0x02000309 RID: 777
		// (Invoke) Token: 0x06001757 RID: 5975
		public delegate void ScenCompletedEventHandler(Scenario theScen);

		// Token: 0x0200030A RID: 778
		public enum enumTimeCompression : byte
		{
			// Token: 0x04001472 RID: 5234
			OneSec,
			// Token: 0x04001473 RID: 5235
			TwoSec,
			// Token: 0x04001474 RID: 5236
			FiveSec,
			// Token: 0x04001475 RID: 5237
			Turbo
		}

		// Token: 0x0200030B RID: 779
		public enum ScenarioFeatureOption
		{
			// Token: 0x04001477 RID: 5239
			const_0,
			// Token: 0x04001478 RID: 5240
			const_1,
			// Token: 0x04001479 RID: 5241
			const_2,
			// Token: 0x0400147A RID: 5242
			const_3,
			// Token: 0x0400147B RID: 5243
			const_4 = 5,
			// Token: 0x0400147C RID: 5244
			const_5,
			// Token: 0x0400147D RID: 5245
			const_6,
			// Token: 0x0400147E RID: 5246
			const_7 = 9,
			// Token: 0x0400147F RID: 5247
			const_8,
			// Token: 0x04001480 RID: 5248
			const_9 = 12,
			// Token: 0x04001481 RID: 5249
			const_10
		}

		// Token: 0x0200030C RID: 780
		internal enum Enum117 : byte
		{
			// Token: 0x04001483 RID: 5251
			const_0,
			// Token: 0x04001484 RID: 5252
			const_1
		}

		// Token: 0x0200030D RID: 781
		public enum WeatherModellingLevel : byte
		{
			// Token: 0x04001486 RID: 5254
			Level0,
			// Token: 0x04001487 RID: 5255
			Level1
		}

		// Token: 0x0200030E RID: 782
		public struct _FeatureCompatibility
		{
			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06001758 RID: 5976 RVA: 0x0000C219 File Offset: 0x0000A419
			public bool CarrierCapableFlag
			{
				get
				{
					if (this._CarrierCapableFlag == null)
					{
						this._CarrierCapableFlag = new bool?(DBFunctions.smethod_105(1, sqliteConnection_0));
					}
					return this._CarrierCapableFlag.Value;
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06001759 RID: 5977 RVA: 0x0000C245 File Offset: 0x0000A445
			public bool WRA
			{
				get
				{
					if (this._WRA == null)
					{
						this._WRA = new bool?(DBFunctions.smethod_105(2, sqliteConnection_0));
					}
					return this._WRA.Value;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x0600175A RID: 5978 RVA: 0x0000C271 File Offset: 0x0000A471
			public bool LPI_Radars
			{
				get
				{
					if (this._LPI_Radars == null)
					{
						this._LPI_Radars = new bool?(DBFunctions.smethod_105(3, sqliteConnection_0));
					}
					return this._LPI_Radars.Value;
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x0600175B RID: 5979 RVA: 0x0000C29D File Offset: 0x0000A49D
			public bool WeaponSnapUpDown
			{
				get
				{
					if (this._WeaponSnapUpDown == null)
					{
						this._WeaponSnapUpDown = new bool?(DBFunctions.smethod_105(4, sqliteConnection_0));
					}
					return this._WeaponSnapUpDown.Value;
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x0600175C RID: 5980 RVA: 0x0000C2C9 File Offset: 0x0000A4C9
			public bool WeaponAGL_ASL
			{
				get
				{
					if (this._WeaponAGL_ASL == null)
					{
						this._WeaponAGL_ASL = new bool?(DBFunctions.smethod_105(5, sqliteConnection_0));
					}
					return this._WeaponAGL_ASL.Value;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600175D RID: 5981 RVA: 0x00003024 File Offset: 0x00001224
			public bool GuidedWeaponsPitchAttitude
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x0600175E RID: 5982 RVA: 0x0000C2F5 File Offset: 0x0000A4F5
			// (set) Token: 0x0600175F RID: 5983 RVA: 0x0000C2FD File Offset: 0x0000A4FD
			public bool CockpitVisibility { get; set; }

			// Token: 0x04001488 RID: 5256
			private bool? _Hypotheticals;

			// Token: 0x04001489 RID: 5257
			private bool? _CarrierCapableFlag;

			// Token: 0x0400148A RID: 5258
			private bool? _WRA;

			// Token: 0x0400148B RID: 5259
			private bool? _LPI_Radars;

			// Token: 0x0400148C RID: 5260
			private bool? _WeaponSnapUpDown;

			// Token: 0x0400148D RID: 5261
			private bool? _WeaponAGL_ASL;

			// Token: 0x0400148E RID: 5262
			private bool? _GuidedWeaponsPitchAttitude;
		}

		// Token: 0x0200030F RID: 783
		[CompilerGenerated]
		internal sealed class Class297
		{
			// Token: 0x06001760 RID: 5984 RVA: 0x0000C306 File Offset: 0x0000A506
			public Class297(Scenario.Class297 class297_0)
			{
				if (class297_0 != null)
				{
					this.side_0 = class297_0.side_0;
					this.dateTime_0 = class297_0.dateTime_0;
					this.string_0 = class297_0.string_0;
					this.bool_0 = class297_0.bool_0;
				}
			}

			// Token: 0x06001761 RID: 5985 RVA: 0x001AD718 File Offset: 0x001AB918
			internal void method_0(LoggedMessage loggedMessage_0, ParallelLoopState parallelLoopState_0)
			{
				if (loggedMessage_0 != null && loggedMessage_0.side_0 != null && loggedMessage_0.side_0 == this.side_0 && DateTime.Compare(loggedMessage_0.dateTime_0, this.dateTime_0) == 0 && string.CompareOrdinal(loggedMessage_0.string_2, this.string_0) == 0)
				{
					this.bool_0 = true;
					parallelLoopState_0.Stop();
				}
			}

			// Token: 0x04001490 RID: 5264
			public Side side_0;

			// Token: 0x04001491 RID: 5265
			public DateTime dateTime_0;

			// Token: 0x04001492 RID: 5266
			public string string_0;

			// Token: 0x04001493 RID: 5267
			public bool bool_0;
		}

		// Token: 0x02000310 RID: 784
		[CompilerGenerated]
		internal sealed class Class298
		{
			// Token: 0x06001762 RID: 5986 RVA: 0x0000C341 File Offset: 0x0000A541
			public Class298(Scenario.Class298 class298_0)
			{
				if (class298_0 != null)
				{
					this.side_0 = class298_0.side_0;
				}
			}

			// Token: 0x04001494 RID: 5268
			public Side side_0;

			// Token: 0x04001495 RID: 5269
			public Scenario.Class297 class297_0;
		}

		// Token: 0x02000311 RID: 785
		[CompilerGenerated]
		internal sealed class Class299
		{
			// Token: 0x06001763 RID: 5987 RVA: 0x0000C358 File Offset: 0x0000A558
			public Class299(Scenario.Class299 class299_0)
			{
				if (class299_0 != null)
				{
					this.bool_0 = class299_0.bool_0;
				}
			}

			// Token: 0x06001764 RID: 5988 RVA: 0x001AD774 File Offset: 0x001AB974
			internal void method_0(LoggedMessage loggedMessage_0, ParallelLoopState parallelLoopState_0)
			{
				if (loggedMessage_0 != null && loggedMessage_0.side_0 != null && loggedMessage_0.side_0 == this.class298_0.side_0 && DateTime.Compare(loggedMessage_0.dateTime_0, this.class298_0.class297_0.dateTime_0) == 0 && string.CompareOrdinal(loggedMessage_0.string_2, this.class298_0.class297_0.string_0) == 0)
				{
					this.bool_0 = true;
					parallelLoopState_0.Stop();
				}
			}

			// Token: 0x04001496 RID: 5270
			public bool bool_0;

			// Token: 0x04001497 RID: 5271
			public Scenario.Class298 class298_0;
		}

		// Token: 0x02000313 RID: 787
		[CompilerGenerated]
		internal sealed class Class300
		{
			// Token: 0x0600176A RID: 5994 RVA: 0x0000C398 File Offset: 0x0000A598
			public Class300(Scenario.Class300 class300_0)
			{
				if (class300_0 != null)
				{
					this.side_0 = class300_0.side_0;
				}
			}

			// Token: 0x0600176B RID: 5995 RVA: 0x0000C3AF File Offset: 0x0000A5AF
			internal bool method_0(Side side_1)
			{
				return Operators.CompareString(side_1.string_0, this.side_0.string_0, false) == 0;
			}

			// Token: 0x0600176C RID: 5996 RVA: 0x0000C3AF File Offset: 0x0000A5AF
			internal bool method_1(Side side_1)
			{
				return Operators.CompareString(side_1.string_0, this.side_0.string_0, false) == 0;
			}

			// Token: 0x0400149C RID: 5276
			public Side side_0;
		}

		// Token: 0x02000314 RID: 788
		[CompilerGenerated]
		internal sealed class Class301
		{
			// Token: 0x0600176D RID: 5997 RVA: 0x0000C3CB File Offset: 0x0000A5CB
			public Class301(Scenario.Class301 class301_0)
			{
				if (class301_0 != null)
				{
					this.keyValuePair_0 = class301_0.keyValuePair_0;
				}
			}

			// Token: 0x0600176E RID: 5998 RVA: 0x0000C3E2 File Offset: 0x0000A5E2
			internal bool method_0(KeyValuePair<Side, Misc.PostureStance> keyValuePair_1)
			{
				return Operators.CompareString(keyValuePair_1.Key.string_0, this.keyValuePair_0.Key.string_0, false) == 0;
			}

			// Token: 0x0400149D RID: 5277
			public KeyValuePair<Side, Misc.PostureStance> keyValuePair_0;
		}

		// Token: 0x02000315 RID: 789
		[CompilerGenerated]
		internal sealed class Class302
		{
			// Token: 0x0600176F RID: 5999 RVA: 0x0000C409 File Offset: 0x0000A609
			public Class302(Scenario.Class302 class302_0)
			{
				if (class302_0 != null)
				{
					this.referencePoint_0 = class302_0.referencePoint_0;
				}
			}

			// Token: 0x06001770 RID: 6000 RVA: 0x0000C420 File Offset: 0x0000A620
			internal bool method_0(ReferencePoint referencePoint_1)
			{
				return Operators.CompareString(referencePoint_1.string_0, this.referencePoint_0.string_0, false) == 0;
			}

			// Token: 0x0400149E RID: 5278
			public ReferencePoint referencePoint_0;
		}

		// Token: 0x02000316 RID: 790
		[CompilerGenerated]
		internal sealed class Class303
		{
			// Token: 0x06001771 RID: 6001 RVA: 0x0000C43C File Offset: 0x0000A63C
			public Class303(Scenario.Class303 class303_0)
			{
				if (class303_0 != null)
				{
					this.exclusionZone_0 = class303_0.exclusionZone_0;
				}
			}

			// Token: 0x06001772 RID: 6002 RVA: 0x0000C453 File Offset: 0x0000A653
			internal bool method_0(ExclusionZone exclusionZone_1)
			{
				return Operators.CompareString(exclusionZone_1.string_0, this.exclusionZone_0.string_0, false) == 0;
			}

			// Token: 0x0400149F RID: 5279
			public ExclusionZone exclusionZone_0;
		}

		// Token: 0x02000317 RID: 791
		[CompilerGenerated]
		internal sealed class Class304
		{
			// Token: 0x06001773 RID: 6003 RVA: 0x0000C46F File Offset: 0x0000A66F
			public Class304(Scenario.Class304 class304_0)
			{
				if (class304_0 != null)
				{
					this.noNavZone_0 = class304_0.noNavZone_0;
				}
			}

			// Token: 0x06001774 RID: 6004 RVA: 0x0000C486 File Offset: 0x0000A686
			internal bool method_0(NoNavZone noNavZone_1)
			{
				return Operators.CompareString(noNavZone_1.string_0, this.noNavZone_0.string_0, false) == 0;
			}

			// Token: 0x040014A0 RID: 5280
			public NoNavZone noNavZone_0;
		}

		// Token: 0x02000318 RID: 792
		[CompilerGenerated]
		internal sealed class Class305
		{
			// Token: 0x06001775 RID: 6005 RVA: 0x0000C4A2 File Offset: 0x0000A6A2
			public Class305(Scenario.Class305 class305_0)
			{
				if (class305_0 != null)
				{
					this.mission_0 = class305_0.mission_0;
				}
			}

			// Token: 0x06001776 RID: 6006 RVA: 0x0000C4B9 File Offset: 0x0000A6B9
			internal bool method_0(Mission mission_1)
			{
				return Operators.CompareString(mission_1.string_0, this.mission_0.string_0, false) == 0;
			}

			// Token: 0x040014A1 RID: 5281
			public Mission mission_0;
		}

		// Token: 0x02000319 RID: 793
		[CompilerGenerated]
		internal sealed class Class306
		{
			// Token: 0x06001777 RID: 6007 RVA: 0x0000C4D5 File Offset: 0x0000A6D5
			public Class306(Scenario.Class306 class306_0)
			{
				if (class306_0 != null)
				{
					this.class316_0 = class306_0.class316_0;
				}
			}

			// Token: 0x06001778 RID: 6008 RVA: 0x0000C4EC File Offset: 0x0000A6EC
			internal bool method_0(Class316 class316_1)
			{
				return Operators.CompareString(class316_1.string_0, this.class316_0.string_0, false) == 0;
			}

			// Token: 0x040014A2 RID: 5282
			public Class316 class316_0;
		}

		// Token: 0x0200031A RID: 794
		[CompilerGenerated]
		internal sealed class Class307
		{
			// Token: 0x06001779 RID: 6009 RVA: 0x0000C508 File Offset: 0x0000A708
			public Class307(Scenario.Class307 class307_0)
			{
				if (class307_0 != null)
				{
					this.explosion_0 = class307_0.explosion_0;
				}
			}

			// Token: 0x0600177A RID: 6010 RVA: 0x0000C51F File Offset: 0x0000A71F
			internal bool method_0(Explosion explosion_1)
			{
				return Operators.CompareString(explosion_1.string_0, this.explosion_0.string_0, false) == 0;
			}

			// Token: 0x040014A3 RID: 5283
			public Explosion explosion_0;
		}

		// Token: 0x0200031B RID: 795
		[CompilerGenerated]
		internal sealed class Class308
		{
			// Token: 0x0600177B RID: 6011 RVA: 0x0000C53B File Offset: 0x0000A73B
			public Class308(Scenario.Class308 class308_0)
			{
				if (class308_0 != null)
				{
					this.weaponImpact_0 = class308_0.weaponImpact_0;
				}
			}

			// Token: 0x0600177C RID: 6012 RVA: 0x0000C552 File Offset: 0x0000A752
			internal bool method_0(WeaponImpact weaponImpact_1)
			{
				return Operators.CompareString(weaponImpact_1.string_0, this.weaponImpact_0.string_0, false) == 0;
			}

			// Token: 0x040014A4 RID: 5284
			public WeaponImpact weaponImpact_0;
		}

		// Token: 0x0200031C RID: 796
		[CompilerGenerated]
		internal sealed class Class309
		{
			// Token: 0x0600177D RID: 6013 RVA: 0x0000C56E File Offset: 0x0000A76E
			public Class309(Scenario.Class309 class309_0)
			{
				if (class309_0 != null)
				{
					this.chaffCorridorCloud_0 = class309_0.chaffCorridorCloud_0;
				}
			}

			// Token: 0x0600177E RID: 6014 RVA: 0x0000C585 File Offset: 0x0000A785
			internal bool method_0(ChaffCorridorCloud chaffCorridorCloud_1)
			{
				return Operators.CompareString(chaffCorridorCloud_1.string_0, this.chaffCorridorCloud_0.string_0, false) == 0;
			}

			// Token: 0x040014A5 RID: 5285
			public ChaffCorridorCloud chaffCorridorCloud_0;
		}
	}
}
