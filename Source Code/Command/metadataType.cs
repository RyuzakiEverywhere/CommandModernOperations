using System;
using System.Xml.Serialization;

// Token: 0x020005A7 RID: 1447
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class metadataType
{
	// Token: 0x040021D3 RID: 8659
	[XmlElement("link")]
	public linkType[] link;

	// Token: 0x040021D4 RID: 8660
	[XmlIgnore]
	public bool timeSpecified;
}
