using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using Command;
using Command.Tacview;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns14;
using ns3;
using ns4;
using ns7;

namespace ns5
{
	// Token: 0x02000D5D RID: 3421
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Form3 : WindowsFormsApplicationBase
	{
		// Token: 0x06005990 RID: 22928 RVA: 0x00039A48 File Offset: 0x00037C48
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[STAThread]
		[MethodImpl(MethodImplOptions.NoOptimization)]
		internal static void Main(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(false);
			Class2413.smethod_1().Run(args);
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x0000378C File Offset: 0x0000198C
		private void Form3_NetworkAvailabilityChanged(object sender, NetworkAvailableEventArgs e)
		{
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x00003024 File Offset: 0x00001224
		protected static bool smethod_0()
		{
			return false;
		}

		// Token: 0x06005993 RID: 22931 RVA: 0x00315E1C File Offset: 0x0031401C
		private void Form3_Shutdown(object sender, EventArgs e)
		{
			if (base.MainForm != null)
			{
				base.MainForm.Visible = false;
			}
			Client.smethod_66();
			Class570.smethod_2(Class2566.dictionary_0, Client.list_1);
			Terrain.smethod_1();
			Class2474.smethod_0();
			if (Class2473.smethod_2())
			{
				Class2473.smethod_1();
			}
			if (!Information.IsNothing(Client.struct15_0) && Client.struct15_0.method_3() > 0)
			{
				Class83.smethod_0(Client.struct15_0);
			}
			try
			{
				foreach (TacviewClient tacviewClient_ in Enumerable.ToList<TacviewClient>(TacviewServer.smethod_0()))
				{
					Form3.Class2411 @class = new Form3.Class2411(@class);
					@class.tacviewClient_0 = tacviewClient_;
					try
					{
						Task.Factory.StartNew(new Action(@class.method_0));
					}
					catch (Exception ex)
					{
					}
				}
			}
			finally
			{
				List<TacviewClient>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			Thread.Sleep(1000);
			Environment.Exit(0);
		}

		// Token: 0x06005994 RID: 22932 RVA: 0x00315F24 File Offset: 0x00314124
		private void Form3_Startup(object sender, StartupEventArgs e)
		{
			if (!Directory.Exists(Path.Combine(GameGeneral.string_8, "LandCover")))
			{
				DarkMessageBox.smethod_2("Land-cover map files not found! Aborting...", "Error", Enum11.const_0);
				Environment.Exit(0);
			}
			try
			{
				Client.dispatcher_0 = Dispatcher.CurrentDispatcher;
				Class2413.smethod_1().DoEvents();
				StartGameMenuWindow.smethod_1();
				Class2413.smethod_1().DoEvents();
			}
			catch (Exception ex)
			{
			}
			try
			{
				try
				{
					if (!Directory.Exists(GameGeneral.string_11))
					{
						Directory.CreateDirectory(GameGeneral.string_11);
					}
				}
				catch (Exception ex2)
				{
					DarkMessageBox.smethod_2("Error found during alpha1 application startup. Error details: " + ex2.Message, Conversions.ToString(0), (Enum11)Conversions.ToInteger("Error in Application_Startup!"));
					throw ex2;
				}
				try
				{
				}
				catch (Exception ex3)
				{
					DarkMessageBox.smethod_2("Error found during alpha2 application startup. Error details: " + ex3.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex3;
				}
				try
				{
					if (!(GameGeneral.smethod_6() | GameGeneral.smethod_7() | GameGeneral.smethod_8() | GameGeneral.smethod_9()))
					{
						Client.smethod_39(Class2413.smethod_1().Info.DirectoryPath.Contains("steamapps\\common"));
						if (File.Exists(Class2413.smethod_1().Info.DirectoryPath + "\\force_steam"))
						{
							Client.smethod_39(true);
						}
					}
				}
				catch (Exception ex4)
				{
					DarkMessageBox.smethod_2("Error found during alpha3 application startup. Error details: " + ex4.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex4;
				}
				try
				{
					if (Client.smethod_38())
					{
						Class2474.smethod_1();
						if (!Class2474.bool_0)
						{
							DarkMessageBox.smethod_2("It appears you are running Command in Steam mode, but the Steam client does not appear to be running. Please ensure the Steam client is running before starting Command. The game will now exit.", "Steam client not running!", Enum11.const_0);
							Environment.Exit(0);
						}
					}
					else
					{
						Thread.Sleep(2000);
					}
				}
				catch (Exception ex5)
				{
					DarkMessageBox.smethod_2("Error found during alpha4 application startup. Error details: " + ex5.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex5;
				}
				try
				{
					if (!Directory.Exists(GameGeneral.string_5))
					{
						Directory.CreateDirectory(GameGeneral.string_5);
					}
				}
				catch (Exception ex6)
				{
					DarkMessageBox.smethod_2("Error found during alpha5 application startup. Error details: " + ex6.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex6;
				}
				try
				{
					Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
				}
				catch (Exception ex7)
				{
					ex7.Data.Add("Error at 200358", ex7.Message);
					GameGeneral.smethod_25(ref ex7);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				try
				{
					if (Class570.class280_0 == null)
					{
						Dictionary<string, Tuple<int, int, int, int>> dictionary = null;
						Class570.smethod_0(ref dictionary, ref Client.list_1);
						if (Class570.class280_0.method_50())
						{
							string text = "Successfully loaded Sim Configuration.";
							GameGeneral.smethod_26(ref text);
						}
					}
				}
				catch (Exception ex8)
				{
					DarkMessageBox.smethod_2("Error found during beta application startup. Error details: " + ex8.Message, Conversions.ToString(0), (Enum11)Conversions.ToInteger("Error in Application_Startup!"));
					Class570.smethod_1();
					Dictionary<string, Tuple<int, int, int, int>> dictionary = null;
					Class570.smethod_0(ref dictionary, ref Client.list_1);
				}
				try
				{
					if (GameGeneral.smethod_6() || GameGeneral.smethod_7() || GameGeneral.smethod_8() || GameGeneral.smethod_9())
					{
						Class2472.smethod_0();
					}
				}
				catch (Exception ex9)
				{
					DarkMessageBox.smethod_2("Error found during beta2 application startup. Error details: " + ex9.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex9;
				}
				try
				{
					if (GameGeneral.smethod_3() != GameGeneral.Enum144.const_5 && GameGeneral.smethod_3() != GameGeneral.Enum144.const_0 && !Class2472.hashSet_0.Contains(Class2472.Enum202.const_7))
					{
						InternetConnectivityCheck.smethod_0(false);
						if (!InternetConnectivityCheck.bool_0)
						{
							DarkMessageBox.smethod_1("It appears that you are not connected to the Internet (If you think this is in error please contact your support contact immediately). Only the Premium license of Command PE is allowed to operate in an isolated environment. \r\nCommand PE will now exit...", "Unable to connect to Internet", Enum11.const_0);
							Environment.Exit(0);
						}
					}
				}
				catch (Exception ex10)
				{
					DarkMessageBox.smethod_2("Error found during beta3 application startup. Error details: " + ex10.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex10;
				}
				try
				{
					if (GameGeneral.smethod_3() != GameGeneral.Enum144.const_5)
					{
						Process[] processes = Process.GetProcesses();
						string processName = Process.GetCurrentProcess().ProcessName;
						DateTime startTime = Process.GetCurrentProcess().StartTime;
						foreach (Process process in processes)
						{
							if (Operators.CompareString(process.ProcessName, processName, false) == 0 && DateTime.Compare(process.StartTime, startTime) != 0)
							{
								process.Kill();
							}
						}
					}
				}
				catch (Exception ex11)
				{
					DarkMessageBox.smethod_2("Error found during beta4 application startup. Error details: " + ex11.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex11;
				}
				try
				{
					if (File.Exists(GameGeneral.string_5 + "\\instance"))
					{
						DarkMessageBox.smethod_2("Only one Instance of the application is allowed!!!", "Error", Enum11.const_0);
						Environment.Exit(0);
					}
					else
					{
						File.Create(GameGeneral.string_5 + "\\instance", 10, FileOptions.DeleteOnClose);
					}
				}
				catch (Exception ex12)
				{
					DarkMessageBox.smethod_2("Error found during beta5 application startup. Error details: " + ex12.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex12;
				}
				try
				{
					if (Screen.PrimaryScreen.BitsPerPixel != 32)
					{
						DarkMessageBox.smethod_2("Please set your screen's color depth to 32-bit and restart Command.", "Error", Enum11.const_0);
						Environment.Exit(0);
					}
				}
				catch (Exception ex13)
				{
					DarkMessageBox.smethod_2("Error found during beta6 application startup. Error details: " + ex13.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex13;
				}
				try
				{
					Client.smethod_110();
				}
				catch (Exception ex14)
				{
					DarkMessageBox.smethod_2("Error found during beta7 application startup. Error details: " + ex14.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex14;
				}
				try
				{
					if (Class570.class280_0 == null)
					{
						Class570.smethod_0(ref Class2566.dictionary_0, ref Client.list_1);
						if (Class570.class280_0.method_50())
						{
							string text = "Successfully loaded Sim Configuration.";
							GameGeneral.smethod_26(ref text);
						}
					}
				}
				catch (Exception ex15)
				{
					DarkMessageBox.smethod_2("Error found during gamma1 application startup. Error details: " + ex15.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex15;
				}
				try
				{
					Class2477 targetObject = new Class2477();
					Class2413.smethod_1().UnhandledException += targetObject.method_0;
				}
				catch (Exception ex16)
				{
					DarkMessageBox.smethod_2("Error found during gamma3 application startup. Error details: " + ex16.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex16;
				}
				try
				{
					Class2413.smethod_2().method_42().Show();
				}
				catch (Exception ex17)
				{
					DarkMessageBox.smethod_2("Error found during gamma4 application startup. Error details: " + ex17.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex17;
				}
				try
				{
					Class2413.smethod_1().DoEvents();
				}
				catch (Exception ex18)
				{
					DarkMessageBox.smethod_2("Error found during gamma5 application startup. Error details: " + ex18.Message, "Error in Application_Startup!", Enum11.const_0);
					throw ex18;
				}
			}
			catch (Exception ex19)
			{
				ex19.Data.Add("Error at 200575", ex19.Message);
				GameGeneral.smethod_25(ref ex19);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				DarkMessageBox.smethod_2("Error found during application startup. Error details: " + ex19.Message, "Error in Application_Startup!", Enum11.const_0);
			}
		}

		// Token: 0x06005995 RID: 22933 RVA: 0x0031676C File Offset: 0x0031496C
		public Form3() : base(AuthenticationMode.Windows)
		{
			base.NetworkAvailabilityChanged += this.Form3_NetworkAvailabilityChanged;
			base.Shutdown += this.Form3_Shutdown;
			base.Startup += this.Form3_Startup;
			base.IsSingleInstance = false;
			base.EnableVisualStyles = true;
			base.SaveMySettingsOnExit = true;
			base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x00039A5B File Offset: 0x00037C5B
		protected override void OnCreateMainForm()
		{
			base.MainForm = Class2413.smethod_2().method_41();
		}

		// Token: 0x02000D5E RID: 3422
		[CompilerGenerated]
		internal sealed class Class2411
		{
			// Token: 0x06005997 RID: 22935 RVA: 0x00039A6D File Offset: 0x00037C6D
			public Class2411(Form3.Class2411 class2411_0)
			{
				if (class2411_0 != null)
				{
					this.tacviewClient_0 = class2411_0.tacviewClient_0;
				}
			}

			// Token: 0x06005998 RID: 22936 RVA: 0x00039A84 File Offset: 0x00037C84
			internal void method_0()
			{
				this.tacviewClient_0.method_0();
			}

			// Token: 0x04003417 RID: 13335
			public TacviewClient tacviewClient_0;
		}
	}
}
