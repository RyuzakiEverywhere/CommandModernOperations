using System;
using System.Xml.Serialization;

// Token: 0x020005B1 RID: 1457
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class boundsType
{
	// Token: 0x040021F4 RID: 8692
	[XmlAttribute]
	public decimal minlat;

	// Token: 0x040021F5 RID: 8693
	[XmlAttribute]
	public decimal minlon;

	// Token: 0x040021F6 RID: 8694
	[XmlAttribute]
	public decimal maxlat;

	// Token: 0x040021F7 RID: 8695
	[XmlAttribute]
	public decimal maxlon;
}
