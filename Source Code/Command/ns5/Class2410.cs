using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ns5
{
	// Token: 0x02000D55 RID: 3413
	[CompilerGenerated]
	internal sealed class Class2410<<Count>j__TPar, <Members>j__TPar>
	{
		// Token: 0x06005968 RID: 22888 RVA: 0x0003995C File Offset: 0x00037B5C
		public Class2410(<Count>j__TPar gparam_2, <Members>j__TPar gparam_3)
		{
			this.gparam_0 = gparam_2;
			this.gparam_1 = gparam_3;
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x00039972 File Offset: 0x00037B72
		public <Count>j__TPar method_0()
		{
			return this.gparam_0;
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x0003997A File Offset: 0x00037B7A
		public <Members>j__TPar method_1()
		{
			return this.gparam_1;
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x00315B74 File Offset: 0x00313D74
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{ Count = ");
			stringBuilder.Append(this.gparam_0);
			stringBuilder.Append(", Members = ");
			stringBuilder.Append(this.gparam_1);
			stringBuilder.Append(" }");
			return stringBuilder.ToString();
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x00315BD8 File Offset: 0x00313DD8
		public override bool Equals(object obj)
		{
			Class2410<<Count>j__TPar, <Members>j__TPar> @class = obj as Class2410<<Count>j__TPar, <Members>j__TPar>;
			return @class != null && EqualityComparer<<Count>j__TPar>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<<Members>j__TPar>.Default.Equals(this.gparam_1, @class.gparam_1);
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x00315C20 File Offset: 0x00313E20
		public override int GetHashCode()
		{
			int num = 697311869 + EqualityComparer<<Count>j__TPar>.Default.GetHashCode(this.gparam_0);
			return -1521134295 * num + EqualityComparer<<Members>j__TPar>.Default.GetHashCode(this.gparam_1);
		}

		// Token: 0x04003411 RID: 13329
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly <Count>j__TPar gparam_0;

		// Token: 0x04003412 RID: 13330
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly <Members>j__TPar gparam_1;
	}
}
