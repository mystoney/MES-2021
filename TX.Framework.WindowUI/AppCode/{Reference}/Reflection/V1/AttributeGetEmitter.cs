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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Reflection.Emit
{
    internal class AttributeGetEmitter : AttributeEmitter
    {
        public AttributeGetEmitter(CallInfo_ callInfo, DelegateCache cache)
            : base(callInfo, cache)
        {
        }

        protected override object Invoke(Delegate action)
        {
            if (CallInfo.IsStatic)
            {
                var invocation = (StaticAttributeGetter)action;
                return invocation.Invoke();
            }
            else
            {
                var invocation = (AttributeGetter)action;
                return invocation.Invoke(CallInfo.Target);
            }
        }

        protected override Delegate CreateDelegate()
        {
            MemberInfo member = GetAttribute(CallInfo);
            var method = CallInfo.IsStatic ?
                CreateDynamicMethod("getter", CallInfo.TargetType, Constants.ObjectType, null) :
                CreateDynamicMethod("getter", CallInfo.TargetType, Constants.ObjectType, new[] { Constants.ObjectType });

            ILGenerator generator = method.GetILGenerator();

            if (!CallInfo.IsStatic)
            {
                generator.Emit(OpCodes.Ldarg_0);
                generator.Emit(OpCodes.Castclass, CallInfo.TargetType);
            }

            if (member.MemberType == MemberTypes.Field)
            {
                var field = member as FieldInfo;
                generator.Emit(CallInfo.IsStatic ? OpCodes.Ldsfld : OpCodes.Ldfld, field);
                BoxIfValueType(generator, field.FieldType);
            }
            else
            {
                PropertyInfo prop = member as PropertyInfo;
                MethodInfo getMethod = GetPropertyGetMethod();
                generator.Emit(CallInfo.IsStatic ? OpCodes.Call : OpCodes.Callvirt, getMethod);
                BoxIfValueType(generator, prop.PropertyType);
            }

            generator.Emit(OpCodes.Ret);

            return CallInfo.IsStatic ?
                method.CreateDelegate(typeof(StaticAttributeGetter)) :
                method.CreateDelegate(typeof(AttributeGetter));
        }
    }
}
