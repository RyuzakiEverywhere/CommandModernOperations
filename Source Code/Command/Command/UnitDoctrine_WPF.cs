using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns7;

namespace Command
{
	// Token: 0x02000D7F RID: 3455
	[DesignerGenerated]
	public sealed class UnitDoctrine_WPF : System.Windows.Controls.UserControl, IComponentConnector
	{
		// Token: 0x06005BB9 RID: 23481 RVA: 0x0003AFFA File Offset: 0x000391FA
		public UnitDoctrine_WPF()
		{
			this.method_2(true);
			this.InitializeComponent();
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x0032A548 File Offset: 0x00328748
		private void method_0()
		{
			this.list_0 = new List<SpecificDoctrineViewModel>();
			this.list_0.Add(new SpecificDoctrineViewModel("Nuclear Wpn", "Strategic", (UnitDoctrine_WPF._Closure$__.$I1-0 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-0 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_0)) : UnitDoctrine_WPF._Closure$__.$I1-0, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_4), (UnitDoctrine_WPF._Closure$__.$I1-2 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-2 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_1)) : UnitDoctrine_WPF._Closure$__.$I1-2));
			this.list_0.Add(new SpecificDoctrineViewModel("WCS, Air", "ROE", (UnitDoctrine_WPF._Closure$__.$I1-3 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-3 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_2)) : UnitDoctrine_WPF._Closure$__.$I1-3, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_5), (UnitDoctrine_WPF._Closure$__.$I1-5 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-5 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_3)) : UnitDoctrine_WPF._Closure$__.$I1-5));
			this.list_0.Add(new SpecificDoctrineViewModel("WCS, Surface", "ROE", (UnitDoctrine_WPF._Closure$__.$I1-6 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-6 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_4)) : UnitDoctrine_WPF._Closure$__.$I1-6, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_6), (UnitDoctrine_WPF._Closure$__.$I1-8 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-8 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_5)) : UnitDoctrine_WPF._Closure$__.$I1-8));
			this.list_0.Add(new SpecificDoctrineViewModel("WCS, Sub-surface", "ROE", (UnitDoctrine_WPF._Closure$__.$I1-9 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-9 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_6)) : UnitDoctrine_WPF._Closure$__.$I1-9, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_7), (UnitDoctrine_WPF._Closure$__.$I1-11 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-11 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_7)) : UnitDoctrine_WPF._Closure$__.$I1-11));
			this.list_0.Add(new SpecificDoctrineViewModel("WCS, Land", "ROE", (UnitDoctrine_WPF._Closure$__.$I1-12 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-12 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_8)) : UnitDoctrine_WPF._Closure$__.$I1-12, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_8), (UnitDoctrine_WPF._Closure$__.$I1-14 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-14 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_9)) : UnitDoctrine_WPF._Closure$__.$I1-14));
			this.list_0.Add(new SpecificDoctrineViewModel("Ignore Plotted Course", "ROE", (UnitDoctrine_WPF._Closure$__.$I1-15 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-15 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_10)) : UnitDoctrine_WPF._Closure$__.$I1-15, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_9), (UnitDoctrine_WPF._Closure$__.$I1-17 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-17 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_11)) : UnitDoctrine_WPF._Closure$__.$I1-17));
			this.list_0.Add(new SpecificDoctrineViewModel("Engage Ambigous", "ROE", (UnitDoctrine_WPF._Closure$__.$I1-18 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-18 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_12)) : UnitDoctrine_WPF._Closure$__.$I1-18, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_10), (UnitDoctrine_WPF._Closure$__.$I1-20 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-20 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_13)) : UnitDoctrine_WPF._Closure$__.$I1-20));
			this.list_0.Add(new SpecificDoctrineViewModel("Engage Opportunities", "ROE", (UnitDoctrine_WPF._Closure$__.$I1-21 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-21 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_14)) : UnitDoctrine_WPF._Closure$__.$I1-21, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_11), (UnitDoctrine_WPF._Closure$__.$I1-23 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-23 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_15)) : UnitDoctrine_WPF._Closure$__.$I1-23));
			this.list_0.Add(new SpecificDoctrineViewModel("Ignore Under Attack", "EMCON", (UnitDoctrine_WPF._Closure$__.$I1-24 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-24 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_16)) : UnitDoctrine_WPF._Closure$__.$I1-24, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_12), (UnitDoctrine_WPF._Closure$__.$I1-26 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-26 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_17)) : UnitDoctrine_WPF._Closure$__.$I1-26));
			this.list_0.Add(new SpecificDoctrineViewModel("Torpedo Range", "Misc", (UnitDoctrine_WPF._Closure$__.$I1-27 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-27 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_18)) : UnitDoctrine_WPF._Closure$__.$I1-27, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_13), (UnitDoctrine_WPF._Closure$__.$I1-29 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-29 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_19)) : UnitDoctrine_WPF._Closure$__.$I1-29));
			this.list_0.Add(new SpecificDoctrineViewModel("Automatic Evasion", "Misc", (UnitDoctrine_WPF._Closure$__.$I1-30 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-30 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_20)) : UnitDoctrine_WPF._Closure$__.$I1-30, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_14), (UnitDoctrine_WPF._Closure$__.$I1-32 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-32 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_21)) : UnitDoctrine_WPF._Closure$__.$I1-32));
			this.list_0.Add(new SpecificDoctrineViewModel("Use Refuel", "Misc", (UnitDoctrine_WPF._Closure$__.$I1-33 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-33 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_22)) : UnitDoctrine_WPF._Closure$__.$I1-33, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_15), (UnitDoctrine_WPF._Closure$__.$I1-35 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-35 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_23)) : UnitDoctrine_WPF._Closure$__.$I1-35));
			this.list_0.Add(new SpecificDoctrineViewModel("Refuel Allies", "Misc", (UnitDoctrine_WPF._Closure$__.$I1-36 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-36 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_24)) : UnitDoctrine_WPF._Closure$__.$I1-36, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_16), (UnitDoctrine_WPF._Closure$__.$I1-38 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-38 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_25)) : UnitDoctrine_WPF._Closure$__.$I1-38));
			this.list_0.Add(new SpecificDoctrineViewModel("Air Ops Tempo", "Air Ops", (UnitDoctrine_WPF._Closure$__.$I1-39 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-39 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_26)) : UnitDoctrine_WPF._Closure$__.$I1-39, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_17), (UnitDoctrine_WPF._Closure$__.$I1-41 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-41 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_27)) : UnitDoctrine_WPF._Closure$__.$I1-41));
			this.list_0.Add(new SpecificDoctrineViewModel("Quick Turnaround", "Air Ops", (UnitDoctrine_WPF._Closure$__.$I1-42 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-42 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_28)) : UnitDoctrine_WPF._Closure$__.$I1-42, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_18), (UnitDoctrine_WPF._Closure$__.$I1-44 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-44 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_29)) : UnitDoctrine_WPF._Closure$__.$I1-44));
			this.list_0.Add(new SpecificDoctrineViewModel("Fuel State", "Air Ops", (UnitDoctrine_WPF._Closure$__.$I1-45 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-45 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_30)) : UnitDoctrine_WPF._Closure$__.$I1-45, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_19), (UnitDoctrine_WPF._Closure$__.$I1-47 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-47 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_31)) : UnitDoctrine_WPF._Closure$__.$I1-47));
			this.list_0.Add(new SpecificDoctrineViewModel("Fuel State RTB", "Air Ops", (UnitDoctrine_WPF._Closure$__.$I1-48 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-48 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_32)) : UnitDoctrine_WPF._Closure$__.$I1-48, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_20), (UnitDoctrine_WPF._Closure$__.$I1-50 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-50 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_33)) : UnitDoctrine_WPF._Closure$__.$I1-50));
			this.list_0.Add(new SpecificDoctrineViewModel("Weapon State", "Air Ops", (UnitDoctrine_WPF._Closure$__.$I1-51 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-51 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_34)) : UnitDoctrine_WPF._Closure$__.$I1-51, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_21), (UnitDoctrine_WPF._Closure$__.$I1-53 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-53 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_35)) : UnitDoctrine_WPF._Closure$__.$I1-53));
			this.list_0.Add(new SpecificDoctrineViewModel("Weapon State RTB", "Air Ops", (UnitDoctrine_WPF._Closure$__.$I1-54 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-54 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_36)) : UnitDoctrine_WPF._Closure$__.$I1-54, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_22), (UnitDoctrine_WPF._Closure$__.$I1-56 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-56 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_37)) : UnitDoctrine_WPF._Closure$__.$I1-56));
			this.list_0.Add(new SpecificDoctrineViewModel("A/G Strafing (gun)", "Air Ops", (UnitDoctrine_WPF._Closure$__.$I1-57 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-57 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_38)) : UnitDoctrine_WPF._Closure$__.$I1-57, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_23), (UnitDoctrine_WPF._Closure$__.$I1-59 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-59 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_39)) : UnitDoctrine_WPF._Closure$__.$I1-59));
			this.list_0.Add(new SpecificDoctrineViewModel("Jettison Ordnance", "Air Ops", (UnitDoctrine_WPF._Closure$__.$I1-60 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-60 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_40)) : UnitDoctrine_WPF._Closure$__.$I1-60, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_24), (UnitDoctrine_WPF._Closure$__.$I1-62 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-62 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_41)) : UnitDoctrine_WPF._Closure$__.$I1-62));
			this.list_0.Add(new SpecificDoctrineViewModel("Anti-Surface SAMs", "ASuW", (UnitDoctrine_WPF._Closure$__.$I1-63 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-63 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_42)) : UnitDoctrine_WPF._Closure$__.$I1-63, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_25), (UnitDoctrine_WPF._Closure$__.$I1-65 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-65 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_43)) : UnitDoctrine_WPF._Closure$__.$I1-65));
			this.list_0.Add(new SpecificDoctrineViewModel("Maintain Standoff", "ASuW", (UnitDoctrine_WPF._Closure$__.$I1-66 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-66 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_44)) : UnitDoctrine_WPF._Closure$__.$I1-66, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_26), (UnitDoctrine_WPF._Closure$__.$I1-68 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-68 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_45)) : UnitDoctrine_WPF._Closure$__.$I1-68));
			this.list_0.Add(new SpecificDoctrineViewModel("Navigation", "ASuW", (UnitDoctrine_WPF._Closure$__.$I1-69 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-69 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_46)) : UnitDoctrine_WPF._Closure$__.$I1-69, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_27), (UnitDoctrine_WPF._Closure$__.$I1-71 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-71 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_47)) : UnitDoctrine_WPF._Closure$__.$I1-71));
			this.list_0.Add(new SpecificDoctrineViewModel("Avoid Contact", "ASW", (UnitDoctrine_WPF._Closure$__.$I1-72 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-72 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_48)) : UnitDoctrine_WPF._Closure$__.$I1-72, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_28), (UnitDoctrine_WPF._Closure$__.$I1-74 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-74 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_49)) : UnitDoctrine_WPF._Closure$__.$I1-74));
			this.list_0.Add(new SpecificDoctrineViewModel("Dive On Threat", "ASW", (UnitDoctrine_WPF._Closure$__.$I1-75 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-75 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_50)) : UnitDoctrine_WPF._Closure$__.$I1-75, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_29), (UnitDoctrine_WPF._Closure$__.$I1-77 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-77 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_51)) : UnitDoctrine_WPF._Closure$__.$I1-77));
			this.list_0.Add(new SpecificDoctrineViewModel("Recharge, Patrol", "ASW", (UnitDoctrine_WPF._Closure$__.$I1-78 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-78 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_52)) : UnitDoctrine_WPF._Closure$__.$I1-78, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_30), (UnitDoctrine_WPF._Closure$__.$I1-80 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-80 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_53)) : UnitDoctrine_WPF._Closure$__.$I1-80));
			this.list_0.Add(new SpecificDoctrineViewModel("Recharge, Attack", "ASW", (UnitDoctrine_WPF._Closure$__.$I1-81 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-81 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_54)) : UnitDoctrine_WPF._Closure$__.$I1-81, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_31), (UnitDoctrine_WPF._Closure$__.$I1-83 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-83 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_55)) : UnitDoctrine_WPF._Closure$__.$I1-83));
			this.list_0.Add(new SpecificDoctrineViewModel("AIP Usage", "ASW", (UnitDoctrine_WPF._Closure$__.$I1-84 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-84 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_56)) : UnitDoctrine_WPF._Closure$__.$I1-84, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_32), (UnitDoctrine_WPF._Closure$__.$I1-86 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-86 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_57)) : UnitDoctrine_WPF._Closure$__.$I1-86));
			this.list_0.Add(new SpecificDoctrineViewModel("Dipping Sonar", "ASW", (UnitDoctrine_WPF._Closure$__.$I1-87 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-87 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_58)) : UnitDoctrine_WPF._Closure$__.$I1-87, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_33), (UnitDoctrine_WPF._Closure$__.$I1-89 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-89 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_59)) : UnitDoctrine_WPF._Closure$__.$I1-89));
			this.list_0.Add(new SpecificDoctrineViewModel("Navigation", "ASW", (UnitDoctrine_WPF._Closure$__.$I1-90 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-90 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_60)) : UnitDoctrine_WPF._Closure$__.$I1-90, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_34), (UnitDoctrine_WPF._Closure$__.$I1-92 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-92 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_61)) : UnitDoctrine_WPF._Closure$__.$I1-92));
			this.list_0.Add(new SpecificDoctrineViewModel("Navigation", "Land", (UnitDoctrine_WPF._Closure$__.$I1-93 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-93 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_62)) : UnitDoctrine_WPF._Closure$__.$I1-93, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_35), (UnitDoctrine_WPF._Closure$__.$I1-95 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-95 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_63)) : UnitDoctrine_WPF._Closure$__.$I1-95));
			this.list_0.Add(new SpecificDoctrineViewModel("Refuel Selection", "Misc", (UnitDoctrine_WPF._Closure$__.$I1-96 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-96 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_64)) : UnitDoctrine_WPF._Closure$__.$I1-96, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_36), (UnitDoctrine_WPF._Closure$__.$I1-98 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-98 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_65)) : UnitDoctrine_WPF._Closure$__.$I1-98));
			this.list_0.Add(new SpecificDoctrineViewModel("BVR Logics", "Air Ops", (UnitDoctrine_WPF._Closure$__.$I1-99 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-99 = new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(UnitDoctrine_WPF._Closure$__.$I.method_66)) : UnitDoctrine_WPF._Closure$__.$I1-99, new Action<Doctrine, System.Windows.Forms.ComboBox, Scenario>(this.method_37), (UnitDoctrine_WPF._Closure$__.$I1-101 == null) ? (UnitDoctrine_WPF._Closure$__.$I1-101 = new Func<Doctrine, Scenario, bool>(UnitDoctrine_WPF._Closure$__.$I.method_67)) : UnitDoctrine_WPF._Closure$__.$I1-101));
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x0003B00F File Offset: 0x0003920F
		[CompilerGenerated]
		public bool method_1()
		{
			return this.bool_0;
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x0003B017 File Offset: 0x00039217
		[CompilerGenerated]
		public void method_2(bool bool_2)
		{
			this.bool_0 = bool_2;
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x0032B3FC File Offset: 0x003295FC
		public void method_3(ActiveUnit activeUnit_0)
		{
			if (this.list_0 == null)
			{
				this.method_0();
			}
			if (activeUnit_0 != null)
			{
				if (!activeUnit_0.vmethod_90().vmethod_1() && !Class2558.smethod_17(activeUnit_0) && !Client.smethod_52().method_1())
				{
					base.Visibility = Visibility.Collapsed;
					return;
				}
				base.Visibility = Visibility.Visible;
			}
			this.method_2(false);
			if (base.DataContext != null)
			{
				DoctrineViewModel doctrineViewModel = (DoctrineViewModel)base.DataContext;
				if (doctrineViewModel.activeUnit_0 == activeUnit_0)
				{
					doctrineViewModel.Refresh();
				}
				else
				{
					base.DataContext = new DoctrineViewModel(activeUnit_0, this.list_0);
				}
			}
			else
			{
				base.DataContext = new DoctrineViewModel(activeUnit_0, this.list_0);
			}
			this.method_2(true);
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x0032B4A4 File Offset: 0x003296A4
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			DoctrineViewModel doctrineViewModel = (DoctrineViewModel)base.DataContext;
			if (doctrineViewModel != null && doctrineViewModel.activeUnit_0 != null)
			{
				new DoctrineForm
				{
					class310_0 = doctrineViewModel.activeUnit_0
				}.Show();
			}
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x0032B4E0 File Offset: 0x003296E0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_1)
			{
				this.bool_1 = true;
				Uri resourceLocator = new Uri("/Command;component/customcontrols/rightcolumn/unitdoctrine_wpf.xaml", UriKind.Relative);
				System.Windows.Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x0003B020 File Offset: 0x00039220
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			}
			this.bool_1 = true;
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x0032B510 File Offset: 0x00329710
		[CompilerGenerated]
		private void method_4(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_284(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x0032B534 File Offset: 0x00329734
		[CompilerGenerated]
		private void method_5(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_286(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BC3 RID: 23491 RVA: 0x0032B558 File Offset: 0x00329758
		[CompilerGenerated]
		private void method_6(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_288(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BC4 RID: 23492 RVA: 0x0032B57C File Offset: 0x0032977C
		[CompilerGenerated]
		private void method_7(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_290(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BC5 RID: 23493 RVA: 0x0032B5A0 File Offset: 0x003297A0
		[CompilerGenerated]
		private void method_8(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_292(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x0032B5C4 File Offset: 0x003297C4
		[CompilerGenerated]
		private void method_9(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_294(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x0032B5E8 File Offset: 0x003297E8
		[CompilerGenerated]
		private void method_10(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_304(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x0032B60C File Offset: 0x0032980C
		[CompilerGenerated]
		private void method_11(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_322(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x0032B630 File Offset: 0x00329830
		[CompilerGenerated]
		private void method_12(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_326(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x0032B654 File Offset: 0x00329854
		[CompilerGenerated]
		private void method_13(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_336(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x0032B678 File Offset: 0x00329878
		[CompilerGenerated]
		private void method_14(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_306(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x0032B69C File Offset: 0x0032989C
		[CompilerGenerated]
		private void method_15(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int selectedIndex = comboBox_0.SelectedIndex;
				int num = 0;
				doctrine_0.method_318(selectedIndex, ref scenario_0, ref num, false, true, false);
			}
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x0032B6C8 File Offset: 0x003298C8
		[CompilerGenerated]
		private void method_16(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_344(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BCE RID: 23502 RVA: 0x0032B6EC File Offset: 0x003298EC
		[CompilerGenerated]
		private void method_17(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				bool flag = true;
				doctrine_0.method_330(comboBox_0, ref scenario_0, ref num, ref flag, false, true);
			}
		}

		// Token: 0x06005BCF RID: 23503 RVA: 0x0032B714 File Offset: 0x00329914
		[CompilerGenerated]
		private void method_18(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				bool flag = true;
				doctrine_0.method_328(comboBox_0, ref scenario_0, ref num, ref flag, false, true);
			}
		}

		// Token: 0x06005BD0 RID: 23504 RVA: 0x0032B73C File Offset: 0x0032993C
		[CompilerGenerated]
		private void method_19(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				bool flag = false;
				bool flag2 = true;
				doctrine_0.method_332(comboBox_0, ref scenario_0, ref num, ref flag, ref flag2, false, true);
			}
		}

		// Token: 0x06005BD1 RID: 23505 RVA: 0x0032B768 File Offset: 0x00329968
		[CompilerGenerated]
		private void method_20(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_298(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BD2 RID: 23506 RVA: 0x0032B78C File Offset: 0x0032998C
		[CompilerGenerated]
		private void method_21(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				bool flag = true;
				doctrine_0.method_334(comboBox_0, ref scenario_0, ref num, ref flag, false, true);
			}
		}

		// Token: 0x06005BD3 RID: 23507 RVA: 0x0032B7B4 File Offset: 0x003299B4
		[CompilerGenerated]
		private void method_22(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_296(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x0032B7D8 File Offset: 0x003299D8
		[CompilerGenerated]
		private void method_23(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_316(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x0032B7FC File Offset: 0x003299FC
		[CompilerGenerated]
		private void method_24(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_300(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x0032B820 File Offset: 0x00329A20
		[CompilerGenerated]
		private void method_25(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_324(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x0032B844 File Offset: 0x00329A44
		[CompilerGenerated]
		private void method_26(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_308(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x0032B868 File Offset: 0x00329A68
		[CompilerGenerated]
		private void method_27(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_310(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x0032B88C File Offset: 0x00329A8C
		[CompilerGenerated]
		private void method_28(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_346(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x0032B8B0 File Offset: 0x00329AB0
		[CompilerGenerated]
		private void method_29(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_348(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x0032B8D4 File Offset: 0x00329AD4
		[CompilerGenerated]
		private void method_30(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_350(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x0032B8F8 File Offset: 0x00329AF8
		[CompilerGenerated]
		private void method_31(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_352(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x0032B91C File Offset: 0x00329B1C
		[CompilerGenerated]
		private void method_32(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_354(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BDE RID: 23518 RVA: 0x0032B940 File Offset: 0x00329B40
		[CompilerGenerated]
		private void method_33(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_356(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BDF RID: 23519 RVA: 0x0032B964 File Offset: 0x00329B64
		[CompilerGenerated]
		private void method_34(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_312(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BE0 RID: 23520 RVA: 0x0032B988 File Offset: 0x00329B88
		[CompilerGenerated]
		private void method_35(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_314(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x06005BE1 RID: 23521 RVA: 0x0032B9AC File Offset: 0x00329BAC
		[CompilerGenerated]
		private void method_36(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int selectedIndex = comboBox_0.SelectedIndex;
				int num = 0;
				doctrine_0.method_320(selectedIndex, ref scenario_0, ref num, false, true, false);
			}
		}

		// Token: 0x06005BE2 RID: 23522 RVA: 0x0032B9D8 File Offset: 0x00329BD8
		[CompilerGenerated]
		private void method_37(Doctrine doctrine_0, System.Windows.Forms.ComboBox comboBox_0, Scenario scenario_0)
		{
			if (this.method_1())
			{
				int num = 0;
				doctrine_0.method_302(comboBox_0, ref scenario_0, ref num, false, true);
			}
		}

		// Token: 0x0400357C RID: 13692
		public List<SpecificDoctrineViewModel> list_0;

		// Token: 0x0400357D RID: 13693
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400357E RID: 13694
		private bool bool_1;
	}
}
