using System;
using System.Xml.Serialization;

// Token: 0x020005B2 RID: 1458
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class copyrightType
{
	// Token: 0x040021F8 RID: 8696
	[XmlElement(DataType = "gYear")]
	public string year;

	// Token: 0x040021F9 RID: 8697
	[XmlElement(DataType = "anyURI")]
	public string license;

	// Token: 0x040021FA RID: 8698
	[XmlAttribute]
	public string author;
}
