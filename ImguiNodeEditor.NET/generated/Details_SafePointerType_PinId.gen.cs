using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct Details_SafePointerType_PinId
    {
        public Details_SafeType_voidptr_PinId _base_Details_SafeType_voidptr_PinId;
    }
    public unsafe partial struct Details_SafePointerType_PinIdPtr
    {
        public Details_SafePointerType_PinId* NativePtr { get; }
        public Details_SafePointerType_PinIdPtr(Details_SafePointerType_PinId* nativePtr) => NativePtr = nativePtr;
        public Details_SafePointerType_PinIdPtr(IntPtr nativePtr) => NativePtr = (Details_SafePointerType_PinId*)nativePtr;
        public static implicit operator Details_SafePointerType_PinIdPtr(Details_SafePointerType_PinId* nativePtr) => new Details_SafePointerType_PinIdPtr(nativePtr);
        public static implicit operator Details_SafePointerType_PinId* (Details_SafePointerType_PinIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator Details_SafePointerType_PinIdPtr(IntPtr nativePtr) => new Details_SafePointerType_PinIdPtr(nativePtr);
        public ref Details_SafeType_voidptr_PinId _base_Details_SafeType_voidptr_PinId => ref Unsafe.AsRef<Details_SafeType_voidptr_PinId>(&NativePtr->_base_Details_SafeType_voidptr_PinId);
    }
}
