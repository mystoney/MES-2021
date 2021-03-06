#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.Reflection.Emit;

namespace System.Reflection
{
    /// <summary>
    /// 为类型成员(FieldInfo, PropertyInfo)提供一个适配器
    /// </summary>
    public abstract class MemberAdapter
    {
        /// <summary>
        /// 成员名
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// 成员类型
        /// </summary>
        public abstract Type MemberType { get; }

        /// <summary>
        /// 是否为属性
        /// </summary>
        public abstract bool IsProperty { get; }

        /// <summary>
        /// 成员属性的信息
        /// </summary>
        /// <returns></returns>
        public abstract MemberInfo MemberInfo { get; }


        /// <summary>
        /// 获取自定义属性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inherit"></param>
        /// <returns></returns>
        public abstract T[] GetAttributes<T>(bool inherit) where T : Attribute;

        /// <summary>
        /// 获取自定义属性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inherit"></param>
        /// <returns></returns>
        public abstract T GetAttribute<T>(bool inherit) where T : Attribute;

        /// <summary>
        /// 是否具有指定自定义属性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inherit"></param>
        /// <returns></returns>
        public abstract bool HasAttribute<T>(bool inherit) where T : Attribute;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inherit"></param>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public abstract bool HasAttribute<T>(bool inherit, out T attribute) where T : Attribute;

        /// <summary>
        /// 设置成员值
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        public abstract void SetValue(object obj, object value);

        /// <summary>
        /// 获取成员值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public abstract object GetValue(object obj);

        public abstract void EmitSet(ILGenerator il);
        public abstract void EmitGet(ILGenerator il);

        #region New

        public static MemberAdapter New(MemberInfo mi)
        {
            if (mi is FieldInfo)
            {
                return MemberAdapter.New((FieldInfo)mi);
            }
            else if (mi is PropertyInfo)
            {
                return MemberAdapter.New((PropertyInfo)mi);
            }
            else if (mi is MethodInfo)
            {
                return MemberAdapter.New((MethodInfo)mi);
            }
            else if (mi is ConstructorInfo)
            {
                return MemberAdapter.New((ConstructorInfo)mi);
            }
            return null;
        }

        internal static MemberAdapter New(FieldInfo fi)
        {
            if (fi.FieldType == typeof(ulong) || fi.FieldType == typeof(uint) || fi.FieldType == typeof(ushort))
            {
                return new UnsignedFieldAdapter(fi);
            }
            return new FieldAdapter(fi);
        }

        internal static MemberAdapter New(PropertyInfo pi)
        {
            if (pi.PropertyType == typeof(ulong) || pi.PropertyType == typeof(uint) || pi.PropertyType == typeof(ushort))
            {
                return new UnsignedPropertyAdapter(pi);
            }
            return new PropertyAdapter(pi);
        }

        internal static MemberAdapter New(MethodInfo mi)
        {
            return new MethodAdapter(mi);
        }

        internal static MemberAdapter New(ConstructorInfo ci)
        {
            return new ConstructorAdapter(ci);
        }

        #endregion
    }

    #region FieldAdapter

    /// <summary>
    /// 字段成员适配器
    /// </summary>
    internal class FieldAdapter : MemberAdapter
    {
        protected FieldInfo fi;

        public FieldAdapter(FieldInfo fi)
        {
            this.fi = fi;
        }

        public override Type MemberType
        {
            get { return fi.FieldType; }
        }

        public override MemberInfo MemberInfo
        {
            get { return this.fi; }
        }

        public override bool IsProperty
        {
            get { return false; }
        }

        public override string Name
        {
            get { return fi.Name; }
        }

        public override T GetAttribute<T>(bool inherit)
        {
            return fi.Attribute<T>();
            //return ClassHelper.GetAttribute<T>(fi, inherit);
        }

        public override T[] GetAttributes<T>(bool inherit)
        {
            return fi.Attributes<T>().ToArray();
            //return ClassHelper.GetAttributes<T>(fi, inherit);
        }

        public override bool HasAttribute<T>(bool inherit)
        {
            return fi.HasAttribute<T>();
            //return ClassHelper.HasAttribute<T>(fi, inherit);
        }

        public override bool HasAttribute<T>(bool inherit, out T attribute)
        {
            attribute = fi.Attribute<T>();
            return attribute != null;
            //return ClassHelper.HasAttribute<T>(fi, inherit, out attribute);
        }

        public override void SetValue(object obj, object value)
        {
            fi.SetValue(obj, value);
        }

        public override object GetValue(object obj)
        {
            return fi.GetValue(obj);
        }

        public override void EmitGet(ILGenerator il)
        {
            il.Emit(OpCodes.Ldfld, fi);
        }

        public override void EmitSet(ILGenerator il)
        {
            il.Emit(OpCodes.Stfld, fi);
        }
    }

    #endregion

    #region PropertyAdapter

    /// <summary>
    /// 属性成员适配器
    /// </summary>
    internal class PropertyAdapter : MemberAdapter
    {
        protected PropertyInfo pi;

        public PropertyAdapter(PropertyInfo pi)
        {
            this.pi = pi;
        }

        public override Type MemberType
        {
            get { return this.pi.PropertyType; }
        }

        public MethodInfo SetMethod
        {
            get { return pi.GetSetMethod(false); }
        }

        public MethodInfo GetMethod
        {
            get { return pi.GetGetMethod(false); }
        }

        public PropertyInfo PropertyInfo
        {
            get { return pi; }
        }

        public override MemberInfo MemberInfo
        {
            get { return pi; }
        }

        public override bool IsProperty
        {
            get { return true; }
        }

        public override string Name
        {
            get { return this.pi.Name; }
        }

        public override T GetAttribute<T>(bool inherit)
        {
            return pi.Attribute<T>();
            //return ClassHelper.GetAttribute<T>(pi, inherit);
        }

        public override T[] GetAttributes<T>(bool inherit)
        {
            return pi.Attributes<T>().ToArray();
            //return ClassHelper.GetAttributes<T>(pi, inherit);
        }

        public override bool HasAttribute<T>(bool inherit)
        {
            return pi.HasAttribute<T>();
            //return ClassHelper.HasAttribute<T>(pi, inherit);
        }

        public override bool HasAttribute<T>(bool inherit, out T attribute)
        {
            attribute = pi.Attribute<T>();
            return attribute != null;
            //return ClassHelper.HasAttribute<T>(pi, inherit, out attribute);
        }

        public override void SetValue(object obj, object value)
        {
            this.pi.SetValue(obj, value, null);
        }

        public override object GetValue(object obj)
        {
            return this.pi.GetValue(obj, null);
        }

        public override void EmitGet(ILGenerator il)
        {
            il.Emit(OpCodes.Callvirt, pi.GetGetMethod());
        }

        public override void EmitSet(ILGenerator il)
        {
            il.Emit(OpCodes.Callvirt, pi.GetSetMethod());
        }
    }

    #endregion

    #region MethodAdapter

    internal class MethodAdapter : MemberAdapter
    {
        protected MethodInfo mi;

        public MethodAdapter(MethodInfo mi)
        {
            this.mi = mi;
        }

        public override string Name
        {
            get { return this.mi.Name; }
        }

        public override Type MemberType
        {
            get { return this.mi.ReturnType; }
        }

        public override bool IsProperty
        {
            get { return false; }
        }

        public override MemberInfo MemberInfo
        {
            get { return this.mi; }
        }

        public override T[] GetAttributes<T>(bool inherit)
        {
            return mi.Attributes<T>().ToArray();
            //return ClassHelper.GetAttributes<T>(mi, inherit);
        }

        public override T GetAttribute<T>(bool inherit)
        {
            return mi.Attribute<T>();
            //return ClassHelper.GetAttribute<T>(mi, inherit);
        }

        public override bool HasAttribute<T>(bool inherit)
        {
            return mi.HasAttribute<T>();
            //return ClassHelper.HasAttribute<T>(mi, inherit);
        }

        public override bool HasAttribute<T>(bool inherit, out T attribute)
        {
            attribute = mi.Attribute<T>();
            return attribute != null;
            //return ClassHelper.HasAttribute<T>(mi, inherit, out attribute);
        }

        public override void SetValue(object obj, object value)
        {
            throw new NotSupportedException("The method or operation is not supported.");
        }

        public override object GetValue(object obj)
        {
            throw new NotSupportedException("The method or operation is not supported.");
        }

        public override void EmitSet(ILGenerator il)
        {
            throw new NotSupportedException("The method or operation is not supported.");
        }

        public override void EmitGet(ILGenerator il)
        {
            throw new NotSupportedException("The method or operation is not supported.");
        }
    }

    #endregion

    #region ConstructorAdapter

    internal class ConstructorAdapter : MemberAdapter
    {
        protected ConstructorInfo ci;

        public ConstructorAdapter(ConstructorInfo ci)
        {
            this.ci = ci;
        }

        public override string Name
        {
            get { return this.ci.Name; }
        }

        public override Type MemberType
        {
            get { return this.ci.ReflectedType; }
        }

        public override bool IsProperty
        {
            get { return false; }
        }

        public override MemberInfo MemberInfo
        {
            get { return this.ci; }
        }

        public override T[] GetAttributes<T>(bool inherit)
        {
            return ci.Attributes<T>().ToArray();
            //return ClassHelper.GetAttributes<T>(this.ci, inherit);
        }

        public override T GetAttribute<T>(bool inherit)
        {
            return ci.Attribute<T>();
            //return ClassHelper.GetAttribute<T>(this.ci, inherit);
        }

        public override bool HasAttribute<T>(bool inherit)
        {
            return ci.HasAttribute<T>();
            //return ClassHelper.HasAttribute<T>(this.ci, inherit);
        }

        public override bool HasAttribute<T>(bool inherit, out T attribute)
        {
            attribute = ci.Attribute<T>();
            return attribute != null;
            //return ClassHelper.HasAttribute<T>(this.ci, inherit, out attribute);
        }

        public override void SetValue(object obj, object value)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override object GetValue(object obj)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void EmitSet(ILGenerator il)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void EmitGet(ILGenerator il)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }

    #endregion

    #region UnsignedPropertyAdapter

    internal class UnsignedPropertyAdapter : PropertyAdapter
    {
        public UnsignedPropertyAdapter(PropertyInfo pi)
            : base(pi)
        {
        }

        public override void SetValue(object obj, object value)
        {
            if (pi.PropertyType == typeof(ulong))
            {
                pi.SetValue(obj, (ulong)(long)value, null);
            }
            else if (pi.PropertyType == typeof(uint))
            {
                pi.SetValue(obj, (uint)(int)value, null);
            }
            else if (pi.PropertyType == typeof(ushort))
            {
                pi.SetValue(obj, (ushort)(short)value, null);
            }
        }
    }

    #endregion

    #region UnsignedFieldAdapter

    internal class UnsignedFieldAdapter : FieldAdapter
    {
        public UnsignedFieldAdapter(FieldInfo fi)
            : base(fi)
        {
        }

        public override void SetValue(object obj, object value)
        {
            if (fi.FieldType == typeof(ulong))
            {
                fi.SetValue(obj, (ulong)(long)value);
            }
            else if (fi.FieldType == typeof(uint))
            {
                fi.SetValue(obj, (uint)(int)value);
            }
            else if (fi.FieldType == typeof(ushort))
            {
                fi.SetValue(obj, (ushort)(short)value);
            }
        }
    }

    #endregion
}
