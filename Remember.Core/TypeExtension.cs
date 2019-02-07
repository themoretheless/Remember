using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Remember.Core
{
    public static class TypeExtension
    {
        public static T GetAttribute<T>(this Type type) where T : Attribute
        {
            var t = type.GetCustomAttribute<T>();
            return t;
            //.GetCustomAttribute<T>();
        }
    }
}
