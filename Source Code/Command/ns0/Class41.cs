using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using Gameloop.Vdf;
using Gameloop.Vdf.Linq;
using Gameloop.Vdf.Utilities;

namespace ns0
{
	// Token: 0x02000044 RID: 68
	internal abstract class Class41 : IEnumerable<Class41>, IEnumerable, IDynamicMetaObjectProvider
	{
		// Token: 0x060000D5 RID: 213
		public abstract void vmethod_0(VdfWriter vdfWriter_0);

		// Token: 0x060000D6 RID: 214 RVA: 0x000031AF File Offset: 0x000013AF
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<Class41>)this).GetEnumerator();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000031B7 File Offset: 0x000013B7
		IEnumerator<Class41> IEnumerable<Class41>.GetEnumerator()
		{
			return this.vmethod_1().GetEnumerator();
		}

		// Token: 0x1700000B RID: 11
		public virtual Class41 this[object object_0]
		{
			get
			{
				throw new InvalidOperationException(string.Format("Cannot access child value on {0}.", base.GetType()));
			}
			set
			{
				throw new InvalidOperationException(string.Format("Cannot set child value on {0}.", base.GetType()));
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000563D8 File Offset: 0x000545D8
		public virtual T Value<T>(object object_0)
		{
			Class41 @class = this[object_0];
			if (@class != null)
			{
				return Class34.smethod_0<Class41, T>(@class);
			}
			return default(T);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000031F2 File Offset: 0x000013F2
		public virtual IEnumerable<VProperty> vmethod_1()
		{
			return Enumerable.Empty<VProperty>();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000031F9 File Offset: 0x000013F9
		protected virtual DynamicMetaObject GetMetaObject(Expression expression_0)
		{
			return new DynamicProxyMetaObject<Class41>(expression_0, this, new Class15<Class41>());
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003207 File Offset: 0x00001407
		DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
		{
			return this.GetMetaObject(parameter);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00056400 File Offset: 0x00054600
		public override string ToString()
		{
			string result;
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				Class13 vdfWriter_ = new Class13(stringWriter);
				this.vmethod_0(vdfWriter_);
				result = stringWriter.ToString();
			}
			return result;
		}
	}
}
