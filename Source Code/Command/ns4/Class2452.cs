using System;
using System.Runtime.CompilerServices;
using Command;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4
{
	// Token: 0x02000DD5 RID: 3541
	internal sealed class Class2452
	{
		// Token: 0x06006686 RID: 26246 RVA: 0x00040D62 File Offset: 0x0003EF62
		public static void smethod_0()
		{
			Class2452.smethod_1(null, 0, null);
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x00385F54 File Offset: 0x00384154
		public static void smethod_1(string SelectedObjectType, int selectedObjectID, string HighlightTarget = null)
		{
			object obj = Class2452.object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			lock (obj)
			{
				new InternalDBViewer
				{
					string_0 = SelectedObjectType,
					int_0 = selectedObjectID,
					string_1 = HighlightTarget
				}.Show();
			}
		}

		// Token: 0x04003A7B RID: 14971
		private static object object_0 = RuntimeHelpers.GetObjectValue(new object());
	}
}
