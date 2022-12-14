using System;
using System.Xml.Serialization;

// Token: 0x020005AA RID: 1450
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class trksegType
{
	// Token: 0x040021D7 RID: 8663
	[XmlElement("trkpt")]
	public wptType[] trkpt;
}
