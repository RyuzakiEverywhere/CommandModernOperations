using System;

namespace Newtonsoft.Json
{
	// Token: 0x02000D45 RID: 3397
	public enum JsonToken
	{
		// Token: 0x040033E4 RID: 13284
		None,
		// Token: 0x040033E5 RID: 13285
		StartObject,
		// Token: 0x040033E6 RID: 13286
		StartArray,
		// Token: 0x040033E7 RID: 13287
		StartConstructor,
		// Token: 0x040033E8 RID: 13288
		PropertyName,
		// Token: 0x040033E9 RID: 13289
		Comment,
		// Token: 0x040033EA RID: 13290
		Raw,
		// Token: 0x040033EB RID: 13291
		Integer,
		// Token: 0x040033EC RID: 13292
		Float,
		// Token: 0x040033ED RID: 13293
		String,
		// Token: 0x040033EE RID: 13294
		Boolean,
		// Token: 0x040033EF RID: 13295
		Null,
		// Token: 0x040033F0 RID: 13296
		Undefined,
		// Token: 0x040033F1 RID: 13297
		EndObject,
		// Token: 0x040033F2 RID: 13298
		EndArray,
		// Token: 0x040033F3 RID: 13299
		EndConstructor,
		// Token: 0x040033F4 RID: 13300
		Date,
		// Token: 0x040033F5 RID: 13301
		Bytes
	}
}
