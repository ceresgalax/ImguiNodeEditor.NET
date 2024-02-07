using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct axNodeEditorDetails_SafePointerType_axNodeEditor_PinId
    {
    }
    public unsafe partial struct axNodeEditorDetails_SafePointerType_axNodeEditor_PinIdPtr
    {
        public axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* NativePtr { get; }
        public axNodeEditorDetails_SafePointerType_axNodeEditor_PinIdPtr(axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* nativePtr) => NativePtr = nativePtr;
        public axNodeEditorDetails_SafePointerType_axNodeEditor_PinIdPtr(IntPtr nativePtr) => NativePtr = (axNodeEditorDetails_SafePointerType_axNodeEditor_PinId*)nativePtr;
        public static implicit operator axNodeEditorDetails_SafePointerType_axNodeEditor_PinIdPtr(axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* nativePtr) => new axNodeEditorDetails_SafePointerType_axNodeEditor_PinIdPtr(nativePtr);
        public static implicit operator axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* (axNodeEditorDetails_SafePointerType_axNodeEditor_PinIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator axNodeEditorDetails_SafePointerType_axNodeEditor_PinIdPtr(IntPtr nativePtr) => new axNodeEditorDetails_SafePointerType_axNodeEditor_PinIdPtr(nativePtr);
    }
}
