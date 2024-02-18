using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct LinkId
    {
        public Details_SafePointerType_LinkId _base_Details_SafePointerType_LinkId;
    }
    public unsafe partial struct LinkIdPtr
    {
        public LinkId* NativePtr { get; }
        public LinkIdPtr(LinkId* nativePtr) => NativePtr = nativePtr;
        public LinkIdPtr(IntPtr nativePtr) => NativePtr = (LinkId*)nativePtr;
        public static implicit operator LinkIdPtr(LinkId* nativePtr) => new LinkIdPtr(nativePtr);
        public static implicit operator LinkId* (LinkIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator LinkIdPtr(IntPtr nativePtr) => new LinkIdPtr(nativePtr);
        public ref Details_SafePointerType_LinkId _base_Details_SafePointerType_LinkId => ref Unsafe.AsRef<Details_SafePointerType_LinkId>(&NativePtr->_base_Details_SafePointerType_LinkId);
    }
}
