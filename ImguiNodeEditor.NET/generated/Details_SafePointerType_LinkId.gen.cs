using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct Details_SafePointerType_LinkId
    {
        public Details_SafeType_voidptr_LinkId _base_Details_SafeType_voidptr_LinkId;
    }
    public unsafe partial struct Details_SafePointerType_LinkIdPtr
    {
        public Details_SafePointerType_LinkId* NativePtr { get; }
        public Details_SafePointerType_LinkIdPtr(Details_SafePointerType_LinkId* nativePtr) => NativePtr = nativePtr;
        public Details_SafePointerType_LinkIdPtr(IntPtr nativePtr) => NativePtr = (Details_SafePointerType_LinkId*)nativePtr;
        public static implicit operator Details_SafePointerType_LinkIdPtr(Details_SafePointerType_LinkId* nativePtr) => new Details_SafePointerType_LinkIdPtr(nativePtr);
        public static implicit operator Details_SafePointerType_LinkId* (Details_SafePointerType_LinkIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator Details_SafePointerType_LinkIdPtr(IntPtr nativePtr) => new Details_SafePointerType_LinkIdPtr(nativePtr);
        public ref Details_SafeType_voidptr_LinkId _base_Details_SafeType_voidptr_LinkId => ref Unsafe.AsRef<Details_SafeType_voidptr_LinkId>(&NativePtr->_base_Details_SafeType_voidptr_LinkId);
    }
}
