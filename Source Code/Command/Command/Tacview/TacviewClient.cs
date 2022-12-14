using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns14;
using ns5;

namespace Command.Tacview
{
	// Token: 0x02000D6A RID: 3434
	public sealed class TacviewClient
	{
		// Token: 0x06005A10 RID: 23056 RVA: 0x00316E4C File Offset: 0x0031504C
		public static string smethod_0(Scenario scenario_0)
		{
			string result;
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("FileType=text/acmi/tacview").Append("\r\n");
				stringBuilder.Append("FileVersion=2.2").Append("\r\n");
				stringBuilder.Append("0,ReferenceTime=" + scenario_0.ZeroHour.ToString("yyyy-MM-ddThh:mm:ss")).Append("Z").Append("\r\n");
				result = stringBuilder.ToString();
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x00316EF4 File Offset: 0x003150F4
		public static string smethod_1(Scenario scenario_0)
		{
			string result;
			try
			{
				try
				{
					foreach (KeyValuePair<string, ActiveUnit> keyValuePair in scenario_0.vmethod_0())
					{
						if (!keyValuePair.Value.bool_1 && keyValuePair.Value.vmethod_127())
						{
							keyValuePair.Value.vmethod_87().method_16(true);
						}
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
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x00316F94 File Offset: 0x00315194
		public void method_0()
		{
			try
			{
				this.process_1.Kill();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.process_0.Kill();
			}
			catch (Exception ex2)
			{
			}
			try
			{
				this.anonymousPipeServerStream_1.Close();
			}
			catch (Exception ex3)
			{
			}
			try
			{
				this.anonymousPipeServerStream_0.Close();
			}
			catch (Exception ex4)
			{
			}
			try
			{
				this.anonymousPipeServerStream_3.Close();
			}
			catch (Exception ex5)
			{
			}
			try
			{
				this.anonymousPipeServerStream_2.Close();
			}
			catch (Exception ex6)
			{
			}
			TacviewServer.smethod_0().method_6(this);
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x003170A0 File Offset: 0x003152A0
		private TacviewClient()
		{
			this.bool_1 = false;
			this.bool_2 = false;
			this.hashSet_0 = new HashSet<string>();
			this.concurrentQueue_0 = new ConcurrentQueue<List<Tuple<string, IEventExporter.EventExportNotification>>>();
			this.anonymousPipeServerStream_0 = new AnonymousPipeServerStream(PipeDirection.In, 1);
			this.anonymousPipeServerStream_1 = new AnonymousPipeServerStream(PipeDirection.Out, 1);
			this.anonymousPipeServerStream_2 = new AnonymousPipeServerStream(PipeDirection.In, 1);
			this.anonymousPipeServerStream_3 = new AnonymousPipeServerStream(PipeDirection.Out, 1);
			this.streamWriter_0 = new StreamWriter(this.anonymousPipeServerStream_1);
			this.streamWriter_1 = new StreamWriter(this.anonymousPipeServerStream_3);
		}

		// Token: 0x06005A14 RID: 23060 RVA: 0x00317130 File Offset: 0x00315330
		public void method_1()
		{
			try
			{
				Struct77 @struct;
				TacviewClient.GetWindowRect(this.process_0.MainWindowHandle, ref @struct);
				this.int_1 = @struct.int_2 - @struct.int_0 + 1;
				this.int_0 = @struct.int_3 - @struct.int_1 + 1;
				this.streamWriter_1.Write(string.Concat(new string[]
				{
					"Tacview.UI.SetWindowPosition(0, 0, ",
					Conversions.ToString(this.int_1),
					", ",
					Conversions.ToString(this.int_0),
					")\0"
				}));
				this.streamWriter_1.Flush();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005A15 RID: 23061
		[DllImport("user32.dll")]
		private static extern bool GetWindowRect(IntPtr intptr_0, ref Struct77 struct77_0);

		// Token: 0x06005A16 RID: 23062 RVA: 0x003171F0 File Offset: 0x003153F0
		public static TacviewClient smethod_2()
		{
			Enumerable.FirstOrDefault<IEventExporter>(Enumerable.Where<IEventExporter>(Class428.ieventExporter_0, (TacviewClient._Closure$__.$I10-0 == null) ? (TacviewClient._Closure$__.$I10-0 = new Func<IEventExporter, bool>(TacviewClient._Closure$__.$I.method_0)) : TacviewClient._Closure$__.$I10-0)).imethod_9(true);
			object object_ = TacviewServer.object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(object_);
			lock (object_)
			{
				TacviewClient tacviewClient = new TacviewClient();
				TacviewServer.smethod_0().method_4(tacviewClient);
				tacviewClient.string_0 = "tvc-" + Guid.NewGuid().ToString().Substring(0, 4);
				tacviewClient.string_1 = Client.smethod_46().method_54().string_0;
				tacviewClient.bool_3 = Client.smethod_52().method_1();
				tacviewClient.process_0 = TacviewServer.smethod_3("CommandTacviewManager.exe", "", IntPtr.Zero);
				while (tacviewClient.process_0.MainWindowHandle == IntPtr.Zero)
				{
					Thread.Sleep(10);
				}
				Struct77 @struct;
				TacviewClient.GetWindowRect(tacviewClient.process_0.MainWindowHandle, ref @struct);
				tacviewClient.int_1 = @struct.int_2 - @struct.int_0 + 1;
				tacviewClient.int_0 = @struct.int_3 - @struct.int_1 + 1;
				string text = Conversions.ToInteger(tacviewClient.anonymousPipeServerStream_1.GetClientHandleAsString()).ToString("X");
				string text2 = Conversions.ToInteger(tacviewClient.anonymousPipeServerStream_0.GetClientHandleAsString()).ToString("X");
				string text3 = Conversions.ToInteger(tacviewClient.anonymousPipeServerStream_3.GetClientHandleAsString()).ToString("X");
				string text4 = Conversions.ToInteger(tacviewClient.anonymousPipeServerStream_2.GetClientHandleAsString()).ToString("X");
				string text5 = string.Concat(new string[]
				{
					"/RealTimeTelemetryPipe:",
					text,
					":",
					text2,
					" /LuaPipe:",
					text3,
					":",
					text4,
					" /ReadOnly:true /ResourceFolder:\"",
					GameGeneral.string_12,
					"\\Tacview\\\""
				});
				tacviewClient.process_1 = TacviewServer.smethod_3(Class570.class280_0.method_62(), text5, tacviewClient.process_0.MainWindowHandle);
				tacviewClient.anonymousPipeServerStream_0.DisposeLocalCopyOfClientHandle();
				tacviewClient.anonymousPipeServerStream_1.DisposeLocalCopyOfClientHandle();
				tacviewClient.anonymousPipeServerStream_2.DisposeLocalCopyOfClientHandle();
				tacviewClient.anonymousPipeServerStream_3.DisposeLocalCopyOfClientHandle();
				string text6 = string.Empty;
				text6 += "XtraLib.Stream.0\n";
				text6 += "Tacview.RealTimeTelemetry.0\n";
				text6 += "CMANO host\n\0";
				tacviewClient.streamWriter_0.Write(text6);
				tacviewClient.streamWriter_0.Flush();
				string text7 = string.Empty;
				text7 += "XtraLib.Stream.0\n";
				text7 += "Tacview.Lua.0\n";
				text7 += "CMANO host\n\0";
				tacviewClient.streamWriter_1.Write(text7);
				tacviewClient.streamWriter_1.Write("Tacview = require('Tacview180')\0");
				tacviewClient.streamWriter_1.Write("Tacview.UI.SetWindowParent(" + Conversions.ToString((int)tacviewClient.process_0.MainWindowHandle) + ")\0");
				tacviewClient.streamWriter_1.Write("Tacview.UI.EnterReadMode(true)\0");
				tacviewClient.streamWriter_1.Write("Tacview.Settings.SetBoolean(\"UI.View.Overlay.Visible\", false)\0");
				tacviewClient.streamWriter_1.Write("Tacview.Settings.SetBoolean(\"UI.View.Grid.Visible\", false)\0");
				tacviewClient.streamWriter_1.Write("Tacview.Settings.SetString(\"UI.View.Camera.Mode\", \"External\")\0");
				tacviewClient.streamWriter_1.Write(string.Concat(new string[]
				{
					"Tacview.UI.SetWindowPosition(0, 0, ",
					Conversions.ToString(tacviewClient.int_1),
					", ",
					Conversions.ToString(tacviewClient.int_0),
					")\0"
				}));
				tacviewClient.streamWriter_1.Flush();
				tacviewClient.thread_0 = new Thread(new ThreadStart(tacviewClient.method_4));
				tacviewClient.thread_0.Name = tacviewClient.string_0 + " Thread";
				tacviewClient.thread_0.Priority = ThreadPriority.Normal;
				tacviewClient.thread_0.Start();
				tacviewClient.method_2(TacviewClient.smethod_0(Client.smethod_46()));
				TacviewClient.smethod_1(Client.smethod_46());
			}
			TacviewClient result;
			return result;
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x0031763C File Offset: 0x0031583C
		private void method_2(string string_2)
		{
			try
			{
				if (this.anonymousPipeServerStream_1.IsConnected)
				{
					this.streamWriter_0.Write(string_2 + "\r\n");
					this.streamWriter_0.Flush();
				}
				else if (!this.bool_1)
				{
					Interaction.MsgBox("Tacview has disconnected from Command.", MsgBoxStyle.OkOnly, null);
					this.bool_1 = true;
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

		// Token: 0x06005A18 RID: 23064 RVA: 0x003176C4 File Offset: 0x003158C4
		private void method_3(string string_2)
		{
			try
			{
				if (this.anonymousPipeServerStream_3.IsConnected)
				{
					this.streamWriter_1.Write(string_2 + "\0");
					this.streamWriter_1.Flush();
				}
				else if (!this.bool_1)
				{
					Interaction.MsgBox("Tacview has disconnected from Command.", MsgBoxStyle.OkOnly, null);
					this.bool_1 = true;
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

		// Token: 0x06005A19 RID: 23065 RVA: 0x0031774C File Offset: 0x0031594C
		public void method_4()
		{
			int num = 1;
			for (;;)
			{
				num++;
				this.method_5();
				Thread.Sleep(50);
				if (num % 20 == 0)
				{
					num = 1;
					try
					{
						this.method_1();
					}
					catch (Exception ex)
					{
					}
					if (this.process_0.HasExited)
					{
						break;
					}
				}
			}
			this.method_0();
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x003177B0 File Offset: 0x003159B0
		private void method_5()
		{
			try
			{
				List<Tuple<string, IEventExporter.EventExportNotification>> list = new List<Tuple<string, IEventExporter.EventExportNotification>>(this.concurrentQueue_0.Count * 2);
				while (this.concurrentQueue_0.Count > 0)
				{
					this.concurrentQueue_0.TryDequeue(out list);
					try
					{
						foreach (Tuple<string, IEventExporter.EventExportNotification> tuple_ in list)
						{
							this.method_8(tuple_);
						}
					}
					finally
					{
						List<Tuple<string, IEventExporter.EventExportNotification>>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (!this.bool_2 && Client.smethod_54() != null)
				{
					this.method_6(Client.smethod_54().string_0, 0);
					this.bool_2 = true;
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

		// Token: 0x06005A1B RID: 23067 RVA: 0x00317880 File Offset: 0x00315A80
		public void method_6(string UnitObjectID, int CameraDistance_meters = 0)
		{
			try
			{
				if (TacviewServer.class425_0.dictionary_5.Count != 0)
				{
					long value;
					if (TacviewServer.class425_0.dictionary_5.TryGetValue(UnitObjectID, out value))
					{
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.Append("local objectHandle = Tacview.Telemetry.GetCurrentObjectHandle(0x").Append(value).Append(")").Append("\r\n");
						stringBuilder.Append("Tacview.Context.SetSelectedObject(0, objectHandle)").Append("\r\n");
						stringBuilder.Append("Tacview.Settings.SetString(\"UI.View.Camera.Mode\", \"External\")").Append("\r\n");
						if (CameraDistance_meters != 0)
						{
							stringBuilder.Append("Tacview.Context.Camera.SetRangeToTarget( ").Append(CameraDistance_meters).Append(" )").Append("\r\n");
						}
						string string_ = stringBuilder.ToString();
						this.method_3(string_);
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

		// Token: 0x06005A1C RID: 23068 RVA: 0x00317978 File Offset: 0x00315B78
		public void method_7(string string_2, string string_3)
		{
			try
			{
				if (TacviewServer.class425_0.dictionary_5.Count != 0)
				{
					long value;
					if (TacviewServer.class425_0.dictionary_5.TryGetValue(string_2, out value))
					{
						long value2;
						if (TacviewServer.class425_0.dictionary_5.TryGetValue(string_3, out value2))
						{
							StringBuilder stringBuilder = new StringBuilder();
							stringBuilder.Append("local objectHandle = Tacview.Telemetry.GetCurrentObjectHandle(0x").Append(value).Append(")").Append("\r\n");
							stringBuilder.Append("Tacview.Context.SetSelectedObject(0, objectHandle)").Append("\r\n");
							stringBuilder.Append("local objectHandle = Tacview.Telemetry.GetCurrentObjectHandle(0x").Append(value2).Append(")").Append("\r\n");
							stringBuilder.Append("Tacview.Context.SetSelectedObject(1, objectHandle)").Append("\r\n");
							stringBuilder.Append("Tacview.Settings.SetString(\"UI.View.Camera.Mode\", \"External\")").Append("\r\n");
							stringBuilder.Append("Tacview.Settings.SetString(\"UI.View.Camera.Dogfight.Mode\", \"LookAt\")").Append("\r\n");
							stringBuilder.Append("Tacview.Settings.SetBoolean(\"UI.View.Camera.Dogfight.Enabled\", true)").Append("\r\n");
							stringBuilder.Append("local roll = 10").Append("\r\n");
							stringBuilder.Append("local pitch = 10").Append("\r\n");
							stringBuilder.Append("local yaw = 45").Append("\r\n");
							stringBuilder.Append("Tacview.Context.Camera.SetRotation( math.rad(roll) , math.rad(pitch) , math.rad(yaw) )").Append("\r\n");
							string string_4 = stringBuilder.ToString();
							this.method_3(string_4);
						}
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

		// Token: 0x06005A1D RID: 23069 RVA: 0x00317B2C File Offset: 0x00315D2C
		private void method_8(Tuple<string, IEventExporter.EventExportNotification> tuple_0)
		{
			try
			{
				string text;
				switch (tuple_0.Item2.EventType)
				{
				case IEventExporter.ExportedEventType.WeaponFired:
					text = Conversions.ToString(tuple_0.Item2.EventParameters["WeaponID"].Value);
					goto IL_1A4;
				case IEventExporter.ExportedEventType.WeaponEndgame:
					text = Conversions.ToString(tuple_0.Item2.EventParameters["WeaponID"].Value);
					goto IL_1A4;
				case IEventExporter.ExportedEventType.UnitDestroyed:
					text = Conversions.ToString(tuple_0.Item2.EventParameters["UnitID"].Value);
					goto IL_1A4;
				case IEventExporter.ExportedEventType.UnitPositions:
					text = Conversions.ToString(tuple_0.Item2.EventParameters["UnitID"].Value);
					goto IL_1A4;
				case IEventExporter.ExportedEventType.WeaponImpact:
					text = Conversions.ToString(tuple_0.Item2.EventParameters["UnitID"].Value);
					goto IL_1A4;
				case IEventExporter.ExportedEventType.Explosion:
					text = Conversions.ToString(tuple_0.Item2.EventParameters["ExplosionID"].Value);
					goto IL_1A4;
				case IEventExporter.ExportedEventType.AirOps:
					text = Conversions.ToString(tuple_0.Item2.EventParameters["UnitID"].Value);
					goto IL_1A4;
				case IEventExporter.ExportedEventType.DockingOps:
					text = Conversions.ToString(tuple_0.Item2.EventParameters["UnitID"].Value);
					goto IL_1A4;
				case IEventExporter.ExportedEventType.WaterSplash:
					text = Conversions.ToString(tuple_0.Item2.EventParameters["UnitID"].Value);
					goto IL_1A4;
				}
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				IL_1A4:
				ActiveUnit activeUnit = tuple_0.Item2.ParentScen.vmethod_0()[text];
				if (!this.hashSet_0.Contains(text))
				{
					this.hashSet_0.Add(text);
					if (TacviewServer.class425_0.dictionary_4.ContainsKey(text))
					{
						this.method_2(TacviewServer.class425_0.dictionary_4[text]);
					}
				}
				this.method_2(tuple_0.Item1);
			}
			catch (Exception ex)
			{
				this.method_2(tuple_0.Item1);
			}
		}

		// Token: 0x06005A1E RID: 23070 RVA: 0x0003A411 File Offset: 0x00038611
		public override string ToString()
		{
			return this.string_0;
		}

		// Token: 0x04003473 RID: 13427
		public int int_0;

		// Token: 0x04003474 RID: 13428
		public int int_1;

		// Token: 0x04003475 RID: 13429
		internal bool bool_0;

		// Token: 0x04003476 RID: 13430
		public string string_0;

		// Token: 0x04003477 RID: 13431
		private bool bool_1;

		// Token: 0x04003478 RID: 13432
		private bool bool_2;

		// Token: 0x04003479 RID: 13433
		public HashSet<string> hashSet_0;

		// Token: 0x0400347A RID: 13434
		public Thread thread_0;

		// Token: 0x0400347B RID: 13435
		public Process process_0;

		// Token: 0x0400347C RID: 13436
		public ConcurrentQueue<List<Tuple<string, IEventExporter.EventExportNotification>>> concurrentQueue_0;

		// Token: 0x0400347D RID: 13437
		public string string_1;

		// Token: 0x0400347E RID: 13438
		public bool bool_3;

		// Token: 0x0400347F RID: 13439
		public Process process_1;

		// Token: 0x04003480 RID: 13440
		public AnonymousPipeServerStream anonymousPipeServerStream_0;

		// Token: 0x04003481 RID: 13441
		public AnonymousPipeServerStream anonymousPipeServerStream_1;

		// Token: 0x04003482 RID: 13442
		public AnonymousPipeServerStream anonymousPipeServerStream_2;

		// Token: 0x04003483 RID: 13443
		public AnonymousPipeServerStream anonymousPipeServerStream_3;

		// Token: 0x04003484 RID: 13444
		public StreamWriter streamWriter_0;

		// Token: 0x04003485 RID: 13445
		public StreamWriter streamWriter_1;
	}
}
