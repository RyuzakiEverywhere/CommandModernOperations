using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns35;

namespace ns5
{
	// Token: 0x02000D49 RID: 3401
	internal static class Class2399
	{
		// Token: 0x060058EA RID: 22762 RVA: 0x00039322 File Offset: 0x00037522
		public static bool smethod_0<T>(ICollection<T> icollection_0)
		{
			return icollection_0 == null || icollection_0.Count == 0;
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x003146A8 File Offset: 0x003128A8
		public static void smethod_1<T>(IList<T> ilist_0, IEnumerable<T> ienumerable_0)
		{
			if (ilist_0 == null)
			{
				throw new ArgumentNullException("initial");
			}
			if (ienumerable_0 == null)
			{
				return;
			}
			foreach (T item in ienumerable_0)
			{
				ilist_0.Add(item);
			}
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x00314704 File Offset: 0x00312904
		public static void smethod_2(IList ilist_0, IEnumerable ienumerable_0)
		{
			Class2409.smethod_4(ilist_0, "initial");
			Class2401<object> ilist_ = new Class2401<object>(ilist_0);
			Class2399.smethod_1<object>(ilist_, Enumerable.Cast<object>(ienumerable_0));
		}

		// Token: 0x060058ED RID: 22765 RVA: 0x00314730 File Offset: 0x00312930
		public static T smethod_3<T>(IList<T> ilist_0, bool bool_0)
		{
			if (ilist_0.Count == 1)
			{
				return ilist_0[0];
			}
			if (!bool_0 || ilist_0.Count != 0)
			{
				throw new Exception(Class2407.smethod_0("Expected single {0} in list but got {1}.", CultureInfo.InvariantCulture, new object[]
				{
					typeof(T),
					ilist_0.Count
				}));
			}
			return default(T);
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x00039332 File Offset: 0x00037532
		public static IList smethod_4(Type type_0)
		{
			Class2409.smethod_4(type_0, "listType");
			return (IList)Class2404.smethod_30(typeof(List<>), type_0, new object[0]);
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x0003935A File Offset: 0x0003755A
		public static bool smethod_5(Type type_0)
		{
			Class2409.smethod_4(type_0, "type");
			return typeof(IDictionary).IsAssignableFrom(type_0) || Class2404.smethod_9(type_0, typeof(IDictionary<, >));
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x0031479C File Offset: 0x0031299C
		public static Interface64 smethod_6(object object_0)
		{
			Func<Type, IList<object>, object> func = null;
			Class2399.Class2400 @class = new Class2399.Class2400();
			@class.object_0 = object_0;
			Class2409.smethod_4(@class.object_0, "list");
			if (Class2404.smethod_10(@class.object_0.GetType(), typeof(ICollection<>), out @class.type_0))
			{
				Type type = Class2404.smethod_16(@class.type_0);
				if (func == null)
				{
					func = new Func<Type, IList<object>, object>(@class.method_0);
				}
				Func<Type, IList<object>, object> func_ = func;
				return (Interface64)Class2404.smethod_32(typeof(Class2391<>), new Type[]
				{
					type
				}, func_, new object[]
				{
					@class.object_0
				});
			}
			if (!(@class.object_0 is IList))
			{
				throw new Exception(Class2407.smethod_0("Can not create ListWrapper for type {0}.", CultureInfo.InvariantCulture, new object[]
				{
					@class.object_0.GetType()
				}));
			}
			return new Class2391<object>((IList)@class.object_0);
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x0031488C File Offset: 0x00312A8C
		public static object smethod_7(Type type_0, Action<IList, bool> action_0)
		{
			Class2409.smethod_4(type_0, "listType");
			Class2409.smethod_4(action_0, "populateList");
			bool flag = false;
			IList list;
			if (type_0.IsArray)
			{
				list = new List<object>();
				flag = true;
			}
			else
			{
				Type type;
				if (Class2404.smethod_14(type_0, typeof(ReadOnlyCollection<>), out type))
				{
					Type type2 = type.GetGenericArguments()[0];
					Type type3 = Class2404.smethod_29(typeof(IEnumerable<>), new Type[]
					{
						type2
					});
					bool flag2 = false;
					ConstructorInfo[] constructors = type_0.GetConstructors();
					int i = 0;
					while (i < constructors.Length)
					{
						ConstructorInfo constructorInfo = constructors[i];
						IList<ParameterInfo> parameters = constructorInfo.GetParameters();
						if (parameters.Count != 1 || !type3.IsAssignableFrom(parameters[0].ParameterType))
						{
							i++;
						}
						else
						{
							flag2 = true;
							IL_C0:
							if (!flag2)
							{
								throw new Exception(Class2407.smethod_0("Read-only type {0} does not have a public constructor that takes a type that implements {1}.", CultureInfo.InvariantCulture, new object[]
								{
									type_0,
									type3
								}));
							}
							list = Class2399.smethod_4(type2);
							flag = true;
							goto IL_168;
						}
					}
					goto IL_C0;
				}
				if (typeof(IList).IsAssignableFrom(type_0))
				{
					if (Class2404.smethod_2(type_0))
					{
						list = (IList)Activator.CreateInstance(type_0);
					}
					else if (type_0 == typeof(IList))
					{
						list = new List<object>();
					}
					else
					{
						list = null;
					}
				}
				else if (Class2404.smethod_9(type_0, typeof(ICollection<>)))
				{
					if (Class2404.smethod_2(type_0))
					{
						list = Class2399.smethod_6(Activator.CreateInstance(type_0));
					}
					else
					{
						list = null;
					}
				}
				else
				{
					list = null;
				}
			}
			IL_168:
			if (list == null)
			{
				throw new Exception(Class2407.smethod_0("Cannot create and populate list type {0}.", CultureInfo.InvariantCulture, new object[]
				{
					type_0
				}));
			}
			action_0(list, flag);
			if (flag)
			{
				if (type_0.IsArray)
				{
					list = Class2399.smethod_8(((List<object>)list).ToArray(), Class2404.smethod_16(type_0));
				}
				else if (Class2404.smethod_13(type_0, typeof(ReadOnlyCollection<>)))
				{
					list = (IList)Class2404.smethod_33(type_0, new object[]
					{
						list
					});
				}
			}
			else if (list is Interface64)
			{
				return ((Interface64)list).imethod_0();
			}
			return list;
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x00314A98 File Offset: 0x00312C98
		public static Array smethod_8(Array array_0, Type type_0)
		{
			if (type_0 == null)
			{
				throw new ArgumentNullException("type");
			}
			Array array = Array.CreateInstance(type_0, array_0.Length);
			Array.Copy(array_0, 0, array, 0, array_0.Length);
			return array;
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x00039390 File Offset: 0x00037590
		public static bool smethod_9<T>(IList<T> ilist_0, T gparam_0)
		{
			return Class2399.smethod_10<T>(ilist_0, gparam_0, EqualityComparer<T>.Default);
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x0003939E File Offset: 0x0003759E
		public static bool smethod_10<T>(IList<T> ilist_0, T gparam_0, IEqualityComparer<T> iequalityComparer_0)
		{
			if (Class2399.smethod_11<T>(ilist_0, gparam_0, iequalityComparer_0))
			{
				return false;
			}
			ilist_0.Add(gparam_0);
			return true;
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x00314AD0 File Offset: 0x00312CD0
		public static bool smethod_11<TSource>(IEnumerable<TSource> ienumerable_0, TSource gparam_0, IEqualityComparer<TSource> iequalityComparer_0)
		{
			if (iequalityComparer_0 == null)
			{
				iequalityComparer_0 = EqualityComparer<TSource>.Default;
			}
			if (ienumerable_0 == null)
			{
				throw new ArgumentNullException("source");
			}
			foreach (TSource x in ienumerable_0)
			{
				if (iequalityComparer_0.Equals(x, gparam_0))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x00314B3C File Offset: 0x00312D3C
		public static bool smethod_12<T>(IList<T> ilist_0, IEnumerable<T> ienumerable_0, IEqualityComparer<T> iequalityComparer_0)
		{
			bool result = true;
			foreach (T gparam_ in ienumerable_0)
			{
				if (!Class2399.smethod_10<T>(ilist_0, gparam_, iequalityComparer_0))
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x00314B90 File Offset: 0x00312D90
		public static int smethod_13<T>(IEnumerable<T> ienumerable_0, Func<T, bool> func_0)
		{
			int num = 0;
			foreach (T arg in ienumerable_0)
			{
				if (func_0(arg))
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		// Token: 0x02000D4A RID: 3402
		[CompilerGenerated]
		private sealed class Class2400
		{
			// Token: 0x060058F9 RID: 22777 RVA: 0x00314BE8 File Offset: 0x00312DE8
			public object method_0(Type type_1, IList<object> ilist_0)
			{
				ConstructorInfo constructor = type_1.GetConstructor(new Type[]
				{
					this.type_0
				});
				return constructor.Invoke(new object[]
				{
					this.object_0
				});
			}

			// Token: 0x04003404 RID: 13316
			public Type type_0;

			// Token: 0x04003405 RID: 13317
			public object object_0;
		}
	}
}
