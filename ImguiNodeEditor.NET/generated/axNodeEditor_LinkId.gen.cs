using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct axNodeEditor_LinkId
    {
    }
    public unsafe partial struct axNodeEditor_LinkIdPtr
    {
        public axNodeEditor_LinkId* NativePtr { get; }
        public axNodeEditor_LinkIdPtr(axNodeEditor_LinkId* nativePtr) => NativePtr = nativePtr;
        public axNodeEditor_LinkIdPtr(IntPtr nativePtr) => NativePtr = (axNodeEditor_LinkId*)nativePtr;
        public static implicit operator axNodeEditor_LinkIdPtr(axNodeEditor_LinkId* nativePtr) => new axNodeEditor_LinkIdPtr(nativePtr);
        public static implicit operator axNodeEditor_LinkId* (axNodeEditor_LinkIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator axNodeEditor_LinkIdPtr(IntPtr nativePtr) => new axNodeEditor_LinkIdPtr(nativePtr);
    }
}
