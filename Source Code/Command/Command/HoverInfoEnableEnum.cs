using System;
using System.ComponentModel;
using ns14;
using ns4;

namespace Command
{
	// Token: 0x02000DDC RID: 3548
	[Attribute0]
	[Attribute2]
	[Attribute3]
	[TypeConverter(typeof(Class2453))]
	public enum HoverInfoEnableEnum
	{
		// Token: 0x04003A94 RID: 14996
		[Description("Show")]
		const_0,
		// Token: 0x04003A95 RID: 14997
		[Description("Hide")]
		const_1 = 2
	}
}
