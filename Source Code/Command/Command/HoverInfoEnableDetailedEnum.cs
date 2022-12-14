using System;
using System.ComponentModel;
using ns14;
using ns4;

namespace Command
{
	// Token: 0x02000DDB RID: 3547
	[TypeConverter(typeof(Class2453))]
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public enum HoverInfoEnableDetailedEnum
	{
		// Token: 0x04003A90 RID: 14992
		[Description("Show Detailed")]
		const_0,
		// Token: 0x04003A91 RID: 14993
		[Description("Show Summary")]
		const_1,
		// Token: 0x04003A92 RID: 14994
		[Description("Hide")]
		const_2
	}
}
