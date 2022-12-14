using System;
using System.Xml.Serialization;

// Token: 0x020005A6 RID: 1446
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
[XmlRoot("gpx", Namespace = "http://www.topografix.com/GPX/1/1", IsNullable = false)]
public sealed class gpxType
{
	// Token: 0x040021CE RID: 8654
	[XmlElement("wpt")]
	public wptType[] wpt;

	// Token: 0x040021CF RID: 8655
	[XmlElement("rte")]
	public rteType[] rte;

	// Token: 0x040021D0 RID: 8656
	[XmlElement("trk")]
	public trkType[] trk;

	// Token: 0x040021D1 RID: 8657
	[XmlAttribute]
	public string version = "1.1";

	// Token: 0x040021D2 RID: 8658
	[XmlAttribute]
	public string creator;
}
