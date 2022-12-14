using System;
using System.Xml;
using System.Xml.Serialization;

// Token: 0x020005AE RID: 1454
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class extensionsType
{
	// Token: 0x040021ED RID: 8685
	[XmlAnyElement]
	public XmlElement[] Any;
}
