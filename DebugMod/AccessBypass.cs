using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Globalization;

namespace DebugMod
{
    internal static class AccessBypass
    {
        internal static T GetPrivateField<T>(this object obj, string name)
        {
            BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
            Type type = obj.GetType();
            FieldInfo field = type.GetField(name, flags);
            return (T)field.GetValue(obj);
        }
        internal static T GetPrivateProperty<T>(this object obj, string name)
        {
            BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
            Type type = obj.GetType();
            PropertyInfo property = type.GetProperty(name, flags);
            return (T)property.GetValue(obj, null);
        }
        internal static void SetPrivateField(this object obj, string name, object value)
        {
            BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
            Type type = obj.GetType();
            FieldInfo field = type.GetField(name, flags);
            field.SetValue(obj, value);
        }

        internal static void SetPrivateProperty(this object obj, string name, object value)
        {
            BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
            Type type = obj.GetType();
            PropertyInfo field = type.GetProperty(name, flags);
            field.SetValue(obj, value, null);
        }

        internal static T CallPrivateMethod<T>(this object obj, string methodName, params object[] parameters)
        {
            BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
            Type type = obj.GetType();
            MethodInfo method = type.GetMethod(methodName, flags);
            return (T)method.Invoke(obj, parameters);
        }
    }
}
