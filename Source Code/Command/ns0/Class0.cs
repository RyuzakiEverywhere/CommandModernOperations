using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000002 RID: 2
	internal sealed class Class0
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00053C80 File Offset: 0x00051E80
		public Class0()
		{
			try
			{
				Assembly assembly = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
				this.type_0 = assembly.GetType("System.Security.Cryptography.AesManaged");
			}
			catch (FileNotFoundException)
			{
				Assembly assembly = Assembly.Load("mscorlib");
				this.type_0 = assembly.GetType("System.Security.Cryptography.RijndaelManaged");
			}
			this.object_0 = Activator.CreateInstance(this.type_0);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00053CF4 File Offset: 0x00051EF4
		public ICryptoTransform method_0(byte[] byte_0, byte[] byte_1, bool bool_0)
		{
			this.type_0.GetProperty("Key").GetSetMethod().Invoke(this.object_0, new object[]
			{
				byte_0
			});
			this.type_0.GetProperty("IV").GetSetMethod().Invoke(this.object_0, new object[]
			{
				byte_1
			});
			MethodInfo method = this.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
			return (ICryptoTransform)method.Invoke(this.object_0, new object[0]);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000027F8 File Offset: 0x000009F8
		public void method_1()
		{
			this.type_0.GetMethod("Clear").Invoke(this.object_0, new object[0]);
		}

		// Token: 0x04000001 RID: 1
		private readonly Type type_0;

		// Token: 0x04000002 RID: 2
		private readonly object object_0;
	}
}
