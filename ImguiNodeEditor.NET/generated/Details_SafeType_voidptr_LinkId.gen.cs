using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct Details_SafeType_voidptr_LinkId
    {
        public void* m_Value;
    }
    public unsafe partial struct Details_SafeType_voidptr_LinkIdPtr
    {
        public Details_SafeType_voidptr_LinkId* NativePtr { get; }
        public Details_SafeType_voidptr_LinkIdPtr(Details_SafeType_voidptr_LinkId* nativePtr) => NativePtr = nativePtr;
        public Details_SafeType_voidptr_LinkIdPtr(IntPtr nativePtr) => NativePtr = (Details_SafeType_voidptr_LinkId*)nativePtr;
        public static implicit operator Details_SafeType_voidptr_LinkIdPtr(Details_SafeType_voidptr_LinkId* nativePtr) => new Details_SafeType_voidptr_LinkIdPtr(nativePtr);
        public static implicit operator Details_SafeType_voidptr_LinkId* (Details_SafeType_voidptr_LinkIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator Details_SafeType_voidptr_LinkIdPtr(IntPtr nativePtr) => new Details_SafeType_voidptr_LinkIdPtr(nativePtr);
        public IntPtr m_Value { get => (IntPtr)NativePtr->m_Value; set => NativePtr->m_Value = (void*)value; }
        public IntPtr Get(ref Details_SafeType_voidptr_LinkId __self)
        {
            fixed (Details_SafeType_voidptr_LinkId* native___self = &__self)
            {
                void* ret = AxNodeEditorNative.axNodeEditorDetails_SafeType_voidptr_axNodeEditor_LinkId_Get(native___self);
                return (IntPtr)ret;
            }
        }
    }
}
