using System;
using System.Xml.Serialization;

// Token: 0x020005AB RID: 1451
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class wptType
{
	// Token: 0x040021D8 RID: 8664
	[XmlIgnore]
	public bool eleSpecified;

	// Token: 0x040021D9 RID: 8665
	[XmlIgnore]
	public bool timeSpecified;

	// Token: 0x040021DA RID: 8666
	[XmlIgnore]
	public bool magvarSpecified;

	// Token: 0x040021DB RID: 8667
	[XmlIgnore]
	public bool geoidheightSpecified;

	// Token: 0x040021DC RID: 8668
	[XmlElement("link")]
	public linkType[] link;

	// Token: 0x040021DD RID: 8669
	[XmlIgnore]
	public bool fixSpecified;

	// Token: 0x040021DE RID: 8670
	[XmlElement(DataType = "nonNegativeInteger")]
	public string sat;

	// Token: 0x040021DF RID: 8671
	[XmlIgnore]
	public bool hdopSpecified;

	// Token: 0x040021E0 RID: 8672
	[XmlIgnore]
	public bool vdopSpecified;

	// Token: 0x040021E1 RID: 8673
	[XmlIgnore]
	public bool pdopSpecified;

	// Token: 0x040021E2 RID: 8674
	[XmlIgnore]
	public bool ageofdgpsdataSpecified;

	// Token: 0x040021E3 RID: 8675
	[XmlElement(DataType = "integer")]
	public string dgpsid;

	// Token: 0x040021E4 RID: 8676
	[XmlAttribute]
	public decimal lat;

	// Token: 0x040021E5 RID: 8677
	[XmlAttribute]
	public decimal lon;
}
