using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct Details_SafeType_voidptr_NodeId
    {
        public void* m_Value;
    }
    public unsafe partial struct Details_SafeType_voidptr_NodeIdPtr
    {
        public Details_SafeType_voidptr_NodeId* NativePtr { get; }
        public Details_SafeType_voidptr_NodeIdPtr(Details_SafeType_voidptr_NodeId* nativePtr) => NativePtr = nativePtr;
        public Details_SafeType_voidptr_NodeIdPtr(IntPtr nativePtr) => NativePtr = (Details_SafeType_voidptr_NodeId*)nativePtr;
        public static implicit operator Details_SafeType_voidptr_NodeIdPtr(Details_SafeType_voidptr_NodeId* nativePtr) => new Details_SafeType_voidptr_NodeIdPtr(nativePtr);
        public static implicit operator Details_SafeType_voidptr_NodeId* (Details_SafeType_voidptr_NodeIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator Details_SafeType_voidptr_NodeIdPtr(IntPtr nativePtr) => new Details_SafeType_voidptr_NodeIdPtr(nativePtr);
        public IntPtr m_Value { get => (IntPtr)NativePtr->m_Value; set => NativePtr->m_Value = (void*)value; }
        public IntPtr Get(ref Details_SafeType_voidptr_NodeId __self)
        {
            fixed (Details_SafeType_voidptr_NodeId* native___self = &__self)
            {
                void* ret = AxNodeEditorNative.axNodeEditorDetails_SafeType_voidptr_axNodeEditor_NodeId_Get(native___self);
                return (IntPtr)ret;
            }
        }
    }
}
