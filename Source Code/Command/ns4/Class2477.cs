using System;
using System.Collections;
using System.Windows.Forms;
using Command_Core;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace ns4
{
	// Token: 0x02000E68 RID: 3688
	internal sealed class Class2477
	{
		// Token: 0x060070C5 RID: 28869 RVA: 0x003CB674 File Offset: 0x003C9874
		public void method_0(object sender, UnhandledExceptionEventArgs e)
		{
			try
			{
				e.ExitApplication = false;
				Class2413.smethod_2().method_17().method_0("OnThreadException");
				Exception exception = e.Exception;
				if (exception == null)
				{
					Class2413.smethod_2().method_17().method_0("theEx == null");
				}
				else
				{
					Class2413.smethod_2().method_17().method_0("theEx != null");
				}
				if (e.Exception.GetType() == typeof(Direct3DXException))
				{
					try
					{
						Device device_ = Class2413.smethod_2().method_41().device_0;
						Class2413.smethod_2().method_17().method_0("Resetting D3D");
						device_.Reset(new PresentParameters[]
						{
							device_.PresentationParameters
						});
						return;
					}
					catch (Exception ex)
					{
					}
				}
				Class2413.smethod_2().method_17().method_0("e.Exception.GetType().Name: " + e.Exception.GetType().Name);
				Class2413.smethod_2().method_17().method_0("theEx.Message: " + exception.Message);
				Class2413.smethod_2().method_17().method_0("theEx.StackTrace: " + exception.StackTrace);
				if (!Information.IsNothing(exception.InnerException))
				{
					Class2413.smethod_2().method_17().method_0("theEx.InnerException.GetType().Name: " + exception.InnerException.GetType().Name);
				}
				if (!Information.IsNothing(GameGeneral.exception_0))
				{
					string text = string.Concat(new string[]
					{
						"This is probably a bug. Please save a screenshot of this and submit it, along with the autosave files, for investigation.\r\n\r\nException: ",
						exception.Message,
						"\r\n\r\nStack Trace: ",
						exception.StackTrace,
						"\r\n\r\n"
					});
					if (!Information.IsNothing(exception.InnerException))
					{
						text = string.Concat(new string[]
						{
							text,
							"Inner Exception: ",
							exception.InnerException.Message,
							"\r\n\r\nInner StackTrace: ",
							exception.InnerException.StackTrace,
							"\r\n\r\n"
						});
					}
					if (exception.Data.Count > 0)
					{
						text += "Call Stack & Error details: ";
						foreach (object obj in exception.Data)
						{
							DictionaryEntry dictionaryEntry = (obj != null) ? ((DictionaryEntry)obj) : default(DictionaryEntry);
							text = string.Concat(new string[]
							{
								text,
								"\r\n",
								Conversions.ToString(dictionaryEntry.Key),
								", ",
								Conversions.ToString(dictionaryEntry.Value)
							});
						}
					}
					Class2413.smethod_2().method_17().method_0(text);
					e.ExitApplication = false;
				}
				else
				{
					e.ExitApplication = false;
				}
			}
			catch (Exception ex2)
			{
				Exception ex3 = ex2;
				MessageBox.Show("Error in Exception Handler!");
				MessageBox.Show("Error in Exception Handler! OnThreadException");
				if (ex3 == null)
				{
					MessageBox.Show("Error in Exception Handler! theEx == null");
				}
				else
				{
					MessageBox.Show("Error in Exception Handler! theEx != null");
				}
				if (e.Exception.GetType() == typeof(Direct3DXException))
				{
					try
					{
						Device device_2 = Class2413.smethod_2().method_41().device_0;
						MessageBox.Show("Resetting D3D");
						device_2.Reset(new PresentParameters[]
						{
							device_2.PresentationParameters
						});
						ProjectData.ClearProjectError();
						return;
					}
					catch (Exception ex4)
					{
					}
				}
				MessageBox.Show("Error in Exception Handler! e.Exception.GetType().Name: " + e.Exception.GetType().Name);
				MessageBox.Show("Error in Exception Handler! theEx.Message: " + ex3.Message);
				MessageBox.Show("Error in Exception Handler! theEx.StackTrace: " + ex3.StackTrace);
				if (!Information.IsNothing(ex3.InnerException))
				{
					MessageBox.Show("Error in Exception Handler! theEx.InnerException.GetType().Name: " + ex3.InnerException.GetType().Name);
				}
				string text2 = string.Concat(new string[]
				{
					"Error in Exception Handler! This is probably a Error in Exception Handler!. Please save a screenshot of this and submit it, along with the autosave files, for investigation.\r\n\r\nException: ",
					ex3.Message,
					"\r\n\r\nStack Trace: ",
					ex3.StackTrace,
					"\r\n\r\n"
				});
				if (!Information.IsNothing(ex3.InnerException))
				{
					text2 = string.Concat(new string[]
					{
						text2,
						"Inner Exception: ",
						ex3.InnerException.Message,
						"\r\n\r\nInner StackTrace: ",
						ex3.InnerException.StackTrace,
						"\r\n\r\n"
					});
				}
				if (ex3.Data.Count > 0)
				{
					text2 += "Call Stack & Error details: ";
					foreach (object obj2 in ex3.Data)
					{
						DictionaryEntry dictionaryEntry2 = (obj2 != null) ? ((DictionaryEntry)obj2) : default(DictionaryEntry);
						text2 = string.Concat(new string[]
						{
							text2,
							"\r\n",
							Conversions.ToString(dictionaryEntry2.Key),
							", ",
							Conversions.ToString(dictionaryEntry2.Value)
						});
					}
				}
				MessageBox.Show(text2);
			}
		}
	}
}
