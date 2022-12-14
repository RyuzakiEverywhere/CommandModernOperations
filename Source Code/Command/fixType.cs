using System;
using System.Xml.Serialization;

// Token: 0x020005AD RID: 1453
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public enum fixType
{
	// Token: 0x040021E8 RID: 8680
	none,
	// Token: 0x040021E9 RID: 8681
	[XmlEnum("2d")]
	Item2d,
	// Token: 0x040021EA RID: 8682
	[XmlEnum("3d")]
	Item3d,
	// Token: 0x040021EB RID: 8683
	dgps,
	// Token: 0x040021EC RID: 8684
	pps
}
