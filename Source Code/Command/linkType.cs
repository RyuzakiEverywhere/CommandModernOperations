using System;
using System.Xml.Serialization;

// Token: 0x020005AC RID: 1452
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class linkType
{
	// Token: 0x040021E6 RID: 8678
	[XmlAttribute(DataType = "anyURI")]
	public string href;
}
