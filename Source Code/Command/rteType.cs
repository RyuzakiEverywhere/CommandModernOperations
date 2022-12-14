using System;
using System.Xml.Serialization;

// Token: 0x020005B0 RID: 1456
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class rteType
{
	// Token: 0x040021F1 RID: 8689
	[XmlElement("link")]
	public linkType[] link;

	// Token: 0x040021F2 RID: 8690
	[XmlElement(DataType = "nonNegativeInteger")]
	public string number;

	// Token: 0x040021F3 RID: 8691
	[XmlElement("rtept")]
	public wptType[] rtept;
}
