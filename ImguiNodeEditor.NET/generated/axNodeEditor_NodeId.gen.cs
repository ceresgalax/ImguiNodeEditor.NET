using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct axNodeEditor_NodeId
    {
    }
    public unsafe partial struct axNodeEditor_NodeIdPtr
    {
        public axNodeEditor_NodeId* NativePtr { get; }
        public axNodeEditor_NodeIdPtr(axNodeEditor_NodeId* nativePtr) => NativePtr = nativePtr;
        public axNodeEditor_NodeIdPtr(IntPtr nativePtr) => NativePtr = (axNodeEditor_NodeId*)nativePtr;
        public static implicit operator axNodeEditor_NodeIdPtr(axNodeEditor_NodeId* nativePtr) => new axNodeEditor_NodeIdPtr(nativePtr);
        public static implicit operator axNodeEditor_NodeId* (axNodeEditor_NodeIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator axNodeEditor_NodeIdPtr(IntPtr nativePtr) => new axNodeEditor_NodeIdPtr(nativePtr);
    }
}
