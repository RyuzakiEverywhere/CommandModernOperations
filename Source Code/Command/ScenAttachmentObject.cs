using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns9;

namespace Command_Core
{
	// Token: 0x020001B7 RID: 439
	public class ScenAttachmentObject
	{
		// Token: 0x06000DBF RID: 3519 RVA: 0x00002977 File Offset: 0x00000B77
		public ScenAttachmentObject()
		{
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x000093F6 File Offset: 0x000075F6
		public ScenAttachmentObject(string string_2)
		{
			this.string_0 = string_2;
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00110704 File Offset: 0x0010E904
		public string method_0()
		{
			if (string.IsNullOrEmpty(this.string_0))
			{
				this.string_0 = Guid.NewGuid().ToString();
			}
			return this.string_0;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00009405 File Offset: 0x00007605
		public string method_1()
		{
			return this.string_1;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0000940D File Offset: 0x0000760D
		public void method_2(string string_2)
		{
			this.string_1 = string_2;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00002F8D File Offset: 0x0000118D
		public virtual void vmethod_0(string string_2)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00002F8D File Offset: 0x0000118D
		public virtual void vmethod_1(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00002F8D File Offset: 0x0000118D
		public virtual void vmethod_2(string string_2)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00110740 File Offset: 0x0010E940
		public static ScenAttachmentObject smethod_0(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0, Scenario scenario_0)
		{
			ScenAttachmentObject result;
			try
			{
				string name = xmlNode_0.Name;
				if (Operators.CompareString(name, "SAO_OverlaySingle", false) != 0)
				{
					if (Operators.CompareString(name, "SAO_LuaScript", false) != 0)
					{
						if (Operators.CompareString(name, "SAO_Inst", false) != 0)
						{
							if (Operators.CompareString(name, "SAO_LocalVideo", false) != 0)
							{
								if (Operators.CompareString(name, "SAO_LocalSound", false) != 0)
								{
									result = null;
								}
								else
								{
									result = Class260.smethod_2(xmlNode_0, dictionary_0, scenario_0);
								}
							}
							else
							{
								result = Class261.smethod_2(xmlNode_0, dictionary_0, scenario_0);
							}
						}
						else
						{
							result = Class259.smethod_2(xmlNode_0, dictionary_0, scenario_0);
						}
					}
					else
					{
						result = Class262.smethod_2(xmlNode_0, dictionary_0, scenario_0);
					}
				}
				else
				{
					result = Class263.smethod_3(xmlNode_0, dictionary_0, scenario_0);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101310", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00002F8D File Offset: 0x0000118D
		public virtual bool vmethod_3(Scenario scenario_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00009416 File Offset: 0x00007616
		public virtual bool vmethod_4(Scenario scenario_0, Side side_0)
		{
			return this.vmethod_3(scenario_0);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00110820 File Offset: 0x0010EA20
		public static ScenAttachmentObject smethod_1(string string_2)
		{
			ScenAttachmentObject scenAttachmentObject = null;
			if (Enumerable.Contains<string>(Directory.GetFiles(string_2), Path.Combine(string_2, "desc.xml")))
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(Path.Combine(string_2, "desc.xml"));
				string fileName = Path.GetFileName(string_2);
				ScenAttachmentObject.AttachmentObjectType attachmentObjectType = (ScenAttachmentObject.AttachmentObjectType)Conversions.ToInteger(xmlDocument.SelectSingleNode("/Attachment/Type").InnerText);
				string innerText = xmlDocument.SelectSingleNode("/Attachment/Desc").InnerText;
				switch (attachmentObjectType)
				{
				case ScenAttachmentObject.AttachmentObjectType.MapOverlay_SingleImage:
					scenAttachmentObject = new Class263(fileName);
					scenAttachmentObject.method_2(innerText);
					((Class263)scenAttachmentObject).ImageFileName = xmlDocument.SelectSingleNode("/Attachment/IFN").InnerText;
					break;
				case ScenAttachmentObject.AttachmentObjectType.LocalVideo:
					scenAttachmentObject = new Class261(fileName);
					scenAttachmentObject.method_2(innerText);
					((Class261)scenAttachmentObject).VideoFileName = xmlDocument.SelectSingleNode("/Attachment/VFN").InnerText;
					break;
				case ScenAttachmentObject.AttachmentObjectType.LuaScript:
					scenAttachmentObject = new Class262(fileName);
					scenAttachmentObject.method_2(innerText);
					((Class262)scenAttachmentObject).ScriptFileName = xmlDocument.SelectSingleNode("/Attachment/SFN").InnerText;
					break;
				case ScenAttachmentObject.AttachmentObjectType.Inst:
					scenAttachmentObject = new Class259(fileName);
					scenAttachmentObject.method_2(innerText);
					((Class259)scenAttachmentObject).InstFileName = xmlDocument.SelectSingleNode("/Attachment/IFN").InnerText;
					break;
				case ScenAttachmentObject.AttachmentObjectType.localSound:
					scenAttachmentObject = new Class260(fileName);
					scenAttachmentObject.method_2(innerText);
					((Class260)scenAttachmentObject).SoundFileName = xmlDocument.SelectSingleNode("/Attachment/FFN").InnerText;
					break;
				}
			}
			return scenAttachmentObject;
		}

		// Token: 0x040008CE RID: 2254
		protected string string_0;

		// Token: 0x040008CF RID: 2255
		public string string_1;

		// Token: 0x040008D0 RID: 2256
		public ScenAttachmentObject.AttachmentObjectType attachmentObjectType_0;

		// Token: 0x020001B8 RID: 440
		public enum AttachmentObjectType
		{
			// Token: 0x040008D2 RID: 2258
			MapOverlay_SingleImage,
			// Token: 0x040008D3 RID: 2259
			MapOverlay_Tiles,
			// Token: 0x040008D4 RID: 2260
			Audio,
			// Token: 0x040008D5 RID: 2261
			LocalVideo,
			// Token: 0x040008D6 RID: 2262
			LuaScript,
			// Token: 0x040008D7 RID: 2263
			Inst,
			// Token: 0x040008D8 RID: 2264
			localSound
		}
	}
}
