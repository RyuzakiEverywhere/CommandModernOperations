using System;
using System.Xml.Serialization;

// Token: 0x020005A9 RID: 1449
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class emailType
{
	// Token: 0x040021D5 RID: 8661
	[XmlAttribute]
	public string id;

	// Token: 0x040021D6 RID: 8662
	[XmlAttribute]
	public string domain;
}
