using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct Details_SafePointerType_NodeId
    {
        public Details_SafeType_voidptr_NodeId _base_Details_SafeType_voidptr_NodeId;
    }
    public unsafe partial struct Details_SafePointerType_NodeIdPtr
    {
        public Details_SafePointerType_NodeId* NativePtr { get; }
        public Details_SafePointerType_NodeIdPtr(Details_SafePointerType_NodeId* nativePtr) => NativePtr = nativePtr;
        public Details_SafePointerType_NodeIdPtr(IntPtr nativePtr) => NativePtr = (Details_SafePointerType_NodeId*)nativePtr;
        public static implicit operator Details_SafePointerType_NodeIdPtr(Details_SafePointerType_NodeId* nativePtr) => new Details_SafePointerType_NodeIdPtr(nativePtr);
        public static implicit operator Details_SafePointerType_NodeId* (Details_SafePointerType_NodeIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator Details_SafePointerType_NodeIdPtr(IntPtr nativePtr) => new Details_SafePointerType_NodeIdPtr(nativePtr);
        public ref Details_SafeType_voidptr_NodeId _base_Details_SafeType_voidptr_NodeId => ref Unsafe.AsRef<Details_SafeType_voidptr_NodeId>(&NativePtr->_base_Details_SafeType_voidptr_NodeId);
    }
}
