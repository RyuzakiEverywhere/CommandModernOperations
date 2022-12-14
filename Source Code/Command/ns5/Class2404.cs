using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;

namespace ns5
{
	// Token: 0x02000D4F RID: 3407
	internal static class Class2404
	{
		// Token: 0x06005929 RID: 22825 RVA: 0x00039775 File Offset: 0x00037975
		public static Type smethod_0(object object_0)
		{
			if (object_0 == null)
			{
				return null;
			}
			return object_0.GetType();
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x00314E40 File Offset: 0x00313040
		public static string smethod_1(Type type_0, FormatterAssemblyStyle formatterAssemblyStyle_0)
		{
			switch (formatterAssemblyStyle_0)
			{
			case FormatterAssemblyStyle.Simple:
				return type_0.FullName + ", " + type_0.Assembly.GetName().Name;
			case FormatterAssemblyStyle.Full:
				return type_0.AssemblyQualifiedName;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x00314E8C File Offset: 0x0031308C
		public static bool smethod_2(Type type_0)
		{
			Class2409.smethod_4(type_0, "t");
			if (!type_0.IsAbstract && !type_0.IsInterface && !type_0.IsArray && !type_0.IsGenericTypeDefinition)
			{
				if (type_0 != typeof(void))
				{
					return Class2404.smethod_3(type_0);
				}
			}
			return false;
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x00039782 File Offset: 0x00037982
		public static bool smethod_3(Type type_0)
		{
			return Class2404.smethod_4(type_0, false);
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x0003978B File Offset: 0x0003798B
		public static bool smethod_4(Type type_0, bool bool_0)
		{
			Class2409.smethod_4(type_0, "t");
			return type_0.IsValueType || Class2404.smethod_6(type_0, bool_0) != null;
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x000397AF File Offset: 0x000379AF
		public static ConstructorInfo smethod_5(Type type_0)
		{
			return Class2404.smethod_6(type_0, false);
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x00314EE0 File Offset: 0x003130E0
		public static ConstructorInfo smethod_6(Type type_0, bool bool_0)
		{
			BindingFlags bindingFlags = BindingFlags.Public;
			if (bool_0)
			{
				bindingFlags |= BindingFlags.NonPublic;
			}
			return type_0.GetConstructor(bindingFlags | BindingFlags.Instance, null, new Type[0], null);
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x000397B8 File Offset: 0x000379B8
		public static bool smethod_7(Type type_0)
		{
			Class2409.smethod_4(type_0, "t");
			return !type_0.IsValueType || Class2404.smethod_8(type_0);
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x000397D5 File Offset: 0x000379D5
		public static bool smethod_8(Type type_0)
		{
			Class2409.smethod_4(type_0, "t");
			return type_0.IsGenericType && type_0.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x00314F0C File Offset: 0x0031310C
		public static bool smethod_9(Type type_0, Type type_1)
		{
			Type type;
			return Class2404.smethod_10(type_0, type_1, out type);
		}

		// Token: 0x06005933 RID: 22835 RVA: 0x00314F24 File Offset: 0x00313124
		public static bool smethod_10(Type type, Type genericInterfaceDefinition, out Type implementingType)
		{
			Class2409.smethod_4(type, "type");
			Class2409.smethod_4(genericInterfaceDefinition, "genericInterfaceDefinition");
			if (genericInterfaceDefinition.IsInterface && genericInterfaceDefinition.IsGenericTypeDefinition)
			{
				if (type.IsInterface && type.IsGenericType)
				{
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					if (genericInterfaceDefinition == genericTypeDefinition)
					{
						implementingType = type;
						return true;
					}
				}
				foreach (Type type2 in type.GetInterfaces())
				{
					if (type2.IsGenericType)
					{
						Type genericTypeDefinition2 = type2.GetGenericTypeDefinition();
						if (genericInterfaceDefinition == genericTypeDefinition2)
						{
							implementingType = type2;
							return true;
						}
					}
				}
				implementingType = null;
				return false;
			}
			throw new ArgumentNullException(Class2407.smethod_0("'{0}' is not a generic interface definition.", CultureInfo.InvariantCulture, new object[]
			{
				genericInterfaceDefinition
			}));
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x00314FE0 File Offset: 0x003131E0
		public static bool smethod_11(Type type, string fullTypeName, out Type match)
		{
			for (Type type2 = type; type2 != null; type2 = type2.BaseType)
			{
				if (string.Equals(type2.FullName, fullTypeName, StringComparison.Ordinal))
				{
					match = type2;
					return true;
				}
			}
			foreach (Type type3 in type.GetInterfaces())
			{
				if (string.Equals(type3.Name, fullTypeName, StringComparison.Ordinal))
				{
					match = type;
					return true;
				}
			}
			match = null;
			return false;
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x0031504C File Offset: 0x0031324C
		public static bool smethod_12(Type type_0, string string_0)
		{
			Type type;
			return Class2404.smethod_11(type_0, string_0, out type);
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x00315064 File Offset: 0x00313264
		public static bool smethod_13(Type type_0, Type type_1)
		{
			Type type;
			return Class2404.smethod_14(type_0, type_1, out type);
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x0031507C File Offset: 0x0031327C
		public static bool smethod_14(Type type, Type genericClassDefinition, out Type implementingType)
		{
			Class2409.smethod_4(type, "type");
			Class2409.smethod_4(genericClassDefinition, "genericClassDefinition");
			if (!genericClassDefinition.IsClass || !genericClassDefinition.IsGenericTypeDefinition)
			{
				throw new ArgumentNullException(Class2407.smethod_0("'{0}' is not a generic class definition.", CultureInfo.InvariantCulture, new object[]
				{
					genericClassDefinition
				}));
			}
			return Class2404.smethod_15(type, genericClassDefinition, out implementingType);
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x003150D8 File Offset: 0x003132D8
		private static bool smethod_15(Type currentType, Type genericClassDefinition, out Type implementingType)
		{
			if (currentType.IsGenericType)
			{
				Type genericTypeDefinition = currentType.GetGenericTypeDefinition();
				if (genericClassDefinition == genericTypeDefinition)
				{
					implementingType = currentType;
					return true;
				}
			}
			if (currentType.BaseType == null)
			{
				implementingType = null;
				return false;
			}
			return Class2404.smethod_15(currentType.BaseType, genericClassDefinition, out implementingType);
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x00315118 File Offset: 0x00313318
		public static Type smethod_16(Type type_0)
		{
			Class2409.smethod_4(type_0, "type");
			if (type_0.IsArray)
			{
				return type_0.GetElementType();
			}
			Type type;
			if (Class2404.smethod_10(type_0, typeof(IEnumerable<>), out type))
			{
				if (type.IsGenericTypeDefinition)
				{
					throw new Exception(Class2407.smethod_0("Type {0} is not a collection.", CultureInfo.InvariantCulture, new object[]
					{
						type_0
					}));
				}
				return type.GetGenericArguments()[0];
			}
			else
			{
				if (!typeof(IEnumerable).IsAssignableFrom(type_0))
				{
					throw new Exception(Class2407.smethod_0("Type {0} is not a collection.", CultureInfo.InvariantCulture, new object[]
					{
						type_0
					}));
				}
				return null;
			}
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x003151BC File Offset: 0x003133BC
		public static void smethod_17(Type dictionaryType, out Type keyType, out Type valueType)
		{
			Class2409.smethod_4(dictionaryType, "type");
			Type type;
			if (Class2404.smethod_10(dictionaryType, typeof(IDictionary<, >), out type))
			{
				if (type.IsGenericTypeDefinition)
				{
					throw new Exception(Class2407.smethod_0("Type {0} is not a dictionary.", CultureInfo.InvariantCulture, new object[]
					{
						dictionaryType
					}));
				}
				Type[] genericArguments = type.GetGenericArguments();
				keyType = genericArguments[0];
				valueType = genericArguments[1];
				return;
			}
			else
			{
				if (!typeof(IDictionary).IsAssignableFrom(dictionaryType))
				{
					throw new Exception(Class2407.smethod_0("Type {0} is not a dictionary.", CultureInfo.InvariantCulture, new object[]
					{
						dictionaryType
					}));
				}
				keyType = null;
				valueType = null;
				return;
			}
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x0031525C File Offset: 0x0031345C
		public static Type smethod_18(MemberInfo memberInfo_0)
		{
			Class2409.smethod_4(memberInfo_0, "member");
			MemberTypes memberType = memberInfo_0.MemberType;
			switch (memberType)
			{
			case MemberTypes.Event:
				return ((EventInfo)memberInfo_0).EventHandlerType;
			case MemberTypes.Constructor | MemberTypes.Event:
				break;
			case MemberTypes.Field:
				return ((FieldInfo)memberInfo_0).FieldType;
			default:
				if (memberType == MemberTypes.Property)
				{
					return ((PropertyInfo)memberInfo_0).PropertyType;
				}
				break;
			}
			throw new ArgumentException("MemberInfo must be of type FieldInfo, PropertyInfo or EventInfo", "member");
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x003152CC File Offset: 0x003134CC
		public static bool smethod_19(MemberInfo memberInfo_0)
		{
			Class2409.smethod_4(memberInfo_0, "member");
			PropertyInfo propertyInfo = memberInfo_0 as PropertyInfo;
			return propertyInfo != null && Class2404.smethod_20(propertyInfo);
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x000397FE File Offset: 0x000379FE
		public static bool smethod_20(PropertyInfo propertyInfo_0)
		{
			Class2409.smethod_4(propertyInfo_0, "property");
			return propertyInfo_0.GetIndexParameters().Length > 0;
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x003152F8 File Offset: 0x003134F8
		public static object smethod_21(MemberInfo memberInfo_0, object object_0)
		{
			Class2409.smethod_4(memberInfo_0, "member");
			Class2409.smethod_4(object_0, "target");
			MemberTypes memberType = memberInfo_0.MemberType;
			if (memberType == MemberTypes.Field)
			{
				return ((FieldInfo)memberInfo_0).GetValue(object_0);
			}
			if (memberType != MemberTypes.Property)
			{
				throw new ArgumentException(Class2407.smethod_0("MemberInfo '{0}' is not of type FieldInfo or PropertyInfo", CultureInfo.InvariantCulture, new object[]
				{
					CultureInfo.InvariantCulture,
					memberInfo_0.Name
				}), "member");
			}
			object value;
			try
			{
				value = ((PropertyInfo)memberInfo_0).GetValue(object_0, null);
			}
			catch (TargetParameterCountException innerException)
			{
				throw new ArgumentException(Class2407.smethod_0("MemberInfo '{0}' has index parameters", CultureInfo.InvariantCulture, new object[]
				{
					memberInfo_0.Name
				}), innerException);
			}
			return value;
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x003153B8 File Offset: 0x003135B8
		public static void smethod_22(MemberInfo memberInfo_0, object object_0, object object_1)
		{
			Class2409.smethod_4(memberInfo_0, "member");
			Class2409.smethod_4(object_0, "target");
			MemberTypes memberType = memberInfo_0.MemberType;
			if (memberType == MemberTypes.Field)
			{
				((FieldInfo)memberInfo_0).SetValue(object_0, object_1);
				return;
			}
			if (memberType != MemberTypes.Property)
			{
				throw new ArgumentException(Class2407.smethod_0("MemberInfo '{0}' must be of type FieldInfo or PropertyInfo", CultureInfo.InvariantCulture, new object[]
				{
					memberInfo_0.Name
				}), "member");
			}
			((PropertyInfo)memberInfo_0).SetValue(object_0, object_1, null);
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x00315434 File Offset: 0x00313634
		public static bool smethod_23(MemberInfo memberInfo_0, bool bool_0)
		{
			MemberTypes memberType = memberInfo_0.MemberType;
			if (memberType == MemberTypes.Field)
			{
				FieldInfo fieldInfo = (FieldInfo)memberInfo_0;
				return bool_0 || fieldInfo.IsPublic;
			}
			if (memberType != MemberTypes.Property)
			{
				return false;
			}
			PropertyInfo propertyInfo = (PropertyInfo)memberInfo_0;
			return propertyInfo.CanRead && (bool_0 || propertyInfo.GetGetMethod(bool_0) != null);
		}

		// Token: 0x06005941 RID: 22849 RVA: 0x00315490 File Offset: 0x00313690
		public static bool smethod_24(MemberInfo memberInfo_0, bool bool_0)
		{
			MemberTypes memberType = memberInfo_0.MemberType;
			if (memberType == MemberTypes.Field)
			{
				FieldInfo fieldInfo = (FieldInfo)memberInfo_0;
				return !fieldInfo.IsInitOnly && (bool_0 || fieldInfo.IsPublic);
			}
			if (memberType != MemberTypes.Property)
			{
				return false;
			}
			PropertyInfo propertyInfo = (PropertyInfo)memberInfo_0;
			return propertyInfo.CanWrite && (bool_0 || propertyInfo.GetSetMethod(bool_0) != null);
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x003154F4 File Offset: 0x003136F4
		public static List<MemberInfo> smethod_25(Type type_0, BindingFlags bindingFlags_0)
		{
			Func<MemberInfo, bool> func = null;
			Class2404.Class2405 @class = new Class2404.Class2405();
			@class.bindingFlags_0 = bindingFlags_0;
			List<MemberInfo> list = new List<MemberInfo>();
			Class2399.smethod_2(list, Class2404.smethod_36(type_0, @class.bindingFlags_0));
			Class2399.smethod_2(list, Class2404.smethod_38(type_0, @class.bindingFlags_0));
			List<MemberInfo> list2 = new List<MemberInfo>(list.Count);
			IEnumerable<MemberInfo> enumerable = list;
			if (Class2404.func_0 == null)
			{
				Class2404.func_0 = new Func<MemberInfo, string>(Class2404.smethod_41);
			}
			IEnumerable<IGrouping<string, MemberInfo>> enumerable2 = Enumerable.GroupBy<MemberInfo, string>(enumerable, Class2404.func_0);
			if (Class2404.func_1 == null)
			{
				Class2404.func_1 = new Func<IGrouping<string, MemberInfo>, Class2410<int, IEnumerable<MemberInfo>>>(Class2404.smethod_42);
			}
			IEnumerable<Class2410<int, IEnumerable<MemberInfo>>> enumerable3 = Enumerable.Select<IGrouping<string, MemberInfo>, Class2410<int, IEnumerable<MemberInfo>>>(enumerable2, Class2404.func_1);
			foreach (Class2410<int, IEnumerable<MemberInfo>> class2 in enumerable3)
			{
				if (class2.method_0() == 1)
				{
					list2.Add(Enumerable.First<MemberInfo>(class2.method_1()));
				}
				else
				{
					IEnumerable<MemberInfo> enumerable4 = class2.method_1();
					if (func == null)
					{
						func = new Func<MemberInfo, bool>(@class.method_0);
					}
					IEnumerable<MemberInfo> collection = Enumerable.Where<MemberInfo>(enumerable4, func);
					list2.AddRange(collection);
				}
			}
			return list2;
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x00315614 File Offset: 0x00313814
		private static bool smethod_26(MemberInfo memberInfo_0, BindingFlags bindingFlags_0)
		{
			if (memberInfo_0.MemberType != MemberTypes.Field && memberInfo_0.MemberType != MemberTypes.Property)
			{
				throw new ArgumentException("Member must be a field or property.");
			}
			Type declaringType = memberInfo_0.DeclaringType;
			if (!declaringType.IsGenericType)
			{
				return false;
			}
			Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
			if (genericTypeDefinition == null)
			{
				return false;
			}
			MemberInfo[] member = genericTypeDefinition.GetMember(memberInfo_0.Name, bindingFlags_0);
			if (member.Length == 0)
			{
				return false;
			}
			Type type = Class2404.smethod_18(member[0]);
			return type.IsGenericParameter;
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x00315688 File Offset: 0x00313888
		public static T smethod_27<T>(ICustomAttributeProvider icustomAttributeProvider_0, bool bool_0) where T : Attribute
		{
			T[] ilist_ = Class2404.smethod_28<T>(icustomAttributeProvider_0, bool_0);
			return Class2399.smethod_3<T>(ilist_, true);
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x00039816 File Offset: 0x00037A16
		public static T[] smethod_28<T>(ICustomAttributeProvider icustomAttributeProvider_0, bool bool_0) where T : Attribute
		{
			Class2409.smethod_4(icustomAttributeProvider_0, "attributeProvider");
			return (T[])icustomAttributeProvider_0.GetCustomAttributes(typeof(T), bool_0);
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x003156A4 File Offset: 0x003138A4
		public static Type smethod_29(Type type_0, Type[] type_1)
		{
			Class2409.smethod_4(type_0, "genericTypeDefinition");
			Class2409.smethod_2<Type>(type_1, "innerTypes");
			Class2409.smethod_5(type_0.IsGenericTypeDefinition, "genericTypeDefinition", Class2407.smethod_0("Type {0} is not a generic type definition.", CultureInfo.InvariantCulture, new object[]
			{
				type_0
			}));
			return type_0.MakeGenericType(type_1);
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x003156FC File Offset: 0x003138FC
		public static object smethod_30(Type type_0, Type type_1, object[] object_0)
		{
			return Class2404.smethod_31(type_0, new Type[]
			{
				type_1
			}, object_0);
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x00039839 File Offset: 0x00037A39
		public static object smethod_31(Type type_0, IList<Type> ilist_0, object[] object_0)
		{
			if (Class2404.func_2 == null)
			{
				Class2404.func_2 = new Func<Type, IList<object>, object>(Class2404.smethod_43);
			}
			return Class2404.smethod_32(type_0, ilist_0, Class2404.func_2, object_0);
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x0031571C File Offset: 0x0031391C
		public static object smethod_32(Type type_0, IList<Type> ilist_0, Func<Type, IList<object>, object> func_4, object[] object_0)
		{
			Class2409.smethod_4(type_0, "genericTypeDefinition");
			Class2409.smethod_2<Type>(ilist_0, "innerTypes");
			Class2409.smethod_4(func_4, "createInstance");
			Type arg = Class2404.smethod_29(type_0, Enumerable.ToArray<Type>(ilist_0));
			return func_4(arg, object_0);
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x00039860 File Offset: 0x00037A60
		public static object smethod_33(Type type_0, object[] object_0)
		{
			Class2409.smethod_4(type_0, "type");
			return Activator.CreateInstance(type_0, object_0);
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x00315760 File Offset: 0x00313960
		public static void smethod_34(string fullyQualifiedTypeName, out string typeName, out string assemblyName)
		{
			int? num = Class2404.smethod_35(fullyQualifiedTypeName);
			if (num != null)
			{
				typeName = fullyQualifiedTypeName.Substring(0, num.Value).Trim();
				assemblyName = fullyQualifiedTypeName.Substring(num.Value + 1, fullyQualifiedTypeName.Length - num.Value - 1).Trim();
				return;
			}
			typeName = fullyQualifiedTypeName;
			assemblyName = null;
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x003157C0 File Offset: 0x003139C0
		private static int? smethod_35(string string_0)
		{
			int num = 0;
			for (int i = 0; i < string_0.Length; i++)
			{
				char c = string_0[i];
				char c2 = c;
				if (c2 != ',')
				{
					switch (c2)
					{
					case '[':
						num++;
						break;
					case ']':
						num--;
						break;
					}
				}
				else if (num == 0)
				{
					return new int?(i);
				}
			}
			return null;
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x00315828 File Offset: 0x00313A28
		public static IEnumerable<FieldInfo> smethod_36(Type type_0, BindingFlags bindingFlags_0)
		{
			Class2409.smethod_4(type_0, "targetType");
			List<MemberInfo> list = new List<MemberInfo>(type_0.GetFields(bindingFlags_0));
			Class2404.smethod_37(list, type_0, bindingFlags_0);
			return Enumerable.Cast<FieldInfo>(list);
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x0031585C File Offset: 0x00313A5C
		private static void smethod_37(IList<MemberInfo> ilist_0, Type type_0, BindingFlags bindingFlags_0)
		{
			if ((bindingFlags_0 & BindingFlags.NonPublic) != BindingFlags.Default)
			{
				BindingFlags bindingAttr = Class2404.smethod_39(bindingFlags_0, BindingFlags.Public);
				while ((type_0 = type_0.BaseType) != null)
				{
					IEnumerable<FieldInfo> fields = type_0.GetFields(bindingAttr);
					if (Class2404.func_3 == null)
					{
						Class2404.func_3 = new Func<FieldInfo, bool>(Class2404.smethod_44);
					}
					IEnumerable<MemberInfo> ienumerable_ = Enumerable.Cast<MemberInfo>(Enumerable.Where<FieldInfo>(fields, Class2404.func_3));
					Class2399.smethod_1<MemberInfo>(ilist_0, ienumerable_);
				}
			}
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x003158BC File Offset: 0x00313ABC
		public static IEnumerable<PropertyInfo> smethod_38(Type type_0, BindingFlags bindingFlags_0)
		{
			Class2409.smethod_4(type_0, "targetType");
			List<MemberInfo> list = new List<MemberInfo>(type_0.GetProperties(bindingFlags_0));
			Class2404.smethod_40(list, type_0, bindingFlags_0);
			return Enumerable.Cast<PropertyInfo>(list);
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x00039874 File Offset: 0x00037A74
		public static BindingFlags smethod_39(BindingFlags bindingFlags_0, BindingFlags bindingFlags_1)
		{
			if ((bindingFlags_0 & bindingFlags_1) != bindingFlags_1)
			{
				return bindingFlags_0;
			}
			return bindingFlags_0 ^ bindingFlags_1;
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x003158F0 File Offset: 0x00313AF0
		private static void smethod_40(IList<MemberInfo> ilist_0, Type type_0, BindingFlags bindingFlags_0)
		{
			if ((bindingFlags_0 & BindingFlags.NonPublic) != BindingFlags.Default)
			{
				BindingFlags bindingAttr = Class2404.smethod_39(bindingFlags_0, BindingFlags.Public);
				while ((type_0 = type_0.BaseType) != null)
				{
					foreach (PropertyInfo propertyInfo_ in type_0.GetProperties(bindingAttr))
					{
						Class2404.Class2406 @class = new Class2404.Class2406();
						@class.propertyInfo_0 = propertyInfo_;
						int num = Class2399.smethod_13<MemberInfo>(ilist_0, new Func<MemberInfo, bool>(@class.method_0));
						if (num == -1)
						{
							ilist_0.Add(@class.propertyInfo_0);
						}
						else
						{
							ilist_0[num] = @class.propertyInfo_0;
						}
					}
				}
			}
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x00038797 File Offset: 0x00036997
		[CompilerGenerated]
		private static string smethod_41(MemberInfo memberInfo_0)
		{
			return memberInfo_0.Name;
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x00039881 File Offset: 0x00037A81
		[CompilerGenerated]
		private static Class2410<int, IEnumerable<MemberInfo>> smethod_42(IGrouping<string, MemberInfo> igrouping_0)
		{
			return new Class2410<int, IEnumerable<MemberInfo>>(Enumerable.Count<MemberInfo>(igrouping_0), Enumerable.Cast<MemberInfo>(igrouping_0));
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x00039894 File Offset: 0x00037A94
		[CompilerGenerated]
		private static object smethod_43(Type type_0, IList<object> ilist_0)
		{
			return Class2404.smethod_33(type_0, Enumerable.ToArray<object>(ilist_0));
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x000398A2 File Offset: 0x00037AA2
		[CompilerGenerated]
		private static bool smethod_44(FieldInfo fieldInfo_0)
		{
			return fieldInfo_0.IsPrivate;
		}

		// Token: 0x04003409 RID: 13321
		[CompilerGenerated]
		private static Func<MemberInfo, string> func_0;

		// Token: 0x0400340A RID: 13322
		[CompilerGenerated]
		private static Func<IGrouping<string, MemberInfo>, Class2410<int, IEnumerable<MemberInfo>>> func_1;

		// Token: 0x0400340B RID: 13323
		[CompilerGenerated]
		private static Func<Type, IList<object>, object> func_2;

		// Token: 0x0400340C RID: 13324
		[CompilerGenerated]
		private static Func<FieldInfo, bool> func_3;

		// Token: 0x02000D50 RID: 3408
		[CompilerGenerated]
		private sealed class Class2405
		{
			// Token: 0x06005957 RID: 22871 RVA: 0x000398AA File Offset: 0x00037AAA
			public bool method_0(MemberInfo memberInfo_0)
			{
				return !Class2404.smethod_26(memberInfo_0, this.bindingFlags_0) || memberInfo_0.Name == "Item";
			}

			// Token: 0x0400340D RID: 13325
			public BindingFlags bindingFlags_0;
		}

		// Token: 0x02000D51 RID: 3409
		[CompilerGenerated]
		private sealed class Class2406
		{
			// Token: 0x06005959 RID: 22873 RVA: 0x000398CC File Offset: 0x00037ACC
			public bool method_0(MemberInfo memberInfo_0)
			{
				return memberInfo_0.Name == this.propertyInfo_0.Name;
			}

			// Token: 0x0400340E RID: 13326
			public PropertyInfo propertyInfo_0;
		}
	}
}
