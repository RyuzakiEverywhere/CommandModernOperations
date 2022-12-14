using System;
using System.Xml.Serialization;

// Token: 0x020005AF RID: 1455
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class trkType
{
	// Token: 0x040021EE RID: 8686
	[XmlElement("link")]
	public linkType[] link;

	// Token: 0x040021EF RID: 8687
	[XmlElement(DataType = "nonNegativeInteger")]
	public string number;

	// Token: 0x040021F0 RID: 8688
	[XmlElement("trkseg")]
	public trksegType[] trkseg;
}
