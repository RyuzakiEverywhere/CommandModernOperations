using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using ns0;

namespace Gameloop.Vdf.Utilities
{
	// Token: 0x02000023 RID: 35
	internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00002C37 File Offset: 0x00000E37
		internal DynamicProxyMetaObject(Expression expression_0, T gparam_0, Class15<T> class15_1) : base(expression_0, BindingRestrictions.Empty, gparam_0)
		{
			this.class15_0 = class15_1;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002C52 File Offset: 0x00000E52
		private bool method_0(string string_0)
		{
			return Class30.smethod_1(this.class15_0.GetType(), typeof(Class15<T>), string_0);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000554F4 File Offset: 0x000536F4
		public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			DynamicProxyMetaObject<T>.Class17 @class = new DynamicProxyMetaObject<T>.Class17();
			@class.getMemberBinder_0 = binder;
			@class.dynamicProxyMetaObject_0 = this;
			if (!this.method_0("TryGetMember"))
			{
				return base.BindGetMember(@class.getMemberBinder_0);
			}
			return this.method_1("TryGetMember", @class.getMemberBinder_0, DynamicProxyMetaObject<T>.smethod_0(), new DynamicProxyMetaObject<T>.Delegate0(@class.method_0), null);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00055554 File Offset: 0x00053754
		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			DynamicProxyMetaObject<T>.Class18 @class = new DynamicProxyMetaObject<T>.Class18();
			@class.setMemberBinder_0 = binder;
			@class.dynamicProxyMetaObject_0 = this;
			@class.value = value;
			if (!this.method_0("TrySetMember"))
			{
				return base.BindSetMember(@class.setMemberBinder_0, @class.value);
			}
			return this.method_3("TrySetMember", @class.setMemberBinder_0, DynamicProxyMetaObject<T>.smethod_1(new DynamicMetaObject[]
			{
				@class.value
			}), new DynamicProxyMetaObject<T>.Delegate0(@class.method_0));
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000555D0 File Offset: 0x000537D0
		public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			DynamicProxyMetaObject<T>.Class19 @class = new DynamicProxyMetaObject<T>.Class19();
			@class.deleteMemberBinder_0 = binder;
			@class.dynamicProxyMetaObject_0 = this;
			if (!this.method_0("TryDeleteMember"))
			{
				return base.BindDeleteMember(@class.deleteMemberBinder_0);
			}
			return this.method_4("TryDeleteMember", @class.deleteMemberBinder_0, DynamicProxyMetaObject<T>.smethod_0(), new DynamicProxyMetaObject<T>.Delegate0(@class.method_0));
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00055630 File Offset: 0x00053830
		public override DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			DynamicProxyMetaObject<T>.Class20 @class = new DynamicProxyMetaObject<T>.Class20();
			@class.convertBinder_0 = binder;
			@class.dynamicProxyMetaObject_0 = this;
			if (!this.method_0("TryConvert"))
			{
				return base.BindConvert(@class.convertBinder_0);
			}
			return this.method_1("TryConvert", @class.convertBinder_0, DynamicProxyMetaObject<T>.smethod_0(), new DynamicProxyMetaObject<T>.Delegate0(@class.method_0), null);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00055690 File Offset: 0x00053890
		public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			DynamicProxyMetaObject<T>.Class21 @class = new DynamicProxyMetaObject<T>.Class21();
			@class.invokeMemberBinder_0 = binder;
			@class.dynamicProxyMetaObject_0 = this;
			@class.dynamicMetaObject_0 = args;
			if (!this.method_0("TryInvokeMember"))
			{
				return base.BindInvokeMember(@class.invokeMemberBinder_0, @class.dynamicMetaObject_0);
			}
			DynamicProxyMetaObject<T>.Delegate0 @delegate = new DynamicProxyMetaObject<T>.Delegate0(@class.method_0);
			return this.method_2("TryInvokeMember", @class.invokeMemberBinder_0, DynamicProxyMetaObject<T>.smethod_2(@class.dynamicMetaObject_0), this.method_2("TryGetMember", new DynamicProxyMetaObject<T>.Class16(@class.invokeMemberBinder_0), DynamicProxyMetaObject<T>.smethod_0(), @delegate(null), new DynamicProxyMetaObject<T>.Delegate0(@class.method_1)), null);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00055730 File Offset: 0x00053930
		public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
		{
			DynamicProxyMetaObject<T>.Class22 @class = new DynamicProxyMetaObject<T>.Class22();
			@class.createInstanceBinder_0 = binder;
			@class.dynamicProxyMetaObject_0 = this;
			@class.dynamicMetaObject_0 = args;
			if (!this.method_0("TryCreateInstance"))
			{
				return base.BindCreateInstance(@class.createInstanceBinder_0, @class.dynamicMetaObject_0);
			}
			return this.method_1("TryCreateInstance", @class.createInstanceBinder_0, DynamicProxyMetaObject<T>.smethod_2(@class.dynamicMetaObject_0), new DynamicProxyMetaObject<T>.Delegate0(@class.method_0), null);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000557A4 File Offset: 0x000539A4
		public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
		{
			DynamicProxyMetaObject<T>.Class23 @class = new DynamicProxyMetaObject<T>.Class23();
			@class.invokeBinder_0 = binder;
			@class.dynamicProxyMetaObject_0 = this;
			@class.dynamicMetaObject_0 = args;
			if (!this.method_0("TryInvoke"))
			{
				return base.BindInvoke(@class.invokeBinder_0, @class.dynamicMetaObject_0);
			}
			return this.method_1("TryInvoke", @class.invokeBinder_0, DynamicProxyMetaObject<T>.smethod_2(@class.dynamicMetaObject_0), new DynamicProxyMetaObject<T>.Delegate0(@class.method_0), null);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00055818 File Offset: 0x00053A18
		public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
		{
			DynamicProxyMetaObject<T>.Class24 @class = new DynamicProxyMetaObject<T>.Class24();
			@class.binaryOperationBinder_0 = binder;
			@class.dynamicProxyMetaObject_0 = this;
			@class.dynamicMetaObject_0 = arg;
			if (!this.method_0("TryBinaryOperation"))
			{
				return base.BindBinaryOperation(@class.binaryOperationBinder_0, @class.dynamicMetaObject_0);
			}
			return this.method_1("TryBinaryOperation", @class.binaryOperationBinder_0, DynamicProxyMetaObject<T>.smethod_1(new DynamicMetaObject[]
			{
				@class.dynamicMetaObject_0
			}), new DynamicProxyMetaObject<T>.Delegate0(@class.method_0), null);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00055894 File Offset: 0x00053A94
		public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			DynamicProxyMetaObject<T>.Class25 @class = new DynamicProxyMetaObject<T>.Class25();
			@class.unaryOperationBinder_0 = binder;
			@class.dynamicProxyMetaObject_0 = this;
			if (!this.method_0("TryUnaryOperation"))
			{
				return base.BindUnaryOperation(@class.unaryOperationBinder_0);
			}
			return this.method_1("TryUnaryOperation", @class.unaryOperationBinder_0, DynamicProxyMetaObject<T>.smethod_0(), new DynamicProxyMetaObject<T>.Delegate0(@class.method_0), null);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000558F4 File Offset: 0x00053AF4
		public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
		{
			DynamicProxyMetaObject<T>.Class26 @class = new DynamicProxyMetaObject<T>.Class26();
			@class.getIndexBinder_0 = binder;
			@class.dynamicProxyMetaObject_0 = this;
			@class.dynamicMetaObject_0 = indexes;
			if (!this.method_0("TryGetIndex"))
			{
				return base.BindGetIndex(@class.getIndexBinder_0, @class.dynamicMetaObject_0);
			}
			return this.method_1("TryGetIndex", @class.getIndexBinder_0, DynamicProxyMetaObject<T>.smethod_2(@class.dynamicMetaObject_0), new DynamicProxyMetaObject<T>.Delegate0(@class.method_0), null);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00055968 File Offset: 0x00053B68
		public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			DynamicProxyMetaObject<T>.Class27 @class = new DynamicProxyMetaObject<T>.Class27();
			@class.setIndexBinder_0 = binder;
			@class.dynamicProxyMetaObject_0 = this;
			@class.dynamicMetaObject_0 = indexes;
			@class.value = value;
			if (!this.method_0("TrySetIndex"))
			{
				return base.BindSetIndex(@class.setIndexBinder_0, @class.dynamicMetaObject_0, @class.value);
			}
			return this.method_3("TrySetIndex", @class.setIndexBinder_0, DynamicProxyMetaObject<T>.smethod_3(@class.dynamicMetaObject_0, @class.value), new DynamicProxyMetaObject<T>.Delegate0(@class.method_0));
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000559EC File Offset: 0x00053BEC
		public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
		{
			DynamicProxyMetaObject<T>.Class28 @class = new DynamicProxyMetaObject<T>.Class28();
			@class.deleteIndexBinder_0 = binder;
			@class.dynamicProxyMetaObject_0 = this;
			@class.dynamicMetaObject_0 = indexes;
			if (!this.method_0("TryDeleteIndex"))
			{
				return base.BindDeleteIndex(@class.deleteIndexBinder_0, @class.dynamicMetaObject_0);
			}
			return this.method_4("TryDeleteIndex", @class.deleteIndexBinder_0, DynamicProxyMetaObject<T>.smethod_2(@class.dynamicMetaObject_0), new DynamicProxyMetaObject<T>.Delegate0(@class.method_0));
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002C6F File Offset: 0x00000E6F
		private static Expression[] smethod_0()
		{
			return Class14.smethod_1<Expression>();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002C76 File Offset: 0x00000E76
		private static IEnumerable<Expression> smethod_1(DynamicMetaObject[] dynamicMetaObject_0)
		{
			return Enumerable.Select<DynamicMetaObject, Expression>(dynamicMetaObject_0, new Func<DynamicMetaObject, Expression>(DynamicProxyMetaObject<T>.<>c.<>9.method_0));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00055A5C File Offset: 0x00053C5C
		private static Expression[] smethod_2(DynamicMetaObject[] dynamicMetaObject_0)
		{
			return new NewArrayExpression[]
			{
				Expression.NewArrayInit(typeof(object), DynamicProxyMetaObject<T>.smethod_1(dynamicMetaObject_0))
			};
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00055A8C File Offset: 0x00053C8C
		private static Expression[] smethod_3(DynamicMetaObject[] dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1)
		{
			Expression expression = dynamicMetaObject_1.Expression;
			return new Expression[]
			{
				Expression.NewArrayInit(typeof(object), DynamicProxyMetaObject<T>.smethod_1(dynamicMetaObject_0)),
				Class32.smethod_3(expression.Type) ? Expression.Convert(expression, typeof(object)) : expression
			};
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00055AE4 File Offset: 0x00053CE4
		private static ConstantExpression smethod_4(DynamicMetaObjectBinder dynamicMetaObjectBinder_0)
		{
			Type type = dynamicMetaObjectBinder_0.GetType();
			while (!Class32.smethod_2(type))
			{
				type = Class32.smethod_1(type);
			}
			return Expression.Constant(dynamicMetaObjectBinder_0, type);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00055B10 File Offset: 0x00053D10
		private DynamicMetaObject method_1(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject<T>.Delegate0 fallback, DynamicProxyMetaObject<T>.Delegate0 fallbackInvoke = null)
		{
			DynamicMetaObject dynamicMetaObject_ = fallback(null);
			return this.method_2(methodName, binder, args, dynamicMetaObject_, fallbackInvoke);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00055B34 File Offset: 0x00053D34
		private DynamicMetaObject method_2(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, IEnumerable<Expression> ienumerable_0, DynamicMetaObject dynamicMetaObject_0, DynamicProxyMetaObject<T>.Delegate0 delegate0_0)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
			IList<Expression> list = new List<Expression>();
			list.Add(Expression.Convert(base.Expression, typeof(T)));
			list.Add(DynamicProxyMetaObject<T>.smethod_4(dynamicMetaObjectBinder_0));
			Class14.smethod_0<Expression>(list, ienumerable_0);
			list.Add(parameterExpression);
			DynamicMetaObject dynamicMetaObject = new DynamicMetaObject(parameterExpression, BindingRestrictions.Empty);
			if (dynamicMetaObjectBinder_0.ReturnType != typeof(object))
			{
				dynamicMetaObject = new DynamicMetaObject(Expression.Convert(dynamicMetaObject.Expression, dynamicMetaObjectBinder_0.ReturnType), dynamicMetaObject.Restrictions);
			}
			if (delegate0_0 != null)
			{
				dynamicMetaObject = delegate0_0(dynamicMetaObject);
			}
			return new DynamicMetaObject(Expression.Block(new ParameterExpression[]
			{
				parameterExpression
			}, new Expression[]
			{
				Expression.Condition(Expression.Call(Expression.Constant(this.class15_0), typeof(Class15<T>).GetMethod(string_0), list), dynamicMetaObject.Expression, dynamicMetaObject_0.Expression, dynamicMetaObjectBinder_0.ReturnType)
			}), this.method_5().Merge(dynamicMetaObject.Restrictions).Merge(dynamicMetaObject_0.Restrictions));
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00055C50 File Offset: 0x00053E50
		private DynamicMetaObject method_3(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, IEnumerable<Expression> ienumerable_0, DynamicProxyMetaObject<T>.Delegate0 delegate0_0)
		{
			DynamicMetaObject dynamicMetaObject = delegate0_0(null);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
			IList<Expression> list = new List<Expression>();
			list.Add(Expression.Convert(base.Expression, typeof(T)));
			list.Add(DynamicProxyMetaObject<T>.smethod_4(dynamicMetaObjectBinder_0));
			Class14.smethod_0<Expression>(list, ienumerable_0);
			list[list.Count - 1] = Expression.Assign(parameterExpression, list[list.Count - 1]);
			return new DynamicMetaObject(Expression.Block(new ParameterExpression[]
			{
				parameterExpression
			}, new Expression[]
			{
				Expression.Condition(Expression.Call(Expression.Constant(this.class15_0), typeof(Class15<T>).GetMethod(string_0), list), parameterExpression, dynamicMetaObject.Expression, typeof(object))
			}), this.method_5().Merge(dynamicMetaObject.Restrictions));
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00055D34 File Offset: 0x00053F34
		private DynamicMetaObject method_4(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, Expression[] expression_0, DynamicProxyMetaObject<T>.Delegate0 delegate0_0)
		{
			DynamicMetaObject dynamicMetaObject = delegate0_0(null);
			IList<Expression> list = new List<Expression>();
			list.Add(Expression.Convert(base.Expression, typeof(T)));
			list.Add(DynamicProxyMetaObject<T>.smethod_4(dynamicMetaObjectBinder_0));
			Class14.smethod_0<Expression>(list, expression_0);
			return new DynamicMetaObject(Expression.Condition(Expression.Call(Expression.Constant(this.class15_0), typeof(Class15<T>).GetMethod(string_0), list), Expression.Empty(), dynamicMetaObject.Expression, typeof(void)), this.method_5().Merge(dynamicMetaObject.Restrictions));
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002C9D File Offset: 0x00000E9D
		private BindingRestrictions method_5()
		{
			if (base.Value == null && base.HasValue)
			{
				return BindingRestrictions.GetInstanceRestriction(base.Expression, null);
			}
			return BindingRestrictions.GetTypeRestriction(base.Expression, base.LimitType);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002CCD File Offset: 0x00000ECD
		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return this.class15_0.vmethod_0((T)((object)base.Value));
		}

		// Token: 0x0400006B RID: 107
		private readonly Class15<T> class15_0;

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x0600006F RID: 111
		private delegate DynamicMetaObject Delegate0(DynamicMetaObject errorSuggestion);

		// Token: 0x02000025 RID: 37
		private sealed class Class16 : GetMemberBinder
		{
			// Token: 0x06000072 RID: 114 RVA: 0x00002CE5 File Offset: 0x00000EE5
			internal Class16(InvokeMemberBinder invokeMemberBinder_0) : base(invokeMemberBinder_0.Name, invokeMemberBinder_0.IgnoreCase)
			{
			}

			// Token: 0x06000073 RID: 115 RVA: 0x00002CF9 File Offset: 0x00000EF9
			public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x02000026 RID: 38
		[CompilerGenerated]
		private sealed class Class17
		{
			// Token: 0x06000075 RID: 117 RVA: 0x00002D00 File Offset: 0x00000F00
			internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
			{
				return this.getMemberBinder_0.FallbackGetMember(this.dynamicProxyMetaObject_0, dynamicMetaObject_0);
			}

			// Token: 0x0400006C RID: 108
			public GetMemberBinder getMemberBinder_0;

			// Token: 0x0400006D RID: 109
			public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;
		}

		// Token: 0x02000027 RID: 39
		[CompilerGenerated]
		private sealed class Class18
		{
			// Token: 0x06000077 RID: 119 RVA: 0x00002D14 File Offset: 0x00000F14
			internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
			{
				return this.setMemberBinder_0.FallbackSetMember(this.dynamicProxyMetaObject_0, this.value, dynamicMetaObject_0);
			}

			// Token: 0x0400006E RID: 110
			public SetMemberBinder setMemberBinder_0;

			// Token: 0x0400006F RID: 111
			public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

			// Token: 0x04000070 RID: 112
			public DynamicMetaObject value;
		}

		// Token: 0x02000028 RID: 40
		[CompilerGenerated]
		private sealed class Class19
		{
			// Token: 0x06000079 RID: 121 RVA: 0x00002D2E File Offset: 0x00000F2E
			internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
			{
				return this.deleteMemberBinder_0.FallbackDeleteMember(this.dynamicProxyMetaObject_0, dynamicMetaObject_0);
			}

			// Token: 0x04000071 RID: 113
			public DeleteMemberBinder deleteMemberBinder_0;

			// Token: 0x04000072 RID: 114
			public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;
		}

		// Token: 0x02000029 RID: 41
		[CompilerGenerated]
		private sealed class Class20
		{
			// Token: 0x0600007B RID: 123 RVA: 0x00002D42 File Offset: 0x00000F42
			internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
			{
				return this.convertBinder_0.FallbackConvert(this.dynamicProxyMetaObject_0, dynamicMetaObject_0);
			}

			// Token: 0x04000073 RID: 115
			public ConvertBinder convertBinder_0;

			// Token: 0x04000074 RID: 116
			public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;
		}

		// Token: 0x0200002A RID: 42
		[CompilerGenerated]
		private sealed class Class21
		{
			// Token: 0x0600007D RID: 125 RVA: 0x00002D56 File Offset: 0x00000F56
			internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
			{
				return this.invokeMemberBinder_0.FallbackInvokeMember(this.dynamicProxyMetaObject_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
			}

			// Token: 0x0600007E RID: 126 RVA: 0x00002D70 File Offset: 0x00000F70
			internal DynamicMetaObject method_1(DynamicMetaObject dynamicMetaObject_1)
			{
				return this.invokeMemberBinder_0.FallbackInvoke(dynamicMetaObject_1, this.dynamicMetaObject_0, null);
			}

			// Token: 0x04000075 RID: 117
			public InvokeMemberBinder invokeMemberBinder_0;

			// Token: 0x04000076 RID: 118
			public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

			// Token: 0x04000077 RID: 119
			public DynamicMetaObject[] dynamicMetaObject_0;
		}

		// Token: 0x0200002B RID: 43
		[CompilerGenerated]
		private sealed class Class22
		{
			// Token: 0x06000080 RID: 128 RVA: 0x00002D85 File Offset: 0x00000F85
			internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
			{
				return this.createInstanceBinder_0.FallbackCreateInstance(this.dynamicProxyMetaObject_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
			}

			// Token: 0x04000078 RID: 120
			public CreateInstanceBinder createInstanceBinder_0;

			// Token: 0x04000079 RID: 121
			public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

			// Token: 0x0400007A RID: 122
			public DynamicMetaObject[] dynamicMetaObject_0;
		}

		// Token: 0x0200002C RID: 44
		[CompilerGenerated]
		private sealed class Class23
		{
			// Token: 0x06000082 RID: 130 RVA: 0x00002D9F File Offset: 0x00000F9F
			internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
			{
				return this.invokeBinder_0.FallbackInvoke(this.dynamicProxyMetaObject_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
			}

			// Token: 0x0400007B RID: 123
			public InvokeBinder invokeBinder_0;

			// Token: 0x0400007C RID: 124
			public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

			// Token: 0x0400007D RID: 125
			public DynamicMetaObject[] dynamicMetaObject_0;
		}

		// Token: 0x0200002D RID: 45
		[CompilerGenerated]
		private sealed class Class24
		{
			// Token: 0x06000084 RID: 132 RVA: 0x00002DB9 File Offset: 0x00000FB9
			internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
			{
				return this.binaryOperationBinder_0.FallbackBinaryOperation(this.dynamicProxyMetaObject_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
			}

			// Token: 0x0400007E RID: 126
			public BinaryOperationBinder binaryOperationBinder_0;

			// Token: 0x0400007F RID: 127
			public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

			// Token: 0x04000080 RID: 128
			public DynamicMetaObject dynamicMetaObject_0;
		}

		// Token: 0x0200002E RID: 46
		[CompilerGenerated]
		private sealed class Class25
		{
			// Token: 0x06000086 RID: 134 RVA: 0x00002DD3 File Offset: 0x00000FD3
			internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
			{
				return this.unaryOperationBinder_0.FallbackUnaryOperation(this.dynamicProxyMetaObject_0, dynamicMetaObject_0);
			}

			// Token: 0x04000081 RID: 129
			public UnaryOperationBinder unaryOperationBinder_0;

			// Token: 0x04000082 RID: 130
			public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;
		}

		// Token: 0x0200002F RID: 47
		[CompilerGenerated]
		private sealed class Class26
		{
			// Token: 0x06000088 RID: 136 RVA: 0x00002DE7 File Offset: 0x00000FE7
			internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
			{
				return this.getIndexBinder_0.FallbackGetIndex(this.dynamicProxyMetaObject_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
			}

			// Token: 0x04000083 RID: 131
			public GetIndexBinder getIndexBinder_0;

			// Token: 0x04000084 RID: 132
			public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

			// Token: 0x04000085 RID: 133
			public DynamicMetaObject[] dynamicMetaObject_0;
		}

		// Token: 0x02000030 RID: 48
		[CompilerGenerated]
		private sealed class Class27
		{
			// Token: 0x0600008A RID: 138 RVA: 0x00002E01 File Offset: 0x00001001
			internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
			{
				return this.setIndexBinder_0.FallbackSetIndex(this.dynamicProxyMetaObject_0, this.dynamicMetaObject_0, this.value, dynamicMetaObject_1);
			}

			// Token: 0x04000086 RID: 134
			public SetIndexBinder setIndexBinder_0;

			// Token: 0x04000087 RID: 135
			public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

			// Token: 0x04000088 RID: 136
			public DynamicMetaObject[] dynamicMetaObject_0;

			// Token: 0x04000089 RID: 137
			public DynamicMetaObject value;
		}

		// Token: 0x02000031 RID: 49
		[CompilerGenerated]
		private sealed class Class28
		{
			// Token: 0x0600008C RID: 140 RVA: 0x00002E21 File Offset: 0x00001021
			internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
			{
				return this.deleteIndexBinder_0.FallbackDeleteIndex(this.dynamicProxyMetaObject_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
			}

			// Token: 0x0400008A RID: 138
			public DeleteIndexBinder deleteIndexBinder_0;

			// Token: 0x0400008B RID: 139
			public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

			// Token: 0x0400008C RID: 140
			public DynamicMetaObject[] dynamicMetaObject_0;
		}
	}
}
