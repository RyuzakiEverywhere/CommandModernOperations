using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.VisualBasic.CompilerServices;

namespace ns5
{
	// Token: 0x02000D68 RID: 3432
	[StandardModule]
	internal sealed class Class2420
	{
		// Token: 0x06005A03 RID: 23043 RVA: 0x00316948 File Offset: 0x00314B48
		public static bool smethod_0(string string_0)
		{
			string text = Class2420.smethod_1(string_0);
			return Class2420.hashSet_0.Contains(text);
		}

		// Token: 0x06005A04 RID: 23044 RVA: 0x00316970 File Offset: 0x00314B70
		private static string smethod_1(string string_0)
		{
			string result;
			try
			{
				Runspace runspace = RunspaceFactory.CreateRunspace(RunspaceConfiguration.Create());
				runspace.Open();
				Pipeline pipeline = runspace.CreatePipeline();
				pipeline.Commands.AddScript("Get-AuthenticodeSignature \"" + string_0 + "\"");
				Collection<PSObject> collection = pipeline.Invoke();
				runspace.Close();
				Signature signature = collection[0].BaseObject as Signature;
				if (signature == null)
				{
					result = string.Empty;
				}
				else
				{
					switch (signature.Status)
					{
					case SignatureStatus.Valid:
						result = signature.SignerCertificate.SerialNumber;
						break;
					case SignatureStatus.UnknownError:
						result = string.Empty;
						break;
					case SignatureStatus.NotSigned:
						result = string.Empty;
						break;
					case SignatureStatus.HashMismatch:
						result = string.Empty;
						break;
					case SignatureStatus.NotTrusted:
						result = string.Empty;
						break;
					case SignatureStatus.NotSupportedFileFormat:
						result = string.Empty;
						break;
					case SignatureStatus.Incompatible:
						result = string.Empty;
						break;
					default:
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						result = Conversions.ToString(signature != null && signature.Status != SignatureStatus.NotSigned);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error when trying to check if file is signed:" + string_0 + " --> " + ex.Message);
			}
			return result;
		}

		// Token: 0x0400346F RID: 13423
		private static HashSet<string> hashSet_0 = new HashSet<string>(new List<string>(new string[]
		{
			"00FC5B076FCD201FD9426461284218C908"
		}));
	}
}
