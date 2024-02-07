using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId
    {
    }
    public unsafe partial struct axNodeEditorDetails_SafePointerType_axNodeEditor_NodeIdPtr
    {
        public axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* NativePtr { get; }
        public axNodeEditorDetails_SafePointerType_axNodeEditor_NodeIdPtr(axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* nativePtr) => NativePtr = nativePtr;
        public axNodeEditorDetails_SafePointerType_axNodeEditor_NodeIdPtr(IntPtr nativePtr) => NativePtr = (axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId*)nativePtr;
        public static implicit operator axNodeEditorDetails_SafePointerType_axNodeEditor_NodeIdPtr(axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* nativePtr) => new axNodeEditorDetails_SafePointerType_axNodeEditor_NodeIdPtr(nativePtr);
        public static implicit operator axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* (axNodeEditorDetails_SafePointerType_axNodeEditor_NodeIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator axNodeEditorDetails_SafePointerType_axNodeEditor_NodeIdPtr(IntPtr nativePtr) => new axNodeEditorDetails_SafePointerType_axNodeEditor_NodeIdPtr(nativePtr);
    }
}
