using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct PinId
    {
        public Details_SafePointerType_PinId _base_Details_SafePointerType_PinId;
    }
    public unsafe partial struct PinIdPtr
    {
        public PinId* NativePtr { get; }
        public PinIdPtr(PinId* nativePtr) => NativePtr = nativePtr;
        public PinIdPtr(IntPtr nativePtr) => NativePtr = (PinId*)nativePtr;
        public static implicit operator PinIdPtr(PinId* nativePtr) => new PinIdPtr(nativePtr);
        public static implicit operator PinId* (PinIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator PinIdPtr(IntPtr nativePtr) => new PinIdPtr(nativePtr);
        public ref Details_SafePointerType_PinId _base_Details_SafePointerType_PinId => ref Unsafe.AsRef<Details_SafePointerType_PinId>(&NativePtr->_base_Details_SafePointerType_PinId);
    }
}
