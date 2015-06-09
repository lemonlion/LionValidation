using System;
using System.ComponentModel;
using System.Reflection;

namespace LionValidation.Helpers
{
    public static class ExtensionMethods
    {  
        public static object GetPropertyValueWithDotNotation(this object obj, String name)
        {
            object finalObject = obj;
            foreach (string part in name.Split('.'))
            {
                if (finalObject == null)
                    return null;

                Type type = finalObject.GetType();
                PropertyInfo info = type.GetPropertyIncludeStatic(part);
                
                if (info == null)
                    return null;

                finalObject = info.GetValue(finalObject, null);
            }

            return finalObject;
        }

        public static object GetStaticPropertyValueWithDotNotation(this Type type, String name)
        {
            return type.GetPropertyInfoWithDotNotation(name).GetValue(new object(), null);
        }

        public static PropertyInfo GetPropertyInfoWithDotNotation(this Type type, String name)
        {
            PropertyInfo propertyInfo = type.GetPropertyIncludeStatic(name);
            
            if (name.Contains("."))
            {
                Type currentType = type;
                foreach (string part in name.Split('.'))
                {
                    propertyInfo = currentType.GetPropertyIncludeStatic(part);

                    if (propertyInfo == null)
                        return null;

                    currentType = propertyInfo.PropertyType;
                }
            }

            return propertyInfo;
        }

        public static string ToAsciiLetter(this int number, bool isCaps = false)
        {
            Char c = (Char)((isCaps ? 65 : 97) + (number - 1));
            return c.ToString();
        }

        public static string TrimEnd(this string source, string value)
        {
            if (!source.EndsWith(value))
                return source;

            return source.Remove(source.LastIndexOf(value));
        }

        public static bool IsInt(this string s)
        {
            int x;
            return int.TryParse(s, out x);
        }

        public static PropertyInfo GetPropertyIncludeStatic(this Type type, String name)
        {
            PropertyInfo propertyInfo = type.GetProperty(name, BindingFlags.Static | BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public);
            while (propertyInfo == null && type != typeof (Object))
            {
                type = type.BaseType;
                propertyInfo = type.GetProperty(name, BindingFlags.Static | BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public);
            }
            return propertyInfo;
        }

        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                        return attr.Description;
                }
            }

            //If we have no description attribute, just return the ToString of the enum
            return value.ToString();
        }

        public static string[] Split(this string value, string splitterValue)
        {
            return value.Split(new[] { splitterValue }, StringSplitOptions.None);
        }
    }
}