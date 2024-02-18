using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct Details_SafeType_voidptr_PinId
    {
        public void* m_Value;
    }
    public unsafe partial struct Details_SafeType_voidptr_PinIdPtr
    {
        public Details_SafeType_voidptr_PinId* NativePtr { get; }
        public Details_SafeType_voidptr_PinIdPtr(Details_SafeType_voidptr_PinId* nativePtr) => NativePtr = nativePtr;
        public Details_SafeType_voidptr_PinIdPtr(IntPtr nativePtr) => NativePtr = (Details_SafeType_voidptr_PinId*)nativePtr;
        public static implicit operator Details_SafeType_voidptr_PinIdPtr(Details_SafeType_voidptr_PinId* nativePtr) => new Details_SafeType_voidptr_PinIdPtr(nativePtr);
        public static implicit operator Details_SafeType_voidptr_PinId* (Details_SafeType_voidptr_PinIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator Details_SafeType_voidptr_PinIdPtr(IntPtr nativePtr) => new Details_SafeType_voidptr_PinIdPtr(nativePtr);
        public IntPtr m_Value { get => (IntPtr)NativePtr->m_Value; set => NativePtr->m_Value = (void*)value; }
        public IntPtr Get(ref Details_SafeType_voidptr_PinId __self)
        {
            fixed (Details_SafeType_voidptr_PinId* native___self = &__self)
            {
                void* ret = AxNodeEditorNative.axNodeEditorDetails_SafeType_voidptr_axNodeEditor_PinId_Get(native___self);
                return (IntPtr)ret;
            }
        }
    }
}
