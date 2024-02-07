using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct axNodeEditor_PinId
    {
    }
    public unsafe partial struct axNodeEditor_PinIdPtr
    {
        public axNodeEditor_PinId* NativePtr { get; }
        public axNodeEditor_PinIdPtr(axNodeEditor_PinId* nativePtr) => NativePtr = nativePtr;
        public axNodeEditor_PinIdPtr(IntPtr nativePtr) => NativePtr = (axNodeEditor_PinId*)nativePtr;
        public static implicit operator axNodeEditor_PinIdPtr(axNodeEditor_PinId* nativePtr) => new axNodeEditor_PinIdPtr(nativePtr);
        public static implicit operator axNodeEditor_PinId* (axNodeEditor_PinIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator axNodeEditor_PinIdPtr(IntPtr nativePtr) => new axNodeEditor_PinIdPtr(nativePtr);
    }
}
